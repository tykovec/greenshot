namespace Greenshot.Plugin.BarcodeDecoder.Forms
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.greenshotTextBox1 = new Greenshot.Base.Controls.GreenshotTextBox();
            this.greenshotLabel1 = new Greenshot.Base.Controls.GreenshotLabel();
            this.buttonCancel = new Greenshot.Base.Controls.GreenshotButton();
            this.buttonOK = new Greenshot.Base.Controls.GreenshotButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // greenshotTextBox1
            // 
            this.greenshotTextBox1.Location = new System.Drawing.Point(108, 12);
            this.greenshotTextBox1.Name = "greenshotTextBox1";
            this.greenshotTextBox1.PropertyName = "MaxLastValuesSize";
            this.greenshotTextBox1.SectionName = "BarcodeDecoder";
            this.greenshotTextBox1.Size = new System.Drawing.Size(144, 20);
            this.greenshotTextBox1.TabIndex = 19;
            this.greenshotTextBox1.VisibleChanged += new System.EventHandler(this.greenshotTextBox1_VisibleChanged);
            this.greenshotTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.greenshotTextBox1_Validating);
            // 
            // greenshotLabel1
            // 
            this.greenshotLabel1.AutoSize = true;
            this.greenshotLabel1.Location = new System.Drawing.Point(4, 15);
            this.greenshotLabel1.Name = "greenshotLabel1";
            this.greenshotLabel1.Size = new System.Drawing.Size(101, 13);
            this.greenshotLabel1.TabIndex = 18;
            this.greenshotLabel1.Text = "Max last values size";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.CausesValidation = false;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(175, 48);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(94, 48);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 16;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(275, 83);
            this.Controls.Add(this.greenshotTextBox1);
            this.Controls.Add(this.greenshotLabel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode decoder settings";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Base.Controls.GreenshotTextBox greenshotTextBox1;
        private Base.Controls.GreenshotLabel greenshotLabel1;
        private Base.Controls.GreenshotButton buttonCancel;
        private Base.Controls.GreenshotButton buttonOK;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}