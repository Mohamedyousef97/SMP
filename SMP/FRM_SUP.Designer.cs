﻿
namespace SMP
{
    partial class FRM_SUP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SUP));
            this.pn_sup = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSup_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSup_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSup_Start_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Footer = new System.Windows.Forms.Panel();
            this.btn_renew = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.pn_sup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_sup
            // 
            this.pn_sup.Controls.Add(this.gridControl1);
            this.pn_sup.Controls.Add(this.Footer);
            this.pn_sup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_sup.Location = new System.Drawing.Point(0, 0);
            this.pn_sup.Name = "pn_sup";
            this.pn_sup.Size = new System.Drawing.Size(845, 563);
            this.pn_sup.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(SMP.TB_SUP);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(845, 497);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSup_Name,
            this.colSup_Phone,
            this.colSup_Start_Date});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "ادخل  اسم المورد تريد البحث عنه";
            this.gridView1.OptionsFind.ShowClearButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSup_Name
            // 
            this.colSup_Name.AppearanceCell.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSup_Name.AppearanceCell.Options.UseFont = true;
            this.colSup_Name.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colSup_Name.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSup_Name.AppearanceHeader.Options.UseBackColor = true;
            this.colSup_Name.AppearanceHeader.Options.UseFont = true;
            this.colSup_Name.Caption = "اسم الشركة";
            this.colSup_Name.FieldName = "Sup_Name";
            this.colSup_Name.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colSup_Name.ImageOptions.Image")));
            this.colSup_Name.Name = "colSup_Name";
            this.colSup_Name.Visible = true;
            this.colSup_Name.VisibleIndex = 0;
            this.colSup_Name.Width = 273;
            // 
            // colSup_Phone
            // 
            this.colSup_Phone.AppearanceCell.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSup_Phone.AppearanceCell.Options.UseFont = true;
            this.colSup_Phone.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colSup_Phone.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSup_Phone.AppearanceHeader.Options.UseBackColor = true;
            this.colSup_Phone.AppearanceHeader.Options.UseFont = true;
            this.colSup_Phone.Caption = "رقم التليفون";
            this.colSup_Phone.FieldName = "Sup_Phone";
            this.colSup_Phone.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colSup_Phone.ImageOptions.Image")));
            this.colSup_Phone.Name = "colSup_Phone";
            this.colSup_Phone.Visible = true;
            this.colSup_Phone.VisibleIndex = 1;
            this.colSup_Phone.Width = 235;
            // 
            // colSup_Start_Date
            // 
            this.colSup_Start_Date.AppearanceCell.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSup_Start_Date.AppearanceCell.Options.UseFont = true;
            this.colSup_Start_Date.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colSup_Start_Date.AppearanceHeader.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSup_Start_Date.AppearanceHeader.Options.UseBackColor = true;
            this.colSup_Start_Date.AppearanceHeader.Options.UseFont = true;
            this.colSup_Start_Date.Caption = "تاريخ البداية";
            this.colSup_Start_Date.FieldName = "Sup_Start_Date";
            this.colSup_Start_Date.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colSup_Start_Date.ImageOptions.Image")));
            this.colSup_Start_Date.Name = "colSup_Start_Date";
            this.colSup_Start_Date.Visible = true;
            this.colSup_Start_Date.VisibleIndex = 2;
            this.colSup_Start_Date.Width = 239;
            // 
            // Footer
            // 
            this.Footer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Footer.Controls.Add(this.btn_renew);
            this.Footer.Controls.Add(this.btn_delete);
            this.Footer.Controls.Add(this.btn_edit);
            this.Footer.Controls.Add(this.btn_add);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 497);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(845, 66);
            this.Footer.TabIndex = 2;
            // 
            // btn_renew
            // 
            this.btn_renew.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_renew.Appearance.Options.UseFont = true;
            this.btn_renew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_renew.ImageOptions.Image")));
            this.btn_renew.Location = new System.Drawing.Point(654, 9);
            this.btn_renew.Name = "btn_renew";
            this.btn_renew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_renew.Size = new System.Drawing.Size(111, 44);
            this.btn_renew.TabIndex = 1;
            this.btn_renew.Text = "تحديث";
            this.btn_renew.Click += new System.EventHandler(this.btn_renew_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.Location = new System.Drawing.Point(472, 9);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_delete.Size = new System.Drawing.Size(111, 44);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Appearance.Options.UseFont = true;
            this.btn_edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.ImageOptions.Image")));
            this.btn_edit.Location = new System.Drawing.Point(263, 9);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_edit.Size = new System.Drawing.Size(111, 44);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(71, 9);
            this.btn_add.Name = "btn_add";
            this.btn_add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add.Size = new System.Drawing.Size(111, 44);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "أضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // FRM_SUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 563);
            this.Controls.Add(this.pn_sup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_SUP";
            this.Text = "FRM_CAT";
            this.pn_sup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.Footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pn_sup;
        private System.Windows.Forms.Panel Footer;
        private DevExpress.XtraEditors.SimpleButton btn_renew;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colSup_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colSup_Phone;
        private DevExpress.XtraGrid.Columns.GridColumn colSup_Start_Date;
    }
}