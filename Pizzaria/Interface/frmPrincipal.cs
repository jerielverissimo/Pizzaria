using Pizzaria.Controle;
using Pizzaria.Model;
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

        bool menuExtended = false, notify = false, pedidos = false, search = false, ativarAlert = false; // vars de controle

        // var para slide do estoque
        int posEstoque = 0;
        bool flagEstoque = false;

        // objs
        Interface.Notificacao aviso = new Interface.Notificacao();


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

            panAlert.Top = panPedido.ClientSize.Height - panAlert.Height;
            panAlert.Left = (panPedido.ClientSize.Width - panAlert.Width) / 2;


            origem = panPedido.ClientSize.Width / 2;
            largura = panPedido.ClientSize.Width * porc;
            locLargura = (panPedido.ClientSize.Width / 2) * porc;

            // set slide pan estoque
            panEstoque.Location = new Point(this.ClientSize.Width, 0);
            panEstoque.Size = new Size(this.Size.Width, this.Size.Height);




            // setar cores
            panTitleBar.BackColor = ColorTranslator.FromHtml("#FBC02D");
            panPrincipal.BackColor = ColorTranslator.FromHtml("#FFF9C4");
            panActionBar.BackColor = ColorTranslator.FromHtml("#FFEE58");
            panSideBar.BackColor = ColorTranslator.FromHtml("#fff176");
            lblStock.BackColor = ColorTranslator.FromHtml("#fff176");
            panSearch.BackColor = ColorTranslator.FromHtml("#795548");
            txtSearch.BackColor = ColorTranslator.FromHtml("#8d6e63");
            txtSearch.ForeColor = ColorTranslator.FromHtml("#795548");
            btnSearch.BackColor = ColorTranslator.FromHtml("#A1887F");
            lblNumPedido.ForeColor = ColorTranslator.FromHtml("#212121");
            panPedido.BackColor = ColorTranslator.FromHtml("#F5F5F5");
            panNotify.BackColor = ColorTranslator.FromHtml("#FF7043");
            lstNotify.BackColor = ColorTranslator.FromHtml("#FF7043");
            lblAddPizza.BackColor = ColorTranslator.FromHtml("#ffff8d");
            lblLimparDados.BackColor = ColorTranslator.FromHtml("#b2ff59");
            lblExcluirPedido.BackColor = ColorTranslator.FromHtml("#ff5252");


            cmbPizza.DataSource = PizzaBLL.PizzaDB;
            cmbPizza.DisplayMember = "Nome";
            cmbPizza.ValueMember = "IdPizza";

            cmbPedidos.DataSource = PedidoBLL.PedidoDB;
            cmbPedidos.DisplayMember = "NumeroPedido";
            cmbPedidos.ValueMember = "IdPedido";

            dgvEstoque.DataSource = EstoqueBLL.EstoqueDB;

        }



        // quando o tamanho do form muda,
        // ex quando maximiza ou minimiza a tela atualiza os componentes da tela

        private void frmPrincipal_SizeChanged(object sender, EventArgs e)
        {


            // seta as var do alert

            largura = 0;
            locLargura = 0;
            origem = 0;
            tamanho = 0;

            //panAlert.Top = panPedido.ClientSize.Height - panAlert.Height;
            panAlert.Left = (panPedido.ClientSize.Width - panAlert.Width) / 2;
            origem = panPedido.ClientSize.Width / 2;
            largura = panPedido.ClientSize.Width * porc;
            locLargura = (panPedido.ClientSize.Width / 2) * porc;
            if (ativarAlert == true)
            {
                panAlert.Left = 0;
                panAlert.Width = panPedido.ClientSize.Width;
            }

            // joga o estoque para fora da tela

            panEstoque.Left = this.Width;





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
                        panPedidos.Location = new Point(panPedidos.Location.X, panSearch.Height);
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
                        panSearch.Height += 5;
                        txtSearch.Visible = true;
                        btnSearch.Visible = true;
                        panNotify.Location = new Point(panNotify.Location.X, panSearch.Height);
                        panPedidos.Location = new Point(panPedidos.Location.X, panSearch.Height);
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
                        panAlert.Dock = DockStyle.Bottom;
                        tmAlert.Enabled = false;
                        ativarAlert = true;
                        ptbAlert.Visible = true;
                        ptbFechar.Visible = true;
                        lblAlert.Visible = true;
                        
                    }
                    break;
                case true:
                    panAlert.Dock = DockStyle.None;
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

                    if (pedidos) tmPedidos.Enabled = true;

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

        // efeito do estoque

        private void tmEstoque_Tick(object sender, EventArgs e)
        {
            switch (flagEstoque)
            {
                case false:
                    if (panEstoque.Location.X <= 0)
                    {
                        panEstoque.Dock = DockStyle.Fill;
                        tmEstoque.Enabled = false;
                    }
                    else
                    {
                        posEstoque -= 100;
                        panEstoque.Location = new Point(posEstoque, 0);
                    }
                    break;
                case true:
                    panEstoque.Dock = DockStyle.None;
                    if (panEstoque.Location.X >= this.ClientSize.Width)
                    {
                        tmEstoque.Enabled = false;


                    }
                    else
                    {
                        posEstoque += 100;
                        panEstoque.Location = new Point(posEstoque, 0);
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



        private void atualizaHora_Tick(object sender, EventArgs e)
        {
            // Pegar hora e data
            string hora = DateTime.Now.ToShortTimeString();
            string data = DateTime.Now.ToShortDateString();
            lblHora.Text = hora;
            lblData.Text = data;
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            lstNotify.Items.Clear();
        }

        private void ptbFechar_Click(object sender, EventArgs e)
        {
            tmAlert.Enabled = true;
        }

        private void lstPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblExcluirPedido.Enabled = true;
            lblExcluirPedido.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblExcluirPedido.Enabled = false;
            lblExcluirPedido.Visible = false;
        }

        private void ptbCarrinho_Click(object sender, EventArgs e)
        {
            tmPedidos.Enabled = true;
        }

        private void lblLimparDados_Click(object sender, EventArgs e)
        {
            txtPedido.Text = "";
        }

        private void lstEstoque_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblAddPizza_Click(object sender, EventArgs e)
        {
            PedidoModel pedido;
            if (string.IsNullOrEmpty(txtPedido.Text))
            {
                //Faz novo pedido
                pedido = new PedidoModel();
                pedido.NumeroPedido = PedidoBLL.GetUltimoNumero();
                pedido.IdPedido = PedidoBLL.PedidoDB.Count + 1;
                //Adicionar campo de observação
            }
            else
            {
                //Obtem Pedido
                pedido = PedidoBLL.GetPedidoPorNumero(txtPedido.Text);

                if (pedido == null)
                {
                    MessageBox.Show("Pedido Inválido!");
                    return;
                }
                PedidoBLL.PedidoDB.RemoveAt(PedidoBLL.PedidoDB.FindIndex(x => x.NumeroPedido == txtPedido.Text));
            }

            if (pedido.Pizzas == null)
                pedido.Pizzas = new List<PedidoPizzaModel>();

            pedido.Pizzas.Add(new PedidoPizzaModel() { IdPedido = PedidoBLL.PedidoDB.Count + 1, ComBorda = ckbBorda.Checked, IdPizza = (int)cmbPizza.SelectedValue, Pizza = PizzaBLL.GetPizzaById((int)cmbPizza.SelectedValue), Pedido = pedido, Quantidade = (int)numQtd.Value });
            PedidoBLL.PedidoDB.Add(pedido);
            txtPedido.Text = pedido.NumeroPedido;
            cmbPedidos.Refresh();
        }

        private void lstNotify_DoubleClick(object sender, EventArgs e)
        {
            aviso.pushMessage("teste asdfasdfasdf", lblAlert);
            tmAlert.Enabled = true;
            
        }

        private void lblAddPizza_MouseEnter(object sender, EventArgs e)
        {
            lblAddPizza.BackColor = ColorTranslator.FromHtml("#fff9c4");
        }

        private void lblAddPizza_MouseLeave(object sender, EventArgs e)
        {
            lblAddPizza.BackColor = ColorTranslator.FromHtml("#ffff8d");
        }

        private void lblLimparDados_MouseEnter(object sender, EventArgs e)
        {
            lblLimparDados.BackColor = ColorTranslator.FromHtml("#ccff90");
        }

        private void lblLimparDados_MouseLeave(object sender, EventArgs e)
        {
              lblLimparDados.BackColor = ColorTranslator.FromHtml("#b2ff59");
        }

        private void lblExcluirPedido_MouseEnter(object sender, EventArgs e)
        {
            lblExcluirPedido.BackColor = ColorTranslator.FromHtml("#ff8a80");
        }

        private void lblExcluirPedido_MouseLeave(object sender, EventArgs e)
        {
            lblExcluirPedido.BackColor = ColorTranslator.FromHtml("#ff5252");
        }

        private void tmPedidos_Tick(object sender, EventArgs e)
        {
            switch (pedidos)
            {
                case true:
                    if (panPedidos.Height == 0)
                    {
                        pedidos = false;
                        tmPedidos.Enabled = false;
                    }
                    else
                    {
                        panPedidos.Height -= 25;
                    }
                    break;
                case false:

                    if (notify) tmNotify.Enabled = true;

                    if (panPedidos.Height == 275)
                    {
                        pedidos = true;
                        tmPedidos.Enabled = false;
                    }
                    else
                    {
                        panPedidos.Height += 25;
                    }
                    break;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.BackColor = ColorTranslator.FromHtml("#A1887F");
        }



        private void lblPedido_Click(object sender, EventArgs e)
        {
            if (search) tmSearch.Enabled = true;
            ptbSearch.Enabled = false;
            ptbSearch.Visible = false;
            tmEstoque.Enabled = true;
            ptbCarrinho.Enabled = true;
            ptbCarrinho.Visible = true;
            flagEstoque = true;
            lblTitulo.Text = "Pedido";
        }

        private void lblStock_Click(object sender, EventArgs e)
        {
            ptbSearch.Enabled = true;
            ptbSearch.Visible = true;
            ptbCarrinho.Enabled = false;
            ptbCarrinho.Visible = false;
            posEstoque = panEstoque.Width;
            tmEstoque.Enabled = true;
            flagEstoque = false;
            lblTitulo.Text = "Estoque";
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
