namespace FolhaFacil.NetCore
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnUsuario = new Button();
            btnBeneficio = new Button();
            btnFerias = new Button();
            btnConvenio = new Button();
            btnEmpresa = new Button();
            btnFuncionario = new Button();
            btnFolhaPagamento = new Button();
            btnHome = new Button();
            panelLogo = new Panel();
            panel1 = new Panel();
            panelUpBar = new Panel();
            lblTitleMenu = new Label();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panelUpBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(37, 40, 60);
            panelMenu.Controls.Add(btnUsuario);
            panelMenu.Controls.Add(btnBeneficio);
            panelMenu.Controls.Add(btnFerias);
            panelMenu.Controls.Add(btnConvenio);
            panelMenu.Controls.Add(btnEmpresa);
            panelMenu.Controls.Add(btnFuncionario);
            panelMenu.Controls.Add(btnFolhaPagamento);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 606);
            panelMenu.TabIndex = 0;
            // 
            // btnUsuario
            // 
            btnUsuario.BackColor = Color.FromArgb(37, 40, 60);
            btnUsuario.Dock = DockStyle.Top;
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 109, 255);
            btnUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(212, 109, 255);
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.ForeColor = Color.White;
            btnUsuario.Image = Properties.Resources.icones_usuario;
            btnUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuario.Location = new Point(0, 437);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Padding = new Padding(10, 0, 0, 0);
            btnUsuario.Size = new Size(250, 50);
            btnUsuario.TabIndex = 8;
            btnUsuario.Text = "Usuário";
            btnUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnBeneficio
            // 
            btnBeneficio.BackColor = Color.FromArgb(37, 40, 60);
            btnBeneficio.Dock = DockStyle.Top;
            btnBeneficio.FlatAppearance.BorderSize = 0;
            btnBeneficio.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 109, 255);
            btnBeneficio.FlatAppearance.MouseOverBackColor = Color.FromArgb(212, 109, 255);
            btnBeneficio.FlatStyle = FlatStyle.Flat;
            btnBeneficio.ForeColor = Color.White;
            btnBeneficio.Image = Properties.Resources.icone_beneficio;
            btnBeneficio.ImageAlign = ContentAlignment.MiddleLeft;
            btnBeneficio.Location = new Point(0, 387);
            btnBeneficio.Name = "btnBeneficio";
            btnBeneficio.Padding = new Padding(10, 0, 0, 0);
            btnBeneficio.Size = new Size(250, 50);
            btnBeneficio.TabIndex = 7;
            btnBeneficio.Text = "Beneficio";
            btnBeneficio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBeneficio.UseVisualStyleBackColor = false;
            btnBeneficio.Click += btnBeneficio_Click;
            // 
            // btnFerias
            // 
            btnFerias.Dock = DockStyle.Top;
            btnFerias.FlatAppearance.BorderSize = 0;
            btnFerias.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 109, 255);
            btnFerias.FlatAppearance.MouseOverBackColor = Color.FromArgb(212, 109, 255);
            btnFerias.FlatStyle = FlatStyle.Flat;
            btnFerias.ForeColor = Color.White;
            btnFerias.Image = Properties.Resources.icone_ferias;
            btnFerias.ImageAlign = ContentAlignment.MiddleLeft;
            btnFerias.Location = new Point(0, 337);
            btnFerias.Name = "btnFerias";
            btnFerias.Padding = new Padding(10, 0, 0, 0);
            btnFerias.Size = new Size(250, 50);
            btnFerias.TabIndex = 6;
            btnFerias.Text = "Ferias";
            btnFerias.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFerias.UseVisualStyleBackColor = true;
            btnFerias.Click += btnFerias_Click;
            // 
            // btnConvenio
            // 
            btnConvenio.BackColor = Color.FromArgb(37, 40, 60);
            btnConvenio.Dock = DockStyle.Top;
            btnConvenio.FlatAppearance.BorderSize = 0;
            btnConvenio.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 109, 255);
            btnConvenio.FlatAppearance.MouseOverBackColor = Color.FromArgb(212, 109, 255);
            btnConvenio.FlatStyle = FlatStyle.Flat;
            btnConvenio.ForeColor = Color.White;
            btnConvenio.Image = Properties.Resources.icone_convenio;
            btnConvenio.ImageAlign = ContentAlignment.MiddleLeft;
            btnConvenio.Location = new Point(0, 287);
            btnConvenio.Name = "btnConvenio";
            btnConvenio.Padding = new Padding(10, 0, 0, 0);
            btnConvenio.Size = new Size(250, 50);
            btnConvenio.TabIndex = 5;
            btnConvenio.Text = "Convênio";
            btnConvenio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConvenio.UseVisualStyleBackColor = false;
            btnConvenio.Click += btnConvenio_Click;
            // 
            // btnEmpresa
            // 
            btnEmpresa.BackColor = Color.FromArgb(37, 40, 60);
            btnEmpresa.Dock = DockStyle.Top;
            btnEmpresa.FlatAppearance.BorderSize = 0;
            btnEmpresa.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 109, 255);
            btnEmpresa.FlatAppearance.MouseOverBackColor = Color.FromArgb(212, 109, 255);
            btnEmpresa.FlatStyle = FlatStyle.Flat;
            btnEmpresa.ForeColor = Color.White;
            btnEmpresa.Image = Properties.Resources.icones_empresa;
            btnEmpresa.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpresa.Location = new Point(0, 237);
            btnEmpresa.Name = "btnEmpresa";
            btnEmpresa.Padding = new Padding(10, 0, 0, 0);
            btnEmpresa.Size = new Size(250, 50);
            btnEmpresa.TabIndex = 4;
            btnEmpresa.Text = "Empresa";
            btnEmpresa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmpresa.UseVisualStyleBackColor = false;
            btnEmpresa.Click += btnEmpresa_Click;
            // 
            // btnFuncionario
            // 
            btnFuncionario.BackColor = Color.FromArgb(37, 40, 60);
            btnFuncionario.Dock = DockStyle.Top;
            btnFuncionario.FlatAppearance.BorderSize = 0;
            btnFuncionario.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 109, 255);
            btnFuncionario.FlatAppearance.MouseOverBackColor = Color.FromArgb(212, 109, 255);
            btnFuncionario.FlatStyle = FlatStyle.Flat;
            btnFuncionario.ForeColor = Color.White;
            btnFuncionario.Image = Properties.Resources.icone_funcionario;
            btnFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            btnFuncionario.Location = new Point(0, 187);
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.Padding = new Padding(10, 0, 0, 0);
            btnFuncionario.Size = new Size(250, 50);
            btnFuncionario.TabIndex = 3;
            btnFuncionario.Text = "Funcionario";
            btnFuncionario.TextAlign = ContentAlignment.MiddleLeft;
            btnFuncionario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFuncionario.UseVisualStyleBackColor = false;
            btnFuncionario.Click += btnFuncionario_Click;
            // 
            // btnFolhaPagamento
            // 
            btnFolhaPagamento.BackColor = Color.FromArgb(37, 40, 60);
            btnFolhaPagamento.Dock = DockStyle.Top;
            btnFolhaPagamento.FlatAppearance.BorderSize = 0;
            btnFolhaPagamento.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 109, 255);
            btnFolhaPagamento.FlatAppearance.MouseOverBackColor = Color.FromArgb(212, 109, 255);
            btnFolhaPagamento.FlatStyle = FlatStyle.Flat;
            btnFolhaPagamento.ForeColor = Color.White;
            btnFolhaPagamento.Image = Properties.Resources.icone_holerite;
            btnFolhaPagamento.ImageAlign = ContentAlignment.MiddleLeft;
            btnFolhaPagamento.Location = new Point(0, 137);
            btnFolhaPagamento.Name = "btnFolhaPagamento";
            btnFolhaPagamento.Padding = new Padding(10, 0, 0, 0);
            btnFolhaPagamento.Size = new Size(250, 50);
            btnFolhaPagamento.TabIndex = 2;
            btnFolhaPagamento.Text = "Folha de Pagamento";
            btnFolhaPagamento.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFolhaPagamento.UseVisualStyleBackColor = false;
            btnFolhaPagamento.Click += btnFolhaPagamento_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(37, 40, 60);
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 109, 255);
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(212, 109, 255);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = Color.White;
            btnHome.Image = Properties.Resources.icones_home;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 87);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(10, 0, 0, 0);
            btnHome.Size = new Size(250, 50);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(29, 29, 45);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 87);
            panelLogo.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Location = new Point(669, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 0;
            // 
            // panelUpBar
            // 
            panelUpBar.BackColor = SystemColors.ButtonFace;
            panelUpBar.Controls.Add(lblTitleMenu);
            panelUpBar.Dock = DockStyle.Top;
            panelUpBar.Location = new Point(250, 0);
            panelUpBar.Name = "panelUpBar";
            panelUpBar.Size = new Size(1182, 87);
            panelUpBar.TabIndex = 1;
            // 
            // lblTitleMenu
            // 
            lblTitleMenu.AutoSize = true;
            lblTitleMenu.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleMenu.Location = new Point(62, 9);
            lblTitleMenu.Name = "lblTitleMenu";
            lblTitleMenu.Size = new Size(86, 35);
            lblTitleMenu.TabIndex = 0;
            lblTitleMenu.Text = "Home";
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(250, 87);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1182, 519);
            panelDesktop.TabIndex = 2;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1432, 606);
            Controls.Add(panelDesktop);
            Controls.Add(panelUpBar);
            Controls.Add(panelMenu);
            MinimumSize = new Size(1450, 653);
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Folha Facil - Menu Principal";
            Load += frmMenuPrincipal_Load;
            panelMenu.ResumeLayout(false);
            panelUpBar.ResumeLayout(false);
            panelUpBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel1;
        private Panel panelLogo;
        private Button btnHome;
        private Button btnFolhaPagamento;
        private Button btnEmpresa;
        private Button btnFuncionario;
        private Button btnConvenio;
        private Button btnFerias;
        private Button btnBeneficio;
        private Button btnUsuario;
        private Panel panelUpBar;
        private Panel panelDesktop;
        private Label lblTitleMenu;
    }
}