using System;
using System.ComponentModel;
using Greenshot.Base.Core;

namespace Greenshot.Plugin.BarcodeDecoder.Forms
{
    public partial class BarcodeDecoderResultForm : BarcodeDecoderForm
    {
        public BarcodeDecoderResultForm(BindingList<BarcodeInfo> decodedValues) : base()
        {
            InitializeComponent();
            grdResults.DataSource = decodedValues;
            grdResults.AutoGenerateColumns = false;
        }

        private void greenshotButton2_Click(object sender, EventArgs e)
        {
            ClipboardHelper.SetClipboardData(txtValue.Text);
        }

        private void greenshotButton1_Click(object sender, EventArgs e)
        {
            ClipboardHelper.SetClipboardData(txtType.Text);
        }

        private void greenshotButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetResult(BarcodeInfo barcodeInfo)
        {
            txtValue.Text = barcodeInfo.Value;
            txtType.Text = barcodeInfo.Type;
        }
    }
}
