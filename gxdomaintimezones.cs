/*
               File: Timezones
        Description: Timezones
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:15:7.28
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
   public class gxdomaintimezones
   {
      private static Hashtable domain = new Hashtable();
      static gxdomaintimezones ()
      {
         domain["Africa/Cairo"] = "Africa/Cairo";
         domain["Africa/Johannesburg"] = "Africa/Johannesburg";
         domain["Africa/Lagos"] = "Africa/Lagos";
         domain["America/Anchorage"] = "America/Anchorage";
         domain["America/Argentina/Buenos_Aires"] = "America/Argentina/Buenos_Aires";
         domain["America/Asuncion"] = "America/Asuncion";
         domain["America/Bogota"] = "America/Bogota";
         domain["America/Caracas"] = "America/Caracas";
         domain["America/Chicago"] = "America/Chicago";
         domain["America/Denver"] = "America/Denver";
         domain["America/Godthab"] = "America/Godthab";
         domain["America/Guatemala"] = "America/Guatemala";
         domain["America/Halifax"] = "America/Halifax";
         domain["America/Los_Angeles"] = "America/Los_Angeles";
         domain["America/Mexico_City"] = "America/Mexico_City";
         domain["America/Montevideo"] = "America/Montevideo";
         domain["America/New_York"] = "America/New_York";
         domain["America/Noronha"] = "America/Noronha";
         domain["America/Phoenix"] = "America/Phoenix";
         domain["America/Santiago"] = "America/Santiago";
         domain["America/Santo_Domingo"] = "America/Santo_Domingo";
         domain["America/Sao_Paulo"] = "America/Sao_Paulo";
         domain["America/St_Johns"] = "America/St_Johns";
         domain["Asia/Baghdad"] = "Asia/Baghdad";
         domain["Asia/Beirut"] = "Asia/Beirut";
         domain["Asia/Damascus"] = "Asia/Damascus";
         domain["Asia/Dhaka"] = "Asia/Dhaka";
         domain["Asia/Dubai"] = "Asia/Dubai";
         domain["Asia/Jerusalem"] = "Asia/Jerusalem";
         domain["Asia/Kabul"] = "Asia/Kabul";
         domain["Asia/Karachi"] = "Asia/Karachi";
         domain["Asia/Katmandu"] = "Asia/Katmandu";
         domain["Asia/Kolkata"] = "Asia/Kolkata";
         domain["Asia/Rangoon"] = "Asia/Rangoon";
         domain["Asia/Shanghai"] = "Asia/Shanghai";
         domain["Asia/Tehran"] = "Asia/Tehran";
         domain["Asia/Tokyo"] = "Asia/Tokyo";
         domain["Asia/Yerevan"] = "Asia/Yerevan";
         domain["Atlantic/Azores"] = "Atlantic/Azores";
         domain["Atlantic/Cape_Verde"] = "Atlantic/Cape_Verde";
         domain["Australia/Adelaide"] = "Australia/Adelaide";
         domain["Australia/Brisbane"] = "Australia/Brisbane";
         domain["Australia/Darwin"] = "Australia/Darwin";
         domain["Australia/Sydney"] = "Australia/Sydney";
         domain["Etc/GMT_12"] = "Etc/GMT_12";
         domain["Etc/GMT_2"] = "Etc/GMT_2";
         domain["Etc/UTC"] = "Etc/UTC";
         domain["Europe/Berlin"] = "Europe/Berlin";
         domain["Europe/Helsinki"] = "Europe/Helsinki";
         domain["Europe/Istanbul"] = "Europe/Istanbul";
         domain["Europe/London"] = "Europe/London";
         domain["Pacific/Auckland"] = "Pacific/Auckland";
         domain["Pacific/Honolulu"] = "Pacific/Honolulu";
         domain["Pacific/Noumea"] = "Pacific/Noumea";
         domain["Pacific/Tongatapu"] = "Pacific/Tongatapu";
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
