Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository

Namespace SimpleHtmlEditExample
    Partial Public Class Main
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()

            Dim repositoryItem As New RepositoryItemHypertextLabel()
            gridControl1.RepositoryItems.Add(repositoryItem)
            gridControl1.DataSource = SimpleDataSource.GetTestData()
            gridView1.Columns(0).ColumnEdit = repositoryItem
        End Sub
    End Class
    Public Class SimpleDataSource
        Public Property HtmlText() As String
        Public Property PlainText() As String

        Private Sub New(ByVal htmlText As String, ByVal plainText As String)
            Me.HtmlText = htmlText
            Me.PlainText = plainText
        End Sub

        Public Shared Function GetTestData() As BindingList(Of SimpleDataSource)
            Dim testDataList As New BindingList(Of SimpleDataSource)()
            testDataList.Add(New SimpleDataSource("One <b>word</b> is bold and <href=https://www.devexpress.com/Support/Center/Example/Details/T398866>another two</href> are link", "text"))
            testDataList.Add(New SimpleDataSource("<s>Strikethrough</s> word, <i>three italic words</i>", "text"))
            testDataList.Add(New SimpleDataSource("First <href=https://www.devexpress.com/Support/Center/Example/Details/T398866>link</href>, second <href=https://www.devexpress.com/Support/Center/Example/Details/T398866>link</href>", "text"))

            Return testDataList
        End Function
    End Class
End Namespace
