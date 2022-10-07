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
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.miImport = new System.Windows.Forms.ToolStripMenuItem();
            this.miExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miOject = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.miDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.miClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.miFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOpenFromBinary = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAsBinary = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOpenFromText = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAsText = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tscbSortBy = new System.Windows.Forms.ToolStripComboBox();
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cmsMenuDataGrid.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.miOpen,
            this.miSave,
            this.toolStripMenuItem2,
            this.miImport,
            this.miExport,
            this.toolStripMenuItem1,
            this.miAbout,
            this.toolStripMenuItem3,
            this.miExit});
            this.miFile.Name = "miFile";
            resources.ApplyResources(this.miFile, "miFile");
            this.miFile.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // miOpen
            // 
            this.miOpen.Image = global::CourseWork.Properties.Resources.load_from_file;
            resources.ApplyResources(this.miOpen, "miOpen");
            this.miOpen.Name = "miOpen";
            // 
            // miSave
            // 
            this.miSave.Image = global::CourseWork.Properties.Resources.save_file;
            resources.ApplyResources(this.miSave, "miSave");
            this.miSave.Name = "miSave";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // miImport
            // 
            this.miImport.Image = global::CourseWork.Properties.Resources.load_from_file;
            resources.ApplyResources(this.miImport, "miImport");
            this.miImport.Name = "miImport";
            // 
            // miExport
            // 
            this.miExport.Image = global::CourseWork.Properties.Resources.save_in_file;
            resources.ApplyResources(this.miExport, "miExport");
            this.miExport.Name = "miExport";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // miAbout
            // 
            this.miAbout.Image = global::CourseWork.Properties.Resources.about;
            resources.ApplyResources(this.miAbout, "miAbout");
            this.miAbout.Name = "miAbout";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // miExit
            // 
            this.miExit.Image = global::CourseWork.Properties.Resources.exit;
            resources.ApplyResources(this.miExit, "miExit");
            this.miExit.Name = "miExit";
            // 
            // miOject
            // 
            this.miOject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAdd,
            this.miEdit,
            this.toolStripMenuItem4,
            this.miDelete,
            this.miClear,
            this.toolStripMenuItem5,
            this.miFilter});
            this.miOject.Name = "miOject";
            resources.ApplyResources(this.miOject, "miOject");
            // 
            // miAdd
            // 
            this.miAdd.Image = global::CourseWork.Properties.Resources.add;
            resources.ApplyResources(this.miAdd, "miAdd");
            this.miAdd.Name = "miAdd";
            // 
            // miEdit
            // 
            this.miEdit.Image = global::CourseWork.Properties.Resources.edit;
            resources.ApplyResources(this.miEdit, "miEdit");
            this.miEdit.Name = "miEdit";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            // 
            // miDelete
            // 
            this.miDelete.Image = global::CourseWork.Properties.Resources.minus;
            resources.ApplyResources(this.miDelete, "miDelete");
            this.miDelete.Name = "miDelete";
            // 
            // miClear
            // 
            this.miClear.Image = global::CourseWork.Properties.Resources.delete;
            resources.ApplyResources(this.miClear, "miClear");
            this.miClear.Name = "miClear";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            // 
            // miFilter
            // 
            this.miFilter.Image = global::CourseWork.Properties.Resources.filter;
            resources.ApplyResources(this.miFilter, "miFilter");
            this.miFilter.Name = "miFilter";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.toolStripSeparator1,
            this.btnDel,
            this.btnClear,
            this.toolStripSeparator2,
            this.btnOpenFromBinary,
            this.btnSaveAsBinary,
            this.toolStripSeparator3,
            this.btnOpenFromText,
            this.btnSaveAsText,
            this.toolStripSeparator4,
            this.btnFilter,
            this.toolStripLabel1,
            this.tscbSortBy,
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
            this.btnAdd.Image = global::CourseWork.Properties.Resources.add;
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = global::CourseWork.Properties.Resources.edit;
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Name = "btnEdit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // btnDel
            // 
            this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDel.Image = global::CourseWork.Properties.Resources.minus;
            resources.ApplyResources(this.btnDel, "btnDel");
            this.btnDel.Name = "btnDel";
            // 
            // btnClear
            // 
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClear.Image = global::CourseWork.Properties.Resources.delete;
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // btnOpenFromBinary
            // 
            this.btnOpenFromBinary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFromBinary.Image = global::CourseWork.Properties.Resources.add_file;
            resources.ApplyResources(this.btnOpenFromBinary, "btnOpenFromBinary");
            this.btnOpenFromBinary.Name = "btnOpenFromBinary";
            // 
            // btnSaveAsBinary
            // 
            this.btnSaveAsBinary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAsBinary.Image = global::CourseWork.Properties.Resources.save_file;
            resources.ApplyResources(this.btnSaveAsBinary, "btnSaveAsBinary");
            this.btnSaveAsBinary.Name = "btnSaveAsBinary";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // btnOpenFromText
            // 
            this.btnOpenFromText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFromText.Image = global::CourseWork.Properties.Resources.load_from_file;
            resources.ApplyResources(this.btnOpenFromText, "btnOpenFromText");
            this.btnOpenFromText.Name = "btnOpenFromText";
            // 
            // btnSaveAsText
            // 
            this.btnSaveAsText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAsText.Image = global::CourseWork.Properties.Resources.save_in_file;
            resources.ApplyResources(this.btnSaveAsText, "btnSaveAsText");
            this.btnSaveAsText.Name = "btnSaveAsText";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // btnFilter
            // 
            this.btnFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFilter.Image = global::CourseWork.Properties.Resources.filter;
            resources.ApplyResources(this.btnFilter, "btnFilter");
            this.btnFilter.Name = "btnFilter";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // tscbSortBy
            // 
            this.tscbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbSortBy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tscbSortBy.Items.AddRange(new object[] {
            resources.GetString("tscbSortBy.Items"),
            resources.GetString("tscbSortBy.Items1"),
            resources.GetString("tscbSortBy.Items2"),
            resources.GetString("tscbSortBy.Items3")});
            this.tscbSortBy.Name = "tscbSortBy";
            resources.ApplyResources(this.tscbSortBy, "tscbSortBy");
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            resources.ApplyResources(this.toolStripLabel2, "toolStripLabel2");
            // 
            // tstbSearch
            // 
            resources.ApplyResources(this.tstbSearch, "tstbSearch");
            this.tstbSearch.Name = "tstbSearch";
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = global::CourseWork.Properties.Resources.exit;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.cmsMenuDataGrid;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.mictAdd.Name = "mictAdd";
            resources.ApplyResources(this.mictAdd, "mictAdd");
            // 
            // mictEdit
            // 
            this.mictEdit.Name = "mictEdit";
            resources.ApplyResources(this.mictEdit, "mictEdit");
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
            // 
            // mictDelete
            // 
            this.mictDelete.Name = "mictDelete";
            resources.ApplyResources(this.mictDelete, "mictDelete");
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            resources.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
            // 
            // mictExit
            // 
            this.mictExit.Name = "mictExit";
            resources.ApplyResources(this.mictExit, "mictExit");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            resources.ApplyResources(this.toolStripStatusLabel3, "toolStripStatusLabel3");
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            resources.ApplyResources(this.toolStripStatusLabel4, "toolStripStatusLabel4");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip3);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cmsMenuDataGrid.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnOpenFromBinary;
        private ToolStripButton btnSaveAsBinary;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnOpenFromText;
        private ToolStripButton btnSaveAsText;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnFilter;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripLabel toolStripLabel2;
        private ToolStripButton btnExit;
        private ToolStripComboBox tscbSortBy;
        private ToolStripTextBox tstbSearch;
        private ToolStripMenuItem miOpen;
        private ToolStripMenuItem miSave;
        private ToolStripMenuItem miImport;
        private ToolStripMenuItem miExport;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem miAbout;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem miAdd;
        private ToolStripMenuItem miEdit;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem miDelete;
        private ToolStripMenuItem miClear;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem miFilter;
        private ToolStripMenuItem miExit;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ContextMenuStrip cmsMenuDataGrid;
        private ToolStripMenuItem mictAdd;
        private ToolStripMenuItem mictEdit;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripMenuItem mictDelete;
        private ToolStripSeparator toolStripMenuItem7;
        private ToolStripMenuItem mictExit;
    }
}