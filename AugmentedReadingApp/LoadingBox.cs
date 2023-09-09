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
    public partial class LoadingBox : Form
    {
        public LoadingBox()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            
        }

        public LoadingBox(Form parent)
        {
            InitializeComponent();
            if (parent != null && parent.Name == "ProjectionScreenActivity2")
            {
                ProjectionScreenActivity2 parentProjected = parent as ProjectionScreenActivity2;
                this.BackColor = SystemColors.Window;
                this.StartPosition = FormStartPosition.Manual;
                if (parentProjected.ladoBusqueda == "izquierda")
                {
                    this.Location = new Point(parentProjected.Location.X + 30, parentProjected.Location.Y + 122);
                }
                else if (parentProjected.ladoBusqueda == "derecha")
                {
                    this.Location = new Point(parentProjected.Location.X + 980, parentProjected.Location.Y + 134);
                }
            }
            else if (parent != null && parent.Name == "MenuSettings")
            {
                this.BackColor = Color.FromArgb(248, 245, 250);
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(parent.Location.X + 17, parent.Location.Y + 420);
            }
            else
                this.StartPosition = FormStartPosition.CenterScreen;
        }

        public LoadingBox(Form parent, String tipoBusqueda)
        {
            InitializeComponent();
            if (parent != null)
            {
                this.StartPosition = FormStartPosition.Manual;
                if (parent.Name == "ProjectionScreenActivity2" && tipoBusqueda == "izquierda")
                {
                    
                    this.Location = new Point(parent.Location.X + 12, parent.Location.Y + 67);
                }
                if (parent.Name == "ProjectionScreenActivity2" && tipoBusqueda == "derecha")
                {
                    this.Location = new Point(parent.Location.X + 880, parent.Location.Y + 67);
                }
            }
            else
                this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void CloseLoadingBox()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            if (label1.Image != null)
            {
                label1.Image.Dispose();
            }

        }
    }
}
