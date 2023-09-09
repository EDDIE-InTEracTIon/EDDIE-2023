namespace AugmentedReadingApp
{
    partial class GestureRecognitionSettings
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
            this.ComboBoxCameraList2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.numericUpDownAStartY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAEndY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSStartY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSEndY = new System.Windows.Forms.NumericUpDown();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.numericUpDownAStartX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAEndX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSStartX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSEndX = new System.Windows.Forms.NumericUpDown();
            this.checkBoxY = new System.Windows.Forms.CheckBox();
            this.checkBoxX = new System.Windows.Forms.CheckBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownXGestual = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYGestual = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMouse = new System.Windows.Forms.CheckBox();
            this.imageBox4 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InteractionsSettingsPanel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonModified3 = new Front_EDDIE_WindowsForm.ButtonModified();
            this.buttonModified2 = new Front_EDDIE_WindowsForm.ButtonModified();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonModified1 = new Front_EDDIE_WindowsForm.ButtonModified();
            this.StartProjectionButtonModified = new Front_EDDIE_WindowsForm.ButtonModified();
            this.TittlePanel = new System.Windows.Forms.Panel();
            this.InteractionsTittle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAStartY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAEndY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSStartY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSEndY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAStartX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAEndX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSStartX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSEndX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXGestual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYGestual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.InteractionsSettingsPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TittlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxCameraList2
            // 
            this.ComboBoxCameraList2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCameraList2.Font = new System.Drawing.Font("IBM Plex Sans", 9.749999F);
            this.ComboBoxCameraList2.FormattingEnabled = true;
            this.ComboBoxCameraList2.Location = new System.Drawing.Point(18, 31);
            this.ComboBoxCameraList2.Name = "ComboBoxCameraList2";
            this.ComboBoxCameraList2.Size = new System.Drawing.Size(226, 25);
            this.ComboBoxCameraList2.TabIndex = 5;
            this.ComboBoxCameraList2.SelectedIndexChanged += new System.EventHandler(this.ComboCameras_SelectedIndexChangedGesture);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IBM Plex Sans SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Camera for gesture recognition";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("IBM Plex Sans", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(612, 377);
            this.label51.Margin = new System.Windows.Forms.Padding(0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(81, 19);
            this.label51.TabIndex = 109;
            this.label51.Text = "App End Y";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("IBM Plex Sans", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(410, 377);
            this.label52.Margin = new System.Windows.Forms.Padding(0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(87, 19);
            this.label52.TabIndex = 108;
            this.label52.Text = "App Start Y";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("IBM Plex Sans", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(612, 351);
            this.label53.Margin = new System.Windows.Forms.Padding(0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(100, 19);
            this.label53.TabIndex = 107;
            this.label53.Text = "Sensor End Y";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("IBM Plex Sans", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(410, 351);
            this.label54.Margin = new System.Windows.Forms.Padding(0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(106, 19);
            this.label54.TabIndex = 106;
            this.label54.Text = "Sensor Start Y";
            // 
            // numericUpDownAStartY
            // 
            this.numericUpDownAStartY.Location = new System.Drawing.Point(513, 377);
            this.numericUpDownAStartY.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownAStartY.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownAStartY.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownAStartY.Name = "numericUpDownAStartY";
            this.numericUpDownAStartY.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownAStartY.TabIndex = 105;
            this.numericUpDownAStartY.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // numericUpDownAEndY
            // 
            this.numericUpDownAEndY.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDownAEndY.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDownAEndY.Location = new System.Drawing.Point(717, 377);
            this.numericUpDownAEndY.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownAEndY.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownAEndY.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownAEndY.Name = "numericUpDownAEndY";
            this.numericUpDownAEndY.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownAEndY.TabIndex = 104;
            this.numericUpDownAEndY.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // numericUpDownSStartY
            // 
            this.numericUpDownSStartY.Location = new System.Drawing.Point(513, 350);
            this.numericUpDownSStartY.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownSStartY.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.numericUpDownSStartY.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownSStartY.Name = "numericUpDownSStartY";
            this.numericUpDownSStartY.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownSStartY.TabIndex = 103;
            this.numericUpDownSStartY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownSEndY
            // 
            this.numericUpDownSEndY.Location = new System.Drawing.Point(717, 350);
            this.numericUpDownSEndY.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownSEndY.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.numericUpDownSEndY.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownSEndY.Name = "numericUpDownSEndY";
            this.numericUpDownSEndY.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownSEndY.TabIndex = 102;
            this.numericUpDownSEndY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("IBM Plex Sans", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(211, 377);
            this.label38.Margin = new System.Windows.Forms.Padding(0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(81, 19);
            this.label38.TabIndex = 101;
            this.label38.Text = "App End X";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("IBM Plex Sans", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(15, 377);
            this.label39.Margin = new System.Windows.Forms.Padding(0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(87, 19);
            this.label39.TabIndex = 100;
            this.label39.Text = "App Start X";
            this.label39.Click += new System.EventHandler(this.label39_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("IBM Plex Sans", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(211, 351);
            this.label40.Margin = new System.Windows.Forms.Padding(0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(100, 19);
            this.label40.TabIndex = 99;
            this.label40.Text = "Sensor End X";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("IBM Plex Sans", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(15, 351);
            this.label41.Margin = new System.Windows.Forms.Padding(0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(106, 19);
            this.label41.TabIndex = 98;
            this.label41.Text = "Sensor Start X";
            this.label41.Click += new System.EventHandler(this.label41_Click);
            // 
            // numericUpDownAStartX
            // 
            this.numericUpDownAStartX.Location = new System.Drawing.Point(118, 377);
            this.numericUpDownAStartX.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownAStartX.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownAStartX.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownAStartX.Name = "numericUpDownAStartX";
            this.numericUpDownAStartX.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownAStartX.TabIndex = 97;
            this.numericUpDownAStartX.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // numericUpDownAEndX
            // 
            this.numericUpDownAEndX.Location = new System.Drawing.Point(317, 377);
            this.numericUpDownAEndX.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownAEndX.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownAEndX.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownAEndX.Name = "numericUpDownAEndX";
            this.numericUpDownAEndX.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownAEndX.TabIndex = 96;
            this.numericUpDownAEndX.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // numericUpDownSStartX
            // 
            this.numericUpDownSStartX.Location = new System.Drawing.Point(118, 350);
            this.numericUpDownSStartX.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownSStartX.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.numericUpDownSStartX.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownSStartX.Name = "numericUpDownSStartX";
            this.numericUpDownSStartX.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownSStartX.TabIndex = 95;
            this.numericUpDownSStartX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownSEndX
            // 
            this.numericUpDownSEndX.Location = new System.Drawing.Point(317, 350);
            this.numericUpDownSEndX.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownSEndX.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.numericUpDownSEndX.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownSEndX.Name = "numericUpDownSEndX";
            this.numericUpDownSEndX.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownSEndX.TabIndex = 94;
            this.numericUpDownSEndX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxY
            // 
            this.checkBoxY.AutoSize = true;
            this.checkBoxY.Font = new System.Drawing.Font("IBM Plex Sans", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxY.Location = new System.Drawing.Point(414, 316);
            this.checkBoxY.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.checkBoxY.Name = "checkBoxY";
            this.checkBoxY.Size = new System.Drawing.Size(111, 23);
            this.checkBoxY.TabIndex = 93;
            this.checkBoxY.Text = "Transform Y";
            this.checkBoxY.UseVisualStyleBackColor = true;
            // 
            // checkBoxX
            // 
            this.checkBoxX.AutoSize = true;
            this.checkBoxX.Font = new System.Drawing.Font("IBM Plex Sans", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxX.Location = new System.Drawing.Point(19, 320);
            this.checkBoxX.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.checkBoxX.Name = "checkBoxX";
            this.checkBoxX.Size = new System.Drawing.Size(111, 23);
            this.checkBoxX.TabIndex = 92;
            this.checkBoxX.Text = "Transform X";
            this.checkBoxX.UseVisualStyleBackColor = true;
            this.checkBoxX.CheckedChanged += new System.EventHandler(this.checkBoxX_CheckedChanged);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(280, 319);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(90, 20);
            this.textBoxX.TabIndex = 119;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(668, 319);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(90, 20);
            this.textBoxY.TabIndex = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IBM Plex Sans", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 121;
            this.label2.Text = "Sensor X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IBM Plex Sans", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(593, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 122;
            this.label3.Text = "Sensor Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 135;
            this.label5.Text = "X";
            // 
            // numericUpDownXGestual
            // 
            this.numericUpDownXGestual.Location = new System.Drawing.Point(18, 61);
            this.numericUpDownXGestual.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownXGestual.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownXGestual.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownXGestual.Name = "numericUpDownXGestual";
            this.numericUpDownXGestual.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownXGestual.TabIndex = 138;
            this.numericUpDownXGestual.Value = new decimal(new int[] {
            960,
            0,
            0,
            0});
            // 
            // numericUpDownYGestual
            // 
            this.numericUpDownYGestual.Location = new System.Drawing.Point(155, 63);
            this.numericUpDownYGestual.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownYGestual.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownYGestual.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownYGestual.Name = "numericUpDownYGestual";
            this.numericUpDownYGestual.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownYGestual.TabIndex = 139;
            this.numericUpDownYGestual.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // checkBoxMouse
            // 
            this.checkBoxMouse.AutoSize = true;
            this.checkBoxMouse.Font = new System.Drawing.Font("IBM Plex Sans", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMouse.Location = new System.Drawing.Point(746, 88);
            this.checkBoxMouse.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.checkBoxMouse.Name = "checkBoxMouse";
            this.checkBoxMouse.Size = new System.Drawing.Size(130, 23);
            this.checkBoxMouse.TabIndex = 161;
            this.checkBoxMouse.Text = "Recognition on";
            this.checkBoxMouse.UseVisualStyleBackColor = true;
            // 
            // imageBox4
            // 
            this.imageBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox4.Location = new System.Drawing.Point(376, 88);
            this.imageBox4.Name = "imageBox4";
            this.imageBox4.Size = new System.Drawing.Size(352, 200);
            this.imageBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox4.TabIndex = 126;
            this.imageBox4.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox2.Location = new System.Drawing.Point(18, 88);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(352, 200);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox2.TabIndex = 124;
            this.imageBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("IBM Plex Sans", 9.749999F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(304, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 25);
            this.comboBox1.TabIndex = 162;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IBM Plex Sans SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 163;
            this.label4.Text = "Plug-in";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // InteractionsSettingsPanel1
            // 
            this.InteractionsSettingsPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.InteractionsSettingsPanel1.Controls.Add(this.pictureBox4);
            this.InteractionsSettingsPanel1.Controls.Add(this.pictureBox2);
            this.InteractionsSettingsPanel1.Controls.Add(this.pictureBox1);
            this.InteractionsSettingsPanel1.Controls.Add(this.buttonModified3);
            this.InteractionsSettingsPanel1.Controls.Add(this.buttonModified2);
            this.InteractionsSettingsPanel1.Controls.Add(this.label6);
            this.InteractionsSettingsPanel1.Controls.Add(this.ComboBoxCameraList2);
            this.InteractionsSettingsPanel1.Controls.Add(this.buttonModified1);
            this.InteractionsSettingsPanel1.Controls.Add(this.label1);
            this.InteractionsSettingsPanel1.Controls.Add(this.StartProjectionButtonModified);
            this.InteractionsSettingsPanel1.Controls.Add(this.checkBoxX);
            this.InteractionsSettingsPanel1.Controls.Add(this.label4);
            this.InteractionsSettingsPanel1.Controls.Add(this.checkBoxY);
            this.InteractionsSettingsPanel1.Controls.Add(this.comboBox1);
            this.InteractionsSettingsPanel1.Controls.Add(this.numericUpDownSEndX);
            this.InteractionsSettingsPanel1.Controls.Add(this.checkBoxMouse);
            this.InteractionsSettingsPanel1.Controls.Add(this.numericUpDownSStartX);
            this.InteractionsSettingsPanel1.Controls.Add(this.numericUpDownAEndX);
            this.InteractionsSettingsPanel1.Controls.Add(this.numericUpDownYGestual);
            this.InteractionsSettingsPanel1.Controls.Add(this.numericUpDownAStartX);
            this.InteractionsSettingsPanel1.Controls.Add(this.numericUpDownXGestual);
            this.InteractionsSettingsPanel1.Controls.Add(this.label41);
            this.InteractionsSettingsPanel1.Controls.Add(this.label5);
            this.InteractionsSettingsPanel1.Controls.Add(this.label40);
            this.InteractionsSettingsPanel1.Controls.Add(this.imageBox4);
            this.InteractionsSettingsPanel1.Controls.Add(this.label39);
            this.InteractionsSettingsPanel1.Controls.Add(this.imageBox2);
            this.InteractionsSettingsPanel1.Controls.Add(this.label38);
            this.InteractionsSettingsPanel1.Controls.Add(this.label3);
            this.InteractionsSettingsPanel1.Controls.Add(this.numericUpDownSEndY);
            this.InteractionsSettingsPanel1.Controls.Add(this.label2);
            this.InteractionsSettingsPanel1.Controls.Add(this.numericUpDownSStartY);
            this.InteractionsSettingsPanel1.Controls.Add(this.textBoxY);
            this.InteractionsSettingsPanel1.Controls.Add(this.numericUpDownAEndY);
            this.InteractionsSettingsPanel1.Controls.Add(this.textBoxX);
            this.InteractionsSettingsPanel1.Controls.Add(this.numericUpDownAStartY);
            this.InteractionsSettingsPanel1.Controls.Add(this.label54);
            this.InteractionsSettingsPanel1.Controls.Add(this.label51);
            this.InteractionsSettingsPanel1.Controls.Add(this.label53);
            this.InteractionsSettingsPanel1.Controls.Add(this.label52);
            this.InteractionsSettingsPanel1.Location = new System.Drawing.Point(12, 94);
            this.InteractionsSettingsPanel1.Name = "InteractionsSettingsPanel1";
            this.InteractionsSettingsPanel1.Size = new System.Drawing.Size(947, 417);
            this.InteractionsSettingsPanel1.TabIndex = 166;
            this.InteractionsSettingsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.InteractionsSettingsPanel1_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox4.Image = global::AugmentedReadingApp.Properties.Resources.informationIcon;
            this.pictureBox4.Location = new System.Drawing.Point(110, 295);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 172;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseHover += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox2.Image = global::AugmentedReadingApp.Properties.Resources.informationIcon;
            this.pictureBox2.Location = new System.Drawing.Point(270, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 170;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox1.Image = global::AugmentedReadingApp.Properties.Resources.informationIcon;
            this.pictureBox1.Location = new System.Drawing.Point(879, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 169;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonModified3
            // 
            this.buttonModified3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(157)))), ((int)(((byte)(236)))));
            this.buttonModified3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModified3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(157)))), ((int)(((byte)(236)))));
            this.buttonModified3.FlatAppearance.BorderSize = 5;
            this.buttonModified3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(202)))));
            this.buttonModified3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.buttonModified3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModified3.Font = new System.Drawing.Font("IBM Plex Sans SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModified3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.buttonModified3.Location = new System.Drawing.Point(773, 296);
            this.buttonModified3.Name = "buttonModified3";
            this.buttonModified3.Size = new System.Drawing.Size(157, 47);
            this.buttonModified3.TabIndex = 168;
            this.buttonModified3.Text = "Save calibration";
            this.buttonModified3.UseVisualStyleBackColor = false;
            this.buttonModified3.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // buttonModified2
            // 
            this.buttonModified2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(157)))), ((int)(((byte)(236)))));
            this.buttonModified2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModified2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(157)))), ((int)(((byte)(236)))));
            this.buttonModified2.FlatAppearance.BorderSize = 5;
            this.buttonModified2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(202)))));
            this.buttonModified2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.buttonModified2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModified2.Font = new System.Drawing.Font("IBM Plex Sans SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModified2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.buttonModified2.Location = new System.Drawing.Point(648, 14);
            this.buttonModified2.Name = "buttonModified2";
            this.buttonModified2.Size = new System.Drawing.Size(140, 63);
            this.buttonModified2.TabIndex = 167;
            this.buttonModified2.Text = "Capture";
            this.buttonModified2.UseVisualStyleBackColor = false;
            this.buttonModified2.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("IBM Plex Sans SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 22);
            this.label6.TabIndex = 166;
            this.label6.Text = "Calibration";
            // 
            // buttonModified1
            // 
            this.buttonModified1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(157)))), ((int)(((byte)(236)))));
            this.buttonModified1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModified1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(157)))), ((int)(((byte)(236)))));
            this.buttonModified1.FlatAppearance.BorderSize = 5;
            this.buttonModified1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(202)))));
            this.buttonModified1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.buttonModified1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModified1.Font = new System.Drawing.Font("IBM Plex Sans SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModified1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.buttonModified1.Location = new System.Drawing.Point(794, 14);
            this.buttonModified1.Name = "buttonModified1";
            this.buttonModified1.Size = new System.Drawing.Size(137, 63);
            this.buttonModified1.TabIndex = 165;
            this.buttonModified1.Text = "Stop Recognition";
            this.buttonModified1.UseVisualStyleBackColor = false;
            this.buttonModified1.Click += new System.EventHandler(this.detenerToolStripMenuItem_Click);
            // 
            // StartProjectionButtonModified
            // 
            this.StartProjectionButtonModified.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(157)))), ((int)(((byte)(236)))));
            this.StartProjectionButtonModified.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartProjectionButtonModified.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(157)))), ((int)(((byte)(236)))));
            this.StartProjectionButtonModified.FlatAppearance.BorderSize = 5;
            this.StartProjectionButtonModified.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(202)))));
            this.StartProjectionButtonModified.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.StartProjectionButtonModified.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartProjectionButtonModified.Font = new System.Drawing.Font("IBM Plex Sans SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartProjectionButtonModified.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.StartProjectionButtonModified.Location = new System.Drawing.Point(502, 14);
            this.StartProjectionButtonModified.Name = "StartProjectionButtonModified";
            this.StartProjectionButtonModified.Size = new System.Drawing.Size(140, 63);
            this.StartProjectionButtonModified.TabIndex = 164;
            this.StartProjectionButtonModified.Text = "Start Recognition";
            this.StartProjectionButtonModified.UseVisualStyleBackColor = false;
            this.StartProjectionButtonModified.Click += new System.EventHandler(this.comenzarToolStripMenuItem_Click);
            // 
            // TittlePanel
            // 
            this.TittlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.TittlePanel.Controls.Add(this.InteractionsTittle);
            this.TittlePanel.Location = new System.Drawing.Point(0, 0);
            this.TittlePanel.Name = "TittlePanel";
            this.TittlePanel.Size = new System.Drawing.Size(988, 74);
            this.TittlePanel.TabIndex = 167;
            // 
            // InteractionsTittle
            // 
            this.InteractionsTittle.AutoSize = true;
            this.InteractionsTittle.Font = new System.Drawing.Font("IBM Plex Sans SemiBold", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InteractionsTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.InteractionsTittle.Location = new System.Drawing.Point(12, 8);
            this.InteractionsTittle.Name = "InteractionsTittle";
            this.InteractionsTittle.Size = new System.Drawing.Size(435, 58);
            this.InteractionsTittle.TabIndex = 0;
            this.InteractionsTittle.Text = "Gesture recognition";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 15000;
            this.toolTip1.AutoPopDelay = 150000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 3000;
            // 
            // GestureRecognitionSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(971, 500);
            this.Controls.Add(this.TittlePanel);
            this.Controls.Add(this.InteractionsSettingsPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "GestureRecognitionSettings";
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.GestureRecognitionSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAStartY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAEndY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSStartY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSEndY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAStartX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAEndX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSStartX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSEndX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXGestual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYGestual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.InteractionsSettingsPanel1.ResumeLayout(false);
            this.InteractionsSettingsPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TittlePanel.ResumeLayout(false);
            this.TittlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ComboBox ComboBoxCameraList2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        public System.Windows.Forms.NumericUpDown numericUpDownAStartY;
        public System.Windows.Forms.NumericUpDown numericUpDownAEndY;
        public System.Windows.Forms.NumericUpDown numericUpDownSStartY;
        public System.Windows.Forms.NumericUpDown numericUpDownSEndY;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        public System.Windows.Forms.NumericUpDown numericUpDownAStartX;
        public System.Windows.Forms.NumericUpDown numericUpDownAEndX;
        public System.Windows.Forms.NumericUpDown numericUpDownSStartX;
        public System.Windows.Forms.NumericUpDown numericUpDownSEndX;
        private System.Windows.Forms.CheckBox checkBoxY;
        private System.Windows.Forms.CheckBox checkBoxX;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Emgu.CV.UI.ImageBox imageBox2;
        private Emgu.CV.UI.ImageBox imageBox4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown numericUpDownXGestual;
        public System.Windows.Forms.NumericUpDown numericUpDownYGestual;
        public System.Windows.Forms.CheckBox checkBoxMouse;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private Front_EDDIE_WindowsForm.ButtonModified StartProjectionButtonModified;
        private Front_EDDIE_WindowsForm.ButtonModified buttonModified1;
        private System.Windows.Forms.Panel InteractionsSettingsPanel1;
        private System.Windows.Forms.Panel TittlePanel;
        private System.Windows.Forms.Label InteractionsTittle;
        private System.Windows.Forms.Label label6;
        private Front_EDDIE_WindowsForm.ButtonModified buttonModified3;
        private Front_EDDIE_WindowsForm.ButtonModified buttonModified2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}
