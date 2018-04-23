namespace SimpleHtmlEditExample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Views = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.simpleHtmlEdit1 = new SimpleHtmlEditExample.SimpleHtmlEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.Views.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simpleHtmlEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(669, 136);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // Views
            // 
            this.Views.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.Views.Controls.Add(this.tabPage1);
            this.Views.Controls.Add(this.tabPage2);
            this.Views.Controls.Add(this.tabPage3);
            this.Views.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Views.HotTrack = true;
            this.Views.Location = new System.Drawing.Point(0, 0);
            this.Views.Name = "Views";
            this.Views.SelectedIndex = 0;
            this.Views.Size = new System.Drawing.Size(683, 168);
            this.Views.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(675, 142);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GridControl";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.treeList1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(675, 142);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "TreeList";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeList1
            // 
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(3, 3);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(669, 136);
            this.treeList1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.simpleHtmlEdit1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(675, 142);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Standalone";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // simpleHtmlEdit1
            // 
            this.simpleHtmlEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.simpleHtmlEdit1.EditValue = "<b>I am standalone</b> <i>editor</i> <s>example</s>. <href=https://www.devexpress" +
    ".com/Support/Center/Example/Details/T398866>About me</href>";
            this.simpleHtmlEdit1.Location = new System.Drawing.Point(7, 7);
            this.simpleHtmlEdit1.Name = "simpleHtmlEdit1";
            this.simpleHtmlEdit1.Size = new System.Drawing.Size(235, 20);
            this.simpleHtmlEdit1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 168);
            this.Controls.Add(this.Views);
            this.Name = "Form1";
            this.Text = "SimpleHtmlEditExample";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.Views.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.simpleHtmlEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TabControl Views;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private System.Windows.Forms.TabPage tabPage3;
        private SimpleHtmlEdit simpleHtmlEdit1;
    }
}

