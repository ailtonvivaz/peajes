/*
               File: type_SdtOperTugSchedule
        Description: OperTugSchedule
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 7:41:50.60
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
   [XmlRoot(ElementName = "OperTugSchedule" )]
   [XmlType(TypeName =  "OperTugSchedule" , Namespace = "CalcularPeajes" )]
   [System.Xml.Serialization.XmlInclude( typeof( SdtOperTugSchedule_GetOperTugScheduleResult ))]
   [Serializable]
   public class SdtOperTugSchedule : GxUserType
   {
      public SdtOperTugSchedule( )
      {
         initialize();
      }

      public SdtOperTugSchedule( IGxContext context )
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
         SdtOperTugSchedule deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "CalcularPeajes" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (SdtOperTugSchedule)(xmls.Deserialize( sr)) ;
         sr.Close();
         SdtOperTugSchedule obj ;
         obj = this;
         obj.gxTpr_Getopertugscheduleresult = deserialized.gxTpr_Getopertugscheduleresult;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "GetOperTugScheduleResult") )
               {
                  if ( gxTv_SdtOperTugSchedule_Getopertugscheduleresult == null )
                  {
                     gxTv_SdtOperTugSchedule_Getopertugscheduleresult = new SdtOperTugSchedule_GetOperTugScheduleResult(context);
                  }
                  if ( ( oReader.IsSimple == 0 ) || ( oReader.AttributeCount > 0 ) )
                  {
                     GXSoapError = gxTv_SdtOperTugSchedule_Getopertugscheduleresult.readxml(oReader, "GetOperTugScheduleResult");
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
            sName = "OperTugSchedule";
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
         if ( gxTv_SdtOperTugSchedule_Getopertugscheduleresult != null )
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
            gxTv_SdtOperTugSchedule_Getopertugscheduleresult.writexml(oWriter, "GetOperTugScheduleResult", sNameSpace1);
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
         if ( gxTv_SdtOperTugSchedule_Getopertugscheduleresult != null )
         {
            AddObjectProperty("GetOperTugScheduleResult", gxTv_SdtOperTugSchedule_Getopertugscheduleresult, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "GetOperTugScheduleResult" )]
      [  XmlElement( ElementName = "GetOperTugScheduleResult"   )]
      public SdtOperTugSchedule_GetOperTugScheduleResult gxTpr_Getopertugscheduleresult
      {
         get {
            if ( gxTv_SdtOperTugSchedule_Getopertugscheduleresult == null )
            {
               gxTv_SdtOperTugSchedule_Getopertugscheduleresult = new SdtOperTugSchedule_GetOperTugScheduleResult(context);
            }
            return gxTv_SdtOperTugSchedule_Getopertugscheduleresult ;
         }

         set {
            gxTv_SdtOperTugSchedule_Getopertugscheduleresult = value;
         }

      }

      public void gxTv_SdtOperTugSchedule_Getopertugscheduleresult_SetNull( )
      {
         gxTv_SdtOperTugSchedule_Getopertugscheduleresult = null;
         return  ;
      }

      public bool gxTv_SdtOperTugSchedule_Getopertugscheduleresult_IsNull( )
      {
         if ( gxTv_SdtOperTugSchedule_Getopertugscheduleresult == null )
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

      protected short readOk ;
      protected short nOutParmCount ;
      protected String sTagName ;
      protected SdtOperTugSchedule_GetOperTugScheduleResult gxTv_SdtOperTugSchedule_Getopertugscheduleresult=null ;
   }

   [DataContract(Name = @"OperTugSchedule", Namespace = "CalcularPeajes")]
   public class SdtOperTugSchedule_RESTInterface : GxGenericCollectionItem<SdtOperTugSchedule>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtOperTugSchedule_RESTInterface( ) : base()
      {
      }

      public SdtOperTugSchedule_RESTInterface( SdtOperTugSchedule psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "GetOperTugScheduleResult" , Order = 0 )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_RESTInterface gxTpr_Getopertugscheduleresult
      {
         get {
            return new SdtOperTugSchedule_GetOperTugScheduleResult_RESTInterface(sdt.gxTpr_Getopertugscheduleresult) ;
         }

         set {
            sdt.gxTpr_Getopertugscheduleresult = value.sdt;
         }

      }

      public SdtOperTugSchedule sdt
      {
         get {
            return (SdtOperTugSchedule)Sdt ;
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
            sdt = new SdtOperTugSchedule() ;
         }
      }

   }

}
