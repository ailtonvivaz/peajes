/*
               File: ppalMasterPage
        Description: ppal Master Page
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/21/2015 10:29:39.9
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
   public class ppalmasterpage : GXMasterPage, System.Web.SessionState.IRequiresSessionState
   {
      public ppalmasterpage( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public ppalmasterpage( IGxContext context )
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
            PA1U2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               WS1U2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE1U2( ) ;
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

      protected void RenderHtmlCloseForm1U2( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
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
         context.AddJavascriptSource("ppalmasterpage.js", "?201512110293911");
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
      }

      public override String GetPgmname( )
      {
         return "ppalmasterpage" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "ppal Master Page", "") ;
      }

      protected void WB1U0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 col-md-12 col-lg-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHeader_Internalname, 1, 0, "px", 0, "px", "ContainerFluid HeaderContainer", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 logoExtraSmall", " "+"id"+" ");
            /* Static images/pictures */
            ClassString = "logoExtraSmall";
            StyleString = "";
            GxWebStd.gx_bitmap( context, imgImage1_Internalname, context.GetImagePath( "1516956f-a296-47b6-a3f8-79678824352f", "", context.GetTheme( )), "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", 1, false, false, "HLP_ppalMasterPage.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-md-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divRecent_Internalname, 1, 0, "px", 0, "px", "ContainerFluid RecentLinksContainer", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 col-md-6 col-md-offset-3", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, context.GetMessage( "Calculadora de Peajes", ""), "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",true,"+"'"+"E_MPAGE."+"'", "", "SubTitle", 0, "", 1, 1, 0, "HLP_ppalMasterPage.htm");
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 col-md-3", " "+"id"+" ");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 col-md-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divContent_Internalname, 1, 0, "px", 0, "px", "BodyContainer", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-3 col-md-3", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divContent1_Internalname, 1, 0, "px", 0, "px", "", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWAdvancedBarCell", " "+"id"+" ");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockseleccione_Internalname, context.GetMessage( "Seleccione el segmento", ""), "", "", lblTextblockseleccione_Jsonclick, "'"+""+"'"+",true,"+"'"+"E_MPAGE."+"'", "", "", 0, "", 1, 1, 0, "HLP_ppalMasterPage.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-attribute", "");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',true,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavSegmento, cmbavSegmento_Internalname, AV5Segmento, 1, cmbavSegmento_Jsonclick, 7, "'"+""+"'"+",true,"+"'"+"e111u1_client"+"'", "svchar", "", 1, cmbavSegmento.Enabled, 0, 0, 40, "chr", 0, "", "", "Attribute", "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(36);\"", "", true, "HLP_ppalMasterPage.htm");
            cmbavSegmento.CurrentValue = AV5Segmento;
            context.httpAjaxContext.ajax_rsp_assign_prop("", true, cmbavSegmento_Internalname, "Values", (String)(cmbavSegmento.ToJavascriptSource()));
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-9 col-sm-12 col-md-12", " "+"id"+" ");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "true");
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-3 hidden-sm col-md-3 hidden-md hidden-lg ToggleCell", " "+"id"+" ");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',true,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",true,"+"'"+"e121u1_client"+"'", TempTags, "", 2, "HLP_ppalMasterPage.htm");
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
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
         }
         wbLoad = true;
      }

      protected void START1U2( )
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
         STRUP1U0( ) ;
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

      protected void WS1U2( )
      {
         START1U2( ) ;
         EVT1U2( ) ;
      }

      protected void EVT1U2( )
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
                           /* Execute user event: E131U2 */
                           E131U2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "REFRESH_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: E141U2 */
                           E141U2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LOAD_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: E151U2 */
                           E151U2 ();
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
                  if ( context.wbHandled == 0 )
                  {
                     getDataAreaObject().DispatchEvents();
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void WE1U2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm1U2( ) ;
            }
         }
      }

      protected void PA1U2( )
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
         RF1U2( ) ;
      }

      protected void RF1U2( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         /* Execute user event: E141U2 */
         E141U2 ();
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E151U2 */
            E151U2 ();
            WB1U0( ) ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
         }
      }

      protected void STRUP1U0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E131U2 */
         E131U2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            cmbavSegmento.CurrentValue = cgiGet( cmbavSegmento_Internalname);
            AV5Segmento = cgiGet( cmbavSegmento_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", true, "AV5Segmento", AV5Segmento);
            if ( cmbavSegmento.ItemCount > 0 )
            {
               AV5Segmento = cmbavSegmento.getValidValue(AV5Segmento);
               context.httpAjaxContext.ajax_rsp_assign_attri("", true, "AV5Segmento", AV5Segmento);
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

      protected void GXStart( )
      {
         /* Execute user event: E131U2 */
         E131U2 ();
         if (returnInSub) return;
      }

      protected void E131U2( )
      {
         /* Start Routine */
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Meta.addItem("viewport", context.GetMessage( "width=device-width; initial-scale=1.0; maximum-scale=1.0; user-scalable=0;", ""), 0) ;
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Meta.addItem("apple-mobile-web-app-capable", context.GetMessage( "yes", ""), 0) ;
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Headerrawhtml = (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Headerrawhtml+"<link rel='stylesheet' type='text/css' href='Resources/Peaje.css' />"+StringUtil.NewLine( );
      }

      protected void E141U2( )
      {
         /* Refresh Routine */
      }

      protected void nextLoad( )
      {
      }

      protected void E151U2( )
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
         PA1U2( ) ;
         WS1U2( ) ;
         WE1U2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?8243888");
         idxLst = 1;
         while ( idxLst <= (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)(getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Item(idxLst))), "?201512110293927");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("ppalmasterpage.js", "?201512110293927");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
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
         lblTextblockseleccione_Internalname = "TEXTBLOCKSELECCIONE_MPAGE";
         lblTextblockseleccione_Internalname = "TEXTBLOCKSELECCIONE_MPAGE";
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
         divSolicitudfechafiltercontainer_Internalname = "SOLICITUDFECHAFILTERCONTAINER_MPAGE";
         divSolicitudfechafiltercontainer_Internalname = "SOLICITUDFECHAFILTERCONTAINER_MPAGE";
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
         divContent1_Internalname = "CONTENT1_MPAGE";
         divContent1_Internalname = "CONTENT1_MPAGE";
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
         divContent_Internalname = "CONTENT_MPAGE";
         divContent_Internalname = "CONTENT_MPAGE";
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
         setEventMetadata("REFRESH_MPAGE","{handler:'Refresh',iparms:[],oparms:[]}");
         setEventMetadata("TOGGLE_MPAGE","{handler:'E121U1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER_MPAGE',prop:'Class'},{ctrl:'BTNTOGGLE_MPAGE',prop:'Class'}],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER_MPAGE',prop:'Class'},{ctrl:'BTNTOGGLE_MPAGE',prop:'Class'}]}");
         setEventMetadata("VSEGMENTO_MPAGE.CLICK_MPAGE","{handler:'E111U1',iparms:[],oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER_MPAGE',prop:'Class'},{ctrl:'BTNTOGGLE_MPAGE',prop:'Class'}]}");
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
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         lblTextblock1_Jsonclick = "";
         lblTextblockseleccione_Jsonclick = "";
         TempTags = "";
         AV5Segmento = "";
         bttBtntoggle_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXKey = "";
         GX_FocusControl = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sDynURL = "";
         Form = new GXWebForm();
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short initialized ;
      private short GxWebError ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGotPars ;
      private short nGXWrapped ;
      private int idxLst ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String divHeader_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String imgImage1_Internalname ;
      private String divRecent_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String divContent_Internalname ;
      private String divContent1_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divSolicitudfechafiltercontainer_Internalname ;
      private String lblTextblockseleccione_Internalname ;
      private String lblTextblockseleccione_Jsonclick ;
      private String TempTags ;
      private String cmbavSegmento_Internalname ;
      private String cmbavSegmento_Jsonclick ;
      private String divGridtable_Internalname ;
      private String bttBtntoggle_Internalname ;
      private String bttBtntoggle_Jsonclick ;
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
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavSegmento ;
      private GXDataAreaControl Contholder1 ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

}
