/*
               File: Gx0080
        Description: Selection List Portavehiculos y RO-RO
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 10:41:39.35
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
   public class gx0080 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0080( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public gx0080( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out short aP0_pVEH_RORO_ID )
      {
         this.AV12pVEH_RORO_ID = 0 ;
         executePrivate();
         aP0_pVEH_RORO_ID=this.AV12pVEH_RORO_ID;
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_GXsfl_74 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_74_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_74_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_GXsfl_74, nGXsfl_74_idx, sGXsfl_74_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               subGrid1_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV6cVEH_RORO_ID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cVEH_RORO_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cVEH_RORO_ID), 4, 0)));
               AV7cVEH_RORO_TON_INI = NumberUtil.Val( GetNextPar( ), ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cVEH_RORO_TON_INI", StringUtil.LTrim( StringUtil.Str( AV7cVEH_RORO_TON_INI, 10, 2)));
               AV8cVEH_RORO_TON_FIN = NumberUtil.Val( GetNextPar( ), ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cVEH_RORO_TON_FIN", StringUtil.LTrim( StringUtil.Str( AV8cVEH_RORO_TON_FIN, 10, 2)));
               AV9cVEH_RORO_UTIL_INI = NumberUtil.Val( GetNextPar( ), ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cVEH_RORO_UTIL_INI", StringUtil.LTrim( StringUtil.Str( AV9cVEH_RORO_UTIL_INI, 10, 2)));
               AV10cVEH_RORO_UTIL_FIN = NumberUtil.Val( GetNextPar( ), ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cVEH_RORO_UTIL_FIN", StringUtil.LTrim( StringUtil.Str( AV10cVEH_RORO_UTIL_FIN, 10, 2)));
               AV11cVEH_RORO_TARIFA = NumberUtil.Val( GetNextPar( ), ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cVEH_RORO_TARIFA", StringUtil.LTrim( StringUtil.Str( AV11cVEH_RORO_TARIFA, 10, 2)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cVEH_RORO_ID, AV7cVEH_RORO_TON_INI, AV8cVEH_RORO_TON_FIN, AV9cVEH_RORO_UTIL_INI, AV10cVEH_RORO_UTIL_FIN, AV11cVEH_RORO_TARIFA) ;
               context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               return  ;
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
            if ( ! entryPointCalled )
            {
               AV12pVEH_RORO_ID = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pVEH_RORO_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pVEH_RORO_ID), 4, 0)));
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdpromptmasterpage", "GeneXus.Programs.rwdpromptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,true);
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
         PA1N2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1N2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201512010413938");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0080.aspx") + "?" + UrlEncode("" +AV12pVEH_RORO_ID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCVEH_RORO_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cVEH_RORO_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCVEH_RORO_TON_INI", StringUtil.LTrim( StringUtil.NToC( AV7cVEH_RORO_TON_INI, 10, 2, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCVEH_RORO_TON_FIN", StringUtil.LTrim( StringUtil.NToC( AV8cVEH_RORO_TON_FIN, 10, 2, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCVEH_RORO_UTIL_INI", StringUtil.LTrim( StringUtil.NToC( AV9cVEH_RORO_UTIL_INI, 10, 2, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCVEH_RORO_UTIL_FIN", StringUtil.LTrim( StringUtil.NToC( AV10cVEH_RORO_UTIL_FIN, 10, 2, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCVEH_RORO_TARIFA", StringUtil.LTrim( StringUtil.NToC( AV11cVEH_RORO_TARIFA, 10, 2, context.GetLanguageProperty( "decimal_point"), "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_74", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_74), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "vPVEH_RORO_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12pVEH_RORO_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "VEH_RORO_IDFILTERCONTAINER_Class", StringUtil.RTrim( divVeh_roro_idfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "VEH_RORO_TON_INIFILTERCONTAINER_Class", StringUtil.RTrim( divVeh_roro_ton_inifiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "VEH_RORO_TON_FINFILTERCONTAINER_Class", StringUtil.RTrim( divVeh_roro_ton_finfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "VEH_RORO_UTIL_INIFILTERCONTAINER_Class", StringUtil.RTrim( divVeh_roro_util_inifiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "VEH_RORO_UTIL_FINFILTERCONTAINER_Class", StringUtil.RTrim( divVeh_roro_util_finfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "VEH_RORO_TARIFAFILTERCONTAINER_Class", StringUtil.RTrim( divVeh_roro_tarifafiltercontainer_Class));
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
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", "notset");
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
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE1N2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1N2( ) ;
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
         return formatLink("gx0080.aspx") + "?" + UrlEncode("" +AV12pVEH_RORO_ID) ;
      }

      public override String GetPgmname( )
      {
         return "gx0080" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "Selection List Portavehiculos y RO-RO", "") ;
      }

      protected void WB1N0( )
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
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", " "+"data-abstract-form"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMain_Internalname, 1, 0, "px", 0, "px", "ContainerFluid PromptContainer", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-3 PromptAdvancedBarCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAdvancedcontainer_Internalname, 1, 0, "px", 0, "px", divAdvancedcontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divVeh_roro_idfiltercontainer_Internalname, 1, 0, "px", 0, "px", divVeh_roro_idfiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblveh_roro_idfilter_Internalname, context.GetMessage( "Identificador unico de la tabla", ""), "", "", lblLblveh_roro_idfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e111n1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0080.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 WWFiltersCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCveh_roro_id_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cVEH_RORO_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCveh_roro_id_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cVEH_RORO_ID), "ZZZ9")) : context.localUtil.Format( (decimal)(AV6cVEH_RORO_ID), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCveh_roro_id_Jsonclick, 0, "Attribute", "", "", "", edtavCveh_roro_id_Visible, edtavCveh_roro_id_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx0080.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divVeh_roro_ton_inifiltercontainer_Internalname, 1, 0, "px", 0, "px", divVeh_roro_ton_inifiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblveh_roro_ton_inifilter_Internalname, context.GetMessage( "Rango inicial de las toneladas", ""), "", "", lblLblveh_roro_ton_inifilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e121n1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0080.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 WWFiltersCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCveh_roro_ton_ini_Internalname, StringUtil.LTrim( StringUtil.NToC( AV7cVEH_RORO_TON_INI, 10, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCveh_roro_ton_ini_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV7cVEH_RORO_TON_INI, "ZZZZZZ9.99")) : context.localUtil.Format( AV7cVEH_RORO_TON_INI, "ZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCveh_roro_ton_ini_Jsonclick, 0, "Attribute", "", "", "", edtavCveh_roro_ton_ini_Visible, edtavCveh_roro_ton_ini_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx0080.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divVeh_roro_ton_finfiltercontainer_Internalname, 1, 0, "px", 0, "px", divVeh_roro_ton_finfiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblveh_roro_ton_finfilter_Internalname, context.GetMessage( "Rango final de las toneladas", ""), "", "", lblLblveh_roro_ton_finfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e131n1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0080.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 WWFiltersCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCveh_roro_ton_fin_Internalname, StringUtil.LTrim( StringUtil.NToC( AV8cVEH_RORO_TON_FIN, 10, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCveh_roro_ton_fin_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV8cVEH_RORO_TON_FIN, "ZZZZZZ9.99")) : context.localUtil.Format( AV8cVEH_RORO_TON_FIN, "ZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCveh_roro_ton_fin_Jsonclick, 0, "Attribute", "", "", "", edtavCveh_roro_ton_fin_Visible, edtavCveh_roro_ton_fin_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx0080.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divVeh_roro_util_inifiltercontainer_Internalname, 1, 0, "px", 0, "px", divVeh_roro_util_inifiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblveh_roro_util_inifilter_Internalname, context.GetMessage( "Rango porcentual inicial de utlizacion del buque", ""), "", "", lblLblveh_roro_util_inifilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e141n1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0080.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 WWFiltersCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCveh_roro_util_ini_Internalname, StringUtil.LTrim( StringUtil.NToC( AV9cVEH_RORO_UTIL_INI, 10, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCveh_roro_util_ini_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV9cVEH_RORO_UTIL_INI, "ZZZZZZ9.99")) : context.localUtil.Format( AV9cVEH_RORO_UTIL_INI, "ZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCveh_roro_util_ini_Jsonclick, 0, "Attribute", "", "", "", edtavCveh_roro_util_ini_Visible, edtavCveh_roro_util_ini_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx0080.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divVeh_roro_util_finfiltercontainer_Internalname, 1, 0, "px", 0, "px", divVeh_roro_util_finfiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblveh_roro_util_finfilter_Internalname, context.GetMessage( "Rango porcentual final de utlizacion del buque", ""), "", "", lblLblveh_roro_util_finfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e151n1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0080.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 WWFiltersCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCveh_roro_util_fin_Internalname, StringUtil.LTrim( StringUtil.NToC( AV10cVEH_RORO_UTIL_FIN, 10, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCveh_roro_util_fin_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV10cVEH_RORO_UTIL_FIN, "ZZZZZZ9.99")) : context.localUtil.Format( AV10cVEH_RORO_UTIL_FIN, "ZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCveh_roro_util_fin_Jsonclick, 0, "Attribute", "", "", "", edtavCveh_roro_util_fin_Visible, edtavCveh_roro_util_fin_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx0080.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divVeh_roro_tarifafiltercontainer_Internalname, 1, 0, "px", 0, "px", divVeh_roro_tarifafiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblveh_roro_tarifafilter_Internalname, context.GetMessage( "Tarifa de cobro", ""), "", "", lblLblveh_roro_tarifafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e161n1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0080.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 WWFiltersCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_74_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCveh_roro_tarifa_Internalname, StringUtil.LTrim( StringUtil.NToC( AV11cVEH_RORO_TARIFA, 10, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCveh_roro_tarifa_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV11cVEH_RORO_TARIFA, "ZZZZZZ9.99")) : context.localUtil.Format( AV11cVEH_RORO_TARIFA, "ZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCveh_roro_tarifa_Jsonclick, 0, "Attribute", "", "", "", edtavCveh_roro_tarifa_Visible, edtavCveh_roro_tarifa_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx0080.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 WWGridCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtable_Internalname, 1, 0, "px", 0, "px", "Table", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-sm hidden-md hidden-lg ToggleCell", " "+"id"+" ");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e171n1_client"+"'", TempTags, "", 2, "HLP_Gx0080.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" gxgridid=\"74\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "PromptGrid", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title";
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "ID", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Rango Inicial TON", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Rango Final TON", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tarifa", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               Grid1Container.AddObjectProperty("GridName", "Grid1");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  Grid1Container = new GXWebGrid( context);
               }
               else
               {
                  Grid1Container.Clear();
               }
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Class", "PromptGrid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5LinkSelection));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A38VEH_RORO_ID), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A39VEH_RORO_TON_INI, 10, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A40VEH_RORO_TON_FIN, 10, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A43VEH_RORO_TARIFA, 10, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 74 )
         {
            wbEnd = 0;
            nRC_GXsfl_74 = (short)(nGXsfl_74_idx-1);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
               sStyleString = " style=\"display:none;\"";
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", Grid1Container);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
               }
            }
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", context.GetMessage( "GX_BtnCancel", ""), bttBtn_cancel_Jsonclick, 1, context.GetMessage( "GX_BtnCancel", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0080.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
         }
         wbLoad = true;
      }

      protected void START1N2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_2-86442", 0) ;
            Form.Meta.addItem("description", context.GetMessage( "Selection List Portavehiculos y RO-RO", ""), 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1N0( ) ;
      }

      protected void WS1N2( )
      {
         START1N2( ) ;
         EVT1N2( ) ;
      }

      protected void EVT1N2( )
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
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                           {
                              context.wbHandled = 1;
                              sEvt = cgiGet( "GRID1PAGING");
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid1_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid1_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid1_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid1_lastpage( ) ;
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                           {
                              nGXsfl_74_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
                              edtVEH_RORO_ID_Internalname = "VEH_RORO_ID_"+sGXsfl_74_idx;
                              edtVEH_RORO_TON_INI_Internalname = "VEH_RORO_TON_INI_"+sGXsfl_74_idx;
                              edtVEH_RORO_TON_FIN_Internalname = "VEH_RORO_TON_FIN_"+sGXsfl_74_idx;
                              edtVEH_RORO_TARIFA_Internalname = "VEH_RORO_TARIFA_"+sGXsfl_74_idx;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV16Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))));
                              A38VEH_RORO_ID = (short)(context.localUtil.CToN( cgiGet( edtVEH_RORO_ID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtVEH_RORO_ID_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A38VEH_RORO_ID), 4, 0)));
                              A39VEH_RORO_TON_INI = context.localUtil.CToN( cgiGet( edtVEH_RORO_TON_INI_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtVEH_RORO_TON_INI_Internalname, StringUtil.LTrim( StringUtil.Str( A39VEH_RORO_TON_INI, 10, 2)));
                              A40VEH_RORO_TON_FIN = context.localUtil.CToN( cgiGet( edtVEH_RORO_TON_FIN_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtVEH_RORO_TON_FIN_Internalname, StringUtil.LTrim( StringUtil.Str( A40VEH_RORO_TON_FIN, 10, 2)));
                              A43VEH_RORO_TARIFA = context.localUtil.CToN( cgiGet( edtVEH_RORO_TARIFA_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtVEH_RORO_TARIFA_Internalname, StringUtil.LTrim( StringUtil.Str( A43VEH_RORO_TARIFA, 10, 2)));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E181N2 */
                                    E181N2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E191N2 */
                                    E191N2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cveh_roro_id Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCVEH_RORO_ID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV6cVEH_RORO_ID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cveh_roro_ton_ini Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCVEH_RORO_TON_INI"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV7cVEH_RORO_TON_INI )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cveh_roro_ton_fin Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCVEH_RORO_TON_FIN"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV8cVEH_RORO_TON_FIN )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cveh_roro_util_ini Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCVEH_RORO_UTIL_INI"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV9cVEH_RORO_UTIL_INI )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cveh_roro_util_fin Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCVEH_RORO_UTIL_FIN"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV10cVEH_RORO_UTIL_FIN )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cveh_roro_tarifa Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCVEH_RORO_TARIFA"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV11cVEH_RORO_TARIFA )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E201N2 */
                                          E201N2 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE1N2( )
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

      protected void PA1N2( )
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
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_GXsfl_74 ,
                                       short nGXsfl_74_idx ,
                                       String sGXsfl_74_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
         edtVEH_RORO_ID_Internalname = "VEH_RORO_ID_"+sGXsfl_74_idx;
         edtVEH_RORO_TON_INI_Internalname = "VEH_RORO_TON_INI_"+sGXsfl_74_idx;
         edtVEH_RORO_TON_FIN_Internalname = "VEH_RORO_TON_FIN_"+sGXsfl_74_idx;
         edtVEH_RORO_TARIFA_Internalname = "VEH_RORO_TARIFA_"+sGXsfl_74_idx;
         while ( nGXsfl_74_idx <= nRC_GXsfl_74 )
         {
            sendrow_742( ) ;
            nGXsfl_74_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1));
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
            edtVEH_RORO_ID_Internalname = "VEH_RORO_ID_"+sGXsfl_74_idx;
            edtVEH_RORO_TON_INI_Internalname = "VEH_RORO_TON_INI_"+sGXsfl_74_idx;
            edtVEH_RORO_TON_FIN_Internalname = "VEH_RORO_TON_FIN_"+sGXsfl_74_idx;
            edtVEH_RORO_TARIFA_Internalname = "VEH_RORO_TARIFA_"+sGXsfl_74_idx;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        short AV6cVEH_RORO_ID ,
                                        decimal AV7cVEH_RORO_TON_INI ,
                                        decimal AV8cVEH_RORO_TON_FIN ,
                                        decimal AV9cVEH_RORO_UTIL_INI ,
                                        decimal AV10cVEH_RORO_UTIL_FIN ,
                                        decimal AV11cVEH_RORO_TARIFA )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         RF1N2( ) ;
         context.GX_msglist = BackMsgLst;
         /* End function gxgrGrid1_refresh */
      }

      public void Refresh( )
      {
         RF1N2( ) ;
      }

      protected void RF1N2( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         Grid1Container.AddObjectProperty("GridName", "Grid1");
         Grid1Container.AddObjectProperty("CmpContext", "");
         Grid1Container.AddObjectProperty("InMasterPage", "false");
         wbStart = 74;
         nGXsfl_74_idx = 1;
         sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
         edtVEH_RORO_ID_Internalname = "VEH_RORO_ID_"+sGXsfl_74_idx;
         edtVEH_RORO_TON_INI_Internalname = "VEH_RORO_TON_INI_"+sGXsfl_74_idx;
         edtVEH_RORO_TON_FIN_Internalname = "VEH_RORO_TON_FIN_"+sGXsfl_74_idx;
         edtVEH_RORO_TARIFA_Internalname = "VEH_RORO_TARIFA_"+sGXsfl_74_idx;
         nGXsfl_74_Refreshing = 1;
         Grid1Container.PageSize = subGrid1_Recordsperpage( );
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
            edtVEH_RORO_ID_Internalname = "VEH_RORO_ID_"+sGXsfl_74_idx;
            edtVEH_RORO_TON_INI_Internalname = "VEH_RORO_TON_INI_"+sGXsfl_74_idx;
            edtVEH_RORO_TON_FIN_Internalname = "VEH_RORO_TON_FIN_"+sGXsfl_74_idx;
            edtVEH_RORO_TARIFA_Internalname = "VEH_RORO_TARIFA_"+sGXsfl_74_idx;
            GXPagingFrom2 = (int)(((10==0) ? 1 : GRID1_nFirstRecordOnPage+1));
            GXPagingTo2 = ((10==0) ? 10000 : GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7cVEH_RORO_TON_INI ,
                                                 AV8cVEH_RORO_TON_FIN ,
                                                 AV9cVEH_RORO_UTIL_INI ,
                                                 AV10cVEH_RORO_UTIL_FIN ,
                                                 AV11cVEH_RORO_TARIFA ,
                                                 A39VEH_RORO_TON_INI ,
                                                 A40VEH_RORO_TON_FIN ,
                                                 A41VEH_RORO_UTIL_INI ,
                                                 A42VEH_RORO_UTIL_FIN ,
                                                 A43VEH_RORO_TARIFA ,
                                                 AV6cVEH_RORO_ID },
                                                 new int[] {
                                                 TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL,
                                                 TypeConstants.SHORT
                                                 }
            });
            /* Using cursor H001N2 */
            pr_default.execute(0, new Object[] {AV6cVEH_RORO_ID, AV7cVEH_RORO_TON_INI, AV8cVEH_RORO_TON_FIN, AV9cVEH_RORO_UTIL_INI, AV10cVEH_RORO_UTIL_FIN, AV11cVEH_RORO_TARIFA, GXPagingFrom2, GXPagingTo2, GXPagingTo2, GXPagingFrom2, GXPagingFrom2});
            nGXsfl_74_idx = 1;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A42VEH_RORO_UTIL_FIN = H001N2_A42VEH_RORO_UTIL_FIN[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42VEH_RORO_UTIL_FIN", StringUtil.LTrim( StringUtil.Str( A42VEH_RORO_UTIL_FIN, 10, 2)));
               A41VEH_RORO_UTIL_INI = H001N2_A41VEH_RORO_UTIL_INI[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41VEH_RORO_UTIL_INI", StringUtil.LTrim( StringUtil.Str( A41VEH_RORO_UTIL_INI, 10, 2)));
               A43VEH_RORO_TARIFA = H001N2_A43VEH_RORO_TARIFA[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtVEH_RORO_TARIFA_Internalname, StringUtil.LTrim( StringUtil.Str( A43VEH_RORO_TARIFA, 10, 2)));
               A40VEH_RORO_TON_FIN = H001N2_A40VEH_RORO_TON_FIN[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtVEH_RORO_TON_FIN_Internalname, StringUtil.LTrim( StringUtil.Str( A40VEH_RORO_TON_FIN, 10, 2)));
               A39VEH_RORO_TON_INI = H001N2_A39VEH_RORO_TON_INI[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtVEH_RORO_TON_INI_Internalname, StringUtil.LTrim( StringUtil.Str( A39VEH_RORO_TON_INI, 10, 2)));
               A38VEH_RORO_ID = H001N2_A38VEH_RORO_ID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtVEH_RORO_ID_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A38VEH_RORO_ID), 4, 0)));
               /* Execute user event: E191N2 */
               E191N2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 74;
            WB1N0( ) ;
         }
         nGXsfl_74_Refreshing = 0;
      }

      protected int subGrid1_Pagecount( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( );
         if ( ((int)((GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV7cVEH_RORO_TON_INI ,
                                              AV8cVEH_RORO_TON_FIN ,
                                              AV9cVEH_RORO_UTIL_INI ,
                                              AV10cVEH_RORO_UTIL_FIN ,
                                              AV11cVEH_RORO_TARIFA ,
                                              A39VEH_RORO_TON_INI ,
                                              A40VEH_RORO_TON_FIN ,
                                              A41VEH_RORO_UTIL_INI ,
                                              A42VEH_RORO_UTIL_FIN ,
                                              A43VEH_RORO_TARIFA ,
                                              AV6cVEH_RORO_ID },
                                              new int[] {
                                              TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL,
                                              TypeConstants.SHORT
                                              }
         });
         /* Using cursor H001N3 */
         pr_default.execute(1, new Object[] {AV6cVEH_RORO_ID, AV7cVEH_RORO_TON_INI, AV8cVEH_RORO_TON_FIN, AV9cVEH_RORO_UTIL_INI, AV10cVEH_RORO_UTIL_FIN, AV11cVEH_RORO_TARIFA});
         GRID1_nRecordCount = H001N3_AGRID1_nRecordCount[0];
         pr_default.close(1);
         return (int)(GRID1_nRecordCount) ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         return (int)(10*1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID1_nFirstRecordOnPage/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cVEH_RORO_ID, AV7cVEH_RORO_TON_INI, AV8cVEH_RORO_TON_FIN, AV9cVEH_RORO_UTIL_INI, AV10cVEH_RORO_UTIL_FIN, AV11cVEH_RORO_TARIFA) ;
         }
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( );
         if ( ( GRID1_nRecordCount >= subGrid1_Recordsperpage( ) ) && ( GRID1_nEOF == 0 ) )
         {
            GRID1_nFirstRecordOnPage = (long)(GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cVEH_RORO_ID, AV7cVEH_RORO_TON_INI, AV8cVEH_RORO_TON_FIN, AV9cVEH_RORO_UTIL_INI, AV10cVEH_RORO_UTIL_FIN, AV11cVEH_RORO_TARIFA) ;
         }
         return 0 ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( GRID1_nFirstRecordOnPage >= subGrid1_Recordsperpage( ) )
         {
            GRID1_nFirstRecordOnPage = (long)(GRID1_nFirstRecordOnPage-subGrid1_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cVEH_RORO_ID, AV7cVEH_RORO_TON_INI, AV8cVEH_RORO_TON_FIN, AV9cVEH_RORO_UTIL_INI, AV10cVEH_RORO_UTIL_FIN, AV11cVEH_RORO_TARIFA) ;
         }
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( );
         if ( GRID1_nRecordCount > subGrid1_Recordsperpage( ) )
         {
            if ( ((int)((GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) == 0 )
            {
               GRID1_nFirstRecordOnPage = (long)(GRID1_nRecordCount-subGrid1_Recordsperpage( ));
            }
            else
            {
               GRID1_nFirstRecordOnPage = (long)(GRID1_nRecordCount-((int)((GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))));
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cVEH_RORO_ID, AV7cVEH_RORO_TON_INI, AV8cVEH_RORO_TON_FIN, AV9cVEH_RORO_UTIL_INI, AV10cVEH_RORO_UTIL_FIN, AV11cVEH_RORO_TARIFA) ;
         }
         return 0 ;
      }

      protected int subgrid1_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID1_nFirstRecordOnPage = (long)(subGrid1_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cVEH_RORO_ID, AV7cVEH_RORO_TON_INI, AV8cVEH_RORO_TON_FIN, AV9cVEH_RORO_UTIL_INI, AV10cVEH_RORO_UTIL_FIN, AV11cVEH_RORO_TARIFA) ;
         }
         return (int)(0) ;
      }

      protected void STRUP1N0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E181N2 */
         E181N2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCveh_roro_id_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCveh_roro_id_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCVEH_RORO_ID");
               GX_FocusControl = edtavCveh_roro_id_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cVEH_RORO_ID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cVEH_RORO_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cVEH_RORO_ID), 4, 0)));
            }
            else
            {
               AV6cVEH_RORO_ID = (short)(context.localUtil.CToN( cgiGet( edtavCveh_roro_id_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cVEH_RORO_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cVEH_RORO_ID), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCveh_roro_ton_ini_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCveh_roro_ton_ini_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 9999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCVEH_RORO_TON_INI");
               GX_FocusControl = edtavCveh_roro_ton_ini_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7cVEH_RORO_TON_INI = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cVEH_RORO_TON_INI", StringUtil.LTrim( StringUtil.Str( AV7cVEH_RORO_TON_INI, 10, 2)));
            }
            else
            {
               AV7cVEH_RORO_TON_INI = context.localUtil.CToN( cgiGet( edtavCveh_roro_ton_ini_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cVEH_RORO_TON_INI", StringUtil.LTrim( StringUtil.Str( AV7cVEH_RORO_TON_INI, 10, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCveh_roro_ton_fin_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCveh_roro_ton_fin_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 9999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCVEH_RORO_TON_FIN");
               GX_FocusControl = edtavCveh_roro_ton_fin_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8cVEH_RORO_TON_FIN = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cVEH_RORO_TON_FIN", StringUtil.LTrim( StringUtil.Str( AV8cVEH_RORO_TON_FIN, 10, 2)));
            }
            else
            {
               AV8cVEH_RORO_TON_FIN = context.localUtil.CToN( cgiGet( edtavCveh_roro_ton_fin_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cVEH_RORO_TON_FIN", StringUtil.LTrim( StringUtil.Str( AV8cVEH_RORO_TON_FIN, 10, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCveh_roro_util_ini_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCveh_roro_util_ini_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 9999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCVEH_RORO_UTIL_INI");
               GX_FocusControl = edtavCveh_roro_util_ini_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9cVEH_RORO_UTIL_INI = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cVEH_RORO_UTIL_INI", StringUtil.LTrim( StringUtil.Str( AV9cVEH_RORO_UTIL_INI, 10, 2)));
            }
            else
            {
               AV9cVEH_RORO_UTIL_INI = context.localUtil.CToN( cgiGet( edtavCveh_roro_util_ini_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cVEH_RORO_UTIL_INI", StringUtil.LTrim( StringUtil.Str( AV9cVEH_RORO_UTIL_INI, 10, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCveh_roro_util_fin_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCveh_roro_util_fin_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 9999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCVEH_RORO_UTIL_FIN");
               GX_FocusControl = edtavCveh_roro_util_fin_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10cVEH_RORO_UTIL_FIN = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cVEH_RORO_UTIL_FIN", StringUtil.LTrim( StringUtil.Str( AV10cVEH_RORO_UTIL_FIN, 10, 2)));
            }
            else
            {
               AV10cVEH_RORO_UTIL_FIN = context.localUtil.CToN( cgiGet( edtavCveh_roro_util_fin_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cVEH_RORO_UTIL_FIN", StringUtil.LTrim( StringUtil.Str( AV10cVEH_RORO_UTIL_FIN, 10, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCveh_roro_tarifa_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCveh_roro_tarifa_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 9999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCVEH_RORO_TARIFA");
               GX_FocusControl = edtavCveh_roro_tarifa_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11cVEH_RORO_TARIFA = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cVEH_RORO_TARIFA", StringUtil.LTrim( StringUtil.Str( AV11cVEH_RORO_TARIFA, 10, 2)));
            }
            else
            {
               AV11cVEH_RORO_TARIFA = context.localUtil.CToN( cgiGet( edtavCveh_roro_tarifa_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cVEH_RORO_TARIFA", StringUtil.LTrim( StringUtil.Str( AV11cVEH_RORO_TARIFA, 10, 2)));
            }
            /* Read saved values. */
            nRC_GXsfl_74 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_74"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            AV12pVEH_RORO_ID = (short)(context.localUtil.CToN( cgiGet( "vPVEH_RORO_ID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCVEH_RORO_ID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV6cVEH_RORO_ID )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vCVEH_RORO_TON_INI"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV7cVEH_RORO_TON_INI )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vCVEH_RORO_TON_FIN"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV8cVEH_RORO_TON_FIN )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vCVEH_RORO_UTIL_INI"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV9cVEH_RORO_UTIL_INI )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vCVEH_RORO_UTIL_FIN"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV10cVEH_RORO_UTIL_FIN )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vCVEH_RORO_TARIFA"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV11cVEH_RORO_TARIFA )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E181N2 */
         E181N2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E181N2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( context.GetMessage( "GXSPC_SelectionList", ""), context.GetMessage( "Portavehiculos y RO-RO", ""), "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
         AV13ADVANCED_LABEL_TEMPLATE = context.GetMessage( "%1 <strong>%2</strong>", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ADVANCED_LABEL_TEMPLATE", AV13ADVANCED_LABEL_TEMPLATE);
      }

      private void E191N2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV16Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))));
         AV16Linkselection_GXI = GeneXus.Utils.GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV16Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))));
         sendrow_742( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ( nGXsfl_74_Refreshing == 0 ) )
         {
            context.DoAjaxLoad(74, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: E201N2 */
         E201N2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E201N2( )
      {
         /* Enter Routine */
         AV12pVEH_RORO_ID = A38VEH_RORO_ID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pVEH_RORO_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pVEH_RORO_ID), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV12pVEH_RORO_ID});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12pVEH_RORO_ID = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pVEH_RORO_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pVEH_RORO_ID), 4, 0)));
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
         PA1N2( ) ;
         WS1N2( ) ;
         WE1N2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?10412851");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20151201041405");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages."+context.GetLanguageProperty( "code")+".js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("gx0080.js", "?20151201041405");
         /* End function include_jscripts */
      }

      protected void sendrow_742( )
      {
         sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
         edtVEH_RORO_ID_Internalname = "VEH_RORO_ID_"+sGXsfl_74_idx;
         edtVEH_RORO_TON_INI_Internalname = "VEH_RORO_TON_INI_"+sGXsfl_74_idx;
         edtVEH_RORO_TON_FIN_Internalname = "VEH_RORO_TON_FIN_"+sGXsfl_74_idx;
         edtVEH_RORO_TARIFA_Internalname = "VEH_RORO_TARIFA_"+sGXsfl_74_idx;
         WB1N0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_74_idx <= subGrid1_Recordsperpage( ) * 1 ) )
         {
            Grid1Row = GXWebRow.GetNew(context,Grid1Container);
            if ( subGrid1_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid1_Backstyle = 0;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
            }
            else if ( subGrid1_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid1_Backstyle = 0;
               subGrid1_Backcolor = subGrid1_Allbackcolor;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Uniform";
               }
            }
            else if ( subGrid1_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid1_Backstyle = 1;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
               subGrid1_Backcolor = (int)(0x0);
            }
            else if ( subGrid1_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1;
               if ( ((int)((nGXsfl_74_idx) % (2))) == 0 )
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Even";
                  }
               }
               else
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Odd";
                  }
               }
            }
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+subGrid1_Linesclass+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_74_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A38VEH_RORO_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV16Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV16Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection)),(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"''",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVEH_RORO_ID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A38VEH_RORO_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( (decimal)(A38VEH_RORO_ID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVEH_RORO_ID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)1,(short)0,(bool)true,(String)"",(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVEH_RORO_TON_INI_Internalname,StringUtil.LTrim( StringUtil.NToC( A39VEH_RORO_TON_INI, 10, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A39VEH_RORO_TON_INI, "ZZZZZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVEH_RORO_TON_INI_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)74,(short)1,(short)1,(short)0,(bool)true,(String)"",(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVEH_RORO_TON_FIN_Internalname,StringUtil.LTrim( StringUtil.NToC( A40VEH_RORO_TON_FIN, 10, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A40VEH_RORO_TON_FIN, "ZZZZZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVEH_RORO_TON_FIN_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)74,(short)1,(short)1,(short)0,(bool)true,(String)"",(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtVEH_RORO_TARIFA_Internalname,StringUtil.LTrim( StringUtil.NToC( A43VEH_RORO_TARIFA, 10, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A43VEH_RORO_TARIFA, "ZZZZZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtVEH_RORO_TARIFA_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)74,(short)1,(short)1,(short)0,(bool)true,(String)"",(String)"right"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_74_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1));
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
            edtVEH_RORO_ID_Internalname = "VEH_RORO_ID_"+sGXsfl_74_idx;
            edtVEH_RORO_TON_INI_Internalname = "VEH_RORO_TON_INI_"+sGXsfl_74_idx;
            edtVEH_RORO_TON_FIN_Internalname = "VEH_RORO_TON_FIN_"+sGXsfl_74_idx;
            edtVEH_RORO_TARIFA_Internalname = "VEH_RORO_TARIFA_"+sGXsfl_74_idx;
         }
         /* End function sendrow_742 */
      }

      protected void init_default_properties( )
      {
         lblLblveh_roro_idfilter_Internalname = "LBLVEH_RORO_IDFILTER";
         lblLblveh_roro_idfilter_Internalname = "LBLVEH_RORO_IDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCveh_roro_id_Internalname = "vCVEH_RORO_ID";
         edtavCveh_roro_id_Internalname = "vCVEH_RORO_ID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divVeh_roro_idfiltercontainer_Internalname = "VEH_RORO_IDFILTERCONTAINER";
         divVeh_roro_idfiltercontainer_Internalname = "VEH_RORO_IDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLblveh_roro_ton_inifilter_Internalname = "LBLVEH_RORO_TON_INIFILTER";
         lblLblveh_roro_ton_inifilter_Internalname = "LBLVEH_RORO_TON_INIFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCveh_roro_ton_ini_Internalname = "vCVEH_RORO_TON_INI";
         edtavCveh_roro_ton_ini_Internalname = "vCVEH_RORO_TON_INI";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divVeh_roro_ton_inifiltercontainer_Internalname = "VEH_RORO_TON_INIFILTERCONTAINER";
         divVeh_roro_ton_inifiltercontainer_Internalname = "VEH_RORO_TON_INIFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLblveh_roro_ton_finfilter_Internalname = "LBLVEH_RORO_TON_FINFILTER";
         lblLblveh_roro_ton_finfilter_Internalname = "LBLVEH_RORO_TON_FINFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCveh_roro_ton_fin_Internalname = "vCVEH_RORO_TON_FIN";
         edtavCveh_roro_ton_fin_Internalname = "vCVEH_RORO_TON_FIN";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divVeh_roro_ton_finfiltercontainer_Internalname = "VEH_RORO_TON_FINFILTERCONTAINER";
         divVeh_roro_ton_finfiltercontainer_Internalname = "VEH_RORO_TON_FINFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLblveh_roro_util_inifilter_Internalname = "LBLVEH_RORO_UTIL_INIFILTER";
         lblLblveh_roro_util_inifilter_Internalname = "LBLVEH_RORO_UTIL_INIFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCveh_roro_util_ini_Internalname = "vCVEH_RORO_UTIL_INI";
         edtavCveh_roro_util_ini_Internalname = "vCVEH_RORO_UTIL_INI";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divVeh_roro_util_inifiltercontainer_Internalname = "VEH_RORO_UTIL_INIFILTERCONTAINER";
         divVeh_roro_util_inifiltercontainer_Internalname = "VEH_RORO_UTIL_INIFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLblveh_roro_util_finfilter_Internalname = "LBLVEH_RORO_UTIL_FINFILTER";
         lblLblveh_roro_util_finfilter_Internalname = "LBLVEH_RORO_UTIL_FINFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCveh_roro_util_fin_Internalname = "vCVEH_RORO_UTIL_FIN";
         edtavCveh_roro_util_fin_Internalname = "vCVEH_RORO_UTIL_FIN";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divVeh_roro_util_finfiltercontainer_Internalname = "VEH_RORO_UTIL_FINFILTERCONTAINER";
         divVeh_roro_util_finfiltercontainer_Internalname = "VEH_RORO_UTIL_FINFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLblveh_roro_tarifafilter_Internalname = "LBLVEH_RORO_TARIFAFILTER";
         lblLblveh_roro_tarifafilter_Internalname = "LBLVEH_RORO_TARIFAFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCveh_roro_tarifa_Internalname = "vCVEH_RORO_TARIFA";
         edtavCveh_roro_tarifa_Internalname = "vCVEH_RORO_TARIFA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divVeh_roro_tarifafiltercontainer_Internalname = "VEH_RORO_TARIFAFILTERCONTAINER";
         divVeh_roro_tarifafiltercontainer_Internalname = "VEH_RORO_TARIFAFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtVEH_RORO_ID_Internalname = "VEH_RORO_ID";
         edtVEH_RORO_TON_INI_Internalname = "VEH_RORO_TON_INI";
         edtVEH_RORO_TON_FIN_Internalname = "VEH_RORO_TON_FIN";
         edtVEH_RORO_TARIFA_Internalname = "VEH_RORO_TARIFA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
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
         divMain_Internalname = "MAIN";
         divMain_Internalname = "MAIN";
         div_Internalname = "";
         div_Internalname = "";
         Form.Internalname = "FORM";
         Form.Internalname = "FORM";
         subGrid1_Internalname = "GRID1";
         subGrid1_Internalname = "GRID1";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtVEH_RORO_TARIFA_Jsonclick = "";
         edtVEH_RORO_TON_FIN_Jsonclick = "";
         edtVEH_RORO_TON_INI_Jsonclick = "";
         edtVEH_RORO_ID_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCveh_roro_tarifa_Jsonclick = "";
         edtavCveh_roro_tarifa_Enabled = 1;
         edtavCveh_roro_tarifa_Visible = 1;
         edtavCveh_roro_util_fin_Jsonclick = "";
         edtavCveh_roro_util_fin_Enabled = 1;
         edtavCveh_roro_util_fin_Visible = 1;
         edtavCveh_roro_util_ini_Jsonclick = "";
         edtavCveh_roro_util_ini_Enabled = 1;
         edtavCveh_roro_util_ini_Visible = 1;
         edtavCveh_roro_ton_fin_Jsonclick = "";
         edtavCveh_roro_ton_fin_Enabled = 1;
         edtavCveh_roro_ton_fin_Visible = 1;
         edtavCveh_roro_ton_ini_Jsonclick = "";
         edtavCveh_roro_ton_ini_Enabled = 1;
         edtavCveh_roro_ton_ini_Visible = 1;
         edtavCveh_roro_id_Jsonclick = "";
         edtavCveh_roro_id_Enabled = 1;
         edtavCveh_roro_id_Visible = 1;
         divVeh_roro_tarifafiltercontainer_Class = "AdvancedContainerItem";
         divVeh_roro_util_finfiltercontainer_Class = "AdvancedContainerItem";
         divVeh_roro_util_inifiltercontainer_Class = "AdvancedContainerItem";
         divVeh_roro_ton_finfiltercontainer_Class = "AdvancedContainerItem";
         divVeh_roro_ton_inifiltercontainer_Class = "AdvancedContainerItem";
         divVeh_roro_idfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainer";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = context.GetMessage( "Selection List Portavehiculos y RO-RO", "");
         subGrid1_Rows = 10;
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cVEH_RORO_ID',fld:'vCVEH_RORO_ID'},{av:'AV7cVEH_RORO_TON_INI',fld:'vCVEH_RORO_TON_INI'},{av:'AV8cVEH_RORO_TON_FIN',fld:'vCVEH_RORO_TON_FIN'},{av:'AV9cVEH_RORO_UTIL_INI',fld:'vCVEH_RORO_UTIL_INI'},{av:'AV10cVEH_RORO_UTIL_FIN',fld:'vCVEH_RORO_UTIL_FIN'},{av:'AV11cVEH_RORO_TARIFA',fld:'vCVEH_RORO_TARIFA'}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E171N1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLVEH_RORO_IDFILTER.CLICK","{handler:'E111N1',iparms:[{av:'divVeh_roro_idfiltercontainer_Class',ctrl:'VEH_RORO_IDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divVeh_roro_idfiltercontainer_Class',ctrl:'VEH_RORO_IDFILTERCONTAINER',prop:'Class'},{av:'edtavCveh_roro_id_Visible',ctrl:'vCVEH_RORO_ID',prop:'Visible'}]}");
         setEventMetadata("LBLVEH_RORO_TON_INIFILTER.CLICK","{handler:'E121N1',iparms:[{av:'divVeh_roro_ton_inifiltercontainer_Class',ctrl:'VEH_RORO_TON_INIFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divVeh_roro_ton_inifiltercontainer_Class',ctrl:'VEH_RORO_TON_INIFILTERCONTAINER',prop:'Class'},{av:'edtavCveh_roro_ton_ini_Visible',ctrl:'vCVEH_RORO_TON_INI',prop:'Visible'}]}");
         setEventMetadata("LBLVEH_RORO_TON_FINFILTER.CLICK","{handler:'E131N1',iparms:[{av:'divVeh_roro_ton_finfiltercontainer_Class',ctrl:'VEH_RORO_TON_FINFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divVeh_roro_ton_finfiltercontainer_Class',ctrl:'VEH_RORO_TON_FINFILTERCONTAINER',prop:'Class'},{av:'edtavCveh_roro_ton_fin_Visible',ctrl:'vCVEH_RORO_TON_FIN',prop:'Visible'}]}");
         setEventMetadata("LBLVEH_RORO_UTIL_INIFILTER.CLICK","{handler:'E141N1',iparms:[{av:'divVeh_roro_util_inifiltercontainer_Class',ctrl:'VEH_RORO_UTIL_INIFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divVeh_roro_util_inifiltercontainer_Class',ctrl:'VEH_RORO_UTIL_INIFILTERCONTAINER',prop:'Class'},{av:'edtavCveh_roro_util_ini_Visible',ctrl:'vCVEH_RORO_UTIL_INI',prop:'Visible'}]}");
         setEventMetadata("LBLVEH_RORO_UTIL_FINFILTER.CLICK","{handler:'E151N1',iparms:[{av:'divVeh_roro_util_finfiltercontainer_Class',ctrl:'VEH_RORO_UTIL_FINFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divVeh_roro_util_finfiltercontainer_Class',ctrl:'VEH_RORO_UTIL_FINFILTERCONTAINER',prop:'Class'},{av:'edtavCveh_roro_util_fin_Visible',ctrl:'vCVEH_RORO_UTIL_FIN',prop:'Visible'}]}");
         setEventMetadata("LBLVEH_RORO_TARIFAFILTER.CLICK","{handler:'E161N1',iparms:[{av:'divVeh_roro_tarifafiltercontainer_Class',ctrl:'VEH_RORO_TARIFAFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divVeh_roro_tarifafiltercontainer_Class',ctrl:'VEH_RORO_TARIFAFILTERCONTAINER',prop:'Class'},{av:'edtavCveh_roro_tarifa_Visible',ctrl:'vCVEH_RORO_TARIFA',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E201N2',iparms:[{av:'A38VEH_RORO_ID',fld:'VEH_RORO_ID'}],oparms:[{av:'AV12pVEH_RORO_ID',fld:'vPVEH_RORO_ID'}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cVEH_RORO_ID',fld:'vCVEH_RORO_ID'},{av:'AV7cVEH_RORO_TON_INI',fld:'vCVEH_RORO_TON_INI'},{av:'AV8cVEH_RORO_TON_FIN',fld:'vCVEH_RORO_TON_FIN'},{av:'AV9cVEH_RORO_UTIL_INI',fld:'vCVEH_RORO_UTIL_INI'},{av:'AV10cVEH_RORO_UTIL_FIN',fld:'vCVEH_RORO_UTIL_FIN'},{av:'AV11cVEH_RORO_TARIFA',fld:'vCVEH_RORO_TARIFA'}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cVEH_RORO_ID',fld:'vCVEH_RORO_ID'},{av:'AV7cVEH_RORO_TON_INI',fld:'vCVEH_RORO_TON_INI'},{av:'AV8cVEH_RORO_TON_FIN',fld:'vCVEH_RORO_TON_FIN'},{av:'AV9cVEH_RORO_UTIL_INI',fld:'vCVEH_RORO_UTIL_INI'},{av:'AV10cVEH_RORO_UTIL_FIN',fld:'vCVEH_RORO_UTIL_FIN'},{av:'AV11cVEH_RORO_TARIFA',fld:'vCVEH_RORO_TARIFA'}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cVEH_RORO_ID',fld:'vCVEH_RORO_ID'},{av:'AV7cVEH_RORO_TON_INI',fld:'vCVEH_RORO_TON_INI'},{av:'AV8cVEH_RORO_TON_FIN',fld:'vCVEH_RORO_TON_FIN'},{av:'AV9cVEH_RORO_UTIL_INI',fld:'vCVEH_RORO_UTIL_INI'},{av:'AV10cVEH_RORO_UTIL_FIN',fld:'vCVEH_RORO_UTIL_FIN'},{av:'AV11cVEH_RORO_TARIFA',fld:'vCVEH_RORO_TARIFA'}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cVEH_RORO_ID',fld:'vCVEH_RORO_ID'},{av:'AV7cVEH_RORO_TON_INI',fld:'vCVEH_RORO_TON_INI'},{av:'AV8cVEH_RORO_TON_FIN',fld:'vCVEH_RORO_TON_FIN'},{av:'AV9cVEH_RORO_UTIL_INI',fld:'vCVEH_RORO_UTIL_INI'},{av:'AV10cVEH_RORO_UTIL_FIN',fld:'vCVEH_RORO_UTIL_FIN'},{av:'AV11cVEH_RORO_TARIFA',fld:'vCVEH_RORO_TARIFA'}],oparms:[]}");
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
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblveh_roro_idfilter_Jsonclick = "";
         TempTags = "";
         lblLblveh_roro_ton_inifilter_Jsonclick = "";
         lblLblveh_roro_ton_finfilter_Jsonclick = "";
         lblLblveh_roro_util_inifilter_Jsonclick = "";
         lblLblveh_roro_util_finfilter_Jsonclick = "";
         lblLblveh_roro_tarifafilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV16Linkselection_GXI = "";
         GXKey = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         scmdbuf = "";
         H001N2_A42VEH_RORO_UTIL_FIN = new decimal[1] ;
         H001N2_A41VEH_RORO_UTIL_INI = new decimal[1] ;
         H001N2_A43VEH_RORO_TARIFA = new decimal[1] ;
         H001N2_A40VEH_RORO_TON_FIN = new decimal[1] ;
         H001N2_A39VEH_RORO_TON_INI = new decimal[1] ;
         H001N2_A38VEH_RORO_ID = new short[1] ;
         H001N3_AGRID1_nRecordCount = new long[1] ;
         AV13ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0080__default(),
            new Object[][] {
                new Object[] {
               H001N2_A42VEH_RORO_UTIL_FIN, H001N2_A41VEH_RORO_UTIL_INI, H001N2_A43VEH_RORO_TARIFA, H001N2_A40VEH_RORO_TON_FIN, H001N2_A39VEH_RORO_TON_INI, H001N2_A38VEH_RORO_ID
               }
               , new Object[] {
               H001N3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_74 ;
      private short nGXsfl_74_idx=1 ;
      private short AV6cVEH_RORO_ID ;
      private short AV12pVEH_RORO_ID ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A38VEH_RORO_ID ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXsfl_74_Refreshing=0 ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Rows ;
      private int edtavCveh_roro_id_Enabled ;
      private int edtavCveh_roro_id_Visible ;
      private int edtavCveh_roro_ton_ini_Enabled ;
      private int edtavCveh_roro_ton_ini_Visible ;
      private int edtavCveh_roro_ton_fin_Enabled ;
      private int edtavCveh_roro_ton_fin_Visible ;
      private int edtavCveh_roro_util_ini_Enabled ;
      private int edtavCveh_roro_util_ini_Visible ;
      private int edtavCveh_roro_util_fin_Enabled ;
      private int edtavCveh_roro_util_fin_Visible ;
      private int edtavCveh_roro_tarifa_Enabled ;
      private int edtavCveh_roro_tarifa_Visible ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long GRID1_nFirstRecordOnPage ;
      private long GXPagingTo2 ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private decimal AV7cVEH_RORO_TON_INI ;
      private decimal AV8cVEH_RORO_TON_FIN ;
      private decimal AV9cVEH_RORO_UTIL_INI ;
      private decimal AV10cVEH_RORO_UTIL_FIN ;
      private decimal AV11cVEH_RORO_TARIFA ;
      private decimal A39VEH_RORO_TON_INI ;
      private decimal A40VEH_RORO_TON_FIN ;
      private decimal A43VEH_RORO_TARIFA ;
      private decimal A41VEH_RORO_UTIL_INI ;
      private decimal A42VEH_RORO_UTIL_FIN ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divVeh_roro_idfiltercontainer_Class ;
      private String divVeh_roro_ton_inifiltercontainer_Class ;
      private String divVeh_roro_ton_finfiltercontainer_Class ;
      private String divVeh_roro_util_inifiltercontainer_Class ;
      private String divVeh_roro_util_finfiltercontainer_Class ;
      private String divVeh_roro_tarifafiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_74_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divVeh_roro_idfiltercontainer_Internalname ;
      private String lblLblveh_roro_idfilter_Internalname ;
      private String lblLblveh_roro_idfilter_Jsonclick ;
      private String TempTags ;
      private String edtavCveh_roro_id_Internalname ;
      private String edtavCveh_roro_id_Jsonclick ;
      private String divVeh_roro_ton_inifiltercontainer_Internalname ;
      private String lblLblveh_roro_ton_inifilter_Internalname ;
      private String lblLblveh_roro_ton_inifilter_Jsonclick ;
      private String edtavCveh_roro_ton_ini_Internalname ;
      private String edtavCveh_roro_ton_ini_Jsonclick ;
      private String divVeh_roro_ton_finfiltercontainer_Internalname ;
      private String lblLblveh_roro_ton_finfilter_Internalname ;
      private String lblLblveh_roro_ton_finfilter_Jsonclick ;
      private String edtavCveh_roro_ton_fin_Internalname ;
      private String edtavCveh_roro_ton_fin_Jsonclick ;
      private String divVeh_roro_util_inifiltercontainer_Internalname ;
      private String lblLblveh_roro_util_inifilter_Internalname ;
      private String lblLblveh_roro_util_inifilter_Jsonclick ;
      private String edtavCveh_roro_util_ini_Internalname ;
      private String edtavCveh_roro_util_ini_Jsonclick ;
      private String divVeh_roro_util_finfiltercontainer_Internalname ;
      private String lblLblveh_roro_util_finfilter_Internalname ;
      private String lblLblveh_roro_util_finfilter_Jsonclick ;
      private String edtavCveh_roro_util_fin_Internalname ;
      private String edtavCveh_roro_util_fin_Jsonclick ;
      private String divVeh_roro_tarifafiltercontainer_Internalname ;
      private String lblLblveh_roro_tarifafilter_Internalname ;
      private String lblLblveh_roro_tarifafilter_Jsonclick ;
      private String edtavCveh_roro_tarifa_Internalname ;
      private String edtavCveh_roro_tarifa_Jsonclick ;
      private String divGridtable_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtntoggle_Internalname ;
      private String bttBtntoggle_Jsonclick ;
      private String sStyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String edtavLinkselection_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtVEH_RORO_ID_Internalname ;
      private String edtVEH_RORO_TON_INI_Internalname ;
      private String edtVEH_RORO_TON_FIN_Internalname ;
      private String edtVEH_RORO_TARIFA_Internalname ;
      private String GXKey ;
      private String scmdbuf ;
      private String AV13ADVANCED_LABEL_TEMPLATE ;
      private String ROClassString ;
      private String edtVEH_RORO_ID_Jsonclick ;
      private String edtVEH_RORO_TON_INI_Jsonclick ;
      private String edtVEH_RORO_TON_FIN_Jsonclick ;
      private String edtVEH_RORO_TARIFA_Jsonclick ;
      private String div_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV16Linkselection_GXI ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_default ;
      private decimal[] H001N2_A42VEH_RORO_UTIL_FIN ;
      private decimal[] H001N2_A41VEH_RORO_UTIL_INI ;
      private decimal[] H001N2_A43VEH_RORO_TARIFA ;
      private decimal[] H001N2_A40VEH_RORO_TON_FIN ;
      private decimal[] H001N2_A39VEH_RORO_TON_INI ;
      private short[] H001N2_A38VEH_RORO_ID ;
      private long[] H001N3_AGRID1_nRecordCount ;
      private short aP0_pVEH_RORO_ID ;
      private GXWebForm Form ;
   }

   public class gx0080__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001N2( IGxContext context ,
                                             decimal AV7cVEH_RORO_TON_INI ,
                                             decimal AV8cVEH_RORO_TON_FIN ,
                                             decimal AV9cVEH_RORO_UTIL_INI ,
                                             decimal AV10cVEH_RORO_UTIL_FIN ,
                                             decimal AV11cVEH_RORO_TARIFA ,
                                             decimal A39VEH_RORO_TON_INI ,
                                             decimal A40VEH_RORO_TON_FIN ,
                                             decimal A41VEH_RORO_UTIL_INI ,
                                             decimal A42VEH_RORO_UTIL_FIN ,
                                             decimal A43VEH_RORO_TARIFA ,
                                             short AV6cVEH_RORO_ID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [11] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [VEH_RORO_UTIL_FIN], [VEH_RORO_UTIL_INI], [VEH_RORO_TARIFA], [VEH_RORO_TON_FIN], [VEH_RORO_TON_INI], [VEH_RORO_ID]";
         sFromString = " FROM [VEH_RORO] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([VEH_RORO_ID] >= @AV6cVEH_RORO_ID)";
         if ( ! (Convert.ToDecimal(0)==AV7cVEH_RORO_TON_INI) )
         {
            sWhereString = sWhereString + " and ([VEH_RORO_TON_INI] >= @AV7cVEH_RORO_TON_INI)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV8cVEH_RORO_TON_FIN) )
         {
            sWhereString = sWhereString + " and ([VEH_RORO_TON_FIN] >= @AV8cVEH_RORO_TON_FIN)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV9cVEH_RORO_UTIL_INI) )
         {
            sWhereString = sWhereString + " and ([VEH_RORO_UTIL_INI] >= @AV9cVEH_RORO_UTIL_INI)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV10cVEH_RORO_UTIL_FIN) )
         {
            sWhereString = sWhereString + " and ([VEH_RORO_UTIL_FIN] >= @AV10cVEH_RORO_UTIL_FIN)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV11cVEH_RORO_TARIFA) )
         {
            sWhereString = sWhereString + " and ([VEH_RORO_TARIFA] >= @AV11cVEH_RORO_TARIFA)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [VEH_RORO_ID]";
         scmdbuf = "SELECT * FROM (SELECT " + sSelectString + ", ROW_NUMBER() OVER (" + sOrderString + " ) AS GX_ROW_NUMBER" + sFromString + sWhereString + ") AS GX_CTE WHERE GX_ROW_NUMBER" + " BETWEEN " + "@GXPagingFrom2" + " AND " + "@GXPagingTo2" + " OR " + "@GXPagingTo2" + " < " + "@GXPagingFrom2" + " AND GX_ROW_NUMBER >= " + "@GXPagingFrom2";
         scmdbuf = scmdbuf + " OPTION (FAST 11)";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H001N3( IGxContext context ,
                                             decimal AV7cVEH_RORO_TON_INI ,
                                             decimal AV8cVEH_RORO_TON_FIN ,
                                             decimal AV9cVEH_RORO_UTIL_INI ,
                                             decimal AV10cVEH_RORO_UTIL_FIN ,
                                             decimal AV11cVEH_RORO_TARIFA ,
                                             decimal A39VEH_RORO_TON_INI ,
                                             decimal A40VEH_RORO_TON_FIN ,
                                             decimal A41VEH_RORO_UTIL_INI ,
                                             decimal A42VEH_RORO_UTIL_FIN ,
                                             decimal A43VEH_RORO_TARIFA ,
                                             short AV6cVEH_RORO_ID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [6] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [VEH_RORO] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([VEH_RORO_ID] >= @AV6cVEH_RORO_ID)";
         if ( ! (Convert.ToDecimal(0)==AV7cVEH_RORO_TON_INI) )
         {
            sWhereString = sWhereString + " and ([VEH_RORO_TON_INI] >= @AV7cVEH_RORO_TON_INI)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV8cVEH_RORO_TON_FIN) )
         {
            sWhereString = sWhereString + " and ([VEH_RORO_TON_FIN] >= @AV8cVEH_RORO_TON_FIN)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV9cVEH_RORO_UTIL_INI) )
         {
            sWhereString = sWhereString + " and ([VEH_RORO_UTIL_INI] >= @AV9cVEH_RORO_UTIL_INI)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV10cVEH_RORO_UTIL_FIN) )
         {
            sWhereString = sWhereString + " and ([VEH_RORO_UTIL_FIN] >= @AV10cVEH_RORO_UTIL_FIN)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV11cVEH_RORO_TARIFA) )
         {
            sWhereString = sWhereString + " and ([VEH_RORO_TARIFA] >= @AV11cVEH_RORO_TARIFA)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + "";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H001N2(context, (decimal)dynConstraints[0] , (decimal)dynConstraints[1] , (decimal)dynConstraints[2] , (decimal)dynConstraints[3] , (decimal)dynConstraints[4] , (decimal)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (decimal)dynConstraints[8] , (decimal)dynConstraints[9] , (short)dynConstraints[10] );
               case 1 :
                     return conditional_H001N3(context, (decimal)dynConstraints[0] , (decimal)dynConstraints[1] , (decimal)dynConstraints[2] , (decimal)dynConstraints[3] , (decimal)dynConstraints[4] , (decimal)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (decimal)dynConstraints[8] , (decimal)dynConstraints[9] , (short)dynConstraints[10] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH001N2 ;
          prmH001N2 = new Object[] {
          new Object[] {"@AV6cVEH_RORO_ID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cVEH_RORO_TON_INI",SqlDbType.Decimal,10,2} ,
          new Object[] {"@AV8cVEH_RORO_TON_FIN",SqlDbType.Decimal,10,2} ,
          new Object[] {"@AV9cVEH_RORO_UTIL_INI",SqlDbType.Decimal,10,2} ,
          new Object[] {"@AV10cVEH_RORO_UTIL_FIN",SqlDbType.Decimal,10,2} ,
          new Object[] {"@AV11cVEH_RORO_TARIFA",SqlDbType.Decimal,10,2} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,6,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Decimal,12,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Decimal,12,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,6,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,6,0}
          } ;
          Object[] prmH001N3 ;
          prmH001N3 = new Object[] {
          new Object[] {"@AV6cVEH_RORO_ID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cVEH_RORO_TON_INI",SqlDbType.Decimal,10,2} ,
          new Object[] {"@AV8cVEH_RORO_TON_FIN",SqlDbType.Decimal,10,2} ,
          new Object[] {"@AV9cVEH_RORO_UTIL_INI",SqlDbType.Decimal,10,2} ,
          new Object[] {"@AV10cVEH_RORO_UTIL_FIN",SqlDbType.Decimal,10,2} ,
          new Object[] {"@AV11cVEH_RORO_TARIFA",SqlDbType.Decimal,10,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001N2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001N2,11,0,false,false )
             ,new CursorDef("H001N3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001N3,1,0,false,false )
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
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[11]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[12]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[13]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[14]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[15]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[16]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[17]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[18]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[19]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[20]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[21]);
                }
                break;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[9]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[10]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[11]);
                }
                break;
       }
    }

 }

}
