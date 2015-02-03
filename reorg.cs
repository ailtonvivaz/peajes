/*
               File: reorg
        Description: Table Manager
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 7:37:47.76
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
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class reorg : GXReorganization
   {
      public reorg( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public reorg( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      void executePrivate( )
      {
         SetCreateDataBase( ) ;
         CreateDataBase( ) ;
         if ( PreviousCheck() )
         {
            ExecuteReorganization( ) ;
         }
      }

      private void CreateDataBase( )
      {
         DS = (GxDataStore)(context.GetDataStore( "Default"));
         ErrCode = DS.Connection.FullConnect();
         DataBaseName = DS.Connection.Database;
         if ( ErrCode != 0 )
         {
            DS.Connection.Database = "";
            ErrCode = DS.Connection.FullConnect();
            if ( ErrCode == 0 )
            {
               try
               {
                  GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("GXM_dbcrea")+ " " +DataBaseName , null);
                  cmdBuffer = "CREATE DATABASE " + "[" + DataBaseName + "]";
                  RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                  RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                  RGZ.ExecuteStmt() ;
                  RGZ.Drop();
                  Count = 1;
               }
               catch ( Exception ex )
               {
                  ErrCode = 1;
                  GeneXus.Reorg.GXReorganization.AddMsg( ex.Message , null);
                  throw ex ;
               }
               ErrCode = DS.Connection.Disconnect();
               DS.Connection.Database = DataBaseName;
               ErrCode = DS.Connection.FullConnect();
               while ( ( ErrCode != 0 ) && ( Count > 0 ) && ( Count < 30 ) )
               {
                  Res = GXUtil.Sleep( 1);
                  ErrCode = DS.Connection.FullConnect();
                  Count = (short)(Count+1);
               }
               setupDB = 0;
               if ( ( setupDB == 1 ) || GeneXus.Configuration.Preferences.MustSetupDB( ) )
               {
                  defaultUsers = GXUtil.DefaultWebUser( context);
                  short gxidx ;
                  gxidx = 1;
                  while ( gxidx <= defaultUsers.Count )
                  {
                     defaultUser = ((String)defaultUsers.Item(gxidx));
                     try
                     {
                        GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("GXM_dbadduser", new   object[]  {defaultUser, DataBaseName}) , null);
                        cmdBuffer = "CREATE LOGIN " + "[" + defaultUser + "]" + " FROM WINDOWS";
                        RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                        RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                        RGZ.ExecuteStmt() ;
                        RGZ.Drop();
                     }
                     catch ( Exception ex )
                     {
                     }
                     try
                     {
                        cmdBuffer = "CREATE USER " + "[" + defaultUser + "]" + " FOR LOGIN " + "[" + defaultUser + "]";
                        RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                        RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                        RGZ.ExecuteStmt() ;
                        RGZ.Drop();
                     }
                     catch ( Exception ex )
                     {
                     }
                     try
                     {
                        cmdBuffer = "EXEC sp_addrolemember N'db_datareader', N'" + defaultUser + "'";
                        RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                        RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                        RGZ.ExecuteStmt() ;
                        RGZ.Drop();
                     }
                     catch ( Exception ex )
                     {
                     }
                     try
                     {
                        cmdBuffer = "EXEC sp_addrolemember N'db_datawriter', N'" + defaultUser + "'";
                        RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                        RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                        RGZ.ExecuteStmt() ;
                        RGZ.Drop();
                     }
                     catch ( Exception ex )
                     {
                     }
                     gxidx = (short)(gxidx+1);
                  }
               }
            }
            if ( ErrCode != 0 )
            {
               ErrMsg = DS.ErrDescription;
               GeneXus.Reorg.GXReorganization.AddMsg( ErrMsg , null);
               ErrCode = 1;
               throw new Exception( ErrMsg) ;
            }
         }
      }

      private void FirstActions( )
      {
         /* Load data into tables. */
      }

      public void CreatePASAJEROS( )
      {
         String cmdBuffer ;
         /* Indices for table PASAJEROS */
         try
         {
            cmdBuffer=" CREATE TABLE [PASAJEROS] ([PASAJEROS_ID] smallint NOT NULL  IDENTITY(1,1), [PASAJEROS_ESCLUSA] varchar(40) NOT NULL , [PASAJEROS_TIPO_TARIFA] varchar(10) NOT NULL , [PASAJEROS_CARGA] varchar(40) NOT NULL , [PASAJEROS_ID_TON_TARIF] smallint NOT NULL , [PASAJEROS_TON_TARIFA] decimal( 10) NULL , [PASAJEROS_TARIFA] money NOT NULL , [PASAJEROS_COMENTARIO] varchar(150) NULL , PRIMARY KEY([PASAJEROS_ID]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            DropTableConstraints( "[PASAJEROS]") ;
            cmdBuffer=" DROP TABLE [PASAJEROS] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE TABLE [PASAJEROS] ([PASAJEROS_ID] smallint NOT NULL  IDENTITY(1,1), [PASAJEROS_ESCLUSA] varchar(40) NOT NULL , [PASAJEROS_TIPO_TARIFA] varchar(10) NOT NULL , [PASAJEROS_CARGA] varchar(40) NOT NULL , [PASAJEROS_ID_TON_TARIF] smallint NOT NULL , [PASAJEROS_TON_TARIFA] decimal( 10) NULL , [PASAJEROS_TARIFA] money NOT NULL , [PASAJEROS_COMENTARIO] varchar(150) NULL , PRIMARY KEY([PASAJEROS_ID]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreateTarifasGranelesSecos( )
      {
         String cmdBuffer ;
         /* Indices for table TarifasGranelesSecos */
         try
         {
            cmdBuffer=" CREATE TABLE [TarifasGranelesSecos] ([TarifasGranelesSecosCodPeaje] decimal( 10) NOT NULL  IDENTITY(1,1), [TarifasGranelesSecosDescBandas] varchar(40) NOT NULL , [TarifasGranelesSecosBandas] decimal( 10) NOT NULL , [TarifasGranelesSecosTipoEsclus] varchar(40) NULL , [TarifasGranelesSecosTipoGranos] varchar(30) NOT NULL , [TarifasGranelesSecosTarifaS_DW] smallmoney NOT NULL , [TarifasGranelesSecosTarifaS_Ca] smallmoney NOT NULL , PRIMARY KEY([TarifasGranelesSecosCodPeaje]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            DropTableConstraints( "[TarifasGranelesSecos]") ;
            cmdBuffer=" DROP TABLE [TarifasGranelesSecos] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE TABLE [TarifasGranelesSecos] ([TarifasGranelesSecosCodPeaje] decimal( 10) NOT NULL  IDENTITY(1,1), [TarifasGranelesSecosDescBandas] varchar(40) NOT NULL , [TarifasGranelesSecosBandas] decimal( 10) NOT NULL , [TarifasGranelesSecosTipoEsclus] varchar(40) NULL , [TarifasGranelesSecosTipoGranos] varchar(30) NOT NULL , [TarifasGranelesSecosTarifaS_DW] smallmoney NOT NULL , [TarifasGranelesSecosTarifaS_Ca] smallmoney NOT NULL , PRIMARY KEY([TarifasGranelesSecosCodPeaje]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreateREF_CGRAL_DESP( )
      {
         String cmdBuffer ;
         /* Indices for table REF_CGRAL_DESP */
         try
         {
            cmdBuffer=" CREATE TABLE [REF_CGRAL_DESP] ([REF_CGRAL_DESP_ID] smallint NOT NULL  IDENTITY(1,1), [REF_CGRAL_DESP_CARGA] varchar(150) NOT NULL , [REF_CGRAL_DESP_TIPO] varchar(50) NULL , [REF_CGRAL_DESP_ID_TON_TARIF] smallint NOT NULL , [REF_CGRAL_DESP_TON_TARIF] decimal( 10) NULL , [REF_CGRAL_DESP_TARIFA] money NOT NULL , [REF_CGRAL_DESP_COMENTARIO] varchar(250) NULL , PRIMARY KEY([REF_CGRAL_DESP_ID]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            DropTableConstraints( "[REF_CGRAL_DESP]") ;
            cmdBuffer=" DROP TABLE [REF_CGRAL_DESP] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE TABLE [REF_CGRAL_DESP] ([REF_CGRAL_DESP_ID] smallint NOT NULL  IDENTITY(1,1), [REF_CGRAL_DESP_CARGA] varchar(150) NOT NULL , [REF_CGRAL_DESP_TIPO] varchar(50) NULL , [REF_CGRAL_DESP_ID_TON_TARIF] smallint NOT NULL , [REF_CGRAL_DESP_TON_TARIF] decimal( 10) NULL , [REF_CGRAL_DESP_TARIFA] money NOT NULL , [REF_CGRAL_DESP_COMENTARIO] varchar(250) NULL , PRIMARY KEY([REF_CGRAL_DESP_ID]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreateVEH_RORO( )
      {
         String cmdBuffer ;
         /* Indices for table VEH_RORO */
         try
         {
            cmdBuffer=" CREATE TABLE [VEH_RORO] ([VEH_RORO_ID] smallint NOT NULL  IDENTITY(1,1), [VEH_RORO_TON_INI] money NOT NULL , [VEH_RORO_TON_FIN] money NOT NULL , [VEH_RORO_UTIL_INI] money NOT NULL , [VEH_RORO_UTIL_FIN] money NOT NULL , [VEH_RORO_TARIFA] money NOT NULL , PRIMARY KEY([VEH_RORO_ID]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            DropTableConstraints( "[VEH_RORO]") ;
            cmdBuffer=" DROP TABLE [VEH_RORO] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE TABLE [VEH_RORO] ([VEH_RORO_ID] smallint NOT NULL  IDENTITY(1,1), [VEH_RORO_TON_INI] money NOT NULL , [VEH_RORO_TON_FIN] money NOT NULL , [VEH_RORO_UTIL_INI] money NOT NULL , [VEH_RORO_UTIL_FIN] money NOT NULL , [VEH_RORO_TARIFA] money NOT NULL , PRIMARY KEY([VEH_RORO_ID]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreatePortaContenedoresRango( )
      {
         String cmdBuffer ;
         /* Indices for table PortaContenedoresRango */
         try
         {
            cmdBuffer=" CREATE TABLE [PortaContenedoresRango] ([PortaContenedoresEsclusa] smallint NOT NULL , [PortaRango] smallint NOT NULL , [PortaRangoIniTEU] decimal( 12) NOT NULL , [PortaRangoFinTEU] decimal( 12) NOT NULL , [PortaTarifaTTA4] smallmoney NOT NULL , [PortaTarifaTEU4] smallmoney NOT NULL , [PortaTarifaTTA3] smallmoney NOT NULL , [PortaTarifaTEU3] smallmoney NOT NULL , [PortaTarifaTTA2] smallmoney NOT NULL , [PortaTarifaTEU2] smallmoney NOT NULL , [PortaTarifaTTA1] smallmoney NOT NULL , [PortaTarifaTEU1] smallmoney NOT NULL , PRIMARY KEY([PortaContenedoresEsclusa], [PortaRango]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            DropTableConstraints( "[PortaContenedoresRango]") ;
            cmdBuffer=" DROP TABLE [PortaContenedoresRango] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE TABLE [PortaContenedoresRango] ([PortaContenedoresEsclusa] smallint NOT NULL , [PortaRango] smallint NOT NULL , [PortaRangoIniTEU] decimal( 12) NOT NULL , [PortaRangoFinTEU] decimal( 12) NOT NULL , [PortaTarifaTTA4] smallmoney NOT NULL , [PortaTarifaTEU4] smallmoney NOT NULL , [PortaTarifaTTA3] smallmoney NOT NULL , [PortaTarifaTEU3] smallmoney NOT NULL , [PortaTarifaTTA2] smallmoney NOT NULL , [PortaTarifaTEU2] smallmoney NOT NULL , [PortaTarifaTTA1] smallmoney NOT NULL , [PortaTarifaTEU1] smallmoney NOT NULL , PRIMARY KEY([PortaContenedoresEsclusa], [PortaRango]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreatePortaContenedores( )
      {
         String cmdBuffer ;
         /* Indices for table PortaContenedores */
         try
         {
            cmdBuffer=" CREATE TABLE [PortaContenedores] ([PortaContenedoresEsclusa] smallint NOT NULL , [PortaContenedoresEsclusaDesc] varchar(40) NOT NULL , PRIMARY KEY([PortaContenedoresEsclusa]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            DropTableConstraints( "[PortaContenedores]") ;
            cmdBuffer=" DROP TABLE [PortaContenedores] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE TABLE [PortaContenedores] ([PortaContenedoresEsclusa] smallint NOT NULL , [PortaContenedoresEsclusaDesc] varchar(40) NOT NULL , PRIMARY KEY([PortaContenedoresEsclusa]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreateLNG( )
      {
         String cmdBuffer ;
         /* Indices for table LNG */
         try
         {
            cmdBuffer=" CREATE TABLE [LNG] ([LNGID] smallint NOT NULL  IDENTITY(1,1), [LNGBandaM3] decimal( 12) NOT NULL , [LNGTarifaCargados] smallmoney NOT NULL , [LNGTarifaLastre] smallmoney NOT NULL , [LNGTarifaLastreRoundtrip] smallmoney NOT NULL , PRIMARY KEY([LNGID]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            DropTableConstraints( "[LNG]") ;
            cmdBuffer=" DROP TABLE [LNG] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE TABLE [LNG] ([LNGID] smallint NOT NULL  IDENTITY(1,1), [LNGBandaM3] decimal( 12) NOT NULL , [LNGTarifaCargados] smallmoney NOT NULL , [LNGTarifaLastre] smallmoney NOT NULL , [LNGTarifaLastreRoundtrip] smallmoney NOT NULL , PRIMARY KEY([LNGID]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreateLPG( )
      {
         String cmdBuffer ;
         /* Indices for table LPG */
         try
         {
            cmdBuffer=" CREATE TABLE [LPG] ([LPGID] smallint NOT NULL  IDENTITY(1,1), [LPGBandaM3] decimal( 12) NOT NULL , [LPGTarifaCargados] smallmoney NOT NULL , [LPGTarifaLastre] smallmoney NOT NULL , PRIMARY KEY([LPGID]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            DropTableConstraints( "[LPG]") ;
            cmdBuffer=" DROP TABLE [LPG] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE TABLE [LPG] ([LPGID] smallint NOT NULL  IDENTITY(1,1), [LPGBandaM3] decimal( 12) NOT NULL , [LPGTarifaCargados] smallmoney NOT NULL , [LPGTarifaLastre] smallmoney NOT NULL , PRIMARY KEY([LPGID]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreateQuimiqueros( )
      {
         String cmdBuffer ;
         /* Indices for table Quimiqueros */
         try
         {
            cmdBuffer=" CREATE TABLE [Quimiqueros] ([QuimiquerosID] smallint NOT NULL  IDENTITY(1,1), [QuimiquerosBandaCPSUAB] decimal( 10) NOT NULL , [QuimiquerosTarifaCargados] smallmoney NOT NULL , [QuimiquerosTarifaLastre] smallmoney NOT NULL , PRIMARY KEY([QuimiquerosID]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            DropTableConstraints( "[Quimiqueros]") ;
            cmdBuffer=" DROP TABLE [Quimiqueros] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE TABLE [Quimiqueros] ([QuimiquerosID] smallint NOT NULL  IDENTITY(1,1), [QuimiquerosBandaCPSUAB] decimal( 10) NOT NULL , [QuimiquerosTarifaCargados] smallmoney NOT NULL , [QuimiquerosTarifaLastre] smallmoney NOT NULL , PRIMARY KEY([QuimiquerosID]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreateTanqueroEsclusasRango( )
      {
         String cmdBuffer ;
         /* Indices for table TanqueroEsclusasRango */
         try
         {
            cmdBuffer=" CREATE TABLE [TanqueroEsclusasRango] ([TanqueroEsclusasID] smallint NOT NULL , [TanqueroRango] smallint NOT NULL , [TanqueroTarifaCPSUAB] smallmoney NOT NULL , [TanqueroBandaTM] decimal( 12) NOT NULL , [TanqueroTarifaTM] smallmoney NOT NULL , [TanqueroTarifaLastre] smallmoney NOT NULL , [TanqueroBandaCPSUAB] decimal( 10) NOT NULL , PRIMARY KEY([TanqueroEsclusasID], [TanqueroRango]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            DropTableConstraints( "[TanqueroEsclusasRango]") ;
            cmdBuffer=" DROP TABLE [TanqueroEsclusasRango] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE TABLE [TanqueroEsclusasRango] ([TanqueroEsclusasID] smallint NOT NULL , [TanqueroRango] smallint NOT NULL , [TanqueroTarifaCPSUAB] smallmoney NOT NULL , [TanqueroBandaTM] decimal( 12) NOT NULL , [TanqueroTarifaTM] smallmoney NOT NULL , [TanqueroTarifaLastre] smallmoney NOT NULL , [TanqueroBandaCPSUAB] decimal( 10) NOT NULL , PRIMARY KEY([TanqueroEsclusasID], [TanqueroRango]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreateTanqueroEsclusas( )
      {
         String cmdBuffer ;
         /* Indices for table TanqueroEsclusas */
         try
         {
            cmdBuffer=" CREATE TABLE [TanqueroEsclusas] ([TanqueroEsclusasID] smallint NOT NULL , [TanqueroEsclusasDesc] varchar(40) NOT NULL , PRIMARY KEY([TanqueroEsclusasID]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            DropTableConstraints( "[TanqueroEsclusas]") ;
            cmdBuffer=" DROP TABLE [TanqueroEsclusas] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE TABLE [TanqueroEsclusas] ([TanqueroEsclusasID] smallint NOT NULL , [TanqueroEsclusasDesc] varchar(40) NOT NULL , PRIMARY KEY([TanqueroEsclusasID]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void RITanqueroEsclusasRangoTanqueroEsclusas( )
      {
         String cmdBuffer ;
         try
         {
            cmdBuffer=" ALTER TABLE [TanqueroEsclusasRango] ADD CONSTRAINT [ITANQUEROESCLUSASRANGO1] FOREIGN KEY ([TanqueroEsclusasID]) REFERENCES [TanqueroEsclusas] ([TanqueroEsclusasID]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               cmdBuffer=" ALTER TABLE [TanqueroEsclusasRango] DROP CONSTRAINT [ITANQUEROESCLUSASRANGO1] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
            }
            cmdBuffer=" ALTER TABLE [TanqueroEsclusasRango] ADD CONSTRAINT [ITANQUEROESCLUSASRANGO1] FOREIGN KEY ([TanqueroEsclusasID]) REFERENCES [TanqueroEsclusas] ([TanqueroEsclusasID]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void RIPortaContenedoresRangoPortaContenedores( )
      {
         String cmdBuffer ;
         try
         {
            cmdBuffer=" ALTER TABLE [PortaContenedoresRango] ADD CONSTRAINT [IPORTACONTENEDORESRANGO1] FOREIGN KEY ([PortaContenedoresEsclusa]) REFERENCES [PortaContenedores] ([PortaContenedoresEsclusa]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               cmdBuffer=" ALTER TABLE [PortaContenedoresRango] DROP CONSTRAINT [IPORTACONTENEDORESRANGO1] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
            }
            cmdBuffer=" ALTER TABLE [PortaContenedoresRango] ADD CONSTRAINT [IPORTACONTENEDORESRANGO1] FOREIGN KEY ([PortaContenedoresEsclusa]) REFERENCES [PortaContenedores] ([PortaContenedoresEsclusa]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      private void TablesCount( )
      {
      }

      private bool PreviousCheck( )
      {
         if ( ! IsResumeMode( ) )
         {
            if ( GXUtil.DbmsVersion( context, "DEFAULT") < 9 )
            {
               SetCheckError ( GXResourceManager.GetMessage("GXM_bad_DBMS_version", new   object[]  {"2005"}) ) ;
               return false ;
            }
         }
         if ( ! MustRunCheck( ) )
         {
            return true ;
         }
         if ( GXUtil.IsSQLSERVER2005( context, "DEFAULT") )
         {
            /* Using cursor P00012 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               sSchemaVar = P00012_AsSchemaVar[0];
               nsSchemaVar = P00012_nsSchemaVar[0];
               pr_default.readNext(0);
            }
            pr_default.close(0);
         }
         else
         {
            /* Using cursor P00023 */
            pr_default.execute(1);
            while ( (pr_default.getStatus(1) != 101) )
            {
               sSchemaVar = P00023_AsSchemaVar[0];
               nsSchemaVar = P00023_nsSchemaVar[0];
               pr_default.readNext(1);
            }
            pr_default.close(1);
         }
         if ( tableexist("PASAJEROS",sSchemaVar) )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_table_exist", new   object[]  {"PASAJEROS"}) ) ;
            return false ;
         }
         if ( tableexist("TarifasGranelesSecos",sSchemaVar) )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_table_exist", new   object[]  {"TarifasGranelesSecos"}) ) ;
            return false ;
         }
         if ( tableexist("REF_CGRAL_DESP",sSchemaVar) )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_table_exist", new   object[]  {"REF_CGRAL_DESP"}) ) ;
            return false ;
         }
         if ( tableexist("VEH_RORO",sSchemaVar) )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_table_exist", new   object[]  {"VEH_RORO"}) ) ;
            return false ;
         }
         if ( tableexist("PortaContenedoresRango",sSchemaVar) )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_table_exist", new   object[]  {"PortaContenedoresRango"}) ) ;
            return false ;
         }
         if ( tableexist("PortaContenedores",sSchemaVar) )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_table_exist", new   object[]  {"PortaContenedores"}) ) ;
            return false ;
         }
         if ( tableexist("LNG",sSchemaVar) )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_table_exist", new   object[]  {"LNG"}) ) ;
            return false ;
         }
         if ( tableexist("LPG",sSchemaVar) )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_table_exist", new   object[]  {"LPG"}) ) ;
            return false ;
         }
         if ( tableexist("Quimiqueros",sSchemaVar) )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_table_exist", new   object[]  {"Quimiqueros"}) ) ;
            return false ;
         }
         if ( tableexist("TanqueroEsclusasRango",sSchemaVar) )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_table_exist", new   object[]  {"TanqueroEsclusasRango"}) ) ;
            return false ;
         }
         if ( tableexist("TanqueroEsclusas",sSchemaVar) )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_table_exist", new   object[]  {"TanqueroEsclusas"}) ) ;
            return false ;
         }
         return true ;
      }

      private bool tableexist( String sTableName ,
                               String sMySchemaName )
      {
         bool result ;
         result = false;
         /* Using cursor P00034 */
         pr_default.execute(2, new Object[] {sTableName, sMySchemaName});
         while ( (pr_default.getStatus(2) != 101) )
         {
            tablename = P00034_Atablename[0];
            ntablename = P00034_ntablename[0];
            schemaname = P00034_Aschemaname[0];
            nschemaname = P00034_nschemaname[0];
            result = true;
            pr_default.readNext(2);
         }
         pr_default.close(2);
         return result ;
      }

      private void ExecuteOnlyTablesReorganization( )
      {
         ReorgExecute.RegisterBlockForSubmit( 1 ,  "CreatePASAJEROS" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 2 ,  "CreateTarifasGranelesSecos" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 3 ,  "CreateREF_CGRAL_DESP" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 4 ,  "CreateVEH_RORO" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 5 ,  "CreatePortaContenedoresRango" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 6 ,  "CreatePortaContenedores" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 7 ,  "CreateLNG" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 8 ,  "CreateLPG" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 9 ,  "CreateQuimiqueros" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 10 ,  "CreateTanqueroEsclusasRango" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 11 ,  "CreateTanqueroEsclusas" , new Object[]{ });
      }

      private void ExecuteOnlyRisReorganization( )
      {
         ReorgExecute.RegisterBlockForSubmit( 12 ,  "RITanqueroEsclusasRangoTanqueroEsclusas" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 13 ,  "RIPortaContenedoresRangoPortaContenedores" , new Object[]{ });
      }

      private void ExecuteTablesReorganization( )
      {
         ExecuteOnlyTablesReorganization( ) ;
         ExecuteOnlyRisReorganization( ) ;
         ReorgExecute.SubmitAll() ;
      }

      private void SetPrecedence( )
      {
         SetPrecedencetables( ) ;
         SetPrecedenceris( ) ;
      }

      private void SetPrecedencetables( )
      {
         GXReorganization.SetMsg( 1 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"PASAJEROS", ""}) );
         GXReorganization.SetMsg( 2 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"TarifasGranelesSecos", ""}) );
         GXReorganization.SetMsg( 3 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"REF_CGRAL_DESP", ""}) );
         GXReorganization.SetMsg( 4 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"VEH_RORO", ""}) );
         GXReorganization.SetMsg( 5 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"PortaContenedoresRango", ""}) );
         ReorgExecute.RegisterPrecedence( "CreatePortaContenedoresRango" ,  "CreatePortaContenedores" );
         GXReorganization.SetMsg( 6 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"PortaContenedores", ""}) );
         GXReorganization.SetMsg( 7 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"LNG", ""}) );
         GXReorganization.SetMsg( 8 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"LPG", ""}) );
         GXReorganization.SetMsg( 9 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"Quimiqueros", ""}) );
         GXReorganization.SetMsg( 10 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"TanqueroEsclusasRango", ""}) );
         ReorgExecute.RegisterPrecedence( "CreateTanqueroEsclusasRango" ,  "CreateTanqueroEsclusas" );
         GXReorganization.SetMsg( 11 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"TanqueroEsclusas", ""}) );
      }

      private void SetPrecedenceris( )
      {
         GXReorganization.SetMsg( 12 ,  GXResourceManager.GetMessage("GXM_refintcrea", new   object[]  {"[ITANQUEROESCLUSASRANGO1]"}) );
         ReorgExecute.RegisterPrecedence( "RITanqueroEsclusasRangoTanqueroEsclusas" ,  "CreateTanqueroEsclusasRango" );
         ReorgExecute.RegisterPrecedence( "RITanqueroEsclusasRangoTanqueroEsclusas" ,  "CreateTanqueroEsclusas" );
         GXReorganization.SetMsg( 13 ,  GXResourceManager.GetMessage("GXM_refintcrea", new   object[]  {"[IPORTACONTENEDORESRANGO1]"}) );
         ReorgExecute.RegisterPrecedence( "RIPortaContenedoresRangoPortaContenedores" ,  "CreatePortaContenedoresRango" );
         ReorgExecute.RegisterPrecedence( "RIPortaContenedoresRangoPortaContenedores" ,  "CreatePortaContenedores" );
      }

      private void ExecuteReorganization( )
      {
         if ( ErrCode == 0 )
         {
            TablesCount( ) ;
            if ( ! PrintOnlyRecordCount( ) )
            {
               FirstActions( ) ;
               SetPrecedence( ) ;
               ExecuteTablesReorganization( ) ;
            }
         }
      }

      [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
      public void DropTableConstraints( String sTableName )
      {
         String cmdBuffer ;
         /* Using cursor P00045 */
         pr_default.execute(3, new Object[] {sTableName});
         while ( (pr_default.getStatus(3) != 101) )
         {
            constid = P00045_Aconstid[0];
            nconstid = P00045_nconstid[0];
            fkeyid = P00045_Afkeyid[0];
            nfkeyid = P00045_nfkeyid[0];
            rkeyid = P00045_Arkeyid[0];
            nrkeyid = P00045_nrkeyid[0];
            cmdBuffer = "ALTER TABLE " + "[" + fkeyid + "] DROP CONSTRAINT " + constid;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            pr_default.readNext(3);
         }
         pr_default.close(3);
      }

      public void UtilsCleanup( )
      {
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         DS = new GxDataStore();
         ErrMsg = "";
         DataBaseName = "";
         defaultUsers = new GeneXus.Utils.GxStringCollection();
         defaultUser = "";
         sSchemaVar = "";
         nsSchemaVar = false;
         scmdbuf = "";
         P00012_AsSchemaVar = new String[] {""} ;
         P00012_nsSchemaVar = new bool[] {false} ;
         P00023_AsSchemaVar = new String[] {""} ;
         P00023_nsSchemaVar = new bool[] {false} ;
         sTableName = "";
         sMySchemaName = "";
         tablename = "";
         ntablename = false;
         schemaname = "";
         nschemaname = false;
         P00034_Atablename = new String[] {""} ;
         P00034_ntablename = new bool[] {false} ;
         P00034_Aschemaname = new String[] {""} ;
         P00034_nschemaname = new bool[] {false} ;
         constid = "";
         nconstid = false;
         fkeyid = "";
         nfkeyid = false;
         P00045_Aconstid = new String[] {""} ;
         P00045_nconstid = new bool[] {false} ;
         P00045_Afkeyid = new String[] {""} ;
         P00045_nfkeyid = new bool[] {false} ;
         P00045_Arkeyid = new int[1] ;
         P00045_nrkeyid = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.reorg__default(),
            new Object[][] {
                new Object[] {
               P00012_AsSchemaVar
               }
               , new Object[] {
               P00023_AsSchemaVar
               }
               , new Object[] {
               P00034_Atablename, P00034_Aschemaname
               }
               , new Object[] {
               P00045_Aconstid, P00045_Afkeyid, P00045_Arkeyid
               }
            }
         );
         /* GeneXus formulas. */
      }

      protected short ErrCode ;
      protected short Count ;
      protected short Res ;
      protected short setupDB ;
      protected int rkeyid ;
      protected String ErrMsg ;
      protected String DataBaseName ;
      protected String cmdBuffer ;
      protected String defaultUser ;
      protected String sSchemaVar ;
      protected String scmdbuf ;
      protected String sTableName ;
      protected String sMySchemaName ;
      protected bool nsSchemaVar ;
      protected bool ntablename ;
      protected bool nschemaname ;
      protected bool nconstid ;
      protected bool nfkeyid ;
      protected bool nrkeyid ;
      protected String tablename ;
      protected String schemaname ;
      protected String constid ;
      protected String fkeyid ;
      protected GeneXus.Utils.GxStringCollection defaultUsers ;
      protected GxDataStore DS ;
      protected IGxDataStore dsDefault ;
      protected GxCommand RGZ ;
      protected IDataStoreProvider pr_default ;
      protected String[] P00012_AsSchemaVar ;
      protected bool[] P00012_nsSchemaVar ;
      protected String[] P00023_AsSchemaVar ;
      protected bool[] P00023_nsSchemaVar ;
      protected String[] P00034_Atablename ;
      protected bool[] P00034_ntablename ;
      protected String[] P00034_Aschemaname ;
      protected bool[] P00034_nschemaname ;
      protected String[] P00045_Aconstid ;
      protected bool[] P00045_nconstid ;
      protected String[] P00045_Afkeyid ;
      protected bool[] P00045_nfkeyid ;
      protected int[] P00045_Arkeyid ;
      protected bool[] P00045_nrkeyid ;
   }

   public class reorg__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00012 ;
          prmP00012 = new Object[] {
          } ;
          Object[] prmP00023 ;
          prmP00023 = new Object[] {
          } ;
          Object[] prmP00034 ;
          prmP00034 = new Object[] {
          new Object[] {"@sTableName",SqlDbType.Char,255,0} ,
          new Object[] {"@sMySchemaName",SqlDbType.Char,255,0}
          } ;
          Object[] prmP00045 ;
          prmP00045 = new Object[] {
          new Object[] {"@sTableName",SqlDbType.Char,255,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00012", "SELECT SCHEMA_NAME() ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00012,100,0,true,false )
             ,new CursorDef("P00023", "SELECT USER_NAME() ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00023,100,0,true,false )
             ,new CursorDef("P00034", "SELECT [TABLE_NAME], [TABLE_SCHEMA] FROM INFORMATION_SCHEMA.TABLES WHERE ([TABLE_NAME] = @sTableName) AND ([TABLE_SCHEMA] = @sMySchemaName) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00034,100,0,true,false )
             ,new CursorDef("P00045", "SELECT OBJECT_NAME(object_id), OBJECT_NAME(parent_object_id), [referenced_object_id] FROM sys.foreign_keys WHERE [referenced_object_id] = OBJECT_ID(RTRIM(LTRIM(@sTableName))) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00045,100,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 255) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 255) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
