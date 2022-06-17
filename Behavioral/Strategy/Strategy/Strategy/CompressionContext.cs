using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CompressionContext
    {
        private ICompression _compression;
        public CompressionContext(ICompression compression)
        {
            _compression = compression;
        }

        public void SetStrategy(ICompression Compression)
        {
            _compression = Compression;
        }
        public void CreateArchive(string compressedArchiveFileName)
        {
            _compression.CompressFolder(compressedArchiveFileName);
        }
    }
}
