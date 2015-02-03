/*
               File: WSCalcularPortavehiculosROROSOAP
        Description: Calcular cobro de Portavehiculos y RO-RO
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:14:57.14
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
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using GeneXus.Http.Server;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class awscalcularportavehiculosrorosoap : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
   {
      public override void webExecute( )
      {
         context.SetDefaultTheme("Flat");
         initialize();
         if ( ! context.isAjaxRequest( ) )
         {
            GXSoapHTTPResponse.AppendHeader("Content-type", "text/xml;charset=utf-8");
         }
         if ( StringUtil.StrCmp(StringUtil.Lower( GXSoapHTTPRequest.Method), "get") == 0 )
         {
            if ( StringUtil.StrCmp(StringUtil.Lower( GXSoapHTTPRequest.QueryString), "wsdl") == 0 )
            {
               GXSoapXMLWriter.OpenResponse(GXSoapHTTPResponse);
               GXSoapXMLWriter.WriteStartDocument("utf-8", 0);
               GXSoapXMLWriter.WriteStartElement("definitions");
               GXSoapXMLWriter.WriteAttribute("name", "WSCalcularPortavehiculosROROSOAP");
               GXSoapXMLWriter.WriteAttribute("targetNamespace", "CalcularPeajes");
               GXSoapXMLWriter.WriteAttribute("xmlns:wsdlns", "CalcularPeajes");
               GXSoapXMLWriter.WriteAttribute("xmlns:soap", "http://schemas.xmlsoap.org/wsdl/soap/");
               GXSoapXMLWriter.WriteAttribute("xmlns:xsd", "http://www.w3.org/2001/XMLSchema");
               GXSoapXMLWriter.WriteAttribute("xmlns", "http://schemas.xmlsoap.org/wsdl/");
               GXSoapXMLWriter.WriteAttribute("xmlns:tns", "CalcularPeajes");
               GXSoapXMLWriter.WriteStartElement("types");
               GXSoapXMLWriter.WriteStartElement("schema");
               GXSoapXMLWriter.WriteAttribute("targetNamespace", "CalcularPeajes");
               GXSoapXMLWriter.WriteAttribute("xmlns", "http://www.w3.org/2001/XMLSchema");
               GXSoapXMLWriter.WriteAttribute("xmlns:SOAP-ENC", "http://schemas.xmlsoap.org/soap/encoding/");
               GXSoapXMLWriter.WriteAttribute("elementFormDefault", "qualified");
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("name", "WSCalcularPortavehiculosROROSOAP.Execute");
               GXSoapXMLWriter.WriteStartElement("complexType");
               GXSoapXMLWriter.WriteStartElement("sequence");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "Veh_roro_ton_ini");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:double");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "Veh_roro_util_ini");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:double");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("name", "WSCalcularPortavehiculosROROSOAP.ExecuteResponse");
               GXSoapXMLWriter.WriteStartElement("complexType");
               GXSoapXMLWriter.WriteStartElement("sequence");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "Resultado");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:string");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("message");
               GXSoapXMLWriter.WriteAttribute("name", "WSCalcularPortavehiculosROROSOAP.ExecuteSoapIn");
               GXSoapXMLWriter.WriteElement("part", "");
               GXSoapXMLWriter.WriteAttribute("name", "parameters");
               GXSoapXMLWriter.WriteAttribute("element", "tns:WSCalcularPortavehiculosROROSOAP.Execute");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("message");
               GXSoapXMLWriter.WriteAttribute("name", "WSCalcularPortavehiculosROROSOAP.ExecuteSoapOut");
               GXSoapXMLWriter.WriteElement("part", "");
               GXSoapXMLWriter.WriteAttribute("name", "parameters");
               GXSoapXMLWriter.WriteAttribute("element", "tns:WSCalcularPortavehiculosROROSOAP.ExecuteResponse");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("portType");
               GXSoapXMLWriter.WriteAttribute("name", "WSCalcularPortavehiculosROROSOAPSoapPort");
               GXSoapXMLWriter.WriteStartElement("operation");
               GXSoapXMLWriter.WriteAttribute("name", "Execute");
               GXSoapXMLWriter.WriteElement("input", "");
               GXSoapXMLWriter.WriteAttribute("message", "wsdlns:"+"WSCalcularPortavehiculosROROSOAP.ExecuteSoapIn");
               GXSoapXMLWriter.WriteElement("output", "");
               GXSoapXMLWriter.WriteAttribute("message", "wsdlns:"+"WSCalcularPortavehiculosROROSOAP.ExecuteSoapOut");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("binding");
               GXSoapXMLWriter.WriteAttribute("name", "WSCalcularPortavehiculosROROSOAPSoapBinding");
               GXSoapXMLWriter.WriteAttribute("type", "wsdlns:"+"WSCalcularPortavehiculosROROSOAPSoapPort");
               GXSoapXMLWriter.WriteElement("soap:binding", "");
               GXSoapXMLWriter.WriteAttribute("style", "document");
               GXSoapXMLWriter.WriteAttribute("transport", "http://schemas.xmlsoap.org/soap/http");
               GXSoapXMLWriter.WriteStartElement("operation");
               GXSoapXMLWriter.WriteAttribute("name", "Execute");
               GXSoapXMLWriter.WriteElement("soap:operation", "");
               GXSoapXMLWriter.WriteAttribute("soapAction", "CalcularPeajesaction/"+"AWSCALCULARPORTAVEHICULOSROROSOAP.Execute");
               GXSoapXMLWriter.WriteStartElement("input");
               GXSoapXMLWriter.WriteElement("soap:body", "");
               GXSoapXMLWriter.WriteAttribute("use", "literal");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("output");
               GXSoapXMLWriter.WriteElement("soap:body", "");
               GXSoapXMLWriter.WriteAttribute("use", "literal");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("service");
               GXSoapXMLWriter.WriteAttribute("name", "WSCalcularPortavehiculosROROSOAP");
               GXSoapXMLWriter.WriteStartElement("port");
               GXSoapXMLWriter.WriteAttribute("name", "WSCalcularPortavehiculosROROSOAPSoapPort");
               GXSoapXMLWriter.WriteAttribute("binding", "wsdlns:"+"WSCalcularPortavehiculosROROSOAPSoapBinding");
               GXSoapXMLWriter.WriteElement("soap:address", "");
               GXSoapXMLWriter.WriteAttribute("location", "http://"+context.GetServerName( )+((context.GetServerPort( )>0)&&(context.GetServerPort( )!=80)&&(context.GetServerPort( )!=443) ? ":"+StringUtil.LTrim( StringUtil.Str( (decimal)(context.GetServerPort( )), 6, 0)) : "")+context.GetScriptPath( )+"awscalcularportavehiculosrorosoap.aspx");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.Close();
               return  ;
            }
            else
            {
               currSoapErr = (short)(-20000);
               currSoapErrmsg = "No SOAP request found. Call " + "http://" + context.GetServerName( ) + ((context.GetServerPort( )>0)&&(context.GetServerPort( )!=80)&&(context.GetServerPort( )!=443) ? ":"+StringUtil.LTrim( StringUtil.Str( (decimal)(context.GetServerPort( )), 6, 0)) : "") + context.GetScriptPath( ) + "awscalcularportavehiculosrorosoap.aspx" + "?wsdl to get the WSDL.";
            }
         }
         if ( currSoapErr == 0 )
         {
            GXSoapXMLReader.OpenRequest(GXSoapHTTPRequest);
            GXSoapError = GXSoapXMLReader.Read();
            while ( GXSoapError > 0 )
            {
               if ( StringUtil.StringSearch( GXSoapXMLReader.Name, "Body", 1) > 0 )
               {
                  if (true) break;
               }
               GXSoapError = GXSoapXMLReader.Read();
            }
            if ( GXSoapError > 0 )
            {
               GXSoapError = GXSoapXMLReader.Read();
               if ( GXSoapError > 0 )
               {
                  currMethod = GXSoapXMLReader.Name;
                  if ( StringUtil.StringSearch( currMethod+"&", "Execute&", 1) > 0 )
                  {
                     if ( currSoapErr == 0 )
                     {
                        sTagName = GXSoapXMLReader.Name;
                        if ( GXSoapXMLReader.IsSimple == 0 )
                        {
                           GXSoapError = GXSoapXMLReader.Read();
                           nOutParmCount = 0;
                           while ( ( ( StringUtil.StrCmp(GXSoapXMLReader.Name, sTagName) != 0 ) || ( GXSoapXMLReader.NodeType == 1 ) ) && ( GXSoapError > 0 ) )
                           {
                              readOk = 0;
                              if ( StringUtil.StrCmp2( GXSoapXMLReader.LocalName, "Veh_roro_ton_ini") && ( GXSoapXMLReader.NodeType != 2 ) && ( StringUtil.StrCmp(GXSoapXMLReader.NamespaceURI, "CalcularPeajes") == 0 ) )
                              {
                                 AV9VEH_RORO_TON_INI = NumberUtil.Val( GXSoapXMLReader.Value, ".");
                                 if ( GXSoapError > 0 )
                                 {
                                    readOk = 1;
                                 }
                                 GXSoapError = GXSoapXMLReader.Read();
                              }
                              if ( StringUtil.StrCmp2( GXSoapXMLReader.LocalName, "Veh_roro_util_ini") && ( GXSoapXMLReader.NodeType != 2 ) && ( StringUtil.StrCmp(GXSoapXMLReader.NamespaceURI, "CalcularPeajes") == 0 ) )
                              {
                                 AV10VEH_RORO_UTIL_INI = NumberUtil.Val( GXSoapXMLReader.Value, ".");
                                 if ( GXSoapError > 0 )
                                 {
                                    readOk = 1;
                                 }
                                 GXSoapError = GXSoapXMLReader.Read();
                              }
                              nOutParmCount = (short)(nOutParmCount+1);
                              if ( readOk == 0 )
                              {
                                 context.sSOAPErrMsg = context.sSOAPErrMsg + "Error reading " + sTagName + StringUtil.NewLine( );
                                 context.sSOAPErrMsg = context.sSOAPErrMsg + "Message: " + GXSoapXMLReader.ReadRawXML();
                                 GXSoapError = (short)(nOutParmCount*-1);
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     currSoapErr = (short)(-20002);
                     currSoapErrmsg = "Wrong method called. Expected method: " + "Execute";
                  }
               }
            }
            GXSoapXMLReader.Close();
         }
         if ( currSoapErr == 0 )
         {
            if ( GXSoapError < 0 )
            {
               currSoapErr = (short)(GXSoapError*-1);
               currSoapErrmsg = context.sSOAPErrMsg;
            }
            else
            {
               if ( GXSoapXMLReader.ErrCode > 0 )
               {
                  currSoapErr = (short)(GXSoapXMLReader.ErrCode*-1);
                  currSoapErrmsg = GXSoapXMLReader.ErrDescription;
               }
               else
               {
                  if ( GXSoapError == 0 )
                  {
                     currSoapErr = (short)(-20001);
                     currSoapErrmsg = "Malformed SOAP message.";
                  }
                  else
                  {
                     currSoapErr = 0;
                     currSoapErrmsg = "No error.";
                  }
               }
            }
         }
         if ( currSoapErr == 0 )
         {
            executePrivate();
         }
         context.CloseConnections() ;
         GXSoapXMLWriter.OpenResponse(GXSoapHTTPResponse);
         GXSoapXMLWriter.WriteStartDocument("utf-8", 0);
         GXSoapXMLWriter.WriteStartElement("SOAP-ENV:Envelope");
         GXSoapXMLWriter.WriteAttribute("xmlns:SOAP-ENV", "http://schemas.xmlsoap.org/soap/envelope/");
         GXSoapXMLWriter.WriteAttribute("xmlns:xsd", "http://www.w3.org/2001/XMLSchema");
         GXSoapXMLWriter.WriteAttribute("xmlns:SOAP-ENC", "http://schemas.xmlsoap.org/soap/encoding/");
         GXSoapXMLWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
         if ( StringUtil.StringSearch( currMethod+"&", "Execute&", 1) > 0 )
         {
            GXSoapXMLWriter.WriteStartElement("SOAP-ENV:Body");
            GXSoapXMLWriter.WriteStartElement("WSCalcularPortavehiculosROROSOAP.ExecuteResponse");
            GXSoapXMLWriter.WriteAttribute("xmlns", "CalcularPeajes");
            if ( currSoapErr == 0 )
            {
               GXSoapXMLWriter.WriteElement("Resultado", StringUtil.RTrim( AV11Resultado));
               GXSoapXMLWriter.WriteAttribute("xmlns", "CalcularPeajes");
            }
            else
            {
               GXSoapXMLWriter.WriteStartElement("SOAP-ENV:Fault");
               GXSoapXMLWriter.WriteElement("faultcode", "SOAP-ENV:Client");
               GXSoapXMLWriter.WriteElement("faultstring", currSoapErrmsg);
               GXSoapXMLWriter.WriteElement("detail", StringUtil.Trim( StringUtil.Str( (decimal)(currSoapErr), 10, 0)));
               GXSoapXMLWriter.WriteEndElement();
            }
            GXSoapXMLWriter.WriteEndElement();
            GXSoapXMLWriter.WriteEndElement();
         }
         GXSoapXMLWriter.WriteEndElement();
         GXSoapXMLWriter.Close();
         cleanup();
      }

      public awscalcularportavehiculosrorosoap( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public awscalcularportavehiculosrorosoap( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( decimal aP0_VEH_RORO_TON_INI ,
                           decimal aP1_VEH_RORO_UTIL_INI ,
                           out String aP2_Resultado )
      {
         this.AV9VEH_RORO_TON_INI = aP0_VEH_RORO_TON_INI;
         this.AV10VEH_RORO_UTIL_INI = aP1_VEH_RORO_UTIL_INI;
         this.AV11Resultado = "" ;
         initialize();
         executePrivate();
         aP2_Resultado=this.AV11Resultado;
      }

      public String executeUdp( decimal aP0_VEH_RORO_TON_INI ,
                                decimal aP1_VEH_RORO_UTIL_INI )
      {
         this.AV9VEH_RORO_TON_INI = aP0_VEH_RORO_TON_INI;
         this.AV10VEH_RORO_UTIL_INI = aP1_VEH_RORO_UTIL_INI;
         this.AV11Resultado = "" ;
         initialize();
         executePrivate();
         aP2_Resultado=this.AV11Resultado;
         return AV11Resultado ;
      }

      public void executeSubmit( decimal aP0_VEH_RORO_TON_INI ,
                                 decimal aP1_VEH_RORO_UTIL_INI ,
                                 out String aP2_Resultado )
      {
         awscalcularportavehiculosrorosoap objawscalcularportavehiculosrorosoap;
         objawscalcularportavehiculosrorosoap = new awscalcularportavehiculosrorosoap();
         objawscalcularportavehiculosrorosoap.AV9VEH_RORO_TON_INI = aP0_VEH_RORO_TON_INI;
         objawscalcularportavehiculosrorosoap.AV10VEH_RORO_UTIL_INI = aP1_VEH_RORO_UTIL_INI;
         objawscalcularportavehiculosrorosoap.AV11Resultado = "" ;
         objawscalcularportavehiculosrorosoap.context.SetSubmitInitialConfig(context);
         objawscalcularportavehiculosrorosoap.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objawscalcularportavehiculosrorosoap);
         aP2_Resultado=this.AV11Resultado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((awscalcularportavehiculosrorosoap)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "ClienteWeb Peajes", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         if ( ( AV10VEH_RORO_UTIL_INI > Convert.ToDecimal( 0 )) )
         {
            /* Using cursor P000I2 */
            pr_default.execute(0, new Object[] {AV9VEH_RORO_TON_INI, AV10VEH_RORO_UTIL_INI});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A42VEH_RORO_UTIL_FIN = P000I2_A42VEH_RORO_UTIL_FIN[0];
               A41VEH_RORO_UTIL_INI = P000I2_A41VEH_RORO_UTIL_INI[0];
               A40VEH_RORO_TON_FIN = P000I2_A40VEH_RORO_TON_FIN[0];
               A39VEH_RORO_TON_INI = P000I2_A39VEH_RORO_TON_INI[0];
               A43VEH_RORO_TARIFA = P000I2_A43VEH_RORO_TARIFA[0];
               A38VEH_RORO_ID = P000I2_A38VEH_RORO_ID[0];
               AV8SdtResultado.gxTpr_Sdtresultadopanamax = (decimal)(A43VEH_RORO_TARIFA*AV9VEH_RORO_TON_INI);
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(0);
            }
            pr_default.close(0);
         }
         else
         {
            /* Using cursor P000I3 */
            pr_default.execute(1, new Object[] {AV9VEH_RORO_TON_INI});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A42VEH_RORO_UTIL_FIN = P000I3_A42VEH_RORO_UTIL_FIN[0];
               A41VEH_RORO_UTIL_INI = P000I3_A41VEH_RORO_UTIL_INI[0];
               A40VEH_RORO_TON_FIN = P000I3_A40VEH_RORO_TON_FIN[0];
               A39VEH_RORO_TON_INI = P000I3_A39VEH_RORO_TON_INI[0];
               A43VEH_RORO_TARIFA = P000I3_A43VEH_RORO_TARIFA[0];
               A38VEH_RORO_ID = P000I3_A38VEH_RORO_ID[0];
               AV8SdtResultado.gxTpr_Sdtresultadopanamax = (decimal)(A43VEH_RORO_TARIFA*AV9VEH_RORO_TON_INI);
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(1);
            }
            pr_default.close(1);
         }
         AV11Resultado = StringUtil.Trim( AV8SdtResultado.ToJSonString(false));
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
         {
            context.Redirect( context.wjLoc );
            context.wjLoc = "";
         }
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         GXSoapHTTPRequest = new GxHttpRequest(context) ;
         GXSoapXMLReader = new GXXMLReader(context.GetPhysicalPath());
         GXSoapHTTPResponse = new GxHttpResponse(context) ;
         GXSoapXMLWriter = new GXXMLWriter(context.GetPhysicalPath());
         currSoapErrmsg = "";
         currMethod = "";
         sTagName = "";
         scmdbuf = "";
         P000I2_A42VEH_RORO_UTIL_FIN = new decimal[1] ;
         P000I2_A41VEH_RORO_UTIL_INI = new decimal[1] ;
         P000I2_A40VEH_RORO_TON_FIN = new decimal[1] ;
         P000I2_A39VEH_RORO_TON_INI = new decimal[1] ;
         P000I2_A43VEH_RORO_TARIFA = new decimal[1] ;
         P000I2_A38VEH_RORO_ID = new short[1] ;
         AV8SdtResultado = new SdtSdtResultado(context);
         P000I3_A42VEH_RORO_UTIL_FIN = new decimal[1] ;
         P000I3_A41VEH_RORO_UTIL_INI = new decimal[1] ;
         P000I3_A40VEH_RORO_TON_FIN = new decimal[1] ;
         P000I3_A39VEH_RORO_TON_INI = new decimal[1] ;
         P000I3_A43VEH_RORO_TARIFA = new decimal[1] ;
         P000I3_A38VEH_RORO_ID = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.awscalcularportavehiculosrorosoap__default(),
            new Object[][] {
                new Object[] {
               P000I2_A42VEH_RORO_UTIL_FIN, P000I2_A41VEH_RORO_UTIL_INI, P000I2_A40VEH_RORO_TON_FIN, P000I2_A39VEH_RORO_TON_INI, P000I2_A43VEH_RORO_TARIFA, P000I2_A38VEH_RORO_ID
               }
               , new Object[] {
               P000I3_A42VEH_RORO_UTIL_FIN, P000I3_A41VEH_RORO_UTIL_INI, P000I3_A40VEH_RORO_TON_FIN, P000I3_A39VEH_RORO_TON_INI, P000I3_A43VEH_RORO_TARIFA, P000I3_A38VEH_RORO_ID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short GXSoapError ;
      private short currSoapErr ;
      private short readOk ;
      private short nOutParmCount ;
      private short A38VEH_RORO_ID ;
      private decimal AV9VEH_RORO_TON_INI ;
      private decimal AV10VEH_RORO_UTIL_INI ;
      private decimal A42VEH_RORO_UTIL_FIN ;
      private decimal A41VEH_RORO_UTIL_INI ;
      private decimal A40VEH_RORO_TON_FIN ;
      private decimal A39VEH_RORO_TON_INI ;
      private decimal A43VEH_RORO_TARIFA ;
      private String currSoapErrmsg ;
      private String currMethod ;
      private String sTagName ;
      private String scmdbuf ;
      private String AV11Resultado ;
      private GXXMLReader GXSoapXMLReader ;
      private GXXMLWriter GXSoapXMLWriter ;
      private GxHttpRequest GXSoapHTTPRequest ;
      private GxHttpResponse GXSoapHTTPResponse ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private decimal[] P000I2_A42VEH_RORO_UTIL_FIN ;
      private decimal[] P000I2_A41VEH_RORO_UTIL_INI ;
      private decimal[] P000I2_A40VEH_RORO_TON_FIN ;
      private decimal[] P000I2_A39VEH_RORO_TON_INI ;
      private decimal[] P000I2_A43VEH_RORO_TARIFA ;
      private short[] P000I2_A38VEH_RORO_ID ;
      private decimal[] P000I3_A42VEH_RORO_UTIL_FIN ;
      private decimal[] P000I3_A41VEH_RORO_UTIL_INI ;
      private decimal[] P000I3_A40VEH_RORO_TON_FIN ;
      private decimal[] P000I3_A39VEH_RORO_TON_INI ;
      private decimal[] P000I3_A43VEH_RORO_TARIFA ;
      private short[] P000I3_A38VEH_RORO_ID ;
      private String aP2_Resultado ;
      private SdtSdtResultado AV8SdtResultado ;
   }

   public class awscalcularportavehiculosrorosoap__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000I2 ;
          prmP000I2 = new Object[] {
          new Object[] {"@AV9VEH_RORO_TON_INI",SqlDbType.Decimal,10,2} ,
          new Object[] {"@AV10VEH_RORO_UTIL_INI",SqlDbType.Decimal,10,2}
          } ;
          Object[] prmP000I3 ;
          prmP000I3 = new Object[] {
          new Object[] {"@AV9VEH_RORO_TON_INI",SqlDbType.Decimal,10,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000I2", "SELECT TOP 1 [VEH_RORO_UTIL_FIN], [VEH_RORO_UTIL_INI], [VEH_RORO_TON_FIN], [VEH_RORO_TON_INI], [VEH_RORO_TARIFA], [VEH_RORO_ID] FROM [VEH_RORO] WITH (NOLOCK) WHERE (@AV9VEH_RORO_TON_INI >= [VEH_RORO_TON_INI] and @AV9VEH_RORO_TON_INI <= [VEH_RORO_TON_FIN]) AND (@AV10VEH_RORO_UTIL_INI >= [VEH_RORO_UTIL_INI] and @AV10VEH_RORO_UTIL_INI <= [VEH_RORO_UTIL_FIN]) ORDER BY [VEH_RORO_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000I2,1,0,false,true )
             ,new CursorDef("P000I3", "SELECT TOP 1 [VEH_RORO_UTIL_FIN], [VEH_RORO_UTIL_INI], [VEH_RORO_TON_FIN], [VEH_RORO_TON_INI], [VEH_RORO_TARIFA], [VEH_RORO_ID] FROM [VEH_RORO] WITH (NOLOCK) WHERE (@AV9VEH_RORO_TON_INI >= [VEH_RORO_TON_INI] and @AV9VEH_RORO_TON_INI <= [VEH_RORO_TON_FIN]) AND ([VEH_RORO_UTIL_INI] = 0.00) AND ([VEH_RORO_UTIL_FIN] = 9.99) ORDER BY [VEH_RORO_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000I3,1,0,false,true )
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
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
             case 1 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
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
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (decimal)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (decimal)parms[0]);
                break;
       }
    }

 }

}
