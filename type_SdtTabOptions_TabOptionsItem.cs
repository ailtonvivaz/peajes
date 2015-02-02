/*
               File: type_SdtTabOptions_TabOptionsItem
        Description: TabOptions
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:15:7.50
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
   [XmlRoot(ElementName = "TabOptions.TabOptionsItem" )]
   [XmlType(TypeName =  "TabOptions.TabOptionsItem" , Namespace = "CalcularPeajes" )]
   [Serializable]
   public class SdtTabOptions_TabOptionsItem : GxUserType
   {
      public SdtTabOptions_TabOptionsItem( )
      {
         initialize();
      }

      public SdtTabOptions_TabOptionsItem( IGxContext context )
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
         SdtTabOptions_TabOptionsItem deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "CalcularPeajes" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (SdtTabOptions_TabOptionsItem)(xmls.Deserialize( sr)) ;
         sr.Close();
         SdtTabOptions_TabOptionsItem obj ;
         obj = this;
         obj.gxTpr_Code = deserialized.gxTpr_Code;
         obj.gxTpr_Description = deserialized.gxTpr_Description;
         obj.gxTpr_Link = deserialized.gxTpr_Link;
         obj.gxTpr_Webcomponent = deserialized.gxTpr_Webcomponent;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "Code") )
               {
                  gxTv_SdtTabOptions_TabOptionsItem_Code = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Description") )
               {
                  gxTv_SdtTabOptions_TabOptionsItem_Description = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Link") )
               {
                  gxTv_SdtTabOptions_TabOptionsItem_Link = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "WebComponent") )
               {
                  gxTv_SdtTabOptions_TabOptionsItem_Webcomponent = oReader.Value;
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
            sName = "TabOptions.TabOptionsItem";
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
         oWriter.WriteElement("Code", StringUtil.RTrim( gxTv_SdtTabOptions_TabOptionsItem_Code));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("Description", StringUtil.RTrim( gxTv_SdtTabOptions_TabOptionsItem_Description));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("Link", StringUtil.RTrim( gxTv_SdtTabOptions_TabOptionsItem_Link));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("WebComponent", StringUtil.RTrim( gxTv_SdtTabOptions_TabOptionsItem_Webcomponent));
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
         AddObjectProperty("Code", gxTv_SdtTabOptions_TabOptionsItem_Code, false);
         AddObjectProperty("Description", gxTv_SdtTabOptions_TabOptionsItem_Description, false);
         AddObjectProperty("Link", gxTv_SdtTabOptions_TabOptionsItem_Link, false);
         AddObjectProperty("WebComponent", gxTv_SdtTabOptions_TabOptionsItem_Webcomponent, false);
         return  ;
      }

      [  SoapElement( ElementName = "Code" )]
      [  XmlElement( ElementName = "Code"   )]
      public String gxTpr_Code
      {
         get {
            return gxTv_SdtTabOptions_TabOptionsItem_Code ;
         }

         set {
            gxTv_SdtTabOptions_TabOptionsItem_Code = (String)(value);
         }

      }

      [  SoapElement( ElementName = "Description" )]
      [  XmlElement( ElementName = "Description"   )]
      public String gxTpr_Description
      {
         get {
            return gxTv_SdtTabOptions_TabOptionsItem_Description ;
         }

         set {
            gxTv_SdtTabOptions_TabOptionsItem_Description = (String)(value);
         }

      }

      [  SoapElement( ElementName = "Link" )]
      [  XmlElement( ElementName = "Link"   )]
      public String gxTpr_Link
      {
         get {
            return gxTv_SdtTabOptions_TabOptionsItem_Link ;
         }

         set {
            gxTv_SdtTabOptions_TabOptionsItem_Link = (String)(value);
         }

      }

      [  SoapElement( ElementName = "WebComponent" )]
      [  XmlElement( ElementName = "WebComponent"   )]
      public String gxTpr_Webcomponent
      {
         get {
            return gxTv_SdtTabOptions_TabOptionsItem_Webcomponent ;
         }

         set {
            gxTv_SdtTabOptions_TabOptionsItem_Webcomponent = (String)(value);
         }

      }

      public void initialize( )
      {
         gxTv_SdtTabOptions_TabOptionsItem_Code = "";
         gxTv_SdtTabOptions_TabOptionsItem_Description = "";
         gxTv_SdtTabOptions_TabOptionsItem_Link = "";
         gxTv_SdtTabOptions_TabOptionsItem_Webcomponent = "";
         sTagName = "";
         return  ;
      }

      protected short readOk ;
      protected short nOutParmCount ;
      protected String gxTv_SdtTabOptions_TabOptionsItem_Code ;
      protected String sTagName ;
      protected String gxTv_SdtTabOptions_TabOptionsItem_Description ;
      protected String gxTv_SdtTabOptions_TabOptionsItem_Link ;
      protected String gxTv_SdtTabOptions_TabOptionsItem_Webcomponent ;
   }

   [DataContract(Name = @"TabOptions.TabOptionsItem", Namespace = "CalcularPeajes")]
   public class SdtTabOptions_TabOptionsItem_RESTInterface : GxGenericCollectionItem<SdtTabOptions_TabOptionsItem>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtTabOptions_TabOptionsItem_RESTInterface( ) : base()
      {
      }

      public SdtTabOptions_TabOptionsItem_RESTInterface( SdtTabOptions_TabOptionsItem psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Code" , Order = 0 )]
      public String gxTpr_Code
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Code) ;
         }

         set {
            sdt.gxTpr_Code = (String)(value);
         }

      }

      [DataMember( Name = "Description" , Order = 1 )]
      public String gxTpr_Description
      {
         get {
            return sdt.gxTpr_Description ;
         }

         set {
            sdt.gxTpr_Description = (String)(value);
         }

      }

      [DataMember( Name = "Link" , Order = 2 )]
      public String gxTpr_Link
      {
         get {
            return sdt.gxTpr_Link ;
         }

         set {
            sdt.gxTpr_Link = (String)(value);
         }

      }

      [DataMember( Name = "WebComponent" , Order = 3 )]
      public String gxTpr_Webcomponent
      {
         get {
            return sdt.gxTpr_Webcomponent ;
         }

         set {
            sdt.gxTpr_Webcomponent = (String)(value);
         }

      }

      public SdtTabOptions_TabOptionsItem sdt
      {
         get {
            return (SdtTabOptions_TabOptionsItem)Sdt ;
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
            sdt = new SdtTabOptions_TabOptionsItem() ;
         }
      }

   }

}
