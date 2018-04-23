using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsFormsApplication313 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
    }
    [ToolboxItem(true)]
    public class CustomListBoxControl : ListBoxControl {
        public CustomListBoxControl()
            : base() {

        }
        protected override BaseStyleControlViewInfo CreateViewInfo() {
            return new CustomListBoxViewInfo(this);
        }
        protected override BaseControlPainter CreatePainter() {
            return new CustomBaseListBoxPainter();
        }
    }

    class CustomListBoxViewInfo : BaseListBoxViewInfo {
        public CustomListBoxViewInfo(BaseListBoxControl owner)
            : base(owner) {

        }

        protected override BaseListBoxItemPainter CreateItemPainter() {
            return new CustomBaseListBoxItemPainter();
        }
    }
    public class CustomBaseListBoxItemPainter : ListBoxItemPainter {
        public CustomBaseListBoxItemPainter()
            : base() {

        }

        public override int GetHorzPadding(ListBoxItemObjectInfoArgs e) {
            //change width between items
            int result = base.GetHorzPadding(e);
            return result + 20;
        }
        public override void DrawObject(DevExpress.Utils.Drawing.ObjectInfoArgs e) {
            base.DrawObject(e);
        }
        protected override Rectangle CalcItemTextRectangle(ListBoxItemObjectInfoArgs e) {
            //change the left margin here
            return Rectangle.Inflate(e.TextRect, -fHorzTextIndent - 5, 0);
        }
        public override int GetVertPadding(ListBoxItemObjectInfoArgs e) {
            int result = base.GetVertPadding(e);
            return result + 20;
        }
    }
    class CustomBaseListBoxPainter : BaseListBoxPainter {
        public CustomBaseListBoxPainter()
            : base() {

        }
        //avoid painting the control's border
        protected override void DrawBorder(ControlGraphicsInfoArgs info) {
            // base.DrawBorder(info);
        }
    }
}
