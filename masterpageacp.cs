/*
               File: MasterPageACP
        Description: Master Page ACP
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/21/2015 9:42:23.47
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
   public class masterpageacp : GXMasterPage, System.Web.SessionState.IRequiresSessionState
   {
      public masterpageacp( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public masterpageacp( IGxContext context )
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
            PA1S2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", true, "Gx_err", StringUtil.LTrim( StringUtil.Str( (decimal)(context.Gx_err), 3, 0)));
               WS1S2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE1S2( ) ;
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

      protected void RenderHtmlCloseForm1S2( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         SendSecurityToken((String)(sPrefix));
         if ( ! isFullAjaxMode( ) )
         {
            getDataAreaObject().RenderHtmlCloseForm();
         }
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.AddJavascriptSource("masterpageacp.js", "?20151219422348");
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
      }

      public override String GetPgmname( )
      {
         return "masterpageacp" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "Master Page ACP", "") ;
      }

      protected void WB1S0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-10 logoExtraSmall", " "+"id"+" ");
            /* Static images/pictures */
            ClassString = "logoExtraSmall";
            StyleString = "";
            GxWebStd.gx_bitmap( context, imgImage1_Internalname, context.GetImagePath( "1516956f-a296-47b6-a3f8-79678824352f", "", context.GetTheme( )), "", "", "", context.GetTheme( ), 1, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", 1, false, false, "HLP_MasterPageACP.htm");
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
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, context.GetMessage( "Calculadora de Peajes", ""), "", "", lblTextblock1_Jsonclick, "'"+""+"'"+",true,"+"'"+"E_MPAGE."+"'", "", "SubTitle", 0, "", 1, 1, 0, "HLP_MasterPageACP.htm");
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 col-md-3", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group gx-button ActionGroup", "");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',true,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "", context.GetMessage( "Español", ""), bttButton1_Jsonclick, 5, context.GetMessage( "Español", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",true,"+"'"+"ESET ESPAñOL_MPAGE."+"'", TempTags, "", context.GetButtonType( ), "HLP_MasterPageACP.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',true,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "", context.GetMessage( "English", ""), bttButton2_Jsonclick, 5, context.GetMessage( "English", ""), "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",true,"+"'"+"EENG._MPAGE."+"'", TempTags, "", context.GetButtonType( ), "HLP_MasterPageACP.htm");
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
            GxWebStd.gx_div_start( context, divContent_Internalname, 1, 0, "px", 0, "px", "BodyContainer", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWAdvancedBarCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAdvancedcontainer_Internalname, 1, 0, "px", 0, "px", "AdvancedContainer", "");
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
            GxWebStd.gx_label_ctrl( context, lblTextblockseleccione_Internalname, context.GetMessage( "Seleccione el segmento", ""), "", "", lblTextblockseleccione_Jsonclick, "'"+""+"'"+",true,"+"'"+"E_MPAGE."+"'", "", "", 0, "", 1, 1, 0, "HLP_MasterPageACP.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", " "+"id"+" ");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',true,'',0)\"";
            ClassString = "BtnToggle";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "", "|||", bttBtntoggle_Jsonclick, 5, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",true,"+"'"+"ETOGGLE_MPAGE."+"'", TempTags, "", context.GetButtonType( ), "HLP_MasterPageACP.htm");
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
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
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
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, context.GetMessage( "Los resultados de los peajes presentados en esta herramienta son de carácter ilustrativo y son aproximaciones.  Los mismos no deben interpretarse como una cotización o compromiso por parte del Canal de Panamá.", ""), "", "", lblTextblock2_Jsonclick, "'"+""+"'"+",true,"+"'"+"E_MPAGE."+"'", "", "FooterText", 0, "", 1, 1, 0, "HLP_MasterPageACP.htm");
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
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
         }
         wbLoad = true;
      }

      protected void START1S2( )
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
         STRUP1S0( ) ;
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

      protected void WS1S2( )
      {
         START1S2( ) ;
         EVT1S2( ) ;
      }

      protected void EVT1S2( )
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
                           /* Execute user event: E111S2 */
                           E111S2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "REFRESH_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: E121S2 */
                           E121S2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENG._MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: E131S2 */
                           E131S2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SET ESPAñOL_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: E141S2 */
                           E141S2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LOAD_MPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: E151S2 */
                           E151S2 ();
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
                        else if ( StringUtil.StrCmp(sEvt, "TOGGLE_MPAGE") == 0 )
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
                  if ( context.wbHandled == 0 )
                  {
                     getDataAreaObject().DispatchEvents();
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void WE1S2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm1S2( ) ;
            }
         }
      }

      protected void PA1S2( )
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
         RF1S2( ) ;
      }

      protected void RF1S2( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", true, "Gx_err", StringUtil.LTrim( StringUtil.Str( (decimal)(context.Gx_err), 3, 0)));
         /* Execute user event: E121S2 */
         E121S2 ();
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E151S2 */
            E151S2 ();
            WB1S0( ) ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
         }
      }

      protected void STRUP1S0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", true, "Gx_err", StringUtil.LTrim( StringUtil.Str( (decimal)(context.Gx_err), 3, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E111S2 */
         E111S2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
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
         /* Execute user event: E111S2 */
         E111S2 ();
         if (returnInSub) return;
      }

      protected void E111S2( )
      {
         /* Start Routine */
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Meta.addItem("viewport", context.GetMessage( "width=device-width; initial-scale=1.0; maximum-scale=1.0; user-scalable=0;", ""), 0) ;
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Meta.addItem("apple-mobile-web-app-capable", context.GetMessage( "yes", ""), 0) ;
         (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Headerrawhtml = (getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Headerrawhtml+"<link rel='stylesheet' type='text/css' href='Resources/Peaje.css' />"+StringUtil.NewLine( );
      }

      protected void E121S2( )
      {
         /* Refresh Routine */
      }

      protected void E131S2( )
      {
         /* 'Eng.' Routine */
         context.Gx_err = (short)(context.SetLanguage( "English"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", true, "Gx_err", StringUtil.LTrim( StringUtil.Str( (decimal)(context.Gx_err), 3, 0)));
         context.DoAjaxRefresh();
      }

      protected void E141S2( )
      {
         /* 'Set Español' Routine */
         context.Gx_err = (short)(context.SetLanguage( "Spanish"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", true, "Gx_err", StringUtil.LTrim( StringUtil.Str( (decimal)(context.Gx_err), 3, 0)));
         context.DoAjaxRefresh();
      }

      protected void nextLoad( )
      {
      }

      protected void E151S2( )
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
         PA1S2( ) ;
         WS1S2( ) ;
         WE1S2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)(getDataAreaObject() == null ? Form : getDataAreaObject().GetForm()).Jscriptsrc.Item(idxLst))), "?20151219422367");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("masterpageacp.js", "?20151219422367");
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
         bttButton1_Internalname = "BUTTON1_MPAGE";
         bttButton1_Internalname = "BUTTON1_MPAGE";
         bttButton2_Internalname = "BUTTON2_MPAGE";
         bttButton2_Internalname = "BUTTON2_MPAGE";
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
         lblTextblockseleccione_Internalname = "TEXTBLOCKSELECCIONE_MPAGE";
         lblTextblockseleccione_Internalname = "TEXTBLOCKSELECCIONE_MPAGE";
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
         divContent_Internalname = "CONTENT_MPAGE";
         divContent_Internalname = "CONTENT_MPAGE";
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
         setEventMetadata("ENG._MPAGE","{handler:'E131S2',iparms:[],oparms:[{av:'Gx_err',fld:'vERR_MPAGE'}]}");
         setEventMetadata("SET ESPAñOL_MPAGE","{handler:'E141S2',iparms:[],oparms:[{av:'Gx_err',fld:'vERR_MPAGE'}]}");
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
         TempTags = "";
         bttButton1_Jsonclick = "";
         bttButton2_Jsonclick = "";
         lblTextblockseleccione_Jsonclick = "";
         bttBtntoggle_Jsonclick = "";
         lblTextblock2_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXKey = "";
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
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String divContent_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divSolicitudfechafiltercontainer_Internalname ;
      private String lblTextblockseleccione_Internalname ;
      private String lblTextblockseleccione_Jsonclick ;
      private String divGridtable_Internalname ;
      private String bttBtntoggle_Internalname ;
      private String bttBtntoggle_Jsonclick ;
      private String divFooter_Internalname ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXKey ;
      private String sDynURL ;
      private String div_Internalname ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private IGxDataStore dsDefault ;
      private GXDataAreaControl Contholder1 ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

}
