/*
               File: type_SdtSDTGraneleros
        Description: SDTGraneleros
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:15:7.41
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
   [XmlRoot(ElementName = "SDTGraneleros" )]
   [XmlType(TypeName =  "SDTGraneleros" , Namespace = "CalcularPeajes" )]
   [Serializable]
   public class SdtSDTGraneleros : GxUserType
   {
      public SdtSDTGraneleros( )
      {
         initialize();
      }

      public SdtSDTGraneleros( IGxContext context )
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
         SdtSDTGraneleros deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "CalcularPeajes" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (SdtSDTGraneleros)(xmls.Deserialize( sr)) ;
         sr.Close();
         SdtSDTGraneleros obj ;
         obj = this;
         obj.gxTpr_Sdtgranelerosresultadopanamax = deserialized.gxTpr_Sdtgranelerosresultadopanamax;
         obj.gxTpr_Sdtgranelerosresultadoneopanamax = deserialized.gxTpr_Sdtgranelerosresultadoneopanamax;
         obj.gxTpr_Sdtgranelerosresultadolastre = deserialized.gxTpr_Sdtgranelerosresultadolastre;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "SDTGranelerosResultadoPanamax") )
               {
                  gxTv_SdtSDTGraneleros_Sdtgranelerosresultadopanamax = NumberUtil.Val( oReader.Value, ".");
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "SDTGranelerosResultadoNeoPanamax") )
               {
                  gxTv_SdtSDTGraneleros_Sdtgranelerosresultadoneopanamax = NumberUtil.Val( oReader.Value, ".");
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "SDTGranelerosResultadoLastre") )
               {
                  gxTv_SdtSDTGraneleros_Sdtgranelerosresultadolastre = NumberUtil.Val( oReader.Value, ".");
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
            sName = "SDTGraneleros";
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sNameSpace)) )
         {
            sNameSpace = "CalcularPeajes";
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
         oWriter.WriteElement("SDTGranelerosResultadoPanamax", StringUtil.Trim( StringUtil.Str( gxTv_SdtSDTGraneleros_Sdtgranelerosresultadopanamax, 12, 2)));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("SDTGranelerosResultadoNeoPanamax", StringUtil.Trim( StringUtil.Str( gxTv_SdtSDTGraneleros_Sdtgranelerosresultadoneopanamax, 12, 2)));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("SDTGranelerosResultadoLastre", StringUtil.Trim( StringUtil.Str( gxTv_SdtSDTGraneleros_Sdtgranelerosresultadolastre, 12, 2)));
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
         AddObjectProperty("SDTGranelerosResultadoPanamax", gxTv_SdtSDTGraneleros_Sdtgranelerosresultadopanamax, false);
         AddObjectProperty("SDTGranelerosResultadoNeoPanamax", gxTv_SdtSDTGraneleros_Sdtgranelerosresultadoneopanamax, false);
         AddObjectProperty("SDTGranelerosResultadoLastre", gxTv_SdtSDTGraneleros_Sdtgranelerosresultadolastre, false);
         return  ;
      }

      [  SoapElement( ElementName = "SDTGranelerosResultadoPanamax" )]
      [  XmlElement( ElementName = "SDTGranelerosResultadoPanamax"   )]
      public double gxTpr_Sdtgranelerosresultadopanamax_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtSDTGraneleros_Sdtgranelerosresultadopanamax) ;
         }

         set {
            gxTv_SdtSDTGraneleros_Sdtgranelerosresultadopanamax = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Sdtgranelerosresultadopanamax
      {
         get {
            return gxTv_SdtSDTGraneleros_Sdtgranelerosresultadopanamax ;
         }

         set {
            gxTv_SdtSDTGraneleros_Sdtgranelerosresultadopanamax = (decimal)(value);
         }

      }

      [  SoapElement( ElementName = "SDTGranelerosResultadoNeoPanamax" )]
      [  XmlElement( ElementName = "SDTGranelerosResultadoNeoPanamax"   )]
      public double gxTpr_Sdtgranelerosresultadoneopanamax_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtSDTGraneleros_Sdtgranelerosresultadoneopanamax) ;
         }

         set {
            gxTv_SdtSDTGraneleros_Sdtgranelerosresultadoneopanamax = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Sdtgranelerosresultadoneopanamax
      {
         get {
            return gxTv_SdtSDTGraneleros_Sdtgranelerosresultadoneopanamax ;
         }

         set {
            gxTv_SdtSDTGraneleros_Sdtgranelerosresultadoneopanamax = (decimal)(value);
         }

      }

      [  SoapElement( ElementName = "SDTGranelerosResultadoLastre" )]
      [  XmlElement( ElementName = "SDTGranelerosResultadoLastre"   )]
      public double gxTpr_Sdtgranelerosresultadolastre_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtSDTGraneleros_Sdtgranelerosresultadolastre) ;
         }

         set {
            gxTv_SdtSDTGraneleros_Sdtgranelerosresultadolastre = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Sdtgranelerosresultadolastre
      {
         get {
            return gxTv_SdtSDTGraneleros_Sdtgranelerosresultadolastre ;
         }

         set {
            gxTv_SdtSDTGraneleros_Sdtgranelerosresultadolastre = (decimal)(value);
         }

      }

      public void initialize( )
      {
         sTagName = "";
         return  ;
      }

      protected short readOk ;
      protected short nOutParmCount ;
      protected decimal gxTv_SdtSDTGraneleros_Sdtgranelerosresultadopanamax ;
      protected decimal gxTv_SdtSDTGraneleros_Sdtgranelerosresultadoneopanamax ;
      protected decimal gxTv_SdtSDTGraneleros_Sdtgranelerosresultadolastre ;
      protected String sTagName ;
   }

   [DataContract(Name = @"SDTGraneleros", Namespace = "CalcularPeajes")]
   public class SdtSDTGraneleros_RESTInterface : GxGenericCollectionItem<SdtSDTGraneleros>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSDTGraneleros_RESTInterface( ) : base()
      {
      }

      public SdtSDTGraneleros_RESTInterface( SdtSDTGraneleros psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "SDTGranelerosResultadoPanamax" , Order = 0 )]
      public String gxTpr_Sdtgranelerosresultadopanamax
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Sdtgranelerosresultadopanamax, 12, 2)) ;
         }

         set {
            sdt.gxTpr_Sdtgranelerosresultadopanamax = NumberUtil.Val( (String)(value), ".");
         }

      }

      [DataMember( Name = "SDTGranelerosResultadoNeoPanamax" , Order = 1 )]
      public String gxTpr_Sdtgranelerosresultadoneopanamax
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Sdtgranelerosresultadoneopanamax, 12, 2)) ;
         }

         set {
            sdt.gxTpr_Sdtgranelerosresultadoneopanamax = NumberUtil.Val( (String)(value), ".");
         }

      }

      [DataMember( Name = "SDTGranelerosResultadoLastre" , Order = 2 )]
      public String gxTpr_Sdtgranelerosresultadolastre
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Sdtgranelerosresultadolastre, 12, 2)) ;
         }

         set {
            sdt.gxTpr_Sdtgranelerosresultadolastre = NumberUtil.Val( (String)(value), ".");
         }

      }

      public SdtSDTGraneleros sdt
      {
         get {
            return (SdtSDTGraneleros)Sdt ;
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
            sdt = new SdtSDTGraneleros() ;
         }
      }

   }

}
