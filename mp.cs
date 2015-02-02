/*
               File: MP
        Description: MP
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:23:9.27
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
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.Data.SqlTypes;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class mp : GXMasterPage, System.Web.SessionState.IRequiresSessionState
   {
      public mp( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public mp( IGxContext context )
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
         cmbavSegmento = new GXCombobox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
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
            PA1X2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV14Pgmname = "MP";
               context.Gx_err = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", true, "Gx_err", StringUtil.LTrim( StringUtil.Str( (decimal)(context.Gx_err), 3, 0)));
               WS1X2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE1X2( ) ;
               }
            }
         }
         this.cleanup();
      }

      protected void RenderHtmlHeaders( )
      {
         if ( ! isFullAjaxMode( ) )
         {
            getDataAreaObject().RenderHtmlHeaders();
         }
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( ! isFullAjaxMode( ) )
         {
            getDataAreaObject().RenderHtmlOpenForm();
         }
      }

      protected void RenderHtmlCloseForm1X2( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "vPGMNAME_MPAGE", StringUtil.RTrim( AV14Pgmname));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_MPAGE_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_MPAGE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         SendSecurityToken((String)(sPrefix));
         if ( ! isFullAjaxMode( ) )
         {
            getDataAreaObject().RenderHtmlCloseForm();
         }
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( ! ( WebComp_Component1 == null ) )
         {
            WebComp_Component1.componentjscripts();
         }
         context.AddJavascriptSource("mp.js", "?20151261123929");
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
      }

      public override String GetPgmname( )
      {
         return "mp" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "MP", "") ;
      }

      protected void WB1X0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
            if ( ! ShowMPWhenPopUp( ) && context.isPopUpObject( ) )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableOutput();
               }
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
               /* Content placeholder */
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gx-content-placeholder");
               context.WriteHtmlText( ">") ;
               if ( ! isFullAjaxMode( ) )
               {
                  getDataAreaObject().RenderHtmlContent();
               }
               context.WriteHtmlText( "</div>") ;
               if ( context.isSpaRequest( ) )
               {
                  disableOutput();
               }
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
               return  ;
            }
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", " "+"data-abstract-form"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "MainContainer", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHeader_Internalname, 1, 0, "px", 0, "px", "ContainerFluid HeaderContainer", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 ToggleCell", " "+"id"+" ");
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 logoExtraSmall", " "+"id"+" ");
            /* Static images/pictures */
            ClassString = "logoExtraSmall";
            StyleString = "";
            GxWebStd.gx_bitmap( context, imgImage1_Internalname, context.GetImagePath( "1516956f-a296-47b6-a3f8-79678824352f", "", context.GetTheme( )), "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", 1, false, false, "HLP_MP.htm");
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
            GxWebStd.gx_div_start( context, divRecent_Internalname, 1, 0, "px", 0, "px", "ContainerFluid RecentLinksContainer", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 col-md-6 col-md-offset-3", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, context.GetMessage( "Calculadora de Peajes", ""), "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",true,"+"'"+"E_MPAGE."+"'", "", "SubTitle", 0, "", 1, 1, 0, "HLP_MP.htm");
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-12 col-md-3", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group gx-button ActionGroup", "");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',true,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "", context.GetMessage( "Español", ""), bttButton2_Jsonclick, 5, context.GetMessage( "Español", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",true,"+"'"+"ESET ESPAñOL_MPAGE."+"'", TempTags, "", context.GetButtonType( ), "HLP_MP.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',true,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "", context.GetMessage( "English", ""), bttButton1_Jsonclick, 5, context.GetMessage( "English", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",true,"+"'"+"EENG._MPAGE."+"'", TempTags, "", context.GetButtonType( ), "HLP_MP.htm");
            context.WriteHtmlText( "</div>") ;
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
            GxWebStd.gx_div_start( context, divMaintablex_Internalname, 1, 0, "px", 0, "px", "Container FormContainer", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-4 col-md-3 WWAdvancedBarCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAdvancedcontainer_Internalname, 1, 0, "px", 0, "px", divAdvancedcontainer_Class, "");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-11 col-xs-offset-1 col-sm-11 col-sm-offset-1", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, context.GetMessage( "Seleccione el segmento", ""), "", "", lblTextblock3_Jsonclick, "'"+""+"'"+",true,"+"'"+"E_MPAGE."+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_MP.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Control Group */
            GxWebStd.gx_group_start( context, grpGroup1_Internalname, "", 1, 0, "px", 0, "px", "Group", "", "HLP_MP.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGroup1table_Internalname, 1, 0, "px", 0, "px", "Table", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-11 col-sm-11 col-md-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',true,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavSegmento, cmbavSegmento_Internalname, AV5Segmento, 1, cmbavSegmento_Jsonclick, 5, "'"+""+"'"+",true,"+"'"+"EVSEGMENTO_MPAGE.CLICK_MPAGE."+"'", "svchar", "", 1, cmbavSegmento.Enabled, 0, 0, 40, "chr", 0, "", "", "Attribute", "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(41);\"", "", true, "HLP_MP.htm");
            cmbavSegmento.CurrentValue = AV5Segmento;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, cmbavSegmento_Internalname, "Values", (String)(cmbavSegmento.ToJavascriptSource()));
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-9 col-xs-offset-3 col-sm-9 col-sm-offset-3 hidden-sm hidden-md hidden-lg", " "+"id"+" ");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',true,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttCancel_Internalname, "", context.GetMessage( "GX_BtnCancel", ""), bttCancel_Jsonclick, 7, context.GetMessage( "GX_BtnCancel", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",true,"+"'"+"e111x1_client"+"'", TempTags, "", 2, "HLP_MP.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-8 col-md-9", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtable_Internalname, 1, 0, "px", 0, "px", "Table", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-9 col-sm-12 col-md-12", " "+"id"+" ");
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-2 col-xs-offset-1 col-sm-2 col-sm-offset-0 hidden-sm col-md-3 hidden-md hidden-lg ToggleCell", " "+"id"+" ");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',true,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",true,"+"'"+"e121x1_client"+"'", TempTags, "", 2, "HLP_MP.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-12 col-md-12 col-md-offset-0", " "+"id"+" ");
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            /* Content placeholder */
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-content-placeholder");
            context.WriteHtmlText( ">") ;
            if ( ! isFullAjaxMode( ) )
            {
               getDataAreaObject().RenderHtmlContent();
            }
            context.WriteHtmlText( "</div>") ;
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
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
            GxWebStd.gx_div_start( context, divFooter_Internalname, 1, 0, "px", 0, "px", "Footer", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, context.GetMessage( "Los resultados de los peajes presentados en esta herramienta son de carácter ilustrativo y son aproximaciones.  Los mismos no deben interpretarse como una cotización o compromiso por parte del Canal de Panamá.", ""), "", "", lblTextblock2_Jsonclick, "'"+""+"'"+",true,"+"'"+"E_MPAGE."+"'", "", "FooterText", 0, "", 1, 1, 0, "HLP_MP.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
            context.WriteHtmlText( "<a href=\"http://www.pancanal.com/eng/noticiero/copyrights.html\" class=\"FooterText\">") ;
            context.WriteHtmlText( "Copyright © 2015 Panama Canal Authority. All rights reserved.") ;
            context.WriteHtmlText( "</a>") ;
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
               GxWebStd.gx_hidden_field( context, "MPW0064"+"", StringUtil.RTrim( WebComp_Component1_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpMPW0064"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Component1_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldComponent1), StringUtil.Lower( WebComp_Component1_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpMPW0064"+"");
                  }
                  WebComp_Component1.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldComponent1), StringUtil.Lower( WebComp_Component1_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
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

      protected void START1X2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1X0( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            if ( getDataAreaObject().ExecuteStartEvent() != 0 )
            {
               setAjaxCallMode();
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
      }

      protected void WS1X2( )
      {
         START1X2( ) ;
         EVT1X2( ) ;
      }

      protected void EVT1X2( )
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
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1);
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                        if ( StringUtil.StrCmp(sEvt, "RFR_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "START_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: E131X2 */
                           E131X2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "REFRESH_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: E141X2 */
                           E141X2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "VSEGMENTO_MPAGE.CLICK_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: E151X2 */
                           E151X2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENG._MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: E161X2 */
                           E161X2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SET ESPAñOL_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: E171X2 */
                           E171X2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LOAD_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: E181X2 */
                           E181X2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER_MPAGE") == 0 )
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
                  else if ( StringUtil.StrCmp(sEvtType, "M") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-2));
                     sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-6));
                     nCmpId = (short)(NumberUtil.Val( sEvtType, "."));
                     if ( nCmpId == 64 )
                     {
                        OldComponent1 = cgiGet( "MPW0064");
                        if ( ( StringUtil.Len( OldComponent1) == 0 ) || ( StringUtil.StrCmp(OldComponent1, WebComp_Component1_Component) != 0 ) )
                        {
                           WebComp_Component1 = getWebComponent(GetType(), "GeneXus.Programs", OldComponent1, new Object[] {context} );
                           WebComp_Component1.ComponentInit();
                           WebComp_Component1.Name = "OldComponent1";
                           WebComp_Component1_Component = OldComponent1;
                        }
                        if ( StringUtil.Len( WebComp_Component1_Component) != 0 )
                        {
                           WebComp_Component1.componentprocess("MPW0064", "", sEvt);
                        }
                        WebComp_Component1_Component = OldComponent1;
                     }
                  }
                  if ( context.wbHandled == 0 )
                  {
                     getDataAreaObject().DispatchEvents();
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void WE1X2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm1X2( ) ;
            }
         }
      }

      protected void PA1X2( )
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
            cmbavSegmento.Name = "vSEGMENTO_MPAGE";
            cmbavSegmento.WebTags = "";
            cmbavSegmento.addItem("", context.GetMessage( "GX_EmptyItemText", ""), 0);
            cmbavSegmento.addItem("Portacontenedores", context.GetMessage( "Portacontenedores", ""), 0);
            cmbavSegmento.addItem("Graneles Secos", context.GetMessage( "Graneles Secos", ""), 0);
            cmbavSegmento.addItem("Tanqueros", context.GetMessage( "Tanqueros", ""), 0);
            cmbavSegmento.addItem("Quimiqueros", context.GetMessage( "Quimiqueros", ""), 0);
            cmbavSegmento.addItem("Gaseros LPG", context.GetMessage( "Gaseros LPG", ""), 0);
            cmbavSegmento.addItem("Gaseros LNG", context.GetMessage( "Gaseros LNG", ""), 0);
            cmbavSegmento.addItem("Porta Vehículos y Ro-Ro", context.GetMessage( "Portavehículos y Ro-Ro", ""), 0);
            cmbavSegmento.addItem("Pasajeros", context.GetMessage( "Pasajeros", ""), 0);
            cmbavSegmento.addItem("Refrigerados", context.GetMessage( "Refrigerados", ""), 0);
            cmbavSegmento.addItem("Carga General", context.GetMessage( "Carga General", ""), 0);
            cmbavSegmento.addItem("Otros", context.GetMessage( "Otros", ""), 0);
            if ( cmbavSegmento.ItemCount > 0 )
            {
               AV5Segmento = cmbavSegmento.getValidValue(AV5Segmento);
               context.httpAjaxContext.ajax_rsp_assign_attri("", true, "AV5Segmento", AV5Segmento);
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = cmbavSegmento_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", true, "GX_FocusControl", GX_FocusControl);
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
         RF1X2( ) ;
      }

      protected void RF1X2( )
      {
         /* GeneXus formulas. */
         AV14Pgmname = "MP";
         context.Gx_err = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", true, "Gx_err", StringUtil.LTrim( StringUtil.Str( (decimal)(context.Gx_err), 3, 0)));
         /* Execute user event: E141X2 */
         E141X2 ();
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Component1_Component) != 0 )
               {
                  WebComp_Component1.componentstart();
               }
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E181X2 */
            E181X2 ();
            WB1X0( ) ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
         }
      }

      protected void STRUP1X0( )
      {
         /* Before Start, stand alone formulas. */
         AV14Pgmname = "MP";
         context.Gx_err = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", true, "Gx_err", StringUtil.LTrim( StringUtil.Str( (decimal)(context.Gx_err), 3, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E131X2 */
         E131X2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            cmbavSegmento.CurrentValue = cgiGet( cmbavSegmento_Internalname);
            AV5Segmento = cgiGet( cmbavSegmento_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", true, "AV5Segmento", AV5Segmento);
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

      protected void GXStart( )
      {
         /* Execute user event: E131X2 */
         E131X2 ();
         if (returnInSub) return;
      }

      protected void E131X2( )
      {
         /* Start Routine */
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Meta.addItem("viewport", context.GetMessage( "width=device-width; initial-scale=1.0; maximum-scale=1.0; user-scalable=0;", ""), 0) ;
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Meta.addItem("apple-mobile-web-app-capable", context.GetMessage( "yes", ""), 0) ;
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Headerrawhtml = (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Headerrawhtml+"<link rel='stylesheet' type='text/css' href='Resources/Peaje.css' />"+StringUtil.NewLine( );
         /* Execute user subroutine: S112 */
         S112 ();
         if (returnInSub) return;
      }

      protected void E141X2( )
      {
         /* Refresh Routine */
         if ( StringUtil.StrCmp(context.GetLanguage( ), context.GetMessage( "Spanish", "")) == 0 )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Component1_Component), StringUtil.Lower( "WCNotEsp")) != 0 )
            {
               WebComp_Component1 = getWebComponent(GetType(), "GeneXus.Programs", "wcnotesp", new Object[] {context} );
               WebComp_Component1.ComponentInit();
               WebComp_Component1.Name = "WCNotEsp";
               WebComp_Component1_Component = "WCNotEsp";
            }
            if ( StringUtil.Len( WebComp_Component1_Component) != 0 )
            {
               WebComp_Component1.setjustcreated();
               WebComp_Component1.componentprepare(new Object[] {(String)"MPW0064",(String)""});
               WebComp_Component1.componentbind(new Object[] {});
            }
         }
         if ( StringUtil.StrCmp(context.GetLanguage( ), context.GetMessage( "English", "")) == 0 )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Component1_Component), StringUtil.Lower( "WCNotEng")) != 0 )
            {
               WebComp_Component1 = getWebComponent(GetType(), "GeneXus.Programs", "wcnoteng", new Object[] {context} );
               WebComp_Component1.ComponentInit();
               WebComp_Component1.Name = "WCNotEng";
               WebComp_Component1_Component = "WCNotEng";
            }
            if ( StringUtil.Len( WebComp_Component1_Component) != 0 )
            {
               WebComp_Component1.setjustcreated();
               WebComp_Component1.componentprepare(new Object[] {(String)"MPW0064",(String)""});
               WebComp_Component1.componentbind(new Object[] {});
            }
         }
         /* Execute user subroutine: S122 */
         S122 ();
         if (returnInSub) return;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "AV8GridState", AV8GridState);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "AV11GridStateFilterValue", AV11GridStateFilterValue);
      }

      protected void S112( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV9HTTPRequest.Method, "GET") == 0 )
         {
            AV8GridState.FromXml(AV10Session.Get(AV14Pgmname+"GridState"), "");
            if ( AV8GridState.gxTpr_Filtervalues.Count >= 1 )
            {
               AV5Segmento = ((SdtGridState_FilterValue)AV8GridState.gxTpr_Filtervalues.Item(1)).gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", true, "AV5Segmento", AV5Segmento);
            }
         }
      }

      protected void S122( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV8GridState.FromXml(AV10Session.Get(AV14Pgmname+"GridState"), "");
         AV8GridState.gxTpr_Filtervalues.Clear() ;
         AV11GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV11GridStateFilterValue.gxTpr_Value = AV5Segmento;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "AV11GridStateFilterValue", AV11GridStateFilterValue);
         AV8GridState.gxTpr_Filtervalues.Add(AV11GridStateFilterValue, 0) ;
         AV10Session.Set(AV14Pgmname+"GridState", AV8GridState.ToXml(false, true, "GridState", "CalcularPeajes"));
      }

      protected void E151X2( )
      {
         /* Segmento_Click Routine */
         /* Execute user subroutine: S122 */
         S122 ();
         if (returnInSub) return;
         if ( StringUtil.StrCmp(AV5Segmento, "Portacontenedores") == 0 )
         {
            context.wjLoc = formatLink("wcportacontenedores.aspx") ;
            context.wjLocDisableFrm = 1;
         }
         else if ( StringUtil.StrCmp(AV5Segmento, "Graneles Secos") == 0 )
         {
            context.wjLoc = formatLink("wcgranelessecos.aspx") ;
            context.wjLocDisableFrm = 1;
         }
         else if ( StringUtil.StrCmp(AV5Segmento, "Tanqueros") == 0 )
         {
            context.wjLoc = formatLink("wctanqueros.aspx") ;
            context.wjLocDisableFrm = 1;
         }
         else if ( StringUtil.StrCmp(AV5Segmento, "Quimiqueros") == 0 )
         {
            context.wjLoc = formatLink("wcquimiqueros.aspx") ;
            context.wjLocDisableFrm = 1;
         }
         else if ( StringUtil.StrCmp(AV5Segmento, "Porta Vehículos y Ro-Ro") == 0 )
         {
            context.wjLoc = formatLink("wcportavehiculosroro.aspx") ;
            context.wjLocDisableFrm = 1;
         }
         else if ( StringUtil.StrCmp(AV5Segmento, "Refrigerados") == 0 )
         {
            context.wjLoc = formatLink("wcrefrigerados.aspx") ;
            context.wjLocDisableFrm = 1;
         }
         else if ( StringUtil.StrCmp(AV5Segmento, "Carga General") == 0 )
         {
            context.wjLoc = formatLink("wccargageneral.aspx") ;
            context.wjLocDisableFrm = 1;
         }
         else if ( StringUtil.StrCmp(AV5Segmento, "Gaseros LPG") == 0 )
         {
            context.wjLoc = formatLink("wclpg.aspx") ;
            context.wjLocDisableFrm = 1;
         }
         else if ( StringUtil.StrCmp(AV5Segmento, "Gaseros LNG") == 0 )
         {
            context.wjLoc = formatLink("wclng.aspx") ;
            context.wjLocDisableFrm = 1;
         }
         else if ( StringUtil.StrCmp(AV5Segmento, "Pasajeros") == 0 )
         {
            context.wjLoc = formatLink("wcpasajeros.aspx") ;
            context.wjLocDisableFrm = 1;
         }
         else if ( StringUtil.StrCmp(AV5Segmento, "Otros") == 0 )
         {
            context.wjLoc = formatLink("wcotros.aspx") ;
            context.wjLocDisableFrm = 1;
         }
         else
         {
            context.wjLoc = formatLink("ppal.aspx") ;
            context.wjLocDisableFrm = 1;
         }
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "AV8GridState", AV8GridState);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "AV11GridStateFilterValue", AV11GridStateFilterValue);
      }

      protected void E161X2( )
      {
         /* 'Eng.' Routine */
         context.Gx_err = (short)(context.SetLanguage( "English"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", true, "Gx_err", StringUtil.LTrim( StringUtil.Str( (decimal)(context.Gx_err), 3, 0)));
         context.DoAjaxRefresh();
      }

      protected void E171X2( )
      {
         /* 'Set Español' Routine */
         context.Gx_err = (short)(context.SetLanguage( "Spanish"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", true, "Gx_err", StringUtil.LTrim( StringUtil.Str( (decimal)(context.Gx_err), 3, 0)));
         context.DoAjaxRefresh();
      }

      protected void nextLoad( )
      {
      }

      protected void E181X2( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA1X2( ) ;
         WS1X2( ) ;
         WE1X2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void master_styles( )
      {
         define_styles( ) ;
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?11145295");
         if ( ! ( WebComp_Component1 == null ) )
         {
            if ( StringUtil.Len( WebComp_Component1_Component) != 0 )
            {
               WebComp_Component1.componentthemes();
            }
         }
         idxLst = 1;
         while ( idxLst <= (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)(getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Item(idxLst))), "?20151261123960");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("mp.js", "?20151261123960");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         imgImage1_Internalname = "IMAGE1_MPAGE";
         imgImage1_Internalname = "IMAGE1_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         divHeader_Internalname = "HEADER_MPAGE";
         divHeader_Internalname = "HEADER_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         lblTextblock1_Internalname = "TEXTBLOCK1_MPAGE";
         lblTextblock1_Internalname = "TEXTBLOCK1_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         bttButton2_Internalname = "BUTTON2_MPAGE";
         bttButton2_Internalname = "BUTTON2_MPAGE";
         bttButton1_Internalname = "BUTTON1_MPAGE";
         bttButton1_Internalname = "BUTTON1_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         divRecent_Internalname = "RECENT_MPAGE";
         divRecent_Internalname = "RECENT_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         lblTextblock3_Internalname = "TEXTBLOCK3_MPAGE";
         lblTextblock3_Internalname = "TEXTBLOCK3_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         cmbavSegmento_Internalname = "vSEGMENTO_MPAGE";
         cmbavSegmento_Internalname = "vSEGMENTO_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         divGroup1table_Internalname = "GROUP1TABLE_MPAGE";
         divGroup1table_Internalname = "GROUP1TABLE_MPAGE";
         grpGroup1_Internalname = "GROUP1_MPAGE";
         grpGroup1_Internalname = "GROUP1_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         divSolicitudfechafiltercontainer_Internalname = "SOLICITUDFECHAFILTERCONTAINER_MPAGE";
         divSolicitudfechafiltercontainer_Internalname = "SOLICITUDFECHAFILTERCONTAINER_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         bttCancel_Internalname = "CANCEL_MPAGE";
         bttCancel_Internalname = "CANCEL_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER_MPAGE";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         bttBtntoggle_Internalname = "BTNTOGGLE_MPAGE";
         bttBtntoggle_Internalname = "BTNTOGGLE_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         divGridtable_Internalname = "GRIDTABLE_MPAGE";
         divGridtable_Internalname = "GRIDTABLE_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         divMaintablex_Internalname = "MAINTABLEX_MPAGE";
         divMaintablex_Internalname = "MAINTABLEX_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         lblTextblock2_Internalname = "TEXTBLOCK2_MPAGE";
         lblTextblock2_Internalname = "TEXTBLOCK2_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         divFooter_Internalname = "FOOTER_MPAGE";
         divFooter_Internalname = "FOOTER_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         divMaintable_Internalname = "MAINTABLE_MPAGE";
         divMaintable_Internalname = "MAINTABLE_MPAGE";
         div_Internalname = "_MPAGE";
         div_Internalname = "_MPAGE";
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Internalname = "FORM_MPAGE";
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Internalname = "FORM_MPAGE";
      }

      public override void initialize_properties( )
      {
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         cmbavSegmento_Jsonclick = "";
         cmbavSegmento.Enabled = 1;
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainer";
         Contholder1.setDataArea(getDataAreaObject());
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
         setEventMetadata("REFRESH_MPAGE","{handler:'Refresh',iparms:[{av:'AV14Pgmname',fld:'vPGMNAME_MPAGE'},{av:'AV5Segmento',fld:'vSEGMENTO_MPAGE'}],oparms:[{ctrl:'COMPONENT1_MPAGE'},{av:'AV8GridState',fld:'vGRIDSTATE_MPAGE'},{av:'AV11GridStateFilterValue',fld:'vGRIDSTATEFILTERVALUE_MPAGE'}]}");
         setEventMetadata("TOGGLE_MPAGE","{handler:'E121X1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER_MPAGE',prop:'Class'},{ctrl:'BTNTOGGLE_MPAGE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER_MPAGE',prop:'Class'},{ctrl:'BTNTOGGLE_MPAGE',prop:'Class'}]}");
         setEventMetadata("VSEGMENTO_MPAGE.CLICK_MPAGE","{handler:'E151X2',iparms:[{av:'AV5Segmento',fld:'vSEGMENTO_MPAGE'},{av:'AV14Pgmname',fld:'vPGMNAME_MPAGE'}],oparms:[{av:'AV8GridState',fld:'vGRIDSTATE_MPAGE'},{av:'AV11GridStateFilterValue',fld:'vGRIDSTATEFILTERVALUE_MPAGE'}]}");
         setEventMetadata("ENG._MPAGE","{handler:'E161X2',iparms:[],oparms:[{av:'Gx_err',fld:'vERR_MPAGE'}]}");
         setEventMetadata("SET ESPAñOL_MPAGE","{handler:'E171X2',iparms:[],oparms:[{av:'Gx_err',fld:'vERR_MPAGE'}]}");
         setEventMetadata("CANCELAR_MPAGE","{handler:'E111X1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER_MPAGE',prop:'Class'},{ctrl:'BTNTOGGLE_MPAGE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER_MPAGE',prop:'Class'},{ctrl:'BTNTOGGLE_MPAGE',prop:'Class'}]}");
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
         Contholder1 = new GXDataAreaControl();
         AV14Pgmname = "";
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         lblTextblock1_Jsonclick = "";
         TempTags = "";
         bttButton2_Jsonclick = "";
         bttButton1_Jsonclick = "";
         lblTextblock3_Jsonclick = "";
         AV5Segmento = "";
         bttCancel_Jsonclick = "";
         bttBtntoggle_Jsonclick = "";
         lblTextblock2_Jsonclick = "";
         WebComp_Component1_Component = "";
         OldComponent1 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXKey = "";
         GX_FocusControl = "";
         AV8GridState = new SdtGridState(context);
         AV11GridStateFilterValue = new SdtGridState_FilterValue(context);
         AV9HTTPRequest = new GxHttpRequest( context);
         AV10Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sDynURL = "";
         Form = new GXWebForm();
         WebComp_Component1 = new GeneXus.Http.GXNullWebComponent();
         AV14Pgmname = "MP";
         /* GeneXus formulas. */
         AV14Pgmname = "MP";
         context.Gx_err = 0;
      }

      private short initialized ;
      private short GxWebError ;
      private short wbEnd ;
      private short wbStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGotPars ;
      private short nGXWrapped ;
      private int idxLst ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String AV14Pgmname ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String divHeader_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String imgImage1_Internalname ;
      private String divRecent_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String TempTags ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String divMaintablex_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divSolicitudfechafiltercontainer_Internalname ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String grpGroup1_Internalname ;
      private String divGroup1table_Internalname ;
      private String cmbavSegmento_Internalname ;
      private String cmbavSegmento_Jsonclick ;
      private String bttCancel_Internalname ;
      private String bttCancel_Jsonclick ;
      private String divGridtable_Internalname ;
      private String bttBtntoggle_Internalname ;
      private String bttBtntoggle_Jsonclick ;
      private String divFooter_Internalname ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String WebComp_Component1_Component ;
      private String OldComponent1 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String sDynURL ;
      private String div_Internalname ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV5Segmento ;
      private IGxSession AV10Session ;
      private GXWebComponent WebComp_Component1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavSegmento ;
      private GXDataAreaControl Contholder1 ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV9HTTPRequest ;
      private GXWebForm Form ;
      private SdtGridState AV8GridState ;
      private SdtGridState_FilterValue AV11GridStateFilterValue ;
   }

}
