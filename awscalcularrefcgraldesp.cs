/*
               File: wscalcularrefcgraldesp
        Description: wscalcularrefcgraldesp
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:14:58.71
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
   public class awscalcularrefcgraldesp : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularrefcgraldesp");
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
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularrefcgraldesp.Execute");
               GXSoapXMLWriter.WriteStartElement("complexType");
               GXSoapXMLWriter.WriteStartElement("sequence");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "Tonelaje");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:long");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "Cubierta");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:long");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "Ref_cgral_desp_carga");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:string");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularrefcgraldesp.ExecuteResponse");
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
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularrefcgraldesp.ExecuteSoapIn");
               GXSoapXMLWriter.WriteElement("part", "");
               GXSoapXMLWriter.WriteAttribute("name", "parameters");
               GXSoapXMLWriter.WriteAttribute("element", "tns:wscalcularrefcgraldesp.Execute");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("message");
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularrefcgraldesp.ExecuteSoapOut");
               GXSoapXMLWriter.WriteElement("part", "");
               GXSoapXMLWriter.WriteAttribute("name", "parameters");
               GXSoapXMLWriter.WriteAttribute("element", "tns:wscalcularrefcgraldesp.ExecuteResponse");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("portType");
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularrefcgraldespSoapPort");
               GXSoapXMLWriter.WriteStartElement("operation");
               GXSoapXMLWriter.WriteAttribute("name", "Execute");
               GXSoapXMLWriter.WriteElement("input", "");
               GXSoapXMLWriter.WriteAttribute("message", "wsdlns:"+"wscalcularrefcgraldesp.ExecuteSoapIn");
               GXSoapXMLWriter.WriteElement("output", "");
               GXSoapXMLWriter.WriteAttribute("message", "wsdlns:"+"wscalcularrefcgraldesp.ExecuteSoapOut");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("binding");
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularrefcgraldespSoapBinding");
               GXSoapXMLWriter.WriteAttribute("type", "wsdlns:"+"wscalcularrefcgraldespSoapPort");
               GXSoapXMLWriter.WriteElement("soap:binding", "");
               GXSoapXMLWriter.WriteAttribute("style", "document");
               GXSoapXMLWriter.WriteAttribute("transport", "http://schemas.xmlsoap.org/soap/http");
               GXSoapXMLWriter.WriteStartElement("operation");
               GXSoapXMLWriter.WriteAttribute("name", "Execute");
               GXSoapXMLWriter.WriteElement("soap:operation", "");
               GXSoapXMLWriter.WriteAttribute("soapAction", "CalcularPeajesaction/"+"AWSCALCULARREFCGRALDESP.Execute");
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
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularrefcgraldesp");
               GXSoapXMLWriter.WriteStartElement("port");
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularrefcgraldespSoapPort");
               GXSoapXMLWriter.WriteAttribute("binding", "wsdlns:"+"wscalcularrefcgraldespSoapBinding");
               GXSoapXMLWriter.WriteElement("soap:address", "");
               GXSoapXMLWriter.WriteAttribute("location", "http://"+context.GetServerName( )+((context.GetServerPort( )>0)&&(context.GetServerPort( )!=80)&&(context.GetServerPort( )!=443) ? ":"+StringUtil.LTrim( StringUtil.Str( (decimal)(context.GetServerPort( )), 6, 0)) : "")+context.GetScriptPath( )+"awscalcularrefcgraldesp.aspx");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.Close();
               return  ;
            }
            else
            {
               currSoapErr = (short)(-20000);
               currSoapErrmsg = "No SOAP request found. Call " + "http://" + context.GetServerName( ) + ((context.GetServerPort( )>0)&&(context.GetServerPort( )!=80)&&(context.GetServerPort( )!=443) ? ":"+StringUtil.LTrim( StringUtil.Str( (decimal)(context.GetServerPort( )), 6, 0)) : "") + context.GetScriptPath( ) + "awscalcularrefcgraldesp.aspx" + "?wsdl to get the WSDL.";
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
                              if ( StringUtil.StrCmp2( GXSoapXMLReader.LocalName, "Tonelaje") && ( GXSoapXMLReader.NodeType != 2 ) && ( StringUtil.StrCmp(GXSoapXMLReader.NamespaceURI, "CalcularPeajes") == 0 ) )
                              {
                                 AV13Tonelaje = (long)(NumberUtil.Val( GXSoapXMLReader.Value, "."));
                                 if ( GXSoapError > 0 )
                                 {
                                    readOk = 1;
                                 }
                                 GXSoapError = GXSoapXMLReader.Read();
                              }
                              if ( StringUtil.StrCmp2( GXSoapXMLReader.LocalName, "Cubierta") && ( GXSoapXMLReader.NodeType != 2 ) && ( StringUtil.StrCmp(GXSoapXMLReader.NamespaceURI, "CalcularPeajes") == 0 ) )
                              {
                                 AV8Cubierta = (long)(NumberUtil.Val( GXSoapXMLReader.Value, "."));
                                 if ( GXSoapError > 0 )
                                 {
                                    readOk = 1;
                                 }
                                 GXSoapError = GXSoapXMLReader.Read();
                              }
                              if ( StringUtil.StrCmp2( GXSoapXMLReader.LocalName, "Ref_cgral_desp_carga") && ( GXSoapXMLReader.NodeType != 2 ) && ( StringUtil.StrCmp(GXSoapXMLReader.NamespaceURI, "CalcularPeajes") == 0 ) )
                              {
                                 AV10REF_CGRAL_DESP_CARGA = GXSoapXMLReader.Value;
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
            GXSoapXMLWriter.WriteStartElement("wscalcularrefcgraldesp.ExecuteResponse");
            GXSoapXMLWriter.WriteAttribute("xmlns", "CalcularPeajes");
            if ( currSoapErr == 0 )
            {
               GXSoapXMLWriter.WriteElement("Resultado", StringUtil.RTrim( AV14Resultado));
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

      public awscalcularrefcgraldesp( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public awscalcularrefcgraldesp( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_Tonelaje ,
                           long aP1_Cubierta ,
                           String aP2_REF_CGRAL_DESP_CARGA ,
                           out String aP3_Resultado )
      {
         this.AV13Tonelaje = aP0_Tonelaje;
         this.AV8Cubierta = aP1_Cubierta;
         this.AV10REF_CGRAL_DESP_CARGA = aP2_REF_CGRAL_DESP_CARGA;
         this.AV14Resultado = "" ;
         initialize();
         executePrivate();
         aP3_Resultado=this.AV14Resultado;
      }

      public String executeUdp( long aP0_Tonelaje ,
                                long aP1_Cubierta ,
                                String aP2_REF_CGRAL_DESP_CARGA )
      {
         this.AV13Tonelaje = aP0_Tonelaje;
         this.AV8Cubierta = aP1_Cubierta;
         this.AV10REF_CGRAL_DESP_CARGA = aP2_REF_CGRAL_DESP_CARGA;
         this.AV14Resultado = "" ;
         initialize();
         executePrivate();
         aP3_Resultado=this.AV14Resultado;
         return AV14Resultado ;
      }

      public void executeSubmit( long aP0_Tonelaje ,
                                 long aP1_Cubierta ,
                                 String aP2_REF_CGRAL_DESP_CARGA ,
                                 out String aP3_Resultado )
      {
         awscalcularrefcgraldesp objawscalcularrefcgraldesp;
         objawscalcularrefcgraldesp = new awscalcularrefcgraldesp();
         objawscalcularrefcgraldesp.AV13Tonelaje = aP0_Tonelaje;
         objawscalcularrefcgraldesp.AV8Cubierta = aP1_Cubierta;
         objawscalcularrefcgraldesp.AV10REF_CGRAL_DESP_CARGA = aP2_REF_CGRAL_DESP_CARGA;
         objawscalcularrefcgraldesp.AV14Resultado = "" ;
         objawscalcularrefcgraldesp.context.SetSubmitInitialConfig(context);
         objawscalcularrefcgraldesp.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objawscalcularrefcgraldesp);
         aP3_Resultado=this.AV14Resultado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((awscalcularrefcgraldesp)stateInfo).executePrivate();
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
         AV9OperacionTonelaje = AV13Tonelaje;
         /* Using cursor P000O2 */
         pr_default.execute(0, new Object[] {AV10REF_CGRAL_DESP_CARGA});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A44REF_CGRAL_DESP_CARGA = P000O2_A44REF_CGRAL_DESP_CARGA[0];
            A45REF_CGRAL_DESP_TIPO = P000O2_A45REF_CGRAL_DESP_TIPO[0];
            n45REF_CGRAL_DESP_TIPO = P000O2_n45REF_CGRAL_DESP_TIPO[0];
            A46REF_CGRAL_DESP_TON_TARIF = P000O2_A46REF_CGRAL_DESP_TON_TARIF[0];
            n46REF_CGRAL_DESP_TON_TARIF = P000O2_n46REF_CGRAL_DESP_TON_TARIF[0];
            A47REF_CGRAL_DESP_TARIFA = P000O2_A47REF_CGRAL_DESP_TARIFA[0];
            A48REF_CGRAL_DESP_ID_TON_TARIF = P000O2_A48REF_CGRAL_DESP_ID_TON_TARIF[0];
            A49REF_CGRAL_DESP_ID = P000O2_A49REF_CGRAL_DESP_ID[0];
            if ( StringUtil.StrCmp(A45REF_CGRAL_DESP_TIPO, context.GetMessage( "CARGADO", "")) == 0 )
            {
               if ( AV9OperacionTonelaje >= A46REF_CGRAL_DESP_TON_TARIF )
               {
                  if ( A46REF_CGRAL_DESP_TON_TARIF != 0 )
                  {
                     AV12SdtResultado.gxTpr_Sdtresultadopanamax = (decimal)(AV12SdtResultado.gxTpr_Sdtresultadopanamax+(A46REF_CGRAL_DESP_TON_TARIF*A47REF_CGRAL_DESP_TARIFA));
                     AV9OperacionTonelaje = (long)(AV9OperacionTonelaje-A46REF_CGRAL_DESP_TON_TARIF);
                  }
                  else
                  {
                     AV12SdtResultado.gxTpr_Sdtresultadopanamax = (decimal)(AV12SdtResultado.gxTpr_Sdtresultadopanamax+(AV9OperacionTonelaje*A47REF_CGRAL_DESP_TARIFA));
                     AV9OperacionTonelaje = 0;
                     /* Exit For each command. Update data (if necessary), close cursors & exit. */
                     if (true) break;
                  }
               }
               else
               {
                  AV12SdtResultado.gxTpr_Sdtresultadopanamax = (decimal)(AV12SdtResultado.gxTpr_Sdtresultadopanamax+(AV9OperacionTonelaje*A47REF_CGRAL_DESP_TARIFA));
                  AV9OperacionTonelaje = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV9OperacionTonelaje = AV13Tonelaje;
         /* Using cursor P000O3 */
         pr_default.execute(1, new Object[] {AV10REF_CGRAL_DESP_CARGA});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A44REF_CGRAL_DESP_CARGA = P000O3_A44REF_CGRAL_DESP_CARGA[0];
            A45REF_CGRAL_DESP_TIPO = P000O3_A45REF_CGRAL_DESP_TIPO[0];
            n45REF_CGRAL_DESP_TIPO = P000O3_n45REF_CGRAL_DESP_TIPO[0];
            A46REF_CGRAL_DESP_TON_TARIF = P000O3_A46REF_CGRAL_DESP_TON_TARIF[0];
            n46REF_CGRAL_DESP_TON_TARIF = P000O3_n46REF_CGRAL_DESP_TON_TARIF[0];
            A47REF_CGRAL_DESP_TARIFA = P000O3_A47REF_CGRAL_DESP_TARIFA[0];
            A48REF_CGRAL_DESP_ID_TON_TARIF = P000O3_A48REF_CGRAL_DESP_ID_TON_TARIF[0];
            A49REF_CGRAL_DESP_ID = P000O3_A49REF_CGRAL_DESP_ID[0];
            if ( StringUtil.StrCmp(A45REF_CGRAL_DESP_TIPO, context.GetMessage( "EN LASTRE", "")) == 0 )
            {
               if ( AV9OperacionTonelaje >= A46REF_CGRAL_DESP_TON_TARIF )
               {
                  if ( A46REF_CGRAL_DESP_TON_TARIF != 0 )
                  {
                     AV12SdtResultado.gxTpr_Sdtresultadolastre = (decimal)(AV12SdtResultado.gxTpr_Sdtresultadolastre+(A46REF_CGRAL_DESP_TON_TARIF*A47REF_CGRAL_DESP_TARIFA));
                     AV9OperacionTonelaje = (long)(AV9OperacionTonelaje-A46REF_CGRAL_DESP_TON_TARIF);
                  }
                  else
                  {
                     AV12SdtResultado.gxTpr_Sdtresultadolastre = (decimal)(AV12SdtResultado.gxTpr_Sdtresultadolastre+(AV9OperacionTonelaje*A47REF_CGRAL_DESP_TARIFA));
                     AV9OperacionTonelaje = 0;
                     /* Exit For each command. Update data (if necessary), close cursors & exit. */
                     if (true) break;
                  }
               }
               else
               {
                  AV12SdtResultado.gxTpr_Sdtresultadolastre = (decimal)(AV12SdtResultado.gxTpr_Sdtresultadolastre+(AV9OperacionTonelaje*A47REF_CGRAL_DESP_TARIFA));
                  AV9OperacionTonelaje = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            pr_default.readNext(1);
         }
         pr_default.close(1);
         AV11REF_CGRAL_DESP_CARGA_LIST.Add(context.GetMessage( "REFRIGERADA", ""), 0);
         AV11REF_CGRAL_DESP_CARGA_LIST.Add(context.GetMessage( "GENERAL", ""), 0);
         AV11REF_CGRAL_DESP_CARGA_LIST.Add(context.GetMessage( "OTROS", ""), 0);
         if ( (AV11REF_CGRAL_DESP_CARGA_LIST.IndexOf(StringUtil.RTrim( AV10REF_CGRAL_DESP_CARGA))>0) && ( AV8Cubierta > 0 ) )
         {
            /* Using cursor P000O4 */
            pr_default.execute(2);
            while ( (pr_default.getStatus(2) != 101) )
            {
               A44REF_CGRAL_DESP_CARGA = P000O4_A44REF_CGRAL_DESP_CARGA[0];
               A47REF_CGRAL_DESP_TARIFA = P000O4_A47REF_CGRAL_DESP_TARIFA[0];
               A48REF_CGRAL_DESP_ID_TON_TARIF = P000O4_A48REF_CGRAL_DESP_ID_TON_TARIF[0];
               A49REF_CGRAL_DESP_ID = P000O4_A49REF_CGRAL_DESP_ID[0];
               if ( StringUtil.StrCmp(A44REF_CGRAL_DESP_CARGA, context.GetMessage( "CUBIERTA", "")) == 0 )
               {
                  AV12SdtResultado.gxTpr_Sdtlastreroundtrip = (decimal)(AV8Cubierta*A47REF_CGRAL_DESP_TARIFA);
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
               pr_default.readNext(2);
            }
            pr_default.close(2);
            AV12SdtResultado.gxTpr_Sdtresultadopanamax = (decimal)(AV12SdtResultado.gxTpr_Sdtresultadopanamax+AV12SdtResultado.gxTpr_Sdtlastreroundtrip);
         }
         AV14Resultado = StringUtil.Trim( AV12SdtResultado.ToJSonString(false));
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
         P000O2_A44REF_CGRAL_DESP_CARGA = new String[] {""} ;
         P000O2_A45REF_CGRAL_DESP_TIPO = new String[] {""} ;
         P000O2_n45REF_CGRAL_DESP_TIPO = new bool[] {false} ;
         P000O2_A46REF_CGRAL_DESP_TON_TARIF = new long[1] ;
         P000O2_n46REF_CGRAL_DESP_TON_TARIF = new bool[] {false} ;
         P000O2_A47REF_CGRAL_DESP_TARIFA = new decimal[1] ;
         P000O2_A48REF_CGRAL_DESP_ID_TON_TARIF = new short[1] ;
         P000O2_A49REF_CGRAL_DESP_ID = new short[1] ;
         A44REF_CGRAL_DESP_CARGA = "";
         A45REF_CGRAL_DESP_TIPO = "";
         AV12SdtResultado = new SdtSdtResultado(context);
         P000O3_A44REF_CGRAL_DESP_CARGA = new String[] {""} ;
         P000O3_A45REF_CGRAL_DESP_TIPO = new String[] {""} ;
         P000O3_n45REF_CGRAL_DESP_TIPO = new bool[] {false} ;
         P000O3_A46REF_CGRAL_DESP_TON_TARIF = new long[1] ;
         P000O3_n46REF_CGRAL_DESP_TON_TARIF = new bool[] {false} ;
         P000O3_A47REF_CGRAL_DESP_TARIFA = new decimal[1] ;
         P000O3_A48REF_CGRAL_DESP_ID_TON_TARIF = new short[1] ;
         P000O3_A49REF_CGRAL_DESP_ID = new short[1] ;
         AV11REF_CGRAL_DESP_CARGA_LIST = new GxSimpleCollection();
         P000O4_A44REF_CGRAL_DESP_CARGA = new String[] {""} ;
         P000O4_A47REF_CGRAL_DESP_TARIFA = new decimal[1] ;
         P000O4_A48REF_CGRAL_DESP_ID_TON_TARIF = new short[1] ;
         P000O4_A49REF_CGRAL_DESP_ID = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.awscalcularrefcgraldesp__default(),
            new Object[][] {
                new Object[] {
               P000O2_A44REF_CGRAL_DESP_CARGA, P000O2_A45REF_CGRAL_DESP_TIPO, P000O2_n45REF_CGRAL_DESP_TIPO, P000O2_A46REF_CGRAL_DESP_TON_TARIF, P000O2_n46REF_CGRAL_DESP_TON_TARIF, P000O2_A47REF_CGRAL_DESP_TARIFA, P000O2_A48REF_CGRAL_DESP_ID_TON_TARIF, P000O2_A49REF_CGRAL_DESP_ID
               }
               , new Object[] {
               P000O3_A44REF_CGRAL_DESP_CARGA, P000O3_A45REF_CGRAL_DESP_TIPO, P000O3_n45REF_CGRAL_DESP_TIPO, P000O3_A46REF_CGRAL_DESP_TON_TARIF, P000O3_n46REF_CGRAL_DESP_TON_TARIF, P000O3_A47REF_CGRAL_DESP_TARIFA, P000O3_A48REF_CGRAL_DESP_ID_TON_TARIF, P000O3_A49REF_CGRAL_DESP_ID
               }
               , new Object[] {
               P000O4_A44REF_CGRAL_DESP_CARGA, P000O4_A47REF_CGRAL_DESP_TARIFA, P000O4_A48REF_CGRAL_DESP_ID_TON_TARIF, P000O4_A49REF_CGRAL_DESP_ID
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
      private short A48REF_CGRAL_DESP_ID_TON_TARIF ;
      private short A49REF_CGRAL_DESP_ID ;
      private long AV13Tonelaje ;
      private long AV8Cubierta ;
      private long AV9OperacionTonelaje ;
      private long A46REF_CGRAL_DESP_TON_TARIF ;
      private decimal A47REF_CGRAL_DESP_TARIFA ;
      private String currSoapErrmsg ;
      private String currMethod ;
      private String sTagName ;
      private String AV14Resultado ;
      private String scmdbuf ;
      private bool n45REF_CGRAL_DESP_TIPO ;
      private bool n46REF_CGRAL_DESP_TON_TARIF ;
      private String AV10REF_CGRAL_DESP_CARGA ;
      private String A44REF_CGRAL_DESP_CARGA ;
      private String A45REF_CGRAL_DESP_TIPO ;
      private GXXMLReader GXSoapXMLReader ;
      private GXXMLWriter GXSoapXMLWriter ;
      private GxHttpRequest GXSoapHTTPRequest ;
      private GxHttpResponse GXSoapHTTPResponse ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000O2_A44REF_CGRAL_DESP_CARGA ;
      private String[] P000O2_A45REF_CGRAL_DESP_TIPO ;
      private bool[] P000O2_n45REF_CGRAL_DESP_TIPO ;
      private long[] P000O2_A46REF_CGRAL_DESP_TON_TARIF ;
      private bool[] P000O2_n46REF_CGRAL_DESP_TON_TARIF ;
      private decimal[] P000O2_A47REF_CGRAL_DESP_TARIFA ;
      private short[] P000O2_A48REF_CGRAL_DESP_ID_TON_TARIF ;
      private short[] P000O2_A49REF_CGRAL_DESP_ID ;
      private String[] P000O3_A44REF_CGRAL_DESP_CARGA ;
      private String[] P000O3_A45REF_CGRAL_DESP_TIPO ;
      private bool[] P000O3_n45REF_CGRAL_DESP_TIPO ;
      private long[] P000O3_A46REF_CGRAL_DESP_TON_TARIF ;
      private bool[] P000O3_n46REF_CGRAL_DESP_TON_TARIF ;
      private decimal[] P000O3_A47REF_CGRAL_DESP_TARIFA ;
      private short[] P000O3_A48REF_CGRAL_DESP_ID_TON_TARIF ;
      private short[] P000O3_A49REF_CGRAL_DESP_ID ;
      private String[] P000O4_A44REF_CGRAL_DESP_CARGA ;
      private decimal[] P000O4_A47REF_CGRAL_DESP_TARIFA ;
      private short[] P000O4_A48REF_CGRAL_DESP_ID_TON_TARIF ;
      private short[] P000O4_A49REF_CGRAL_DESP_ID ;
      private String aP3_Resultado ;
      [ObjectCollection(ItemType=typeof( String ))]
      private IGxCollection AV11REF_CGRAL_DESP_CARGA_LIST ;
      private SdtSdtResultado AV12SdtResultado ;
   }

   public class awscalcularrefcgraldesp__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000O2 ;
          prmP000O2 = new Object[] {
          new Object[] {"@AV10REF_CGRAL_DESP_CARGA",SqlDbType.VarChar,150,0}
          } ;
          Object[] prmP000O3 ;
          prmP000O3 = new Object[] {
          new Object[] {"@AV10REF_CGRAL_DESP_CARGA",SqlDbType.VarChar,150,0}
          } ;
          Object[] prmP000O4 ;
          prmP000O4 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P000O2", "SELECT [REF_CGRAL_DESP_CARGA], [REF_CGRAL_DESP_TIPO], [REF_CGRAL_DESP_TON_TARIF], [REF_CGRAL_DESP_TARIFA], [REF_CGRAL_DESP_ID_TON_TARIF], [REF_CGRAL_DESP_ID] FROM [REF_CGRAL_DESP] WITH (NOLOCK) WHERE [REF_CGRAL_DESP_CARGA] = @AV10REF_CGRAL_DESP_CARGA ORDER BY [REF_CGRAL_DESP_ID_TON_TARIF] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000O2,100,0,false,false )
             ,new CursorDef("P000O3", "SELECT [REF_CGRAL_DESP_CARGA], [REF_CGRAL_DESP_TIPO], [REF_CGRAL_DESP_TON_TARIF], [REF_CGRAL_DESP_TARIFA], [REF_CGRAL_DESP_ID_TON_TARIF], [REF_CGRAL_DESP_ID] FROM [REF_CGRAL_DESP] WITH (NOLOCK) WHERE [REF_CGRAL_DESP_CARGA] = @AV10REF_CGRAL_DESP_CARGA ORDER BY [REF_CGRAL_DESP_ID_TON_TARIF] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000O3,100,0,false,false )
             ,new CursorDef("P000O4", "SELECT [REF_CGRAL_DESP_CARGA], [REF_CGRAL_DESP_TARIFA], [REF_CGRAL_DESP_ID_TON_TARIF], [REF_CGRAL_DESP_ID] FROM [REF_CGRAL_DESP] WITH (NOLOCK) ORDER BY [REF_CGRAL_DESP_ID_TON_TARIF] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000O4,100,0,false,false )
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
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
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
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
