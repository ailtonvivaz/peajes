/*
               File: type_SdtSdtResultado
        Description: SdtResultado
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:15:7.43
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
   [XmlRoot(ElementName = "SdtResultado" )]
   [XmlType(TypeName =  "SdtResultado" , Namespace = "CalcularPeajes" )]
   [Serializable]
   public class SdtSdtResultado : GxUserType
   {
      public SdtSdtResultado( )
      {
         initialize();
      }

      public SdtSdtResultado( IGxContext context )
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
         SdtSdtResultado deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "CalcularPeajes" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (SdtSdtResultado)(xmls.Deserialize( sr)) ;
         sr.Close();
         SdtSdtResultado obj ;
         obj = this;
         obj.gxTpr_Sdtresultadopanamax = deserialized.gxTpr_Sdtresultadopanamax;
         obj.gxTpr_Sdtresultadoneopanamax = deserialized.gxTpr_Sdtresultadoneopanamax;
         obj.gxTpr_Sdtresultadolastre = deserialized.gxTpr_Sdtresultadolastre;
         obj.gxTpr_Sdtlastreroundtrip = deserialized.gxTpr_Sdtlastreroundtrip;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "SdtResultadoPanamax") )
               {
                  gxTv_SdtSdtResultado_Sdtresultadopanamax = NumberUtil.Val( oReader.Value, ".");
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "SdtResultadoNeoPanamax") )
               {
                  gxTv_SdtSdtResultado_Sdtresultadoneopanamax = NumberUtil.Val( oReader.Value, ".");
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "SdtResultadoLastre") )
               {
                  gxTv_SdtSdtResultado_Sdtresultadolastre = NumberUtil.Val( oReader.Value, ".");
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "SdtLastreRoundtrip") )
               {
                  gxTv_SdtSdtResultado_Sdtlastreroundtrip = NumberUtil.Val( oReader.Value, ".");
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
            sName = "SdtResultado";
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
         oWriter.WriteElement("SdtResultadoPanamax", StringUtil.Trim( StringUtil.Str( gxTv_SdtSdtResultado_Sdtresultadopanamax, 18, 2)));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("SdtResultadoNeoPanamax", StringUtil.Trim( StringUtil.Str( gxTv_SdtSdtResultado_Sdtresultadoneopanamax, 18, 2)));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("SdtResultadoLastre", StringUtil.Trim( StringUtil.Str( gxTv_SdtSdtResultado_Sdtresultadolastre, 18, 2)));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("SdtLastreRoundtrip", StringUtil.Trim( StringUtil.Str( gxTv_SdtSdtResultado_Sdtlastreroundtrip, 18, 2)));
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
         AddObjectProperty("SdtResultadoPanamax", StringUtil.LTrim( StringUtil.Str( gxTv_SdtSdtResultado_Sdtresultadopanamax, 18, 2)), false);
         AddObjectProperty("SdtResultadoNeoPanamax", StringUtil.LTrim( StringUtil.Str( gxTv_SdtSdtResultado_Sdtresultadoneopanamax, 18, 2)), false);
         AddObjectProperty("SdtResultadoLastre", StringUtil.LTrim( StringUtil.Str( gxTv_SdtSdtResultado_Sdtresultadolastre, 18, 2)), false);
         AddObjectProperty("SdtLastreRoundtrip", StringUtil.LTrim( StringUtil.Str( gxTv_SdtSdtResultado_Sdtlastreroundtrip, 18, 2)), false);
         return  ;
      }

      [  SoapElement( ElementName = "SdtResultadoPanamax" )]
      [  XmlElement( ElementName = "SdtResultadoPanamax"   )]
      public double gxTpr_Sdtresultadopanamax_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtSdtResultado_Sdtresultadopanamax) ;
         }

         set {
            gxTv_SdtSdtResultado_Sdtresultadopanamax = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Sdtresultadopanamax
      {
         get {
            return gxTv_SdtSdtResultado_Sdtresultadopanamax ;
         }

         set {
            gxTv_SdtSdtResultado_Sdtresultadopanamax = (decimal)(value);
         }

      }

      [  SoapElement( ElementName = "SdtResultadoNeoPanamax" )]
      [  XmlElement( ElementName = "SdtResultadoNeoPanamax"   )]
      public double gxTpr_Sdtresultadoneopanamax_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtSdtResultado_Sdtresultadoneopanamax) ;
         }

         set {
            gxTv_SdtSdtResultado_Sdtresultadoneopanamax = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Sdtresultadoneopanamax
      {
         get {
            return gxTv_SdtSdtResultado_Sdtresultadoneopanamax ;
         }

         set {
            gxTv_SdtSdtResultado_Sdtresultadoneopanamax = (decimal)(value);
         }

      }

      [  SoapElement( ElementName = "SdtResultadoLastre" )]
      [  XmlElement( ElementName = "SdtResultadoLastre"   )]
      public double gxTpr_Sdtresultadolastre_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtSdtResultado_Sdtresultadolastre) ;
         }

         set {
            gxTv_SdtSdtResultado_Sdtresultadolastre = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Sdtresultadolastre
      {
         get {
            return gxTv_SdtSdtResultado_Sdtresultadolastre ;
         }

         set {
            gxTv_SdtSdtResultado_Sdtresultadolastre = (decimal)(value);
         }

      }

      [  SoapElement( ElementName = "SdtLastreRoundtrip" )]
      [  XmlElement( ElementName = "SdtLastreRoundtrip"   )]
      public double gxTpr_Sdtlastreroundtrip_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtSdtResultado_Sdtlastreroundtrip) ;
         }

         set {
            gxTv_SdtSdtResultado_Sdtlastreroundtrip = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Sdtlastreroundtrip
      {
         get {
            return gxTv_SdtSdtResultado_Sdtlastreroundtrip ;
         }

         set {
            gxTv_SdtSdtResultado_Sdtlastreroundtrip = (decimal)(value);
         }

      }

      public void initialize( )
      {
         sTagName = "";
         return  ;
      }

      protected short readOk ;
      protected short nOutParmCount ;
      protected decimal gxTv_SdtSdtResultado_Sdtresultadopanamax ;
      protected decimal gxTv_SdtSdtResultado_Sdtresultadoneopanamax ;
      protected decimal gxTv_SdtSdtResultado_Sdtresultadolastre ;
      protected decimal gxTv_SdtSdtResultado_Sdtlastreroundtrip ;
      protected String sTagName ;
   }

   [DataContract(Name = @"SdtResultado", Namespace = "CalcularPeajes")]
   public class SdtSdtResultado_RESTInterface : GxGenericCollectionItem<SdtSdtResultado>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSdtResultado_RESTInterface( ) : base()
      {
      }

      public SdtSdtResultado_RESTInterface( SdtSdtResultado psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "SdtResultadoPanamax" , Order = 0 )]
      public String gxTpr_Sdtresultadopanamax
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Sdtresultadopanamax, 18, 2)) ;
         }

         set {
            sdt.gxTpr_Sdtresultadopanamax = NumberUtil.Val( (String)(value), ".");
         }

      }

      [DataMember( Name = "SdtResultadoNeoPanamax" , Order = 1 )]
      public String gxTpr_Sdtresultadoneopanamax
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Sdtresultadoneopanamax, 18, 2)) ;
         }

         set {
            sdt.gxTpr_Sdtresultadoneopanamax = NumberUtil.Val( (String)(value), ".");
         }

      }

      [DataMember( Name = "SdtResultadoLastre" , Order = 2 )]
      public String gxTpr_Sdtresultadolastre
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Sdtresultadolastre, 18, 2)) ;
         }

         set {
            sdt.gxTpr_Sdtresultadolastre = NumberUtil.Val( (String)(value), ".");
         }

      }

      [DataMember( Name = "SdtLastreRoundtrip" , Order = 3 )]
      public String gxTpr_Sdtlastreroundtrip
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Sdtlastreroundtrip, 18, 2)) ;
         }

         set {
            sdt.gxTpr_Sdtlastreroundtrip = NumberUtil.Val( (String)(value), ".");
         }

      }

      public SdtSdtResultado sdt
      {
         get {
            return (SdtSdtResultado)Sdt ;
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
            sdt = new SdtSdtResultado() ;
         }
      }

   }

}
