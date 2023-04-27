namespace BaseZ.Views
{
    partial class OpenDatabase
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
            this.bdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bdPasswd = new System.Windows.Forms.TextBox();
            this.opendb = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SelectorDB = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // bdName
            // 
            this.bdName.Location = new System.Drawing.Point(230, 92);
            this.bdName.Name = "bdName";
            this.bdName.Size = new System.Drawing.Size(283, 20);
            this.bdName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de la base de datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // bdPasswd
            // 
            this.bdPasswd.Location = new System.Drawing.Point(230, 183);
            this.bdPasswd.Name = "bdPasswd";
            this.bdPasswd.Size = new System.Drawing.Size(283, 20);
            this.bdPasswd.TabIndex = 3;
            // 
            // opendb
            // 
            this.opendb.Location = new System.Drawing.Point(285, 268);
            this.opendb.Name = "opendb";
            this.opendb.Size = new System.Drawing.Size(169, 69);
            this.opendb.TabIndex = 4;
            this.opendb.Text = "Abrir Base de Datos";
            this.opendb.UseVisualStyleBackColor = true;
            this.opendb.Click += new System.EventHandler(this.DecryptFile);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Volver Menú";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SelectorDB
            // 
            this.SelectorDB.Location = new System.Drawing.Point(519, 89);
            this.SelectorDB.Name = "SelectorDB";
            this.SelectorDB.Size = new System.Drawing.Size(75, 23);
            this.SelectorDB.TabIndex = 7;
            this.SelectorDB.Text = "Seleccionar";
            this.SelectorDB.UseVisualStyleBackColor = true;
            this.SelectorDB.Click += new System.EventHandler(this.SelectorDB_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectorDB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.opendb);
            this.Controls.Add(this.bdPasswd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bdName);
            this.Name = "OpenDatabase";
            this.Text = "OpenDatabase";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpenDatabase_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bdPasswd;
        private System.Windows.Forms.Button opendb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SelectorDB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}