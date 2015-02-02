/*
               File: VEH_RORO
        Description: Portavehiculos y RO-RO
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 9:38:47.55
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
   public class veh_roro : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_2-86442", 0) ;
            Form.Meta.addItem("description", context.GetMessage( "Portavehiculos y RO-RO", ""), 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtVEH_RORO_ID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Flat");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public veh_roro( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public veh_roro( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, context.GetMessage( "Portavehiculos y RO-RO", ""), "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_VEH_RORO.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", context.GetMessage( "GX_BtnFirst", ""), bttBtn_first_Jsonclick, 5, context.GetMessage( "GX_BtnFirst", ""), "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_VEH_RORO.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", context.GetMessage( "GX_BtnPrevious", ""), bttBtn_previous_Jsonclick, 5, context.GetMessage( "GX_BtnPrevious", ""), "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_VEH_RORO.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", context.GetMessage( "GX_BtnNext", ""), bttBtn_next_Jsonclick, 5, context.GetMessage( "GX_BtnNext", ""), "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_VEH_RORO.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", context.GetMessage( "GX_BtnLast", ""), bttBtn_last_Jsonclick, 5, context.GetMessage( "GX_BtnLast", ""), "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_VEH_RORO.htm");
            context.WriteHtmlText( "</div>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", context.GetMessage( "GX_BtnSelect", ""), bttBtn_select_Jsonclick, 4, context.GetMessage( "GX_BtnSelect", ""), "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "gx.popup.openPrompt('"+"gx0080.aspx"+"',["+"{Ctrl:gx.dom.el('"+"VEH_RORO_ID"+"'), id:'"+"VEH_RORO_ID"+"'"+",IOType:'out',isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", 2, "HLP_VEH_RORO.htm");
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
            GxWebStd.gx_div_start( context, divVeh_roro_id_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl22_Internalname, context.GetMessage( "ID", ""), "", "", lbllbl22_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_VEH_RORO.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtVEH_RORO_ID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A38VEH_RORO_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtVEH_RORO_ID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A38VEH_RORO_ID), "ZZZ9")) : context.localUtil.Format( (decimal)(A38VEH_RORO_ID), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(24);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVEH_RORO_ID_Jsonclick, 0, "Attribute", "", "", "", 1, edtVEH_RORO_ID_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_VEH_RORO.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divVeh_roro_ton_ini_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl28_Internalname, context.GetMessage( "Rango Inicial TON", ""), "", "", lbllbl28_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_VEH_RORO.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtVEH_RORO_TON_INI_Internalname, StringUtil.LTrim( StringUtil.NToC( A39VEH_RORO_TON_INI, 10, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtVEH_RORO_TON_INI_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A39VEH_RORO_TON_INI, "ZZZZZZ9.99")) : context.localUtil.Format( A39VEH_RORO_TON_INI, "ZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVEH_RORO_TON_INI_Jsonclick, 0, "Attribute", "", "", "", 1, edtVEH_RORO_TON_INI_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_VEH_RORO.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divVeh_roro_ton_fin_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl34_Internalname, context.GetMessage( "Rango Final TON", ""), "", "", lbllbl34_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_VEH_RORO.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtVEH_RORO_TON_FIN_Internalname, StringUtil.LTrim( StringUtil.NToC( A40VEH_RORO_TON_FIN, 10, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtVEH_RORO_TON_FIN_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A40VEH_RORO_TON_FIN, "ZZZZZZ9.99")) : context.localUtil.Format( A40VEH_RORO_TON_FIN, "ZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVEH_RORO_TON_FIN_Jsonclick, 0, "Attribute", "", "", "", 1, edtVEH_RORO_TON_FIN_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_VEH_RORO.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divVeh_roro_util_ini_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl40_Internalname, context.GetMessage( "Porcentaje Inicial Utilizacion", ""), "", "", lbllbl40_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_VEH_RORO.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtVEH_RORO_UTIL_INI_Internalname, StringUtil.LTrim( StringUtil.NToC( A41VEH_RORO_UTIL_INI, 10, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtVEH_RORO_UTIL_INI_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A41VEH_RORO_UTIL_INI, "ZZZZZZ9.99")) : context.localUtil.Format( A41VEH_RORO_UTIL_INI, "ZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(42);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVEH_RORO_UTIL_INI_Jsonclick, 0, "Attribute", "", "", "", 1, edtVEH_RORO_UTIL_INI_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_VEH_RORO.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divVeh_roro_util_fin_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl46_Internalname, context.GetMessage( "Porcentaje Inicial Utilizacion", ""), "", "", lbllbl46_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_VEH_RORO.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtVEH_RORO_UTIL_FIN_Internalname, StringUtil.LTrim( StringUtil.NToC( A42VEH_RORO_UTIL_FIN, 10, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtVEH_RORO_UTIL_FIN_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A42VEH_RORO_UTIL_FIN, "ZZZZZZ9.99")) : context.localUtil.Format( A42VEH_RORO_UTIL_FIN, "ZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVEH_RORO_UTIL_FIN_Jsonclick, 0, "Attribute", "", "", "", 1, edtVEH_RORO_UTIL_FIN_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_VEH_RORO.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divVeh_roro_tarifa_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl52_Internalname, context.GetMessage( "Tarifa", ""), "", "", lbllbl52_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_VEH_RORO.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtVEH_RORO_TARIFA_Internalname, StringUtil.LTrim( StringUtil.NToC( A43VEH_RORO_TARIFA, 10, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtVEH_RORO_TARIFA_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A43VEH_RORO_TARIFA, "ZZZZZZ9.99")) : context.localUtil.Format( A43VEH_RORO_TARIFA, "ZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtVEH_RORO_TARIFA_Jsonclick, 0, "Attribute", "", "", "", 1, edtVEH_RORO_TARIFA_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_VEH_RORO.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", context.GetMessage( "GX_BtnEnter", ""), bttBtn_enter_Jsonclick, 5, context.GetMessage( "GX_BtnEnter", ""), "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_VEH_RORO.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", context.GetMessage( "GX_BtnCancel", ""), bttBtn_cancel_Jsonclick, 1, context.GetMessage( "GX_BtnCancel", ""), "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_VEH_RORO.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", context.GetMessage( "GX_BtnDelete", ""), bttBtn_delete_Jsonclick, 5, context.GetMessage( "GX_BtnDelete", ""), "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_VEH_RORO.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtVEH_RORO_ID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtVEH_RORO_ID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "VEH_RORO_ID");
                  AnyError = 1;
                  GX_FocusControl = edtVEH_RORO_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A38VEH_RORO_ID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38VEH_RORO_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A38VEH_RORO_ID), 4, 0)));
               }
               else
               {
                  A38VEH_RORO_ID = (short)(context.localUtil.CToN( cgiGet( edtVEH_RORO_ID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38VEH_RORO_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A38VEH_RORO_ID), 4, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtVEH_RORO_TON_INI_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtVEH_RORO_TON_INI_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 9999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "VEH_RORO_TON_INI");
                  AnyError = 1;
                  GX_FocusControl = edtVEH_RORO_TON_INI_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A39VEH_RORO_TON_INI = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39VEH_RORO_TON_INI", StringUtil.LTrim( StringUtil.Str( A39VEH_RORO_TON_INI, 10, 2)));
               }
               else
               {
                  A39VEH_RORO_TON_INI = context.localUtil.CToN( cgiGet( edtVEH_RORO_TON_INI_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39VEH_RORO_TON_INI", StringUtil.LTrim( StringUtil.Str( A39VEH_RORO_TON_INI, 10, 2)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtVEH_RORO_TON_FIN_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtVEH_RORO_TON_FIN_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 9999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "VEH_RORO_TON_FIN");
                  AnyError = 1;
                  GX_FocusControl = edtVEH_RORO_TON_FIN_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A40VEH_RORO_TON_FIN = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40VEH_RORO_TON_FIN", StringUtil.LTrim( StringUtil.Str( A40VEH_RORO_TON_FIN, 10, 2)));
               }
               else
               {
                  A40VEH_RORO_TON_FIN = context.localUtil.CToN( cgiGet( edtVEH_RORO_TON_FIN_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40VEH_RORO_TON_FIN", StringUtil.LTrim( StringUtil.Str( A40VEH_RORO_TON_FIN, 10, 2)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtVEH_RORO_UTIL_INI_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtVEH_RORO_UTIL_INI_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 9999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "VEH_RORO_UTIL_INI");
                  AnyError = 1;
                  GX_FocusControl = edtVEH_RORO_UTIL_INI_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A41VEH_RORO_UTIL_INI = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41VEH_RORO_UTIL_INI", StringUtil.LTrim( StringUtil.Str( A41VEH_RORO_UTIL_INI, 10, 2)));
               }
               else
               {
                  A41VEH_RORO_UTIL_INI = context.localUtil.CToN( cgiGet( edtVEH_RORO_UTIL_INI_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41VEH_RORO_UTIL_INI", StringUtil.LTrim( StringUtil.Str( A41VEH_RORO_UTIL_INI, 10, 2)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtVEH_RORO_UTIL_FIN_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtVEH_RORO_UTIL_FIN_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 9999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "VEH_RORO_UTIL_FIN");
                  AnyError = 1;
                  GX_FocusControl = edtVEH_RORO_UTIL_FIN_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A42VEH_RORO_UTIL_FIN = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42VEH_RORO_UTIL_FIN", StringUtil.LTrim( StringUtil.Str( A42VEH_RORO_UTIL_FIN, 10, 2)));
               }
               else
               {
                  A42VEH_RORO_UTIL_FIN = context.localUtil.CToN( cgiGet( edtVEH_RORO_UTIL_FIN_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42VEH_RORO_UTIL_FIN", StringUtil.LTrim( StringUtil.Str( A42VEH_RORO_UTIL_FIN, 10, 2)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtVEH_RORO_TARIFA_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtVEH_RORO_TARIFA_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 9999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "VEH_RORO_TARIFA");
                  AnyError = 1;
                  GX_FocusControl = edtVEH_RORO_TARIFA_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A43VEH_RORO_TARIFA = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43VEH_RORO_TARIFA", StringUtil.LTrim( StringUtil.Str( A43VEH_RORO_TARIFA, 10, 2)));
               }
               else
               {
                  A43VEH_RORO_TARIFA = context.localUtil.CToN( cgiGet( edtVEH_RORO_TARIFA_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43VEH_RORO_TARIFA", StringUtil.LTrim( StringUtil.Str( A43VEH_RORO_TARIFA, 10, 2)));
               }
               /* Read saved values. */
               Z38VEH_RORO_ID = (short)(context.localUtil.CToN( cgiGet( "Z38VEH_RORO_ID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               Z39VEH_RORO_TON_INI = context.localUtil.CToN( cgiGet( "Z39VEH_RORO_TON_INI"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               Z40VEH_RORO_TON_FIN = context.localUtil.CToN( cgiGet( "Z40VEH_RORO_TON_FIN"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               Z41VEH_RORO_UTIL_INI = context.localUtil.CToN( cgiGet( "Z41VEH_RORO_UTIL_INI"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               Z42VEH_RORO_UTIL_FIN = context.localUtil.CToN( cgiGet( "Z42VEH_RORO_UTIL_FIN"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               Z43VEH_RORO_TARIFA = context.localUtil.CToN( cgiGet( "Z43VEH_RORO_TARIFA"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
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
                  A38VEH_RORO_ID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38VEH_RORO_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A38VEH_RORO_ID), 4, 0)));
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
               InitAll068( ) ;
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
         DisableAttributes068( ) ;
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

      protected void ResetCaption060( )
      {
      }

      protected void ZM068( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z39VEH_RORO_TON_INI = T00063_A39VEH_RORO_TON_INI[0];
               Z40VEH_RORO_TON_FIN = T00063_A40VEH_RORO_TON_FIN[0];
               Z41VEH_RORO_UTIL_INI = T00063_A41VEH_RORO_UTIL_INI[0];
               Z42VEH_RORO_UTIL_FIN = T00063_A42VEH_RORO_UTIL_FIN[0];
               Z43VEH_RORO_TARIFA = T00063_A43VEH_RORO_TARIFA[0];
            }
            else
            {
               Z39VEH_RORO_TON_INI = A39VEH_RORO_TON_INI;
               Z40VEH_RORO_TON_FIN = A40VEH_RORO_TON_FIN;
               Z41VEH_RORO_UTIL_INI = A41VEH_RORO_UTIL_INI;
               Z42VEH_RORO_UTIL_FIN = A42VEH_RORO_UTIL_FIN;
               Z43VEH_RORO_TARIFA = A43VEH_RORO_TARIFA;
            }
         }
         if ( GX_JID == -1 )
         {
            Z38VEH_RORO_ID = A38VEH_RORO_ID;
            Z39VEH_RORO_TON_INI = A39VEH_RORO_TON_INI;
            Z40VEH_RORO_TON_FIN = A40VEH_RORO_TON_FIN;
            Z41VEH_RORO_UTIL_INI = A41VEH_RORO_UTIL_INI;
            Z42VEH_RORO_UTIL_FIN = A42VEH_RORO_UTIL_FIN;
            Z43VEH_RORO_TARIFA = A43VEH_RORO_TARIFA;
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

      protected void Load068( )
      {
         /* Using cursor T00064 */
         pr_default.execute(2, new Object[] {A38VEH_RORO_ID});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound8 = 1;
            A39VEH_RORO_TON_INI = T00064_A39VEH_RORO_TON_INI[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39VEH_RORO_TON_INI", StringUtil.LTrim( StringUtil.Str( A39VEH_RORO_TON_INI, 10, 2)));
            A40VEH_RORO_TON_FIN = T00064_A40VEH_RORO_TON_FIN[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40VEH_RORO_TON_FIN", StringUtil.LTrim( StringUtil.Str( A40VEH_RORO_TON_FIN, 10, 2)));
            A41VEH_RORO_UTIL_INI = T00064_A41VEH_RORO_UTIL_INI[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41VEH_RORO_UTIL_INI", StringUtil.LTrim( StringUtil.Str( A41VEH_RORO_UTIL_INI, 10, 2)));
            A42VEH_RORO_UTIL_FIN = T00064_A42VEH_RORO_UTIL_FIN[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42VEH_RORO_UTIL_FIN", StringUtil.LTrim( StringUtil.Str( A42VEH_RORO_UTIL_FIN, 10, 2)));
            A43VEH_RORO_TARIFA = T00064_A43VEH_RORO_TARIFA[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43VEH_RORO_TARIFA", StringUtil.LTrim( StringUtil.Str( A43VEH_RORO_TARIFA, 10, 2)));
            ZM068( -1) ;
         }
         pr_default.close(2);
         OnLoadActions068( ) ;
      }

      protected void OnLoadActions068( )
      {
      }

      protected void CheckExtendedTable068( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors068( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey068( )
      {
         /* Using cursor T00065 */
         pr_default.execute(3, new Object[] {A38VEH_RORO_ID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound8 = 1;
         }
         else
         {
            RcdFound8 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00063 */
         pr_default.execute(1, new Object[] {A38VEH_RORO_ID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM068( 1) ;
            RcdFound8 = 1;
            A38VEH_RORO_ID = T00063_A38VEH_RORO_ID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38VEH_RORO_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A38VEH_RORO_ID), 4, 0)));
            A39VEH_RORO_TON_INI = T00063_A39VEH_RORO_TON_INI[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39VEH_RORO_TON_INI", StringUtil.LTrim( StringUtil.Str( A39VEH_RORO_TON_INI, 10, 2)));
            A40VEH_RORO_TON_FIN = T00063_A40VEH_RORO_TON_FIN[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40VEH_RORO_TON_FIN", StringUtil.LTrim( StringUtil.Str( A40VEH_RORO_TON_FIN, 10, 2)));
            A41VEH_RORO_UTIL_INI = T00063_A41VEH_RORO_UTIL_INI[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41VEH_RORO_UTIL_INI", StringUtil.LTrim( StringUtil.Str( A41VEH_RORO_UTIL_INI, 10, 2)));
            A42VEH_RORO_UTIL_FIN = T00063_A42VEH_RORO_UTIL_FIN[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42VEH_RORO_UTIL_FIN", StringUtil.LTrim( StringUtil.Str( A42VEH_RORO_UTIL_FIN, 10, 2)));
            A43VEH_RORO_TARIFA = T00063_A43VEH_RORO_TARIFA[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43VEH_RORO_TARIFA", StringUtil.LTrim( StringUtil.Str( A43VEH_RORO_TARIFA, 10, 2)));
            Z38VEH_RORO_ID = A38VEH_RORO_ID;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load068( ) ;
            if ( AnyError == 1 )
            {
               RcdFound8 = 0;
               InitializeNonKey068( ) ;
            }
            Gx_mode = sMode8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound8 = 0;
            InitializeNonKey068( ) ;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey068( ) ;
         if ( RcdFound8 == 0 )
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
         RcdFound8 = 0;
         /* Using cursor T00066 */
         pr_default.execute(4, new Object[] {A38VEH_RORO_ID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00066_A38VEH_RORO_ID[0] < A38VEH_RORO_ID ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00066_A38VEH_RORO_ID[0] > A38VEH_RORO_ID ) ) )
            {
               A38VEH_RORO_ID = T00066_A38VEH_RORO_ID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38VEH_RORO_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A38VEH_RORO_ID), 4, 0)));
               RcdFound8 = 1;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound8 = 0;
         /* Using cursor T00067 */
         pr_default.execute(5, new Object[] {A38VEH_RORO_ID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00067_A38VEH_RORO_ID[0] > A38VEH_RORO_ID ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00067_A38VEH_RORO_ID[0] < A38VEH_RORO_ID ) ) )
            {
               A38VEH_RORO_ID = T00067_A38VEH_RORO_ID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38VEH_RORO_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A38VEH_RORO_ID), 4, 0)));
               RcdFound8 = 1;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey068( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtVEH_RORO_ID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert068( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound8 == 1 )
            {
               if ( A38VEH_RORO_ID != Z38VEH_RORO_ID )
               {
                  A38VEH_RORO_ID = Z38VEH_RORO_ID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38VEH_RORO_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A38VEH_RORO_ID), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "VEH_RORO_ID");
                  AnyError = 1;
                  GX_FocusControl = edtVEH_RORO_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtVEH_RORO_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update068( ) ;
                  GX_FocusControl = edtVEH_RORO_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A38VEH_RORO_ID != Z38VEH_RORO_ID )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtVEH_RORO_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert068( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "VEH_RORO_ID");
                     AnyError = 1;
                     GX_FocusControl = edtVEH_RORO_ID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtVEH_RORO_ID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert068( ) ;
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
         if ( A38VEH_RORO_ID != Z38VEH_RORO_ID )
         {
            A38VEH_RORO_ID = Z38VEH_RORO_ID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38VEH_RORO_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A38VEH_RORO_ID), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "VEH_RORO_ID");
            AnyError = 1;
            GX_FocusControl = edtVEH_RORO_ID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtVEH_RORO_ID_Internalname;
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
         if ( RcdFound8 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "VEH_RORO_ID");
            AnyError = 1;
         }
         GX_FocusControl = edtVEH_RORO_TON_INI_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         ScanStart068( ) ;
         if ( RcdFound8 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtVEH_RORO_TON_INI_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd068( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         move_previous( ) ;
         if ( RcdFound8 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtVEH_RORO_TON_INI_Internalname;
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
         if ( RcdFound8 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtVEH_RORO_TON_INI_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         ScanStart068( ) ;
         if ( RcdFound8 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound8 != 0 )
            {
               ScanNext068( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtVEH_RORO_TON_INI_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd068( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency068( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00068 */
            pr_default.execute(6, new Object[] {A38VEH_RORO_ID});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"VEH_RORO"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(6) == 101) || ( Z39VEH_RORO_TON_INI != T00068_A39VEH_RORO_TON_INI[0] ) || ( Z40VEH_RORO_TON_FIN != T00068_A40VEH_RORO_TON_FIN[0] ) || ( Z41VEH_RORO_UTIL_INI != T00068_A41VEH_RORO_UTIL_INI[0] ) || ( Z42VEH_RORO_UTIL_FIN != T00068_A42VEH_RORO_UTIL_FIN[0] ) || ( Z43VEH_RORO_TARIFA != T00068_A43VEH_RORO_TARIFA[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"VEH_RORO"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert068( )
      {
         BeforeValidate068( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable068( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM068( 0) ;
            CheckOptimisticConcurrency068( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm068( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert068( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00069 */
                     pr_default.execute(7, new Object[] {A39VEH_RORO_TON_INI, A40VEH_RORO_TON_FIN, A41VEH_RORO_UTIL_INI, A42VEH_RORO_UTIL_FIN, A43VEH_RORO_TARIFA});
                     pr_default.close(7);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000610 */
                     pr_default.execute(8);
                     A38VEH_RORO_ID = T000610_A38VEH_RORO_ID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38VEH_RORO_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A38VEH_RORO_ID), 4, 0)));
                     pr_default.close(8);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "", true);
                           ResetCaption060( ) ;
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
               Load068( ) ;
            }
            EndLevel068( ) ;
         }
         CloseExtendedTableCursors068( ) ;
      }

      protected void Update068( )
      {
         BeforeValidate068( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable068( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency068( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm068( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate068( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000611 */
                     pr_default.execute(9, new Object[] {A39VEH_RORO_TON_INI, A40VEH_RORO_TON_FIN, A41VEH_RORO_UTIL_INI, A42VEH_RORO_UTIL_FIN, A43VEH_RORO_TARIFA, A38VEH_RORO_ID});
                     pr_default.close(9);
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"VEH_RORO"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate068( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "", true);
                           ResetCaption060( ) ;
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
            EndLevel068( ) ;
         }
         CloseExtendedTableCursors068( ) ;
      }

      protected void DeferredUpdate068( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate068( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency068( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls068( ) ;
            AfterConfirm068( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete068( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000612 */
                  pr_default.execute(10, new Object[] {A38VEH_RORO_ID});
                  pr_default.close(10);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound8 == 0 )
                        {
                           InitAll068( ) ;
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
                        ResetCaption060( ) ;
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
         sMode8 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel068( ) ;
         Gx_mode = sMode8;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls068( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel068( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(6);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete068( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(4);
            context.CommitDataStores( "VEH_RORO");
            if ( AnyError == 0 )
            {
               ConfirmValues060( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(4);
            context.RollbackDataStores( "VEH_RORO");
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart068( )
      {
         /* Using cursor T000613 */
         pr_default.execute(11);
         RcdFound8 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound8 = 1;
            A38VEH_RORO_ID = T000613_A38VEH_RORO_ID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38VEH_RORO_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A38VEH_RORO_ID), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext068( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound8 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound8 = 1;
            A38VEH_RORO_ID = T000613_A38VEH_RORO_ID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38VEH_RORO_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A38VEH_RORO_ID), 4, 0)));
         }
      }

      protected void ScanEnd068( )
      {
      }

      protected void AfterConfirm068( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert068( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate068( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete068( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete068( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate068( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes068( )
      {
         edtVEH_RORO_ID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVEH_RORO_ID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVEH_RORO_ID_Enabled), 5, 0)));
         edtVEH_RORO_TON_INI_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVEH_RORO_TON_INI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVEH_RORO_TON_INI_Enabled), 5, 0)));
         edtVEH_RORO_TON_FIN_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVEH_RORO_TON_FIN_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVEH_RORO_TON_FIN_Enabled), 5, 0)));
         edtVEH_RORO_UTIL_INI_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVEH_RORO_UTIL_INI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVEH_RORO_UTIL_INI_Enabled), 5, 0)));
         edtVEH_RORO_UTIL_FIN_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVEH_RORO_UTIL_FIN_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVEH_RORO_UTIL_FIN_Enabled), 5, 0)));
         edtVEH_RORO_TARIFA_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtVEH_RORO_TARIFA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtVEH_RORO_TARIFA_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues060( )
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
         context.AddJavascriptSource("gxcfg.js", "?2015120938486");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" class=\"form-horizontal Form\" novalidate action=\""+formatLink("veh_roro.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z38VEH_RORO_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z38VEH_RORO_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "Z39VEH_RORO_TON_INI", StringUtil.LTrim( StringUtil.NToC( Z39VEH_RORO_TON_INI, 10, 2, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "Z40VEH_RORO_TON_FIN", StringUtil.LTrim( StringUtil.NToC( Z40VEH_RORO_TON_FIN, 10, 2, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "Z41VEH_RORO_UTIL_INI", StringUtil.LTrim( StringUtil.NToC( Z41VEH_RORO_UTIL_INI, 10, 2, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "Z42VEH_RORO_UTIL_FIN", StringUtil.LTrim( StringUtil.NToC( Z42VEH_RORO_UTIL_FIN, 10, 2, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "Z43VEH_RORO_TARIFA", StringUtil.LTrim( StringUtil.NToC( Z43VEH_RORO_TARIFA, 10, 2, context.GetLanguageProperty( "decimal_point"), "")));
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
         return formatLink("veh_roro.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "veh_roro" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "Portavehiculos y RO-RO", "") ;
      }

      protected void InitializeNonKey068( )
      {
         A39VEH_RORO_TON_INI = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39VEH_RORO_TON_INI", StringUtil.LTrim( StringUtil.Str( A39VEH_RORO_TON_INI, 10, 2)));
         A40VEH_RORO_TON_FIN = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40VEH_RORO_TON_FIN", StringUtil.LTrim( StringUtil.Str( A40VEH_RORO_TON_FIN, 10, 2)));
         A41VEH_RORO_UTIL_INI = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41VEH_RORO_UTIL_INI", StringUtil.LTrim( StringUtil.Str( A41VEH_RORO_UTIL_INI, 10, 2)));
         A42VEH_RORO_UTIL_FIN = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42VEH_RORO_UTIL_FIN", StringUtil.LTrim( StringUtil.Str( A42VEH_RORO_UTIL_FIN, 10, 2)));
         A43VEH_RORO_TARIFA = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43VEH_RORO_TARIFA", StringUtil.LTrim( StringUtil.Str( A43VEH_RORO_TARIFA, 10, 2)));
      }

      protected void InitAll068( )
      {
         A38VEH_RORO_ID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38VEH_RORO_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A38VEH_RORO_ID), 4, 0)));
         InitializeNonKey068( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2015120938488");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages."+context.GetLanguageProperty( "code")+".js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("veh_roro.js", "?2015120938488");
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
         edtVEH_RORO_ID_Internalname = "VEH_RORO_ID";
         edtVEH_RORO_ID_Internalname = "VEH_RORO_ID";
         div_Internalname = "";
         div_Internalname = "";
         divVeh_roro_id_container_Internalname = "VEH_RORO_ID_CONTAINER";
         divVeh_roro_id_container_Internalname = "VEH_RORO_ID_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl28_Internalname = "LBL28";
         lbllbl28_Internalname = "LBL28";
         edtVEH_RORO_TON_INI_Internalname = "VEH_RORO_TON_INI";
         edtVEH_RORO_TON_INI_Internalname = "VEH_RORO_TON_INI";
         div_Internalname = "";
         div_Internalname = "";
         divVeh_roro_ton_ini_container_Internalname = "VEH_RORO_TON_INI_CONTAINER";
         divVeh_roro_ton_ini_container_Internalname = "VEH_RORO_TON_INI_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl34_Internalname = "LBL34";
         lbllbl34_Internalname = "LBL34";
         edtVEH_RORO_TON_FIN_Internalname = "VEH_RORO_TON_FIN";
         edtVEH_RORO_TON_FIN_Internalname = "VEH_RORO_TON_FIN";
         div_Internalname = "";
         div_Internalname = "";
         divVeh_roro_ton_fin_container_Internalname = "VEH_RORO_TON_FIN_CONTAINER";
         divVeh_roro_ton_fin_container_Internalname = "VEH_RORO_TON_FIN_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl40_Internalname = "LBL40";
         lbllbl40_Internalname = "LBL40";
         edtVEH_RORO_UTIL_INI_Internalname = "VEH_RORO_UTIL_INI";
         edtVEH_RORO_UTIL_INI_Internalname = "VEH_RORO_UTIL_INI";
         div_Internalname = "";
         div_Internalname = "";
         divVeh_roro_util_ini_container_Internalname = "VEH_RORO_UTIL_INI_CONTAINER";
         divVeh_roro_util_ini_container_Internalname = "VEH_RORO_UTIL_INI_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl46_Internalname = "LBL46";
         lbllbl46_Internalname = "LBL46";
         edtVEH_RORO_UTIL_FIN_Internalname = "VEH_RORO_UTIL_FIN";
         edtVEH_RORO_UTIL_FIN_Internalname = "VEH_RORO_UTIL_FIN";
         div_Internalname = "";
         div_Internalname = "";
         divVeh_roro_util_fin_container_Internalname = "VEH_RORO_UTIL_FIN_CONTAINER";
         divVeh_roro_util_fin_container_Internalname = "VEH_RORO_UTIL_FIN_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl52_Internalname = "LBL52";
         lbllbl52_Internalname = "LBL52";
         edtVEH_RORO_TARIFA_Internalname = "VEH_RORO_TARIFA";
         edtVEH_RORO_TARIFA_Internalname = "VEH_RORO_TARIFA";
         div_Internalname = "";
         div_Internalname = "";
         divVeh_roro_tarifa_container_Internalname = "VEH_RORO_TARIFA_CONTAINER";
         divVeh_roro_tarifa_container_Internalname = "VEH_RORO_TARIFA_CONTAINER";
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
         Form.Caption = context.GetMessage( "Portavehiculos y RO-RO", "");
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtVEH_RORO_TARIFA_Jsonclick = "";
         edtVEH_RORO_TARIFA_Enabled = 1;
         edtVEH_RORO_UTIL_FIN_Jsonclick = "";
         edtVEH_RORO_UTIL_FIN_Enabled = 1;
         edtVEH_RORO_UTIL_INI_Jsonclick = "";
         edtVEH_RORO_UTIL_INI_Enabled = 1;
         edtVEH_RORO_TON_FIN_Jsonclick = "";
         edtVEH_RORO_TON_FIN_Enabled = 1;
         edtVEH_RORO_TON_INI_Jsonclick = "";
         edtVEH_RORO_TON_INI_Enabled = 1;
         edtVEH_RORO_ID_Jsonclick = "";
         edtVEH_RORO_ID_Enabled = 1;
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
         GX_FocusControl = edtVEH_RORO_TON_INI_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Veh_roro_id( short GX_Parm1 ,
                                     decimal GX_Parm2 ,
                                     decimal GX_Parm3 ,
                                     decimal GX_Parm4 ,
                                     decimal GX_Parm5 ,
                                     decimal GX_Parm6 )
      {
         A38VEH_RORO_ID = GX_Parm1;
         A39VEH_RORO_TON_INI = GX_Parm2;
         A40VEH_RORO_TON_FIN = GX_Parm3;
         A41VEH_RORO_UTIL_INI = GX_Parm4;
         A42VEH_RORO_UTIL_FIN = GX_Parm5;
         A43VEH_RORO_TARIFA = GX_Parm6;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A39VEH_RORO_TON_INI, 10, 2, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A40VEH_RORO_TON_FIN, 10, 2, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A41VEH_RORO_UTIL_INI, 10, 2, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A42VEH_RORO_UTIL_FIN, 10, 2, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( A43VEH_RORO_TARIFA, 10, 2, ".", "")));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z38VEH_RORO_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( Z39VEH_RORO_TON_INI, 10, 2, context.GetLanguageProperty( "decimal_point"), "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( Z40VEH_RORO_TON_FIN, 10, 2, context.GetLanguageProperty( "decimal_point"), "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( Z41VEH_RORO_UTIL_INI, 10, 2, context.GetLanguageProperty( "decimal_point"), "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( Z42VEH_RORO_UTIL_FIN, 10, 2, context.GetLanguageProperty( "decimal_point"), "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( Z43VEH_RORO_TARIFA, 10, 2, context.GetLanguageProperty( "decimal_point"), "")));
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
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
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
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T00064_A38VEH_RORO_ID = new short[1] ;
         T00064_A39VEH_RORO_TON_INI = new decimal[1] ;
         T00064_A40VEH_RORO_TON_FIN = new decimal[1] ;
         T00064_A41VEH_RORO_UTIL_INI = new decimal[1] ;
         T00064_A42VEH_RORO_UTIL_FIN = new decimal[1] ;
         T00064_A43VEH_RORO_TARIFA = new decimal[1] ;
         T00065_A38VEH_RORO_ID = new short[1] ;
         T00063_A38VEH_RORO_ID = new short[1] ;
         T00063_A39VEH_RORO_TON_INI = new decimal[1] ;
         T00063_A40VEH_RORO_TON_FIN = new decimal[1] ;
         T00063_A41VEH_RORO_UTIL_INI = new decimal[1] ;
         T00063_A42VEH_RORO_UTIL_FIN = new decimal[1] ;
         T00063_A43VEH_RORO_TARIFA = new decimal[1] ;
         sMode8 = "";
         T00066_A38VEH_RORO_ID = new short[1] ;
         T00067_A38VEH_RORO_ID = new short[1] ;
         T00068_A38VEH_RORO_ID = new short[1] ;
         T00068_A39VEH_RORO_TON_INI = new decimal[1] ;
         T00068_A40VEH_RORO_TON_FIN = new decimal[1] ;
         T00068_A41VEH_RORO_UTIL_INI = new decimal[1] ;
         T00068_A42VEH_RORO_UTIL_FIN = new decimal[1] ;
         T00068_A43VEH_RORO_TARIFA = new decimal[1] ;
         T000610_A38VEH_RORO_ID = new short[1] ;
         T000613_A38VEH_RORO_ID = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.veh_roro__default(),
            new Object[][] {
                new Object[] {
               T00062_A38VEH_RORO_ID, T00062_A39VEH_RORO_TON_INI, T00062_A40VEH_RORO_TON_FIN, T00062_A41VEH_RORO_UTIL_INI, T00062_A42VEH_RORO_UTIL_FIN, T00062_A43VEH_RORO_TARIFA
               }
               , new Object[] {
               T00063_A38VEH_RORO_ID, T00063_A39VEH_RORO_TON_INI, T00063_A40VEH_RORO_TON_FIN, T00063_A41VEH_RORO_UTIL_INI, T00063_A42VEH_RORO_UTIL_FIN, T00063_A43VEH_RORO_TARIFA
               }
               , new Object[] {
               T00064_A38VEH_RORO_ID, T00064_A39VEH_RORO_TON_INI, T00064_A40VEH_RORO_TON_FIN, T00064_A41VEH_RORO_UTIL_INI, T00064_A42VEH_RORO_UTIL_FIN, T00064_A43VEH_RORO_TARIFA
               }
               , new Object[] {
               T00065_A38VEH_RORO_ID
               }
               , new Object[] {
               T00066_A38VEH_RORO_ID
               }
               , new Object[] {
               T00067_A38VEH_RORO_ID
               }
               , new Object[] {
               T00068_A38VEH_RORO_ID, T00068_A39VEH_RORO_TON_INI, T00068_A40VEH_RORO_TON_FIN, T00068_A41VEH_RORO_UTIL_INI, T00068_A42VEH_RORO_UTIL_FIN, T00068_A43VEH_RORO_TARIFA
               }
               , new Object[] {
               }
               , new Object[] {
               T000610_A38VEH_RORO_ID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000613_A38VEH_RORO_ID
               }
            }
         );
      }

      private short Z38VEH_RORO_ID ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A38VEH_RORO_ID ;
      private short GX_JID ;
      private short RcdFound8 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtVEH_RORO_ID_Enabled ;
      private int edtVEH_RORO_TON_INI_Enabled ;
      private int edtVEH_RORO_TON_FIN_Enabled ;
      private int edtVEH_RORO_UTIL_INI_Enabled ;
      private int edtVEH_RORO_UTIL_FIN_Enabled ;
      private int edtVEH_RORO_TARIFA_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private decimal Z39VEH_RORO_TON_INI ;
      private decimal Z40VEH_RORO_TON_FIN ;
      private decimal Z41VEH_RORO_UTIL_INI ;
      private decimal Z42VEH_RORO_UTIL_FIN ;
      private decimal Z43VEH_RORO_TARIFA ;
      private decimal A39VEH_RORO_TON_INI ;
      private decimal A40VEH_RORO_TON_FIN ;
      private decimal A41VEH_RORO_UTIL_INI ;
      private decimal A42VEH_RORO_UTIL_FIN ;
      private decimal A43VEH_RORO_TARIFA ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtVEH_RORO_ID_Internalname ;
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
      private String divVeh_roro_id_container_Internalname ;
      private String lbllbl22_Internalname ;
      private String lbllbl22_Jsonclick ;
      private String edtVEH_RORO_ID_Jsonclick ;
      private String divVeh_roro_ton_ini_container_Internalname ;
      private String lbllbl28_Internalname ;
      private String lbllbl28_Jsonclick ;
      private String edtVEH_RORO_TON_INI_Internalname ;
      private String edtVEH_RORO_TON_INI_Jsonclick ;
      private String divVeh_roro_ton_fin_container_Internalname ;
      private String lbllbl34_Internalname ;
      private String lbllbl34_Jsonclick ;
      private String edtVEH_RORO_TON_FIN_Internalname ;
      private String edtVEH_RORO_TON_FIN_Jsonclick ;
      private String divVeh_roro_util_ini_container_Internalname ;
      private String lbllbl40_Internalname ;
      private String lbllbl40_Jsonclick ;
      private String edtVEH_RORO_UTIL_INI_Internalname ;
      private String edtVEH_RORO_UTIL_INI_Jsonclick ;
      private String divVeh_roro_util_fin_container_Internalname ;
      private String lbllbl46_Internalname ;
      private String lbllbl46_Jsonclick ;
      private String edtVEH_RORO_UTIL_FIN_Internalname ;
      private String edtVEH_RORO_UTIL_FIN_Jsonclick ;
      private String divVeh_roro_tarifa_container_Internalname ;
      private String lbllbl52_Internalname ;
      private String lbllbl52_Jsonclick ;
      private String edtVEH_RORO_TARIFA_Internalname ;
      private String edtVEH_RORO_TARIFA_Jsonclick ;
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
      private String sMode8 ;
      private String sDynURL ;
      private String FormProcess ;
      private String div_Internalname ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool toggleJsOutput ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00064_A38VEH_RORO_ID ;
      private decimal[] T00064_A39VEH_RORO_TON_INI ;
      private decimal[] T00064_A40VEH_RORO_TON_FIN ;
      private decimal[] T00064_A41VEH_RORO_UTIL_INI ;
      private decimal[] T00064_A42VEH_RORO_UTIL_FIN ;
      private decimal[] T00064_A43VEH_RORO_TARIFA ;
      private short[] T00065_A38VEH_RORO_ID ;
      private short[] T00063_A38VEH_RORO_ID ;
      private decimal[] T00063_A39VEH_RORO_TON_INI ;
      private decimal[] T00063_A40VEH_RORO_TON_FIN ;
      private decimal[] T00063_A41VEH_RORO_UTIL_INI ;
      private decimal[] T00063_A42VEH_RORO_UTIL_FIN ;
      private decimal[] T00063_A43VEH_RORO_TARIFA ;
      private short[] T00066_A38VEH_RORO_ID ;
      private short[] T00067_A38VEH_RORO_ID ;
      private short[] T00068_A38VEH_RORO_ID ;
      private decimal[] T00068_A39VEH_RORO_TON_INI ;
      private decimal[] T00068_A40VEH_RORO_TON_FIN ;
      private decimal[] T00068_A41VEH_RORO_UTIL_INI ;
      private decimal[] T00068_A42VEH_RORO_UTIL_FIN ;
      private decimal[] T00068_A43VEH_RORO_TARIFA ;
      private short[] T000610_A38VEH_RORO_ID ;
      private short[] T000613_A38VEH_RORO_ID ;
      private short[] T00062_A38VEH_RORO_ID ;
      private decimal[] T00062_A39VEH_RORO_TON_INI ;
      private decimal[] T00062_A40VEH_RORO_TON_FIN ;
      private decimal[] T00062_A41VEH_RORO_UTIL_INI ;
      private decimal[] T00062_A42VEH_RORO_UTIL_FIN ;
      private decimal[] T00062_A43VEH_RORO_TARIFA ;
      private GXWebForm Form ;
   }

   public class veh_roro__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT00062 ;
          prmT00062 = new Object[] {
          new Object[] {"@VEH_RORO_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00064 ;
          prmT00064 = new Object[] {
          new Object[] {"@VEH_RORO_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00065 ;
          prmT00065 = new Object[] {
          new Object[] {"@VEH_RORO_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00063 ;
          prmT00063 = new Object[] {
          new Object[] {"@VEH_RORO_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00066 ;
          prmT00066 = new Object[] {
          new Object[] {"@VEH_RORO_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00067 ;
          prmT00067 = new Object[] {
          new Object[] {"@VEH_RORO_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00068 ;
          prmT00068 = new Object[] {
          new Object[] {"@VEH_RORO_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00069 ;
          prmT00069 = new Object[] {
          new Object[] {"@VEH_RORO_TON_INI",SqlDbType.Decimal,10,2} ,
          new Object[] {"@VEH_RORO_TON_FIN",SqlDbType.Decimal,10,2} ,
          new Object[] {"@VEH_RORO_UTIL_INI",SqlDbType.Decimal,10,2} ,
          new Object[] {"@VEH_RORO_UTIL_FIN",SqlDbType.Decimal,10,2} ,
          new Object[] {"@VEH_RORO_TARIFA",SqlDbType.Decimal,10,2}
          } ;
          Object[] prmT000610 ;
          prmT000610 = new Object[] {
          } ;
          Object[] prmT000611 ;
          prmT000611 = new Object[] {
          new Object[] {"@VEH_RORO_TON_INI",SqlDbType.Decimal,10,2} ,
          new Object[] {"@VEH_RORO_TON_FIN",SqlDbType.Decimal,10,2} ,
          new Object[] {"@VEH_RORO_UTIL_INI",SqlDbType.Decimal,10,2} ,
          new Object[] {"@VEH_RORO_UTIL_FIN",SqlDbType.Decimal,10,2} ,
          new Object[] {"@VEH_RORO_TARIFA",SqlDbType.Decimal,10,2} ,
          new Object[] {"@VEH_RORO_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000612 ;
          prmT000612 = new Object[] {
          new Object[] {"@VEH_RORO_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000613 ;
          prmT000613 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00062", "SELECT [VEH_RORO_ID], [VEH_RORO_TON_INI], [VEH_RORO_TON_FIN], [VEH_RORO_UTIL_INI], [VEH_RORO_UTIL_FIN], [VEH_RORO_TARIFA] FROM [VEH_RORO] WITH (UPDLOCK) WHERE [VEH_RORO_ID] = @VEH_RORO_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00062,1,0,true,false )
             ,new CursorDef("T00063", "SELECT [VEH_RORO_ID], [VEH_RORO_TON_INI], [VEH_RORO_TON_FIN], [VEH_RORO_UTIL_INI], [VEH_RORO_UTIL_FIN], [VEH_RORO_TARIFA] FROM [VEH_RORO] WITH (NOLOCK) WHERE [VEH_RORO_ID] = @VEH_RORO_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00063,1,0,true,false )
             ,new CursorDef("T00064", "SELECT TM1.[VEH_RORO_ID], TM1.[VEH_RORO_TON_INI], TM1.[VEH_RORO_TON_FIN], TM1.[VEH_RORO_UTIL_INI], TM1.[VEH_RORO_UTIL_FIN], TM1.[VEH_RORO_TARIFA] FROM [VEH_RORO] TM1 WITH (NOLOCK) WHERE TM1.[VEH_RORO_ID] = @VEH_RORO_ID ORDER BY TM1.[VEH_RORO_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00064,100,0,true,false )
             ,new CursorDef("T00065", "SELECT [VEH_RORO_ID] FROM [VEH_RORO] WITH (NOLOCK) WHERE [VEH_RORO_ID] = @VEH_RORO_ID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00065,1,0,true,false )
             ,new CursorDef("T00066", "SELECT TOP 1 [VEH_RORO_ID] FROM [VEH_RORO] WITH (NOLOCK) WHERE ( [VEH_RORO_ID] > @VEH_RORO_ID) ORDER BY [VEH_RORO_ID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00066,1,0,true,true )
             ,new CursorDef("T00067", "SELECT TOP 1 [VEH_RORO_ID] FROM [VEH_RORO] WITH (NOLOCK) WHERE ( [VEH_RORO_ID] < @VEH_RORO_ID) ORDER BY [VEH_RORO_ID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00067,1,0,true,true )
             ,new CursorDef("T00068", "SELECT [VEH_RORO_ID], [VEH_RORO_TON_INI], [VEH_RORO_TON_FIN], [VEH_RORO_UTIL_INI], [VEH_RORO_UTIL_FIN], [VEH_RORO_TARIFA] FROM [VEH_RORO] WITH (UPDLOCK) WHERE [VEH_RORO_ID] = @VEH_RORO_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00068,1,0,true,false )
             ,new CursorDef("T00069", "INSERT INTO [VEH_RORO]([VEH_RORO_TON_INI], [VEH_RORO_TON_FIN], [VEH_RORO_UTIL_INI], [VEH_RORO_UTIL_FIN], [VEH_RORO_TARIFA]) VALUES(@VEH_RORO_TON_INI, @VEH_RORO_TON_FIN, @VEH_RORO_UTIL_INI, @VEH_RORO_UTIL_FIN, @VEH_RORO_TARIFA)", GxErrorMask.GX_NOMASK,prmT00069)
             ,new CursorDef("T000610", "SELECT Ident_Current('[VEH_RORO]') ",true, GxErrorMask.GX_NOMASK, false, this,prmT000610,1,0,true,false )
             ,new CursorDef("T000611", "UPDATE [VEH_RORO] SET [VEH_RORO_TON_INI]=@VEH_RORO_TON_INI, [VEH_RORO_TON_FIN]=@VEH_RORO_TON_FIN, [VEH_RORO_UTIL_INI]=@VEH_RORO_UTIL_INI, [VEH_RORO_UTIL_FIN]=@VEH_RORO_UTIL_FIN, [VEH_RORO_TARIFA]=@VEH_RORO_TARIFA  WHERE [VEH_RORO_ID] = @VEH_RORO_ID", GxErrorMask.GX_NOMASK,prmT000611)
             ,new CursorDef("T000612", "DELETE FROM [VEH_RORO]  WHERE [VEH_RORO_ID] = @VEH_RORO_ID", GxErrorMask.GX_NOMASK,prmT000612)
             ,new CursorDef("T000613", "SELECT [VEH_RORO_ID] FROM [VEH_RORO] WITH (NOLOCK) ORDER BY [VEH_RORO_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000613,100,0,true,false )
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
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
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
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
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
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (decimal)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                break;
             case 9 :
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (decimal)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                break;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
