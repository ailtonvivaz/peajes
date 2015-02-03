/*
               File: PASAJEROS
        Description: Transaccion para el segmento de buques de pasajeros
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 9:38:49.17
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class pasajeros : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false;
         gxfirstwebparm = GetNextPar( );
         gxfirstwebparm_bkp = gxfirstwebparm;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm);
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
         {
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         cmbPASAJEROS_ESCLUSA.Name = "PASAJEROS_ESCLUSA";
         cmbPASAJEROS_ESCLUSA.WebTags = "";
         cmbPASAJEROS_ESCLUSA.addItem("Panamax", context.GetMessage( "Panamax", ""), 0);
         cmbPASAJEROS_ESCLUSA.addItem("Neo Panamax", context.GetMessage( "Neo Panamax", ""), 0);
         if ( cmbPASAJEROS_ESCLUSA.ItemCount > 0 )
         {
            A58PASAJEROS_ESCLUSA = cmbPASAJEROS_ESCLUSA.getValidValue(A58PASAJEROS_ESCLUSA);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58PASAJEROS_ESCLUSA", A58PASAJEROS_ESCLUSA);
         }
         cmbPASAJEROS_TIPO_TARIFA.Name = "PASAJEROS_TIPO_TARIFA";
         cmbPASAJEROS_TIPO_TARIFA.WebTags = "";
         cmbPASAJEROS_TIPO_TARIFA.addItem("LITERA", context.GetMessage( "Litera", ""), 0);
         cmbPASAJEROS_TIPO_TARIFA.addItem("CPSUAB", context.GetMessage( "CP/ SUAB", ""), 0);
         if ( cmbPASAJEROS_TIPO_TARIFA.ItemCount > 0 )
         {
            A60PASAJEROS_TIPO_TARIFA = cmbPASAJEROS_TIPO_TARIFA.getValidValue(A60PASAJEROS_TIPO_TARIFA);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60PASAJEROS_TIPO_TARIFA", A60PASAJEROS_TIPO_TARIFA);
         }
         cmbPASAJEROS_CARGA.Name = "PASAJEROS_CARGA";
         cmbPASAJEROS_CARGA.WebTags = "";
         cmbPASAJEROS_CARGA.addItem("Laden", context.GetMessage( "Laden", ""), 0);
         cmbPASAJEROS_CARGA.addItem("Ballast", context.GetMessage( "Ballast", ""), 0);
         if ( cmbPASAJEROS_CARGA.ItemCount > 0 )
         {
            A59PASAJEROS_CARGA = cmbPASAJEROS_CARGA.getValidValue(A59PASAJEROS_CARGA);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59PASAJEROS_CARGA", A59PASAJEROS_CARGA);
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_2-86442", 0) ;
            Form.Meta.addItem("description", context.GetMessage( "Transaccion para el segmento de buques de pasajeros", ""), 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtPASAJEROS_ID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Flat");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public pasajeros( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public pasajeros( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbPASAJEROS_ESCLUSA = new GXCombobox();
         cmbPASAJEROS_TIPO_TARIFA = new GXCombobox();
         cmbPASAJEROS_CARGA = new GXCombobox();
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdmasterpage", "GeneXus.Programs.rwdmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
            if ( ( GxWebError == 0 ) && context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", " "+"data-abstract-form"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "Container FormContainer", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, context.GetMessage( "Transaccion para el segmento de buques de pasajeros", ""), "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_PASAJEROS.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 col-sm-offset-3", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group gx-button ActionGroup", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "btn-group", "");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"";
            ClassString = "BtnFirst";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", context.GetMessage( "GX_BtnFirst", ""), bttBtn_first_Jsonclick, 5, context.GetMessage( "GX_BtnFirst", ""), "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_PASAJEROS.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", context.GetMessage( "GX_BtnPrevious", ""), bttBtn_previous_Jsonclick, 5, context.GetMessage( "GX_BtnPrevious", ""), "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_PASAJEROS.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", context.GetMessage( "GX_BtnNext", ""), bttBtn_next_Jsonclick, 5, context.GetMessage( "GX_BtnNext", ""), "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_PASAJEROS.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", context.GetMessage( "GX_BtnLast", ""), bttBtn_last_Jsonclick, 5, context.GetMessage( "GX_BtnLast", ""), "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_PASAJEROS.htm");
            context.WriteHtmlText( "</div>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", context.GetMessage( "GX_BtnSelect", ""), bttBtn_select_Jsonclick, 4, context.GetMessage( "GX_BtnSelect", ""), "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx00b0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PASAJEROS_ID"+"'), id:'"+"PASAJEROS_ID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_PASAJEROS.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 col-sm-offset-3", " "+"id"+" ");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPasajeros_id_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl22_Internalname, context.GetMessage( "ID", ""), "", "", lbllbl22_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_PASAJEROS.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPASAJEROS_ID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A63PASAJEROS_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtPASAJEROS_ID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A63PASAJEROS_ID), "ZZZ9")) : context.localUtil.Format( (decimal)(A63PASAJEROS_ID), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(24);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPASAJEROS_ID_Jsonclick, 0, "Attribute", "", "", "", 1, edtPASAJEROS_ID_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_PASAJEROS.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPasajeros_esclusa_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl28_Internalname, context.GetMessage( "Esclusa", ""), "", "", lbllbl28_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_PASAJEROS.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbPASAJEROS_ESCLUSA, cmbPASAJEROS_ESCLUSA_Internalname, A58PASAJEROS_ESCLUSA, 1, cmbPASAJEROS_ESCLUSA_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbPASAJEROS_ESCLUSA.Enabled, 0, 0, 40, "chr", 0, "", "", "Attribute", "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(30);\"", "", true, "HLP_PASAJEROS.htm");
            cmbPASAJEROS_ESCLUSA.CurrentValue = A58PASAJEROS_ESCLUSA;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPASAJEROS_ESCLUSA_Internalname, "Values", (String)(cmbPASAJEROS_ESCLUSA.ToJavascriptSource()));
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPasajeros_tipo_tarifa_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl34_Internalname, context.GetMessage( "Tipo Tarifa", ""), "", "", lbllbl34_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_PASAJEROS.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbPASAJEROS_TIPO_TARIFA, cmbPASAJEROS_TIPO_TARIFA_Internalname, A60PASAJEROS_TIPO_TARIFA, 1, cmbPASAJEROS_TIPO_TARIFA_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbPASAJEROS_TIPO_TARIFA.Enabled, 0, 0, 10, "chr", 0, "", "", "Attribute", "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(36);\"", "", true, "HLP_PASAJEROS.htm");
            cmbPASAJEROS_TIPO_TARIFA.CurrentValue = A60PASAJEROS_TIPO_TARIFA;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPASAJEROS_TIPO_TARIFA_Internalname, "Values", (String)(cmbPASAJEROS_TIPO_TARIFA.ToJavascriptSource()));
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPasajeros_carga_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl40_Internalname, context.GetMessage( "Carga", ""), "", "", lbllbl40_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_PASAJEROS.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbPASAJEROS_CARGA, cmbPASAJEROS_CARGA_Internalname, A59PASAJEROS_CARGA, 1, cmbPASAJEROS_CARGA_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbPASAJEROS_CARGA.Enabled, 0, 0, 40, "chr", 0, "", "", "Attribute", "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(42);\"", "", true, "HLP_PASAJEROS.htm");
            cmbPASAJEROS_CARGA.CurrentValue = A59PASAJEROS_CARGA;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPASAJEROS_CARGA_Internalname, "Values", (String)(cmbPASAJEROS_CARGA.ToJavascriptSource()));
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPasajeros_id_ton_tarif_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl46_Internalname, context.GetMessage( "ID Tarifa", ""), "", "", lbllbl46_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_PASAJEROS.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPASAJEROS_ID_TON_TARIF_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A65PASAJEROS_ID_TON_TARIF), 4, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtPASAJEROS_ID_TON_TARIF_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A65PASAJEROS_ID_TON_TARIF), "ZZZ9")) : context.localUtil.Format( (decimal)(A65PASAJEROS_ID_TON_TARIF), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPASAJEROS_ID_TON_TARIF_Jsonclick, 0, "Attribute", "", "", "", 1, edtPASAJEROS_ID_TON_TARIF_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_PASAJEROS.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPasajeros_ton_tarifa_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl52_Internalname, context.GetMessage( "TON TARIFA", ""), "", "", lbllbl52_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_PASAJEROS.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPASAJEROS_TON_TARIFA_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A61PASAJEROS_TON_TARIFA), 10, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtPASAJEROS_TON_TARIFA_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A61PASAJEROS_TON_TARIFA), "ZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A61PASAJEROS_TON_TARIFA), "ZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPASAJEROS_TON_TARIFA_Jsonclick, 0, "Attribute", "", "", "", 1, edtPASAJEROS_TON_TARIFA_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_PASAJEROS.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPasajeros_tarifa_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl58_Internalname, context.GetMessage( "Tarifa", ""), "", "", lbllbl58_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_PASAJEROS.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPASAJEROS_TARIFA_Internalname, StringUtil.LTrim( StringUtil.NToC( A62PASAJEROS_TARIFA, 10, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtPASAJEROS_TARIFA_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A62PASAJEROS_TARIFA, "ZZZZZZ9.99")) : context.localUtil.Format( A62PASAJEROS_TARIFA, "ZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(60);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPASAJEROS_TARIFA_Jsonclick, 0, "Attribute", "", "", "", 1, edtPASAJEROS_TARIFA_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_PASAJEROS.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPasajeros_comentario_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl64_Internalname, context.GetMessage( "Comentario", ""), "", "", lbllbl64_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_PASAJEROS.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPASAJEROS_COMENTARIO_Internalname, StringUtil.RTrim( A64PASAJEROS_COMENTARIO), StringUtil.RTrim( context.localUtil.Format( A64PASAJEROS_COMENTARIO, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPASAJEROS_COMENTARIO_Jsonclick, 0, "Attribute", "", "", "", 1, edtPASAJEROS_COMENTARIO_Enabled, 0, "text", "", 80, "chr", 1, "row", 150, 0, 0, 0, 1, -1, -1, true, "", "left", "HLP_PASAJEROS.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 col-sm-offset-3", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group gx-button ActionGroup", "");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", context.GetMessage( "GX_BtnEnter", ""), bttBtn_enter_Jsonclick, 5, context.GetMessage( "GX_BtnEnter", ""), "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_PASAJEROS.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", context.GetMessage( "GX_BtnCancel", ""), bttBtn_cancel_Jsonclick, 1, context.GetMessage( "GX_BtnCancel", ""), "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_PASAJEROS.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", context.GetMessage( "GX_BtnDelete", ""), bttBtn_delete_Jsonclick, 5, context.GetMessage( "GX_BtnDelete", ""), "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_PASAJEROS.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
         }
         /* Execute Exit event if defined. */
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtPASAJEROS_ID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPASAJEROS_ID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PASAJEROS_ID");
                  AnyError = 1;
                  GX_FocusControl = edtPASAJEROS_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A63PASAJEROS_ID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63PASAJEROS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A63PASAJEROS_ID), 4, 0)));
               }
               else
               {
                  A63PASAJEROS_ID = (short)(context.localUtil.CToN( cgiGet( edtPASAJEROS_ID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63PASAJEROS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A63PASAJEROS_ID), 4, 0)));
               }
               cmbPASAJEROS_ESCLUSA.CurrentValue = cgiGet( cmbPASAJEROS_ESCLUSA_Internalname);
               A58PASAJEROS_ESCLUSA = cgiGet( cmbPASAJEROS_ESCLUSA_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58PASAJEROS_ESCLUSA", A58PASAJEROS_ESCLUSA);
               if ( cmbPASAJEROS_ESCLUSA.ItemCount > 0 )
               {
                  A58PASAJEROS_ESCLUSA = cmbPASAJEROS_ESCLUSA.getValidValue(A58PASAJEROS_ESCLUSA);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58PASAJEROS_ESCLUSA", A58PASAJEROS_ESCLUSA);
               }
               cmbPASAJEROS_TIPO_TARIFA.CurrentValue = cgiGet( cmbPASAJEROS_TIPO_TARIFA_Internalname);
               A60PASAJEROS_TIPO_TARIFA = cgiGet( cmbPASAJEROS_TIPO_TARIFA_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60PASAJEROS_TIPO_TARIFA", A60PASAJEROS_TIPO_TARIFA);
               if ( cmbPASAJEROS_TIPO_TARIFA.ItemCount > 0 )
               {
                  A60PASAJEROS_TIPO_TARIFA = cmbPASAJEROS_TIPO_TARIFA.getValidValue(A60PASAJEROS_TIPO_TARIFA);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60PASAJEROS_TIPO_TARIFA", A60PASAJEROS_TIPO_TARIFA);
               }
               cmbPASAJEROS_CARGA.CurrentValue = cgiGet( cmbPASAJEROS_CARGA_Internalname);
               A59PASAJEROS_CARGA = cgiGet( cmbPASAJEROS_CARGA_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59PASAJEROS_CARGA", A59PASAJEROS_CARGA);
               if ( cmbPASAJEROS_CARGA.ItemCount > 0 )
               {
                  A59PASAJEROS_CARGA = cmbPASAJEROS_CARGA.getValidValue(A59PASAJEROS_CARGA);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59PASAJEROS_CARGA", A59PASAJEROS_CARGA);
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtPASAJEROS_ID_TON_TARIF_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPASAJEROS_ID_TON_TARIF_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PASAJEROS_ID_TON_TARIF");
                  AnyError = 1;
                  GX_FocusControl = edtPASAJEROS_ID_TON_TARIF_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A65PASAJEROS_ID_TON_TARIF = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65PASAJEROS_ID_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(A65PASAJEROS_ID_TON_TARIF), 4, 0)));
               }
               else
               {
                  A65PASAJEROS_ID_TON_TARIF = (short)(context.localUtil.CToN( cgiGet( edtPASAJEROS_ID_TON_TARIF_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65PASAJEROS_ID_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(A65PASAJEROS_ID_TON_TARIF), 4, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtPASAJEROS_TON_TARIFA_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPASAJEROS_TON_TARIFA_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PASAJEROS_TON_TARIFA");
                  AnyError = 1;
                  GX_FocusControl = edtPASAJEROS_TON_TARIFA_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A61PASAJEROS_TON_TARIFA = 0;
                  n61PASAJEROS_TON_TARIFA = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61PASAJEROS_TON_TARIFA", StringUtil.LTrim( StringUtil.Str( (decimal)(A61PASAJEROS_TON_TARIFA), 10, 0)));
               }
               else
               {
                  A61PASAJEROS_TON_TARIFA = (long)(context.localUtil.CToN( cgiGet( edtPASAJEROS_TON_TARIFA_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                  n61PASAJEROS_TON_TARIFA = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61PASAJEROS_TON_TARIFA", StringUtil.LTrim( StringUtil.Str( (decimal)(A61PASAJEROS_TON_TARIFA), 10, 0)));
               }
               n61PASAJEROS_TON_TARIFA = ((0==A61PASAJEROS_TON_TARIFA) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtPASAJEROS_TARIFA_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPASAJEROS_TARIFA_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 9999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "PASAJEROS_TARIFA");
                  AnyError = 1;
                  GX_FocusControl = edtPASAJEROS_TARIFA_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A62PASAJEROS_TARIFA = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62PASAJEROS_TARIFA", StringUtil.LTrim( StringUtil.Str( A62PASAJEROS_TARIFA, 10, 2)));
               }
               else
               {
                  A62PASAJEROS_TARIFA = context.localUtil.CToN( cgiGet( edtPASAJEROS_TARIFA_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62PASAJEROS_TARIFA", StringUtil.LTrim( StringUtil.Str( A62PASAJEROS_TARIFA, 10, 2)));
               }
               A64PASAJEROS_COMENTARIO = cgiGet( edtPASAJEROS_COMENTARIO_Internalname);
               n64PASAJEROS_COMENTARIO = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64PASAJEROS_COMENTARIO", A64PASAJEROS_COMENTARIO);
               n64PASAJEROS_COMENTARIO = (String.IsNullOrEmpty(StringUtil.RTrim( A64PASAJEROS_COMENTARIO)) ? true : false);
               /* Read saved values. */
               Z63PASAJEROS_ID = (short)(context.localUtil.CToN( cgiGet( "Z63PASAJEROS_ID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               Z58PASAJEROS_ESCLUSA = cgiGet( "Z58PASAJEROS_ESCLUSA");
               Z60PASAJEROS_TIPO_TARIFA = cgiGet( "Z60PASAJEROS_TIPO_TARIFA");
               Z59PASAJEROS_CARGA = cgiGet( "Z59PASAJEROS_CARGA");
               Z65PASAJEROS_ID_TON_TARIF = (short)(context.localUtil.CToN( cgiGet( "Z65PASAJEROS_ID_TON_TARIF"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               Z61PASAJEROS_TON_TARIFA = (long)(context.localUtil.CToN( cgiGet( "Z61PASAJEROS_TON_TARIFA"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               n61PASAJEROS_TON_TARIFA = ((0==A61PASAJEROS_TON_TARIFA) ? true : false);
               Z62PASAJEROS_TARIFA = context.localUtil.CToN( cgiGet( "Z62PASAJEROS_TARIFA"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               Z64PASAJEROS_COMENTARIO = cgiGet( "Z64PASAJEROS_COMENTARIO");
               n64PASAJEROS_COMENTARIO = (String.IsNullOrEmpty(StringUtil.RTrim( A64PASAJEROS_COMENTARIO)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               Gx_mode = cgiGet( "Mode");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  A63PASAJEROS_ID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63PASAJEROS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A63PASAJEROS_ID), 4, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons_dsp( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal( ) ;
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName");
            EvtGridId = cgiGet( "_EventGridId");
            EvtRowId = cgiGet( "_EventRowId");
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1);
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1);
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_first( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_previous( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_next( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_last( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_select( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_delete( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1;
                           AfterKeyLoadScreen( ) ;
                        }
                     }
                     else
                     {
                     }
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0911( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         }
      }

      protected void disable_std_buttons_dsp( )
      {
         bttBtn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         bttBtn_first_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_first_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_first_Visible), 5, 0)));
         bttBtn_previous_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_previous_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_previous_Visible), 5, 0)));
         bttBtn_next_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_next_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_next_Visible), 5, 0)));
         bttBtn_last_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_last_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_last_Visible), 5, 0)));
         bttBtn_select_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_select_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_select_Visible), 5, 0)));
         bttBtn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
         }
         DisableAttributes0911( ) ;
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void ResetCaption090( )
      {
      }

      protected void ZM0911( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z58PASAJEROS_ESCLUSA = T00093_A58PASAJEROS_ESCLUSA[0];
               Z60PASAJEROS_TIPO_TARIFA = T00093_A60PASAJEROS_TIPO_TARIFA[0];
               Z59PASAJEROS_CARGA = T00093_A59PASAJEROS_CARGA[0];
               Z65PASAJEROS_ID_TON_TARIF = T00093_A65PASAJEROS_ID_TON_TARIF[0];
               Z61PASAJEROS_TON_TARIFA = T00093_A61PASAJEROS_TON_TARIFA[0];
               Z62PASAJEROS_TARIFA = T00093_A62PASAJEROS_TARIFA[0];
               Z64PASAJEROS_COMENTARIO = T00093_A64PASAJEROS_COMENTARIO[0];
            }
            else
            {
               Z58PASAJEROS_ESCLUSA = A58PASAJEROS_ESCLUSA;
               Z60PASAJEROS_TIPO_TARIFA = A60PASAJEROS_TIPO_TARIFA;
               Z59PASAJEROS_CARGA = A59PASAJEROS_CARGA;
               Z65PASAJEROS_ID_TON_TARIF = A65PASAJEROS_ID_TON_TARIF;
               Z61PASAJEROS_TON_TARIFA = A61PASAJEROS_TON_TARIFA;
               Z62PASAJEROS_TARIFA = A62PASAJEROS_TARIFA;
               Z64PASAJEROS_COMENTARIO = A64PASAJEROS_COMENTARIO;
            }
         }
         if ( GX_JID == -4 )
         {
            Z63PASAJEROS_ID = A63PASAJEROS_ID;
            Z58PASAJEROS_ESCLUSA = A58PASAJEROS_ESCLUSA;
            Z60PASAJEROS_TIPO_TARIFA = A60PASAJEROS_TIPO_TARIFA;
            Z59PASAJEROS_CARGA = A59PASAJEROS_CARGA;
            Z65PASAJEROS_ID_TON_TARIF = A65PASAJEROS_ID_TON_TARIF;
            Z61PASAJEROS_TON_TARIFA = A61PASAJEROS_TON_TARIFA;
            Z62PASAJEROS_TARIFA = A62PASAJEROS_TARIFA;
            Z64PASAJEROS_COMENTARIO = A64PASAJEROS_COMENTARIO;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         }
         else
         {
            bttBtn_delete_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)));
         }
         else
         {
            bttBtn_enter_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)));
         }
      }

      protected void Load0911( )
      {
         /* Using cursor T00094 */
         pr_default.execute(2, new Object[] {A63PASAJEROS_ID});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound11 = 1;
            A58PASAJEROS_ESCLUSA = T00094_A58PASAJEROS_ESCLUSA[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58PASAJEROS_ESCLUSA", A58PASAJEROS_ESCLUSA);
            A60PASAJEROS_TIPO_TARIFA = T00094_A60PASAJEROS_TIPO_TARIFA[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60PASAJEROS_TIPO_TARIFA", A60PASAJEROS_TIPO_TARIFA);
            A59PASAJEROS_CARGA = T00094_A59PASAJEROS_CARGA[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59PASAJEROS_CARGA", A59PASAJEROS_CARGA);
            A65PASAJEROS_ID_TON_TARIF = T00094_A65PASAJEROS_ID_TON_TARIF[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65PASAJEROS_ID_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(A65PASAJEROS_ID_TON_TARIF), 4, 0)));
            A61PASAJEROS_TON_TARIFA = T00094_A61PASAJEROS_TON_TARIFA[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61PASAJEROS_TON_TARIFA", StringUtil.LTrim( StringUtil.Str( (decimal)(A61PASAJEROS_TON_TARIFA), 10, 0)));
            n61PASAJEROS_TON_TARIFA = T00094_n61PASAJEROS_TON_TARIFA[0];
            A62PASAJEROS_TARIFA = T00094_A62PASAJEROS_TARIFA[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62PASAJEROS_TARIFA", StringUtil.LTrim( StringUtil.Str( A62PASAJEROS_TARIFA, 10, 2)));
            A64PASAJEROS_COMENTARIO = T00094_A64PASAJEROS_COMENTARIO[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64PASAJEROS_COMENTARIO", A64PASAJEROS_COMENTARIO);
            n64PASAJEROS_COMENTARIO = T00094_n64PASAJEROS_COMENTARIO[0];
            ZM0911( -4) ;
         }
         pr_default.close(2);
         OnLoadActions0911( ) ;
      }

      protected void OnLoadActions0911( )
      {
      }

      protected void CheckExtendedTable0911( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         if ( ! ( ( StringUtil.StrCmp(A58PASAJEROS_ESCLUSA, "Panamax") == 0 ) || ( StringUtil.StrCmp(A58PASAJEROS_ESCLUSA, "Neo Panamax") == 0 ) ) )
         {
            GX_msglist.addItem(StringUtil.Format( context.GetMessage( "GXSPC_OutOfRange", ""), context.GetMessage( "Identificador unico de la transaccion", ""), "", "", "", "", "", "", "", ""), "OutOfRange", 1, "PASAJEROS_ESCLUSA");
            AnyError = 1;
            GX_FocusControl = cmbPASAJEROS_ESCLUSA_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( StringUtil.StrCmp(A60PASAJEROS_TIPO_TARIFA, "LITERA") == 0 ) || ( StringUtil.StrCmp(A60PASAJEROS_TIPO_TARIFA, "CPSUAB") == 0 ) ) )
         {
            GX_msglist.addItem(StringUtil.Format( context.GetMessage( "GXSPC_OutOfRange", ""), context.GetMessage( "Tipo de tarifa del peaje: Litera, CP/SUAB", ""), "", "", "", "", "", "", "", ""), "OutOfRange", 1, "PASAJEROS_TIPO_TARIFA");
            AnyError = 1;
            GX_FocusControl = cmbPASAJEROS_TIPO_TARIFA_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( StringUtil.StrCmp(A59PASAJEROS_CARGA, "Laden") == 0 ) || ( StringUtil.StrCmp(A59PASAJEROS_CARGA, "Ballast") == 0 ) ) )
         {
            GX_msglist.addItem(StringUtil.Format( context.GetMessage( "GXSPC_OutOfRange", ""), context.GetMessage( "Estado en el que viaja el buque: Cargado, En Lastre", ""), "", "", "", "", "", "", "", ""), "OutOfRange", 1, "PASAJEROS_CARGA");
            AnyError = 1;
            GX_FocusControl = cmbPASAJEROS_CARGA_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0911( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0911( )
      {
         /* Using cursor T00095 */
         pr_default.execute(3, new Object[] {A63PASAJEROS_ID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound11 = 1;
         }
         else
         {
            RcdFound11 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00093 */
         pr_default.execute(1, new Object[] {A63PASAJEROS_ID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0911( 4) ;
            RcdFound11 = 1;
            A63PASAJEROS_ID = T00093_A63PASAJEROS_ID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63PASAJEROS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A63PASAJEROS_ID), 4, 0)));
            A58PASAJEROS_ESCLUSA = T00093_A58PASAJEROS_ESCLUSA[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58PASAJEROS_ESCLUSA", A58PASAJEROS_ESCLUSA);
            A60PASAJEROS_TIPO_TARIFA = T00093_A60PASAJEROS_TIPO_TARIFA[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60PASAJEROS_TIPO_TARIFA", A60PASAJEROS_TIPO_TARIFA);
            A59PASAJEROS_CARGA = T00093_A59PASAJEROS_CARGA[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59PASAJEROS_CARGA", A59PASAJEROS_CARGA);
            A65PASAJEROS_ID_TON_TARIF = T00093_A65PASAJEROS_ID_TON_TARIF[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65PASAJEROS_ID_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(A65PASAJEROS_ID_TON_TARIF), 4, 0)));
            A61PASAJEROS_TON_TARIFA = T00093_A61PASAJEROS_TON_TARIFA[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61PASAJEROS_TON_TARIFA", StringUtil.LTrim( StringUtil.Str( (decimal)(A61PASAJEROS_TON_TARIFA), 10, 0)));
            n61PASAJEROS_TON_TARIFA = T00093_n61PASAJEROS_TON_TARIFA[0];
            A62PASAJEROS_TARIFA = T00093_A62PASAJEROS_TARIFA[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62PASAJEROS_TARIFA", StringUtil.LTrim( StringUtil.Str( A62PASAJEROS_TARIFA, 10, 2)));
            A64PASAJEROS_COMENTARIO = T00093_A64PASAJEROS_COMENTARIO[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64PASAJEROS_COMENTARIO", A64PASAJEROS_COMENTARIO);
            n64PASAJEROS_COMENTARIO = T00093_n64PASAJEROS_COMENTARIO[0];
            Z63PASAJEROS_ID = A63PASAJEROS_ID;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0911( ) ;
            if ( AnyError == 1 )
            {
               RcdFound11 = 0;
               InitializeNonKey0911( ) ;
            }
            Gx_mode = sMode11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound11 = 0;
            InitializeNonKey0911( ) ;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0911( ) ;
         if ( RcdFound11 == 0 )
         {
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound11 = 0;
         /* Using cursor T00096 */
         pr_default.execute(4, new Object[] {A63PASAJEROS_ID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00096_A63PASAJEROS_ID[0] < A63PASAJEROS_ID ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00096_A63PASAJEROS_ID[0] > A63PASAJEROS_ID ) ) )
            {
               A63PASAJEROS_ID = T00096_A63PASAJEROS_ID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63PASAJEROS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A63PASAJEROS_ID), 4, 0)));
               RcdFound11 = 1;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound11 = 0;
         /* Using cursor T00097 */
         pr_default.execute(5, new Object[] {A63PASAJEROS_ID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00097_A63PASAJEROS_ID[0] > A63PASAJEROS_ID ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00097_A63PASAJEROS_ID[0] < A63PASAJEROS_ID ) ) )
            {
               A63PASAJEROS_ID = T00097_A63PASAJEROS_ID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63PASAJEROS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A63PASAJEROS_ID), 4, 0)));
               RcdFound11 = 1;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0911( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtPASAJEROS_ID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0911( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound11 == 1 )
            {
               if ( A63PASAJEROS_ID != Z63PASAJEROS_ID )
               {
                  A63PASAJEROS_ID = Z63PASAJEROS_ID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63PASAJEROS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A63PASAJEROS_ID), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "PASAJEROS_ID");
                  AnyError = 1;
                  GX_FocusControl = edtPASAJEROS_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtPASAJEROS_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update0911( ) ;
                  GX_FocusControl = edtPASAJEROS_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A63PASAJEROS_ID != Z63PASAJEROS_ID )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtPASAJEROS_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0911( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "PASAJEROS_ID");
                     AnyError = 1;
                     GX_FocusControl = edtPASAJEROS_ID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtPASAJEROS_ID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0911( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
      }

      protected void btn_delete( )
      {
         if ( A63PASAJEROS_ID != Z63PASAJEROS_ID )
         {
            A63PASAJEROS_ID = Z63PASAJEROS_ID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63PASAJEROS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A63PASAJEROS_ID), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "PASAJEROS_ID");
            AnyError = 1;
            GX_FocusControl = edtPASAJEROS_ID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtPASAJEROS_ID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            getByPrimaryKey( ) ;
         }
         CloseOpenCursors();
      }

      protected void btn_get( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         getEqualNoModal( ) ;
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "PASAJEROS_ID");
            AnyError = 1;
         }
         GX_FocusControl = cmbPASAJEROS_ESCLUSA_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         ScanStart0911( ) ;
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbPASAJEROS_ESCLUSA_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0911( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         move_previous( ) ;
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbPASAJEROS_ESCLUSA_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         move_next( ) ;
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbPASAJEROS_ESCLUSA_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         ScanStart0911( ) ;
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound11 != 0 )
            {
               ScanNext0911( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbPASAJEROS_ESCLUSA_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0911( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0911( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00098 */
            pr_default.execute(6, new Object[] {A63PASAJEROS_ID});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PASAJEROS"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(6) == 101) || ( StringUtil.StrCmp(Z58PASAJEROS_ESCLUSA, T00098_A58PASAJEROS_ESCLUSA[0]) != 0 ) || ( StringUtil.StrCmp(Z60PASAJEROS_TIPO_TARIFA, T00098_A60PASAJEROS_TIPO_TARIFA[0]) != 0 ) || ( StringUtil.StrCmp(Z59PASAJEROS_CARGA, T00098_A59PASAJEROS_CARGA[0]) != 0 ) || ( Z65PASAJEROS_ID_TON_TARIF != T00098_A65PASAJEROS_ID_TON_TARIF[0] ) || ( Z61PASAJEROS_TON_TARIFA != T00098_A61PASAJEROS_TON_TARIFA[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z62PASAJEROS_TARIFA != T00098_A62PASAJEROS_TARIFA[0] ) || ( StringUtil.StrCmp(Z64PASAJEROS_COMENTARIO, T00098_A64PASAJEROS_COMENTARIO[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"PASAJEROS"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0911( )
      {
         BeforeValidate0911( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0911( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0911( 0) ;
            CheckOptimisticConcurrency0911( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0911( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0911( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00099 */
                     pr_default.execute(7, new Object[] {A58PASAJEROS_ESCLUSA, A60PASAJEROS_TIPO_TARIFA, A59PASAJEROS_CARGA, A65PASAJEROS_ID_TON_TARIF, n61PASAJEROS_TON_TARIFA, A61PASAJEROS_TON_TARIFA, A62PASAJEROS_TARIFA, n64PASAJEROS_COMENTARIO, A64PASAJEROS_COMENTARIO});
                     pr_default.close(7);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000910 */
                     pr_default.execute(8);
                     A63PASAJEROS_ID = T000910_A63PASAJEROS_ID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63PASAJEROS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A63PASAJEROS_ID), 4, 0)));
                     pr_default.close(8);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "", true);
                           ResetCaption090( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load0911( ) ;
            }
            EndLevel0911( ) ;
         }
         CloseExtendedTableCursors0911( ) ;
      }

      protected void Update0911( )
      {
         BeforeValidate0911( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0911( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0911( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0911( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0911( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000911 */
                     pr_default.execute(9, new Object[] {A58PASAJEROS_ESCLUSA, A60PASAJEROS_TIPO_TARIFA, A59PASAJEROS_CARGA, A65PASAJEROS_ID_TON_TARIF, n61PASAJEROS_TON_TARIFA, A61PASAJEROS_TON_TARIFA, A62PASAJEROS_TARIFA, n64PASAJEROS_COMENTARIO, A64PASAJEROS_COMENTARIO, A63PASAJEROS_ID});
                     pr_default.close(9);
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"PASAJEROS"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0911( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "", true);
                           ResetCaption090( ) ;
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel0911( ) ;
         }
         CloseExtendedTableCursors0911( ) ;
      }

      protected void DeferredUpdate0911( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0911( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0911( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0911( ) ;
            AfterConfirm0911( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0911( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000912 */
                  pr_default.execute(10, new Object[] {A63PASAJEROS_ID});
                  pr_default.close(10);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound11 == 0 )
                        {
                           InitAll0911( ) ;
                           Gx_mode = "INS";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), 0, "", true);
                        ResetCaption090( ) ;
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode11 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0911( ) ;
         Gx_mode = sMode11;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0911( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0911( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(6);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0911( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(4);
            context.CommitDataStores( "PASAJEROS");
            if ( AnyError == 0 )
            {
               ConfirmValues090( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(4);
            context.RollbackDataStores( "PASAJEROS");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0911( )
      {
         /* Using cursor T000913 */
         pr_default.execute(11);
         RcdFound11 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound11 = 1;
            A63PASAJEROS_ID = T000913_A63PASAJEROS_ID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63PASAJEROS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A63PASAJEROS_ID), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0911( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound11 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound11 = 1;
            A63PASAJEROS_ID = T000913_A63PASAJEROS_ID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63PASAJEROS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A63PASAJEROS_ID), 4, 0)));
         }
      }

      protected void ScanEnd0911( )
      {
      }

      protected void AfterConfirm0911( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0911( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0911( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0911( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0911( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0911( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0911( )
      {
         edtPASAJEROS_ID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPASAJEROS_ID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPASAJEROS_ID_Enabled), 5, 0)));
         cmbPASAJEROS_ESCLUSA.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPASAJEROS_ESCLUSA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbPASAJEROS_ESCLUSA.Enabled), 5, 0)));
         cmbPASAJEROS_TIPO_TARIFA.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPASAJEROS_TIPO_TARIFA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbPASAJEROS_TIPO_TARIFA.Enabled), 5, 0)));
         cmbPASAJEROS_CARGA.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPASAJEROS_CARGA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbPASAJEROS_CARGA.Enabled), 5, 0)));
         edtPASAJEROS_ID_TON_TARIF_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPASAJEROS_ID_TON_TARIF_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPASAJEROS_ID_TON_TARIF_Enabled), 5, 0)));
         edtPASAJEROS_TON_TARIFA_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPASAJEROS_TON_TARIFA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPASAJEROS_TON_TARIFA_Enabled), 5, 0)));
         edtPASAJEROS_TARIFA_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPASAJEROS_TARIFA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPASAJEROS_TARIFA_Enabled), 5, 0)));
         edtPASAJEROS_COMENTARIO_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPASAJEROS_COMENTARIO_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPASAJEROS_COMENTARIO_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues090( )
      {
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("gxcfg.js", "?20151209384979");
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"";
         context.WriteHtmlText( "<body") ;
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+";") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background-image:url("+context.convertURL( Form.Background)+")") ;
         }
         context.WriteHtmlText( "\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" class=\"form-horizontal Form\" novalidate action=\""+formatLink("pasajeros.aspx") +"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z63PASAJEROS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z63PASAJEROS_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "Z58PASAJEROS_ESCLUSA", StringUtil.RTrim( Z58PASAJEROS_ESCLUSA));
         GxWebStd.gx_hidden_field( context, "Z60PASAJEROS_TIPO_TARIFA", StringUtil.RTrim( Z60PASAJEROS_TIPO_TARIFA));
         GxWebStd.gx_hidden_field( context, "Z59PASAJEROS_CARGA", StringUtil.RTrim( Z59PASAJEROS_CARGA));
         GxWebStd.gx_hidden_field( context, "Z65PASAJEROS_ID_TON_TARIF", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z65PASAJEROS_ID_TON_TARIF), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "Z61PASAJEROS_TON_TARIFA", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z61PASAJEROS_TON_TARIFA), 10, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "Z62PASAJEROS_TARIFA", StringUtil.LTrim( StringUtil.NToC( Z62PASAJEROS_TARIFA, 10, 2, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "Z64PASAJEROS_COMENTARIO", StringUtil.RTrim( Z64PASAJEROS_COMENTARIO));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         context.WriteHtmlText( "<script type=\"text/javascript\">") ;
         context.WriteHtmlText( "gx.setLanguageCode(\""+context.GetLanguageProperty( "code")+"\");") ;
         if ( ! context.isSpaRequest( ) )
         {
            context.WriteHtmlText( "gx.setDateFormat(\""+context.GetLanguageProperty( "date_fmt")+"\");") ;
            context.WriteHtmlText( "gx.setTimeFormat("+context.GetLanguageProperty( "time_fmt")+");") ;
            context.WriteHtmlText( "gx.setCenturyFirstYear("+40+");") ;
            context.WriteHtmlText( "gx.setDecimalPoint(\""+context.GetLanguageProperty( "decimal_point")+"\");") ;
            context.WriteHtmlText( "gx.setThousandSeparator(\""+context.GetLanguageProperty( "thousand_sep")+"\");") ;
            context.WriteHtmlText( "gx.StorageTimeZone = "+1+";") ;
         }
         context.WriteHtmlText( "</script>") ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken(sPrefix);
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.WriteHtmlTextNl( "</form>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         context.WriteHtmlText( "<div") ;
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
         context.WriteHtmlText( ">") ;
         Draw( ) ;
         context.WriteHtmlText( "</div>") ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("pasajeros.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "pasajeros" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "Transaccion para el segmento de buques de pasajeros", "") ;
      }

      protected void InitializeNonKey0911( )
      {
         A58PASAJEROS_ESCLUSA = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58PASAJEROS_ESCLUSA", A58PASAJEROS_ESCLUSA);
         A60PASAJEROS_TIPO_TARIFA = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60PASAJEROS_TIPO_TARIFA", A60PASAJEROS_TIPO_TARIFA);
         A59PASAJEROS_CARGA = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59PASAJEROS_CARGA", A59PASAJEROS_CARGA);
         A65PASAJEROS_ID_TON_TARIF = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65PASAJEROS_ID_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(A65PASAJEROS_ID_TON_TARIF), 4, 0)));
         A61PASAJEROS_TON_TARIFA = 0;
         n61PASAJEROS_TON_TARIFA = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61PASAJEROS_TON_TARIFA", StringUtil.LTrim( StringUtil.Str( (decimal)(A61PASAJEROS_TON_TARIFA), 10, 0)));
         n61PASAJEROS_TON_TARIFA = ((0==A61PASAJEROS_TON_TARIFA) ? true : false);
         A62PASAJEROS_TARIFA = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62PASAJEROS_TARIFA", StringUtil.LTrim( StringUtil.Str( A62PASAJEROS_TARIFA, 10, 2)));
         A64PASAJEROS_COMENTARIO = "";
         n64PASAJEROS_COMENTARIO = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64PASAJEROS_COMENTARIO", A64PASAJEROS_COMENTARIO);
         n64PASAJEROS_COMENTARIO = (String.IsNullOrEmpty(StringUtil.RTrim( A64PASAJEROS_COMENTARIO)) ? true : false);
      }

      protected void InitAll0911( )
      {
         A63PASAJEROS_ID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63PASAJEROS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A63PASAJEROS_ID), 4, 0)));
         InitializeNonKey0911( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?9383857");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20151209384981");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages."+context.GetLanguageProperty( "code")+".js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("pasajeros.js", "?20151209384981");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTitle_Internalname = "TITLE";
         lblTitle_Internalname = "TITLE";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         bttBtn_last_Internalname = "BTN_LAST";
         div_Internalname = "";
         div_Internalname = "";
         bttBtn_select_Internalname = "BTN_SELECT";
         bttBtn_select_Internalname = "BTN_SELECT";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl22_Internalname = "LBL22";
         lbllbl22_Internalname = "LBL22";
         edtPASAJEROS_ID_Internalname = "PASAJEROS_ID";
         edtPASAJEROS_ID_Internalname = "PASAJEROS_ID";
         div_Internalname = "";
         div_Internalname = "";
         divPasajeros_id_container_Internalname = "PASAJEROS_ID_CONTAINER";
         divPasajeros_id_container_Internalname = "PASAJEROS_ID_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl28_Internalname = "LBL28";
         lbllbl28_Internalname = "LBL28";
         cmbPASAJEROS_ESCLUSA_Internalname = "PASAJEROS_ESCLUSA";
         cmbPASAJEROS_ESCLUSA_Internalname = "PASAJEROS_ESCLUSA";
         div_Internalname = "";
         div_Internalname = "";
         divPasajeros_esclusa_container_Internalname = "PASAJEROS_ESCLUSA_CONTAINER";
         divPasajeros_esclusa_container_Internalname = "PASAJEROS_ESCLUSA_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl34_Internalname = "LBL34";
         lbllbl34_Internalname = "LBL34";
         cmbPASAJEROS_TIPO_TARIFA_Internalname = "PASAJEROS_TIPO_TARIFA";
         cmbPASAJEROS_TIPO_TARIFA_Internalname = "PASAJEROS_TIPO_TARIFA";
         div_Internalname = "";
         div_Internalname = "";
         divPasajeros_tipo_tarifa_container_Internalname = "PASAJEROS_TIPO_TARIFA_CONTAINER";
         divPasajeros_tipo_tarifa_container_Internalname = "PASAJEROS_TIPO_TARIFA_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl40_Internalname = "LBL40";
         lbllbl40_Internalname = "LBL40";
         cmbPASAJEROS_CARGA_Internalname = "PASAJEROS_CARGA";
         cmbPASAJEROS_CARGA_Internalname = "PASAJEROS_CARGA";
         div_Internalname = "";
         div_Internalname = "";
         divPasajeros_carga_container_Internalname = "PASAJEROS_CARGA_CONTAINER";
         divPasajeros_carga_container_Internalname = "PASAJEROS_CARGA_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl46_Internalname = "LBL46";
         lbllbl46_Internalname = "LBL46";
         edtPASAJEROS_ID_TON_TARIF_Internalname = "PASAJEROS_ID_TON_TARIF";
         edtPASAJEROS_ID_TON_TARIF_Internalname = "PASAJEROS_ID_TON_TARIF";
         div_Internalname = "";
         div_Internalname = "";
         divPasajeros_id_ton_tarif_container_Internalname = "PASAJEROS_ID_TON_TARIF_CONTAINER";
         divPasajeros_id_ton_tarif_container_Internalname = "PASAJEROS_ID_TON_TARIF_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl52_Internalname = "LBL52";
         lbllbl52_Internalname = "LBL52";
         edtPASAJEROS_TON_TARIFA_Internalname = "PASAJEROS_TON_TARIFA";
         edtPASAJEROS_TON_TARIFA_Internalname = "PASAJEROS_TON_TARIFA";
         div_Internalname = "";
         div_Internalname = "";
         divPasajeros_ton_tarifa_container_Internalname = "PASAJEROS_TON_TARIFA_CONTAINER";
         divPasajeros_ton_tarifa_container_Internalname = "PASAJEROS_TON_TARIFA_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl58_Internalname = "LBL58";
         lbllbl58_Internalname = "LBL58";
         edtPASAJEROS_TARIFA_Internalname = "PASAJEROS_TARIFA";
         edtPASAJEROS_TARIFA_Internalname = "PASAJEROS_TARIFA";
         div_Internalname = "";
         div_Internalname = "";
         divPasajeros_tarifa_container_Internalname = "PASAJEROS_TARIFA_CONTAINER";
         divPasajeros_tarifa_container_Internalname = "PASAJEROS_TARIFA_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl64_Internalname = "LBL64";
         lbllbl64_Internalname = "LBL64";
         edtPASAJEROS_COMENTARIO_Internalname = "PASAJEROS_COMENTARIO";
         edtPASAJEROS_COMENTARIO_Internalname = "PASAJEROS_COMENTARIO";
         div_Internalname = "";
         div_Internalname = "";
         divPasajeros_comentario_container_Internalname = "PASAJEROS_COMENTARIO_CONTAINER";
         divPasajeros_comentario_container_Internalname = "PASAJEROS_COMENTARIO_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         bttBtn_delete_Internalname = "BTN_DELETE";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divTablemain_Internalname = "TABLEMAIN";
         divTablemain_Internalname = "TABLEMAIN";
         div_Internalname = "";
         div_Internalname = "";
         Form.Internalname = "FORM";
         Form.Internalname = "FORM";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = context.GetMessage( "Transaccion para el segmento de buques de pasajeros", "");
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtPASAJEROS_COMENTARIO_Jsonclick = "";
         edtPASAJEROS_COMENTARIO_Enabled = 1;
         edtPASAJEROS_TARIFA_Jsonclick = "";
         edtPASAJEROS_TARIFA_Enabled = 1;
         edtPASAJEROS_TON_TARIFA_Jsonclick = "";
         edtPASAJEROS_TON_TARIFA_Enabled = 1;
         edtPASAJEROS_ID_TON_TARIF_Jsonclick = "";
         edtPASAJEROS_ID_TON_TARIF_Enabled = 1;
         cmbPASAJEROS_CARGA_Jsonclick = "";
         cmbPASAJEROS_CARGA.Enabled = 1;
         cmbPASAJEROS_TIPO_TARIFA_Jsonclick = "";
         cmbPASAJEROS_TIPO_TARIFA.Enabled = 1;
         cmbPASAJEROS_ESCLUSA_Jsonclick = "";
         cmbPASAJEROS_ESCLUSA.Enabled = 1;
         edtPASAJEROS_ID_Jsonclick = "";
         edtPASAJEROS_ID_Enabled = 1;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         getEqualNoModal( ) ;
         GX_FocusControl = cmbPASAJEROS_ESCLUSA_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Pasajeros_id( short GX_Parm1 ,
                                      GXCombobox cmbGX_Parm2 ,
                                      GXCombobox cmbGX_Parm3 ,
                                      GXCombobox cmbGX_Parm4 ,
                                      short GX_Parm5 ,
                                      long GX_Parm6 ,
                                      decimal GX_Parm7 ,
                                      String GX_Parm8 )
      {
         A63PASAJEROS_ID = GX_Parm1;
         cmbPASAJEROS_ESCLUSA = cmbGX_Parm2;
         A58PASAJEROS_ESCLUSA = cmbPASAJEROS_ESCLUSA.CurrentValue;
         cmbPASAJEROS_ESCLUSA.CurrentValue = A58PASAJEROS_ESCLUSA;
         cmbPASAJEROS_TIPO_TARIFA = cmbGX_Parm3;
         A60PASAJEROS_TIPO_TARIFA = cmbPASAJEROS_TIPO_TARIFA.CurrentValue;
         cmbPASAJEROS_TIPO_TARIFA.CurrentValue = A60PASAJEROS_TIPO_TARIFA;
         cmbPASAJEROS_CARGA = cmbGX_Parm4;
         A59PASAJEROS_CARGA = cmbPASAJEROS_CARGA.CurrentValue;
         cmbPASAJEROS_CARGA.CurrentValue = A59PASAJEROS_CARGA;
         A65PASAJEROS_ID_TON_TARIF = GX_Parm5;
         A61PASAJEROS_TON_TARIFA = GX_Parm6;
         n61PASAJEROS_TON_TARIFA = false;
         A62PASAJEROS_TARIFA = GX_Parm7;
         A64PASAJEROS_COMENTARIO = GX_Parm8;
         n64PASAJEROS_COMENTARIO = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         cmbPASAJEROS_ESCLUSA.CurrentValue = A58PASAJEROS_ESCLUSA;
         isValidOutput.Add(cmbPASAJEROS_ESCLUSA);
         cmbPASAJEROS_TIPO_TARIFA.CurrentValue = A60PASAJEROS_TIPO_TARIFA;
         isValidOutput.Add(cmbPASAJEROS_TIPO_TARIFA);
         cmbPASAJEROS_CARGA.CurrentValue = A59PASAJEROS_CARGA;
         isValidOutput.Add(cmbPASAJEROS_CARGA);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A65PASAJEROS_ID_TON_TARIF), 4, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A61PASAJEROS_TON_TARIFA), 10, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A62PASAJEROS_TARIFA, 10, 2, ".", "")));
         isValidOutput.Add(StringUtil.RTrim( A64PASAJEROS_COMENTARIO));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z63PASAJEROS_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         isValidOutput.Add(StringUtil.RTrim( Z58PASAJEROS_ESCLUSA));
         isValidOutput.Add(StringUtil.RTrim( Z60PASAJEROS_TIPO_TARIFA));
         isValidOutput.Add(StringUtil.RTrim( Z59PASAJEROS_CARGA));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z65PASAJEROS_ID_TON_TARIF), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z61PASAJEROS_TON_TARIFA), 10, 0, context.GetLanguageProperty( "decimal_point"), "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( Z62PASAJEROS_TARIFA, 10, 2, context.GetLanguageProperty( "decimal_point"), "")));
         isValidOutput.Add(StringUtil.RTrim( Z64PASAJEROS_COMENTARIO));
         isValidOutput.Add(bttBtn_delete_Enabled);
         isValidOutput.Add(bttBtn_enter_Enabled);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true}],oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[],oparms:[]}");
         return  ;
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(11);
         pr_default.close(5);
         pr_default.close(4);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z58PASAJEROS_ESCLUSA = "";
         Z60PASAJEROS_TIPO_TARIFA = "";
         Z59PASAJEROS_CARGA = "";
         Z64PASAJEROS_COMENTARIO = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         A58PASAJEROS_ESCLUSA = "";
         A60PASAJEROS_TIPO_TARIFA = "";
         A59PASAJEROS_CARGA = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         lblTitle_Jsonclick = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         lbllbl22_Jsonclick = "";
         lbllbl28_Jsonclick = "";
         lbllbl34_Jsonclick = "";
         lbllbl40_Jsonclick = "";
         lbllbl46_Jsonclick = "";
         lbllbl52_Jsonclick = "";
         lbllbl58_Jsonclick = "";
         lbllbl64_Jsonclick = "";
         A64PASAJEROS_COMENTARIO = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T00094_A63PASAJEROS_ID = new short[1] ;
         T00094_A58PASAJEROS_ESCLUSA = new String[] {""} ;
         T00094_A60PASAJEROS_TIPO_TARIFA = new String[] {""} ;
         T00094_A59PASAJEROS_CARGA = new String[] {""} ;
         T00094_A65PASAJEROS_ID_TON_TARIF = new short[1] ;
         T00094_A61PASAJEROS_TON_TARIFA = new long[1] ;
         T00094_n61PASAJEROS_TON_TARIFA = new bool[] {false} ;
         T00094_A62PASAJEROS_TARIFA = new decimal[1] ;
         T00094_A64PASAJEROS_COMENTARIO = new String[] {""} ;
         T00094_n64PASAJEROS_COMENTARIO = new bool[] {false} ;
         T00095_A63PASAJEROS_ID = new short[1] ;
         T00093_A63PASAJEROS_ID = new short[1] ;
         T00093_A58PASAJEROS_ESCLUSA = new String[] {""} ;
         T00093_A60PASAJEROS_TIPO_TARIFA = new String[] {""} ;
         T00093_A59PASAJEROS_CARGA = new String[] {""} ;
         T00093_A65PASAJEROS_ID_TON_TARIF = new short[1] ;
         T00093_A61PASAJEROS_TON_TARIFA = new long[1] ;
         T00093_n61PASAJEROS_TON_TARIFA = new bool[] {false} ;
         T00093_A62PASAJEROS_TARIFA = new decimal[1] ;
         T00093_A64PASAJEROS_COMENTARIO = new String[] {""} ;
         T00093_n64PASAJEROS_COMENTARIO = new bool[] {false} ;
         sMode11 = "";
         T00096_A63PASAJEROS_ID = new short[1] ;
         T00097_A63PASAJEROS_ID = new short[1] ;
         T00098_A63PASAJEROS_ID = new short[1] ;
         T00098_A58PASAJEROS_ESCLUSA = new String[] {""} ;
         T00098_A60PASAJEROS_TIPO_TARIFA = new String[] {""} ;
         T00098_A59PASAJEROS_CARGA = new String[] {""} ;
         T00098_A65PASAJEROS_ID_TON_TARIF = new short[1] ;
         T00098_A61PASAJEROS_TON_TARIFA = new long[1] ;
         T00098_n61PASAJEROS_TON_TARIFA = new bool[] {false} ;
         T00098_A62PASAJEROS_TARIFA = new decimal[1] ;
         T00098_A64PASAJEROS_COMENTARIO = new String[] {""} ;
         T00098_n64PASAJEROS_COMENTARIO = new bool[] {false} ;
         T000910_A63PASAJEROS_ID = new short[1] ;
         T000913_A63PASAJEROS_ID = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pasajeros__default(),
            new Object[][] {
                new Object[] {
               T00092_A63PASAJEROS_ID, T00092_A58PASAJEROS_ESCLUSA, T00092_A60PASAJEROS_TIPO_TARIFA, T00092_A59PASAJEROS_CARGA, T00092_A65PASAJEROS_ID_TON_TARIF, T00092_A61PASAJEROS_TON_TARIFA, T00092_n61PASAJEROS_TON_TARIFA, T00092_A62PASAJEROS_TARIFA, T00092_A64PASAJEROS_COMENTARIO, T00092_n64PASAJEROS_COMENTARIO
               }
               , new Object[] {
               T00093_A63PASAJEROS_ID, T00093_A58PASAJEROS_ESCLUSA, T00093_A60PASAJEROS_TIPO_TARIFA, T00093_A59PASAJEROS_CARGA, T00093_A65PASAJEROS_ID_TON_TARIF, T00093_A61PASAJEROS_TON_TARIFA, T00093_n61PASAJEROS_TON_TARIFA, T00093_A62PASAJEROS_TARIFA, T00093_A64PASAJEROS_COMENTARIO, T00093_n64PASAJEROS_COMENTARIO
               }
               , new Object[] {
               T00094_A63PASAJEROS_ID, T00094_A58PASAJEROS_ESCLUSA, T00094_A60PASAJEROS_TIPO_TARIFA, T00094_A59PASAJEROS_CARGA, T00094_A65PASAJEROS_ID_TON_TARIF, T00094_A61PASAJEROS_TON_TARIFA, T00094_n61PASAJEROS_TON_TARIFA, T00094_A62PASAJEROS_TARIFA, T00094_A64PASAJEROS_COMENTARIO, T00094_n64PASAJEROS_COMENTARIO
               }
               , new Object[] {
               T00095_A63PASAJEROS_ID
               }
               , new Object[] {
               T00096_A63PASAJEROS_ID
               }
               , new Object[] {
               T00097_A63PASAJEROS_ID
               }
               , new Object[] {
               T00098_A63PASAJEROS_ID, T00098_A58PASAJEROS_ESCLUSA, T00098_A60PASAJEROS_TIPO_TARIFA, T00098_A59PASAJEROS_CARGA, T00098_A65PASAJEROS_ID_TON_TARIF, T00098_A61PASAJEROS_TON_TARIFA, T00098_n61PASAJEROS_TON_TARIFA, T00098_A62PASAJEROS_TARIFA, T00098_A64PASAJEROS_COMENTARIO, T00098_n64PASAJEROS_COMENTARIO
               }
               , new Object[] {
               }
               , new Object[] {
               T000910_A63PASAJEROS_ID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000913_A63PASAJEROS_ID
               }
            }
         );
      }

      private short Z63PASAJEROS_ID ;
      private short Z65PASAJEROS_ID_TON_TARIF ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A63PASAJEROS_ID ;
      private short A65PASAJEROS_ID_TON_TARIF ;
      private short GX_JID ;
      private short RcdFound11 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtPASAJEROS_ID_Enabled ;
      private int edtPASAJEROS_ID_TON_TARIF_Enabled ;
      private int edtPASAJEROS_TON_TARIFA_Enabled ;
      private int edtPASAJEROS_TARIFA_Enabled ;
      private int edtPASAJEROS_COMENTARIO_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z61PASAJEROS_TON_TARIFA ;
      private long A61PASAJEROS_TON_TARIFA ;
      private decimal Z62PASAJEROS_TARIFA ;
      private decimal A62PASAJEROS_TARIFA ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtPASAJEROS_ID_Internalname ;
      private String divTablemain_Internalname ;
      private String lblTitle_Internalname ;
      private String lblTitle_Jsonclick ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttBtn_select_Internalname ;
      private String bttBtn_select_Jsonclick ;
      private String divPasajeros_id_container_Internalname ;
      private String lbllbl22_Internalname ;
      private String lbllbl22_Jsonclick ;
      private String edtPASAJEROS_ID_Jsonclick ;
      private String divPasajeros_esclusa_container_Internalname ;
      private String lbllbl28_Internalname ;
      private String lbllbl28_Jsonclick ;
      private String cmbPASAJEROS_ESCLUSA_Internalname ;
      private String cmbPASAJEROS_ESCLUSA_Jsonclick ;
      private String divPasajeros_tipo_tarifa_container_Internalname ;
      private String lbllbl34_Internalname ;
      private String lbllbl34_Jsonclick ;
      private String cmbPASAJEROS_TIPO_TARIFA_Internalname ;
      private String cmbPASAJEROS_TIPO_TARIFA_Jsonclick ;
      private String divPasajeros_carga_container_Internalname ;
      private String lbllbl40_Internalname ;
      private String lbllbl40_Jsonclick ;
      private String cmbPASAJEROS_CARGA_Internalname ;
      private String cmbPASAJEROS_CARGA_Jsonclick ;
      private String divPasajeros_id_ton_tarif_container_Internalname ;
      private String lbllbl46_Internalname ;
      private String lbllbl46_Jsonclick ;
      private String edtPASAJEROS_ID_TON_TARIF_Internalname ;
      private String edtPASAJEROS_ID_TON_TARIF_Jsonclick ;
      private String divPasajeros_ton_tarifa_container_Internalname ;
      private String lbllbl52_Internalname ;
      private String lbllbl52_Jsonclick ;
      private String edtPASAJEROS_TON_TARIFA_Internalname ;
      private String edtPASAJEROS_TON_TARIFA_Jsonclick ;
      private String divPasajeros_tarifa_container_Internalname ;
      private String lbllbl58_Internalname ;
      private String lbllbl58_Jsonclick ;
      private String edtPASAJEROS_TARIFA_Internalname ;
      private String edtPASAJEROS_TARIFA_Jsonclick ;
      private String divPasajeros_comentario_container_Internalname ;
      private String lbllbl64_Internalname ;
      private String lbllbl64_Jsonclick ;
      private String edtPASAJEROS_COMENTARIO_Internalname ;
      private String edtPASAJEROS_COMENTARIO_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode11 ;
      private String sDynURL ;
      private String FormProcess ;
      private String div_Internalname ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool n61PASAJEROS_TON_TARIFA ;
      private bool n64PASAJEROS_COMENTARIO ;
      private bool Gx_longc ;
      private bool toggleJsOutput ;
      private String Z58PASAJEROS_ESCLUSA ;
      private String Z60PASAJEROS_TIPO_TARIFA ;
      private String Z59PASAJEROS_CARGA ;
      private String Z64PASAJEROS_COMENTARIO ;
      private String A58PASAJEROS_ESCLUSA ;
      private String A60PASAJEROS_TIPO_TARIFA ;
      private String A59PASAJEROS_CARGA ;
      private String A64PASAJEROS_COMENTARIO ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbPASAJEROS_ESCLUSA ;
      private GXCombobox cmbPASAJEROS_TIPO_TARIFA ;
      private GXCombobox cmbPASAJEROS_CARGA ;
      private IDataStoreProvider pr_default ;
      private short[] T00094_A63PASAJEROS_ID ;
      private String[] T00094_A58PASAJEROS_ESCLUSA ;
      private String[] T00094_A60PASAJEROS_TIPO_TARIFA ;
      private String[] T00094_A59PASAJEROS_CARGA ;
      private short[] T00094_A65PASAJEROS_ID_TON_TARIF ;
      private long[] T00094_A61PASAJEROS_TON_TARIFA ;
      private bool[] T00094_n61PASAJEROS_TON_TARIFA ;
      private decimal[] T00094_A62PASAJEROS_TARIFA ;
      private String[] T00094_A64PASAJEROS_COMENTARIO ;
      private bool[] T00094_n64PASAJEROS_COMENTARIO ;
      private short[] T00095_A63PASAJEROS_ID ;
      private short[] T00093_A63PASAJEROS_ID ;
      private String[] T00093_A58PASAJEROS_ESCLUSA ;
      private String[] T00093_A60PASAJEROS_TIPO_TARIFA ;
      private String[] T00093_A59PASAJEROS_CARGA ;
      private short[] T00093_A65PASAJEROS_ID_TON_TARIF ;
      private long[] T00093_A61PASAJEROS_TON_TARIFA ;
      private bool[] T00093_n61PASAJEROS_TON_TARIFA ;
      private decimal[] T00093_A62PASAJEROS_TARIFA ;
      private String[] T00093_A64PASAJEROS_COMENTARIO ;
      private bool[] T00093_n64PASAJEROS_COMENTARIO ;
      private short[] T00096_A63PASAJEROS_ID ;
      private short[] T00097_A63PASAJEROS_ID ;
      private short[] T00098_A63PASAJEROS_ID ;
      private String[] T00098_A58PASAJEROS_ESCLUSA ;
      private String[] T00098_A60PASAJEROS_TIPO_TARIFA ;
      private String[] T00098_A59PASAJEROS_CARGA ;
      private short[] T00098_A65PASAJEROS_ID_TON_TARIF ;
      private long[] T00098_A61PASAJEROS_TON_TARIFA ;
      private bool[] T00098_n61PASAJEROS_TON_TARIFA ;
      private decimal[] T00098_A62PASAJEROS_TARIFA ;
      private String[] T00098_A64PASAJEROS_COMENTARIO ;
      private bool[] T00098_n64PASAJEROS_COMENTARIO ;
      private short[] T000910_A63PASAJEROS_ID ;
      private short[] T000913_A63PASAJEROS_ID ;
      private short[] T00092_A63PASAJEROS_ID ;
      private String[] T00092_A58PASAJEROS_ESCLUSA ;
      private String[] T00092_A60PASAJEROS_TIPO_TARIFA ;
      private String[] T00092_A59PASAJEROS_CARGA ;
      private short[] T00092_A65PASAJEROS_ID_TON_TARIF ;
      private long[] T00092_A61PASAJEROS_TON_TARIFA ;
      private decimal[] T00092_A62PASAJEROS_TARIFA ;
      private String[] T00092_A64PASAJEROS_COMENTARIO ;
      private bool[] T00092_n61PASAJEROS_TON_TARIFA ;
      private bool[] T00092_n64PASAJEROS_COMENTARIO ;
      private GXWebForm Form ;
   }

   public class pasajeros__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new ForEachCursor(def[11])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00092 ;
          prmT00092 = new Object[] {
          new Object[] {"@PASAJEROS_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00094 ;
          prmT00094 = new Object[] {
          new Object[] {"@PASAJEROS_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00095 ;
          prmT00095 = new Object[] {
          new Object[] {"@PASAJEROS_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00093 ;
          prmT00093 = new Object[] {
          new Object[] {"@PASAJEROS_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00096 ;
          prmT00096 = new Object[] {
          new Object[] {"@PASAJEROS_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00097 ;
          prmT00097 = new Object[] {
          new Object[] {"@PASAJEROS_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00098 ;
          prmT00098 = new Object[] {
          new Object[] {"@PASAJEROS_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00099 ;
          prmT00099 = new Object[] {
          new Object[] {"@PASAJEROS_ESCLUSA",SqlDbType.VarChar,40,0} ,
          new Object[] {"@PASAJEROS_TIPO_TARIFA",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PASAJEROS_CARGA",SqlDbType.VarChar,40,0} ,
          new Object[] {"@PASAJEROS_ID_TON_TARIF",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PASAJEROS_TON_TARIFA",SqlDbType.Decimal,10,0} ,
          new Object[] {"@PASAJEROS_TARIFA",SqlDbType.Decimal,10,2} ,
          new Object[] {"@PASAJEROS_COMENTARIO",SqlDbType.VarChar,150,0}
          } ;
          Object[] prmT000910 ;
          prmT000910 = new Object[] {
          } ;
          Object[] prmT000911 ;
          prmT000911 = new Object[] {
          new Object[] {"@PASAJEROS_ESCLUSA",SqlDbType.VarChar,40,0} ,
          new Object[] {"@PASAJEROS_TIPO_TARIFA",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PASAJEROS_CARGA",SqlDbType.VarChar,40,0} ,
          new Object[] {"@PASAJEROS_ID_TON_TARIF",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PASAJEROS_TON_TARIFA",SqlDbType.Decimal,10,0} ,
          new Object[] {"@PASAJEROS_TARIFA",SqlDbType.Decimal,10,2} ,
          new Object[] {"@PASAJEROS_COMENTARIO",SqlDbType.VarChar,150,0} ,
          new Object[] {"@PASAJEROS_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000912 ;
          prmT000912 = new Object[] {
          new Object[] {"@PASAJEROS_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000913 ;
          prmT000913 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00092", "SELECT [PASAJEROS_ID], [PASAJEROS_ESCLUSA], [PASAJEROS_TIPO_TARIFA], [PASAJEROS_CARGA], [PASAJEROS_ID_TON_TARIF], [PASAJEROS_TON_TARIFA], [PASAJEROS_TARIFA], [PASAJEROS_COMENTARIO] FROM [PASAJEROS] WITH (UPDLOCK) WHERE [PASAJEROS_ID] = @PASAJEROS_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00092,1,0,true,false )
             ,new CursorDef("T00093", "SELECT [PASAJEROS_ID], [PASAJEROS_ESCLUSA], [PASAJEROS_TIPO_TARIFA], [PASAJEROS_CARGA], [PASAJEROS_ID_TON_TARIF], [PASAJEROS_TON_TARIFA], [PASAJEROS_TARIFA], [PASAJEROS_COMENTARIO] FROM [PASAJEROS] WITH (NOLOCK) WHERE [PASAJEROS_ID] = @PASAJEROS_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00093,1,0,true,false )
             ,new CursorDef("T00094", "SELECT TM1.[PASAJEROS_ID], TM1.[PASAJEROS_ESCLUSA], TM1.[PASAJEROS_TIPO_TARIFA], TM1.[PASAJEROS_CARGA], TM1.[PASAJEROS_ID_TON_TARIF], TM1.[PASAJEROS_TON_TARIFA], TM1.[PASAJEROS_TARIFA], TM1.[PASAJEROS_COMENTARIO] FROM [PASAJEROS] TM1 WITH (NOLOCK) WHERE TM1.[PASAJEROS_ID] = @PASAJEROS_ID ORDER BY TM1.[PASAJEROS_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00094,100,0,true,false )
             ,new CursorDef("T00095", "SELECT [PASAJEROS_ID] FROM [PASAJEROS] WITH (NOLOCK) WHERE [PASAJEROS_ID] = @PASAJEROS_ID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00095,1,0,true,false )
             ,new CursorDef("T00096", "SELECT TOP 1 [PASAJEROS_ID] FROM [PASAJEROS] WITH (NOLOCK) WHERE ( [PASAJEROS_ID] > @PASAJEROS_ID) ORDER BY [PASAJEROS_ID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00096,1,0,true,true )
             ,new CursorDef("T00097", "SELECT TOP 1 [PASAJEROS_ID] FROM [PASAJEROS] WITH (NOLOCK) WHERE ( [PASAJEROS_ID] < @PASAJEROS_ID) ORDER BY [PASAJEROS_ID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00097,1,0,true,true )
             ,new CursorDef("T00098", "SELECT [PASAJEROS_ID], [PASAJEROS_ESCLUSA], [PASAJEROS_TIPO_TARIFA], [PASAJEROS_CARGA], [PASAJEROS_ID_TON_TARIF], [PASAJEROS_TON_TARIFA], [PASAJEROS_TARIFA], [PASAJEROS_COMENTARIO] FROM [PASAJEROS] WITH (UPDLOCK) WHERE [PASAJEROS_ID] = @PASAJEROS_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00098,1,0,true,false )
             ,new CursorDef("T00099", "INSERT INTO [PASAJEROS]([PASAJEROS_ESCLUSA], [PASAJEROS_TIPO_TARIFA], [PASAJEROS_CARGA], [PASAJEROS_ID_TON_TARIF], [PASAJEROS_TON_TARIFA], [PASAJEROS_TARIFA], [PASAJEROS_COMENTARIO]) VALUES(@PASAJEROS_ESCLUSA, @PASAJEROS_TIPO_TARIFA, @PASAJEROS_CARGA, @PASAJEROS_ID_TON_TARIF, @PASAJEROS_TON_TARIFA, @PASAJEROS_TARIFA, @PASAJEROS_COMENTARIO)", GxErrorMask.GX_NOMASK,prmT00099)
             ,new CursorDef("T000910", "SELECT Ident_Current('[PASAJEROS]') ",true, GxErrorMask.GX_NOMASK, false, this,prmT000910,1,0,true,false )
             ,new CursorDef("T000911", "UPDATE [PASAJEROS] SET [PASAJEROS_ESCLUSA]=@PASAJEROS_ESCLUSA, [PASAJEROS_TIPO_TARIFA]=@PASAJEROS_TIPO_TARIFA, [PASAJEROS_CARGA]=@PASAJEROS_CARGA, [PASAJEROS_ID_TON_TARIF]=@PASAJEROS_ID_TON_TARIF, [PASAJEROS_TON_TARIFA]=@PASAJEROS_TON_TARIFA, [PASAJEROS_TARIFA]=@PASAJEROS_TARIFA, [PASAJEROS_COMENTARIO]=@PASAJEROS_COMENTARIO  WHERE [PASAJEROS_ID] = @PASAJEROS_ID", GxErrorMask.GX_NOMASK,prmT000911)
             ,new CursorDef("T000912", "DELETE FROM [PASAJEROS]  WHERE [PASAJEROS_ID] = @PASAJEROS_ID", GxErrorMask.GX_NOMASK,prmT000912)
             ,new CursorDef("T000913", "SELECT [PASAJEROS_ID] FROM [PASAJEROS] WITH (NOLOCK) ORDER BY [PASAJEROS_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000913,100,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((long[]) buf[5])[0] = rslt.getLong(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(7) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((long[]) buf[5])[0] = rslt.getLong(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(7) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((long[]) buf[5])[0] = rslt.getLong(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(7) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                break;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((long[]) buf[5])[0] = rslt.getLong(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(7) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                break;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 5 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(5, (long)parms[5]);
                }
                stmt.SetParameter(6, (decimal)parms[6]);
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 7 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[8]);
                }
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 5 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(5, (long)parms[5]);
                }
                stmt.SetParameter(6, (decimal)parms[6]);
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 7 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[8]);
                }
                stmt.SetParameter(8, (short)parms[9]);
                break;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
