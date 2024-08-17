
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();

        }
        private void validarNumero()
        {

            int resultadoNumerico = 0;
            bool value = Int32.TryParse(Telefono.Text, out resultadoNumerico);

            if (value)
            {
                Console.WriteLine($"Converted '{value}' to {resultadoNumerico}.");
            }
            else
            {
                if (Telefono.Text.Length == 0)
                {
                   
                }
                else
                {
                    Telefono.Text = Telefono.Text[..^1];
                    MessageBox.Show("El número de teléfono debe incluir unicamente números");
                }


            }
        }
       
        private void validarCampo()
        {
            var vr = !string.IsNullOrEmpty(Nombre.Text) &&
                !string.IsNullOrEmpty(Telefono.Text) &&
                !string.IsNullOrEmpty(Correo.Text);
            Agregar.Enabled = vr;
            if (Agregar.Enabled)
            {
                Agregar.BackColor = Color.LimeGreen;
            }
            else {
                Agregar.BackColor = Color.FromArgb(40,40,40);
            }
            
        }
        private void validarCampoLleno()
        {
            var vrs = !string.IsNullOrEmpty(Nombre.Text) ||
                !string.IsNullOrEmpty(Telefono.Text) ||
                !string.IsNullOrEmpty(Correo.Text);
            Limpiar.Enabled = vrs;
            if (Limpiar.Enabled)
            {
                Limpiar.BackColor = Color.White;
            }
            else
            {
                Limpiar.BackColor = Color.FromArgb(40, 40, 40);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Agregar.Enabled = false;
            Limpiar.Enabled = false;
            Agregar.BackColor = Color.FromArgb(40,40,40);
            Limpiar.BackColor = Color.FromArgb(40, 40, 40);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (Telefono.Text.Length >= 8)
            {
                if (validarCorreo())
                {
                    validarCampo();
                    validarCampoLleno();

                    string[] data = { Nombre.Text, Telefono.Text, Correo.Text };
                    var ls = new ListViewItem(data);
                    lista.Items.Add(ls);
                    borrarDatos();
                }
                else
                {
                    MessageBox.Show("Ingrese un email valido para continuar");
                }
                
            }
            else {
                MessageBox.Show("El número de teléfono debe contener 8 números");
            }
           

        }
        public void borrarDatos()
        {
            Nombre.Text = string.Empty;
            Telefono.Text = string.Empty;
            Correo.Text = string.Empty;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            borrarDatos();
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            lista.View = View.Details;
            lista.GridLines = false;
            
        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
            validarCampoLleno();
        }

        private void Telefono_TextChanged(object sender, EventArgs e)
        {
            validarNumero();
            validarCampo();
            validarCampoLleno();
        }
        public bool validarCorreo()
        {
            string email = Correo.Text;
            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (expr.IsMatch(email)) {
                return true;
            } else {
                return false;
            }
        }
        private void Correo_TextChanged(object sender, EventArgs e)
        {
           
            if (Correo.Text.Length > 3)
            {
                validarCampo();
            }
            else {
                Agregar.BackColor = Color.FromArgb(40, 40, 40);
                Agregar.Enabled = false;
            }
            validarCampoLleno();           
        }
    
    }
}
