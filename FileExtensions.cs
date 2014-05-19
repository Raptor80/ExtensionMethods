using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ExtensionMethods
{
    public static class FileExtensions
    {
        // Usage: dInfo.GetFilesByExtensions(".jpg",".exe",".gif");
        public static IEnumerable<FileInfo> GetFilesByExtensions(this DirectoryInfo dir, params string[] extensions)
        {
            if (extensions == null) throw new ArgumentNullException("extensions");
            var files = dir.EnumerateFiles();
            return files.Where(f => extensions.Contains(f.Extension));
        }
    }
}
