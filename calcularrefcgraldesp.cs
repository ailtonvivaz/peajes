/*
               File: CalcularRefCGralDesp
        Description: Calculo para buques refrigerados, carga general, otros y desplazamiento
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:14:55.96
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
   public class calcularrefcgraldesp : GXProcedure
   {
      public calcularrefcgraldesp( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public calcularrefcgraldesp( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_Tonelaje ,
                           long aP1_Cubierta ,
                           String aP2_REF_CGRAL_DESP_CARGA ,
                           out SdtSdtResultado aP3_SdtResultado )
      {
         this.AV11Tonelaje = aP0_Tonelaje;
         this.AV13Cubierta = aP1_Cubierta;
         this.AV9REF_CGRAL_DESP_CARGA = aP2_REF_CGRAL_DESP_CARGA;
         this.AV14SdtResultado = new SdtSdtResultado(context) ;
         initialize();
         executePrivate();
         aP3_SdtResultado=this.AV14SdtResultado;
      }

      public SdtSdtResultado executeUdp( long aP0_Tonelaje ,
                                         long aP1_Cubierta ,
                                         String aP2_REF_CGRAL_DESP_CARGA )
      {
         this.AV11Tonelaje = aP0_Tonelaje;
         this.AV13Cubierta = aP1_Cubierta;
         this.AV9REF_CGRAL_DESP_CARGA = aP2_REF_CGRAL_DESP_CARGA;
         this.AV14SdtResultado = new SdtSdtResultado(context) ;
         initialize();
         executePrivate();
         aP3_SdtResultado=this.AV14SdtResultado;
         return AV14SdtResultado ;
      }

      public void executeSubmit( long aP0_Tonelaje ,
                                 long aP1_Cubierta ,
                                 String aP2_REF_CGRAL_DESP_CARGA ,
                                 out SdtSdtResultado aP3_SdtResultado )
      {
         calcularrefcgraldesp objcalcularrefcgraldesp;
         objcalcularrefcgraldesp = new calcularrefcgraldesp();
         objcalcularrefcgraldesp.AV11Tonelaje = aP0_Tonelaje;
         objcalcularrefcgraldesp.AV13Cubierta = aP1_Cubierta;
         objcalcularrefcgraldesp.AV9REF_CGRAL_DESP_CARGA = aP2_REF_CGRAL_DESP_CARGA;
         objcalcularrefcgraldesp.AV14SdtResultado = new SdtSdtResultado(context) ;
         objcalcularrefcgraldesp.context.SetSubmitInitialConfig(context);
         objcalcularrefcgraldesp.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objcalcularrefcgraldesp);
         aP3_SdtResultado=this.AV14SdtResultado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((calcularrefcgraldesp)stateInfo).executePrivate();
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
         AV8OperacionTonelaje = AV11Tonelaje;
         /* Using cursor P000A2 */
         pr_default.execute(0, new Object[] {AV9REF_CGRAL_DESP_CARGA});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A44REF_CGRAL_DESP_CARGA = P000A2_A44REF_CGRAL_DESP_CARGA[0];
            A45REF_CGRAL_DESP_TIPO = P000A2_A45REF_CGRAL_DESP_TIPO[0];
            n45REF_CGRAL_DESP_TIPO = P000A2_n45REF_CGRAL_DESP_TIPO[0];
            A46REF_CGRAL_DESP_TON_TARIF = P000A2_A46REF_CGRAL_DESP_TON_TARIF[0];
            n46REF_CGRAL_DESP_TON_TARIF = P000A2_n46REF_CGRAL_DESP_TON_TARIF[0];
            A47REF_CGRAL_DESP_TARIFA = P000A2_A47REF_CGRAL_DESP_TARIFA[0];
            A48REF_CGRAL_DESP_ID_TON_TARIF = P000A2_A48REF_CGRAL_DESP_ID_TON_TARIF[0];
            A49REF_CGRAL_DESP_ID = P000A2_A49REF_CGRAL_DESP_ID[0];
            if ( StringUtil.StrCmp(A45REF_CGRAL_DESP_TIPO, context.GetMessage( "CARGADO", "")) == 0 )
            {
               if ( AV8OperacionTonelaje >= A46REF_CGRAL_DESP_TON_TARIF )
               {
                  if ( A46REF_CGRAL_DESP_TON_TARIF != 0 )
                  {
                     AV14SdtResultado.gxTpr_Sdtresultadopanamax = (decimal)(AV14SdtResultado.gxTpr_Sdtresultadopanamax+(A46REF_CGRAL_DESP_TON_TARIF*A47REF_CGRAL_DESP_TARIFA));
                     AV8OperacionTonelaje = (long)(AV8OperacionTonelaje-A46REF_CGRAL_DESP_TON_TARIF);
                  }
                  else
                  {
                     AV14SdtResultado.gxTpr_Sdtresultadopanamax = (decimal)(AV14SdtResultado.gxTpr_Sdtresultadopanamax+(AV8OperacionTonelaje*A47REF_CGRAL_DESP_TARIFA));
                     AV8OperacionTonelaje = 0;
                     /* Exit For each command. Update data (if necessary), close cursors & exit. */
                     if (true) break;
                  }
               }
               else
               {
                  AV14SdtResultado.gxTpr_Sdtresultadopanamax = (decimal)(AV14SdtResultado.gxTpr_Sdtresultadopanamax+(AV8OperacionTonelaje*A47REF_CGRAL_DESP_TARIFA));
                  AV8OperacionTonelaje = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV8OperacionTonelaje = AV11Tonelaje;
         /* Using cursor P000A3 */
         pr_default.execute(1, new Object[] {AV9REF_CGRAL_DESP_CARGA});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A44REF_CGRAL_DESP_CARGA = P000A3_A44REF_CGRAL_DESP_CARGA[0];
            A45REF_CGRAL_DESP_TIPO = P000A3_A45REF_CGRAL_DESP_TIPO[0];
            n45REF_CGRAL_DESP_TIPO = P000A3_n45REF_CGRAL_DESP_TIPO[0];
            A46REF_CGRAL_DESP_TON_TARIF = P000A3_A46REF_CGRAL_DESP_TON_TARIF[0];
            n46REF_CGRAL_DESP_TON_TARIF = P000A3_n46REF_CGRAL_DESP_TON_TARIF[0];
            A47REF_CGRAL_DESP_TARIFA = P000A3_A47REF_CGRAL_DESP_TARIFA[0];
            A48REF_CGRAL_DESP_ID_TON_TARIF = P000A3_A48REF_CGRAL_DESP_ID_TON_TARIF[0];
            A49REF_CGRAL_DESP_ID = P000A3_A49REF_CGRAL_DESP_ID[0];
            if ( StringUtil.StrCmp(A45REF_CGRAL_DESP_TIPO, context.GetMessage( "EN LASTRE", "")) == 0 )
            {
               if ( AV8OperacionTonelaje >= A46REF_CGRAL_DESP_TON_TARIF )
               {
                  if ( A46REF_CGRAL_DESP_TON_TARIF != 0 )
                  {
                     AV14SdtResultado.gxTpr_Sdtresultadolastre = (decimal)(AV14SdtResultado.gxTpr_Sdtresultadolastre+(A46REF_CGRAL_DESP_TON_TARIF*A47REF_CGRAL_DESP_TARIFA));
                     AV8OperacionTonelaje = (long)(AV8OperacionTonelaje-A46REF_CGRAL_DESP_TON_TARIF);
                  }
                  else
                  {
                     AV14SdtResultado.gxTpr_Sdtresultadolastre = (decimal)(AV14SdtResultado.gxTpr_Sdtresultadolastre+(AV8OperacionTonelaje*A47REF_CGRAL_DESP_TARIFA));
                     AV8OperacionTonelaje = 0;
                     /* Exit For each command. Update data (if necessary), close cursors & exit. */
                     if (true) break;
                  }
               }
               else
               {
                  AV14SdtResultado.gxTpr_Sdtresultadolastre = (decimal)(AV14SdtResultado.gxTpr_Sdtresultadolastre+(AV8OperacionTonelaje*A47REF_CGRAL_DESP_TARIFA));
                  AV8OperacionTonelaje = 0;
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
            }
            pr_default.readNext(1);
         }
         pr_default.close(1);
         AV16REF_CGRAL_DESP_CARGA_LIST.Add(context.GetMessage( "REFRIGERADA", ""), 0);
         AV16REF_CGRAL_DESP_CARGA_LIST.Add(context.GetMessage( "GENERAL", ""), 0);
         AV16REF_CGRAL_DESP_CARGA_LIST.Add(context.GetMessage( "OTROS", ""), 0);
         if ( (AV16REF_CGRAL_DESP_CARGA_LIST.IndexOf(StringUtil.RTrim( AV9REF_CGRAL_DESP_CARGA))>0) && ( AV13Cubierta > 0 ) )
         {
            /* Using cursor P000A4 */
            pr_default.execute(2);
            while ( (pr_default.getStatus(2) != 101) )
            {
               A44REF_CGRAL_DESP_CARGA = P000A4_A44REF_CGRAL_DESP_CARGA[0];
               A47REF_CGRAL_DESP_TARIFA = P000A4_A47REF_CGRAL_DESP_TARIFA[0];
               A48REF_CGRAL_DESP_ID_TON_TARIF = P000A4_A48REF_CGRAL_DESP_ID_TON_TARIF[0];
               A49REF_CGRAL_DESP_ID = P000A4_A49REF_CGRAL_DESP_ID[0];
               if ( StringUtil.StrCmp(A44REF_CGRAL_DESP_CARGA, context.GetMessage( "CUBIERTA", "")) == 0 )
               {
                  AV14SdtResultado.gxTpr_Sdtlastreroundtrip = (decimal)(AV13Cubierta*A47REF_CGRAL_DESP_TARIFA);
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
               pr_default.readNext(2);
            }
            pr_default.close(2);
            AV14SdtResultado.gxTpr_Sdtresultadopanamax = (decimal)(AV14SdtResultado.gxTpr_Sdtresultadopanamax+AV14SdtResultado.gxTpr_Sdtlastreroundtrip);
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
         P000A2_A44REF_CGRAL_DESP_CARGA = new String[] {""} ;
         P000A2_A45REF_CGRAL_DESP_TIPO = new String[] {""} ;
         P000A2_n45REF_CGRAL_DESP_TIPO = new bool[] {false} ;
         P000A2_A46REF_CGRAL_DESP_TON_TARIF = new long[1] ;
         P000A2_n46REF_CGRAL_DESP_TON_TARIF = new bool[] {false} ;
         P000A2_A47REF_CGRAL_DESP_TARIFA = new decimal[1] ;
         P000A2_A48REF_CGRAL_DESP_ID_TON_TARIF = new short[1] ;
         P000A2_A49REF_CGRAL_DESP_ID = new short[1] ;
         A44REF_CGRAL_DESP_CARGA = "";
         A45REF_CGRAL_DESP_TIPO = "";
         P000A3_A44REF_CGRAL_DESP_CARGA = new String[] {""} ;
         P000A3_A45REF_CGRAL_DESP_TIPO = new String[] {""} ;
         P000A3_n45REF_CGRAL_DESP_TIPO = new bool[] {false} ;
         P000A3_A46REF_CGRAL_DESP_TON_TARIF = new long[1] ;
         P000A3_n46REF_CGRAL_DESP_TON_TARIF = new bool[] {false} ;
         P000A3_A47REF_CGRAL_DESP_TARIFA = new decimal[1] ;
         P000A3_A48REF_CGRAL_DESP_ID_TON_TARIF = new short[1] ;
         P000A3_A49REF_CGRAL_DESP_ID = new short[1] ;
         AV16REF_CGRAL_DESP_CARGA_LIST = new GxSimpleCollection();
         P000A4_A44REF_CGRAL_DESP_CARGA = new String[] {""} ;
         P000A4_A47REF_CGRAL_DESP_TARIFA = new decimal[1] ;
         P000A4_A48REF_CGRAL_DESP_ID_TON_TARIF = new short[1] ;
         P000A4_A49REF_CGRAL_DESP_ID = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.calcularrefcgraldesp__default(),
            new Object[][] {
                new Object[] {
               P000A2_A44REF_CGRAL_DESP_CARGA, P000A2_A45REF_CGRAL_DESP_TIPO, P000A2_n45REF_CGRAL_DESP_TIPO, P000A2_A46REF_CGRAL_DESP_TON_TARIF, P000A2_n46REF_CGRAL_DESP_TON_TARIF, P000A2_A47REF_CGRAL_DESP_TARIFA, P000A2_A48REF_CGRAL_DESP_ID_TON_TARIF, P000A2_A49REF_CGRAL_DESP_ID
               }
               , new Object[] {
               P000A3_A44REF_CGRAL_DESP_CARGA, P000A3_A45REF_CGRAL_DESP_TIPO, P000A3_n45REF_CGRAL_DESP_TIPO, P000A3_A46REF_CGRAL_DESP_TON_TARIF, P000A3_n46REF_CGRAL_DESP_TON_TARIF, P000A3_A47REF_CGRAL_DESP_TARIFA, P000A3_A48REF_CGRAL_DESP_ID_TON_TARIF, P000A3_A49REF_CGRAL_DESP_ID
               }
               , new Object[] {
               P000A4_A44REF_CGRAL_DESP_CARGA, P000A4_A47REF_CGRAL_DESP_TARIFA, P000A4_A48REF_CGRAL_DESP_ID_TON_TARIF, P000A4_A49REF_CGRAL_DESP_ID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A48REF_CGRAL_DESP_ID_TON_TARIF ;
      private short A49REF_CGRAL_DESP_ID ;
      private long AV11Tonelaje ;
      private long AV13Cubierta ;
      private long AV8OperacionTonelaje ;
      private long A46REF_CGRAL_DESP_TON_TARIF ;
      private decimal A47REF_CGRAL_DESP_TARIFA ;
      private String scmdbuf ;
      private bool n45REF_CGRAL_DESP_TIPO ;
      private bool n46REF_CGRAL_DESP_TON_TARIF ;
      private String AV9REF_CGRAL_DESP_CARGA ;
      private String A44REF_CGRAL_DESP_CARGA ;
      private String A45REF_CGRAL_DESP_TIPO ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000A2_A44REF_CGRAL_DESP_CARGA ;
      private String[] P000A2_A45REF_CGRAL_DESP_TIPO ;
      private bool[] P000A2_n45REF_CGRAL_DESP_TIPO ;
      private long[] P000A2_A46REF_CGRAL_DESP_TON_TARIF ;
      private bool[] P000A2_n46REF_CGRAL_DESP_TON_TARIF ;
      private decimal[] P000A2_A47REF_CGRAL_DESP_TARIFA ;
      private short[] P000A2_A48REF_CGRAL_DESP_ID_TON_TARIF ;
      private short[] P000A2_A49REF_CGRAL_DESP_ID ;
      private String[] P000A3_A44REF_CGRAL_DESP_CARGA ;
      private String[] P000A3_A45REF_CGRAL_DESP_TIPO ;
      private bool[] P000A3_n45REF_CGRAL_DESP_TIPO ;
      private long[] P000A3_A46REF_CGRAL_DESP_TON_TARIF ;
      private bool[] P000A3_n46REF_CGRAL_DESP_TON_TARIF ;
      private decimal[] P000A3_A47REF_CGRAL_DESP_TARIFA ;
      private short[] P000A3_A48REF_CGRAL_DESP_ID_TON_TARIF ;
      private short[] P000A3_A49REF_CGRAL_DESP_ID ;
      private String[] P000A4_A44REF_CGRAL_DESP_CARGA ;
      private decimal[] P000A4_A47REF_CGRAL_DESP_TARIFA ;
      private short[] P000A4_A48REF_CGRAL_DESP_ID_TON_TARIF ;
      private short[] P000A4_A49REF_CGRAL_DESP_ID ;
      private SdtSdtResultado aP3_SdtResultado ;
      [ObjectCollection(ItemType=typeof( String ))]
      private IGxCollection AV16REF_CGRAL_DESP_CARGA_LIST ;
      private SdtSdtResultado AV14SdtResultado ;
   }

   public class calcularrefcgraldesp__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000A2 ;
          prmP000A2 = new Object[] {
          new Object[] {"@AV9REF_CGRAL_DESP_CARGA",SqlDbType.VarChar,150,0}
          } ;
          Object[] prmP000A3 ;
          prmP000A3 = new Object[] {
          new Object[] {"@AV9REF_CGRAL_DESP_CARGA",SqlDbType.VarChar,150,0}
          } ;
          Object[] prmP000A4 ;
          prmP000A4 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P000A2", "SELECT [REF_CGRAL_DESP_CARGA], [REF_CGRAL_DESP_TIPO], [REF_CGRAL_DESP_TON_TARIF], [REF_CGRAL_DESP_TARIFA], [REF_CGRAL_DESP_ID_TON_TARIF], [REF_CGRAL_DESP_ID] FROM [REF_CGRAL_DESP] WITH (NOLOCK) WHERE [REF_CGRAL_DESP_CARGA] = @AV9REF_CGRAL_DESP_CARGA ORDER BY [REF_CGRAL_DESP_ID_TON_TARIF] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000A2,100,0,false,false )
             ,new CursorDef("P000A3", "SELECT [REF_CGRAL_DESP_CARGA], [REF_CGRAL_DESP_TIPO], [REF_CGRAL_DESP_TON_TARIF], [REF_CGRAL_DESP_TARIFA], [REF_CGRAL_DESP_ID_TON_TARIF], [REF_CGRAL_DESP_ID] FROM [REF_CGRAL_DESP] WITH (NOLOCK) WHERE [REF_CGRAL_DESP_CARGA] = @AV9REF_CGRAL_DESP_CARGA ORDER BY [REF_CGRAL_DESP_ID_TON_TARIF] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000A3,100,0,false,false )
             ,new CursorDef("P000A4", "SELECT [REF_CGRAL_DESP_CARGA], [REF_CGRAL_DESP_TARIFA], [REF_CGRAL_DESP_ID_TON_TARIF], [REF_CGRAL_DESP_ID] FROM [REF_CGRAL_DESP] WITH (NOLOCK) ORDER BY [REF_CGRAL_DESP_ID_TON_TARIF] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000A4,100,0,false,false )
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
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((decimal[]) buf[5])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
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
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
