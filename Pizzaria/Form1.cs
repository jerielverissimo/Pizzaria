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

        int X = 0, Y = 0; // variáveis para usar no arrastar form.
        
        // var do alert
        float largAlert = 0, tamAlert = 0, origemAlert = 0, locAlert = 0;
        const float porc = 0.2f;
        
        bool menuExtended = true, notify = false, search = false, ativarAlert = false; // vars de controle

        public frmPrincipal()
        {
            InitializeComponent();
            
        }
        
        
        ///     
        /// Eventos
        /// 
        
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
                        lblCaixa.Text = "";
                        lblPedido.Text = "";
                        panSideBar.Width -= 25;
                        panAlert.Left = panSideBar.Width;
                    }
                    break;

                // aumenta menu
                case false:
                    if (panSideBar.Width == 250)
                    {
                        lblUser.Text = "Usuário";
                        lblStock.Text = "Estoque";
                        lblCaixa.Text = "Caixa";
                        lblPedido.Text = "Pedido";
                        menuExtended = true;
                        tmMenuSide.Enabled = false;
                    }
                    else
                    {
                        panSideBar.Width += 25;
                        panAlert.Left = panSideBar.Width;
                    }
                    break;
            }
            
        }

        private void ptbAddPedido_MouseEnter(object sender, EventArgs e)
        {
            ptbAddPedido.Image = Pizzaria.Properties.Resources.add_circle_red_hover;
        }

        private void ptbAddPedido_MouseLeave(object sender, EventArgs e)
        {
            ptbAddPedido.Image = Pizzaria.Properties.Resources.add_circle_red;
        }

        private void lblCaixa_MouseEnter(object sender, EventArgs e)
        {
            lblCaixa.BackColor = ColorTranslator.FromHtml("#fff59d");
        }

        private void lblCaixa_MouseLeave(object sender, EventArgs e)
        {
            lblCaixa.BackColor = ColorTranslator.FromHtml("#fff176");
        }

        private void lblPedido_MouseEnter(object sender, EventArgs e)
        {
            lblPedido.BackColor = ColorTranslator.FromHtml("#fff59d");
        }

        private void lblPedido_MouseLeave(object sender, EventArgs e)
        {
            lblPedido.BackColor = ColorTranslator.FromHtml("#fff176");
        }

        private void frmPrincipal_SizeChanged(object sender, EventArgs e)
        {
            ptbAddPedido.Left = (panOrder.Size.Width - ptbAddPedido.Size.Width) / 2;

            // zera as var do alert
            largAlert = 0;
            tamAlert = 0;
            origemAlert = 0;
            locAlert = 0;

            // posiciona o alert no centro e embaixo
            panAlert.Top = this.ClientSize.Height - panAlert.Height;
            panAlert.Left = (this.ClientSize.Width - panAlert.Width) / 2;

            locAlert = ClientSize.Width / 2;
            largAlert = ClientSize.Width * porc;
        }

        private void tmSearch_Tick(object sender, EventArgs e)
        {
            switch (search)
            {
                case true:
                    if (panSearch.Height == 0)
                    {
                        search = false;
                        tmSearch.Enabled = false;
                    }
                    else
                    {
                        panSearch.Height -= 10;
                        panNotify.Location = new Point(panNotify.Location.X, panSearch.Height);
                    }
                    break;
                case false:
                    if (panSearch.Height == 75)
                    {
                        search = true;
                        tmSearch.Enabled = false;
                    }
                    else
                    {
                        panSearch.Height += 25;
                        panNotify.Location = new Point(panNotify.Location.X, panSearch.Height);
                    }
                    break;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.BackColor = ColorTranslator.FromHtml("#BCAAA4");
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.BackColor = ColorTranslator.FromHtml("#A1887F");
        }

        private void ptbSearch_Click(object sender, EventArgs e)
        {
            tmSearch.Enabled = true;
        }

        private void ptbAddPedido_Click(object sender, EventArgs e)
        {
            tmAlert.Enabled = true;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // mover formulário
            this.MouseDown += new MouseEventHandler(panTitleBar_MouseDown);
            this.MouseMove += new MouseEventHandler(panTitleBar_MouseMove);

            panAlert.Top = this.ClientSize.Height - panAlert.Height;
            panAlert.Left = (this.ClientSize.Width - panAlert.Width) / 2;
            // setar vars do alerta

            locAlert = ClientSize.Width / 2;
            largAlert = ClientSize.Width * porc;

            origemAlert = (ClientSize.Width / 2) * porc;

            // setar cores
            panTitleBar.BackColor = ColorTranslator.FromHtml("#FBC02D");
            panPrincipal.BackColor = ColorTranslator.FromHtml("#FFF9C4");
            panActionBar.BackColor = ColorTranslator.FromHtml("#FFEE58");
            panSideBar.BackColor = ColorTranslator.FromHtml("#fff176");
            lblUser.BackColor = ColorTranslator.FromHtml("#fff176");
            lblStock.BackColor = ColorTranslator.FromHtml("#fff176");
            panSearch.BackColor = ColorTranslator.FromHtml("#795548");
            txtSearch.BackColor = ColorTranslator.FromHtml("#8d6e63");
            panAlert.BackColor = ColorTranslator.FromHtml("#f44336");
            txtSearch.ForeColor = ColorTranslator.FromHtml("#795548");
            btnSearch.BackColor = ColorTranslator.FromHtml("#A1887F");

            panAlert.Left = (panOrder.Size.Width - panAlert.Size.Width) / 2;
            lblAlert.Text = panAlert.Left.ToString();

           
        }

        private void tmAlert_Tick(object sender, EventArgs e)
        {
            panAlert.Left = Convert.ToInt32(tamAlert);
            panAlert.Width = Convert.ToInt32(locAlert);

            switch (ativarAlert)
            {
                case false:

                    tamAlert += largAlert;
                    locAlert -= origemAlert;

                    if (panAlert.Width == ClientSize.Width && panAlert.Left == 0)
                    {
                        tmAlert.Enabled = false;
                        ativarAlert = true;
                    }

                    break;
                case true:

                    tamAlert -= largAlert;
                    locAlert += origemAlert;

                    if (panAlert.Width == 0 && panAlert.Left == ClientSize.Width / 2)
                    {
                        tmAlert.Enabled = false;
                        ativarAlert = false;
                    }
                    break;
            }
        }

        private void ptbNotify_Click(object sender, EventArgs e)
        {
            tmNotify.Enabled = true;
        }

        private void tmNotify_Tick(object sender, EventArgs e)
        {

            switch (notify)
            {
                case true:
                    if (panNotify.Height == 0)
                    {
                        notify = false;
                        tmNotify.Enabled = false;
                    }
                    else
                    {
                        panNotify.Height -= 25;
                    }
                    break;
                case false:
                    if (panNotify.Height == 225)
                    {
                        notify = true;
                        tmNotify.Enabled = false;
                    }
                    else
                    {
                        panNotify.Height += 25;
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
