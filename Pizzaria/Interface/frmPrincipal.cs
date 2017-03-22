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
        float largura = 0, locLargura = 0, origem = 0, tamanho = 0;
        const float porc = 0.2f;
        
        bool menuExtended = false, notify = false, search = false, ativarAlert = false; // vars de controle
    
        // var para slide do estoque
        int pos = 0;
        bool flag = false, prim = false;

        

        // Construtor do form
        public frmPrincipal()
        {
            InitializeComponent();
            
        }

        // load do form 
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

           

            
            // mover formulário
            this.MouseDown += new MouseEventHandler(panTitleBar_MouseDown);
            this.MouseMove += new MouseEventHandler(panTitleBar_MouseMove);



            // setar vars do  efeito do alerta

            panAlert.Top =  panPedido.ClientSize.Height - panAlert.Height;
            panAlert.Left = (panPedido.ClientSize.Width - panAlert.Width) / 2;


            origem = panPedido.ClientSize.Width / 2;
            largura = panPedido.ClientSize.Width * porc;
            locLargura = (panPedido.ClientSize.Width / 2) * porc;

            // set efeito estoque
            panEstoque.Location = new Point(this.ClientSize.Width, 0);



            // setar cores
            panTitleBar.BackColor = ColorTranslator.FromHtml("#FBC02D");
            panPrincipal.BackColor = ColorTranslator.FromHtml("#FFF9C4");
            panActionBar.BackColor = ColorTranslator.FromHtml("#FFEE58");
            panSideBar.BackColor = ColorTranslator.FromHtml("#fff176");
            lblStock.BackColor = ColorTranslator.FromHtml("#fff176");
            panSearch.BackColor = ColorTranslator.FromHtml("#795548");
            txtSearch.BackColor = ColorTranslator.FromHtml("#8d6e63");
            //panel1.BackColor = ColorTranslator.FromHtml("#f44336");
            txtSearch.ForeColor = ColorTranslator.FromHtml("#795548");
            btnSearch.BackColor = ColorTranslator.FromHtml("#A1887F");
           
        }

       

        // quando o tamanho do form muda,
        // ex quando maximiza ou minimiza a tela atualiza os componentes da tela
        
        private void frmPrincipal_SizeChanged(object sender, EventArgs e)
        {
            ptbAddPedido.Left = (panPedido.Size.Width - ptbAddPedido.Size.Width) / 2;

            // seta as var do alert

            largura = 0;
            locLargura = 0;
            origem = 0;
            tamanho = 0;
            panAlert.Top = panPedido.ClientSize.Height - panAlert.Height;
            panAlert.Left = (panPedido.ClientSize.Width - panAlert.Width) / 2;
            origem = panPedido.ClientSize.Width / 2;
            largura = panPedido.ClientSize.Width * porc;
            locLargura = (panPedido.ClientSize.Width / 2) * porc;
            if (ativarAlert == true)
            {
                panAlert.Left = 0;
                panAlert.Width = panPedido.ClientSize.Width;
            }

            // slide estoque

            
            if (flag == true) panEstoque.Location = new Point(this.ClientSize.Width, 0);
            if (prim == false) panEstoque.Location = new Point(this.ClientSize.Width, 0);
            panEstoque.Size = new Size(this.Size.Width, this.Size.Height);


        }

        // métodos

        // Maximizar e minimizar formulario
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

        // efeitos

        // efeito da barra de pesquisa
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
                        txtSearch.Visible = false;
                        btnSearch.Visible = false;
                        panNotify.Location = new Point(panNotify.Location.X, panSearch.Height);
                        //panPedido.Top = panSearch.Height;
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
                        txtSearch.Visible = true;
                        btnSearch.Visible = true;
                        panNotify.Location = new Point(panNotify.Location.X, panSearch.Height);
                        //panPedido.Top = panSearch.Height;
                    }
                    break;
            }
        }

        // efeito do menu lateral
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

                        lblStock.Text = "";
                        lblPedido.Text = "";
                        lblData.Visible = false;
                        lblHora.Visible = false;
                        lblLogo.Visible = false;

                        panSideBar.Width -= 25;
                        
                    }
                    break;

                // aumenta menu
                case false:
                    if (panSideBar.Width == 250)
                    {

                        lblStock.Text = "Estoque";
                        lblPedido.Text = "Pedido";
                        lblData.Visible = true;
                        lblHora.Visible = true;
                        lblLogo.Visible = true;

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

        // efeito do alerta
        private void tmAlert_Tick(object sender, EventArgs e)
        {
            panAlert.Width = Convert.ToInt32(tamanho);

            panAlert.Left = Convert.ToInt32(origem);

            switch (ativarAlert)
            {
                case false:
                    tamanho += largura;
                    origem -= locLargura;
   
                    if (panAlert.Width == panPedido.ClientSize.Width && panAlert.Left == 0)
                    {
                        tmAlert.Enabled = false;
                        ativarAlert = true;
                        ptbAlert.Visible = true;
                        ptbFechar.Visible = true;
                        lblAlert.Visible = true;

                    }
                    break;
                case true:
                    tamanho -= largura;
                    origem += locLargura;
                    ptbAlert.Visible = false;
                    ptbFechar.Visible = false;
                    lblAlert.Visible = false;

                    if (panAlert.Width == 0 && panAlert.Left == panPedido.ClientSize.Width / 2)
                    {
                        tmAlert.Enabled = false;
                        ativarAlert = false;
                    }
                    break;
            }


        }

        // efeito da notificação
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


        ///     
        /// Eventos de mouse
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

        private void ptbAddPedido_MouseEnter(object sender, EventArgs e)
        {
            ptbAddPedido.Image = Pizzaria.Properties.Resources.add_circle_red_hover;
        }

        private void ptbAddPedido_MouseLeave(object sender, EventArgs e)
        {
            ptbAddPedido.Image = Pizzaria.Properties.Resources.add_circle_red;
        }

        private void lblPedido_MouseEnter(object sender, EventArgs e)
        {
            lblPedido.BackColor = ColorTranslator.FromHtml("#fff59d");
        }

        private void lblPedido_MouseLeave(object sender, EventArgs e)
        {
            lblPedido.BackColor = ColorTranslator.FromHtml("#fff176");
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.BackColor = ColorTranslator.FromHtml("#BCAAA4");
        }

        private void tmEstoque_Tick(object sender, EventArgs e)
        {
            switch (flag)
            {
                case false:
                    if (panEstoque.Location.X <= 0)
                    {
                        tmEstoque.Enabled = false;
                    }
                    else
                    {
                        pos -= 100;
                        panEstoque.Location = new Point(pos, 0);
                    }
                    break;
                case true:
                    if (panEstoque.Location.X >= this.ClientSize.Width)
                    {
                        tmEstoque.Enabled = false;
                    }
                    else
                    {
                        pos += 100;
                        panEstoque.Location = new Point(pos, 0);
                    }
                    break;
            }
        }

        private void atualizaHora_Tick(object sender, EventArgs e)
        {
            // Pegar hora e data
            string hora = DateTime.Now.ToShortTimeString();
            string data = DateTime.Now.ToShortDateString();
            lblHora.Text = hora;
            lblData.Text = data;
        }

        private void ptbFechar_Click(object sender, EventArgs e)
        {
            tmAlert.Enabled = true;
        }

     

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.BackColor = ColorTranslator.FromHtml("#A1887F");
        }

        private void button1_Click(object sender, EventArgs e)
        {

          
        }

        private void lblPedido_Click(object sender, EventArgs e)
        {
            ptbSearch.Enabled = false;
            ptbSearch.Visible = false;
            tmEstoque.Enabled = true;
            flag = true;
            prim = false;
        }

        private void lblStock_Click(object sender, EventArgs e)
        {
            ptbSearch.Enabled = true;
            ptbSearch.Visible = true;
            pos = panEstoque.Width;
            tmEstoque.Enabled = true;
            flag = false;
            prim = true;
        }

        private void ptbSearch_Click(object sender, EventArgs e)
        {
            tmSearch.Enabled = true;
        }

        private void ptbAddPedido_Click(object sender, EventArgs e)
        {
            tmAlert.Enabled = true;
           
        }


        private void ptbNotify_Click(object sender, EventArgs e)
        {
            tmNotify.Enabled = true;
        }


        // efeito de sombra na borda externa do formulario
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
