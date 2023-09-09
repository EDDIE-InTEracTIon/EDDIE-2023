using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Drawing.Text;
//Se agrega
using Emgu.CV;
//Se agrega para correccion de errores
using System.Management;

namespace AugmentedReadingApp
{
    public partial class MenuSettings : Form
    {
        //Se Instancias los formularios con cada configuracion de cada módulo
        //WebSearchServicesSettings WebSearchServicesForm = new WebSearchServicesSettings();
        AlertBox alertBox;
        String bandera;
        LoadingBox loadingbox; //Para la animacion de carga
        Thread loadthread;//Para la animacion de carga

        //ProgressBox progressBox = new ProgressBox();
        SeleccionInteraccionPorVoz2 seleccionInteraccionPorVoz = new SeleccionInteraccionPorVoz2();
        SeleccionApis2 seleccionApis = new SeleccionApis2();
        EyeTrackingConfiguration2 eyeTrackingConfig = new EyeTrackingConfiguration2();
        TextRecognitionSettings textRecognitionSettings = new TextRecognitionSettings();
        GestureRecognitionSettings gestureRecognitionSettings = new GestureRecognitionSettings();
        //InteractionCoordinator interactionCoordinator = new InteractionCoordinator();
        //SeleccionApis seleccionapis1 = new SeleccionApis();
        ProjectionScreen projectionScreenForm = new ProjectionScreen();
        public PageDetectionSettings pageDetectionSettings;
        public ProjectionScreenActivity2 projectionScreenActivity2;
        int posY = 0;//Variables para mover el formulario con el mouse presionan el panel superior
        int posX = 0;
        public MenuSettings()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            alertBox = new AlertBox(this, seleccionInteraccionPorVoz, seleccionApis, textRecognitionSettings, gestureRecognitionSettings,bandera);
            pageDetectionSettings = new PageDetectionSettings();
            projectionScreenActivity2 = new ProjectionScreenActivity2(pageDetectionSettings, textRecognitionSettings, gestureRecognitionSettings);
            
            //projectionScreenActivity2 = new ProjectionScreenActivity2();
            //seleccionInteraccionPorVoz.btn_guardar.Visible = false;
            
            //ProjectionScreenForm.Show();
        }
        


        private void MenuSettings_Load(object sender, EventArgs e)
        {
            GetAllSettings(seleccionInteraccionPorVoz,seleccionApis, textRecognitionSettings, gestureRecognitionSettings);
            /*
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(".../Fonts/IBMPlexSans-Regular.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 15, FontStyle.Bold);
            }*/
            //LoadingPictureBox.Visible = false;//Gif de carga parte invisible PUEDE SER OPTIMIZADO
        }
        private void ContenidoNavBar_Paint(object sender, PaintEventArgs e)
        {
            Graphics gOject = ContenidoNavBar.CreateGraphics();//Código para dibujar la linea bajo del label Settings
            Brush separador = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(separador, 1);
            gOject.DrawLine(blackPen, 0, 47, 213, 47);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ExitIconPictureBox(object sender, EventArgs e)
        {

        }

        private void ExitIconPictureBox_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                formBackground.StartPosition = FormStartPosition.Manual;
                formBackground.FormBorderStyle = FormBorderStyle.None;
                formBackground.Opacity = .50d;
                formBackground.BackColor = Color.Black;
                formBackground.WindowState = FormWindowState.Normal;
                formBackground.Width = 1280;
                formBackground.Height = 720;
                formBackground.TopMost = true;
                formBackground.Location = this.Location;
                formBackground.ShowInTaskbar = false;
                formBackground.Show();

                alertBox.bandera = "exit";
                alertBox.label1.Text = "¿Are you sure you want to close the application?";
                alertBox.label2.Text = "If you have not saved any settings, they will be lost for the next session.";
                alertBox.okButton.Visible = false;
                alertBox.buttonModified1.Visible = true;
                alertBox.buttonModified2.Visible = true;
                SaveAllSettings(seleccionInteraccionPorVoz, seleccionApis, textRecognitionSettings, gestureRecognitionSettings);
                alertBox.StartPosition = FormStartPosition.CenterScreen;
                alertBox.Location = this.Location;
                alertBox.ShowDialog();

                formBackground.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }



            //if (MessageBox.Show("Está seguro de cerrar?", "Mensaje de Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)//Mensaje de alerta tras presionar la X para cerrar
            //{
            //    //Acá debe venir el código que mantiene guardado los ajustes antes de cerrar
            //    Application.Exit();
            //}

        }

        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Evento para mover la ventana al mantener el click izquierdo en el panel superior
        private void PanelBarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;

            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void PanelContenido_Paint(object sender, PaintEventArgs e)
        {

        }
        //Método para abrir un form en el PanelContenido
        private void AbrirFormEnPanel(Form formHijo)//OPTIMIZAR ESTO
        {
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.PanelContenido.Controls.Add(formHijo);
            this.PanelContenido.Tag = formHijo;
            //Problema aqui
            formHijo.Show();
            formHijo.BringToFront();
        }
        private void GetAllSettings(SeleccionInteraccionPorVoz2 interactionSettings, SeleccionApis2 seleccionApisSettings, TextRecognitionSettings textRecognitionSettings, GestureRecognitionSettings gestureRecognitionSettings)
        {
            if (Properties.Settings2.Default.buttonDisplay == "Yes")
            {
                interactionSettings.rbtn_Si_botones.Checked = true;
            }
            if (Properties.Settings2.Default.buttonDisplay == "No")
            {
                interactionSettings.rbtn_no_botones.Checked = true;
            }
            if (Properties.Settings2.Default.voiceInteraction == "Yes")
            {
                interactionSettings.rbtn_voz_si.Checked = true;
            }
            if (Properties.Settings2.Default.voiceInteraction == "No")
            {
                interactionSettings.rbtn_voz_no.Checked = true;
            }
            //Configuraciones de seleccion de apis
            seleccionApisSettings.cbx_apisDefiniciones.Text = Properties.Settings2.Default.definitionApi;
            seleccionApisSettings.cbx_apisEnciclopedia.Text = Properties.Settings2.Default.encyclopediaApi;
            //seleccionApisSettings.cbx_apisEnciclopedia.SelectedIndex = Properties.Settings2.Default.encyclopediaApiIndex;
            seleccionApisSettings.cbx_apisVideos.Text = Properties.Settings2.Default.videoApi;
            seleccionApisSettings.cbx_apisImagenes.Text = Properties.Settings2.Default.imageApi;
            seleccionApisSettings.cbx_apisTraducciones.Text = Properties.Settings2.Default.translationApi;
            seleccionApisSettings.cbx_idiomaTraducir.Text = Properties.Settings2.Default.languageTranslate;
            //Configuraciones de TextRecognitionSettings
            textRecognitionSettings._CameraTextIndex = Properties.Settings2.Default.cameraTextIndex;//Se cambia la variable
            //Correccion error "no se encuentra camara"
            try
            {
                textRecognitionSettings.ComboBoxCameraList1.SelectedIndex = Properties.Settings2.Default.cameraTextIndex;  //La parte visual del cbox
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Connect 2 cameras to start EDDIE.", "Problem");
                Console.WriteLine(Properties.Settings2.Default.cameraTextIndex);
                Environment.Exit(1);
            }
            textRecognitionSettings.numericUpDownResXText.Value = Properties.Settings2.Default.cameraTextWidth;
            textRecognitionSettings.numericUpDownResYText.Value = Properties.Settings2.Default.cameraTextHeight;
            //Configuraciones de GestureRecognitionSettings
            gestureRecognitionSettings._CameraGestureIndex = Properties.Settings2.Default.cameraGestureIndex;//Se cambia la variable
            try
            {
                gestureRecognitionSettings.ComboBoxCameraList2.SelectedIndex = Properties.Settings2.Default.cameraGestureIndex;//La parte visual del cbox
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.Write("falta una camara");
            }
            gestureRecognitionSettings.numericUpDownXGestual.Value = Properties.Settings2.Default.cameraGestureWidth;
            gestureRecognitionSettings.numericUpDownYGestual.Value = Properties.Settings2.Default.cameraGestureHeight;
            gestureRecognitionSettings.comboBox1.SelectedIndex = Properties.Settings2.Default.gestureComplementIndex;
            gestureRecognitionSettings.numericUpDownSStartX.Value = Properties.Settings2.Default.gestureValorX1;
            gestureRecognitionSettings.numericUpDownSStartY.Value = Properties.Settings2.Default.gestureValorY1;
            gestureRecognitionSettings.numericUpDownSEndX.Value = Properties.Settings2.Default.gestureValorX2;
            gestureRecognitionSettings.numericUpDownSEndY.Value = Properties.Settings2.Default.gestureValorY2;
            gestureRecognitionSettings.checkBoxMouse.Checked = Properties.Settings2.Default.gestureRecognitionOnChecked;
            //Codigo de guardado de SeleccionInteraccionPorVoz
            if (seleccionInteraccionPorVoz.rbtn_voz_si.Checked && seleccionInteraccionPorVoz.rbtn_Si_botones.Checked)
            {
                SeleccionInteraccionPorVoz2.activarBusquedaVoz = seleccionInteraccionPorVoz.rbtn_voz_si.Text;
                SeleccionInteraccionPorVoz2.mostrarBotonesconVoz = seleccionInteraccionPorVoz.rbtn_Si_botones.Text;
                //MessageBox.Show("Ha seleccionado la opción de interacción por voz");
                //this.Hide();
            }
            if (seleccionInteraccionPorVoz.rbtn_voz_si.Checked && seleccionInteraccionPorVoz.rbtn_no_botones.Checked)
            {
                SeleccionInteraccionPorVoz2.activarBusquedaVoz = seleccionInteraccionPorVoz.rbtn_voz_si.Text;
                SeleccionInteraccionPorVoz2.mostrarBotonesconVoz = seleccionInteraccionPorVoz.rbtn_no_botones.Text;
                //MessageBox.Show("Ha seleccionado la opción de interacción por voz");
                //this.Hide();
            }
            if (seleccionInteraccionPorVoz.rbtn_voz_no.Checked)
            {
                SeleccionInteraccionPorVoz2.activarBusquedaVoz = seleccionInteraccionPorVoz.rbtn_voz_no.Text;
                //MessageBox.Show("Ha seleccionado la opción de interacción por botones");
                //this.Hide();
            }
            //Codigo de boton de guardado de SeleccionApis
            SeleccionApis2.apiSeleccionadaEnciclopedia = seleccionApisSettings.cbx_apisEnciclopedia.Text;
            SeleccionApis2.apiSeleccionadaDefinicion = seleccionApisSettings.cbx_apisDefiniciones.Text;
            SeleccionApis2.apiSeleccionadaTraduccion = seleccionApisSettings.cbx_apisTraducciones.Text;
            SeleccionApis2.apiSeleccionadaVideo = seleccionApisSettings.cbx_apisVideos.Text;
            SeleccionApis2.apiSeleccionadaImagen = seleccionApisSettings.cbx_apisImagenes.Text;
            SeleccionApis2.idiomaSeleccionadoTraduccion = seleccionApisSettings.cbx_idiomaTraducir.Text;
        }
        public void SaveAllSettings(SeleccionInteraccionPorVoz2 interactionSettings, SeleccionApis2 seleccionApisSettings, TextRecognitionSettings textRecognitionSettings, GestureRecognitionSettings gestureRecognitionSettings)
        {
            //Configuraciones de interactionSettings
            if (interactionSettings.rbtn_Si_botones.Checked == true)
            {
                Properties.Settings2.Default.buttonDisplay = "Yes";
            }
            if (interactionSettings.rbtn_no_botones.Checked == true)
            {
                Properties.Settings2.Default.buttonDisplay = "No";
            }
            if (interactionSettings.rbtn_voz_si.Checked == true)
            {
                Properties.Settings2.Default.voiceInteraction = "Yes";
            }
            if (interactionSettings.rbtn_voz_no.Checked == true)
            {
                Properties.Settings2.Default.voiceInteraction = "No";
            }
            //Configuraciones de seleccion de apis
            Properties.Settings2.Default.definitionApi = seleccionApisSettings.cbx_apisDefiniciones.Text;
            
            Properties.Settings2.Default.encyclopediaApi = seleccionApisSettings.cbx_apisEnciclopedia.Text;
            Properties.Settings2.Default.encyclopediaApiIndex = seleccionApisSettings.cbx_apisEnciclopedia.SelectedIndex;

            Properties.Settings2.Default.videoApi = seleccionApisSettings.cbx_apisVideos.Text;
            Properties.Settings2.Default.imageApi = seleccionApisSettings.cbx_apisImagenes.Text;
            Properties.Settings2.Default.translationApi = seleccionApisSettings.cbx_apisTraducciones.Text;
            Properties.Settings2.Default.languageTranslate = seleccionApisSettings.cbx_idiomaTraducir.Text;
            //Configuraciones de TextRecognitionSettings
            Properties.Settings2.Default.cameraTextIndex = textRecognitionSettings._CameraTextIndex;
            Properties.Settings2.Default.cameraTextWidth = textRecognitionSettings.numericUpDownResXText.Value;
            Properties.Settings2.Default.cameraTextHeight = textRecognitionSettings.numericUpDownResYText.Value;
            //Configuraciones de GestureRecognitionSettings
            Properties.Settings2.Default.cameraGestureIndex = gestureRecognitionSettings._CameraGestureIndex;
            Properties.Settings2.Default.cameraGestureWidth = gestureRecognitionSettings.numericUpDownXGestual.Value;
            Properties.Settings2.Default.cameraGestureHeight = gestureRecognitionSettings.numericUpDownYGestual.Value;
            Properties.Settings2.Default.gestureComplementIndex = gestureRecognitionSettings.comboBox1.SelectedIndex;
            Properties.Settings2.Default.gestureValorX1 = (int)gestureRecognitionSettings.numericUpDownSStartX.Value;
            Properties.Settings2.Default.gestureValorY1 = (int)gestureRecognitionSettings.numericUpDownSStartY.Value;
            Properties.Settings2.Default.gestureValorX2 = (int)gestureRecognitionSettings.numericUpDownSEndX.Value;
            Properties.Settings2.Default.gestureValorY2 = (int)gestureRecognitionSettings.numericUpDownSEndY.Value;
            if (gestureRecognitionSettings.checkBoxMouse.Checked == true)
            {
                Properties.Settings2.Default.gestureRecognitionOnChecked = true;
            }
            if (gestureRecognitionSettings.checkBoxMouse.Checked == false)
            {
                Properties.Settings2.Default.gestureRecognitionOnChecked = false;
            }
            //Se modifica el formulario de seleccionInteraccionPorVoz
            if (seleccionInteraccionPorVoz.rbtn_voz_si.Checked && seleccionInteraccionPorVoz.rbtn_Si_botones.Checked)
            {
                SeleccionInteraccionPorVoz2.activarBusquedaVoz = seleccionInteraccionPorVoz.rbtn_voz_si.Text;
                SeleccionInteraccionPorVoz2.mostrarBotonesconVoz = seleccionInteraccionPorVoz.rbtn_Si_botones.Text;
                //MessageBox.Show("Ha seleccionado la opción de interacción por voz");
                //this.Hide();
            }
            if (seleccionInteraccionPorVoz.rbtn_voz_si.Checked && seleccionInteraccionPorVoz.rbtn_no_botones.Checked)
            {
                SeleccionInteraccionPorVoz2.activarBusquedaVoz = seleccionInteraccionPorVoz.rbtn_voz_si.Text;
                SeleccionInteraccionPorVoz2.mostrarBotonesconVoz = seleccionInteraccionPorVoz.rbtn_no_botones.Text;
                //MessageBox.Show("Ha seleccionado la opción de interacción por voz");
                //this.Hide();
            }
            if (seleccionInteraccionPorVoz.rbtn_voz_no.Checked)
            {
                SeleccionInteraccionPorVoz2.activarBusquedaVoz = seleccionInteraccionPorVoz.rbtn_voz_no.Text;
                //MessageBox.Show("Ha seleccionado la opción de interacción por botones");
                //this.Hide();
            }

            //Guardado de todos los valores default
            Properties.Settings2.Default.Save();

        }
        public void ResetAllSettings(SeleccionInteraccionPorVoz2 interactionSettings, SeleccionApis2 seleccionApisSettings, TextRecognitionSettings textRecognitionSettings, GestureRecognitionSettings gestureRecognitionSettings)
        {
            interactionSettings.rbtn_Si_botones.Checked = false;
            interactionSettings.rbtn_no_botones.Checked = false;
            interactionSettings.rbtn_voz_si.Checked = false;
            interactionSettings.rbtn_voz_no.Checked = false;
            //Resetear valores default
            Properties.Settings2.Default.Reset();
            Properties.Settings2.Default.Save();
            GetAllSettings(seleccionInteraccionPorVoz, seleccionApis, textRecognitionSettings, gestureRecognitionSettings);
            //SaveAllSettings(seleccionInteraccionPorVoz, seleccionApis, textRecognitionSettings, gestureRecognitionSettings);
        }
        //A Continuación los eventos click de los botones del navBar vertical
        private void InteractionsButton_Click(object sender, EventArgs e)
        {
            changeAllToLightFont();
            InteractionsButton.Font = new Font(InteractionsButton.Font, FontStyle.Bold);
            //AbrirFormEnPanel(InteractionsForm);
            AbrirFormEnPanel(seleccionInteraccionPorVoz);
            /*
            //Método para abrir el form InteractionsSettings
            InteractionsSettings fm = new InteractionsSettings();
            //fm.FormClosed += new FormClosedEventHandler();
            //AbrirFormEnPanel(fm);
            */
        }

        private void WebSearchServicesButton_Click(object sender, EventArgs e)
        {
            changeAllToLightFont();
            WebSearchServicesButton.Font = new Font(WebSearchServicesButton.Font, FontStyle.Bold);
            AbrirFormEnPanel(seleccionApis);

            /*
            //Método para abrir el form WebSearchServicesSettings
            WebSearchServicesSettings fm = new WebSearchServicesSettings();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
            */
        }

        private void EyeTrackingButton_Click(object sender, EventArgs e)
        {
            changeAllToLightFont();
            EyeTrackingButton.Font = new Font(EyeTrackingButton.Font, FontStyle.Bold);
            AbrirFormEnPanel(eyeTrackingConfig);
            //problema aqui
        }
        private void TextRecognitiionButton_Click(object sender, EventArgs e)
        {
            changeAllToLightFont();
            TextRecognitiionButton.Font = new Font(TextRecognitiionButton.Font, FontStyle.Bold);
            AbrirFormEnPanel(textRecognitionSettings);
        }
        private void GestureRecognitionButton_Click(object sender, EventArgs e)
        {
            changeAllToLightFont();
            GestureRecognitionButton.Font = new Font(GestureRecognitionButton.Font, FontStyle.Bold);
            AbrirFormEnPanel(gestureRecognitionSettings);
        }
        private void PageDetectionButton_Click(object sender, EventArgs e)
        {
            changeAllToLightFont();
            PageDetectionButton.Font = new Font(PageDetectionButton.Font, FontStyle.Bold);
            AbrirFormEnPanel(pageDetectionSettings);
        }
        //Evento para desplegar la interfaz de realidad aumentada
        private async void StartProjectionButton_Click(object sender, EventArgs e)
        {
            mostrarLoading();
            Task task = new Task(dummySleep);//Se simula un estado de cargando
            task.Start();
            await task;
            projectionScreenActivity2.Show();
            //ProjectionScreenForm.Show();
            ocultarLoading();
            
        }
        private void dummySleep()//Función para simular carga
        {
            Thread.Sleep(1000);
        }
        private void mostrarLoading()
        {
            LoadingPictureBox.Visible = true;
        }
        private void ocultarLoading()
        {
            LoadingPictureBox.Visible = false;
        }
        private void changeAllToLightFont()//Función para quitar el Bold a todos los botones del navbar
        {
            InteractionsButton.Font = new Font(InteractionsButton.Font, FontStyle.Regular);
            WebSearchServicesButton.Font = new Font(WebSearchServicesButton.Font, FontStyle.Regular);
            EyeTrackingButton.Font = new Font(EyeTrackingButton.Font, FontStyle.Regular);
            TextRecognitiionButton.Font = new Font(TextRecognitiionButton.Font, FontStyle.Regular);
            GestureRecognitionButton.Font = new Font(GestureRecognitionButton.Font, FontStyle.Regular);
            PageDetectionButton.Font = new Font(PageDetectionButton.Font, FontStyle.Regular);
        }

        private async void StartProjectionButtonModified_Click(object sender, EventArgs e)//Evento que muestra la interfaz de RA
        {
            mostrarLoading();
            Task task = new Task(dummySleep);
            task.Start();
            await task;
            //ProjectionScreenForm.Show();
            ocultarLoading();
        }

        private async void StartProjectionButtonModified_Click_1(object sender, EventArgs e)
        {
            try
            {

                projectionScreenActivity2.LoadingShow(this);
                
                //Configuraciones de Text Recognition Settings
                var CameraNumber = textRecognitionSettings._CameraTextIndex;
                //Se cambia projectionScreenActivity luego del if para que se muestre la interfaz proyectada sin interrupcion
                //projectionScreenActivity2.Show();

                if (textRecognitionSettings.captureText == null)
                {
                    textRecognitionSettings.captureText = new VideoCapture(CameraNumber);
                    textRecognitionSettings.captureText.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth, (double)textRecognitionSettings.numericUpDownResXText.Value);
                    textRecognitionSettings.captureText.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight, (double)textRecognitionSettings.numericUpDownResYText.Value);

                    textRecognitionSettings.imageBox1.Image = textRecognitionSettings.recTxt.Recognition(textRecognitionSettings.captureText);
                }
                projectionScreenActivity2.Show();
                Thread.Sleep(10);
                projectionScreenActivity2.LoadingClose();
            }
            catch
            {

            }
            //LoadingPictureBox.Show();
            //progressBox.StartPosition = FormStartPosition.CenterScreen;
            //progressBox.Show();
            //mostrarLoading();
            //Task task = new Task(dummySleep);
            //task.Start();
            //await task;
            //ProjectionScreenForm.Show();
            
            
           
            //progressBox.Close();
            //ocultarLoading();
            //LoadingPictureBox.Hide();
        }//IDENTIFICAR EL MENSAJE "No hay reconocedor instalado"

        private void SaveSettingsButtonModified_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                formBackground.StartPosition = FormStartPosition.Manual;
                formBackground.FormBorderStyle = FormBorderStyle.None;
                formBackground.Opacity = .50d;
                formBackground.BackColor = Color.Black;
                formBackground.WindowState = FormWindowState.Normal;
                formBackground.Width = 1280;
                formBackground.Height = 720;
                formBackground.TopMost = true;
                formBackground.Location = this.Location;
                formBackground.ShowInTaskbar = false;
                formBackground.Show();

                alertBox.bandera = "save";
                alertBox.label1.Text = "¡Changes have been saved!";
                alertBox.label2.Text = "The settings made will be saved for subsequent sessions";
                alertBox.okButton.Visible = true;
                alertBox.buttonModified1.Visible = false;
                alertBox.buttonModified2.Visible = false;
                SaveAllSettings(seleccionInteraccionPorVoz, seleccionApis, textRecognitionSettings, gestureRecognitionSettings);
                alertBox.StartPosition = FormStartPosition.CenterScreen;
                alertBox.Location = this.Location;
                alertBox.ShowDialog();

                formBackground.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }




            //manto.Show();

            SaveAllSettings(seleccionInteraccionPorVoz, seleccionApis, textRecognitionSettings, gestureRecognitionSettings);
            GetAllSettings(seleccionInteraccionPorVoz, seleccionApis, textRecognitionSettings, gestureRecognitionSettings);
            //Codigo de guardado de SeleccionInteraccionPorVoz
            if (seleccionInteraccionPorVoz.rbtn_voz_si.Checked && seleccionInteraccionPorVoz.rbtn_Si_botones.Checked)
            {
                SeleccionInteraccionPorVoz2.activarBusquedaVoz = seleccionInteraccionPorVoz.rbtn_voz_si.Text;
                SeleccionInteraccionPorVoz2.mostrarBotonesconVoz = seleccionInteraccionPorVoz.rbtn_Si_botones.Text;
                //MessageBox.Show("Ha seleccionado la opción de interacción por voz");
                //this.Hide();
            }
            if (seleccionInteraccionPorVoz.rbtn_voz_si.Checked && seleccionInteraccionPorVoz.rbtn_no_botones.Checked)
            {
                SeleccionInteraccionPorVoz2.activarBusquedaVoz = seleccionInteraccionPorVoz.rbtn_voz_si.Text;
                SeleccionInteraccionPorVoz2.mostrarBotonesconVoz = seleccionInteraccionPorVoz.rbtn_no_botones.Text;
                //MessageBox.Show("Ha seleccionado la opción de interacción por voz");
                //this.Hide();
            }
            if (seleccionInteraccionPorVoz.rbtn_voz_no.Checked)
            {
                SeleccionInteraccionPorVoz2.activarBusquedaVoz = seleccionInteraccionPorVoz.rbtn_voz_no.Text;
                //MessageBox.Show("Ha seleccionado la opción de interacción por botones");
                //this.Hide();
            }
            //Codigo de boton de guardado de SeleccionApis
            SeleccionApis2.apiSeleccionadaEnciclopedia = seleccionApis.cbx_apisEnciclopedia.GetItemText(seleccionApis.cbx_apisEnciclopedia.SelectedItem);
            SeleccionApis2.apiSeleccionadaDefinicion = seleccionApis.cbx_apisDefiniciones.GetItemText(seleccionApis.cbx_apisDefiniciones.SelectedItem);
            SeleccionApis2.apiSeleccionadaTraduccion = seleccionApis.cbx_apisTraducciones.GetItemText(seleccionApis.cbx_apisTraducciones.SelectedItem);
            SeleccionApis2.apiSeleccionadaVideo = seleccionApis.cbx_apisVideos.GetItemText(seleccionApis.cbx_apisVideos.SelectedItem);
            SeleccionApis2.apiSeleccionadaImagen = seleccionApis.cbx_apisImagenes.GetItemText(seleccionApis.cbx_apisImagenes.SelectedItem);
            SeleccionApis2.idiomaSeleccionadoTraduccion = seleccionApis.cbx_idiomaTraducir.GetItemText(seleccionApis.cbx_idiomaTraducir.SelectedValue);
            //MessageBox.Show("Apis seleccionadas con éxito");

        }

        private void ResetSettingsButtonModified_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                formBackground.StartPosition = FormStartPosition.Manual;
                formBackground.FormBorderStyle = FormBorderStyle.None;
                formBackground.Opacity = .50d;
                formBackground.BackColor = Color.Black;
                formBackground.WindowState = FormWindowState.Normal;
                formBackground.Width = 1280;
                formBackground.Height = 720;
                formBackground.TopMost = true;
                formBackground.Location = this.Location;
                formBackground.ShowInTaskbar = false;
                formBackground.Show();

                alertBox.bandera = "reset";
                alertBox.label1.Text = "¿Are you sure to do this action?";
                alertBox.label2.Text = "If you reset the settings, the changes made to the settings so far will be lost";
                alertBox.okButton.Visible = false;
                alertBox.buttonModified1.Visible = true;
                alertBox.buttonModified2.Visible = true;
                alertBox.StartPosition = FormStartPosition.CenterScreen;
                alertBox.Location = this.Location;
                alertBox.ShowDialog();

                formBackground.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }



            ///
            
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorkerStartProjection_DoWork(object sender, DoWorkEventArgs e)
        {
            //progressBox.Show();
        }

        private void backgroundWorkerStartProjection_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorkerStartProjection_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //progressBox.Close();
        }
    }
}
