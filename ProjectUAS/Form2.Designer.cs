﻿namespace ProjectUAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtIDBuku = new System.Windows.Forms.TextBox();
            this.txtNamaPembeli = new System.Windows.Forms.TextBox();
            this.txtIDPembeli = new System.Windows.Forms.TextBox();
            this.IDBuku = new System.Windows.Forms.Label();
            this.NamaPembeli = new System.Windows.Forms.Label();
            this.IDPembeli = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(395, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Insert";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(283, 355);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Create";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtIDBuku
            // 
            this.txtIDBuku.Location = new System.Drawing.Point(292, 243);
            this.txtIDBuku.Name = "txtIDBuku";
            this.txtIDBuku.Size = new System.Drawing.Size(270, 20);
            this.txtIDBuku.TabIndex = 23;
            // 
            // txtNamaPembeli
            // 
            this.txtNamaPembeli.Location = new System.Drawing.Point(292, 204);
            this.txtNamaPembeli.Name = "txtNamaPembeli";
            this.txtNamaPembeli.Size = new System.Drawing.Size(270, 20);
            this.txtNamaPembeli.TabIndex = 22;
            // 
            // txtIDPembeli
            // 
            this.txtIDPembeli.Location = new System.Drawing.Point(292, 164);
            this.txtIDPembeli.Name = "txtIDPembeli";
            this.txtIDPembeli.Size = new System.Drawing.Size(270, 20);
            this.txtIDPembeli.TabIndex = 21;
            this.txtIDPembeli.TextChanged += new System.EventHandler(this.txtIDPembeli_TextChanged);
            // 
            // IDBuku
            // 
            this.IDBuku.AutoSize = true;
            this.IDBuku.Location = new System.Drawing.Point(167, 246);
            this.IDBuku.Name = "IDBuku";
            this.IDBuku.Size = new System.Drawing.Size(46, 13);
            this.IDBuku.TabIndex = 17;
            this.IDBuku.Text = "ID Buku";
            // 
            // NamaPembeli
            // 
            this.NamaPembeli.AutoSize = true;
            this.NamaPembeli.Location = new System.Drawing.Point(167, 204);
            this.NamaPembeli.Name = "NamaPembeli";
            this.NamaPembeli.Size = new System.Drawing.Size(75, 13);
            this.NamaPembeli.TabIndex = 16;
            this.NamaPembeli.Text = "Nama Pembeli";
            // 
            // IDPembeli
            // 
            this.IDPembeli.AutoSize = true;
            this.IDPembeli.Location = new System.Drawing.Point(167, 164);
            this.IDPembeli.Name = "IDPembeli";
            this.IDPembeli.Size = new System.Drawing.Size(58, 13);
            this.IDPembeli.TabIndex = 15;
            this.IDPembeli.Text = "ID Pembeli";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(24, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 46);
            this.button1.TabIndex = 31;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Silahkan Isi Data Berikut";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtIDBuku);
            this.Controls.Add(this.txtNamaPembeli);
            this.Controls.Add(this.txtIDPembeli);
            this.Controls.Add(this.IDBuku);
            this.Controls.Add(this.NamaPembeli);
            this.Controls.Add(this.IDPembeli);
            this.Name = "Form2";
            this.Text = "Form Pembeli";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtIDBuku;
        private System.Windows.Forms.TextBox txtNamaPembeli;
        private System.Windows.Forms.TextBox txtIDPembeli;
        private System.Windows.Forms.Label IDBuku;
        private System.Windows.Forms.Label NamaPembeli;
        private System.Windows.Forms.Label IDPembeli;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}