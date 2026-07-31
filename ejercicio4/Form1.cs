using System.Reflection.PortableExecutable;

namespace ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe llenar el espacio para continuar");
                txtNombre.Focus();
                return;
            }

            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Debe llenar el espacio para continuar");
                txtTelefono.Focus();
                return;
            }


            if (!int.TryParse(txtTelefono.Text, out _))
            {
                MessageBox.Show("Debe colocar numeros");
                txtTelefono.Focus();
                return;

            }

            if (txtCorreo.Text == "")
            {
                MessageBox.Show("Debe llenar el espacio para continuar");
                txtCorreo.Focus();
                return;
            }

            if (!txtCorreo.Text.Contains("@") || !txtCorreo.Text.Contains(".com"))
            {
                MessageBox.Show("Debe colocar @ y .com");
                txtCorreo.Focus();
                return;
            }

            lstLista.Items.Add(txtNombre.Text);
            lstLista.Items.Add(txtTelefono.Text);
            lstLista.Items.Add(txtCorreo.Text);
            txtNombre.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            lstLista.Items.Add("");

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
