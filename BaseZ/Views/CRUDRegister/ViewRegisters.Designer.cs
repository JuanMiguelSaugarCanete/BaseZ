namespace BaseZ.Views.CRUDRegister
{
    partial class ViewRegisters
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
            this.components = new System.ComponentModel.Container();
            this.MenuRegisters = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generatePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewRegisters = new System.Windows.Forms.DataGridView();
            this.contextMenuStripRegisters = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMS_DELETE = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_ADD = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_MODIFY = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_OPEN_URL = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_COPY_USERNAME = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_COPY_NAME = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_COPY_PASSWORD = new System.Windows.Forms.ToolStripMenuItem();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameRe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuRegisters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegisters)).BeginInit();
            this.contextMenuStripRegisters.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuRegisters
            // 
            this.MenuRegisters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.entryToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuRegisters.Location = new System.Drawing.Point(0, 0);
            this.MenuRegisters.Name = "MenuRegisters";
            this.MenuRegisters.Size = new System.Drawing.Size(800, 24);
            this.MenuRegisters.TabIndex = 0;
            this.MenuRegisters.Text = "menuStrip1";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRegisterToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // newRegisterToolStripMenuItem
            // 
            this.newRegisterToolStripMenuItem.Name = "newRegisterToolStripMenuItem";
            this.newRegisterToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.newRegisterToolStripMenuItem.Text = "New Register";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // entryToolStripMenuItem
            // 
            this.entryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyNameToolStripMenuItem,
            this.copyPasswordToolStripMenuItem});
            this.entryToolStripMenuItem.Name = "entryToolStripMenuItem";
            this.entryToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.entryToolStripMenuItem.Text = "Entry";
            // 
            // copyNameToolStripMenuItem
            // 
            this.copyNameToolStripMenuItem.Name = "copyNameToolStripMenuItem";
            this.copyNameToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.copyNameToolStripMenuItem.Text = "Copy Name";
            // 
            // copyPasswordToolStripMenuItem
            // 
            this.copyPasswordToolStripMenuItem.Name = "copyPasswordToolStripMenuItem";
            this.copyPasswordToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.copyPasswordToolStripMenuItem.Text = "Copy Password";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generatePasswordToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // generatePasswordToolStripMenuItem
            // 
            this.generatePasswordToolStripMenuItem.Name = "generatePasswordToolStripMenuItem";
            this.generatePasswordToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.generatePasswordToolStripMenuItem.Text = "Generate Password";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // dataGridViewRegisters
            // 
            this.dataGridViewRegisters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegisters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameRe,
            this.UserName,
            this.Email,
            this.URL,
            this.Password});
            this.dataGridViewRegisters.Location = new System.Drawing.Point(12, 27);
            this.dataGridViewRegisters.Name = "dataGridViewRegisters";
            this.dataGridViewRegisters.Size = new System.Drawing.Size(776, 411);
            this.dataGridViewRegisters.TabIndex = 1;
            this.dataGridViewRegisters.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewRegisters_CellMouseClick);
            // 
            // contextMenuStripRegisters
            // 
            this.contextMenuStripRegisters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_DELETE,
            this.CMS_ADD,
            this.CMS_MODIFY,
            this.CMS_OPEN_URL,
            this.copyToolStripMenuItem});
            this.contextMenuStripRegisters.Name = "contextMenuStripRegisters";
            this.contextMenuStripRegisters.Size = new System.Drawing.Size(128, 114);
            this.contextMenuStripRegisters.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripRegisters_ItemClicked);
            // 
            // CMS_DELETE
            // 
            this.CMS_DELETE.Name = "CMS_DELETE";
            this.CMS_DELETE.Size = new System.Drawing.Size(127, 22);
            this.CMS_DELETE.Text = "Delete";
            // 
            // CMS_ADD
            // 
            this.CMS_ADD.Name = "CMS_ADD";
            this.CMS_ADD.Size = new System.Drawing.Size(127, 22);
            this.CMS_ADD.Text = "Add";
            // 
            // CMS_MODIFY
            // 
            this.CMS_MODIFY.Name = "CMS_MODIFY";
            this.CMS_MODIFY.Size = new System.Drawing.Size(127, 22);
            this.CMS_MODIFY.Text = "Modify";
            // 
            // CMS_OPEN_URL
            // 
            this.CMS_OPEN_URL.Name = "CMS_OPEN_URL";
            this.CMS_OPEN_URL.Size = new System.Drawing.Size(127, 22);
            this.CMS_OPEN_URL.Text = "Open URL";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMS_COPY_USERNAME,
            this.CMS_COPY_NAME,
            this.CMS_COPY_PASSWORD});
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // CMS_COPY_USERNAME
            // 
            this.CMS_COPY_USERNAME.Name = "CMS_COPY_USERNAME";
            this.CMS_COPY_USERNAME.Size = new System.Drawing.Size(180, 22);
            this.CMS_COPY_USERNAME.Text = "Copy UserName";
            // 
            // CMS_COPY_NAME
            // 
            this.CMS_COPY_NAME.Name = "CMS_COPY_NAME";
            this.CMS_COPY_NAME.Size = new System.Drawing.Size(180, 22);
            this.CMS_COPY_NAME.Text = "Copy Name";
            // 
            // CMS_COPY_PASSWORD
            // 
            this.CMS_COPY_PASSWORD.Name = "CMS_COPY_PASSWORD";
            this.CMS_COPY_PASSWORD.Size = new System.Drawing.Size(180, 22);
            this.CMS_COPY_PASSWORD.Text = "Copy Password";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // NameRe
            // 
            this.NameRe.HeaderText = "Name";
            this.NameRe.Name = "NameRe";
            // 
            // UserName
            // 
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // URL
            // 
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // ViewRegisters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewRegisters);
            this.Controls.Add(this.MenuRegisters);
            this.MainMenuStrip = this.MenuRegisters;
            this.Name = "ViewRegisters";
            this.Text = "ViewRegisters";
            this.Load += new System.EventHandler(this.ViewRegisters_Load);
            this.MenuRegisters.ResumeLayout(false);
            this.MenuRegisters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegisters)).EndInit();
            this.contextMenuStripRegisters.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuRegisters;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatePasswordToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewRegisters;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRegisters;
        private System.Windows.Forms.ToolStripMenuItem CMS_DELETE;
        private System.Windows.Forms.ToolStripMenuItem CMS_ADD;
        private System.Windows.Forms.ToolStripMenuItem CMS_MODIFY;
        private System.Windows.Forms.ToolStripMenuItem CMS_OPEN_URL;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CMS_COPY_USERNAME;
        private System.Windows.Forms.ToolStripMenuItem CMS_COPY_NAME;
        private System.Windows.Forms.ToolStripMenuItem CMS_COPY_PASSWORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameRe;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
    }
}