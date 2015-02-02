/*
               File: CalcularPortavehiculosRORO
        Description: Calcular cobro de Portavehiculos y RO-RO
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:14:55.88
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
   public class calcularportavehiculosroro : GXProcedure
   {
      public calcularportavehiculosroro( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public calcularportavehiculosroro( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( decimal aP0_VEH_RORO_TON_INI ,
                           decimal aP1_VEH_RORO_UTIL_INI ,
                           out SdtSdtResultado aP2_SdtResultado )
      {
         this.AV9VEH_RORO_TON_INI = aP0_VEH_RORO_TON_INI;
         this.AV10VEH_RORO_UTIL_INI = aP1_VEH_RORO_UTIL_INI;
         this.AV11SdtResultado = new SdtSdtResultado(context) ;
         initialize();
         executePrivate();
         aP2_SdtResultado=this.AV11SdtResultado;
      }

      public SdtSdtResultado executeUdp( decimal aP0_VEH_RORO_TON_INI ,
                                         decimal aP1_VEH_RORO_UTIL_INI )
      {
         this.AV9VEH_RORO_TON_INI = aP0_VEH_RORO_TON_INI;
         this.AV10VEH_RORO_UTIL_INI = aP1_VEH_RORO_UTIL_INI;
         this.AV11SdtResultado = new SdtSdtResultado(context) ;
         initialize();
         executePrivate();
         aP2_SdtResultado=this.AV11SdtResultado;
         return AV11SdtResultado ;
      }

      public void executeSubmit( decimal aP0_VEH_RORO_TON_INI ,
                                 decimal aP1_VEH_RORO_UTIL_INI ,
                                 out SdtSdtResultado aP2_SdtResultado )
      {
         calcularportavehiculosroro objcalcularportavehiculosroro;
         objcalcularportavehiculosroro = new calcularportavehiculosroro();
         objcalcularportavehiculosroro.AV9VEH_RORO_TON_INI = aP0_VEH_RORO_TON_INI;
         objcalcularportavehiculosroro.AV10VEH_RORO_UTIL_INI = aP1_VEH_RORO_UTIL_INI;
         objcalcularportavehiculosroro.AV11SdtResultado = new SdtSdtResultado(context) ;
         objcalcularportavehiculosroro.context.SetSubmitInitialConfig(context);
         objcalcularportavehiculosroro.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objcalcularportavehiculosroro);
         aP2_SdtResultado=this.AV11SdtResultado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((calcularportavehiculosroro)stateInfo).executePrivate();
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
         if ( ( AV10VEH_RORO_UTIL_INI > Convert.ToDecimal( 0 )) )
         {
            /* Using cursor P00092 */
            pr_default.execute(0, new Object[] {AV9VEH_RORO_TON_INI, AV10VEH_RORO_UTIL_INI});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A42VEH_RORO_UTIL_FIN = P00092_A42VEH_RORO_UTIL_FIN[0];
               A41VEH_RORO_UTIL_INI = P00092_A41VEH_RORO_UTIL_INI[0];
               A40VEH_RORO_TON_FIN = P00092_A40VEH_RORO_TON_FIN[0];
               A39VEH_RORO_TON_INI = P00092_A39VEH_RORO_TON_INI[0];
               A43VEH_RORO_TARIFA = P00092_A43VEH_RORO_TARIFA[0];
               A38VEH_RORO_ID = P00092_A38VEH_RORO_ID[0];
               AV11SdtResultado.gxTpr_Sdtresultadopanamax = (decimal)(A43VEH_RORO_TARIFA*AV9VEH_RORO_TON_INI);
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(0);
            }
            pr_default.close(0);
         }
         else
         {
            /* Using cursor P00093 */
            pr_default.execute(1, new Object[] {AV9VEH_RORO_TON_INI});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A42VEH_RORO_UTIL_FIN = P00093_A42VEH_RORO_UTIL_FIN[0];
               A41VEH_RORO_UTIL_INI = P00093_A41VEH_RORO_UTIL_INI[0];
               A40VEH_RORO_TON_FIN = P00093_A40VEH_RORO_TON_FIN[0];
               A39VEH_RORO_TON_INI = P00093_A39VEH_RORO_TON_INI[0];
               A43VEH_RORO_TARIFA = P00093_A43VEH_RORO_TARIFA[0];
               A38VEH_RORO_ID = P00093_A38VEH_RORO_ID[0];
               AV11SdtResultado.gxTpr_Sdtresultadopanamax = (decimal)(A43VEH_RORO_TARIFA*AV9VEH_RORO_TON_INI);
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(1);
            }
            pr_default.close(1);
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
         P00092_A42VEH_RORO_UTIL_FIN = new decimal[1] ;
         P00092_A41VEH_RORO_UTIL_INI = new decimal[1] ;
         P00092_A40VEH_RORO_TON_FIN = new decimal[1] ;
         P00092_A39VEH_RORO_TON_INI = new decimal[1] ;
         P00092_A43VEH_RORO_TARIFA = new decimal[1] ;
         P00092_A38VEH_RORO_ID = new short[1] ;
         P00093_A42VEH_RORO_UTIL_FIN = new decimal[1] ;
         P00093_A41VEH_RORO_UTIL_INI = new decimal[1] ;
         P00093_A40VEH_RORO_TON_FIN = new decimal[1] ;
         P00093_A39VEH_RORO_TON_INI = new decimal[1] ;
         P00093_A43VEH_RORO_TARIFA = new decimal[1] ;
         P00093_A38VEH_RORO_ID = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.calcularportavehiculosroro__default(),
            new Object[][] {
                new Object[] {
               P00092_A42VEH_RORO_UTIL_FIN, P00092_A41VEH_RORO_UTIL_INI, P00092_A40VEH_RORO_TON_FIN, P00092_A39VEH_RORO_TON_INI, P00092_A43VEH_RORO_TARIFA, P00092_A38VEH_RORO_ID
               }
               , new Object[] {
               P00093_A42VEH_RORO_UTIL_FIN, P00093_A41VEH_RORO_UTIL_INI, P00093_A40VEH_RORO_TON_FIN, P00093_A39VEH_RORO_TON_INI, P00093_A43VEH_RORO_TARIFA, P00093_A38VEH_RORO_ID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A38VEH_RORO_ID ;
      private decimal AV9VEH_RORO_TON_INI ;
      private decimal AV10VEH_RORO_UTIL_INI ;
      private decimal A42VEH_RORO_UTIL_FIN ;
      private decimal A41VEH_RORO_UTIL_INI ;
      private decimal A40VEH_RORO_TON_FIN ;
      private decimal A39VEH_RORO_TON_INI ;
      private decimal A43VEH_RORO_TARIFA ;
      private String scmdbuf ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private decimal[] P00092_A42VEH_RORO_UTIL_FIN ;
      private decimal[] P00092_A41VEH_RORO_UTIL_INI ;
      private decimal[] P00092_A40VEH_RORO_TON_FIN ;
      private decimal[] P00092_A39VEH_RORO_TON_INI ;
      private decimal[] P00092_A43VEH_RORO_TARIFA ;
      private short[] P00092_A38VEH_RORO_ID ;
      private decimal[] P00093_A42VEH_RORO_UTIL_FIN ;
      private decimal[] P00093_A41VEH_RORO_UTIL_INI ;
      private decimal[] P00093_A40VEH_RORO_TON_FIN ;
      private decimal[] P00093_A39VEH_RORO_TON_INI ;
      private decimal[] P00093_A43VEH_RORO_TARIFA ;
      private short[] P00093_A38VEH_RORO_ID ;
      private SdtSdtResultado aP2_SdtResultado ;
      private SdtSdtResultado AV11SdtResultado ;
   }

   public class calcularportavehiculosroro__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00092 ;
          prmP00092 = new Object[] {
          new Object[] {"@AV9VEH_RORO_TON_INI",SqlDbType.Decimal,10,2} ,
          new Object[] {"@AV10VEH_RORO_UTIL_INI",SqlDbType.Decimal,10,2}
          } ;
          Object[] prmP00093 ;
          prmP00093 = new Object[] {
          new Object[] {"@AV9VEH_RORO_TON_INI",SqlDbType.Decimal,10,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00092", "SELECT TOP 1 [VEH_RORO_UTIL_FIN], [VEH_RORO_UTIL_INI], [VEH_RORO_TON_FIN], [VEH_RORO_TON_INI], [VEH_RORO_TARIFA], [VEH_RORO_ID] FROM [VEH_RORO] WITH (NOLOCK) WHERE (@AV9VEH_RORO_TON_INI >= [VEH_RORO_TON_INI] and @AV9VEH_RORO_TON_INI <= [VEH_RORO_TON_FIN]) AND (@AV10VEH_RORO_UTIL_INI >= [VEH_RORO_UTIL_INI] and @AV10VEH_RORO_UTIL_INI <= [VEH_RORO_UTIL_FIN]) ORDER BY [VEH_RORO_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00092,1,0,false,true )
             ,new CursorDef("P00093", "SELECT TOP 1 [VEH_RORO_UTIL_FIN], [VEH_RORO_UTIL_INI], [VEH_RORO_TON_FIN], [VEH_RORO_TON_INI], [VEH_RORO_TARIFA], [VEH_RORO_ID] FROM [VEH_RORO] WITH (NOLOCK) WHERE (@AV9VEH_RORO_TON_INI >= [VEH_RORO_TON_INI] and @AV9VEH_RORO_TON_INI <= [VEH_RORO_TON_FIN]) AND ([VEH_RORO_UTIL_INI] = 0.00) AND ([VEH_RORO_UTIL_FIN] = 9.99) ORDER BY [VEH_RORO_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00093,1,0,false,true )
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
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
             case 1 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
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
                stmt.SetParameter(2, (decimal)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (decimal)parms[0]);
                break;
       }
    }

 }

}
