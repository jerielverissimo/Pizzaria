using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class frmPrincipal : Form
    {

        // variaveis globais
        int X = 0, Y = 0;
        bool menuExtended = true;

        public frmPrincipal()
        {
            InitializeComponent();

            setComponents();
            
        }

        void setComponents()
        {
            // mover formulário
            this.MouseDown += new MouseEventHandler(panTitleBar_MouseDown);
            this.MouseMove += new MouseEventHandler(panTitleBar_MouseMove);

            // setar cores
            panTitleBar.BackColor = ColorTranslator.FromHtml("#FBC02D");
            panPrincipal.BackColor = ColorTranslator.FromHtml("#FFF9C4");
            panActionBar.BackColor = ColorTranslator.FromHtml("#FFEE58");
            panSideBar.BackColor = ColorTranslator.FromHtml("#fff176");
            lblUser.BackColor = ColorTranslator.FromHtml("#fff176");
            lblStock.BackColor = ColorTranslator.FromHtml("#fff176");

        }

        private void panTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void panTitleBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            maximize_restore_window();
        }

        private void panTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptbMaxiRest_Click(object sender, EventArgs e)
        {
            maximize_restore_window();
        }

        void maximize_restore_window()
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                ptbMaxiRest.Image = Pizzaria.Properties.Resources.window_restore;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                ptbMaxiRest.Image = Pizzaria.Properties.Resources.window_maximize;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void lblUser_MouseEnter(object sender, EventArgs e)
        {
            lblUser.BackColor = ColorTranslator.FromHtml("#fff59d");
        }

        private void lblUser_MouseLeave(object sender, EventArgs e)
        {
            lblUser.BackColor = ColorTranslator.FromHtml("#fff176");
        }

        private void lblStock_MouseEnter(object sender, EventArgs e)
        {
            lblStock.BackColor = ColorTranslator.FromHtml("#fff59d");
        }

        private void lblStock_MouseLeave(object sender, EventArgs e)
        {
            lblStock.BackColor = ColorTranslator.FromHtml("#fff176");
        }

        private void ptbMenu_Click(object sender, EventArgs e)
        {
            //ptbMenu.Image = Pizzaria.Properties.Resources.ic_arrow_back_white_24dp;
            tmMenuSide.Enabled = true;
        }

        private void tmMenuSide_Tick(object sender, EventArgs e)
        {

            switch (menuExtended)
            {
                // diminui menu
                case true:
                    if (panSideBar.Width == 75)
                    {
                        
                        menuExtended = false;
                        tmMenuSide.Enabled = false;
                    }
                    else
                    {
                        lblUser.Text = "";
                        lblStock.Text = "";
                        panSideBar.Width -= 25;
                    }
                    break;

                // aumenta menu
                case false:
                    if (panSideBar.Width == 250)
                    {
                        lblUser.Text = "Usuário";
                        lblStock.Text = "Estoque";
                        menuExtended = true;
                        tmMenuSide.Enabled = false;
                    }
                    else
                    {
                        panSideBar.Width += 25;
                    }
                    break;
            }
            
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }

        }
    }
}
