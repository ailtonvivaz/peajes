/*
               File: type_SdtTransactionContext
        Description: TransactionContext
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 7:41:53.56
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
   [XmlRoot(ElementName = "TransactionContext" )]
   [XmlType(TypeName =  "TransactionContext" , Namespace = "CalcularPeajes" )]
   [System.Xml.Serialization.XmlInclude( typeof( SdtTransactionContext_Attribute ))]
   [Serializable]
   public class SdtTransactionContext : GxUserType
   {
      public SdtTransactionContext( )
      {
         initialize();
      }

      public SdtTransactionContext( IGxContext context )
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
         SdtTransactionContext deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "CalcularPeajes" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (SdtTransactionContext)(xmls.Deserialize( sr)) ;
         sr.Close();
         SdtTransactionContext obj ;
         obj = this;
         obj.gxTpr_Callerobject = deserialized.gxTpr_Callerobject;
         obj.gxTpr_Callerondelete = deserialized.gxTpr_Callerondelete;
         obj.gxTpr_Callerurl = deserialized.gxTpr_Callerurl;
         obj.gxTpr_Transactionname = deserialized.gxTpr_Transactionname;
         obj.gxTpr_Attributes = deserialized.gxTpr_Attributes;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "CallerObject") )
               {
                  gxTv_SdtTransactionContext_Callerobject = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "CallerOnDelete") )
               {
                  gxTv_SdtTransactionContext_Callerondelete = (bool)(Convert.ToBoolean(((StringUtil.StrCmp(oReader.Value, "true")==0)||(StringUtil.StrCmp(oReader.Value, "1")==0) ? 1 : 0)));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "CallerURL") )
               {
                  gxTv_SdtTransactionContext_Callerurl = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "TransactionName") )
               {
                  gxTv_SdtTransactionContext_Transactionname = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Attributes") )
               {
                  if ( gxTv_SdtTransactionContext_Attributes == null )
                  {
                     gxTv_SdtTransactionContext_Attributes = new GxObjectCollection( context, "TransactionContext.Attribute", "CalcularPeajes", "SdtTransactionContext_Attribute", "GeneXus.Programs");
                  }
                  if ( oReader.IsSimple == 0 )
                  {
                     GXSoapError = gxTv_SdtTransactionContext_Attributes.readxmlcollection(oReader, "Attributes", "Attribute");
                  }
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
            sName = "TransactionContext";
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
         oWriter.WriteElement("CallerObject", StringUtil.RTrim( gxTv_SdtTransactionContext_Callerobject));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("CallerOnDelete", StringUtil.RTrim( StringUtil.BoolToStr( gxTv_SdtTransactionContext_Callerondelete)));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("CallerURL", StringUtil.RTrim( gxTv_SdtTransactionContext_Callerurl));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("TransactionName", StringUtil.RTrim( gxTv_SdtTransactionContext_Transactionname));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         if ( gxTv_SdtTransactionContext_Attributes != null )
         {
            String sNameSpace1 ;
            if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") == 0 )
            {
               sNameSpace1 = "[*:nosend]" + "CalcularPeajes";
            }
            else
            {
               sNameSpace1 = "CalcularPeajes";
            }
            gxTv_SdtTransactionContext_Attributes.writexmlcollection(oWriter, "Attributes", sNameSpace1, "Attribute", sNameSpace1);
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
         AddObjectProperty("CallerObject", gxTv_SdtTransactionContext_Callerobject, false);
         AddObjectProperty("CallerOnDelete", gxTv_SdtTransactionContext_Callerondelete, false);
         AddObjectProperty("CallerURL", gxTv_SdtTransactionContext_Callerurl, false);
         AddObjectProperty("TransactionName", gxTv_SdtTransactionContext_Transactionname, false);
         if ( gxTv_SdtTransactionContext_Attributes != null )
         {
            AddObjectProperty("Attributes", gxTv_SdtTransactionContext_Attributes, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "CallerObject" )]
      [  XmlElement( ElementName = "CallerObject"   )]
      public String gxTpr_Callerobject
      {
         get {
            return gxTv_SdtTransactionContext_Callerobject ;
         }

         set {
            gxTv_SdtTransactionContext_Callerobject = (String)(value);
         }

      }

      [  SoapElement( ElementName = "CallerOnDelete" )]
      [  XmlElement( ElementName = "CallerOnDelete"   )]
      public bool gxTpr_Callerondelete
      {
         get {
            return gxTv_SdtTransactionContext_Callerondelete ;
         }

         set {
            gxTv_SdtTransactionContext_Callerondelete = value;
         }

      }

      [  SoapElement( ElementName = "CallerURL" )]
      [  XmlElement( ElementName = "CallerURL"   )]
      public String gxTpr_Callerurl
      {
         get {
            return gxTv_SdtTransactionContext_Callerurl ;
         }

         set {
            gxTv_SdtTransactionContext_Callerurl = (String)(value);
         }

      }

      [  SoapElement( ElementName = "TransactionName" )]
      [  XmlElement( ElementName = "TransactionName"   )]
      public String gxTpr_Transactionname
      {
         get {
            return gxTv_SdtTransactionContext_Transactionname ;
         }

         set {
            gxTv_SdtTransactionContext_Transactionname = (String)(value);
         }

      }

      public class gxTv_SdtTransactionContext_Attributes_SdtTransactionContext_Attribute_80compatibility:SdtTransactionContext_Attribute {}
      [  SoapElement( ElementName = "Attributes" )]
      [  XmlArray( ElementName = "Attributes"  )]
      [  XmlArrayItemAttribute( Type= typeof( SdtTransactionContext_Attribute ), ElementName= "Attribute"  , IsNullable=false)]
      [  XmlArrayItemAttribute( Type= typeof( gxTv_SdtTransactionContext_Attributes_SdtTransactionContext_Attribute_80compatibility ), ElementName= "TransactionContext.Attribute"  , IsNullable=false)]
      public GxObjectCollection gxTpr_Attributes_GxObjectCollection
      {
         get {
            if ( gxTv_SdtTransactionContext_Attributes == null )
            {
               gxTv_SdtTransactionContext_Attributes = new GxObjectCollection( context, "TransactionContext.Attribute", "CalcularPeajes", "SdtTransactionContext_Attribute", "GeneXus.Programs");
            }
            return (GxObjectCollection)gxTv_SdtTransactionContext_Attributes ;
         }

         set {
            if ( gxTv_SdtTransactionContext_Attributes == null )
            {
               gxTv_SdtTransactionContext_Attributes = new GxObjectCollection( context, "TransactionContext.Attribute", "CalcularPeajes", "SdtTransactionContext_Attribute", "GeneXus.Programs");
            }
            gxTv_SdtTransactionContext_Attributes = (GxObjectCollection) value;
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public IGxCollection gxTpr_Attributes
      {
         get {
            if ( gxTv_SdtTransactionContext_Attributes == null )
            {
               gxTv_SdtTransactionContext_Attributes = new GxObjectCollection( context, "TransactionContext.Attribute", "CalcularPeajes", "SdtTransactionContext_Attribute", "GeneXus.Programs");
            }
            return gxTv_SdtTransactionContext_Attributes ;
         }

         set {
            gxTv_SdtTransactionContext_Attributes = value;
         }

      }

      public void gxTv_SdtTransactionContext_Attributes_SetNull( )
      {
         gxTv_SdtTransactionContext_Attributes = null;
         return  ;
      }

      public bool gxTv_SdtTransactionContext_Attributes_IsNull( )
      {
         if ( gxTv_SdtTransactionContext_Attributes == null )
         {
            return true ;
         }
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtTransactionContext_Callerobject = "";
         gxTv_SdtTransactionContext_Callerurl = "";
         gxTv_SdtTransactionContext_Transactionname = "";
         sTagName = "";
         return  ;
      }

      protected short readOk ;
      protected short nOutParmCount ;
      protected String sTagName ;
      protected bool gxTv_SdtTransactionContext_Callerondelete ;
      protected String gxTv_SdtTransactionContext_Callerobject ;
      protected String gxTv_SdtTransactionContext_Callerurl ;
      protected String gxTv_SdtTransactionContext_Transactionname ;
      [ObjectCollection(ItemType=typeof( SdtTransactionContext_Attribute ))]
      protected IGxCollection gxTv_SdtTransactionContext_Attributes=null ;
   }

   [DataContract(Name = @"TransactionContext", Namespace = "CalcularPeajes")]
   public class SdtTransactionContext_RESTInterface : GxGenericCollectionItem<SdtTransactionContext>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtTransactionContext_RESTInterface( ) : base()
      {
      }

      public SdtTransactionContext_RESTInterface( SdtTransactionContext psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "CallerObject" , Order = 0 )]
      public String gxTpr_Callerobject
      {
         get {
            return sdt.gxTpr_Callerobject ;
         }

         set {
            sdt.gxTpr_Callerobject = (String)(value);
         }

      }

      [DataMember( Name = "CallerOnDelete" , Order = 1 )]
      public bool gxTpr_Callerondelete
      {
         get {
            return sdt.gxTpr_Callerondelete ;
         }

         set {
            sdt.gxTpr_Callerondelete = value;
         }

      }

      [DataMember( Name = "CallerURL" , Order = 2 )]
      public String gxTpr_Callerurl
      {
         get {
            return sdt.gxTpr_Callerurl ;
         }

         set {
            sdt.gxTpr_Callerurl = (String)(value);
         }

      }

      [DataMember( Name = "TransactionName" , Order = 3 )]
      public String gxTpr_Transactionname
      {
         get {
            return sdt.gxTpr_Transactionname ;
         }

         set {
            sdt.gxTpr_Transactionname = (String)(value);
         }

      }

      [DataMember( Name = "Attributes" , Order = 4 )]
      public GxGenericCollection<SdtTransactionContext_Attribute_RESTInterface> gxTpr_Attributes
      {
         get {
            return new GxGenericCollection<SdtTransactionContext_Attribute_RESTInterface>(sdt.gxTpr_Attributes) ;
         }

         set {
            value.LoadCollection(sdt.gxTpr_Attributes);
         }

      }

      public SdtTransactionContext sdt
      {
         get {
            return (SdtTransactionContext)Sdt ;
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
            sdt = new SdtTransactionContext() ;
         }
      }

   }

}
