using DevExpress.XtraSplashScreen;
using System.Windows.Forms;

namespace WINlogistica.Modulo
{
    public partial class UC_Vista_Dashboard : DevExpress.XtraEditors.XtraUserControl
    {
        private static UC_Vista_Dashboard _instance;
        public static UC_Vista_Dashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Vista_Dashboard();
                return _instance;
            }
        }

        public UC_Vista_Dashboard()
        {
            InitializeComponent();
        }

        private void Btn_Abrir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "xlsx files (*.xml)|*.xml";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
                    SplashScreenManager.Default.SetWaitFormDescription("Trayendo archivo dashboard...");

                    filePath = openFileDialog.FileName;

                    dashboardViewer.DashboardSource = filePath;

                    SplashScreenManager.CloseForm();
                }
            }

        }
    }
}
