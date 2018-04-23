using DevExpress.Utils.Text;
using DevExpress.Utils.Text.Internal;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
 
namespace SimpleHtmlEditExample {
    [UserRepositoryItem("RegisterSimpleHtmlEdit")]
    public class RepositoryItemSimpleHtmlEdit : RepositoryItemTextEdit {
        public RepositoryItemSimpleHtmlEdit() { }
        static RepositoryItemSimpleHtmlEdit() { RegisterSimpleHtmlEdit(); }
 
        public const string CustomEditName = "SimpleHtmlEdit";
        public override string EditorTypeName { get { return CustomEditName; } }
        public static void RegisterSimpleHtmlEdit() {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName,
              typeof(SimpleHtmlEdit), typeof(RepositoryItemSimpleHtmlEdit),
              typeof(SimpleHtmlEditViewInfo), new TextEditPainter(), true, null));
        }
    }
 
    [ToolboxItem(true)]
    public class SimpleHtmlEdit : BaseEdit {
        protected Cursor PrevCursor { get; set; }
        public SimpleHtmlEdit() { }
 
        protected override void OnMouseMove(MouseEventArgs e) {
            base.OnMouseMove(e);
            TryUpdateCursorByHyperlink(e);
        }
 
        protected virtual void TryUpdateCursorByHyperlink(MouseEventArgs e) {
            if(ViewInfo.GetStringInfo() == null) return;
            StringBlock linkFound = ViewInfo.GetStringInfo().GetLinkByPoint(e.Location);
            if(linkFound != null) {
                if(PrevCursor == null)
                    PrevCursor = Cursor;
                Cursor = Cursors.Hand;                
            } else {
                if(PrevCursor != null)
                    Cursor = PrevCursor;
                PrevCursor = null;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e) {
            try {
                StringBlock linkFound = ViewInfo.GetStringInfo().GetLinkByPoint(e.Location);
                if(linkFound != null)
                    OpenUrlInDefaultBrowser(linkFound.Link);
 
            } catch(Exception exc) {
                MessageBox.Show("link is not valid");
            }
        }
 
        public void OpenUrlInDefaultBrowser(string url) {
            Process.Start(url);
        }
 
        static SimpleHtmlEdit() { RepositoryItemSimpleHtmlEdit.RegisterSimpleHtmlEdit(); }
        public override string EditorTypeName { get { return RepositoryItemSimpleHtmlEdit.CustomEditName; } }
        protected internal new SimpleHtmlEditViewInfo ViewInfo { get { return base.ViewInfo as SimpleHtmlEditViewInfo; } }
    }
 
    public class SimpleHtmlEditViewInfo : TextEditViewInfo {
        public SimpleHtmlEditViewInfo(RepositoryItem item) : base(item) { }
         
        public StringInfo GetStringInfo() {
            return StringInfo;
        }
 
        public override Cursor GetMouseCursor(Point point) {
            if(StringInfo.GetLinkByPoint(point) != null)
                return Cursors.Hand;
             
            return base.GetMouseCursor(point);
        }
 
        public override bool AllowHtmlString { get { return true; } }
        public override bool IsRequiredUpdateOnMouseMove { get { return true; } }
    }
}