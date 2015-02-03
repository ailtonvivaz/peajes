/*
               File: WSCalcularPortavehiculosRORO
        Description: Calcular cobro de Portavehiculos y RO-RO
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:14:57.9
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
   public class wscalcularportavehiculosroro : GXProcedure
   {
      public wscalcularportavehiculosroro( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public wscalcularportavehiculosroro( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out String aP0_Resultado )
      {
         this.AV12Resultado = "" ;
         initialize();
         executePrivate();
         aP0_Resultado=this.AV12Resultado;
      }

      public String executeUdp( )
      {
         this.AV12Resultado = "" ;
         initialize();
         executePrivate();
         aP0_Resultado=this.AV12Resultado;
         return AV12Resultado ;
      }

      public void executeSubmit( out String aP0_Resultado )
      {
         wscalcularportavehiculosroro objwscalcularportavehiculosroro;
         objwscalcularportavehiculosroro = new wscalcularportavehiculosroro();
         objwscalcularportavehiculosroro.AV12Resultado = "" ;
         objwscalcularportavehiculosroro.context.SetSubmitInitialConfig(context);
         objwscalcularportavehiculosroro.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objwscalcularportavehiculosroro);
         aP0_Resultado=this.AV12Resultado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((wscalcularportavehiculosroro)stateInfo).executePrivate();
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
         AV12Resultado = context.GetMessage( "Me jubilo en 5 años y me trasladaran a Madden", "");
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
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private String AV12Resultado ;
      private String aP0_Resultado ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.wscalcularportavehiculosroro_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class wscalcularportavehiculosroro_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "POST" ,
      	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/")]
      public void execute( out String Resultado )
      {
         Resultado = "" ;
         try
         {
            wscalcularportavehiculosroro worker = new wscalcularportavehiculosroro(context) ;
            worker.IsMain = RunAsMain ;
            worker.execute(out Resultado );
            worker.cleanup( );
         }
         catch ( Exception e )
         {
            WebException(e);
         }
         finally
         {
            Cleanup();
         }
      }

   }

}
