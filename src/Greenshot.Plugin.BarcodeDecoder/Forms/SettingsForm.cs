using System.ComponentModel;

namespace Greenshot.Plugin.BarcodeDecoder.Forms
{
    public partial class SettingsForm : BarcodeDecoderForm
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void greenshotTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(greenshotTextBox1.Text, out var _))
            {
                e.Cancel = true;
                errorProvider.SetError(greenshotTextBox1, "Only number allowed");
            }
        }

        private void greenshotTextBox1_VisibleChanged(object sender, System.EventArgs e)
        {
            errorProvider.SetError(greenshotTextBox1, string.Empty);
        }
    }
}
