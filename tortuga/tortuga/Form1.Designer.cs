namespace tortuga
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdGirarDerecha = new System.Windows.Forms.Button();
            this.cmdGirarIzq = new System.Windows.Forms.Button();
            this.cmdPArriba = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdGirarDerecha
            // 
            this.cmdGirarDerecha.Location = new System.Drawing.Point(326, 62);
            this.cmdGirarDerecha.Name = "cmdGirarDerecha";
            this.cmdGirarDerecha.Size = new System.Drawing.Size(82, 23);
            this.cmdGirarDerecha.TabIndex = 7;
            this.cmdGirarDerecha.Text = "Girar Derecha";
            this.cmdGirarDerecha.UseVisualStyleBackColor = true;
            this.cmdGirarDerecha.Click += new System.EventHandler(this.cmdGirarDerecha_Click);
            // 
            // cmdGirarIzq
            // 
            this.cmdGirarIzq.Location = new System.Drawing.Point(419, 62);
            this.cmdGirarIzq.Name = "cmdGirarIzq";
            this.cmdGirarIzq.Size = new System.Drawing.Size(84, 23);
            this.cmdGirarIzq.TabIndex = 6;
            this.cmdGirarIzq.Text = "Girar Izquierda";
            this.cmdGirarIzq.UseVisualStyleBackColor = true;
            this.cmdGirarIzq.Click += new System.EventHandler(this.cmdGirarIzq_Click);
            // 
            // cmdPArriba
            // 
            this.cmdPArriba.Location = new System.Drawing.Point(426, 91);
            this.cmdPArriba.Name = "cmdPArriba";
            this.cmdPArriba.Size = new System.Drawing.Size(75, 23);
            this.cmdPArriba.TabIndex = 4;
            this.cmdPArriba.Text = "Avanzar";
            this.cmdPArriba.UseVisualStyleBackColor = true;
            this.cmdPArriba.Click += new System.EventHandler(this.cmdPArriba_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 219);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(419, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Pluma Arriba";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(326, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Pluma Abajo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(326, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(82, 20);
            this.textBox2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 279);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdGirarDerecha);
            this.Controls.Add(this.cmdGirarIzq);
            this.Controls.Add(this.cmdPArriba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdGirarDerecha;
        private System.Windows.Forms.Button cmdGirarIzq;
        private System.Windows.Forms.Button cmdPArriba;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

