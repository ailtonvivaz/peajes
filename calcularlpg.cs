/*
               File: CalcularLPG
        Description: Calcular LPG
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:14:56.5
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
   public class calcularlpg : GXProcedure
   {
      public calcularlpg( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public calcularlpg( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_LPGBandaM3 ,
                           out SdtSdtResultado aP1_SdtResultado )
      {
         this.AV16LPGBandaM3 = aP0_LPGBandaM3;
         this.AV13SdtResultado = new SdtSdtResultado(context) ;
         initialize();
         executePrivate();
         aP1_SdtResultado=this.AV13SdtResultado;
      }

      public SdtSdtResultado executeUdp( long aP0_LPGBandaM3 )
      {
         this.AV16LPGBandaM3 = aP0_LPGBandaM3;
         this.AV13SdtResultado = new SdtSdtResultado(context) ;
         initialize();
         executePrivate();
         aP1_SdtResultado=this.AV13SdtResultado;
         return AV13SdtResultado ;
      }

      public void executeSubmit( long aP0_LPGBandaM3 ,
                                 out SdtSdtResultado aP1_SdtResultado )
      {
         calcularlpg objcalcularlpg;
         objcalcularlpg = new calcularlpg();
         objcalcularlpg.AV16LPGBandaM3 = aP0_LPGBandaM3;
         objcalcularlpg.AV13SdtResultado = new SdtSdtResultado(context) ;
         objcalcularlpg.context.SetSubmitInitialConfig(context);
         objcalcularlpg.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objcalcularlpg);
         aP1_SdtResultado=this.AV13SdtResultado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((calcularlpg)stateInfo).executePrivate();
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
         AV17ResultadoLPGBandaM3 = AV16LPGBandaM3;
         AV15ValorACalcular = 0;
         /* Using cursor P000B2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A14LPGBandaM3 = P000B2_A14LPGBandaM3[0];
            A15LPGTarifaCargados = P000B2_A15LPGTarifaCargados[0];
            A13LPGID = P000B2_A13LPGID[0];
            if ( AV17ResultadoLPGBandaM3 >= A14LPGBandaM3 )
            {
               if ( A14LPGBandaM3 != 0 )
               {
                  AV15ValorACalcular = (decimal)(AV15ValorACalcular+(A14LPGBandaM3*A15LPGTarifaCargados));
                  AV17ResultadoLPGBandaM3 = (long)(AV17ResultadoLPGBandaM3-A14LPGBandaM3);
               }
               else
               {
                  AV15ValorACalcular = (decimal)(AV15ValorACalcular+(AV17ResultadoLPGBandaM3*A15LPGTarifaCargados));
                  AV17ResultadoLPGBandaM3 = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            else
            {
               AV15ValorACalcular = (decimal)(AV15ValorACalcular+(AV17ResultadoLPGBandaM3*A15LPGTarifaCargados));
               AV17ResultadoLPGBandaM3 = 0;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV13SdtResultado.gxTpr_Sdtresultadopanamax = AV15ValorACalcular;
         AV13SdtResultado.gxTpr_Sdtresultadoneopanamax = AV15ValorACalcular;
         AV17ResultadoLPGBandaM3 = AV16LPGBandaM3;
         AV15ValorACalcular = 0;
         AV17ResultadoLPGBandaM3 = AV16LPGBandaM3;
         /* Using cursor P000B3 */
         pr_default.execute(1);
         while ( (pr_default.getStatus(1) != 101) )
         {
            A14LPGBandaM3 = P000B3_A14LPGBandaM3[0];
            A16LPGTarifaLastre = P000B3_A16LPGTarifaLastre[0];
            A13LPGID = P000B3_A13LPGID[0];
            if ( AV17ResultadoLPGBandaM3 >= A14LPGBandaM3 )
            {
               if ( A14LPGBandaM3 != 0 )
               {
                  AV15ValorACalcular = (decimal)(AV15ValorACalcular+(A14LPGBandaM3*A16LPGTarifaLastre));
                  AV17ResultadoLPGBandaM3 = (long)(AV17ResultadoLPGBandaM3-A14LPGBandaM3);
               }
               else
               {
                  AV15ValorACalcular = (decimal)(AV15ValorACalcular+(AV17ResultadoLPGBandaM3*A16LPGTarifaLastre));
                  AV17ResultadoLPGBandaM3 = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            else
            {
               AV15ValorACalcular = (decimal)(AV15ValorACalcular+(AV17ResultadoLPGBandaM3*A16LPGTarifaLastre));
               AV17ResultadoLPGBandaM3 = 0;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(1);
         }
         pr_default.close(1);
         AV13SdtResultado.gxTpr_Sdtresultadolastre = AV15ValorACalcular;
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
         P000B2_A14LPGBandaM3 = new long[1] ;
         P000B2_A15LPGTarifaCargados = new decimal[1] ;
         P000B2_A13LPGID = new short[1] ;
         P000B3_A14LPGBandaM3 = new long[1] ;
         P000B3_A16LPGTarifaLastre = new decimal[1] ;
         P000B3_A13LPGID = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.calcularlpg__default(),
            new Object[][] {
                new Object[] {
               P000B2_A14LPGBandaM3, P000B2_A15LPGTarifaCargados, P000B2_A13LPGID
               }
               , new Object[] {
               P000B3_A14LPGBandaM3, P000B3_A16LPGTarifaLastre, P000B3_A13LPGID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A13LPGID ;
      private long AV16LPGBandaM3 ;
      private long AV17ResultadoLPGBandaM3 ;
      private long A14LPGBandaM3 ;
      private decimal AV15ValorACalcular ;
      private decimal A15LPGTarifaCargados ;
      private decimal A16LPGTarifaLastre ;
      private String scmdbuf ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P000B2_A14LPGBandaM3 ;
      private decimal[] P000B2_A15LPGTarifaCargados ;
      private short[] P000B2_A13LPGID ;
      private long[] P000B3_A14LPGBandaM3 ;
      private decimal[] P000B3_A16LPGTarifaLastre ;
      private short[] P000B3_A13LPGID ;
      private SdtSdtResultado aP1_SdtResultado ;
      private SdtSdtResultado AV13SdtResultado ;
   }

   public class calcularlpg__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000B2 ;
          prmP000B2 = new Object[] {
          } ;
          Object[] prmP000B3 ;
          prmP000B3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P000B2", "SELECT [LPGBandaM3], [LPGTarifaCargados], [LPGID] FROM [LPG] WITH (NOLOCK) ORDER BY [LPGID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000B2,100,0,false,false )
             ,new CursorDef("P000B3", "SELECT [LPGBandaM3], [LPGTarifaLastre], [LPGID] FROM [LPG] WITH (NOLOCK) ORDER BY [LPGID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000B3,100,0,false,false )
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
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
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
