using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace prueba_conexion
{
    public partial class Imagenes : Form
    {
        public Imagenes()
        {
            InitializeComponent();
        }

        //Carga la imagen
        private void Btncargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Seleccione una imágenes en formato|*.jpeg;*.png;*.bmp;*.ico";
            BuscarImagen.InitialDirectory = @"C:\\";
            BuscarImagen.FileName = RutaImagen.Text;

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                RutaImagen.Text = BuscarImagen.FileName;
                string Ruta = BuscarImagen.FileName;
                imagen.ImageLocation = Ruta;
                imagen.SizeMode = PictureBoxSizeMode.StretchImage;  
               
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=sinley143;Database=postgres");
            MemoryStream ms = new MemoryStream();
            imagen.Image.Save(ms, ImageFormat.Png);
            byte[] abyte = ms.ToArray();

            try { 

               NpgsqlCommand InsertarImagen = new NpgsqlCommand("INSERT INTO imagenes (idimagen,nombre,imagen) values (@idimagen,@nombre,@imagen)",conexion);
                InsertarImagen.Parameters.AddWithValue("idimagen", Convert.ToInt32(idimagenInsertar.Text));
                InsertarImagen.Parameters.AddWithValue("nombre", NombreImg.Text);
                InsertarImagen.Parameters.AddWithValue("imagen",abyte);
                conexion.Open();
                InsertarImagen.ExecuteNonQuery();
                MessageBox.Show("Imagen guardada");
                imagen.Image = null;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
     }

        private void ConsultaImagen_Click(object sender, EventArgs e)
        {
          
            NpgsqlConnection conexion = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=sinley143;Database=postgres");
            int id = int.Parse(idimagenConsultar.Text);
            NpgsqlCommand ConsultarImagen = new NpgsqlCommand("Select imagen from imagenes where idimagen='"+id+"'",conexion);
            conexion.Open();

            try
            {
                NpgsqlDataReader reader =ConsultarImagen.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    MemoryStream ms = new MemoryStream((byte[])reader["imagen"]);
                    Bitmap bm = new Bitmap(ms);
                    imagen.Image = bm;
                    //idimagenConsultar.Text = reader["nombre"].ToString(); leer sql en textbox
                    MessageBox.Show("Imagen cargada");

                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
   

        }
    }
}
