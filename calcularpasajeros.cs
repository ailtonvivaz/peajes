/*
               File: CalcularPasajeros
        Description: Calculo para los buques pasajeros
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:14:56.88
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
   public class calcularpasajeros : GXProcedure
   {
      public calcularpasajeros( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public calcularpasajeros( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_PAXITC ,
                           long aP1_TRB ,
                           long aP2_CPSUAB ,
                           out SdtSdtResultado aP3_SdtResultado )
      {
         this.AV11PAXITC = aP0_PAXITC;
         this.AV14TRB = aP1_TRB;
         this.AV8CPSUAB = aP2_CPSUAB;
         this.AV13SdtResultado = new SdtSdtResultado(context) ;
         initialize();
         executePrivate();
         aP3_SdtResultado=this.AV13SdtResultado;
      }

      public SdtSdtResultado executeUdp( long aP0_PAXITC ,
                                         long aP1_TRB ,
                                         long aP2_CPSUAB )
      {
         this.AV11PAXITC = aP0_PAXITC;
         this.AV14TRB = aP1_TRB;
         this.AV8CPSUAB = aP2_CPSUAB;
         this.AV13SdtResultado = new SdtSdtResultado(context) ;
         initialize();
         executePrivate();
         aP3_SdtResultado=this.AV13SdtResultado;
         return AV13SdtResultado ;
      }

      public void executeSubmit( long aP0_PAXITC ,
                                 long aP1_TRB ,
                                 long aP2_CPSUAB ,
                                 out SdtSdtResultado aP3_SdtResultado )
      {
         calcularpasajeros objcalcularpasajeros;
         objcalcularpasajeros = new calcularpasajeros();
         objcalcularpasajeros.AV11PAXITC = aP0_PAXITC;
         objcalcularpasajeros.AV14TRB = aP1_TRB;
         objcalcularpasajeros.AV8CPSUAB = aP2_CPSUAB;
         objcalcularpasajeros.AV13SdtResultado = new SdtSdtResultado(context) ;
         objcalcularpasajeros.context.SetSubmitInitialConfig(context);
         objcalcularpasajeros.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objcalcularpasajeros);
         aP3_SdtResultado=this.AV13SdtResultado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((calcularpasajeros)stateInfo).executePrivate();
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
         AV9MaxTRB = 30000;
         AV12Relacion = 33;
         AV13SdtResultado.gxTpr_Sdtresultadopanamax = (decimal)(0);
         AV13SdtResultado.gxTpr_Sdtresultadoneopanamax = (decimal)(0);
         AV13SdtResultado.gxTpr_Sdtresultadolastre = (decimal)(0);
         AV13SdtResultado.gxTpr_Sdtlastreroundtrip = (decimal)(0);
         if ( ( ( AV14TRB > AV9MaxTRB ) ) && ( ( ( AV8CPSUAB /  ( decimal )( AV11PAXITC ) ) <= Convert.ToDecimal( AV12Relacion )) ) )
         {
            /* Using cursor P000G2 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               A58PASAJEROS_ESCLUSA = P000G2_A58PASAJEROS_ESCLUSA[0];
               A59PASAJEROS_CARGA = P000G2_A59PASAJEROS_CARGA[0];
               A60PASAJEROS_TIPO_TARIFA = P000G2_A60PASAJEROS_TIPO_TARIFA[0];
               A62PASAJEROS_TARIFA = P000G2_A62PASAJEROS_TARIFA[0];
               A63PASAJEROS_ID = P000G2_A63PASAJEROS_ID[0];
               AV13SdtResultado.gxTpr_Sdtresultadopanamax = (decimal)(AV11PAXITC*A62PASAJEROS_TARIFA);
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(0);
            }
            pr_default.close(0);
            /* Using cursor P000G3 */
            pr_default.execute(1);
            while ( (pr_default.getStatus(1) != 101) )
            {
               A58PASAJEROS_ESCLUSA = P000G3_A58PASAJEROS_ESCLUSA[0];
               A59PASAJEROS_CARGA = P000G3_A59PASAJEROS_CARGA[0];
               A60PASAJEROS_TIPO_TARIFA = P000G3_A60PASAJEROS_TIPO_TARIFA[0];
               A62PASAJEROS_TARIFA = P000G3_A62PASAJEROS_TARIFA[0];
               A63PASAJEROS_ID = P000G3_A63PASAJEROS_ID[0];
               AV13SdtResultado.gxTpr_Sdtresultadoneopanamax = (decimal)(AV11PAXITC*A62PASAJEROS_TARIFA);
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(1);
            }
            pr_default.close(1);
            /* Using cursor P000G4 */
            pr_default.execute(2);
            while ( (pr_default.getStatus(2) != 101) )
            {
               A58PASAJEROS_ESCLUSA = P000G4_A58PASAJEROS_ESCLUSA[0];
               A59PASAJEROS_CARGA = P000G4_A59PASAJEROS_CARGA[0];
               A60PASAJEROS_TIPO_TARIFA = P000G4_A60PASAJEROS_TIPO_TARIFA[0];
               A62PASAJEROS_TARIFA = P000G4_A62PASAJEROS_TARIFA[0];
               A63PASAJEROS_ID = P000G4_A63PASAJEROS_ID[0];
               AV13SdtResultado.gxTpr_Sdtresultadolastre = (decimal)(AV11PAXITC*A62PASAJEROS_TARIFA);
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(2);
            }
            pr_default.close(2);
            /* Using cursor P000G5 */
            pr_default.execute(3);
            while ( (pr_default.getStatus(3) != 101) )
            {
               A58PASAJEROS_ESCLUSA = P000G5_A58PASAJEROS_ESCLUSA[0];
               A59PASAJEROS_CARGA = P000G5_A59PASAJEROS_CARGA[0];
               A60PASAJEROS_TIPO_TARIFA = P000G5_A60PASAJEROS_TIPO_TARIFA[0];
               A62PASAJEROS_TARIFA = P000G5_A62PASAJEROS_TARIFA[0];
               A63PASAJEROS_ID = P000G5_A63PASAJEROS_ID[0];
               AV13SdtResultado.gxTpr_Sdtlastreroundtrip = (decimal)(AV11PAXITC*A62PASAJEROS_TARIFA);
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(3);
            }
            pr_default.close(3);
         }
         if ( ( ( AV14TRB > AV9MaxTRB ) ) && ( ( ( AV8CPSUAB /  ( decimal )( AV11PAXITC ) ) > Convert.ToDecimal( AV12Relacion )) ) || ( ( AV14TRB <= AV9MaxTRB ) ) )
         {
            AV10OperacionTonelaje = AV8CPSUAB;
            /* Using cursor P000G6 */
            pr_default.execute(4);
            while ( (pr_default.getStatus(4) != 101) )
            {
               A60PASAJEROS_TIPO_TARIFA = P000G6_A60PASAJEROS_TIPO_TARIFA[0];
               A59PASAJEROS_CARGA = P000G6_A59PASAJEROS_CARGA[0];
               A58PASAJEROS_ESCLUSA = P000G6_A58PASAJEROS_ESCLUSA[0];
               A61PASAJEROS_TON_TARIFA = P000G6_A61PASAJEROS_TON_TARIFA[0];
               n61PASAJEROS_TON_TARIFA = P000G6_n61PASAJEROS_TON_TARIFA[0];
               A62PASAJEROS_TARIFA = P000G6_A62PASAJEROS_TARIFA[0];
               A65PASAJEROS_ID_TON_TARIF = P000G6_A65PASAJEROS_ID_TON_TARIF[0];
               A63PASAJEROS_ID = P000G6_A63PASAJEROS_ID[0];
               if ( AV10OperacionTonelaje >= A61PASAJEROS_TON_TARIFA )
               {
                  if ( A61PASAJEROS_TON_TARIFA != 0 )
                  {
                     AV13SdtResultado.gxTpr_Sdtresultadopanamax = (decimal)(AV13SdtResultado.gxTpr_Sdtresultadopanamax+(A61PASAJEROS_TON_TARIFA*A62PASAJEROS_TARIFA));
                     AV10OperacionTonelaje = (long)(AV10OperacionTonelaje-A61PASAJEROS_TON_TARIFA);
                  }
                  else
                  {
                     AV13SdtResultado.gxTpr_Sdtresultadopanamax = (decimal)(AV13SdtResultado.gxTpr_Sdtresultadopanamax+(AV10OperacionTonelaje*A62PASAJEROS_TARIFA));
                     AV10OperacionTonelaje = 0;
                     /* Exit For each command. Update data (if necessary), close cursors & exit. */
                     if (true) break;
                  }
               }
               else
               {
                  AV13SdtResultado.gxTpr_Sdtresultadopanamax = (decimal)(AV13SdtResultado.gxTpr_Sdtresultadopanamax+(AV10OperacionTonelaje*A62PASAJEROS_TARIFA));
                  AV10OperacionTonelaje = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
               pr_default.readNext(4);
            }
            pr_default.close(4);
            AV10OperacionTonelaje = AV8CPSUAB;
            /* Using cursor P000G7 */
            pr_default.execute(5);
            while ( (pr_default.getStatus(5) != 101) )
            {
               A60PASAJEROS_TIPO_TARIFA = P000G7_A60PASAJEROS_TIPO_TARIFA[0];
               A59PASAJEROS_CARGA = P000G7_A59PASAJEROS_CARGA[0];
               A58PASAJEROS_ESCLUSA = P000G7_A58PASAJEROS_ESCLUSA[0];
               A61PASAJEROS_TON_TARIFA = P000G7_A61PASAJEROS_TON_TARIFA[0];
               n61PASAJEROS_TON_TARIFA = P000G7_n61PASAJEROS_TON_TARIFA[0];
               A62PASAJEROS_TARIFA = P000G7_A62PASAJEROS_TARIFA[0];
               A65PASAJEROS_ID_TON_TARIF = P000G7_A65PASAJEROS_ID_TON_TARIF[0];
               A63PASAJEROS_ID = P000G7_A63PASAJEROS_ID[0];
               if ( AV10OperacionTonelaje >= A61PASAJEROS_TON_TARIFA )
               {
                  if ( A61PASAJEROS_TON_TARIFA != 0 )
                  {
                     AV13SdtResultado.gxTpr_Sdtresultadoneopanamax = (decimal)(AV13SdtResultado.gxTpr_Sdtresultadoneopanamax+(A61PASAJEROS_TON_TARIFA*A62PASAJEROS_TARIFA));
                     AV10OperacionTonelaje = (long)(AV10OperacionTonelaje-A61PASAJEROS_TON_TARIFA);
                  }
                  else
                  {
                     AV13SdtResultado.gxTpr_Sdtresultadoneopanamax = (decimal)(AV13SdtResultado.gxTpr_Sdtresultadoneopanamax+(AV10OperacionTonelaje*A62PASAJEROS_TARIFA));
                     AV10OperacionTonelaje = 0;
                     /* Exit For each command. Update data (if necessary), close cursors & exit. */
                     if (true) break;
                  }
               }
               else
               {
                  AV13SdtResultado.gxTpr_Sdtresultadoneopanamax = (decimal)(AV13SdtResultado.gxTpr_Sdtresultadoneopanamax+(AV10OperacionTonelaje*A62PASAJEROS_TARIFA));
                  AV10OperacionTonelaje = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
               pr_default.readNext(5);
            }
            pr_default.close(5);
            AV10OperacionTonelaje = AV8CPSUAB;
            /* Using cursor P000G8 */
            pr_default.execute(6);
            while ( (pr_default.getStatus(6) != 101) )
            {
               A60PASAJEROS_TIPO_TARIFA = P000G8_A60PASAJEROS_TIPO_TARIFA[0];
               A59PASAJEROS_CARGA = P000G8_A59PASAJEROS_CARGA[0];
               A58PASAJEROS_ESCLUSA = P000G8_A58PASAJEROS_ESCLUSA[0];
               A61PASAJEROS_TON_TARIFA = P000G8_A61PASAJEROS_TON_TARIFA[0];
               n61PASAJEROS_TON_TARIFA = P000G8_n61PASAJEROS_TON_TARIFA[0];
               A62PASAJEROS_TARIFA = P000G8_A62PASAJEROS_TARIFA[0];
               A65PASAJEROS_ID_TON_TARIF = P000G8_A65PASAJEROS_ID_TON_TARIF[0];
               A63PASAJEROS_ID = P000G8_A63PASAJEROS_ID[0];
               if ( AV10OperacionTonelaje >= A61PASAJEROS_TON_TARIFA )
               {
                  if ( A61PASAJEROS_TON_TARIFA != 0 )
                  {
                     AV13SdtResultado.gxTpr_Sdtresultadolastre = (decimal)(AV13SdtResultado.gxTpr_Sdtresultadolastre+(A61PASAJEROS_TON_TARIFA*A62PASAJEROS_TARIFA));
                     AV10OperacionTonelaje = (long)(AV10OperacionTonelaje-A61PASAJEROS_TON_TARIFA);
                  }
                  else
                  {
                     AV13SdtResultado.gxTpr_Sdtresultadolastre = (decimal)(AV13SdtResultado.gxTpr_Sdtresultadolastre+(AV10OperacionTonelaje*A62PASAJEROS_TARIFA));
                     AV10OperacionTonelaje = 0;
                     /* Exit For each command. Update data (if necessary), close cursors & exit. */
                     if (true) break;
                  }
               }
               else
               {
                  AV13SdtResultado.gxTpr_Sdtresultadolastre = (decimal)(AV13SdtResultado.gxTpr_Sdtresultadolastre+(AV10OperacionTonelaje*A62PASAJEROS_TARIFA));
                  AV10OperacionTonelaje = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
               pr_default.readNext(6);
            }
            pr_default.close(6);
            AV10OperacionTonelaje = AV8CPSUAB;
            /* Using cursor P000G9 */
            pr_default.execute(7);
            while ( (pr_default.getStatus(7) != 101) )
            {
               A60PASAJEROS_TIPO_TARIFA = P000G9_A60PASAJEROS_TIPO_TARIFA[0];
               A59PASAJEROS_CARGA = P000G9_A59PASAJEROS_CARGA[0];
               A58PASAJEROS_ESCLUSA = P000G9_A58PASAJEROS_ESCLUSA[0];
               A61PASAJEROS_TON_TARIFA = P000G9_A61PASAJEROS_TON_TARIFA[0];
               n61PASAJEROS_TON_TARIFA = P000G9_n61PASAJEROS_TON_TARIFA[0];
               A62PASAJEROS_TARIFA = P000G9_A62PASAJEROS_TARIFA[0];
               A65PASAJEROS_ID_TON_TARIF = P000G9_A65PASAJEROS_ID_TON_TARIF[0];
               A63PASAJEROS_ID = P000G9_A63PASAJEROS_ID[0];
               if ( AV10OperacionTonelaje >= A61PASAJEROS_TON_TARIFA )
               {
                  if ( A61PASAJEROS_TON_TARIFA != 0 )
                  {
                     AV13SdtResultado.gxTpr_Sdtlastreroundtrip = (decimal)(AV13SdtResultado.gxTpr_Sdtlastreroundtrip+(A61PASAJEROS_TON_TARIFA*A62PASAJEROS_TARIFA));
                     AV10OperacionTonelaje = (long)(AV10OperacionTonelaje-A61PASAJEROS_TON_TARIFA);
                  }
                  else
                  {
                     AV13SdtResultado.gxTpr_Sdtlastreroundtrip = (decimal)(AV13SdtResultado.gxTpr_Sdtlastreroundtrip+(AV10OperacionTonelaje*A62PASAJEROS_TARIFA));
                     AV10OperacionTonelaje = 0;
                     /* Exit For each command. Update data (if necessary), close cursors & exit. */
                     if (true) break;
                  }
               }
               else
               {
                  AV13SdtResultado.gxTpr_Sdtlastreroundtrip = (decimal)(AV13SdtResultado.gxTpr_Sdtlastreroundtrip+(AV10OperacionTonelaje*A62PASAJEROS_TARIFA));
                  AV10OperacionTonelaje = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
               pr_default.readNext(7);
            }
            pr_default.close(7);
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
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         scmdbuf = "";
         P000G2_A58PASAJEROS_ESCLUSA = new String[] {""} ;
         P000G2_A59PASAJEROS_CARGA = new String[] {""} ;
         P000G2_A60PASAJEROS_TIPO_TARIFA = new String[] {""} ;
         P000G2_A62PASAJEROS_TARIFA = new decimal[1] ;
         P000G2_A63PASAJEROS_ID = new short[1] ;
         A58PASAJEROS_ESCLUSA = "";
         A59PASAJEROS_CARGA = "";
         A60PASAJEROS_TIPO_TARIFA = "";
         P000G3_A58PASAJEROS_ESCLUSA = new String[] {""} ;
         P000G3_A59PASAJEROS_CARGA = new String[] {""} ;
         P000G3_A60PASAJEROS_TIPO_TARIFA = new String[] {""} ;
         P000G3_A62PASAJEROS_TARIFA = new decimal[1] ;
         P000G3_A63PASAJEROS_ID = new short[1] ;
         P000G4_A58PASAJEROS_ESCLUSA = new String[] {""} ;
         P000G4_A59PASAJEROS_CARGA = new String[] {""} ;
         P000G4_A60PASAJEROS_TIPO_TARIFA = new String[] {""} ;
         P000G4_A62PASAJEROS_TARIFA = new decimal[1] ;
         P000G4_A63PASAJEROS_ID = new short[1] ;
         P000G5_A58PASAJEROS_ESCLUSA = new String[] {""} ;
         P000G5_A59PASAJEROS_CARGA = new String[] {""} ;
         P000G5_A60PASAJEROS_TIPO_TARIFA = new String[] {""} ;
         P000G5_A62PASAJEROS_TARIFA = new decimal[1] ;
         P000G5_A63PASAJEROS_ID = new short[1] ;
         P000G6_A60PASAJEROS_TIPO_TARIFA = new String[] {""} ;
         P000G6_A59PASAJEROS_CARGA = new String[] {""} ;
         P000G6_A58PASAJEROS_ESCLUSA = new String[] {""} ;
         P000G6_A61PASAJEROS_TON_TARIFA = new long[1] ;
         P000G6_n61PASAJEROS_TON_TARIFA = new bool[] {false} ;
         P000G6_A62PASAJEROS_TARIFA = new decimal[1] ;
         P000G6_A65PASAJEROS_ID_TON_TARIF = new short[1] ;
         P000G6_A63PASAJEROS_ID = new short[1] ;
         P000G7_A60PASAJEROS_TIPO_TARIFA = new String[] {""} ;
         P000G7_A59PASAJEROS_CARGA = new String[] {""} ;
         P000G7_A58PASAJEROS_ESCLUSA = new String[] {""} ;
         P000G7_A61PASAJEROS_TON_TARIFA = new long[1] ;
         P000G7_n61PASAJEROS_TON_TARIFA = new bool[] {false} ;
         P000G7_A62PASAJEROS_TARIFA = new decimal[1] ;
         P000G7_A65PASAJEROS_ID_TON_TARIF = new short[1] ;
         P000G7_A63PASAJEROS_ID = new short[1] ;
         P000G8_A60PASAJEROS_TIPO_TARIFA = new String[] {""} ;
         P000G8_A59PASAJEROS_CARGA = new String[] {""} ;
         P000G8_A58PASAJEROS_ESCLUSA = new String[] {""} ;
         P000G8_A61PASAJEROS_TON_TARIFA = new long[1] ;
         P000G8_n61PASAJEROS_TON_TARIFA = new bool[] {false} ;
         P000G8_A62PASAJEROS_TARIFA = new decimal[1] ;
         P000G8_A65PASAJEROS_ID_TON_TARIF = new short[1] ;
         P000G8_A63PASAJEROS_ID = new short[1] ;
         P000G9_A60PASAJEROS_TIPO_TARIFA = new String[] {""} ;
         P000G9_A59PASAJEROS_CARGA = new String[] {""} ;
         P000G9_A58PASAJEROS_ESCLUSA = new String[] {""} ;
         P000G9_A61PASAJEROS_TON_TARIFA = new long[1] ;
         P000G9_n61PASAJEROS_TON_TARIFA = new bool[] {false} ;
         P000G9_A62PASAJEROS_TARIFA = new decimal[1] ;
         P000G9_A65PASAJEROS_ID_TON_TARIF = new short[1] ;
         P000G9_A63PASAJEROS_ID = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.calcularpasajeros__default(),
            new Object[][] {
                new Object[] {
               P000G2_A58PASAJEROS_ESCLUSA, P000G2_A59PASAJEROS_CARGA, P000G2_A60PASAJEROS_TIPO_TARIFA, P000G2_A62PASAJEROS_TARIFA, P000G2_A63PASAJEROS_ID
               }
               , new Object[] {
               P000G3_A58PASAJEROS_ESCLUSA, P000G3_A59PASAJEROS_CARGA, P000G3_A60PASAJEROS_TIPO_TARIFA, P000G3_A62PASAJEROS_TARIFA, P000G3_A63PASAJEROS_ID
               }
               , new Object[] {
               P000G4_A58PASAJEROS_ESCLUSA, P000G4_A59PASAJEROS_CARGA, P000G4_A60PASAJEROS_TIPO_TARIFA, P000G4_A62PASAJEROS_TARIFA, P000G4_A63PASAJEROS_ID
               }
               , new Object[] {
               P000G5_A58PASAJEROS_ESCLUSA, P000G5_A59PASAJEROS_CARGA, P000G5_A60PASAJEROS_TIPO_TARIFA, P000G5_A62PASAJEROS_TARIFA, P000G5_A63PASAJEROS_ID
               }
               , new Object[] {
               P000G6_A60PASAJEROS_TIPO_TARIFA, P000G6_A59PASAJEROS_CARGA, P000G6_A58PASAJEROS_ESCLUSA, P000G6_A61PASAJEROS_TON_TARIFA, P000G6_n61PASAJEROS_TON_TARIFA, P000G6_A62PASAJEROS_TARIFA, P000G6_A65PASAJEROS_ID_TON_TARIF, P000G6_A63PASAJEROS_ID
               }
               , new Object[] {
               P000G7_A60PASAJEROS_TIPO_TARIFA, P000G7_A59PASAJEROS_CARGA, P000G7_A58PASAJEROS_ESCLUSA, P000G7_A61PASAJEROS_TON_TARIFA, P000G7_n61PASAJEROS_TON_TARIFA, P000G7_A62PASAJEROS_TARIFA, P000G7_A65PASAJEROS_ID_TON_TARIF, P000G7_A63PASAJEROS_ID
               }
               , new Object[] {
               P000G8_A60PASAJEROS_TIPO_TARIFA, P000G8_A59PASAJEROS_CARGA, P000G8_A58PASAJEROS_ESCLUSA, P000G8_A61PASAJEROS_TON_TARIFA, P000G8_n61PASAJEROS_TON_TARIFA, P000G8_A62PASAJEROS_TARIFA, P000G8_A65PASAJEROS_ID_TON_TARIF, P000G8_A63PASAJEROS_ID
               }
               , new Object[] {
               P000G9_A60PASAJEROS_TIPO_TARIFA, P000G9_A59PASAJEROS_CARGA, P000G9_A58PASAJEROS_ESCLUSA, P000G9_A61PASAJEROS_TON_TARIFA, P000G9_n61PASAJEROS_TON_TARIFA, P000G9_A62PASAJEROS_TARIFA, P000G9_A65PASAJEROS_ID_TON_TARIF, P000G9_A63PASAJEROS_ID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV12Relacion ;
      private short A63PASAJEROS_ID ;
      private short A65PASAJEROS_ID_TON_TARIF ;
      private long AV11PAXITC ;
      private long AV14TRB ;
      private long AV8CPSUAB ;
      private long AV9MaxTRB ;
      private long AV10OperacionTonelaje ;
      private long A61PASAJEROS_TON_TARIFA ;
      private decimal A62PASAJEROS_TARIFA ;
      private String scmdbuf ;
      private bool n61PASAJEROS_TON_TARIFA ;
      private String A58PASAJEROS_ESCLUSA ;
      private String A59PASAJEROS_CARGA ;
      private String A60PASAJEROS_TIPO_TARIFA ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000G2_A58PASAJEROS_ESCLUSA ;
      private String[] P000G2_A59PASAJEROS_CARGA ;
      private String[] P000G2_A60PASAJEROS_TIPO_TARIFA ;
      private decimal[] P000G2_A62PASAJEROS_TARIFA ;
      private short[] P000G2_A63PASAJEROS_ID ;
      private String[] P000G3_A58PASAJEROS_ESCLUSA ;
      private String[] P000G3_A59PASAJEROS_CARGA ;
      private String[] P000G3_A60PASAJEROS_TIPO_TARIFA ;
      private decimal[] P000G3_A62PASAJEROS_TARIFA ;
      private short[] P000G3_A63PASAJEROS_ID ;
      private String[] P000G4_A58PASAJEROS_ESCLUSA ;
      private String[] P000G4_A59PASAJEROS_CARGA ;
      private String[] P000G4_A60PASAJEROS_TIPO_TARIFA ;
      private decimal[] P000G4_A62PASAJEROS_TARIFA ;
      private short[] P000G4_A63PASAJEROS_ID ;
      private String[] P000G5_A58PASAJEROS_ESCLUSA ;
      private String[] P000G5_A59PASAJEROS_CARGA ;
      private String[] P000G5_A60PASAJEROS_TIPO_TARIFA ;
      private decimal[] P000G5_A62PASAJEROS_TARIFA ;
      private short[] P000G5_A63PASAJEROS_ID ;
      private String[] P000G6_A60PASAJEROS_TIPO_TARIFA ;
      private String[] P000G6_A59PASAJEROS_CARGA ;
      private String[] P000G6_A58PASAJEROS_ESCLUSA ;
      private long[] P000G6_A61PASAJEROS_TON_TARIFA ;
      private bool[] P000G6_n61PASAJEROS_TON_TARIFA ;
      private decimal[] P000G6_A62PASAJEROS_TARIFA ;
      private short[] P000G6_A65PASAJEROS_ID_TON_TARIF ;
      private short[] P000G6_A63PASAJEROS_ID ;
      private String[] P000G7_A60PASAJEROS_TIPO_TARIFA ;
      private String[] P000G7_A59PASAJEROS_CARGA ;
      private String[] P000G7_A58PASAJEROS_ESCLUSA ;
      private long[] P000G7_A61PASAJEROS_TON_TARIFA ;
      private bool[] P000G7_n61PASAJEROS_TON_TARIFA ;
      private decimal[] P000G7_A62PASAJEROS_TARIFA ;
      private short[] P000G7_A65PASAJEROS_ID_TON_TARIF ;
      private short[] P000G7_A63PASAJEROS_ID ;
      private String[] P000G8_A60PASAJEROS_TIPO_TARIFA ;
      private String[] P000G8_A59PASAJEROS_CARGA ;
      private String[] P000G8_A58PASAJEROS_ESCLUSA ;
      private long[] P000G8_A61PASAJEROS_TON_TARIFA ;
      private bool[] P000G8_n61PASAJEROS_TON_TARIFA ;
      private decimal[] P000G8_A62PASAJEROS_TARIFA ;
      private short[] P000G8_A65PASAJEROS_ID_TON_TARIF ;
      private short[] P000G8_A63PASAJEROS_ID ;
      private String[] P000G9_A60PASAJEROS_TIPO_TARIFA ;
      private String[] P000G9_A59PASAJEROS_CARGA ;
      private String[] P000G9_A58PASAJEROS_ESCLUSA ;
      private long[] P000G9_A61PASAJEROS_TON_TARIFA ;
      private bool[] P000G9_n61PASAJEROS_TON_TARIFA ;
      private decimal[] P000G9_A62PASAJEROS_TARIFA ;
      private short[] P000G9_A65PASAJEROS_ID_TON_TARIF ;
      private short[] P000G9_A63PASAJEROS_ID ;
      private SdtSdtResultado aP3_SdtResultado ;
      private SdtSdtResultado AV13SdtResultado ;
   }

   public class calcularpasajeros__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000G2 ;
          prmP000G2 = new Object[] {
          } ;
          Object[] prmP000G3 ;
          prmP000G3 = new Object[] {
          } ;
          Object[] prmP000G4 ;
          prmP000G4 = new Object[] {
          } ;
          Object[] prmP000G5 ;
          prmP000G5 = new Object[] {
          } ;
          Object[] prmP000G6 ;
          prmP000G6 = new Object[] {
          } ;
          Object[] prmP000G7 ;
          prmP000G7 = new Object[] {
          } ;
          Object[] prmP000G8 ;
          prmP000G8 = new Object[] {
          } ;
          Object[] prmP000G9 ;
          prmP000G9 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P000G2", "SELECT TOP 1 [PASAJEROS_ESCLUSA], [PASAJEROS_CARGA], [PASAJEROS_TIPO_TARIFA], [PASAJEROS_TARIFA], [PASAJEROS_ID] FROM [PASAJEROS] WITH (NOLOCK) WHERE ([PASAJEROS_TIPO_TARIFA] = 'LITERA') AND ([PASAJEROS_CARGA] = 'Laden') AND ([PASAJEROS_ESCLUSA] = 'Panamax') ORDER BY [PASAJEROS_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000G2,1,0,false,true )
             ,new CursorDef("P000G3", "SELECT TOP 1 [PASAJEROS_ESCLUSA], [PASAJEROS_CARGA], [PASAJEROS_TIPO_TARIFA], [PASAJEROS_TARIFA], [PASAJEROS_ID] FROM [PASAJEROS] WITH (NOLOCK) WHERE ([PASAJEROS_TIPO_TARIFA] = 'LITERA') AND ([PASAJEROS_CARGA] = 'Laden') AND ([PASAJEROS_ESCLUSA] = 'NeoPanamax') ORDER BY [PASAJEROS_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000G3,1,0,false,true )
             ,new CursorDef("P000G4", "SELECT TOP 1 [PASAJEROS_ESCLUSA], [PASAJEROS_CARGA], [PASAJEROS_TIPO_TARIFA], [PASAJEROS_TARIFA], [PASAJEROS_ID] FROM [PASAJEROS] WITH (NOLOCK) WHERE ([PASAJEROS_TIPO_TARIFA] = 'LITERA') AND ([PASAJEROS_CARGA] = 'Ballast') AND ([PASAJEROS_ESCLUSA] = 'Panamax') ORDER BY [PASAJEROS_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000G4,1,0,false,true )
             ,new CursorDef("P000G5", "SELECT TOP 1 [PASAJEROS_ESCLUSA], [PASAJEROS_CARGA], [PASAJEROS_TIPO_TARIFA], [PASAJEROS_TARIFA], [PASAJEROS_ID] FROM [PASAJEROS] WITH (NOLOCK) WHERE ([PASAJEROS_TIPO_TARIFA] = 'LITERA') AND ([PASAJEROS_CARGA] = 'Ballast') AND ([PASAJEROS_ESCLUSA] = 'NeoPanamax') ORDER BY [PASAJEROS_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000G5,1,0,false,true )
             ,new CursorDef("P000G6", "SELECT [PASAJEROS_TIPO_TARIFA], [PASAJEROS_CARGA], [PASAJEROS_ESCLUSA], [PASAJEROS_TON_TARIFA], [PASAJEROS_TARIFA], [PASAJEROS_ID_TON_TARIF], [PASAJEROS_ID] FROM [PASAJEROS] WITH (NOLOCK) WHERE ([PASAJEROS_TIPO_TARIFA] = 'CPSUAB') AND ([PASAJEROS_CARGA] = 'Laden') AND ([PASAJEROS_ESCLUSA] = 'Panamax') ORDER BY [PASAJEROS_ID_TON_TARIF] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000G6,100,0,false,false )
             ,new CursorDef("P000G7", "SELECT [PASAJEROS_TIPO_TARIFA], [PASAJEROS_CARGA], [PASAJEROS_ESCLUSA], [PASAJEROS_TON_TARIFA], [PASAJEROS_TARIFA], [PASAJEROS_ID_TON_TARIF], [PASAJEROS_ID] FROM [PASAJEROS] WITH (NOLOCK) WHERE ([PASAJEROS_TIPO_TARIFA] = 'CPSUAB') AND ([PASAJEROS_CARGA] = 'Laden') AND ([PASAJEROS_ESCLUSA] = 'NeoPanamax') ORDER BY [PASAJEROS_ID_TON_TARIF] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000G7,100,0,false,false )
             ,new CursorDef("P000G8", "SELECT [PASAJEROS_TIPO_TARIFA], [PASAJEROS_CARGA], [PASAJEROS_ESCLUSA], [PASAJEROS_TON_TARIFA], [PASAJEROS_TARIFA], [PASAJEROS_ID_TON_TARIF], [PASAJEROS_ID] FROM [PASAJEROS] WITH (NOLOCK) WHERE ([PASAJEROS_TIPO_TARIFA] = 'CPSUAB') AND ([PASAJEROS_CARGA] = 'Ballast') AND ([PASAJEROS_ESCLUSA] = 'Panamax') ORDER BY [PASAJEROS_ID_TON_TARIF] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000G8,100,0,false,false )
             ,new CursorDef("P000G9", "SELECT [PASAJEROS_TIPO_TARIFA], [PASAJEROS_CARGA], [PASAJEROS_ESCLUSA], [PASAJEROS_TON_TARIFA], [PASAJEROS_TARIFA], [PASAJEROS_ID_TON_TARIF], [PASAJEROS_ID] FROM [PASAJEROS] WITH (NOLOCK) WHERE ([PASAJEROS_TIPO_TARIFA] = 'CPSUAB') AND ([PASAJEROS_CARGA] = 'Ballast') AND ([PASAJEROS_ESCLUSA] = 'NeoPanamax') ORDER BY [PASAJEROS_ID_TON_TARIF] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000G9,100,0,false,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((short[]) buf[7])[0] = rslt.getShort(7) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((short[]) buf[7])[0] = rslt.getShort(7) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((short[]) buf[7])[0] = rslt.getShort(7) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((short[]) buf[7])[0] = rslt.getShort(7) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

}
