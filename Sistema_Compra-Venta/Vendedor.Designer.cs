
namespace Sistema_Compra_Venta
{
    partial class Vendedor
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
            this.PDel = new System.Windows.Forms.Panel();
            this.txtENombreUsuario = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.pModificar = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.PCons = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCNombreProd = new System.Windows.Forms.TextBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.PAdd = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesgral = new System.Windows.Forms.TextBox();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PDel.SuspendLayout();
            this.pModificar.SuspendLayout();
            this.PCons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // PDel
            // 
            this.PDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PDel.Controls.Add(this.label4);
            this.PDel.Controls.Add(this.txtENombreUsuario);
            this.PDel.Controls.Add(this.btnDel);
            this.PDel.Location = new System.Drawing.Point(21, 282);
            this.PDel.Name = "PDel";
            this.PDel.Size = new System.Drawing.Size(420, 57);
            this.PDel.TabIndex = 30;
            // 
            // txtENombreUsuario
            // 
            this.txtENombreUsuario.Location = new System.Drawing.Point(19, 21);
            this.txtENombreUsuario.Name = "txtENombreUsuario";
            this.txtENombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtENombreUsuario.TabIndex = 1;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(274, 18);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(99, 23);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "Eliminar";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // pModificar
            // 
            this.pModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pModificar.Controls.Add(this.label2);
            this.pModificar.Controls.Add(this.textBox1);
            this.pModificar.Controls.Add(this.label12);
            this.pModificar.Controls.Add(this.textBox6);
            this.pModificar.Controls.Add(this.label16);
            this.pModificar.Controls.Add(this.txtID);
            this.pModificar.Controls.Add(this.btnUpdate);
            this.pModificar.Location = new System.Drawing.Point(21, 131);
            this.pModificar.Name = "pModificar";
            this.pModificar.Size = new System.Drawing.Size(420, 136);
            this.pModificar.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "ID Usuario";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(19, 29);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(253, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "ID Vendedor";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(246, 45);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 17;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(272, 87);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 35);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // PCons
            // 
            this.PCons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PCons.Controls.Add(this.label5);
            this.PCons.Controls.Add(this.dataGridView1);
            this.PCons.Controls.Add(this.txtCNombreProd);
            this.PCons.Controls.Add(this.btnConsulta);
            this.PCons.Location = new System.Drawing.Point(494, 9);
            this.PCons.Name = "PCons";
            this.PCons.Size = new System.Drawing.Size(420, 330);
            this.PCons.TabIndex = 29;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 254);
            this.dataGridView1.TabIndex = 10;
            // 
            // txtCNombreProd
            // 
            this.txtCNombreProd.Location = new System.Drawing.Point(19, 34);
            this.txtCNombreProd.Name = "txtCNombreProd";
            this.txtCNombreProd.Size = new System.Drawing.Size(100, 20);
            this.txtCNombreProd.TabIndex = 1;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(172, 8);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(110, 46);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Buscar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // PAdd
            // 
            this.PAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PAdd.Controls.Add(this.label3);
            this.PAdd.Controls.Add(this.label1);
            this.PAdd.Controls.Add(this.txtDesgral);
            this.PAdd.Controls.Add(this.txtNombreProd);
            this.PAdd.Controls.Add(this.btnAdd);
            this.PAdd.Location = new System.Drawing.Point(21, 6);
            this.PAdd.Name = "PAdd";
            this.PAdd.Size = new System.Drawing.Size(420, 108);
            this.PAdd.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Reputacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Usuario";
            // 
            // txtDesgral
            // 
            this.txtDesgral.Location = new System.Drawing.Point(19, 70);
            this.txtDesgral.Name = "txtDesgral";
            this.txtDesgral.Size = new System.Drawing.Size(100, 20);
            this.txtDesgral.TabIndex = 3;
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Location = new System.Drawing.Point(19, 21);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProd.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(274, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 46);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Reputacion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "ID Vendedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID Vendedor";
            // 
            // Vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 353);
            this.Controls.Add(this.PDel);
            this.Controls.Add(this.pModificar);
            this.Controls.Add(this.PCons);
            this.Controls.Add(this.PAdd);
            this.Name = "Vendedor";
            this.Text = "Vendedor";
            this.PDel.ResumeLayout(false);
            this.PDel.PerformLayout();
            this.pModificar.ResumeLayout(false);
            this.pModificar.PerformLayout();
            this.PCons.ResumeLayout(false);
            this.PCons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PAdd.ResumeLayout(false);
            this.PAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PDel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtENombreUsuario;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Panel pModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel PCons;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCNombreProd;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Panel PAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesgral;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
    }
}