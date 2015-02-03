/*
               File: reorganization
        Description: No description for object
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 7:37:48.12
       Program type: Callable routine
          Main DBMS: sqlserver
*/
namespace GeneXus.Programs {
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
   public class reorganization : GXReorganization
   {
      public static void Main( )
      {
         new reorganization().execute();
      }

      [ WebMethod ]
      public ArrayList execute( )
      {
         if ( GeneXus.Configuration.Config.ConfigFileName.Length == 0)
         GeneXus.Configuration.Config.ConfigFileName = "client.exe.config" ;
         try
         {
            new reorg().execute();
            GXReorganization.NotifyEnd();
         }
         catch ( Exception ex )
         {
            if ( IsBadImageFormatException(ex) )
            {
               throw ex ;
            }
            else
            {
               GXReorganization.NotifyError();
               GeneXus.Reorg.GXReorganization.AddMsg( ex.Message , null);
            }
         }
         return GXReorganization.ReorgLog;
      }

      public override void ExecForm( )
      {
         execute();
      }

      public override bool GetCreateDataBase( )
      {
         return true;
      }

   }

}
