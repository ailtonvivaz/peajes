/*
               File: Gx0071
        Description: Selection List Rango
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 8:3:30.81
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
   public class gx0071 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0071( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public gx0071( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_pPortaContenedoresEsclusa ,
                           out short aP1_pPortaRango )
      {
         this.AV12pPortaContenedoresEsclusa = aP0_pPortaContenedoresEsclusa;
         this.AV13pPortaRango = 0 ;
         executePrivate();
         aP1_pPortaRango=this.AV13pPortaRango;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbPortaContenedoresEsclusa = new GXCombobox();
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
               AV6cPortaRango = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cPortaRango", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cPortaRango), 4, 0)));
               AV7cPortaRangoIniTEU = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cPortaRangoIniTEU", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cPortaRangoIniTEU), 12, 0)));
               AV8cPortaRangoFinTEU = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cPortaRangoFinTEU", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cPortaRangoFinTEU), 12, 0)));
               AV9cPortaTarifaTTA4 = NumberUtil.Val( GetNextPar( ), ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cPortaTarifaTTA4", StringUtil.LTrim( StringUtil.Str( AV9cPortaTarifaTTA4, 7, 2)));
               AV15cPortaTarifaTEU4 = NumberUtil.Val( GetNextPar( ), ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15cPortaTarifaTEU4", StringUtil.LTrim( StringUtil.Str( AV15cPortaTarifaTEU4, 7, 2)));
               AV11cPortaTarifaTTA3 = NumberUtil.Val( GetNextPar( ), ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cPortaTarifaTTA3", StringUtil.LTrim( StringUtil.Str( AV11cPortaTarifaTTA3, 7, 2)));
               AV12pPortaContenedoresEsclusa = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pPortaContenedoresEsclusa", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pPortaContenedoresEsclusa), 4, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cPortaRango, AV7cPortaRangoIniTEU, AV8cPortaRangoFinTEU, AV9cPortaTarifaTTA4, AV15cPortaTarifaTEU4, AV11cPortaTarifaTTA3, AV12pPortaContenedoresEsclusa) ;
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
               AV12pPortaContenedoresEsclusa = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pPortaContenedoresEsclusa", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pPortaContenedoresEsclusa), 4, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV13pPortaRango = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pPortaRango", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pPortaRango), 4, 0)));
               }
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
         PA112( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START112( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2015120833085");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0071.aspx") + "?" + UrlEncode("" +AV12pPortaContenedoresEsclusa) + "," + UrlEncode("" +AV13pPortaRango)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCPORTARANGO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cPortaRango), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPORTARANGOINITEU", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cPortaRangoIniTEU), 12, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPORTARANGOFINTEU", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cPortaRangoFinTEU), 12, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPORTATARIFATTA4", StringUtil.LTrim( StringUtil.NToC( AV9cPortaTarifaTTA4, 7, 2, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPORTATARIFATEU4", StringUtil.LTrim( StringUtil.NToC( AV15cPortaTarifaTEU4, 7, 2, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPORTATARIFATTA3", StringUtil.LTrim( StringUtil.NToC( AV11cPortaTarifaTTA3, 7, 2, context.GetLanguageProperty( "decimal_point"), "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_74", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_74), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "vPPORTACONTENEDORESESCLUSA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12pPortaContenedoresEsclusa), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "vPPORTARANGO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pPortaRango), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "PORTARANGOFILTERCONTAINER_Class", StringUtil.RTrim( divPortarangofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PORTARANGOINITEUFILTERCONTAINER_Class", StringUtil.RTrim( divPortarangoiniteufiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PORTARANGOFINTEUFILTERCONTAINER_Class", StringUtil.RTrim( divPortarangofinteufiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PORTATARIFATTA4FILTERCONTAINER_Class", StringUtil.RTrim( divPortatarifatta4filtercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PORTATARIFATEU4FILTERCONTAINER_Class", StringUtil.RTrim( divPortatarifateu4filtercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PORTATARIFATTA3FILTERCONTAINER_Class", StringUtil.RTrim( divPortatarifatta3filtercontainer_Class));
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
            WE112( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT112( ) ;
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
         return formatLink("gx0071.aspx") + "?" + UrlEncode("" +AV12pPortaContenedoresEsclusa) + "," + UrlEncode("" +AV13pPortaRango) ;
      }

      public override String GetPgmname( )
      {
         return "gx0071" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "Selection List Rango", "") ;
      }

      protected void WB110( )
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
            GxWebStd.gx_div_start( context, divPortarangofiltercontainer_Internalname, 1, 0, "px", 0, "px", divPortarangofiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblportarangofilter_Internalname, context.GetMessage( "Porta Rango", ""), "", "", lblLblportarangofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e11111_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0071.htm");
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
            GxWebStd.gx_single_line_edit( context, edtavCportarango_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cPortaRango), 4, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCportarango_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cPortaRango), "ZZZ9")) : context.localUtil.Format( (decimal)(AV6cPortaRango), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCportarango_Jsonclick, 0, "Attribute", "", "", "", edtavCportarango_Visible, edtavCportarango_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx0071.htm");
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
            GxWebStd.gx_div_start( context, divPortarangoiniteufiltercontainer_Internalname, 1, 0, "px", 0, "px", divPortarangoiniteufiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblportarangoiniteufilter_Internalname, context.GetMessage( "Rango Inicial", ""), "", "", lblLblportarangoiniteufilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e12111_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0071.htm");
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
            GxWebStd.gx_single_line_edit( context, edtavCportarangoiniteu_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cPortaRangoIniTEU), 12, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCportarangoiniteu_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7cPortaRangoIniTEU), "ZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV7cPortaRangoIniTEU), "ZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCportarangoiniteu_Jsonclick, 0, "Attribute", "", "", "", edtavCportarangoiniteu_Visible, edtavCportarangoiniteu_Enabled, 0, "text", "", 12, "chr", 1, "row", 12, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx0071.htm");
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
            GxWebStd.gx_div_start( context, divPortarangofinteufiltercontainer_Internalname, 1, 0, "px", 0, "px", divPortarangofinteufiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblportarangofinteufilter_Internalname, context.GetMessage( "Rango Final", ""), "", "", lblLblportarangofinteufilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e13111_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0071.htm");
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
            GxWebStd.gx_single_line_edit( context, edtavCportarangofinteu_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cPortaRangoFinTEU), 12, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCportarangofinteu_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8cPortaRangoFinTEU), "ZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV8cPortaRangoFinTEU), "ZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCportarangofinteu_Jsonclick, 0, "Attribute", "", "", "", edtavCportarangofinteu_Visible, edtavCportarangofinteu_Enabled, 0, "text", "", 12, "chr", 1, "row", 12, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx0071.htm");
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
            GxWebStd.gx_div_start( context, divPortatarifatta4filtercontainer_Internalname, 1, 0, "px", 0, "px", divPortatarifatta4filtercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblportatarifatta4filter_Internalname, context.GetMessage( "Tarifa TTA4", ""), "", "", lblLblportatarifatta4filter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e14111_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0071.htm");
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
            GxWebStd.gx_single_line_edit( context, edtavCportatarifatta4_Internalname, StringUtil.LTrim( StringUtil.NToC( AV9cPortaTarifaTTA4, 7, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCportatarifatta4_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV9cPortaTarifaTTA4, "ZZZ9.99")) : context.localUtil.Format( AV9cPortaTarifaTTA4, "ZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCportatarifatta4_Jsonclick, 0, "Attribute", "", "", "", edtavCportatarifatta4_Visible, edtavCportatarifatta4_Enabled, 0, "text", "", 7, "chr", 1, "row", 7, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx0071.htm");
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
            GxWebStd.gx_div_start( context, divPortatarifateu4filtercontainer_Internalname, 1, 0, "px", 0, "px", divPortatarifateu4filtercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblportatarifateu4filter_Internalname, context.GetMessage( "Tarifa TEU4", ""), "", "", lblLblportatarifateu4filter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e15111_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0071.htm");
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
            GxWebStd.gx_single_line_edit( context, edtavCportatarifateu4_Internalname, StringUtil.LTrim( StringUtil.NToC( AV15cPortaTarifaTEU4, 7, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCportatarifateu4_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV15cPortaTarifaTEU4, "ZZZ9.99")) : context.localUtil.Format( AV15cPortaTarifaTEU4, "ZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCportatarifateu4_Jsonclick, 0, "Attribute", "", "", "", edtavCportatarifateu4_Visible, edtavCportatarifateu4_Enabled, 0, "text", "", 7, "chr", 1, "row", 7, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx0071.htm");
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
            GxWebStd.gx_div_start( context, divPortatarifatta3filtercontainer_Internalname, 1, 0, "px", 0, "px", divPortatarifatta3filtercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblportatarifatta3filter_Internalname, context.GetMessage( "Tarifa TTA3", ""), "", "", lblLblportatarifatta3filter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e16111_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0071.htm");
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
            GxWebStd.gx_single_line_edit( context, edtavCportatarifatta3_Internalname, StringUtil.LTrim( StringUtil.NToC( AV11cPortaTarifaTTA3, 7, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCportatarifatta3_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV11cPortaTarifaTTA3, "ZZZ9.99")) : context.localUtil.Format( AV11cPortaTarifaTTA3, "ZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCportatarifatta3_Jsonclick, 0, "Attribute", "", "", "", edtavCportatarifatta3_Visible, edtavCportatarifatta3_Enabled, 0, "text", "", 7, "chr", 1, "row", 7, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx0071.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e17111_client"+"'", TempTags, "", 2, "HLP_Gx0071.htm");
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
               context.SendWebValue( context.GetMessage( "Rango", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Rango Inicial", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Final", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tarifa TTA4", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tarifa TEU4", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tarifa TTA3", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tarifa TEU3", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tarifa TTA2", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tarifa TEU2", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tarifa TTA1", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tarifa TEU1", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Esclusa", "")) ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A24PortaRango), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A25PortaRangoIniTEU), 12, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A26PortaRangoFinTEU), 12, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A27PortaTarifaTTA4, 7, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A28PortaTarifaTEU4, 7, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A29PortaTarifaTTA3, 7, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A30PortaTarifaTEU3, 7, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A31PortaTarifaTTA2, 7, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A32PortaTarifaTEU2, 7, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A33PortaTarifaTTA1, 7, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A34PortaTarifaTEU1, 7, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22PortaContenedoresEsclusa), 4, 0, ".", "")));
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 90,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", context.GetMessage( "GX_BtnCancel", ""), bttBtn_cancel_Jsonclick, 1, context.GetMessage( "GX_BtnCancel", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0071.htm");
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

      protected void START112( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_2-86442", 0) ;
            Form.Meta.addItem("description", context.GetMessage( "Selection List Rango", ""), 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP110( ) ;
      }

      protected void WS112( )
      {
         START112( ) ;
         EVT112( ) ;
      }

      protected void EVT112( )
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
                              edtPortaRango_Internalname = "PORTARANGO_"+sGXsfl_74_idx;
                              edtPortaRangoIniTEU_Internalname = "PORTARANGOINITEU_"+sGXsfl_74_idx;
                              edtPortaRangoFinTEU_Internalname = "PORTARANGOFINTEU_"+sGXsfl_74_idx;
                              edtPortaTarifaTTA4_Internalname = "PORTATARIFATTA4_"+sGXsfl_74_idx;
                              edtPortaTarifaTEU4_Internalname = "PORTATARIFATEU4_"+sGXsfl_74_idx;
                              edtPortaTarifaTTA3_Internalname = "PORTATARIFATTA3_"+sGXsfl_74_idx;
                              edtPortaTarifaTEU3_Internalname = "PORTATARIFATEU3_"+sGXsfl_74_idx;
                              edtPortaTarifaTTA2_Internalname = "PORTATARIFATTA2_"+sGXsfl_74_idx;
                              edtPortaTarifaTEU2_Internalname = "PORTATARIFATEU2_"+sGXsfl_74_idx;
                              edtPortaTarifaTTA1_Internalname = "PORTATARIFATTA1_"+sGXsfl_74_idx;
                              edtPortaTarifaTEU1_Internalname = "PORTATARIFATEU1_"+sGXsfl_74_idx;
                              cmbPortaContenedoresEsclusa_Internalname = "PORTACONTENEDORESESCLUSA_"+sGXsfl_74_idx;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV18Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))));
                              A24PortaRango = (short)(context.localUtil.CToN( cgiGet( edtPortaRango_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPortaRango_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A24PortaRango), 4, 0)));
                              A25PortaRangoIniTEU = (long)(context.localUtil.CToN( cgiGet( edtPortaRangoIniTEU_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPortaRangoIniTEU_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A25PortaRangoIniTEU), 12, 0)));
                              A26PortaRangoFinTEU = (long)(context.localUtil.CToN( cgiGet( edtPortaRangoFinTEU_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPortaRangoFinTEU_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A26PortaRangoFinTEU), 12, 0)));
                              A27PortaTarifaTTA4 = context.localUtil.CToN( cgiGet( edtPortaTarifaTTA4_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPortaTarifaTTA4_Internalname, StringUtil.LTrim( StringUtil.Str( A27PortaTarifaTTA4, 7, 2)));
                              A28PortaTarifaTEU4 = context.localUtil.CToN( cgiGet( edtPortaTarifaTEU4_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPortaTarifaTEU4_Internalname, StringUtil.LTrim( StringUtil.Str( A28PortaTarifaTEU4, 7, 2)));
                              A29PortaTarifaTTA3 = context.localUtil.CToN( cgiGet( edtPortaTarifaTTA3_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPortaTarifaTTA3_Internalname, StringUtil.LTrim( StringUtil.Str( A29PortaTarifaTTA3, 7, 2)));
                              A30PortaTarifaTEU3 = context.localUtil.CToN( cgiGet( edtPortaTarifaTEU3_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPortaTarifaTEU3_Internalname, StringUtil.LTrim( StringUtil.Str( A30PortaTarifaTEU3, 7, 2)));
                              A31PortaTarifaTTA2 = context.localUtil.CToN( cgiGet( edtPortaTarifaTTA2_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPortaTarifaTTA2_Internalname, StringUtil.LTrim( StringUtil.Str( A31PortaTarifaTTA2, 7, 2)));
                              A32PortaTarifaTEU2 = context.localUtil.CToN( cgiGet( edtPortaTarifaTEU2_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPortaTarifaTEU2_Internalname, StringUtil.LTrim( StringUtil.Str( A32PortaTarifaTEU2, 7, 2)));
                              A33PortaTarifaTTA1 = context.localUtil.CToN( cgiGet( edtPortaTarifaTTA1_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPortaTarifaTTA1_Internalname, StringUtil.LTrim( StringUtil.Str( A33PortaTarifaTTA1, 7, 2)));
                              A34PortaTarifaTEU1 = context.localUtil.CToN( cgiGet( edtPortaTarifaTEU1_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPortaTarifaTEU1_Internalname, StringUtil.LTrim( StringUtil.Str( A34PortaTarifaTEU1, 7, 2)));
                              cmbPortaContenedoresEsclusa.Name = cmbPortaContenedoresEsclusa_Internalname;
                              cmbPortaContenedoresEsclusa.CurrentValue = cgiGet( cmbPortaContenedoresEsclusa_Internalname);
                              A22PortaContenedoresEsclusa = (short)(NumberUtil.Val( cgiGet( cmbPortaContenedoresEsclusa_Internalname), "."));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbPortaContenedoresEsclusa_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A22PortaContenedoresEsclusa), 4, 0)));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E18112 */
                                    E18112 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E19112 */
                                    E19112 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cportarango Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPORTARANGO"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV6cPortaRango )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cportarangoiniteu Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPORTARANGOINITEU"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV7cPortaRangoIniTEU )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cportarangofinteu Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPORTARANGOFINTEU"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV8cPortaRangoFinTEU )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cportatarifatta4 Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCPORTATARIFATTA4"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV9cPortaTarifaTTA4 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cportatarifateu4 Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCPORTATARIFATEU4"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV15cPortaTarifaTEU4 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cportatarifatta3 Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCPORTATARIFATTA3"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV11cPortaTarifaTTA3 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E20112 */
                                          E20112 ();
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

      protected void WE112( )
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

      protected void PA112( )
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
            GXCCtl = "PORTACONTENEDORESESCLUSA_" + sGXsfl_74_idx;
            cmbPortaContenedoresEsclusa.Name = GXCCtl;
            cmbPortaContenedoresEsclusa.WebTags = "";
            cmbPortaContenedoresEsclusa.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), context.GetMessage( "GX_EmptyItemText", ""), 0);
            cmbPortaContenedoresEsclusa.addItem("1", context.GetMessage( "Panamax", ""), 0);
            cmbPortaContenedoresEsclusa.addItem("2", context.GetMessage( "Neopanamax", ""), 0);
            if ( cmbPortaContenedoresEsclusa.ItemCount > 0 )
            {
               A22PortaContenedoresEsclusa = (short)(NumberUtil.Val( cmbPortaContenedoresEsclusa.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A22PortaContenedoresEsclusa), 4, 0))), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbPortaContenedoresEsclusa_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A22PortaContenedoresEsclusa), 4, 0)));
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
         edtPortaRango_Internalname = "PORTARANGO_"+sGXsfl_74_idx;
         edtPortaRangoIniTEU_Internalname = "PORTARANGOINITEU_"+sGXsfl_74_idx;
         edtPortaRangoFinTEU_Internalname = "PORTARANGOFINTEU_"+sGXsfl_74_idx;
         edtPortaTarifaTTA4_Internalname = "PORTATARIFATTA4_"+sGXsfl_74_idx;
         edtPortaTarifaTEU4_Internalname = "PORTATARIFATEU4_"+sGXsfl_74_idx;
         edtPortaTarifaTTA3_Internalname = "PORTATARIFATTA3_"+sGXsfl_74_idx;
         edtPortaTarifaTEU3_Internalname = "PORTATARIFATEU3_"+sGXsfl_74_idx;
         edtPortaTarifaTTA2_Internalname = "PORTATARIFATTA2_"+sGXsfl_74_idx;
         edtPortaTarifaTEU2_Internalname = "PORTATARIFATEU2_"+sGXsfl_74_idx;
         edtPortaTarifaTTA1_Internalname = "PORTATARIFATTA1_"+sGXsfl_74_idx;
         edtPortaTarifaTEU1_Internalname = "PORTATARIFATEU1_"+sGXsfl_74_idx;
         cmbPortaContenedoresEsclusa_Internalname = "PORTACONTENEDORESESCLUSA_"+sGXsfl_74_idx;
         while ( nGXsfl_74_idx <= nRC_GXsfl_74 )
         {
            sendrow_742( ) ;
            nGXsfl_74_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1));
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
            edtPortaRango_Internalname = "PORTARANGO_"+sGXsfl_74_idx;
            edtPortaRangoIniTEU_Internalname = "PORTARANGOINITEU_"+sGXsfl_74_idx;
            edtPortaRangoFinTEU_Internalname = "PORTARANGOFINTEU_"+sGXsfl_74_idx;
            edtPortaTarifaTTA4_Internalname = "PORTATARIFATTA4_"+sGXsfl_74_idx;
            edtPortaTarifaTEU4_Internalname = "PORTATARIFATEU4_"+sGXsfl_74_idx;
            edtPortaTarifaTTA3_Internalname = "PORTATARIFATTA3_"+sGXsfl_74_idx;
            edtPortaTarifaTEU3_Internalname = "PORTATARIFATEU3_"+sGXsfl_74_idx;
            edtPortaTarifaTTA2_Internalname = "PORTATARIFATTA2_"+sGXsfl_74_idx;
            edtPortaTarifaTEU2_Internalname = "PORTATARIFATEU2_"+sGXsfl_74_idx;
            edtPortaTarifaTTA1_Internalname = "PORTATARIFATTA1_"+sGXsfl_74_idx;
            edtPortaTarifaTEU1_Internalname = "PORTATARIFATEU1_"+sGXsfl_74_idx;
            cmbPortaContenedoresEsclusa_Internalname = "PORTACONTENEDORESESCLUSA_"+sGXsfl_74_idx;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        short AV6cPortaRango ,
                                        long AV7cPortaRangoIniTEU ,
                                        long AV8cPortaRangoFinTEU ,
                                        decimal AV9cPortaTarifaTTA4 ,
                                        decimal AV15cPortaTarifaTEU4 ,
                                        decimal AV11cPortaTarifaTTA3 ,
                                        short AV12pPortaContenedoresEsclusa )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         GXCCtl = "PORTACONTENEDORESESCLUSA_" + sGXsfl_74_idx;
         cmbPortaContenedoresEsclusa.Name = GXCCtl;
         cmbPortaContenedoresEsclusa.WebTags = "";
         cmbPortaContenedoresEsclusa.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), context.GetMessage( "GX_EmptyItemText", ""), 0);
         cmbPortaContenedoresEsclusa.addItem("1", context.GetMessage( "Panamax", ""), 0);
         cmbPortaContenedoresEsclusa.addItem("2", context.GetMessage( "Neopanamax", ""), 0);
         if ( cmbPortaContenedoresEsclusa.ItemCount > 0 )
         {
            A22PortaContenedoresEsclusa = (short)(NumberUtil.Val( cmbPortaContenedoresEsclusa.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A22PortaContenedoresEsclusa), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbPortaContenedoresEsclusa_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A22PortaContenedoresEsclusa), 4, 0)));
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         RF112( ) ;
         context.GX_msglist = BackMsgLst;
         /* End function gxgrGrid1_refresh */
      }

      public void Refresh( )
      {
         RF112( ) ;
      }

      protected void RF112( )
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
         edtPortaRango_Internalname = "PORTARANGO_"+sGXsfl_74_idx;
         edtPortaRangoIniTEU_Internalname = "PORTARANGOINITEU_"+sGXsfl_74_idx;
         edtPortaRangoFinTEU_Internalname = "PORTARANGOFINTEU_"+sGXsfl_74_idx;
         edtPortaTarifaTTA4_Internalname = "PORTATARIFATTA4_"+sGXsfl_74_idx;
         edtPortaTarifaTEU4_Internalname = "PORTATARIFATEU4_"+sGXsfl_74_idx;
         edtPortaTarifaTTA3_Internalname = "PORTATARIFATTA3_"+sGXsfl_74_idx;
         edtPortaTarifaTEU3_Internalname = "PORTATARIFATEU3_"+sGXsfl_74_idx;
         edtPortaTarifaTTA2_Internalname = "PORTATARIFATTA2_"+sGXsfl_74_idx;
         edtPortaTarifaTEU2_Internalname = "PORTATARIFATEU2_"+sGXsfl_74_idx;
         edtPortaTarifaTTA1_Internalname = "PORTATARIFATTA1_"+sGXsfl_74_idx;
         edtPortaTarifaTEU1_Internalname = "PORTATARIFATEU1_"+sGXsfl_74_idx;
         cmbPortaContenedoresEsclusa_Internalname = "PORTACONTENEDORESESCLUSA_"+sGXsfl_74_idx;
         nGXsfl_74_Refreshing = 1;
         Grid1Container.PageSize = subGrid1_Recordsperpage( );
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
            edtPortaRango_Internalname = "PORTARANGO_"+sGXsfl_74_idx;
            edtPortaRangoIniTEU_Internalname = "PORTARANGOINITEU_"+sGXsfl_74_idx;
            edtPortaRangoFinTEU_Internalname = "PORTARANGOFINTEU_"+sGXsfl_74_idx;
            edtPortaTarifaTTA4_Internalname = "PORTATARIFATTA4_"+sGXsfl_74_idx;
            edtPortaTarifaTEU4_Internalname = "PORTATARIFATEU4_"+sGXsfl_74_idx;
            edtPortaTarifaTTA3_Internalname = "PORTATARIFATTA3_"+sGXsfl_74_idx;
            edtPortaTarifaTEU3_Internalname = "PORTATARIFATEU3_"+sGXsfl_74_idx;
            edtPortaTarifaTTA2_Internalname = "PORTATARIFATTA2_"+sGXsfl_74_idx;
            edtPortaTarifaTEU2_Internalname = "PORTATARIFATEU2_"+sGXsfl_74_idx;
            edtPortaTarifaTTA1_Internalname = "PORTATARIFATTA1_"+sGXsfl_74_idx;
            edtPortaTarifaTEU1_Internalname = "PORTATARIFATEU1_"+sGXsfl_74_idx;
            cmbPortaContenedoresEsclusa_Internalname = "PORTACONTENEDORESESCLUSA_"+sGXsfl_74_idx;
            GXPagingFrom2 = (int)(((10==0) ? 1 : GRID1_nFirstRecordOnPage+1));
            GXPagingTo2 = ((10==0) ? 10000 : GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7cPortaRangoIniTEU ,
                                                 AV8cPortaRangoFinTEU ,
                                                 AV9cPortaTarifaTTA4 ,
                                                 AV15cPortaTarifaTEU4 ,
                                                 AV11cPortaTarifaTTA3 ,
                                                 A25PortaRangoIniTEU ,
                                                 A26PortaRangoFinTEU ,
                                                 A27PortaTarifaTTA4 ,
                                                 A28PortaTarifaTEU4 ,
                                                 A29PortaTarifaTTA3 ,
                                                 AV12pPortaContenedoresEsclusa ,
                                                 AV6cPortaRango ,
                                                 A22PortaContenedoresEsclusa },
                                                 new int[] {
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL,
                                                 TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT
                                                 }
            });
            /* Using cursor H00112 */
            pr_default.execute(0, new Object[] {AV12pPortaContenedoresEsclusa, AV6cPortaRango, AV7cPortaRangoIniTEU, AV8cPortaRangoFinTEU, AV9cPortaTarifaTTA4, AV15cPortaTarifaTEU4, AV11cPortaTarifaTTA3, GXPagingFrom2, GXPagingTo2, GXPagingTo2, GXPagingFrom2, GXPagingFrom2});
            nGXsfl_74_idx = 1;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A22PortaContenedoresEsclusa = H00112_A22PortaContenedoresEsclusa[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbPortaContenedoresEsclusa_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A22PortaContenedoresEsclusa), 4, 0)));
               A34PortaTarifaTEU1 = H00112_A34PortaTarifaTEU1[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPortaTarifaTEU1_Internalname, StringUtil.LTrim( StringUtil.Str( A34PortaTarifaTEU1, 7, 2)));
               A33PortaTarifaTTA1 = H00112_A33PortaTarifaTTA1[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPortaTarifaTTA1_Internalname, StringUtil.LTrim( StringUtil.Str( A33PortaTarifaTTA1, 7, 2)));
               A32PortaTarifaTEU2 = H00112_A32PortaTarifaTEU2[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPortaTarifaTEU2_Internalname, StringUtil.LTrim( StringUtil.Str( A32PortaTarifaTEU2, 7, 2)));
               A31PortaTarifaTTA2 = H00112_A31PortaTarifaTTA2[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPortaTarifaTTA2_Internalname, StringUtil.LTrim( StringUtil.Str( A31PortaTarifaTTA2, 7, 2)));
               A30PortaTarifaTEU3 = H00112_A30PortaTarifaTEU3[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPortaTarifaTEU3_Internalname, StringUtil.LTrim( StringUtil.Str( A30PortaTarifaTEU3, 7, 2)));
               A29PortaTarifaTTA3 = H00112_A29PortaTarifaTTA3[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPortaTarifaTTA3_Internalname, StringUtil.LTrim( StringUtil.Str( A29PortaTarifaTTA3, 7, 2)));
               A28PortaTarifaTEU4 = H00112_A28PortaTarifaTEU4[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPortaTarifaTEU4_Internalname, StringUtil.LTrim( StringUtil.Str( A28PortaTarifaTEU4, 7, 2)));
               A27PortaTarifaTTA4 = H00112_A27PortaTarifaTTA4[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPortaTarifaTTA4_Internalname, StringUtil.LTrim( StringUtil.Str( A27PortaTarifaTTA4, 7, 2)));
               A26PortaRangoFinTEU = H00112_A26PortaRangoFinTEU[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPortaRangoFinTEU_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A26PortaRangoFinTEU), 12, 0)));
               A25PortaRangoIniTEU = H00112_A25PortaRangoIniTEU[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPortaRangoIniTEU_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A25PortaRangoIniTEU), 12, 0)));
               A24PortaRango = H00112_A24PortaRango[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPortaRango_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A24PortaRango), 4, 0)));
               /* Execute user event: E19112 */
               E19112 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 74;
            WB110( ) ;
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
                                              AV7cPortaRangoIniTEU ,
                                              AV8cPortaRangoFinTEU ,
                                              AV9cPortaTarifaTTA4 ,
                                              AV15cPortaTarifaTEU4 ,
                                              AV11cPortaTarifaTTA3 ,
                                              A25PortaRangoIniTEU ,
                                              A26PortaRangoFinTEU ,
                                              A27PortaTarifaTTA4 ,
                                              A28PortaTarifaTEU4 ,
                                              A29PortaTarifaTTA3 ,
                                              AV12pPortaContenedoresEsclusa ,
                                              AV6cPortaRango ,
                                              A22PortaContenedoresEsclusa },
                                              new int[] {
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL,
                                              TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         });
         /* Using cursor H00113 */
         pr_default.execute(1, new Object[] {AV12pPortaContenedoresEsclusa, AV6cPortaRango, AV7cPortaRangoIniTEU, AV8cPortaRangoFinTEU, AV9cPortaTarifaTTA4, AV15cPortaTarifaTEU4, AV11cPortaTarifaTTA3});
         GRID1_nRecordCount = H00113_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cPortaRango, AV7cPortaRangoIniTEU, AV8cPortaRangoFinTEU, AV9cPortaTarifaTTA4, AV15cPortaTarifaTEU4, AV11cPortaTarifaTTA3, AV12pPortaContenedoresEsclusa) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cPortaRango, AV7cPortaRangoIniTEU, AV8cPortaRangoFinTEU, AV9cPortaTarifaTTA4, AV15cPortaTarifaTEU4, AV11cPortaTarifaTTA3, AV12pPortaContenedoresEsclusa) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cPortaRango, AV7cPortaRangoIniTEU, AV8cPortaRangoFinTEU, AV9cPortaTarifaTTA4, AV15cPortaTarifaTEU4, AV11cPortaTarifaTTA3, AV12pPortaContenedoresEsclusa) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cPortaRango, AV7cPortaRangoIniTEU, AV8cPortaRangoFinTEU, AV9cPortaTarifaTTA4, AV15cPortaTarifaTEU4, AV11cPortaTarifaTTA3, AV12pPortaContenedoresEsclusa) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cPortaRango, AV7cPortaRangoIniTEU, AV8cPortaRangoFinTEU, AV9cPortaTarifaTTA4, AV15cPortaTarifaTEU4, AV11cPortaTarifaTTA3, AV12pPortaContenedoresEsclusa) ;
         }
         return (int)(0) ;
      }

      protected void STRUP110( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E18112 */
         E18112 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCportarango_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCportarango_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPORTARANGO");
               GX_FocusControl = edtavCportarango_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cPortaRango = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cPortaRango", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cPortaRango), 4, 0)));
            }
            else
            {
               AV6cPortaRango = (short)(context.localUtil.CToN( cgiGet( edtavCportarango_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cPortaRango", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cPortaRango), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCportarangoiniteu_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCportarangoiniteu_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPORTARANGOINITEU");
               GX_FocusControl = edtavCportarangoiniteu_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7cPortaRangoIniTEU = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cPortaRangoIniTEU", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cPortaRangoIniTEU), 12, 0)));
            }
            else
            {
               AV7cPortaRangoIniTEU = (long)(context.localUtil.CToN( cgiGet( edtavCportarangoiniteu_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cPortaRangoIniTEU", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cPortaRangoIniTEU), 12, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCportarangofinteu_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCportarangofinteu_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPORTARANGOFINTEU");
               GX_FocusControl = edtavCportarangofinteu_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8cPortaRangoFinTEU = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cPortaRangoFinTEU", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cPortaRangoFinTEU), 12, 0)));
            }
            else
            {
               AV8cPortaRangoFinTEU = (long)(context.localUtil.CToN( cgiGet( edtavCportarangofinteu_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cPortaRangoFinTEU", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cPortaRangoFinTEU), 12, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCportatarifatta4_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCportatarifatta4_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 9999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPORTATARIFATTA4");
               GX_FocusControl = edtavCportatarifatta4_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9cPortaTarifaTTA4 = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cPortaTarifaTTA4", StringUtil.LTrim( StringUtil.Str( AV9cPortaTarifaTTA4, 7, 2)));
            }
            else
            {
               AV9cPortaTarifaTTA4 = context.localUtil.CToN( cgiGet( edtavCportatarifatta4_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cPortaTarifaTTA4", StringUtil.LTrim( StringUtil.Str( AV9cPortaTarifaTTA4, 7, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCportatarifateu4_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCportatarifateu4_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 9999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPORTATARIFATEU4");
               GX_FocusControl = edtavCportatarifateu4_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV15cPortaTarifaTEU4 = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15cPortaTarifaTEU4", StringUtil.LTrim( StringUtil.Str( AV15cPortaTarifaTEU4, 7, 2)));
            }
            else
            {
               AV15cPortaTarifaTEU4 = context.localUtil.CToN( cgiGet( edtavCportatarifateu4_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15cPortaTarifaTEU4", StringUtil.LTrim( StringUtil.Str( AV15cPortaTarifaTEU4, 7, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCportatarifatta3_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCportatarifatta3_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 9999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPORTATARIFATTA3");
               GX_FocusControl = edtavCportatarifatta3_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11cPortaTarifaTTA3 = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cPortaTarifaTTA3", StringUtil.LTrim( StringUtil.Str( AV11cPortaTarifaTTA3, 7, 2)));
            }
            else
            {
               AV11cPortaTarifaTTA3 = context.localUtil.CToN( cgiGet( edtavCportatarifatta3_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cPortaTarifaTTA3", StringUtil.LTrim( StringUtil.Str( AV11cPortaTarifaTTA3, 7, 2)));
            }
            /* Read saved values. */
            nRC_GXsfl_74 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_74"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            AV12pPortaContenedoresEsclusa = (short)(context.localUtil.CToN( cgiGet( "vPPORTACONTENEDORESESCLUSA"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            AV13pPortaRango = (short)(context.localUtil.CToN( cgiGet( "vPPORTARANGO"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPORTARANGO"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV6cPortaRango )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPORTARANGOINITEU"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV7cPortaRangoIniTEU )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPORTARANGOFINTEU"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV8cPortaRangoFinTEU )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vCPORTATARIFATTA4"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV9cPortaTarifaTTA4 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vCPORTATARIFATEU4"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV15cPortaTarifaTEU4 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vCPORTATARIFATTA3"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV11cPortaTarifaTTA3 )
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
         /* Execute user event: E18112 */
         E18112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E18112( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( context.GetMessage( "GXSPC_SelectionList", ""), context.GetMessage( "Rango", ""), "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
         AV14ADVANCED_LABEL_TEMPLATE = context.GetMessage( "%1 <strong>%2</strong>", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ADVANCED_LABEL_TEMPLATE", AV14ADVANCED_LABEL_TEMPLATE);
      }

      private void E19112( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV18Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))));
         AV18Linkselection_GXI = GeneXus.Utils.GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV18Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))));
         sendrow_742( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ( nGXsfl_74_Refreshing == 0 ) )
         {
            context.DoAjaxLoad(74, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: E20112 */
         E20112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E20112( )
      {
         /* Enter Routine */
         AV13pPortaRango = A24PortaRango;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pPortaRango", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pPortaRango), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV13pPortaRango});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12pPortaContenedoresEsclusa = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pPortaContenedoresEsclusa", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pPortaContenedoresEsclusa), 4, 0)));
         AV13pPortaRango = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pPortaRango", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pPortaRango), 4, 0)));
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
         PA112( ) ;
         WS112( ) ;
         WE112( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?831912");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2015120833173");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages."+context.GetLanguageProperty( "code")+".js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("gx0071.js", "?2015120833173");
         /* End function include_jscripts */
      }

      protected void sendrow_742( )
      {
         sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
         edtPortaRango_Internalname = "PORTARANGO_"+sGXsfl_74_idx;
         edtPortaRangoIniTEU_Internalname = "PORTARANGOINITEU_"+sGXsfl_74_idx;
         edtPortaRangoFinTEU_Internalname = "PORTARANGOFINTEU_"+sGXsfl_74_idx;
         edtPortaTarifaTTA4_Internalname = "PORTATARIFATTA4_"+sGXsfl_74_idx;
         edtPortaTarifaTEU4_Internalname = "PORTATARIFATEU4_"+sGXsfl_74_idx;
         edtPortaTarifaTTA3_Internalname = "PORTATARIFATTA3_"+sGXsfl_74_idx;
         edtPortaTarifaTEU3_Internalname = "PORTATARIFATEU3_"+sGXsfl_74_idx;
         edtPortaTarifaTTA2_Internalname = "PORTATARIFATTA2_"+sGXsfl_74_idx;
         edtPortaTarifaTEU2_Internalname = "PORTATARIFATEU2_"+sGXsfl_74_idx;
         edtPortaTarifaTTA1_Internalname = "PORTATARIFATTA1_"+sGXsfl_74_idx;
         edtPortaTarifaTEU1_Internalname = "PORTATARIFATEU1_"+sGXsfl_74_idx;
         cmbPortaContenedoresEsclusa_Internalname = "PORTACONTENEDORESESCLUSA_"+sGXsfl_74_idx;
         WB110( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A24PortaRango), 4, 0, context.GetLanguageProperty( "decimal_point"), "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV18Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV18Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection)),(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"''",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPortaRango_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A24PortaRango), 4, 0, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( (decimal)(A24PortaRango), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPortaRango_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)1,(short)0,(bool)true,(String)"",(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPortaRangoIniTEU_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A25PortaRangoIniTEU), 12, 0, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( (decimal)(A25PortaRangoIniTEU), "ZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPortaRangoIniTEU_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)12,(short)0,(short)0,(short)74,(short)1,(short)1,(short)0,(bool)true,(String)"",(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPortaRangoFinTEU_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A26PortaRangoFinTEU), 12, 0, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( (decimal)(A26PortaRangoFinTEU), "ZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPortaRangoFinTEU_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)12,(short)0,(short)0,(short)74,(short)1,(short)1,(short)0,(bool)true,(String)"",(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPortaTarifaTTA4_Internalname,StringUtil.LTrim( StringUtil.NToC( A27PortaTarifaTTA4, 7, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A27PortaTarifaTTA4, "ZZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPortaTarifaTTA4_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)7,(short)0,(short)0,(short)74,(short)1,(short)1,(short)0,(bool)true,(String)"DominioTarifa",(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPortaTarifaTEU4_Internalname,StringUtil.LTrim( StringUtil.NToC( A28PortaTarifaTEU4, 7, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A28PortaTarifaTEU4, "ZZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPortaTarifaTEU4_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)7,(short)0,(short)0,(short)74,(short)1,(short)1,(short)0,(bool)true,(String)"DominioTarifa",(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPortaTarifaTTA3_Internalname,StringUtil.LTrim( StringUtil.NToC( A29PortaTarifaTTA3, 7, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A29PortaTarifaTTA3, "ZZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPortaTarifaTTA3_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)7,(short)0,(short)0,(short)74,(short)1,(short)1,(short)0,(bool)true,(String)"DominioTarifa",(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPortaTarifaTEU3_Internalname,StringUtil.LTrim( StringUtil.NToC( A30PortaTarifaTEU3, 7, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A30PortaTarifaTEU3, "ZZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPortaTarifaTEU3_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)7,(short)0,(short)0,(short)74,(short)1,(short)1,(short)0,(bool)true,(String)"DominioTarifa",(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPortaTarifaTTA2_Internalname,StringUtil.LTrim( StringUtil.NToC( A31PortaTarifaTTA2, 7, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A31PortaTarifaTTA2, "ZZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPortaTarifaTTA2_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)7,(short)0,(short)0,(short)74,(short)1,(short)1,(short)0,(bool)true,(String)"DominioTarifa",(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPortaTarifaTEU2_Internalname,StringUtil.LTrim( StringUtil.NToC( A32PortaTarifaTEU2, 7, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A32PortaTarifaTEU2, "ZZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPortaTarifaTEU2_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)7,(short)0,(short)0,(short)74,(short)1,(short)1,(short)0,(bool)true,(String)"DominioTarifa",(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPortaTarifaTTA1_Internalname,StringUtil.LTrim( StringUtil.NToC( A33PortaTarifaTTA1, 7, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A33PortaTarifaTTA1, "ZZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPortaTarifaTTA1_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)7,(short)0,(short)0,(short)74,(short)1,(short)1,(short)0,(bool)true,(String)"DominioTarifa",(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPortaTarifaTEU1_Internalname,StringUtil.LTrim( StringUtil.NToC( A34PortaTarifaTEU1, 7, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A34PortaTarifaTEU1, "ZZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPortaTarifaTEU1_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)7,(short)0,(short)0,(short)74,(short)1,(short)1,(short)0,(bool)true,(String)"DominioTarifa",(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            if ( ( nGXsfl_74_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "PORTACONTENEDORESESCLUSA_" + sGXsfl_74_idx;
               cmbPortaContenedoresEsclusa.Name = GXCCtl;
               cmbPortaContenedoresEsclusa.WebTags = "";
               cmbPortaContenedoresEsclusa.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), context.GetMessage( "GX_EmptyItemText", ""), 0);
               cmbPortaContenedoresEsclusa.addItem("1", context.GetMessage( "Panamax", ""), 0);
               cmbPortaContenedoresEsclusa.addItem("2", context.GetMessage( "Neopanamax", ""), 0);
               if ( cmbPortaContenedoresEsclusa.ItemCount > 0 )
               {
                  A22PortaContenedoresEsclusa = (short)(NumberUtil.Val( cmbPortaContenedoresEsclusa.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A22PortaContenedoresEsclusa), 4, 0))), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbPortaContenedoresEsclusa_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A22PortaContenedoresEsclusa), 4, 0)));
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbPortaContenedoresEsclusa,(String)cmbPortaContenedoresEsclusa_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A22PortaContenedoresEsclusa), 4, 0)),(short)1,(String)cmbPortaContenedoresEsclusa_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)0,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"",(String)"",(String)"",(bool)true});
            cmbPortaContenedoresEsclusa.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A22PortaContenedoresEsclusa), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPortaContenedoresEsclusa_Internalname, "Values", (String)(cmbPortaContenedoresEsclusa.ToJavascriptSource()));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_74_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1));
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
            edtPortaRango_Internalname = "PORTARANGO_"+sGXsfl_74_idx;
            edtPortaRangoIniTEU_Internalname = "PORTARANGOINITEU_"+sGXsfl_74_idx;
            edtPortaRangoFinTEU_Internalname = "PORTARANGOFINTEU_"+sGXsfl_74_idx;
            edtPortaTarifaTTA4_Internalname = "PORTATARIFATTA4_"+sGXsfl_74_idx;
            edtPortaTarifaTEU4_Internalname = "PORTATARIFATEU4_"+sGXsfl_74_idx;
            edtPortaTarifaTTA3_Internalname = "PORTATARIFATTA3_"+sGXsfl_74_idx;
            edtPortaTarifaTEU3_Internalname = "PORTATARIFATEU3_"+sGXsfl_74_idx;
            edtPortaTarifaTTA2_Internalname = "PORTATARIFATTA2_"+sGXsfl_74_idx;
            edtPortaTarifaTEU2_Internalname = "PORTATARIFATEU2_"+sGXsfl_74_idx;
            edtPortaTarifaTTA1_Internalname = "PORTATARIFATTA1_"+sGXsfl_74_idx;
            edtPortaTarifaTEU1_Internalname = "PORTATARIFATEU1_"+sGXsfl_74_idx;
            cmbPortaContenedoresEsclusa_Internalname = "PORTACONTENEDORESESCLUSA_"+sGXsfl_74_idx;
         }
         /* End function sendrow_742 */
      }

      protected void init_default_properties( )
      {
         lblLblportarangofilter_Internalname = "LBLPORTARANGOFILTER";
         lblLblportarangofilter_Internalname = "LBLPORTARANGOFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCportarango_Internalname = "vCPORTARANGO";
         edtavCportarango_Internalname = "vCPORTARANGO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divPortarangofiltercontainer_Internalname = "PORTARANGOFILTERCONTAINER";
         divPortarangofiltercontainer_Internalname = "PORTARANGOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLblportarangoiniteufilter_Internalname = "LBLPORTARANGOINITEUFILTER";
         lblLblportarangoiniteufilter_Internalname = "LBLPORTARANGOINITEUFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCportarangoiniteu_Internalname = "vCPORTARANGOINITEU";
         edtavCportarangoiniteu_Internalname = "vCPORTARANGOINITEU";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divPortarangoiniteufiltercontainer_Internalname = "PORTARANGOINITEUFILTERCONTAINER";
         divPortarangoiniteufiltercontainer_Internalname = "PORTARANGOINITEUFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLblportarangofinteufilter_Internalname = "LBLPORTARANGOFINTEUFILTER";
         lblLblportarangofinteufilter_Internalname = "LBLPORTARANGOFINTEUFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCportarangofinteu_Internalname = "vCPORTARANGOFINTEU";
         edtavCportarangofinteu_Internalname = "vCPORTARANGOFINTEU";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divPortarangofinteufiltercontainer_Internalname = "PORTARANGOFINTEUFILTERCONTAINER";
         divPortarangofinteufiltercontainer_Internalname = "PORTARANGOFINTEUFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLblportatarifatta4filter_Internalname = "LBLPORTATARIFATTA4FILTER";
         lblLblportatarifatta4filter_Internalname = "LBLPORTATARIFATTA4FILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCportatarifatta4_Internalname = "vCPORTATARIFATTA4";
         edtavCportatarifatta4_Internalname = "vCPORTATARIFATTA4";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divPortatarifatta4filtercontainer_Internalname = "PORTATARIFATTA4FILTERCONTAINER";
         divPortatarifatta4filtercontainer_Internalname = "PORTATARIFATTA4FILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLblportatarifateu4filter_Internalname = "LBLPORTATARIFATEU4FILTER";
         lblLblportatarifateu4filter_Internalname = "LBLPORTATARIFATEU4FILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCportatarifateu4_Internalname = "vCPORTATARIFATEU4";
         edtavCportatarifateu4_Internalname = "vCPORTATARIFATEU4";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divPortatarifateu4filtercontainer_Internalname = "PORTATARIFATEU4FILTERCONTAINER";
         divPortatarifateu4filtercontainer_Internalname = "PORTATARIFATEU4FILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLblportatarifatta3filter_Internalname = "LBLPORTATARIFATTA3FILTER";
         lblLblportatarifatta3filter_Internalname = "LBLPORTATARIFATTA3FILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCportatarifatta3_Internalname = "vCPORTATARIFATTA3";
         edtavCportatarifatta3_Internalname = "vCPORTATARIFATTA3";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divPortatarifatta3filtercontainer_Internalname = "PORTATARIFATTA3FILTERCONTAINER";
         divPortatarifatta3filtercontainer_Internalname = "PORTATARIFATTA3FILTERCONTAINER";
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
         edtPortaRango_Internalname = "PORTARANGO";
         edtPortaRangoIniTEU_Internalname = "PORTARANGOINITEU";
         edtPortaRangoFinTEU_Internalname = "PORTARANGOFINTEU";
         edtPortaTarifaTTA4_Internalname = "PORTATARIFATTA4";
         edtPortaTarifaTEU4_Internalname = "PORTATARIFATEU4";
         edtPortaTarifaTTA3_Internalname = "PORTATARIFATTA3";
         edtPortaTarifaTEU3_Internalname = "PORTATARIFATEU3";
         edtPortaTarifaTTA2_Internalname = "PORTATARIFATTA2";
         edtPortaTarifaTEU2_Internalname = "PORTATARIFATEU2";
         edtPortaTarifaTTA1_Internalname = "PORTATARIFATTA1";
         edtPortaTarifaTEU1_Internalname = "PORTATARIFATEU1";
         cmbPortaContenedoresEsclusa_Internalname = "PORTACONTENEDORESESCLUSA";
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
         cmbPortaContenedoresEsclusa_Jsonclick = "";
         edtPortaTarifaTEU1_Jsonclick = "";
         edtPortaTarifaTTA1_Jsonclick = "";
         edtPortaTarifaTEU2_Jsonclick = "";
         edtPortaTarifaTTA2_Jsonclick = "";
         edtPortaTarifaTEU3_Jsonclick = "";
         edtPortaTarifaTTA3_Jsonclick = "";
         edtPortaTarifaTEU4_Jsonclick = "";
         edtPortaTarifaTTA4_Jsonclick = "";
         edtPortaRangoFinTEU_Jsonclick = "";
         edtPortaRangoIniTEU_Jsonclick = "";
         edtPortaRango_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCportatarifatta3_Jsonclick = "";
         edtavCportatarifatta3_Enabled = 1;
         edtavCportatarifatta3_Visible = 1;
         edtavCportatarifateu4_Jsonclick = "";
         edtavCportatarifateu4_Enabled = 1;
         edtavCportatarifateu4_Visible = 1;
         edtavCportatarifatta4_Jsonclick = "";
         edtavCportatarifatta4_Enabled = 1;
         edtavCportatarifatta4_Visible = 1;
         edtavCportarangofinteu_Jsonclick = "";
         edtavCportarangofinteu_Enabled = 1;
         edtavCportarangofinteu_Visible = 1;
         edtavCportarangoiniteu_Jsonclick = "";
         edtavCportarangoiniteu_Enabled = 1;
         edtavCportarangoiniteu_Visible = 1;
         edtavCportarango_Jsonclick = "";
         edtavCportarango_Enabled = 1;
         edtavCportarango_Visible = 1;
         divPortatarifatta3filtercontainer_Class = "AdvancedContainerItem";
         divPortatarifateu4filtercontainer_Class = "AdvancedContainerItem";
         divPortatarifatta4filtercontainer_Class = "AdvancedContainerItem";
         divPortarangofinteufiltercontainer_Class = "AdvancedContainerItem";
         divPortarangoiniteufiltercontainer_Class = "AdvancedContainerItem";
         divPortarangofiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainer";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = context.GetMessage( "Selection List Rango", "");
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cPortaRango',fld:'vCPORTARANGO'},{av:'AV7cPortaRangoIniTEU',fld:'vCPORTARANGOINITEU'},{av:'AV8cPortaRangoFinTEU',fld:'vCPORTARANGOFINTEU'},{av:'AV9cPortaTarifaTTA4',fld:'vCPORTATARIFATTA4'},{av:'AV15cPortaTarifaTEU4',fld:'vCPORTATARIFATEU4'},{av:'AV11cPortaTarifaTTA3',fld:'vCPORTATARIFATTA3'},{av:'AV12pPortaContenedoresEsclusa',fld:'vPPORTACONTENEDORESESCLUSA'}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E17111',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLPORTARANGOFILTER.CLICK","{handler:'E11111',iparms:[{av:'divPortarangofiltercontainer_Class',ctrl:'PORTARANGOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divPortarangofiltercontainer_Class',ctrl:'PORTARANGOFILTERCONTAINER',prop:'Class'},{av:'edtavCportarango_Visible',ctrl:'vCPORTARANGO',prop:'Visible'}]}");
         setEventMetadata("LBLPORTARANGOINITEUFILTER.CLICK","{handler:'E12111',iparms:[{av:'divPortarangoiniteufiltercontainer_Class',ctrl:'PORTARANGOINITEUFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divPortarangoiniteufiltercontainer_Class',ctrl:'PORTARANGOINITEUFILTERCONTAINER',prop:'Class'},{av:'edtavCportarangoiniteu_Visible',ctrl:'vCPORTARANGOINITEU',prop:'Visible'}]}");
         setEventMetadata("LBLPORTARANGOFINTEUFILTER.CLICK","{handler:'E13111',iparms:[{av:'divPortarangofinteufiltercontainer_Class',ctrl:'PORTARANGOFINTEUFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divPortarangofinteufiltercontainer_Class',ctrl:'PORTARANGOFINTEUFILTERCONTAINER',prop:'Class'},{av:'edtavCportarangofinteu_Visible',ctrl:'vCPORTARANGOFINTEU',prop:'Visible'}]}");
         setEventMetadata("LBLPORTATARIFATTA4FILTER.CLICK","{handler:'E14111',iparms:[{av:'divPortatarifatta4filtercontainer_Class',ctrl:'PORTATARIFATTA4FILTERCONTAINER',prop:'Class'}],oparms:[{av:'divPortatarifatta4filtercontainer_Class',ctrl:'PORTATARIFATTA4FILTERCONTAINER',prop:'Class'},{av:'edtavCportatarifatta4_Visible',ctrl:'vCPORTATARIFATTA4',prop:'Visible'}]}");
         setEventMetadata("LBLPORTATARIFATEU4FILTER.CLICK","{handler:'E15111',iparms:[{av:'divPortatarifateu4filtercontainer_Class',ctrl:'PORTATARIFATEU4FILTERCONTAINER',prop:'Class'}],oparms:[{av:'divPortatarifateu4filtercontainer_Class',ctrl:'PORTATARIFATEU4FILTERCONTAINER',prop:'Class'},{av:'edtavCportatarifateu4_Visible',ctrl:'vCPORTATARIFATEU4',prop:'Visible'}]}");
         setEventMetadata("LBLPORTATARIFATTA3FILTER.CLICK","{handler:'E16111',iparms:[{av:'divPortatarifatta3filtercontainer_Class',ctrl:'PORTATARIFATTA3FILTERCONTAINER',prop:'Class'}],oparms:[{av:'divPortatarifatta3filtercontainer_Class',ctrl:'PORTATARIFATTA3FILTERCONTAINER',prop:'Class'},{av:'edtavCportatarifatta3_Visible',ctrl:'vCPORTATARIFATTA3',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E20112',iparms:[{av:'A24PortaRango',fld:'PORTARANGO'}],oparms:[{av:'AV13pPortaRango',fld:'vPPORTARANGO'}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cPortaRango',fld:'vCPORTARANGO'},{av:'AV7cPortaRangoIniTEU',fld:'vCPORTARANGOINITEU'},{av:'AV8cPortaRangoFinTEU',fld:'vCPORTARANGOFINTEU'},{av:'AV9cPortaTarifaTTA4',fld:'vCPORTATARIFATTA4'},{av:'AV15cPortaTarifaTEU4',fld:'vCPORTATARIFATEU4'},{av:'AV11cPortaTarifaTTA3',fld:'vCPORTATARIFATTA3'},{av:'AV12pPortaContenedoresEsclusa',fld:'vPPORTACONTENEDORESESCLUSA'}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cPortaRango',fld:'vCPORTARANGO'},{av:'AV7cPortaRangoIniTEU',fld:'vCPORTARANGOINITEU'},{av:'AV8cPortaRangoFinTEU',fld:'vCPORTARANGOFINTEU'},{av:'AV9cPortaTarifaTTA4',fld:'vCPORTATARIFATTA4'},{av:'AV15cPortaTarifaTEU4',fld:'vCPORTATARIFATEU4'},{av:'AV11cPortaTarifaTTA3',fld:'vCPORTATARIFATTA3'},{av:'AV12pPortaContenedoresEsclusa',fld:'vPPORTACONTENEDORESESCLUSA'}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cPortaRango',fld:'vCPORTARANGO'},{av:'AV7cPortaRangoIniTEU',fld:'vCPORTARANGOINITEU'},{av:'AV8cPortaRangoFinTEU',fld:'vCPORTARANGOFINTEU'},{av:'AV9cPortaTarifaTTA4',fld:'vCPORTATARIFATTA4'},{av:'AV15cPortaTarifaTEU4',fld:'vCPORTATARIFATEU4'},{av:'AV11cPortaTarifaTTA3',fld:'vCPORTATARIFATTA3'},{av:'AV12pPortaContenedoresEsclusa',fld:'vPPORTACONTENEDORESESCLUSA'}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cPortaRango',fld:'vCPORTARANGO'},{av:'AV7cPortaRangoIniTEU',fld:'vCPORTARANGOINITEU'},{av:'AV8cPortaRangoFinTEU',fld:'vCPORTARANGOFINTEU'},{av:'AV9cPortaTarifaTTA4',fld:'vCPORTATARIFATTA4'},{av:'AV15cPortaTarifaTEU4',fld:'vCPORTATARIFATEU4'},{av:'AV11cPortaTarifaTTA3',fld:'vCPORTATARIFATTA3'},{av:'AV12pPortaContenedoresEsclusa',fld:'vPPORTACONTENEDORESESCLUSA'}],oparms:[]}");
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
         lblLblportarangofilter_Jsonclick = "";
         TempTags = "";
         lblLblportarangoiniteufilter_Jsonclick = "";
         lblLblportarangofinteufilter_Jsonclick = "";
         lblLblportatarifatta4filter_Jsonclick = "";
         lblLblportatarifateu4filter_Jsonclick = "";
         lblLblportatarifatta3filter_Jsonclick = "";
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
         AV18Linkselection_GXI = "";
         GXKey = "";
         GXCCtl = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         scmdbuf = "";
         H00112_A22PortaContenedoresEsclusa = new short[1] ;
         H00112_A34PortaTarifaTEU1 = new decimal[1] ;
         H00112_A33PortaTarifaTTA1 = new decimal[1] ;
         H00112_A32PortaTarifaTEU2 = new decimal[1] ;
         H00112_A31PortaTarifaTTA2 = new decimal[1] ;
         H00112_A30PortaTarifaTEU3 = new decimal[1] ;
         H00112_A29PortaTarifaTTA3 = new decimal[1] ;
         H00112_A28PortaTarifaTEU4 = new decimal[1] ;
         H00112_A27PortaTarifaTTA4 = new decimal[1] ;
         H00112_A26PortaRangoFinTEU = new long[1] ;
         H00112_A25PortaRangoIniTEU = new long[1] ;
         H00112_A24PortaRango = new short[1] ;
         H00113_AGRID1_nRecordCount = new long[1] ;
         AV14ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0071__default(),
            new Object[][] {
                new Object[] {
               H00112_A22PortaContenedoresEsclusa, H00112_A34PortaTarifaTEU1, H00112_A33PortaTarifaTTA1, H00112_A32PortaTarifaTEU2, H00112_A31PortaTarifaTTA2, H00112_A30PortaTarifaTEU3, H00112_A29PortaTarifaTTA3, H00112_A28PortaTarifaTEU4, H00112_A27PortaTarifaTTA4, H00112_A26PortaRangoFinTEU,
               H00112_A25PortaRangoIniTEU, H00112_A24PortaRango
               }
               , new Object[] {
               H00113_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV12pPortaContenedoresEsclusa ;
      private short wcpOAV12pPortaContenedoresEsclusa ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_74 ;
      private short nGXsfl_74_idx=1 ;
      private short AV6cPortaRango ;
      private short AV13pPortaRango ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A24PortaRango ;
      private short A22PortaContenedoresEsclusa ;
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
      private int edtavCportarango_Enabled ;
      private int edtavCportarango_Visible ;
      private int edtavCportarangoiniteu_Enabled ;
      private int edtavCportarangoiniteu_Visible ;
      private int edtavCportarangofinteu_Enabled ;
      private int edtavCportarangofinteu_Visible ;
      private int edtavCportatarifatta4_Enabled ;
      private int edtavCportatarifatta4_Visible ;
      private int edtavCportatarifateu4_Enabled ;
      private int edtavCportatarifateu4_Visible ;
      private int edtavCportatarifatta3_Enabled ;
      private int edtavCportatarifatta3_Visible ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long AV7cPortaRangoIniTEU ;
      private long AV8cPortaRangoFinTEU ;
      private long GRID1_nFirstRecordOnPage ;
      private long A25PortaRangoIniTEU ;
      private long A26PortaRangoFinTEU ;
      private long GXPagingTo2 ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private decimal AV9cPortaTarifaTTA4 ;
      private decimal AV15cPortaTarifaTEU4 ;
      private decimal AV11cPortaTarifaTTA3 ;
      private decimal A27PortaTarifaTTA4 ;
      private decimal A28PortaTarifaTEU4 ;
      private decimal A29PortaTarifaTTA3 ;
      private decimal A30PortaTarifaTEU3 ;
      private decimal A31PortaTarifaTTA2 ;
      private decimal A32PortaTarifaTEU2 ;
      private decimal A33PortaTarifaTTA1 ;
      private decimal A34PortaTarifaTEU1 ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divPortarangofiltercontainer_Class ;
      private String divPortarangoiniteufiltercontainer_Class ;
      private String divPortarangofinteufiltercontainer_Class ;
      private String divPortatarifatta4filtercontainer_Class ;
      private String divPortatarifateu4filtercontainer_Class ;
      private String divPortatarifatta3filtercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_74_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divPortarangofiltercontainer_Internalname ;
      private String lblLblportarangofilter_Internalname ;
      private String lblLblportarangofilter_Jsonclick ;
      private String TempTags ;
      private String edtavCportarango_Internalname ;
      private String edtavCportarango_Jsonclick ;
      private String divPortarangoiniteufiltercontainer_Internalname ;
      private String lblLblportarangoiniteufilter_Internalname ;
      private String lblLblportarangoiniteufilter_Jsonclick ;
      private String edtavCportarangoiniteu_Internalname ;
      private String edtavCportarangoiniteu_Jsonclick ;
      private String divPortarangofinteufiltercontainer_Internalname ;
      private String lblLblportarangofinteufilter_Internalname ;
      private String lblLblportarangofinteufilter_Jsonclick ;
      private String edtavCportarangofinteu_Internalname ;
      private String edtavCportarangofinteu_Jsonclick ;
      private String divPortatarifatta4filtercontainer_Internalname ;
      private String lblLblportatarifatta4filter_Internalname ;
      private String lblLblportatarifatta4filter_Jsonclick ;
      private String edtavCportatarifatta4_Internalname ;
      private String edtavCportatarifatta4_Jsonclick ;
      private String divPortatarifateu4filtercontainer_Internalname ;
      private String lblLblportatarifateu4filter_Internalname ;
      private String lblLblportatarifateu4filter_Jsonclick ;
      private String edtavCportatarifateu4_Internalname ;
      private String edtavCportatarifateu4_Jsonclick ;
      private String divPortatarifatta3filtercontainer_Internalname ;
      private String lblLblportatarifatta3filter_Internalname ;
      private String lblLblportatarifatta3filter_Jsonclick ;
      private String edtavCportatarifatta3_Internalname ;
      private String edtavCportatarifatta3_Jsonclick ;
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
      private String edtPortaRango_Internalname ;
      private String edtPortaRangoIniTEU_Internalname ;
      private String edtPortaRangoFinTEU_Internalname ;
      private String edtPortaTarifaTTA4_Internalname ;
      private String edtPortaTarifaTEU4_Internalname ;
      private String edtPortaTarifaTTA3_Internalname ;
      private String edtPortaTarifaTEU3_Internalname ;
      private String edtPortaTarifaTTA2_Internalname ;
      private String edtPortaTarifaTEU2_Internalname ;
      private String edtPortaTarifaTTA1_Internalname ;
      private String edtPortaTarifaTEU1_Internalname ;
      private String cmbPortaContenedoresEsclusa_Internalname ;
      private String GXKey ;
      private String GXCCtl ;
      private String scmdbuf ;
      private String AV14ADVANCED_LABEL_TEMPLATE ;
      private String ROClassString ;
      private String edtPortaRango_Jsonclick ;
      private String edtPortaRangoIniTEU_Jsonclick ;
      private String edtPortaRangoFinTEU_Jsonclick ;
      private String edtPortaTarifaTTA4_Jsonclick ;
      private String edtPortaTarifaTEU4_Jsonclick ;
      private String edtPortaTarifaTTA3_Jsonclick ;
      private String edtPortaTarifaTEU3_Jsonclick ;
      private String edtPortaTarifaTTA2_Jsonclick ;
      private String edtPortaTarifaTEU2_Jsonclick ;
      private String edtPortaTarifaTTA1_Jsonclick ;
      private String edtPortaTarifaTEU1_Jsonclick ;
      private String cmbPortaContenedoresEsclusa_Jsonclick ;
      private String div_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV18Linkselection_GXI ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbPortaContenedoresEsclusa ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_default ;
      private short[] H00112_A22PortaContenedoresEsclusa ;
      private decimal[] H00112_A34PortaTarifaTEU1 ;
      private decimal[] H00112_A33PortaTarifaTTA1 ;
      private decimal[] H00112_A32PortaTarifaTEU2 ;
      private decimal[] H00112_A31PortaTarifaTTA2 ;
      private decimal[] H00112_A30PortaTarifaTEU3 ;
      private decimal[] H00112_A29PortaTarifaTTA3 ;
      private decimal[] H00112_A28PortaTarifaTEU4 ;
      private decimal[] H00112_A27PortaTarifaTTA4 ;
      private long[] H00112_A26PortaRangoFinTEU ;
      private long[] H00112_A25PortaRangoIniTEU ;
      private short[] H00112_A24PortaRango ;
      private long[] H00113_AGRID1_nRecordCount ;
      private short aP1_pPortaRango ;
      private GXWebForm Form ;
   }

   public class gx0071__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00112( IGxContext context ,
                                             long AV7cPortaRangoIniTEU ,
                                             long AV8cPortaRangoFinTEU ,
                                             decimal AV9cPortaTarifaTTA4 ,
                                             decimal AV15cPortaTarifaTEU4 ,
                                             decimal AV11cPortaTarifaTTA3 ,
                                             long A25PortaRangoIniTEU ,
                                             long A26PortaRangoFinTEU ,
                                             decimal A27PortaTarifaTTA4 ,
                                             decimal A28PortaTarifaTEU4 ,
                                             decimal A29PortaTarifaTTA3 ,
                                             short AV12pPortaContenedoresEsclusa ,
                                             short AV6cPortaRango ,
                                             short A22PortaContenedoresEsclusa )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [12] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [PortaContenedoresEsclusa], [PortaTarifaTEU1], [PortaTarifaTTA1], [PortaTarifaTEU2], [PortaTarifaTTA2], [PortaTarifaTEU3], [PortaTarifaTTA3], [PortaTarifaTEU4], [PortaTarifaTTA4], [PortaRangoFinTEU], [PortaRangoIniTEU], [PortaRango]";
         sFromString = " FROM [PortaContenedoresRango] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([PortaContenedoresEsclusa] = @AV12pPortaContenedoresEsclusa and [PortaRango] >= @AV6cPortaRango)";
         if ( ! (0==AV7cPortaRangoIniTEU) )
         {
            sWhereString = sWhereString + " and ([PortaRangoIniTEU] >= @AV7cPortaRangoIniTEU)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (0==AV8cPortaRangoFinTEU) )
         {
            sWhereString = sWhereString + " and ([PortaRangoFinTEU] >= @AV8cPortaRangoFinTEU)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV9cPortaTarifaTTA4) )
         {
            sWhereString = sWhereString + " and ([PortaTarifaTTA4] >= @AV9cPortaTarifaTTA4)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV15cPortaTarifaTEU4) )
         {
            sWhereString = sWhereString + " and ([PortaTarifaTEU4] >= @AV15cPortaTarifaTEU4)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV11cPortaTarifaTTA3) )
         {
            sWhereString = sWhereString + " and ([PortaTarifaTTA3] >= @AV11cPortaTarifaTTA3)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [PortaContenedoresEsclusa], [PortaRango]";
         scmdbuf = "SELECT * FROM (SELECT " + sSelectString + ", ROW_NUMBER() OVER (" + sOrderString + " ) AS GX_ROW_NUMBER" + sFromString + sWhereString + ") AS GX_CTE WHERE GX_ROW_NUMBER" + " BETWEEN " + "@GXPagingFrom2" + " AND " + "@GXPagingTo2" + " OR " + "@GXPagingTo2" + " < " + "@GXPagingFrom2" + " AND GX_ROW_NUMBER >= " + "@GXPagingFrom2";
         scmdbuf = scmdbuf + " OPTION (FAST 11)";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H00113( IGxContext context ,
                                             long AV7cPortaRangoIniTEU ,
                                             long AV8cPortaRangoFinTEU ,
                                             decimal AV9cPortaTarifaTTA4 ,
                                             decimal AV15cPortaTarifaTEU4 ,
                                             decimal AV11cPortaTarifaTTA3 ,
                                             long A25PortaRangoIniTEU ,
                                             long A26PortaRangoFinTEU ,
                                             decimal A27PortaTarifaTTA4 ,
                                             decimal A28PortaTarifaTEU4 ,
                                             decimal A29PortaTarifaTTA3 ,
                                             short AV12pPortaContenedoresEsclusa ,
                                             short AV6cPortaRango ,
                                             short A22PortaContenedoresEsclusa )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [PortaContenedoresRango] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([PortaContenedoresEsclusa] = @AV12pPortaContenedoresEsclusa and [PortaRango] >= @AV6cPortaRango)";
         if ( ! (0==AV7cPortaRangoIniTEU) )
         {
            sWhereString = sWhereString + " and ([PortaRangoIniTEU] >= @AV7cPortaRangoIniTEU)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV8cPortaRangoFinTEU) )
         {
            sWhereString = sWhereString + " and ([PortaRangoFinTEU] >= @AV8cPortaRangoFinTEU)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV9cPortaTarifaTTA4) )
         {
            sWhereString = sWhereString + " and ([PortaTarifaTTA4] >= @AV9cPortaTarifaTTA4)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV15cPortaTarifaTEU4) )
         {
            sWhereString = sWhereString + " and ([PortaTarifaTEU4] >= @AV15cPortaTarifaTEU4)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV11cPortaTarifaTTA3) )
         {
            sWhereString = sWhereString + " and ([PortaTarifaTTA3] >= @AV11cPortaTarifaTTA3)";
         }
         else
         {
            GXv_int3[6] = 1;
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
                     return conditional_H00112(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (decimal)dynConstraints[2] , (decimal)dynConstraints[3] , (decimal)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (decimal)dynConstraints[7] , (decimal)dynConstraints[8] , (decimal)dynConstraints[9] , (short)dynConstraints[10] , (short)dynConstraints[11] , (short)dynConstraints[12] );
               case 1 :
                     return conditional_H00113(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (decimal)dynConstraints[2] , (decimal)dynConstraints[3] , (decimal)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (decimal)dynConstraints[7] , (decimal)dynConstraints[8] , (decimal)dynConstraints[9] , (short)dynConstraints[10] , (short)dynConstraints[11] , (short)dynConstraints[12] );
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
          Object[] prmH00112 ;
          prmH00112 = new Object[] {
          new Object[] {"@AV12pPortaContenedoresEsclusa",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6cPortaRango",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cPortaRangoIniTEU",SqlDbType.Decimal,12,0} ,
          new Object[] {"@AV8cPortaRangoFinTEU",SqlDbType.Decimal,12,0} ,
          new Object[] {"@AV9cPortaTarifaTTA4",SqlDbType.Decimal,7,2} ,
          new Object[] {"@AV15cPortaTarifaTEU4",SqlDbType.Decimal,7,2} ,
          new Object[] {"@AV11cPortaTarifaTTA3",SqlDbType.Decimal,7,2} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,6,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Decimal,12,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Decimal,12,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,6,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,6,0}
          } ;
          Object[] prmH00113 ;
          prmH00113 = new Object[] {
          new Object[] {"@AV12pPortaContenedoresEsclusa",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6cPortaRango",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cPortaRangoIniTEU",SqlDbType.Decimal,12,0} ,
          new Object[] {"@AV8cPortaRangoFinTEU",SqlDbType.Decimal,12,0} ,
          new Object[] {"@AV9cPortaTarifaTTA4",SqlDbType.Decimal,7,2} ,
          new Object[] {"@AV15cPortaTarifaTEU4",SqlDbType.Decimal,7,2} ,
          new Object[] {"@AV11cPortaTarifaTTA3",SqlDbType.Decimal,7,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00112", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00112,11,0,false,false )
             ,new CursorDef("H00113", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00113,1,0,false,false )
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
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((decimal[]) buf[7])[0] = rslt.getDecimal(8) ;
                ((decimal[]) buf[8])[0] = rslt.getDecimal(9) ;
                ((long[]) buf[9])[0] = rslt.getLong(10) ;
                ((long[]) buf[10])[0] = rslt.getLong(11) ;
                ((short[]) buf[11])[0] = rslt.getShort(12) ;
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
                   stmt.SetParameter(sIdx, (short)parms[12]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[13]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[15]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[16]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[17]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[18]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[19]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[20]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[21]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[23]);
                }
                break;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[7]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[8]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[9]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[11]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[13]);
                }
                break;
       }
    }

 }

}
