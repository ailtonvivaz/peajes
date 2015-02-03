/*
               File: WCLPG
        Description: WCLPG
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:15:4.39
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
   public class wclpg : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wclpg( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public wclpg( IGxContext context )
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
         PA1B2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1B2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20151261115440");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" class=\"form-horizontal Form\" novalidate action=\""+formatLink("wclpg.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vSDTRESULTADO_Sdtresultadopanamax", StringUtil.LTrim( StringUtil.NToC( AV10SdtResultado.gxTpr_Sdtresultadopanamax, 18, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "vSDTRESULTADO_Sdtresultadoneopanamax", StringUtil.LTrim( StringUtil.NToC( AV10SdtResultado.gxTpr_Sdtresultadoneopanamax, 18, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "vSDTRESULTADO_Sdtresultadolastre", StringUtil.LTrim( StringUtil.NToC( AV10SdtResultado.gxTpr_Sdtresultadolastre, 18, 2, ".", "")));
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
            WE1B2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1B2( ) ;
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
         return formatLink("wclpg.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "wclpg" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "WCLPG", "") ;
      }

      protected void WB1B0( )
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
            GxWebStd.gx_group_start( context, grpGrouptanquerotitulo_Internalname, context.GetMessage( "Gaseros LPG", ""), 1, 0, "px", 0, "px", "Group", "", "HLP_WCLPG.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10 col-md-10 TextBlock", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLpgbandam3_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl14_Internalname, context.GetMessage( "Capacidad (metros cúbicos)", ""), "", "", lbllbl14_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WCLPG.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavLpgbandam3_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12LPGBandaM3), 15, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtavLpgbandam3_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV12LPGBandaM3), "ZZZ,ZZZ,ZZZ,ZZ9")) : context.localUtil.Format( (decimal)(AV12LPGBandaM3), "ZZZ,ZZZ,ZZZ,ZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavLpgbandam3_Jsonclick, 0, "Attribute", "", "", "", 1, edtavLpgbandam3_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_WCLPG.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-xs-offset-0 col-sm-3 col-sm-offset-0 col-md-3 col-md-offset-0", " "+"id"+" ");
            wb_table1_19_1B2( true) ;
         }
         else
         {
            wb_table1_19_1B2( false) ;
         }
         return  ;
      }

      protected void wb_table1_19_1B2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-offset-0 col-sm-12 col-sm-offset-0", " "+"id"+" ");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            /* Control Group */
            GxWebStd.gx_group_start( context, grpGrouptanqueroresultado_Internalname, context.GetMessage( "Resultados estimados en USD", ""), 1, 0, "px", 0, "px", "Group", "", "HLP_WCLPG.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGroup3table_Internalname, 1, 0, "px", 0, "px", "Table", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-4", " "+"id"+" ");
            wb_table2_34_1B2( true) ;
         }
         else
         {
            wb_table2_34_1B2( false) ;
         }
         return  ;
      }

      protected void wb_table2_34_1B2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-4", " "+"id"+" ");
            wb_table3_41_1B2( true) ;
         }
         else
         {
            wb_table3_41_1B2( false) ;
         }
         return  ;
      }

      protected void wb_table3_41_1B2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-4", " "+"id"+" ");
            wb_table4_48_1B2( true) ;
         }
         else
         {
            wb_table4_48_1B2( false) ;
         }
         return  ;
      }

      protected void wb_table4_48_1B2e( bool wbgen )
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
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "alert alert-info", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock8_Internalname, context.GetMessage( "Los buques en lastre se le permite transportar hasta un 2% de la capacidad de carga.", ""), "", "", lblTextblock8_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WCLPG.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
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
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0062"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( ! context.isAjaxRequest( ) )
               {
                  context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0062"+"");
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
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
         }
         wbLoad = true;
      }

      protected void START1B2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_2-86442", 0) ;
            Form.Meta.addItem("description", context.GetMessage( "WCLPG", ""), 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1B0( ) ;
      }

      protected void WS1B2( )
      {
         START1B2( ) ;
         EVT1B2( ) ;
      }

      protected void EVT1B2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "'LIMPIAR'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E111B2 */
                              E111B2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CALCULAR'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E121B2 */
                              E121B2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E131B2 */
                              E131B2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E141B2 */
                              E141B2 ();
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
                        if ( nCmpId == 62 )
                        {
                           WebComp_Component1 = getWebComponent(GetType(), "GeneXus.Programs", "wcnota", new Object[] {context} );
                           WebComp_Component1.ComponentInit();
                           WebComp_Component1.Name = "WCNota";
                           WebComp_Component1_Component = "WCNota";
                           WebComp_Component1.componentprocess("W0062", "", sEvt);
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE1B2( )
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

      protected void PA1B2( )
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
               GX_FocusControl = edtavLpgbandam3_Internalname;
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
         RF1B2( ) ;
      }

      protected void RF1B2( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
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
            WebComp_Component1.componentprepare(new Object[] {(String)"W0062",(String)""});
            WebComp_Component1.componentbind(new Object[] {});
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0062"+"");
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
            /* Execute user event: E141B2 */
            E141B2 ();
            WB1B0( ) ;
         }
      }

      protected void STRUP1B0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E131B2 */
         E131B2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavLpgbandam3_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavLpgbandam3_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vLPGBANDAM3");
               GX_FocusControl = edtavLpgbandam3_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV12LPGBandaM3 = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12LPGBandaM3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12LPGBandaM3), 12, 0)));
            }
            else
            {
               AV12LPGBandaM3 = (long)(context.localUtil.CToN( cgiGet( edtavLpgbandam3_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12LPGBandaM3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12LPGBandaM3), 12, 0)));
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

      protected void E111B2( )
      {
         /* 'Limpiar' Routine */
         AV5TanqueroBandaCPSUAB = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5TanqueroBandaCPSUAB", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5TanqueroBandaCPSUAB), 10, 0)));
         AV7ValorACalcular = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ValorACalcular", StringUtil.LTrim( StringUtil.Str( AV7ValorACalcular, 12, 2)));
         lblResultadopanamax_Caption = StringUtil.Format( "%1", "$0.00", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadopanamax_Internalname, "Caption", lblResultadopanamax_Caption);
         lblResultadoneopanamax_Caption = StringUtil.Format( "%1", "$0.00", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadoneopanamax_Internalname, "Caption", lblResultadoneopanamax_Caption);
         lblResultadolastre_Caption = StringUtil.Format( "%1", "$0.00", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadolastre_Internalname, "Caption", lblResultadolastre_Caption);
         context.DoAjaxRefresh();
      }

      protected void E121B2( )
      {
         /* 'Calcular' Routine */
         if ( AV12LPGBandaM3 >= 90000 )
         {
            GX_msglist.addItem(context.GetMessage( "Buques con esta capacidad, en base a sus dimensiones podrían no aplicar al Canal de Panamá.", ""));
         }
         else
         {
         }
         GXt_SdtSdtResultado1 = AV10SdtResultado;
         new calcularlpg(context ).execute(  AV12LPGBandaM3, out  GXt_SdtSdtResultado1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12LPGBandaM3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12LPGBandaM3), 12, 0)));
         AV10SdtResultado = GXt_SdtSdtResultado1;
         lblResultadopanamax_Caption = StringUtil.Format( "%1", context.localUtil.Format( AV10SdtResultado.gxTpr_Sdtresultadopanamax, "$ZZZ,ZZZ,ZZZ,ZZZ,ZZ9.99"), "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadopanamax_Internalname, "Caption", lblResultadopanamax_Caption);
         lblResultadoneopanamax_Caption = StringUtil.Format( "%1", context.localUtil.Format( AV10SdtResultado.gxTpr_Sdtresultadoneopanamax, "$ZZZ,ZZZ,ZZZ,ZZZ,ZZ9.99"), "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadoneopanamax_Internalname, "Caption", lblResultadoneopanamax_Caption);
         lblResultadolastre_Caption = StringUtil.Format( "%1", context.localUtil.Format( AV10SdtResultado.gxTpr_Sdtresultadolastre, "$ZZZ,ZZZ,ZZZ,ZZZ,ZZ9.99"), "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadolastre_Internalname, "Caption", lblResultadolastre_Caption);
         GX_FocusControl = bttCalcular_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10SdtResultado", AV10SdtResultado);
      }

      protected void GXStart( )
      {
         /* Execute user event: E131B2 */
         E131B2 ();
         if (returnInSub) return;
      }

      protected void E131B2( )
      {
         /* Start Routine */
      }

      protected void nextLoad( )
      {
      }

      protected void E141B2( )
      {
         /* Load Routine */
      }

      protected void wb_table4_48_1B2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable5_Internalname, tblTable5_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockresultadolastre_Internalname, context.GetMessage( "Tránsito en lastre:", ""), "", "", lblTextblockresultadolastre_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WCLPG.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadolastre_Internalname, lblResultadolastre_Caption, "", "", lblResultadolastre_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Estimados", 0, "", 1, 1, 0, "HLP_WCLPG.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_48_1B2e( true) ;
         }
         else
         {
            wb_table4_48_1B2e( false) ;
         }
      }

      protected void wb_table3_41_1B2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockresultadoneopanamax_Internalname, context.GetMessage( "Esclusa neopanamax:", ""), "", "", lblTextblockresultadoneopanamax_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WCLPG.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadoneopanamax_Internalname, lblResultadoneopanamax_Caption, "", "", lblResultadoneopanamax_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Estimados", 0, "", 1, 1, 0, "HLP_WCLPG.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_41_1B2e( true) ;
         }
         else
         {
            wb_table3_41_1B2e( false) ;
         }
      }

      protected void wb_table2_34_1B2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockresultadopanamax_Internalname, context.GetMessage( "Esclusa panamax:", ""), "", "", lblTextblockresultadopanamax_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WCLPG.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadopanamax_Internalname, lblResultadopanamax_Caption, "", "", lblResultadopanamax_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Estimados", 0, "", 1, 1, 0, "HLP_WCLPG.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_34_1B2e( true) ;
         }
         else
         {
            wb_table2_34_1B2e( false) ;
         }
      }

      protected void wb_table1_19_1B2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttCalcular_Internalname, "", context.GetMessage( "Calcular", ""), bttCalcular_Jsonclick, 5, context.GetMessage( "Calcular", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'CALCULAR\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_WCLPG.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttLimpiar_Internalname, "", context.GetMessage( "Limpiar", ""), bttLimpiar_Jsonclick, 5, context.GetMessage( "Limpiar", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'LIMPIAR\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_WCLPG.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_19_1B2e( true) ;
         }
         else
         {
            wb_table1_19_1B2e( false) ;
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
         PA1B2( ) ;
         WS1B2( ) ;
         WE1B2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20151261115465");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages."+context.GetLanguageProperty( "code")+".js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("wclpg.js", "?20151261115465");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lbllbl14_Internalname = "LBL14";
         lbllbl14_Internalname = "LBL14";
         edtavLpgbandam3_Internalname = "vLPGBANDAM3";
         edtavLpgbandam3_Internalname = "vLPGBANDAM3";
         div_Internalname = "";
         div_Internalname = "";
         divLpgbandam3_container_Internalname = "LPGBANDAM3_CONTAINER";
         divLpgbandam3_container_Internalname = "LPGBANDAM3_CONTAINER";
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
         lblTextblockresultadopanamax_Internalname = "TEXTBLOCKRESULTADOPANAMAX";
         lblTextblockresultadopanamax_Internalname = "TEXTBLOCKRESULTADOPANAMAX";
         lblResultadopanamax_Internalname = "RESULTADOPANAMAX";
         lblResultadopanamax_Internalname = "RESULTADOPANAMAX";
         tblTable4_Internalname = "TABLE4";
         tblTable4_Internalname = "TABLE4";
         div_Internalname = "";
         div_Internalname = "";
         lblTextblockresultadoneopanamax_Internalname = "TEXTBLOCKRESULTADONEOPANAMAX";
         lblTextblockresultadoneopanamax_Internalname = "TEXTBLOCKRESULTADONEOPANAMAX";
         lblResultadoneopanamax_Internalname = "RESULTADONEOPANAMAX";
         lblResultadoneopanamax_Internalname = "RESULTADONEOPANAMAX";
         tblTable2_Internalname = "TABLE2";
         tblTable2_Internalname = "TABLE2";
         div_Internalname = "";
         div_Internalname = "";
         lblTextblockresultadolastre_Internalname = "TEXTBLOCKRESULTADOLASTRE";
         lblTextblockresultadolastre_Internalname = "TEXTBLOCKRESULTADOLASTRE";
         lblResultadolastre_Internalname = "RESULTADOLASTRE";
         lblResultadolastre_Internalname = "RESULTADOLASTRE";
         tblTable5_Internalname = "TABLE5";
         tblTable5_Internalname = "TABLE5";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divGroup3table_Internalname = "GROUP3TABLE";
         divGroup3table_Internalname = "GROUP3TABLE";
         grpGrouptanqueroresultado_Internalname = "GROUPTANQUERORESULTADO";
         grpGrouptanqueroresultado_Internalname = "GROUPTANQUERORESULTADO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblTextblock8_Internalname = "TEXTBLOCK8";
         lblTextblock8_Internalname = "TEXTBLOCK8";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divTable1_Internalname = "TABLE1";
         divTable1_Internalname = "TABLE1";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divGroup1table_Internalname = "GROUP1TABLE";
         divGroup1table_Internalname = "GROUP1TABLE";
         grpGrouptanquerotitulo_Internalname = "GROUPTANQUEROTITULO";
         grpGrouptanquerotitulo_Internalname = "GROUPTANQUEROTITULO";
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
         lblResultadolastre_Caption = "$0.00";
         lblResultadoneopanamax_Caption = "$0.00";
         lblResultadopanamax_Caption = "$0.00";
         edtavLpgbandam3_Jsonclick = "";
         edtavLpgbandam3_Enabled = 1;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = context.GetMessage( "WCLPG", "");
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[],oparms:[]}");
         setEventMetadata("'LIMPIAR'","{handler:'E111B2',iparms:[],oparms:[{av:'AV5TanqueroBandaCPSUAB',fld:'vTANQUEROBANDACPSUAB'},{av:'AV7ValorACalcular',fld:'vVALORACALCULAR'},{av:'lblResultadopanamax_Caption',ctrl:'RESULTADOPANAMAX',prop:'Caption'},{av:'lblResultadoneopanamax_Caption',ctrl:'RESULTADONEOPANAMAX',prop:'Caption'},{av:'lblResultadolastre_Caption',ctrl:'RESULTADOLASTRE',prop:'Caption'}]}");
         setEventMetadata("'CALCULAR'","{handler:'E121B2',iparms:[{av:'AV12LPGBandaM3',fld:'vLPGBANDAM3'},{av:'AV10SdtResultado',fld:'vSDTRESULTADO'}],oparms:[{av:'AV10SdtResultado',fld:'vSDTRESULTADO'},{av:'lblResultadopanamax_Caption',ctrl:'RESULTADOPANAMAX',prop:'Caption'},{av:'lblResultadoneopanamax_Caption',ctrl:'RESULTADONEOPANAMAX',prop:'Caption'},{av:'lblResultadolastre_Caption',ctrl:'RESULTADOLASTRE',prop:'Caption'}]}");
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
         AV10SdtResultado = new SdtSdtResultado(context);
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lbllbl14_Jsonclick = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         lblTextblock8_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         WebComp_Component1_Component = "";
         GXKey = "";
         GXt_SdtSdtResultado1 = new SdtSdtResultado(context);
         sStyleString = "";
         lblTextblockresultadolastre_Jsonclick = "";
         lblResultadolastre_Jsonclick = "";
         lblTextblockresultadoneopanamax_Jsonclick = "";
         lblResultadoneopanamax_Jsonclick = "";
         lblTextblockresultadopanamax_Jsonclick = "";
         lblResultadopanamax_Jsonclick = "";
         bttCalcular_Jsonclick = "";
         bttLimpiar_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         WebComp_Component1 = new GeneXus.Http.GXNullWebComponent();
         /* GeneXus formulas. */
         context.Gx_err = 0;
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
      private int edtavLpgbandam3_Enabled ;
      private int idxLst ;
      private long AV12LPGBandaM3 ;
      private long AV5TanqueroBandaCPSUAB ;
      private decimal AV7ValorACalcular ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String grpGrouptanquerotitulo_Internalname ;
      private String divGroup1table_Internalname ;
      private String divGridtable_Internalname ;
      private String divLpgbandam3_container_Internalname ;
      private String lbllbl14_Internalname ;
      private String lbllbl14_Jsonclick ;
      private String TempTags ;
      private String edtavLpgbandam3_Internalname ;
      private String edtavLpgbandam3_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String grpGrouptanqueroresultado_Internalname ;
      private String divGroup3table_Internalname ;
      private String divTable1_Internalname ;
      private String lblTextblock8_Internalname ;
      private String lblTextblock8_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String WebComp_Component1_Component ;
      private String GXKey ;
      private String lblResultadopanamax_Caption ;
      private String lblResultadopanamax_Internalname ;
      private String lblResultadoneopanamax_Caption ;
      private String lblResultadoneopanamax_Internalname ;
      private String lblResultadolastre_Caption ;
      private String lblResultadolastre_Internalname ;
      private String bttCalcular_Internalname ;
      private String sStyleString ;
      private String tblTable5_Internalname ;
      private String lblTextblockresultadolastre_Internalname ;
      private String lblTextblockresultadolastre_Jsonclick ;
      private String lblResultadolastre_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockresultadoneopanamax_Internalname ;
      private String lblTextblockresultadoneopanamax_Jsonclick ;
      private String lblResultadoneopanamax_Jsonclick ;
      private String tblTable4_Internalname ;
      private String lblTextblockresultadopanamax_Internalname ;
      private String lblTextblockresultadopanamax_Jsonclick ;
      private String lblResultadopanamax_Jsonclick ;
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
      private bool returnInSub ;
      private GXWebComponent WebComp_Component1 ;
      private IGxDataStore dsDefault ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtSdtResultado AV10SdtResultado ;
      private SdtSdtResultado GXt_SdtSdtResultado1 ;
   }

}
