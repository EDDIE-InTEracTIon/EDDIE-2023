using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using ModuloProcesamientoImagenes;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Reflection;
using System.IO;
using ModuloReconocimientoGestual;
using ModuloConsistenciaDatos;
using ModuloRastreoOcular;
//using Leap;



namespace AugmentedReadingApp
{
    public partial class GestureRecognitionSettings : Form
    {   //Clase y atributos para detectar y desplegar camaras
        
        CameraActivity camerasText = new CameraActivity();
        CameraActivity camerasGesture = new CameraActivity();
        private int _CameraTextIndex;
        //Se pasa a public
        public int _CameraGestureIndex;
        VideoCapture captureText;
        public VideoCapture captureGesture;
        Dictionary<string, IPlugin> _plugins = new Dictionary<string, IPlugin>();

        public IPlugin plugin;

        public ColorRecognition recTxt = new ColorRecognition();
        public GestureRecognitionActivity recGestual = new GestureRecognitionActivity();
        public ProjectionScreenActivity projection;
        public DigitalDocSync documentoSyn;
        OpenFileDialog openFilePDF = new OpenFileDialog();

        public byte[] byteImagenBuscada;

        //
        //Agrega Modulo consistencia DP
        //

        public int numeroCamara;
        public string pdfName;
        public VideoCapture _capture;
        public Mat _frame;
        //Fin agrega Modulo consistencia DP

        private Mat rectangleImage;
        public Mat RectangleImage
        {
            get
            {
                return rectangleImage;
            }
        }


        public GestureRecognitionSettings()
        {
            ///Codigo de preuba para probar menusettings
            //MenuSettings menuSettings = new MenuSettings();
            //menuSettings.Show();
            ///Codigo de prueba para probar projection screen.cs
            //ProjectionScreen projectionScreen = new ProjectionScreen();
            //projectionScreen.Show();


            //projection = new ProjectionScreenActivity(this);


            //SeleccionInteraccionPorVoz seleccionInteraccionPorVoz = new SeleccionInteraccionPorVoz();
            //seleccionInteraccionPorVoz.TopMost = true;
            //seleccionInteraccionPorVoz.Show();

            InitializeComponent();
            
            LoadComboBox(camerasGesture.ListCameras(), ComboBoxCameraList2);


            //Atributos y metodos reflexion
            var assembly = Assembly.GetExecutingAssembly();

            var folder = Path.GetDirectoryName(assembly.Location);

            LoadPlugins(folder);//carga los plugins

            CreateFilterMenu();

            recGestual.selectedRectangle += PutRectangle;

            GetSettings();

        }

        //Clase reconociminto gestual
        void LoadPlugins(string folder)
        {
            _plugins.Clear();
            foreach (var dll in Directory.GetFiles(folder + "\\Plugins", "*.dll"))
            {
                try
                {
                    var asm = Assembly.LoadFrom(dll);
                    foreach (var type in asm.GetTypes())
                    {
                        if (type.GetInterface("IPlugin") == typeof(IPlugin))
                        {
                            var filter = Activator.CreateInstance(type) as IPlugin;
                            _plugins[filter.Name] = filter;


                        }
                    }

                }
                catch (BadImageFormatException ex) { MessageBox.Show("LoadPlugins :" + ex.Message); }

            }
        }

        void CreateFilterMenu()
        {
            //complementoToolStripMenuItem.DropDownItems.Clear();
            //Se agregan a un toolStripMenuItem
            foreach (KeyValuePair<string, IPlugin> pair in _plugins)
            {
                var item = new ToolStripMenuItem(pair.Key);
                item.Click += new EventHandler(menuItem_click);
                //complementoToolStripMenuItem.DropDownItems.Add(item);
                // ((ToolStripMenuItem)menuItem).Checked = true;

            }
            //Ahora se agregan a un comboBox
            foreach (KeyValuePair<string, IPlugin> pair in _plugins)
            {
                //var item = new ToolStripMenuItem(pair.Key);
                //item.Click += new EventHandler(menuItem_click);
                comboBox1.Items.Add(pair.Key);
                //complementoToolStripMenuItem.DropDownItems.Add(item);
                // ((ToolStripMenuItem)menuItem).Checked = true;

            }

        }

        void menuItem_click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            plugin = _plugins[menuItem.Text];
            recGestual.Plugin = _plugins[menuItem.Text];
            UncheckOtherToolStripMenuItems((ToolStripMenuItem)sender);
            ((ToolStripMenuItem)menuItem).Checked = true;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                //pictureBox2.Image = _filter.RunPlugin(captureGesture);
            }
            //catch ()
            catch (Exception ex)
            {
                MessageBox.Show(".dll externo" + ex.Message);
                // no sabemos qué puede pasar al cargar en un .dll externo

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        void menuItem_click2(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            plugin = _plugins[menuItem.Text];
            recGestual.Plugin = _plugins[menuItem.Text];
            UncheckOtherToolStripMenuItems((ToolStripMenuItem)sender);
            ((ToolStripMenuItem)menuItem).Checked = true;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                //pictureBox2.Image = _filter.RunPlugin(captureGesture);
            }
            //catch ()
            catch (Exception ex)
            {
                MessageBox.Show(".dll externo" + ex.Message);
                // no sabemos qué puede pasar al cargar en un .dll externo

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        public void UncheckOtherToolStripMenuItems(ToolStripMenuItem selectedMenuItem)
        {
            selectedMenuItem.Checked = true;


            foreach (var ltoolStripMenuItem in (from object
                                                    item in selectedMenuItem.Owner.Items
                                                let ltoolStripMenuItem = item as ToolStripMenuItem
                                                where ltoolStripMenuItem != null
                                                where !item.Equals(selectedMenuItem)
                                                select ltoolStripMenuItem))
                (ltoolStripMenuItem).Checked = false;


            selectedMenuItem.Owner.Show();
        }

        void LoadComboBox(List<KeyValuePair<int, string>> ListData,
        ComboBox ComboBoxCameraList)
        {
            
            //Limpiar el comboBox que muestra las camaras
            ComboBoxCameraList.DataSource = null;
            ComboBoxCameraList.Items.Clear();

            //Enlase a comboBox que muestra las camaras
            ComboBoxCameraList.DataSource = new BindingSource(ListData, null);
            ComboBoxCameraList.DisplayMember = "Value";
            ComboBoxCameraList.ValueMember = "Key";
        }

       void refreshList(List<KeyValuePair<int, string>> ListData,
        ComboBox ComboBoxCameraList)
        {
            ComboBoxCameraList.DataSource = ListData;
            ComboBoxCameraList.Refresh();
        }

        private void ComboCameras_SelectedIndexChangedText(object sender, EventArgs e)
        {
            //Obtiene la camara seleccionada del combobox para reconocimiento de texto
            _CameraTextIndex = SelectItem((ComboBox)sender);

        }

        private void ComboCameras_SelectedIndexChangedGesture(object sender, EventArgs e)
        {
            //Obtiene la camara seleccionada del combobox para reconocimiento gestual
            _CameraGestureIndex = SelectItem((ComboBox)sender);

        }

        int SelectItem(ComboBox ComboBoxCameraList)
        {
            //Obtiene el item seleccionado del combobox
            KeyValuePair<int, string> SelectedItem = (KeyValuePair<int, string>)ComboBoxCameraList.SelectedItem;
            //Asigna el numero del item camara selecionada a la salida
            return SelectedItem.Key;
        }
        

        private void comenzarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CameraNumber = _CameraGestureIndex;
            if (captureGesture == null)
            {
                captureGesture = new VideoCapture(CameraNumber);
                captureGesture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth, (double)numericUpDownXGestual.Value);
                captureGesture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight, (double)numericUpDownYGestual.Value);
                captureGesture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps, 5);

            }
            captureGesture.ImageGrabbed += Capture_ImageGrabbed1;
            captureGesture.Start();
        }

        private delegate void SetValueDelegate(string prValue);

        private void SetValue_textBoxX(string hecho)
        {
            if (textBoxX.InvokeRequired)
            {
                SetValueDelegate delegado = new SetValueDelegate(SetValue_textBoxX);
                textBoxX.Invoke(delegado, new object[] { hecho });
            }
            textBoxX.Text = hecho;
        }



        private void SetValue_textBoxY(string hecho)
        {
            if (textBoxY.InvokeRequired)
            {
                SetValueDelegate delegado = new SetValueDelegate(SetValue_textBoxY);
                textBoxY.Invoke(delegado, new object[] { hecho });
            }
            textBoxY.Text = hecho;
        }

        private void Capture_ImageGrabbed1(object sender, EventArgs e)
        {
            recGestual.ActiveX = checkBoxX.Checked;
            recGestual.ActiveY = checkBoxY.Checked;
            recGestual.MouseRecOn = checkBoxMouse.Checked;
            imageBox2.Image = recGestual.Capture_ImageGrabbed(captureGesture, (float)numericUpDownSStartX.Value,
            (float)numericUpDownSEndX.Value, (float)numericUpDownAStartX.Value, (float)numericUpDownAEndX.Value,
            (float)numericUpDownSStartY.Value, (float)numericUpDownSEndY.Value, (float)numericUpDownAStartY.Value,
            (float)numericUpDownAEndY.Value);
            SetValue_textBoxX(recGestual.SensorX.ToString());
            SetValue_textBoxY(recGestual.SensorY.ToString());

        }


        private void detenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (captureGesture != null)
            {
                captureGesture.Stop();
                captureGesture.ImageGrabbed -= Capture_ImageGrabbed1;//retirar el evento de captura camara
            }
        }

       

  

        private void button4_Click(object sender, EventArgs e)
        {

            PutRectangle(recGestual.RectangularSelection);

        }

        public string ImageToBase64(System.Drawing.Image image,
        System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        private void PutRectangle(Rectangle rectangle)
        {
            using (Mat m = new Mat())
            {

                if (captureGesture != null)
                {
                    captureGesture.Retrieve(m);

                    imageBox4.Image = cropColorFrame(m, rectangle).ToImage<Bgr, byte>();
                    ImageToBase64(cropColorFrame(m, rectangle).Bitmap, System.Drawing.Imaging.ImageFormat.Bmp);
                    //imageBox4.Image = cropColorFrame(m, new Rectangle(10,10,0,1)).ToImage<Bgr, byte>();
                    CaptureImage();
                }

            }

        }

        public void CaptureImage()
        {
            using (Mat m = new Mat())
            {
                if (captureGesture != null)
                {
                    captureGesture.Retrieve(m);
                    rectangleImage = cropColorFrame(m, recGestual.RectangularSelection);
                    //if (checkBoxMouse.Checked)
                    //{

                    //    rectangleImage = cropColorFrame(m, recGestual.RectangularSelection);
                    //}
                    //else
                    //{

                    //    // rectangleImage = cropColorFrame(m, projection.Highlight.GetRectangle());
                    //    rectangleImage = cropColorFrame(m, recGestual.RectangularSelection);
                    //}
                    if (rectangleImage != null)
                    {
                        imageBox4.Image = rectangleImage.ToImage<Bgr, Byte>();
                        Image<Bgr, Byte> img = rectangleImage.ToImage<Bgr, Byte>();
                        Console.WriteLine("Imagen capturada " + recGestual.RectangularSelection);
                        Bitmap bimage = img.ToBitmap();
                        System.IO.MemoryStream ms = new MemoryStream();
                        bimage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byteImagenBuscada = ms.ToArray();
                        //if (byteImagenBuscada != null && byteImagenBuscada.Length > 0)
                        //{
                        //    MessageBox.Show("se ha transformado la imagen a byte[] correctamente");
                        //}
                        //else
                        //{
                        //    MessageBox.Show("no se ha transformado la imagen a byte[] ");

                        //}
                    }

                }
            }
        }


        Mat cropColorFrame(Mat input, Rectangle cropRegion)
        {
            //copia de input
            Image<Bgr, Byte> buffer_im = input.ToImage<Bgr, Byte>();
            if (cropRegion.Width > 0 && cropRegion.Height > 0 && cropRegion.Location.X < input.Width)
            {
                buffer_im.ROI = cropRegion;

                Image<Bgr, Byte> cropped_im = buffer_im.Copy();


                return cropped_im.Mat;
            }

            return buffer_im.Mat;
        }

        

        public void GetSettings()
        {
            numericUpDownSStartX.Value = Properties.Settings.Default.ValorX1;
            numericUpDownSStartY.Value = Properties.Settings.Default.ValorY1;
            numericUpDownSEndX.Value = Properties.Settings.Default.ValorX2;
            numericUpDownSEndY.Value = Properties.Settings.Default.ValorY2;

        }
        public void SaveSettings()
        {
            Properties.Settings.Default.ValorX1 = (int)numericUpDownSStartX.Value;
            Properties.Settings.Default.ValorY1 = (int)numericUpDownSStartY.Value;
            Properties.Settings.Default.ValorX2 = (int)numericUpDownSEndX.Value;
            Properties.Settings.Default.ValorY2 = (int)numericUpDownSEndY.Value;
            Properties.Settings.Default.Save();

        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            SaveSettings();
            GetSettings();
        }
        
        //private void ComboBoxCameraList1_Click(object sender, EventArgs e)//Action al apretar en el bombo box
        //{
        //    refreshList(camerasText.ListCameras(), ComboBoxCameraList1);
        //    //LoadComboBox(camerasGesture.ListCameras(), ComboBoxCameraList2);
        //}


        //Agregar Modulo Consistencia DP

        


        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EyeTrackingConfiguration eyeTrackingConfig = new EyeTrackingConfiguration();
            eyeTrackingConfig.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var menuItem = sender as ComboBox;
            plugin = _plugins[menuItem.Text];
            recGestual.Plugin = _plugins[menuItem.Text];
            try
            {
                this.Cursor = Cursors.WaitCursor;
                //pictureBox2.Image = _filter.RunPlugin(captureGesture);
            }
            //catch ()
            catch (Exception ex)
            {
                MessageBox.Show(".dll externo" + ex.Message);
                // no sabemos qué puede pasar al cargar en un .dll externo

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void GestureRecognitionSettings_Load(object sender, EventArgs e)
        {

        }

        private void InteractionsSettingsPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxX_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            toolTip1.Show("Camera selection for gesture recognition. The same camera must not be used for text recognition. Before starting the recognition you must select a plug-in.", pictureBox2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            toolTip1.Show("If the device is going to take control of the mouse such as the Hand Skin or Color Pen, activate the Recognition on checkbox.", pictureBox1);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            toolTip1.Show("'Sensor X' and 'Sensor Y' Displays the sensor information, relative coordinate in X and Y axis.\n In 'Sensor start X' and 'Sensor start Y' the X and Y coordinates shown in the input 'Sensor X' and 'Sensor Y' must be entered when pointing the cursor to the center of the upper left calibration cross.\n In 'Sensor end X' and 'Sensor end Y' the X and Y coordinates shown in the input 'Sensor X' and 'Sensor Y' must be entered by pointing the cursor to the center of the lower right calibration cross.", pictureBox4);
        }
    }
}

