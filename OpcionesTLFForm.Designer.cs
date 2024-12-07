namespace farmabit
{
    partial class OpcionesTLFForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnpago = new System.Windows.Forms.Button();
            this.btnrecarga = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnpago);
            this.panel1.Controls.Add(this.btnrecarga);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 323);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::farmabit.Properties.Resources.atras;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(529, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 50);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnpago
            // 
            this.btnpago.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnpago.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpago.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnpago.Location = new System.Drawing.Point(314, 82);
            this.btnpago.Name = "btnpago";
            this.btnpago.Size = new System.Drawing.Size(271, 180);
            this.btnpago.TabIndex = 29;
            this.btnpago.Text = "PAGO TELEFONO";
            this.btnpago.UseVisualStyleBackColor = false;
            this.btnpago.Click += new System.EventHandler(this.btnpago_Click);
            // 
            // btnrecarga
            // 
            this.btnrecarga.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnrecarga.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecarga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnrecarga.Location = new System.Drawing.Point(29, 82);
            this.btnrecarga.Name = "btnrecarga";
            this.btnrecarga.Size = new System.Drawing.Size(268, 180);
            this.btnrecarga.TabIndex = 28;
            this.btnrecarga.Text = "RECARGA";
            this.btnrecarga.UseVisualStyleBackColor = false;
            this.btnrecarga.Click += new System.EventHandler(this.btnrecarga_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Controls.Add(this.label17);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(791, 54);
            this.panel5.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(142, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(333, 41);
            this.label17.TabIndex = 11;
            this.label17.Text = "SELECCIONE SERVICIO";
            // 
            // OpcionesTLFForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 323);
            this.Controls.Add(this.panel1);
            this.Name = "OpcionesTLFForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpcionesTLFForm";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnpago;
        private System.Windows.Forms.Button btnrecarga;
        private System.Windows.Forms.Button button2;
    }
}