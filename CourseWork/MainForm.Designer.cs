namespace CourseWork
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miOject = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.miDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.miClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tstbSearch = new System.Windows.Forms.ToolStripTextBox();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmsMenuDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mictAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mictEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.mictDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.mictExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnEdit2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_Producer = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.menuStrip3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cmsMenuDataGrid.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miOject});
            resources.ApplyResources(this.menuStrip3, "menuStrip3");
            this.menuStrip3.Name = "menuStrip3";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSave,
            this.toolStripMenuItem2,
            this.miExit});
            this.miFile.Name = "miFile";
            resources.ApplyResources(this.miFile, "miFile");
            // 
            // miSave
            // 
            this.miSave.Image = global::CourseWork.Properties.Resources.save_icon;
            resources.ApplyResources(this.miSave, "miSave");
            this.miSave.Name = "miSave";
            this.miSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // miExit
            // 
            this.miExit.Image = global::CourseWork.Properties.Resources.edit_icon;
            resources.ApplyResources(this.miExit, "miExit");
            this.miExit.Name = "miExit";
            this.miExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // miOject
            // 
            this.miOject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAdd,
            this.miEdit,
            this.toolStripMenuItem4,
            this.miDelete,
            this.miClear,
            this.toolStripMenuItem5});
            this.miOject.Name = "miOject";
            resources.ApplyResources(this.miOject, "miOject");
            // 
            // miAdd
            // 
            this.miAdd.Image = global::CourseWork.Properties.Resources.add_icon;
            resources.ApplyResources(this.miAdd, "miAdd");
            this.miAdd.Name = "miAdd";
            this.miAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // miEdit
            // 
            this.miEdit.Image = global::CourseWork.Properties.Resources.edit_icon;
            resources.ApplyResources(this.miEdit, "miEdit");
            this.miEdit.Name = "miEdit";
            this.miEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            // 
            // miDelete
            // 
            this.miDelete.Image = global::CourseWork.Properties.Resources.minus_icon;
            resources.ApplyResources(this.miDelete, "miDelete");
            this.miDelete.Name = "miDelete";
            this.miDelete.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // miClear
            // 
            this.miClear.Image = global::CourseWork.Properties.Resources.clear_icon;
            resources.ApplyResources(this.miClear, "miClear");
            this.miClear.Name = "miClear";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.toolStripSeparator1,
            this.btnDel,
            this.btnClear,
            this.toolStripSeparator3,
            this.toolStripSeparator5,
            this.toolStripLabel2,
            this.tstbSearch,
            this.btnExit});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = global::CourseWork.Properties.Resources.add_icon;
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = global::CourseWork.Properties.Resources.edit_icon;
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // btnDel
            // 
            this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDel.Image = global::CourseWork.Properties.Resources.minus_icon;
            resources.ApplyResources(this.btnDel, "btnDel");
            this.btnDel.Name = "btnDel";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClear
            // 
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClear.Image = global::CourseWork.Properties.Resources.clear_icon;
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Image = global::CourseWork.Properties.Resources.search_icon;
            this.toolStripLabel2.Name = "toolStripLabel2";
            resources.ApplyResources(this.toolStripLabel2, "toolStripLabel2");
            // 
            // tstbSearch
            // 
            resources.ApplyResources(this.tstbSearch, "tstbSearch");
            this.tstbSearch.Name = "tstbSearch";
            this.tstbSearch.TextChanged += new System.EventHandler(this.tstbSearch_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = global::CourseWork.Properties.Resources.exit_icon;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.cmsMenuDataGrid;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cmsMenuDataGrid
            // 
            this.cmsMenuDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mictAdd,
            this.mictEdit,
            this.toolStripMenuItem6,
            this.mictDelete,
            this.toolStripMenuItem7,
            this.mictExit});
            this.cmsMenuDataGrid.Name = "contextMenuStrip1";
            resources.ApplyResources(this.cmsMenuDataGrid, "cmsMenuDataGrid");
            // 
            // mictAdd
            // 
            this.mictAdd.Image = global::CourseWork.Properties.Resources.add_icon;
            resources.ApplyResources(this.mictAdd, "mictAdd");
            this.mictAdd.Name = "mictAdd";
            this.mictAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // mictEdit
            // 
            this.mictEdit.Image = global::CourseWork.Properties.Resources.edit_icon;
            resources.ApplyResources(this.mictEdit, "mictEdit");
            this.mictEdit.Name = "mictEdit";
            this.mictEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
            // 
            // mictDelete
            // 
            this.mictDelete.Image = global::CourseWork.Properties.Resources.minus_icon;
            resources.ApplyResources(this.mictDelete, "mictDelete");
            this.mictDelete.Name = "mictDelete";
            this.mictDelete.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            resources.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
            // 
            // mictExit
            // 
            this.mictExit.Image = global::CourseWork.Properties.Resources.exit_icon;
            resources.ApplyResources(this.mictExit, "mictExit");
            this.mictExit.Name = "mictExit";
            this.mictExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbWidth);
            this.groupBox1.Controls.Add(this.toolStrip2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_Price);
            this.groupBox1.Controls.Add(this.tb_Producer);
            this.groupBox1.Controls.Add(this.tb_Name);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEdit2,
            this.toolStripSeparator2,
            this.btnReload,
            this.toolStripSeparator4,
            this.btnSave});
            resources.ApplyResources(this.toolStrip2, "toolStrip2");
            this.toolStrip2.Name = "toolStrip2";
            // 
            // btnEdit2
            // 
            this.btnEdit2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit2.Image = global::CourseWork.Properties.Resources.edit_icon;
            resources.ApplyResources(this.btnEdit2, "btnEdit2");
            this.btnEdit2.Name = "btnEdit2";
            this.btnEdit2.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // btnReload
            // 
            this.btnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReload.Image = global::CourseWork.Properties.Resources.refresh_icon;
            resources.ApplyResources(this.btnReload, "btnReload");
            this.btnReload.Name = "btnReload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click_1);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::CourseWork.Properties.Resources.save_icon;
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tb_Price
            // 
            resources.ApplyResources(this.tb_Price, "tb_Price");
            this.tb_Price.Name = "tb_Price";
            // 
            // tb_Producer
            // 
            resources.ApplyResources(this.tb_Producer, "tb_Producer");
            this.tb_Producer.Name = "tb_Producer";
            // 
            // tb_Name
            // 
            resources.ApplyResources(this.tb_Name, "tb_Name");
            this.tb_Name.Name = "tb_Name";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tbWidth
            // 
            resources.ApplyResources(this.tbWidth, "tbWidth");
            this.tbWidth.Name = "tbWidth";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cmsMenuDataGrid.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip3;
        private ToolStripMenuItem miFile;
        private ToolStripMenuItem miOject;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdd;
        private DataGridView dataGridView1;
        private ToolStripButton btnEdit;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDel;
        private ToolStripButton btnClear;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripLabel toolStripLabel2;
        private ToolStripButton btnExit;
        private ToolStripTextBox tstbSearch;
        private ToolStripMenuItem miSave;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem miAdd;
        private ToolStripMenuItem miEdit;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem miDelete;
        private ToolStripMenuItem miClear;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem miExit;
        private ContextMenuStrip cmsMenuDataGrid;
        private ToolStripMenuItem mictAdd;
        private ToolStripMenuItem mictEdit;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripMenuItem mictDelete;
        private ToolStripSeparator toolStripMenuItem7;
        private ToolStripMenuItem mictExit;
        private GroupBox groupBox1;
        private TextBox tb_Name;
        private TextBox tb_Producer;
        private TextBox tb_Price;
        private Label label6;
        private Label label2;
        private Label label1;
        private ToolStrip toolStrip2;
        private ToolStripButton btnEdit2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnReload;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnSave;
        private Label label3;
        private TextBox tbWidth;
    }
}