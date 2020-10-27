namespace CNC
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
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectArchivo = new System.Windows.Forms.Button();
            this.txtResta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCoordenada = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog";
            // 
            // btnSelectArchivo
            // 
            this.btnSelectArchivo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSelectArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectArchivo.ForeColor = System.Drawing.Color.White;
            this.btnSelectArchivo.Location = new System.Drawing.Point(40, 55);
            this.btnSelectArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectArchivo.Name = "btnSelectArchivo";
            this.btnSelectArchivo.Size = new System.Drawing.Size(215, 74);
            this.btnSelectArchivo.TabIndex = 0;
            this.btnSelectArchivo.Text = "Seleccionar Archivo";
            this.btnSelectArchivo.UseVisualStyleBackColor = false;
            this.btnSelectArchivo.Click += new System.EventHandler(this.btnSelectArchivo_Click);
            // 
            // txtResta
            // 
            this.txtResta.Location = new System.Drawing.Point(519, 60);
            this.txtResta.Margin = new System.Windows.Forms.Padding(4);
            this.txtResta.Name = "txtResta";
            this.txtResta.Size = new System.Drawing.Size(132, 22);
            this.txtResta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número(negativo para restar)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coordenada(X, Y, Z)";
            // 
            // txtCoordenada
            // 
            this.txtCoordenada.Location = new System.Drawing.Point(519, 112);
            this.txtCoordenada.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoordenada.Name = "txtCoordenada";
            this.txtCoordenada.Size = new System.Drawing.Size(132, 22);
            this.txtCoordenada.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CNC.Properties.Resources.ejemplo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(447, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 353);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ejemplo del archivo de texto.";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 161);
            this.label4.TabIndex = 7;
            this.label4.Text = "Es importante que cada coordenada se especifique un número aunque sea 0 . Ejemplo" +
    " \" Y0 \"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCoordenada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResta);
            this.Controls.Add(this.btnSelectArchivo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Button btnSelectArchivo;
        private System.Windows.Forms.TextBox txtResta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCoordenada;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

