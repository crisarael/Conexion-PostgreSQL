using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace prueba_conexion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Conectar_Click(object sender, EventArgs e)

        {
            NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost; User Id=postgres;Password=sinley143;Database=postgres");
         

            try
            {
                conexion.Open();
                MessageBox.Show("Conexion Realizada");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Desconectar_Click(object sender, EventArgs e)
        {
            //NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=sinley143;Database=postgres");

            NpgsqlConnection conexion = new NpgsqlConnection("Server=192.168.100.14;Port=5432; User Id=postgres;Password=Indivi2022*.;Database=postgres");
            try
            {
                conexion.Close();
                MessageBox.Show("Conexion Desconectada");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Consultar_Click(object sender, EventArgs e)
        {

            NpgsqlConnection conexion = new NpgsqlConnection("Server=192.168.100.14;Port=5432; User Id=postgres;Password=Indivi2022*.;Database=Prueba");
            conexion.Open();

            string query = "Select * from empleados";

            NpgsqlCommand comando = new NpgsqlCommand(query,conexion);

            NpgsqlDataAdapter data = new NpgsqlDataAdapter(comando);
            data.SelectCommand = comando;
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            datos.DataSource = tabla;
            datos.Columns["idempleado"].Visible = false;
            datos.Columns["fechanacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            MessageBox.Show("Consulta Realizada");

            //string query = "Select * from empleados";
            //NpgsqlCommandBuilder comando = new NpgsqlCommandBuilder(query, conexion);
            //SqlDataAdapter data = new SqlDataAdapter(comando);
            //DataTable tabla = new DataTable();
            //data.Fill(tabla);
            //datos.DataSource = tabla;
            //MessageBox.Show("Consulta Realizada");
        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            //NpgsqlConnection conexion = new NpgsqlConnection("Server=192.168.100.14;Port=5432; User Id=postgres;Password=Indivi2022*.;Database=Prueba");
            NpgsqlConnection conexion = new NpgsqlConnection("Server=192.168.100.14;Port=5432; User Id=postgres;Password=Indivi2022*.;Database=Prueba");


            NpgsqlCommand altas = new NpgsqlCommand("insert into empleados(idempleado,nombre,apellidopaterno,apellidomaterno,fechanacimiento,telefono,sueldo,puesto) values(@idempleado,@nombre,@apellidopaterno,@apellidomaterno,@fechanacimiento,@telefono,@sueldo,@puesto)",conexion);
           
            //converciones de datos
            string date = fechanacimiento.Text;
            DateTime dt = Convert.ToDateTime(date);
            decimal tel = Convert.ToDecimal(telefono.Text);
            decimal sueld = Convert.ToDecimal(sueldo.Text);
            decimal empleado= Convert.ToDecimal(idempleado.Text);


            // se pasan los valores de los text box a las variables temporales
            altas.Parameters.AddWithValue("idempleado", empleado);
            altas.Parameters.AddWithValue("nombre", nombre.Text);
            altas.Parameters.AddWithValue("apellidopaterno", apellidopaterno.Text);
            altas.Parameters.AddWithValue("apellidomaterno", apellidomaterno.Text);
            altas.Parameters.AddWithValue("fechanacimiento", dt);
            altas.Parameters.AddWithValue("telefono", tel);
            altas.Parameters.AddWithValue("sueldo", sueld);
            altas.Parameters.AddWithValue("puesto", puesto.Text);

            conexion.Open();// se abre la conexion
            altas.ExecuteNonQuery();
            conexion.Close();// se cierra la conexion
            MessageBox.Show("Empleado dado de alta");
            
        }

        private void Btnimagen_Click(object sender, EventArgs e)
        {
            Form VentanaImagen = new Imagenes();
            VentanaImagen.ShowDialog();
        }
    }
}