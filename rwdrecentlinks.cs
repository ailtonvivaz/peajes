/*
               File: RwdRecentLinks
        Description: Responsive Recent Links
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:14:54.92
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
   public class rwdrecentlinks : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public rwdrecentlinks( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            context.SetDefaultTheme("Flat");
         }
      }

      public rwdrecentlinks( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_FormCaption ,
                           String aP1_FormPgmName )
      {
         this.AV6FormCaption = aP0_FormCaption;
         this.AV7FormPgmName = aP1_FormPgmName;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            context.SetDefaultTheme("Flat");
         }
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            if ( ! context.IsLocalStorageSupported( ) )
            {
               context.PushCurrentUrl();
            }
         }
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  nDynComponent = 1;
                  sCompPrefix = GetNextPar( );
                  sSFPrefix = GetNextPar( );
                  AV6FormCaption = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6FormCaption", AV6FormCaption);
                  AV7FormPgmName = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7FormPgmName", AV7FormPgmName);
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(String)AV6FormCaption,(String)AV7FormPgmName});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Links") == 0 )
               {
                  nRC_GXsfl_8 = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  nGXsfl_8_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  sGXsfl_8_idx = GetNextPar( );
                  sPrefix = GetNextPar( );
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxnrLinks_newrow( nRC_GXsfl_8, nGXsfl_8_idx, sGXsfl_8_idx, sPrefix) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Links") == 0 )
               {
                  subLinks_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  AV6FormCaption = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6FormCaption", AV6FormCaption);
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrLinks_refresh( subLinks_Rows, AV6FormCaption, sPrefix) ;
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
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               ValidateSpaRequest();
            }
            PA052( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               WS052( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv);
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            context.WriteHtmlText( "<title>") ;
            context.SendWebValue( context.GetMessage( "Responsive Recent Links", "")) ;
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
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 86442));
         context.AddJavascriptSource("gxcfg.js", "?201512611145494");
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"";
            context.WriteHtmlText( "<body") ;
            context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+" style=\"-moz-opacity:0;opacity:0;") ;
            context.WriteHtmlText( "\""+FormProcess+">") ;
            context.skipLines(1);
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" class=\"form-horizontal Form\" novalidate action=\""+formatLink("rwdrecentlinks.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV6FormCaption)) + "," + UrlEncode(StringUtil.RTrim(AV7FormPgmName))+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
         else
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gxwebcomponent-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
      }

      protected void RenderHtmlCloseForm052( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_GXsfl_8", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_8), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV6FormCaption", StringUtil.RTrim( wcpOAV6FormCaption));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV7FormPgmName", StringUtil.RTrim( wcpOAV7FormPgmName));
         GxWebStd.gx_hidden_field( context, sPrefix+"vFORMCAPTION", StringUtil.RTrim( AV6FormCaption));
         GxWebStd.gx_hidden_field( context, sPrefix+"vFORMPGMNAME", StringUtil.RTrim( AV7FormPgmName));
         GxWebStd.gx_hidden_field( context, sPrefix+"LINKS_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(LINKS_nFirstRecordOnPage), 15, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"LINKS_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(LINKS_nEOF), 1, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"MAINTABLE_Class", StringUtil.RTrim( divMaintable_Class));
         GxWebStd.gx_hidden_field( context, sPrefix+"vRECENTLINKSITEM_Caption", StringUtil.RTrim( AV12RecentLinksItem.gxTpr_Caption));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("rwdrecentlinks.js", "?201512611145495");
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         SendSecurityToken(sPrefix);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
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
            context.WriteHtmlTextNl( "</body>") ;
            context.WriteHtmlTextNl( "</html>") ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
         }
         else
         {
            context.WriteHtmlText( "</div>") ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
      }

      public override String GetPgmname( )
      {
         return "rwdrecentlinks" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "Responsive Recent Links", "") ;
      }

      protected void WB050( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "rwdrecentlinks.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", " "+"data-abstract-form"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", divMaintable_Class, "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-2 col-md-1", " "+"id"+" ");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblRecenttext_Internalname, context.GetMessage( "Recents", ""), "", "", lblRecenttext_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+"e11051_client"+"'", "", "RecentsTitle", 7, "", 1, 1, 0, "HLP_RwdRecentLinks.htm");
            context.WriteHtmlText( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-10 col-md-11", " "+"id"+" ");
            /*  Grid Control  */
            LinksContainer.SetIsFreestyle(true);
            LinksContainer.SetWrapped(nGXWrapped);
            if ( LinksContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+sPrefix+"LinksContainer"+"DivS\" gxgridid=\"8\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subLinks_Internalname, subLinks_Internalname, "", "RecentLinksGrid", 0, "", "", 1, 2, sStyleString, "", 0);
               LinksContainer.AddObjectProperty("GridName", "Links");
            }
            else
            {
               LinksContainer.AddObjectProperty("GridName", "Links");
               LinksContainer.AddObjectProperty("Class", StringUtil.RTrim( "RecentLinksGrid"));
               LinksContainer.AddObjectProperty("Class", "RecentLinksGrid");
               LinksContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               LinksContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               LinksContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subLinks_Backcolorstyle), 1, 0, ".", "")));
               LinksContainer.AddObjectProperty("CmpContext", sPrefix);
               LinksContainer.AddObjectProperty("InMasterPage", "false");
               LinksColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               LinksContainer.AddColumnProperties(LinksColumn);
               LinksColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               LinksContainer.AddColumnProperties(LinksColumn);
               LinksColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               LinksContainer.AddColumnProperties(LinksColumn);
               LinksColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               LinksColumn.AddObjectProperty("Value", lblPlace_Caption);
               LinksContainer.AddColumnProperties(LinksColumn);
               LinksContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subLinks_Allowselection), 1, 0, ".", "")));
               LinksContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subLinks_Selectioncolor), 9, 0, ".", "")));
               LinksContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subLinks_Allowhovering), 1, 0, ".", "")));
               LinksContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subLinks_Hoveringcolor), 9, 0, ".", "")));
               LinksContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subLinks_Allowcollapsing), 1, 0, ".", "")));
               LinksContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subLinks_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 8 )
         {
            wbEnd = 0;
            nRC_GXsfl_8 = (short)(nGXsfl_8_idx-1);
            if ( LinksContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               LinksContainer.AddObjectProperty("LINKS_nEOF", LINKS_nEOF);
               LinksContainer.AddObjectProperty("LINKS_nFirstRecordOnPage", LINKS_nFirstRecordOnPage);
               sStyleString = " style=\"display:none;\"";
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+sPrefix+"LinksContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Links", LinksContainer);
               if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"LinksContainerData", LinksContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"LinksContainerData"+"V", LinksContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"LinksContainerData"+"V"+"\" value='"+LinksContainer.GridValuesHidden()+"'/>") ;
               }
            }
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
         }
         wbLoad = true;
      }

      protected void START052( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 10_3_2-86442", 0) ;
               Form.Meta.addItem("description", context.GetMessage( "Responsive Recent Links", ""), 0) ;
            }
            context.wjLoc = "";
            context.nUserReturn = 0;
            context.wbHandled = 0;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName");
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP050( ) ;
            }
         }
      }

      protected void WS052( )
      {
         START052( ) ;
         EVT052( ) ;
      }

      protected void EVT052( )
      {
         sXEvt = cgiGet( "_EventName");
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName");
                     EvtGridId = cgiGet( "_EventGridId");
                     EvtRowId = cgiGet( "_EventRowId");
                  }
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
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP050( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP050( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LINKSPAGING") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP050( ) ;
                              }
                              sEvt = cgiGet( sPrefix+"LINKSPAGING");
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 sublinks_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 sublinks_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 sublinks_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 sublinks_lastpage( ) ;
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "LINKS.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP050( ) ;
                              }
                              nGXsfl_8_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_8_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_idx), 4, 0)), 4, "0");
                              lblPlace_Internalname = sPrefix+"PLACE_"+sGXsfl_8_idx;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "LINKS.LOAD") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          /* Execute user event: E12052 */
                                          E12052 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          if ( ! wbErr )
                                          {
                                             Rfr0gs = false;
                                             if ( ! Rfr0gs )
                                             {
                                             }
                                             dynload_actions( ) ;
                                          }
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "CANCEL") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                                    {
                                       STRUP050( ) ;
                                    }
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                       }
                                    }
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

      protected void WE052( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm052( ) ;
            }
         }
      }

      protected void PA052( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
               {
                  gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
               }
            }
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
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

      protected void gxnrLinks_newrow( short nRC_GXsfl_8 ,
                                       short nGXsfl_8_idx ,
                                       String sGXsfl_8_idx ,
                                       String sPrefix )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         sGXsfl_8_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_idx), 4, 0)), 4, "0");
         lblPlace_Internalname = sPrefix+"PLACE_"+sGXsfl_8_idx;
         while ( nGXsfl_8_idx <= nRC_GXsfl_8 )
         {
            sendrow_82( ) ;
            nGXsfl_8_idx = (short)(((subLinks_Islastpage==1)&&(nGXsfl_8_idx+1>subLinks_Recordsperpage( )) ? 1 : nGXsfl_8_idx+1));
            sGXsfl_8_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_idx), 4, 0)), 4, "0");
            lblPlace_Internalname = sPrefix+"PLACE_"+sGXsfl_8_idx;
         }
         context.GX_webresponse.AddString(LinksContainer.ToJavascriptSource());
         /* End function gxnrLinks_newrow */
      }

      protected void gxgrLinks_refresh( int subLinks_Rows ,
                                        String AV6FormCaption ,
                                        String sPrefix )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, sPrefix+"LINKS_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subLinks_Rows), 6, 0, ".", "")));
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         RF052( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
         /* End function gxgrLinks_refresh */
      }

      public void Refresh( )
      {
         RF052( ) ;
      }

      protected void RF052( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         LinksContainer.AddObjectProperty("GridName", "Links");
         LinksContainer.AddObjectProperty("CmpContext", sPrefix);
         LinksContainer.AddObjectProperty("InMasterPage", "false");
         wbStart = 8;
         nGXsfl_8_idx = 1;
         sGXsfl_8_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_idx), 4, 0)), 4, "0");
         lblPlace_Internalname = sPrefix+"PLACE_"+sGXsfl_8_idx;
         nGXsfl_8_Refreshing = 1;
         LinksContainer.PageSize = subLinks_Recordsperpage( );
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            sGXsfl_8_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_idx), 4, 0)), 4, "0");
            lblPlace_Internalname = sPrefix+"PLACE_"+sGXsfl_8_idx;
            /* Execute user event: E12052 */
            E12052 ();
            wbEnd = 8;
            WB050( ) ;
         }
         nGXsfl_8_Refreshing = 0;
      }

      protected int subLinks_Pagecount( )
      {
         LINKS_nRecordCount = subLinks_Recordcount( );
         if ( ((int)((LINKS_nRecordCount) % (subLinks_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(LINKS_nRecordCount/ (decimal)(subLinks_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(LINKS_nRecordCount/ (decimal)(subLinks_Recordsperpage( ))))+1) ;
      }

      protected int subLinks_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subLinks_Recordsperpage( )
      {
         return (int)(5*9999) ;
      }

      protected int subLinks_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected short sublinks_firstpage( )
      {
         LINKS_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, sPrefix+"LINKS_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(LINKS_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrLinks_refresh( subLinks_Rows, AV6FormCaption, sPrefix) ;
         }
         return 0 ;
      }

      protected short sublinks_nextpage( )
      {
         if ( LINKS_nEOF == 0 )
         {
            LINKS_nFirstRecordOnPage = (long)(LINKS_nFirstRecordOnPage+subLinks_Recordsperpage( ));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"LINKS_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(LINKS_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrLinks_refresh( subLinks_Rows, AV6FormCaption, sPrefix) ;
         }
         return 0 ;
      }

      protected short sublinks_previouspage( )
      {
         if ( LINKS_nFirstRecordOnPage >= subLinks_Recordsperpage( ) )
         {
            LINKS_nFirstRecordOnPage = (long)(LINKS_nFirstRecordOnPage-subLinks_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"LINKS_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(LINKS_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrLinks_refresh( subLinks_Rows, AV6FormCaption, sPrefix) ;
         }
         return 0 ;
      }

      protected short sublinks_lastpage( )
      {
         subLinks_Islastpage = 1;
         if ( isFullAjaxMode( ) )
         {
            gxgrLinks_refresh( subLinks_Rows, AV6FormCaption, sPrefix) ;
         }
         return 0 ;
      }

      protected int sublinks_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            LINKS_nFirstRecordOnPage = (long)(subLinks_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            LINKS_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"LINKS_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(LINKS_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrLinks_refresh( subLinks_Rows, AV6FormCaption, sPrefix) ;
         }
         return (int)(0) ;
      }

      protected void STRUP050( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            nRC_GXsfl_8 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_8"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            wcpOAV6FormCaption = cgiGet( sPrefix+"wcpOAV6FormCaption");
            wcpOAV7FormPgmName = cgiGet( sPrefix+"wcpOAV7FormPgmName");
            AV6FormCaption = cgiGet( sPrefix+"vFORMCAPTION");
            AV7FormPgmName = cgiGet( sPrefix+"vFORMPGMNAME");
            LINKS_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"LINKS_nFirstRecordOnPage"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            LINKS_nEOF = (short)(context.localUtil.CToN( cgiGet( sPrefix+"LINKS_nEOF"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      private void E12052( )
      {
         /* Links_Load Routine */
         AV11RecentLinksItems.FromXml(AV8Session.Get("RecentLinks"), "");
         AV9i = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV9i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9i), 5, 0)));
         while ( AV9i <= AV11RecentLinksItems.Count )
         {
            AV12RecentLinksItem = ((SdtLinkList_LinkItem)AV11RecentLinksItems.Item(AV9i));
            if ( StringUtil.StrCmp(StringUtil.Trim( AV12RecentLinksItem.gxTpr_Caption), StringUtil.Trim( AV6FormCaption)) == 0 )
            {
               AV11RecentLinksItems.RemoveItem(AV9i);
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV9i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9i), 5, 0)));
            }
            else
            {
               AV9i = (int)(AV9i+1);
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV9i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9i), 5, 0)));
            }
         }
         while ( AV11RecentLinksItems.Count > 8 - 1 )
         {
            AV11RecentLinksItems.RemoveItem(1);
         }
         AV12RecentLinksItem = new SdtLinkList_LinkItem(context);
         AV12RecentLinksItem.gxTpr_Caption = StringUtil.Trim( AV6FormCaption);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV12RecentLinksItem", AV12RecentLinksItem);
         AV12RecentLinksItem.gxTpr_Url = AV10Request.ScriptName+"?"+AV10Request.QueryString;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV12RecentLinksItem", AV12RecentLinksItem);
         AV11RecentLinksItems.Add(AV12RecentLinksItem, 0);
         AV8Session.Set("RecentLinks", AV11RecentLinksItems.ToXml(false, true, "LinkList", "CalcularPeajes"));
         AV9i = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV9i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9i), 5, 0)));
         while ( AV9i <= AV11RecentLinksItems.Count )
         {
            AV12RecentLinksItem = ((SdtLinkList_LinkItem)AV11RecentLinksItems.Item(AV9i));
            AV13PlaceCaption = AV12RecentLinksItem.gxTpr_Caption;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13PlaceCaption", AV13PlaceCaption);
            if ( StringUtil.Len( AV13PlaceCaption) > 20 )
            {
               AV13PlaceCaption = StringUtil.Format( "%1...", StringUtil.Substring( AV13PlaceCaption, 1, 18), "", "", "", "", "", "", "", "");
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV13PlaceCaption", AV13PlaceCaption);
            }
            lblPlace_Caption = AV13PlaceCaption;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, lblPlace_Internalname, "Caption", lblPlace_Caption);
            if ( AV9i < AV11RecentLinksItems.Count )
            {
               lblPlace_Link = formatLink(AV12RecentLinksItem.gxTpr_Url) ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, lblPlace_Internalname, "Link", lblPlace_Link);
            }
            else
            {
               lblPlace_Link = "";
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, lblPlace_Internalname, "Link", lblPlace_Link);
            }
            /* Load Method */
            if ( wbStart != -1 )
            {
               wbStart = 8;
            }
            if ( ( subLinks_Islastpage == 1 ) || ( 5 == 0 ) || ( ( LINKS_nCurrentRecord >= LINKS_nFirstRecordOnPage ) && ( LINKS_nCurrentRecord < LINKS_nFirstRecordOnPage + subLinks_Recordsperpage( ) ) ) )
            {
               sendrow_82( ) ;
               LINKS_nEOF = 1;
               GxWebStd.gx_hidden_field( context, sPrefix+"LINKS_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(LINKS_nEOF), 1, 0, ".", "")));
               if ( ( subLinks_Islastpage == 1 ) && ( ((int)((LINKS_nCurrentRecord) % (subLinks_Recordsperpage( )))) == 0 ) )
               {
                  LINKS_nFirstRecordOnPage = LINKS_nCurrentRecord;
               }
            }
            if ( LINKS_nCurrentRecord >= LINKS_nFirstRecordOnPage + subLinks_Recordsperpage( ) )
            {
               LINKS_nEOF = 0;
               GxWebStd.gx_hidden_field( context, sPrefix+"LINKS_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(LINKS_nEOF), 1, 0, ".", "")));
            }
            LINKS_nCurrentRecord = (long)(LINKS_nCurrentRecord+1);
            if ( isFullAjaxMode( ) && ( nGXsfl_8_Refreshing == 0 ) )
            {
               context.DoAjaxLoad(8, LinksRow);
            }
            AV9i = (int)(AV9i+1);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV9i", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9i), 5, 0)));
         }
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11RecentLinksItems", AV11RecentLinksItems);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV12RecentLinksItem", AV12RecentLinksItem);
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV6FormCaption = (String)getParm(obj,0);
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6FormCaption", AV6FormCaption);
         AV7FormPgmName = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7FormPgmName", AV7FormPgmName);
      }

      public override String getresponse( String sGXDynURL )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.SetDefaultTheme("Flat");
         }
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA052( ) ;
         WS052( ) ;
         WE052( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlAV6FormCaption = (String)((String)getParm(obj,0));
         sCtrlAV7FormPgmName = (String)((String)getParm(obj,1));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA052( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "rwdrecentlinks");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA052( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV6FormCaption = (String)getParm(obj,2);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6FormCaption", AV6FormCaption);
            AV7FormPgmName = (String)getParm(obj,3);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7FormPgmName", AV7FormPgmName);
         }
         wcpOAV6FormCaption = cgiGet( sPrefix+"wcpOAV6FormCaption");
         wcpOAV7FormPgmName = cgiGet( sPrefix+"wcpOAV7FormPgmName");
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(AV6FormCaption, wcpOAV6FormCaption) != 0 ) || ( StringUtil.StrCmp(AV7FormPgmName, wcpOAV7FormPgmName) != 0 ) ) )
         {
            setjustcreated();
         }
         wcpOAV6FormCaption = AV6FormCaption;
         wcpOAV7FormPgmName = AV7FormPgmName;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV6FormCaption = cgiGet( sPrefix+"AV6FormCaption_CTRL");
         if ( StringUtil.Len( sCtrlAV6FormCaption) > 0 )
         {
            AV6FormCaption = cgiGet( sCtrlAV6FormCaption);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV6FormCaption", AV6FormCaption);
         }
         else
         {
            AV6FormCaption = cgiGet( sPrefix+"AV6FormCaption_PARM");
         }
         sCtrlAV7FormPgmName = cgiGet( sPrefix+"AV7FormPgmName_CTRL");
         if ( StringUtil.Len( sCtrlAV7FormPgmName) > 0 )
         {
            AV7FormPgmName = cgiGet( sCtrlAV7FormPgmName);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7FormPgmName", AV7FormPgmName);
         }
         else
         {
            AV7FormPgmName = cgiGet( sPrefix+"AV7FormPgmName_PARM");
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix;
         sSFPrefix = sPSFPrefix;
         sPrefix = sCompPrefix + sSFPrefix;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         INITWEB( ) ;
         nDraw = 0;
         PA052( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS052( ) ;
         if ( isFullAjaxMode( ) )
         {
            componentdraw();
         }
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WS052( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV6FormCaption_PARM", StringUtil.RTrim( AV6FormCaption));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV6FormCaption)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV6FormCaption_CTRL", StringUtil.RTrim( sCtrlAV6FormCaption));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV7FormPgmName_PARM", StringUtil.RTrim( AV7FormPgmName));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV7FormPgmName)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV7FormPgmName_CTRL", StringUtil.RTrim( sCtrlAV7FormPgmName));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WCParametersSet( ) ;
         WE052( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1);
         }
         else
         {
            sCtrlName = sGXControl;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?11145295");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20151261114554");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("rwdrecentlinks.js", "?20151261114555");
         /* End function include_jscripts */
      }

      protected void sendrow_82( )
      {
         sGXsfl_8_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_idx), 4, 0)), 4, "0");
         lblPlace_Internalname = sPrefix+"PLACE_"+sGXsfl_8_idx;
         WB050( ) ;
         if ( ( 5 * 9999 == 0 ) || ( nGXsfl_8_idx <= subLinks_Recordsperpage( ) * 9999 ) )
         {
            LinksRow = GXWebRow.GetNew(context,LinksContainer);
            if ( subLinks_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subLinks_Backstyle = 0;
               if ( StringUtil.StrCmp(subLinks_Class, "") != 0 )
               {
                  subLinks_Linesclass = subLinks_Class+"Odd";
               }
            }
            else if ( subLinks_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subLinks_Backstyle = 0;
               subLinks_Backcolor = subLinks_Allbackcolor;
               if ( StringUtil.StrCmp(subLinks_Class, "") != 0 )
               {
                  subLinks_Linesclass = subLinks_Class+"Uniform";
               }
            }
            else if ( subLinks_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subLinks_Backstyle = 1;
               if ( StringUtil.StrCmp(subLinks_Class, "") != 0 )
               {
                  subLinks_Linesclass = subLinks_Class+"Odd";
               }
               subLinks_Backcolor = (int)(0xFFFFFF);
            }
            else if ( subLinks_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subLinks_Backstyle = 1;
               if ( ((int)((nGXsfl_8_idx) % (2))) == 0 )
               {
                  subLinks_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subLinks_Class, "") != 0 )
                  {
                     subLinks_Linesclass = subLinks_Class+"Even";
                  }
               }
               else
               {
                  subLinks_Backcolor = (int)(0xFFFFFF);
                  if ( StringUtil.StrCmp(subLinks_Class, "") != 0 )
                  {
                     subLinks_Linesclass = subLinks_Class+"Odd";
                  }
               }
            }
            /* Start of Columns property logic. */
            if ( LinksContainer.GetWrapped() == 1 )
            {
               if ( ( 1 == 0 ) && ( nGXsfl_8_idx == 1 ) )
               {
                  context.WriteHtmlText( "<tr"+" class=\""+subLinks_Linesclass+"\" style=\""+""+"\""+" gxrow=\""+sGXsfl_8_idx+"\">") ;
               }
               if ( 1 > 0 )
               {
                  if ( ( 1 == 1 ) || ( ((int)((nGXsfl_8_idx) % (1))) - 1 == 0 ) )
                  {
                     context.WriteHtmlText( "<tr"+" class=\""+subLinks_Linesclass+"\" style=\""+""+"\""+" gxrow=\""+sGXsfl_8_idx+"\">") ;
                  }
               }
            }
            /* Div Control */
            LinksRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)divLinkstable_Internalname+"_"+sGXsfl_8_idx,(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"RecentLinksTable",(String)""});
            /* Div Control */
            LinksRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)""});
            /* Div Control */
            LinksRow.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12",(String)" "+"id"+" "});
            /* Text block */
            LinksRow.AddColumnProperties("label", 1, isAjaxCallMode( ), new Object[] {(String)lblPlace_Internalname,(String)lblPlace_Caption,(String)lblPlace_Link,(String)"",(String)lblPlace_Jsonclick,(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"RecentLinkItem",(short)0,(String)"",(short)1,(short)1,(short)0});
            /* End of Columns property logic. */
            if ( LinksContainer.GetWrapped() == 1 )
            {
               if ( 1 > 0 )
               {
                  if ( ((int)((nGXsfl_8_idx) % (1))) == 0 )
                  {
                     context.WriteHtmlTextNl( "</tr>") ;
                  }
               }
            }
            LinksContainer.AddRow(LinksRow);
            nGXsfl_8_idx = (short)(((subLinks_Islastpage==1)&&(nGXsfl_8_idx+1>subLinks_Recordsperpage( )) ? 1 : nGXsfl_8_idx+1));
            sGXsfl_8_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_8_idx), 4, 0)), 4, "0");
            lblPlace_Internalname = sPrefix+"PLACE_"+sGXsfl_8_idx;
         }
         /* End function sendrow_82 */
      }

      protected void init_default_properties( )
      {
         lblRecenttext_Internalname = sPrefix+"RECENTTEXT";
         lblRecenttext_Internalname = sPrefix+"RECENTTEXT";
         div_Internalname = sPrefix+"";
         div_Internalname = sPrefix+"";
         lblPlace_Internalname = sPrefix+"PLACE";
         div_Internalname = sPrefix+"";
         div_Internalname = sPrefix+"";
         div_Internalname = sPrefix+"";
         div_Internalname = sPrefix+"";
         divLinkstable_Internalname = sPrefix+"LINKSTABLE";
         divLinkstable_Internalname = sPrefix+"LINKSTABLE";
         div_Internalname = sPrefix+"";
         div_Internalname = sPrefix+"";
         div_Internalname = sPrefix+"";
         div_Internalname = sPrefix+"";
         divMaintable_Internalname = sPrefix+"MAINTABLE";
         divMaintable_Internalname = sPrefix+"MAINTABLE";
         div_Internalname = sPrefix+"";
         div_Internalname = sPrefix+"";
         Form.Internalname = sPrefix+"FORM";
         Form.Internalname = sPrefix+"FORM";
         subLinks_Internalname = sPrefix+"LINKS";
         subLinks_Internalname = sPrefix+"LINKS";
      }

      public override void initialize_properties( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         init_default_properties( ) ;
         lblPlace_Link = "";
         subLinks_Class = "RecentLinksGrid";
         lblPlace_Caption = context.GetMessage( "Place.", "");
         subLinks_Allowcollapsing = 0;
         lblPlace_Caption = context.GetMessage( "Place.", "");
         subLinks_Backcolorstyle = 0;
         divMaintable_Class = "RecentLinksMainTable";
         subLinks_Rows = 5;
         GxWebStd.gx_hidden_field( context, sPrefix+"LINKS_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subLinks_Rows), 6, 0, ".", "")));
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'LINKS_nFirstRecordOnPage'},{av:'LINKS_nEOF'},{av:'subLinks_Rows'},{av:'AV6FormCaption',fld:'vFORMCAPTION'},{av:'sPrefix'}],oparms:[]}");
         setEventMetadata("RECENTTEXT.CLICK","{handler:'E11051',iparms:[{av:'divMaintable_Class',ctrl:'MAINTABLE',prop:'Class'}],oparms:[{av:'divMaintable_Class',ctrl:'MAINTABLE',prop:'Class'}]}");
         setEventMetadata("LINKS.LOAD","{handler:'E12052',iparms:[{av:'AV11RecentLinksItems',fld:'vRECENTLINKSITEMS'},{av:'AV12RecentLinksItem',fld:'vRECENTLINKSITEM'},{av:'AV6FormCaption',fld:'vFORMCAPTION'}],oparms:[{av:'AV11RecentLinksItems',fld:'vRECENTLINKSITEMS'},{av:'AV9i',fld:'vI'},{av:'AV12RecentLinksItem',fld:'vRECENTLINKSITEM'},{av:'AV13PlaceCaption',fld:'vPLACECAPTION'},{av:'lblPlace_Caption',ctrl:'PLACE',prop:'Caption'},{av:'lblPlace_Link',ctrl:'PLACE',prop:'Link'}]}");
         setEventMetadata("LINKS_FIRSTPAGE","{handler:'sublinks_firstpage',iparms:[{av:'LINKS_nFirstRecordOnPage'},{av:'LINKS_nEOF'},{av:'subLinks_Rows'},{av:'AV6FormCaption',fld:'vFORMCAPTION'},{av:'sPrefix'}],oparms:[]}");
         setEventMetadata("LINKS_PREVPAGE","{handler:'sublinks_previouspage',iparms:[{av:'LINKS_nFirstRecordOnPage'},{av:'LINKS_nEOF'},{av:'subLinks_Rows'},{av:'AV6FormCaption',fld:'vFORMCAPTION'},{av:'sPrefix'}],oparms:[]}");
         setEventMetadata("LINKS_NEXTPAGE","{handler:'sublinks_nextpage',iparms:[{av:'LINKS_nFirstRecordOnPage'},{av:'LINKS_nEOF'},{av:'subLinks_Rows'},{av:'AV6FormCaption',fld:'vFORMCAPTION'},{av:'sPrefix'}],oparms:[]}");
         setEventMetadata("LINKS_LASTPAGE","{handler:'sublinks_lastpage',iparms:[{av:'LINKS_nFirstRecordOnPage'},{av:'LINKS_nEOF'},{av:'subLinks_Rows'},{av:'AV6FormCaption',fld:'vFORMCAPTION'},{av:'sPrefix'}],oparms:[]}");
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
         wcpOAV6FormCaption = "";
         wcpOAV7FormPgmName = "";
         AV12RecentLinksItem = new SdtLinkList_LinkItem(context);
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         sDynURL = "";
         FormProcess = "";
         GX_FocusControl = "";
         lblRecenttext_Jsonclick = "";
         LinksContainer = new GXWebGrid( context);
         sStyleString = "";
         LinksColumn = new GXWebColumn();
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXKey = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         AV11RecentLinksItems = new GxObjectCollection( context, "LinkList.LinkItem", "CalcularPeajes", "SdtLinkList_LinkItem", "GeneXus.Programs");
         AV8Session = context.GetSession();
         AV10Request = new GxHttpRequest( context);
         AV13PlaceCaption = "";
         LinksRow = new GXWebRow();
         sCtrlAV6FormCaption = "";
         sCtrlAV7FormPgmName = "";
         subLinks_Linesclass = "";
         lblPlace_Jsonclick = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short nRC_GXsfl_8 ;
      private short nGXsfl_8_idx=1 ;
      private short initialized ;
      private short LINKS_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short subLinks_Backcolorstyle ;
      private short subLinks_Allowselection ;
      private short subLinks_Allowhovering ;
      private short subLinks_Allowcollapsing ;
      private short subLinks_Collapsed ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXsfl_8_Refreshing=0 ;
      private short nGXWrapped ;
      private short subLinks_Backstyle ;
      private int subLinks_Rows ;
      private int subLinks_Selectioncolor ;
      private int subLinks_Hoveringcolor ;
      private int subLinks_Islastpage ;
      private int AV9i ;
      private int idxLst ;
      private int subLinks_Backcolor ;
      private int subLinks_Allbackcolor ;
      private long LINKS_nFirstRecordOnPage ;
      private long LINKS_nRecordCount ;
      private long LINKS_nCurrentRecord ;
      private String AV6FormCaption ;
      private String wcpOAV6FormCaption ;
      private String divMaintable_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_8_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String divMaintable_Internalname ;
      private String lblRecenttext_Internalname ;
      private String lblRecenttext_Jsonclick ;
      private String sStyleString ;
      private String subLinks_Internalname ;
      private String lblPlace_Caption ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String lblPlace_Internalname ;
      private String GXKey ;
      private String lblPlace_Link ;
      private String sCtrlAV6FormCaption ;
      private String sCtrlAV7FormPgmName ;
      private String subLinks_Class ;
      private String subLinks_Linesclass ;
      private String divLinkstable_Internalname ;
      private String lblPlace_Jsonclick ;
      private String div_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private String AV7FormPgmName ;
      private String wcpOAV7FormPgmName ;
      private String AV13PlaceCaption ;
      private IGxSession AV8Session ;
      private GXWebGrid LinksContainer ;
      private GXWebRow LinksRow ;
      private GXWebColumn LinksColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV10Request ;
      [ObjectCollection(ItemType=typeof( SdtLinkList_LinkItem ))]
      private IGxCollection AV11RecentLinksItems ;
      private SdtLinkList_LinkItem AV12RecentLinksItem ;
   }

}
