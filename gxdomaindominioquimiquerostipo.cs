/*
               File: DominioQuimiquerosTipo
        Description: DominioQuimiquerosTipo
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:15:7.20
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
   public class gxdomaindominioquimiquerostipo
   {
      private static Hashtable domain = new Hashtable();
      static gxdomaindominioquimiquerostipo ()
      {
         domain[(short)1] = "Pure Chemical Tanker";
         domain[(short)2] = "Chemical Oil Tanker";
         domain[(short)3] = "Chemical Parcel Tanker";
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
