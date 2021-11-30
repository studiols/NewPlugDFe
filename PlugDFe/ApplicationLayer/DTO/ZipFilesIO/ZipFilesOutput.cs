using System.Collections.Generic;
using System.IO;

namespace PlugDFe.ApplicationLayer.DTO.ZipFilesIO
{
    public class ZipFilesOutput
    {
        public ZipFilesOutput(bool success, string msg, List<string> zipPaths, List<FileInfo> validFilesAfterFilter)
        {
            Success = success;
            Msg = msg;
            ZipPaths = zipPaths;
            ValidFilesAfterFilter = validFilesAfterFilter;
        }

        public List<string> ZipPaths { get; set; }
        public List<FileInfo> ValidFilesAfterFilter { get; set; }
        public bool Success { get; set; }
        public string Msg { get; set; }
    }
}
