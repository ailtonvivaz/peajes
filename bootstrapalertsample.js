gx.evt.autoSkip=!1;
gx.define("bootstrapalertsample",!1,function(){this.ServerClass="bootstrapalertsample";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.skipOnEnter=this.hasEnterEvent=false;this.ajaxSecurityToken=this.supportAjaxEvents=this.fullAjax=this.autoRefresh=true;this.SetStandaloneVars=function(){};this.e111r1_client=function(){this.clearMessages();this.addMessage(gx.getMessage("Default Message"));this.refreshOutputs([])};this.e131r1_client=function(){this.clearMessages();this.addMessage(gx.getMessage("<strong>Oh snap!</strong> Change a few things up and try submitting again.</strong>[[danger]]"));
this.refreshOutputs([])};this.e141r1_client=function(){this.clearMessages();this.addMessage(gx.getMessage("<strong>Well done!</strong> You successfully read this important alert message.[[success]]"));this.refreshOutputs([])};this.e121r1_client=function(){this.clearMessages();this.addMessage(gx.getMessage("<strong>Warning!</strong> Best check yo self, you're not looking too good.[[warning]]"));this.refreshOutputs([])};this.e151r1_client=function(){this.clearMessages();this.addMessage(gx.getMessage("<strong>Heads up!</strong> This alert needs your attention, but it's not super important.[[info]]"));
this.refreshOutputs([])};this.e161r1_client=function(){this.clearMessages();this.addMessage(gx.getMessage("Default Message"));this.addMessage(gx.getMessage("<strong>Oh snap!</strong> Change a few things up and try submitting again.</strong>[[danger]]"));this.addMessage(gx.getMessage("<strong>Well done!</strong> You successfully read this important alert message.[[success]]"));this.addMessage(gx.getMessage("<strong>Warning!</strong> Best check yo self, you're not looking too good.[[warning]]"));this.addMessage(gx.getMessage("<strong>Heads up!</strong> This alert needs your attention, but it's not super important.[[info]]"));
this.refreshOutputs([])};this.e181r2_client=function(){this.executeServerEvent("ENTER",true)};this.e191r2_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXLastCtrlId=0;var a=this.BOOTSTRAPALERT1Container=gx.uc.getNew(this,3,0,"BootstrapAlert","BOOTSTRAPALERT1Container","Bootstrapalert1");a.setProp("Width","Width","100%","str");a.setProp("Height","Height","50","str");a.setProp("Visible","Visible",true,"bool");a.setProp("Enabled","Enabled",false,"boolean");a.setProp("Class",
"Class","","char");a.setC2ShowFunction(function(a){a.show()});this.setUserControl(a);this.Events={e181r2_client:["ENTER",true],e191r2_client:["CANCEL",true],e111r1_client:["'DEFAULT'",false],e131r1_client:["'DANGER'",false],e141r1_client:["'SUCCESS'",false],e121r1_client:["'WARNING'",false],e151r1_client:["'INFO'",false],e161r1_client:["'ALL'",false]};this.EvtParms.REFRESH=[[],[]];this.EvtParms["'DEFAULT'"]=[[],[]];this.EvtParms["'DANGER'"]=[[],[]];this.EvtParms["'SUCCESS'"]=[[],[]];this.EvtParms["'WARNING'"]=
[[],[]];this.EvtParms["'INFO'"]=[[],[]];this.EvtParms["'ALL'"]=[[],[]];this.InitStandaloneVars()});gx.createParentObj(bootstrapalertsample);
