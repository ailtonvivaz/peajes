/*
               File: CalcularGranelesSecos
        Description: Calcular Graneles Secos
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:14:55.56
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
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class calculargranelessecos : GXProcedure
   {
      public calculargranelessecos( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public calculargranelessecos( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( short aP0_P1 ,
                           out decimal aP1_ValorCalculado )
      {
         this.AV8P1 = aP0_P1;
         this.AV10ValorCalculado = 0 ;
         initialize();
         executePrivate();
         aP1_ValorCalculado=this.AV10ValorCalculado;
      }

      public decimal executeUdp( short aP0_P1 )
      {
         this.AV8P1 = aP0_P1;
         this.AV10ValorCalculado = 0 ;
         initialize();
         executePrivate();
         aP1_ValorCalculado=this.AV10ValorCalculado;
         return AV10ValorCalculado ;
      }

      public void executeSubmit( short aP0_P1 ,
                                 out decimal aP1_ValorCalculado )
      {
         calculargranelessecos objcalculargranelessecos;
         objcalculargranelessecos = new calculargranelessecos();
         objcalculargranelessecos.AV8P1 = aP0_P1;
         objcalculargranelessecos.AV10ValorCalculado = 0 ;
         objcalculargranelessecos.context.SetSubmitInitialConfig(context);
         objcalculargranelessecos.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objcalculargranelessecos);
         aP1_ValorCalculado=this.AV10ValorCalculado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((calculargranelessecos)stateInfo).executePrivate();
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
         AV10ValorCalculado = (decimal)(NumberUtil.Random( ));
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

      private short AV8P1 ;
      private decimal AV10ValorCalculado ;
      private decimal aP1_ValorCalculado ;
   }

}
