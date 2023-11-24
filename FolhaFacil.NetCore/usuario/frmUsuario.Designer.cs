namespace FolhaFacil.NetCore.usuario
{
    partial class frmUsuario
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
            dgvUsuario = new DataGridView();
            btnAddUsuario = new Button();
            btnEditarUsuario = new Button();
            btnDeletarUsuario = new Button();
            txtPesquisarUsuario = new TextBox();
            btnPesquisarUsuario = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuario
            // 
            dgvUsuario.AllowUserToAddRows = false;
            dgvUsuario.AllowUserToDeleteRows = false;
            dgvUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Location = new Point(12, 79);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.ReadOnly = true;
            dgvUsuario.RowHeadersWidth = 51;
            dgvUsuario.RowTemplate.Height = 29;
            dgvUsuario.Size = new Size(923, 360);
            dgvUsuario.TabIndex = 0;
            // 
            // btnAddUsuario
            // 
            btnAddUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddUsuario.BackColor = Color.FromArgb(49, 164, 117);
            btnAddUsuario.FlatAppearance.BorderSize = 0;
            btnAddUsuario.FlatStyle = FlatStyle.Flat;
            btnAddUsuario.ForeColor = Color.White;
            btnAddUsuario.Location = new Point(958, 112);
            btnAddUsuario.Name = "btnAddUsuario";
            btnAddUsuario.Size = new Size(136, 51);
            btnAddUsuario.TabIndex = 2;
            btnAddUsuario.Text = "Adicionar";
            btnAddUsuario.UseVisualStyleBackColor = false;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditarUsuario.BackColor = Color.FromArgb(97, 149, 243);
            btnEditarUsuario.FlatAppearance.BorderSize = 0;
            btnEditarUsuario.FlatStyle = FlatStyle.Popup;
            btnEditarUsuario.ForeColor = Color.White;
            btnEditarUsuario.Location = new Point(958, 180);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(136, 51);
            btnEditarUsuario.TabIndex = 3;
            btnEditarUsuario.Text = "Editar";
            btnEditarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnDeletarUsuario
            // 
            btnDeletarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeletarUsuario.BackColor = Color.FromArgb(245, 98, 99);
            btnDeletarUsuario.FlatAppearance.BorderSize = 0;
            btnDeletarUsuario.FlatStyle = FlatStyle.Flat;
            btnDeletarUsuario.ForeColor = Color.White;
            btnDeletarUsuario.Location = new Point(958, 249);
            btnDeletarUsuario.Name = "btnDeletarUsuario";
            btnDeletarUsuario.Size = new Size(136, 51);
            btnDeletarUsuario.TabIndex = 4;
            btnDeletarUsuario.Text = "Deletar";
            btnDeletarUsuario.UseVisualStyleBackColor = false;
            // 
            // txtPesquisarUsuario
            // 
            txtPesquisarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisarUsuario.Location = new Point(12, 33);
            txtPesquisarUsuario.Name = "txtPesquisarUsuario";
            txtPesquisarUsuario.Size = new Size(765, 27);
            txtPesquisarUsuario.TabIndex = 0;
            // 
            // btnPesquisarUsuario
            // 
            btnPesquisarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisarUsuario.BackColor = Color.Orange;
            btnPesquisarUsuario.FlatAppearance.BorderSize = 0;
            btnPesquisarUsuario.FlatStyle = FlatStyle.Flat;
            btnPesquisarUsuario.Location = new Point(797, 31);
            btnPesquisarUsuario.Name = "btnPesquisarUsuario";
            btnPesquisarUsuario.Size = new Size(127, 29);
            btnPesquisarUsuario.TabIndex = 1;
            btnPesquisarUsuario.Text = "Pesquisar";
            btnPesquisarUsuario.UseVisualStyleBackColor = false;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 472);
            Controls.Add(btnPesquisarUsuario);
            Controls.Add(txtPesquisarUsuario);
            Controls.Add(btnDeletarUsuario);
            Controls.Add(btnEditarUsuario);
            Controls.Add(btnAddUsuario);
            Controls.Add(dgvUsuario);
            Name = "frmUsuario";
            Text = "Usuário";
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuario;
        private Button btnAddUsuario;
        private Button btnEditarUsuario;
        private Button btnDeletarUsuario;
        private TextBox txtPesquisarUsuario;
        private Button btnPesquisarUsuario;
    }
}