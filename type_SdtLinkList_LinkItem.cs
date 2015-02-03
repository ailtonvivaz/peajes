/*
               File: type_SdtLinkList_LinkItem
        Description: LinkList
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:15:7.36
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
   [XmlRoot(ElementName = "LinkList.LinkItem" )]
   [XmlType(TypeName =  "LinkList.LinkItem" , Namespace = "CalcularPeajes" )]
   [Serializable]
   public class SdtLinkList_LinkItem : GxUserType
   {
      public SdtLinkList_LinkItem( )
      {
         initialize();
      }

      public SdtLinkList_LinkItem( IGxContext context )
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
         SdtLinkList_LinkItem deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "CalcularPeajes" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (SdtLinkList_LinkItem)(xmls.Deserialize( sr)) ;
         sr.Close();
         SdtLinkList_LinkItem obj ;
         obj = this;
         obj.gxTpr_Caption = deserialized.gxTpr_Caption;
         obj.gxTpr_Url = deserialized.gxTpr_Url;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "Caption") )
               {
                  gxTv_SdtLinkList_LinkItem_Caption = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "URL") )
               {
                  gxTv_SdtLinkList_LinkItem_Url = oReader.Value;
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
            sName = "LinkList.LinkItem";
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
         oWriter.WriteElement("Caption", StringUtil.RTrim( gxTv_SdtLinkList_LinkItem_Caption));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("URL", StringUtil.RTrim( gxTv_SdtLinkList_LinkItem_Url));
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
         AddObjectProperty("Caption", gxTv_SdtLinkList_LinkItem_Caption, false);
         AddObjectProperty("URL", gxTv_SdtLinkList_LinkItem_Url, false);
         return  ;
      }

      [  SoapElement( ElementName = "Caption" )]
      [  XmlElement( ElementName = "Caption"   )]
      public String gxTpr_Caption
      {
         get {
            return gxTv_SdtLinkList_LinkItem_Caption ;
         }

         set {
            gxTv_SdtLinkList_LinkItem_Caption = (String)(value);
         }

      }

      [  SoapElement( ElementName = "URL" )]
      [  XmlElement( ElementName = "URL"   )]
      public String gxTpr_Url
      {
         get {
            return gxTv_SdtLinkList_LinkItem_Url ;
         }

         set {
            gxTv_SdtLinkList_LinkItem_Url = (String)(value);
         }

      }

      public void initialize( )
      {
         gxTv_SdtLinkList_LinkItem_Caption = "";
         gxTv_SdtLinkList_LinkItem_Url = "";
         sTagName = "";
         return  ;
      }

      protected short readOk ;
      protected short nOutParmCount ;
      protected String sTagName ;
      protected String gxTv_SdtLinkList_LinkItem_Caption ;
      protected String gxTv_SdtLinkList_LinkItem_Url ;
   }

   [DataContract(Name = @"LinkList.LinkItem", Namespace = "CalcularPeajes")]
   public class SdtLinkList_LinkItem_RESTInterface : GxGenericCollectionItem<SdtLinkList_LinkItem>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtLinkList_LinkItem_RESTInterface( ) : base()
      {
      }

      public SdtLinkList_LinkItem_RESTInterface( SdtLinkList_LinkItem psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Caption" , Order = 0 )]
      public String gxTpr_Caption
      {
         get {
            return sdt.gxTpr_Caption ;
         }

         set {
            sdt.gxTpr_Caption = (String)(value);
         }

      }

      [DataMember( Name = "URL" , Order = 1 )]
      public String gxTpr_Url
      {
         get {
            return sdt.gxTpr_Url ;
         }

         set {
            sdt.gxTpr_Url = (String)(value);
         }

      }

      public SdtLinkList_LinkItem sdt
      {
         get {
            return (SdtLinkList_LinkItem)Sdt ;
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
            sdt = new SdtLinkList_LinkItem() ;
         }
      }

   }

}
