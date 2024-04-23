using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Data
    {
        private Repository.Data objDs = new Repository.Data();

        //Repository.Data objDs = new Repository.Data();

        #region ACCESO

        #region Empresa
        public DataSet Combo_Empresa_DataTable()
        {
            return objDs.Combo_Empresa_DataTable();
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
        #region "TipoMoneda"
        public DataSet Ayuda_TipoMoneda()
        {
            return Ayuda_TipoMoneda();


        }
        public DataSet Combo_TipoMoneda()
        {
            return Combo_TipoMoneda();


        }
        public Model.TipoMoneda Recupera_TipoMoneda(int intIdTipoMoneda)
        {
            return Recupera_TipoMoneda(intIdTipoMoneda);
        }


        public Model.TipoMoneda Recupera_TipoMoneda_Codigo(string strCodTipoMoneda)
        {
            return Recupera_TipoMoneda_Codigo(strCodTipoMoneda);
        }

        public int Graba_TipoMoneda(Model.TipoMoneda obj)
        {
            return Graba_TipoMoneda(obj);
        }

        public int Modifica_TipoMoneda(Model.TipoMoneda obj)
        {
            return Modifica_TipoMoneda(obj);
        }

        public bool Elimina_TipoMoneda(int intIdTipoMoneda)
        {
            return Elimina_TipoMoneda(intIdTipoMoneda);
        }

        public DataSet Lista_TipoMoneda()
        {
            return Lista_TipoMoneda();
        }

        #endregion

        #region Concepto
        public DataSet Ayuda_Concepto()
        {
            return Ayuda_Concepto();
        }
        #endregion


        #region Contabilidad
        public DataSet Ayuda_PlanContable_Spring()
        {
            return Ayuda_PlanContable_Spring();
        }
        #endregion

        #region Formulacion

        public DataSet Combo_TipoDocumento_Formulacion()
        {
            return Combo_TipoDocumento_Formulacion();
        }

        public DataSet Combo_CentroGestor_Reporte(string strCodFuenteFinanciamiento)
        {
            return Combo_CentroGestor_Reporte(strCodFuenteFinanciamiento);
        }

        public DataSet Ayuda_CentroGestor_Reporte(string strCodFuenteFinanciamiento)
        {
            return Ayuda_CentroGestor_Reporte(strCodFuenteFinanciamiento);
        }


        public DataSet Combo_ClaseGasto()
        {
            return Combo_ClaseGasto();
        }

        public DataSet Combo_Tarea_FuenteFinanciamiento(string strCodCompañia,
                                                            string strCodProyecto
                                                          )
        {
            return Combo_Tarea_FuenteFinanciamiento(strCodCompañia,
                                                            strCodProyecto
                                                          );
        }

        public DataSet Combo_ClaseGasto_Clasificador(string strCodCompañia,
                                                        string strCodCentroGestor,
                                                        string strCodTipoFormulacion
                                                    )
        {
            return Combo_ClaseGasto_Clasificador( strCodCompañia,
                                                  strCodCentroGestor,
                                                  strCodTipoFormulacion
                                                    );
        }

        public DataSet Combo_ClaseGasto_Inversion(string strCodCompañia,
                                                  string strCodProyecto,
                                                  string strCodCentroGestor
                                                    )
        {
            return Combo_ClaseGasto_Inversion( strCodCompañia,
                                               strCodProyecto,
                                               strCodCentroGestor
                                                    );
        }

        public DataSet Combo_ClaseGasto_Otros(string strCodCompañia,
                                          string strCodProyecto,
                                          string strCodCentroGestor
                                            )
        {
            return Combo_ClaseGasto_Otros(strCodCompañia,
                                          strCodProyecto,
                                          strCodCentroGestor
                                            );
        }


        public DataSet Combo_ClaseGasto_Tarea(string strCodCompañia,
                                                  string strCodProyecto,
                                                  string strCodCentroGestor
                                                    )
        {
            return Combo_ClaseGasto_Tarea( strCodCompañia,
                                           strCodProyecto,
                                           strCodCentroGestor
                                                    );
        }

        public DataSet Ayuda_ClaseGasto()
        {
            return Ayuda_ClaseGasto();
        }

        public DataSet Ayuda_ClaseIngreso()
        {
            return Ayuda_ClaseIngreso();
        }

        public DataSet Combo_ClaseIngreso()
        {
            return Combo_ClaseIngreso();
        }

        public DataSet Combo_TipoFormulacion()
        {
            return Combo_TipoFormulacion();
        }


        public DataSet Combo_MetodoDistribucion()
        {
            return Combo_MetodoDistribucion();
        }
        public DataSet Ayuda_MetodoDistribucion()
        {
            return Ayuda_MetodoDistribucion();
        }
        #endregion

        #region Logistica
        public DataSet Lista_Proyecto_SaldoAñoAnterior(string strCodCompañia,
                                                        string strCodProyecto,
                                                        string strCodCentroGestor,
                                                        string strCodCentroCosto,
                                                        double dblImporte,
                                                        string strOrdenesElegidas
                             )
        {
            return Lista_Proyecto_SaldoAñoAnterior(strCodCompañia,
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
            return Lista_Proyecto_SaldoAñoAnterior_Clasificador( strCodCompañia,
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
            return Lista_Proyecto_IncorporaSaldoAñoAnterior_OS( strCodCompañia,
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
            return Lista_Proyecto_IncorporaSaldoAñoAnterior_OC( strCodCompañia,
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
            return Lista_Proyecto_IncorporaSaldoAñoAnterior_OS_Clasificador(strCodCompañia,
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
            return Lista_Proyecto_IncorporaSaldoAñoAnterior_OC_Clasificador( strCodCompañia,
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
            return Lista_Conformidad_Pago( strCodCompañia,
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
            return Formato_Conformidad(strCodCompañia,
                         strNumConformidad,
                         strTipoOrden,
                         strNumOrden
                     );
        }

        public DataSet Combo_UnidadMedida()
        {
            return Combo_UnidadMedida();
        }

        public DataSet Ayuda_UnidadMedida()
        {
            return Ayuda_UnidadMedida();
        }

        #endregion

        #region Gestion
        public DataSet Combo_Prioridad()
        {
            return Combo_Prioridad();
        }
        #endregion

        #region Patrimonio  
        public DataSet Ayuda_Marca()
        {
            return Ayuda_Marca();
        }

        public DataSet Ayuda_Color()
        {
            return Ayuda_Color();
        }

        public DataSet Ayuda_TipoDocumento(string strCodModulo)
        {
            return Ayuda_TipoDocumento( strCodModulo);
        }

        public DataSet Ayuda_Segmento()
        {
            return Ayuda_Segmento();
        }

        public DataSet Combo_Segmento_Sin_Almacen()
        {
            return Combo_Segmento_Sin_Almacen();
        }

        public DataSet Ayuda_Centro()
        {
            return Ayuda_Centro();
        }

        public DataSet Combo_Centro()
        {
            return Combo_Centro();
        }

        public DataSet Ayuda_Emplazamiento()
        {
            return Ayuda_Emplazamiento();
        }
        #endregion

        #region Aeropuerto
        public Model.Aeropuerto Recupera_msto_Aeropuerto_Codigo(string strCodAeropuerto)
        {
            return Recupera_msto_Aeropuerto_Codigo(strCodAeropuerto);
        }

        public DataSet Ayuda_msto_Aeropuerto()
        {
            return Ayuda_msto_Aeropuerto();
        }

        #endregion

        #region ClaseDocumento
        public Model.ClaseDocumento Recupera_ctrl_ClaseDocumento_Codigo(string strCodClaseDocumento)
        {
            return Recupera_ctrl_ClaseDocumento_Codigo( strCodClaseDocumento);
        }

        public Model.ClaseDocumento Recupera_ctrl_ClaseDocumento(int intIdDocumento)
        {
            return Recupera_ctrl_ClaseDocumento( intIdDocumento);
        }
        public DataSet Ayuda_ctrl_ClaseDocumento()
        {
            return Ayuda_ctrl_ClaseDocumento();
        }

        public int Graba_ctrl_ClaseDocumento(Model.ClaseDocumento objClaseDocumento)
        {
            return Graba_ctrl_ClaseDocumento( objClaseDocumento);
        }

        public int Modifica_ctrl_ClaseDocumento(Model.ClaseDocumento objClaseDocumento)
        {
            return Modifica_ctrl_ClaseDocumento( objClaseDocumento);
        }

        public bool Elimina_ctrl_ClaseDocumento(int intIdClaseDocumento)
        {
            return Elimina_ctrl_ClaseDocumento( intIdClaseDocumento);
        }

        public DataSet Lista_ctrl_ClaseDocumento()
        {
            return Lista_ctrl_ClaseDocumento();
        }

        #endregion

        #region TipoAcumulador
        public DataSet Ayuda_TipoAcumulador()
        {
            return Ayuda_TipoAcumulador();
        }
        public DataSet Lista_TipoAcumulador()
        {
            return Lista_TipoAcumulador();
        }

        public DataSet Naturaleza_TipoAcumulador()
        {
            return Naturaleza_TipoAcumulador();
        }

        public DataSet Combo_TipoAcumulador_Reporte()
        {
            return Combo_TipoAcumulador_Reporte();
        }

        public DataSet Combo_TipoAcumulador()
        {
            return Combo_TipoAcumulador();
        }
        public Model.TipoAcumulador Recupera_TipoAcumulador(int intIdTipoAcumulador)
        {
            return Recupera_TipoAcumulador( intIdTipoAcumulador);
        }

        public Model.TipoAcumulador Recupera_TipoAcumulador_codigo(string strCodTipoAcumulador)
        {
            return Recupera_TipoAcumulador_codigo( strCodTipoAcumulador);
        }
        public int Graba_TipoAcumulador(Model.TipoAcumulador obj)
        {
            return Graba_TipoAcumulador( obj);
        }
        public int Modifica_TipoAcumulador(Model.TipoAcumulador obj)
        {
            return Modifica_TipoAcumulador( obj);
        }

        public bool Elimina_TipoAcumulador(int intIdTipoAcumulador)
        {
            return Elimina_TipoAcumulador( intIdTipoAcumulador);
        }

        #endregion

        #region TipoRecurso
        public DataSet Ayuda_TipoRecurso()
        {
            return Ayuda_TipoRecurso();
        }
        public DataSet Lista_TipoRecurso()
        {
            return Lista_TipoRecurso();
        }

        public DataSet Naturaleza_TipoRecurso()
        {
            return Naturaleza_TipoRecurso();
        }

        public DataSet Combo_TipoRecurso_Reporte()
        {
            return Combo_TipoRecurso_Reporte();
        }

        public DataSet Combo_TipoRecurso()
        {
            return Combo_TipoRecurso();
        }
        public Model.TipoRecurso Recupera_TipoRecurso(int intIdTipoRecurso)
        {
            return Recupera_TipoRecurso( intIdTipoRecurso);
        }

        public Model.TipoRecurso Recupera_TipoRecurso_codigo(string strCodTipoRecurso)
        {
            return Recupera_TipoRecurso_codigo( strCodTipoRecurso);
        }
        public int Graba_TipoRecurso(Model.TipoRecurso obj)
        {
            return Graba_TipoRecurso( obj);
        }
        public int Modifica_TipoRecurso(Model.TipoRecurso obj)
        {
            return Modifica_TipoRecurso( obj);
        }

        public bool Elimina_TipoRecurso(int intIdTipoRecurso)
        {
            return Elimina_TipoRecurso( intIdTipoRecurso);
        }

        #endregion

        #region TipoTasa
        public DataSet Ayuda_TipoTasa()
        {
            return Ayuda_TipoTasa();
        }
        public DataSet Lista_TipoTasa()
        {
            return Lista_TipoTasa();
        }

        public DataSet Naturaleza_TipoTasa()
        {
            return Naturaleza_TipoTasa();
        }

        public DataSet Combo_TipoTasa_Reporte()
        {
            return Combo_TipoTasa_Reporte();
        }

        public DataSet Combo_TipoTasa()
        {
            return Combo_TipoTasa();
        }
        public Model.TipoTasa Recupera_TipoTasa(int intIdTipoTasa)
        {
            return Recupera_TipoTasa( intIdTipoTasa);
        }

        public Model.TipoTasa Recupera_TipoTasa_codigo(string strCodTipoTasa)
        {
            return Recupera_TipoTasa_codigo( strCodTipoTasa);
        }
        public int Graba_TipoTasa(Model.TipoTasa obj)
        {
            return Graba_TipoTasa( obj);
        }
        public int Modifica_TipoTasa(Model.TipoTasa obj)
        {
            return Modifica_TipoTasa( obj);
        }

        public bool Elimina_TipoTasa(int intIdTipoTasa)
        {
            return Elimina_TipoTasa( intIdTipoTasa);
        }

        #endregion

        #region TipoVoucher
        public DataSet Combo_TipoVoucher()
        {
            return Combo_TipoVoucher();
        }

        #endregion

        #region TipoDocumento
        public DataSet Combo_TipoDocumento()
        {
            return Combo_TipoDocumento();
        }
        public DataSet Combo_ctrl_TipoDocumento_DataTable(int intTipoTramite)
        {
            return Combo_ctrl_TipoDocumento_DataTable( intTipoTramite);
        }

        public string Recupera_mvto_CeGes_Sigla_Correlativo(string strSigla,
                                                             string strCodCeGes,
                                                             int intTipoDocumento,
                                                             int intAñoProceso)
        {
            return Recupera_mvto_CeGes_Sigla_Correlativo( strSigla,
                                                           strCodCeGes,
                                                           intTipoDocumento,
                                                            intAñoProceso);
        }

        public Model.TipoDocumento Recupera_TipoDocumento(int intTipoDocumento)
        {
            return Recupera_TipoDocumento( intTipoDocumento);
        }

        #endregion

        #region TipoDocumentoIdentidad
        public DataSet Combo_TipoDocumentoIdentidad_DataTable()
        {
            return Combo_TipoDocumentoIdentidad_DataTable();
        }

        public Model.TipoDocumentoIdentidad Recupera_TipoDocumentoIdentidad(int intTipoDocumentoIdentidad)
        {
            return Recupera_TipoDocumentoIdentidad( intTipoDocumentoIdentidad);
        }

        #endregion

        #region TipoContabilidad
        public DataSet Combo_TipoContabilidad()
        {
            return Combo_TipoContabilidad();
        }

        #endregion

        #region PeriodoProcesoContabilidad
        public DataSet Combo_PeriodoProceso_DataTable()
        {
            return Combo_PeriodoProceso_DataTable();
        }

        #endregion

        #region GrupoRecurso
        public DataSet Ayuda_GrupoRecurso()
        {
            return Ayuda_GrupoRecurso();
        }
        public DataSet Lista_GrupoRecurso()
        {
            return Lista_GrupoRecurso();
        }

        public DataSet Naturaleza_GrupoRecurso()
        {
            return Naturaleza_GrupoRecurso();
        }

        public DataSet Combo_GrupoRecurso_Reporte()
        {
            return Combo_GrupoRecurso_Reporte();
        }

        public DataSet Combo_GrupoRecurso()
        {
            return Combo_GrupoRecurso();
        }
        public Model.GrupoRecurso Recupera_GrupoRecurso(int intIdGrupoRecurso)
        {
            return Recupera_GrupoRecurso( intIdGrupoRecurso);
        }

        public Model.GrupoRecurso Recupera_GrupoRecurso_codigo(string strCodGrupoRecurso)
        {
            return Recupera_GrupoRecurso_codigo( strCodGrupoRecurso);
        }
        public int Graba_GrupoRecurso(Model.GrupoRecurso obj)
        {
            return Graba_GrupoRecurso( obj);
        }
        public int Modifica_GrupoRecurso(Model.GrupoRecurso obj)
        {
            return Modifica_GrupoRecurso( obj);
        }

        public bool Elimina_GrupoRecurso(int intIdGrupoRecurso)
        {
            return Elimina_GrupoRecurso( intIdGrupoRecurso);
        }

        #endregion

        #region Feriado
        public System.Data.DataSet Lista_Feriado_DataTable(int intAñoProceso)
        {
            return Lista_Feriado_DataTable( intAñoProceso);
        }

        public Model.Feriado Recupera_Feriado(int intAñoProceso,
                                                        string cFecha)
        {
            return Recupera_Feriado( intAñoProceso,
                                                        cFecha);
        }

        #endregion

        #region UbicacionGeografica
        public DataSet Ayuda_UbicacionGeografica()
        {
            return Ayuda_UbicacionGeografica();
        }

        public Model.Ubigeo Recupera_msto_Ubigeo_Codigo(string strCodUbigeo)
        {
            return Recupera_msto_Ubigeo_Codigo(strCodUbigeo);
        }

        public DataSet Ayuda_msto_Ubigeo()
        {
            return Ayuda_msto_Ubigeo();
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
            return graba_ProcesoLogistico_Requerimiento_Cabecera(strAñoProceso,
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
            return graba_ProcesoLogistico_Requerimiento_Detalle( intIdRequerimiento_Cabecera,
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
            return lista_ContratoConformidad_Formato(strCodCompañia,
                                                     strCodAdministradorContrato,
                                                     strCodCentrogestor
                                                         );
        }

        public DataSet formato_ContratoConformidad_Formato(string strCodCompañia,
                                                   string strNroContrato,
                                                   string strNroConformidad
                                                 )
        {
            return formato_ContratoConformidad_Formato( strCodCompañia,
                                                    strNroContrato,
                                                    strNroConformidad
                                                 );
        }


        public DataSet reporte_Conformidad_Pantalla(string strCodCompañia,
                                                    string strNroContrato,
                                                    string strNroConformidad
                                                   )
        {
            return reporte_Conformidad_Pantalla( strCodCompañia,
                                                 strNroContrato,
                                                 strNroConformidad
                                                   );
        }

        public DataSet reporte_Conformidad(string strCodCompañia,
                                         string strNroContrato
                                       )
        {
            return reporte_Conformidad( strCodCompañia,
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
            return reporte_Contrato( strCodCompañia,
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
            return ayuda_BuenaPro(strCodCompañia);
        }
        public Model.BuenaPro recupera_BuenaPro(string strCodCompañia,
                                                string strNroProceso
                                               )
        {
            return recupera_BuenaPro(strCodCompañia,
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
            return ayuda_Contrato( strCodCompañia,
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
            return lista_Contrato_Proyecto_Detalle_Saldo( strCodCompañia,
                                               strNroContrato,
                                               strCodFuenteDinanciamiento,
                                               strCodProyecto
                                 );
        }

        public DataSet lista_Contrato_Proyecto_Saldo(string strCodCompañia,
                                                      string strNroContrato,
                                                      string strCodFuenteDinanciamiento
                                         )
        {
            return lista_Contrato_Proyecto_Saldo( strCodCompañia,
                                                  strNroContrato,
                                                  strCodFuenteDinanciamiento
                                         );
        }

        public DataSet lista_Contrato_FuenteFinanciemiento_Saldo(string strCodCompañia,
                                           string strNroContrato
                                         )
        {
            return lista_Contrato_FuenteFinanciemiento_Saldo( strCodCompañia,
                                           strNroContrato
                                         );
        }


        public Model.ContratoCabecera recupera_Contrato(string strCodCompañia,
                                                          string strNroContrato
                                                         )
        {
            return recupera_Contrato(strCodCompañia,
                                     strNroContrato
                                                         );
        }


        public Model.ContratoCabecera graba_Contrato(Model.ContratoCabecera obj)
        {
            return graba_Contrato(obj);
        }

        public Model.ContratoCabecera modifica_Contrato(Model.ContratoCabecera obj,
                                                        string strCodAdministradorContrato_Anterior
                                                       )
        {
            return modifica_Contrato(obj,
                                     strCodAdministradorContrato_Anterior
                                                       );
        }
        public Boolean elimina_Contrato(Model.ContratoCabecera obj)
        {
            return elimina_Contrato(obj);
        }


        #endregion

        #region "Entidad Financiera"
        public DataSet ayuda_EntidadFinanciera(string strCodCompañia)
        {
            return ayuda_EntidadFinanciera(strCodCompañia);
        }
        #endregion

        #region "Tipo Observacion Adjunto"
        public DataSet combo_TipoObservacion_Adjunto(string strCodTipoArchivo)
        {
            return combo_TipoObservacion_Adjunto(strCodTipoArchivo);
        }
        #endregion

        #region "ClaseGarantia"
        public DataSet combo_ClaseGarantia()
        {
            return combo_ClaseGarantia();
        }

        public Model.ClaseGarantia recupera_ClaseGarantia_Codigo(string strCodClaseGarantia)
        {
            return recupera_ClaseGarantia_Codigo(strCodClaseGarantia);
        }

        #endregion

        #region "TipoGarantia"
        public DataSet combo_TipoGarantia()
        {
            return combo_TipoGarantia();
        }

        public Model.TipoGarantia recupera_TipoGarantia_Codigo(string strCodTipoGarantia)
        {
            return recupera_TipoGarantia_Codigo(strCodTipoGarantia);
        }

        #endregion

        #region "Parametro Logistica"
        public Model.ParametroLogistica Recupera_ParametroLogistica_Codigo(string strCodParametroLogistica)
        {
            return Recupera_ParametroLogistica_Codigo(strCodParametroLogistica);
        }
    #endregion

        #region "TipoContrato"
        public DataSet combo_TipoContrato()
        {
            return combo_TipoContrato();
        }

        public Model.TipoContrato recupera_TipoContrato_Codigo(string strCodTipoContrato)
        {
            return recupera_TipoContrato_Codigo(strCodTipoContrato);
        }

        #endregion

        #region "TipoAnticipo"
        public DataSet combo_TipoAnticipo()
        {
            return combo_TipoAnticipo();
        }

        public Model.TipoAnticipo recupera_TipoAnticipo_Codigo(string strCodTipoAnticipo)
        {
            return recupera_TipoAnticipo_Codigo(strCodTipoAnticipo);
        }

        #endregion

        #region "TipoDocumento"
        public DataSet combo_TipoDocumento(bool blnEsDocumentoTributario
                                           )
        {
            return combo_TipoDocumento(blnEsDocumentoTributario);
        }

        public DataSet combo_TipoDocumento_Filtro(bool blnEsDocumentoTributario,
                                                  string strFiltro
                                   )
        {
            return combo_TipoDocumento_Filtro( blnEsDocumentoTributario,
                                              strFiltro
                                   );
        }


        public Model.TipoDocumento recupera_TipoDocumento_Codigo(int intTipodocumento)
        {
            return recupera_TipoDocumento_Codigo(intTipodocumento);
        }

        #endregion

        #region "TipoImpuesto"
        public DataSet combo_TipoImpuesto()
        {
            return combo_TipoImpuesto();
        }

        public Model.TipoImpuesto recupera_TipoImpuesto_Codigo(string strCodTipoDocumento)
        {
            return recupera_TipoImpuesto_Codigo(strCodTipoDocumento);
        }

        #endregion

        #region "Conformidad"

        public Boolean firma_Conformidad(string strCodCompañia,
                                            string strCodCentroGestor,
                                            string strNroConformidad,
                                            string strCodEmpleado
                                        )
        {
            return firma_Conformidad( strCodCompañia,
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
            return lista_Conformidad_Adjuntos_Consulta( strCodCompañia,
                                                    strNroConformidad,
                                                    strCodTipoAdjunto
                                                 );
        }
        public Model.Conformidad graba_Conformidad(Model.Conformidad obj)
        {
            return graba_Conformidad(obj);
        }

        public Model.ConformidadAdjunto graba_ConformidadAdjunto(Model.ConformidadAdjunto obj)
        {
            return graba_ConformidadAdjunto(obj);
        }
        public Model.ConformidadDocumentoTributario graba_ConformidadDocumentoTributario(Model.ConformidadDocumentoTributario obj)
        {
            return graba_ConformidadDocumentoTributario(obj);
        }
        public Model.ConformidadProyecto graba_ConformidadProyecto(Model.ConformidadProyecto obj)
        {
            return graba_ConformidadProyecto(obj);
        }

        public DataSet lista_Conformidad_Proyecto(string strCodCompañia,
                                                   string strNroContrato
                                                 )
        {
            return lista_Conformidad_Proyecto( strCodCompañia,
                                               strNroContrato
                                                 );
        }

        public Model.ConformidadPenalidad graba_ConformidadPenalidad(Model.ConformidadPenalidad obj
                                                  )
        {
            return graba_ConformidadPenalidad(obj);
        }

        public Model.Conformidadgarantia graba_ConformidadGarantia(Model.Conformidadgarantia obj
                                                  )
        {
            return graba_ConformidadGarantia( obj );
        }

        public Model.ConformidadRetencion graba_ConformidadRetencion(Model.ConformidadRetencion obj
                                          )
        {
            return graba_ConformidadRetencion(obj);
        }

        public Model.ConformidadAjustePolinomico graba_ConformidadAjustePolinomico(Model.ConformidadAjustePolinomico obj
                                  )
        {
            return graba_ConformidadAjustePolinomico(obj);
        }


        #endregion

        #region "Entregable"

        public DataSet lista_ContratoEntregable(string strCodCompañia,
                                                string strNroContrato
                                              )
        {
            return lista_ContratoEntregable( strCodCompañia,
                                              strNroContrato
                                              );
        }
        public Model.EntregableCabecera insertar_EntregableCabecera(Model.EntregableCabecera obj)
        {
            return insertar_EntregableCabecera(obj);
        }

        public bool modificar_EntregableCabecera(Model.EntregableCabecera obj)
        {
            return modificar_EntregableCabecera(obj);
        }

        public bool eliminar_EntregableCabecera(Model.EntregableCabecera obj)
        {
            return eliminar_EntregableCabecera( obj);
        }
        public Model.EntregableCabecera recupera_EntregableCabecera(int intIdEntregableCabecera)
        {
            return recupera_EntregableCabecera(intIdEntregableCabecera);
        }

        public Model.EntregableCabecera recupera_EntregableCabecera_Codigo(string strCodCompañia,
                                                                            string strNroContrato,
                                                                            string strNroEntregable
                                                                          )
        {
            return recupera_EntregableCabecera_Codigo(strCodCompañia,
                                                                            strNroContrato,
                                                                            strNroEntregable
                                                                          );
        }

        public DataSet lista_EntregableCabecera(string strCodCompañia,
                                                    string strNroContrato)
        {
            return lista_EntregableCabecera(strCodCompañia,
                                            strNroContrato);
        }

        public DataSet ayuda_EntregableCabecera(string strCodCompañia,
                                            string strNroContrato)
        {
            return ayuda_EntregableCabecera(strCodCompañia,
                                            strNroContrato);
        }

        #endregion

        #region "Adenda"

        public Model.adenda recupera_ContratoAdicional_Codigo(string strCodCompañia,
                                                              string strNroContrato,
                                                              string strCodAdenda
                                                             )
        {
            return recupera_ContratoAdicional_Codigo(strCodCompañia,
                                                              strNroContrato,
                                                               strCodAdenda
                                                             );
        }
        public Model.adenda recupera_ContratoAdicional(int intIdAdenda
                                                      )
        {
            return recupera_ContratoAdicional(intIdAdenda
                                                      );
        }
        public Model.adenda insertar_ContratoAdicional(Model.adenda obj)
        {
            return insertar_ContratoAdicional(obj);
        }

        public bool modificar_ContratoAdicional(Model.adenda obj)
        {
            return modificar_ContratoAdicional(obj);
        }

        public bool eliminar_ContratoAdicionl(Model.adenda obj)
        {
            return eliminar_ContratoAdicionl(obj);
        }
        public DataSet lista_ContratoAdicional(string strCodCompañia,
                                               string strNroContrato
                                              )
        {
            return lista_ContratoAdicional( strCodCompañia,
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
            return recupera_ContratoAnticipo_Codigo(strCodCompañia,
                                                               strNroContrato,
                                                               strCodAnticipo
                                                             );
        }
        public Model.ContratoAnticipo recupera_ContratoAnticipo(int intIdAnticipo
                                                      )
        {
            return recupera_ContratoAnticipo(intIdAnticipo);
        }
        public Model.ContratoAnticipo insertar_ContratoAnticipo(Model.ContratoAnticipo obj)
        {
            return insertar_ContratoAnticipo(obj);
        }

        public bool modificar_ContratoAdicional(Model.ContratoAnticipo obj)
        {
            return modificar_ContratoAdicional(obj);
        }

        public bool eliminar_ContratoAnticipo(Model.ContratoAnticipo obj)
        {
            return eliminar_ContratoAnticipo(obj);
        }
        public DataSet lista_ContratoAnticipo(string strCodCompañia,
                                               string strNroContrato
                                              )
        {
            return lista_ContratoAnticipo( strCodCompañia,
                                                strNroContrato
                                              );
        }
        #endregion

        #region "Tipo Adicional"
        public DataSet combo_TipoAdicional()
        {
            return combo_TipoAdicional();
        }
        #endregion

        #region "Garantia"

        public DataSet ayuda_ContratoGarantia(string strCodCompañia,
                                               string strNroContrato
                                             )
        {
            return ayuda_ContratoGarantia( strCodCompañia,
                                           strNroContrato
                                             );
        }
        public DataSet lista_ContratoGarantia(string strCodCompañia,
                                                string strNroContrato
                                             )
        {
            return lista_ContratoGarantia( strCodCompañia,
                                           strNroContrato
                                             );
        }

        public Model.ContratoGarantia recupera_ContratoGarantia_Codigo(string strCodCompañia,
                                                                string strNroContrato,
                                                                string strNroGarantia
                                                               )
        {
            return recupera_ContratoGarantia_Codigo(strCodCompañia,
                                                    strNroContrato,
                                                    strNroGarantia
                                                               );
        }
        public Model.ContratoGarantia recupera_ContratoGarantia(int intIdContrato_Garantia)
        {
            return recupera_ContratoGarantia(intIdContrato_Garantia);
        }
        public Model.ContratoGarantia graba_ContratoGarantia(Model.ContratoGarantia obj
                                                            )
        {
            return graba_ContratoGarantia(obj);
        }

        public Model.ContratoGarantia modifica_ContratoGarantia(Model.ContratoGarantia obj
                                                    )
        {
            return modifica_ContratoGarantia(obj);
        }
        public Boolean elimina_ContratoGarantia(Model.ContratoGarantia obj
                                            )
        {
            return elimina_ContratoGarantia(obj);
        }


        #endregion

        #region "Inicio Actividad"

        public DataSet lista_ContratoInicioActividad(string strCodCompañia,
                                                string strNroContrato
                                             )
        {
            return lista_ContratoInicioActividad( strCodCompañia,
                                                 strNroContrato
                                             );
        }

        public Model.ContratoInicioActividad graba_ContratoInicioActividad(Model.ContratoInicioActividad obj
                                                            )
        {
            return graba_ContratoInicioActividad(obj);
        }

        public Model.ContratoInicioActividad modifica_ContratoInicioActividad(Model.ContratoInicioActividad obj
                                                            )
        {
            return modifica_ContratoInicioActividad(obj);
        }
        public Boolean elimina_ContratoInicioActividad(Model.ContratoInicioActividad obj
                                            )
        {
            return elimina_ContratoInicioActividad(obj);
        }


        #endregion

        #endregion


        #region "Viatico"
        public List<Model.Viatico> recupera_Viatico_App(string strCodEmpleado)
        {
            return recupera_Viatico_App( strCodEmpleado);
        }

        private Model.Viatico GetViaticoDataTableRow(DataRow dr)
        {
            return GetViaticoDataTableRow(dr);
        }

        public Model.Viatico_Paso graba_Viatico_Firma_App(string strNumeroProceso)
        {
            return graba_Viatico_Firma_App( strNumeroProceso);
        }


        private Model.Viatico_Paso GetViaticoPasoDataTableRow(DataRow dr)
        {
            return GetViaticoPasoDataTableRow(dr);
        }


        #endregion


        #region "CajaChica"
        public List<Model.CajaChica> recupera_CajaChica_App(string strCodEmpleado)
        {
            return recupera_CajaChica_App( strCodEmpleado);
        }

        private Model.CajaChica GetCajaChicaDataTableRow(DataRow dr)
        {
            return GetCajaChicaDataTableRow( dr);
        }

        public Model.CajaChica_Paso graba_CajaChica_Firma_App(string strNumeroProceso)
        {
            return graba_CajaChica_Firma_App( strNumeroProceso);
        }

        private Model.CajaChica_Paso GetCajaChicaPasoDataTableRow(DataRow dr)
        {
            return GetCajaChicaPasoDataTableRow(dr);
        }


        #endregion


        #region "FichaPresupuestal"
        public List<Model.FichaPresupuestal> recupera_FichaPresupuestal_App(string strCodEmpresa)
        {
            return recupera_FichaPresupuestal_App( strCodEmpresa);
        }

        private Model.FichaPresupuestal GetFichaDataTableRow(DataRow dr)
        {
            return GetFichaDataTableRow( dr);
        }

        public Model.FichaPresupuestal_Paso graba_FichaPresupuestal_Firma_App(string strNumProcedimiento)
        {
            return graba_FichaPresupuestal_Firma_App( strNumProcedimiento);
        }


        private Model.FichaPresupuestal_Paso GetPasoDataTableRow(DataRow dr)
        {
            return GetPasoDataTableRow( dr);
        }


        #endregion

        #region "ProcesoLogistico_Aprobacion"

        public DataSet lista_ProcesoLogistico_CreaProceso_Detalle(string strNumRequerimiento)
        {
            return lista_ProcesoLogistico_CreaProceso_Detalle( strNumRequerimiento);
        }
        public DataSet lista_ProcesoLogistico_CreaProceso(string strCodOperadorLogistico)
        {
            return lista_ProcesoLogistico_CreaProceso( strCodOperadorLogistico);
        }

        public DataSet lista_ProcesoLogistico_Aprobacion(string strEstado)
        {
            return lista_ProcesoLogistico_Aprobacion( strEstado);
        }

        public bool graba_procesoLogistico_Aprobacion_DescarteFirma(string strNumRequerimiento,
                                                                      string strCodMotivoDescarte,
                                                                      DateTime dtpFecDescarte,
                                                                      string strNotaDescarte,
                                                                      string strCodEmpleado
                                                                    )
        {
            return graba_procesoLogistico_Aprobacion_DescarteFirma( strNumRequerimiento,
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
            return graba_procesoLogistico_Aprobacion_Firma( strCodCentroGestor,
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
            return graba_ProcesoLogistico_FichaPresupuestal( obj);
        }
        #endregion

        #region "ValorEstimado"

        public Model.ValorEstimado recupera_ValorEstimado_Codigo(string strCodEmpresa,
                                                                 string strAñoProceso,
                                                                 string strNumProcedimiento
                                                                )
        {
            return recupera_ValorEstimado_Codigo( strCodEmpresa,
                                                  strAñoProceso,
                                                  strNumProcedimiento
                                                                );
        }
        public Model.ValorEstimado recupera_ValorEstimado(int intIdValorEstimado)
        {
            return recupera_ValorEstimado( intIdValorEstimado);
        }

        public DataSet lista_ValorEstimado(string strCodEmpresa,
                                            string strAñoProceso,
                                         string strNumProcedimiento
                                        )
        {
            return lista_ValorEstimado( strCodEmpresa,
                                        strAñoProceso,
                                        strNumProcedimiento
                                        );
        }

        public bool graba_ValorEstimado_Cronograma(Model.ValorEstimado_Cronograma obj)
        {
            return graba_ValorEstimado_Cronograma(obj);
        }

        public int graba_ValorEstimado(Model.ValorEstimado obj)
        {
            return graba_ValorEstimado( obj);
        }

        public Boolean modifica_ValorEstimado(Model.ValorEstimado obj)
        {
            return modifica_ValorEstimado(obj);
        }

        public Boolean elimina_ValorEstimado(int intIdValorEstimado)
        {
            return elimina_ValorEstimado(intIdValorEstimado);
        }

        #endregion

        #region "Proveedor"

        public DataSet ayuda_Proveedor_Invitacion(string strCodEmpresa,
                                                  string strNumProcedimiento,
                                                  string strNumRequerimiento
                                                 )
        {
            return ayuda_Proveedor_Invitacion( strCodEmpresa,
                                               strNumProcedimiento,
                                               strNumRequerimiento
                                                 );
        }
        public DataSet ayuda_Proveedor(string strCodEmpresa)
        {
            return ayuda_Proveedor(strCodEmpresa);
        }

        public Model.Proveedor recupera_Proveedor_Codigo(string strCodEmpresa,
                                                 string strCodProveedor
                                                )
        {
            return recupera_Proveedor_Codigo( strCodEmpresa,
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
            return ayuda_Invitacion( strCodEmpresa,
                                     strNumProcedimiento,
                                     strNumRequerimiento
                                        );
        }
        public Model.Invitacion recupera_Invitacion(int intIdInvitacion)
        {
            return recupera_Invitacion(intIdInvitacion);
        }

        public DataSet lista_Invitacion(string strCodEmpresa,
                                         string strNumProcedimiento,
                                         string strNumRequerimiento
                                        )
        {
            return lista_Invitacion( strCodEmpresa,
                                     strNumProcedimiento,
                                     strNumRequerimiento
                                        );
        }

        public int graba_Invitacion(Model.Invitacion obj)
        {
            return graba_Invitacion(obj);
        }

        public Boolean modifica_Invitacion(Model.Invitacion obj)
        {
            return modifica_Invitacion(obj);
        }

        public Boolean elimina_Invitacion(int intIdInvitacion)
        {
            return elimina_Invitacion(intIdInvitacion);
        }

        #endregion

        #region "Cotizacion"

        public DataSet ayuda_Cotizacion(string strCodEmpresa,
                                         string strNumProcedimiento
                                        )
        {
            return ayuda_Cotizacion( strCodEmpresa,
                                     strNumProcedimiento
                                        );
        }
        public Model.Cotizacion recupera_Cotizacion(int intIdCotizacion)
        {
            return recupera_Cotizacion(intIdCotizacion);
        }

        public DataSet lista_Cotizacion(string strCodEmpresa,
                                         string strNumProcedimiento
                                        )
        {
            return lista_Cotizacion( strCodEmpresa,
                                     strNumProcedimiento
                                        );
        }

        public int graba_Cotizacion(Model.Cotizacion obj)
        {
            return graba_Cotizacion(obj);
        }

        public Boolean modifica_Cotizacion(Model.Cotizacion obj)
        {
            return modifica_Cotizacion(obj);
        }

        public Boolean elimina_Cotizacion(int intIdCotizacion)
        {
            return elimina_Cotizacion(intIdCotizacion);
        }

        #endregion

        #region "OperadorLogistico"
        public DataSet Ayuda_OperadorLogistico_Reemplazo(string strCodOperadorLogistico)
        {
            return Ayuda_OperadorLogistico_Reemplazo(strCodOperadorLogistico);
        }

        public DataSet Ayuda_OperadorLogistico()
        {
            return Ayuda_OperadorLogistico();
        }

        public DataSet Ayuda_OperadorLogistico_Jefatura(string strCodJefatura)
        {
            return Ayuda_OperadorLogistico_Jefatura(strCodJefatura);
        }
        public DataSet Lista_OperadorLogistico()
        {
            return Lista_OperadorLogistico();
        }

        public int Graba_OperadorLogistico(Model.OperadorLogistico obj)
        {
            return Graba_OperadorLogistico(obj);
        }

        public int Modifica_OperadorLogistico(Model.OperadorLogistico obj)
        {
            return Modifica_OperadorLogistico(obj);
        }

        public bool Elimina_OperadorLogistico(int intIdEmpleado)
        {
            return Elimina_OperadorLogistico(intIdEmpleado);
        }

        #endregion

        #region "CargoComite"
        public DataSet Combo_CargoComite()
        {
            return Combo_CargoComite();
        }

        #endregion

        #region "TipoIntegrante"
        public DataSet Combo_TipoIntegrante()
        {
            return Combo_TipoIntegrante();
        }

        #endregion

        #region "TipoPaso"
        public DataSet Combo_TipoPaso()
        {
            return Combo_TipoPaso();
        }

        #endregion

        #region "TipoComite"
        public DataSet Combo_TipoComite()
        {
            return Combo_TipoPaso();
        }

        #endregion

        #region "TipoPlantilla_Paso"
        public DataSet Combo_TipoPlantilla()
        {
            return Combo_TipoPlantilla();
        }

        public Model.TipoPlantillaPaso Recupera_TipoPlantilla(int intIdTipoPlantilla
                                                             )
        {
            return Recupera_TipoPlantilla(intIdTipoPlantilla
                                                             );
        }

        public Model.TipoPlantillaPaso Recupera_TipoPlantilla_Codigo(int strCodTipoPlantilla
                                                             )
        {
            return Recupera_TipoPlantilla_Codigo(strCodTipoPlantilla
                                                             );
        }

        public int Graba_TipoPlantilla(Model.TipoPlantillaPaso obj
                                                     )
        {
            return Graba_TipoPlantilla(obj);
        }

        public int Modifica_TipoPlantilla(Model.TipoPlantillaPaso obj
                                                     )
        {
            return Modifica_TipoPlantilla(obj
                                                     );
        }

        public Boolean Elimina_TipoPlantilla(int intIdTipoPlantilla)
        {
            return Elimina_TipoPlantilla(intIdTipoPlantilla);
        }

        public DataSet Lista_TipoPlantilla()
        {
            return Lista_TipoPlantilla();
        }

        #endregion

        #region "TipoProceso_Duracion"
        public DataSet Lista_TipoProceso_Duracion(string strAñoProceso,
                                            string strCodTipoProceso,
                                            string strCodObjetoContratacion
                                           )
        {
            return Lista_TipoProceso_Duracion( strAñoProceso,
                                            strCodTipoProceso,
                                            strCodObjetoContratacion
                                           );
        }

        public Model.TipoProceso_Duracion Recupera_TipoProceso_Duracion(int intIdTipoProceso_Duracion)
        {
            return Recupera_TipoProceso_Duracion(intIdTipoProceso_Duracion);
        }
        public int[] Graba_TipoProceso_Duracion(Model.TipoProceso_Duracion obj)
        {
            return Graba_TipoProceso_Duracion(obj);
        }
        public int Modifica_TipoProceso_Duracion(Model.TipoProceso_Duracion obj)
        {
            return Modifica_TipoProceso_Duracion(obj);
        }

        public bool Elimina_TipoProceso_Duracion(int intIdTipoProceso_Duracion)
        {
            return Elimina_TipoProceso_Duracion(intIdTipoProceso_Duracion);
        }

        #endregion

        #region "Comite"
        public DataSet Lista_Comite(int intIdDocumentoComite)
        {
            return Lista_Comite(intIdDocumentoComite);
        }

        public Model.Comite Recupera_Comite(int intIdComite)
        {
            return Recupera_Comite(intIdComite);
        }
        public int Graba_Comite(Model.Comite obj)
        {
            return Graba_Comite(obj);
        }
        public int Modifica_Comite(Model.Comite obj)
        {
            return Modifica_Comite(obj);
        }

        public bool Elimina_Comite(int intIdComite)
        {
            return Elimina_Comite(intIdComite);
        }

        #endregion

        #region "Comite_Integrante"
        public DataSet Ayuda_Comite_Integrante(string strAñoProceso)
        {
            return Ayuda_Comite_Integrante(strAñoProceso);
        }
        public DataSet Lista_Comite_Integrante_Pac(string strAñoProceso,
                                                     string strCodIntegrante
                                                    )
        {
            return Lista_Comite_Integrante_Pac(strAñoProceso,
                                               strCodIntegrante
                                                    );
        }
        public DataSet Lista_Comite_Integrante(int intIdComite)
        {
            return Lista_Comite_Integrante(intIdComite);
        }

        public DataSet Lista_Comite_Integrante_Procedimiento(string strNumProcedimiento)
        {
            return Lista_Comite_Integrante_Procedimiento(strNumProcedimiento);
        }


        public Model.Comite_Integrante Recupera_Comite_Integrante(int intIdComite_Integrante)
        {
            return Recupera_Comite_Integrante(intIdComite_Integrante);
        }


        public int Graba_Comite_Integrante(Model.Comite_Integrante obj)
        {
            return Graba_Comite_Integrante(obj);
        }
        public int Modifica_Comite_Integrante(Model.Comite_Integrante obj)
        {
            return Modifica_Comite_Integrante(obj);
        }
        public bool Elimina_Comite_Integrante(int intIdComite_Integrante)
        {
            return Elimina_Comite_Integrante(intIdComite_Integrante);
        }

        #endregion

        #region "Comite_Integrnte_Reemplazo"
        public int Graba_Comite_Integrante_Reemplazo(Model.Comite_Integrante_Reemplazo obj)
        {
            return Graba_Comite_Integrante_Reemplazo(obj);
        }

        #endregion

        #region "Comite_Resolucion"
        public DataSet Combo_ComiteResolucion()
        {
            return Combo_ComiteResolucion();
        }
        public DataSet Combo_Comite_Resolucion_AñoProceso()
        {
            return Combo_Comite_Resolucion_AñoProceso();
        }
        public DataSet combo_Comite_Resolucion_NumDocumento(string strAñoProceso)
        {
            return combo_Comite_Resolucion_NumDocumento(strAñoProceso);
        }

        public DataSet Lista_Comite_Resolucion()
        {
            return Lista_Comite_Resolucion();
        }
        public Model.Comite_Resolucion Recupera_Comite_Resolucion(int intIdDocumentoComite)
        {
            return Recupera_Comite_Resolucion(intIdDocumentoComite);
        }
        public int Graba_Comite_Resolucion(Model.Comite_Resolucion obj)
        {
            return Graba_Comite_Resolucion(obj);
        }
        public int Modifica_Comite_Resolucion(Model.Comite_Resolucion obj)
        {
            return Modifica_Comite_Resolucion(obj);
        }

        public bool Elimina_Comite_Resolucion(int intIdDocumentoComite)
        {
            return Elimina_Comite_Resolucion(intIdDocumentoComite);
        }

        #endregion

        #region "CondicionComite"
        public DataSet Combo_CondicionComite()
        {
            return Combo_CondicionComite();
        }

        #endregion

        #region "Paso"
        public DataSet Lista_Paso(string strCodTipoPlantilla)
        {
            return Lista_Paso(strCodTipoPlantilla);
        }

        public DataSet Combo_Paso_Reporte(string strCodTipoPlantilla)
        {
            return Combo_Paso_Reporte(strCodTipoPlantilla);
        }

        public DataSet Combo_Paso(string strCodTipoPlantilla)
        {
            return Combo_Paso(strCodTipoPlantilla);
        }
        public Model.Paso Recupera_Paso(int intIdPaso)
        {
            return Recupera_Paso(intIdPaso);
        }

        public Model.Paso Recupera_Paso_codigo(string strCodTipoPlantilla,
                                                 string strCodPaso
                                               )
        {
            return Recupera_Paso_codigo(strCodTipoPlantilla,
                                        strCodPaso
                                               );
        }
        public int Graba_Paso(Model.Paso obj)
        {
            return Graba_Paso(obj);
        }
        public int Modifica_Paso(Model.Paso obj)
        {
            return Modifica_Paso(obj);
        }

        public bool Elimina_Paso(int intIdPaso)
        {
            return Elimina_Paso(intIdPaso);
        }

        #endregion

        #region "TipoDocumento_ProcesoLogistico"
        public DataSet Ayuda_TipoDocumento_ProcesoLogistico()
        {
            return Ayuda_TipoDocumento_ProcesoLogistico();
        }
        public DataSet Combo_TipoDocumento_ProcesoLogistico()
        {
            return Combo_TipoDocumento_ProcesoLogistico();
        }

        #endregion

        #region "ProcesoLogistico_Version"
        public DataSet Combo_AñoProceso_Logistica()
        {
            return Combo_AñoProceso_Logistica();
        }

        public DataSet Combo_Version_Logistica(string strAñoProceso)
        {
            return Combo_Version_Logistica(strAñoProceso);
        }

        public Model.ProcesoLogistico_Version Recupera_Version_Logistica()
        {
            return Recupera_Version_Logistica();
        }

        #endregion

        #region "ProcesoLogistico_Paso_Cierre"
        public int Graba_ProcesoLogistico_Paso_Cierre(Model.ProcesoLogistico_Paso_Cierre obj)
        {
            return Graba_ProcesoLogistico_Paso_Cierre(obj);
        }

        #endregion

        #region "ProcesoLogistico_Paso_CambioEstado"
        public DataSet Recupera_ProcesoLogistico_Paso_CambiaEstado(string strNumProcedimiento)
        {
            return Recupera_ProcesoLogistico_Paso_CambiaEstado(strNumProcedimiento);
        }
        public int Graba_ProcesoLogistico_Paso_CambioEstado(Model.ProcesoLogistico_Paso_CambioEstado obj)
        {
            return Graba_ProcesoLogistico_Paso_CambioEstado(obj);
        }

        #endregion

        #region "ProcesoLogistico_Paso_Apertura"
        public Model.ProcesoLogistico_Paso_Apertura Recupera_ProcesoLogistico_Paso_Apertura(int intIdProcesoLogistico_Paso_Apertura)
        {
            return Recupera_ProcesoLogistico_Paso_Apertura(intIdProcesoLogistico_Paso_Apertura);
        }

        public DateTime[] Recupera_ProcesoLogistico_Paso_Apertura_Inicio(string strNumProcedimiento)
        {
            return Recupera_ProcesoLogistico_Paso_Apertura_Inicio(strNumProcedimiento);
        }

        public DateTime[] Recupera_ProcesoLogistico_Paso_Apertura_Proceso(string strNumProcedimiento,
                                                                          string strCodTipoPlantilla,
                                                                          string strCodPaso
                                                                         )
        {
            return Recupera_ProcesoLogistico_Paso_Apertura_Proceso(strNumProcedimiento,
                                                                    strCodTipoPlantilla,
                                                                    strCodPaso
                                                                         );
        }


        public int Graba_ProcesoLogistico_Paso_Apertura(Model.ProcesoLogistico_Paso_Apertura objPA,
                                                        Model.ProcesoLogistico_Paso objP
                                                       )
        {
            return Graba_ProcesoLogistico_Paso_Apertura(objPA,
                                                        objP
                                                       );
        }

        public int Graba_ProcesoLogistico_Paso_Apertura_Inicio(Model.ProcesoLogistico_Paso objP,
                                                               Model.ProcesoLogistico_Paso_Apertura objPA
                                                              )
        {
            return Graba_ProcesoLogistico_Paso_Apertura_Inicio(objP,
                                                               objPA
                                                              );
        }

        #endregion

        #region "ProcesoLogistico_Paso_Adjunto"
        public DataSet Lista_ProcesoLogistico_Paso_Adjunto(string strNumProcedimiento, string strCodPaso)
        {
            return Lista_ProcesoLogistico_Paso_Adjunto( strNumProcedimiento, strCodPaso);
        }

        public DataSet Lista_ProcesoLogistico_Paso_Adjunto_Consulta(string strNumProcedimiento, string strCodPaso)
        {
            return Lista_ProcesoLogistico_Paso_Adjunto_Consulta( strNumProcedimiento, strCodPaso);
        }

        public Model.ProcesoLogistico_Paso_Adjunto Recupera_ProcesoLogistico_Paso_Adjunto(int intIdAdjunto)
        {
            return Recupera_ProcesoLogistico_Paso_Adjunto(intIdAdjunto);
        }
        public int Graba_ProcesoLogistico_Paso_Adjunto(Model.ProcesoLogistico_Paso_Adjunto obj)
        {
            return Graba_ProcesoLogistico_Paso_Adjunto(obj);
        }
        public int Modifica_ProcesoLogistico_Paso_Adjunto(Model.ProcesoLogistico_Paso_Adjunto obj)
        {
            return Modifica_ProcesoLogistico_Paso_Adjunto(obj);
        }

        public bool Elimina_ProcesoLogistico_Paso_Adjunto(int intIdAdjunto)
        {
            return Elimina_ProcesoLogistico_Paso_Adjunto(intIdAdjunto);
        }

        #endregion

        #region "ProcesoLogistico_Paso"
        public DataSet Combo_EstadoAperturaPaso()
        {
            return Combo_EstadoAperturaPaso();
        }
        public DataSet Lista_ProcesoLogistico_Paso(string strAñoProceso,
                                                 string strNumProcedimiento
                                                )
        {
            return Lista_ProcesoLogistico_Paso(strAñoProceso,
                                               strNumProcedimiento
                                                );
        }
        public Model.ProcesoLogistico_Paso Recupera_ProcesoLogistico_Paso(int intIdProcesoLogistico_Paso)
        {
            return Recupera_ProcesoLogistico_Paso(intIdProcesoLogistico_Paso);
        }

        public Model.ProcesoLogistico_Paso Recupera_ProcesoLogistico_Paso_Apertura_Procedimiento(string strNumProcedimiento)
        {
            return Recupera_ProcesoLogistico_Paso_Apertura_Procedimiento(strNumProcedimiento);
        }

        public int Graba_ProcesoLogistico_Paso(Model.ProcesoLogistico_Paso obj)
        {
            return Graba_ProcesoLogistico_Paso(obj);
        }
        public int Modifica_ProcesoLogistico_Paso(Model.ProcesoLogistico_Paso obj)
        {
            return Modifica_ProcesoLogistico_Paso(obj);
        }

        public bool Elimina_ProcesoLogistico_Paso(int intIdProcesoLogistico_Paso)
        {
            return Elimina_ProcesoLogistico_Paso(intIdProcesoLogistico_Paso);
        }

        #endregion

        #region "PeriodoProceso_OperadorLogistico"
        public Model.ProcesoLogistico_OperadorLogistico Recupera_ProcesoLogistico_OperadorLogistico(int intIdProcesoLogistico_OperadorLogistico)
        {
            return Recupera_ProcesoLogistico_OperadorLogistico(intIdProcesoLogistico_OperadorLogistico);
        }

        public Model.ProcesoLogistico_OperadorLogistico Recupera_ProcesoLogistico_OperadorLogistico_ItemProcesoLogistico(string strNumProcedimiento)
        {
            return Recupera_ProcesoLogistico_OperadorLogistico_ItemProcesoLogistico(strNumProcedimiento);
        }

        public Boolean Graba_ProcesoLogistico_OperadorLogistico_Reemplazo(int intIdProcesoLogistico_OperadorLogistico,
                                                                        string strCodTipoOperadorLogistico,
                                                                        string strCodMotivoReemplazo,
                                                                        string strCodReemplazo,
                                                                        DateTime dateFecInicio,
                                                                        DateTime dateFecFinal
                                                                       )
        {
            return Graba_ProcesoLogistico_OperadorLogistico_Reemplazo( intIdProcesoLogistico_OperadorLogistico,
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
            return Lista_ProcesoLogistico_OperadorLogistico( strCodCompañia,
                                                             strAñoProceso,
                                                             strCodOperadorLogistico
                                                               );
        }

        public int Graba_ProcesoLogistico_OperadorLogistico(Model.ProcesoLogistico_OperadorLogistico obj)
        {
            return Graba_ProcesoLogistico_OperadorLogistico(obj);
        }

        public int Modifica_ProcesoLogistico_OperadorLogistico(Model.ProcesoLogistico_OperadorLogistico obj)
        {
            return Modifica_ProcesoLogistico_OperadorLogistico(obj);
        }

        public bool Elimina_ProcesoLogistico_OperadorLogistico(int intIdProcesoLogistico_OperadorLogistico)
        {
            return Elimina_ProcesoLogistico_OperadorLogistico(intIdProcesoLogistico_OperadorLogistico);
        }

        public DataSet Lista_ProcesoLogistico_OperadorLogistico(string strAñoProceso,
                                                        string strCodOperadorLogistico
                                                    )
        {
            return Lista_ProcesoLogistico_OperadorLogistico( strAñoProceso,
                                                         strCodOperadorLogistico
                                                    );
        }

        public DataSet Ayuda_ProcesoLogistico_OperadorLogistico_itemProcesoLogistico_Todos(string strAñoProceso)
        {
            return Ayuda_ProcesoLogistico_OperadorLogistico_itemProcesoLogistico_Todos(strAñoProceso);
        }

        #endregion

        #region "ProcesoLogistico_Modificado"
        public Model.ProcesoLogistico_Modificado Recupera_ProcesoLogistico_Modificado(int intIdProcesoLogistico_Modificado)
        {
            return Recupera_ProcesoLogistico_Modificado(intIdProcesoLogistico_Modificado);
        }

        #endregion

        #region "ProcesoLogistico_Insertado"
        public Model.ProcesoLogistico_Insertado Recupera_ProcesoLogistico_Insertado(int intIdProcesoLogistico_Insertado)
        {
            return Recupera_ProcesoLogistico_Insertado(intIdProcesoLogistico_Insertado);
        }

        #endregion

        #region "ProcesoLogistico_Eliminado"
        public Model.ProcesoLogistico_Eliminado Recupera_ProcesoLogistico_Eliminado(int intIdProcesoLogistico_Eliminado)
        {
            return Recupera_ProcesoLogistico_Eliminado(intIdProcesoLogistico_Eliminado);
        }

        #endregion

        #region "ProcesoLogistico_Cabecera_Adjunto"
        public DataSet Lista_ProcesoLogistico_Cabecera_Adjunto(string strAñoProceso,
                                            string strVersion
                                           )
        {
            return Lista_ProcesoLogistico_Cabecera_Adjunto( strAñoProceso,
                                             strVersion
                                           );
        }

        public DataSet Lista_ProcesoLogistico_Cabecera_Adjunto_Consulta(string strAñoProceso,
                                                    string strVersion
                                                   )
        {
            return Lista_ProcesoLogistico_Cabecera_Adjunto_Consulta( strAñoProceso,
                                                     strVersion
                                                   );
        }

        public Model.ProcesoLogistico_Cabecera_Adjunto Recupera_ProcesoLogistico_Cabecera_Adjunto(int intIdAdjunto)
        {
            return Recupera_ProcesoLogistico_Cabecera_Adjunto(intIdAdjunto);
        }
        public int Graba_ProcesoLogistico_Cabecera_Adjunto(Model.ProcesoLogistico_Cabecera_Adjunto obj)
        {
            return Graba_ProcesoLogistico_Cabecera_Adjunto( obj);
        }
        public int Modifica_ProcesoLogistico_Cabecera_Adjunto(Model.ProcesoLogistico_Cabecera_Adjunto obj)
        {
            return Modifica_ProcesoLogistico_Cabecera_Adjunto(obj);
        }

        public bool Elimina_ProcesoLogistico_Cabecera_Adjunto(int intIdAdjunto)
        {
            return Elimina_ProcesoLogistico_Cabecera_Adjunto(intIdAdjunto);
        }

        #endregion

        #region "ProcesoLogistico_Adjunto"
        public DataSet Lista_ProcesoLogistico_Adjunto(string strNumProcedimiento)
        {
            return Lista_ProcesoLogistico_Adjunto(strNumProcedimiento);
        }

        public DataSet Lista_ProcesoLogistico_Adjunto_Consulta(string strNumProcedimiento)
        {
            return Lista_ProcesoLogistico_Adjunto_Consulta(strNumProcedimiento);
        }

        public Model.ProcesoLogistico_Adjunto Recupera_ProcesoLogistico_Adjunto(int intIdAdjunto)
        {
            return Recupera_ProcesoLogistico_Adjunto(intIdAdjunto);
        }
        public int Graba_ProcesoLogistico_Adjunto(Model.ProcesoLogistico_Adjunto obj)
        {
            return Graba_ProcesoLogistico_Adjunto( obj);
        }
        public int Modifica_ProcesoLogistico_Adjunto(Model.ProcesoLogistico_Adjunto obj)
        {
            return Modifica_ProcesoLogistico_Adjunto( obj);
        }

        public bool Elimina_ProcesoLogistico_Adjunto(int intIdAdjunto)
        {
            return Elimina_ProcesoLogistico_Adjunto( intIdAdjunto);
        }

        #endregion

        #region "Duracion"
        public DataSet Lista_ProcesoLogistico_Duracion(string strAñoProceso,
                                    string strVersion,
                                    string strNumProcedimiento
                                 )
        {
            return Lista_ProcesoLogistico_Duracion( strAñoProceso,
                                    strVersion,
                                    strNumProcedimiento
                                 );
        }

        public DataSet Lista_ProcesoLogistico_Duracion_Consulta(string strAñoProceso,
                                            string strVersion,
                                            string strNumProcedimiento
                                         )
        {
            return Lista_ProcesoLogistico_Duracion_Consulta(strAñoProceso,
                                             strVersion,
                                             strNumProcedimiento
                                         );
        }


        public Model.ProcesoLogistico_Duracion Graba_ProcesoLogistico_Duracion(Model.ProcesoLogistico_Duracion obj)
        {
            return Graba_ProcesoLogistico_Duracion(obj);
        }


        public int Modifica_ProcesoLogistico_Duracion(Model.ProcesoLogistico_Duracion obj)
        {
            return Modifica_ProcesoLogistico_Duracion(obj);
        }
        public object recupera_ProcesoLogistico_Duracion(string strNumProcedimiento,
                                            string strCodPaso
                                           )
        {
            return recupera_ProcesoLogistico_Duracion( strNumProcedimiento,
                                             strCodPaso
                                           );
        }

        public int Recupera_ProcesoLogistico_Duracion_Orden(string strNumProcedimiento)
        {
            return Recupera_ProcesoLogistico_Duracion_Orden(strNumProcedimiento);
        }
        public bool elimina_mvto_ProcesoLogistico_Detalle_Duracion(int intIdProcesoLogistico_Detalle_Duracion)
        {
            return elimina_mvto_ProcesoLogistico_Detalle_Duracion(intIdProcesoLogistico_Detalle_Duracion);
        }

        #endregion

        #region "MotivoEliminacion_ProcesoLogistico"
        public DataSet Ayuda_TipoMotivoEliminacionProcesoLogistico()
        {
            return Ayuda_TipoMotivoEliminacionProcesoLogistico();
        }
        public DataSet Combo_TipoMotivoEliminacionProcesoLogistico()
        {
            return Combo_TipoMotivoEliminacionProcesoLogistico();
        }

        #endregion

        #region "MotivoModificacion_ProcesoLogistico"
        public DataSet Ayuda_TipoMotivoModificacionProcesoLogistico()
        {
            return Ayuda_TipoMotivoModificacionProcesoLogistico();
        }
        public DataSet Combo_TipoMotivoModificacionProcesoLogistico()
        {
            return Combo_TipoMotivoModificacionProcesoLogistico();
        }

        #endregion

        #region "MotivoInserccion_ProcesoLogistico"
        public DataSet Ayuda_TipoMotivoInserccionProcesoLogistico()
        {
            return Ayuda_TipoMotivoInserccionProcesoLogistico();
        }
        public DataSet Combo_TipoMotivoInserccionProcesoLogistico()
        {
            return Combo_TipoMotivoInserccionProcesoLogistico();
        }

        #endregion

        #region "TipoAdquisicion"
        public DataSet Combo_TipoAdquisicion()
        {
            return Combo_TipoAdquisicion();
        }

        public DataSet Ayuda_TipoAdquisicion()
        {
            return Ayuda_TipoAdquisicion();
        }
        public Model.TipoAdquisicion Recupera_TipoAdquisicion(int intIdTipoAdquisicion)
        {
            return Recupera_TipoAdquisicion(intIdTipoAdquisicion);
        }
        public Model.TipoAdquisicion Recupera_TipoAdquisicion_Codigo(string strCodTipoAdquisicion)
        {
            return Recupera_TipoAdquisicion_Codigo( strCodTipoAdquisicion);
        }
        public int Graba_TipoAdquisicion(Model.TipoAdquisicion obj)
        {
            return Graba_TipoAdquisicion( obj);
        }
        public int Modifica_TipoAdquisicion(Model.TipoAdquisicion obj)
        {
            return Modifica_TipoAdquisicion(obj);
        }
        public bool Elimina_TipoAdquisicion(int intIdTipoAdquisicion)
        {
            return Elimina_TipoAdquisicion(intIdTipoAdquisicion);
        }
        public DataSet Lista_TipoAdquisicion()
        {
            return Lista_TipoAdquisicion();
        }

        #endregion

        #region "ProcesoLogistico_Cabecera"

        public DataSet ayuda_ProcesoLogistico_Reasignacion()
        {
            return ayuda_ProcesoLogistico_Reasignacion();
        }
        public DataSet lista_ProcesoLogistico_Reasignacion(string strAñoProceso,
                                                             string strNumProcedimiento
                                                            )
        {
            return lista_ProcesoLogistico_Reasignacion(strAñoProceso,
                                                       strNumProcedimiento
                                                            );
        }
        public Model.ProcesoLogistico_Cabecera Recupera_ProcesoLogistico_Cabecera(int intIdProcesoLogistico_Cabecera)
        {
            return Recupera_ProcesoLogistico_Cabecera(intIdProcesoLogistico_Cabecera);
        }
        public Model.ProcesoLogistico_Cabecera Recupera_ProcesoLogistico_Cabecera_Id()
        {
            return Recupera_ProcesoLogistico_Cabecera_Id();
        }

        public int Graba_ProcesoLogistico_Cabecera(Model.ProcesoLogistico_Cabecera obj)
        {
            return Graba_ProcesoLogistico_Cabecera(obj);
        }

        public int Modifica_ProcesoLogistico_Cabecera(Model.ProcesoLogistico_Cabecera obj)
        {
            return Modifica_ProcesoLogistico_Cabecera(obj);
        }
        public bool Elimina_ProcesoLogistico_Cabecera(int intIdProcesoLogistico_Cabecera)
        {
            return Elimina_ProcesoLogistico_Cabecera(intIdProcesoLogistico_Cabecera);
        }

        public DataSet Lista_ProcesoLogistico_Cabecera(string strAñoProceso)
        {
            return Lista_ProcesoLogistico_Cabecera(strAñoProceso);
        }
        #endregion

        #region "TipoProceso"
        public DataSet Combo_TipoProceso()
        {
            return Combo_TipoProceso();
        }

        public DataSet Ayuda_TipoProceso()
        {
            return Ayuda_TipoProceso();
        }

        public Model.TipoProceso Recupera_TipoProceso(int intIdTipoProceso)
        {
            return Recupera_TipoProceso(intIdTipoProceso);
        }
        public Model.TipoProceso Recupera_TipoProceso_Codigo(string strCodTipoProceso)
        {
            return Recupera_TipoProceso_Codigo(strCodTipoProceso);
        }

        public int Graba_TipoProceso(Model.TipoProceso obj)
        {
            return Graba_TipoProceso(obj);
        }

        public int Modifica_TipoProceso(Model.TipoProceso obj)
        {
            return Modifica_TipoProceso(obj);
        }

        public bool Elimina_TipoProceso(int intIdTipoProceso)
        {
            return Elimina_TipoProceso(intIdTipoProceso);
        }

        public DataSet Lista_TipoProceso()
        {
            return Lista_TipoProceso();
        }


        #endregion

        #region "ObjetoContratacion"
        public DataSet Ayuda_ObjetoContratacion()
        {
            return Ayuda_ObjetoContratacion();
        }

        public DataSet Combo_ObjetoContratacion(string strCodTipoProceso)
        {
            return Combo_ObjetoContratacion(strCodTipoProceso);
        }

        public Model.ObjetoContratacion Recupera_ObjetoContratacion(int intIdObjetoContratacion)
        {
            return Recupera_ObjetoContratacion(intIdObjetoContratacion);
        }
        public Model.ObjetoContratacion Recupera_ObjetoContratacion_Codigo(string strCodObjetoContratacion)
        {
            return Recupera_ObjetoContratacion_Codigo(strCodObjetoContratacion);
        }
        public int Graba_ObjetoContratacion(Model.ObjetoContratacion obj)
        {
            return Graba_ObjetoContratacion(obj);
        }
        public int Modifica_ObjetoContratacion(Model.ObjetoContratacion obj)
        {
            return Modifica_ObjetoContratacion(obj);
        }

        public bool Elimina_ObjetoContratacion(int intIdObjetoContratacion)
        {
            return Elimina_ObjetoContratacion( intIdObjetoContratacion);
        }

        public DataSet Lista_ObjetoContratacion()
        {
            return Lista_ObjetoContratacion();
        }

        #endregion

        #region "UnidadMedida"
        public Model.UnidadMedida Recupera_UnidadMedida(int intIdUnidadMedida)
        {
            return Recupera_UnidadMedida(intIdUnidadMedida);
        }
        public Model.UnidadMedida Recupera_UnidadMedida_Codigo(string strCodUnidadMedida)
        {
            return Recupera_UnidadMedida_Codigo(strCodUnidadMedida);
        }

        public int Graba_UnidadMedida(Model.UnidadMedida obj)
        {
            return Graba_UnidadMedida(obj);
        }

        public int Modifica_UnidadMedida(Model.UnidadMedida obj)
        {
            return Modifica_UnidadMedida(obj);
        }

        public bool Elimina_UnidadMedida(int intIdUnidadMedida)
        {
            return Elimina_UnidadMedida(intIdUnidadMedida);
        }

        public DataSet Lista_UnidadMedida()
        {
            return Lista_UnidadMedida();
        }

        #endregion


        #region "TipoTipoFuenteFinanciamiento"
        public DataSet Combo_TipoFuenteFinanciamiento()
        {
            return Combo_TipoFuenteFinanciamiento();
        }

        public DataSet Ayuda_TipoFuenteFinanciamiento()
        {
            return Ayuda_TipoFuenteFinanciamiento();
        }
        public Model.TipoFuenteFinanciamiento Recupera_TipoFuenteFinanciamiento(int intIdTipoFuenteFinanciamiento)
        {
            return Recupera_TipoFuenteFinanciamiento(intIdTipoFuenteFinanciamiento);
        }


        public Model.TipoFuenteFinanciamiento Recupera_TipoFuenteFinanciamiento_Codigo(string strCodTipoFuenteFinanciamiento)
        {
            return Recupera_TipoFuenteFinanciamiento_Codigo(strCodTipoFuenteFinanciamiento);
        }

        public int Graba_TipoFuenteFinanciamiento(Model.TipoFuenteFinanciamiento obj)
        {
            return Graba_TipoFuenteFinanciamiento(obj);
        }

        public int Modifica_TipoFuenteFinanciamiento(Model.TipoFuenteFinanciamiento obj)
        {
            return Modifica_TipoFuenteFinanciamiento(obj);
        }

        public bool Elimina_TipoFuenteFinanciamiento(int intIdTipoFuenteFinanciamiento)
        {
            return Elimina_TipoFuenteFinanciamiento(intIdTipoFuenteFinanciamiento);
        }

        public DataSet Lista_TipoFuenteFinanciamiento()
        {
            return Lista_TipoFuenteFinanciamiento();
        }

        #endregion

        #region "EntidadEncargadaConvocante"
        public DataSet Combo_EntidadEncargadaConvocante()
        {
            return Combo_EntidadEncargadaConvocante();
        }

        public DataSet Ayuda_EntidadEncargadaConvocante()
        {
            return Ayuda_EntidadEncargadaConvocante();
        }

        public Model.EntidadEncargadaConvocante Recupera_EntidadEncargadaConvocante(int intIdEntidadEncargadaConvocante)
        {
            return Recupera_EntidadEncargadaConvocante(intIdEntidadEncargadaConvocante);
        }


        public Model.EntidadEncargadaConvocante Recupera_EntidadEncargadaConvocante_Codigo(string strCodEntidadEncargadaConvocante)
        {
            return Recupera_EntidadEncargadaConvocante_Codigo(strCodEntidadEncargadaConvocante);
        }

        public int Graba_EntidadEncargadaConvocante(Model.EntidadEncargadaConvocante obj)
        {
            return Graba_EntidadEncargadaConvocante(obj);
        }

        public int Modifica_EntidadEncargadaConvocante(Model.EntidadEncargadaConvocante obj)
        {
            return Modifica_EntidadEncargadaConvocante(obj);
        }

        public bool Elimina_EntidadEncargadaConvocante(int intIdEntidadEncargadaConvocante)
        {
            return Elimina_EntidadEncargadaConvocante(intIdEntidadEncargadaConvocante);
        }

        public DataSet Lista_EntidadEncargadaConvocante()
        {
            return Lista_EntidadEncargadaConvocante();
        }

        #endregion


        #region "ModalidadSeleccion"
        public DataSet Combo_ModalidadSeleccion()
        {
            return Combo_ModalidadSeleccion();
        }

        public DataSet Ayuda_ModalidadSeleccion()
        {
            return Ayuda_ModalidadSeleccion();
        }

        public Model.ModalidadSeleccion Recupera_ModalidadSeleccion(int intIdModalidadSeleccion)
        {
            return Recupera_ModalidadSeleccion(intIdModalidadSeleccion);
        }


        public Model.ModalidadSeleccion Recupera_ModalidadSeleccion_Codigo(string strCodModalidadSeleccion)
        {
            return Recupera_ModalidadSeleccion_Codigo(strCodModalidadSeleccion);
        }

        public int Graba_ModalidadSeleccion(Model.ModalidadSeleccion obj)
        {
            return Graba_ModalidadSeleccion(obj);
        }

        public int Modifica_ModalidadSeleccion(Model.ModalidadSeleccion obj)
        {
            return Modifica_ModalidadSeleccion(obj);
        }

        public bool Elimina_ModalidadSeleccion(int intIdModalidadSeleccion)
        {
            return Elimina_ModalidadSeleccion(intIdModalidadSeleccion);
        }

        public DataSet Lista_ModalidadSeleccion()
        {
            return Lista_ModalidadSeleccion();
        }

        #endregion

        #region "Centro"
        public Model.Centro Recupera_Centro(int intIdCentro)
        {
            return Recupera_Centro(intIdCentro);
        }


        public Model.Centro Recupera_Centro_Codigo(string strCodCentro)
        {
            return Recupera_Centro_Codigo(strCodCentro);
        }

        public int Graba_Centro(Model.Centro obj)
        {
            return Graba_Centro(obj);
        }

        public int Modifica_Centro(Model.Centro obj)
        {
            return Modifica_Centro(obj);
        }

        public bool Elimina_Centro(int intIdCentro)
        {
            return Elimina_Centro(intIdCentro);
        }

        public DataTable Lista_Centro()
        {
            return Lista_Centro();
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
            return graba_ProcesoLogistico_Requerimiento( strNumRequerimiento,
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
            return graba_ProcesoLogistico_Requerimiento_LineaFormulacion(strNumRequerimiento,
                                                                           strNumProcedimiento,
                                                                           intIdRequerimiento_Detalle
                                                                         );
        }
        public DataSet ayuda_Pac_HojaTrabajo(string strCodCompañia,
                                              string strAñoProceso
                                            )
        {
            return ayuda_Pac_HojaTrabajo( strCodCompañia,
                                           strAñoProceso
                                            );
        }

        public Model.Pac_HojaTrabajo recupera_Pac_HojaTrabajo(string strCodCompañia,
                                                string strAñoProceso,
                                                string strCodProcesoLogistico
                                    )
        {
            return recupera_Pac_HojaTrabajo( strCodCompañia,
                                              strAñoProceso,
                                               strCodProcesoLogistico
                                    );
        }
        public Model.ProcesoLogistico_Detalle Recupera_ProcesoLogistico_Detalle(int intIdProcesoLogistico_Detalle)
        {
            return Recupera_ProcesoLogistico_Detalle(intIdProcesoLogistico_Detalle);
        }
        public Model.ProcesoLogistico_Detalle Recupera_ProcesoLogistico_Detalle_Codigo(string strNumProcedimiento)
        {
            return Recupera_ProcesoLogistico_Detalle_Codigo(strNumProcedimiento);
        }

        public int Graba_ProcesoLogistico_Detalle(Model.ProcesoLogistico_Detalle obj)
        {
            return Graba_ProcesoLogistico_Detalle(obj);
        }

        public int Modifica_ProcesoLogistico_Detalle(Model.ProcesoLogistico_Detalle obj)
        {
            return Modifica_ProcesoLogistico_Detalle(obj);
        }

        public bool Elimina_ProcesoLogistico_Detalle(Model.ProcesoLogistico_Detalle obj)
        {
            return Elimina_ProcesoLogistico_Detalle(obj);
        }

        public DataSet Lista_ProcesoLogistico_Detalle(string strAñoProceso,
                                            string strVersion
            )
        {
            return Lista_ProcesoLogistico_Detalle( strAñoProceso,
                                             strVersion
                                                );
        }

        public string[] HallarTipoProcedimiento_ProcesoLogistico_Detalle(string strAñoProceso,
                                                            string strVersion,
                                                            string strCodTipoProceso
            )
        {
            return HallarTipoProcedimiento_ProcesoLogistico_Detalle(strAñoProceso,
                                                             strVersion,
                                                             strCodTipoProceso
                                                                );
        }

        public DataSet Lista_ProcesoLogistico_Detalle_PorOperadorLogistico(string strAñoProceso,
                                                                string strVersion,
                                                                string strCodOperadorLogistico
                                                               )
        {
            return Lista_ProcesoLogistico_Detalle_PorOperadorLogistico( strAñoProceso,
                                                                 strVersion,
                                                                 strCodOperadorLogistico
                                                               );
        }

        public DataSet Lista_ProcesoLogistico_Detalle_PorCeges(string strAñoProceso,
                                                        string strVersion,
                                                        string strCodCeges
                                                     )

        {
            return Lista_ProcesoLogistico_Detalle_PorCeges( strAñoProceso,
                                                         strVersion,
                                                         strCodCeges
                                                     );
        }

        #endregion

        #region EstadoComite_Integrante
        public DataSet Combo_EstadoComiteIntegrante(int intTipo)
        {
            return Combo_EstadoComiteIntegrante(intTipo);
        }

        public DataSet Combo_EstadoComite_Integrante_Reemplazo()
        {
            return Combo_EstadoComite_Integrante_Reemplazo();
        }


        #endregion

        #region EstadoOperadorLogistico
        public DataSet Combo_EstadoOperadorLogistico(int intTipo)
        {
            return Combo_EstadoOperadorLogistico(intTipo);
        }

        public DataSet Combo_EstadoOperadorLogistico_Reemplazo()
        {
            return Combo_EstadoOperadorLogistico_Reemplazo();
        }


        #endregion


        #region Adjunto
        public DataTable Lista_Pac_Adjunto_Consulta(int intTipoMovimiento)
        {
            return Lista_Pac_Adjunto_Consulta(intTipoMovimiento);
        }

        public DataTable Lista_Pac_Adjunto(int intTipoMovimiento)
        {
            return Lista_Pac_Adjunto(intTipoMovimiento);
        }

        public Model.Adjunto Recupera_Pac_Adjunto(int intIdAdjunto)
        {
            return Recupera_Pac_Adjunto(intIdAdjunto);
        }
        public int Graba_Pac_Adjunto(Model.Adjunto obj)
        {
            return Graba_Pac_Adjunto(obj);
        }

        public bool Elimina_Pac_Adjunto(int intIdAdjunto)
        {
            return Elimina_Pac_Adjunto(intIdAdjunto);
        }

        #endregion

        #region Proveedor
        public DataSet Ayuda_Proveedor()
        {
            return Ayuda_Proveedor();
        }

        public Model.Proveedor Recupera_msto_Proveedor(string strCodProveedor)
        {
            return Recupera_msto_Proveedor(strCodProveedor);
        }

        public int Graba_msto_Proveedor(Model.Proveedor objProveedor)
        {
            return Graba_msto_Proveedor(objProveedor);
        }


        public DataSet Ayuda_msto_Proveedor()
        {
            return Ayuda_msto_Proveedor();
        }


        #endregion

        #region Material
        public Model.Material Recupera_Material(string strCodMaterial)
        {
            return Recupera_Material(strCodMaterial);
        }

        public Model.Servicio Recupera_Servicio(string strCodServicio)
        {
            return Recupera_Servicio(strCodServicio);
        }

        public DataSet Ayuda_Material(string strTexto)
        {
            return Ayuda_Material(strTexto);
        }

        public DataSet Ayuda_Servicio(string strCodPosPre)
        {
            return Ayuda_Servicio(strCodPosPre);
        }
        #endregion

        #region Reporte
        public DataSet Reporte_Pac_Paso_Gantt(string strAñoProceso,
                                        string strVersion,
                                        string strNumProcedimiento
                                            )
        {
            return Reporte_Pac_Paso_Gantt( strAñoProceso,
                                         strVersion,
                                         strNumProcedimiento
                                            );
        }

        #endregion

        #region Varios
        public DataSet Combo_PeriodoProceso()
        {
            return Combo_PeriodoProceso();
        }

        public DataSet Combo_Version(string strPeriodoProceso)
        {
            return Combo_Version(strPeriodoProceso);
        }

        #endregion

        #region PATRIMONIO
        #region MotivoBaja
        public DataSet Combo_MotivoBaja()
        {
            return Combo_MotivoBaja();
        }

        public Model.MotivoBaja Recupera_MotivoBaja(int intIdMotivoBaja)
        {
            return Recupera_MotivoBaja(intIdMotivoBaja);
        }

        public int Graba_MotivoBaja(string strCodMotivoBaja, string strDesMotivoBaja)
        {
            return Graba_MotivoBaja(strCodMotivoBaja, strDesMotivoBaja);
        }
        public int Modifica_MotivoBaja(int intIdMotivoBaja, string strCodMotivoBaja, string strDesMotivoBaja)
        {
            return Modifica_MotivoBaja(intIdMotivoBaja, strCodMotivoBaja, strDesMotivoBaja);
        }

        public int Elimina_MotivoBaja(int intIdMotivoBaja)
        {
            return Elimina_MotivoBaja(intIdMotivoBaja);
        }

        #endregion

        #region OtrosDatos
        public DataSet Ayuda_TipoIncorporacion()
        {
            return Ayuda_TipoIncorporacion();
        }
        public DataSet Ayuda_ClasePatrimonio()
        {
            return Ayuda_ClasePatrimonio();
        }

        public DataSet Ayuda_Actividad()
        {
            return Ayuda_Actividad();
        }

        public DataSet Ayuda_SubActividad(string strCodActividad)
        {
            return Ayuda_SubActividad(strCodActividad);
        }

        public DataSet Ayuda_Componente(string strCodActividad)
        {
            return Ayuda_Componente(strCodActividad);
        }

        public DataSet Ayuda_TipoPatrimonio()
        {
            return Ayuda_TipoPatrimonio();
        }

        public DataSet Ayuda_EstadoConservacion()
        {
            return Ayuda_EstadoConservacion();
        }

        public DataSet Ayuda_MetodoDepreciacion()
        {
            return Ayuda_MetodoDepreciacion();
        }

        public DataSet Ayuda_Componente_VidaUtil(string strCodActividad,
                                                  string strCodComponente
                                                )
        {
            return Ayuda_Componente_VidaUtil(strCodActividad,
                                              strCodComponente
                                                );
        }

        public DataSet Ayuda_SupraNumero()
        {
            return Ayuda_SupraNumero();
        }

        public DataSet Ayuda_TipoFactorCalculo()
        {
            return Ayuda_TipoFactorCalculo();
        }

        #endregion

        #region Patrimonio
        public Model.Patrimonio Recupera_Patrimonio(string strCodPatrimonio)
        {
            return Recupera_Patrimonio(strCodPatrimonio);
        }


        public Model.Patrimonio Graba_Patrimonio(Model.Patrimonio obj)
        {
            return Graba_Patrimonio(obj);
        }


        public Boolean Modifica_Patrimonio(Model.Patrimonio obj)
        {
            return Modifica_Patrimonio(obj);
        }

        public Boolean Elimina_Patrimonio(string strCodPatrimonio)
        {
            return Elimina_Patrimonio(strCodPatrimonio);
        }

        public DataSet Ayuda_Patrimonio()
        {
            return Ayuda_Patrimonio();
        }

        public DataSet Lista_Patrimonio_ErroresDepreciacion()
        {
            return Lista_Patrimonio_ErroresDepreciacion();
        }

        #endregion

        #region Patrimonio_Depreciacion
        public Model.Patrimonio_Depreciacion Recupera_Patrimonio_Depreciacion(string strPeriodo,
                                                                        string strCodSegmento,
                                                                        string strCodPatrimonio
                                                                       )
        {
            return Recupera_Patrimonio_Depreciacion(strPeriodo,
                                                    strCodSegmento,
                                                    strCodPatrimonio
                                                                       );
        }
        public Model.Patrimonio_Depreciacion Recupera_Patrimonio_Depreciacion_Componente(string strPeriodo,
                                                                                         string strCodSegmento,
                                                                                         string strCodPatrimonio
                                                                                        )
        {
            return Recupera_Patrimonio_Depreciacion_Componente(strPeriodo,
                                                                                         strCodSegmento,
                                                                                         strCodPatrimonio
                                                                                        );
        }

        #endregion

        #region Patrimonio_Origen
        public Model.Patrimonio_Origen Recupera_Patrimonio_Origen(int intIdPatrimonio_Origen)
        {
            return Recupera_Patrimonio_Origen(intIdPatrimonio_Origen);
        }


        public Model.Patrimonio_Origen Graba_Patrimonio_Origen(Model.Patrimonio_Origen obj)
        {
            return Graba_Patrimonio_Origen(obj);
        }


        public Boolean Modifica_Patrimonio_Origen(Model.Patrimonio_Origen obj)
        {
            return Modifica_Patrimonio_Origen(obj);
        }

        public Boolean Elimina_Patrimonio_Origen(int intIdPatrimonio_Origen)
        {
            return Elimina_Patrimonio_Origen(intIdPatrimonio_Origen);
        }

        #endregion

        #region Patrimonio_Resguardo
        public Model.Patrimonio_Resguardo Recupera_Patrimonio_Resguardo(int intIdPatrimonio_Resguardo)
        {
            return Recupera_Patrimonio_Resguardo(intIdPatrimonio_Resguardo);
        }


        public Model.Patrimonio_Resguardo Graba_Patrimonio_Resguardo(Model.Patrimonio_Resguardo obj)
        {
            return Graba_Patrimonio_Resguardo(obj);
        }


        public Boolean Modifica_Patrimonio_Resguardo(Model.Patrimonio_Resguardo obj)
        {
            return Modifica_Patrimonio_Resguardo(obj);
        }

        public Boolean Elimina_Patrimonio_Resguardo(int intIdPatrimonio_Resguardo)
        {
            return Elimina_Patrimonio_Resguardo(intIdPatrimonio_Resguardo);
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
            return Recupera_Patrimonio_Saldos(strCodSegmento,
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
            return Recupera_TipoMovimientoPatrimonio_Codigo(strCodTipoMovimientoPatrimonio);
        }
        public string recupera_TipoMovimientoPatrimonio_Correlativo(string strCodCentro, string strCodTipoMovimientoPatrimonio)
        {
            return recupera_TipoMovimientoPatrimonio_Correlativo(strCodCentro, strCodTipoMovimientoPatrimonio);
        }

        public int Graba_TipoMovimientoPatrimonio(Model.Patrimonio_TipoMovimiento obj)
        {
            return Graba_TipoMovimientoPatrimonio(obj);
        }
        public int Graba_TipoMovimientoPatrimonio_Correlativo(string strCodCentro,
                                                                string strCodTipoMovimientoPatrimonio,
                                                                string strNumTransaccion
                                                              )
        {
            return Graba_TipoMovimientoPatrimonio_Correlativo( strCodCentro,
                                                               strCodTipoMovimientoPatrimonio,
                                                               strNumTransaccion
                                                              );
        }

        public int Modifica_TipoMovimientoPatrimonio(Model.Patrimonio_TipoMovimiento obj)
        {
            return Modifica_TipoMovimientoPatrimonio(obj);
        }


        #endregion

        #region Patrimonio_Transaccion
        public Model.Patrimonio_Transaccion Recupera_Patrimonio_Transaccion(int intIdPatrimonio_Transaccion)
        {
            return Recupera_Patrimonio_Transaccion(intIdPatrimonio_Transaccion);
        }


        public string Graba_Patrimonio_Transaccion(Model.Patrimonio_Transaccion obj)
        {
            return Graba_Patrimonio_Transaccion(obj);
        }


        public Boolean Modifica_Patrimonio_Transaccion(Model.Patrimonio_Transaccion obj)
        {
            return Modifica_Patrimonio_Transaccion(obj);
        }

        public Boolean Elimina_Patrimonio_Transaccion(int intIdPatrimonio_Transaccion)
        {
            return Elimina_Patrimonio_Transaccion(intIdPatrimonio_Transaccion);
        }

        public DataSet Lista_Patrimonio_Transaccion_para_transferencia(string strCodPatrimonio)
        {
            return Lista_Patrimonio_Transaccion_para_transferencia(strCodPatrimonio);
        }

        #endregion

        #region Patrimonio_Transferencia
        public Model.Patrimonio_Transferencia Recupera_Patrimonio_Transferencia(int intIdPatrimonio_Transferencia)
        {
            return Recupera_Patrimonio_Transferencia(intIdPatrimonio_Transferencia);
        }


        public Model.Patrimonio_Transferencia Graba_Patrimonio_Transferencia(Model.Patrimonio_Transferencia obj)
        {
            return Graba_Patrimonio_Transferencia(obj);
        }


        public Boolean Modifica_Patrimonio_Transferencia(Model.Patrimonio_Transferencia obj)
        {
            return Modifica_Patrimonio_Transferencia(obj);
        }

        public Boolean Elimina_Patrimonio_Transferencia(int intIdPatrimonio_Transferencia)
        {
            return Elimina_Patrimonio_Transferencia(intIdPatrimonio_Transferencia);
        }

        #endregion

        #region PeriodoProceso_Patrimonio
        public bool Graba_PeriodoProceso_Patrimonio(Model.PeriodoProceso_Patrimonio obj)
        {
            return Graba_PeriodoProceso_Patrimonio(obj);
        }
        public Model.PeriodoProceso_Patrimonio Recupera_PeriodoProceso_Patrimonio_Apertura(string strAñoProceso)
        {
            return Recupera_PeriodoProceso_Patrimonio_Apertura(strAñoProceso);
        }
        public Boolean Graba_PeriodoProceso_Patrimonio_Cierre(Model.PeriodoProceso_Patrimonio obj)
        {
            return Graba_PeriodoProceso_Patrimonio_Cierre(obj);
        }
        public int Recupera_PeriodoProceso_Patrimonio_ProcesoAnterior(Model.PeriodoProceso_Patrimonio obj)
        {
            return Recupera_PeriodoProceso_Patrimonio_ProcesoAnterior(obj);
        }
        public int Recupera_PeriodoProceso_Patrimonio_ProcesoActual(Model.PeriodoProceso_Patrimonio obj)
        {
            return Recupera_PeriodoProceso_Patrimonio_ProcesoActual(obj);
        }
        public Model.PeriodoProceso_Patrimonio Recupera_PeriodoProceso_Patrimonio(string strAñoProceso)
        {
            return Recupera_PeriodoProceso_Patrimonio(strAñoProceso);
        }
        public Model.PeriodoProceso_Patrimonio Recupera_PeriodoProceso_Patrimonio_PeriodoAnterior(string strAñoProceso)
        {
            return Recupera_PeriodoProceso_Patrimonio_PeriodoAnterior(strAñoProceso);
        }

        public bool Reapertura_PeriodoProceso_Patrimonio(string strPeriodo)
        {
            return Reapertura_PeriodoProceso_Patrimonio(strPeriodo);
        }

        public bool Recupera_PeriodoProceso_Patrimonio_Abierto()
        {
            return Recupera_PeriodoProceso_Patrimonio_Abierto();
        }

        #endregion

        #region RecomendacionBaja
        public DataSet Combo_RecomendacionBaja()
        {
            return Combo_RecomendacionBaja();
        }


        public Model.RecomendacionBaja Recupera_RecomendacionBaja(int intIdRecomendacionBaja)
        {
            return Recupera_RecomendacionBaja(intIdRecomendacionBaja);
        }

        public int Graba_RecomendacionBaja(string strCodRecomendacionBaja, string strDesRecomendacionBaja)
        {
            return Graba_RecomendacionBaja(strCodRecomendacionBaja, strDesRecomendacionBaja);
        }
        public int Modifica_RecomendacionBaja(int intIdRecomendacionBaja, string strCodRecomendacionBaja, string strDesRecomendacionBaja)
        {
            return Modifica_RecomendacionBaja(intIdRecomendacionBaja, strCodRecomendacionBaja, strDesRecomendacionBaja);
        }

        public int Elimina_RecomendacionBaja(int intIdRecomendacionBaja)
        {
            return Elimina_RecomendacionBaja(intIdRecomendacionBaja);
        }

        #endregion

        #region RecomendacionTransferencia
        public DataSet Combo_RecomendacionTransferencia()
        {
            return Combo_RecomendacionTransferencia();
        }

        public Model.RecomendacionTransferencia Recupera_RecomendacionTransferencia(int intIdRecomendacionTransferencia)
        {
            return Recupera_RecomendacionTransferencia(intIdRecomendacionTransferencia);
        }

        public Model.RecomendacionTransferencia Recupera_RecomendacionTransferencia_Codigo(string strCodRecomendacionTransferencia)
        {
            return Recupera_RecomendacionTransferencia_Codigo(strCodRecomendacionTransferencia);
        }


        public Model.RecomendacionTransferencia Graba_RecomendacionTransferencia(Model.RecomendacionTransferencia obj)
        {
            return Graba_RecomendacionTransferencia(obj);
        }


        public Boolean Modifica_RecomendacionTransferencia(Model.RecomendacionTransferencia obj)
        {
            return Modifica_RecomendacionTransferencia(obj);
        }

        public Boolean Elimina_RecomendacionTransferencia(int intIdRecomendacionTransferencia)
        {
            return Elimina_RecomendacionTransferencia(intIdRecomendacionTransferencia);
        }

        #endregion

        #region Parametro_Patrimonio
        public Model.Parametro_Patrimonio Recupera_Parametro_Patrimonio(int intIdParametroPatrimonio)
        {
            return Recupera_Parametro_Patrimonio(intIdParametroPatrimonio);
        }

        public Model.Parametro_Patrimonio Recupera_Parametro_Patrimonio_Codigo(string strCodParametroPatrimonio)
        {
            return Recupera_Parametro_Patrimonio_Codigo(strCodParametroPatrimonio);
        }


        public Model.Parametro_Patrimonio Graba_Parametro_Patrimonio(Model.Parametro_Patrimonio obj)
        {
            return Graba_Parametro_Patrimonio(obj);
        }


        public Boolean Modifica_Parametro_Patrimonio(Model.Parametro_Patrimonio obj)
        {
            return Modifica_Parametro_Patrimonio(obj);
        }

        public Boolean Elimina_Parametro_Patrimonio(int intIdParametroPatrimonio)
        {
            return Elimina_Parametro_Patrimonio(intIdParametroPatrimonio);
        }

        #endregion

        #region MotivoRevaluacion
        public DataTable Ayuda_MotivoRevaluacion()
        {
            return Ayuda_MotivoRevaluacion();
        }
        public DataTable Combo_MotivoRevaluacion()
        {
            return Combo_MotivoRevaluacion();
        }
        public Model.MotivoRevaluacion Recupera_MotivoRevaluacion(int intIdMotivoRevaluacion)
        {
            return Recupera_MotivoRevaluacion(intIdMotivoRevaluacion);
        }


        public Model.MotivoRevaluacion Recupera_MotivoRevaluacion_Codigo(string strCodMotivoRevaluacion)
        {
            return Recupera_MotivoRevaluacion_Codigo(strCodMotivoRevaluacion);
        }

        public int Graba_MotivoRevaluacion(Model.MotivoRevaluacion obj)
        {
            return Graba_MotivoRevaluacion( obj);
        }

        public int Modifica_MotivoRevaluacion(Model.MotivoRevaluacion obj)
        {
            return Modifica_MotivoRevaluacion(obj);
        }

        public bool Elimina_MotivoRevaluacion(int intIdMotivoRevaluacion)
        {
            return Elimina_MotivoRevaluacion(intIdMotivoRevaluacion);
        }

        public DataTable Lista_MotivoRevaluacion()
        {
            return Lista_MotivoRevaluacion();
        }

        public DataTable Arbol_MotivoRevaluacion()
        {
            return Arbol_MotivoRevaluacion();
        }

        #endregion

        #region MotivoTransferencia
        public DataSet Combo_MotivoTransferencia()
        {
            return Combo_MotivoTransferencia();
        }

        public Model.MotivoTransferencia Recupera_MotivoTransferencia(int intIdMotivoTransferencia)
        {
            return Recupera_MotivoTransferencia(intIdMotivoTransferencia);
        }

        public Model.MotivoTransferencia Recupera_MotivoTransferencia_Codigo(string strCodMotivoTransferencia)
        {
            return Recupera_MotivoTransferencia_Codigo(strCodMotivoTransferencia);
        }


        public Model.MotivoTransferencia Graba_MotivoTransferencia(Model.MotivoTransferencia obj)
        {
            return Graba_MotivoTransferencia(obj);
        }


        public Boolean Modifica_MotivoTransferencia(Model.MotivoTransferencia obj)
        {
            return Modifica_MotivoTransferencia(obj);
        }

        public Boolean Elimina_MotivoTransferencia(int intIdMotivoTransferencia)
        {
            return Elimina_MotivoTransferencia(intIdMotivoTransferencia);
        }

        #endregion

        #region TipoMovimientoPatrimonio
        public DataTable Combo_TipoMovimientoPatrimonio_Ajuste()
        {
            return Combo_TipoMovimientoPatrimonio_Ajuste();
        }
        public DataTable Combo_TipoMovimientoPatrimonio()
        {
            return Combo_TipoMovimientoPatrimonio();
        }
        public DataTable Lista_TipoMovimientoPatrimonio()
        {
            return Lista_TipoMovimientoPatrimonio();
        }

        public DataTable Arbol_TipoMovimientoPatrimonio()
        {
            return Arbol_TipoMovimientoPatrimonio();
        }

        public Model.TipoMovimientoPatrimonio Recupera_TipoMovimientoPatrimonio(int intIdTipoMovimientoPatrimonio)
        {
            return Recupera_TipoMovimientoPatrimonio(intIdTipoMovimientoPatrimonio);
        }
        public int Graba_TipoMovimientoPatrimonio(Model.TipoMovimientoPatrimonio obj)
        {
            return Graba_TipoMovimientoPatrimonio(obj);
        }
        public int Modifica_TipoMovimientoPatrimonio(Model.TipoMovimientoPatrimonio obj)
        {
            return Modifica_TipoMovimientoPatrimonio(obj);
        }

        public bool Elimina_TipoMovimientoPatrimonio(int intIdTipoMovimientoPatrimonio)
        {
            return Elimina_TipoMovimientoPatrimonio(intIdTipoMovimientoPatrimonio);
        }

        #endregion

        #endregion

        #region PRESUPUESTO
        #region Actividad
        public DataSet Ayuda_Actividad(string strCodCompañia)
        {
            return Ayuda_Actividad(strCodCompañia);
        }
        public DataSet Lista_Actividad(string strCodCompañia)
        {
            return Lista_Actividad(strCodCompañia);
        }

        public DataSet Naturaleza_Actividad(string strCodCompañia)
        {
            return Naturaleza_Actividad(strCodCompañia);
        }

        public DataSet Combo_Actividad_Reporte(string strCodCompañia)
        {
            return Combo_Actividad_Reporte(strCodCompañia);
        }

        public DataSet Combo_Actividad(string strCodCompañia)
        {
            return Combo_Actividad(strCodCompañia);
        }
        public Model.Actividad Recupera_Actividad(int intIdActividad)
        {
            return Recupera_Actividad(intIdActividad);
        }

        public Model.Actividad Recupera_Actividad_codigo(string strCodCompañia,
                                                          string strCodActividad
                                                        )
        {
            return Recupera_Actividad_codigo(strCodCompañia,
                                              strCodActividad
                                                        );
        }
        public int Graba_Actividad(Model.Actividad obj)
        {
            return Graba_Actividad(obj);
        }
        public int Modifica_Actividad(Model.Actividad obj)
        {
            return Modifica_Actividad(obj);
        }

        public bool Elimina_Actividad(int intIdActividad)
        {
            return Elimina_Actividad(intIdActividad);
        }
        #endregion

        #region CentroBeneficio
        public DataSet Combo_CentroBeneficio(string strCodCompañia)
        {
            return Combo_CentroBeneficio(strCodCompañia);
        }

        public DataSet Ayuda_CentroBeneficio(string strCodCompañia)
        {
            return Ayuda_CentroBeneficio(strCodCompañia);
        }

        public Model.CentroBeneficio Recupera_CentroBeneficio(int intIdCentroBeneficio)
        {
            return Recupera_CentroBeneficio(intIdCentroBeneficio);
        }


        public Model.CentroBeneficio Recupera_CentroBeneficio_Codigo(string strCodCompañia,
                                                                      string strCodCentroBeneficio
                                                                    )
        {
            return Recupera_CentroBeneficio_Codigo(strCodCompañia,
                                                                  strCodCentroBeneficio
                                                                    );
        }

        public int Graba_CentroBeneficio(Model.CentroBeneficio obj)
        {
            return Graba_CentroBeneficio(obj);
        }

        public int Modifica_CentroBeneficio(Model.CentroBeneficio obj)
        {
            return Modifica_CentroBeneficio(obj);
        }

        public bool Elimina_CentroBeneficio(int intIdCentroBeneficio)
        {
            return Elimina_CentroBeneficio(intIdCentroBeneficio);
        }

        public DataSet Lista_CentroBeneficio(string strCodCompañia)
        {
            return Lista_CentroBeneficio(strCodCompañia);
        }

        #endregion

        #region CentroCosto
        public Model.CentroCosto Recupera_CentroCosto_Codigo(string strCodCentroCosto)
        {
            return Recupera_CentroCosto_Codigo(strCodCentroCosto);
        }


        public Model.CentroCosto Recupera_CentroCosto(string intIdCentroCosto)
        {
            return Recupera_CentroCosto(intIdCentroCosto);
        }

        public DataSet Ayuda_CentroCosto(string strCodCompañia)
        {
            return Ayuda_CentroCosto(strCodCompañia);
        }

        public DataSet Ayuda_CentroCosto_Todos()
        {
            return Ayuda_CentroCosto_Todos();
        }

        public DataSet Ayuda_CentroCosto_CentroGestor(string strcodCentroGestor)
        {
            return Ayuda_CentroCosto_CentroGestor(strcodCentroGestor);
        }

        public DataSet Combo_CentroCosto_CentroGestor(string strcodCentroGestor)
        {
            return Combo_CentroCosto_CentroGestor(strcodCentroGestor);
        }

        public bool Elimina_CentroCosto(int intidCentroCosto)
        {
            return Elimina_CentroCosto(intidCentroCosto);
        }

        public int Graba_CentroCosto(Model.CentroCosto obj)
        {
            return Graba_CentroCosto(obj);
        }

        public int Modifica_CentroCosto(Model.CentroCosto obj)
        {
            return Modifica_CentroCosto(obj);
        }

        public DataSet Lista_CentroCosto()
        {
            return Lista_CentroCosto();
        }

        #endregion

        #region CentroGestor
        public DataSet Ayuda_CentroGestor_Proyecto(string strCodCompañia,
                                           string strCodCentroGestor,
                                           string strTipoProyecto,
                                           string strPeriodo
                                          )
        {
            return Ayuda_CentroGestor_Proyecto( strCodCompañia,
                                            strCodCentroGestor,
                                            strTipoProyecto,
                                            strPeriodo
                                          );
        }

        public DataSet Ayuda_CentroGestorSuperior(string strCodCompañia,
                                                  string strCodCentroGestor
                                                 )
        {
            return Ayuda_CentroGestorSuperior( strCodCompañia,
                                                strCodCentroGestor
                                                 );
        }

        public DataSet Ayuda_CentroGestor(string strCodCompañia)
        {
            return Ayuda_CentroGestor(strCodCompañia);
        }

        public Model.CentroGestor Recupera_CentroGestor_Codigo(string strCodCompañia,
                                                                string strCodCentroGestor
                                                            )
        {
            return Recupera_CentroGestor_Codigo(strCodCompañia,
                                                strCodCentroGestor
                                                            );
        }

        public Model.CentroGestor Recupera_CentroGestor_Superior(string strCodCompañia,
                                                                  string strCodCentroCosto
                                                                )
        {
            return Recupera_CentroGestor_Superior(strCodCompañia,
                                                                  strCodCentroCosto
                                                                );
        }

        public Model.CentroGestor Recupera_CentroGestor(int intIdCentroGestor)
        {
            return Recupera_CentroGestor(intIdCentroGestor);
        }


        public DataSet Lista_Cege_Clasificador_x_Elegir(string strCodCompañia,
                                                        string strCodCentroGestor

                             )
        {
            return Lista_Cege_Clasificador_x_Elegir(strCodCompañia,
                                                    strCodCentroGestor

                             );
        }


        public bool Elimina_CentroGestor(int intidCentroGestor)
        {
            return Elimina_CentroGestor(intidCentroGestor);
        }

        public DataSet Lista_Cege_Proyecto(string strCodCompañia,
                                            string strAñoProceso,
                                            string strPeriodo,
                                            string strCodCentroGestor

                                          )
        {
            return Lista_Cege_Proyecto(strCodCompañia,
                                        strAñoProceso,
                                        strPeriodo,
                                        strCodCentroGestor

                                          );
        }

        public Boolean Graba_CentroGestor_Proyecto(string strCodCompañia,
                                                string strAñoProceso,
                                                string strPeriodo,
                                                string strCodCege,
                                                string strCodProyecto
                                              )
        {
            return Graba_CentroGestor_Proyecto( strCodCompañia,
                                                 strAñoProceso,
                                                strPeriodo,
                                                strCodCege,
                                                strCodProyecto
                                              );
        }

        public Boolean Elimina_CentroGestor_Proyecto(string strCodCompañia,
                                                string strAñoProceso,
                                                string strPeriodo,
                                                string strCodCege,
                                                string strCodProyecto
                                              )
        {
            return Elimina_CentroGestor_Proyecto( strCodCompañia,
                                                 strAñoProceso,
                                                 strPeriodo,
                                                 strCodCege,
                                                 strCodProyecto
                                              );
        }

        public DataSet Lista_Cege_Clasificador(string strCodCompañia,
                                            string strAñoProceso,
                                            string strPeriodo,
                                            string strCodCentroGestor

                                          )
        {
            return Lista_Cege_Clasificador( strCodCompañia,
                                            strAñoProceso,
                                            strPeriodo,
                                            strCodCentroGestor

                                          );
        }

        public Boolean Graba_CentroGestor_Clasificador(string strCodCompañia,
                                                string strAñoProceso,
                                                string strPeriodo,
                                                string strCodCege,
                                                string strCodClasificador
                                              )
        {
            return Graba_CentroGestor_Clasificador(strCodCompañia,
                                                 strAñoProceso,
                                                 strPeriodo,
                                                 strCodCege,
                                                 strCodClasificador
                                              );
        }

        public Boolean Elimina_CentroGestor_Clasificador(string strCodCompañia,
                                                string strAñoProceso,
                                                string strPeriodo,
                                                string strCodCege,
                                                string strCodClasificador
                                              )
        {
            return Elimina_CentroGestor_Clasificador(strCodCompañia,
                                                 strAñoProceso,
                                                 strPeriodo,
                                                 strCodCege,
                                                 strCodClasificador
                                              );
        }

        public int Graba_CentroGestor(Model.CentroGestor obj)
        {
            return Graba_CentroGestor(obj);
        }

        public int Modifica_CentroGestor(Model.CentroGestor obj)
        {
            return Modifica_CentroGestor(obj);
        }

        public DataSet Lista_CentroGestor(string strCodCompañia)
        {
            return Lista_CentroGestor(strCodCompañia);
        }
        #endregion

        #region Clasificador
        public DataSet Ayuda_Clasificador(string strCodCompañia, string strCodClasificador, string strCodCentroGestor)
        {
            return Ayuda_Clasificador(strCodCompañia, strCodClasificador, strCodCentroGestor);
        }
        public DataSet Ayuda_Clasificador_Inversion(string strCodCompañia, string strCodProyecto, string strCodClasificador, string strCodCentroGestor)
        {
            return Ayuda_Clasificador_Inversion(strCodCompañia, strCodProyecto, strCodClasificador, strCodCentroGestor);
        }

        public DataSet Ayuda_Clasificador_Otro(string strCodCompañia, string strCodClasificador, string strCodCentroGestor)
        {
            return Ayuda_Clasificador_Otro(strCodCompañia, strCodClasificador,strCodCentroGestor);
        }

        public DataSet Ayuda_Clasificador_Tarea(string strCodCompañia, string strCodProyecto, string strCodClasificador, string strCodCentroGestor)
        {
            return Ayuda_Clasificador_Tarea(strCodCompañia, strCodProyecto, strCodClasificador, strCodCentroGestor);
        }

        public DataSet Ayuda_Clasificador_Ingreso(string strCodCompañia, string strCodCentroGestor)
        {
            return Ayuda_Clasificador_Ingreso(strCodCompañia, strCodCentroGestor);
        }

        public DataSet Ayuda_Clasificador_General(string strCodCompañia)
        {
            return Ayuda_Clasificador_General(strCodCompañia);
        }

        public DataSet Lista_Clasificador(string strCodCompañia)
        {
            return Lista_Clasificador(strCodCompañia);
        }



        public Model.Clasificador Recupera_Clasificador_Codigo(string strCodCompañia,
                                                                string strCodClasificador)
        {
            return Recupera_Clasificador_Codigo(strCodCompañia,
                                                                strCodClasificador);
        }

        public Model.Clasificador Recupera_Clasificador(int intIdClasificador)
        {
            return Recupera_Clasificador(intIdClasificador);
        }

        public int Graba_Clasificador(Model.Clasificador obj)
        {
            return Graba_Clasificador(obj);
        }

        public int Modifica_Clasificador(Model.Clasificador obj)
        {
            return Modifica_Clasificador(obj);
        }

        public bool Elimina_Clasificador(int intIdClasificador)
        {
            return Elimina_Clasificador(intIdClasificador);
        }

        #endregion

        #region Formulacion
        public Model.Formulacion Recupera_Formulacion(string strCodCompañia,
                                                string strAñoProceso,
                                                string strCodFormulacion
                                              )
        {
            return Recupera_Formulacion(strCodCompañia,
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
            return Ayuda_Formulacion( strCodCompañia,
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
            return Ayuda_Formulacion_Logistica( strCodCompañia,
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
            return Ayuda_Formulacion_Logistica( strCodCompañia,
                                          strAñoProceso,
                                          strCodCentroGestor,
                                          strCodTipoAdquisicion
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
            return Ayuda_Formulacion_General( strCodCompañia,
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
            return Elige_Formulacion_General( strCodCompañia,
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
            return Ayuda_Formulacion_Origen(strCodCompañia,
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
            return Ayuda_Formulacion_Destino( strCodCompañia,
                                               strAñoProceso,
                                               strCodCentroGestor,
                                               strCodClasificador,
                                               strCodPosPre,
                                               strCodTipoAdquisicion,
                                               strCodFormulacion
                                       );
        }

        public Boolean Graba_Formulacion_Genera_PIA(string strCodCompañia,
                                                 string strAñoProceso,
                                                 string strVersion
                                               )
        {
            return Graba_Formulacion_Genera_PIA( strCodCompañia,
                                                 strAñoProceso,
                                                 strVersion
                                               );
        }

        public string Graba_Formulacion(Model.Formulacion obj)
        {
            return Graba_Formulacion(obj);
        }

        #endregion

        #region FormulacionAjuste_Cabecera
        public Model.Formulacion_Ajuste_Cabecera Recupera_Formulacion_Ajuste_Cabecera(string strNumAjuste)
        {
            return Recupera_Formulacion_Ajuste_Cabecera(strNumAjuste);
        }

        public Model.Formulacion_Ajuste_Cabecera Graba_Formulacion_Ajuste_Cabecera(Model.Formulacion_Ajuste_Cabecera obj)
        {
            return Graba_Formulacion_Ajuste_Cabecera( obj);
        }

        public Model.Formulacion_Ajuste_Cabecera Graba_Formulacion_Ajuste_Cabecera_Procedimiento(Model.Formulacion_Ajuste_Cabecera obj)
        {
            return Graba_Formulacion_Ajuste_Cabecera_Procedimiento(obj);
        }


        public int Modifica_Formulacion_Ajuste_Cabecera(Model.Formulacion_Ajuste_Cabecera obj)
        {
            return Modifica_Formulacion_Ajuste_Cabecera(obj);
        }

        public int Elimina_Formulacion_Ajuste_Cabecera(string strNumAjuste)
        {
            return Elimina_Formulacion_Ajuste_Cabecera(strNumAjuste);
        }

        public DataSet Lista_Formulacion_Ajuste_Cabecera(string strAñoProceso,
                                                    string strCodCentroGestor,
                                                    string strCodEmpleado
                                                )
        {
            return Lista_Formulacion_Ajuste_Cabecera( strAñoProceso,
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
            return Recupera_Formulacion_Ajuste_Detalle(strNumAjuste,
                                                       strCodTipoMovimiento
                                                                    );
        }

        public int Graba_Formulacion_Ajuste_Detalle(Model.Formulacion_Ajuste_Detalle obj)
        {
            return Graba_Formulacion_Ajuste_Detalle(obj);
        }

        public int Modifica_Formulacion_Ajuste_Detalle(Model.Formulacion_Ajuste_Detalle obj)
        {
            return Modifica_Formulacion_Ajuste_Detalle(obj);
        }

        public int Elimina_Formulacion_Ajuste_Detalle(string strNumAjuste,
                                                        string strCodTipoMovimiento
                                                     )
        {
            return Elimina_Formulacion_Ajuste_Detalle(strNumAjuste,
                                                      strCodTipoMovimiento
                                                     );
        }

        public DataSet Lista_Formulacion_Ajuste_Detalle(string strAñoProceso,
                                                    string strNumAjuste
                                                )
        {
            return Lista_Formulacion_Ajuste_Detalle( strAñoProceso,
                                                     strNumAjuste
                                                );
        }

        public DataSet Lista_Formulacion_Ajuste_Detalle_Formato(string strAñoProceso,
                                                    string strNumAjuste
                                                )
        {
            return Lista_Formulacion_Ajuste_Detalle_Formato(strAñoProceso,
                                                    strNumAjuste
                                                );
        }

        public DataSet Lista_Formulacion_Ajuste_Detalle_Formato_Nuevo(string strAñoProceso,
                                                    string strNumAjuste
                                                )
        {
            return Lista_Formulacion_Ajuste_Detalle_Formato_Nuevo( strAñoProceso,
                                                     strNumAjuste
                                                );
        }

        public DataSet Formato_Ajuste_Estado(string strCodCentro_Gestor,
                                                    string strEstado,
                                                    string strCodEmpleado
                                                   )
        {
            return Formato_Ajuste_Estado(strCodCentro_Gestor,
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
            return Formato_Ajuste_DescarteFirma(strNumAjuste,
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
            return Formato_Ajuste_Firma(strCodCentro_Gestor,
                                          strPaso,
                                          strNumAjuste,
                                         strCodEmpleado
                                                   );
        }

        #endregion

        #region Formulacion_Cabecera
        public DataTable Combo_AñoProceso(string strCodCompañia)
        {
            return Combo_AñoProceso(strCodCompañia);
        }
        public DataTable Combo_Periodo(string strAñoProceso)
        {
            return Combo_Periodo(strAñoProceso);
        }

        public Model.Formulacion_Cabecera Recupera_FormulacionCabecera(string strAñoProceso)
        {
            return Recupera_FormulacionCabecera(strAñoProceso);
        }

        public int Graba_FormulacionCabecera(Model.Formulacion_Cabecera obj)
        {
            return Graba_FormulacionCabecera(obj);
        }

        //Agregado
        public DataSet Lista_FormulacionCabecera(string strAñoProceso)
        {
            return Lista_FormulacionCabecera(strAñoProceso);
        }

        public bool elimina_mvto_Formulacion_Cabecera(int intiIdFormulacion_Cabecera)
        {
            return elimina_mvto_Formulacion_Cabecera(intiIdFormulacion_Cabecera);
        }

        public DataSet Graba_FormulacionCabecera_DataSet(Model.Formulacion_Cabecera obj)
        {
            return Graba_FormulacionCabecera_DataSet( obj);
        }

        public bool Modifica_mvto_Formulacion_Cabecera(Model.Formulacion_Cabecera obj)
        {
            return Modifica_mvto_Formulacion_Cabecera(obj);
        }

        #endregion

        #region Formulacion_Cabecera_CentroGestor
        public bool Graba_mvto_Formulacion_Cabecera_Cege(Model.Formulacion_Cabecera_Cege obj)
        {
            return Graba_mvto_Formulacion_Cabecera_Cege(obj);
        }

        public DataSet Lista_FormulacionCabecera_Cege(string strAñoProceso, string strCege, int digito)
        {
            return Lista_FormulacionCabecera_Cege(strAñoProceso, strCege, digito);
        }
        public Model.Formulacion_Cabecera_Cege Recupera_FormulacionCabecera_Cege(string strAñoProceso,
                                                                            string strVersion,
                                                                            string strPeriodo,
                                                                            string strCodCentroGestor
                                                                           )
        {
            return Recupera_FormulacionCabecera_Cege( strAñoProceso,
                                                      strVersion,
                                                      strPeriodo,
                                                      strCodCentroGestor
                                                                           );
        }
        public DataSet Lista_Formulacion_Aprobacion_Cege(string strAñoProceso, string strCeGe, string strVersion, string strCodEmpleado)
        {
            return Lista_Formulacion_Aprobacion_Cege( strAñoProceso,  strCeGe,  strVersion,  strCodEmpleado);
        }

        public DataSet Lista_Version(string strAñoProceso)
        {
            return Lista_Version( strAñoProceso);
        }

        #endregion

        #region Formulacion_Detalle
        public int Graba_FormulacionDetalle(Model.Formulacion_Detalle obj)
        {
            return Graba_FormulacionDetalle( obj);
        }

        #endregion

        #region Formulacion_Detalle_Ingreso
        public Boolean Elimina_FormulacionDetalle_Ingreso(int intIdFormulacion_Detalle_Proyecto)
        {
            return Elimina_FormulacionDetalle_Ingreso( intIdFormulacion_Detalle_Proyecto);
        }


        public int Graba_FormulacionDetalle_Ingreso(Model.Formulacion_Detalle_Ingreso obj)
        {
            return Graba_FormulacionDetalle_Ingreso( obj);
        }

        public int Modifica_FormulacionDetalle_Ingreso(Model.Formulacion_Detalle_Ingreso obj)
        {
            return Modifica_FormulacionDetalle_Ingreso( obj);
        }


        public DataSet Lista_FormulacionDetalle_Ingreso(string strCodCompañia,
                                                         string strCodProyecto,
                                                         string strCodCentroGestor,
                                                         string strCodTipoFormulacion
                                        )
        {
            return Lista_FormulacionDetalle_Ingreso( strCodCompañia,
                                                     strCodProyecto,
                                                     strCodCentroGestor,
                                                     strCodTipoFormulacion
                                        );
        }

        #endregion

        #region Formulacion_Detalle_Personal
        public Boolean Elimina_FormulacionDetalle_Personal(int intIdFormulacion_Detalle_Proyecto)
        {
            return Elimina_FormulacionDetalle_Personal(intIdFormulacion_Detalle_Proyecto);
        }


        public int Graba_FormulacionDetalle_Personal(Model.Formulacion_Detalle_Personal obj)
        {
            return Graba_FormulacionDetalle_Personal(obj);
        }

        public int Modifica_FormulacionDetalle_Personal(Model.Formulacion_Detalle_Personal obj)
        {
            return Modifica_FormulacionDetalle_Personal( obj);
        }


        public DataSet Lista_FormulacionDetalle_Personal(string strCodCompañia,
                                                         string strCodCentroGestor,
                                                         string strCodTipoFormulacion
                                        )
        {
            return Lista_FormulacionDetalle_Personal( strCodCompañia,
                                                     strCodCentroGestor,
                                                      strCodTipoFormulacion
                                        );
        }

        #endregion

        #region Formulacion_Detalle_Proyecto
        public Boolean Elimina_FormulacionDetalle_Proyecto(int intIdFormulacion_Detalle_Proyecto)
        {
            return Elimina_FormulacionDetalle_Proyecto(intIdFormulacion_Detalle_Proyecto);
        }


        public int Graba_FormulacionDetalle_Proyecto(Model.Formulacion_Detalle_Proyecto obj)
        {
            return Graba_FormulacionDetalle_Proyecto( obj);
        }

        public int Modifica_FormulacionDetalle_Proyecto(Model.Formulacion_Detalle_Proyecto obj)
        {
            return Modifica_FormulacionDetalle_Proyecto(obj);
        }


        public DataSet Lista_FormulacionDetalle_Proyecto(string strCodCompañia,
                                                         string strCodProyecto,
                                                         string strCodCentroGestor,
                                                         string strCodTipoFormulacion
                                        )
        {
            return Lista_FormulacionDetalle_Proyecto(strCodCompañia,
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
            return Lista_FormulacionDetalle_Proyecto_Otros( strCodCompañia,
                                                         strCodCentroGestor,
                                                         strCodTipoFormulacion
                                        );
        }

        #endregion

        #region Formulacion_HojaTrabajo
        public DataSet Lista_CierreCentroGestor(string strCodCompañia,
                                    string strAñoProceso,
                                    string strVersion,
                                    string strPeriodo
                                  )
        {
            return Lista_CierreCentroGestor( strCodCompañia,
                                    strAñoProceso,
                                    strVersion,
                                    strPeriodo
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
            return Graba_CierreCentroGestor( strCodCompañia,
                                              strAñoProceso,
                                              strVersion,
                                              strPeriodo,
                                              strCodCege,
                                              strCodUsuario
                                              );
        }

        public Boolean Elimina_CierreCentroGestor(string strCodCompañia,
                                                string strAñoProceso,
                                                string strVersion,
                                                string strPeriodo,
                                                string strCodCege
                                              )
        {
            return Elimina_CierreCentroGestor(strCodCompañia,
                                               strAñoProceso,
                                               strVersion,
                                               strPeriodo,
                                                 strCodCege
                                              );
        }

        public Boolean Cierra_CierreVersion_GeneraPIA(string strCodCompañia,
                                            string strAñoProceso,
                                            string strPeriodo,
                                            string strVersion
                                         )
        {
            return Cierra_CierreVersion_GeneraPIA( strCodCompañia,
                                             strAñoProceso,
                                             strPeriodo,
                                             strVersion
                                         );
        }

        public Boolean Cierra_CierreVersion_CenroGestor(string strCodCompañia,
                                                            string strAñoProceso,
                                                            string strVersion,
                                                            string strPeriodo,
                                                            string strCodCentroGestor
                                                         )
        {
            return Cierra_CierreVersion_CenroGestor(strCodCompañia,
                                                    strAñoProceso,
                                                    strVersion,
                                                    strPeriodo,
                                                    strCodCentroGestor
                                                         );
        }
        public DataTable Combo_PeriodoPresupuesto(string strCodCompañia, string strPeriodo)
        {
            return Combo_PeriodoPresupuesto(strCodCompañia, strPeriodo);
        }

        public DataTable Combo_PeriodoPia(string strCodCompañia)
        {
            return Combo_PeriodoPia(strCodCompañia);
        }

        public DataTable Combo_VersionPia(string strCodCompañia, string strAñoProceso)
        {
            return Combo_VersionPia(strCodCompañia, strAñoProceso);
        }


        public DataTable Combo_PeriodoPresupuesto_Version(string strCodCompañia, string strPeriodo, string strAñoProceso)
        {
            return Combo_PeriodoPresupuesto_Version(strCodCompañia, strPeriodo, strAñoProceso);
        }

        public int Recupera_PeriodoPresupuesto_IdCabecera(string strCodCompañia,
                                                          string strPeriodo,
                                                          string strAñoProceso,
                                                          string strVersion
                                                        )
        {
            return Recupera_PeriodoPresupuesto_IdCabecera( strCodCompañia,
                                                           strPeriodo,
                                                           strAñoProceso,
                                                           strVersion
                                                        );
        }

        public Boolean Recupera_VerificaCierrePeriodoModificacion(string strCodEmpresa,
                                                                          string strAñoProceso
                                                                 )
        {
            return Recupera_VerificaCierrePeriodoModificacion(strCodEmpresa,
                                                              strAñoProceso
                                                                 );
        }

        public Model.PeriodoCierreModificacion Recupera_CierrePeriodoModificacion(string strCodEmpresa)
        {
            return Recupera_CierrePeriodoModificacion(strCodEmpresa);
        }
        public DataSet Ayuda_Proyecto_HojaTrabajo(string strCodEmpresa,
                                      string strCodCentroGestor
            )
        {
            return Ayuda_Proyecto_HojaTrabajo(strCodEmpresa,
                                      strCodCentroGestor
                                            );
        }
        public DataSet Ayuda_Proyecto_Componente_HojaTrabajo(string strCodEmpresa,
                                      string strCodCentroGestor
            )
        {
            return Ayuda_Proyecto_Componente_HojaTrabajo( strCodEmpresa,
                                      strCodCentroGestor
                                            );
        }
        public DataSet Ayuda_Formulacion_HojaTrabajo(string strCodEmpresa, string strTipoProyecto)
        {
            return Ayuda_Formulacion_HojaTrabajo(strCodEmpresa, strTipoProyecto);
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
            return Lista_Formulacion_HojaTrabajo_Servicio( strCodCompañia,
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
            return Lista_Formulacion_HojaTrabajo( strCodCompañia,
                                                  strAñoProceso,
                                                   strVersion,
                                                   strPeriodo,
                                                   strCodProyecto,
                                                   strCodCentroGestor,
                                                   strCodTipoFormulacion
                                                    );
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
            return Lista_ReFormulacion_HojaTrabajo( strCodCompañia,
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
            return Recupera_FormulacionHojaTrabajo_Cabecera( strAñoProceso);
        }

        public DataTable Combo_AñoProceso_HojaTrabajo(string strCodCompañia)
        {
            return Combo_AñoProceso_HojaTrabajo(strCodCompañia);
        }

        public DataTable Combo_Periodo_HojaTrabajo(string strAñoProceso)
        {
            return Combo_Periodo_HojaTrabajo(strAñoProceso);
        }

        public DataTable Combo_AñoProceso_GeneraSaldo(string strCodCompañia)
        {
            return Combo_AñoProceso_GeneraSaldo(strCodCompañia);
        }

        public DataTable Combo_Version_GeneraSaldo(string strCodCompañia, string strAñoProceso)
        {
            return Combo_Version_GeneraSaldo( strCodCompañia, strAñoProceso);
        }
        public DataTable Combo_Periodo_GeneraSaldo(string strCodCompañia, string strAñoProceso)
        {
            return Combo_Periodo_GeneraSaldo(strCodCompañia, strAñoProceso);
        }

        public string[] GrabaHojaTrabajo_Detalle(Model.Formulacion_HojaTrabajo_Detalle obj)
        {
            return GrabaHojaTrabajo_Detalle(obj);
        }

        public string[] ModificaHojaTrabajo_Detalle(Model.Formulacion_HojaTrabajo_Detalle obj)
        {
            return ModificaHojaTrabajo_Detalle(obj);
        }

        public int GrabaHojaTrabajo_Detalle_Item(Model.Formulacion_HojaTrabajo_Detalle_Item obj)
        {
            return GrabaHojaTrabajo_Detalle_Item(obj);
        }
        public int ModificaHojaTrabajo_Detalle_Item(Model.Formulacion_HojaTrabajo_Detalle_Item obj)
        {
            return ModificaHojaTrabajo_Detalle_Item(obj);
        }
        public Boolean EliminaHojaTrabajo_Detalle(int intIdDetalle)
        {
            return EliminaHojaTrabajo_Detalle(intIdDetalle);
        }

        public Boolean GeneraSaldoPresupuestal(string strCodCompañia,
                                                string strAñoProceso,
                                                string strPeriodo,
                                                string strMesProceso,
                                                string strAñoActual
                                              )
        {
            return GeneraSaldoPresupuestal( strCodCompañia,
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
            return GeneraCierreModificacionPresupuestal( strCodCompañia,
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
            return Lista_OrdenesVigentes( strCodCompañia,
                                         strAñoProceso,
                                         strCodCentroCosto,
                                         strCodLineaFormulacion
                                                    );
        }

        public DataSet Reporte_Detalle_ModificacionFormulacion(string strCodCompañia,
                          string strAñoProceso,
                          string strVersion,
                          string strPeriodo,
                          string strCodCentroGestor
                        )
        {
            return Reporte_Detalle_ModificacionFormulacion(strCodCompañia,
                          strAñoProceso,
                          strVersion,
                          strPeriodo,
                          strCodCentroGestor
                        );
        }

        public DataSet Reporte_Detalle_PIA(string strCodCompañia,
                          string strAñoProceso,
                          string strVersion,
                          string strCodCentroGestor
                        )
        {
            return Reporte_Detalle_PIA( strCodCompañia,
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
            return Reporte_SaldoDetalle_PIA( strCodCompañia,
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
            return Reporte_Resumen_ModificacionFormulacion(strCodCompañia,
                                                            strAñoProceso,
                                                             strVersion,
                                                             strPeriodo
                                                            );
        }

        public DataSet Ayuda_CentroGestor_HojaTrabajo(string strCodCentroGestorSuperior)
        {
            return Ayuda_CentroGestor_HojaTrabajo(strCodCentroGestorSuperior);
        }


        #endregion

        #region Gestion_HojaTrabajo
        public DataSet Lista_Mensajevalidacion_PasePresupuestal(string strCodCompañia,
                                                        string strAñoProceso,
                                                        string strNumRequerimiento
                                                       )
        {
            return Lista_Mensajevalidacion_PasePresupuestal( strCodCompañia,
                                                         strAñoProceso,
                                                         strNumRequerimiento
                                                       );
        }

        public DataSet Combo_TipoMensajeValidacion()
        {
            return Combo_TipoMensajeValidacion();
        }
        public DataSet Lista_TerminoReferencia_IdaVuelta(string strCodCompañia,
                                                            string strCodEmpleado,
                                                            string strTipoMovimiento
                                                        )
        {
            return Lista_TerminoReferencia_IdaVuelta( strCodCompañia,
                                                      strCodEmpleado,
                                                      strTipoMovimiento
                                                        );
        }

        public DataSet Lista_Encargatura_Empleado(string strCodCompañia,
                                                  string strCodEmpleado
                                                 )
        {
            return Lista_Encargatura_Empleado( strCodCompañia,
                                                strCodEmpleado
                                                 );
        }

        public DataSet Lista_Encargatura(string strCodCompañia)
        {
            return Lista_Encargatura(strCodCompañia);
        }

        public Model.Encargatura Recupera_Encargatura(int intIdEncargatura)
        {
            return Recupera_Encargatura(intIdEncargatura);
        }

        public Model.Encargatura Graba_Encargatura(string strAñoProceso,
                                                    Model.Encargatura obj)
        {
            return Graba_Encargatura(strAñoProceso,
                                                    obj);
        }

        public int Modifica_Encargatura(string strAñoProceso, Model.Encargatura obj)
        {
            return Modifica_Encargatura( strAñoProceso, obj);
        }

        public Boolean Elimina_Encargatura(string strNumDocumento)
        {
            return Elimina_Encargatura(strNumDocumento);
        }


        public DataTable Combo_TipoEngargatura()
        {
            return Combo_TipoEngargatura();
        }

        public DataTable Combo_PeriodoPlanEstrategico(string strCodCompañia)
        {
            return Combo_PeriodoPlanEstrategico(strCodCompañia);
        }

        public DataTable Combo_PeriodoPlanEstrategico_Version(string strCodCompañia,
                                                                string strAñoProceso
                                                            )
        {
            return Combo_PeriodoPlanEstrategico_Version(strCodCompañia,
                                                        strAñoProceso
                                                            );
        }

        public Boolean Traslada_Requerimiento_a_SPRING(string strNumRequerimiento)
        {
            return Traslada_Requerimiento_a_SPRING(strNumRequerimiento);
        }

        public DataSet Reporte_EstadoRequerimiento(string strCodCompañia,
                                                    string strPeriodoInicial,
                                                    string strPeriodoFinal,
                                                    string strCodCentroGestor,
                                                    int intTipo
                                          )
        {
            return Reporte_EstadoRequerimiento( strCodCompañia,
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
            return Reporte_EstadoReasignacion( strCodCompañia,
                                               strPeriodoInicial,
                                               strPeriodoFinal,
                                               strCodCentroGestor
                                          );
        }

        public DataSet Ayuda_PlanEstrategico(string strCodCompañia,
                                             string strAñoProceso
                                            )
        {
            return Ayuda_PlanEstrategico(strCodCompañia,
                                         strAñoProceso
                                            );
        }

        public DataSet Lista_PlanEstrategico_LineaFormulacion(string strCodCompañia,
                                                        string strAñoProceso,
                                                        string strCodIndicadorOperativo
                                                     )
        {
            return Lista_PlanEstrategico_LineaFormulacion( strCodCompañia,
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
            return Graba_PlanEstrategico_LineaFormulacion( strCodCompañia,
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
            return Elimina_PlanEstrategico_LineaFormulacion( strCodCompañia,
                                                 strAñoProceso,
                                                 strCodIndicadorOperativo,
                                                 strCodLineaFormulacion
                                              );
        }
        public DataSet Lista_Estado_FuenteFinanciamiento(string strCodCompañia,
                                                                string strCodFuenteFinanciamiento
                                                             )
        {
            return Lista_Estado_FuenteFinanciamiento(strCodCompañia,
                                                      strCodFuenteFinanciamiento
                                                             );
        }

        public Boolean Modifica_Estado_FuenteFinanciamiento(string strCodCompañia,
                                                                string strCodFuenteFinanciamiento,
                                                                string strCodProyecto,
                                                                Boolean blnEstado
                                              )
        {
            return Modifica_Estado_FuenteFinanciamiento( strCodCompañia,
                                                        strCodFuenteFinanciamiento,
                                                        strCodProyecto,
                                                        blnEstado
                                              );
        }
        #endregion

        #region MotivoRechazoAjuste
        public DataSet Combo_MotivoRechazoAjuste(string strCodTipoRechazo)
        {
            return Combo_MotivoRechazoAjuste(strCodTipoRechazo);
        }

        public DataSet Ayuda_MotivoRechazoAjuste()
        {
            return Ayuda_MotivoRechazoAjuste();
        }

        public Model.MotivoRechazoAjuste Recupera_MotivoRechazoAjuste(int intIdMotivoRechazoAjuste)
        {
            return Recupera_MotivoRechazoAjuste( intIdMotivoRechazoAjuste);
        }


        public Model.MotivoRechazoAjuste Recupera_MotivoRechazoAjuste_Codigo(string strCodMotivoRechazoAjuste)
        {
            return Recupera_MotivoRechazoAjuste_Codigo(strCodMotivoRechazoAjuste);
        }

        public int Graba_MotivoRechazoAjuste(Model.MotivoRechazoAjuste obj)
        {
            return Graba_MotivoRechazoAjuste(obj);
        }

        public int Modifica_MotivoRechazoAjuste(Model.MotivoRechazoAjuste obj)
        {
            return Modifica_MotivoRechazoAjuste(obj);
        }

        public bool Elimina_MotivoRechazoAjuste(int intIdMotivoRechazoAjuste)
        {
            return Elimina_MotivoRechazoAjuste(intIdMotivoRechazoAjuste);
        }

        public DataTable Lista_MotivoRechazoAjuste()
        {
            return Lista_MotivoRechazoAjuste();
        }

        #endregion

        #region MotivoRechazoRequerimiento
        public DataSet Combo_MotivoRechazoRequerimiento(string strCodTipoRechazo)
        {
            return Combo_MotivoRechazoRequerimiento( strCodTipoRechazo);
        }

        public DataSet Ayuda_MotivoRechazoRequerimiento()
        {
            return Ayuda_MotivoRechazoRequerimiento();
        }

        public Model.MotivoRechazoRequerimiento Recupera_MotivoRechazoRequerimiento(int intIdMotivoRechazoRequerimiento)
        {
            return Recupera_MotivoRechazoRequerimiento(intIdMotivoRechazoRequerimiento);
        }


        public Model.MotivoRechazoRequerimiento Recupera_MotivoRechazoRequerimiento_Codigo(string strCodMotivoRechazoRequerimiento)
        {
            return Recupera_MotivoRechazoRequerimiento_Codigo(strCodMotivoRechazoRequerimiento);
        }

        public int Graba_MotivoRechazoRequerimiento(Model.MotivoRechazoRequerimiento obj)
        {
            return Graba_MotivoRechazoRequerimiento(obj);
        }

        public int Modifica_MotivoRechazoRequerimiento(Model.MotivoRechazoRequerimiento obj)
        {
            return Modifica_MotivoRechazoRequerimiento(obj);
        }

        public bool Elimina_MotivoRechazoRequerimiento(int intIdMotivoRechazoRequerimiento)
        {
            return Elimina_MotivoRechazoRequerimiento(intIdMotivoRechazoRequerimiento);
        }

        public DataTable Lista_MotivoRechazoRequerimiento()
        {
            return Lista_MotivoRechazoRequerimiento();
        }

        #endregion

        #region ParametroFormulacion
        public Model.ParametroFormulacion Recupera_ParametroFormulacion_Codigo(string strCodParametro)
        {
            return Recupera_ParametroFormulacion_Codigo(strCodParametro);
        }

        public Model.ParametroFormulacion Recupera_ParametroFormulacion(int intIdParametro)
        {
            return Recupera_ParametroFormulacion( intIdParametro);
        }

        public int Graba_ParametroFormulacion(Model.ParametroFormulacion obj)
        {
            return Graba_ParametroFormulacion(obj);
        }

        public int Modifica_ParametroFormulacion(Model.ParametroFormulacion obj)
        {
            return Modifica_ParametroFormulacion(obj);
        }

        public bool Elimina_ParametroFormulacion(int intIdParametro)
        {
            return Elimina_ParametroFormulacion( intIdParametro);
        }

        public DataSet Lista_ParametroFormulacion()
        {
            return Lista_ParametroFormulacion();
        }

        #endregion

        #region ParametroGestion
        public Model.ParametroGestion Recupera_ParametroGestion_Codigo(string strCodParametroGestion)
        {
            return Recupera_ParametroGestion_Codigo(strCodParametroGestion);
        }

        public Model.ParametroGestion Recupera_ParametroGestion(int intIdParametroGestion)
        {
            return Recupera_ParametroGestion(intIdParametroGestion);
        }

        public int Graba_ParametroGestion(Model.ParametroGestion obj)
        {
            return Graba_ParametroGestion(obj);
        }

        public int Modifica_ParametroGestion(Model.ParametroGestion obj)
        {
            return Modifica_ParametroGestion(obj);
        }

        public bool Elimina_ParametroGestion(int intIdParametro)
        {
            return Elimina_ParametroGestion(intIdParametro);
        }

        public DataSet Lista_ParametroGestion()
        {
            return Lista_ParametroGestion();
        }

        #endregion

        #region PasoAjuste
        public Model.Paso_Ajuste GetPaso_Ajuste(string strNumAjuste
                                                     )
        {
            return GetPaso_Ajuste(strNumAjuste);
        }


        private Model.Paso_Ajuste GetEmpDataTableRow(DataRow dr)
        {
            return GetEmpDataTableRow(dr);
        }

        #endregion

        #region PasoRequerimiento
        public Model.Paso_Requerimiento GetPaso_Requerimiento(string strNumRequerimiento )
        {
            return GetPaso_Requerimiento(strNumRequerimiento);
        }


        private Model.Paso_Requerimiento GetEmpDataTableRow_Pry(DataRow dr)
        {
            return GetEmpDataTableRow_Pry(dr);
        }

        #endregion

        #region PAC_HojaTrabajo
        public Boolean EliminaPacHojaTrabajo_Detalle(int intIdDetalle)
        {
            return EliminaPacHojaTrabajo_Detalle(intIdDetalle);
        }


        public DataSet Reporte_Detalle_PAC(string strCodCompañia,
                  string strAñoProceso,
                  string strVersion,
                  string strCodCentroGestor
                )
        {
            return Reporte_Detalle_PAC( strCodCompañia,
                                       strAñoProceso,
                                       strVersion,
                                       strCodCentroGestor
                                    );
        }


        public DataTable Combo_PeriodoPAC_Version(string strCodCompañia, string strAñoProceso)
        {
            return Combo_PeriodoPAC_Version(strCodCompañia, strAñoProceso);
        }

        public Model.Formulacion_Detlle_CodFormulacion Recupera_Formulacion_Detlle_CodFormulacion(string strCodCompañia,
                                                                                                    string strAñoProceso,
                                                                                                    string strCodCentroGestor,
                                                                                                    string strCodFormulacion
                                                                                                 )
        {
            return Recupera_Formulacion_Detlle_CodFormulacion(strCodCompañia,
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
            return Lista_Pac_HojaTrabajo(strCodCompañia,
                                         strAñoProceso,
                                         strVersion,
                                         strCodCentroGestor
                                                    );
        }

        public DataTable Combo_PeriodoPAC(string strCodCompañia)
        {
            return Combo_PeriodoPAC(strCodCompañia);
        }

        public string Graba_Pac_HojaTrabajo(Model.Pac_HojaTrabajo obj)
        {
            return Graba_Pac_HojaTrabajo(obj);
        }

        public int Graba_Pac_HojaTrabajo_Detalle(Model.Pac_HojaTrabajo_detalle obj)
        {
            return Graba_Pac_HojaTrabajo_Detalle(obj);
        }

        public int Modifica_Pac_HojaTrabajo_Detalle(Model.Pac_HojaTrabajo_detalle obj)
        {
            return Modifica_Pac_HojaTrabajo_Detalle(obj);
        }

        public int Graba_Pac_HojaTrabajo_Detalle_Item(Model.Pac_HojaTrabajo_detalle_Item obj)
        {
            return Graba_Pac_HojaTrabajo_Detalle_Item(obj);
        }
        public int Modifica_Pac_HojaTrabajo_Detalle_Item(Model.Pac_HojaTrabajo_detalle_Item obj)
        {
            return Modifica_Pac_HojaTrabajo_Detalle_Item(obj);
        }


        public DataSet Ayuda_Pac_HojaTrabajo(string strCodEmpresa,
                                             string strAñoProceso,
                                             string strCodCentroGestor
                                            )
        {
            return Ayuda_Pac_HojaTrabajo( strCodEmpresa,
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
            return Ayuda_Formulacion_HojaTrabajo_CentroGestor( strCodEmpresa,
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
            return Recupera_PeriodoPac_IdCabecera(strCodCompañia,
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
            return Ayuda_PDF(strCodCeGe,
                         strNumDocumento
                       );
        }


        public Model.Requerimiento GetRequerimiento(string strNumRequerimiento)
        {
            return GetRequerimiento(strNumRequerimiento);
        }

        public List<Model.Requerimiento> GetListaRequerimiento(string strCodCentroGestor)
        {
            return GetListaRequerimiento(strCodCentroGestor);
        }

        private Model.Requerimiento GetEmpDataTableRow_Req(DataRow dr)
        {
            return GetEmpDataTableRow_Req(dr);
        }

        public Model.Formulacion_Saldo Recupera_Formulacion_Sado(Model.Formulacion_Saldo obj)
        {
            return Recupera_Formulacion_Sado(obj);
        }

        private Model.Formulacion_Saldo GetSalDataTableRow(DataRow dr)
        {
            return GetSalDataTableRow(dr);
        }

        #endregion

        #region Requerimiento_Adjunto
        public DataSet Lista_Requerimiento_Adjunto_Codigo(string strNumDocumento)
        {
            return Lista_Requerimiento_Adjunto_Codigo(strNumDocumento);
        }
        public DataSet Lista_Requerimiento_Adjunto(string strNumProcedimiento)
        {
            return Lista_Requerimiento_Adjunto(strNumProcedimiento);
        }

        public DataSet Lista_Requerimiento_Adjunto_Consulta(string strNumProcedimiento)
        {
            return Lista_Requerimiento_Adjunto_Consulta(strNumProcedimiento);
        }

        public Model.Requerimiento_Adjunto Recupera_Requerimiento_Adjunto_Codigo(string strNumRequerimiento)
        {
            return Recupera_Requerimiento_Adjunto_Codigo(strNumRequerimiento);
        }
        public Model.Requerimiento_Adjunto Recupera_Requerimiento_Adjunto(int intIdAdjunto)
        {
            return Recupera_Requerimiento_Adjunto(intIdAdjunto);
        }
        public int Graba_Requerimiento_Adjunto(Model.Requerimiento_Adjunto obj)
        {
            return Graba_Requerimiento_Adjunto(obj);
        }
        public int Modifica_Requerimiento_Adjunto(Model.Requerimiento_Adjunto obj)
        {
            return Modifica_Requerimiento_Adjunto(obj);
        }

        public bool Elimina_Requerimiento_Adjunto(int intIdAdjunto)
        {
            return Elimina_Requerimiento_Adjunto(intIdAdjunto);
        }

        #endregion

        #region Requerimiento_Cabecera
        public Model.Requerimiento_Cabecera Recupera_Requerimiento_Cabecera_NumRequerimiento(string strNumRequerimiento)
        {
            return Recupera_Requerimiento_Cabecera_NumRequerimiento(strNumRequerimiento);
        }
        public Model.Requerimiento_Cabecera Recupera_Requerimiento_Cabecera(int intIdRequrimiento_Cabecera)
        {
            return Recupera_Requerimiento_Cabecera(intIdRequrimiento_Cabecera);
        }

        public Model.Requerimiento_Cabecera Graba_Requerimiento_Cabecera(Model.Requerimiento_Cabecera obj)
        {
            return Graba_Requerimiento_Cabecera(obj);
        }

        public int Modifica_Requerimiento_Cabecera(Model.Requerimiento_Cabecera obj)
        {
            return Modifica_Requerimiento_Cabecera(obj);
        }

        public int Modifica_Requerimiento_Cabecera_NumRequerimiento(Model.Requerimiento_Cabecera obj)
        {
            return Modifica_Requerimiento_Cabecera_NumRequerimiento(obj);
        }

        public int Modifica_Requerimiento_Cabecera_Requerimiento(Model.Requerimiento_Cabecera obj)
        {
            return Modifica_Requerimiento_Cabecera_Requerimiento(obj);
        }

        public int Elimina_Requerimiento_Cabecera(int intIdRequerimiento_Cabecera)
        {
            return Elimina_Requerimiento_Cabecera(intIdRequerimiento_Cabecera);
        }

        public DataSet Lista_Requerimiento_Cabecera_Adjunto(string strNumRequerimiento)
        {
            return Lista_Requerimiento_Cabecera_Adjunto(strNumRequerimiento);
        }

        public Boolean Graba_Requerimiento_Cabecera_Adjunto(string strNumRequerimiento,
                                                             string strArchivo,
                                                             string strNombreArchivo
                                                           )
        {
            return Graba_Requerimiento_Cabecera_Adjunto( strNumRequerimiento,
                                                         strArchivo,
                                                         strNombreArchivo
                                                           );
        }

        public Boolean Elimina_Requerimiento_Cabecera_Adjunto(string strNumRequerimiento,
                                                             string strArchivo,
                                                             string strNombreArchivo
                                                           )
        {
            return Elimina_Requerimiento_Cabecera_Adjunto( strNumRequerimiento,
                                                            strArchivo,
                                                           strNombreArchivo
                                                           );
        }

        #endregion

        #region Requerimiento_Cabecera_Viatico
        public Model.Requerimiento_Cabecera_Viatico Recupera_Requerimiento_Cabecera_Viatico(int intIdRequrimiento_Cabecera_Viatico)
        {
            return Recupera_Requerimiento_Cabecera_Viatico(intIdRequrimiento_Cabecera_Viatico);
        }

        public int Graba_Requerimiento_Cabecera_Viatico(Model.Requerimiento_Cabecera_Viatico obj)
        {
            return Graba_Requerimiento_Cabecera_Viatico(obj);
        }

        public int Modifica_Requerimiento_Cabecera_Viatico(Model.Requerimiento_Cabecera_Viatico obj)
        {
            return Modifica_Requerimiento_Cabecera_Viatico(obj);
        }


        public Boolean Elimina_Requerimiento_Cabecera_Viatico(int intIdRequerimiento_Cabecera_Viatico)
        {
            return Elimina_Requerimiento_Cabecera_Viatico(intIdRequerimiento_Cabecera_Viatico);
        }

        public DataSet Lista_Requerimiento_Cabecera_Viatico(string strNumRequerimiento)
        {
            return Lista_Requerimiento_Cabecera_Viatico(strNumRequerimiento);
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
            return Recupera_Saldo_vs_Tope( strAñoProceso,
                                        strCodTipoGasto,
                                        strCodFuenteFinanciamiento,
                                        strCodProyecto,
                                        strCodComponente
                                      );
        }

        public Model.Requerimiento_Detalle Recupera_Requerimiento_Detalle(int intIdRequrimiento_Detalle)
        {
            return Recupera_Requerimiento_Detalle(intIdRequrimiento_Detalle);
        }

        public int Graba_Requerimiento_Detalle(Model.Requerimiento_Detalle obj)
        {
            return Graba_Requerimiento_Detalle(obj);
        }

        public int Modifica_Requerimiento_Detalle(Model.Requerimiento_Detalle obj)
        {
            return Modifica_Requerimiento_Detalle(obj);
        }

        public int Elimina_Requerimiento_Detalle(int intIdRequerimiento_Detalle,
                                                 Boolean EsCofinanciado,
                                                 string strNumRequerimiento,
                                                 string strCodTipoAdquisicion
                                                )
        {
            return Elimina_Requerimiento_Detalle( intIdRequerimiento_Detalle,
                                                  EsCofinanciado,
                                                  strNumRequerimiento,
                                                  strCodTipoAdquisicion
                                                );
        }

        public DataSet Lista_Requerimiento_Detalle(string strNumRequerimiento)
        {
            return Lista_Requerimiento_Detalle(strNumRequerimiento);
        }

        public DataSet Lista_EjecucionPresupuestal_CentroGestor(string strAñoProceso, string strCodCentroGestor)
        {
            return Lista_EjecucionPresupuestal_CentroGestor(strAñoProceso, strCodCentroGestor);
        }

        public DataSet Lista_Consulta_LineaFormulacion(string strAñoProceso, string strCodCentroGestor)
        {
            return Lista_Consulta_LineaFormulacion(strAñoProceso, strCodCentroGestor);
        }

        public DataSet Lista_EjecucionPresupuestal_CentroGestor_Grafico(string strAñoProceso,
                                                                       string strCodCentroGestor,
                                                                       string strCodCentroCosto,
                                                                       string strCodClasificador
                                                                      )
        {
            return Lista_EjecucionPresupuestal_CentroGestor_Grafico( strAñoProceso,
                                                                     strCodCentroGestor,
                                                                     strCodCentroCosto,
                                                                       strCodClasificador
                                                                      );
        }

        public DataSet Lista_EjecucionPresupuestal_Proyecto(string strAñoProceso, string strCodProyecto)
        {
            return Lista_EjecucionPresupuestal_Proyecto(strAñoProceso, strCodProyecto);
        }


        public DataSet Lista_Requerimiento_Detalle_Requerido(Model.Formulacion_Saldo obj)
        {
            return Lista_Requerimiento_Detalle_Requerido(obj);
        }

        public DataSet Lista_Requerimiento_Detalle_Ejecutado(Model.Formulacion_Saldo obj)
        {
            return Lista_Requerimiento_Detalle_Ejecutado(obj);
        }

        public DataSet Lista_Requerimiento_Detalle_Ajustado(Model.Formulacion_Saldo obj)
        {
            return Lista_Requerimiento_Detalle_Ajustado(obj);
        }

        public DataSet Lista_Requerimiento_Detalle_Requerimiento(Model.Formulacion_Saldo obj)
        {
            return Lista_Requerimiento_Detalle_Requerimiento(obj);
        }

        public DataSet Lista_Ajustado_CentroGestor(string strAñoProceso,
                                                    string strCodCentroGestor,
                                                    string strCodCentroCosto,
                                                    string strCodClasificador
                                                  )
        {
            return Lista_Ajustado_CentroGestor( strAñoProceso,
                                                 strCodCentroGestor,
                                                 strCodCentroCosto,
                                                  strCodClasificador
                                                  );
        }

        public DataSet Lista_Ajustado_SinAprobacion(string strAñoProceso,
                                                    string strCodCentroGestor
                                                  )
        {
            return Lista_Ajustado_SinAprobacion( strAñoProceso,
                                                  strCodCentroGestor
                                                  );
        }

        public DataSet Lista_Formulado_CentroGestor(string strAñoProceso,
                                                    string strCodCentroGestor,
                                                    string strCodCentroCosto,
                                                    string strCodClasificador
                                                  )
        {
            return Lista_Formulado_CentroGestor( strAñoProceso,
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
            return Lista_Disponible_CentroGestor(strAñoProceso,
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
            return Lista_Ejecutado_CentroGestor(strAñoProceso,
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
            return Lista_Comprometido_CentroGestor(strAñoProceso,
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
            return Lista_Formulado_Proyecto( strAñoProceso,
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
            return Lista_Ajustado_Proyecto( strAñoProceso,
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
            return Lista_Disponible_Proyecto(strAñoProceso,
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
            return Lista_Ejecutado_Proyecto(strAñoProceso,
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
            return Lista_Comprometido_Proyecto( strAñoProceso,
                                                strCodFuenteFinanciamiento,
                                                 strCodProyecto,
                                                  strCodClasificador
                                                  );
        }

        public DataSet Formato_Requerimiento(string strNumRequerimiento)
        {
            return Formato_Requerimiento(strNumRequerimiento);
        }

        public DataSet Formato_Requerimiento_Estado(string strCodCentro_Gestor,
                                                    string strEstado,
                                                    string strCodEmpleado
                                                   )
        {
            return Formato_Requerimiento_Estado(strCodCentro_Gestor,
                                                 strEstado,
                                                 strCodEmpleado
                                                   );
        }

        public DataSet Formato_Requerimiento_PasePresupuestal(string strCodCompañia,
                                                              string strAñoProceso
                                                            )
        {
            return Formato_Requerimiento_PasePresupuestal(strCodCompañia,
                                                           strAñoProceso
                                                            );
        }


        public DataSet Formato_Requerimiento_Cege(string strCodCentro_Gestor)
        {
            return Formato_Requerimiento_Cege(strCodCentro_Gestor);
        }

        public Boolean Formato_Requerimiento_Firma(string strCodCentro_Gestor,
                                                    string strPaso,
                                                    string strNumRequerimiento,
                                                    string strCodEmpleado
                                                   )
        {
            return Formato_Requerimiento_Firma( strCodCentro_Gestor,
                                                strPaso,
                                               strNumRequerimiento,
                                                strCodEmpleado
                                                   );
        }

        public Boolean Graba_Requerimiento_PasePresupuestal(string strNumRequerimiento,
                                                                string strCodMensaje,
                                                                string strMensaje,
                                                                string strCodEmpleado
                                                             )
        {
            return Graba_Requerimiento_PasePresupuestal( strNumRequerimiento,
                                                                strCodMensaje,
                                                                strMensaje,
                                                                 strCodEmpleado
                                                             );
        }

        public Boolean Formato_Requerimiento_DescarteFirma(string strNumRequerimiento,
                                                            string strCodMotivoDescarte,
                                                            DateTime dateFecDescarte,
                                                            string strMotivoDescarte
                                                          )
        {
            return Formato_Requerimiento_DescarteFirma(strNumRequerimiento,
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
            return Graba_Requerimiento_DescartePasePresupuestal(strNumRequerimiento,
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
            return Formato_Requerimiento_Anulacion( strNumRequerimiento,
                                                   strCodMotivoDescarte,
                                                   dateFecDescarte,
                                                   strMotivoDescarte
                                                  );
        }

        #endregion

        #region Requerimiento_Detalle_Bien
        public Model.Requerimiento_Detalle_Bien Recupera_Requerimiento_Detalle_Bien(int intIdRequrimiento_Detalle_Bien)
        {
            return Recupera_Requerimiento_Detalle_Bien(intIdRequrimiento_Detalle_Bien);
        }

        public int Graba_Requerimiento_Detalle_Bien(Model.Requerimiento_Detalle_Bien obj)
        {
            return Graba_Requerimiento_Detalle_Bien(obj);
        }

        public int Modifica_Requerimiento_Detalle_Bien(Model.Requerimiento_Detalle_Bien obj)
        {
            return Modifica_Requerimiento_Detalle_Bien(obj);
        }

        public int Elimina_Requerimiento_Detalle_Bien(int intIdRequerimiento_Detalle_Bien)
        {
            return Elimina_Requerimiento_Detalle_Bien(intIdRequerimiento_Detalle_Bien);
        }

        #endregion

        #region Requerimiento_Detalle_CoFinanciado
        public Model.Requerimiento_Detalle_CoFinanciado Recupera_Requerimiento_Detalle_CoFinanciado(string strNumRequerimiento)
        {
            return Recupera_Requerimiento_Detalle_CoFinanciado(strNumRequerimiento);
        }

        public int Graba_Requerimiento_Detalle_CoFinanciado(Model.Requerimiento_Detalle_CoFinanciado obj)
        {
            return Graba_Requerimiento_Detalle_CoFinanciado(obj);
        }

        public int Modifica_Requerimiento_Detalle_CoFinanciado(Model.Requerimiento_Detalle_CoFinanciado obj)
        {
            return Modifica_Requerimiento_Detalle_CoFinanciado(obj);
        }

        public int Elimina_Requerimiento_Detalle_CoFinanciado(string strNumRequerimiento)
        {
            return Elimina_Requerimiento_Detalle_CoFinanciado(strNumRequerimiento);
        }

        #endregion

        #region Requerimiento_Detalle_Cronograma
        public bool graba_Requerimiento_Detalle_Cronograma(Model.Requerimiento_Detalle_Cronograma obj)
        {
            return graba_Requerimiento_Detalle_Cronograma(obj);
        }

        public Model.Requerimiento_Detalle_Cronograma recupera_Requerimiento_Detalle_Cronograma(int intIdRequerimiento_Detalle)
        {
            return recupera_Requerimiento_Detalle_Cronograma(intIdRequerimiento_Detalle);
        }

        #endregion

        #region Requerimiento_Detalle_Servicio
        public Model.Requerimiento_Detalle_Servicio Recupera_Requerimiento_Detalle_Servicio(int intIdRequrimiento_Detalle_Servicio)
        {
            return Recupera_Requerimiento_Detalle_Servicio(intIdRequrimiento_Detalle_Servicio);
        }

        public int Graba_Requerimiento_Detalle_Servicio(Model.Requerimiento_Detalle_Servicio obj)
        {
            return Graba_Requerimiento_Detalle_Servicio(obj);
        }

        public int Modifica_Requerimiento_Detalle_Servicio(Model.Requerimiento_Detalle_Servicio obj)
        {
            return Modifica_Requerimiento_Detalle_Servicio(obj);
        }

        public int Elimina_Requerimiento_Detalle_Servicio(int intIdRequerimiento_Detalle_Servicio)
        {
            return Elimina_Requerimiento_Detalle_Servicio(intIdRequerimiento_Detalle_Servicio);
        }

        #endregion

        #region ReasignacionAPP
        public List<Model.Ajuste> GetReasignacion(string strNumAjuste)
        {
            return GetReasignacion(strNumAjuste);
        }

        public List<Model.Ajuste> GetListaReasignacion(string strCodCentroGestor)
        {
            return GetListaReasignacion(strCodCentroGestor);
        }

        private Model.Ajuste GetEmpDataTableRowAPP(DataRow dr)
        {
            return GetEmpDataTableRowAPP(dr);
        }

        #endregion

        #region Clasificacion
        public DataSet Ayuda_Clasificacion()
        {
            return Ayuda_Clasificacion();
        }

        public DataSet Ayuda_Clasificacion_Formulacion(string strAñoProceso)
        {
            return Ayuda_Clasificacion_Formulacion(strAñoProceso);
        }

        #endregion

        #region PosicionPresupuestal
        public DataSet Lista_PosicionPresupuestal(string strCodCompañia)
        {
            return Lista_PosicionPresupuestal(strCodCompañia);
        }

        public DataSet Ayuda_PosicionPresupuestal_FuenteFinanciamiento(string strCodCompañia,
                                                                        string strCodFuenteFinanciamiento
                                                                      )
        {
            return Ayuda_PosicionPresupuestal_FuenteFinanciamiento(strCodCompañia,
                                                                    strCodFuenteFinanciamiento
                                                                      );
        }

        public DataSet Ayuda_PosicionPresupuestal(string strCodCompañia)
        {
            return Ayuda_PosicionPresupuestal(strCodCompañia);
        }

        public DataSet Ayuda_PosicionPresupuestal_Clasificador(string strCodCompañia,
                                                                string strCodClasificador,
                                                               string strCodFuenteFinanciamiento
                                                                )
        {
            return Ayuda_PosicionPresupuestal_Clasificador(strCodCompañia,
                                                           strCodClasificador,
                                                           strCodFuenteFinanciamiento
                                                                );
        }

        public DataSet Ayuda_PosicionPresupuestal_Formulacion(string strCodCompañia,
                                                              string strAñoProceso
                                                            )
        {
            return Ayuda_PosicionPresupuestal_Formulacion(strCodCompañia,
                                                          strAñoProceso
                                                            );
        }


        public Model.PosicionPresupuestal Recupera_PosicionPresupuestal_Codigo(string strCodCompañia,
                                                                                string strCodPosPre
                                                                              )
        {
            return Recupera_PosicionPresupuestal_Codigo(strCodCompañia,
                                                                                strCodPosPre
                                                                              );
        }

        public Model.PosicionPresupuestal Recupera_PosicionPresupuestal(int intIdCodPosPre)
        {
            return Recupera_PosicionPresupuestal(intIdCodPosPre);
        }

        public int Graba_PosicionPresupuestal(Model.PosicionPresupuestal obj)
        {
            return Graba_PosicionPresupuestal(obj);
        }

        public int Modifica_PosicionPresupuestal(Model.PosicionPresupuestal obj)
        {
            return Modifica_PosicionPresupuestal(obj);
        }

        public bool Elimina_PosicionPresupuestal(int intIdPosPre)
        {
            return Elimina_PosicionPresupuestal(intIdPosPre);
        }

        #endregion

        #region FuenteFinanciamiento
        public DataSet Ayuda_FuenteFinanciamiento_Reporte(string strCodEmpresa)
        {
            return Ayuda_FuenteFinanciamiento_Reporte(strCodEmpresa);
        }

        public DataSet Combo_FuenteFinanciamiento_Reporte(string strCodEmpresa)
        {
            return Combo_FuenteFinanciamiento_Reporte(strCodEmpresa);
        }

        public DataSet Ayuda_FuenteFinanciamiento_Proyecto(string strCodProyecto)
        {
            return Ayuda_FuenteFinanciamiento_Proyecto(strCodProyecto);
        }
        public DataSet Ayuda_FuenteFinanciamiento()
        {
            return Ayuda_FuenteFinanciamiento();
        }

        public DataSet Combo_FuenteFinanciamiento()
        {
            return Combo_FuenteFinanciamiento();
        }

        public DataSet Combo_FuenteFinanciamiento_Pase()
        {
            return Combo_FuenteFinanciamiento_Pase();
        }

        public Model.FuenteFinanciamiento Recupera_FuenteFinanciamiento(int intIdFuenteFinanciamiento)
        {
            return Recupera_FuenteFinanciamiento(intIdFuenteFinanciamiento);
        }

        public Model.FuenteFinanciamiento Recupera_FuenteFinanciamiento_Codigo(string strCodFuenteFinanciamiento)
        {
            return Recupera_FuenteFinanciamiento_Codigo(strCodFuenteFinanciamiento);
        }


        public int Graba_FuenteFinanciamiento(Model.FuenteFinanciamiento obj)
        {
            return Graba_FuenteFinanciamiento(obj);
        }

        public int Modifica_FuenteFinanciamiento(Model.FuenteFinanciamiento obj)
        {
            return Modifica_FuenteFinanciamiento(obj);
        }

        public DataSet Lista_FuenteFinanciamiento()
        {
            return Lista_FuenteFinanciamiento();
        }

        public Boolean Elimina_FuenteFinanciamiento(int intIdFuenteFinanciamiento)
        {
            return Elimina_FuenteFinanciamiento(intIdFuenteFinanciamiento);
        }

        #endregion

        #region Familia_PosicionPresupustal
        public DataSet Combo_FamiliaPosicionPresupuestal()
        {
            return Combo_FamiliaPosicionPresupuestal();
        }

        public DataSet Ayuda_FamiliaPosicionPresupuestal()
        {
            return Ayuda_FamiliaPosicionPresupuestal();
        }

        public Model.FamiliaPosicionPresupuestal Recupera_FamiliaPosicionPresupuestal(int intIdFamiliaPosicionPresupuestal)
        {
            return Recupera_FamiliaPosicionPresupuestal(intIdFamiliaPosicionPresupuestal);
        }


        public Model.FamiliaPosicionPresupuestal Recupera_FamiliaPosicionPresupuestal_Codigo(string strCodFamiliaPosicionPresupuestal)
        {
            return Recupera_FamiliaPosicionPresupuestal_Codigo(strCodFamiliaPosicionPresupuestal);
        }

        public int Graba_FamiliaPosicionPresupuestal(Model.FamiliaPosicionPresupuestal obj)
        {
            return Graba_FamiliaPosicionPresupuestal(obj);
        }

        public int Modifica_FamiliaPosicionPresupuestal(Model.FamiliaPosicionPresupuestal obj)
        {
            return Modifica_FamiliaPosicionPresupuestal(obj);
        }

        public bool Elimina_FamiliaPosicionPresupuestal(int intIdFamiliaPosicionPresupuestal)
        {
            return Elimina_FamiliaPosicionPresupuestal(intIdFamiliaPosicionPresupuestal);
        }

        public DataSet Lista_FamiliaPosicionPresupuestal()
        {
            return Lista_FamiliaPosicionPresupuestal();
        }

        #endregion

        #region LineaPosicionPresupuestal
        public DataSet Combo_LineaPosicionPresupuestal(string strCodFamiliaPosicionPresupuestal)
        {
            return Combo_LineaPosicionPresupuestal(strCodFamiliaPosicionPresupuestal);
        }

        public DataSet Ayuda_LineaPosicionPresupuestal(string strCodFamiliaPosicionPresupuestal)
        {
            return Ayuda_LineaPosicionPresupuestal(strCodFamiliaPosicionPresupuestal);
        }

        public Model.LineaPosicionPresupuestal Recupera_LineaPosicionPresupuestal(int intIdLineaPosicionPresupuestal)
        {
            return Recupera_LineaPosicionPresupuestal(intIdLineaPosicionPresupuestal);
        }


        public Model.LineaPosicionPresupuestal Recupera_LineaPosicionPresupuestal_Codigo(string strCodLineaPosicionPresupuestal)
        {
            return Recupera_LineaPosicionPresupuestal_Codigo(strCodLineaPosicionPresupuestal);
        }

        public int Graba_LineaPosicionPresupuestal(Model.LineaPosicionPresupuestal obj)
        {
            return Graba_LineaPosicionPresupuestal(obj);
        }

        public int Modifica_LineaPosicionPresupuestal(Model.LineaPosicionPresupuestal obj)
        {
            return Modifica_LineaPosicionPresupuestal(obj);
        }

        public bool Elimina_LineaPosicionPresupuestal(int intIdLineaPosicionPresupuestal)
        {
            return Elimina_LineaPosicionPresupuestal(intIdLineaPosicionPresupuestal);
        }

        public DataSet Lista_LineaPosicionPresupuestal(string strCodFamiliaPosicionPresupuestal)
        {
            return Lista_LineaPosicionPresupuestal(strCodFamiliaPosicionPresupuestal);
        }

        #endregion

        #region TipoClasificador
        public DataSet Combo_TipoClasificador()
        {
            return Combo_TipoClasificador();
        }
        #endregion

        #region TopePresupuestal
        public Double Recupera_TopePresupuestal_Saldo(Model.TopePresupuestal obj
                                                              )
        {
            return Recupera_TopePresupuestal_Saldo(obj  );
        }

        public Model.TopePresupuestal Recupera_TopePresupuestal(int intIdTopePresupuestal)
        {
            return Recupera_TopePresupuestal(intIdTopePresupuestal);
        }

        public int Graba_TopePresupuestal(Model.TopePresupuestal obj)
        {
            return Graba_TopePresupuestal(obj);
        }

        public int Modifica_TopePresupuestal(Model.TopePresupuestal obj)
        {
            return Modifica_TopePresupuestal(obj);
        }

        public bool Elimina_TopePresupuestal(int intidTopePresupuestal)
        {
            return Elimina_TopePresupuestal(intidTopePresupuestal);
        }


        public DataSet Lista_TopePresupuestal(string strCodEmpresa, string strAñoProceso, string strVersion)
        {
            return Lista_TopePresupuestal(strCodEmpresa, strAñoProceso, strVersion);
        }

        #endregion

        #region Empleado_CentroGestor
        public DataSet Arbol_Empleado()
        {
            return Arbol_Empleado();
        }
        public int Graba_Empleado_CentroGestor(int iCodEmpleado, string strCodCege)
        {
            return Graba_Empleado_CentroGestor(iCodEmpleado, strCodCege);
        }

        public int Modifica_Empleado_CentroGestor(int iCodEmpleado, string strCodCege)
        {
            return Modifica_Empleado_CentroGestor(iCodEmpleado, strCodCege);
        }

        public DataSet Recupera_Empleado_CentroGestor(int iCodEmpleado)
        {
            return Recupera_Empleado_CentroGestor(iCodEmpleado);
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
            return Lista_Formulacion_ResumenClasificador_Gasto(strCodCompañia,
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
            return Lista_Formulacion_HojaTrabajo_Gasto(strCodCompañia,
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
            return Lista_Formulacion_ResumenClasificador_Ingreso( strCodCompañia,
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
            return Lista_Formulacion_HojaTrabajo_Ingreso(strCodCompañia,
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
            return Lista_FormulacionReporteProyecto(cCodCompañia, strAñoProceso, strVersion, cCodTipoFormulacion, cCodProyecto);
        }

        public DataSet Lista_FormulacionReporteProyecto_CentroGestor(string cCodCompañia,
                                                                    string cCodTipoFormulacion,
                                                                    string cCodProyecto,
                                                                    string cCodCentroGestor_Gestor
            )
        {
            return Lista_FormulacionReporteProyecto_CentroGestor( cCodCompañia,
                                                                  cCodTipoFormulacion,
                                                                   cCodProyecto,
                                                                   cCodCentroGestor_Gestor
                                                                );
        }


        public DataSet Lista_FormulacionReporteContrato(string cCodCompañia, string cNumeroOrden, string cTipoOrden)
        {
            return Lista_FormulacionReporteContrato(cCodCompañia, cNumeroOrden, cTipoOrden);
        }


        public DataSet Help_FormulacionTipoFormulacion()
        {
            return Help_FormulacionTipoFormulacion();
        }

        public DataSet Lista_FormulacionReporteProyecto_Cege(string cCodCompañia, string strAñoProceso, string strVersion, string cCodTipoFormulacion, string CodCentroGestor)
        {
            return Lista_FormulacionReporteProyecto_Cege(cCodCompañia, strAñoProceso, strVersion, cCodTipoFormulacion, CodCentroGestor);
        }

        public DataSet Formato_4P(string strCodCompañia,
                                  string strAñoProceso,
                                  string strVersion,
                                  string strCodFuenteFinanciamiento,
                                  string strCodCentroGestor,
                                  string strCodProyecto
                                )
        {
            return Formato_4P(strCodCompañia,
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
            return Formato_4E( strCodCompañia,
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
            return Reporte_Detalle_Formulacion(strCodCompañia,
                                   strAñoProceso,
                                   strVersion,
                                   strCodFuenteFinanciamiento,
                                   strCodCentroGestor,
                                   strCodProyecto
                                );
        }

        public DataSet Lista_FormulacionReporteProyecto_Saldo(string cCodCompañia)
        {
            return Lista_FormulacionReporteProyecto_Saldo(cCodCompañia);
        }

        public DataSet Reporte_ResumenGasto(string strCodCompañia,
                                            string strPeriodoInicial,
                                            string strPeriodoFinal,
                                            int intTipoReporte
                                            )
        {
            return Reporte_ResumenGasto(strCodCompañia,
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
            return Ayuda_CadenaFuncionalProyecto();
        }
        public DataSet Lista_CadenaFuncionalProyecto()
        {
            return Lista_CadenaFuncionalProyecto();
        }

        public DataSet Combo_CadenaFuncionalProyecto_Reporte()
        {
            return Combo_CadenaFuncionalProyecto_Reporte();
        }

        public DataSet Combo_CadenaFuncionalProyecto()
        {
            return Combo_CadenaFuncionalProyecto();
        }
        public Model.CadenaFuncionalProyecto Recupera_CadenaFuncionalProyecto(int intIdCadenaFuncionalProyecto)
        {
            return Recupera_CadenaFuncionalProyecto(intIdCadenaFuncionalProyecto);
        }

        public Model.CadenaFuncionalProyecto Recupera_CadenaFuncionalProyecto_codigo(string strCodCadenaFuncionalProyecto)
        {
            return Recupera_CadenaFuncionalProyecto_codigo(strCodCadenaFuncionalProyecto);
        }
        public int Graba_CadenaFuncionalProyecto(Model.CadenaFuncionalProyecto obj)
        {
            return Graba_CadenaFuncionalProyecto(obj);
        }
        public int Modifica_CadenaFuncionalProyecto(Model.CadenaFuncionalProyecto obj)
        {
            return Modifica_CadenaFuncionalProyecto(obj);
        }

        public bool Elimina_CadenaFuncionalProyecto(int intIdCadenaFuncionalProyecto)
        {
            return Elimina_CadenaFuncionalProyecto(intIdCadenaFuncionalProyecto);
        }

        #endregion

        #region ClaseProyecto
        public DataSet Ayuda_ClaseProyecto()
        {
            return Ayuda_ClaseProyecto();
        }
        public DataSet Lista_ClaseProyecto()
        {
            return Lista_ClaseProyecto();
        }

        public DataSet Naturaleza_ClaseProyecto()
        {
            return Naturaleza_ClaseProyecto();
        }

        public DataSet Combo_ClaseProyecto_Reporte()
        {
            return Combo_ClaseProyecto_Reporte();
        }

        public DataSet Combo_ClaseProyecto()
        {
            return Combo_ClaseProyecto();
        }
        public Model.ClaseProyecto Recupera_ClaseProyecto(int intIdClaseProyecto)
        {
            return Recupera_ClaseProyecto(intIdClaseProyecto);
        }

        public Model.ClaseProyecto Recupera_ClaseProyecto_codigo(string strCodClaseProyecto)
        {
            return Recupera_ClaseProyecto_codigo(strCodClaseProyecto);
        }
        public int Graba_ClaseProyecto(Model.ClaseProyecto obj)
        {
            return Graba_ClaseProyecto(obj);
        }
        public int Modifica_ClaseProyecto(Model.ClaseProyecto obj)
        {
            return Modifica_ClaseProyecto(obj);
        }

        public bool Elimina_ClaseProyecto(int intIdClaseProyecto)
        {
            return Elimina_ClaseProyecto(intIdClaseProyecto);
        }
        #endregion

        #region EstadoProyecto
        public DataSet Ayuda_EstadoProyecto()
        {
            return Ayuda_EstadoProyecto();
        }

        public DataSet Lista_EstadoProyecto()
        {
            return Lista_EstadoProyecto();
        }

        public DataSet Combo_EstadoProyecto_Reporte()
        {
            return Combo_EstadoProyecto_Reporte();
        }

        public DataSet Combo_EstadoProyecto()
        {
            return Combo_EstadoProyecto();
        }
        public Model.EstadoProyecto Recupera_EstadoProyecto(int intIdEstadoProyecto)
        {
            return Recupera_EstadoProyecto(intIdEstadoProyecto);
        }

        public Model.EstadoProyecto Recupera_EstadoProyecto_codigo(string strCodEstadoProyecto)
        {
            return Recupera_EstadoProyecto_codigo(strCodEstadoProyecto);
        }
        public int Graba_EstadoProyecto(Model.EstadoProyecto obj)
        {
            return Graba_EstadoProyecto(obj);
        }
        public int Modifica_EstadoProyecto(Model.EstadoProyecto obj)
        {
            return Modifica_EstadoProyecto(obj);
        }

        public bool Elimina_EstadoProyecto(int intIdEstadoProyecto)
        {
            return Elimina_EstadoProyecto(intIdEstadoProyecto);
        }

        #endregion

        #region EtapaProyecto
        public DataSet Lista_EtapaProyecto()
        {
            return Lista_EtapaProyecto();
        }

        public DataSet Ayuda_EtapaProyecto()
        {
            return Ayuda_EtapaProyecto();
        }

        public DataSet Combo_EtapaProyecto_Reporte()
        {
            return Combo_EtapaProyecto_Reporte();
        }

        public DataSet Combo_EtapaProyecto()
        {
            return Combo_EtapaProyecto();
        }
        public Model.EtapaProyecto Recupera_EtapaProyecto(int intIdEtapaProyecto)
        {
            return Recupera_EtapaProyecto(intIdEtapaProyecto);
        }

        public Model.EtapaProyecto Recupera_EtapaProyecto_codigo(string strCodEtapaProyecto)
        {
            return Recupera_EtapaProyecto_codigo(strCodEtapaProyecto);
        }
        public int Graba_EtapaProyecto(Model.EtapaProyecto obj)
        {
            return Graba_EtapaProyecto(obj);
        }
        public int Modifica_EtapaProyecto(Model.EtapaProyecto obj)
        {
            return Modifica_EtapaProyecto(obj);
        }

        public bool Elimina_EtapaProyecto(int intIdEtapaProyecto)
        {
            return Elimina_EtapaProyecto(intIdEtapaProyecto);
        }

        #endregion

        #region Fase_ActividadProyecto
        public DataSet Lista_Fase_ActividadProyecto()
        {
            return Lista_Fase_ActividadProyecto();
        }

        public DataSet Lista_Fase_ActividadProyecto_Clase(string strCodClaseProyecto)
        {
            return Lista_Fase_ActividadProyecto_Clase(strCodClaseProyecto);
        }

        public DataSet Ayuda_Fase_ActividadProyecto()
        {
            return Ayuda_Fase_ActividadProyecto();
        }

        public DataSet Combo_Fase_ActividadProyecto_Reporte()
        {
            return Combo_Fase_ActividadProyecto_Reporte();
        }

        public DataSet Combo_Fase_ActividadProyecto()
        {
            return Combo_Fase_ActividadProyecto();
        }
        public Model.Fase_ActividadProyecto Recupera_Fase_ActividadProyecto(int intIdFase_ActividadProyecto)
        {
            return Recupera_Fase_ActividadProyecto(intIdFase_ActividadProyecto);
        }

        public Model.Fase_ActividadProyecto Recupera_Fase_ActividadProyecto_codigo(string strCodFase_ActividadProyecto)
        {
            return Recupera_Fase_ActividadProyecto_codigo(strCodFase_ActividadProyecto);
        }
        public int Graba_Fase_ActividadProyecto(Model.Fase_ActividadProyecto obj)
        {
            return Graba_Fase_ActividadProyecto(obj);
        }
        public int Modifica_Fase_ActividadProyecto(Model.Fase_ActividadProyecto obj)
        {
            return Modifica_Fase_ActividadProyecto(obj);
        }

        public bool Elimina_Fase_ActividadProyecto(int intIdFase_ActividadProyecto)
        {
            return Elimina_Fase_ActividadProyecto(intIdFase_ActividadProyecto);
        }

        #endregion

        #region GrupoClaseProyecto
        public DataSet Ayuda_GrupoClaseProyecto()
        {
            return Ayuda_GrupoClaseProyecto();
        }
        public DataSet Lista_GrupoClaseProyecto()
        {
            return Lista_GrupoClaseProyecto();
        }

        public DataSet GrupoClase_GrupoClaseProyecto()
        {
            return GrupoClase_GrupoClaseProyecto();
        }

        public DataSet Combo_GrupoClaseProyecto_Reporte()
        {
            return Combo_GrupoClaseProyecto_Reporte();
        }

        public DataSet Combo_GrupoClaseProyecto()
        {
            return Combo_GrupoClaseProyecto();
        }
        public Model.GrupoClaseProyecto Recupera_GrupoClaseProyecto(int intIdGrupoClaseProyecto)
        {
            return Recupera_GrupoClaseProyecto(intIdGrupoClaseProyecto);
        }

        public Model.GrupoClaseProyecto Recupera_GrupoClaseProyecto_codigo(string strCodGrupoClaseProyecto)
        {
            return Recupera_GrupoClaseProyecto_codigo(strCodGrupoClaseProyecto);
        }
        public int Graba_GrupoClaseProyecto(Model.GrupoClaseProyecto obj)
        {
            return Graba_GrupoClaseProyecto(obj);
        }
        public int Modifica_GrupoClaseProyecto(Model.GrupoClaseProyecto obj)
        {
            return Modifica_GrupoClaseProyecto(obj);
        }

        public bool Elimina_GrupoClaseProyecto(int intIdGrupoClaseProyecto)
        {
            return Elimina_GrupoClaseProyecto(intIdGrupoClaseProyecto);
        }

        #endregion

        #region GrupoProyecto
        public DataSet Lista_GrupoProyecto()
        {
            return Lista_GrupoProyecto();
        }

        public DataSet Ayuda_GrupoProyecto()
        {
            return Ayuda_GrupoProyecto();
        }

        public DataSet Combo_GrupoProyecto_Reporte()
        {
            return Combo_GrupoProyecto_Reporte();
        }

        public DataSet Combo_GrupoProyecto()
        {
            return Combo_GrupoProyecto();
        }
        public Model.GrupoProyecto Recupera_GrupoProyecto(int intIdGrupoProyecto)
        {
            return Recupera_GrupoProyecto(intIdGrupoProyecto);
        }

        public Model.GrupoProyecto Recupera_GrupoProyecto_codigo(string strCodGrupoProyecto)
        {
            return Recupera_GrupoProyecto_codigo(strCodGrupoProyecto);
        }
        public int Graba_GrupoProyecto(Model.GrupoProyecto obj)
        {
            return Graba_GrupoProyecto(obj);
        }
        public int Modifica_GrupoProyecto(Model.GrupoProyecto obj)
        {
            return Modifica_GrupoProyecto(obj);
        }

        public bool Elimina_GrupoProyecto(int intIdGrupoProyecto)
        {
            return Elimina_GrupoProyecto(intIdGrupoProyecto);
        }

        #endregion

        #region MacroProyecto
        public DataSet Lista_MacroProyecto()
        {
            return Lista_MacroProyecto();
        }

        public DataSet Ayuda_MacroProyecto()
        {
            return Ayuda_MacroProyecto();
        }


        public DataSet Combo_MacroProyecto_Reporte()
        {
            return Combo_MacroProyecto_Reporte();
        }

        public DataSet Combo_MacroProyecto()
        {
            return Combo_MacroProyecto();
        }
        public Model.MacroProyecto Recupera_MacroProyecto(int intIdMacroProyecto)
        {
            return Recupera_MacroProyecto(intIdMacroProyecto);
        }

        public Model.MacroProyecto Recupera_MacroProyecto_codigo(string strCodMacroProyecto)
        {
            return Recupera_MacroProyecto_codigo(strCodMacroProyecto);
        }
        public int Graba_MacroProyecto(Model.MacroProyecto obj)
        {
            return Graba_MacroProyecto(obj);
        }
        public int Modifica_MacroProyecto(Model.MacroProyecto obj)
        {
            return Modifica_MacroProyecto(obj);
        }

        public bool Elimina_MacroProyecto(int intIdMacroProyecto)
        {
            return Elimina_MacroProyecto(intIdMacroProyecto);
        }

        #endregion

        #region NaturalezaProyecto
        public DataSet Ayuda_NaturalezaProyecto()
        {
            return Ayuda_NaturalezaProyecto();
        }
        public DataSet Lista_NaturalezaProyecto()
        {
            return Lista_NaturalezaProyecto();
        }

        public DataSet Naturaleza_NaturalezaProyecto()
        {
            return Naturaleza_NaturalezaProyecto();
        }

        public DataSet Combo_NaturalezaProyecto_Reporte()
        {
            return Combo_NaturalezaProyecto_Reporte();
        }

        public DataSet Combo_NaturalezaProyecto()
        {
            return Combo_NaturalezaProyecto();
        }
        public Model.NaturalezaProyecto Recupera_NaturalezaProyecto(int intIdNaturalezaProyecto)
        {
            return Recupera_NaturalezaProyecto(intIdNaturalezaProyecto);
        }

        public Model.NaturalezaProyecto Recupera_NaturalezaProyecto_codigo(string strCodNaturalezaProyecto)
        {
            return Recupera_NaturalezaProyecto_codigo(strCodNaturalezaProyecto);
        }
        public int Graba_NaturalezaProyecto(Model.NaturalezaProyecto obj)
        {
            return Graba_NaturalezaProyecto(obj);
        }
        public int Modifica_NaturalezaProyecto(Model.NaturalezaProyecto obj)
        {
            return Modifica_NaturalezaProyecto(obj);
        }

        public bool Elimina_NaturalezaProyecto(int intIdNaturalezaProyecto)
        {
            return Elimina_NaturalezaProyecto(intIdNaturalezaProyecto);
        }

        #endregion

        #region Proyecto
        public DataSet Ayuda_Proyecto_Componente_Spring(string strCodCompañia,
                                        string strCodProyecto
                                    )
        {
            return Ayuda_Proyecto_Componente_Spring(strCodCompañia,
                                        strCodProyecto
                                    );
        }

        public DataSet Ayuda_Proyecto_Componente(string strCodCompañia,
                                                string strCodProyecto
                                            )
        {
            return Ayuda_Proyecto_Componente( strCodCompañia,
                                              strCodProyecto
                                            );
        }

        public DataSet Ayuda_Proyecto_Componente_Servicio(string strCodCompañia)
        {
            return Ayuda_Proyecto_Componente_Servicio(strCodCompañia);
        }

        public DataSet Ayuda_Proyecto_Componente_Todos(string strCodCompañia)
        {
            return Ayuda_Proyecto_Componente_Todos(strCodCompañia);
        }

        public DataSet Graba_Proyecto_OrdenTemporal(string strCodEmpleado,
                                                    string strTipoOrden,
                                                    string strNumeroOrden
                                                  )
        {
            return Graba_Proyecto_OrdenTemporal(strCodEmpleado,
                                                 strTipoOrden,
                                                 strNumeroOrden
                                                  );
        }

        public DataSet Elimina_Proyecto_OrdenTemporal(string strCodEmpleado,
                                                    string strTipoOrden,
                                                    string strNumeroOrden
                                                  )
        {
            return Elimina_Proyecto_OrdenTemporal( strCodEmpleado,
                                                   strTipoOrden,
                                                   strNumeroOrden
                                                  );
        }
        public DataSet Ayuda_Proyecto_CentroGestor(string strCodCentroGestor, int intDigito, string strCodEmpleado)
        {
            return Ayuda_Proyecto_CentroGestor(strCodCentroGestor, intDigito, strCodEmpleado);
        }


        public DataSet Ayuda_Proyecto_Reporte(string strCodFuenteFinanciamiento,
                                              string strCodCentroGestor
                                             )
        {
            return Ayuda_Proyecto_Reporte( strCodFuenteFinanciamiento,
                                           strCodCentroGestor
                                             );
        }


        public DataSet Lista_Proyecto(string strCodEmpresa,
                                      int intTipoProyecto
                                     )
        {
            return Lista_Proyecto( strCodEmpresa,
                                    intTipoProyecto
                                     );
        }

        public DataSet Ayuda_Proyecto(string strCodEmpresa,
                                      int intTipoProyecto
            )
        {
            return Ayuda_Proyecto(strCodEmpresa,
                                   intTipoProyecto
                                    );
        }

        public DataSet Ayuda_Proyecto_FuenteFinanciamiento(string strCodEmpresa,
                                                    string strCodProyecto
                                )
        {
            return Ayuda_Proyecto_FuenteFinanciamiento(strCodEmpresa,
                                                     strCodProyecto
                                );
        }

        public DataSet Ayuda_Proyecto_y_FuenteFinanciamiento(string strCodEmpresa,
                                      int intTipoProyecto
            )
        {
            return Ayuda_Proyecto_y_FuenteFinanciamiento(strCodEmpresa,
                                                        intTipoProyecto
                                                            );
        }

        public DataSet Combo_Proyecto_Reporte(string strCodEmpresa,
                                              int intTipoProyecto
                                             )
        {
            return Combo_Proyecto_Reporte(strCodEmpresa,
                                          intTipoProyecto
                                             );
        }

        public DataSet Combo_Proyecto(string strCodEmpresa, int intTipoProyecto)
        {
            return Combo_Proyecto(strCodEmpresa, intTipoProyecto);
        }
        public Model.Proyecto Recupera_Proyecto(int intIdProyecto)
        {
            return Recupera_Proyecto(intIdProyecto);
        }

        public Model.Proyecto Recupera_Proyecto_codigo(int intTipoProyecto,
                                                        string strCodGrupoProyecto,
                                                        string strCodProyecto
                                                      )
        {
            return Recupera_Proyecto_codigo(intTipoProyecto,
                                            strCodGrupoProyecto,
                                            strCodProyecto
                                                      );
        }
        public int Graba_Proyecto(Model.Proyecto obj)
        {
            return Graba_Proyecto(obj);
        }
        public int Modifica_Proyecto(Model.Proyecto obj)
        {
            return Modifica_Proyecto(obj);
        }

        public bool Elimina_Proyecto(int intIdProyecto)
        {
            return Elimina_Proyecto(intIdProyecto);
        }

        #endregion

        #region Proyecto_CentroCosto
        public DataSet Lista_Proyecto_CentroCosto(int intIdProyecto)
        {
            return Lista_Proyecto_CentroCosto(intIdProyecto);
        }

        public int Graba_Proyecto_CentroCosto(Model.Proyecto_CentroCosto obj)
        {
            return Graba_Proyecto_CentroCosto(obj);
        }
        public int Modifica_Proyecto_CentroCosto(Model.Proyecto_CentroCosto obj)
        {
            return Modifica_Proyecto_CentroCosto(obj);
        }

        public bool Elimina_Proyecto_CentroCosto(int intIdProyecto_CentroCosto)
        {
            return Elimina_Proyecto_CentroCosto(intIdProyecto_CentroCosto);
        }

        #endregion

        #region Proyecto_Etapa
        public Model.Proyecto_Etapa Recupera_Proyecto_Etapa(int intIdProyecto_Etapa)
        {
            return Recupera_Proyecto_Etapa(intIdProyecto_Etapa);
        }

        public int Graba_Proyecto_Etapa(Model.Proyecto_Etapa obj)
        {
            return Graba_Proyecto_Etapa(obj);
        }
        public int Modifica_Proyecto_Etapa(Model.Proyecto_Etapa obj)
        {
            return Modifica_Proyecto_Etapa(obj);
        }

        public bool Elimina_Proyecto_Etapa(int intIdProyecto_Etapa)
        {
            return Elimina_Proyecto_Etapa(intIdProyecto_Etapa);
        }

        public DataSet Lista_Proyecto_Etapa(int intIdProyecto)
        {
            return Lista_Proyecto_Etapa(intIdProyecto);
        }

        #endregion

        #region Proyecto_Etapa_Actividad
        public DataSet Lista_Proyecto_Etapa_Actividad(int intIdProyecto_Etapa)
        {
            return Lista_Proyecto_Etapa_Actividad(intIdProyecto_Etapa);
        }

        public Model.Proyecto_Etapa_Actividad Recupera_Proyecto_Etapa_Actividad(int intIdProyecto_Etapa_Actividad)
        {
            return Recupera_Proyecto_Etapa_Actividad(intIdProyecto_Etapa_Actividad);
        }

        public int Graba_Proyecto_Etapa_Actividad(Model.Proyecto_Etapa_Actividad obj)
        {
            return Graba_Proyecto_Etapa_Actividad(obj);
        }
        public int Modifica_Proyecto_Etapa_Actividad(Model.Proyecto_Etapa_Actividad obj)
        {
            return Modifica_Proyecto_Etapa_Actividad(obj);
        }

        public bool Elimina_Proyecto_Etapa_Actividad(int intIdProyecto_Etapa_Actividad)
        {
            return Elimina_Proyecto_Etapa_Actividad(intIdProyecto_Etapa_Actividad);
        }

        #endregion

        #region Proyecto_Etapa_CostoFijo
        public DataSet Lista_Proyecto_Etapa_CostoFijo(int intIdProyecto_Etapa)
        {
            return Lista_Proyecto_Etapa_CostoFijo(intIdProyecto_Etapa);
        }

        public Model.Proyecto_Etapa_CostoFijo Recupera_Proyecto_Etapa_CostoFijo(int intIdProyecto_Etapa_CostoFijo)
        {
            return Recupera_Proyecto_Etapa_CostoFijo(intIdProyecto_Etapa_CostoFijo);
        }

        public int Graba_Proyecto_Etapa_CostoFijo(Model.Proyecto_Etapa_CostoFijo obj)
        {
            return Graba_Proyecto_Etapa_CostoFijo(obj);
        }
        public int Modifica_Proyecto_Etapa_CostoFijo(Model.Proyecto_Etapa_CostoFijo obj)
        {
            return Modifica_Proyecto_Etapa_CostoFijo(obj);
        }

        public bool Elimina_Proyecto_Etapa_CostoFijo(int intIdProyecto_Etapa_CostoFijo)
        {
            return Elimina_Proyecto_Etapa_CostoFijo(intIdProyecto_Etapa_CostoFijo);
        }

        #endregion

        #region Proyecto_FuenteFinanciamiento
        public DataSet Combo_Proyecto_FuenteFinanciamiento(string strCodEmpresa,
                                            string strCodProyecto
                                          )
        {
            return Combo_Proyecto_FuenteFinanciamiento( strCodEmpresa,
                                            strCodProyecto
                                          );
        }

        public DataSet Combo_Proyecto_FuenteFinanciamiento_Todos(string strCodEmpresa)
        {
            return Combo_Proyecto_FuenteFinanciamiento_Todos(strCodEmpresa);
        }

        public DataSet Lista_Proyecto_FuenteFinanciamiento(string strCodProyecto)
        {
            return Lista_Proyecto_FuenteFinanciamiento(strCodProyecto);
        }

        public int Graba_Proyecto_FuenteFinanciamiento(Model.Proyecto_FuenteFinanciamiento obj)
        {
            return Graba_Proyecto_FuenteFinanciamiento( obj);
        }
        public int Modifica_Proyecto_FuenteFinanciamiento(Model.Proyecto_FuenteFinanciamiento obj)
        {
            return Modifica_Proyecto_FuenteFinanciamiento(obj);
        }

        public bool Elimina_Proyecto_FuenteFinanciamiento(int intIdProyecto_FuenteFinanciamiento)
        {
            return Elimina_Proyecto_FuenteFinanciamiento(intIdProyecto_FuenteFinanciamiento);
        }

        #endregion

        #region TipoProyecto
        public DataSet Ayuda_TipoProyecto()
        {
            return Ayuda_TipoProyecto();
        }

        public DataSet Lista_TipoProyecto()
        {
            return Lista_TipoProyecto();
        }

        public DataSet Combo_TipoProyecto_Reporte()
        {
            return Combo_TipoProyecto_Reporte();
        }

        public DataSet Combo_TipoProyecto()
        {
            return Combo_TipoProyecto();
        }
        public Model.TipoProyecto Recupera_TipoProyecto(int intIdTipoProyecto)
        {
            return Recupera_TipoProyecto(intIdTipoProyecto);
        }

        public Model.TipoProyecto Recupera_TipoProyecto_codigo(string strCodTipoProyecto)
        {
            return Recupera_TipoProyecto_codigo(strCodTipoProyecto);
        }
        public int Graba_TipoProyecto(Model.TipoProyecto obj)
        {
            return Graba_TipoProyecto(obj);
        }
        public int Modifica_TipoProyecto(Model.TipoProyecto obj)
        {
            return Modifica_TipoProyecto(obj);
        }

        public bool Elimina_TipoProyecto(int intIdTipoProyecto)
        {
            return Elimina_TipoProyecto(intIdTipoProyecto);
        }

        #endregion

        #region UnidadEjecutoraProyecto
        public DataSet Lista_UnidadEjecutoraProyecto()
        {
            return Lista_UnidadEjecutoraProyecto();
        }

        public DataSet Ayuda_UnidadEjecutoraProyecto()
        {
            return Ayuda_UnidadEjecutoraProyecto();
        }

        public DataSet Combo_UnidadEjecutoraProyecto_Reporte()
        {
            return Combo_UnidadEjecutoraProyecto_Reporte();
        }

        public DataSet Combo_UnidadEjecutoraProyecto()
        {
            return Combo_UnidadEjecutoraProyecto();
        }
        public Model.UnidadEjecutoraProyecto Recupera_UnidadEjecutoraProyecto(int intIdUnidadEjecutoraProyecto)
        {
            return Recupera_UnidadEjecutoraProyecto(intIdUnidadEjecutoraProyecto);
        }

        public Model.UnidadEjecutoraProyecto Recupera_UnidadEjecutoraProyecto_codigo(string strCodUnidadEjecutoraProyecto)
        {
            return Recupera_UnidadEjecutoraProyecto_codigo(strCodUnidadEjecutoraProyecto);
        }
        public int Graba_UnidadEjecutoraProyecto(Model.UnidadEjecutoraProyecto obj)
        {
            return Graba_UnidadEjecutoraProyecto(obj);
        }
        public int Modifica_UnidadEjecutoraProyecto(Model.UnidadEjecutoraProyecto obj)
        {
            return Modifica_UnidadEjecutoraProyecto(obj);
        }

        public bool Elimina_UnidadEjecutoraProyecto(int intIdUnidadEjecutoraProyecto)
        {
            return Elimina_UnidadEjecutoraProyecto(intIdUnidadEjecutoraProyecto);
        }

        #endregion

        #region UnidadFormuladoraProyecto
        public DataSet Lista_UnidadFormuladoraProyecto()
        {
            return Lista_UnidadFormuladoraProyecto();
        }

        public DataSet Ayuda_UnidadFormuladoraProyecto()
        {
            return Ayuda_UnidadFormuladoraProyecto();
        }

        public DataSet Combo_UnidadFormuladoraProyecto_Reporte()
        {
            return Combo_UnidadFormuladoraProyecto_Reporte();
        }

        public DataSet Combo_UnidadFormuladoraProyecto()
        {
            return Combo_UnidadFormuladoraProyecto();
        }
        public Model.UnidadFormuladoraProyecto Recupera_UnidadFormuladoraProyecto(int intIdUnidadFormuladoraProyecto)
        {
            return Recupera_UnidadFormuladoraProyecto(intIdUnidadFormuladoraProyecto);
        }

        public Model.UnidadFormuladoraProyecto Recupera_UnidadFormuladoraProyecto_codigo(string strCodUnidadFormuladoraProyecto)
        {
            return Recupera_UnidadFormuladoraProyecto_codigo(strCodUnidadFormuladoraProyecto);
        }
        public int Graba_UnidadFormuladoraProyecto(Model.UnidadFormuladoraProyecto obj)
        {
            return Graba_UnidadFormuladoraProyecto(obj);
        }
        public int Modifica_UnidadFormuladoraProyecto(Model.UnidadFormuladoraProyecto obj)
        {
            return Modifica_UnidadFormuladoraProyecto(obj);
        }

        public bool Elimina_UnidadFormuladoraProyecto(int intIdUnidadFormuladoraProyecto)
        {
            return Elimina_UnidadFormuladoraProyecto(intIdUnidadFormuladoraProyecto);
        }

        #endregion

        #region TareaProyecto
        public DataSet Ayuda_TareaProyecto()
        {
            return Ayuda_TareaProyecto();
        }
        public DataSet Lista_TareaProyecto()
        {
            return Lista_TareaProyecto();
        }

        public DataSet Naturaleza_TareaProyecto()
        {
            return Naturaleza_TareaProyecto();
        }

        public DataSet Combo_TareaProyecto_Reporte()
        {
            return Combo_TareaProyecto_Reporte();
        }

        public DataSet Combo_TareaProyecto()
        {
            return Combo_TareaProyecto();
        }
        public Model.TareaProyecto Recupera_TareaProyecto(int intIdTareaProyecto)
        {
            return Recupera_TareaProyecto(intIdTareaProyecto);
        }

        public Model.TareaProyecto Recupera_TareaProyecto_codigo(string strCodTareaProyecto)
        {
            return Recupera_TareaProyecto_codigo(strCodTareaProyecto);
        }
        public int Graba_TareaProyecto(Model.TareaProyecto obj)
        {
            return Graba_TareaProyecto(obj);
        }
        public int Modifica_TareaProyecto(Model.TareaProyecto obj)
        {
            return Modifica_TareaProyecto(obj);
        }

        public bool Elimina_TareaProyecto(int intIdTareaProyecto)
        {
            return Elimina_TareaProyecto(intIdTareaProyecto);
        }

        #endregion

        #region TipoActividadProyecto
        public DataSet Ayuda_TipoActividadProyecto()
        {
            return Ayuda_TipoActividadProyecto();
        }
        public DataSet Lista_TipoActividadProyecto()
        {
            return Lista_TipoActividadProyecto();
        }

        public DataSet Naturaleza_TipoActividadProyecto()
        {
            return Naturaleza_TipoActividadProyecto();
        }

        public DataSet Combo_TipoActividadProyecto_Reporte()
        {
            return Combo_TipoActividadProyecto_Reporte();
        }

        public DataSet Combo_TipoActividadProyecto()
        {
            return Combo_TipoActividadProyecto();
        }
        public Model.TipoActividadProyecto Recupera_TipoActividadProyecto(int intIdTipoActividadProyecto)
        {
            return Recupera_TipoActividadProyecto(intIdTipoActividadProyecto);
        }

        public Model.TipoActividadProyecto Recupera_TipoActividadProyecto_codigo(string strCodTipoActividadProyecto)
        {
            return Recupera_TipoActividadProyecto_codigo(strCodTipoActividadProyecto);
        }
        public int Graba_TipoActividadProyecto(Model.TipoActividadProyecto obj)
        {
            return Graba_TipoActividadProyecto(obj);
        }
        public int Modifica_TipoActividadProyecto(Model.TipoActividadProyecto obj)
        {
            return Modifica_TipoActividadProyecto(obj);
        }

        public bool Elimina_TipoActividadProyecto(int intIdTipoActividadProyecto)
        {
            return Elimina_TipoActividadProyecto(intIdTipoActividadProyecto);
        }

        #endregion

        #region EstadoMacroProyecto
        public DataSet Combo_EstadoMacroProyecto()
        {
            return Combo_EstadoMacroProyecto();
        }

        #endregion

        #endregion

        #region RECURSOHUMANO
        #region "TipoMovimientoConcepto"
        public DataSet combo_TipoMovimientoConcepto()
        {
            return combo_TipoMovimientoConcepto();
        }
        #endregion

        #region "ClaseConcepto"
        public DataSet combo_ClaseConcepto()
        {
            return combo_ClaseConcepto();
        }
        #endregion

        #region "TipoConcepto"
        public DataSet combo_TipoConcepto()
        {
            return combo_TipoConcepto();
        }
        #endregion

        #region "Contrato"
        public DataSet lista_Empleado(string strCodEmpresa,
                                       string strCodTipoCalculo
                                     )
        {
            return lista_Empleado(strCodEmpresa,
                                   strCodTipoCalculo
                                     );
        }

        public DataSet combo_TipoCalculoPlanilla()
        {
            return combo_TipoCalculoPlanilla();
        }

        public DataSet combo_Sexo()
        {
            return combo_Sexo();
        }

        public DataSet combo_TipoDocumentoIdentidad()
        {
            return combo_TipoDocumentoIdentidad();
        }

        public DataSet ayuda_Nacionalidad()
        {
            return ayuda_Nacionalidad();
        }

        public DataSet Recupera_Empleado_Vigente(string strCodEmpresa,
                                                  string strCodEmpleado
                                                )
        {
            return Recupera_Empleado_Vigente(strCodEmpresa,
                                              strCodEmpleado
                                                );
        }

        public Model.Empleado recupera_Empleado(int intIdEmpleado)
        {
            return recupera_Empleado(intIdEmpleado);
        }

        public int graba_Empleado(Model.Empleado obj)
        {
            return graba_Empleado(obj);
        }

        public int modifica_Empleado(Model.Empleado obj)
        {
            return modifica_Empleado(obj);
        }

        public Boolean elimina_Empleado(int intIdEmpleado)
        {
            return elimina_Empleado(intIdEmpleado);
        }

        #endregion

        #region "Empleado_Contrato"
        public DataSet combo_Empresa()
        {
            return combo_Empresa();
        }

        public DataSet combo_TipoDocumentoLaboral()
        {
            return combo_TipoDocumentoLaboral();
        }

        public DataSet combo_TipoContratoLaboral()
        {
            return combo_TipoContratoLaboral();
        }

        public DataSet combo_TipoEmpleado()
        {
            return combo_TipoEmpleado();
        }

        public DataSet combo_NivelSalarial()
        {
            return combo_NivelSalarial();
        }

        public DataSet combo_ClaseEmpleado()
        {
            return combo_ClaseEmpleado();
        }

        public DataSet combo_CategoriaOcupacional()
        {
            return combo_CategoriaOcupacional();
        }

        public DataSet combo_RegimenLaboral()
        {
            return combo_RegimenLaboral();
        }

        public DataSet combo_PeriodicidadRemunerativa()
        {
            return combo_PeriodicidadRemunerativa();
        }

        public DataSet combo_TipoRemuneracion()
        {
            return combo_TipoRemuneracion();
        }

        public DataSet combo_TipoMoneda_RRHH()
        {
            return combo_TipoMoneda_RRHH();
        }

        public DataSet combo_TipoFormatoContrato()
        {
            return combo_TipoFormatoContrato();
        }

        public DataSet lista_Empleado_Contrato(string strCodEmpleado)
        {
            return lista_Empleado_Contrato(strCodEmpleado);
        }

        public Model.Empleado_Contrato recupera_Empleado_Contrato(int intIdEmpleado_Contrato)
        {
            return recupera_Empleado_Contrato(intIdEmpleado_Contrato);
        }

        public Model.Empleado_Contrato recupera_Empleado_Contrato_Duplicado(string strCodEmpleado)
        {
            return recupera_Empleado_Contrato_Duplicado(strCodEmpleado);
        }

        public int graba_Empleado_Contrato(Model.Empleado_Contrato obj)
        {
            return graba_Empleado_Contrato(obj);
        }

        public int modifica_Empleado_Contrato(Model.Empleado_Contrato obj)
        {
            return modifica_Empleado_Contrato(obj);
        }

        public DataSet combo_Obra()
        {
            return combo_Obra();
        }

        #endregion

        #region "TipoEmpleado"
        public Model.TipoEmpleado recupera_TipoEmpleado(int intIdTipoEmpleado)
        {
            return recupera_TipoEmpleado(intIdTipoEmpleado);
        }
        public Model.TipoEmpleado recupera_TipoEmpleado_Codigo(string strCodTipoEmpleado)
        {
            return recupera_TipoEmpleado_Codigo(strCodTipoEmpleado);
        }

        public int graba_TipoEmpleado(Model.TipoEmpleado obj)
        {
            return graba_TipoEmpleado(obj);
        }

        public int modifica_TipoEmpleado(Model.TipoEmpleado obj)
        {
            return modifica_TipoEmpleado(obj);
        }

        public Boolean elimina_TipoEmpleado(int intIdTipoEmpleado)
        {
            return elimina_TipoEmpleado(intIdTipoEmpleado);
        }



        #endregion

        #region "NivelSalarial"

        public Model.NivelSalarial recupera_NivelSalarial_Codigo(string strCodNivelSalarial)
        {
            return recupera_NivelSalarial_Codigo(strCodNivelSalarial);
        }
        public Model.NivelSalarial recupera_NivelSalarial(int intIdNivelSalarial)
        {
            return recupera_NivelSalarial(intIdNivelSalarial);
        }

        public int graba_NivelSalarial(Model.NivelSalarial obj)
        {
            return graba_NivelSalarial(obj);
        }

        public int modifica_NivelSalarial(Model.NivelSalarial obj)
        {
            return modifica_NivelSalarial(obj);
        }

        public Boolean elimina_NivelSalarial(int intIdNivelSalarial)
        {
            return elimina_NivelSalarial(intIdNivelSalarial);
        }

        #endregion

        #region "MotivoBajaEmpleado"
        public DataSet combo_MotivoBajaEmpleado()
        {
            return combo_MotivoBajaEmpleado();
        }
        #endregion

        #region "Empleado_Baja"
        public Model.Empleado_Baja recupera_Empleado_Baja(int intIdEmpleado_Baja)
        {
            return recupera_Empleado_Baja(intIdEmpleado_Baja);
        }
        public int graba_Empleado_Baja(Model.Empleado_Baja obj)
        {
            return graba_Empleado_Baja(obj);
        }
        public int modifica_Empleado_Baja(Model.Empleado_Baja obj)
        {
            return modifica_Empleado_Baja(obj);
        }

        public Boolean elimina_Empleado_Baja(int intIdEmpleado_Baja)
        {
            return elimina_Empleado_Baja(intIdEmpleado_Baja);
        }
        #endregion

        #region "Profesion"
        public DataSet ayuda_Profesion()
        {
            return ayuda_Profesion();
        }
        #endregion

        #region "Concepto"

        public DataSet lista_Concepto()
        {
            return lista_Concepto();
        }
        public DataSet ayuda_ConceptoPlanillaRTPS(string strCodClaseConcepto)
        {
            return ayuda_ConceptoPlanillaRTPS(strCodClaseConcepto);
        }
        public DataSet ayuda_ConceptoPlanilla(string strCodClaseConcepto)
        {
            return ayuda_ConceptoPlanilla(strCodClaseConcepto);
        }
        public Model.ConceptoPlanilla recupera_ConceptoPlanilla(int intidConcepto)
        {
            return recupera_ConceptoPlanilla(intidConcepto);
        }
        public Model.ConceptoPlanilla recupera_ConceptoPlanilla_Codigo(string strCodConcepto)
        {
            return recupera_ConceptoPlanilla_Codigo(strCodConcepto);
        }

        public Model.ConceptoPlanilla recupera_ConceptoPlanilla_Codigo_TipoCalculo(string strCodConcepto,
                                                                                   string strCodTipoCalculo
                                                                                  )
        {
            return recupera_ConceptoPlanilla_Codigo_TipoCalculo(strCodConcepto,
                                                                                   strCodTipoCalculo
                                                                                  );
        }
        public int graba_ConceptoPlanilla(Model.ConceptoPlanilla obj)
        {
            return graba_ConceptoPlanilla(obj);
        }

        public int modifica_ConceptoPlanilla(Model.ConceptoPlanilla obj)
        {
            return modifica_ConceptoPlanilla(obj);
        }
        public Boolean elimina_ConceptoPlanilla(int intidConcepto,
                                    string strCodEmpresa
                                    )
        {
            return elimina_ConceptoPlanilla( intidConcepto,
                                    strCodEmpresa
                                    );
        }
        #endregion

        #region "FormulaPlanilla"

        public DataSet lista_FormulaPlanilla(string strCodTipoCalculo)
        {
            return lista_FormulaPlanilla(strCodTipoCalculo);
        }
        public Model.FormulaPlanilla recupera_FormulaPlanilla(int intIdFormula)
        {
            return recupera_FormulaPlanilla(intIdFormula);
        }

        public Model.FormulaPlanilla recupera_FormulaPlanilla_Codigo(string strCodFormula)
        {
            return recupera_FormulaPlanilla_Codigo(strCodFormula);
        }
        public int graba_FormulaPlanilla(Model.FormulaPlanilla obj)
        {
            return graba_FormulaPlanilla(obj);
        }

        public int modifica_FormulaPlanilla(Model.FormulaPlanilla obj)
        {
            return modifica_FormulaPlanilla(obj);
        }

        public Boolean elimina_FormulaPlanilla(int intIdFormula)
        {
            return elimina_FormulaPlanilla(intIdFormula);
        }
        #endregion

        #region "FormulaPlanillaBI"

        public DataSet lista_FormulaPlanillaBI(string strCodTipoCalculo)
        {
            return lista_FormulaPlanillaBI(strCodTipoCalculo);
        }
        public Model.FormulaPlanillaBI recupera_FormulaPlanillaBI(int intIdFormulaBI)
        {
            return recupera_FormulaPlanillaBI(intIdFormulaBI);
        }

        public Model.FormulaPlanillaBI recupera_FormulaPlanillaBI_Codigo(string strCodFormulaBI)
        {
            return recupera_FormulaPlanillaBI_Codigo(strCodFormulaBI);
        }
        public int graba_FormulaPlanillaBI(Model.FormulaPlanillaBI obj)
        {
            return graba_FormulaPlanillaBI(obj);
        }

        public int modifica_FormulaPlanillaBI(Model.FormulaPlanillaBI obj)
        {
            return modifica_FormulaPlanillaBI(obj);
        }
        public Boolean elimina_FormulaPlanillaBI(int intIdFormulaBI)
        {
            return elimina_FormulaPlanillaBI(intIdFormulaBI);
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
            return reporte_BoletaCabecera(strAñoProceso,
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
            return lista_Empleados_Boleta(strAñoProcesoPlanilla,
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
            return recupera_BoletaCabecera_CalculoPlanilla( strAñoProceso,
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
            return graba_BoletaCabecera( strAñoProceso,
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
            return recupera_BoletaCabecera_ParametrosCalculoPlanilla(strAñoProceso,
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
            return genera_BoletaDetalle_EmpleadosSinMeta( strAñoProceso,
                                                          strPeriodoProceso,
                                                          strCodTipoCalculo,
                                                          strCodEmpresa
                                                        );
        }

        public int genera_BoletaDetalle_EmpleadosSinContrato(string strCodTipoCalculo)
        {
            return genera_BoletaDetalle_EmpleadosSinContrato(strCodTipoCalculo);
        }

        #endregion

        #region "ParametroPlanilla"
        public Model.Parametro_Planilla recupera_ParametroPlanilla(string strCodEmpresa)
        {
            return recupera_ParametroPlanilla(strCodEmpresa);
        }
        #endregion

        #region "PeriodoCalculoPlanilla"
        public Model.PeriodoCalculoPlanilla recupera_PeriodoCalculoPlanilla(string strAñoProceso,
                                                                            string strCodTipoCalculo,
                                                                            string strPeriodoProceso
                                                                           )
        {
            return recupera_PeriodoCalculoPlanilla(strAñoProceso,
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
            return graba_BoletaDetalle(intIdBoletaCabecera,
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
            return genera_BoletaDetalle_CalculoPlanilla(strAñoProceso,
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
            return Verificar_PeriodoCalculoPlanilla(strCodTipoCalculo,
                                                    strAnoProceso,
                                                    strPeriodoProceso
                                                       );
        }
        public DataSet combo_AñoProcesoPlanilla()
        {
            return combo_AñoProcesoPlanilla();
        }

        public DataSet combo_PeriodoProcesoPlanilla(string strAñoProceso,
                                                     string strCodTipoCalculo
                                                    )
        {
            return combo_PeriodoProcesoPlanilla(strAñoProceso,
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
            return combo_TipoPlanilla(strAñoProcesoPlanilla,
                                       strCodTipoCalculo,
                                       strPeriodoProcesoPlanilla
                                         );
        }
        #endregion

        #region Empleado
        public DataSet Ayuda_Empleado_Jefatura()
        {
            return Ayuda_Empleado_Jefatura();
        }


        public Model.Empleado Recupera_Empleado_Codigo(string strCodEmpleado)
        {
            return Recupera_Empleado_Codigo(strCodEmpleado);
        }

        public DataSet Ayuda_Empleado()
        {
            return Ayuda_Empleado();
        }

        public Model.Empleado GetEmpleado(string strCodEmpleado)
        {
            return GetEmpleado(strCodEmpleado);
        }

        private Model.Empleado GetEmpDataTableRow_rrhh(DataRow dr)
        {
            return GetEmpDataTableRow_rrhh(dr);
        }

        public DataSet Lista_Empleado_CentroCosto(string strCodEmpresa)
        {
            return Lista_Empleado_CentroCosto(strCodEmpresa);
        }

        public DataSet Graba_Empleado_CentroCosto(string strCodEmpresa,
                                                  string strCodEmpleado,
                                                  string strCodCentroCosto
                                                 )
        {
            return Graba_Empleado_CentroCosto(strCodEmpresa,
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
            return Ayuda_TerminoReferencia_Seguimiento( strCodCompañia,
                                                    strAñoProceso,
                                                    strCodCentroGestor
                                                 );
        }


        public DataSet Ayuda_TerminoReferencia(string strCodCompañia,
                                                string strAñoProceso,
                                                string strCodCentroGestor
                                               )
        {
            return Ayuda_TerminoReferencia(strCodCompañia,
                                            strAñoProceso,
                                            strCodCentroGestor
                                               );
        }
        public DataSet Ayuda_TerminoReferencia(string strCodCompañia,
                                 string strCodCentroGestor
                               )
        {
            return Ayuda_TerminoReferencia(strCodCompañia,
                                 strCodCentroGestor
                               );
        }


        public Model.EnvioCorreo Recupera_EnvioCorreo(string strCodCompañia,
                                                        string strCodEmpleado
                                                      )
        {
            return Recupera_EnvioCorreo(strCodCompañia,
                                        strCodEmpleado
                                                      );
        }

        public Model.EnvioCorreo Recupera_UsuarioCorreo(string strCodCompañia,
                                                        string strEmail
                                                      )
        {
            return Recupera_UsuarioCorreo(strCodCompañia,
                                          strEmail
                                                      );
        }

        public DataSet Ayuda_Empleado_TDR_Para(string strCodCompañia,
                                               Boolean blnEsInicioDocumento
                                              )
        {
            return Ayuda_Empleado_TDR_Para(strCodCompañia,
                                           blnEsInicioDocumento
                                              );
        }

        public DataSet Ayuda_Empleado_TDR_CC(string strCodCompañia,
                                             string strCodEmpleado
                                            )
        {
            return Ayuda_Empleado_TDR_CC(strCodCompañia,
                                         strCodEmpleado
                                            );
        }

        public string Graba_TerminoRefrencia(Model.TerminoReferencia obj,
                                                                Boolean blnEsCreadoEnGestion
                                                              )
        {
            return Graba_TerminoRefrencia(obj,
                                          blnEsCreadoEnGestion
                                                              );
        }

        public string Graba_TerminoRefrencia_CreadoEnGestion(Model.TerminoReferencia obj)
        {
            return Graba_TerminoRefrencia_CreadoEnGestion(obj);
        }

        public string Recupera_VersionDocumento(string strCodCompañia,
                                                string strAñoProceso,
                                                string strTerminoReferencia
                                                      )
        {
            return Recupera_VersionDocumento(strCodCompañia,
                                             strAñoProceso,
                                             strTerminoReferencia
                                                      );
        }


        public string Graba_TerminoRefrencia_IdaVuelta(Model.TerminoReferencia obj)
        {
            return Graba_TerminoRefrencia_IdaVuelta(obj);
        }

        public string Graba_TerminoRefrencia_AutorizaRequerimiento(Model.TerminoReferencia obj)
        {
            return Graba_TerminoRefrencia_AutorizaRequerimiento(obj);
        }
        public DataSet Lista_TerminoRefrencia_IdaVuelta(string strCodCompañia,
                                                         string strCodEmpleado,
                                                         string strCodTipoMovimiento,
                                                         string strCodEstado
                                                       )
        {
            return Lista_TerminoRefrencia_IdaVuelta(strCodCompañia,
                                                     strCodEmpleado,
                                                     strCodTipoMovimiento,
                                                     strCodEstado
                                                       );
        }

        public DataSet Lista_TerminoRefrencia_Seguimiento(string strCodCompañia,
                                                          string strNumDocumento
                                                       )
        {
            return Lista_TerminoRefrencia_Seguimiento(strCodCompañia,
                                                      strNumDocumento
                                                       );
        }

        public Model.TerminoReferencia Recupera_TerminoReferencia(string strCodCompañia,
                                                                    string strNumAdjunto
                                                                 )
        {
            return Recupera_TerminoReferencia(strCodCompañia,
                                              strNumAdjunto
                                                                 );
        }

        #endregion

        #region TRAMITE
        #region DocumentoTramite
        public int Recupera_Version(string strNumDocumento)
        {
            return Recupera_Version(strNumDocumento);
        }

        public int GrabaDocumentoTramite(Model.DocumentoTramite objDocumentoTramite)
        {
            return GrabaDocumentoTramite(objDocumentoTramite);
        }
        #endregion

        #region DocumentoTramite_Adjunto
        public int GrabaDocumentoTramite_Adjunto(Model.DocumentoTramite_Adjunto objDocumentoTramite_Adjunto)
        {
            return GrabaDocumentoTramite_Adjunto(objDocumentoTramite_Adjunto);
        }


        public DataSet Lista_TDR_Aprobar(string strAñoProceso,
                                      string strCodCentroGestor
                                    )
        {
            return Lista_TDR_Aprobar(strAñoProceso,
                                     strCodCentroGestor
                                    );
        }

        #endregion

        #region DocumentoTramite_Contacto
        public int grabaDocumentoTramite_Contacto(Model.DocumentoTramite_Contacto objDocumentoTramite_Contacto)
        {
            return grabaDocumentoTramite_Contacto(objDocumentoTramite_Contacto);
        }

        #endregion

        #region DocumentoTramite_ContactoCC
        public int grabaDocumentoTramite_ContactoCC(Model.DocumentoTramite_ContactoCC objDocumentoTramite_Contacto)
        {
            return grabaDocumentoTramite_ContactoCC(objDocumentoTramite_Contacto);
        }

        #endregion

        #region DocumentoTramite_Detalle
        public DataSet recuperaDocumentoTramite_Detalle_Documento(long intIdDocumentoDetalle)
        {
            return recuperaDocumentoTramite_Detalle_Documento(intIdDocumentoDetalle);
        }

        public DataSet listaDocumentoTramite_Detalle_Seguimiento(long intIdDocumentoDetalle)
        {
            return listaDocumentoTramite_Detalle_Seguimiento(intIdDocumentoDetalle);
        }
        public DataSet listaDocumentoTramite_Detalle_Leidos(long intIdDocumentoDetalle)
        {
            return listaDocumentoTramite_Detalle_Leidos(intIdDocumentoDetalle);
        }

        public DataSet listaDocumentoTramite_Detalle_Adjuntos(long intIdDocumentoDetalle)
        {
            return listaDocumentoTramite_Detalle_Adjuntos(intIdDocumentoDetalle);
        }
        public int grabaDocumentoTramite_Detalle(Model.DocumentoTramite_Detalle objDocumentoTramite_Detalle)
        {
            return grabaDocumentoTramite_Detalle(objDocumentoTramite_Detalle);
        }

        public DataSet listaDocumentoTramite_Detalle(string strCodContacto, int intTipoMovimiento)
        {
            return listaDocumentoTramite_Detalle(strCodContacto, intTipoMovimiento);
        }

        #endregion

        #region DocumentoTramite_Entidad
        public int grabaDocumentoTramite_Entidad(Model.DocumentoTramite_Entidad objDocumentoTramite_Entidad)
        {
            return grabaDocumentoTramite_Entidad(objDocumentoTramite_Entidad);
        }

        #endregion

        #region DocumentoTramite_Proveido
        public int grabaDocumentoTramite_Proveido(Model.DocumentoTramite_Proveido objDocumentoTramite_Proveido)
        {
            return grabaDocumentoTramite_Proveido(objDocumentoTramite_Proveido);
        }

        #endregion

        #region DocumentoTramite_Seguimiento
        public int grabaDocumentoTramite_Seguimiento(Model.DocumentoTramite_Seguimiento objDocumentoTramite_Seguimiento)
        {
            return grabaDocumentoTramite_Seguimiento(objDocumentoTramite_Seguimiento);
        }

        #endregion

        #region TipoProveidoDocumento
        public Model.TipoProveidoDocumento Recupera_TipoProveidoDocumento(int intIdTipoProveido)
        {
            return Recupera_TipoProveidoDocumento(intIdTipoProveido);
        }

        public Model.TipoProveidoDocumento Recupera_TipoProveidoDocumento_Descripcion(string strDesTipoProveido)
        {
            return Recupera_TipoProveidoDocumento_Descripcion(strDesTipoProveido);
        }

        public int GrabaTipoProveidoDocumento(Model.TipoProveidoDocumento objTipoProveido)
        {
            return GrabaTipoProveidoDocumento(objTipoProveido);
        }

        public int ModificaTipoProveidoDocumento(Model.TipoProveidoDocumento objTipoProveido)
        {
            return ModificaTipoProveidoDocumento(objTipoProveido);
        }

        public bool EliminarTipoProveidoDocumento(int intIdTipoProveido)
        {
            return EliminarTipoProveidoDocumento(intIdTipoProveido);
        }

        public DataSet ListaTipoProveidoDocumento()
        {
            return ListaTipoProveidoDocumento();
        }

        public DataSet ComboTipoProveidoDocumento()
        {
            return ComboTipoProveidoDocumento();
        }

        #endregion

        #region ParametroTramite
        public Model.ParametroTramite Recupera_ParametroTramite(string strCodParametroTramite)
        {
            return Recupera_ParametroTramite(strCodParametroTramite);
        }

        #endregion

        #region Contacto
        public System.Data.DataSet Ayuda_msto_Contacto_DataTable(string strTexto)
        {
            return Ayuda_msto_Contacto_DataTable(strTexto);
        }

        public System.Data.DataSet Ayuda_msto_Preferido_DataTable(string strCodEmpleado)
        {
            return Ayuda_msto_Preferido_DataTable(strCodEmpleado);
        }

        public Model.Contacto Recupera_msto_Contacto(string strCodContacto)
        {
            return Recupera_msto_Contacto(strCodContacto);
        }

        public List<Model.Contacto> Ayuda_msto_Contacto(string strTexto)
        {
            return Ayuda_msto_Contacto(strTexto);
        }

        #endregion

        #endregion

        #region VIATICO
        #region ParametroViatico
        public Model.ParametroViatico Recupera_ctrl_ParametroViatico(string strCodParametroViatico)
        {
            return Recupera_ctrl_ParametroViatico(strCodParametroViatico);
        }

        #endregion

        #region SolicitudViatico
        public Model.SolicitudViatico Recupera_SolicitudViatico(string strCodSolicitud)
        {
            return Recupera_SolicitudViatico(strCodSolicitud);
        }

        public Model.SolicitudViatico Recupera_SolicitudViatico_y_LiquidacionViatico(string strCodSolicitud)
        {
            return Recupera_SolicitudViatico_y_LiquidacionViatico(strCodSolicitud);
        }

        public Model.SolicitudViatico Graba_SolicitudViatico(Model.SolicitudViatico objSolicitudViatico)
        {
            return Graba_SolicitudViatico(objSolicitudViatico);
        }

        public bool Modifica_SolicitudViatico(Model.SolicitudViatico objSolicitudViatico)
        {
            return Modifica_SolicitudViatico(objSolicitudViatico);
        }

        public bool Elimina_SolicitudViatico(string strCodSolicitud)
        {
            return Elimina_SolicitudViatico(strCodSolicitud);
        }

        public DataSet Lista_SolicitudViatico()
        {
            return Lista_SolicitudViatico();
        }
        #endregion

        #region IndicadorImpuesto
        public Model.IndicadorImpuesto Recupera_ctrl_IndicadorImpuesto_Codigo(string strCodIndicadorImpuesto)
        {
            return Recupera_ctrl_IndicadorImpuesto_Codigo(strCodIndicadorImpuesto);
        }

        public Model.IndicadorImpuesto Recupera_ctrl_IndicadorImpuesto(int intIdIndicadorImpuesto)
        {
            return Recupera_ctrl_IndicadorImpuesto(intIdIndicadorImpuesto);
        }

        public DataSet Ayuda_ctrl_IndicadorImpuesto()
        {
            return Ayuda_ctrl_IndicadorImpuesto();
        }

        public DataSet Combo_ctrl_IndicadorImpuesto()
        {
            return Combo_ctrl_IndicadorImpuesto();
        }

        public int Graba_ctrl_IndicadorImpuesto(Model.IndicadorImpuesto objIndicadorImpuesto)
        {
            return Graba_ctrl_IndicadorImpuesto(objIndicadorImpuesto);
        }

        public int Modifica_ctrl_IndicadorImpuesto(Model.IndicadorImpuesto objIndicadorImpuesto)
        {
            return Modifica_ctrl_IndicadorImpuesto(objIndicadorImpuesto);
        }

        public bool Elimina_ctrl_IndicadorImpuesto(int intIdIndicadorImpuesto)
        {
            return Elimina_ctrl_IndicadorImpuesto(intIdIndicadorImpuesto);
        }

        public DataTable Lista_ctrl_IndicadorImpuesto()
        {
            return Lista_ctrl_IndicadorImpuesto();
        }

        #endregion

        #region SolicitudViatico_OtroGasto
        public Model.SolicitudViatico_OtroGasto Recupera_SolicitudViatico_OtroGasto(int intIdSolicitudViatico_OtroGasto)
        {
            return Recupera_SolicitudViatico_OtroGasto(intIdSolicitudViatico_OtroGasto);
        }

        public int Graba_SolicitudViatico_OtroGasto(Model.SolicitudViatico_OtroGasto obj)
        {
            return Graba_SolicitudViatico_OtroGasto(obj);
        }

        public int Modifica_SolicitudViatico_OtroGasto(Model.SolicitudViatico_OtroGasto obj)
        {
            return Modifica_SolicitudViatico_OtroGasto(obj);
        }

        public bool Elimina_SolicitudViatico_OtroGasto(int intIdSolicitudViatico_OtroGasto)
        {
            return Elimina_SolicitudViatico_OtroGasto(intIdSolicitudViatico_OtroGasto);
        }

        public DataSet Lista_SolicitudViatico_OtroGasto(string strCodSolicitud)
        {
            return Lista_SolicitudViatico_OtroGasto(strCodSolicitud);
        }

        #endregion

        #region SolicitudViatico_Rendicion
        public Model.SolicitudViatico_Rendicion Recupera_SolicitudViatico_Rendicion(string intIdSolicitudViatico_Rendicion)
        {
            return Recupera_SolicitudViatico_Rendicion(intIdSolicitudViatico_Rendicion);
        }


        public int Graba_SolicitudViatico_Rendicion(Model.SolicitudViatico_Rendicion objLiquidacionViatico)
        {
            return Graba_SolicitudViatico_Rendicion(objLiquidacionViatico);
        }

        public int Modifica_SolicitudViatico_Rendicion(Model.SolicitudViatico_Rendicion objLiquidacionViatico)
        {
            return Modifica_SolicitudViatico_Rendicion(objLiquidacionViatico);
        }

        public bool Elimina_SolicitudViatico_Rendicion(int intIdSolicitudViatico_Rendicion)
        {
            return Elimina_SolicitudViatico_Rendicion(intIdSolicitudViatico_Rendicion);
        }

        public DataSet Lista_SolicitudViatico_Rendicion(string strCodSolicitud)
        {
            return Lista_SolicitudViatico_Rendicion(strCodSolicitud);
        }

        #endregion

        #region SolicitudViatico_Rendicion_Impuesto
        public Model.SolicitudViatico_Rendicion_Impuesto Recupera_SolicitudViatico_Rendicion_Impuesto(int intIdSolicitudViatico_Rendicion_Impuesto)
        {
            return Recupera_SolicitudViatico_Rendicion_Impuesto(intIdSolicitudViatico_Rendicion_Impuesto);
        }

        public int Graba_SolicitudViatico_Rendicion_Impuesto(Model.SolicitudViatico_Rendicion_Impuesto obj)
        {
            return Graba_SolicitudViatico_Rendicion_Impuesto(obj);
        }

        public int Modifica_SolicitudViatico_Rendicion_Impuesto(Model.SolicitudViatico_Rendicion_Impuesto obj)
        {
            return Modifica_SolicitudViatico_Rendicion_Impuesto(obj);
        }

        public bool Elimina_SolicitudViatico_Rendicion_Impuesto(int intIdSolicitudViatico_Rendicion_Impuesto)
        {
            return Elimina_SolicitudViatico_Rendicion_Impuesto(intIdSolicitudViatico_Rendicion_Impuesto);
        }

        public DataSet Lista_SolicitudViatico_Rendicion_Impuesto(int intIdSolicitudViatico_Rendicion)
        {
            return Lista_SolicitudViatico_Rendicion_Impuesto(intIdSolicitudViatico_Rendicion);
        }

        #endregion

        #region Concepto
        public Model.Concepto Recupera_msto_Concepto_Codigo(string strCodConcepto)
        {
            return Recupera_msto_Concepto_Codigo(strCodConcepto);
        }

        public Model.Concepto Recupera_msto_Concepto(int intIdConcepto)
        {
            return Recupera_msto_Concepto(intIdConcepto);
        }

        public DataSet Ayuda_msto_Concepto(string strCodTipoConcepto)
        {
            return Ayuda_msto_Concepto(strCodTipoConcepto);
        }

        public int Graba_msto_Concepto(Model.Concepto objConcepto)
        {
            return Graba_msto_Concepto(objConcepto);
        }

        public int Modifica_msto_Concepto(Model.Concepto objConcepto)
        {
            return Modifica_msto_Concepto(objConcepto);
        }

        public bool Elimina_msto_Concepto(int intIdConcepto)
        {
            return Elimina_msto_Concepto(intIdConcepto);
        }

        public DataSet Lista_msto_Concepto()
        {
            return Lista_msto_Concepto();
        }

        #endregion

        #region Destino
        public Model.Destino Recupera_msto_Empleado_Destino(string strCodTipoDestinoViaje,
                                                     string strCodEscalaViaje
                                                    )
        {
            return Recupera_msto_Empleado_Destino(strCodTipoDestinoViaje,
                                                  strCodEscalaViaje
                                                    );
        }

        #endregion

        #endregion

    }
}
