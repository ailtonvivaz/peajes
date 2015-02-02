/*
               File: Gx0021
        Description: Selection List Rango
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 8:5:11.45
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
   public class gx0021 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0021( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public gx0021( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_pTanqueroEsclusasID ,
                           out short aP1_pTanqueroRango )
      {
         this.AV12pTanqueroEsclusasID = aP0_pTanqueroEsclusasID;
         this.AV13pTanqueroRango = 0 ;
         executePrivate();
         aP1_pTanqueroRango=this.AV13pTanqueroRango;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbTanqueroEsclusasID = new GXCombobox();
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
               AV6cTanqueroRango = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTanqueroRango", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cTanqueroRango), 4, 0)));
               AV7cTanqueroTarifaCPSUAB = NumberUtil.Val( GetNextPar( ), ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTanqueroTarifaCPSUAB", StringUtil.LTrim( StringUtil.Str( AV7cTanqueroTarifaCPSUAB, 7, 2)));
               AV8cTanqueroBandaTM = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTanqueroBandaTM", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cTanqueroBandaTM), 12, 0)));
               AV9cTanqueroTarifaTM = NumberUtil.Val( GetNextPar( ), ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTanqueroTarifaTM", StringUtil.LTrim( StringUtil.Str( AV9cTanqueroTarifaTM, 7, 2)));
               AV10cTanqueroTarifaLastre = NumberUtil.Val( GetNextPar( ), ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTanqueroTarifaLastre", StringUtil.LTrim( StringUtil.Str( AV10cTanqueroTarifaLastre, 7, 2)));
               AV11cTanqueroBandaCPSUAB = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTanqueroBandaCPSUAB", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cTanqueroBandaCPSUAB), 10, 0)));
               AV12pTanqueroEsclusasID = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pTanqueroEsclusasID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pTanqueroEsclusasID), 4, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cTanqueroRango, AV7cTanqueroTarifaCPSUAB, AV8cTanqueroBandaTM, AV9cTanqueroTarifaTM, AV10cTanqueroTarifaLastre, AV11cTanqueroBandaCPSUAB, AV12pTanqueroEsclusasID) ;
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
               AV12pTanqueroEsclusasID = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pTanqueroEsclusasID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pTanqueroEsclusasID), 4, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV13pTanqueroRango = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTanqueroRango", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pTanqueroRango), 4, 0)));
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
         PA0X2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0X2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2015120851148");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0021.aspx") + "?" + UrlEncode("" +AV12pTanqueroEsclusasID) + "," + UrlEncode("" +AV13pTanqueroRango)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCTANQUERORANGO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cTanqueroRango), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTANQUEROTARIFACPSUAB", StringUtil.LTrim( StringUtil.NToC( AV7cTanqueroTarifaCPSUAB, 7, 2, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTANQUEROBANDATM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cTanqueroBandaTM), 12, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTANQUEROTARIFATM", StringUtil.LTrim( StringUtil.NToC( AV9cTanqueroTarifaTM, 7, 2, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTANQUEROTARIFALASTRE", StringUtil.LTrim( StringUtil.NToC( AV10cTanqueroTarifaLastre, 7, 2, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTANQUEROBANDACPSUAB", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cTanqueroBandaCPSUAB), 10, 0, context.GetLanguageProperty( "decimal_point"), "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_74", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_74), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "vPTANQUEROESCLUSASID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12pTanqueroEsclusasID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "vPTANQUERORANGO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pTanqueroRango), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "TANQUERORANGOFILTERCONTAINER_Class", StringUtil.RTrim( divTanquerorangofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "TANQUEROTARIFACPSUABFILTERCONTAINER_Class", StringUtil.RTrim( divTanquerotarifacpsuabfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "TANQUEROBANDATMFILTERCONTAINER_Class", StringUtil.RTrim( divTanquerobandatmfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "TANQUEROTARIFATMFILTERCONTAINER_Class", StringUtil.RTrim( divTanquerotarifatmfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "TANQUEROTARIFALASTREFILTERCONTAINER_Class", StringUtil.RTrim( divTanquerotarifalastrefiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "TANQUEROBANDACPSUABFILTERCONTAINER_Class", StringUtil.RTrim( divTanquerobandacpsuabfiltercontainer_Class));
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
            WE0X2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0X2( ) ;
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
         return formatLink("gx0021.aspx") + "?" + UrlEncode("" +AV12pTanqueroEsclusasID) + "," + UrlEncode("" +AV13pTanqueroRango) ;
      }

      public override String GetPgmname( )
      {
         return "gx0021" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "Selection List Rango", "") ;
      }

      protected void WB0X0( )
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
            GxWebStd.gx_div_start( context, divTanquerorangofiltercontainer_Internalname, 1, 0, "px", 0, "px", divTanquerorangofiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbltanquerorangofilter_Internalname, context.GetMessage( "Identificador de rango", ""), "", "", lblLbltanquerorangofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e110x1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0021.htm");
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
            GxWebStd.gx_single_line_edit( context, edtavCtanquerorango_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cTanqueroRango), 4, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCtanquerorango_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cTanqueroRango), "ZZZ9")) : context.localUtil.Format( (decimal)(AV6cTanqueroRango), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCtanquerorango_Jsonclick, 0, "Attribute", "", "", "", edtavCtanquerorango_Visible, edtavCtanquerorango_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx0021.htm");
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
            GxWebStd.gx_div_start( context, divTanquerotarifacpsuabfiltercontainer_Internalname, 1, 0, "px", 0, "px", divTanquerotarifacpsuabfiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbltanquerotarifacpsuabfilter_Internalname, context.GetMessage( "Tarifa CP/SUAB", ""), "", "", lblLbltanquerotarifacpsuabfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e120x1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0021.htm");
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
            GxWebStd.gx_single_line_edit( context, edtavCtanquerotarifacpsuab_Internalname, StringUtil.LTrim( StringUtil.NToC( AV7cTanqueroTarifaCPSUAB, 7, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCtanquerotarifacpsuab_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV7cTanqueroTarifaCPSUAB, "ZZZ9.99")) : context.localUtil.Format( AV7cTanqueroTarifaCPSUAB, "ZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCtanquerotarifacpsuab_Jsonclick, 0, "Attribute", "", "", "", edtavCtanquerotarifacpsuab_Visible, edtavCtanquerotarifacpsuab_Enabled, 0, "text", "", 7, "chr", 1, "row", 7, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx0021.htm");
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
            GxWebStd.gx_div_start( context, divTanquerobandatmfiltercontainer_Internalname, 1, 0, "px", 0, "px", divTanquerobandatmfiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbltanquerobandatmfilter_Internalname, context.GetMessage( "Banda TM", ""), "", "", lblLbltanquerobandatmfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e130x1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0021.htm");
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
            GxWebStd.gx_single_line_edit( context, edtavCtanquerobandatm_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cTanqueroBandaTM), 12, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCtanquerobandatm_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8cTanqueroBandaTM), "ZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV8cTanqueroBandaTM), "ZZZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCtanquerobandatm_Jsonclick, 0, "Attribute", "", "", "", edtavCtanquerobandatm_Visible, edtavCtanquerobandatm_Enabled, 0, "text", "", 12, "chr", 1, "row", 12, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx0021.htm");
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
            GxWebStd.gx_div_start( context, divTanquerotarifatmfiltercontainer_Internalname, 1, 0, "px", 0, "px", divTanquerotarifatmfiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbltanquerotarifatmfilter_Internalname, context.GetMessage( "Tarifa TM", ""), "", "", lblLbltanquerotarifatmfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e140x1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0021.htm");
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
            GxWebStd.gx_single_line_edit( context, edtavCtanquerotarifatm_Internalname, StringUtil.LTrim( StringUtil.NToC( AV9cTanqueroTarifaTM, 7, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCtanquerotarifatm_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV9cTanqueroTarifaTM, "ZZZ9.99")) : context.localUtil.Format( AV9cTanqueroTarifaTM, "ZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCtanquerotarifatm_Jsonclick, 0, "Attribute", "", "", "", edtavCtanquerotarifatm_Visible, edtavCtanquerotarifatm_Enabled, 0, "text", "", 7, "chr", 1, "row", 7, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx0021.htm");
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
            GxWebStd.gx_div_start( context, divTanquerotarifalastrefiltercontainer_Internalname, 1, 0, "px", 0, "px", divTanquerotarifalastrefiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbltanquerotarifalastrefilter_Internalname, context.GetMessage( "Tarifa Lastre", ""), "", "", lblLbltanquerotarifalastrefilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e150x1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0021.htm");
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
            GxWebStd.gx_single_line_edit( context, edtavCtanquerotarifalastre_Internalname, StringUtil.LTrim( StringUtil.NToC( AV10cTanqueroTarifaLastre, 7, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCtanquerotarifalastre_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV10cTanqueroTarifaLastre, "ZZZ9.99")) : context.localUtil.Format( AV10cTanqueroTarifaLastre, "ZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCtanquerotarifalastre_Jsonclick, 0, "Attribute", "", "", "", edtavCtanquerotarifalastre_Visible, edtavCtanquerotarifalastre_Enabled, 0, "text", "", 7, "chr", 1, "row", 7, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx0021.htm");
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
            GxWebStd.gx_div_start( context, divTanquerobandacpsuabfiltercontainer_Internalname, 1, 0, "px", 0, "px", divTanquerobandacpsuabfiltercontainer_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbltanquerobandacpsuabfilter_Internalname, context.GetMessage( "Banda en CP/SUAB", ""), "", "", lblLbltanquerobandacpsuabfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e160x1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0021.htm");
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
            GxWebStd.gx_single_line_edit( context, edtavCtanquerobandacpsuab_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cTanqueroBandaCPSUAB), 10, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCtanquerobandacpsuab_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11cTanqueroBandaCPSUAB), "ZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV11cTanqueroBandaCPSUAB), "ZZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCtanquerobandacpsuab_Jsonclick, 0, "Attribute", "", "", "", edtavCtanquerobandacpsuab_Visible, edtavCtanquerobandacpsuab_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_Gx0021.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e170x1_client"+"'", TempTags, "", 2, "HLP_Gx0021.htm");
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
               context.SendWebValue( context.GetMessage( "Identificador de rango", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tarifa CP/SUAB", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Banda TM", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tarifa TM", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tarifa Lastre", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Banda en CP/SUAB", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Identificador de esclusa", "")) ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3TanqueroRango), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A4TanqueroTarifaCPSUAB, 7, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A5TanqueroBandaTM), 12, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A6TanqueroTarifaTM, 7, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A7TanqueroTarifaLastre, 7, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A8TanqueroBandaCPSUAB), 10, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1TanqueroEsclusasID), 4, 0, ".", "")));
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 2, 0)+","+"null"+");", context.GetMessage( "GX_BtnCancel", ""), bttBtn_cancel_Jsonclick, 1, context.GetMessage( "GX_BtnCancel", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0021.htm");
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

      protected void START0X2( )
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
         STRUP0X0( ) ;
      }

      protected void WS0X2( )
      {
         START0X2( ) ;
         EVT0X2( ) ;
      }

      protected void EVT0X2( )
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
                              edtTanqueroRango_Internalname = "TANQUERORANGO_"+sGXsfl_74_idx;
                              edtTanqueroTarifaCPSUAB_Internalname = "TANQUEROTARIFACPSUAB_"+sGXsfl_74_idx;
                              edtTanqueroBandaTM_Internalname = "TANQUEROBANDATM_"+sGXsfl_74_idx;
                              edtTanqueroTarifaTM_Internalname = "TANQUEROTARIFATM_"+sGXsfl_74_idx;
                              edtTanqueroTarifaLastre_Internalname = "TANQUEROTARIFALASTRE_"+sGXsfl_74_idx;
                              edtTanqueroBandaCPSUAB_Internalname = "TANQUEROBANDACPSUAB_"+sGXsfl_74_idx;
                              cmbTanqueroEsclusasID_Internalname = "TANQUEROESCLUSASID_"+sGXsfl_74_idx;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV17Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))));
                              A3TanqueroRango = (short)(context.localUtil.CToN( cgiGet( edtTanqueroRango_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtTanqueroRango_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A3TanqueroRango), 4, 0)));
                              A4TanqueroTarifaCPSUAB = context.localUtil.CToN( cgiGet( edtTanqueroTarifaCPSUAB_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtTanqueroTarifaCPSUAB_Internalname, StringUtil.LTrim( StringUtil.Str( A4TanqueroTarifaCPSUAB, 7, 2)));
                              A5TanqueroBandaTM = (long)(context.localUtil.CToN( cgiGet( edtTanqueroBandaTM_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtTanqueroBandaTM_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A5TanqueroBandaTM), 12, 0)));
                              A6TanqueroTarifaTM = context.localUtil.CToN( cgiGet( edtTanqueroTarifaTM_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtTanqueroTarifaTM_Internalname, StringUtil.LTrim( StringUtil.Str( A6TanqueroTarifaTM, 7, 2)));
                              A7TanqueroTarifaLastre = context.localUtil.CToN( cgiGet( edtTanqueroTarifaLastre_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtTanqueroTarifaLastre_Internalname, StringUtil.LTrim( StringUtil.Str( A7TanqueroTarifaLastre, 7, 2)));
                              A8TanqueroBandaCPSUAB = (long)(context.localUtil.CToN( cgiGet( edtTanqueroBandaCPSUAB_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtTanqueroBandaCPSUAB_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A8TanqueroBandaCPSUAB), 10, 0)));
                              cmbTanqueroEsclusasID.Name = cmbTanqueroEsclusasID_Internalname;
                              cmbTanqueroEsclusasID.CurrentValue = cgiGet( cmbTanqueroEsclusasID_Internalname);
                              A1TanqueroEsclusasID = (short)(NumberUtil.Val( cgiGet( cmbTanqueroEsclusasID_Internalname), "."));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbTanqueroEsclusasID_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A1TanqueroEsclusasID), 4, 0)));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E180X2 */
                                    E180X2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: E190X2 */
                                    E190X2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Ctanquerorango Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTANQUERORANGO"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV6cTanqueroRango )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ctanquerotarifacpsuab Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCTANQUEROTARIFACPSUAB"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV7cTanqueroTarifaCPSUAB )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ctanquerobandatm Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTANQUEROBANDATM"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV8cTanqueroBandaTM )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ctanquerotarifatm Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCTANQUEROTARIFATM"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV9cTanqueroTarifaTM )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ctanquerotarifalastre Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCTANQUEROTARIFALASTRE"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV10cTanqueroTarifaLastre )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ctanquerobandacpsuab Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTANQUEROBANDACPSUAB"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV11cTanqueroBandaCPSUAB )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E200X2 */
                                          E200X2 ();
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

      protected void WE0X2( )
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

      protected void PA0X2( )
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
            GXCCtl = "TANQUEROESCLUSASID_" + sGXsfl_74_idx;
            cmbTanqueroEsclusasID.Name = GXCCtl;
            cmbTanqueroEsclusasID.WebTags = "";
            cmbTanqueroEsclusasID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), context.GetMessage( "GX_EmptyItemText", ""), 0);
            cmbTanqueroEsclusasID.addItem("1", context.GetMessage( "Panamax", ""), 0);
            cmbTanqueroEsclusasID.addItem("2", context.GetMessage( "Neopanamax", ""), 0);
            if ( cmbTanqueroEsclusasID.ItemCount > 0 )
            {
               A1TanqueroEsclusasID = (short)(NumberUtil.Val( cmbTanqueroEsclusasID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A1TanqueroEsclusasID), 4, 0))), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbTanqueroEsclusasID_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A1TanqueroEsclusasID), 4, 0)));
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
         edtTanqueroRango_Internalname = "TANQUERORANGO_"+sGXsfl_74_idx;
         edtTanqueroTarifaCPSUAB_Internalname = "TANQUEROTARIFACPSUAB_"+sGXsfl_74_idx;
         edtTanqueroBandaTM_Internalname = "TANQUEROBANDATM_"+sGXsfl_74_idx;
         edtTanqueroTarifaTM_Internalname = "TANQUEROTARIFATM_"+sGXsfl_74_idx;
         edtTanqueroTarifaLastre_Internalname = "TANQUEROTARIFALASTRE_"+sGXsfl_74_idx;
         edtTanqueroBandaCPSUAB_Internalname = "TANQUEROBANDACPSUAB_"+sGXsfl_74_idx;
         cmbTanqueroEsclusasID_Internalname = "TANQUEROESCLUSASID_"+sGXsfl_74_idx;
         while ( nGXsfl_74_idx <= nRC_GXsfl_74 )
         {
            sendrow_742( ) ;
            nGXsfl_74_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1));
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
            edtTanqueroRango_Internalname = "TANQUERORANGO_"+sGXsfl_74_idx;
            edtTanqueroTarifaCPSUAB_Internalname = "TANQUEROTARIFACPSUAB_"+sGXsfl_74_idx;
            edtTanqueroBandaTM_Internalname = "TANQUEROBANDATM_"+sGXsfl_74_idx;
            edtTanqueroTarifaTM_Internalname = "TANQUEROTARIFATM_"+sGXsfl_74_idx;
            edtTanqueroTarifaLastre_Internalname = "TANQUEROTARIFALASTRE_"+sGXsfl_74_idx;
            edtTanqueroBandaCPSUAB_Internalname = "TANQUEROBANDACPSUAB_"+sGXsfl_74_idx;
            cmbTanqueroEsclusasID_Internalname = "TANQUEROESCLUSASID_"+sGXsfl_74_idx;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        short AV6cTanqueroRango ,
                                        decimal AV7cTanqueroTarifaCPSUAB ,
                                        long AV8cTanqueroBandaTM ,
                                        decimal AV9cTanqueroTarifaTM ,
                                        decimal AV10cTanqueroTarifaLastre ,
                                        long AV11cTanqueroBandaCPSUAB ,
                                        short AV12pTanqueroEsclusasID )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         GXCCtl = "TANQUEROESCLUSASID_" + sGXsfl_74_idx;
         cmbTanqueroEsclusasID.Name = GXCCtl;
         cmbTanqueroEsclusasID.WebTags = "";
         cmbTanqueroEsclusasID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), context.GetMessage( "GX_EmptyItemText", ""), 0);
         cmbTanqueroEsclusasID.addItem("1", context.GetMessage( "Panamax", ""), 0);
         cmbTanqueroEsclusasID.addItem("2", context.GetMessage( "Neopanamax", ""), 0);
         if ( cmbTanqueroEsclusasID.ItemCount > 0 )
         {
            A1TanqueroEsclusasID = (short)(NumberUtil.Val( cmbTanqueroEsclusasID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A1TanqueroEsclusasID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbTanqueroEsclusasID_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A1TanqueroEsclusasID), 4, 0)));
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID1_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Rows), 6, 0, ".", "")));
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         RF0X2( ) ;
         context.GX_msglist = BackMsgLst;
         /* End function gxgrGrid1_refresh */
      }

      public void Refresh( )
      {
         RF0X2( ) ;
      }

      protected void RF0X2( )
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
         edtTanqueroRango_Internalname = "TANQUERORANGO_"+sGXsfl_74_idx;
         edtTanqueroTarifaCPSUAB_Internalname = "TANQUEROTARIFACPSUAB_"+sGXsfl_74_idx;
         edtTanqueroBandaTM_Internalname = "TANQUEROBANDATM_"+sGXsfl_74_idx;
         edtTanqueroTarifaTM_Internalname = "TANQUEROTARIFATM_"+sGXsfl_74_idx;
         edtTanqueroTarifaLastre_Internalname = "TANQUEROTARIFALASTRE_"+sGXsfl_74_idx;
         edtTanqueroBandaCPSUAB_Internalname = "TANQUEROBANDACPSUAB_"+sGXsfl_74_idx;
         cmbTanqueroEsclusasID_Internalname = "TANQUEROESCLUSASID_"+sGXsfl_74_idx;
         nGXsfl_74_Refreshing = 1;
         Grid1Container.PageSize = subGrid1_Recordsperpage( );
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
            edtTanqueroRango_Internalname = "TANQUERORANGO_"+sGXsfl_74_idx;
            edtTanqueroTarifaCPSUAB_Internalname = "TANQUEROTARIFACPSUAB_"+sGXsfl_74_idx;
            edtTanqueroBandaTM_Internalname = "TANQUEROBANDATM_"+sGXsfl_74_idx;
            edtTanqueroTarifaTM_Internalname = "TANQUEROTARIFATM_"+sGXsfl_74_idx;
            edtTanqueroTarifaLastre_Internalname = "TANQUEROTARIFALASTRE_"+sGXsfl_74_idx;
            edtTanqueroBandaCPSUAB_Internalname = "TANQUEROBANDACPSUAB_"+sGXsfl_74_idx;
            cmbTanqueroEsclusasID_Internalname = "TANQUEROESCLUSASID_"+sGXsfl_74_idx;
            GXPagingFrom2 = (int)(((10==0) ? 1 : GRID1_nFirstRecordOnPage+1));
            GXPagingTo2 = ((10==0) ? 10000 : GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7cTanqueroTarifaCPSUAB ,
                                                 AV8cTanqueroBandaTM ,
                                                 AV9cTanqueroTarifaTM ,
                                                 AV10cTanqueroTarifaLastre ,
                                                 AV11cTanqueroBandaCPSUAB ,
                                                 A4TanqueroTarifaCPSUAB ,
                                                 A5TanqueroBandaTM ,
                                                 A6TanqueroTarifaTM ,
                                                 A7TanqueroTarifaLastre ,
                                                 A8TanqueroBandaCPSUAB ,
                                                 AV12pTanqueroEsclusasID ,
                                                 AV6cTanqueroRango ,
                                                 A1TanqueroEsclusasID },
                                                 new int[] {
                                                 TypeConstants.DECIMAL, TypeConstants.LONG, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.LONG, TypeConstants.DECIMAL, TypeConstants.LONG, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.LONG,
                                                 TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT
                                                 }
            });
            /* Using cursor H000X2 */
            pr_default.execute(0, new Object[] {AV12pTanqueroEsclusasID, AV6cTanqueroRango, AV7cTanqueroTarifaCPSUAB, AV8cTanqueroBandaTM, AV9cTanqueroTarifaTM, AV10cTanqueroTarifaLastre, AV11cTanqueroBandaCPSUAB, GXPagingFrom2, GXPagingTo2, GXPagingTo2, GXPagingFrom2, GXPagingFrom2});
            nGXsfl_74_idx = 1;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < subGrid1_Recordsperpage( ) ) ) ) )
            {
               A1TanqueroEsclusasID = H000X2_A1TanqueroEsclusasID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbTanqueroEsclusasID_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A1TanqueroEsclusasID), 4, 0)));
               A8TanqueroBandaCPSUAB = H000X2_A8TanqueroBandaCPSUAB[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtTanqueroBandaCPSUAB_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A8TanqueroBandaCPSUAB), 10, 0)));
               A7TanqueroTarifaLastre = H000X2_A7TanqueroTarifaLastre[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtTanqueroTarifaLastre_Internalname, StringUtil.LTrim( StringUtil.Str( A7TanqueroTarifaLastre, 7, 2)));
               A6TanqueroTarifaTM = H000X2_A6TanqueroTarifaTM[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtTanqueroTarifaTM_Internalname, StringUtil.LTrim( StringUtil.Str( A6TanqueroTarifaTM, 7, 2)));
               A5TanqueroBandaTM = H000X2_A5TanqueroBandaTM[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtTanqueroBandaTM_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A5TanqueroBandaTM), 12, 0)));
               A4TanqueroTarifaCPSUAB = H000X2_A4TanqueroTarifaCPSUAB[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtTanqueroTarifaCPSUAB_Internalname, StringUtil.LTrim( StringUtil.Str( A4TanqueroTarifaCPSUAB, 7, 2)));
               A3TanqueroRango = H000X2_A3TanqueroRango[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtTanqueroRango_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A3TanqueroRango), 4, 0)));
               /* Execute user event: E190X2 */
               E190X2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 74;
            WB0X0( ) ;
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
                                              AV7cTanqueroTarifaCPSUAB ,
                                              AV8cTanqueroBandaTM ,
                                              AV9cTanqueroTarifaTM ,
                                              AV10cTanqueroTarifaLastre ,
                                              AV11cTanqueroBandaCPSUAB ,
                                              A4TanqueroTarifaCPSUAB ,
                                              A5TanqueroBandaTM ,
                                              A6TanqueroTarifaTM ,
                                              A7TanqueroTarifaLastre ,
                                              A8TanqueroBandaCPSUAB ,
                                              AV12pTanqueroEsclusasID ,
                                              AV6cTanqueroRango ,
                                              A1TanqueroEsclusasID },
                                              new int[] {
                                              TypeConstants.DECIMAL, TypeConstants.LONG, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.LONG, TypeConstants.DECIMAL, TypeConstants.LONG, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.LONG,
                                              TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         });
         /* Using cursor H000X3 */
         pr_default.execute(1, new Object[] {AV12pTanqueroEsclusasID, AV6cTanqueroRango, AV7cTanqueroTarifaCPSUAB, AV8cTanqueroBandaTM, AV9cTanqueroTarifaTM, AV10cTanqueroTarifaLastre, AV11cTanqueroBandaCPSUAB});
         GRID1_nRecordCount = H000X3_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cTanqueroRango, AV7cTanqueroTarifaCPSUAB, AV8cTanqueroBandaTM, AV9cTanqueroTarifaTM, AV10cTanqueroTarifaLastre, AV11cTanqueroBandaCPSUAB, AV12pTanqueroEsclusasID) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cTanqueroRango, AV7cTanqueroTarifaCPSUAB, AV8cTanqueroBandaTM, AV9cTanqueroTarifaTM, AV10cTanqueroTarifaLastre, AV11cTanqueroBandaCPSUAB, AV12pTanqueroEsclusasID) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cTanqueroRango, AV7cTanqueroTarifaCPSUAB, AV8cTanqueroBandaTM, AV9cTanqueroTarifaTM, AV10cTanqueroTarifaLastre, AV11cTanqueroBandaCPSUAB, AV12pTanqueroEsclusasID) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cTanqueroRango, AV7cTanqueroTarifaCPSUAB, AV8cTanqueroBandaTM, AV9cTanqueroTarifaTM, AV10cTanqueroTarifaLastre, AV11cTanqueroBandaCPSUAB, AV12pTanqueroEsclusasID) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cTanqueroRango, AV7cTanqueroTarifaCPSUAB, AV8cTanqueroBandaTM, AV9cTanqueroTarifaTM, AV10cTanqueroTarifaLastre, AV11cTanqueroBandaCPSUAB, AV12pTanqueroEsclusasID) ;
         }
         return (int)(0) ;
      }

      protected void STRUP0X0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E180X2 */
         E180X2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCtanquerorango_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCtanquerorango_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCTANQUERORANGO");
               GX_FocusControl = edtavCtanquerorango_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cTanqueroRango = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTanqueroRango", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cTanqueroRango), 4, 0)));
            }
            else
            {
               AV6cTanqueroRango = (short)(context.localUtil.CToN( cgiGet( edtavCtanquerorango_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cTanqueroRango", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cTanqueroRango), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCtanquerotarifacpsuab_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCtanquerotarifacpsuab_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 9999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCTANQUEROTARIFACPSUAB");
               GX_FocusControl = edtavCtanquerotarifacpsuab_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7cTanqueroTarifaCPSUAB = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTanqueroTarifaCPSUAB", StringUtil.LTrim( StringUtil.Str( AV7cTanqueroTarifaCPSUAB, 7, 2)));
            }
            else
            {
               AV7cTanqueroTarifaCPSUAB = context.localUtil.CToN( cgiGet( edtavCtanquerotarifacpsuab_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTanqueroTarifaCPSUAB", StringUtil.LTrim( StringUtil.Str( AV7cTanqueroTarifaCPSUAB, 7, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCtanquerobandatm_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCtanquerobandatm_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCTANQUEROBANDATM");
               GX_FocusControl = edtavCtanquerobandatm_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8cTanqueroBandaTM = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTanqueroBandaTM", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cTanqueroBandaTM), 12, 0)));
            }
            else
            {
               AV8cTanqueroBandaTM = (long)(context.localUtil.CToN( cgiGet( edtavCtanquerobandatm_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTanqueroBandaTM", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cTanqueroBandaTM), 12, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCtanquerotarifatm_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCtanquerotarifatm_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 9999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCTANQUEROTARIFATM");
               GX_FocusControl = edtavCtanquerotarifatm_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9cTanqueroTarifaTM = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTanqueroTarifaTM", StringUtil.LTrim( StringUtil.Str( AV9cTanqueroTarifaTM, 7, 2)));
            }
            else
            {
               AV9cTanqueroTarifaTM = context.localUtil.CToN( cgiGet( edtavCtanquerotarifatm_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTanqueroTarifaTM", StringUtil.LTrim( StringUtil.Str( AV9cTanqueroTarifaTM, 7, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCtanquerotarifalastre_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCtanquerotarifalastre_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 9999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCTANQUEROTARIFALASTRE");
               GX_FocusControl = edtavCtanquerotarifalastre_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10cTanqueroTarifaLastre = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTanqueroTarifaLastre", StringUtil.LTrim( StringUtil.Str( AV10cTanqueroTarifaLastre, 7, 2)));
            }
            else
            {
               AV10cTanqueroTarifaLastre = context.localUtil.CToN( cgiGet( edtavCtanquerotarifalastre_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTanqueroTarifaLastre", StringUtil.LTrim( StringUtil.Str( AV10cTanqueroTarifaLastre, 7, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCtanquerobandacpsuab_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCtanquerobandacpsuab_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCTANQUEROBANDACPSUAB");
               GX_FocusControl = edtavCtanquerobandacpsuab_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11cTanqueroBandaCPSUAB = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTanqueroBandaCPSUAB", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cTanqueroBandaCPSUAB), 10, 0)));
            }
            else
            {
               AV11cTanqueroBandaCPSUAB = (long)(context.localUtil.CToN( cgiGet( edtavCtanquerobandacpsuab_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTanqueroBandaCPSUAB", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cTanqueroBandaCPSUAB), 10, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_74 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_74"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            AV12pTanqueroEsclusasID = (short)(context.localUtil.CToN( cgiGet( "vPTANQUEROESCLUSASID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            AV13pTanqueroRango = (short)(context.localUtil.CToN( cgiGet( "vPTANQUERORANGO"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTANQUERORANGO"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV6cTanqueroRango )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vCTANQUEROTARIFACPSUAB"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV7cTanqueroTarifaCPSUAB )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTANQUEROBANDATM"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV8cTanqueroBandaTM )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vCTANQUEROTARIFATM"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV9cTanqueroTarifaTM )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vCTANQUEROTARIFALASTRE"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != AV10cTanqueroTarifaLastre )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTANQUEROBANDACPSUAB"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) != Convert.ToDecimal( AV11cTanqueroBandaCPSUAB )) )
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
         /* Execute user event: E180X2 */
         E180X2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E180X2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( context.GetMessage( "GXSPC_SelectionList", ""), context.GetMessage( "Rango", ""), "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
         AV14ADVANCED_LABEL_TEMPLATE = context.GetMessage( "%1 <strong>%2</strong>", "");
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ADVANCED_LABEL_TEMPLATE", AV14ADVANCED_LABEL_TEMPLATE);
      }

      private void E190X2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV17Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))));
         AV17Linkselection_GXI = GeneXus.Utils.GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV17Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))));
         sendrow_742( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ( nGXsfl_74_Refreshing == 0 ) )
         {
            context.DoAjaxLoad(74, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: E200X2 */
         E200X2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E200X2( )
      {
         /* Enter Routine */
         AV13pTanqueroRango = A3TanqueroRango;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTanqueroRango", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pTanqueroRango), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV13pTanqueroRango});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12pTanqueroEsclusasID = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pTanqueroEsclusasID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pTanqueroEsclusasID), 4, 0)));
         AV13pTanqueroRango = Convert.ToInt16(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTanqueroRango", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pTanqueroRango), 4, 0)));
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
         PA0X2( ) ;
         WS0X2( ) ;
         WE0X2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?85166");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2015120851223");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages."+context.GetLanguageProperty( "code")+".js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("gx0021.js", "?2015120851223");
         /* End function include_jscripts */
      }

      protected void sendrow_742( )
      {
         sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
         edtTanqueroRango_Internalname = "TANQUERORANGO_"+sGXsfl_74_idx;
         edtTanqueroTarifaCPSUAB_Internalname = "TANQUEROTARIFACPSUAB_"+sGXsfl_74_idx;
         edtTanqueroBandaTM_Internalname = "TANQUEROBANDATM_"+sGXsfl_74_idx;
         edtTanqueroTarifaTM_Internalname = "TANQUEROTARIFATM_"+sGXsfl_74_idx;
         edtTanqueroTarifaLastre_Internalname = "TANQUEROTARIFALASTRE_"+sGXsfl_74_idx;
         edtTanqueroBandaCPSUAB_Internalname = "TANQUEROBANDACPSUAB_"+sGXsfl_74_idx;
         cmbTanqueroEsclusasID_Internalname = "TANQUEROESCLUSASID_"+sGXsfl_74_idx;
         WB0X0( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A3TanqueroRango), 4, 0, context.GetLanguageProperty( "decimal_point"), "")))+"'"+"]);";
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTanqueroRango_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A3TanqueroRango), 4, 0, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( (decimal)(A3TanqueroRango), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTanqueroRango_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)1,(short)0,(bool)true,(String)"",(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTanqueroTarifaCPSUAB_Internalname,StringUtil.LTrim( StringUtil.NToC( A4TanqueroTarifaCPSUAB, 7, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A4TanqueroTarifaCPSUAB, "ZZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTanqueroTarifaCPSUAB_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)7,(short)0,(short)0,(short)74,(short)1,(short)1,(short)0,(bool)true,(String)"DominioTarifa",(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTanqueroBandaTM_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A5TanqueroBandaTM), 12, 0, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( (decimal)(A5TanqueroBandaTM), "ZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTanqueroBandaTM_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)12,(short)0,(short)0,(short)74,(short)1,(short)1,(short)0,(bool)true,(String)"",(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTanqueroTarifaTM_Internalname,StringUtil.LTrim( StringUtil.NToC( A6TanqueroTarifaTM, 7, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A6TanqueroTarifaTM, "ZZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTanqueroTarifaTM_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)7,(short)0,(short)0,(short)74,(short)1,(short)1,(short)0,(bool)true,(String)"DominioTarifa",(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTanqueroTarifaLastre_Internalname,StringUtil.LTrim( StringUtil.NToC( A7TanqueroTarifaLastre, 7, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A7TanqueroTarifaLastre, "ZZZ9.99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTanqueroTarifaLastre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)7,(short)0,(short)0,(short)74,(short)1,(short)1,(short)0,(bool)true,(String)"DominioTarifa",(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTanqueroBandaCPSUAB_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A8TanqueroBandaCPSUAB), 10, 0, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( (decimal)(A8TanqueroBandaCPSUAB), "ZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTanqueroBandaCPSUAB_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)74,(short)1,(short)1,(short)0,(bool)true,(String)"",(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            if ( ( nGXsfl_74_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "TANQUEROESCLUSASID_" + sGXsfl_74_idx;
               cmbTanqueroEsclusasID.Name = GXCCtl;
               cmbTanqueroEsclusasID.WebTags = "";
               cmbTanqueroEsclusasID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), context.GetMessage( "GX_EmptyItemText", ""), 0);
               cmbTanqueroEsclusasID.addItem("1", context.GetMessage( "Panamax", ""), 0);
               cmbTanqueroEsclusasID.addItem("2", context.GetMessage( "Neopanamax", ""), 0);
               if ( cmbTanqueroEsclusasID.ItemCount > 0 )
               {
                  A1TanqueroEsclusasID = (short)(NumberUtil.Val( cmbTanqueroEsclusasID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A1TanqueroEsclusasID), 4, 0))), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, cmbTanqueroEsclusasID_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A1TanqueroEsclusasID), 4, 0)));
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbTanqueroEsclusasID,(String)cmbTanqueroEsclusasID_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A1TanqueroEsclusasID), 4, 0)),(short)1,(String)cmbTanqueroEsclusasID_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)0,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"",(String)"",(String)"",(bool)true});
            cmbTanqueroEsclusasID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A1TanqueroEsclusasID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTanqueroEsclusasID_Internalname, "Values", (String)(cmbTanqueroEsclusasID.ToJavascriptSource()));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_74_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1));
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0");
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_74_idx;
            edtTanqueroRango_Internalname = "TANQUERORANGO_"+sGXsfl_74_idx;
            edtTanqueroTarifaCPSUAB_Internalname = "TANQUEROTARIFACPSUAB_"+sGXsfl_74_idx;
            edtTanqueroBandaTM_Internalname = "TANQUEROBANDATM_"+sGXsfl_74_idx;
            edtTanqueroTarifaTM_Internalname = "TANQUEROTARIFATM_"+sGXsfl_74_idx;
            edtTanqueroTarifaLastre_Internalname = "TANQUEROTARIFALASTRE_"+sGXsfl_74_idx;
            edtTanqueroBandaCPSUAB_Internalname = "TANQUEROBANDACPSUAB_"+sGXsfl_74_idx;
            cmbTanqueroEsclusasID_Internalname = "TANQUEROESCLUSASID_"+sGXsfl_74_idx;
         }
         /* End function sendrow_742 */
      }

      protected void init_default_properties( )
      {
         lblLbltanquerorangofilter_Internalname = "LBLTANQUERORANGOFILTER";
         lblLbltanquerorangofilter_Internalname = "LBLTANQUERORANGOFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCtanquerorango_Internalname = "vCTANQUERORANGO";
         edtavCtanquerorango_Internalname = "vCTANQUERORANGO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divTanquerorangofiltercontainer_Internalname = "TANQUERORANGOFILTERCONTAINER";
         divTanquerorangofiltercontainer_Internalname = "TANQUERORANGOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLbltanquerotarifacpsuabfilter_Internalname = "LBLTANQUEROTARIFACPSUABFILTER";
         lblLbltanquerotarifacpsuabfilter_Internalname = "LBLTANQUEROTARIFACPSUABFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCtanquerotarifacpsuab_Internalname = "vCTANQUEROTARIFACPSUAB";
         edtavCtanquerotarifacpsuab_Internalname = "vCTANQUEROTARIFACPSUAB";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divTanquerotarifacpsuabfiltercontainer_Internalname = "TANQUEROTARIFACPSUABFILTERCONTAINER";
         divTanquerotarifacpsuabfiltercontainer_Internalname = "TANQUEROTARIFACPSUABFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLbltanquerobandatmfilter_Internalname = "LBLTANQUEROBANDATMFILTER";
         lblLbltanquerobandatmfilter_Internalname = "LBLTANQUEROBANDATMFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCtanquerobandatm_Internalname = "vCTANQUEROBANDATM";
         edtavCtanquerobandatm_Internalname = "vCTANQUEROBANDATM";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divTanquerobandatmfiltercontainer_Internalname = "TANQUEROBANDATMFILTERCONTAINER";
         divTanquerobandatmfiltercontainer_Internalname = "TANQUEROBANDATMFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLbltanquerotarifatmfilter_Internalname = "LBLTANQUEROTARIFATMFILTER";
         lblLbltanquerotarifatmfilter_Internalname = "LBLTANQUEROTARIFATMFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCtanquerotarifatm_Internalname = "vCTANQUEROTARIFATM";
         edtavCtanquerotarifatm_Internalname = "vCTANQUEROTARIFATM";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divTanquerotarifatmfiltercontainer_Internalname = "TANQUEROTARIFATMFILTERCONTAINER";
         divTanquerotarifatmfiltercontainer_Internalname = "TANQUEROTARIFATMFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLbltanquerotarifalastrefilter_Internalname = "LBLTANQUEROTARIFALASTREFILTER";
         lblLbltanquerotarifalastrefilter_Internalname = "LBLTANQUEROTARIFALASTREFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCtanquerotarifalastre_Internalname = "vCTANQUEROTARIFALASTRE";
         edtavCtanquerotarifalastre_Internalname = "vCTANQUEROTARIFALASTRE";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divTanquerotarifalastrefiltercontainer_Internalname = "TANQUEROTARIFALASTREFILTERCONTAINER";
         divTanquerotarifalastrefiltercontainer_Internalname = "TANQUEROTARIFALASTREFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLbltanquerobandacpsuabfilter_Internalname = "LBLTANQUEROBANDACPSUABFILTER";
         lblLbltanquerobandacpsuabfilter_Internalname = "LBLTANQUEROBANDACPSUABFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavCtanquerobandacpsuab_Internalname = "vCTANQUEROBANDACPSUAB";
         edtavCtanquerobandacpsuab_Internalname = "vCTANQUEROBANDACPSUAB";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divTanquerobandacpsuabfiltercontainer_Internalname = "TANQUEROBANDACPSUABFILTERCONTAINER";
         divTanquerobandacpsuabfiltercontainer_Internalname = "TANQUEROBANDACPSUABFILTERCONTAINER";
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
         edtTanqueroRango_Internalname = "TANQUERORANGO";
         edtTanqueroTarifaCPSUAB_Internalname = "TANQUEROTARIFACPSUAB";
         edtTanqueroBandaTM_Internalname = "TANQUEROBANDATM";
         edtTanqueroTarifaTM_Internalname = "TANQUEROTARIFATM";
         edtTanqueroTarifaLastre_Internalname = "TANQUEROTARIFALASTRE";
         edtTanqueroBandaCPSUAB_Internalname = "TANQUEROBANDACPSUAB";
         cmbTanqueroEsclusasID_Internalname = "TANQUEROESCLUSASID";
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
         cmbTanqueroEsclusasID_Jsonclick = "";
         edtTanqueroBandaCPSUAB_Jsonclick = "";
         edtTanqueroTarifaLastre_Jsonclick = "";
         edtTanqueroTarifaTM_Jsonclick = "";
         edtTanqueroBandaTM_Jsonclick = "";
         edtTanqueroTarifaCPSUAB_Jsonclick = "";
         edtTanqueroRango_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtavLinkselection_Link = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavCtanquerobandacpsuab_Jsonclick = "";
         edtavCtanquerobandacpsuab_Enabled = 1;
         edtavCtanquerobandacpsuab_Visible = 1;
         edtavCtanquerotarifalastre_Jsonclick = "";
         edtavCtanquerotarifalastre_Enabled = 1;
         edtavCtanquerotarifalastre_Visible = 1;
         edtavCtanquerotarifatm_Jsonclick = "";
         edtavCtanquerotarifatm_Enabled = 1;
         edtavCtanquerotarifatm_Visible = 1;
         edtavCtanquerobandatm_Jsonclick = "";
         edtavCtanquerobandatm_Enabled = 1;
         edtavCtanquerobandatm_Visible = 1;
         edtavCtanquerotarifacpsuab_Jsonclick = "";
         edtavCtanquerotarifacpsuab_Enabled = 1;
         edtavCtanquerotarifacpsuab_Visible = 1;
         edtavCtanquerorango_Jsonclick = "";
         edtavCtanquerorango_Enabled = 1;
         edtavCtanquerorango_Visible = 1;
         divTanquerobandacpsuabfiltercontainer_Class = "AdvancedContainerItem";
         divTanquerotarifalastrefiltercontainer_Class = "AdvancedContainerItem";
         divTanquerotarifatmfiltercontainer_Class = "AdvancedContainerItem";
         divTanquerobandatmfiltercontainer_Class = "AdvancedContainerItem";
         divTanquerotarifacpsuabfiltercontainer_Class = "AdvancedContainerItem";
         divTanquerorangofiltercontainer_Class = "AdvancedContainerItem";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cTanqueroRango',fld:'vCTANQUERORANGO'},{av:'AV7cTanqueroTarifaCPSUAB',fld:'vCTANQUEROTARIFACPSUAB'},{av:'AV8cTanqueroBandaTM',fld:'vCTANQUEROBANDATM'},{av:'AV9cTanqueroTarifaTM',fld:'vCTANQUEROTARIFATM'},{av:'AV10cTanqueroTarifaLastre',fld:'vCTANQUEROTARIFALASTRE'},{av:'AV11cTanqueroBandaCPSUAB',fld:'vCTANQUEROBANDACPSUAB'},{av:'AV12pTanqueroEsclusasID',fld:'vPTANQUEROESCLUSASID'}],oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E170X1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLTANQUERORANGOFILTER.CLICK","{handler:'E110X1',iparms:[{av:'divTanquerorangofiltercontainer_Class',ctrl:'TANQUERORANGOFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divTanquerorangofiltercontainer_Class',ctrl:'TANQUERORANGOFILTERCONTAINER',prop:'Class'},{av:'edtavCtanquerorango_Visible',ctrl:'vCTANQUERORANGO',prop:'Visible'}]}");
         setEventMetadata("LBLTANQUEROTARIFACPSUABFILTER.CLICK","{handler:'E120X1',iparms:[{av:'divTanquerotarifacpsuabfiltercontainer_Class',ctrl:'TANQUEROTARIFACPSUABFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divTanquerotarifacpsuabfiltercontainer_Class',ctrl:'TANQUEROTARIFACPSUABFILTERCONTAINER',prop:'Class'},{av:'edtavCtanquerotarifacpsuab_Visible',ctrl:'vCTANQUEROTARIFACPSUAB',prop:'Visible'}]}");
         setEventMetadata("LBLTANQUEROBANDATMFILTER.CLICK","{handler:'E130X1',iparms:[{av:'divTanquerobandatmfiltercontainer_Class',ctrl:'TANQUEROBANDATMFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divTanquerobandatmfiltercontainer_Class',ctrl:'TANQUEROBANDATMFILTERCONTAINER',prop:'Class'},{av:'edtavCtanquerobandatm_Visible',ctrl:'vCTANQUEROBANDATM',prop:'Visible'}]}");
         setEventMetadata("LBLTANQUEROTARIFATMFILTER.CLICK","{handler:'E140X1',iparms:[{av:'divTanquerotarifatmfiltercontainer_Class',ctrl:'TANQUEROTARIFATMFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divTanquerotarifatmfiltercontainer_Class',ctrl:'TANQUEROTARIFATMFILTERCONTAINER',prop:'Class'},{av:'edtavCtanquerotarifatm_Visible',ctrl:'vCTANQUEROTARIFATM',prop:'Visible'}]}");
         setEventMetadata("LBLTANQUEROTARIFALASTREFILTER.CLICK","{handler:'E150X1',iparms:[{av:'divTanquerotarifalastrefiltercontainer_Class',ctrl:'TANQUEROTARIFALASTREFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divTanquerotarifalastrefiltercontainer_Class',ctrl:'TANQUEROTARIFALASTREFILTERCONTAINER',prop:'Class'},{av:'edtavCtanquerotarifalastre_Visible',ctrl:'vCTANQUEROTARIFALASTRE',prop:'Visible'}]}");
         setEventMetadata("LBLTANQUEROBANDACPSUABFILTER.CLICK","{handler:'E160X1',iparms:[{av:'divTanquerobandacpsuabfiltercontainer_Class',ctrl:'TANQUEROBANDACPSUABFILTERCONTAINER',prop:'Class'}],oparms:[{av:'divTanquerobandacpsuabfiltercontainer_Class',ctrl:'TANQUEROBANDACPSUABFILTERCONTAINER',prop:'Class'},{av:'edtavCtanquerobandacpsuab_Visible',ctrl:'vCTANQUEROBANDACPSUAB',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E200X2',iparms:[{av:'A3TanqueroRango',fld:'TANQUERORANGO'}],oparms:[{av:'AV13pTanqueroRango',fld:'vPTANQUERORANGO'}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cTanqueroRango',fld:'vCTANQUERORANGO'},{av:'AV7cTanqueroTarifaCPSUAB',fld:'vCTANQUEROTARIFACPSUAB'},{av:'AV8cTanqueroBandaTM',fld:'vCTANQUEROBANDATM'},{av:'AV9cTanqueroTarifaTM',fld:'vCTANQUEROTARIFATM'},{av:'AV10cTanqueroTarifaLastre',fld:'vCTANQUEROTARIFALASTRE'},{av:'AV11cTanqueroBandaCPSUAB',fld:'vCTANQUEROBANDACPSUAB'},{av:'AV12pTanqueroEsclusasID',fld:'vPTANQUEROESCLUSASID'}],oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cTanqueroRango',fld:'vCTANQUERORANGO'},{av:'AV7cTanqueroTarifaCPSUAB',fld:'vCTANQUEROTARIFACPSUAB'},{av:'AV8cTanqueroBandaTM',fld:'vCTANQUEROBANDATM'},{av:'AV9cTanqueroTarifaTM',fld:'vCTANQUEROTARIFATM'},{av:'AV10cTanqueroTarifaLastre',fld:'vCTANQUEROTARIFALASTRE'},{av:'AV11cTanqueroBandaCPSUAB',fld:'vCTANQUEROBANDACPSUAB'},{av:'AV12pTanqueroEsclusasID',fld:'vPTANQUEROESCLUSASID'}],oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cTanqueroRango',fld:'vCTANQUERORANGO'},{av:'AV7cTanqueroTarifaCPSUAB',fld:'vCTANQUEROTARIFACPSUAB'},{av:'AV8cTanqueroBandaTM',fld:'vCTANQUEROBANDATM'},{av:'AV9cTanqueroTarifaTM',fld:'vCTANQUEROTARIFATM'},{av:'AV10cTanqueroTarifaLastre',fld:'vCTANQUEROTARIFALASTRE'},{av:'AV11cTanqueroBandaCPSUAB',fld:'vCTANQUEROBANDACPSUAB'},{av:'AV12pTanqueroEsclusasID',fld:'vPTANQUEROESCLUSASID'}],oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows'},{av:'AV6cTanqueroRango',fld:'vCTANQUERORANGO'},{av:'AV7cTanqueroTarifaCPSUAB',fld:'vCTANQUEROTARIFACPSUAB'},{av:'AV8cTanqueroBandaTM',fld:'vCTANQUEROBANDATM'},{av:'AV9cTanqueroTarifaTM',fld:'vCTANQUEROTARIFATM'},{av:'AV10cTanqueroTarifaLastre',fld:'vCTANQUEROTARIFALASTRE'},{av:'AV11cTanqueroBandaCPSUAB',fld:'vCTANQUEROBANDACPSUAB'},{av:'AV12pTanqueroEsclusasID',fld:'vPTANQUEROESCLUSASID'}],oparms:[]}");
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
         lblLbltanquerorangofilter_Jsonclick = "";
         TempTags = "";
         lblLbltanquerotarifacpsuabfilter_Jsonclick = "";
         lblLbltanquerobandatmfilter_Jsonclick = "";
         lblLbltanquerotarifatmfilter_Jsonclick = "";
         lblLbltanquerotarifalastrefilter_Jsonclick = "";
         lblLbltanquerobandacpsuabfilter_Jsonclick = "";
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
         AV17Linkselection_GXI = "";
         GXKey = "";
         GXCCtl = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         scmdbuf = "";
         H000X2_A1TanqueroEsclusasID = new short[1] ;
         H000X2_A8TanqueroBandaCPSUAB = new long[1] ;
         H000X2_A7TanqueroTarifaLastre = new decimal[1] ;
         H000X2_A6TanqueroTarifaTM = new decimal[1] ;
         H000X2_A5TanqueroBandaTM = new long[1] ;
         H000X2_A4TanqueroTarifaCPSUAB = new decimal[1] ;
         H000X2_A3TanqueroRango = new short[1] ;
         H000X3_AGRID1_nRecordCount = new long[1] ;
         AV14ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0021__default(),
            new Object[][] {
                new Object[] {
               H000X2_A1TanqueroEsclusasID, H000X2_A8TanqueroBandaCPSUAB, H000X2_A7TanqueroTarifaLastre, H000X2_A6TanqueroTarifaTM, H000X2_A5TanqueroBandaTM, H000X2_A4TanqueroTarifaCPSUAB, H000X2_A3TanqueroRango
               }
               , new Object[] {
               H000X3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV12pTanqueroEsclusasID ;
      private short wcpOAV12pTanqueroEsclusasID ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_74 ;
      private short nGXsfl_74_idx=1 ;
      private short AV6cTanqueroRango ;
      private short AV13pTanqueroRango ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A3TanqueroRango ;
      private short A1TanqueroEsclusasID ;
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
      private int edtavCtanquerorango_Enabled ;
      private int edtavCtanquerorango_Visible ;
      private int edtavCtanquerotarifacpsuab_Enabled ;
      private int edtavCtanquerotarifacpsuab_Visible ;
      private int edtavCtanquerobandatm_Enabled ;
      private int edtavCtanquerobandatm_Visible ;
      private int edtavCtanquerotarifatm_Enabled ;
      private int edtavCtanquerotarifatm_Visible ;
      private int edtavCtanquerotarifalastre_Enabled ;
      private int edtavCtanquerotarifalastre_Visible ;
      private int edtavCtanquerobandacpsuab_Enabled ;
      private int edtavCtanquerobandacpsuab_Visible ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long AV8cTanqueroBandaTM ;
      private long AV11cTanqueroBandaCPSUAB ;
      private long GRID1_nFirstRecordOnPage ;
      private long A5TanqueroBandaTM ;
      private long A8TanqueroBandaCPSUAB ;
      private long GXPagingTo2 ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private decimal AV7cTanqueroTarifaCPSUAB ;
      private decimal AV9cTanqueroTarifaTM ;
      private decimal AV10cTanqueroTarifaLastre ;
      private decimal A4TanqueroTarifaCPSUAB ;
      private decimal A6TanqueroTarifaTM ;
      private decimal A7TanqueroTarifaLastre ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divTanquerorangofiltercontainer_Class ;
      private String divTanquerotarifacpsuabfiltercontainer_Class ;
      private String divTanquerobandatmfiltercontainer_Class ;
      private String divTanquerotarifatmfiltercontainer_Class ;
      private String divTanquerotarifalastrefiltercontainer_Class ;
      private String divTanquerobandacpsuabfiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_74_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divTanquerorangofiltercontainer_Internalname ;
      private String lblLbltanquerorangofilter_Internalname ;
      private String lblLbltanquerorangofilter_Jsonclick ;
      private String TempTags ;
      private String edtavCtanquerorango_Internalname ;
      private String edtavCtanquerorango_Jsonclick ;
      private String divTanquerotarifacpsuabfiltercontainer_Internalname ;
      private String lblLbltanquerotarifacpsuabfilter_Internalname ;
      private String lblLbltanquerotarifacpsuabfilter_Jsonclick ;
      private String edtavCtanquerotarifacpsuab_Internalname ;
      private String edtavCtanquerotarifacpsuab_Jsonclick ;
      private String divTanquerobandatmfiltercontainer_Internalname ;
      private String lblLbltanquerobandatmfilter_Internalname ;
      private String lblLbltanquerobandatmfilter_Jsonclick ;
      private String edtavCtanquerobandatm_Internalname ;
      private String edtavCtanquerobandatm_Jsonclick ;
      private String divTanquerotarifatmfiltercontainer_Internalname ;
      private String lblLbltanquerotarifatmfilter_Internalname ;
      private String lblLbltanquerotarifatmfilter_Jsonclick ;
      private String edtavCtanquerotarifatm_Internalname ;
      private String edtavCtanquerotarifatm_Jsonclick ;
      private String divTanquerotarifalastrefiltercontainer_Internalname ;
      private String lblLbltanquerotarifalastrefilter_Internalname ;
      private String lblLbltanquerotarifalastrefilter_Jsonclick ;
      private String edtavCtanquerotarifalastre_Internalname ;
      private String edtavCtanquerotarifalastre_Jsonclick ;
      private String divTanquerobandacpsuabfiltercontainer_Internalname ;
      private String lblLbltanquerobandacpsuabfilter_Internalname ;
      private String lblLbltanquerobandacpsuabfilter_Jsonclick ;
      private String edtavCtanquerobandacpsuab_Internalname ;
      private String edtavCtanquerobandacpsuab_Jsonclick ;
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
      private String edtTanqueroRango_Internalname ;
      private String edtTanqueroTarifaCPSUAB_Internalname ;
      private String edtTanqueroBandaTM_Internalname ;
      private String edtTanqueroTarifaTM_Internalname ;
      private String edtTanqueroTarifaLastre_Internalname ;
      private String edtTanqueroBandaCPSUAB_Internalname ;
      private String cmbTanqueroEsclusasID_Internalname ;
      private String GXKey ;
      private String GXCCtl ;
      private String scmdbuf ;
      private String AV14ADVANCED_LABEL_TEMPLATE ;
      private String ROClassString ;
      private String edtTanqueroRango_Jsonclick ;
      private String edtTanqueroTarifaCPSUAB_Jsonclick ;
      private String edtTanqueroBandaTM_Jsonclick ;
      private String edtTanqueroTarifaTM_Jsonclick ;
      private String edtTanqueroTarifaLastre_Jsonclick ;
      private String edtTanqueroBandaCPSUAB_Jsonclick ;
      private String cmbTanqueroEsclusasID_Jsonclick ;
      private String div_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV17Linkselection_GXI ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbTanqueroEsclusasID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_default ;
      private short[] H000X2_A1TanqueroEsclusasID ;
      private long[] H000X2_A8TanqueroBandaCPSUAB ;
      private decimal[] H000X2_A7TanqueroTarifaLastre ;
      private decimal[] H000X2_A6TanqueroTarifaTM ;
      private long[] H000X2_A5TanqueroBandaTM ;
      private decimal[] H000X2_A4TanqueroTarifaCPSUAB ;
      private short[] H000X2_A3TanqueroRango ;
      private long[] H000X3_AGRID1_nRecordCount ;
      private short aP1_pTanqueroRango ;
      private GXWebForm Form ;
   }

   public class gx0021__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000X2( IGxContext context ,
                                             decimal AV7cTanqueroTarifaCPSUAB ,
                                             long AV8cTanqueroBandaTM ,
                                             decimal AV9cTanqueroTarifaTM ,
                                             decimal AV10cTanqueroTarifaLastre ,
                                             long AV11cTanqueroBandaCPSUAB ,
                                             decimal A4TanqueroTarifaCPSUAB ,
                                             long A5TanqueroBandaTM ,
                                             decimal A6TanqueroTarifaTM ,
                                             decimal A7TanqueroTarifaLastre ,
                                             long A8TanqueroBandaCPSUAB ,
                                             short AV12pTanqueroEsclusasID ,
                                             short AV6cTanqueroRango ,
                                             short A1TanqueroEsclusasID )
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
         sSelectString = " [TanqueroEsclusasID], [TanqueroBandaCPSUAB], [TanqueroTarifaLastre], [TanqueroTarifaTM], [TanqueroBandaTM], [TanqueroTarifaCPSUAB], [TanqueroRango]";
         sFromString = " FROM [TanqueroEsclusasRango] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([TanqueroEsclusasID] = @AV12pTanqueroEsclusasID and [TanqueroRango] >= @AV6cTanqueroRango)";
         if ( ! (Convert.ToDecimal(0)==AV7cTanqueroTarifaCPSUAB) )
         {
            sWhereString = sWhereString + " and ([TanqueroTarifaCPSUAB] >= @AV7cTanqueroTarifaCPSUAB)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (0==AV8cTanqueroBandaTM) )
         {
            sWhereString = sWhereString + " and ([TanqueroBandaTM] >= @AV8cTanqueroBandaTM)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV9cTanqueroTarifaTM) )
         {
            sWhereString = sWhereString + " and ([TanqueroTarifaTM] >= @AV9cTanqueroTarifaTM)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV10cTanqueroTarifaLastre) )
         {
            sWhereString = sWhereString + " and ([TanqueroTarifaLastre] >= @AV10cTanqueroTarifaLastre)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (0==AV11cTanqueroBandaCPSUAB) )
         {
            sWhereString = sWhereString + " and ([TanqueroBandaCPSUAB] >= @AV11cTanqueroBandaCPSUAB)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [TanqueroEsclusasID], [TanqueroRango]";
         scmdbuf = "SELECT * FROM (SELECT " + sSelectString + ", ROW_NUMBER() OVER (" + sOrderString + " ) AS GX_ROW_NUMBER" + sFromString + sWhereString + ") AS GX_CTE WHERE GX_ROW_NUMBER" + " BETWEEN " + "@GXPagingFrom2" + " AND " + "@GXPagingTo2" + " OR " + "@GXPagingTo2" + " < " + "@GXPagingFrom2" + " AND GX_ROW_NUMBER >= " + "@GXPagingFrom2";
         scmdbuf = scmdbuf + " OPTION (FAST 11)";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H000X3( IGxContext context ,
                                             decimal AV7cTanqueroTarifaCPSUAB ,
                                             long AV8cTanqueroBandaTM ,
                                             decimal AV9cTanqueroTarifaTM ,
                                             decimal AV10cTanqueroTarifaLastre ,
                                             long AV11cTanqueroBandaCPSUAB ,
                                             decimal A4TanqueroTarifaCPSUAB ,
                                             long A5TanqueroBandaTM ,
                                             decimal A6TanqueroTarifaTM ,
                                             decimal A7TanqueroTarifaLastre ,
                                             long A8TanqueroBandaCPSUAB ,
                                             short AV12pTanqueroEsclusasID ,
                                             short AV6cTanqueroRango ,
                                             short A1TanqueroEsclusasID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [TanqueroEsclusasRango] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([TanqueroEsclusasID] = @AV12pTanqueroEsclusasID and [TanqueroRango] >= @AV6cTanqueroRango)";
         if ( ! (Convert.ToDecimal(0)==AV7cTanqueroTarifaCPSUAB) )
         {
            sWhereString = sWhereString + " and ([TanqueroTarifaCPSUAB] >= @AV7cTanqueroTarifaCPSUAB)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV8cTanqueroBandaTM) )
         {
            sWhereString = sWhereString + " and ([TanqueroBandaTM] >= @AV8cTanqueroBandaTM)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV9cTanqueroTarifaTM) )
         {
            sWhereString = sWhereString + " and ([TanqueroTarifaTM] >= @AV9cTanqueroTarifaTM)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV10cTanqueroTarifaLastre) )
         {
            sWhereString = sWhereString + " and ([TanqueroTarifaLastre] >= @AV10cTanqueroTarifaLastre)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (0==AV11cTanqueroBandaCPSUAB) )
         {
            sWhereString = sWhereString + " and ([TanqueroBandaCPSUAB] >= @AV11cTanqueroBandaCPSUAB)";
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
                     return conditional_H000X2(context, (decimal)dynConstraints[0] , (long)dynConstraints[1] , (decimal)dynConstraints[2] , (decimal)dynConstraints[3] , (long)dynConstraints[4] , (decimal)dynConstraints[5] , (long)dynConstraints[6] , (decimal)dynConstraints[7] , (decimal)dynConstraints[8] , (long)dynConstraints[9] , (short)dynConstraints[10] , (short)dynConstraints[11] , (short)dynConstraints[12] );
               case 1 :
                     return conditional_H000X3(context, (decimal)dynConstraints[0] , (long)dynConstraints[1] , (decimal)dynConstraints[2] , (decimal)dynConstraints[3] , (long)dynConstraints[4] , (decimal)dynConstraints[5] , (long)dynConstraints[6] , (decimal)dynConstraints[7] , (decimal)dynConstraints[8] , (long)dynConstraints[9] , (short)dynConstraints[10] , (short)dynConstraints[11] , (short)dynConstraints[12] );
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
          Object[] prmH000X2 ;
          prmH000X2 = new Object[] {
          new Object[] {"@AV12pTanqueroEsclusasID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6cTanqueroRango",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cTanqueroTarifaCPSUAB",SqlDbType.Decimal,7,2} ,
          new Object[] {"@AV8cTanqueroBandaTM",SqlDbType.Decimal,12,0} ,
          new Object[] {"@AV9cTanqueroTarifaTM",SqlDbType.Decimal,7,2} ,
          new Object[] {"@AV10cTanqueroTarifaLastre",SqlDbType.Decimal,7,2} ,
          new Object[] {"@AV11cTanqueroBandaCPSUAB",SqlDbType.Decimal,10,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,6,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Decimal,12,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Decimal,12,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,6,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,6,0}
          } ;
          Object[] prmH000X3 ;
          prmH000X3 = new Object[] {
          new Object[] {"@AV12pTanqueroEsclusasID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6cTanqueroRango",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cTanqueroTarifaCPSUAB",SqlDbType.Decimal,7,2} ,
          new Object[] {"@AV8cTanqueroBandaTM",SqlDbType.Decimal,12,0} ,
          new Object[] {"@AV9cTanqueroTarifaTM",SqlDbType.Decimal,7,2} ,
          new Object[] {"@AV10cTanqueroTarifaLastre",SqlDbType.Decimal,7,2} ,
          new Object[] {"@AV11cTanqueroBandaCPSUAB",SqlDbType.Decimal,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000X2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000X2,11,0,false,false )
             ,new CursorDef("H000X3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000X3,1,0,false,false )
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
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
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
                   stmt.SetParameter(sIdx, (decimal)parms[14]);
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
                   stmt.SetParameter(sIdx, (long)parms[18]);
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
                   stmt.SetParameter(sIdx, (decimal)parms[9]);
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
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                break;
       }
    }

 }

}
