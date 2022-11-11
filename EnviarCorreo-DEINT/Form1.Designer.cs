namespace EnviarCorreo_DEINT
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContrasenna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDestinatario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAsunto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdjuntar = new System.Windows.Forms.Button();
            this.tbContenido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "De :";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(190, 21);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(182, 20);
            this.tbUsuario.TabIndex = 1;
            // 
            // tbContrasenna
            // 
            this.tbContrasenna.Location = new System.Drawing.Point(190, 60);
            this.tbContrasenna.Name = "tbContrasenna";
            this.tbContrasenna.Size = new System.Drawing.Size(182, 20);
            this.tbContrasenna.TabIndex = 3;
            this.tbContrasenna.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña :";
            // 
            // tbDestinatario
            // 
            this.tbDestinatario.Location = new System.Drawing.Point(190, 100);
            this.tbDestinatario.Name = "tbDestinatario";
            this.tbDestinatario.Size = new System.Drawing.Size(287, 20);
            this.tbDestinatario.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Para :";
            // 
            // tbAsunto
            // 
            this.tbAsunto.Location = new System.Drawing.Point(41, 230);
            this.tbAsunto.Name = "tbAsunto";
            this.tbAsunto.Size = new System.Drawing.Size(436, 20);
            this.tbAsunto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Asunto :";
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Location = new System.Drawing.Point(129, 145);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(122, 33);
            this.btnAdjuntar.TabIndex = 8;
            this.btnAdjuntar.Text = "Archivo Adjunto";
            this.btnAdjuntar.UseVisualStyleBackColor = true;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // tbContenido
            // 
            this.tbContenido.Location = new System.Drawing.Point(41, 289);
            this.tbContenido.Multiline = true;
            this.tbContenido.Name = "tbContenido";
            this.tbContenido.Size = new System.Drawing.Size(436, 178);
            this.tbContenido.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contenido :";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(427, 474);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 11;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 509);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.tbContenido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdjuntar);
            this.Controls.Add(this.tbAsunto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDestinatario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbContrasenna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContrasenna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDestinatario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAsunto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdjuntar;
        private System.Windows.Forms.TextBox tbContenido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

