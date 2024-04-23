using DevExpress.Utils.Serializing;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINlogistica.Modulo
{
    public partial class UC_ActualizaEmpresa : DevExpress.XtraEditors.XtraUserControl
    {
        //private SRsafnet.SAFnetEClient objWCF = new SRsafnet.SAFnetEClient();
        private Service.Data objDATA = new Service.Data();

        private byte[] imageData_I;
        private byte[] imageData_C;
        private byte[] imageData_M;

        private static UC_ActualizaEmpresa _instance;
        public static UC_ActualizaEmpresa Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_ActualizaEmpresa();
                return _instance;
            }
        }
        public UC_ActualizaEmpresa()
        {
            InitializeComponent();
            this.Inicio();
        }

        private void Inicio()
        {
            Model.Empresa_Login EL = new Model.Empresa_Login();
            if (MyStuff.UsaWCF == true)
            {
                //jesusEL = objWCF.Recupera_Empresa_Login(MyStuff.CodigoEmpresa);
            }
            else
            {
                EL = objDATA.Recupera_Empresa_Login(MyStuff.CodigoEmpresa);
            }
            this.Txt_RUC.EditValue = EL.CcodEmpresa;
            this.Txt_Empresa.EditValue = EL.VnomEmpresa;
            this.ImgLogo_Izquierdo.EditValue = EL.Pimg_LogoIzquierdo;
            this.ImgLogo_Centro.EditValue = EL.Pimg_LogoCentro;
            this.ImgLogo_Menu.EditValue = EL.Pimg_LogoMenu;
        }

        private void Img_LogoIzquierda_Click(object sender, EventArgs e)
        {

        }

        private void Btn_LogoIzquierdo_Click(object sender, EventArgs e)
        {
            if (imageDialog.ShowDialog() == DialogResult.OK)
            {
                string lastFileName = string.Empty;
                foreach (string fileName in imageDialog.FileNames)
                {
                    if (!IsFileAdded(fileName))
                    {
                        PathData p = new PathData();
                        p.Name = Path.GetFileName(fileName);
                        p.Path = fileName;
                    }
                    lastFileName = fileName;
                }

                this.ImgLogo_Izquierdo.LoadAsync(lastFileName);
            }
        }
        private bool IsFileAdded(string fileName)
        {
            return false;
            //return IsPathAdded(fileName, ViewData.Others.Files);
        }

        private void UpdateImageData_I(Image image)
        {
            using (var stream = new System.IO.MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageData_I = stream.ToArray();
            }
        }

        private void UpdateImageData_C(Image image)
        {
            using (var stream = new System.IO.MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageData_C = stream.ToArray();
            }
        }

        private void UpdateImageData_M(Image image)
        {
            using (var stream = new System.IO.MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageData_M = stream.ToArray();
            }
        }
        private void Btn_LogoCentro_Click(object sender, EventArgs e)
        {
            if (imageDialog.ShowDialog() == DialogResult.OK)
            {
                string lastFileName = string.Empty;
                foreach (string fileName in imageDialog.FileNames)
                {
                    if (!IsFileAdded(fileName))
                    {
                        PathData p = new PathData();
                        p.Name = Path.GetFileName(fileName);
                        p.Path = fileName;
                    }
                    lastFileName = fileName;
                }

                this.ImgLogo_Centro.LoadAsync(lastFileName);
            }
        }

        private void Btn_LogoMenu_Click(object sender, EventArgs e)
        {
            if (imageDialog.ShowDialog() == DialogResult.OK)
            {
                string lastFileName = string.Empty;
                foreach (string fileName in imageDialog.FileNames)
                {
                    if (!IsFileAdded(fileName))
                    {
                        PathData p = new PathData();
                        p.Name = Path.GetFileName(fileName);
                        p.Path = fileName;
                    }
                    lastFileName = fileName;
                }

                this.ImgLogo_Menu.LoadAsync(lastFileName);
            }
        }

        private void Btn_Acceso_Click(object sender, EventArgs e)
        {
            Image CapturedImage_I = this.ImgLogo_Izquierdo.Image;
            this.UpdateImageData_I(CapturedImage_I);

            Image CapturedImage_C = this.ImgLogo_Centro.Image;
            this.UpdateImageData_C(CapturedImage_C);

            Image CapturedImage_M = this.ImgLogo_Menu.Image;
            this.UpdateImageData_M(CapturedImage_M);

            Model.Empresa_Login EL = new Model.Empresa_Login();

            EL.CcodEmpresa = Convert.ToString(this.Txt_RUC.EditValue);
            EL.VnomEmpresa = Convert.ToString(this.Txt_Empresa.EditValue);
            EL.Pimg_LogoIzquierdo = imageData_I;
            EL.Pimg_LogoCentro = imageData_C;
            EL.Pimg_LogoMenu = imageData_M;

            bool result = false;
            if (MyStuff.UsaWCF == true)
            {
                //jesusresult = objWCF.Modifica_Empresa_Login(EL);
            }
            else
            {
                result = objDATA.Modifica_Empresa_Login(EL);
            }

            if (result)
                MessageBox.Show("OK: Los datos se actualizaron correctamente");
            else
                MessageBox.Show("ERROR: Los datos No se actualizaron correctamente");
        }

        private void Txt_RUC_EditValueChanged(object sender, EventArgs e)
        {

        }
    }

    public class PathData : IXtraSerializable
    {
        string nameCore;
        string pathCore;
        Image imageCore;

        [XtraSerializableProperty]
        public string Name { get { return nameCore; } set { nameCore = value; } }
        [XtraSerializableProperty]
        public string Path { get { return pathCore; } set { pathCore = value; } }
        public Image Image { get { return imageCore; } set { imageCore = value; } }

        #region IXtraSerializable Members

        void IXtraSerializable.OnEndDeserializing(string restoredVersion) { }
        void IXtraSerializable.OnEndSerializing() { }
        void IXtraSerializable.OnStartDeserializing(DevExpress.Utils.LayoutAllowEventArgs e) { }
        void IXtraSerializable.OnStartSerializing() { }

        #endregion
    }
}
