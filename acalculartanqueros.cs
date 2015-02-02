/*
               File: CalcularTanqueros
        Description: Calcular Tanqueros
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:14:55.71
       Program type: Main program
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
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class acalculartanqueros : GXProcedure
   {
      public acalculartanqueros( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public acalculartanqueros( IGxContext context )
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
         this.AV8TanqueroBandaCPSUAB = aP0_TanqueroBandaCPSUAB;
         this.AV9TanqueroBandaTM = aP1_TanqueroBandaTM;
         this.AV16DWT = aP2_DWT;
         this.AV15SdtResultado = new SdtSdtResultado(context) ;
         initialize();
         executePrivate();
         aP3_SdtResultado=this.AV15SdtResultado;
      }

      public SdtSdtResultado executeUdp( long aP0_TanqueroBandaCPSUAB ,
                                         long aP1_TanqueroBandaTM ,
                                         long aP2_DWT )
      {
         this.AV8TanqueroBandaCPSUAB = aP0_TanqueroBandaCPSUAB;
         this.AV9TanqueroBandaTM = aP1_TanqueroBandaTM;
         this.AV16DWT = aP2_DWT;
         this.AV15SdtResultado = new SdtSdtResultado(context) ;
         initialize();
         executePrivate();
         aP3_SdtResultado=this.AV15SdtResultado;
         return AV15SdtResultado ;
      }

      public void executeSubmit( long aP0_TanqueroBandaCPSUAB ,
                                 long aP1_TanqueroBandaTM ,
                                 long aP2_DWT ,
                                 out SdtSdtResultado aP3_SdtResultado )
      {
         acalculartanqueros objacalculartanqueros;
         objacalculartanqueros = new acalculartanqueros();
         objacalculartanqueros.AV8TanqueroBandaCPSUAB = aP0_TanqueroBandaCPSUAB;
         objacalculartanqueros.AV9TanqueroBandaTM = aP1_TanqueroBandaTM;
         objacalculartanqueros.AV16DWT = aP2_DWT;
         objacalculartanqueros.AV15SdtResultado = new SdtSdtResultado(context) ;
         objacalculartanqueros.context.SetSubmitInitialConfig(context);
         objacalculartanqueros.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objacalculartanqueros);
         aP3_SdtResultado=this.AV15SdtResultado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((acalculartanqueros)stateInfo).executePrivate();
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
         AV11ResultadoTanqueroBandaCPSUAB = AV8TanqueroBandaCPSUAB;
         AV12ValorACalcular = 0;
         /* Using cursor P00072 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A1TanqueroEsclusasID = P00072_A1TanqueroEsclusasID[0];
            A8TanqueroBandaCPSUAB = P00072_A8TanqueroBandaCPSUAB[0];
            A4TanqueroTarifaCPSUAB = P00072_A4TanqueroTarifaCPSUAB[0];
            A3TanqueroRango = P00072_A3TanqueroRango[0];
            if ( AV11ResultadoTanqueroBandaCPSUAB >= A8TanqueroBandaCPSUAB )
            {
               if ( A8TanqueroBandaCPSUAB != 0 )
               {
                  AV12ValorACalcular = (decimal)(AV12ValorACalcular+(A8TanqueroBandaCPSUAB*A4TanqueroTarifaCPSUAB));
                  AV11ResultadoTanqueroBandaCPSUAB = (long)(AV11ResultadoTanqueroBandaCPSUAB-A8TanqueroBandaCPSUAB);
               }
               else
               {
                  AV12ValorACalcular = (decimal)(AV12ValorACalcular+(AV11ResultadoTanqueroBandaCPSUAB*A4TanqueroTarifaCPSUAB));
                  AV11ResultadoTanqueroBandaCPSUAB = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            else
            {
               AV12ValorACalcular = (decimal)(AV12ValorACalcular+(AV11ResultadoTanqueroBandaCPSUAB*A4TanqueroTarifaCPSUAB));
               AV11ResultadoTanqueroBandaCPSUAB = 0;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV15SdtResultado.gxTpr_Sdtresultadopanamax = AV12ValorACalcular;
         AV11ResultadoTanqueroBandaCPSUAB = AV8TanqueroBandaCPSUAB;
         AV12ValorACalcular = 0;
         /* Using cursor P00073 */
         pr_default.execute(1);
         while ( (pr_default.getStatus(1) != 101) )
         {
            A1TanqueroEsclusasID = P00073_A1TanqueroEsclusasID[0];
            A8TanqueroBandaCPSUAB = P00073_A8TanqueroBandaCPSUAB[0];
            A4TanqueroTarifaCPSUAB = P00073_A4TanqueroTarifaCPSUAB[0];
            A3TanqueroRango = P00073_A3TanqueroRango[0];
            if ( AV11ResultadoTanqueroBandaCPSUAB >= A8TanqueroBandaCPSUAB )
            {
               if ( A8TanqueroBandaCPSUAB != 0 )
               {
                  AV12ValorACalcular = (decimal)(AV12ValorACalcular+(A8TanqueroBandaCPSUAB*A4TanqueroTarifaCPSUAB));
                  AV11ResultadoTanqueroBandaCPSUAB = (long)(AV11ResultadoTanqueroBandaCPSUAB-A8TanqueroBandaCPSUAB);
               }
               else
               {
                  AV12ValorACalcular = (decimal)(AV12ValorACalcular+(AV11ResultadoTanqueroBandaCPSUAB*A4TanqueroTarifaCPSUAB));
                  AV11ResultadoTanqueroBandaCPSUAB = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            else
            {
               AV12ValorACalcular = (decimal)(AV12ValorACalcular+(AV11ResultadoTanqueroBandaCPSUAB*A4TanqueroTarifaCPSUAB));
               AV11ResultadoTanqueroBandaCPSUAB = 0;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(1);
         }
         pr_default.close(1);
         AV11ResultadoTanqueroBandaCPSUAB = AV9TanqueroBandaTM;
         /* Using cursor P00074 */
         pr_default.execute(2);
         while ( (pr_default.getStatus(2) != 101) )
         {
            A1TanqueroEsclusasID = P00074_A1TanqueroEsclusasID[0];
            A5TanqueroBandaTM = P00074_A5TanqueroBandaTM[0];
            A6TanqueroTarifaTM = P00074_A6TanqueroTarifaTM[0];
            A3TanqueroRango = P00074_A3TanqueroRango[0];
            if ( AV11ResultadoTanqueroBandaCPSUAB >= A5TanqueroBandaTM )
            {
               if ( A5TanqueroBandaTM != 0 )
               {
                  AV12ValorACalcular = (decimal)(AV12ValorACalcular+(A5TanqueroBandaTM*A6TanqueroTarifaTM));
                  AV11ResultadoTanqueroBandaCPSUAB = (long)(AV11ResultadoTanqueroBandaCPSUAB-A5TanqueroBandaTM);
               }
               else
               {
                  AV12ValorACalcular = (decimal)(AV12ValorACalcular+(AV11ResultadoTanqueroBandaCPSUAB*A6TanqueroTarifaTM));
                  AV11ResultadoTanqueroBandaCPSUAB = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            else
            {
               AV12ValorACalcular = (decimal)(AV12ValorACalcular+(AV11ResultadoTanqueroBandaCPSUAB*A6TanqueroTarifaTM));
               AV11ResultadoTanqueroBandaCPSUAB = 0;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(2);
         }
         pr_default.close(2);
         AV15SdtResultado.gxTpr_Sdtresultadoneopanamax = AV12ValorACalcular;
         AV12ValorACalcular = 0;
         AV11ResultadoTanqueroBandaCPSUAB = AV8TanqueroBandaCPSUAB;
         /* Using cursor P00075 */
         pr_default.execute(3);
         while ( (pr_default.getStatus(3) != 101) )
         {
            A1TanqueroEsclusasID = P00075_A1TanqueroEsclusasID[0];
            A8TanqueroBandaCPSUAB = P00075_A8TanqueroBandaCPSUAB[0];
            A7TanqueroTarifaLastre = P00075_A7TanqueroTarifaLastre[0];
            A3TanqueroRango = P00075_A3TanqueroRango[0];
            if ( AV11ResultadoTanqueroBandaCPSUAB >= A8TanqueroBandaCPSUAB )
            {
               if ( A8TanqueroBandaCPSUAB != 0 )
               {
                  AV12ValorACalcular = (decimal)(AV12ValorACalcular+(A8TanqueroBandaCPSUAB*A7TanqueroTarifaLastre));
                  AV11ResultadoTanqueroBandaCPSUAB = (long)(AV11ResultadoTanqueroBandaCPSUAB-A8TanqueroBandaCPSUAB);
               }
               else
               {
                  AV12ValorACalcular = (decimal)(AV12ValorACalcular+(AV11ResultadoTanqueroBandaCPSUAB*A7TanqueroTarifaLastre));
                  AV11ResultadoTanqueroBandaCPSUAB = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            else
            {
               AV12ValorACalcular = (decimal)(AV12ValorACalcular+(AV11ResultadoTanqueroBandaCPSUAB*A7TanqueroTarifaLastre));
               AV11ResultadoTanqueroBandaCPSUAB = 0;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(3);
         }
         pr_default.close(3);
         AV15SdtResultado.gxTpr_Sdtresultadolastre = AV12ValorACalcular;
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
         P00072_A1TanqueroEsclusasID = new short[1] ;
         P00072_A8TanqueroBandaCPSUAB = new long[1] ;
         P00072_A4TanqueroTarifaCPSUAB = new decimal[1] ;
         P00072_A3TanqueroRango = new short[1] ;
         P00073_A1TanqueroEsclusasID = new short[1] ;
         P00073_A8TanqueroBandaCPSUAB = new long[1] ;
         P00073_A4TanqueroTarifaCPSUAB = new decimal[1] ;
         P00073_A3TanqueroRango = new short[1] ;
         P00074_A1TanqueroEsclusasID = new short[1] ;
         P00074_A5TanqueroBandaTM = new long[1] ;
         P00074_A6TanqueroTarifaTM = new decimal[1] ;
         P00074_A3TanqueroRango = new short[1] ;
         P00075_A1TanqueroEsclusasID = new short[1] ;
         P00075_A8TanqueroBandaCPSUAB = new long[1] ;
         P00075_A7TanqueroTarifaLastre = new decimal[1] ;
         P00075_A3TanqueroRango = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.acalculartanqueros__default(),
            new Object[][] {
                new Object[] {
               P00072_A1TanqueroEsclusasID, P00072_A8TanqueroBandaCPSUAB, P00072_A4TanqueroTarifaCPSUAB, P00072_A3TanqueroRango
               }
               , new Object[] {
               P00073_A1TanqueroEsclusasID, P00073_A8TanqueroBandaCPSUAB, P00073_A4TanqueroTarifaCPSUAB, P00073_A3TanqueroRango
               }
               , new Object[] {
               P00074_A1TanqueroEsclusasID, P00074_A5TanqueroBandaTM, P00074_A6TanqueroTarifaTM, P00074_A3TanqueroRango
               }
               , new Object[] {
               P00075_A1TanqueroEsclusasID, P00075_A8TanqueroBandaCPSUAB, P00075_A7TanqueroTarifaLastre, P00075_A3TanqueroRango
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A1TanqueroEsclusasID ;
      private short A3TanqueroRango ;
      private long AV8TanqueroBandaCPSUAB ;
      private long AV9TanqueroBandaTM ;
      private long AV16DWT ;
      private long AV11ResultadoTanqueroBandaCPSUAB ;
      private long A8TanqueroBandaCPSUAB ;
      private long A5TanqueroBandaTM ;
      private decimal AV12ValorACalcular ;
      private decimal A4TanqueroTarifaCPSUAB ;
      private decimal A6TanqueroTarifaTM ;
      private decimal A7TanqueroTarifaLastre ;
      private String scmdbuf ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00072_A1TanqueroEsclusasID ;
      private long[] P00072_A8TanqueroBandaCPSUAB ;
      private decimal[] P00072_A4TanqueroTarifaCPSUAB ;
      private short[] P00072_A3TanqueroRango ;
      private short[] P00073_A1TanqueroEsclusasID ;
      private long[] P00073_A8TanqueroBandaCPSUAB ;
      private decimal[] P00073_A4TanqueroTarifaCPSUAB ;
      private short[] P00073_A3TanqueroRango ;
      private short[] P00074_A1TanqueroEsclusasID ;
      private long[] P00074_A5TanqueroBandaTM ;
      private decimal[] P00074_A6TanqueroTarifaTM ;
      private short[] P00074_A3TanqueroRango ;
      private short[] P00075_A1TanqueroEsclusasID ;
      private long[] P00075_A8TanqueroBandaCPSUAB ;
      private decimal[] P00075_A7TanqueroTarifaLastre ;
      private short[] P00075_A3TanqueroRango ;
      private SdtSdtResultado aP3_SdtResultado ;
      private SdtSdtResultado AV15SdtResultado ;
   }

   public class acalculartanqueros__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00072 ;
          prmP00072 = new Object[] {
          } ;
          Object[] prmP00073 ;
          prmP00073 = new Object[] {
          } ;
          Object[] prmP00074 ;
          prmP00074 = new Object[] {
          } ;
          Object[] prmP00075 ;
          prmP00075 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P00072", "SELECT [TanqueroEsclusasID], [TanqueroBandaCPSUAB], [TanqueroTarifaCPSUAB], [TanqueroRango] FROM [TanqueroEsclusasRango] WITH (NOLOCK) WHERE [TanqueroEsclusasID] = 1 ORDER BY [TanqueroEsclusasID], [TanqueroRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00072,100,0,false,false )
             ,new CursorDef("P00073", "SELECT [TanqueroEsclusasID], [TanqueroBandaCPSUAB], [TanqueroTarifaCPSUAB], [TanqueroRango] FROM [TanqueroEsclusasRango] WITH (NOLOCK) WHERE [TanqueroEsclusasID] = 2 ORDER BY [TanqueroEsclusasID], [TanqueroRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00073,100,0,false,false )
             ,new CursorDef("P00074", "SELECT [TanqueroEsclusasID], [TanqueroBandaTM], [TanqueroTarifaTM], [TanqueroRango] FROM [TanqueroEsclusasRango] WITH (NOLOCK) WHERE [TanqueroEsclusasID] = 2 ORDER BY [TanqueroEsclusasID], [TanqueroRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00074,100,0,false,false )
             ,new CursorDef("P00075", "SELECT [TanqueroEsclusasID], [TanqueroBandaCPSUAB], [TanqueroTarifaLastre], [TanqueroRango] FROM [TanqueroEsclusasRango] WITH (NOLOCK) WHERE [TanqueroEsclusasID] = 1 ORDER BY [TanqueroEsclusasID], [TanqueroRango] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00075,100,0,false,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
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

 [ServiceContract(Namespace = "GeneXus.Programs.calculartanqueros_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class calculartanqueros_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "POST" ,
    	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/")]
    public void execute( String TanqueroBandaCPSUAB ,
                         String TanqueroBandaTM ,
                         String DWT ,
                         out SdtSdtResultado_RESTInterface SdtResultado )
    {
       SdtResultado = new SdtSdtResultado_RESTInterface() ;
       try
       {
          acalculartanqueros worker = new acalculartanqueros(context) ;
          worker.IsMain = RunAsMain ;
          long gxrTanqueroBandaCPSUAB ;
          gxrTanqueroBandaCPSUAB = (long)(NumberUtil.Val( (String)(TanqueroBandaCPSUAB), "."));
          long gxrTanqueroBandaTM ;
          gxrTanqueroBandaTM = (long)(NumberUtil.Val( (String)(TanqueroBandaTM), "."));
          long gxrDWT ;
          gxrDWT = (long)(NumberUtil.Val( (String)(DWT), "."));
          SdtSdtResultado gxrSdtResultado = SdtResultado.sdt ;
          worker.execute(gxrTanqueroBandaCPSUAB,gxrTanqueroBandaTM,gxrDWT,out gxrSdtResultado );
          worker.cleanup( );
          SdtResultado = new SdtSdtResultado_RESTInterface(gxrSdtResultado) ;
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
