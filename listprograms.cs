/*
               File: ListPrograms
        Description: List Programs
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:14:55.61
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
   public class listprograms : GXProcedure
   {
      public listprograms( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("Flat");
      }

      public listprograms( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out IGxCollection aP0_ProgramNames )
      {
         this.AV10ProgramNames = new GxObjectCollection( context, "ProgramNames.ProgramName", "CalcularPeajes", "SdtProgramNames_ProgramName", "GeneXus.Programs") ;
         initialize();
         executePrivate();
         aP0_ProgramNames=this.AV10ProgramNames;
      }

      public IGxCollection executeUdp( )
      {
         this.AV10ProgramNames = new GxObjectCollection( context, "ProgramNames.ProgramName", "CalcularPeajes", "SdtProgramNames_ProgramName", "GeneXus.Programs") ;
         initialize();
         executePrivate();
         aP0_ProgramNames=this.AV10ProgramNames;
         return AV10ProgramNames ;
      }

      public void executeSubmit( out IGxCollection aP0_ProgramNames )
      {
         listprograms objlistprograms;
         objlistprograms = new listprograms();
         objlistprograms.AV10ProgramNames = new GxObjectCollection( context, "ProgramNames.ProgramName", "CalcularPeajes", "SdtProgramNames_ProgramName", "GeneXus.Programs") ;
         objlistprograms.context.SetSubmitInitialConfig(context);
         objlistprograms.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objlistprograms);
         aP0_ProgramNames=this.AV10ProgramNames;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((listprograms)stateInfo).executePrivate();
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
         AV10ProgramNames = new GxObjectCollection( context, "ProgramNames.ProgramName", "CalcularPeajes", "SdtProgramNames_ProgramName", "GeneXus.Programs");
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'ADDPROGRAM' Routine */
         AV8IsAuthorized = true;
         GXt_boolean1 = AV8IsAuthorized;
         new isauthorized(context ).execute(  AV12name, out  GXt_boolean1) ;
         AV8IsAuthorized = GXt_boolean1;
         if ( AV8IsAuthorized )
         {
            AV11ProgramName = new SdtProgramNames_ProgramName(context);
            AV11ProgramName.gxTpr_Name = AV12name;
            AV11ProgramName.gxTpr_Description = AV13description;
            AV11ProgramName.gxTpr_Link = AV14link;
            AV10ProgramNames.Add(AV11ProgramName, 0);
         }
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
         AV12name = "";
         AV11ProgramName = new SdtProgramNames_ProgramName(context);
         AV13description = "";
         AV14link = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private String AV12name ;
      private String AV13description ;
      private String AV14link ;
      private IGxCollection aP0_ProgramNames ;
      [ObjectCollection(ItemType=typeof( SdtProgramNames_ProgramName ))]
      private IGxCollection AV10ProgramNames ;
      private SdtProgramNames_ProgramName AV11ProgramName ;
   }

}
