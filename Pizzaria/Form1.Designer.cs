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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panPrincipal = new System.Windows.Forms.Panel();
            this.panActionBar = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panSideBar = new System.Windows.Forms.Panel();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.ptbMenu = new System.Windows.Forms.PictureBox();
            this.ptbMini = new System.Windows.Forms.PictureBox();
            this.ptbMaxiRest = new System.Windows.Forms.PictureBox();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.tmMenuSide = new System.Windows.Forms.Timer(this.components);
            this.panTitleBar.SuspendLayout();
            this.panPrincipal.SuspendLayout();
            this.panActionBar.SuspendLayout();
            this.panSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaxiRest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
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
            this.panTitleBar.Size = new System.Drawing.Size(784, 25);
            this.panTitleBar.TabIndex = 0;
            this.panTitleBar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseDoubleClick);
            this.panTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseDown);
            this.panTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panTitleBar_MouseMove);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(347, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(91, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pizzaria C#";
            // 
            // panPrincipal
            // 
            this.panPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panPrincipal.Controls.Add(this.panSideBar);
            this.panPrincipal.Controls.Add(this.panActionBar);
            this.panPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPrincipal.Location = new System.Drawing.Point(0, 25);
            this.panPrincipal.Name = "panPrincipal";
            this.panPrincipal.Size = new System.Drawing.Size(784, 537);
            this.panPrincipal.TabIndex = 1;
            // 
            // panActionBar
            // 
            this.panActionBar.BackColor = System.Drawing.Color.Gold;
            this.panActionBar.Controls.Add(this.ptbMenu);
            this.panActionBar.Controls.Add(this.lblTitulo);
            this.panActionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panActionBar.Location = new System.Drawing.Point(0, 0);
            this.panActionBar.Margin = new System.Windows.Forms.Padding(0);
            this.panActionBar.Name = "panActionBar";
            this.panActionBar.Size = new System.Drawing.Size(784, 75);
            this.panActionBar.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(81, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(134, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Pizzaria C#";
            // 
            // panSideBar
            // 
            this.panSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panSideBar.Controls.Add(this.lblStock);
            this.panSideBar.Controls.Add(this.lblUser);
            this.panSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSideBar.Location = new System.Drawing.Point(0, 75);
            this.panSideBar.Margin = new System.Windows.Forms.Padding(0);
            this.panSideBar.Name = "panSideBar";
            this.panSideBar.Size = new System.Drawing.Size(250, 462);
            this.panSideBar.TabIndex = 1;
            // 
            // lblStock
            // 
            this.lblStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStock.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.White;
            this.lblStock.Image = global::Pizzaria.Properties.Resources.stocking_1_;
            this.lblStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStock.Location = new System.Drawing.Point(0, 75);
            this.lblStock.Margin = new System.Windows.Forms.Padding(0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblStock.Size = new System.Drawing.Size(250, 75);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Estoque";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStock.MouseEnter += new System.EventHandler(this.lblStock_MouseEnter);
            this.lblStock.MouseLeave += new System.EventHandler(this.lblStock_MouseLeave);
            // 
            // lblUser
            // 
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUser.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Image = global::Pizzaria.Properties.Resources.ic_account_circle_white_48dp;
            this.lblUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUser.Location = new System.Drawing.Point(0, 0);
            this.lblUser.Margin = new System.Windows.Forms.Padding(0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblUser.Size = new System.Drawing.Size(250, 75);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Usuário";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUser.MouseEnter += new System.EventHandler(this.lblUser_MouseEnter);
            this.lblUser.MouseLeave += new System.EventHandler(this.lblUser_MouseLeave);
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
            // ptbMini
            // 
            this.ptbMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMini.Image = global::Pizzaria.Properties.Resources.window_minimize;
            this.ptbMini.Location = new System.Drawing.Point(690, 1);
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
            this.ptbMaxiRest.Location = new System.Drawing.Point(720, 0);
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
            this.ptbClose.Location = new System.Drawing.Point(750, 0);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(24, 24);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbClose.TabIndex = 1;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.ptbClose_Click);
            // 
            // tmMenuSide
            // 
            this.tmMenuSide.Interval = 1;
            this.tmMenuSide.Tick += new System.EventHandler(this.tmMenuSide_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panPrincipal);
            this.Controls.Add(this.panTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizzaria C#";
            this.panTitleBar.ResumeLayout(false);
            this.panTitleBar.PerformLayout();
            this.panPrincipal.ResumeLayout(false);
            this.panActionBar.ResumeLayout(false);
            this.panActionBar.PerformLayout();
            this.panSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaxiRest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
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
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Timer tmMenuSide;
    }
}

