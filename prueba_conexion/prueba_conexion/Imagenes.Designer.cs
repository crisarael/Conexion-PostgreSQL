namespace prueba_conexion
{
    partial class Imagenes
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
            this.RutaImagen = new System.Windows.Forms.TextBox();
            this.btncargar = new System.Windows.Forms.Button();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ConsultaImagen = new System.Windows.Forms.Button();
            this.idimagenInsertar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idimagenConsultar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreImg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // RutaImagen
            // 
            this.RutaImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RutaImagen.Location = new System.Drawing.Point(525, 343);
            this.RutaImagen.Margin = new System.Windows.Forms.Padding(4);
            this.RutaImagen.Multiline = true;
            this.RutaImagen.Name = "RutaImagen";
            this.RutaImagen.Size = new System.Drawing.Size(509, 27);
            this.RutaImagen.TabIndex = 8;
            // 
            // btncargar
            // 
            this.btncargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btncargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btncargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncargar.Font = new System.Drawing.Font("Consolas", 10F);
            this.btncargar.ForeColor = System.Drawing.Color.Black;
            this.btncargar.Location = new System.Drawing.Point(565, 395);
            this.btncargar.Margin = new System.Windows.Forms.Padding(4);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(443, 28);
            this.btncargar.TabIndex = 7;
            this.btncargar.Text = "Seleccionar Imagen";
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.Btncargar_Click);
            // 
            // imagen
            // 
            this.imagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagen.Image = global::prueba_conexion.Properties.Resources.perfil;
            this.imagen.Location = new System.Drawing.Point(637, 38);
            this.imagen.Margin = new System.Windows.Forms.Padding(4);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(289, 285);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen.TabIndex = 10;
            this.imagen.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 10F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(79, 646);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(443, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Insertar Imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ConsultaImagen
            // 
            this.ConsultaImagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.ConsultaImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.ConsultaImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultaImagen.Font = new System.Drawing.Font("Consolas", 10F);
            this.ConsultaImagen.ForeColor = System.Drawing.Color.Black;
            this.ConsultaImagen.Location = new System.Drawing.Point(1137, 646);
            this.ConsultaImagen.Margin = new System.Windows.Forms.Padding(4);
            this.ConsultaImagen.Name = "ConsultaImagen";
            this.ConsultaImagen.Size = new System.Drawing.Size(443, 28);
            this.ConsultaImagen.TabIndex = 12;
            this.ConsultaImagen.Text = "s";
            this.ConsultaImagen.UseVisualStyleBackColor = true;
            this.ConsultaImagen.Click += new System.EventHandler(this.ConsultaImagen_Click);
            // 
            // idimagenInsertar
            // 
            this.idimagenInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idimagenInsertar.Location = new System.Drawing.Point(159, 551);
            this.idimagenInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.idimagenInsertar.Multiline = true;
            this.idimagenInsertar.Name = "idimagenInsertar";
            this.idimagenInsertar.Size = new System.Drawing.Size(313, 27);
            this.idimagenInsertar.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 554);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1133, 594);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID:";
            // 
            // idimagenConsultar
            // 
            this.idimagenConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idimagenConsultar.Location = new System.Drawing.Point(1167, 594);
            this.idimagenConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.idimagenConsultar.Multiline = true;
            this.idimagenConsultar.Name = "idimagenConsultar";
            this.idimagenConsultar.Size = new System.Drawing.Size(313, 27);
            this.idimagenConsultar.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 597);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "NOMBRE:";
            // 
            // NombreImg
            // 
            this.NombreImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreImg.Location = new System.Drawing.Point(159, 594);
            this.NombreImg.Margin = new System.Windows.Forms.Padding(4);
            this.NombreImg.Multiline = true;
            this.NombreImg.Name = "NombreImg";
            this.NombreImg.Size = new System.Drawing.Size(313, 27);
            this.NombreImg.TabIndex = 18;
            // 
            // Imagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 831);
            this.Controls.Add(this.NombreImg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idimagenConsultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idimagenInsertar);
            this.Controls.Add(this.ConsultaImagen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RutaImagen);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.imagen);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Imagenes";
            this.Text = "Imagenes";
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox RutaImagen;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ConsultaImagen;
        private System.Windows.Forms.TextBox idimagenInsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idimagenConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreImg;
    }
}