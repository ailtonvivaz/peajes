gx.evt.autoSkip=!1;
gx.define("gx0071",!1,function(){this.ServerClass="gx0071";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.skipOnEnter=false;this.ajaxSecurityToken=this.supportAjaxEvents=this.fullAjax=this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV12pPortaContenedoresEsclusa=gx.fn.getIntegerValue("vPPORTACONTENEDORESESCLUSA",gx.thousandSeparator);this.AV13pPortaRango=gx.fn.getIntegerValue("vPPORTARANGO",gx.thousandSeparator)};this.e17111_client=function(){this.clearMessages();
if(gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"){gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible");gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")}else{gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer");gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")}this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",
prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}])};this.e11111_client=function(){this.clearMessages();if(gx.fn.getCtrlProperty("PORTARANGOFILTERCONTAINER","Class")=="AdvancedContainerItem"){gx.fn.setCtrlProperty("PORTARANGOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded");gx.fn.setCtrlProperty("vCPORTARANGO","Visible",true)}else{gx.fn.setCtrlProperty("PORTARANGOFILTERCONTAINER","Class","AdvancedContainerItem");gx.fn.setCtrlProperty("vCPORTARANGO","Visible",false)}this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PORTARANGOFILTERCONTAINER","Class")',
ctrl:"PORTARANGOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPORTARANGO","Visible")',ctrl:"vCPORTARANGO",prop:"Visible"}])};this.e12111_client=function(){this.clearMessages();if(gx.fn.getCtrlProperty("PORTARANGOINITEUFILTERCONTAINER","Class")=="AdvancedContainerItem"){gx.fn.setCtrlProperty("PORTARANGOINITEUFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded");gx.fn.setCtrlProperty("vCPORTARANGOINITEU","Visible",true)}else{gx.fn.setCtrlProperty("PORTARANGOINITEUFILTERCONTAINER",
"Class","AdvancedContainerItem");gx.fn.setCtrlProperty("vCPORTARANGOINITEU","Visible",false)}this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PORTARANGOINITEUFILTERCONTAINER","Class")',ctrl:"PORTARANGOINITEUFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPORTARANGOINITEU","Visible")',ctrl:"vCPORTARANGOINITEU",prop:"Visible"}])};this.e13111_client=function(){this.clearMessages();if(gx.fn.getCtrlProperty("PORTARANGOFINTEUFILTERCONTAINER","Class")=="AdvancedContainerItem"){gx.fn.setCtrlProperty("PORTARANGOFINTEUFILTERCONTAINER",
"Class","AdvancedContainerItem AdvancedContainerItemExpanded");gx.fn.setCtrlProperty("vCPORTARANGOFINTEU","Visible",true)}else{gx.fn.setCtrlProperty("PORTARANGOFINTEUFILTERCONTAINER","Class","AdvancedContainerItem");gx.fn.setCtrlProperty("vCPORTARANGOFINTEU","Visible",false)}this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PORTARANGOFINTEUFILTERCONTAINER","Class")',ctrl:"PORTARANGOFINTEUFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPORTARANGOFINTEU","Visible")',ctrl:"vCPORTARANGOFINTEU",
prop:"Visible"}])};this.e14111_client=function(){this.clearMessages();if(gx.fn.getCtrlProperty("PORTATARIFATTA4FILTERCONTAINER","Class")=="AdvancedContainerItem"){gx.fn.setCtrlProperty("PORTATARIFATTA4FILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded");gx.fn.setCtrlProperty("vCPORTATARIFATTA4","Visible",true)}else{gx.fn.setCtrlProperty("PORTATARIFATTA4FILTERCONTAINER","Class","AdvancedContainerItem");gx.fn.setCtrlProperty("vCPORTATARIFATTA4","Visible",false)}this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PORTATARIFATTA4FILTERCONTAINER","Class")',
ctrl:"PORTATARIFATTA4FILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPORTATARIFATTA4","Visible")',ctrl:"vCPORTATARIFATTA4",prop:"Visible"}])};this.e15111_client=function(){this.clearMessages();if(gx.fn.getCtrlProperty("PORTATARIFATEU4FILTERCONTAINER","Class")=="AdvancedContainerItem"){gx.fn.setCtrlProperty("PORTATARIFATEU4FILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded");gx.fn.setCtrlProperty("vCPORTATARIFATEU4","Visible",true)}else{gx.fn.setCtrlProperty("PORTATARIFATEU4FILTERCONTAINER",
"Class","AdvancedContainerItem");gx.fn.setCtrlProperty("vCPORTATARIFATEU4","Visible",false)}this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PORTATARIFATEU4FILTERCONTAINER","Class")',ctrl:"PORTATARIFATEU4FILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPORTATARIFATEU4","Visible")',ctrl:"vCPORTATARIFATEU4",prop:"Visible"}])};this.e16111_client=function(){this.clearMessages();if(gx.fn.getCtrlProperty("PORTATARIFATTA3FILTERCONTAINER","Class")=="AdvancedContainerItem"){gx.fn.setCtrlProperty("PORTATARIFATTA3FILTERCONTAINER",
"Class","AdvancedContainerItem AdvancedContainerItemExpanded");gx.fn.setCtrlProperty("vCPORTATARIFATTA3","Visible",true)}else{gx.fn.setCtrlProperty("PORTATARIFATTA3FILTERCONTAINER","Class","AdvancedContainerItem");gx.fn.setCtrlProperty("vCPORTATARIFATTA3","Visible",false)}this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PORTATARIFATTA3FILTERCONTAINER","Class")',ctrl:"PORTATARIFATTA3FILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPORTATARIFATTA3","Visible")',ctrl:"vCPORTATARIFATTA3",prop:"Visible"}])};
this.e20112_client=function(a){this.executeServerEvent("ENTER",true,a)};this.e21111_client=function(){this.executeServerEvent("CANCEL",true)};var b=this.GXValidFnc=[];this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,72,73,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89];this.GXLastCtrlId=89;var c=this.Grid1Container=new gx.grid.grid(this,
2,"WbpLvl2",74,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0071",[],false,1,false,true,10,true,false,false,"",0,"px",gx.getMessage("GXM_newrow"),true,false,false,null,null,false,"",false,[1,1,1,1]);c.addBitmap("&Linkselection","vLINKSELECTION",75,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");c.addSingleLineEdit(24,76,"PORTARANGO",gx.getMessage("Rango"),"","PortaRango","int",0,"px",4,4,"right",null,[],24,"PortaRango",true,0,false,false,"Attribute",1,"WWColumn");
c.addSingleLineEdit(25,77,"PORTARANGOINITEU",gx.getMessage("Rango Inicial"),"","PortaRangoIniTEU","int",0,"px",12,12,"right",null,[],25,"PortaRangoIniTEU",true,0,false,false,"DescriptionAttribute",1,"WWColumn");c.addSingleLineEdit(26,78,"PORTARANGOFINTEU",gx.getMessage("Final"),"","PortaRangoFinTEU","int",0,"px",12,12,"right",null,[],26,"PortaRangoFinTEU",true,0,false,false,"Attribute",1,"WWColumn OptionalColumn");c.addSingleLineEdit(27,79,"PORTATARIFATTA4",gx.getMessage("Tarifa TTA4"),"","PortaTarifaTTA4",
"decimal",0,"px",7,7,"right",null,[],27,"PortaTarifaTTA4",true,2,false,false,"Attribute",1,"WWColumn OptionalColumn");c.addSingleLineEdit(28,80,"PORTATARIFATEU4",gx.getMessage("Tarifa TEU4"),"","PortaTarifaTEU4","decimal",0,"px",7,7,"right",null,[],28,"PortaTarifaTEU4",true,2,false,false,"Attribute",1,"WWColumn OptionalColumn");c.addSingleLineEdit(29,81,"PORTATARIFATTA3",gx.getMessage("Tarifa TTA3"),"","PortaTarifaTTA3","decimal",0,"px",7,7,"right",null,[],29,"PortaTarifaTTA3",true,2,false,false,
"Attribute",1,"WWColumn OptionalColumn");c.addSingleLineEdit(30,82,"PORTATARIFATEU3",gx.getMessage("Tarifa TEU3"),"","PortaTarifaTEU3","decimal",0,"px",7,7,"right",null,[],30,"PortaTarifaTEU3",true,2,false,false,"Attribute",1,"WWColumn OptionalColumn");c.addSingleLineEdit(31,83,"PORTATARIFATTA2",gx.getMessage("Tarifa TTA2"),"","PortaTarifaTTA2","decimal",0,"px",7,7,"right",null,[],31,"PortaTarifaTTA2",true,2,false,false,"Attribute",1,"WWColumn OptionalColumn");c.addSingleLineEdit(32,84,"PORTATARIFATEU2",
gx.getMessage("Tarifa TEU2"),"","PortaTarifaTEU2","decimal",0,"px",7,7,"right",null,[],32,"PortaTarifaTEU2",true,2,false,false,"Attribute",1,"WWColumn OptionalColumn");c.addSingleLineEdit(33,85,"PORTATARIFATTA1",gx.getMessage("Tarifa TTA1"),"","PortaTarifaTTA1","decimal",0,"px",7,7,"right",null,[],33,"PortaTarifaTTA1",true,2,false,false,"Attribute",1,"WWColumn OptionalColumn");c.addSingleLineEdit(34,86,"PORTATARIFATEU1",gx.getMessage("Tarifa TEU1"),"","PortaTarifaTEU1","decimal",0,"px",7,7,"right",
null,[],34,"PortaTarifaTEU1",true,2,false,false,"Attribute",1,"WWColumn OptionalColumn");c.addComboBox(22,87,"PORTACONTENEDORESESCLUSA",gx.getMessage("Esclusa"),"PortaContenedoresEsclusa","int",null,0,false,false,0,"px","");this.setGrid(c);b[2]={fld:"",grid:0};b[3]={fld:"MAIN",grid:0};b[4]={fld:"",grid:0};b[5]={fld:"",grid:0};b[6]={fld:"ADVANCEDCONTAINER",grid:0};b[7]={fld:"",grid:0};b[8]={fld:"",grid:0};b[9]={fld:"PORTARANGOFILTERCONTAINER",grid:0};b[10]={fld:"",grid:0};b[11]={fld:"",grid:0};b[12]=
{fld:"LBLPORTARANGOFILTER",format:1,grid:0};b[13]={fld:"",grid:0};b[14]={fld:"",grid:0};b[15]={fld:"",grid:0};b[16]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPORTARANGO",gxz:"ZV6cPortaRango",gxold:"OV6cPortaRango",gxvar:"AV6cPortaRango",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cPortaRango=gx.num.intval(a)},v2z:function(a){gx.O.ZV6cPortaRango=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCPORTARANGO",
gx.O.AV6cPortaRango,0)},c2v:function(){gx.O.AV6cPortaRango=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vCPORTARANGO",gx.thousandSeparator)},nac:gx.falseFn};b[17]={fld:"",grid:0};b[18]={fld:"",grid:0};b[19]={fld:"PORTARANGOINITEUFILTERCONTAINER",grid:0};b[20]={fld:"",grid:0};b[21]={fld:"",grid:0};b[22]={fld:"LBLPORTARANGOINITEUFILTER",format:1,grid:0};b[23]={fld:"",grid:0};b[24]={fld:"",grid:0};b[25]={fld:"",grid:0};b[26]={lvl:0,type:"int",len:12,dec:0,sign:false,pic:"ZZZZZZZZZZZ9",
ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPORTARANGOINITEU",gxz:"ZV7cPortaRangoIniTEU",gxold:"OV7cPortaRangoIniTEU",gxvar:"AV7cPortaRangoIniTEU",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7cPortaRangoIniTEU=gx.num.intval(a)},v2z:function(a){gx.O.ZV7cPortaRangoIniTEU=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCPORTARANGOINITEU",gx.O.AV7cPortaRangoIniTEU,0)},c2v:function(){gx.O.AV7cPortaRangoIniTEU=gx.num.intval(this.val())},
val:function(){return gx.fn.getIntegerValue("vCPORTARANGOINITEU",gx.thousandSeparator)},nac:gx.falseFn};b[27]={fld:"",grid:0};b[28]={fld:"",grid:0};b[29]={fld:"PORTARANGOFINTEUFILTERCONTAINER",grid:0};b[30]={fld:"",grid:0};b[31]={fld:"",grid:0};b[32]={fld:"LBLPORTARANGOFINTEUFILTER",format:1,grid:0};b[33]={fld:"",grid:0};b[34]={fld:"",grid:0};b[35]={fld:"",grid:0};b[36]={lvl:0,type:"int",len:12,dec:0,sign:false,pic:"ZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],
fld:"vCPORTARANGOFINTEU",gxz:"ZV8cPortaRangoFinTEU",gxold:"OV8cPortaRangoFinTEU",gxvar:"AV8cPortaRangoFinTEU",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8cPortaRangoFinTEU=gx.num.intval(a)},v2z:function(a){gx.O.ZV8cPortaRangoFinTEU=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCPORTARANGOFINTEU",gx.O.AV8cPortaRangoFinTEU,0)},c2v:function(){gx.O.AV8cPortaRangoFinTEU=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vCPORTARANGOFINTEU",gx.thousandSeparator)},
nac:gx.falseFn};b[37]={fld:"",grid:0};b[38]={fld:"",grid:0};b[39]={fld:"PORTATARIFATTA4FILTERCONTAINER",grid:0};b[40]={fld:"",grid:0};b[41]={fld:"",grid:0};b[42]={fld:"LBLPORTATARIFATTA4FILTER",format:1,grid:0};b[43]={fld:"",grid:0};b[44]={fld:"",grid:0};b[45]={fld:"",grid:0};b[46]={lvl:0,type:"decimal",len:7,dec:2,sign:false,pic:"ZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPORTATARIFATTA4",gxz:"ZV9cPortaTarifaTTA4",gxold:"OV9cPortaTarifaTTA4",gxvar:"AV9cPortaTarifaTTA4",
ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV9cPortaTarifaTTA4=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.ZV9cPortaTarifaTTA4=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(){gx.fn.setDecimalValue("vCPORTATARIFATTA4",gx.O.AV9cPortaTarifaTTA4,2,gx.decimalPoint)},c2v:function(){gx.O.AV9cPortaTarifaTTA4=this.val()},val:function(){return gx.fn.getDecimalValue("vCPORTATARIFATTA4",gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};b[47]=
{fld:"",grid:0};b[48]={fld:"",grid:0};b[49]={fld:"PORTATARIFATEU4FILTERCONTAINER",grid:0};b[50]={fld:"",grid:0};b[51]={fld:"",grid:0};b[52]={fld:"LBLPORTATARIFATEU4FILTER",format:1,grid:0};b[53]={fld:"",grid:0};b[54]={fld:"",grid:0};b[55]={fld:"",grid:0};b[56]={lvl:0,type:"decimal",len:7,dec:2,sign:false,pic:"ZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPORTATARIFATEU4",gxz:"ZV15cPortaTarifaTEU4",gxold:"OV15cPortaTarifaTEU4",gxvar:"AV15cPortaTarifaTEU4",
ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV15cPortaTarifaTEU4=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.ZV15cPortaTarifaTEU4=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(){gx.fn.setDecimalValue("vCPORTATARIFATEU4",gx.O.AV15cPortaTarifaTEU4,2,gx.decimalPoint)},c2v:function(){gx.O.AV15cPortaTarifaTEU4=this.val()},val:function(){return gx.fn.getDecimalValue("vCPORTATARIFATEU4",gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};b[57]=
{fld:"",grid:0};b[58]={fld:"",grid:0};b[59]={fld:"PORTATARIFATTA3FILTERCONTAINER",grid:0};b[60]={fld:"",grid:0};b[61]={fld:"",grid:0};b[62]={fld:"LBLPORTATARIFATTA3FILTER",format:1,grid:0};b[63]={fld:"",grid:0};b[64]={fld:"",grid:0};b[65]={fld:"",grid:0};b[66]={lvl:0,type:"decimal",len:7,dec:2,sign:false,pic:"ZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPORTATARIFATTA3",gxz:"ZV11cPortaTarifaTTA3",gxold:"OV11cPortaTarifaTTA3",gxvar:"AV11cPortaTarifaTTA3",
ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV11cPortaTarifaTTA3=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.ZV11cPortaTarifaTTA3=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(){gx.fn.setDecimalValue("vCPORTATARIFATTA3",gx.O.AV11cPortaTarifaTTA3,2,gx.decimalPoint)},c2v:function(){gx.O.AV11cPortaTarifaTTA3=this.val()},val:function(){return gx.fn.getDecimalValue("vCPORTATARIFATTA3",gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};b[67]=
{fld:"",grid:0};b[68]={fld:"GRIDTABLE",grid:0};b[69]={fld:"",grid:0};b[70]={fld:"",grid:0};b[72]={fld:"",grid:0};b[73]={fld:"",grid:0};b[75]={lvl:2,type:"bits",len:1024,dec:0,sign:false,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(a){gx.O.AV5LinkSelection=a},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(a){gx.fn.setGridMultimediaValue("vLINKSELECTION",
a||gx.fn.currentGridRowImpl(74),gx.O.AV5LinkSelection,gx.O.AV18Linkselection_GXI)},c2v:function(){gx.O.AV18Linkselection_GXI=this.val_GXI();gx.O.AV5LinkSelection=this.val()},val:function(a){return gx.fn.getGridControlValue("vLINKSELECTION",a||gx.fn.currentGridRowImpl(74))},val_GXI:function(a){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",a||gx.fn.currentGridRowImpl(74))},gxvar_GXI:"AV18Linkselection_GXI",nac:gx.falseFn};b[76]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,
grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PORTARANGO",gxz:"Z24PortaRango",gxold:"O24PortaRango",gxvar:"A24PortaRango",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(a){gx.O.A24PortaRango=gx.num.intval(a)},v2z:function(a){gx.O.Z24PortaRango=gx.num.intval(a)},v2c:function(a){gx.fn.setGridControlValue("PORTARANGO",a||gx.fn.currentGridRowImpl(74),gx.O.A24PortaRango,0)},c2v:function(){gx.O.A24PortaRango=gx.num.intval(this.val())},val:function(a){return gx.fn.getGridIntegerValue("PORTARANGO",
a||gx.fn.currentGridRowImpl(74),gx.thousandSeparator)},nac:gx.falseFn};b[77]={lvl:2,type:"int",len:12,dec:0,sign:false,pic:"ZZZZZZZZZZZ9",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PORTARANGOINITEU",gxz:"Z25PortaRangoIniTEU",gxold:"O25PortaRangoIniTEU",gxvar:"A25PortaRangoIniTEU",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(a){gx.O.A25PortaRangoIniTEU=gx.num.intval(a)},v2z:function(a){gx.O.Z25PortaRangoIniTEU=gx.num.intval(a)},
v2c:function(a){gx.fn.setGridControlValue("PORTARANGOINITEU",a||gx.fn.currentGridRowImpl(74),gx.O.A25PortaRangoIniTEU,0)},c2v:function(){gx.O.A25PortaRangoIniTEU=gx.num.intval(this.val())},val:function(a){return gx.fn.getGridIntegerValue("PORTARANGOINITEU",a||gx.fn.currentGridRowImpl(74),gx.thousandSeparator)},nac:gx.falseFn};b[78]={lvl:2,type:"int",len:12,dec:0,sign:false,pic:"ZZZZZZZZZZZ9",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PORTARANGOFINTEU",gxz:"Z26PortaRangoFinTEU",
gxold:"O26PortaRangoFinTEU",gxvar:"A26PortaRangoFinTEU",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(a){gx.O.A26PortaRangoFinTEU=gx.num.intval(a)},v2z:function(a){gx.O.Z26PortaRangoFinTEU=gx.num.intval(a)},v2c:function(a){gx.fn.setGridControlValue("PORTARANGOFINTEU",a||gx.fn.currentGridRowImpl(74),gx.O.A26PortaRangoFinTEU,0)},c2v:function(){gx.O.A26PortaRangoFinTEU=gx.num.intval(this.val())},val:function(a){return gx.fn.getGridIntegerValue("PORTARANGOFINTEU",a||gx.fn.currentGridRowImpl(74),
gx.thousandSeparator)},nac:gx.falseFn};b[79]={lvl:2,type:"decimal",len:7,dec:2,sign:false,pic:"ZZZ9.99",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PORTATARIFATTA4",gxz:"Z27PortaTarifaTTA4",gxold:"O27PortaTarifaTTA4",gxvar:"A27PortaTarifaTTA4",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(a){gx.O.A27PortaTarifaTTA4=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.Z27PortaTarifaTTA4=gx.fn.toDecimalValue(a,gx.thousandSeparator,
gx.decimalPoint)},v2c:function(a){gx.fn.setGridDecimalValue("PORTATARIFATTA4",a||gx.fn.currentGridRowImpl(74),gx.O.A27PortaTarifaTTA4,2,gx.decimalPoint);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){gx.O.A27PortaTarifaTTA4=gx.fn.toDecimalValue(this.val(),",",".")},val:function(a){return gx.fn.getGridDecimalValue("PORTATARIFATTA4",a||gx.fn.currentGridRowImpl(74),gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};b[80]={lvl:2,type:"decimal",len:7,dec:2,sign:false,pic:"ZZZ9.99",
ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PORTATARIFATEU4",gxz:"Z28PortaTarifaTEU4",gxold:"O28PortaTarifaTEU4",gxvar:"A28PortaTarifaTEU4",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(a){gx.O.A28PortaTarifaTEU4=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.Z28PortaTarifaTEU4=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(a){gx.fn.setGridDecimalValue("PORTATARIFATEU4",a||gx.fn.currentGridRowImpl(74),
gx.O.A28PortaTarifaTEU4,2,gx.decimalPoint);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){gx.O.A28PortaTarifaTEU4=gx.fn.toDecimalValue(this.val(),",",".")},val:function(a){return gx.fn.getGridDecimalValue("PORTATARIFATEU4",a||gx.fn.currentGridRowImpl(74),gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};b[81]={lvl:2,type:"decimal",len:7,dec:2,sign:false,pic:"ZZZ9.99",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PORTATARIFATTA3",
gxz:"Z29PortaTarifaTTA3",gxold:"O29PortaTarifaTTA3",gxvar:"A29PortaTarifaTTA3",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(a){gx.O.A29PortaTarifaTTA3=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.Z29PortaTarifaTTA3=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(a){gx.fn.setGridDecimalValue("PORTATARIFATTA3",a||gx.fn.currentGridRowImpl(74),gx.O.A29PortaTarifaTTA3,2,gx.decimalPoint);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},
c2v:function(){gx.O.A29PortaTarifaTTA3=gx.fn.toDecimalValue(this.val(),",",".")},val:function(a){return gx.fn.getGridDecimalValue("PORTATARIFATTA3",a||gx.fn.currentGridRowImpl(74),gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};b[82]={lvl:2,type:"decimal",len:7,dec:2,sign:false,pic:"ZZZ9.99",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PORTATARIFATEU3",gxz:"Z30PortaTarifaTEU3",gxold:"O30PortaTarifaTEU3",gxvar:"A30PortaTarifaTEU3",ucs:[],op:[],ip:[],nacdep:[],
ctrltype:"edit",inputType:"text",v2v:function(a){gx.O.A30PortaTarifaTEU3=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.Z30PortaTarifaTEU3=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(a){gx.fn.setGridDecimalValue("PORTATARIFATEU3",a||gx.fn.currentGridRowImpl(74),gx.O.A30PortaTarifaTEU3,2,gx.decimalPoint);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){gx.O.A30PortaTarifaTEU3=gx.fn.toDecimalValue(this.val(),",",".")},val:function(a){return gx.fn.getGridDecimalValue("PORTATARIFATEU3",
a||gx.fn.currentGridRowImpl(74),gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};b[83]={lvl:2,type:"decimal",len:7,dec:2,sign:false,pic:"ZZZ9.99",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PORTATARIFATTA2",gxz:"Z31PortaTarifaTTA2",gxold:"O31PortaTarifaTTA2",gxvar:"A31PortaTarifaTTA2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(a){gx.O.A31PortaTarifaTTA2=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.Z31PortaTarifaTTA2=
gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(a){gx.fn.setGridDecimalValue("PORTATARIFATTA2",a||gx.fn.currentGridRowImpl(74),gx.O.A31PortaTarifaTTA2,2,gx.decimalPoint);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){gx.O.A31PortaTarifaTTA2=gx.fn.toDecimalValue(this.val(),",",".")},val:function(a){return gx.fn.getGridDecimalValue("PORTATARIFATTA2",a||gx.fn.currentGridRowImpl(74),gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};b[84]={lvl:2,
type:"decimal",len:7,dec:2,sign:false,pic:"ZZZ9.99",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PORTATARIFATEU2",gxz:"Z32PortaTarifaTEU2",gxold:"O32PortaTarifaTEU2",gxvar:"A32PortaTarifaTEU2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(a){gx.O.A32PortaTarifaTEU2=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.Z32PortaTarifaTEU2=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(a){gx.fn.setGridDecimalValue("PORTATARIFATEU2",
a||gx.fn.currentGridRowImpl(74),gx.O.A32PortaTarifaTEU2,2,gx.decimalPoint);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){gx.O.A32PortaTarifaTEU2=gx.fn.toDecimalValue(this.val(),",",".")},val:function(a){return gx.fn.getGridDecimalValue("PORTATARIFATEU2",a||gx.fn.currentGridRowImpl(74),gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};b[85]={lvl:2,type:"decimal",len:7,dec:2,sign:false,pic:"ZZZ9.99",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,
rgrid:[],fld:"PORTATARIFATTA1",gxz:"Z33PortaTarifaTTA1",gxold:"O33PortaTarifaTTA1",gxvar:"A33PortaTarifaTTA1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(a){gx.O.A33PortaTarifaTTA1=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.Z33PortaTarifaTTA1=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(a){gx.fn.setGridDecimalValue("PORTATARIFATTA1",a||gx.fn.currentGridRowImpl(74),gx.O.A33PortaTarifaTTA1,2,gx.decimalPoint);typeof this.dom_hdl==
"function"&&this.dom_hdl.call(gx.O)},c2v:function(){gx.O.A33PortaTarifaTTA1=gx.fn.toDecimalValue(this.val(),",",".")},val:function(a){return gx.fn.getGridDecimalValue("PORTATARIFATTA1",a||gx.fn.currentGridRowImpl(74),gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};b[86]={lvl:2,type:"decimal",len:7,dec:2,sign:false,pic:"ZZZ9.99",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PORTATARIFATEU1",gxz:"Z34PortaTarifaTEU1",gxold:"O34PortaTarifaTEU1",gxvar:"A34PortaTarifaTEU1",
ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(a){gx.O.A34PortaTarifaTEU1=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.Z34PortaTarifaTEU1=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(a){gx.fn.setGridDecimalValue("PORTATARIFATEU1",a||gx.fn.currentGridRowImpl(74),gx.O.A34PortaTarifaTEU1,2,gx.decimalPoint);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){gx.O.A34PortaTarifaTEU1=gx.fn.toDecimalValue(this.val(),
",",".")},val:function(a){return gx.fn.getGridDecimalValue("PORTATARIFATEU1",a||gx.fn.currentGridRowImpl(74),gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};b[87]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PORTACONTENEDORESESCLUSA",gxz:"Z22PortaContenedoresEsclusa",gxold:"O22PortaContenedoresEsclusa",gxvar:"A22PortaContenedoresEsclusa",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",inputType:"text",
v2v:function(a){gx.O.A22PortaContenedoresEsclusa=gx.num.intval(a)},v2z:function(a){gx.O.Z22PortaContenedoresEsclusa=gx.num.intval(a)},v2c:function(a){gx.fn.setGridComboBoxValue("PORTACONTENEDORESESCLUSA",a||gx.fn.currentGridRowImpl(74),gx.O.A22PortaContenedoresEsclusa);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){gx.O.A22PortaContenedoresEsclusa=gx.num.intval(this.val())},val:function(a){return gx.fn.getGridIntegerValue("PORTACONTENEDORESESCLUSA",a||gx.fn.currentGridRowImpl(74),
gx.thousandSeparator)},nac:gx.falseFn};b[88]={fld:"",grid:0};b[89]={fld:"",grid:0};this.OV11cPortaTarifaTTA3=this.ZV11cPortaTarifaTTA3=this.AV11cPortaTarifaTTA3=this.OV15cPortaTarifaTEU4=this.ZV15cPortaTarifaTEU4=this.AV15cPortaTarifaTEU4=this.OV9cPortaTarifaTTA4=this.ZV9cPortaTarifaTTA4=this.AV9cPortaTarifaTTA4=this.OV8cPortaRangoFinTEU=this.ZV8cPortaRangoFinTEU=this.AV8cPortaRangoFinTEU=this.OV7cPortaRangoIniTEU=this.ZV7cPortaRangoIniTEU=this.AV7cPortaRangoIniTEU=this.OV6cPortaRango=this.ZV6cPortaRango=
this.AV6cPortaRango=0;this.OV5LinkSelection=this.ZV5LinkSelection="";this.AV13pPortaRango=this.AV12pPortaContenedoresEsclusa=this.AV11cPortaTarifaTTA3=this.AV15cPortaTarifaTEU4=this.AV9cPortaTarifaTTA4=this.AV8cPortaRangoFinTEU=this.AV7cPortaRangoIniTEU=this.AV6cPortaRango=this.O22PortaContenedoresEsclusa=this.Z22PortaContenedoresEsclusa=this.O34PortaTarifaTEU1=this.Z34PortaTarifaTEU1=this.O33PortaTarifaTTA1=this.Z33PortaTarifaTTA1=this.O32PortaTarifaTEU2=this.Z32PortaTarifaTEU2=this.O31PortaTarifaTTA2=
this.Z31PortaTarifaTTA2=this.O30PortaTarifaTEU3=this.Z30PortaTarifaTEU3=this.O29PortaTarifaTTA3=this.Z29PortaTarifaTTA3=this.O28PortaTarifaTEU4=this.Z28PortaTarifaTEU4=this.O27PortaTarifaTTA4=this.Z27PortaTarifaTTA4=this.O26PortaRangoFinTEU=this.Z26PortaRangoFinTEU=this.O25PortaRangoIniTEU=this.Z25PortaRangoIniTEU=this.O24PortaRango=this.Z24PortaRango=0;this.AV5LinkSelection="";this.A22PortaContenedoresEsclusa=this.A34PortaTarifaTEU1=this.A33PortaTarifaTTA1=this.A32PortaTarifaTEU2=this.A31PortaTarifaTTA2=
this.A30PortaTarifaTEU3=this.A29PortaTarifaTTA3=this.A28PortaTarifaTEU4=this.A27PortaTarifaTTA4=this.A26PortaRangoFinTEU=this.A25PortaRangoIniTEU=this.A24PortaRango=0;this.Events={e20112_client:["ENTER",true],e21111_client:["CANCEL",true],e17111_client:["'TOGGLE'",false],e11111_client:["LBLPORTARANGOFILTER.CLICK",false],e12111_client:["LBLPORTARANGOINITEUFILTER.CLICK",false],e13111_client:["LBLPORTARANGOFINTEUFILTER.CLICK",false],e14111_client:["LBLPORTATARIFATTA4FILTER.CLICK",false],e15111_client:["LBLPORTATARIFATEU4FILTER.CLICK",
false],e16111_client:["LBLPORTATARIFATTA3FILTER.CLICK",false]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{av:"subGrid1_Rows"},{av:"AV6cPortaRango",fld:"vCPORTARANGO"},{av:"AV7cPortaRangoIniTEU",fld:"vCPORTARANGOINITEU"},{av:"AV8cPortaRangoFinTEU",fld:"vCPORTARANGOFINTEU"},{av:"AV9cPortaTarifaTTA4",fld:"vCPORTATARIFATTA4"},{av:"AV15cPortaTarifaTEU4",fld:"vCPORTATARIFATEU4"},{av:"AV11cPortaTarifaTTA3",fld:"vCPORTATARIFATTA3"},{av:"AV12pPortaContenedoresEsclusa",fld:"vPPORTACONTENEDORESESCLUSA"}],
[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLPORTARANGOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PORTARANGOFILTERCONTAINER","Class")',ctrl:"PORTARANGOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PORTARANGOFILTERCONTAINER","Class")',
ctrl:"PORTARANGOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPORTARANGO","Visible")',ctrl:"vCPORTARANGO",prop:"Visible"}]];this.EvtParms["LBLPORTARANGOINITEUFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PORTARANGOINITEUFILTERCONTAINER","Class")',ctrl:"PORTARANGOINITEUFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PORTARANGOINITEUFILTERCONTAINER","Class")',ctrl:"PORTARANGOINITEUFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPORTARANGOINITEU","Visible")',ctrl:"vCPORTARANGOINITEU",
prop:"Visible"}]];this.EvtParms["LBLPORTARANGOFINTEUFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PORTARANGOFINTEUFILTERCONTAINER","Class")',ctrl:"PORTARANGOFINTEUFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PORTARANGOFINTEUFILTERCONTAINER","Class")',ctrl:"PORTARANGOFINTEUFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPORTARANGOFINTEU","Visible")',ctrl:"vCPORTARANGOFINTEU",prop:"Visible"}]];this.EvtParms["LBLPORTATARIFATTA4FILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PORTATARIFATTA4FILTERCONTAINER","Class")',
ctrl:"PORTATARIFATTA4FILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PORTATARIFATTA4FILTERCONTAINER","Class")',ctrl:"PORTATARIFATTA4FILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPORTATARIFATTA4","Visible")',ctrl:"vCPORTATARIFATTA4",prop:"Visible"}]];this.EvtParms["LBLPORTATARIFATEU4FILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PORTATARIFATEU4FILTERCONTAINER","Class")',ctrl:"PORTATARIFATEU4FILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PORTATARIFATEU4FILTERCONTAINER","Class")',
ctrl:"PORTATARIFATEU4FILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPORTATARIFATEU4","Visible")',ctrl:"vCPORTATARIFATEU4",prop:"Visible"}]];this.EvtParms["LBLPORTATARIFATTA3FILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PORTATARIFATTA3FILTERCONTAINER","Class")',ctrl:"PORTATARIFATTA3FILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PORTATARIFATTA3FILTERCONTAINER","Class")',ctrl:"PORTATARIFATTA3FILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPORTATARIFATTA3","Visible")',
ctrl:"vCPORTATARIFATTA3",prop:"Visible"}]];this.EvtParms.ENTER=[[{av:"A24PortaRango",fld:"PORTARANGO"}],[{av:"AV13pPortaRango",fld:"vPPORTARANGO"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{av:"subGrid1_Rows"},{av:"AV6cPortaRango",fld:"vCPORTARANGO"},{av:"AV7cPortaRangoIniTEU",fld:"vCPORTARANGOINITEU"},{av:"AV8cPortaRangoFinTEU",fld:"vCPORTARANGOFINTEU"},{av:"AV9cPortaTarifaTTA4",fld:"vCPORTATARIFATTA4"},{av:"AV15cPortaTarifaTEU4",fld:"vCPORTATARIFATEU4"},
{av:"AV11cPortaTarifaTTA3",fld:"vCPORTATARIFATTA3"},{av:"AV12pPortaContenedoresEsclusa",fld:"vPPORTACONTENEDORESESCLUSA"}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{av:"subGrid1_Rows"},{av:"AV6cPortaRango",fld:"vCPORTARANGO"},{av:"AV7cPortaRangoIniTEU",fld:"vCPORTARANGOINITEU"},{av:"AV8cPortaRangoFinTEU",fld:"vCPORTARANGOFINTEU"},{av:"AV9cPortaTarifaTTA4",fld:"vCPORTATARIFATTA4"},{av:"AV15cPortaTarifaTEU4",fld:"vCPORTATARIFATEU4"},{av:"AV11cPortaTarifaTTA3",
fld:"vCPORTATARIFATTA3"},{av:"AV12pPortaContenedoresEsclusa",fld:"vPPORTACONTENEDORESESCLUSA"}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{av:"subGrid1_Rows"},{av:"AV6cPortaRango",fld:"vCPORTARANGO"},{av:"AV7cPortaRangoIniTEU",fld:"vCPORTARANGOINITEU"},{av:"AV8cPortaRangoFinTEU",fld:"vCPORTARANGOFINTEU"},{av:"AV9cPortaTarifaTTA4",fld:"vCPORTATARIFATTA4"},{av:"AV15cPortaTarifaTEU4",fld:"vCPORTATARIFATEU4"},{av:"AV11cPortaTarifaTTA3",fld:"vCPORTATARIFATTA3"},
{av:"AV12pPortaContenedoresEsclusa",fld:"vPPORTACONTENEDORESESCLUSA"}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{av:"subGrid1_Rows"},{av:"AV6cPortaRango",fld:"vCPORTARANGO"},{av:"AV7cPortaRangoIniTEU",fld:"vCPORTARANGOINITEU"},{av:"AV8cPortaRangoFinTEU",fld:"vCPORTARANGOFINTEU"},{av:"AV9cPortaTarifaTTA4",fld:"vCPORTATARIFATTA4"},{av:"AV15cPortaTarifaTEU4",fld:"vCPORTATARIFATEU4"},{av:"AV11cPortaTarifaTTA3",fld:"vCPORTATARIFATTA3"},{av:"AV12pPortaContenedoresEsclusa",
fld:"vPPORTACONTENEDORESESCLUSA"}],[]];this.setVCMap("AV12pPortaContenedoresEsclusa","vPPORTACONTENEDORESESCLUSA",0,"int");this.setVCMap("AV13pPortaRango","vPPORTARANGO",0,"int");this.setVCMap("AV12pPortaContenedoresEsclusa","vPPORTACONTENEDORESESCLUSA",0,"int");c.addRefreshingVar(this.GXValidFnc[16]);c.addRefreshingVar(this.GXValidFnc[26]);c.addRefreshingVar(this.GXValidFnc[36]);c.addRefreshingVar(this.GXValidFnc[46]);c.addRefreshingVar(this.GXValidFnc[56]);c.addRefreshingVar(this.GXValidFnc[66]);
c.addRefreshingVar({rfrVar:"AV12pPortaContenedoresEsclusa"});this.InitStandaloneVars()});gx.createParentObj(gx0071);
