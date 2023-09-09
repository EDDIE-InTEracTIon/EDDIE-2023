namespace AugmentedReadingApp
{
    partial class TextRecognitionSettings
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
            this.ComboBoxCameraList1 = new System.Windows.Forms.ComboBox();
            this.labelRecTxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownResXText = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownResYText = new System.Windows.Forms.NumericUpDown();
            this.InteractionsSettingsPanel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.InteractionsTittle = new System.Windows.Forms.Label();
            this.TittlePanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResXText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResYText)).BeginInit();
            this.InteractionsSettingsPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            this.TittlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxCameraList1
            // 
            this.ComboBoxCameraList1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCameraList1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.ComboBoxCameraList1.FormattingEnabled = true;
            this.ComboBoxCameraList1.Location = new System.Drawing.Point(19, 45);
            this.ComboBoxCameraList1.Name = "ComboBoxCameraList1";
            this.ComboBoxCameraList1.Size = new System.Drawing.Size(226, 24);
            this.ComboBoxCameraList1.TabIndex = 2;
            this.ComboBoxCameraList1.SelectedIndexChanged += new System.EventHandler(this.ComboCameras_SelectedIndexChangedText);
            // 
            // labelRecTxt
            // 
            this.labelRecTxt.AutoSize = true;
            this.labelRecTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.labelRecTxt.Location = new System.Drawing.Point(17, 19);
            this.labelRecTxt.Name = "labelRecTxt";
            this.labelRecTxt.Size = new System.Drawing.Size(293, 20);
            this.labelRecTxt.TabIndex = 4;
            this.labelRecTxt.Text = "Camera for text recognition(DCR)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 134;
            this.label4.Text = "X";
            // 
            // numericUpDownResXText
            // 
            this.numericUpDownResXText.Location = new System.Drawing.Point(19, 77);
            this.numericUpDownResXText.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownResXText.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownResXText.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownResXText.Name = "numericUpDownResXText";
            this.numericUpDownResXText.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownResXText.TabIndex = 136;
            this.numericUpDownResXText.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // numericUpDownResYText
            // 
            this.numericUpDownResYText.Location = new System.Drawing.Point(155, 77);
            this.numericUpDownResYText.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownResYText.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownResYText.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownResYText.Name = "numericUpDownResYText";
            this.numericUpDownResYText.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownResYText.TabIndex = 137;
            this.numericUpDownResYText.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            // 
            // InteractionsSettingsPanel1
            // 
            this.InteractionsSettingsPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.InteractionsSettingsPanel1.Controls.Add(this.pictureBox2);
            this.InteractionsSettingsPanel1.Controls.Add(this.ComboBoxCameraList1);
            this.InteractionsSettingsPanel1.Controls.Add(this.labelRecTxt);
            this.InteractionsSettingsPanel1.Controls.Add(this.numericUpDownResYText);
            this.InteractionsSettingsPanel1.Controls.Add(this.imageBox1);
            this.InteractionsSettingsPanel1.Controls.Add(this.numericUpDownResXText);
            this.InteractionsSettingsPanel1.Controls.Add(this.imageBox3);
            this.InteractionsSettingsPanel1.Controls.Add(this.label4);
            this.InteractionsSettingsPanel1.Location = new System.Drawing.Point(12, 94);
            this.InteractionsSettingsPanel1.Name = "InteractionsSettingsPanel1";
            this.InteractionsSettingsPanel1.Size = new System.Drawing.Size(947, 367);
            this.InteractionsSettingsPanel1.TabIndex = 139;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox2.Image = global::AugmentedReadingApp.Properties.Resources.informationIcon;
            this.pictureBox2.Location = new System.Drawing.Point(316, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 138;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(21, 113);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(352, 200);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // imageBox3
            // 
            this.imageBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox3.Location = new System.Drawing.Point(383, 113);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(352, 200);
            this.imageBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox3.TabIndex = 125;
            this.imageBox3.TabStop = false;
            // 
            // InteractionsTittle
            // 
            this.InteractionsTittle.AutoSize = true;
            this.InteractionsTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InteractionsTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.InteractionsTittle.Location = new System.Drawing.Point(12, 8);
            this.InteractionsTittle.Name = "InteractionsTittle";
            this.InteractionsTittle.Size = new System.Drawing.Size(377, 52);
            this.InteractionsTittle.TabIndex = 0;
            this.InteractionsTittle.Text = "Text Recognition";
            // 
            // TittlePanel
            // 
            this.TittlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.TittlePanel.Controls.Add(this.InteractionsTittle);
            this.TittlePanel.Location = new System.Drawing.Point(0, 0);
            this.TittlePanel.Name = "TittlePanel";
            this.TittlePanel.Size = new System.Drawing.Size(988, 74);
            this.TittlePanel.TabIndex = 138;
            // 
            // TextRecognitionSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(971, 500);
            this.Controls.Add(this.InteractionsSettingsPanel1);
            this.Controls.Add(this.TittlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "TextRecognitionSettings";
            this.Text = "Configuración";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResXText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResYText)).EndInit();
            this.InteractionsSettingsPanel1.ResumeLayout(false);
            this.InteractionsSettingsPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            this.TittlePanel.ResumeLayout(false);
            this.TittlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ComboBox ComboBoxCameraList1;
        private System.Windows.Forms.Label labelRecTxt;
        public Emgu.CV.UI.ImageBox imageBox1;
        public Emgu.CV.UI.ImageBox imageBox3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown numericUpDownResXText;
        public System.Windows.Forms.NumericUpDown numericUpDownResYText;
        private System.Windows.Forms.Panel InteractionsSettingsPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label InteractionsTittle;
        private System.Windows.Forms.Panel TittlePanel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
