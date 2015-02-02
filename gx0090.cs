/*
               File: Gx0090
        Description: Selection List Buques refrigerados, carga general, otros y desplazamiento
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 10:41:40.53
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
   public class gx0090 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0090( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public gx0090( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out short aP0_pREF_CGRAL_DESP_ID )
      {
         this.AV11pREF_CGRAL_DESP_ID = 0 ;
         executePrivate();
         aP0_pREF_CGRAL_DESP_ID=this.AV11pREF_CGRAL_DESP_ID;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavCref_cgral_desp_tipo = new GXCombobox();
         cmbREF_CGRAL_DESP_TIPO = new GXCombobox();
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
               nRC_GXsfl_64 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_64_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_64_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_GXsfl_64, nGXsfl_64_idx, sGXsfl_64_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               subGrid1_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV6cREF_CGRAL_DESP_ID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cREF_CGRAL_DESP_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cREF_CGRAL_DESP_ID), 4, 0)));
               AV7cREF_CGRAL_DESP_TIPO = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cREF_CGRAL_DESP_TIPO", AV7cREF_CGRAL_DESP_TIPO);
               AV8cREF_CGRAL_DESP_ID_TON_TARIF = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cREF_CGRAL_DESP_ID_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cREF_CGRAL_DESP_ID_TON_TARIF), 4, 0)));
               AV9cREF_CGRAL_DESP_TON_TARIF = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cREF_CGRAL_DESP_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cREF_CGRAL_DESP_TON_TARIF), 10, 0)));
               AV10cREF_CGRAL_DESP_TARIFA = NumberUtil.Val( GetNextPar( ), ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cREF_CGRAL_DESP_TARIFA", StringUtil.LTrim( StringUtil.Str( AV10cREF_CGRAL_DESP_TARIFA, 10, 2)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cREF_CGRAL_DESP_ID, AV7cREF_CGRAL_DESP_TIPO, AV8cREF_CGRAL_DESP_ID_TON_TARIF, AV9cREF_CGRAL_DESP_TON_TARIF, AV10cREF_CGRAL_DESP_TARIFA) ;
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
               AV11pREF_CGRAL_DESP_ID = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pREF_CGRAL_DESP_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pREF_CGRAL_DESP_ID), 4, 0)));
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
         PA1O2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1O2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201512010414055");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0090.aspx") + "?" + UrlEncode("" +AV11pREF_CGRAL_DESP_ID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCREF_CGRAL_DESP_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cREF_CGRAL_DESP_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCREF_CGRAL_DESP_TIPO", StringUtil.RTrim( AV7cREF_CGRAL_DESP_TIPO));
         GxWebStd.gx_hidden_field( context, "GXH_vCREF_CGRAL_DESP_ID_TON_TARIF", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cREF_CGRAL_DESP_ID_TON_TARIF), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCREF_CGRAL_DESP_TON_TARIF", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cREF_CGRAL_DESP_TON_TARIF), 10, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCREF_CGRAL_DESP_TARIFA", StringUtil.LTrim( StringUtil.NToC( AV10cREF_CGRAL_DESP_TARIFA, 10, 2, context.GetLanguageProperty( "decimal_point"), "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_64", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_64), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "vPREF_CGRAL_DESP_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11pREF_CGRAL_DESP_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "REF_CGRAL_DESP_IDFILTERCONTAINER_Class", StringUtil.RTrim( divRef_cgral_desp_idfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "REF_CGRAL_DESP_TIPOFILTERCONTAINER_Class", StringUtil.RTrim( divRef_cgral_desp_tipofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "REF_CGRAL_DESP_ID_TON_TARIFFILTERCONTAINER_Class", StringUtil.RTrim( divRef_cgral_desp_id_ton_tariffiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "REF_CGRAL_DESP_TON_TARIFFILTERCONTAINER_Class", StringUtil.RTrim( divRef_cgral_desp_ton_tariffiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "REF_CGRAL_DESP_TARIFAFILTERCONTAINER_Class", StringUtil.RTrim( divRef_cgral_desp_tarifafiltercontainer_Class));
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
            WE1O2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1O2( ) ;
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
         return formatLink("gx0090.aspx") + "?" + UrlEncode("" +AV11pREF_CGRAL_DESP_ID) ;
      }

      public override String GetPgmname( )
      {
         return "gx0090" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "Selection List Buques refrigerados, carga general, otros y desplazamiento", "") ;
      }

      protected void WB1O0( )
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
            GxWebStd.gx_div_start( context, divRef_cgral_desp_idfiltercontainer_Internalname, 1, 0, "px", 0, "px", divRef_cgral_desp_idfiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblref_cgral_desp_idfilter_Internalname, context.GetMessage( "Identificador unico de la transaccion", ""), "", "", lblLblref_cgral_desp_idfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e111o1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0090.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 WWFiltersCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_64_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCref_cgral_desp_id_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cREF_CGRAL_DESP_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCref_cgral_desp_id_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cREF_CGRAL_DESP_ID), "ZZZ9")) : context.localUtil.Format( (decimal)(AV6cREF_CGRAL_DESP_ID), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCref_cgral_desp_id_Jsonclick, 0, "Attribute", "", "", "", edtavCref_cgral_desp_id_Visible, edtavCref_cgral_desp_id_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx0090.htm");
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
            GxWebStd.gx_div_start( context, divRef_cgral_desp_tipofiltercontainer_Internalname, 1, 0, "px", 0, "px", divRef_cgral_desp_tipofiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblref_cgral_desp_tipofilter_Internalname, context.GetMessage( "Condicion en que transita el buque", ""), "", "", lblLblref_cgral_desp_tipofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e121o1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0090.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 WWFiltersCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_64_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCref_cgral_desp_tipo, cmbavCref_cgral_desp_tipo_Internalname, AV7cREF_CGRAL_DESP_TIPO, 1, cmbavCref_cgral_desp_tipo_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", cmbavCref_cgral_desp_tipo.Visible, cmbavCref_cgral_desp_tipo.Enabled, 0, 0, 50, "chr", 0, "", "", "Attribute", "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(26);\"", "", true, "HLP_Gx0090.htm");
            cmbavCref_cgral_desp_tipo.CurrentValue = AV7cREF_CGRAL_DESP_TIPO;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCref_cgral_desp_tipo_Internalname, "Values", (String)(cmbavCref_cgral_desp_tipo.ToJavascriptSource()));
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
            GxWebStd.gx_div_start( context, divRef_cgral_desp_id_ton_tariffiltercontainer_Internalname, 1, 0, "px", 0, "px", divRef_cgral_desp_id_ton_tariffiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblref_cgral_desp_id_ton_tariffilter_Internalname, context.GetMessage( "Identificador de las toneladas totales", ""), "", "", lblLblref_cgral_desp_id_ton_tariffilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e131o1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0090.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 WWFiltersCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_64_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCref_cgral_desp_id_ton_tarif_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cREF_CGRAL_DESP_ID_TON_TARIF), 4, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCref_cgral_desp_id_ton_tarif_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8cREF_CGRAL_DESP_ID_TON_TARIF), "ZZZ9")) : context.localUtil.Format( (decimal)(AV8cREF_CGRAL_DESP_ID_TON_TARIF), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCref_cgral_desp_id_ton_tarif_Jsonclick, 0, "Attribute", "", "", "", edtavCref_cgral_desp_id_ton_tarif_Visible, edtavCref_cgral_desp_id_ton_tarif_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx0090.htm");
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
            GxWebStd.gx_div_start( context, divRef_cgral_desp_ton_tariffiltercontainer_Internalname, 1, 0, "px", 0, "px", divRef_cgral_desp_ton_tariffiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblref_cgral_desp_ton_tariffilter_Internalname, context.GetMessage( "Rango de las toneladas totales", ""), "", "", lblLblref_cgral_desp_ton_tariffilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e141o1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0090.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 WWFiltersCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_64_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCref_cgral_desp_ton_tarif_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cREF_CGRAL_DESP_TON_TARIF), 10, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCref_cgral_desp_ton_tarif_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV9cREF_CGRAL_DESP_TON_TARIF), "ZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV9cREF_CGRAL_DESP_TON_TARIF), "ZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCref_cgral_desp_ton_tarif_Jsonclick, 0, "Attribute", "", "", "", edtavCref_cgral_desp_ton_tarif_Visible, edtavCref_cgral_desp_ton_tarif_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx0090.htm");
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
            GxWebStd.gx_div_start( context, divRef_cgral_desp_tarifafiltercontainer_Internalname, 1, 0, "px", 0, "px", divRef_cgral_desp_tarifafiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblref_cgral_desp_tarifafilter_Internalname, context.GetMessage( "Tarifa que se aplicara a las toneladas", ""), "", "", lblLblref_cgral_desp_tarifafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e151o1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0090.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 WWFiltersCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_64_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCref_cgral_desp_tarifa_Internalname, StringUtil.LTrim( StringUtil.NToC( AV10cREF_CGRAL_DESP_TARIFA, 10, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCref_cgral_desp_tarifa_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV10cREF_CGRAL_DESP_TARIFA, "ZZZZZZ9.99")) : context.localUtil.Format( AV10cREF_CGRAL_DESP_TARIFA, "ZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCref_cgral_desp_tarifa_Jsonclick, 0, "Attribute", "", "", "", edtavCref_cgral_desp_tarifa_Visible, edtavCref_cgral_desp_tarifa_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx0090.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(64), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e161o1_client"+"'", TempTags, "", 2, "HLP_Gx0090.htm");
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" gxgridid=\"64\">") ;
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
               context.SendWebValue( context.GetMessage( "Tipo", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "TON ID", "")) ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A49REF_CGRAL_DESP_ID), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A45REF_CGRAL_DESP_TIPO));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A48REF_CGRAL_DESP_ID_TON_TARIF), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 64 )
         {
            wbEnd = 0;
            nRC_GXsfl_64 = (short)(nGXsfl_64_idx-1);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(64), 2, 0)+","+"null"+");", context.GetMessage( "GX_BtnCancel", ""), bttBtn_cancel_Jsonclick, 1, context.GetMessage( "GX_BtnCancel", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0090.htm");
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

      protected void START1O2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_2-86442", 0) ;
            Form.Meta.addItem("description", context.GetMessage( "Selection List Buques refrigerados, carga general, otros y desplazamiento", ""), 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1O0( ) ;
      }

      protected void WS1O2( )
      {
         START1O2( ) ;
         EVT1O2( ) ;
      }

      protected void EVT1O2( )
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
                              nGXsfl_64_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_64_idx), 4, 0)), 4, "0");
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_64_idx;
                              edtREF_CGRAL_DESP_ID_Internalname = "REF_CGRAL_DESP_ID_"+sGXsfl_64_idx;
                              cmbREF_CGRAL_DESP_TIPO_Internalname = "REF_CGRAL_DESP_TIPO_"+sGXsfl_64_idx;
                              edtREF_CGRAL_DESP_ID_TON_TARIF_Internalname = "REF_CGRAL_DESP_ID_TON_TARIF_"+sGXsfl_64_idx;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV15Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))));
                              A49REF_CGRAL_DESP_ID = (short)(context.localUtil.CToN( cgiGet( edtREF_CGRAL_DESP_ID_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtREF_CGRAL_DESP_ID_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A49REF_CGRAL_DESP_ID), 4, 0)));
                              cmbREF_CGRAL_DESP_TIPO.Name = cmbREF_CGRAL_DESP_TIPO_Internalname;
                              cmbREF_CGRAL_DESP_TIPO.CurrentValue = cgiGet( cmbREF_CGRAL_DESP_TIPO_Internalname);
                              A45REF_CGRAL_DESP_TIPO = cgiGet( cmbREF_CGRAL_DESP_TIPO_Internalname);
                              n45REF_CGRAL_DESP_TIPO = false;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbREF_CGRAL_DESP_TIPO_Internalname, A45REF_CGRAL_DESP_TIPO);
                              A48REF_CGRAL_DESP_ID_TON_TARIF = (short)(context.localUtil.CToN( cgiGet( edtREF_CGRAL_DESP_ID_TON_TARIF_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtREF_CGRAL_DESP_ID_TON_TARIF_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A48REF_CGRAL_DESP_ID_TON_TARIF), 4, 0)));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E171O2 */
                                    E171O2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E181O2 */
                                    E181O2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cref_cgral_desp_id Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCREF_CGRAL_DESP_ID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV6cREF_CGRAL_DESP_ID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cref_cgral_desp_tipo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCREF_CGRAL_DESP_TIPO"), AV7cREF_CGRAL_DESP_TIPO) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cref_cgral_desp_id_ton_tarif Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCREF_CGRAL_DESP_ID_TON_TARIF"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV8cREF_CGRAL_DESP_ID_TON_TARIF )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cref_cgral_desp_ton_tarif Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCREF_CGRAL_DESP_TON_TARIF"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV9cREF_CGRAL_DESP_TON_TARIF )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cref_cgral_desp_tarifa Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCREF_CGRAL_DESP_TARIFA"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV10cREF_CGRAL_DESP_TARIFA )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E191O2 */
                                          E191O2 ();
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

      protected void WE1O2( )
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

      protected void PA1O2( )
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
            cmbavCref_cgral_desp_tipo.Name = "vCREF_CGRAL_DESP_TIPO";
            cmbavCref_cgral_desp_tipo.WebTags = "";
            cmbavCref_cgral_desp_tipo.addItem("", context.GetMessage( "GX_EmptyItemText", ""), 0);
            cmbavCref_cgral_desp_tipo.addItem("CARGADO", context.GetMessage( "Cargado", ""), 0);
            cmbavCref_cgral_desp_tipo.addItem("EN LASTRE", context.GetMessage( "En Lastre", ""), 0);
            if ( cmbavCref_cgral_desp_tipo.ItemCount > 0 )
            {
               AV7cREF_CGRAL_DESP_TIPO = cmbavCref_cgral_desp_tipo.getValidValue(AV7cREF_CGRAL_DESP_TIPO);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cREF_CGRAL_DESP_TIPO", AV7cREF_CGRAL_DESP_TIPO);
            }
            GXCCtl = "REF_CGRAL_DESP_TIPO_" + sGXsfl_64_idx;
            cmbREF_CGRAL_DESP_TIPO.Name = GXCCtl;
            cmbREF_CGRAL_DESP_TIPO.WebTags = "";
            cmbREF_CGRAL_DESP_TIPO.addItem("", context.GetMessage( "GX_EmptyItemText", ""), 0);
            cmbREF_CGRAL_DESP_TIPO.addItem("CARGADO", context.GetMessage( "Cargado", ""), 0);
            cmbREF_CGRAL_DESP_TIPO.addItem("EN LASTRE", context.GetMessage( "En Lastre", ""), 0);
            if ( cmbREF_CGRAL_DESP_TIPO.ItemCount > 0 )
            {
               A45REF_CGRAL_DESP_TIPO = cmbREF_CGRAL_DESP_TIPO.getValidValue(A45REF_CGRAL_DESP_TIPO);
               n45REF_CGRAL_DESP_TIPO = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbREF_CGRAL_DESP_TIPO_Internalname, A45REF_CGRAL_DESP_TIPO);
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

      protected void gxnrGrid1_newrow( short nRC_GXsfl_64 ,
                                       short nGXsfl_64_idx ,
                                       String sGXsfl_64_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_64_idx), 4, 0)), 4, "0");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_64_idx;
         edtREF_CGRAL_DESP_ID_Internalname = "REF_CGRAL_DESP_ID_"+sGXsfl_64_idx;
         cmbREF_CGRAL_DESP_TIPO_Internalname = "REF_CGRAL_DESP_TIPO_"+sGXsfl_64_idx;
         edtREF_CGRAL_DESP_ID_TON_TARIF_Internalname = "REF_CGRAL_DESP_ID_TON_TARIF_"+sGXsfl_64_idx;
         while ( nGXsfl_64_idx <= nRC_GXsfl_64 )
         {
            sendrow_642( ) ;
            nGXsfl_64_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_64_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_64_idx+1));
            sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_64_idx), 4, 0)), 4, "0");
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_64_idx;
            edtREF_CGRAL_DESP_ID_Internalname = "REF_CGRAL_DESP_ID_"+sGXsfl_64_idx;
            cmbREF_CGRAL_DESP_TIPO_Internalname = "REF_CGRAL_DESP_TIPO_"+sGXsfl_64_idx;
            edtREF_CGRAL_DESP_ID_TON_TARIF_Internalname = "REF_CGRAL_DESP_ID_TON_TARIF_"+sGXsfl_64_idx;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        short AV6cREF_CGRAL_DESP_ID ,
                                        String AV7cREF_CGRAL_DESP_TIPO ,
                                        short AV8cREF_CGRAL_DESP_ID_TON_TARIF ,
                                        long AV9cREF_CGRAL_DESP_TON_TARIF ,
                                        decimal AV10cREF_CGRAL_DESP_TARIFA )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         cmbavCref_cgral_desp_tipo.Name = "vCREF_CGRAL_DESP_TIPO";
         cmbavCref_cgral_desp_tipo.WebTags = "";
         cmbavCref_cgral_desp_tipo.addItem("", context.GetMessage( "GX_EmptyItemText", ""), 0);
         cmbavCref_cgral_desp_tipo.addItem("CARGADO", context.GetMessage( "Cargado", ""), 0);
         cmbavCref_cgral_desp_tipo.addItem("EN LASTRE", context.GetMessage( "En Lastre", ""), 0);
         if ( cmbavCref_cgral_desp_tipo.ItemCount > 0 )
         {
            AV7cREF_CGRAL_DESP_TIPO = cmbavCref_cgral_desp_tipo.getValidValue(AV7cREF_CGRAL_DESP_TIPO);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cREF_CGRAL_DESP_TIPO", AV7cREF_CGRAL_DESP_TIPO);
         }
         GXCCtl = "REF_CGRAL_DESP_TIPO_" + sGXsfl_64_idx;
         cmbREF_CGRAL_DESP_TIPO.Name = GXCCtl;
         cmbREF_CGRAL_DESP_TIPO.WebTags = "";
         cmbREF_CGRAL_DESP_TIPO.addItem("", context.GetMessage( "GX_EmptyItemText", ""), 0);
         cmbREF_CGRAL_DESP_TIPO.addItem("CARGADO", context.GetMessage( "Cargado", ""), 0);
         cmbREF_CGRAL_DESP_TIPO.addItem("EN LASTRE", context.GetMessage( "En Lastre", ""), 0);
         if ( cmbREF_CGRAL_DESP_TIPO.ItemCount > 0 )
         {
            A45REF_CGRAL_DESP_TIPO = cmbREF_CGRAL_DESP_TIPO.getValidValue(A45REF_CGRAL_DESP_TIPO);
            n45REF_CGRAL_DESP_TIPO = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbREF_CGRAL_DESP_TIPO_Internalname, A45REF_CGRAL_DESP_TIPO);
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         RF1O2( ) ;
         context.GX_msglist = BackMsgLst;
         /* End function gxgrGrid1_refresh */
      }

      public void Refresh( )
      {
         RF1O2( ) ;
      }

      protected void RF1O2( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         Grid1Container.AddObjectProperty("GridName", "Grid1");
         Grid1Container.AddObjectProperty("CmpContext", "");
         Grid1Container.AddObjectProperty("InMasterPage", "false");
         wbStart = 64;
         nGXsfl_64_idx = 1;
         sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_64_idx), 4, 0)), 4, "0");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_64_idx;
         edtREF_CGRAL_DESP_ID_Internalname = "REF_CGRAL_DESP_ID_"+sGXsfl_64_idx;
         cmbREF_CGRAL_DESP_TIPO_Internalname = "REF_CGRAL_DESP_TIPO_"+sGXsfl_64_idx;
         edtREF_CGRAL_DESP_ID_TON_TARIF_Internalname = "REF_CGRAL_DESP_ID_TON_TARIF_"+sGXsfl_64_idx;
         nGXsfl_64_Refreshing = 1;
         Grid1Container.PageSize = subGrid1_Recordsperpage( );
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_64_idx), 4, 0)), 4, "0");
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_64_idx;
            edtREF_CGRAL_DESP_ID_Internalname = "REF_CGRAL_DESP_ID_"+sGXsfl_64_idx;
            cmbREF_CGRAL_DESP_TIPO_Internalname = "REF_CGRAL_DESP_TIPO_"+sGXsfl_64_idx;
            edtREF_CGRAL_DESP_ID_TON_TARIF_Internalname = "REF_CGRAL_DESP_ID_TON_TARIF_"+sGXsfl_64_idx;
            GXPagingFrom2 = (int)(((10==0) ? 1 : GRID1_nFirstRecordOnPage+1));
            GXPagingTo2 = ((10==0) ? 10000 : GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7cREF_CGRAL_DESP_TIPO ,
                                                 AV8cREF_CGRAL_DESP_ID_TON_TARIF ,
                                                 AV9cREF_CGRAL_DESP_TON_TARIF ,
                                                 AV10cREF_CGRAL_DESP_TARIFA ,
                                                 A45REF_CGRAL_DESP_TIPO ,
                                                 A48REF_CGRAL_DESP_ID_TON_TARIF ,
                                                 A46REF_CGRAL_DESP_TON_TARIF ,
                                                 A47REF_CGRAL_DESP_TARIFA ,
                                                 AV6cREF_CGRAL_DESP_ID },
                                                 new int[] {
                                                 TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.LONG, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.DECIMAL,
                                                 TypeConstants.SHORT
                                                 }
            });
            lV7cREF_CGRAL_DESP_TIPO = StringUtil.PadR( StringUtil.RTrim( AV7cREF_CGRAL_DESP_TIPO), 50, "%");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cREF_CGRAL_DESP_TIPO", AV7cREF_CGRAL_DESP_TIPO);
            /* Using cursor H001O2 */
            pr_default.execute(0, new Object[] {AV6cREF_CGRAL_DESP_ID, lV7cREF_CGRAL_DESP_TIPO, AV8cREF_CGRAL_DESP_ID_TON_TARIF, AV9cREF_CGRAL_DESP_TON_TARIF, AV10cREF_CGRAL_DESP_TARIFA, GXPagingFrom2, GXPagingTo2, GXPagingTo2, GXPagingFrom2, GXPagingFrom2});
            nGXsfl_64_idx = 1;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A47REF_CGRAL_DESP_TARIFA = H001O2_A47REF_CGRAL_DESP_TARIFA[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47REF_CGRAL_DESP_TARIFA", StringUtil.LTrim( StringUtil.Str( A47REF_CGRAL_DESP_TARIFA, 10, 2)));
               A46REF_CGRAL_DESP_TON_TARIF = H001O2_A46REF_CGRAL_DESP_TON_TARIF[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46REF_CGRAL_DESP_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(A46REF_CGRAL_DESP_TON_TARIF), 10, 0)));
               n46REF_CGRAL_DESP_TON_TARIF = H001O2_n46REF_CGRAL_DESP_TON_TARIF[0];
               A48REF_CGRAL_DESP_ID_TON_TARIF = H001O2_A48REF_CGRAL_DESP_ID_TON_TARIF[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtREF_CGRAL_DESP_ID_TON_TARIF_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A48REF_CGRAL_DESP_ID_TON_TARIF), 4, 0)));
               A45REF_CGRAL_DESP_TIPO = H001O2_A45REF_CGRAL_DESP_TIPO[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbREF_CGRAL_DESP_TIPO_Internalname, A45REF_CGRAL_DESP_TIPO);
               n45REF_CGRAL_DESP_TIPO = H001O2_n45REF_CGRAL_DESP_TIPO[0];
               A49REF_CGRAL_DESP_ID = H001O2_A49REF_CGRAL_DESP_ID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtREF_CGRAL_DESP_ID_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A49REF_CGRAL_DESP_ID), 4, 0)));
               /* Execute user event: E181O2 */
               E181O2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 64;
            WB1O0( ) ;
         }
         nGXsfl_64_Refreshing = 0;
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
                                              AV7cREF_CGRAL_DESP_TIPO ,
                                              AV8cREF_CGRAL_DESP_ID_TON_TARIF ,
                                              AV9cREF_CGRAL_DESP_TON_TARIF ,
                                              AV10cREF_CGRAL_DESP_TARIFA ,
                                              A45REF_CGRAL_DESP_TIPO ,
                                              A48REF_CGRAL_DESP_ID_TON_TARIF ,
                                              A46REF_CGRAL_DESP_TON_TARIF ,
                                              A47REF_CGRAL_DESP_TARIFA ,
                                              AV6cREF_CGRAL_DESP_ID },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.LONG, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.DECIMAL,
                                              TypeConstants.SHORT
                                              }
         });
         lV7cREF_CGRAL_DESP_TIPO = StringUtil.PadR( StringUtil.RTrim( AV7cREF_CGRAL_DESP_TIPO), 50, "%");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cREF_CGRAL_DESP_TIPO", AV7cREF_CGRAL_DESP_TIPO);
         /* Using cursor H001O3 */
         pr_default.execute(1, new Object[] {AV6cREF_CGRAL_DESP_ID, lV7cREF_CGRAL_DESP_TIPO, AV8cREF_CGRAL_DESP_ID_TON_TARIF, AV9cREF_CGRAL_DESP_TON_TARIF, AV10cREF_CGRAL_DESP_TARIFA});
         GRID1_nRecordCount = H001O3_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cREF_CGRAL_DESP_ID, AV7cREF_CGRAL_DESP_TIPO, AV8cREF_CGRAL_DESP_ID_TON_TARIF, AV9cREF_CGRAL_DESP_TON_TARIF, AV10cREF_CGRAL_DESP_TARIFA) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cREF_CGRAL_DESP_ID, AV7cREF_CGRAL_DESP_TIPO, AV8cREF_CGRAL_DESP_ID_TON_TARIF, AV9cREF_CGRAL_DESP_TON_TARIF, AV10cREF_CGRAL_DESP_TARIFA) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cREF_CGRAL_DESP_ID, AV7cREF_CGRAL_DESP_TIPO, AV8cREF_CGRAL_DESP_ID_TON_TARIF, AV9cREF_CGRAL_DESP_TON_TARIF, AV10cREF_CGRAL_DESP_TARIFA) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cREF_CGRAL_DESP_ID, AV7cREF_CGRAL_DESP_TIPO, AV8cREF_CGRAL_DESP_ID_TON_TARIF, AV9cREF_CGRAL_DESP_TON_TARIF, AV10cREF_CGRAL_DESP_TARIFA) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cREF_CGRAL_DESP_ID, AV7cREF_CGRAL_DESP_TIPO, AV8cREF_CGRAL_DESP_ID_TON_TARIF, AV9cREF_CGRAL_DESP_TON_TARIF, AV10cREF_CGRAL_DESP_TARIFA) ;
         }
         return (int)(0) ;
      }

      protected void STRUP1O0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E171O2 */
         E171O2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCref_cgral_desp_id_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCref_cgral_desp_id_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCREF_CGRAL_DESP_ID");
               GX_FocusControl = edtavCref_cgral_desp_id_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cREF_CGRAL_DESP_ID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cREF_CGRAL_DESP_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cREF_CGRAL_DESP_ID), 4, 0)));
            }
            else
            {
               AV6cREF_CGRAL_DESP_ID = (short)(context.localUtil.CToN( cgiGet( edtavCref_cgral_desp_id_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cREF_CGRAL_DESP_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cREF_CGRAL_DESP_ID), 4, 0)));
            }
            cmbavCref_cgral_desp_tipo.Name = cmbavCref_cgral_desp_tipo_Internalname;
            cmbavCref_cgral_desp_tipo.CurrentValue = cgiGet( cmbavCref_cgral_desp_tipo_Internalname);
            AV7cREF_CGRAL_DESP_TIPO = cgiGet( cmbavCref_cgral_desp_tipo_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cREF_CGRAL_DESP_TIPO", AV7cREF_CGRAL_DESP_TIPO);
            if ( cmbavCref_cgral_desp_tipo.ItemCount > 0 )
            {
               AV7cREF_CGRAL_DESP_TIPO = cmbavCref_cgral_desp_tipo.getValidValue(AV7cREF_CGRAL_DESP_TIPO);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cREF_CGRAL_DESP_TIPO", AV7cREF_CGRAL_DESP_TIPO);
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCref_cgral_desp_id_ton_tarif_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCref_cgral_desp_id_ton_tarif_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCREF_CGRAL_DESP_ID_TON_TARIF");
               GX_FocusControl = edtavCref_cgral_desp_id_ton_tarif_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8cREF_CGRAL_DESP_ID_TON_TARIF = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cREF_CGRAL_DESP_ID_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cREF_CGRAL_DESP_ID_TON_TARIF), 4, 0)));
            }
            else
            {
               AV8cREF_CGRAL_DESP_ID_TON_TARIF = (short)(context.localUtil.CToN( cgiGet( edtavCref_cgral_desp_id_ton_tarif_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cREF_CGRAL_DESP_ID_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cREF_CGRAL_DESP_ID_TON_TARIF), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCref_cgral_desp_ton_tarif_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCref_cgral_desp_ton_tarif_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCREF_CGRAL_DESP_TON_TARIF");
               GX_FocusControl = edtavCref_cgral_desp_ton_tarif_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9cREF_CGRAL_DESP_TON_TARIF = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cREF_CGRAL_DESP_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cREF_CGRAL_DESP_TON_TARIF), 10, 0)));
            }
            else
            {
               AV9cREF_CGRAL_DESP_TON_TARIF = (long)(context.localUtil.CToN( cgiGet( edtavCref_cgral_desp_ton_tarif_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cREF_CGRAL_DESP_TON_TARIF", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cREF_CGRAL_DESP_TON_TARIF), 10, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCref_cgral_desp_tarifa_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCref_cgral_desp_tarifa_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 9999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCREF_CGRAL_DESP_TARIFA");
               GX_FocusControl = edtavCref_cgral_desp_tarifa_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10cREF_CGRAL_DESP_TARIFA = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cREF_CGRAL_DESP_TARIFA", StringUtil.LTrim( StringUtil.Str( AV10cREF_CGRAL_DESP_TARIFA, 10, 2)));
            }
            else
            {
               AV10cREF_CGRAL_DESP_TARIFA = context.localUtil.CToN( cgiGet( edtavCref_cgral_desp_tarifa_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cREF_CGRAL_DESP_TARIFA", StringUtil.LTrim( StringUtil.Str( AV10cREF_CGRAL_DESP_TARIFA, 10, 2)));
            }
            /* Read saved values. */
            nRC_GXsfl_64 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_64"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            AV11pREF_CGRAL_DESP_ID = (short)(context.localUtil.CToN( cgiGet( "vPREF_CGRAL_DESP_ID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCREF_CGRAL_DESP_ID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV6cREF_CGRAL_DESP_ID )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCREF_CGRAL_DESP_TIPO"), AV7cREF_CGRAL_DESP_TIPO) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCREF_CGRAL_DESP_ID_TON_TARIF"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV8cREF_CGRAL_DESP_ID_TON_TARIF )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCREF_CGRAL_DESP_TON_TARIF"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV9cREF_CGRAL_DESP_TON_TARIF )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vCREF_CGRAL_DESP_TARIFA"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV10cREF_CGRAL_DESP_TARIFA )
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
         /* Execute user event: E171O2 */
         E171O2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E171O2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( context.GetMessage( "GXSPC_SelectionList", ""), context.GetMessage( "Buques refrigerados, carga general, otros y desplazamiento", ""), "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
         AV12ADVANCED_LABEL_TEMPLATE = context.GetMessage( "%1 <strong>%2</strong>", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12ADVANCED_LABEL_TEMPLATE", AV12ADVANCED_LABEL_TEMPLATE);
      }

      private void E181O2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV15Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))));
         AV15Linkselection_GXI = GeneXus.Utils.GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV15Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))));
         sendrow_642( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ( nGXsfl_64_Refreshing == 0 ) )
         {
            context.DoAjaxLoad(64, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: E191O2 */
         E191O2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E191O2( )
      {
         /* Enter Routine */
         AV11pREF_CGRAL_DESP_ID = A49REF_CGRAL_DESP_ID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pREF_CGRAL_DESP_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pREF_CGRAL_DESP_ID), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV11pREF_CGRAL_DESP_ID});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV11pREF_CGRAL_DESP_ID = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pREF_CGRAL_DESP_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pREF_CGRAL_DESP_ID), 4, 0)));
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
         PA1O2( ) ;
         WS1O2( ) ;
         WE1O2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20151201041419");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages."+context.GetLanguageProperty( "code")+".js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("gx0090.js", "?20151201041419");
         /* End function include_jscripts */
      }

      protected void sendrow_642( )
      {
         sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_64_idx), 4, 0)), 4, "0");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_64_idx;
         edtREF_CGRAL_DESP_ID_Internalname = "REF_CGRAL_DESP_ID_"+sGXsfl_64_idx;
         cmbREF_CGRAL_DESP_TIPO_Internalname = "REF_CGRAL_DESP_TIPO_"+sGXsfl_64_idx;
         edtREF_CGRAL_DESP_ID_TON_TARIF_Internalname = "REF_CGRAL_DESP_ID_TON_TARIF_"+sGXsfl_64_idx;
         WB1O0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_64_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)((nGXsfl_64_idx) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_64_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A49REF_CGRAL_DESP_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")))+"'"+"]);";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV15Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV15Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection)),(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"''",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtREF_CGRAL_DESP_ID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A49REF_CGRAL_DESP_ID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( (decimal)(A49REF_CGRAL_DESP_ID), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtREF_CGRAL_DESP_ID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)64,(short)1,(short)1,(short)0,(bool)true,(String)"",(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            if ( ( nGXsfl_64_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "REF_CGRAL_DESP_TIPO_" + sGXsfl_64_idx;
               cmbREF_CGRAL_DESP_TIPO.Name = GXCCtl;
               cmbREF_CGRAL_DESP_TIPO.WebTags = "";
               cmbREF_CGRAL_DESP_TIPO.addItem("", context.GetMessage( "GX_EmptyItemText", ""), 0);
               cmbREF_CGRAL_DESP_TIPO.addItem("CARGADO", context.GetMessage( "Cargado", ""), 0);
               cmbREF_CGRAL_DESP_TIPO.addItem("EN LASTRE", context.GetMessage( "En Lastre", ""), 0);
               if ( cmbREF_CGRAL_DESP_TIPO.ItemCount > 0 )
               {
                  A45REF_CGRAL_DESP_TIPO = cmbREF_CGRAL_DESP_TIPO.getValidValue(A45REF_CGRAL_DESP_TIPO);
                  n45REF_CGRAL_DESP_TIPO = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbREF_CGRAL_DESP_TIPO_Internalname, A45REF_CGRAL_DESP_TIPO);
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbREF_CGRAL_DESP_TIPO,(String)cmbREF_CGRAL_DESP_TIPO_Internalname,(String)A45REF_CGRAL_DESP_TIPO,(short)1,(String)cmbREF_CGRAL_DESP_TIPO_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn OptionalColumn",(String)"",(String)"",(bool)true});
            cmbREF_CGRAL_DESP_TIPO.CurrentValue = A45REF_CGRAL_DESP_TIPO;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbREF_CGRAL_DESP_TIPO_Internalname, "Values", (String)(cmbREF_CGRAL_DESP_TIPO.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtREF_CGRAL_DESP_ID_TON_TARIF_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A48REF_CGRAL_DESP_ID_TON_TARIF), 4, 0, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( (decimal)(A48REF_CGRAL_DESP_ID_TON_TARIF), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtREF_CGRAL_DESP_ID_TON_TARIF_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)64,(short)1,(short)1,(short)0,(bool)true,(String)"",(String)"right"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_64_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_64_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_64_idx+1));
            sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_64_idx), 4, 0)), 4, "0");
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_64_idx;
            edtREF_CGRAL_DESP_ID_Internalname = "REF_CGRAL_DESP_ID_"+sGXsfl_64_idx;
            cmbREF_CGRAL_DESP_TIPO_Internalname = "REF_CGRAL_DESP_TIPO_"+sGXsfl_64_idx;
            edtREF_CGRAL_DESP_ID_TON_TARIF_Internalname = "REF_CGRAL_DESP_ID_TON_TARIF_"+sGXsfl_64_idx;
         }
         /* End function sendrow_642 */
      }

      protected void init_default_properties( )
      {
         lblLblref_cgral_desp_idfilter_Internalname = "LBLREF_CGRAL_DESP_IDFILTER";
         lblLblref_cgral_desp_idfilter_Internalname = "LBLREF_CGRAL_DESP_IDFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCref_cgral_desp_id_Internalname = "vCREF_CGRAL_DESP_ID";
         edtavCref_cgral_desp_id_Internalname = "vCREF_CGRAL_DESP_ID";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divRef_cgral_desp_idfiltercontainer_Internalname = "REF_CGRAL_DESP_IDFILTERCONTAINER";
         divRef_cgral_desp_idfiltercontainer_Internalname = "REF_CGRAL_DESP_IDFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLblref_cgral_desp_tipofilter_Internalname = "LBLREF_CGRAL_DESP_TIPOFILTER";
         lblLblref_cgral_desp_tipofilter_Internalname = "LBLREF_CGRAL_DESP_TIPOFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         cmbavCref_cgral_desp_tipo_Internalname = "vCREF_CGRAL_DESP_TIPO";
         cmbavCref_cgral_desp_tipo_Internalname = "vCREF_CGRAL_DESP_TIPO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divRef_cgral_desp_tipofiltercontainer_Internalname = "REF_CGRAL_DESP_TIPOFILTERCONTAINER";
         divRef_cgral_desp_tipofiltercontainer_Internalname = "REF_CGRAL_DESP_TIPOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLblref_cgral_desp_id_ton_tariffilter_Internalname = "LBLREF_CGRAL_DESP_ID_TON_TARIFFILTER";
         lblLblref_cgral_desp_id_ton_tariffilter_Internalname = "LBLREF_CGRAL_DESP_ID_TON_TARIFFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCref_cgral_desp_id_ton_tarif_Internalname = "vCREF_CGRAL_DESP_ID_TON_TARIF";
         edtavCref_cgral_desp_id_ton_tarif_Internalname = "vCREF_CGRAL_DESP_ID_TON_TARIF";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divRef_cgral_desp_id_ton_tariffiltercontainer_Internalname = "REF_CGRAL_DESP_ID_TON_TARIFFILTERCONTAINER";
         divRef_cgral_desp_id_ton_tariffiltercontainer_Internalname = "REF_CGRAL_DESP_ID_TON_TARIFFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLblref_cgral_desp_ton_tariffilter_Internalname = "LBLREF_CGRAL_DESP_TON_TARIFFILTER";
         lblLblref_cgral_desp_ton_tariffilter_Internalname = "LBLREF_CGRAL_DESP_TON_TARIFFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCref_cgral_desp_ton_tarif_Internalname = "vCREF_CGRAL_DESP_TON_TARIF";
         edtavCref_cgral_desp_ton_tarif_Internalname = "vCREF_CGRAL_DESP_TON_TARIF";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divRef_cgral_desp_ton_tariffiltercontainer_Internalname = "REF_CGRAL_DESP_TON_TARIFFILTERCONTAINER";
         divRef_cgral_desp_ton_tariffiltercontainer_Internalname = "REF_CGRAL_DESP_TON_TARIFFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLblref_cgral_desp_tarifafilter_Internalname = "LBLREF_CGRAL_DESP_TARIFAFILTER";
         lblLblref_cgral_desp_tarifafilter_Internalname = "LBLREF_CGRAL_DESP_TARIFAFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCref_cgral_desp_tarifa_Internalname = "vCREF_CGRAL_DESP_TARIFA";
         edtavCref_cgral_desp_tarifa_Internalname = "vCREF_CGRAL_DESP_TARIFA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divRef_cgral_desp_tarifafiltercontainer_Internalname = "REF_CGRAL_DESP_TARIFAFILTERCONTAINER";
         divRef_cgral_desp_tarifafiltercontainer_Internalname = "REF_CGRAL_DESP_TARIFAFILTERCONTAINER";
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
         edtREF_CGRAL_DESP_ID_Internalname = "REF_CGRAL_DESP_ID";
         cmbREF_CGRAL_DESP_TIPO_Internalname = "REF_CGRAL_DESP_TIPO";
         edtREF_CGRAL_DESP_ID_TON_TARIF_Internalname = "REF_CGRAL_DESP_ID_TON_TARIF";
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
         edtREF_CGRAL_DESP_ID_TON_TARIF_Jsonclick = "";
         cmbREF_CGRAL_DESP_TIPO_Jsonclick = "";
         edtREF_CGRAL_DESP_ID_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCref_cgral_desp_tarifa_Jsonclick = "";
         edtavCref_cgral_desp_tarifa_Enabled = 1;
         edtavCref_cgral_desp_tarifa_Visible = 1;
         edtavCref_cgral_desp_ton_tarif_Jsonclick = "";
         edtavCref_cgral_desp_ton_tarif_Enabled = 1;
         edtavCref_cgral_desp_ton_tarif_Visible = 1;
         edtavCref_cgral_desp_id_ton_tarif_Jsonclick = "";
         edtavCref_cgral_desp_id_ton_tarif_Enabled = 1;
         edtavCref_cgral_desp_id_ton_tarif_Visible = 1;
         cmbavCref_cgral_desp_tipo_Jsonclick = "";
         cmbavCref_cgral_desp_tipo.Enabled = 1;
         cmbavCref_cgral_desp_tipo.Visible = 1;
         edtavCref_cgral_desp_id_Jsonclick = "";
         edtavCref_cgral_desp_id_Enabled = 1;
         edtavCref_cgral_desp_id_Visible = 1;
         divRef_cgral_desp_tarifafiltercontainer_Class = "AdvancedContainerItem";
         divRef_cgral_desp_ton_tariffiltercontainer_Class = "AdvancedContainerItem";
         divRef_cgral_desp_id_ton_tariffiltercontainer_Class = "AdvancedContainerItem";
         divRef_cgral_desp_tipofiltercontainer_Class = "AdvancedContainerItem";
         divRef_cgral_desp_idfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainer";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = context.GetMessage( "Selection List Buques refrigerados, carga general, otros y desplazamiento", "");
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cREF_CGRAL_DESP_ID',fld:'vCREF_CGRAL_DESP_ID'},{av:'AV7cREF_CGRAL_DESP_TIPO',fld:'vCREF_CGRAL_DESP_TIPO'},{av:'AV8cREF_CGRAL_DESP_ID_TON_TARIF',fld:'vCREF_CGRAL_DESP_ID_TON_TARIF'},{av:'AV9cREF_CGRAL_DESP_TON_TARIF',fld:'vCREF_CGRAL_DESP_TON_TARIF'},{av:'AV10cREF_CGRAL_DESP_TARIFA',fld:'vCREF_CGRAL_DESP_TARIFA'}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E161O1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLREF_CGRAL_DESP_IDFILTER.CLICK","{handler:'E111O1',iparms:[{av:'divRef_cgral_desp_idfiltercontainer_Class',ctrl:'REF_CGRAL_DESP_IDFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divRef_cgral_desp_idfiltercontainer_Class',ctrl:'REF_CGRAL_DESP_IDFILTERCONTAINER',prop:'Class'},{av:'edtavCref_cgral_desp_id_Visible',ctrl:'vCREF_CGRAL_DESP_ID',prop:'Visible'}]}");
         setEventMetadata("LBLREF_CGRAL_DESP_TIPOFILTER.CLICK","{handler:'E121O1',iparms:[{av:'divRef_cgral_desp_tipofiltercontainer_Class',ctrl:'REF_CGRAL_DESP_TIPOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divRef_cgral_desp_tipofiltercontainer_Class',ctrl:'REF_CGRAL_DESP_TIPOFILTERCONTAINER',prop:'Class'},{av:'cmbavCref_cgral_desp_tipo'}]}");
         setEventMetadata("LBLREF_CGRAL_DESP_ID_TON_TARIFFILTER.CLICK","{handler:'E131O1',iparms:[{av:'divRef_cgral_desp_id_ton_tariffiltercontainer_Class',ctrl:'REF_CGRAL_DESP_ID_TON_TARIFFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divRef_cgral_desp_id_ton_tariffiltercontainer_Class',ctrl:'REF_CGRAL_DESP_ID_TON_TARIFFILTERCONTAINER',prop:'Class'},{av:'edtavCref_cgral_desp_id_ton_tarif_Visible',ctrl:'vCREF_CGRAL_DESP_ID_TON_TARIF',prop:'Visible'}]}");
         setEventMetadata("LBLREF_CGRAL_DESP_TON_TARIFFILTER.CLICK","{handler:'E141O1',iparms:[{av:'divRef_cgral_desp_ton_tariffiltercontainer_Class',ctrl:'REF_CGRAL_DESP_TON_TARIFFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divRef_cgral_desp_ton_tariffiltercontainer_Class',ctrl:'REF_CGRAL_DESP_TON_TARIFFILTERCONTAINER',prop:'Class'},{av:'edtavCref_cgral_desp_ton_tarif_Visible',ctrl:'vCREF_CGRAL_DESP_TON_TARIF',prop:'Visible'}]}");
         setEventMetadata("LBLREF_CGRAL_DESP_TARIFAFILTER.CLICK","{handler:'E151O1',iparms:[{av:'divRef_cgral_desp_tarifafiltercontainer_Class',ctrl:'REF_CGRAL_DESP_TARIFAFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divRef_cgral_desp_tarifafiltercontainer_Class',ctrl:'REF_CGRAL_DESP_TARIFAFILTERCONTAINER',prop:'Class'},{av:'edtavCref_cgral_desp_tarifa_Visible',ctrl:'vCREF_CGRAL_DESP_TARIFA',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E191O2',iparms:[{av:'A49REF_CGRAL_DESP_ID',fld:'REF_CGRAL_DESP_ID'}],oparms:[{av:'AV11pREF_CGRAL_DESP_ID',fld:'vPREF_CGRAL_DESP_ID'}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cREF_CGRAL_DESP_ID',fld:'vCREF_CGRAL_DESP_ID'},{av:'AV7cREF_CGRAL_DESP_TIPO',fld:'vCREF_CGRAL_DESP_TIPO'},{av:'AV8cREF_CGRAL_DESP_ID_TON_TARIF',fld:'vCREF_CGRAL_DESP_ID_TON_TARIF'},{av:'AV9cREF_CGRAL_DESP_TON_TARIF',fld:'vCREF_CGRAL_DESP_TON_TARIF'},{av:'AV10cREF_CGRAL_DESP_TARIFA',fld:'vCREF_CGRAL_DESP_TARIFA'}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cREF_CGRAL_DESP_ID',fld:'vCREF_CGRAL_DESP_ID'},{av:'AV7cREF_CGRAL_DESP_TIPO',fld:'vCREF_CGRAL_DESP_TIPO'},{av:'AV8cREF_CGRAL_DESP_ID_TON_TARIF',fld:'vCREF_CGRAL_DESP_ID_TON_TARIF'},{av:'AV9cREF_CGRAL_DESP_TON_TARIF',fld:'vCREF_CGRAL_DESP_TON_TARIF'},{av:'AV10cREF_CGRAL_DESP_TARIFA',fld:'vCREF_CGRAL_DESP_TARIFA'}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cREF_CGRAL_DESP_ID',fld:'vCREF_CGRAL_DESP_ID'},{av:'AV7cREF_CGRAL_DESP_TIPO',fld:'vCREF_CGRAL_DESP_TIPO'},{av:'AV8cREF_CGRAL_DESP_ID_TON_TARIF',fld:'vCREF_CGRAL_DESP_ID_TON_TARIF'},{av:'AV9cREF_CGRAL_DESP_TON_TARIF',fld:'vCREF_CGRAL_DESP_TON_TARIF'},{av:'AV10cREF_CGRAL_DESP_TARIFA',fld:'vCREF_CGRAL_DESP_TARIFA'}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cREF_CGRAL_DESP_ID',fld:'vCREF_CGRAL_DESP_ID'},{av:'AV7cREF_CGRAL_DESP_TIPO',fld:'vCREF_CGRAL_DESP_TIPO'},{av:'AV8cREF_CGRAL_DESP_ID_TON_TARIF',fld:'vCREF_CGRAL_DESP_ID_TON_TARIF'},{av:'AV9cREF_CGRAL_DESP_TON_TARIF',fld:'vCREF_CGRAL_DESP_TON_TARIF'},{av:'AV10cREF_CGRAL_DESP_TARIFA',fld:'vCREF_CGRAL_DESP_TARIFA'}],oparms:[]}");
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
         AV7cREF_CGRAL_DESP_TIPO = "";
         sDynURL = "";
         FormProcess = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblref_cgral_desp_idfilter_Jsonclick = "";
         TempTags = "";
         lblLblref_cgral_desp_tipofilter_Jsonclick = "";
         lblLblref_cgral_desp_id_ton_tariffilter_Jsonclick = "";
         lblLblref_cgral_desp_ton_tariffilter_Jsonclick = "";
         lblLblref_cgral_desp_tarifafilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A45REF_CGRAL_DESP_TIPO = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV15Linkselection_GXI = "";
         GXKey = "";
         GXCCtl = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         scmdbuf = "";
         lV7cREF_CGRAL_DESP_TIPO = "";
         H001O2_A47REF_CGRAL_DESP_TARIFA = new decimal[1] ;
         H001O2_A46REF_CGRAL_DESP_TON_TARIF = new long[1] ;
         H001O2_n46REF_CGRAL_DESP_TON_TARIF = new bool[] {false} ;
         H001O2_A48REF_CGRAL_DESP_ID_TON_TARIF = new short[1] ;
         H001O2_A45REF_CGRAL_DESP_TIPO = new String[] {""} ;
         H001O2_n45REF_CGRAL_DESP_TIPO = new bool[] {false} ;
         H001O2_A49REF_CGRAL_DESP_ID = new short[1] ;
         H001O3_AGRID1_nRecordCount = new long[1] ;
         AV12ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0090__default(),
            new Object[][] {
                new Object[] {
               H001O2_A47REF_CGRAL_DESP_TARIFA, H001O2_A46REF_CGRAL_DESP_TON_TARIF, H001O2_n46REF_CGRAL_DESP_TON_TARIF, H001O2_A48REF_CGRAL_DESP_ID_TON_TARIF, H001O2_A45REF_CGRAL_DESP_TIPO, H001O2_n45REF_CGRAL_DESP_TIPO, H001O2_A49REF_CGRAL_DESP_ID
               }
               , new Object[] {
               H001O3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_64 ;
      private short nGXsfl_64_idx=1 ;
      private short AV6cREF_CGRAL_DESP_ID ;
      private short AV8cREF_CGRAL_DESP_ID_TON_TARIF ;
      private short AV11pREF_CGRAL_DESP_ID ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A49REF_CGRAL_DESP_ID ;
      private short A48REF_CGRAL_DESP_ID_TON_TARIF ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXsfl_64_Refreshing=0 ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int subGrid1_Rows ;
      private int edtavCref_cgral_desp_id_Enabled ;
      private int edtavCref_cgral_desp_id_Visible ;
      private int edtavCref_cgral_desp_id_ton_tarif_Enabled ;
      private int edtavCref_cgral_desp_id_ton_tarif_Visible ;
      private int edtavCref_cgral_desp_ton_tarif_Enabled ;
      private int edtavCref_cgral_desp_ton_tarif_Visible ;
      private int edtavCref_cgral_desp_tarifa_Enabled ;
      private int edtavCref_cgral_desp_tarifa_Visible ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long AV9cREF_CGRAL_DESP_TON_TARIF ;
      private long GRID1_nFirstRecordOnPage ;
      private long GXPagingTo2 ;
      private long A46REF_CGRAL_DESP_TON_TARIF ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private decimal AV10cREF_CGRAL_DESP_TARIFA ;
      private decimal A47REF_CGRAL_DESP_TARIFA ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divRef_cgral_desp_idfiltercontainer_Class ;
      private String divRef_cgral_desp_tipofiltercontainer_Class ;
      private String divRef_cgral_desp_id_ton_tariffiltercontainer_Class ;
      private String divRef_cgral_desp_ton_tariffiltercontainer_Class ;
      private String divRef_cgral_desp_tarifafiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_64_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divRef_cgral_desp_idfiltercontainer_Internalname ;
      private String lblLblref_cgral_desp_idfilter_Internalname ;
      private String lblLblref_cgral_desp_idfilter_Jsonclick ;
      private String TempTags ;
      private String edtavCref_cgral_desp_id_Internalname ;
      private String edtavCref_cgral_desp_id_Jsonclick ;
      private String divRef_cgral_desp_tipofiltercontainer_Internalname ;
      private String lblLblref_cgral_desp_tipofilter_Internalname ;
      private String lblLblref_cgral_desp_tipofilter_Jsonclick ;
      private String cmbavCref_cgral_desp_tipo_Internalname ;
      private String cmbavCref_cgral_desp_tipo_Jsonclick ;
      private String divRef_cgral_desp_id_ton_tariffiltercontainer_Internalname ;
      private String lblLblref_cgral_desp_id_ton_tariffilter_Internalname ;
      private String lblLblref_cgral_desp_id_ton_tariffilter_Jsonclick ;
      private String edtavCref_cgral_desp_id_ton_tarif_Internalname ;
      private String edtavCref_cgral_desp_id_ton_tarif_Jsonclick ;
      private String divRef_cgral_desp_ton_tariffiltercontainer_Internalname ;
      private String lblLblref_cgral_desp_ton_tariffilter_Internalname ;
      private String lblLblref_cgral_desp_ton_tariffilter_Jsonclick ;
      private String edtavCref_cgral_desp_ton_tarif_Internalname ;
      private String edtavCref_cgral_desp_ton_tarif_Jsonclick ;
      private String divRef_cgral_desp_tarifafiltercontainer_Internalname ;
      private String lblLblref_cgral_desp_tarifafilter_Internalname ;
      private String lblLblref_cgral_desp_tarifafilter_Jsonclick ;
      private String edtavCref_cgral_desp_tarifa_Internalname ;
      private String edtavCref_cgral_desp_tarifa_Jsonclick ;
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
      private String edtREF_CGRAL_DESP_ID_Internalname ;
      private String cmbREF_CGRAL_DESP_TIPO_Internalname ;
      private String edtREF_CGRAL_DESP_ID_TON_TARIF_Internalname ;
      private String GXKey ;
      private String GXCCtl ;
      private String scmdbuf ;
      private String AV12ADVANCED_LABEL_TEMPLATE ;
      private String ROClassString ;
      private String edtREF_CGRAL_DESP_ID_Jsonclick ;
      private String cmbREF_CGRAL_DESP_TIPO_Jsonclick ;
      private String edtREF_CGRAL_DESP_ID_TON_TARIF_Jsonclick ;
      private String div_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n45REF_CGRAL_DESP_TIPO ;
      private bool n46REF_CGRAL_DESP_TON_TARIF ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV7cREF_CGRAL_DESP_TIPO ;
      private String A45REF_CGRAL_DESP_TIPO ;
      private String AV15Linkselection_GXI ;
      private String lV7cREF_CGRAL_DESP_TIPO ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavCref_cgral_desp_tipo ;
      private GXCombobox cmbREF_CGRAL_DESP_TIPO ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_default ;
      private decimal[] H001O2_A47REF_CGRAL_DESP_TARIFA ;
      private long[] H001O2_A46REF_CGRAL_DESP_TON_TARIF ;
      private bool[] H001O2_n46REF_CGRAL_DESP_TON_TARIF ;
      private short[] H001O2_A48REF_CGRAL_DESP_ID_TON_TARIF ;
      private String[] H001O2_A45REF_CGRAL_DESP_TIPO ;
      private bool[] H001O2_n45REF_CGRAL_DESP_TIPO ;
      private short[] H001O2_A49REF_CGRAL_DESP_ID ;
      private long[] H001O3_AGRID1_nRecordCount ;
      private short aP0_pREF_CGRAL_DESP_ID ;
      private GXWebForm Form ;
   }

   public class gx0090__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001O2( IGxContext context ,
                                             String AV7cREF_CGRAL_DESP_TIPO ,
                                             short AV8cREF_CGRAL_DESP_ID_TON_TARIF ,
                                             long AV9cREF_CGRAL_DESP_TON_TARIF ,
                                             decimal AV10cREF_CGRAL_DESP_TARIFA ,
                                             String A45REF_CGRAL_DESP_TIPO ,
                                             short A48REF_CGRAL_DESP_ID_TON_TARIF ,
                                             long A46REF_CGRAL_DESP_TON_TARIF ,
                                             decimal A47REF_CGRAL_DESP_TARIFA ,
                                             short AV6cREF_CGRAL_DESP_ID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [10] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [REF_CGRAL_DESP_TARIFA], [REF_CGRAL_DESP_TON_TARIF], [REF_CGRAL_DESP_ID_TON_TARIF], [REF_CGRAL_DESP_TIPO], [REF_CGRAL_DESP_ID]";
         sFromString = " FROM [REF_CGRAL_DESP] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([REF_CGRAL_DESP_ID] >= @AV6cREF_CGRAL_DESP_ID)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cREF_CGRAL_DESP_TIPO)) )
         {
            sWhereString = sWhereString + " and ([REF_CGRAL_DESP_TIPO] like @lV7cREF_CGRAL_DESP_TIPO)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (0==AV8cREF_CGRAL_DESP_ID_TON_TARIF) )
         {
            sWhereString = sWhereString + " and ([REF_CGRAL_DESP_ID_TON_TARIF] >= @AV8cREF_CGRAL_DESP_ID_TON_TARIF)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (0==AV9cREF_CGRAL_DESP_TON_TARIF) )
         {
            sWhereString = sWhereString + " and ([REF_CGRAL_DESP_TON_TARIF] >= @AV9cREF_CGRAL_DESP_TON_TARIF)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV10cREF_CGRAL_DESP_TARIFA) )
         {
            sWhereString = sWhereString + " and ([REF_CGRAL_DESP_TARIFA] >= @AV10cREF_CGRAL_DESP_TARIFA)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [REF_CGRAL_DESP_ID]";
         scmdbuf = "SELECT * FROM (SELECT " + sSelectString + ", ROW_NUMBER() OVER (" + sOrderString + " ) AS GX_ROW_NUMBER" + sFromString + sWhereString + ") AS GX_CTE WHERE GX_ROW_NUMBER" + " BETWEEN " + "@GXPagingFrom2" + " AND " + "@GXPagingTo2" + " OR " + "@GXPagingTo2" + " < " + "@GXPagingFrom2" + " AND GX_ROW_NUMBER >= " + "@GXPagingFrom2";
         scmdbuf = scmdbuf + " OPTION (FAST 11)";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H001O3( IGxContext context ,
                                             String AV7cREF_CGRAL_DESP_TIPO ,
                                             short AV8cREF_CGRAL_DESP_ID_TON_TARIF ,
                                             long AV9cREF_CGRAL_DESP_TON_TARIF ,
                                             decimal AV10cREF_CGRAL_DESP_TARIFA ,
                                             String A45REF_CGRAL_DESP_TIPO ,
                                             short A48REF_CGRAL_DESP_ID_TON_TARIF ,
                                             long A46REF_CGRAL_DESP_TON_TARIF ,
                                             decimal A47REF_CGRAL_DESP_TARIFA ,
                                             short AV6cREF_CGRAL_DESP_ID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [5] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [REF_CGRAL_DESP] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([REF_CGRAL_DESP_ID] >= @AV6cREF_CGRAL_DESP_ID)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cREF_CGRAL_DESP_TIPO)) )
         {
            sWhereString = sWhereString + " and ([REF_CGRAL_DESP_TIPO] like @lV7cREF_CGRAL_DESP_TIPO)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV8cREF_CGRAL_DESP_ID_TON_TARIF) )
         {
            sWhereString = sWhereString + " and ([REF_CGRAL_DESP_ID_TON_TARIF] >= @AV8cREF_CGRAL_DESP_ID_TON_TARIF)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV9cREF_CGRAL_DESP_TON_TARIF) )
         {
            sWhereString = sWhereString + " and ([REF_CGRAL_DESP_TON_TARIF] >= @AV9cREF_CGRAL_DESP_TON_TARIF)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV10cREF_CGRAL_DESP_TARIFA) )
         {
            sWhereString = sWhereString + " and ([REF_CGRAL_DESP_TARIFA] >= @AV10cREF_CGRAL_DESP_TARIFA)";
         }
         else
         {
            GXv_int3[4] = 1;
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
                     return conditional_H001O2(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (long)dynConstraints[2] , (decimal)dynConstraints[3] , (String)dynConstraints[4] , (short)dynConstraints[5] , (long)dynConstraints[6] , (decimal)dynConstraints[7] , (short)dynConstraints[8] );
               case 1 :
                     return conditional_H001O3(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (long)dynConstraints[2] , (decimal)dynConstraints[3] , (String)dynConstraints[4] , (short)dynConstraints[5] , (long)dynConstraints[6] , (decimal)dynConstraints[7] , (short)dynConstraints[8] );
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
          Object[] prmH001O2 ;
          prmH001O2 = new Object[] {
          new Object[] {"@AV6cREF_CGRAL_DESP_ID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV7cREF_CGRAL_DESP_TIPO",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV8cREF_CGRAL_DESP_ID_TON_TARIF",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9cREF_CGRAL_DESP_TON_TARIF",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV10cREF_CGRAL_DESP_TARIFA",SqlDbType.Decimal,10,2} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,6,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Decimal,12,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Decimal,12,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,6,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,6,0}
          } ;
          Object[] prmH001O3 ;
          prmH001O3 = new Object[] {
          new Object[] {"@AV6cREF_CGRAL_DESP_ID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV7cREF_CGRAL_DESP_TIPO",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV8cREF_CGRAL_DESP_ID_TON_TARIF",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9cREF_CGRAL_DESP_TON_TARIF",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV10cREF_CGRAL_DESP_TARIFA",SqlDbType.Decimal,10,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001O2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001O2,11,0,false,false )
             ,new CursorDef("H001O3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001O3,1,0,false,false )
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
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
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
                   stmt.SetParameter(sIdx, (short)parms[10]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[16]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[17]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[18]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[19]);
                }
                break;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[5]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[6]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[7]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[8]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[9]);
                }
                break;
       }
    }

 }

}
