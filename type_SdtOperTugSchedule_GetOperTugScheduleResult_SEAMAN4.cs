/*
               File: type_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4
        Description: OperTugSchedule
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 7:41:52.69
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
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "OperTugSchedule.GetOperTugScheduleResult.SEAMAN4" )]
   [XmlType(TypeName =  "OperTugSchedule.GetOperTugScheduleResult.SEAMAN4" , Namespace = "CalcularPeajes" )]
   [Serializable]
   public class SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4 : GxUserType
   {
      public SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4( )
      {
         initialize();
      }

      public SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4( IGxContext context )
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

      public override String ToXml( bool includeHeader ,
                                    bool includeState ,
                                    String name ,
                                    String sNameSpace )
      {
         String s ;
         XmlSerializer xmls ;
         xmls = new XmlSerializer(this.GetType(), sNameSpace);
         System.IO.MemoryStream stream = new System.IO.MemoryStream();
         System.Xml.XmlWriter xmlw = System.Xml.XmlWriter.Create(stream, new System.Xml.XmlWriterSettings() { OmitXmlDeclaration = !includeHeader});
         XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();
         xmlns.Add(String.Empty, sNameSpace);
         xmls.Serialize( xmlw, this, xmlns);
         stream.Seek(0L, System.IO.SeekOrigin.Begin);
         System.IO.StreamReader sr = new System.IO.StreamReader(stream);
         s = sr.ReadToEnd();
         stream.Close();
         return s ;
      }

      public override void FromXml( String s ,
                                    String name )
      {
         SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4 deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "CalcularPeajes" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4)(xmls.Deserialize( sr)) ;
         sr.Close();
         SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4 obj ;
         obj = this;
         obj.gxTpr_Ip = deserialized.gxTpr_Ip;
         obj.gxTpr_Lname = deserialized.gxTpr_Lname;
         obj.gxTpr_Fname = deserialized.gxTpr_Fname;
         obj.gxTpr_Name = deserialized.gxTpr_Name;
         obj.gxTpr_Temporal = deserialized.gxTpr_Temporal;
         return  ;
      }

      public override short readxml( GXXMLReader oReader ,
                                     String sName )
      {
         short GXSoapError = 1 ;
         sTagName = oReader.Name;
         if ( oReader.IsSimple == 0 )
         {
            GXSoapError = oReader.Read();
            nOutParmCount = 0;
            while ( ( ( StringUtil.StrCmp(oReader.Name, sTagName) != 0 ) || ( oReader.NodeType == 1 ) ) && ( GXSoapError > 0 ) )
            {
               readOk = 0;
               if ( StringUtil.StrCmp2( oReader.LocalName, "IP") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Ip = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "LName") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Lname = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "FName") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Fname = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "NAME") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Name = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "TEMPORAL") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Temporal = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               nOutParmCount = (short)(nOutParmCount+1);
               if ( readOk == 0 )
               {
                  context.sSOAPErrMsg = context.sSOAPErrMsg + "Error reading " + sTagName + StringUtil.NewLine( );
                  context.sSOAPErrMsg = context.sSOAPErrMsg + "Message: " + oReader.ReadRawXML();
                  GXSoapError = (short)(nOutParmCount*-1);
               }
            }
         }
         return GXSoapError ;
      }

      public override void writexml( GXXMLWriter oWriter ,
                                     String sName ,
                                     String sNameSpace )
      {
         writexml(oWriter, sName, sNameSpace, true);
         return  ;
      }

      public override void writexml( GXXMLWriter oWriter ,
                                     String sName ,
                                     String sNameSpace ,
                                     bool sIncludeState )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sName)) )
         {
            sName = "OperTugSchedule.GetOperTugScheduleResult.SEAMAN4";
         }
         oWriter.WriteStartElement(sName);
         if ( StringUtil.StrCmp(StringUtil.Left( sNameSpace, 10), "[*:nosend]") != 0 )
         {
            oWriter.WriteAttribute("xmlns", sNameSpace);
         }
         else
         {
            sNameSpace = StringUtil.Right( sNameSpace, (short)(StringUtil.Len( sNameSpace)-10));
         }
         oWriter.WriteElement("IP", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Ip));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("LName", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Lname));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("FName", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Fname));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("NAME", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Name));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("TEMPORAL", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Temporal));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("IP", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Ip, false);
         AddObjectProperty("LName", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Lname, false);
         AddObjectProperty("FName", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Fname, false);
         AddObjectProperty("NAME", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Name, false);
         AddObjectProperty("TEMPORAL", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Temporal, false);
         return  ;
      }

      [  SoapElement( ElementName = "IP" )]
      [  XmlElement( ElementName = "IP"   )]
      public String gxTpr_Ip
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Ip ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Ip = (String)(value);
         }

      }

      [  SoapElement( ElementName = "LName" )]
      [  XmlElement( ElementName = "LName"   )]
      public String gxTpr_Lname
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Lname ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Lname = (String)(value);
         }

      }

      [  SoapElement( ElementName = "FName" )]
      [  XmlElement( ElementName = "FName"   )]
      public String gxTpr_Fname
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Fname ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Fname = (String)(value);
         }

      }

      [  SoapElement( ElementName = "NAME" )]
      [  XmlElement( ElementName = "NAME"   )]
      public String gxTpr_Name
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Name ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Name = (String)(value);
         }

      }

      [  SoapElement( ElementName = "TEMPORAL" )]
      [  XmlElement( ElementName = "TEMPORAL"   )]
      public String gxTpr_Temporal
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Temporal ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Temporal = (String)(value);
         }

      }

      public void initialize( )
      {
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Ip = "";
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Lname = "";
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Fname = "";
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Name = "";
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Temporal = "";
         sTagName = "";
         return  ;
      }

      protected short readOk ;
      protected short nOutParmCount ;
      protected String sTagName ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Ip ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Lname ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Fname ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Name ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_Temporal ;
   }

   [DataContract(Name = @"OperTugSchedule.GetOperTugScheduleResult.SEAMAN4", Namespace = "CalcularPeajes")]
   public class SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_RESTInterface : GxGenericCollectionItem<SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_RESTInterface( ) : base()
      {
      }

      public SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_RESTInterface( SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4 psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "IP" , Order = 0 )]
      public String gxTpr_Ip
      {
         get {
            return sdt.gxTpr_Ip ;
         }

         set {
            sdt.gxTpr_Ip = (String)(value);
         }

      }

      [DataMember( Name = "LName" , Order = 1 )]
      public String gxTpr_Lname
      {
         get {
            return sdt.gxTpr_Lname ;
         }

         set {
            sdt.gxTpr_Lname = (String)(value);
         }

      }

      [DataMember( Name = "FName" , Order = 2 )]
      public String gxTpr_Fname
      {
         get {
            return sdt.gxTpr_Fname ;
         }

         set {
            sdt.gxTpr_Fname = (String)(value);
         }

      }

      [DataMember( Name = "NAME" , Order = 3 )]
      public String gxTpr_Name
      {
         get {
            return sdt.gxTpr_Name ;
         }

         set {
            sdt.gxTpr_Name = (String)(value);
         }

      }

      [DataMember( Name = "TEMPORAL" , Order = 4 )]
      public String gxTpr_Temporal
      {
         get {
            return sdt.gxTpr_Temporal ;
         }

         set {
            sdt.gxTpr_Temporal = (String)(value);
         }

      }

      public SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4 sdt
      {
         get {
            return (SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4)Sdt ;
         }

         set {
            Sdt = value ;
         }

      }

      [OnDeserializing]
      void checkSdt( StreamingContext ctx )
      {
         if ( sdt == null )
         {
            sdt = new SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4() ;
         }
      }

   }

}
