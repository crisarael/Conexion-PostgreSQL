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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.edad = new System.Windows.Forms.TextBox();
            this.alta = new System.Windows.Forms.Button();
            this.baja = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.conectar = new System.Windows.Forms.Button();
            this.desconectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(198, 57);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 22);
            this.nombre.TabIndex = 2;
            // 
            // edad
            // 
            this.edad.Location = new System.Drawing.Point(198, 101);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(100, 22);
            this.edad.TabIndex = 3;
            // 
            // alta
            // 
            this.alta.Location = new System.Drawing.Point(180, 165);
            this.alta.Name = "alta";
            this.alta.Size = new System.Drawing.Size(75, 23);
            this.alta.TabIndex = 4;
            this.alta.Text = "alta";
            this.alta.UseVisualStyleBackColor = true;
            // 
            // baja
            // 
            this.baja.Location = new System.Drawing.Point(297, 165);
            this.baja.Name = "baja";
            this.baja.Size = new System.Drawing.Size(75, 23);
            this.baja.TabIndex = 5;
            this.baja.Text = "baja";
            this.baja.UseVisualStyleBackColor = true;
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(243, 213);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 23);
            this.editar.TabIndex = 6;
            this.editar.Text = "editar";
            this.editar.UseVisualStyleBackColor = true;
            // 
            // conectar
            // 
            this.conectar.Location = new System.Drawing.Point(180, 282);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(75, 23);
            this.conectar.TabIndex = 7;
            this.conectar.Text = "conectar";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // desconectar
            // 
            this.desconectar.Location = new System.Drawing.Point(280, 282);
            this.desconectar.Name = "desconectar";
            this.desconectar.Size = new System.Drawing.Size(111, 23);
            this.desconectar.TabIndex = 8;
            this.desconectar.Text = "Desconectar";
            this.desconectar.UseVisualStyleBackColor = true;
            this.desconectar.Click += new System.EventHandler(this.Desconectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.desconectar);
            this.Controls.Add(this.conectar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.baja);
            this.Controls.Add(this.alta);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox edad;
        private System.Windows.Forms.Button alta;
        private System.Windows.Forms.Button baja;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button conectar;
        private System.Windows.Forms.Button desconectar;
    }
}

