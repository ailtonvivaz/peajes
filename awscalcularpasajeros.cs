/*
               File: wsCalcularPasajeros
        Description: ws Calcular Pasajeros
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:14:58.87
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
   public class awscalcularpasajeros : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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
               GXSoapXMLWriter.WriteAttribute("name", "wsCalcularPasajeros");
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
               GXSoapXMLWriter.WriteAttribute("name", "wsCalcularPasajeros.Execute");
               GXSoapXMLWriter.WriteStartElement("complexType");
               GXSoapXMLWriter.WriteStartElement("sequence");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "Paxitc");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:long");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "Trb");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:long");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "Cpsuab");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:long");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("name", "wsCalcularPasajeros.ExecuteResponse");
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
               GXSoapXMLWriter.WriteAttribute("name", "wsCalcularPasajeros.ExecuteSoapIn");
               GXSoapXMLWriter.WriteElement("part", "");
               GXSoapXMLWriter.WriteAttribute("name", "parameters");
               GXSoapXMLWriter.WriteAttribute("element", "tns:wsCalcularPasajeros.Execute");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("message");
               GXSoapXMLWriter.WriteAttribute("name", "wsCalcularPasajeros.ExecuteSoapOut");
               GXSoapXMLWriter.WriteElement("part", "");
               GXSoapXMLWriter.WriteAttribute("name", "parameters");
               GXSoapXMLWriter.WriteAttribute("element", "tns:wsCalcularPasajeros.ExecuteResponse");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("portType");
               GXSoapXMLWriter.WriteAttribute("name", "wsCalcularPasajerosSoapPort");
               GXSoapXMLWriter.WriteStartElement("operation");
               GXSoapXMLWriter.WriteAttribute("name", "Execute");
               GXSoapXMLWriter.WriteElement("input", "");
               GXSoapXMLWriter.WriteAttribute("message", "wsdlns:"+"wsCalcularPasajeros.ExecuteSoapIn");
               GXSoapXMLWriter.WriteElement("output", "");
               GXSoapXMLWriter.WriteAttribute("message", "wsdlns:"+"wsCalcularPasajeros.ExecuteSoapOut");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("binding");
               GXSoapXMLWriter.WriteAttribute("name", "wsCalcularPasajerosSoapBinding");
               GXSoapXMLWriter.WriteAttribute("type", "wsdlns:"+"wsCalcularPasajerosSoapPort");
               GXSoapXMLWriter.WriteElement("soap:binding", "");
               GXSoapXMLWriter.WriteAttribute("style", "document");
               GXSoapXMLWriter.WriteAttribute("transport", "http://schemas.xmlsoap.org/soap/http");
               GXSoapXMLWriter.WriteStartElement("operation");
               GXSoapXMLWriter.WriteAttribute("name", "Execute");
               GXSoapXMLWriter.WriteElement("soap:operation", "");
               GXSoapXMLWriter.WriteAttribute("soapAction", "CalcularPeajesaction/"+"AWSCALCULARPASAJEROS.Execute");
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
               GXSoapXMLWriter.WriteAttribute("name", "wsCalcularPasajeros");
               GXSoapXMLWriter.WriteStartElement("port");
               GXSoapXMLWriter.WriteAttribute("name", "wsCalcularPasajerosSoapPort");
               GXSoapXMLWriter.WriteAttribute("binding", "wsdlns:"+"wsCalcularPasajerosSoapBinding");
               GXSoapXMLWriter.WriteElement("soap:address", "");
               GXSoapXMLWriter.WriteAttribute("location", "http://"+context.GetServerName( )+((context.GetServerPort( )>0)&&(context.GetServerPort( )!=80)&&(context.GetServerPort( )!=443) ? ":"+StringUtil.LTrim( StringUtil.Str( (decimal)(context.GetServerPort( )), 6, 0)) : "")+context.GetScriptPath( )+"awscalcularpasajeros.aspx");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.Close();
               return  ;
            }
            else
            {
               currSoapErr = (short)(-20000);
               currSoapErrmsg = "No SOAP request found. Call " + "http://" + context.GetServerName( ) + ((context.GetServerPort( )>0)&&(context.GetServerPort( )!=80)&&(context.GetServerPort( )!=443) ? ":"+StringUtil.LTrim( StringUtil.Str( (decimal)(context.GetServerPort( )), 6, 0)) : "") + context.GetScriptPath( ) + "awscalcularpasajeros.aspx" + "?wsdl to get the WSDL.";
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
                              if ( StringUtil.StrCmp2( GXSoapXMLReader.LocalName, "Paxitc") && ( GXSoapXMLReader.NodeType != 2 ) && ( StringUtil.StrCmp(GXSoapXMLReader.NamespaceURI, "CalcularPeajes") == 0 ) )
                              {
                                 AV11PAXITC = (long)(NumberUtil.Val( GXSoapXMLReader.Value, "."));
                                 if ( GXSoapError > 0 )
                                 {
                                    readOk = 1;
                                 }
                                 GXSoapError = GXSoapXMLReader.Read();
                              }
                              if ( StringUtil.StrCmp2( GXSoapXMLReader.LocalName, "Trb") && ( GXSoapXMLReader.NodeType != 2 ) && ( StringUtil.StrCmp(GXSoapXMLReader.NamespaceURI, "CalcularPeajes") == 0 ) )
                              {
                                 AV14TRB = (long)(NumberUtil.Val( GXSoapXMLReader.Value, "."));
                                 if ( GXSoapError > 0 )
                                 {
                                    readOk = 1;
                                 }
                                 GXSoapError = GXSoapXMLReader.Read();
                              }
                              if ( StringUtil.StrCmp2( GXSoapXMLReader.LocalName, "Cpsuab") && ( GXSoapXMLReader.NodeType != 2 ) && ( StringUtil.StrCmp(GXSoapXMLReader.NamespaceURI, "CalcularPeajes") == 0 ) )
                              {
                                 AV8CPSUAB = (long)(NumberUtil.Val( GXSoapXMLReader.Value, "."));
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
            GXSoapXMLWriter.WriteStartElement("wsCalcularPasajeros.ExecuteResponse");
            GXSoapXMLWriter.WriteAttribute("xmlns", "CalcularPeajes");
            if ( currSoapErr == 0 )
            {
               GXSoapXMLWriter.WriteElement("Resultado", StringUtil.RTrim( AV15Resultado));
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

      public awscalcularpasajeros( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public awscalcularpasajeros( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_PAXITC ,
                           long aP1_TRB ,
                           long aP2_CPSUAB ,
                           out String aP3_Resultado )
      {
         this.AV11PAXITC = aP0_PAXITC;
         this.AV14TRB = aP1_TRB;
         this.AV8CPSUAB = aP2_CPSUAB;
         this.AV15Resultado = "" ;
         initialize();
         executePrivate();
         aP3_Resultado=this.AV15Resultado;
      }

      public String executeUdp( long aP0_PAXITC ,
                                long aP1_TRB ,
                                long aP2_CPSUAB )
      {
         this.AV11PAXITC = aP0_PAXITC;
         this.AV14TRB = aP1_TRB;
         this.AV8CPSUAB = aP2_CPSUAB;
         this.AV15Resultado = "" ;
         initialize();
         executePrivate();
         aP3_Resultado=this.AV15Resultado;
         return AV15Resultado ;
      }

      public void executeSubmit( long aP0_PAXITC ,
                                 long aP1_TRB ,
                                 long aP2_CPSUAB ,
                                 out String aP3_Resultado )
      {
         awscalcularpasajeros objawscalcularpasajeros;
         objawscalcularpasajeros = new awscalcularpasajeros();
         objawscalcularpasajeros.AV11PAXITC = aP0_PAXITC;
         objawscalcularpasajeros.AV14TRB = aP1_TRB;
         objawscalcularpasajeros.AV8CPSUAB = aP2_CPSUAB;
         objawscalcularpasajeros.AV15Resultado = "" ;
         objawscalcularpasajeros.context.SetSubmitInitialConfig(context);
         objawscalcularpasajeros.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objawscalcularpasajeros);
         aP3_Resultado=this.AV15Resultado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((awscalcularpasajeros)stateInfo).executePrivate();
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
         AV9MaxTRB = 30000;
         AV12Relacion = 33;
         AV13SdtResultado.gxTpr_Sdtresultadopanamax = (decimal)(0);
         AV13SdtResultado.gxTpr_Sdtresultadoneopanamax = (decimal)(0);
         AV13SdtResultado.gxTpr_Sdtresultadolastre = (decimal)(0);
         AV13SdtResultado.gxTpr_Sdtlastreroundtrip = (decimal)(0);
         if ( ( ( AV14TRB > AV9MaxTRB ) ) && ( ( ( AV8CPSUAB /  ( decimal )( AV11PAXITC ) ) <= Convert.ToDecimal( AV12Relacion )) ) )
         {
            /* Using cursor P000P2 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               A58PASAJEROS_ESCLUSA = P000P2_A58PASAJEROS_ESCLUSA[0];
               A59PASAJEROS_CARGA = P000P2_A59PASAJEROS_CARGA[0];
               A60PASAJEROS_TIPO_TARIFA = P000P2_A60PASAJEROS_TIPO_TARIFA[0];
               A62PASAJEROS_TARIFA = P000P2_A62PASAJEROS_TARIFA[0];
               A63PASAJEROS_ID = P000P2_A63PASAJEROS_ID[0];
               AV13SdtResultado.gxTpr_Sdtresultadopanamax = (decimal)(AV11PAXITC*A62PASAJEROS_TARIFA);
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(0);
            }
            pr_default.close(0);
            /* Using cursor P000P3 */
            pr_default.execute(1);
            while ( (pr_default.getStatus(1) != 101) )
            {
               A58PASAJEROS_ESCLUSA = P000P3_A58PASAJEROS_ESCLUSA[0];
               A59PASAJEROS_CARGA = P000P3_A59PASAJEROS_CARGA[0];
               A60PASAJEROS_TIPO_TARIFA = P000P3_A60PASAJEROS_TIPO_TARIFA[0];
               A62PASAJEROS_TARIFA = P000P3_A62PASAJEROS_TARIFA[0];
               A63PASAJEROS_ID = P000P3_A63PASAJEROS_ID[0];
               AV13SdtResultado.gxTpr_Sdtresultadoneopanamax = (decimal)(AV11PAXITC*A62PASAJEROS_TARIFA);
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(1);
            }
            pr_default.close(1);
            /* Using cursor P000P4 */
            pr_default.execute(2);
            while ( (pr_default.getStatus(2) != 101) )
            {
               A58PASAJEROS_ESCLUSA = P000P4_A58PASAJEROS_ESCLUSA[0];
               A59PASAJEROS_CARGA = P000P4_A59PASAJEROS_CARGA[0];
               A60PASAJEROS_TIPO_TARIFA = P000P4_A60PASAJEROS_TIPO_TARIFA[0];
               A62PASAJEROS_TARIFA = P000P4_A62PASAJEROS_TARIFA[0];
               A63PASAJEROS_ID = P000P4_A63PASAJEROS_ID[0];
               AV13SdtResultado.gxTpr_Sdtresultadolastre = (decimal)(AV11PAXITC*A62PASAJEROS_TARIFA);
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(2);
            }
            pr_default.close(2);
            /* Using cursor P000P5 */
            pr_default.execute(3);
            while ( (pr_default.getStatus(3) != 101) )
            {
               A58PASAJEROS_ESCLUSA = P000P5_A58PASAJEROS_ESCLUSA[0];
               A59PASAJEROS_CARGA = P000P5_A59PASAJEROS_CARGA[0];
               A60PASAJEROS_TIPO_TARIFA = P000P5_A60PASAJEROS_TIPO_TARIFA[0];
               A62PASAJEROS_TARIFA = P000P5_A62PASAJEROS_TARIFA[0];
               A63PASAJEROS_ID = P000P5_A63PASAJEROS_ID[0];
               AV13SdtResultado.gxTpr_Sdtlastreroundtrip = (decimal)(AV11PAXITC*A62PASAJEROS_TARIFA);
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(3);
            }
            pr_default.close(3);
         }
         if ( ( ( AV14TRB > AV9MaxTRB ) ) && ( ( ( AV8CPSUAB /  ( decimal )( AV11PAXITC ) ) > Convert.ToDecimal( AV12Relacion )) ) || ( ( AV14TRB <= AV9MaxTRB ) ) )
         {
            AV10OperacionTonelaje = AV8CPSUAB;
            /* Using cursor P000P6 */
            pr_default.execute(4);
            while ( (pr_default.getStatus(4) != 101) )
            {
               A60PASAJEROS_TIPO_TARIFA = P000P6_A60PASAJEROS_TIPO_TARIFA[0];
               A59PASAJEROS_CARGA = P000P6_A59PASAJEROS_CARGA[0];
               A58PASAJEROS_ESCLUSA = P000P6_A58PASAJEROS_ESCLUSA[0];
               A61PASAJEROS_TON_TARIFA = P000P6_A61PASAJEROS_TON_TARIFA[0];
               n61PASAJEROS_TON_TARIFA = P000P6_n61PASAJEROS_TON_TARIFA[0];
               A62PASAJEROS_TARIFA = P000P6_A62PASAJEROS_TARIFA[0];
               A65PASAJEROS_ID_TON_TARIF = P000P6_A65PASAJEROS_ID_TON_TARIF[0];
               A63PASAJEROS_ID = P000P6_A63PASAJEROS_ID[0];
               if ( AV10OperacionTonelaje >= A61PASAJEROS_TON_TARIFA )
               {
                  if ( A61PASAJEROS_TON_TARIFA != 0 )
                  {
                     AV13SdtResultado.gxTpr_Sdtresultadopanamax = (decimal)(AV13SdtResultado.gxTpr_Sdtresultadopanamax+(A61PASAJEROS_TON_TARIFA*A62PASAJEROS_TARIFA));
                     AV10OperacionTonelaje = (long)(AV10OperacionTonelaje-A61PASAJEROS_TON_TARIFA);
                  }
                  else
                  {
                     AV13SdtResultado.gxTpr_Sdtresultadopanamax = (decimal)(AV13SdtResultado.gxTpr_Sdtresultadopanamax+(AV10OperacionTonelaje*A62PASAJEROS_TARIFA));
                     AV10OperacionTonelaje = 0;
                     /* Exit For each command. Update data (if necessary), close cursors & exit. */
                     if (true) break;
                  }
               }
               else
               {
                  AV13SdtResultado.gxTpr_Sdtresultadopanamax = (decimal)(AV13SdtResultado.gxTpr_Sdtresultadopanamax+(AV10OperacionTonelaje*A62PASAJEROS_TARIFA));
                  AV10OperacionTonelaje = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
               pr_default.readNext(4);
            }
            pr_default.close(4);
            AV10OperacionTonelaje = AV8CPSUAB;
            /* Using cursor P000P7 */
            pr_default.execute(5);
            while ( (pr_default.getStatus(5) != 101) )
            {
               A60PASAJEROS_TIPO_TARIFA = P000P7_A60PASAJEROS_TIPO_TARIFA[0];
               A59PASAJEROS_CARGA = P000P7_A59PASAJEROS_CARGA[0];
               A58PASAJEROS_ESCLUSA = P000P7_A58PASAJEROS_ESCLUSA[0];
               A61PASAJEROS_TON_TARIFA = P000P7_A61PASAJEROS_TON_TARIFA[0];
               n61PASAJEROS_TON_TARIFA = P000P7_n61PASAJEROS_TON_TARIFA[0];
               A62PASAJEROS_TARIFA = P000P7_A62PASAJEROS_TARIFA[0];
               A65PASAJEROS_ID_TON_TARIF = P000P7_A65PASAJEROS_ID_TON_TARIF[0];
               A63PASAJEROS_ID = P000P7_A63PASAJEROS_ID[0];
               if ( AV10OperacionTonelaje >= A61PASAJEROS_TON_TARIFA )
               {
                  if ( A61PASAJEROS_TON_TARIFA != 0 )
                  {
                     AV13SdtResultado.gxTpr_Sdtresultadoneopanamax = (decimal)(AV13SdtResultado.gxTpr_Sdtresultadoneopanamax+(A61PASAJEROS_TON_TARIFA*A62PASAJEROS_TARIFA));
                     AV10OperacionTonelaje = (long)(AV10OperacionTonelaje-A61PASAJEROS_TON_TARIFA);
                  }
                  else
                  {
                     AV13SdtResultado.gxTpr_Sdtresultadoneopanamax = (decimal)(AV13SdtResultado.gxTpr_Sdtresultadoneopanamax+(AV10OperacionTonelaje*A62PASAJEROS_TARIFA));
                     AV10OperacionTonelaje = 0;
                     /* Exit For each command. Update data (if necessary), close cursors & exit. */
                     if (true) break;
                  }
               }
               else
               {
                  AV13SdtResultado.gxTpr_Sdtresultadoneopanamax = (decimal)(AV13SdtResultado.gxTpr_Sdtresultadoneopanamax+(AV10OperacionTonelaje*A62PASAJEROS_TARIFA));
                  AV10OperacionTonelaje = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
               pr_default.readNext(5);
            }
            pr_default.close(5);
            AV10OperacionTonelaje = AV8CPSUAB;
            /* Using cursor P000P8 */
            pr_default.execute(6);
            while ( (pr_default.getStatus(6) != 101) )
            {
               A60PASAJEROS_TIPO_TARIFA = P000P8_A60PASAJEROS_TIPO_TARIFA[0];
               A59PASAJEROS_CARGA = P000P8_A59PASAJEROS_CARGA[0];
               A58PASAJEROS_ESCLUSA = P000P8_A58PASAJEROS_ESCLUSA[0];
               A61PASAJEROS_TON_TARIFA = P000P8_A61PASAJEROS_TON_TARIFA[0];
               n61PASAJEROS_TON_TARIFA = P000P8_n61PASAJEROS_TON_TARIFA[0];
               A62PASAJEROS_TARIFA = P000P8_A62PASAJEROS_TARIFA[0];
               A65PASAJEROS_ID_TON_TARIF = P000P8_A65PASAJEROS_ID_TON_TARIF[0];
               A63PASAJEROS_ID = P000P8_A63PASAJEROS_ID[0];
               if ( AV10OperacionTonelaje >= A61PASAJEROS_TON_TARIFA )
               {
                  if ( A61PASAJEROS_TON_TARIFA != 0 )
                  {
                     AV13SdtResultado.gxTpr_Sdtresultadolastre = (decimal)(AV13SdtResultado.gxTpr_Sdtresultadolastre+(A61PASAJEROS_TON_TARIFA*A62PASAJEROS_TARIFA));
                     AV10OperacionTonelaje = (long)(AV10OperacionTonelaje-A61PASAJEROS_TON_TARIFA);
                  }
                  else
                  {
                     AV13SdtResultado.gxTpr_Sdtresultadolastre = (decimal)(AV13SdtResultado.gxTpr_Sdtresultadolastre+(AV10OperacionTonelaje*A62PASAJEROS_TARIFA));
                     AV10OperacionTonelaje = 0;
                     /* Exit For each command. Update data (if necessary), close cursors & exit. */
                     if (true) break;
                  }
               }
               else
               {
                  AV13SdtResultado.gxTpr_Sdtresultadolastre = (decimal)(AV13SdtResultado.gxTpr_Sdtresultadolastre+(AV10OperacionTonelaje*A62PASAJEROS_TARIFA));
                  AV10OperacionTonelaje = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
               pr_default.readNext(6);
            }
            pr_default.close(6);
            AV10OperacionTonelaje = AV8CPSUAB;
            /* Using cursor P000P9 */
            pr_default.execute(7);
            while ( (pr_default.getStatus(7) != 101) )
            {
               A60PASAJEROS_TIPO_TARIFA = P000P9_A60PASAJEROS_TIPO_TARIFA[0];
               A59PASAJEROS_CARGA = P000P9_A59PASAJEROS_CARGA[0];
               A58PASAJEROS_ESCLUSA = P000P9_A58PASAJEROS_ESCLUSA[0];
               A61PASAJEROS_TON_TARIFA = P000P9_A61PASAJEROS_TON_TARIFA[0];
               n61PASAJEROS_TON_TARIFA = P000P9_n61PASAJEROS_TON_TARIFA[0];
               A62PASAJEROS_TARIFA = P000P9_A62PASAJEROS_TARIFA[0];
               A65PASAJEROS_ID_TON_TARIF = P000P9_A65PASAJEROS_ID_TON_TARIF[0];
               A63PASAJEROS_ID = P000P9_A63PASAJEROS_ID[0];
               if ( AV10OperacionTonelaje >= A61PASAJEROS_TON_TARIFA )
               {
                  if ( A61PASAJEROS_TON_TARIFA != 0 )
                  {
                     AV13SdtResultado.gxTpr_Sdtlastreroundtrip = (decimal)(AV13SdtResultado.gxTpr_Sdtlastreroundtrip+(A61PASAJEROS_TON_TARIFA*A62PASAJEROS_TARIFA));
                     AV10OperacionTonelaje = (long)(AV10OperacionTonelaje-A61PASAJEROS_TON_TARIFA);
                  }
                  else
                  {
                     AV13SdtResultado.gxTpr_Sdtlastreroundtrip = (decimal)(AV13SdtResultado.gxTpr_Sdtlastreroundtrip+(AV10OperacionTonelaje*A62PASAJEROS_TARIFA));
                     AV10OperacionTonelaje = 0;
                     /* Exit For each command. Update data (if necessary), close cursors & exit. */
                     if (true) break;
                  }
               }
               else
               {
                  AV13SdtResultado.gxTpr_Sdtlastreroundtrip = (decimal)(AV13SdtResultado.gxTpr_Sdtlastreroundtrip+(AV10OperacionTonelaje*A62PASAJEROS_TARIFA));
                  AV10OperacionTonelaje = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
               pr_default.readNext(7);
            }
            pr_default.close(7);
         }
         AV15Resultado = StringUtil.Trim( AV13SdtResultado.ToJSonString(false));
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
         AV13SdtResultado = new SdtSdtResultado(context);
         scmdbuf = "";
         P000P2_A58PASAJEROS_ESCLUSA = new String[] {""} ;
         P000P2_A59PASAJEROS_CARGA = new String[] {""} ;
         P000P2_A60PASAJEROS_TIPO_TARIFA = new String[] {""} ;
         P000P2_A62PASAJEROS_TARIFA = new decimal[1] ;
         P000P2_A63PASAJEROS_ID = new short[1] ;
         A58PASAJEROS_ESCLUSA = "";
         A59PASAJEROS_CARGA = "";
         A60PASAJEROS_TIPO_TARIFA = "";
         P000P3_A58PASAJEROS_ESCLUSA = new String[] {""} ;
         P000P3_A59PASAJEROS_CARGA = new String[] {""} ;
         P000P3_A60PASAJEROS_TIPO_TARIFA = new String[] {""} ;
         P000P3_A62PASAJEROS_TARIFA = new decimal[1] ;
         P000P3_A63PASAJEROS_ID = new short[1] ;
         P000P4_A58PASAJEROS_ESCLUSA = new String[] {""} ;
         P000P4_A59PASAJEROS_CARGA = new String[] {""} ;
         P000P4_A60PASAJEROS_TIPO_TARIFA = new String[] {""} ;
         P000P4_A62PASAJEROS_TARIFA = new decimal[1] ;
         P000P4_A63PASAJEROS_ID = new short[1] ;
         P000P5_A58PASAJEROS_ESCLUSA = new String[] {""} ;
         P000P5_A59PASAJEROS_CARGA = new String[] {""} ;
         P000P5_A60PASAJEROS_TIPO_TARIFA = new String[] {""} ;
         P000P5_A62PASAJEROS_TARIFA = new decimal[1] ;
         P000P5_A63PASAJEROS_ID = new short[1] ;
         P000P6_A60PASAJEROS_TIPO_TARIFA = new String[] {""} ;
         P000P6_A59PASAJEROS_CARGA = new String[] {""} ;
         P000P6_A58PASAJEROS_ESCLUSA = new String[] {""} ;
         P000P6_A61PASAJEROS_TON_TARIFA = new long[1] ;
         P000P6_n61PASAJEROS_TON_TARIFA = new bool[] {false} ;
         P000P6_A62PASAJEROS_TARIFA = new decimal[1] ;
         P000P6_A65PASAJEROS_ID_TON_TARIF = new short[1] ;
         P000P6_A63PASAJEROS_ID = new short[1] ;
         P000P7_A60PASAJEROS_TIPO_TARIFA = new String[] {""} ;
         P000P7_A59PASAJEROS_CARGA = new String[] {""} ;
         P000P7_A58PASAJEROS_ESCLUSA = new String[] {""} ;
         P000P7_A61PASAJEROS_TON_TARIFA = new long[1] ;
         P000P7_n61PASAJEROS_TON_TARIFA = new bool[] {false} ;
         P000P7_A62PASAJEROS_TARIFA = new decimal[1] ;
         P000P7_A65PASAJEROS_ID_TON_TARIF = new short[1] ;
         P000P7_A63PASAJEROS_ID = new short[1] ;
         P000P8_A60PASAJEROS_TIPO_TARIFA = new String[] {""} ;
         P000P8_A59PASAJEROS_CARGA = new String[] {""} ;
         P000P8_A58PASAJEROS_ESCLUSA = new String[] {""} ;
         P000P8_A61PASAJEROS_TON_TARIFA = new long[1] ;
         P000P8_n61PASAJEROS_TON_TARIFA = new bool[] {false} ;
         P000P8_A62PASAJEROS_TARIFA = new decimal[1] ;
         P000P8_A65PASAJEROS_ID_TON_TARIF = new short[1] ;
         P000P8_A63PASAJEROS_ID = new short[1] ;
         P000P9_A60PASAJEROS_TIPO_TARIFA = new String[] {""} ;
         P000P9_A59PASAJEROS_CARGA = new String[] {""} ;
         P000P9_A58PASAJEROS_ESCLUSA = new String[] {""} ;
         P000P9_A61PASAJEROS_TON_TARIFA = new long[1] ;
         P000P9_n61PASAJEROS_TON_TARIFA = new bool[] {false} ;
         P000P9_A62PASAJEROS_TARIFA = new decimal[1] ;
         P000P9_A65PASAJEROS_ID_TON_TARIF = new short[1] ;
         P000P9_A63PASAJEROS_ID = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.awscalcularpasajeros__default(),
            new Object[][] {
                new Object[] {
               P000P2_A58PASAJEROS_ESCLUSA, P000P2_A59PASAJEROS_CARGA, P000P2_A60PASAJEROS_TIPO_TARIFA, P000P2_A62PASAJEROS_TARIFA, P000P2_A63PASAJEROS_ID
               }
               , new Object[] {
               P000P3_A58PASAJEROS_ESCLUSA, P000P3_A59PASAJEROS_CARGA, P000P3_A60PASAJEROS_TIPO_TARIFA, P000P3_A62PASAJEROS_TARIFA, P000P3_A63PASAJEROS_ID
               }
               , new Object[] {
               P000P4_A58PASAJEROS_ESCLUSA, P000P4_A59PASAJEROS_CARGA, P000P4_A60PASAJEROS_TIPO_TARIFA, P000P4_A62PASAJEROS_TARIFA, P000P4_A63PASAJEROS_ID
               }
               , new Object[] {
               P000P5_A58PASAJEROS_ESCLUSA, P000P5_A59PASAJEROS_CARGA, P000P5_A60PASAJEROS_TIPO_TARIFA, P000P5_A62PASAJEROS_TARIFA, P000P5_A63PASAJEROS_ID
               }
               , new Object[] {
               P000P6_A60PASAJEROS_TIPO_TARIFA, P000P6_A59PASAJEROS_CARGA, P000P6_A58PASAJEROS_ESCLUSA, P000P6_A61PASAJEROS_TON_TARIFA, P000P6_n61PASAJEROS_TON_TARIFA, P000P6_A62PASAJEROS_TARIFA, P000P6_A65PASAJEROS_ID_TON_TARIF, P000P6_A63PASAJEROS_ID
               }
               , new Object[] {
               P000P7_A60PASAJEROS_TIPO_TARIFA, P000P7_A59PASAJEROS_CARGA, P000P7_A58PASAJEROS_ESCLUSA, P000P7_A61PASAJEROS_TON_TARIFA, P000P7_n61PASAJEROS_TON_TARIFA, P000P7_A62PASAJEROS_TARIFA, P000P7_A65PASAJEROS_ID_TON_TARIF, P000P7_A63PASAJEROS_ID
               }
               , new Object[] {
               P000P8_A60PASAJEROS_TIPO_TARIFA, P000P8_A59PASAJEROS_CARGA, P000P8_A58PASAJEROS_ESCLUSA, P000P8_A61PASAJEROS_TON_TARIFA, P000P8_n61PASAJEROS_TON_TARIFA, P000P8_A62PASAJEROS_TARIFA, P000P8_A65PASAJEROS_ID_TON_TARIF, P000P8_A63PASAJEROS_ID
               }
               , new Object[] {
               P000P9_A60PASAJEROS_TIPO_TARIFA, P000P9_A59PASAJEROS_CARGA, P000P9_A58PASAJEROS_ESCLUSA, P000P9_A61PASAJEROS_TON_TARIFA, P000P9_n61PASAJEROS_TON_TARIFA, P000P9_A62PASAJEROS_TARIFA, P000P9_A65PASAJEROS_ID_TON_TARIF, P000P9_A63PASAJEROS_ID
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
      private short AV12Relacion ;
      private short A63PASAJEROS_ID ;
      private short A65PASAJEROS_ID_TON_TARIF ;
      private long AV11PAXITC ;
      private long AV14TRB ;
      private long AV8CPSUAB ;
      private long AV9MaxTRB ;
      private long AV10OperacionTonelaje ;
      private long A61PASAJEROS_TON_TARIFA ;
      private decimal A62PASAJEROS_TARIFA ;
      private String currSoapErrmsg ;
      private String currMethod ;
      private String sTagName ;
      private String scmdbuf ;
      private bool n61PASAJEROS_TON_TARIFA ;
      private String AV15Resultado ;
      private String A58PASAJEROS_ESCLUSA ;
      private String A59PASAJEROS_CARGA ;
      private String A60PASAJEROS_TIPO_TARIFA ;
      private GXXMLReader GXSoapXMLReader ;
      private GXXMLWriter GXSoapXMLWriter ;
      private GxHttpRequest GXSoapHTTPRequest ;
      private GxHttpResponse GXSoapHTTPResponse ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000P2_A58PASAJEROS_ESCLUSA ;
      private String[] P000P2_A59PASAJEROS_CARGA ;
      private String[] P000P2_A60PASAJEROS_TIPO_TARIFA ;
      private decimal[] P000P2_A62PASAJEROS_TARIFA ;
      private short[] P000P2_A63PASAJEROS_ID ;
      private String[] P000P3_A58PASAJEROS_ESCLUSA ;
      private String[] P000P3_A59PASAJEROS_CARGA ;
      private String[] P000P3_A60PASAJEROS_TIPO_TARIFA ;
      private decimal[] P000P3_A62PASAJEROS_TARIFA ;
      private short[] P000P3_A63PASAJEROS_ID ;
      private String[] P000P4_A58PASAJEROS_ESCLUSA ;
      private String[] P000P4_A59PASAJEROS_CARGA ;
      private String[] P000P4_A60PASAJEROS_TIPO_TARIFA ;
      private decimal[] P000P4_A62PASAJEROS_TARIFA ;
      private short[] P000P4_A63PASAJEROS_ID ;
      private String[] P000P5_A58PASAJEROS_ESCLUSA ;
      private String[] P000P5_A59PASAJEROS_CARGA ;
      private String[] P000P5_A60PASAJEROS_TIPO_TARIFA ;
      private decimal[] P000P5_A62PASAJEROS_TARIFA ;
      private short[] P000P5_A63PASAJEROS_ID ;
      private String[] P000P6_A60PASAJEROS_TIPO_TARIFA ;
      private String[] P000P6_A59PASAJEROS_CARGA ;
      private String[] P000P6_A58PASAJEROS_ESCLUSA ;
      private long[] P000P6_A61PASAJEROS_TON_TARIFA ;
      private bool[] P000P6_n61PASAJEROS_TON_TARIFA ;
      private decimal[] P000P6_A62PASAJEROS_TARIFA ;
      private short[] P000P6_A65PASAJEROS_ID_TON_TARIF ;
      private short[] P000P6_A63PASAJEROS_ID ;
      private String[] P000P7_A60PASAJEROS_TIPO_TARIFA ;
      private String[] P000P7_A59PASAJEROS_CARGA ;
      private String[] P000P7_A58PASAJEROS_ESCLUSA ;
      private long[] P000P7_A61PASAJEROS_TON_TARIFA ;
      private bool[] P000P7_n61PASAJEROS_TON_TARIFA ;
      private decimal[] P000P7_A62PASAJEROS_TARIFA ;
      private short[] P000P7_A65PASAJEROS_ID_TON_TARIF ;
      private short[] P000P7_A63PASAJEROS_ID ;
      private String[] P000P8_A60PASAJEROS_TIPO_TARIFA ;
      private String[] P000P8_A59PASAJEROS_CARGA ;
      private String[] P000P8_A58PASAJEROS_ESCLUSA ;
      private long[] P000P8_A61PASAJEROS_TON_TARIFA ;
      private bool[] P000P8_n61PASAJEROS_TON_TARIFA ;
      private decimal[] P000P8_A62PASAJEROS_TARIFA ;
      private short[] P000P8_A65PASAJEROS_ID_TON_TARIF ;
      private short[] P000P8_A63PASAJEROS_ID ;
      private String[] P000P9_A60PASAJEROS_TIPO_TARIFA ;
      private String[] P000P9_A59PASAJEROS_CARGA ;
      private String[] P000P9_A58PASAJEROS_ESCLUSA ;
      private long[] P000P9_A61PASAJEROS_TON_TARIFA ;
      private bool[] P000P9_n61PASAJEROS_TON_TARIFA ;
      private decimal[] P000P9_A62PASAJEROS_TARIFA ;
      private short[] P000P9_A65PASAJEROS_ID_TON_TARIF ;
      private short[] P000P9_A63PASAJEROS_ID ;
      private String aP3_Resultado ;
      private SdtSdtResultado AV13SdtResultado ;
   }

   public class awscalcularpasajeros__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000P2 ;
          prmP000P2 = new Object[] {
          } ;
          Object[] prmP000P3 ;
          prmP000P3 = new Object[] {
          } ;
          Object[] prmP000P4 ;
          prmP000P4 = new Object[] {
          } ;
          Object[] prmP000P5 ;
          prmP000P5 = new Object[] {
          } ;
          Object[] prmP000P6 ;
          prmP000P6 = new Object[] {
          } ;
          Object[] prmP000P7 ;
          prmP000P7 = new Object[] {
          } ;
          Object[] prmP000P8 ;
          prmP000P8 = new Object[] {
          } ;
          Object[] prmP000P9 ;
          prmP000P9 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P000P2", "SELECT TOP 1 [PASAJEROS_ESCLUSA], [PASAJEROS_CARGA], [PASAJEROS_TIPO_TARIFA], [PASAJEROS_TARIFA], [PASAJEROS_ID] FROM [PASAJEROS] WITH (NOLOCK) WHERE ([PASAJEROS_TIPO_TARIFA] = 'LITERA') AND ([PASAJEROS_CARGA] = 'Laden') AND ([PASAJEROS_ESCLUSA] = 'Panamax') ORDER BY [PASAJEROS_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000P2,1,0,false,true )
             ,new CursorDef("P000P3", "SELECT TOP 1 [PASAJEROS_ESCLUSA], [PASAJEROS_CARGA], [PASAJEROS_TIPO_TARIFA], [PASAJEROS_TARIFA], [PASAJEROS_ID] FROM [PASAJEROS] WITH (NOLOCK) WHERE ([PASAJEROS_TIPO_TARIFA] = 'LITERA') AND ([PASAJEROS_CARGA] = 'Laden') AND ([PASAJEROS_ESCLUSA] = 'NeoPanamax') ORDER BY [PASAJEROS_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000P3,1,0,false,true )
             ,new CursorDef("P000P4", "SELECT TOP 1 [PASAJEROS_ESCLUSA], [PASAJEROS_CARGA], [PASAJEROS_TIPO_TARIFA], [PASAJEROS_TARIFA], [PASAJEROS_ID] FROM [PASAJEROS] WITH (NOLOCK) WHERE ([PASAJEROS_TIPO_TARIFA] = 'LITERA') AND ([PASAJEROS_CARGA] = 'Ballast') AND ([PASAJEROS_ESCLUSA] = 'Panamax') ORDER BY [PASAJEROS_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000P4,1,0,false,true )
             ,new CursorDef("P000P5", "SELECT TOP 1 [PASAJEROS_ESCLUSA], [PASAJEROS_CARGA], [PASAJEROS_TIPO_TARIFA], [PASAJEROS_TARIFA], [PASAJEROS_ID] FROM [PASAJEROS] WITH (NOLOCK) WHERE ([PASAJEROS_TIPO_TARIFA] = 'LITERA') AND ([PASAJEROS_CARGA] = 'Ballast') AND ([PASAJEROS_ESCLUSA] = 'NeoPanamax') ORDER BY [PASAJEROS_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000P5,1,0,false,true )
             ,new CursorDef("P000P6", "SELECT [PASAJEROS_TIPO_TARIFA], [PASAJEROS_CARGA], [PASAJEROS_ESCLUSA], [PASAJEROS_TON_TARIFA], [PASAJEROS_TARIFA], [PASAJEROS_ID_TON_TARIF], [PASAJEROS_ID] FROM [PASAJEROS] WITH (NOLOCK) WHERE ([PASAJEROS_TIPO_TARIFA] = 'CPSUAB') AND ([PASAJEROS_CARGA] = 'Laden') AND ([PASAJEROS_ESCLUSA] = 'Panamax') ORDER BY [PASAJEROS_ID_TON_TARIF] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000P6,100,0,false,false )
             ,new CursorDef("P000P7", "SELECT [PASAJEROS_TIPO_TARIFA], [PASAJEROS_CARGA], [PASAJEROS_ESCLUSA], [PASAJEROS_TON_TARIFA], [PASAJEROS_TARIFA], [PASAJEROS_ID_TON_TARIF], [PASAJEROS_ID] FROM [PASAJEROS] WITH (NOLOCK) WHERE ([PASAJEROS_TIPO_TARIFA] = 'CPSUAB') AND ([PASAJEROS_CARGA] = 'Laden') AND ([PASAJEROS_ESCLUSA] = 'NeoPanamax') ORDER BY [PASAJEROS_ID_TON_TARIF] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000P7,100,0,false,false )
             ,new CursorDef("P000P8", "SELECT [PASAJEROS_TIPO_TARIFA], [PASAJEROS_CARGA], [PASAJEROS_ESCLUSA], [PASAJEROS_TON_TARIFA], [PASAJEROS_TARIFA], [PASAJEROS_ID_TON_TARIF], [PASAJEROS_ID] FROM [PASAJEROS] WITH (NOLOCK) WHERE ([PASAJEROS_TIPO_TARIFA] = 'CPSUAB') AND ([PASAJEROS_CARGA] = 'Ballast') AND ([PASAJEROS_ESCLUSA] = 'Panamax') ORDER BY [PASAJEROS_ID_TON_TARIF] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000P8,100,0,false,false )
             ,new CursorDef("P000P9", "SELECT [PASAJEROS_TIPO_TARIFA], [PASAJEROS_CARGA], [PASAJEROS_ESCLUSA], [PASAJEROS_TON_TARIFA], [PASAJEROS_TARIFA], [PASAJEROS_ID_TON_TARIF], [PASAJEROS_ID] FROM [PASAJEROS] WITH (NOLOCK) WHERE ([PASAJEROS_TIPO_TARIFA] = 'CPSUAB') AND ([PASAJEROS_CARGA] = 'Ballast') AND ([PASAJEROS_ESCLUSA] = 'NeoPanamax') ORDER BY [PASAJEROS_ID_TON_TARIF] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000P9,100,0,false,false )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((short[]) buf[7])[0] = rslt.getShort(7) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((short[]) buf[7])[0] = rslt.getShort(7) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((short[]) buf[7])[0] = rslt.getShort(7) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((short[]) buf[7])[0] = rslt.getShort(7) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

}
