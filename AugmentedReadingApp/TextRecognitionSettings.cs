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
    public partial class TextRecognitionSettings : Form
    {   //Clase y atributos para detectar y desplegar camaras
        
        CameraActivity camerasText = new CameraActivity();
        CameraActivity camerasGesture = new CameraActivity();
        public int _CameraTextIndex; //Se pasa a publico
        private int _CameraGestureIndex;
        public VideoCapture captureText;
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


        public TextRecognitionSettings()
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

            LoadComboBox(camerasText.ListCameras(), ComboBoxCameraList1);


            //Atributos y metodos reflexion
            var assembly = Assembly.GetExecutingAssembly();

            var folder = Path.GetDirectoryName(assembly.Location);

            LoadPlugins(folder);//carga los plugins

            

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

        private void ProyectionActivityBt(object sender, EventArgs e)
        {
            var CameraNumber = _CameraTextIndex;

            projection.Show();
            captureText = new VideoCapture(CameraNumber);
            captureText.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth, (double)numericUpDownResXText.Value);
            captureText.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight, (double)numericUpDownResYText.Value);

            imageBox1.Image = recTxt.Recognition(captureText);
            if (captureText == null)
            {
                captureText = new VideoCapture(CameraNumber);
                captureText.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth, (double)numericUpDownResXText.Value);
                captureText.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight, (double)numericUpDownResYText.Value);

                imageBox1.Image = recTxt.Recognition(captureText);
            }
            
            //Agrega Modulo Consistencia DP
            consistencyCamera(CameraNumber);
            numeroCamara = CameraNumber;
        }


        public void CaptureTxt()
        {
            captureText.Start();
            try
            {
                imageBox1.Image = recTxt.Recognition(captureText);
                if (recTxt.TextImage != null)
                {
                    imageBox3.Image = recTxt.TextImage;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("CaptureTxt: " + ex.Message);
            }

            captureText.Stop();

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
        

        private void ComboBoxCameraList1_Click(object sender, EventArgs e)//Action al apretar en el bombo box
        {
            refreshList(camerasText.ListCameras(), ComboBoxCameraList1);
            //LoadComboBox(camerasGesture.ListCameras(), ComboBoxCameraList2);
        }


        //Agregar Modulo Consistencia DP

        private async void ProcessFrame(object sender, EventArgs e)
        {
            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {
                _capture.Retrieve(_frame, 0);
                if (_frame != null)
                {
                    Image<Bgr, byte> imagen_aux = _frame.ToImage<Bgr, byte>();
                    //imagen_aux = imagen_aux.Rotate(180, new Bgr(0, 0, 0));
                    imageBox3.Image = imagen_aux;
                    //pictureBox1.Image = _frame.Bitmap;
                    double fps = 15;
                    await Task.Delay(1000 / Convert.ToInt32(fps));
                }


            }
        }

        public void consistencyCamera(int CameraNumber)
        {
            _capture = new VideoCapture(CameraNumber);


            _capture.ImageGrabbed += ProcessFrame;
            _frame = new Mat();
            if (_capture != null)
            {
                try
                {
                    _capture.Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
        }

        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EyeTrackingConfiguration eyeTrackingConfig = new EyeTrackingConfiguration();
            eyeTrackingConfig.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            toolTip1.Show("Camera selection for OCR text recognition. The same camera must not be used for gesture recognition.", pictureBox2);
        }
        //public void stopCamera(int CameraNumber)
        //{
        //    _capture.Stop();
        //}

    }
}

