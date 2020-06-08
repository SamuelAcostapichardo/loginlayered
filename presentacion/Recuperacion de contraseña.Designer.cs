namespace presentacion
{
    partial class Recuperacion_de_contraseña
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnrecovery = new System.Windows.Forms.Button();
            this.txtemailornombre = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 214);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel2.Controls.Add(this.lblresultado);
            this.panel2.Controls.Add(this.btnrecovery);
            this.panel2.Controls.Add(this.txtemailornombre);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(134, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 214);
            this.panel2.TabIndex = 1;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblresultado.Location = new System.Drawing.Point(6, 120);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(55, 13);
            this.lblresultado.TabIndex = 3;
            this.lblresultado.Text = "Resultado";
            // 
            // btnrecovery
            // 
            this.btnrecovery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrecovery.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnrecovery.Location = new System.Drawing.Point(222, 179);
            this.btnrecovery.Name = "btnrecovery";
            this.btnrecovery.Size = new System.Drawing.Size(75, 23);
            this.btnrecovery.TabIndex = 2;
            this.btnrecovery.Text = "Enter";
            this.btnrecovery.UseVisualStyleBackColor = false;
            this.btnrecovery.Click += new System.EventHandler(this.btnrecovery_Click);
            // 
            // txtemailornombre
            // 
            this.txtemailornombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtemailornombre.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemailornombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtemailornombre.Location = new System.Drawing.Point(6, 76);
            this.txtemailornombre.Multiline = true;
            this.txtemailornombre.Name = "txtemailornombre";
            this.txtemailornombre.Size = new System.Drawing.Size(291, 27);
            this.txtemailornombre.TabIndex = 0;
            this.txtemailornombre.Text = "Nombre o Email";
            this.txtemailornombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Recuperacion_de_contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 214);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Recuperacion_de_contraseña";
            this.Text = "Recuperacion_de_contraseña";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnrecovery;
        private System.Windows.Forms.TextBox txtemailornombre;
        private System.Windows.Forms.Label lblresultado;
    }
}