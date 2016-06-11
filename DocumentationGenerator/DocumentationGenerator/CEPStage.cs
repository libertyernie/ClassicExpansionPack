using BrawlLib.SSBB;
using BrawlManagerLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace DocumentationGenerator {
    public class CEPStage {
        private string _filename;
        public string Filename {
            get {
                return _filename;
            }
            set {
                _filename = value;
                if (!_filename.EndsWith(".pac", StringComparison.InvariantCultureIgnoreCase)) {
                    _filename += ".pac";
                }
            }
        }

        public string Source { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

		public string SongFilename { get; set; }

		public string SongTitle { get; set; }

		public string SongName { get; set; }

		public string BrawlVaultLink { get; set; }

        public string DirectLink { get; set; }

        public string Link {
            get {
                return BrawlVaultLink ?? DirectLink;
            }
        }

        public bool Imported { get; set; }

        public string Notes { get; set; }

        public bool Alternate {
            get {
                return Filename.Contains("_");
            }
        }

        private Stage _stage;
        public Stage Stage {
            get {
                if (_stage != null) return _stage;

                if (Filename.StartsWith("STGCUSTOM")) {
                    int c = Convert.ToInt32(Filename.Substring(9, 2), 16);
                    _stage = new Stage((byte)(c + 0x3F), Filename, "st_custom" + c + ".rel", "custom");
                    return _stage;
                }

                return _stage = Stage.Stages.Where(s => s.ContainsPac(Filename)).FirstOrDefault();
            }
        }

        public string ModuleBase { get; set; }

        public byte[] PngIcon { get; set; }
    }
}