/*
               File: wscalculobuquesgranelero
        Description: wscalculobuquesgranelero
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:14:57.30
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
   public class awscalculobuquesgranelero : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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
               GXSoapXMLWriter.WriteAttribute("name", "wscalculobuquesgranelero");
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
               GXSoapXMLWriter.WriteAttribute("name", "wscalculobuquesgranelero.Execute");
               GXSoapXMLWriter.WriteStartElement("complexType");
               GXSoapXMLWriter.WriteStartElement("sequence");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "Pgranos");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:double");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "Pcarbon");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:double");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "Pmhierro");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:double");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "Potros");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:double");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "Dwt");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:double");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("name", "wscalculobuquesgranelero.ExecuteResponse");
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
               GXSoapXMLWriter.WriteAttribute("name", "wscalculobuquesgranelero.ExecuteSoapIn");
               GXSoapXMLWriter.WriteElement("part", "");
               GXSoapXMLWriter.WriteAttribute("name", "parameters");
               GXSoapXMLWriter.WriteAttribute("element", "tns:wscalculobuquesgranelero.Execute");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("message");
               GXSoapXMLWriter.WriteAttribute("name", "wscalculobuquesgranelero.ExecuteSoapOut");
               GXSoapXMLWriter.WriteElement("part", "");
               GXSoapXMLWriter.WriteAttribute("name", "parameters");
               GXSoapXMLWriter.WriteAttribute("element", "tns:wscalculobuquesgranelero.ExecuteResponse");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("portType");
               GXSoapXMLWriter.WriteAttribute("name", "wscalculobuquesgraneleroSoapPort");
               GXSoapXMLWriter.WriteStartElement("operation");
               GXSoapXMLWriter.WriteAttribute("name", "Execute");
               GXSoapXMLWriter.WriteElement("input", "");
               GXSoapXMLWriter.WriteAttribute("message", "wsdlns:"+"wscalculobuquesgranelero.ExecuteSoapIn");
               GXSoapXMLWriter.WriteElement("output", "");
               GXSoapXMLWriter.WriteAttribute("message", "wsdlns:"+"wscalculobuquesgranelero.ExecuteSoapOut");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("binding");
               GXSoapXMLWriter.WriteAttribute("name", "wscalculobuquesgraneleroSoapBinding");
               GXSoapXMLWriter.WriteAttribute("type", "wsdlns:"+"wscalculobuquesgraneleroSoapPort");
               GXSoapXMLWriter.WriteElement("soap:binding", "");
               GXSoapXMLWriter.WriteAttribute("style", "document");
               GXSoapXMLWriter.WriteAttribute("transport", "http://schemas.xmlsoap.org/soap/http");
               GXSoapXMLWriter.WriteStartElement("operation");
               GXSoapXMLWriter.WriteAttribute("name", "Execute");
               GXSoapXMLWriter.WriteElement("soap:operation", "");
               GXSoapXMLWriter.WriteAttribute("soapAction", "CalcularPeajesaction/"+"AWSCALCULOBUQUESGRANELERO.Execute");
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
               GXSoapXMLWriter.WriteAttribute("name", "wscalculobuquesgranelero");
               GXSoapXMLWriter.WriteStartElement("port");
               GXSoapXMLWriter.WriteAttribute("name", "wscalculobuquesgraneleroSoapPort");
               GXSoapXMLWriter.WriteAttribute("binding", "wsdlns:"+"wscalculobuquesgraneleroSoapBinding");
               GXSoapXMLWriter.WriteElement("soap:address", "");
               GXSoapXMLWriter.WriteAttribute("location", "http://"+context.GetServerName( )+((context.GetServerPort( )>0)&&(context.GetServerPort( )!=80)&&(context.GetServerPort( )!=443) ? ":"+StringUtil.LTrim( StringUtil.Str( (decimal)(context.GetServerPort( )), 6, 0)) : "")+context.GetScriptPath( )+"awscalculobuquesgranelero.aspx");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.Close();
               return  ;
            }
            else
            {
               currSoapErr = (short)(-20000);
               currSoapErrmsg = "No SOAP request found. Call " + "http://" + context.GetServerName( ) + ((context.GetServerPort( )>0)&&(context.GetServerPort( )!=80)&&(context.GetServerPort( )!=443) ? ":"+StringUtil.LTrim( StringUtil.Str( (decimal)(context.GetServerPort( )), 6, 0)) : "") + context.GetScriptPath( ) + "awscalculobuquesgranelero.aspx" + "?wsdl to get the WSDL.";
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
                              if ( StringUtil.StrCmp2( GXSoapXMLReader.LocalName, "Pgranos") && ( GXSoapXMLReader.NodeType != 2 ) && ( StringUtil.StrCmp(GXSoapXMLReader.NamespaceURI, "CalcularPeajes") == 0 ) )
                              {
                                 AV16PGranos = NumberUtil.Val( GXSoapXMLReader.Value, ".");
                                 if ( GXSoapError > 0 )
                                 {
                                    readOk = 1;
                                 }
                                 GXSoapError = GXSoapXMLReader.Read();
                              }
                              if ( StringUtil.StrCmp2( GXSoapXMLReader.LocalName, "Pcarbon") && ( GXSoapXMLReader.NodeType != 2 ) && ( StringUtil.StrCmp(GXSoapXMLReader.NamespaceURI, "CalcularPeajes") == 0 ) )
                              {
                                 AV11PCarbon = NumberUtil.Val( GXSoapXMLReader.Value, ".");
                                 if ( GXSoapError > 0 )
                                 {
                                    readOk = 1;
                                 }
                                 GXSoapError = GXSoapXMLReader.Read();
                              }
                              if ( StringUtil.StrCmp2( GXSoapXMLReader.LocalName, "Pmhierro") && ( GXSoapXMLReader.NodeType != 2 ) && ( StringUtil.StrCmp(GXSoapXMLReader.NamespaceURI, "CalcularPeajes") == 0 ) )
                              {
                                 AV17PMHierro = NumberUtil.Val( GXSoapXMLReader.Value, ".");
                                 if ( GXSoapError > 0 )
                                 {
                                    readOk = 1;
                                 }
                                 GXSoapError = GXSoapXMLReader.Read();
                              }
                              if ( StringUtil.StrCmp2( GXSoapXMLReader.LocalName, "Potros") && ( GXSoapXMLReader.NodeType != 2 ) && ( StringUtil.StrCmp(GXSoapXMLReader.NamespaceURI, "CalcularPeajes") == 0 ) )
                              {
                                 AV19POtros = NumberUtil.Val( GXSoapXMLReader.Value, ".");
                                 if ( GXSoapError > 0 )
                                 {
                                    readOk = 1;
                                 }
                                 GXSoapError = GXSoapXMLReader.Read();
                              }
                              if ( StringUtil.StrCmp2( GXSoapXMLReader.LocalName, "Dwt") && ( GXSoapXMLReader.NodeType != 2 ) && ( StringUtil.StrCmp(GXSoapXMLReader.NamespaceURI, "CalcularPeajes") == 0 ) )
                              {
                                 AV9DWT = NumberUtil.Val( GXSoapXMLReader.Value, ".");
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
            GXSoapXMLWriter.WriteStartElement("wscalculobuquesgranelero.ExecuteResponse");
            GXSoapXMLWriter.WriteAttribute("xmlns", "CalcularPeajes");
            if ( currSoapErr == 0 )
            {
               GXSoapXMLWriter.WriteElement("Resultado", StringUtil.RTrim( AV30Resultado));
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

      public awscalculobuquesgranelero( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public awscalculobuquesgranelero( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( decimal aP0_PGranos ,
                           decimal aP1_PCarbon ,
                           decimal aP2_PMHierro ,
                           decimal aP3_POtros ,
                           decimal aP4_DWT ,
                           out String aP5_Resultado )
      {
         this.AV16PGranos = aP0_PGranos;
         this.AV11PCarbon = aP1_PCarbon;
         this.AV17PMHierro = aP2_PMHierro;
         this.AV19POtros = aP3_POtros;
         this.AV9DWT = aP4_DWT;
         this.AV30Resultado = "" ;
         initialize();
         executePrivate();
         aP5_Resultado=this.AV30Resultado;
      }

      public String executeUdp( decimal aP0_PGranos ,
                                decimal aP1_PCarbon ,
                                decimal aP2_PMHierro ,
                                decimal aP3_POtros ,
                                decimal aP4_DWT )
      {
         this.AV16PGranos = aP0_PGranos;
         this.AV11PCarbon = aP1_PCarbon;
         this.AV17PMHierro = aP2_PMHierro;
         this.AV19POtros = aP3_POtros;
         this.AV9DWT = aP4_DWT;
         this.AV30Resultado = "" ;
         initialize();
         executePrivate();
         aP5_Resultado=this.AV30Resultado;
         return AV30Resultado ;
      }

      public void executeSubmit( decimal aP0_PGranos ,
                                 decimal aP1_PCarbon ,
                                 decimal aP2_PMHierro ,
                                 decimal aP3_POtros ,
                                 decimal aP4_DWT ,
                                 out String aP5_Resultado )
      {
         awscalculobuquesgranelero objawscalculobuquesgranelero;
         objawscalculobuquesgranelero = new awscalculobuquesgranelero();
         objawscalculobuquesgranelero.AV16PGranos = aP0_PGranos;
         objawscalculobuquesgranelero.AV11PCarbon = aP1_PCarbon;
         objawscalculobuquesgranelero.AV17PMHierro = aP2_PMHierro;
         objawscalculobuquesgranelero.AV19POtros = aP3_POtros;
         objawscalculobuquesgranelero.AV9DWT = aP4_DWT;
         objawscalculobuquesgranelero.AV30Resultado = "" ;
         objawscalculobuquesgranelero.context.SetSubmitInitialConfig(context);
         objawscalculobuquesgranelero.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objawscalculobuquesgranelero);
         aP5_Resultado=this.AV30Resultado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((awscalculobuquesgranelero)stateInfo).executePrivate();
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
         AV13pctGranos = (decimal)((AV16PGranos*100)/ (decimal)(AV9DWT));
         AV12pctCarbon = (decimal)((AV11PCarbon*100)/ (decimal)(AV9DWT));
         AV14pctMHierro = (decimal)((AV17PMHierro*100)/ (decimal)(AV9DWT));
         AV15pctOtros = (decimal)((AV19POtros*100)/ (decimal)(AV9DWT));
         AV18PMT = (decimal)(AV16PGranos+AV11PCarbon+AV17PMHierro+AV19POtros);
         AV25TOTALDWT = AV9DWT;
         /* Using cursor P000J2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A54TarifasGranelesSecosTipoGranos = P000J2_A54TarifasGranelesSecosTipoGranos[0];
            A52TarifasGranelesSecosBandas = P000J2_A52TarifasGranelesSecosBandas[0];
            A55TarifasGranelesSecosTarifaS_DW = P000J2_A55TarifasGranelesSecosTarifaS_DW[0];
            A57TarifasGranelesSecosDescBandas = P000J2_A57TarifasGranelesSecosDescBandas[0];
            A51TarifasGranelesSecosCodPeaje = P000J2_A51TarifasGranelesSecosCodPeaje[0];
            if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
            {
               if ( A52TarifasGranelesSecosBandas != 1 )
               {
                  AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                  AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
               }
               else
               {
                  AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                  AV25TOTALDWT = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            else
            {
               AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
               AV25TOTALDWT = 0;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadolastre = AV28ValorACalcular;
         if ( ( AV16PGranos == Convert.ToDecimal( 0 )) && ( AV11PCarbon == Convert.ToDecimal( 0 )) && ( AV17PMHierro == Convert.ToDecimal( 0 )) && ( AV19POtros == Convert.ToDecimal( 0 )) )
         {
            AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadoneopanamax = AV28ValorACalcular;
            AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadopanamax = AV28ValorACalcular;
         }
         else
         {
            if ( ( AV13pctGranos > Convert.ToDecimal( 50 )) || ( AV12pctCarbon > Convert.ToDecimal( 50 )) || ( AV14pctMHierro > Convert.ToDecimal( 50 )) || ( AV15pctOtros > Convert.ToDecimal( 50 )) )
            {
               if ( ( AV13pctGranos > Convert.ToDecimal( 50 )) )
               {
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000J3 */
                  pr_default.execute(1);
                  while ( (pr_default.getStatus(1) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000J3_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000J3_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000J3_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000J3_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000J3_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000J3_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000J3_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(1);
                  }
                  pr_default.close(1);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadopanamax = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000J4 */
                  pr_default.execute(2);
                  while ( (pr_default.getStatus(2) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000J4_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000J4_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000J4_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000J4_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000J4_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000J4_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000J4_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(2);
                  }
                  pr_default.close(2);
                  AV29ValorACalcularDWT = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV27TOTALMT = AV18PMT;
                  /* Using cursor P000J5 */
                  pr_default.execute(3);
                  while ( (pr_default.getStatus(3) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000J5_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000J5_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000J5_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000J5_A52TarifasGranelesSecosBandas[0];
                     A56TarifasGranelesSecosTarifaS_Ca = P000J5_A56TarifasGranelesSecosTarifaS_Ca[0];
                     A57TarifasGranelesSecosDescBandas = P000J5_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000J5_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV27TOTALMT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = (decimal)(AV27TOTALMT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                        AV27TOTALMT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(3);
                  }
                  pr_default.close(3);
                  AV28ValorACalcular = (decimal)(AV28ValorACalcular+AV29ValorACalcularDWT);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadoneopanamax = AV28ValorACalcular;
               }
               if ( ( AV12pctCarbon > Convert.ToDecimal( 50 )) )
               {
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000J6 */
                  pr_default.execute(4);
                  while ( (pr_default.getStatus(4) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000J6_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000J6_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000J6_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000J6_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000J6_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000J6_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000J6_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(4);
                  }
                  pr_default.close(4);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadopanamax = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000J7 */
                  pr_default.execute(5);
                  while ( (pr_default.getStatus(5) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000J7_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000J7_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000J7_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000J7_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000J7_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000J7_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000J7_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(5);
                  }
                  pr_default.close(5);
                  AV29ValorACalcularDWT = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV27TOTALMT = AV18PMT;
                  /* Using cursor P000J8 */
                  pr_default.execute(6);
                  while ( (pr_default.getStatus(6) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000J8_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000J8_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000J8_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000J8_A52TarifasGranelesSecosBandas[0];
                     A56TarifasGranelesSecosTarifaS_Ca = P000J8_A56TarifasGranelesSecosTarifaS_Ca[0];
                     A57TarifasGranelesSecosDescBandas = P000J8_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000J8_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV27TOTALMT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = (decimal)(AV27TOTALMT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                        AV27TOTALMT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(6);
                  }
                  pr_default.close(6);
                  AV28ValorACalcular = (decimal)(AV28ValorACalcular+AV29ValorACalcularDWT);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadoneopanamax = AV28ValorACalcular;
               }
               if ( ( AV14pctMHierro > Convert.ToDecimal( 50 )) )
               {
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000J9 */
                  pr_default.execute(7);
                  while ( (pr_default.getStatus(7) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000J9_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000J9_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000J9_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000J9_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000J9_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000J9_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000J9_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(7);
                  }
                  pr_default.close(7);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadopanamax = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000J10 */
                  pr_default.execute(8);
                  while ( (pr_default.getStatus(8) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000J10_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000J10_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000J10_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000J10_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000J10_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000J10_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000J10_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(8);
                  }
                  pr_default.close(8);
                  AV29ValorACalcularDWT = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV27TOTALMT = AV18PMT;
                  /* Using cursor P000J11 */
                  pr_default.execute(9);
                  while ( (pr_default.getStatus(9) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000J11_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000J11_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000J11_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000J11_A52TarifasGranelesSecosBandas[0];
                     A56TarifasGranelesSecosTarifaS_Ca = P000J11_A56TarifasGranelesSecosTarifaS_Ca[0];
                     A57TarifasGranelesSecosDescBandas = P000J11_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000J11_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV27TOTALMT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = (decimal)(AV27TOTALMT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                        AV27TOTALMT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(9);
                  }
                  pr_default.close(9);
                  AV28ValorACalcular = (decimal)(AV28ValorACalcular+AV29ValorACalcularDWT);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadoneopanamax = AV28ValorACalcular;
               }
               if ( ( AV15pctOtros > Convert.ToDecimal( 50 )) )
               {
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000J12 */
                  pr_default.execute(10);
                  while ( (pr_default.getStatus(10) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000J12_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000J12_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000J12_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000J12_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000J12_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000J12_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000J12_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(10);
                  }
                  pr_default.close(10);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadopanamax = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000J13 */
                  pr_default.execute(11);
                  while ( (pr_default.getStatus(11) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000J13_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000J13_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000J13_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000J13_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000J13_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000J13_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000J13_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(11);
                  }
                  pr_default.close(11);
                  AV29ValorACalcularDWT = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV27TOTALMT = AV18PMT;
                  /* Using cursor P000J14 */
                  pr_default.execute(12);
                  while ( (pr_default.getStatus(12) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000J14_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000J14_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000J14_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000J14_A52TarifasGranelesSecosBandas[0];
                     A56TarifasGranelesSecosTarifaS_Ca = P000J14_A56TarifasGranelesSecosTarifaS_Ca[0];
                     A57TarifasGranelesSecosDescBandas = P000J14_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000J14_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV27TOTALMT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = (decimal)(AV27TOTALMT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                        AV27TOTALMT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(12);
                  }
                  pr_default.close(12);
                  AV28ValorACalcular = (decimal)(AV28ValorACalcular+AV29ValorACalcularDWT);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadoneopanamax = AV28ValorACalcular;
               }
            }
            AV8cont = 0;
            if ( ( AV13pctGranos == Convert.ToDecimal( 50 )) )
            {
               AV8cont = (short)(AV8cont+1);
            }
            if ( ( AV12pctCarbon == Convert.ToDecimal( 50 )) )
            {
               AV8cont = (short)(AV8cont+1);
            }
            if ( ( AV14pctMHierro == Convert.ToDecimal( 50 )) )
            {
               AV8cont = (short)(AV8cont+1);
            }
            if ( ( AV15pctOtros == Convert.ToDecimal( 50 )) )
            {
               AV8cont = (short)(AV8cont+1);
            }
            if ( AV8cont < 2 )
            {
               if ( ( AV13pctGranos <= Convert.ToDecimal( 50 )) && ( AV12pctCarbon <= Convert.ToDecimal( 50 )) && ( AV14pctMHierro <= Convert.ToDecimal( 50 )) && ( AV15pctOtros <= Convert.ToDecimal( 50 )) )
               {
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000J15 */
                  pr_default.execute(13);
                  while ( (pr_default.getStatus(13) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000J15_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000J15_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000J15_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000J15_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000J15_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000J15_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000J15_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(13);
                  }
                  pr_default.close(13);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadopanamax = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000J16 */
                  pr_default.execute(14);
                  while ( (pr_default.getStatus(14) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000J16_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000J16_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000J16_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000J16_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000J16_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000J16_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000J16_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(14);
                  }
                  pr_default.close(14);
                  AV29ValorACalcularDWT = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV27TOTALMT = AV18PMT;
                  /* Using cursor P000J17 */
                  pr_default.execute(15);
                  while ( (pr_default.getStatus(15) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000J17_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000J17_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000J17_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000J17_A52TarifasGranelesSecosBandas[0];
                     A56TarifasGranelesSecosTarifaS_Ca = P000J17_A56TarifasGranelesSecosTarifaS_Ca[0];
                     A57TarifasGranelesSecosDescBandas = P000J17_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000J17_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV27TOTALMT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = (decimal)(AV27TOTALMT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                        AV27TOTALMT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(15);
                  }
                  pr_default.close(15);
                  AV28ValorACalcular = (decimal)(AV28ValorACalcular+AV29ValorACalcularDWT);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadoneopanamax = AV28ValorACalcular;
               }
            }
            else
            {
               if ( ( AV13pctGranos == Convert.ToDecimal( 50 )) || ( AV15pctOtros == Convert.ToDecimal( 50 )) )
               {
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000J18 */
                  pr_default.execute(16);
                  while ( (pr_default.getStatus(16) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000J18_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000J18_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000J18_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000J18_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000J18_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000J18_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000J18_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(16);
                  }
                  pr_default.close(16);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadopanamax = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000J19 */
                  pr_default.execute(17);
                  while ( (pr_default.getStatus(17) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000J19_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000J19_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000J19_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000J19_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000J19_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000J19_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000J19_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(17);
                  }
                  pr_default.close(17);
                  AV29ValorACalcularDWT = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV27TOTALMT = AV18PMT;
                  /* Using cursor P000J20 */
                  pr_default.execute(18);
                  while ( (pr_default.getStatus(18) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000J20_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000J20_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000J20_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000J20_A52TarifasGranelesSecosBandas[0];
                     A56TarifasGranelesSecosTarifaS_Ca = P000J20_A56TarifasGranelesSecosTarifaS_Ca[0];
                     A57TarifasGranelesSecosDescBandas = P000J20_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000J20_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV27TOTALMT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = (decimal)(AV27TOTALMT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                        AV27TOTALMT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(18);
                  }
                  pr_default.close(18);
                  AV28ValorACalcular = (decimal)(AV28ValorACalcular+AV29ValorACalcularDWT);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadoneopanamax = AV28ValorACalcular;
               }
               if ( ( AV12pctCarbon == Convert.ToDecimal( 50 )) && ( AV13pctGranos == Convert.ToDecimal( 0 )) && ( AV15pctOtros == Convert.ToDecimal( 0 )) )
               {
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000J21 */
                  pr_default.execute(19);
                  while ( (pr_default.getStatus(19) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000J21_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000J21_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000J21_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000J21_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000J21_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000J21_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000J21_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(19);
                  }
                  pr_default.close(19);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadopanamax = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000J22 */
                  pr_default.execute(20);
                  while ( (pr_default.getStatus(20) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000J22_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000J22_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000J22_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000J22_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000J22_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000J22_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000J22_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(20);
                  }
                  pr_default.close(20);
                  AV29ValorACalcularDWT = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV27TOTALMT = AV18PMT;
                  /* Using cursor P000J23 */
                  pr_default.execute(21);
                  while ( (pr_default.getStatus(21) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000J23_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000J23_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000J23_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000J23_A52TarifasGranelesSecosBandas[0];
                     A56TarifasGranelesSecosTarifaS_Ca = P000J23_A56TarifasGranelesSecosTarifaS_Ca[0];
                     A57TarifasGranelesSecosDescBandas = P000J23_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000J23_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV27TOTALMT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = (decimal)(AV27TOTALMT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                        AV27TOTALMT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(21);
                  }
                  pr_default.close(21);
                  AV28ValorACalcular = (decimal)(AV28ValorACalcular+AV29ValorACalcularDWT);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadoneopanamax = AV28ValorACalcular;
               }
            }
         }
         AV30Resultado = StringUtil.Trim( AV21SDTGraneleros.ToJSonString(false));
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
         P000J2_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000J2_A52TarifasGranelesSecosBandas = new long[1] ;
         P000J2_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000J2_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000J2_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         A54TarifasGranelesSecosTipoGranos = "";
         A57TarifasGranelesSecosDescBandas = "";
         AV21SDTGraneleros = new SdtSDTGraneleros(context);
         P000J3_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000J3_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000J3_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000J3_A52TarifasGranelesSecosBandas = new long[1] ;
         P000J3_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000J3_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000J3_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         A53TarifasGranelesSecosTipoEsclus = "";
         P000J4_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000J4_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000J4_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000J4_A52TarifasGranelesSecosBandas = new long[1] ;
         P000J4_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000J4_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000J4_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000J5_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000J5_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000J5_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000J5_A52TarifasGranelesSecosBandas = new long[1] ;
         P000J5_A56TarifasGranelesSecosTarifaS_Ca = new decimal[1] ;
         P000J5_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000J5_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000J6_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000J6_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000J6_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000J6_A52TarifasGranelesSecosBandas = new long[1] ;
         P000J6_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000J6_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000J6_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000J7_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000J7_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000J7_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000J7_A52TarifasGranelesSecosBandas = new long[1] ;
         P000J7_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000J7_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000J7_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000J8_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000J8_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000J8_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000J8_A52TarifasGranelesSecosBandas = new long[1] ;
         P000J8_A56TarifasGranelesSecosTarifaS_Ca = new decimal[1] ;
         P000J8_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000J8_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000J9_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000J9_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000J9_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000J9_A52TarifasGranelesSecosBandas = new long[1] ;
         P000J9_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000J9_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000J9_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000J10_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000J10_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000J10_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000J10_A52TarifasGranelesSecosBandas = new long[1] ;
         P000J10_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000J10_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000J10_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000J11_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000J11_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000J11_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000J11_A52TarifasGranelesSecosBandas = new long[1] ;
         P000J11_A56TarifasGranelesSecosTarifaS_Ca = new decimal[1] ;
         P000J11_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000J11_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000J12_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000J12_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000J12_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000J12_A52TarifasGranelesSecosBandas = new long[1] ;
         P000J12_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000J12_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000J12_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000J13_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000J13_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000J13_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000J13_A52TarifasGranelesSecosBandas = new long[1] ;
         P000J13_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000J13_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000J13_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000J14_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000J14_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000J14_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000J14_A52TarifasGranelesSecosBandas = new long[1] ;
         P000J14_A56TarifasGranelesSecosTarifaS_Ca = new decimal[1] ;
         P000J14_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000J14_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000J15_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000J15_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000J15_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000J15_A52TarifasGranelesSecosBandas = new long[1] ;
         P000J15_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000J15_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000J15_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000J16_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000J16_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000J16_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000J16_A52TarifasGranelesSecosBandas = new long[1] ;
         P000J16_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000J16_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000J16_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000J17_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000J17_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000J17_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000J17_A52TarifasGranelesSecosBandas = new long[1] ;
         P000J17_A56TarifasGranelesSecosTarifaS_Ca = new decimal[1] ;
         P000J17_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000J17_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000J18_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000J18_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000J18_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000J18_A52TarifasGranelesSecosBandas = new long[1] ;
         P000J18_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000J18_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000J18_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000J19_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000J19_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000J19_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000J19_A52TarifasGranelesSecosBandas = new long[1] ;
         P000J19_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000J19_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000J19_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000J20_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000J20_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000J20_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000J20_A52TarifasGranelesSecosBandas = new long[1] ;
         P000J20_A56TarifasGranelesSecosTarifaS_Ca = new decimal[1] ;
         P000J20_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000J20_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000J21_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000J21_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000J21_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000J21_A52TarifasGranelesSecosBandas = new long[1] ;
         P000J21_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000J21_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000J21_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000J22_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000J22_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000J22_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000J22_A52TarifasGranelesSecosBandas = new long[1] ;
         P000J22_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000J22_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000J22_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000J23_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000J23_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000J23_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000J23_A52TarifasGranelesSecosBandas = new long[1] ;
         P000J23_A56TarifasGranelesSecosTarifaS_Ca = new decimal[1] ;
         P000J23_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000J23_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.awscalculobuquesgranelero__default(),
            new Object[][] {
                new Object[] {
               P000J2_A54TarifasGranelesSecosTipoGranos, P000J2_A52TarifasGranelesSecosBandas, P000J2_A55TarifasGranelesSecosTarifaS_DW, P000J2_A57TarifasGranelesSecosDescBandas, P000J2_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000J3_A53TarifasGranelesSecosTipoEsclus, P000J3_n53TarifasGranelesSecosTipoEsclus, P000J3_A54TarifasGranelesSecosTipoGranos, P000J3_A52TarifasGranelesSecosBandas, P000J3_A55TarifasGranelesSecosTarifaS_DW, P000J3_A57TarifasGranelesSecosDescBandas, P000J3_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000J4_A53TarifasGranelesSecosTipoEsclus, P000J4_n53TarifasGranelesSecosTipoEsclus, P000J4_A54TarifasGranelesSecosTipoGranos, P000J4_A52TarifasGranelesSecosBandas, P000J4_A55TarifasGranelesSecosTarifaS_DW, P000J4_A57TarifasGranelesSecosDescBandas, P000J4_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000J5_A53TarifasGranelesSecosTipoEsclus, P000J5_n53TarifasGranelesSecosTipoEsclus, P000J5_A54TarifasGranelesSecosTipoGranos, P000J5_A52TarifasGranelesSecosBandas, P000J5_A56TarifasGranelesSecosTarifaS_Ca, P000J5_A57TarifasGranelesSecosDescBandas, P000J5_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000J6_A53TarifasGranelesSecosTipoEsclus, P000J6_n53TarifasGranelesSecosTipoEsclus, P000J6_A54TarifasGranelesSecosTipoGranos, P000J6_A52TarifasGranelesSecosBandas, P000J6_A55TarifasGranelesSecosTarifaS_DW, P000J6_A57TarifasGranelesSecosDescBandas, P000J6_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000J7_A53TarifasGranelesSecosTipoEsclus, P000J7_n53TarifasGranelesSecosTipoEsclus, P000J7_A54TarifasGranelesSecosTipoGranos, P000J7_A52TarifasGranelesSecosBandas, P000J7_A55TarifasGranelesSecosTarifaS_DW, P000J7_A57TarifasGranelesSecosDescBandas, P000J7_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000J8_A53TarifasGranelesSecosTipoEsclus, P000J8_n53TarifasGranelesSecosTipoEsclus, P000J8_A54TarifasGranelesSecosTipoGranos, P000J8_A52TarifasGranelesSecosBandas, P000J8_A56TarifasGranelesSecosTarifaS_Ca, P000J8_A57TarifasGranelesSecosDescBandas, P000J8_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000J9_A53TarifasGranelesSecosTipoEsclus, P000J9_n53TarifasGranelesSecosTipoEsclus, P000J9_A54TarifasGranelesSecosTipoGranos, P000J9_A52TarifasGranelesSecosBandas, P000J9_A55TarifasGranelesSecosTarifaS_DW, P000J9_A57TarifasGranelesSecosDescBandas, P000J9_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000J10_A53TarifasGranelesSecosTipoEsclus, P000J10_n53TarifasGranelesSecosTipoEsclus, P000J10_A54TarifasGranelesSecosTipoGranos, P000J10_A52TarifasGranelesSecosBandas, P000J10_A55TarifasGranelesSecosTarifaS_DW, P000J10_A57TarifasGranelesSecosDescBandas, P000J10_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000J11_A53TarifasGranelesSecosTipoEsclus, P000J11_n53TarifasGranelesSecosTipoEsclus, P000J11_A54TarifasGranelesSecosTipoGranos, P000J11_A52TarifasGranelesSecosBandas, P000J11_A56TarifasGranelesSecosTarifaS_Ca, P000J11_A57TarifasGranelesSecosDescBandas, P000J11_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000J12_A53TarifasGranelesSecosTipoEsclus, P000J12_n53TarifasGranelesSecosTipoEsclus, P000J12_A54TarifasGranelesSecosTipoGranos, P000J12_A52TarifasGranelesSecosBandas, P000J12_A55TarifasGranelesSecosTarifaS_DW, P000J12_A57TarifasGranelesSecosDescBandas, P000J12_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000J13_A53TarifasGranelesSecosTipoEsclus, P000J13_n53TarifasGranelesSecosTipoEsclus, P000J13_A54TarifasGranelesSecosTipoGranos, P000J13_A52TarifasGranelesSecosBandas, P000J13_A55TarifasGranelesSecosTarifaS_DW, P000J13_A57TarifasGranelesSecosDescBandas, P000J13_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000J14_A53TarifasGranelesSecosTipoEsclus, P000J14_n53TarifasGranelesSecosTipoEsclus, P000J14_A54TarifasGranelesSecosTipoGranos, P000J14_A52TarifasGranelesSecosBandas, P000J14_A56TarifasGranelesSecosTarifaS_Ca, P000J14_A57TarifasGranelesSecosDescBandas, P000J14_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000J15_A53TarifasGranelesSecosTipoEsclus, P000J15_n53TarifasGranelesSecosTipoEsclus, P000J15_A54TarifasGranelesSecosTipoGranos, P000J15_A52TarifasGranelesSecosBandas, P000J15_A55TarifasGranelesSecosTarifaS_DW, P000J15_A57TarifasGranelesSecosDescBandas, P000J15_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000J16_A53TarifasGranelesSecosTipoEsclus, P000J16_n53TarifasGranelesSecosTipoEsclus, P000J16_A54TarifasGranelesSecosTipoGranos, P000J16_A52TarifasGranelesSecosBandas, P000J16_A55TarifasGranelesSecosTarifaS_DW, P000J16_A57TarifasGranelesSecosDescBandas, P000J16_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000J17_A53TarifasGranelesSecosTipoEsclus, P000J17_n53TarifasGranelesSecosTipoEsclus, P000J17_A54TarifasGranelesSecosTipoGranos, P000J17_A52TarifasGranelesSecosBandas, P000J17_A56TarifasGranelesSecosTarifaS_Ca, P000J17_A57TarifasGranelesSecosDescBandas, P000J17_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000J18_A53TarifasGranelesSecosTipoEsclus, P000J18_n53TarifasGranelesSecosTipoEsclus, P000J18_A54TarifasGranelesSecosTipoGranos, P000J18_A52TarifasGranelesSecosBandas, P000J18_A55TarifasGranelesSecosTarifaS_DW, P000J18_A57TarifasGranelesSecosDescBandas, P000J18_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000J19_A53TarifasGranelesSecosTipoEsclus, P000J19_n53TarifasGranelesSecosTipoEsclus, P000J19_A54TarifasGranelesSecosTipoGranos, P000J19_A52TarifasGranelesSecosBandas, P000J19_A55TarifasGranelesSecosTarifaS_DW, P000J19_A57TarifasGranelesSecosDescBandas, P000J19_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000J20_A53TarifasGranelesSecosTipoEsclus, P000J20_n53TarifasGranelesSecosTipoEsclus, P000J20_A54TarifasGranelesSecosTipoGranos, P000J20_A52TarifasGranelesSecosBandas, P000J20_A56TarifasGranelesSecosTarifaS_Ca, P000J20_A57TarifasGranelesSecosDescBandas, P000J20_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000J21_A53TarifasGranelesSecosTipoEsclus, P000J21_n53TarifasGranelesSecosTipoEsclus, P000J21_A54TarifasGranelesSecosTipoGranos, P000J21_A52TarifasGranelesSecosBandas, P000J21_A55TarifasGranelesSecosTarifaS_DW, P000J21_A57TarifasGranelesSecosDescBandas, P000J21_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000J22_A53TarifasGranelesSecosTipoEsclus, P000J22_n53TarifasGranelesSecosTipoEsclus, P000J22_A54TarifasGranelesSecosTipoGranos, P000J22_A52TarifasGranelesSecosBandas, P000J22_A55TarifasGranelesSecosTarifaS_DW, P000J22_A57TarifasGranelesSecosDescBandas, P000J22_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000J23_A53TarifasGranelesSecosTipoEsclus, P000J23_n53TarifasGranelesSecosTipoEsclus, P000J23_A54TarifasGranelesSecosTipoGranos, P000J23_A52TarifasGranelesSecosBandas, P000J23_A56TarifasGranelesSecosTarifaS_Ca, P000J23_A57TarifasGranelesSecosDescBandas, P000J23_A51TarifasGranelesSecosCodPeaje
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
      private short AV8cont ;
      private long A52TarifasGranelesSecosBandas ;
      private long A51TarifasGranelesSecosCodPeaje ;
      private decimal AV16PGranos ;
      private decimal AV11PCarbon ;
      private decimal AV17PMHierro ;
      private decimal AV19POtros ;
      private decimal AV9DWT ;
      private decimal AV13pctGranos ;
      private decimal AV12pctCarbon ;
      private decimal AV14pctMHierro ;
      private decimal AV15pctOtros ;
      private decimal AV18PMT ;
      private decimal AV25TOTALDWT ;
      private decimal A55TarifasGranelesSecosTarifaS_DW ;
      private decimal AV28ValorACalcular ;
      private decimal AV29ValorACalcularDWT ;
      private decimal AV27TOTALMT ;
      private decimal A56TarifasGranelesSecosTarifaS_Ca ;
      private String currSoapErrmsg ;
      private String currMethod ;
      private String sTagName ;
      private String scmdbuf ;
      private bool n53TarifasGranelesSecosTipoEsclus ;
      private String AV30Resultado ;
      private String A54TarifasGranelesSecosTipoGranos ;
      private String A57TarifasGranelesSecosDescBandas ;
      private String A53TarifasGranelesSecosTipoEsclus ;
      private GXXMLReader GXSoapXMLReader ;
      private GXXMLWriter GXSoapXMLWriter ;
      private GxHttpRequest GXSoapHTTPRequest ;
      private GxHttpResponse GXSoapHTTPResponse ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000J2_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000J2_A52TarifasGranelesSecosBandas ;
      private decimal[] P000J2_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000J2_A57TarifasGranelesSecosDescBandas ;
      private long[] P000J2_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000J3_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000J3_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000J3_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000J3_A52TarifasGranelesSecosBandas ;
      private decimal[] P000J3_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000J3_A57TarifasGranelesSecosDescBandas ;
      private long[] P000J3_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000J4_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000J4_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000J4_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000J4_A52TarifasGranelesSecosBandas ;
      private decimal[] P000J4_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000J4_A57TarifasGranelesSecosDescBandas ;
      private long[] P000J4_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000J5_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000J5_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000J5_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000J5_A52TarifasGranelesSecosBandas ;
      private decimal[] P000J5_A56TarifasGranelesSecosTarifaS_Ca ;
      private String[] P000J5_A57TarifasGranelesSecosDescBandas ;
      private long[] P000J5_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000J6_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000J6_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000J6_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000J6_A52TarifasGranelesSecosBandas ;
      private decimal[] P000J6_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000J6_A57TarifasGranelesSecosDescBandas ;
      private long[] P000J6_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000J7_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000J7_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000J7_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000J7_A52TarifasGranelesSecosBandas ;
      private decimal[] P000J7_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000J7_A57TarifasGranelesSecosDescBandas ;
      private long[] P000J7_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000J8_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000J8_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000J8_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000J8_A52TarifasGranelesSecosBandas ;
      private decimal[] P000J8_A56TarifasGranelesSecosTarifaS_Ca ;
      private String[] P000J8_A57TarifasGranelesSecosDescBandas ;
      private long[] P000J8_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000J9_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000J9_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000J9_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000J9_A52TarifasGranelesSecosBandas ;
      private decimal[] P000J9_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000J9_A57TarifasGranelesSecosDescBandas ;
      private long[] P000J9_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000J10_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000J10_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000J10_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000J10_A52TarifasGranelesSecosBandas ;
      private decimal[] P000J10_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000J10_A57TarifasGranelesSecosDescBandas ;
      private long[] P000J10_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000J11_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000J11_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000J11_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000J11_A52TarifasGranelesSecosBandas ;
      private decimal[] P000J11_A56TarifasGranelesSecosTarifaS_Ca ;
      private String[] P000J11_A57TarifasGranelesSecosDescBandas ;
      private long[] P000J11_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000J12_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000J12_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000J12_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000J12_A52TarifasGranelesSecosBandas ;
      private decimal[] P000J12_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000J12_A57TarifasGranelesSecosDescBandas ;
      private long[] P000J12_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000J13_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000J13_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000J13_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000J13_A52TarifasGranelesSecosBandas ;
      private decimal[] P000J13_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000J13_A57TarifasGranelesSecosDescBandas ;
      private long[] P000J13_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000J14_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000J14_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000J14_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000J14_A52TarifasGranelesSecosBandas ;
      private decimal[] P000J14_A56TarifasGranelesSecosTarifaS_Ca ;
      private String[] P000J14_A57TarifasGranelesSecosDescBandas ;
      private long[] P000J14_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000J15_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000J15_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000J15_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000J15_A52TarifasGranelesSecosBandas ;
      private decimal[] P000J15_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000J15_A57TarifasGranelesSecosDescBandas ;
      private long[] P000J15_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000J16_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000J16_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000J16_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000J16_A52TarifasGranelesSecosBandas ;
      private decimal[] P000J16_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000J16_A57TarifasGranelesSecosDescBandas ;
      private long[] P000J16_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000J17_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000J17_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000J17_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000J17_A52TarifasGranelesSecosBandas ;
      private decimal[] P000J17_A56TarifasGranelesSecosTarifaS_Ca ;
      private String[] P000J17_A57TarifasGranelesSecosDescBandas ;
      private long[] P000J17_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000J18_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000J18_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000J18_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000J18_A52TarifasGranelesSecosBandas ;
      private decimal[] P000J18_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000J18_A57TarifasGranelesSecosDescBandas ;
      private long[] P000J18_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000J19_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000J19_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000J19_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000J19_A52TarifasGranelesSecosBandas ;
      private decimal[] P000J19_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000J19_A57TarifasGranelesSecosDescBandas ;
      private long[] P000J19_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000J20_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000J20_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000J20_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000J20_A52TarifasGranelesSecosBandas ;
      private decimal[] P000J20_A56TarifasGranelesSecosTarifaS_Ca ;
      private String[] P000J20_A57TarifasGranelesSecosDescBandas ;
      private long[] P000J20_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000J21_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000J21_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000J21_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000J21_A52TarifasGranelesSecosBandas ;
      private decimal[] P000J21_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000J21_A57TarifasGranelesSecosDescBandas ;
      private long[] P000J21_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000J22_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000J22_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000J22_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000J22_A52TarifasGranelesSecosBandas ;
      private decimal[] P000J22_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000J22_A57TarifasGranelesSecosDescBandas ;
      private long[] P000J22_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000J23_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000J23_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000J23_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000J23_A52TarifasGranelesSecosBandas ;
      private decimal[] P000J23_A56TarifasGranelesSecosTarifaS_Ca ;
      private String[] P000J23_A57TarifasGranelesSecosDescBandas ;
      private long[] P000J23_A51TarifasGranelesSecosCodPeaje ;
      private String aP5_Resultado ;
      private SdtSDTGraneleros AV21SDTGraneleros ;
   }

   public class awscalculobuquesgranelero__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000J2 ;
          prmP000J2 = new Object[] {
          } ;
          Object[] prmP000J3 ;
          prmP000J3 = new Object[] {
          } ;
          Object[] prmP000J4 ;
          prmP000J4 = new Object[] {
          } ;
          Object[] prmP000J5 ;
          prmP000J5 = new Object[] {
          } ;
          Object[] prmP000J6 ;
          prmP000J6 = new Object[] {
          } ;
          Object[] prmP000J7 ;
          prmP000J7 = new Object[] {
          } ;
          Object[] prmP000J8 ;
          prmP000J8 = new Object[] {
          } ;
          Object[] prmP000J9 ;
          prmP000J9 = new Object[] {
          } ;
          Object[] prmP000J10 ;
          prmP000J10 = new Object[] {
          } ;
          Object[] prmP000J11 ;
          prmP000J11 = new Object[] {
          } ;
          Object[] prmP000J12 ;
          prmP000J12 = new Object[] {
          } ;
          Object[] prmP000J13 ;
          prmP000J13 = new Object[] {
          } ;
          Object[] prmP000J14 ;
          prmP000J14 = new Object[] {
          } ;
          Object[] prmP000J15 ;
          prmP000J15 = new Object[] {
          } ;
          Object[] prmP000J16 ;
          prmP000J16 = new Object[] {
          } ;
          Object[] prmP000J17 ;
          prmP000J17 = new Object[] {
          } ;
          Object[] prmP000J18 ;
          prmP000J18 = new Object[] {
          } ;
          Object[] prmP000J19 ;
          prmP000J19 = new Object[] {
          } ;
          Object[] prmP000J20 ;
          prmP000J20 = new Object[] {
          } ;
          Object[] prmP000J21 ;
          prmP000J21 = new Object[] {
          } ;
          Object[] prmP000J22 ;
          prmP000J22 = new Object[] {
          } ;
          Object[] prmP000J23 ;
          prmP000J23 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P000J2", "SELECT [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE [TarifasGranelesSecosTipoGranos] = 'Lastre' ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J2,100,0,false,false )
             ,new CursorDef("P000J3", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'Panamax') AND ([TarifasGranelesSecosTipoGranos] = 'Granos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J3,100,0,false,false )
             ,new CursorDef("P000J4", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Granos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J4,100,0,false,false )
             ,new CursorDef("P000J5", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_Ca], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Granos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J5,100,0,false,false )
             ,new CursorDef("P000J6", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'Panamax') AND ([TarifasGranelesSecosTipoGranos] = 'Carbón') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J6,100,0,false,false )
             ,new CursorDef("P000J7", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Carbón') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J7,100,0,false,false )
             ,new CursorDef("P000J8", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_Ca], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Carbón') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J8,100,0,false,false )
             ,new CursorDef("P000J9", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'Panamax') AND ([TarifasGranelesSecosTipoGranos] = 'Mineral Hierro') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J9,100,0,false,false )
             ,new CursorDef("P000J10", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Mineral Hierro') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J10,100,0,false,false )
             ,new CursorDef("P000J11", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_Ca], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Mineral Hierro') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J11,100,0,false,false )
             ,new CursorDef("P000J12", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'Panamax') AND ([TarifasGranelesSecosTipoGranos] = 'Otros Graneles Secos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J12,100,0,false,false )
             ,new CursorDef("P000J13", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Otros Graneles Secos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J13,100,0,false,false )
             ,new CursorDef("P000J14", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_Ca], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Otros Graneles Secos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J14,100,0,false,false )
             ,new CursorDef("P000J15", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'Panamax') AND ([TarifasGranelesSecosTipoGranos] = 'Otros Graneles Secos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J15,100,0,false,false )
             ,new CursorDef("P000J16", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Otros Graneles Secos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J16,100,0,false,false )
             ,new CursorDef("P000J17", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_Ca], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Otros Graneles Secos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J17,100,0,false,false )
             ,new CursorDef("P000J18", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'Panamax') AND ([TarifasGranelesSecosTipoGranos] = 'Otros Graneles Secos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J18,100,0,false,false )
             ,new CursorDef("P000J19", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Otros Graneles Secos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J19,100,0,false,false )
             ,new CursorDef("P000J20", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_Ca], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Otros Graneles Secos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J20,100,0,false,false )
             ,new CursorDef("P000J21", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'Panamax') AND ([TarifasGranelesSecosTipoGranos] = 'Carbón') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J21,100,0,false,false )
             ,new CursorDef("P000J22", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Carbón') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J22,100,0,false,false )
             ,new CursorDef("P000J23", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_Ca], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Carbón') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000J23,100,0,false,false )
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
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
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
