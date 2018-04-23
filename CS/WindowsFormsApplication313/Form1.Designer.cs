namespace WindowsFormsApplication313 {
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
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.customListBoxControl1 = new WindowsFormsApplication313.CustomListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customListBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(46, 34);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(120, 95);
            this.listBoxControl1.TabIndex = 0;
            // 
            // customListBoxControl1
            // 
            this.customListBoxControl1.Items.AddRange(new object[] {
            "dsfdsfdsfds",
            "dsfdsfdsfds",
            "dsfdsfdsfds",
            "dsfdsfdsfds",
            "dsfdsfdsfds",
            "dsfdsfdsfds",
            "dsfdsfdsfds",
            "dsfdsfdsfds",
            "dsfdsfdsfds",
            "dsfdsfdsfds",
            "dsfdsfdsfds",
            "dsfdsfdsfds",
            "dsfdsfdsfds",
            "dsfdsfdsfds",
            "dsfdsfdsfds",
            "dsfdsfdsfds"});
            this.customListBoxControl1.Location = new System.Drawing.Point(102, 162);
            this.customListBoxControl1.MultiColumn = true;
            this.customListBoxControl1.Name = "customListBoxControl1";
            this.customListBoxControl1.Size = new System.Drawing.Size(260, 160);
            this.customListBoxControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 388);
            this.Controls.Add(this.customListBoxControl1);
            this.Controls.Add(this.listBoxControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customListBoxControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private CustomListBoxControl customListBoxControl1;
    }
}

