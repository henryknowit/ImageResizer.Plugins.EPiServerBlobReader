﻿using ImageResizer.Plugins.EPiServer;

namespace SampleAlloy.Business
{
    public class PictureProfiles
    {
        public static PictureProfile SampleImage = new PictureProfile
                                                   {
                                                       DefaultWidth = 992,
                                                       //SrcSetSizes = new[]
                                                       //              {
                                                       //                  "(max-width: 480px) 100vw",
                                                       //                  "(max-width: 768px) 80vw",
                                                       //                  "(max-width: 992px) 50vw",
                                                       //                  "(max-width: 1200px) 25vw",
                                                       //                  "768px"
                                                       //              },
                                                       SrcSetWidths = new[] { 480, 768, 992, 1200 }
                                                   };

        public static PictureProfile BootstrapGrid = new PictureProfile
                                                     {
                                                         DefaultWidth = 576,
                                                         SrcMedias = new[]
                                                                     {
                                                                         "(min-width: 1200px)",
                                                                         "(min-width: 992px)",
                                                                         "(min-width: 768px)",
                                                                         "(min-width: 576px)",
                                                                         "(max-width: 575.98px)"
                                                                     },
                                                         SrcSetWidths = new[]
                                                                        {
                                                                            1200,
                                                                            1200,
                                                                            992,
                                                                            768,
                                                                            576
                                                                        }
                                                     };
    }
}
