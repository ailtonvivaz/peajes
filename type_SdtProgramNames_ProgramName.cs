/*
               File: type_SdtProgramNames_ProgramName
        Description: ProgramNames
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:15:7.38
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
   [XmlRoot(ElementName = "ProgramNames.ProgramName" )]
   [XmlType(TypeName =  "ProgramNames.ProgramName" , Namespace = "CalcularPeajes" )]
   [Serializable]
   public class SdtProgramNames_ProgramName : GxUserType
   {
      public SdtProgramNames_ProgramName( )
      {
         initialize();
      }

      public SdtProgramNames_ProgramName( IGxContext context )
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
         SdtProgramNames_ProgramName deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "CalcularPeajes" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (SdtProgramNames_ProgramName)(xmls.Deserialize( sr)) ;
         sr.Close();
         SdtProgramNames_ProgramName obj ;
         obj = this;
         obj.gxTpr_Name = deserialized.gxTpr_Name;
         obj.gxTpr_Description = deserialized.gxTpr_Description;
         obj.gxTpr_Link = deserialized.gxTpr_Link;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "Name") )
               {
                  gxTv_SdtProgramNames_ProgramName_Name = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Description") )
               {
                  gxTv_SdtProgramNames_ProgramName_Description = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Link") )
               {
                  gxTv_SdtProgramNames_ProgramName_Link = oReader.Value;
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
            sName = "ProgramNames.ProgramName";
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
         oWriter.WriteElement("Name", StringUtil.RTrim( gxTv_SdtProgramNames_ProgramName_Name));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("Description", StringUtil.RTrim( gxTv_SdtProgramNames_ProgramName_Description));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("Link", StringUtil.RTrim( gxTv_SdtProgramNames_ProgramName_Link));
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
         AddObjectProperty("Name", gxTv_SdtProgramNames_ProgramName_Name, false);
         AddObjectProperty("Description", gxTv_SdtProgramNames_ProgramName_Description, false);
         AddObjectProperty("Link", gxTv_SdtProgramNames_ProgramName_Link, false);
         return  ;
      }

      [  SoapElement( ElementName = "Name" )]
      [  XmlElement( ElementName = "Name"   )]
      public String gxTpr_Name
      {
         get {
            return gxTv_SdtProgramNames_ProgramName_Name ;
         }

         set {
            gxTv_SdtProgramNames_ProgramName_Name = (String)(value);
         }

      }

      [  SoapElement( ElementName = "Description" )]
      [  XmlElement( ElementName = "Description"   )]
      public String gxTpr_Description
      {
         get {
            return gxTv_SdtProgramNames_ProgramName_Description ;
         }

         set {
            gxTv_SdtProgramNames_ProgramName_Description = (String)(value);
         }

      }

      [  SoapElement( ElementName = "Link" )]
      [  XmlElement( ElementName = "Link"   )]
      public String gxTpr_Link
      {
         get {
            return gxTv_SdtProgramNames_ProgramName_Link ;
         }

         set {
            gxTv_SdtProgramNames_ProgramName_Link = (String)(value);
         }

      }

      public void initialize( )
      {
         gxTv_SdtProgramNames_ProgramName_Name = "";
         gxTv_SdtProgramNames_ProgramName_Description = "";
         gxTv_SdtProgramNames_ProgramName_Link = "";
         sTagName = "";
         return  ;
      }

      protected short readOk ;
      protected short nOutParmCount ;
      protected String sTagName ;
      protected String gxTv_SdtProgramNames_ProgramName_Name ;
      protected String gxTv_SdtProgramNames_ProgramName_Description ;
      protected String gxTv_SdtProgramNames_ProgramName_Link ;
   }

   [DataContract(Name = @"ProgramNames.ProgramName", Namespace = "CalcularPeajes")]
   public class SdtProgramNames_ProgramName_RESTInterface : GxGenericCollectionItem<SdtProgramNames_ProgramName>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtProgramNames_ProgramName_RESTInterface( ) : base()
      {
      }

      public SdtProgramNames_ProgramName_RESTInterface( SdtProgramNames_ProgramName psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Name" , Order = 0 )]
      public String gxTpr_Name
      {
         get {
            return sdt.gxTpr_Name ;
         }

         set {
            sdt.gxTpr_Name = (String)(value);
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

      public SdtProgramNames_ProgramName sdt
      {
         get {
            return (SdtProgramNames_ProgramName)Sdt ;
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
            sdt = new SdtProgramNames_ProgramName() ;
         }
      }

   }

}
