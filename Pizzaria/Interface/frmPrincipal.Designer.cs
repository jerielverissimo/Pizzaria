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
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panPrincipal = new System.Windows.Forms.Panel();
            this.panSideBar = new System.Windows.Forms.Panel();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.panActionBar = new System.Windows.Forms.Panel();
            this.ptbNotify = new System.Windows.Forms.PictureBox();
            this.ptbSearch = new System.Windows.Forms.PictureBox();
            this.ptbMenu = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tmMenuSide = new System.Windows.Forms.Timer(this.components);
            this.tmNotify = new System.Windows.Forms.Timer(this.components);
            this.tmSearch = new System.Windows.Forms.Timer(this.components);
            this.tmAlert = new System.Windows.Forms.Timer(this.components);
            this.ptbAddPedido = new System.Windows.Forms.PictureBox();
            this.panSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panNotify = new System.Windows.Forms.Panel();
            this.lblClear = new System.Windows.Forms.Label();
            this.lblNotify = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panPedido = new System.Windows.Forms.Panel();
            this.ptbAlert = new System.Windows.Forms.PictureBox();
            this.ptbFechar = new System.Windows.Forms.PictureBox();
            this.lblAlert = new System.Windows.Forms.Label();
            this.panAlert = new System.Windows.Forms.Panel();
            this.panEstoque = new System.Windows.Forms.Panel();
            this.panTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaxiRest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            this.panPrincipal.SuspendLayout();
            this.panSideBar.SuspendLayout();
            this.panActionBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNotify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddPedido)).BeginInit();
            this.panSearch.SuspendLayout();
            this.panNotify.SuspendLayout();
            this.panPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAlert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFechar)).BeginInit();
            this.panAlert.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTitleBar
            // 
            this.panTitleBar.BackColor = System.Drawing.Color.SandyBrown;
            this.panTitleBar.Controls.Add(this.ptbMini);
            this.panTitleBar.Controls.Add(this.ptbMaxiRest);
            this.panTitleBar.Controls.Add(this.ptbClose);
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
            // ptbClose
            // 
            this.ptbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbClose.Image = global::Pizzaria.Properties.Resources.window_close;
            this.ptbClose.Location = new System.Drawing.Point(966, 0);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(24, 24);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbClose.TabIndex = 1;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.ptbClose_Click);
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
            // panSideBar
            // 
            this.panSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panSideBar.Controls.Add(this.lblPedido);
            this.panSideBar.Controls.Add(this.lblStock);
            this.panSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSideBar.Location = new System.Drawing.Point(0, 75);
            this.panSideBar.Margin = new System.Windows.Forms.Padding(0);
            this.panSideBar.Name = "panSideBar";
            this.panSideBar.Size = new System.Drawing.Size(75, 583);
            this.panSideBar.TabIndex = 1;
            // 
            // lblPedido
            // 
            this.lblPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPedido.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.ForeColor = System.Drawing.Color.DimGray;
            this.lblPedido.Image = global::Pizzaria.Properties.Resources.ic_local_pizza_white_48dp;
            this.lblPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPedido.Location = new System.Drawing.Point(0, 75);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
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
            this.lblStock.Image = global::Pizzaria.Properties.Resources.stocking_1_;
            this.lblStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStock.Location = new System.Drawing.Point(0, 0);
            this.lblStock.Margin = new System.Windows.Forms.Padding(0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
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
            // ptbNotify
            // 
            this.ptbNotify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbNotify.Image = global::Pizzaria.Properties.Resources.ic_notifications_white_24dp;
            this.ptbNotify.Location = new System.Drawing.Point(936, 25);
            this.ptbNotify.Name = "ptbNotify";
            this.ptbNotify.Size = new System.Drawing.Size(24, 24);
            this.ptbNotify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbNotify.TabIndex = 3;
            this.ptbNotify.TabStop = false;
            this.ptbNotify.Click += new System.EventHandler(this.ptbNotify_Click);
            // 
            // ptbSearch
            // 
            this.ptbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbSearch.Image = global::Pizzaria.Properties.Resources.ic_search_white_24dp;
            this.ptbSearch.Location = new System.Drawing.Point(888, 25);
            this.ptbSearch.Name = "ptbSearch";
            this.ptbSearch.Size = new System.Drawing.Size(24, 24);
            this.ptbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbSearch.TabIndex = 2;
            this.ptbSearch.TabStop = false;
            this.ptbSearch.Click += new System.EventHandler(this.ptbSearch_Click);
            // 
            // ptbMenu
            // 
            this.ptbMenu.Image = global::Pizzaria.Properties.Resources.ic_menu_white_24dp;
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
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitulo.Location = new System.Drawing.Point(81, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(134, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Pizzaria C#";
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
            // ptbAddPedido
            // 
            this.ptbAddPedido.Image = global::Pizzaria.Properties.Resources.add_circle_red;
            this.ptbAddPedido.Location = new System.Drawing.Point(67, 159);
            this.ptbAddPedido.Name = "ptbAddPedido";
            this.ptbAddPedido.Size = new System.Drawing.Size(48, 48);
            this.ptbAddPedido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbAddPedido.TabIndex = 0;
            this.ptbAddPedido.TabStop = false;
            this.ptbAddPedido.Click += new System.EventHandler(this.ptbAddPedido_Click);
            this.ptbAddPedido.MouseEnter += new System.EventHandler(this.ptbAddPedido_MouseEnter);
            this.ptbAddPedido.MouseLeave += new System.EventHandler(this.ptbAddPedido_MouseLeave);
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
            this.txtSearch.Size = new System.Drawing.Size(463, 30);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Visible = false;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
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
            // panNotify
            // 
            this.panNotify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panNotify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panNotify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panNotify.Controls.Add(this.lblNotify);
            this.panNotify.Controls.Add(this.lblClear);
            this.panNotify.Location = new System.Drawing.Point(700, 0);
            this.panNotify.Margin = new System.Windows.Forms.Padding(0);
            this.panNotify.Name = "panNotify";
            this.panNotify.Size = new System.Drawing.Size(225, 0);
            this.panNotify.TabIndex = 1;
            // 
            // lblClear
            // 
            this.lblClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblClear.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.ForeColor = System.Drawing.Color.DimGray;
            this.lblClear.Image = global::Pizzaria.Properties.Resources.ic_clear_all_black_24dp;
            this.lblClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClear.Location = new System.Drawing.Point(110, -44);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(24, 24);
            this.lblClear.TabIndex = 1;
            this.lblClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNotify
            // 
            this.lblNotify.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNotify.AutoSize = true;
            this.lblNotify.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotify.ForeColor = System.Drawing.Color.DimGray;
            this.lblNotify.Location = new System.Drawing.Point(43, 29);
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Size = new System.Drawing.Size(131, 25);
            this.lblNotify.TabIndex = 0;
            this.lblNotify.Text = "Notificações";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Novo pedido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(237, 170);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(237, 199);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(100, 20);
            this.txtQtd.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // panPedido
            // 
            this.panPedido.BackColor = System.Drawing.Color.White;
            this.panPedido.Controls.Add(this.ptbAddPedido);
            this.panPedido.Controls.Add(this.panAlert);
            this.panPedido.Controls.Add(this.panSearch);
            this.panPedido.Controls.Add(this.panNotify);
            this.panPedido.Controls.Add(this.panEstoque);
            this.panPedido.Controls.Add(this.label1);
            this.panPedido.Controls.Add(this.txtQtd);
            this.panPedido.Controls.Add(this.txtNome);
            this.panPedido.Controls.Add(this.button1);
            this.panPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPedido.Location = new System.Drawing.Point(75, 75);
            this.panPedido.Margin = new System.Windows.Forms.Padding(0);
            this.panPedido.Name = "panPedido";
            this.panPedido.Size = new System.Drawing.Size(925, 583);
            this.panPedido.TabIndex = 2;
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
            // panEstoque
            // 
            this.panEstoque.BackColor = System.Drawing.Color.Indigo;
            this.panEstoque.Location = new System.Drawing.Point(546, 0);
            this.panEstoque.Margin = new System.Windows.Forms.Padding(0);
            this.panEstoque.Name = "panEstoque";
            this.panEstoque.Size = new System.Drawing.Size(379, 583);
            this.panEstoque.TabIndex = 8;
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
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            this.panPrincipal.ResumeLayout(false);
            this.panSideBar.ResumeLayout(false);
            this.panActionBar.ResumeLayout(false);
            this.panActionBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNotify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddPedido)).EndInit();
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            this.panNotify.ResumeLayout(false);
            this.panNotify.PerformLayout();
            this.panPedido.ResumeLayout(false);
            this.panPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAlert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFechar)).EndInit();
            this.panAlert.ResumeLayout(false);
            this.panAlert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTitleBar;
        private System.Windows.Forms.Panel panPrincipal;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panActionBar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox ptbMenu;
        private System.Windows.Forms.PictureBox ptbClose;
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
        private System.Windows.Forms.Timer tmAlert;
        private System.Windows.Forms.Panel panPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panNotify;
        private System.Windows.Forms.Label lblNotify;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.Panel panSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox ptbAddPedido;
        private System.Windows.Forms.Panel panAlert;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.PictureBox ptbFechar;
        private System.Windows.Forms.PictureBox ptbAlert;
        private System.Windows.Forms.Panel panEstoque;
    }
}

