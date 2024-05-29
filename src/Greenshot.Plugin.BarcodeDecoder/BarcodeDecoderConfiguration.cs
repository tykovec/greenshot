using Greenshot.Base.IniFile;

namespace Greenshot.Plugin.BarcodeDecoder
{
    [IniSection("Barcode", Description = "Barcode parser from image")]
    public class BarcodeDecoderConfiguration : IniSection
    {
        [IniProperty("DisplayImage", Description = "Display image of barcode with parsed value", DefaultValue = "false")]
        public bool DisplayImage { get; set; }
    }
}
