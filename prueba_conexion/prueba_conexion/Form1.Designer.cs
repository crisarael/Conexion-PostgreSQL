namespace prueba_conexion
{
    partial class Form1
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
            this.conectar = new System.Windows.Forms.Button();
            this.desconectar = new System.Windows.Forms.Button();
            this.datos = new System.Windows.Forms.DataGridView();
            this.consultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellidopaterno = new System.Windows.Forms.TextBox();
            this.apellidomaterno = new System.Windows.Forms.TextBox();
            this.fechanacimiento = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.sueldo = new System.Windows.Forms.TextBox();
            this.puesto = new System.Windows.Forms.TextBox();
            this.insertar = new System.Windows.Forms.Button();
            this.idempleado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnimagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).BeginInit();
            this.SuspendLayout();
            // 
            // conectar
            // 
            this.conectar.Location = new System.Drawing.Point(640, 10);
            this.conectar.Margin = new System.Windows.Forms.Padding(2);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(106, 51);
            this.conectar.TabIndex = 7;
            this.conectar.Text = "conectar";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // desconectar
            // 
            this.desconectar.Location = new System.Drawing.Point(523, 10);
            this.desconectar.Margin = new System.Windows.Forms.Padding(2);
            this.desconectar.Name = "desconectar";
            this.desconectar.Size = new System.Drawing.Size(114, 51);
            this.desconectar.TabIndex = 8;
            this.desconectar.Text = "Desconectar";
            this.desconectar.UseVisualStyleBackColor = true;
            this.desconectar.Click += new System.EventHandler(this.Desconectar_Click);
            // 
            // datos
            // 
            this.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos.Location = new System.Drawing.Point(346, 76);
            this.datos.Margin = new System.Windows.Forms.Padding(2);
            this.datos.Name = "datos";
            this.datos.RowHeadersWidth = 51;
            this.datos.RowTemplate.Height = 24;
            this.datos.Size = new System.Drawing.Size(518, 277);
            this.datos.TabIndex = 9;
            // 
            // consultar
            // 
            this.consultar.Location = new System.Drawing.Point(751, 10);
            this.consultar.Margin = new System.Windows.Forms.Padding(2);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(106, 51);
            this.consultar.TabIndex = 10;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Apellido Paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Apellido Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha De Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 279);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sueldo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 327);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Puesto";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(134, 40);
            this.nombre.Margin = new System.Windows.Forms.Padding(2);
            this.nombre.Multiline = true;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(166, 30);
            this.nombre.TabIndex = 24;
            // 
            // apellidopaterno
            // 
            this.apellidopaterno.Location = new System.Drawing.Point(134, 84);
            this.apellidopaterno.Margin = new System.Windows.Forms.Padding(2);
            this.apellidopaterno.Multiline = true;
            this.apellidopaterno.Name = "apellidopaterno";
            this.apellidopaterno.Size = new System.Drawing.Size(166, 30);
            this.apellidopaterno.TabIndex = 25;
            // 
            // apellidomaterno
            // 
            this.apellidomaterno.Location = new System.Drawing.Point(134, 134);
            this.apellidomaterno.Margin = new System.Windows.Forms.Padding(2);
            this.apellidomaterno.Multiline = true;
            this.apellidomaterno.Name = "apellidomaterno";
            this.apellidomaterno.Size = new System.Drawing.Size(166, 30);
            this.apellidomaterno.TabIndex = 26;
            // 
            // fechanacimiento
            // 
            this.fechanacimiento.Location = new System.Drawing.Point(134, 180);
            this.fechanacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.fechanacimiento.Multiline = true;
            this.fechanacimiento.Name = "fechanacimiento";
            this.fechanacimiento.Size = new System.Drawing.Size(166, 30);
            this.fechanacimiento.TabIndex = 27;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(134, 225);
            this.telefono.Margin = new System.Windows.Forms.Padding(2);
            this.telefono.Multiline = true;
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(166, 30);
            this.telefono.TabIndex = 28;
            // 
            // sueldo
            // 
            this.sueldo.Location = new System.Drawing.Point(134, 271);
            this.sueldo.Margin = new System.Windows.Forms.Padding(2);
            this.sueldo.Multiline = true;
            this.sueldo.Name = "sueldo";
            this.sueldo.Size = new System.Drawing.Size(166, 30);
            this.sueldo.TabIndex = 29;
            // 
            // puesto
            // 
            this.puesto.Location = new System.Drawing.Point(134, 320);
            this.puesto.Margin = new System.Windows.Forms.Padding(2);
            this.puesto.Multiline = true;
            this.puesto.Name = "puesto";
            this.puesto.Size = new System.Drawing.Size(166, 30);
            this.puesto.TabIndex = 30;
            // 
            // insertar
            // 
            this.insertar.Location = new System.Drawing.Point(398, 10);
            this.insertar.Margin = new System.Windows.Forms.Padding(2);
            this.insertar.Name = "insertar";
            this.insertar.Size = new System.Drawing.Size(114, 51);
            this.insertar.TabIndex = 33;
            this.insertar.Text = "Insertar";
            this.insertar.UseVisualStyleBackColor = true;
            this.insertar.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // idempleado
            // 
            this.idempleado.Location = new System.Drawing.Point(134, 6);
            this.idempleado.Margin = new System.Windows.Forms.Padding(2);
            this.idempleado.Multiline = true;
            this.idempleado.Name = "idempleado";
            this.idempleado.Size = new System.Drawing.Size(166, 30);
            this.idempleado.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Id Empleado";
            // 
            // btnimagen
            // 
            this.btnimagen.Location = new System.Drawing.Point(868, 172);
            this.btnimagen.Margin = new System.Windows.Forms.Padding(2);
            this.btnimagen.Name = "btnimagen";
            this.btnimagen.Size = new System.Drawing.Size(106, 51);
            this.btnimagen.TabIndex = 36;
            this.btnimagen.Text = "Ventana Imagen";
            this.btnimagen.UseVisualStyleBackColor = true;
            this.btnimagen.Click += new System.EventHandler(this.Btnimagen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 387);
            this.Controls.Add(this.btnimagen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.idempleado);
            this.Controls.Add(this.insertar);
            this.Controls.Add(this.puesto);
            this.Controls.Add(this.sueldo);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.fechanacimiento);
            this.Controls.Add(this.apellidomaterno);
            this.Controls.Add(this.apellidopaterno);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.desconectar);
            this.Controls.Add(this.conectar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Conexion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button conectar;
        private System.Windows.Forms.Button desconectar;
        private System.Windows.Forms.DataGridView datos;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellidopaterno;
        private System.Windows.Forms.TextBox apellidomaterno;
        private System.Windows.Forms.TextBox fechanacimiento;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox sueldo;
        private System.Windows.Forms.TextBox puesto;
        private System.Windows.Forms.Button insertar;
        private System.Windows.Forms.TextBox idempleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnimagen;
    }
}

