/*
               File: type_SdtContext
        Description: Context
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:15:7.30
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
   [XmlRoot(ElementName = "Context" )]
   [XmlType(TypeName =  "Context" , Namespace = "CalcularPeajes" )]
   [Serializable]
   public class SdtContext : GxUserType
   {
      public SdtContext( )
      {
         initialize();
      }

      public SdtContext( IGxContext context )
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
         SdtContext deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "CalcularPeajes" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (SdtContext)(xmls.Deserialize( sr)) ;
         sr.Close();
         SdtContext obj ;
         obj = this;
         obj.gxTpr_User = deserialized.gxTpr_User;
         obj.gxTpr_Companycode = deserialized.gxTpr_Companycode;
         obj.gxTpr_Profile = deserialized.gxTpr_Profile;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "User") )
               {
                  gxTv_SdtContext_User = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "CompanyCode") )
               {
                  gxTv_SdtContext_Companycode = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Profile") )
               {
                  gxTv_SdtContext_Profile = oReader.Value;
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
            sName = "Context";
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
         oWriter.WriteElement("User", StringUtil.RTrim( gxTv_SdtContext_User));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("CompanyCode", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtContext_Companycode), 4, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("Profile", StringUtil.RTrim( gxTv_SdtContext_Profile));
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
         AddObjectProperty("User", gxTv_SdtContext_User, false);
         AddObjectProperty("CompanyCode", gxTv_SdtContext_Companycode, false);
         AddObjectProperty("Profile", gxTv_SdtContext_Profile, false);
         return  ;
      }

      [  SoapElement( ElementName = "User" )]
      [  XmlElement( ElementName = "User"   )]
      public String gxTpr_User
      {
         get {
            return gxTv_SdtContext_User ;
         }

         set {
            gxTv_SdtContext_User = (String)(value);
         }

      }

      [  SoapElement( ElementName = "CompanyCode" )]
      [  XmlElement( ElementName = "CompanyCode"   )]
      public short gxTpr_Companycode
      {
         get {
            return gxTv_SdtContext_Companycode ;
         }

         set {
            gxTv_SdtContext_Companycode = (short)(value);
         }

      }

      [  SoapElement( ElementName = "Profile" )]
      [  XmlElement( ElementName = "Profile"   )]
      public String gxTpr_Profile
      {
         get {
            return gxTv_SdtContext_Profile ;
         }

         set {
            gxTv_SdtContext_Profile = (String)(value);
         }

      }

      public void initialize( )
      {
         gxTv_SdtContext_User = "";
         gxTv_SdtContext_Profile = "";
         sTagName = "";
         return  ;
      }

      protected short gxTv_SdtContext_Companycode ;
      protected short readOk ;
      protected short nOutParmCount ;
      protected String gxTv_SdtContext_User ;
      protected String gxTv_SdtContext_Profile ;
      protected String sTagName ;
   }

   [DataContract(Name = @"Context", Namespace = "CalcularPeajes")]
   public class SdtContext_RESTInterface : GxGenericCollectionItem<SdtContext>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtContext_RESTInterface( ) : base()
      {
      }

      public SdtContext_RESTInterface( SdtContext psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "User" , Order = 0 )]
      public String gxTpr_User
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_User) ;
         }

         set {
            sdt.gxTpr_User = (String)(value);
         }

      }

      [DataMember( Name = "CompanyCode" , Order = 1 )]
      public Nullable<short> gxTpr_Companycode
      {
         get {
            return sdt.gxTpr_Companycode ;
         }

         set {
            sdt.gxTpr_Companycode = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "Profile" , Order = 2 )]
      public String gxTpr_Profile
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Profile) ;
         }

         set {
            sdt.gxTpr_Profile = (String)(value);
         }

      }

      public SdtContext sdt
      {
         get {
            return (SdtContext)Sdt ;
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
            sdt = new SdtContext() ;
         }
      }

   }

}
