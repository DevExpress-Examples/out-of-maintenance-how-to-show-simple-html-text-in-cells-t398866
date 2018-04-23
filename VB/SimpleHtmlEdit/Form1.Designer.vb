Namespace SimpleHtmlEditExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.Views = New System.Windows.Forms.TabControl()
			Me.tabPage1 = New System.Windows.Forms.TabPage()
			Me.tabPage2 = New System.Windows.Forms.TabPage()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.tabPage3 = New System.Windows.Forms.TabPage()
			Me.simpleHtmlEdit1 = New SimpleHtmlEditExample.SimpleHtmlEdit()
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Views.SuspendLayout()
			Me.tabPage1.SuspendLayout()
			Me.tabPage2.SuspendLayout()
			DirectCast(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tabPage3.SuspendLayout()
			DirectCast(Me.simpleHtmlEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(3, 3)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(669, 136)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default
			' 
			' Views
			' 
			Me.Views.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
			Me.Views.Controls.Add(Me.tabPage1)
			Me.Views.Controls.Add(Me.tabPage2)
			Me.Views.Controls.Add(Me.tabPage3)
			Me.Views.Dock = System.Windows.Forms.DockStyle.Fill
			Me.Views.HotTrack = True
			Me.Views.Location = New System.Drawing.Point(0, 0)
			Me.Views.Name = "Views"
			Me.Views.SelectedIndex = 0
			Me.Views.Size = New System.Drawing.Size(683, 168)
			Me.Views.TabIndex = 1
			' 
			' tabPage1
			' 
			Me.tabPage1.Controls.Add(Me.gridControl1)
			Me.tabPage1.Location = New System.Drawing.Point(4, 22)
			Me.tabPage1.Name = "tabPage1"
			Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
			Me.tabPage1.Size = New System.Drawing.Size(675, 142)
			Me.tabPage1.TabIndex = 0
			Me.tabPage1.Text = "GridControl"
			Me.tabPage1.UseVisualStyleBackColor = True
			' 
			' tabPage2
			' 
			Me.tabPage2.Controls.Add(Me.treeList1)
			Me.tabPage2.Location = New System.Drawing.Point(4, 22)
			Me.tabPage2.Name = "tabPage2"
			Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
			Me.tabPage2.Size = New System.Drawing.Size(675, 142)
			Me.tabPage2.TabIndex = 2
			Me.tabPage2.Text = "TreeList"
			Me.tabPage2.UseVisualStyleBackColor = True
			' 
			' treeList1
			' 
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(3, 3)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.Size = New System.Drawing.Size(669, 136)
			Me.treeList1.TabIndex = 0
			' 
			' tabPage3
			' 
			Me.tabPage3.Controls.Add(Me.simpleHtmlEdit1)
			Me.tabPage3.Location = New System.Drawing.Point(4, 22)
			Me.tabPage3.Name = "tabPage3"
			Me.tabPage3.Padding = New System.Windows.Forms.Padding(3)
			Me.tabPage3.Size = New System.Drawing.Size(675, 142)
			Me.tabPage3.TabIndex = 3
			Me.tabPage3.Text = "Standalone"
			Me.tabPage3.UseVisualStyleBackColor = True
			' 
			' simpleHtmlEdit1
			' 
			Me.simpleHtmlEdit1.Cursor = System.Windows.Forms.Cursors.Default
			Me.simpleHtmlEdit1.EditValue = "<b>I am standalone</b> <i>editor</i> <s>example</s>. <href=https://www.devexpress" & ".com/Support/Center/Example/Details/T398866>About me</href>"
			Me.simpleHtmlEdit1.Location = New System.Drawing.Point(7, 7)
			Me.simpleHtmlEdit1.Name = "simpleHtmlEdit1"
			Me.simpleHtmlEdit1.Size = New System.Drawing.Size(235, 20)
			Me.simpleHtmlEdit1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(683, 168)
			Me.Controls.Add(Me.Views)
			Me.Name = "Form1"
			Me.Text = "SimpleHtmlEditExample"
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.Views.ResumeLayout(False)
			Me.tabPage1.ResumeLayout(False)
			Me.tabPage2.ResumeLayout(False)
			DirectCast(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tabPage3.ResumeLayout(False)
			DirectCast(Me.simpleHtmlEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private Views As System.Windows.Forms.TabControl
		Private tabPage1 As System.Windows.Forms.TabPage
		Private tabPage2 As System.Windows.Forms.TabPage
		Private treeList1 As DevExpress.XtraTreeList.TreeList
		Private tabPage3 As System.Windows.Forms.TabPage
		Private simpleHtmlEdit1 As SimpleHtmlEdit
	End Class
End Namespace

