gx.evt.autoSkip=!1;
gx.define("gx0080",!1,function(){this.ServerClass="gx0080";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.skipOnEnter=false;this.ajaxSecurityToken=this.supportAjaxEvents=this.fullAjax=this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV12pVEH_RORO_ID=gx.fn.getIntegerValue("vPVEH_RORO_ID",gx.thousandSeparator)};this.e171n1_client=function(){this.clearMessages();if(gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"){gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class",
"AdvancedContainer AdvancedContainerVisible");gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")}else{gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer");gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")}this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}])};this.e111n1_client=function(){this.clearMessages();if(gx.fn.getCtrlProperty("VEH_RORO_IDFILTERCONTAINER",
"Class")=="AdvancedContainerItem"){gx.fn.setCtrlProperty("VEH_RORO_IDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded");gx.fn.setCtrlProperty("vCVEH_RORO_ID","Visible",true)}else{gx.fn.setCtrlProperty("VEH_RORO_IDFILTERCONTAINER","Class","AdvancedContainerItem");gx.fn.setCtrlProperty("vCVEH_RORO_ID","Visible",false)}this.refreshOutputs([{av:'gx.fn.getCtrlProperty("VEH_RORO_IDFILTERCONTAINER","Class")',ctrl:"VEH_RORO_IDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVEH_RORO_ID","Visible")',
ctrl:"vCVEH_RORO_ID",prop:"Visible"}])};this.e121n1_client=function(){this.clearMessages();if(gx.fn.getCtrlProperty("VEH_RORO_TON_INIFILTERCONTAINER","Class")=="AdvancedContainerItem"){gx.fn.setCtrlProperty("VEH_RORO_TON_INIFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded");gx.fn.setCtrlProperty("vCVEH_RORO_TON_INI","Visible",true)}else{gx.fn.setCtrlProperty("VEH_RORO_TON_INIFILTERCONTAINER","Class","AdvancedContainerItem");gx.fn.setCtrlProperty("vCVEH_RORO_TON_INI","Visible",
false)}this.refreshOutputs([{av:'gx.fn.getCtrlProperty("VEH_RORO_TON_INIFILTERCONTAINER","Class")',ctrl:"VEH_RORO_TON_INIFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVEH_RORO_TON_INI","Visible")',ctrl:"vCVEH_RORO_TON_INI",prop:"Visible"}])};this.e131n1_client=function(){this.clearMessages();if(gx.fn.getCtrlProperty("VEH_RORO_TON_FINFILTERCONTAINER","Class")=="AdvancedContainerItem"){gx.fn.setCtrlProperty("VEH_RORO_TON_FINFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded");
gx.fn.setCtrlProperty("vCVEH_RORO_TON_FIN","Visible",true)}else{gx.fn.setCtrlProperty("VEH_RORO_TON_FINFILTERCONTAINER","Class","AdvancedContainerItem");gx.fn.setCtrlProperty("vCVEH_RORO_TON_FIN","Visible",false)}this.refreshOutputs([{av:'gx.fn.getCtrlProperty("VEH_RORO_TON_FINFILTERCONTAINER","Class")',ctrl:"VEH_RORO_TON_FINFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVEH_RORO_TON_FIN","Visible")',ctrl:"vCVEH_RORO_TON_FIN",prop:"Visible"}])};this.e141n1_client=function(){this.clearMessages();
if(gx.fn.getCtrlProperty("VEH_RORO_UTIL_INIFILTERCONTAINER","Class")=="AdvancedContainerItem"){gx.fn.setCtrlProperty("VEH_RORO_UTIL_INIFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded");gx.fn.setCtrlProperty("vCVEH_RORO_UTIL_INI","Visible",true)}else{gx.fn.setCtrlProperty("VEH_RORO_UTIL_INIFILTERCONTAINER","Class","AdvancedContainerItem");gx.fn.setCtrlProperty("vCVEH_RORO_UTIL_INI","Visible",false)}this.refreshOutputs([{av:'gx.fn.getCtrlProperty("VEH_RORO_UTIL_INIFILTERCONTAINER","Class")',
ctrl:"VEH_RORO_UTIL_INIFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVEH_RORO_UTIL_INI","Visible")',ctrl:"vCVEH_RORO_UTIL_INI",prop:"Visible"}])};this.e151n1_client=function(){this.clearMessages();if(gx.fn.getCtrlProperty("VEH_RORO_UTIL_FINFILTERCONTAINER","Class")=="AdvancedContainerItem"){gx.fn.setCtrlProperty("VEH_RORO_UTIL_FINFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded");gx.fn.setCtrlProperty("vCVEH_RORO_UTIL_FIN","Visible",true)}else{gx.fn.setCtrlProperty("VEH_RORO_UTIL_FINFILTERCONTAINER",
"Class","AdvancedContainerItem");gx.fn.setCtrlProperty("vCVEH_RORO_UTIL_FIN","Visible",false)}this.refreshOutputs([{av:'gx.fn.getCtrlProperty("VEH_RORO_UTIL_FINFILTERCONTAINER","Class")',ctrl:"VEH_RORO_UTIL_FINFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVEH_RORO_UTIL_FIN","Visible")',ctrl:"vCVEH_RORO_UTIL_FIN",prop:"Visible"}])};this.e161n1_client=function(){this.clearMessages();if(gx.fn.getCtrlProperty("VEH_RORO_TARIFAFILTERCONTAINER","Class")=="AdvancedContainerItem"){gx.fn.setCtrlProperty("VEH_RORO_TARIFAFILTERCONTAINER",
"Class","AdvancedContainerItem AdvancedContainerItemExpanded");gx.fn.setCtrlProperty("vCVEH_RORO_TARIFA","Visible",true)}else{gx.fn.setCtrlProperty("VEH_RORO_TARIFAFILTERCONTAINER","Class","AdvancedContainerItem");gx.fn.setCtrlProperty("vCVEH_RORO_TARIFA","Visible",false)}this.refreshOutputs([{av:'gx.fn.getCtrlProperty("VEH_RORO_TARIFAFILTERCONTAINER","Class")',ctrl:"VEH_RORO_TARIFAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVEH_RORO_TARIFA","Visible")',ctrl:"vCVEH_RORO_TARIFA",prop:"Visible"}])};
this.e201n2_client=function(a){this.executeServerEvent("ENTER",true,a)};this.e211n1_client=function(){this.executeServerEvent("CANCEL",true)};var a=this.GXValidFnc=[];this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,72,73,75,76,77,78,79,80,81];this.GXLastCtrlId=81;var b=this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",74,"Grid1",
"Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0080",[],false,1,false,true,10,true,false,false,"",0,"px",gx.getMessage("GXM_newrow"),true,false,false,null,null,false,"",false,[1,1,1,1]);b.addBitmap("&Linkselection","vLINKSELECTION",75,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");b.addSingleLineEdit(38,76,"VEH_RORO_ID",gx.getMessage("ID"),"","VEH_RORO_ID","int",0,"px",4,4,"right",null,[],38,"VEH_RORO_ID",true,0,false,false,"Attribute",1,"WWColumn");b.addSingleLineEdit(39,
77,"VEH_RORO_TON_INI",gx.getMessage("Rango Inicial TON"),"","VEH_RORO_TON_INI","decimal",0,"px",10,10,"right",null,[],39,"VEH_RORO_TON_INI",true,2,false,false,"DescriptionAttribute",1,"WWColumn");b.addSingleLineEdit(40,78,"VEH_RORO_TON_FIN",gx.getMessage("Rango Final TON"),"","VEH_RORO_TON_FIN","decimal",0,"px",10,10,"right",null,[],40,"VEH_RORO_TON_FIN",true,2,false,false,"Attribute",1,"WWColumn OptionalColumn");b.addSingleLineEdit(43,79,"VEH_RORO_TARIFA",gx.getMessage("Tarifa"),"","VEH_RORO_TARIFA",
"decimal",0,"px",10,10,"right",null,[],43,"VEH_RORO_TARIFA",true,2,false,false,"Attribute",1,"WWColumn OptionalColumn");this.setGrid(b);a[2]={fld:"",grid:0};a[3]={fld:"MAIN",grid:0};a[4]={fld:"",grid:0};a[5]={fld:"",grid:0};a[6]={fld:"ADVANCEDCONTAINER",grid:0};a[7]={fld:"",grid:0};a[8]={fld:"",grid:0};a[9]={fld:"VEH_RORO_IDFILTERCONTAINER",grid:0};a[10]={fld:"",grid:0};a[11]={fld:"",grid:0};a[12]={fld:"LBLVEH_RORO_IDFILTER",format:1,grid:0};a[13]={fld:"",grid:0};a[14]={fld:"",grid:0};a[15]={fld:"",
grid:0};a[16]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCVEH_RORO_ID",gxz:"ZV6cVEH_RORO_ID",gxold:"OV6cVEH_RORO_ID",gxvar:"AV6cVEH_RORO_ID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cVEH_RORO_ID=gx.num.intval(a)},v2z:function(a){gx.O.ZV6cVEH_RORO_ID=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCVEH_RORO_ID",gx.O.AV6cVEH_RORO_ID,0)},c2v:function(){gx.O.AV6cVEH_RORO_ID=gx.num.intval(this.val())},
val:function(){return gx.fn.getIntegerValue("vCVEH_RORO_ID",gx.thousandSeparator)},nac:gx.falseFn};a[17]={fld:"",grid:0};a[18]={fld:"",grid:0};a[19]={fld:"VEH_RORO_TON_INIFILTERCONTAINER",grid:0};a[20]={fld:"",grid:0};a[21]={fld:"",grid:0};a[22]={fld:"LBLVEH_RORO_TON_INIFILTER",format:1,grid:0};a[23]={fld:"",grid:0};a[24]={fld:"",grid:0};a[25]={fld:"",grid:0};a[26]={lvl:0,type:"decimal",len:10,dec:2,sign:false,pic:"ZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],
fld:"vCVEH_RORO_TON_INI",gxz:"ZV7cVEH_RORO_TON_INI",gxold:"OV7cVEH_RORO_TON_INI",gxvar:"AV7cVEH_RORO_TON_INI",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7cVEH_RORO_TON_INI=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.ZV7cVEH_RORO_TON_INI=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(){gx.fn.setDecimalValue("vCVEH_RORO_TON_INI",gx.O.AV7cVEH_RORO_TON_INI,2,gx.decimalPoint)},c2v:function(){gx.O.AV7cVEH_RORO_TON_INI=this.val()},val:function(){return gx.fn.getDecimalValue("vCVEH_RORO_TON_INI",
gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};a[27]={fld:"",grid:0};a[28]={fld:"",grid:0};a[29]={fld:"VEH_RORO_TON_FINFILTERCONTAINER",grid:0};a[30]={fld:"",grid:0};a[31]={fld:"",grid:0};a[32]={fld:"LBLVEH_RORO_TON_FINFILTER",format:1,grid:0};a[33]={fld:"",grid:0};a[34]={fld:"",grid:0};a[35]={fld:"",grid:0};a[36]={lvl:0,type:"decimal",len:10,dec:2,sign:false,pic:"ZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCVEH_RORO_TON_FIN",gxz:"ZV8cVEH_RORO_TON_FIN",
gxold:"OV8cVEH_RORO_TON_FIN",gxvar:"AV8cVEH_RORO_TON_FIN",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8cVEH_RORO_TON_FIN=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.ZV8cVEH_RORO_TON_FIN=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(){gx.fn.setDecimalValue("vCVEH_RORO_TON_FIN",gx.O.AV8cVEH_RORO_TON_FIN,2,gx.decimalPoint)},c2v:function(){gx.O.AV8cVEH_RORO_TON_FIN=this.val()},val:function(){return gx.fn.getDecimalValue("vCVEH_RORO_TON_FIN",
gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};a[37]={fld:"",grid:0};a[38]={fld:"",grid:0};a[39]={fld:"VEH_RORO_UTIL_INIFILTERCONTAINER",grid:0};a[40]={fld:"",grid:0};a[41]={fld:"",grid:0};a[42]={fld:"LBLVEH_RORO_UTIL_INIFILTER",format:1,grid:0};a[43]={fld:"",grid:0};a[44]={fld:"",grid:0};a[45]={fld:"",grid:0};a[46]={lvl:0,type:"decimal",len:10,dec:2,sign:false,pic:"ZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCVEH_RORO_UTIL_INI",gxz:"ZV9cVEH_RORO_UTIL_INI",
gxold:"OV9cVEH_RORO_UTIL_INI",gxvar:"AV9cVEH_RORO_UTIL_INI",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV9cVEH_RORO_UTIL_INI=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.ZV9cVEH_RORO_UTIL_INI=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(){gx.fn.setDecimalValue("vCVEH_RORO_UTIL_INI",gx.O.AV9cVEH_RORO_UTIL_INI,2,gx.decimalPoint)},c2v:function(){gx.O.AV9cVEH_RORO_UTIL_INI=this.val()},val:function(){return gx.fn.getDecimalValue("vCVEH_RORO_UTIL_INI",
gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};a[47]={fld:"",grid:0};a[48]={fld:"",grid:0};a[49]={fld:"VEH_RORO_UTIL_FINFILTERCONTAINER",grid:0};a[50]={fld:"",grid:0};a[51]={fld:"",grid:0};a[52]={fld:"LBLVEH_RORO_UTIL_FINFILTER",format:1,grid:0};a[53]={fld:"",grid:0};a[54]={fld:"",grid:0};a[55]={fld:"",grid:0};a[56]={lvl:0,type:"decimal",len:10,dec:2,sign:false,pic:"ZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCVEH_RORO_UTIL_FIN",gxz:"ZV10cVEH_RORO_UTIL_FIN",
gxold:"OV10cVEH_RORO_UTIL_FIN",gxvar:"AV10cVEH_RORO_UTIL_FIN",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV10cVEH_RORO_UTIL_FIN=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.ZV10cVEH_RORO_UTIL_FIN=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(){gx.fn.setDecimalValue("vCVEH_RORO_UTIL_FIN",gx.O.AV10cVEH_RORO_UTIL_FIN,2,gx.decimalPoint)},c2v:function(){gx.O.AV10cVEH_RORO_UTIL_FIN=this.val()},val:function(){return gx.fn.getDecimalValue("vCVEH_RORO_UTIL_FIN",
gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};a[57]={fld:"",grid:0};a[58]={fld:"",grid:0};a[59]={fld:"VEH_RORO_TARIFAFILTERCONTAINER",grid:0};a[60]={fld:"",grid:0};a[61]={fld:"",grid:0};a[62]={fld:"LBLVEH_RORO_TARIFAFILTER",format:1,grid:0};a[63]={fld:"",grid:0};a[64]={fld:"",grid:0};a[65]={fld:"",grid:0};a[66]={lvl:0,type:"decimal",len:10,dec:2,sign:false,pic:"ZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCVEH_RORO_TARIFA",gxz:"ZV11cVEH_RORO_TARIFA",
gxold:"OV11cVEH_RORO_TARIFA",gxvar:"AV11cVEH_RORO_TARIFA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV11cVEH_RORO_TARIFA=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.ZV11cVEH_RORO_TARIFA=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(){gx.fn.setDecimalValue("vCVEH_RORO_TARIFA",gx.O.AV11cVEH_RORO_TARIFA,2,gx.decimalPoint)},c2v:function(){gx.O.AV11cVEH_RORO_TARIFA=this.val()},val:function(){return gx.fn.getDecimalValue("vCVEH_RORO_TARIFA",
gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};a[67]={fld:"",grid:0};a[68]={fld:"GRIDTABLE",grid:0};a[69]={fld:"",grid:0};a[70]={fld:"",grid:0};a[72]={fld:"",grid:0};a[73]={fld:"",grid:0};a[75]={lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(a){gx.O.AV5LinkSelection=
a},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(a){gx.fn.setGridMultimediaValue("vLINKSELECTION",a||gx.fn.currentGridRowImpl(74),gx.O.AV5LinkSelection,gx.O.AV16Linkselection_GXI)},c2v:function(){gx.O.AV16Linkselection_GXI=this.val_GXI();gx.O.AV5LinkSelection=this.val()},val:function(a){return gx.fn.getGridControlValue("vLINKSELECTION",a||gx.fn.currentGridRowImpl(74))},val_GXI:function(a){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",a||gx.fn.currentGridRowImpl(74))},gxvar_GXI:"AV16Linkselection_GXI",
nac:gx.falseFn};a[76]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"VEH_RORO_ID",gxz:"Z38VEH_RORO_ID",gxold:"O38VEH_RORO_ID",gxvar:"A38VEH_RORO_ID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(a){gx.O.A38VEH_RORO_ID=gx.num.intval(a)},v2z:function(a){gx.O.Z38VEH_RORO_ID=gx.num.intval(a)},v2c:function(a){gx.fn.setGridControlValue("VEH_RORO_ID",a||gx.fn.currentGridRowImpl(74),gx.O.A38VEH_RORO_ID,
0)},c2v:function(){gx.O.A38VEH_RORO_ID=gx.num.intval(this.val())},val:function(a){return gx.fn.getGridIntegerValue("VEH_RORO_ID",a||gx.fn.currentGridRowImpl(74),gx.thousandSeparator)},nac:gx.falseFn};a[77]={lvl:2,type:"decimal",len:10,dec:2,sign:false,pic:"ZZZZZZ9.99",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"VEH_RORO_TON_INI",gxz:"Z39VEH_RORO_TON_INI",gxold:"O39VEH_RORO_TON_INI",gxvar:"A39VEH_RORO_TON_INI",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",
v2v:function(a){gx.O.A39VEH_RORO_TON_INI=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.Z39VEH_RORO_TON_INI=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(a){gx.fn.setGridDecimalValue("VEH_RORO_TON_INI",a||gx.fn.currentGridRowImpl(74),gx.O.A39VEH_RORO_TON_INI,2,gx.decimalPoint)},c2v:function(){gx.O.A39VEH_RORO_TON_INI=gx.fn.toDecimalValue(this.val(),",",".")},val:function(a){return gx.fn.getGridDecimalValue("VEH_RORO_TON_INI",a||gx.fn.currentGridRowImpl(74),gx.thousandSeparator,
gx.decimalPoint)},nac:gx.falseFn};a[78]={lvl:2,type:"decimal",len:10,dec:2,sign:false,pic:"ZZZZZZ9.99",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"VEH_RORO_TON_FIN",gxz:"Z40VEH_RORO_TON_FIN",gxold:"O40VEH_RORO_TON_FIN",gxvar:"A40VEH_RORO_TON_FIN",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(a){gx.O.A40VEH_RORO_TON_FIN=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.Z40VEH_RORO_TON_FIN=gx.fn.toDecimalValue(a,gx.thousandSeparator,
gx.decimalPoint)},v2c:function(a){gx.fn.setGridDecimalValue("VEH_RORO_TON_FIN",a||gx.fn.currentGridRowImpl(74),gx.O.A40VEH_RORO_TON_FIN,2,gx.decimalPoint)},c2v:function(){gx.O.A40VEH_RORO_TON_FIN=gx.fn.toDecimalValue(this.val(),",",".")},val:function(a){return gx.fn.getGridDecimalValue("VEH_RORO_TON_FIN",a||gx.fn.currentGridRowImpl(74),gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};a[79]={lvl:2,type:"decimal",len:10,dec:2,sign:false,pic:"ZZZZZZ9.99",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,
fnc:null,isvalid:null,rgrid:[],fld:"VEH_RORO_TARIFA",gxz:"Z43VEH_RORO_TARIFA",gxold:"O43VEH_RORO_TARIFA",gxvar:"A43VEH_RORO_TARIFA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(a){gx.O.A43VEH_RORO_TARIFA=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.Z43VEH_RORO_TARIFA=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(a){gx.fn.setGridDecimalValue("VEH_RORO_TARIFA",a||gx.fn.currentGridRowImpl(74),gx.O.A43VEH_RORO_TARIFA,2,gx.decimalPoint)},
c2v:function(){gx.O.A43VEH_RORO_TARIFA=gx.fn.toDecimalValue(this.val(),",",".")},val:function(a){return gx.fn.getGridDecimalValue("VEH_RORO_TARIFA",a||gx.fn.currentGridRowImpl(74),gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};a[80]={fld:"",grid:0};a[81]={fld:"",grid:0};this.OV11cVEH_RORO_TARIFA=this.ZV11cVEH_RORO_TARIFA=this.AV11cVEH_RORO_TARIFA=this.OV10cVEH_RORO_UTIL_FIN=this.ZV10cVEH_RORO_UTIL_FIN=this.AV10cVEH_RORO_UTIL_FIN=this.OV9cVEH_RORO_UTIL_INI=this.ZV9cVEH_RORO_UTIL_INI=this.AV9cVEH_RORO_UTIL_INI=
this.OV8cVEH_RORO_TON_FIN=this.ZV8cVEH_RORO_TON_FIN=this.AV8cVEH_RORO_TON_FIN=this.OV7cVEH_RORO_TON_INI=this.ZV7cVEH_RORO_TON_INI=this.AV7cVEH_RORO_TON_INI=this.OV6cVEH_RORO_ID=this.ZV6cVEH_RORO_ID=this.AV6cVEH_RORO_ID=0;this.OV5LinkSelection=this.ZV5LinkSelection="";this.A41VEH_RORO_UTIL_INI=this.A42VEH_RORO_UTIL_FIN=this.AV12pVEH_RORO_ID=this.AV11cVEH_RORO_TARIFA=this.AV10cVEH_RORO_UTIL_FIN=this.AV9cVEH_RORO_UTIL_INI=this.AV8cVEH_RORO_TON_FIN=this.AV7cVEH_RORO_TON_INI=this.AV6cVEH_RORO_ID=this.O43VEH_RORO_TARIFA=
this.Z43VEH_RORO_TARIFA=this.O40VEH_RORO_TON_FIN=this.Z40VEH_RORO_TON_FIN=this.O39VEH_RORO_TON_INI=this.Z39VEH_RORO_TON_INI=this.O38VEH_RORO_ID=this.Z38VEH_RORO_ID=0;this.AV5LinkSelection="";this.A43VEH_RORO_TARIFA=this.A40VEH_RORO_TON_FIN=this.A39VEH_RORO_TON_INI=this.A38VEH_RORO_ID=0;this.Events={e201n2_client:["ENTER",true],e211n1_client:["CANCEL",true],e171n1_client:["'TOGGLE'",false],e111n1_client:["LBLVEH_RORO_IDFILTER.CLICK",false],e121n1_client:["LBLVEH_RORO_TON_INIFILTER.CLICK",false],e131n1_client:["LBLVEH_RORO_TON_FINFILTER.CLICK",
false],e141n1_client:["LBLVEH_RORO_UTIL_INIFILTER.CLICK",false],e151n1_client:["LBLVEH_RORO_UTIL_FINFILTER.CLICK",false],e161n1_client:["LBLVEH_RORO_TARIFAFILTER.CLICK",false]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{av:"subGrid1_Rows"},{av:"AV6cVEH_RORO_ID",fld:"vCVEH_RORO_ID"},{av:"AV7cVEH_RORO_TON_INI",fld:"vCVEH_RORO_TON_INI"},{av:"AV8cVEH_RORO_TON_FIN",fld:"vCVEH_RORO_TON_FIN"},{av:"AV9cVEH_RORO_UTIL_INI",fld:"vCVEH_RORO_UTIL_INI"},{av:"AV10cVEH_RORO_UTIL_FIN",
fld:"vCVEH_RORO_UTIL_FIN"},{av:"AV11cVEH_RORO_TARIFA",fld:"vCVEH_RORO_TARIFA"}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLVEH_RORO_IDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("VEH_RORO_IDFILTERCONTAINER","Class")',ctrl:"VEH_RORO_IDFILTERCONTAINER",
prop:"Class"}],[{av:'gx.fn.getCtrlProperty("VEH_RORO_IDFILTERCONTAINER","Class")',ctrl:"VEH_RORO_IDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVEH_RORO_ID","Visible")',ctrl:"vCVEH_RORO_ID",prop:"Visible"}]];this.EvtParms["LBLVEH_RORO_TON_INIFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("VEH_RORO_TON_INIFILTERCONTAINER","Class")',ctrl:"VEH_RORO_TON_INIFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("VEH_RORO_TON_INIFILTERCONTAINER","Class")',ctrl:"VEH_RORO_TON_INIFILTERCONTAINER",
prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVEH_RORO_TON_INI","Visible")',ctrl:"vCVEH_RORO_TON_INI",prop:"Visible"}]];this.EvtParms["LBLVEH_RORO_TON_FINFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("VEH_RORO_TON_FINFILTERCONTAINER","Class")',ctrl:"VEH_RORO_TON_FINFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("VEH_RORO_TON_FINFILTERCONTAINER","Class")',ctrl:"VEH_RORO_TON_FINFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVEH_RORO_TON_FIN","Visible")',ctrl:"vCVEH_RORO_TON_FIN",
prop:"Visible"}]];this.EvtParms["LBLVEH_RORO_UTIL_INIFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("VEH_RORO_UTIL_INIFILTERCONTAINER","Class")',ctrl:"VEH_RORO_UTIL_INIFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("VEH_RORO_UTIL_INIFILTERCONTAINER","Class")',ctrl:"VEH_RORO_UTIL_INIFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVEH_RORO_UTIL_INI","Visible")',ctrl:"vCVEH_RORO_UTIL_INI",prop:"Visible"}]];this.EvtParms["LBLVEH_RORO_UTIL_FINFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("VEH_RORO_UTIL_FINFILTERCONTAINER","Class")',
ctrl:"VEH_RORO_UTIL_FINFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("VEH_RORO_UTIL_FINFILTERCONTAINER","Class")',ctrl:"VEH_RORO_UTIL_FINFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVEH_RORO_UTIL_FIN","Visible")',ctrl:"vCVEH_RORO_UTIL_FIN",prop:"Visible"}]];this.EvtParms["LBLVEH_RORO_TARIFAFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("VEH_RORO_TARIFAFILTERCONTAINER","Class")',ctrl:"VEH_RORO_TARIFAFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("VEH_RORO_TARIFAFILTERCONTAINER","Class")',
ctrl:"VEH_RORO_TARIFAFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCVEH_RORO_TARIFA","Visible")',ctrl:"vCVEH_RORO_TARIFA",prop:"Visible"}]];this.EvtParms.ENTER=[[{av:"A38VEH_RORO_ID",fld:"VEH_RORO_ID"}],[{av:"AV12pVEH_RORO_ID",fld:"vPVEH_RORO_ID"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{av:"subGrid1_Rows"},{av:"AV6cVEH_RORO_ID",fld:"vCVEH_RORO_ID"},{av:"AV7cVEH_RORO_TON_INI",fld:"vCVEH_RORO_TON_INI"},{av:"AV8cVEH_RORO_TON_FIN",fld:"vCVEH_RORO_TON_FIN"},
{av:"AV9cVEH_RORO_UTIL_INI",fld:"vCVEH_RORO_UTIL_INI"},{av:"AV10cVEH_RORO_UTIL_FIN",fld:"vCVEH_RORO_UTIL_FIN"},{av:"AV11cVEH_RORO_TARIFA",fld:"vCVEH_RORO_TARIFA"}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{av:"subGrid1_Rows"},{av:"AV6cVEH_RORO_ID",fld:"vCVEH_RORO_ID"},{av:"AV7cVEH_RORO_TON_INI",fld:"vCVEH_RORO_TON_INI"},{av:"AV8cVEH_RORO_TON_FIN",fld:"vCVEH_RORO_TON_FIN"},{av:"AV9cVEH_RORO_UTIL_INI",fld:"vCVEH_RORO_UTIL_INI"},{av:"AV10cVEH_RORO_UTIL_FIN",
fld:"vCVEH_RORO_UTIL_FIN"},{av:"AV11cVEH_RORO_TARIFA",fld:"vCVEH_RORO_TARIFA"}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{av:"subGrid1_Rows"},{av:"AV6cVEH_RORO_ID",fld:"vCVEH_RORO_ID"},{av:"AV7cVEH_RORO_TON_INI",fld:"vCVEH_RORO_TON_INI"},{av:"AV8cVEH_RORO_TON_FIN",fld:"vCVEH_RORO_TON_FIN"},{av:"AV9cVEH_RORO_UTIL_INI",fld:"vCVEH_RORO_UTIL_INI"},{av:"AV10cVEH_RORO_UTIL_FIN",fld:"vCVEH_RORO_UTIL_FIN"},{av:"AV11cVEH_RORO_TARIFA",fld:"vCVEH_RORO_TARIFA"}],[]];
this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{av:"subGrid1_Rows"},{av:"AV6cVEH_RORO_ID",fld:"vCVEH_RORO_ID"},{av:"AV7cVEH_RORO_TON_INI",fld:"vCVEH_RORO_TON_INI"},{av:"AV8cVEH_RORO_TON_FIN",fld:"vCVEH_RORO_TON_FIN"},{av:"AV9cVEH_RORO_UTIL_INI",fld:"vCVEH_RORO_UTIL_INI"},{av:"AV10cVEH_RORO_UTIL_FIN",fld:"vCVEH_RORO_UTIL_FIN"},{av:"AV11cVEH_RORO_TARIFA",fld:"vCVEH_RORO_TARIFA"}],[]];this.setVCMap("AV12pVEH_RORO_ID","vPVEH_RORO_ID",0,"int");b.addRefreshingVar(this.GXValidFnc[16]);
b.addRefreshingVar(this.GXValidFnc[26]);b.addRefreshingVar(this.GXValidFnc[36]);b.addRefreshingVar(this.GXValidFnc[46]);b.addRefreshingVar(this.GXValidFnc[56]);b.addRefreshingVar(this.GXValidFnc[66]);this.InitStandaloneVars()});gx.createParentObj(gx0080);