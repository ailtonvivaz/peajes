/*
               File: Gx00B0
        Description: Selection List Transaccion para el segmento de buques de pasajeros
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 10:41:41.50
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
   public class gx00b0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00b0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public gx00b0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out short aP0_pPASAJEROS_ID )
      {
         this.AV13pPASAJEROS_ID = 0 ;
         executePrivate();
         aP0_pPASAJEROS_ID=this.AV13pPASAJEROS_ID;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavCpasajeros_esclusa = new GXCombobox();
         cmbavCpasajeros_tipo_tarifa = new GXCombobox();
         cmbavCpasajeros_carga = new GXCombobox();
         cmbPASAJEROS_ESCLUSA = new GXCombobox();
         cmbPASAJEROS_TIPO_TARIFA = new GXCombobox();
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
               nRC_GXsfl_84 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_84_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_84_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_GXsfl_84, nGXsfl_84_idx, sGXsfl_84_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               subGrid1_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV6cPASAJEROS_ID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cPASAJEROS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cPASAJEROS_ID), 4, 0)));
               AV7cPASAJEROS_ESCLUSA = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cPASAJEROS_ESCLUSA", AV7cPASAJEROS_ESCLUSA);
               AV8cPASAJEROS_TIPO_TARIFA = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cPASAJEROS_TIPO_TARIFA", AV8cPASAJEROS_TIPO_TARIFA);
               AV9cPASAJEROS_CARGA = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cPASAJEROS_CARGA", AV9cPASAJEROS_CARGA);
               AV10cPASAJEROS_ID_TON_TARIF = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cPASAJEROS_ID_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cPASAJEROS_ID_TON_TARIF), 4, 0)));
               AV11cPASAJEROS_TON_TARIFA = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cPASAJEROS_TON_TARIFA", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cPASAJEROS_TON_TARIFA), 10, 0)));
               AV12cPASAJEROS_TARIFA = NumberUtil.Val( GetNextPar( ), ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cPASAJEROS_TARIFA", StringUtil.LTrim( StringUtil.Str( AV12cPASAJEROS_TARIFA, 10, 2)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cPASAJEROS_ID, AV7cPASAJEROS_ESCLUSA, AV8cPASAJEROS_TIPO_TARIFA, AV9cPASAJEROS_CARGA, AV10cPASAJEROS_ID_TON_TARIF, AV11cPASAJEROS_TON_TARIFA, AV12cPASAJEROS_TARIFA) ;
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
               AV13pPASAJEROS_ID = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pPASAJEROS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pPASAJEROS_ID), 4, 0)));
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
         PA1P2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1P2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201512010414153");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx00b0.aspx") + "?" + UrlEncode("" +AV13pPASAJEROS_ID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCPASAJEROS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cPASAJEROS_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPASAJEROS_ESCLUSA", StringUtil.RTrim( AV7cPASAJEROS_ESCLUSA));
         GxWebStd.gx_hidden_field( context, "GXH_vCPASAJEROS_TIPO_TARIFA", StringUtil.RTrim( AV8cPASAJEROS_TIPO_TARIFA));
         GxWebStd.gx_hidden_field( context, "GXH_vCPASAJEROS_CARGA", StringUtil.RTrim( AV9cPASAJEROS_CARGA));
         GxWebStd.gx_hidden_field( context, "GXH_vCPASAJEROS_ID_TON_TARIF", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cPASAJEROS_ID_TON_TARIF), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPASAJEROS_TON_TARIFA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cPASAJEROS_TON_TARIFA), 10, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPASAJEROS_TARIFA", StringUtil.LTrim( StringUtil.NToC( AV12cPASAJEROS_TARIFA, 10, 2, context.GetLanguageProperty( "decimal_point"), "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_84", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_84), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "vPPASAJEROS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pPASAJEROS_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "PASAJEROS_IDFILTERCONTAINER_Class", StringUtil.RTrim( divPasajeros_idfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PASAJEROS_ESCLUSAFILTERCONTAINER_Class", StringUtil.RTrim( divPasajeros_esclusafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PASAJEROS_TIPO_TARIFAFILTERCONTAINER_Class", StringUtil.RTrim( divPasajeros_tipo_tarifafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PASAJEROS_CARGAFILTERCONTAINER_Class", StringUtil.RTrim( divPasajeros_cargafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PASAJEROS_ID_TON_TARIFFILTERCONTAINER_Class", StringUtil.RTrim( divPasajeros_id_ton_tariffiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PASAJEROS_TON_TARIFAFILTERCONTAINER_Class", StringUtil.RTrim( divPasajeros_ton_tarifafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "PASAJEROS_TARIFAFILTERCONTAINER_Class", StringUtil.RTrim( divPasajeros_tarifafiltercontainer_Class));
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
            WE1P2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1P2( ) ;
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
         return formatLink("gx00b0.aspx") + "?" + UrlEncode("" +AV13pPASAJEROS_ID) ;
      }

      public override String GetPgmname( )
      {
         return "gx00b0" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "Selection List Transaccion para el segmento de buques de pasajeros", "") ;
      }

      protected void WB1P0( )
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
            GxWebStd.gx_div_start( context, divPasajeros_idfiltercontainer_Internalname, 1, 0, "px", 0, "px", divPasajeros_idfiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblpasajeros_idfilter_Internalname, context.GetMessage( "Identificador unico de la transaccion", ""), "", "", lblLblpasajeros_idfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e111p1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00B0.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 WWFiltersCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCpasajeros_id_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cPASAJEROS_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCpasajeros_id_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cPASAJEROS_ID), "ZZZ9")) : context.localUtil.Format( (decimal)(AV6cPASAJEROS_ID), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCpasajeros_id_Jsonclick, 0, "Attribute", "", "", "", edtavCpasajeros_id_Visible, edtavCpasajeros_id_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx00B0.htm");
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
            GxWebStd.gx_div_start( context, divPasajeros_esclusafiltercontainer_Internalname, 1, 0, "px", 0, "px", divPasajeros_esclusafiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblpasajeros_esclusafilter_Internalname, context.GetMessage( "Identificador unico de la transaccion", ""), "", "", lblLblpasajeros_esclusafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e121p1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00B0.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 WWFiltersCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_84_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCpasajeros_esclusa, cmbavCpasajeros_esclusa_Internalname, AV7cPASAJEROS_ESCLUSA, 1, cmbavCpasajeros_esclusa_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", cmbavCpasajeros_esclusa.Visible, cmbavCpasajeros_esclusa.Enabled, 0, 0, 40, "chr", 0, "", "", "Attribute", "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(26);\"", "", true, "HLP_Gx00B0.htm");
            cmbavCpasajeros_esclusa.CurrentValue = AV7cPASAJEROS_ESCLUSA;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCpasajeros_esclusa_Internalname, "Values", (String)(cmbavCpasajeros_esclusa.ToJavascriptSource()));
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
            GxWebStd.gx_div_start( context, divPasajeros_tipo_tarifafiltercontainer_Internalname, 1, 0, "px", 0, "px", divPasajeros_tipo_tarifafiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblpasajeros_tipo_tarifafilter_Internalname, context.GetMessage( "Tipo de tarifa del peaje: Litera, CP/SUAB", ""), "", "", lblLblpasajeros_tipo_tarifafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e131p1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00B0.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 WWFiltersCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_84_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCpasajeros_tipo_tarifa, cmbavCpasajeros_tipo_tarifa_Internalname, AV8cPASAJEROS_TIPO_TARIFA, 1, cmbavCpasajeros_tipo_tarifa_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", cmbavCpasajeros_tipo_tarifa.Visible, cmbavCpasajeros_tipo_tarifa.Enabled, 0, 0, 10, "chr", 0, "", "", "Attribute", "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(36);\"", "", true, "HLP_Gx00B0.htm");
            cmbavCpasajeros_tipo_tarifa.CurrentValue = AV8cPASAJEROS_TIPO_TARIFA;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCpasajeros_tipo_tarifa_Internalname, "Values", (String)(cmbavCpasajeros_tipo_tarifa.ToJavascriptSource()));
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
            GxWebStd.gx_div_start( context, divPasajeros_cargafiltercontainer_Internalname, 1, 0, "px", 0, "px", divPasajeros_cargafiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblpasajeros_cargafilter_Internalname, context.GetMessage( "Estado en el que viaja el buque: Cargado, En Lastre", ""), "", "", lblLblpasajeros_cargafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e141p1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00B0.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 WWFiltersCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_84_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCpasajeros_carga, cmbavCpasajeros_carga_Internalname, AV9cPASAJEROS_CARGA, 1, cmbavCpasajeros_carga_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", cmbavCpasajeros_carga.Visible, cmbavCpasajeros_carga.Enabled, 0, 0, 40, "chr", 0, "", "", "Attribute", "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(46);\"", "", true, "HLP_Gx00B0.htm");
            cmbavCpasajeros_carga.CurrentValue = AV9cPASAJEROS_CARGA;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCpasajeros_carga_Internalname, "Values", (String)(cmbavCpasajeros_carga.ToJavascriptSource()));
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
            GxWebStd.gx_div_start( context, divPasajeros_id_ton_tariffiltercontainer_Internalname, 1, 0, "px", 0, "px", divPasajeros_id_ton_tariffiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblpasajeros_id_ton_tariffilter_Internalname, context.GetMessage( "Identificador unico para las tarifas con cobro por CP/SUAB", ""), "", "", lblLblpasajeros_id_ton_tariffilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e151p1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00B0.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 WWFiltersCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCpasajeros_id_ton_tarif_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cPASAJEROS_ID_TON_TARIF), 4, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCpasajeros_id_ton_tarif_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10cPASAJEROS_ID_TON_TARIF), "ZZZ9")) : context.localUtil.Format( (decimal)(AV10cPASAJEROS_ID_TON_TARIF), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCpasajeros_id_ton_tarif_Jsonclick, 0, "Attribute", "", "", "", edtavCpasajeros_id_ton_tarif_Visible, edtavCpasajeros_id_ton_tarif_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx00B0.htm");
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
            GxWebStd.gx_div_start( context, divPasajeros_ton_tarifafiltercontainer_Internalname, 1, 0, "px", 0, "px", divPasajeros_ton_tarifafiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblpasajeros_ton_tarifafilter_Internalname, context.GetMessage( "Rango de las toneladas totales para el cobro CP/SUAB", ""), "", "", lblLblpasajeros_ton_tarifafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e161p1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00B0.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 WWFiltersCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCpasajeros_ton_tarifa_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cPASAJEROS_TON_TARIFA), 10, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCpasajeros_ton_tarifa_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11cPASAJEROS_TON_TARIFA), "ZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV11cPASAJEROS_TON_TARIFA), "ZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCpasajeros_ton_tarifa_Jsonclick, 0, "Attribute", "", "", "", edtavCpasajeros_ton_tarifa_Visible, edtavCpasajeros_ton_tarifa_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx00B0.htm");
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
            GxWebStd.gx_div_start( context, divPasajeros_tarifafiltercontainer_Internalname, 1, 0, "px", 0, "px", divPasajeros_tarifafiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblpasajeros_tarifafilter_Internalname, context.GetMessage( "Tarifa para el cobro del peaje", ""), "", "", lblLblpasajeros_tarifafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e171p1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00B0.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 WWFiltersCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCpasajeros_tarifa_Internalname, StringUtil.LTrim( StringUtil.NToC( AV12cPASAJEROS_TARIFA, 10, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCpasajeros_tarifa_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV12cPASAJEROS_TARIFA, "ZZZZZZ9.99")) : context.localUtil.Format( AV12cPASAJEROS_TARIFA, "ZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCpasajeros_tarifa_Jsonclick, 0, "Attribute", "", "", "", edtavCpasajeros_tarifa_Visible, edtavCpasajeros_tarifa_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx00B0.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e181p1_client"+"'", TempTags, "", 2, "HLP_Gx00B0.htm");
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" gxgridid=\"84\">") ;
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Esclusa", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tipo Tarifa", "")) ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A63PASAJEROS_ID), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A58PASAJEROS_ESCLUSA));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A60PASAJEROS_TIPO_TARIFA));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 84 )
         {
            wbEnd = 0;
            nRC_GXsfl_84 = (short)(nGXsfl_84_idx-1);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", context.GetMessage( "GX_BtnCancel", ""), bttBtn_cancel_Jsonclick, 1, context.GetMessage( "GX_BtnCancel", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx00B0.htm");
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

      protected void START1P2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_2-86442", 0) ;
            Form.Meta.addItem("description", context.GetMessage( "Selection List Transaccion para el segmento de buques de pasajeros", ""), 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1P0( ) ;
      }

      protected void WS1P2( )
      {
         START1P2( ) ;
         EVT1P2( ) ;
      }

      protected void EVT1P2( )
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
                              nGXsfl_84_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
                              edtPASAJEROS_ID_Internalname = "PASAJEROS_ID_"+sGXsfl_84_idx;
                              cmbPASAJEROS_ESCLUSA_Internalname = "PASAJEROS_ESCLUSA_"+sGXsfl_84_idx;
                              cmbPASAJEROS_TIPO_TARIFA_Internalname = "PASAJEROS_TIPO_TARIFA_"+sGXsfl_84_idx;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV17Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))));
                              A63PASAJEROS_ID = (short)(context.localUtil.CToN( cgiGet( edtPASAJEROS_ID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPASAJEROS_ID_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A63PASAJEROS_ID), 4, 0)));
                              cmbPASAJEROS_ESCLUSA.Name = cmbPASAJEROS_ESCLUSA_Internalname;
                              cmbPASAJEROS_ESCLUSA.CurrentValue = cgiGet( cmbPASAJEROS_ESCLUSA_Internalname);
                              A58PASAJEROS_ESCLUSA = cgiGet( cmbPASAJEROS_ESCLUSA_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbPASAJEROS_ESCLUSA_Internalname, A58PASAJEROS_ESCLUSA);
                              cmbPASAJEROS_TIPO_TARIFA.Name = cmbPASAJEROS_TIPO_TARIFA_Internalname;
                              cmbPASAJEROS_TIPO_TARIFA.CurrentValue = cgiGet( cmbPASAJEROS_TIPO_TARIFA_Internalname);
                              A60PASAJEROS_TIPO_TARIFA = cgiGet( cmbPASAJEROS_TIPO_TARIFA_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbPASAJEROS_TIPO_TARIFA_Internalname, A60PASAJEROS_TIPO_TARIFA);
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E191P2 */
                                    E191P2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E201P2 */
                                    E201P2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cpasajeros_id Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPASAJEROS_ID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV6cPASAJEROS_ID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cpasajeros_esclusa Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCPASAJEROS_ESCLUSA"), AV7cPASAJEROS_ESCLUSA) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cpasajeros_tipo_tarifa Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCPASAJEROS_TIPO_TARIFA"), AV8cPASAJEROS_TIPO_TARIFA) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cpasajeros_carga Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCPASAJEROS_CARGA"), AV9cPASAJEROS_CARGA) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cpasajeros_id_ton_tarif Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPASAJEROS_ID_TON_TARIF"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV10cPASAJEROS_ID_TON_TARIF )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cpasajeros_ton_tarifa Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPASAJEROS_TON_TARIFA"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV11cPASAJEROS_TON_TARIFA )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cpasajeros_tarifa Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCPASAJEROS_TARIFA"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV12cPASAJEROS_TARIFA )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E211P2 */
                                          E211P2 ();
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

      protected void WE1P2( )
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

      protected void PA1P2( )
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
            cmbavCpasajeros_esclusa.Name = "vCPASAJEROS_ESCLUSA";
            cmbavCpasajeros_esclusa.WebTags = "";
            cmbavCpasajeros_esclusa.addItem("Panamax", context.GetMessage( "Panamax", ""), 0);
            cmbavCpasajeros_esclusa.addItem("NeoPanamax", context.GetMessage( "NeoPanamax", ""), 0);
            if ( cmbavCpasajeros_esclusa.ItemCount > 0 )
            {
               AV7cPASAJEROS_ESCLUSA = cmbavCpasajeros_esclusa.getValidValue(AV7cPASAJEROS_ESCLUSA);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cPASAJEROS_ESCLUSA", AV7cPASAJEROS_ESCLUSA);
            }
            cmbavCpasajeros_tipo_tarifa.Name = "vCPASAJEROS_TIPO_TARIFA";
            cmbavCpasajeros_tipo_tarifa.WebTags = "";
            cmbavCpasajeros_tipo_tarifa.addItem("LITERA", context.GetMessage( "Litera", ""), 0);
            cmbavCpasajeros_tipo_tarifa.addItem("CPSUAB", context.GetMessage( "CP/ SUAB", ""), 0);
            if ( cmbavCpasajeros_tipo_tarifa.ItemCount > 0 )
            {
               AV8cPASAJEROS_TIPO_TARIFA = cmbavCpasajeros_tipo_tarifa.getValidValue(AV8cPASAJEROS_TIPO_TARIFA);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cPASAJEROS_TIPO_TARIFA", AV8cPASAJEROS_TIPO_TARIFA);
            }
            cmbavCpasajeros_carga.Name = "vCPASAJEROS_CARGA";
            cmbavCpasajeros_carga.WebTags = "";
            cmbavCpasajeros_carga.addItem("Laden", context.GetMessage( "Laden", ""), 0);
            cmbavCpasajeros_carga.addItem("Ballast", context.GetMessage( "Ballast", ""), 0);
            if ( cmbavCpasajeros_carga.ItemCount > 0 )
            {
               AV9cPASAJEROS_CARGA = cmbavCpasajeros_carga.getValidValue(AV9cPASAJEROS_CARGA);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cPASAJEROS_CARGA", AV9cPASAJEROS_CARGA);
            }
            GXCCtl = "PASAJEROS_ESCLUSA_" + sGXsfl_84_idx;
            cmbPASAJEROS_ESCLUSA.Name = GXCCtl;
            cmbPASAJEROS_ESCLUSA.WebTags = "";
            cmbPASAJEROS_ESCLUSA.addItem("Panamax", context.GetMessage( "Panamax", ""), 0);
            cmbPASAJEROS_ESCLUSA.addItem("NeoPanamax", context.GetMessage( "NeoPanamax", ""), 0);
            if ( cmbPASAJEROS_ESCLUSA.ItemCount > 0 )
            {
               A58PASAJEROS_ESCLUSA = cmbPASAJEROS_ESCLUSA.getValidValue(A58PASAJEROS_ESCLUSA);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbPASAJEROS_ESCLUSA_Internalname, A58PASAJEROS_ESCLUSA);
            }
            GXCCtl = "PASAJEROS_TIPO_TARIFA_" + sGXsfl_84_idx;
            cmbPASAJEROS_TIPO_TARIFA.Name = GXCCtl;
            cmbPASAJEROS_TIPO_TARIFA.WebTags = "";
            cmbPASAJEROS_TIPO_TARIFA.addItem("LITERA", context.GetMessage( "Litera", ""), 0);
            cmbPASAJEROS_TIPO_TARIFA.addItem("CPSUAB", context.GetMessage( "CP/ SUAB", ""), 0);
            if ( cmbPASAJEROS_TIPO_TARIFA.ItemCount > 0 )
            {
               A60PASAJEROS_TIPO_TARIFA = cmbPASAJEROS_TIPO_TARIFA.getValidValue(A60PASAJEROS_TIPO_TARIFA);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbPASAJEROS_TIPO_TARIFA_Internalname, A60PASAJEROS_TIPO_TARIFA);
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

      protected void gxnrGrid1_newrow( short nRC_GXsfl_84 ,
                                       short nGXsfl_84_idx ,
                                       String sGXsfl_84_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtPASAJEROS_ID_Internalname = "PASAJEROS_ID_"+sGXsfl_84_idx;
         cmbPASAJEROS_ESCLUSA_Internalname = "PASAJEROS_ESCLUSA_"+sGXsfl_84_idx;
         cmbPASAJEROS_TIPO_TARIFA_Internalname = "PASAJEROS_TIPO_TARIFA_"+sGXsfl_84_idx;
         while ( nGXsfl_84_idx <= nRC_GXsfl_84 )
         {
            sendrow_842( ) ;
            nGXsfl_84_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1));
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
            edtPASAJEROS_ID_Internalname = "PASAJEROS_ID_"+sGXsfl_84_idx;
            cmbPASAJEROS_ESCLUSA_Internalname = "PASAJEROS_ESCLUSA_"+sGXsfl_84_idx;
            cmbPASAJEROS_TIPO_TARIFA_Internalname = "PASAJEROS_TIPO_TARIFA_"+sGXsfl_84_idx;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        short AV6cPASAJEROS_ID ,
                                        String AV7cPASAJEROS_ESCLUSA ,
                                        String AV8cPASAJEROS_TIPO_TARIFA ,
                                        String AV9cPASAJEROS_CARGA ,
                                        short AV10cPASAJEROS_ID_TON_TARIF ,
                                        long AV11cPASAJEROS_TON_TARIFA ,
                                        decimal AV12cPASAJEROS_TARIFA )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         cmbavCpasajeros_esclusa.Name = "vCPASAJEROS_ESCLUSA";
         cmbavCpasajeros_esclusa.WebTags = "";
         cmbavCpasajeros_esclusa.addItem("Panamax", context.GetMessage( "Panamax", ""), 0);
         cmbavCpasajeros_esclusa.addItem("NeoPanamax", context.GetMessage( "NeoPanamax", ""), 0);
         if ( cmbavCpasajeros_esclusa.ItemCount > 0 )
         {
            AV7cPASAJEROS_ESCLUSA = cmbavCpasajeros_esclusa.getValidValue(AV7cPASAJEROS_ESCLUSA);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cPASAJEROS_ESCLUSA", AV7cPASAJEROS_ESCLUSA);
         }
         cmbavCpasajeros_tipo_tarifa.Name = "vCPASAJEROS_TIPO_TARIFA";
         cmbavCpasajeros_tipo_tarifa.WebTags = "";
         cmbavCpasajeros_tipo_tarifa.addItem("LITERA", context.GetMessage( "Litera", ""), 0);
         cmbavCpasajeros_tipo_tarifa.addItem("CPSUAB", context.GetMessage( "CP/ SUAB", ""), 0);
         if ( cmbavCpasajeros_tipo_tarifa.ItemCount > 0 )
         {
            AV8cPASAJEROS_TIPO_TARIFA = cmbavCpasajeros_tipo_tarifa.getValidValue(AV8cPASAJEROS_TIPO_TARIFA);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cPASAJEROS_TIPO_TARIFA", AV8cPASAJEROS_TIPO_TARIFA);
         }
         cmbavCpasajeros_carga.Name = "vCPASAJEROS_CARGA";
         cmbavCpasajeros_carga.WebTags = "";
         cmbavCpasajeros_carga.addItem("Laden", context.GetMessage( "Laden", ""), 0);
         cmbavCpasajeros_carga.addItem("Ballast", context.GetMessage( "Ballast", ""), 0);
         if ( cmbavCpasajeros_carga.ItemCount > 0 )
         {
            AV9cPASAJEROS_CARGA = cmbavCpasajeros_carga.getValidValue(AV9cPASAJEROS_CARGA);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cPASAJEROS_CARGA", AV9cPASAJEROS_CARGA);
         }
         GXCCtl = "PASAJEROS_ESCLUSA_" + sGXsfl_84_idx;
         cmbPASAJEROS_ESCLUSA.Name = GXCCtl;
         cmbPASAJEROS_ESCLUSA.WebTags = "";
         cmbPASAJEROS_ESCLUSA.addItem("Panamax", context.GetMessage( "Panamax", ""), 0);
         cmbPASAJEROS_ESCLUSA.addItem("NeoPanamax", context.GetMessage( "NeoPanamax", ""), 0);
         if ( cmbPASAJEROS_ESCLUSA.ItemCount > 0 )
         {
            A58PASAJEROS_ESCLUSA = cmbPASAJEROS_ESCLUSA.getValidValue(A58PASAJEROS_ESCLUSA);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbPASAJEROS_ESCLUSA_Internalname, A58PASAJEROS_ESCLUSA);
         }
         GXCCtl = "PASAJEROS_TIPO_TARIFA_" + sGXsfl_84_idx;
         cmbPASAJEROS_TIPO_TARIFA.Name = GXCCtl;
         cmbPASAJEROS_TIPO_TARIFA.WebTags = "";
         cmbPASAJEROS_TIPO_TARIFA.addItem("LITERA", context.GetMessage( "Litera", ""), 0);
         cmbPASAJEROS_TIPO_TARIFA.addItem("CPSUAB", context.GetMessage( "CP/ SUAB", ""), 0);
         if ( cmbPASAJEROS_TIPO_TARIFA.ItemCount > 0 )
         {
            A60PASAJEROS_TIPO_TARIFA = cmbPASAJEROS_TIPO_TARIFA.getValidValue(A60PASAJEROS_TIPO_TARIFA);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbPASAJEROS_TIPO_TARIFA_Internalname, A60PASAJEROS_TIPO_TARIFA);
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         RF1P2( ) ;
         context.GX_msglist = BackMsgLst;
         /* End function gxgrGrid1_refresh */
      }

      public void Refresh( )
      {
         RF1P2( ) ;
      }

      protected void RF1P2( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         Grid1Container.AddObjectProperty("GridName", "Grid1");
         Grid1Container.AddObjectProperty("CmpContext", "");
         Grid1Container.AddObjectProperty("InMasterPage", "false");
         wbStart = 84;
         nGXsfl_84_idx = 1;
         sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtPASAJEROS_ID_Internalname = "PASAJEROS_ID_"+sGXsfl_84_idx;
         cmbPASAJEROS_ESCLUSA_Internalname = "PASAJEROS_ESCLUSA_"+sGXsfl_84_idx;
         cmbPASAJEROS_TIPO_TARIFA_Internalname = "PASAJEROS_TIPO_TARIFA_"+sGXsfl_84_idx;
         nGXsfl_84_Refreshing = 1;
         Grid1Container.PageSize = subGrid1_Recordsperpage( );
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
            edtPASAJEROS_ID_Internalname = "PASAJEROS_ID_"+sGXsfl_84_idx;
            cmbPASAJEROS_ESCLUSA_Internalname = "PASAJEROS_ESCLUSA_"+sGXsfl_84_idx;
            cmbPASAJEROS_TIPO_TARIFA_Internalname = "PASAJEROS_TIPO_TARIFA_"+sGXsfl_84_idx;
            GXPagingFrom2 = (int)(((10==0) ? 1 : GRID1_nFirstRecordOnPage+1));
            GXPagingTo2 = ((10==0) ? 10000 : GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7cPASAJEROS_ESCLUSA ,
                                                 AV8cPASAJEROS_TIPO_TARIFA ,
                                                 AV9cPASAJEROS_CARGA ,
                                                 AV10cPASAJEROS_ID_TON_TARIF ,
                                                 AV11cPASAJEROS_TON_TARIFA ,
                                                 AV12cPASAJEROS_TARIFA ,
                                                 A58PASAJEROS_ESCLUSA ,
                                                 A60PASAJEROS_TIPO_TARIFA ,
                                                 A59PASAJEROS_CARGA ,
                                                 A65PASAJEROS_ID_TON_TARIF ,
                                                 A61PASAJEROS_TON_TARIFA ,
                                                 A62PASAJEROS_TARIFA ,
                                                 AV6cPASAJEROS_ID },
                                                 new int[] {
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.LONG, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT,
                                                 TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.SHORT
                                                 }
            });
            lV7cPASAJEROS_ESCLUSA = StringUtil.PadR( StringUtil.RTrim( AV7cPASAJEROS_ESCLUSA), 40, "%");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cPASAJEROS_ESCLUSA", AV7cPASAJEROS_ESCLUSA);
            lV8cPASAJEROS_TIPO_TARIFA = StringUtil.PadR( StringUtil.RTrim( AV8cPASAJEROS_TIPO_TARIFA), 10, "%");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cPASAJEROS_TIPO_TARIFA", AV8cPASAJEROS_TIPO_TARIFA);
            lV9cPASAJEROS_CARGA = StringUtil.PadR( StringUtil.RTrim( AV9cPASAJEROS_CARGA), 40, "%");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cPASAJEROS_CARGA", AV9cPASAJEROS_CARGA);
            /* Using cursor H001P2 */
            pr_default.execute(0, new Object[] {AV6cPASAJEROS_ID, lV7cPASAJEROS_ESCLUSA, lV8cPASAJEROS_TIPO_TARIFA, lV9cPASAJEROS_CARGA, AV10cPASAJEROS_ID_TON_TARIF, AV11cPASAJEROS_TON_TARIFA, AV12cPASAJEROS_TARIFA, GXPagingFrom2, GXPagingTo2, GXPagingTo2, GXPagingFrom2, GXPagingFrom2});
            nGXsfl_84_idx = 1;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A62PASAJEROS_TARIFA = H001P2_A62PASAJEROS_TARIFA[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A62PASAJEROS_TARIFA", StringUtil.LTrim( StringUtil.Str( A62PASAJEROS_TARIFA, 10, 2)));
               A61PASAJEROS_TON_TARIFA = H001P2_A61PASAJEROS_TON_TARIFA[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61PASAJEROS_TON_TARIFA", StringUtil.LTrim( StringUtil.Str( (decimal)(A61PASAJEROS_TON_TARIFA), 10, 0)));
               n61PASAJEROS_TON_TARIFA = H001P2_n61PASAJEROS_TON_TARIFA[0];
               A65PASAJEROS_ID_TON_TARIF = H001P2_A65PASAJEROS_ID_TON_TARIF[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65PASAJEROS_ID_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(A65PASAJEROS_ID_TON_TARIF), 4, 0)));
               A59PASAJEROS_CARGA = H001P2_A59PASAJEROS_CARGA[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59PASAJEROS_CARGA", A59PASAJEROS_CARGA);
               A60PASAJEROS_TIPO_TARIFA = H001P2_A60PASAJEROS_TIPO_TARIFA[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbPASAJEROS_TIPO_TARIFA_Internalname, A60PASAJEROS_TIPO_TARIFA);
               A58PASAJEROS_ESCLUSA = H001P2_A58PASAJEROS_ESCLUSA[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbPASAJEROS_ESCLUSA_Internalname, A58PASAJEROS_ESCLUSA);
               A63PASAJEROS_ID = H001P2_A63PASAJEROS_ID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtPASAJEROS_ID_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A63PASAJEROS_ID), 4, 0)));
               /* Execute user event: E201P2 */
               E201P2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 84;
            WB1P0( ) ;
         }
         nGXsfl_84_Refreshing = 0;
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
                                              AV7cPASAJEROS_ESCLUSA ,
                                              AV8cPASAJEROS_TIPO_TARIFA ,
                                              AV9cPASAJEROS_CARGA ,
                                              AV10cPASAJEROS_ID_TON_TARIF ,
                                              AV11cPASAJEROS_TON_TARIFA ,
                                              AV12cPASAJEROS_TARIFA ,
                                              A58PASAJEROS_ESCLUSA ,
                                              A60PASAJEROS_TIPO_TARIFA ,
                                              A59PASAJEROS_CARGA ,
                                              A65PASAJEROS_ID_TON_TARIF ,
                                              A61PASAJEROS_TON_TARIFA ,
                                              A62PASAJEROS_TARIFA ,
                                              AV6cPASAJEROS_ID },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.LONG, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT,
                                              TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.SHORT
                                              }
         });
         lV7cPASAJEROS_ESCLUSA = StringUtil.PadR( StringUtil.RTrim( AV7cPASAJEROS_ESCLUSA), 40, "%");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cPASAJEROS_ESCLUSA", AV7cPASAJEROS_ESCLUSA);
         lV8cPASAJEROS_TIPO_TARIFA = StringUtil.PadR( StringUtil.RTrim( AV8cPASAJEROS_TIPO_TARIFA), 10, "%");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cPASAJEROS_TIPO_TARIFA", AV8cPASAJEROS_TIPO_TARIFA);
         lV9cPASAJEROS_CARGA = StringUtil.PadR( StringUtil.RTrim( AV9cPASAJEROS_CARGA), 40, "%");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cPASAJEROS_CARGA", AV9cPASAJEROS_CARGA);
         /* Using cursor H001P3 */
         pr_default.execute(1, new Object[] {AV6cPASAJEROS_ID, lV7cPASAJEROS_ESCLUSA, lV8cPASAJEROS_TIPO_TARIFA, lV9cPASAJEROS_CARGA, AV10cPASAJEROS_ID_TON_TARIF, AV11cPASAJEROS_TON_TARIFA, AV12cPASAJEROS_TARIFA});
         GRID1_nRecordCount = H001P3_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cPASAJEROS_ID, AV7cPASAJEROS_ESCLUSA, AV8cPASAJEROS_TIPO_TARIFA, AV9cPASAJEROS_CARGA, AV10cPASAJEROS_ID_TON_TARIF, AV11cPASAJEROS_TON_TARIFA, AV12cPASAJEROS_TARIFA) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cPASAJEROS_ID, AV7cPASAJEROS_ESCLUSA, AV8cPASAJEROS_TIPO_TARIFA, AV9cPASAJEROS_CARGA, AV10cPASAJEROS_ID_TON_TARIF, AV11cPASAJEROS_TON_TARIFA, AV12cPASAJEROS_TARIFA) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cPASAJEROS_ID, AV7cPASAJEROS_ESCLUSA, AV8cPASAJEROS_TIPO_TARIFA, AV9cPASAJEROS_CARGA, AV10cPASAJEROS_ID_TON_TARIF, AV11cPASAJEROS_TON_TARIFA, AV12cPASAJEROS_TARIFA) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cPASAJEROS_ID, AV7cPASAJEROS_ESCLUSA, AV8cPASAJEROS_TIPO_TARIFA, AV9cPASAJEROS_CARGA, AV10cPASAJEROS_ID_TON_TARIF, AV11cPASAJEROS_TON_TARIFA, AV12cPASAJEROS_TARIFA) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cPASAJEROS_ID, AV7cPASAJEROS_ESCLUSA, AV8cPASAJEROS_TIPO_TARIFA, AV9cPASAJEROS_CARGA, AV10cPASAJEROS_ID_TON_TARIF, AV11cPASAJEROS_TON_TARIFA, AV12cPASAJEROS_TARIFA) ;
         }
         return (int)(0) ;
      }

      protected void STRUP1P0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E191P2 */
         E191P2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCpasajeros_id_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCpasajeros_id_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPASAJEROS_ID");
               GX_FocusControl = edtavCpasajeros_id_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cPASAJEROS_ID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cPASAJEROS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cPASAJEROS_ID), 4, 0)));
            }
            else
            {
               AV6cPASAJEROS_ID = (short)(context.localUtil.CToN( cgiGet( edtavCpasajeros_id_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cPASAJEROS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cPASAJEROS_ID), 4, 0)));
            }
            cmbavCpasajeros_esclusa.Name = cmbavCpasajeros_esclusa_Internalname;
            cmbavCpasajeros_esclusa.CurrentValue = cgiGet( cmbavCpasajeros_esclusa_Internalname);
            AV7cPASAJEROS_ESCLUSA = cgiGet( cmbavCpasajeros_esclusa_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cPASAJEROS_ESCLUSA", AV7cPASAJEROS_ESCLUSA);
            if ( cmbavCpasajeros_esclusa.ItemCount > 0 )
            {
               AV7cPASAJEROS_ESCLUSA = cmbavCpasajeros_esclusa.getValidValue(AV7cPASAJEROS_ESCLUSA);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cPASAJEROS_ESCLUSA", AV7cPASAJEROS_ESCLUSA);
            }
            cmbavCpasajeros_tipo_tarifa.Name = cmbavCpasajeros_tipo_tarifa_Internalname;
            cmbavCpasajeros_tipo_tarifa.CurrentValue = cgiGet( cmbavCpasajeros_tipo_tarifa_Internalname);
            AV8cPASAJEROS_TIPO_TARIFA = cgiGet( cmbavCpasajeros_tipo_tarifa_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cPASAJEROS_TIPO_TARIFA", AV8cPASAJEROS_TIPO_TARIFA);
            if ( cmbavCpasajeros_tipo_tarifa.ItemCount > 0 )
            {
               AV8cPASAJEROS_TIPO_TARIFA = cmbavCpasajeros_tipo_tarifa.getValidValue(AV8cPASAJEROS_TIPO_TARIFA);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cPASAJEROS_TIPO_TARIFA", AV8cPASAJEROS_TIPO_TARIFA);
            }
            cmbavCpasajeros_carga.Name = cmbavCpasajeros_carga_Internalname;
            cmbavCpasajeros_carga.CurrentValue = cgiGet( cmbavCpasajeros_carga_Internalname);
            AV9cPASAJEROS_CARGA = cgiGet( cmbavCpasajeros_carga_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cPASAJEROS_CARGA", AV9cPASAJEROS_CARGA);
            if ( cmbavCpasajeros_carga.ItemCount > 0 )
            {
               AV9cPASAJEROS_CARGA = cmbavCpasajeros_carga.getValidValue(AV9cPASAJEROS_CARGA);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cPASAJEROS_CARGA", AV9cPASAJEROS_CARGA);
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCpasajeros_id_ton_tarif_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCpasajeros_id_ton_tarif_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPASAJEROS_ID_TON_TARIF");
               GX_FocusControl = edtavCpasajeros_id_ton_tarif_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10cPASAJEROS_ID_TON_TARIF = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cPASAJEROS_ID_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cPASAJEROS_ID_TON_TARIF), 4, 0)));
            }
            else
            {
               AV10cPASAJEROS_ID_TON_TARIF = (short)(context.localUtil.CToN( cgiGet( edtavCpasajeros_id_ton_tarif_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cPASAJEROS_ID_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cPASAJEROS_ID_TON_TARIF), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCpasajeros_ton_tarifa_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCpasajeros_ton_tarifa_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPASAJEROS_TON_TARIFA");
               GX_FocusControl = edtavCpasajeros_ton_tarifa_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11cPASAJEROS_TON_TARIFA = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cPASAJEROS_TON_TARIFA", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cPASAJEROS_TON_TARIFA), 10, 0)));
            }
            else
            {
               AV11cPASAJEROS_TON_TARIFA = (long)(context.localUtil.CToN( cgiGet( edtavCpasajeros_ton_tarifa_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cPASAJEROS_TON_TARIFA", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cPASAJEROS_TON_TARIFA), 10, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCpasajeros_tarifa_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCpasajeros_tarifa_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 9999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPASAJEROS_TARIFA");
               GX_FocusControl = edtavCpasajeros_tarifa_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV12cPASAJEROS_TARIFA = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cPASAJEROS_TARIFA", StringUtil.LTrim( StringUtil.Str( AV12cPASAJEROS_TARIFA, 10, 2)));
            }
            else
            {
               AV12cPASAJEROS_TARIFA = context.localUtil.CToN( cgiGet( edtavCpasajeros_tarifa_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cPASAJEROS_TARIFA", StringUtil.LTrim( StringUtil.Str( AV12cPASAJEROS_TARIFA, 10, 2)));
            }
            /* Read saved values. */
            nRC_GXsfl_84 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_84"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            AV13pPASAJEROS_ID = (short)(context.localUtil.CToN( cgiGet( "vPPASAJEROS_ID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPASAJEROS_ID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV6cPASAJEROS_ID )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCPASAJEROS_ESCLUSA"), AV7cPASAJEROS_ESCLUSA) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCPASAJEROS_TIPO_TARIFA"), AV8cPASAJEROS_TIPO_TARIFA) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCPASAJEROS_CARGA"), AV9cPASAJEROS_CARGA) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPASAJEROS_ID_TON_TARIF"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV10cPASAJEROS_ID_TON_TARIF )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPASAJEROS_TON_TARIFA"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV11cPASAJEROS_TON_TARIFA )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vCPASAJEROS_TARIFA"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV12cPASAJEROS_TARIFA )
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
         /* Execute user event: E191P2 */
         E191P2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E191P2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( context.GetMessage( "GXSPC_SelectionList", ""), context.GetMessage( "Transaccion para el segmento de buques de pasajeros", ""), "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
         AV14ADVANCED_LABEL_TEMPLATE = context.GetMessage( "%1 <strong>%2</strong>", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ADVANCED_LABEL_TEMPLATE", AV14ADVANCED_LABEL_TEMPLATE);
      }

      private void E201P2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV17Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))));
         AV17Linkselection_GXI = GeneXus.Utils.GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV17Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))));
         sendrow_842( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ( nGXsfl_84_Refreshing == 0 ) )
         {
            context.DoAjaxLoad(84, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: E211P2 */
         E211P2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E211P2( )
      {
         /* Enter Routine */
         AV13pPASAJEROS_ID = A63PASAJEROS_ID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pPASAJEROS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pPASAJEROS_ID), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV13pPASAJEROS_ID});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pPASAJEROS_ID = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pPASAJEROS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pPASAJEROS_ID), 4, 0)));
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
         PA1P2( ) ;
         WS1P2( ) ;
         WE1P2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201512010414232");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages."+context.GetLanguageProperty( "code")+".js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("gx00b0.js", "?201512010414232");
         /* End function include_jscripts */
      }

      protected void sendrow_842( )
      {
         sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtPASAJEROS_ID_Internalname = "PASAJEROS_ID_"+sGXsfl_84_idx;
         cmbPASAJEROS_ESCLUSA_Internalname = "PASAJEROS_ESCLUSA_"+sGXsfl_84_idx;
         cmbPASAJEROS_TIPO_TARIFA_Internalname = "PASAJEROS_TIPO_TARIFA_"+sGXsfl_84_idx;
         WB1P0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_84_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)((nGXsfl_84_idx) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_84_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A63PASAJEROS_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV17Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV17Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection)),(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"''",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPASAJEROS_ID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A63PASAJEROS_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( (decimal)(A63PASAJEROS_ID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPASAJEROS_ID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)84,(short)1,(short)1,(short)0,(bool)true,(String)"",(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            if ( ( nGXsfl_84_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "PASAJEROS_ESCLUSA_" + sGXsfl_84_idx;
               cmbPASAJEROS_ESCLUSA.Name = GXCCtl;
               cmbPASAJEROS_ESCLUSA.WebTags = "";
               cmbPASAJEROS_ESCLUSA.addItem("Panamax", context.GetMessage( "Panamax", ""), 0);
               cmbPASAJEROS_ESCLUSA.addItem("NeoPanamax", context.GetMessage( "NeoPanamax", ""), 0);
               if ( cmbPASAJEROS_ESCLUSA.ItemCount > 0 )
               {
                  A58PASAJEROS_ESCLUSA = cmbPASAJEROS_ESCLUSA.getValidValue(A58PASAJEROS_ESCLUSA);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbPASAJEROS_ESCLUSA_Internalname, A58PASAJEROS_ESCLUSA);
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbPASAJEROS_ESCLUSA,(String)cmbPASAJEROS_ESCLUSA_Internalname,(String)A58PASAJEROS_ESCLUSA,(short)1,(String)cmbPASAJEROS_ESCLUSA_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"DescriptionAttribute",(String)"WWColumn",(String)"",(String)"",(bool)true});
            cmbPASAJEROS_ESCLUSA.CurrentValue = A58PASAJEROS_ESCLUSA;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPASAJEROS_ESCLUSA_Internalname, "Values", (String)(cmbPASAJEROS_ESCLUSA.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            if ( ( nGXsfl_84_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "PASAJEROS_TIPO_TARIFA_" + sGXsfl_84_idx;
               cmbPASAJEROS_TIPO_TARIFA.Name = GXCCtl;
               cmbPASAJEROS_TIPO_TARIFA.WebTags = "";
               cmbPASAJEROS_TIPO_TARIFA.addItem("LITERA", context.GetMessage( "Litera", ""), 0);
               cmbPASAJEROS_TIPO_TARIFA.addItem("CPSUAB", context.GetMessage( "CP/ SUAB", ""), 0);
               if ( cmbPASAJEROS_TIPO_TARIFA.ItemCount > 0 )
               {
                  A60PASAJEROS_TIPO_TARIFA = cmbPASAJEROS_TIPO_TARIFA.getValidValue(A60PASAJEROS_TIPO_TARIFA);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbPASAJEROS_TIPO_TARIFA_Internalname, A60PASAJEROS_TIPO_TARIFA);
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbPASAJEROS_TIPO_TARIFA,(String)cmbPASAJEROS_TIPO_TARIFA_Internalname,(String)A60PASAJEROS_TIPO_TARIFA,(short)1,(String)cmbPASAJEROS_TIPO_TARIFA_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn OptionalColumn",(String)"",(String)"",(bool)true});
            cmbPASAJEROS_TIPO_TARIFA.CurrentValue = A60PASAJEROS_TIPO_TARIFA;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPASAJEROS_TIPO_TARIFA_Internalname, "Values", (String)(cmbPASAJEROS_TIPO_TARIFA.ToJavascriptSource()));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_84_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1));
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_84_idx), 4, 0)), 4, "0");
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
            edtPASAJEROS_ID_Internalname = "PASAJEROS_ID_"+sGXsfl_84_idx;
            cmbPASAJEROS_ESCLUSA_Internalname = "PASAJEROS_ESCLUSA_"+sGXsfl_84_idx;
            cmbPASAJEROS_TIPO_TARIFA_Internalname = "PASAJEROS_TIPO_TARIFA_"+sGXsfl_84_idx;
         }
         /* End function sendrow_842 */
      }

      protected void init_default_properties( )
      {
         lblLblpasajeros_idfilter_Internalname = "LBLPASAJEROS_IDFILTER";
         lblLblpasajeros_idfilter_Internalname = "LBLPASAJEROS_IDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCpasajeros_id_Internalname = "vCPASAJEROS_ID";
         edtavCpasajeros_id_Internalname = "vCPASAJEROS_ID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divPasajeros_idfiltercontainer_Internalname = "PASAJEROS_IDFILTERCONTAINER";
         divPasajeros_idfiltercontainer_Internalname = "PASAJEROS_IDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLblpasajeros_esclusafilter_Internalname = "LBLPASAJEROS_ESCLUSAFILTER";
         lblLblpasajeros_esclusafilter_Internalname = "LBLPASAJEROS_ESCLUSAFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         cmbavCpasajeros_esclusa_Internalname = "vCPASAJEROS_ESCLUSA";
         cmbavCpasajeros_esclusa_Internalname = "vCPASAJEROS_ESCLUSA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divPasajeros_esclusafiltercontainer_Internalname = "PASAJEROS_ESCLUSAFILTERCONTAINER";
         divPasajeros_esclusafiltercontainer_Internalname = "PASAJEROS_ESCLUSAFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLblpasajeros_tipo_tarifafilter_Internalname = "LBLPASAJEROS_TIPO_TARIFAFILTER";
         lblLblpasajeros_tipo_tarifafilter_Internalname = "LBLPASAJEROS_TIPO_TARIFAFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         cmbavCpasajeros_tipo_tarifa_Internalname = "vCPASAJEROS_TIPO_TARIFA";
         cmbavCpasajeros_tipo_tarifa_Internalname = "vCPASAJEROS_TIPO_TARIFA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divPasajeros_tipo_tarifafiltercontainer_Internalname = "PASAJEROS_TIPO_TARIFAFILTERCONTAINER";
         divPasajeros_tipo_tarifafiltercontainer_Internalname = "PASAJEROS_TIPO_TARIFAFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLblpasajeros_cargafilter_Internalname = "LBLPASAJEROS_CARGAFILTER";
         lblLblpasajeros_cargafilter_Internalname = "LBLPASAJEROS_CARGAFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         cmbavCpasajeros_carga_Internalname = "vCPASAJEROS_CARGA";
         cmbavCpasajeros_carga_Internalname = "vCPASAJEROS_CARGA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divPasajeros_cargafiltercontainer_Internalname = "PASAJEROS_CARGAFILTERCONTAINER";
         divPasajeros_cargafiltercontainer_Internalname = "PASAJEROS_CARGAFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLblpasajeros_id_ton_tariffilter_Internalname = "LBLPASAJEROS_ID_TON_TARIFFILTER";
         lblLblpasajeros_id_ton_tariffilter_Internalname = "LBLPASAJEROS_ID_TON_TARIFFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCpasajeros_id_ton_tarif_Internalname = "vCPASAJEROS_ID_TON_TARIF";
         edtavCpasajeros_id_ton_tarif_Internalname = "vCPASAJEROS_ID_TON_TARIF";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divPasajeros_id_ton_tariffiltercontainer_Internalname = "PASAJEROS_ID_TON_TARIFFILTERCONTAINER";
         divPasajeros_id_ton_tariffiltercontainer_Internalname = "PASAJEROS_ID_TON_TARIFFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLblpasajeros_ton_tarifafilter_Internalname = "LBLPASAJEROS_TON_TARIFAFILTER";
         lblLblpasajeros_ton_tarifafilter_Internalname = "LBLPASAJEROS_TON_TARIFAFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCpasajeros_ton_tarifa_Internalname = "vCPASAJEROS_TON_TARIFA";
         edtavCpasajeros_ton_tarifa_Internalname = "vCPASAJEROS_TON_TARIFA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divPasajeros_ton_tarifafiltercontainer_Internalname = "PASAJEROS_TON_TARIFAFILTERCONTAINER";
         divPasajeros_ton_tarifafiltercontainer_Internalname = "PASAJEROS_TON_TARIFAFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLblpasajeros_tarifafilter_Internalname = "LBLPASAJEROS_TARIFAFILTER";
         lblLblpasajeros_tarifafilter_Internalname = "LBLPASAJEROS_TARIFAFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCpasajeros_tarifa_Internalname = "vCPASAJEROS_TARIFA";
         edtavCpasajeros_tarifa_Internalname = "vCPASAJEROS_TARIFA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divPasajeros_tarifafiltercontainer_Internalname = "PASAJEROS_TARIFAFILTERCONTAINER";
         divPasajeros_tarifafiltercontainer_Internalname = "PASAJEROS_TARIFAFILTERCONTAINER";
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
         edtPASAJEROS_ID_Internalname = "PASAJEROS_ID";
         cmbPASAJEROS_ESCLUSA_Internalname = "PASAJEROS_ESCLUSA";
         cmbPASAJEROS_TIPO_TARIFA_Internalname = "PASAJEROS_TIPO_TARIFA";
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
         cmbPASAJEROS_TIPO_TARIFA_Jsonclick = "";
         cmbPASAJEROS_ESCLUSA_Jsonclick = "";
         edtPASAJEROS_ID_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCpasajeros_tarifa_Jsonclick = "";
         edtavCpasajeros_tarifa_Enabled = 1;
         edtavCpasajeros_tarifa_Visible = 1;
         edtavCpasajeros_ton_tarifa_Jsonclick = "";
         edtavCpasajeros_ton_tarifa_Enabled = 1;
         edtavCpasajeros_ton_tarifa_Visible = 1;
         edtavCpasajeros_id_ton_tarif_Jsonclick = "";
         edtavCpasajeros_id_ton_tarif_Enabled = 1;
         edtavCpasajeros_id_ton_tarif_Visible = 1;
         cmbavCpasajeros_carga_Jsonclick = "";
         cmbavCpasajeros_carga.Enabled = 1;
         cmbavCpasajeros_carga.Visible = 1;
         cmbavCpasajeros_tipo_tarifa_Jsonclick = "";
         cmbavCpasajeros_tipo_tarifa.Enabled = 1;
         cmbavCpasajeros_tipo_tarifa.Visible = 1;
         cmbavCpasajeros_esclusa_Jsonclick = "";
         cmbavCpasajeros_esclusa.Enabled = 1;
         cmbavCpasajeros_esclusa.Visible = 1;
         edtavCpasajeros_id_Jsonclick = "";
         edtavCpasajeros_id_Enabled = 1;
         edtavCpasajeros_id_Visible = 1;
         divPasajeros_tarifafiltercontainer_Class = "AdvancedContainerItem";
         divPasajeros_ton_tarifafiltercontainer_Class = "AdvancedContainerItem";
         divPasajeros_id_ton_tariffiltercontainer_Class = "AdvancedContainerItem";
         divPasajeros_cargafiltercontainer_Class = "AdvancedContainerItem";
         divPasajeros_tipo_tarifafiltercontainer_Class = "AdvancedContainerItem";
         divPasajeros_esclusafiltercontainer_Class = "AdvancedContainerItem";
         divPasajeros_idfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainer";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = context.GetMessage( "Selection List Transaccion para el segmento de buques de pasajeros", "");
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cPASAJEROS_ID',fld:'vCPASAJEROS_ID'},{av:'AV7cPASAJEROS_ESCLUSA',fld:'vCPASAJEROS_ESCLUSA'},{av:'AV8cPASAJEROS_TIPO_TARIFA',fld:'vCPASAJEROS_TIPO_TARIFA'},{av:'AV9cPASAJEROS_CARGA',fld:'vCPASAJEROS_CARGA'},{av:'AV10cPASAJEROS_ID_TON_TARIF',fld:'vCPASAJEROS_ID_TON_TARIF'},{av:'AV11cPASAJEROS_TON_TARIFA',fld:'vCPASAJEROS_TON_TARIFA'},{av:'AV12cPASAJEROS_TARIFA',fld:'vCPASAJEROS_TARIFA'}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E181P1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLPASAJEROS_IDFILTER.CLICK","{handler:'E111P1',iparms:[{av:'divPasajeros_idfiltercontainer_Class',ctrl:'PASAJEROS_IDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divPasajeros_idfiltercontainer_Class',ctrl:'PASAJEROS_IDFILTERCONTAINER',prop:'Class'},{av:'edtavCpasajeros_id_Visible',ctrl:'vCPASAJEROS_ID',prop:'Visible'}]}");
         setEventMetadata("LBLPASAJEROS_ESCLUSAFILTER.CLICK","{handler:'E121P1',iparms:[{av:'divPasajeros_esclusafiltercontainer_Class',ctrl:'PASAJEROS_ESCLUSAFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divPasajeros_esclusafiltercontainer_Class',ctrl:'PASAJEROS_ESCLUSAFILTERCONTAINER',prop:'Class'},{av:'cmbavCpasajeros_esclusa'}]}");
         setEventMetadata("LBLPASAJEROS_TIPO_TARIFAFILTER.CLICK","{handler:'E131P1',iparms:[{av:'divPasajeros_tipo_tarifafiltercontainer_Class',ctrl:'PASAJEROS_TIPO_TARIFAFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divPasajeros_tipo_tarifafiltercontainer_Class',ctrl:'PASAJEROS_TIPO_TARIFAFILTERCONTAINER',prop:'Class'},{av:'cmbavCpasajeros_tipo_tarifa'}]}");
         setEventMetadata("LBLPASAJEROS_CARGAFILTER.CLICK","{handler:'E141P1',iparms:[{av:'divPasajeros_cargafiltercontainer_Class',ctrl:'PASAJEROS_CARGAFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divPasajeros_cargafiltercontainer_Class',ctrl:'PASAJEROS_CARGAFILTERCONTAINER',prop:'Class'},{av:'cmbavCpasajeros_carga'}]}");
         setEventMetadata("LBLPASAJEROS_ID_TON_TARIFFILTER.CLICK","{handler:'E151P1',iparms:[{av:'divPasajeros_id_ton_tariffiltercontainer_Class',ctrl:'PASAJEROS_ID_TON_TARIFFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divPasajeros_id_ton_tariffiltercontainer_Class',ctrl:'PASAJEROS_ID_TON_TARIFFILTERCONTAINER',prop:'Class'},{av:'edtavCpasajeros_id_ton_tarif_Visible',ctrl:'vCPASAJEROS_ID_TON_TARIF',prop:'Visible'}]}");
         setEventMetadata("LBLPASAJEROS_TON_TARIFAFILTER.CLICK","{handler:'E161P1',iparms:[{av:'divPasajeros_ton_tarifafiltercontainer_Class',ctrl:'PASAJEROS_TON_TARIFAFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divPasajeros_ton_tarifafiltercontainer_Class',ctrl:'PASAJEROS_TON_TARIFAFILTERCONTAINER',prop:'Class'},{av:'edtavCpasajeros_ton_tarifa_Visible',ctrl:'vCPASAJEROS_TON_TARIFA',prop:'Visible'}]}");
         setEventMetadata("LBLPASAJEROS_TARIFAFILTER.CLICK","{handler:'E171P1',iparms:[{av:'divPasajeros_tarifafiltercontainer_Class',ctrl:'PASAJEROS_TARIFAFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divPasajeros_tarifafiltercontainer_Class',ctrl:'PASAJEROS_TARIFAFILTERCONTAINER',prop:'Class'},{av:'edtavCpasajeros_tarifa_Visible',ctrl:'vCPASAJEROS_TARIFA',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E211P2',iparms:[{av:'A63PASAJEROS_ID',fld:'PASAJEROS_ID'}],oparms:[{av:'AV13pPASAJEROS_ID',fld:'vPPASAJEROS_ID'}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cPASAJEROS_ID',fld:'vCPASAJEROS_ID'},{av:'AV7cPASAJEROS_ESCLUSA',fld:'vCPASAJEROS_ESCLUSA'},{av:'AV8cPASAJEROS_TIPO_TARIFA',fld:'vCPASAJEROS_TIPO_TARIFA'},{av:'AV9cPASAJEROS_CARGA',fld:'vCPASAJEROS_CARGA'},{av:'AV10cPASAJEROS_ID_TON_TARIF',fld:'vCPASAJEROS_ID_TON_TARIF'},{av:'AV11cPASAJEROS_TON_TARIFA',fld:'vCPASAJEROS_TON_TARIFA'},{av:'AV12cPASAJEROS_TARIFA',fld:'vCPASAJEROS_TARIFA'}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cPASAJEROS_ID',fld:'vCPASAJEROS_ID'},{av:'AV7cPASAJEROS_ESCLUSA',fld:'vCPASAJEROS_ESCLUSA'},{av:'AV8cPASAJEROS_TIPO_TARIFA',fld:'vCPASAJEROS_TIPO_TARIFA'},{av:'AV9cPASAJEROS_CARGA',fld:'vCPASAJEROS_CARGA'},{av:'AV10cPASAJEROS_ID_TON_TARIF',fld:'vCPASAJEROS_ID_TON_TARIF'},{av:'AV11cPASAJEROS_TON_TARIFA',fld:'vCPASAJEROS_TON_TARIFA'},{av:'AV12cPASAJEROS_TARIFA',fld:'vCPASAJEROS_TARIFA'}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cPASAJEROS_ID',fld:'vCPASAJEROS_ID'},{av:'AV7cPASAJEROS_ESCLUSA',fld:'vCPASAJEROS_ESCLUSA'},{av:'AV8cPASAJEROS_TIPO_TARIFA',fld:'vCPASAJEROS_TIPO_TARIFA'},{av:'AV9cPASAJEROS_CARGA',fld:'vCPASAJEROS_CARGA'},{av:'AV10cPASAJEROS_ID_TON_TARIF',fld:'vCPASAJEROS_ID_TON_TARIF'},{av:'AV11cPASAJEROS_TON_TARIFA',fld:'vCPASAJEROS_TON_TARIFA'},{av:'AV12cPASAJEROS_TARIFA',fld:'vCPASAJEROS_TARIFA'}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cPASAJEROS_ID',fld:'vCPASAJEROS_ID'},{av:'AV7cPASAJEROS_ESCLUSA',fld:'vCPASAJEROS_ESCLUSA'},{av:'AV8cPASAJEROS_TIPO_TARIFA',fld:'vCPASAJEROS_TIPO_TARIFA'},{av:'AV9cPASAJEROS_CARGA',fld:'vCPASAJEROS_CARGA'},{av:'AV10cPASAJEROS_ID_TON_TARIF',fld:'vCPASAJEROS_ID_TON_TARIF'},{av:'AV11cPASAJEROS_TON_TARIFA',fld:'vCPASAJEROS_TON_TARIFA'},{av:'AV12cPASAJEROS_TARIFA',fld:'vCPASAJEROS_TARIFA'}],oparms:[]}");
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
         AV7cPASAJEROS_ESCLUSA = "";
         AV8cPASAJEROS_TIPO_TARIFA = "";
         AV9cPASAJEROS_CARGA = "";
         sDynURL = "";
         FormProcess = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblpasajeros_idfilter_Jsonclick = "";
         TempTags = "";
         lblLblpasajeros_esclusafilter_Jsonclick = "";
         lblLblpasajeros_tipo_tarifafilter_Jsonclick = "";
         lblLblpasajeros_cargafilter_Jsonclick = "";
         lblLblpasajeros_id_ton_tariffilter_Jsonclick = "";
         lblLblpasajeros_ton_tarifafilter_Jsonclick = "";
         lblLblpasajeros_tarifafilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A58PASAJEROS_ESCLUSA = "";
         A60PASAJEROS_TIPO_TARIFA = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV17Linkselection_GXI = "";
         GXKey = "";
         GXCCtl = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         scmdbuf = "";
         lV7cPASAJEROS_ESCLUSA = "";
         lV8cPASAJEROS_TIPO_TARIFA = "";
         lV9cPASAJEROS_CARGA = "";
         A59PASAJEROS_CARGA = "";
         H001P2_A62PASAJEROS_TARIFA = new decimal[1] ;
         H001P2_A61PASAJEROS_TON_TARIFA = new long[1] ;
         H001P2_n61PASAJEROS_TON_TARIFA = new bool[] {false} ;
         H001P2_A65PASAJEROS_ID_TON_TARIF = new short[1] ;
         H001P2_A59PASAJEROS_CARGA = new String[] {""} ;
         H001P2_A60PASAJEROS_TIPO_TARIFA = new String[] {""} ;
         H001P2_A58PASAJEROS_ESCLUSA = new String[] {""} ;
         H001P2_A63PASAJEROS_ID = new short[1] ;
         H001P3_AGRID1_nRecordCount = new long[1] ;
         AV14ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00b0__default(),
            new Object[][] {
                new Object[] {
               H001P2_A62PASAJEROS_TARIFA, H001P2_A61PASAJEROS_TON_TARIFA, H001P2_n61PASAJEROS_TON_TARIFA, H001P2_A65PASAJEROS_ID_TON_TARIF, H001P2_A59PASAJEROS_CARGA, H001P2_A60PASAJEROS_TIPO_TARIFA, H001P2_A58PASAJEROS_ESCLUSA, H001P2_A63PASAJEROS_ID
               }
               , new Object[] {
               H001P3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_84 ;
      private short nGXsfl_84_idx=1 ;
      private short AV6cPASAJEROS_ID ;
      private short AV10cPASAJEROS_ID_TON_TARIF ;
      private short AV13pPASAJEROS_ID ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A63PASAJEROS_ID ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXsfl_84_Refreshing=0 ;
      private short A65PASAJEROS_ID_TON_TARIF ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Rows ;
      private int edtavCpasajeros_id_Enabled ;
      private int edtavCpasajeros_id_Visible ;
      private int edtavCpasajeros_id_ton_tarif_Enabled ;
      private int edtavCpasajeros_id_ton_tarif_Visible ;
      private int edtavCpasajeros_ton_tarifa_Enabled ;
      private int edtavCpasajeros_ton_tarifa_Visible ;
      private int edtavCpasajeros_tarifa_Enabled ;
      private int edtavCpasajeros_tarifa_Visible ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long AV11cPASAJEROS_TON_TARIFA ;
      private long GRID1_nFirstRecordOnPage ;
      private long GXPagingTo2 ;
      private long A61PASAJEROS_TON_TARIFA ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private decimal AV12cPASAJEROS_TARIFA ;
      private decimal A62PASAJEROS_TARIFA ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divPasajeros_idfiltercontainer_Class ;
      private String divPasajeros_esclusafiltercontainer_Class ;
      private String divPasajeros_tipo_tarifafiltercontainer_Class ;
      private String divPasajeros_cargafiltercontainer_Class ;
      private String divPasajeros_id_ton_tariffiltercontainer_Class ;
      private String divPasajeros_ton_tarifafiltercontainer_Class ;
      private String divPasajeros_tarifafiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_84_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divPasajeros_idfiltercontainer_Internalname ;
      private String lblLblpasajeros_idfilter_Internalname ;
      private String lblLblpasajeros_idfilter_Jsonclick ;
      private String TempTags ;
      private String edtavCpasajeros_id_Internalname ;
      private String edtavCpasajeros_id_Jsonclick ;
      private String divPasajeros_esclusafiltercontainer_Internalname ;
      private String lblLblpasajeros_esclusafilter_Internalname ;
      private String lblLblpasajeros_esclusafilter_Jsonclick ;
      private String cmbavCpasajeros_esclusa_Internalname ;
      private String cmbavCpasajeros_esclusa_Jsonclick ;
      private String divPasajeros_tipo_tarifafiltercontainer_Internalname ;
      private String lblLblpasajeros_tipo_tarifafilter_Internalname ;
      private String lblLblpasajeros_tipo_tarifafilter_Jsonclick ;
      private String cmbavCpasajeros_tipo_tarifa_Internalname ;
      private String cmbavCpasajeros_tipo_tarifa_Jsonclick ;
      private String divPasajeros_cargafiltercontainer_Internalname ;
      private String lblLblpasajeros_cargafilter_Internalname ;
      private String lblLblpasajeros_cargafilter_Jsonclick ;
      private String cmbavCpasajeros_carga_Internalname ;
      private String cmbavCpasajeros_carga_Jsonclick ;
      private String divPasajeros_id_ton_tariffiltercontainer_Internalname ;
      private String lblLblpasajeros_id_ton_tariffilter_Internalname ;
      private String lblLblpasajeros_id_ton_tariffilter_Jsonclick ;
      private String edtavCpasajeros_id_ton_tarif_Internalname ;
      private String edtavCpasajeros_id_ton_tarif_Jsonclick ;
      private String divPasajeros_ton_tarifafiltercontainer_Internalname ;
      private String lblLblpasajeros_ton_tarifafilter_Internalname ;
      private String lblLblpasajeros_ton_tarifafilter_Jsonclick ;
      private String edtavCpasajeros_ton_tarifa_Internalname ;
      private String edtavCpasajeros_ton_tarifa_Jsonclick ;
      private String divPasajeros_tarifafiltercontainer_Internalname ;
      private String lblLblpasajeros_tarifafilter_Internalname ;
      private String lblLblpasajeros_tarifafilter_Jsonclick ;
      private String edtavCpasajeros_tarifa_Internalname ;
      private String edtavCpasajeros_tarifa_Jsonclick ;
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
      private String edtPASAJEROS_ID_Internalname ;
      private String cmbPASAJEROS_ESCLUSA_Internalname ;
      private String cmbPASAJEROS_TIPO_TARIFA_Internalname ;
      private String GXKey ;
      private String GXCCtl ;
      private String scmdbuf ;
      private String AV14ADVANCED_LABEL_TEMPLATE ;
      private String ROClassString ;
      private String edtPASAJEROS_ID_Jsonclick ;
      private String cmbPASAJEROS_ESCLUSA_Jsonclick ;
      private String cmbPASAJEROS_TIPO_TARIFA_Jsonclick ;
      private String div_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n61PASAJEROS_TON_TARIFA ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV7cPASAJEROS_ESCLUSA ;
      private String AV8cPASAJEROS_TIPO_TARIFA ;
      private String AV9cPASAJEROS_CARGA ;
      private String A58PASAJEROS_ESCLUSA ;
      private String A60PASAJEROS_TIPO_TARIFA ;
      private String AV17Linkselection_GXI ;
      private String lV7cPASAJEROS_ESCLUSA ;
      private String lV8cPASAJEROS_TIPO_TARIFA ;
      private String lV9cPASAJEROS_CARGA ;
      private String A59PASAJEROS_CARGA ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavCpasajeros_esclusa ;
      private GXCombobox cmbavCpasajeros_tipo_tarifa ;
      private GXCombobox cmbavCpasajeros_carga ;
      private GXCombobox cmbPASAJEROS_ESCLUSA ;
      private GXCombobox cmbPASAJEROS_TIPO_TARIFA ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_default ;
      private decimal[] H001P2_A62PASAJEROS_TARIFA ;
      private long[] H001P2_A61PASAJEROS_TON_TARIFA ;
      private bool[] H001P2_n61PASAJEROS_TON_TARIFA ;
      private short[] H001P2_A65PASAJEROS_ID_TON_TARIF ;
      private String[] H001P2_A59PASAJEROS_CARGA ;
      private String[] H001P2_A60PASAJEROS_TIPO_TARIFA ;
      private String[] H001P2_A58PASAJEROS_ESCLUSA ;
      private short[] H001P2_A63PASAJEROS_ID ;
      private long[] H001P3_AGRID1_nRecordCount ;
      private short aP0_pPASAJEROS_ID ;
      private GXWebForm Form ;
   }

   public class gx00b0__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001P2( IGxContext context ,
                                             String AV7cPASAJEROS_ESCLUSA ,
                                             String AV8cPASAJEROS_TIPO_TARIFA ,
                                             String AV9cPASAJEROS_CARGA ,
                                             short AV10cPASAJEROS_ID_TON_TARIF ,
                                             long AV11cPASAJEROS_TON_TARIFA ,
                                             decimal AV12cPASAJEROS_TARIFA ,
                                             String A58PASAJEROS_ESCLUSA ,
                                             String A60PASAJEROS_TIPO_TARIFA ,
                                             String A59PASAJEROS_CARGA ,
                                             short A65PASAJEROS_ID_TON_TARIF ,
                                             long A61PASAJEROS_TON_TARIFA ,
                                             decimal A62PASAJEROS_TARIFA ,
                                             short AV6cPASAJEROS_ID )
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
         sSelectString = " [PASAJEROS_TARIFA], [PASAJEROS_TON_TARIFA], [PASAJEROS_ID_TON_TARIF], [PASAJEROS_CARGA], [PASAJEROS_TIPO_TARIFA], [PASAJEROS_ESCLUSA], [PASAJEROS_ID]";
         sFromString = " FROM [PASAJEROS] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([PASAJEROS_ID] >= @AV6cPASAJEROS_ID)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cPASAJEROS_ESCLUSA)) )
         {
            sWhereString = sWhereString + " and ([PASAJEROS_ESCLUSA] like @lV7cPASAJEROS_ESCLUSA)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cPASAJEROS_TIPO_TARIFA)) )
         {
            sWhereString = sWhereString + " and ([PASAJEROS_TIPO_TARIFA] like @lV8cPASAJEROS_TIPO_TARIFA)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cPASAJEROS_CARGA)) )
         {
            sWhereString = sWhereString + " and ([PASAJEROS_CARGA] like @lV9cPASAJEROS_CARGA)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (0==AV10cPASAJEROS_ID_TON_TARIF) )
         {
            sWhereString = sWhereString + " and ([PASAJEROS_ID_TON_TARIF] >= @AV10cPASAJEROS_ID_TON_TARIF)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (0==AV11cPASAJEROS_TON_TARIFA) )
         {
            sWhereString = sWhereString + " and ([PASAJEROS_TON_TARIFA] >= @AV11cPASAJEROS_TON_TARIFA)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV12cPASAJEROS_TARIFA) )
         {
            sWhereString = sWhereString + " and ([PASAJEROS_TARIFA] >= @AV12cPASAJEROS_TARIFA)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [PASAJEROS_ID]";
         scmdbuf = "SELECT * FROM (SELECT " + sSelectString + ", ROW_NUMBER() OVER (" + sOrderString + " ) AS GX_ROW_NUMBER" + sFromString + sWhereString + ") AS GX_CTE WHERE GX_ROW_NUMBER" + " BETWEEN " + "@GXPagingFrom2" + " AND " + "@GXPagingTo2" + " OR " + "@GXPagingTo2" + " < " + "@GXPagingFrom2" + " AND GX_ROW_NUMBER >= " + "@GXPagingFrom2";
         scmdbuf = scmdbuf + " OPTION (FAST 11)";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H001P3( IGxContext context ,
                                             String AV7cPASAJEROS_ESCLUSA ,
                                             String AV8cPASAJEROS_TIPO_TARIFA ,
                                             String AV9cPASAJEROS_CARGA ,
                                             short AV10cPASAJEROS_ID_TON_TARIF ,
                                             long AV11cPASAJEROS_TON_TARIFA ,
                                             decimal AV12cPASAJEROS_TARIFA ,
                                             String A58PASAJEROS_ESCLUSA ,
                                             String A60PASAJEROS_TIPO_TARIFA ,
                                             String A59PASAJEROS_CARGA ,
                                             short A65PASAJEROS_ID_TON_TARIF ,
                                             long A61PASAJEROS_TON_TARIFA ,
                                             decimal A62PASAJEROS_TARIFA ,
                                             short AV6cPASAJEROS_ID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [PASAJEROS] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([PASAJEROS_ID] >= @AV6cPASAJEROS_ID)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cPASAJEROS_ESCLUSA)) )
         {
            sWhereString = sWhereString + " and ([PASAJEROS_ESCLUSA] like @lV7cPASAJEROS_ESCLUSA)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8cPASAJEROS_TIPO_TARIFA)) )
         {
            sWhereString = sWhereString + " and ([PASAJEROS_TIPO_TARIFA] like @lV8cPASAJEROS_TIPO_TARIFA)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9cPASAJEROS_CARGA)) )
         {
            sWhereString = sWhereString + " and ([PASAJEROS_CARGA] like @lV9cPASAJEROS_CARGA)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (0==AV10cPASAJEROS_ID_TON_TARIF) )
         {
            sWhereString = sWhereString + " and ([PASAJEROS_ID_TON_TARIF] >= @AV10cPASAJEROS_ID_TON_TARIF)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (0==AV11cPASAJEROS_TON_TARIFA) )
         {
            sWhereString = sWhereString + " and ([PASAJEROS_TON_TARIFA] >= @AV11cPASAJEROS_TON_TARIFA)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV12cPASAJEROS_TARIFA) )
         {
            sWhereString = sWhereString + " and ([PASAJEROS_TARIFA] >= @AV12cPASAJEROS_TARIFA)";
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
                     return conditional_H001P2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (long)dynConstraints[4] , (decimal)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (long)dynConstraints[10] , (decimal)dynConstraints[11] , (short)dynConstraints[12] );
               case 1 :
                     return conditional_H001P3(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (long)dynConstraints[4] , (decimal)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (short)dynConstraints[9] , (long)dynConstraints[10] , (decimal)dynConstraints[11] , (short)dynConstraints[12] );
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
          Object[] prmH001P2 ;
          prmH001P2 = new Object[] {
          new Object[] {"@AV6cPASAJEROS_ID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV7cPASAJEROS_ESCLUSA",SqlDbType.VarChar,40,0} ,
          new Object[] {"@lV8cPASAJEROS_TIPO_TARIFA",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV9cPASAJEROS_CARGA",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV10cPASAJEROS_ID_TON_TARIF",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11cPASAJEROS_TON_TARIFA",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV12cPASAJEROS_TARIFA",SqlDbType.Decimal,10,2} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,6,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Decimal,12,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Decimal,12,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,6,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,6,0}
          } ;
          Object[] prmH001P3 ;
          prmH001P3 = new Object[] {
          new Object[] {"@AV6cPASAJEROS_ID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV7cPASAJEROS_ESCLUSA",SqlDbType.VarChar,40,0} ,
          new Object[] {"@lV8cPASAJEROS_TIPO_TARIFA",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV9cPASAJEROS_CARGA",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV10cPASAJEROS_ID_TON_TARIF",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11cPASAJEROS_TON_TARIFA",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV12cPASAJEROS_TARIFA",SqlDbType.Decimal,10,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001P2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001P2,11,0,false,false )
             ,new CursorDef("H001P3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001P3,1,0,false,false )
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
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(6) ;
                ((short[]) buf[7])[0] = rslt.getShort(7) ;
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
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[16]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[17]);
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
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[11]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[12]);
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
