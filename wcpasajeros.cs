/*
               File: WCPasajeros
        Description: WC para buques pasajeros
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:15:5.22
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
   public class wcpasajeros : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wcpasajeros( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public wcpasajeros( IGxContext context )
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
         PA1I2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1I2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20151261115524");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" class=\"form-horizontal Form\" novalidate action=\""+formatLink("wcpasajeros.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vSDTRESULTADO_Sdtresultadopanamax", StringUtil.LTrim( StringUtil.NToC( AV7SdtResultado.gxTpr_Sdtresultadopanamax, 18, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "vSDTRESULTADO_Sdtresultadolastre", StringUtil.LTrim( StringUtil.NToC( AV7SdtResultado.gxTpr_Sdtresultadolastre, 18, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "vSDTRESULTADO_Sdtresultadoneopanamax", StringUtil.LTrim( StringUtil.NToC( AV7SdtResultado.gxTpr_Sdtresultadoneopanamax, 18, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "vSDTRESULTADO_Sdtlastreroundtrip", StringUtil.LTrim( StringUtil.NToC( AV7SdtResultado.gxTpr_Sdtlastreroundtrip, 18, 2, ".", "")));
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
            WE1I2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1I2( ) ;
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
         return formatLink("wcpasajeros.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "wcpasajeros" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "WC para buques pasajeros", "") ;
      }

      protected void WB1I0( )
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
            GxWebStd.gx_group_start( context, grpGroup1_Internalname, context.GetMessage( "Pasajeros", ""), 1, 0, "px", 0, "px", "Group", "", "HLP_WCPasajeros.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-3", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCpsuab_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl14_Internalname, context.GetMessage( "CP/SUAB", ""), "", "", lbllbl14_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WCPasajeros.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCpsuab_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5CPSUAB), 13, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCpsuab_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV5CPSUAB), "Z,ZZZ,ZZZ,ZZ9")) : context.localUtil.Format( (decimal)(AV5CPSUAB), "Z,ZZZ,ZZZ,ZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCpsuab_Jsonclick, 0, "Attribute", "", "", "", 1, edtavCpsuab_Enabled, 0, "text", "", 13, "chr", 1, "row", 13, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_WCPasajeros.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-3", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPaxitc_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl19_Internalname, context.GetMessage( "Literas", ""), "", "", lbllbl19_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WCPasajeros.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavPaxitc_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6PAXITC), 5, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtavPaxitc_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6PAXITC), "Z,ZZ9")) : context.localUtil.Format( (decimal)(AV6PAXITC), "Z,ZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(21);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPaxitc_Jsonclick, 0, "Attribute", "", "", "", 1, edtavPaxitc_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_WCPasajeros.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-3", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divRelacion_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl24_Internalname, context.GetMessage( "Relación (%)", ""), "", "", lbllbl24_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WCPasajeros.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavRelacion_Internalname, StringUtil.LTrim( StringUtil.NToC( AV9Relacion, 10, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavRelacion_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV9Relacion, "ZZZZZZ9.99")) : context.localUtil.Format( AV9Relacion, "ZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavRelacion_Jsonclick, 0, "Attribute", "", "", "", 1, edtavRelacion_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, 1, 0, true, "", "right", "HLP_WCPasajeros.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-3", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTrb_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl29_Internalname, context.GetMessage( "TRB", ""), "", "", lbllbl29_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WCPasajeros.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTrb_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8TRB), 13, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtavTrb_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8TRB), "Z,ZZZ,ZZZ,ZZ9")) : context.localUtil.Format( (decimal)(AV8TRB), "Z,ZZZ,ZZZ,ZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(31);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTrb_Jsonclick, 0, "Attribute", "", "", "", 1, edtavTrb_Enabled, 0, "text", "", 13, "chr", 1, "row", 13, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_WCPasajeros.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            wb_table1_34_1I2( true) ;
         }
         else
         {
            wb_table1_34_1I2( false) ;
         }
         return  ;
      }

      protected void wb_table1_34_1I2e( bool wbgen )
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
            GxWebStd.gx_group_start( context, grpGroup2_Internalname, context.GetMessage( "Resultados estimados en USD", ""), 1, 0, "px", 0, "px", "Group", "", "HLP_WCPasajeros.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGroup2table_Internalname, 1, 0, "px", 0, "px", "Table", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6", " "+"id"+" ");
            wb_table2_49_1I2( true) ;
         }
         else
         {
            wb_table2_49_1I2( false) ;
         }
         return  ;
      }

      protected void wb_table2_49_1I2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6", " "+"id"+" ");
            wb_table3_64_1I2( true) ;
         }
         else
         {
            wb_table3_64_1I2( false) ;
         }
         return  ;
      }

      protected void wb_table3_64_1I2e( bool wbgen )
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
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0080"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( ! context.isAjaxRequest( ) )
               {
                  context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0080"+"");
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

      protected void START1I2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_2-86442", 0) ;
            Form.Meta.addItem("description", context.GetMessage( "WC para buques pasajeros", ""), 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1I0( ) ;
      }

      protected void WS1I2( )
      {
         START1I2( ) ;
         EVT1I2( ) ;
      }

      protected void EVT1I2( )
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
                              /* Execute user event: E111I2 */
                              E111I2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E121I2 */
                              E121I2 ();
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
                        if ( nCmpId == 80 )
                        {
                           WebComp_Component1 = getWebComponent(GetType(), "GeneXus.Programs", "wcnota", new Object[] {context} );
                           WebComp_Component1.ComponentInit();
                           WebComp_Component1.Name = "WCNota";
                           WebComp_Component1_Component = "WCNota";
                           WebComp_Component1.componentprocess("W0080", "", sEvt);
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE1I2( )
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

      protected void PA1I2( )
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
               GX_FocusControl = edtavCpsuab_Internalname;
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
         RF1I2( ) ;
      }

      protected void RF1I2( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavRelacion_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavRelacion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavRelacion_Enabled), 5, 0)));
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
            WebComp_Component1.componentprepare(new Object[] {(String)"W0080",(String)""});
            WebComp_Component1.componentbind(new Object[] {});
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0080"+"");
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
            /* Execute user event: E121I2 */
            E121I2 ();
            WB1I0( ) ;
         }
      }

      protected void STRUP1I0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavRelacion_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavRelacion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavRelacion_Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCpsuab_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCpsuab_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPSUAB");
               GX_FocusControl = edtavCpsuab_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV5CPSUAB = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5CPSUAB", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5CPSUAB), 10, 0)));
            }
            else
            {
               AV5CPSUAB = (long)(context.localUtil.CToN( cgiGet( edtavCpsuab_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5CPSUAB", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5CPSUAB), 10, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavPaxitc_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavPaxitc_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vPAXITC");
               GX_FocusControl = edtavPaxitc_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6PAXITC = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6PAXITC", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6PAXITC), 4, 0)));
            }
            else
            {
               AV6PAXITC = (short)(context.localUtil.CToN( cgiGet( edtavPaxitc_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6PAXITC", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6PAXITC), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavRelacion_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavRelacion_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 9999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vRELACION");
               GX_FocusControl = edtavRelacion_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9Relacion = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9Relacion", StringUtil.LTrim( StringUtil.Str( AV9Relacion, 10, 2)));
            }
            else
            {
               AV9Relacion = context.localUtil.CToN( cgiGet( edtavRelacion_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9Relacion", StringUtil.LTrim( StringUtil.Str( AV9Relacion, 10, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTrb_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTrb_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTRB");
               GX_FocusControl = edtavTrb_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8TRB = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TRB", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8TRB), 10, 0)));
            }
            else
            {
               AV8TRB = (long)(context.localUtil.CToN( cgiGet( edtavTrb_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TRB", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8TRB), 10, 0)));
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

      protected void E111I2( )
      {
         /* 'Calcular' Routine */
         if ( ( ( AV5CPSUAB != 0 ) ) && ( ( AV6PAXITC != 0 ) ) && ( ( AV8TRB != 0 ) ) && ( ( AV8TRB >= AV5CPSUAB ) ) )
         {
            AV9Relacion = (decimal)((AV5CPSUAB/ (decimal)(AV6PAXITC)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9Relacion", StringUtil.LTrim( StringUtil.Str( AV9Relacion, 10, 2)));
            GXt_SdtSdtResultado1 = AV7SdtResultado;
            new calcularpasajeros(context ).execute(  AV6PAXITC,  AV8TRB,  AV5CPSUAB, out  GXt_SdtSdtResultado1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6PAXITC", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6PAXITC), 4, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TRB", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8TRB), 10, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5CPSUAB", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5CPSUAB), 10, 0)));
            AV7SdtResultado = GXt_SdtSdtResultado1;
            lblResultadopanamaxcargadocalculo_Caption = context.localUtil.Format( AV7SdtResultado.gxTpr_Sdtresultadopanamax, "$ZZZ,ZZZ,ZZZ,ZZZ,ZZ9.99");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadopanamaxcargadocalculo_Internalname, "Caption", lblResultadopanamaxcargadocalculo_Caption);
            lblResultadopanamaxlastrecalculo_Caption = context.localUtil.Format( AV7SdtResultado.gxTpr_Sdtresultadolastre, "$ZZZ,ZZZ,ZZZ,ZZZ,ZZ9.99");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadopanamaxlastrecalculo_Internalname, "Caption", lblResultadopanamaxlastrecalculo_Caption);
            lblResultadoneopanamaxcargadocalculo_Caption = context.localUtil.Format( AV7SdtResultado.gxTpr_Sdtresultadoneopanamax, "$ZZZ,ZZZ,ZZZ,ZZZ,ZZ9.99");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadoneopanamaxcargadocalculo_Internalname, "Caption", lblResultadoneopanamaxcargadocalculo_Caption);
            lblResultadoneopanamaxlastrecalculo_Caption = context.localUtil.Format( AV7SdtResultado.gxTpr_Sdtlastreroundtrip, "$ZZZ,ZZZ,ZZZ,ZZZ,ZZ9.99");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadoneopanamaxlastrecalculo_Internalname, "Caption", lblResultadoneopanamaxlastrecalculo_Caption);
         }
         if ( AV8TRB == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "Error|El valor de TRB no puede ser 0", ""));
         }
         if ( AV8TRB < AV5CPSUAB )
         {
            GX_msglist.addItem(context.GetMessage( "Error|El valor de TRB no puede ser menor al valor del CP/SUAB", ""));
         }
         if ( ( ( AV6PAXITC > 3000 ) ) && ( ( AV6PAXITC < 4000 ) ) )
         {
            GX_msglist.addItem(context.GetMessage( "Buques con esta capacidad, dependiendo de sus dimensiones y calado, podran requerir utilizar las esclusas neopanamax", ""));
         }
         if ( AV6PAXITC > 6000 )
         {
            GX_msglist.addItem(context.GetMessage( "Buques con esta capacidad, en base a sus dimensiones podrian no aplicar al Canal de Panama.", ""));
         }
         if ( AV6PAXITC > 4000 )
         {
            lblResultadopanamaxcargadocalculo_Caption = context.GetMessage( "N/A", "");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadopanamaxcargadocalculo_Internalname, "Caption", lblResultadopanamaxcargadocalculo_Caption);
            lblResultadopanamaxlastrecalculo_Caption = context.GetMessage( "N/A", "");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadopanamaxlastrecalculo_Internalname, "Caption", lblResultadopanamaxlastrecalculo_Caption);
         }
         GX_FocusControl = bttCalcular_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV7SdtResultado", AV7SdtResultado);
      }

      protected void nextLoad( )
      {
      }

      protected void E121I2( )
      {
         /* Load Routine */
      }

      protected void wb_table3_64_1I2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTableneopanamax_Internalname, tblTableneopanamax_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblNeopanamax_Internalname, context.GetMessage( "Esclusa neopanamax", ""), "", "", lblNeopanamax_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Resultado", 0, "", 1, 1, 0, "HLP_WCPasajeros.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadoneopanamaxcargadotexto_Internalname, context.GetMessage( "Cargado:", ""), "", "", lblResultadoneopanamaxcargadotexto_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Resultado", 0, "", 1, 1, 0, "HLP_WCPasajeros.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadoneopanamaxcargadocalculo_Internalname, lblResultadoneopanamaxcargadocalculo_Caption, "", "", lblResultadoneopanamaxcargadocalculo_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Estimados", 0, "", 1, 1, 0, "HLP_WCPasajeros.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadoneopanamaxlastretexto_Internalname, context.GetMessage( "Tránsito en lastre:", ""), "", "", lblResultadoneopanamaxlastretexto_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Resultado", 0, "", 1, 1, 0, "HLP_WCPasajeros.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadoneopanamaxlastrecalculo_Internalname, lblResultadoneopanamaxlastrecalculo_Caption, "", "", lblResultadoneopanamaxlastrecalculo_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Estimados", 0, "", 1, 1, 0, "HLP_WCPasajeros.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_64_1I2e( true) ;
         }
         else
         {
            wb_table3_64_1I2e( false) ;
         }
      }

      protected void wb_table2_49_1I2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablepanamax_Internalname, tblTablepanamax_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblPanamax_Internalname, context.GetMessage( "Esclusa panamax", ""), "", "", lblPanamax_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Resultado", 0, "", 1, 1, 0, "HLP_WCPasajeros.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadopanamaxcargadotexto_Internalname, context.GetMessage( "Cargado:", ""), "", "", lblResultadopanamaxcargadotexto_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Resultado", 0, "", 1, 1, 0, "HLP_WCPasajeros.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadopanamaxcargadocalculo_Internalname, lblResultadopanamaxcargadocalculo_Caption, "", "", lblResultadopanamaxcargadocalculo_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Estimados", 0, "", 1, 1, 0, "HLP_WCPasajeros.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadopanamaxlastretexto_Internalname, context.GetMessage( "Tránsito en lastre:", ""), "", "", lblResultadopanamaxlastretexto_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Resultado", 0, "", 1, 1, 0, "HLP_WCPasajeros.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadopanamaxlastrecalculo_Internalname, lblResultadopanamaxlastrecalculo_Caption, "", "", lblResultadopanamaxlastrecalculo_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Estimados", 0, "", 1, 1, 0, "HLP_WCPasajeros.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_49_1I2e( true) ;
         }
         else
         {
            wb_table2_49_1I2e( false) ;
         }
      }

      protected void wb_table1_34_1I2( bool wbgen )
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
            GxWebStd.gx_button_ctrl( context, bttCalcular_Internalname, "", context.GetMessage( "Calcular", ""), bttCalcular_Jsonclick, 5, context.GetMessage( "Calcular", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'CALCULAR\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_WCPasajeros.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttLimpiar_Internalname, "", context.GetMessage( "Limpiar", ""), bttLimpiar_Jsonclick, 7, context.GetMessage( "Limpiar", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e131i1_client"+"'", TempTags, "", 2, "HLP_WCPasajeros.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_34_1I2e( true) ;
         }
         else
         {
            wb_table1_34_1I2e( false) ;
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
         PA1I2( ) ;
         WS1I2( ) ;
         WE1I2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20151261115562");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages."+context.GetLanguageProperty( "code")+".js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("wcpasajeros.js", "?20151261115562");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lbllbl14_Internalname = "LBL14";
         lbllbl14_Internalname = "LBL14";
         edtavCpsuab_Internalname = "vCPSUAB";
         edtavCpsuab_Internalname = "vCPSUAB";
         div_Internalname = "";
         div_Internalname = "";
         divCpsuab_container_Internalname = "CPSUAB_CONTAINER";
         divCpsuab_container_Internalname = "CPSUAB_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl19_Internalname = "LBL19";
         lbllbl19_Internalname = "LBL19";
         edtavPaxitc_Internalname = "vPAXITC";
         edtavPaxitc_Internalname = "vPAXITC";
         div_Internalname = "";
         div_Internalname = "";
         divPaxitc_container_Internalname = "PAXITC_CONTAINER";
         divPaxitc_container_Internalname = "PAXITC_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl24_Internalname = "LBL24";
         lbllbl24_Internalname = "LBL24";
         edtavRelacion_Internalname = "vRELACION";
         edtavRelacion_Internalname = "vRELACION";
         div_Internalname = "";
         div_Internalname = "";
         divRelacion_container_Internalname = "RELACION_CONTAINER";
         divRelacion_container_Internalname = "RELACION_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl29_Internalname = "LBL29";
         lbllbl29_Internalname = "LBL29";
         edtavTrb_Internalname = "vTRB";
         edtavTrb_Internalname = "vTRB";
         div_Internalname = "";
         div_Internalname = "";
         divTrb_container_Internalname = "TRB_CONTAINER";
         divTrb_container_Internalname = "TRB_CONTAINER";
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
         lblPanamax_Internalname = "PANAMAX";
         lblPanamax_Internalname = "PANAMAX";
         lblResultadopanamaxcargadotexto_Internalname = "RESULTADOPANAMAXCARGADOTEXTO";
         lblResultadopanamaxcargadotexto_Internalname = "RESULTADOPANAMAXCARGADOTEXTO";
         lblResultadopanamaxcargadocalculo_Internalname = "RESULTADOPANAMAXCARGADOCALCULO";
         lblResultadopanamaxcargadocalculo_Internalname = "RESULTADOPANAMAXCARGADOCALCULO";
         lblResultadopanamaxlastretexto_Internalname = "RESULTADOPANAMAXLASTRETEXTO";
         lblResultadopanamaxlastretexto_Internalname = "RESULTADOPANAMAXLASTRETEXTO";
         lblResultadopanamaxlastrecalculo_Internalname = "RESULTADOPANAMAXLASTRECALCULO";
         lblResultadopanamaxlastrecalculo_Internalname = "RESULTADOPANAMAXLASTRECALCULO";
         tblTablepanamax_Internalname = "TABLEPANAMAX";
         tblTablepanamax_Internalname = "TABLEPANAMAX";
         div_Internalname = "";
         div_Internalname = "";
         lblNeopanamax_Internalname = "NEOPANAMAX";
         lblNeopanamax_Internalname = "NEOPANAMAX";
         lblResultadoneopanamaxcargadotexto_Internalname = "RESULTADONEOPANAMAXCARGADOTEXTO";
         lblResultadoneopanamaxcargadotexto_Internalname = "RESULTADONEOPANAMAXCARGADOTEXTO";
         lblResultadoneopanamaxcargadocalculo_Internalname = "RESULTADONEOPANAMAXCARGADOCALCULO";
         lblResultadoneopanamaxcargadocalculo_Internalname = "RESULTADONEOPANAMAXCARGADOCALCULO";
         lblResultadoneopanamaxlastretexto_Internalname = "RESULTADONEOPANAMAXLASTRETEXTO";
         lblResultadoneopanamaxlastretexto_Internalname = "RESULTADONEOPANAMAXLASTRETEXTO";
         lblResultadoneopanamaxlastrecalculo_Internalname = "RESULTADONEOPANAMAXLASTRECALCULO";
         lblResultadoneopanamaxlastrecalculo_Internalname = "RESULTADONEOPANAMAXLASTRECALCULO";
         tblTableneopanamax_Internalname = "TABLENEOPANAMAX";
         tblTableneopanamax_Internalname = "TABLENEOPANAMAX";
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
         lblResultadoneopanamaxlastrecalculo_Caption = "$0.00";
         lblResultadoneopanamaxcargadocalculo_Caption = "$0.00";
         lblResultadopanamaxlastrecalculo_Caption = "$0.00";
         lblResultadopanamaxcargadocalculo_Caption = "$0.00";
         edtavTrb_Jsonclick = "";
         edtavTrb_Enabled = 1;
         edtavRelacion_Jsonclick = "";
         edtavRelacion_Enabled = 1;
         edtavPaxitc_Jsonclick = "";
         edtavPaxitc_Enabled = 1;
         edtavCpsuab_Jsonclick = "";
         edtavCpsuab_Enabled = 1;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = context.GetMessage( "WC para buques pasajeros", "");
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
         setEventMetadata("'LIMPIAR'","{handler:'E131I1',iparms:[],oparms:[{av:'AV6PAXITC',fld:'vPAXITC'},{av:'AV8TRB',fld:'vTRB'},{av:'AV5CPSUAB',fld:'vCPSUAB'},{av:'AV9Relacion',fld:'vRELACION'},{av:'lblResultadopanamaxcargadocalculo_Caption',ctrl:'RESULTADOPANAMAXCARGADOCALCULO',prop:'Caption'},{av:'lblResultadopanamaxlastrecalculo_Caption',ctrl:'RESULTADOPANAMAXLASTRECALCULO',prop:'Caption'},{av:'lblResultadoneopanamaxcargadocalculo_Caption',ctrl:'RESULTADONEOPANAMAXCARGADOCALCULO',prop:'Caption'},{av:'lblResultadoneopanamaxlastrecalculo_Caption',ctrl:'RESULTADONEOPANAMAXLASTRECALCULO',prop:'Caption'}]}");
         setEventMetadata("'CALCULAR'","{handler:'E111I2',iparms:[{av:'AV6PAXITC',fld:'vPAXITC'},{av:'AV8TRB',fld:'vTRB'},{av:'AV5CPSUAB',fld:'vCPSUAB'},{av:'AV7SdtResultado',fld:'vSDTRESULTADO'}],oparms:[{av:'AV9Relacion',fld:'vRELACION'},{av:'AV7SdtResultado',fld:'vSDTRESULTADO'},{av:'lblResultadopanamaxcargadocalculo_Caption',ctrl:'RESULTADOPANAMAXCARGADOCALCULO',prop:'Caption'},{av:'lblResultadopanamaxlastrecalculo_Caption',ctrl:'RESULTADOPANAMAXLASTRECALCULO',prop:'Caption'},{av:'lblResultadoneopanamaxcargadocalculo_Caption',ctrl:'RESULTADONEOPANAMAXCARGADOCALCULO',prop:'Caption'},{av:'lblResultadoneopanamaxlastrecalculo_Caption',ctrl:'RESULTADONEOPANAMAXLASTRECALCULO',prop:'Caption'}]}");
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
         AV7SdtResultado = new SdtSdtResultado(context);
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
         lblNeopanamax_Jsonclick = "";
         lblResultadoneopanamaxcargadotexto_Jsonclick = "";
         lblResultadoneopanamaxcargadocalculo_Jsonclick = "";
         lblResultadoneopanamaxlastretexto_Jsonclick = "";
         lblResultadoneopanamaxlastrecalculo_Jsonclick = "";
         lblPanamax_Jsonclick = "";
         lblResultadopanamaxcargadotexto_Jsonclick = "";
         lblResultadopanamaxcargadocalculo_Jsonclick = "";
         lblResultadopanamaxlastretexto_Jsonclick = "";
         lblResultadopanamaxlastrecalculo_Jsonclick = "";
         bttCalcular_Jsonclick = "";
         bttLimpiar_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         WebComp_Component1 = new GeneXus.Http.GXNullWebComponent();
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavRelacion_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short AV6PAXITC ;
      private short nCmpId ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int edtavCpsuab_Enabled ;
      private int edtavPaxitc_Enabled ;
      private int edtavRelacion_Enabled ;
      private int edtavTrb_Enabled ;
      private int idxLst ;
      private long AV5CPSUAB ;
      private long AV8TRB ;
      private decimal AV9Relacion ;
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
      private String divCpsuab_container_Internalname ;
      private String lbllbl14_Internalname ;
      private String lbllbl14_Jsonclick ;
      private String TempTags ;
      private String edtavCpsuab_Internalname ;
      private String edtavCpsuab_Jsonclick ;
      private String divPaxitc_container_Internalname ;
      private String lbllbl19_Internalname ;
      private String lbllbl19_Jsonclick ;
      private String edtavPaxitc_Internalname ;
      private String edtavPaxitc_Jsonclick ;
      private String divRelacion_container_Internalname ;
      private String lbllbl24_Internalname ;
      private String lbllbl24_Jsonclick ;
      private String edtavRelacion_Internalname ;
      private String edtavRelacion_Jsonclick ;
      private String divTrb_container_Internalname ;
      private String lbllbl29_Internalname ;
      private String lbllbl29_Jsonclick ;
      private String edtavTrb_Internalname ;
      private String edtavTrb_Jsonclick ;
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
      private String lblResultadopanamaxcargadocalculo_Caption ;
      private String lblResultadopanamaxcargadocalculo_Internalname ;
      private String lblResultadopanamaxlastrecalculo_Caption ;
      private String lblResultadopanamaxlastrecalculo_Internalname ;
      private String lblResultadoneopanamaxcargadocalculo_Caption ;
      private String lblResultadoneopanamaxcargadocalculo_Internalname ;
      private String lblResultadoneopanamaxlastrecalculo_Caption ;
      private String lblResultadoneopanamaxlastrecalculo_Internalname ;
      private String bttCalcular_Internalname ;
      private String sStyleString ;
      private String tblTableneopanamax_Internalname ;
      private String lblNeopanamax_Internalname ;
      private String lblNeopanamax_Jsonclick ;
      private String lblResultadoneopanamaxcargadotexto_Internalname ;
      private String lblResultadoneopanamaxcargadotexto_Jsonclick ;
      private String lblResultadoneopanamaxcargadocalculo_Jsonclick ;
      private String lblResultadoneopanamaxlastretexto_Internalname ;
      private String lblResultadoneopanamaxlastretexto_Jsonclick ;
      private String lblResultadoneopanamaxlastrecalculo_Jsonclick ;
      private String tblTablepanamax_Internalname ;
      private String lblPanamax_Internalname ;
      private String lblPanamax_Jsonclick ;
      private String lblResultadopanamaxcargadotexto_Internalname ;
      private String lblResultadopanamaxcargadotexto_Jsonclick ;
      private String lblResultadopanamaxcargadocalculo_Jsonclick ;
      private String lblResultadopanamaxlastretexto_Internalname ;
      private String lblResultadopanamaxlastretexto_Jsonclick ;
      private String lblResultadopanamaxlastrecalculo_Jsonclick ;
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
      private IGxDataStore dsDefault ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtSdtResultado AV7SdtResultado ;
      private SdtSdtResultado GXt_SdtSdtResultado1 ;
   }

}
