using FolhaFacil.NetCore.usuario;

namespace FolhaFacil.NetCore
{
    public partial class frmMenuPrincipal : Form
    {
        private Form frmActive;
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        public frmMenuPrincipal()
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        {
            
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveFormClose();
            lblTitleMenu.Text = "Home";
        }

        private void btnFolhaPagamento_Click(object sender, EventArgs e)
        {

        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void btnConvenio_Click(object sender, EventArgs e)
        {

        }

        private void btnFerias_Click(object sender, EventArgs e)
        {

        }

        private void btnBeneficio_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormShow(new frmUsuario());
        }

        //metodos que manipulam o menu

        private void ActiveFormClose()
        {
            if (frmActive != null)
            {
                frmActive.Close();
            }
        }
        private void FormShow(Form childForm)
        {
            ActiveFormClose();
            frmActive = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            lblTitleMenu.Text = childForm.Text;
        }

        private void ActiveButton(Button buttonFrmActive)
        {
            foreach (Control control in panelMenu.Controls)
            {
                control.BackColor = Color.FromArgb(37, 40, 60);
                buttonFrmActive.BackColor = Color.FromArgb(212, 109, 255);
            }
        }


    }
}