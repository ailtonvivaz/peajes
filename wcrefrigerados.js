gx.evt.autoSkip=!1;
gx.define("wcrefrigerados",!1,function(){this.ServerClass="wcrefrigerados";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.skipOnEnter=this.hasEnterEvent=false;this.ajaxSecurityToken=this.supportAjaxEvents=this.fullAjax=this.autoRefresh=true;this.SetStandaloneVars=function(){};this.e14181_client=function(){this.clearMessages();this.AV10Cubierta=this.AV7Tonelaje=0;gx.fn.setCtrlProperty("RESULTADOCARGADOCALCULO","Caption","$0.00");gx.fn.setCtrlProperty("RESULTADOLASTRECALCULO","Caption",
"$0.00");this.refreshOutputs([{av:"AV7Tonelaje",fld:"vTONELAJE"},{av:"AV10Cubierta",fld:"vCUBIERTA"},{av:'gx.fn.getCtrlProperty("RESULTADOCARGADOCALCULO","Caption")',ctrl:"RESULTADOCARGADOCALCULO",prop:"Caption"},{av:'gx.fn.getCtrlProperty("RESULTADOLASTRECALCULO","Caption")',ctrl:"RESULTADOLASTRECALCULO",prop:"Caption"}])};this.e11182_client=function(){this.executeServerEvent("'CALCULAR'",false)};this.e15182_client=function(){this.executeServerEvent("ENTER",true)};this.e16182_client=function(){this.executeServerEvent("CANCEL",
true)};var a=this.GXValidFnc=[];this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,30,31,33,34,35,36,37,38,39,42,44,46,48,49,50];this.GXLastCtrlId=50;a[2]={fld:"",grid:0};a[3]={fld:"MAINTABLE",grid:0};a[4]={fld:"",grid:0};a[5]={fld:"",grid:0};a[6]={fld:"GROUP1",grid:0};a[7]={fld:"GROUP1TABLE",grid:0};a[8]={fld:"",grid:0};a[9]={fld:"",grid:0};a[10]={fld:"GRIDTABLE",grid:0};a[11]={fld:"",grid:0};a[12]={fld:"",grid:0};a[13]={fld:"TONELAJE_CONTAINER",grid:0};a[14]={fld:"",format:0,
grid:0};a[15]={fld:"",grid:0};a[16]={lvl:0,type:"int",len:10,dec:0,sign:false,pic:"Z,ZZZ,ZZZ,ZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vTONELAJE",gxz:"ZV7Tonelaje",gxold:"OV7Tonelaje",gxvar:"AV7Tonelaje",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7Tonelaje=gx.num.intval(a)},v2z:function(a){gx.O.ZV7Tonelaje=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vTONELAJE",gx.O.AV7Tonelaje,0)},c2v:function(){gx.O.AV7Tonelaje=gx.num.intval(this.val())},
val:function(){return gx.fn.getIntegerValue("vTONELAJE",gx.thousandSeparator)},nac:gx.falseFn};a[17]={fld:"",grid:0};a[18]={fld:"CUBIERTA_CONTAINER",grid:0};a[19]={fld:"",format:0,grid:0};a[20]={fld:"",grid:0};a[21]={lvl:0,type:"int",len:10,dec:0,sign:false,pic:"Z,ZZZ,ZZZ,ZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vCUBIERTA",gxz:"ZV10Cubierta",gxold:"OV10Cubierta",gxvar:"AV10Cubierta",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV10Cubierta=gx.num.intval(a)},
v2z:function(a){gx.O.ZV10Cubierta=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCUBIERTA",gx.O.AV10Cubierta,0)},c2v:function(){gx.O.AV10Cubierta=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vCUBIERTA",gx.thousandSeparator)},nac:gx.falseFn};a[22]={fld:"",grid:0};a[23]={fld:"",grid:0};a[24]={fld:"TABLE3",grid:0};a[30]={fld:"",grid:0};a[31]={fld:"",grid:0};a[33]={fld:"",grid:0};a[34]={fld:"",grid:0};a[35]={fld:"GROUP2",grid:0};a[36]={fld:"GROUP2TABLE",grid:0};a[37]=
{fld:"",grid:0};a[38]={fld:"",grid:0};a[39]={fld:"TABLE1",grid:0};a[42]={fld:"RESULTADOCARGADOTEXTO",format:0,grid:0};a[44]={fld:"RESULTADOCARGADOCALCULO",format:0,grid:0};a[46]={fld:"RESULTADOLASTRETEXTO",format:0,grid:0};a[48]={fld:"RESULTADOLASTRECALCULO",format:0,grid:0};a[49]={fld:"",grid:0};a[50]={fld:"",grid:0};this.AV10Cubierta=this.AV7Tonelaje=this.OV10Cubierta=this.ZV10Cubierta=this.AV10Cubierta=this.OV7Tonelaje=this.ZV7Tonelaje=this.AV7Tonelaje=0;this.AV9SdtResultado={};this.Events={e11182_client:["'CALCULAR'",
true],e15182_client:["ENTER",true],e16182_client:["CANCEL",true],e14181_client:["'LIMPIAR'",false]};this.EvtParms.REFRESH=[[],[]];this.EvtParms["'LIMPIAR'"]=[[],[{av:"AV7Tonelaje",fld:"vTONELAJE"},{av:"AV10Cubierta",fld:"vCUBIERTA"},{av:'gx.fn.getCtrlProperty("RESULTADOCARGADOCALCULO","Caption")',ctrl:"RESULTADOCARGADOCALCULO",prop:"Caption"},{av:'gx.fn.getCtrlProperty("RESULTADOLASTRECALCULO","Caption")',ctrl:"RESULTADOLASTRECALCULO",prop:"Caption"}]];this.EvtParms["'CALCULAR'"]=[[{av:"AV7Tonelaje",
fld:"vTONELAJE"},{av:"AV10Cubierta",fld:"vCUBIERTA"},{av:"AV9SdtResultado",fld:"vSDTRESULTADO"}],[{av:"AV9SdtResultado",fld:"vSDTRESULTADO"},{av:'gx.fn.getCtrlProperty("RESULTADOCARGADOCALCULO","Caption")',ctrl:"RESULTADOCARGADOCALCULO",prop:"Caption"},{av:'gx.fn.getCtrlProperty("RESULTADOLASTRECALCULO","Caption")',ctrl:"RESULTADOLASTRECALCULO",prop:"Caption"}]];this.InitStandaloneVars();this.setComponent({id:"COMPONENT1",GXClass:"wcnota",Prefix:"W0051",lvl:1})});gx.createParentObj(wcrefrigerados);
