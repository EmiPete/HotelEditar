using Microsoft.VisualBasic;
using System.Drawing.Imaging;

namespace HOTEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string  usuario, contrase�a;

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Usuariotxt.Clear();
            Contrase�atxt.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            Form cerrar = new Form1();
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs E)
        {
            
            usuario = Convert.ToString (Usuariotxt.Text);
            contrase�a =Convert.ToString (Contrase�atxt.Text);

          if(usuario=="EliasBs" && contrase�a=="123")
            {
                Form nuevo = new Menu();
                nuevo.Show();

                
               

            }
            else
            {
                MessageBox.Show("Error al entrar");
            }


        }

        }
    }


