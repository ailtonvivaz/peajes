/*
               File: CalcularQuimiqueros
        Description: Calcular Quimiqueros
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:14:55.82
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
   public class calcularquimiqueros : GXProcedure
   {
      public calcularquimiqueros( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public calcularquimiqueros( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_QuimiquerosBandaCPSUAB ,
                           ref String aP1_DominioIMO ,
                           out SdtSdtResultado aP2_SdtResultado )
      {
         this.AV15QuimiquerosBandaCPSUAB = aP0_QuimiquerosBandaCPSUAB;
         this.AV18DominioIMO = aP1_DominioIMO;
         this.AV17SdtResultado = new SdtSdtResultado(context) ;
         initialize();
         executePrivate();
         aP1_DominioIMO=this.AV18DominioIMO;
         aP2_SdtResultado=this.AV17SdtResultado;
      }

      public SdtSdtResultado executeUdp( long aP0_QuimiquerosBandaCPSUAB ,
                                         ref String aP1_DominioIMO )
      {
         this.AV15QuimiquerosBandaCPSUAB = aP0_QuimiquerosBandaCPSUAB;
         this.AV18DominioIMO = aP1_DominioIMO;
         this.AV17SdtResultado = new SdtSdtResultado(context) ;
         initialize();
         executePrivate();
         aP1_DominioIMO=this.AV18DominioIMO;
         aP2_SdtResultado=this.AV17SdtResultado;
         return AV17SdtResultado ;
      }

      public void executeSubmit( long aP0_QuimiquerosBandaCPSUAB ,
                                 ref String aP1_DominioIMO ,
                                 out SdtSdtResultado aP2_SdtResultado )
      {
         calcularquimiqueros objcalcularquimiqueros;
         objcalcularquimiqueros = new calcularquimiqueros();
         objcalcularquimiqueros.AV15QuimiquerosBandaCPSUAB = aP0_QuimiquerosBandaCPSUAB;
         objcalcularquimiqueros.AV18DominioIMO = aP1_DominioIMO;
         objcalcularquimiqueros.AV17SdtResultado = new SdtSdtResultado(context) ;
         objcalcularquimiqueros.context.SetSubmitInitialConfig(context);
         objcalcularquimiqueros.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objcalcularquimiqueros);
         aP1_DominioIMO=this.AV18DominioIMO;
         aP2_SdtResultado=this.AV17SdtResultado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((calcularquimiqueros)stateInfo).executePrivate();
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
         AV16ResultadoQuimiquerosBandaCPSUAB = AV15QuimiquerosBandaCPSUAB;
         AV13ValorACalcular = 0;
         /* Using cursor P00082 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A10QuimiquerosBandaCPSUAB = P00082_A10QuimiquerosBandaCPSUAB[0];
            A11QuimiquerosTarifaCargados = P00082_A11QuimiquerosTarifaCargados[0];
            A9QuimiquerosID = P00082_A9QuimiquerosID[0];
            if ( AV16ResultadoQuimiquerosBandaCPSUAB >= A10QuimiquerosBandaCPSUAB )
            {
               if ( A10QuimiquerosBandaCPSUAB != 0 )
               {
                  AV13ValorACalcular = (decimal)(AV13ValorACalcular+(A10QuimiquerosBandaCPSUAB*A11QuimiquerosTarifaCargados));
                  AV16ResultadoQuimiquerosBandaCPSUAB = (long)(AV16ResultadoQuimiquerosBandaCPSUAB-A10QuimiquerosBandaCPSUAB);
               }
               else
               {
                  AV13ValorACalcular = (decimal)(AV13ValorACalcular+(AV16ResultadoQuimiquerosBandaCPSUAB*A11QuimiquerosTarifaCargados));
                  AV16ResultadoQuimiquerosBandaCPSUAB = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            else
            {
               AV13ValorACalcular = (decimal)(AV13ValorACalcular+(AV16ResultadoQuimiquerosBandaCPSUAB*A11QuimiquerosTarifaCargados));
               AV16ResultadoQuimiquerosBandaCPSUAB = 0;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV17SdtResultado.gxTpr_Sdtresultadopanamax = AV13ValorACalcular;
         AV17SdtResultado.gxTpr_Sdtresultadoneopanamax = AV13ValorACalcular;
         AV16ResultadoQuimiquerosBandaCPSUAB = AV15QuimiquerosBandaCPSUAB;
         AV13ValorACalcular = 0;
         AV16ResultadoQuimiquerosBandaCPSUAB = AV15QuimiquerosBandaCPSUAB;
         /* Using cursor P00083 */
         pr_default.execute(1);
         while ( (pr_default.getStatus(1) != 101) )
         {
            A10QuimiquerosBandaCPSUAB = P00083_A10QuimiquerosBandaCPSUAB[0];
            A12QuimiquerosTarifaLastre = P00083_A12QuimiquerosTarifaLastre[0];
            A9QuimiquerosID = P00083_A9QuimiquerosID[0];
            if ( AV16ResultadoQuimiquerosBandaCPSUAB >= A10QuimiquerosBandaCPSUAB )
            {
               if ( A10QuimiquerosBandaCPSUAB != 0 )
               {
                  AV13ValorACalcular = (decimal)(AV13ValorACalcular+(A10QuimiquerosBandaCPSUAB*A12QuimiquerosTarifaLastre));
                  AV16ResultadoQuimiquerosBandaCPSUAB = (long)(AV16ResultadoQuimiquerosBandaCPSUAB-A10QuimiquerosBandaCPSUAB);
               }
               else
               {
                  AV13ValorACalcular = (decimal)(AV13ValorACalcular+(AV16ResultadoQuimiquerosBandaCPSUAB*A12QuimiquerosTarifaLastre));
                  AV16ResultadoQuimiquerosBandaCPSUAB = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            else
            {
               AV13ValorACalcular = (decimal)(AV13ValorACalcular+(AV16ResultadoQuimiquerosBandaCPSUAB*A12QuimiquerosTarifaLastre));
               AV16ResultadoQuimiquerosBandaCPSUAB = 0;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(1);
         }
         pr_default.close(1);
         AV17SdtResultado.gxTpr_Sdtresultadolastre = AV13ValorACalcular;
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
         P00082_A10QuimiquerosBandaCPSUAB = new long[1] ;
         P00082_A11QuimiquerosTarifaCargados = new decimal[1] ;
         P00082_A9QuimiquerosID = new short[1] ;
         P00083_A10QuimiquerosBandaCPSUAB = new long[1] ;
         P00083_A12QuimiquerosTarifaLastre = new decimal[1] ;
         P00083_A9QuimiquerosID = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.calcularquimiqueros__default(),
            new Object[][] {
                new Object[] {
               P00082_A10QuimiquerosBandaCPSUAB, P00082_A11QuimiquerosTarifaCargados, P00082_A9QuimiquerosID
               }
               , new Object[] {
               P00083_A10QuimiquerosBandaCPSUAB, P00083_A12QuimiquerosTarifaLastre, P00083_A9QuimiquerosID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A9QuimiquerosID ;
      private long AV15QuimiquerosBandaCPSUAB ;
      private long AV16ResultadoQuimiquerosBandaCPSUAB ;
      private long A10QuimiquerosBandaCPSUAB ;
      private decimal AV13ValorACalcular ;
      private decimal A11QuimiquerosTarifaCargados ;
      private decimal A12QuimiquerosTarifaLastre ;
      private String scmdbuf ;
      private String AV18DominioIMO ;
      private IGxDataStore dsDefault ;
      private String aP1_DominioIMO ;
      private IDataStoreProvider pr_default ;
      private long[] P00082_A10QuimiquerosBandaCPSUAB ;
      private decimal[] P00082_A11QuimiquerosTarifaCargados ;
      private short[] P00082_A9QuimiquerosID ;
      private long[] P00083_A10QuimiquerosBandaCPSUAB ;
      private decimal[] P00083_A12QuimiquerosTarifaLastre ;
      private short[] P00083_A9QuimiquerosID ;
      private SdtSdtResultado aP2_SdtResultado ;
      private SdtSdtResultado AV17SdtResultado ;
   }

   public class calcularquimiqueros__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00082 ;
          prmP00082 = new Object[] {
          } ;
          Object[] prmP00083 ;
          prmP00083 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P00082", "SELECT [QuimiquerosBandaCPSUAB], [QuimiquerosTarifaCargados], [QuimiquerosID] FROM [Quimiqueros] WITH (NOLOCK) ORDER BY [QuimiquerosID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00082,100,0,false,false )
             ,new CursorDef("P00083", "SELECT [QuimiquerosBandaCPSUAB], [QuimiquerosTarifaLastre], [QuimiquerosID] FROM [Quimiqueros] WITH (NOLOCK) ORDER BY [QuimiquerosID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00083,100,0,false,false )
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
