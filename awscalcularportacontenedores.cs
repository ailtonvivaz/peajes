/*
               File: wsCalcularPortacontenedores
        Description: ws Calcular Portacontenedores
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:14:59.23
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
   public class awscalcularportacontenedores : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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
               GXSoapXMLWriter.WriteAttribute("name", "wsCalcularPortacontenedores");
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
               GXSoapXMLWriter.WriteAttribute("name", "wsCalcularPortacontenedores.Execute");
               GXSoapXMLWriter.WriteStartElement("complexType");
               GXSoapXMLWriter.WriteStartElement("sequence");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "Capacidaddecontenedores");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:double");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "Cargateu");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:double");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("name", "wsCalcularPortacontenedores.ExecuteResponse");
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
               GXSoapXMLWriter.WriteAttribute("name", "wsCalcularPortacontenedores.ExecuteSoapIn");
               GXSoapXMLWriter.WriteElement("part", "");
               GXSoapXMLWriter.WriteAttribute("name", "parameters");
               GXSoapXMLWriter.WriteAttribute("element", "tns:wsCalcularPortacontenedores.Execute");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("message");
               GXSoapXMLWriter.WriteAttribute("name", "wsCalcularPortacontenedores.ExecuteSoapOut");
               GXSoapXMLWriter.WriteElement("part", "");
               GXSoapXMLWriter.WriteAttribute("name", "parameters");
               GXSoapXMLWriter.WriteAttribute("element", "tns:wsCalcularPortacontenedores.ExecuteResponse");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("portType");
               GXSoapXMLWriter.WriteAttribute("name", "wsCalcularPortacontenedoresSoapPort");
               GXSoapXMLWriter.WriteStartElement("operation");
               GXSoapXMLWriter.WriteAttribute("name", "Execute");
               GXSoapXMLWriter.WriteElement("input", "");
               GXSoapXMLWriter.WriteAttribute("message", "wsdlns:"+"wsCalcularPortacontenedores.ExecuteSoapIn");
               GXSoapXMLWriter.WriteElement("output", "");
               GXSoapXMLWriter.WriteAttribute("message", "wsdlns:"+"wsCalcularPortacontenedores.ExecuteSoapOut");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("binding");
               GXSoapXMLWriter.WriteAttribute("name", "wsCalcularPortacontenedoresSoapBinding");
               GXSoapXMLWriter.WriteAttribute("type", "wsdlns:"+"wsCalcularPortacontenedoresSoapPort");
               GXSoapXMLWriter.WriteElement("soap:binding", "");
               GXSoapXMLWriter.WriteAttribute("style", "document");
               GXSoapXMLWriter.WriteAttribute("transport", "http://schemas.xmlsoap.org/soap/http");
               GXSoapXMLWriter.WriteStartElement("operation");
               GXSoapXMLWriter.WriteAttribute("name", "Execute");
               GXSoapXMLWriter.WriteElement("soap:operation", "");
               GXSoapXMLWriter.WriteAttribute("soapAction", "CalcularPeajesaction/"+"AWSCALCULARPORTACONTENEDORES.Execute");
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
               GXSoapXMLWriter.WriteAttribute("name", "wsCalcularPortacontenedores");
               GXSoapXMLWriter.WriteStartElement("port");
               GXSoapXMLWriter.WriteAttribute("name", "wsCalcularPortacontenedoresSoapPort");
               GXSoapXMLWriter.WriteAttribute("binding", "wsdlns:"+"wsCalcularPortacontenedoresSoapBinding");
               GXSoapXMLWriter.WriteElement("soap:address", "");
               GXSoapXMLWriter.WriteAttribute("location", "http://"+context.GetServerName( )+((context.GetServerPort( )>0)&&(context.GetServerPort( )!=80)&&(context.GetServerPort( )!=443) ? ":"+StringUtil.LTrim( StringUtil.Str( (decimal)(context.GetServerPort( )), 6, 0)) : "")+context.GetScriptPath( )+"awscalcularportacontenedores.aspx");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.Close();
               return  ;
            }
            else
            {
               currSoapErr = (short)(-20000);
               currSoapErrmsg = "No SOAP request found. Call " + "http://" + context.GetServerName( ) + ((context.GetServerPort( )>0)&&(context.GetServerPort( )!=80)&&(context.GetServerPort( )!=443) ? ":"+StringUtil.LTrim( StringUtil.Str( (decimal)(context.GetServerPort( )), 6, 0)) : "") + context.GetScriptPath( ) + "awscalcularportacontenedores.aspx" + "?wsdl to get the WSDL.";
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
                              if ( StringUtil.StrCmp2( GXSoapXMLReader.LocalName, "Capacidaddecontenedores") && ( GXSoapXMLReader.NodeType != 2 ) && ( StringUtil.StrCmp(GXSoapXMLReader.NamespaceURI, "CalcularPeajes") == 0 ) )
                              {
                                 AV10CapacidadDeContenedores = NumberUtil.Val( GXSoapXMLReader.Value, ".");
                                 if ( GXSoapError > 0 )
                                 {
                                    readOk = 1;
                                 }
                                 GXSoapError = GXSoapXMLReader.Read();
                              }
                              if ( StringUtil.StrCmp2( GXSoapXMLReader.LocalName, "Cargateu") && ( GXSoapXMLReader.NodeType != 2 ) && ( StringUtil.StrCmp(GXSoapXMLReader.NamespaceURI, "CalcularPeajes") == 0 ) )
                              {
                                 AV11CargaTEU = NumberUtil.Val( GXSoapXMLReader.Value, ".");
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
            GXSoapXMLWriter.WriteStartElement("wsCalcularPortacontenedores.ExecuteResponse");
            GXSoapXMLWriter.WriteAttribute("xmlns", "CalcularPeajes");
            if ( currSoapErr == 0 )
            {
               GXSoapXMLWriter.WriteElement("Resultado", StringUtil.RTrim( AV18Resultado));
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

      public awscalcularportacontenedores( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public awscalcularportacontenedores( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( decimal aP0_CapacidadDeContenedores ,
                           decimal aP1_CargaTEU ,
                           out String aP2_Resultado )
      {
         this.AV10CapacidadDeContenedores = aP0_CapacidadDeContenedores;
         this.AV11CargaTEU = aP1_CargaTEU;
         this.AV18Resultado = "" ;
         initialize();
         executePrivate();
         aP2_Resultado=this.AV18Resultado;
      }

      public String executeUdp( decimal aP0_CapacidadDeContenedores ,
                                decimal aP1_CargaTEU )
      {
         this.AV10CapacidadDeContenedores = aP0_CapacidadDeContenedores;
         this.AV11CargaTEU = aP1_CargaTEU;
         this.AV18Resultado = "" ;
         initialize();
         executePrivate();
         aP2_Resultado=this.AV18Resultado;
         return AV18Resultado ;
      }

      public void executeSubmit( decimal aP0_CapacidadDeContenedores ,
                                 decimal aP1_CargaTEU ,
                                 out String aP2_Resultado )
      {
         awscalcularportacontenedores objawscalcularportacontenedores;
         objawscalcularportacontenedores = new awscalcularportacontenedores();
         objawscalcularportacontenedores.AV10CapacidadDeContenedores = aP0_CapacidadDeContenedores;
         objawscalcularportacontenedores.AV11CargaTEU = aP1_CargaTEU;
         objawscalcularportacontenedores.AV18Resultado = "" ;
         objawscalcularportacontenedores.context.SetSubmitInitialConfig(context);
         objawscalcularportacontenedores.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objawscalcularportacontenedores);
         aP2_Resultado=this.AV18Resultado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((awscalcularportacontenedores)stateInfo).executePrivate();
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
         AV9CalculoTTA = 0;
         AV8CalculoTEU = 0;
         AV17CalculoValorTotal = 0;
         AV14PortaTarifaTTA4 = 0;
         AV13PortaTarifaTEU4 = 0;
         if ( ( AV11CargaTEU < Convert.ToDecimal( 6000 )) )
         {
            /* Using cursor P000Q2 */
            pr_default.execute(0, new Object[] {AV11CargaTEU});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A26PortaRangoFinTEU = P000Q2_A26PortaRangoFinTEU[0];
               A25PortaRangoIniTEU = P000Q2_A25PortaRangoIniTEU[0];
               A22PortaContenedoresEsclusa = P000Q2_A22PortaContenedoresEsclusa[0];
               A27PortaTarifaTTA4 = P000Q2_A27PortaTarifaTTA4[0];
               A28PortaTarifaTEU4 = P000Q2_A28PortaTarifaTEU4[0];
               A24PortaRango = P000Q2_A24PortaRango[0];
               AV14PortaTarifaTTA4 = A27PortaTarifaTTA4;
               AV13PortaTarifaTEU4 = A28PortaTarifaTEU4;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(0);
            }
            pr_default.close(0);
            AV9CalculoTTA = (decimal)(AV10CapacidadDeContenedores*AV14PortaTarifaTTA4);
            AV8CalculoTEU = (decimal)(AV11CargaTEU*AV13PortaTarifaTEU4);
            AV17CalculoValorTotal = (decimal)(AV9CalculoTTA+AV8CalculoTEU);
            AV15SdtResultado.gxTpr_Sdtresultadopanamax = AV17CalculoValorTotal;
         }
         /* Using cursor P000Q3 */
         pr_default.execute(1, new Object[] {AV10CapacidadDeContenedores});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A26PortaRangoFinTEU = P000Q3_A26PortaRangoFinTEU[0];
            A25PortaRangoIniTEU = P000Q3_A25PortaRangoIniTEU[0];
            A22PortaContenedoresEsclusa = P000Q3_A22PortaContenedoresEsclusa[0];
            A27PortaTarifaTTA4 = P000Q3_A27PortaTarifaTTA4[0];
            A28PortaTarifaTEU4 = P000Q3_A28PortaTarifaTEU4[0];
            A24PortaRango = P000Q3_A24PortaRango[0];
            AV14PortaTarifaTTA4 = A27PortaTarifaTTA4;
            AV13PortaTarifaTEU4 = A28PortaTarifaTEU4;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(1);
         }
         pr_default.close(1);
         AV9CalculoTTA = (decimal)(AV10CapacidadDeContenedores*AV14PortaTarifaTTA4);
         AV8CalculoTEU = (decimal)(AV11CargaTEU*AV13PortaTarifaTEU4);
         AV17CalculoValorTotal = (decimal)(AV9CalculoTTA+AV8CalculoTEU);
         AV15SdtResultado.gxTpr_Sdtresultadoneopanamax = AV17CalculoValorTotal;
         AV9CalculoTTA = 0;
         AV8CalculoTEU = 0;
         AV17CalculoValorTotal = 0;
         AV14PortaTarifaTTA4 = 0;
         AV13PortaTarifaTEU4 = 0;
         if ( ( AV11CargaTEU < Convert.ToDecimal( 6000 )) )
         {
            /* Using cursor P000Q4 */
            pr_default.execute(2, new Object[] {AV11CargaTEU});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A26PortaRangoFinTEU = P000Q4_A26PortaRangoFinTEU[0];
               A25PortaRangoIniTEU = P000Q4_A25PortaRangoIniTEU[0];
               A22PortaContenedoresEsclusa = P000Q4_A22PortaContenedoresEsclusa[0];
               A29PortaTarifaTTA3 = P000Q4_A29PortaTarifaTTA3[0];
               A30PortaTarifaTEU3 = P000Q4_A30PortaTarifaTEU3[0];
               A24PortaRango = P000Q4_A24PortaRango[0];
               AV14PortaTarifaTTA4 = A29PortaTarifaTTA3;
               AV13PortaTarifaTEU4 = A30PortaTarifaTEU3;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(2);
            }
            pr_default.close(2);
            AV9CalculoTTA = (decimal)(AV10CapacidadDeContenedores*AV14PortaTarifaTTA4);
            AV8CalculoTEU = (decimal)(AV11CargaTEU*AV13PortaTarifaTEU4);
            AV17CalculoValorTotal = (decimal)(AV9CalculoTTA+AV8CalculoTEU);
            AV15SdtResultado.gxTpr_Sdtresultadopanamaxc3 = AV17CalculoValorTotal;
         }
         /* Using cursor P000Q5 */
         pr_default.execute(3, new Object[] {AV10CapacidadDeContenedores});
         while ( (pr_default.getStatus(3) != 101) )
         {
            A26PortaRangoFinTEU = P000Q5_A26PortaRangoFinTEU[0];
            A25PortaRangoIniTEU = P000Q5_A25PortaRangoIniTEU[0];
            A22PortaContenedoresEsclusa = P000Q5_A22PortaContenedoresEsclusa[0];
            A29PortaTarifaTTA3 = P000Q5_A29PortaTarifaTTA3[0];
            A30PortaTarifaTEU3 = P000Q5_A30PortaTarifaTEU3[0];
            A24PortaRango = P000Q5_A24PortaRango[0];
            AV14PortaTarifaTTA4 = A29PortaTarifaTTA3;
            AV13PortaTarifaTEU4 = A30PortaTarifaTEU3;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(3);
         }
         pr_default.close(3);
         AV9CalculoTTA = (decimal)(AV10CapacidadDeContenedores*AV14PortaTarifaTTA4);
         AV8CalculoTEU = (decimal)(AV11CargaTEU*AV13PortaTarifaTEU4);
         AV17CalculoValorTotal = (decimal)(AV9CalculoTTA+AV8CalculoTEU);
         AV15SdtResultado.gxTpr_Sdtresultadoneopanamaxc3 = AV17CalculoValorTotal;
         AV9CalculoTTA = 0;
         AV8CalculoTEU = 0;
         AV17CalculoValorTotal = 0;
         AV14PortaTarifaTTA4 = 0;
         AV13PortaTarifaTEU4 = 0;
         if ( ( AV11CargaTEU < Convert.ToDecimal( 6000 )) )
         {
            /* Using cursor P000Q6 */
            pr_default.execute(4, new Object[] {AV11CargaTEU});
            while ( (pr_default.getStatus(4) != 101) )
            {
               A26PortaRangoFinTEU = P000Q6_A26PortaRangoFinTEU[0];
               A25PortaRangoIniTEU = P000Q6_A25PortaRangoIniTEU[0];
               A22PortaContenedoresEsclusa = P000Q6_A22PortaContenedoresEsclusa[0];
               A31PortaTarifaTTA2 = P000Q6_A31PortaTarifaTTA2[0];
               A32PortaTarifaTEU2 = P000Q6_A32PortaTarifaTEU2[0];
               A24PortaRango = P000Q6_A24PortaRango[0];
               AV14PortaTarifaTTA4 = A31PortaTarifaTTA2;
               AV13PortaTarifaTEU4 = A32PortaTarifaTEU2;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(4);
            }
            pr_default.close(4);
            AV9CalculoTTA = (decimal)(AV10CapacidadDeContenedores*AV14PortaTarifaTTA4);
            AV8CalculoTEU = (decimal)(AV11CargaTEU*AV13PortaTarifaTEU4);
            AV17CalculoValorTotal = (decimal)(AV9CalculoTTA+AV8CalculoTEU);
            AV15SdtResultado.gxTpr_Sdtresultadopanamaxc2 = AV17CalculoValorTotal;
         }
         /* Using cursor P000Q7 */
         pr_default.execute(5, new Object[] {AV10CapacidadDeContenedores});
         while ( (pr_default.getStatus(5) != 101) )
         {
            A26PortaRangoFinTEU = P000Q7_A26PortaRangoFinTEU[0];
            A25PortaRangoIniTEU = P000Q7_A25PortaRangoIniTEU[0];
            A22PortaContenedoresEsclusa = P000Q7_A22PortaContenedoresEsclusa[0];
            A31PortaTarifaTTA2 = P000Q7_A31PortaTarifaTTA2[0];
            A32PortaTarifaTEU2 = P000Q7_A32PortaTarifaTEU2[0];
            A24PortaRango = P000Q7_A24PortaRango[0];
            AV14PortaTarifaTTA4 = A31PortaTarifaTTA2;
            AV13PortaTarifaTEU4 = A32PortaTarifaTEU2;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(5);
         }
         pr_default.close(5);
         AV9CalculoTTA = (decimal)(AV10CapacidadDeContenedores*AV14PortaTarifaTTA4);
         AV8CalculoTEU = (decimal)(AV11CargaTEU*AV13PortaTarifaTEU4);
         AV17CalculoValorTotal = (decimal)(AV9CalculoTTA+AV8CalculoTEU);
         AV15SdtResultado.gxTpr_Sdtresultadoneopanamaxc2 = AV17CalculoValorTotal;
         AV9CalculoTTA = 0;
         AV8CalculoTEU = 0;
         AV17CalculoValorTotal = 0;
         AV14PortaTarifaTTA4 = 0;
         AV13PortaTarifaTEU4 = 0;
         if ( ( AV11CargaTEU < Convert.ToDecimal( 6000 )) )
         {
            /* Using cursor P000Q8 */
            pr_default.execute(6, new Object[] {AV11CargaTEU});
            while ( (pr_default.getStatus(6) != 101) )
            {
               A26PortaRangoFinTEU = P000Q8_A26PortaRangoFinTEU[0];
               A25PortaRangoIniTEU = P000Q8_A25PortaRangoIniTEU[0];
               A22PortaContenedoresEsclusa = P000Q8_A22PortaContenedoresEsclusa[0];
               A33PortaTarifaTTA1 = P000Q8_A33PortaTarifaTTA1[0];
               A34PortaTarifaTEU1 = P000Q8_A34PortaTarifaTEU1[0];
               A24PortaRango = P000Q8_A24PortaRango[0];
               AV14PortaTarifaTTA4 = A33PortaTarifaTTA1;
               AV13PortaTarifaTEU4 = A34PortaTarifaTEU1;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(6);
            }
            pr_default.close(6);
            AV9CalculoTTA = (decimal)(AV10CapacidadDeContenedores*AV14PortaTarifaTTA4);
            AV8CalculoTEU = (decimal)(AV11CargaTEU*AV13PortaTarifaTEU4);
            AV17CalculoValorTotal = (decimal)(AV9CalculoTTA+AV8CalculoTEU);
            AV15SdtResultado.gxTpr_Sdtresultadopanamaxc1 = AV17CalculoValorTotal;
         }
         /* Using cursor P000Q9 */
         pr_default.execute(7, new Object[] {AV10CapacidadDeContenedores});
         while ( (pr_default.getStatus(7) != 101) )
         {
            A26PortaRangoFinTEU = P000Q9_A26PortaRangoFinTEU[0];
            A25PortaRangoIniTEU = P000Q9_A25PortaRangoIniTEU[0];
            A22PortaContenedoresEsclusa = P000Q9_A22PortaContenedoresEsclusa[0];
            A33PortaTarifaTTA1 = P000Q9_A33PortaTarifaTTA1[0];
            A34PortaTarifaTEU1 = P000Q9_A34PortaTarifaTEU1[0];
            A24PortaRango = P000Q9_A24PortaRango[0];
            AV14PortaTarifaTTA4 = A33PortaTarifaTTA1;
            AV13PortaTarifaTEU4 = A34PortaTarifaTEU1;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(7);
         }
         pr_default.close(7);
         AV9CalculoTTA = (decimal)(AV10CapacidadDeContenedores*AV14PortaTarifaTTA4);
         AV8CalculoTEU = (decimal)(AV11CargaTEU*AV13PortaTarifaTEU4);
         AV17CalculoValorTotal = (decimal)(AV9CalculoTTA+AV8CalculoTEU);
         AV15SdtResultado.gxTpr_Sdtresultadoneopanamaxc1 = AV17CalculoValorTotal;
         AV18Resultado = StringUtil.Trim( AV15SdtResultado.ToJSonString(false));
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
         P000Q2_A26PortaRangoFinTEU = new long[1] ;
         P000Q2_A25PortaRangoIniTEU = new long[1] ;
         P000Q2_A22PortaContenedoresEsclusa = new short[1] ;
         P000Q2_A27PortaTarifaTTA4 = new decimal[1] ;
         P000Q2_A28PortaTarifaTEU4 = new decimal[1] ;
         P000Q2_A24PortaRango = new short[1] ;
         AV15SdtResultado = new SdtSdtResultadoPortaContenedores(context);
         P000Q3_A26PortaRangoFinTEU = new long[1] ;
         P000Q3_A25PortaRangoIniTEU = new long[1] ;
         P000Q3_A22PortaContenedoresEsclusa = new short[1] ;
         P000Q3_A27PortaTarifaTTA4 = new decimal[1] ;
         P000Q3_A28PortaTarifaTEU4 = new decimal[1] ;
         P000Q3_A24PortaRango = new short[1] ;
         P000Q4_A26PortaRangoFinTEU = new long[1] ;
         P000Q4_A25PortaRangoIniTEU = new long[1] ;
         P000Q4_A22PortaContenedoresEsclusa = new short[1] ;
         P000Q4_A29PortaTarifaTTA3 = new decimal[1] ;
         P000Q4_A30PortaTarifaTEU3 = new decimal[1] ;
         P000Q4_A24PortaRango = new short[1] ;
         P000Q5_A26PortaRangoFinTEU = new long[1] ;
         P000Q5_A25PortaRangoIniTEU = new long[1] ;
         P000Q5_A22PortaContenedoresEsclusa = new short[1] ;
         P000Q5_A29PortaTarifaTTA3 = new decimal[1] ;
         P000Q5_A30PortaTarifaTEU3 = new decimal[1] ;
         P000Q5_A24PortaRango = new short[1] ;
         P000Q6_A26PortaRangoFinTEU = new long[1] ;
         P000Q6_A25PortaRangoIniTEU = new long[1] ;
         P000Q6_A22PortaContenedoresEsclusa = new short[1] ;
         P000Q6_A31PortaTarifaTTA2 = new decimal[1] ;
         P000Q6_A32PortaTarifaTEU2 = new decimal[1] ;
         P000Q6_A24PortaRango = new short[1] ;
         P000Q7_A26PortaRangoFinTEU = new long[1] ;
         P000Q7_A25PortaRangoIniTEU = new long[1] ;
         P000Q7_A22PortaContenedoresEsclusa = new short[1] ;
         P000Q7_A31PortaTarifaTTA2 = new decimal[1] ;
         P000Q7_A32PortaTarifaTEU2 = new decimal[1] ;
         P000Q7_A24PortaRango = new short[1] ;
         P000Q8_A26PortaRangoFinTEU = new long[1] ;
         P000Q8_A25PortaRangoIniTEU = new long[1] ;
         P000Q8_A22PortaContenedoresEsclusa = new short[1] ;
         P000Q8_A33PortaTarifaTTA1 = new decimal[1] ;
         P000Q8_A34PortaTarifaTEU1 = new decimal[1] ;
         P000Q8_A24PortaRango = new short[1] ;
         P000Q9_A26PortaRangoFinTEU = new long[1] ;
         P000Q9_A25PortaRangoIniTEU = new long[1] ;
         P000Q9_A22PortaContenedoresEsclusa = new short[1] ;
         P000Q9_A33PortaTarifaTTA1 = new decimal[1] ;
         P000Q9_A34PortaTarifaTEU1 = new decimal[1] ;
         P000Q9_A24PortaRango = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.awscalcularportacontenedores__default(),
            new Object[][] {
                new Object[] {
               P000Q2_A26PortaRangoFinTEU, P000Q2_A25PortaRangoIniTEU, P000Q2_A22PortaContenedoresEsclusa, P000Q2_A27PortaTarifaTTA4, P000Q2_A28PortaTarifaTEU4, P000Q2_A24PortaRango
               }
               , new Object[] {
               P000Q3_A26PortaRangoFinTEU, P000Q3_A25PortaRangoIniTEU, P000Q3_A22PortaContenedoresEsclusa, P000Q3_A27PortaTarifaTTA4, P000Q3_A28PortaTarifaTEU4, P000Q3_A24PortaRango
               }
               , new Object[] {
               P000Q4_A26PortaRangoFinTEU, P000Q4_A25PortaRangoIniTEU, P000Q4_A22PortaContenedoresEsclusa, P000Q4_A29PortaTarifaTTA3, P000Q4_A30PortaTarifaTEU3, P000Q4_A24PortaRango
               }
               , new Object[] {
               P000Q5_A26PortaRangoFinTEU, P000Q5_A25PortaRangoIniTEU, P000Q5_A22PortaContenedoresEsclusa, P000Q5_A29PortaTarifaTTA3, P000Q5_A30PortaTarifaTEU3, P000Q5_A24PortaRango
               }
               , new Object[] {
               P000Q6_A26PortaRangoFinTEU, P000Q6_A25PortaRangoIniTEU, P000Q6_A22PortaContenedoresEsclusa, P000Q6_A31PortaTarifaTTA2, P000Q6_A32PortaTarifaTEU2, P000Q6_A24PortaRango
               }
               , new Object[] {
               P000Q7_A26PortaRangoFinTEU, P000Q7_A25PortaRangoIniTEU, P000Q7_A22PortaContenedoresEsclusa, P000Q7_A31PortaTarifaTTA2, P000Q7_A32PortaTarifaTEU2, P000Q7_A24PortaRango
               }
               , new Object[] {
               P000Q8_A26PortaRangoFinTEU, P000Q8_A25PortaRangoIniTEU, P000Q8_A22PortaContenedoresEsclusa, P000Q8_A33PortaTarifaTTA1, P000Q8_A34PortaTarifaTEU1, P000Q8_A24PortaRango
               }
               , new Object[] {
               P000Q9_A26PortaRangoFinTEU, P000Q9_A25PortaRangoIniTEU, P000Q9_A22PortaContenedoresEsclusa, P000Q9_A33PortaTarifaTTA1, P000Q9_A34PortaTarifaTEU1, P000Q9_A24PortaRango
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
      private short A22PortaContenedoresEsclusa ;
      private short A24PortaRango ;
      private long A26PortaRangoFinTEU ;
      private long A25PortaRangoIniTEU ;
      private decimal AV10CapacidadDeContenedores ;
      private decimal AV11CargaTEU ;
      private decimal AV9CalculoTTA ;
      private decimal AV8CalculoTEU ;
      private decimal AV17CalculoValorTotal ;
      private decimal AV14PortaTarifaTTA4 ;
      private decimal AV13PortaTarifaTEU4 ;
      private decimal A27PortaTarifaTTA4 ;
      private decimal A28PortaTarifaTEU4 ;
      private decimal A29PortaTarifaTTA3 ;
      private decimal A30PortaTarifaTEU3 ;
      private decimal A31PortaTarifaTTA2 ;
      private decimal A32PortaTarifaTEU2 ;
      private decimal A33PortaTarifaTTA1 ;
      private decimal A34PortaTarifaTEU1 ;
      private String currSoapErrmsg ;
      private String currMethod ;
      private String sTagName ;
      private String scmdbuf ;
      private String AV18Resultado ;
      private GXXMLReader GXSoapXMLReader ;
      private GXXMLWriter GXSoapXMLWriter ;
      private GxHttpRequest GXSoapHTTPRequest ;
      private GxHttpResponse GXSoapHTTPResponse ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P000Q2_A26PortaRangoFinTEU ;
      private long[] P000Q2_A25PortaRangoIniTEU ;
      private short[] P000Q2_A22PortaContenedoresEsclusa ;
      private decimal[] P000Q2_A27PortaTarifaTTA4 ;
      private decimal[] P000Q2_A28PortaTarifaTEU4 ;
      private short[] P000Q2_A24PortaRango ;
      private long[] P000Q3_A26PortaRangoFinTEU ;
      private long[] P000Q3_A25PortaRangoIniTEU ;
      private short[] P000Q3_A22PortaContenedoresEsclusa ;
      private decimal[] P000Q3_A27PortaTarifaTTA4 ;
      private decimal[] P000Q3_A28PortaTarifaTEU4 ;
      private short[] P000Q3_A24PortaRango ;
      private long[] P000Q4_A26PortaRangoFinTEU ;
      private long[] P000Q4_A25PortaRangoIniTEU ;
      private short[] P000Q4_A22PortaContenedoresEsclusa ;
      private decimal[] P000Q4_A29PortaTarifaTTA3 ;
      private decimal[] P000Q4_A30PortaTarifaTEU3 ;
      private short[] P000Q4_A24PortaRango ;
      private long[] P000Q5_A26PortaRangoFinTEU ;
      private long[] P000Q5_A25PortaRangoIniTEU ;
      private short[] P000Q5_A22PortaContenedoresEsclusa ;
      private decimal[] P000Q5_A29PortaTarifaTTA3 ;
      private decimal[] P000Q5_A30PortaTarifaTEU3 ;
      private short[] P000Q5_A24PortaRango ;
      private long[] P000Q6_A26PortaRangoFinTEU ;
      private long[] P000Q6_A25PortaRangoIniTEU ;
      private short[] P000Q6_A22PortaContenedoresEsclusa ;
      private decimal[] P000Q6_A31PortaTarifaTTA2 ;
      private decimal[] P000Q6_A32PortaTarifaTEU2 ;
      private short[] P000Q6_A24PortaRango ;
      private long[] P000Q7_A26PortaRangoFinTEU ;
      private long[] P000Q7_A25PortaRangoIniTEU ;
      private short[] P000Q7_A22PortaContenedoresEsclusa ;
      private decimal[] P000Q7_A31PortaTarifaTTA2 ;
      private decimal[] P000Q7_A32PortaTarifaTEU2 ;
      private short[] P000Q7_A24PortaRango ;
      private long[] P000Q8_A26PortaRangoFinTEU ;
      private long[] P000Q8_A25PortaRangoIniTEU ;
      private short[] P000Q8_A22PortaContenedoresEsclusa ;
      private decimal[] P000Q8_A33PortaTarifaTTA1 ;
      private decimal[] P000Q8_A34PortaTarifaTEU1 ;
      private short[] P000Q8_A24PortaRango ;
      private long[] P000Q9_A26PortaRangoFinTEU ;
      private long[] P000Q9_A25PortaRangoIniTEU ;
      private short[] P000Q9_A22PortaContenedoresEsclusa ;
      private decimal[] P000Q9_A33PortaTarifaTTA1 ;
      private decimal[] P000Q9_A34PortaTarifaTEU1 ;
      private short[] P000Q9_A24PortaRango ;
      private String aP2_Resultado ;
      private SdtSdtResultadoPortaContenedores AV15SdtResultado ;
   }

   public class awscalcularportacontenedores__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000Q2 ;
          prmP000Q2 = new Object[] {
          new Object[] {"@AV11CargaTEU",SqlDbType.Decimal,12,2}
          } ;
          Object[] prmP000Q3 ;
          prmP000Q3 = new Object[] {
          new Object[] {"@AV10CapacidadDeContenedores",SqlDbType.Decimal,12,2}
          } ;
          Object[] prmP000Q4 ;
          prmP000Q4 = new Object[] {
          new Object[] {"@AV11CargaTEU",SqlDbType.Decimal,12,2}
          } ;
          Object[] prmP000Q5 ;
          prmP000Q5 = new Object[] {
          new Object[] {"@AV10CapacidadDeContenedores",SqlDbType.Decimal,12,2}
          } ;
          Object[] prmP000Q6 ;
          prmP000Q6 = new Object[] {
          new Object[] {"@AV11CargaTEU",SqlDbType.Decimal,12,2}
          } ;
          Object[] prmP000Q7 ;
          prmP000Q7 = new Object[] {
          new Object[] {"@AV10CapacidadDeContenedores",SqlDbType.Decimal,12,2}
          } ;
          Object[] prmP000Q8 ;
          prmP000Q8 = new Object[] {
          new Object[] {"@AV11CargaTEU",SqlDbType.Decimal,12,2}
          } ;
          Object[] prmP000Q9 ;
          prmP000Q9 = new Object[] {
          new Object[] {"@AV10CapacidadDeContenedores",SqlDbType.Decimal,12,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000Q2", "SELECT TOP 1 [PortaRangoFinTEU], [PortaRangoIniTEU], [PortaContenedoresEsclusa], [PortaTarifaTTA4], [PortaTarifaTEU4], [PortaRango] FROM [PortaContenedoresRango] WITH (NOLOCK) WHERE ([PortaContenedoresEsclusa] = 1) AND (@AV11CargaTEU >= [PortaRangoIniTEU] and @AV11CargaTEU < [PortaRangoFinTEU]) ORDER BY [PortaContenedoresEsclusa], [PortaRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000Q2,1,0,false,true )
             ,new CursorDef("P000Q3", "SELECT TOP 1 [PortaRangoFinTEU], [PortaRangoIniTEU], [PortaContenedoresEsclusa], [PortaTarifaTTA4], [PortaTarifaTEU4], [PortaRango] FROM [PortaContenedoresRango] WITH (NOLOCK) WHERE ([PortaContenedoresEsclusa] = 2) AND (@AV10CapacidadDeContenedores >= [PortaRangoIniTEU] and @AV10CapacidadDeContenedores < [PortaRangoFinTEU]) ORDER BY [PortaContenedoresEsclusa], [PortaRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000Q3,1,0,false,true )
             ,new CursorDef("P000Q4", "SELECT TOP 1 [PortaRangoFinTEU], [PortaRangoIniTEU], [PortaContenedoresEsclusa], [PortaTarifaTTA3], [PortaTarifaTEU3], [PortaRango] FROM [PortaContenedoresRango] WITH (NOLOCK) WHERE ([PortaContenedoresEsclusa] = 1) AND (@AV11CargaTEU >= [PortaRangoIniTEU] and @AV11CargaTEU < [PortaRangoFinTEU]) ORDER BY [PortaContenedoresEsclusa], [PortaRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000Q4,1,0,false,true )
             ,new CursorDef("P000Q5", "SELECT TOP 1 [PortaRangoFinTEU], [PortaRangoIniTEU], [PortaContenedoresEsclusa], [PortaTarifaTTA3], [PortaTarifaTEU3], [PortaRango] FROM [PortaContenedoresRango] WITH (NOLOCK) WHERE ([PortaContenedoresEsclusa] = 2) AND (@AV10CapacidadDeContenedores >= [PortaRangoIniTEU] and @AV10CapacidadDeContenedores < [PortaRangoFinTEU]) ORDER BY [PortaContenedoresEsclusa], [PortaRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000Q5,1,0,false,true )
             ,new CursorDef("P000Q6", "SELECT TOP 1 [PortaRangoFinTEU], [PortaRangoIniTEU], [PortaContenedoresEsclusa], [PortaTarifaTTA2], [PortaTarifaTEU2], [PortaRango] FROM [PortaContenedoresRango] WITH (NOLOCK) WHERE ([PortaContenedoresEsclusa] = 1) AND (@AV11CargaTEU >= [PortaRangoIniTEU] and @AV11CargaTEU < [PortaRangoFinTEU]) ORDER BY [PortaContenedoresEsclusa], [PortaRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000Q6,1,0,false,true )
             ,new CursorDef("P000Q7", "SELECT TOP 1 [PortaRangoFinTEU], [PortaRangoIniTEU], [PortaContenedoresEsclusa], [PortaTarifaTTA2], [PortaTarifaTEU2], [PortaRango] FROM [PortaContenedoresRango] WITH (NOLOCK) WHERE ([PortaContenedoresEsclusa] = 2) AND (@AV10CapacidadDeContenedores >= [PortaRangoIniTEU] and @AV10CapacidadDeContenedores < [PortaRangoFinTEU]) ORDER BY [PortaContenedoresEsclusa], [PortaRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000Q7,1,0,false,true )
             ,new CursorDef("P000Q8", "SELECT TOP 1 [PortaRangoFinTEU], [PortaRangoIniTEU], [PortaContenedoresEsclusa], [PortaTarifaTTA1], [PortaTarifaTEU1], [PortaRango] FROM [PortaContenedoresRango] WITH (NOLOCK) WHERE ([PortaContenedoresEsclusa] = 1) AND (@AV11CargaTEU >= [PortaRangoIniTEU] and @AV11CargaTEU < [PortaRangoFinTEU]) ORDER BY [PortaContenedoresEsclusa], [PortaRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000Q8,1,0,false,true )
             ,new CursorDef("P000Q9", "SELECT TOP 1 [PortaRangoFinTEU], [PortaRangoIniTEU], [PortaContenedoresEsclusa], [PortaTarifaTTA1], [PortaTarifaTEU1], [PortaRango] FROM [PortaContenedoresRango] WITH (NOLOCK) WHERE ([PortaContenedoresEsclusa] = 2) AND (@AV10CapacidadDeContenedores >= [PortaRangoIniTEU] and @AV10CapacidadDeContenedores < [PortaRangoFinTEU]) ORDER BY [PortaContenedoresEsclusa], [PortaRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000Q9,1,0,false,true )
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
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
             case 2 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
             case 3 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
             case 4 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
             case 5 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
             case 6 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
             case 7 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
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
                break;
             case 1 :
                stmt.SetParameter(1, (decimal)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (decimal)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (decimal)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (decimal)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (decimal)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (decimal)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (decimal)parms[0]);
                break;
       }
    }

 }

}
