using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;//Para redondear los bordes del form

namespace AugmentedReadingApp
{
    public partial class ProjectionScreen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        //DictionaryPanel dictionaryPanel = new DictionaryPanel();
        public ProjectionScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; //Para redondear los bordes del form
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        int posY = 0;//Variable para mover el formulario con el mouse
        int posX = 0;//Variable para mover el formulario con el mouse
        //Valores para indicar si los botones fueron clickeados y estan activados
        bool dictionaryActived = false;
        bool encyclopediaActived= false;
        bool translatorActived = false;
        bool imagesActived = false;
        bool videosActived = false;
        bool bookmarkActived = false;
        bool commentsActived = false;
        bool figuresActived = false;
        bool contentActived = false;
        bool historyActived = false;
        //Valores para indicar que los botones principales fueron clicleados
        bool webSearchButtonActived = false;
        bool syncronizerButtonActived = false;
        bool capturesButtonActived = true;
        

        private void ProjectionScreen_Load(object sender, EventArgs e)
        {

        }
        //Evento para mover la ventana al mantener el click derecho en cualquier parte del form que no sea un botón o panel
        private void ProjectionScreen_MouseMove(object sender, MouseEventArgs e)
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
        private void WebSearcherButton_Click(object sender, EventArgs e)
        {
            

        }

        private void SynchronizerButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ModeButton_Click(object sender, EventArgs e)
        {
            if(capturesButtonActived == true){
                capturesButtonActived = false;
                CapturedContentLabel.Visible = false;
                CapturedContentPanel.Visible = false;
                HighlightModeLabel.Visible = true;
                SyncHighlightImageButton.Visible = true;
            }
            else
            {
                capturesButtonActived = true;
                CapturedContentLabel.Visible = true;
                CapturedContentPanel.Visible = true;
                HighlightModeLabel.Visible = false;
                SyncHighlightImageButton.Visible = false;
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void DeFormAPanelIzquierdo(Form formHijo)//OPTIMIZAR ESTO
        {
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.LeftPanel.Controls.Add(formHijo);
            this.LeftPanel.Tag = formHijo;
            formHijo.Show();
            formHijo.BringToFront();
        }

        private void LeftPanel_Paint(object sender, PaintEventArgs e)
        {
        }
        //Diccionario
        private void DictionaryImageButton_Click(object sender, EventArgs e)
        {
            if(dictionaryActived == false){
                DictionaryImageButton.Image = AugmentedReadingApp.Properties.Resources.DiccionarioButtonClicked;
                dictionaryActived = true;
                //DeFormAPanelIzquierdo(dictionaryPanel);
            }
            else
            {
                DictionaryImageButton.Image = AugmentedReadingApp.Properties.Resources.DiccionarioButtonImage;
                dictionaryActived = false;
            }
        }

        private void DictionaryImageButton_MouseEnter(object sender, EventArgs e)
        {
            if (dictionaryActived == true)
            {

            }
            else
            {
                DictionaryImageButton.Image = AugmentedReadingApp.Properties.Resources.DiccionarioButtonHover;
            }
            
        }

        private void DictionaryImageButton_MouseLeave(object sender, EventArgs e)
        {
            if(dictionaryActived == true){
                
            }
            else
            {
                DictionaryImageButton.Image = AugmentedReadingApp.Properties.Resources.DiccionarioButtonImage;
            }
            
        }
        //Encyclopedia
        private void EncyclopediaImageButton_Click(object sender, EventArgs e)
        {
            if (encyclopediaActived == false)
            {
                EncyclopediaImageButton.Image = AugmentedReadingApp.Properties.Resources.EncyclopediaButtonClicked;
                encyclopediaActived = true;
                //DeFormAPanelIzquierdo(dictionaryPanel);
            }
            else
            {
                EncyclopediaImageButton.Image = AugmentedReadingApp.Properties.Resources.EncyclopediaButtonImage;
                encyclopediaActived = false;
            }
        }

        private void EncyclopediaImageButton_MouseEnter(object sender, EventArgs e)
        {
            if (encyclopediaActived == true)
            {

            }
            else
            {
                EncyclopediaImageButton.Image = AugmentedReadingApp.Properties.Resources.EncyclopediaButtonHover;
            }
        }

        private void EncyclopediaImageButton_MouseLeave(object sender, EventArgs e)
        {
            if (encyclopediaActived == true)
            {

            }
            else
            {
                EncyclopediaImageButton.Image = AugmentedReadingApp.Properties.Resources.EncyclopediaButtonImage;
            }
        }

        private void TranslatorImageButton_Click(object sender, EventArgs e)
        {
            if (translatorActived == false)
            {
                TranslatorImageButton.Image = AugmentedReadingApp.Properties.Resources.TraductorButtonClicked;
                translatorActived = true;
                //DeFormAPanelIzquierdo();//Agregar contenido al panel izquierdo
            }
            else
            {
                TranslatorImageButton.Image = AugmentedReadingApp.Properties.Resources.TraductorButtonImage;
                translatorActived = false;
            }
        }

        private void TranslatorImageButton_MouseEnter(object sender, EventArgs e)
        {
            if (translatorActived == true)
            {

            }
            else
            {
                TranslatorImageButton.Image = AugmentedReadingApp.Properties.Resources.TraductorButtonHover;
            }
        }

        private void TranslatorImageButton_MouseLeave(object sender, EventArgs e)
        {
            if (translatorActived == true)
            {

            }
            else
            {
                TranslatorImageButton.Image = AugmentedReadingApp.Properties.Resources.TraductorButtonImage;
            }
        }

        private void ImagesImageButton_Click(object sender, EventArgs e)
        {
            if (imagesActived == false)
            {
                ImagesImageButton.Image = AugmentedReadingApp.Properties.Resources.ImagesButtonClicked;
                imagesActived = true;
                //DeFormAPanelIzquierdo();//Agregar contenido al panel izquierdo
            }
            else
            {
                ImagesImageButton.Image = AugmentedReadingApp.Properties.Resources.ImagesButtonImage;
                imagesActived = false;
            }
        }

        private void ImagesImageButton_MouseEnter(object sender, EventArgs e)
        {
            if (imagesActived == true)
            {

            }
            else
            {
                ImagesImageButton.Image = AugmentedReadingApp.Properties.Resources.ImagesButtonHover;
            }
        }

        private void ImagesImageButton_MouseLeave(object sender, EventArgs e)
        {
            if (imagesActived == true)
            {

            }
            else
            {
                ImagesImageButton.Image = AugmentedReadingApp.Properties.Resources.ImagesButtonImage;
            }
        }

        private void VideosImageButton_Click(object sender, EventArgs e)
        {
            if (videosActived == false)
            {
                VideosImageButton.Image = AugmentedReadingApp.Properties.Resources.VideoButtonClicked;
                videosActived = true;
                //DeFormAPanelIzquierdo();//Agregar contenido al panel izquierdo
            }
            else
            {
                VideosImageButton.Image = AugmentedReadingApp.Properties.Resources.VideoButtonImage;
                videosActived = false;
            }
        }

        private void VideosImageButton_MouseEnter(object sender, EventArgs e)
        {
            if (videosActived == true)
            {

            }
            else
            {
                VideosImageButton.Image = AugmentedReadingApp.Properties.Resources.VideoButtonHover;
            }
        }

        private void VideosImageButton_MouseLeave(object sender, EventArgs e)
        {
            if (videosActived == true)
            {

            }
            else
            {
                VideosImageButton.Image = AugmentedReadingApp.Properties.Resources.VideoButtonImage;
            }
        }

        private void BookmarkImageButton_Click(object sender, EventArgs e)
        {
            if (bookmarkActived == false)
            {
                BookmarkImageButton.Image = AugmentedReadingApp.Properties.Resources.BookmarkButtonClicked;
                bookmarkActived = true;
                //DeFormAPanelIzquierdo();//Agregar contenido al panel izquierdo
            }
            else
            {
                BookmarkImageButton.Image = AugmentedReadingApp.Properties.Resources.BookmarkButtonImage;
                bookmarkActived = false;
            }
        }

        private void BookmarkImageButton_MouseEnter(object sender, EventArgs e)
        {
            if (bookmarkActived == true)
            {

            }
            else
            {
                BookmarkImageButton.Image = AugmentedReadingApp.Properties.Resources.BookmarkButtonHover;
            }
        }

        private void BookmarkImageButton_MouseLeave(object sender, EventArgs e)
        {
            if (bookmarkActived == true)
            {

            }
            else
            {
                BookmarkImageButton.Image = AugmentedReadingApp.Properties.Resources.BookmarkButtonImage;
            }

        }

        private void CommentsImageButton_Click(object sender, EventArgs e)
        {
            if (commentsActived == false)
            {
                CommentsImageButton.Image = AugmentedReadingApp.Properties.Resources.CommentsButtonClicked;
                commentsActived = true;
                //DeFormAPanelIzquierdo();//Agregar contenido al panel izquierdo
            }
            else
            {
                CommentsImageButton.Image = AugmentedReadingApp.Properties.Resources.CommentsButtonImage;
                commentsActived = false;
            }
        }

        private void CommentsImageButton_MouseEnter(object sender, EventArgs e)
        {
            if (commentsActived == true)
            {

            }
            else
            {
                CommentsImageButton.Image = AugmentedReadingApp.Properties.Resources.CommentsButtonHover;
            }
        }

        private void CommentsImageButton_MouseLeave(object sender, EventArgs e)
        {
            if (commentsActived == true)
            {

            }
            else
            {
                CommentsImageButton.Image = AugmentedReadingApp.Properties.Resources.CommentsButtonImage;
            }
        }

        private void FiguresImageButton_Click(object sender, EventArgs e)
        {
            if (figuresActived == false)
            {
                FiguresImageButton.Image = AugmentedReadingApp.Properties.Resources.FiguresButtonnClicked;
                figuresActived = true;
                //DeFormAPanelIzquierdo();//Agregar contenido al panel izquierdo
            }
            else
            {
                FiguresImageButton.Image = AugmentedReadingApp.Properties.Resources.FiguresButtonnImage;
                figuresActived = false;
            }
        }

        private void FiguresImageButton_MouseEnter(object sender, EventArgs e)
        {
            if (figuresActived == true)
            {

            }
            else
            {
                FiguresImageButton.Image = AugmentedReadingApp.Properties.Resources.FiguresButtonnHover;
            }
        }

        private void FiguresImageButton_MouseLeave(object sender, EventArgs e)
        {
            if (figuresActived == true)
            {

            }
            else
            {
                FiguresImageButton.Image = AugmentedReadingApp.Properties.Resources.FiguresButtonnImage;
            }
        }

        private void ContentImageButton_Click(object sender, EventArgs e)
        {
            if (contentActived == false)
            {
                ContentImageButton.Image = AugmentedReadingApp.Properties.Resources.ContentButtonClicked;
                contentActived = true;
                //DeFormAPanelIzquierdo();//Agregar contenido al panel izquierdo
            }
            else
            {
                ContentImageButton.Image = AugmentedReadingApp.Properties.Resources.ContentButtonImage;
                contentActived = false;
            }
        }

        private void ContentImageButton_MouseEnter(object sender, EventArgs e)
        {
            if (contentActived == true)
            {

            }
            else
            {
                ContentImageButton.Image = AugmentedReadingApp.Properties.Resources.ContentButtonHover;
            }
        }

        private void ContentImageButton_MouseLeave(object sender, EventArgs e)
        {
            if (contentActived == true)
            {

            }
            else
            {
                ContentImageButton.Image = AugmentedReadingApp.Properties.Resources.ContentButtonImage;
            }
        }

        

        private void LeftArrowImageButton_MouseDown(object sender, MouseEventArgs e)
        {
            LeftArrowImageButton.Image = AugmentedReadingApp.Properties.Resources.LeftArrowButtonClicked;
        }

        private void LeftArrowImageButton_MouseUp(object sender, MouseEventArgs e)
        {
            LeftArrowImageButton.Image = AugmentedReadingApp.Properties.Resources.LeftArrowButtonHover;
        }

        private void LeftArrowImageButton_MouseEnter(object sender, EventArgs e)
        {
            LeftArrowImageButton.Image = AugmentedReadingApp.Properties.Resources.LeftArrowButtonHover;
        }

        private void LeftArrowImageButton_MouseLeave(object sender, EventArgs e)
        {
            LeftArrowImageButton.Image = AugmentedReadingApp.Properties.Resources.LeftArrowButtonImage;
        }

        private void RightArrowImageButton_MouseDown(object sender, MouseEventArgs e)
        {
            RightArrowImageButton.Image = AugmentedReadingApp.Properties.Resources.RightArrowButtonClicked;
        }

        private void RightArrowImageButton_MouseUp(object sender, MouseEventArgs e)
        {
            RightArrowImageButton.Image = AugmentedReadingApp.Properties.Resources.RightArrowButtonHover;
        }

        private void RightArrowImageButton_MouseEnter(object sender, EventArgs e)
        {
            RightArrowImageButton.Image = AugmentedReadingApp.Properties.Resources.RightArrowButtonHover;
        }

        private void RightArrowImageButton_MouseLeave(object sender, EventArgs e)
        {
            RightArrowImageButton.Image = AugmentedReadingApp.Properties.Resources.RightArrowButtonImage;
        }

        private void XRightPanelImageButton_MouseDown(object sender, MouseEventArgs e)
        {
            XRightPanelImageButton.Image = AugmentedReadingApp.Properties.Resources.XButtonImageClicked;
        }

        private void XRightPanelImageButton_MouseUp(object sender, MouseEventArgs e)
        {
            XRightPanelImageButton.Image = AugmentedReadingApp.Properties.Resources.XButtonImageHover;
        }

        private void XRightPanelImageButton_MouseEnter(object sender, EventArgs e)
        {
            XRightPanelImageButton.Image = AugmentedReadingApp.Properties.Resources.XButtonImageHover;
        }

        private void XRightPanelImageButton_MouseLeave(object sender, EventArgs e)
        {
            XRightPanelImageButton.Image = AugmentedReadingApp.Properties.Resources.XButtonImage;
        }

        private void HistoryImageButton_Click(object sender, EventArgs e)
        {
            if (historyActived == false)
            {
                HistoryImageButton.Image = AugmentedReadingApp.Properties.Resources.HistoryButtonClicked;
                historyActived = true;
                //DeFormAPanelIzquierdo();//Agregar contenido al panel izquierdo
            }
            else
            {
                HistoryImageButton.Image = AugmentedReadingApp.Properties.Resources.HistoryButtonImage;
                historyActived = false;
            }
        }
        private void HistoryImageButton_MouseEnter(object sender, EventArgs e)
        {
            if (historyActived == true)
            {

            }
            else
            {
                HistoryImageButton.Image = AugmentedReadingApp.Properties.Resources.HistoryButtonHover;
            }
            //HistoryImageButton.Image = AugmentedReadingApp.Properties.Resources.HistoryButtonHover;
        }

        private void HistoryImageButton_MouseLeave(object sender, EventArgs e)
        {
            //HistoryImageButton.Image = AugmentedReadingApp.Properties.Resources.HistoryButtonImage;
            if (historyActived == true)
            {

            }
            else
            {
                HistoryImageButton.Image = AugmentedReadingApp.Properties.Resources.HistoryButtonImage;
            }
        }

        private void TurnOffImageButton_MouseDown(object sender, MouseEventArgs e)
        {
            
            TurnOffImageButton.Image = AugmentedReadingApp.Properties.Resources.TurnOffButtonClicked;
        }

        private void TurnOffImageButton_MouseUp(object sender, MouseEventArgs e)
        {
            TurnOffImageButton.Image = AugmentedReadingApp.Properties.Resources.TurnOffButtonHover;
        }

        private void TurnOffImageButton_MouseEnter(object sender, EventArgs e)
        {
            TurnOffImageButton.Image = AugmentedReadingApp.Properties.Resources.TurnOffButtonHover;
        }

        private void TurnOffImageButton_MouseLeave(object sender, EventArgs e)
        {
            TurnOffImageButton.Image = AugmentedReadingApp.Properties.Resources.TurnOffButtonImage;
        }

        private void SynchronizerImageButton_Click(object sender, EventArgs e)
        {
            if (syncronizerButtonActived == false)
            {
                syncronizerButtonActived = true;
                SynchronizerImageButton.Image = AugmentedReadingApp.Properties.Resources.SynchronizerButtonONImage;
                BookmarkImageButton.Visible = true;
                CommentsImageButton.Visible = true;
                FiguresImageButton.Visible = true;
                ContentImageButton.Visible = true;
                if (webSearchButtonActived == true)
                {
                    webSearchButtonActived = false;
                    WebSearcherImageButton.Image = AugmentedReadingApp.Properties.Resources.WebSearcherButtonOFFImage;
                    DictionaryImageButton.Visible = false;
                    EncyclopediaImageButton.Visible = false;
                    TranslatorImageButton.Visible = false;
                    ImagesImageButton.Visible = false;
                    VideosImageButton.Visible = false;
                }
            }
            else
            {
                syncronizerButtonActived = false;
                SynchronizerImageButton.Image = AugmentedReadingApp.Properties.Resources.SynchonizerButtonOFFImage;
                BookmarkImageButton.Visible = false;
                CommentsImageButton.Visible = false;
                FiguresImageButton.Visible = false;
                ContentImageButton.Visible = false;
            }
        }

        private void SynchronizerImageButton_MouseEnter(object sender, EventArgs e)
        {
            if (syncronizerButtonActived == true)
            {
                SynchronizerImageButton.Image = AugmentedReadingApp.Properties.Resources.SynchronizerButtonONHover;
            }
            else
            {
                SynchronizerImageButton.Image = AugmentedReadingApp.Properties.Resources.SynchronizerButtonOFFHover;
            }
        }

        private void SynchronizerImageButton_MouseLeave(object sender, EventArgs e)
        {
            if (syncronizerButtonActived == true)
            {
                SynchronizerImageButton.Image = AugmentedReadingApp.Properties.Resources.SynchronizerButtonONImage;
            }
            else
            {
                SynchronizerImageButton.Image = AugmentedReadingApp.Properties.Resources.SynchonizerButtonOFFImage;
            }
        }

        private void WebSearcherImageButton_Click(object sender, EventArgs e)
        {
            if (webSearchButtonActived == false)
            {
                //Se Prenden los botonesWebSearch
                webSearchButtonActived = true;
                WebSearcherImageButton.Image = AugmentedReadingApp.Properties.Resources.WebSearcherButtonONImage;
                //WebSearcherButton.BackColor = Color.FromArgb(207, 233, 242);//Azul
                DictionaryImageButton.Visible = true;
                EncyclopediaImageButton.Visible = true;
                TranslatorImageButton.Visible = true;
                ImagesImageButton.Visible = true;
                VideosImageButton.Visible = true;
                if (syncronizerButtonActived == true)
                {
                    //Se Apagan los botonesSyncrhonizerPDF
                    syncronizerButtonActived = false;
                    SynchronizerImageButton.Image = AugmentedReadingApp.Properties.Resources.SynchonizerButtonOFFImage;
                    //SynchronizerButton.BackColor = Color.FromArgb(248, 245, 250);//Blanco
                    BookmarkImageButton.Visible = false;
                    CommentsImageButton.Visible = false;
                    FiguresImageButton.Visible = false;
                    ContentImageButton.Visible = false;
                }
            }
            else
            {
                webSearchButtonActived = false;
                WebSearcherImageButton.Image = AugmentedReadingApp.Properties.Resources.WebSearcherButtonOFFImage;
                //WebSearcherButton.BackColor = Color.FromArgb(248, 245, 250);//Blanco
                DictionaryImageButton.Visible = false;
                EncyclopediaImageButton.Visible = false;
                TranslatorImageButton.Visible = false;
                ImagesImageButton.Visible = false;
                VideosImageButton.Visible = false;
            }
        }

        private void WebSearcherImageButton_MouseEnter(object sender, EventArgs e)
        {
            if (webSearchButtonActived == true)
            {
                WebSearcherImageButton.Image = AugmentedReadingApp.Properties.Resources.WebSearcherButtonOMHover;
            }
            else
            {
                WebSearcherImageButton.Image = AugmentedReadingApp.Properties.Resources.WebSearcherButtonOFFHover;
            }
        }

        private void WebSearcherImageButton_MouseLeave(object sender, EventArgs e)
        {
            if (webSearchButtonActived == true)
            {
                WebSearcherImageButton.Image = AugmentedReadingApp.Properties.Resources.WebSearcherButtonONImage;
            }
            else
            {
                WebSearcherImageButton.Image = AugmentedReadingApp.Properties.Resources.WebSearcherButtonOFFImage;
            }
        }

        private void HighlightModeImageButton_Click(object sender, EventArgs e)
        {
            if (capturesButtonActived == true)
            {
                capturesButtonActived = false;
                HighlightModeImageButton.Image = AugmentedReadingApp.Properties.Resources.CaptureModeButtonImage;
                CapturedContentLabel.Visible = false;
                CapturedContentPanel.Visible = false;
                HighlightModeLabel.Visible = true;
                SyncHighlightImageButton.Visible = true;
            }
            else
            {
                capturesButtonActived = true;
                HighlightModeImageButton.Image = AugmentedReadingApp.Properties.Resources.HighlightModeButtonImage;
                CapturedContentLabel.Visible = true;
                CapturedContentPanel.Visible = true;
                HighlightModeLabel.Visible = false;
                SyncHighlightImageButton.Visible = false;
            }
        }

        private void HighlightModeImageButton_MouseEnter(object sender, EventArgs e)
        {
            if (capturesButtonActived == true)
            {
                HighlightModeImageButton.Image = AugmentedReadingApp.Properties.Resources.HighlightModeButtonHover;
            }
            else
            {
                HighlightModeImageButton.Image = AugmentedReadingApp.Properties.Resources.CaptureModeButtonHover;
            }
        }

        private void HighlightModeImageButton_MouseLeave(object sender, EventArgs e)
        {
            if (capturesButtonActived == true)
            {
                HighlightModeImageButton.Image = AugmentedReadingApp.Properties.Resources.HighlightModeButtonImage;
            }
            else
            {
                HighlightModeImageButton.Image = AugmentedReadingApp.Properties.Resources.CaptureModeButtonImage;
            }
        }

        private void SyncHighlightImageButton_MouseDown(object sender, MouseEventArgs e)
        {
            SyncHighlightImageButton.Image = AugmentedReadingApp.Properties.Resources.SyncHighlightsButtonClicked;
        }

        private void SyncHighlightImageButton_MouseUp(object sender, MouseEventArgs e)
        {
            SyncHighlightImageButton.Image = AugmentedReadingApp.Properties.Resources.SyncHighlightsButtonHover;
        }

        private void SyncHighlightImageButton_MouseEnter(object sender, EventArgs e)
        {
            SyncHighlightImageButton.Image = AugmentedReadingApp.Properties.Resources.SyncHighlightsButtonHover;
        }

        private void SyncHighlightImageButton_MouseLeave(object sender, EventArgs e)
        {
            SyncHighlightImageButton.Image = AugmentedReadingApp.Properties.Resources.SyncHighlightsButtonImage;
        }

        private void LeftArrowImageButton_Click(object sender, EventArgs e)
        {

        }
    }
}
