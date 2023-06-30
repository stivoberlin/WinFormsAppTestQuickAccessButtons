

namespace WinFormsAppTestQuickAccessButtons
{
    public partial class TestWindow : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public TestWindow()
        {
            InitializeComponent();
            if (DesignMode) return;

            // fill language list
            this.BarListItemLanguage.Strings.Clear();
            this.BarListItemLanguage.Strings.AddRange(new string[] { "en", "fr", "de" });
            this.BarListItemLanguage.Strings.Add("Edit...");

            // fill succursale list
            this.BarListItemSuccursale.Strings.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });




            // remove default skinning
            LookAndFeel.UseDefaultLookAndFeel = false;
        }




    }
}