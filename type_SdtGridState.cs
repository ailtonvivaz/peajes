/*
               File: type_SdtGridState
        Description: GridState
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:15:7.32
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
   [XmlRoot(ElementName = "GridState" )]
   [XmlType(TypeName =  "GridState" , Namespace = "CalcularPeajes" )]
   [System.Xml.Serialization.XmlInclude( typeof( SdtGridState_FilterValue ))]
   [Serializable]
   public class SdtGridState : GxUserType
   {
      public SdtGridState( )
      {
         initialize();
      }

      public SdtGridState( IGxContext context )
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
         SdtGridState deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "CalcularPeajes" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (SdtGridState)(xmls.Deserialize( sr)) ;
         sr.Close();
         SdtGridState obj ;
         obj = this;
         obj.gxTpr_Currentpage = deserialized.gxTpr_Currentpage;
         obj.gxTpr_Orderedby = deserialized.gxTpr_Orderedby;
         obj.gxTpr_Hidingsearch = deserialized.gxTpr_Hidingsearch;
         obj.gxTpr_Filtervalues = deserialized.gxTpr_Filtervalues;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "CurrentPage") )
               {
                  gxTv_SdtGridState_Currentpage = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "OrderedBy") )
               {
                  gxTv_SdtGridState_Orderedby = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "HidingSearch") )
               {
                  gxTv_SdtGridState_Hidingsearch = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "FilterValues") )
               {
                  if ( gxTv_SdtGridState_Filtervalues == null )
                  {
                     gxTv_SdtGridState_Filtervalues = new GxObjectCollection( context, "GridState.FilterValue", "CalcularPeajes", "SdtGridState_FilterValue", "GeneXus.Programs");
                  }
                  if ( oReader.IsSimple == 0 )
                  {
                     GXSoapError = gxTv_SdtGridState_Filtervalues.readxmlcollection(oReader, "FilterValues", "FilterValue");
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
            sName = "GridState";
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
         oWriter.WriteElement("CurrentPage", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtGridState_Currentpage), 4, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("OrderedBy", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtGridState_Orderedby), 4, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("HidingSearch", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtGridState_Hidingsearch), 1, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         if ( gxTv_SdtGridState_Filtervalues != null )
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
            gxTv_SdtGridState_Filtervalues.writexmlcollection(oWriter, "FilterValues", sNameSpace1, "FilterValue", sNameSpace1);
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
         AddObjectProperty("CurrentPage", gxTv_SdtGridState_Currentpage, false);
         AddObjectProperty("OrderedBy", gxTv_SdtGridState_Orderedby, false);
         AddObjectProperty("HidingSearch", gxTv_SdtGridState_Hidingsearch, false);
         if ( gxTv_SdtGridState_Filtervalues != null )
         {
            AddObjectProperty("FilterValues", gxTv_SdtGridState_Filtervalues, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "CurrentPage" )]
      [  XmlElement( ElementName = "CurrentPage"   )]
      public short gxTpr_Currentpage
      {
         get {
            return gxTv_SdtGridState_Currentpage ;
         }

         set {
            gxTv_SdtGridState_Currentpage = (short)(value);
         }

      }

      [  SoapElement( ElementName = "OrderedBy" )]
      [  XmlElement( ElementName = "OrderedBy"   )]
      public short gxTpr_Orderedby
      {
         get {
            return gxTv_SdtGridState_Orderedby ;
         }

         set {
            gxTv_SdtGridState_Orderedby = (short)(value);
         }

      }

      [  SoapElement( ElementName = "HidingSearch" )]
      [  XmlElement( ElementName = "HidingSearch"   )]
      public short gxTpr_Hidingsearch
      {
         get {
            return gxTv_SdtGridState_Hidingsearch ;
         }

         set {
            gxTv_SdtGridState_Hidingsearch = (short)(value);
         }

      }

      public class gxTv_SdtGridState_Filtervalues_SdtGridState_FilterValue_80compatibility:SdtGridState_FilterValue {}
      [  SoapElement( ElementName = "FilterValues" )]
      [  XmlArray( ElementName = "FilterValues"  )]
      [  XmlArrayItemAttribute( Type= typeof( SdtGridState_FilterValue ), ElementName= "FilterValue"  , IsNullable=false)]
      [  XmlArrayItemAttribute( Type= typeof( gxTv_SdtGridState_Filtervalues_SdtGridState_FilterValue_80compatibility ), ElementName= "GridState.FilterValue"  , IsNullable=false)]
      public GxObjectCollection gxTpr_Filtervalues_GxObjectCollection
      {
         get {
            if ( gxTv_SdtGridState_Filtervalues == null )
            {
               gxTv_SdtGridState_Filtervalues = new GxObjectCollection( context, "GridState.FilterValue", "CalcularPeajes", "SdtGridState_FilterValue", "GeneXus.Programs");
            }
            return (GxObjectCollection)gxTv_SdtGridState_Filtervalues ;
         }

         set {
            if ( gxTv_SdtGridState_Filtervalues == null )
            {
               gxTv_SdtGridState_Filtervalues = new GxObjectCollection( context, "GridState.FilterValue", "CalcularPeajes", "SdtGridState_FilterValue", "GeneXus.Programs");
            }
            gxTv_SdtGridState_Filtervalues = (GxObjectCollection) value;
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public IGxCollection gxTpr_Filtervalues
      {
         get {
            if ( gxTv_SdtGridState_Filtervalues == null )
            {
               gxTv_SdtGridState_Filtervalues = new GxObjectCollection( context, "GridState.FilterValue", "CalcularPeajes", "SdtGridState_FilterValue", "GeneXus.Programs");
            }
            return gxTv_SdtGridState_Filtervalues ;
         }

         set {
            gxTv_SdtGridState_Filtervalues = value;
         }

      }

      public void gxTv_SdtGridState_Filtervalues_SetNull( )
      {
         gxTv_SdtGridState_Filtervalues = null;
         return  ;
      }

      public bool gxTv_SdtGridState_Filtervalues_IsNull( )
      {
         if ( gxTv_SdtGridState_Filtervalues == null )
         {
            return true ;
         }
         return false ;
      }

      public void initialize( )
      {
         sTagName = "";
         return  ;
      }

      protected short gxTv_SdtGridState_Currentpage ;
      protected short gxTv_SdtGridState_Orderedby ;
      protected short gxTv_SdtGridState_Hidingsearch ;
      protected short readOk ;
      protected short nOutParmCount ;
      protected String sTagName ;
      [ObjectCollection(ItemType=typeof( SdtGridState_FilterValue ))]
      protected IGxCollection gxTv_SdtGridState_Filtervalues=null ;
   }

   [DataContract(Name = @"GridState", Namespace = "CalcularPeajes")]
   public class SdtGridState_RESTInterface : GxGenericCollectionItem<SdtGridState>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtGridState_RESTInterface( ) : base()
      {
      }

      public SdtGridState_RESTInterface( SdtGridState psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "CurrentPage" , Order = 0 )]
      public Nullable<short> gxTpr_Currentpage
      {
         get {
            return sdt.gxTpr_Currentpage ;
         }

         set {
            sdt.gxTpr_Currentpage = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "OrderedBy" , Order = 1 )]
      public Nullable<short> gxTpr_Orderedby
      {
         get {
            return sdt.gxTpr_Orderedby ;
         }

         set {
            sdt.gxTpr_Orderedby = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "HidingSearch" , Order = 2 )]
      public Nullable<short> gxTpr_Hidingsearch
      {
         get {
            return sdt.gxTpr_Hidingsearch ;
         }

         set {
            sdt.gxTpr_Hidingsearch = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "FilterValues" , Order = 3 )]
      public GxGenericCollection<SdtGridState_FilterValue_RESTInterface> gxTpr_Filtervalues
      {
         get {
            return new GxGenericCollection<SdtGridState_FilterValue_RESTInterface>(sdt.gxTpr_Filtervalues) ;
         }

         set {
            value.LoadCollection(sdt.gxTpr_Filtervalues);
         }

      }

      public SdtGridState sdt
      {
         get {
            return (SdtGridState)Sdt ;
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
            sdt = new SdtGridState() ;
         }
      }

   }

}
