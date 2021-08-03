
namespace lector
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
            this.leer = new System.Windows.Forms.Button();
            this.buscador = new System.Windows.Forms.Button();
            this.buscarTxt = new System.Windows.Forms.TextBox();
            this.detener = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leer
            // 
            this.leer.Location = new System.Drawing.Point(178, 69);
            this.leer.Name = "leer";
            this.leer.Size = new System.Drawing.Size(133, 39);
            this.leer.TabIndex = 0;
            this.leer.Text = "leer";
            this.leer.UseVisualStyleBackColor = true;
            this.leer.Click += new System.EventHandler(this.leer_Click);
            // 
            // buscador
            // 
            this.buscador.Location = new System.Drawing.Point(28, 76);
            this.buscador.Name = "buscador";
            this.buscador.Size = new System.Drawing.Size(133, 23);
            this.buscador.TabIndex = 1;
            this.buscador.Text = "buscar texto";
            this.buscador.UseVisualStyleBackColor = true;
            this.buscador.Click += new System.EventHandler(this.buscador_Click);
            // 
            // buscarTxt
            // 
            this.buscarTxt.BackColor = System.Drawing.SystemColors.Window;
            this.buscarTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.buscarTxt.Location = new System.Drawing.Point(28, 43);
            this.buscarTxt.Name = "buscarTxt";
            this.buscarTxt.Size = new System.Drawing.Size(296, 20);
            this.buscarTxt.TabIndex = 2;
            this.buscarTxt.Text = "Solo archivos (.txt)";
            this.buscarTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // detener
            // 
            this.detener.Location = new System.Drawing.Point(132, 125);
            this.detener.Name = "detener";
            this.detener.Size = new System.Drawing.Size(75, 23);
            this.detener.TabIndex = 3;
            this.detener.Text = "pausa";
            this.detener.UseVisualStyleBackColor = true;
            this.detener.Click += new System.EventHandler(this.detener_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(53, 154);
            this.txtArchivo.Multiline = true;
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(469, 284);
            this.txtArchivo.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Detener";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(53, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(365, 84);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "grabar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(447, 83);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "para";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 436);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.detener);
            this.Controls.Add(this.buscarTxt);
            this.Controls.Add(this.buscador);
            this.Controls.Add(this.leer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button leer;
        private System.Windows.Forms.Button buscador;
        private System.Windows.Forms.TextBox buscarTxt;
        private System.Windows.Forms.Button detener;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

