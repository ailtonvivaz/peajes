/*
               File: PortaContenedoresRangoWC
        Description: Porta Contenedores Rango WC
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 7:38:11.48
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
   public class portacontenedoresrangowc : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public portacontenedoresrangowc( )
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

      public portacontenedoresrangowc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_PortaContenedoresEsclusa )
      {
         this.AV7PortaContenedoresEsclusa = aP0_PortaContenedoresEsclusa;
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
         cmbPortaContenedoresEsclusa = new GXCombobox();
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
                  AV7PortaContenedoresEsclusa = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7PortaContenedoresEsclusa", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PortaContenedoresEsclusa), 4, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(short)AV7PortaContenedoresEsclusa});
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid") == 0 )
               {
                  nRC_GXsfl_9 = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  nGXsfl_9_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  sGXsfl_9_idx = GetNextPar( );
                  sPrefix = GetNextPar( );
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxnrGrid_newrow( nRC_GXsfl_9, nGXsfl_9_idx, sGXsfl_9_idx, sPrefix) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid") == 0 )
               {
                  subGrid_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
                  AV7PortaContenedoresEsclusa = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7PortaContenedoresEsclusa", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PortaContenedoresEsclusa), 4, 0)));
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrGrid_refresh( subGrid_Rows, AV7PortaContenedoresEsclusa, sPrefix) ;
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
            PA152( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV15Pgmname = "PortaContenedoresRangoWC";
               context.Gx_err = 0;
               WS152( ) ;
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
            context.SendWebValue( context.GetMessage( "Porta Contenedores Rango WC", "")) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20151207381149");
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
            FormProcess = ((nGXWrapped==0) ? " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" : "");
            context.WriteHtmlText( "<body") ;
            context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+" style=\"-moz-opacity:0;opacity:0;") ;
            context.WriteHtmlText( "\""+FormProcess+">") ;
            context.skipLines(1);
            if ( nGXWrapped != 1 )
            {
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" class=\"form-horizontal Form\" novalidate action=\""+formatLink("portacontenedoresrangowc.aspx") + "?" + UrlEncode("" +AV7PortaContenedoresEsclusa)+"\">") ;
               GxWebStd.gx_hidden_field( context, "_EventName", "");
               GxWebStd.gx_hidden_field( context, "_EventGridId", "");
               GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            }
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

      protected void RenderHtmlCloseForm152( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_GXsfl_9", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_9), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV7PortaContenedoresEsclusa", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV7PortaContenedoresEsclusa), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vPORTACONTENEDORESESCLUSA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7PortaContenedoresEsclusa), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("portacontenedoresrangowc.js", "?20151207381150");
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
            if ( nGXWrapped != 1 )
            {
               context.WriteHtmlTextNl( "</form>") ;
            }
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
         return "portacontenedoresrangowc" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "Porta Contenedores Rango WC", "") ;
      }

      protected void WB150( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "portacontenedoresrangowc.aspx");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", " "+"data-abstract-form"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMain_Internalname, 1, 0, "px", 0, "px", "GridTabMainTable", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12 ViewGridCell", " "+"id"+" ");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtable_Internalname, 1, 0, "px", 0, "px", "Table", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-12", " "+"id"+" ");
            /*  Grid Control  */
            GridContainer.SetWrapped(nGXWrapped);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"DivS\" gxgridid=\"9\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid_Internalname, subGrid_Internalname, "", "WorkWith", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid_Backcolorstyle == 0 )
               {
                  subGrid_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid_Class) > 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Title";
                  }
               }
               else
               {
                  subGrid_Titlebackstyle = 1;
                  if ( subGrid_Backcolorstyle == 1 )
                  {
                     subGrid_Titlebackcolor = subGrid_Allbackcolor;
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Rango", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Rango Inicial", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Final", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tarifa TTA4", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tarifa TEU4", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tarifa TTA3", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tarifa TEU3", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tarifa TTA2", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tarifa TEU2", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tarifa TTA1", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tarifa TEU1", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               GridContainer.AddObjectProperty("GridName", "Grid");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  GridContainer = new GXWebGrid( context);
               }
               else
               {
                  GridContainer.Clear();
               }
               GridContainer.SetWrapped(nGXWrapped);
               GridContainer.AddObjectProperty("GridName", "Grid");
               GridContainer.AddObjectProperty("Class", "WorkWith");
               GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("CmpContext", sPrefix);
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A24PortaRango), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A25PortaRangoIniTEU), 12, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A26PortaRangoFinTEU), 12, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A27PortaTarifaTTA4, 7, 2, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A28PortaTarifaTEU4, 7, 2, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A29PortaTarifaTTA3, 7, 2, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A30PortaTarifaTEU3, 7, 2, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A31PortaTarifaTTA2, 7, 2, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A32PortaTarifaTEU2, 7, 2, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A33PortaTarifaTTA1, 7, 2, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A34PortaTarifaTEU1, 7, 2, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowselection), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Selectioncolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowhovering), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Hoveringcolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowcollapsing), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 9 )
         {
            wbEnd = 0;
            nRC_GXsfl_9 = (short)(nGXsfl_9_idx-1);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               GridContainer.AddObjectProperty("GRID_nEOF", GRID_nEOF);
               GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
               sStyleString = " style=\"display:none;\"";
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid", GridContainer);
               if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData", GridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData"+"V", GridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
               }
            }
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
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbPortaContenedoresEsclusa, cmbPortaContenedoresEsclusa_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A22PortaContenedoresEsclusa), 4, 0)), 1, cmbPortaContenedoresEsclusa_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "int", "", cmbPortaContenedoresEsclusa.Visible, cmbPortaContenedoresEsclusa.Enabled, 0, 0, 4, "chr", 0, "", "", "Attribute", "", "", "", true, "HLP_PortaContenedoresRangoWC.htm");
            cmbPortaContenedoresEsclusa.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A22PortaContenedoresEsclusa), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbPortaContenedoresEsclusa_Internalname, "Values", (String)(cmbPortaContenedoresEsclusa.ToJavascriptSource()));
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
         }
         wbLoad = true;
      }

      protected void START152( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 10_3_2-86442", 0) ;
               Form.Meta.addItem("description", context.GetMessage( "Porta Contenedores Rango WC", ""), 0) ;
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
               STRUP150( ) ;
            }
         }
      }

      protected void WS152( )
      {
         START152( ) ;
         EVT152( ) ;
      }

      protected void EVT152( )
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
                                 STRUP150( ) ;
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
                                 STRUP150( ) ;
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
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGING") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP150( ) ;
                              }
                              sEvt = cgiGet( sPrefix+"GRIDPAGING");
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid_lastpage( ) ;
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP150( ) ;
                              }
                              nGXsfl_9_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_9_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_9_idx), 4, 0)), 4, "0");
                              edtPortaRango_Internalname = sPrefix+"PORTARANGO_"+sGXsfl_9_idx;
                              edtPortaRangoIniTEU_Internalname = sPrefix+"PORTARANGOINITEU_"+sGXsfl_9_idx;
                              edtPortaRangoFinTEU_Internalname = sPrefix+"PORTARANGOFINTEU_"+sGXsfl_9_idx;
                              edtPortaTarifaTTA4_Internalname = sPrefix+"PORTATARIFATTA4_"+sGXsfl_9_idx;
                              edtPortaTarifaTEU4_Internalname = sPrefix+"PORTATARIFATEU4_"+sGXsfl_9_idx;
                              edtPortaTarifaTTA3_Internalname = sPrefix+"PORTATARIFATTA3_"+sGXsfl_9_idx;
                              edtPortaTarifaTEU3_Internalname = sPrefix+"PORTATARIFATEU3_"+sGXsfl_9_idx;
                              edtPortaTarifaTTA2_Internalname = sPrefix+"PORTATARIFATTA2_"+sGXsfl_9_idx;
                              edtPortaTarifaTEU2_Internalname = sPrefix+"PORTATARIFATEU2_"+sGXsfl_9_idx;
                              edtPortaTarifaTTA1_Internalname = sPrefix+"PORTATARIFATTA1_"+sGXsfl_9_idx;
                              edtPortaTarifaTEU1_Internalname = sPrefix+"PORTATARIFATEU1_"+sGXsfl_9_idx;
                              A24PortaRango = (short)(context.localUtil.CToN( cgiGet( edtPortaRango_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtPortaRango_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A24PortaRango), 4, 0)));
                              A25PortaRangoIniTEU = (long)(context.localUtil.CToN( cgiGet( edtPortaRangoIniTEU_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtPortaRangoIniTEU_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A25PortaRangoIniTEU), 12, 0)));
                              A26PortaRangoFinTEU = (long)(context.localUtil.CToN( cgiGet( edtPortaRangoFinTEU_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtPortaRangoFinTEU_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A26PortaRangoFinTEU), 12, 0)));
                              A27PortaTarifaTTA4 = context.localUtil.CToN( cgiGet( edtPortaTarifaTTA4_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtPortaTarifaTTA4_Internalname, StringUtil.LTrim( StringUtil.Str( A27PortaTarifaTTA4, 7, 2)));
                              A28PortaTarifaTEU4 = context.localUtil.CToN( cgiGet( edtPortaTarifaTEU4_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtPortaTarifaTEU4_Internalname, StringUtil.LTrim( StringUtil.Str( A28PortaTarifaTEU4, 7, 2)));
                              A29PortaTarifaTTA3 = context.localUtil.CToN( cgiGet( edtPortaTarifaTTA3_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtPortaTarifaTTA3_Internalname, StringUtil.LTrim( StringUtil.Str( A29PortaTarifaTTA3, 7, 2)));
                              A30PortaTarifaTEU3 = context.localUtil.CToN( cgiGet( edtPortaTarifaTEU3_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtPortaTarifaTEU3_Internalname, StringUtil.LTrim( StringUtil.Str( A30PortaTarifaTEU3, 7, 2)));
                              A31PortaTarifaTTA2 = context.localUtil.CToN( cgiGet( edtPortaTarifaTTA2_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtPortaTarifaTTA2_Internalname, StringUtil.LTrim( StringUtil.Str( A31PortaTarifaTTA2, 7, 2)));
                              A32PortaTarifaTEU2 = context.localUtil.CToN( cgiGet( edtPortaTarifaTEU2_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtPortaTarifaTEU2_Internalname, StringUtil.LTrim( StringUtil.Str( A32PortaTarifaTEU2, 7, 2)));
                              A33PortaTarifaTTA1 = context.localUtil.CToN( cgiGet( edtPortaTarifaTTA1_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtPortaTarifaTTA1_Internalname, StringUtil.LTrim( StringUtil.Str( A33PortaTarifaTTA1, 7, 2)));
                              A34PortaTarifaTEU1 = context.localUtil.CToN( cgiGet( edtPortaTarifaTEU1_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtPortaTarifaTEU1_Internalname, StringUtil.LTrim( StringUtil.Str( A34PortaTarifaTEU1, 7, 2)));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          /* Execute user event: E11152 */
                                          E11152 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          /* Execute user event: E12152 */
                                          E12152 ();
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
                                       STRUP150( ) ;
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

      protected void WE152( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm152( ) ;
            }
         }
      }

      protected void PA152( )
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
            cmbPortaContenedoresEsclusa.Name = "PORTACONTENEDORESESCLUSA";
            cmbPortaContenedoresEsclusa.WebTags = "";
            cmbPortaContenedoresEsclusa.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), context.GetMessage( "GX_EmptyItemText", ""), 0);
            cmbPortaContenedoresEsclusa.addItem("1", context.GetMessage( "Panamax", ""), 0);
            cmbPortaContenedoresEsclusa.addItem("2", context.GetMessage( "Neopanamax", ""), 0);
            if ( cmbPortaContenedoresEsclusa.ItemCount > 0 )
            {
               A22PortaContenedoresEsclusa = (short)(NumberUtil.Val( cmbPortaContenedoresEsclusa.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A22PortaContenedoresEsclusa), 4, 0))), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A22PortaContenedoresEsclusa", StringUtil.LTrim( StringUtil.Str( (decimal)(A22PortaContenedoresEsclusa), 4, 0)));
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

      protected void gxnrGrid_newrow( short nRC_GXsfl_9 ,
                                      short nGXsfl_9_idx ,
                                      String sGXsfl_9_idx ,
                                      String sPrefix )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         sGXsfl_9_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_9_idx), 4, 0)), 4, "0");
         edtPortaRango_Internalname = sPrefix+"PORTARANGO_"+sGXsfl_9_idx;
         edtPortaRangoIniTEU_Internalname = sPrefix+"PORTARANGOINITEU_"+sGXsfl_9_idx;
         edtPortaRangoFinTEU_Internalname = sPrefix+"PORTARANGOFINTEU_"+sGXsfl_9_idx;
         edtPortaTarifaTTA4_Internalname = sPrefix+"PORTATARIFATTA4_"+sGXsfl_9_idx;
         edtPortaTarifaTEU4_Internalname = sPrefix+"PORTATARIFATEU4_"+sGXsfl_9_idx;
         edtPortaTarifaTTA3_Internalname = sPrefix+"PORTATARIFATTA3_"+sGXsfl_9_idx;
         edtPortaTarifaTEU3_Internalname = sPrefix+"PORTATARIFATEU3_"+sGXsfl_9_idx;
         edtPortaTarifaTTA2_Internalname = sPrefix+"PORTATARIFATTA2_"+sGXsfl_9_idx;
         edtPortaTarifaTEU2_Internalname = sPrefix+"PORTATARIFATEU2_"+sGXsfl_9_idx;
         edtPortaTarifaTTA1_Internalname = sPrefix+"PORTATARIFATTA1_"+sGXsfl_9_idx;
         edtPortaTarifaTEU1_Internalname = sPrefix+"PORTATARIFATEU1_"+sGXsfl_9_idx;
         while ( nGXsfl_9_idx <= nRC_GXsfl_9 )
         {
            sendrow_92( ) ;
            nGXsfl_9_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_9_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_9_idx+1));
            sGXsfl_9_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_9_idx), 4, 0)), 4, "0");
            edtPortaRango_Internalname = sPrefix+"PORTARANGO_"+sGXsfl_9_idx;
            edtPortaRangoIniTEU_Internalname = sPrefix+"PORTARANGOINITEU_"+sGXsfl_9_idx;
            edtPortaRangoFinTEU_Internalname = sPrefix+"PORTARANGOFINTEU_"+sGXsfl_9_idx;
            edtPortaTarifaTTA4_Internalname = sPrefix+"PORTATARIFATTA4_"+sGXsfl_9_idx;
            edtPortaTarifaTEU4_Internalname = sPrefix+"PORTATARIFATEU4_"+sGXsfl_9_idx;
            edtPortaTarifaTTA3_Internalname = sPrefix+"PORTATARIFATTA3_"+sGXsfl_9_idx;
            edtPortaTarifaTEU3_Internalname = sPrefix+"PORTATARIFATEU3_"+sGXsfl_9_idx;
            edtPortaTarifaTTA2_Internalname = sPrefix+"PORTATARIFATTA2_"+sGXsfl_9_idx;
            edtPortaTarifaTEU2_Internalname = sPrefix+"PORTATARIFATEU2_"+sGXsfl_9_idx;
            edtPortaTarifaTTA1_Internalname = sPrefix+"PORTATARIFATTA1_"+sGXsfl_9_idx;
            edtPortaTarifaTEU1_Internalname = sPrefix+"PORTATARIFATEU1_"+sGXsfl_9_idx;
         }
         context.GX_webresponse.AddString(GridContainer.ToJavascriptSource());
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV7PortaContenedoresEsclusa ,
                                       String sPrefix )
      {
         /* GeneXus formulas. */
         AV15Pgmname = "PortaContenedoresRangoWC";
         context.Gx_err = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         cmbPortaContenedoresEsclusa.Name = "PORTACONTENEDORESESCLUSA";
         cmbPortaContenedoresEsclusa.WebTags = "";
         cmbPortaContenedoresEsclusa.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), context.GetMessage( "GX_EmptyItemText", ""), 0);
         cmbPortaContenedoresEsclusa.addItem("1", context.GetMessage( "Panamax", ""), 0);
         cmbPortaContenedoresEsclusa.addItem("2", context.GetMessage( "Neopanamax", ""), 0);
         if ( cmbPortaContenedoresEsclusa.ItemCount > 0 )
         {
            A22PortaContenedoresEsclusa = (short)(NumberUtil.Val( cmbPortaContenedoresEsclusa.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A22PortaContenedoresEsclusa), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A22PortaContenedoresEsclusa", StringUtil.LTrim( StringUtil.Str( (decimal)(A22PortaContenedoresEsclusa), 4, 0)));
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         RF152( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
         /* End function gxgrGrid_refresh */
      }

      public void Refresh( )
      {
         RF152( ) ;
      }

      protected void RF152( )
      {
         /* GeneXus formulas. */
         AV15Pgmname = "PortaContenedoresRangoWC";
         context.Gx_err = 0;
         GridContainer.AddObjectProperty("GridName", "Grid");
         GridContainer.AddObjectProperty("CmpContext", sPrefix);
         GridContainer.AddObjectProperty("InMasterPage", "false");
         wbStart = 9;
         nGXsfl_9_idx = 1;
         sGXsfl_9_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_9_idx), 4, 0)), 4, "0");
         edtPortaRango_Internalname = sPrefix+"PORTARANGO_"+sGXsfl_9_idx;
         edtPortaRangoIniTEU_Internalname = sPrefix+"PORTARANGOINITEU_"+sGXsfl_9_idx;
         edtPortaRangoFinTEU_Internalname = sPrefix+"PORTARANGOFINTEU_"+sGXsfl_9_idx;
         edtPortaTarifaTTA4_Internalname = sPrefix+"PORTATARIFATTA4_"+sGXsfl_9_idx;
         edtPortaTarifaTEU4_Internalname = sPrefix+"PORTATARIFATEU4_"+sGXsfl_9_idx;
         edtPortaTarifaTTA3_Internalname = sPrefix+"PORTATARIFATTA3_"+sGXsfl_9_idx;
         edtPortaTarifaTEU3_Internalname = sPrefix+"PORTATARIFATEU3_"+sGXsfl_9_idx;
         edtPortaTarifaTTA2_Internalname = sPrefix+"PORTATARIFATTA2_"+sGXsfl_9_idx;
         edtPortaTarifaTEU2_Internalname = sPrefix+"PORTATARIFATEU2_"+sGXsfl_9_idx;
         edtPortaTarifaTTA1_Internalname = sPrefix+"PORTATARIFATTA1_"+sGXsfl_9_idx;
         edtPortaTarifaTEU1_Internalname = sPrefix+"PORTATARIFATEU1_"+sGXsfl_9_idx;
         nGXsfl_9_Refreshing = 1;
         GridContainer.PageSize = subGrid_Recordsperpage( );
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            sGXsfl_9_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_9_idx), 4, 0)), 4, "0");
            edtPortaRango_Internalname = sPrefix+"PORTARANGO_"+sGXsfl_9_idx;
            edtPortaRangoIniTEU_Internalname = sPrefix+"PORTARANGOINITEU_"+sGXsfl_9_idx;
            edtPortaRangoFinTEU_Internalname = sPrefix+"PORTARANGOFINTEU_"+sGXsfl_9_idx;
            edtPortaTarifaTTA4_Internalname = sPrefix+"PORTATARIFATTA4_"+sGXsfl_9_idx;
            edtPortaTarifaTEU4_Internalname = sPrefix+"PORTATARIFATEU4_"+sGXsfl_9_idx;
            edtPortaTarifaTTA3_Internalname = sPrefix+"PORTATARIFATTA3_"+sGXsfl_9_idx;
            edtPortaTarifaTEU3_Internalname = sPrefix+"PORTATARIFATEU3_"+sGXsfl_9_idx;
            edtPortaTarifaTTA2_Internalname = sPrefix+"PORTATARIFATTA2_"+sGXsfl_9_idx;
            edtPortaTarifaTEU2_Internalname = sPrefix+"PORTATARIFATEU2_"+sGXsfl_9_idx;
            edtPortaTarifaTTA1_Internalname = sPrefix+"PORTATARIFATTA1_"+sGXsfl_9_idx;
            edtPortaTarifaTEU1_Internalname = sPrefix+"PORTATARIFATEU1_"+sGXsfl_9_idx;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 1 : GRID_nFirstRecordOnPage+1));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : GRID_nFirstRecordOnPage+subGrid_Recordsperpage( )+1);
            /* Using cursor H00152 */
            pr_default.execute(0, new Object[] {AV7PortaContenedoresEsclusa, GXPagingFrom2, GXPagingTo2});
            nGXsfl_9_idx = 1;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A22PortaContenedoresEsclusa = H00152_A22PortaContenedoresEsclusa[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A22PortaContenedoresEsclusa", StringUtil.LTrim( StringUtil.Str( (decimal)(A22PortaContenedoresEsclusa), 4, 0)));
               A34PortaTarifaTEU1 = H00152_A34PortaTarifaTEU1[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtPortaTarifaTEU1_Internalname, StringUtil.LTrim( StringUtil.Str( A34PortaTarifaTEU1, 7, 2)));
               A33PortaTarifaTTA1 = H00152_A33PortaTarifaTTA1[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtPortaTarifaTTA1_Internalname, StringUtil.LTrim( StringUtil.Str( A33PortaTarifaTTA1, 7, 2)));
               A32PortaTarifaTEU2 = H00152_A32PortaTarifaTEU2[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtPortaTarifaTEU2_Internalname, StringUtil.LTrim( StringUtil.Str( A32PortaTarifaTEU2, 7, 2)));
               A31PortaTarifaTTA2 = H00152_A31PortaTarifaTTA2[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtPortaTarifaTTA2_Internalname, StringUtil.LTrim( StringUtil.Str( A31PortaTarifaTTA2, 7, 2)));
               A30PortaTarifaTEU3 = H00152_A30PortaTarifaTEU3[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtPortaTarifaTEU3_Internalname, StringUtil.LTrim( StringUtil.Str( A30PortaTarifaTEU3, 7, 2)));
               A29PortaTarifaTTA3 = H00152_A29PortaTarifaTTA3[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtPortaTarifaTTA3_Internalname, StringUtil.LTrim( StringUtil.Str( A29PortaTarifaTTA3, 7, 2)));
               A28PortaTarifaTEU4 = H00152_A28PortaTarifaTEU4[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtPortaTarifaTEU4_Internalname, StringUtil.LTrim( StringUtil.Str( A28PortaTarifaTEU4, 7, 2)));
               A27PortaTarifaTTA4 = H00152_A27PortaTarifaTTA4[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtPortaTarifaTTA4_Internalname, StringUtil.LTrim( StringUtil.Str( A27PortaTarifaTTA4, 7, 2)));
               A26PortaRangoFinTEU = H00152_A26PortaRangoFinTEU[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtPortaRangoFinTEU_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A26PortaRangoFinTEU), 12, 0)));
               A25PortaRangoIniTEU = H00152_A25PortaRangoIniTEU[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtPortaRangoIniTEU_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A25PortaRangoIniTEU), 12, 0)));
               A24PortaRango = H00152_A24PortaRango[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtPortaRango_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A24PortaRango), 4, 0)));
               /* Execute user event: E12152 */
               E12152 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 9;
            WB150( ) ;
         }
         nGXsfl_9_Refreshing = 0;
      }

      protected int subGrid_Pagecount( )
      {
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( ((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_Recordsperpage( ))))+1) ;
      }

      protected int subGrid_Recordcount( )
      {
         /* Using cursor H00153 */
         pr_default.execute(1, new Object[] {AV7PortaContenedoresEsclusa});
         GRID_nRecordCount = H00153_AGRID_nRecordCount[0];
         pr_default.close(1);
         return (int)(GRID_nRecordCount) ;
      }

      protected int subGrid_Recordsperpage( )
      {
         if ( subGrid_Rows > 0 )
         {
            return subGrid_Rows*1 ;
         }
         else
         {
            return (int)(-1) ;
         }
      }

      protected int subGrid_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID_nFirstRecordOnPage/ (decimal)(subGrid_Recordsperpage( ))))+1) ;
      }

      protected short subgrid_firstpage( )
      {
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV7PortaContenedoresEsclusa, sPrefix) ;
         }
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( ( GRID_nRecordCount >= subGrid_Recordsperpage( ) ) && ( GRID_nEOF == 0 ) )
         {
            GRID_nFirstRecordOnPage = (long)(GRID_nFirstRecordOnPage+subGrid_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV7PortaContenedoresEsclusa, sPrefix) ;
         }
         return 0 ;
      }

      protected short subgrid_previouspage( )
      {
         if ( GRID_nFirstRecordOnPage >= subGrid_Recordsperpage( ) )
         {
            GRID_nFirstRecordOnPage = (long)(GRID_nFirstRecordOnPage-subGrid_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV7PortaContenedoresEsclusa, sPrefix) ;
         }
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( GRID_nRecordCount > subGrid_Recordsperpage( ) )
         {
            if ( ((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))) == 0 )
            {
               GRID_nFirstRecordOnPage = (long)(GRID_nRecordCount-subGrid_Recordsperpage( ));
            }
            else
            {
               GRID_nFirstRecordOnPage = (long)(GRID_nRecordCount-((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))));
            }
         }
         else
         {
            GRID_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV7PortaContenedoresEsclusa, sPrefix) ;
         }
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID_nFirstRecordOnPage = (long)(subGrid_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV7PortaContenedoresEsclusa, sPrefix) ;
         }
         return (int)(0) ;
      }

      protected void STRUP150( )
      {
         /* Before Start, stand alone formulas. */
         AV15Pgmname = "PortaContenedoresRangoWC";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E11152 */
         E11152 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            cmbPortaContenedoresEsclusa.Name = cmbPortaContenedoresEsclusa_Internalname;
            cmbPortaContenedoresEsclusa.CurrentValue = cgiGet( cmbPortaContenedoresEsclusa_Internalname);
            A22PortaContenedoresEsclusa = (short)(NumberUtil.Val( cgiGet( cmbPortaContenedoresEsclusa_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A22PortaContenedoresEsclusa", StringUtil.LTrim( StringUtil.Str( (decimal)(A22PortaContenedoresEsclusa), 4, 0)));
            if ( cmbPortaContenedoresEsclusa.ItemCount > 0 )
            {
               A22PortaContenedoresEsclusa = (short)(NumberUtil.Val( cmbPortaContenedoresEsclusa.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A22PortaContenedoresEsclusa), 4, 0))), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A22PortaContenedoresEsclusa", StringUtil.LTrim( StringUtil.Str( (decimal)(A22PortaContenedoresEsclusa), 4, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_9 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_9"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            wcpOAV7PortaContenedoresEsclusa = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV7PortaContenedoresEsclusa"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            AV7PortaContenedoresEsclusa = (short)(context.localUtil.CToN( cgiGet( sPrefix+"vPORTACONTENEDORESESCLUSA"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nFirstRecordOnPage"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nEOF"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
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

      protected void GXStart( )
      {
         /* Execute user event: E11152 */
         E11152 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E11152( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV15Pgmname) )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV15Pgmname));
            context.wjLocDisableFrm = 1;
         }
         subGrid_Rows = 10;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         cmbPortaContenedoresEsclusa.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbPortaContenedoresEsclusa_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbPortaContenedoresEsclusa.Visible), 5, 0)));
         /* Execute user subroutine: S112 */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      private void E12152( )
      {
         /* Grid_Load Routine */
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 9;
         }
         sendrow_92( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ( nGXsfl_9_Refreshing == 0 ) )
         {
            context.DoAjaxLoad(9, GridRow);
         }
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV10TrnContext = new SdtTransactionContext(context);
         AV10TrnContext.gxTpr_Callerobject = AV15Pgmname;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContext", AV10TrnContext);
         AV10TrnContext.gxTpr_Callerondelete = true;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContext", AV10TrnContext);
         AV10TrnContext.gxTpr_Callerurl = AV9HTTPRequest.ScriptName+"?"+AV9HTTPRequest.QueryString;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContext", AV10TrnContext);
         AV10TrnContext.gxTpr_Transactionname = "PortaContenedores";
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContext", AV10TrnContext);
         AV11TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV11TrnContextAtt.gxTpr_Attributename = "PortaContenedoresEsclusa";
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11TrnContextAtt", AV11TrnContextAtt);
         AV11TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV7PortaContenedoresEsclusa), 4, 0);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11TrnContextAtt", AV11TrnContextAtt);
         AV10TrnContext.gxTpr_Attributes.Add(AV11TrnContextAtt, 0) ;
         AV8Session.Set("TrnContext", AV10TrnContext.ToXml(false, true, "TransactionContext", "CalcularPeajes"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV7PortaContenedoresEsclusa = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7PortaContenedoresEsclusa", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PortaContenedoresEsclusa), 4, 0)));
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
         PA152( ) ;
         WS152( ) ;
         WE152( ) ;
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
         sCtrlAV7PortaContenedoresEsclusa = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA152( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "portacontenedoresrangowc");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA152( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV7PortaContenedoresEsclusa = Convert.ToInt16(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7PortaContenedoresEsclusa", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PortaContenedoresEsclusa), 4, 0)));
         }
         wcpOAV7PortaContenedoresEsclusa = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV7PortaContenedoresEsclusa"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
         if ( ! GetJustCreated( ) && ( ( AV7PortaContenedoresEsclusa != wcpOAV7PortaContenedoresEsclusa ) ) )
         {
            setjustcreated();
         }
         wcpOAV7PortaContenedoresEsclusa = AV7PortaContenedoresEsclusa;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV7PortaContenedoresEsclusa = cgiGet( sPrefix+"AV7PortaContenedoresEsclusa_CTRL");
         if ( StringUtil.Len( sCtrlAV7PortaContenedoresEsclusa) > 0 )
         {
            AV7PortaContenedoresEsclusa = (short)(context.localUtil.CToN( cgiGet( sCtrlAV7PortaContenedoresEsclusa), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7PortaContenedoresEsclusa", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PortaContenedoresEsclusa), 4, 0)));
         }
         else
         {
            AV7PortaContenedoresEsclusa = (short)(context.localUtil.CToN( cgiGet( sPrefix+"AV7PortaContenedoresEsclusa_PARM"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
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
         PA152( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS152( ) ;
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
         WS152( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV7PortaContenedoresEsclusa_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7PortaContenedoresEsclusa), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV7PortaContenedoresEsclusa)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV7PortaContenedoresEsclusa_CTRL", StringUtil.RTrim( sCtrlAV7PortaContenedoresEsclusa));
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
         WE152( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?738724");
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20151207381176");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("portacontenedoresrangowc.js", "?20151207381176");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_92( )
      {
         sGXsfl_9_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_9_idx), 4, 0)), 4, "0");
         edtPortaRango_Internalname = sPrefix+"PORTARANGO_"+sGXsfl_9_idx;
         edtPortaRangoIniTEU_Internalname = sPrefix+"PORTARANGOINITEU_"+sGXsfl_9_idx;
         edtPortaRangoFinTEU_Internalname = sPrefix+"PORTARANGOFINTEU_"+sGXsfl_9_idx;
         edtPortaTarifaTTA4_Internalname = sPrefix+"PORTATARIFATTA4_"+sGXsfl_9_idx;
         edtPortaTarifaTEU4_Internalname = sPrefix+"PORTATARIFATEU4_"+sGXsfl_9_idx;
         edtPortaTarifaTTA3_Internalname = sPrefix+"PORTATARIFATTA3_"+sGXsfl_9_idx;
         edtPortaTarifaTEU3_Internalname = sPrefix+"PORTATARIFATEU3_"+sGXsfl_9_idx;
         edtPortaTarifaTTA2_Internalname = sPrefix+"PORTATARIFATTA2_"+sGXsfl_9_idx;
         edtPortaTarifaTEU2_Internalname = sPrefix+"PORTATARIFATEU2_"+sGXsfl_9_idx;
         edtPortaTarifaTTA1_Internalname = sPrefix+"PORTATARIFATTA1_"+sGXsfl_9_idx;
         edtPortaTarifaTEU1_Internalname = sPrefix+"PORTATARIFATEU1_"+sGXsfl_9_idx;
         WB150( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_9_idx <= subGrid_Recordsperpage( ) * 1 ) )
         {
            GridRow = GXWebRow.GetNew(context,GridContainer);
            if ( subGrid_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid_Backstyle = 0;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd";
               }
            }
            else if ( subGrid_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid_Backstyle = 0;
               subGrid_Backcolor = subGrid_Allbackcolor;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Uniform";
               }
            }
            else if ( subGrid_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid_Backstyle = 1;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd";
               }
               subGrid_Backcolor = (int)(0x0);
            }
            else if ( subGrid_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid_Backstyle = 1;
               if ( ((int)((nGXsfl_9_idx) % (2))) == 0 )
               {
                  subGrid_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Even";
                  }
               }
               else
               {
                  subGrid_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Odd";
                  }
               }
            }
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+subGrid_Linesclass+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_9_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPortaRango_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A24PortaRango), 4, 0, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( (decimal)(A24PortaRango), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPortaRango_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)9,(short)1,(short)1,(short)0,(bool)true,(String)"",(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPortaRangoIniTEU_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A25PortaRangoIniTEU), 12, 0, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( (decimal)(A25PortaRangoIniTEU), "ZZZZZZZZZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPortaRangoIniTEU_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)12,(short)0,(short)0,(short)9,(short)1,(short)1,(short)0,(bool)true,(String)"",(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPortaRangoFinTEU_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A26PortaRangoFinTEU), 12, 0, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( (decimal)(A26PortaRangoFinTEU), "ZZZZZZZZZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPortaRangoFinTEU_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)12,(short)0,(short)0,(short)9,(short)1,(short)1,(short)0,(bool)true,(String)"",(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPortaTarifaTTA4_Internalname,StringUtil.LTrim( StringUtil.NToC( A27PortaTarifaTTA4, 7, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A27PortaTarifaTTA4, "ZZZ9.99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPortaTarifaTTA4_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)7,(short)0,(short)0,(short)9,(short)1,(short)1,(short)0,(bool)true,(String)"DominioTarifa",(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPortaTarifaTEU4_Internalname,StringUtil.LTrim( StringUtil.NToC( A28PortaTarifaTEU4, 7, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A28PortaTarifaTEU4, "ZZZ9.99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPortaTarifaTEU4_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)7,(short)0,(short)0,(short)9,(short)1,(short)1,(short)0,(bool)true,(String)"DominioTarifa",(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPortaTarifaTTA3_Internalname,StringUtil.LTrim( StringUtil.NToC( A29PortaTarifaTTA3, 7, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A29PortaTarifaTTA3, "ZZZ9.99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPortaTarifaTTA3_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)7,(short)0,(short)0,(short)9,(short)1,(short)1,(short)0,(bool)true,(String)"DominioTarifa",(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPortaTarifaTEU3_Internalname,StringUtil.LTrim( StringUtil.NToC( A30PortaTarifaTEU3, 7, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A30PortaTarifaTEU3, "ZZZ9.99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPortaTarifaTEU3_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)7,(short)0,(short)0,(short)9,(short)1,(short)1,(short)0,(bool)true,(String)"DominioTarifa",(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPortaTarifaTTA2_Internalname,StringUtil.LTrim( StringUtil.NToC( A31PortaTarifaTTA2, 7, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A31PortaTarifaTTA2, "ZZZ9.99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPortaTarifaTTA2_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)7,(short)0,(short)0,(short)9,(short)1,(short)1,(short)0,(bool)true,(String)"DominioTarifa",(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPortaTarifaTEU2_Internalname,StringUtil.LTrim( StringUtil.NToC( A32PortaTarifaTEU2, 7, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A32PortaTarifaTEU2, "ZZZ9.99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPortaTarifaTEU2_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)7,(short)0,(short)0,(short)9,(short)1,(short)1,(short)0,(bool)true,(String)"DominioTarifa",(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPortaTarifaTTA1_Internalname,StringUtil.LTrim( StringUtil.NToC( A33PortaTarifaTTA1, 7, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A33PortaTarifaTTA1, "ZZZ9.99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPortaTarifaTTA1_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)7,(short)0,(short)0,(short)9,(short)1,(short)1,(short)0,(bool)true,(String)"DominioTarifa",(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPortaTarifaTEU1_Internalname,StringUtil.LTrim( StringUtil.NToC( A34PortaTarifaTEU1, 7, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A34PortaTarifaTEU1, "ZZZ9.99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtPortaTarifaTEU1_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)7,(short)0,(short)0,(short)9,(short)1,(short)1,(short)0,(bool)true,(String)"DominioTarifa",(String)"right"});
            GridContainer.AddRow(GridRow);
            nGXsfl_9_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_9_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_9_idx+1));
            sGXsfl_9_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_9_idx), 4, 0)), 4, "0");
            edtPortaRango_Internalname = sPrefix+"PORTARANGO_"+sGXsfl_9_idx;
            edtPortaRangoIniTEU_Internalname = sPrefix+"PORTARANGOINITEU_"+sGXsfl_9_idx;
            edtPortaRangoFinTEU_Internalname = sPrefix+"PORTARANGOFINTEU_"+sGXsfl_9_idx;
            edtPortaTarifaTTA4_Internalname = sPrefix+"PORTATARIFATTA4_"+sGXsfl_9_idx;
            edtPortaTarifaTEU4_Internalname = sPrefix+"PORTATARIFATEU4_"+sGXsfl_9_idx;
            edtPortaTarifaTTA3_Internalname = sPrefix+"PORTATARIFATTA3_"+sGXsfl_9_idx;
            edtPortaTarifaTEU3_Internalname = sPrefix+"PORTATARIFATEU3_"+sGXsfl_9_idx;
            edtPortaTarifaTTA2_Internalname = sPrefix+"PORTATARIFATTA2_"+sGXsfl_9_idx;
            edtPortaTarifaTEU2_Internalname = sPrefix+"PORTATARIFATEU2_"+sGXsfl_9_idx;
            edtPortaTarifaTTA1_Internalname = sPrefix+"PORTATARIFATTA1_"+sGXsfl_9_idx;
            edtPortaTarifaTEU1_Internalname = sPrefix+"PORTATARIFATEU1_"+sGXsfl_9_idx;
         }
         /* End function sendrow_92 */
      }

      protected void init_default_properties( )
      {
         edtPortaRango_Internalname = sPrefix+"PORTARANGO";
         edtPortaRangoIniTEU_Internalname = sPrefix+"PORTARANGOINITEU";
         edtPortaRangoFinTEU_Internalname = sPrefix+"PORTARANGOFINTEU";
         edtPortaTarifaTTA4_Internalname = sPrefix+"PORTATARIFATTA4";
         edtPortaTarifaTEU4_Internalname = sPrefix+"PORTATARIFATEU4";
         edtPortaTarifaTTA3_Internalname = sPrefix+"PORTATARIFATTA3";
         edtPortaTarifaTEU3_Internalname = sPrefix+"PORTATARIFATEU3";
         edtPortaTarifaTTA2_Internalname = sPrefix+"PORTATARIFATTA2";
         edtPortaTarifaTEU2_Internalname = sPrefix+"PORTATARIFATEU2";
         edtPortaTarifaTTA1_Internalname = sPrefix+"PORTATARIFATTA1";
         edtPortaTarifaTEU1_Internalname = sPrefix+"PORTATARIFATEU1";
         div_Internalname = sPrefix+"";
         div_Internalname = sPrefix+"";
         div_Internalname = sPrefix+"";
         div_Internalname = sPrefix+"";
         divGridtable_Internalname = sPrefix+"GRIDTABLE";
         divGridtable_Internalname = sPrefix+"GRIDTABLE";
         div_Internalname = sPrefix+"";
         div_Internalname = sPrefix+"";
         div_Internalname = sPrefix+"";
         div_Internalname = sPrefix+"";
         cmbPortaContenedoresEsclusa_Internalname = sPrefix+"PORTACONTENEDORESESCLUSA";
         cmbPortaContenedoresEsclusa_Internalname = sPrefix+"PORTACONTENEDORESESCLUSA";
         div_Internalname = sPrefix+"";
         div_Internalname = sPrefix+"";
         div_Internalname = sPrefix+"";
         div_Internalname = sPrefix+"";
         div_Internalname = sPrefix+"";
         div_Internalname = sPrefix+"";
         divMain_Internalname = sPrefix+"MAIN";
         divMain_Internalname = sPrefix+"MAIN";
         div_Internalname = sPrefix+"";
         div_Internalname = sPrefix+"";
         Form.Internalname = sPrefix+"FORM";
         Form.Internalname = sPrefix+"FORM";
         subGrid_Internalname = sPrefix+"GRID";
         subGrid_Internalname = sPrefix+"GRID";
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
         edtPortaTarifaTEU1_Jsonclick = "";
         edtPortaTarifaTTA1_Jsonclick = "";
         edtPortaTarifaTEU2_Jsonclick = "";
         edtPortaTarifaTTA2_Jsonclick = "";
         edtPortaTarifaTEU3_Jsonclick = "";
         edtPortaTarifaTTA3_Jsonclick = "";
         edtPortaTarifaTEU4_Jsonclick = "";
         edtPortaTarifaTTA4_Jsonclick = "";
         edtPortaRangoFinTEU_Jsonclick = "";
         edtPortaRangoIniTEU_Jsonclick = "";
         edtPortaRango_Jsonclick = "";
         cmbPortaContenedoresEsclusa_Jsonclick = "";
         cmbPortaContenedoresEsclusa.Enabled = 0;
         cmbPortaContenedoresEsclusa.Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         subGrid_Class = "WorkWith";
         subGrid_Backcolorstyle = 0;
         subGrid_Rows = 0;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows'},{av:'AV7PortaContenedoresEsclusa',fld:'vPORTACONTENEDORESESCLUSA'},{av:'sPrefix'}],oparms:[]}");
         setEventMetadata("GRID.LOAD","{handler:'E12152',iparms:[],oparms:[]}");
         setEventMetadata("GRID_FIRSTPAGE","{handler:'subgrid_firstpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows'},{av:'AV7PortaContenedoresEsclusa',fld:'vPORTACONTENEDORESESCLUSA'},{av:'sPrefix'}],oparms:[]}");
         setEventMetadata("GRID_PREVPAGE","{handler:'subgrid_previouspage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows'},{av:'AV7PortaContenedoresEsclusa',fld:'vPORTACONTENEDORESESCLUSA'},{av:'sPrefix'}],oparms:[]}");
         setEventMetadata("GRID_NEXTPAGE","{handler:'subgrid_nextpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows'},{av:'AV7PortaContenedoresEsclusa',fld:'vPORTACONTENEDORESESCLUSA'},{av:'sPrefix'}],oparms:[]}");
         setEventMetadata("GRID_LASTPAGE","{handler:'subgrid_lastpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows'},{av:'AV7PortaContenedoresEsclusa',fld:'vPORTACONTENEDORESESCLUSA'},{av:'sPrefix'}],oparms:[]}");
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
         sPrefix = "";
         AV15Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         GX_FocusControl = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXKey = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         scmdbuf = "";
         H00152_A22PortaContenedoresEsclusa = new short[1] ;
         H00152_A34PortaTarifaTEU1 = new decimal[1] ;
         H00152_A33PortaTarifaTTA1 = new decimal[1] ;
         H00152_A32PortaTarifaTEU2 = new decimal[1] ;
         H00152_A31PortaTarifaTTA2 = new decimal[1] ;
         H00152_A30PortaTarifaTEU3 = new decimal[1] ;
         H00152_A29PortaTarifaTTA3 = new decimal[1] ;
         H00152_A28PortaTarifaTEU4 = new decimal[1] ;
         H00152_A27PortaTarifaTTA4 = new decimal[1] ;
         H00152_A26PortaRangoFinTEU = new long[1] ;
         H00152_A25PortaRangoIniTEU = new long[1] ;
         H00152_A24PortaRango = new short[1] ;
         H00153_AGRID_nRecordCount = new long[1] ;
         GridRow = new GXWebRow();
         AV10TrnContext = new SdtTransactionContext(context);
         AV9HTTPRequest = new GxHttpRequest( context);
         AV11TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV8Session = context.GetSession();
         sCtrlAV7PortaContenedoresEsclusa = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.portacontenedoresrangowc__default(),
            new Object[][] {
                new Object[] {
               H00152_A22PortaContenedoresEsclusa, H00152_A34PortaTarifaTEU1, H00152_A33PortaTarifaTTA1, H00152_A32PortaTarifaTEU2, H00152_A31PortaTarifaTTA2, H00152_A30PortaTarifaTEU3, H00152_A29PortaTarifaTTA3, H00152_A28PortaTarifaTEU4, H00152_A27PortaTarifaTTA4, H00152_A26PortaRangoFinTEU,
               H00152_A25PortaRangoIniTEU, H00152_A24PortaRango
               }
               , new Object[] {
               H00153_AGRID_nRecordCount
               }
            }
         );
         AV15Pgmname = "PortaContenedoresRangoWC";
         /* GeneXus formulas. */
         AV15Pgmname = "PortaContenedoresRangoWC";
         context.Gx_err = 0;
      }

      private short AV7PortaContenedoresEsclusa ;
      private short wcpOAV7PortaContenedoresEsclusa ;
      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short nRC_GXsfl_9 ;
      private short nGXsfl_9_idx=1 ;
      private short initialized ;
      private short nGXWrapped ;
      private short GRID_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short A24PortaRango ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short A22PortaContenedoresEsclusa ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXsfl_9_Refreshing=0 ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long A25PortaRangoIniTEU ;
      private long A26PortaRangoFinTEU ;
      private long GXPagingTo2 ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private decimal A27PortaTarifaTTA4 ;
      private decimal A28PortaTarifaTEU4 ;
      private decimal A29PortaTarifaTTA3 ;
      private decimal A30PortaTarifaTEU3 ;
      private decimal A31PortaTarifaTTA2 ;
      private decimal A32PortaTarifaTEU2 ;
      private decimal A33PortaTarifaTTA1 ;
      private decimal A34PortaTarifaTEU1 ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_9_idx="0001" ;
      private String AV15Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String divMain_Internalname ;
      private String divGridtable_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String cmbPortaContenedoresEsclusa_Internalname ;
      private String cmbPortaContenedoresEsclusa_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtPortaRango_Internalname ;
      private String edtPortaRangoIniTEU_Internalname ;
      private String edtPortaRangoFinTEU_Internalname ;
      private String edtPortaTarifaTTA4_Internalname ;
      private String edtPortaTarifaTEU4_Internalname ;
      private String edtPortaTarifaTTA3_Internalname ;
      private String edtPortaTarifaTEU3_Internalname ;
      private String edtPortaTarifaTTA2_Internalname ;
      private String edtPortaTarifaTEU2_Internalname ;
      private String edtPortaTarifaTTA1_Internalname ;
      private String edtPortaTarifaTEU1_Internalname ;
      private String GXKey ;
      private String scmdbuf ;
      private String sCtrlAV7PortaContenedoresEsclusa ;
      private String ROClassString ;
      private String edtPortaRango_Jsonclick ;
      private String edtPortaRangoIniTEU_Jsonclick ;
      private String edtPortaRangoFinTEU_Jsonclick ;
      private String edtPortaTarifaTTA4_Jsonclick ;
      private String edtPortaTarifaTEU4_Jsonclick ;
      private String edtPortaTarifaTTA3_Jsonclick ;
      private String edtPortaTarifaTEU3_Jsonclick ;
      private String edtPortaTarifaTTA2_Jsonclick ;
      private String edtPortaTarifaTEU2_Jsonclick ;
      private String edtPortaTarifaTTA1_Jsonclick ;
      private String edtPortaTarifaTEU1_Jsonclick ;
      private String div_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbPortaContenedoresEsclusa ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_default ;
      private short[] H00152_A22PortaContenedoresEsclusa ;
      private decimal[] H00152_A34PortaTarifaTEU1 ;
      private decimal[] H00152_A33PortaTarifaTTA1 ;
      private decimal[] H00152_A32PortaTarifaTEU2 ;
      private decimal[] H00152_A31PortaTarifaTTA2 ;
      private decimal[] H00152_A30PortaTarifaTEU3 ;
      private decimal[] H00152_A29PortaTarifaTTA3 ;
      private decimal[] H00152_A28PortaTarifaTEU4 ;
      private decimal[] H00152_A27PortaTarifaTTA4 ;
      private long[] H00152_A26PortaRangoFinTEU ;
      private long[] H00152_A25PortaRangoIniTEU ;
      private short[] H00152_A24PortaRango ;
      private long[] H00153_AGRID_nRecordCount ;
      private GxHttpRequest AV9HTTPRequest ;
      private IGxSession AV8Session ;
      private SdtTransactionContext AV10TrnContext ;
      private SdtTransactionContext_Attribute AV11TrnContextAtt ;
   }

   public class portacontenedoresrangowc__default : DataStoreHelperBase, IDataStoreHelper
   {
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
          Object[] prmH00152 ;
          prmH00152 = new Object[] {
          new Object[] {"@AV7PortaContenedoresEsclusa",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,6,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmH00153 ;
          prmH00153 = new Object[] {
          new Object[] {"@AV7PortaContenedoresEsclusa",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00152", "SELECT * FROM (SELECT  [PortaContenedoresEsclusa], [PortaTarifaTEU1], [PortaTarifaTTA1], [PortaTarifaTEU2], [PortaTarifaTTA2], [PortaTarifaTEU3], [PortaTarifaTTA3], [PortaTarifaTEU4], [PortaTarifaTTA4], [PortaRangoFinTEU], [PortaRangoIniTEU], [PortaRango], ROW_NUMBER() OVER ( ORDER BY [PortaContenedoresEsclusa], [PortaRango] ) AS GX_ROW_NUMBER FROM [PortaContenedoresRango] WITH (NOLOCK) WHERE [PortaContenedoresEsclusa] = @AV7PortaContenedoresEsclusa) AS GX_CTE WHERE GX_ROW_NUMBER BETWEEN @GXPagingFrom2 AND @GXPagingTo2 OR @GXPagingTo2 < @GXPagingFrom2 AND GX_ROW_NUMBER >= @GXPagingFrom2",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00152,11,0,true,false )
             ,new CursorDef("H00153", "SELECT COUNT(*) FROM [PortaContenedoresRango] WITH (NOLOCK) WHERE [PortaContenedoresEsclusa] = @AV7PortaContenedoresEsclusa ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00153,1,0,true,false )
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
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((decimal[]) buf[7])[0] = rslt.getDecimal(8) ;
                ((decimal[]) buf[8])[0] = rslt.getDecimal(9) ;
                ((long[]) buf[9])[0] = rslt.getLong(10) ;
                ((long[]) buf[10])[0] = rslt.getLong(11) ;
                ((short[]) buf[11])[0] = rslt.getShort(12) ;
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
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (long)parms[2]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
