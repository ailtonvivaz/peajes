/*
               File: DPWsTest
        Description: DPWs Test
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/21/2015 12:14:22.85
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
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class dpwstest : GXProcedure
   {
      public dpwstest( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public dpwstest( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( decimal aP0_CapacidadDeContenedores ,
                           decimal aP1_CargaTEU ,
                           out SdtSdtResultado aP2_Gxm1sdtresultado )
      {
         this.AV6CapacidadDeContenedores = aP0_CapacidadDeContenedores;
         this.AV7CargaTEU = aP1_CargaTEU;
         this.Gxm1sdtresultado = new SdtSdtResultado(context) ;
         initialize();
         executePrivate();
         aP2_Gxm1sdtresultado=this.Gxm1sdtresultado;
      }

      public SdtSdtResultado executeUdp( decimal aP0_CapacidadDeContenedores ,
                                         decimal aP1_CargaTEU )
      {
         this.AV6CapacidadDeContenedores = aP0_CapacidadDeContenedores;
         this.AV7CargaTEU = aP1_CargaTEU;
         this.Gxm1sdtresultado = new SdtSdtResultado(context) ;
         initialize();
         executePrivate();
         aP2_Gxm1sdtresultado=this.Gxm1sdtresultado;
         return Gxm1sdtresultado ;
      }

      public void executeSubmit( decimal aP0_CapacidadDeContenedores ,
                                 decimal aP1_CargaTEU ,
                                 out SdtSdtResultado aP2_Gxm1sdtresultado )
      {
         dpwstest objdpwstest;
         objdpwstest = new dpwstest();
         objdpwstest.AV6CapacidadDeContenedores = aP0_CapacidadDeContenedores;
         objdpwstest.AV7CargaTEU = aP1_CargaTEU;
         objdpwstest.Gxm1sdtresultado = new SdtSdtResultado(context) ;
         objdpwstest.context.SetSubmitInitialConfig(context);
         objdpwstest.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objdpwstest);
         aP2_Gxm1sdtresultado=this.Gxm1sdtresultado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((dpwstest)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "ClienteWeb Peajes", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         GXt_SdtSdtResultado1 = AV5sdtResultado;
         new calcularportacontenedores(context ).execute(  AV6CapacidadDeContenedores,  AV7CargaTEU, out  GXt_SdtSdtResultado1) ;
         AV5sdtResultado = GXt_SdtSdtResultado1;
         Gxm1sdtresultado.gxTpr_Sdtresultadopanamax = AV5sdtResultado.gxTpr_Sdtresultadopanamax;
         Gxm1sdtresultado.gxTpr_Sdtresultadoneopanamax = AV5sdtResultado.gxTpr_Sdtresultadoneopanamax;
         Gxm1sdtresultado.gxTpr_Sdtresultadolastre = AV5sdtResultado.gxTpr_Sdtresultadolastre;
         Gxm1sdtresultado.gxTpr_Sdtlastreroundtrip = AV5sdtResultado.gxTpr_Sdtlastreroundtrip;
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         AV5sdtResultado = new SdtSdtResultado(context);
         GXt_SdtSdtResultado1 = new SdtSdtResultado(context);
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private decimal AV6CapacidadDeContenedores ;
      private decimal AV7CargaTEU ;
      private SdtSdtResultado aP2_Gxm1sdtresultado ;
      private SdtSdtResultado Gxm1sdtresultado ;
      private SdtSdtResultado AV5sdtResultado ;
      private SdtSdtResultado GXt_SdtSdtResultado1 ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.dpwstest_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class dpwstest_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "GET" ,
      	BodyStyle =  WebMessageBodyStyle.Bare  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/?CapacidadDeContenedores={CapacidadDeContenedores}&CargaTEU={CargaTEU}")]
      public SdtSdtResultado_RESTInterface execute( String CapacidadDeContenedores ,
                                                    String CargaTEU )
      {
         SdtSdtResultado_RESTInterface Gxm1sdtresultado = new SdtSdtResultado_RESTInterface() ;
         try
         {
            dpwstest worker = new dpwstest(context) ;
            worker.IsMain = RunAsMain ;
            decimal gxrCapacidadDeContenedores ;
            gxrCapacidadDeContenedores = NumberUtil.Val( (String)(CapacidadDeContenedores), ".");
            decimal gxrCargaTEU ;
            gxrCargaTEU = NumberUtil.Val( (String)(CargaTEU), ".");
            SdtSdtResultado gxrGxm1sdtresultado = Gxm1sdtresultado.sdt ;
            worker.execute(gxrCapacidadDeContenedores,gxrCargaTEU,out gxrGxm1sdtresultado );
            worker.cleanup( );
            Gxm1sdtresultado = new SdtSdtResultado_RESTInterface(gxrGxm1sdtresultado) ;
            return Gxm1sdtresultado ;
         }
         catch ( Exception e )
         {
            WebException(e);
         }
         finally
         {
            Cleanup();
         }
         return null ;
      }

   }

}
