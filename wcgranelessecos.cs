/*
               File: WCGranelesSecos
        Description: WCGraneles Secos
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:18:47.59
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
   public class wcgranelessecos : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wcgranelessecos( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public wcgranelessecos( IGxContext context )
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
         PA0D2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0D2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?201512611184763");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" class=\"form-horizontal Form\" novalidate action=\""+formatLink("wcgranelessecos.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vSDTGRANELEROS_Sdtgranelerosresultadopanamax", StringUtil.LTrim( StringUtil.NToC( AV18SDTGraneleros.gxTpr_Sdtgranelerosresultadopanamax, 12, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "vSDTGRANELEROS_Sdtgranelerosresultadoneopanamax", StringUtil.LTrim( StringUtil.NToC( AV18SDTGraneleros.gxTpr_Sdtgranelerosresultadoneopanamax, 12, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "vSDTGRANELEROS_Sdtgranelerosresultadolastre", StringUtil.LTrim( StringUtil.NToC( AV18SDTGraneleros.gxTpr_Sdtgranelerosresultadolastre, 12, 2, ".", "")));
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
            WE0D2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0D2( ) ;
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
         return formatLink("wcgranelessecos.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "wcgranelessecos" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "WCGraneles Secos", "") ;
      }

      protected void WB0D0( )
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
            GxWebStd.gx_group_start( context, grpGroup1_Internalname, context.GetMessage( "Graneles Secos", ""), 1, 0, "px", 0, "px", "Group", "", "HLP_WCGranelesSecos.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGroup1table_Internalname, 1, 0, "px", 0, "px", "Table", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable1_Internalname, 1, 0, "px", 0, "px", "Table", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-8 col-sm-9 col-md-9", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divDwt_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl14_Internalname, context.GetMessage( "DWT", ""), "", "", lbllbl14_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavDwt_Internalname, StringUtil.LTrim( StringUtil.NToC( AV11DWT, 14, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavDwt_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV11DWT, "ZZZ,ZZZ,ZZ9.99")) : context.localUtil.Format( AV11DWT, "ZZZ,ZZZ,ZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDwt_Jsonclick, 0, "Attribute", "", "", "", 1, edtavDwt_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-4 col-sm-3 col-md-3", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, context.GetMessage( "Text Block", ""), "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", lblTextblock1_Visible, 1, 0, "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-8 col-sm-9", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMtgranos_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl22_Internalname, context.GetMessage( "Granos (TM)", ""), "", "", lbllbl22_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavMtgranos_Internalname, StringUtil.LTrim( StringUtil.NToC( AV15MTGranos, 14, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavMtgranos_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV15MTGranos, "ZZZ,ZZZ,ZZ9.99")) : context.localUtil.Format( AV15MTGranos, "ZZZ,ZZZ,ZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(24);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavMtgranos_Jsonclick, 0, "Attribute", "", "", "", 1, edtavMtgranos_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-4 col-sm-3", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPorcentajegranos_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl27_Internalname, "%", "", "", lbllbl27_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavPorcentajegranos_Internalname, StringUtil.LTrim( StringUtil.NToC( AV7PorcentajeGranos, 12, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavPorcentajegranos_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV7PorcentajeGranos, "ZZZZZZZZ9.99")) : context.localUtil.Format( AV7PorcentajeGranos, "ZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPorcentajegranos_Jsonclick, 0, "Attribute", "", "", "", 1, edtavPorcentajegranos_Enabled, 0, "text", "", 12, "chr", 1, "row", 12, 0, 0, 0, 1, 1, 0, true, "", "right", "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-8 col-sm-9", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMtcarbon_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl33_Internalname, context.GetMessage( "Carbón (TM)", ""), "", "", lbllbl33_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavMtcarbon_Internalname, StringUtil.LTrim( StringUtil.NToC( AV14MTCarbon, 14, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavMtcarbon_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV14MTCarbon, "ZZZ,ZZZ,ZZ9.99")) : context.localUtil.Format( AV14MTCarbon, "ZZZ,ZZZ,ZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(35);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavMtcarbon_Jsonclick, 0, "Attribute", "", "", "", 1, edtavMtcarbon_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-4 col-sm-3", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPorcentajecarbon_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl38_Internalname, "%", "", "", lbllbl38_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavPorcentajecarbon_Internalname, StringUtil.LTrim( StringUtil.NToC( AV8PorcentajeCarbon, 12, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavPorcentajecarbon_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV8PorcentajeCarbon, "ZZZZZZZZ9.99")) : context.localUtil.Format( AV8PorcentajeCarbon, "ZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(40);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPorcentajecarbon_Jsonclick, 0, "Attribute", "", "", "", 1, edtavPorcentajecarbon_Enabled, 0, "text", "", 12, "chr", 1, "row", 12, 0, 0, 0, 1, 1, 0, true, "", "right", "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-8 col-sm-9", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMtmineralhierro_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl44_Internalname, context.GetMessage( "Mineral Hierro (TM)", ""), "", "", lbllbl44_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavMtmineralhierro_Internalname, StringUtil.LTrim( StringUtil.NToC( AV16MTMineralHierro, 14, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavMtmineralhierro_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV16MTMineralHierro, "ZZZ,ZZZ,ZZ9.99")) : context.localUtil.Format( AV16MTMineralHierro, "ZZZ,ZZZ,ZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavMtmineralhierro_Jsonclick, 0, "Attribute", "", "", "", 1, edtavMtmineralhierro_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-4 col-sm-3", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPorcentajehierro_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl49_Internalname, "%", "", "", lbllbl49_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavPorcentajehierro_Internalname, StringUtil.LTrim( StringUtil.NToC( AV9PorcentajeHierro, 12, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavPorcentajehierro_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV9PorcentajeHierro, "ZZZZZZZZ9.99")) : context.localUtil.Format( AV9PorcentajeHierro, "ZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(51);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPorcentajehierro_Jsonclick, 0, "Attribute", "", "", "", 1, edtavPorcentajehierro_Enabled, 0, "text", "", 12, "chr", 1, "row", 12, 0, 0, 0, 1, 1, 0, true, "", "right", "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-8 col-sm-9", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMtotros_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl55_Internalname, context.GetMessage( "Otros (TM)", ""), "", "", lbllbl55_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavMtotros_Internalname, StringUtil.LTrim( StringUtil.NToC( AV17MTOtros, 14, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavMtotros_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV17MTOtros, "ZZZ,ZZZ,ZZ9.99")) : context.localUtil.Format( AV17MTOtros, "ZZZ,ZZZ,ZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(57);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavMtotros_Jsonclick, 0, "Attribute", "", "", "", 1, edtavMtotros_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "", "right", "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-4 col-sm-3", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divPorcentajeotros_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl60_Internalname, "%", "", "", lbllbl60_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavPorcentajeotros_Internalname, StringUtil.LTrim( StringUtil.NToC( AV10PorcentajeOtros, 12, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavPorcentajeotros_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV10PorcentajeOtros, "ZZZZZZZZ9.99")) : context.localUtil.Format( AV10PorcentajeOtros, "ZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(62);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavPorcentajeotros_Jsonclick, 0, "Attribute", "", "", "", 1, edtavPorcentajeotros_Enabled, 0, "text", "", 12, "chr", 1, "row", 12, 0, 0, 0, 1, 1, 0, true, "", "right", "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-8 col-sm-9", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTotalmt_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl66_Internalname, context.GetMessage( "Total (TM)", ""), "", "", lbllbl66_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTotalmt_Internalname, StringUtil.LTrim( StringUtil.NToC( AV20TotalMT, 14, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavTotalmt_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV20TotalMT, "ZZZ,ZZZ,ZZ9.99")) : context.localUtil.Format( AV20TotalMT, "ZZZ,ZZZ,ZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTotalmt_Jsonclick, 0, "Attribute", "", "", "", 1, edtavTotalmt_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, 1, 0, true, "", "right", "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-4 col-sm-3", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTotalptje_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl71_Internalname, "%", "", "", lbllbl71_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTotalptje_Internalname, StringUtil.LTrim( StringUtil.NToC( AV21TotalPtje, 12, 2, context.GetLanguageProperty( "decimal_point"), "")), ((edtavTotalptje_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV21TotalPtje, "ZZZZZZZZ9.99")) : context.localUtil.Format( AV21TotalPtje, "ZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, gx.thousandSeparator,gx.decimalPoint,'2');"+";gx.evt.onblur(73);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTotalptje_Jsonclick, 0, "Attribute", "", "", "", 1, edtavTotalptje_Enabled, 0, "text", "", 12, "chr", 1, "row", 12, 0, 0, 0, 1, 1, 0, true, "", "right", "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            wb_table1_76_0D2( true) ;
         }
         else
         {
            wb_table1_76_0D2( false) ;
         }
         return  ;
      }

      protected void wb_table1_76_0D2e( bool wbgen )
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
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            /* Control Group */
            GxWebStd.gx_group_start( context, grpGroup2_Internalname, context.GetMessage( "Resultados estimados en USD", ""), 1, 0, "px", 0, "px", "Group", "", "HLP_WCGranelesSecos.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGroup2table_Internalname, 1, 0, "px", 0, "px", "Table", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-4", " "+"id"+" ");
            wb_table2_92_0D2( true) ;
         }
         else
         {
            wb_table2_92_0D2( false) ;
         }
         return  ;
      }

      protected void wb_table2_92_0D2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-4", " "+"id"+" ");
            wb_table3_99_0D2( true) ;
         }
         else
         {
            wb_table3_99_0D2( false) ;
         }
         return  ;
      }

      protected void wb_table3_99_0D2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-4", " "+"id"+" ");
            wb_table4_106_0D2( true) ;
         }
         else
         {
            wb_table4_106_0D2( false) ;
         }
         return  ;
      }

      protected void wb_table4_106_0D2e( bool wbgen )
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
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0114"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( ! context.isAjaxRequest( ) )
               {
                  context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0114"+"");
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

      protected void START0D2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_2-86442", 0) ;
            Form.Meta.addItem("description", context.GetMessage( "WCGraneles Secos", ""), 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0D0( ) ;
      }

      protected void WS0D2( )
      {
         START0D2( ) ;
         EVT0D2( ) ;
      }

      protected void EVT0D2( )
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
                              /* Execute user event: E110D2 */
                              E110D2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E120D2 */
                              E120D2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E130D2 */
                              E130D2 ();
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
                        if ( nCmpId == 114 )
                        {
                           WebComp_Component1 = getWebComponent(GetType(), "GeneXus.Programs", "wcnota", new Object[] {context} );
                           WebComp_Component1.ComponentInit();
                           WebComp_Component1.Name = "WCNota";
                           WebComp_Component1_Component = "WCNota";
                           WebComp_Component1.componentprocess("W0114", "", sEvt);
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE0D2( )
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

      protected void PA0D2( )
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
               GX_FocusControl = edtavDwt_Internalname;
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
         RF0D2( ) ;
      }

      protected void RF0D2( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavPorcentajegranos_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPorcentajegranos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPorcentajegranos_Enabled), 5, 0)));
         edtavPorcentajecarbon_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPorcentajecarbon_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPorcentajecarbon_Enabled), 5, 0)));
         edtavPorcentajehierro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPorcentajehierro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPorcentajehierro_Enabled), 5, 0)));
         edtavPorcentajeotros_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPorcentajeotros_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPorcentajeotros_Enabled), 5, 0)));
         edtavTotalmt_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTotalmt_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTotalmt_Enabled), 5, 0)));
         edtavTotalptje_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTotalptje_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTotalptje_Enabled), 5, 0)));
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
            WebComp_Component1.componentprepare(new Object[] {(String)"W0114",(String)""});
            WebComp_Component1.componentbind(new Object[] {});
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0114"+"");
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
            /* Execute user event: E130D2 */
            E130D2 ();
            WB0D0( ) ;
         }
      }

      protected void STRUP0D0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavPorcentajegranos_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPorcentajegranos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPorcentajegranos_Enabled), 5, 0)));
         edtavPorcentajecarbon_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPorcentajecarbon_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPorcentajecarbon_Enabled), 5, 0)));
         edtavPorcentajehierro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPorcentajehierro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPorcentajehierro_Enabled), 5, 0)));
         edtavPorcentajeotros_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPorcentajeotros_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPorcentajeotros_Enabled), 5, 0)));
         edtavTotalmt_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTotalmt_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTotalmt_Enabled), 5, 0)));
         edtavTotalptje_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTotalptje_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTotalptje_Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E120D2 */
         E120D2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavDwt_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavDwt_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vDWT");
               GX_FocusControl = edtavDwt_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11DWT = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11DWT", StringUtil.LTrim( StringUtil.Str( AV11DWT, 12, 2)));
            }
            else
            {
               AV11DWT = context.localUtil.CToN( cgiGet( edtavDwt_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11DWT", StringUtil.LTrim( StringUtil.Str( AV11DWT, 12, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavMtgranos_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavMtgranos_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vMTGRANOS");
               GX_FocusControl = edtavMtgranos_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV15MTGranos = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15MTGranos", StringUtil.LTrim( StringUtil.Str( AV15MTGranos, 12, 2)));
            }
            else
            {
               AV15MTGranos = context.localUtil.CToN( cgiGet( edtavMtgranos_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15MTGranos", StringUtil.LTrim( StringUtil.Str( AV15MTGranos, 12, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavPorcentajegranos_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavPorcentajegranos_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vPORCENTAJEGRANOS");
               GX_FocusControl = edtavPorcentajegranos_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7PorcentajeGranos = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PorcentajeGranos", StringUtil.LTrim( StringUtil.Str( AV7PorcentajeGranos, 12, 2)));
            }
            else
            {
               AV7PorcentajeGranos = context.localUtil.CToN( cgiGet( edtavPorcentajegranos_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PorcentajeGranos", StringUtil.LTrim( StringUtil.Str( AV7PorcentajeGranos, 12, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavMtcarbon_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavMtcarbon_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vMTCARBON");
               GX_FocusControl = edtavMtcarbon_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV14MTCarbon = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14MTCarbon", StringUtil.LTrim( StringUtil.Str( AV14MTCarbon, 12, 2)));
            }
            else
            {
               AV14MTCarbon = context.localUtil.CToN( cgiGet( edtavMtcarbon_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14MTCarbon", StringUtil.LTrim( StringUtil.Str( AV14MTCarbon, 12, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavPorcentajecarbon_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavPorcentajecarbon_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vPORCENTAJECARBON");
               GX_FocusControl = edtavPorcentajecarbon_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8PorcentajeCarbon = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PorcentajeCarbon", StringUtil.LTrim( StringUtil.Str( AV8PorcentajeCarbon, 12, 2)));
            }
            else
            {
               AV8PorcentajeCarbon = context.localUtil.CToN( cgiGet( edtavPorcentajecarbon_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PorcentajeCarbon", StringUtil.LTrim( StringUtil.Str( AV8PorcentajeCarbon, 12, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavMtmineralhierro_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavMtmineralhierro_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vMTMINERALHIERRO");
               GX_FocusControl = edtavMtmineralhierro_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV16MTMineralHierro = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16MTMineralHierro", StringUtil.LTrim( StringUtil.Str( AV16MTMineralHierro, 12, 2)));
            }
            else
            {
               AV16MTMineralHierro = context.localUtil.CToN( cgiGet( edtavMtmineralhierro_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16MTMineralHierro", StringUtil.LTrim( StringUtil.Str( AV16MTMineralHierro, 12, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavPorcentajehierro_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavPorcentajehierro_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vPORCENTAJEHIERRO");
               GX_FocusControl = edtavPorcentajehierro_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9PorcentajeHierro = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PorcentajeHierro", StringUtil.LTrim( StringUtil.Str( AV9PorcentajeHierro, 12, 2)));
            }
            else
            {
               AV9PorcentajeHierro = context.localUtil.CToN( cgiGet( edtavPorcentajehierro_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PorcentajeHierro", StringUtil.LTrim( StringUtil.Str( AV9PorcentajeHierro, 12, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavMtotros_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavMtotros_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vMTOTROS");
               GX_FocusControl = edtavMtotros_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV17MTOtros = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17MTOtros", StringUtil.LTrim( StringUtil.Str( AV17MTOtros, 12, 2)));
            }
            else
            {
               AV17MTOtros = context.localUtil.CToN( cgiGet( edtavMtotros_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17MTOtros", StringUtil.LTrim( StringUtil.Str( AV17MTOtros, 12, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavPorcentajeotros_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavPorcentajeotros_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vPORCENTAJEOTROS");
               GX_FocusControl = edtavPorcentajeotros_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10PorcentajeOtros = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PorcentajeOtros", StringUtil.LTrim( StringUtil.Str( AV10PorcentajeOtros, 12, 2)));
            }
            else
            {
               AV10PorcentajeOtros = context.localUtil.CToN( cgiGet( edtavPorcentajeotros_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PorcentajeOtros", StringUtil.LTrim( StringUtil.Str( AV10PorcentajeOtros, 12, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTotalmt_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTotalmt_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTOTALMT");
               GX_FocusControl = edtavTotalmt_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV20TotalMT = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20TotalMT", StringUtil.LTrim( StringUtil.Str( AV20TotalMT, 12, 2)));
            }
            else
            {
               AV20TotalMT = context.localUtil.CToN( cgiGet( edtavTotalmt_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20TotalMT", StringUtil.LTrim( StringUtil.Str( AV20TotalMT, 12, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTotalptje_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTotalptje_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")) > 999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTOTALPTJE");
               GX_FocusControl = edtavTotalptje_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV21TotalPtje = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TotalPtje", StringUtil.LTrim( StringUtil.Str( AV21TotalPtje, 12, 2)));
            }
            else
            {
               AV21TotalPtje = context.localUtil.CToN( cgiGet( edtavTotalptje_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TotalPtje", StringUtil.LTrim( StringUtil.Str( AV21TotalPtje, 12, 2)));
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

      protected void E110D2( )
      {
         /* 'Calcular' Routine */
         lblResultadopanamax_Caption = StringUtil.Format( "%1", "$0.00", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadopanamax_Internalname, "Caption", lblResultadopanamax_Caption);
         lblResultadoneopanamax_Caption = StringUtil.Format( "%1", "$0.00", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadoneopanamax_Internalname, "Caption", lblResultadoneopanamax_Caption);
         lblResultadolastre_Caption = StringUtil.Format( "%1", "$0.00", "", "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadolastre_Internalname, "Caption", lblResultadolastre_Caption);
         AV19sw = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19sw", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19sw), 4, 0)));
         if ( (Convert.ToDecimal(0)==AV11DWT) || ( AV11DWT == Convert.ToDecimal( 0 )) )
         {
            AV19sw = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19sw", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19sw), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "Error|El campo DWT es requerido", ""));
         }
         if ( AV20TotalMT > AV11DWT )
         {
            AV19sw = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19sw", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19sw), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "Error|La carga transportada  no debe superar la capacidad del buque", ""));
         }
         if ( AV19sw == 0 )
         {
            GXt_SdtSDTGraneleros1 = AV18SDTGraneleros;
            new calculobuquesgranelero(context ).execute(  AV15MTGranos,  AV14MTCarbon,  AV16MTMineralHierro,  AV17MTOtros,  AV11DWT, out  GXt_SdtSDTGraneleros1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15MTGranos", StringUtil.LTrim( StringUtil.Str( AV15MTGranos, 12, 2)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14MTCarbon", StringUtil.LTrim( StringUtil.Str( AV14MTCarbon, 12, 2)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16MTMineralHierro", StringUtil.LTrim( StringUtil.Str( AV16MTMineralHierro, 12, 2)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17MTOtros", StringUtil.LTrim( StringUtil.Str( AV17MTOtros, 12, 2)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11DWT", StringUtil.LTrim( StringUtil.Str( AV11DWT, 12, 2)));
            AV18SDTGraneleros = GXt_SdtSDTGraneleros1;
            lblResultadopanamax_Caption = StringUtil.Format( "%1", context.localUtil.Format( AV18SDTGraneleros.gxTpr_Sdtgranelerosresultadopanamax, "$ZZZ,ZZZ,ZZ9.99"), "", "", "", "", "", "", "", "");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadopanamax_Internalname, "Caption", lblResultadopanamax_Caption);
            lblResultadoneopanamax_Caption = StringUtil.Format( "%1", context.localUtil.Format( AV18SDTGraneleros.gxTpr_Sdtgranelerosresultadoneopanamax, "$ZZZ,ZZZ,ZZ9.99"), "", "", "", "", "", "", "", "");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadoneopanamax_Internalname, "Caption", lblResultadoneopanamax_Caption);
            lblResultadolastre_Caption = StringUtil.Format( "%1", context.localUtil.Format( AV18SDTGraneleros.gxTpr_Sdtgranelerosresultadolastre, "$ZZZ,ZZZ,ZZ9.99"), "", "", "", "", "", "", "", "");
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadolastre_Internalname, "Caption", lblResultadolastre_Caption);
            if ( ( AV11DWT > Convert.ToDecimal( 60000 )) && ( AV11DWT < Convert.ToDecimal( 90000 )) )
            {
               GX_msglist.addItem(context.GetMessage( "Buques con esta capacidad, dependiendo de sus dimensiones y calado, podrán requerir utilizar las esclusas neopanamax ", ""));
            }
            if ( ( AV11DWT >= Convert.ToDecimal( 90000 )) )
            {
               lblResultadopanamax_Caption = context.GetMessage( "N/A", "");
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblResultadopanamax_Internalname, "Caption", lblResultadopanamax_Caption);
            }
            if ( ( AV11DWT >= Convert.ToDecimal( 180000 )) )
            {
               GX_msglist.addItem(context.GetMessage( "Buques con esta capacidad, en base a sus dimensiones, podrían no aplicar al Canal de Panamá ", ""));
            }
         }
         GX_FocusControl = bttCalcular_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18SDTGraneleros", AV18SDTGraneleros);
      }

      protected void GXStart( )
      {
         /* Execute user event: E120D2 */
         E120D2 ();
         if (returnInSub) return;
      }

      protected void E120D2( )
      {
         /* Start Routine */
         lblTextblock1_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTextblock1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(lblTextblock1_Visible), 5, 0)));
      }

      protected void nextLoad( )
      {
      }

      protected void E130D2( )
      {
         /* Load Routine */
      }

      protected void wb_table4_106_0D2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable5_Internalname, tblTable5_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockresultadolastre_Internalname, context.GetMessage( "Tránsito en lastre:", ""), "", "", lblTextblockresultadolastre_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadolastre_Internalname, lblResultadolastre_Caption, "", "", lblResultadolastre_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Estimados", 0, "", 1, 1, 0, "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_106_0D2e( true) ;
         }
         else
         {
            wb_table4_106_0D2e( false) ;
         }
      }

      protected void wb_table3_99_0D2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockresultadoneopanamax_Internalname, context.GetMessage( "Esclusa neopanamax:", ""), "", "", lblTextblockresultadoneopanamax_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadoneopanamax_Internalname, lblResultadoneopanamax_Caption, "", "", lblResultadoneopanamax_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Estimados", 0, "", 1, 1, 0, "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_99_0D2e( true) ;
         }
         else
         {
            wb_table3_99_0D2e( false) ;
         }
      }

      protected void wb_table2_92_0D2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockresultadopanamax_Internalname, context.GetMessage( "Esclusa panamax:", ""), "", "", lblTextblockresultadopanamax_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblResultadopanamax_Internalname, lblResultadopanamax_Caption, "", "", lblResultadopanamax_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Estimados", 0, "", 1, 1, 0, "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_92_0D2e( true) ;
         }
         else
         {
            wb_table2_92_0D2e( false) ;
         }
      }

      protected void wb_table1_76_0D2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttCalcular_Internalname, "", context.GetMessage( "Calcular", ""), bttCalcular_Jsonclick, 5, context.GetMessage( "Calcular", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'CALCULAR\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttLimpiar_Internalname, "", context.GetMessage( "Limpiar", ""), bttLimpiar_Jsonclick, 7, context.GetMessage( "Limpiar", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e140d1_client"+"'", TempTags, "", 2, "HLP_WCGranelesSecos.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_76_0D2e( true) ;
         }
         else
         {
            wb_table1_76_0D2e( false) ;
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
         PA0D2( ) ;
         WS0D2( ) ;
         WE0D2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?201512611184849");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages."+context.GetLanguageProperty( "code")+".js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("wcgranelessecos.js", "?201512611184849");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lbllbl14_Internalname = "LBL14";
         lbllbl14_Internalname = "LBL14";
         edtavDwt_Internalname = "vDWT";
         edtavDwt_Internalname = "vDWT";
         div_Internalname = "";
         div_Internalname = "";
         divDwt_container_Internalname = "DWT_CONTAINER";
         divDwt_container_Internalname = "DWT_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblTextblock1_Internalname = "TEXTBLOCK1";
         lblTextblock1_Internalname = "TEXTBLOCK1";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl22_Internalname = "LBL22";
         lbllbl22_Internalname = "LBL22";
         edtavMtgranos_Internalname = "vMTGRANOS";
         edtavMtgranos_Internalname = "vMTGRANOS";
         div_Internalname = "";
         div_Internalname = "";
         divMtgranos_container_Internalname = "MTGRANOS_CONTAINER";
         divMtgranos_container_Internalname = "MTGRANOS_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl27_Internalname = "LBL27";
         lbllbl27_Internalname = "LBL27";
         edtavPorcentajegranos_Internalname = "vPORCENTAJEGRANOS";
         edtavPorcentajegranos_Internalname = "vPORCENTAJEGRANOS";
         div_Internalname = "";
         div_Internalname = "";
         divPorcentajegranos_container_Internalname = "PORCENTAJEGRANOS_CONTAINER";
         divPorcentajegranos_container_Internalname = "PORCENTAJEGRANOS_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl33_Internalname = "LBL33";
         lbllbl33_Internalname = "LBL33";
         edtavMtcarbon_Internalname = "vMTCARBON";
         edtavMtcarbon_Internalname = "vMTCARBON";
         div_Internalname = "";
         div_Internalname = "";
         divMtcarbon_container_Internalname = "MTCARBON_CONTAINER";
         divMtcarbon_container_Internalname = "MTCARBON_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl38_Internalname = "LBL38";
         lbllbl38_Internalname = "LBL38";
         edtavPorcentajecarbon_Internalname = "vPORCENTAJECARBON";
         edtavPorcentajecarbon_Internalname = "vPORCENTAJECARBON";
         div_Internalname = "";
         div_Internalname = "";
         divPorcentajecarbon_container_Internalname = "PORCENTAJECARBON_CONTAINER";
         divPorcentajecarbon_container_Internalname = "PORCENTAJECARBON_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl44_Internalname = "LBL44";
         lbllbl44_Internalname = "LBL44";
         edtavMtmineralhierro_Internalname = "vMTMINERALHIERRO";
         edtavMtmineralhierro_Internalname = "vMTMINERALHIERRO";
         div_Internalname = "";
         div_Internalname = "";
         divMtmineralhierro_container_Internalname = "MTMINERALHIERRO_CONTAINER";
         divMtmineralhierro_container_Internalname = "MTMINERALHIERRO_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl49_Internalname = "LBL49";
         lbllbl49_Internalname = "LBL49";
         edtavPorcentajehierro_Internalname = "vPORCENTAJEHIERRO";
         edtavPorcentajehierro_Internalname = "vPORCENTAJEHIERRO";
         div_Internalname = "";
         div_Internalname = "";
         divPorcentajehierro_container_Internalname = "PORCENTAJEHIERRO_CONTAINER";
         divPorcentajehierro_container_Internalname = "PORCENTAJEHIERRO_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl55_Internalname = "LBL55";
         lbllbl55_Internalname = "LBL55";
         edtavMtotros_Internalname = "vMTOTROS";
         edtavMtotros_Internalname = "vMTOTROS";
         div_Internalname = "";
         div_Internalname = "";
         divMtotros_container_Internalname = "MTOTROS_CONTAINER";
         divMtotros_container_Internalname = "MTOTROS_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl60_Internalname = "LBL60";
         lbllbl60_Internalname = "LBL60";
         edtavPorcentajeotros_Internalname = "vPORCENTAJEOTROS";
         edtavPorcentajeotros_Internalname = "vPORCENTAJEOTROS";
         div_Internalname = "";
         div_Internalname = "";
         divPorcentajeotros_container_Internalname = "PORCENTAJEOTROS_CONTAINER";
         divPorcentajeotros_container_Internalname = "PORCENTAJEOTROS_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl66_Internalname = "LBL66";
         lbllbl66_Internalname = "LBL66";
         edtavTotalmt_Internalname = "vTOTALMT";
         edtavTotalmt_Internalname = "vTOTALMT";
         div_Internalname = "";
         div_Internalname = "";
         divTotalmt_container_Internalname = "TOTALMT_CONTAINER";
         divTotalmt_container_Internalname = "TOTALMT_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl71_Internalname = "LBL71";
         lbllbl71_Internalname = "LBL71";
         edtavTotalptje_Internalname = "vTOTALPTJE";
         edtavTotalptje_Internalname = "vTOTALPTJE";
         div_Internalname = "";
         div_Internalname = "";
         divTotalptje_container_Internalname = "TOTALPTJE_CONTAINER";
         divTotalptje_container_Internalname = "TOTALPTJE_CONTAINER";
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
         divTable1_Internalname = "TABLE1";
         divTable1_Internalname = "TABLE1";
         div_Internalname = "";
         div_Internalname = "";
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
         lblResultadolastre_Caption = "$0.00";
         lblResultadoneopanamax_Caption = "$0.00";
         lblResultadopanamax_Caption = "$0.00";
         edtavTotalptje_Jsonclick = "";
         edtavTotalptje_Enabled = 1;
         edtavTotalmt_Jsonclick = "";
         edtavTotalmt_Enabled = 1;
         edtavPorcentajeotros_Jsonclick = "";
         edtavPorcentajeotros_Enabled = 1;
         edtavMtotros_Jsonclick = "";
         edtavMtotros_Enabled = 1;
         edtavPorcentajehierro_Jsonclick = "";
         edtavPorcentajehierro_Enabled = 1;
         edtavMtmineralhierro_Jsonclick = "";
         edtavMtmineralhierro_Enabled = 1;
         edtavPorcentajecarbon_Jsonclick = "";
         edtavPorcentajecarbon_Enabled = 1;
         edtavMtcarbon_Jsonclick = "";
         edtavMtcarbon_Enabled = 1;
         edtavPorcentajegranos_Jsonclick = "";
         edtavPorcentajegranos_Enabled = 1;
         edtavMtgranos_Jsonclick = "";
         edtavMtgranos_Enabled = 1;
         lblTextblock1_Visible = 1;
         edtavDwt_Jsonclick = "";
         edtavDwt_Enabled = 1;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = context.GetMessage( "WCGraneles Secos", "");
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public void Validv_Mtgranos( decimal GX_Parm1 ,
                                   decimal GX_Parm2 ,
                                   decimal GX_Parm3 )
      {
         AV15MTGranos = GX_Parm1;
         AV11DWT = GX_Parm2;
         AV7PorcentajeGranos = GX_Parm3;
         AV7PorcentajeGranos = (decimal)((AV15MTGranos*100)/ (decimal)(AV11DWT));
         dynload_actions( ) ;
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( AV7PorcentajeGranos, 12, 2, ".", "")));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Validv_Mtcarbon( decimal GX_Parm1 ,
                                   decimal GX_Parm2 ,
                                   decimal GX_Parm3 )
      {
         AV14MTCarbon = GX_Parm1;
         AV11DWT = GX_Parm2;
         AV8PorcentajeCarbon = GX_Parm3;
         AV8PorcentajeCarbon = (decimal)((AV14MTCarbon*100)/ (decimal)(AV11DWT));
         dynload_actions( ) ;
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( AV8PorcentajeCarbon, 12, 2, ".", "")));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Validv_Mtmineralhierro( decimal GX_Parm1 ,
                                          decimal GX_Parm2 ,
                                          decimal GX_Parm3 )
      {
         AV16MTMineralHierro = GX_Parm1;
         AV11DWT = GX_Parm2;
         AV9PorcentajeHierro = GX_Parm3;
         AV9PorcentajeHierro = (decimal)((AV16MTMineralHierro*100)/ (decimal)(AV11DWT));
         dynload_actions( ) ;
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( AV9PorcentajeHierro, 12, 2, ".", "")));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Validv_Mtotros( decimal GX_Parm1 ,
                                  decimal GX_Parm2 ,
                                  decimal GX_Parm3 ,
                                  decimal GX_Parm4 ,
                                  decimal GX_Parm5 ,
                                  decimal GX_Parm6 ,
                                  decimal GX_Parm7 )
      {
         AV17MTOtros = GX_Parm1;
         AV11DWT = GX_Parm2;
         AV15MTGranos = GX_Parm3;
         AV14MTCarbon = GX_Parm4;
         AV16MTMineralHierro = GX_Parm5;
         AV10PorcentajeOtros = GX_Parm6;
         AV20TotalMT = GX_Parm7;
         AV10PorcentajeOtros = (decimal)((AV17MTOtros*100)/ (decimal)(AV11DWT));
         AV20TotalMT = (decimal)(AV15MTGranos+AV14MTCarbon+AV16MTMineralHierro+AV17MTOtros);
         dynload_actions( ) ;
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( AV10PorcentajeOtros, 12, 2, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( AV20TotalMT, 12, 2, ".", "")));
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Validv_Porcentajeotros( decimal GX_Parm1 ,
                                          decimal GX_Parm2 ,
                                          decimal GX_Parm3 ,
                                          decimal GX_Parm4 ,
                                          decimal GX_Parm5 )
      {
         AV7PorcentajeGranos = GX_Parm1;
         AV8PorcentajeCarbon = GX_Parm2;
         AV9PorcentajeHierro = GX_Parm3;
         AV10PorcentajeOtros = GX_Parm4;
         AV21TotalPtje = GX_Parm5;
         AV21TotalPtje = (decimal)(AV7PorcentajeGranos+AV8PorcentajeCarbon+AV9PorcentajeHierro+AV10PorcentajeOtros);
         dynload_actions( ) ;
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( AV21TotalPtje, 12, 2, ".", "")));
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
         setEventMetadata("'CALCULAR'","{handler:'E110D2',iparms:[{av:'AV11DWT',fld:'vDWT'},{av:'AV20TotalMT',fld:'vTOTALMT'},{av:'AV15MTGranos',fld:'vMTGRANOS'},{av:'AV14MTCarbon',fld:'vMTCARBON'},{av:'AV16MTMineralHierro',fld:'vMTMINERALHIERRO'},{av:'AV17MTOtros',fld:'vMTOTROS'},{av:'AV18SDTGraneleros',fld:'vSDTGRANELEROS'}],oparms:[{av:'lblResultadopanamax_Caption',ctrl:'RESULTADOPANAMAX',prop:'Caption'},{av:'lblResultadoneopanamax_Caption',ctrl:'RESULTADONEOPANAMAX',prop:'Caption'},{av:'lblResultadolastre_Caption',ctrl:'RESULTADOLASTRE',prop:'Caption'},{av:'AV19sw',fld:'vSW'},{av:'AV18SDTGraneleros',fld:'vSDTGRANELEROS'}]}");
         setEventMetadata("'LIMPIAR'","{handler:'E140D1',iparms:[],oparms:[{av:'AV11DWT',fld:'vDWT'},{av:'AV14MTCarbon',fld:'vMTCARBON'},{av:'AV15MTGranos',fld:'vMTGRANOS'},{av:'AV16MTMineralHierro',fld:'vMTMINERALHIERRO'},{av:'AV17MTOtros',fld:'vMTOTROS'},{av:'AV8PorcentajeCarbon',fld:'vPORCENTAJECARBON'},{av:'AV7PorcentajeGranos',fld:'vPORCENTAJEGRANOS'},{av:'AV9PorcentajeHierro',fld:'vPORCENTAJEHIERRO'},{av:'AV10PorcentajeOtros',fld:'vPORCENTAJEOTROS'},{av:'AV20TotalMT',fld:'vTOTALMT'},{av:'AV21TotalPtje',fld:'vTOTALPTJE'}]}");
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
         AV18SDTGraneleros = new SdtSDTGraneleros(context);
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lbllbl14_Jsonclick = "";
         TempTags = "";
         lblTextblock1_Jsonclick = "";
         lbllbl22_Jsonclick = "";
         lbllbl27_Jsonclick = "";
         lbllbl33_Jsonclick = "";
         lbllbl38_Jsonclick = "";
         lbllbl44_Jsonclick = "";
         lbllbl49_Jsonclick = "";
         lbllbl55_Jsonclick = "";
         lbllbl60_Jsonclick = "";
         lbllbl66_Jsonclick = "";
         lbllbl71_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         WebComp_Component1_Component = "";
         GXKey = "";
         GXt_SdtSDTGraneleros1 = new SdtSDTGraneleros(context);
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
         isValidOutput = new GxUnknownObjectCollection();
         WebComp_Component1 = new GeneXus.Http.GXNullWebComponent();
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavPorcentajegranos_Enabled = 0;
         edtavPorcentajecarbon_Enabled = 0;
         edtavPorcentajehierro_Enabled = 0;
         edtavPorcentajeotros_Enabled = 0;
         edtavTotalmt_Enabled = 0;
         edtavTotalptje_Enabled = 0;
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
      private short AV19sw ;
      private short nGXWrapped ;
      private short wbTemp ;
      private int edtavDwt_Enabled ;
      private int lblTextblock1_Visible ;
      private int edtavMtgranos_Enabled ;
      private int edtavPorcentajegranos_Enabled ;
      private int edtavMtcarbon_Enabled ;
      private int edtavPorcentajecarbon_Enabled ;
      private int edtavMtmineralhierro_Enabled ;
      private int edtavPorcentajehierro_Enabled ;
      private int edtavMtotros_Enabled ;
      private int edtavPorcentajeotros_Enabled ;
      private int edtavTotalmt_Enabled ;
      private int edtavTotalptje_Enabled ;
      private int idxLst ;
      private decimal AV11DWT ;
      private decimal AV15MTGranos ;
      private decimal AV7PorcentajeGranos ;
      private decimal AV14MTCarbon ;
      private decimal AV8PorcentajeCarbon ;
      private decimal AV16MTMineralHierro ;
      private decimal AV9PorcentajeHierro ;
      private decimal AV17MTOtros ;
      private decimal AV10PorcentajeOtros ;
      private decimal AV20TotalMT ;
      private decimal AV21TotalPtje ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String grpGroup1_Internalname ;
      private String divGroup1table_Internalname ;
      private String divTable1_Internalname ;
      private String divDwt_container_Internalname ;
      private String lbllbl14_Internalname ;
      private String lbllbl14_Jsonclick ;
      private String TempTags ;
      private String edtavDwt_Internalname ;
      private String edtavDwt_Jsonclick ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String divMtgranos_container_Internalname ;
      private String lbllbl22_Internalname ;
      private String lbllbl22_Jsonclick ;
      private String edtavMtgranos_Internalname ;
      private String edtavMtgranos_Jsonclick ;
      private String divPorcentajegranos_container_Internalname ;
      private String lbllbl27_Internalname ;
      private String lbllbl27_Jsonclick ;
      private String edtavPorcentajegranos_Internalname ;
      private String edtavPorcentajegranos_Jsonclick ;
      private String divMtcarbon_container_Internalname ;
      private String lbllbl33_Internalname ;
      private String lbllbl33_Jsonclick ;
      private String edtavMtcarbon_Internalname ;
      private String edtavMtcarbon_Jsonclick ;
      private String divPorcentajecarbon_container_Internalname ;
      private String lbllbl38_Internalname ;
      private String lbllbl38_Jsonclick ;
      private String edtavPorcentajecarbon_Internalname ;
      private String edtavPorcentajecarbon_Jsonclick ;
      private String divMtmineralhierro_container_Internalname ;
      private String lbllbl44_Internalname ;
      private String lbllbl44_Jsonclick ;
      private String edtavMtmineralhierro_Internalname ;
      private String edtavMtmineralhierro_Jsonclick ;
      private String divPorcentajehierro_container_Internalname ;
      private String lbllbl49_Internalname ;
      private String lbllbl49_Jsonclick ;
      private String edtavPorcentajehierro_Internalname ;
      private String edtavPorcentajehierro_Jsonclick ;
      private String divMtotros_container_Internalname ;
      private String lbllbl55_Internalname ;
      private String lbllbl55_Jsonclick ;
      private String edtavMtotros_Internalname ;
      private String edtavMtotros_Jsonclick ;
      private String divPorcentajeotros_container_Internalname ;
      private String lbllbl60_Internalname ;
      private String lbllbl60_Jsonclick ;
      private String edtavPorcentajeotros_Internalname ;
      private String edtavPorcentajeotros_Jsonclick ;
      private String divTotalmt_container_Internalname ;
      private String lbllbl66_Internalname ;
      private String lbllbl66_Jsonclick ;
      private String edtavTotalmt_Internalname ;
      private String edtavTotalmt_Jsonclick ;
      private String divTotalptje_container_Internalname ;
      private String lbllbl71_Internalname ;
      private String lbllbl71_Jsonclick ;
      private String edtavTotalptje_Internalname ;
      private String edtavTotalptje_Jsonclick ;
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
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDefault ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtSDTGraneleros AV18SDTGraneleros ;
      private SdtSDTGraneleros GXt_SdtSDTGraneleros1 ;
   }

}
