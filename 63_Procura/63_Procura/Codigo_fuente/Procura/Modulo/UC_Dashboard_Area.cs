using DevExpress.XtraSplashScreen;
using System.Windows.Forms;

namespace WINlogistica.Modulo
{
    public partial class UC_Dashboard_Area : DevExpress.XtraEditors.XtraUserControl
    {
        private static UC_Dashboard_Area _instance;
        public static UC_Dashboard_Area Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Dashboard_Area();
                return _instance;
            }
        }

        private Service.Data objDATA = new Service.Data();
        public UC_Dashboard_Area()
        {
            InitializeComponent();
            this.Inicio();
        }

        private void Inicio()
        {
            string strRuta = "";
            if (MyStuff.UsaWCF)
            {
                //jesus
            }
            else
                strRuta = objDATA.Recupera_ParametroLogistica_Codigo("60").vValParametroLogistica.TrimEnd();


            var strNomreDashboard = objDATA.Recupera_ParametroLogistica_Codigo("61").vValParametroLogistica;

            strRuta = strRuta.TrimEnd() + "/" + strNomreDashboard.TrimEnd();

            dashboardViewer.DashboardSource = @strRuta;

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

        private void ribbonControl1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
