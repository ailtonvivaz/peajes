/*
               File: type_SdtOperTugSchedule_GetOperTugScheduleResult
        Description: OperTugSchedule
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 7:41:50.64
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
   [XmlRoot(ElementName = "OperTugSchedule.GetOperTugScheduleResult" )]
   [XmlType(TypeName =  "OperTugSchedule.GetOperTugScheduleResult" , Namespace = "CalcularPeajes" )]
   [System.Xml.Serialization.XmlInclude( typeof( SdtOperTugSchedule_GetOperTugScheduleResult_MASTER1 ))]
   [System.Xml.Serialization.XmlInclude( typeof( SdtOperTugSchedule_GetOperTugScheduleResult_MASTER2 ))]
   [System.Xml.Serialization.XmlInclude( typeof( SdtOperTugSchedule_GetOperTugScheduleResult_ENGINEER1 ))]
   [System.Xml.Serialization.XmlInclude( typeof( SdtOperTugSchedule_GetOperTugScheduleResult_ENGINEER2 ))]
   [System.Xml.Serialization.XmlInclude( typeof( SdtOperTugSchedule_GetOperTugScheduleResult_BOSUN1 ))]
   [System.Xml.Serialization.XmlInclude( typeof( SdtOperTugSchedule_GetOperTugScheduleResult_BOSUN2 ))]
   [System.Xml.Serialization.XmlInclude( typeof( SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN1 ))]
   [System.Xml.Serialization.XmlInclude( typeof( SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN2 ))]
   [System.Xml.Serialization.XmlInclude( typeof( SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN3 ))]
   [System.Xml.Serialization.XmlInclude( typeof( SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4 ))]
   [System.Xml.Serialization.XmlInclude( typeof( SdtOperTugSchedule_GetOperTugScheduleResult_OILER1 ))]
   [System.Xml.Serialization.XmlInclude( typeof( SdtOperTugSchedule_GetOperTugScheduleResult_OILER2 ))]
   [System.Xml.Serialization.XmlInclude( typeof( SdtOperTugSchedule_GetOperTugScheduleResult_MATE1 ))]
   [System.Xml.Serialization.XmlInclude( typeof( SdtOperTugSchedule_GetOperTugScheduleResult_MATE2 ))]
   [Serializable]
   public class SdtOperTugSchedule_GetOperTugScheduleResult : GxUserType
   {
      public SdtOperTugSchedule_GetOperTugScheduleResult( )
      {
         initialize();
      }

      public SdtOperTugSchedule_GetOperTugScheduleResult( IGxContext context )
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
         SdtOperTugSchedule_GetOperTugScheduleResult deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "CalcularPeajes" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (SdtOperTugSchedule_GetOperTugScheduleResult)(xmls.Deserialize( sr)) ;
         sr.Close();
         SdtOperTugSchedule_GetOperTugScheduleResult obj ;
         obj = this;
         obj.gxTpr_Status = deserialized.gxTpr_Status;
         obj.gxTpr_Ip = deserialized.gxTpr_Ip;
         obj.gxTpr_Username = deserialized.gxTpr_Username;
         obj.gxTpr_Horariosemanal = deserialized.gxTpr_Horariosemanal;
         obj.gxTpr_Distrito = deserialized.gxTpr_Distrito;
         obj.gxTpr_Version = deserialized.gxTpr_Version;
         obj.gxTpr_Nombreremolcador = deserialized.gxTpr_Nombreremolcador;
         obj.gxTpr_Identificadorturno = deserialized.gxTpr_Identificadorturno;
         obj.gxTpr_Turnosemanal = deserialized.gxTpr_Turnosemanal;
         obj.gxTpr_Horarioremolcador = deserialized.gxTpr_Horarioremolcador;
         obj.gxTpr_Tipousuario = deserialized.gxTpr_Tipousuario;
         obj.gxTpr_Master1 = deserialized.gxTpr_Master1;
         obj.gxTpr_Master2 = deserialized.gxTpr_Master2;
         obj.gxTpr_Engineer1 = deserialized.gxTpr_Engineer1;
         obj.gxTpr_Engineer2 = deserialized.gxTpr_Engineer2;
         obj.gxTpr_Bosun1 = deserialized.gxTpr_Bosun1;
         obj.gxTpr_Bosun2 = deserialized.gxTpr_Bosun2;
         obj.gxTpr_Seaman1 = deserialized.gxTpr_Seaman1;
         obj.gxTpr_Seaman2 = deserialized.gxTpr_Seaman2;
         obj.gxTpr_Seaman3 = deserialized.gxTpr_Seaman3;
         obj.gxTpr_Seaman4 = deserialized.gxTpr_Seaman4;
         obj.gxTpr_Oiler1 = deserialized.gxTpr_Oiler1;
         obj.gxTpr_Oiler2 = deserialized.gxTpr_Oiler2;
         obj.gxTpr_Mate1 = deserialized.gxTpr_Mate1;
         obj.gxTpr_Mate2 = deserialized.gxTpr_Mate2;
         obj.gxTpr_Comentario = deserialized.gxTpr_Comentario;
         obj.gxTpr_Remplazodia01 = deserialized.gxTpr_Remplazodia01;
         obj.gxTpr_Remplazodia02 = deserialized.gxTpr_Remplazodia02;
         obj.gxTpr_Remplazodia03 = deserialized.gxTpr_Remplazodia03;
         obj.gxTpr_Remplazodia04 = deserialized.gxTpr_Remplazodia04;
         obj.gxTpr_Remplazodia05 = deserialized.gxTpr_Remplazodia05;
         obj.gxTpr_Remplazodia06 = deserialized.gxTpr_Remplazodia06;
         obj.gxTpr_Remplazodia07 = deserialized.gxTpr_Remplazodia07;
         obj.gxTpr_Tughorarioscounter = deserialized.gxTpr_Tughorarioscounter;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "STATUS") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Status = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "IP") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Ip = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "USERNAME") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Username = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "HORARIOSEMANAL") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Horariosemanal = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "DISTRITO") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Distrito = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "VERSION") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Version = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "NOMBREREMOLCADOR") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Nombreremolcador = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "IDENTIFICADORTURNO") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Identificadorturno = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "TURNOSEMANAL") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Turnosemanal = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "HORARIOREMOLCADOR") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Horarioremolcador = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "TIPOUSUARIO") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Tipousuario = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "MASTER1") )
               {
                  if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master1 == null )
                  {
                     gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master1 = new SdtOperTugSchedule_GetOperTugScheduleResult_MASTER1(context);
                  }
                  if ( ( oReader.IsSimple == 0 ) || ( oReader.AttributeCount > 0 ) )
                  {
                     GXSoapError = gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master1.readxml(oReader, "MASTER1");
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "MASTER2") )
               {
                  if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master2 == null )
                  {
                     gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master2 = new SdtOperTugSchedule_GetOperTugScheduleResult_MASTER2(context);
                  }
                  if ( ( oReader.IsSimple == 0 ) || ( oReader.AttributeCount > 0 ) )
                  {
                     GXSoapError = gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master2.readxml(oReader, "MASTER2");
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "ENGINEER1") )
               {
                  if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer1 == null )
                  {
                     gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer1 = new SdtOperTugSchedule_GetOperTugScheduleResult_ENGINEER1(context);
                  }
                  if ( ( oReader.IsSimple == 0 ) || ( oReader.AttributeCount > 0 ) )
                  {
                     GXSoapError = gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer1.readxml(oReader, "ENGINEER1");
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "ENGINEER2") )
               {
                  if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer2 == null )
                  {
                     gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer2 = new SdtOperTugSchedule_GetOperTugScheduleResult_ENGINEER2(context);
                  }
                  if ( ( oReader.IsSimple == 0 ) || ( oReader.AttributeCount > 0 ) )
                  {
                     GXSoapError = gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer2.readxml(oReader, "ENGINEER2");
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "BOSUN1") )
               {
                  if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun1 == null )
                  {
                     gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun1 = new SdtOperTugSchedule_GetOperTugScheduleResult_BOSUN1(context);
                  }
                  if ( ( oReader.IsSimple == 0 ) || ( oReader.AttributeCount > 0 ) )
                  {
                     GXSoapError = gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun1.readxml(oReader, "BOSUN1");
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "BOSUN2") )
               {
                  if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun2 == null )
                  {
                     gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun2 = new SdtOperTugSchedule_GetOperTugScheduleResult_BOSUN2(context);
                  }
                  if ( ( oReader.IsSimple == 0 ) || ( oReader.AttributeCount > 0 ) )
                  {
                     GXSoapError = gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun2.readxml(oReader, "BOSUN2");
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "SEAMAN1") )
               {
                  if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman1 == null )
                  {
                     gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman1 = new SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN1(context);
                  }
                  if ( ( oReader.IsSimple == 0 ) || ( oReader.AttributeCount > 0 ) )
                  {
                     GXSoapError = gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman1.readxml(oReader, "SEAMAN1");
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "SEAMAN2") )
               {
                  if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman2 == null )
                  {
                     gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman2 = new SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN2(context);
                  }
                  if ( ( oReader.IsSimple == 0 ) || ( oReader.AttributeCount > 0 ) )
                  {
                     GXSoapError = gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman2.readxml(oReader, "SEAMAN2");
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "SEAMAN3") )
               {
                  if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman3 == null )
                  {
                     gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman3 = new SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN3(context);
                  }
                  if ( ( oReader.IsSimple == 0 ) || ( oReader.AttributeCount > 0 ) )
                  {
                     GXSoapError = gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman3.readxml(oReader, "SEAMAN3");
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "SEAMAN4") )
               {
                  if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman4 == null )
                  {
                     gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman4 = new SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4(context);
                  }
                  if ( ( oReader.IsSimple == 0 ) || ( oReader.AttributeCount > 0 ) )
                  {
                     GXSoapError = gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman4.readxml(oReader, "SEAMAN4");
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "OILER1") )
               {
                  if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler1 == null )
                  {
                     gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler1 = new SdtOperTugSchedule_GetOperTugScheduleResult_OILER1(context);
                  }
                  if ( ( oReader.IsSimple == 0 ) || ( oReader.AttributeCount > 0 ) )
                  {
                     GXSoapError = gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler1.readxml(oReader, "OILER1");
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "OILER2") )
               {
                  if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler2 == null )
                  {
                     gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler2 = new SdtOperTugSchedule_GetOperTugScheduleResult_OILER2(context);
                  }
                  if ( ( oReader.IsSimple == 0 ) || ( oReader.AttributeCount > 0 ) )
                  {
                     GXSoapError = gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler2.readxml(oReader, "OILER2");
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "MATE1") )
               {
                  if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate1 == null )
                  {
                     gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate1 = new SdtOperTugSchedule_GetOperTugScheduleResult_MATE1(context);
                  }
                  if ( ( oReader.IsSimple == 0 ) || ( oReader.AttributeCount > 0 ) )
                  {
                     GXSoapError = gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate1.readxml(oReader, "MATE1");
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "MATE2") )
               {
                  if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate2 == null )
                  {
                     gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate2 = new SdtOperTugSchedule_GetOperTugScheduleResult_MATE2(context);
                  }
                  if ( ( oReader.IsSimple == 0 ) || ( oReader.AttributeCount > 0 ) )
                  {
                     GXSoapError = gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate2.readxml(oReader, "MATE2");
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "COMENTARIO") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Comentario = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "REMPLAZODIA01") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia01 = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "REMPLAZODIA02") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia02 = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "REMPLAZODIA03") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia03 = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "REMPLAZODIA04") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia04 = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "REMPLAZODIA05") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia05 = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "REMPLAZODIA06") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia06 = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "REMPLAZODIA07") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia07 = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "TUGHORARIOSCOUNTER") )
               {
                  gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Tughorarioscounter = oReader.Value;
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
            sName = "OperTugSchedule.GetOperTugScheduleResult";
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
         oWriter.WriteElement("STATUS", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Status));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("IP", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Ip));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("USERNAME", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Username));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("HORARIOSEMANAL", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Horariosemanal));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("DISTRITO", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Distrito));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("VERSION", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Version));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("NOMBREREMOLCADOR", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Nombreremolcador));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("IDENTIFICADORTURNO", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Identificadorturno));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("TURNOSEMANAL", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Turnosemanal));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("HORARIOREMOLCADOR", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Horarioremolcador));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("TIPOUSUARIO", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Tipousuario));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master1 != null )
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
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master1.writexml(oWriter, "MASTER1", sNameSpace1);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master2 != null )
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
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master2.writexml(oWriter, "MASTER2", sNameSpace1);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer1 != null )
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
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer1.writexml(oWriter, "ENGINEER1", sNameSpace1);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer2 != null )
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
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer2.writexml(oWriter, "ENGINEER2", sNameSpace1);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun1 != null )
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
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun1.writexml(oWriter, "BOSUN1", sNameSpace1);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun2 != null )
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
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun2.writexml(oWriter, "BOSUN2", sNameSpace1);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman1 != null )
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
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman1.writexml(oWriter, "SEAMAN1", sNameSpace1);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman2 != null )
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
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman2.writexml(oWriter, "SEAMAN2", sNameSpace1);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman3 != null )
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
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman3.writexml(oWriter, "SEAMAN3", sNameSpace1);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman4 != null )
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
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman4.writexml(oWriter, "SEAMAN4", sNameSpace1);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler1 != null )
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
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler1.writexml(oWriter, "OILER1", sNameSpace1);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler2 != null )
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
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler2.writexml(oWriter, "OILER2", sNameSpace1);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate1 != null )
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
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate1.writexml(oWriter, "MATE1", sNameSpace1);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate2 != null )
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
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate2.writexml(oWriter, "MATE2", sNameSpace1);
         }
         oWriter.WriteElement("COMENTARIO", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Comentario));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("REMPLAZODIA01", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia01));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("REMPLAZODIA02", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia02));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("REMPLAZODIA03", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia03));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("REMPLAZODIA04", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia04));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("REMPLAZODIA05", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia05));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("REMPLAZODIA06", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia06));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("REMPLAZODIA07", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia07));
         if ( StringUtil.StrCmp(sNameSpace, "CalcularPeajes") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "CalcularPeajes");
         }
         oWriter.WriteElement("TUGHORARIOSCOUNTER", StringUtil.RTrim( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Tughorarioscounter));
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
         AddObjectProperty("STATUS", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Status, false);
         AddObjectProperty("IP", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Ip, false);
         AddObjectProperty("USERNAME", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Username, false);
         AddObjectProperty("HORARIOSEMANAL", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Horariosemanal, false);
         AddObjectProperty("DISTRITO", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Distrito, false);
         AddObjectProperty("VERSION", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Version, false);
         AddObjectProperty("NOMBREREMOLCADOR", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Nombreremolcador, false);
         AddObjectProperty("IDENTIFICADORTURNO", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Identificadorturno, false);
         AddObjectProperty("TURNOSEMANAL", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Turnosemanal, false);
         AddObjectProperty("HORARIOREMOLCADOR", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Horarioremolcador, false);
         AddObjectProperty("TIPOUSUARIO", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Tipousuario, false);
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master1 != null )
         {
            AddObjectProperty("MASTER1", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master1, false);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master2 != null )
         {
            AddObjectProperty("MASTER2", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master2, false);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer1 != null )
         {
            AddObjectProperty("ENGINEER1", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer1, false);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer2 != null )
         {
            AddObjectProperty("ENGINEER2", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer2, false);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun1 != null )
         {
            AddObjectProperty("BOSUN1", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun1, false);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun2 != null )
         {
            AddObjectProperty("BOSUN2", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun2, false);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman1 != null )
         {
            AddObjectProperty("SEAMAN1", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman1, false);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman2 != null )
         {
            AddObjectProperty("SEAMAN2", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman2, false);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman3 != null )
         {
            AddObjectProperty("SEAMAN3", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman3, false);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman4 != null )
         {
            AddObjectProperty("SEAMAN4", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman4, false);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler1 != null )
         {
            AddObjectProperty("OILER1", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler1, false);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler2 != null )
         {
            AddObjectProperty("OILER2", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler2, false);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate1 != null )
         {
            AddObjectProperty("MATE1", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate1, false);
         }
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate2 != null )
         {
            AddObjectProperty("MATE2", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate2, false);
         }
         AddObjectProperty("COMENTARIO", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Comentario, false);
         AddObjectProperty("REMPLAZODIA01", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia01, false);
         AddObjectProperty("REMPLAZODIA02", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia02, false);
         AddObjectProperty("REMPLAZODIA03", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia03, false);
         AddObjectProperty("REMPLAZODIA04", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia04, false);
         AddObjectProperty("REMPLAZODIA05", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia05, false);
         AddObjectProperty("REMPLAZODIA06", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia06, false);
         AddObjectProperty("REMPLAZODIA07", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia07, false);
         AddObjectProperty("TUGHORARIOSCOUNTER", gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Tughorarioscounter, false);
         return  ;
      }

      [  SoapElement( ElementName = "STATUS" )]
      [  XmlElement( ElementName = "STATUS"   )]
      public String gxTpr_Status
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Status ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Status = (String)(value);
         }

      }

      [  SoapElement( ElementName = "IP" )]
      [  XmlElement( ElementName = "IP"   )]
      public String gxTpr_Ip
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Ip ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Ip = (String)(value);
         }

      }

      [  SoapElement( ElementName = "USERNAME" )]
      [  XmlElement( ElementName = "USERNAME"   )]
      public String gxTpr_Username
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Username ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Username = (String)(value);
         }

      }

      [  SoapElement( ElementName = "HORARIOSEMANAL" )]
      [  XmlElement( ElementName = "HORARIOSEMANAL"   )]
      public String gxTpr_Horariosemanal
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Horariosemanal ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Horariosemanal = (String)(value);
         }

      }

      [  SoapElement( ElementName = "DISTRITO" )]
      [  XmlElement( ElementName = "DISTRITO"   )]
      public String gxTpr_Distrito
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Distrito ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Distrito = (String)(value);
         }

      }

      [  SoapElement( ElementName = "VERSION" )]
      [  XmlElement( ElementName = "VERSION"   )]
      public String gxTpr_Version
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Version ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Version = (String)(value);
         }

      }

      [  SoapElement( ElementName = "NOMBREREMOLCADOR" )]
      [  XmlElement( ElementName = "NOMBREREMOLCADOR"   )]
      public String gxTpr_Nombreremolcador
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Nombreremolcador ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Nombreremolcador = (String)(value);
         }

      }

      [  SoapElement( ElementName = "IDENTIFICADORTURNO" )]
      [  XmlElement( ElementName = "IDENTIFICADORTURNO"   )]
      public String gxTpr_Identificadorturno
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Identificadorturno ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Identificadorturno = (String)(value);
         }

      }

      [  SoapElement( ElementName = "TURNOSEMANAL" )]
      [  XmlElement( ElementName = "TURNOSEMANAL"   )]
      public String gxTpr_Turnosemanal
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Turnosemanal ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Turnosemanal = (String)(value);
         }

      }

      [  SoapElement( ElementName = "HORARIOREMOLCADOR" )]
      [  XmlElement( ElementName = "HORARIOREMOLCADOR"   )]
      public String gxTpr_Horarioremolcador
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Horarioremolcador ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Horarioremolcador = (String)(value);
         }

      }

      [  SoapElement( ElementName = "TIPOUSUARIO" )]
      [  XmlElement( ElementName = "TIPOUSUARIO"   )]
      public String gxTpr_Tipousuario
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Tipousuario ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Tipousuario = (String)(value);
         }

      }

      [  SoapElement( ElementName = "MASTER1" )]
      [  XmlElement( ElementName = "MASTER1"   )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_MASTER1 gxTpr_Master1
      {
         get {
            if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master1 == null )
            {
               gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master1 = new SdtOperTugSchedule_GetOperTugScheduleResult_MASTER1(context);
            }
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master1 ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master1 = value;
         }

      }

      public void gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master1_SetNull( )
      {
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master1 = null;
         return  ;
      }

      public bool gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master1_IsNull( )
      {
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master1 == null )
         {
            return true ;
         }
         return false ;
      }

      [  SoapElement( ElementName = "MASTER2" )]
      [  XmlElement( ElementName = "MASTER2"   )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_MASTER2 gxTpr_Master2
      {
         get {
            if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master2 == null )
            {
               gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master2 = new SdtOperTugSchedule_GetOperTugScheduleResult_MASTER2(context);
            }
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master2 ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master2 = value;
         }

      }

      public void gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master2_SetNull( )
      {
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master2 = null;
         return  ;
      }

      public bool gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master2_IsNull( )
      {
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master2 == null )
         {
            return true ;
         }
         return false ;
      }

      [  SoapElement( ElementName = "ENGINEER1" )]
      [  XmlElement( ElementName = "ENGINEER1"   )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_ENGINEER1 gxTpr_Engineer1
      {
         get {
            if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer1 == null )
            {
               gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer1 = new SdtOperTugSchedule_GetOperTugScheduleResult_ENGINEER1(context);
            }
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer1 ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer1 = value;
         }

      }

      public void gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer1_SetNull( )
      {
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer1 = null;
         return  ;
      }

      public bool gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer1_IsNull( )
      {
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer1 == null )
         {
            return true ;
         }
         return false ;
      }

      [  SoapElement( ElementName = "ENGINEER2" )]
      [  XmlElement( ElementName = "ENGINEER2"   )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_ENGINEER2 gxTpr_Engineer2
      {
         get {
            if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer2 == null )
            {
               gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer2 = new SdtOperTugSchedule_GetOperTugScheduleResult_ENGINEER2(context);
            }
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer2 ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer2 = value;
         }

      }

      public void gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer2_SetNull( )
      {
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer2 = null;
         return  ;
      }

      public bool gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer2_IsNull( )
      {
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer2 == null )
         {
            return true ;
         }
         return false ;
      }

      [  SoapElement( ElementName = "BOSUN1" )]
      [  XmlElement( ElementName = "BOSUN1"   )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_BOSUN1 gxTpr_Bosun1
      {
         get {
            if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun1 == null )
            {
               gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun1 = new SdtOperTugSchedule_GetOperTugScheduleResult_BOSUN1(context);
            }
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun1 ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun1 = value;
         }

      }

      public void gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun1_SetNull( )
      {
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun1 = null;
         return  ;
      }

      public bool gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun1_IsNull( )
      {
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun1 == null )
         {
            return true ;
         }
         return false ;
      }

      [  SoapElement( ElementName = "BOSUN2" )]
      [  XmlElement( ElementName = "BOSUN2"   )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_BOSUN2 gxTpr_Bosun2
      {
         get {
            if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun2 == null )
            {
               gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun2 = new SdtOperTugSchedule_GetOperTugScheduleResult_BOSUN2(context);
            }
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun2 ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun2 = value;
         }

      }

      public void gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun2_SetNull( )
      {
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun2 = null;
         return  ;
      }

      public bool gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun2_IsNull( )
      {
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun2 == null )
         {
            return true ;
         }
         return false ;
      }

      [  SoapElement( ElementName = "SEAMAN1" )]
      [  XmlElement( ElementName = "SEAMAN1"   )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN1 gxTpr_Seaman1
      {
         get {
            if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman1 == null )
            {
               gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman1 = new SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN1(context);
            }
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman1 ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman1 = value;
         }

      }

      public void gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman1_SetNull( )
      {
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman1 = null;
         return  ;
      }

      public bool gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman1_IsNull( )
      {
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman1 == null )
         {
            return true ;
         }
         return false ;
      }

      [  SoapElement( ElementName = "SEAMAN2" )]
      [  XmlElement( ElementName = "SEAMAN2"   )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN2 gxTpr_Seaman2
      {
         get {
            if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman2 == null )
            {
               gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman2 = new SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN2(context);
            }
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman2 ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman2 = value;
         }

      }

      public void gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman2_SetNull( )
      {
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman2 = null;
         return  ;
      }

      public bool gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman2_IsNull( )
      {
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman2 == null )
         {
            return true ;
         }
         return false ;
      }

      [  SoapElement( ElementName = "SEAMAN3" )]
      [  XmlElement( ElementName = "SEAMAN3"   )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN3 gxTpr_Seaman3
      {
         get {
            if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman3 == null )
            {
               gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman3 = new SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN3(context);
            }
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman3 ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman3 = value;
         }

      }

      public void gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman3_SetNull( )
      {
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman3 = null;
         return  ;
      }

      public bool gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman3_IsNull( )
      {
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman3 == null )
         {
            return true ;
         }
         return false ;
      }

      [  SoapElement( ElementName = "SEAMAN4" )]
      [  XmlElement( ElementName = "SEAMAN4"   )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4 gxTpr_Seaman4
      {
         get {
            if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman4 == null )
            {
               gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman4 = new SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4(context);
            }
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman4 ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman4 = value;
         }

      }

      public void gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman4_SetNull( )
      {
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman4 = null;
         return  ;
      }

      public bool gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman4_IsNull( )
      {
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman4 == null )
         {
            return true ;
         }
         return false ;
      }

      [  SoapElement( ElementName = "OILER1" )]
      [  XmlElement( ElementName = "OILER1"   )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_OILER1 gxTpr_Oiler1
      {
         get {
            if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler1 == null )
            {
               gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler1 = new SdtOperTugSchedule_GetOperTugScheduleResult_OILER1(context);
            }
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler1 ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler1 = value;
         }

      }

      public void gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler1_SetNull( )
      {
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler1 = null;
         return  ;
      }

      public bool gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler1_IsNull( )
      {
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler1 == null )
         {
            return true ;
         }
         return false ;
      }

      [  SoapElement( ElementName = "OILER2" )]
      [  XmlElement( ElementName = "OILER2"   )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_OILER2 gxTpr_Oiler2
      {
         get {
            if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler2 == null )
            {
               gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler2 = new SdtOperTugSchedule_GetOperTugScheduleResult_OILER2(context);
            }
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler2 ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler2 = value;
         }

      }

      public void gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler2_SetNull( )
      {
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler2 = null;
         return  ;
      }

      public bool gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler2_IsNull( )
      {
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler2 == null )
         {
            return true ;
         }
         return false ;
      }

      [  SoapElement( ElementName = "MATE1" )]
      [  XmlElement( ElementName = "MATE1"   )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_MATE1 gxTpr_Mate1
      {
         get {
            if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate1 == null )
            {
               gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate1 = new SdtOperTugSchedule_GetOperTugScheduleResult_MATE1(context);
            }
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate1 ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate1 = value;
         }

      }

      public void gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate1_SetNull( )
      {
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate1 = null;
         return  ;
      }

      public bool gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate1_IsNull( )
      {
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate1 == null )
         {
            return true ;
         }
         return false ;
      }

      [  SoapElement( ElementName = "MATE2" )]
      [  XmlElement( ElementName = "MATE2"   )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_MATE2 gxTpr_Mate2
      {
         get {
            if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate2 == null )
            {
               gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate2 = new SdtOperTugSchedule_GetOperTugScheduleResult_MATE2(context);
            }
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate2 ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate2 = value;
         }

      }

      public void gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate2_SetNull( )
      {
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate2 = null;
         return  ;
      }

      public bool gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate2_IsNull( )
      {
         if ( gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate2 == null )
         {
            return true ;
         }
         return false ;
      }

      [  SoapElement( ElementName = "COMENTARIO" )]
      [  XmlElement( ElementName = "COMENTARIO"   )]
      public String gxTpr_Comentario
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Comentario ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Comentario = (String)(value);
         }

      }

      [  SoapElement( ElementName = "REMPLAZODIA01" )]
      [  XmlElement( ElementName = "REMPLAZODIA01"   )]
      public String gxTpr_Remplazodia01
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia01 ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia01 = (String)(value);
         }

      }

      [  SoapElement( ElementName = "REMPLAZODIA02" )]
      [  XmlElement( ElementName = "REMPLAZODIA02"   )]
      public String gxTpr_Remplazodia02
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia02 ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia02 = (String)(value);
         }

      }

      [  SoapElement( ElementName = "REMPLAZODIA03" )]
      [  XmlElement( ElementName = "REMPLAZODIA03"   )]
      public String gxTpr_Remplazodia03
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia03 ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia03 = (String)(value);
         }

      }

      [  SoapElement( ElementName = "REMPLAZODIA04" )]
      [  XmlElement( ElementName = "REMPLAZODIA04"   )]
      public String gxTpr_Remplazodia04
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia04 ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia04 = (String)(value);
         }

      }

      [  SoapElement( ElementName = "REMPLAZODIA05" )]
      [  XmlElement( ElementName = "REMPLAZODIA05"   )]
      public String gxTpr_Remplazodia05
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia05 ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia05 = (String)(value);
         }

      }

      [  SoapElement( ElementName = "REMPLAZODIA06" )]
      [  XmlElement( ElementName = "REMPLAZODIA06"   )]
      public String gxTpr_Remplazodia06
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia06 ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia06 = (String)(value);
         }

      }

      [  SoapElement( ElementName = "REMPLAZODIA07" )]
      [  XmlElement( ElementName = "REMPLAZODIA07"   )]
      public String gxTpr_Remplazodia07
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia07 ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia07 = (String)(value);
         }

      }

      [  SoapElement( ElementName = "TUGHORARIOSCOUNTER" )]
      [  XmlElement( ElementName = "TUGHORARIOSCOUNTER"   )]
      public String gxTpr_Tughorarioscounter
      {
         get {
            return gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Tughorarioscounter ;
         }

         set {
            gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Tughorarioscounter = (String)(value);
         }

      }

      public void initialize( )
      {
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Status = "";
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Ip = "";
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Username = "";
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Horariosemanal = "";
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Distrito = "";
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Version = "";
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Nombreremolcador = "";
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Identificadorturno = "";
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Turnosemanal = "";
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Horarioremolcador = "";
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Tipousuario = "";
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Comentario = "";
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia01 = "";
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia02 = "";
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia03 = "";
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia04 = "";
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia05 = "";
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia06 = "";
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia07 = "";
         gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Tughorarioscounter = "";
         sTagName = "";
         return  ;
      }

      protected short readOk ;
      protected short nOutParmCount ;
      protected String sTagName ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Status ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Ip ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Username ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Horariosemanal ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Distrito ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Version ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Nombreremolcador ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Identificadorturno ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Turnosemanal ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Horarioremolcador ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Tipousuario ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Comentario ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia01 ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia02 ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia03 ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia04 ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia05 ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia06 ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Remplazodia07 ;
      protected String gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Tughorarioscounter ;
      protected SdtOperTugSchedule_GetOperTugScheduleResult_MASTER1 gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master1=null ;
      protected SdtOperTugSchedule_GetOperTugScheduleResult_MASTER2 gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Master2=null ;
      protected SdtOperTugSchedule_GetOperTugScheduleResult_ENGINEER1 gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer1=null ;
      protected SdtOperTugSchedule_GetOperTugScheduleResult_ENGINEER2 gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Engineer2=null ;
      protected SdtOperTugSchedule_GetOperTugScheduleResult_BOSUN1 gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun1=null ;
      protected SdtOperTugSchedule_GetOperTugScheduleResult_BOSUN2 gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Bosun2=null ;
      protected SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN1 gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman1=null ;
      protected SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN2 gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman2=null ;
      protected SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN3 gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman3=null ;
      protected SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4 gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Seaman4=null ;
      protected SdtOperTugSchedule_GetOperTugScheduleResult_OILER1 gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler1=null ;
      protected SdtOperTugSchedule_GetOperTugScheduleResult_OILER2 gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Oiler2=null ;
      protected SdtOperTugSchedule_GetOperTugScheduleResult_MATE1 gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate1=null ;
      protected SdtOperTugSchedule_GetOperTugScheduleResult_MATE2 gxTv_SdtOperTugSchedule_GetOperTugScheduleResult_Mate2=null ;
   }

   [DataContract(Name = @"OperTugSchedule.GetOperTugScheduleResult", Namespace = "CalcularPeajes")]
   public class SdtOperTugSchedule_GetOperTugScheduleResult_RESTInterface : GxGenericCollectionItem<SdtOperTugSchedule_GetOperTugScheduleResult>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtOperTugSchedule_GetOperTugScheduleResult_RESTInterface( ) : base()
      {
      }

      public SdtOperTugSchedule_GetOperTugScheduleResult_RESTInterface( SdtOperTugSchedule_GetOperTugScheduleResult psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "STATUS" , Order = 0 )]
      public String gxTpr_Status
      {
         get {
            return sdt.gxTpr_Status ;
         }

         set {
            sdt.gxTpr_Status = (String)(value);
         }

      }

      [DataMember( Name = "IP" , Order = 1 )]
      public String gxTpr_Ip
      {
         get {
            return sdt.gxTpr_Ip ;
         }

         set {
            sdt.gxTpr_Ip = (String)(value);
         }

      }

      [DataMember( Name = "USERNAME" , Order = 2 )]
      public String gxTpr_Username
      {
         get {
            return sdt.gxTpr_Username ;
         }

         set {
            sdt.gxTpr_Username = (String)(value);
         }

      }

      [DataMember( Name = "HORARIOSEMANAL" , Order = 3 )]
      public String gxTpr_Horariosemanal
      {
         get {
            return sdt.gxTpr_Horariosemanal ;
         }

         set {
            sdt.gxTpr_Horariosemanal = (String)(value);
         }

      }

      [DataMember( Name = "DISTRITO" , Order = 4 )]
      public String gxTpr_Distrito
      {
         get {
            return sdt.gxTpr_Distrito ;
         }

         set {
            sdt.gxTpr_Distrito = (String)(value);
         }

      }

      [DataMember( Name = "VERSION" , Order = 5 )]
      public String gxTpr_Version
      {
         get {
            return sdt.gxTpr_Version ;
         }

         set {
            sdt.gxTpr_Version = (String)(value);
         }

      }

      [DataMember( Name = "NOMBREREMOLCADOR" , Order = 6 )]
      public String gxTpr_Nombreremolcador
      {
         get {
            return sdt.gxTpr_Nombreremolcador ;
         }

         set {
            sdt.gxTpr_Nombreremolcador = (String)(value);
         }

      }

      [DataMember( Name = "IDENTIFICADORTURNO" , Order = 7 )]
      public String gxTpr_Identificadorturno
      {
         get {
            return sdt.gxTpr_Identificadorturno ;
         }

         set {
            sdt.gxTpr_Identificadorturno = (String)(value);
         }

      }

      [DataMember( Name = "TURNOSEMANAL" , Order = 8 )]
      public String gxTpr_Turnosemanal
      {
         get {
            return sdt.gxTpr_Turnosemanal ;
         }

         set {
            sdt.gxTpr_Turnosemanal = (String)(value);
         }

      }

      [DataMember( Name = "HORARIOREMOLCADOR" , Order = 9 )]
      public String gxTpr_Horarioremolcador
      {
         get {
            return sdt.gxTpr_Horarioremolcador ;
         }

         set {
            sdt.gxTpr_Horarioremolcador = (String)(value);
         }

      }

      [DataMember( Name = "TIPOUSUARIO" , Order = 10 )]
      public String gxTpr_Tipousuario
      {
         get {
            return sdt.gxTpr_Tipousuario ;
         }

         set {
            sdt.gxTpr_Tipousuario = (String)(value);
         }

      }

      [DataMember( Name = "MASTER1" , Order = 11 )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_MASTER1_RESTInterface gxTpr_Master1
      {
         get {
            return new SdtOperTugSchedule_GetOperTugScheduleResult_MASTER1_RESTInterface(sdt.gxTpr_Master1) ;
         }

         set {
            sdt.gxTpr_Master1 = value.sdt;
         }

      }

      [DataMember( Name = "MASTER2" , Order = 12 )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_MASTER2_RESTInterface gxTpr_Master2
      {
         get {
            return new SdtOperTugSchedule_GetOperTugScheduleResult_MASTER2_RESTInterface(sdt.gxTpr_Master2) ;
         }

         set {
            sdt.gxTpr_Master2 = value.sdt;
         }

      }

      [DataMember( Name = "ENGINEER1" , Order = 13 )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_ENGINEER1_RESTInterface gxTpr_Engineer1
      {
         get {
            return new SdtOperTugSchedule_GetOperTugScheduleResult_ENGINEER1_RESTInterface(sdt.gxTpr_Engineer1) ;
         }

         set {
            sdt.gxTpr_Engineer1 = value.sdt;
         }

      }

      [DataMember( Name = "ENGINEER2" , Order = 14 )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_ENGINEER2_RESTInterface gxTpr_Engineer2
      {
         get {
            return new SdtOperTugSchedule_GetOperTugScheduleResult_ENGINEER2_RESTInterface(sdt.gxTpr_Engineer2) ;
         }

         set {
            sdt.gxTpr_Engineer2 = value.sdt;
         }

      }

      [DataMember( Name = "BOSUN1" , Order = 15 )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_BOSUN1_RESTInterface gxTpr_Bosun1
      {
         get {
            return new SdtOperTugSchedule_GetOperTugScheduleResult_BOSUN1_RESTInterface(sdt.gxTpr_Bosun1) ;
         }

         set {
            sdt.gxTpr_Bosun1 = value.sdt;
         }

      }

      [DataMember( Name = "BOSUN2" , Order = 16 )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_BOSUN2_RESTInterface gxTpr_Bosun2
      {
         get {
            return new SdtOperTugSchedule_GetOperTugScheduleResult_BOSUN2_RESTInterface(sdt.gxTpr_Bosun2) ;
         }

         set {
            sdt.gxTpr_Bosun2 = value.sdt;
         }

      }

      [DataMember( Name = "SEAMAN1" , Order = 17 )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN1_RESTInterface gxTpr_Seaman1
      {
         get {
            return new SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN1_RESTInterface(sdt.gxTpr_Seaman1) ;
         }

         set {
            sdt.gxTpr_Seaman1 = value.sdt;
         }

      }

      [DataMember( Name = "SEAMAN2" , Order = 18 )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN2_RESTInterface gxTpr_Seaman2
      {
         get {
            return new SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN2_RESTInterface(sdt.gxTpr_Seaman2) ;
         }

         set {
            sdt.gxTpr_Seaman2 = value.sdt;
         }

      }

      [DataMember( Name = "SEAMAN3" , Order = 19 )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN3_RESTInterface gxTpr_Seaman3
      {
         get {
            return new SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN3_RESTInterface(sdt.gxTpr_Seaman3) ;
         }

         set {
            sdt.gxTpr_Seaman3 = value.sdt;
         }

      }

      [DataMember( Name = "SEAMAN4" , Order = 20 )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_RESTInterface gxTpr_Seaman4
      {
         get {
            return new SdtOperTugSchedule_GetOperTugScheduleResult_SEAMAN4_RESTInterface(sdt.gxTpr_Seaman4) ;
         }

         set {
            sdt.gxTpr_Seaman4 = value.sdt;
         }

      }

      [DataMember( Name = "OILER1" , Order = 21 )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_OILER1_RESTInterface gxTpr_Oiler1
      {
         get {
            return new SdtOperTugSchedule_GetOperTugScheduleResult_OILER1_RESTInterface(sdt.gxTpr_Oiler1) ;
         }

         set {
            sdt.gxTpr_Oiler1 = value.sdt;
         }

      }

      [DataMember( Name = "OILER2" , Order = 22 )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_OILER2_RESTInterface gxTpr_Oiler2
      {
         get {
            return new SdtOperTugSchedule_GetOperTugScheduleResult_OILER2_RESTInterface(sdt.gxTpr_Oiler2) ;
         }

         set {
            sdt.gxTpr_Oiler2 = value.sdt;
         }

      }

      [DataMember( Name = "MATE1" , Order = 23 )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_MATE1_RESTInterface gxTpr_Mate1
      {
         get {
            return new SdtOperTugSchedule_GetOperTugScheduleResult_MATE1_RESTInterface(sdt.gxTpr_Mate1) ;
         }

         set {
            sdt.gxTpr_Mate1 = value.sdt;
         }

      }

      [DataMember( Name = "MATE2" , Order = 24 )]
      public SdtOperTugSchedule_GetOperTugScheduleResult_MATE2_RESTInterface gxTpr_Mate2
      {
         get {
            return new SdtOperTugSchedule_GetOperTugScheduleResult_MATE2_RESTInterface(sdt.gxTpr_Mate2) ;
         }

         set {
            sdt.gxTpr_Mate2 = value.sdt;
         }

      }

      [DataMember( Name = "COMENTARIO" , Order = 25 )]
      public String gxTpr_Comentario
      {
         get {
            return sdt.gxTpr_Comentario ;
         }

         set {
            sdt.gxTpr_Comentario = (String)(value);
         }

      }

      [DataMember( Name = "REMPLAZODIA01" , Order = 26 )]
      public String gxTpr_Remplazodia01
      {
         get {
            return sdt.gxTpr_Remplazodia01 ;
         }

         set {
            sdt.gxTpr_Remplazodia01 = (String)(value);
         }

      }

      [DataMember( Name = "REMPLAZODIA02" , Order = 27 )]
      public String gxTpr_Remplazodia02
      {
         get {
            return sdt.gxTpr_Remplazodia02 ;
         }

         set {
            sdt.gxTpr_Remplazodia02 = (String)(value);
         }

      }

      [DataMember( Name = "REMPLAZODIA03" , Order = 28 )]
      public String gxTpr_Remplazodia03
      {
         get {
            return sdt.gxTpr_Remplazodia03 ;
         }

         set {
            sdt.gxTpr_Remplazodia03 = (String)(value);
         }

      }

      [DataMember( Name = "REMPLAZODIA04" , Order = 29 )]
      public String gxTpr_Remplazodia04
      {
         get {
            return sdt.gxTpr_Remplazodia04 ;
         }

         set {
            sdt.gxTpr_Remplazodia04 = (String)(value);
         }

      }

      [DataMember( Name = "REMPLAZODIA05" , Order = 30 )]
      public String gxTpr_Remplazodia05
      {
         get {
            return sdt.gxTpr_Remplazodia05 ;
         }

         set {
            sdt.gxTpr_Remplazodia05 = (String)(value);
         }

      }

      [DataMember( Name = "REMPLAZODIA06" , Order = 31 )]
      public String gxTpr_Remplazodia06
      {
         get {
            return sdt.gxTpr_Remplazodia06 ;
         }

         set {
            sdt.gxTpr_Remplazodia06 = (String)(value);
         }

      }

      [DataMember( Name = "REMPLAZODIA07" , Order = 32 )]
      public String gxTpr_Remplazodia07
      {
         get {
            return sdt.gxTpr_Remplazodia07 ;
         }

         set {
            sdt.gxTpr_Remplazodia07 = (String)(value);
         }

      }

      [DataMember( Name = "TUGHORARIOSCOUNTER" , Order = 33 )]
      public String gxTpr_Tughorarioscounter
      {
         get {
            return sdt.gxTpr_Tughorarioscounter ;
         }

         set {
            sdt.gxTpr_Tughorarioscounter = (String)(value);
         }

      }

      public SdtOperTugSchedule_GetOperTugScheduleResult sdt
      {
         get {
            return (SdtOperTugSchedule_GetOperTugScheduleResult)Sdt ;
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
            sdt = new SdtOperTugSchedule_GetOperTugScheduleResult() ;
         }
      }

   }

}
