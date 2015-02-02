/*
               File: type_SdtSdtResultadoPortaContenedores
        Description: SdtResultadoPortaContenedores
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:15:7.45
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
   [XmlRoot(ElementName = "SdtResultadoPortaContenedores" )]
   [XmlType(TypeName =  "SdtResultadoPortaContenedores" , Namespace = "CalcularPeajes" )]
   [Serializable]
   public class SdtSdtResultadoPortaContenedores : GxUserType
   {
      public SdtSdtResultadoPortaContenedores( )
      {
         initialize();
      }

      public SdtSdtResultadoPortaContenedores( IGxContext context )
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
         SdtSdtResultadoPortaContenedores deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "CalcularPeajes" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (SdtSdtResultadoPortaContenedores)(xmls.Deserialize( sr)) ;
         sr.Close();
         SdtSdtResultadoPortaContenedores obj ;
         obj = this;
         obj.gxTpr_Sdtresultadopanamax = deserialized.gxTpr_Sdtresultadopanamax;
         obj.gxTpr_Sdtresultadoneopanamax = deserialized.gxTpr_Sdtresultadoneopanamax;
         obj.gxTpr_Sdtresultadopanamaxc3 = deserialized.gxTpr_Sdtresultadopanamaxc3;
         obj.gxTpr_Sdtresultadoneopanamaxc3 = deserialized.gxTpr_Sdtresultadoneopanamaxc3;
         obj.gxTpr_Sdtresultadopanamaxc2 = deserialized.gxTpr_Sdtresultadopanamaxc2;
         obj.gxTpr_Sdtresultadoneopanamaxc2 = deserialized.gxTpr_Sdtresultadoneopanamaxc2;
         obj.gxTpr_Sdtresultadopanamaxc1 = deserialized.gxTpr_Sdtresultadopanamaxc1;
         obj.gxTpr_Sdtresultadoneopanamaxc1 = deserialized.gxTpr_Sdtresultadoneopanamaxc1;
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
                  gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamax = NumberUtil.Val( oReader.Value, ".");
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "SdtResultadoNeoPanamax") )
               {
                  gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamax = NumberUtil.Val( oReader.Value, ".");
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "SdtResultadoPanamaxC3") )
               {
                  gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc3 = NumberUtil.Val( oReader.Value, ".");
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "SdtResultadoNeoPanamaxC3") )
               {
                  gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc3 = NumberUtil.Val( oReader.Value, ".");
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "SdtResultadoPanamaxC2") )
               {
                  gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc2 = NumberUtil.Val( oReader.Value, ".");
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "SdtResultadoNeoPanamaxC2") )
               {
                  gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc2 = NumberUtil.Val( oReader.Value, ".");
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "SdtResultadoPanamaxC1") )
               {
                  gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc1 = NumberUtil.Val( oReader.Value, ".");
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "SdtResultadoNeoPanamaxC1") )
               {
                  gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc1 = NumberUtil.Val( oReader.Value, ".");
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
            sName = "SdtResultadoPortaContenedores";
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
         oWriter.WriteElement("SdtResultadoPanamax", StringUtil.Trim( StringUtil.Str( gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamax, 18, 2)));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("SdtResultadoNeoPanamax", StringUtil.Trim( StringUtil.Str( gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamax, 18, 2)));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("SdtResultadoPanamaxC3", StringUtil.Trim( StringUtil.Str( gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc3, 18, 2)));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("SdtResultadoNeoPanamaxC3", StringUtil.Trim( StringUtil.Str( gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc3, 18, 2)));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("SdtResultadoPanamaxC2", StringUtil.Trim( StringUtil.Str( gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc2, 18, 2)));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("SdtResultadoNeoPanamaxC2", StringUtil.Trim( StringUtil.Str( gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc2, 18, 2)));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("SdtResultadoPanamaxC1", StringUtil.Trim( StringUtil.Str( gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc1, 18, 2)));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("SdtResultadoNeoPanamaxC1", StringUtil.Trim( StringUtil.Str( gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc1, 18, 2)));
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
         AddObjectProperty("SdtResultadoPanamax", StringUtil.LTrim( StringUtil.Str( gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamax, 18, 2)), false);
         AddObjectProperty("SdtResultadoNeoPanamax", StringUtil.LTrim( StringUtil.Str( gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamax, 18, 2)), false);
         AddObjectProperty("SdtResultadoPanamaxC3", StringUtil.LTrim( StringUtil.Str( gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc3, 18, 2)), false);
         AddObjectProperty("SdtResultadoNeoPanamaxC3", StringUtil.LTrim( StringUtil.Str( gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc3, 18, 2)), false);
         AddObjectProperty("SdtResultadoPanamaxC2", StringUtil.LTrim( StringUtil.Str( gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc2, 18, 2)), false);
         AddObjectProperty("SdtResultadoNeoPanamaxC2", StringUtil.LTrim( StringUtil.Str( gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc2, 18, 2)), false);
         AddObjectProperty("SdtResultadoPanamaxC1", StringUtil.LTrim( StringUtil.Str( gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc1, 18, 2)), false);
         AddObjectProperty("SdtResultadoNeoPanamaxC1", StringUtil.LTrim( StringUtil.Str( gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc1, 18, 2)), false);
         return  ;
      }

      [  SoapElement( ElementName = "SdtResultadoPanamax" )]
      [  XmlElement( ElementName = "SdtResultadoPanamax"   )]
      public double gxTpr_Sdtresultadopanamax_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamax) ;
         }

         set {
            gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamax = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Sdtresultadopanamax
      {
         get {
            return gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamax ;
         }

         set {
            gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamax = (decimal)(value);
         }

      }

      [  SoapElement( ElementName = "SdtResultadoNeoPanamax" )]
      [  XmlElement( ElementName = "SdtResultadoNeoPanamax"   )]
      public double gxTpr_Sdtresultadoneopanamax_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamax) ;
         }

         set {
            gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamax = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Sdtresultadoneopanamax
      {
         get {
            return gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamax ;
         }

         set {
            gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamax = (decimal)(value);
         }

      }

      [  SoapElement( ElementName = "SdtResultadoPanamaxC3" )]
      [  XmlElement( ElementName = "SdtResultadoPanamaxC3"   )]
      public double gxTpr_Sdtresultadopanamaxc3_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc3) ;
         }

         set {
            gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc3 = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Sdtresultadopanamaxc3
      {
         get {
            return gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc3 ;
         }

         set {
            gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc3 = (decimal)(value);
         }

      }

      [  SoapElement( ElementName = "SdtResultadoNeoPanamaxC3" )]
      [  XmlElement( ElementName = "SdtResultadoNeoPanamaxC3"   )]
      public double gxTpr_Sdtresultadoneopanamaxc3_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc3) ;
         }

         set {
            gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc3 = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Sdtresultadoneopanamaxc3
      {
         get {
            return gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc3 ;
         }

         set {
            gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc3 = (decimal)(value);
         }

      }

      [  SoapElement( ElementName = "SdtResultadoPanamaxC2" )]
      [  XmlElement( ElementName = "SdtResultadoPanamaxC2"   )]
      public double gxTpr_Sdtresultadopanamaxc2_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc2) ;
         }

         set {
            gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc2 = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Sdtresultadopanamaxc2
      {
         get {
            return gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc2 ;
         }

         set {
            gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc2 = (decimal)(value);
         }

      }

      [  SoapElement( ElementName = "SdtResultadoNeoPanamaxC2" )]
      [  XmlElement( ElementName = "SdtResultadoNeoPanamaxC2"   )]
      public double gxTpr_Sdtresultadoneopanamaxc2_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc2) ;
         }

         set {
            gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc2 = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Sdtresultadoneopanamaxc2
      {
         get {
            return gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc2 ;
         }

         set {
            gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc2 = (decimal)(value);
         }

      }

      [  SoapElement( ElementName = "SdtResultadoPanamaxC1" )]
      [  XmlElement( ElementName = "SdtResultadoPanamaxC1"   )]
      public double gxTpr_Sdtresultadopanamaxc1_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc1) ;
         }

         set {
            gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc1 = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Sdtresultadopanamaxc1
      {
         get {
            return gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc1 ;
         }

         set {
            gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc1 = (decimal)(value);
         }

      }

      [  SoapElement( ElementName = "SdtResultadoNeoPanamaxC1" )]
      [  XmlElement( ElementName = "SdtResultadoNeoPanamaxC1"   )]
      public double gxTpr_Sdtresultadoneopanamaxc1_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc1) ;
         }

         set {
            gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc1 = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Sdtresultadoneopanamaxc1
      {
         get {
            return gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc1 ;
         }

         set {
            gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc1 = (decimal)(value);
         }

      }

      public void initialize( )
      {
         sTagName = "";
         return  ;
      }

      protected short readOk ;
      protected short nOutParmCount ;
      protected decimal gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamax ;
      protected decimal gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamax ;
      protected decimal gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc3 ;
      protected decimal gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc3 ;
      protected decimal gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc2 ;
      protected decimal gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc2 ;
      protected decimal gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadopanamaxc1 ;
      protected decimal gxTv_SdtSdtResultadoPortaContenedores_Sdtresultadoneopanamaxc1 ;
      protected String sTagName ;
   }

   [DataContract(Name = @"SdtResultadoPortaContenedores", Namespace = "CalcularPeajes")]
   public class SdtSdtResultadoPortaContenedores_RESTInterface : GxGenericCollectionItem<SdtSdtResultadoPortaContenedores>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSdtResultadoPortaContenedores_RESTInterface( ) : base()
      {
      }

      public SdtSdtResultadoPortaContenedores_RESTInterface( SdtSdtResultadoPortaContenedores psdt ) : base(psdt)
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

      [DataMember( Name = "SdtResultadoPanamaxC3" , Order = 2 )]
      public String gxTpr_Sdtresultadopanamaxc3
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Sdtresultadopanamaxc3, 18, 2)) ;
         }

         set {
            sdt.gxTpr_Sdtresultadopanamaxc3 = NumberUtil.Val( (String)(value), ".");
         }

      }

      [DataMember( Name = "SdtResultadoNeoPanamaxC3" , Order = 3 )]
      public String gxTpr_Sdtresultadoneopanamaxc3
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Sdtresultadoneopanamaxc3, 18, 2)) ;
         }

         set {
            sdt.gxTpr_Sdtresultadoneopanamaxc3 = NumberUtil.Val( (String)(value), ".");
         }

      }

      [DataMember( Name = "SdtResultadoPanamaxC2" , Order = 4 )]
      public String gxTpr_Sdtresultadopanamaxc2
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Sdtresultadopanamaxc2, 18, 2)) ;
         }

         set {
            sdt.gxTpr_Sdtresultadopanamaxc2 = NumberUtil.Val( (String)(value), ".");
         }

      }

      [DataMember( Name = "SdtResultadoNeoPanamaxC2" , Order = 5 )]
      public String gxTpr_Sdtresultadoneopanamaxc2
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Sdtresultadoneopanamaxc2, 18, 2)) ;
         }

         set {
            sdt.gxTpr_Sdtresultadoneopanamaxc2 = NumberUtil.Val( (String)(value), ".");
         }

      }

      [DataMember( Name = "SdtResultadoPanamaxC1" , Order = 6 )]
      public String gxTpr_Sdtresultadopanamaxc1
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Sdtresultadopanamaxc1, 18, 2)) ;
         }

         set {
            sdt.gxTpr_Sdtresultadopanamaxc1 = NumberUtil.Val( (String)(value), ".");
         }

      }

      [DataMember( Name = "SdtResultadoNeoPanamaxC1" , Order = 7 )]
      public String gxTpr_Sdtresultadoneopanamaxc1
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Sdtresultadoneopanamaxc1, 18, 2)) ;
         }

         set {
            sdt.gxTpr_Sdtresultadoneopanamaxc1 = NumberUtil.Val( (String)(value), ".");
         }

      }

      public SdtSdtResultadoPortaContenedores sdt
      {
         get {
            return (SdtSdtResultadoPortaContenedores)Sdt ;
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
            sdt = new SdtSdtResultadoPortaContenedores() ;
         }
      }

   }

}
