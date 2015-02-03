/*
               File: ViewTarifasGranelesSecos
        Description: View Tarifas Graneles Secos
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 7:38:22.58
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
gx.define('viewtarifasgranelessecos', false, function () {
   this.ServerClass =  "viewtarifasgranelessecos" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = false;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV12LoadAllTabs=gx.fn.getControlValue("vLOADALLTABS") ;
      this.AV8SelectedTabCode=gx.fn.getControlValue("vSELECTEDTABCODE") ;
      this.AV13TarifasGranelesSecosCodPeaje=gx.fn.getIntegerValue("vTARIFASGRANELESSECOSCODPEAJE",gx.thousandSeparator) ;
      this.AV7TabCode=gx.fn.getControlValue("vTABCODE") ;
   };
   this.s112_client=function()
   {
      if ( this.AV12LoadAllTabs || this.AV8SelectedTabCode == "" || this.AV8SelectedTabCode == gx.getMessage( "General") )
      {
         this.createWebComponent('Generalwc','TarifasGranelesSecosGeneral',[this.AV13TarifasGranelesSecosCodPeaje]);
      }
   };
   this.e131g1_client=function()
   {
      this.clearMessages();
      this.AV8SelectedTabCode = this.TABContainer.ActivePageControlName ;
      this.AV12LoadAllTabs = false ;
      this.s112_client();
      this.refreshOutputs([{av:'AV8SelectedTabCode',fld:'vSELECTEDTABCODE'},{av:'AV12LoadAllTabs',fld:'vLOADALLTABS'},{ctrl:'GENERALWC'}]);
   };
   this.e141g2_client=function()
   {
      this.executeServerEvent("ENTER", true);
   };
   this.e151g2_client=function()
   {
      this.executeServerEvent("CANCEL", true);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,13,14,16,17,18];
   this.GXLastCtrlId =18;
   this.TABContainer = gx.uc.getNew(this, 11, 0, "Tab", "TABContainer", "Tab");
   var TABContainer = this.TABContainer;
   TABContainer.setProp("ActivePage", "Activepage", '', "int");
   TABContainer.setDynProp("ActivePageControlName", "Activepagecontrolname", "", "char");
   TABContainer.setProp("PageCount", "Pagecount", 1, "num");
   TABContainer.setProp("Class", "Class", "Tab", "str");
   TABContainer.setProp("HistoryManagement", "Historymanagement", true, "bool");
   TABContainer.setProp("Visible", "Visible", true, "bool");
   TABContainer.setProp("Enabled", "Enabled", false, "boolean");
   TABContainer.setC2ShowFunction(function(UC) { UC.show(); });
   TABContainer.addEventHandler("TabChanged", this.e131g1_client);
   this.setUserControl(TABContainer);
   GXValidFnc[2]={fld:"",grid:0};
   GXValidFnc[3]={fld:"MAIN",grid:0};
   GXValidFnc[4]={fld:"",grid:0};
   GXValidFnc[5]={fld:"",grid:0};
   GXValidFnc[6]={fld:"VIEWTITLE", format:0,grid:0};
   GXValidFnc[7]={fld:"",grid:0};
   GXValidFnc[8]={fld:"VIEWALL", format:0,grid:0};
   GXValidFnc[9]={fld:"",grid:0};
   GXValidFnc[10]={fld:"",grid:0};
   GXValidFnc[13]={fld:"GENERAL_TITLE", format:0,grid:0};
   GXValidFnc[14]={fld:"",grid:0};
   GXValidFnc[16]={fld:"",grid:0};
   GXValidFnc[17]={fld:"",grid:0};
   GXValidFnc[18]={fld:"",grid:0};
   this.AV13TarifasGranelesSecosCodPeaje = 0 ;
   this.AV7TabCode = "" ;
   this.A51TarifasGranelesSecosCodPeaje = 0 ;
   this.AV12LoadAllTabs = false ;
   this.AV8SelectedTabCode = "" ;
   this.Events = {"e141g2_client": ["ENTER", true] ,"e151g2_client": ["CANCEL", true] ,"s112_client": ["'LOAD TAB'", false] ,"e131g1_client": ["TAB.TABCHANGED", false]};
   this.EvtParms["REFRESH"] = [[],[]];
   this.EvtParms["TAB.TABCHANGED"] = [[{av:'AV10Tab',fld:'TAB'},{av:'AV12LoadAllTabs',fld:'vLOADALLTABS'},{av:'AV8SelectedTabCode',fld:'vSELECTEDTABCODE'},{av:'AV13TarifasGranelesSecosCodPeaje',fld:'vTARIFASGRANELESSECOSCODPEAJE'}],[{av:'AV8SelectedTabCode',fld:'vSELECTEDTABCODE'},{av:'AV12LoadAllTabs',fld:'vLOADALLTABS'},{ctrl:'GENERALWC'}]];
   this.setVCMap("AV12LoadAllTabs", "vLOADALLTABS", 0, "boolean");
   this.setVCMap("AV8SelectedTabCode", "vSELECTEDTABCODE", 0, "char");
   this.setVCMap("AV13TarifasGranelesSecosCodPeaje", "vTARIFASGRANELESSECOSCODPEAJE", 0, "int");
   this.setVCMap("AV7TabCode", "vTABCODE", 0, "char");
   this.InitStandaloneVars( );
   this.setComponent({id: "GENERALWC" ,GXClass: null , Prefix: "W0019" , lvl: 1 });
});
gx.createParentObj(viewtarifasgranelessecos);
