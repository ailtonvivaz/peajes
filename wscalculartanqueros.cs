/*
               File: wscalculartanqueros
        Description: Stub for wscalculartanqueros
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:14:58.10
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
using System.Web.Services.Protocols;
using System.Web.Services;
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
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class wscalculartanqueros : GXProcedure
   {
      public wscalculartanqueros( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public wscalculartanqueros( IGxContext context )
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
         this.AV2TanqueroBandaCPSUAB = aP0_TanqueroBandaCPSUAB;
         this.AV3TanqueroBandaTM = aP1_TanqueroBandaTM;
         this.AV4DWT = aP2_DWT;
         this.AV5Resultado = "" ;
         initialize();
         executePrivate();
         aP3_Resultado=this.AV5Resultado;
      }

      public String executeUdp( long aP0_TanqueroBandaCPSUAB ,
                                long aP1_TanqueroBandaTM ,
                                long aP2_DWT )
      {
         this.AV2TanqueroBandaCPSUAB = aP0_TanqueroBandaCPSUAB;
         this.AV3TanqueroBandaTM = aP1_TanqueroBandaTM;
         this.AV4DWT = aP2_DWT;
         this.AV5Resultado = "" ;
         initialize();
         executePrivate();
         aP3_Resultado=this.AV5Resultado;
         return AV5Resultado ;
      }

      public void executeSubmit( long aP0_TanqueroBandaCPSUAB ,
                                 long aP1_TanqueroBandaTM ,
                                 long aP2_DWT ,
                                 out String aP3_Resultado )
      {
         wscalculartanqueros objwscalculartanqueros;
         objwscalculartanqueros = new wscalculartanqueros();
         objwscalculartanqueros.AV2TanqueroBandaCPSUAB = aP0_TanqueroBandaCPSUAB;
         objwscalculartanqueros.AV3TanqueroBandaTM = aP1_TanqueroBandaTM;
         objwscalculartanqueros.AV4DWT = aP2_DWT;
         objwscalculartanqueros.AV5Resultado = "" ;
         objwscalculartanqueros.context.SetSubmitInitialConfig(context);
         objwscalculartanqueros.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objwscalculartanqueros);
         aP3_Resultado=this.AV5Resultado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((wscalculartanqueros)stateInfo).executePrivate();
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
         context.nSOAPErr = 0;
         context.sSOAPErrMsg = "";
         GXSoapHTTPClient.Host = context.GetServerName( );
         GXSoapHTTPClient.Port = context.GetServerPort( );
         GXSoapHTTPClient.BaseURL = context.GetScriptPath( );
         SoapParm.AssignLocationProperties( context, "Awscalculartanqueros", GXSoapHTTPClient);
         GXSoapHTTPClient.AddHeader("Content-type", "text/xml;charset=utf-8");
         GXSoapHTTPClient.AddHeader("SOAPAction", "CalcularPeajesaction/"+"AWSCALCULARTANQUEROS.Execute");
         GXSoapXMLWriter.OpenRequest(GXSoapHTTPClient);
         GXSoapXMLWriter.WriteStartDocument("utf-8", 0);
         GXSoapXMLWriter.WriteStartElement("SOAP-ENV:Envelope");
         GXSoapXMLWriter.WriteAttribute("xmlns:SOAP-ENV", "http://schemas.xmlsoap.org/soap/envelope/");
         GXSoapXMLWriter.WriteAttribute("xmlns:xsd", "http://www.w3.org/2001/XMLSchema");
         GXSoapXMLWriter.WriteAttribute("xmlns:SOAP-ENC", "http://schemas.xmlsoap.org/soap/encoding/");
         GXSoapXMLWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
         GXSoapXMLWriter.WriteStartElement("SOAP-ENV:Body");
         GXSoapXMLWriter.WriteStartElement("Execute");
         GXSoapXMLWriter.WriteAttribute("xmlns", "CalcularPeajes");
         GXSoapXMLWriter.WriteElement("Tanquerobandacpsuab", StringUtil.Trim( StringUtil.Str( (decimal)(AV2TanqueroBandaCPSUAB), 10, 0)));
         GXSoapXMLWriter.WriteAttribute("xmlns", "http://tempuri.org/");
         GXSoapXMLWriter.WriteElement("Tanquerobandatm", StringUtil.Trim( StringUtil.Str( (decimal)(AV3TanqueroBandaTM), 12, 0)));
         GXSoapXMLWriter.WriteAttribute("xmlns", "http://tempuri.org/");
         GXSoapXMLWriter.WriteElement("Dwt", StringUtil.Trim( StringUtil.Str( (decimal)(AV4DWT), 12, 0)));
         GXSoapXMLWriter.WriteAttribute("xmlns", "http://tempuri.org/");
         GXSoapXMLWriter.WriteEndElement();
         GXSoapXMLWriter.WriteEndElement();
         GXSoapXMLWriter.WriteEndElement();
         GXSoapXMLWriter.Close();
         GXSoapHTTPClient.Execute("POST", "awscalculartanqueros.aspx");
         if ( GXSoapHTTPClient.ErrCode != 0 )
         {
            currSoapErr = (short)(GXSoapHTTPClient.ErrCode*-1-10000);
            currSoapErrmsg = GXSoapHTTPClient.ErrDescription;
         }
         GXSoapXMLReader.OpenResponse(GXSoapHTTPClient);
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
            if ( ( GXSoapError > 0 ) && ( StringUtil.StrCmp(GXSoapXMLReader.LocalName, "Fault") == 0 ) )
            {
               soapFault = 1;
            }
         }
         sTagName = GXSoapXMLReader.Name;
         if ( GXSoapXMLReader.IsSimple == 0 )
         {
            if ( soapFault == 0 )
            {
               GXSoapError = GXSoapXMLReader.Read();
               if ( ( GXSoapError > 0 ) && ( StringUtil.StrCmp(GXSoapXMLReader.LocalName, "Fault") == 0 ) )
               {
                  soapFault = 1;
               }
            }
            if ( soapFault == 1 )
            {
               GXSoapXMLReader.Read();
               while ( ! ( ( StringUtil.StrCmp(GXSoapXMLReader.LocalName, "Fault") == 0 ) && ( GXSoapXMLReader.NodeType == 2 ) ) )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( GXSoapXMLReader.Name), "faultcode") == 0 )
                  {
                     sFaultCode = GXSoapXMLReader.Value;
                  }
                  else if ( StringUtil.StrCmp(StringUtil.Lower( GXSoapXMLReader.Name), "faultstring") == 0 )
                  {
                     sFaultString = GXSoapXMLReader.Value;
                  }
                  else if ( StringUtil.StrCmp(StringUtil.Lower( GXSoapXMLReader.Name), "detail") == 0 )
                  {
                     if ( GXSoapXMLReader.IsSimple == 0 )
                     {
                        GXSoapXMLReader.Read();
                        sDetail = GXSoapXMLReader.ReadRawXML();
                     }
                     else
                     {
                        sDetail = GXSoapXMLReader.Value;
                     }
                  }
                  GXSoapXMLReader.Read();
               }
               if ( StringUtil.StringSearch( StringUtil.Lower( sFaultCode), "client", 1) > 0 )
               {
                  currSoapErr = (short)(-20004);
                  currSoapErrmsg = currSoapErrmsg + "SOAP Fault: Error in client request." + StringUtil.NewLine( ) + "Message: " + sFaultString + StringUtil.NewLine( ) + "Detail: " + sDetail;
               }
               else if ( StringUtil.StringSearch( StringUtil.Lower( sFaultCode), "server", 1) > 0 )
               {
                  currSoapErr = (short)(-20005);
                  currSoapErrmsg = currSoapErrmsg + "SOAP Fault: Error in server execution." + StringUtil.NewLine( ) + "Message: " + sFaultString + StringUtil.NewLine( ) + "Detail: " + sDetail;
               }
               else
               {
                  currSoapErr = (short)(-20006);
                  currSoapErrmsg = currSoapErrmsg + "Unknown error: " + sFaultCode + StringUtil.NewLine( ) + "Message: " + sFaultString + StringUtil.NewLine( ) + "Detail: " + sDetail;
               }
            }
            else
            {
               nOutParmCount = 0;
               while ( ( ( StringUtil.StrCmp(GXSoapXMLReader.Name, sTagName) != 0 ) || ( GXSoapXMLReader.NodeType == 1 ) ) && ( GXSoapError > 0 ) )
               {
                  readOk = 0;
                  if ( StringUtil.StrCmp2( GXSoapXMLReader.LocalName, "Resultado") && ( GXSoapXMLReader.NodeType != 2 ) && ( StringUtil.StrCmp(GXSoapXMLReader.NamespaceURI, "http://tempuri.org/") == 0 ) )
                  {
                     AV5Resultado = GXSoapXMLReader.Value;
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
         GXSoapXMLReader.Close();
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
         if ( currSoapErr != 0 )
         {
            oLocation = SoapParm.getlocation( context, "Awscalculartanqueros");
            if ( oLocation.CancelOnError == 1 )
            {
               throw new Exception( currSoapErrmsg+"("+StringUtil.LTrim( StringUtil.NToC( (decimal)(currSoapErr), 6, 0, ".", ""))+")") ;
            }
         }
         context.nSOAPErr = currSoapErr;
         context.sSOAPErrMsg = currSoapErrmsg;
         this.cleanup();
      }

      public override void cleanup( )
      {
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
         GXSoapHTTPClient = new GxHttpClient( context);
         sReturn = "";
         GXSoapXMLReader = new GXXMLReader(context.GetPhysicalPath());
         GXSoapXMLWriter = new GXXMLWriter(context.GetPhysicalPath());
         currSoapErrmsg = "";
         sTagName = "";
         sFaultCode = "";
         sFaultString = "";
         sDetail = "";
         oLocation = new GxLocation();
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short GXSoapError ;
      private short currSoapErr ;
      private short soapFault ;
      private short readOk ;
      private short nOutParmCount ;
      private long AV2TanqueroBandaCPSUAB ;
      private long AV3TanqueroBandaTM ;
      private long AV4DWT ;
      private String sReturn ;
      private String currSoapErrmsg ;
      private String sTagName ;
      private String sFaultCode ;
      private String sFaultString ;
      private String sDetail ;
      private String AV5Resultado ;
      private GXXMLReader GXSoapXMLReader ;
      private GXXMLWriter GXSoapXMLWriter ;
      private GxHttpClient GXSoapHTTPClient ;
      private GxLocation oLocation ;
      private IGxDataStore dsDefault ;
      private String aP3_Resultado ;
   }

}
