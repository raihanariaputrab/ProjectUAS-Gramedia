﻿namespace ProjectUAS
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtIDBuku = new System.Windows.Forms.TextBox();
            this.txtNamaPembeli = new System.Windows.Forms.TextBox();
            this.txtIDPembeli = new System.Windows.Forms.TextBox();
            this.IDBuku = new System.Windows.Forms.Label();
            this.NamaPembeli = new System.Windows.Forms.Label();
            this.IDPembeli = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 46);
            this.button1.TabIndex = 41;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(444, 309);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(331, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(219, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtIDBuku
            // 
            this.txtIDBuku.Location = new System.Drawing.Point(297, 191);
            this.txtIDBuku.Name = "txtIDBuku";
            this.txtIDBuku.Size = new System.Drawing.Size(270, 20);
            this.txtIDBuku.TabIndex = 37;
            // 
            // txtNamaPembeli
            // 
            this.txtNamaPembeli.Location = new System.Drawing.Point(297, 152);
            this.txtNamaPembeli.Name = "txtNamaPembeli";
            this.txtNamaPembeli.Size = new System.Drawing.Size(270, 20);
            this.txtNamaPembeli.TabIndex = 36;
            // 
            // txtIDPembeli
            // 
            this.txtIDPembeli.Location = new System.Drawing.Point(297, 112);
            this.txtIDPembeli.Name = "txtIDPembeli";
            this.txtIDPembeli.Size = new System.Drawing.Size(270, 20);
            this.txtIDPembeli.TabIndex = 35;
            // 
            // IDBuku
            // 
            this.IDBuku.AutoSize = true;
            this.IDBuku.Location = new System.Drawing.Point(172, 194);
            this.IDBuku.Name = "IDBuku";
            this.IDBuku.Size = new System.Drawing.Size(39, 13);
            this.IDBuku.TabIndex = 34;
            this.IDBuku.Text = "Alamat";
            // 
            // NamaPembeli
            // 
            this.NamaPembeli.AutoSize = true;
            this.NamaPembeli.Location = new System.Drawing.Point(172, 152);
            this.NamaPembeli.Name = "NamaPembeli";
            this.NamaPembeli.Size = new System.Drawing.Size(39, 13);
            this.NamaPembeli.TabIndex = 33;
            this.NamaPembeli.Text = "No HP";
            // 
            // IDPembeli
            // 
            this.IDPembeli.AutoSize = true;
            this.IDPembeli.Location = new System.Drawing.Point(172, 112);
            this.IDPembeli.Name = "IDPembeli";
            this.IDPembeli.Size = new System.Drawing.Size(68, 13);
            this.IDPembeli.TabIndex = 32;
            this.IDPembeli.Text = "ID Karyawan";
            this.IDPembeli.Click += new System.EventHandler(this.IDPembeli_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtIDBuku);
            this.Controls.Add(this.txtNamaPembeli);
            this.Controls.Add(this.txtIDPembeli);
            this.Controls.Add(this.IDBuku);
            this.Controls.Add(this.NamaPembeli);
            this.Controls.Add(this.IDPembeli);
            this.Name = "Form5";
            this.Text = "Karyawan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtIDBuku;
        private System.Windows.Forms.TextBox txtNamaPembeli;
        private System.Windows.Forms.TextBox txtIDPembeli;
        private System.Windows.Forms.Label IDBuku;
        private System.Windows.Forms.Label NamaPembeli;
        private System.Windows.Forms.Label IDPembeli;
    }
}