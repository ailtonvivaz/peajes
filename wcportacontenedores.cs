/*
               File: WCPortacontenedores
        Description: WCPortacontenedores
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:15:0.7
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
   public class wcportacontenedores : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wcportacontenedores( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public wcportacontenedores( IGxContext context )
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
         PA0A2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0A2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2015126111509");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" class=\"form-horizontal Form\" novalidate action=\""+formatLink("wcportacontenedores.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vSDTRESULTADO_Sdtresultadopanamaxc3", StringUtil.LTrim( StringUtil.NToC( AV10SdtResultado.gxTpr_Sdtresultadopanamaxc3, 18, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "vSDTRESULTADO_Sdtresultadoneopanamaxc3", StringUtil.LTrim( StringUtil.NToC( AV10SdtResultado.gxTpr_Sdtresultadoneopanamaxc3, 18, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "vSDTRESULTADO_Sdtresultadopanamaxc2", StringUtil.LTrim( StringUtil.NToC( AV10SdtResultado.gxTpr_Sdtresultadopanamaxc2, 18, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "vSDTRESULTADO_Sdtresultadoneopanamaxc2", StringUtil.LTrim( StringUtil.NToC( AV10SdtResultado.gxTpr_Sdtresultadoneopanamaxc2, 18, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "vSDTRESULTADO_Sdtresultadopanamaxc1", StringUtil.LTrim( StringUtil.NToC( AV10SdtResultado.gxTpr_Sdtresultadopanamaxc1, 18, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "vSDTRESULTADO_Sdtresultadoneopanamaxc1", StringUtil.LTrim( StringUtil.NToC( AV10SdtResultado.gxTpr_Sdtresultadoneopanamaxc1, 18, 2, ".", "")));
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
            WE0A2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0A2( ) ;
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
         return formatLink("wcportacontenedores.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "wcportacontenedores" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "WCPortacontenedores", "") ;
      }

      protected void WB0A0( )
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
            GxWebStd.gx_group_start( context, grpGroup1_Internalname, context.GetMessage( "Portacontenedores", ""), 1, 0, "px", 0, "px", "Group", "", "HLP_WCPortacontenedores.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-7 col-md-7", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCapacidaddecontenedores_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl14_Internalname, context.GetMessage( "Capacidad total TEU", ""), "", "", lbllbl14_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCapacidaddecontenedores_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5CapacidadDeContenedores), 7, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCapacidaddecontenedores_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV5CapacidadDeContenedores), "ZZZ,ZZ9")) : context.localUtil.Format( (decimal)(AV5CapacidadDeContenedores), "ZZZ,ZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCapacidaddecontenedores_Jsonclick, 0, "Attribute", "", "", "", 1, edtavCapacidaddecontenedores_Enabled, 0, "text", "", 7, "chr", 1, "row", 7, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-4 col-sm-offset-0 col-md-4 col-md-offset-0", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCargateu_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl19_Internalname, context.GetMessage( "Carga TEU", ""), "", "", lbllbl19_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCargateu_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9CargaTEU), 7, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtavCargateu_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV9CargaTEU), "ZZZ,ZZ9")) : context.localUtil.Format( (decimal)(AV9CargaTEU), "ZZZ,ZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(21);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCargateu_Jsonclick, 0, "Attribute", "", "", "", 1, edtavCargateu_Enabled, 0, "text", "", 7, "chr", 1, "row", 7, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-8 col-sm-offset-0 col-md-8", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPorcentajedecarga_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl24_Internalname, context.GetMessage( "%  de carga", ""), "", "", lbllbl24_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavPorcentajedecarga_Internalname, StringUtil.LTrim( StringUtil.NToC( AV6PorcentajeDeCarga, 6, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavPorcentajedecarga_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV6PorcentajeDeCarga, "ZZ9.99")) : context.localUtil.Format( AV6PorcentajeDeCarga, "ZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPorcentajedecarga_Jsonclick, 0, "Attribute", "", "", "", 1, edtavPorcentajedecarga_Enabled, 0, "text", "", 6, "chr", 1, "row", 6, 0, 0, 0, 1, 1, 0, true, "", "right", "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            wb_table1_29_0A2( true) ;
         }
         else
         {
            wb_table1_29_0A2( false) ;
         }
         return  ;
      }

      protected void wb_table1_29_0A2e( bool wbgen )
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
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            /* Control Group */
            GxWebStd.gx_group_start( context, grpGrouptanqueroresultado_Internalname, context.GetMessage( "Resultados estimados en USD", ""), 1, 0, "px", 0, "px", "Group", "", "HLP_WCPortacontenedores.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGrouptanqueroresultadotable_Internalname, 1, 0, "px", 0, "px", "Table", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, context.GetMessage( "Tarifa regular (de 0-450,000 TEU)", ""), "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6", " "+"id"+" ");
            wb_table2_47_0A2( true) ;
         }
         else
         {
            wb_table2_47_0A2( false) ;
         }
         return  ;
      }

      protected void wb_table2_47_0A2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6", " "+"id"+" ");
            wb_table3_54_0A2( true) ;
         }
         else
         {
            wb_table3_54_0A2( false) ;
         }
         return  ;
      }

      protected void wb_table3_54_0A2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, context.GetMessage( "Tarifa categoría 3 (de 450,001 - 999,999 TEU)", ""), "", "", lblTextblock2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6", " "+"id"+" ");
            wb_table4_65_0A2( true) ;
         }
         else
         {
            wb_table4_65_0A2( false) ;
         }
         return  ;
      }

      protected void wb_table4_65_0A2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6", " "+"id"+" ");
            wb_table5_73_0A2( true) ;
         }
         else
         {
            wb_table5_73_0A2( false) ;
         }
         return  ;
      }

      protected void wb_table5_73_0A2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, context.GetMessage( "Tarifa categoría 2 (de 1,000,000 - 1,499,999 TEU)", ""), "", "", lblTextblock3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6", " "+"id"+" ");
            wb_table6_85_0A2( true) ;
         }
         else
         {
            wb_table6_85_0A2( false) ;
         }
         return  ;
      }

      protected void wb_table6_85_0A2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6", " "+"id"+" ");
            wb_table7_93_0A2( true) ;
         }
         else
         {
            wb_table7_93_0A2( false) ;
         }
         return  ;
      }

      protected void wb_table7_93_0A2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, context.GetMessage( "Tarifa categoría 1 (de 1,500,000 o más TEU)", ""), "", "", lblTextblock4_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6", " "+"id"+" ");
            wb_table8_105_0A2( true) ;
         }
         else
         {
            wb_table8_105_0A2( false) ;
         }
         return  ;
      }

      protected void wb_table8_105_0A2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-6", " "+"id"+" ");
            wb_table9_113_0A2( true) ;
         }
         else
         {
            wb_table9_113_0A2( false) ;
         }
         return  ;
      }

      protected void wb_table9_113_0A2e( bool wbgen )
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
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0122"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( ! context.isAjaxRequest( ) )
               {
                  context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0122"+"");
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

      protected void START0A2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_2-86442", 0) ;
            Form.Meta.addItem("description", context.GetMessage( "WCPortacontenedores", ""), 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0A0( ) ;
      }

      protected void WS0A2( )
      {
         START0A2( ) ;
         EVT0A2( ) ;
      }

      protected void EVT0A2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false;
                                 if ( ! Rfr0gs )
                                 {
                                    /* Execute user event: E110A2 */
                                    E110A2 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CALCULAR'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E120A2 */
                              E120A2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E130A2 */
                              E130A2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E140A2 */
                              E140A2 ();
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
                        if ( nCmpId == 122 )
                        {
                           WebComp_Component1 = getWebComponent(GetType(), "GeneXus.Programs", "wcnota", new Object[] {context} );
                           WebComp_Component1.ComponentInit();
                           WebComp_Component1.Name = "WCNota";
                           WebComp_Component1_Component = "WCNota";
                           WebComp_Component1.componentprocess("W0122", "", sEvt);
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE0A2( )
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

      protected void PA0A2( )
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
               GX_FocusControl = edtavCapacidaddecontenedores_Internalname;
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
         RF0A2( ) ;
      }

      protected void RF0A2( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavPorcentajedecarga_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPorcentajedecarga_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPorcentajedecarga_Enabled), 5, 0)));
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
            WebComp_Component1.componentprepare(new Object[] {(String)"W0122",(String)""});
            WebComp_Component1.componentbind(new Object[] {});
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0122"+"");
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
            /* Execute user event: E140A2 */
            E140A2 ();
            WB0A0( ) ;
         }
      }

      protected void STRUP0A0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavPorcentajedecarga_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPorcentajedecarga_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPorcentajedecarga_Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E130A2 */
         E130A2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCapacidaddecontenedores_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCapacidaddecontenedores_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCAPACIDADDECONTENEDORES");
               GX_FocusControl = edtavCapacidaddecontenedores_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV5CapacidadDeContenedores = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5CapacidadDeContenedores", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5CapacidadDeContenedores), 6, 0)));
            }
            else
            {
               AV5CapacidadDeContenedores = (int)(context.localUtil.CToN( cgiGet( edtavCapacidaddecontenedores_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5CapacidadDeContenedores", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5CapacidadDeContenedores), 6, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCargateu_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCargateu_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > Convert.ToDecimal( 999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCARGATEU");
               GX_FocusControl = edtavCargateu_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9CargaTEU = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9CargaTEU", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9CargaTEU), 6, 0)));
            }
            else
            {
               AV9CargaTEU = (int)(context.localUtil.CToN( cgiGet( edtavCargateu_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9CargaTEU", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9CargaTEU), 6, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavPorcentajedecarga_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavPorcentajedecarga_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vPORCENTAJEDECARGA");
               GX_FocusControl = edtavPorcentajedecarga_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6PorcentajeDeCarga = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6PorcentajeDeCarga", StringUtil.LTrim( StringUtil.Str( AV6PorcentajeDeCarga, 6, 2)));
            }
            else
            {
               AV6PorcentajeDeCarga = context.localUtil.CToN( cgiGet( edtavPorcentajedecarga_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6PorcentajeDeCarga", StringUtil.LTrim( StringUtil.Str( AV6PorcentajeDeCarga, 6, 2)));
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

      protected void S112( )
      {
         /* 'LIMPIARCALCULOS' Routine */
         AV9CargaTEU = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9CargaTEU", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9CargaTEU), 6, 0)));
         AV5CapacidadDeContenedores = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5CapacidadDeContenedores", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5CapacidadDeContenedores), 6, 0)));
         AV6PorcentajeDeCarga = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6PorcentajeDeCarga", StringUtil.LTrim( StringUtil.Str( AV6PorcentajeDeCarga, 6, 2)));
         lblResultadopanamax_Caption = StringUtil.Format( "%1", "$0.00", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadopanamax_Internalname, "Caption", lblResultadopanamax_Caption);
         lblResultadoneopanamax_Caption = StringUtil.Format( "%1", "$0.00", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadoneopanamax_Internalname, "Caption", lblResultadoneopanamax_Caption);
         lblResultadopanamaxc3_Caption = StringUtil.Format( "%1", "$0.00", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadopanamaxc3_Internalname, "Caption", lblResultadopanamaxc3_Caption);
         lblResultadoneopanamaxc3_Caption = StringUtil.Format( "%1", "$0.00", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadoneopanamaxc3_Internalname, "Caption", lblResultadoneopanamaxc3_Caption);
         lblResultadopanamaxc2_Caption = StringUtil.Format( "%1", "$0.00", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadopanamaxc2_Internalname, "Caption", lblResultadopanamaxc2_Caption);
         lblResultadoneopanamaxc2_Caption = StringUtil.Format( "%1", "$0.00", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadoneopanamaxc2_Internalname, "Caption", lblResultadoneopanamaxc2_Caption);
         lblResultadopanamaxc1_Caption = StringUtil.Format( "%1", "$0.00", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadopanamaxc1_Internalname, "Caption", lblResultadopanamaxc1_Caption);
         lblResultadoneopanamaxc1_Caption = StringUtil.Format( "%1", "$0.00", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadoneopanamaxc1_Internalname, "Caption", lblResultadoneopanamaxc1_Caption);
      }

      protected void S122( )
      {
         /* 'CALCULAR' Routine */
         if ( ( AV5CapacidadDeContenedores >= 4000 ) && ( AV5CapacidadDeContenedores <= 6000 ) )
         {
            GX_msglist.addItem(context.GetMessage( "Buques con esta capacidad, dependiendo de sus dimensiones y calado, podrán requerir utilizar las esclusas neopanamax.", ""));
         }
         else if ( AV5CapacidadDeContenedores > 14000 )
         {
            GX_msglist.addItem(context.GetMessage( "Buques con esta capacidad, en base a sus dimensiones, podrían no aplicar al Canal de Panamá.", ""));
         }
         else
         {
         }
         if ( AV5CapacidadDeContenedores != 0 )
         {
            if ( ( AV9CargaTEU > AV5CapacidadDeContenedores ) && ( AV9CargaTEU != 0 ) && ( AV5CapacidadDeContenedores != 0 ) )
            {
               /* Execute user subroutine: S112 */
               S112 ();
               if (returnInSub) return;
               GX_msglist.addItem(context.GetMessage( "Error|Número de TEUs cargados abordo no deben superar la capacidad del buque.", ""));
            }
            else
            {
               GXt_SdtSdtResultadoPortaContenedores1 = AV10SdtResultado;
               new calcularportacontenedores(context ).execute(  (decimal)(AV5CapacidadDeContenedores),  (decimal)(AV9CargaTEU), out  GXt_SdtSdtResultadoPortaContenedores1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5CapacidadDeContenedores", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5CapacidadDeContenedores), 6, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9CargaTEU", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9CargaTEU), 6, 0)));
               AV10SdtResultado = GXt_SdtSdtResultadoPortaContenedores1;
               lblResultadopanamax_Caption = StringUtil.Format( "%1", context.localUtil.Format( AV10SdtResultado.gxTpr_Sdtresultadopanamax, "$ZZZ,ZZZ,ZZZ,ZZZ,ZZ9.99"), "", "", "", "", "", "", "", "");
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadopanamax_Internalname, "Caption", lblResultadopanamax_Caption);
               lblResultadoneopanamax_Caption = StringUtil.Format( "%1", context.localUtil.Format( AV10SdtResultado.gxTpr_Sdtresultadoneopanamax, "$ZZZ,ZZZ,ZZZ,ZZZ,ZZ9.99"), "", "", "", "", "", "", "", "");
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadoneopanamax_Internalname, "Caption", lblResultadoneopanamax_Caption);
               lblResultadopanamaxc3_Caption = StringUtil.Format( "%1", context.localUtil.Format( AV10SdtResultado.gxTpr_Sdtresultadopanamaxc3, "$ZZZ,ZZZ,ZZZ,ZZZ,ZZ9.99"), "", "", "", "", "", "", "", "");
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadopanamaxc3_Internalname, "Caption", lblResultadopanamaxc3_Caption);
               lblResultadoneopanamaxc3_Caption = StringUtil.Format( "%1", context.localUtil.Format( AV10SdtResultado.gxTpr_Sdtresultadoneopanamaxc3, "$ZZZ,ZZZ,ZZZ,ZZZ,ZZ9.99"), "", "", "", "", "", "", "", "");
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadoneopanamaxc3_Internalname, "Caption", lblResultadoneopanamaxc3_Caption);
               lblResultadopanamaxc2_Caption = StringUtil.Format( "%1", context.localUtil.Format( AV10SdtResultado.gxTpr_Sdtresultadopanamaxc2, "$ZZZ,ZZZ,ZZZ,ZZZ,ZZ9.99"), "", "", "", "", "", "", "", "");
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadopanamaxc2_Internalname, "Caption", lblResultadopanamaxc2_Caption);
               lblResultadoneopanamaxc2_Caption = StringUtil.Format( "%1", context.localUtil.Format( AV10SdtResultado.gxTpr_Sdtresultadoneopanamaxc2, "$ZZZ,ZZZ,ZZZ,ZZZ,ZZ9.99"), "", "", "", "", "", "", "", "");
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadoneopanamaxc2_Internalname, "Caption", lblResultadoneopanamaxc2_Caption);
               lblResultadopanamaxc1_Caption = StringUtil.Format( "%1", context.localUtil.Format( AV10SdtResultado.gxTpr_Sdtresultadopanamaxc1, "$ZZZ,ZZZ,ZZZ,ZZZ,ZZ9.99"), "", "", "", "", "", "", "", "");
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadopanamaxc1_Internalname, "Caption", lblResultadopanamaxc1_Caption);
               lblResultadoneopanamaxc1_Caption = StringUtil.Format( "%1", context.localUtil.Format( AV10SdtResultado.gxTpr_Sdtresultadoneopanamaxc1, "$ZZZ,ZZZ,ZZZ,ZZZ,ZZ9.99"), "", "", "", "", "", "", "", "");
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadoneopanamaxc1_Internalname, "Caption", lblResultadoneopanamaxc1_Caption);
            }
         }
         else
         {
            /* Execute user subroutine: S112 */
            S112 ();
            if (returnInSub) return;
            GX_msglist.addItem(context.GetMessage( "Error|La capacidad máxima  en TEUs es requerida", ""));
         }
         if ( AV5CapacidadDeContenedores > 6000 )
         {
            lblResultadopanamax_Caption = StringUtil.Format( "%1", context.GetMessage( "N/A", ""), "", "", "", "", "", "", "", "");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadopanamax_Internalname, "Caption", lblResultadopanamax_Caption);
            lblResultadopanamaxc3_Caption = StringUtil.Format( "%1", context.GetMessage( "N/A", ""), "", "", "", "", "", "", "", "");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadopanamaxc3_Internalname, "Caption", lblResultadopanamaxc3_Caption);
            lblResultadopanamaxc2_Caption = StringUtil.Format( "%1", context.GetMessage( "N/A", ""), "", "", "", "", "", "", "", "");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadopanamaxc2_Internalname, "Caption", lblResultadopanamaxc2_Caption);
            lblResultadopanamaxc1_Caption = StringUtil.Format( "%1", context.GetMessage( "N/A", ""), "", "", "", "", "", "", "", "");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadopanamaxc1_Internalname, "Caption", lblResultadopanamaxc1_Caption);
         }
         else
         {
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: E110A2 */
         E110A2 ();
         if (returnInSub) return;
      }

      protected void E110A2( )
      {
         /* Enter Routine */
      }

      protected void E120A2( )
      {
         /* 'Calcular' Routine */
         /* Execute user subroutine: S122 */
         S122 ();
         if (returnInSub) return;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10SdtResultado", AV10SdtResultado);
      }

      protected void GXStart( )
      {
         /* Execute user event: E130A2 */
         E130A2 ();
         if (returnInSub) return;
      }

      protected void E130A2( )
      {
         /* Start Routine */
      }

      protected void nextLoad( )
      {
      }

      protected void E140A2( )
      {
         /* Load Routine */
      }

      protected void wb_table9_113_0A2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable9_Internalname, tblTable9_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockresultadoneopanamaxc1_Internalname, context.GetMessage( "Esclusa neopanamax:", ""), "", "", lblTextblockresultadoneopanamaxc1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadoneopanamaxc1_Internalname, lblResultadoneopanamaxc1_Caption, "", "", lblResultadoneopanamaxc1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Estimados", 0, "", 1, 1, 0, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table9_113_0A2e( true) ;
         }
         else
         {
            wb_table9_113_0A2e( false) ;
         }
      }

      protected void wb_table8_105_0A2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable8_Internalname, tblTable8_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockresultadopanamaxc1_Internalname, context.GetMessage( "Esclusa panamax:", ""), "", "", lblTextblockresultadopanamaxc1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadopanamaxc1_Internalname, lblResultadopanamaxc1_Caption, "", "", lblResultadopanamaxc1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Estimados", 0, "", 1, 1, 0, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table8_105_0A2e( true) ;
         }
         else
         {
            wb_table8_105_0A2e( false) ;
         }
      }

      protected void wb_table7_93_0A2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable7_Internalname, tblTable7_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockresultadoneopanamaxc2_Internalname, context.GetMessage( "Esclusa neopanamax:", ""), "", "", lblTextblockresultadoneopanamaxc2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadoneopanamaxc2_Internalname, lblResultadoneopanamaxc2_Caption, "", "", lblResultadoneopanamaxc2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Estimados", 0, "", 1, 1, 0, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table7_93_0A2e( true) ;
         }
         else
         {
            wb_table7_93_0A2e( false) ;
         }
      }

      protected void wb_table6_85_0A2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable6_Internalname, tblTable6_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockresultadopanamaxc2_Internalname, context.GetMessage( "Esclusa panamax:", ""), "", "", lblTextblockresultadopanamaxc2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadopanamaxc2_Internalname, lblResultadopanamaxc2_Caption, "", "", lblResultadopanamaxc2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Estimados", 0, "", 1, 1, 0, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table6_85_0A2e( true) ;
         }
         else
         {
            wb_table6_85_0A2e( false) ;
         }
      }

      protected void wb_table5_73_0A2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable5_Internalname, tblTable5_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockresultadoneopanamaxc3_Internalname, context.GetMessage( "Esclusa neopanamax:", ""), "", "", lblTextblockresultadoneopanamaxc3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadoneopanamaxc3_Internalname, lblResultadoneopanamaxc3_Caption, "", "", lblResultadoneopanamaxc3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Estimados", 0, "", 1, 1, 0, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_73_0A2e( true) ;
         }
         else
         {
            wb_table5_73_0A2e( false) ;
         }
      }

      protected void wb_table4_65_0A2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockresultadopanamaxc3_Internalname, context.GetMessage( "Esclusa panamax:", ""), "", "", lblTextblockresultadopanamaxc3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadopanamaxc3_Internalname, lblResultadopanamaxc3_Caption, "", "", lblResultadopanamaxc3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Estimados", 0, "", 1, 1, 0, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_65_0A2e( true) ;
         }
         else
         {
            wb_table4_65_0A2e( false) ;
         }
      }

      protected void wb_table3_54_0A2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockresultadoneopanamax_Internalname, context.GetMessage( "Esclusa neopanamax:", ""), "", "", lblTextblockresultadoneopanamax_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadoneopanamax_Internalname, lblResultadoneopanamax_Caption, "", "", lblResultadoneopanamax_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Estimados", 0, "", 1, 1, 0, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_54_0A2e( true) ;
         }
         else
         {
            wb_table3_54_0A2e( false) ;
         }
      }

      protected void wb_table2_47_0A2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockresultadopanamax_Internalname, context.GetMessage( "Esclusa panamax:", ""), "", "", lblTextblockresultadopanamax_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadopanamax_Internalname, lblResultadopanamax_Caption, "", "", lblResultadopanamax_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Estimados", 0, "", 1, 1, 0, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_47_0A2e( true) ;
         }
         else
         {
            wb_table2_47_0A2e( false) ;
         }
      }

      protected void wb_table1_29_0A2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttCalcular_Internalname, "", context.GetMessage( "Calcular", ""), bttCalcular_Jsonclick, 5, context.GetMessage( "Calcular", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'CALCULAR\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttLimpiar_Internalname, "", context.GetMessage( "Limpiar", ""), bttLimpiar_Jsonclick, 7, context.GetMessage( "Limpiar", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e150a1_client"+"'", TempTags, "", 2, "HLP_WCPortacontenedores.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_29_0A2e( true) ;
         }
         else
         {
            wb_table1_29_0A2e( false) ;
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
         PA0A2( ) ;
         WS0A2( ) ;
         WE0A2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20151261115083");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages."+context.GetLanguageProperty( "code")+".js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("wcportacontenedores.js", "?20151261115083");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lbllbl14_Internalname = "LBL14";
         lbllbl14_Internalname = "LBL14";
         edtavCapacidaddecontenedores_Internalname = "vCAPACIDADDECONTENEDORES";
         edtavCapacidaddecontenedores_Internalname = "vCAPACIDADDECONTENEDORES";
         div_Internalname = "";
         div_Internalname = "";
         divCapacidaddecontenedores_container_Internalname = "CAPACIDADDECONTENEDORES_CONTAINER";
         divCapacidaddecontenedores_container_Internalname = "CAPACIDADDECONTENEDORES_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl19_Internalname = "LBL19";
         lbllbl19_Internalname = "LBL19";
         edtavCargateu_Internalname = "vCARGATEU";
         edtavCargateu_Internalname = "vCARGATEU";
         div_Internalname = "";
         div_Internalname = "";
         divCargateu_container_Internalname = "CARGATEU_CONTAINER";
         divCargateu_container_Internalname = "CARGATEU_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl24_Internalname = "LBL24";
         lbllbl24_Internalname = "LBL24";
         edtavPorcentajedecarga_Internalname = "vPORCENTAJEDECARGA";
         edtavPorcentajedecarga_Internalname = "vPORCENTAJEDECARGA";
         div_Internalname = "";
         div_Internalname = "";
         divPorcentajedecarga_container_Internalname = "PORCENTAJEDECARGA_CONTAINER";
         divPorcentajedecarga_container_Internalname = "PORCENTAJEDECARGA_CONTAINER";
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
         lblTextblock1_Internalname = "TEXTBLOCK1";
         lblTextblock1_Internalname = "TEXTBLOCK1";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblTextblockresultadopanamax_Internalname = "TEXTBLOCKRESULTADOPANAMAX";
         lblTextblockresultadopanamax_Internalname = "TEXTBLOCKRESULTADOPANAMAX";
         lblResultadopanamax_Internalname = "RESULTADOPANAMAX";
         lblResultadopanamax_Internalname = "RESULTADOPANAMAX";
         tblTable1_Internalname = "TABLE1";
         tblTable1_Internalname = "TABLE1";
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
         div_Internalname = "";
         div_Internalname = "";
         lblTextblock2_Internalname = "TEXTBLOCK2";
         lblTextblock2_Internalname = "TEXTBLOCK2";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblTextblockresultadopanamaxc3_Internalname = "TEXTBLOCKRESULTADOPANAMAXC3";
         lblTextblockresultadopanamaxc3_Internalname = "TEXTBLOCKRESULTADOPANAMAXC3";
         lblResultadopanamaxc3_Internalname = "RESULTADOPANAMAXC3";
         lblResultadopanamaxc3_Internalname = "RESULTADOPANAMAXC3";
         tblTable4_Internalname = "TABLE4";
         tblTable4_Internalname = "TABLE4";
         div_Internalname = "";
         div_Internalname = "";
         lblTextblockresultadoneopanamaxc3_Internalname = "TEXTBLOCKRESULTADONEOPANAMAXC3";
         lblTextblockresultadoneopanamaxc3_Internalname = "TEXTBLOCKRESULTADONEOPANAMAXC3";
         lblResultadoneopanamaxc3_Internalname = "RESULTADONEOPANAMAXC3";
         lblResultadoneopanamaxc3_Internalname = "RESULTADONEOPANAMAXC3";
         tblTable5_Internalname = "TABLE5";
         tblTable5_Internalname = "TABLE5";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblTextblock3_Internalname = "TEXTBLOCK3";
         lblTextblock3_Internalname = "TEXTBLOCK3";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblTextblockresultadopanamaxc2_Internalname = "TEXTBLOCKRESULTADOPANAMAXC2";
         lblTextblockresultadopanamaxc2_Internalname = "TEXTBLOCKRESULTADOPANAMAXC2";
         lblResultadopanamaxc2_Internalname = "RESULTADOPANAMAXC2";
         lblResultadopanamaxc2_Internalname = "RESULTADOPANAMAXC2";
         tblTable6_Internalname = "TABLE6";
         tblTable6_Internalname = "TABLE6";
         div_Internalname = "";
         div_Internalname = "";
         lblTextblockresultadoneopanamaxc2_Internalname = "TEXTBLOCKRESULTADONEOPANAMAXC2";
         lblTextblockresultadoneopanamaxc2_Internalname = "TEXTBLOCKRESULTADONEOPANAMAXC2";
         lblResultadoneopanamaxc2_Internalname = "RESULTADONEOPANAMAXC2";
         lblResultadoneopanamaxc2_Internalname = "RESULTADONEOPANAMAXC2";
         tblTable7_Internalname = "TABLE7";
         tblTable7_Internalname = "TABLE7";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblTextblock4_Internalname = "TEXTBLOCK4";
         lblTextblock4_Internalname = "TEXTBLOCK4";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblTextblockresultadopanamaxc1_Internalname = "TEXTBLOCKRESULTADOPANAMAXC1";
         lblTextblockresultadopanamaxc1_Internalname = "TEXTBLOCKRESULTADOPANAMAXC1";
         lblResultadopanamaxc1_Internalname = "RESULTADOPANAMAXC1";
         lblResultadopanamaxc1_Internalname = "RESULTADOPANAMAXC1";
         tblTable8_Internalname = "TABLE8";
         tblTable8_Internalname = "TABLE8";
         div_Internalname = "";
         div_Internalname = "";
         lblTextblockresultadoneopanamaxc1_Internalname = "TEXTBLOCKRESULTADONEOPANAMAXC1";
         lblTextblockresultadoneopanamaxc1_Internalname = "TEXTBLOCKRESULTADONEOPANAMAXC1";
         lblResultadoneopanamaxc1_Internalname = "RESULTADONEOPANAMAXC1";
         lblResultadoneopanamaxc1_Internalname = "RESULTADONEOPANAMAXC1";
         tblTable9_Internalname = "TABLE9";
         tblTable9_Internalname = "TABLE9";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divGrouptanqueroresultadotable_Internalname = "GROUPTANQUERORESULTADOTABLE";
         divGrouptanqueroresultadotable_Internalname = "GROUPTANQUERORESULTADOTABLE";
         grpGrouptanqueroresultado_Internalname = "GROUPTANQUERORESULTADO";
         grpGrouptanqueroresultado_Internalname = "GROUPTANQUERORESULTADO";
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
         grpGroup1_Internalname = "GROUP1";
         grpGroup1_Internalname = "GROUP1";
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
         lblResultadoneopanamaxc1_Caption = "$0.00";
         lblResultadopanamaxc1_Caption = "$0.00";
         lblResultadoneopanamaxc2_Caption = "$0.00";
         lblResultadopanamaxc2_Caption = "$0.00";
         lblResultadoneopanamaxc3_Caption = "$0.00";
         lblResultadopanamaxc3_Caption = "$0.00";
         lblResultadoneopanamax_Caption = "$0.00";
         lblResultadopanamax_Caption = "$0.00";
         edtavPorcentajedecarga_Jsonclick = "";
         edtavPorcentajedecarga_Enabled = 1;
         edtavCargateu_Jsonclick = "";
         edtavCargateu_Enabled = 1;
         edtavCapacidaddecontenedores_Jsonclick = "";
         edtavCapacidaddecontenedores_Enabled = 1;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = context.GetMessage( "WCPortacontenedores", "");
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public void Validv_Cargateu( int GX_Parm1 ,
                                   int GX_Parm2 ,
                                   decimal GX_Parm3 )
      {
         AV9CargaTEU = GX_Parm1;
         AV5CapacidadDeContenedores = GX_Parm2;
         AV6PorcentajeDeCarga = GX_Parm3;
         if ( AV9CargaTEU != 0 )
         {
            AV6PorcentajeDeCarga = (decimal)((AV9CargaTEU/ (decimal)(AV5CapacidadDeContenedores))*100);
         }
         else
         {
            if ( AV9CargaTEU == 0 )
            {
               AV6PorcentajeDeCarga = 0;
            }
            else
            {
               if ( AV9CargaTEU > AV5CapacidadDeContenedores )
               {
                  AV6PorcentajeDeCarga = 0;
               }
            }
         }
         dynload_actions( ) ;
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( AV6PorcentajeDeCarga, 6, 2, ".", "")));
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
         setEventMetadata("'LIMPIAR'","{handler:'E150A1',iparms:[],oparms:[{av:'AV9CargaTEU',fld:'vCARGATEU'},{av:'AV5CapacidadDeContenedores',fld:'vCAPACIDADDECONTENEDORES'},{av:'AV6PorcentajeDeCarga',fld:'vPORCENTAJEDECARGA'},{av:'lblResultadopanamax_Caption',ctrl:'RESULTADOPANAMAX',prop:'Caption'},{av:'lblResultadoneopanamax_Caption',ctrl:'RESULTADONEOPANAMAX',prop:'Caption'},{av:'lblResultadopanamaxc3_Caption',ctrl:'RESULTADOPANAMAXC3',prop:'Caption'},{av:'lblResultadoneopanamaxc3_Caption',ctrl:'RESULTADONEOPANAMAXC3',prop:'Caption'},{av:'lblResultadopanamaxc2_Caption',ctrl:'RESULTADOPANAMAXC2',prop:'Caption'},{av:'lblResultadoneopanamaxc2_Caption',ctrl:'RESULTADONEOPANAMAXC2',prop:'Caption'},{av:'lblResultadopanamaxc1_Caption',ctrl:'RESULTADOPANAMAXC1',prop:'Caption'},{av:'lblResultadoneopanamaxc1_Caption',ctrl:'RESULTADONEOPANAMAXC1',prop:'Caption'}]}");
         setEventMetadata("ENTER","{handler:'E110A2',iparms:[],oparms:[]}");
         setEventMetadata("'CALCULAR'","{handler:'E120A2',iparms:[{av:'AV5CapacidadDeContenedores',fld:'vCAPACIDADDECONTENEDORES'},{av:'AV9CargaTEU',fld:'vCARGATEU'},{av:'AV10SdtResultado',fld:'vSDTRESULTADO'}],oparms:[{av:'AV10SdtResultado',fld:'vSDTRESULTADO'},{av:'lblResultadopanamax_Caption',ctrl:'RESULTADOPANAMAX',prop:'Caption'},{av:'lblResultadoneopanamax_Caption',ctrl:'RESULTADONEOPANAMAX',prop:'Caption'},{av:'lblResultadopanamaxc3_Caption',ctrl:'RESULTADOPANAMAXC3',prop:'Caption'},{av:'lblResultadoneopanamaxc3_Caption',ctrl:'RESULTADONEOPANAMAXC3',prop:'Caption'},{av:'lblResultadopanamaxc2_Caption',ctrl:'RESULTADOPANAMAXC2',prop:'Caption'},{av:'lblResultadoneopanamaxc2_Caption',ctrl:'RESULTADONEOPANAMAXC2',prop:'Caption'},{av:'lblResultadopanamaxc1_Caption',ctrl:'RESULTADOPANAMAXC1',prop:'Caption'},{av:'lblResultadoneopanamaxc1_Caption',ctrl:'RESULTADONEOPANAMAXC1',prop:'Caption'},{av:'AV9CargaTEU',fld:'vCARGATEU'},{av:'AV5CapacidadDeContenedores',fld:'vCAPACIDADDECONTENEDORES'},{av:'AV6PorcentajeDeCarga',fld:'vPORCENTAJEDECARGA'}]}");
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
         AV10SdtResultado = new SdtSdtResultadoPortaContenedores(context);
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
         ClassString = "";
         StyleString = "";
         lblTextblock1_Jsonclick = "";
         lblTextblock2_Jsonclick = "";
         lblTextblock3_Jsonclick = "";
         lblTextblock4_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         WebComp_Component1_Component = "";
         GXKey = "";
         GXt_SdtSdtResultadoPortaContenedores1 = new SdtSdtResultadoPortaContenedores(context);
         sStyleString = "";
         lblTextblockresultadoneopanamaxc1_Jsonclick = "";
         lblResultadoneopanamaxc1_Jsonclick = "";
         lblTextblockresultadopanamaxc1_Jsonclick = "";
         lblResultadopanamaxc1_Jsonclick = "";
         lblTextblockresultadoneopanamaxc2_Jsonclick = "";
         lblResultadoneopanamaxc2_Jsonclick = "";
         lblTextblockresultadopanamaxc2_Jsonclick = "";
         lblResultadopanamaxc2_Jsonclick = "";
         lblTextblockresultadoneopanamaxc3_Jsonclick = "";
         lblResultadoneopanamaxc3_Jsonclick = "";
         lblTextblockresultadopanamaxc3_Jsonclick = "";
         lblResultadopanamaxc3_Jsonclick = "";
         lblTextblockresultadoneopanamax_Jsonclick = "";
         lblResultadoneopanamax_Jsonclick = "";
         lblTextblockresultadopanamax_Jsonclick = "";
         lblResultadopanamax_Jsonclick = "";
         bttCalcular_Jsonclick = "";
         bttLimpiar_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         isValidOutput = new GxUnknownObjectCollection();
         WebComp_Component1 = new GeneXus.Http.GXNullWebComponent();
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavPorcentajedecarga_Enabled = 0;
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
      private int AV5CapacidadDeContenedores ;
      private int edtavCapacidaddecontenedores_Enabled ;
      private int AV9CargaTEU ;
      private int edtavCargateu_Enabled ;
      private int edtavPorcentajedecarga_Enabled ;
      private int idxLst ;
      private decimal AV6PorcentajeDeCarga ;
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
      private String divCapacidaddecontenedores_container_Internalname ;
      private String lbllbl14_Internalname ;
      private String lbllbl14_Jsonclick ;
      private String TempTags ;
      private String edtavCapacidaddecontenedores_Internalname ;
      private String edtavCapacidaddecontenedores_Jsonclick ;
      private String divCargateu_container_Internalname ;
      private String lbllbl19_Internalname ;
      private String lbllbl19_Jsonclick ;
      private String edtavCargateu_Internalname ;
      private String edtavCargateu_Jsonclick ;
      private String divPorcentajedecarga_container_Internalname ;
      private String lbllbl24_Internalname ;
      private String lbllbl24_Jsonclick ;
      private String edtavPorcentajedecarga_Internalname ;
      private String edtavPorcentajedecarga_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String grpGrouptanqueroresultado_Internalname ;
      private String divGrouptanqueroresultadotable_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
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
      private String lblResultadopanamaxc3_Caption ;
      private String lblResultadopanamaxc3_Internalname ;
      private String lblResultadoneopanamaxc3_Caption ;
      private String lblResultadoneopanamaxc3_Internalname ;
      private String lblResultadopanamaxc2_Caption ;
      private String lblResultadopanamaxc2_Internalname ;
      private String lblResultadoneopanamaxc2_Caption ;
      private String lblResultadoneopanamaxc2_Internalname ;
      private String lblResultadopanamaxc1_Caption ;
      private String lblResultadopanamaxc1_Internalname ;
      private String lblResultadoneopanamaxc1_Caption ;
      private String lblResultadoneopanamaxc1_Internalname ;
      private String sStyleString ;
      private String tblTable9_Internalname ;
      private String lblTextblockresultadoneopanamaxc1_Internalname ;
      private String lblTextblockresultadoneopanamaxc1_Jsonclick ;
      private String lblResultadoneopanamaxc1_Jsonclick ;
      private String tblTable8_Internalname ;
      private String lblTextblockresultadopanamaxc1_Internalname ;
      private String lblTextblockresultadopanamaxc1_Jsonclick ;
      private String lblResultadopanamaxc1_Jsonclick ;
      private String tblTable7_Internalname ;
      private String lblTextblockresultadoneopanamaxc2_Internalname ;
      private String lblTextblockresultadoneopanamaxc2_Jsonclick ;
      private String lblResultadoneopanamaxc2_Jsonclick ;
      private String tblTable6_Internalname ;
      private String lblTextblockresultadopanamaxc2_Internalname ;
      private String lblTextblockresultadopanamaxc2_Jsonclick ;
      private String lblResultadopanamaxc2_Jsonclick ;
      private String tblTable5_Internalname ;
      private String lblTextblockresultadoneopanamaxc3_Internalname ;
      private String lblTextblockresultadoneopanamaxc3_Jsonclick ;
      private String lblResultadoneopanamaxc3_Jsonclick ;
      private String tblTable4_Internalname ;
      private String lblTextblockresultadopanamaxc3_Internalname ;
      private String lblTextblockresultadopanamaxc3_Jsonclick ;
      private String lblResultadopanamaxc3_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockresultadoneopanamax_Internalname ;
      private String lblTextblockresultadoneopanamax_Jsonclick ;
      private String lblResultadoneopanamax_Jsonclick ;
      private String tblTable1_Internalname ;
      private String lblTextblockresultadopanamax_Internalname ;
      private String lblTextblockresultadopanamax_Jsonclick ;
      private String lblResultadopanamax_Jsonclick ;
      private String tblTable3_Internalname ;
      private String bttCalcular_Internalname ;
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
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtSdtResultadoPortaContenedores AV10SdtResultado ;
      private SdtSdtResultadoPortaContenedores GXt_SdtSdtResultadoPortaContenedores1 ;
   }

}
