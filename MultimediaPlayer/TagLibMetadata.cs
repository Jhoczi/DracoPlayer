using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using TagLib;

namespace MultimediaPlayer
{
    class TagLibMetadata
    {
        public TagLib.File MetaDataTL { get; private set; }

        public TagLibMetadata(string patch)
        {
            MetaDataTL = TagLib.File.Create($@"{patch}"); 
        }
        
        public Image GetImage()
        {
            MemoryStream ms;
            if (MetaDataTL.Tag.Pictures.Length > 0)
            {
                ms = new MemoryStream(MetaDataTL.Tag.Pictures[0].Data.Data);
                return Image.FromStream(ms);
            }
            return null;
        }
            

    }
}
