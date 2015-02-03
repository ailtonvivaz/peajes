/*
               File: wscalcularlng
        Description: wscalcularlng
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:14:58.56
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
   public class awscalcularlng : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularlng");
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
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularlng.Execute");
               GXSoapXMLWriter.WriteStartElement("complexType");
               GXSoapXMLWriter.WriteStartElement("sequence");
               GXSoapXMLWriter.WriteElement("element", "");
               GXSoapXMLWriter.WriteAttribute("minOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("maxOccurs", "1");
               GXSoapXMLWriter.WriteAttribute("name", "Lngbandam3");
               GXSoapXMLWriter.WriteAttribute("type", "xsd:long");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("element");
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularlng.ExecuteResponse");
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
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularlng.ExecuteSoapIn");
               GXSoapXMLWriter.WriteElement("part", "");
               GXSoapXMLWriter.WriteAttribute("name", "parameters");
               GXSoapXMLWriter.WriteAttribute("element", "tns:wscalcularlng.Execute");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("message");
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularlng.ExecuteSoapOut");
               GXSoapXMLWriter.WriteElement("part", "");
               GXSoapXMLWriter.WriteAttribute("name", "parameters");
               GXSoapXMLWriter.WriteAttribute("element", "tns:wscalcularlng.ExecuteResponse");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("portType");
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularlngSoapPort");
               GXSoapXMLWriter.WriteStartElement("operation");
               GXSoapXMLWriter.WriteAttribute("name", "Execute");
               GXSoapXMLWriter.WriteElement("input", "");
               GXSoapXMLWriter.WriteAttribute("message", "wsdlns:"+"wscalcularlng.ExecuteSoapIn");
               GXSoapXMLWriter.WriteElement("output", "");
               GXSoapXMLWriter.WriteAttribute("message", "wsdlns:"+"wscalcularlng.ExecuteSoapOut");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteStartElement("binding");
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularlngSoapBinding");
               GXSoapXMLWriter.WriteAttribute("type", "wsdlns:"+"wscalcularlngSoapPort");
               GXSoapXMLWriter.WriteElement("soap:binding", "");
               GXSoapXMLWriter.WriteAttribute("style", "document");
               GXSoapXMLWriter.WriteAttribute("transport", "http://schemas.xmlsoap.org/soap/http");
               GXSoapXMLWriter.WriteStartElement("operation");
               GXSoapXMLWriter.WriteAttribute("name", "Execute");
               GXSoapXMLWriter.WriteElement("soap:operation", "");
               GXSoapXMLWriter.WriteAttribute("soapAction", "CalcularPeajesaction/"+"AWSCALCULARLNG.Execute");
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
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularlng");
               GXSoapXMLWriter.WriteStartElement("port");
               GXSoapXMLWriter.WriteAttribute("name", "wscalcularlngSoapPort");
               GXSoapXMLWriter.WriteAttribute("binding", "wsdlns:"+"wscalcularlngSoapBinding");
               GXSoapXMLWriter.WriteElement("soap:address", "");
               GXSoapXMLWriter.WriteAttribute("location", "http://"+context.GetServerName( )+((context.GetServerPort( )>0)&&(context.GetServerPort( )!=80)&&(context.GetServerPort( )!=443) ? ":"+StringUtil.LTrim( StringUtil.Str( (decimal)(context.GetServerPort( )), 6, 0)) : "")+context.GetScriptPath( )+"awscalcularlng.aspx");
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.WriteEndElement();
               GXSoapXMLWriter.Close();
               return  ;
            }
            else
            {
               currSoapErr = (short)(-20000);
               currSoapErrmsg = "No SOAP request found. Call " + "http://" + context.GetServerName( ) + ((context.GetServerPort( )>0)&&(context.GetServerPort( )!=80)&&(context.GetServerPort( )!=443) ? ":"+StringUtil.LTrim( StringUtil.Str( (decimal)(context.GetServerPort( )), 6, 0)) : "") + context.GetScriptPath( ) + "awscalcularlng.aspx" + "?wsdl to get the WSDL.";
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
                              if ( StringUtil.StrCmp2( GXSoapXMLReader.LocalName, "Lngbandam3") && ( GXSoapXMLReader.NodeType != 2 ) && ( StringUtil.StrCmp(GXSoapXMLReader.NamespaceURI, "CalcularPeajes") == 0 ) )
                              {
                                 AV19LNGBandaM3 = (long)(NumberUtil.Val( GXSoapXMLReader.Value, "."));
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
            GXSoapXMLWriter.WriteStartElement("wscalcularlng.ExecuteResponse");
            GXSoapXMLWriter.WriteAttribute("xmlns", "CalcularPeajes");
            if ( currSoapErr == 0 )
            {
               GXSoapXMLWriter.WriteElement("Resultado", StringUtil.RTrim( AV20Resultado));
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

      public awscalcularlng( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public awscalcularlng( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_LNGBandaM3 ,
                           out String aP1_Resultado )
      {
         this.AV19LNGBandaM3 = aP0_LNGBandaM3;
         this.AV20Resultado = "" ;
         initialize();
         executePrivate();
         aP1_Resultado=this.AV20Resultado;
      }

      public String executeUdp( long aP0_LNGBandaM3 )
      {
         this.AV19LNGBandaM3 = aP0_LNGBandaM3;
         this.AV20Resultado = "" ;
         initialize();
         executePrivate();
         aP1_Resultado=this.AV20Resultado;
         return AV20Resultado ;
      }

      public void executeSubmit( long aP0_LNGBandaM3 ,
                                 out String aP1_Resultado )
      {
         awscalcularlng objawscalcularlng;
         objawscalcularlng = new awscalcularlng();
         objawscalcularlng.AV19LNGBandaM3 = aP0_LNGBandaM3;
         objawscalcularlng.AV20Resultado = "" ;
         objawscalcularlng.context.SetSubmitInitialConfig(context);
         objawscalcularlng.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objawscalcularlng);
         aP1_Resultado=this.AV20Resultado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((awscalcularlng)stateInfo).executePrivate();
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
         AV18ResultadoLNGBandaM3 = AV19LNGBandaM3;
         AV15ValorACalcular = 0;
         /* Using cursor P000N2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A18LNGBandaM3 = P000N2_A18LNGBandaM3[0];
            A19LNGTarifaCargados = P000N2_A19LNGTarifaCargados[0];
            A17LNGID = P000N2_A17LNGID[0];
            if ( AV18ResultadoLNGBandaM3 >= A18LNGBandaM3 )
            {
               if ( A18LNGBandaM3 != 0 )
               {
                  AV15ValorACalcular = (decimal)(AV15ValorACalcular+(A18LNGBandaM3*A19LNGTarifaCargados));
                  AV18ResultadoLNGBandaM3 = (long)(AV18ResultadoLNGBandaM3-A18LNGBandaM3);
               }
               else
               {
                  AV15ValorACalcular = (decimal)(AV15ValorACalcular+(AV18ResultadoLNGBandaM3*A19LNGTarifaCargados));
                  AV18ResultadoLNGBandaM3 = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            else
            {
               AV15ValorACalcular = (decimal)(AV15ValorACalcular+(AV18ResultadoLNGBandaM3*A19LNGTarifaCargados));
               AV18ResultadoLNGBandaM3 = 0;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV13SdtResultado.gxTpr_Sdtresultadopanamax = AV15ValorACalcular;
         AV13SdtResultado.gxTpr_Sdtresultadoneopanamax = AV15ValorACalcular;
         AV18ResultadoLNGBandaM3 = AV19LNGBandaM3;
         AV15ValorACalcular = 0;
         AV18ResultadoLNGBandaM3 = AV19LNGBandaM3;
         /* Using cursor P000N3 */
         pr_default.execute(1);
         while ( (pr_default.getStatus(1) != 101) )
         {
            A18LNGBandaM3 = P000N3_A18LNGBandaM3[0];
            A20LNGTarifaLastre = P000N3_A20LNGTarifaLastre[0];
            A17LNGID = P000N3_A17LNGID[0];
            if ( AV18ResultadoLNGBandaM3 >= A18LNGBandaM3 )
            {
               if ( A18LNGBandaM3 != 0 )
               {
                  AV15ValorACalcular = (decimal)(AV15ValorACalcular+(A18LNGBandaM3*A20LNGTarifaLastre));
                  AV18ResultadoLNGBandaM3 = (long)(AV18ResultadoLNGBandaM3-A18LNGBandaM3);
               }
               else
               {
                  AV15ValorACalcular = (decimal)(AV15ValorACalcular+(AV18ResultadoLNGBandaM3*A20LNGTarifaLastre));
                  AV18ResultadoLNGBandaM3 = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            else
            {
               AV15ValorACalcular = (decimal)(AV15ValorACalcular+(AV18ResultadoLNGBandaM3*A20LNGTarifaLastre));
               AV18ResultadoLNGBandaM3 = 0;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(1);
         }
         pr_default.close(1);
         AV13SdtResultado.gxTpr_Sdtresultadolastre = AV15ValorACalcular;
         AV18ResultadoLNGBandaM3 = AV19LNGBandaM3;
         AV15ValorACalcular = 0;
         /* Using cursor P000N4 */
         pr_default.execute(2);
         while ( (pr_default.getStatus(2) != 101) )
         {
            A18LNGBandaM3 = P000N4_A18LNGBandaM3[0];
            A21LNGTarifaLastreRoundtrip = P000N4_A21LNGTarifaLastreRoundtrip[0];
            A17LNGID = P000N4_A17LNGID[0];
            if ( AV18ResultadoLNGBandaM3 >= A18LNGBandaM3 )
            {
               if ( A18LNGBandaM3 != 0 )
               {
                  AV15ValorACalcular = (decimal)(AV15ValorACalcular+(A18LNGBandaM3*A21LNGTarifaLastreRoundtrip));
                  AV18ResultadoLNGBandaM3 = (long)(AV18ResultadoLNGBandaM3-A18LNGBandaM3);
               }
               else
               {
                  AV15ValorACalcular = (decimal)(AV15ValorACalcular+(AV18ResultadoLNGBandaM3*A21LNGTarifaLastreRoundtrip));
                  AV18ResultadoLNGBandaM3 = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            else
            {
               AV15ValorACalcular = (decimal)(AV15ValorACalcular+(AV18ResultadoLNGBandaM3*A21LNGTarifaLastreRoundtrip));
               AV18ResultadoLNGBandaM3 = 0;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(2);
         }
         pr_default.close(2);
         AV13SdtResultado.gxTpr_Sdtlastreroundtrip = AV15ValorACalcular;
         AV20Resultado = StringUtil.Trim( AV13SdtResultado.ToJSonString(false));
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
         P000N2_A18LNGBandaM3 = new long[1] ;
         P000N2_A19LNGTarifaCargados = new decimal[1] ;
         P000N2_A17LNGID = new short[1] ;
         AV13SdtResultado = new SdtSdtResultado(context);
         P000N3_A18LNGBandaM3 = new long[1] ;
         P000N3_A20LNGTarifaLastre = new decimal[1] ;
         P000N3_A17LNGID = new short[1] ;
         P000N4_A18LNGBandaM3 = new long[1] ;
         P000N4_A21LNGTarifaLastreRoundtrip = new decimal[1] ;
         P000N4_A17LNGID = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.awscalcularlng__default(),
            new Object[][] {
                new Object[] {
               P000N2_A18LNGBandaM3, P000N2_A19LNGTarifaCargados, P000N2_A17LNGID
               }
               , new Object[] {
               P000N3_A18LNGBandaM3, P000N3_A20LNGTarifaLastre, P000N3_A17LNGID
               }
               , new Object[] {
               P000N4_A18LNGBandaM3, P000N4_A21LNGTarifaLastreRoundtrip, P000N4_A17LNGID
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
      private short A17LNGID ;
      private long AV19LNGBandaM3 ;
      private long AV18ResultadoLNGBandaM3 ;
      private long A18LNGBandaM3 ;
      private decimal AV15ValorACalcular ;
      private decimal A19LNGTarifaCargados ;
      private decimal A20LNGTarifaLastre ;
      private decimal A21LNGTarifaLastreRoundtrip ;
      private String currSoapErrmsg ;
      private String currMethod ;
      private String sTagName ;
      private String scmdbuf ;
      private String AV20Resultado ;
      private GXXMLReader GXSoapXMLReader ;
      private GXXMLWriter GXSoapXMLWriter ;
      private GxHttpRequest GXSoapHTTPRequest ;
      private GxHttpResponse GXSoapHTTPResponse ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P000N2_A18LNGBandaM3 ;
      private decimal[] P000N2_A19LNGTarifaCargados ;
      private short[] P000N2_A17LNGID ;
      private long[] P000N3_A18LNGBandaM3 ;
      private decimal[] P000N3_A20LNGTarifaLastre ;
      private short[] P000N3_A17LNGID ;
      private long[] P000N4_A18LNGBandaM3 ;
      private decimal[] P000N4_A21LNGTarifaLastreRoundtrip ;
      private short[] P000N4_A17LNGID ;
      private String aP1_Resultado ;
      private SdtSdtResultado AV13SdtResultado ;
   }

   public class awscalcularlng__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000N2 ;
          prmP000N2 = new Object[] {
          } ;
          Object[] prmP000N3 ;
          prmP000N3 = new Object[] {
          } ;
          Object[] prmP000N4 ;
          prmP000N4 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P000N2", "SELECT [LNGBandaM3], [LNGTarifaCargados], [LNGID] FROM [LNG] WITH (NOLOCK) ORDER BY [LNGID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000N2,100,0,false,false )
             ,new CursorDef("P000N3", "SELECT [LNGBandaM3], [LNGTarifaLastre], [LNGID] FROM [LNG] WITH (NOLOCK) ORDER BY [LNGID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000N3,100,0,false,false )
             ,new CursorDef("P000N4", "SELECT [LNGBandaM3], [LNGTarifaLastreRoundtrip], [LNGID] FROM [LNG] WITH (NOLOCK) ORDER BY [LNGID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000N4,100,0,false,false )
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
             case 2 :
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
