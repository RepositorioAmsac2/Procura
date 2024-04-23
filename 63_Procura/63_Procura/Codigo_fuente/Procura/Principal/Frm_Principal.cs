using Microsoft.Win32;
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Xml;
using System.Xml.Schema;

//using Infragistics.UltraChart.Resources.Appearance;
//using Infragistics.UltraChart.Shared.Styles;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinTree;
using Infragistics.Win.UltraWinToolbars;
using Microsoft.VisualBasic;

namespace WINlogistica
{
	public class Frm_Principal : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private Infragistics.Win.Misc.UltraButton btnLaunch;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinDock.UltraDockManager ultraDockManager1;
		private Infragistics.Win.UltraWinDock.UnpinnedTabArea _Form1UnpinnedTabAreaLeft;
		private Infragistics.Win.UltraWinDock.UnpinnedTabArea _Form1UnpinnedTabAreaRight;
		private Infragistics.Win.UltraWinDock.UnpinnedTabArea _Form1UnpinnedTabAreaTop;
		private Infragistics.Win.UltraWinDock.UnpinnedTabArea _Form1UnpinnedTabAreaBottom;
		private Infragistics.Win.UltraWinDock.AutoHideControl _Form1AutoHideControl;
		private Infragistics.Win.UltraWinDock.WindowDockingArea windowDockingArea2;
		private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow1;
		private Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager ultraTabbedMdiManager1;
		private Infragistics.Win.UltraWinToolbars.UltraToolbarsManager ultraToolbarsManager1;
		private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _Form1_Toolbars_Dock_Area_Left;
		private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _Form1_Toolbars_Dock_Area_Right;
		private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _Form1_Toolbars_Dock_Area_Top;
		private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _Form1_Toolbars_Dock_Area_Bottom;
		private System.Windows.Forms.ImageList imageListExplorerBar;
		private System.Windows.Forms.ImageList imageListTreeView;
        internal Infragistics.Win.UltraWinStatusBar.UltraStatusBar USB_Barra;
        private System.ComponentModel.IContainer components;

        #region "Variables Iniciales"
        //private SRmate.WCFmateEClient objService = new SRmate.WCFmateEClient();
        const int LargeImageIndexOpen = 0;
        const int LargeImageIndexNew = 1;
        const int LargeImageIndexClose = 2;
        const int LargeImageIndexSave = 3;
        const int LargeImageIndexSaveAs = 4;
        const int LargeImageIndexPaste = 5;
        const int LargeImageIndexFirstChart = 6;
        private DataSet Ds_cnfg_Opciones = new DataSet();
        DataTable Dt_Modulo = new DataTable();
        DataTable Dt_SubModulo = new DataTable();
        DataView Dv_SubModulo = new DataView();
        DataTable Dt_Grupo = new DataTable();
        DataView Dv_Grupo = new DataView();
        DataTable Dt_Opciones = new DataTable();
        DataView Dv_Opciones = new DataView();
        DataTable Dt_SubOpciones = new DataTable();
        DataView Dv_SubOpciones = new DataView();
        DataSet dsModulo = new DataSet();
        DataTable dtModulo = new DataTable();
        DataTable dtSubModulo = new DataTable();
        DataTable dtGrupo = new DataTable();
        DataTable dtOpcion = new DataTable();
        string[] datos = { "0", "0" };
        string strLogUsuario = "";
        string strCodModulo = "";
        internal ImageList ImageList1;
        private string strCodempresa = "";
        private string strCodEmpleado = "";
        internal ImageList ilLarge;
        DataTable menuTable = new DataTable("Menu");

        #endregion

        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();
        Service.Data sdl = new Service.Data();

        public Frm_Principal()
		{
			InitializeComponent();
		}

        public void ShowMe(string strCodUsuario, 
                            string cCodModulo, 
                            string cLogUsuario,
                            string cCodEmpresa, 
                            string strNomEmpresa, 
                            string strAñoProceso
                          )
        {
            strCodempresa = cCodEmpresa;
            strCodModulo = cCodModulo;
            strLogUsuario = cLogUsuario;

            Model.Usuario objMU = new Model.Usuario();
            Model.Empleado objME = new Model.Empleado();

            if (MyStuff.UsaWCF == true)
            {
                objMU = objWCF.Recupera_Usuario_Codigo(strCodempresa, strLogUsuario);
            }
            else
            {
                objMU = sdl.Recupera_Usuario_Codigo(strCodempresa, strLogUsuario);
            }

            strCodEmpleado = objMU.cCodEmpleado;

            if (MyStuff.UsaWCF == true)
            {
                objME = objWCF.Recupera_Empleado_Codigo(objMU.cCodEmpleado);
            }
            else
            {
                objME = sdl.Recupera_Empleado_Codigo(objMU.cCodEmpleado);
            }


            MyStuff.CodigoEmpleado = strCodEmpleado;
            MyStuff.CodigoCentroGestor = objME.CCodCentroGestor;
            MyStuff.CodigoCentroCosto = objME.CCodCentroCosto;
            MyStuff.NombreCentroCosto = objME.VNomCentroCosto;
            MyStuff.NombreCentroGestor = objME.VNomCentroGestor;
            MyStuff.AñoProceso = strAñoProceso;
            MyStuff.DigitoCentroGestor = objME.Idigito;
            MyStuff.CodigoCentroGestorSuperior = objME.CCodCentroGestor;

            Model.ParametroGestion MPG = new Model.ParametroGestion();

            if (MyStuff.UsaWCF == true)
            {
                //MPG = objWCF.Recupera_ParametroGestion_Codigo("60");
            }
            else
            {
                MPG = sdl.Recupera_ParametroGestion_Codigo("60");
            }

            if (MPG.vValParametroGestion.TrimEnd() == "SI")
            {
                MyStuff.CodigoCentroGestorSuperior = objME.CCodCentroGestorSuperior;
            }


            this.USB_Barra.Panels[0].Text = objMU.vDesEmpleado;
            this.USB_Barra.Panels[1].Text = strNomEmpresa;
            this.USB_Barra.Panels[2].Text = "Año:" + strAñoProceso;
            this.USB_Barra.Panels[3].Text = "CeCo:" + "(" + objME.CCodCentroCosto.TrimEnd() + ") " +
                                                      objME.VNomCentroCosto;
            this.USB_Barra.Panels[4].Text = "CeGe:" + "(" + objME.CCodCentroGestor.TrimEnd() + ") " +
                                                      objME.VNomCentroGestor;
            if (MyStuff.UsaWCF == true)
            {
                this.USB_Barra.Panels[5].Text = "Conexion: Remota";
            }
            else
            {
                this.USB_Barra.Panels[5].Text = "Conexion: Local";
            }



            CreaTablaMenu();
            CargarCabeceraRibbon();
            CargarBarraLateral();
            this.Show();
            //this.CargaFormularioInicial();
        }

        private void CargaFormularioInicial()
        {
            Service.Data sdl = new Service.Data();
            string strCodJefatura = sdl.Recupera_ParametroLogistica_Codigo("12").vValParametroLogistica.TrimEnd();
            string strCGJefatura = sdl.Recupera_ParametroLogistica_Codigo("10").vValParametroLogistica.TrimEnd();
            string strFormulario = "";

            if (MyStuff.CodigoCentroGestorSuperior.TrimEnd() == strCGJefatura)
            {
                if (MyStuff.CodigoEmpleado.TrimEnd() == strCodJefatura)
                {
                    strFormulario = "WINlogistica.Frm_EnlazaRequerimiento_OperadorLogistico";
                }
                else
                {
                    strFormulario = "WINlogistica.Frm_ControlItemPAC";
                }
            }
            else
            {
                strFormulario = "WINlogistica.Frm_AperturaProceso_Ceges";
            }
            


            string strParametro = "";

            //bool blnProcesaDatosPersonal = false;
            string strPrograma = strFormulario;

            //Esto tiene que ser una variable publica----- strCodTipoFormulacion_Publico = strParametro;

            if (strPrograma.Trim() != "")
            {
                try
                {

                    foreach (Form f in this.MdiChildren)
                    {
                        if (f.GetType().ToString() == strPrograma)
                        {
                            f.Show();
                            f.Focus();
                            return;
                        }
                    }
                    System.Type t = System.Type.GetType(strPrograma);
                    object[] parametros = { strParametro };
                    Form sample = ((Form)System.Activator.CreateInstance(t, true));
                    sample.MdiParent = this;

                    sample.Show();
                }
                catch
                {

                }
            }

        }

        private void samplestree_AfterSelect(object sender, Infragistics.Win.UltraWinTree.SelectEventArgs e)
        {
            //bool blnProcesaDatosPersonal = false;
            string strPrograma = e.NewSelections[0].Tag.ToString();
            if (strPrograma.Trim() != "")
            {
                //strPrograma = strPrograma;
                try
                {
                    foreach (Form f in this.MdiChildren)
                    {
                        if (f.GetType().ToString() == strPrograma)
                        {
                            f.Show();
                            f.Focus();
                            return;
                        }
                    }

                    System.Type t = System.Type.GetType(strPrograma.Replace("WinGaugeSamplesExplorerCS", "WinGaugeSamplesExplorerVB"), true);
                    System.Windows.Forms.Form sample = ((System.Windows.Forms.Form)System.Activator.CreateInstance(t, true));
                    sample.MdiParent = this;
                    sample.Show();
                }
                catch (Exception)
                {
                }
            }
        }   //samplestree_AfterSelect

        protected void ClickOnTools(System.Object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {


            string strCodigo = e.Tool.Key;

            string strFormulario = "";
            string strParametro = "";

            DataRow dr;
            dr = menuTable.Rows.Find(strCodigo);
            if (dr != null)
            {
                strFormulario = "WINlogistica." + Convert.ToString(dr[1]).Trim();
                //strFormulario = Convert.ToString(dr[1]).Trim();

                if (Convert.ToString(dr[2]).Trim() != "")
                {
                    strParametro = Convert.ToString(dr[2]).Trim();
                }
            }


            //bool blnProcesaDatosPersonal = false;
            string strPrograma = strFormulario;

            //Esto tiene que ser una variable publica----- strCodTipoFormulacion_Publico = strParametro;

            if (strPrograma.Trim() != "")
            {
                try
                {

                    foreach (Form  f in this.MdiChildren)
                    {
                        if (f.GetType().ToString() == strPrograma)
                        {
                            f.Show();
                            f.Focus();
                            return;
                        }
                    }

                    //Dim formulario As Form
                    //Dim tipoObjeto As Type = Type.GetType(strPrograma)
                    //Dim parametros() As Object = {strParametro}
                    //'fijate que al ser object, puedes meter cualquier objeto y no sólo cádenas como en el ejemplo
                    //Dim objeto As Object = Activator.CreateInstance(tipoObjeto, parametros)
                    //formulario = DirectCast(objeto, Form)
                    //formulario.Show()


                    System.Type t = System.Type.GetType(strPrograma);
                    object[] parametros = { strParametro };
                    Form sample = ((Form)System.Activator.CreateInstance(t, true));
                    sample.MdiParent = this;

                    sample.Show();


                }
                catch 
                {
                   
                }
            }
        }

        internal void OrdenarTablas()
        {

            Dt_Modulo = Ds_cnfg_Opciones.Tables[0];

            Dt_SubModulo = Ds_cnfg_Opciones.Tables[1];
            Dv_SubModulo = Dt_SubModulo.DefaultView;

            Dt_Grupo = Ds_cnfg_Opciones.Tables[2];
            Dv_Grupo = Dt_Grupo.DefaultView;

            Dt_Opciones = Ds_cnfg_Opciones.Tables[3];
            Dv_Opciones = Dt_Opciones.DefaultView;

            Dt_SubOpciones = Ds_cnfg_Opciones.Tables[4];
            Dv_SubOpciones = Dt_SubOpciones.DefaultView;

            //string strEsquema = "";

        }

        private void CargarBarraLateral()
        {
            UltraExplorerBarContainerControl container = new UltraExplorerBarContainerControl();
            this.ultraExplorerBar1.Controls.Add(container);
            UltraTree samplestree = new UltraTree();
            samplestree.Dock = DockStyle.Fill;

            samplestree.AfterSelect += new Infragistics.Win.UltraWinTree.AfterNodeSelectEventHandler(this.samplestree_AfterSelect);

            samplestree.NodeConnectorStyle = NodeConnectorStyle.None;
            samplestree.Override.ActiveNodeAppearance.BackColor = Color.DarkBlue;
            samplestree.Override.ActiveNodeAppearance.ForeColor = Color.Yellow;
            samplestree.Override.ActiveNodeAppearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.False;
            samplestree.Override.NodeAppearance.ImageBackgroundAlpha = Infragistics.Win.Alpha.UseAlphaLevel;

            container.Controls.Add(samplestree);

            if (MyStuff.UsaWCF == true)
            {
                Ds_cnfg_Opciones = objWCF.OpcionesMenu_Lateral(strCodempresa, strLogUsuario, strCodModulo);
            }
            else
            {
                Ds_cnfg_Opciones = sdl.OpcionesMenu_Lateral(strCodempresa, strLogUsuario, strCodModulo);
            }
            

            //Ds_cnfg_Opciones = objService.opcionesMenu_Lateral(strLogUsuario, strCodModulo);

            //DataRow dr_Modulo;
            //DataRowView dr_SubModulo;
            //DataRowView dr_Grupo;
            //DataRowView dr_Opciones;
            //DataRowView dr_SubOpciones;
            string strFiltroModulo = "";
            string strFiltroSubModulo = "";
            string strFiltroGrupo = "";
            string strFiltroOpciones = "";
            string strFiltroSubOpciones = "";

            OrdenarTablas();


            foreach (DataRow dr_Modulo in this.Dt_Modulo.Rows)
            {
                //
                // Modulos
                //

                strFiltroModulo = Convert.ToString(dr_Modulo["cCodModulo"]);
                this.Dv_SubModulo.RowFilter = "cCodModulo = " + strFiltroModulo;



                UltraExplorerBarGroup group = new UltraExplorerBarGroup();
                group.Text = Convert.ToString(dr_Modulo["vDesModulo"]);
                group.Key = strFiltroModulo;

                group.Settings.Style = GroupStyle.ControlContainer;
                group.Container = container;
                group.Tag = "";
                this.ultraExplorerBar1.Groups.Add(group);

                //bool blnExpandedProducts = true;


                foreach (DataRowView dr_SubModulo in this.Dv_SubModulo)
                {
                    strFiltroSubModulo = Convert.ToString(dr_SubModulo["cCodsubModulo"]);

                    UltraTreeNode productnode = new UltraTreeNode(strFiltroModulo.TrimEnd() + "_" + 
                                                                  strFiltroSubModulo.TrimEnd(), 
                                                                  Convert.ToString(dr_SubModulo["vDesSubModulo"] ).TrimEnd()
                                                                 );
                    productnode.LeftImages.Add(this.imageListTreeView.Images[1]);
                    productnode.Expanded = true;
                    productnode.Override.NodeAppearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.False;

                    productnode.Tag = "";
                    samplestree.Nodes.Add(productnode);

                    this.Dv_Grupo.RowFilter = "cCodModulo =" + strFiltroModulo + " And " + "cCodSubModulo=" + strFiltroSubModulo;

                    foreach (DataRowView dr_Grupo in this.Dv_Grupo)
                    {
                        //
                        // Grupos
                        //
                        strFiltroGrupo = Convert.ToString(dr_Grupo["cCodGrupo"]);

                        this.Dv_Opciones.RowFilter = "cCodModulo =" + strFiltroModulo + " And " + "cCodSubModulo=" + strFiltroSubModulo + " and " + "cCodGrupo=" + strFiltroGrupo;

                        UltraTreeNode categorynode = new UltraTreeNode(strFiltroModulo.TrimEnd() + "_" + 
                                                                       strFiltroSubModulo.TrimEnd() + "_" + 
                                                                       strFiltroGrupo.TrimEnd(), 
                                                                       Convert.ToString(dr_Grupo["vDesGrupo"]).TrimEnd()
                                                                       );
                        categorynode.Override.NodeAppearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.False;

                        categorynode.Tag = "";
                        productnode.Nodes.Add(categorynode);

                        foreach (DataRowView dr_Opciones in this.Dv_Opciones)
                        {
                            strFiltroOpciones = Convert.ToString(dr_Opciones["cCodOpcion"]);
                            UltraTreeNode samplenode = new UltraTreeNode(strFiltroModulo.TrimEnd() + "_" + 
                                                                         strFiltroSubModulo.TrimEnd() + "_" + 
                                                                         strFiltroGrupo.TrimEnd() + "_" + 
                                                                         strFiltroOpciones, Convert.ToString(dr_Opciones["vDesOpcion"]).TrimEnd()
                                                                         );

                            this.Dv_SubOpciones.RowFilter = "cCodModulo =" + strFiltroModulo + " And " + "cCodSubModulo=" + strFiltroSubModulo + " and " + "cCodGrupo=" + strFiltroGrupo + " and " + "cCodOpcion=" + strFiltroOpciones;

                            if (this.Dv_SubOpciones.Count > 0)
                            {
                                if (!(this.imageListTreeView.Images[1] == null))
                                {
                                    samplenode.LeftImages.Add(this.imageListTreeView.Images[1]);
                                }
                                samplenode.Tag = "";
                                categorynode.Nodes.Add(samplenode);

                                foreach (DataRowView  dr_SubOpciones in this.Dv_SubOpciones)
                                {
                                    strFiltroSubOpciones = Convert.ToString(dr_SubOpciones["cCodSubOpcion"]);
                                    UltraTreeNode samplenode1 = new UltraTreeNode(strFiltroModulo.TrimEnd() + "_" + 
                                                                                  strFiltroSubModulo.TrimEnd() + "_" + 
                                                                                  strFiltroGrupo.TrimEnd() + "_" + 
                                                                                  strFiltroOpciones.TrimEnd() + "_" + 
                                                                                  strFiltroSubOpciones.TrimEnd(), 
                                                                                  Convert.ToString(dr_SubOpciones["vDesSubOpcion"]).TrimEnd()
                                                                                  );

                                    if (!(this.imageListTreeView.Images[0] == null))
                                    {
                                        samplenode1.LeftImages.Add(this.imageListTreeView.Images[0]);
                                    }
                                    samplenode1.Tag = "WINLogistica." +  Convert.ToString(dr_SubOpciones["vDesFormulario"]);
                                    samplenode.Nodes.Add(samplenode1);
                                }
                            }
                            else
                            {
                                if (!(this.imageListTreeView.Images[0] == null))
                                {
                                    samplenode.LeftImages.Add(this.imageListTreeView.Images[0]);
                                }
                                samplenode.Tag = "WINLogistica." + Convert.ToString(dr_Opciones["vDesFormulario"]);
                                categorynode.Nodes.Add(samplenode);
                            }
                        }
                    }
                }
            }
        }
        private void CreaTablaMenu()
        {
            DataColumn menuCol = menuTable.Columns.Add("Codigo", Type.GetType("System.String"));
            menuCol.AllowDBNull = false;
            menuCol.Unique = true;
            menuTable.Columns.Add("Formulario", Type.GetType("System.String"));
            menuTable.Columns.Add("Parametro", Type.GetType("System.String"));
            menuTable.PrimaryKey = new DataColumn[] { menuTable.Columns["Codigo"] };
        }

        private void CargarCabeceraRibbon()
        {
            //
            // Imprimir la Cabecera
            //

            //create the new explorerbar group and assign the container to it
            //
            // Imprimir las opciones
            //


            if (MyStuff.UsaWCF == true)
            {
                Ds_cnfg_Opciones = objWCF.OpcionesMenu_Top(strCodempresa, strLogUsuario, strCodModulo);
            }
            else
            {
                Ds_cnfg_Opciones = sdl.OpcionesMenu_Top(strCodempresa, strLogUsuario, strCodModulo);
            }

            

            //Ds_cnfg_Opciones = objService.opcionesMenu_Top( strCodempresa, strLogUsuario, strCodModulo);

            //DataRow dr_Modulo;
            //DataRowView dr_SubModulo;
            //DataRowView dr_Grupo;
            //DataRowView dr_Opciones;
            //DataRowView dr_SubOpciones;
            string strFiltroModulo = "";
            string strFiltroSubModulo = "";
            string strFiltroGrupo = "";
            string strFiltroOpciones = "";
            string strFiltroSubOpciones = "";


            OrdenarTablas();


            foreach (DataRow dr_Modulo in this.Dt_Modulo.Rows)
            {
                strFiltroModulo = Convert.ToString(dr_Modulo["cCodModulo"]);
                this.Dv_SubModulo.RowFilter = "cCodModulo = " + strFiltroModulo;

                this.Text = Convert.ToString(dr_Modulo["vDesModulo"]);
                //LoadImage();
                this.ultraToolbarsManager1.BeginUpdate();
                this.ultraToolbarsManager1.ImageListLarge = this.ImageList1;
                this.ultraToolbarsManager1.ImageListSmall = this.ImageList1;

                foreach (DataRowView dr_SubModulo in this.Dv_SubModulo)
                {

                    //
                    // Sub - Modulos
                    //
                    strFiltroSubModulo = Convert.ToString(dr_SubModulo["cCodsubModulo"]);

                    RibbonTab tab = ultraToolbarsManager1.Ribbon.Tabs.Add(Convert.ToString(dr_SubModulo["cCodsubModulo"]));
                    tab.Caption = Convert.ToString(dr_SubModulo["vDesSubModulo"]);

                    this.Dv_Grupo.RowFilter = "cCodModulo =" + strFiltroModulo + " And " + 
                                              "cCodSubModulo=" + strFiltroSubModulo;

                    foreach (DataRowView dr_Grupo in this.Dv_Grupo)
                    {
                        //
                        // Grupos
                        //
                        strFiltroGrupo = Convert.ToString(dr_Grupo["cCodGrupo"]);

                        this.Dv_Opciones.RowFilter = "cCodModulo =" + strFiltroModulo + " And " +
                                                     "cCodSubModulo=" + strFiltroSubModulo + " and " +
                                                     "cCodGrupo=" + strFiltroGrupo;

                        RibbonGroup groupWithLargeTools = tab.Groups.Add(Convert.ToString(dr_Grupo["cCodGrupo"]));
                        groupWithLargeTools.Caption = Convert.ToString(dr_Grupo["vDesGrupo"]);
                        foreach (DataRowView  dr_Opciones in this.Dv_Opciones)
                        {
                            strFiltroOpciones = Convert.ToString(dr_Opciones["cCodOpcion"]);

                            this.Dv_SubOpciones.RowFilter = "cCodModulo =" + strFiltroModulo + " And " +
                                                            "cCodSubModulo=" + strFiltroSubModulo + " and " +
                                                            "cCodGrupo=" + strFiltroGrupo + " and " +
                                                            "cCodOpcion=" + strFiltroOpciones;

                            int intNumeroImagen = 0;
                            bool blnEsInicioGrupo = false;

                            if (this.Dv_SubOpciones.Count > 0)
                            {
                                PopupMenuTool boton = new PopupMenuTool(Convert.ToString(dr_Opciones["cCodOpcion"]));
                                boton.SharedProps.Caption = Convert.ToString(dr_Opciones["vDesOpcion"]);
                                intNumeroImagen = Convert.ToInt32(dr_Opciones["iNumeroImagen"]);
                                blnEsInicioGrupo = Convert.ToBoolean(dr_Opciones["bEsInicioGrupo"]);
                                if (!this.ultraToolbarsManager1.Tools.Exists(boton.Key))
                                {
                                    this.ultraToolbarsManager1.Tools.Add(boton);
                                    ToolBase tool = groupWithLargeTools.Tools.AddTool(Convert.ToString(dr_Opciones["cCodOpcion"]));
                                    tool.InstanceProps.PreferredSizeOnRibbon = RibbonToolSize.Large;
                                    tool.InstanceProps.IsFirstInGroup = blnEsInicioGrupo;
                                    tool.SharedProps.AppearancesLarge.Appearance.Image = ilLarge.Images[intNumeroImagen];
                                }

                                foreach (DataRowView dr_SubOpciones in this.Dv_SubOpciones)
                                {
                                    strFiltroSubOpciones = Convert.ToString(dr_SubOpciones["cCodSubOpcion"]);
                                    StateButtonTool subboton = new StateButtonTool(strFiltroSubOpciones);
                                    intNumeroImagen = Convert.ToInt32(dr_SubOpciones["iNumeroImagen"]);
                                    blnEsInicioGrupo = Convert.ToBoolean(dr_SubOpciones["bEsInicioGrupo"]);
                                    subboton.SharedProps.Caption = Convert.ToString(dr_SubOpciones["vDesSubOpcion"]);

                                    if (!this.ultraToolbarsManager1.Tools.Exists(subboton.Key))
                                    {
                                        this.ultraToolbarsManager1.Tools.Add(subboton);
                                        ToolBase tool = boton.Tools.AddTool(strFiltroSubOpciones);
                                        //'tool.Tag = CStr(dr_SubOpciones("vDesFormulario")).Trim
                                        AñadeRegistroMenu(Convert.ToString(dr_SubOpciones["cCodsubOpcion"]), Convert.ToString(dr_SubOpciones["vDesFormulario"]).Trim());
                                        tool.InstanceProps.PreferredSizeOnRibbon = RibbonToolSize.Default;
                                        tool.InstanceProps.IsFirstInGroup = blnEsInicioGrupo;

                                        tool.SharedProps.AppearancesSmall.Appearance.Image = ilLarge.Images[intNumeroImagen];
                                        //tool.ToolClick += new /* TODO: Comprobar el tipo de delegado */ EventHandler(ClickOnTools);
                                        tool.ToolClick += new ToolClickEventHandler(ClickOnTools);

                                        //AddHandler tool.ToolClick, AddressOf ClickOnTools;
                                    }
                                }
                            }
                            else
                            {
                                ButtonTool boton = new ButtonTool(Convert.ToString(dr_Opciones["cCodOpcion"]));
                                boton.SharedProps.Caption = Convert.ToString(dr_Opciones["vDesOpcion"]);
                                intNumeroImagen = Convert.ToInt32(dr_Opciones["iNumeroImagen"]);
                                blnEsInicioGrupo = Convert.ToBoolean(dr_Opciones["bEsInicioGrupo"]);
                                if (!this.ultraToolbarsManager1.Tools.Exists(boton.Key))
                                {
                                    this.ultraToolbarsManager1.Tools.Add(boton);
                                    ToolBase tool = groupWithLargeTools.Tools.AddTool(Convert.ToString(dr_Opciones["cCodOpcion"]));
                                    //'tool.Tag = "Formulacion." & CStr(dr_Opciones("vDesFormulario")).Trim
                                    //'tool.Tag = CStr(dr_Opciones("vDesFormulario")).Trim
                                    AñadeRegistroMenu(Convert.ToString(dr_Opciones["cCodOpcion"]), Convert.ToString(dr_Opciones["vDesFormulario"]).Trim());
                                    tool.InstanceProps.PreferredSizeOnRibbon = RibbonToolSize.Large;
                                    tool.InstanceProps.IsFirstInGroup = blnEsInicioGrupo;
                                    if ( intNumeroImagen < ilLarge.Images.Count)
                                    {
                                        tool.SharedProps.AppearancesLarge.Appearance.Image = ilLarge.Images[intNumeroImagen];
                                    }
                                    
                                    //tool.ToolClick += new /* TODO: Comprobar el tipo de delegado */ EventHandler(ClickOnTools);
                                    tool.ToolClick += new ToolClickEventHandler(ClickOnTools);
                                }
                            }
                        }
                    }
                }
            }
            this.ultraToolbarsManager1.EndUpdate();
        }

        private void AñadeRegistroMenu(string strCodigo, string strFormulario)
        {
            int TestPos = 0;
            string strParametro = "";
            int intLongitud = strFormulario.Trim().Length;
            TestPos = strFormulario.IndexOf("@"); //  InStr(strFormulario, "@");
            if (TestPos > 0)
            {
                strParametro = strFormulario.Trim().Substring(TestPos, intLongitud - TestPos);
                strFormulario = strFormulario.Trim().Substring(0, TestPos - 1);
            }
            DataRow contactoRow;
            contactoRow = menuTable.NewRow();
            contactoRow["Codigo"] = strCodigo;
            contactoRow["Formulario"] = strFormulario;
            contactoRow["Parametro"] = strParametro;
            menuTable.Rows.Add(contactoRow);

        }

        protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
	
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            Infragistics.Win.UltraWinDock.DockAreaPane dockAreaPane1 = new Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedLeft, new System.Guid("d9f71001-af1e-4005-b53c-a329bd7cabe6"));
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane1 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("f8a7d748-8373-4d71-8f5e-8ae70ffc69cd"), new System.Guid("00000000-0000-0000-0000-000000000000"), -1, new System.Guid("d9f71001-af1e-4005-b53c-a329bd7cabe6"), -1);
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.UltraToolbar ultraToolbar1 = new Infragistics.Win.UltraWinToolbars.UltraToolbar("MainMenu");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool3 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("File");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool1 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Exit");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool2 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Exit");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool4 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("Window");
            Infragistics.Win.UltraWinToolbars.MdiWindowListTool mdiWindowListTool1 = new Infragistics.Win.UltraWinToolbars.MdiWindowListTool("WindowList");
            Infragistics.Win.UltraWinToolbars.MdiWindowListTool mdiWindowListTool2 = new Infragistics.Win.UltraWinToolbars.MdiWindowListTool("WindowList");
            Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel1 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
            Infragistics.Win.Appearance Appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel2 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
            Infragistics.Win.Appearance Appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel3 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
            Infragistics.Win.Appearance Appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel4 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel5 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel6 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.imageListExplorerBar = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLaunch = new Infragistics.Win.Misc.UltraButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ultraDockManager1 = new Infragistics.Win.UltraWinDock.UltraDockManager(this.components);
            this._Form1UnpinnedTabAreaLeft = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
            this._Form1UnpinnedTabAreaRight = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
            this._Form1UnpinnedTabAreaTop = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
            this._Form1UnpinnedTabAreaBottom = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
            this._Form1AutoHideControl = new Infragistics.Win.UltraWinDock.AutoHideControl();
            this.dockableWindow1 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.ultraTabbedMdiManager1 = new Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager(this.components);
            this._Form1_Toolbars_Dock_Area_Left = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.ultraToolbarsManager1 = new Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(this.components);
            this._Form1_Toolbars_Dock_Area_Right = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._Form1_Toolbars_Dock_Area_Top = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._Form1_Toolbars_Dock_Area_Bottom = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.imageListTreeView = new System.Windows.Forms.ImageList(this.components);
            this.USB_Barra = new Infragistics.Win.UltraWinStatusBar.UltraStatusBar();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ilLarge = new System.Windows.Forms.ImageList(this.components);
            this.windowDockingArea2 = new Infragistics.Win.UltraWinDock.WindowDockingArea();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDockManager1)).BeginInit();
            this._Form1AutoHideControl.SuspendLayout();
            this.dockableWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraToolbarsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraExplorerBar1
            // 
            this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ultraExplorerBar1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraExplorerBar1.ImageListLarge = this.imageListExplorerBar;
            this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 25);
            this.ultraExplorerBar1.Name = "ultraExplorerBar1";
            this.ultraExplorerBar1.Size = new System.Drawing.Size(321, 327);
            this.ultraExplorerBar1.Style = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarStyle.OutlookNavigationPane;
            this.ultraExplorerBar1.TabIndex = 5;
            this.ultraExplorerBar1.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            // 
            // imageListExplorerBar
            // 
            this.imageListExplorerBar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListExplorerBar.ImageStream")));
            this.imageListExplorerBar.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListExplorerBar.Images.SetKeyName(0, "");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLaunch);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // btnLaunch
            // 
            this.btnLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunch.Location = new System.Drawing.Point(0, 0);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(75, 23);
            this.btnLaunch.TabIndex = 2;
            this.btnLaunch.Text = "Launch Sample";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "richTextBox1";
            // 
            // ultraDockManager1
            // 
            dockAreaPane1.ChildPaneStyle = Infragistics.Win.UltraWinDock.ChildPaneStyle.TabGroup;
            dockableControlPane1.Control = this.ultraExplorerBar1;
            dockableControlPane1.FlyoutSize = new System.Drawing.Size(321, -1);
            dockableControlPane1.OriginalControlBounds = new System.Drawing.Rectangle(0, 0, 236, 414);
            dockableControlPane1.Pinned = false;
            dockableControlPane1.Settings.AllowClose = Infragistics.Win.DefaultableBoolean.False;
            appearance1.FontData.SizeInPoints = 7.75F;
            dockableControlPane1.Settings.CaptionAppearance = appearance1;
            dockableControlPane1.Size = new System.Drawing.Size(100, 100);
            dockableControlPane1.Text = "Módulos";
            dockAreaPane1.Panes.AddRange(new Infragistics.Win.UltraWinDock.DockablePaneBase[] {
            dockableControlPane1});
            dockAreaPane1.Settings.AllowClose = Infragistics.Win.DefaultableBoolean.True;
            dockAreaPane1.Size = new System.Drawing.Size(321, 352);
            this.ultraDockManager1.DockAreas.AddRange(new Infragistics.Win.UltraWinDock.DockAreaPane[] {
            dockAreaPane1});
            this.ultraDockManager1.HostControl = this;
            this.ultraDockManager1.WindowStyle = Infragistics.Win.UltraWinDock.WindowStyle.Office2003;
            // 
            // _Form1UnpinnedTabAreaLeft
            // 
            this._Form1UnpinnedTabAreaLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this._Form1UnpinnedTabAreaLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Form1UnpinnedTabAreaLeft.Location = new System.Drawing.Point(4, 51);
            this._Form1UnpinnedTabAreaLeft.Name = "_Form1UnpinnedTabAreaLeft";
            this._Form1UnpinnedTabAreaLeft.Owner = this.ultraDockManager1;
            this._Form1UnpinnedTabAreaLeft.Size = new System.Drawing.Size(21, 352);
            this._Form1UnpinnedTabAreaLeft.TabIndex = 6;
            // 
            // _Form1UnpinnedTabAreaRight
            // 
            this._Form1UnpinnedTabAreaRight.Dock = System.Windows.Forms.DockStyle.Right;
            this._Form1UnpinnedTabAreaRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Form1UnpinnedTabAreaRight.Location = new System.Drawing.Point(672, 51);
            this._Form1UnpinnedTabAreaRight.Name = "_Form1UnpinnedTabAreaRight";
            this._Form1UnpinnedTabAreaRight.Owner = this.ultraDockManager1;
            this._Form1UnpinnedTabAreaRight.Size = new System.Drawing.Size(0, 352);
            this._Form1UnpinnedTabAreaRight.TabIndex = 7;
            // 
            // _Form1UnpinnedTabAreaTop
            // 
            this._Form1UnpinnedTabAreaTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._Form1UnpinnedTabAreaTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Form1UnpinnedTabAreaTop.Location = new System.Drawing.Point(25, 51);
            this._Form1UnpinnedTabAreaTop.Name = "_Form1UnpinnedTabAreaTop";
            this._Form1UnpinnedTabAreaTop.Owner = this.ultraDockManager1;
            this._Form1UnpinnedTabAreaTop.Size = new System.Drawing.Size(647, 0);
            this._Form1UnpinnedTabAreaTop.TabIndex = 8;
            // 
            // _Form1UnpinnedTabAreaBottom
            // 
            this._Form1UnpinnedTabAreaBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._Form1UnpinnedTabAreaBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Form1UnpinnedTabAreaBottom.Location = new System.Drawing.Point(25, 403);
            this._Form1UnpinnedTabAreaBottom.Name = "_Form1UnpinnedTabAreaBottom";
            this._Form1UnpinnedTabAreaBottom.Owner = this.ultraDockManager1;
            this._Form1UnpinnedTabAreaBottom.Size = new System.Drawing.Size(647, 0);
            this._Form1UnpinnedTabAreaBottom.TabIndex = 9;
            // 
            // _Form1AutoHideControl
            // 
            this._Form1AutoHideControl.Controls.Add(this.dockableWindow1);
            this._Form1AutoHideControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Form1AutoHideControl.Location = new System.Drawing.Point(25, 51);
            this._Form1AutoHideControl.Name = "_Form1AutoHideControl";
            this._Form1AutoHideControl.Owner = this.ultraDockManager1;
            this._Form1AutoHideControl.Size = new System.Drawing.Size(16, 352);
            this._Form1AutoHideControl.TabIndex = 10;
            // 
            // dockableWindow1
            // 
            this.dockableWindow1.Controls.Add(this.ultraExplorerBar1);
            this.dockableWindow1.Location = new System.Drawing.Point(0, 0);
            this.dockableWindow1.Name = "dockableWindow1";
            this.dockableWindow1.Owner = this.ultraDockManager1;
            this.dockableWindow1.Size = new System.Drawing.Size(321, 352);
            this.dockableWindow1.TabIndex = 35;
            // 
            // ultraTabbedMdiManager1
            // 
            this.ultraTabbedMdiManager1.MdiParent = this;
            this.ultraTabbedMdiManager1.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            this.ultraTabbedMdiManager1.ViewStyle = Infragistics.Win.UltraWinTabbedMdi.ViewStyle.VisualStudio2005;
            // 
            // _Form1_Toolbars_Dock_Area_Left
            // 
            this._Form1_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._Form1_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._Form1_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left;
            this._Form1_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Form1_Toolbars_Dock_Area_Left.InitialResizeAreaExtent = 4;
            this._Form1_Toolbars_Dock_Area_Left.Location = new System.Drawing.Point(0, 51);
            this._Form1_Toolbars_Dock_Area_Left.Name = "_Form1_Toolbars_Dock_Area_Left";
            this._Form1_Toolbars_Dock_Area_Left.Size = new System.Drawing.Size(4, 352);
            this._Form1_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // ultraToolbarsManager1
            // 
            this.ultraToolbarsManager1.DesignerFlags = 1;
            this.ultraToolbarsManager1.DockWithinContainer = this;
            this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof(System.Windows.Forms.Form);
            this.ultraToolbarsManager1.Ribbon.Visible = true;
            this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
            this.ultraToolbarsManager1.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2007;
            ultraToolbar1.DockedColumn = 0;
            ultraToolbar1.DockedRow = 0;
            ultraToolbar1.IsMainMenuBar = true;
            ultraToolbar1.Text = "MainMenu";
            this.ultraToolbarsManager1.Toolbars.AddRange(new Infragistics.Win.UltraWinToolbars.UltraToolbar[] {
            ultraToolbar1});
            popupMenuTool3.SharedProps.Caption = "&File";
            popupMenuTool3.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool1});
            buttonTool2.SharedProps.Caption = "E&xit";
            popupMenuTool4.SharedProps.Caption = "&Window";
            popupMenuTool4.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            mdiWindowListTool1});
            mdiWindowListTool2.SharedProps.Caption = "WindowList";
            this.ultraToolbarsManager1.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            popupMenuTool3,
            buttonTool2,
            popupMenuTool4,
            mdiWindowListTool2});
            this.ultraToolbarsManager1.ToolClick += new Infragistics.Win.UltraWinToolbars.ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
            // 
            // _Form1_Toolbars_Dock_Area_Right
            // 
            this._Form1_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._Form1_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._Form1_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right;
            this._Form1_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Form1_Toolbars_Dock_Area_Right.InitialResizeAreaExtent = 4;
            this._Form1_Toolbars_Dock_Area_Right.Location = new System.Drawing.Point(672, 51);
            this._Form1_Toolbars_Dock_Area_Right.Name = "_Form1_Toolbars_Dock_Area_Right";
            this._Form1_Toolbars_Dock_Area_Right.Size = new System.Drawing.Size(4, 352);
            this._Form1_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // _Form1_Toolbars_Dock_Area_Top
            // 
            this._Form1_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._Form1_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._Form1_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top;
            this._Form1_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Form1_Toolbars_Dock_Area_Top.Location = new System.Drawing.Point(0, 0);
            this._Form1_Toolbars_Dock_Area_Top.Name = "_Form1_Toolbars_Dock_Area_Top";
            this._Form1_Toolbars_Dock_Area_Top.Size = new System.Drawing.Size(676, 51);
            this._Form1_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // _Form1_Toolbars_Dock_Area_Bottom
            // 
            this._Form1_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._Form1_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._Form1_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom;
            this._Form1_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Form1_Toolbars_Dock_Area_Bottom.Location = new System.Drawing.Point(0, 403);
            this._Form1_Toolbars_Dock_Area_Bottom.Name = "_Form1_Toolbars_Dock_Area_Bottom";
            this._Form1_Toolbars_Dock_Area_Bottom.Size = new System.Drawing.Size(676, 0);
            this._Form1_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // imageListTreeView
            // 
            this.imageListTreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTreeView.ImageStream")));
            this.imageListTreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTreeView.Images.SetKeyName(0, "");
            this.imageListTreeView.Images.SetKeyName(1, "");
            // 
            // USB_Barra
            // 
            this.USB_Barra.Location = new System.Drawing.Point(0, 403);
            this.USB_Barra.Name = "USB_Barra";
            Appearance15.FontData.BoldAsString = "True";
            ultraStatusPanel1.Appearance = Appearance15;
            ultraStatusPanel1.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded4Thick;
            ultraStatusPanel1.Key = "Key_User";
            ultraStatusPanel1.Width = 250;
            ultraStatusPanel1.WrapText = Infragistics.Win.DefaultableBoolean.False;
            Appearance16.FontData.BoldAsString = "True";
            ultraStatusPanel2.Appearance = Appearance16;
            ultraStatusPanel2.Key = "Key_Crp";
            ultraStatusPanel2.Width = 180;
            Appearance17.FontData.BoldAsString = "True";
            ultraStatusPanel3.Appearance = Appearance17;
            ultraStatusPanel3.Key = "Key_Con";
            appearance2.FontData.BoldAsString = "True";
            ultraStatusPanel4.Appearance = appearance2;
            ultraStatusPanel4.Key = "Key_CentroCosto";
            ultraStatusPanel4.Width = 350;
            appearance13.FontData.BoldAsString = "True";
            ultraStatusPanel5.Appearance = appearance13;
            ultraStatusPanel5.Key = "Key_CentroGestor";
            ultraStatusPanel5.Width = 350;
            appearance14.FontData.BoldAsString = "True";
            ultraStatusPanel6.Appearance = appearance14;
            ultraStatusPanel6.Key = "KeyConexion";
            this.USB_Barra.Panels.AddRange(new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel[] {
            ultraStatusPanel1,
            ultraStatusPanel2,
            ultraStatusPanel3,
            ultraStatusPanel4,
            ultraStatusPanel5,
            ultraStatusPanel6});
            this.USB_Barra.Size = new System.Drawing.Size(676, 26);
            this.USB_Barra.TabIndex = 33;
            this.USB_Barra.Text = "UltraStatusBar1";
            this.USB_Barra.ViewStyle = Infragistics.Win.UltraWinStatusBar.ViewStyle.Office2007;
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Silver;
            this.ImageList1.Images.SetKeyName(0, "ActualizarVersion.png");
            this.ImageList1.Images.SetKeyName(1, "Ceco.png");
            this.ImageList1.Images.SetKeyName(2, "CecoProyecto.png");
            this.ImageList1.Images.SetKeyName(3, "Empleado.png");
            this.ImageList1.Images.SetKeyName(4, "Financiamiento.png");
            this.ImageList1.Images.SetKeyName(5, "Formulacion.png");
            this.ImageList1.Images.SetKeyName(6, "Interno.png");
            this.ImageList1.Images.SetKeyName(7, "Inversion.png");
            this.ImageList1.Images.SetKeyName(8, "Proyecto.png");
            this.ImageList1.Images.SetKeyName(9, "ReporteCeco.png");
            this.ImageList1.Images.SetKeyName(10, "ReporteProyecto.png");
            this.ImageList1.Images.SetKeyName(11, "Saldo.png");
            this.ImageList1.Images.SetKeyName(12, "Tarea.png");
            this.ImageList1.Images.SetKeyName(13, "Accounting_32x32.png");
            this.ImageList1.Images.SetKeyName(14, "Action_AboutInfo_32x32.png");
            this.ImageList1.Images.SetKeyName(15, "Action_Chart_Printing_Preview_32x32.png");
            this.ImageList1.Images.SetKeyName(16, "Action_Close_32x32.png");
            this.ImageList1.Images.SetKeyName(17, "Action_CloseAllWindows_32x32.png");
            this.ImageList1.Images.SetKeyName(18, "Action_Copy_32x32.png");
            this.ImageList1.Images.SetKeyName(19, "Action_Dashboard_ShowDesigner_32x32.png");
            this.ImageList1.Images.SetKeyName(20, "Action_Exit_32x32.png");
            this.ImageList1.Images.SetKeyName(21, "Action_Export_32x32.png");
            this.ImageList1.Images.SetKeyName(22, "Action_LinkUnlink_Link_32x32.png");
            this.ImageList1.Images.SetKeyName(23, "Action_OrganizeDashboard_32x32.png");
            this.ImageList1.Images.SetKeyName(24, "Action_PivotChart_Data_Unbind_32x32.png");
            this.ImageList1.Images.SetKeyName(25, "Action_Printing_PageSetup_32x32.png");
            this.ImageList1.Images.SetKeyName(26, "Action_Printing_Preview_32x32.png");
            this.ImageList1.Images.SetKeyName(27, "Action_Report_Object_Inplace_Preview_32x32.png");
            this.ImageList1.Images.SetKeyName(28, "Action_ResetPassword_32x32.png");
            this.ImageList1.Images.SetKeyName(29, "Action_WindowList_32x32.png");
            this.ImageList1.Images.SetKeyName(30, "ActionGroup_EasyTestRecorder_32x32.png");
            this.ImageList1.Images.SetKeyName(31, "ActionsInDetailView_32x32.png");
            this.ImageList1.Images.SetKeyName(32, "AllowUsersToEditRanges_32x32.png");
            this.ImageList1.Images.SetKeyName(33, "Area3_32x32.png");
            this.ImageList1.Images.SetKeyName(34, "Article_32x32.png");
            this.ImageList1.Images.SetKeyName(35, "AssignTo_32x32.png");
            this.ImageList1.Images.SetKeyName(36, "AssignToMe_32x32.png");
            this.ImageList1.Images.SetKeyName(37, "BO_Address_32x32.png");
            this.ImageList1.Images.SetKeyName(38, "BO_Appearance_32x32.png");
            this.ImageList1.Images.SetKeyName(39, "BO_Category_32x32.png");
            this.ImageList1.Images.SetKeyName(40, "BO_Contract_32x32.png");
            this.ImageList1.Images.SetKeyName(41, "BO_Department_32x32.png");
            this.ImageList1.Images.SetKeyName(42, "BO_Report_32x32.png");
            this.ImageList1.Images.SetKeyName(43, "BO_Skull_32x32.png");
            this.ImageList1.Images.SetKeyName(44, "BOContact2_32x32.png");
            this.ImageList1.Images.SetKeyName(45, "BODetails_32x32.png");
            this.ImageList1.Images.SetKeyName(46, "BOPivotChart_32x32.png");
            this.ImageList1.Images.SetKeyName(47, "BOScheduler_32x32.png");
            this.ImageList1.Images.SetKeyName(48, "BOTask_32x32.png");
            this.ImageList1.Images.SetKeyName(49, "Cancel_32x32.png");
            this.ImageList1.Images.SetKeyName(50, "CellsAutoHeight-_32x32.png");
            this.ImageList1.Images.SetKeyName(51, "CheckButtons_32x32.png");
            this.ImageList1.Images.SetKeyName(52, "ColorLegend_32x32.png");
            this.ImageList1.Images.SetKeyName(53, "Customization_32x32.png");
            this.ImageList1.Images.SetKeyName(54, "CustomizeGrid_32x32.png");
            this.ImageList1.Images.SetKeyName(55, "DeleteGroupHeader_32x32.png");
            this.ImageList1.Images.SetKeyName(56, "DeleteList_32x32.png");
            this.ImageList1.Images.SetKeyName(57, "DifferentOddEvenPages_32x32.png");
            this.ImageList1.Images.SetKeyName(58, "DocumentMap_32x32.png");
            this.ImageList1.Images.SetKeyName(59, "DocumentProperties_32x32.png");
            this.ImageList1.Images.SetKeyName(60, "EditContact_32x32.png");
            this.ImageList1.Images.SetKeyName(61, "EditTask_32x32.png");
            this.ImageList1.Images.SetKeyName(62, "FieldHeadersPivotTable_32x32.png");
            this.ImageList1.Images.SetKeyName(63, "Fill_32x32.png");
            this.ImageList1.Images.SetKeyName(64, "ForceTesting_32x32.png");
            this.ImageList1.Images.SetKeyName(65, "Format_32x32.png");
            this.ImageList1.Images.SetKeyName(66, "FormatCells_32x32.png");
            this.ImageList1.Images.SetKeyName(67, "GeoPointMap_32x32.png");
            this.ImageList1.Images.SetKeyName(68, "GroupByDate_32x32.png");
            this.ImageList1.Images.SetKeyName(69, "GroupHeader_32x32.png");
            this.ImageList1.Images.SetKeyName(70, "Information_32x32.png");
            this.ImageList1.Images.SetKeyName(71, "InitialState_32x32.png");
            this.ImageList1.Images.SetKeyName(72, "InsertBlankLinePivotTable_32x32.png");
            this.ImageList1.Images.SetKeyName(73, "InsertTableOfContents_32x32.png");
            this.ImageList1.Images.SetKeyName(74, "InsertTextBox_32x32.png");
            this.ImageList1.Images.SetKeyName(75, "LabelsOutsideEnd_32x32.png");
            this.ImageList1.Images.SetKeyName(76, "ListNumbers_32x32.png");
            this.ImageList1.Images.SetKeyName(77, "ModelEditor_Action_Schema_32x32.png");
            this.ImageList1.Images.SetKeyName(78, "ModelEditor_Alphabetic_32x32.png");
            this.ImageList1.Images.SetKeyName(79, "ModelEditor_Views_32x32.png");
            this.ImageList1.Images.SetKeyName(80, "ModifyTableStyle_32x32.png");
            this.ImageList1.Images.SetKeyName(81, "NameManager_32x32.png");
            this.ImageList1.Images.SetKeyName(82, "Navigation_Group_ViewVariant_32x32.png");
            this.ImageList1.Images.SetKeyName(83, "NavigationOptions_32x32.png");
            this.ImageList1.Images.SetKeyName(84, "NewContact_32x32.png");
            this.ImageList1.Images.SetKeyName(85, "PageInfo_32x32.png");
            this.ImageList1.Images.SetKeyName(86, "PivotTableGroupSelectionContextMenuItem_32x32.png");
            this.ImageList1.Images.SetKeyName(87, "Preview_32x32.png");
            this.ImageList1.Images.SetKeyName(88, "Print_32x32.png");
            this.ImageList1.Images.SetKeyName(89, "PrintLayoutView_32x32.png");
            this.ImageList1.Images.SetKeyName(90, "PublicFix_32x32.png");
            this.ImageList1.Images.SetKeyName(91, "RangeBar_32x32.png");
            this.ImageList1.Images.SetKeyName(92, "Recurrence_32x32.png");
            this.ImageList1.Images.SetKeyName(93, "Reviewers_32x32.png");
            this.ImageList1.Images.SetKeyName(94, "Save_32x32.png");
            this.ImageList1.Images.SetKeyName(95, "ShowTestReport_32x32.png");
            this.ImageList1.Images.SetKeyName(96, "SnapDeleteList_32x32.png");
            this.ImageList1.Images.SetKeyName(97, "State_Validation_Information_48x48.png");
            this.ImageList1.Images.SetKeyName(98, "State_Validation_Invalid_48x48.png");
            this.ImageList1.Images.SetKeyName(99, "State_Validation_Valid_48x48.png");
            this.ImageList1.Images.SetKeyName(100, "SwitchTimeScalesTo_32x32.png");
            this.ImageList1.Images.SetKeyName(101, "Task_32x32.png");
            this.ImageList1.Images.SetKeyName(102, "Time2_32x32.png");
            this.ImageList1.Images.SetKeyName(103, "TimeLineView_32x32.png");
            this.ImageList1.Images.SetKeyName(104, "Today_32x32.png");
            this.ImageList1.Images.SetKeyName(105, "TopBottomRules_32x32.png");
            this.ImageList1.Images.SetKeyName(106, "UpdateTableOfContents_32x32.png");
            this.ImageList1.Images.SetKeyName(107, "UserGroup_32x32.png");
            this.ImageList1.Images.SetKeyName(108, "Version_32x32.png");
            this.ImageList1.Images.SetKeyName(109, "ViewMergedData_32x32.png");
            this.ImageList1.Images.SetKeyName(110, "WeekView_32x32.png");
            this.ImageList1.Images.SetKeyName(111, "Window_32x32.png");
            this.ImageList1.Images.SetKeyName(112, "PivotTableUngroup_32x32.png");
            // 
            // ilLarge
            // 
            this.ilLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilLarge.ImageStream")));
            this.ilLarge.TransparentColor = System.Drawing.Color.Silver;
            this.ilLarge.Images.SetKeyName(0, "ActualizarVersion.png");
            this.ilLarge.Images.SetKeyName(1, "Buscar.png");
            this.ilLarge.Images.SetKeyName(2, "Calcular.png");
            this.ilLarge.Images.SetKeyName(3, "Ceco.png");
            this.ilLarge.Images.SetKeyName(4, "CecoProyecto.png");
            this.ilLarge.Images.SetKeyName(5, "Cerrar.png");
            this.ilLarge.Images.SetKeyName(6, "Detalle.png");
            this.ilLarge.Images.SetKeyName(7, "Eliminar.png");
            this.ilLarge.Images.SetKeyName(8, "Empleado.png");
            this.ilLarge.Images.SetKeyName(9, "Financiamiento.png");
            this.ilLarge.Images.SetKeyName(10, "Formulacion.png");
            this.ilLarge.Images.SetKeyName(11, "Imprimir.png");
            this.ilLarge.Images.SetKeyName(12, "Interno.png");
            this.ilLarge.Images.SetKeyName(13, "Inversion.png");
            this.ilLarge.Images.SetKeyName(14, "Lista.png");
            this.ilLarge.Images.SetKeyName(15, "Proyecto.png");
            this.ilLarge.Images.SetKeyName(16, "ReporteCeco.png");
            this.ilLarge.Images.SetKeyName(17, "ReporteProyecto.png");
            this.ilLarge.Images.SetKeyName(18, "Saldo.png");
            this.ilLarge.Images.SetKeyName(19, "Tarea.png");
            this.ilLarge.Images.SetKeyName(20, "Accounting_32x32.png");
            this.ilLarge.Images.SetKeyName(21, "Action_AboutInfo_32x32.png");
            this.ilLarge.Images.SetKeyName(22, "Action_Chart_Printing_Preview_32x32.png");
            this.ilLarge.Images.SetKeyName(23, "Action_Close_32x32.png");
            this.ilLarge.Images.SetKeyName(24, "Action_CloseAllWindows_32x32.png");
            this.ilLarge.Images.SetKeyName(25, "Action_Copy_32x32.png");
            this.ilLarge.Images.SetKeyName(26, "Action_Dashboard_ShowDesigner_32x32.png");
            this.ilLarge.Images.SetKeyName(27, "Action_Exit_32x32.png");
            this.ilLarge.Images.SetKeyName(28, "Action_Export_32x32.png");
            this.ilLarge.Images.SetKeyName(29, "Action_LinkUnlink_Link_32x32.png");
            this.ilLarge.Images.SetKeyName(30, "Action_OrganizeDashboard_32x32.png");
            this.ilLarge.Images.SetKeyName(31, "Action_PivotChart_Data_Unbind_32x32.png");
            this.ilLarge.Images.SetKeyName(32, "Action_Printing_PageSetup_32x32.png");
            this.ilLarge.Images.SetKeyName(33, "Action_Printing_Preview_32x32.png");
            this.ilLarge.Images.SetKeyName(34, "Action_Report_Object_Inplace_Preview_32x32.png");
            this.ilLarge.Images.SetKeyName(35, "Action_ResetPassword_32x32.png");
            this.ilLarge.Images.SetKeyName(36, "Action_WindowList_32x32.png");
            this.ilLarge.Images.SetKeyName(37, "ActionGroup_EasyTestRecorder_32x32.png");
            this.ilLarge.Images.SetKeyName(38, "ActionsInDetailView_32x32.png");
            this.ilLarge.Images.SetKeyName(39, "AllowUsersToEditRanges_32x32.png");
            this.ilLarge.Images.SetKeyName(40, "Area3_32x32.png");
            this.ilLarge.Images.SetKeyName(41, "Article_32x32.png");
            this.ilLarge.Images.SetKeyName(42, "AssignTo_32x32.png");
            this.ilLarge.Images.SetKeyName(43, "AssignToMe_32x32.png");
            this.ilLarge.Images.SetKeyName(44, "BO_Address_32x32.png");
            this.ilLarge.Images.SetKeyName(45, "BO_Appearance_32x32.png");
            this.ilLarge.Images.SetKeyName(46, "BO_Category_32x32.png");
            this.ilLarge.Images.SetKeyName(47, "BO_Contract_32x32.png");
            this.ilLarge.Images.SetKeyName(48, "BO_Department_32x32.png");
            this.ilLarge.Images.SetKeyName(49, "BO_Report_32x32.png");
            this.ilLarge.Images.SetKeyName(50, "BO_Skull_32x32.png");
            this.ilLarge.Images.SetKeyName(51, "BOContact2_32x32.png");
            this.ilLarge.Images.SetKeyName(52, "BODetails_32x32.png");
            this.ilLarge.Images.SetKeyName(53, "BOPivotChart_32x32.png");
            this.ilLarge.Images.SetKeyName(54, "BOScheduler_32x32.png");
            this.ilLarge.Images.SetKeyName(55, "BOTask_32x32.png");
            this.ilLarge.Images.SetKeyName(56, "Cancel_32x32.png");
            this.ilLarge.Images.SetKeyName(57, "CellsAutoHeight-_32x32.png");
            this.ilLarge.Images.SetKeyName(58, "CheckButtons_32x32.png");
            this.ilLarge.Images.SetKeyName(59, "ColorLegend_32x32.png");
            this.ilLarge.Images.SetKeyName(60, "Customization_32x32.png");
            this.ilLarge.Images.SetKeyName(61, "CustomizeGrid_32x32.png");
            this.ilLarge.Images.SetKeyName(62, "DeleteGroupHeader_32x32.png");
            this.ilLarge.Images.SetKeyName(63, "DeleteList_32x32.png");
            this.ilLarge.Images.SetKeyName(64, "DifferentOddEvenPages_32x32.png");
            this.ilLarge.Images.SetKeyName(65, "DocumentMap_32x32.png");
            this.ilLarge.Images.SetKeyName(66, "DocumentProperties_32x32.png");
            this.ilLarge.Images.SetKeyName(67, "EditContact_32x32.png");
            this.ilLarge.Images.SetKeyName(68, "EditTask_32x32.png");
            this.ilLarge.Images.SetKeyName(69, "FieldHeadersPivotTable_32x32.png");
            this.ilLarge.Images.SetKeyName(70, "Fill_32x32.png");
            this.ilLarge.Images.SetKeyName(71, "ForceTesting_32x32.png");
            this.ilLarge.Images.SetKeyName(72, "Format_32x32.png");
            this.ilLarge.Images.SetKeyName(73, "FormatCells_32x32.png");
            this.ilLarge.Images.SetKeyName(74, "GeoPointMap_32x32.png");
            this.ilLarge.Images.SetKeyName(75, "GroupByDate_32x32.png");
            this.ilLarge.Images.SetKeyName(76, "GroupHeader_32x32.png");
            this.ilLarge.Images.SetKeyName(77, "Information_32x32.png");
            this.ilLarge.Images.SetKeyName(78, "InitialState_32x32.png");
            this.ilLarge.Images.SetKeyName(79, "InsertBlankLinePivotTable_32x32.png");
            this.ilLarge.Images.SetKeyName(80, "InsertTableOfContents_32x32.png");
            this.ilLarge.Images.SetKeyName(81, "InsertTextBox_32x32.png");
            this.ilLarge.Images.SetKeyName(82, "LabelsOutsideEnd_32x32.png");
            this.ilLarge.Images.SetKeyName(83, "ListNumbers_32x32.png");
            this.ilLarge.Images.SetKeyName(84, "ModelEditor_Action_Schema_32x32.png");
            this.ilLarge.Images.SetKeyName(85, "ModelEditor_Alphabetic_32x32.png");
            this.ilLarge.Images.SetKeyName(86, "ModelEditor_Views_32x32.png");
            this.ilLarge.Images.SetKeyName(87, "ModifyTableStyle_32x32.png");
            this.ilLarge.Images.SetKeyName(88, "NameManager_32x32.png");
            this.ilLarge.Images.SetKeyName(89, "Navigation_Group_ViewVariant_32x32.png");
            this.ilLarge.Images.SetKeyName(90, "NavigationOptions_32x32.png");
            this.ilLarge.Images.SetKeyName(91, "NewContact_32x32.png");
            this.ilLarge.Images.SetKeyName(92, "PageInfo_32x32.png");
            this.ilLarge.Images.SetKeyName(93, "PivotTableGroupSelectionContextMenuItem_32x32.png");
            this.ilLarge.Images.SetKeyName(94, "Preview_32x32.png");
            this.ilLarge.Images.SetKeyName(95, "Print_32x32.png");
            this.ilLarge.Images.SetKeyName(96, "PrintLayoutView_32x32.png");
            this.ilLarge.Images.SetKeyName(97, "PublicFix_32x32.png");
            this.ilLarge.Images.SetKeyName(98, "RangeBar_32x32.png");
            this.ilLarge.Images.SetKeyName(99, "Recurrence_32x32.png");
            this.ilLarge.Images.SetKeyName(100, "Reviewers_32x32.png");
            this.ilLarge.Images.SetKeyName(101, "Save_32x32.png");
            this.ilLarge.Images.SetKeyName(102, "ShowTestReport_32x32.png");
            this.ilLarge.Images.SetKeyName(103, "SnapDeleteList_32x32.png");
            this.ilLarge.Images.SetKeyName(104, "State_Validation_Information_48x48.png");
            this.ilLarge.Images.SetKeyName(105, "State_Validation_Invalid_48x48.png");
            this.ilLarge.Images.SetKeyName(106, "State_Validation_Valid_48x48.png");
            this.ilLarge.Images.SetKeyName(107, "SwitchTimeScalesTo_32x32.png");
            this.ilLarge.Images.SetKeyName(108, "Task_32x32.png");
            this.ilLarge.Images.SetKeyName(109, "Time2_32x32.png");
            this.ilLarge.Images.SetKeyName(110, "TimeLineView_32x32.png");
            this.ilLarge.Images.SetKeyName(111, "Today_32x32.png");
            this.ilLarge.Images.SetKeyName(112, "TopBottomRules_32x32.png");
            this.ilLarge.Images.SetKeyName(113, "UpdateTableOfContents_32x32.png");
            this.ilLarge.Images.SetKeyName(114, "UserGroup_32x32.png");
            this.ilLarge.Images.SetKeyName(115, "Version_32x32.png");
            this.ilLarge.Images.SetKeyName(116, "ViewMergedData_32x32.png");
            this.ilLarge.Images.SetKeyName(117, "WeekView_32x32.png");
            this.ilLarge.Images.SetKeyName(118, "Window_32x32.png");
            this.ilLarge.Images.SetKeyName(119, "PivotTableUngroup_32x32.png");
            // 
            // windowDockingArea2
            // 
            this.windowDockingArea2.Dock = System.Windows.Forms.DockStyle.Left;
            this.windowDockingArea2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowDockingArea2.Location = new System.Drawing.Point(4, 51);
            this.windowDockingArea2.Name = "windowDockingArea2";
            this.windowDockingArea2.Owner = this.ultraDockManager1;
            this.windowDockingArea2.Size = new System.Drawing.Size(326, 352);
            this.windowDockingArea2.TabIndex = 11;
            // 
            // Frm_Principal
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(676, 429);
            this.Controls.Add(this._Form1AutoHideControl);
            this.Controls.Add(this.windowDockingArea2);
            this.Controls.Add(this._Form1UnpinnedTabAreaTop);
            this.Controls.Add(this._Form1UnpinnedTabAreaBottom);
            this.Controls.Add(this._Form1UnpinnedTabAreaRight);
            this.Controls.Add(this._Form1UnpinnedTabAreaLeft);
            this.Controls.Add(this._Form1_Toolbars_Dock_Area_Left);
            this.Controls.Add(this._Form1_Toolbars_Dock_Area_Right);
            this.Controls.Add(this._Form1_Toolbars_Dock_Area_Top);
            this.Controls.Add(this._Form1_Toolbars_Dock_Area_Bottom);
            this.Controls.Add(this.USB_Barra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPRINGreport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Principal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraDockManager1)).EndInit();
            this._Form1AutoHideControl.ResumeLayout(false);
            this.dockableWindow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraToolbarsManager1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


       private void Form1_Load(object sender, System.EventArgs e)
		{
		}

		private void ultraToolbarsManager1_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
		{
			switch (e.Tool.Key)
			{
				case "Exit":    // ButtonTool
					Application.Exit();
					break;

				case "Refresh Navigation":    // ButtonTool
					//LoadSamplesNavigationTree();
					break;

			}

		}

        private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Esta por finalizar el acceso a la aplicacion, realmente desea salir ? ",
                                        "Salir", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question
                                    ) == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
