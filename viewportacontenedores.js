/*
               File: ViewPortaContenedores
        Description: View Porta Contenedores
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 7:38:22.39
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
gx.define('viewportacontenedores', false, function () {
   this.ServerClass =  "viewportacontenedores" ;
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
      this.AV13PortaContenedoresEsclusa=gx.fn.getIntegerValue("vPORTACONTENEDORESESCLUSA",gx.thousandSeparator) ;
      this.AV7TabCode=gx.fn.getControlValue("vTABCODE") ;
   };
   this.s112_client=function()
   {
      if ( this.AV12LoadAllTabs || this.AV8SelectedTabCode == "" || this.AV8SelectedTabCode == gx.getMessage( "General") )
      {
         this.createWebComponent('Generalwc','PortaContenedoresGeneral',[this.AV13PortaContenedoresEsclusa]);
      }
      if ( this.AV12LoadAllTabs || this.AV8SelectedTabCode == gx.getMessage( "Rango") )
      {
         this.createWebComponent('Rangowc','PortaContenedoresRangoWC',[this.AV13PortaContenedoresEsclusa]);
      }
   };
   this.e13121_client=function()
   {
      this.clearMessages();
      this.AV8SelectedTabCode = this.TABContainer.ActivePageControlName ;
      this.AV12LoadAllTabs = false ;
      this.s112_client();
      this.refreshOutputs([{av:'AV8SelectedTabCode',fld:'vSELECTEDTABCODE'},{av:'AV12LoadAllTabs',fld:'vLOADALLTABS'},{ctrl:'GENERALWC'},{ctrl:'RANGOWC'}]);
   };
   this.e14122_client=function()
   {
      this.executeServerEvent("ENTER", true);
   };
   this.e15122_client=function()
   {
      this.executeServerEvent("CANCEL", true);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,19,20,22,23,24,27,28,30,31,32];
   this.GXLastCtrlId =32;
   this.TABContainer = gx.uc.getNew(this, 17, 14, "Tab", "TABContainer", "Tab");
   var TABContainer = this.TABContainer;
   TABContainer.setProp("ActivePage", "Activepage", '', "int");
   TABContainer.setDynProp("ActivePageControlName", "Activepagecontrolname", "", "char");
   TABContainer.setProp("PageCount", "Pagecount", 2, "num");
   TABContainer.setProp("Class", "Class", "Tab", "str");
   TABContainer.setProp("HistoryManagement", "Historymanagement", true, "bool");
   TABContainer.setProp("Visible", "Visible", true, "bool");
   TABContainer.setProp("Enabled", "Enabled", false, "boolean");
   TABContainer.setC2ShowFunction(function(UC) { UC.show(); });
   TABContainer.addEventHandler("TabChanged", this.e13121_client);
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
   GXValidFnc[11]={fld:"PORTACONTENEDORESESCLUSADESC_CONTAINER",grid:0};
   GXValidFnc[12]={fld:"", format:0,grid:0};
   GXValidFnc[13]={fld:"",grid:0};
   GXValidFnc[14]={lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"PORTACONTENEDORESESCLUSADESC",gxz:"Z23PortaContenedoresEsclusaDesc",gxold:"O23PortaContenedoresEsclusaDesc",gxvar:"A23PortaContenedoresEsclusaDesc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A23PortaContenedoresEsclusaDesc=Value},v2z:function(Value){gx.O.Z23PortaContenedoresEsclusaDesc=Value},v2c:function(){gx.fn.setControlValue("PORTACONTENEDORESESCLUSADESC",gx.O.A23PortaContenedoresEsclusaDesc,0)},c2v:function(){gx.O.A23PortaContenedoresEsclusaDesc=this.val()},val:function(){return gx.fn.getControlValue("PORTACONTENEDORESESCLUSADESC")},nac:gx.falseFn};
   GXValidFnc[15]={fld:"",grid:0};
   GXValidFnc[16]={fld:"",grid:0};
   GXValidFnc[19]={fld:"GENERAL_TITLE", format:0,grid:0};
   GXValidFnc[20]={fld:"",grid:0};
   GXValidFnc[22]={fld:"",grid:0};
   GXValidFnc[23]={fld:"",grid:0};
   GXValidFnc[24]={fld:"",grid:0};
   GXValidFnc[27]={fld:"RANGO_TITLE", format:0,grid:0};
   GXValidFnc[28]={fld:"",grid:0};
   GXValidFnc[30]={fld:"",grid:0};
   GXValidFnc[31]={fld:"",grid:0};
   GXValidFnc[32]={fld:"",grid:0};
   this.A23PortaContenedoresEsclusaDesc = "" ;
   this.Z23PortaContenedoresEsclusaDesc = "" ;
   this.O23PortaContenedoresEsclusaDesc = "" ;
   this.A23PortaContenedoresEsclusaDesc = "" ;
   this.AV13PortaContenedoresEsclusa = 0 ;
   this.AV7TabCode = "" ;
   this.A22PortaContenedoresEsclusa = 0 ;
   this.AV12LoadAllTabs = false ;
   this.AV8SelectedTabCode = "" ;
   this.Events = {"e14122_client": ["ENTER", true] ,"e15122_client": ["CANCEL", true] ,"s112_client": ["'LOAD TAB'", false] ,"e13121_client": ["TAB.TABCHANGED", false]};
   this.EvtParms["REFRESH"] = [[],[]];
   this.EvtParms["TAB.TABCHANGED"] = [[{av:'AV10Tab',fld:'TAB'},{av:'AV12LoadAllTabs',fld:'vLOADALLTABS'},{av:'AV8SelectedTabCode',fld:'vSELECTEDTABCODE'},{av:'AV13PortaContenedoresEsclusa',fld:'vPORTACONTENEDORESESCLUSA'}],[{av:'AV8SelectedTabCode',fld:'vSELECTEDTABCODE'},{av:'AV12LoadAllTabs',fld:'vLOADALLTABS'},{ctrl:'GENERALWC'},{ctrl:'RANGOWC'}]];
   this.setVCMap("AV12LoadAllTabs", "vLOADALLTABS", 0, "boolean");
   this.setVCMap("AV8SelectedTabCode", "vSELECTEDTABCODE", 0, "char");
   this.setVCMap("AV13PortaContenedoresEsclusa", "vPORTACONTENEDORESESCLUSA", 0, "int");
   this.setVCMap("AV7TabCode", "vTABCODE", 0, "char");
   this.InitStandaloneVars( );
   this.setComponent({id: "GENERALWC" ,GXClass: null , Prefix: "W0025" , lvl: 1 });
   this.setComponent({id: "RANGOWC" ,GXClass: null , Prefix: "W0033" , lvl: 1 });
});
gx.createParentObj(viewportacontenedores);
