using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace SimpleHtmlEditExample {
    public partial class Main : XtraForm {
        public Main() {
            InitializeComponent();

            RepositoryItemHypertextLabel repositoryItem = new RepositoryItemHypertextLabel();
            gridControl1.RepositoryItems.Add(repositoryItem);
            gridControl1.DataSource = SimpleDataSource.GetTestData();
            gridView1.Columns[0].ColumnEdit = repositoryItem;
        }
    }
    public class SimpleDataSource {
        public string HtmlText { get; set; }
        public string PlainText { get; set; }

        SimpleDataSource(string htmlText, string plainText) {
            HtmlText = htmlText;
            PlainText = plainText;
        }

        public static BindingList<SimpleDataSource> GetTestData() {
            BindingList<SimpleDataSource> testDataList = new BindingList<SimpleDataSource>();
            testDataList.Add(new SimpleDataSource("One <b>word</b> is bold and <href=https://www.devexpress.com/Support/Center/Example/Details/T398866>another two</href> are link", "text"));
            testDataList.Add(new SimpleDataSource("<s>Strikethrough</s> word, <i>three italic words</i>", "text"));
            testDataList.Add(new SimpleDataSource("First <href=https://www.devexpress.com/Support/Center/Example/Details/T398866>link</href>, second <href=https://www.devexpress.com/Support/Center/Example/Details/T398866>link</href>", "text"));

            return testDataList;
        }
    }
}
