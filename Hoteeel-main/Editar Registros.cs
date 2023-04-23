using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL
{
    public partial class Editar_Registros : Form
    {
        public Editar_Registros()
        {
            InitializeComponent();
        }

        private void Editar_Registros_Load(object sender, EventArgs e)
        {
            string cadenaConexion = "Database=hotel;data source = localhost;user id=root; pass =; SSL Mode = None;";

            MySqlConnection conexionDb;
            DataTable datatable = new DataTable();
            MySqlDataReader resultado;
            conexionDb = new MySqlConnection(cadenaConexion);

            MySqlCommand comando = new MySqlCommand("SELECT * FROM hotel where Vigencia=true", conexionDb);
            comando.CommandType = CommandType.Text;

            conexionDb.Open();
            try
            {


                resultado = comando.ExecuteReader();
                datatable.Load(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DGVEditar.DataSource = datatable;
            conexionDb.Close();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

            bool verificarid = false;
            string cadenaConexion = "Database=hotel;data source = localhost;user id=root; pass =; SSL Mode = None;";

            MySqlConnection conexionDb;
            MySqlDataReader resultado;

            try
            {
                conexionDb = new MySqlConnection(cadenaConexion);

                MySqlCommand comando = new MySqlCommand("SELECT id FROM hotel ", conexionDb);

                conexionDb.Open();

                resultado = comando.ExecuteReader();
                while (resultado.Read()) //Recorre todos los id
                {
                    int id = resultado.GetInt32(0);//Le asigna el id a la variable id
                    if (id == Convert.ToInt32(txtId.Text))
                    { //Verifica si el idText es alguno de los que hay en la base
                        verificarid = true;
                    }



                }
                resultado.Close();
                if (verificarid == false) MessageBox.Show("El registro con el id ingresado no existe");
                else
                {
                    PanelCampos.Enabled = true;
                    comando = new MySqlCommand("SELECT * FROM hotel where id=" + txtId.Text, conexionDb);
                    resultado = comando.ExecuteReader();
                    while (resultado.Read())
                    {
                        txtNombre.Text = resultado.GetString(1);
                        txtTelefono.Text = resultado.GetString(2);
                        txtEdad.Text = resultado.GetString(3);
                        txtDias.Text = resultado.GetString(4);
                        cmboxHab.Text = resultado.GetString(5);
                        DTPDiaEntrada.Text = resultado.GetString(7);


                    }


                    
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataTable recargar = new DataTable();
            int total = 0;
            DateTime DTPDiaSalida = DTPDiaEntrada.Value;
            DTPDiaSalida = DTPDiaSalida.AddDays(Convert.ToInt32(txtDias.Text));
            string DiaSalida = DTPDiaSalida.ToString();
            string cadenaConexion = "Database=hotel;data source = localhost;user id=root; pass =; SSL Mode = None;";

            MySqlConnection conexionDb;
            MySqlDataReader resultado;

            try
            {
                conexionDb = new MySqlConnection(cadenaConexion);
                conexionDb.Open();
                if (cmboxHab.Text == "Habitacion sencilla $100") total = 100 * Convert.ToInt32(txtDias.Text);
                else if (cmboxHab.Text == "Habitacion Doble $200") total = 200 * Convert.ToInt32(txtDias.Text);
                else if (cmboxHab.Text == "Habitacion VIP $500") total = 500 * Convert.ToInt32(txtDias.Text);
                else if (cmboxHab.Text == "Habitacion VIP doble $600") total = 600 * Convert.ToInt32(txtDias.Text);

                MySqlCommand comando = new MySqlCommand("UPDATE hotel set nombre='" + txtNombre.Text + "', telefono='" + txtTelefono.Text + "', edad='" + txtEdad.Text + "',dias='" + txtDias.Text + "', Habitacion='" + cmboxHab.SelectedItem + "', total='" + total + "', DiaEntrada='" + DTPDiaEntrada.Text + "', DiaSalida='" + DiaSalida + "' where id=" + txtId.Text, conexionDb);
                comando.ExecuteNonQuery();
                comando = new MySqlCommand("SELECT * FROM hotel where Vigencia=true", conexionDb);
                
                resultado = comando.ExecuteReader();
                recargar.Load(resultado);
                DGVEditar.DataSource = recargar;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
