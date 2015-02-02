/*
               File: type_SdtTransactionContext_Attribute
        Description: TransactionContext
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 7:41:53.59
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
   [XmlRoot(ElementName = "TransactionContext.Attribute" )]
   [XmlType(TypeName =  "TransactionContext.Attribute" , Namespace = "CalcularPeajes" )]
   [Serializable]
   public class SdtTransactionContext_Attribute : GxUserType
   {
      public SdtTransactionContext_Attribute( )
      {
         initialize();
      }

      public SdtTransactionContext_Attribute( IGxContext context )
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
         SdtTransactionContext_Attribute deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "CalcularPeajes" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (SdtTransactionContext_Attribute)(xmls.Deserialize( sr)) ;
         sr.Close();
         SdtTransactionContext_Attribute obj ;
         obj = this;
         obj.gxTpr_Attributename = deserialized.gxTpr_Attributename;
         obj.gxTpr_Attributevalue = deserialized.gxTpr_Attributevalue;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "AttributeName") )
               {
                  gxTv_SdtTransactionContext_Attribute_Attributename = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "AttributeValue") )
               {
                  gxTv_SdtTransactionContext_Attribute_Attributevalue = oReader.Value;
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
            sName = "TransactionContext.Attribute";
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
         oWriter.WriteElement("AttributeName", StringUtil.RTrim( gxTv_SdtTransactionContext_Attribute_Attributename));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("AttributeValue", StringUtil.RTrim( gxTv_SdtTransactionContext_Attribute_Attributevalue));
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
         AddObjectProperty("AttributeName", gxTv_SdtTransactionContext_Attribute_Attributename, false);
         AddObjectProperty("AttributeValue", gxTv_SdtTransactionContext_Attribute_Attributevalue, false);
         return  ;
      }

      [  SoapElement( ElementName = "AttributeName" )]
      [  XmlElement( ElementName = "AttributeName"   )]
      public String gxTpr_Attributename
      {
         get {
            return gxTv_SdtTransactionContext_Attribute_Attributename ;
         }

         set {
            gxTv_SdtTransactionContext_Attribute_Attributename = (String)(value);
         }

      }

      [  SoapElement( ElementName = "AttributeValue" )]
      [  XmlElement( ElementName = "AttributeValue"   )]
      public String gxTpr_Attributevalue
      {
         get {
            return gxTv_SdtTransactionContext_Attribute_Attributevalue ;
         }

         set {
            gxTv_SdtTransactionContext_Attribute_Attributevalue = (String)(value);
         }

      }

      public void initialize( )
      {
         gxTv_SdtTransactionContext_Attribute_Attributename = "";
         gxTv_SdtTransactionContext_Attribute_Attributevalue = "";
         sTagName = "";
         return  ;
      }

      protected short readOk ;
      protected short nOutParmCount ;
      protected String sTagName ;
      protected String gxTv_SdtTransactionContext_Attribute_Attributename ;
      protected String gxTv_SdtTransactionContext_Attribute_Attributevalue ;
   }

   [DataContract(Name = @"TransactionContext.Attribute", Namespace = "CalcularPeajes")]
   public class SdtTransactionContext_Attribute_RESTInterface : GxGenericCollectionItem<SdtTransactionContext_Attribute>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtTransactionContext_Attribute_RESTInterface( ) : base()
      {
      }

      public SdtTransactionContext_Attribute_RESTInterface( SdtTransactionContext_Attribute psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "AttributeName" , Order = 0 )]
      public String gxTpr_Attributename
      {
         get {
            return sdt.gxTpr_Attributename ;
         }

         set {
            sdt.gxTpr_Attributename = (String)(value);
         }

      }

      [DataMember( Name = "AttributeValue" , Order = 1 )]
      public String gxTpr_Attributevalue
      {
         get {
            return sdt.gxTpr_Attributevalue ;
         }

         set {
            sdt.gxTpr_Attributevalue = (String)(value);
         }

      }

      public SdtTransactionContext_Attribute sdt
      {
         get {
            return (SdtTransactionContext_Attribute)Sdt ;
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
            sdt = new SdtTransactionContext_Attribute() ;
         }
      }

   }

}
