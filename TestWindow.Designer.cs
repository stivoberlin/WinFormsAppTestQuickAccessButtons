namespace Tools3.Presentation.Controls.WinForm.Tools3Windows
{
    partial class TestWindow
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestWindow));
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItemPrint = new DevExpress.XtraBars.BarSubItem();
            BarListItemLanguage = new DevExpress.XtraBars.BarListItem();
            BarListItemSuccursale = new DevExpress.XtraBars.BarListItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(components);
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemComboBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)behaviorManager1).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.AutoHideEmptyItems = true;
            ribbonControl1.CaptionBarItemLinks.Add(barButtonItemPrint);
            ribbonControl1.CaptionBarItemLinks.Add(BarListItemLanguage);
            ribbonControl1.CaptionBarItemLinks.Add(BarListItemSuccursale);
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItemPrint, BarListItemLanguage, BarListItemSuccursale, ribbonControl1.ExpandCollapseItem, ribbonControl1.SearchEditItem });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 7;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemComboBox1 });
            ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            ribbonControl1.ShowItemCaptionsInCaptionBar = true;
            ribbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            ribbonControl1.ShowToolbarCustomizeItem = false;
            ribbonControl1.Size = new Size(881, 32);
            ribbonControl1.Toolbar.ShowCustomizeItem = false;
            ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItemPrint
            // 
            barButtonItemPrint.Id = 2;
            barButtonItemPrint.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemPrint.ImageOptions.SvgImage");
            barButtonItemPrint.Name = "barButtonItemPrint";
            // 
            // BarListItemLanguage
            // 
            BarListItemLanguage.Caption = "fr";
            BarListItemLanguage.Id = 4;
            BarListItemLanguage.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("BarListItemLanguage.ImageOptions.SvgImage");
            BarListItemLanguage.Name = "BarListItemLanguage";
            BarListItemLanguage.Strings.AddRange(new object[] { "fr", "de" });
            // 
            // BarListItemSuccursale
            // 
            BarListItemSuccursale.Caption = "FR";
            BarListItemSuccursale.Id = 6;
            BarListItemSuccursale.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("BarListItemSuccursale.ImageOptions.SvgImage");
            BarListItemSuccursale.Name = "BarListItemSuccursale";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "ribbonPage1";
            ribbonPage1.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "ribbonPageGroup1";
            ribbonPageGroup1.Visible = false;
            // 
            // repositoryItemComboBox1
            // 
            repositoryItemComboBox1.AutoHeight = false;
            repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // TestWindow
            // 
            AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            Appearance.BackColor = Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 425);
            Controls.Add(ribbonControl1);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            Name = "TestWindow";
            Ribbon = ribbonControl1;
            RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            Text = "TestWindow";
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemComboBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)behaviorManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarSubItem barButtonItemPrint;
        private DevExpress.XtraBars.BarListItem BarListItemLanguage;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarListItem BarListItemSuccursale;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}