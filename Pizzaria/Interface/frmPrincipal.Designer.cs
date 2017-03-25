namespace Pizzaria
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panTitleBar = new System.Windows.Forms.Panel();
            this.ptbMini = new System.Windows.Forms.PictureBox();
            this.ptbMaxiRest = new System.Windows.Forms.PictureBox();
            this.ptbExit = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panPrincipal = new System.Windows.Forms.Panel();
            this.panPedido = new System.Windows.Forms.Panel();
            this.panNotify = new System.Windows.Forms.Panel();
            this.lstNotify = new System.Windows.Forms.ListBox();
            this.lblNotify = new System.Windows.Forms.Label();
            this.lblClear = new System.Windows.Forms.Label();
            this.panEstoque = new System.Windows.Forms.Panel();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.ckbAcabando = new System.Windows.Forms.CheckBox();
            this.panPedidos = new System.Windows.Forms.Panel();
            this.lblFinalizarPedido = new System.Windows.Forms.Label();
            this.cmbPedidos = new System.Windows.Forms.ComboBox();
            this.lblExcluirPedido = new System.Windows.Forms.Label();
            this.lstPedidos = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblConcluirPedido = new System.Windows.Forms.Label();
            this.lblLimparDados = new System.Windows.Forms.Label();
            this.numQtd = new System.Windows.Forms.NumericUpDown();
            this.lblQtd = new System.Windows.Forms.Label();
            this.ckbBorda = new System.Windows.Forms.CheckBox();
            this.cmbPizza = new System.Windows.Forms.ComboBox();
            this.lblSabor = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.lblNumPedido = new System.Windows.Forms.Label();
            this.lblAddPizza = new System.Windows.Forms.Label();
            this.panAlert = new System.Windows.Forms.Panel();
            this.lblAlert = new System.Windows.Forms.Label();
            this.ptbFechar = new System.Windows.Forms.PictureBox();
            this.ptbAlert = new System.Windows.Forms.PictureBox();
            this.panSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panSideBar = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.panActionBar = new System.Windows.Forms.Panel();
            this.ptbCarrinho = new System.Windows.Forms.PictureBox();
            this.ptbNotify = new System.Windows.Forms.PictureBox();
            this.ptbSearch = new System.Windows.Forms.PictureBox();
            this.ptbMenu = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tmMenuSide = new System.Windows.Forms.Timer(this.components);
            this.tmNotify = new System.Windows.Forms.Timer(this.components);
            this.tmSearch = new System.Windows.Forms.Timer(this.components);
            this.tmAlert = new System.Windows.Forms.Timer(this.components);
            this.tmEstoque = new System.Windows.Forms.Timer(this.components);
            this.atualizaHora = new System.Windows.Forms.Timer(this.components);
            this.tmPedidos = new System.Windows.Forms.Timer(this.components);
            this.idEstoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idIngredienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaxiRest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            this.panPrincipal.SuspendLayout();
            this.panPedido.SuspendLayout();
            this.panNotify.SuspendLayout();
            this.panEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.panPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtd)).BeginInit();
            this.panAlert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAlert)).BeginInit();
            this.panSearch.SuspendLayout();
            this.panSideBar.SuspendLayout();
            this.panActionBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCarrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panTitleBar
            // 
            this.panTitleBar.BackColor = System.Drawing.Color.SandyBrown;
            this.panTitleBar.Controls.Add(this.ptbMini);
            this.panTitleBar.Controls.Add(this.ptbMaxiRest);
            this.panTitleBar.Controls.Add(this.ptbExit);
            this.panTitleBar.Controls.Add(this.lblTitle);
            this.panTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.panTitleBar.Name = "panTitleBar";
            this.panTitleBar.Size = new System.Drawing.Size(1000, 25);
            this.panTitleBar.TabIndex = 0;
            this.panTitleBar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseDoubleClick);
            this.panTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseDown);
            this.panTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseMove);
            // 
            // ptbMini
            // 
            this.ptbMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMini.Image = global::Pizzaria.Properties.Resources.window_minimize;
            this.ptbMini.Location = new System.Drawing.Point(906, 1);
            this.ptbMini.Name = "ptbMini";
            this.ptbMini.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.ptbMini.Size = new System.Drawing.Size(24, 24);
            this.ptbMini.TabIndex = 3;
            this.ptbMini.TabStop = false;
            // 
            // ptbMaxiRest
            // 
            this.ptbMaxiRest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMaxiRest.Image = global::Pizzaria.Properties.Resources.window_maximize;
            this.ptbMaxiRest.Location = new System.Drawing.Point(936, 0);
            this.ptbMaxiRest.Name = "ptbMaxiRest";
            this.ptbMaxiRest.Size = new System.Drawing.Size(24, 24);
            this.ptbMaxiRest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbMaxiRest.TabIndex = 2;
            this.ptbMaxiRest.TabStop = false;
            this.ptbMaxiRest.Click += new System.EventHandler(this.ptbMaxiRest_Click);
            // 
            // ptbExit
            // 
            this.ptbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbExit.Image = global::Pizzaria.Properties.Resources.window_close;
            this.ptbExit.Location = new System.Drawing.Point(966, 0);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(24, 24);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbExit.TabIndex = 1;
            this.ptbExit.TabStop = false;
            this.ptbExit.Click += new System.EventHandler(this.ptbExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(455, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(91, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pizzaria C#";
            this.lblTitle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseDoubleClick);
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseMove);
            // 
            // panPrincipal
            // 
            this.panPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panPrincipal.Controls.Add(this.panPedido);
            this.panPrincipal.Controls.Add(this.panSideBar);
            this.panPrincipal.Controls.Add(this.panActionBar);
            this.panPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPrincipal.Location = new System.Drawing.Point(0, 25);
            this.panPrincipal.Name = "panPrincipal";
            this.panPrincipal.Size = new System.Drawing.Size(1000, 658);
            this.panPrincipal.TabIndex = 1;
            // 
            // panPedido
            // 
            this.panPedido.BackColor = System.Drawing.Color.White;
            this.panPedido.Controls.Add(this.panNotify);
            this.panPedido.Controls.Add(this.panEstoque);
            this.panPedido.Controls.Add(this.panPedidos);
            this.panPedido.Controls.Add(this.lblConcluirPedido);
            this.panPedido.Controls.Add(this.lblLimparDados);
            this.panPedido.Controls.Add(this.numQtd);
            this.panPedido.Controls.Add(this.lblQtd);
            this.panPedido.Controls.Add(this.ckbBorda);
            this.panPedido.Controls.Add(this.cmbPizza);
            this.panPedido.Controls.Add(this.lblSabor);
            this.panPedido.Controls.Add(this.txtPedido);
            this.panPedido.Controls.Add(this.lblNumPedido);
            this.panPedido.Controls.Add(this.lblAddPizza);
            this.panPedido.Controls.Add(this.panAlert);
            this.panPedido.Controls.Add(this.panSearch);
            this.panPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPedido.Location = new System.Drawing.Point(75, 75);
            this.panPedido.Margin = new System.Windows.Forms.Padding(0);
            this.panPedido.Name = "panPedido";
            this.panPedido.Size = new System.Drawing.Size(925, 583);
            this.panPedido.TabIndex = 2;
            // 
            // panNotify
            // 
            this.panNotify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panNotify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panNotify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panNotify.Controls.Add(this.lstNotify);
            this.panNotify.Controls.Add(this.lblNotify);
            this.panNotify.Controls.Add(this.lblClear);
            this.panNotify.Location = new System.Drawing.Point(700, 0);
            this.panNotify.Margin = new System.Windows.Forms.Padding(0);
            this.panNotify.Name = "panNotify";
            this.panNotify.Size = new System.Drawing.Size(225, 0);
            this.panNotify.TabIndex = 1;
            // 
            // lstNotify
            // 
            this.lstNotify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lstNotify.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstNotify.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNotify.ForeColor = System.Drawing.Color.White;
            this.lstNotify.FormattingEnabled = true;
            this.lstNotify.HorizontalExtent = 10;
            this.lstNotify.ItemHeight = 19;
            this.lstNotify.Items.AddRange(new object[] {
            "Mussarela",
            "Calabresa",
            "Cebola",
            "Tomate"});
            this.lstNotify.Location = new System.Drawing.Point(10, 75);
            this.lstNotify.Margin = new System.Windows.Forms.Padding(10);
            this.lstNotify.Name = "lstNotify";
            this.lstNotify.Size = new System.Drawing.Size(205, 114);
            this.lstNotify.TabIndex = 10;
            this.lstNotify.DoubleClick += new System.EventHandler(this.lstNotify_DoubleClick);
            // 
            // lblNotify
            // 
            this.lblNotify.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNotify.AutoSize = true;
            this.lblNotify.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotify.ForeColor = System.Drawing.Color.White;
            this.lblNotify.Location = new System.Drawing.Point(43, 29);
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Size = new System.Drawing.Size(131, 25);
            this.lblNotify.TabIndex = 0;
            this.lblNotify.Text = "Notificações";
            // 
            // lblClear
            // 
            this.lblClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblClear.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.ForeColor = System.Drawing.Color.DimGray;
            this.lblClear.Image = global::Pizzaria.Properties.Resources.ic_clear_all_black_24dp;
            this.lblClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClear.Location = new System.Drawing.Point(100, -36);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(24, 24);
            this.lblClear.TabIndex = 1;
            this.lblClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // panEstoque
            // 
            this.panEstoque.BackColor = System.Drawing.Color.White;
            this.panEstoque.Controls.Add(this.dgvEstoque);
            this.panEstoque.Controls.Add(this.ckbAcabando);
            this.panEstoque.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panEstoque.ForeColor = System.Drawing.Color.DimGray;
            this.panEstoque.Location = new System.Drawing.Point(132, 248);
            this.panEstoque.Margin = new System.Windows.Forms.Padding(0);
            this.panEstoque.Name = "panEstoque";
            this.panEstoque.Size = new System.Drawing.Size(922, 583);
            this.panEstoque.TabIndex = 8;
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToOrderColumns = true;
            this.dgvEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstoque.AutoGenerateColumns = false;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEstoqueDataGridViewTextBoxColumn,
            this.idIngredienteDataGridViewTextBoxColumn,
            this.ingredienteDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn});
            this.dgvEstoque.DataSource = this.estoqueModelBindingSource;
            this.dgvEstoque.Location = new System.Drawing.Point(88, 56);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.Size = new System.Drawing.Size(594, 410);
            this.dgvEstoque.TabIndex = 2;
            // 
            // ckbAcabando
            // 
            this.ckbAcabando.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ckbAcabando.AutoSize = true;
            this.ckbAcabando.Location = new System.Drawing.Point(731, 121);
            this.ckbAcabando.Name = "ckbAcabando";
            this.ckbAcabando.Size = new System.Drawing.Size(179, 29);
            this.ckbAcabando.TabIndex = 1;
            this.ckbAcabando.Text = "Itens Acabando";
            this.ckbAcabando.UseVisualStyleBackColor = true;
            // 
            // panPedidos
            // 
            this.panPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panPedidos.Controls.Add(this.lblFinalizarPedido);
            this.panPedidos.Controls.Add(this.cmbPedidos);
            this.panPedidos.Controls.Add(this.lblExcluirPedido);
            this.panPedidos.Controls.Add(this.lstPedidos);
            this.panPedidos.Controls.Add(this.label5);
            this.panPedidos.Controls.Add(this.label4);
            this.panPedidos.Location = new System.Drawing.Point(625, 0);
            this.panPedidos.Margin = new System.Windows.Forms.Padding(0);
            this.panPedidos.Name = "panPedidos";
            this.panPedidos.Size = new System.Drawing.Size(300, 0);
            this.panPedidos.TabIndex = 17;
            this.panPedidos.Leave += new System.EventHandler(this.panPedidos_Leave);
            // 
            // lblFinalizarPedido
            // 
            this.lblFinalizarPedido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFinalizarPedido.AutoSize = true;
            this.lblFinalizarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblFinalizarPedido.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalizarPedido.ForeColor = System.Drawing.Color.DimGray;
            this.lblFinalizarPedido.Location = new System.Drawing.Point(144, 297);
            this.lblFinalizarPedido.Name = "lblFinalizarPedido";
            this.lblFinalizarPedido.Padding = new System.Windows.Forms.Padding(10);
            this.lblFinalizarPedido.Size = new System.Drawing.Size(144, 39);
            this.lblFinalizarPedido.TabIndex = 24;
            this.lblFinalizarPedido.Text = "Finalizar Pedido";
            this.lblFinalizarPedido.Click += new System.EventHandler(this.lblFinalizarPedido_Click);
            this.lblFinalizarPedido.MouseEnter += new System.EventHandler(this.lblFinalizarPedido_MouseEnter);
            this.lblFinalizarPedido.MouseLeave += new System.EventHandler(this.lblFinalizarPedido_MouseLeave);
            // 
            // cmbPedidos
            // 
            this.cmbPedidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbPedidos.AutoCompleteCustomSource.AddRange(new string[] {
            "Mussarela",
            "Calabresa",
            "Escarola",
            "Portuguesa"});
            this.cmbPedidos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPedidos.BackColor = System.Drawing.Color.White;
            this.cmbPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPedidos.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPedidos.ForeColor = System.Drawing.Color.DimGray;
            this.cmbPedidos.FormattingEnabled = true;
            this.cmbPedidos.Items.AddRange(new object[] {
            "Mussarela",
            "Calabresa",
            "Escarola",
            "Portuguesa"});
            this.cmbPedidos.Location = new System.Drawing.Point(123, 20);
            this.cmbPedidos.Name = "cmbPedidos";
            this.cmbPedidos.Size = new System.Drawing.Size(161, 33);
            this.cmbPedidos.TabIndex = 23;
            this.cmbPedidos.SelectedIndexChanged += new System.EventHandler(this.cmbPedidos_SelectedIndexChanged);
            // 
            // lblExcluirPedido
            // 
            this.lblExcluirPedido.AutoSize = true;
            this.lblExcluirPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblExcluirPedido.Enabled = false;
            this.lblExcluirPedido.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcluirPedido.ForeColor = System.Drawing.Color.White;
            this.lblExcluirPedido.Location = new System.Drawing.Point(15, 302);
            this.lblExcluirPedido.Name = "lblExcluirPedido";
            this.lblExcluirPedido.Padding = new System.Windows.Forms.Padding(5);
            this.lblExcluirPedido.Size = new System.Drawing.Size(110, 29);
            this.lblExcluirPedido.TabIndex = 22;
            this.lblExcluirPedido.Text = "Excluir Pizza";
            this.lblExcluirPedido.Visible = false;
            this.lblExcluirPedido.Click += new System.EventHandler(this.lblExcluirPedido_Click);
            this.lblExcluirPedido.MouseEnter += new System.EventHandler(this.lblExcluirPedido_MouseEnter);
            this.lblExcluirPedido.MouseLeave += new System.EventHandler(this.lblExcluirPedido_MouseLeave);
            // 
            // lstPedidos
            // 
            this.lstPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lstPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPedidos.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPedidos.ForeColor = System.Drawing.Color.DimGray;
            this.lstPedidos.FormattingEnabled = true;
            this.lstPedidos.ItemHeight = 19;
            this.lstPedidos.Location = new System.Drawing.Point(10, 114);
            this.lstPedidos.Name = "lstPedidos";
            this.lstPedidos.Size = new System.Drawing.Size(280, 114);
            this.lstPedidos.TabIndex = 21;
            this.lstPedidos.SelectedIndexChanged += new System.EventHandler(this.lstPedidos_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(117, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Pizzas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(32, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nº Pedido";
            // 
            // lblConcluirPedido
            // 
            this.lblConcluirPedido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConcluirPedido.AutoSize = true;
            this.lblConcluirPedido.BackColor = System.Drawing.Color.SteelBlue;
            this.lblConcluirPedido.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcluirPedido.ForeColor = System.Drawing.Color.White;
            this.lblConcluirPedido.Location = new System.Drawing.Point(501, 336);
            this.lblConcluirPedido.Name = "lblConcluirPedido";
            this.lblConcluirPedido.Padding = new System.Windows.Forms.Padding(10);
            this.lblConcluirPedido.Size = new System.Drawing.Size(141, 39);
            this.lblConcluirPedido.TabIndex = 19;
            this.lblConcluirPedido.Text = "Concluir Pedido";
            this.lblConcluirPedido.Click += new System.EventHandler(this.lblConcluirPedido_Click);
            this.lblConcluirPedido.MouseEnter += new System.EventHandler(this.lblConcluirPedido_MouseEnter);
            this.lblConcluirPedido.MouseLeave += new System.EventHandler(this.lblConcluirPedido_MouseLeave);
            // 
            // lblLimparDados
            // 
            this.lblLimparDados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLimparDados.AutoSize = true;
            this.lblLimparDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblLimparDados.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimparDados.ForeColor = System.Drawing.Color.White;
            this.lblLimparDados.Location = new System.Drawing.Point(283, 336);
            this.lblLimparDados.Name = "lblLimparDados";
            this.lblLimparDados.Padding = new System.Windows.Forms.Padding(10);
            this.lblLimparDados.Size = new System.Drawing.Size(130, 39);
            this.lblLimparDados.TabIndex = 18;
            this.lblLimparDados.Text = "Limpar Dados";
            this.lblLimparDados.Click += new System.EventHandler(this.lblLimparDados_Click);
            this.lblLimparDados.MouseEnter += new System.EventHandler(this.lblLimparDados_MouseEnter);
            this.lblLimparDados.MouseLeave += new System.EventHandler(this.lblLimparDados_MouseLeave);
            // 
            // numQtd
            // 
            this.numQtd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numQtd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numQtd.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQtd.ForeColor = System.Drawing.Color.DimGray;
            this.numQtd.Location = new System.Drawing.Point(349, 209);
            this.numQtd.Name = "numQtd";
            this.numQtd.Size = new System.Drawing.Size(64, 29);
            this.numQtd.TabIndex = 16;
            // 
            // lblQtd
            // 
            this.lblQtd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.ForeColor = System.Drawing.Color.DimGray;
            this.lblQtd.Location = new System.Drawing.Point(211, 211);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(106, 25);
            this.lblQtd.TabIndex = 15;
            this.lblQtd.Text = "Quantidade";
            // 
            // ckbBorda
            // 
            this.ckbBorda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbBorda.AutoSize = true;
            this.ckbBorda.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.ckbBorda.FlatAppearance.BorderSize = 5;
            this.ckbBorda.FlatAppearance.CheckedBackColor = System.Drawing.Color.Indigo;
            this.ckbBorda.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBorda.ForeColor = System.Drawing.Color.DimGray;
            this.ckbBorda.Location = new System.Drawing.Point(521, 198);
            this.ckbBorda.Name = "ckbBorda";
            this.ckbBorda.Padding = new System.Windows.Forms.Padding(10);
            this.ckbBorda.Size = new System.Drawing.Size(144, 47);
            this.ckbBorda.TabIndex = 14;
            this.ckbBorda.Text = "Com borda";
            this.ckbBorda.UseVisualStyleBackColor = true;
            // 
            // cmbPizza
            // 
            this.cmbPizza.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbPizza.AutoCompleteCustomSource.AddRange(new string[] {
            "Mussarela",
            "Calabresa",
            "Escarola",
            "Portuguesa"});
            this.cmbPizza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPizza.BackColor = System.Drawing.Color.White;
            this.cmbPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPizza.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPizza.ForeColor = System.Drawing.Color.DimGray;
            this.cmbPizza.FormattingEnabled = true;
            this.cmbPizza.Items.AddRange(new object[] {
            "Mussarela",
            "Calabresa",
            "Escarola",
            "Portuguesa"});
            this.cmbPizza.Location = new System.Drawing.Point(349, 143);
            this.cmbPizza.Name = "cmbPizza";
            this.cmbPizza.Size = new System.Drawing.Size(296, 33);
            this.cmbPizza.TabIndex = 13;
            // 
            // lblSabor
            // 
            this.lblSabor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSabor.AutoSize = true;
            this.lblSabor.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabor.ForeColor = System.Drawing.Color.DimGray;
            this.lblSabor.Location = new System.Drawing.Point(258, 147);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(57, 25);
            this.lblSabor.TabIndex = 12;
            this.lblSabor.Text = "Pizza";
            // 
            // txtPedido
            // 
            this.txtPedido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPedido.BackColor = System.Drawing.Color.White;
            this.txtPedido.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedido.ForeColor = System.Drawing.Color.DimGray;
            this.txtPedido.Location = new System.Drawing.Point(349, 75);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(296, 33);
            this.txtPedido.TabIndex = 11;
            // 
            // lblNumPedido
            // 
            this.lblNumPedido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumPedido.AutoSize = true;
            this.lblNumPedido.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPedido.ForeColor = System.Drawing.Color.DimGray;
            this.lblNumPedido.Location = new System.Drawing.Point(247, 79);
            this.lblNumPedido.Name = "lblNumPedido";
            this.lblNumPedido.Size = new System.Drawing.Size(95, 25);
            this.lblNumPedido.TabIndex = 10;
            this.lblNumPedido.Text = "Nº Pedido";
            // 
            // lblAddPizza
            // 
            this.lblAddPizza.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddPizza.AutoSize = true;
            this.lblAddPizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblAddPizza.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPizza.ForeColor = System.Drawing.Color.DimGray;
            this.lblAddPizza.Location = new System.Drawing.Point(670, 140);
            this.lblAddPizza.Name = "lblAddPizza";
            this.lblAddPizza.Padding = new System.Windows.Forms.Padding(10);
            this.lblAddPizza.Size = new System.Drawing.Size(144, 39);
            this.lblAddPizza.TabIndex = 9;
            this.lblAddPizza.Text = " Adicionar Pizza";
            this.lblAddPizza.Click += new System.EventHandler(this.lblAddPizza_Click);
            this.lblAddPizza.MouseEnter += new System.EventHandler(this.lblAddPizza_MouseEnter);
            this.lblAddPizza.MouseLeave += new System.EventHandler(this.lblAddPizza_MouseLeave);
            // 
            // panAlert
            // 
            this.panAlert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panAlert.BackColor = System.Drawing.Color.Salmon;
            this.panAlert.Controls.Add(this.lblAlert);
            this.panAlert.Controls.Add(this.ptbFechar);
            this.panAlert.Controls.Add(this.ptbAlert);
            this.panAlert.Location = new System.Drawing.Point(36, 548);
            this.panAlert.Margin = new System.Windows.Forms.Padding(0);
            this.panAlert.Name = "panAlert";
            this.panAlert.Size = new System.Drawing.Size(0, 35);
            this.panAlert.TabIndex = 3;
            // 
            // lblAlert
            // 
            this.lblAlert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAlert.AutoSize = true;
            this.lblAlert.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.ForeColor = System.Drawing.Color.White;
            this.lblAlert.Location = new System.Drawing.Point(-116, 4);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(233, 25);
            this.lblAlert.TabIndex = 2;
            this.lblAlert.Text = "Atenção estoque vazio!";
            this.lblAlert.Visible = false;
            // 
            // ptbFechar
            // 
            this.ptbFechar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ptbFechar.Image = global::Pizzaria.Properties.Resources.ic_close_white_24dp;
            this.ptbFechar.Location = new System.Drawing.Point(-36, 7);
            this.ptbFechar.Name = "ptbFechar";
            this.ptbFechar.Size = new System.Drawing.Size(24, 24);
            this.ptbFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbFechar.TabIndex = 1;
            this.ptbFechar.TabStop = false;
            this.ptbFechar.Visible = false;
            this.ptbFechar.Click += new System.EventHandler(this.ptbFechar_Click);
            // 
            // ptbAlert
            // 
            this.ptbAlert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ptbAlert.Image = global::Pizzaria.Properties.Resources.ic_warning_white_24dp;
            this.ptbAlert.Location = new System.Drawing.Point(-166, 5);
            this.ptbAlert.Name = "ptbAlert";
            this.ptbAlert.Size = new System.Drawing.Size(24, 24);
            this.ptbAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbAlert.TabIndex = 0;
            this.ptbAlert.TabStop = false;
            this.ptbAlert.Visible = false;
            // 
            // panSearch
            // 
            this.panSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panSearch.Controls.Add(this.btnSearch);
            this.panSearch.Controls.Add(this.txtSearch);
            this.panSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSearch.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panSearch.Location = new System.Drawing.Point(0, 0);
            this.panSearch.Margin = new System.Windows.Forms.Padding(0);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(925, 0);
            this.panSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::Pizzaria.Properties.Resources.ic_arrow_forward_white_24dp;
            this.btnSearch.Location = new System.Drawing.Point(664, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnSearch.Size = new System.Drawing.Size(35, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = true;
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "Pedido",
            "Estoque",
            "Usuário"});
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.BackColor = System.Drawing.Color.Peru;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Indigo;
            this.txtSearch.Location = new System.Drawing.Point(231, 24);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(463, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Visible = false;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // panSideBar
            // 
            this.panSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panSideBar.Controls.Add(this.lblData);
            this.panSideBar.Controls.Add(this.lblHora);
            this.panSideBar.Controls.Add(this.lblPedido);
            this.panSideBar.Controls.Add(this.lblStock);
            this.panSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSideBar.Location = new System.Drawing.Point(0, 75);
            this.panSideBar.Margin = new System.Windows.Forms.Padding(0);
            this.panSideBar.Name = "panSideBar";
            this.panSideBar.Size = new System.Drawing.Size(75, 583);
            this.panSideBar.TabIndex = 1;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.DimGray;
            this.lblData.Location = new System.Drawing.Point(63, 545);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(141, 29);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "10/03/2017";
            this.lblData.Visible = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.DimGray;
            this.lblHora.Location = new System.Drawing.Point(71, 411);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(108, 42);
            this.lblHora.TabIndex = 9;
            this.lblHora.Text = "16:33";
            this.lblHora.Visible = false;
            // 
            // lblPedido
            // 
            this.lblPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPedido.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.ForeColor = System.Drawing.Color.DimGray;
            this.lblPedido.Image = global::Pizzaria.Properties.Resources.path4;
            this.lblPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPedido.Location = new System.Drawing.Point(0, 75);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.lblPedido.Size = new System.Drawing.Size(75, 75);
            this.lblPedido.TabIndex = 7;
            this.lblPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPedido.Click += new System.EventHandler(this.lblPedido_Click);
            this.lblPedido.MouseEnter += new System.EventHandler(this.lblPedido_MouseEnter);
            this.lblPedido.MouseLeave += new System.EventHandler(this.lblPedido_MouseLeave);
            // 
            // lblStock
            // 
            this.lblStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStock.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.DimGray;
            this.lblStock.Image = global::Pizzaria.Properties.Resources.archive;
            this.lblStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStock.Location = new System.Drawing.Point(0, 0);
            this.lblStock.Margin = new System.Windows.Forms.Padding(0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.lblStock.Size = new System.Drawing.Size(75, 75);
            this.lblStock.TabIndex = 5;
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStock.Click += new System.EventHandler(this.lblStock_Click);
            this.lblStock.MouseEnter += new System.EventHandler(this.lblStock_MouseEnter);
            this.lblStock.MouseLeave += new System.EventHandler(this.lblStock_MouseLeave);
            // 
            // panActionBar
            // 
            this.panActionBar.BackColor = System.Drawing.Color.Gold;
            this.panActionBar.Controls.Add(this.ptbCarrinho);
            this.panActionBar.Controls.Add(this.ptbNotify);
            this.panActionBar.Controls.Add(this.ptbSearch);
            this.panActionBar.Controls.Add(this.ptbMenu);
            this.panActionBar.Controls.Add(this.lblTitulo);
            this.panActionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panActionBar.Location = new System.Drawing.Point(0, 0);
            this.panActionBar.Margin = new System.Windows.Forms.Padding(0);
            this.panActionBar.Name = "panActionBar";
            this.panActionBar.Size = new System.Drawing.Size(1000, 75);
            this.panActionBar.TabIndex = 0;
            // 
            // ptbCarrinho
            // 
            this.ptbCarrinho.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ptbCarrinho.Image = global::Pizzaria.Properties.Resources.ic_shopping_cart_24px;
            this.ptbCarrinho.Location = new System.Drawing.Point(894, 25);
            this.ptbCarrinho.Name = "ptbCarrinho";
            this.ptbCarrinho.Size = new System.Drawing.Size(24, 24);
            this.ptbCarrinho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbCarrinho.TabIndex = 4;
            this.ptbCarrinho.TabStop = false;
            this.ptbCarrinho.Click += new System.EventHandler(this.ptbCarrinho_Click);
            // 
            // ptbNotify
            // 
            this.ptbNotify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbNotify.Image = global::Pizzaria.Properties.Resources.ic_notifications_24_px2;
            this.ptbNotify.Location = new System.Drawing.Point(942, 25);
            this.ptbNotify.Name = "ptbNotify";
            this.ptbNotify.Size = new System.Drawing.Size(18, 22);
            this.ptbNotify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbNotify.TabIndex = 3;
            this.ptbNotify.TabStop = false;
            this.ptbNotify.Click += new System.EventHandler(this.ptbNotify_Click);
            // 
            // ptbSearch
            // 
            this.ptbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbSearch.Enabled = false;
            this.ptbSearch.Image = global::Pizzaria.Properties.Resources.ic_search_24px;
            this.ptbSearch.Location = new System.Drawing.Point(894, 25);
            this.ptbSearch.Name = "ptbSearch";
            this.ptbSearch.Size = new System.Drawing.Size(24, 24);
            this.ptbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbSearch.TabIndex = 2;
            this.ptbSearch.TabStop = false;
            this.ptbSearch.Visible = false;
            this.ptbSearch.Click += new System.EventHandler(this.ptbSearch_Click);
            // 
            // ptbMenu
            // 
            this.ptbMenu.Image = global::Pizzaria.Properties.Resources.path5;
            this.ptbMenu.Location = new System.Drawing.Point(30, 25);
            this.ptbMenu.Name = "ptbMenu";
            this.ptbMenu.Size = new System.Drawing.Size(24, 24);
            this.ptbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbMenu.TabIndex = 1;
            this.ptbMenu.TabStop = false;
            this.ptbMenu.Click += new System.EventHandler(this.ptbMenu_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto Lt", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitulo.Location = new System.Drawing.Point(81, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(95, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Pedido";
            // 
            // tmMenuSide
            // 
            this.tmMenuSide.Interval = 1;
            this.tmMenuSide.Tick += new System.EventHandler(this.tmMenuSide_Tick);
            // 
            // tmNotify
            // 
            this.tmNotify.Interval = 1;
            this.tmNotify.Tick += new System.EventHandler(this.tmNotify_Tick);
            // 
            // tmSearch
            // 
            this.tmSearch.Interval = 1;
            this.tmSearch.Tick += new System.EventHandler(this.tmSearch_Tick);
            // 
            // tmAlert
            // 
            this.tmAlert.Interval = 1;
            this.tmAlert.Tick += new System.EventHandler(this.tmAlert_Tick);
            // 
            // tmEstoque
            // 
            this.tmEstoque.Interval = 1;
            this.tmEstoque.Tick += new System.EventHandler(this.tmEstoque_Tick);
            // 
            // atualizaHora
            // 
            this.atualizaHora.Enabled = true;
            this.atualizaHora.Tick += new System.EventHandler(this.atualizaHora_Tick);
            // 
            // tmPedidos
            // 
            this.tmPedidos.Interval = 1;
            this.tmPedidos.Tick += new System.EventHandler(this.tmPedidos_Tick);
            // 
            // idEstoqueDataGridViewTextBoxColumn
            // 
            this.idEstoqueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idEstoqueDataGridViewTextBoxColumn.DataPropertyName = "IdEstoque";
            this.idEstoqueDataGridViewTextBoxColumn.HeaderText = "IdEstoque";
            this.idEstoqueDataGridViewTextBoxColumn.Name = "idEstoqueDataGridViewTextBoxColumn";
            this.idEstoqueDataGridViewTextBoxColumn.Visible = false;
            // 
            // idIngredienteDataGridViewTextBoxColumn
            // 
            this.idIngredienteDataGridViewTextBoxColumn.DataPropertyName = "IdIngrediente";
            this.idIngredienteDataGridViewTextBoxColumn.HeaderText = "IdIngrediente";
            this.idIngredienteDataGridViewTextBoxColumn.Name = "idIngredienteDataGridViewTextBoxColumn";
            this.idIngredienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // ingredienteDataGridViewTextBoxColumn
            // 
            this.ingredienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ingredienteDataGridViewTextBoxColumn.DataPropertyName = "Ingrediente";
            this.ingredienteDataGridViewTextBoxColumn.HeaderText = "Ingrediente";
            this.ingredienteDataGridViewTextBoxColumn.Name = "ingredienteDataGridViewTextBoxColumn";
            this.ingredienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.Width = 150;
            // 
            // estoqueModelBindingSource
            // 
            this.estoqueModelBindingSource.DataSource = typeof(Pizzaria.Model.EstoqueModel);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 683);
            this.Controls.Add(this.panPrincipal);
            this.Controls.Add(this.panTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizzaria C#";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.SizeChanged += new System.EventHandler(this.frmPrincipal_SizeChanged);
            this.panTitleBar.ResumeLayout(false);
            this.panTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaxiRest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            this.panPrincipal.ResumeLayout(false);
            this.panPedido.ResumeLayout(false);
            this.panPedido.PerformLayout();
            this.panNotify.ResumeLayout(false);
            this.panNotify.PerformLayout();
            this.panEstoque.ResumeLayout(false);
            this.panEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.panPedidos.ResumeLayout(false);
            this.panPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtd)).EndInit();
            this.panAlert.ResumeLayout(false);
            this.panAlert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAlert)).EndInit();
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            this.panSideBar.ResumeLayout(false);
            this.panSideBar.PerformLayout();
            this.panActionBar.ResumeLayout(false);
            this.panActionBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCarrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTitleBar;
        private System.Windows.Forms.Panel panPrincipal;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panActionBar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox ptbMenu;
        private System.Windows.Forms.PictureBox ptbExit;
        private System.Windows.Forms.PictureBox ptbMaxiRest;
        private System.Windows.Forms.PictureBox ptbMini;
        private System.Windows.Forms.Panel panSideBar;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Timer tmMenuSide;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.PictureBox ptbSearch;
        private System.Windows.Forms.PictureBox ptbNotify;
        private System.Windows.Forms.Timer tmNotify;
        private System.Windows.Forms.Timer tmSearch;
        public System.Windows.Forms.Timer tmAlert;
        private System.Windows.Forms.Panel panPedido;
        private System.Windows.Forms.Panel panNotify;
        private System.Windows.Forms.Label lblNotify;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.Panel panSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panAlert;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.PictureBox ptbFechar;
        private System.Windows.Forms.PictureBox ptbAlert;
        private System.Windows.Forms.Panel panEstoque;
        private System.Windows.Forms.Timer tmEstoque;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer atualizaHora;
        private System.Windows.Forms.Label lblAddPizza;
        private System.Windows.Forms.ListBox lstNotify;
        private System.Windows.Forms.Label lblNumPedido;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.ComboBox cmbPizza;
        private System.Windows.Forms.Label lblSabor;
        private System.Windows.Forms.CheckBox ckbBorda;
        private System.Windows.Forms.NumericUpDown numQtd;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.PictureBox ptbCarrinho;
        private System.Windows.Forms.Panel panPedidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblExcluirPedido;
        private System.Windows.Forms.ListBox lstPedidos;
        private System.Windows.Forms.Timer tmPedidos;
        private System.Windows.Forms.Label lblLimparDados;
        private System.Windows.Forms.CheckBox ckbAcabando;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.BindingSource estoqueModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIngredienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblConcluirPedido;
        private System.Windows.Forms.ComboBox cmbPedidos;
        private System.Windows.Forms.Label lblFinalizarPedido;
    }
}

