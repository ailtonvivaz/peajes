/*
               File: TanqueroEsclusasRangoWC
        Description: Tanquero Esclusas Rango WC
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 7:38:12.52
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
   public class tanqueroesclusasrangowc : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public tanqueroesclusasrangowc( )
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

      public tanqueroesclusasrangowc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_TanqueroEsclusasID )
      {
         this.AV7TanqueroEsclusasID = aP0_TanqueroEsclusasID;
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
         cmbTanqueroEsclusasID = new GXCombobox();
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
                  AV7TanqueroEsclusasID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7TanqueroEsclusasID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7TanqueroEsclusasID), 4, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(short)AV7TanqueroEsclusasID});
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
                  AV7TanqueroEsclusasID = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7TanqueroEsclusasID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7TanqueroEsclusasID), 4, 0)));
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrGrid_refresh( subGrid_Rows, AV7TanqueroEsclusasID, sPrefix) ;
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
            PA0N2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV15Pgmname = "TanqueroEsclusasRangoWC";
               context.Gx_err = 0;
               WS0N2( ) ;
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
            context.SendWebValue( context.GetMessage( "Tanquero Esclusas Rango WC", "")) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20151207381254");
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
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" name=\"MAINFORM\" method=\"post\" class=\"form-horizontal Form\" novalidate action=\""+formatLink("tanqueroesclusasrangowc.aspx") + "?" + UrlEncode("" +AV7TanqueroEsclusasID)+"\">") ;
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

      protected void RenderHtmlCloseForm0N2( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_GXsfl_9", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_9), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV7TanqueroEsclusasID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV7TanqueroEsclusasID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vTANQUEROESCLUSASID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7TanqueroEsclusasID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, context.GetLanguageProperty( "decimal_point"), "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("tanqueroesclusasrangowc.js", "?20151207381255");
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
         return "tanqueroesclusasrangowc" ;
      }

      public override String GetPgmdesc( )
      {
         return context.GetMessage( "Tanquero Esclusas Rango WC", "") ;
      }

      protected void WB0N0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "tanqueroesclusasrangowc.aspx");
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
               context.SendWebValue( context.GetMessage( "Identificador de rango", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Banda en CP/SUAB", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tarifa CP/SUAB", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Banda TM", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tarifa TM", "")) ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( context.GetMessage( "Tarifa Lastre", "")) ;
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
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3TanqueroRango), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A8TanqueroBandaCPSUAB), 10, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A4TanqueroTarifaCPSUAB, 7, 2, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A5TanqueroBandaTM), 12, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A6TanqueroTarifaTM, 7, 2, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A7TanqueroTarifaLastre, 7, 2, ".", "")));
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
            GxWebStd.gx_combobox_ctrl1( context, cmbTanqueroEsclusasID, cmbTanqueroEsclusasID_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A1TanqueroEsclusasID), 4, 0)), 1, cmbTanqueroEsclusasID_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "int", "", cmbTanqueroEsclusasID.Visible, cmbTanqueroEsclusasID.Enabled, 0, 0, 4, "chr", 0, "", "", "Attribute", "", "", "", true, "HLP_TanqueroEsclusasRangoWC.htm");
            cmbTanqueroEsclusasID.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A1TanqueroEsclusasID), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbTanqueroEsclusasID_Internalname, "Values", (String)(cmbTanqueroEsclusasID.ToJavascriptSource()));
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</div>") ;
         }
         wbLoad = true;
      }

      protected void START0N2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 10_3_2-86442", 0) ;
               Form.Meta.addItem("description", context.GetMessage( "Tanquero Esclusas Rango WC", ""), 0) ;
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
               STRUP0N0( ) ;
            }
         }
      }

      protected void WS0N2( )
      {
         START0N2( ) ;
         EVT0N2( ) ;
      }

      protected void EVT0N2( )
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
                                 STRUP0N0( ) ;
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
                                 STRUP0N0( ) ;
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
                                 STRUP0N0( ) ;
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
                                 STRUP0N0( ) ;
                              }
                              nGXsfl_9_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_9_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_9_idx), 4, 0)), 4, "0");
                              edtTanqueroRango_Internalname = sPrefix+"TANQUERORANGO_"+sGXsfl_9_idx;
                              edtTanqueroBandaCPSUAB_Internalname = sPrefix+"TANQUEROBANDACPSUAB_"+sGXsfl_9_idx;
                              edtTanqueroTarifaCPSUAB_Internalname = sPrefix+"TANQUEROTARIFACPSUAB_"+sGXsfl_9_idx;
                              edtTanqueroBandaTM_Internalname = sPrefix+"TANQUEROBANDATM_"+sGXsfl_9_idx;
                              edtTanqueroTarifaTM_Internalname = sPrefix+"TANQUEROTARIFATM_"+sGXsfl_9_idx;
                              edtTanqueroTarifaLastre_Internalname = sPrefix+"TANQUEROTARIFALASTRE_"+sGXsfl_9_idx;
                              A3TanqueroRango = (short)(context.localUtil.CToN( cgiGet( edtTanqueroRango_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtTanqueroRango_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A3TanqueroRango), 4, 0)));
                              A8TanqueroBandaCPSUAB = (long)(context.localUtil.CToN( cgiGet( edtTanqueroBandaCPSUAB_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtTanqueroBandaCPSUAB_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A8TanqueroBandaCPSUAB), 10, 0)));
                              A4TanqueroTarifaCPSUAB = context.localUtil.CToN( cgiGet( edtTanqueroTarifaCPSUAB_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtTanqueroTarifaCPSUAB_Internalname, StringUtil.LTrim( StringUtil.Str( A4TanqueroTarifaCPSUAB, 7, 2)));
                              A5TanqueroBandaTM = (long)(context.localUtil.CToN( cgiGet( edtTanqueroBandaTM_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtTanqueroBandaTM_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A5TanqueroBandaTM), 12, 0)));
                              A6TanqueroTarifaTM = context.localUtil.CToN( cgiGet( edtTanqueroTarifaTM_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtTanqueroTarifaTM_Internalname, StringUtil.LTrim( StringUtil.Str( A6TanqueroTarifaTM, 7, 2)));
                              A7TanqueroTarifaLastre = context.localUtil.CToN( cgiGet( edtTanqueroTarifaLastre_Internalname), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep"));
                              context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtTanqueroTarifaLastre_Internalname, StringUtil.LTrim( StringUtil.Str( A7TanqueroTarifaLastre, 7, 2)));
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
                                          /* Execute user event: E110N2 */
                                          E110N2 ();
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
                                          /* Execute user event: E120N2 */
                                          E120N2 ();
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
                                       STRUP0N0( ) ;
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

      protected void WE0N2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm0N2( ) ;
            }
         }
      }

      protected void PA0N2( )
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
            cmbTanqueroEsclusasID.Name = "TANQUEROESCLUSASID";
            cmbTanqueroEsclusasID.WebTags = "";
            cmbTanqueroEsclusasID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), context.GetMessage( "GX_EmptyItemText", ""), 0);
            cmbTanqueroEsclusasID.addItem("1", context.GetMessage( "Panamax", ""), 0);
            cmbTanqueroEsclusasID.addItem("2", context.GetMessage( "Neopanamax", ""), 0);
            if ( cmbTanqueroEsclusasID.ItemCount > 0 )
            {
               A1TanqueroEsclusasID = (short)(NumberUtil.Val( cmbTanqueroEsclusasID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A1TanqueroEsclusasID), 4, 0))), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1TanqueroEsclusasID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1TanqueroEsclusasID), 4, 0)));
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
         edtTanqueroRango_Internalname = sPrefix+"TANQUERORANGO_"+sGXsfl_9_idx;
         edtTanqueroBandaCPSUAB_Internalname = sPrefix+"TANQUEROBANDACPSUAB_"+sGXsfl_9_idx;
         edtTanqueroTarifaCPSUAB_Internalname = sPrefix+"TANQUEROTARIFACPSUAB_"+sGXsfl_9_idx;
         edtTanqueroBandaTM_Internalname = sPrefix+"TANQUEROBANDATM_"+sGXsfl_9_idx;
         edtTanqueroTarifaTM_Internalname = sPrefix+"TANQUEROTARIFATM_"+sGXsfl_9_idx;
         edtTanqueroTarifaLastre_Internalname = sPrefix+"TANQUEROTARIFALASTRE_"+sGXsfl_9_idx;
         while ( nGXsfl_9_idx <= nRC_GXsfl_9 )
         {
            sendrow_92( ) ;
            nGXsfl_9_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_9_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_9_idx+1));
            sGXsfl_9_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_9_idx), 4, 0)), 4, "0");
            edtTanqueroRango_Internalname = sPrefix+"TANQUERORANGO_"+sGXsfl_9_idx;
            edtTanqueroBandaCPSUAB_Internalname = sPrefix+"TANQUEROBANDACPSUAB_"+sGXsfl_9_idx;
            edtTanqueroTarifaCPSUAB_Internalname = sPrefix+"TANQUEROTARIFACPSUAB_"+sGXsfl_9_idx;
            edtTanqueroBandaTM_Internalname = sPrefix+"TANQUEROBANDATM_"+sGXsfl_9_idx;
            edtTanqueroTarifaTM_Internalname = sPrefix+"TANQUEROTARIFATM_"+sGXsfl_9_idx;
            edtTanqueroTarifaLastre_Internalname = sPrefix+"TANQUEROTARIFALASTRE_"+sGXsfl_9_idx;
         }
         context.GX_webresponse.AddString(GridContainer.ToJavascriptSource());
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV7TanqueroEsclusasID ,
                                       String sPrefix )
      {
         /* GeneXus formulas. */
         AV15Pgmname = "TanqueroEsclusasRangoWC";
         context.Gx_err = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         cmbTanqueroEsclusasID.Name = "TANQUEROESCLUSASID";
         cmbTanqueroEsclusasID.WebTags = "";
         cmbTanqueroEsclusasID.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), context.GetMessage( "GX_EmptyItemText", ""), 0);
         cmbTanqueroEsclusasID.addItem("1", context.GetMessage( "Panamax", ""), 0);
         cmbTanqueroEsclusasID.addItem("2", context.GetMessage( "Neopanamax", ""), 0);
         if ( cmbTanqueroEsclusasID.ItemCount > 0 )
         {
            A1TanqueroEsclusasID = (short)(NumberUtil.Val( cmbTanqueroEsclusasID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A1TanqueroEsclusasID), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1TanqueroEsclusasID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1TanqueroEsclusasID), 4, 0)));
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
         RF0N2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
         /* End function gxgrGrid_refresh */
      }

      public void Refresh( )
      {
         RF0N2( ) ;
      }

      protected void RF0N2( )
      {
         /* GeneXus formulas. */
         AV15Pgmname = "TanqueroEsclusasRangoWC";
         context.Gx_err = 0;
         GridContainer.AddObjectProperty("GridName", "Grid");
         GridContainer.AddObjectProperty("CmpContext", sPrefix);
         GridContainer.AddObjectProperty("InMasterPage", "false");
         wbStart = 9;
         nGXsfl_9_idx = 1;
         sGXsfl_9_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_9_idx), 4, 0)), 4, "0");
         edtTanqueroRango_Internalname = sPrefix+"TANQUERORANGO_"+sGXsfl_9_idx;
         edtTanqueroBandaCPSUAB_Internalname = sPrefix+"TANQUEROBANDACPSUAB_"+sGXsfl_9_idx;
         edtTanqueroTarifaCPSUAB_Internalname = sPrefix+"TANQUEROTARIFACPSUAB_"+sGXsfl_9_idx;
         edtTanqueroBandaTM_Internalname = sPrefix+"TANQUEROBANDATM_"+sGXsfl_9_idx;
         edtTanqueroTarifaTM_Internalname = sPrefix+"TANQUEROTARIFATM_"+sGXsfl_9_idx;
         edtTanqueroTarifaLastre_Internalname = sPrefix+"TANQUEROTARIFALASTRE_"+sGXsfl_9_idx;
         nGXsfl_9_Refreshing = 1;
         GridContainer.PageSize = subGrid_Recordsperpage( );
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            sGXsfl_9_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_9_idx), 4, 0)), 4, "0");
            edtTanqueroRango_Internalname = sPrefix+"TANQUERORANGO_"+sGXsfl_9_idx;
            edtTanqueroBandaCPSUAB_Internalname = sPrefix+"TANQUEROBANDACPSUAB_"+sGXsfl_9_idx;
            edtTanqueroTarifaCPSUAB_Internalname = sPrefix+"TANQUEROTARIFACPSUAB_"+sGXsfl_9_idx;
            edtTanqueroBandaTM_Internalname = sPrefix+"TANQUEROBANDATM_"+sGXsfl_9_idx;
            edtTanqueroTarifaTM_Internalname = sPrefix+"TANQUEROTARIFATM_"+sGXsfl_9_idx;
            edtTanqueroTarifaLastre_Internalname = sPrefix+"TANQUEROTARIFALASTRE_"+sGXsfl_9_idx;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 1 : GRID_nFirstRecordOnPage+1));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : GRID_nFirstRecordOnPage+subGrid_Recordsperpage( )+1);
            /* Using cursor H000N2 */
            pr_default.execute(0, new Object[] {AV7TanqueroEsclusasID, GXPagingFrom2, GXPagingTo2});
            nGXsfl_9_idx = 1;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A1TanqueroEsclusasID = H000N2_A1TanqueroEsclusasID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1TanqueroEsclusasID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1TanqueroEsclusasID), 4, 0)));
               A7TanqueroTarifaLastre = H000N2_A7TanqueroTarifaLastre[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtTanqueroTarifaLastre_Internalname, StringUtil.LTrim( StringUtil.Str( A7TanqueroTarifaLastre, 7, 2)));
               A6TanqueroTarifaTM = H000N2_A6TanqueroTarifaTM[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtTanqueroTarifaTM_Internalname, StringUtil.LTrim( StringUtil.Str( A6TanqueroTarifaTM, 7, 2)));
               A5TanqueroBandaTM = H000N2_A5TanqueroBandaTM[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtTanqueroBandaTM_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A5TanqueroBandaTM), 12, 0)));
               A4TanqueroTarifaCPSUAB = H000N2_A4TanqueroTarifaCPSUAB[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtTanqueroTarifaCPSUAB_Internalname, StringUtil.LTrim( StringUtil.Str( A4TanqueroTarifaCPSUAB, 7, 2)));
               A8TanqueroBandaCPSUAB = H000N2_A8TanqueroBandaCPSUAB[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtTanqueroBandaCPSUAB_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A8TanqueroBandaCPSUAB), 10, 0)));
               A3TanqueroRango = H000N2_A3TanqueroRango[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtTanqueroRango_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(A3TanqueroRango), 4, 0)));
               /* Execute user event: E120N2 */
               E120N2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 9;
            WB0N0( ) ;
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
         /* Using cursor H000N3 */
         pr_default.execute(1, new Object[] {AV7TanqueroEsclusasID});
         GRID_nRecordCount = H000N3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV7TanqueroEsclusasID, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV7TanqueroEsclusasID, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV7TanqueroEsclusasID, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV7TanqueroEsclusasID, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV7TanqueroEsclusasID, sPrefix) ;
         }
         return (int)(0) ;
      }

      protected void STRUP0N0( )
      {
         /* Before Start, stand alone formulas. */
         AV15Pgmname = "TanqueroEsclusasRangoWC";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: E110N2 */
         E110N2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            cmbTanqueroEsclusasID.Name = cmbTanqueroEsclusasID_Internalname;
            cmbTanqueroEsclusasID.CurrentValue = cgiGet( cmbTanqueroEsclusasID_Internalname);
            A1TanqueroEsclusasID = (short)(NumberUtil.Val( cgiGet( cmbTanqueroEsclusasID_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1TanqueroEsclusasID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1TanqueroEsclusasID), 4, 0)));
            if ( cmbTanqueroEsclusasID.ItemCount > 0 )
            {
               A1TanqueroEsclusasID = (short)(NumberUtil.Val( cmbTanqueroEsclusasID.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A1TanqueroEsclusasID), 4, 0))), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A1TanqueroEsclusasID", StringUtil.LTrim( StringUtil.Str( (decimal)(A1TanqueroEsclusasID), 4, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_9 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_9"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            wcpOAV7TanqueroEsclusasID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV7TanqueroEsclusasID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            AV7TanqueroEsclusasID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"vTANQUEROESCLUSASID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
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
         /* Execute user event: E110N2 */
         E110N2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E110N2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV15Pgmname) )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV15Pgmname));
            context.wjLocDisableFrm = 1;
         }
         subGrid_Rows = 10;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         cmbTanqueroEsclusasID.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbTanqueroEsclusasID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTanqueroEsclusasID.Visible), 5, 0)));
         /* Execute user subroutine: S112 */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      private void E120N2( )
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
         AV10TrnContext.gxTpr_Transactionname = "TanqueroEsclusas";
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV10TrnContext", AV10TrnContext);
         AV11TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV11TrnContextAtt.gxTpr_Attributename = "TanqueroEsclusasID";
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11TrnContextAtt", AV11TrnContextAtt);
         AV11TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV7TanqueroEsclusasID), 4, 0);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV11TrnContextAtt", AV11TrnContextAtt);
         AV10TrnContext.gxTpr_Attributes.Add(AV11TrnContextAtt, 0) ;
         AV8Session.Set("TrnContext", AV10TrnContext.ToXml(false, true, "TransactionContext", "CalcularPeajes"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV7TanqueroEsclusasID = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7TanqueroEsclusasID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7TanqueroEsclusasID), 4, 0)));
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
         PA0N2( ) ;
         WS0N2( ) ;
         WE0N2( ) ;
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
         sCtrlAV7TanqueroEsclusasID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA0N2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "tanqueroesclusasrangowc");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA0N2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV7TanqueroEsclusasID = Convert.ToInt16(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7TanqueroEsclusasID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7TanqueroEsclusasID), 4, 0)));
         }
         wcpOAV7TanqueroEsclusasID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV7TanqueroEsclusasID"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
         if ( ! GetJustCreated( ) && ( ( AV7TanqueroEsclusasID != wcpOAV7TanqueroEsclusasID ) ) )
         {
            setjustcreated();
         }
         wcpOAV7TanqueroEsclusasID = AV7TanqueroEsclusasID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV7TanqueroEsclusasID = cgiGet( sPrefix+"AV7TanqueroEsclusasID_CTRL");
         if ( StringUtil.Len( sCtrlAV7TanqueroEsclusasID) > 0 )
         {
            AV7TanqueroEsclusasID = (short)(context.localUtil.CToN( cgiGet( sCtrlAV7TanqueroEsclusasID), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV7TanqueroEsclusasID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7TanqueroEsclusasID), 4, 0)));
         }
         else
         {
            AV7TanqueroEsclusasID = (short)(context.localUtil.CToN( cgiGet( sPrefix+"AV7TanqueroEsclusasID_PARM"), context.GetLanguageProperty( "decimal_point"), context.GetLanguageProperty( "thousand_sep")));
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
         PA0N2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS0N2( ) ;
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
         WS0N2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV7TanqueroEsclusasID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7TanqueroEsclusasID), 4, 0, context.GetLanguageProperty( "decimal_point"), "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV7TanqueroEsclusasID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV7TanqueroEsclusasID_CTRL", StringUtil.RTrim( sCtrlAV7TanqueroEsclusasID));
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
         WE0N2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20151207381274");
            idxLst = (int)(idxLst+1);
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("tanqueroesclusasrangowc.js", "?20151207381274");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_92( )
      {
         sGXsfl_9_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_9_idx), 4, 0)), 4, "0");
         edtTanqueroRango_Internalname = sPrefix+"TANQUERORANGO_"+sGXsfl_9_idx;
         edtTanqueroBandaCPSUAB_Internalname = sPrefix+"TANQUEROBANDACPSUAB_"+sGXsfl_9_idx;
         edtTanqueroTarifaCPSUAB_Internalname = sPrefix+"TANQUEROTARIFACPSUAB_"+sGXsfl_9_idx;
         edtTanqueroBandaTM_Internalname = sPrefix+"TANQUEROBANDATM_"+sGXsfl_9_idx;
         edtTanqueroTarifaTM_Internalname = sPrefix+"TANQUEROTARIFATM_"+sGXsfl_9_idx;
         edtTanqueroTarifaLastre_Internalname = sPrefix+"TANQUEROTARIFALASTRE_"+sGXsfl_9_idx;
         WB0N0( ) ;
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
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTanqueroRango_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A3TanqueroRango), 4, 0, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( (decimal)(A3TanqueroRango), "ZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTanqueroRango_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)9,(short)1,(short)1,(short)0,(bool)true,(String)"",(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTanqueroBandaCPSUAB_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A8TanqueroBandaCPSUAB), 10, 0, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( (decimal)(A8TanqueroBandaCPSUAB), "ZZZZZZZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTanqueroBandaCPSUAB_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)9,(short)1,(short)1,(short)0,(bool)true,(String)"",(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTanqueroTarifaCPSUAB_Internalname,StringUtil.LTrim( StringUtil.NToC( A4TanqueroTarifaCPSUAB, 7, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A4TanqueroTarifaCPSUAB, "ZZZ9.99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTanqueroTarifaCPSUAB_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)7,(short)0,(short)0,(short)9,(short)1,(short)1,(short)0,(bool)true,(String)"DominioTarifa",(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTanqueroBandaTM_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A5TanqueroBandaTM), 12, 0, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( (decimal)(A5TanqueroBandaTM), "ZZZZZZZZZZZ9"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTanqueroBandaTM_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)12,(short)0,(short)0,(short)9,(short)1,(short)1,(short)0,(bool)true,(String)"",(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTanqueroTarifaTM_Internalname,StringUtil.LTrim( StringUtil.NToC( A6TanqueroTarifaTM, 7, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A6TanqueroTarifaTM, "ZZZ9.99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTanqueroTarifaTM_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)7,(short)0,(short)0,(short)9,(short)1,(short)1,(short)0,(bool)true,(String)"DominioTarifa",(String)"right"});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTanqueroTarifaLastre_Internalname,StringUtil.LTrim( StringUtil.NToC( A7TanqueroTarifaLastre, 7, 2, context.GetLanguageProperty( "decimal_point"), "")),context.localUtil.Format( A7TanqueroTarifaLastre, "ZZZ9.99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtTanqueroTarifaLastre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn WWOptionalColumn",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)7,(short)0,(short)0,(short)9,(short)1,(short)1,(short)0,(bool)true,(String)"DominioTarifa",(String)"right"});
            GridContainer.AddRow(GridRow);
            nGXsfl_9_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_9_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_9_idx+1));
            sGXsfl_9_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_9_idx), 4, 0)), 4, "0");
            edtTanqueroRango_Internalname = sPrefix+"TANQUERORANGO_"+sGXsfl_9_idx;
            edtTanqueroBandaCPSUAB_Internalname = sPrefix+"TANQUEROBANDACPSUAB_"+sGXsfl_9_idx;
            edtTanqueroTarifaCPSUAB_Internalname = sPrefix+"TANQUEROTARIFACPSUAB_"+sGXsfl_9_idx;
            edtTanqueroBandaTM_Internalname = sPrefix+"TANQUEROBANDATM_"+sGXsfl_9_idx;
            edtTanqueroTarifaTM_Internalname = sPrefix+"TANQUEROTARIFATM_"+sGXsfl_9_idx;
            edtTanqueroTarifaLastre_Internalname = sPrefix+"TANQUEROTARIFALASTRE_"+sGXsfl_9_idx;
         }
         /* End function sendrow_92 */
      }

      protected void init_default_properties( )
      {
         edtTanqueroRango_Internalname = sPrefix+"TANQUERORANGO";
         edtTanqueroBandaCPSUAB_Internalname = sPrefix+"TANQUEROBANDACPSUAB";
         edtTanqueroTarifaCPSUAB_Internalname = sPrefix+"TANQUEROTARIFACPSUAB";
         edtTanqueroBandaTM_Internalname = sPrefix+"TANQUEROBANDATM";
         edtTanqueroTarifaTM_Internalname = sPrefix+"TANQUEROTARIFATM";
         edtTanqueroTarifaLastre_Internalname = sPrefix+"TANQUEROTARIFALASTRE";
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
         cmbTanqueroEsclusasID_Internalname = sPrefix+"TANQUEROESCLUSASID";
         cmbTanqueroEsclusasID_Internalname = sPrefix+"TANQUEROESCLUSASID";
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
         edtTanqueroTarifaLastre_Jsonclick = "";
         edtTanqueroTarifaTM_Jsonclick = "";
         edtTanqueroBandaTM_Jsonclick = "";
         edtTanqueroTarifaCPSUAB_Jsonclick = "";
         edtTanqueroBandaCPSUAB_Jsonclick = "";
         edtTanqueroRango_Jsonclick = "";
         cmbTanqueroEsclusasID_Jsonclick = "";
         cmbTanqueroEsclusasID.Enabled = 0;
         cmbTanqueroEsclusasID.Visible = 1;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows'},{av:'AV7TanqueroEsclusasID',fld:'vTANQUEROESCLUSASID'},{av:'sPrefix'}],oparms:[]}");
         setEventMetadata("GRID.LOAD","{handler:'E120N2',iparms:[],oparms:[]}");
         setEventMetadata("GRID_FIRSTPAGE","{handler:'subgrid_firstpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows'},{av:'AV7TanqueroEsclusasID',fld:'vTANQUEROESCLUSASID'},{av:'sPrefix'}],oparms:[]}");
         setEventMetadata("GRID_PREVPAGE","{handler:'subgrid_previouspage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows'},{av:'AV7TanqueroEsclusasID',fld:'vTANQUEROESCLUSASID'},{av:'sPrefix'}],oparms:[]}");
         setEventMetadata("GRID_NEXTPAGE","{handler:'subgrid_nextpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows'},{av:'AV7TanqueroEsclusasID',fld:'vTANQUEROESCLUSASID'},{av:'sPrefix'}],oparms:[]}");
         setEventMetadata("GRID_LASTPAGE","{handler:'subgrid_lastpage',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows'},{av:'AV7TanqueroEsclusasID',fld:'vTANQUEROESCLUSASID'},{av:'sPrefix'}],oparms:[]}");
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
         H000N2_A1TanqueroEsclusasID = new short[1] ;
         H000N2_A7TanqueroTarifaLastre = new decimal[1] ;
         H000N2_A6TanqueroTarifaTM = new decimal[1] ;
         H000N2_A5TanqueroBandaTM = new long[1] ;
         H000N2_A4TanqueroTarifaCPSUAB = new decimal[1] ;
         H000N2_A8TanqueroBandaCPSUAB = new long[1] ;
         H000N2_A3TanqueroRango = new short[1] ;
         H000N3_AGRID_nRecordCount = new long[1] ;
         GridRow = new GXWebRow();
         AV10TrnContext = new SdtTransactionContext(context);
         AV9HTTPRequest = new GxHttpRequest( context);
         AV11TrnContextAtt = new SdtTransactionContext_Attribute(context);
         AV8Session = context.GetSession();
         sCtrlAV7TanqueroEsclusasID = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tanqueroesclusasrangowc__default(),
            new Object[][] {
                new Object[] {
               H000N2_A1TanqueroEsclusasID, H000N2_A7TanqueroTarifaLastre, H000N2_A6TanqueroTarifaTM, H000N2_A5TanqueroBandaTM, H000N2_A4TanqueroTarifaCPSUAB, H000N2_A8TanqueroBandaCPSUAB, H000N2_A3TanqueroRango
               }
               , new Object[] {
               H000N3_AGRID_nRecordCount
               }
            }
         );
         AV15Pgmname = "TanqueroEsclusasRangoWC";
         /* GeneXus formulas. */
         AV15Pgmname = "TanqueroEsclusasRangoWC";
         context.Gx_err = 0;
      }

      private short AV7TanqueroEsclusasID ;
      private short wcpOAV7TanqueroEsclusasID ;
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
      private short A3TanqueroRango ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short A1TanqueroEsclusasID ;
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
      private long A8TanqueroBandaCPSUAB ;
      private long A5TanqueroBandaTM ;
      private long GXPagingTo2 ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private decimal A4TanqueroTarifaCPSUAB ;
      private decimal A6TanqueroTarifaTM ;
      private decimal A7TanqueroTarifaLastre ;
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
      private String cmbTanqueroEsclusasID_Internalname ;
      private String cmbTanqueroEsclusasID_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtTanqueroRango_Internalname ;
      private String edtTanqueroBandaCPSUAB_Internalname ;
      private String edtTanqueroTarifaCPSUAB_Internalname ;
      private String edtTanqueroBandaTM_Internalname ;
      private String edtTanqueroTarifaTM_Internalname ;
      private String edtTanqueroTarifaLastre_Internalname ;
      private String GXKey ;
      private String scmdbuf ;
      private String sCtrlAV7TanqueroEsclusasID ;
      private String ROClassString ;
      private String edtTanqueroRango_Jsonclick ;
      private String edtTanqueroBandaCPSUAB_Jsonclick ;
      private String edtTanqueroTarifaCPSUAB_Jsonclick ;
      private String edtTanqueroBandaTM_Jsonclick ;
      private String edtTanqueroTarifaTM_Jsonclick ;
      private String edtTanqueroTarifaLastre_Jsonclick ;
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
      private GXCombobox cmbTanqueroEsclusasID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_default ;
      private short[] H000N2_A1TanqueroEsclusasID ;
      private decimal[] H000N2_A7TanqueroTarifaLastre ;
      private decimal[] H000N2_A6TanqueroTarifaTM ;
      private long[] H000N2_A5TanqueroBandaTM ;
      private decimal[] H000N2_A4TanqueroTarifaCPSUAB ;
      private long[] H000N2_A8TanqueroBandaCPSUAB ;
      private short[] H000N2_A3TanqueroRango ;
      private long[] H000N3_AGRID_nRecordCount ;
      private GxHttpRequest AV9HTTPRequest ;
      private IGxSession AV8Session ;
      private SdtTransactionContext AV10TrnContext ;
      private SdtTransactionContext_Attribute AV11TrnContextAtt ;
   }

   public class tanqueroesclusasrangowc__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH000N2 ;
          prmH000N2 = new Object[] {
          new Object[] {"@AV7TanqueroEsclusasID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,6,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmH000N3 ;
          prmH000N3 = new Object[] {
          new Object[] {"@AV7TanqueroEsclusasID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000N2", "SELECT * FROM (SELECT  [TanqueroEsclusasID], [TanqueroTarifaLastre], [TanqueroTarifaTM], [TanqueroBandaTM], [TanqueroTarifaCPSUAB], [TanqueroBandaCPSUAB], [TanqueroRango], ROW_NUMBER() OVER ( ORDER BY [TanqueroEsclusasID], [TanqueroRango] ) AS GX_ROW_NUMBER FROM [TanqueroEsclusasRango] WITH (NOLOCK) WHERE [TanqueroEsclusasID] = @AV7TanqueroEsclusasID) AS GX_CTE WHERE GX_ROW_NUMBER BETWEEN @GXPagingFrom2 AND @GXPagingTo2 OR @GXPagingTo2 < @GXPagingFrom2 AND GX_ROW_NUMBER >= @GXPagingFrom2",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000N2,11,0,true,false )
             ,new CursorDef("H000N3", "SELECT COUNT(*) FROM [TanqueroEsclusasRango] WITH (NOLOCK) WHERE [TanqueroEsclusasID] = @AV7TanqueroEsclusasID ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000N3,1,0,true,false )
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
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((long[]) buf[5])[0] = rslt.getLong(6) ;
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
