namespace Greenshot.Plugin.BarcodeDecoder.Forms
{
    partial class BarcodeDecoderResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodeDecoderResultForm));
            this.greenshotLabel1 = new Greenshot.Base.Controls.GreenshotLabel();
            this.greenshotLabel2 = new Greenshot.Base.Controls.GreenshotLabel();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.greenshotButton1 = new Greenshot.Base.Controls.GreenshotButton();
            this.greenshotButton2 = new Greenshot.Base.Controls.GreenshotButton();
            this.greenshotButton3 = new Greenshot.Base.Controls.GreenshotButton();
            this.grdResults = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapturedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).BeginInit();
            this.SuspendLayout();
            // 
            // greenshotLabel1
            // 
            this.greenshotLabel1.AutoSize = true;
            this.greenshotLabel1.Location = new System.Drawing.Point(12, 9);
            this.greenshotLabel1.Name = "greenshotLabel1";
            this.greenshotLabel1.Size = new System.Drawing.Size(34, 13);
            this.greenshotLabel1.TabIndex = 0;
            this.greenshotLabel1.Text = "Value";
            // 
            // greenshotLabel2
            // 
            this.greenshotLabel2.AutoSize = true;
            this.greenshotLabel2.Location = new System.Drawing.Point(15, 119);
            this.greenshotLabel2.Name = "greenshotLabel2";
            this.greenshotLabel2.Size = new System.Drawing.Size(31, 13);
            this.greenshotLabel2.TabIndex = 1;
            this.greenshotLabel2.Text = "Type";
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtValue.Location = new System.Drawing.Point(53, 9);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.ReadOnly = true;
            this.txtValue.Size = new System.Drawing.Size(328, 99);
            this.txtValue.TabIndex = 2;
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtType.Location = new System.Drawing.Point(53, 119);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(327, 20);
            this.txtType.TabIndex = 3;
            // 
            // greenshotButton1
            // 
            this.greenshotButton1.Location = new System.Drawing.Point(387, 119);
            this.greenshotButton1.Name = "greenshotButton1";
            this.greenshotButton1.Size = new System.Drawing.Size(75, 23);
            this.greenshotButton1.TabIndex = 4;
            this.greenshotButton1.Text = "To Clipboard";
            this.greenshotButton1.UseVisualStyleBackColor = true;
            this.greenshotButton1.Click += new System.EventHandler(this.greenshotButton1_Click);
            // 
            // greenshotButton2
            // 
            this.greenshotButton2.Location = new System.Drawing.Point(387, 9);
            this.greenshotButton2.Name = "greenshotButton2";
            this.greenshotButton2.Size = new System.Drawing.Size(75, 23);
            this.greenshotButton2.TabIndex = 5;
            this.greenshotButton2.Text = "To Clipboard";
            this.greenshotButton2.UseVisualStyleBackColor = true;
            this.greenshotButton2.Click += new System.EventHandler(this.greenshotButton2_Click);
            // 
            // greenshotButton3
            // 
            this.greenshotButton3.Location = new System.Drawing.Point(387, 456);
            this.greenshotButton3.Name = "greenshotButton3";
            this.greenshotButton3.Size = new System.Drawing.Size(75, 23);
            this.greenshotButton3.TabIndex = 6;
            this.greenshotButton3.Text = "Close";
            this.greenshotButton3.UseVisualStyleBackColor = true;
            this.greenshotButton3.Click += new System.EventHandler(this.greenshotButton3_Click);
            // 
            // grdResults
            // 
            this.grdResults.AllowUserToAddRows = false;
            this.grdResults.AllowUserToDeleteRows = false;
            this.grdResults.AllowUserToOrderColumns = true;
            this.grdResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Value,
            this.Type,
            this.CapturedAt});
            this.grdResults.Location = new System.Drawing.Point(18, 180);
            this.grdResults.Name = "grdResults";
            this.grdResults.Size = new System.Drawing.Size(438, 261);
            this.grdResults.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Last values";
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Visible = false;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Visible = false;
            // 
            // CapturedAt
            // 
            this.CapturedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;            
            this.CapturedAt.HeaderText = "CapturedAt";
            this.CapturedAt.Name = "CapturedAt";
            this.CapturedAt.ReadOnly = true;            
            this.CapturedAt.Visible = false;

            // 
            // BarcodeDecoderResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdResults);
            this.Controls.Add(this.greenshotButton3);
            this.Controls.Add(this.greenshotButton2);
            this.Controls.Add(this.greenshotButton1);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.greenshotLabel2);
            this.Controls.Add(this.greenshotLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BarcodeDecoderResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode parsing result";
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Base.Controls.GreenshotLabel greenshotLabel1;
        private Base.Controls.GreenshotLabel greenshotLabel2;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtType;
        private Base.Controls.GreenshotButton greenshotButton1;
        private Base.Controls.GreenshotButton greenshotButton2;
        private Base.Controls.GreenshotButton greenshotButton3;
        private System.Windows.Forms.DataGridView grdResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapturedAt;
    }
}