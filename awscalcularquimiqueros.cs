/*
               File: wscalcularquimiqueros
        Description: wscalcularquimiqueros
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:14:58.31
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
   public class awscalcularquimiqueros : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularquimiqueros");
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
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularquimiqueros.Execute");
               GXSoapXMLWriter.WriteStartElement("complexType");
               GXSoapXMLWriter.WriteStartElement("sequence");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "Quimiquerosbandacpsuab");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:long");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "Dominioimo");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:string");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularquimiqueros.ExecuteResponse");
               GXSoapXMLWriter.WriteStartElement("complexType");
               GXSoapXMLWriter.WriteStartElement("sequence");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "Dominioimo");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:string");
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
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularquimiqueros.ExecuteSoapIn");
               GXSoapXMLWriter.WriteElement("part", "");
               GXSoapXMLWriter.WriteAttribute("name", "parameters");
               GXSoapXMLWriter.WriteAttribute("element", "tns:wscalcularquimiqueros.Execute");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("message");
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularquimiqueros.ExecuteSoapOut");
               GXSoapXMLWriter.WriteElement("part", "");
               GXSoapXMLWriter.WriteAttribute("name", "parameters");
               GXSoapXMLWriter.WriteAttribute("element", "tns:wscalcularquimiqueros.ExecuteResponse");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("portType");
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularquimiquerosSoapPort");
               GXSoapXMLWriter.WriteStartElement("operation");
               GXSoapXMLWriter.WriteAttribute("name", "Execute");
               GXSoapXMLWriter.WriteElement("input", "");
               GXSoapXMLWriter.WriteAttribute("message", "wsdlns:"+"wscalcularquimiqueros.ExecuteSoapIn");
               GXSoapXMLWriter.WriteElement("output", "");
               GXSoapXMLWriter.WriteAttribute("message", "wsdlns:"+"wscalcularquimiqueros.ExecuteSoapOut");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("binding");
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularquimiquerosSoapBinding");
               GXSoapXMLWriter.WriteAttribute("type", "wsdlns:"+"wscalcularquimiquerosSoapPort");
               GXSoapXMLWriter.WriteElement("soap:binding", "");
               GXSoapXMLWriter.WriteAttribute("style", "document");
               GXSoapXMLWriter.WriteAttribute("transport", "http://schemas.xmlsoap.org/soap/http");
               GXSoapXMLWriter.WriteStartElement("operation");
               GXSoapXMLWriter.WriteAttribute("name", "Execute");
               GXSoapXMLWriter.WriteElement("soap:operation", "");
               GXSoapXMLWriter.WriteAttribute("soapAction", "CalcularPeajesaction/"+"AWSCALCULARQUIMIQUEROS.Execute");
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
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularquimiqueros");
               GXSoapXMLWriter.WriteStartElement("port");
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularquimiquerosSoapPort");
               GXSoapXMLWriter.WriteAttribute("binding", "wsdlns:"+"wscalcularquimiquerosSoapBinding");
               GXSoapXMLWriter.WriteElement("soap:address", "");
               GXSoapXMLWriter.WriteAttribute("location", "http://"+context.GetServerName( )+((context.GetServerPort( )>0)&&(context.GetServerPort( )!=80)&&(context.GetServerPort( )!=443) ? ":"+StringUtil.LTrim( StringUtil.Str( (decimal)(context.GetServerPort( )), 6, 0)) : "")+context.GetScriptPath( )+"awscalcularquimiqueros.aspx");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.Close();
               return  ;
            }
            else
            {
               currSoapErr = (short)(-20000);
               currSoapErrmsg = "No SOAP request found. Call " + "http://" + context.GetServerName( ) + ((context.GetServerPort( )>0)&&(context.GetServerPort( )!=80)&&(context.GetServerPort( )!=443) ? ":"+StringUtil.LTrim( StringUtil.Str( (decimal)(context.GetServerPort( )), 6, 0)) : "") + context.GetScriptPath( ) + "awscalcularquimiqueros.aspx" + "?wsdl to get the WSDL.";
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
                              if ( StringUtil.StrCmp2( GXSoapXMLReader.LocalName, "Quimiquerosbandacpsuab") && ( GXSoapXMLReader.NodeType != 2 ) && ( StringUtil.StrCmp(GXSoapXMLReader.NamespaceURI, "CalcularPeajes") == 0 ) )
                              {
                                 AV9QuimiquerosBandaCPSUAB = (long)(NumberUtil.Val( GXSoapXMLReader.Value, "."));
                                 if ( GXSoapError > 0 )
                                 {
                                    readOk = 1;
                                 }
                                 GXSoapError = GXSoapXMLReader.Read();
                              }
                              if ( StringUtil.StrCmp2( GXSoapXMLReader.LocalName, "Dominioimo") && ( GXSoapXMLReader.NodeType != 2 ) && ( StringUtil.StrCmp(GXSoapXMLReader.NamespaceURI, "CalcularPeajes") == 0 ) )
                              {
                                 AV16DominioIMO = GXSoapXMLReader.Value;
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
            GXSoapXMLWriter.WriteStartElement("wscalcularquimiqueros.ExecuteResponse");
            GXSoapXMLWriter.WriteAttribute("xmlns", "CalcularPeajes");
            if ( currSoapErr == 0 )
            {
               GXSoapXMLWriter.WriteElement("Dominioimo", StringUtil.RTrim( AV16DominioIMO));
               GXSoapXMLWriter.WriteAttribute("xmlns", "CalcularPeajes");
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

      public awscalcularquimiqueros( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public awscalcularquimiqueros( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_QuimiquerosBandaCPSUAB ,
                           ref String aP1_DominioIMO ,
                           out String aP2_Resultado )
      {
         this.AV9QuimiquerosBandaCPSUAB = aP0_QuimiquerosBandaCPSUAB;
         this.AV16DominioIMO = aP1_DominioIMO;
         this.AV17Resultado = "" ;
         initialize();
         executePrivate();
         aP1_DominioIMO=this.AV16DominioIMO;
         aP2_Resultado=this.AV17Resultado;
      }

      public String executeUdp( long aP0_QuimiquerosBandaCPSUAB ,
                                ref String aP1_DominioIMO )
      {
         this.AV9QuimiquerosBandaCPSUAB = aP0_QuimiquerosBandaCPSUAB;
         this.AV16DominioIMO = aP1_DominioIMO;
         this.AV17Resultado = "" ;
         initialize();
         executePrivate();
         aP1_DominioIMO=this.AV16DominioIMO;
         aP2_Resultado=this.AV17Resultado;
         return AV17Resultado ;
      }

      public void executeSubmit( long aP0_QuimiquerosBandaCPSUAB ,
                                 ref String aP1_DominioIMO ,
                                 out String aP2_Resultado )
      {
         awscalcularquimiqueros objawscalcularquimiqueros;
         objawscalcularquimiqueros = new awscalcularquimiqueros();
         objawscalcularquimiqueros.AV9QuimiquerosBandaCPSUAB = aP0_QuimiquerosBandaCPSUAB;
         objawscalcularquimiqueros.AV16DominioIMO = aP1_DominioIMO;
         objawscalcularquimiqueros.AV17Resultado = "" ;
         objawscalcularquimiqueros.context.SetSubmitInitialConfig(context);
         objawscalcularquimiqueros.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objawscalcularquimiqueros);
         aP1_DominioIMO=this.AV16DominioIMO;
         aP2_Resultado=this.AV17Resultado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((awscalcularquimiqueros)stateInfo).executePrivate();
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
         AV10ResultadoQuimiquerosBandaCPSUAB = AV9QuimiquerosBandaCPSUAB;
         AV15ValorACalcular = 0;
         /* Using cursor P000L2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A10QuimiquerosBandaCPSUAB = P000L2_A10QuimiquerosBandaCPSUAB[0];
            A11QuimiquerosTarifaCargados = P000L2_A11QuimiquerosTarifaCargados[0];
            A9QuimiquerosID = P000L2_A9QuimiquerosID[0];
            if ( AV10ResultadoQuimiquerosBandaCPSUAB >= A10QuimiquerosBandaCPSUAB )
            {
               if ( A10QuimiquerosBandaCPSUAB != 0 )
               {
                  AV15ValorACalcular = (decimal)(AV15ValorACalcular+(A10QuimiquerosBandaCPSUAB*A11QuimiquerosTarifaCargados));
                  AV10ResultadoQuimiquerosBandaCPSUAB = (long)(AV10ResultadoQuimiquerosBandaCPSUAB-A10QuimiquerosBandaCPSUAB);
               }
               else
               {
                  AV15ValorACalcular = (decimal)(AV15ValorACalcular+(AV10ResultadoQuimiquerosBandaCPSUAB*A11QuimiquerosTarifaCargados));
                  AV10ResultadoQuimiquerosBandaCPSUAB = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            else
            {
               AV15ValorACalcular = (decimal)(AV15ValorACalcular+(AV10ResultadoQuimiquerosBandaCPSUAB*A11QuimiquerosTarifaCargados));
               AV10ResultadoQuimiquerosBandaCPSUAB = 0;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV13SdtResultado.gxTpr_Sdtresultadopanamax = AV15ValorACalcular;
         AV13SdtResultado.gxTpr_Sdtresultadoneopanamax = AV15ValorACalcular;
         AV10ResultadoQuimiquerosBandaCPSUAB = AV9QuimiquerosBandaCPSUAB;
         AV15ValorACalcular = 0;
         AV10ResultadoQuimiquerosBandaCPSUAB = AV9QuimiquerosBandaCPSUAB;
         /* Using cursor P000L3 */
         pr_default.execute(1);
         while ( (pr_default.getStatus(1) != 101) )
         {
            A10QuimiquerosBandaCPSUAB = P000L3_A10QuimiquerosBandaCPSUAB[0];
            A12QuimiquerosTarifaLastre = P000L3_A12QuimiquerosTarifaLastre[0];
            A9QuimiquerosID = P000L3_A9QuimiquerosID[0];
            if ( AV10ResultadoQuimiquerosBandaCPSUAB >= A10QuimiquerosBandaCPSUAB )
            {
               if ( A10QuimiquerosBandaCPSUAB != 0 )
               {
                  AV15ValorACalcular = (decimal)(AV15ValorACalcular+(A10QuimiquerosBandaCPSUAB*A12QuimiquerosTarifaLastre));
                  AV10ResultadoQuimiquerosBandaCPSUAB = (long)(AV10ResultadoQuimiquerosBandaCPSUAB-A10QuimiquerosBandaCPSUAB);
               }
               else
               {
                  AV15ValorACalcular = (decimal)(AV15ValorACalcular+(AV10ResultadoQuimiquerosBandaCPSUAB*A12QuimiquerosTarifaLastre));
                  AV10ResultadoQuimiquerosBandaCPSUAB = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            else
            {
               AV15ValorACalcular = (decimal)(AV15ValorACalcular+(AV10ResultadoQuimiquerosBandaCPSUAB*A12QuimiquerosTarifaLastre));
               AV10ResultadoQuimiquerosBandaCPSUAB = 0;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(1);
         }
         pr_default.close(1);
         AV13SdtResultado.gxTpr_Sdtresultadolastre = AV15ValorACalcular;
         AV17Resultado = StringUtil.Trim( AV13SdtResultado.ToJSonString(false));
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
         P000L2_A10QuimiquerosBandaCPSUAB = new long[1] ;
         P000L2_A11QuimiquerosTarifaCargados = new decimal[1] ;
         P000L2_A9QuimiquerosID = new short[1] ;
         AV13SdtResultado = new SdtSdtResultado(context);
         P000L3_A10QuimiquerosBandaCPSUAB = new long[1] ;
         P000L3_A12QuimiquerosTarifaLastre = new decimal[1] ;
         P000L3_A9QuimiquerosID = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.awscalcularquimiqueros__default(),
            new Object[][] {
                new Object[] {
               P000L2_A10QuimiquerosBandaCPSUAB, P000L2_A11QuimiquerosTarifaCargados, P000L2_A9QuimiquerosID
               }
               , new Object[] {
               P000L3_A10QuimiquerosBandaCPSUAB, P000L3_A12QuimiquerosTarifaLastre, P000L3_A9QuimiquerosID
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
      private short A9QuimiquerosID ;
      private long AV9QuimiquerosBandaCPSUAB ;
      private long AV10ResultadoQuimiquerosBandaCPSUAB ;
      private long A10QuimiquerosBandaCPSUAB ;
      private decimal AV15ValorACalcular ;
      private decimal A11QuimiquerosTarifaCargados ;
      private decimal A12QuimiquerosTarifaLastre ;
      private String currSoapErrmsg ;
      private String currMethod ;
      private String sTagName ;
      private String scmdbuf ;
      private String AV17Resultado ;
      private String AV16DominioIMO ;
      private GXXMLReader GXSoapXMLReader ;
      private GXXMLWriter GXSoapXMLWriter ;
      private GxHttpRequest GXSoapHTTPRequest ;
      private GxHttpResponse GXSoapHTTPResponse ;
      private IGxDataStore dsDefault ;
      private String aP1_DominioIMO ;
      private IDataStoreProvider pr_default ;
      private long[] P000L2_A10QuimiquerosBandaCPSUAB ;
      private decimal[] P000L2_A11QuimiquerosTarifaCargados ;
      private short[] P000L2_A9QuimiquerosID ;
      private long[] P000L3_A10QuimiquerosBandaCPSUAB ;
      private decimal[] P000L3_A12QuimiquerosTarifaLastre ;
      private short[] P000L3_A9QuimiquerosID ;
      private String aP2_Resultado ;
      private SdtSdtResultado AV13SdtResultado ;
   }

   public class awscalcularquimiqueros__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000L2 ;
          prmP000L2 = new Object[] {
          } ;
          Object[] prmP000L3 ;
          prmP000L3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P000L2", "SELECT [QuimiquerosBandaCPSUAB], [QuimiquerosTarifaCargados], [QuimiquerosID] FROM [Quimiqueros] WITH (NOLOCK) ORDER BY [QuimiquerosID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000L2,100,0,false,false )
             ,new CursorDef("P000L3", "SELECT [QuimiquerosBandaCPSUAB], [QuimiquerosTarifaLastre], [QuimiquerosID] FROM [Quimiqueros] WITH (NOLOCK) ORDER BY [QuimiquerosID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000L3,100,0,false,false )
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
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
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
