/*
               File: Segmento1
        Description: Segmento1
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 7:38:17.49
       Program type: Main program
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
   public class segmento1 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public segmento1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public segmento1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_P1 ,
                           String aP1_P2 )
      {
         this.AV45P1 = aP0_P1;
         this.AV46P2 = aP1_P2;
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
            if ( ! entryPointCalled )
            {
               AV45P1 = gxfirstwebparm;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45P1", AV45P1);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV46P2 = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46P2", AV46P2);
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdmasterpage", "GeneXus.Programs.rwdmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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
         PA072( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START072( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20151207381752");
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("calendar-"+StringUtil.Substring( context.GetLanguageProperty( "culture"), 1, 2)+".js", "?"+context.GetBuildNumber( 86442));
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" class=\"form-horizontal Form\" novalidate action=\""+formatLink("segmento1.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV45P1)) + "," + UrlEncode(StringUtil.RTrim(AV46P2))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vP1", StringUtil.RTrim( AV45P1));
         GxWebStd.gx_hidden_field( context, "vP2", StringUtil.RTrim( AV46P2));
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
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE072( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT072( ) ;
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
         return formatLink("segmento1.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV45P1)) + "," + UrlEncode(StringUtil.RTrim(AV46P2)) ;
      }

      public override String GetPgmname( )
      {
         return "segmento1" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "Segmento1", "") ;
      }

      protected void WB070( )
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
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "Container FormContainer", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-3 col-md-3 WWAdvancedBarCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAdvancedcontainer_Internalname, 1, 0, "px", 0, "px", "AdvancedContainer", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSolicitudfechafiltercontainer_Internalname, 1, 0, "px", 0, "px", "AdvancedContainerItem", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblsolicitudfechafilter_Internalname, context.GetMessage( "Fecha del horario", ""), "", "", lblLblsolicitudfechafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "WWAdvancedLabel WWDateFilterLabel", 0, "", 1, 1, 1, "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 WWFiltersCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavSolicitudfecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavSolicitudfecha_Internalname, context.localUtil.Format(AV58SolicitudFecha, "99/99/9999"), context.localUtil.Format( AV58SolicitudFecha, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'"+context.GetLanguageProperty( "date_fmt")+"',0,"+context.GetLanguageProperty( "time_fmt")+",'"+context.GetLanguageProperty( "code")+"',false,0);"+";gx.evt.onblur(17);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSolicitudfecha_Jsonclick, 0, "ReadonlyAttribute", "", "", "", 1, edtavSolicitudfecha_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, false, "", "right", "HLP_Segmento1.htm");
            GxWebStd.gx_bitmap( context, edtavSolicitudfecha_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavSolicitudfecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", 1, false, false, "HLP_Segmento1.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            GxWebStd.gx_div_start( context, divFiltroipfiltercontainer_Internalname, 1, 0, "px", 0, "px", "AdvancedContainerItem", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblfiltroipfilter_Internalname, context.GetMessage( "Empleado (IP)", ""), "", "", lblLblfiltroipfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "WWAdvancedLabel WWFilterLabel", 0, "", 1, 1, 1, "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 WWFiltersCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavFiltroip_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV24filtroIP), 9, 0, context.GetLanguageProperty( "decimal_point"), "")), ((edtavFiltroip_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV24filtroIP), "ZZZZZZZZZ")) : context.localUtil.Format( (decimal)(AV24filtroIP), "ZZZZZZZZZ")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,gx.thousandSeparator);"+";gx.evt.onblur(27);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavFiltroip_Jsonclick, 0, "Attribute", "", "", "", 1, edtavFiltroip_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, false, "", "right", "HLP_Segmento1.htm");
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
            GxWebStd.gx_div_start( context, divNombrecortofiltercontainer_Internalname, 1, 0, "px", 0, "px", "AdvancedContainerItem", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblnombrecorto_Internalname, context.GetMessage( "Nombre Corto", ""), "", "", lblLblnombrecorto_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "WWAdvancedLabel WWFilterLabel", 0, "", 1, 1, 1, "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 WWFiltersCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavNombrecorto_Internalname, StringUtil.RTrim( AV34NombreCorto), StringUtil.RTrim( context.localUtil.Format( AV34NombreCorto, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(37);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavNombrecorto_Jsonclick, 0, "Attribute", "", "", "", 1, edtavNombrecorto_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, false, "", "left", "HLP_Segmento1.htm");
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
            GxWebStd.gx_div_start( context, divTable2_Internalname, 1, 0, "px", 0, "px", "AdvancedContainerItem", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-9 col-xs-offset-3 col-sm-12 col-sm-offset-0", " "+"id"+" ");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttRefresh_Internalname, "", context.GetMessage( "Buscar", ""), bttRefresh_Jsonclick, 5, context.GetMessage( "Buscar", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BUSCAR\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTipousuario_Internalname, StringUtil.RTrim( AV59TIPOUSUARIO), StringUtil.RTrim( context.localUtil.Format( AV59TIPOUSUARIO, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(47);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTipousuario_Jsonclick, 0, "Attribute", "", "", "", 1, edtavTipousuario_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 col-md-9", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtable_Internalname, 1, 0, "px", 0, "px", "Table", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-9 col-sm-6 col-md-3", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitletext_Internalname, context.GetMessage( "Horario Semanal", ""), "", "", lblTitletext_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "SubTitle", 0, "", 1, 1, 0, "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-3 col-sm-3 hidden-sm col-md-3 hidden-md hidden-lg ToggleCell", " "+"id"+" ");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            ClassString = "BtnToggle";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "", "|||", bttBtntoggle_Jsonclick, 5, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'TOGGLE\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 col-md-6", " "+"id"+" ");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 col-sm-12 col-md-12 col-md-offset-0", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divColaborador_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl60_Internalname, context.GetMessage( "Colaborador", ""), "", "", lbllbl60_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_Segmento1.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavColaborador_Internalname, StringUtil.RTrim( AV7COLABORADOR), StringUtil.RTrim( context.localUtil.Format( AV7COLABORADOR, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(62);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavColaborador_Jsonclick, 0, "Attribute", "", "", "", 1, edtavColaborador_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 col-sm-4 col-md-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divFechapantalla_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl65_Internalname, context.GetMessage( "Fecha Horario", ""), "", "", lbllbl65_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_Segmento1.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavFechapantalla_Internalname, StringUtil.RTrim( AV23FechaPantalla), StringUtil.RTrim( context.localUtil.Format( AV23FechaPantalla, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(67);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavFechapantalla_Jsonclick, 0, "Attribute", "", "", "", 1, edtavFechapantalla_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 col-sm-4 col-md-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divDomingohorariosemanalpantalla_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl70_Internalname, context.GetMessage( "Horario Semanal", ""), "", "", lbllbl70_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_Segmento1.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavDomingohorariosemanalpantalla_Internalname, StringUtil.RTrim( AV18DomingoHorarioSemanalPantalla), StringUtil.RTrim( context.localUtil.Format( AV18DomingoHorarioSemanalPantalla, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(72);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDomingohorariosemanalpantalla_Jsonclick, 0, "Attribute", "", "", "", 1, edtavDomingohorariosemanalpantalla_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 col-sm-4 col-md-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divRemolcador_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl75_Internalname, context.GetMessage( "Remolcador", ""), "", "", lbllbl75_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_Segmento1.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavRemolcador_Internalname, StringUtil.RTrim( AV51Remolcador), StringUtil.RTrim( context.localUtil.Format( AV51Remolcador, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(77);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavRemolcador_Jsonclick, 0, "Attribute", "", "", "", 1, edtavRemolcador_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-offset-0 col-sm-12 col-sm-offset-0 WWOptionalColumnTurno", " "+"id"+" ");
            wb_table1_80_072( true) ;
         }
         else
         {
            wb_table1_80_072( false) ;
         }
         return  ;
      }

      protected void wb_table1_80_072e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            /* Control Group */
            GxWebStd.gx_group_start( context, grpGroup1_Internalname, context.GetMessage( "Tripulación", ""), 1, 0, "px", 0, "px", "Group", "", "HLP_Segmento1.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGroup1table_Internalname, 1, 0, "px", 0, "px", "Table", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaster_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl169_Internalname, context.GetMessage( "Master", ""), "", "", lbllbl169_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_Segmento1.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 171,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavMaster_Internalname, StringUtil.RTrim( AV31Master), StringUtil.RTrim( context.localUtil.Format( AV31Master, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(171);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavMaster_Jsonclick, 0, "Attribute", "", "", "", 1, edtavMaster_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divEngineer_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl175_Internalname, context.GetMessage( "Engineer", ""), "", "", lbllbl175_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_Segmento1.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 177,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavEngineer_Internalname, StringUtil.RTrim( AV20Engineer), StringUtil.RTrim( context.localUtil.Format( AV20Engineer, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(177);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEngineer_Jsonclick, 0, "Attribute", "", "", "", 1, edtavEngineer_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSeaman1_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl181_Internalname, context.GetMessage( "Seaman 1", ""), "", "", lbllbl181_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_Segmento1.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 183,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSeaman1_Internalname, StringUtil.RTrim( AV54Seaman1), StringUtil.RTrim( context.localUtil.Format( AV54Seaman1, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(183);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSeaman1_Jsonclick, 0, "Attribute", "", "", "", 1, edtavSeaman1_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divSeaman2_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl187_Internalname, context.GetMessage( "Seaman 2", ""), "", "", lbllbl187_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_Segmento1.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 189,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSeaman2_Internalname, StringUtil.RTrim( AV55Seaman2), StringUtil.RTrim( context.localUtil.Format( AV55Seaman2, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(189);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSeaman2_Jsonclick, 0, "Attribute", "", "", "", 1, edtavSeaman2_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divBosnseaman_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl193_Internalname, context.GetMessage( "Bosn Seaman", ""), "", "", lbllbl193_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_Segmento1.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 195,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBosnseaman_Internalname, StringUtil.RTrim( AV6BosnSeaman), StringUtil.RTrim( context.localUtil.Format( AV6BosnSeaman, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(195);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBosnseaman_Jsonclick, 0, "Attribute", "", "", "", 1, edtavBosnseaman_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divOiler_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl199_Internalname, context.GetMessage( "Oiler", ""), "", "", lbllbl199_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_Segmento1.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 201,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOiler_Internalname, StringUtil.RTrim( AV42Oiler), StringUtil.RTrim( context.localUtil.Format( AV42Oiler, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(201);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOiler_Jsonclick, 0, "Attribute", "", "", "", 1, edtavOiler_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMate_container_Internalname, 1, 0, "px", 0, "px", "form-group gx-form-group", "");
            context.WriteHtmlText( "<label class=\"control-label gx-label col-sm-3\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lbllbl205_Internalname, context.GetMessage( "Mate", ""), "", "", lbllbl205_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_Segmento1.htm");
            context.WriteHtmlText( "</label>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 207,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavMate_Internalname, StringUtil.RTrim( AV32Mate), StringUtil.RTrim( context.localUtil.Format( AV32Mate, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(207);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavMate_Jsonclick, 0, "Attribute", "", "", "", 1, edtavMate_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-md-2", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblJsscript_Internalname, context.GetMessage( "Text Block", ""), "", "", lblJsscript_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 2, "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
         }
         wbLoad = true;
      }

      protected void START072( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 10_3_2-86442", 0) ;
            Form.Meta.addItem("description", context.GetMessage( "Segmento1", ""), 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP070( ) ;
      }

      protected void WS072( )
      {
         START072( ) ;
         EVT072( ) ;
      }

      protected void EVT072( )
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
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: E11072 */
                              E11072 ();
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
                           else if ( StringUtil.StrCmp(sEvt, "'BUSCAR'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'TOGGLE'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
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
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE072( )
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

      protected void PA072( )
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
               GX_FocusControl = edtavSolicitudfecha_Internalname;
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
         RF072( ) ;
      }

      protected void RF072( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavColaborador_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavColaborador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavColaborador_Enabled), 5, 0)));
         edtavFechapantalla_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavFechapantalla_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavFechapantalla_Enabled), 5, 0)));
         edtavDomingohorariosemanalpantalla_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDomingohorariosemanalpantalla_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDomingohorariosemanalpantalla_Enabled), 5, 0)));
         edtavRemolcador_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavRemolcador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavRemolcador_Enabled), 5, 0)));
         edtavNumdia1_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNumdia1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNumdia1_Enabled), 5, 0)));
         edtavNumdia2_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNumdia2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNumdia2_Enabled), 5, 0)));
         edtavNumdia3_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNumdia3_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNumdia3_Enabled), 5, 0)));
         edtavNumdia4_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNumdia4_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNumdia4_Enabled), 5, 0)));
         edtavNumdia5_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNumdia5_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNumdia5_Enabled), 5, 0)));
         edtavNumdia6_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNumdia6_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNumdia6_Enabled), 5, 0)));
         edtavNumdia7_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNumdia7_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNumdia7_Enabled), 5, 0)));
         edtavTurno1_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTurno1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTurno1_Enabled), 5, 0)));
         edtavTurno2_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTurno2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTurno2_Enabled), 5, 0)));
         edtavTurno3_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTurno3_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTurno3_Enabled), 5, 0)));
         edtavTurno4_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTurno4_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTurno4_Enabled), 5, 0)));
         edtavTurno5_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTurno5_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTurno5_Enabled), 5, 0)));
         edtavTurno6_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTurno6_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTurno6_Enabled), 5, 0)));
         edtavTurno7_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTurno7_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTurno7_Enabled), 5, 0)));
         edtavDia1turnootro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDia1turnootro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDia1turnootro_Enabled), 5, 0)));
         edtavDia2turnootro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDia2turnootro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDia2turnootro_Enabled), 5, 0)));
         edtavDia3turnootro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDia3turnootro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDia3turnootro_Enabled), 5, 0)));
         edtavDia4turnootro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDia4turnootro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDia4turnootro_Enabled), 5, 0)));
         edtavDia5turnootro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDia5turnootro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDia5turnootro_Enabled), 5, 0)));
         edtavDia6turnootro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDia6turnootro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDia6turnootro_Enabled), 5, 0)));
         edtavDia7turnootro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDia7turnootro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDia7turnootro_Enabled), 5, 0)));
         edtavMaster_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavMaster_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavMaster_Enabled), 5, 0)));
         edtavEngineer_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEngineer_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEngineer_Enabled), 5, 0)));
         edtavSeaman1_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSeaman1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSeaman1_Enabled), 5, 0)));
         edtavSeaman2_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSeaman2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSeaman2_Enabled), 5, 0)));
         edtavBosnseaman_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBosnseaman_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBosnseaman_Enabled), 5, 0)));
         edtavOiler_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOiler_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOiler_Enabled), 5, 0)));
         edtavMate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavMate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavMate_Enabled), 5, 0)));
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E11072 */
            E11072 ();
            WB070( ) ;
         }
      }

      protected void STRUP070( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavColaborador_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavColaborador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavColaborador_Enabled), 5, 0)));
         edtavFechapantalla_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavFechapantalla_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavFechapantalla_Enabled), 5, 0)));
         edtavDomingohorariosemanalpantalla_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDomingohorariosemanalpantalla_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDomingohorariosemanalpantalla_Enabled), 5, 0)));
         edtavRemolcador_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavRemolcador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavRemolcador_Enabled), 5, 0)));
         edtavNumdia1_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNumdia1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNumdia1_Enabled), 5, 0)));
         edtavNumdia2_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNumdia2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNumdia2_Enabled), 5, 0)));
         edtavNumdia3_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNumdia3_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNumdia3_Enabled), 5, 0)));
         edtavNumdia4_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNumdia4_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNumdia4_Enabled), 5, 0)));
         edtavNumdia5_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNumdia5_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNumdia5_Enabled), 5, 0)));
         edtavNumdia6_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNumdia6_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNumdia6_Enabled), 5, 0)));
         edtavNumdia7_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavNumdia7_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavNumdia7_Enabled), 5, 0)));
         edtavTurno1_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTurno1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTurno1_Enabled), 5, 0)));
         edtavTurno2_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTurno2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTurno2_Enabled), 5, 0)));
         edtavTurno3_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTurno3_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTurno3_Enabled), 5, 0)));
         edtavTurno4_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTurno4_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTurno4_Enabled), 5, 0)));
         edtavTurno5_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTurno5_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTurno5_Enabled), 5, 0)));
         edtavTurno6_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTurno6_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTurno6_Enabled), 5, 0)));
         edtavTurno7_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTurno7_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTurno7_Enabled), 5, 0)));
         edtavDia1turnootro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDia1turnootro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDia1turnootro_Enabled), 5, 0)));
         edtavDia2turnootro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDia2turnootro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDia2turnootro_Enabled), 5, 0)));
         edtavDia3turnootro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDia3turnootro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDia3turnootro_Enabled), 5, 0)));
         edtavDia4turnootro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDia4turnootro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDia4turnootro_Enabled), 5, 0)));
         edtavDia5turnootro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDia5turnootro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDia5turnootro_Enabled), 5, 0)));
         edtavDia6turnootro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDia6turnootro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDia6turnootro_Enabled), 5, 0)));
         edtavDia7turnootro_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDia7turnootro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDia7turnootro_Enabled), 5, 0)));
         edtavMaster_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavMaster_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavMaster_Enabled), 5, 0)));
         edtavEngineer_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEngineer_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEngineer_Enabled), 5, 0)));
         edtavSeaman1_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSeaman1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSeaman1_Enabled), 5, 0)));
         edtavSeaman2_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSeaman2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSeaman2_Enabled), 5, 0)));
         edtavBosnseaman_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBosnseaman_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBosnseaman_Enabled), 5, 0)));
         edtavOiler_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOiler_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOiler_Enabled), 5, 0)));
         edtavMate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavMate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavMate_Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            AV45P1 = cgiGet( "vP1");
            AV46P2 = cgiGet( "vP2");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E11072( )
      {
         /* Load Routine */
      }

      protected void wb_table1_80_072( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "WWOptionalColumnTurno", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"WWGridCell\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, context.GetMessage( "  SUN", ""), "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "FieldSetTitle", 0, "", 1, 1, 0, "HLP_Segmento1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"WWGridCell\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, context.GetMessage( "  MON", ""), "", "", lblTextblock2_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "FieldSetTitle", 0, "", 1, 1, 0, "HLP_Segmento1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"WWGridCell\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, context.GetMessage( "  TUE", ""), "", "", lblTextblock3_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "FieldSetTitle", 0, "", 1, 1, 0, "HLP_Segmento1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"WWGridCell\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, context.GetMessage( "  WED", ""), "", "", lblTextblock4_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "FieldSetTitle", 0, "", 1, 1, 0, "HLP_Segmento1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"WWGridCell\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, context.GetMessage( "  THU", ""), "", "", lblTextblock5_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "FieldSetTitle", 0, "", 1, 1, 0, "HLP_Segmento1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"WWGridCell\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, context.GetMessage( "  FRI", ""), "", "", lblTextblock6_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "FieldSetTitle", 0, "", 1, 1, 0, "HLP_Segmento1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"WWGridCell\" >") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock7_Internalname, context.GetMessage( "  SAT", ""), "", "", lblTextblock7_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "FieldSetTitle", 0, "", 1, 1, 0, "HLP_Segmento1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"WWGridCell\" >") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavNumdia1_Internalname, StringUtil.RTrim( AV35NumDia1), StringUtil.RTrim( context.localUtil.Format( AV35NumDia1, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(99);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavNumdia1_Jsonclick, 0, "FieldSetTitle", "", "", "", 1, edtavNumdia1_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 1, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"WWGridCell\" >") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 102,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavNumdia2_Internalname, StringUtil.RTrim( AV36NumDia2), StringUtil.RTrim( context.localUtil.Format( AV36NumDia2, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(102);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavNumdia2_Jsonclick, 0, "FieldSetTitle", "", "", "", 1, edtavNumdia2_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 1, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"WWGridCell\" >") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 105,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavNumdia3_Internalname, StringUtil.RTrim( AV37NumDia3), StringUtil.RTrim( context.localUtil.Format( AV37NumDia3, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(105);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavNumdia3_Jsonclick, 0, "FieldSetTitle", "", "", "", 1, edtavNumdia3_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 1, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"WWGridCell\" >") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 108,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavNumdia4_Internalname, StringUtil.RTrim( AV38NumDia4), StringUtil.RTrim( context.localUtil.Format( AV38NumDia4, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(108);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavNumdia4_Jsonclick, 0, "FieldSetTitle", "", "", "", 1, edtavNumdia4_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 1, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"WWGridCell\" >") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 111,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavNumdia5_Internalname, StringUtil.RTrim( AV39NumDia5), StringUtil.RTrim( context.localUtil.Format( AV39NumDia5, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(111);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavNumdia5_Jsonclick, 0, "FieldSetTitle", "", "", "", 1, edtavNumdia5_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 1, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"WWGridCell\" >") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 114,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavNumdia6_Internalname, StringUtil.RTrim( AV40NumDia6), StringUtil.RTrim( context.localUtil.Format( AV40NumDia6, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(114);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavNumdia6_Jsonclick, 0, "FieldSetTitle", "", "", "", 1, edtavNumdia6_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 1, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"WWGridCell\" >") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 117,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavNumdia7_Internalname, StringUtil.RTrim( AV41NumDia7), StringUtil.RTrim( context.localUtil.Format( AV41NumDia7, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(117);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavNumdia7_Jsonclick, 0, "FieldSetTitle", "", "", "", 1, edtavNumdia7_Enabled, 0, "text", "", 5, "chr", 1, "row", 5, 0, 0, 0, 1, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 121,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTurno1_Internalname, StringUtil.RTrim( AV62Turno1), StringUtil.RTrim( context.localUtil.Format( AV62Turno1, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(121);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTurno1_Jsonclick, 0, "", "", "", "", 1, edtavTurno1_Enabled, 0, "text", "", 2, "chr", 1, "row", 2, 0, 0, 0, 0, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 124,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTurno2_Internalname, StringUtil.RTrim( AV63Turno2), StringUtil.RTrim( context.localUtil.Format( AV63Turno2, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(124);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTurno2_Jsonclick, 0, "", "", "", "", 1, edtavTurno2_Enabled, 0, "text", "", 2, "chr", 1, "row", 2, 0, 0, 0, 0, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 127,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTurno3_Internalname, StringUtil.RTrim( AV64Turno3), StringUtil.RTrim( context.localUtil.Format( AV64Turno3, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(127);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTurno3_Jsonclick, 0, "", "", "", "", 1, edtavTurno3_Enabled, 0, "text", "", 2, "chr", 1, "row", 2, 0, 0, 0, 0, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 130,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTurno4_Internalname, StringUtil.RTrim( AV65Turno4), StringUtil.RTrim( context.localUtil.Format( AV65Turno4, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(130);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTurno4_Jsonclick, 0, "", "", "", "", 1, edtavTurno4_Enabled, 0, "text", "", 2, "chr", 1, "row", 2, 0, 0, 0, 0, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 133,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTurno5_Internalname, StringUtil.RTrim( AV66Turno5), StringUtil.RTrim( context.localUtil.Format( AV66Turno5, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(133);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTurno5_Jsonclick, 0, "", "", "", "", 1, edtavTurno5_Enabled, 0, "text", "", 2, "chr", 1, "row", 2, 0, 0, 0, 0, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 136,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTurno6_Internalname, StringUtil.RTrim( AV67Turno6), StringUtil.RTrim( context.localUtil.Format( AV67Turno6, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(136);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTurno6_Jsonclick, 0, "", "", "", "", 1, edtavTurno6_Enabled, 0, "text", "", 2, "chr", 1, "row", 2, 0, 0, 0, 0, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 139,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTurno7_Internalname, StringUtil.RTrim( AV68Turno7), StringUtil.RTrim( context.localUtil.Format( AV68Turno7, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(139);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTurno7_Jsonclick, 0, "", "", "", "", 1, edtavTurno7_Enabled, 0, "text", "", 2, "chr", 1, "row", 2, 0, 0, 0, 0, 1, -1, false, "", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 143,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavDia1turnootro_Internalname, StringUtil.RTrim( AV10Dia1TurnoOtro), StringUtil.RTrim( context.localUtil.Format( AV10Dia1TurnoOtro, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(143);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDia1turnootro_Jsonclick, 0, "", "", "", "", 1, edtavDia1turnootro_Enabled, 0, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 0, 1, -1, false, "TurnoOtro", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 146,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavDia2turnootro_Internalname, StringUtil.RTrim( AV11Dia2TurnoOtro), StringUtil.RTrim( context.localUtil.Format( AV11Dia2TurnoOtro, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(146);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDia2turnootro_Jsonclick, 0, "", "", "", "", 1, edtavDia2turnootro_Enabled, 0, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 0, 1, -1, false, "TurnoOtro", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 149,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavDia3turnootro_Internalname, StringUtil.RTrim( AV12Dia3TurnoOtro), StringUtil.RTrim( context.localUtil.Format( AV12Dia3TurnoOtro, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(149);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDia3turnootro_Jsonclick, 0, "", "", "", "", 1, edtavDia3turnootro_Enabled, 0, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 0, 1, -1, false, "TurnoOtro", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 152,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavDia4turnootro_Internalname, StringUtil.RTrim( AV13Dia4TurnoOtro), StringUtil.RTrim( context.localUtil.Format( AV13Dia4TurnoOtro, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(152);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDia4turnootro_Jsonclick, 0, "", "", "", "", 1, edtavDia4turnootro_Enabled, 0, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 0, 1, -1, false, "TurnoOtro", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 155,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavDia5turnootro_Internalname, StringUtil.RTrim( AV14Dia5TurnoOtro), StringUtil.RTrim( context.localUtil.Format( AV14Dia5TurnoOtro, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(155);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDia5turnootro_Jsonclick, 0, "", "", "", "", 1, edtavDia5turnootro_Enabled, 0, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 0, 1, -1, false, "TurnoOtro", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 158,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavDia6turnootro_Internalname, StringUtil.RTrim( AV15Dia6TurnoOtro), StringUtil.RTrim( context.localUtil.Format( AV15Dia6TurnoOtro, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(158);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDia6turnootro_Jsonclick, 0, "", "", "", "", 1, edtavDia6turnootro_Enabled, 0, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 0, 1, -1, false, "TurnoOtro", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\"\" class=\"\" >") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 161,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavDia7turnootro_Internalname, StringUtil.RTrim( AV16Dia7TurnoOtro), StringUtil.RTrim( context.localUtil.Format( AV16Dia7TurnoOtro, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(161);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDia7turnootro_Jsonclick, 0, "", "", "", "", 1, edtavDia7turnootro_Enabled, 0, "text", "", 3, "chr", 1, "row", 3, 0, 0, 0, 0, 1, -1, false, "TurnoOtro", "left", "HLP_Segmento1.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_80_072e( true) ;
         }
         else
         {
            wb_table1_80_072e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV45P1 = (String)getParm(obj,0);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45P1", AV45P1);
         AV46P2 = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV46P2", AV46P2);
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
         PA072( ) ;
         WS072( ) ;
         WE072( ) ;
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
         AddStyleSheetFile("calendar-system.css", "?1451520");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?738724");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20151207381959");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages."+context.GetLanguageProperty( "code")+".js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("segmento1.js", "?20151207381959");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         div_Internalname = "";
         div_Internalname = "";
         lblLblsolicitudfechafilter_Internalname = "LBLSOLICITUDFECHAFILTER";
         lblLblsolicitudfechafilter_Internalname = "LBLSOLICITUDFECHAFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavSolicitudfecha_Internalname = "vSOLICITUDFECHA";
         edtavSolicitudfecha_Internalname = "vSOLICITUDFECHA";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divSolicitudfechafiltercontainer_Internalname = "SOLICITUDFECHAFILTERCONTAINER";
         divSolicitudfechafiltercontainer_Internalname = "SOLICITUDFECHAFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLblfiltroipfilter_Internalname = "LBLFILTROIPFILTER";
         lblLblfiltroipfilter_Internalname = "LBLFILTROIPFILTER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavFiltroip_Internalname = "vFILTROIP";
         edtavFiltroip_Internalname = "vFILTROIP";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divFiltroipfiltercontainer_Internalname = "FILTROIPFILTERCONTAINER";
         divFiltroipfiltercontainer_Internalname = "FILTROIPFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblLblnombrecorto_Internalname = "LBLNOMBRECORTO";
         lblLblnombrecorto_Internalname = "LBLNOMBRECORTO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavNombrecorto_Internalname = "vNOMBRECORTO";
         edtavNombrecorto_Internalname = "vNOMBRECORTO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divNombrecortofiltercontainer_Internalname = "NOMBRECORTOFILTERCONTAINER";
         divNombrecortofiltercontainer_Internalname = "NOMBRECORTOFILTERCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         bttRefresh_Internalname = "REFRESH";
         bttRefresh_Internalname = "REFRESH";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divTable2_Internalname = "TABLE2";
         divTable2_Internalname = "TABLE2";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         edtavTipousuario_Internalname = "vTIPOUSUARIO";
         edtavTipousuario_Internalname = "vTIPOUSUARIO";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lblTitletext_Internalname = "TITLETEXT";
         lblTitletext_Internalname = "TITLETEXT";
         div_Internalname = "";
         div_Internalname = "";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl60_Internalname = "LBL60";
         lbllbl60_Internalname = "LBL60";
         edtavColaborador_Internalname = "vCOLABORADOR";
         edtavColaborador_Internalname = "vCOLABORADOR";
         div_Internalname = "";
         div_Internalname = "";
         divColaborador_container_Internalname = "COLABORADOR_CONTAINER";
         divColaborador_container_Internalname = "COLABORADOR_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl65_Internalname = "LBL65";
         lbllbl65_Internalname = "LBL65";
         edtavFechapantalla_Internalname = "vFECHAPANTALLA";
         edtavFechapantalla_Internalname = "vFECHAPANTALLA";
         div_Internalname = "";
         div_Internalname = "";
         divFechapantalla_container_Internalname = "FECHAPANTALLA_CONTAINER";
         divFechapantalla_container_Internalname = "FECHAPANTALLA_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl70_Internalname = "LBL70";
         lbllbl70_Internalname = "LBL70";
         edtavDomingohorariosemanalpantalla_Internalname = "vDOMINGOHORARIOSEMANALPANTALLA";
         edtavDomingohorariosemanalpantalla_Internalname = "vDOMINGOHORARIOSEMANALPANTALLA";
         div_Internalname = "";
         div_Internalname = "";
         divDomingohorariosemanalpantalla_container_Internalname = "DOMINGOHORARIOSEMANALPANTALLA_CONTAINER";
         divDomingohorariosemanalpantalla_container_Internalname = "DOMINGOHORARIOSEMANALPANTALLA_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl75_Internalname = "LBL75";
         lbllbl75_Internalname = "LBL75";
         edtavRemolcador_Internalname = "vREMOLCADOR";
         edtavRemolcador_Internalname = "vREMOLCADOR";
         div_Internalname = "";
         div_Internalname = "";
         divRemolcador_container_Internalname = "REMOLCADOR_CONTAINER";
         divRemolcador_container_Internalname = "REMOLCADOR_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblTextblock1_Internalname = "TEXTBLOCK1";
         lblTextblock1_Internalname = "TEXTBLOCK1";
         lblTextblock2_Internalname = "TEXTBLOCK2";
         lblTextblock2_Internalname = "TEXTBLOCK2";
         lblTextblock3_Internalname = "TEXTBLOCK3";
         lblTextblock3_Internalname = "TEXTBLOCK3";
         lblTextblock4_Internalname = "TEXTBLOCK4";
         lblTextblock4_Internalname = "TEXTBLOCK4";
         lblTextblock5_Internalname = "TEXTBLOCK5";
         lblTextblock5_Internalname = "TEXTBLOCK5";
         lblTextblock6_Internalname = "TEXTBLOCK6";
         lblTextblock6_Internalname = "TEXTBLOCK6";
         lblTextblock7_Internalname = "TEXTBLOCK7";
         lblTextblock7_Internalname = "TEXTBLOCK7";
         edtavNumdia1_Internalname = "vNUMDIA1";
         edtavNumdia1_Internalname = "vNUMDIA1";
         div_Internalname = "";
         div_Internalname = "";
         edtavNumdia2_Internalname = "vNUMDIA2";
         edtavNumdia2_Internalname = "vNUMDIA2";
         div_Internalname = "";
         div_Internalname = "";
         edtavNumdia3_Internalname = "vNUMDIA3";
         edtavNumdia3_Internalname = "vNUMDIA3";
         div_Internalname = "";
         div_Internalname = "";
         edtavNumdia4_Internalname = "vNUMDIA4";
         edtavNumdia4_Internalname = "vNUMDIA4";
         div_Internalname = "";
         div_Internalname = "";
         edtavNumdia5_Internalname = "vNUMDIA5";
         edtavNumdia5_Internalname = "vNUMDIA5";
         div_Internalname = "";
         div_Internalname = "";
         edtavNumdia6_Internalname = "vNUMDIA6";
         edtavNumdia6_Internalname = "vNUMDIA6";
         div_Internalname = "";
         div_Internalname = "";
         edtavNumdia7_Internalname = "vNUMDIA7";
         edtavNumdia7_Internalname = "vNUMDIA7";
         div_Internalname = "";
         div_Internalname = "";
         edtavTurno1_Internalname = "vTURNO1";
         edtavTurno1_Internalname = "vTURNO1";
         div_Internalname = "";
         div_Internalname = "";
         edtavTurno2_Internalname = "vTURNO2";
         edtavTurno2_Internalname = "vTURNO2";
         div_Internalname = "";
         div_Internalname = "";
         edtavTurno3_Internalname = "vTURNO3";
         edtavTurno3_Internalname = "vTURNO3";
         div_Internalname = "";
         div_Internalname = "";
         edtavTurno4_Internalname = "vTURNO4";
         edtavTurno4_Internalname = "vTURNO4";
         div_Internalname = "";
         div_Internalname = "";
         edtavTurno5_Internalname = "vTURNO5";
         edtavTurno5_Internalname = "vTURNO5";
         div_Internalname = "";
         div_Internalname = "";
         edtavTurno6_Internalname = "vTURNO6";
         edtavTurno6_Internalname = "vTURNO6";
         div_Internalname = "";
         div_Internalname = "";
         edtavTurno7_Internalname = "vTURNO7";
         edtavTurno7_Internalname = "vTURNO7";
         div_Internalname = "";
         div_Internalname = "";
         edtavDia1turnootro_Internalname = "vDIA1TURNOOTRO";
         edtavDia1turnootro_Internalname = "vDIA1TURNOOTRO";
         div_Internalname = "";
         div_Internalname = "";
         edtavDia2turnootro_Internalname = "vDIA2TURNOOTRO";
         edtavDia2turnootro_Internalname = "vDIA2TURNOOTRO";
         div_Internalname = "";
         div_Internalname = "";
         edtavDia3turnootro_Internalname = "vDIA3TURNOOTRO";
         edtavDia3turnootro_Internalname = "vDIA3TURNOOTRO";
         div_Internalname = "";
         div_Internalname = "";
         edtavDia4turnootro_Internalname = "vDIA4TURNOOTRO";
         edtavDia4turnootro_Internalname = "vDIA4TURNOOTRO";
         div_Internalname = "";
         div_Internalname = "";
         edtavDia5turnootro_Internalname = "vDIA5TURNOOTRO";
         edtavDia5turnootro_Internalname = "vDIA5TURNOOTRO";
         div_Internalname = "";
         div_Internalname = "";
         edtavDia6turnootro_Internalname = "vDIA6TURNOOTRO";
         edtavDia6turnootro_Internalname = "vDIA6TURNOOTRO";
         div_Internalname = "";
         div_Internalname = "";
         edtavDia7turnootro_Internalname = "vDIA7TURNOOTRO";
         edtavDia7turnootro_Internalname = "vDIA7TURNOOTRO";
         div_Internalname = "";
         div_Internalname = "";
         tblTable1_Internalname = "TABLE1";
         tblTable1_Internalname = "TABLE1";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl169_Internalname = "LBL169";
         lbllbl169_Internalname = "LBL169";
         edtavMaster_Internalname = "vMASTER";
         edtavMaster_Internalname = "vMASTER";
         div_Internalname = "";
         div_Internalname = "";
         divMaster_container_Internalname = "MASTER_CONTAINER";
         divMaster_container_Internalname = "MASTER_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl175_Internalname = "LBL175";
         lbllbl175_Internalname = "LBL175";
         edtavEngineer_Internalname = "vENGINEER";
         edtavEngineer_Internalname = "vENGINEER";
         div_Internalname = "";
         div_Internalname = "";
         divEngineer_container_Internalname = "ENGINEER_CONTAINER";
         divEngineer_container_Internalname = "ENGINEER_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl181_Internalname = "LBL181";
         lbllbl181_Internalname = "LBL181";
         edtavSeaman1_Internalname = "vSEAMAN1";
         edtavSeaman1_Internalname = "vSEAMAN1";
         div_Internalname = "";
         div_Internalname = "";
         divSeaman1_container_Internalname = "SEAMAN1_CONTAINER";
         divSeaman1_container_Internalname = "SEAMAN1_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl187_Internalname = "LBL187";
         lbllbl187_Internalname = "LBL187";
         edtavSeaman2_Internalname = "vSEAMAN2";
         edtavSeaman2_Internalname = "vSEAMAN2";
         div_Internalname = "";
         div_Internalname = "";
         divSeaman2_container_Internalname = "SEAMAN2_CONTAINER";
         divSeaman2_container_Internalname = "SEAMAN2_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl193_Internalname = "LBL193";
         lbllbl193_Internalname = "LBL193";
         edtavBosnseaman_Internalname = "vBOSNSEAMAN";
         edtavBosnseaman_Internalname = "vBOSNSEAMAN";
         div_Internalname = "";
         div_Internalname = "";
         divBosnseaman_container_Internalname = "BOSNSEAMAN_CONTAINER";
         divBosnseaman_container_Internalname = "BOSNSEAMAN_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl199_Internalname = "LBL199";
         lbllbl199_Internalname = "LBL199";
         edtavOiler_Internalname = "vOILER";
         edtavOiler_Internalname = "vOILER";
         div_Internalname = "";
         div_Internalname = "";
         divOiler_container_Internalname = "OILER_CONTAINER";
         divOiler_container_Internalname = "OILER_CONTAINER";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lbllbl205_Internalname = "LBL205";
         lbllbl205_Internalname = "LBL205";
         edtavMate_Internalname = "vMATE";
         edtavMate_Internalname = "vMATE";
         div_Internalname = "";
         div_Internalname = "";
         divMate_container_Internalname = "MATE_CONTAINER";
         divMate_container_Internalname = "MATE_CONTAINER";
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
         divGridtable_Internalname = "GRIDTABLE";
         divGridtable_Internalname = "GRIDTABLE";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         div_Internalname = "";
         lblJsscript_Internalname = "JSSCRIPT";
         lblJsscript_Internalname = "JSSCRIPT";
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
         edtavDia7turnootro_Jsonclick = "";
         edtavDia7turnootro_Backcolor = (int)(0x0);
         edtavDia7turnootro_Enabled = 1;
         edtavDia6turnootro_Jsonclick = "";
         edtavDia6turnootro_Backcolor = (int)(0x0);
         edtavDia6turnootro_Enabled = 1;
         edtavDia5turnootro_Jsonclick = "";
         edtavDia5turnootro_Backcolor = (int)(0x0);
         edtavDia5turnootro_Enabled = 1;
         edtavDia4turnootro_Jsonclick = "";
         edtavDia4turnootro_Backcolor = (int)(0x0);
         edtavDia4turnootro_Enabled = 1;
         edtavDia3turnootro_Jsonclick = "";
         edtavDia3turnootro_Backcolor = (int)(0x0);
         edtavDia3turnootro_Enabled = 1;
         edtavDia2turnootro_Jsonclick = "";
         edtavDia2turnootro_Backcolor = (int)(0x0);
         edtavDia2turnootro_Enabled = 1;
         edtavDia1turnootro_Jsonclick = "";
         edtavDia1turnootro_Backcolor = (int)(0x0);
         edtavDia1turnootro_Enabled = 1;
         edtavTurno7_Jsonclick = "";
         edtavTurno7_Backcolor = (int)(0x0);
         edtavTurno7_Enabled = 1;
         edtavTurno6_Jsonclick = "";
         edtavTurno6_Backcolor = (int)(0x0);
         edtavTurno6_Enabled = 1;
         edtavTurno5_Jsonclick = "";
         edtavTurno5_Backcolor = (int)(0x0);
         edtavTurno5_Enabled = 1;
         edtavTurno4_Jsonclick = "";
         edtavTurno4_Backcolor = (int)(0x0);
         edtavTurno4_Enabled = 1;
         edtavTurno3_Jsonclick = "";
         edtavTurno3_Backcolor = (int)(0x0);
         edtavTurno3_Enabled = 1;
         edtavTurno2_Jsonclick = "";
         edtavTurno2_Backcolor = (int)(0x0);
         edtavTurno2_Enabled = 1;
         edtavTurno1_Jsonclick = "";
         edtavTurno1_Backcolor = (int)(0x0);
         edtavTurno1_Enabled = 1;
         edtavNumdia7_Jsonclick = "";
         edtavNumdia7_Enabled = 1;
         edtavNumdia6_Jsonclick = "";
         edtavNumdia6_Enabled = 1;
         edtavNumdia5_Jsonclick = "";
         edtavNumdia5_Enabled = 1;
         edtavNumdia4_Jsonclick = "";
         edtavNumdia4_Enabled = 1;
         edtavNumdia3_Jsonclick = "";
         edtavNumdia3_Enabled = 1;
         edtavNumdia2_Jsonclick = "";
         edtavNumdia2_Enabled = 1;
         edtavNumdia1_Jsonclick = "";
         edtavNumdia1_Enabled = 1;
         edtavMate_Jsonclick = "";
         edtavMate_Enabled = 1;
         edtavOiler_Jsonclick = "";
         edtavOiler_Enabled = 1;
         edtavBosnseaman_Jsonclick = "";
         edtavBosnseaman_Enabled = 1;
         edtavSeaman2_Jsonclick = "";
         edtavSeaman2_Enabled = 1;
         edtavSeaman1_Jsonclick = "";
         edtavSeaman1_Enabled = 1;
         edtavEngineer_Jsonclick = "";
         edtavEngineer_Enabled = 1;
         edtavMaster_Jsonclick = "";
         edtavMaster_Enabled = 1;
         edtavRemolcador_Jsonclick = "";
         edtavRemolcador_Enabled = 1;
         edtavDomingohorariosemanalpantalla_Jsonclick = "";
         edtavDomingohorariosemanalpantalla_Enabled = 1;
         edtavFechapantalla_Jsonclick = "";
         edtavFechapantalla_Enabled = 1;
         edtavColaborador_Jsonclick = "";
         edtavColaborador_Enabled = 1;
         edtavTipousuario_Jsonclick = "";
         edtavTipousuario_Enabled = 1;
         edtavNombrecorto_Jsonclick = "";
         edtavNombrecorto_Enabled = 1;
         edtavFiltroip_Jsonclick = "";
         edtavFiltroip_Enabled = 1;
         edtavSolicitudfecha_Jsonclick = "";
         edtavSolicitudfecha_Enabled = 1;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = context.GetMessage( "Segmento1", "");
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
         wcpOAV45P1 = "";
         wcpOAV46P2 = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblsolicitudfechafilter_Jsonclick = "";
         TempTags = "";
         AV58SolicitudFecha = DateTime.MinValue;
         lblLblfiltroipfilter_Jsonclick = "";
         lblLblnombrecorto_Jsonclick = "";
         AV34NombreCorto = "";
         ClassString = "";
         StyleString = "";
         bttRefresh_Jsonclick = "";
         AV59TIPOUSUARIO = "";
         lblTitletext_Jsonclick = "";
         bttBtntoggle_Jsonclick = "";
         lbllbl60_Jsonclick = "";
         AV7COLABORADOR = "";
         lbllbl65_Jsonclick = "";
         AV23FechaPantalla = "";
         lbllbl70_Jsonclick = "";
         AV18DomingoHorarioSemanalPantalla = "";
         lbllbl75_Jsonclick = "";
         AV51Remolcador = "";
         lbllbl169_Jsonclick = "";
         AV31Master = "";
         lbllbl175_Jsonclick = "";
         AV20Engineer = "";
         lbllbl181_Jsonclick = "";
         AV54Seaman1 = "";
         lbllbl187_Jsonclick = "";
         AV55Seaman2 = "";
         lbllbl193_Jsonclick = "";
         AV6BosnSeaman = "";
         lbllbl199_Jsonclick = "";
         AV42Oiler = "";
         lbllbl205_Jsonclick = "";
         AV32Mate = "";
         lblJsscript_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXKey = "";
         sStyleString = "";
         lblTextblock1_Jsonclick = "";
         lblTextblock2_Jsonclick = "";
         lblTextblock3_Jsonclick = "";
         lblTextblock4_Jsonclick = "";
         lblTextblock5_Jsonclick = "";
         lblTextblock6_Jsonclick = "";
         lblTextblock7_Jsonclick = "";
         AV35NumDia1 = "";
         AV36NumDia2 = "";
         AV37NumDia3 = "";
         AV38NumDia4 = "";
         AV39NumDia5 = "";
         AV40NumDia6 = "";
         AV41NumDia7 = "";
         AV62Turno1 = "";
         AV63Turno2 = "";
         AV64Turno3 = "";
         AV65Turno4 = "";
         AV66Turno5 = "";
         AV67Turno6 = "";
         AV68Turno7 = "";
         AV10Dia1TurnoOtro = "";
         AV11Dia2TurnoOtro = "";
         AV12Dia3TurnoOtro = "";
         AV13Dia4TurnoOtro = "";
         AV14Dia5TurnoOtro = "";
         AV15Dia6TurnoOtro = "";
         AV16Dia7TurnoOtro = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavColaborador_Enabled = 0;
         edtavFechapantalla_Enabled = 0;
         edtavDomingohorariosemanalpantalla_Enabled = 0;
         edtavRemolcador_Enabled = 0;
         edtavNumdia1_Enabled = 0;
         edtavNumdia2_Enabled = 0;
         edtavNumdia3_Enabled = 0;
         edtavNumdia4_Enabled = 0;
         edtavNumdia5_Enabled = 0;
         edtavNumdia6_Enabled = 0;
         edtavNumdia7_Enabled = 0;
         edtavTurno1_Enabled = 0;
         edtavTurno2_Enabled = 0;
         edtavTurno3_Enabled = 0;
         edtavTurno4_Enabled = 0;
         edtavTurno5_Enabled = 0;
         edtavTurno6_Enabled = 0;
         edtavTurno7_Enabled = 0;
         edtavDia1turnootro_Enabled = 0;
         edtavDia2turnootro_Enabled = 0;
         edtavDia3turnootro_Enabled = 0;
         edtavDia4turnootro_Enabled = 0;
         edtavDia5turnootro_Enabled = 0;
         edtavDia6turnootro_Enabled = 0;
         edtavDia7turnootro_Enabled = 0;
         edtavMaster_Enabled = 0;
         edtavEngineer_Enabled = 0;
         edtavSeaman1_Enabled = 0;
         edtavSeaman2_Enabled = 0;
         edtavBosnseaman_Enabled = 0;
         edtavOiler_Enabled = 0;
         edtavMate_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int edtavSolicitudfecha_Enabled ;
      private int AV24filtroIP ;
      private int edtavFiltroip_Enabled ;
      private int edtavNombrecorto_Enabled ;
      private int edtavTipousuario_Enabled ;
      private int edtavColaborador_Enabled ;
      private int edtavFechapantalla_Enabled ;
      private int edtavDomingohorariosemanalpantalla_Enabled ;
      private int edtavRemolcador_Enabled ;
      private int edtavMaster_Enabled ;
      private int edtavEngineer_Enabled ;
      private int edtavSeaman1_Enabled ;
      private int edtavSeaman2_Enabled ;
      private int edtavBosnseaman_Enabled ;
      private int edtavOiler_Enabled ;
      private int edtavMate_Enabled ;
      private int edtavNumdia1_Enabled ;
      private int edtavNumdia2_Enabled ;
      private int edtavNumdia3_Enabled ;
      private int edtavNumdia4_Enabled ;
      private int edtavNumdia5_Enabled ;
      private int edtavNumdia6_Enabled ;
      private int edtavNumdia7_Enabled ;
      private int edtavTurno1_Enabled ;
      private int edtavTurno2_Enabled ;
      private int edtavTurno3_Enabled ;
      private int edtavTurno4_Enabled ;
      private int edtavTurno5_Enabled ;
      private int edtavTurno6_Enabled ;
      private int edtavTurno7_Enabled ;
      private int edtavDia1turnootro_Enabled ;
      private int edtavDia2turnootro_Enabled ;
      private int edtavDia3turnootro_Enabled ;
      private int edtavDia4turnootro_Enabled ;
      private int edtavDia5turnootro_Enabled ;
      private int edtavDia6turnootro_Enabled ;
      private int edtavDia7turnootro_Enabled ;
      private int idxLst ;
      private int edtavDia7turnootro_Backcolor ;
      private int edtavDia6turnootro_Backcolor ;
      private int edtavDia5turnootro_Backcolor ;
      private int edtavDia4turnootro_Backcolor ;
      private int edtavDia3turnootro_Backcolor ;
      private int edtavDia2turnootro_Backcolor ;
      private int edtavDia1turnootro_Backcolor ;
      private int edtavTurno7_Backcolor ;
      private int edtavTurno6_Backcolor ;
      private int edtavTurno5_Backcolor ;
      private int edtavTurno4_Backcolor ;
      private int edtavTurno3_Backcolor ;
      private int edtavTurno2_Backcolor ;
      private int edtavTurno1_Backcolor ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divSolicitudfechafiltercontainer_Internalname ;
      private String lblLblsolicitudfechafilter_Internalname ;
      private String lblLblsolicitudfechafilter_Jsonclick ;
      private String TempTags ;
      private String edtavSolicitudfecha_Internalname ;
      private String edtavSolicitudfecha_Jsonclick ;
      private String divFiltroipfiltercontainer_Internalname ;
      private String lblLblfiltroipfilter_Internalname ;
      private String lblLblfiltroipfilter_Jsonclick ;
      private String edtavFiltroip_Internalname ;
      private String edtavFiltroip_Jsonclick ;
      private String divNombrecortofiltercontainer_Internalname ;
      private String lblLblnombrecorto_Internalname ;
      private String lblLblnombrecorto_Jsonclick ;
      private String edtavNombrecorto_Internalname ;
      private String edtavNombrecorto_Jsonclick ;
      private String divTable2_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String bttRefresh_Internalname ;
      private String bttRefresh_Jsonclick ;
      private String edtavTipousuario_Internalname ;
      private String edtavTipousuario_Jsonclick ;
      private String divGridtable_Internalname ;
      private String lblTitletext_Internalname ;
      private String lblTitletext_Jsonclick ;
      private String bttBtntoggle_Internalname ;
      private String bttBtntoggle_Jsonclick ;
      private String divColaborador_container_Internalname ;
      private String lbllbl60_Internalname ;
      private String lbllbl60_Jsonclick ;
      private String edtavColaborador_Internalname ;
      private String edtavColaborador_Jsonclick ;
      private String divFechapantalla_container_Internalname ;
      private String lbllbl65_Internalname ;
      private String lbllbl65_Jsonclick ;
      private String edtavFechapantalla_Internalname ;
      private String edtavFechapantalla_Jsonclick ;
      private String divDomingohorariosemanalpantalla_container_Internalname ;
      private String lbllbl70_Internalname ;
      private String lbllbl70_Jsonclick ;
      private String edtavDomingohorariosemanalpantalla_Internalname ;
      private String edtavDomingohorariosemanalpantalla_Jsonclick ;
      private String divRemolcador_container_Internalname ;
      private String lbllbl75_Internalname ;
      private String lbllbl75_Jsonclick ;
      private String edtavRemolcador_Internalname ;
      private String edtavRemolcador_Jsonclick ;
      private String grpGroup1_Internalname ;
      private String divGroup1table_Internalname ;
      private String divMaster_container_Internalname ;
      private String lbllbl169_Internalname ;
      private String lbllbl169_Jsonclick ;
      private String edtavMaster_Internalname ;
      private String edtavMaster_Jsonclick ;
      private String divEngineer_container_Internalname ;
      private String lbllbl175_Internalname ;
      private String lbllbl175_Jsonclick ;
      private String edtavEngineer_Internalname ;
      private String edtavEngineer_Jsonclick ;
      private String divSeaman1_container_Internalname ;
      private String lbllbl181_Internalname ;
      private String lbllbl181_Jsonclick ;
      private String edtavSeaman1_Internalname ;
      private String edtavSeaman1_Jsonclick ;
      private String divSeaman2_container_Internalname ;
      private String lbllbl187_Internalname ;
      private String lbllbl187_Jsonclick ;
      private String edtavSeaman2_Internalname ;
      private String edtavSeaman2_Jsonclick ;
      private String divBosnseaman_container_Internalname ;
      private String lbllbl193_Internalname ;
      private String lbllbl193_Jsonclick ;
      private String edtavBosnseaman_Internalname ;
      private String edtavBosnseaman_Jsonclick ;
      private String divOiler_container_Internalname ;
      private String lbllbl199_Internalname ;
      private String lbllbl199_Jsonclick ;
      private String edtavOiler_Internalname ;
      private String edtavOiler_Jsonclick ;
      private String divMate_container_Internalname ;
      private String lbllbl205_Internalname ;
      private String lbllbl205_Jsonclick ;
      private String edtavMate_Internalname ;
      private String edtavMate_Jsonclick ;
      private String lblJsscript_Internalname ;
      private String lblJsscript_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXKey ;
      private String edtavNumdia1_Internalname ;
      private String edtavNumdia2_Internalname ;
      private String edtavNumdia3_Internalname ;
      private String edtavNumdia4_Internalname ;
      private String edtavNumdia5_Internalname ;
      private String edtavNumdia6_Internalname ;
      private String edtavNumdia7_Internalname ;
      private String edtavTurno1_Internalname ;
      private String edtavTurno2_Internalname ;
      private String edtavTurno3_Internalname ;
      private String edtavTurno4_Internalname ;
      private String edtavTurno5_Internalname ;
      private String edtavTurno6_Internalname ;
      private String edtavTurno7_Internalname ;
      private String edtavDia1turnootro_Internalname ;
      private String edtavDia2turnootro_Internalname ;
      private String edtavDia3turnootro_Internalname ;
      private String edtavDia4turnootro_Internalname ;
      private String edtavDia5turnootro_Internalname ;
      private String edtavDia6turnootro_Internalname ;
      private String edtavDia7turnootro_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String edtavNumdia1_Jsonclick ;
      private String edtavNumdia2_Jsonclick ;
      private String edtavNumdia3_Jsonclick ;
      private String edtavNumdia4_Jsonclick ;
      private String edtavNumdia5_Jsonclick ;
      private String edtavNumdia6_Jsonclick ;
      private String edtavNumdia7_Jsonclick ;
      private String edtavTurno1_Jsonclick ;
      private String edtavTurno2_Jsonclick ;
      private String edtavTurno3_Jsonclick ;
      private String edtavTurno4_Jsonclick ;
      private String edtavTurno5_Jsonclick ;
      private String edtavTurno6_Jsonclick ;
      private String edtavTurno7_Jsonclick ;
      private String edtavDia1turnootro_Jsonclick ;
      private String edtavDia2turnootro_Jsonclick ;
      private String edtavDia3turnootro_Jsonclick ;
      private String edtavDia4turnootro_Jsonclick ;
      private String edtavDia5turnootro_Jsonclick ;
      private String edtavDia6turnootro_Jsonclick ;
      private String edtavDia7turnootro_Jsonclick ;
      private String div_Internalname ;
      private DateTime AV58SolicitudFecha ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private String AV45P1 ;
      private String AV46P2 ;
      private String wcpOAV45P1 ;
      private String wcpOAV46P2 ;
      private String AV34NombreCorto ;
      private String AV59TIPOUSUARIO ;
      private String AV7COLABORADOR ;
      private String AV23FechaPantalla ;
      private String AV18DomingoHorarioSemanalPantalla ;
      private String AV51Remolcador ;
      private String AV31Master ;
      private String AV20Engineer ;
      private String AV54Seaman1 ;
      private String AV55Seaman2 ;
      private String AV6BosnSeaman ;
      private String AV42Oiler ;
      private String AV32Mate ;
      private String AV35NumDia1 ;
      private String AV36NumDia2 ;
      private String AV37NumDia3 ;
      private String AV38NumDia4 ;
      private String AV39NumDia5 ;
      private String AV40NumDia6 ;
      private String AV41NumDia7 ;
      private String AV62Turno1 ;
      private String AV63Turno2 ;
      private String AV64Turno3 ;
      private String AV65Turno4 ;
      private String AV66Turno5 ;
      private String AV67Turno6 ;
      private String AV68Turno7 ;
      private String AV10Dia1TurnoOtro ;
      private String AV11Dia2TurnoOtro ;
      private String AV12Dia3TurnoOtro ;
      private String AV13Dia4TurnoOtro ;
      private String AV14Dia5TurnoOtro ;
      private String AV15Dia6TurnoOtro ;
      private String AV16Dia7TurnoOtro ;
      private IGxDataStore dsDefault ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

}
