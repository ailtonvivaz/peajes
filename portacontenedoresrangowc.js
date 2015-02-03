/*
               File: PortaContenedoresRangoWC
        Description: Porta Contenedores Rango WC
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 7:38:11.92
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
gx.define('portacontenedoresrangowc', true, function (CmpContext) {
   this.ServerClass =  "portacontenedoresrangowc" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.setCmpContext(CmpContext);
   this.ReadonlyForm = true;
   this.hasEnterEvent = false;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV7PortaContenedoresEsclusa=gx.fn.getIntegerValue("vPORTACONTENEDORESESCLUSA",gx.thousandSeparator) ;
   };
   this.e13152_client=function()
   {
      this.executeServerEvent("ENTER", true, arguments[0]);
   };
   this.e14152_client=function()
   {
      this.executeServerEvent("CANCEL", true, arguments[0]);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24];
   this.GXLastCtrlId =24;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",9,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"portacontenedoresrangowc",[],false,1,false,true,0,true,false,false,"",0,"px",gx.getMessage( "GXM_newrow"),true,false,false,null,null,false,"",false,[1,1,1,1]);
   var GridContainer = this.GridContainer;
   GridContainer.addSingleLineEdit(24,10,"PORTARANGO",gx.getMessage( "Rango"),"","PortaRango","int",0,"px",4,4,"right",null,[],24,"PortaRango",true,0,false,false,"Attribute",1,"WWColumn WWOptionalColumn");
   GridContainer.addSingleLineEdit(25,11,"PORTARANGOINITEU",gx.getMessage( "Rango Inicial"),"","PortaRangoIniTEU","int",0,"px",12,12,"right",null,[],25,"PortaRangoIniTEU",true,0,false,false,"Attribute",1,"WWColumn WWOptionalColumn");
   GridContainer.addSingleLineEdit(26,12,"PORTARANGOFINTEU",gx.getMessage( "Final"),"","PortaRangoFinTEU","int",0,"px",12,12,"right",null,[],26,"PortaRangoFinTEU",true,0,false,false,"Attribute",1,"WWColumn WWOptionalColumn");
   GridContainer.addSingleLineEdit(27,13,"PORTATARIFATTA4",gx.getMessage( "Tarifa TTA4"),"","PortaTarifaTTA4","decimal",0,"px",7,7,"right",null,[],27,"PortaTarifaTTA4",true,2,false,false,"Attribute",1,"WWColumn WWOptionalColumn");
   GridContainer.addSingleLineEdit(28,14,"PORTATARIFATEU4",gx.getMessage( "Tarifa TEU4"),"","PortaTarifaTEU4","decimal",0,"px",7,7,"right",null,[],28,"PortaTarifaTEU4",true,2,false,false,"Attribute",1,"WWColumn WWOptionalColumn");
   GridContainer.addSingleLineEdit(29,15,"PORTATARIFATTA3",gx.getMessage( "Tarifa TTA3"),"","PortaTarifaTTA3","decimal",0,"px",7,7,"right",null,[],29,"PortaTarifaTTA3",true,2,false,false,"Attribute",1,"WWColumn WWOptionalColumn");
   GridContainer.addSingleLineEdit(30,16,"PORTATARIFATEU3",gx.getMessage( "Tarifa TEU3"),"","PortaTarifaTEU3","decimal",0,"px",7,7,"right",null,[],30,"PortaTarifaTEU3",true,2,false,false,"Attribute",1,"WWColumn WWOptionalColumn");
   GridContainer.addSingleLineEdit(31,17,"PORTATARIFATTA2",gx.getMessage( "Tarifa TTA2"),"","PortaTarifaTTA2","decimal",0,"px",7,7,"right",null,[],31,"PortaTarifaTTA2",true,2,false,false,"Attribute",1,"WWColumn WWOptionalColumn");
   GridContainer.addSingleLineEdit(32,18,"PORTATARIFATEU2",gx.getMessage( "Tarifa TEU2"),"","PortaTarifaTEU2","decimal",0,"px",7,7,"right",null,[],32,"PortaTarifaTEU2",true,2,false,false,"Attribute",1,"WWColumn WWOptionalColumn");
   GridContainer.addSingleLineEdit(33,19,"PORTATARIFATTA1",gx.getMessage( "Tarifa TTA1"),"","PortaTarifaTTA1","decimal",0,"px",7,7,"right",null,[],33,"PortaTarifaTTA1",true,2,false,false,"Attribute",1,"WWColumn WWOptionalColumn");
   GridContainer.addSingleLineEdit(34,20,"PORTATARIFATEU1",gx.getMessage( "Tarifa TEU1"),"","PortaTarifaTEU1","decimal",0,"px",7,7,"right",null,[],34,"PortaTarifaTEU1",true,2,false,false,"Attribute",1,"WWColumn WWOptionalColumn");
   this.setGrid(GridContainer);
   GXValidFnc[2]={fld:"",grid:0};
   GXValidFnc[3]={fld:"MAIN",grid:0};
   GXValidFnc[4]={fld:"",grid:0};
   GXValidFnc[5]={fld:"",grid:0};
   GXValidFnc[6]={fld:"GRIDTABLE",grid:0};
   GXValidFnc[7]={fld:"",grid:0};
   GXValidFnc[8]={fld:"",grid:0};
   GXValidFnc[10]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,grid:9,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PORTARANGO",gxz:"Z24PortaRango",gxold:"O24PortaRango",gxvar:"A24PortaRango",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){gx.O.A24PortaRango=gx.num.intval(Value)},v2z:function(Value){gx.O.Z24PortaRango=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("PORTARANGO",row || gx.fn.currentGridRowImpl(9),gx.O.A24PortaRango,0)},c2v:function(){gx.O.A24PortaRango=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("PORTARANGO",row || gx.fn.currentGridRowImpl(9),gx.thousandSeparator)},nac:gx.falseFn};
   GXValidFnc[11]={lvl:2,type:"int",len:12,dec:0,sign:false,pic:"ZZZZZZZZZZZ9",ro:1,isacc:0,grid:9,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PORTARANGOINITEU",gxz:"Z25PortaRangoIniTEU",gxold:"O25PortaRangoIniTEU",gxvar:"A25PortaRangoIniTEU",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){gx.O.A25PortaRangoIniTEU=gx.num.intval(Value)},v2z:function(Value){gx.O.Z25PortaRangoIniTEU=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("PORTARANGOINITEU",row || gx.fn.currentGridRowImpl(9),gx.O.A25PortaRangoIniTEU,0)},c2v:function(){gx.O.A25PortaRangoIniTEU=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("PORTARANGOINITEU",row || gx.fn.currentGridRowImpl(9),gx.thousandSeparator)},nac:gx.falseFn};
   GXValidFnc[12]={lvl:2,type:"int",len:12,dec:0,sign:false,pic:"ZZZZZZZZZZZ9",ro:1,isacc:0,grid:9,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PORTARANGOFINTEU",gxz:"Z26PortaRangoFinTEU",gxold:"O26PortaRangoFinTEU",gxvar:"A26PortaRangoFinTEU",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){gx.O.A26PortaRangoFinTEU=gx.num.intval(Value)},v2z:function(Value){gx.O.Z26PortaRangoFinTEU=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("PORTARANGOFINTEU",row || gx.fn.currentGridRowImpl(9),gx.O.A26PortaRangoFinTEU,0)},c2v:function(){gx.O.A26PortaRangoFinTEU=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("PORTARANGOFINTEU",row || gx.fn.currentGridRowImpl(9),gx.thousandSeparator)},nac:gx.falseFn};
   GXValidFnc[13]={lvl:2,type:"decimal",len:7,dec:2,sign:false,pic:"ZZZ9.99",ro:1,isacc:0,grid:9,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PORTATARIFATTA4",gxz:"Z27PortaTarifaTTA4",gxold:"O27PortaTarifaTTA4",gxvar:"A27PortaTarifaTTA4",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){gx.O.A27PortaTarifaTTA4=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z27PortaTarifaTTA4=gx.fn.toDecimalValue(Value,gx.thousandSeparator,gx.decimalPoint)},v2c:function(row){gx.fn.setGridDecimalValue("PORTATARIFATTA4",row || gx.fn.currentGridRowImpl(9),gx.O.A27PortaTarifaTTA4,2,gx.decimalPoint);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){gx.O.A27PortaTarifaTTA4=gx.fn.toDecimalValue(this.val(),',','.')},val:function(row){return gx.fn.getGridDecimalValue("PORTATARIFATTA4",row || gx.fn.currentGridRowImpl(9),gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};
   GXValidFnc[14]={lvl:2,type:"decimal",len:7,dec:2,sign:false,pic:"ZZZ9.99",ro:1,isacc:0,grid:9,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PORTATARIFATEU4",gxz:"Z28PortaTarifaTEU4",gxold:"O28PortaTarifaTEU4",gxvar:"A28PortaTarifaTEU4",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){gx.O.A28PortaTarifaTEU4=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z28PortaTarifaTEU4=gx.fn.toDecimalValue(Value,gx.thousandSeparator,gx.decimalPoint)},v2c:function(row){gx.fn.setGridDecimalValue("PORTATARIFATEU4",row || gx.fn.currentGridRowImpl(9),gx.O.A28PortaTarifaTEU4,2,gx.decimalPoint);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){gx.O.A28PortaTarifaTEU4=gx.fn.toDecimalValue(this.val(),',','.')},val:function(row){return gx.fn.getGridDecimalValue("PORTATARIFATEU4",row || gx.fn.currentGridRowImpl(9),gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};
   GXValidFnc[15]={lvl:2,type:"decimal",len:7,dec:2,sign:false,pic:"ZZZ9.99",ro:1,isacc:0,grid:9,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PORTATARIFATTA3",gxz:"Z29PortaTarifaTTA3",gxold:"O29PortaTarifaTTA3",gxvar:"A29PortaTarifaTTA3",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){gx.O.A29PortaTarifaTTA3=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z29PortaTarifaTTA3=gx.fn.toDecimalValue(Value,gx.thousandSeparator,gx.decimalPoint)},v2c:function(row){gx.fn.setGridDecimalValue("PORTATARIFATTA3",row || gx.fn.currentGridRowImpl(9),gx.O.A29PortaTarifaTTA3,2,gx.decimalPoint);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){gx.O.A29PortaTarifaTTA3=gx.fn.toDecimalValue(this.val(),',','.')},val:function(row){return gx.fn.getGridDecimalValue("PORTATARIFATTA3",row || gx.fn.currentGridRowImpl(9),gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};
   GXValidFnc[16]={lvl:2,type:"decimal",len:7,dec:2,sign:false,pic:"ZZZ9.99",ro:1,isacc:0,grid:9,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PORTATARIFATEU3",gxz:"Z30PortaTarifaTEU3",gxold:"O30PortaTarifaTEU3",gxvar:"A30PortaTarifaTEU3",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){gx.O.A30PortaTarifaTEU3=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z30PortaTarifaTEU3=gx.fn.toDecimalValue(Value,gx.thousandSeparator,gx.decimalPoint)},v2c:function(row){gx.fn.setGridDecimalValue("PORTATARIFATEU3",row || gx.fn.currentGridRowImpl(9),gx.O.A30PortaTarifaTEU3,2,gx.decimalPoint);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){gx.O.A30PortaTarifaTEU3=gx.fn.toDecimalValue(this.val(),',','.')},val:function(row){return gx.fn.getGridDecimalValue("PORTATARIFATEU3",row || gx.fn.currentGridRowImpl(9),gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};
   GXValidFnc[17]={lvl:2,type:"decimal",len:7,dec:2,sign:false,pic:"ZZZ9.99",ro:1,isacc:0,grid:9,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PORTATARIFATTA2",gxz:"Z31PortaTarifaTTA2",gxold:"O31PortaTarifaTTA2",gxvar:"A31PortaTarifaTTA2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){gx.O.A31PortaTarifaTTA2=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z31PortaTarifaTTA2=gx.fn.toDecimalValue(Value,gx.thousandSeparator,gx.decimalPoint)},v2c:function(row){gx.fn.setGridDecimalValue("PORTATARIFATTA2",row || gx.fn.currentGridRowImpl(9),gx.O.A31PortaTarifaTTA2,2,gx.decimalPoint);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){gx.O.A31PortaTarifaTTA2=gx.fn.toDecimalValue(this.val(),',','.')},val:function(row){return gx.fn.getGridDecimalValue("PORTATARIFATTA2",row || gx.fn.currentGridRowImpl(9),gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};
   GXValidFnc[18]={lvl:2,type:"decimal",len:7,dec:2,sign:false,pic:"ZZZ9.99",ro:1,isacc:0,grid:9,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PORTATARIFATEU2",gxz:"Z32PortaTarifaTEU2",gxold:"O32PortaTarifaTEU2",gxvar:"A32PortaTarifaTEU2",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){gx.O.A32PortaTarifaTEU2=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z32PortaTarifaTEU2=gx.fn.toDecimalValue(Value,gx.thousandSeparator,gx.decimalPoint)},v2c:function(row){gx.fn.setGridDecimalValue("PORTATARIFATEU2",row || gx.fn.currentGridRowImpl(9),gx.O.A32PortaTarifaTEU2,2,gx.decimalPoint);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){gx.O.A32PortaTarifaTEU2=gx.fn.toDecimalValue(this.val(),',','.')},val:function(row){return gx.fn.getGridDecimalValue("PORTATARIFATEU2",row || gx.fn.currentGridRowImpl(9),gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};
   GXValidFnc[19]={lvl:2,type:"decimal",len:7,dec:2,sign:false,pic:"ZZZ9.99",ro:1,isacc:0,grid:9,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PORTATARIFATTA1",gxz:"Z33PortaTarifaTTA1",gxold:"O33PortaTarifaTTA1",gxvar:"A33PortaTarifaTTA1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){gx.O.A33PortaTarifaTTA1=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z33PortaTarifaTTA1=gx.fn.toDecimalValue(Value,gx.thousandSeparator,gx.decimalPoint)},v2c:function(row){gx.fn.setGridDecimalValue("PORTATARIFATTA1",row || gx.fn.currentGridRowImpl(9),gx.O.A33PortaTarifaTTA1,2,gx.decimalPoint);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){gx.O.A33PortaTarifaTTA1=gx.fn.toDecimalValue(this.val(),',','.')},val:function(row){return gx.fn.getGridDecimalValue("PORTATARIFATTA1",row || gx.fn.currentGridRowImpl(9),gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};
   GXValidFnc[20]={lvl:2,type:"decimal",len:7,dec:2,sign:false,pic:"ZZZ9.99",ro:1,isacc:0,grid:9,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"PORTATARIFATEU1",gxz:"Z34PortaTarifaTEU1",gxold:"O34PortaTarifaTEU1",gxvar:"A34PortaTarifaTEU1",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){gx.O.A34PortaTarifaTEU1=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z34PortaTarifaTEU1=gx.fn.toDecimalValue(Value,gx.thousandSeparator,gx.decimalPoint)},v2c:function(row){gx.fn.setGridDecimalValue("PORTATARIFATEU1",row || gx.fn.currentGridRowImpl(9),gx.O.A34PortaTarifaTEU1,2,gx.decimalPoint);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){gx.O.A34PortaTarifaTEU1=gx.fn.toDecimalValue(this.val(),',','.')},val:function(row){return gx.fn.getGridDecimalValue("PORTATARIFATEU1",row || gx.fn.currentGridRowImpl(9),gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};
   GXValidFnc[21]={fld:"",grid:0};
   GXValidFnc[22]={fld:"",grid:0};
   GXValidFnc[23]={fld:"",grid:0};
   GXValidFnc[24]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PORTACONTENEDORESESCLUSA",gxz:"Z22PortaContenedoresEsclusa",gxold:"O22PortaContenedoresEsclusa",gxvar:"A22PortaContenedoresEsclusa",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(Value){gx.O.A22PortaContenedoresEsclusa=gx.num.intval(Value)},v2z:function(Value){gx.O.Z22PortaContenedoresEsclusa=gx.num.intval(Value)},v2c:function(){gx.fn.setComboBoxValue("PORTACONTENEDORESESCLUSA",gx.O.A22PortaContenedoresEsclusa);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){gx.O.A22PortaContenedoresEsclusa=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("PORTACONTENEDORESESCLUSA",gx.thousandSeparator)},nac:gx.falseFn};
   this.declareDomainHdlr( 24 , function() {
   });
   this.Z24PortaRango = 0 ;
   this.O24PortaRango = 0 ;
   this.Z25PortaRangoIniTEU = 0 ;
   this.O25PortaRangoIniTEU = 0 ;
   this.Z26PortaRangoFinTEU = 0 ;
   this.O26PortaRangoFinTEU = 0 ;
   this.Z27PortaTarifaTTA4 = 0 ;
   this.O27PortaTarifaTTA4 = 0 ;
   this.Z28PortaTarifaTEU4 = 0 ;
   this.O28PortaTarifaTEU4 = 0 ;
   this.Z29PortaTarifaTTA3 = 0 ;
   this.O29PortaTarifaTTA3 = 0 ;
   this.Z30PortaTarifaTEU3 = 0 ;
   this.O30PortaTarifaTEU3 = 0 ;
   this.Z31PortaTarifaTTA2 = 0 ;
   this.O31PortaTarifaTTA2 = 0 ;
   this.Z32PortaTarifaTEU2 = 0 ;
   this.O32PortaTarifaTEU2 = 0 ;
   this.Z33PortaTarifaTTA1 = 0 ;
   this.O33PortaTarifaTTA1 = 0 ;
   this.Z34PortaTarifaTEU1 = 0 ;
   this.O34PortaTarifaTEU1 = 0 ;
   this.A22PortaContenedoresEsclusa = 0 ;
   this.Z22PortaContenedoresEsclusa = 0 ;
   this.O22PortaContenedoresEsclusa = 0 ;
   this.A22PortaContenedoresEsclusa = 0 ;
   this.AV7PortaContenedoresEsclusa = 0 ;
   this.A24PortaRango = 0 ;
   this.A25PortaRangoIniTEU = 0 ;
   this.A26PortaRangoFinTEU = 0 ;
   this.A27PortaTarifaTTA4 = 0 ;
   this.A28PortaTarifaTEU4 = 0 ;
   this.A29PortaTarifaTTA3 = 0 ;
   this.A30PortaTarifaTEU3 = 0 ;
   this.A31PortaTarifaTTA2 = 0 ;
   this.A32PortaTarifaTEU2 = 0 ;
   this.A33PortaTarifaTTA1 = 0 ;
   this.A34PortaTarifaTEU1 = 0 ;
   this.Events = {"e13152_client": ["ENTER", true] ,"e14152_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows'},{av:'AV7PortaContenedoresEsclusa',fld:'vPORTACONTENEDORESESCLUSA'},{av:'sPrefix'}],[]];
   this.EvtParms["GRID.LOAD"] = [[],[]];
   this.EvtParms["GRID_FIRSTPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows'},{av:'AV7PortaContenedoresEsclusa',fld:'vPORTACONTENEDORESESCLUSA'},{av:'sPrefix'}],[]];
   this.EvtParms["GRID_PREVPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows'},{av:'AV7PortaContenedoresEsclusa',fld:'vPORTACONTENEDORESESCLUSA'},{av:'sPrefix'}],[]];
   this.EvtParms["GRID_NEXTPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows'},{av:'AV7PortaContenedoresEsclusa',fld:'vPORTACONTENEDORESESCLUSA'},{av:'sPrefix'}],[]];
   this.EvtParms["GRID_LASTPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows'},{av:'AV7PortaContenedoresEsclusa',fld:'vPORTACONTENEDORESESCLUSA'},{av:'sPrefix'}],[]];
   this.setVCMap("AV7PortaContenedoresEsclusa", "vPORTACONTENEDORESESCLUSA", 0, "int");
   this.setVCMap("AV7PortaContenedoresEsclusa", "vPORTACONTENEDORESESCLUSA", 0, "int");
   GridContainer.addRefreshingVar({rfrVar:"AV7PortaContenedoresEsclusa"});
   this.InitStandaloneVars( );
});
