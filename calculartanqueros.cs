/*
               File: CalcularTanqueros
        Description: Stub for CalcularTanqueros
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:14:55.70
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
using System.Web.Services.Protocols;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
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
   public class calculartanqueros : GXProcedure
   {
      public calculartanqueros( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public calculartanqueros( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_TanqueroBandaCPSUAB ,
                           long aP1_TanqueroBandaTM ,
                           long aP2_DWT ,
                           out SdtSdtResultado aP3_SdtResultado )
      {
         this.AV2TanqueroBandaCPSUAB = aP0_TanqueroBandaCPSUAB;
         this.AV3TanqueroBandaTM = aP1_TanqueroBandaTM;
         this.AV4DWT = aP2_DWT;
         this.AV5SdtResultado = new SdtSdtResultado(context) ;
         initialize();
         executePrivate();
         aP3_SdtResultado=this.AV5SdtResultado;
      }

      public SdtSdtResultado executeUdp( long aP0_TanqueroBandaCPSUAB ,
                                         long aP1_TanqueroBandaTM ,
                                         long aP2_DWT )
      {
         this.AV2TanqueroBandaCPSUAB = aP0_TanqueroBandaCPSUAB;
         this.AV3TanqueroBandaTM = aP1_TanqueroBandaTM;
         this.AV4DWT = aP2_DWT;
         this.AV5SdtResultado = new SdtSdtResultado(context) ;
         initialize();
         executePrivate();
         aP3_SdtResultado=this.AV5SdtResultado;
         return AV5SdtResultado ;
      }

      public void executeSubmit( long aP0_TanqueroBandaCPSUAB ,
                                 long aP1_TanqueroBandaTM ,
                                 long aP2_DWT ,
                                 out SdtSdtResultado aP3_SdtResultado )
      {
         calculartanqueros objcalculartanqueros;
         objcalculartanqueros = new calculartanqueros();
         objcalculartanqueros.AV2TanqueroBandaCPSUAB = aP0_TanqueroBandaCPSUAB;
         objcalculartanqueros.AV3TanqueroBandaTM = aP1_TanqueroBandaTM;
         objcalculartanqueros.AV4DWT = aP2_DWT;
         objcalculartanqueros.AV5SdtResultado = new SdtSdtResultado(context) ;
         objcalculartanqueros.context.SetSubmitInitialConfig(context);
         objcalculartanqueros.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objcalculartanqueros);
         aP3_SdtResultado=this.AV5SdtResultado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((calculartanqueros)stateInfo).executePrivate();
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
         args = new Object[] {(long)AV2TanqueroBandaCPSUAB,(long)AV3TanqueroBandaTM,(long)AV4DWT,(SdtSdtResultado)AV5SdtResultado} ;
         ClassLoader.Execute("acalculartanqueros","GeneXus.Programs.acalculartanqueros", new Object[] {context }, "execute", args);
         if ( ( args != null ) && ( args.Length == 4 ) )
         {
            AV5SdtResultado = (SdtSdtResultado)(args[3]) ;
         }
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long AV2TanqueroBandaCPSUAB ;
      private long AV3TanqueroBandaTM ;
      private long AV4DWT ;
      private IGxDataStore dsDefault ;
      private Object[] args ;
      private SdtSdtResultado aP3_SdtResultado ;
      private SdtSdtResultado AV5SdtResultado ;
   }

}
