/*
               File: Encoding
        Description: Encoding
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/26/2015 11:15:7.23
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
   public class gxdomainencoding
   {
      private static Hashtable domain = new Hashtable();
      static gxdomainencoding ()
      {
         domain["US-ASCII"] = "ASCII";
         domain["Big5"] = "Big5";
         domain["Big5-HKSCS"] = "Big5-HKSCS";
         domain["EUC-JP"] = "EUC-JP";
         domain["EUC-KR"] = "EUC-KR";
         domain["GB18030"] = "GB18030";
         domain["GB2312"] = "GB2312";
         domain["GBK"] = "GBK";
         domain["IBM850"] = "IBM850";
         domain["ISO-2022-JP"] = "ISO-2022-JP";
         domain["ISO-8859-1"] = "ISO-8859-1";
         domain["ISO-8859-10"] = "ISO-8859-10";
         domain["ISO-8859-13"] = "ISO-8859-13";
         domain["ISO-8859-15"] = "ISO-8859-15";
         domain["ISO-8859-16"] = "ISO-8859-16";
         domain["ISO-8859-2"] = "ISO-8859-2";
         domain["ISO-8859-3"] = "ISO-8859-3";
         domain["ISO-8859-4"] = "ISO-8859-4";
         domain["ISO-8859-5"] = "ISO-8859-5";
         domain["ISO-8859-6"] = "ISO-8859-6";
         domain["ISO-8859-7"] = "ISO-8859-7";
         domain["ISO-8859-8"] = "ISO-8859-8";
         domain["ISO-8859-9"] = "ISO-8859-9";
         domain["KOI8-R"] = "KOI8-R";
         domain["KOI8-U"] = "KOI8-U";
         domain["KS_C_5601-1987"] = "KS_C_5601-1987";
         domain["Shift_JIS"] = "Shift_JIS";
         domain["TIS-620"] = "TIS-620";
         domain["UTF-32"] = "UTF-32";
         domain["UTF-32 BOM"] = "UTF-32 BOM";
         domain["UTF-32BE BOM"] = "UTF-32BE BOM";
         domain["UTF-32LE BOM"] = "UTF-32LE BOM";
         domain["UTF-8"] = "UTF-8";
         domain["UTF-8 BOM"] = "UTF-8 BOM";
         domain["Windows-1250"] = "Windows-1250";
         domain["Windows-1251"] = "Windows-1251";
         domain["Windows-1252"] = "Windows-1252";
         domain["Windows-1253"] = "Windows-1253";
         domain["Windows-1254"] = "Windows-1254";
         domain["Windows-1255"] = "Windows-1255";
         domain["Windows-1256"] = "Windows-1256";
         domain["Windows-1257"] = "Windows-1257";
         domain["Windows-1258"] = "Windows-1258";
         domain["Windows-31J"] = "Windows-31J";
         domain["Windows-874"] = "Windows-874";
         domain["UTF-16BE BOM"] = "UTF-16BE BOM";
         domain["UTF-16LE BOM"] = "UTF-16LE BOM";
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
