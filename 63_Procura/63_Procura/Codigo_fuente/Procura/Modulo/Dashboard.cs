namespace WINlogistica.Modulo
{
    public partial class Dashboard : DevExpress.XtraEditors.XtraUserControl
    {
        private static Dashboard _instance;
        public static Dashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Dashboard();
                return _instance;
            }
        }
        public Dashboard()
        {
            InitializeComponent();
        }
    }
}
