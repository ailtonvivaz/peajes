/*
               File: CalcularPortacontenedores
        Description: Calcular Portacontenedores
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:14:55.32
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
   public class calcularportacontenedores : GXProcedure
   {
      public calcularportacontenedores( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public calcularportacontenedores( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( decimal aP0_CapacidadDeContenedores ,
                           decimal aP1_CargaTEU ,
                           out SdtSdtResultadoPortaContenedores aP2_SdtResultado )
      {
         this.AV11CapacidadDeContenedores = aP0_CapacidadDeContenedores;
         this.AV12CargaTEU = aP1_CargaTEU;
         this.AV13SdtResultado = new SdtSdtResultadoPortaContenedores(context) ;
         initialize();
         executePrivate();
         aP2_SdtResultado=this.AV13SdtResultado;
      }

      public SdtSdtResultadoPortaContenedores executeUdp( decimal aP0_CapacidadDeContenedores ,
                                                          decimal aP1_CargaTEU )
      {
         this.AV11CapacidadDeContenedores = aP0_CapacidadDeContenedores;
         this.AV12CargaTEU = aP1_CargaTEU;
         this.AV13SdtResultado = new SdtSdtResultadoPortaContenedores(context) ;
         initialize();
         executePrivate();
         aP2_SdtResultado=this.AV13SdtResultado;
         return AV13SdtResultado ;
      }

      public void executeSubmit( decimal aP0_CapacidadDeContenedores ,
                                 decimal aP1_CargaTEU ,
                                 out SdtSdtResultadoPortaContenedores aP2_SdtResultado )
      {
         calcularportacontenedores objcalcularportacontenedores;
         objcalcularportacontenedores = new calcularportacontenedores();
         objcalcularportacontenedores.AV11CapacidadDeContenedores = aP0_CapacidadDeContenedores;
         objcalcularportacontenedores.AV12CargaTEU = aP1_CargaTEU;
         objcalcularportacontenedores.AV13SdtResultado = new SdtSdtResultadoPortaContenedores(context) ;
         objcalcularportacontenedores.context.SetSubmitInitialConfig(context);
         objcalcularportacontenedores.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objcalcularportacontenedores);
         aP2_SdtResultado=this.AV13SdtResultado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((calcularportacontenedores)stateInfo).executePrivate();
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
         AV18CalculoTTA = 0;
         AV19CalculoTEU = 0;
         AV20CalculoValorTotal = 0;
         AV14PortaTarifaTTA4 = 0;
         AV17PortaTarifaTEU4 = 0;
         if ( ( AV12CargaTEU < Convert.ToDecimal( 6000 )) )
         {
            /* Using cursor P00012 */
            pr_default.execute(0, new Object[] {AV12CargaTEU});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A26PortaRangoFinTEU = P00012_A26PortaRangoFinTEU[0];
               A25PortaRangoIniTEU = P00012_A25PortaRangoIniTEU[0];
               A22PortaContenedoresEsclusa = P00012_A22PortaContenedoresEsclusa[0];
               A27PortaTarifaTTA4 = P00012_A27PortaTarifaTTA4[0];
               A28PortaTarifaTEU4 = P00012_A28PortaTarifaTEU4[0];
               A24PortaRango = P00012_A24PortaRango[0];
               AV14PortaTarifaTTA4 = A27PortaTarifaTTA4;
               AV17PortaTarifaTEU4 = A28PortaTarifaTEU4;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(0);
            }
            pr_default.close(0);
            AV18CalculoTTA = (decimal)(AV11CapacidadDeContenedores*AV14PortaTarifaTTA4);
            AV19CalculoTEU = (decimal)(AV12CargaTEU*AV17PortaTarifaTEU4);
            AV20CalculoValorTotal = (decimal)(AV18CalculoTTA+AV19CalculoTEU);
            AV13SdtResultado.gxTpr_Sdtresultadopanamax = AV20CalculoValorTotal;
         }
         /* Using cursor P00013 */
         pr_default.execute(1, new Object[] {AV11CapacidadDeContenedores});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A26PortaRangoFinTEU = P00013_A26PortaRangoFinTEU[0];
            A25PortaRangoIniTEU = P00013_A25PortaRangoIniTEU[0];
            A22PortaContenedoresEsclusa = P00013_A22PortaContenedoresEsclusa[0];
            A27PortaTarifaTTA4 = P00013_A27PortaTarifaTTA4[0];
            A28PortaTarifaTEU4 = P00013_A28PortaTarifaTEU4[0];
            A24PortaRango = P00013_A24PortaRango[0];
            AV14PortaTarifaTTA4 = A27PortaTarifaTTA4;
            AV17PortaTarifaTEU4 = A28PortaTarifaTEU4;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(1);
         }
         pr_default.close(1);
         AV18CalculoTTA = (decimal)(AV11CapacidadDeContenedores*AV14PortaTarifaTTA4);
         AV19CalculoTEU = (decimal)(AV12CargaTEU*AV17PortaTarifaTEU4);
         AV20CalculoValorTotal = (decimal)(AV18CalculoTTA+AV19CalculoTEU);
         AV13SdtResultado.gxTpr_Sdtresultadoneopanamax = AV20CalculoValorTotal;
         AV18CalculoTTA = 0;
         AV19CalculoTEU = 0;
         AV20CalculoValorTotal = 0;
         AV14PortaTarifaTTA4 = 0;
         AV17PortaTarifaTEU4 = 0;
         if ( ( AV12CargaTEU < Convert.ToDecimal( 6000 )) )
         {
            /* Using cursor P00014 */
            pr_default.execute(2, new Object[] {AV12CargaTEU});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A26PortaRangoFinTEU = P00014_A26PortaRangoFinTEU[0];
               A25PortaRangoIniTEU = P00014_A25PortaRangoIniTEU[0];
               A22PortaContenedoresEsclusa = P00014_A22PortaContenedoresEsclusa[0];
               A29PortaTarifaTTA3 = P00014_A29PortaTarifaTTA3[0];
               A30PortaTarifaTEU3 = P00014_A30PortaTarifaTEU3[0];
               A24PortaRango = P00014_A24PortaRango[0];
               AV14PortaTarifaTTA4 = A29PortaTarifaTTA3;
               AV17PortaTarifaTEU4 = A30PortaTarifaTEU3;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(2);
            }
            pr_default.close(2);
            AV18CalculoTTA = (decimal)(AV11CapacidadDeContenedores*AV14PortaTarifaTTA4);
            AV19CalculoTEU = (decimal)(AV12CargaTEU*AV17PortaTarifaTEU4);
            AV20CalculoValorTotal = (decimal)(AV18CalculoTTA+AV19CalculoTEU);
            AV13SdtResultado.gxTpr_Sdtresultadopanamaxc3 = AV20CalculoValorTotal;
         }
         /* Using cursor P00015 */
         pr_default.execute(3, new Object[] {AV11CapacidadDeContenedores});
         while ( (pr_default.getStatus(3) != 101) )
         {
            A26PortaRangoFinTEU = P00015_A26PortaRangoFinTEU[0];
            A25PortaRangoIniTEU = P00015_A25PortaRangoIniTEU[0];
            A22PortaContenedoresEsclusa = P00015_A22PortaContenedoresEsclusa[0];
            A29PortaTarifaTTA3 = P00015_A29PortaTarifaTTA3[0];
            A30PortaTarifaTEU3 = P00015_A30PortaTarifaTEU3[0];
            A24PortaRango = P00015_A24PortaRango[0];
            AV14PortaTarifaTTA4 = A29PortaTarifaTTA3;
            AV17PortaTarifaTEU4 = A30PortaTarifaTEU3;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(3);
         }
         pr_default.close(3);
         AV18CalculoTTA = (decimal)(AV11CapacidadDeContenedores*AV14PortaTarifaTTA4);
         AV19CalculoTEU = (decimal)(AV12CargaTEU*AV17PortaTarifaTEU4);
         AV20CalculoValorTotal = (decimal)(AV18CalculoTTA+AV19CalculoTEU);
         AV13SdtResultado.gxTpr_Sdtresultadoneopanamaxc3 = AV20CalculoValorTotal;
         AV18CalculoTTA = 0;
         AV19CalculoTEU = 0;
         AV20CalculoValorTotal = 0;
         AV14PortaTarifaTTA4 = 0;
         AV17PortaTarifaTEU4 = 0;
         if ( ( AV12CargaTEU < Convert.ToDecimal( 6000 )) )
         {
            /* Using cursor P00016 */
            pr_default.execute(4, new Object[] {AV12CargaTEU});
            while ( (pr_default.getStatus(4) != 101) )
            {
               A26PortaRangoFinTEU = P00016_A26PortaRangoFinTEU[0];
               A25PortaRangoIniTEU = P00016_A25PortaRangoIniTEU[0];
               A22PortaContenedoresEsclusa = P00016_A22PortaContenedoresEsclusa[0];
               A31PortaTarifaTTA2 = P00016_A31PortaTarifaTTA2[0];
               A32PortaTarifaTEU2 = P00016_A32PortaTarifaTEU2[0];
               A24PortaRango = P00016_A24PortaRango[0];
               AV14PortaTarifaTTA4 = A31PortaTarifaTTA2;
               AV17PortaTarifaTEU4 = A32PortaTarifaTEU2;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(4);
            }
            pr_default.close(4);
            AV18CalculoTTA = (decimal)(AV11CapacidadDeContenedores*AV14PortaTarifaTTA4);
            AV19CalculoTEU = (decimal)(AV12CargaTEU*AV17PortaTarifaTEU4);
            AV20CalculoValorTotal = (decimal)(AV18CalculoTTA+AV19CalculoTEU);
            AV13SdtResultado.gxTpr_Sdtresultadopanamaxc2 = AV20CalculoValorTotal;
         }
         /* Using cursor P00017 */
         pr_default.execute(5, new Object[] {AV11CapacidadDeContenedores});
         while ( (pr_default.getStatus(5) != 101) )
         {
            A26PortaRangoFinTEU = P00017_A26PortaRangoFinTEU[0];
            A25PortaRangoIniTEU = P00017_A25PortaRangoIniTEU[0];
            A22PortaContenedoresEsclusa = P00017_A22PortaContenedoresEsclusa[0];
            A31PortaTarifaTTA2 = P00017_A31PortaTarifaTTA2[0];
            A32PortaTarifaTEU2 = P00017_A32PortaTarifaTEU2[0];
            A24PortaRango = P00017_A24PortaRango[0];
            AV14PortaTarifaTTA4 = A31PortaTarifaTTA2;
            AV17PortaTarifaTEU4 = A32PortaTarifaTEU2;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(5);
         }
         pr_default.close(5);
         AV18CalculoTTA = (decimal)(AV11CapacidadDeContenedores*AV14PortaTarifaTTA4);
         AV19CalculoTEU = (decimal)(AV12CargaTEU*AV17PortaTarifaTEU4);
         AV20CalculoValorTotal = (decimal)(AV18CalculoTTA+AV19CalculoTEU);
         AV13SdtResultado.gxTpr_Sdtresultadoneopanamaxc2 = AV20CalculoValorTotal;
         AV18CalculoTTA = 0;
         AV19CalculoTEU = 0;
         AV20CalculoValorTotal = 0;
         AV14PortaTarifaTTA4 = 0;
         AV17PortaTarifaTEU4 = 0;
         if ( ( AV12CargaTEU < Convert.ToDecimal( 6000 )) )
         {
            /* Using cursor P00018 */
            pr_default.execute(6, new Object[] {AV12CargaTEU});
            while ( (pr_default.getStatus(6) != 101) )
            {
               A26PortaRangoFinTEU = P00018_A26PortaRangoFinTEU[0];
               A25PortaRangoIniTEU = P00018_A25PortaRangoIniTEU[0];
               A22PortaContenedoresEsclusa = P00018_A22PortaContenedoresEsclusa[0];
               A33PortaTarifaTTA1 = P00018_A33PortaTarifaTTA1[0];
               A34PortaTarifaTEU1 = P00018_A34PortaTarifaTEU1[0];
               A24PortaRango = P00018_A24PortaRango[0];
               AV14PortaTarifaTTA4 = A33PortaTarifaTTA1;
               AV17PortaTarifaTEU4 = A34PortaTarifaTEU1;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(6);
            }
            pr_default.close(6);
            AV18CalculoTTA = (decimal)(AV11CapacidadDeContenedores*AV14PortaTarifaTTA4);
            AV19CalculoTEU = (decimal)(AV12CargaTEU*AV17PortaTarifaTEU4);
            AV20CalculoValorTotal = (decimal)(AV18CalculoTTA+AV19CalculoTEU);
            AV13SdtResultado.gxTpr_Sdtresultadopanamaxc1 = AV20CalculoValorTotal;
         }
         /* Using cursor P00019 */
         pr_default.execute(7, new Object[] {AV11CapacidadDeContenedores});
         while ( (pr_default.getStatus(7) != 101) )
         {
            A26PortaRangoFinTEU = P00019_A26PortaRangoFinTEU[0];
            A25PortaRangoIniTEU = P00019_A25PortaRangoIniTEU[0];
            A22PortaContenedoresEsclusa = P00019_A22PortaContenedoresEsclusa[0];
            A33PortaTarifaTTA1 = P00019_A33PortaTarifaTTA1[0];
            A34PortaTarifaTEU1 = P00019_A34PortaTarifaTEU1[0];
            A24PortaRango = P00019_A24PortaRango[0];
            AV14PortaTarifaTTA4 = A33PortaTarifaTTA1;
            AV17PortaTarifaTEU4 = A34PortaTarifaTEU1;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(7);
         }
         pr_default.close(7);
         AV18CalculoTTA = (decimal)(AV11CapacidadDeContenedores*AV14PortaTarifaTTA4);
         AV19CalculoTEU = (decimal)(AV12CargaTEU*AV17PortaTarifaTEU4);
         AV20CalculoValorTotal = (decimal)(AV18CalculoTTA+AV19CalculoTEU);
         AV13SdtResultado.gxTpr_Sdtresultadoneopanamaxc1 = AV20CalculoValorTotal;
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
         P00012_A26PortaRangoFinTEU = new long[1] ;
         P00012_A25PortaRangoIniTEU = new long[1] ;
         P00012_A22PortaContenedoresEsclusa = new short[1] ;
         P00012_A27PortaTarifaTTA4 = new decimal[1] ;
         P00012_A28PortaTarifaTEU4 = new decimal[1] ;
         P00012_A24PortaRango = new short[1] ;
         P00013_A26PortaRangoFinTEU = new long[1] ;
         P00013_A25PortaRangoIniTEU = new long[1] ;
         P00013_A22PortaContenedoresEsclusa = new short[1] ;
         P00013_A27PortaTarifaTTA4 = new decimal[1] ;
         P00013_A28PortaTarifaTEU4 = new decimal[1] ;
         P00013_A24PortaRango = new short[1] ;
         P00014_A26PortaRangoFinTEU = new long[1] ;
         P00014_A25PortaRangoIniTEU = new long[1] ;
         P00014_A22PortaContenedoresEsclusa = new short[1] ;
         P00014_A29PortaTarifaTTA3 = new decimal[1] ;
         P00014_A30PortaTarifaTEU3 = new decimal[1] ;
         P00014_A24PortaRango = new short[1] ;
         P00015_A26PortaRangoFinTEU = new long[1] ;
         P00015_A25PortaRangoIniTEU = new long[1] ;
         P00015_A22PortaContenedoresEsclusa = new short[1] ;
         P00015_A29PortaTarifaTTA3 = new decimal[1] ;
         P00015_A30PortaTarifaTEU3 = new decimal[1] ;
         P00015_A24PortaRango = new short[1] ;
         P00016_A26PortaRangoFinTEU = new long[1] ;
         P00016_A25PortaRangoIniTEU = new long[1] ;
         P00016_A22PortaContenedoresEsclusa = new short[1] ;
         P00016_A31PortaTarifaTTA2 = new decimal[1] ;
         P00016_A32PortaTarifaTEU2 = new decimal[1] ;
         P00016_A24PortaRango = new short[1] ;
         P00017_A26PortaRangoFinTEU = new long[1] ;
         P00017_A25PortaRangoIniTEU = new long[1] ;
         P00017_A22PortaContenedoresEsclusa = new short[1] ;
         P00017_A31PortaTarifaTTA2 = new decimal[1] ;
         P00017_A32PortaTarifaTEU2 = new decimal[1] ;
         P00017_A24PortaRango = new short[1] ;
         P00018_A26PortaRangoFinTEU = new long[1] ;
         P00018_A25PortaRangoIniTEU = new long[1] ;
         P00018_A22PortaContenedoresEsclusa = new short[1] ;
         P00018_A33PortaTarifaTTA1 = new decimal[1] ;
         P00018_A34PortaTarifaTEU1 = new decimal[1] ;
         P00018_A24PortaRango = new short[1] ;
         P00019_A26PortaRangoFinTEU = new long[1] ;
         P00019_A25PortaRangoIniTEU = new long[1] ;
         P00019_A22PortaContenedoresEsclusa = new short[1] ;
         P00019_A33PortaTarifaTTA1 = new decimal[1] ;
         P00019_A34PortaTarifaTEU1 = new decimal[1] ;
         P00019_A24PortaRango = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.calcularportacontenedores__default(),
            new Object[][] {
                new Object[] {
               P00012_A26PortaRangoFinTEU, P00012_A25PortaRangoIniTEU, P00012_A22PortaContenedoresEsclusa, P00012_A27PortaTarifaTTA4, P00012_A28PortaTarifaTEU4, P00012_A24PortaRango
               }
               , new Object[] {
               P00013_A26PortaRangoFinTEU, P00013_A25PortaRangoIniTEU, P00013_A22PortaContenedoresEsclusa, P00013_A27PortaTarifaTTA4, P00013_A28PortaTarifaTEU4, P00013_A24PortaRango
               }
               , new Object[] {
               P00014_A26PortaRangoFinTEU, P00014_A25PortaRangoIniTEU, P00014_A22PortaContenedoresEsclusa, P00014_A29PortaTarifaTTA3, P00014_A30PortaTarifaTEU3, P00014_A24PortaRango
               }
               , new Object[] {
               P00015_A26PortaRangoFinTEU, P00015_A25PortaRangoIniTEU, P00015_A22PortaContenedoresEsclusa, P00015_A29PortaTarifaTTA3, P00015_A30PortaTarifaTEU3, P00015_A24PortaRango
               }
               , new Object[] {
               P00016_A26PortaRangoFinTEU, P00016_A25PortaRangoIniTEU, P00016_A22PortaContenedoresEsclusa, P00016_A31PortaTarifaTTA2, P00016_A32PortaTarifaTEU2, P00016_A24PortaRango
               }
               , new Object[] {
               P00017_A26PortaRangoFinTEU, P00017_A25PortaRangoIniTEU, P00017_A22PortaContenedoresEsclusa, P00017_A31PortaTarifaTTA2, P00017_A32PortaTarifaTEU2, P00017_A24PortaRango
               }
               , new Object[] {
               P00018_A26PortaRangoFinTEU, P00018_A25PortaRangoIniTEU, P00018_A22PortaContenedoresEsclusa, P00018_A33PortaTarifaTTA1, P00018_A34PortaTarifaTEU1, P00018_A24PortaRango
               }
               , new Object[] {
               P00019_A26PortaRangoFinTEU, P00019_A25PortaRangoIniTEU, P00019_A22PortaContenedoresEsclusa, P00019_A33PortaTarifaTTA1, P00019_A34PortaTarifaTEU1, P00019_A24PortaRango
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A22PortaContenedoresEsclusa ;
      private short A24PortaRango ;
      private long A26PortaRangoFinTEU ;
      private long A25PortaRangoIniTEU ;
      private decimal AV11CapacidadDeContenedores ;
      private decimal AV12CargaTEU ;
      private decimal AV18CalculoTTA ;
      private decimal AV19CalculoTEU ;
      private decimal AV20CalculoValorTotal ;
      private decimal AV14PortaTarifaTTA4 ;
      private decimal AV17PortaTarifaTEU4 ;
      private decimal A27PortaTarifaTTA4 ;
      private decimal A28PortaTarifaTEU4 ;
      private decimal A29PortaTarifaTTA3 ;
      private decimal A30PortaTarifaTEU3 ;
      private decimal A31PortaTarifaTTA2 ;
      private decimal A32PortaTarifaTEU2 ;
      private decimal A33PortaTarifaTTA1 ;
      private decimal A34PortaTarifaTEU1 ;
      private String scmdbuf ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00012_A26PortaRangoFinTEU ;
      private long[] P00012_A25PortaRangoIniTEU ;
      private short[] P00012_A22PortaContenedoresEsclusa ;
      private decimal[] P00012_A27PortaTarifaTTA4 ;
      private decimal[] P00012_A28PortaTarifaTEU4 ;
      private short[] P00012_A24PortaRango ;
      private long[] P00013_A26PortaRangoFinTEU ;
      private long[] P00013_A25PortaRangoIniTEU ;
      private short[] P00013_A22PortaContenedoresEsclusa ;
      private decimal[] P00013_A27PortaTarifaTTA4 ;
      private decimal[] P00013_A28PortaTarifaTEU4 ;
      private short[] P00013_A24PortaRango ;
      private long[] P00014_A26PortaRangoFinTEU ;
      private long[] P00014_A25PortaRangoIniTEU ;
      private short[] P00014_A22PortaContenedoresEsclusa ;
      private decimal[] P00014_A29PortaTarifaTTA3 ;
      private decimal[] P00014_A30PortaTarifaTEU3 ;
      private short[] P00014_A24PortaRango ;
      private long[] P00015_A26PortaRangoFinTEU ;
      private long[] P00015_A25PortaRangoIniTEU ;
      private short[] P00015_A22PortaContenedoresEsclusa ;
      private decimal[] P00015_A29PortaTarifaTTA3 ;
      private decimal[] P00015_A30PortaTarifaTEU3 ;
      private short[] P00015_A24PortaRango ;
      private long[] P00016_A26PortaRangoFinTEU ;
      private long[] P00016_A25PortaRangoIniTEU ;
      private short[] P00016_A22PortaContenedoresEsclusa ;
      private decimal[] P00016_A31PortaTarifaTTA2 ;
      private decimal[] P00016_A32PortaTarifaTEU2 ;
      private short[] P00016_A24PortaRango ;
      private long[] P00017_A26PortaRangoFinTEU ;
      private long[] P00017_A25PortaRangoIniTEU ;
      private short[] P00017_A22PortaContenedoresEsclusa ;
      private decimal[] P00017_A31PortaTarifaTTA2 ;
      private decimal[] P00017_A32PortaTarifaTEU2 ;
      private short[] P00017_A24PortaRango ;
      private long[] P00018_A26PortaRangoFinTEU ;
      private long[] P00018_A25PortaRangoIniTEU ;
      private short[] P00018_A22PortaContenedoresEsclusa ;
      private decimal[] P00018_A33PortaTarifaTTA1 ;
      private decimal[] P00018_A34PortaTarifaTEU1 ;
      private short[] P00018_A24PortaRango ;
      private long[] P00019_A26PortaRangoFinTEU ;
      private long[] P00019_A25PortaRangoIniTEU ;
      private short[] P00019_A22PortaContenedoresEsclusa ;
      private decimal[] P00019_A33PortaTarifaTTA1 ;
      private decimal[] P00019_A34PortaTarifaTEU1 ;
      private short[] P00019_A24PortaRango ;
      private SdtSdtResultadoPortaContenedores aP2_SdtResultado ;
      private SdtSdtResultadoPortaContenedores AV13SdtResultado ;
   }

   public class calcularportacontenedores__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00012 ;
          prmP00012 = new Object[] {
          new Object[] {"@AV12CargaTEU",SqlDbType.Decimal,12,2}
          } ;
          Object[] prmP00013 ;
          prmP00013 = new Object[] {
          new Object[] {"@AV11CapacidadDeContenedores",SqlDbType.Decimal,12,2}
          } ;
          Object[] prmP00014 ;
          prmP00014 = new Object[] {
          new Object[] {"@AV12CargaTEU",SqlDbType.Decimal,12,2}
          } ;
          Object[] prmP00015 ;
          prmP00015 = new Object[] {
          new Object[] {"@AV11CapacidadDeContenedores",SqlDbType.Decimal,12,2}
          } ;
          Object[] prmP00016 ;
          prmP00016 = new Object[] {
          new Object[] {"@AV12CargaTEU",SqlDbType.Decimal,12,2}
          } ;
          Object[] prmP00017 ;
          prmP00017 = new Object[] {
          new Object[] {"@AV11CapacidadDeContenedores",SqlDbType.Decimal,12,2}
          } ;
          Object[] prmP00018 ;
          prmP00018 = new Object[] {
          new Object[] {"@AV12CargaTEU",SqlDbType.Decimal,12,2}
          } ;
          Object[] prmP00019 ;
          prmP00019 = new Object[] {
          new Object[] {"@AV11CapacidadDeContenedores",SqlDbType.Decimal,12,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00012", "SELECT TOP 1 [PortaRangoFinTEU], [PortaRangoIniTEU], [PortaContenedoresEsclusa], [PortaTarifaTTA4], [PortaTarifaTEU4], [PortaRango] FROM [PortaContenedoresRango] WITH (NOLOCK) WHERE ([PortaContenedoresEsclusa] = 1) AND (@AV12CargaTEU >= [PortaRangoIniTEU] and @AV12CargaTEU < [PortaRangoFinTEU]) ORDER BY [PortaContenedoresEsclusa], [PortaRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00012,1,0,false,true )
             ,new CursorDef("P00013", "SELECT TOP 1 [PortaRangoFinTEU], [PortaRangoIniTEU], [PortaContenedoresEsclusa], [PortaTarifaTTA4], [PortaTarifaTEU4], [PortaRango] FROM [PortaContenedoresRango] WITH (NOLOCK) WHERE ([PortaContenedoresEsclusa] = 2) AND (@AV11CapacidadDeContenedores >= [PortaRangoIniTEU] and @AV11CapacidadDeContenedores < [PortaRangoFinTEU]) ORDER BY [PortaContenedoresEsclusa], [PortaRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00013,1,0,false,true )
             ,new CursorDef("P00014", "SELECT TOP 1 [PortaRangoFinTEU], [PortaRangoIniTEU], [PortaContenedoresEsclusa], [PortaTarifaTTA3], [PortaTarifaTEU3], [PortaRango] FROM [PortaContenedoresRango] WITH (NOLOCK) WHERE ([PortaContenedoresEsclusa] = 1) AND (@AV12CargaTEU >= [PortaRangoIniTEU] and @AV12CargaTEU < [PortaRangoFinTEU]) ORDER BY [PortaContenedoresEsclusa], [PortaRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00014,1,0,false,true )
             ,new CursorDef("P00015", "SELECT TOP 1 [PortaRangoFinTEU], [PortaRangoIniTEU], [PortaContenedoresEsclusa], [PortaTarifaTTA3], [PortaTarifaTEU3], [PortaRango] FROM [PortaContenedoresRango] WITH (NOLOCK) WHERE ([PortaContenedoresEsclusa] = 2) AND (@AV11CapacidadDeContenedores >= [PortaRangoIniTEU] and @AV11CapacidadDeContenedores < [PortaRangoFinTEU]) ORDER BY [PortaContenedoresEsclusa], [PortaRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00015,1,0,false,true )
             ,new CursorDef("P00016", "SELECT TOP 1 [PortaRangoFinTEU], [PortaRangoIniTEU], [PortaContenedoresEsclusa], [PortaTarifaTTA2], [PortaTarifaTEU2], [PortaRango] FROM [PortaContenedoresRango] WITH (NOLOCK) WHERE ([PortaContenedoresEsclusa] = 1) AND (@AV12CargaTEU >= [PortaRangoIniTEU] and @AV12CargaTEU < [PortaRangoFinTEU]) ORDER BY [PortaContenedoresEsclusa], [PortaRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00016,1,0,false,true )
             ,new CursorDef("P00017", "SELECT TOP 1 [PortaRangoFinTEU], [PortaRangoIniTEU], [PortaContenedoresEsclusa], [PortaTarifaTTA2], [PortaTarifaTEU2], [PortaRango] FROM [PortaContenedoresRango] WITH (NOLOCK) WHERE ([PortaContenedoresEsclusa] = 2) AND (@AV11CapacidadDeContenedores >= [PortaRangoIniTEU] and @AV11CapacidadDeContenedores < [PortaRangoFinTEU]) ORDER BY [PortaContenedoresEsclusa], [PortaRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00017,1,0,false,true )
             ,new CursorDef("P00018", "SELECT TOP 1 [PortaRangoFinTEU], [PortaRangoIniTEU], [PortaContenedoresEsclusa], [PortaTarifaTTA1], [PortaTarifaTEU1], [PortaRango] FROM [PortaContenedoresRango] WITH (NOLOCK) WHERE ([PortaContenedoresEsclusa] = 1) AND (@AV12CargaTEU >= [PortaRangoIniTEU] and @AV12CargaTEU < [PortaRangoFinTEU]) ORDER BY [PortaContenedoresEsclusa], [PortaRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00018,1,0,false,true )
             ,new CursorDef("P00019", "SELECT TOP 1 [PortaRangoFinTEU], [PortaRangoIniTEU], [PortaContenedoresEsclusa], [PortaTarifaTTA1], [PortaTarifaTEU1], [PortaRango] FROM [PortaContenedoresRango] WITH (NOLOCK) WHERE ([PortaContenedoresEsclusa] = 2) AND (@AV11CapacidadDeContenedores >= [PortaRangoIniTEU] and @AV11CapacidadDeContenedores < [PortaRangoFinTEU]) ORDER BY [PortaContenedoresEsclusa], [PortaRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00019,1,0,false,true )
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
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
             case 2 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
             case 3 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
             case 4 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
             case 5 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
             case 6 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
             case 7 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (decimal)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (decimal)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (decimal)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (decimal)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (decimal)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (decimal)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (decimal)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (decimal)parms[0]);
                break;
       }
    }

 }

}
