using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AugmentedReadingApp
{
    public partial class AlertBox : Form
    {
        MenuSettings menuFunction;
        SeleccionInteraccionPorVoz2 interactionSettings;
        SeleccionApis2 seleccionApisSettings;
        TextRecognitionSettings textRecognitionSettings;
        GestureRecognitionSettings gestureRecognitionSettings;
        public String bandera;
        public AlertBox(MenuSettings incomingMenu, SeleccionInteraccionPorVoz2 incomingInteractionSettings, SeleccionApis2 incomingSeleccionApisSettings, TextRecognitionSettings incomingTextRecognitionSettings, GestureRecognitionSettings incomingGestureRecognitionSettings,String incomingBandera)
        {
            InitializeComponent();
            menuFunction = incomingMenu;
            interactionSettings = incomingInteractionSettings;
            seleccionApisSettings = incomingSeleccionApisSettings;
            textRecognitionSettings = incomingTextRecognitionSettings;
            gestureRecognitionSettings = incomingGestureRecognitionSettings;
            bandera = incomingBandera;
            
        }
        public AlertBox(String incomingBandera)
        {
            InitializeComponent();
            bandera = incomingBandera;

        }

        private void WebSearchServicesSettings_Load(object sender, EventArgs e)
        {

        }

        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if(bandera == "save"){
                menuFunction.SaveAllSettings(interactionSettings, seleccionApisSettings, textRecognitionSettings, gestureRecognitionSettings);
                this.Hide();
            }
            if (bandera == "reset")
            {
                menuFunction.ResetAllSettings(interactionSettings, seleccionApisSettings, textRecognitionSettings, gestureRecognitionSettings);
                this.Hide();
            }
            if (bandera == "exit")
            {
                Application.Exit();
            }
            
        }
    }
}
