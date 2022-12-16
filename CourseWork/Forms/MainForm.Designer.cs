﻿namespace CourseWork
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miImport = new System.Windows.Forms.ToolStripMenuItem();
            this.miExport = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miOject = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.miClear = new System.Windows.Forms.ToolStripMenuItem();
            this.miFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.btnOpenFromText = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAsText = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tstbSearch = new System.Windows.Forms.ToolStripTextBox();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_Weight = new System.Windows.Forms.TextBox();
            this.tb_CountColors = new System.Windows.Forms.TextBox();
            this.tb_Model = new System.Windows.Forms.TextBox();
            this.tb_Company = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
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
            this.menuStrip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miOject});
            resources.ApplyResources(this.menuStrip3, "menuStrip3");
            this.menuStrip3.Name = "menuStrip3";
            // 
            // miFile
            // 
            this.miFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.miFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSave,
            this.miImport,
            this.miExport,
            this.miAbout,
            this.miExit});
            this.miFile.ForeColor = System.Drawing.Color.White;
            this.miFile.Name = "miFile";
            resources.ApplyResources(this.miFile, "miFile");
            // 
            // miSave
            // 
            this.miSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.miSave.ForeColor = System.Drawing.Color.White;
            this.miSave.Image = global::CourseWork.Properties.Resources.save_icon;
            resources.ApplyResources(this.miSave, "miSave");
            this.miSave.Name = "miSave";
            this.miSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // miImport
            // 
            this.miImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.miImport.ForeColor = System.Drawing.Color.White;
            this.miImport.Image = global::CourseWork.Properties.Resources.open_from_text_icon;
            resources.ApplyResources(this.miImport, "miImport");
            this.miImport.Name = "miImport";
            this.miImport.Click += new System.EventHandler(this.btnOpenFromText_Click);
            // 
            // miExport
            // 
            this.miExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.miExport.ForeColor = System.Drawing.Color.White;
            this.miExport.Image = global::CourseWork.Properties.Resources.save_file_icon;
            resources.ApplyResources(this.miExport, "miExport");
            this.miExport.Name = "miExport";
            this.miExport.Click += new System.EventHandler(this.btnSaveAsText_Click);
            // 
            // miAbout
            // 
            this.miAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.miAbout.ForeColor = System.Drawing.Color.White;
            this.miAbout.Image = global::CourseWork.Properties.Resources.about_icon;
            resources.ApplyResources(this.miAbout, "miAbout");
            this.miAbout.Name = "miAbout";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // miExit
            // 
            this.miExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.miExit.ForeColor = System.Drawing.Color.White;
            this.miExit.Image = global::CourseWork.Properties.Resources.exit_icon;
            resources.ApplyResources(this.miExit, "miExit");
            this.miExit.Name = "miExit";
            this.miExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // miOject
            // 
            this.miOject.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.miOject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.miOject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAdd,
            this.miEdit,
            this.miDelete,
            this.miClear,
            this.miFilter});
            this.miOject.ForeColor = System.Drawing.Color.White;
            this.miOject.Name = "miOject";
            resources.ApplyResources(this.miOject, "miOject");
            // 
            // miAdd
            // 
            this.miAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.miAdd.ForeColor = System.Drawing.Color.White;
            this.miAdd.Image = global::CourseWork.Properties.Resources.add_icon;
            resources.ApplyResources(this.miAdd, "miAdd");
            this.miAdd.Name = "miAdd";
            this.miAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // miEdit
            // 
            this.miEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.miEdit.ForeColor = System.Drawing.Color.White;
            this.miEdit.Image = global::CourseWork.Properties.Resources.edit_icon;
            resources.ApplyResources(this.miEdit, "miEdit");
            this.miEdit.Name = "miEdit";
            this.miEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // miDelete
            // 
            this.miDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.miDelete.ForeColor = System.Drawing.Color.White;
            this.miDelete.Image = global::CourseWork.Properties.Resources.minus_icon;
            resources.ApplyResources(this.miDelete, "miDelete");
            this.miDelete.Name = "miDelete";
            this.miDelete.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // miClear
            // 
            this.miClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.miClear.ForeColor = System.Drawing.Color.White;
            this.miClear.Image = global::CourseWork.Properties.Resources.clear_icon;
            resources.ApplyResources(this.miClear, "miClear");
            this.miClear.Name = "miClear";
            // 
            // miFilter
            // 
            this.miFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.miFilter.ForeColor = System.Drawing.Color.White;
            this.miFilter.Image = global::CourseWork.Properties.Resources.fither_icon;
            resources.ApplyResources(this.miFilter, "miFilter");
            this.miFilter.Name = "miFilter";
            this.miFilter.Click += new System.EventHandler(this.miFilter_Click);
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 5, 2);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDel,
            this.btnClear,
            this.btnOpenFromText,
            this.btnSaveAsText,
            this.toolStripLabel2,
            this.tstbSearch,
            this.btnBack});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::CourseWork.Properties.Resources.add_icon;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::CourseWork.Properties.Resources.edit_icon;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            resources.ApplyResources(this.btnDel, "btnDel");
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Image = global::CourseWork.Properties.Resources.minus_icon;
            this.btnDel.Name = "btnDel";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::CourseWork.Properties.Resources.clear_icon;
            this.btnClear.Name = "btnClear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOpenFromText
            // 
            resources.ApplyResources(this.btnOpenFromText, "btnOpenFromText");
            this.btnOpenFromText.ForeColor = System.Drawing.Color.White;
            this.btnOpenFromText.Image = global::CourseWork.Properties.Resources.open_from_text_icon;
            this.btnOpenFromText.Name = "btnOpenFromText";
            this.btnOpenFromText.Click += new System.EventHandler(this.btnSaveAsText_Click);
            // 
            // btnSaveAsText
            // 
            resources.ApplyResources(this.btnSaveAsText, "btnSaveAsText");
            this.btnSaveAsText.ForeColor = System.Drawing.Color.White;
            this.btnSaveAsText.Image = global::CourseWork.Properties.Resources.save_file_icon;
            this.btnSaveAsText.Name = "btnSaveAsText";
            this.btnSaveAsText.Click += new System.EventHandler(this.btnOpenFromText_Click);
            // 
            // toolStripLabel2
            // 
            resources.ApplyResources(this.toolStripLabel2, "toolStripLabel2");
            this.toolStripLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel2.Image = global::CourseWork.Properties.Resources.search_icon;
            this.toolStripLabel2.Name = "toolStripLabel2";
            // 
            // tstbSearch
            // 
            this.tstbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            resources.ApplyResources(this.tstbSearch, "tstbSearch");
            this.tstbSearch.ForeColor = System.Drawing.Color.White;
            this.tstbSearch.Name = "tstbSearch";
            this.tstbSearch.TextChanged += new System.EventHandler(this.tstbSearch_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::CourseWork.Properties.Resources.back_icon;
            this.btnBack.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(156)))), ((int)(((byte)(148)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.cmsMenuDataGrid;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
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
            this.groupBox1.Controls.Add(this.toolStrip2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.tb_Price);
            this.groupBox1.Controls.Add(this.tb_Weight);
            this.groupBox1.Controls.Add(this.tb_CountColors);
            this.groupBox1.Controls.Add(this.tb_Model);
            this.groupBox1.Controls.Add(this.tb_Company);
            this.groupBox1.Controls.Add(this.tb_Name);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.toolStrip2.AllowMerge = false;
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this.toolStrip2, "toolStrip2");
            this.toolStrip2.GripMargin = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEdit2,
            this.toolStripSeparator2,
            this.btnReload,
            this.toolStripSeparator4,
            this.btnSave});
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
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
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
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tb_Price
            // 
            this.tb_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.tb_Price.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tb_Price, "tb_Price");
            this.tb_Price.Name = "tb_Price";
            // 
            // tb_Weight
            // 
            this.tb_Weight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.tb_Weight.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tb_Weight, "tb_Weight");
            this.tb_Weight.Name = "tb_Weight";
            // 
            // tb_CountColors
            // 
            this.tb_CountColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.tb_CountColors.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tb_CountColors, "tb_CountColors");
            this.tb_CountColors.Name = "tb_CountColors";
            // 
            // tb_Model
            // 
            this.tb_Model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.tb_Model.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tb_Model, "tb_Model");
            this.tb_Model.Name = "tb_Model";
            // 
            // tb_Company
            // 
            this.tb_Company.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.tb_Company.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tb_Company, "tb_Company");
            this.tb_Company.Name = "tb_Company";
            // 
            // tb_Name
            // 
            this.tb_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.tb_Name.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tb_Name, "tb_Name");
            this.tb_Name.Name = "tb_Name";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip3);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
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
        private ToolStripButton btnDel;
        private ToolStripButton btnClear;
        private ToolStripButton btnOpenFromText;
        private ToolStripButton btnSaveAsText;
        private ToolStripLabel toolStripLabel2;
        private ToolStripTextBox tstbSearch;
        private ToolStripMenuItem miSave;
        private ToolStripMenuItem miImport;
        private ToolStripMenuItem miExport;
        private ToolStripMenuItem miAbout;
        private ToolStripMenuItem miAdd;
        private ToolStripMenuItem miEdit;
        private ToolStripMenuItem miDelete;
        private ToolStripMenuItem miClear;
        private ToolStripMenuItem miFilter;
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
        private TextBox tb_Company;
        private TextBox tb_Price;
        private TextBox tb_Weight;
        private TextBox tb_CountColors;
        private TextBox tb_Model;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ToolStrip toolStrip2;
        private ToolStripButton btnEdit2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnReload;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnSave;
        private ToolStripButton btnBack;
    }
}