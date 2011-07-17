using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Xml;
using System.Net;
using Media;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
namespace CoverArtDownload
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // API Last.fm
        string API_key      = "a02ca035e8ad67b7c8fbfe985ea0f9c2";
        string API_username = "cjmobix";
        string API_url      = "http://ws.audioscrobbler.com/2.0/";

        string LyricsAPI_key = "1cab0e79c6422fe9beea388702fc8ea2";

        int fid = 0;
        int aid = 0;
        bool astate = false;

        bool proceed = true;

        int Mplayerid;

        // Main arrays
        string[,] files = new string[1,5];
        string[,] albums = new string[1,5];

        // string[,] files;
        // string[,] albums;

        string currentFile = "";
        string currentCover = "";

        int filesTotal = 0;
        int filesAdded = 0;

        /// <summary>
        /// Возвращает URL к обложке
        /// </summary>
        /// <param name="album">Название альбома</param>
        /// <param name="artist">Исполнитель</param>
        /// <returns>URL обложки (если есть)</returns>
        public string AlbumGetCover(string album, string artist)
        {
            Current(artist + " — " + album);

            string result = null;

            // Формируем запрос к API
            string API_request = API_url + "?method=album.getinfo&api_key=" + API_key + "&artist=" + artist + "&album=" + album + "&username=" + API_username;


            // Ответ приходит в XML
            // Получаем и обрабатываем
            XmlDocument API_response = new XmlDocument();
            try
            { 
                API_response.Load(API_request);
                
                XmlNode node = API_response.DocumentElement;

                // Album art
                XmlNodeList nodes = node.SelectNodes("/lfm/album/image[@size='mega']");
                if (nodes.Count < 1)
                    nodes = node.SelectNodes("/lfm/album/image[@size='extralarge']");
                if (nodes.Count < 1)
                    nodes = node.SelectNodes("/lfm/album/image[@size='large']");

                result = nodes[0].InnerText;
            }
            catch (Exception e) { Error("XMLGetError" + e.Message); }

            return result;
        }


        /// <summary>
        /// Функция скачивает файл в асинхронном потоке
        /// </summary>
        /// <param name="url">URL</param>
        /// <param name="filename">Куда сохранять</param>
        public void Download(string url, string filename)
        {
             try
             {
                 WebClient webClient = new WebClient();
                 webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(webClient_DownloadFileCompleted);
                 webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(webClient_DownloadProgressChanged);
                 webClient.DownloadFileAsync(new Uri(url), filename);
                 proceed = false;
             }
             catch (Exception ex)
             {
                 Error("Ошибка загрузки: " + ex.Message);
             }
         }

        public void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Status(String.Format("Загрузка: {2}% из {1}кБ", e.BytesReceived, (e.TotalBytesToReceive / 1024), e.ProgressPercentage));
            dlProgress.Visible = true;
            dlProgress.Value = e.ProgressPercentage;
        }

        public void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                Status("Загрузок нет");
                // assignCover(currentFile, currentCover);
            }
            else
            {
                Error("Ошибка загрузки: " + e.Error.Message);
            }
            dlProgress.Value = 0;
            proceed = true;
            
        }
        
        // Обработка файлов и папок
        public void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
            Application.DoEvents();
        }

        public void ProcessFile(string path)
        {
            filesAdded++;
            Application.DoEvents();
            if (Path.GetExtension(path) == ".mp3")
            {
                
                // Добавляем в массив только если есть данные
                try
                {
                    TagLib.File file = TagLib.File.Create(path);

                    if (file.Tag.Album != null)
                    {
                        files[fid, 0] = path;
                        files[fid, 1] = file.Tag.Album;
                        if (file.Tag.Performers.Length > 0)
                            files[fid, 2] = file.Tag.Performers[file.Tag.Performers.Length - 1];

                        files[fid, 3] = file.Tag.Title;

                        tracksLst.Items.Add(files[fid, 2] + " — " + file.Tag.Title + " (" + file.Tag.Album + ")", 3);

                       

                        // добавляем в альбомы
                        for (int i = 0; i <= aid; i++)
                        {
                            if (albums[i,0] == file.Tag.Album)
                            {
                                // Такой альбом уже есть
                                astate = true;
                            }
                        }

                        if (!astate)
                        {
                            albums[aid,0] = file.Tag.Album;
                            if (file.Tag.Performers.Length > 0)
                                albums[aid,1] = file.Tag.Performers[file.Tag.Performers.Length - 1];
                            albums[aid, 2] = Path.GetDirectoryName(path);

                            // tracksLst.Items.Add(albums[aid, 1] + " - " + albums[aid, 0], 0);
                            
                            aid++;
                        }

                        astate = false;
                        fid++;
                    }
                }
                catch (Exception e)
                {
                    Error("Ошибка обработки: "+e);
                }
            }
            


            // обновляем прогрессбар
            double ratio = (Convert.ToDouble(filesAdded) / Convert.ToDouble(filesTotal));
            int percentage = Convert.ToInt16(ratio * 100);
            dlProgress.Value = percentage;
            Current(String.Format("Добавляю {0} из {1} ({2}%)", filesAdded, filesTotal, percentage));
        }

        /// <summary>
        /// Отображает ошибку в статусбаре
        /// </summary>
        /// <param name="mess">Сообщение</param>
        public void Error(string mess)
        {
            errLbl.Visible = true;
            errLbl.Text = mess;
            errTimer.Enabled = true;
            errTimer.Start();
        }

        /// <summary>
        /// Отображает сообщение в статусной строке
        /// </summary>
        /// <param name="mess">Сообщение</param>
        public void Current(string mess)
        {
            currentLbl.Text = mess;
        }

        public void Status(string mess)
        {
            statLbl.Text = mess;
        }

        // Формы
        private void frmMain_Load(object sender, EventArgs e)
        {
            errLbl.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fbd.Description = "Выберите папку с вашей медиатекой.";
            fbd.ShowDialog();
            pathTxt.Text = fbd.SelectedPath;
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            if (pathTxt.Text == "")
            {
                toolStripButton1_Click(goBtn, e);
            }

            if (pathTxt.Text != "")
            {
                clear();
                Current("Обрабатываю файлы…");
                loadPic.Visible = true;
                tracksLst.Visible = false;

                // Считаем количество папок
                filesTotal = SimpleClass.GetNumOfFiles(pathTxt.Text, true);

                ProcessDirectory(pathTxt.Text);

                tracksLst.Visible = true;
                Current("Треки не обрабатываются");
                loadPic.Visible = false;
                dlProgress.Value = 0;

                startBtn.Enabled = true;
            }

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void albumsLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indexes = this.tracksLst.SelectedIndices;
            foreach (int index in indexes)
            {
                artistLbl.Text = files[index, 2];
                albumLbl.Text = files[index, 1];
                titleLbl.Text = files[index, 3];

            }

        }

        private void скачатьОбложкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idx = 99999;
            ListView.SelectedIndexCollection indexes = this.tracksLst.SelectedIndices;

            foreach (int index in indexes)
                idx = index;

            if (idx != 99999)
            {
                string artist, album, path;

                artist = files[idx, 2];
                album = files[idx, 1];
                path = files[idx, 0];

                string dl_path = Path.GetDirectoryName(path) + @"\folder";

                string ext = downloadCover(artist, album, dl_path);

                // здесь надо подождать до выполнения download

                while (!proceed)
                {
                    Thread.Sleep(50);
                    Application.DoEvents();
                }

                if (ext != "")
                {
                    tracksLst.Items[idx].ImageIndex = 1;
                    pictureBox1.ImageLocation = dl_path + ext;
                    currentFile = path;
                    currentCover = dl_path + ext;
                    MessageBox.Show("dloaded");
                }
            }
        }

        /// <summary>
        /// Добавляет к файлу обложку
        /// </summary>
        /// <param name="mp3_path">Путь к MP3 файлу</param>
        /// <param name="cover_path">Путь к обложке</param>
        private void assignCover(string mp3_path, string cover_path)
        {
            try
            {
                // Формируем картинку в кадр Id3v2
                TagLib.Picture pic = new TagLib.Picture(cover_path);
                TagLib.Id3v2.AttachedPictureFrame albumCoverPictFrame = new TagLib.Id3v2.AttachedPictureFrame(pic);
                albumCoverPictFrame.MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg;
                albumCoverPictFrame.Type = TagLib.PictureType.FrontCover;
                TagLib.IPicture[] ipic = { albumCoverPictFrame };

                // Открываем файл
                TagLib.File file = TagLib.File.Create(mp3_path);
                file.Tag.Pictures = ipic;
                file.Save();

                
                


                
            }
            catch (Exception e)
            {
                Error("Ошибка сохранения файла.");
            }
        }

        private string downloadCover(string artist, string album, string path)
        {
            string result = "";

            string uri = AlbumGetCover(album, artist);

            if (uri != null)
            {
                result = Path.GetExtension(uri);
                Download(uri, path + result); 
            }

            return result;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void открытьВПроводникеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int currid = 99999;
            string path = @"C:\";

            ListView.SelectedIndexCollection indexes = this.tracksLst.SelectedIndices;
            foreach (int index in indexes)
            {
                currid = index;
                path = files[index, 0];
            }

            if (currid != 99999)
            {
                // Process.Start(Path.GetDirectoryName(path));
                Process.Start("explorer.exe", "/select," + path);
            }
        }

        private void errTimer_Tick(object sender, EventArgs e)
        {
            errLbl.Visible = false;
            errTimer.Enabled = false;
        }

        private void gbPreviewAlbumArt_Enter(object sender, EventArgs e)
        {

        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            if (Media.Player.GetPlayer().IsPaused())
            {
                Media.Player.GetPlayer().Play(false);
            }
            else
            {
                string tPath = "";
                string tArtist = "";
                string tAlbum = "";
                string tTitle = "";
                int currid = 99999;

                ListView.SelectedIndexCollection indexes = this.tracksLst.SelectedIndices;
                foreach (int index in indexes)
                {
                    currid = index;
                    tPath = files[index, 0];
                    tArtist = files[index, 2];
                    tAlbum = files[index, 1];
                    tTitle = files[index, 3];

                }


                // Если файл уже открыт, то закрываем и открываем новый
                if (currid != 99999)
                {
                    if (tPath != null)
                    {
                        if (Media.Player.GetPlayer().IsOpen())
                        {
                            if (Mplayerid != currid)
                                Media.Player.GetPlayer().Close();
                        }
                        Media.Player.GetPlayer().Open(tPath);
                    }

                    // Показываем название трека
                    playTrackLbl.Text = tArtist + " — " + tTitle;
                }

                if (Media.Player.GetPlayer().IsOpen())
                {
                    Media.Player.GetPlayer().Play(false);
                    playBtn.Image = CoverArtDownload.Properties.Resources.control_play_blue;

                    pauseBtn.Image = CoverArtDownload.Properties.Resources.control_pause;
                }
            }
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            if (Media.Player.GetPlayer().IsPlaying())
            {
                Media.Player.GetPlayer().Pause();

                pauseBtn.Image = CoverArtDownload.Properties.Resources.control_pause_blue;
                playBtn.Image = CoverArtDownload.Properties.Resources.control_play;
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (Media.Player.GetPlayer().IsOpen())
            {
                Media.Player.GetPlayer().Pause();
                Media.Player.GetPlayer().Close();

                playBtn.Image = CoverArtDownload.Properties.Resources.control_play;
                pauseBtn.Image = CoverArtDownload.Properties.Resources.control_pause;

                playTrackLbl.Text = "";
            }
        }

        private void воспроизвестиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playBtn_Click(sender, e);
        }

        private void statLbl_Click(object sender, EventArgs e)
        {
            
        }

        private void clear()
        {
            tracksLst.Items.Clear();
            filesTotal = 0;
            filesAdded = 0;
            Array.Clear(files, 0, files.GetLength(0));
            Array.Clear(albums, 0, albums.GetLength(0));
            fid = 0;
            aid = 0;
            startBtn.Enabled = false;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            // А это самое вкусное
            // самое ответсвенное
            // и сложное

            loadPic.Visible = true;

            string fPath = "";
            string fDir, fArtist, fAlbum, fCoverUri, fCoverPath;

            // Перебираем массив файлов
            
            for (int i = 0; i < files.GetLength(0); i++)
            {
                if (files[i, 0] != null)
                {
                    fPath = files[i, 0];
                    fDir = Path.GetDirectoryName(fPath) + @"\";
                    fAlbum = files[i, 1];
                    fArtist = files[i, 2];

                    Current("Обрабатываю: " + fArtist + " — " + fAlbum);

                    
                    
                    fCoverPath = fDir + GetMd5Hash(fAlbum + fArtist) + ".jpg";
                    
                    // Обрабатываем только те файлы, где есть Artist и Album
                    if ((String.IsNullOrEmpty(fAlbum)) || (String.IsNullOrEmpty(fArtist)))
                    {
                        // Отмечаем как неудача
                        tracksLst.Items[i].ImageIndex = 7;
                    }
                    else
                    {
                        // tracksLst.Items[i].ImageIndex = 8;
                        // Если файл обложки еще не загружен
                        if ( ! File.Exists(fCoverPath))
                        {
                            // Загружаем
                            fCoverUri = AlbumGetCover(fAlbum, fArtist);

                            // Если cover нашелся
                            if ( ! String.IsNullOrEmpty(fCoverUri))
                            {
                                Download(fCoverUri, fCoverPath);

                                // Останавливаем основной поток до загрузки
                                while ( ! proceed)
                                {
                                    Thread.Sleep(50);
                                    Application.DoEvents();
                                }
                            }
                            else
                            {
                                // Отмечаем как неудача
                                tracksLst.Items[i].ImageIndex = 7;
                            }
                        }

                        if (File.Exists(fCoverPath))
                        {
                            // Добавляем кавер к песне
                            assignCover(fPath, fCoverPath);

                            // Отмечаем как загружено
                            tracksLst.Items[i].ImageIndex = 6;
                        }
                    }
                    
                }
                Application.DoEvents();
            }
            loadPic.Visible = false;
            Current("Все обработано");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        static string GetMd5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        static bool VerifyMd5Hash(string input, string hash)
        {
            // Hash the input.
            MD5 md5Hash = MD5.Create();
            string hashOfInput = GetMd5Hash(input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void tracksLst_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Array a = (Array)e.Data.GetData(DataFormats.FileDrop);

                if (a != null)
                {
                    // Extract string from first array element

                    // (ignore all files except first if number of files are dropped).

                    Current("Обрабатываю файлы…");
                    loadPic.Visible = true;
                    tracksLst.Visible = false;

                    foreach (string path in a)
                    {
                        Application.DoEvents();
                        // Добавляем файлы в форму









                        if (Path.GetExtension(path) == ".mp3")
                        {

                            // Добавляем в массив только если есть данные
                            try
                            {
                                TagLib.File file = TagLib.File.Create(path);

                                if (file.Tag.Album != null)
                                {
                                    files[fid, 0] = path;
                                    files[fid, 1] = file.Tag.Album;
                                    if (file.Tag.Performers.Length > 0)
                                        files[fid, 2] = file.Tag.Performers[file.Tag.Performers.Length - 1];

                                    files[fid, 3] = file.Tag.Title;

                                    tracksLst.Items.Add(files[fid, 2] + " — " + file.Tag.Title + " (" + file.Tag.Album + ")", 3);



                                    // добавляем в альбомы
                                    for (int i = 0; i <= aid; i++)
                                    {
                                        if (albums[i, 0] == file.Tag.Album)
                                        {
                                            // Такой альбом уже есть
                                            astate = true;
                                        }
                                    }

                                    if (!astate)
                                    {
                                        albums[aid, 0] = file.Tag.Album;
                                        if (file.Tag.Performers.Length > 0)
                                            albums[aid, 1] = file.Tag.Performers[file.Tag.Performers.Length - 1];
                                        albums[aid, 2] = Path.GetDirectoryName(path);

                                        // tracksLst.Items.Add(albums[aid, 1] + " - " + albums[aid, 0], 0);

                                        aid++;
                                    }

                                    astate = false;
                                    fid++;
                                }
                            }
                            catch (Exception ex)
                            {
                                
                            }
                        }



                    }

                    // Call OpenFile asynchronously.

                    // Explorer instance from which file is dropped is not responding

                    // all the time when DragDrop handler is active, so we need to return

                    // immidiately (especially if OpenFile shows MessageBox).


                   
                    // this.Activate();        // in the case Explorer overlaps this form
                    tracksLst.Visible = true;
                    Current("Треки не обрабатываются");
                    loadPic.Visible = false;
                    dlProgress.Value = 0;

                    startBtn.Enabled = true;
                }
            }
            catch (Exception ex)
            {


            }
            
        }

        private void tracksLst_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
