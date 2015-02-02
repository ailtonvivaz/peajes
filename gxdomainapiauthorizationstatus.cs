/*
               File: APIAuthorizationStatus
        Description: APIAuthorizationStatus
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:15:7.7
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
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class gxdomainapiauthorizationstatus
   {
      private static Hashtable domain = new Hashtable();
      static gxdomainapiauthorizationstatus ()
      {
         domain[(short)0] = "Not Determined";
         domain[(short)1] = "Restricted";
         domain[(short)2] = "Denied";
         domain[(short)3] = "Authorized";
         domain[(short)4] = "Authorized When In Use";
      }

      public static string getDescription( IGxContext context ,
                                           short key )
      {
         return context.GetMessage( (String)(domain[key]), "") ;
      }

      public static GxSimpleCollection getValues( )
      {
         GxSimpleCollection value = new GxSimpleCollection();
         ArrayList aKeys = new ArrayList(domain.Keys);
         aKeys.Sort();
         foreach (short key in aKeys)
         {
            value.Add(key);
         }
         return value;
      }

   }

}
