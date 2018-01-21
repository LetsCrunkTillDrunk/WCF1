using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDisk
{
    public class MyDiskInfo : IMyDisk
    {
        public string FreeSpace(string s)
        {
            if (Char.IsLetter(s[0]))
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                DriveInfo d = drives.Where(i => Char.ToLower(i.Name[0]) == Char.ToLower(s[0])).FirstOrDefault();
                if (d != null)
                {
                    return "Total free space = " + d.TotalFreeSpace.ToString();
                }
                return "Wrong disk";

            }
            return "Wrong request";
        }

        public string TotalSpace(string s)
        {
            if (Char.IsLetter(s[0]))
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                DriveInfo d = drives.Where(i => Char.ToLower(i.Name[0]) == Char.ToLower(s[0])).FirstOrDefault();
                if (d != null)
                {
                    return "Total size = " + d.TotalSize.ToString();
                }
                return "Wrong disk";

            }
            return "Wrong request";
        }
    }
}
