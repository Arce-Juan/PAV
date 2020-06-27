namespace DelegadosYEventos
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
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_Evento = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(189, 47);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(103, 52);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "Dividir";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.Btn_1_Click);
            // 
            // btn_Evento
            // 
            this.btn_Evento.Location = new System.Drawing.Point(189, 153);
            this.btn_Evento.Name = "btn_Evento";
            this.btn_Evento.Size = new System.Drawing.Size(103, 52);
            this.btn_Evento.TabIndex = 1;
            this.btn_Evento.Text = "Evento";
            this.btn_Evento.UseVisualStyleBackColor = true;
            this.btn_Evento.Click += new System.EventHandler(this.Btn_Evento_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Evento Con Retorno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Evento);
            this.Controls.Add(this.btn_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_Evento;
        private System.Windows.Forms.Button button1;
    }
}

