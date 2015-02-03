/*
               File: TanqueroEsclusasRangoWC
        Description: Tanquero Esclusas Rango WC
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 7:38:12.85
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
gx.define('tanqueroesclusasrangowc', true, function (CmpContext) {
   this.ServerClass =  "tanqueroesclusasrangowc" ;
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
      this.AV7TanqueroEsclusasID=gx.fn.getIntegerValue("vTANQUEROESCLUSASID",gx.thousandSeparator) ;
   };
   this.e130n2_client=function()
   {
      this.executeServerEvent("ENTER", true, arguments[0]);
   };
   this.e140n2_client=function()
   {
      this.executeServerEvent("CANCEL", true, arguments[0]);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,12,13,14,15,16,17,18,19];
   this.GXLastCtrlId =19;
   this.GridContainer = new gx.grid.grid(this, 2,"WbpLvl2",9,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"tanqueroesclusasrangowc",[],false,1,false,true,0,true,false,false,"",0,"px",gx.getMessage( "GXM_newrow"),true,false,false,null,null,false,"",false,[1,1,1,1]);
   var GridContainer = this.GridContainer;
   GridContainer.addSingleLineEdit(3,10,"TANQUERORANGO",gx.getMessage( "Identificador de rango"),"","TanqueroRango","int",0,"px",4,4,"right",null,[],3,"TanqueroRango",true,0,false,false,"Attribute",1,"WWColumn WWOptionalColumn");
   GridContainer.addSingleLineEdit(8,11,"TANQUEROBANDACPSUAB",gx.getMessage( "Banda en CP/SUAB"),"","TanqueroBandaCPSUAB","int",0,"px",10,10,"right",null,[],8,"TanqueroBandaCPSUAB",true,0,false,false,"Attribute",1,"WWColumn WWOptionalColumn");
   GridContainer.addSingleLineEdit(4,12,"TANQUEROTARIFACPSUAB",gx.getMessage( "Tarifa CP/SUAB"),"","TanqueroTarifaCPSUAB","decimal",0,"px",7,7,"right",null,[],4,"TanqueroTarifaCPSUAB",true,2,false,false,"Attribute",1,"WWColumn WWOptionalColumn");
   GridContainer.addSingleLineEdit(5,13,"TANQUEROBANDATM",gx.getMessage( "Banda TM"),"","TanqueroBandaTM","int",0,"px",12,12,"right",null,[],5,"TanqueroBandaTM",true,0,false,false,"Attribute",1,"WWColumn WWOptionalColumn");
   GridContainer.addSingleLineEdit(6,14,"TANQUEROTARIFATM",gx.getMessage( "Tarifa TM"),"","TanqueroTarifaTM","decimal",0,"px",7,7,"right",null,[],6,"TanqueroTarifaTM",true,2,false,false,"Attribute",1,"WWColumn WWOptionalColumn");
   GridContainer.addSingleLineEdit(7,15,"TANQUEROTARIFALASTRE",gx.getMessage( "Tarifa Lastre"),"","TanqueroTarifaLastre","decimal",0,"px",7,7,"right",null,[],7,"TanqueroTarifaLastre",true,2,false,false,"Attribute",1,"WWColumn WWOptionalColumn");
   this.setGrid(GridContainer);
   GXValidFnc[2]={fld:"",grid:0};
   GXValidFnc[3]={fld:"MAIN",grid:0};
   GXValidFnc[4]={fld:"",grid:0};
   GXValidFnc[5]={fld:"",grid:0};
   GXValidFnc[6]={fld:"GRIDTABLE",grid:0};
   GXValidFnc[7]={fld:"",grid:0};
   GXValidFnc[8]={fld:"",grid:0};
   GXValidFnc[10]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,isacc:0,grid:9,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"TANQUERORANGO",gxz:"Z3TanqueroRango",gxold:"O3TanqueroRango",gxvar:"A3TanqueroRango",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){gx.O.A3TanqueroRango=gx.num.intval(Value)},v2z:function(Value){gx.O.Z3TanqueroRango=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("TANQUERORANGO",row || gx.fn.currentGridRowImpl(9),gx.O.A3TanqueroRango,0)},c2v:function(){gx.O.A3TanqueroRango=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("TANQUERORANGO",row || gx.fn.currentGridRowImpl(9),gx.thousandSeparator)},nac:gx.falseFn};
   GXValidFnc[11]={lvl:2,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZ9",ro:1,isacc:0,grid:9,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"TANQUEROBANDACPSUAB",gxz:"Z8TanqueroBandaCPSUAB",gxold:"O8TanqueroBandaCPSUAB",gxvar:"A8TanqueroBandaCPSUAB",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){gx.O.A8TanqueroBandaCPSUAB=gx.num.intval(Value)},v2z:function(Value){gx.O.Z8TanqueroBandaCPSUAB=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("TANQUEROBANDACPSUAB",row || gx.fn.currentGridRowImpl(9),gx.O.A8TanqueroBandaCPSUAB,0)},c2v:function(){gx.O.A8TanqueroBandaCPSUAB=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("TANQUEROBANDACPSUAB",row || gx.fn.currentGridRowImpl(9),gx.thousandSeparator)},nac:gx.falseFn};
   GXValidFnc[12]={lvl:2,type:"decimal",len:7,dec:2,sign:false,pic:"ZZZ9.99",ro:1,isacc:0,grid:9,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"TANQUEROTARIFACPSUAB",gxz:"Z4TanqueroTarifaCPSUAB",gxold:"O4TanqueroTarifaCPSUAB",gxvar:"A4TanqueroTarifaCPSUAB",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){gx.O.A4TanqueroTarifaCPSUAB=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z4TanqueroTarifaCPSUAB=gx.fn.toDecimalValue(Value,gx.thousandSeparator,gx.decimalPoint)},v2c:function(row){gx.fn.setGridDecimalValue("TANQUEROTARIFACPSUAB",row || gx.fn.currentGridRowImpl(9),gx.O.A4TanqueroTarifaCPSUAB,2,gx.decimalPoint);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){gx.O.A4TanqueroTarifaCPSUAB=gx.fn.toDecimalValue(this.val(),',','.')},val:function(row){return gx.fn.getGridDecimalValue("TANQUEROTARIFACPSUAB",row || gx.fn.currentGridRowImpl(9),gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};
   GXValidFnc[13]={lvl:2,type:"int",len:12,dec:0,sign:false,pic:"ZZZZZZZZZZZ9",ro:1,isacc:0,grid:9,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"TANQUEROBANDATM",gxz:"Z5TanqueroBandaTM",gxold:"O5TanqueroBandaTM",gxvar:"A5TanqueroBandaTM",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){gx.O.A5TanqueroBandaTM=gx.num.intval(Value)},v2z:function(Value){gx.O.Z5TanqueroBandaTM=gx.num.intval(Value)},v2c:function(row){gx.fn.setGridControlValue("TANQUEROBANDATM",row || gx.fn.currentGridRowImpl(9),gx.O.A5TanqueroBandaTM,0)},c2v:function(){gx.O.A5TanqueroBandaTM=gx.num.intval(this.val())},val:function(row){return gx.fn.getGridIntegerValue("TANQUEROBANDATM",row || gx.fn.currentGridRowImpl(9),gx.thousandSeparator)},nac:gx.falseFn};
   GXValidFnc[14]={lvl:2,type:"decimal",len:7,dec:2,sign:false,pic:"ZZZ9.99",ro:1,isacc:0,grid:9,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"TANQUEROTARIFATM",gxz:"Z6TanqueroTarifaTM",gxold:"O6TanqueroTarifaTM",gxvar:"A6TanqueroTarifaTM",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){gx.O.A6TanqueroTarifaTM=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z6TanqueroTarifaTM=gx.fn.toDecimalValue(Value,gx.thousandSeparator,gx.decimalPoint)},v2c:function(row){gx.fn.setGridDecimalValue("TANQUEROTARIFATM",row || gx.fn.currentGridRowImpl(9),gx.O.A6TanqueroTarifaTM,2,gx.decimalPoint);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){gx.O.A6TanqueroTarifaTM=gx.fn.toDecimalValue(this.val(),',','.')},val:function(row){return gx.fn.getGridDecimalValue("TANQUEROTARIFATM",row || gx.fn.currentGridRowImpl(9),gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};
   GXValidFnc[15]={lvl:2,type:"decimal",len:7,dec:2,sign:false,pic:"ZZZ9.99",ro:1,isacc:0,grid:9,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"TANQUEROTARIFALASTRE",gxz:"Z7TanqueroTarifaLastre",gxold:"O7TanqueroTarifaLastre",gxvar:"A7TanqueroTarifaLastre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',v2v:function(Value){gx.O.A7TanqueroTarifaLastre=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z7TanqueroTarifaLastre=gx.fn.toDecimalValue(Value,gx.thousandSeparator,gx.decimalPoint)},v2c:function(row){gx.fn.setGridDecimalValue("TANQUEROTARIFALASTRE",row || gx.fn.currentGridRowImpl(9),gx.O.A7TanqueroTarifaLastre,2,gx.decimalPoint);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){gx.O.A7TanqueroTarifaLastre=gx.fn.toDecimalValue(this.val(),',','.')},val:function(row){return gx.fn.getGridDecimalValue("TANQUEROTARIFALASTRE",row || gx.fn.currentGridRowImpl(9),gx.thousandSeparator,gx.decimalPoint)},nac:gx.falseFn};
   GXValidFnc[16]={fld:"",grid:0};
   GXValidFnc[17]={fld:"",grid:0};
   GXValidFnc[18]={fld:"",grid:0};
   GXValidFnc[19]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"TANQUEROESCLUSASID",gxz:"Z1TanqueroEsclusasID",gxold:"O1TanqueroEsclusasID",gxvar:"A1TanqueroEsclusasID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"combo",v2v:function(Value){gx.O.A1TanqueroEsclusasID=gx.num.intval(Value)},v2z:function(Value){gx.O.Z1TanqueroEsclusasID=gx.num.intval(Value)},v2c:function(){gx.fn.setComboBoxValue("TANQUEROESCLUSASID",gx.O.A1TanqueroEsclusasID);if (typeof(this.dom_hdl) == 'function') this.dom_hdl.call(gx.O);},c2v:function(){gx.O.A1TanqueroEsclusasID=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("TANQUEROESCLUSASID",gx.thousandSeparator)},nac:gx.falseFn};
   this.declareDomainHdlr( 19 , function() {
   });
   this.Z3TanqueroRango = 0 ;
   this.O3TanqueroRango = 0 ;
   this.Z8TanqueroBandaCPSUAB = 0 ;
   this.O8TanqueroBandaCPSUAB = 0 ;
   this.Z4TanqueroTarifaCPSUAB = 0 ;
   this.O4TanqueroTarifaCPSUAB = 0 ;
   this.Z5TanqueroBandaTM = 0 ;
   this.O5TanqueroBandaTM = 0 ;
   this.Z6TanqueroTarifaTM = 0 ;
   this.O6TanqueroTarifaTM = 0 ;
   this.Z7TanqueroTarifaLastre = 0 ;
   this.O7TanqueroTarifaLastre = 0 ;
   this.A1TanqueroEsclusasID = 0 ;
   this.Z1TanqueroEsclusasID = 0 ;
   this.O1TanqueroEsclusasID = 0 ;
   this.A1TanqueroEsclusasID = 0 ;
   this.AV7TanqueroEsclusasID = 0 ;
   this.A3TanqueroRango = 0 ;
   this.A8TanqueroBandaCPSUAB = 0 ;
   this.A4TanqueroTarifaCPSUAB = 0 ;
   this.A5TanqueroBandaTM = 0 ;
   this.A6TanqueroTarifaTM = 0 ;
   this.A7TanqueroTarifaLastre = 0 ;
   this.Events = {"e130n2_client": ["ENTER", true] ,"e140n2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows'},{av:'AV7TanqueroEsclusasID',fld:'vTANQUEROESCLUSASID'},{av:'sPrefix'}],[]];
   this.EvtParms["GRID.LOAD"] = [[],[]];
   this.EvtParms["GRID_FIRSTPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows'},{av:'AV7TanqueroEsclusasID',fld:'vTANQUEROESCLUSASID'},{av:'sPrefix'}],[]];
   this.EvtParms["GRID_PREVPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows'},{av:'AV7TanqueroEsclusasID',fld:'vTANQUEROESCLUSASID'},{av:'sPrefix'}],[]];
   this.EvtParms["GRID_NEXTPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows'},{av:'AV7TanqueroEsclusasID',fld:'vTANQUEROESCLUSASID'},{av:'sPrefix'}],[]];
   this.EvtParms["GRID_LASTPAGE"] = [[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows'},{av:'AV7TanqueroEsclusasID',fld:'vTANQUEROESCLUSASID'},{av:'sPrefix'}],[]];
   this.setVCMap("AV7TanqueroEsclusasID", "vTANQUEROESCLUSASID", 0, "int");
   this.setVCMap("AV7TanqueroEsclusasID", "vTANQUEROESCLUSASID", 0, "int");
   GridContainer.addRefreshingVar({rfrVar:"AV7TanqueroEsclusasID"});
   this.InitStandaloneVars( );
});
