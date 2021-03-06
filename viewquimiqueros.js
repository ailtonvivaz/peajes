/*
               File: ViewQuimiqueros
        Description: View Quimiqueros
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 7:38:21.61
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
gx.define('viewquimiqueros', false, function () {
   this.ServerClass =  "viewquimiqueros" ;
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
      this.AV13QuimiquerosID=gx.fn.getIntegerValue("vQUIMIQUEROSID",gx.thousandSeparator) ;
      this.AV7TabCode=gx.fn.getControlValue("vTABCODE") ;
   };
   this.s112_client=function()
   {
      if ( this.AV12LoadAllTabs || this.AV8SelectedTabCode == "" || this.AV8SelectedTabCode == gx.getMessage( "General") )
      {
         this.createWebComponent('Generalwc','QuimiquerosGeneral',[this.AV13QuimiquerosID]);
      }
   };
   this.e130o1_client=function()
   {
      this.clearMessages();
      this.AV8SelectedTabCode = this.TABContainer.ActivePageControlName ;
      this.AV12LoadAllTabs = false ;
      this.s112_client();
      this.refreshOutputs([{av:'AV8SelectedTabCode',fld:'vSELECTEDTABCODE'},{av:'AV12LoadAllTabs',fld:'vLOADALLTABS'},{ctrl:'GENERALWC'}]);
   };
   this.e140o2_client=function()
   {
      this.executeServerEvent("ENTER", true);
   };
   this.e150o2_client=function()
   {
      this.executeServerEvent("CANCEL", true);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,19,20,22,23,24];
   this.GXLastCtrlId =24;
   this.TABContainer = gx.uc.getNew(this, 17, 14, "Tab", "TABContainer", "Tab");
   var TABContainer = this.TABContainer;
   TABContainer.setProp("ActivePage", "Activepage", '', "int");
   TABContainer.setDynProp("ActivePageControlName", "Activepagecontrolname", "", "char");
   TABContainer.setProp("PageCount", "Pagecount", 1, "num");
   TABContainer.setProp("Class", "Class", "Tab", "str");
   TABContainer.setProp("HistoryManagement", "Historymanagement", true, "bool");
   TABContainer.setProp("Visible", "Visible", true, "bool");
   TABContainer.setProp("Enabled", "Enabled", false, "boolean");
   TABContainer.setC2ShowFunction(function(UC) { UC.show(); });
   TABContainer.addEventHandler("TabChanged", this.e130o1_client);
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
   GXValidFnc[11]={fld:"QUIMIQUEROSBANDACPSUAB_CONTAINER",grid:0};
   GXValidFnc[12]={fld:"", format:0,grid:0};
   GXValidFnc[13]={fld:"",grid:0};
   GXValidFnc[14]={lvl:0,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"QUIMIQUEROSBANDACPSUAB",gxz:"Z10QuimiquerosBandaCPSUAB",gxold:"O10QuimiquerosBandaCPSUAB",gxvar:"A10QuimiquerosBandaCPSUAB",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A10QuimiquerosBandaCPSUAB=gx.num.intval(Value)},v2z:function(Value){gx.O.Z10QuimiquerosBandaCPSUAB=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("QUIMIQUEROSBANDACPSUAB",gx.O.A10QuimiquerosBandaCPSUAB,0)},c2v:function(){gx.O.A10QuimiquerosBandaCPSUAB=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("QUIMIQUEROSBANDACPSUAB",gx.thousandSeparator)},nac:gx.falseFn};
   GXValidFnc[15]={fld:"",grid:0};
   GXValidFnc[16]={fld:"",grid:0};
   GXValidFnc[19]={fld:"GENERAL_TITLE", format:0,grid:0};
   GXValidFnc[20]={fld:"",grid:0};
   GXValidFnc[22]={fld:"",grid:0};
   GXValidFnc[23]={fld:"",grid:0};
   GXValidFnc[24]={fld:"",grid:0};
   this.A10QuimiquerosBandaCPSUAB = 0 ;
   this.Z10QuimiquerosBandaCPSUAB = 0 ;
   this.O10QuimiquerosBandaCPSUAB = 0 ;
   this.A10QuimiquerosBandaCPSUAB = 0 ;
   this.AV13QuimiquerosID = 0 ;
   this.AV7TabCode = "" ;
   this.A9QuimiquerosID = 0 ;
   this.AV12LoadAllTabs = false ;
   this.AV8SelectedTabCode = "" ;
   this.Events = {"e140o2_client": ["ENTER", true] ,"e150o2_client": ["CANCEL", true] ,"s112_client": ["'LOAD TAB'", false] ,"e130o1_client": ["TAB.TABCHANGED", false]};
   this.EvtParms["REFRESH"] = [[],[]];
   this.EvtParms["TAB.TABCHANGED"] = [[{av:'AV10Tab',fld:'TAB'},{av:'AV12LoadAllTabs',fld:'vLOADALLTABS'},{av:'AV8SelectedTabCode',fld:'vSELECTEDTABCODE'},{av:'AV13QuimiquerosID',fld:'vQUIMIQUEROSID'}],[{av:'AV8SelectedTabCode',fld:'vSELECTEDTABCODE'},{av:'AV12LoadAllTabs',fld:'vLOADALLTABS'},{ctrl:'GENERALWC'}]];
   this.setVCMap("AV12LoadAllTabs", "vLOADALLTABS", 0, "boolean");
   this.setVCMap("AV8SelectedTabCode", "vSELECTEDTABCODE", 0, "char");
   this.setVCMap("AV13QuimiquerosID", "vQUIMIQUEROSID", 0, "int");
   this.setVCMap("AV7TabCode", "vTABCODE", 0, "char");
   this.InitStandaloneVars( );
   this.setComponent({id: "GENERALWC" ,GXClass: null , Prefix: "W0025" , lvl: 1 });
});
gx.createParentObj(viewquimiqueros);
