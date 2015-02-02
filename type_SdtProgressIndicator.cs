/*
               File: type_SdtProgressIndicator
        Description: ProgressIndicator
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/23/2015 13:23:5.75
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
using System.Reflection;
using System.Xml.Serialization;
using System.Data.SqlTypes;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [Serializable]
   public class SdtProgressIndicator : GxUserType, IGxExternalObject
   {
      public SdtProgressIndicator( )
      {
         initialize();
      }

      public SdtProgressIndicator( IGxContext context )
      {
         this.context = context;
         initialize();
      }

      private static Hashtable mapper;
      public override String JsonMap( String value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (String)mapper[value]; ;
      }

      public void show( )
      {
         if ( ProgressIndicator_externalReference == null )
         {
            ProgressIndicator_externalReference = new GeneXus.Notifications.GXWebProgressIndicator(context);
         }
         ProgressIndicator_externalReference.Show();
         return  ;
      }

      public void showwithtitle( String gxTp_title )
      {
         if ( ProgressIndicator_externalReference == null )
         {
            ProgressIndicator_externalReference = new GeneXus.Notifications.GXWebProgressIndicator(context);
         }
         ProgressIndicator_externalReference.ShowWithTitle(gxTp_title);
         return  ;
      }

      public void showwithtitleanddescription( String gxTp_title ,
                                               String gxTp_description )
      {
         if ( ProgressIndicator_externalReference == null )
         {
            ProgressIndicator_externalReference = new GeneXus.Notifications.GXWebProgressIndicator(context);
         }
         ProgressIndicator_externalReference.ShowWithTitleAndDescription(gxTp_title, gxTp_description);
         return  ;
      }

      public void hide( )
      {
         if ( ProgressIndicator_externalReference == null )
         {
            ProgressIndicator_externalReference = new GeneXus.Notifications.GXWebProgressIndicator(context);
         }
         ProgressIndicator_externalReference.Hide();
         return  ;
      }

      public String gxTpr_Class
      {
         get {
            if ( ProgressIndicator_externalReference == null )
            {
               ProgressIndicator_externalReference = new GeneXus.Notifications.GXWebProgressIndicator(context);
            }
            return ProgressIndicator_externalReference.Class ;
         }

         set {
            if ( ProgressIndicator_externalReference == null )
            {
               ProgressIndicator_externalReference = new GeneXus.Notifications.GXWebProgressIndicator(context);
            }
            ProgressIndicator_externalReference.Class = value;
         }

      }

      public short gxTpr_Type
      {
         get {
            if ( ProgressIndicator_externalReference == null )
            {
               ProgressIndicator_externalReference = new GeneXus.Notifications.GXWebProgressIndicator(context);
            }
            return ProgressIndicator_externalReference.Type ;
         }

         set {
            if ( ProgressIndicator_externalReference == null )
            {
               ProgressIndicator_externalReference = new GeneXus.Notifications.GXWebProgressIndicator(context);
            }
            ProgressIndicator_externalReference.Type = value;
         }

      }

      public String gxTpr_Title
      {
         get {
            if ( ProgressIndicator_externalReference == null )
            {
               ProgressIndicator_externalReference = new GeneXus.Notifications.GXWebProgressIndicator(context);
            }
            return ProgressIndicator_externalReference.Title ;
         }

         set {
            if ( ProgressIndicator_externalReference == null )
            {
               ProgressIndicator_externalReference = new GeneXus.Notifications.GXWebProgressIndicator(context);
            }
            ProgressIndicator_externalReference.Title = value;
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( ProgressIndicator_externalReference == null )
            {
               ProgressIndicator_externalReference = new GeneXus.Notifications.GXWebProgressIndicator(context);
            }
            return ProgressIndicator_externalReference.Description ;
         }

         set {
            if ( ProgressIndicator_externalReference == null )
            {
               ProgressIndicator_externalReference = new GeneXus.Notifications.GXWebProgressIndicator(context);
            }
            ProgressIndicator_externalReference.Description = value;
         }

      }

      public int gxTpr_Maxvalue
      {
         get {
            if ( ProgressIndicator_externalReference == null )
            {
               ProgressIndicator_externalReference = new GeneXus.Notifications.GXWebProgressIndicator(context);
            }
            return ProgressIndicator_externalReference.MaxValue ;
         }

         set {
            if ( ProgressIndicator_externalReference == null )
            {
               ProgressIndicator_externalReference = new GeneXus.Notifications.GXWebProgressIndicator(context);
            }
            ProgressIndicator_externalReference.MaxValue = value;
         }

      }

      public int gxTpr_Value
      {
         get {
            if ( ProgressIndicator_externalReference == null )
            {
               ProgressIndicator_externalReference = new GeneXus.Notifications.GXWebProgressIndicator(context);
            }
            return ProgressIndicator_externalReference.Value ;
         }

         set {
            if ( ProgressIndicator_externalReference == null )
            {
               ProgressIndicator_externalReference = new GeneXus.Notifications.GXWebProgressIndicator(context);
            }
            ProgressIndicator_externalReference.Value = value;
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( ProgressIndicator_externalReference == null )
            {
               ProgressIndicator_externalReference = new GeneXus.Notifications.GXWebProgressIndicator(context);
            }
            return ProgressIndicator_externalReference ;
         }

         set {
            ProgressIndicator_externalReference = (GeneXus.Notifications.GXWebProgressIndicator)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected GeneXus.Notifications.GXWebProgressIndicator ProgressIndicator_externalReference=null ;
   }

}
