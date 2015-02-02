/*
               File: Home
        Description: Home
             Author: GeneXus C# Generator version 10_3_2-86442
       Generated on: 1/20/2015 7:38:21.1
       Program type: Main program
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
gx.define('home', false, function () {
   this.ServerClass =  "home" ;
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
   this.e120h2_client=function()
   {
      this.executeServerEvent("ENTER", true, arguments[0]);
   };
   this.e130h2_client=function()
   {
      this.executeServerEvent("CANCEL", true, arguments[0]);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,8];
   this.GXLastCtrlId =8;
   this.Grid1Container = new gx.grid.grid(this, 2,"WbpLvl2",5,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"home",[],true,1,true,true,0,false,false,false,"",100,"%",gx.getMessage( "GXM_newrow"),false,false,false,null,null,false,"",false,[1,1,1,1]);
   var Grid1Container = this.Grid1Container;
   Grid1Container.startRow("","","","","","");
   Grid1Container.startCell("","","","","","","","","","");
   Grid1Container.addSingleLineEdit("Menuitem",8,"vMENUITEM","","","MenuItem","char",80,"chr",100,80,"left",null,[],"Menuitem","MenuItem",true,0,false,false,"Attribute",1,"");
   Grid1Container.endCell();
   Grid1Container.endRow();
   this.setGrid(Grid1Container);
   GXValidFnc[2]={fld:"TABLE1",grid:0};
   GXValidFnc[8]={lvl:2,type:"char",len:100,dec:0,sign:false,ro:1,isacc:0,grid:5,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vMENUITEM",gxz:"ZV5MenuItem",gxold:"OV5MenuItem",gxvar:"AV5MenuItem",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){gx.O.AV5MenuItem=Value},v2z:function(Value){gx.O.ZV5MenuItem=Value},v2c:function(row){gx.fn.setGridControlValue("vMENUITEM",row || gx.fn.currentGridRowImpl(5),gx.O.AV5MenuItem,0)},c2v:function(){gx.O.AV5MenuItem=this.val()},val:function(row){return gx.fn.getGridControlValue("vMENUITEM",row || gx.fn.currentGridRowImpl(5))},nac:gx.falseFn};
   this.AV5MenuItem = "" ;
   this.Events = {"e120h2_client": ["ENTER", true] ,"e130h2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'}],[]];
   this.InitStandaloneVars( );
});
gx.createParentObj(home);
