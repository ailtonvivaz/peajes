/*
               File: wscalculartanqueros
        Description: wscalculartanqueros
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:14:58.12
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
   public class awscalculartanqueros : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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
               GXSoapXMLWriter.WriteAttribute("name", "wscalculartanqueros");
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
               GXSoapXMLWriter.WriteAttribute("name", "wscalculartanqueros.Execute");
               GXSoapXMLWriter.WriteStartElement("complexType");
               GXSoapXMLWriter.WriteStartElement("sequence");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "Tanquerobandacpsuab");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:long");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "Tanquerobandatm");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:long");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "Dwt");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:long");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("name", "wscalculartanqueros.ExecuteResponse");
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
               GXSoapXMLWriter.WriteAttribute("name", "wscalculartanqueros.ExecuteSoapIn");
               GXSoapXMLWriter.WriteElement("part", "");
               GXSoapXMLWriter.WriteAttribute("name", "parameters");
               GXSoapXMLWriter.WriteAttribute("element", "tns:wscalculartanqueros.Execute");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("message");
               GXSoapXMLWriter.WriteAttribute("name", "wscalculartanqueros.ExecuteSoapOut");
               GXSoapXMLWriter.WriteElement("part", "");
               GXSoapXMLWriter.WriteAttribute("name", "parameters");
               GXSoapXMLWriter.WriteAttribute("element", "tns:wscalculartanqueros.ExecuteResponse");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("portType");
               GXSoapXMLWriter.WriteAttribute("name", "wscalculartanquerosSoapPort");
               GXSoapXMLWriter.WriteStartElement("operation");
               GXSoapXMLWriter.WriteAttribute("name", "Execute");
               GXSoapXMLWriter.WriteElement("input", "");
               GXSoapXMLWriter.WriteAttribute("message", "wsdlns:"+"wscalculartanqueros.ExecuteSoapIn");
               GXSoapXMLWriter.WriteElement("output", "");
               GXSoapXMLWriter.WriteAttribute("message", "wsdlns:"+"wscalculartanqueros.ExecuteSoapOut");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("binding");
               GXSoapXMLWriter.WriteAttribute("name", "wscalculartanquerosSoapBinding");
               GXSoapXMLWriter.WriteAttribute("type", "wsdlns:"+"wscalculartanquerosSoapPort");
               GXSoapXMLWriter.WriteElement("soap:binding", "");
               GXSoapXMLWriter.WriteAttribute("style", "document");
               GXSoapXMLWriter.WriteAttribute("transport", "http://schemas.xmlsoap.org/soap/http");
               GXSoapXMLWriter.WriteStartElement("operation");
               GXSoapXMLWriter.WriteAttribute("name", "Execute");
               GXSoapXMLWriter.WriteElement("soap:operation", "");
               GXSoapXMLWriter.WriteAttribute("soapAction", "CalcularPeajesaction/"+"AWSCALCULARTANQUEROS.Execute");
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
               GXSoapXMLWriter.WriteAttribute("name", "wscalculartanqueros");
               GXSoapXMLWriter.WriteStartElement("port");
               GXSoapXMLWriter.WriteAttribute("name", "wscalculartanquerosSoapPort");
               GXSoapXMLWriter.WriteAttribute("binding", "wsdlns:"+"wscalculartanquerosSoapBinding");
               GXSoapXMLWriter.WriteElement("soap:address", "");
               GXSoapXMLWriter.WriteAttribute("location", "http://"+context.GetServerName( )+((context.GetServerPort( )>0)&&(context.GetServerPort( )!=80)&&(context.GetServerPort( )!=443) ? ":"+StringUtil.LTrim( StringUtil.Str( (decimal)(context.GetServerPort( )), 6, 0)) : "")+context.GetScriptPath( )+"awscalculartanqueros.aspx");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.Close();
               return  ;
            }
            else
            {
               currSoapErr = (short)(-20000);
               currSoapErrmsg = "No SOAP request found. Call " + "http://" + context.GetServerName( ) + ((context.GetServerPort( )>0)&&(context.GetServerPort( )!=80)&&(context.GetServerPort( )!=443) ? ":"+StringUtil.LTrim( StringUtil.Str( (decimal)(context.GetServerPort( )), 6, 0)) : "") + context.GetScriptPath( ) + "awscalculartanqueros.aspx" + "?wsdl to get the WSDL.";
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
                              if ( StringUtil.StrCmp2( GXSoapXMLReader.LocalName, "Tanquerobandacpsuab") && ( GXSoapXMLReader.NodeType != 2 ) && ( StringUtil.StrCmp(GXSoapXMLReader.NamespaceURI, "CalcularPeajes") == 0 ) )
                              {
                                 AV8TanqueroBandaCPSUAB = (long)(NumberUtil.Val( GXSoapXMLReader.Value, "."));
                                 if ( GXSoapError > 0 )
                                 {
                                    readOk = 1;
                                 }
                                 GXSoapError = GXSoapXMLReader.Read();
                              }
                              if ( StringUtil.StrCmp2( GXSoapXMLReader.LocalName, "Tanquerobandatm") && ( GXSoapXMLReader.NodeType != 2 ) && ( StringUtil.StrCmp(GXSoapXMLReader.NamespaceURI, "CalcularPeajes") == 0 ) )
                              {
                                 AV9TanqueroBandaTM = (long)(NumberUtil.Val( GXSoapXMLReader.Value, "."));
                                 if ( GXSoapError > 0 )
                                 {
                                    readOk = 1;
                                 }
                                 GXSoapError = GXSoapXMLReader.Read();
                              }
                              if ( StringUtil.StrCmp2( GXSoapXMLReader.LocalName, "Dwt") && ( GXSoapXMLReader.NodeType != 2 ) && ( StringUtil.StrCmp(GXSoapXMLReader.NamespaceURI, "CalcularPeajes") == 0 ) )
                              {
                                 AV16DWT = (long)(NumberUtil.Val( GXSoapXMLReader.Value, "."));
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
            GXSoapXMLWriter.WriteStartElement("wscalculartanqueros.ExecuteResponse");
            GXSoapXMLWriter.WriteAttribute("xmlns", "CalcularPeajes");
            if ( currSoapErr == 0 )
            {
               GXSoapXMLWriter.WriteElement("Resultado", StringUtil.RTrim( AV17Resultado));
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

      public awscalculartanqueros( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public awscalculartanqueros( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_TanqueroBandaCPSUAB ,
                           long aP1_TanqueroBandaTM ,
                           long aP2_DWT ,
                           out String aP3_Resultado )
      {
         this.AV8TanqueroBandaCPSUAB = aP0_TanqueroBandaCPSUAB;
         this.AV9TanqueroBandaTM = aP1_TanqueroBandaTM;
         this.AV16DWT = aP2_DWT;
         this.AV17Resultado = "" ;
         initialize();
         executePrivate();
         aP3_Resultado=this.AV17Resultado;
      }

      public String executeUdp( long aP0_TanqueroBandaCPSUAB ,
                                long aP1_TanqueroBandaTM ,
                                long aP2_DWT )
      {
         this.AV8TanqueroBandaCPSUAB = aP0_TanqueroBandaCPSUAB;
         this.AV9TanqueroBandaTM = aP1_TanqueroBandaTM;
         this.AV16DWT = aP2_DWT;
         this.AV17Resultado = "" ;
         initialize();
         executePrivate();
         aP3_Resultado=this.AV17Resultado;
         return AV17Resultado ;
      }

      public void executeSubmit( long aP0_TanqueroBandaCPSUAB ,
                                 long aP1_TanqueroBandaTM ,
                                 long aP2_DWT ,
                                 out String aP3_Resultado )
      {
         awscalculartanqueros objawscalculartanqueros;
         objawscalculartanqueros = new awscalculartanqueros();
         objawscalculartanqueros.AV8TanqueroBandaCPSUAB = aP0_TanqueroBandaCPSUAB;
         objawscalculartanqueros.AV9TanqueroBandaTM = aP1_TanqueroBandaTM;
         objawscalculartanqueros.AV16DWT = aP2_DWT;
         objawscalculartanqueros.AV17Resultado = "" ;
         objawscalculartanqueros.context.SetSubmitInitialConfig(context);
         objawscalculartanqueros.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objawscalculartanqueros);
         aP3_Resultado=this.AV17Resultado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((awscalculartanqueros)stateInfo).executePrivate();
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
         AV11ResultadoTanqueroBandaCPSUAB = AV8TanqueroBandaCPSUAB;
         AV13ValorACalcular = 0;
         /* Using cursor P000K2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A1TanqueroEsclusasID = P000K2_A1TanqueroEsclusasID[0];
            A8TanqueroBandaCPSUAB = P000K2_A8TanqueroBandaCPSUAB[0];
            A4TanqueroTarifaCPSUAB = P000K2_A4TanqueroTarifaCPSUAB[0];
            A3TanqueroRango = P000K2_A3TanqueroRango[0];
            if ( AV11ResultadoTanqueroBandaCPSUAB >= A8TanqueroBandaCPSUAB )
            {
               if ( A8TanqueroBandaCPSUAB != 0 )
               {
                  AV13ValorACalcular = (decimal)(AV13ValorACalcular+(A8TanqueroBandaCPSUAB*A4TanqueroTarifaCPSUAB));
                  AV11ResultadoTanqueroBandaCPSUAB = (long)(AV11ResultadoTanqueroBandaCPSUAB-A8TanqueroBandaCPSUAB);
               }
               else
               {
                  AV13ValorACalcular = (decimal)(AV13ValorACalcular+(AV11ResultadoTanqueroBandaCPSUAB*A4TanqueroTarifaCPSUAB));
                  AV11ResultadoTanqueroBandaCPSUAB = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            else
            {
               AV13ValorACalcular = (decimal)(AV13ValorACalcular+(AV11ResultadoTanqueroBandaCPSUAB*A4TanqueroTarifaCPSUAB));
               AV11ResultadoTanqueroBandaCPSUAB = 0;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV15SdtResultado.gxTpr_Sdtresultadopanamax = AV13ValorACalcular;
         AV11ResultadoTanqueroBandaCPSUAB = AV8TanqueroBandaCPSUAB;
         AV13ValorACalcular = 0;
         /* Using cursor P000K3 */
         pr_default.execute(1);
         while ( (pr_default.getStatus(1) != 101) )
         {
            A1TanqueroEsclusasID = P000K3_A1TanqueroEsclusasID[0];
            A8TanqueroBandaCPSUAB = P000K3_A8TanqueroBandaCPSUAB[0];
            A4TanqueroTarifaCPSUAB = P000K3_A4TanqueroTarifaCPSUAB[0];
            A3TanqueroRango = P000K3_A3TanqueroRango[0];
            if ( AV11ResultadoTanqueroBandaCPSUAB >= A8TanqueroBandaCPSUAB )
            {
               if ( A8TanqueroBandaCPSUAB != 0 )
               {
                  AV13ValorACalcular = (decimal)(AV13ValorACalcular+(A8TanqueroBandaCPSUAB*A4TanqueroTarifaCPSUAB));
                  AV11ResultadoTanqueroBandaCPSUAB = (long)(AV11ResultadoTanqueroBandaCPSUAB-A8TanqueroBandaCPSUAB);
               }
               else
               {
                  AV13ValorACalcular = (decimal)(AV13ValorACalcular+(AV11ResultadoTanqueroBandaCPSUAB*A4TanqueroTarifaCPSUAB));
                  AV11ResultadoTanqueroBandaCPSUAB = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            else
            {
               AV13ValorACalcular = (decimal)(AV13ValorACalcular+(AV11ResultadoTanqueroBandaCPSUAB*A4TanqueroTarifaCPSUAB));
               AV11ResultadoTanqueroBandaCPSUAB = 0;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(1);
         }
         pr_default.close(1);
         AV11ResultadoTanqueroBandaCPSUAB = AV9TanqueroBandaTM;
         /* Using cursor P000K4 */
         pr_default.execute(2);
         while ( (pr_default.getStatus(2) != 101) )
         {
            A1TanqueroEsclusasID = P000K4_A1TanqueroEsclusasID[0];
            A5TanqueroBandaTM = P000K4_A5TanqueroBandaTM[0];
            A6TanqueroTarifaTM = P000K4_A6TanqueroTarifaTM[0];
            A3TanqueroRango = P000K4_A3TanqueroRango[0];
            if ( AV11ResultadoTanqueroBandaCPSUAB >= A5TanqueroBandaTM )
            {
               if ( A5TanqueroBandaTM != 0 )
               {
                  AV13ValorACalcular = (decimal)(AV13ValorACalcular+(A5TanqueroBandaTM*A6TanqueroTarifaTM));
                  AV11ResultadoTanqueroBandaCPSUAB = (long)(AV11ResultadoTanqueroBandaCPSUAB-A5TanqueroBandaTM);
               }
               else
               {
                  AV13ValorACalcular = (decimal)(AV13ValorACalcular+(AV11ResultadoTanqueroBandaCPSUAB*A6TanqueroTarifaTM));
                  AV11ResultadoTanqueroBandaCPSUAB = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            else
            {
               AV13ValorACalcular = (decimal)(AV13ValorACalcular+(AV11ResultadoTanqueroBandaCPSUAB*A6TanqueroTarifaTM));
               AV11ResultadoTanqueroBandaCPSUAB = 0;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(2);
         }
         pr_default.close(2);
         AV15SdtResultado.gxTpr_Sdtresultadoneopanamax = AV13ValorACalcular;
         AV13ValorACalcular = 0;
         AV11ResultadoTanqueroBandaCPSUAB = AV8TanqueroBandaCPSUAB;
         /* Using cursor P000K5 */
         pr_default.execute(3);
         while ( (pr_default.getStatus(3) != 101) )
         {
            A1TanqueroEsclusasID = P000K5_A1TanqueroEsclusasID[0];
            A8TanqueroBandaCPSUAB = P000K5_A8TanqueroBandaCPSUAB[0];
            A7TanqueroTarifaLastre = P000K5_A7TanqueroTarifaLastre[0];
            A3TanqueroRango = P000K5_A3TanqueroRango[0];
            if ( AV11ResultadoTanqueroBandaCPSUAB >= A8TanqueroBandaCPSUAB )
            {
               if ( A8TanqueroBandaCPSUAB != 0 )
               {
                  AV13ValorACalcular = (decimal)(AV13ValorACalcular+(A8TanqueroBandaCPSUAB*A7TanqueroTarifaLastre));
                  AV11ResultadoTanqueroBandaCPSUAB = (long)(AV11ResultadoTanqueroBandaCPSUAB-A8TanqueroBandaCPSUAB);
               }
               else
               {
                  AV13ValorACalcular = (decimal)(AV13ValorACalcular+(AV11ResultadoTanqueroBandaCPSUAB*A7TanqueroTarifaLastre));
                  AV11ResultadoTanqueroBandaCPSUAB = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            else
            {
               AV13ValorACalcular = (decimal)(AV13ValorACalcular+(AV11ResultadoTanqueroBandaCPSUAB*A7TanqueroTarifaLastre));
               AV11ResultadoTanqueroBandaCPSUAB = 0;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(3);
         }
         pr_default.close(3);
         AV15SdtResultado.gxTpr_Sdtresultadolastre = AV13ValorACalcular;
         AV17Resultado = StringUtil.Trim( AV15SdtResultado.ToJSonString(false));
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
         P000K2_A1TanqueroEsclusasID = new short[1] ;
         P000K2_A8TanqueroBandaCPSUAB = new long[1] ;
         P000K2_A4TanqueroTarifaCPSUAB = new decimal[1] ;
         P000K2_A3TanqueroRango = new short[1] ;
         AV15SdtResultado = new SdtSdtResultado(context);
         P000K3_A1TanqueroEsclusasID = new short[1] ;
         P000K3_A8TanqueroBandaCPSUAB = new long[1] ;
         P000K3_A4TanqueroTarifaCPSUAB = new decimal[1] ;
         P000K3_A3TanqueroRango = new short[1] ;
         P000K4_A1TanqueroEsclusasID = new short[1] ;
         P000K4_A5TanqueroBandaTM = new long[1] ;
         P000K4_A6TanqueroTarifaTM = new decimal[1] ;
         P000K4_A3TanqueroRango = new short[1] ;
         P000K5_A1TanqueroEsclusasID = new short[1] ;
         P000K5_A8TanqueroBandaCPSUAB = new long[1] ;
         P000K5_A7TanqueroTarifaLastre = new decimal[1] ;
         P000K5_A3TanqueroRango = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.awscalculartanqueros__default(),
            new Object[][] {
                new Object[] {
               P000K2_A1TanqueroEsclusasID, P000K2_A8TanqueroBandaCPSUAB, P000K2_A4TanqueroTarifaCPSUAB, P000K2_A3TanqueroRango
               }
               , new Object[] {
               P000K3_A1TanqueroEsclusasID, P000K3_A8TanqueroBandaCPSUAB, P000K3_A4TanqueroTarifaCPSUAB, P000K3_A3TanqueroRango
               }
               , new Object[] {
               P000K4_A1TanqueroEsclusasID, P000K4_A5TanqueroBandaTM, P000K4_A6TanqueroTarifaTM, P000K4_A3TanqueroRango
               }
               , new Object[] {
               P000K5_A1TanqueroEsclusasID, P000K5_A8TanqueroBandaCPSUAB, P000K5_A7TanqueroTarifaLastre, P000K5_A3TanqueroRango
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
      private short A1TanqueroEsclusasID ;
      private short A3TanqueroRango ;
      private long AV8TanqueroBandaCPSUAB ;
      private long AV9TanqueroBandaTM ;
      private long AV16DWT ;
      private long AV11ResultadoTanqueroBandaCPSUAB ;
      private long A8TanqueroBandaCPSUAB ;
      private long A5TanqueroBandaTM ;
      private decimal AV13ValorACalcular ;
      private decimal A4TanqueroTarifaCPSUAB ;
      private decimal A6TanqueroTarifaTM ;
      private decimal A7TanqueroTarifaLastre ;
      private String currSoapErrmsg ;
      private String currMethod ;
      private String sTagName ;
      private String scmdbuf ;
      private String AV17Resultado ;
      private GXXMLReader GXSoapXMLReader ;
      private GXXMLWriter GXSoapXMLWriter ;
      private GxHttpRequest GXSoapHTTPRequest ;
      private GxHttpResponse GXSoapHTTPResponse ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000K2_A1TanqueroEsclusasID ;
      private long[] P000K2_A8TanqueroBandaCPSUAB ;
      private decimal[] P000K2_A4TanqueroTarifaCPSUAB ;
      private short[] P000K2_A3TanqueroRango ;
      private short[] P000K3_A1TanqueroEsclusasID ;
      private long[] P000K3_A8TanqueroBandaCPSUAB ;
      private decimal[] P000K3_A4TanqueroTarifaCPSUAB ;
      private short[] P000K3_A3TanqueroRango ;
      private short[] P000K4_A1TanqueroEsclusasID ;
      private long[] P000K4_A5TanqueroBandaTM ;
      private decimal[] P000K4_A6TanqueroTarifaTM ;
      private short[] P000K4_A3TanqueroRango ;
      private short[] P000K5_A1TanqueroEsclusasID ;
      private long[] P000K5_A8TanqueroBandaCPSUAB ;
      private decimal[] P000K5_A7TanqueroTarifaLastre ;
      private short[] P000K5_A3TanqueroRango ;
      private String aP3_Resultado ;
      private SdtSdtResultado AV15SdtResultado ;
   }

   public class awscalculartanqueros__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000K2 ;
          prmP000K2 = new Object[] {
          } ;
          Object[] prmP000K3 ;
          prmP000K3 = new Object[] {
          } ;
          Object[] prmP000K4 ;
          prmP000K4 = new Object[] {
          } ;
          Object[] prmP000K5 ;
          prmP000K5 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P000K2", "SELECT [TanqueroEsclusasID], [TanqueroBandaCPSUAB], [TanqueroTarifaCPSUAB], [TanqueroRango] FROM [TanqueroEsclusasRango] WITH (NOLOCK) WHERE [TanqueroEsclusasID] = 1 ORDER BY [TanqueroEsclusasID], [TanqueroRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000K2,100,0,false,false )
             ,new CursorDef("P000K3", "SELECT [TanqueroEsclusasID], [TanqueroBandaCPSUAB], [TanqueroTarifaCPSUAB], [TanqueroRango] FROM [TanqueroEsclusasRango] WITH (NOLOCK) WHERE [TanqueroEsclusasID] = 2 ORDER BY [TanqueroEsclusasID], [TanqueroRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000K3,100,0,false,false )
             ,new CursorDef("P000K4", "SELECT [TanqueroEsclusasID], [TanqueroBandaTM], [TanqueroTarifaTM], [TanqueroRango] FROM [TanqueroEsclusasRango] WITH (NOLOCK) WHERE [TanqueroEsclusasID] = 2 ORDER BY [TanqueroEsclusasID], [TanqueroRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000K4,100,0,false,false )
             ,new CursorDef("P000K5", "SELECT [TanqueroEsclusasID], [TanqueroBandaCPSUAB], [TanqueroTarifaLastre], [TanqueroRango] FROM [TanqueroEsclusasRango] WITH (NOLOCK) WHERE [TanqueroEsclusasID] = 1 ORDER BY [TanqueroEsclusasID], [TanqueroRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000K5,100,0,false,false )
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
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
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
