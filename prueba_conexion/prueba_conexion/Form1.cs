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
            //NpgsqlConnection conexion = new NpgsqlConnection("Server=192.168.100.170;Port=5432; User Id=postgres;Password=sinley143;Database=postgres");
            NpgsqlConnection conexion = new NpgsqlConnection("Server=192.168.100.14;Port=5432; User Id=postgres;Password=Indivi2022*.;Database=postgres");

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
            //NpgsqlConnection conexion = new NpgsqlConnection("Server=192.168.100.3;Port=5432; User Id=postgres;Password=sinley143;Database=postgres");
            //NpgsqlConnection conexion = new NpgsqlConnection("Server=192.168.100.14;Port=5432; User Id=postgres;Password=Indivi2022*.;Database=postgres");

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
    }
}
