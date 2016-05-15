using BrawlManagerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocumentationGenerator.Models {
    public class MainModel {
        public IList<CEPStage> Stages { get; set; }
        public StageDependentSongLoader Sdsl { get; set; }

    }
}