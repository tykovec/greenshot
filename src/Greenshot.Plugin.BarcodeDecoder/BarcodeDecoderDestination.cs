using System;
using System.Drawing;
using System.Windows.Forms;
using Greenshot.Base.Controls;
using Greenshot.Base.Core;
using Greenshot.Base.IniFile;
using Greenshot.Base.Interfaces;
using Greenshot.Plugin.BarcodeDecoder.Forms;
using ZXing;

namespace Greenshot.Plugin.BarcodeDecoder
{
    internal class BarcodeDecoderDestination : AbstractDestination
    {
        public override string Designation => "Decode barcode from Image";

        public override string Description => "Decode barcode";

        private BarcodeDecoderResultForm _resultForm = null;

        private Lazy<Image> _displayIcon = new Lazy<Image>(() =>
        {
            var w = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new ZXing.Common.EncodingOptions
                {
                    Height = 16,
                    Width = 16
                }
            };
            return w.Write("1234");
        });

        public override Image DisplayIcon => _displayIcon.Value;

        private static BarcodeDecoderConfiguration config = IniConfig.GetIniSection<BarcodeDecoderConfiguration>();

        private BarcodeDecoderPlugin _plugin;

        public BarcodeDecoderDestination(BarcodeDecoderPlugin greenshotBarcodePlugin)
        {
            _plugin = greenshotBarcodePlugin;
        }

        public override ExportInformation ExportCapture(bool manuallyInitiated, ISurface surface, ICaptureDetails captureDetails)
        {
            var exportInformation = new ExportInformation(Designation, Description);
            var barcodeInfo = default(BarcodeInfo);
            var errorText = string.Empty;
            try
            {
                new PleaseWaitForm().ShowAndWait(Description, "Parsing barcode",
                    delegate ()
                    {
                        var br = new BarcodeReader();
                        if (surface.Image == null)
                        {
                            errorText = "No surface image !";
                        }
                        else
                        {
                            var result = br.Decode(new Bitmap(surface.Image));

                            if (result == null)
                            {
                                errorText = "No barcode found !";
                            }
                            else
                            {
                                barcodeInfo = new BarcodeInfo
                                {
                                    Value = result.Text,
                                    Type = result.BarcodeFormat.ToString()
                                };
                            }
                        }

                    }
                );
                exportInformation.ExportMade = true;
            }
            catch (Exception e)
            {
                errorText = "Decoding failure";
            }

            if (barcodeInfo == null)
            {
                MessageBox.Show(errorText, "Decoded barcode");
            }
            else
            {
                _plugin.DecodedValues.Insert(0, barcodeInfo);

                if (_resultForm == null)
                {
                    _resultForm = new BarcodeDecoderResultForm(_plugin.DecodedValues);
                    _resultForm.FormClosed += (s, e) => _resultForm = null;
                }

                _resultForm.SetResult(barcodeInfo);

                if (!_resultForm.Visible)
                {
                    _resultForm.Show();
                }
            }

            return exportInformation;
        }

        private void _resultForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}