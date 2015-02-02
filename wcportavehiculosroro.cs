/*
               File: WCPortavehiculosRORO
        Description: WC para Portavehiculos y RORO
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:15:3.67
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
   public class wcportavehiculosroro : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wcportavehiculosroro( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public wcportavehiculosroro( IGxContext context )
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

      protected void INITWEB( )
      {
         context.SetDefaultTheme("Flat");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
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
         }
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("mp", "GeneXus.Programs.mp", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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

      public override short ExecuteStartEvent( )
      {
         PA172( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START172( ) ;
         }
         return gxajaxcallmode ;
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
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("gxcfg.js", "?20151261115368");
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
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"";
         context.WriteHtmlText( "<body") ;
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+";") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background-image:url("+context.convertURL( Form.Background)+")") ;
         }
         context.WriteHtmlText( "\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" class=\"form-horizontal Form\" novalidate action=\""+formatLink("wcportavehiculosroro.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vSDTRESULTADO_Sdtresultadopanamax", StringUtil.LTrim( StringUtil.NToC( AV9SdtResultado.gxTpr_Sdtresultadopanamax, 18, 2, ".", "")));
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
         SendSecurityToken((String)(sPrefix));
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
         if ( ! ( WebComp_Component1 == null ) )
         {
            WebComp_Component1.componentjscripts();
         }
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE172( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT172( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("wcportavehiculosroro.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "wcportavehiculosroro" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "WC para Portavehiculos y RORO", "") ;
      }

      protected void WB170( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", " "+"data-abstract-form"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "Table", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            /* Control Group */
            GxWebStd.gx_group_start( context, grpGroup1_Internalname, context.GetMessage( "Portavehículos y Ro-Ro", ""), 1, 0, "px", 0, "px", "Group", "", "HLP_WCPortavehiculosRORO.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGroup1table_Internalname, 1, 0, "px", 0, "px", "Table", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtable_Internalname, 1, 0, "px", 0, "px", "Table", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-4", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTonelaje_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl14_Internalname, context.GetMessage( "CP/SUAB", ""), "", "", lbllbl14_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WCPortavehiculosRORO.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTonelaje_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6Tonelaje), 13, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtavTonelaje_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6Tonelaje), "Z,ZZZ,ZZZ,ZZ9")) : context.localUtil.Format( (decimal)(AV6Tonelaje), "Z,ZZZ,ZZZ,ZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTonelaje_Jsonclick, 0, "Attribute", "", "", "", 1, edtavTonelaje_Enabled, 0, "text", "", 13, "chr", 1, "row", 13, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_WCPortavehiculosRORO.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-4", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTm_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl19_Internalname, context.GetMessage( "TM", ""), "", "", lbllbl19_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WCPortavehiculosRORO.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTm_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10TM), 13, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtavTm_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10TM), "Z,ZZZ,ZZZ,ZZ9")) : context.localUtil.Format( (decimal)(AV10TM), "Z,ZZZ,ZZZ,ZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(21);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTm_Jsonclick, 0, "Attribute", "", "", "", 1, edtavTm_Enabled, 0, "text", "", 13, "chr", 1, "row", 13, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_WCPortavehiculosRORO.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-4", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divDwt_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl24_Internalname, context.GetMessage( "DWT", ""), "", "", lbllbl24_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WCPortavehiculosRORO.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavDwt_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8DWT), 13, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtavDwt_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8DWT), "Z,ZZZ,ZZZ,ZZ9")) : context.localUtil.Format( (decimal)(AV8DWT), "Z,ZZZ,ZZZ,ZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDwt_Jsonclick, 0, "Attribute", "", "", "", 1, edtavDwt_Enabled, 0, "text", "", 13, "chr", 1, "row", 13, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_WCPortavehiculosRORO.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-8", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUtilizacion_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl29_Internalname, context.GetMessage( "Utilización (%)", ""), "", "", lbllbl29_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WCPortavehiculosRORO.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavUtilizacion_Internalname, StringUtil.LTrim( StringUtil.NToC( AV7Utilizacion, 12, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavUtilizacion_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV7Utilizacion, "Z,ZZZ,ZZ9.99")) : context.localUtil.Format( AV7Utilizacion, "Z,ZZZ,ZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(31);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavUtilizacion_Jsonclick, 0, "Attribute", "", "", "", 1, edtavUtilizacion_Enabled, 0, "text", "", 12, "chr", 1, "row", 12, 0, 0, 0, 1, 1, 0, true, "", "right", "HLP_WCPortavehiculosRORO.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            wb_table1_34_172( true) ;
         }
         else
         {
            wb_table1_34_172( false) ;
         }
         return  ;
      }

      protected void wb_table1_34_172e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            /* Control Group */
            GxWebStd.gx_group_start( context, grpGroup2_Internalname, context.GetMessage( "Resultados estimados en USD", ""), 1, 0, "px", 0, "px", "Group", "", "HLP_WCPortavehiculosRORO.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGroup2table_Internalname, 1, 0, "px", 0, "px", "Table", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            wb_table2_49_172( true) ;
         }
         else
         {
            wb_table2_49_172( false) ;
         }
         return  ;
      }

      protected void wb_table2_49_172e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0057"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( ! context.isAjaxRequest( ) )
               {
                  context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0057"+"");
               }
               WebComp_Component1.componentdraw();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.httpAjaxContext.ajax_rspEndCmp();
               }
               context.WriteHtmlText( "</div>") ;
            }
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
         }
         wbLoad = true;
      }

      protected void START172( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_2-86442", 0) ;
            Form.Meta.addItem("description", context.GetMessage( "WC para Portavehiculos y RORO", ""), 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP170( ) ;
      }

      protected void WS172( )
      {
         START172( ) ;
         EVT172( ) ;
      }

      protected void EVT172( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
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
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CALCULAR'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E11172 */
                              E11172 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E12172 */
                              E12172 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false;
                                 if ( ! Rfr0gs )
                                 {
                                 }
                                 dynload_actions( ) ;
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                        }
                     }
                     else if ( StringUtil.StrCmp(sEvtType, "W") == 0 )
                     {
                        sEvtType = StringUtil.Left( sEvt, 4);
                        sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-4));
                        nCmpId = (short)(NumberUtil.Val( sEvtType, "."));
                        if ( nCmpId == 57 )
                        {
                           WebComp_Component1 = getWebComponent(GetType(), "GeneXus.Programs", "wcnota", new Object[] {context} );
                           WebComp_Component1.ComponentInit();
                           WebComp_Component1.Name = "WCNota";
                           WebComp_Component1_Component = "WCNota";
                           WebComp_Component1.componentprocess("W0057", "", sEvt);
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE172( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA172( )
      {
         if ( nDonePA == 0 )
         {
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
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavTonelaje_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      public void Refresh( )
      {
         RF172( ) ;
      }

      protected void RF172( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavUtilizacion_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUtilizacion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUtilizacion_Enabled), 5, 0)));
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( StringUtil.StrCmp(WebComp_Component1_Component, "") == 0 )
            {
               WebComp_Component1 = getWebComponent(GetType(), "GeneXus.Programs", "wcnota", new Object[] {context} );
               WebComp_Component1.ComponentInit();
               WebComp_Component1.Name = "WCNota";
               WebComp_Component1_Component = "WCNota";
            }
            WebComp_Component1.setjustcreated();
            WebComp_Component1.componentprepare(new Object[] {(String)"W0057",(String)""});
            WebComp_Component1.componentbind(new Object[] {});
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0057"+"");
               WebComp_Component1.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
            if ( 1 != 0 )
            {
               WebComp_Component1.componentstart();
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E12172 */
            E12172 ();
            WB170( ) ;
         }
      }

      protected void STRUP170( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavUtilizacion_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUtilizacion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUtilizacion_Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTonelaje_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTonelaje_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTONELAJE");
               GX_FocusControl = edtavTonelaje_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6Tonelaje = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6Tonelaje", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6Tonelaje), 10, 0)));
            }
            else
            {
               AV6Tonelaje = (long)(context.localUtil.CToN( cgiGet( edtavTonelaje_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6Tonelaje", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6Tonelaje), 10, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTm_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTm_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTM");
               GX_FocusControl = edtavTm_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10TM = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10TM", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10TM), 10, 0)));
            }
            else
            {
               AV10TM = (long)(context.localUtil.CToN( cgiGet( edtavTm_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10TM", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10TM), 10, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavDwt_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavDwt_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vDWT");
               GX_FocusControl = edtavDwt_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8DWT = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8DWT", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8DWT), 10, 0)));
            }
            else
            {
               AV8DWT = (long)(context.localUtil.CToN( cgiGet( edtavDwt_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8DWT", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8DWT), 10, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavUtilizacion_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavUtilizacion_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 9999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vUTILIZACION");
               GX_FocusControl = edtavUtilizacion_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7Utilizacion = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7Utilizacion", StringUtil.LTrim( StringUtil.Str( AV7Utilizacion, 10, 2)));
            }
            else
            {
               AV7Utilizacion = context.localUtil.CToN( cgiGet( edtavUtilizacion_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7Utilizacion", StringUtil.LTrim( StringUtil.Str( AV7Utilizacion, 10, 2)));
            }
            /* Read saved values. */
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void E11172( )
      {
         /* 'Calcular' Routine */
         if ( AV10TM > AV8DWT )
         {
            GX_msglist.addItem(context.GetMessage( "Error|El valor de TM no puede exceder al DWT", ""));
            AV7Utilizacion = 0;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7Utilizacion", StringUtil.LTrim( StringUtil.Str( AV7Utilizacion, 10, 2)));
         }
         else
         {
            GXt_SdtSdtResultado1 = AV9SdtResultado;
            new calcularportavehiculosroro(context ).execute(  (decimal)(AV6Tonelaje),  AV7Utilizacion, out  GXt_SdtSdtResultado1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6Tonelaje", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6Tonelaje), 10, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7Utilizacion", StringUtil.LTrim( StringUtil.Str( AV7Utilizacion, 10, 2)));
            AV9SdtResultado = GXt_SdtSdtResultado1;
            lblResultadocalculo_Caption = context.localUtil.Format( AV9SdtResultado.gxTpr_Sdtresultadopanamax, "$ZZZ,ZZZ,ZZZ,ZZZ,ZZ9.99");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadocalculo_Internalname, "Caption", lblResultadocalculo_Caption);
         }
         GX_FocusControl = bttCalcular_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9SdtResultado", AV9SdtResultado);
      }

      protected void nextLoad( )
      {
      }

      protected void E12172( )
      {
         /* Load Routine */
      }

      protected void wb_table2_49_172( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadotexto_Internalname, context.GetMessage( "Cálculo:", ""), "", "", lblResultadotexto_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Resultado", 0, "", 1, 1, 0, "HLP_WCPortavehiculosRORO.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadocalculo_Internalname, lblResultadocalculo_Caption, "", "", lblResultadocalculo_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Estimados", 0, "", 1, 1, 0, "HLP_WCPortavehiculosRORO.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_49_172e( true) ;
         }
         else
         {
            wb_table2_49_172e( false) ;
         }
      }

      protected void wb_table1_34_172( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttCalcular_Internalname, "", context.GetMessage( "Calcular", ""), bttCalcular_Jsonclick, 5, context.GetMessage( "Calcular", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'CALCULAR\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_WCPortavehiculosRORO.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttLimpiar_Internalname, "", context.GetMessage( "Limpiar", ""), bttLimpiar_Jsonclick, 7, context.GetMessage( "Limpiar", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e13171_client"+"'", TempTags, "", 2, "HLP_WCPortavehiculosRORO.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_34_172e( true) ;
         }
         else
         {
            wb_table1_34_172e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
      }

      public override String getresponse( String sGXDynURL )
      {
         context.SetDefaultTheme("Flat");
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA172( ) ;
         WS172( ) ;
         WE172( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?11145295");
         if ( StringUtil.StrCmp(WebComp_Component1_Component, "") == 0 )
         {
            WebComp_Component1 = getWebComponent(GetType(), "GeneXus.Programs", "wcnota", new Object[] {context} );
            WebComp_Component1.ComponentInit();
            WebComp_Component1.Name = "WCNota";
            WebComp_Component1_Component = "WCNota";
         }
         if ( ! ( WebComp_Component1 == null ) )
         {
            WebComp_Component1.componentthemes();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20151261115394");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages."+context.GetLanguageProperty( "code")+".js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("wcportavehiculosroro.js", "?20151261115394");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lbllbl14_Internalname = "LBL14";
         lbllbl14_Internalname = "LBL14";
         edtavTonelaje_Internalname = "vTONELAJE";
         edtavTonelaje_Internalname = "vTONELAJE";
         div_Internalname = "";
         div_Internalname = "";
         divTonelaje_container_Internalname = "TONELAJE_CONTAINER";
         divTonelaje_container_Internalname = "TONELAJE_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl19_Internalname = "LBL19";
         lbllbl19_Internalname = "LBL19";
         edtavTm_Internalname = "vTM";
         edtavTm_Internalname = "vTM";
         div_Internalname = "";
         div_Internalname = "";
         divTm_container_Internalname = "TM_CONTAINER";
         divTm_container_Internalname = "TM_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl24_Internalname = "LBL24";
         lbllbl24_Internalname = "LBL24";
         edtavDwt_Internalname = "vDWT";
         edtavDwt_Internalname = "vDWT";
         div_Internalname = "";
         div_Internalname = "";
         divDwt_container_Internalname = "DWT_CONTAINER";
         divDwt_container_Internalname = "DWT_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl29_Internalname = "LBL29";
         lbllbl29_Internalname = "LBL29";
         edtavUtilizacion_Internalname = "vUTILIZACION";
         edtavUtilizacion_Internalname = "vUTILIZACION";
         div_Internalname = "";
         div_Internalname = "";
         divUtilizacion_container_Internalname = "UTILIZACION_CONTAINER";
         divUtilizacion_container_Internalname = "UTILIZACION_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         bttCalcular_Internalname = "CALCULAR";
         bttCalcular_Internalname = "CALCULAR";
         bttLimpiar_Internalname = "LIMPIAR";
         bttLimpiar_Internalname = "LIMPIAR";
         tblTable3_Internalname = "TABLE3";
         tblTable3_Internalname = "TABLE3";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divGridtable_Internalname = "GRIDTABLE";
         divGridtable_Internalname = "GRIDTABLE";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divGroup1table_Internalname = "GROUP1TABLE";
         divGroup1table_Internalname = "GROUP1TABLE";
         grpGroup1_Internalname = "GROUP1";
         grpGroup1_Internalname = "GROUP1";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblResultadotexto_Internalname = "RESULTADOTEXTO";
         lblResultadotexto_Internalname = "RESULTADOTEXTO";
         lblResultadocalculo_Internalname = "RESULTADOCALCULO";
         lblResultadocalculo_Internalname = "RESULTADOCALCULO";
         tblTable1_Internalname = "TABLE1";
         tblTable1_Internalname = "TABLE1";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divGroup2table_Internalname = "GROUP2TABLE";
         divGroup2table_Internalname = "GROUP2TABLE";
         grpGroup2_Internalname = "GROUP2";
         grpGroup2_Internalname = "GROUP2";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divMaintable_Internalname = "MAINTABLE";
         divMaintable_Internalname = "MAINTABLE";
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
         lblResultadocalculo_Caption = "$0.00";
         edtavUtilizacion_Jsonclick = "";
         edtavUtilizacion_Enabled = 1;
         edtavDwt_Jsonclick = "";
         edtavDwt_Enabled = 1;
         edtavTm_Jsonclick = "";
         edtavTm_Enabled = 1;
         edtavTonelaje_Jsonclick = "";
         edtavTonelaje_Enabled = 1;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = context.GetMessage( "WC para Portavehiculos y RORO", "");
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public void Validv_Dwt( long GX_Parm1 ,
                              long GX_Parm2 ,
                              decimal GX_Parm3 )
      {
         AV10TM = GX_Parm1;
         AV8DWT = GX_Parm2;
         AV7Utilizacion = GX_Parm3;
         if ( true )
         {
            AV7Utilizacion = (decimal)(((AV10TM/ (decimal)(AV8DWT))*100));
         }
         else
         {
            if ( AV10TM == 0 )
            {
               AV7Utilizacion = 0;
            }
            else
            {
               if ( AV10TM > AV8DWT )
               {
                  AV7Utilizacion = 0;
               }
            }
         }
         dynload_actions( ) ;
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( AV7Utilizacion, 10, 2, ".", "")));
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[],oparms:[]}");
         setEventMetadata("'LIMPIAR'","{handler:'E13171',iparms:[],oparms:[{av:'AV6Tonelaje',fld:'vTONELAJE'},{av:'AV10TM',fld:'vTM'},{av:'AV8DWT',fld:'vDWT'},{av:'AV7Utilizacion',fld:'vUTILIZACION'},{av:'lblResultadocalculo_Caption',ctrl:'RESULTADOCALCULO',prop:'Caption'}]}");
         setEventMetadata("'CALCULAR'","{handler:'E11172',iparms:[{av:'AV10TM',fld:'vTM'},{av:'AV8DWT',fld:'vDWT'},{av:'AV6Tonelaje',fld:'vTONELAJE'},{av:'AV7Utilizacion',fld:'vUTILIZACION'},{av:'AV9SdtResultado',fld:'vSDTRESULTADO'}],oparms:[{av:'AV7Utilizacion',fld:'vUTILIZACION'},{av:'AV9SdtResultado',fld:'vSDTRESULTADO'},{av:'lblResultadocalculo_Caption',ctrl:'RESULTADOCALCULO',prop:'Caption'}]}");
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
      }

      public override void initialize( )
      {
         AV9SdtResultado = new SdtSdtResultado(context);
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lbllbl14_Jsonclick = "";
         TempTags = "";
         lbllbl19_Jsonclick = "";
         lbllbl24_Jsonclick = "";
         lbllbl29_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         WebComp_Component1_Component = "";
         GXKey = "";
         GXt_SdtSdtResultado1 = new SdtSdtResultado(context);
         sStyleString = "";
         lblResultadotexto_Jsonclick = "";
         lblResultadocalculo_Jsonclick = "";
         bttCalcular_Jsonclick = "";
         bttLimpiar_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         isValidOutput = new GxUnknownObjectCollection();
         WebComp_Component1 = new GeneXus.Http.GXNullWebComponent();
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavUtilizacion_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short wbTemp ;
      private int edtavTonelaje_Enabled ;
      private int edtavTm_Enabled ;
      private int edtavDwt_Enabled ;
      private int edtavUtilizacion_Enabled ;
      private int idxLst ;
      private long AV6Tonelaje ;
      private long AV10TM ;
      private long AV8DWT ;
      private decimal AV7Utilizacion ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String grpGroup1_Internalname ;
      private String divGroup1table_Internalname ;
      private String divGridtable_Internalname ;
      private String divTonelaje_container_Internalname ;
      private String lbllbl14_Internalname ;
      private String lbllbl14_Jsonclick ;
      private String TempTags ;
      private String edtavTonelaje_Internalname ;
      private String edtavTonelaje_Jsonclick ;
      private String divTm_container_Internalname ;
      private String lbllbl19_Internalname ;
      private String lbllbl19_Jsonclick ;
      private String edtavTm_Internalname ;
      private String edtavTm_Jsonclick ;
      private String divDwt_container_Internalname ;
      private String lbllbl24_Internalname ;
      private String lbllbl24_Jsonclick ;
      private String edtavDwt_Internalname ;
      private String edtavDwt_Jsonclick ;
      private String divUtilizacion_container_Internalname ;
      private String lbllbl29_Internalname ;
      private String lbllbl29_Jsonclick ;
      private String edtavUtilizacion_Internalname ;
      private String edtavUtilizacion_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroup2_Internalname ;
      private String divGroup2table_Internalname ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String WebComp_Component1_Component ;
      private String GXKey ;
      private String lblResultadocalculo_Caption ;
      private String lblResultadocalculo_Internalname ;
      private String bttCalcular_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String lblResultadotexto_Internalname ;
      private String lblResultadotexto_Jsonclick ;
      private String lblResultadocalculo_Jsonclick ;
      private String tblTable3_Internalname ;
      private String bttCalcular_Jsonclick ;
      private String bttLimpiar_Internalname ;
      private String bttLimpiar_Jsonclick ;
      private String div_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private GXWebComponent WebComp_Component1 ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtSdtResultado AV9SdtResultado ;
      private SdtSdtResultado GXt_SdtSdtResultado1 ;
   }

}
