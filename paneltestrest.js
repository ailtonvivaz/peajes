/*
               File: PanelTestRest
        Description: Panel Test Rest
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 7:38:22.67
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
gx.define('paneltestrest', false, function () {
   this.ServerClass =  "paneltestrest" ;
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
   };
   this.e111h2_client=function()
   {
      this.executeServerEvent("'REST'", false);
   };
   this.e131h2_client=function()
   {
      this.executeServerEvent("ENTER", true);
   };
   this.e141h2_client=function()
   {
      this.executeServerEvent("CANCEL", true);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5];
   this.GXLastCtrlId =5;
   GXValidFnc[2]={fld:"",grid:0};
   GXValidFnc[3]={fld:"MAINTABLE",grid:0};
   GXValidFnc[4]={fld:"",grid:0};
   GXValidFnc[5]={fld:"",grid:0};
   this.Events = {"e111h2_client": ["'REST'", true] ,"e131h2_client": ["ENTER", true] ,"e141h2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[],[]];
   this.EvtParms["'REST'"] = [[],[{av:'AV8Resultado',fld:'vRESULTADO'}]];
   this.InitStandaloneVars( );
});
gx.createParentObj(paneltestrest);
