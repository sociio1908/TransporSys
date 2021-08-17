
namespace _911_RD.Administracion.Configuracion
{
    partial class FrmConfiguracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_salir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_empresa = new System.Windows.Forms.Button();
            this.btn_combustibles = new System.Windows.Forms.Button();
            this.btn_Tipos_Pago = new System.Windows.Forms.Button();
            this.p_container = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lbl_salir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 44);
            this.panel1.TabIndex = 0;
            // 
            // lbl_salir
            // 
            this.lbl_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_salir.AutoSize = true;
            this.lbl_salir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salir.Location = new System.Drawing.Point(1069, 8);
            this.lbl_salir.Name = "lbl_salir";
            this.lbl_salir.Size = new System.Drawing.Size(22, 22);
            this.lbl_salir.TabIndex = 1;
            this.lbl_salir.Text = "X";
            this.lbl_salir.Click += new System.EventHandler(this.lbl_salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONFIGURACIONES";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_empresa);
            this.panel2.Controls.Add(this.btn_combustibles);
            this.panel2.Controls.Add(this.btn_Tipos_Pago);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 721);
            this.panel2.TabIndex = 1;
            // 
            // btn_empresa
            // 
            this.btn_empresa.FlatAppearance.BorderSize = 0;
            this.btn_empresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empresa.Location = new System.Drawing.Point(3, 16);
            this.btn_empresa.Name = "btn_empresa";
            this.btn_empresa.Size = new System.Drawing.Size(146, 35);
            this.btn_empresa.TabIndex = 2;
            this.btn_empresa.Text = "EMPRESA";
            this.btn_empresa.UseVisualStyleBackColor = true;
            this.btn_empresa.Click += new System.EventHandler(this.btn_empresa_Click);
            // 
            // btn_combustibles
            // 
            this.btn_combustibles.FlatAppearance.BorderSize = 0;
            this.btn_combustibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_combustibles.Location = new System.Drawing.Point(6, 57);
            this.btn_combustibles.Name = "btn_combustibles";
            this.btn_combustibles.Size = new System.Drawing.Size(146, 35);
            this.btn_combustibles.TabIndex = 1;
            this.btn_combustibles.Text = "COMBUSTIBLES";
            this.btn_combustibles.UseVisualStyleBackColor = true;
            this.btn_combustibles.Click += new System.EventHandler(this.btn_combustibles_Click);
            // 
            // btn_Tipos_Pago
            // 
            this.btn_Tipos_Pago.FlatAppearance.BorderSize = 0;
            this.btn_Tipos_Pago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tipos_Pago.Location = new System.Drawing.Point(6, 94);
            this.btn_Tipos_Pago.Name = "btn_Tipos_Pago";
            this.btn_Tipos_Pago.Size = new System.Drawing.Size(146, 35);
            this.btn_Tipos_Pago.TabIndex = 0;
            this.btn_Tipos_Pago.Text = "TIPOS DE PAGO";
            this.btn_Tipos_Pago.UseVisualStyleBackColor = true;
            this.btn_Tipos_Pago.Click += new System.EventHandler(this.btn_Tipos_Pago_Click);
            // 
            // p_container
            // 
            this.p_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_container.Location = new System.Drawing.Point(155, 44);
            this.p_container.Name = "p_container";
            this.p_container.Size = new System.Drawing.Size(948, 721);
            this.p_container.TabIndex = 2;
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 765);
            this.Controls.Add(this.p_container);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConfiguracion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel p_container;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_salir;
        private System.Windows.Forms.Button btn_Tipos_Pago;
        private System.Windows.Forms.Button btn_empresa;
        private System.Windows.Forms.Button btn_combustibles;
    }
}