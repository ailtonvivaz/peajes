/*
               File: type_Sdtwscalcularportavehiculosroro_services
        Description: wscalcularportavehiculosroro_services
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 7:41:53.61
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
using GeneXus.Data;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.Data.SqlTypes;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [Serializable]
   public class Sdtwscalcularportavehiculosroro_services : GxUserType
   {
      public Sdtwscalcularportavehiculosroro_services( )
      {
         initialize();
      }

      public Sdtwscalcularportavehiculosroro_services( IGxContext context )
      {
         this.context = context;
         initialize();
      }

      private static Hashtable mapper;
      public override String JsonMap( String value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (String)mapper[value]; ;
      }

      public String execute( String gxTp_VEH_RORO_TON_INI ,
                             String gxTp_VEH_RORO_UTIL_INI )
      {
         String returnexecute ;
         returnexecute = "";
         context.nSOAPErr = 0;
         context.sSOAPErrMsg = "";
         GXSoapHTTPClient.Host = "tise-wks-345508.canal.acp";
         GXSoapHTTPClient.Port = 80;
         GXSoapHTTPClient.BaseURL = "/CalcularPeajes/";
         SoapParm.AssignLocationProperties( context, "wscalcularportavehiculosroro_services", GXSoapHTTPClient);
         if ( StringUtil.StrCmp(defaultExecute, "") == 0 )
         {
            targetResourceName = (String)(SoapParm.GetResourceName(context, "wscalcularportavehiculosroro_services"));
            if ( StringUtil.StrCmp(targetResourceName, "") == 0 )
            {
               execName = "wscalcularportavehiculosroro.svc";
            }
            else
            {
               execName = targetResourceName;
            }
         }
         else
         {
            execName = defaultExecute;
         }
         GXSoapHTTPClient.AddHeader("Content-type", "text/xml;charset=utf-8");
         GXSoapHTTPClient.AddHeader("SOAPAction", "GeneXus.Programs.wscalcularportavehiculosroro_services/wscalcularportavehiculosroro_services/execute");
         GXSoapXMLWriter.OpenRequest(GXSoapHTTPClient);
         GXSoapXMLWriter.WriteStartDocument("utf-8", 0);
         GXSoapXMLWriter.WriteStartElement("SOAP-ENV:Envelope");
         GXSoapXMLWriter.WriteAttribute("xmlns:SOAP-ENV", "http://schemas.xmlsoap.org/soap/envelope/");
         GXSoapXMLWriter.WriteAttribute("xmlns:xsd", "http://www.w3.org/2001/XMLSchema");
         GXSoapXMLWriter.WriteAttribute("xmlns:SOAP-ENC", "http://schemas.xmlsoap.org/soap/encoding/");
         GXSoapXMLWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
         if ( ! ( soapHeaders == null ) )
         {
            if ( soapHeaders.Count > 0 )
            {
               soapHeaders.writexml(GXSoapXMLWriter, "SOAP-ENV:Header", "");
            }
         }
         else
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( soapHeadersRaw)) ) )
            {
               GXSoapXMLWriter.WriteStartElement("SOAP-ENV:Header");
               GXSoapXMLWriter.WriteRawText(soapHeadersRaw);
               GXSoapXMLWriter.WriteEndElement();
            }
         }
         GXSoapXMLWriter.WriteStartElement("SOAP-ENV:Body");
         GXSoapXMLWriter.WriteStartElement("execute");
         GXSoapXMLWriter.WriteAttribute("xmlns", "GeneXus.Programs.wscalcularportavehiculosroro_services");
         GXSoapXMLWriter.WriteElement("VEH_RORO_TON_INI", StringUtil.RTrim( gxTp_VEH_RORO_TON_INI));
         GXSoapXMLWriter.WriteAttribute("xmlns", "GeneXus.Programs.wscalcularportavehiculosroro_services");
         GXSoapXMLWriter.WriteElement("VEH_RORO_UTIL_INI", StringUtil.RTrim( gxTp_VEH_RORO_UTIL_INI));
         GXSoapXMLWriter.WriteAttribute("xmlns", "GeneXus.Programs.wscalcularportavehiculosroro_services");
         GXSoapXMLWriter.WriteEndElement();
         GXSoapXMLWriter.WriteEndElement();
         GXSoapXMLWriter.WriteEndElement();
         GXSoapXMLWriter.Close();
         GXSoapHTTPClient.Execute("POST", execName);
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
               soapFaultHandling( ) ;
            }
            else
            {
               nOutParmCount = 0;
               while ( ( ( StringUtil.StrCmp(GXSoapXMLReader.Name, sTagName) != 0 ) || ( GXSoapXMLReader.NodeType == 1 ) ) && ( GXSoapError > 0 ) )
               {
                  readOk = 0;
                  if ( StringUtil.StrCmp2( GXSoapXMLReader.LocalName, "SdtResultadoStr") && ( GXSoapXMLReader.NodeType != 2 ) && ( StringUtil.StrCmp(GXSoapXMLReader.NamespaceURI, "GeneXus.Programs.wscalcularportavehiculosroro_services") == 0 ) )
                  {
                     returnexecute = GXSoapXMLReader.Value;
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
            oLocation = SoapParm.getlocation( context, "wscalcularportavehiculosroro_services");
            if ( ( oLocation.CancelOnError == 0 ) || ( oLocation.CancelOnError == 1 ) )
            {
               throw new Exception( currSoapErrmsg+"("+StringUtil.LTrim( StringUtil.NToC( (decimal)(currSoapErr), 6, 0, ".", ""))+")") ;
            }
         }
         context.nSOAPErr = currSoapErr;
         context.sSOAPErrMsg = currSoapErrmsg;
         return returnexecute ;
      }

      public void soapFaultHandling( )
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
         return  ;
      }

      public String DefaultExecute
      {
         get {
            return defaultExecute ;
         }

         set {
            defaultExecute = (String)(value);
         }

      }

      public GxUnknownObjectCollection SoapHeaders
      {
         get {
            if ( soapHeaders == null )
            {
               soapHeaders = new GxUnknownObjectCollection();
            }
            return soapHeaders ;
         }

      }

      public String SoapHeadersRaw
      {
         get {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( soapHeadersRaw)) )
            {
               soapHeadersRaw = "";
            }
            return soapHeadersRaw ;
         }

         set {
            soapHeadersRaw = (String)(value);
         }

      }

      public void initialize( )
      {
         defaultExecute = "";
         GXSoapHTTPClient = new GxHttpClient( context);
         execName = "";
         targetResourceName = "";
         GXSoapXMLReader = new GXXMLReader(context.GetPhysicalPath());
         GXSoapXMLWriter = new GXXMLWriter(context.GetPhysicalPath());
         currSoapErrmsg = "";
         sTagName = "";
         oLocation = new GxLocation();
         sFaultCode = "";
         sFaultString = "";
         sDetail = "";
         return  ;
      }

      protected short GXSoapError ;
      protected short currSoapErr ;
      protected short soapFault ;
      protected short readOk ;
      protected short nOutParmCount ;
      protected String defaultExecute ;
      protected String execName ;
      protected String targetResourceName ;
      protected String currSoapErrmsg ;
      protected String soapHeadersRaw ;
      protected String sTagName ;
      protected String sFaultCode ;
      protected String sFaultString ;
      protected String sDetail ;
      protected GXXMLReader GXSoapXMLReader ;
      protected GXXMLWriter GXSoapXMLWriter ;
      protected GxHttpClient GXSoapHTTPClient ;
      protected GxLocation oLocation ;
      protected GxUnknownObjectCollection soapHeaders ;
   }

}
