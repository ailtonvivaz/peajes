/*
               File: DominioBandas
        Description: DominioBandas
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:15:7.15
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
   public class gxdomaindominiobandas
   {
      private static Hashtable domain = new Hashtable();
      static gxdomaindominiobandas ()
      {
         domain["Seleccione"] = "Seleccione";
         domain["1eros 5,000"] = "1eros 5,000";
         domain["2-  Sig. 5,000"] = "2-  Sig. 5,000";
         domain["3-  Sig. 10,000"] = "3-  Sig. 10,000";
         domain["4-  Sig. 20,000"] = "4-  Sig. 20,000";
         domain["5-  Sig. 20,000"] = "5-  Sig. 20,000";
         domain["6-  Sig. 25,000"] = "6-  Sig. 25,000";
         domain["7-  Sig. 35,000"] = "7-  Sig. 35,000";
         domain["8-  Resto"] = "8-  Resto";
      }

      public static string getDescription( IGxContext context ,
                                           String key )
      {
         string rtkey ;
         rtkey = StringUtil.Trim( (String)(key));
         return context.GetMessage( (String)(domain[rtkey]), "") ;
      }

      public static GxSimpleCollection getValues( )
      {
         GxSimpleCollection value = new GxSimpleCollection();
         ArrayList aKeys = new ArrayList(domain.Keys);
         aKeys.Sort();
         foreach (String key in aKeys)
         {
            value.Add(key);
         }
         return value;
      }

   }

}
