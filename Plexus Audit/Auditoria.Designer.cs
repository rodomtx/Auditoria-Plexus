namespace Plexus_Audit
{
    partial class Auditoria
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
            this.label2 = new System.Windows.Forms.Label();
            this.gs2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gs1 = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serie1 = new System.Windows.Forms.TextBox();
            this.serie6 = new System.Windows.Forms.TextBox();
            this.serie3 = new System.Windows.Forms.TextBox();
            this.serie5 = new System.Windows.Forms.TextBox();
            this.serie2 = new System.Windows.Forms.TextBox();
            this.serie4 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contenedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAuditar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(482, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Paso 1 - Selecciona el producto del embarque a auditar.";
            // 
            // gs2
            // 
            this.gs2.AutoSize = true;
            this.gs2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gs2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gs2.Location = new System.Drawing.Point(13, 13);
            this.gs2.Name = "gs2";
            this.gs2.Size = new System.Drawing.Size(155, 26);
            this.gs2.TabIndex = 6;
            this.gs2.TabStop = true;
            this.gs2.Text = "09-0286 - GS2";
            this.gs2.UseVisualStyleBackColor = true;
            this.gs2.CheckedChanged += new System.EventHandler(this.gs2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gs1);
            this.panel1.Controls.Add(this.gs2);
            this.panel1.Location = new System.Drawing.Point(16, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 92);
            this.panel1.TabIndex = 7;
            // 
            // gs1
            // 
            this.gs1.AutoSize = true;
            this.gs1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gs1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gs1.Location = new System.Drawing.Point(13, 54);
            this.gs1.Name = "gs1";
            this.gs1.Size = new System.Drawing.Size(155, 26);
            this.gs1.TabIndex = 7;
            this.gs1.TabStop = true;
            this.gs1.Text = "09-0269 - GS1";
            this.gs1.UseVisualStyleBackColor = true;
            this.gs1.CheckedChanged += new System.EventHandler(this.gs1_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.Location = new System.Drawing.Point(644, 255);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 57);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Paso 2 - Escanea los productos del empaque..";
            // 
            // serie1
            // 
            this.serie1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serie1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.serie1.Location = new System.Drawing.Point(13, 12);
            this.serie1.Name = "serie1";
            this.serie1.Size = new System.Drawing.Size(168, 29);
            this.serie1.TabIndex = 10;
            this.serie1.TextChanged += new System.EventHandler(this.serie1_TextChanged);
            // 
            // serie6
            // 
            this.serie6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serie6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.serie6.Location = new System.Drawing.Point(201, 82);
            this.serie6.Name = "serie6";
            this.serie6.Size = new System.Drawing.Size(168, 29);
            this.serie6.TabIndex = 15;
            this.serie6.TextChanged += new System.EventHandler(this.serie6_TextChanged);
            // 
            // serie3
            // 
            this.serie3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serie3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.serie3.Location = new System.Drawing.Point(13, 82);
            this.serie3.Name = "serie3";
            this.serie3.Size = new System.Drawing.Size(168, 29);
            this.serie3.TabIndex = 14;
            this.serie3.TextChanged += new System.EventHandler(this.serie3_TextChanged);
            // 
            // serie5
            // 
            this.serie5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serie5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.serie5.Location = new System.Drawing.Point(201, 47);
            this.serie5.Name = "serie5";
            this.serie5.Size = new System.Drawing.Size(168, 29);
            this.serie5.TabIndex = 13;
            this.serie5.TextChanged += new System.EventHandler(this.serie5_TextChanged);
            // 
            // serie2
            // 
            this.serie2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serie2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.serie2.Location = new System.Drawing.Point(13, 47);
            this.serie2.Name = "serie2";
            this.serie2.Size = new System.Drawing.Size(168, 29);
            this.serie2.TabIndex = 12;
            this.serie2.TextChanged += new System.EventHandler(this.serie2_TextChanged);
            // 
            // serie4
            // 
            this.serie4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serie4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.serie4.Location = new System.Drawing.Point(201, 12);
            this.serie4.Name = "serie4";
            this.serie4.Size = new System.Drawing.Size(168, 29);
            this.serie4.TabIndex = 11;
            this.serie4.TextChanged += new System.EventHandler(this.serie4_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.serie1);
            this.panel2.Controls.Add(this.serie6);
            this.panel2.Controls.Add(this.serie3);
            this.panel2.Controls.Add(this.serie5);
            this.panel2.Controls.Add(this.serie2);
            this.panel2.Controls.Add(this.serie4);
            this.panel2.Location = new System.Drawing.Point(16, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 134);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.contenedor);
            this.panel3.Location = new System.Drawing.Point(543, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 92);
            this.panel3.TabIndex = 11;
            // 
            // contenedor
            // 
            this.contenedor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contenedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.contenedor.Location = new System.Drawing.Point(24, 30);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(168, 29);
            this.contenedor.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(539, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Paso 3 - Capture numero de contenedor";
            // 
            // btnAuditar
            // 
            this.btnAuditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAuditar.Location = new System.Drawing.Point(520, 255);
            this.btnAuditar.Name = "btnAuditar";
            this.btnAuditar.Size = new System.Drawing.Size(118, 57);
            this.btnAuditar.TabIndex = 12;
            this.btnAuditar.Text = "Auditar";
            this.btnAuditar.UseVisualStyleBackColor = true;
            this.btnAuditar.Click += new System.EventHandler(this.btnAuditar_Click);
            // 
            // Auditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 417);
            this.ControlBox = false;
            this.Controls.Add(this.btnAuditar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Auditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plexus Audit";
            this.Load += new System.EventHandler(this.Auditoria_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton gs2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton gs1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serie1;
        private System.Windows.Forms.TextBox serie6;
        private System.Windows.Forms.TextBox serie3;
        private System.Windows.Forms.TextBox serie5;
        private System.Windows.Forms.TextBox serie2;
        private System.Windows.Forms.TextBox serie4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contenedor;
        private System.Windows.Forms.Button btnAuditar;
    }
}

