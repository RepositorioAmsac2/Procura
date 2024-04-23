using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Service
{
    public class Data
    {
        private Repository.Data objDs = new Repository.Data();

        //Repository.Data objDs = new Repository.Data();

        #region GNLP

        public DataSet Ayuda_Gnlp_FuenteFinanciamiento(string strCodEmpresa,
                                                    string strCodGnlp
                                )
        {
            return objDs.Ayuda_Gnlp_FuenteFinanciamiento(strCodEmpresa,
                                                     strCodGnlp
                                );
        }

        public DataSet Lista_CeCo_Gnlp(string strCodEmpresa,
                                    string strAñoProceso,
                                    string strPeriodo,
                                    string strCodCentroCosto

                                  )
        {
            return objDs.Lista_CeCo_Gnlp(strCodEmpresa,
                                        strAñoProceso,
                                        strPeriodo,
                                        strCodCentroCosto

                                          );
        }

        public DataSet Lista_CeCo_Gnlp_Total(string strCodEmpresa,
                            string strAñoProceso,
                            string strPeriodo

                          )
        {
            return objDs.Lista_CeCo_Gnlp_Total(strCodEmpresa,
                                        strAñoProceso,
                                        strPeriodo

                                          );
        }


        public Boolean Elimina_CentroCosto_Gnlp(string strCodEmpresa,
                                        string strAñoProceso,
                                        string strPeriodo,
                                        string strCodCeCo,
                                        string strCodGnlp
                                      )
        {
            return objDs.Elimina_CentroCosto_Gnlp(strCodEmpresa,
                                                 strAñoProceso,
                                                 strPeriodo,
                                                 strCodCeCo,
                                                 strCodGnlp
                                              );
        }

        public Boolean Graba_CentroCosto_Gnlp(string strCodEmpresa,
                                        string strAñoProceso,
                                        string strPeriodo,
                                        string strCodCeCo,
                                        string strCodGnlp
                                      )
        {
            return objDs.Graba_CentroCosto_Gnlp(strCodEmpresa,
                                                 strAñoProceso,
                                                strPeriodo,
                                                strCodCeCo,
                                                strCodGnlp
                                              );
        }


        public DataSet Ayuda_GNLP(string strCodCompañia,
                                    string strAñoProceso,
                                    string strCodTipoFormulacion,
                                    string strCodSubTipoFormulacion
                          )
        {
            return objDs.Ayuda_GNLP(    strCodCompañia,
                                        strAñoProceso,
                                        strCodTipoFormulacion,
                                        strCodSubTipoFormulacion
                          );
        }

        public DataSet Ayuda_CentroCosto_Gnlp(string strCodCompañia,
                                    string strAñoProceso,
                                    string strPeriodo,
                                    string strCodCentroCosto
                                  )
        {
            return objDs.Ayuda_CentroCosto_Gnlp(strCodCompañia,
                                            strAñoProceso,
                                            strPeriodo,
                                            strCodCentroCosto
                                          );
        }

        public DataSet Combo_ClaseOrden(string strCodEmpresa, string strCodTipoFormulacion)
        {
            return objDs.Combo_ClaseOrden(strCodEmpresa,strCodTipoFormulacion);
        }

        public Model.GNLP Recupera_GNLP(string strCodEmpresa,
                                         string strCodGNLP
                                       )
        {
            return objDs.Recupera_GNLP(strCodEmpresa, strCodGNLP);
        }

        public DataSet Lista_GNLP_FuenteFinanciamiento(string strCodEmpresa,
                                    string strCodGNLP

                          )
        {
            return objDs.Lista_GNLP_FuenteFinanciamiento(strCodEmpresa, strCodGNLP);
        }

        public Boolean Graba_GNLP_FuenteFinanciamiento(string strCodEmpresa,
                                        string strCodGNLP,
                                        string strCodFuenteFinanciamiento
                                      )
        {
            return objDs.Graba_GNLP_FuenteFinanciamiento(strCodEmpresa,
                                                 strCodGNLP,
                                                 strCodFuenteFinanciamiento
                                               );
        }

        public Boolean Elimina_GNLP_FuenteFinanciamiento(string strCodEmpresa,
                                        string strCodGNLP,
                                        string strCodFuenteFinanciamiento
                                      )
        {
            return objDs.Elimina_GNLP_FuenteFinanciamiento(strCodEmpresa,
                                                strCodGNLP,
                                                strCodFuenteFinanciamiento
                                              );
        }

        public Model.GNLP Graba_GNLP(Model.GNLP obj,
                                string strAñoProceso,
                                string strPeriodoProceso,
                                string strCodCentroCosto,
                                bool LlamadaDesdeHojaTrabajo
                            )
        {
            return objDs.Graba_GNLP(obj,
                                    strAñoProceso,
                                    strPeriodoProceso,
                                    strCodCentroCosto,
                                    LlamadaDesdeHojaTrabajo
                                     );
        }
        public Model.GNLP Modifica_GNLP(Model.GNLP obj)
        {
            return objDs.Modifica_GNLP(obj);
        }

        public int Elimina_GNLP(int Id)
        {
            return objDs.Elimina_GNLP(Id);
        }

        public DataSet Lista_GNLP(string strCodEmpresa,
                              int intTipoGNLP
                             )
        {
            return objDs.Lista_GNLP(strCodEmpresa,
                                    intTipoGNLP
                                     );
        }


        #endregion

        #region ConfiguracionHojaTrabajo
        public List<Model.Configuracion_HojaTrabajo> lista_Configuracion_HojaTrabajo_OcultaColumna(string strCodEmpresa,
                                                                     string strCodTipoFormulacion,
                                                                     string strCodSubTipoFormulacion,
                                                                     bool blnManejaVariosCentroCostos,
                                                                     bool blnManejaVariosProyectos
                                                                    )
        {
            return objDs.lista_Configuracion_HojaTrabajo_OcultaColumna(strCodEmpresa,strCodTipoFormulacion,strCodSubTipoFormulacion, blnManejaVariosCentroCostos,blnManejaVariosProyectos);
        }

        public List<Model.Configuracion_HojaTrabajo> lista_Configuracion_HojaTrabajo_ProtegeColumna(string strCodEmpresa,
                                                             string strCodTipoFormulacion,
                                                             string strCodSubTipoFormulacion,
                                                             bool blnManejaVariosCentroCostos,
                                                             bool blnManejaVariosProyectos
                                                            )
        {
            return objDs.lista_Configuracion_HojaTrabajo_ProtegeColumna(strCodEmpresa, strCodTipoFormulacion, strCodSubTipoFormulacion, blnManejaVariosCentroCostos, blnManejaVariosProyectos);
        }

        public List<Model.Configuracion_HojaTrabajo> lista_Configuracion_HojaTrabajo_ValidaColumna(string strCodEmpresa,
                                                             string strCodTipoFormulacion,
                                                             string strCodSubTipoFormulacion,
                                                             bool blnManejaVariosCentroCostos,
                                                             bool blnManejaVariosProyectos
                                                            )
        {
            return objDs.lista_Configuracion_HojaTrabajo_ValidaColumna(strCodEmpresa, strCodTipoFormulacion, strCodSubTipoFormulacion, blnManejaVariosCentroCostos, blnManejaVariosProyectos);
        }
        #endregion


        #region Usuario_Empresa

        public bool Modifica_Cntraseña_Empresa(string strCodEmpresa,
                                                string strUsuario,
                                                string strContraseña
                                              )
        {
            return objDs.Modifica_Cntraseña_Empresa(strCodEmpresa,
                                                strUsuario,
                                                strContraseña
                                              );
        }

        public Model.Usuario_Empresa Recupera_Usuario_Empresa(int intIdUsuario)
        {
            return objDs.Recupera_Usuario_Empresa(intIdUsuario);

        }
        public Model.Usuario_Empresa Recupera_Usuario_Empresa_Codigo(string strCodEmpresa,
                                                     string strLogUsuario
                                                    )
        {
            return objDs.Recupera_Usuario_Empresa_Codigo(strCodEmpresa,
                                                         strLogUsuario
                                                        );

        }
        public bool Elimina_Usuario_Empresa(int intidUsuario)
        {
            return objDs.Elimina_Usuario_Empresa(intidUsuario);
        }

        public int Graba_Usuario_Empresa(Model.Usuario_Empresa obj)
        {
            return objDs.Graba_Usuario_Empresa(obj);
        }

        public int Modifica_Usuario_Empresa(Model.Usuario_Empresa obj)
        {
            return objDs.Modifica_Usuario_Empresa(obj);
        }

        public DataSet Lista_Usuario_Empresa(string strCodEmpresa)
        {
            return objDs.Lista_Usuario_Empresa(strCodEmpresa);
        }

        #endregion

        #region ACCESO

        #region Empresa
        public DataSet Combo_Empresa_DataTable()
        {
            return objDs.Combo_Empresa_DataTable();
        }

        public bool Modifica_Empresa_Login(Model.Empresa_Login obj)
        {
            return objDs.Modifica_Empresa_Login(obj);
        }

        public Model.Empresa_Login Recupera_Empresa_Login(string strCodEmpresa)
        {
            return objDs.Recupera_Empresa_Login(strCodEmpresa);
        }

        #endregion

        #region TipoFormulacion
        public DataSet Combo_SubTipoFormulacion(    string strCodEmpresa,
                                                    string strCodTipoFormulacion
                                                )
        {
            return objDs.Combo_SubTipoFormulacion( strCodEmpresa,strCodTipoFormulacion);
        }
        #endregion

        #region Usuario
        public Model.Usuario Recupera_Usuario(int intIdeUsuario)
        {
            return objDs.Recupera_Usuario(intIdeUsuario);
        }

        public Model.Usuario Recupera_Usuario_Codigo(string strCodEmpresa,
                                                         string strLogUsuario
                                                    )
        {
            return objDs.Recupera_Usuario_Codigo( strCodEmpresa,
                                                   strLogUsuario
                                                    );

        }

        public DataSet Combo_Usuario_Modulo_DataTable(string strCodEmpresa, string strLogUsuario)
        {
            return objDs.Combo_Usuario_Modulo_DataTable(strCodEmpresa, strLogUsuario);

        }

        public DataSet OpcionesMenu_Top(string strCodEmpresa,
                                    string strCodUsuario,
                                    string strCodModulo)
        {
            return objDs.OpcionesMenu_Top( strCodEmpresa,
                                     strCodUsuario,
                                     strCodModulo);
        }

        public DataSet OpcionesMenu_Lateral(string strCodEmpresa,
                                    string strCodUsuario,
                                    string strCodModulo)
        {
            return objDs.OpcionesMenu_Lateral(strCodEmpresa,
                                     strCodUsuario,
                                     strCodModulo);
        }

        public Model.Usuario GetUsuario(string strLogUsuario)
        {
            return objDs.GetUsuario( strLogUsuario);
        }

        public bool Modifica_Usuario(Model.Usuario objU )
        {
            return objDs.Modifica_Usuario(objU);
        }
        #endregion
        #endregion

        #region GENERAL
        #region Gerencia
        public DataSet Combo_Gerencia(string strCodEmpresa)
        {

            return objDs.Combo_Gerencia(strCodEmpresa);
        }

        #endregion
        #region "TipoMoneda"
        public DataSet Ayuda_TipoMoneda()
        {
            return objDs.Ayuda_TipoMoneda();


        }
        public DataSet Combo_TipoMoneda()
        {
            return objDs.Combo_TipoMoneda();


        }
        public Model.TipoMoneda Recupera_TipoMoneda(int intIdTipoMoneda)
        {
            return objDs.Recupera_TipoMoneda(intIdTipoMoneda);
        }


        public Model.TipoMoneda Recupera_TipoMoneda_Codigo(string strCodTipoMoneda)
        {
            return objDs.Recupera_TipoMoneda_Codigo(strCodTipoMoneda);
        }

        public int Graba_TipoMoneda(Model.TipoMoneda obj)
        {
            return objDs.Graba_TipoMoneda(obj);
        }

        public int Modifica_TipoMoneda(Model.TipoMoneda obj)
        {
            return objDs.Modifica_TipoMoneda(obj);
        }

        public bool Elimina_TipoMoneda(int intIdTipoMoneda)
        {
            return objDs.Elimina_TipoMoneda(intIdTipoMoneda);
        }

        public DataSet Lista_TipoMoneda()
        {
            return objDs.Lista_TipoMoneda();
        }

        #endregion

        #region Concepto
        public DataSet Ayuda_Concepto()
        {
            return objDs.Ayuda_Concepto();
        }
        #endregion


        #region Contabilidad
        public DataSet Ayuda_PlanContable_Spring()
        {
            return objDs.Ayuda_PlanContable_Spring();
        }
        #endregion

        #region Formulacion

        public DataSet Combo_TipoDocumento_Formulacion()
        {
            return objDs.Combo_TipoDocumento_Formulacion();
        }

        public DataSet Combo_CentroGestor_Reporte(string strCodFuenteFinanciamiento)
        {
            return objDs.Combo_CentroGestor_Reporte(strCodFuenteFinanciamiento);
        }

        public DataSet Ayuda_CentroGestor_Reporte(string strCodFuenteFinanciamiento)
        {
            return objDs.Ayuda_CentroGestor_Reporte(strCodFuenteFinanciamiento);
        }


        public DataSet Combo_ClaseGasto()
        {
            return objDs.Combo_ClaseGasto();
        }

        public DataSet Combo_Tarea_FuenteFinanciamiento(string strCodCompañia,
                                                            string strCodProyecto
                                                          )
        {
            return objDs.Combo_Tarea_FuenteFinanciamiento(strCodCompañia,
                                                            strCodProyecto
                                                          );
        }

        public DataSet Combo_ClaseGasto_Clasificador(string strCodCompañia,
                                                        string strCodCentroGestor,
                                                        string strCodTipoFormulacion
                                                    )
        {
            return objDs.Combo_ClaseGasto_Clasificador( strCodCompañia,
                                                  strCodCentroGestor,
                                                  strCodTipoFormulacion
                                                    );
        }

        public DataSet Combo_ClaseGasto_Inversion(string strCodCompañia,
                                                  string strCodProyecto,
                                                  string strCodCentroGestor
                                                    )
        {
            return objDs.Combo_ClaseGasto_Inversion( strCodCompañia,
                                               strCodProyecto,
                                               strCodCentroGestor
                                                    );
        }

        public DataSet Combo_ClaseGasto_Otros(string strCodCompañia,
                                          string strCodProyecto,
                                          string strCodCentroGestor
                                            )
        {
            return objDs.Combo_ClaseGasto_Otros(strCodCompañia,
                                          strCodProyecto,
                                          strCodCentroGestor
                                            );
        }


        public DataSet Combo_ClaseGasto_Tarea(string strCodCompañia,
                                                  string strCodProyecto,
                                                  string strCodCentroGestor
                                                    )
        {
            return objDs.Combo_ClaseGasto_Tarea( strCodCompañia,
                                           strCodProyecto,
                                           strCodCentroGestor
                                                    );
        }

        public Model.Componente Recupera_Componente_Codigo( string strCodEmpresa, string strCodComponente )
        {
            return objDs.Recupera_Componente_Codigo( strCodEmpresa, strCodComponente );
        }

        public int Graba_Componente(Model.Componente obj)
        {
            return objDs.Graba_Componente(obj);
        }

        public int Modifica_Componente(Model.Componente obj)
        {
            return objDs.Modifica_Componente(obj);
        }

        public Boolean Elimina_Componente(int intIdComponente)
        {
            return objDs.Elimina_Componente(intIdComponente);
        }

        public DataSet Lista_Componente(string strCodEmpresa)
        {
            return objDs.Lista_Componente(strCodEmpresa);
        }


        public DataSet Lista_Proyecto_Componente(string strCodEmpresa,
                                                 string strCodProyecto)
        {
            return objDs.Lista_Proyecto_Componente(strCodEmpresa,
                                                          strCodProyecto
                                                         );
        }

        public Boolean Graba_Proyecto_Componente(string strCodEmpresa,
                                                string strCodProyecto,
                                                string strCodComponente)
        {
            return objDs.Graba_Proyecto_Componente(   strCodEmpresa,
                                                        strCodProyecto,
                                                        strCodComponente
                                                    );
        }


        public Boolean Elimina_Proyecto_Componente(string strCodEmpresa,
                                                string strCodProyecto,
                                                string strCodComponente
                                              )
        {
            return objDs.Elimina_Proyecto_Componente(strCodEmpresa,
                                                     strCodProyecto,
                                                     strCodComponente
                                                   );
        }

        public DataSet Ayuda_ClaseGasto(string strCodEmpresa)
        {
            return objDs.Ayuda_ClaseGasto(strCodEmpresa);
        }

        public DataSet Ayuda_ClaseIngreso()
        {
            return objDs.Ayuda_ClaseIngreso();
        }

        public DataSet Combo_ClaseIngreso()
        {
            return objDs.Combo_ClaseIngreso();
        }

        public DataSet Combo_TipoFormulacion()
        {
            return objDs.Combo_TipoFormulacion();
        }


        public DataSet Combo_MetodoDistribucion()
        {
            return objDs.Combo_MetodoDistribucion();
        }
        public DataSet Ayuda_MetodoDistribucion()
        {
            return objDs.Ayuda_MetodoDistribucion();
        }
        #endregion

        #region Logistica

        public DataSet Ayuda_ProcesoLogistico_CentroGestor(string strCodCentroGestor, string strCodEmpleado)
        {
            return objDs.Ayuda_ProcesoLogistico_CentroGestor(strCodCentroGestor, strCodEmpleado);
        }
        public DataSet Lista_Proyecto_SaldoAñoAnterior(string strCodCompañia,
                                                        string strCodProyecto,
                                                        string strCodCentroGestor,
                                                        string strCodCentroCosto,
                                                        double dblImporte,
                                                        string strOrdenesElegidas
                             )
        {
            return objDs.Lista_Proyecto_SaldoAñoAnterior(strCodCompañia,
                                                    strCodProyecto,
                                                    strCodCentroGestor,
                                                    strCodCentroCosto,
                                                    dblImporte,
                                                    strOrdenesElegidas
                             );
        }

        public DataSet Lista_Proyecto_SaldoAñoAnterior_Clasificador(string strCodCompañia,
                                                                    string strCodClasificador,
                                                                    double dblImporte,
                                                                    string strOrdenesElegidas
                                                                  )
        {
            return objDs.Lista_Proyecto_SaldoAñoAnterior_Clasificador( strCodCompañia,
                                                                 strCodClasificador,
                                                                 dblImporte,
                                                                 strOrdenesElegidas
                                                                  );
        }


        public DataSet Lista_Proyecto_IncorporaSaldoAñoAnterior_OS(string strCodCompañia,
                                                                    string strCodProyecto,
                                                                    string strCodCentroGestor,
                                                                    string strCodCentroCosto,
                                                                    string strNumeroOrden
                                                                  )
        {
            return objDs.Lista_Proyecto_IncorporaSaldoAñoAnterior_OS( strCodCompañia,
                                                                strCodProyecto,
                                                                strCodCentroGestor,
                                                                strCodCentroCosto,
                                                                strNumeroOrden
                                                                  );
        }

        public DataSet Lista_Proyecto_IncorporaSaldoAñoAnterior_OC(string strCodCompañia,
                                                                    string strCodProyecto,
                                                                    string strCodCentroGestor,
                                                                    string strCodCentroCosto,
                                                                    string strNumeroOrden
                                                                  )
        {
            return objDs.Lista_Proyecto_IncorporaSaldoAñoAnterior_OC( strCodCompañia,
                                                                     strCodProyecto,
                                                                     strCodCentroGestor,
                                                                     strCodCentroCosto,
                                                                     strNumeroOrden
                                                                  );
        }


        public DataSet Lista_Proyecto_IncorporaSaldoAñoAnterior_OS_Clasificador(string strCodCompañia,
                                                                    string strCodClasificador,
                                                                    string strCodCentroGestor,
                                                                    string strCodCentroCosto,
                                                                    string strNumeroOrden
                                                                  )
        {
            return objDs.Lista_Proyecto_IncorporaSaldoAñoAnterior_OS_Clasificador(strCodCompañia,
                                                                     strCodClasificador,
                                                                     strCodCentroGestor,
                                                                     strCodCentroCosto,
                                                                     strNumeroOrden
                                                                  );
        }

        public DataSet Lista_Proyecto_IncorporaSaldoAñoAnterior_OC_Clasificador(string strCodCompañia,
                                                                    string strCodClasificador,
                                                                    string strCodCentroGestor,
                                                                    string strCodCentroCosto,
                                                                    string strNumeroOrden
                                                                  )
        {
            return objDs.Lista_Proyecto_IncorporaSaldoAñoAnterior_OC_Clasificador( strCodCompañia,
                                                                     strCodClasificador,
                                                                     strCodCentroGestor,
                                                                     strCodCentroCosto,
                                                                     strNumeroOrden
                                                                  );
        }

        public DataSet Lista_Conformidad_Pago(string strCodCompañia,
                                string strTipoOrden,
                                string strNumeroOrden
                             )
        {
            return objDs.Lista_Conformidad_Pago( strCodCompañia,
                                 strTipoOrden,
                                 strNumeroOrden
                             );
        }

        public DataSet Formato_Conformidad(string strCodCompañia,
                        string strNumConformidad,
                        string strTipoOrden,
                        string strNumOrden
                     )
        {
            return objDs.Formato_Conformidad(strCodCompañia,
                         strNumConformidad,
                         strTipoOrden,
                         strNumOrden
                     );
        }

        public DataSet Combo_UnidadMedida()
        {
            return objDs.Combo_UnidadMedida();
        }

        public DataSet Ayuda_UnidadMedida()
        {
            return objDs.Ayuda_UnidadMedida();
        }

        #endregion

        #region Gestion
        public DataSet Combo_Prioridad()
        {
            return objDs.Combo_Prioridad();
        }
        #endregion

        #region Patrimonio  
        public DataSet Ayuda_Marca()
        {
            return objDs.Ayuda_Marca();
        }

        public DataSet Ayuda_Color()
        {
            return objDs.Ayuda_Color();
        }

        public DataSet Ayuda_TipoDocumento(string strCodModulo)
        {
            return objDs.Ayuda_TipoDocumento( strCodModulo);
        }

        public DataSet Ayuda_Segmento()
        {
            return objDs.Ayuda_Segmento();
        }

        public DataSet Combo_Segmento_Sin_Almacen()
        {
            return objDs.Combo_Segmento_Sin_Almacen();
        }

        public DataSet Ayuda_Centro()
        {
            return objDs.Ayuda_Centro();
        }

        public DataSet Combo_Centro()
        {
            return objDs.Combo_Centro();
        }

        public DataSet Ayuda_Emplazamiento()
        {
            return objDs.Ayuda_Emplazamiento();
        }
        #endregion

        #region Aeropuerto
        public Model.Aeropuerto Recupera_msto_Aeropuerto_Codigo(string strCodAeropuerto)
        {
            return objDs.Recupera_msto_Aeropuerto_Codigo(strCodAeropuerto);
        }

        public DataSet Ayuda_msto_Aeropuerto()
        {
            return objDs.Ayuda_msto_Aeropuerto();
        }

        #endregion

        #region ClaseDocumento
        public Model.ClaseDocumento Recupera_ctrl_ClaseDocumento_Codigo(string strCodClaseDocumento)
        {
            return objDs.Recupera_ctrl_ClaseDocumento_Codigo( strCodClaseDocumento);
        }

        public Model.ClaseDocumento Recupera_ctrl_ClaseDocumento(int intIdDocumento)
        {
            return objDs.Recupera_ctrl_ClaseDocumento( intIdDocumento);
        }
        public DataSet Ayuda_ctrl_ClaseDocumento()
        {
            return objDs.Ayuda_ctrl_ClaseDocumento();
        }

        public int Graba_ctrl_ClaseDocumento(Model.ClaseDocumento objClaseDocumento)
        {
            return objDs.Graba_ctrl_ClaseDocumento( objClaseDocumento);
        }

        public int Modifica_ctrl_ClaseDocumento(Model.ClaseDocumento objClaseDocumento)
        {
            return objDs.Modifica_ctrl_ClaseDocumento( objClaseDocumento);
        }

        public bool Elimina_ctrl_ClaseDocumento(int intIdClaseDocumento)
        {
            return objDs.Elimina_ctrl_ClaseDocumento( intIdClaseDocumento);
        }

        public DataSet Lista_ctrl_ClaseDocumento()
        {
            return objDs.Lista_ctrl_ClaseDocumento();
        }

        #endregion

        #region TipoAcumulador
        public DataSet Ayuda_TipoAcumulador()
        {
            return objDs.Ayuda_TipoAcumulador();
        }
        public DataSet Lista_TipoAcumulador()
        {
            return objDs.Lista_TipoAcumulador();
        }

        public DataSet Naturaleza_TipoAcumulador()
        {
            return objDs.Naturaleza_TipoAcumulador();
        }

        public DataSet Combo_TipoAcumulador_Reporte()
        {
            return objDs.Combo_TipoAcumulador_Reporte();
        }

        public DataSet Combo_TipoAcumulador()
        {
            return objDs.Combo_TipoAcumulador();
        }
        public Model.TipoAcumulador Recupera_TipoAcumulador(int intIdTipoAcumulador)
        {
            return objDs.Recupera_TipoAcumulador( intIdTipoAcumulador);
        }

        public Model.TipoAcumulador Recupera_TipoAcumulador_codigo(string strCodTipoAcumulador)
        {
            return objDs.Recupera_TipoAcumulador_codigo( strCodTipoAcumulador);
        }
        public int Graba_TipoAcumulador(Model.TipoAcumulador obj)
        {
            return objDs.Graba_TipoAcumulador( obj);
        }
        public int Modifica_TipoAcumulador(Model.TipoAcumulador obj)
        {
            return objDs.Modifica_TipoAcumulador( obj);
        }

        public bool Elimina_TipoAcumulador(int intIdTipoAcumulador)
        {
            return objDs.Elimina_TipoAcumulador( intIdTipoAcumulador);
        }

        #endregion

        #region TipoRecurso
        public DataSet Ayuda_TipoRecurso()
        {
            return objDs.Ayuda_TipoRecurso();
        }
        public DataSet Lista_TipoRecurso()
        {
            return objDs.Lista_TipoRecurso();
        }

        public DataSet Naturaleza_TipoRecurso()
        {
            return objDs.Naturaleza_TipoRecurso();
        }

        public DataSet Combo_TipoRecurso_Reporte()
        {
            return objDs.Combo_TipoRecurso_Reporte();
        }

        public DataSet Combo_TipoRecurso()
        {
            return objDs.Combo_TipoRecurso();
        }
        public Model.TipoRecurso Recupera_TipoRecurso(int intIdTipoRecurso)
        {
            return objDs.Recupera_TipoRecurso( intIdTipoRecurso);
        }

        public Model.TipoRecurso Recupera_TipoRecurso_codigo(string strCodTipoRecurso)
        {
            return objDs.Recupera_TipoRecurso_codigo( strCodTipoRecurso);
        }
        public int Graba_TipoRecurso(Model.TipoRecurso obj)
        {
            return objDs.Graba_TipoRecurso( obj);
        }
        public int Modifica_TipoRecurso(Model.TipoRecurso obj)
        {
            return objDs.Modifica_TipoRecurso( obj);
        }

        public bool Elimina_TipoRecurso(int intIdTipoRecurso)
        {
            return objDs.Elimina_TipoRecurso( intIdTipoRecurso);
        }

        #endregion

        #region TipoTasa
        public DataSet Ayuda_TipoTasa()
        {
            return objDs.Ayuda_TipoTasa();
        }
        public DataSet Lista_TipoTasa()
        {
            return objDs.Lista_TipoTasa();
        }

        public DataSet Naturaleza_TipoTasa()
        {
            return objDs.Naturaleza_TipoTasa();
        }

        public DataSet Combo_TipoTasa_Reporte()
        {
            return objDs.Combo_TipoTasa_Reporte();
        }

        public DataSet Combo_TipoTasa()
        {
            return objDs.Combo_TipoTasa();
        }
        public Model.TipoTasa Recupera_TipoTasa(int intIdTipoTasa)
        {
            return objDs.Recupera_TipoTasa( intIdTipoTasa);
        }

        public Model.TipoTasa Recupera_TipoTasa_codigo(string strCodTipoTasa)
        {
            return objDs.Recupera_TipoTasa_codigo( strCodTipoTasa);
        }
        public int Graba_TipoTasa(Model.TipoTasa obj)
        {
            return objDs.Graba_TipoTasa( obj);
        }
        public int Modifica_TipoTasa(Model.TipoTasa obj)
        {
            return objDs.Modifica_TipoTasa( obj);
        }

        public bool Elimina_TipoTasa(int intIdTipoTasa)
        {
            return objDs.Elimina_TipoTasa( intIdTipoTasa);
        }

        #endregion

        #region TipoVoucher
        public DataSet Combo_TipoVoucher()
        {
            return objDs.Combo_TipoVoucher();
        }

        #endregion

        #region TipoDocumento
        public DataSet Combo_TipoDocumento()
        {
            return objDs.Combo_TipoDocumento();
        }
        public DataSet Combo_ctrl_TipoDocumento_DataTable(int intTipoTramite)
        {
            return objDs.Combo_ctrl_TipoDocumento_DataTable( intTipoTramite);
        }

        public string Recupera_mvto_CeGes_Sigla_Correlativo(string strSigla,
                                                             string strCodCeGes,
                                                             int intTipoDocumento,
                                                             int intAñoProceso)
        {
            return objDs.Recupera_mvto_CeGes_Sigla_Correlativo( strSigla,
                                                           strCodCeGes,
                                                           intTipoDocumento,
                                                            intAñoProceso);
        }

        public Model.TipoDocumento Recupera_TipoDocumento(int intTipoDocumento)
        {
            return objDs.Recupera_TipoDocumento( intTipoDocumento);
        }

        #endregion

        #region TipoDocumentoIdentidad
        public DataSet Combo_TipoDocumentoIdentidad_DataTable()
        {
            return objDs.Combo_TipoDocumentoIdentidad_DataTable();
        }

        public Model.TipoDocumentoIdentidad Recupera_TipoDocumentoIdentidad(int intTipoDocumentoIdentidad)
        {
            return objDs.Recupera_TipoDocumentoIdentidad( intTipoDocumentoIdentidad);
        }

        #endregion

        #region TipoContabilidad
        public DataSet Combo_TipoContabilidad()
        {
            return objDs.Combo_TipoContabilidad();
        }

        #endregion

        #region PeriodoProcesoContabilidad
        public DataSet Combo_PeriodoProceso_DataTable()
        {
            return objDs.Combo_PeriodoProceso_DataTable();
        }

        #endregion

        #region GrupoRecurso
        public DataSet Ayuda_GrupoRecurso()
        {
            return objDs.Ayuda_GrupoRecurso();
        }
        public DataSet Lista_GrupoRecurso()
        {
            return objDs.Lista_GrupoRecurso();
        }

        public DataSet Naturaleza_GrupoRecurso()
        {
            return objDs.Naturaleza_GrupoRecurso();
        }

        public DataSet Combo_GrupoRecurso_Reporte()
        {
            return objDs.Combo_GrupoRecurso_Reporte();
        }

        public DataSet Combo_GrupoRecurso()
        {
            return objDs.Combo_GrupoRecurso();
        }
        public Model.GrupoRecurso Recupera_GrupoRecurso(int intIdGrupoRecurso)
        {
            return objDs.Recupera_GrupoRecurso( intIdGrupoRecurso);
        }

        public Model.GrupoRecurso Recupera_GrupoRecurso_codigo(string strCodGrupoRecurso)
        {
            return objDs.Recupera_GrupoRecurso_codigo( strCodGrupoRecurso);
        }
        public int Graba_GrupoRecurso(Model.GrupoRecurso obj)
        {
            return objDs.Graba_GrupoRecurso( obj);
        }
        public int Modifica_GrupoRecurso(Model.GrupoRecurso obj)
        {
            return objDs.Modifica_GrupoRecurso( obj);
        }

        public bool Elimina_GrupoRecurso(int intIdGrupoRecurso)
        {
            return objDs.Elimina_GrupoRecurso( intIdGrupoRecurso);
        }

        #endregion

        #region Feriado
        public System.Data.DataSet Lista_Feriado_DataTable(int intAñoProceso)
        {
            return objDs.Lista_Feriado_DataTable( intAñoProceso);
        }

        public Model.Feriado Recupera_Feriado(int intAñoProceso,
                                                        string cFecha)
        {
            return objDs.Recupera_Feriado( intAñoProceso,
                                                        cFecha);
        }

        #endregion

        #region UbicacionGeografica
        public DataSet Ayuda_UbicacionGeografica()
        {
            return objDs.Ayuda_UbicacionGeografica();
        }

        public Model.Ubigeo Recupera_msto_Ubigeo_Codigo(string strCodUbigeo)
        {
            return objDs.Recupera_msto_Ubigeo_Codigo(strCodUbigeo);
        }

        public DataSet Ayuda_msto_Ubigeo()
        {
            return objDs.Ayuda_msto_Ubigeo();
        }


        #endregion

        #endregion

        #region LOGISTICA
        #region "ProcesoLogistico Cabecera Requerimiento"
        public Model.Requerimiento_Cabecera graba_ProcesoLogistico_Requerimiento_Cabecera(string strAñoProceso,
                                                                                            string strNumProcedimiento,
                                                                                            string strCodEmpleado
                                                                                         )
        {
            return objDs.graba_ProcesoLogistico_Requerimiento_Cabecera(strAñoProceso,
                                                                  strNumProcedimiento,
                                                                   strCodEmpleado
                                                                    );
        }

        public Boolean graba_ProcesoLogistico_Requerimiento_Detalle(int intIdRequerimiento_Cabecera,
                                                                    int intIdRequerimiento_Detalle,
                                                                    double dblImporte,
                                                                    string strNumProcedimiento
                                                                    )
        {
            return objDs.graba_ProcesoLogistico_Requerimiento_Detalle( intIdRequerimiento_Cabecera,
                                                                   intIdRequerimiento_Detalle,
                                                                   dblImporte,
                                                                   strNumProcedimiento
                                                                    );
        }

        #endregion
        
        #region "Reportes"

        public DataSet lista_ContratoConformidad_Formato(string strCodCompañia,
                                                           string strCodAdministradorContrato,
                                                           string strCodCentrogestor
                                                         )
        {
            return objDs.lista_ContratoConformidad_Formato(strCodCompañia,
                                                     strCodAdministradorContrato,
                                                     strCodCentrogestor
                                                         );
        }

        public DataSet formato_ContratoConformidad_Formato(string strCodCompañia,
                                                   string strNroContrato,
                                                   string strNroConformidad
                                                 )
        {
            return objDs.formato_ContratoConformidad_Formato( strCodCompañia,
                                                    strNroContrato,
                                                    strNroConformidad
                                                 );
        }


        public DataSet reporte_Conformidad_Pantalla(string strCodCompañia,
                                                    string strNroContrato,
                                                    string strNroConformidad
                                                   )
        {
            return objDs.reporte_Conformidad_Pantalla( strCodCompañia,
                                                 strNroContrato,
                                                 strNroConformidad
                                                   );
        }

        public DataSet reporte_Conformidad(string strCodCompañia,
                                         string strNroContrato
                                       )
        {
            return objDs.reporte_Conformidad( strCodCompañia,
                                        strNroContrato
                                       );
        }
        public DataSet reporte_Contrato(string strCodCompañia,
                                         string strPeriodoInicial,
                                         string strPeriodoFinal,
                                         string strCodProveedor,
                                         string strCodProyecto,
                                         int intEstadoContrato
                                       )
        {
            return objDs.reporte_Contrato( strCodCompañia,
                                     strPeriodoInicial,
                                     strPeriodoFinal,
                                     strCodProveedor,
                                     strCodProyecto,
                                     intEstadoContrato
                                       );
        }
        #endregion

        #region "BuenaPro"
        public DataSet ayuda_BuenaPro(string strCodCompañia)
        {
            return objDs.ayuda_BuenaPro(strCodCompañia);
        }
        public Model.BuenaPro recupera_BuenaPro(string strCodCompañia,
                                                string strNroProceso
                                               )
        {
            return objDs.recupera_BuenaPro(strCodCompañia,
                                                 strNroProceso
                                               );
        }
    #endregion

        #region "Contrato"

    public DataSet ayuda_Contrato(string strCodCompañia,
                                 string strPeriodoInicial,
                                 string strPeriodoFinal,
                                 string strCodProveedor,
                                 string strCodProyecto,
                                 int intEstadoContrato
                               )
        {
            return objDs.ayuda_Contrato( strCodCompañia,
                                  strPeriodoInicial,
                                  strPeriodoFinal,
                                  strCodProveedor,
                                  strCodProyecto,
                                 intEstadoContrato
                               );
        }

        public DataSet lista_Contrato_Proyecto_Detalle_Saldo(string strCodCompañia,
                                              string strNroContrato,
                                              string strCodFuenteDinanciamiento,
                                              string strCodProyecto
                                 )
        {
            return objDs.lista_Contrato_Proyecto_Detalle_Saldo( strCodCompañia,
                                               strNroContrato,
                                               strCodFuenteDinanciamiento,
                                               strCodProyecto
                                 );
        }

        public DataSet lista_Contrato_Proyecto_Saldo(string strCodCompañia,
                                                      string strNroContrato,
                                                      string strCodFuenteDinanciamiento,
                                                      double dblImporte
                                         )
        {
            return objDs.lista_Contrato_Proyecto_Saldo( strCodCompañia,
                                                  strNroContrato,
                                                  strCodFuenteDinanciamiento,
                                                  dblImporte
                                         );
        }

        public DataSet lista_Contrato_FuenteFinanciemiento_Saldo(string strCodCompañia,
                                           string strNroContrato
                                         )
        {
            return objDs.lista_Contrato_FuenteFinanciemiento_Saldo( strCodCompañia,
                                           strNroContrato
                                         );
        }


        public Model.ContratoCabecera recupera_Contrato(string strCodCompañia,
                                                          string strNroContrato
                                                         )
        {
            return objDs.recupera_Contrato(strCodCompañia,
                                     strNroContrato
                                                         );
        }


        public Model.ContratoCabecera graba_Contrato(Model.ContratoCabecera obj)
        {
            return objDs.graba_Contrato(obj);
        }

        public Model.ContratoCabecera modifica_Contrato(Model.ContratoCabecera obj,
                                                        string strCodAdministradorContrato_Anterior
                                                       )
        {
            return objDs.modifica_Contrato(obj,
                                     strCodAdministradorContrato_Anterior
                                                       );
        }

        public Model.ContratoCabecera modifica_Contrato_Proceso(Model.ContratoCabecera obj,
                                                string strCodAdministradorContrato_Anterior
                                               )
        {
            return objDs.modifica_Contrato_Proceso(obj,
                                     strCodAdministradorContrato_Anterior
                                                       );
        }

        public Boolean elimina_Contrato(Model.ContratoCabecera obj)
        {
            return objDs.elimina_Contrato(obj);
        }


        #endregion

        #region "Entidad Financiera"
        public DataSet ayuda_EntidadFinanciera(string strCodCompañia)
        {
            return objDs.ayuda_EntidadFinanciera(strCodCompañia);
        }
        #endregion

        #region "Tipo Observacion Adjunto"
        public DataSet combo_TipoObservacion_Adjunto(string strCodTipoArchivo)
        {
            return objDs.combo_TipoObservacion_Adjunto(strCodTipoArchivo);
        }
        #endregion

        #region "ClaseGarantia"
        public DataSet combo_ClaseGarantia()
        {
            return objDs.combo_ClaseGarantia();
        }

        public Model.ClaseGarantia recupera_ClaseGarantia_Codigo(string strCodClaseGarantia)
        {
            return objDs.recupera_ClaseGarantia_Codigo(strCodClaseGarantia);
        }

        #endregion

        #region "TipoGarantia"
        public DataSet combo_TipoGarantia()
        {
            return objDs.combo_TipoGarantia();
        }

        public Model.TipoGarantia recupera_TipoGarantia_Codigo(string strCodTipoGarantia)
        {
            return objDs.recupera_TipoGarantia_Codigo(strCodTipoGarantia);
        }

        #endregion

        #region "Parametro Logistica"
        public Model.ParametroLogistica Recupera_ParametroLogistica_Codigo(string strCodParametroLogistica)
        {
            return objDs.Recupera_ParametroLogistica_Codigo(strCodParametroLogistica);
        }
    #endregion

        #region "TipoContrato"
        public DataSet combo_TipoContrato()
        {
            return objDs.combo_TipoContrato();
        }

        public Model.TipoContrato recupera_TipoContrato_Codigo(string strCodTipoContrato)
        {
            return objDs.recupera_TipoContrato_Codigo(strCodTipoContrato);
        }

        #endregion

        #region "TipoAnticipo"
        public DataSet combo_TipoAnticipo()
        {
            return objDs.combo_TipoAnticipo();
        }

        public Model.TipoAnticipo recupera_TipoAnticipo_Codigo(string strCodTipoAnticipo)
        {
            return objDs.recupera_TipoAnticipo_Codigo(strCodTipoAnticipo);
        }

        #endregion

        #region "TipoDocumento"
        public DataSet combo_TipoDocumento(bool blnEsDocumentoTributario
                                           )
        {
            return objDs.combo_TipoDocumento(blnEsDocumentoTributario);
        }

        public DataSet combo_TipoDocumento_Filtro(bool blnEsDocumentoTributario,
                                                  string strFiltro
                                   )
        {
            return objDs.combo_TipoDocumento_Filtro( blnEsDocumentoTributario,
                                              strFiltro
                                   );
        }


        public Model.TipoDocumento recupera_TipoDocumento_Codigo(int intTipodocumento)
        {
            return objDs.recupera_TipoDocumento_Codigo(intTipodocumento);
        }

        #endregion

        #region "TipoImpuesto"
        public DataSet combo_TipoImpuesto()
        {
            return objDs.combo_TipoImpuesto();
        }

        public Model.TipoImpuesto recupera_TipoImpuesto_Codigo(string strCodTipoDocumento)
        {
            return objDs.recupera_TipoImpuesto_Codigo(strCodTipoDocumento);
        }

        #endregion

        #region "Conformidad"

        public Boolean firma_Conformidad(string strCodCompañia,
                                            string strCodCentroGestor,
                                            string strNroConformidad,
                                            string strCodEmpleado
                                        )
        {
            return objDs.firma_Conformidad( strCodCompañia,
                                      strCodCentroGestor,
                                      strNroConformidad,
                                      strCodEmpleado
                                        );
        }

        public DataSet lista_Conformidad_Adjuntos_Consulta(string strCodCompañia,
                                                   string strNroConformidad,
                                                   string strCodTipoAdjunto
                                                 )
        {
            return objDs.lista_Conformidad_Adjuntos_Consulta( strCodCompañia,
                                                    strNroConformidad,
                                                    strCodTipoAdjunto
                                                 );
        }
        public Model.Conformidad graba_Conformidad(Model.Conformidad obj)
        {
            return objDs.graba_Conformidad(obj);
        }

        public Model.ConformidadAdjunto graba_ConformidadAdjunto(Model.ConformidadAdjunto obj)
        {
            return objDs.graba_ConformidadAdjunto(obj);
        }
        public Model.ConformidadDocumentoTributario graba_ConformidadDocumentoTributario(Model.ConformidadDocumentoTributario obj)
        {
            return objDs.graba_ConformidadDocumentoTributario(obj);
        }
        public Model.ConformidadProyecto graba_ConformidadProyecto(Model.ConformidadProyecto obj)
        {
            return objDs.graba_ConformidadProyecto(obj);
        }

        public DataSet lista_Conformidad_Proyecto(string strCodCompañia,
                                                   string strNroContrato
                                                 )
        {
            return objDs.lista_Conformidad_Proyecto( strCodCompañia,
                                               strNroContrato
                                                 );
        }

        public Model.ConformidadPenalidad graba_ConformidadPenalidad(Model.ConformidadPenalidad obj
                                                  )
        {
            return objDs.graba_ConformidadPenalidad(obj);
        }

        public Model.Conformidadgarantia graba_ConformidadGarantia(Model.Conformidadgarantia obj
                                                  )
        {
            return objDs.graba_ConformidadGarantia( obj );
        }

        public Model.ConformidadRetencion graba_ConformidadRetencion(Model.ConformidadRetencion obj
                                          )
        {
            return objDs.graba_ConformidadRetencion(obj);
        }

        public Model.ConformidadAjustePolinomico graba_ConformidadAjustePolinomico(Model.ConformidadAjustePolinomico obj
                                  )
        {
            return objDs.graba_ConformidadAjustePolinomico(obj);
        }


        #endregion

        #region "Entregable"

        public DataSet lista_ContratoEntregable(string strCodCompañia,
                                                string strNroContrato
                                              )
        {
            return objDs.lista_ContratoEntregable( strCodCompañia,
                                              strNroContrato
                                              );
        }
        public Model.EntregableCabecera insertar_EntregableCabecera(Model.EntregableCabecera obj)
        {
            return objDs.insertar_EntregableCabecera(obj);
        }

        public bool modificar_EntregableCabecera(Model.EntregableCabecera obj)
        {
            return objDs.modificar_EntregableCabecera(obj);
        }

        public bool eliminar_EntregableCabecera(Model.EntregableCabecera obj)
        {
            return objDs.eliminar_EntregableCabecera( obj);
        }
        public Model.EntregableCabecera recupera_EntregableCabecera(int intIdEntregableCabecera)
        {
            return objDs.recupera_EntregableCabecera(intIdEntregableCabecera);
        }

        public Model.EntregableCabecera recupera_EntregableCabecera_Codigo(string strCodCompañia,
                                                                            string strNroContrato,
                                                                            string strNroEntregable
                                                                          )
        {
            return objDs.recupera_EntregableCabecera_Codigo(strCodCompañia,
                                                                            strNroContrato,
                                                                            strNroEntregable
                                                                          );
        }

        public DataSet lista_EntregableCabecera(string strCodCompañia,
                                                    string strNroContrato)
        {
            return objDs.lista_EntregableCabecera(strCodCompañia,
                                            strNroContrato);
        }

        public DataSet ayuda_EntregableCabecera(string strCodCompañia,
                                            string strNroContrato)
        {
            return objDs.ayuda_EntregableCabecera(strCodCompañia,
                                            strNroContrato);
        }

        #endregion

        #region "Adenda"

        public Model.adenda recupera_ContratoAdicional_Codigo(string strCodCompañia,
                                                              string strNroContrato,
                                                              string strCodAdenda
                                                             )
        {
            return objDs.recupera_ContratoAdicional_Codigo(strCodCompañia,
                                                              strNroContrato,
                                                               strCodAdenda
                                                             );
        }
        public Model.adenda recupera_ContratoAdicional(int intIdAdenda
                                                      )
        {
            return objDs.recupera_ContratoAdicional(intIdAdenda
                                                      );
        }
        public Model.adenda insertar_ContratoAdicional(Model.adenda obj)
        {
            return objDs.insertar_ContratoAdicional(obj);
        }

        public bool modificar_ContratoAdicional(Model.adenda obj)
        {
            return objDs.modificar_ContratoAdicional(obj);
        }

        public bool eliminar_ContratoAdicionl(Model.adenda obj)
        {
            return objDs.eliminar_ContratoAdicionl(obj);
        }
        public DataSet lista_ContratoAdicional(string strCodCompañia,
                                               string strNroContrato
                                              )
        {
            return objDs.lista_ContratoAdicional( strCodCompañia,
                                               strNroContrato
                                              );
        }
        #endregion

        #region "Anticipo"

        public Model.ContratoAnticipo recupera_ContratoAnticipo_Codigo(string strCodCompañia,
                                                              string strNroContrato,
                                                              string strCodAnticipo
                                                             )
        {
            return objDs.recupera_ContratoAnticipo_Codigo(strCodCompañia,
                                                               strNroContrato,
                                                               strCodAnticipo
                                                             );
        }
        public Model.ContratoAnticipo recupera_ContratoAnticipo(int intIdAnticipo
                                                      )
        {
            return objDs.recupera_ContratoAnticipo(intIdAnticipo);
        }
        public Model.ContratoAnticipo insertar_ContratoAnticipo(Model.ContratoAnticipo obj)
        {
            return objDs.insertar_ContratoAnticipo(obj);
        }

        public bool modificar_ContratoAnticipo(Model.ContratoAnticipo obj)
        {
            return objDs.modificar_ContratoAnticipo(obj);
        }

        public bool eliminar_ContratoAnticipo(Model.ContratoAnticipo obj)
        {
            return objDs.eliminar_ContratoAnticipo(obj);
        }
        public DataSet lista_ContratoAnticipo(string strCodCompañia,
                                               string strNroContrato
                                              )
        {
            return objDs.lista_ContratoAnticipo( strCodCompañia,
                                                strNroContrato
                                              );
        }
        #endregion

        #region "Tipo Adicional"
        public DataSet combo_TipoAdicional()
        {
            return objDs.combo_TipoAdicional();
        }
        #endregion

        #region "Garantia"

        public DataSet ayuda_ContratoGarantia(string strCodCompañia,
                                               string strNroContrato
                                             )
        {
            return objDs.ayuda_ContratoGarantia( strCodCompañia,
                                           strNroContrato
                                             );
        }
        public DataSet lista_ContratoGarantia(string strCodCompañia,
                                                string strNroContrato
                                             )
        {
            return objDs.lista_ContratoGarantia( strCodCompañia,
                                           strNroContrato
                                             );
        }

        public Model.ContratoGarantia recupera_ContratoGarantia_Codigo(string strCodCompañia,
                                                                string strNroContrato,
                                                                string strNroGarantia
                                                               )
        {
            return objDs.recupera_ContratoGarantia_Codigo(strCodCompañia,
                                                    strNroContrato,
                                                    strNroGarantia
                                                               );
        }
        public Model.ContratoGarantia recupera_ContratoGarantia(int intIdContrato_Garantia)
        {
            return objDs.recupera_ContratoGarantia(intIdContrato_Garantia);
        }
        public Model.ContratoGarantia graba_ContratoGarantia(Model.ContratoGarantia obj
                                                            )
        {
            return objDs.graba_ContratoGarantia(obj);
        }

        public Model.ContratoGarantia modifica_ContratoGarantia(Model.ContratoGarantia obj
                                                    )
        {
            return objDs.modifica_ContratoGarantia(obj);
        }
        public Boolean elimina_ContratoGarantia(Model.ContratoGarantia obj
                                            )
        {
            return objDs.elimina_ContratoGarantia(obj);
        }


        #endregion

        #region "Inicio Actividad"

        public DataSet lista_ContratoInicioActividad(string strCodCompañia,
                                                string strNroContrato
                                             )
        {
            return objDs.lista_ContratoInicioActividad( strCodCompañia,
                                                 strNroContrato
                                             );
        }

        public Model.ContratoInicioActividad graba_ContratoInicioActividad(Model.ContratoInicioActividad obj
                                                            )
        {
            return objDs.graba_ContratoInicioActividad(obj);
        }

        public Model.ContratoInicioActividad modifica_ContratoInicioActividad(Model.ContratoInicioActividad obj
                                                            )
        {
            return objDs.modifica_ContratoInicioActividad(obj);
        }
        public Boolean elimina_ContratoInicioActividad(Model.ContratoInicioActividad obj
                                            )
        {
            return objDs.elimina_ContratoInicioActividad(obj);
        }


        #endregion

        #endregion


        #region "Viatico"
        public List<Model.Viatico> recupera_Viatico_App(string strCodEmpleado)
        {
            return objDs.recupera_Viatico_App( strCodEmpleado);
        }

        private Model.Viatico GetViaticoDataTableRow(DataRow dr)
        {
            return GetViaticoDataTableRow(dr);
        }

        public Model.Viatico_Paso graba_Viatico_Firma_App(string strNumeroProceso)
        {
            return objDs.graba_Viatico_Firma_App( strNumeroProceso);
        }


        private Model.Viatico_Paso GetViaticoPasoDataTableRow(DataRow dr)
        {
            return GetViaticoPasoDataTableRow(dr);
        }


        #endregion


        #region "CajaChica"
        public List<Model.CajaChica> recupera_CajaChica_App(string strCodEmpleado)
        {
            return objDs.recupera_CajaChica_App( strCodEmpleado);
        }

        private Model.CajaChica GetCajaChicaDataTableRow(DataRow dr)
        {
            return GetCajaChicaDataTableRow( dr);
        }

        public Model.CajaChica_Paso graba_CajaChica_Firma_App(string strNumeroProceso)
        {
            return objDs.graba_CajaChica_Firma_App( strNumeroProceso);
        }

        private Model.CajaChica_Paso GetCajaChicaPasoDataTableRow(DataRow dr)
        {
            return GetCajaChicaPasoDataTableRow(dr);
        }


        #endregion


        #region "FichaPresupuestal"
        public List<Model.FichaPresupuestal> recupera_FichaPresupuestal_App(string strCodEmpresa)
        {
            return objDs.recupera_FichaPresupuestal_App( strCodEmpresa);
        }

        private Model.FichaPresupuestal GetFichaDataTableRow(DataRow dr)
        {
            return GetFichaDataTableRow( dr);
        }

        public Model.FichaPresupuestal_Paso graba_FichaPresupuestal_Firma_App(string strNumProcedimiento)
        {
            return objDs.graba_FichaPresupuestal_Firma_App( strNumProcedimiento);
        }


        private Model.FichaPresupuestal_Paso GetPasoDataTableRow(DataRow dr)
        {
            return GetPasoDataTableRow( dr);
        }


        #endregion

        #region "ProcesoLogistico_Aprobacion"

        public int Elimina_PAC(int Id)
        {
            return objDs.Elimina_PAC(Id);
        }
        public Model.Pac_HojaTrabajo Graba_PAC(Model.Pac_HojaTrabajo obj)
        {
            return objDs.Graba_PAC(obj);
        }

        public Model.Pac_HojaTrabajo Modifica_PAC(Model.Pac_HojaTrabajo obj)
        {
            return objDs.Modifica_PAC(obj);
        }
        public Model.Pac_HojaTrabajo Recupera_PAC(string strCodEmpresa,
                                 string strCodPAC
                                )
        {
            return objDs.Recupera_PAC(strCodEmpresa, strCodPAC);
        }

        public Model.SolicitudAdquisicion Recupera_SolicitudAdquisicion(int intIdSolicitud
                                )
        {
            return objDs.Recupera_SolicitudAdquisicion(intIdSolicitud);
        }
        public DataSet Lista_PAC(string strCodEmpresa,
                      string strAñoProceso
                     )
        {
            return objDs.Lista_PAC(strCodEmpresa, strAñoProceso);
        }

        public DataSet Lista_PAC_SolicitudAdquisicion(string strCodEmpresa,
                      string strAñoProceso
                     )
        {
            return objDs.Lista_PAC_SolicitudAdquisicion(strCodEmpresa, strAñoProceso);
        }
        public DataSet lista_ProcesoLogistico_CreaProceso_Detalle(string strNumRequerimiento)
        {
            return objDs.lista_ProcesoLogistico_CreaProceso_Detalle( strNumRequerimiento);
        }
        public DataSet lista_ProcesoLogistico_CreaProceso(string strCodOperadorLogistico)
        {
            return objDs.lista_ProcesoLogistico_CreaProceso( strCodOperadorLogistico);
        }

        public DataSet ayuda_ProcesoLogistico(string strCodEmpresa,
                                        string strAñoProceso
                                    )
        {
            return objDs.ayuda_ProcesoLogistico(strCodEmpresa,
                                                strAñoProceso
                                                );
        }
        public DataSet lista_ProcesoLogistico_Aprobacion(string strEstado)
        {
            return objDs.lista_ProcesoLogistico_Aprobacion( strEstado);
        }

        public bool graba_procesoLogistico_Aprobacion_DescarteFirma(string strNumRequerimiento,
                                                                      string strCodMotivoDescarte,
                                                                      DateTime dtpFecDescarte,
                                                                      string strNotaDescarte,
                                                                      string strCodEmpleado
                                                                    )
        {
            return objDs.graba_procesoLogistico_Aprobacion_DescarteFirma( strNumRequerimiento,
                                                                     strCodMotivoDescarte,
                                                                      dtpFecDescarte,
                                                                       strNotaDescarte,
                                                                       strCodEmpleado
                                                                    );
        }

        public bool graba_procesoLogistico_Aprobacion_Firma(string strCodCentroGestor,
                                                                string strPaso,
                                                                string strNumRequerimiento,
                                                                string strCodEmpleado,
                                                                string strCodOperadorLogistico,
                                                                string strEsUnProceso,
                                                                string strCodPac
                                                            )
        {
            return objDs.graba_procesoLogistico_Aprobacion_Firma( strCodCentroGestor,
                                                             strPaso,
                                                              strNumRequerimiento,
                                                              strCodEmpleado,
                                                               strCodOperadorLogistico,
                                                               strEsUnProceso,
                                                               strCodPac
                                                            );
        }


        #endregion

        #region "ProcesoLogistico_FichaPresupuestal"
        public Boolean graba_ProcesoLogistico_FichaPresupuestal(Model.ProcesoLogistico_FichaPresupuestal obj)
        {
            return objDs.graba_ProcesoLogistico_FichaPresupuestal( obj);
        }
        #endregion

        #region "ValorEstimado"

        public Model.ValorEstimado recupera_ValorEstimado_Codigo(string strCodEmpresa,
                                                                 string strAñoProceso,
                                                                 string strNumProcedimiento
                                                                )
        {
            return objDs.recupera_ValorEstimado_Codigo( strCodEmpresa,
                                                  strAñoProceso,
                                                  strNumProcedimiento
                                                                );
        }
        public Model.ValorEstimado recupera_ValorEstimado(int intIdValorEstimado)
        {
            return objDs.recupera_ValorEstimado( intIdValorEstimado);
        }

        public DataSet lista_ValorEstimado(string strCodEmpresa,
                                            string strAñoProceso,
                                         string strNumProcedimiento
                                        )
        {
            return objDs.lista_ValorEstimado( strCodEmpresa,
                                        strAñoProceso,
                                        strNumProcedimiento
                                        );
        }

        public bool graba_ValorEstimado_Cronograma(Model.ValorEstimado_Cronograma obj)
        {
            return objDs.graba_ValorEstimado_Cronograma(obj);
        }

        public int graba_ValorEstimado(Model.ValorEstimado obj)
        {
            return objDs.graba_ValorEstimado( obj);
        }

        public Boolean modifica_ValorEstimado(Model.ValorEstimado obj)
        {
            return objDs.modifica_ValorEstimado(obj);
        }

        public Boolean elimina_ValorEstimado(int intIdValorEstimado)
        {
            return objDs.elimina_ValorEstimado(intIdValorEstimado);
        }

        #endregion

        #region "Proveedor"

        public DataSet ayuda_Proveedor_Invitacion(string strCodEmpresa,
                                                  string strNumProcedimiento,
                                                  string strNumRequerimiento
                                                 )
        {
            return objDs.ayuda_Proveedor_Invitacion( strCodEmpresa,
                                               strNumProcedimiento,
                                               strNumRequerimiento
                                                 );
        }
        public DataSet ayuda_Proveedor(string strCodEmpresa)
        {
            return objDs.ayuda_Proveedor(strCodEmpresa);
        }

        public Model.Proveedor recupera_Proveedor_Codigo(string strCodEmpresa,
                                                 string strCodProveedor
                                                )
        {
            return objDs.recupera_Proveedor_Codigo( strCodEmpresa,
                                              strCodProveedor
                                                );
        }

        #endregion

        #region "Invitacion"

        public DataSet ayuda_Invitacion(string strCodEmpresa,
                                         string strNumProcedimiento,
                                         string strNumRequerimiento
                                        )
        {
            return objDs.ayuda_Invitacion( strCodEmpresa,
                                     strNumProcedimiento,
                                     strNumRequerimiento
                                        );
        }
        public Model.Invitacion recupera_Invitacion(int intIdInvitacion)
        {
            return objDs.recupera_Invitacion(intIdInvitacion);
        }

        public DataSet lista_Invitacion(string strCodEmpresa,
                                         string strNumProcedimiento,
                                         string strNumRequerimiento
                                        )
        {
            return objDs.lista_Invitacion( strCodEmpresa,
                                     strNumProcedimiento,
                                     strNumRequerimiento
                                        );
        }

        public int graba_Invitacion(Model.Invitacion obj)
        {
            return objDs.graba_Invitacion(obj);
        }

        public Boolean modifica_Invitacion(Model.Invitacion obj)
        {
            return objDs.modifica_Invitacion(obj);
        }

        public Boolean elimina_Invitacion(int intIdInvitacion)
        {
            return objDs.elimina_Invitacion(intIdInvitacion);
        }

        #endregion

        #region "Cotizacion"

        public DataSet ayuda_Cotizacion(string strCodEmpresa,
                                         string strNumProcedimiento
                                        )
        {
            return objDs.ayuda_Cotizacion( strCodEmpresa,
                                     strNumProcedimiento
                                        );
        }
        public Model.Cotizacion recupera_Cotizacion(int intIdCotizacion)
        {
            return objDs.recupera_Cotizacion(intIdCotizacion);
        }

        public DataSet lista_Cotizacion(string strCodEmpresa,
                                         string strNumProcedimiento
                                        )
        {
            return objDs.lista_Cotizacion( strCodEmpresa,
                                     strNumProcedimiento
                                        );
        }

        public int graba_Cotizacion(Model.Cotizacion obj)
        {
            return objDs.graba_Cotizacion(obj);
        }

        public Boolean modifica_Cotizacion(Model.Cotizacion obj)
        {
            return objDs.modifica_Cotizacion(obj);
        }

        public Boolean elimina_Cotizacion(int intIdCotizacion)
        {
            return objDs.elimina_Cotizacion(intIdCotizacion);
        }

        #endregion

        #region "OperadorLogistico"
        public DataSet Ayuda_OperadorLogistico_Reemplazo(string strCodOperadorLogistico)
        {
            return objDs.Ayuda_OperadorLogistico_Reemplazo(strCodOperadorLogistico);
        }

        public DataSet Ayuda_OperadorLogistico()
        {
            return objDs.Ayuda_OperadorLogistico();
        }

        public DataSet Ayuda_OperadorLogistico_Jefatura(string strCodJefatura)
        {
            return objDs.Ayuda_OperadorLogistico_Jefatura(strCodJefatura);
        }
        public DataSet Lista_OperadorLogistico()
        {
            return objDs.Lista_OperadorLogistico();
        }

        public int Graba_OperadorLogistico(Model.OperadorLogistico obj)
        {
            return objDs.Graba_OperadorLogistico(obj);
        }

        public int Modifica_OperadorLogistico(Model.OperadorLogistico obj)
        {
            return objDs.Modifica_OperadorLogistico(obj);
        }

        public bool Elimina_OperadorLogistico(int intIdEmpleado)
        {
            return objDs.Elimina_OperadorLogistico(intIdEmpleado);
        }

        #endregion

        #region "CargoComite"
        public DataSet Combo_CargoComite()
        {
            return objDs.Combo_CargoComite();
        }

        #endregion

        #region "TipoIntegrante"
        public DataSet Combo_TipoIntegrante()
        {
            return objDs.Combo_TipoIntegrante();
        }

        #endregion

        #region "TipoPaso"
        public DataSet Combo_TipoPaso()
        {
            return objDs.Combo_TipoPaso();
        }

        public DataSet Ayuda_TipoPaso()
        {
            return objDs.Ayuda_TipoPaso();
        }

        #endregion

        #region "TipoComite"
        public DataSet Combo_TipoComite()
        {
            return objDs.Combo_TipoPaso();
        }

        #endregion

        #region "TipoPlantilla_Paso"
        public DataSet Combo_TipoPlantilla()
        {
            return objDs.Combo_TipoPlantilla();
        }

        public DataSet Ayuda_TipoPlantilla()
        {
            return objDs.Ayuda_TipoPlantilla();
        }

        public Model.TipoPlantillaPaso Recupera_TipoPlantilla(int intIdTipoPlantilla
                                                             )
        {
            return objDs.Recupera_TipoPlantilla(intIdTipoPlantilla
                                                             );
        }

        public Model.TipoPlantillaPaso Recupera_TipoPlantilla_Codigo(string strCodTipoPlantilla
                                                             )
        {
            return objDs.Recupera_TipoPlantilla_Codigo(strCodTipoPlantilla
                                                             );
        }

        public int Graba_TipoPlantilla(Model.TipoPlantillaPaso obj
                                                     )
        {
            return objDs.Graba_TipoPlantilla(obj);
        }

        public int Modifica_TipoPlantilla(Model.TipoPlantillaPaso obj
                                                     )
        {
            return objDs.Modifica_TipoPlantilla(obj
                                                     );
        }

        public Boolean Elimina_TipoPlantilla(int intIdTipoPlantilla)
        {
            return objDs.Elimina_TipoPlantilla(intIdTipoPlantilla);
        }

        public DataSet Lista_TipoPlantilla()
        {
            return objDs.Lista_TipoPlantilla();
        }

        #endregion

        #region "TipoProceso_Duracion"
        public DataSet Lista_TipoProceso_Duracion(string strAñoProceso,
                                            string strCodTipoProceso,
                                            string strCodObjetoContratacion
                                           )
        {
            return objDs.Lista_TipoProceso_Duracion( strAñoProceso,
                                            strCodTipoProceso,
                                            strCodObjetoContratacion
                                           );
        }

        public DataSet Reporte_TipoProceso_Duracion(string strAñoProceso,
                                            string strCodTipoProceso,
                                            string strCodObjetoContratacion
                                           )
        {
            return objDs.Reporte_TipoProceso_Duracion(strAñoProceso,
                                            strCodTipoProceso,
                                            strCodObjetoContratacion
                                           );
        }

        public Model.TipoProceso_Duracion Recupera_TipoProceso_Duracion(int intIdTipoProceso_Duracion)
        {
            return objDs.Recupera_TipoProceso_Duracion(intIdTipoProceso_Duracion);
        }
        public int[] Graba_TipoProceso_Duracion(Model.TipoProceso_Duracion obj)
        {
            return objDs.Graba_TipoProceso_Duracion(obj);
        }
        public int Modifica_TipoProceso_Duracion(Model.TipoProceso_Duracion obj)
        {
            return objDs.Modifica_TipoProceso_Duracion(obj);
        }

        public bool Elimina_TipoProceso_Duracion(int intIdTipoProceso_Duracion)
        {
            return objDs.Elimina_TipoProceso_Duracion(intIdTipoProceso_Duracion);
        }

        #endregion

        #region "Comite"
        public DataSet Lista_Comite(int intIdDocumentoComite)
        {
            return objDs.Lista_Comite(intIdDocumentoComite);
        }

        public Model.Comite Recupera_Comite(int intIdComite)
        {
            return objDs.Recupera_Comite(intIdComite);
        }
        public int Graba_Comite(Model.Comite obj)
        {
            return objDs.Graba_Comite(obj);
        }
        public int Modifica_Comite(Model.Comite obj)
        {
            return objDs.Modifica_Comite(obj);
        }

        public bool Elimina_Comite(int intIdComite)
        {
            return objDs.Elimina_Comite(intIdComite);
        }

        #endregion

        #region "Comite_Integrante"
        public DataSet Ayuda_Comite_Integrante(string strAñoProceso)
        {
            return objDs.Ayuda_Comite_Integrante(strAñoProceso);
        }
        public DataSet Lista_Comite_Integrante_Pac(string strAñoProceso,
                                                     string strCodIntegrante
                                                    )
        {
            return objDs.Lista_Comite_Integrante_Pac(strAñoProceso,
                                               strCodIntegrante
                                                    );
        }
        public DataSet Lista_Comite_Integrante(int intIdComite)
        {
            return objDs.Lista_Comite_Integrante(intIdComite);
        }

        public DataSet Lista_Comite_Integrante_Procedimiento(string strNumProcedimiento)
        {
            return objDs.Lista_Comite_Integrante_Procedimiento(strNumProcedimiento);
        }


        public Model.Comite_Integrante Recupera_Comite_Integrante(int intIdComite_Integrante)
        {
            return objDs.Recupera_Comite_Integrante(intIdComite_Integrante);
        }


        public int Graba_Comite_Integrante(Model.Comite_Integrante obj)
        {
            return objDs.Graba_Comite_Integrante(obj);
        }
        public int Modifica_Comite_Integrante(Model.Comite_Integrante obj)
        {
            return objDs.Modifica_Comite_Integrante(obj);
        }
        public bool Elimina_Comite_Integrante(int intIdComite_Integrante)
        {
            return objDs.Elimina_Comite_Integrante(intIdComite_Integrante);
        }

        #endregion

        #region "Comite_Integrnte_Reemplazo"
        public int Graba_Comite_Integrante_Reemplazo(Model.Comite_Integrante_Reemplazo obj)
        {
            return objDs.Graba_Comite_Integrante_Reemplazo(obj);
        }

        #endregion

        #region "Comite_Resolucion"
        public DataSet Combo_ComiteResolucion()
        {
            return objDs.Combo_ComiteResolucion();
        }
        public DataSet Combo_Comite_Resolucion_AñoProceso()
        {
            return objDs.Combo_Comite_Resolucion_AñoProceso();
        }
        public DataSet combo_Comite_Resolucion_NumDocumento(string strAñoProceso)
        {
            return objDs.combo_Comite_Resolucion_NumDocumento(strAñoProceso);
        }

        public DataSet Lista_Comite_Resolucion()
        {
            return objDs.Lista_Comite_Resolucion();
        }
        public Model.Comite_Resolucion Recupera_Comite_Resolucion(int intIdDocumentoComite)
        {
            return objDs.Recupera_Comite_Resolucion(intIdDocumentoComite);
        }
        public int Graba_Comite_Resolucion(Model.Comite_Resolucion obj)
        {
            return objDs.Graba_Comite_Resolucion(obj);
        }
        public int Modifica_Comite_Resolucion(Model.Comite_Resolucion obj)
        {
            return objDs.Modifica_Comite_Resolucion(obj);
        }

        public bool Elimina_Comite_Resolucion(int intIdDocumentoComite)
        {
            return objDs.Elimina_Comite_Resolucion(intIdDocumentoComite);
        }

        #endregion

        #region "CondicionComite"
        public DataSet Combo_CondicionComite()
        {
            return objDs.Combo_CondicionComite();
        }

        #endregion

        #region "Paso"
        public DataSet Lista_Paso(string strCodEmpresa)
        {
            return objDs.Lista_Paso(strCodEmpresa);
        }
        public DataSet Reporte_Paso(string strCodTipoPlantilla)
        {
            return objDs.Reporte_Paso(strCodTipoPlantilla);
        }

        public DataSet Combo_Paso_Reporte(string strCodTipoPlantilla)
        {
            return objDs.Combo_Paso_Reporte(strCodTipoPlantilla);
        }

        public DataSet Combo_Paso(string strCodTipoPlantilla)
        {
            return objDs.Combo_Paso(strCodTipoPlantilla);
        }

        public DataSet Combo_Paso_ID(string strCodTipoPlantilla)
        {
            return objDs.Combo_Paso_ID(strCodTipoPlantilla);
        }

        public DataSet Ayuda_Paso_ID(string strCodTipoPlantilla)
        {
            return objDs.Ayuda_Paso_ID(strCodTipoPlantilla);
        }
        public Model.Paso Recupera_Paso(int intIdPaso)
        {
            return objDs.Recupera_Paso(intIdPaso);
        }

        public Model.Paso Recupera_Paso_codigo(string strCodTipoPlantilla,
                                                 string strCodPaso
                                               )
        {
            return objDs.Recupera_Paso_codigo(strCodTipoPlantilla,
                                        strCodPaso
                                               );
        }
        public int Graba_Paso(Model.Paso obj)
        {
            return objDs.Graba_Paso(obj);
        }
        public int Modifica_Paso(Model.Paso obj)
        {
            return objDs.Modifica_Paso(obj);
        }

        public bool Elimina_Paso(int intIdPaso)
        {
            return objDs.Elimina_Paso(intIdPaso);
        }

        #endregion

        #region "TipoDocumento_ProcesoLogistico"
        public DataSet Ayuda_TipoDocumento_ProcesoLogistico()
        {
            return objDs.Ayuda_TipoDocumento_ProcesoLogistico();
        }
        public DataSet Combo_TipoDocumento_ProcesoLogistico()
        {
            return objDs.Combo_TipoDocumento_ProcesoLogistico();
        }

        #endregion

        #region "ProcesoLogistico_Version"
        public DataSet Combo_AñoProceso_Logistica()
        {
            return objDs.Combo_AñoProceso_Logistica();
        }

        public DataSet Combo_Version_Logistica(string strAñoProceso)
        {
            return objDs.Combo_Version_Logistica(strAñoProceso);
        }

        public Model.ProcesoLogistico_Version Recupera_Version_Logistica()
        {
            return objDs.Recupera_Version_Logistica();
        }

        #endregion

        #region "ProcesoLogistico_Paso_Cierre"
        public int Graba_ProcesoLogistico_Paso_Cierre(Model.ProcesoLogistico_Paso_Cierre obj)
        {
            return objDs.Graba_ProcesoLogistico_Paso_Cierre(obj);
        }

        #endregion

        #region "ProcesoLogistico_Paso_CambioEstado"
        public DataSet Recupera_ProcesoLogistico_Paso_CambiaEstado(string strNumProcedimiento)
        {
            return objDs.Recupera_ProcesoLogistico_Paso_CambiaEstado(strNumProcedimiento);
        }
        public int Graba_ProcesoLogistico_Paso_CambioEstado(Model.ProcesoLogistico_Paso_CambioEstado obj)
        {
            return objDs.Graba_ProcesoLogistico_Paso_CambioEstado(obj);
        }

        #endregion

        #region "ProcesoLogistico_Paso_Apertura"
        public Model.ProcesoLogistico_Paso_Apertura Recupera_ProcesoLogistico_Paso_Apertura(int intIdProcesoLogistico_Paso_Apertura)
        {
            return objDs.Recupera_ProcesoLogistico_Paso_Apertura(intIdProcesoLogistico_Paso_Apertura);
        }

        public DateTime[] Recupera_ProcesoLogistico_Paso_Apertura_Inicio(string strNumProcedimiento)
        {
            return objDs.Recupera_ProcesoLogistico_Paso_Apertura_Inicio(strNumProcedimiento);
        }

        public DateTime[] Recupera_ProcesoLogistico_Paso_Apertura_Proceso(string strNumProcedimiento,
                                                                          string strCodTipoPlantilla,
                                                                          int intIdPaso
                                                                         )
        {
            return objDs.Recupera_ProcesoLogistico_Paso_Apertura_Proceso(strNumProcedimiento,
                                                                    strCodTipoPlantilla,
                                                                    intIdPaso
                                                                         );
        }


        public int Graba_ProcesoLogistico_Paso_Apertura(Model.ProcesoLogistico_Paso_Apertura objPA,
                                                        Model.ProcesoLogistico_Paso objP
                                                       )
        {
            return objDs.Graba_ProcesoLogistico_Paso_Apertura(objPA,
                                                        objP
                                                       );
        }

        public int Graba_ProcesoLogistico_Paso_Apertura_Inicio(Model.ProcesoLogistico_Paso objP,
                                                               Model.ProcesoLogistico_Paso_Apertura objPA
                                                              )
        {
            return objDs.Graba_ProcesoLogistico_Paso_Apertura_Inicio(objP,
                                                               objPA
                                                              );
        }

        #endregion

        #region "ProcesoLogistico_Paso_Adjunto"
        public DataSet Lista_ProcesoLogistico_Paso_Adjunto(string strNumProcedimiento, int intIdPaso)
        {
            return objDs.Lista_ProcesoLogistico_Paso_Adjunto( strNumProcedimiento, intIdPaso);
        }

        public DataSet Lista_ProcesoLogistico_Paso_Adjunto_Consulta(string strNumProcedimiento, string strCodPaso)
        {
            return objDs.Lista_ProcesoLogistico_Paso_Adjunto_Consulta( strNumProcedimiento, strCodPaso);
        }

        public Model.ProcesoLogistico_Paso_Adjunto Recupera_ProcesoLogistico_Paso_Adjunto(int intIdAdjunto)
        {
            return objDs.Recupera_ProcesoLogistico_Paso_Adjunto(intIdAdjunto);
        }
        public int Graba_ProcesoLogistico_Paso_Adjunto(Model.ProcesoLogistico_Paso_Adjunto obj)
        {
            return objDs.Graba_ProcesoLogistico_Paso_Adjunto(obj);
        }
        public int Modifica_ProcesoLogistico_Paso_Adjunto(Model.ProcesoLogistico_Paso_Adjunto obj)
        {
            return objDs.Modifica_ProcesoLogistico_Paso_Adjunto(obj);
        }

        public bool Elimina_ProcesoLogistico_Paso_Adjunto(int intIdAdjunto)
        {
            return objDs.Elimina_ProcesoLogistico_Paso_Adjunto(intIdAdjunto);
        }

        #endregion

        #region "ProcesoLogistico_Paso"
        public DataSet Combo_EstadoAperturaPaso()
        {
            return objDs.Combo_EstadoAperturaPaso();
        }
        public DataSet Lista_ProcesoLogistico_Paso(string strAñoProceso,
                                                 string strNumProcedimiento
                                                )
        {
            return objDs.Lista_ProcesoLogistico_Paso(strAñoProceso,
                                               strNumProcedimiento
                                                );
        }
        public Model.ProcesoLogistico_Paso Recupera_ProcesoLogistico_Paso(int intIdProcesoLogistico_Paso)
        {
            return objDs.Recupera_ProcesoLogistico_Paso(intIdProcesoLogistico_Paso);
        }

        public Model.ProcesoLogistico_Paso Recupera_ProcesoLogistico_Paso_Apertura_Procedimiento(string strNumProcedimiento)
        {
            return objDs.Recupera_ProcesoLogistico_Paso_Apertura_Procedimiento(strNumProcedimiento);
        }

        public int Graba_ProcesoLogistico_Paso(Model.ProcesoLogistico_Paso obj)
        {
            return objDs.Graba_ProcesoLogistico_Paso(obj);
        }
        public int Modifica_ProcesoLogistico_Paso(Model.ProcesoLogistico_Paso obj)
        {
            return objDs.Modifica_ProcesoLogistico_Paso(obj);
        }

        public bool Elimina_ProcesoLogistico_Paso(int intIdProcesoLogistico_Paso)
        {
            return objDs.Elimina_ProcesoLogistico_Paso(intIdProcesoLogistico_Paso);
        }

        #endregion

        #region "PeriodoProceso_OperadorLogistico"
        public Model.ProcesoLogistico_OperadorLogistico Recupera_ProcesoLogistico_OperadorLogistico(int intIdProcesoLogistico_OperadorLogistico)
        {
            return objDs.Recupera_ProcesoLogistico_OperadorLogistico(intIdProcesoLogistico_OperadorLogistico);
        }

        public Model.ProcesoLogistico_OperadorLogistico Recupera_ProcesoLogistico_OperadorLogistico_ItemProcesoLogistico(string strNumProcedimiento)
        {
            return objDs.Recupera_ProcesoLogistico_OperadorLogistico_ItemProcesoLogistico(strNumProcedimiento);
        }

        public Boolean Graba_ProcesoLogistico_OperadorLogistico_Reemplazo(int intIdProcesoLogistico_OperadorLogistico,
                                                                        string strCodTipoOperadorLogistico,
                                                                        string strCodMotivoReemplazo,
                                                                        string strCodReemplazo,
                                                                        DateTime dateFecInicio,
                                                                        DateTime dateFecFinal
                                                                       )
        {
            return objDs.Graba_ProcesoLogistico_OperadorLogistico_Reemplazo( intIdProcesoLogistico_OperadorLogistico,
                                                                       strCodTipoOperadorLogistico,
                                                                       strCodMotivoReemplazo,
                                                                       strCodReemplazo,
                                                                       dateFecInicio,
                                                                        dateFecFinal
                                                                       );
        }

        public DataSet Lista_ProcesoLogistico_OperadorLogistico(string strCodCompañia,
                                                                 string strAñoProceso,
                                                                 string strCodOperadorLogistico
                                                               )
        {
            return objDs.Lista_ProcesoLogistico_OperadorLogistico( strCodCompañia,
                                                             strAñoProceso,
                                                             strCodOperadorLogistico
                                                               );
        }

        public DataSet Lista_ProcesoLogistico_Programacion( string strCodCompañia,
                                                            string strCodTipoProceso,
                                                            string strCodObjetoContratacion,
                                                            DateTime dateFecPosibleCierre,
                                                            int intTipoReporte
                                                               )
        {
            return objDs.Lista_ProcesoLogistico_Programacion(strCodCompañia,
                                                            strCodTipoProceso,
                                                            strCodObjetoContratacion,
                                                            dateFecPosibleCierre,
                                                            intTipoReporte
                                                               );
        }

        public int Graba_ProcesoLogistico_OperadorLogistico(Model.ProcesoLogistico_OperadorLogistico obj)
        {
            return objDs.Graba_ProcesoLogistico_OperadorLogistico(obj);
        }

        public int Modifica_ProcesoLogistico_OperadorLogistico(Model.ProcesoLogistico_OperadorLogistico obj)
        {
            return objDs.Modifica_ProcesoLogistico_OperadorLogistico(obj);
        }

        public bool Elimina_ProcesoLogistico_OperadorLogistico(int intIdProcesoLogistico_OperadorLogistico)
        {
            return objDs.Elimina_ProcesoLogistico_OperadorLogistico(intIdProcesoLogistico_OperadorLogistico);
        }

        public DataSet Lista_ProcesoLogistico_OperadorLogistico(string strAñoProceso,
                                                        string strCodOperadorLogistico
                                                    )
        {
            return objDs.Lista_ProcesoLogistico_OperadorLogistico( strAñoProceso,
                                                         strCodOperadorLogistico
                                                    );
        }

        public DataSet Ayuda_ProcesoLogistico_OperadorLogistico_itemProcesoLogistico_Todos(string strAñoProceso)
        {
            return objDs.Ayuda_ProcesoLogistico_OperadorLogistico_itemProcesoLogistico_Todos(strAñoProceso);
        }

        #endregion

        #region "ProcesoLogistico_Modificado"
        public Model.ProcesoLogistico_Modificado Recupera_ProcesoLogistico_Modificado(int intIdProcesoLogistico_Modificado)
        {
            return objDs.Recupera_ProcesoLogistico_Modificado(intIdProcesoLogistico_Modificado);
        }

        #endregion

        #region "ProcesoLogistico_Insertado"
        public Model.ProcesoLogistico_Insertado Recupera_ProcesoLogistico_Insertado(int intIdProcesoLogistico_Insertado)
        {
            return objDs.Recupera_ProcesoLogistico_Insertado(intIdProcesoLogistico_Insertado);
        }

        #endregion

        #region "ProcesoLogistico_Eliminado"
        public Model.ProcesoLogistico_Eliminado Recupera_ProcesoLogistico_Eliminado(int intIdProcesoLogistico_Eliminado)
        {
            return objDs.Recupera_ProcesoLogistico_Eliminado(intIdProcesoLogistico_Eliminado);
        }

        #endregion

        #region "ProcesoLogistico_Cabecera_Adjunto"
        public DataSet Lista_ProcesoLogistico_Cabecera_Adjunto(string strAñoProceso,
                                            string strVersion
                                           )
        {
            return objDs.Lista_ProcesoLogistico_Cabecera_Adjunto( strAñoProceso,
                                             strVersion
                                           );
        }

        public DataSet Lista_ProcesoLogistico_Cabecera_Adjunto_Consulta(string strAñoProceso,
                                                    string strVersion
                                                   )
        {
            return objDs.Lista_ProcesoLogistico_Cabecera_Adjunto_Consulta( strAñoProceso,
                                                     strVersion
                                                   );
        }

        public Model.ProcesoLogistico_Cabecera_Adjunto Recupera_ProcesoLogistico_Cabecera_Adjunto(int intIdAdjunto)
        {
            return objDs.Recupera_ProcesoLogistico_Cabecera_Adjunto(intIdAdjunto);
        }
        public int Graba_ProcesoLogistico_Cabecera_Adjunto(Model.ProcesoLogistico_Cabecera_Adjunto obj)
        {
            return objDs.Graba_ProcesoLogistico_Cabecera_Adjunto( obj);
        }
        public int Modifica_ProcesoLogistico_Cabecera_Adjunto(Model.ProcesoLogistico_Cabecera_Adjunto obj)
        {
            return objDs.Modifica_ProcesoLogistico_Cabecera_Adjunto(obj);
        }

        public bool Elimina_ProcesoLogistico_Cabecera_Adjunto(int intIdAdjunto)
        {
            return objDs.Elimina_ProcesoLogistico_Cabecera_Adjunto(intIdAdjunto);
        }

        #endregion

        #region "ProcesoLogistico_Adjunto"
        public DataSet Lista_ProcesoLogistico_Adjunto(string strNumProcedimiento)
        {
            return objDs.Lista_ProcesoLogistico_Adjunto(strNumProcedimiento);
        }

        public DataSet Lista_ProcesoLogistico_Adjunto_Consulta(string strNumProcedimiento)
        {
            return objDs.Lista_ProcesoLogistico_Adjunto_Consulta(strNumProcedimiento);
        }

        public Model.ProcesoLogistico_Adjunto Recupera_ProcesoLogistico_Adjunto(int intIdAdjunto)
        {
            return objDs.Recupera_ProcesoLogistico_Adjunto(intIdAdjunto);
        }
        public int Graba_ProcesoLogistico_Adjunto(Model.ProcesoLogistico_Adjunto obj)
        {
            return objDs.Graba_ProcesoLogistico_Adjunto( obj);
        }
        public int Modifica_ProcesoLogistico_Adjunto(Model.ProcesoLogistico_Adjunto obj)
        {
            return objDs.Modifica_ProcesoLogistico_Adjunto( obj);
        }

        public bool Elimina_ProcesoLogistico_Adjunto(int intIdAdjunto)
        {
            return objDs.Elimina_ProcesoLogistico_Adjunto( intIdAdjunto);
        }

        #endregion

        #region "Duracion"
        public DataSet Lista_ProcesoLogistico_Duracion(string strAñoProceso,
                                    string strVersion,
                                    string strNumProcedimiento
                                 )
        {
            return objDs.Lista_ProcesoLogistico_Duracion( strAñoProceso,
                                    strVersion,
                                    strNumProcedimiento
                                 );
        }

        public DataSet Lista_ProcesoLogistico_Duracion_Consulta(string strAñoProceso,
                                            string strVersion,
                                            string strNumProcedimiento
                                         )
        {
            return objDs.Lista_ProcesoLogistico_Duracion_Consulta(strAñoProceso,
                                             strVersion,
                                             strNumProcedimiento
                                         );
        }


        public Model.ProcesoLogistico_Duracion Graba_ProcesoLogistico_Duracion(Model.ProcesoLogistico_Duracion obj)
        {
            return objDs.Graba_ProcesoLogistico_Duracion(obj);
        }


        public int Modifica_ProcesoLogistico_Duracion(Model.ProcesoLogistico_Duracion obj)
        {
            return objDs.Modifica_ProcesoLogistico_Duracion(obj);
        }
        public object recupera_ProcesoLogistico_Duracion(string strNumProcedimiento,
                                            string strCodPaso
                                           )
        {
            return objDs.recupera_ProcesoLogistico_Duracion( strNumProcedimiento,
                                             strCodPaso
                                           );
        }

        public int Recupera_ProcesoLogistico_Duracion_Orden(string strNumProcedimiento)
        {
            return objDs.Recupera_ProcesoLogistico_Duracion_Orden(strNumProcedimiento);
        }
        public bool elimina_mvto_ProcesoLogistico_Detalle_Duracion(int intIdProcesoLogistico_Detalle_Duracion)
        {
            return objDs.elimina_mvto_ProcesoLogistico_Detalle_Duracion(intIdProcesoLogistico_Detalle_Duracion);
        }

        #endregion

        #region "MotivoEliminacion_ProcesoLogistico"
        public DataSet Ayuda_TipoMotivoEliminacionProcesoLogistico()
        {
            return objDs.Ayuda_TipoMotivoEliminacionProcesoLogistico();
        }
        public DataSet Combo_TipoMotivoEliminacionProcesoLogistico()
        {
            return objDs.Combo_TipoMotivoEliminacionProcesoLogistico();
        }

        #endregion

        #region "MotivoModificacion_ProcesoLogistico"
        public DataSet Ayuda_TipoMotivoModificacionProcesoLogistico()
        {
            return objDs.Ayuda_TipoMotivoModificacionProcesoLogistico();
        }
        public DataSet Combo_TipoMotivoModificacionProcesoLogistico()
        {
            return objDs.Combo_TipoMotivoModificacionProcesoLogistico();
        }

        #endregion

        #region "MotivoInserccion_ProcesoLogistico"
        public DataSet Ayuda_TipoMotivoInserccionProcesoLogistico()
        {
            return objDs.Ayuda_TipoMotivoInserccionProcesoLogistico();
        }
        public DataSet Combo_TipoMotivoInserccionProcesoLogistico()
        {
            return objDs.Combo_TipoMotivoInserccionProcesoLogistico();
        }

        #endregion

        #region "TipoAdquisicion"
        public DataSet Combo_TipoAdquisicion()
        {
            return objDs.Combo_TipoAdquisicion();
        }

        public DataSet Ayuda_TipoAdquisicion()
        {
            return objDs.Ayuda_TipoAdquisicion();
        }
        public Model.TipoAdquisicion Recupera_TipoAdquisicion(int intIdTipoAdquisicion)
        {
            return objDs.Recupera_TipoAdquisicion(intIdTipoAdquisicion);
        }
        public Model.TipoAdquisicion Recupera_TipoAdquisicion_Codigo(string strCodTipoAdquisicion)
        {
            return objDs.Recupera_TipoAdquisicion_Codigo( strCodTipoAdquisicion);
        }
        public int Graba_TipoAdquisicion(Model.TipoAdquisicion obj)
        {
            return objDs.Graba_TipoAdquisicion( obj);
        }
        public int Modifica_TipoAdquisicion(Model.TipoAdquisicion obj)
        {
            return objDs.Modifica_TipoAdquisicion(obj);
        }
        public bool Elimina_TipoAdquisicion(int intIdTipoAdquisicion)
        {
            return objDs.Elimina_TipoAdquisicion(intIdTipoAdquisicion);
        }
        public DataSet Lista_TipoAdquisicion()
        {
            return objDs.Lista_TipoAdquisicion();
        }

        #endregion

        #region "ProcesoLogistico_Cabecera"

        public DataSet ayuda_ProcesoLogistico_Reasignacion()
        {
            return objDs.ayuda_ProcesoLogistico_Reasignacion();
        }
        public DataSet lista_ProcesoLogistico_Reasignacion(string strAñoProceso,
                                                             string strNumProcedimiento
                                                            )
        {
            return objDs.lista_ProcesoLogistico_Reasignacion(strAñoProceso,
                                                       strNumProcedimiento
                                                            );
        }
        public Model.ProcesoLogistico_Cabecera Recupera_ProcesoLogistico_Cabecera(int intIdProcesoLogistico_Cabecera)
        {
            return objDs.Recupera_ProcesoLogistico_Cabecera(intIdProcesoLogistico_Cabecera);
        }

        public DataSet Combo_ProcesoLogistico_Año(string strCodEmpresa)
        {
            return objDs.Combo_ProcesoLogistico_Año(strCodEmpresa);
        }

        public List<Model.Dashboard_ProcesoLogistico_TipoProceso> Reporte_ProcesoLogistico_Dashboard(string strCodCompañia,
                  string strAñoProceso,
                  string strVersion,
                  bool blnTodasLasVersiones
                )
        {
            return objDs.Reporte_ProcesoLogistico_Dashboard(strCodCompañia,
                          strAñoProceso,
                          strVersion,
                          blnTodasLasVersiones
                        );
        }



        public DataSet Combo_ProcesoLogistico_Version(string strCodEmpresa,
                                                      string strAñoProceso
                                                     )
        {
            return objDs.Combo_ProcesoLogistico_Version(strCodEmpresa,strAñoProceso);
        }
        public Model.ProcesoLogistico_Cabecera Recupera_ProcesoLogistico_Cabecera_Id()
        {
            return objDs.Recupera_ProcesoLogistico_Cabecera_Id();
        }

        public int Graba_ProcesoLogistico_Cabecera(Model.ProcesoLogistico_Cabecera obj)
        {
            return objDs.Graba_ProcesoLogistico_Cabecera(obj);
        }

        public int Modifica_ProcesoLogistico_Cabecera(Model.ProcesoLogistico_Cabecera obj)
        {
            return objDs.Modifica_ProcesoLogistico_Cabecera(obj);
        }
        public bool Elimina_ProcesoLogistico_Cabecera(int intIdProcesoLogistico_Cabecera)
        {
            return objDs.Elimina_ProcesoLogistico_Cabecera(intIdProcesoLogistico_Cabecera);
        }

        public DataSet Lista_ProcesoLogistico_Cabecera(string strAñoProceso)
        {
            return objDs.Lista_ProcesoLogistico_Cabecera(strAñoProceso);
        }
        #endregion

        #region "TipoProceso"
        public DataSet Combo_TipoProceso()
        {
            return objDs.Combo_TipoProceso();
        }

        public DataSet Ayuda_TipoProceso()
        {
            return objDs.Ayuda_TipoProceso();
        }

        public Model.TipoProceso Recupera_TipoProceso(int intIdTipoProceso)
        {
            return objDs.Recupera_TipoProceso(intIdTipoProceso);
        }
        public Model.TipoProceso Recupera_TipoProceso_Codigo(string strCodTipoProceso)
        {
            return objDs.Recupera_TipoProceso_Codigo(strCodTipoProceso);
        }

        public int Graba_TipoProceso(Model.TipoProceso obj)
        {
            return objDs.Graba_TipoProceso(obj);
        }

        public int Modifica_TipoProceso(Model.TipoProceso obj)
        {
            return objDs.Modifica_TipoProceso(obj);
        }

        public bool Elimina_TipoProceso(int intIdTipoProceso)
        {
            return objDs.Elimina_TipoProceso(intIdTipoProceso);
        }

        public DataSet Lista_TipoProceso()
        {
            return objDs.Lista_TipoProceso();
        }


        #endregion

        #region "ObjetoContratacion"
        public DataSet Ayuda_ObjetoContratacion()
        {
            return objDs.Ayuda_ObjetoContratacion();
        }
        public DataSet Combo_ObjetoContratacion_SinFiltro()
        {
            return objDs.Combo_ObjetoContratacion_SinFiltro();
        }
        public DataSet Combo_ObjetoContratacion(string strCodTipoProceso)
        {
            return objDs.Combo_ObjetoContratacion(strCodTipoProceso);
        }

        public DataSet Ayuda_ObjetoContratacion_TipoProceso(string strCodTipoProceso)
        {
            return objDs.Ayuda_ObjetoContratacion_TipoProceso(strCodTipoProceso);
        }


        public Model.ObjetoContratacion Recupera_ObjetoContratacion(int intIdObjetoContratacion)
        {
            return objDs.Recupera_ObjetoContratacion(intIdObjetoContratacion);
        }
        public Model.ObjetoContratacion Recupera_ObjetoContratacion_Codigo(string strCodObjetoContratacion)
        {
            return objDs.Recupera_ObjetoContratacion_Codigo(strCodObjetoContratacion);
        }

        public int Graba_ObjetoContratacion(Model.ObjetoContratacion obj)
        {
            return objDs.Graba_ObjetoContratacion(obj);
        }
        public int Modifica_ObjetoContratacion(Model.ObjetoContratacion obj)
        {
            return objDs.Modifica_ObjetoContratacion(obj);
        }

        public bool Elimina_ObjetoContratacion(int intIdObjetoContratacion)
        {
            return objDs.Elimina_ObjetoContratacion( intIdObjetoContratacion);
        }

        public DataSet Lista_ObjetoContratacion()
        {
            return objDs.Lista_ObjetoContratacion();
        }

        #endregion

        #region "UnidadMedida"
        public Model.UnidadMedida Recupera_UnidadMedida(int intIdUnidadMedida)
        {
            return objDs.Recupera_UnidadMedida(intIdUnidadMedida);
        }
        public Model.UnidadMedida Recupera_UnidadMedida_Codigo(string strCodUnidadMedida)
        {
            return objDs.Recupera_UnidadMedida_Codigo(strCodUnidadMedida);
        }

        public int Graba_UnidadMedida(Model.UnidadMedida obj)
        {
            return objDs.Graba_UnidadMedida(obj);
        }

        public int Modifica_UnidadMedida(Model.UnidadMedida obj)
        {
            return objDs.Modifica_UnidadMedida(obj);
        }

        public bool Elimina_UnidadMedida(int intIdUnidadMedida)
        {
            return objDs.Elimina_UnidadMedida(intIdUnidadMedida);
        }

        public DataSet Lista_UnidadMedida()
        {
            return objDs.Lista_UnidadMedida();
        }

        #endregion


        #region "TipoTipoFuenteFinanciamiento"
        public DataSet Combo_TipoFuenteFinanciamiento()
        {
            return objDs.Combo_TipoFuenteFinanciamiento();
        }

        public DataSet Ayuda_TipoFuenteFinanciamiento()
        {
            return objDs.Ayuda_TipoFuenteFinanciamiento();
        }
        public Model.TipoFuenteFinanciamiento Recupera_TipoFuenteFinanciamiento(int intIdTipoFuenteFinanciamiento)
        {
            return objDs.Recupera_TipoFuenteFinanciamiento(intIdTipoFuenteFinanciamiento);
        }


        public Model.TipoFuenteFinanciamiento Recupera_TipoFuenteFinanciamiento_Codigo(string strCodTipoFuenteFinanciamiento)
        {
            return objDs.Recupera_TipoFuenteFinanciamiento_Codigo(strCodTipoFuenteFinanciamiento);
        }

        public int Graba_TipoFuenteFinanciamiento(Model.TipoFuenteFinanciamiento obj)
        {
            return objDs.Graba_TipoFuenteFinanciamiento(obj);
        }

        public int Modifica_TipoFuenteFinanciamiento(Model.TipoFuenteFinanciamiento obj)
        {
            return objDs.Modifica_TipoFuenteFinanciamiento(obj);
        }

        public bool Elimina_TipoFuenteFinanciamiento(int intIdTipoFuenteFinanciamiento)
        {
            return objDs.Elimina_TipoFuenteFinanciamiento(intIdTipoFuenteFinanciamiento);
        }

        public DataSet Lista_TipoFuenteFinanciamiento()
        {
            return objDs.Lista_TipoFuenteFinanciamiento();
        }

        #endregion

        #region "EntidadEncargadaConvocante"
        public DataSet Combo_EntidadEncargadaConvocante()
        {
            return objDs.Combo_EntidadEncargadaConvocante();
        }

        public DataSet Ayuda_EntidadEncargadaConvocante()
        {
            return objDs.Ayuda_EntidadEncargadaConvocante();
        }

        public Model.EntidadEncargadaConvocante Recupera_EntidadEncargadaConvocante(int intIdEntidadEncargadaConvocante)
        {
            return objDs.Recupera_EntidadEncargadaConvocante(intIdEntidadEncargadaConvocante);
        }


        public Model.EntidadEncargadaConvocante Recupera_EntidadEncargadaConvocante_Codigo(string strCodEntidadEncargadaConvocante)
        {
            return objDs.Recupera_EntidadEncargadaConvocante_Codigo(strCodEntidadEncargadaConvocante);
        }

        public int Graba_EntidadEncargadaConvocante(Model.EntidadEncargadaConvocante obj)
        {
            return objDs.Graba_EntidadEncargadaConvocante(obj);
        }

        public int Modifica_EntidadEncargadaConvocante(Model.EntidadEncargadaConvocante obj)
        {
            return objDs.Modifica_EntidadEncargadaConvocante(obj);
        }

        public bool Elimina_EntidadEncargadaConvocante(int intIdEntidadEncargadaConvocante)
        {
            return objDs.Elimina_EntidadEncargadaConvocante(intIdEntidadEncargadaConvocante);
        }

        public DataSet Lista_EntidadEncargadaConvocante()
        {
            return objDs.Lista_EntidadEncargadaConvocante();
        }

        #endregion


        #region "ModalidadSeleccion"
        public DataSet Combo_ModalidadSeleccion()
        {
            return objDs.Combo_ModalidadSeleccion();
        }

        public DataSet Ayuda_ModalidadSeleccion()
        {
            return objDs.Ayuda_ModalidadSeleccion();
        }

        public Model.ModalidadSeleccion Recupera_ModalidadSeleccion(int intIdModalidadSeleccion)
        {
            return objDs.Recupera_ModalidadSeleccion(intIdModalidadSeleccion);
        }


        public Model.ModalidadSeleccion Recupera_ModalidadSeleccion_Codigo(string strCodModalidadSeleccion)
        {
            return objDs.Recupera_ModalidadSeleccion_Codigo(strCodModalidadSeleccion);
        }

        public int Graba_ModalidadSeleccion(Model.ModalidadSeleccion obj)
        {
            return objDs.Graba_ModalidadSeleccion(obj);
        }

        public int Modifica_ModalidadSeleccion(Model.ModalidadSeleccion obj)
        {
            return objDs.Modifica_ModalidadSeleccion(obj);
        }

        public bool Elimina_ModalidadSeleccion(int intIdModalidadSeleccion)
        {
            return objDs.Elimina_ModalidadSeleccion(intIdModalidadSeleccion);
        }

        public DataSet Lista_ModalidadSeleccion()
        {
            return objDs.Lista_ModalidadSeleccion();
        }

        #endregion

        #region "Centro"
        public Model.Centro Recupera_Centro(int intIdCentro)
        {
            return objDs.Recupera_Centro(intIdCentro);
        }


        public Model.Centro Recupera_Centro_Codigo(string strCodCentro)
        {
            return objDs.Recupera_Centro_Codigo(strCodCentro);
        }

        public int Graba_Centro(Model.Centro obj)
        {
            return objDs.Graba_Centro(obj);
        }

        public int Modifica_Centro(Model.Centro obj)
        {
            return objDs.Modifica_Centro(obj);
        }

        public bool Elimina_Centro(int intIdCentro)
        {
            return objDs.Elimina_Centro(intIdCentro);
        }

        public DataTable Lista_Centro()
        {
            return objDs.Lista_Centro();
        }

        #endregion

        #region "ProcesoLogistico_Detalle"

        public string graba_ProcesoLogistico_Requerimiento(string strNumRequerimiento,
                                                            string strCodTipoProceso,
                                                            string strCodObjetoContratacion,
                                                            string strCodAdministradorContrato,
                                                            int intDiasPlazo,
                                                            string strPaso,
                                                            string strCodCentroGestor,
                                                            string strEsUnProceso,
                                                            string strCodPac,
                                                            string strCodEmpleado
                                                          )
        {
            return objDs.graba_ProcesoLogistico_Requerimiento( strNumRequerimiento,
                                                          strCodTipoProceso,
                                                           strCodObjetoContratacion,
                                                           strCodAdministradorContrato,
                                                           intDiasPlazo,
                                                           strPaso,
                                                           strCodCentroGestor,
                                                           strEsUnProceso,
                                                           strCodPac,
                                                            strCodEmpleado
                                                          );
        }

        public bool graba_ProcesoLogistico_Requerimiento_LineaFormulacion(string strNumRequerimiento,
                                                                          string strNumProcedimiento,
                                                                          int intIdRequerimiento_Detalle
                                                                         )
        {
            return objDs.graba_ProcesoLogistico_Requerimiento_LineaFormulacion(strNumRequerimiento,
                                                                           strNumProcedimiento,
                                                                           intIdRequerimiento_Detalle
                                                                         );
        }
        public DataSet ayuda_Pac_HojaTrabajo(string strCodCompañia,
                                              string strAñoProceso
                                            )
        {
            return objDs.ayuda_Pac_HojaTrabajo( strCodCompañia,
                                           strAñoProceso
                                            );
        }

        public Model.Pac_HojaTrabajo recupera_Pac_HojaTrabajo(string strCodCompañia,
                                                string strAñoProceso,
                                                string strCodProcesoLogistico
                                    )
        {
            return objDs.recupera_Pac_HojaTrabajo( strCodCompañia,
                                              strAñoProceso,
                                               strCodProcesoLogistico
                                    );
        }
        public Model.ProcesoLogistico_Detalle Recupera_ProcesoLogistico_Detalle(int intIdProcesoLogistico_Detalle)
        {
            return objDs.Recupera_ProcesoLogistico_Detalle(intIdProcesoLogistico_Detalle);
        }
        public Model.ProcesoLogistico_Detalle Recupera_ProcesoLogistico_Detalle_Codigo(string strNumProcedimiento)
        {
            return objDs.Recupera_ProcesoLogistico_Detalle_Codigo(strNumProcedimiento);
        }

        public int Graba_ProcesoLogistico_Detalle(Model.ProcesoLogistico_Detalle obj)
        {
            return objDs.Graba_ProcesoLogistico_Detalle(obj);
        }

        public int Modifica_ProcesoLogistico_Detalle(Model.ProcesoLogistico_Detalle obj)
        {
            return objDs.Modifica_ProcesoLogistico_Detalle(obj);
        }

        public bool Elimina_ProcesoLogistico_Detalle(Model.ProcesoLogistico_Detalle obj)
        {
            return objDs.Elimina_ProcesoLogistico_Detalle(obj);
        }

        public DataSet Lista_ProcesoLogistico_Detalle(string strAñoProceso,
                                            string strVersion
            )
        {
            return objDs.Lista_ProcesoLogistico_Detalle( strAñoProceso,
                                             strVersion
                                                );
        }

        public DataSet Lista_ProcesoLogistico_Detalle_CurvaS( )
        {
            return objDs.Lista_ProcesoLogistico_Detalle_CurvaS();
        }

        public DataSet Lista_ProcesoLogistico_Detalle_AperturaEtapa()
        {
            return objDs.Lista_ProcesoLogistico_Detalle_AperturaEtapa();
        }

        public DataSet Lista_ProcesoLogistico_Detalle_Cotizaciones()
        {
            return objDs.Lista_ProcesoLogistico_Detalle_Cotizaciones();
        }

        public string[] HallarTipoProcedimiento_ProcesoLogistico_Detalle(string strAñoProceso,
                                                            string strVersion,
                                                            string strCodTipoProceso
            )
        {
            return objDs.HallarTipoProcedimiento_ProcesoLogistico_Detalle(strAñoProceso,
                                                             strVersion,
                                                             strCodTipoProceso
                                                                );
        }

        public DataSet Lista_ProcesoLogistico_Detalle_PorOperadorLogistico(string strAñoProceso,
                                                                string strVersion,
                                                                string strCodOperadorLogistico
                                                               )
        {
            return objDs.Lista_ProcesoLogistico_Detalle_PorOperadorLogistico( strAñoProceso,
                                                                 strVersion,
                                                                 strCodOperadorLogistico
                                                               );
        }

        public DataSet Lista_ProcesoLogistico_Detalle_PorCeges(string strAñoProceso,
                                                        string strVersion,
                                                        string strCodCeges
                                                     )

        {
            return objDs.Lista_ProcesoLogistico_Detalle_PorCeges( strAñoProceso,
                                                         strVersion,
                                                         strCodCeges
                                                     );
        }

        #endregion

        #region EstadoComite_Integrante
        public DataSet Combo_EstadoComiteIntegrante(int intTipo)
        {
            return objDs.Combo_EstadoComiteIntegrante(intTipo);
        }

        public DataSet Combo_EstadoComite_Integrante_Reemplazo()
        {
            return objDs.Combo_EstadoComite_Integrante_Reemplazo();
        }


        #endregion

        #region EstadoOperadorLogistico
        public DataSet Combo_EstadoOperadorLogistico(int intTipo)
        {
            return objDs.Combo_EstadoOperadorLogistico(intTipo);
        }

        public DataSet Combo_EstadoOperadorLogistico_Reemplazo()
        {
            return objDs.Combo_EstadoOperadorLogistico_Reemplazo();
        }


        #endregion


        #region Adjunto
        public DataTable Lista_Pac_Adjunto_Consulta(int intTipoMovimiento)
        {
            return objDs.Lista_Pac_Adjunto_Consulta(intTipoMovimiento);
        }

        public DataTable Lista_Pac_Adjunto(int intTipoMovimiento)
        {
            return objDs.Lista_Pac_Adjunto(intTipoMovimiento);
        }

        public Model.Adjunto Recupera_Pac_Adjunto(int intIdAdjunto)
        {
            return objDs.Recupera_Pac_Adjunto(intIdAdjunto);
        }
        public int Graba_Pac_Adjunto(Model.Adjunto obj)
        {
            return objDs.Graba_Pac_Adjunto(obj);
        }

        public bool Elimina_Pac_Adjunto(int intIdAdjunto)
        {
            return objDs.Elimina_Pac_Adjunto(intIdAdjunto);
        }

        #endregion

        #region Proveedor
        public DataSet Ayuda_Proveedor()
        {
            return objDs.Ayuda_Proveedor();
        }

        public Model.Proveedor Recupera_msto_Proveedor(string strCodProveedor)
        {
            return objDs.Recupera_msto_Proveedor(strCodProveedor);
        }

        public int Graba_msto_Proveedor(Model.Proveedor objProveedor)
        {
            return objDs.Graba_msto_Proveedor(objProveedor);
        }


        public DataSet Ayuda_msto_Proveedor()
        {
            return objDs.Ayuda_msto_Proveedor();
        }


        #endregion

        #region Material
        public Model.Material Recupera_Material(string strCodMaterial)
        {
            return objDs.Recupera_Material(strCodMaterial);
        }

        public Model.Servicio Recupera_Servicio(string strCodServicio)
        {
            return objDs.Recupera_Servicio(strCodServicio);
        }

        public DataSet Ayuda_Material(string strTexto)
        {
            return objDs.Ayuda_Material(strTexto);
        }

        public DataSet Ayuda_Servicio(string strCodPosPre)
        {
            return objDs.Ayuda_Servicio(strCodPosPre);
        }
        #endregion

        #region Reporte

        public DataSet Reporte_Pac_Paso_CurvaS( string strNumProcedimiento )
        {
            return objDs.Reporte_Pac_Paso_CurvaS( strNumProcedimiento );
        }

        public DataSet Reporte_Pac_Paso_Gantt(string strNumProcedimiento)
        {
            return objDs.Reporte_Pac_Paso_Gantt(strNumProcedimiento);
        }
        public DataSet Reporte_Cotizaciones(string strCodEmpresa, string strNumProcedimiento)
        {
            return objDs.Reporte_Cotizaciones(strCodEmpresa,strNumProcedimiento);
        }
        public DataSet Reporte_Pac_Paso_Gantt(string strAñoProceso,
                                        string strVersion,
                                        string strNumProcedimiento
                                            )
        {
            return objDs.Reporte_Pac_Paso_Gantt( strAñoProceso,
                                         strVersion,
                                         strNumProcedimiento
                                            );
        }

        #endregion

        #region Varios
        public DataSet Combo_PeriodoProceso()
        {
            return objDs.Combo_PeriodoProceso();
        }

        public DataSet Combo_Version(string strPeriodoProceso)
        {
            return objDs.Combo_Version(strPeriodoProceso);
        }

        public DataSet Combo_Version_Formulacion(string strPeriodoProceso)
        {
            return objDs.Combo_Version_Formulacion(strPeriodoProceso);
        }


        #endregion

        #region PATRIMONIO
        #region MotivoBaja
        public DataSet Combo_MotivoBaja()
        {
            return objDs.Combo_MotivoBaja();
        }

        public Model.MotivoBaja Recupera_MotivoBaja(int intIdMotivoBaja)
        {
            return objDs.Recupera_MotivoBaja(intIdMotivoBaja);
        }

        public int Graba_MotivoBaja(string strCodMotivoBaja, string strDesMotivoBaja)
        {
            return objDs.Graba_MotivoBaja(strCodMotivoBaja, strDesMotivoBaja);
        }
        public int Modifica_MotivoBaja(int intIdMotivoBaja, string strCodMotivoBaja, string strDesMotivoBaja)
        {
            return objDs.Modifica_MotivoBaja(intIdMotivoBaja, strCodMotivoBaja, strDesMotivoBaja);
        }

        public int Elimina_MotivoBaja(int intIdMotivoBaja)
        {
            return objDs.Elimina_MotivoBaja(intIdMotivoBaja);
        }

        #endregion

        #region OtrosDatos
        public DataSet Ayuda_TipoIncorporacion()
        {
            return objDs.Ayuda_TipoIncorporacion();
        }
        public DataSet Ayuda_ClasePatrimonio()
        {
            return objDs.Ayuda_ClasePatrimonio();
        }

        public DataSet Ayuda_Actividad()
        {
            return objDs.Ayuda_Actividad();
        }

        public DataSet Ayuda_SubActividad(string strCodActividad)
        {
            return objDs.Ayuda_SubActividad(strCodActividad);
        }

        public DataSet Ayuda_Componente(string strCodActividad)
        {
            return objDs.Ayuda_Componente(strCodActividad);
        }

        public DataSet Ayuda_TipoPatrimonio()
        {
            return objDs.Ayuda_TipoPatrimonio();
        }

        public DataSet Ayuda_EstadoConservacion()
        {
            return objDs.Ayuda_EstadoConservacion();
        }

        public DataSet Ayuda_MetodoDepreciacion()
        {
            return objDs.Ayuda_MetodoDepreciacion();
        }

        public DataSet Ayuda_Componente_VidaUtil(string strCodActividad,
                                                  string strCodComponente
                                                )
        {
            return objDs.Ayuda_Componente_VidaUtil(strCodActividad,
                                              strCodComponente
                                                );
        }

        public DataSet Ayuda_SupraNumero()
        {
            return objDs.Ayuda_SupraNumero();
        }

        public DataSet Ayuda_TipoFactorCalculo()
        {
            return objDs.Ayuda_TipoFactorCalculo();
        }

        #endregion

        #region Patrimonio
        public Model.Patrimonio Recupera_Patrimonio(string strCodPatrimonio)
        {
            return objDs.Recupera_Patrimonio(strCodPatrimonio);
        }


        public Model.Patrimonio Graba_Patrimonio(Model.Patrimonio obj)
        {
            return objDs.Graba_Patrimonio(obj);
        }


        public Boolean Modifica_Patrimonio(Model.Patrimonio obj)
        {
            return objDs.Modifica_Patrimonio(obj);
        }

        public Boolean Elimina_Patrimonio(string strCodPatrimonio)
        {
            return objDs.Elimina_Patrimonio(strCodPatrimonio);
        }

        public DataSet Ayuda_Patrimonio()
        {
            return objDs.Ayuda_Patrimonio();
        }

        public DataSet Lista_Patrimonio_ErroresDepreciacion()
        {
            return objDs.Lista_Patrimonio_ErroresDepreciacion();
        }

        #endregion

        #region Patrimonio_Depreciacion
        public Model.Patrimonio_Depreciacion Recupera_Patrimonio_Depreciacion(string strPeriodo,
                                                                        string strCodSegmento,
                                                                        string strCodPatrimonio
                                                                       )
        {
            return objDs.Recupera_Patrimonio_Depreciacion(strPeriodo,
                                                    strCodSegmento,
                                                    strCodPatrimonio
                                                                       );
        }
        public Model.Patrimonio_Depreciacion Recupera_Patrimonio_Depreciacion_Componente(string strPeriodo,
                                                                                         string strCodSegmento,
                                                                                         string strCodPatrimonio
                                                                                        )
        {
            return objDs.Recupera_Patrimonio_Depreciacion_Componente(strPeriodo,
                                                                                         strCodSegmento,
                                                                                         strCodPatrimonio
                                                                                        );
        }

        #endregion

        #region Patrimonio_Origen
        public Model.Patrimonio_Origen Recupera_Patrimonio_Origen(int intIdPatrimonio_Origen)
        {
            return objDs.Recupera_Patrimonio_Origen(intIdPatrimonio_Origen);
        }


        public Model.Patrimonio_Origen Graba_Patrimonio_Origen(Model.Patrimonio_Origen obj)
        {
            return objDs.Graba_Patrimonio_Origen(obj);
        }


        public Boolean Modifica_Patrimonio_Origen(Model.Patrimonio_Origen obj)
        {
            return objDs.Modifica_Patrimonio_Origen(obj);
        }

        public Boolean Elimina_Patrimonio_Origen(int intIdPatrimonio_Origen)
        {
            return objDs.Elimina_Patrimonio_Origen(intIdPatrimonio_Origen);
        }

        #endregion

        #region Patrimonio_Resguardo
        public Model.Patrimonio_Resguardo Recupera_Patrimonio_Resguardo(int intIdPatrimonio_Resguardo)
        {
            return objDs.Recupera_Patrimonio_Resguardo(intIdPatrimonio_Resguardo);
        }


        public Model.Patrimonio_Resguardo Graba_Patrimonio_Resguardo(Model.Patrimonio_Resguardo obj)
        {
            return objDs.Graba_Patrimonio_Resguardo(obj);
        }


        public Boolean Modifica_Patrimonio_Resguardo(Model.Patrimonio_Resguardo obj)
        {
            return objDs.Modifica_Patrimonio_Resguardo(obj);
        }

        public Boolean Elimina_Patrimonio_Resguardo(int intIdPatrimonio_Resguardo)
        {
            return objDs.Elimina_Patrimonio_Resguardo(intIdPatrimonio_Resguardo);
        }

        #endregion

        #region Patrimonio_Saldos
        public Model.Patrimonio_Saldos Recupera_Patrimonio_Saldos(string strCodSegmento,
                                                            string strCodCentro,
                                                            string strCodEmplazamiento,
                                                            string strCodCentroCosto,
                                                            string strCodPatrimonio
                                                         )
        {
            return objDs.Recupera_Patrimonio_Saldos(strCodSegmento,
                                              strCodCentro,
                                              strCodEmplazamiento,
                                              strCodCentroCosto,
                                              strCodPatrimonio
                                                         );
        }

        #endregion

        #region Patrimonio_TipoMovimiento
        public Model.Patrimonio_TipoMovimiento Recupera_TipoMovimientoPatrimonio_Codigo(string strCodTipoMovimientoPatrimonio)
        {
            return objDs.Recupera_TipoMovimientoPatrimonio_Codigo(strCodTipoMovimientoPatrimonio);
        }
        public string recupera_TipoMovimientoPatrimonio_Correlativo(string strCodCentro, string strCodTipoMovimientoPatrimonio)
        {
            return objDs.recupera_TipoMovimientoPatrimonio_Correlativo(strCodCentro, strCodTipoMovimientoPatrimonio);
        }

        public int Graba_TipoMovimientoPatrimonio(Model.Patrimonio_TipoMovimiento obj)
        {
            return objDs.Graba_TipoMovimientoPatrimonio(obj);
        }
        public int Graba_TipoMovimientoPatrimonio_Correlativo(string strCodCentro,
                                                                string strCodTipoMovimientoPatrimonio,
                                                                string strNumTransaccion
                                                              )
        {
            return objDs.Graba_TipoMovimientoPatrimonio_Correlativo( strCodCentro,
                                                               strCodTipoMovimientoPatrimonio,
                                                               strNumTransaccion
                                                              );
        }

        public int Modifica_TipoMovimientoPatrimonio(Model.Patrimonio_TipoMovimiento obj)
        {
            return objDs.Modifica_TipoMovimientoPatrimonio(obj);
        }


        #endregion

        #region Patrimonio_Transaccion
        public Model.Patrimonio_Transaccion Recupera_Patrimonio_Transaccion(int intIdPatrimonio_Transaccion)
        {
            return objDs.Recupera_Patrimonio_Transaccion(intIdPatrimonio_Transaccion);
        }


        public string Graba_Patrimonio_Transaccion(Model.Patrimonio_Transaccion obj)
        {
            return objDs.Graba_Patrimonio_Transaccion(obj);
        }


        public Boolean Modifica_Patrimonio_Transaccion(Model.Patrimonio_Transaccion obj)
        {
            return objDs.Modifica_Patrimonio_Transaccion(obj);
        }

        public Boolean Elimina_Patrimonio_Transaccion(int intIdPatrimonio_Transaccion)
        {
            return objDs.Elimina_Patrimonio_Transaccion(intIdPatrimonio_Transaccion);
        }

        public DataSet Lista_Patrimonio_Transaccion_para_transferencia(string strCodPatrimonio)
        {
            return objDs.Lista_Patrimonio_Transaccion_para_transferencia(strCodPatrimonio);
        }

        #endregion

        #region Patrimonio_Transferencia
        public Model.Patrimonio_Transferencia Recupera_Patrimonio_Transferencia(int intIdPatrimonio_Transferencia)
        {
            return objDs.Recupera_Patrimonio_Transferencia(intIdPatrimonio_Transferencia);
        }


        public Model.Patrimonio_Transferencia Graba_Patrimonio_Transferencia(Model.Patrimonio_Transferencia obj)
        {
            return objDs.Graba_Patrimonio_Transferencia(obj);
        }


        public Boolean Modifica_Patrimonio_Transferencia(Model.Patrimonio_Transferencia obj)
        {
            return objDs.Modifica_Patrimonio_Transferencia(obj);
        }

        public Boolean Elimina_Patrimonio_Transferencia(int intIdPatrimonio_Transferencia)
        {
            return objDs.Elimina_Patrimonio_Transferencia(intIdPatrimonio_Transferencia);
        }

        #endregion

        #region PeriodoProceso_Patrimonio
        public bool Graba_PeriodoProceso_Patrimonio(Model.PeriodoProceso_Patrimonio obj)
        {
            return objDs.Graba_PeriodoProceso_Patrimonio(obj);
        }
        public Model.PeriodoProceso_Patrimonio Recupera_PeriodoProceso_Patrimonio_Apertura(string strAñoProceso)
        {
            return objDs.Recupera_PeriodoProceso_Patrimonio_Apertura(strAñoProceso);
        }
        public Boolean Graba_PeriodoProceso_Patrimonio_Cierre(Model.PeriodoProceso_Patrimonio obj)
        {
            return objDs.Graba_PeriodoProceso_Patrimonio_Cierre(obj);
        }
        public int Recupera_PeriodoProceso_Patrimonio_ProcesoAnterior(Model.PeriodoProceso_Patrimonio obj)
        {
            return objDs.Recupera_PeriodoProceso_Patrimonio_ProcesoAnterior(obj);
        }
        public int Recupera_PeriodoProceso_Patrimonio_ProcesoActual(Model.PeriodoProceso_Patrimonio obj)
        {
            return objDs.Recupera_PeriodoProceso_Patrimonio_ProcesoActual(obj);
        }
        public Model.PeriodoProceso_Patrimonio Recupera_PeriodoProceso_Patrimonio(string strAñoProceso)
        {
            return objDs.Recupera_PeriodoProceso_Patrimonio(strAñoProceso);
        }
        public Model.PeriodoProceso_Patrimonio Recupera_PeriodoProceso_Patrimonio_PeriodoAnterior(string strAñoProceso)
        {
            return objDs.Recupera_PeriodoProceso_Patrimonio_PeriodoAnterior(strAñoProceso);
        }

        public bool Reapertura_PeriodoProceso_Patrimonio(string strPeriodo)
        {
            return objDs.Reapertura_PeriodoProceso_Patrimonio(strPeriodo);
        }

        public bool Recupera_PeriodoProceso_Patrimonio_Abierto()
        {
            return objDs.Recupera_PeriodoProceso_Patrimonio_Abierto();
        }

        #endregion

        #region RecomendacionBaja
        public DataSet Combo_RecomendacionBaja()
        {
            return objDs.Combo_RecomendacionBaja();
        }


        public Model.RecomendacionBaja Recupera_RecomendacionBaja(int intIdRecomendacionBaja)
        {
            return objDs.Recupera_RecomendacionBaja(intIdRecomendacionBaja);
        }

        public int Graba_RecomendacionBaja(string strCodRecomendacionBaja, string strDesRecomendacionBaja)
        {
            return objDs.Graba_RecomendacionBaja(strCodRecomendacionBaja, strDesRecomendacionBaja);
        }
        public int Modifica_RecomendacionBaja(int intIdRecomendacionBaja, string strCodRecomendacionBaja, string strDesRecomendacionBaja)
        {
            return objDs.Modifica_RecomendacionBaja(intIdRecomendacionBaja, strCodRecomendacionBaja, strDesRecomendacionBaja);
        }

        public int Elimina_RecomendacionBaja(int intIdRecomendacionBaja)
        {
            return objDs.Elimina_RecomendacionBaja(intIdRecomendacionBaja);
        }

        #endregion

        #region RecomendacionTransferencia
        public DataSet Combo_RecomendacionTransferencia()
        {
            return objDs.Combo_RecomendacionTransferencia();
        }

        public Model.RecomendacionTransferencia Recupera_RecomendacionTransferencia(int intIdRecomendacionTransferencia)
        {
            return objDs.Recupera_RecomendacionTransferencia(intIdRecomendacionTransferencia);
        }

        public Model.RecomendacionTransferencia Recupera_RecomendacionTransferencia_Codigo(string strCodRecomendacionTransferencia)
        {
            return objDs.Recupera_RecomendacionTransferencia_Codigo(strCodRecomendacionTransferencia);
        }


        public Model.RecomendacionTransferencia Graba_RecomendacionTransferencia(Model.RecomendacionTransferencia obj)
        {
            return objDs.Graba_RecomendacionTransferencia(obj);
        }


        public Boolean Modifica_RecomendacionTransferencia(Model.RecomendacionTransferencia obj)
        {
            return objDs.Modifica_RecomendacionTransferencia(obj);
        }

        public Boolean Elimina_RecomendacionTransferencia(int intIdRecomendacionTransferencia)
        {
            return objDs.Elimina_RecomendacionTransferencia(intIdRecomendacionTransferencia);
        }

        #endregion

        #region Parametro_Patrimonio
        public Model.Parametro_Patrimonio Recupera_Parametro_Patrimonio(int intIdParametroPatrimonio)
        {
            return objDs.Recupera_Parametro_Patrimonio(intIdParametroPatrimonio);
        }

        public Model.Parametro_Patrimonio Recupera_Parametro_Patrimonio_Codigo(string strCodParametroPatrimonio)
        {
            return objDs.Recupera_Parametro_Patrimonio_Codigo(strCodParametroPatrimonio);
        }


        public Model.Parametro_Patrimonio Graba_Parametro_Patrimonio(Model.Parametro_Patrimonio obj)
        {
            return objDs.Graba_Parametro_Patrimonio(obj);
        }


        public Boolean Modifica_Parametro_Patrimonio(Model.Parametro_Patrimonio obj)
        {
            return objDs.Modifica_Parametro_Patrimonio(obj);
        }

        public Boolean Elimina_Parametro_Patrimonio(int intIdParametroPatrimonio)
        {
            return objDs.Elimina_Parametro_Patrimonio(intIdParametroPatrimonio);
        }

        #endregion

        #region MotivoRevaluacion
        public DataTable Ayuda_MotivoRevaluacion()
        {
            return objDs.Ayuda_MotivoRevaluacion();
        }
        public DataTable Combo_MotivoRevaluacion()
        {
            return objDs.Combo_MotivoRevaluacion();
        }
        public Model.MotivoRevaluacion Recupera_MotivoRevaluacion(int intIdMotivoRevaluacion)
        {
            return objDs.Recupera_MotivoRevaluacion(intIdMotivoRevaluacion);
        }


        public Model.MotivoRevaluacion Recupera_MotivoRevaluacion_Codigo(string strCodMotivoRevaluacion)
        {
            return objDs.Recupera_MotivoRevaluacion_Codigo(strCodMotivoRevaluacion);
        }

        public int Graba_MotivoRevaluacion(Model.MotivoRevaluacion obj)
        {
            return objDs.Graba_MotivoRevaluacion( obj);
        }

        public int Modifica_MotivoRevaluacion(Model.MotivoRevaluacion obj)
        {
            return objDs.Modifica_MotivoRevaluacion(obj);
        }

        public bool Elimina_MotivoRevaluacion(int intIdMotivoRevaluacion)
        {
            return objDs.Elimina_MotivoRevaluacion(intIdMotivoRevaluacion);
        }

        public DataTable Lista_MotivoRevaluacion()
        {
            return objDs.Lista_MotivoRevaluacion();
        }

        public DataTable Arbol_MotivoRevaluacion()
        {
            return objDs.Arbol_MotivoRevaluacion();
        }

        #endregion

        #region MotivoTransferencia
        public DataSet Combo_MotivoTransferencia()
        {
            return objDs.Combo_MotivoTransferencia();
        }

        public Model.MotivoTransferencia Recupera_MotivoTransferencia(int intIdMotivoTransferencia)
        {
            return objDs.Recupera_MotivoTransferencia(intIdMotivoTransferencia);
        }

        public Model.MotivoTransferencia Recupera_MotivoTransferencia_Codigo(string strCodMotivoTransferencia)
        {
            return objDs.Recupera_MotivoTransferencia_Codigo(strCodMotivoTransferencia);
        }


        public Model.MotivoTransferencia Graba_MotivoTransferencia(Model.MotivoTransferencia obj)
        {
            return objDs.Graba_MotivoTransferencia(obj);
        }


        public Boolean Modifica_MotivoTransferencia(Model.MotivoTransferencia obj)
        {
            return objDs.Modifica_MotivoTransferencia(obj);
        }

        public Boolean Elimina_MotivoTransferencia(int intIdMotivoTransferencia)
        {
            return objDs.Elimina_MotivoTransferencia(intIdMotivoTransferencia);
        }

        #endregion

        #region TipoMovimientoPatrimonio
        public DataTable Combo_TipoMovimientoPatrimonio_Ajuste()
        {
            return objDs.Combo_TipoMovimientoPatrimonio_Ajuste();
        }
        public DataTable Combo_TipoMovimientoPatrimonio()
        {
            return objDs.Combo_TipoMovimientoPatrimonio();
        }
        public DataTable Lista_TipoMovimientoPatrimonio()
        {
            return objDs.Lista_TipoMovimientoPatrimonio();
        }

        public DataTable Arbol_TipoMovimientoPatrimonio()
        {
            return objDs.Arbol_TipoMovimientoPatrimonio();
        }

        public Model.TipoMovimientoPatrimonio Recupera_TipoMovimientoPatrimonio(int intIdTipoMovimientoPatrimonio)
        {
            return objDs.Recupera_TipoMovimientoPatrimonio(intIdTipoMovimientoPatrimonio);
        }
        public int Graba_TipoMovimientoPatrimonio(Model.TipoMovimientoPatrimonio obj)
        {
            return objDs.Graba_TipoMovimientoPatrimonio(obj);
        }
        public int Modifica_TipoMovimientoPatrimonio(Model.TipoMovimientoPatrimonio obj)
        {
            return objDs.Modifica_TipoMovimientoPatrimonio(obj);
        }

        public bool Elimina_TipoMovimientoPatrimonio(int intIdTipoMovimientoPatrimonio)
        {
            return objDs.Elimina_TipoMovimientoPatrimonio(intIdTipoMovimientoPatrimonio);
        }

        #endregion

        #endregion

        #region PRESUPUESTO
        #region Actividad
        public DataSet Ayuda_Actividad(string strCodCompañia)
        {
            return objDs.Ayuda_Actividad(strCodCompañia);
        }
        public DataSet Lista_Actividad(string strCodCompañia)
        {
            return objDs.Lista_Actividad(strCodCompañia);
        }

        public DataSet Naturaleza_Actividad(string strCodCompañia)
        {
            return objDs.Naturaleza_Actividad(strCodCompañia);
        }

        public DataSet Combo_Actividad_Reporte(string strCodCompañia)
        {
            return objDs.Combo_Actividad_Reporte(strCodCompañia);
        }

        public DataSet Combo_Actividad(string strCodCompañia)
        {
            return objDs.Combo_Actividad(strCodCompañia);
        }
        public Model.Actividad Recupera_Actividad(int intIdActividad)
        {
            return objDs.Recupera_Actividad(intIdActividad);
        }

        public Model.Actividad Recupera_Actividad_codigo(string strCodCompañia,
                                                          string strCodActividad
                                                        )
        {
            return objDs.Recupera_Actividad_codigo(strCodCompañia,
                                              strCodActividad
                                                        );
        }
        public int Graba_Actividad(Model.Actividad obj)
        {
            return objDs.Graba_Actividad(obj);
        }
        public int Modifica_Actividad(Model.Actividad obj)
        {
            return objDs.Modifica_Actividad(obj);
        }

        public bool Elimina_Actividad(int intIdActividad)
        {
            return objDs.Elimina_Actividad(intIdActividad);
        }
        #endregion

        #region CentroBeneficio
        public DataSet Combo_CentroBeneficio(string strCodCompañia)
        {
            return objDs.Combo_CentroBeneficio(strCodCompañia);
        }

        public DataSet Ayuda_CentroBeneficio(string strCodCompañia)
        {
            return objDs.Ayuda_CentroBeneficio(strCodCompañia);
        }

        public Model.CentroBeneficio Recupera_CentroBeneficio(int intIdCentroBeneficio)
        {
            return objDs.Recupera_CentroBeneficio(intIdCentroBeneficio);
        }


        public Model.CentroBeneficio Recupera_CentroBeneficio_Codigo(string strCodCompañia,
                                                                      string strCodCentroBeneficio
                                                                    )
        {
            return objDs.Recupera_CentroBeneficio_Codigo(strCodCompañia,
                                                                  strCodCentroBeneficio
                                                                    );
        }

        public int Graba_CentroBeneficio(Model.CentroBeneficio obj)
        {
            return objDs.Graba_CentroBeneficio(obj);
        }

        public int Modifica_CentroBeneficio(Model.CentroBeneficio obj)
        {
            return objDs.Modifica_CentroBeneficio(obj);
        }

        public bool Elimina_CentroBeneficio(int intIdCentroBeneficio)
        {
            return objDs.Elimina_CentroBeneficio(intIdCentroBeneficio);
        }

        public DataSet Lista_CentroBeneficio(string strCodCompañia)
        {
            return objDs.Lista_CentroBeneficio(strCodCompañia);
        }

        #endregion

        #region CentroCosto
        public Model.CentroCosto Recupera_CentroCosto_Codigo(   string strCodEmpresa,
                                                                string strCodCentroCosto
                                                            )
        {
            return objDs.Recupera_CentroCosto_Codigo( strCodEmpresa, strCodCentroCosto);
        }


        public Model.CentroCosto Recupera_CentroCosto(string intIdCentroCosto)
        {
            return objDs.Recupera_CentroCosto(intIdCentroCosto);
        }

        public DataSet Ayuda_CentroCosto(string strCodCompañia)
        {
            return objDs.Ayuda_CentroCosto(strCodCompañia);
        }

        public bool Procesa_AperturaVersion( Model.Formulacion_HojaTrabajo_Cabecera obj, 
                                              bool TrasladaInformacion,
                                              bool TrasladaApertura
                                            )
        {
            return objDs.Procesa_AperturaVersion(obj,TrasladaInformacion,TrasladaApertura);
        }

        public bool Procesa_AperturaPeriodo(Model.Formulacion_HojaTrabajo_Cabecera obj,
                                              bool TrasladaApertura
                                            )
        {
            return objDs.Procesa_AperturaPeriodo(obj, TrasladaApertura);
        }

        public bool Procesa_AperturaVersion_Ajuste(Model.Formulacion_HojaTrabajo_Cabecera obj )
        {
            return objDs.Procesa_AperturaVersion_Ajuste(obj);
        }

        public bool Procesa_DistribucionAjuste(Model.Formulacion_HojaTrabajo_Cabecera obj)
        {
            return objDs.Procesa_DistribucionAjuste(obj);
        }

        public DataSet Ayuda_CentroCosto_Formulacion_HojaTrabajo(string strCodCompañia,
                                                                 string strAñoProceso,
                                                                 string strPeriodo,
                                                                 string strCodCentroGestor,
                                                                 string strCodCentroCosto)
        {
            return objDs.Ayuda_CentroCosto_Formulacion_HojaTrabajo(strCodCompañia,strAñoProceso,strPeriodo,strCodCentroGestor,strCodCentroCosto);
        }

        public DataSet Ayuda_CentroCosto_Total(string strCodCompañia)
        {
            return objDs.Ayuda_CentroCosto_Total(strCodCompañia);
        }

        public DataSet Ayuda_CentroGestor_Total(string strCodCompañia)
        {
            return objDs.Ayuda_CentroGestor_Total(strCodCompañia);
        }

        public bool Elimina_HojaTrabajo_Formulacion_Formato( string strCodEmpresa,
                                                             string strAñoProceso,
                                                             string strVersion,
                                                             string strPeriodo,
                                                             string strCodTipoFormulacion,
                                                             string strCodSubTipoFormulacion
                                                            )
        {
            return objDs.Elimina_HojaTrabajo_Formulacion_Formato(strCodEmpresa,
                                                              strAñoProceso,
                                                              strVersion,
                                                              strPeriodo,
                                                              strCodTipoFormulacion,
                                                              strCodSubTipoFormulacion
                                                             );
        }

        public DataSet Ayuda_CentroCosto_Todos()
        {
            return objDs.Ayuda_CentroCosto_Todos();
        }

        public DataSet Ayuda_CentroCosto_CentroGestor(string strCodEmpresa, string strcodCentroGestor)
        {
            return objDs.Ayuda_CentroCosto_CentroGestor( strCodEmpresa, strcodCentroGestor);
        }

        public DataSet Combo_CentroCosto_CentroGestor(string strcodCentroGestor)
        {
            return objDs.Combo_CentroCosto_CentroGestor(strcodCentroGestor);
        }

        public bool Elimina_CentroCosto(int intidCentroCosto)
        {
            return objDs.Elimina_CentroCosto(intidCentroCosto);
        }

        public int Graba_CentroCosto(Model.CentroCosto obj)
        {
            return objDs.Graba_CentroCosto(obj);
        }

        public int Modifica_CentroCosto(Model.CentroCosto obj)
        {
            return objDs.Modifica_CentroCosto(obj);
        }

        public DataSet Lista_CentroCosto(string strCodEmpresa)
        {
            return objDs.Lista_CentroCosto(strCodEmpresa);
        }

        #endregion

        #region OrdenTrabajo
        public Model.OrdenTrabajo Recupera_OrdenTrabajo_Codigo(string strCodEmpresa,
                                                                string strNumOrdenTrabajo
                                                            )
        {
            return objDs.Recupera_OrdenTrabajo_Codigo(strCodEmpresa, strNumOrdenTrabajo);
        }


        public Model.OrdenTrabajo Recupera_OrdenTrabajo(string intIdCentroCosto)
        {
            return objDs.Recupera_OrdenTrabajo(intIdCentroCosto);
        }


        public bool Elimina_OrdenTrabajo(int intidOrdenTrabajo)
        {
            return objDs.Elimina_OrdenTrabajo(intidOrdenTrabajo);
        }

        public int Graba_OrdenTrabajo(Model.OrdenTrabajo obj)
        {
            return objDs.Graba_OrdenTrabajo(obj);
        }

        public int Modifica_OrdenTrabajo(Model.OrdenTrabajo obj)
        {
            return objDs.Modifica_OrdenTrabajo(obj);
        }

        public DataSet Lista_OrdenTrabajo(string strCodEmpresa)
        {
            return objDs.Lista_OrdenTrabajo(strCodEmpresa);
        }
        public DataSet Ayuda_ClaseOrdenTrabajo(string strCodEmpresa)
        {
            return objDs.Ayuda_ClaseOrdenTrabajo(strCodEmpresa);
        }


        #endregion

        #region CentroGestor

        public int Graba_HojaTrabajo_Cabecera(Model.Formulacion_HojaTrabajo_Cabecera obj)
        {
            return objDs.Graba_HojaTrabajo_Cabecera(obj);
        }

        public bool Traslada_HojaTrabajo_ModificacionFormulacion_Saldos(Model.Formulacion_HojaTrabajo_Cabecera obj,
                                                                         bool blnTraslada_CentroCosto,
                                                                         bool blnTraslada_PosicionPresupuestal,
                                                                         bool blnTraslada_Proyecto,
                                                                         bool blnTraslada_Apertura
                                                                         )
        {
            return objDs.Traslada_HojaTrabajo_ModificacionFormulacion_Saldos(obj,
                                                                              blnTraslada_CentroCosto,
                                                                              blnTraslada_PosicionPresupuestal,
                                                                              blnTraslada_Proyecto,
                                                                               blnTraslada_Apertura
                                                                             );
        }
        public bool Traslada_HojaTrabajo_Formulacion_PIA(Model.Formulacion_HojaTrabajo_Cabecera obj)
        {
            return objDs.Traslada_HojaTrabajo_Formulacion_PIA(obj);
        }

        public Model.Formulacion_HojaTrabajo_Cabecera recupera_HojaTrabajo_Apertura(string strCodCompañia,
                                                                             string strAñoProceso,
                                                                             string strPeriodo
                                                                            )
        {
            return objDs.recupera_HojaTrabajo_Apertura(strCodCompañia,
                                                        strAñoProceso,
                                                        strPeriodo
                                                      );
        }

        public string recupera_HojaTrabajo_HallarVersion( string strCodCompañia,
                                                          string strAñoProceso
                                                        )
        {
            return objDs.recupera_HojaTrabajo_HallarVersion( strCodCompañia,
                                                             strAñoProceso
                                                           );
        }


        public DataSet Ayuda_CentroGestor_Proyecto(string strCodCompañia,
                                           string strCodCentroGestor,
                                           string strTipoProyecto,
                                           string strPeriodo
                                          )
        {
            return objDs.Ayuda_CentroGestor_Proyecto( strCodCompañia,
                                            strCodCentroGestor,
                                            strTipoProyecto,
                                            strPeriodo
                                          );
        }

        public DataSet Ayuda_CentroCosto_Proyecto(string strCodCompañia,
                                            string strAñoProceso,
                                            string strPeriodo,
                                            string strCodCentroCosto,
                                            string strTipoProyecto
                                          )
        {
            return objDs.Ayuda_CentroCosto_Proyecto(strCodCompañia,
                                            strAñoProceso,
                                            strPeriodo,
                                            strCodCentroCosto,
                                            strTipoProyecto
                                          );
        }

        public DataSet Ayuda_CentroGestorSuperior(string strCodCompañia,
                                                  string strCodCentroGestor
                                                 )
        {
            return objDs.Ayuda_CentroGestorSuperior( strCodCompañia,
                                                strCodCentroGestor
                                                 );
        }

        public DataSet Ayuda_CentroCostoFormulacion_HojaTrabajo_Filtro(    string strCodEmpresa,
                                                                    string strAño,
                                                                    string strPeriodo,
                                                                    string strCodCentroGestor,
                                                                    string strCodCentroCosto
                                                                )
        {
            return objDs.Ayuda_CentroCostoFormulacion_HojaTrabajo_Filtro(  strCodEmpresa,
                                                                    strAño,
                                                                    strPeriodo,
                                                                    strCodCentroGestor,
                                                                    strCodCentroCosto
                                                                 );
        }

        public DataSet Ayuda_CentroCostoFormulacion_HojaTrabajo_Filtro_ControlTotal(string strCodEmpresa,
                                                                    string strAño,
                                                                    string strPeriodo,
                                                                    string strCodCentroGestor
                                                                )
        {
            return objDs.Ayuda_CentroCostoFormulacion_HojaTrabajo_Filtro_ControlTotal(strCodEmpresa,
                                                                    strAño,
                                                                    strPeriodo,
                                                                    strCodCentroGestor
                                                                 );
        }

        public DataSet Ayuda_CentroCostoFormulacion_HojaTrabajo_Control(string strCodEmpresa,
                                                            string strAño,
                                                            string strPeriodo,
                                                            string strCodCentroGestor
                                                        )
        {
            return objDs.Ayuda_CentroCostoFormulacion_HojaTrabajo_Control(strCodEmpresa,
                                                                    strAño,
                                                                    strPeriodo,
                                                                    strCodCentroGestor
                                                                 );
        }

        public DataSet Ayuda_CentroCostoFormulacion_Control(string strCodEmpresa,
                                                    string strCodCentroGestor
                                                )
        {
            return objDs.Ayuda_CentroCostoFormulacion_Control(strCodEmpresa,
                                                                    strCodCentroGestor
                                                                 );
        }


        public DataSet Ayuda_TipoFormulacion()
        {
            return objDs.Ayuda_TipoFormulacion();
        }

        public DataSet Ayuda_CentroGestor(string strCodCompañia)
        {
            return objDs.Ayuda_CentroGestor(strCodCompañia);
        }

        public DataSet Ayuda_CentroGestor_Formulacion(string strCodEmpresa,
                                                        string strAñoProceso,
                                                        string strPeriodo
                                                      )
        {
            return objDs.Ayuda_CentroGestor_Formulacion(strCodEmpresa,strAñoProceso,strPeriodo);
        }

        public Model.CentroGestor Recupera_CentroGestor_Codigo(string strCodCompañia,
                                                                string strCodCentroGestor
                                                            )
        {
            return objDs.Recupera_CentroGestor_Codigo(strCodCompañia,
                                                strCodCentroGestor
                                                            );
        }

        public Model.CentroGestor Recupera_CentroGestor_Superior(string strCodCompañia,
                                                                  string strCodCentroCosto
                                                                )
        {
            return objDs.Recupera_CentroGestor_Superior(strCodCompañia,
                                                                  strCodCentroCosto
                                                                );
        }

        public Model.CentroGestor Recupera_CentroGestor(int intIdCentroGestor)
        {
            return objDs.Recupera_CentroGestor(intIdCentroGestor);
        }


        public DataSet Lista_Cege_Clasificador_x_Elegir(string strCodCompañia,
                                                        string strCodCentroGestor

                             )
        {
            return objDs.Lista_Cege_Clasificador_x_Elegir(strCodCompañia,
                                                    strCodCentroGestor

                             );
        }


        public bool Elimina_CentroGestor(int intidCentroGestor)
        {
            return objDs.Elimina_CentroGestor(intidCentroGestor);
        }

        public DataSet Lista_Cege_Proyecto(string strCodCompañia,
                                            string strAñoProceso,
                                            string strPeriodo,
                                            string strCodCentroGestor

                                          )
        {
            return objDs.Lista_Cege_Proyecto(strCodCompañia,
                                        strAñoProceso,
                                        strPeriodo,
                                        strCodCentroGestor

                                          );
        }

        public DataSet Lista_CeCo_Proyecto(string strCodEmpresa,
                                            string strAñoProceso,
                                            string strPeriodo,
                                            string strCodCentroCosto

                                          )
        {
            return objDs.Lista_CeCo_Proyecto(strCodEmpresa,
                                        strAñoProceso,
                                        strPeriodo,
                                        strCodCentroCosto

                                          );
        }

        public DataSet Lista_CeCo_Proyecto_Total(string strCodEmpresa,
                                            string strAñoProceso,
                                            string strPeriodo

                                          )
        {
            return objDs.Lista_CeCo_Proyecto_Total(strCodEmpresa,
                                        strAñoProceso,
                                        strPeriodo

                                          );
        }

        public DataSet Lista_CeCo_PosicionPresupuestal(string strCodEmpresa,
                                            string strAñoProceso,
                                            string strPeriodo,
                                            string strCodCentroCosto

                                          )
        {
            return objDs.Lista_CeCo_PosicionPresupuestal(strCodEmpresa,
                                        strAñoProceso,
                                        strPeriodo,
                                        strCodCentroCosto

                                          );
        }

        public DataSet Lista_CeCo_PosicionPresupuestal_Total(string strCodEmpresa,
                                    string strAñoProceso,
                                    string strPeriodo

                                  )
        {
            return objDs.Lista_CeCo_PosicionPresupuestal_Total(strCodEmpresa,
                                        strAñoProceso,
                                        strPeriodo

                                          );
        }


        public Boolean Graba_CentroGestor_Proyecto(string strCodCompañia,
                                                string strAñoProceso,
                                                string strPeriodo,
                                                string strCodCege,
                                                string strCodProyecto
                                              )
        {
            return objDs.Graba_CentroGestor_Proyecto( strCodCompañia,
                                                 strAñoProceso,
                                                strPeriodo,
                                                strCodCege,
                                                strCodProyecto
                                              );
        }

        public Boolean Graba_CentroCosto_Proyecto(string strCodEmpresa,
                                                string strAñoProceso,
                                                string strPeriodo,
                                                string strCodCeCo,
                                                string strCodProyecto
                                              )
        {
            return objDs.Graba_CentroCosto_Proyecto(strCodEmpresa,
                                                 strAñoProceso,
                                                strPeriodo,
                                                strCodCeCo,
                                                strCodProyecto
                                              );
        }

        public Boolean Graba_CentroCosto_PosicionPresupuestal(string strCodEmpresa,
                                                string strAñoProceso,
                                                string strPeriodo,
                                                string strCodCeCo,
                                                string strCodPosPre
                                              )
        {
            return objDs.Graba_CentroCosto_PosicionPresupuestal(strCodEmpresa,
                                                 strAñoProceso,
                                                strPeriodo,
                                                strCodCeCo,
                                                strCodPosPre
                                              );
        }

        public Boolean Elimina_CentroGestor_Proyecto(string strCodCompañia,
                                                string strAñoProceso,
                                                string strPeriodo,
                                                string strCodCege,
                                                string strCodProyecto
                                              )
        {
            return objDs.Elimina_CentroGestor_Proyecto( strCodCompañia,
                                                 strAñoProceso,
                                                 strPeriodo,
                                                 strCodCege,
                                                 strCodProyecto
                                              );
        }

        public Boolean Elimina_CentroCosto_Proyecto(string strCodEmpresa,
                                                string strAñoProceso,
                                                string strPeriodo,
                                                string strCodCeCo,
                                                string strCodProyecto
                                              )
        {
            return objDs.Elimina_CentroCosto_Proyecto(strCodEmpresa,
                                                 strAñoProceso,
                                                 strPeriodo,
                                                 strCodCeCo,
                                                 strCodProyecto
                                              );
        }

        public Boolean Elimina_CentroCosto_PosicionPresupuestal(string strCodEmpresa,
                                                string strAñoProceso,
                                                string strPeriodo,
                                                string strCodCeCo,
                                                string strCodPosPre
                                              )
        {
            return objDs.Elimina_CentroCosto_PosicionPresupuestal(strCodEmpresa,
                                                 strAñoProceso,
                                                 strPeriodo,
                                                 strCodCeCo,
                                                 strCodPosPre
                                              );
        }

        public DataSet Lista_Cege_Clasificador(string strCodCompañia,
                                            string strAñoProceso,
                                            string strPeriodo,
                                            string strCodCentroGestor

                                          )
        {
            return objDs.Lista_Cege_Clasificador( strCodCompañia,
                                            strAñoProceso,
                                            strPeriodo,
                                            strCodCentroGestor

                                          );
        }

        public DataSet Lista_Cege_CentroCosto(string strCodCompañia,
                                            string strAñoProceso,
                                            string strPeriodo,
                                            string strCodCentroGestor,
                                            string strCodCentroCosto,
                                            string TodosLosCeCos

                                          )
        {
            return objDs.Lista_Cege_CentroCosto(strCodCompañia,
                                            strAñoProceso,
                                            strPeriodo,
                                            strCodCentroGestor,
                                            strCodCentroCosto,
                                            TodosLosCeCos

                                          );
        }

        public DataSet Lista_Cege_CentroCosto_Total(string strCodCompañia,
                                    string strAñoProceso,
                                    string strPeriodo

                                  )
        {
            return objDs.Lista_Cege_CentroCosto_Total(strCodCompañia,
                                            strAñoProceso,
                                            strPeriodo

                                          );
        }


        public Boolean Graba_CentroGestor_Clasificador(string strCodCompañia,
                                                string strAñoProceso,
                                                string strPeriodo,
                                                string strCodCege,
                                                string strCodClasificador
                                              )
        {
            return objDs.Graba_CentroGestor_Clasificador(strCodCompañia,
                                                 strAñoProceso,
                                                 strPeriodo,
                                                 strCodCege,
                                                 strCodClasificador
                                              );
        }

        public Boolean Graba_CentroGestor_CentroCosto(string strCodCompañia,
                                                string strAñoProceso,
                                                string strPeriodo,
                                                string strCodCege,
                                                string strCodCeco,
                                                string strCodCentroCosto
                                              )
        {
            return objDs.Graba_CentroGestor_CentroCosto(strCodCompañia,
                                                 strAñoProceso,
                                                 strPeriodo,
                                                 strCodCege,
                                                 strCodCeco,
                                                 strCodCentroCosto
                                              );
        }

        public Boolean Elimina_CentroGestor_Clasificador(string strCodCompañia,
                                                string strAñoProceso,
                                                string strPeriodo,
                                                string strCodCege,
                                                string strCodClasificador
                                              )
        {
            return objDs.Elimina_CentroGestor_Clasificador(strCodCompañia,
                                                 strAñoProceso,
                                                 strPeriodo,
                                                 strCodCege,
                                                 strCodClasificador
                                              );
        }

        public Boolean Elimina_CentroGestor_CentroCosto(string strCodCompañia,
                                                string strAñoProceso,
                                                string strPeriodo,
                                                string strCodCege,
                                                string strCodCeco,
                                                string strCodCentroCosto
                                              )
        {
            return objDs.Elimina_CentroGestor_CentroCosto(strCodCompañia,
                                                 strAñoProceso,
                                                 strPeriodo,
                                                 strCodCege,
                                                 strCodCeco,
                                                 strCodCentroCosto
                                              );
        }

        public int Graba_CentroGestor(Model.CentroGestor obj)
        {
            return objDs.Graba_CentroGestor(obj);
        }

        public int Modifica_CentroGestor(Model.CentroGestor obj)
        {
            return objDs.Modifica_CentroGestor(obj);
        }

        public DataSet Lista_CentroGestor(string strCodCompañia)
        {
            return objDs.Lista_CentroGestor(strCodCompañia);
        }
        #endregion

        #region Clasificador
        public DataSet Ayuda_Clasificador(string strCodCompañia, string strCodClasificador, string strCodCentroGestor)
        {
            return objDs.Ayuda_Clasificador(strCodCompañia, strCodClasificador, strCodCentroGestor);
        }
        public DataSet Ayuda_Clasificador_Inversion(string strCodCompañia, string strCodProyecto, string strCodClasificador, string strCodCentroGestor)
        {
            return objDs.Ayuda_Clasificador_Inversion(strCodCompañia, strCodProyecto, strCodClasificador, strCodCentroGestor);
        }

        public DataSet Ayuda_Clasificador_Otro(string strCodCompañia, string strCodClasificador, string strCodCentroGestor)
        {
            return objDs.Ayuda_Clasificador_Otro(strCodCompañia, strCodClasificador,strCodCentroGestor);
        }

        public DataSet Ayuda_Clasificador_Tarea(string strCodCompañia, string strCodProyecto, string strCodClasificador, string strCodCentroGestor)
        {
            return objDs.Ayuda_Clasificador_Tarea(strCodCompañia, strCodProyecto, strCodClasificador, strCodCentroGestor);
        }

        public DataSet Ayuda_Clasificador_Ingreso(string strCodCompañia, string strCodCentroGestor)
        {
            return objDs.Ayuda_Clasificador_Ingreso(strCodCompañia, strCodCentroGestor);
        }

        public DataSet Ayuda_Clasificador_General(string strCodCompañia)
        {
            return objDs.Ayuda_Clasificador_General(strCodCompañia);
        }

        public DataSet Lista_Clasificador(string strCodCompañia)
        {
            return objDs.Lista_Clasificador(strCodCompañia);
        }
        public DataSet Lista_AgrupadorClasificador(string strCodCompañia)
        {
            return objDs.Lista_AgrupadorClasificador(strCodCompañia);
        }


        public Model.Clasificador Recupera_Clasificador_Codigo(string strCodCompañia,
                                                                string strCodClasificador)
        {
            return objDs.Recupera_Clasificador_Codigo(strCodCompañia,
                                                                strCodClasificador);
        }

        public Model.AgrupadorClasificador Recupera_AgrupadorClasificador_Codigo(string strCodCompañia,
                                                                string strCodAgrupador)
        {
            return objDs.Recupera_AgrupadorClasificador_Codigo(strCodCompañia,
                                                                strCodAgrupador);
        }

        public Model.Clasificador Recupera_Clasificador(int intIdClasificador)
        {
            return objDs.Recupera_Clasificador(intIdClasificador);
        }

        public int Graba_Clasificador(Model.Clasificador obj)
        {
            return objDs.Graba_Clasificador(obj);
        }
        public int Graba_AgrupadorClasificador(Model.AgrupadorClasificador obj)
        {
            return objDs.Graba_AgrupadorClasificador(obj);
        }

        public int Modifica_Clasificador(Model.Clasificador obj)
        {
            return objDs.Modifica_Clasificador(obj);
        }

        public int Modifica_AgrupadorClasificador(Model.AgrupadorClasificador obj)
        {
            return objDs.Modifica_AgrupadorClasificador(obj);
        }

        public bool Elimina_Clasificador(int intIdClasificador)
        {
            return objDs.Elimina_Clasificador(intIdClasificador);
        }

        public bool Elimina_AgrupadorClasificador(int intIdAgrupador)
        {
            return objDs.Elimina_AgrupadorClasificador(intIdAgrupador);
        }

        #endregion

        #region Formulacion

        public DataSet Lista_HojaTrabajo_Dashboard(string strCodCompañia,
                                                    string strAñoProceso,
                                                    string strPeriodo,
                                                    string strVersion
                                                  )
        {
            return objDs.Lista_HojaTrabajo_Dashboard(strCodCompañia,
                                                      strAñoProceso,
                                                      strPeriodo,
                                                      strVersion
                                                  );
        }
        public Model.Formulacion Recupera_Formulacion(string strCodCompañia,
                                                string strAñoProceso,
                                                string strCodFormulacion
                                              )
        {
            return objDs.Recupera_Formulacion(strCodCompañia,
                                         strAñoProceso,
                                         strCodFormulacion
                                              );
        }

        public DataSet Ayuda_Formulacion(string strCodCompañia,
                                         string strAñoProceso,
                                         string strCodCentroGestor,
                                         string strCodTipoAdquisicion,
                                         Boolean blnEsPasajeAereo
                                       )
        {
            return objDs.Ayuda_Formulacion( strCodCompañia,
                                      strAñoProceso,
                                      strCodCentroGestor,
                                      strCodTipoAdquisicion,
                                      blnEsPasajeAereo
                                       );
        }

        public DataSet Ayuda_Formulacion_Logistica(string strCodCompañia,
                                                    string strAñoProceso,
                                                    string strCodCentroGestor,
                                                    string strJustificacionGasto,
                                                    string strCodTipoAdquisicion
                                       )
        {
            return objDs.Ayuda_Formulacion_Logistica( strCodCompañia,
                                                strAñoProceso,
                                                strCodCentroGestor,
                                                strJustificacionGasto,
                                                strCodTipoAdquisicion
                                       );
        }

        public DataSet Ayuda_Formulacion_Logistica(string strCodCompañia,
                                         string strAñoProceso,
                                         string strCodCentroGestor,
                                         string strCodTipoAdquisicion
                                       )
        {
            return objDs.Ayuda_Formulacion_Logistica( strCodCompañia,
                                          strAñoProceso,
                                          strCodCentroGestor,
                                          strCodTipoAdquisicion
                                       );
        }

        public DataSet Lista_Formulacion_Reasignacion(string strCodCompañia,
                                                string strAñoProceso,
                                                string strCodCentroGestor,
                                                int intTipoBusqueda
                                       )
        {
            return objDs.Lista_Formulacion_Reasignacion(strCodCompañia,
                                              strAñoProceso,
                                              strCodCentroGestor,
                                              intTipoBusqueda
                                       );
        }
        public DataSet Ayuda_Formulacion_General(string strCodCompañia,
                                                string strAñoProceso,
                                                string strCodCentroGestor,
                                                string strCodTipoAdquisicion,
                                                int intTipoBusqueda,
                                                Boolean blnEsPasajeAereo
                                       )
        {
            return objDs.Ayuda_Formulacion_General( strCodCompañia,
                                              strAñoProceso,
                                              strCodCentroGestor,
                                              strCodTipoAdquisicion,
                                              intTipoBusqueda,
                                              blnEsPasajeAereo
                                       );
        }

        public DataSet Elige_Formulacion_General(string strCodCompañia,
                                                string strAñoProceso,
                                                string strLineasElegidas
                                       )
        {
            return objDs.Elige_Formulacion_General( strCodCompañia,
                                              strAñoProceso,
                                              strLineasElegidas
                                       );
        }

        public DataSet Ayuda_Formulacion_Origen(string strCodCompañia,
                                                string strAñoProceso,
                                                string strCodCentroGestor,
                                                string strCodTipoAdquisicion
                                       )
        {
            return objDs.Ayuda_Formulacion_Origen(strCodCompañia,
                                                 strAñoProceso,
                                                 strCodCentroGestor,
                                                 strCodTipoAdquisicion
                                       );
        }

        public DataSet Ayuda_Formulacion_Destino(string strCodCompañia,
                                                string strAñoProceso,
                                                string strCodCentroGestor,
                                                string strCodClasificador,
                                                string strCodPosPre,
                                                string strCodTipoAdquisicion,
                                                string strCodFormulacion
                                       )
        {
            return objDs.Ayuda_Formulacion_Destino( strCodCompañia,
                                               strAñoProceso,
                                               strCodCentroGestor,
                                               strCodClasificador,
                                               strCodPosPre,
                                               strCodTipoAdquisicion,
                                               strCodFormulacion
                                       );
        }

        public DataSet Ayuda_Formulacion_Destino_Uno_Varios(string strCodCompañia,
                                        string strAñoProceso,
                                        string strCodCentroGestor,
                                        string strCodClasificador,
                                        string strCodPosPre,
                                        string strCodTipoAdquisicion,
                                        string strCodFormulacion,
                                        string strTipoFormulacion
                               )
        {
            return objDs.Ayuda_Formulacion_Destino_Uno_Varios(strCodCompañia,
                                               strAñoProceso,
                                               strCodCentroGestor,
                                               strCodClasificador,
                                               strCodPosPre,
                                               strCodTipoAdquisicion,
                                               strCodFormulacion,
                                               strTipoFormulacion
                                       );
        }


        public Boolean Graba_Formulacion_Genera_PIA(string strCodCompañia,
                                                 string strAñoProceso,
                                                 string strVersion
                                               )
        {
            return objDs.Graba_Formulacion_Genera_PIA( strCodCompañia,
                                                 strAñoProceso,
                                                 strVersion
                                               );
        }

        public string Graba_Formulacion(Model.Formulacion obj)
        {
            return objDs.Graba_Formulacion(obj);
        }

        public string Modifica_Formulacion(Model.Formulacion obj)
        {
            return objDs.Modifica_Formulacion(obj);
        }

        #endregion

        #region FormulacionAjuste_Cabecera
        public Model.Formulacion_Ajuste_Cabecera Recupera_Formulacion_Ajuste_Cabecera(string strNumAjuste)
        {
            return objDs.Recupera_Formulacion_Ajuste_Cabecera(strNumAjuste);
        }

        public Model.Formulacion_Ajuste_Cabecera Graba_Formulacion_Ajuste_Cabecera(Model.Formulacion_Ajuste_Cabecera obj)
        {
            return objDs.Graba_Formulacion_Ajuste_Cabecera( obj);
        }

        public Model.Formulacion_Ajuste_Cabecera Graba_Formulacion_Ajuste_Cabecera_Procedimiento(Model.Formulacion_Ajuste_Cabecera obj)
        {
            return objDs.Graba_Formulacion_Ajuste_Cabecera_Procedimiento(obj);
        }


        public int Modifica_Formulacion_Ajuste_Cabecera(Model.Formulacion_Ajuste_Cabecera obj)
        {
            return objDs.Modifica_Formulacion_Ajuste_Cabecera(obj);
        }

        public int Elimina_Formulacion_Ajuste_Cabecera(string strNumAjuste)
        {
            return objDs.Elimina_Formulacion_Ajuste_Cabecera(strNumAjuste);
        }

        public DataSet Lista_Formulacion_Ajuste_Cabecera(string strAñoProceso,
                                                    string strCodCentroGestor,
                                                    string strCodEmpleado
                                                )
        {
            return objDs.Lista_Formulacion_Ajuste_Cabecera( strAñoProceso,
                                                     strCodCentroGestor,
                                                     strCodEmpleado
                                                );
        }

        #endregion

        #region FormulacionAjuste_Detalle
        public Model.Formulacion_Ajuste_Detalle Recupera_Formulacion_Ajuste_Detalle(string strNumAjuste,
                                                                     string strCodTipoMovimiento
                                                                    )
        {
            return objDs.Recupera_Formulacion_Ajuste_Detalle(strNumAjuste,
                                                       strCodTipoMovimiento
                                                                    );
        }

        public int Graba_Formulacion_Ajuste_Detalle(Model.Formulacion_Ajuste_Detalle obj)
        {
            return objDs.Graba_Formulacion_Ajuste_Detalle(obj);
        }

        public int Modifica_Formulacion_Ajuste_Detalle(Model.Formulacion_Ajuste_Detalle obj)
        {
            return objDs.Modifica_Formulacion_Ajuste_Detalle(obj);
        }

        public int Elimina_Formulacion_Ajuste_Detalle(string strNumAjuste,
                                                        string strCodTipoMovimiento
                                                     )
        {
            return objDs.Elimina_Formulacion_Ajuste_Detalle(strNumAjuste,
                                                      strCodTipoMovimiento
                                                     );
        }

        public DataSet Lista_Formulacion_Ajuste_Detalle(string strAñoProceso,
                                                    string strNumAjuste
                                                )
        {
            return objDs.Lista_Formulacion_Ajuste_Detalle( strAñoProceso,
                                                     strNumAjuste
                                                );
        }

        public DataSet Lista_Formulacion_Ajuste_Detalle_Formato(string strAñoProceso,
                                                    string strNumAjuste
                                                )
        {
            return objDs.Lista_Formulacion_Ajuste_Detalle_Formato(strAñoProceso,
                                                    strNumAjuste
                                                );
        }

        public DataSet Lista_Formulacion_Ajuste_Detalle_Modificacion(string strAñoProceso,
                                                    string strNumAjuste,
                                                    string strTipoReasignacion
                                                )
        {
            return objDs.Lista_Formulacion_Ajuste_Detalle_Modificacion(strAñoProceso,
                                                    strNumAjuste,
                                                    strTipoReasignacion
                                                );
        }

        public bool Elimina_Formulacion_Ajuste_Detalle(  int intIdDetalle,
                                                            int intIdDetalle_C,
                                                            double dlbImporte,
                                                            double dblImporte_C
                                                         )
        {
            return objDs.Elimina_Formulacion_Ajuste_Detalle(intIdDetalle,
                                                                      intIdDetalle_C,
                                                                      dlbImporte,
                                                                      dblImporte_C
                                                );
        }

        public bool Modifica_Formulacion_Ajuste_Detalle(int intIdDetalle,
                                                            int intIdDetalle_C,
                                                            double dlbImporte,
                                                            double dblImporte_C
                                                         )
        {
            return objDs.Modifica_Formulacion_Ajuste_Detalle(intIdDetalle,
                                                                      intIdDetalle_C,
                                                                      dlbImporte,
                                                                      dblImporte_C
                                                );
        }

        public DataSet Lista_Formulacion_Ajuste_Detalle_Formato_Nuevo(string strAñoProceso,
                                                    string strNumAjuste
                                                )
        {
            return objDs.Lista_Formulacion_Ajuste_Detalle_Formato_Nuevo( strAñoProceso,
                                                     strNumAjuste
                                                );
        }

        public DataSet Formato_Ajuste_Estado(string strCodCentro_Gestor,
                                                    string strEstado,
                                                    string strCodEmpleado
                                                   )
        {
            return objDs.Formato_Ajuste_Estado(strCodCentro_Gestor,
                                         strEstado,
                                         strCodEmpleado
                                                   );
        }

        public Boolean Formato_Ajuste_DescarteFirma(string strNumAjuste,
                                                            string strCodMotivoDescarte,
                                                            DateTime dateFecDescarte,
                                                            string strMotivoDescarte
                                                          )
        {
            return objDs.Formato_Ajuste_DescarteFirma(strNumAjuste,
                                                 strCodMotivoDescarte,
                                                 dateFecDescarte,
                                                strMotivoDescarte
                                                          );
        }

        public Boolean Formato_Ajuste_Firma(string strCodCentro_Gestor,
                                                    string strPaso,
                                                    string strNumAjuste,
                                                    string strCodEmpleado
                                                   )
        {
            return objDs.Formato_Ajuste_Firma(strCodCentro_Gestor,
                                          strPaso,
                                          strNumAjuste,
                                         strCodEmpleado
                                                   );
        }

        #endregion

        #region Formulacion_Cabecera
        public DataTable Combo_AñoProceso(string strCodCompañia)
        {
            return objDs.Combo_AñoProceso(strCodCompañia);
        }
        public DataTable Combo_Periodo(string strAñoProceso)
        {
            return objDs.Combo_Periodo(strAñoProceso);
        }

        public Model.Formulacion_Cabecera Recupera_FormulacionCabecera(string strAñoProceso)
        {
            return objDs.Recupera_FormulacionCabecera(strAñoProceso);
        }

        public int Graba_FormulacionCabecera(Model.Formulacion_Cabecera obj)
        {
            return objDs.Graba_FormulacionCabecera(obj);
        }

        //Agregado
        public DataSet Lista_FormulacionCabecera(string strAñoProceso)
        {
            return objDs.Lista_FormulacionCabecera(strAñoProceso);
        }

        public bool elimina_mvto_Formulacion_Cabecera(int intiIdFormulacion_Cabecera)
        {
            return objDs.elimina_mvto_Formulacion_Cabecera(intiIdFormulacion_Cabecera);
        }

        public DataSet Graba_FormulacionCabecera_DataSet(Model.Formulacion_Cabecera obj)
        {
            return objDs.Graba_FormulacionCabecera_DataSet( obj);
        }

        public bool Modifica_mvto_Formulacion_Cabecera(Model.Formulacion_Cabecera obj)
        {
            return objDs.Modifica_mvto_Formulacion_Cabecera(obj);
        }

        #endregion

        #region Formulacion_Cabecera_CentroGestor
        public bool Graba_mvto_Formulacion_Cabecera_Cege(Model.Formulacion_Cabecera_Cege obj)
        {
            return objDs.Graba_mvto_Formulacion_Cabecera_Cege(obj);
        }

        public DataSet Lista_FormulacionCabecera_Cege(string strAñoProceso, string strCege, int digito)
        {
            return objDs.Lista_FormulacionCabecera_Cege(strAñoProceso, strCege, digito);
        }
        public Model.Formulacion_Cabecera_Cege Recupera_FormulacionCabecera_Cege(string strAñoProceso,
                                                                            string strVersion,
                                                                            string strPeriodo,
                                                                            string strCodCentroGestor
                                                                           )
        {
            return objDs.Recupera_FormulacionCabecera_Cege( strAñoProceso,
                                                      strVersion,
                                                      strPeriodo,
                                                      strCodCentroGestor
                                                                           );
        }
        public DataSet Lista_Formulacion_Aprobacion_Cege(string strAñoProceso, string strCeGe, string strVersion, string strCodEmpleado)
        {
            return objDs.Lista_Formulacion_Aprobacion_Cege( strAñoProceso,  strCeGe,  strVersion,  strCodEmpleado);
        }

        public DataSet Lista_Version(string strAñoProceso)
        {
            return objDs.Lista_Version( strAñoProceso);
        }

        #endregion

        #region Formulacion_Detalle
        public int Graba_FormulacionDetalle(Model.Formulacion_Detalle obj)
        {
            return objDs.Graba_FormulacionDetalle( obj);
        }

        #endregion

        #region Formulacion_Detalle_Ingreso
        public Boolean Elimina_FormulacionDetalle_Ingreso(int intIdFormulacion_Detalle_Proyecto)
        {
            return objDs.Elimina_FormulacionDetalle_Ingreso( intIdFormulacion_Detalle_Proyecto);
        }


        public int Graba_FormulacionDetalle_Ingreso(Model.Formulacion_Detalle_Ingreso obj)
        {
            return objDs.Graba_FormulacionDetalle_Ingreso( obj);
        }

        public int Modifica_FormulacionDetalle_Ingreso(Model.Formulacion_Detalle_Ingreso obj)
        {
            return objDs.Modifica_FormulacionDetalle_Ingreso( obj);
        }


        public DataSet Lista_FormulacionDetalle_Ingreso(string strCodCompañia,
                                                         string strCodProyecto,
                                                         string strCodCentroGestor,
                                                         string strCodTipoFormulacion
                                        )
        {
            return objDs.Lista_FormulacionDetalle_Ingreso( strCodCompañia,
                                                     strCodProyecto,
                                                     strCodCentroGestor,
                                                     strCodTipoFormulacion
                                        );
        }

        #endregion

        #region Formulacion_Detalle_Personal
        public Boolean Elimina_FormulacionDetalle_Personal(int intIdFormulacion_Detalle_Proyecto)
        {
            return objDs.Elimina_FormulacionDetalle_Personal(intIdFormulacion_Detalle_Proyecto);
        }


        public int Graba_FormulacionDetalle_Personal(Model.Formulacion_Detalle_Personal obj)
        {
            return objDs.Graba_FormulacionDetalle_Personal(obj);
        }

        public int Modifica_FormulacionDetalle_Personal(Model.Formulacion_Detalle_Personal obj)
        {
            return objDs.Modifica_FormulacionDetalle_Personal( obj);
        }


        public DataSet Lista_FormulacionDetalle_Personal(string strCodCompañia,
                                                         string strCodCentroGestor,
                                                         string strCodTipoFormulacion
                                        )
        {
            return objDs.Lista_FormulacionDetalle_Personal( strCodCompañia,
                                                     strCodCentroGestor,
                                                      strCodTipoFormulacion
                                        );
        }

        #endregion

        #region Formulacion_Detalle_Proyecto
        public Boolean Elimina_FormulacionDetalle_Proyecto(int intIdFormulacion_Detalle_Proyecto)
        {
            return objDs.Elimina_FormulacionDetalle_Proyecto(intIdFormulacion_Detalle_Proyecto);
        }


        public int Graba_FormulacionDetalle_Proyecto(Model.Formulacion_Detalle_Proyecto obj)
        {
            return objDs.Graba_FormulacionDetalle_Proyecto( obj);
        }

        public int Modifica_FormulacionDetalle_Proyecto(Model.Formulacion_Detalle_Proyecto obj)
        {
            return objDs.Modifica_FormulacionDetalle_Proyecto(obj);
        }


        public DataSet Lista_FormulacionDetalle_Proyecto(string strCodCompañia,
                                                         string strCodProyecto,
                                                         string strCodCentroGestor,
                                                         string strCodTipoFormulacion
                                        )
        {
            return objDs.Lista_FormulacionDetalle_Proyecto(strCodCompañia,
                                                     strCodProyecto,
                                                     strCodCentroGestor,
                                                     strCodTipoFormulacion
                                        );
        }


        public DataSet Lista_FormulacionDetalle_Proyecto_Otros(string strCodCompañia,
                                                         string strCodCentroGestor,
                                                         string strCodTipoFormulacion
                                        )
        {
            return objDs.Lista_FormulacionDetalle_Proyecto_Otros( strCodCompañia,
                                                         strCodCentroGestor,
                                                         strCodTipoFormulacion
                                        );
        }

        #endregion

        #region Formulacion_HojaTrabajo

        public List<Model.HojaTrabajo_Formato_Cabecera> lista_HojaTrabajo_Formato_Cabecera(string strCodEmpresa,
                                                                                    string strCodFormato
                                                                                  )
        {
            return objDs.lista_HojaTrabajo_Formato_Cabecera(strCodEmpresa,
                                                            strCodFormato
                                                          );
        }

        public Model.HojaTrabajo_Formato_Cabecera recupera_HojaTrabajo_Formato_Cabecera(string strCodEmpresa,
                                                                                    string strCodFormato
                                                                                  )
        {
            return objDs.recupera_HojaTrabajo_Formato_Cabecera(strCodEmpresa,
                                                            strCodFormato
                                                          );
        }

        public bool  modifica_HojaTrabajo_Formato_Cabecera(Model.HojaTrabajo_Formato_Cabecera obj )
        {
            return objDs.modifica_HojaTrabajo_Formato_Cabecera( obj );
        }

        public List<Model.HojaTrabajo_Formato_Detalle> lista_HojaTrabajo_Formato_Detalle(string strCodEmpresa,
                                                                                    string strCodFormato
                                                                                  )
        {
            return objDs.lista_HojaTrabajo_Formato_Detalle(strCodEmpresa,
                                                            strCodFormato
                                                          );
        }

        public DataSet lista_HojaTrabajo_Formato_Detalle_Personal( string strCodEmpresa,
                                                          string strCodFormato
                                                          )
        {
            return objDs.lista_HojaTrabajo_Formato_Detalle_Personal(strCodEmpresa,
                                                            strCodFormato
                                                          );
        }

        public int graba_HojaTrabajo_Formato_Detalle_Personal(Model.HojaTrabajo_Formato_Detalle obj)
        {
            return objDs.graba_HojaTrabajo_Formato_Detalle_Personal( obj );
        }

        public int modifica_HojaTrabajo_Formato_Detalle_Personal(Model.HojaTrabajo_Formato_Detalle obj)
        {
            return objDs.modifica_HojaTrabajo_Formato_Detalle_Personal(obj);
        }

        public bool elimina_HojaTrabajo_Formato_Detalle_Personal(int intIdDetalle)
        {
            return objDs.elimina_HojaTrabajo_Formato_Detalle_Personal(intIdDetalle);
        }
        public DataSet Lista_CierreModificacionCentroGestor(string strCodCompañia,
                            string strAñoProceso,
                            string strVersion
                          )
        {
            return objDs.Lista_CierreModificacionCentroGestor(strCodCompañia,
                                    strAñoProceso,
                                    strVersion
                                  );
        }

        public Boolean Graba_CierreModificacionCentroGestor(string strCodCompañia,
                                                string strAñoProceso,
                                                string strVersion,
                                                string strCodCege,
                                                string strCodUsuario
                                              )
        {
            return objDs.Graba_CierreModificacionCentroGestor(strCodCompañia,
                                              strAñoProceso,
                                              strVersion,
                                              strCodCege,
                                              strCodUsuario
                                              );
        }

        public Boolean Elimina_CierreModificacionCentroGestor(string strCodCompañia,
                                                string strAñoProceso,
                                                string strVersion,
                                                string strCodCege
                                              )
        {
            return objDs.Elimina_CierreModificacionCentroGestor(strCodCompañia,
                                               strAñoProceso,
                                               strVersion,
                                                 strCodCege
                                              );
        }

        public DataSet Lista_CierreCentroGestor(string strCodCompañia,
                                    string strAñoProceso,
                                    string strVersion,
                                    string strPeriodo
                                  )
        {
            return objDs.Lista_CierreCentroGestor( strCodCompañia,
                                    strAñoProceso,
                                    strVersion,
                                    strPeriodo
                                  );
        }

        public DataSet Lista_CierreCentroCosto(string strCodCompañia,
                                    string strAñoProceso,
                                    string strVersion,
                                    string strPeriodo
                                  )
        {
            return objDs.Lista_CierreCentroCosto(strCodCompañia,
                                    strAñoProceso,
                                    strVersion,
                                    strPeriodo
                                  );
        }

        public DataSet Lista_AperturaCentroGestor(string strCodCompañia,
                                    string strAñoProceso,
                                    string strVersion,
                                    string strPeriodo
                                  )
        {
            return objDs.Lista_AperturaCentroGestor(strCodCompañia,
                                    strAñoProceso,
                                    strVersion,
                                    strPeriodo
                                  );
        }

        public DataSet Lista_AperturaCentroCosto(string strCodCompañia,
                                    string strAñoProceso,
                                    string strVersion,
                                    string strPeriodo
                                  )
        {
            return objDs.Lista_AperturaCentroCosto(strCodCompañia,
                                    strAñoProceso,
                                    strVersion,
                                    strPeriodo
                                  );
        }

        public DataSet Lista_AperturaEjecucionPresupuestal(string strCodCompañia,
                            string strAñoProceso
                          )
        {
            return objDs.Lista_AperturaEjecucionPresupuestal(strCodCompañia,
                                    strAñoProceso
                                  );
        }

        public DataSet Lista_AperturaEjecucionIndicador(string strCodCompañia,
                            string strAñoProceso
                          )
        {
            return objDs.Lista_AperturaEjecucionIndicador(strCodCompañia,
                                    strAñoProceso
                                  );
        }

        public Boolean Graba_CierreCentroGestor(string strCodCompañia,
                                                string strAñoProceso,
                                                string strVersion,
                                                string strPeriodo,
                                                string strCodCege,
                                                string strCodUsuario
                                              )
        {
            return objDs.Graba_CierreCentroGestor( strCodCompañia,
                                              strAñoProceso,
                                              strVersion,
                                              strPeriodo,
                                              strCodCege,
                                              strCodUsuario
                                              );
        }

        public Boolean Graba_CierreCentroCosto(string strCodCompañia,
                                        string strAñoProceso,
                                        string strVersion,
                                        string strPeriodo,
                                        string strCodCeco,
                                        string strCodUsuario
                                      )
        {
            return objDs.Graba_CierreCentroCosto(strCodCompañia,
                                              strAñoProceso,
                                              strVersion,
                                              strPeriodo,
                                              strCodCeco,
                                              strCodUsuario
                                              );
        }


        public Boolean Graba_AperturaCentroGestor(string strCodCompañia,
                                        string strAñoProceso,
                                        string strVersion,
                                        string strPeriodo,
                                        string strCodCege,
                                        string strCodUsuario
                                      )
        {
            return objDs.Graba_AperturaCentroGestor(strCodCompañia,
                                              strAñoProceso,
                                              strVersion,
                                              strPeriodo,
                                              strCodCege,
                                              strCodUsuario
                                              );
        }

        public Boolean Graba_AperturaCentroCosto(string strCodCompañia,
                                        string strAñoProceso,
                                        string strVersion,
                                        string strPeriodo,
                                        string strCodCeCo,
                                        string strCodUsuario
                                      )
        {
            return objDs.Graba_AperturaCentroCosto(strCodCompañia,
                                              strAñoProceso,
                                              strVersion,
                                              strPeriodo,
                                              strCodCeCo,
                                              strCodUsuario
                                              );
        }

        public Boolean Graba_AperturaEjecucionPresupuestal(string strCodCompañia,
                                        string strAñoProceso,
                                        string strMes,
                                        string strCodEmpleado
                                      )
        {
            return objDs.Graba_AperturaEjecucionPresupuestal(strCodCompañia,
                                              strAñoProceso,
                                              strMes,
                                              strCodEmpleado
                                              );
        }

        public Boolean Graba_AperturaEjecucionIndicador(string strCodCompañia,
                                        string strAñoProceso,
                                        string strMes,
                                        string strCodEmpleado
                                      )
        {
            return objDs.Graba_AperturaEjecucionIndicador(strCodCompañia,
                                              strAñoProceso,
                                              strMes,
                                              strCodEmpleado
                                              );
        }

        public Boolean Elimina_CierreCentroGestor(string strCodCompañia,
                                                string strAñoProceso,
                                                string strVersion,
                                                string strPeriodo,
                                                string strCodCege
                                              )
        {
            return objDs.Elimina_CierreCentroGestor(strCodCompañia,
                                               strAñoProceso,
                                               strVersion,
                                               strPeriodo,
                                                 strCodCege
                                              );
        }

        public Boolean Elimina_CierreCentroCosto(string strCodCompañia,
                                        string strAñoProceso,
                                        string strVersion,
                                        string strPeriodo,
                                        string strCodCeco
                                      )
        {
            return objDs.Elimina_CierreCentroCosto(strCodCompañia,
                                               strAñoProceso,
                                               strVersion,
                                               strPeriodo,
                                                 strCodCeco
                                              );
        }


        public Boolean Elimina_AperturaCentroGestor(string strCodCompañia,
                                        string strAñoProceso,
                                        string strVersion,
                                        string strPeriodo,
                                        string strCodCege
                                      )
        {
            return objDs.Elimina_AperturaCentroGestor(strCodCompañia,
                                               strAñoProceso,
                                               strVersion,
                                               strPeriodo,
                                                 strCodCege
                                              );
        }

        public Boolean Elimina_AperturaCentroCosto(string strCodCompañia,
                                        string strAñoProceso,
                                        string strVersion,
                                        string strPeriodo,
                                        string strCodCeCo
                                      )
        {
            return objDs.Elimina_AperturaCentroCosto(strCodCompañia,
                                               strAñoProceso,
                                               strVersion,
                                               strPeriodo,
                                                 strCodCeCo
                                              );
        }

        public Boolean Elimina_AperturaEjecucionPresupuestal(string strCodCompañia,
                                string strAñoProceso,
                                string strMes
                              )
        {
            return objDs.Elimina_AperturaEjecucionPresupuestal(strCodCompañia,
                                               strAñoProceso,
                                               strMes
                                              );
        }

        public Boolean Elimina_AperturaEjecucionIndicador(string strCodCompañia,
                                string strAñoProceso,
                                string strMes
                              )
        {
            return objDs.Elimina_AperturaEjecucionIndicador(strCodCompañia,
                                               strAñoProceso,
                                               strMes
                                              );
        }

        public Boolean Cierra_CierreVersion_GeneraPIA(string strCodCompañia,
                                            string strAñoProceso,
                                            string strPeriodo,
                                            string strVersion
                                         )
        {
            return objDs.Cierra_CierreVersion_GeneraPIA( strCodCompañia,
                                             strAñoProceso,
                                             strPeriodo,
                                             strVersion
                                         );
        }

        public int Cierra_CierreVersion_CenroGestor(string strCodCompañia,
                                                            string strAñoProceso,
                                                            string strVersion,
                                                            string strPeriodo,
                                                            string strCodCentroGestor
                                                         )
        {
            return objDs.Cierra_CierreVersion_CentroGestor(strCodCompañia,
                                                    strAñoProceso,
                                                    strVersion,
                                                    strPeriodo,
                                                    strCodCentroGestor
                                                         );
        }

        public int Cierra_CierreVersion_CentroCosto(string strCodCompañia,
                                                    string strAñoProceso,
                                                    string strVersion,
                                                    string strPeriodo,
                                                    string strCodCentroGestor,
                                                    string strCodCentroCosto
                                                 )
        {
            return objDs.Cierra_CierreVersion_CentroCosto(strCodCompañia,
                                                    strAñoProceso,
                                                    strVersion,
                                                    strPeriodo,
                                                    strCodCentroGestor,
                                                    strCodCentroCosto
                                                         );
        }

        public List<Model.Mensaje> Valida_Configuracion_CentroCosto(string strCodCompañia,
                                                    string strAñoProceso,
                                                    string strVersion,
                                                    string strPeriodo,
                                                    string strCodCentroGestor,
                                                    string strCodCentroCosto,
                                                    string strCodTipoFormulacion
                                                 )
        {
            return objDs.Valida_Configuracion_CentroCosto(strCodCompañia,
                                                    strAñoProceso,
                                                    strVersion,
                                                    strPeriodo,
                                                    strCodCentroGestor,
                                                    strCodCentroCosto,
                                                    strCodTipoFormulacion
                                                         );
        }

        public int Cierra_CierrePeriodo_EjecucionPresupuestal(string strCodCompañia,
                                                    string strAñoProceso,
                                                    string strMes
                                                 )
        {
            return objDs.Cierra_CierrePeriodo_EjecucionPresupuestal(strCodCompañia,
                                                    strAñoProceso,
                                                    strMes
                                                         );
        }

        public DataTable Combo_PeriodoPresupuesto(string strCodCompañia, string strPeriodo)
        {
            return objDs.Combo_PeriodoPresupuesto(strCodCompañia, strPeriodo);
        }

        public DataTable Combo_PeriodoAjuste(string strCodCompañia)
        {
            return objDs.Combo_PeriodoAjuste(strCodCompañia);
        }

        public string Recupera_PeriodoAjuste(string strCodCompañia)
        {
            return objDs.Recupera_PeriodoAjuste(strCodCompañia);
        }

        public DataTable Combo_PeriodoEjecucionPresupuestal(string strCodCompañia)
        {
            return objDs.Combo_PeriodoEjecucionPresupuestal(strCodCompañia);
        }

        public DataTable Combo_PeriodoEjecucionIndicador(string strCodCompañia)
        {
            return objDs.Combo_PeriodoEjecucionIndicador(strCodCompañia);
        }

        public string Recupera_PeriodoEjecucionPresupuestal_Ultimo(string strCodCompañia)
        {
            return objDs.Recupera_PeriodoEjecucionPresupuestal_Ultimo(strCodCompañia);
        }

        public int Recupera_IDEjecucionPresupuestal_Ultimo(string strCodCompañia)
        {
            return objDs.Recupera_IDEjecucionPresupuestal_Ultimo(strCodCompañia);
        }

        public bool Elimina_EjecucionPresupuestal_Comercial(    int intIdCabecera,
                                                                string strTipoFormato
                                                           )
        {
            return objDs.Elimina_EjecucionPresupuestal_Comercial(intIdCabecera, strTipoFormato);
        }

        public bool Graba_EjecucionPresupuestal_Comercial_F01(Model.FormatoEjecucion_F01 obj)
        {
            return objDs.Graba_EjecucionPresupuestal_Comercial_F01(obj);
        }
        public bool Graba_EjecucionPresupuestal_Comercial_F02(Model.FormatoEjecucion_F02 obj)
        {
            return objDs.Graba_EjecucionPresupuestal_Comercial_F02(obj);
        }
        public bool Graba_EjecucionPresupuestal_Comercial_F03(Model.FormatoEjecucion_F03 obj)
        {
            return objDs.Graba_EjecucionPresupuestal_Comercial_F03(obj);
        }

        public bool Graba_EjecucionPresupuestal_Gasto_F04(Model.FormatoEjecucion_F04 obj)
        {
            return objDs.Graba_EjecucionPresupuestal_Gasto_F04(obj);
        }

        public bool Graba_EjecucionPresupuestal_Gasto_F05(Model.FormatoEjecucion_F05 obj)
        {
            return objDs.Graba_EjecucionPresupuestal_Gasto_F05(obj);
        }

        public bool Graba_EjecucionPresupuestal_Gasto_F06(Model.FormatoEjecucion_F06 obj)
        {
            return objDs.Graba_EjecucionPresupuestal_Gasto_F06(obj);
        }

        public bool Graba_EjecucionPresupuestal_Gasto_F07(Model.FormatoEjecucion_F07 obj)
        {
            return objDs.Graba_EjecucionPresupuestal_Gasto_F07(obj);
        }

        public bool Graba_EjecucionPresupuestal_Gasto_F08(Model.FormatoEjecucion_F08 obj)
        {
            return objDs.Graba_EjecucionPresupuestal_Gasto_F08(obj);
        }

        public bool Graba_EjecucionPresupuestal_Gasto_F09(Model.FormatoEjecucion_F09 obj)
        {
            return objDs.Graba_EjecucionPresupuestal_Gasto_F09(obj);
        }

        public bool Graba_EjecucionPresupuestal_Gasto_F10(Model.FormatoEjecucion_F10 obj)
        {
            return objDs.Graba_EjecucionPresupuestal_Gasto_F10(obj);
        }

        public DataTable Combo_PIA_PeriodoPresupuesto(string strCodCompañia)
        {
            return objDs.Combo_PIA_PeriodoPresupuesto(strCodCompañia);
        }

        public DataTable Combo_PeriodoPia(string strCodCompañia)
        {
            return objDs.Combo_PeriodoPia(strCodCompañia);
        }

        public DataTable Combo_VersionPia(string strCodCompañia, string strAñoProceso)
        {
            return objDs.Combo_VersionPia(strCodCompañia, strAñoProceso);
        }


        public DataTable Combo_PeriodoPresupuesto_Version(string strCodCompañia, string strPeriodo, string strAñoProceso)
        {
            return objDs.Combo_PeriodoPresupuesto_Version(strCodCompañia, strPeriodo, strAñoProceso);
        }

        public DataTable Combo_PeriodoEjecucionPresupuestal_Mes(string strCodCompañia, string strAñoProceso)
        {
            return objDs.Combo_PeriodoEjecucionPresupuestal_Mes(strCodCompañia, strAñoProceso);
        }

        public DataTable Combo_PeriodoEjecucionPresupuestal_Validacion_Mes(string strCodCompañia, string strAñoProceso)
        {
            return objDs.Combo_PeriodoEjecucionPresupuestal_Validacion_Mes(strCodCompañia, strAñoProceso);
        }

        public int Recupera_PeriodoPresupuesto_IdCabecera(string strCodCompañia,
                                                          string strPeriodo,
                                                          string strAñoProceso,
                                                          string strVersion
                                                        )
        {
            return objDs.Recupera_PeriodoPresupuesto_IdCabecera( strCodCompañia,
                                                           strPeriodo,
                                                           strAñoProceso,
                                                           strVersion
                                                        );
        }

        public int Recupera_PeriodoEjecucionPresupuestal_IdCabecera(string strCodCompañia,
                                                          string strAñoProceso,
                                                          string strMes
                                                        )
        {
            return objDs.Recupera_PeriodoEjecucionPresupuestal_IdCabecera(strCodCompañia,
                                                           strAñoProceso,
                                                           strMes
                                                        );
        }

        

        public Boolean Recupera_VerificaCierrePeriodoModificacion(string strCodEmpresa,
                                                                          string strAñoProceso
                                                                 )
        {
            return objDs.Recupera_VerificaCierrePeriodoModificacion(strCodEmpresa,
                                                              strAñoProceso
                                                                 );
        }

        public Model.PeriodoCierreModificacion Recupera_CierrePeriodoModificacion(string strCodEmpresa)
        {
            return objDs.Recupera_CierrePeriodoModificacion(strCodEmpresa);
        }
        public DataSet Ayuda_Proyecto_HojaTrabajo(string strCodEmpresa,
                                      string strCodCentroGestor
            )
        {
            return objDs.Ayuda_Proyecto_HojaTrabajo(strCodEmpresa,
                                      strCodCentroGestor
                                            );
        }
        public DataSet Ayuda_Proyecto_Componente_HojaTrabajo(string strCodEmpresa,
                                      string strCodCentroGestor
            )
        {
            return objDs.Ayuda_Proyecto_Componente_HojaTrabajo( strCodEmpresa,
                                      strCodCentroGestor
                                            );
        }
        public DataSet Ayuda_Formulacion_HojaTrabajo(string strCodEmpresa, string strTipoProyecto)
        {
            return objDs.Ayuda_Formulacion_HojaTrabajo(strCodEmpresa, strTipoProyecto);
        }

        public DataSet Lista_Formulacion_HojaTrabajo_Servicio(string strCodCompañia,
                                                string strAñoProceso,
                                                string strVersion,
                                                string strPeriodo,
                                                string strCodProyecto,
                                                string strCodCentroGestor,
                                                string strCodTipoFormulacion
                                            )
        {
            return objDs.Lista_Formulacion_HojaTrabajo_Servicio( strCodCompañia,
                                                 strAñoProceso,
                                                 strVersion,
                                                 strPeriodo,
                                                 strCodProyecto,
                                                 strCodCentroGestor,
                                                 strCodTipoFormulacion
                                            );
        }

        public DataSet Lista_Formulacion_HojaTrabajo(string strCodCompañia,
                                                        string strAñoProceso,
                                                        string strVersion,
                                                        string strPeriodo,
                                                        string strCodProyecto,
                                                        string strCodCentroGestor,
                                                        string strCodTipoFormulacion
                                                    )
        {
            return objDs.Lista_Formulacion_HojaTrabajo( strCodCompañia,
                                                  strAñoProceso,
                                                   strVersion,
                                                   strPeriodo,
                                                   strCodProyecto,
                                                   strCodCentroGestor,
                                                   strCodTipoFormulacion
                                                    );
        }

        public DataSet Lista_Formulacion_Inversion_HojaTrabajo(string strCodCompañia,
                                                        string strAñoProceso,
                                                        string strVersion,
                                                        string strPeriodo,
                                                        string strCodProyecto,
                                                        string strCodCentroGestor,
                                                        string strCodCentroCosto,
                                                        string strCodTipoFormulacion,
                                                        string strCodSubTipoFormulacion
                                                    )
        {
            return objDs.Lista_Formulacion_Inversion_HojaTrabajo(strCodCompañia,
                                                  strAñoProceso,
                                                   strVersion,
                                                   strPeriodo,
                                                   strCodProyecto,
                                                   strCodCentroGestor,
                                                   strCodCentroCosto,
                                                   strCodTipoFormulacion,
                                                   strCodSubTipoFormulacion
                                                    );
        }

        public DataSet Lista_HojaTrabajo_Formulacion(string strCodCompañia,
                                                string strAñoProceso,
                                                string strVersion,
                                                string strPeriodo,
                                                string strCodProyecto,
                                                string strCodCentroGestor,
                                                string strCodCentroCosto,
                                                string strCodTipoFormulacion,
                                                string strCodSubTipoFormulacion,
                                                bool blnManejaVariosCentroCostos
                                            )
        {
            return objDs.Lista_HojaTrabajo_Formulacion(strCodCompañia,
                                                  strAñoProceso,
                                                   strVersion,
                                                   strPeriodo,
                                                   strCodProyecto,
                                                   strCodCentroGestor,
                                                   strCodCentroCosto,
                                                   strCodTipoFormulacion,
                                                   strCodSubTipoFormulacion,
                                                   blnManejaVariosCentroCostos
                                                    );
        }

        public DataSet Lista_HojaTrabajo_Configuracion(string strCodCompañia,
                                string strCodTipoFormulacion,
                                string strCodSubTipoFormulacion,
                                string strCodTipoConfiguracion
                            )
        {
            return objDs.Lista_HojaTrabajo_Configuracion(strCodCompañia,
                                strCodTipoFormulacion,
                                strCodSubTipoFormulacion,
                                strCodTipoConfiguracion
                            );
        }

        public DataSet Lista_HojaTrabajo_EjecucionPresupuestal(string strCodCompañia,
                                                string strAñoProceso,
                                                string strMes
                                            )
        {
            return objDs.Lista_HojaTrabajo_EjecucionPresupuestal(strCodCompañia,
                                                  strAñoProceso,
                                                   strMes
                                                    );
        }

        
        public DataSet Lista_FormatoFormulacion_Proyecto(string strCodCompañia,
                                string strAñoProceso,
                                string strCodCentroGestor,
                                string strCodCentroCosto
                            )
        {
            return objDs.Lista_FormatoFormulacion_Proyecto(strCodCompañia,
                                strAñoProceso,
                                strCodCentroGestor,
                                strCodCentroCosto
                            );
        }

        public int Graba_FormatoFormulacion_Proyecto(Model.Formato_Proyecto FP)
        {
            return objDs.Graba_FormatoFormulacion_Proyecto(FP);
        }

        public int Modifica_FormatoFormulacion_Proyecto(Model.Formato_Proyecto FP)
        {
            return objDs.Modifica_FormatoFormulacion_Proyecto(FP);
        }

        public bool Elimina_FormatoFormulacion_Proyecto(int intIdTraslado)
        {
            return objDs.Elimina_FormatoFormulacion_Proyecto(intIdTraslado);
        }


        public DataSet Lista_ReFormulacion_HojaTrabajo(string strCodCompañia,
                                                        string strAñoProceso,
                                                        string strVersion,
                                                        string strPeriodo,
                                                        string strCodProyecto,
                                                        string strCodCentroGestor,
                                                        string strCodTipoFormulacion
                                                    )
        {
            return objDs.Lista_ReFormulacion_HojaTrabajo( strCodCompañia,
                                                    strAñoProceso,
                                                     strVersion,
                                                     strPeriodo,
                                                     strCodProyecto,
                                                     strCodCentroGestor,
                                                      strCodTipoFormulacion
                                                    );
        }

        public Model.Formulacion_HojaTrabajo_Cabecera Recupera_FormulacionHojaTrabajo_Cabecera(string strAñoProceso)
        {
            return objDs.Recupera_FormulacionHojaTrabajo_Cabecera( strAñoProceso);
        }

        public DataTable Combo_AñoProceso_HojaTrabajo(string strCodCompañia)
        {
            return objDs.Combo_AñoProceso_HojaTrabajo(strCodCompañia);
        }

        public DataTable Combo_Periodo_HojaTrabajo(string strAñoProceso)
        {
            return objDs.Combo_Periodo_HojaTrabajo(strAñoProceso);
        }

        public DataTable Combo_AñoProceso_GeneraSaldo(string strCodCompañia)
        {
            return objDs.Combo_AñoProceso_GeneraSaldo(strCodCompañia);
        }

        public DataTable Combo_Version_GeneraSaldo(string strCodCompañia, string strAñoProceso)
        {
            return objDs.Combo_Version_GeneraSaldo( strCodCompañia, strAñoProceso);
        }
        public DataTable Combo_Periodo_GeneraSaldo(string strCodCompañia, string strAñoProceso)
        {
            return objDs.Combo_Periodo_GeneraSaldo(strCodCompañia, strAñoProceso);
        }

        public string[] GrabaHojaTrabajo_Detalle(Model.Formulacion_HojaTrabajo_Detalle obj)
        {
            return objDs.GrabaHojaTrabajo_Detalle(obj);
        }

        public int GrabaHojaTrabajo_Configuracion(Model.Formulacion_HojaTrabajo_Configuracion obj)
        {
            return objDs.GrabaHojaTrabajo_Configuracion(obj);
        }

        public int ModificaHojaTrabajo_Configuracion(Model.Formulacion_HojaTrabajo_Configuracion obj)
        {
            return objDs.ModificaHojaTrabajo_Configuracion(obj);
        }

        public bool EliminaHojaTrabajo_Configuracion(int intIdItem)
        {
            return objDs.EliminaHojaTrabajo_Configuracion(intIdItem);
        }
        public int GrabaEjecucionPresupuestal_Detalle(Model.EjecucionPresupuestal_Detalle obj)
        {
            return objDs.GrabaEjecucionPresupuestal_Detalle(obj);
        }

        public int ModificaEjecucionPresupuestal_Detalle(Model.EjecucionPresupuestal_Detalle obj)
        {
            return objDs.ModificaEjecucionPresupuestal_Detalle(obj);
        }

        public bool EliminaEjecucionPresupuestal_Detalle(int intIdDetalle)
        {
            return objDs.EliminaEjecucionPresupuestal_Detalle(intIdDetalle);
        }

        public bool ModificaHojaTrabajo_Ajuste(Model.Formulacion_HojaTrabajo_Ajuste obj)
        {
            return objDs.ModificaHojaTrabajo_Ajuste(obj);
        }
        public string[] ModificaHojaTrabajo_Detalle(Model.Formulacion_HojaTrabajo_Detalle obj)
        {
            return objDs.ModificaHojaTrabajo_Detalle(obj);
        }

        public int GrabaHojaTrabajo_Detalle_Item(Model.Formulacion_HojaTrabajo_Detalle_Item obj)
        {
            return objDs.GrabaHojaTrabajo_Detalle_Item(obj);
        }
        public int ModificaHojaTrabajo_Detalle_Item(Model.Formulacion_HojaTrabajo_Detalle_Item obj)
        {
            return objDs.ModificaHojaTrabajo_Detalle_Item(obj);
        }
        public Boolean EliminaHojaTrabajo_Detalle(int intIdDetalle)
        {
            return objDs.EliminaHojaTrabajo_Detalle(intIdDetalle);
        }

        public Boolean GeneraSaldoPresupuestal(string strCodCompañia,
                                                string strAñoProceso,
                                                string strPeriodo,
                                                string strMesProceso,
                                                string strAñoActual
                                              )
        {
            return objDs.GeneraSaldoPresupuestal( strCodCompañia,
                                            strAñoProceso,
                                             strPeriodo,
                                             strMesProceso,
                                             strAñoActual
                                              );
        }

        public Boolean GeneraCierreModificacionPresupuestal(string strCodCompañia,
                                                string strAñoModificacion,
                                                string strAñoFormulacion
                                              )
        {
            return objDs.GeneraCierreModificacionPresupuestal( strCodCompañia,
                                                strAñoModificacion,
                                                strAñoFormulacion
                                              );
        }

        public DataSet Lista_OrdenesVigentes(string strCodCompañia,
                                                        string strAñoProceso,
                                                        string strCodCentroCosto,
                                                        string strCodLineaFormulacion
                                                    )
        {
            return objDs.Lista_OrdenesVigentes( strCodCompañia,
                                         strAñoProceso,
                                         strCodCentroCosto,
                                         strCodLineaFormulacion
                                                    );
        }

        public DataSet Reporte_HojaTrabajo_Formulacion_Dashboard(string strCodCompañia,
                          string strAñoProceso,
                          string strVersion,
                          string strPeriodo,
                          bool blnTodasLasVersiones,
                          string strTipoFormulacion
                        )
        {
            return objDs.Reporte_HojaTrabajo_Formulacion_Dashboard(strCodCompañia,
                          strAñoProceso,
                          strVersion,
                          strPeriodo,
                          blnTodasLasVersiones,
                          strTipoFormulacion
                        );
        }

        public DataSet Reporte_Detalle_ModificacionFormulacion(string strCodCompañia,
                          string strAñoProceso,
                          string strVersion,
                          string strPeriodo,
                          string strCodGerencia,
                          string strCodTipoFormulacion,
                          string strCodSubTipoFormulacion
                        )
        {
            return objDs.Reporte_Detalle_ModificacionFormulacion(strCodCompañia,
                          strAñoProceso,
                          strVersion,
                          strPeriodo,
                          strCodGerencia,
                          strCodTipoFormulacion,
                          strCodSubTipoFormulacion
                        );
        }

        public List<Model.Dashboard_Formulacion_PIA> Reporte_Detalle_ModificacionFormulacion_dashboard(string strCodCompañia,
                          string strAñoProceso,
                          string strVersion,
                          string strPeriodo,
                          string strCodGerencia,
                          string strCodTipoFormulacion,
                          string strCodSubTipoFormulacion
                        )
        {
            return objDs.Reporte_Detalle_ModificacionFormulacion_dashboard(strCodCompañia,
                          strAñoProceso,
                          strVersion,
                          strPeriodo,
                          strCodGerencia,
                          strCodTipoFormulacion,
                          strCodSubTipoFormulacion
                        );
        }

        public DataSet Reporte_Detalle_PlanEstrategico_Formulacion(string strCodCompañia,
                          string strAñoProceso,
                          string strVersion,
                          string strPeriodo,
                          string strCodGerencia,
                          string strCodTipoFormulacion,
                          string strCodSubTipoFormulacion
                        )
        {
            return objDs.Reporte_Detalle_PlanEstrategico_Formulacion(strCodCompañia,
                          strAñoProceso,
                          strVersion,
                          strPeriodo,
                          strCodGerencia,
                          strCodTipoFormulacion,
                          strCodSubTipoFormulacion
                        );
        }

        public DataSet Formato_HojaTrabajo_Formato4P_Detalle(string strCodCompañia,
                  string strAñoProceso,
                  string strVersion,
                  string strPeriodo,
                  string strCodGerencia,
                  string strCodTipoFormulacion,
                  string strCodSubTipoFormulacion
                )
        {
            return objDs.Formato_HojaTrabajo_Formato4P_Detalle(strCodCompañia,
                          strAñoProceso,
                          strVersion,
                          strPeriodo,
                          strCodGerencia,
                          strCodTipoFormulacion,
                          strCodSubTipoFormulacion
                        );
        }

        public DataSet Formato_PIA_Formato4P_Detalle(string strCodCompañia,
                  string strAñoProceso
                )
        {
            return objDs.Formato_PIA_Formato4P_Detalle(strCodCompañia,
                          strAñoProceso
                        );
        }

        public DataSet Formato_Ejecucion_Ingreso_Detalle(string strCodCompañia,
                  string strAñoProceso,
                  string strMes
                )
        {
            return objDs.Formato_Ejecucion_Ingreso_Detalle(strCodCompañia,
                          strAñoProceso,
                          strMes
                        );
        }

        public DataSet Formato_Ejecucion_Egreso_Resumen(string strCodCompañia,
                  string strAñoProceso,
                  string strMes
                )
        {
            return objDs.Formato_Ejecucion_Egreso_Resumen(strCodCompañia,
                          strAñoProceso,
                          strMes
                        );
        }

        public DataSet Formato_Ejecucion_Inversion_Resumen(string strCodCompañia,
                  string strAñoProceso,
                  string strMes
                )
        {
            return objDs.Formato_Ejecucion_Inversion_Resumen(strCodCompañia,
                          strAñoProceso,
                          strMes
                        );
        }

        public DataSet Formato_Ejecucion_Egreso_Detalle(string strCodCompañia,
                  string strCodPosPre,
                  string strAñoProceso,
                  string strMes
                )
        {
            return objDs.Formato_Ejecucion_Egreso_Detalle(strCodCompañia,
                          strCodPosPre,
                          strAñoProceso,
                          strMes
                        );
        }

        public DataSet Formato_Ejecucion_Egreso_Detalle_Presupuesto(string strCodCompañia,
          string strCodPosPre,
          string strAñoProceso,
          string strMes
        )
        {
            return objDs.Formato_Ejecucion_Egreso_Detalle_Presupuesto(strCodCompañia,
                          strCodPosPre,
                          strAñoProceso,
                          strMes
                        );
        }

        public DataSet Formato_Ejecucion_Egreso_Detalle_Contabilidad(string strCodCompañia,
          string strCodPosPre,
          string strAñoProceso,
          string strMes
        )
        {
            return objDs.Formato_Ejecucion_Egreso_Detalle_Contabilidad(strCodCompañia,
                          strCodPosPre,
                          strAñoProceso,
                          strMes
                        );
        }


        public DataSet Formato_Ejecucion_Inversion_Detalle(string strCodCompañia,
                  string strCodPosPre,
                  string strAñoProceso,
                  string strMes
                )
        {
            return objDs.Formato_Ejecucion_Inversion_Detalle(strCodCompañia,
                          strCodPosPre,
                          strAñoProceso,
                          strMes
                        );
        }

        public DataSet Formato_Ejecucion_Inversion_Detalle_Presupuesto(string strCodCompañia,
          string strCodPosPre,
          string strAñoProceso,
          string strMes
        )
        {
            return objDs.Formato_Ejecucion_Inversion_Detalle_Presupuesto(strCodCompañia,
                          strCodPosPre,
                          strAñoProceso,
                          strMes
                        );
        }

        public DataSet Formato_Ejecucion_Inversion_Detalle_Contabilidad(string strCodCompañia,
              string strCodPosPre,
              string strAñoProceso,
              string strMes
            )
        {
            return objDs.Formato_Ejecucion_Inversion_Detalle_Contabilidad(strCodCompañia,
                          strCodPosPre,
                          strAñoProceso,
                          strMes
                        );
        }


        public DataSet Formato_PIA_Formato5P_Resumen(string strCodCompañia,
                                                      string strAñoProceso,
                                                      string strCodTipoFormulacion,
                                                      string strCodSubTipoFormulacion
                                                    )
        {
            return objDs.Formato_PIA_Formato5P_Resumen(strCodCompañia,
                          strAñoProceso,
                          strCodTipoFormulacion,
                          strCodSubTipoFormulacion
                        );
        }

        public DataSet Formato_PIA_Formato5E_Resumen(string strCodCompañia,
                                                      string strAñoProceso
                                                    )
        {
            return objDs.Formato_PIA_Formato5E_Resumen(strCodCompañia,
                          strAñoProceso
                        );
        }

        public DataSet Formato_PIA_Formato5E_Detalle(string strCodCompañia,
                                                      string strAñoProceso
                                                    )
        {
            return objDs.Formato_PIA_Formato5E_Detalle(strCodCompañia,
                          strAñoProceso
                        );
        }

        public DataSet Formato_HojaTrabajo_Formato_8P(string strCodCompañia,
          string strAñoProceso,
          string strVersion,
          string strPeriodo
        )
        {
            return objDs.Formato_HojaTrabajo_Formato_8P(strCodCompañia,
                          strAñoProceso,
                          strVersion,
                          strPeriodo
                        );
        }

        public DataSet Formato_PIA_Formato_8P(string strCodCompañia,
          string strAñoProceso
        )
        {
            return objDs.Formato_PIA_Formato_8P(strCodCompañia,
                          strAñoProceso
                        );
        }
        public DataSet Formato_HojaTrabajo_AjusteManual(string strCodCompañia,
          string strAñoProceso,
          string strCodClasificador_Resumen,
          string strPeriodo
        )
        {
            return objDs.Formato_HojaTrabajo_AjusteManual(strCodCompañia,
                          strAñoProceso,
                          strCodClasificador_Resumen,
                          strPeriodo
                        );
        }
        public DataSet Formato_HojaTrabajo_FONAFE(  string strCodCompañia,
                                                    string strAñoProceso,
                                                    string strPeriodo)
        {
            return objDs.Formato_HojaTrabajo_FONAFE(strCodCompañia,
                          strAñoProceso,strPeriodo);
        }

        public int Graba_HojaTrabajo_FONAFE(Model.Formulacion_HojaTrabajo_FONAFE obj)
        {
            return objDs.Graba_HojaTrabajo_FONAFE(obj);
        }

        public int Modifica_HojaTrabajo_FONAFE(Model.Formulacion_HojaTrabajo_FONAFE obj)
        {
            return objDs.Modifica_HojaTrabajo_FONAFE(obj);
        }

        public DataSet Formato_HojaTrabajo_AjusteManual_FONAFE(string strCodCompañia,
                                                              string strAñoProceso,
                                                              string strPeriodo
                                                            )
        {
            return objDs.Formato_HojaTrabajo_AjusteManual_FONAFE(strCodCompañia,
                          strAñoProceso,
                          strPeriodo
                        );
        }

        public DataSet Formato_HojaTrabajo_Distribucion_FONAFE(string strCodCompañia,
                                                              string strAñoProceso,
                                                              string strPeriodo
                                                            )
        {
            return objDs.Formato_HojaTrabajo_Distribucion_FONAFE(strCodCompañia,
                          strAñoProceso,
                          strPeriodo
                        );
        }

        public DataSet Formato_HojaTrabajo_AjusteManual_Resumen(string strCodCompañia,
          string strAñoProceso,
          string strPeriodo
        )
        {
            return objDs.Formato_HojaTrabajo_AjusteManual_Resumen(strCodCompañia,
                          strAñoProceso,
                          strPeriodo
                        );
        }
        public DataSet Formato_HojaTrabajo_Conciliacion_Detalle_01(string strCodCompañia,
          string strAñoProceso,
          string strVersion,
          string strPeriodo,
          string strCodGerencia,
          string strCodTipoFormulacion,
          string strCodSubTipoFormulacion
        )
        {
            return objDs.Formato_HojaTrabajo_Conciliacion_Detalle_01(strCodCompañia,
                          strAñoProceso,
                          strVersion,
                          strPeriodo,
                          strCodGerencia,
                          strCodTipoFormulacion,
                          strCodSubTipoFormulacion
                        );
        }

        public DataSet Formato_HojaTrabajo_Conciliacion_Detalle_02(string strCodCompañia,
          string strAñoProceso,
          string strVersion,
          string strPeriodo,
          string strCodGerencia,
          string strCodTipoFormulacion,
          string strCodSubTipoFormulacion
        )
        {
            return objDs.Formato_HojaTrabajo_Conciliacion_Detalle_02(strCodCompañia,
                          strAñoProceso,
                          strVersion,
                          strPeriodo,
                          strCodGerencia,
                          strCodTipoFormulacion,
                          strCodSubTipoFormulacion
                        );
        }

        public DataSet Formato_HojaTrabajo_Conciliacion_Detalle_03(string strCodCompañia,
          string strAñoProceso,
          string strVersion,
          string strPeriodo,
          string strCodGerencia,
          string strCodTipoFormulacion,
          string strCodSubTipoFormulacion
        )
        {
            return objDs.Formato_HojaTrabajo_Conciliacion_Detalle_03(strCodCompañia,
                          strAñoProceso,
                          strVersion,
                          strPeriodo,
                          strCodGerencia,
                          strCodTipoFormulacion,
                          strCodSubTipoFormulacion
                        );
        }

        public DataSet Formato_HojaTrabajo_Conciliacion_Resumido_03(string strCodCompañia,
         string strAñoProceso,
         string strVersion,
         string strPeriodo,
         string strCodGerencia,
         string strCodTipoFormulacion,
         string strCodSubTipoFormulacion
       )
        {
            return objDs.Formato_HojaTrabajo_Conciliacion_Resumido_03(strCodCompañia,
                          strAñoProceso,
                          strVersion,
                          strPeriodo,
                          strCodGerencia,
                          strCodTipoFormulacion,
                          strCodSubTipoFormulacion
                        );
        }

        public DataSet Reporte_Formuacion_HojaTrabajo_Detalle(string strCodCompañia,
                          string strAñoProceso,
                          string strVersion,
                          string strPeriodo,
                          string strCodGerencia,
                          string strCodTipoFormulacion,
                          string strCodSubTipoFormulacion
                        )
        {
            return objDs.Reporte_Formuacion_HojaTrabajo_Detalle(strCodCompañia,
                          strAñoProceso,
                          strVersion,
                          strPeriodo,
                          strCodGerencia,
                          strCodTipoFormulacion,
                          strCodSubTipoFormulacion
                        );
        }



        

        public DataSet Reporte_Detalle_PIA(string strCodCompañia,
                          string strAñoProceso,
                          string strVersion,
                          string strCodCentroGestor
                        )
        {
            return objDs.Reporte_Detalle_PIA( strCodCompañia,
                           strAñoProceso,
                           strVersion,
                           strCodCentroGestor
                        );
        }

        public DataSet Reporte_SaldoDetalle_PIA(string strCodCompañia,
                          string strAñoProceso,
                          string strVersion,
                          string strCodCentroGestor
                        )
        {
            return objDs.Reporte_SaldoDetalle_PIA( strCodCompañia,
                           strAñoProceso,
                           strVersion,
                           strCodCentroGestor
                        );
        }

        public DataSet Reporte_Resumen_ModificacionFormulacion(string strCodCompañia,
                                                              string strAñoProceso,
                                                              string strVersion,
                                                              string strPeriodo
                                                            )
        {
            return objDs.Reporte_Resumen_ModificacionFormulacion(strCodCompañia,
                                                            strAñoProceso,
                                                             strVersion,
                                                             strPeriodo
                                                            );
        }

        public DataSet Reporte_ResumenMensual_Formulacion(string strCodCompañia,
                                                      string strAñoProceso,
                                                      string strVersion
                                                    )
        {
            return objDs.Reporte_ResumenMensual_Formulacion(strCodCompañia,
                                                            strAñoProceso,
                                                             strVersion
                                                            );
        }


        public DataSet Ayuda_CentroGestor_HojaTrabajo(string strCodCentroGestorSuperior)
        {
            return objDs.Ayuda_CentroGestor_HojaTrabajo(strCodCentroGestorSuperior);
        }

        public DataSet Ayuda_Gerencia_HojaTrabajo(string strCodEmpresa)
        {
            return objDs.Ayuda_Gerencia_HojaTrabajo(strCodEmpresa);
        }

        public DataSet Ayuda_UnidadEconomica(string strCodEmpresa)
        {
            return objDs.Ayuda_UnidadEconomica(strCodEmpresa);
        }

        public DataSet Ayuda_TipoFormulacion_HojaTrabajo(string strCodEmpresa)
        {
            return objDs.Ayuda_TipoFormulacion_HojaTrabajo(strCodEmpresa);
        }

        public DataSet Ayuda_SubTipoFormulacion_HojaTrabajo(string strCodEmpresa, string strCodTipoFormulacion)
        {
            return objDs.Ayuda_SubTipoFormulacion_HojaTrabajo(strCodEmpresa,strCodTipoFormulacion);
        }


        #endregion

        #region Gestion_HojaTrabajo
        public DataSet Lista_Mensajevalidacion_PasePresupuestal(string strCodCompañia,
                                                        string strAñoProceso,
                                                        string strNumRequerimiento
                                                       )
        {
            return objDs.Lista_Mensajevalidacion_PasePresupuestal( strCodCompañia,
                                                         strAñoProceso,
                                                         strNumRequerimiento
                                                       );
        }

        public DataSet Combo_TipoMensajeValidacion()
        {
            return objDs.Combo_TipoMensajeValidacion();
        }
        public DataSet Lista_TerminoReferencia_IdaVuelta(string strCodCompañia,
                                                            string strCodEmpleado,
                                                            string strTipoMovimiento
                                                        )
        {
            return objDs.Lista_TerminoReferencia_IdaVuelta( strCodCompañia,
                                                      strCodEmpleado,
                                                      strTipoMovimiento
                                                        );
        }

        public DataSet Lista_Encargatura_Empleado(string strCodCompañia,
                                                  string strCodEmpleado
                                                 )
        {
            return objDs.Lista_Encargatura_Empleado( strCodCompañia,
                                                strCodEmpleado
                                                 );
        }

        public DataSet Lista_Encargatura(string strCodCompañia)
        {
            return objDs.Lista_Encargatura(strCodCompañia);
        }

        public Model.Encargatura Recupera_Encargatura(int intIdEncargatura)
        {
            return objDs.Recupera_Encargatura(intIdEncargatura);
        }

        public Model.Encargatura Graba_Encargatura(string strAñoProceso,
                                                    Model.Encargatura obj)
        {
            return objDs.Graba_Encargatura(strAñoProceso,
                                                    obj);
        }

        public int Modifica_Encargatura(string strAñoProceso, Model.Encargatura obj)
        {
            return objDs.Modifica_Encargatura( strAñoProceso, obj);
        }

        public Boolean Elimina_Encargatura(string strNumDocumento)
        {
            return objDs.Elimina_Encargatura(strNumDocumento);
        }


        public DataTable Combo_TipoEngargatura()
        {
            return objDs.Combo_TipoEngargatura();
        }

        public DataTable Combo_PeriodoPlanEstrategico(string strCodCompañia)
        {
            return objDs.Combo_PeriodoPlanEstrategico(strCodCompañia);
        }

        public DataTable Combo_PeriodoPlanEstrategico_Version(string strCodCompañia,
                                                                string strAñoProceso
                                                            )
        {
            return objDs.Combo_PeriodoPlanEstrategico_Version(strCodCompañia,
                                                        strAñoProceso
                                                            );
        }

        public Boolean Traslada_Requerimiento_a_SPRING(string strNumRequerimiento)
        {
            return objDs.Traslada_Requerimiento_a_SPRING(strNumRequerimiento);
        }

        public DataSet Reporte_EstadoRequerimiento(string strCodCompañia,
                                                    string strPeriodoInicial,
                                                    string strPeriodoFinal,
                                                    string strCodCentroGestor,
                                                    int intTipo
                                          )
        {
            return objDs.Reporte_EstadoRequerimiento( strCodCompañia,
                                                strPeriodoInicial,
                                                strPeriodoFinal,
                                                strCodCentroGestor,
                                                 intTipo
                                          );
        }

        public DataSet Reporte_EstadoReasignacion(string strCodCompañia,
                                                    string strPeriodoInicial,
                                                    string strPeriodoFinal,
                                                    string strCodCentroGestor
                                          )
        {
            return objDs.Reporte_EstadoReasignacion( strCodCompañia,
                                               strPeriodoInicial,
                                               strPeriodoFinal,
                                               strCodCentroGestor
                                          );
        }

        public DataSet Ayuda_PlanEstrategico(string strCodCompañia,
                                             string strAñoProceso
                                            )
        {
            return objDs.Ayuda_PlanEstrategico(strCodCompañia,
                                         strAñoProceso
                                            );
        }

        public DataSet Lista_PlanEstrategico_LineaFormulacion(string strCodCompañia,
                                                        string strAñoProceso,
                                                        string strCodIndicadorOperativo
                                                     )
        {
            return objDs.Lista_PlanEstrategico_LineaFormulacion( strCodCompañia,
                                                        strAñoProceso,
                                                         strCodIndicadorOperativo
                                                     );
        }

        public Boolean Graba_PlanEstrategico_LineaFormulacion(string strCodCompañia,
                                                                string strAñoProceso,
                                                                string strCodIndicadorOperativo,
                                                                string strCodLineaFormulacion
                                              )
        {
            return objDs.Graba_PlanEstrategico_LineaFormulacion( strCodCompañia,
                                                           strAñoProceso,
                                                           strCodIndicadorOperativo,
                                                           strCodLineaFormulacion
                                              );
        }

        public Boolean Elimina_PlanEstrategico_LineaFormulacion(string strCodCompañia,
                                                string strAñoProceso,
                                                string strCodIndicadorOperativo,
                                                string strCodLineaFormulacion
                                              )
        {
            return objDs.Elimina_PlanEstrategico_LineaFormulacion( strCodCompañia,
                                                 strAñoProceso,
                                                 strCodIndicadorOperativo,
                                                 strCodLineaFormulacion
                                              );
        }
        public DataSet Lista_Estado_FuenteFinanciamiento(string strCodCompañia,
                                                                string strCodFuenteFinanciamiento
                                                             )
        {
            return objDs.Lista_Estado_FuenteFinanciamiento(strCodCompañia,
                                                      strCodFuenteFinanciamiento
                                                             );
        }

        public Boolean Modifica_Estado_FuenteFinanciamiento(string strCodCompañia,
                                                                string strCodFuenteFinanciamiento,
                                                                string strCodProyecto,
                                                                Boolean blnEstado
                                              )
        {
            return objDs.Modifica_Estado_FuenteFinanciamiento( strCodCompañia,
                                                        strCodFuenteFinanciamiento,
                                                        strCodProyecto,
                                                        blnEstado
                                              );
        }
        #endregion

        #region MotivoRechazoAjuste
        public DataSet Combo_MotivoRechazoAjuste(string strCodTipoRechazo)
        {
            return objDs.Combo_MotivoRechazoAjuste(strCodTipoRechazo);
        }

        public DataSet Ayuda_MotivoRechazoAjuste()
        {
            return objDs.Ayuda_MotivoRechazoAjuste();
        }

        public Model.MotivoRechazoAjuste Recupera_MotivoRechazoAjuste(int intIdMotivoRechazoAjuste)
        {
            return objDs.Recupera_MotivoRechazoAjuste( intIdMotivoRechazoAjuste);
        }


        public Model.MotivoRechazoAjuste Recupera_MotivoRechazoAjuste_Codigo(string strCodMotivoRechazoAjuste)
        {
            return objDs.Recupera_MotivoRechazoAjuste_Codigo(strCodMotivoRechazoAjuste);
        }

        public int Graba_MotivoRechazoAjuste(Model.MotivoRechazoAjuste obj)
        {
            return objDs.Graba_MotivoRechazoAjuste(obj);
        }

        public int Modifica_MotivoRechazoAjuste(Model.MotivoRechazoAjuste obj)
        {
            return objDs.Modifica_MotivoRechazoAjuste(obj);
        }

        public bool Elimina_MotivoRechazoAjuste(int intIdMotivoRechazoAjuste)
        {
            return objDs.Elimina_MotivoRechazoAjuste(intIdMotivoRechazoAjuste);
        }

        public DataTable Lista_MotivoRechazoAjuste()
        {
            return objDs.Lista_MotivoRechazoAjuste();
        }

        #endregion

        #region MotivoRechazoRequerimiento
        public DataSet Combo_MotivoRechazoRequerimiento(string strCodTipoRechazo)
        {
            return objDs.Combo_MotivoRechazoRequerimiento( strCodTipoRechazo);
        }

        public DataSet Ayuda_MotivoRechazoRequerimiento()
        {
            return objDs.Ayuda_MotivoRechazoRequerimiento();
        }

        public Model.MotivoRechazoRequerimiento Recupera_MotivoRechazoRequerimiento(int intIdMotivoRechazoRequerimiento)
        {
            return objDs.Recupera_MotivoRechazoRequerimiento(intIdMotivoRechazoRequerimiento);
        }


        public Model.MotivoRechazoRequerimiento Recupera_MotivoRechazoRequerimiento_Codigo(string strCodMotivoRechazoRequerimiento)
        {
            return objDs.Recupera_MotivoRechazoRequerimiento_Codigo(strCodMotivoRechazoRequerimiento);
        }

        public int Graba_MotivoRechazoRequerimiento(Model.MotivoRechazoRequerimiento obj)
        {
            return objDs.Graba_MotivoRechazoRequerimiento(obj);
        }

        public int Modifica_MotivoRechazoRequerimiento(Model.MotivoRechazoRequerimiento obj)
        {
            return objDs.Modifica_MotivoRechazoRequerimiento(obj);
        }

        public bool Elimina_MotivoRechazoRequerimiento(int intIdMotivoRechazoRequerimiento)
        {
            return objDs.Elimina_MotivoRechazoRequerimiento(intIdMotivoRechazoRequerimiento);
        }

        public DataTable Lista_MotivoRechazoRequerimiento()
        {
            return objDs.Lista_MotivoRechazoRequerimiento();
        }

        #endregion

        #region ParametroLogistica

        public Model.ParametroLogistica Recupera_ParametroLogistica(int intIdParametro)
        {
            return objDs.Recupera_ParametroLogistica(intIdParametro);
        }

        public int Graba_ParametroLogistica(Model.ParametroLogistica obj)
        {
            return objDs.Graba_ParametroLogistica(obj);
        }

        public int Modifica_ParametroLogistica(Model.ParametroLogistica obj)
        {
            return objDs.Modifica_ParametroLogistica(obj);
        }

        public bool Elimina_ParametroLogistica(int intIdParametro)
        {
            return objDs.Elimina_ParametroLogistica(intIdParametro);
        }

        public DataSet Lista_ParametroLogistica(string strCodEmpresa)
        {
            return objDs.Lista_ParametroLogistica(strCodEmpresa);
        }

        #endregion

        #region ParametroFormulacion
        public Model.ParametroFormulacion Recupera_ParametroFormulacion_Codigo( string strCodEmpresa,
                                                                                string strCodParametro)
        {
            return objDs.Recupera_ParametroFormulacion_Codigo(strCodEmpresa, strCodParametro);
        }

        public Model.ParametroFormulacion Recupera_ParametroFormulacion(int intIdParametro)
        {
            return objDs.Recupera_ParametroFormulacion( intIdParametro);
        }

        public int Graba_ParametroFormulacion(Model.ParametroFormulacion obj)
        {
            return objDs.Graba_ParametroFormulacion(obj);
        }

        public int Modifica_ParametroFormulacion(Model.ParametroFormulacion obj)
        {
            return objDs.Modifica_ParametroFormulacion(obj);
        }

        public bool Elimina_ParametroFormulacion(int intIdParametro)
        {
            return objDs.Elimina_ParametroFormulacion( intIdParametro);
        }

        public DataSet Lista_ParametroFormulacion(string strCodEmpresa)
        {
            return objDs.Lista_ParametroFormulacion(strCodEmpresa);
        }

        #endregion

        #region ParametroGestion
        public Model.ParametroGestion Recupera_ParametroGestion_Codigo(string strCodParametroGestion)
        {
            return objDs.Recupera_ParametroGestion_Codigo(strCodParametroGestion);
        }

        public Model.ParametroGestion Recupera_ParametroGestion(int intIdParametroGestion)
        {
            return objDs.Recupera_ParametroGestion(intIdParametroGestion);
        }

        public int Graba_ParametroGestion(Model.ParametroGestion obj)
        {
            return objDs.Graba_ParametroGestion(obj);
        }

        public int Modifica_ParametroGestion(Model.ParametroGestion obj)
        {
            return objDs.Modifica_ParametroGestion(obj);
        }

        public bool Elimina_ParametroGestion(int intIdParametro)
        {
            return objDs.Elimina_ParametroGestion(intIdParametro);
        }

        public DataSet Lista_ParametroGestion()
        {
            return objDs.Lista_ParametroGestion();
        }

        #endregion

        #region PasoAjuste
        public Model.Paso_Ajuste GetPaso_Ajuste(string strNumAjuste
                                                     )
        {
            return objDs.GetPaso_Ajuste(strNumAjuste);
        }


        private Model.Paso_Ajuste GetEmpDataTableRow(DataRow dr)
        {
            return GetEmpDataTableRow(dr);
        }

        #endregion

        #region PasoRequerimiento
        public Model.Paso_Requerimiento GetPaso_Requerimiento(string strNumRequerimiento )
        {
            return objDs.GetPaso_Requerimiento(strNumRequerimiento);
        }


        private Model.Paso_Requerimiento GetEmpDataTableRow_Pry(DataRow dr)
        {
            return GetEmpDataTableRow_Pry(dr);
        }

        #endregion

        #region PAC_HojaTrabajo
        public Boolean EliminaPacHojaTrabajo_Detalle(int intIdDetalle)
        {
            return objDs.EliminaPacHojaTrabajo_Detalle(intIdDetalle);
        }


        public DataSet Reporte_Detalle_PAC(string strCodCompañia,
                  string strAñoProceso,
                  string strVersion,
                  string strCodCentroGestor
                )
        {
            return objDs.Reporte_Detalle_PAC( strCodCompañia,
                                       strAñoProceso,
                                       strVersion,
                                       strCodCentroGestor
                                    );
        }


        public DataTable Combo_PeriodoPAC_Version(string strCodCompañia, string strAñoProceso)
        {
            return objDs.Combo_PeriodoPAC_Version(strCodCompañia, strAñoProceso);
        }

        public Model.Formulacion_Detlle_CodFormulacion Recupera_Formulacion_Detlle_CodFormulacion(string strCodCompañia,
                                                                                                    string strAñoProceso,
                                                                                                    string strCodCentroGestor,
                                                                                                    string strCodFormulacion
                                                                                                 )
        {
            return objDs.Recupera_Formulacion_Detlle_CodFormulacion(strCodCompañia,
                                                             strAñoProceso,
                                                             strCodCentroGestor,
                                                             strCodFormulacion
                                                            );
        }

        public DataSet Lista_Pac_HojaTrabajo(string strCodCompañia,
                                                        string strAñoProceso,
                                                        string strVersion,
                                                        string strCodCentroGestor
                                                    )
        {
            return objDs.Lista_Pac_HojaTrabajo(strCodCompañia,
                                         strAñoProceso,
                                         strVersion,
                                         strCodCentroGestor
                                                    );
        }

        public DataTable Combo_PeriodoPAC(string strCodCompañia)
        {
            return objDs.Combo_PeriodoPAC(strCodCompañia);
        }

        public string Graba_Pac_HojaTrabajo(Model.Pac_HojaTrabajo obj)
        {
            return objDs.Graba_Pac_HojaTrabajo(obj);
        }

        public int Graba_Pac_HojaTrabajo_Detalle(Model.Pac_HojaTrabajo_detalle obj)
        {
            return objDs.Graba_Pac_HojaTrabajo_Detalle(obj);
        }

        public int Modifica_Pac_HojaTrabajo_Detalle(Model.Pac_HojaTrabajo_detalle obj)
        {
            return objDs.Modifica_Pac_HojaTrabajo_Detalle(obj);
        }

        public int Graba_Pac_HojaTrabajo_Detalle_Item(Model.Pac_HojaTrabajo_detalle_Item obj)
        {
            return objDs.Graba_Pac_HojaTrabajo_Detalle_Item(obj);
        }
        public int Modifica_Pac_HojaTrabajo_Detalle_Item(Model.Pac_HojaTrabajo_detalle_Item obj)
        {
            return objDs.Modifica_Pac_HojaTrabajo_Detalle_Item(obj);
        }


        public DataSet Ayuda_Pac_HojaTrabajo(string strCodEmpresa,
                                             string strAñoProceso,
                                             string strCodCentroGestor
                                            )
        {
            return objDs.Ayuda_Pac_HojaTrabajo( strCodEmpresa,
                                          strAñoProceso,
                                          strCodCentroGestor
                                            );
        }

        public DataSet Ayuda_Formulacion_HojaTrabajo_CentroGestor(string strCodEmpresa,
                                                                    string strAñoProceso,
                                                                    string strCodCentroGestor,
                                                                    string strLineas
                                                                 )
        {
            return objDs.Ayuda_Formulacion_HojaTrabajo_CentroGestor( strCodEmpresa,
                                                               strAñoProceso,
                                                               strCodCentroGestor,
                                                               strLineas
                                                                 );
        }

        public int Recupera_PeriodoPac_IdCabecera(string strCodCompañia,
                                                          string strAñoProceso,
                                                          string strVersion
                                                        )
        {
            return objDs.Recupera_PeriodoPac_IdCabecera(strCodCompañia,
                                                  strAñoProceso,
                                                  strVersion
                                                        );
        }

        #endregion

        #region Requerimiento
        public DataSet Ayuda_PDF(string strCodCeGe,
                         string strNumDocumento
                       )
        {
            return objDs.Ayuda_PDF(strCodCeGe,
                         strNumDocumento
                       );
        }


        public Model.Requerimiento GetRequerimiento(string strNumRequerimiento)
        {
            return objDs.GetRequerimiento(strNumRequerimiento);
        }

        public List<Model.Requerimiento> GetListaRequerimiento(string strCodCentroGestor)
        {
            return objDs.GetListaRequerimiento(strCodCentroGestor);
        }

        private Model.Requerimiento GetEmpDataTableRow_Req(DataRow dr)
        {
            return GetEmpDataTableRow_Req(dr);
        }

        public Model.Formulacion_Saldo Recupera_Formulacion_Saldo(Model.Formulacion_Saldo obj)
        {
            return objDs.Recupera_Formulacion_Saldo(obj);
        }

        private Model.Formulacion_Saldo GetSalDataTableRow(DataRow dr)
        {
            return GetSalDataTableRow(dr);
        }

        #endregion

        #region Requerimiento_Adjunto
        public DataSet Lista_Requerimiento_Adjunto_Codigo(string strNumDocumento)
        {
            return objDs.Lista_Requerimiento_Adjunto_Codigo(strNumDocumento);
        }
        public DataSet Lista_Requerimiento_Adjunto(string strNumProcedimiento)
        {
            return objDs.Lista_Requerimiento_Adjunto(strNumProcedimiento);
        }

        public DataSet Lista_Requerimiento_Adjunto_Consulta(string strNumProcedimiento)
        {
            return objDs.Lista_Requerimiento_Adjunto_Consulta(strNumProcedimiento);
        }

        public Model.Requerimiento_Adjunto Recupera_Requerimiento_Adjunto_Codigo(string strNumRequerimiento)
        {
            return objDs.Recupera_Requerimiento_Adjunto_Codigo(strNumRequerimiento);
        }
        public Model.Requerimiento_Adjunto Recupera_Requerimiento_Adjunto(int intIdAdjunto)
        {
            return objDs.Recupera_Requerimiento_Adjunto(intIdAdjunto);
        }
        public int Graba_Requerimiento_Adjunto(Model.Requerimiento_Adjunto obj)
        {
            return objDs.Graba_Requerimiento_Adjunto(obj);
        }
        public int Modifica_Requerimiento_Adjunto(Model.Requerimiento_Adjunto obj)
        {
            return objDs.Modifica_Requerimiento_Adjunto(obj);
        }

        public bool Elimina_Requerimiento_Adjunto(int intIdAdjunto)
        {
            return objDs.Elimina_Requerimiento_Adjunto(intIdAdjunto);
        }

        #endregion

        #region Requerimiento_Cabecera
        public Model.Requerimiento_Cabecera Recupera_Requerimiento_Cabecera_NumRequerimiento(string strNumRequerimiento)
        {
            return objDs.Recupera_Requerimiento_Cabecera_NumRequerimiento(strNumRequerimiento);
        }
        public Model.Requerimiento_Cabecera Recupera_Requerimiento_Cabecera(int intIdRequrimiento_Cabecera)
        {
            return objDs.Recupera_Requerimiento_Cabecera(intIdRequrimiento_Cabecera);
        }

        public Model.Requerimiento_Cabecera Graba_Requerimiento_Cabecera(Model.Requerimiento_Cabecera obj)
        {
            return objDs.Graba_Requerimiento_Cabecera(obj);
        }

        public int Modifica_Requerimiento_Cabecera(Model.Requerimiento_Cabecera obj)
        {
            return objDs.Modifica_Requerimiento_Cabecera(obj);
        }

        public int Modifica_Requerimiento_Cabecera_NumRequerimiento(Model.Requerimiento_Cabecera obj)
        {
            return objDs.Modifica_Requerimiento_Cabecera_NumRequerimiento(obj);
        }

        public int Modifica_Requerimiento_Cabecera_Requerimiento(Model.Requerimiento_Cabecera obj)
        {
            return objDs.Modifica_Requerimiento_Cabecera_Requerimiento(obj);
        }

        public int Elimina_Requerimiento_Cabecera(int intIdRequerimiento_Cabecera)
        {
            return objDs.Elimina_Requerimiento_Cabecera(intIdRequerimiento_Cabecera);
        }

        public DataSet Lista_Requerimiento_Cabecera_Adjunto(string strNumRequerimiento)
        {
            return objDs.Lista_Requerimiento_Cabecera_Adjunto(strNumRequerimiento);
        }

        public Boolean Graba_Requerimiento_Cabecera_Adjunto(string strNumRequerimiento,
                                                             string strArchivo,
                                                             string strNombreArchivo
                                                           )
        {
            return objDs.Graba_Requerimiento_Cabecera_Adjunto( strNumRequerimiento,
                                                         strArchivo,
                                                         strNombreArchivo
                                                           );
        }

        public Boolean Elimina_Requerimiento_Cabecera_Adjunto(string strNumRequerimiento,
                                                             string strArchivo,
                                                             string strNombreArchivo
                                                           )
        {
            return objDs.Elimina_Requerimiento_Cabecera_Adjunto( strNumRequerimiento,
                                                            strArchivo,
                                                           strNombreArchivo
                                                           );
        }

        #endregion

        #region Requerimiento_Cabecera_Viatico
        public Model.Requerimiento_Cabecera_Viatico Recupera_Requerimiento_Cabecera_Viatico(int intIdRequrimiento_Cabecera_Viatico)
        {
            return objDs.Recupera_Requerimiento_Cabecera_Viatico(intIdRequrimiento_Cabecera_Viatico);
        }

        public int Graba_Requerimiento_Cabecera_Viatico(Model.Requerimiento_Cabecera_Viatico obj)
        {
            return objDs.Graba_Requerimiento_Cabecera_Viatico(obj);
        }

        public int Modifica_Requerimiento_Cabecera_Viatico(Model.Requerimiento_Cabecera_Viatico obj)
        {
            return objDs.Modifica_Requerimiento_Cabecera_Viatico(obj);
        }


        public Boolean Elimina_Requerimiento_Cabecera_Viatico(int intIdRequerimiento_Cabecera_Viatico)
        {
            return objDs.Elimina_Requerimiento_Cabecera_Viatico(intIdRequerimiento_Cabecera_Viatico);
        }

        public DataSet Lista_Requerimiento_Cabecera_Viatico(string strNumRequerimiento)
        {
            return objDs.Lista_Requerimiento_Cabecera_Viatico(strNumRequerimiento);
        }

        #endregion

        #region Requerimiento_Detalle
        public DataSet Recupera_Saldo_vs_Tope(String strAñoProceso,
                                       string strCodTipoGasto,
                                       string strCodFuenteFinanciamiento,
                                       string strCodProyecto,
                                       string strCodComponente
                                      )
        {
            return objDs.Recupera_Saldo_vs_Tope( strAñoProceso,
                                        strCodTipoGasto,
                                        strCodFuenteFinanciamiento,
                                        strCodProyecto,
                                        strCodComponente
                                      );
        }

        public Model.Requerimiento_Detalle Recupera_Requerimiento_Detalle(int intIdRequrimiento_Detalle)
        {
            return objDs.Recupera_Requerimiento_Detalle(intIdRequrimiento_Detalle);
        }

        public int Graba_Requerimiento_Detalle(Model.Requerimiento_Detalle obj)
        {
            return objDs.Graba_Requerimiento_Detalle(obj);
        }

        public int Modifica_Requerimiento_Detalle(Model.Requerimiento_Detalle obj)
        {
            return objDs.Modifica_Requerimiento_Detalle(obj);
        }

        public int Elimina_Requerimiento_Detalle(int intIdRequerimiento_Detalle,
                                                 Boolean EsCofinanciado,
                                                 string strNumRequerimiento,
                                                 string strCodTipoAdquisicion
                                                )
        {
            return objDs.Elimina_Requerimiento_Detalle( intIdRequerimiento_Detalle,
                                                  EsCofinanciado,
                                                  strNumRequerimiento,
                                                  strCodTipoAdquisicion
                                                );
        }

        public DataSet Lista_Requerimiento_Detalle(string strNumRequerimiento)
        {
            return objDs.Lista_Requerimiento_Detalle(strNumRequerimiento);
        }

        public DataSet Lista_EjecucionPresupuestal_CentroGestor(string strAñoProceso, string strCodCentroGestor)
        {
            return objDs.Lista_EjecucionPresupuestal_CentroGestor(strAñoProceso, strCodCentroGestor);
        }

        public DataSet Lista_Consulta_LineaFormulacion(string strAñoProceso, string strCodCentroGestor)
        {
            return objDs.Lista_Consulta_LineaFormulacion(strAñoProceso, strCodCentroGestor);
        }

        public DataSet Lista_EjecucionPresupuestal_CentroGestor_Grafico(string strAñoProceso,
                                                                       string strCodCentroGestor,
                                                                       string strCodCentroCosto,
                                                                       string strCodClasificador
                                                                      )
        {
            return objDs.Lista_EjecucionPresupuestal_CentroGestor_Grafico( strAñoProceso,
                                                                     strCodCentroGestor,
                                                                     strCodCentroCosto,
                                                                       strCodClasificador
                                                                      );
        }

        public DataSet Lista_EjecucionPresupuestal_Proyecto(string strAñoProceso, string strCodProyecto)
        {
            return objDs.Lista_EjecucionPresupuestal_Proyecto(strAñoProceso, strCodProyecto);
        }


        public DataSet Lista_Requerimiento_Detalle_Requerido(Model.Formulacion_Saldo obj)
        {
            return objDs.Lista_Requerimiento_Detalle_Requerido(obj);
        }

        public DataSet Lista_Requerimiento_Detalle_Ejecutado(Model.Formulacion_Saldo obj)
        {
            return objDs.Lista_Requerimiento_Detalle_Ejecutado(obj);
        }

        public DataSet Lista_Requerimiento_Detalle_Ajustado(Model.Formulacion_Saldo obj)
        {
            return objDs.Lista_Requerimiento_Detalle_Ajustado(obj);
        }

        public DataSet Lista_Requerimiento_Detalle_Requerimiento(Model.Formulacion_Saldo obj)
        {
            return objDs.Lista_Requerimiento_Detalle_Requerimiento(obj);
        }

        public DataSet Lista_Ajustado_CentroGestor(string strAñoProceso,
                                                    string strCodCentroGestor,
                                                    string strCodCentroCosto,
                                                    string strCodClasificador
                                                  )
        {
            return objDs.Lista_Ajustado_CentroGestor( strAñoProceso,
                                                 strCodCentroGestor,
                                                 strCodCentroCosto,
                                                  strCodClasificador
                                                  );
        }

        public DataSet Lista_Ajustado_SinAprobacion(string strAñoProceso,
                                                    string strCodCentroGestor
                                                  )
        {
            return objDs.Lista_Ajustado_SinAprobacion( strAñoProceso,
                                                  strCodCentroGestor
                                                  );
        }

        public DataSet Lista_Formulado_CentroGestor(string strAñoProceso,
                                                    string strCodCentroGestor,
                                                    string strCodCentroCosto,
                                                    string strCodClasificador
                                                  )
        {
            return objDs.Lista_Formulado_CentroGestor( strAñoProceso,
                                                 strCodCentroGestor,
                                                 strCodCentroCosto,
                                                 strCodClasificador
                                                  );
        }

        public DataSet Lista_Disponible_CentroGestor(string strAñoProceso,
                                                    string strCodCentroGestor,
                                                    string strCodCentroCosto,
                                                    string strCodClasificador
                                                  )
        {
            return objDs.Lista_Disponible_CentroGestor(strAñoProceso,
                                                   strCodCentroGestor,
                                                   strCodCentroCosto,
                                                   strCodClasificador
                                                  );
        }

        public DataSet Lista_Ejecutado_CentroGestor(string strAñoProceso,
                                                    string strCodCentroGestor,
                                                    string strCodCentroCosto,
                                                    string strCodClasificador
                                                  )
        {
            return objDs.Lista_Ejecutado_CentroGestor(strAñoProceso,
                                                strCodCentroGestor,
                                                strCodCentroCosto,
                                                strCodClasificador
                                                  );
        }

        public DataSet Lista_Comprometido_CentroGestor(string strAñoProceso,
                                                    string strCodCentroGestor,
                                                    string strCodCentroCosto,
                                                    string strCodClasificador
                                                  )
        {
            return objDs.Lista_Comprometido_CentroGestor(strAñoProceso,
                                                    strCodCentroGestor,
                                                    strCodCentroCosto,
                                                    strCodClasificador
                                                  );
        }


        public DataSet Lista_Formulado_Proyecto(string strAñoProceso,
                                            string strCodFuenteFinanciamiento,
                                            string strCodProyecto,
                                            string strCodClasificador
                                          )
        {
            return objDs.Lista_Formulado_Proyecto( strAñoProceso,
                                             strCodFuenteFinanciamiento,
                                             strCodProyecto,
                                             strCodClasificador
                                          );
        }

        public DataSet Lista_Ajustado_Proyecto(string strAñoProceso,
                                            string strCodFuenteFinanciamiento,
                                            string strCodProyecto,
                                            string strCodClasificador
                                          )
        {
            return objDs.Lista_Ajustado_Proyecto( strAñoProceso,
                                             strCodFuenteFinanciamiento,
                                             strCodProyecto,
                                             strCodClasificador
                                          );
        }

        public DataSet Lista_Disponible_Proyecto(string strAñoProceso,
                                                    string strCodFuenteFinanciamiento,
                                                    string strCodProyecto,
                                                    string strCodClasificador
                                                  )
        {
            return objDs.Lista_Disponible_Proyecto(strAñoProceso,
                                              strCodFuenteFinanciamiento,
                                              strCodProyecto,
                                              strCodClasificador
                                                  );
        }

        public DataSet Lista_Ejecutado_Proyecto(string strAñoProceso,
                                                    string strCodFuenteFinanciamiento,
                                                    string strCodProyecto,
                                                    string strCodClasificador
                                                  )
        {
            return objDs.Lista_Ejecutado_Proyecto(strAñoProceso,
                                             strCodFuenteFinanciamiento,
                                            strCodProyecto,
                                             strCodClasificador
                                                  );
        }

        public DataSet Lista_Comprometido_Proyecto(string strAñoProceso,
                                                    string strCodFuenteFinanciamiento,
                                                    string strCodProyecto,
                                                    string strCodClasificador
                                                  )
        {
            return objDs.Lista_Comprometido_Proyecto( strAñoProceso,
                                                strCodFuenteFinanciamiento,
                                                 strCodProyecto,
                                                  strCodClasificador
                                                  );
        }

        public DataSet Formato_Requerimiento(string strNumRequerimiento)
        {
            return objDs.Formato_Requerimiento(strNumRequerimiento);
        }

        public DataSet Formato_Requerimiento_Estado(string strCodCentro_Gestor,
                                                    string strEstado,
                                                    string strCodEmpleado
                                                   )
        {
            return objDs.Formato_Requerimiento_Estado(strCodCentro_Gestor,
                                                 strEstado,
                                                 strCodEmpleado
                                                   );
        }

        public DataSet Formato_Requerimiento_PasePresupuestal(string strCodCompañia,
                                                              string strAñoProceso
                                                            )
        {
            return objDs.Formato_Requerimiento_PasePresupuestal(strCodCompañia,
                                                           strAñoProceso
                                                            );
        }


        public DataSet Formato_Requerimiento_Cege(string strCodCentro_Gestor)
        {
            return objDs.Formato_Requerimiento_Cege(strCodCentro_Gestor);
        }

        public Boolean Formato_Requerimiento_Firma(string strCodCentro_Gestor,
                                                    string strPaso,
                                                    string strNumRequerimiento,
                                                    string strCodEmpleado
                                                   )
        {
            return objDs.Formato_Requerimiento_Firma( strCodCentro_Gestor,
                                                strPaso,
                                               strNumRequerimiento,
                                                strCodEmpleado
                                                   );
        }

        public Boolean Graba_Requerimiento_PasePresupuestal(string strNumRequerimiento,
                                                                string strCodMensaje,
                                                                string strMensaje,
                                                                string strCodEmpleado,
                                                                string strPaso,
                                                                string strCodCentroGestor
                                                             )
        {
            return objDs.Graba_Requerimiento_PasePresupuestal( strNumRequerimiento,
                                                                strCodMensaje,
                                                                strMensaje,
                                                                 strCodEmpleado,
                                                                 strPaso,
                                                                 strCodCentroGestor
                                                             );
        }

        public Boolean Formato_Requerimiento_DescarteFirma(string strNumRequerimiento,
                                                            string strCodMotivoDescarte,
                                                            DateTime dateFecDescarte,
                                                            string strMotivoDescarte
                                                          )
        {
            return objDs.Formato_Requerimiento_DescarteFirma(strNumRequerimiento,
                                                       strCodMotivoDescarte,
                                                       dateFecDescarte,
                                                       strMotivoDescarte
                                                          );
        }

        public Boolean Graba_Requerimiento_DescartePasePresupuestal(string strNumRequerimiento,
                                                    string strCodMotivoDescarte,
                                                    DateTime dateFecDescarte,
                                                    string strMotivoDescarte
                                                  )
        {
            return objDs.Graba_Requerimiento_DescartePasePresupuestal(strNumRequerimiento,
                                                    strCodMotivoDescarte,
                                                    dateFecDescarte,
                                                    strMotivoDescarte
                                                  );
        }

        public Boolean Formato_Requerimiento_Anulacion(string strNumRequerimiento,
                                                    string strCodMotivoDescarte,
                                                    DateTime dateFecDescarte,
                                                    string strMotivoDescarte
                                                  )
        {
            return objDs.Formato_Requerimiento_Anulacion( strNumRequerimiento,
                                                   strCodMotivoDescarte,
                                                   dateFecDescarte,
                                                   strMotivoDescarte
                                                  );
        }

        #endregion

        #region Requerimiento_Detalle_Bien
        public Model.Requerimiento_Detalle_Bien Recupera_Requerimiento_Detalle_Bien(int intIdRequrimiento_Detalle_Bien)
        {
            return objDs.Recupera_Requerimiento_Detalle_Bien(intIdRequrimiento_Detalle_Bien);
        }

        public int Graba_Requerimiento_Detalle_Bien(Model.Requerimiento_Detalle_Bien obj)
        {
            return objDs.Graba_Requerimiento_Detalle_Bien(obj);
        }

        public int Modifica_Requerimiento_Detalle_Bien(Model.Requerimiento_Detalle_Bien obj)
        {
            return objDs.Modifica_Requerimiento_Detalle_Bien(obj);
        }

        public int Elimina_Requerimiento_Detalle_Bien(int intIdRequerimiento_Detalle_Bien)
        {
            return objDs.Elimina_Requerimiento_Detalle_Bien(intIdRequerimiento_Detalle_Bien);
        }

        #endregion

        #region Requerimiento_Detalle_CoFinanciado
        public Model.Requerimiento_Detalle_CoFinanciado Recupera_Requerimiento_Detalle_CoFinanciado(string strNumRequerimiento)
        {
            return objDs.Recupera_Requerimiento_Detalle_CoFinanciado(strNumRequerimiento);
        }

        public int Graba_Requerimiento_Detalle_CoFinanciado(Model.Requerimiento_Detalle_CoFinanciado obj)
        {
            return objDs.Graba_Requerimiento_Detalle_CoFinanciado(obj);
        }

        public int Modifica_Requerimiento_Detalle_CoFinanciado(Model.Requerimiento_Detalle_CoFinanciado obj)
        {
            return objDs.Modifica_Requerimiento_Detalle_CoFinanciado(obj);
        }

        public int Elimina_Requerimiento_Detalle_CoFinanciado(string strNumRequerimiento)
        {
            return objDs.Elimina_Requerimiento_Detalle_CoFinanciado(strNumRequerimiento);
        }

        #endregion

        #region Requerimiento_Detalle_Cronograma
        public bool graba_Requerimiento_Detalle_Cronograma(Model.Requerimiento_Detalle_Cronograma obj)
        {
            return objDs.graba_Requerimiento_Detalle_Cronograma(obj);
        }

        public bool modifica_Requerimiento_Detalle_Cronograma(Model.Requerimiento_Detalle_Cronograma obj)
        {
            return objDs.modifica_Requerimiento_Detalle_Cronograma(obj);
        }
        public bool elimina_Requerimiento_Detalle_Cronograma(int intIdCronograma)
        {
            return objDs.elimina_Requerimiento_Detalle_Cronograma(intIdCronograma);
        }

        public Model.Requerimiento_Detalle_Cronograma recupera_Requerimiento_Detalle_Cronograma(int intIdRequerimiento_Detalle)
        {
            return objDs.recupera_Requerimiento_Detalle_Cronograma(intIdRequerimiento_Detalle);
        }

        public DataTable lista_Requerimiento_Detalle_Cronograma(int intIdRequerimiento_Detalle)
        {
            return objDs.lista_Requerimiento_Detalle_Cronograma(intIdRequerimiento_Detalle);
        }

        #endregion

        #region Requerimiento_Detalle_Servicio
        public Model.Requerimiento_Detalle_Servicio Recupera_Requerimiento_Detalle_Servicio(int intIdRequrimiento_Detalle_Servicio)
        {
            return objDs.Recupera_Requerimiento_Detalle_Servicio(intIdRequrimiento_Detalle_Servicio);
        }

        public int Graba_Requerimiento_Detalle_Servicio(Model.Requerimiento_Detalle_Servicio obj)
        {
            return objDs.Graba_Requerimiento_Detalle_Servicio(obj);
        }

        public int Modifica_Requerimiento_Detalle_Servicio(Model.Requerimiento_Detalle_Servicio obj)
        {
            return objDs.Modifica_Requerimiento_Detalle_Servicio(obj);
        }

        public int Elimina_Requerimiento_Detalle_Servicio(int intIdRequerimiento_Detalle_Servicio)
        {
            return objDs.Elimina_Requerimiento_Detalle_Servicio(intIdRequerimiento_Detalle_Servicio);
        }

        #endregion

        #region ReasignacionAPP
        public List<Model.Ajuste> GetReasignacion(string strNumAjuste)
        {
            return objDs.GetReasignacion(strNumAjuste);
        }

        public List<Model.Ajuste> GetListaReasignacion(string strCodCentroGestor)
        {
            return objDs.GetListaReasignacion(strCodCentroGestor);
        }

        private Model.Ajuste GetEmpDataTableRowAPP(DataRow dr)
        {
            return GetEmpDataTableRowAPP(dr);
        }

        #endregion

        #region Clasificacion
        public DataSet Ayuda_Clasificador(string strCodEmpresa)
        {
            return objDs.Ayuda_Clasificador(strCodEmpresa);
        }
        public DataSet Ayuda_TipoClasificador(string strCodEmpresa)
        {
            return objDs.Ayuda_TipoClasificador(strCodEmpresa);
        }
        public DataSet Ayuda_AgrupadorClasificador(string strCodEmpresa)
        {
            return objDs.Ayuda_AgrupadorClasificador(strCodEmpresa);
        }

        public DataSet Ayuda_Clasificacion_Formulacion(string strAñoProceso)
        {
            return objDs.Ayuda_Clasificacion_Formulacion(strAñoProceso);
        }

        #endregion

        #region PosicionPresupuestal_SAP
        public DataSet Lista_PosicionPresupuestal_SAP(string strCodCompañia)
        {
            return objDs.Lista_PosicionPresupuestal_SAP(strCodCompañia);
        }

        public DataSet Ayuda_PosicionPresupuestal_SAP(string strCodCompañia)
        {
            return objDs.Ayuda_PosicionPresupuestal_SAP(strCodCompañia);
        }


        public Model.PosicionPresupuestal_SAP Recupera_PosicionPresupuestal_SAP_Codigo(string strCodCompañia,
                                                                                string strCodPosPre
                                                                              )
        {
            return objDs.Recupera_PosicionPresupuestal_SAP_Codigo(strCodCompañia,
                                                                                strCodPosPre
                                                                              );
        }

        public Model.PosicionPresupuestal_SAP Recupera_PosicionPresupuestal_SAP(int intIdCodPosPre)
        {
            return objDs.Recupera_PosicionPresupuestal_SAP(intIdCodPosPre);
        }

        public int Graba_PosicionPresupuestal_SAP(Model.PosicionPresupuestal_SAP obj)
        {
            return objDs.Graba_PosicionPresupuestal_SAP(obj);
        }

        public int Modifica_PosicionPresupuestal_SAP(Model.PosicionPresupuestal_SAP obj)
        {
            return objDs.Modifica_PosicionPresupuestal_SAP(obj);
        }

        public bool Elimina_PosicionPresupuestal_SAP(int intIdPosPre)
        {
            return objDs.Elimina_PosicionPresupuestal_SAP(intIdPosPre);
        }

        #endregion

        #region PosicionPresupuestal
        public DataSet Lista_PosicionPresupuestal(string strCodCompañia)
        {
            return objDs.Lista_PosicionPresupuestal(strCodCompañia);
        }

        public DataSet Ayuda_PosicionPresupuestal_FuenteFinanciamiento(string strCodCompañia,
                                                                        string strCodFuenteFinanciamiento
                                                                      )
        {
            return objDs.Ayuda_PosicionPresupuestal_FuenteFinanciamiento(strCodCompañia,
                                                                    strCodFuenteFinanciamiento
                                                                      );
        }

        public DataSet Ayuda_PosicionPresupuestal(string strCodCompañia)
        {
            return objDs.Ayuda_PosicionPresupuestal(strCodCompañia);
        }

        public DataSet Ayuda_PosicionPresupuestal_HojaTrabajo(string strCodCompañia)
        {
            return objDs.Ayuda_PosicionPresupuestal_HojaTrabajo(strCodCompañia);
        }

        public DataSet Ayuda_PosicionPresupuestal_Formulacion_HojaTrabajo(string strCodCompañia,
                                                                         string strAñoProceso,
                                                                         string strPeriodo,
                                                                         string strCodCentroGestor,
                                                                         string strCodCentroCosto,
                                                                         string strCodTipoFormulacion,
                                                                         string strCodSubTipoFormulacion,
                                                                         bool blnManejaVariosCentroCosto
                                                                        )
        {
            return objDs.Ayuda_PosicionPresupuestal_Formulacion_HojaTrabajo(strCodCompañia,
                                                                           strAñoProceso,
                                                                           strPeriodo,
                                                                           strCodCentroGestor,
                                                                           strCodCentroCosto,
                                                                           strCodTipoFormulacion,
                                                                           strCodSubTipoFormulacion,
                                                                           blnManejaVariosCentroCosto
                                                                           );
        }

        public DataSet Ayuda_PosicionPresupuestal_Total(string strCodCompañia)
        {
            return objDs.Ayuda_PosicionPresupuestal_Total(strCodCompañia);
        }

        public DataSet Ayuda_Orden_Total(string strCodCompañia)
        {
            return objDs.Ayuda_Orden_Total(strCodCompañia);
        }



        public DataSet Ayuda_PosicionPresupuestal_Clasificador(string strCodCompañia,
                                                                string strCodClasificador,
                                                               string strCodFuenteFinanciamiento
                                                                )
        {
            return objDs.Ayuda_PosicionPresupuestal_Clasificador(strCodCompañia,
                                                           strCodClasificador,
                                                           strCodFuenteFinanciamiento
                                                                );
        }

        public DataSet Ayuda_PosicionPresupuestal_Formulacion(string strCodCompañia,
                                                              string strAñoProceso
                                                            )
        {
            return objDs.Ayuda_PosicionPresupuestal_Formulacion(strCodCompañia,
                                                          strAñoProceso
                                                            );
        }


        public Model.PosicionPresupuestal Recupera_PosicionPresupuestal_Codigo(string strCodCompañia,
                                                                                string strCodPosPre
                                                                              )
        {
            return objDs.Recupera_PosicionPresupuestal_Codigo(strCodCompañia,
                                                                                strCodPosPre
                                                                              );
        }

        public Model.PosicionPresupuestal Recupera_PosicionPresupuestal(int intIdCodPosPre)
        {
            return objDs.Recupera_PosicionPresupuestal(intIdCodPosPre);
        }

        public int Graba_PosicionPresupuestal(Model.PosicionPresupuestal obj)
        {
            return objDs.Graba_PosicionPresupuestal(obj);
        }

        public int Modifica_PosicionPresupuestal(Model.PosicionPresupuestal obj)
        {
            return objDs.Modifica_PosicionPresupuestal(obj);
        }

        public bool Elimina_PosicionPresupuestal(int intIdPosPre)
        {
            return objDs.Elimina_PosicionPresupuestal(intIdPosPre);
        }

        #endregion

        #region FuenteFinanciamiento
        public DataSet Ayuda_FuenteFinanciamiento_Reporte(string strCodEmpresa)
        {
            return objDs.Ayuda_FuenteFinanciamiento_Reporte(strCodEmpresa);
        }

        public DataSet Combo_FuenteFinanciamiento_Reporte(string strCodEmpresa)
        {
            return objDs.Combo_FuenteFinanciamiento_Reporte(strCodEmpresa);
        }

        public DataSet Ayuda_FuenteFinanciamiento_Proyecto( string strCodEmpresa, string strCodProyecto)
        {
            return objDs.Ayuda_FuenteFinanciamiento_Proyecto( strCodEmpresa, strCodProyecto);
        }

        public DataSet Ayuda_FuenteFinanciamiento_Proyecto_Reasignacion(string strCodEmpresa, string strCodProyecto)
        {
            return objDs.Ayuda_FuenteFinanciamiento_Proyecto_Reasignacion(strCodEmpresa, strCodProyecto);
        }

        public DataSet Ayuda_FuenteFinanciamiento()
        {
            return objDs.Ayuda_FuenteFinanciamiento();
        }

        public DataSet Combo_FuenteFinanciamiento()
        {
            return objDs.Combo_FuenteFinanciamiento();
        }

        public DataSet Combo_FuenteFinanciamiento_Pase()
        {
            return objDs.Combo_FuenteFinanciamiento_Pase();
        }

        public Model.FuenteFinanciamiento Recupera_FuenteFinanciamiento(int intIdFuenteFinanciamiento)
        {
            return objDs.Recupera_FuenteFinanciamiento(intIdFuenteFinanciamiento);
        }

        public Model.FuenteFinanciamiento Recupera_FuenteFinanciamiento_Codigo( string strCodEmpresa,
                                                                                string strCodFuenteFinanciamiento
                                                                            )
        {
            return objDs.Recupera_FuenteFinanciamiento_Codigo( strCodEmpresa, strCodFuenteFinanciamiento);
        }


        public int Graba_FuenteFinanciamiento(Model.FuenteFinanciamiento obj)
        {
            return objDs.Graba_FuenteFinanciamiento(obj);
        }

        public int Modifica_FuenteFinanciamiento(Model.FuenteFinanciamiento obj)
        {
            return objDs.Modifica_FuenteFinanciamiento(obj);
        }

        public DataSet Lista_FuenteFinanciamiento(string strCodEmpresa)
        {
            return objDs.Lista_FuenteFinanciamiento(strCodEmpresa);
        }

        public Boolean Elimina_FuenteFinanciamiento(int intIdFuenteFinanciamiento)
        {
            return objDs.Elimina_FuenteFinanciamiento(intIdFuenteFinanciamiento);
        }

        #endregion

        #region Familia_PosicionPresupustal
        public DataSet Combo_FamiliaPosicionPresupuestal()
        {
            return objDs.Combo_FamiliaPosicionPresupuestal();
        }

        public DataSet Ayuda_FamiliaPosicionPresupuestal()
        {
            return objDs.Ayuda_FamiliaPosicionPresupuestal();
        }

        public Model.FamiliaPosicionPresupuestal Recupera_FamiliaPosicionPresupuestal(int intIdFamiliaPosicionPresupuestal)
        {
            return objDs.Recupera_FamiliaPosicionPresupuestal(intIdFamiliaPosicionPresupuestal);
        }


        public Model.FamiliaPosicionPresupuestal Recupera_FamiliaPosicionPresupuestal_Codigo(string strCodFamiliaPosicionPresupuestal)
        {
            return objDs.Recupera_FamiliaPosicionPresupuestal_Codigo(strCodFamiliaPosicionPresupuestal);
        }

        public int Graba_FamiliaPosicionPresupuestal(Model.FamiliaPosicionPresupuestal obj)
        {
            return objDs.Graba_FamiliaPosicionPresupuestal(obj);
        }

        public int Modifica_FamiliaPosicionPresupuestal(Model.FamiliaPosicionPresupuestal obj)
        {
            return objDs.Modifica_FamiliaPosicionPresupuestal(obj);
        }

        public bool Elimina_FamiliaPosicionPresupuestal(int intIdFamiliaPosicionPresupuestal)
        {
            return objDs.Elimina_FamiliaPosicionPresupuestal(intIdFamiliaPosicionPresupuestal);
        }

        public DataSet Lista_FamiliaPosicionPresupuestal()
        {
            return objDs.Lista_FamiliaPosicionPresupuestal();
        }

        #endregion

        #region LineaPosicionPresupuestal
        public DataSet Combo_LineaPosicionPresupuestal(string strCodFamiliaPosicionPresupuestal)
        {
            return objDs.Combo_LineaPosicionPresupuestal(strCodFamiliaPosicionPresupuestal);
        }

        public DataSet Ayuda_LineaPosicionPresupuestal(string strCodFamiliaPosicionPresupuestal)
        {
            return objDs.Ayuda_LineaPosicionPresupuestal(strCodFamiliaPosicionPresupuestal);
        }

        public Model.LineaPosicionPresupuestal Recupera_LineaPosicionPresupuestal(int intIdLineaPosicionPresupuestal)
        {
            return objDs.Recupera_LineaPosicionPresupuestal(intIdLineaPosicionPresupuestal);
        }


        public Model.LineaPosicionPresupuestal Recupera_LineaPosicionPresupuestal_Codigo(string strCodLineaPosicionPresupuestal)
        {
            return objDs.Recupera_LineaPosicionPresupuestal_Codigo(strCodLineaPosicionPresupuestal);
        }

        public int Graba_LineaPosicionPresupuestal(Model.LineaPosicionPresupuestal obj)
        {
            return objDs.Graba_LineaPosicionPresupuestal(obj);
        }

        public int Modifica_LineaPosicionPresupuestal(Model.LineaPosicionPresupuestal obj)
        {
            return objDs.Modifica_LineaPosicionPresupuestal(obj);
        }

        public bool Elimina_LineaPosicionPresupuestal(int intIdLineaPosicionPresupuestal)
        {
            return objDs.Elimina_LineaPosicionPresupuestal(intIdLineaPosicionPresupuestal);
        }

        public DataSet Lista_LineaPosicionPresupuestal(string strCodFamiliaPosicionPresupuestal)
        {
            return objDs.Lista_LineaPosicionPresupuestal(strCodFamiliaPosicionPresupuestal);
        }

        #endregion

        #region TipoClasificador
        public DataSet Combo_TipoClasificador()
        {
            return objDs.Combo_TipoClasificador();
        }
        #endregion

        #region TopePresupuestal
        public Double Recupera_TopePresupuestal_Saldo(Model.TopePresupuestal obj
                                                              )
        {
            return objDs.Recupera_TopePresupuestal_Saldo(obj  );
        }

        public Model.TopePresupuestal Recupera_TopePresupuestal(int intIdTopePresupuestal)
        {
            return objDs.Recupera_TopePresupuestal(intIdTopePresupuestal);
        }

        public int Graba_TopePresupuestal(Model.TopePresupuestal obj)
        {
            return objDs.Graba_TopePresupuestal(obj);
        }

        public int Modifica_TopePresupuestal(Model.TopePresupuestal obj)
        {
            return objDs.Modifica_TopePresupuestal(obj);
        }

        public bool Elimina_TopePresupuestal(int intidTopePresupuestal)
        {
            return objDs.Elimina_TopePresupuestal(intidTopePresupuestal);
        }


        public DataSet Lista_TopePresupuestal(string strCodEmpresa, string strAñoProceso, string strVersion)
        {
            return objDs.Lista_TopePresupuestal(strCodEmpresa, strAñoProceso, strVersion);
        }

        #endregion

        #region Empleado_CentroGestor
        public DataSet Arbol_Empleado()
        {
            return objDs.Arbol_Empleado();
        }
        public int Graba_Empleado_CentroGestor(int iCodEmpleado, string strCodCege)
        {
            return objDs.Graba_Empleado_CentroGestor(iCodEmpleado, strCodCege);
        }

        public int Modifica_Empleado_CentroGestor(int iCodEmpleado, string strCodCege)
        {
            return objDs.Modifica_Empleado_CentroGestor(iCodEmpleado, strCodCege);
        }

        public DataSet Recupera_Empleado_CentroGestor(int iCodEmpleado)
        {
            return objDs.Recupera_Empleado_CentroGestor(iCodEmpleado);
        }

        #endregion

        #region Reporte
        public DataSet Lista_Formulacion_ResumenClasificador_Gasto(string strCodCompañia,
                                                          string strAñoProceso,
                                                          string strVersion,
                                                          string strCodFuenteFinanciamiento,
                                                          string strCodCentroGestor,
                                                          string strCodProyecto,
                                                          int intTipoAgrupacion
                                                        )
        {
            return objDs.Lista_Formulacion_ResumenClasificador_Gasto(strCodCompañia,
                                                          strAñoProceso,
                                                          strVersion,
                                                          strCodFuenteFinanciamiento,
                                                          strCodCentroGestor,
                                                          strCodProyecto,
                                                          intTipoAgrupacion
                                                        );
        }

        public DataSet Lista_Formulacion_HojaTrabajo_Gasto(string strCodCompañia,
                                                                  string strAñoProceso,
                                                                  string strVersion,
                                                                  string strCodFuenteFinanciamiento,
                                                                  string strCodCentroGestor,
                                                                  string strCodProyecto,
                                                                  int intTipoAgrupacion
                                                                )
        {
            return objDs.Lista_Formulacion_HojaTrabajo_Gasto(strCodCompañia,
                                                       strAñoProceso,
                                                       strVersion,
                                                       strCodFuenteFinanciamiento,
                                                       strCodCentroGestor,
                                                       strCodProyecto,
                                                       intTipoAgrupacion
                                                                );
        }

        public DataSet Lista_Formulacion_ResumenClasificador_Ingreso(string strCodCompañia,
                                                                  string strAñoProceso,
                                                                  string strVersion,
                                                                  string strCodFuenteFinanciamiento,
                                                                  string strCodCentroGestor,
                                                                  string strCodProyecto,
                                                                  int intTipoAgrupacion
                                                                )
        {
            return objDs.Lista_Formulacion_ResumenClasificador_Ingreso( strCodCompañia,
                                                                  strAñoProceso,
                                                                  strVersion,
                                                                  strCodFuenteFinanciamiento,
                                                                  strCodCentroGestor,
                                                                 strCodProyecto,
                                                                 intTipoAgrupacion
                                                                );
        }

        public DataSet Lista_Formulacion_HojaTrabajo_Ingreso(string strCodCompañia,
                                                          string strAñoProceso,
                                                          string strVersion,
                                                          string strCodFuenteFinanciamiento,
                                                          string strCodCentroGestor,
                                                          string strCodProyecto,
                                                          int intTipoAgrupacion
                                                        )
        {
            return objDs.Lista_Formulacion_HojaTrabajo_Ingreso(strCodCompañia,
                                                         strAñoProceso,
                                                         strVersion,
                                                         strCodFuenteFinanciamiento,
                                                         strCodCentroGestor,
                                                         strCodProyecto,
                                                         intTipoAgrupacion
                                                        );
        }


        public DataSet Lista_FormulacionReporteProyecto(string cCodCompañia, string strAñoProceso, string strVersion, string cCodTipoFormulacion, string cCodProyecto)
        {
            return objDs.Lista_FormulacionReporteProyecto(cCodCompañia, strAñoProceso, strVersion, cCodTipoFormulacion, cCodProyecto);
        }

        public DataSet Lista_FormulacionReporteProyecto_CentroGestor(string cCodCompañia,
                                                                    string cCodTipoFormulacion,
                                                                    string cCodProyecto,
                                                                    string cCodCentroGestor_Gestor
            )
        {
            return objDs.Lista_FormulacionReporteProyecto_CentroGestor( cCodCompañia,
                                                                  cCodTipoFormulacion,
                                                                   cCodProyecto,
                                                                   cCodCentroGestor_Gestor
                                                                );
        }


        public DataSet Lista_FormulacionReporteContrato(string cCodCompañia, string cNumeroOrden, string cTipoOrden)
        {
            return objDs.Lista_FormulacionReporteContrato(cCodCompañia, cNumeroOrden, cTipoOrden);
        }


        public DataSet Help_FormulacionTipoFormulacion()
        {
            return objDs.Help_FormulacionTipoFormulacion();
        }

        public DataSet Lista_FormulacionReporteProyecto_Cege(string cCodCompañia, string strAñoProceso, string strVersion, string cCodTipoFormulacion, string CodCentroGestor)
        {
            return objDs.Lista_FormulacionReporteProyecto_Cege(cCodCompañia, strAñoProceso, strVersion, cCodTipoFormulacion, CodCentroGestor);
        }

        public DataSet Formato_4P(string strCodCompañia,
                                  string strAñoProceso,
                                  string strVersion,
                                  string strCodFuenteFinanciamiento,
                                  string strCodCentroGestor,
                                  string strCodProyecto
                                )
        {
            return objDs.Formato_4P(strCodCompañia,
                              strAñoProceso,
                              strVersion,
                              strCodFuenteFinanciamiento,
                              strCodCentroGestor,
                              strCodProyecto
                                );
        }

        public DataSet Formato_4E(string strCodCompañia,
                                  string strAñoProceso,
                                  string strCodFuenteFinanciamiento,
                                  string strCodCentroGestor,
                                  string strCodProyecto
                                )
        {
            return objDs.Formato_4E( strCodCompañia,
                               strAñoProceso,
                               strCodFuenteFinanciamiento,
                               strCodCentroGestor,
                               strCodProyecto
                                );
        }

        public DataSet Reporte_Detalle_Formulacion(string strCodCompañia,
                                  string strAñoProceso,
                                  string strVersion,
                                  string strCodFuenteFinanciamiento,
                                  string strCodCentroGestor,
                                  string strCodProyecto
                                )
        {
            return objDs.Reporte_Detalle_Formulacion(strCodCompañia,
                                   strAñoProceso,
                                   strVersion,
                                   strCodFuenteFinanciamiento,
                                   strCodCentroGestor,
                                   strCodProyecto
                                );
        }

        public DataSet Lista_FormulacionReporteProyecto_Saldo(string cCodCompañia)
        {
            return objDs.Lista_FormulacionReporteProyecto_Saldo(cCodCompañia);
        }

        public DataSet Reporte_ResumenGasto(string strCodCompañia,
                                            string strPeriodoInicial,
                                            string strPeriodoFinal,
                                            int intTipoReporte
                                            )
        {
            return objDs.Reporte_ResumenGasto(strCodCompañia,
                                            strPeriodoInicial,
                                            strPeriodoFinal,
                                            intTipoReporte
                                            );
        }

        #endregion

        #endregion

        #region PROYECTO
        #region CadenaFuncionalProyecto
        public DataSet Ayuda_CadenaFuncionalProyecto()
        {
            return objDs.Ayuda_CadenaFuncionalProyecto();
        }
        public DataSet Lista_CadenaFuncionalProyecto()
        {
            return objDs.Lista_CadenaFuncionalProyecto();
        }

        public DataSet Combo_CadenaFuncionalProyecto_Reporte()
        {
            return objDs.Combo_CadenaFuncionalProyecto_Reporte();
        }

        public DataSet Combo_CadenaFuncionalProyecto()
        {
            return objDs.Combo_CadenaFuncionalProyecto();
        }

        public DataSet Combo_SituacionActualProyecto()
        {
            return objDs.Combo_SituacionActualProyecto();
        }
        public Model.CadenaFuncionalProyecto Recupera_CadenaFuncionalProyecto(int intIdCadenaFuncionalProyecto)
        {
            return objDs.Recupera_CadenaFuncionalProyecto(intIdCadenaFuncionalProyecto);
        }

        public Model.CadenaFuncionalProyecto Recupera_CadenaFuncionalProyecto_codigo(string strCodCadenaFuncionalProyecto)
        {
            return objDs.Recupera_CadenaFuncionalProyecto_codigo(strCodCadenaFuncionalProyecto);
        }
        public int Graba_CadenaFuncionalProyecto(Model.CadenaFuncionalProyecto obj)
        {
            return objDs.Graba_CadenaFuncionalProyecto(obj);
        }
        public int Modifica_CadenaFuncionalProyecto(Model.CadenaFuncionalProyecto obj)
        {
            return objDs.Modifica_CadenaFuncionalProyecto(obj);
        }

        public bool Elimina_CadenaFuncionalProyecto(int intIdCadenaFuncionalProyecto)
        {
            return objDs.Elimina_CadenaFuncionalProyecto(intIdCadenaFuncionalProyecto);
        }

        #endregion

        #region ClaseProyecto
        public DataSet Ayuda_ClaseProyecto()
        {
            return objDs.Ayuda_ClaseProyecto();
        }
        public DataSet Lista_ClaseProyecto()
        {
            return objDs.Lista_ClaseProyecto();
        }

        public DataSet Naturaleza_ClaseProyecto()
        {
            return objDs.Naturaleza_ClaseProyecto();
        }

        public DataSet Combo_ClaseProyecto_Reporte()
        {
            return objDs.Combo_ClaseProyecto_Reporte();
        }

        public DataSet Combo_ClaseProyecto()
        {
            return objDs.Combo_ClaseProyecto();
        }
        public Model.ClaseProyecto Recupera_ClaseProyecto(int intIdClaseProyecto)
        {
            return objDs.Recupera_ClaseProyecto(intIdClaseProyecto);
        }

        public Model.ClaseProyecto Recupera_ClaseProyecto_codigo(string strCodClaseProyecto)
        {
            return objDs.Recupera_ClaseProyecto_codigo(strCodClaseProyecto);
        }
        public int Graba_ClaseProyecto(Model.ClaseProyecto obj)
        {
            return objDs.Graba_ClaseProyecto(obj);
        }
        public int Modifica_ClaseProyecto(Model.ClaseProyecto obj)
        {
            return objDs.Modifica_ClaseProyecto(obj);
        }

        public bool Elimina_ClaseProyecto(int intIdClaseProyecto)
        {
            return objDs.Elimina_ClaseProyecto(intIdClaseProyecto);
        }
        #endregion

        #region EstadoProyecto
        public DataSet Ayuda_EstadoProyecto()
        {
            return objDs.Ayuda_EstadoProyecto();
        }

        public DataSet Lista_EstadoProyecto()
        {
            return objDs.Lista_EstadoProyecto();
        }

        public DataSet Combo_EstadoProyecto_Reporte()
        {
            return objDs.Combo_EstadoProyecto_Reporte();
        }

        public DataSet Combo_EstadoProyecto()
        {
            return objDs.Combo_EstadoProyecto();
        }
        public Model.EstadoProyecto Recupera_EstadoProyecto(int intIdEstadoProyecto)
        {
            return objDs.Recupera_EstadoProyecto(intIdEstadoProyecto);
        }

        public Model.EstadoProyecto Recupera_EstadoProyecto_codigo(string strCodEstadoProyecto)
        {
            return objDs.Recupera_EstadoProyecto_codigo(strCodEstadoProyecto);
        }
        public int Graba_EstadoProyecto(Model.EstadoProyecto obj)
        {
            return objDs.Graba_EstadoProyecto(obj);
        }
        public int Modifica_EstadoProyecto(Model.EstadoProyecto obj)
        {
            return objDs.Modifica_EstadoProyecto(obj);
        }

        public bool Elimina_EstadoProyecto(int intIdEstadoProyecto)
        {
            return objDs.Elimina_EstadoProyecto(intIdEstadoProyecto);
        }

        #endregion

        #region EtapaProyecto
        public DataSet Lista_EtapaProyecto()
        {
            return objDs.Lista_EtapaProyecto();
        }

        public DataSet Ayuda_EtapaProyecto()
        {
            return objDs.Ayuda_EtapaProyecto();
        }

        public DataSet Combo_EtapaProyecto_Reporte()
        {
            return objDs.Combo_EtapaProyecto_Reporte();
        }

        public DataSet Combo_EtapaProyecto()
        {
            return objDs.Combo_EtapaProyecto();
        }
        public Model.EtapaProyecto Recupera_EtapaProyecto(int intIdEtapaProyecto)
        {
            return objDs.Recupera_EtapaProyecto(intIdEtapaProyecto);
        }

        public Model.EtapaProyecto Recupera_EtapaProyecto_codigo(string strCodEtapaProyecto)
        {
            return objDs.Recupera_EtapaProyecto_codigo(strCodEtapaProyecto);
        }
        public int Graba_EtapaProyecto(Model.EtapaProyecto obj)
        {
            return objDs.Graba_EtapaProyecto(obj);
        }
        public int Modifica_EtapaProyecto(Model.EtapaProyecto obj)
        {
            return objDs.Modifica_EtapaProyecto(obj);
        }

        public bool Elimina_EtapaProyecto(int intIdEtapaProyecto)
        {
            return objDs.Elimina_EtapaProyecto(intIdEtapaProyecto);
        }

        #endregion

        #region Fase_ActividadProyecto
        public DataSet Lista_Fase_ActividadProyecto()
        {
            return objDs.Lista_Fase_ActividadProyecto();
        }

        public DataSet Lista_Fase_ActividadProyecto_Clase(string strCodClaseProyecto)
        {
            return objDs.Lista_Fase_ActividadProyecto_Clase(strCodClaseProyecto);
        }

        public DataSet Ayuda_Fase_ActividadProyecto()
        {
            return objDs.Ayuda_Fase_ActividadProyecto();
        }

        public DataSet Combo_Fase_ActividadProyecto_Reporte()
        {
            return objDs.Combo_Fase_ActividadProyecto_Reporte();
        }

        public DataSet Combo_Fase_ActividadProyecto()
        {
            return objDs.Combo_Fase_ActividadProyecto();
        }
        public Model.Fase_ActividadProyecto Recupera_Fase_ActividadProyecto(int intIdFase_ActividadProyecto)
        {
            return objDs.Recupera_Fase_ActividadProyecto(intIdFase_ActividadProyecto);
        }

        public Model.Fase_ActividadProyecto Recupera_Fase_ActividadProyecto_codigo(string strCodFase_ActividadProyecto)
        {
            return objDs.Recupera_Fase_ActividadProyecto_codigo(strCodFase_ActividadProyecto);
        }
        public int Graba_Fase_ActividadProyecto(Model.Fase_ActividadProyecto obj)
        {
            return objDs.Graba_Fase_ActividadProyecto(obj);
        }
        public int Modifica_Fase_ActividadProyecto(Model.Fase_ActividadProyecto obj)
        {
            return objDs.Modifica_Fase_ActividadProyecto(obj);
        }

        public bool Elimina_Fase_ActividadProyecto(int intIdFase_ActividadProyecto)
        {
            return objDs.Elimina_Fase_ActividadProyecto(intIdFase_ActividadProyecto);
        }

        #endregion

        #region GrupoClaseProyecto
        public DataSet Ayuda_GrupoClaseProyecto()
        {
            return objDs.Ayuda_GrupoClaseProyecto();
        }
        public DataSet Lista_GrupoClaseProyecto()
        {
            return objDs.Lista_GrupoClaseProyecto();
        }

        public DataSet GrupoClase_GrupoClaseProyecto()
        {
            return objDs.GrupoClase_GrupoClaseProyecto();
        }

        public DataSet Combo_GrupoClaseProyecto_Reporte()
        {
            return objDs.Combo_GrupoClaseProyecto_Reporte();
        }

        public DataSet Combo_GrupoClaseProyecto()
        {
            return objDs.Combo_GrupoClaseProyecto();
        }
        public Model.GrupoClaseProyecto Recupera_GrupoClaseProyecto(int intIdGrupoClaseProyecto)
        {
            return objDs.Recupera_GrupoClaseProyecto(intIdGrupoClaseProyecto);
        }

        public Model.GrupoClaseProyecto Recupera_GrupoClaseProyecto_codigo(string strCodGrupoClaseProyecto)
        {
            return objDs.Recupera_GrupoClaseProyecto_codigo(strCodGrupoClaseProyecto);
        }
        public int Graba_GrupoClaseProyecto(Model.GrupoClaseProyecto obj)
        {
            return objDs.Graba_GrupoClaseProyecto(obj);
        }
        public int Modifica_GrupoClaseProyecto(Model.GrupoClaseProyecto obj)
        {
            return objDs.Modifica_GrupoClaseProyecto(obj);
        }

        public bool Elimina_GrupoClaseProyecto(int intIdGrupoClaseProyecto)
        {
            return objDs.Elimina_GrupoClaseProyecto(intIdGrupoClaseProyecto);
        }

        #endregion

        #region GrupoProyecto
        public DataSet Lista_GrupoProyecto()
        {
            return objDs.Lista_GrupoProyecto();
        }

        public DataSet Ayuda_GrupoProyecto()
        {
            return objDs.Ayuda_GrupoProyecto();
        }

        public DataSet Combo_GrupoProyecto_Reporte()
        {
            return objDs.Combo_GrupoProyecto_Reporte();
        }

        public DataSet Combo_GrupoProyecto()
        {
            return objDs.Combo_GrupoProyecto();
        }
        public Model.GrupoProyecto Recupera_GrupoProyecto(int intIdGrupoProyecto)
        {
            return objDs.Recupera_GrupoProyecto(intIdGrupoProyecto);
        }

        public Model.GrupoProyecto Recupera_GrupoProyecto_codigo(string strCodGrupoProyecto)
        {
            return objDs.Recupera_GrupoProyecto_codigo(strCodGrupoProyecto);
        }
        public int Graba_GrupoProyecto(Model.GrupoProyecto obj)
        {
            return objDs.Graba_GrupoProyecto(obj);
        }
        public int Modifica_GrupoProyecto(Model.GrupoProyecto obj)
        {
            return objDs.Modifica_GrupoProyecto(obj);
        }

        public bool Elimina_GrupoProyecto(int intIdGrupoProyecto)
        {
            return objDs.Elimina_GrupoProyecto(intIdGrupoProyecto);
        }

        #endregion

        #region MacroProyecto
        public DataSet Lista_MacroProyecto()
        {
            return objDs.Lista_MacroProyecto();
        }

        public DataSet Ayuda_MacroProyecto()
        {
            return objDs.Ayuda_MacroProyecto();
        }


        public DataSet Combo_MacroProyecto_Reporte()
        {
            return objDs.Combo_MacroProyecto_Reporte();
        }

        public DataSet Combo_MacroProyecto()
        {
            return objDs.Combo_MacroProyecto();
        }
        public Model.MacroProyecto Recupera_MacroProyecto(int intIdMacroProyecto)
        {
            return objDs.Recupera_MacroProyecto(intIdMacroProyecto);
        }

        public Model.MacroProyecto Recupera_MacroProyecto_codigo(string strCodMacroProyecto)
        {
            return objDs.Recupera_MacroProyecto_codigo(strCodMacroProyecto);
        }
        public int Graba_MacroProyecto(Model.MacroProyecto obj)
        {
            return objDs.Graba_MacroProyecto(obj);
        }
        public int Modifica_MacroProyecto(Model.MacroProyecto obj)
        {
            return objDs.Modifica_MacroProyecto(obj);
        }

        public bool Elimina_MacroProyecto(int intIdMacroProyecto)
        {
            return objDs.Elimina_MacroProyecto(intIdMacroProyecto);
        }

        #endregion

        #region NaturalezaProyecto
        public DataSet Ayuda_NaturalezaProyecto()
        {
            return objDs.Ayuda_NaturalezaProyecto();
        }
        public DataSet Lista_NaturalezaProyecto()
        {
            return objDs.Lista_NaturalezaProyecto();
        }

        public DataSet Naturaleza_NaturalezaProyecto()
        {
            return objDs.Naturaleza_NaturalezaProyecto();
        }

        public DataSet Combo_NaturalezaProyecto_Reporte()
        {
            return objDs.Combo_NaturalezaProyecto_Reporte();
        }

        public DataSet Combo_NaturalezaProyecto()
        {
            return objDs.Combo_NaturalezaProyecto();
        }
        public Model.NaturalezaProyecto Recupera_NaturalezaProyecto(int intIdNaturalezaProyecto)
        {
            return objDs.Recupera_NaturalezaProyecto(intIdNaturalezaProyecto);
        }

        public Model.NaturalezaProyecto Recupera_NaturalezaProyecto_codigo(string strCodNaturalezaProyecto)
        {
            return objDs.Recupera_NaturalezaProyecto_codigo(strCodNaturalezaProyecto);
        }
        public int Graba_NaturalezaProyecto(Model.NaturalezaProyecto obj)
        {
            return objDs.Graba_NaturalezaProyecto(obj);
        }
        public int Modifica_NaturalezaProyecto(Model.NaturalezaProyecto obj)
        {
            return objDs.Modifica_NaturalezaProyecto(obj);
        }

        public bool Elimina_NaturalezaProyecto(int intIdNaturalezaProyecto)
        {
            return objDs.Elimina_NaturalezaProyecto(intIdNaturalezaProyecto);
        }

        #endregion

        #region Proyecto
        public bool Graba_SolicitudViatico_Proyecto( string strCodSolicitud,
                                                string strCodProyecto
                                               )
        {
            return objDs.Graba_SolicitudViatico_Proyecto(  strCodSolicitud,
                                                           strCodProyecto
                                    );
        }
        public DataSet Ayuda_Proyecto_Componente_Spring(string strCodCompañia,
                                        string strCodProyecto
                                    )
        {
            return objDs.Ayuda_Proyecto_Componente_Spring(strCodCompañia,
                                        strCodProyecto
                                    );
        }

        public DataSet Ayuda_Proyecto_Componente(string strCodCompañia,
                                                 string strAñoProceso,
                                                string strCodProyecto
                                            )
        {
            return objDs.Ayuda_Proyecto_Componente( strCodCompañia,
                                              strAñoProceso,
                                              strCodProyecto
                                            );
        }

        public DataSet Ayuda_Proyecto_Componente_Servicio(string strCodCompañia)
        {
            return objDs.Ayuda_Proyecto_Componente_Servicio(strCodCompañia);
        }

        public DataSet Ayuda_Proyecto_Componente_Todos(string strCodCompañia)
        {
            return objDs.Ayuda_Proyecto_Componente_Todos(strCodCompañia);
        }


        public DataSet Graba_Proyecto_OrdenTemporal(string strCodEmpleado,
                                                    string strTipoOrden,
                                                    string strNumeroOrden
                                                  )
        {
            return objDs.Graba_Proyecto_OrdenTemporal(strCodEmpleado,
                                                 strTipoOrden,
                                                 strNumeroOrden
                                                  );
        }

        public DataSet Elimina_Proyecto_OrdenTemporal(string strCodEmpleado,
                                                    string strTipoOrden,
                                                    string strNumeroOrden
                                                  )
        {
            return objDs.Elimina_Proyecto_OrdenTemporal( strCodEmpleado,
                                                   strTipoOrden,
                                                   strNumeroOrden
                                                  );
        }
        public DataSet Ayuda_Proyecto_CentroGestor(string strCodCentroGestor, int intDigito, string strCodEmpleado)
        {
            return objDs.Ayuda_Proyecto_CentroGestor(strCodCentroGestor, intDigito, strCodEmpleado);
        }


        public DataSet Ayuda_Proyecto_Reporte(string strCodFuenteFinanciamiento,
                                              string strCodCentroGestor
                                             )
        {
            return objDs.Ayuda_Proyecto_Reporte( strCodFuenteFinanciamiento,
                                           strCodCentroGestor
                                             );
        }


        public DataSet Lista_Proyecto(string strCodEmpresa,
                                      int intTipoProyecto
                                     )
        {
            return objDs.Lista_Proyecto( strCodEmpresa,
                                    intTipoProyecto
                                     );
        }

        public DataSet Ayuda_Proyecto(string strCodEmpresa,
                                      int intTipoProyecto
            )
        {
            return objDs.Ayuda_Proyecto(strCodEmpresa,
                                   intTipoProyecto
                                    );
        }

        public DataSet Ayuda_Proyecto_FuenteFinanciamiento(string strCodEmpresa,
                                                    string strCodProyecto
                                )
        {
            return objDs.Ayuda_Proyecto_FuenteFinanciamiento(strCodEmpresa,
                                                     strCodProyecto
                                );
        }

        public DataSet Ayuda_Proyecto_FuenteFinanciamiento_Reasignacion(string strCodEmpresa,
                                                    string strCodProyecto
                                )
        {
            return objDs.Ayuda_Proyecto_FuenteFinanciamiento_Reasignacion(strCodEmpresa,
                                                     strCodProyecto
                                );
        }

        public DataSet Ayuda_Proyecto_y_FuenteFinanciamiento(string strCodEmpresa,
                                      int intTipoProyecto
            )
        {
            return objDs.Ayuda_Proyecto_y_FuenteFinanciamiento(strCodEmpresa,
                                                        intTipoProyecto
                                                            );
        }

        public DataSet Combo_Proyecto_Reporte(string strCodEmpresa,
                                              int intTipoProyecto
                                             )
        {
            return objDs.Combo_Proyecto_Reporte(strCodEmpresa,
                                          intTipoProyecto
                                             );
        }

        public DataSet Combo_Proyecto(string strCodEmpresa, int intTipoProyecto)
        {
            return objDs.Combo_Proyecto(strCodEmpresa, intTipoProyecto);
        }
        public Model.Proyecto Recupera_Proyecto( string strCodEmpresa,
                                                 string strCodProyecto
                                               )
        {
            return objDs.Recupera_Proyecto(strCodEmpresa, strCodProyecto);
        }

        public Model.Proyecto Recupera_Proyecto_codigo(int intTipoProyecto,
                                                        string strCodGrupoProyecto,
                                                        string strCodProyecto
                                                      )
        {
            return objDs.Recupera_Proyecto_codigo(intTipoProyecto,
                                            strCodGrupoProyecto,
                                            strCodProyecto
                                                      );
        }
        public Model.Proyecto Graba_Proyecto(Model.Proyecto obj,
                                        string strAñoProceso,
                                        string strPeriodo,
                                        string strCodCentroCosto,
                                        bool LLamadaDesdeHojaTrabajo)
        {
            return objDs.Graba_Proyecto(obj,
                                        strAñoProceso,
                                        strPeriodo,
                                        strCodCentroCosto,
                                        LLamadaDesdeHojaTrabajo);
        }
        public Model.Proyecto Modifica_Proyecto(Model.Proyecto obj)
        {
            return objDs.Modifica_Proyecto(obj);
        }

        public int Elimina_Proyecto(int Id)
        {
            return objDs.Elimina_Proyecto(Id);
        }

        #endregion

        

        #region Proyecto_CentroCosto
        public DataSet Lista_Proyecto_CentroCosto(int intIdProyecto)
        {
            return objDs.Lista_Proyecto_CentroCosto(intIdProyecto);
        }

        public int Graba_Proyecto_CentroCosto(Model.Proyecto_CentroCosto obj)
        {
            return objDs.Graba_Proyecto_CentroCosto(obj);
        }
        public int Modifica_Proyecto_CentroCosto(Model.Proyecto_CentroCosto obj)
        {
            return objDs.Modifica_Proyecto_CentroCosto(obj);
        }

        public bool Elimina_Proyecto_CentroCosto(int intIdProyecto_CentroCosto)
        {
            return objDs.Elimina_Proyecto_CentroCosto(intIdProyecto_CentroCosto);
        }

        #endregion

        #region Proyecto_Etapa
        public Model.Proyecto_Etapa Recupera_Proyecto_Etapa(int intIdProyecto_Etapa)
        {
            return objDs.Recupera_Proyecto_Etapa(intIdProyecto_Etapa);
        }

        public int Graba_Proyecto_Etapa(Model.Proyecto_Etapa obj)
        {
            return objDs.Graba_Proyecto_Etapa(obj);
        }
        public int Modifica_Proyecto_Etapa(Model.Proyecto_Etapa obj)
        {
            return objDs.Modifica_Proyecto_Etapa(obj);
        }

        public bool Elimina_Proyecto_Etapa(int intIdProyecto_Etapa)
        {
            return objDs.Elimina_Proyecto_Etapa(intIdProyecto_Etapa);
        }

        public DataSet Lista_Proyecto_Etapa(int intIdProyecto)
        {
            return objDs.Lista_Proyecto_Etapa(intIdProyecto);
        }

        #endregion

        #region Proyecto_Etapa_Actividad
        public DataSet Lista_Proyecto_Etapa_Actividad(int intIdProyecto_Etapa)
        {
            return objDs.Lista_Proyecto_Etapa_Actividad(intIdProyecto_Etapa);
        }

        public Model.Proyecto_Etapa_Actividad Recupera_Proyecto_Etapa_Actividad(int intIdProyecto_Etapa_Actividad)
        {
            return objDs.Recupera_Proyecto_Etapa_Actividad(intIdProyecto_Etapa_Actividad);
        }

        public int Graba_Proyecto_Etapa_Actividad(Model.Proyecto_Etapa_Actividad obj)
        {
            return objDs.Graba_Proyecto_Etapa_Actividad(obj);
        }
        public int Modifica_Proyecto_Etapa_Actividad(Model.Proyecto_Etapa_Actividad obj)
        {
            return objDs.Modifica_Proyecto_Etapa_Actividad(obj);
        }

        public bool Elimina_Proyecto_Etapa_Actividad(int intIdProyecto_Etapa_Actividad)
        {
            return objDs.Elimina_Proyecto_Etapa_Actividad(intIdProyecto_Etapa_Actividad);
        }

        #endregion

        #region Proyecto_Etapa_CostoFijo
        public DataSet Lista_Proyecto_Etapa_CostoFijo(int intIdProyecto_Etapa)
        {
            return objDs.Lista_Proyecto_Etapa_CostoFijo(intIdProyecto_Etapa);
        }

        public Model.Proyecto_Etapa_CostoFijo Recupera_Proyecto_Etapa_CostoFijo(int intIdProyecto_Etapa_CostoFijo)
        {
            return objDs.Recupera_Proyecto_Etapa_CostoFijo(intIdProyecto_Etapa_CostoFijo);
        }

        public int Graba_Proyecto_Etapa_CostoFijo(Model.Proyecto_Etapa_CostoFijo obj)
        {
            return objDs.Graba_Proyecto_Etapa_CostoFijo(obj);
        }
        public int Modifica_Proyecto_Etapa_CostoFijo(Model.Proyecto_Etapa_CostoFijo obj)
        {
            return objDs.Modifica_Proyecto_Etapa_CostoFijo(obj);
        }

        public bool Elimina_Proyecto_Etapa_CostoFijo(int intIdProyecto_Etapa_CostoFijo)
        {
            return objDs.Elimina_Proyecto_Etapa_CostoFijo(intIdProyecto_Etapa_CostoFijo);
        }

        #endregion

        #region Proyecto_FuenteFinanciamiento
        public DataSet Combo_Proyecto_FuenteFinanciamiento(string strCodEmpresa,
                                            string strCodProyecto
                                          )
        {
            return objDs.Combo_Proyecto_FuenteFinanciamiento( strCodEmpresa,
                                            strCodProyecto
                                          );
        }

        public DataSet Combo_Proyecto_FuenteFinanciamiento_Todos(string strCodEmpresa)
        {
            return objDs.Combo_Proyecto_FuenteFinanciamiento_Todos(strCodEmpresa);
        }

        public DataSet Lista_Proyecto_FuenteFinanciamiento(string strCodEmpresa,
                                            string strCodProyecto

                                  )
        {
            return objDs.Lista_Proyecto_FuenteFinanciamiento(strCodEmpresa, strCodProyecto);
        }


        public Boolean Graba_Proyecto_FuenteFinanciamiento(string strCodEmpresa,
                                                string strCodProyecto,
                                                string strCodFuenteFinanciamiento
                                              )
        {
            return objDs.Graba_Proyecto_FuenteFinanciamiento(strCodEmpresa,
                                                 strCodProyecto,
                                                 strCodFuenteFinanciamiento
                                               );
        }
        public Boolean Elimina_Proyecto_FuenteFinanciamiento(string strCodEmpresa,
                                                string strCodProyecto,
                                                string strCodFuenteFinanciamiento
                                              )
        {
            return objDs.Elimina_Proyecto_FuenteFinanciamiento(strCodEmpresa,
                                                strCodProyecto,
                                                strCodFuenteFinanciamiento
                                              );
        }



        #endregion

        #region TipoProyecto
        public DataSet Ayuda_TipoProyecto()
        {
            return objDs.Ayuda_TipoProyecto();
        }

        public DataSet Lista_TipoProyecto()
        {
            return objDs.Lista_TipoProyecto();
        }

        public DataSet Combo_TipoProyecto_Reporte()
        {
            return objDs.Combo_TipoProyecto_Reporte();
        }

        public DataSet Combo_TipoProyecto()
        {
            return objDs.Combo_TipoProyecto();
        }
        public Model.TipoProyecto Recupera_TipoProyecto(int intIdTipoProyecto)
        {
            return objDs.Recupera_TipoProyecto(intIdTipoProyecto);
        }

        public Model.TipoProyecto Recupera_TipoProyecto_codigo(string strCodTipoProyecto)
        {
            return objDs.Recupera_TipoProyecto_codigo(strCodTipoProyecto);
        }
        public int Graba_TipoProyecto(Model.TipoProyecto obj)
        {
            return objDs.Graba_TipoProyecto(obj);
        }
        public int Modifica_TipoProyecto(Model.TipoProyecto obj)
        {
            return objDs.Modifica_TipoProyecto(obj);
        }

        public bool Elimina_TipoProyecto(int intIdTipoProyecto)
        {
            return objDs.Elimina_TipoProyecto(intIdTipoProyecto);
        }

        #endregion

        #region UnidadEjecutoraProyecto
        public DataSet Lista_UnidadEjecutoraProyecto()
        {
            return objDs.Lista_UnidadEjecutoraProyecto();
        }

        public DataSet Ayuda_UnidadEjecutoraProyecto()
        {
            return objDs.Ayuda_UnidadEjecutoraProyecto();
        }

        public DataSet Combo_UnidadEjecutoraProyecto_Reporte()
        {
            return objDs.Combo_UnidadEjecutoraProyecto_Reporte();
        }

        public DataSet Combo_UnidadEjecutoraProyecto()
        {
            return objDs.Combo_UnidadEjecutoraProyecto();
        }
        public Model.UnidadEjecutoraProyecto Recupera_UnidadEjecutoraProyecto(int intIdUnidadEjecutoraProyecto)
        {
            return objDs.Recupera_UnidadEjecutoraProyecto(intIdUnidadEjecutoraProyecto);
        }

        public Model.UnidadEjecutoraProyecto Recupera_UnidadEjecutoraProyecto_codigo(string strCodUnidadEjecutoraProyecto)
        {
            return objDs.Recupera_UnidadEjecutoraProyecto_codigo(strCodUnidadEjecutoraProyecto);
        }
        public int Graba_UnidadEjecutoraProyecto(Model.UnidadEjecutoraProyecto obj)
        {
            return objDs.Graba_UnidadEjecutoraProyecto(obj);
        }
        public int Modifica_UnidadEjecutoraProyecto(Model.UnidadEjecutoraProyecto obj)
        {
            return objDs.Modifica_UnidadEjecutoraProyecto(obj);
        }

        public bool Elimina_UnidadEjecutoraProyecto(int intIdUnidadEjecutoraProyecto)
        {
            return objDs.Elimina_UnidadEjecutoraProyecto(intIdUnidadEjecutoraProyecto);
        }

        #endregion

        #region UnidadFormuladoraProyecto
        public DataSet Lista_UnidadFormuladoraProyecto()
        {
            return objDs.Lista_UnidadFormuladoraProyecto();
        }

        public DataSet Ayuda_UnidadFormuladoraProyecto()
        {
            return objDs.Ayuda_UnidadFormuladoraProyecto();
        }

        public DataSet Combo_UnidadFormuladoraProyecto_Reporte()
        {
            return objDs.Combo_UnidadFormuladoraProyecto_Reporte();
        }

        public DataSet Combo_UnidadFormuladoraProyecto()
        {
            return objDs.Combo_UnidadFormuladoraProyecto();
        }
        public Model.UnidadFormuladoraProyecto Recupera_UnidadFormuladoraProyecto(int intIdUnidadFormuladoraProyecto)
        {
            return objDs.Recupera_UnidadFormuladoraProyecto(intIdUnidadFormuladoraProyecto);
        }

        public Model.UnidadFormuladoraProyecto Recupera_UnidadFormuladoraProyecto_codigo(string strCodUnidadFormuladoraProyecto)
        {
            return objDs.Recupera_UnidadFormuladoraProyecto_codigo(strCodUnidadFormuladoraProyecto);
        }
        public int Graba_UnidadFormuladoraProyecto(Model.UnidadFormuladoraProyecto obj)
        {
            return objDs.Graba_UnidadFormuladoraProyecto(obj);
        }
        public int Modifica_UnidadFormuladoraProyecto(Model.UnidadFormuladoraProyecto obj)
        {
            return objDs.Modifica_UnidadFormuladoraProyecto(obj);
        }

        public bool Elimina_UnidadFormuladoraProyecto(int intIdUnidadFormuladoraProyecto)
        {
            return objDs.Elimina_UnidadFormuladoraProyecto(intIdUnidadFormuladoraProyecto);
        }

        #endregion

        #region TareaProyecto
        public DataSet Ayuda_TareaProyecto()
        {
            return objDs.Ayuda_TareaProyecto();
        }
        public DataSet Lista_TareaProyecto()
        {
            return objDs.Lista_TareaProyecto();
        }

        public DataSet Naturaleza_TareaProyecto()
        {
            return objDs.Naturaleza_TareaProyecto();
        }

        public DataSet Combo_TareaProyecto_Reporte()
        {
            return objDs.Combo_TareaProyecto_Reporte();
        }

        public DataSet Combo_TareaProyecto()
        {
            return objDs.Combo_TareaProyecto();
        }
        public Model.TareaProyecto Recupera_TareaProyecto(int intIdTareaProyecto)
        {
            return objDs.Recupera_TareaProyecto(intIdTareaProyecto);
        }

        public Model.TareaProyecto Recupera_TareaProyecto_codigo(string strCodTareaProyecto)
        {
            return objDs.Recupera_TareaProyecto_codigo(strCodTareaProyecto);
        }
        public int Graba_TareaProyecto(Model.TareaProyecto obj)
        {
            return objDs.Graba_TareaProyecto(obj);
        }
        public int Modifica_TareaProyecto(Model.TareaProyecto obj)
        {
            return objDs.Modifica_TareaProyecto(obj);
        }

        public bool Elimina_TareaProyecto(int intIdTareaProyecto)
        {
            return objDs.Elimina_TareaProyecto(intIdTareaProyecto);
        }

        #endregion

        #region TipoActividadProyecto
        public DataSet Ayuda_TipoActividadProyecto()
        {
            return objDs.Ayuda_TipoActividadProyecto();
        }
        public DataSet Lista_TipoActividadProyecto()
        {
            return objDs.Lista_TipoActividadProyecto();
        }

        public DataSet Naturaleza_TipoActividadProyecto()
        {
            return objDs.Naturaleza_TipoActividadProyecto();
        }

        public DataSet Combo_TipoActividadProyecto_Reporte()
        {
            return objDs.Combo_TipoActividadProyecto_Reporte();
        }

        public DataSet Combo_TipoActividadProyecto()
        {
            return objDs.Combo_TipoActividadProyecto();
        }
        public Model.TipoActividadProyecto Recupera_TipoActividadProyecto(int intIdTipoActividadProyecto)
        {
            return objDs.Recupera_TipoActividadProyecto(intIdTipoActividadProyecto);
        }

        public Model.TipoActividadProyecto Recupera_TipoActividadProyecto_codigo(string strCodTipoActividadProyecto)
        {
            return objDs.Recupera_TipoActividadProyecto_codigo(strCodTipoActividadProyecto);
        }
        public int Graba_TipoActividadProyecto(Model.TipoActividadProyecto obj)
        {
            return objDs.Graba_TipoActividadProyecto(obj);
        }
        public int Modifica_TipoActividadProyecto(Model.TipoActividadProyecto obj)
        {
            return objDs.Modifica_TipoActividadProyecto(obj);
        }

        public bool Elimina_TipoActividadProyecto(int intIdTipoActividadProyecto)
        {
            return objDs.Elimina_TipoActividadProyecto(intIdTipoActividadProyecto);
        }

        #endregion

        #region EstadoMacroProyecto
        public DataSet Combo_EstadoMacroProyecto()
        {
            return objDs.Combo_EstadoMacroProyecto();
        }

        #endregion

        #endregion

        #region RECURSOHUMANO
        #region "TipoMovimientoConcepto"
        public DataSet combo_TipoMovimientoConcepto()
        {
            return objDs.combo_TipoMovimientoConcepto();
        }
        #endregion

        #region "ClaseConcepto"
        public DataSet combo_ClaseConcepto()
        {
            return objDs.combo_ClaseConcepto();
        }
        #endregion

        #region "TipoConcepto"
        public DataSet combo_TipoConcepto()
        {
            return objDs.combo_TipoConcepto();
        }
        #endregion

        #region "Contrato"
        public DataSet lista_Empleado(string strCodEmpresa,
                                       string strCodTipoCalculo
                                     )
        {
            return objDs.lista_Empleado(strCodEmpresa,
                                   strCodTipoCalculo
                                     );
        }

        public DataSet combo_TipoCalculoPlanilla()
        {
            return objDs.combo_TipoCalculoPlanilla();
        }

        public DataSet combo_Sexo()
        {
            return objDs.combo_Sexo();
        }

        public DataSet combo_TipoDocumentoIdentidad()
        {
            return objDs.combo_TipoDocumentoIdentidad();
        }

        public DataSet ayuda_Nacionalidad()
        {
            return objDs.ayuda_Nacionalidad();
        }

        public DataSet Recupera_Empleado_Vigente(string strCodEmpresa,
                                                  string strCodEmpleado
                                                )
        {
            return objDs.Recupera_Empleado_Vigente(strCodEmpresa,
                                              strCodEmpleado
                                                );
        }

        public Model.Empleado recupera_Empleado(int intIdEmpleado)
        {
            return objDs.recupera_Empleado(intIdEmpleado);
        }

        public int graba_Empleado(Model.Empleado obj)
        {
            return objDs.graba_Empleado(obj);
        }

        public int modifica_Empleado(Model.Empleado obj)
        {
            return objDs.modifica_Empleado(obj);
        }

        public Boolean elimina_Empleado(int intIdEmpleado)
        {
            return objDs.elimina_Empleado(intIdEmpleado);
        }

        #endregion

        #region "Empleado_Contrato"
        public DataSet combo_Empresa()
        {
            return objDs.combo_Empresa();
        }

        public DataSet combo_TipoDocumentoLaboral()
        {
            return objDs.combo_TipoDocumentoLaboral();
        }

        public DataSet combo_TipoContratoLaboral()
        {
            return objDs.combo_TipoContratoLaboral();
        }

        public DataSet combo_TipoEmpleado()
        {
            return objDs.combo_TipoEmpleado();
        }

        public DataSet combo_NivelSalarial()
        {
            return objDs.combo_NivelSalarial();
        }

        public DataSet combo_ClaseEmpleado()
        {
            return objDs.combo_ClaseEmpleado();
        }

        public DataSet combo_CategoriaOcupacional()
        {
            return objDs.combo_CategoriaOcupacional();
        }

        public DataSet combo_RegimenLaboral()
        {
            return objDs.combo_RegimenLaboral();
        }

        public DataSet combo_PeriodicidadRemunerativa()
        {
            return objDs.combo_PeriodicidadRemunerativa();
        }

        public DataSet combo_TipoRemuneracion()
        {
            return objDs.combo_TipoRemuneracion();
        }

        public DataSet combo_TipoMoneda_RRHH()
        {
            return objDs.combo_TipoMoneda_RRHH();
        }

        public DataSet combo_TipoFormatoContrato()
        {
            return objDs.combo_TipoFormatoContrato();
        }

        public DataSet lista_Empleado_Contrato(string strCodEmpleado)
        {
            return objDs.lista_Empleado_Contrato(strCodEmpleado);
        }

        public Model.Empleado_Contrato recupera_Empleado_Contrato(int intIdEmpleado_Contrato)
        {
            return objDs.recupera_Empleado_Contrato(intIdEmpleado_Contrato);
        }

        public Model.Empleado_Contrato recupera_Empleado_Contrato_Duplicado(string strCodEmpleado)
        {
            return objDs.recupera_Empleado_Contrato_Duplicado(strCodEmpleado);
        }

        public int graba_Empleado_Contrato(Model.Empleado_Contrato obj)
        {
            return objDs.graba_Empleado_Contrato(obj);
        }

        public int modifica_Empleado_Contrato(Model.Empleado_Contrato obj)
        {
            return objDs.modifica_Empleado_Contrato(obj);
        }

        public DataSet combo_Obra()
        {
            return objDs.combo_Obra();
        }

        #endregion

        #region "TipoEmpleado"
        public Model.TipoEmpleado recupera_TipoEmpleado(int intIdTipoEmpleado)
        {
            return objDs.recupera_TipoEmpleado(intIdTipoEmpleado);
        }
        public Model.TipoEmpleado recupera_TipoEmpleado_Codigo(string strCodTipoEmpleado)
        {
            return objDs.recupera_TipoEmpleado_Codigo(strCodTipoEmpleado);
        }

        public int graba_TipoEmpleado(Model.TipoEmpleado obj)
        {
            return objDs.graba_TipoEmpleado(obj);
        }

        public int modifica_TipoEmpleado(Model.TipoEmpleado obj)
        {
            return objDs.modifica_TipoEmpleado(obj);
        }

        public Boolean elimina_TipoEmpleado(int intIdTipoEmpleado)
        {
            return objDs.elimina_TipoEmpleado(intIdTipoEmpleado);
        }



        #endregion

        #region "NivelSalarial"

        public Model.NivelSalarial recupera_NivelSalarial_Codigo(string strCodNivelSalarial)
        {
            return objDs.recupera_NivelSalarial_Codigo(strCodNivelSalarial);
        }
        public Model.NivelSalarial recupera_NivelSalarial(int intIdNivelSalarial)
        {
            return objDs.recupera_NivelSalarial(intIdNivelSalarial);
        }

        public int graba_NivelSalarial(Model.NivelSalarial obj)
        {
            return objDs.graba_NivelSalarial(obj);
        }

        public int modifica_NivelSalarial(Model.NivelSalarial obj)
        {
            return objDs.modifica_NivelSalarial(obj);
        }

        public Boolean elimina_NivelSalarial(int intIdNivelSalarial)
        {
            return objDs.elimina_NivelSalarial(intIdNivelSalarial);
        }

        #endregion

        #region "MotivoBajaEmpleado"
        public DataSet combo_MotivoBajaEmpleado()
        {
            return objDs.combo_MotivoBajaEmpleado();
        }
        #endregion

        #region "Empleado_Baja"
        public Model.Empleado_Baja recupera_Empleado_Baja(int intIdEmpleado_Baja)
        {
            return objDs.recupera_Empleado_Baja(intIdEmpleado_Baja);
        }
        public int graba_Empleado_Baja(Model.Empleado_Baja obj)
        {
            return objDs.graba_Empleado_Baja(obj);
        }
        public int modifica_Empleado_Baja(Model.Empleado_Baja obj)
        {
            return objDs.modifica_Empleado_Baja(obj);
        }

        public Boolean elimina_Empleado_Baja(int intIdEmpleado_Baja)
        {
            return objDs.elimina_Empleado_Baja(intIdEmpleado_Baja);
        }
        #endregion

        #region "Profesion"
        public DataSet ayuda_Profesion()
        {
            return objDs.ayuda_Profesion();
        }
        #endregion

        #region "Concepto"

        public DataSet lista_Concepto()
        {
            return objDs.lista_Concepto();
        }
        public DataSet ayuda_ConceptoPlanillaRTPS(string strCodClaseConcepto)
        {
            return objDs.ayuda_ConceptoPlanillaRTPS(strCodClaseConcepto);
        }
        public DataSet ayuda_ConceptoPlanilla(string strCodClaseConcepto)
        {
            return objDs.ayuda_ConceptoPlanilla(strCodClaseConcepto);
        }
        public Model.ConceptoPlanilla recupera_ConceptoPlanilla(int intidConcepto)
        {
            return objDs.recupera_ConceptoPlanilla(intidConcepto);
        }
        public Model.ConceptoPlanilla recupera_ConceptoPlanilla_Codigo(string strCodConcepto)
        {
            return objDs.recupera_ConceptoPlanilla_Codigo(strCodConcepto);
        }

        public Model.ConceptoPlanilla recupera_ConceptoPlanilla_Codigo_TipoCalculo(string strCodConcepto,
                                                                                   string strCodTipoCalculo
                                                                                  )
        {
            return objDs.recupera_ConceptoPlanilla_Codigo_TipoCalculo(strCodConcepto,
                                                                                   strCodTipoCalculo
                                                                                  );
        }
        public int graba_ConceptoPlanilla(Model.ConceptoPlanilla obj)
        {
            return objDs.graba_ConceptoPlanilla(obj);
        }

        public int modifica_ConceptoPlanilla(Model.ConceptoPlanilla obj)
        {
            return objDs.modifica_ConceptoPlanilla(obj);
        }
        public Boolean elimina_ConceptoPlanilla(int intidConcepto,
                                    string strCodEmpresa
                                    )
        {
            return objDs.elimina_ConceptoPlanilla( intidConcepto,
                                    strCodEmpresa
                                    );
        }
        #endregion

        #region "FormulaPlanilla"

        public DataSet lista_FormulaPlanilla(string strCodTipoCalculo)
        {
            return objDs.lista_FormulaPlanilla(strCodTipoCalculo);
        }
        public Model.FormulaPlanilla recupera_FormulaPlanilla(int intIdFormula)
        {
            return objDs.recupera_FormulaPlanilla(intIdFormula);
        }

        public Model.FormulaPlanilla recupera_FormulaPlanilla_Codigo(string strCodFormula)
        {
            return objDs.recupera_FormulaPlanilla_Codigo(strCodFormula);
        }
        public int graba_FormulaPlanilla(Model.FormulaPlanilla obj)
        {
            return objDs.graba_FormulaPlanilla(obj);
        }

        public int modifica_FormulaPlanilla(Model.FormulaPlanilla obj)
        {
            return objDs.modifica_FormulaPlanilla(obj);
        }

        public Boolean elimina_FormulaPlanilla(int intIdFormula)
        {
            return objDs.elimina_FormulaPlanilla(intIdFormula);
        }
        #endregion

        #region "FormulaPlanillaBI"

        public DataSet lista_FormulaPlanillaBI(string strCodTipoCalculo)
        {
            return objDs.lista_FormulaPlanillaBI(strCodTipoCalculo);
        }
        public Model.FormulaPlanillaBI recupera_FormulaPlanillaBI(int intIdFormulaBI)
        {
            return objDs.recupera_FormulaPlanillaBI(intIdFormulaBI);
        }

        public Model.FormulaPlanillaBI recupera_FormulaPlanillaBI_Codigo(string strCodFormulaBI)
        {
            return objDs.recupera_FormulaPlanillaBI_Codigo(strCodFormulaBI);
        }
        public int graba_FormulaPlanillaBI(Model.FormulaPlanillaBI obj)
        {
            return objDs.graba_FormulaPlanillaBI(obj);
        }

        public int modifica_FormulaPlanillaBI(Model.FormulaPlanillaBI obj)
        {
            return objDs.modifica_FormulaPlanillaBI(obj);
        }
        public Boolean elimina_FormulaPlanillaBI(int intIdFormulaBI)
        {
            return objDs.elimina_FormulaPlanillaBI(intIdFormulaBI);
        }
        #endregion

        #region "BoletaCabecera"

        public DataSet reporte_BoletaCabecera(string strAñoProceso,
                                                    string strCodTipoCalculo,
                                                    string strPeriodoProceso,
                                                    string strCodTipoPlanilla,
                                                    string strCodEmpleado,
                                                    bool blnEstado,
                                                    string strCodEmpresa,
                                                    string strCodTipoMoneda
                                                  )
        {
            return objDs.reporte_BoletaCabecera(strAñoProceso,
                                          strCodTipoCalculo,
                                          strPeriodoProceso,
                                          strCodTipoPlanilla,
                                          strCodEmpleado,
                                          blnEstado,
                                          strCodEmpresa,
                                          strCodTipoMoneda
                                                  );
        }

        public DataSet lista_Empleados_Boleta(string strAñoProcesoPlanilla,
                                                string strCodTipoCalculo,
                                                string strPeriodoProcesoPlanilla,
                                                string strCodTipoPlanilla
                                             )
        {
            return objDs.lista_Empleados_Boleta(strAñoProcesoPlanilla,
                                          strCodTipoCalculo,
                                          strPeriodoProcesoPlanilla,
                                          strCodTipoPlanilla
                                             );
        }

        public DataSet recupera_BoletaCabecera_CalculoPlanilla(string strAñoProceso,
                                                               string strCodTipoCalculo,
                                                               string strPeriodoProceso,
                                                               string strCodTipoPlanilla,
                                                               string strCodEmpleado
                                                           )
        {
            return objDs.recupera_BoletaCabecera_CalculoPlanilla( strAñoProceso,
                                                            strCodTipoCalculo,
                                                             strPeriodoProceso,
                                                             strCodTipoPlanilla,
                                                             strCodEmpleado
                                                           );
        }
        public int graba_BoletaCabecera(string strAñoProceso,
                                        string strCodTipoCalculo,
                                        string strPeriodoProceso,
                                        string strCodTipoPlanilla,
                                        DateTime datePeriodoInicial,
                                        DateTime datePeriodoFinal
                                     )
        {
            return objDs.graba_BoletaCabecera( strAñoProceso,
                                         strCodTipoCalculo,
                                        strPeriodoProceso,
                                         strCodTipoPlanilla,
                                         datePeriodoInicial,
                                         datePeriodoFinal
                                     );
        }
        public Model.BoletaCabecera_ParametrosCalculoPlanilla recupera_BoletaCabecera_ParametrosCalculoPlanilla(string strAñoProceso,
                                                                                                                 string strCodTipoCalculo
                                                                                                               )
        {
            return objDs.recupera_BoletaCabecera_ParametrosCalculoPlanilla(strAñoProceso,
                                                                     strCodTipoCalculo
                                                                    );
        }
        #endregion

        #region "BoletaDetalle"
        public int genera_BoletaDetalle_EmpleadosSinMeta(string strAñoProceso,
                                                         string strPeriodoProceso,
                                                         string strCodTipoCalculo,
                                                         string strCodEmpresa
                                                        )

        {
            return objDs.genera_BoletaDetalle_EmpleadosSinMeta( strAñoProceso,
                                                          strPeriodoProceso,
                                                          strCodTipoCalculo,
                                                          strCodEmpresa
                                                        );
        }

        public int genera_BoletaDetalle_EmpleadosSinContrato(string strCodTipoCalculo)
        {
            return objDs.genera_BoletaDetalle_EmpleadosSinContrato(strCodTipoCalculo);
        }

        #endregion

        #region "ParametroPlanilla"
        public Model.Parametro_Planilla recupera_ParametroPlanilla(string strCodEmpresa)
        {
            return objDs.recupera_ParametroPlanilla(strCodEmpresa);
        }
        #endregion

        #region "PeriodoCalculoPlanilla"
        public Model.PeriodoCalculoPlanilla recupera_PeriodoCalculoPlanilla(string strAñoProceso,
                                                                            string strCodTipoCalculo,
                                                                            string strPeriodoProceso
                                                                           )
        {
            return objDs.recupera_PeriodoCalculoPlanilla(strAñoProceso,
                                                                             strCodTipoCalculo,
                                                                             strPeriodoProceso
                                                                           );
        }
        #endregion

        #region "CalculoPlanilla"

        public bool graba_BoletaDetalle(int intIdBoletaCabecera,
                                                string strCodConcepto,
                                                double dblCantidad,
                                                double dblImporte,
                                                double dblRestoPrestamo,
                                                int intIdPrestamoDetalle,
                                                bool blnEstado,
                                                string strCodMeta
                                            )
        {
            return objDs.graba_BoletaDetalle(intIdBoletaCabecera,
                                       strCodConcepto,
                                       dblCantidad,
                                       dblImporte,
                                       dblRestoPrestamo,
                                       intIdPrestamoDetalle,
                                       blnEstado,
                                       strCodMeta
                                            );
        }

        public DataSet genera_BoletaDetalle_CalculoPlanilla(string strAñoProceso,
                                                            string strMesProceso,
                                                            string strPeriodoProceso,
                                                            string strCodTipoCalculo,
                                                            string strCodTipoPlanilla,
                                                            string strCodEmpleado,
                                                            bool blnEstado,
                                                            int intIdBoletaCabecera
                                                          )
        {
            return objDs.genera_BoletaDetalle_CalculoPlanilla(strAñoProceso,
                                                        strMesProceso,
                                                        strPeriodoProceso,
                                                        strCodTipoCalculo,
                                                        strCodTipoPlanilla,
                                                        strCodEmpleado,
                                                        blnEstado,
                                                        intIdBoletaCabecera
                                                          );
        }
        #endregion

        #region "PeriodoRecursoHumano"

        public DataSet Verificar_PeriodoCalculoPlanilla(string strCodTipoCalculo,
                                                         string strAnoProceso,
                                                         string strPeriodoProceso
                                                       )
        {
            return objDs.Verificar_PeriodoCalculoPlanilla(strCodTipoCalculo,
                                                    strAnoProceso,
                                                    strPeriodoProceso
                                                       );
        }
        public DataSet combo_AñoProcesoPlanilla()
        {
            return objDs.combo_AñoProcesoPlanilla();
        }

        public DataSet combo_PeriodoProcesoPlanilla(string strAñoProceso,
                                                     string strCodTipoCalculo
                                                    )
        {
            return objDs.combo_PeriodoProcesoPlanilla(strAñoProceso,
                                                 strCodTipoCalculo
                                                    );
        }

        #endregion

        #region "ReporteRecursoHumano"

        #endregion

        #region "TipoPlanilla"
        public DataSet combo_TipoPlanilla(string strAñoProcesoPlanilla,
                                           string strCodTipoCalculo,
                                           string strPeriodoProcesoPlanilla
                                         )
        {
            return objDs.combo_TipoPlanilla(strAñoProcesoPlanilla,
                                       strCodTipoCalculo,
                                       strPeriodoProcesoPlanilla
                                         );
        }
        #endregion

        #region Empleado
        public DataSet Ayuda_Empleado_Jefatura()
        {
            return objDs.Ayuda_Empleado_Jefatura();
        }


        public Model.Empleado Recupera_Empleado_Codigo(string strCodEmpleado)
        {
            return objDs.Recupera_Empleado_Codigo(strCodEmpleado);
        }

        public DataSet Ayuda_Empleado()
        {
            return objDs.Ayuda_Empleado();
        }

        public Model.Empleado GetEmpleado(string strCodEmpleado)
        {
            return objDs.GetEmpleado(strCodEmpleado);
        }

        private Model.Empleado GetEmpDataTableRow_rrhh(DataRow dr)
        {
            return GetEmpDataTableRow_rrhh(dr);
        }

        public DataSet Lista_Empleado_CentroCosto(string strCodEmpresa)
        {
            return objDs.Lista_Empleado_CentroCosto(strCodEmpresa);
        }

        public DataSet Graba_Empleado_CentroCosto(string strCodEmpresa,
                                                  string strCodEmpleado,
                                                  string strCodCentroCosto
                                                 )
        {
            return objDs.Graba_Empleado_CentroCosto(strCodEmpresa,
                                              strCodEmpleado,
                                              strCodCentroCosto
                                                 );
        }

        #endregion

        #endregion

        #region TDR
        public DataSet Ayuda_TerminoReferencia_Seguimiento(string strCodCompañia,
                                                   string strAñoProceso,
                                                   string strCodCentroGestor
                                                 )
        {
            return objDs.Ayuda_TerminoReferencia_Seguimiento( strCodCompañia,
                                                    strAñoProceso,
                                                    strCodCentroGestor
                                                 );
        }


        public DataSet Ayuda_TerminoReferencia(string strCodCompañia,
                                                string strAñoProceso,
                                                string strCodCentroGestor
                                               )
        {
            return objDs.Ayuda_TerminoReferencia(strCodCompañia,
                                            strAñoProceso,
                                            strCodCentroGestor
                                               );
        }
        public DataSet Ayuda_TerminoReferencia(string strCodCompañia,
                                 string strCodCentroGestor
                               )
        {
            return objDs.Ayuda_TerminoReferencia(strCodCompañia,
                                 strCodCentroGestor
                               );
        }

        public DataSet Ayuda_TerminoReferencia_SinEtapaCierre(string strCodCompañia,
                                 string strCodCentroGestor
                               )
        {
            return objDs.Ayuda_TerminoReferencia_SinEtapaCierre(strCodCompañia,
                                 strCodCentroGestor
                               );
        }


        public Model.EnvioCorreo Recupera_EnvioCorreo(string strCodCompañia,
                                                        string strCodEmpleado
                                                      )
        {
            return objDs.Recupera_EnvioCorreo(strCodCompañia,
                                        strCodEmpleado
                                                      );
        }

        public Model.EnvioCorreo Recupera_UsuarioCorreo(string strCodCompañia,
                                                        string strEmail
                                                      )
        {
            return objDs.Recupera_UsuarioCorreo(strCodCompañia,
                                          strEmail
                                                      );
        }

        public DataSet Ayuda_Empleado_TDR_Para(string strCodCompañia,
                                               Boolean blnEsInicioDocumento
                                              )
        {
            return objDs.Ayuda_Empleado_TDR_Para(strCodCompañia,
                                           blnEsInicioDocumento
                                              );
        }

        public DataSet Ayuda_Empleado_TDR_CC(string strCodCompañia,
                                             string strCodEmpleado
                                            )
        {
            return objDs.Ayuda_Empleado_TDR_CC(strCodCompañia,
                                         strCodEmpleado
                                            );
        }

        public string Graba_TerminoRefrencia(Model.TerminoReferencia obj,
                                                                Boolean blnEsCreadoEnGestion
                                                              )
        {
            return objDs.Graba_TerminoRefrencia(obj,
                                          blnEsCreadoEnGestion
                                                              );
        }

        public string Graba_TerminoRefrencia_CreadoEnGestion(Model.TerminoReferencia obj)
        {
            return objDs.Graba_TerminoRefrencia_CreadoEnGestion(obj);
        }

        public string Recupera_VersionDocumento(string strCodCompañia,
                                                string strAñoProceso,
                                                string strTerminoReferencia
                                                      )
        {
            return objDs.Recupera_VersionDocumento(strCodCompañia,
                                             strAñoProceso,
                                             strTerminoReferencia
                                                      );
        }


        public string Graba_TerminoRefrencia_IdaVuelta(Model.TerminoReferencia obj)
        {
            return objDs.Graba_TerminoRefrencia_IdaVuelta(obj);
        }

        public string Graba_TerminoRefrencia_AutorizaRequerimiento(Model.TerminoReferencia obj)
        {
            return objDs.Graba_TerminoRefrencia_AutorizaRequerimiento(obj);
        }
        public DataSet Lista_TerminoRefrencia_IdaVuelta(string strCodCompañia,
                                                         string strCodEmpleado,
                                                         string strCodTipoMovimiento,
                                                         string strCodEstado
                                                       )
        {
            return objDs.Lista_TerminoRefrencia_IdaVuelta(strCodCompañia,
                                                     strCodEmpleado,
                                                     strCodTipoMovimiento,
                                                     strCodEstado
                                                       );
        }

        public DataSet Lista_TerminoRefrencia_Seguimiento(string strCodCompañia,
                                                          string strNumDocumento
                                                       )
        {
            return objDs.Lista_TerminoRefrencia_Seguimiento(strCodCompañia,
                                                      strNumDocumento
                                                       );
        }

        public bool Graba_TerminoRefrencia_Anulacion(string strCodCompañia,
                                                          string strNumDocumento
                                                       )
        {
            return objDs.Graba_TerminoRefrencia_Anulacion(strCodCompañia,
                                                      strNumDocumento
                                                       );
        }

        public Model.TerminoReferencia Recupera_TerminoReferencia(string strCodCompañia,
                                                                    string strNumAdjunto
                                                                 )
        {
            return objDs.Recupera_TerminoReferencia(strCodCompañia,
                                              strNumAdjunto
                                                                 );
        }

        public string Recupera_TerminoReferencia_Adjunto(string strCodCompañia,
                                                                    string strNumAdjunto
                                                                 )
        {
            return objDs.Recupera_TerminoReferencia_Adjunto(strCodCompañia,
                                              strNumAdjunto
                                                                 );
        }

        public int Graba_ProcesoAdquisicion(Model.ProcesoAdquisicion obj)
        {
            return objDs.Graba_ProcesoAdquisicion(obj);
        }

        public int Modifica_ProcesoAdquisicion(Model.ProcesoAdquisicion obj)
        {

            return objDs.Modifica_ProcesoAdquisicion(obj);
        }

        public bool Elimina_ProcesoAdquisicion(int intIdProcesoAduisicion)
        {

            return objDs.Elimina_ProcesoAdquisicion(intIdProcesoAduisicion);
        }

        public Model.xmlDATA recupera_xmlData(string xmlCodigo)
        {
            return objDs.recupera_xmlData(xmlCodigo);
        }

        public Model.xmlDATA recupera_xmlData_Logistica(string xmlCodigo)
        {
            return objDs.recupera_xmlData_Logistica(xmlCodigo);
        }


        public int graba_xmlData(Model.xmlDATA obj)
        {

            return objDs.graba_xmlData(obj);
        }

        public int modifica_xmlData(Model.xmlDATA obj)
        {

            return objDs.modifica_xmlData(obj);
        }

        public int modifica_xmlData_Logistica(Model.xmlDATA obj)
        {

            return objDs.modifica_xmlData_Logistica(obj);
        }

        public bool elimina_xmlData(int intIdXml)
        {

            return objDs.elimina_xmlData(intIdXml);
        }

        public DataSet lista_xmlData()
        {

            return objDs.lista_xmlData();

        }

        #endregion

        #region TRAMITE
        #region DocumentoTramite
        public int Recupera_Version(string strNumDocumento)
        {
            return objDs.Recupera_Version(strNumDocumento);
        }

        public int GrabaDocumentoTramite(Model.DocumentoTramite objDocumentoTramite)
        {
            return objDs.GrabaDocumentoTramite(objDocumentoTramite);
        }
        #endregion

        #region DocumentoTramite_Adjunto
        public int GrabaDocumentoTramite_Adjunto(Model.DocumentoTramite_Adjunto objDocumentoTramite_Adjunto)
        {
            return objDs.GrabaDocumentoTramite_Adjunto(objDocumentoTramite_Adjunto);
        }


        public DataSet Lista_TDR_Aprobar(string strAñoProceso,
                                      string strCodCentroGestor
                                    )
        {
            return objDs.Lista_TDR_Aprobar(strAñoProceso,
                                     strCodCentroGestor
                                    );
        }

        #endregion

        #region DocumentoTramite_Contacto
        public int grabaDocumentoTramite_Contacto(Model.DocumentoTramite_Contacto objDocumentoTramite_Contacto)
        {
            return objDs.grabaDocumentoTramite_Contacto(objDocumentoTramite_Contacto);
        }

        #endregion

        #region DocumentoTramite_ContactoCC
        public int grabaDocumentoTramite_ContactoCC(Model.DocumentoTramite_ContactoCC objDocumentoTramite_Contacto)
        {
            return objDs.grabaDocumentoTramite_ContactoCC(objDocumentoTramite_Contacto);
        }

        #endregion

        #region DocumentoTramite_Detalle
        public DataSet recuperaDocumentoTramite_Detalle_Documento(long intIdDocumentoDetalle)
        {
            return objDs.recuperaDocumentoTramite_Detalle_Documento(intIdDocumentoDetalle);
        }

        public DataSet listaDocumentoTramite_Detalle_Seguimiento(long intIdDocumentoDetalle)
        {
            return objDs.listaDocumentoTramite_Detalle_Seguimiento(intIdDocumentoDetalle);
        }
        public DataSet listaDocumentoTramite_Detalle_Leidos(long intIdDocumentoDetalle)
        {
            return objDs.listaDocumentoTramite_Detalle_Leidos(intIdDocumentoDetalle);
        }

        public DataSet listaDocumentoTramite_Detalle_Adjuntos(long intIdDocumentoDetalle)
        {
            return objDs.listaDocumentoTramite_Detalle_Adjuntos(intIdDocumentoDetalle);
        }
        public int grabaDocumentoTramite_Detalle(Model.DocumentoTramite_Detalle objDocumentoTramite_Detalle)
        {
            return objDs.grabaDocumentoTramite_Detalle(objDocumentoTramite_Detalle);
        }

        public DataSet listaDocumentoTramite_Detalle(string strCodContacto, int intTipoMovimiento)
        {
            return objDs.listaDocumentoTramite_Detalle(strCodContacto, intTipoMovimiento);
        }

        #endregion

        #region DocumentoTramite_Entidad
        public int grabaDocumentoTramite_Entidad(Model.DocumentoTramite_Entidad objDocumentoTramite_Entidad)
        {
            return objDs.grabaDocumentoTramite_Entidad(objDocumentoTramite_Entidad);
        }

        #endregion

        #region DocumentoTramite_Proveido
        public int grabaDocumentoTramite_Proveido(Model.DocumentoTramite_Proveido objDocumentoTramite_Proveido)
        {
            return objDs.grabaDocumentoTramite_Proveido(objDocumentoTramite_Proveido);
        }

        #endregion

        #region DocumentoTramite_Seguimiento
        public int grabaDocumentoTramite_Seguimiento(Model.DocumentoTramite_Seguimiento objDocumentoTramite_Seguimiento)
        {
            return objDs.grabaDocumentoTramite_Seguimiento(objDocumentoTramite_Seguimiento);
        }

        #endregion

        #region TipoProveidoDocumento
        public Model.TipoProveidoDocumento Recupera_TipoProveidoDocumento(int intIdTipoProveido)
        {
            return objDs.Recupera_TipoProveidoDocumento(intIdTipoProveido);
        }

        public Model.TipoProveidoDocumento Recupera_TipoProveidoDocumento_Descripcion(string strDesTipoProveido)
        {
            return objDs.Recupera_TipoProveidoDocumento_Descripcion(strDesTipoProveido);
        }

        public int GrabaTipoProveidoDocumento(Model.TipoProveidoDocumento objTipoProveido)
        {
            return objDs.GrabaTipoProveidoDocumento(objTipoProveido);
        }

        public int ModificaTipoProveidoDocumento(Model.TipoProveidoDocumento objTipoProveido)
        {
            return objDs.ModificaTipoProveidoDocumento(objTipoProveido);
        }

        public bool EliminarTipoProveidoDocumento(int intIdTipoProveido)
        {
            return objDs.EliminarTipoProveidoDocumento(intIdTipoProveido);
        }

        public DataSet ListaTipoProveidoDocumento()
        {
            return objDs.ListaTipoProveidoDocumento();
        }

        public DataSet ComboTipoProveidoDocumento()
        {
            return objDs.ComboTipoProveidoDocumento();
        }

        #endregion

        #region ParametroTramite
        public Model.ParametroTramite Recupera_ParametroTramite(string strCodParametroTramite)
        {
            return objDs.Recupera_ParametroTramite(strCodParametroTramite);
        }

        #endregion

        #region Contacto
        public System.Data.DataSet Ayuda_msto_Contacto_DataTable(string strTexto)
        {
            return objDs.Ayuda_msto_Contacto_DataTable(strTexto);
        }

        public System.Data.DataSet Ayuda_msto_Preferido_DataTable(string strCodEmpleado)
        {
            return objDs.Ayuda_msto_Preferido_DataTable(strCodEmpleado);
        }

        public Model.Contacto Recupera_msto_Contacto(string strCodContacto)
        {
            return objDs.Recupera_msto_Contacto(strCodContacto);
        }

        public List<Model.Contacto> Ayuda_msto_Contacto(string strTexto)
        {
            return objDs.Ayuda_msto_Contacto(strTexto);
        }

        #endregion

        #endregion

        #region VIATICO
        #region ParametroViatico
        public Model.ParametroViatico Recupera_ctrl_ParametroViatico(string strCodParametroViatico)
        {
            return objDs.Recupera_ctrl_ParametroViatico(strCodParametroViatico);
        }

        #endregion

        #region SolicitudViatico

        public DataSet ayuda_Solicitud_Requerimiento(string strCodEmpresa)
        {
            return objDs.ayuda_Solicitud_Requerimiento(strCodEmpresa);
        }
        public Boolean Formato_SolicitudViatico_DescarteFirma(string strCodSolicitud,
                                            string strCodMotivoDescarte,
                                            DateTime dateFecDescarte,
                                            string strMotivoDescarte
                                          )
        {
            return objDs.Formato_SolicitudViatico_DescarteFirma(strCodSolicitud,
                                            strCodMotivoDescarte,
                                            dateFecDescarte,
                                            strMotivoDescarte
                                          );
        }
        public Boolean Formato_SolicitudViatico_Firma(string strCodCentro_Gestor,
                                            string strPaso,
                                            string strCodSolicitud,
                                            string strCodEmpleado
                                           )
        {
            return objDs.Formato_SolicitudViatico_Firma(strCodCentro_Gestor,
                                                strPaso,
                                               strCodSolicitud,
                                                strCodEmpleado
                                                   );
        }


        public DataSet Formato_SolicitudViatico(string strCodSolicitud)
        {
            return objDs.Formato_SolicitudViatico(strCodSolicitud);
        }
        public DataSet Formato_Solicitudviatico_Estado(string strCodCentro_Gestor,
                                                        string strEstado,
                                                        string strCodEmpleado,
                                                        string strCodPaso
                                                      )
        {
            return objDs.Formato_Solicitudviatico_Estado(strCodCentro_Gestor,
                                                         strEstado,
                                                         strCodEmpleado,
                                                         strCodPaso
                                                         );
        }
        public Model.SolicitudViatico Recupera_SolicitudViatico(string strCodSolicitud)
        {
            return objDs.Recupera_SolicitudViatico(strCodSolicitud);
        }

        public Model.SolicitudViatico Recupera_SolicitudViatico_y_LiquidacionViatico(string strCodSolicitud)
        {
            return objDs.Recupera_SolicitudViatico_y_LiquidacionViatico(strCodSolicitud);
        }

        public Model.SolicitudViatico Graba_SolicitudViatico(Model.SolicitudViatico objSolicitudViatico)
        {
            return objDs.Graba_SolicitudViatico(objSolicitudViatico);
        }

        public bool Modifica_SolicitudViatico(Model.SolicitudViatico objSolicitudViatico)
        {
            return objDs.Modifica_SolicitudViatico(objSolicitudViatico);
        }

        public bool Elimina_SolicitudViatico(string strCodSolicitud)
        {
            return objDs.Elimina_SolicitudViatico(strCodSolicitud);
        }

        public DataSet Lista_SolicitudViatico()
        {
            return objDs.Lista_SolicitudViatico();
        }



        #endregion

        #region IndicadorImpuesto
        public Model.IndicadorImpuesto Recupera_ctrl_IndicadorImpuesto_Codigo(string strCodIndicadorImpuesto)
        {
            return objDs.Recupera_ctrl_IndicadorImpuesto_Codigo(strCodIndicadorImpuesto);
        }

        public Model.IndicadorImpuesto Recupera_ctrl_IndicadorImpuesto(int intIdIndicadorImpuesto)
        {
            return objDs.Recupera_ctrl_IndicadorImpuesto(intIdIndicadorImpuesto);
        }

        public DataSet Ayuda_ctrl_IndicadorImpuesto()
        {
            return objDs.Ayuda_ctrl_IndicadorImpuesto();
        }

        public DataSet Combo_ctrl_IndicadorImpuesto()
        {
            return objDs.Combo_ctrl_IndicadorImpuesto();
        }

        public int Graba_ctrl_IndicadorImpuesto(Model.IndicadorImpuesto objIndicadorImpuesto)
        {
            return objDs.Graba_ctrl_IndicadorImpuesto(objIndicadorImpuesto);
        }

        public int Modifica_ctrl_IndicadorImpuesto(Model.IndicadorImpuesto objIndicadorImpuesto)
        {
            return objDs.Modifica_ctrl_IndicadorImpuesto(objIndicadorImpuesto);
        }

        public bool Elimina_ctrl_IndicadorImpuesto(int intIdIndicadorImpuesto)
        {
            return objDs.Elimina_ctrl_IndicadorImpuesto(intIdIndicadorImpuesto);
        }

        public DataTable Lista_ctrl_IndicadorImpuesto()
        {
            return objDs.Lista_ctrl_IndicadorImpuesto();
        }

        #endregion

        #region SolicitudViatico_OtroGasto
        public Model.SolicitudViatico_OtroGasto Recupera_SolicitudViatico_OtroGasto(int intIdSolicitudViatico_OtroGasto)
        {
            return objDs.Recupera_SolicitudViatico_OtroGasto(intIdSolicitudViatico_OtroGasto);
        }

        public int Graba_SolicitudViatico_OtroGasto(Model.SolicitudViatico_OtroGasto obj)
        {
            return objDs.Graba_SolicitudViatico_OtroGasto(obj);
        }

        public int Modifica_SolicitudViatico_OtroGasto(Model.SolicitudViatico_OtroGasto obj)
        {
            return objDs.Modifica_SolicitudViatico_OtroGasto(obj);
        }

        public bool Elimina_SolicitudViatico_OtroGasto(int intIdSolicitudViatico_OtroGasto)
        {
            return objDs.Elimina_SolicitudViatico_OtroGasto(intIdSolicitudViatico_OtroGasto);
        }

        public DataSet Lista_SolicitudViatico_OtroGasto(string strCodSolicitud)
        {
            return objDs.Lista_SolicitudViatico_OtroGasto(strCodSolicitud);
        }

        #endregion

        #region SolicitudViatico_Rendicion
        public Model.SolicitudViatico_Rendicion Recupera_SolicitudViatico_Rendicion(string intIdSolicitudViatico_Rendicion)
        {
            return objDs.Recupera_SolicitudViatico_Rendicion(intIdSolicitudViatico_Rendicion);
        }


        public int Graba_SolicitudViatico_Rendicion(Model.SolicitudViatico_Rendicion objLiquidacionViatico)
        {
            return objDs.Graba_SolicitudViatico_Rendicion(objLiquidacionViatico);
        }

        public int Modifica_SolicitudViatico_Rendicion(Model.SolicitudViatico_Rendicion objLiquidacionViatico)
        {
            return objDs.Modifica_SolicitudViatico_Rendicion(objLiquidacionViatico);
        }

        public bool Elimina_SolicitudViatico_Rendicion(int intIdSolicitudViatico_Rendicion)
        {
            return objDs.Elimina_SolicitudViatico_Rendicion(intIdSolicitudViatico_Rendicion);
        }

        public DataSet Lista_SolicitudViatico_Rendicion(string strCodSolicitud)
        {
            return objDs.Lista_SolicitudViatico_Rendicion(strCodSolicitud);
        }

        #endregion

        #region SolicitudViatico_Rendicion_Impuesto
        public Model.SolicitudViatico_Rendicion_Impuesto Recupera_SolicitudViatico_Rendicion_Impuesto(int intIdSolicitudViatico_Rendicion_Impuesto)
        {
            return objDs.Recupera_SolicitudViatico_Rendicion_Impuesto(intIdSolicitudViatico_Rendicion_Impuesto);
        }

        public int Graba_SolicitudViatico_Rendicion_Impuesto(Model.SolicitudViatico_Rendicion_Impuesto obj)
        {
            return objDs.Graba_SolicitudViatico_Rendicion_Impuesto(obj);
        }

        public int Modifica_SolicitudViatico_Rendicion_Impuesto(Model.SolicitudViatico_Rendicion_Impuesto obj)
        {
            return objDs.Modifica_SolicitudViatico_Rendicion_Impuesto(obj);
        }

        public bool Elimina_SolicitudViatico_Rendicion_Impuesto(int intIdSolicitudViatico_Rendicion_Impuesto)
        {
            return objDs.Elimina_SolicitudViatico_Rendicion_Impuesto(intIdSolicitudViatico_Rendicion_Impuesto);
        }

        public DataSet Lista_SolicitudViatico_Rendicion_Impuesto(int intIdSolicitudViatico_Rendicion)
        {
            return objDs.Lista_SolicitudViatico_Rendicion_Impuesto(intIdSolicitudViatico_Rendicion);
        }

        #endregion

        #region Concepto
        public Model.Concepto Recupera_msto_Concepto_Codigo(string strCodConcepto)
        {
            return objDs.Recupera_msto_Concepto_Codigo(strCodConcepto);
        }

        public Model.Concepto Recupera_msto_Concepto(int intIdConcepto)
        {
            return objDs.Recupera_msto_Concepto(intIdConcepto);
        }

        public DataSet Ayuda_msto_Concepto(string strCodTipoConcepto)
        {
            return objDs.Ayuda_msto_Concepto(strCodTipoConcepto);
        }

        public int Graba_msto_Concepto(Model.Concepto objConcepto)
        {
            return objDs.Graba_msto_Concepto(objConcepto);
        }

        public int Modifica_msto_Concepto(Model.Concepto objConcepto)
        {
            return objDs.Modifica_msto_Concepto(objConcepto);
        }

        public bool Elimina_msto_Concepto(int intIdConcepto)
        {
            return objDs.Elimina_msto_Concepto(intIdConcepto);
        }

        public DataSet Lista_msto_Concepto()
        {
            return objDs.Lista_msto_Concepto();
        }

        #endregion

        #region Destino
        public Model.Destino Recupera_msto_Empleado_Destino(string strCodTipoDestinoViaje,
                                                     string strCodEscalaViaje
                                                    )
        {
            return objDs.Recupera_msto_Empleado_Destino(strCodTipoDestinoViaje,
                                                  strCodEscalaViaje
                                                    );
        }

        #endregion

        #endregion

        #region EmpresaContratante
        public  DataSet Combo_EmpresaContratante()
        {
            return objDs.Combo_EmpresaContratante();
        }
        #endregion

        #region HojaTrabajo_PlanEstrategico

        public DataSet Ayuda_TipoInformacion(string strCodEmpresa)
        {
            return objDs.Ayuda_TipoInformacion(strCodEmpresa);
        }

        public DataSet Ayuda_SubTipoInformacion(string strCodEmpresa,
                                             string strCodTipoInformacion
                                            )
        {
            return objDs.Ayuda_SubTipoInformacion( strCodEmpresa,
                                                 strCodTipoInformacion
                                            );
        }


        public DataTable Combo_PeriodoInformacion_Mes(string strCodCompañia, string strAñoProceso)
        {
            return objDs.Combo_PeriodoInformacion_Mes(strCodCompañia, strAñoProceso);
        }
        public DataTable Combo_PeriodoInformacion_PO(string strCodCompañia)
        {
            return objDs.Combo_PeriodoInformacion_PO(strCodCompañia);
        }

        public int Recupera_PeriodoPresupuesto_IdCabecera_PO(string strCodCompañia,
                                          string strAñoProceso,
                                          string strMesProceso
                                        )
        {
            return objDs.Recupera_PeriodoPresupuesto_IdCabecera_PO(strCodCompañia,
                                          strAñoProceso,
                                          strMesProceso
                                        );
        }
        public DataSet Lista_HojaTrabajo_PO(string strCodCompañia,
                                        string strAñoProceso,
                                        string strMesProceso,
                                        string strCodTipoInformacion,
                                        string strCodSubTipoInformacion
                                    )
        {
            return objDs.Lista_HojaTrabajo_PO(strCodCompañia,
                                        strAñoProceso,
                                        strMesProceso,
                                        strCodTipoInformacion,
                                        strCodSubTipoInformacion
                                    );
        }
        public string[] GrabaHojaTrabajo_Detalle_PO(Model.PO_HojaTrabajo_Detalle obj)
        {
            return objDs.GrabaHojaTrabajo_Detalle_PO(obj);
        }

        public string[] ModificaHojaTrabajo_Detalle_PO(Model.PO_HojaTrabajo_Detalle obj)
        {
            return objDs.ModificaHojaTrabajo_Detalle_PO(obj);
        }

        public int GrabaHojaTrabajo_Detalle_Item_PO(Model.PO_HojaTrabajo_Detalle_Item obj)
        {
            return objDs.GrabaHojaTrabajo_Detalle_Item_PO(obj);
        }
        public int ModificaHojaTrabajo_Detalle_Item_PO(Model.PO_HojaTrabajo_Detalle_Item obj)
        {
            return objDs.ModificaHojaTrabajo_Detalle_Item_PO(obj);
        }
        public Boolean EliminaHojaTrabajo_Detalle_PO(int intIdDetalle)
        {
            return objDs.EliminaHojaTrabajo_Detalle_PO(intIdDetalle);
        }

        #endregion

    }
}

