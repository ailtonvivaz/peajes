using System;
using GeneXus.Builder;
using System.IO;
public class bldawscalcularlpg : GxBaseBuilder
{
   string cs_path = "." ;
   public bldawscalcularlpg( ) : base()
   {
   }

   public override int BeforeCompile( )
   {
      return 0 ;
   }

   public override int AfterCompile( )
   {
      int ErrCode ;
      ErrCode = 0;
      return ErrCode ;
   }

   static public int Main( string[] args )
   {
      bldawscalcularlpg x = new bldawscalcularlpg() ;
      x.SetMainSourceFile( "awscalcularlpg.cs");
      x.LoadVariables( args);
      return x.CompileAll( );
   }

   public override ItemCollection GetSortedBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\GeneXus.Programs.Common.dll", cs_path + @"\genexus.programs.common.rsp");
      return sc ;
   }

   public override TargetCollection GetRuntimeBuildList( )
   {
      TargetCollection sc = new TargetCollection() ;
      sc.Add( @"awscalcularlpg", "dll");
      return sc ;
   }

   public override ItemCollection GetResBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\messages.eng.dll", cs_path + @"\messages.eng.txt");
      sc.Add( @"bin\messages.spa.dll", cs_path + @"\messages.spa.txt");
      return sc ;
   }

   public override bool ToBuild( String obj )
   {
      if (checkTime(obj, cs_path + @"\bin\GxClasses.dll" ))
         return true;
      if ( obj == @"bin\GeneXus.Programs.Common.dll" )
      {
         if (checkTime(obj, cs_path + @"\type_SdtSdtResultadoPortaContenedores.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSDTGraneleros.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSdtResultado.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtTabOptions_TabOptionsItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtProgramNames_ProgramName.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGridState.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGridState_FilterValue.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtContext.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtLinkList_LinkItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxObjectCollection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxSilentTrnGridCollection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\SoapParm.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxWebStd.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxFullTextSearchReindexer.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxModelInfoProvider.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINCryptoSignAlgorithm.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINAPIAuthorizationStatus.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINMessageTypes.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINProgressIndicatorType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINIMEMode.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINRecentLinksOptions.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINCallTargetSize.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINDominioSegmento.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINDominioTipoEsclusa.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINDominioEstadoCarga.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINHttpMethod.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINPage.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINTrnMode.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINDominioEsclusa.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINDominioEstado.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINDominioGranos.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINDominioBandas.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINDominioPasajerosTipoCobro.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINDominioIMO.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINDominioQuimiquerosTipo.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINEncoding.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINTimezones.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINEffect.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINCallType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINCryptoEncryptAlgorithm.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINCryptoHashAlgorithm.cs" ))
            return true;
      }
      if ( obj == @"bin\messages.eng.dll" )
      {
         if (checkTime(obj, cs_path + @"\messages.eng.txt" ))
            return true;
      }
      if ( obj == @"bin\messages.spa.dll" )
      {
         if (checkTime(obj, cs_path + @"\messages.spa.txt" ))
            return true;
      }
      return false ;
   }

}

