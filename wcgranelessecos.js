gx.evt.autoSkip=!1;
gx.define("wcgranelessecos",!1,function(){this.ServerClass="wcgranelessecos";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.skipOnEnter=this.hasEnterEvent=false;this.ajaxSecurityToken=this.supportAjaxEvents=this.fullAjax=this.autoRefresh=true;this.SetStandaloneVars=function(){};this.Validv_Dwt=function(){try{var a=gx.util.balloon.getNew("vDWT");this.AnyError=0}catch(b){}try{return a==null?true:a.show()}catch(c){}return true};this.Validv_Mtgranos=function(){gx.ajax.validSrvEvt("dyncall","Validv_Mtgranos",
["gx.num.urlDecimal(gx.O.AV15MTGranos,gx.thousandSeparator,gx.decimalPoint)","gx.num.urlDecimal(gx.O.AV11DWT,gx.thousandSeparator,gx.decimalPoint)","gx.num.urlDecimal(gx.O.AV7PorcentajeGranos,gx.thousandSeparator,gx.decimalPoint)"],["AV7PorcentajeGranos"]);return true};this.Validv_Porcentajegranos=function(){try{var a=gx.util.balloon.getNew("vPORCENTAJEGRANOS");this.AnyError=0}catch(b){}try{return a==null?true:a.show()}catch(c){}return true};this.Validv_Mtcarbon=function(){gx.ajax.validSrvEvt("dyncall",
"Validv_Mtcarbon",["gx.num.urlDecimal(gx.O.AV14MTCarbon,gx.thousandSeparator,gx.decimalPoint)","gx.num.urlDecimal(gx.O.AV11DWT,gx.thousandSeparator,gx.decimalPoint)","gx.num.urlDecimal(gx.O.AV8PorcentajeCarbon,gx.thousandSeparator,gx.decimalPoint)"],["AV8PorcentajeCarbon"]);return true};this.Validv_Porcentajecarbon=function(){try{var a=gx.util.balloon.getNew("vPORCENTAJECARBON");this.AnyError=0}catch(b){}try{return a==null?true:a.show()}catch(c){}return true};this.Validv_Mtmineralhierro=function(){gx.ajax.validSrvEvt("dyncall",
"Validv_Mtmineralhierro",["gx.num.urlDecimal(gx.O.AV16MTMineralHierro,gx.thousandSeparator,gx.decimalPoint)","gx.num.urlDecimal(gx.O.AV11DWT,gx.thousandSeparator,gx.decimalPoint)","gx.num.urlDecimal(gx.O.AV9PorcentajeHierro,gx.thousandSeparator,gx.decimalPoint)"],["AV9PorcentajeHierro"]);return true};this.Validv_Porcentajehierro=function(){try{var a=gx.util.balloon.getNew("vPORCENTAJEHIERRO");this.AnyError=0}catch(b){}try{return a==null?true:a.show()}catch(c){}return true};this.Validv_Mtotros=function(){gx.ajax.validSrvEvt("dyncall",
"Validv_Mtotros",["gx.num.urlDecimal(gx.O.AV17MTOtros,gx.thousandSeparator,gx.decimalPoint)","gx.num.urlDecimal(gx.O.AV11DWT,gx.thousandSeparator,gx.decimalPoint)","gx.num.urlDecimal(gx.O.AV15MTGranos,gx.thousandSeparator,gx.decimalPoint)","gx.num.urlDecimal(gx.O.AV14MTCarbon,gx.thousandSeparator,gx.decimalPoint)","gx.num.urlDecimal(gx.O.AV16MTMineralHierro,gx.thousandSeparator,gx.decimalPoint)","gx.num.urlDecimal(gx.O.AV10PorcentajeOtros,gx.thousandSeparator,gx.decimalPoint)","gx.num.urlDecimal(gx.O.AV20TotalMT,gx.thousandSeparator,gx.decimalPoint)"],
["AV10PorcentajeOtros","AV20TotalMT"]);return true};this.Validv_Porcentajeotros=function(){gx.ajax.validSrvEvt("dyncall","Validv_Porcentajeotros",["gx.num.urlDecimal(gx.O.AV7PorcentajeGranos,gx.thousandSeparator,gx.decimalPoint)","gx.num.urlDecimal(gx.O.AV8PorcentajeCarbon,gx.thousandSeparator,gx.decimalPoint)","gx.num.urlDecimal(gx.O.AV9PorcentajeHierro,gx.thousandSeparator,gx.decimalPoint)","gx.num.urlDecimal(gx.O.AV10PorcentajeOtros,gx.thousandSeparator,gx.decimalPoint)","gx.num.urlDecimal(gx.O.AV21TotalPtje,gx.thousandSeparator,gx.decimalPoint)"],
["AV21TotalPtje"]);return true};this.e140d1_client=function(){this.clearMessages();this.AV21TotalPtje=this.AV20TotalMT=this.AV10PorcentajeOtros=this.AV9PorcentajeHierro=this.AV7PorcentajeGranos=this.AV8PorcentajeCarbon=this.AV17MTOtros=this.AV16MTMineralHierro=this.AV15MTGranos=this.AV14MTCarbon=this.AV11DWT=0;this.refreshOutputs([{av:"AV11DWT",fld:"vDWT"},{av:"AV14MTCarbon",fld:"vMTCARBON"},{av:"AV15MTGranos",fld:"vMTGRANOS"},{av:"AV16MTMineralHierro",fld:"vMTMINERALHIERRO"},{av:"AV17MTOtros",fld:"vMTOTROS"},
{av:"AV8PorcentajeCarbon",fld:"vPORCENTAJECARBON"},{av:"AV7PorcentajeGranos",fld:"vPORCENTAJEGRANOS"},{av:"AV9PorcentajeHierro",fld:"vPORCENTAJEHIERRO"},{av:"AV10PorcentajeOtros",fld:"vPORCENTAJEOTROS"},{av:"AV20TotalMT",fld:"vTOTALMT"},{av:"AV21TotalPtje",fld:"vTOTALPTJE"}])};this.e110d2_client=function(){this.executeServerEvent("'CALCULAR'",false)};this.e150d2_client=function(){this.executeServerEvent("ENTER",true)};this.e160d2_client=function(){this.executeServerEvent("CANCEL",true)};var a=this.GXValidFnc=
[];this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,82,83,85,86,87,88,89,90,91,92,95,97,98,99,102,104,105,106,109,111,112,113];this.GXLastCtrlId=113;a[2]={fld:"",grid:0};a[3]={fld:"MAINTABLE",grid:0};a[4]={fld:"",grid:0};a[5]={fld:"",grid:0};a[6]={fld:"GROUP1",grid:0};a[7]={fld:"GROUP1TABLE",grid:0};a[8]={fld:"",grid:0};
a[9]={fld:"",grid:0};a[10]={fld:"TABLE1",grid:0};a[11]={fld:"",grid:0};a[12]={fld:"",grid:0};a[13]={fld:"DWT_CONTAINER",grid:0};a[14]={fld:"",format:0,grid:0};a[15]={fld:"",grid:0};a[16]={lvl:0,type:"decimal",len:12,dec:2,sign:false,pic:"ZZZ,ZZZ,ZZ9.99",ro:0,grid:0,gxgrid:null,fnc:this.Validv_Dwt,isvalid:null,rgrid:[],fld:"vDWT",gxz:"ZV11DWT",gxold:"OV11DWT",gxvar:"AV11DWT",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV11DWT=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.ZV11DWT=
gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(){gx.fn.setDecimalValue("vDWT",gx.O.AV11DWT,2,gx.decimalPoint)},c2v:function(){gx.O.AV11DWT=this.val()},val:function(){return gx.fn.getDecimalValue("vDWT",gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};a[17]={fld:"",grid:0};a[18]={fld:"TEXTBLOCK1",format:0,grid:0};a[19]={fld:"",grid:0};a[20]={fld:"",grid:0};a[21]={fld:"MTGRANOS_CONTAINER",grid:0};a[22]={fld:"",format:0,grid:0};a[23]={fld:"",grid:0};a[24]={lvl:0,type:"decimal",
len:12,dec:2,sign:false,pic:"ZZZ,ZZZ,ZZ9.99",ro:0,grid:0,gxgrid:null,fnc:this.Validv_Mtgranos,isvalid:null,rgrid:[],fld:"vMTGRANOS",gxz:"ZV15MTGranos",gxold:"OV15MTGranos",gxvar:"AV15MTGranos",ucs:[],op:[29],ip:[29,16,24],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV15MTGranos=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.ZV15MTGranos=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(){gx.fn.setDecimalValue("vMTGRANOS",gx.O.AV15MTGranos,2,gx.decimalPoint)},c2v:function(){gx.O.AV15MTGranos=
this.val()},val:function(){return gx.fn.getDecimalValue("vMTGRANOS",gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};a[25]={fld:"",grid:0};a[26]={fld:"PORCENTAJEGRANOS_CONTAINER",grid:0};a[27]={fld:"",format:0,grid:0};a[28]={fld:"",grid:0};a[29]={lvl:0,type:"decimal",len:12,dec:2,sign:false,pic:"ZZZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:this.Validv_Porcentajegranos,isvalid:null,rgrid:[],fld:"vPORCENTAJEGRANOS",gxz:"ZV7PorcentajeGranos",gxold:"OV7PorcentajeGranos",gxvar:"AV7PorcentajeGranos",
ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7PorcentajeGranos=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.ZV7PorcentajeGranos=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(){gx.fn.setDecimalValue("vPORCENTAJEGRANOS",gx.O.AV7PorcentajeGranos,2,gx.decimalPoint)},c2v:function(){gx.O.AV7PorcentajeGranos=this.val()},val:function(){return gx.fn.getDecimalValue("vPORCENTAJEGRANOS",gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};a[30]=
{fld:"",grid:0};a[31]={fld:"",grid:0};a[32]={fld:"MTCARBON_CONTAINER",grid:0};a[33]={fld:"",format:0,grid:0};a[34]={fld:"",grid:0};a[35]={lvl:0,type:"decimal",len:12,dec:2,sign:false,pic:"ZZZ,ZZZ,ZZ9.99",ro:0,grid:0,gxgrid:null,fnc:this.Validv_Mtcarbon,isvalid:null,rgrid:[],fld:"vMTCARBON",gxz:"ZV14MTCarbon",gxold:"OV14MTCarbon",gxvar:"AV14MTCarbon",ucs:[],op:[40],ip:[40,16,35],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV14MTCarbon=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.ZV14MTCarbon=
gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(){gx.fn.setDecimalValue("vMTCARBON",gx.O.AV14MTCarbon,2,gx.decimalPoint)},c2v:function(){gx.O.AV14MTCarbon=this.val()},val:function(){return gx.fn.getDecimalValue("vMTCARBON",gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};a[36]={fld:"",grid:0};a[37]={fld:"PORCENTAJECARBON_CONTAINER",grid:0};a[38]={fld:"",format:0,grid:0};a[39]={fld:"",grid:0};a[40]={lvl:0,type:"decimal",len:12,dec:2,sign:false,pic:"ZZZZZZZZ9.99",ro:0,
grid:0,gxgrid:null,fnc:this.Validv_Porcentajecarbon,isvalid:null,rgrid:[],fld:"vPORCENTAJECARBON",gxz:"ZV8PorcentajeCarbon",gxold:"OV8PorcentajeCarbon",gxvar:"AV8PorcentajeCarbon",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8PorcentajeCarbon=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.ZV8PorcentajeCarbon=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(){gx.fn.setDecimalValue("vPORCENTAJECARBON",gx.O.AV8PorcentajeCarbon,2,gx.decimalPoint)},
c2v:function(){gx.O.AV8PorcentajeCarbon=this.val()},val:function(){return gx.fn.getDecimalValue("vPORCENTAJECARBON",gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};a[41]={fld:"",grid:0};a[42]={fld:"",grid:0};a[43]={fld:"MTMINERALHIERRO_CONTAINER",grid:0};a[44]={fld:"",format:0,grid:0};a[45]={fld:"",grid:0};a[46]={lvl:0,type:"decimal",len:12,dec:2,sign:false,pic:"ZZZ,ZZZ,ZZ9.99",ro:0,grid:0,gxgrid:null,fnc:this.Validv_Mtmineralhierro,isvalid:null,rgrid:[],fld:"vMTMINERALHIERRO",gxz:"ZV16MTMineralHierro",
gxold:"OV16MTMineralHierro",gxvar:"AV16MTMineralHierro",ucs:[],op:[51],ip:[51,16,46],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV16MTMineralHierro=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.ZV16MTMineralHierro=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(){gx.fn.setDecimalValue("vMTMINERALHIERRO",gx.O.AV16MTMineralHierro,2,gx.decimalPoint)},c2v:function(){gx.O.AV16MTMineralHierro=this.val()},val:function(){return gx.fn.getDecimalValue("vMTMINERALHIERRO",
gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};a[47]={fld:"",grid:0};a[48]={fld:"PORCENTAJEHIERRO_CONTAINER",grid:0};a[49]={fld:"",format:0,grid:0};a[50]={fld:"",grid:0};a[51]={lvl:0,type:"decimal",len:12,dec:2,sign:false,pic:"ZZZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:this.Validv_Porcentajehierro,isvalid:null,rgrid:[],fld:"vPORCENTAJEHIERRO",gxz:"ZV9PorcentajeHierro",gxold:"OV9PorcentajeHierro",gxvar:"AV9PorcentajeHierro",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV9PorcentajeHierro=
gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.ZV9PorcentajeHierro=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(){gx.fn.setDecimalValue("vPORCENTAJEHIERRO",gx.O.AV9PorcentajeHierro,2,gx.decimalPoint)},c2v:function(){gx.O.AV9PorcentajeHierro=this.val()},val:function(){return gx.fn.getDecimalValue("vPORCENTAJEHIERRO",gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};a[52]={fld:"",grid:0};a[53]={fld:"",grid:0};a[54]={fld:"MTOTROS_CONTAINER",grid:0};a[55]={fld:"",
format:0,grid:0};a[56]={fld:"",grid:0};a[57]={lvl:0,type:"decimal",len:12,dec:2,sign:false,pic:"ZZZ,ZZZ,ZZ9.99",ro:0,grid:0,gxgrid:null,fnc:this.Validv_Mtotros,isvalid:null,rgrid:[],fld:"vMTOTROS",gxz:"ZV17MTOtros",gxold:"OV17MTOtros",gxvar:"AV17MTOtros",ucs:[],op:[68,62],ip:[68,62,46,35,24,16,57],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV17MTOtros=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.ZV17MTOtros=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(){gx.fn.setDecimalValue("vMTOTROS",
gx.O.AV17MTOtros,2,gx.decimalPoint)},c2v:function(){gx.O.AV17MTOtros=this.val()},val:function(){return gx.fn.getDecimalValue("vMTOTROS",gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};a[58]={fld:"",grid:0};a[59]={fld:"PORCENTAJEOTROS_CONTAINER",grid:0};a[60]={fld:"",format:0,grid:0};a[61]={fld:"",grid:0};a[62]={lvl:0,type:"decimal",len:12,dec:2,sign:false,pic:"ZZZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:this.Validv_Porcentajeotros,isvalid:null,rgrid:[],fld:"vPORCENTAJEOTROS",gxz:"ZV10PorcentajeOtros",
gxold:"OV10PorcentajeOtros",gxvar:"AV10PorcentajeOtros",ucs:[],op:[73],ip:[73,62,51,40,29],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV10PorcentajeOtros=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.ZV10PorcentajeOtros=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(){gx.fn.setDecimalValue("vPORCENTAJEOTROS",gx.O.AV10PorcentajeOtros,2,gx.decimalPoint)},c2v:function(){gx.O.AV10PorcentajeOtros=this.val()},val:function(){return gx.fn.getDecimalValue("vPORCENTAJEOTROS",
gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};a[63]={fld:"",grid:0};a[64]={fld:"",grid:0};a[65]={fld:"TOTALMT_CONTAINER",grid:0};a[66]={fld:"",format:0,grid:0};a[67]={fld:"",grid:0};a[68]={lvl:0,type:"decimal",len:12,dec:2,sign:false,pic:"ZZZ,ZZZ,ZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vTOTALMT",gxz:"ZV20TotalMT",gxold:"OV20TotalMT",gxvar:"AV20TotalMT",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV20TotalMT=gx.fn.toDecimalValue(a,",",".")},
v2z:function(a){gx.O.ZV20TotalMT=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(){gx.fn.setDecimalValue("vTOTALMT",gx.O.AV20TotalMT,2,gx.decimalPoint)},c2v:function(){gx.O.AV20TotalMT=this.val()},val:function(){return gx.fn.getDecimalValue("vTOTALMT",gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};a[69]={fld:"",grid:0};a[70]={fld:"TOTALPTJE_CONTAINER",grid:0};a[71]={fld:"",format:0,grid:0};a[72]={fld:"",grid:0};a[73]={lvl:0,type:"decimal",len:12,dec:2,sign:false,
pic:"ZZZZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vTOTALPTJE",gxz:"ZV21TotalPtje",gxold:"OV21TotalPtje",gxvar:"AV21TotalPtje",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV21TotalPtje=gx.fn.toDecimalValue(a,",",".")},v2z:function(a){gx.O.ZV21TotalPtje=gx.fn.toDecimalValue(a,gx.thousandSeparator,gx.decimalPoint)},v2c:function(){gx.fn.setDecimalValue("vTOTALPTJE",gx.O.AV21TotalPtje,2,gx.decimalPoint)},c2v:function(){gx.O.AV21TotalPtje=this.val()},val:function(){return gx.fn.getDecimalValue("vTOTALPTJE",
gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};a[74]={fld:"",grid:0};a[75]={fld:"",grid:0};a[76]={fld:"TABLE3",grid:0};a[82]={fld:"",grid:0};a[83]={fld:"",grid:0};a[85]={fld:"",grid:0};a[86]={fld:"",grid:0};a[87]={fld:"",grid:0};a[88]={fld:"GROUP2",grid:0};a[89]={fld:"GROUP2TABLE",grid:0};a[90]={fld:"",grid:0};a[91]={fld:"",grid:0};a[92]={fld:"TABLE4",grid:0};a[95]={fld:"TEXTBLOCKRESULTADOPANAMAX",format:0,grid:0};a[97]={fld:"RESULTADOPANAMAX",format:0,grid:0};a[98]={fld:"",grid:0};a[99]=
{fld:"TABLE2",grid:0};a[102]={fld:"TEXTBLOCKRESULTADONEOPANAMAX",format:0,grid:0};a[104]={fld:"RESULTADONEOPANAMAX",format:0,grid:0};a[105]={fld:"",grid:0};a[106]={fld:"TABLE5",grid:0};a[109]={fld:"TEXTBLOCKRESULTADOLASTRE",format:0,grid:0};a[111]={fld:"RESULTADOLASTRE",format:0,grid:0};a[112]={fld:"",grid:0};a[113]={fld:"",grid:0};this.AV21TotalPtje=this.AV20TotalMT=this.AV10PorcentajeOtros=this.AV17MTOtros=this.AV9PorcentajeHierro=this.AV16MTMineralHierro=this.AV8PorcentajeCarbon=this.AV14MTCarbon=
this.AV7PorcentajeGranos=this.AV15MTGranos=this.AV11DWT=this.OV21TotalPtje=this.ZV21TotalPtje=this.AV21TotalPtje=this.OV20TotalMT=this.ZV20TotalMT=this.AV20TotalMT=this.OV10PorcentajeOtros=this.ZV10PorcentajeOtros=this.AV10PorcentajeOtros=this.OV17MTOtros=this.ZV17MTOtros=this.AV17MTOtros=this.OV9PorcentajeHierro=this.ZV9PorcentajeHierro=this.AV9PorcentajeHierro=this.OV16MTMineralHierro=this.ZV16MTMineralHierro=this.AV16MTMineralHierro=this.OV8PorcentajeCarbon=this.ZV8PorcentajeCarbon=this.AV8PorcentajeCarbon=
this.OV14MTCarbon=this.ZV14MTCarbon=this.AV14MTCarbon=this.OV7PorcentajeGranos=this.ZV7PorcentajeGranos=this.AV7PorcentajeGranos=this.OV15MTGranos=this.ZV15MTGranos=this.AV15MTGranos=this.OV11DWT=this.ZV11DWT=this.AV11DWT=0;this.AV18SDTGraneleros={};this.Events={e110d2_client:["'CALCULAR'",true],e150d2_client:["ENTER",true],e160d2_client:["CANCEL",true],e140d1_client:["'LIMPIAR'",false]};this.EvtParms.REFRESH=[[],[]];this.EvtParms["'CALCULAR'"]=[[{av:"AV11DWT",fld:"vDWT"},{av:"AV20TotalMT",fld:"vTOTALMT"},
{av:"AV15MTGranos",fld:"vMTGRANOS"},{av:"AV14MTCarbon",fld:"vMTCARBON"},{av:"AV16MTMineralHierro",fld:"vMTMINERALHIERRO"},{av:"AV17MTOtros",fld:"vMTOTROS"},{av:"AV18SDTGraneleros",fld:"vSDTGRANELEROS"}],[{av:'gx.fn.getCtrlProperty("RESULTADOPANAMAX","Caption")',ctrl:"RESULTADOPANAMAX",prop:"Caption"},{av:'gx.fn.getCtrlProperty("RESULTADONEOPANAMAX","Caption")',ctrl:"RESULTADONEOPANAMAX",prop:"Caption"},{av:'gx.fn.getCtrlProperty("RESULTADOLASTRE","Caption")',ctrl:"RESULTADOLASTRE",prop:"Caption"},
{av:"AV19sw",fld:"vSW"},{av:"AV18SDTGraneleros",fld:"vSDTGRANELEROS"}]];this.EvtParms["'LIMPIAR'"]=[[],[{av:"AV11DWT",fld:"vDWT"},{av:"AV14MTCarbon",fld:"vMTCARBON"},{av:"AV15MTGranos",fld:"vMTGRANOS"},{av:"AV16MTMineralHierro",fld:"vMTMINERALHIERRO"},{av:"AV17MTOtros",fld:"vMTOTROS"},{av:"AV8PorcentajeCarbon",fld:"vPORCENTAJECARBON"},{av:"AV7PorcentajeGranos",fld:"vPORCENTAJEGRANOS"},{av:"AV9PorcentajeHierro",fld:"vPORCENTAJEHIERRO"},{av:"AV10PorcentajeOtros",fld:"vPORCENTAJEOTROS"},{av:"AV20TotalMT",
fld:"vTOTALMT"},{av:"AV21TotalPtje",fld:"vTOTALPTJE"}]];this.InitStandaloneVars();this.setComponent({id:"COMPONENT1",GXClass:"wcnota",Prefix:"W0114",lvl:1})});gx.createParentObj(wcgranelessecos);