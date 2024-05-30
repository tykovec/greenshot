using System.Windows.Forms;
using Greenshot.Base.IniFile;
using Greenshot.Plugin.BarcodeDecoder.Forms;

namespace Greenshot.Plugin.BarcodeDecoder
{
    [IniSection("BarcodeDecoder", Description = "Decode barcode from image")]
    public class BarcodeDecoderConfiguration : IniSection
    {
        [IniProperty(nameof(MaxLastValuesSize), Description = "Max size of last values", DefaultValue = "-1")]
        public int MaxLastValuesSize { get; set; }

        public bool ShowConfigDialog() => new SettingsForm().ShowDialog() == DialogResult.OK;
    }
}
