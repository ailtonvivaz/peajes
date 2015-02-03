/*
               File: CalcularLNG
        Description: Calcular LNG
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:14:56.11
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
   public class calcularlng : GXProcedure
   {
      public calcularlng( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public calcularlng( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_LNGBandaM3 ,
                           out SdtSdtResultado aP1_SdtResultado )
      {
         this.AV19LNGBandaM3 = aP0_LNGBandaM3;
         this.AV13SdtResultado = new SdtSdtResultado(context) ;
         initialize();
         executePrivate();
         aP1_SdtResultado=this.AV13SdtResultado;
      }

      public SdtSdtResultado executeUdp( long aP0_LNGBandaM3 )
      {
         this.AV19LNGBandaM3 = aP0_LNGBandaM3;
         this.AV13SdtResultado = new SdtSdtResultado(context) ;
         initialize();
         executePrivate();
         aP1_SdtResultado=this.AV13SdtResultado;
         return AV13SdtResultado ;
      }

      public void executeSubmit( long aP0_LNGBandaM3 ,
                                 out SdtSdtResultado aP1_SdtResultado )
      {
         calcularlng objcalcularlng;
         objcalcularlng = new calcularlng();
         objcalcularlng.AV19LNGBandaM3 = aP0_LNGBandaM3;
         objcalcularlng.AV13SdtResultado = new SdtSdtResultado(context) ;
         objcalcularlng.context.SetSubmitInitialConfig(context);
         objcalcularlng.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objcalcularlng);
         aP1_SdtResultado=this.AV13SdtResultado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((calcularlng)stateInfo).executePrivate();
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
         AV18ResultadoLNGBandaM3 = AV19LNGBandaM3;
         AV15ValorACalcular = 0;
         /* Using cursor P000C2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A18LNGBandaM3 = P000C2_A18LNGBandaM3[0];
            A19LNGTarifaCargados = P000C2_A19LNGTarifaCargados[0];
            A17LNGID = P000C2_A17LNGID[0];
            if ( AV18ResultadoLNGBandaM3 >= A18LNGBandaM3 )
            {
               if ( A18LNGBandaM3 != 0 )
               {
                  AV15ValorACalcular = (decimal)(AV15ValorACalcular+(A18LNGBandaM3*A19LNGTarifaCargados));
                  AV18ResultadoLNGBandaM3 = (long)(AV18ResultadoLNGBandaM3-A18LNGBandaM3);
               }
               else
               {
                  AV15ValorACalcular = (decimal)(AV15ValorACalcular+(AV18ResultadoLNGBandaM3*A19LNGTarifaCargados));
                  AV18ResultadoLNGBandaM3 = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            else
            {
               AV15ValorACalcular = (decimal)(AV15ValorACalcular+(AV18ResultadoLNGBandaM3*A19LNGTarifaCargados));
               AV18ResultadoLNGBandaM3 = 0;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV13SdtResultado.gxTpr_Sdtresultadopanamax = AV15ValorACalcular;
         AV13SdtResultado.gxTpr_Sdtresultadoneopanamax = AV15ValorACalcular;
         AV18ResultadoLNGBandaM3 = AV19LNGBandaM3;
         AV15ValorACalcular = 0;
         AV18ResultadoLNGBandaM3 = AV19LNGBandaM3;
         /* Using cursor P000C3 */
         pr_default.execute(1);
         while ( (pr_default.getStatus(1) != 101) )
         {
            A18LNGBandaM3 = P000C3_A18LNGBandaM3[0];
            A20LNGTarifaLastre = P000C3_A20LNGTarifaLastre[0];
            A17LNGID = P000C3_A17LNGID[0];
            if ( AV18ResultadoLNGBandaM3 >= A18LNGBandaM3 )
            {
               if ( A18LNGBandaM3 != 0 )
               {
                  AV15ValorACalcular = (decimal)(AV15ValorACalcular+(A18LNGBandaM3*A20LNGTarifaLastre));
                  AV18ResultadoLNGBandaM3 = (long)(AV18ResultadoLNGBandaM3-A18LNGBandaM3);
               }
               else
               {
                  AV15ValorACalcular = (decimal)(AV15ValorACalcular+(AV18ResultadoLNGBandaM3*A20LNGTarifaLastre));
                  AV18ResultadoLNGBandaM3 = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            else
            {
               AV15ValorACalcular = (decimal)(AV15ValorACalcular+(AV18ResultadoLNGBandaM3*A20LNGTarifaLastre));
               AV18ResultadoLNGBandaM3 = 0;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(1);
         }
         pr_default.close(1);
         AV13SdtResultado.gxTpr_Sdtresultadolastre = AV15ValorACalcular;
         AV18ResultadoLNGBandaM3 = AV19LNGBandaM3;
         AV15ValorACalcular = 0;
         /* Using cursor P000C4 */
         pr_default.execute(2);
         while ( (pr_default.getStatus(2) != 101) )
         {
            A18LNGBandaM3 = P000C4_A18LNGBandaM3[0];
            A21LNGTarifaLastreRoundtrip = P000C4_A21LNGTarifaLastreRoundtrip[0];
            A17LNGID = P000C4_A17LNGID[0];
            if ( AV18ResultadoLNGBandaM3 >= A18LNGBandaM3 )
            {
               if ( A18LNGBandaM3 != 0 )
               {
                  AV15ValorACalcular = (decimal)(AV15ValorACalcular+(A18LNGBandaM3*A21LNGTarifaLastreRoundtrip));
                  AV18ResultadoLNGBandaM3 = (long)(AV18ResultadoLNGBandaM3-A18LNGBandaM3);
               }
               else
               {
                  AV15ValorACalcular = (decimal)(AV15ValorACalcular+(AV18ResultadoLNGBandaM3*A21LNGTarifaLastreRoundtrip));
                  AV18ResultadoLNGBandaM3 = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            else
            {
               AV15ValorACalcular = (decimal)(AV15ValorACalcular+(AV18ResultadoLNGBandaM3*A21LNGTarifaLastreRoundtrip));
               AV18ResultadoLNGBandaM3 = 0;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(2);
         }
         pr_default.close(2);
         AV13SdtResultado.gxTpr_Sdtlastreroundtrip = AV15ValorACalcular;
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
         P000C2_A18LNGBandaM3 = new long[1] ;
         P000C2_A19LNGTarifaCargados = new decimal[1] ;
         P000C2_A17LNGID = new short[1] ;
         P000C3_A18LNGBandaM3 = new long[1] ;
         P000C3_A20LNGTarifaLastre = new decimal[1] ;
         P000C3_A17LNGID = new short[1] ;
         P000C4_A18LNGBandaM3 = new long[1] ;
         P000C4_A21LNGTarifaLastreRoundtrip = new decimal[1] ;
         P000C4_A17LNGID = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.calcularlng__default(),
            new Object[][] {
                new Object[] {
               P000C2_A18LNGBandaM3, P000C2_A19LNGTarifaCargados, P000C2_A17LNGID
               }
               , new Object[] {
               P000C3_A18LNGBandaM3, P000C3_A20LNGTarifaLastre, P000C3_A17LNGID
               }
               , new Object[] {
               P000C4_A18LNGBandaM3, P000C4_A21LNGTarifaLastreRoundtrip, P000C4_A17LNGID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A17LNGID ;
      private long AV19LNGBandaM3 ;
      private long AV18ResultadoLNGBandaM3 ;
      private long A18LNGBandaM3 ;
      private decimal AV15ValorACalcular ;
      private decimal A19LNGTarifaCargados ;
      private decimal A20LNGTarifaLastre ;
      private decimal A21LNGTarifaLastreRoundtrip ;
      private String scmdbuf ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P000C2_A18LNGBandaM3 ;
      private decimal[] P000C2_A19LNGTarifaCargados ;
      private short[] P000C2_A17LNGID ;
      private long[] P000C3_A18LNGBandaM3 ;
      private decimal[] P000C3_A20LNGTarifaLastre ;
      private short[] P000C3_A17LNGID ;
      private long[] P000C4_A18LNGBandaM3 ;
      private decimal[] P000C4_A21LNGTarifaLastreRoundtrip ;
      private short[] P000C4_A17LNGID ;
      private SdtSdtResultado aP1_SdtResultado ;
      private SdtSdtResultado AV13SdtResultado ;
   }

   public class calcularlng__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000C2 ;
          prmP000C2 = new Object[] {
          } ;
          Object[] prmP000C3 ;
          prmP000C3 = new Object[] {
          } ;
          Object[] prmP000C4 ;
          prmP000C4 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P000C2", "SELECT [LNGBandaM3], [LNGTarifaCargados], [LNGID] FROM [LNG] WITH (NOLOCK) ORDER BY [LNGID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000C2,100,0,false,false )
             ,new CursorDef("P000C3", "SELECT [LNGBandaM3], [LNGTarifaLastre], [LNGID] FROM [LNG] WITH (NOLOCK) ORDER BY [LNGID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000C3,100,0,false,false )
             ,new CursorDef("P000C4", "SELECT [LNGBandaM3], [LNGTarifaLastreRoundtrip], [LNGID] FROM [LNG] WITH (NOLOCK) ORDER BY [LNGID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000C4,100,0,false,false )
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
             case 2 :
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
