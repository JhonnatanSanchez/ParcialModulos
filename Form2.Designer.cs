
namespace ParcialModulos
{
    partial class Form2
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
            this.picAhorcado = new System.Windows.Forms.PictureBox();
            this.flPalabra = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPerder = new System.Windows.Forms.Label();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.flFichasJuego = new System.Windows.Forms.FlowLayoutPanel();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // picAhorcado
            // 
            this.picAhorcado.Location = new System.Drawing.Point(542, 182);
            this.picAhorcado.Name = "picAhorcado";
            this.picAhorcado.Size = new System.Drawing.Size(255, 287);
            this.picAhorcado.TabIndex = 4;
            this.picAhorcado.TabStop = false;
            // 
            // flPalabra
            // 
            this.flPalabra.Location = new System.Drawing.Point(189, 503);
            this.flPalabra.Name = "flPalabra";
            this.flPalabra.Size = new System.Drawing.Size(608, 88);
            this.flPalabra.TabIndex = 5;
            // 
            // lblPerder
            // 
            this.lblPerder.AutoSize = true;
            this.lblPerder.Location = new System.Drawing.Point(639, 154);
            this.lblPerder.Name = "lblPerder";
            this.lblPerder.Size = new System.Drawing.Size(73, 15);
            this.lblPerder.TabIndex = 6;
            this.lblPerder.Text = "AHORCADO";
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(12, 12);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(189, 37);
            this.btnComenzar.TabIndex = 7;
            this.btnComenzar.Text = "COMENZAR";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // flFichasJuego
            // 
            this.flFichasJuego.Location = new System.Drawing.Point(12, 182);
            this.flFichasJuego.Name = "flFichasJuego";
            this.flFichasJuego.Size = new System.Drawing.Size(500, 287);
            this.flFichasJuego.TabIndex = 8;
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(639, 20);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(158, 23);
            this.txtPalabra.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Escriba la palabra";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(47, 530);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 603);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.flFichasJuego);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.lblPerder);
            this.Controls.Add(this.flPalabra);
            this.Controls.Add(this.picAhorcado);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAhorcado;
        private System.Windows.Forms.FlowLayoutPanel flPalabra;
        private System.Windows.Forms.Label lblPerder;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.FlowLayoutPanel flFichasJuego;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
    }
}