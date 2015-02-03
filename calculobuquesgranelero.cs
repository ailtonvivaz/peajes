/*
               File: CalculoBuquesGranelero
        Description: Calculo Buques Granelero
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:14:56.20
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
   public class calculobuquesgranelero : GXProcedure
   {
      public calculobuquesgranelero( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public calculobuquesgranelero( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( decimal aP0_PGranos ,
                           decimal aP1_PCarbon ,
                           decimal aP2_PMHierro ,
                           decimal aP3_POtros ,
                           decimal aP4_DWT ,
                           out SdtSDTGraneleros aP5_SDTGraneleros )
      {
         this.AV16PGranos = aP0_PGranos;
         this.AV11PCarbon = aP1_PCarbon;
         this.AV17PMHierro = aP2_PMHierro;
         this.AV19POtros = aP3_POtros;
         this.AV9DWT = aP4_DWT;
         this.AV21SDTGraneleros = new SdtSDTGraneleros(context) ;
         initialize();
         executePrivate();
         aP5_SDTGraneleros=this.AV21SDTGraneleros;
      }

      public SdtSDTGraneleros executeUdp( decimal aP0_PGranos ,
                                          decimal aP1_PCarbon ,
                                          decimal aP2_PMHierro ,
                                          decimal aP3_POtros ,
                                          decimal aP4_DWT )
      {
         this.AV16PGranos = aP0_PGranos;
         this.AV11PCarbon = aP1_PCarbon;
         this.AV17PMHierro = aP2_PMHierro;
         this.AV19POtros = aP3_POtros;
         this.AV9DWT = aP4_DWT;
         this.AV21SDTGraneleros = new SdtSDTGraneleros(context) ;
         initialize();
         executePrivate();
         aP5_SDTGraneleros=this.AV21SDTGraneleros;
         return AV21SDTGraneleros ;
      }

      public void executeSubmit( decimal aP0_PGranos ,
                                 decimal aP1_PCarbon ,
                                 decimal aP2_PMHierro ,
                                 decimal aP3_POtros ,
                                 decimal aP4_DWT ,
                                 out SdtSDTGraneleros aP5_SDTGraneleros )
      {
         calculobuquesgranelero objcalculobuquesgranelero;
         objcalculobuquesgranelero = new calculobuquesgranelero();
         objcalculobuquesgranelero.AV16PGranos = aP0_PGranos;
         objcalculobuquesgranelero.AV11PCarbon = aP1_PCarbon;
         objcalculobuquesgranelero.AV17PMHierro = aP2_PMHierro;
         objcalculobuquesgranelero.AV19POtros = aP3_POtros;
         objcalculobuquesgranelero.AV9DWT = aP4_DWT;
         objcalculobuquesgranelero.AV21SDTGraneleros = new SdtSDTGraneleros(context) ;
         objcalculobuquesgranelero.context.SetSubmitInitialConfig(context);
         objcalculobuquesgranelero.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objcalculobuquesgranelero);
         aP5_SDTGraneleros=this.AV21SDTGraneleros;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((calculobuquesgranelero)stateInfo).executePrivate();
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
         AV13pctGranos = (decimal)((AV16PGranos*100)/ (decimal)(AV9DWT));
         AV12pctCarbon = (decimal)((AV11PCarbon*100)/ (decimal)(AV9DWT));
         AV14pctMHierro = (decimal)((AV17PMHierro*100)/ (decimal)(AV9DWT));
         AV15pctOtros = (decimal)((AV19POtros*100)/ (decimal)(AV9DWT));
         AV18PMT = (decimal)(AV16PGranos+AV11PCarbon+AV17PMHierro+AV19POtros);
         AV25TOTALDWT = AV9DWT;
         /* Using cursor P000F2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A54TarifasGranelesSecosTipoGranos = P000F2_A54TarifasGranelesSecosTipoGranos[0];
            A52TarifasGranelesSecosBandas = P000F2_A52TarifasGranelesSecosBandas[0];
            A55TarifasGranelesSecosTarifaS_DW = P000F2_A55TarifasGranelesSecosTarifaS_DW[0];
            A57TarifasGranelesSecosDescBandas = P000F2_A57TarifasGranelesSecosDescBandas[0];
            A51TarifasGranelesSecosCodPeaje = P000F2_A51TarifasGranelesSecosCodPeaje[0];
            if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
            {
               if ( A52TarifasGranelesSecosBandas != 1 )
               {
                  AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                  AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
               }
               else
               {
                  AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                  AV25TOTALDWT = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            else
            {
               AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
               AV25TOTALDWT = 0;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadolastre = AV28ValorACalcular;
         if ( ( AV16PGranos == Convert.ToDecimal( 0 )) && ( AV11PCarbon == Convert.ToDecimal( 0 )) && ( AV17PMHierro == Convert.ToDecimal( 0 )) && ( AV19POtros == Convert.ToDecimal( 0 )) )
         {
            AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadoneopanamax = AV28ValorACalcular;
            AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadopanamax = AV28ValorACalcular;
         }
         else
         {
            if ( ( AV13pctGranos > Convert.ToDecimal( 50 )) || ( AV12pctCarbon > Convert.ToDecimal( 50 )) || ( AV14pctMHierro > Convert.ToDecimal( 50 )) || ( AV15pctOtros > Convert.ToDecimal( 50 )) )
            {
               if ( ( AV13pctGranos > Convert.ToDecimal( 50 )) )
               {
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000F3 */
                  pr_default.execute(1);
                  while ( (pr_default.getStatus(1) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000F3_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000F3_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000F3_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000F3_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000F3_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000F3_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000F3_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(1);
                  }
                  pr_default.close(1);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadopanamax = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000F4 */
                  pr_default.execute(2);
                  while ( (pr_default.getStatus(2) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000F4_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000F4_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000F4_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000F4_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000F4_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000F4_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000F4_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(2);
                  }
                  pr_default.close(2);
                  AV29ValorACalcularDWT = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV27TOTALMT = AV18PMT;
                  /* Using cursor P000F5 */
                  pr_default.execute(3);
                  while ( (pr_default.getStatus(3) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000F5_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000F5_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000F5_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000F5_A52TarifasGranelesSecosBandas[0];
                     A56TarifasGranelesSecosTarifaS_Ca = P000F5_A56TarifasGranelesSecosTarifaS_Ca[0];
                     A57TarifasGranelesSecosDescBandas = P000F5_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000F5_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV27TOTALMT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = (decimal)(AV27TOTALMT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                        AV27TOTALMT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(3);
                  }
                  pr_default.close(3);
                  AV28ValorACalcular = (decimal)(AV28ValorACalcular+AV29ValorACalcularDWT);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadoneopanamax = AV28ValorACalcular;
               }
               if ( ( AV12pctCarbon > Convert.ToDecimal( 50 )) )
               {
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000F6 */
                  pr_default.execute(4);
                  while ( (pr_default.getStatus(4) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000F6_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000F6_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000F6_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000F6_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000F6_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000F6_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000F6_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(4);
                  }
                  pr_default.close(4);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadopanamax = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000F7 */
                  pr_default.execute(5);
                  while ( (pr_default.getStatus(5) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000F7_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000F7_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000F7_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000F7_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000F7_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000F7_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000F7_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(5);
                  }
                  pr_default.close(5);
                  AV29ValorACalcularDWT = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV27TOTALMT = AV18PMT;
                  /* Using cursor P000F8 */
                  pr_default.execute(6);
                  while ( (pr_default.getStatus(6) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000F8_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000F8_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000F8_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000F8_A52TarifasGranelesSecosBandas[0];
                     A56TarifasGranelesSecosTarifaS_Ca = P000F8_A56TarifasGranelesSecosTarifaS_Ca[0];
                     A57TarifasGranelesSecosDescBandas = P000F8_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000F8_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV27TOTALMT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = (decimal)(AV27TOTALMT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                        AV27TOTALMT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(6);
                  }
                  pr_default.close(6);
                  AV28ValorACalcular = (decimal)(AV28ValorACalcular+AV29ValorACalcularDWT);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadoneopanamax = AV28ValorACalcular;
               }
               if ( ( AV14pctMHierro > Convert.ToDecimal( 50 )) )
               {
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000F9 */
                  pr_default.execute(7);
                  while ( (pr_default.getStatus(7) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000F9_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000F9_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000F9_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000F9_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000F9_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000F9_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000F9_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(7);
                  }
                  pr_default.close(7);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadopanamax = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000F10 */
                  pr_default.execute(8);
                  while ( (pr_default.getStatus(8) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000F10_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000F10_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000F10_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000F10_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000F10_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000F10_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000F10_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(8);
                  }
                  pr_default.close(8);
                  AV29ValorACalcularDWT = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV27TOTALMT = AV18PMT;
                  /* Using cursor P000F11 */
                  pr_default.execute(9);
                  while ( (pr_default.getStatus(9) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000F11_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000F11_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000F11_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000F11_A52TarifasGranelesSecosBandas[0];
                     A56TarifasGranelesSecosTarifaS_Ca = P000F11_A56TarifasGranelesSecosTarifaS_Ca[0];
                     A57TarifasGranelesSecosDescBandas = P000F11_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000F11_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV27TOTALMT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = (decimal)(AV27TOTALMT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                        AV27TOTALMT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(9);
                  }
                  pr_default.close(9);
                  AV28ValorACalcular = (decimal)(AV28ValorACalcular+AV29ValorACalcularDWT);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadoneopanamax = AV28ValorACalcular;
               }
               if ( ( AV15pctOtros > Convert.ToDecimal( 50 )) )
               {
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000F12 */
                  pr_default.execute(10);
                  while ( (pr_default.getStatus(10) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000F12_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000F12_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000F12_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000F12_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000F12_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000F12_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000F12_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(10);
                  }
                  pr_default.close(10);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadopanamax = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000F13 */
                  pr_default.execute(11);
                  while ( (pr_default.getStatus(11) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000F13_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000F13_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000F13_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000F13_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000F13_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000F13_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000F13_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(11);
                  }
                  pr_default.close(11);
                  AV29ValorACalcularDWT = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV27TOTALMT = AV18PMT;
                  /* Using cursor P000F14 */
                  pr_default.execute(12);
                  while ( (pr_default.getStatus(12) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000F14_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000F14_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000F14_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000F14_A52TarifasGranelesSecosBandas[0];
                     A56TarifasGranelesSecosTarifaS_Ca = P000F14_A56TarifasGranelesSecosTarifaS_Ca[0];
                     A57TarifasGranelesSecosDescBandas = P000F14_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000F14_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV27TOTALMT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = (decimal)(AV27TOTALMT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                        AV27TOTALMT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(12);
                  }
                  pr_default.close(12);
                  AV28ValorACalcular = (decimal)(AV28ValorACalcular+AV29ValorACalcularDWT);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadoneopanamax = AV28ValorACalcular;
               }
            }
            AV8cont = 0;
            if ( ( AV13pctGranos == Convert.ToDecimal( 50 )) )
            {
               AV8cont = (short)(AV8cont+1);
            }
            if ( ( AV12pctCarbon == Convert.ToDecimal( 50 )) )
            {
               AV8cont = (short)(AV8cont+1);
            }
            if ( ( AV14pctMHierro == Convert.ToDecimal( 50 )) )
            {
               AV8cont = (short)(AV8cont+1);
            }
            if ( ( AV15pctOtros == Convert.ToDecimal( 50 )) )
            {
               AV8cont = (short)(AV8cont+1);
            }
            if ( AV8cont < 2 )
            {
               if ( ( AV13pctGranos <= Convert.ToDecimal( 50 )) && ( AV12pctCarbon <= Convert.ToDecimal( 50 )) && ( AV14pctMHierro <= Convert.ToDecimal( 50 )) && ( AV15pctOtros <= Convert.ToDecimal( 50 )) )
               {
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000F15 */
                  pr_default.execute(13);
                  while ( (pr_default.getStatus(13) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000F15_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000F15_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000F15_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000F15_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000F15_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000F15_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000F15_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(13);
                  }
                  pr_default.close(13);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadopanamax = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000F16 */
                  pr_default.execute(14);
                  while ( (pr_default.getStatus(14) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000F16_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000F16_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000F16_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000F16_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000F16_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000F16_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000F16_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(14);
                  }
                  pr_default.close(14);
                  AV29ValorACalcularDWT = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV27TOTALMT = AV18PMT;
                  /* Using cursor P000F17 */
                  pr_default.execute(15);
                  while ( (pr_default.getStatus(15) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000F17_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000F17_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000F17_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000F17_A52TarifasGranelesSecosBandas[0];
                     A56TarifasGranelesSecosTarifaS_Ca = P000F17_A56TarifasGranelesSecosTarifaS_Ca[0];
                     A57TarifasGranelesSecosDescBandas = P000F17_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000F17_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV27TOTALMT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = (decimal)(AV27TOTALMT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                        AV27TOTALMT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(15);
                  }
                  pr_default.close(15);
                  AV28ValorACalcular = (decimal)(AV28ValorACalcular+AV29ValorACalcularDWT);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadoneopanamax = AV28ValorACalcular;
               }
            }
            else
            {
               if ( ( AV13pctGranos == Convert.ToDecimal( 50 )) || ( AV15pctOtros == Convert.ToDecimal( 50 )) )
               {
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000F18 */
                  pr_default.execute(16);
                  while ( (pr_default.getStatus(16) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000F18_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000F18_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000F18_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000F18_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000F18_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000F18_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000F18_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(16);
                  }
                  pr_default.close(16);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadopanamax = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000F19 */
                  pr_default.execute(17);
                  while ( (pr_default.getStatus(17) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000F19_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000F19_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000F19_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000F19_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000F19_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000F19_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000F19_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(17);
                  }
                  pr_default.close(17);
                  AV29ValorACalcularDWT = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV27TOTALMT = AV18PMT;
                  /* Using cursor P000F20 */
                  pr_default.execute(18);
                  while ( (pr_default.getStatus(18) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000F20_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000F20_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000F20_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000F20_A52TarifasGranelesSecosBandas[0];
                     A56TarifasGranelesSecosTarifaS_Ca = P000F20_A56TarifasGranelesSecosTarifaS_Ca[0];
                     A57TarifasGranelesSecosDescBandas = P000F20_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000F20_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV27TOTALMT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = (decimal)(AV27TOTALMT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                        AV27TOTALMT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(18);
                  }
                  pr_default.close(18);
                  AV28ValorACalcular = (decimal)(AV28ValorACalcular+AV29ValorACalcularDWT);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadoneopanamax = AV28ValorACalcular;
               }
               if ( ( AV12pctCarbon == Convert.ToDecimal( 50 )) && ( AV13pctGranos == Convert.ToDecimal( 0 )) && ( AV15pctOtros == Convert.ToDecimal( 0 )) )
               {
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000F21 */
                  pr_default.execute(19);
                  while ( (pr_default.getStatus(19) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000F21_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000F21_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000F21_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000F21_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000F21_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000F21_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000F21_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(19);
                  }
                  pr_default.close(19);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadopanamax = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV25TOTALDWT = AV9DWT;
                  /* Using cursor P000F22 */
                  pr_default.execute(20);
                  while ( (pr_default.getStatus(20) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000F22_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000F22_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000F22_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000F22_A52TarifasGranelesSecosBandas[0];
                     A55TarifasGranelesSecosTarifaS_DW = P000F22_A55TarifasGranelesSecosTarifaS_DW[0];
                     A57TarifasGranelesSecosDescBandas = P000F22_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000F22_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV25TOTALDWT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = (decimal)(AV25TOTALDWT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                           AV25TOTALDWT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV25TOTALDWT*A55TarifasGranelesSecosTarifaS_DW));
                        AV25TOTALDWT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(20);
                  }
                  pr_default.close(20);
                  AV29ValorACalcularDWT = AV28ValorACalcular;
                  AV28ValorACalcular = 0;
                  AV27TOTALMT = AV18PMT;
                  /* Using cursor P000F23 */
                  pr_default.execute(21);
                  while ( (pr_default.getStatus(21) != 101) )
                  {
                     A53TarifasGranelesSecosTipoEsclus = P000F23_A53TarifasGranelesSecosTipoEsclus[0];
                     n53TarifasGranelesSecosTipoEsclus = P000F23_n53TarifasGranelesSecosTipoEsclus[0];
                     A54TarifasGranelesSecosTipoGranos = P000F23_A54TarifasGranelesSecosTipoGranos[0];
                     A52TarifasGranelesSecosBandas = P000F23_A52TarifasGranelesSecosBandas[0];
                     A56TarifasGranelesSecosTarifaS_Ca = P000F23_A56TarifasGranelesSecosTarifaS_Ca[0];
                     A57TarifasGranelesSecosDescBandas = P000F23_A57TarifasGranelesSecosDescBandas[0];
                     A51TarifasGranelesSecosCodPeaje = P000F23_A51TarifasGranelesSecosCodPeaje[0];
                     if ( ( AV27TOTALMT >= Convert.ToDecimal( A52TarifasGranelesSecosBandas )) )
                     {
                        if ( A52TarifasGranelesSecosBandas != 1 )
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(A52TarifasGranelesSecosBandas*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = (decimal)(AV27TOTALMT-A52TarifasGranelesSecosBandas);
                        }
                        else
                        {
                           AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                           AV27TOTALMT = 0;
                           /* Exit For each command. Update data (if necessary), close cursors & exit. */
                           if (true) break;
                        }
                     }
                     else
                     {
                        AV28ValorACalcular = (decimal)(AV28ValorACalcular+(AV27TOTALMT*A56TarifasGranelesSecosTarifaS_Ca));
                        AV27TOTALMT = 0;
                        /* Exit For each command. Update data (if necessary), close cursors & exit. */
                        if (true) break;
                     }
                     pr_default.readNext(21);
                  }
                  pr_default.close(21);
                  AV28ValorACalcular = (decimal)(AV28ValorACalcular+AV29ValorACalcularDWT);
                  AV21SDTGraneleros.gxTpr_Sdtgranelerosresultadoneopanamax = AV28ValorACalcular;
               }
            }
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
         P000F2_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000F2_A52TarifasGranelesSecosBandas = new long[1] ;
         P000F2_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000F2_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000F2_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         A54TarifasGranelesSecosTipoGranos = "";
         A57TarifasGranelesSecosDescBandas = "";
         P000F3_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000F3_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000F3_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000F3_A52TarifasGranelesSecosBandas = new long[1] ;
         P000F3_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000F3_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000F3_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         A53TarifasGranelesSecosTipoEsclus = "";
         P000F4_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000F4_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000F4_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000F4_A52TarifasGranelesSecosBandas = new long[1] ;
         P000F4_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000F4_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000F4_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000F5_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000F5_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000F5_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000F5_A52TarifasGranelesSecosBandas = new long[1] ;
         P000F5_A56TarifasGranelesSecosTarifaS_Ca = new decimal[1] ;
         P000F5_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000F5_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000F6_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000F6_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000F6_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000F6_A52TarifasGranelesSecosBandas = new long[1] ;
         P000F6_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000F6_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000F6_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000F7_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000F7_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000F7_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000F7_A52TarifasGranelesSecosBandas = new long[1] ;
         P000F7_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000F7_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000F7_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000F8_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000F8_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000F8_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000F8_A52TarifasGranelesSecosBandas = new long[1] ;
         P000F8_A56TarifasGranelesSecosTarifaS_Ca = new decimal[1] ;
         P000F8_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000F8_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000F9_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000F9_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000F9_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000F9_A52TarifasGranelesSecosBandas = new long[1] ;
         P000F9_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000F9_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000F9_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000F10_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000F10_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000F10_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000F10_A52TarifasGranelesSecosBandas = new long[1] ;
         P000F10_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000F10_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000F10_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000F11_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000F11_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000F11_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000F11_A52TarifasGranelesSecosBandas = new long[1] ;
         P000F11_A56TarifasGranelesSecosTarifaS_Ca = new decimal[1] ;
         P000F11_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000F11_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000F12_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000F12_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000F12_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000F12_A52TarifasGranelesSecosBandas = new long[1] ;
         P000F12_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000F12_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000F12_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000F13_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000F13_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000F13_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000F13_A52TarifasGranelesSecosBandas = new long[1] ;
         P000F13_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000F13_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000F13_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000F14_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000F14_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000F14_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000F14_A52TarifasGranelesSecosBandas = new long[1] ;
         P000F14_A56TarifasGranelesSecosTarifaS_Ca = new decimal[1] ;
         P000F14_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000F14_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000F15_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000F15_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000F15_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000F15_A52TarifasGranelesSecosBandas = new long[1] ;
         P000F15_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000F15_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000F15_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000F16_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000F16_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000F16_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000F16_A52TarifasGranelesSecosBandas = new long[1] ;
         P000F16_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000F16_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000F16_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000F17_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000F17_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000F17_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000F17_A52TarifasGranelesSecosBandas = new long[1] ;
         P000F17_A56TarifasGranelesSecosTarifaS_Ca = new decimal[1] ;
         P000F17_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000F17_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000F18_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000F18_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000F18_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000F18_A52TarifasGranelesSecosBandas = new long[1] ;
         P000F18_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000F18_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000F18_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000F19_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000F19_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000F19_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000F19_A52TarifasGranelesSecosBandas = new long[1] ;
         P000F19_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000F19_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000F19_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000F20_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000F20_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000F20_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000F20_A52TarifasGranelesSecosBandas = new long[1] ;
         P000F20_A56TarifasGranelesSecosTarifaS_Ca = new decimal[1] ;
         P000F20_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000F20_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000F21_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000F21_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000F21_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000F21_A52TarifasGranelesSecosBandas = new long[1] ;
         P000F21_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000F21_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000F21_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000F22_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000F22_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000F22_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000F22_A52TarifasGranelesSecosBandas = new long[1] ;
         P000F22_A55TarifasGranelesSecosTarifaS_DW = new decimal[1] ;
         P000F22_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000F22_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         P000F23_A53TarifasGranelesSecosTipoEsclus = new String[] {""} ;
         P000F23_n53TarifasGranelesSecosTipoEsclus = new bool[] {false} ;
         P000F23_A54TarifasGranelesSecosTipoGranos = new String[] {""} ;
         P000F23_A52TarifasGranelesSecosBandas = new long[1] ;
         P000F23_A56TarifasGranelesSecosTarifaS_Ca = new decimal[1] ;
         P000F23_A57TarifasGranelesSecosDescBandas = new String[] {""} ;
         P000F23_A51TarifasGranelesSecosCodPeaje = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.calculobuquesgranelero__default(),
            new Object[][] {
                new Object[] {
               P000F2_A54TarifasGranelesSecosTipoGranos, P000F2_A52TarifasGranelesSecosBandas, P000F2_A55TarifasGranelesSecosTarifaS_DW, P000F2_A57TarifasGranelesSecosDescBandas, P000F2_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000F3_A53TarifasGranelesSecosTipoEsclus, P000F3_n53TarifasGranelesSecosTipoEsclus, P000F3_A54TarifasGranelesSecosTipoGranos, P000F3_A52TarifasGranelesSecosBandas, P000F3_A55TarifasGranelesSecosTarifaS_DW, P000F3_A57TarifasGranelesSecosDescBandas, P000F3_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000F4_A53TarifasGranelesSecosTipoEsclus, P000F4_n53TarifasGranelesSecosTipoEsclus, P000F4_A54TarifasGranelesSecosTipoGranos, P000F4_A52TarifasGranelesSecosBandas, P000F4_A55TarifasGranelesSecosTarifaS_DW, P000F4_A57TarifasGranelesSecosDescBandas, P000F4_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000F5_A53TarifasGranelesSecosTipoEsclus, P000F5_n53TarifasGranelesSecosTipoEsclus, P000F5_A54TarifasGranelesSecosTipoGranos, P000F5_A52TarifasGranelesSecosBandas, P000F5_A56TarifasGranelesSecosTarifaS_Ca, P000F5_A57TarifasGranelesSecosDescBandas, P000F5_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000F6_A53TarifasGranelesSecosTipoEsclus, P000F6_n53TarifasGranelesSecosTipoEsclus, P000F6_A54TarifasGranelesSecosTipoGranos, P000F6_A52TarifasGranelesSecosBandas, P000F6_A55TarifasGranelesSecosTarifaS_DW, P000F6_A57TarifasGranelesSecosDescBandas, P000F6_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000F7_A53TarifasGranelesSecosTipoEsclus, P000F7_n53TarifasGranelesSecosTipoEsclus, P000F7_A54TarifasGranelesSecosTipoGranos, P000F7_A52TarifasGranelesSecosBandas, P000F7_A55TarifasGranelesSecosTarifaS_DW, P000F7_A57TarifasGranelesSecosDescBandas, P000F7_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000F8_A53TarifasGranelesSecosTipoEsclus, P000F8_n53TarifasGranelesSecosTipoEsclus, P000F8_A54TarifasGranelesSecosTipoGranos, P000F8_A52TarifasGranelesSecosBandas, P000F8_A56TarifasGranelesSecosTarifaS_Ca, P000F8_A57TarifasGranelesSecosDescBandas, P000F8_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000F9_A53TarifasGranelesSecosTipoEsclus, P000F9_n53TarifasGranelesSecosTipoEsclus, P000F9_A54TarifasGranelesSecosTipoGranos, P000F9_A52TarifasGranelesSecosBandas, P000F9_A55TarifasGranelesSecosTarifaS_DW, P000F9_A57TarifasGranelesSecosDescBandas, P000F9_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000F10_A53TarifasGranelesSecosTipoEsclus, P000F10_n53TarifasGranelesSecosTipoEsclus, P000F10_A54TarifasGranelesSecosTipoGranos, P000F10_A52TarifasGranelesSecosBandas, P000F10_A55TarifasGranelesSecosTarifaS_DW, P000F10_A57TarifasGranelesSecosDescBandas, P000F10_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000F11_A53TarifasGranelesSecosTipoEsclus, P000F11_n53TarifasGranelesSecosTipoEsclus, P000F11_A54TarifasGranelesSecosTipoGranos, P000F11_A52TarifasGranelesSecosBandas, P000F11_A56TarifasGranelesSecosTarifaS_Ca, P000F11_A57TarifasGranelesSecosDescBandas, P000F11_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000F12_A53TarifasGranelesSecosTipoEsclus, P000F12_n53TarifasGranelesSecosTipoEsclus, P000F12_A54TarifasGranelesSecosTipoGranos, P000F12_A52TarifasGranelesSecosBandas, P000F12_A55TarifasGranelesSecosTarifaS_DW, P000F12_A57TarifasGranelesSecosDescBandas, P000F12_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000F13_A53TarifasGranelesSecosTipoEsclus, P000F13_n53TarifasGranelesSecosTipoEsclus, P000F13_A54TarifasGranelesSecosTipoGranos, P000F13_A52TarifasGranelesSecosBandas, P000F13_A55TarifasGranelesSecosTarifaS_DW, P000F13_A57TarifasGranelesSecosDescBandas, P000F13_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000F14_A53TarifasGranelesSecosTipoEsclus, P000F14_n53TarifasGranelesSecosTipoEsclus, P000F14_A54TarifasGranelesSecosTipoGranos, P000F14_A52TarifasGranelesSecosBandas, P000F14_A56TarifasGranelesSecosTarifaS_Ca, P000F14_A57TarifasGranelesSecosDescBandas, P000F14_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000F15_A53TarifasGranelesSecosTipoEsclus, P000F15_n53TarifasGranelesSecosTipoEsclus, P000F15_A54TarifasGranelesSecosTipoGranos, P000F15_A52TarifasGranelesSecosBandas, P000F15_A55TarifasGranelesSecosTarifaS_DW, P000F15_A57TarifasGranelesSecosDescBandas, P000F15_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000F16_A53TarifasGranelesSecosTipoEsclus, P000F16_n53TarifasGranelesSecosTipoEsclus, P000F16_A54TarifasGranelesSecosTipoGranos, P000F16_A52TarifasGranelesSecosBandas, P000F16_A55TarifasGranelesSecosTarifaS_DW, P000F16_A57TarifasGranelesSecosDescBandas, P000F16_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000F17_A53TarifasGranelesSecosTipoEsclus, P000F17_n53TarifasGranelesSecosTipoEsclus, P000F17_A54TarifasGranelesSecosTipoGranos, P000F17_A52TarifasGranelesSecosBandas, P000F17_A56TarifasGranelesSecosTarifaS_Ca, P000F17_A57TarifasGranelesSecosDescBandas, P000F17_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000F18_A53TarifasGranelesSecosTipoEsclus, P000F18_n53TarifasGranelesSecosTipoEsclus, P000F18_A54TarifasGranelesSecosTipoGranos, P000F18_A52TarifasGranelesSecosBandas, P000F18_A55TarifasGranelesSecosTarifaS_DW, P000F18_A57TarifasGranelesSecosDescBandas, P000F18_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000F19_A53TarifasGranelesSecosTipoEsclus, P000F19_n53TarifasGranelesSecosTipoEsclus, P000F19_A54TarifasGranelesSecosTipoGranos, P000F19_A52TarifasGranelesSecosBandas, P000F19_A55TarifasGranelesSecosTarifaS_DW, P000F19_A57TarifasGranelesSecosDescBandas, P000F19_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000F20_A53TarifasGranelesSecosTipoEsclus, P000F20_n53TarifasGranelesSecosTipoEsclus, P000F20_A54TarifasGranelesSecosTipoGranos, P000F20_A52TarifasGranelesSecosBandas, P000F20_A56TarifasGranelesSecosTarifaS_Ca, P000F20_A57TarifasGranelesSecosDescBandas, P000F20_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000F21_A53TarifasGranelesSecosTipoEsclus, P000F21_n53TarifasGranelesSecosTipoEsclus, P000F21_A54TarifasGranelesSecosTipoGranos, P000F21_A52TarifasGranelesSecosBandas, P000F21_A55TarifasGranelesSecosTarifaS_DW, P000F21_A57TarifasGranelesSecosDescBandas, P000F21_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000F22_A53TarifasGranelesSecosTipoEsclus, P000F22_n53TarifasGranelesSecosTipoEsclus, P000F22_A54TarifasGranelesSecosTipoGranos, P000F22_A52TarifasGranelesSecosBandas, P000F22_A55TarifasGranelesSecosTarifaS_DW, P000F22_A57TarifasGranelesSecosDescBandas, P000F22_A51TarifasGranelesSecosCodPeaje
               }
               , new Object[] {
               P000F23_A53TarifasGranelesSecosTipoEsclus, P000F23_n53TarifasGranelesSecosTipoEsclus, P000F23_A54TarifasGranelesSecosTipoGranos, P000F23_A52TarifasGranelesSecosBandas, P000F23_A56TarifasGranelesSecosTarifaS_Ca, P000F23_A57TarifasGranelesSecosDescBandas, P000F23_A51TarifasGranelesSecosCodPeaje
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8cont ;
      private long A52TarifasGranelesSecosBandas ;
      private long A51TarifasGranelesSecosCodPeaje ;
      private decimal AV16PGranos ;
      private decimal AV11PCarbon ;
      private decimal AV17PMHierro ;
      private decimal AV19POtros ;
      private decimal AV9DWT ;
      private decimal AV13pctGranos ;
      private decimal AV12pctCarbon ;
      private decimal AV14pctMHierro ;
      private decimal AV15pctOtros ;
      private decimal AV18PMT ;
      private decimal AV25TOTALDWT ;
      private decimal A55TarifasGranelesSecosTarifaS_DW ;
      private decimal AV28ValorACalcular ;
      private decimal AV29ValorACalcularDWT ;
      private decimal AV27TOTALMT ;
      private decimal A56TarifasGranelesSecosTarifaS_Ca ;
      private String scmdbuf ;
      private bool n53TarifasGranelesSecosTipoEsclus ;
      private String A54TarifasGranelesSecosTipoGranos ;
      private String A57TarifasGranelesSecosDescBandas ;
      private String A53TarifasGranelesSecosTipoEsclus ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000F2_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000F2_A52TarifasGranelesSecosBandas ;
      private decimal[] P000F2_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000F2_A57TarifasGranelesSecosDescBandas ;
      private long[] P000F2_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000F3_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000F3_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000F3_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000F3_A52TarifasGranelesSecosBandas ;
      private decimal[] P000F3_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000F3_A57TarifasGranelesSecosDescBandas ;
      private long[] P000F3_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000F4_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000F4_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000F4_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000F4_A52TarifasGranelesSecosBandas ;
      private decimal[] P000F4_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000F4_A57TarifasGranelesSecosDescBandas ;
      private long[] P000F4_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000F5_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000F5_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000F5_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000F5_A52TarifasGranelesSecosBandas ;
      private decimal[] P000F5_A56TarifasGranelesSecosTarifaS_Ca ;
      private String[] P000F5_A57TarifasGranelesSecosDescBandas ;
      private long[] P000F5_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000F6_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000F6_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000F6_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000F6_A52TarifasGranelesSecosBandas ;
      private decimal[] P000F6_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000F6_A57TarifasGranelesSecosDescBandas ;
      private long[] P000F6_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000F7_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000F7_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000F7_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000F7_A52TarifasGranelesSecosBandas ;
      private decimal[] P000F7_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000F7_A57TarifasGranelesSecosDescBandas ;
      private long[] P000F7_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000F8_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000F8_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000F8_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000F8_A52TarifasGranelesSecosBandas ;
      private decimal[] P000F8_A56TarifasGranelesSecosTarifaS_Ca ;
      private String[] P000F8_A57TarifasGranelesSecosDescBandas ;
      private long[] P000F8_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000F9_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000F9_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000F9_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000F9_A52TarifasGranelesSecosBandas ;
      private decimal[] P000F9_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000F9_A57TarifasGranelesSecosDescBandas ;
      private long[] P000F9_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000F10_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000F10_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000F10_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000F10_A52TarifasGranelesSecosBandas ;
      private decimal[] P000F10_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000F10_A57TarifasGranelesSecosDescBandas ;
      private long[] P000F10_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000F11_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000F11_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000F11_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000F11_A52TarifasGranelesSecosBandas ;
      private decimal[] P000F11_A56TarifasGranelesSecosTarifaS_Ca ;
      private String[] P000F11_A57TarifasGranelesSecosDescBandas ;
      private long[] P000F11_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000F12_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000F12_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000F12_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000F12_A52TarifasGranelesSecosBandas ;
      private decimal[] P000F12_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000F12_A57TarifasGranelesSecosDescBandas ;
      private long[] P000F12_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000F13_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000F13_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000F13_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000F13_A52TarifasGranelesSecosBandas ;
      private decimal[] P000F13_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000F13_A57TarifasGranelesSecosDescBandas ;
      private long[] P000F13_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000F14_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000F14_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000F14_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000F14_A52TarifasGranelesSecosBandas ;
      private decimal[] P000F14_A56TarifasGranelesSecosTarifaS_Ca ;
      private String[] P000F14_A57TarifasGranelesSecosDescBandas ;
      private long[] P000F14_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000F15_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000F15_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000F15_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000F15_A52TarifasGranelesSecosBandas ;
      private decimal[] P000F15_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000F15_A57TarifasGranelesSecosDescBandas ;
      private long[] P000F15_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000F16_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000F16_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000F16_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000F16_A52TarifasGranelesSecosBandas ;
      private decimal[] P000F16_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000F16_A57TarifasGranelesSecosDescBandas ;
      private long[] P000F16_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000F17_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000F17_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000F17_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000F17_A52TarifasGranelesSecosBandas ;
      private decimal[] P000F17_A56TarifasGranelesSecosTarifaS_Ca ;
      private String[] P000F17_A57TarifasGranelesSecosDescBandas ;
      private long[] P000F17_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000F18_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000F18_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000F18_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000F18_A52TarifasGranelesSecosBandas ;
      private decimal[] P000F18_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000F18_A57TarifasGranelesSecosDescBandas ;
      private long[] P000F18_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000F19_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000F19_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000F19_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000F19_A52TarifasGranelesSecosBandas ;
      private decimal[] P000F19_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000F19_A57TarifasGranelesSecosDescBandas ;
      private long[] P000F19_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000F20_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000F20_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000F20_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000F20_A52TarifasGranelesSecosBandas ;
      private decimal[] P000F20_A56TarifasGranelesSecosTarifaS_Ca ;
      private String[] P000F20_A57TarifasGranelesSecosDescBandas ;
      private long[] P000F20_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000F21_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000F21_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000F21_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000F21_A52TarifasGranelesSecosBandas ;
      private decimal[] P000F21_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000F21_A57TarifasGranelesSecosDescBandas ;
      private long[] P000F21_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000F22_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000F22_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000F22_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000F22_A52TarifasGranelesSecosBandas ;
      private decimal[] P000F22_A55TarifasGranelesSecosTarifaS_DW ;
      private String[] P000F22_A57TarifasGranelesSecosDescBandas ;
      private long[] P000F22_A51TarifasGranelesSecosCodPeaje ;
      private String[] P000F23_A53TarifasGranelesSecosTipoEsclus ;
      private bool[] P000F23_n53TarifasGranelesSecosTipoEsclus ;
      private String[] P000F23_A54TarifasGranelesSecosTipoGranos ;
      private long[] P000F23_A52TarifasGranelesSecosBandas ;
      private decimal[] P000F23_A56TarifasGranelesSecosTarifaS_Ca ;
      private String[] P000F23_A57TarifasGranelesSecosDescBandas ;
      private long[] P000F23_A51TarifasGranelesSecosCodPeaje ;
      private SdtSDTGraneleros aP5_SDTGraneleros ;
      private SdtSDTGraneleros AV21SDTGraneleros ;
   }

   public class calculobuquesgranelero__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000F2 ;
          prmP000F2 = new Object[] {
          } ;
          Object[] prmP000F3 ;
          prmP000F3 = new Object[] {
          } ;
          Object[] prmP000F4 ;
          prmP000F4 = new Object[] {
          } ;
          Object[] prmP000F5 ;
          prmP000F5 = new Object[] {
          } ;
          Object[] prmP000F6 ;
          prmP000F6 = new Object[] {
          } ;
          Object[] prmP000F7 ;
          prmP000F7 = new Object[] {
          } ;
          Object[] prmP000F8 ;
          prmP000F8 = new Object[] {
          } ;
          Object[] prmP000F9 ;
          prmP000F9 = new Object[] {
          } ;
          Object[] prmP000F10 ;
          prmP000F10 = new Object[] {
          } ;
          Object[] prmP000F11 ;
          prmP000F11 = new Object[] {
          } ;
          Object[] prmP000F12 ;
          prmP000F12 = new Object[] {
          } ;
          Object[] prmP000F13 ;
          prmP000F13 = new Object[] {
          } ;
          Object[] prmP000F14 ;
          prmP000F14 = new Object[] {
          } ;
          Object[] prmP000F15 ;
          prmP000F15 = new Object[] {
          } ;
          Object[] prmP000F16 ;
          prmP000F16 = new Object[] {
          } ;
          Object[] prmP000F17 ;
          prmP000F17 = new Object[] {
          } ;
          Object[] prmP000F18 ;
          prmP000F18 = new Object[] {
          } ;
          Object[] prmP000F19 ;
          prmP000F19 = new Object[] {
          } ;
          Object[] prmP000F20 ;
          prmP000F20 = new Object[] {
          } ;
          Object[] prmP000F21 ;
          prmP000F21 = new Object[] {
          } ;
          Object[] prmP000F22 ;
          prmP000F22 = new Object[] {
          } ;
          Object[] prmP000F23 ;
          prmP000F23 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P000F2", "SELECT [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE [TarifasGranelesSecosTipoGranos] = 'Lastre' ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F2,100,0,false,false )
             ,new CursorDef("P000F3", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'Panamax') AND ([TarifasGranelesSecosTipoGranos] = 'Granos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F3,100,0,false,false )
             ,new CursorDef("P000F4", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Granos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F4,100,0,false,false )
             ,new CursorDef("P000F5", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_Ca], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Granos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F5,100,0,false,false )
             ,new CursorDef("P000F6", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'Panamax') AND ([TarifasGranelesSecosTipoGranos] = 'Carbón') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F6,100,0,false,false )
             ,new CursorDef("P000F7", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Carbón') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F7,100,0,false,false )
             ,new CursorDef("P000F8", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_Ca], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Carbón') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F8,100,0,false,false )
             ,new CursorDef("P000F9", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'Panamax') AND ([TarifasGranelesSecosTipoGranos] = 'Mineral Hierro') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F9,100,0,false,false )
             ,new CursorDef("P000F10", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Mineral Hierro') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F10,100,0,false,false )
             ,new CursorDef("P000F11", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_Ca], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Mineral Hierro') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F11,100,0,false,false )
             ,new CursorDef("P000F12", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'Panamax') AND ([TarifasGranelesSecosTipoGranos] = 'Otros Graneles Secos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F12,100,0,false,false )
             ,new CursorDef("P000F13", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Otros Graneles Secos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F13,100,0,false,false )
             ,new CursorDef("P000F14", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_Ca], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Otros Graneles Secos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F14,100,0,false,false )
             ,new CursorDef("P000F15", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'Panamax') AND ([TarifasGranelesSecosTipoGranos] = 'Otros Graneles Secos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F15,100,0,false,false )
             ,new CursorDef("P000F16", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Otros Graneles Secos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F16,100,0,false,false )
             ,new CursorDef("P000F17", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_Ca], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Otros Graneles Secos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F17,100,0,false,false )
             ,new CursorDef("P000F18", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'Panamax') AND ([TarifasGranelesSecosTipoGranos] = 'Otros Graneles Secos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F18,100,0,false,false )
             ,new CursorDef("P000F19", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Otros Graneles Secos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F19,100,0,false,false )
             ,new CursorDef("P000F20", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_Ca], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Otros Graneles Secos') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F20,100,0,false,false )
             ,new CursorDef("P000F21", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'Panamax') AND ([TarifasGranelesSecosTipoGranos] = 'Carbón') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F21,100,0,false,false )
             ,new CursorDef("P000F22", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_DW], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Carbón') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F22,100,0,false,false )
             ,new CursorDef("P000F23", "SELECT [TarifasGranelesSecosTipoEsclus], [TarifasGranelesSecosTipoGranos], [TarifasGranelesSecosBandas], [TarifasGranelesSecosTarifaS_Ca], [TarifasGranelesSecosDescBandas], [TarifasGranelesSecosCodPeaje] FROM [TarifasGranelesSecos] WITH (NOLOCK) WHERE ([TarifasGranelesSecosTipoEsclus] = 'NeoPanamax') AND ([TarifasGranelesSecosTipoGranos] = 'Carbón') ORDER BY [TarifasGranelesSecosDescBandas] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000F23,100,0,false,false )
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
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
                break;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[6])[0] = rslt.getLong(6) ;
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
