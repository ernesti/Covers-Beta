using System;
using System.Collections;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using FILETIME = System.Runtime.InteropServices.ComTypes.FILETIME;

public static class SimpleClass
{
    //Импортируем необходимые методы из kernel32
    [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr FindFirstFile(string lpFileName, out WIN32_FIND_DATA lpFindFileData);

    [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern bool FindNextFile(IntPtr hFindFile, out WIN32_FIND_DATA lpFindFileData);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool FindClose(IntPtr hFindFile);

    //Объявим структуру для сохранения информации о текущем файле или папке
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    private struct WIN32_FIND_DATA
    {
        public FileAttributes dwFileAttributes;
        public FILETIME ftCreationTime;
        public FILETIME ftLastAccessTime;
        public FILETIME ftLastWriteTime;
        public int nFileSizeHigh;
        public int nFileSizeLow;
        public int dwReserved0;
        public int dwReserved1;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
        public string cFileName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
        public string cAlternate;
    }

    //Метод получения количества файлов в заданной директории.
    //По желанию может обрабатывать подкаталоги.
    public static int GetNumOfFiles(string path, bool withSubDirectories)
    {
        if (!path.EndsWith("\\"))
            path += "\\";
        int num = 0;
        WIN32_FIND_DATA findData;
        IntPtr findHandle = FindFirstFile(path + "*", out findData);
        if (findHandle == new IntPtr(-1))
            return num;
        try
        {
            while (FindNextFile(findHandle, out findData))
                if (findData.cFileName == "." || findData.cFileName == "..")
                    continue;
                else if ((findData.dwFileAttributes & FileAttributes.Directory) != 0 && withSubDirectories)
                    num += GetNumOfFiles(path + findData.cFileName, withSubDirectories);
                else num++;
                
        }
        finally
        {
            FindClose(findHandle);
        }
        return num;
    }
}