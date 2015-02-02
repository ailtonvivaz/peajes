/*
               File: REF_CGRAL_DESP
        Description: Buques refrigerados, carga general, otros y desplazamiento
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 9:38:48.32
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
   public class ref_cgral_desp : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         cmbREF_CGRAL_DESP_CARGA.Name = "REF_CGRAL_DESP_CARGA";
         cmbREF_CGRAL_DESP_CARGA.WebTags = "";
         cmbREF_CGRAL_DESP_CARGA.addItem("", context.GetMessage( "GX_EmptyItemText", ""), 0);
         cmbREF_CGRAL_DESP_CARGA.addItem("GENERAL", context.GetMessage( "General", ""), 0);
         cmbREF_CGRAL_DESP_CARGA.addItem("REFRIGERADA", context.GetMessage( "Refrigerada", ""), 0);
         cmbREF_CGRAL_DESP_CARGA.addItem("OTROS", context.GetMessage( "Otros", ""), 0);
         cmbREF_CGRAL_DESP_CARGA.addItem("DESPLAZAMIENTO", context.GetMessage( "Desplazamiento", ""), 0);
         cmbREF_CGRAL_DESP_CARGA.addItem("CUBIERTA", context.GetMessage( "Cubierta", ""), 0);
         if ( cmbREF_CGRAL_DESP_CARGA.ItemCount > 0 )
         {
            A44REF_CGRAL_DESP_CARGA = cmbREF_CGRAL_DESP_CARGA.getValidValue(A44REF_CGRAL_DESP_CARGA);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44REF_CGRAL_DESP_CARGA", A44REF_CGRAL_DESP_CARGA);
         }
         cmbREF_CGRAL_DESP_TIPO.Name = "REF_CGRAL_DESP_TIPO";
         cmbREF_CGRAL_DESP_TIPO.WebTags = "";
         cmbREF_CGRAL_DESP_TIPO.addItem("", context.GetMessage( "GX_EmptyItemText", ""), 0);
         cmbREF_CGRAL_DESP_TIPO.addItem("CARGADO", context.GetMessage( "Cargado", ""), 0);
         cmbREF_CGRAL_DESP_TIPO.addItem("EN LASTRE", context.GetMessage( "En Lastre", ""), 0);
         if ( cmbREF_CGRAL_DESP_TIPO.ItemCount > 0 )
         {
            A45REF_CGRAL_DESP_TIPO = cmbREF_CGRAL_DESP_TIPO.getValidValue(A45REF_CGRAL_DESP_TIPO);
            n45REF_CGRAL_DESP_TIPO = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45REF_CGRAL_DESP_TIPO", A45REF_CGRAL_DESP_TIPO);
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_2-86442", 0) ;
            Form.Meta.addItem("description", context.GetMessage( "Buques refrigerados, carga general, otros y desplazamiento", ""), 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtREF_CGRAL_DESP_ID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Flat");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public ref_cgral_desp( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public ref_cgral_desp( IGxContext context )
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
         cmbREF_CGRAL_DESP_CARGA = new GXCombobox();
         cmbREF_CGRAL_DESP_TIPO = new GXCombobox();
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, context.GetMessage( "Buques refrigerados, carga general, otros y desplazamiento", ""), "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_REF_CGRAL_DESP.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", context.GetMessage( "GX_BtnFirst", ""), bttBtn_first_Jsonclick, 5, context.GetMessage( "GX_BtnFirst", ""), "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_REF_CGRAL_DESP.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", context.GetMessage( "GX_BtnPrevious", ""), bttBtn_previous_Jsonclick, 5, context.GetMessage( "GX_BtnPrevious", ""), "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_REF_CGRAL_DESP.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", context.GetMessage( "GX_BtnNext", ""), bttBtn_next_Jsonclick, 5, context.GetMessage( "GX_BtnNext", ""), "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_REF_CGRAL_DESP.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", context.GetMessage( "GX_BtnLast", ""), bttBtn_last_Jsonclick, 5, context.GetMessage( "GX_BtnLast", ""), "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_REF_CGRAL_DESP.htm");
            context.WriteHtmlText( "</div>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", context.GetMessage( "GX_BtnSelect", ""), bttBtn_select_Jsonclick, 4, context.GetMessage( "GX_BtnSelect", ""), "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0090.aspx"+"',["+"{Ctrl:gx.dom.el('"+"REF_CGRAL_DESP_ID"+"'), id:'"+"REF_CGRAL_DESP_ID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_REF_CGRAL_DESP.htm");
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
            GxWebStd.gx_div_start( context, divRef_cgral_desp_id_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl22_Internalname, context.GetMessage( "ID", ""), "", "", lbllbl22_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_REF_CGRAL_DESP.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtREF_CGRAL_DESP_ID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A49REF_CGRAL_DESP_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtREF_CGRAL_DESP_ID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A49REF_CGRAL_DESP_ID), "ZZZ9")) : context.localUtil.Format( (decimal)(A49REF_CGRAL_DESP_ID), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(24);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtREF_CGRAL_DESP_ID_Jsonclick, 0, "Attribute", "", "", "", 1, edtREF_CGRAL_DESP_ID_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_REF_CGRAL_DESP.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divRef_cgral_desp_carga_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl28_Internalname, context.GetMessage( "Carga", ""), "", "", lbllbl28_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_REF_CGRAL_DESP.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbREF_CGRAL_DESP_CARGA, cmbREF_CGRAL_DESP_CARGA_Internalname, A44REF_CGRAL_DESP_CARGA, 1, cmbREF_CGRAL_DESP_CARGA_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbREF_CGRAL_DESP_CARGA.Enabled, 0, 0, 80, "chr", 0, "", "", "Attribute", "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(30);\"", "", true, "HLP_REF_CGRAL_DESP.htm");
            cmbREF_CGRAL_DESP_CARGA.CurrentValue = A44REF_CGRAL_DESP_CARGA;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbREF_CGRAL_DESP_CARGA_Internalname, "Values", (String)(cmbREF_CGRAL_DESP_CARGA.ToJavascriptSource()));
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divRef_cgral_desp_tipo_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl34_Internalname, context.GetMessage( "Tipo", ""), "", "", lbllbl34_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_REF_CGRAL_DESP.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbREF_CGRAL_DESP_TIPO, cmbREF_CGRAL_DESP_TIPO_Internalname, A45REF_CGRAL_DESP_TIPO, 1, cmbREF_CGRAL_DESP_TIPO_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbREF_CGRAL_DESP_TIPO.Enabled, 0, 0, 50, "chr", 0, "", "", "Attribute", "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(36);\"", "", true, "HLP_REF_CGRAL_DESP.htm");
            cmbREF_CGRAL_DESP_TIPO.CurrentValue = A45REF_CGRAL_DESP_TIPO;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbREF_CGRAL_DESP_TIPO_Internalname, "Values", (String)(cmbREF_CGRAL_DESP_TIPO.ToJavascriptSource()));
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divRef_cgral_desp_id_ton_tarif_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl40_Internalname, context.GetMessage( "TON ID", ""), "", "", lbllbl40_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_REF_CGRAL_DESP.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtREF_CGRAL_DESP_ID_TON_TARIF_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A48REF_CGRAL_DESP_ID_TON_TARIF), 4, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtREF_CGRAL_DESP_ID_TON_TARIF_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A48REF_CGRAL_DESP_ID_TON_TARIF), "ZZZ9")) : context.localUtil.Format( (decimal)(A48REF_CGRAL_DESP_ID_TON_TARIF), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(42);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtREF_CGRAL_DESP_ID_TON_TARIF_Jsonclick, 0, "Attribute", "", "", "", 1, edtREF_CGRAL_DESP_ID_TON_TARIF_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_REF_CGRAL_DESP.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divRef_cgral_desp_ton_tarif_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl46_Internalname, context.GetMessage( "Rango", ""), "", "", lbllbl46_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_REF_CGRAL_DESP.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtREF_CGRAL_DESP_TON_TARIF_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A46REF_CGRAL_DESP_TON_TARIF), 10, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtREF_CGRAL_DESP_TON_TARIF_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A46REF_CGRAL_DESP_TON_TARIF), "ZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A46REF_CGRAL_DESP_TON_TARIF), "ZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtREF_CGRAL_DESP_TON_TARIF_Jsonclick, 0, "Attribute", "", "", "", 1, edtREF_CGRAL_DESP_TON_TARIF_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_REF_CGRAL_DESP.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divRef_cgral_desp_tarifa_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl52_Internalname, context.GetMessage( "Tarifa", ""), "", "", lbllbl52_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_REF_CGRAL_DESP.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtREF_CGRAL_DESP_TARIFA_Internalname, StringUtil.LTrim( StringUtil.NToC( A47REF_CGRAL_DESP_TARIFA, 10, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtREF_CGRAL_DESP_TARIFA_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A47REF_CGRAL_DESP_TARIFA, "ZZZZZZ9.99")) : context.localUtil.Format( A47REF_CGRAL_DESP_TARIFA, "ZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtREF_CGRAL_DESP_TARIFA_Jsonclick, 0, "Attribute", "", "", "", 1, edtREF_CGRAL_DESP_TARIFA_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_REF_CGRAL_DESP.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divRef_cgral_desp_comentario_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl58_Internalname, context.GetMessage( "Comentario", ""), "", "", lbllbl58_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_REF_CGRAL_DESP.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtREF_CGRAL_DESP_COMENTARIO_Internalname, StringUtil.RTrim( A50REF_CGRAL_DESP_COMENTARIO), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(60);\"", 0, 1, edtREF_CGRAL_DESP_COMENTARIO_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "250", -1, "", "", -1, true, "", "HLP_REF_CGRAL_DESP.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", context.GetMessage( "GX_BtnEnter", ""), bttBtn_enter_Jsonclick, 5, context.GetMessage( "GX_BtnEnter", ""), "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_REF_CGRAL_DESP.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", context.GetMessage( "GX_BtnCancel", ""), bttBtn_cancel_Jsonclick, 1, context.GetMessage( "GX_BtnCancel", ""), "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_REF_CGRAL_DESP.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", context.GetMessage( "GX_BtnDelete", ""), bttBtn_delete_Jsonclick, 5, context.GetMessage( "GX_BtnDelete", ""), "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_REF_CGRAL_DESP.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtREF_CGRAL_DESP_ID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtREF_CGRAL_DESP_ID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "REF_CGRAL_DESP_ID");
                  AnyError = 1;
                  GX_FocusControl = edtREF_CGRAL_DESP_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A49REF_CGRAL_DESP_ID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49REF_CGRAL_DESP_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A49REF_CGRAL_DESP_ID), 4, 0)));
               }
               else
               {
                  A49REF_CGRAL_DESP_ID = (short)(context.localUtil.CToN( cgiGet( edtREF_CGRAL_DESP_ID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49REF_CGRAL_DESP_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A49REF_CGRAL_DESP_ID), 4, 0)));
               }
               cmbREF_CGRAL_DESP_CARGA.CurrentValue = cgiGet( cmbREF_CGRAL_DESP_CARGA_Internalname);
               A44REF_CGRAL_DESP_CARGA = cgiGet( cmbREF_CGRAL_DESP_CARGA_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44REF_CGRAL_DESP_CARGA", A44REF_CGRAL_DESP_CARGA);
               if ( cmbREF_CGRAL_DESP_CARGA.ItemCount > 0 )
               {
                  A44REF_CGRAL_DESP_CARGA = cmbREF_CGRAL_DESP_CARGA.getValidValue(A44REF_CGRAL_DESP_CARGA);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44REF_CGRAL_DESP_CARGA", A44REF_CGRAL_DESP_CARGA);
               }
               cmbREF_CGRAL_DESP_TIPO.CurrentValue = cgiGet( cmbREF_CGRAL_DESP_TIPO_Internalname);
               A45REF_CGRAL_DESP_TIPO = cgiGet( cmbREF_CGRAL_DESP_TIPO_Internalname);
               n45REF_CGRAL_DESP_TIPO = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45REF_CGRAL_DESP_TIPO", A45REF_CGRAL_DESP_TIPO);
               n45REF_CGRAL_DESP_TIPO = (String.IsNullOrEmpty(StringUtil.RTrim( A45REF_CGRAL_DESP_TIPO)) ? true : false);
               if ( cmbREF_CGRAL_DESP_TIPO.ItemCount > 0 )
               {
                  A45REF_CGRAL_DESP_TIPO = cmbREF_CGRAL_DESP_TIPO.getValidValue(A45REF_CGRAL_DESP_TIPO);
                  n45REF_CGRAL_DESP_TIPO = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45REF_CGRAL_DESP_TIPO", A45REF_CGRAL_DESP_TIPO);
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtREF_CGRAL_DESP_ID_TON_TARIF_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtREF_CGRAL_DESP_ID_TON_TARIF_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "REF_CGRAL_DESP_ID_TON_TARIF");
                  AnyError = 1;
                  GX_FocusControl = edtREF_CGRAL_DESP_ID_TON_TARIF_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A48REF_CGRAL_DESP_ID_TON_TARIF = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48REF_CGRAL_DESP_ID_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(A48REF_CGRAL_DESP_ID_TON_TARIF), 4, 0)));
               }
               else
               {
                  A48REF_CGRAL_DESP_ID_TON_TARIF = (short)(context.localUtil.CToN( cgiGet( edtREF_CGRAL_DESP_ID_TON_TARIF_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48REF_CGRAL_DESP_ID_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(A48REF_CGRAL_DESP_ID_TON_TARIF), 4, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtREF_CGRAL_DESP_TON_TARIF_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtREF_CGRAL_DESP_TON_TARIF_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "REF_CGRAL_DESP_TON_TARIF");
                  AnyError = 1;
                  GX_FocusControl = edtREF_CGRAL_DESP_TON_TARIF_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A46REF_CGRAL_DESP_TON_TARIF = 0;
                  n46REF_CGRAL_DESP_TON_TARIF = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46REF_CGRAL_DESP_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(A46REF_CGRAL_DESP_TON_TARIF), 10, 0)));
               }
               else
               {
                  A46REF_CGRAL_DESP_TON_TARIF = (long)(context.localUtil.CToN( cgiGet( edtREF_CGRAL_DESP_TON_TARIF_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                  n46REF_CGRAL_DESP_TON_TARIF = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46REF_CGRAL_DESP_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(A46REF_CGRAL_DESP_TON_TARIF), 10, 0)));
               }
               n46REF_CGRAL_DESP_TON_TARIF = ((0==A46REF_CGRAL_DESP_TON_TARIF) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtREF_CGRAL_DESP_TARIFA_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtREF_CGRAL_DESP_TARIFA_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 9999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "REF_CGRAL_DESP_TARIFA");
                  AnyError = 1;
                  GX_FocusControl = edtREF_CGRAL_DESP_TARIFA_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A47REF_CGRAL_DESP_TARIFA = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47REF_CGRAL_DESP_TARIFA", StringUtil.LTrim( StringUtil.Str( A47REF_CGRAL_DESP_TARIFA, 10, 2)));
               }
               else
               {
                  A47REF_CGRAL_DESP_TARIFA = context.localUtil.CToN( cgiGet( edtREF_CGRAL_DESP_TARIFA_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47REF_CGRAL_DESP_TARIFA", StringUtil.LTrim( StringUtil.Str( A47REF_CGRAL_DESP_TARIFA, 10, 2)));
               }
               A50REF_CGRAL_DESP_COMENTARIO = cgiGet( edtREF_CGRAL_DESP_COMENTARIO_Internalname);
               n50REF_CGRAL_DESP_COMENTARIO = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50REF_CGRAL_DESP_COMENTARIO", A50REF_CGRAL_DESP_COMENTARIO);
               n50REF_CGRAL_DESP_COMENTARIO = (String.IsNullOrEmpty(StringUtil.RTrim( A50REF_CGRAL_DESP_COMENTARIO)) ? true : false);
               /* Read saved values. */
               Z49REF_CGRAL_DESP_ID = (short)(context.localUtil.CToN( cgiGet( "Z49REF_CGRAL_DESP_ID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               Z44REF_CGRAL_DESP_CARGA = cgiGet( "Z44REF_CGRAL_DESP_CARGA");
               Z45REF_CGRAL_DESP_TIPO = cgiGet( "Z45REF_CGRAL_DESP_TIPO");
               n45REF_CGRAL_DESP_TIPO = (String.IsNullOrEmpty(StringUtil.RTrim( A45REF_CGRAL_DESP_TIPO)) ? true : false);
               Z48REF_CGRAL_DESP_ID_TON_TARIF = (short)(context.localUtil.CToN( cgiGet( "Z48REF_CGRAL_DESP_ID_TON_TARIF"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               Z46REF_CGRAL_DESP_TON_TARIF = (long)(context.localUtil.CToN( cgiGet( "Z46REF_CGRAL_DESP_TON_TARIF"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               n46REF_CGRAL_DESP_TON_TARIF = ((0==A46REF_CGRAL_DESP_TON_TARIF) ? true : false);
               Z47REF_CGRAL_DESP_TARIFA = context.localUtil.CToN( cgiGet( "Z47REF_CGRAL_DESP_TARIFA"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               Z50REF_CGRAL_DESP_COMENTARIO = cgiGet( "Z50REF_CGRAL_DESP_COMENTARIO");
               n50REF_CGRAL_DESP_COMENTARIO = (String.IsNullOrEmpty(StringUtil.RTrim( A50REF_CGRAL_DESP_COMENTARIO)) ? true : false);
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
                  A49REF_CGRAL_DESP_ID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49REF_CGRAL_DESP_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A49REF_CGRAL_DESP_ID), 4, 0)));
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
               InitAll079( ) ;
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
         DisableAttributes079( ) ;
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

      protected void ResetCaption070( )
      {
      }

      protected void ZM079( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z44REF_CGRAL_DESP_CARGA = T00073_A44REF_CGRAL_DESP_CARGA[0];
               Z45REF_CGRAL_DESP_TIPO = T00073_A45REF_CGRAL_DESP_TIPO[0];
               Z48REF_CGRAL_DESP_ID_TON_TARIF = T00073_A48REF_CGRAL_DESP_ID_TON_TARIF[0];
               Z46REF_CGRAL_DESP_TON_TARIF = T00073_A46REF_CGRAL_DESP_TON_TARIF[0];
               Z47REF_CGRAL_DESP_TARIFA = T00073_A47REF_CGRAL_DESP_TARIFA[0];
               Z50REF_CGRAL_DESP_COMENTARIO = T00073_A50REF_CGRAL_DESP_COMENTARIO[0];
            }
            else
            {
               Z44REF_CGRAL_DESP_CARGA = A44REF_CGRAL_DESP_CARGA;
               Z45REF_CGRAL_DESP_TIPO = A45REF_CGRAL_DESP_TIPO;
               Z48REF_CGRAL_DESP_ID_TON_TARIF = A48REF_CGRAL_DESP_ID_TON_TARIF;
               Z46REF_CGRAL_DESP_TON_TARIF = A46REF_CGRAL_DESP_TON_TARIF;
               Z47REF_CGRAL_DESP_TARIFA = A47REF_CGRAL_DESP_TARIFA;
               Z50REF_CGRAL_DESP_COMENTARIO = A50REF_CGRAL_DESP_COMENTARIO;
            }
         }
         if ( GX_JID == -1 )
         {
            Z49REF_CGRAL_DESP_ID = A49REF_CGRAL_DESP_ID;
            Z44REF_CGRAL_DESP_CARGA = A44REF_CGRAL_DESP_CARGA;
            Z45REF_CGRAL_DESP_TIPO = A45REF_CGRAL_DESP_TIPO;
            Z48REF_CGRAL_DESP_ID_TON_TARIF = A48REF_CGRAL_DESP_ID_TON_TARIF;
            Z46REF_CGRAL_DESP_TON_TARIF = A46REF_CGRAL_DESP_TON_TARIF;
            Z47REF_CGRAL_DESP_TARIFA = A47REF_CGRAL_DESP_TARIFA;
            Z50REF_CGRAL_DESP_COMENTARIO = A50REF_CGRAL_DESP_COMENTARIO;
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

      protected void Load079( )
      {
         /* Using cursor T00074 */
         pr_default.execute(2, new Object[] {A49REF_CGRAL_DESP_ID});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound9 = 1;
            A44REF_CGRAL_DESP_CARGA = T00074_A44REF_CGRAL_DESP_CARGA[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44REF_CGRAL_DESP_CARGA", A44REF_CGRAL_DESP_CARGA);
            A45REF_CGRAL_DESP_TIPO = T00074_A45REF_CGRAL_DESP_TIPO[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45REF_CGRAL_DESP_TIPO", A45REF_CGRAL_DESP_TIPO);
            n45REF_CGRAL_DESP_TIPO = T00074_n45REF_CGRAL_DESP_TIPO[0];
            A48REF_CGRAL_DESP_ID_TON_TARIF = T00074_A48REF_CGRAL_DESP_ID_TON_TARIF[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48REF_CGRAL_DESP_ID_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(A48REF_CGRAL_DESP_ID_TON_TARIF), 4, 0)));
            A46REF_CGRAL_DESP_TON_TARIF = T00074_A46REF_CGRAL_DESP_TON_TARIF[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46REF_CGRAL_DESP_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(A46REF_CGRAL_DESP_TON_TARIF), 10, 0)));
            n46REF_CGRAL_DESP_TON_TARIF = T00074_n46REF_CGRAL_DESP_TON_TARIF[0];
            A47REF_CGRAL_DESP_TARIFA = T00074_A47REF_CGRAL_DESP_TARIFA[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47REF_CGRAL_DESP_TARIFA", StringUtil.LTrim( StringUtil.Str( A47REF_CGRAL_DESP_TARIFA, 10, 2)));
            A50REF_CGRAL_DESP_COMENTARIO = T00074_A50REF_CGRAL_DESP_COMENTARIO[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50REF_CGRAL_DESP_COMENTARIO", A50REF_CGRAL_DESP_COMENTARIO);
            n50REF_CGRAL_DESP_COMENTARIO = T00074_n50REF_CGRAL_DESP_COMENTARIO[0];
            ZM079( -1) ;
         }
         pr_default.close(2);
         OnLoadActions079( ) ;
      }

      protected void OnLoadActions079( )
      {
      }

      protected void CheckExtendedTable079( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors079( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey079( )
      {
         /* Using cursor T00075 */
         pr_default.execute(3, new Object[] {A49REF_CGRAL_DESP_ID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound9 = 1;
         }
         else
         {
            RcdFound9 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00073 */
         pr_default.execute(1, new Object[] {A49REF_CGRAL_DESP_ID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM079( 1) ;
            RcdFound9 = 1;
            A49REF_CGRAL_DESP_ID = T00073_A49REF_CGRAL_DESP_ID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49REF_CGRAL_DESP_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A49REF_CGRAL_DESP_ID), 4, 0)));
            A44REF_CGRAL_DESP_CARGA = T00073_A44REF_CGRAL_DESP_CARGA[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44REF_CGRAL_DESP_CARGA", A44REF_CGRAL_DESP_CARGA);
            A45REF_CGRAL_DESP_TIPO = T00073_A45REF_CGRAL_DESP_TIPO[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45REF_CGRAL_DESP_TIPO", A45REF_CGRAL_DESP_TIPO);
            n45REF_CGRAL_DESP_TIPO = T00073_n45REF_CGRAL_DESP_TIPO[0];
            A48REF_CGRAL_DESP_ID_TON_TARIF = T00073_A48REF_CGRAL_DESP_ID_TON_TARIF[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48REF_CGRAL_DESP_ID_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(A48REF_CGRAL_DESP_ID_TON_TARIF), 4, 0)));
            A46REF_CGRAL_DESP_TON_TARIF = T00073_A46REF_CGRAL_DESP_TON_TARIF[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46REF_CGRAL_DESP_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(A46REF_CGRAL_DESP_TON_TARIF), 10, 0)));
            n46REF_CGRAL_DESP_TON_TARIF = T00073_n46REF_CGRAL_DESP_TON_TARIF[0];
            A47REF_CGRAL_DESP_TARIFA = T00073_A47REF_CGRAL_DESP_TARIFA[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47REF_CGRAL_DESP_TARIFA", StringUtil.LTrim( StringUtil.Str( A47REF_CGRAL_DESP_TARIFA, 10, 2)));
            A50REF_CGRAL_DESP_COMENTARIO = T00073_A50REF_CGRAL_DESP_COMENTARIO[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50REF_CGRAL_DESP_COMENTARIO", A50REF_CGRAL_DESP_COMENTARIO);
            n50REF_CGRAL_DESP_COMENTARIO = T00073_n50REF_CGRAL_DESP_COMENTARIO[0];
            Z49REF_CGRAL_DESP_ID = A49REF_CGRAL_DESP_ID;
            sMode9 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load079( ) ;
            if ( AnyError == 1 )
            {
               RcdFound9 = 0;
               InitializeNonKey079( ) ;
            }
            Gx_mode = sMode9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound9 = 0;
            InitializeNonKey079( ) ;
            sMode9 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey079( ) ;
         if ( RcdFound9 == 0 )
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
         RcdFound9 = 0;
         /* Using cursor T00076 */
         pr_default.execute(4, new Object[] {A49REF_CGRAL_DESP_ID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00076_A49REF_CGRAL_DESP_ID[0] < A49REF_CGRAL_DESP_ID ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00076_A49REF_CGRAL_DESP_ID[0] > A49REF_CGRAL_DESP_ID ) ) )
            {
               A49REF_CGRAL_DESP_ID = T00076_A49REF_CGRAL_DESP_ID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49REF_CGRAL_DESP_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A49REF_CGRAL_DESP_ID), 4, 0)));
               RcdFound9 = 1;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound9 = 0;
         /* Using cursor T00077 */
         pr_default.execute(5, new Object[] {A49REF_CGRAL_DESP_ID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00077_A49REF_CGRAL_DESP_ID[0] > A49REF_CGRAL_DESP_ID ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00077_A49REF_CGRAL_DESP_ID[0] < A49REF_CGRAL_DESP_ID ) ) )
            {
               A49REF_CGRAL_DESP_ID = T00077_A49REF_CGRAL_DESP_ID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49REF_CGRAL_DESP_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A49REF_CGRAL_DESP_ID), 4, 0)));
               RcdFound9 = 1;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey079( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtREF_CGRAL_DESP_ID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert079( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound9 == 1 )
            {
               if ( A49REF_CGRAL_DESP_ID != Z49REF_CGRAL_DESP_ID )
               {
                  A49REF_CGRAL_DESP_ID = Z49REF_CGRAL_DESP_ID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49REF_CGRAL_DESP_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A49REF_CGRAL_DESP_ID), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "REF_CGRAL_DESP_ID");
                  AnyError = 1;
                  GX_FocusControl = edtREF_CGRAL_DESP_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtREF_CGRAL_DESP_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update079( ) ;
                  GX_FocusControl = edtREF_CGRAL_DESP_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A49REF_CGRAL_DESP_ID != Z49REF_CGRAL_DESP_ID )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtREF_CGRAL_DESP_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert079( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "REF_CGRAL_DESP_ID");
                     AnyError = 1;
                     GX_FocusControl = edtREF_CGRAL_DESP_ID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtREF_CGRAL_DESP_ID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert079( ) ;
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
         if ( A49REF_CGRAL_DESP_ID != Z49REF_CGRAL_DESP_ID )
         {
            A49REF_CGRAL_DESP_ID = Z49REF_CGRAL_DESP_ID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49REF_CGRAL_DESP_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A49REF_CGRAL_DESP_ID), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "REF_CGRAL_DESP_ID");
            AnyError = 1;
            GX_FocusControl = edtREF_CGRAL_DESP_ID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtREF_CGRAL_DESP_ID_Internalname;
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
         if ( RcdFound9 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "REF_CGRAL_DESP_ID");
            AnyError = 1;
         }
         GX_FocusControl = cmbREF_CGRAL_DESP_CARGA_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         ScanStart079( ) ;
         if ( RcdFound9 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbREF_CGRAL_DESP_CARGA_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd079( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         move_previous( ) ;
         if ( RcdFound9 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbREF_CGRAL_DESP_CARGA_Internalname;
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
         if ( RcdFound9 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbREF_CGRAL_DESP_CARGA_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         ScanStart079( ) ;
         if ( RcdFound9 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound9 != 0 )
            {
               ScanNext079( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbREF_CGRAL_DESP_CARGA_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd079( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency079( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00078 */
            pr_default.execute(6, new Object[] {A49REF_CGRAL_DESP_ID});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"REF_CGRAL_DESP"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(6) == 101) || ( StringUtil.StrCmp(Z44REF_CGRAL_DESP_CARGA, T00078_A44REF_CGRAL_DESP_CARGA[0]) != 0 ) || ( StringUtil.StrCmp(Z45REF_CGRAL_DESP_TIPO, T00078_A45REF_CGRAL_DESP_TIPO[0]) != 0 ) || ( Z48REF_CGRAL_DESP_ID_TON_TARIF != T00078_A48REF_CGRAL_DESP_ID_TON_TARIF[0] ) || ( Z46REF_CGRAL_DESP_TON_TARIF != T00078_A46REF_CGRAL_DESP_TON_TARIF[0] ) || ( Z47REF_CGRAL_DESP_TARIFA != T00078_A47REF_CGRAL_DESP_TARIFA[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z50REF_CGRAL_DESP_COMENTARIO, T00078_A50REF_CGRAL_DESP_COMENTARIO[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"REF_CGRAL_DESP"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert079( )
      {
         BeforeValidate079( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable079( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM079( 0) ;
            CheckOptimisticConcurrency079( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm079( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert079( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00079 */
                     pr_default.execute(7, new Object[] {A44REF_CGRAL_DESP_CARGA, n45REF_CGRAL_DESP_TIPO, A45REF_CGRAL_DESP_TIPO, A48REF_CGRAL_DESP_ID_TON_TARIF, n46REF_CGRAL_DESP_TON_TARIF, A46REF_CGRAL_DESP_TON_TARIF, A47REF_CGRAL_DESP_TARIFA, n50REF_CGRAL_DESP_COMENTARIO, A50REF_CGRAL_DESP_COMENTARIO});
                     pr_default.close(7);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000710 */
                     pr_default.execute(8);
                     A49REF_CGRAL_DESP_ID = T000710_A49REF_CGRAL_DESP_ID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49REF_CGRAL_DESP_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A49REF_CGRAL_DESP_ID), 4, 0)));
                     pr_default.close(8);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "", true);
                           ResetCaption070( ) ;
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
               Load079( ) ;
            }
            EndLevel079( ) ;
         }
         CloseExtendedTableCursors079( ) ;
      }

      protected void Update079( )
      {
         BeforeValidate079( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable079( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency079( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm079( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate079( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000711 */
                     pr_default.execute(9, new Object[] {A44REF_CGRAL_DESP_CARGA, n45REF_CGRAL_DESP_TIPO, A45REF_CGRAL_DESP_TIPO, A48REF_CGRAL_DESP_ID_TON_TARIF, n46REF_CGRAL_DESP_TON_TARIF, A46REF_CGRAL_DESP_TON_TARIF, A47REF_CGRAL_DESP_TARIFA, n50REF_CGRAL_DESP_COMENTARIO, A50REF_CGRAL_DESP_COMENTARIO, A49REF_CGRAL_DESP_ID});
                     pr_default.close(9);
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"REF_CGRAL_DESP"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate079( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "", true);
                           ResetCaption070( ) ;
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
            EndLevel079( ) ;
         }
         CloseExtendedTableCursors079( ) ;
      }

      protected void DeferredUpdate079( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate079( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency079( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls079( ) ;
            AfterConfirm079( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete079( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000712 */
                  pr_default.execute(10, new Object[] {A49REF_CGRAL_DESP_ID});
                  pr_default.close(10);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound9 == 0 )
                        {
                           InitAll079( ) ;
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
                        ResetCaption070( ) ;
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
         sMode9 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel079( ) ;
         Gx_mode = sMode9;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls079( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel079( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(6);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete079( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(4);
            context.CommitDataStores( "REF_CGRAL_DESP");
            if ( AnyError == 0 )
            {
               ConfirmValues070( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(4);
            context.RollbackDataStores( "REF_CGRAL_DESP");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart079( )
      {
         /* Using cursor T000713 */
         pr_default.execute(11);
         RcdFound9 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound9 = 1;
            A49REF_CGRAL_DESP_ID = T000713_A49REF_CGRAL_DESP_ID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49REF_CGRAL_DESP_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A49REF_CGRAL_DESP_ID), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext079( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound9 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound9 = 1;
            A49REF_CGRAL_DESP_ID = T000713_A49REF_CGRAL_DESP_ID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49REF_CGRAL_DESP_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A49REF_CGRAL_DESP_ID), 4, 0)));
         }
      }

      protected void ScanEnd079( )
      {
      }

      protected void AfterConfirm079( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert079( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate079( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete079( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete079( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate079( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes079( )
      {
         edtREF_CGRAL_DESP_ID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtREF_CGRAL_DESP_ID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtREF_CGRAL_DESP_ID_Enabled), 5, 0)));
         cmbREF_CGRAL_DESP_CARGA.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbREF_CGRAL_DESP_CARGA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbREF_CGRAL_DESP_CARGA.Enabled), 5, 0)));
         cmbREF_CGRAL_DESP_TIPO.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbREF_CGRAL_DESP_TIPO_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbREF_CGRAL_DESP_TIPO.Enabled), 5, 0)));
         edtREF_CGRAL_DESP_ID_TON_TARIF_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtREF_CGRAL_DESP_ID_TON_TARIF_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtREF_CGRAL_DESP_ID_TON_TARIF_Enabled), 5, 0)));
         edtREF_CGRAL_DESP_TON_TARIF_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtREF_CGRAL_DESP_TON_TARIF_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtREF_CGRAL_DESP_TON_TARIF_Enabled), 5, 0)));
         edtREF_CGRAL_DESP_TARIFA_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtREF_CGRAL_DESP_TARIFA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtREF_CGRAL_DESP_TARIFA_Enabled), 5, 0)));
         edtREF_CGRAL_DESP_COMENTARIO_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtREF_CGRAL_DESP_COMENTARIO_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtREF_CGRAL_DESP_COMENTARIO_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues070( )
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
         context.AddJavascriptSource("gxcfg.js", "?20151209384889");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" class=\"form-horizontal Form\" novalidate action=\""+formatLink("ref_cgral_desp.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z49REF_CGRAL_DESP_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z49REF_CGRAL_DESP_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "Z44REF_CGRAL_DESP_CARGA", StringUtil.RTrim( Z44REF_CGRAL_DESP_CARGA));
         GxWebStd.gx_hidden_field( context, "Z45REF_CGRAL_DESP_TIPO", StringUtil.RTrim( Z45REF_CGRAL_DESP_TIPO));
         GxWebStd.gx_hidden_field( context, "Z48REF_CGRAL_DESP_ID_TON_TARIF", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z48REF_CGRAL_DESP_ID_TON_TARIF), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "Z46REF_CGRAL_DESP_TON_TARIF", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z46REF_CGRAL_DESP_TON_TARIF), 10, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "Z47REF_CGRAL_DESP_TARIFA", StringUtil.LTrim( StringUtil.NToC( Z47REF_CGRAL_DESP_TARIFA, 10, 2, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "Z50REF_CGRAL_DESP_COMENTARIO", StringUtil.RTrim( Z50REF_CGRAL_DESP_COMENTARIO));
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
         return formatLink("ref_cgral_desp.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "ref_cgral_desp" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "Buques refrigerados, carga general, otros y desplazamiento", "") ;
      }

      protected void InitializeNonKey079( )
      {
         A44REF_CGRAL_DESP_CARGA = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44REF_CGRAL_DESP_CARGA", A44REF_CGRAL_DESP_CARGA);
         A45REF_CGRAL_DESP_TIPO = "";
         n45REF_CGRAL_DESP_TIPO = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45REF_CGRAL_DESP_TIPO", A45REF_CGRAL_DESP_TIPO);
         n45REF_CGRAL_DESP_TIPO = (String.IsNullOrEmpty(StringUtil.RTrim( A45REF_CGRAL_DESP_TIPO)) ? true : false);
         A48REF_CGRAL_DESP_ID_TON_TARIF = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48REF_CGRAL_DESP_ID_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(A48REF_CGRAL_DESP_ID_TON_TARIF), 4, 0)));
         A46REF_CGRAL_DESP_TON_TARIF = 0;
         n46REF_CGRAL_DESP_TON_TARIF = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46REF_CGRAL_DESP_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(A46REF_CGRAL_DESP_TON_TARIF), 10, 0)));
         n46REF_CGRAL_DESP_TON_TARIF = ((0==A46REF_CGRAL_DESP_TON_TARIF) ? true : false);
         A47REF_CGRAL_DESP_TARIFA = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47REF_CGRAL_DESP_TARIFA", StringUtil.LTrim( StringUtil.Str( A47REF_CGRAL_DESP_TARIFA, 10, 2)));
         A50REF_CGRAL_DESP_COMENTARIO = "";
         n50REF_CGRAL_DESP_COMENTARIO = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50REF_CGRAL_DESP_COMENTARIO", A50REF_CGRAL_DESP_COMENTARIO);
         n50REF_CGRAL_DESP_COMENTARIO = (String.IsNullOrEmpty(StringUtil.RTrim( A50REF_CGRAL_DESP_COMENTARIO)) ? true : false);
      }

      protected void InitAll079( )
      {
         A49REF_CGRAL_DESP_ID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49REF_CGRAL_DESP_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A49REF_CGRAL_DESP_ID), 4, 0)));
         InitializeNonKey079( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20151209384891");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages."+context.GetLanguageProperty( "code")+".js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("ref_cgral_desp.js", "?20151209384891");
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
         edtREF_CGRAL_DESP_ID_Internalname = "REF_CGRAL_DESP_ID";
         edtREF_CGRAL_DESP_ID_Internalname = "REF_CGRAL_DESP_ID";
         div_Internalname = "";
         div_Internalname = "";
         divRef_cgral_desp_id_container_Internalname = "REF_CGRAL_DESP_ID_CONTAINER";
         divRef_cgral_desp_id_container_Internalname = "REF_CGRAL_DESP_ID_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl28_Internalname = "LBL28";
         lbllbl28_Internalname = "LBL28";
         cmbREF_CGRAL_DESP_CARGA_Internalname = "REF_CGRAL_DESP_CARGA";
         cmbREF_CGRAL_DESP_CARGA_Internalname = "REF_CGRAL_DESP_CARGA";
         div_Internalname = "";
         div_Internalname = "";
         divRef_cgral_desp_carga_container_Internalname = "REF_CGRAL_DESP_CARGA_CONTAINER";
         divRef_cgral_desp_carga_container_Internalname = "REF_CGRAL_DESP_CARGA_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl34_Internalname = "LBL34";
         lbllbl34_Internalname = "LBL34";
         cmbREF_CGRAL_DESP_TIPO_Internalname = "REF_CGRAL_DESP_TIPO";
         cmbREF_CGRAL_DESP_TIPO_Internalname = "REF_CGRAL_DESP_TIPO";
         div_Internalname = "";
         div_Internalname = "";
         divRef_cgral_desp_tipo_container_Internalname = "REF_CGRAL_DESP_TIPO_CONTAINER";
         divRef_cgral_desp_tipo_container_Internalname = "REF_CGRAL_DESP_TIPO_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl40_Internalname = "LBL40";
         lbllbl40_Internalname = "LBL40";
         edtREF_CGRAL_DESP_ID_TON_TARIF_Internalname = "REF_CGRAL_DESP_ID_TON_TARIF";
         edtREF_CGRAL_DESP_ID_TON_TARIF_Internalname = "REF_CGRAL_DESP_ID_TON_TARIF";
         div_Internalname = "";
         div_Internalname = "";
         divRef_cgral_desp_id_ton_tarif_container_Internalname = "REF_CGRAL_DESP_ID_TON_TARIF_CONTAINER";
         divRef_cgral_desp_id_ton_tarif_container_Internalname = "REF_CGRAL_DESP_ID_TON_TARIF_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl46_Internalname = "LBL46";
         lbllbl46_Internalname = "LBL46";
         edtREF_CGRAL_DESP_TON_TARIF_Internalname = "REF_CGRAL_DESP_TON_TARIF";
         edtREF_CGRAL_DESP_TON_TARIF_Internalname = "REF_CGRAL_DESP_TON_TARIF";
         div_Internalname = "";
         div_Internalname = "";
         divRef_cgral_desp_ton_tarif_container_Internalname = "REF_CGRAL_DESP_TON_TARIF_CONTAINER";
         divRef_cgral_desp_ton_tarif_container_Internalname = "REF_CGRAL_DESP_TON_TARIF_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl52_Internalname = "LBL52";
         lbllbl52_Internalname = "LBL52";
         edtREF_CGRAL_DESP_TARIFA_Internalname = "REF_CGRAL_DESP_TARIFA";
         edtREF_CGRAL_DESP_TARIFA_Internalname = "REF_CGRAL_DESP_TARIFA";
         div_Internalname = "";
         div_Internalname = "";
         divRef_cgral_desp_tarifa_container_Internalname = "REF_CGRAL_DESP_TARIFA_CONTAINER";
         divRef_cgral_desp_tarifa_container_Internalname = "REF_CGRAL_DESP_TARIFA_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl58_Internalname = "LBL58";
         lbllbl58_Internalname = "LBL58";
         edtREF_CGRAL_DESP_COMENTARIO_Internalname = "REF_CGRAL_DESP_COMENTARIO";
         edtREF_CGRAL_DESP_COMENTARIO_Internalname = "REF_CGRAL_DESP_COMENTARIO";
         div_Internalname = "";
         div_Internalname = "";
         divRef_cgral_desp_comentario_container_Internalname = "REF_CGRAL_DESP_COMENTARIO_CONTAINER";
         divRef_cgral_desp_comentario_container_Internalname = "REF_CGRAL_DESP_COMENTARIO_CONTAINER";
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
         Form.Caption = context.GetMessage( "Buques refrigerados, carga general, otros y desplazamiento", "");
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtREF_CGRAL_DESP_COMENTARIO_Enabled = 1;
         edtREF_CGRAL_DESP_TARIFA_Jsonclick = "";
         edtREF_CGRAL_DESP_TARIFA_Enabled = 1;
         edtREF_CGRAL_DESP_TON_TARIF_Jsonclick = "";
         edtREF_CGRAL_DESP_TON_TARIF_Enabled = 1;
         edtREF_CGRAL_DESP_ID_TON_TARIF_Jsonclick = "";
         edtREF_CGRAL_DESP_ID_TON_TARIF_Enabled = 1;
         cmbREF_CGRAL_DESP_TIPO_Jsonclick = "";
         cmbREF_CGRAL_DESP_TIPO.Enabled = 1;
         cmbREF_CGRAL_DESP_CARGA_Jsonclick = "";
         cmbREF_CGRAL_DESP_CARGA.Enabled = 1;
         edtREF_CGRAL_DESP_ID_Jsonclick = "";
         edtREF_CGRAL_DESP_ID_Enabled = 1;
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
         GX_FocusControl = cmbREF_CGRAL_DESP_CARGA_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Ref_cgral_desp_id( short GX_Parm1 ,
                                           GXCombobox cmbGX_Parm2 ,
                                           GXCombobox cmbGX_Parm3 ,
                                           short GX_Parm4 ,
                                           long GX_Parm5 ,
                                           decimal GX_Parm6 ,
                                           String GX_Parm7 )
      {
         A49REF_CGRAL_DESP_ID = GX_Parm1;
         cmbREF_CGRAL_DESP_CARGA = cmbGX_Parm2;
         A44REF_CGRAL_DESP_CARGA = cmbREF_CGRAL_DESP_CARGA.CurrentValue;
         cmbREF_CGRAL_DESP_CARGA.CurrentValue = A44REF_CGRAL_DESP_CARGA;
         cmbREF_CGRAL_DESP_TIPO = cmbGX_Parm3;
         A45REF_CGRAL_DESP_TIPO = cmbREF_CGRAL_DESP_TIPO.CurrentValue;
         n45REF_CGRAL_DESP_TIPO = false;
         cmbREF_CGRAL_DESP_TIPO.CurrentValue = A45REF_CGRAL_DESP_TIPO;
         A48REF_CGRAL_DESP_ID_TON_TARIF = GX_Parm4;
         A46REF_CGRAL_DESP_TON_TARIF = GX_Parm5;
         n46REF_CGRAL_DESP_TON_TARIF = false;
         A47REF_CGRAL_DESP_TARIFA = GX_Parm6;
         A50REF_CGRAL_DESP_COMENTARIO = GX_Parm7;
         n50REF_CGRAL_DESP_COMENTARIO = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         cmbREF_CGRAL_DESP_CARGA.CurrentValue = A44REF_CGRAL_DESP_CARGA;
         isValidOutput.Add(cmbREF_CGRAL_DESP_CARGA);
         cmbREF_CGRAL_DESP_TIPO.CurrentValue = A45REF_CGRAL_DESP_TIPO;
         isValidOutput.Add(cmbREF_CGRAL_DESP_TIPO);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A48REF_CGRAL_DESP_ID_TON_TARIF), 4, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A46REF_CGRAL_DESP_TON_TARIF), 10, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A47REF_CGRAL_DESP_TARIFA, 10, 2, ".", "")));
         isValidOutput.Add(StringUtil.RTrim( A50REF_CGRAL_DESP_COMENTARIO));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z49REF_CGRAL_DESP_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         isValidOutput.Add(StringUtil.RTrim( Z44REF_CGRAL_DESP_CARGA));
         isValidOutput.Add(StringUtil.RTrim( Z45REF_CGRAL_DESP_TIPO));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z48REF_CGRAL_DESP_ID_TON_TARIF), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z46REF_CGRAL_DESP_TON_TARIF), 10, 0, context.GetLanguageProperty( "decimal_point"), "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( Z47REF_CGRAL_DESP_TARIFA, 10, 2, context.GetLanguageProperty( "decimal_point"), "")));
         isValidOutput.Add(StringUtil.RTrim( Z50REF_CGRAL_DESP_COMENTARIO));
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
         Z44REF_CGRAL_DESP_CARGA = "";
         Z45REF_CGRAL_DESP_TIPO = "";
         Z50REF_CGRAL_DESP_COMENTARIO = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         A44REF_CGRAL_DESP_CARGA = "";
         A45REF_CGRAL_DESP_TIPO = "";
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
         A50REF_CGRAL_DESP_COMENTARIO = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T00074_A49REF_CGRAL_DESP_ID = new short[1] ;
         T00074_A44REF_CGRAL_DESP_CARGA = new String[] {""} ;
         T00074_A45REF_CGRAL_DESP_TIPO = new String[] {""} ;
         T00074_n45REF_CGRAL_DESP_TIPO = new bool[] {false} ;
         T00074_A48REF_CGRAL_DESP_ID_TON_TARIF = new short[1] ;
         T00074_A46REF_CGRAL_DESP_TON_TARIF = new long[1] ;
         T00074_n46REF_CGRAL_DESP_TON_TARIF = new bool[] {false} ;
         T00074_A47REF_CGRAL_DESP_TARIFA = new decimal[1] ;
         T00074_A50REF_CGRAL_DESP_COMENTARIO = new String[] {""} ;
         T00074_n50REF_CGRAL_DESP_COMENTARIO = new bool[] {false} ;
         T00075_A49REF_CGRAL_DESP_ID = new short[1] ;
         T00073_A49REF_CGRAL_DESP_ID = new short[1] ;
         T00073_A44REF_CGRAL_DESP_CARGA = new String[] {""} ;
         T00073_A45REF_CGRAL_DESP_TIPO = new String[] {""} ;
         T00073_n45REF_CGRAL_DESP_TIPO = new bool[] {false} ;
         T00073_A48REF_CGRAL_DESP_ID_TON_TARIF = new short[1] ;
         T00073_A46REF_CGRAL_DESP_TON_TARIF = new long[1] ;
         T00073_n46REF_CGRAL_DESP_TON_TARIF = new bool[] {false} ;
         T00073_A47REF_CGRAL_DESP_TARIFA = new decimal[1] ;
         T00073_A50REF_CGRAL_DESP_COMENTARIO = new String[] {""} ;
         T00073_n50REF_CGRAL_DESP_COMENTARIO = new bool[] {false} ;
         sMode9 = "";
         T00076_A49REF_CGRAL_DESP_ID = new short[1] ;
         T00077_A49REF_CGRAL_DESP_ID = new short[1] ;
         T00078_A49REF_CGRAL_DESP_ID = new short[1] ;
         T00078_A44REF_CGRAL_DESP_CARGA = new String[] {""} ;
         T00078_A45REF_CGRAL_DESP_TIPO = new String[] {""} ;
         T00078_n45REF_CGRAL_DESP_TIPO = new bool[] {false} ;
         T00078_A48REF_CGRAL_DESP_ID_TON_TARIF = new short[1] ;
         T00078_A46REF_CGRAL_DESP_TON_TARIF = new long[1] ;
         T00078_n46REF_CGRAL_DESP_TON_TARIF = new bool[] {false} ;
         T00078_A47REF_CGRAL_DESP_TARIFA = new decimal[1] ;
         T00078_A50REF_CGRAL_DESP_COMENTARIO = new String[] {""} ;
         T00078_n50REF_CGRAL_DESP_COMENTARIO = new bool[] {false} ;
         T000710_A49REF_CGRAL_DESP_ID = new short[1] ;
         T000713_A49REF_CGRAL_DESP_ID = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ref_cgral_desp__default(),
            new Object[][] {
                new Object[] {
               T00072_A49REF_CGRAL_DESP_ID, T00072_A44REF_CGRAL_DESP_CARGA, T00072_A45REF_CGRAL_DESP_TIPO, T00072_n45REF_CGRAL_DESP_TIPO, T00072_A48REF_CGRAL_DESP_ID_TON_TARIF, T00072_A46REF_CGRAL_DESP_TON_TARIF, T00072_n46REF_CGRAL_DESP_TON_TARIF, T00072_A47REF_CGRAL_DESP_TARIFA, T00072_A50REF_CGRAL_DESP_COMENTARIO, T00072_n50REF_CGRAL_DESP_COMENTARIO
               }
               , new Object[] {
               T00073_A49REF_CGRAL_DESP_ID, T00073_A44REF_CGRAL_DESP_CARGA, T00073_A45REF_CGRAL_DESP_TIPO, T00073_n45REF_CGRAL_DESP_TIPO, T00073_A48REF_CGRAL_DESP_ID_TON_TARIF, T00073_A46REF_CGRAL_DESP_TON_TARIF, T00073_n46REF_CGRAL_DESP_TON_TARIF, T00073_A47REF_CGRAL_DESP_TARIFA, T00073_A50REF_CGRAL_DESP_COMENTARIO, T00073_n50REF_CGRAL_DESP_COMENTARIO
               }
               , new Object[] {
               T00074_A49REF_CGRAL_DESP_ID, T00074_A44REF_CGRAL_DESP_CARGA, T00074_A45REF_CGRAL_DESP_TIPO, T00074_n45REF_CGRAL_DESP_TIPO, T00074_A48REF_CGRAL_DESP_ID_TON_TARIF, T00074_A46REF_CGRAL_DESP_TON_TARIF, T00074_n46REF_CGRAL_DESP_TON_TARIF, T00074_A47REF_CGRAL_DESP_TARIFA, T00074_A50REF_CGRAL_DESP_COMENTARIO, T00074_n50REF_CGRAL_DESP_COMENTARIO
               }
               , new Object[] {
               T00075_A49REF_CGRAL_DESP_ID
               }
               , new Object[] {
               T00076_A49REF_CGRAL_DESP_ID
               }
               , new Object[] {
               T00077_A49REF_CGRAL_DESP_ID
               }
               , new Object[] {
               T00078_A49REF_CGRAL_DESP_ID, T00078_A44REF_CGRAL_DESP_CARGA, T00078_A45REF_CGRAL_DESP_TIPO, T00078_n45REF_CGRAL_DESP_TIPO, T00078_A48REF_CGRAL_DESP_ID_TON_TARIF, T00078_A46REF_CGRAL_DESP_TON_TARIF, T00078_n46REF_CGRAL_DESP_TON_TARIF, T00078_A47REF_CGRAL_DESP_TARIFA, T00078_A50REF_CGRAL_DESP_COMENTARIO, T00078_n50REF_CGRAL_DESP_COMENTARIO
               }
               , new Object[] {
               }
               , new Object[] {
               T000710_A49REF_CGRAL_DESP_ID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000713_A49REF_CGRAL_DESP_ID
               }
            }
         );
      }

      private short Z49REF_CGRAL_DESP_ID ;
      private short Z48REF_CGRAL_DESP_ID_TON_TARIF ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A49REF_CGRAL_DESP_ID ;
      private short A48REF_CGRAL_DESP_ID_TON_TARIF ;
      private short GX_JID ;
      private short RcdFound9 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtREF_CGRAL_DESP_ID_Enabled ;
      private int edtREF_CGRAL_DESP_ID_TON_TARIF_Enabled ;
      private int edtREF_CGRAL_DESP_TON_TARIF_Enabled ;
      private int edtREF_CGRAL_DESP_TARIFA_Enabled ;
      private int edtREF_CGRAL_DESP_COMENTARIO_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z46REF_CGRAL_DESP_TON_TARIF ;
      private long A46REF_CGRAL_DESP_TON_TARIF ;
      private decimal Z47REF_CGRAL_DESP_TARIFA ;
      private decimal A47REF_CGRAL_DESP_TARIFA ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtREF_CGRAL_DESP_ID_Internalname ;
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
      private String divRef_cgral_desp_id_container_Internalname ;
      private String lbllbl22_Internalname ;
      private String lbllbl22_Jsonclick ;
      private String edtREF_CGRAL_DESP_ID_Jsonclick ;
      private String divRef_cgral_desp_carga_container_Internalname ;
      private String lbllbl28_Internalname ;
      private String lbllbl28_Jsonclick ;
      private String cmbREF_CGRAL_DESP_CARGA_Internalname ;
      private String cmbREF_CGRAL_DESP_CARGA_Jsonclick ;
      private String divRef_cgral_desp_tipo_container_Internalname ;
      private String lbllbl34_Internalname ;
      private String lbllbl34_Jsonclick ;
      private String cmbREF_CGRAL_DESP_TIPO_Internalname ;
      private String cmbREF_CGRAL_DESP_TIPO_Jsonclick ;
      private String divRef_cgral_desp_id_ton_tarif_container_Internalname ;
      private String lbllbl40_Internalname ;
      private String lbllbl40_Jsonclick ;
      private String edtREF_CGRAL_DESP_ID_TON_TARIF_Internalname ;
      private String edtREF_CGRAL_DESP_ID_TON_TARIF_Jsonclick ;
      private String divRef_cgral_desp_ton_tarif_container_Internalname ;
      private String lbllbl46_Internalname ;
      private String lbllbl46_Jsonclick ;
      private String edtREF_CGRAL_DESP_TON_TARIF_Internalname ;
      private String edtREF_CGRAL_DESP_TON_TARIF_Jsonclick ;
      private String divRef_cgral_desp_tarifa_container_Internalname ;
      private String lbllbl52_Internalname ;
      private String lbllbl52_Jsonclick ;
      private String edtREF_CGRAL_DESP_TARIFA_Internalname ;
      private String edtREF_CGRAL_DESP_TARIFA_Jsonclick ;
      private String divRef_cgral_desp_comentario_container_Internalname ;
      private String lbllbl58_Internalname ;
      private String lbllbl58_Jsonclick ;
      private String edtREF_CGRAL_DESP_COMENTARIO_Internalname ;
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
      private String sMode9 ;
      private String sDynURL ;
      private String FormProcess ;
      private String div_Internalname ;
      private bool entryPointCalled ;
      private bool n45REF_CGRAL_DESP_TIPO ;
      private bool wbErr ;
      private bool n46REF_CGRAL_DESP_TON_TARIF ;
      private bool n50REF_CGRAL_DESP_COMENTARIO ;
      private bool Gx_longc ;
      private bool toggleJsOutput ;
      private String Z44REF_CGRAL_DESP_CARGA ;
      private String Z45REF_CGRAL_DESP_TIPO ;
      private String Z50REF_CGRAL_DESP_COMENTARIO ;
      private String A44REF_CGRAL_DESP_CARGA ;
      private String A45REF_CGRAL_DESP_TIPO ;
      private String A50REF_CGRAL_DESP_COMENTARIO ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbREF_CGRAL_DESP_CARGA ;
      private GXCombobox cmbREF_CGRAL_DESP_TIPO ;
      private IDataStoreProvider pr_default ;
      private short[] T00074_A49REF_CGRAL_DESP_ID ;
      private String[] T00074_A44REF_CGRAL_DESP_CARGA ;
      private String[] T00074_A45REF_CGRAL_DESP_TIPO ;
      private bool[] T00074_n45REF_CGRAL_DESP_TIPO ;
      private short[] T00074_A48REF_CGRAL_DESP_ID_TON_TARIF ;
      private long[] T00074_A46REF_CGRAL_DESP_TON_TARIF ;
      private bool[] T00074_n46REF_CGRAL_DESP_TON_TARIF ;
      private decimal[] T00074_A47REF_CGRAL_DESP_TARIFA ;
      private String[] T00074_A50REF_CGRAL_DESP_COMENTARIO ;
      private bool[] T00074_n50REF_CGRAL_DESP_COMENTARIO ;
      private short[] T00075_A49REF_CGRAL_DESP_ID ;
      private short[] T00073_A49REF_CGRAL_DESP_ID ;
      private String[] T00073_A44REF_CGRAL_DESP_CARGA ;
      private String[] T00073_A45REF_CGRAL_DESP_TIPO ;
      private bool[] T00073_n45REF_CGRAL_DESP_TIPO ;
      private short[] T00073_A48REF_CGRAL_DESP_ID_TON_TARIF ;
      private long[] T00073_A46REF_CGRAL_DESP_TON_TARIF ;
      private bool[] T00073_n46REF_CGRAL_DESP_TON_TARIF ;
      private decimal[] T00073_A47REF_CGRAL_DESP_TARIFA ;
      private String[] T00073_A50REF_CGRAL_DESP_COMENTARIO ;
      private bool[] T00073_n50REF_CGRAL_DESP_COMENTARIO ;
      private short[] T00076_A49REF_CGRAL_DESP_ID ;
      private short[] T00077_A49REF_CGRAL_DESP_ID ;
      private short[] T00078_A49REF_CGRAL_DESP_ID ;
      private String[] T00078_A44REF_CGRAL_DESP_CARGA ;
      private String[] T00078_A45REF_CGRAL_DESP_TIPO ;
      private bool[] T00078_n45REF_CGRAL_DESP_TIPO ;
      private short[] T00078_A48REF_CGRAL_DESP_ID_TON_TARIF ;
      private long[] T00078_A46REF_CGRAL_DESP_TON_TARIF ;
      private bool[] T00078_n46REF_CGRAL_DESP_TON_TARIF ;
      private decimal[] T00078_A47REF_CGRAL_DESP_TARIFA ;
      private String[] T00078_A50REF_CGRAL_DESP_COMENTARIO ;
      private bool[] T00078_n50REF_CGRAL_DESP_COMENTARIO ;
      private short[] T000710_A49REF_CGRAL_DESP_ID ;
      private short[] T000713_A49REF_CGRAL_DESP_ID ;
      private short[] T00072_A49REF_CGRAL_DESP_ID ;
      private String[] T00072_A44REF_CGRAL_DESP_CARGA ;
      private String[] T00072_A45REF_CGRAL_DESP_TIPO ;
      private short[] T00072_A48REF_CGRAL_DESP_ID_TON_TARIF ;
      private long[] T00072_A46REF_CGRAL_DESP_TON_TARIF ;
      private decimal[] T00072_A47REF_CGRAL_DESP_TARIFA ;
      private String[] T00072_A50REF_CGRAL_DESP_COMENTARIO ;
      private bool[] T00072_n45REF_CGRAL_DESP_TIPO ;
      private bool[] T00072_n46REF_CGRAL_DESP_TON_TARIF ;
      private bool[] T00072_n50REF_CGRAL_DESP_COMENTARIO ;
      private GXWebForm Form ;
   }

   public class ref_cgral_desp__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT00072 ;
          prmT00072 = new Object[] {
          new Object[] {"@REF_CGRAL_DESP_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00074 ;
          prmT00074 = new Object[] {
          new Object[] {"@REF_CGRAL_DESP_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00075 ;
          prmT00075 = new Object[] {
          new Object[] {"@REF_CGRAL_DESP_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00073 ;
          prmT00073 = new Object[] {
          new Object[] {"@REF_CGRAL_DESP_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00076 ;
          prmT00076 = new Object[] {
          new Object[] {"@REF_CGRAL_DESP_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00077 ;
          prmT00077 = new Object[] {
          new Object[] {"@REF_CGRAL_DESP_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00078 ;
          prmT00078 = new Object[] {
          new Object[] {"@REF_CGRAL_DESP_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00079 ;
          prmT00079 = new Object[] {
          new Object[] {"@REF_CGRAL_DESP_CARGA",SqlDbType.VarChar,150,0} ,
          new Object[] {"@REF_CGRAL_DESP_TIPO",SqlDbType.VarChar,50,0} ,
          new Object[] {"@REF_CGRAL_DESP_ID_TON_TARIF",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@REF_CGRAL_DESP_TON_TARIF",SqlDbType.Decimal,10,0} ,
          new Object[] {"@REF_CGRAL_DESP_TARIFA",SqlDbType.Decimal,10,2} ,
          new Object[] {"@REF_CGRAL_DESP_COMENTARIO",SqlDbType.VarChar,250,0}
          } ;
          Object[] prmT000710 ;
          prmT000710 = new Object[] {
          } ;
          Object[] prmT000711 ;
          prmT000711 = new Object[] {
          new Object[] {"@REF_CGRAL_DESP_CARGA",SqlDbType.VarChar,150,0} ,
          new Object[] {"@REF_CGRAL_DESP_TIPO",SqlDbType.VarChar,50,0} ,
          new Object[] {"@REF_CGRAL_DESP_ID_TON_TARIF",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@REF_CGRAL_DESP_TON_TARIF",SqlDbType.Decimal,10,0} ,
          new Object[] {"@REF_CGRAL_DESP_TARIFA",SqlDbType.Decimal,10,2} ,
          new Object[] {"@REF_CGRAL_DESP_COMENTARIO",SqlDbType.VarChar,250,0} ,
          new Object[] {"@REF_CGRAL_DESP_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000712 ;
          prmT000712 = new Object[] {
          new Object[] {"@REF_CGRAL_DESP_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000713 ;
          prmT000713 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00072", "SELECT [REF_CGRAL_DESP_ID], [REF_CGRAL_DESP_CARGA], [REF_CGRAL_DESP_TIPO], [REF_CGRAL_DESP_ID_TON_TARIF], [REF_CGRAL_DESP_TON_TARIF], [REF_CGRAL_DESP_TARIFA], [REF_CGRAL_DESP_COMENTARIO] FROM [REF_CGRAL_DESP] WITH (UPDLOCK) WHERE [REF_CGRAL_DESP_ID] = @REF_CGRAL_DESP_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00072,1,0,true,false )
             ,new CursorDef("T00073", "SELECT [REF_CGRAL_DESP_ID], [REF_CGRAL_DESP_CARGA], [REF_CGRAL_DESP_TIPO], [REF_CGRAL_DESP_ID_TON_TARIF], [REF_CGRAL_DESP_TON_TARIF], [REF_CGRAL_DESP_TARIFA], [REF_CGRAL_DESP_COMENTARIO] FROM [REF_CGRAL_DESP] WITH (NOLOCK) WHERE [REF_CGRAL_DESP_ID] = @REF_CGRAL_DESP_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00073,1,0,true,false )
             ,new CursorDef("T00074", "SELECT TM1.[REF_CGRAL_DESP_ID], TM1.[REF_CGRAL_DESP_CARGA], TM1.[REF_CGRAL_DESP_TIPO], TM1.[REF_CGRAL_DESP_ID_TON_TARIF], TM1.[REF_CGRAL_DESP_TON_TARIF], TM1.[REF_CGRAL_DESP_TARIFA], TM1.[REF_CGRAL_DESP_COMENTARIO] FROM [REF_CGRAL_DESP] TM1 WITH (NOLOCK) WHERE TM1.[REF_CGRAL_DESP_ID] = @REF_CGRAL_DESP_ID ORDER BY TM1.[REF_CGRAL_DESP_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00074,100,0,true,false )
             ,new CursorDef("T00075", "SELECT [REF_CGRAL_DESP_ID] FROM [REF_CGRAL_DESP] WITH (NOLOCK) WHERE [REF_CGRAL_DESP_ID] = @REF_CGRAL_DESP_ID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00075,1,0,true,false )
             ,new CursorDef("T00076", "SELECT TOP 1 [REF_CGRAL_DESP_ID] FROM [REF_CGRAL_DESP] WITH (NOLOCK) WHERE ( [REF_CGRAL_DESP_ID] > @REF_CGRAL_DESP_ID) ORDER BY [REF_CGRAL_DESP_ID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00076,1,0,true,true )
             ,new CursorDef("T00077", "SELECT TOP 1 [REF_CGRAL_DESP_ID] FROM [REF_CGRAL_DESP] WITH (NOLOCK) WHERE ( [REF_CGRAL_DESP_ID] < @REF_CGRAL_DESP_ID) ORDER BY [REF_CGRAL_DESP_ID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00077,1,0,true,true )
             ,new CursorDef("T00078", "SELECT [REF_CGRAL_DESP_ID], [REF_CGRAL_DESP_CARGA], [REF_CGRAL_DESP_TIPO], [REF_CGRAL_DESP_ID_TON_TARIF], [REF_CGRAL_DESP_TON_TARIF], [REF_CGRAL_DESP_TARIFA], [REF_CGRAL_DESP_COMENTARIO] FROM [REF_CGRAL_DESP] WITH (UPDLOCK) WHERE [REF_CGRAL_DESP_ID] = @REF_CGRAL_DESP_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00078,1,0,true,false )
             ,new CursorDef("T00079", "INSERT INTO [REF_CGRAL_DESP]([REF_CGRAL_DESP_CARGA], [REF_CGRAL_DESP_TIPO], [REF_CGRAL_DESP_ID_TON_TARIF], [REF_CGRAL_DESP_TON_TARIF], [REF_CGRAL_DESP_TARIFA], [REF_CGRAL_DESP_COMENTARIO]) VALUES(@REF_CGRAL_DESP_CARGA, @REF_CGRAL_DESP_TIPO, @REF_CGRAL_DESP_ID_TON_TARIF, @REF_CGRAL_DESP_TON_TARIF, @REF_CGRAL_DESP_TARIFA, @REF_CGRAL_DESP_COMENTARIO)", GxErrorMask.GX_NOMASK,prmT00079)
             ,new CursorDef("T000710", "SELECT Ident_Current('[REF_CGRAL_DESP]') ",true, GxErrorMask.GX_NOMASK, false, this,prmT000710,1,0,true,false )
             ,new CursorDef("T000711", "UPDATE [REF_CGRAL_DESP] SET [REF_CGRAL_DESP_CARGA]=@REF_CGRAL_DESP_CARGA, [REF_CGRAL_DESP_TIPO]=@REF_CGRAL_DESP_TIPO, [REF_CGRAL_DESP_ID_TON_TARIF]=@REF_CGRAL_DESP_ID_TON_TARIF, [REF_CGRAL_DESP_TON_TARIF]=@REF_CGRAL_DESP_TON_TARIF, [REF_CGRAL_DESP_TARIFA]=@REF_CGRAL_DESP_TARIFA, [REF_CGRAL_DESP_COMENTARIO]=@REF_CGRAL_DESP_COMENTARIO  WHERE [REF_CGRAL_DESP_ID] = @REF_CGRAL_DESP_ID", GxErrorMask.GX_NOMASK,prmT000711)
             ,new CursorDef("T000712", "DELETE FROM [REF_CGRAL_DESP]  WHERE [REF_CGRAL_DESP_ID] = @REF_CGRAL_DESP_ID", GxErrorMask.GX_NOMASK,prmT000712)
             ,new CursorDef("T000713", "SELECT [REF_CGRAL_DESP_ID] FROM [REF_CGRAL_DESP] WITH (NOLOCK) ORDER BY [REF_CGRAL_DESP_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000713,100,0,true,false )
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
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((long[]) buf[5])[0] = rslt.getLong(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(6) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(7);
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((long[]) buf[5])[0] = rslt.getLong(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(6) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(7);
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((long[]) buf[5])[0] = rslt.getLong(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(6) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(7);
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
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((long[]) buf[5])[0] = rslt.getLong(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(6) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(7);
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
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                stmt.SetParameter(3, (short)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(4, (long)parms[5]);
                }
                stmt.SetParameter(5, (decimal)parms[6]);
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 6 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[8]);
                }
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                stmt.SetParameter(3, (short)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(4, (long)parms[5]);
                }
                stmt.SetParameter(5, (decimal)parms[6]);
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 6 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[8]);
                }
                stmt.SetParameter(7, (short)parms[9]);
                break;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
