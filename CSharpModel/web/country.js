/*
               File: Country
        Description: Country
             Author: GeneXus C# Generator version 10_1_6-46473
       Generated on: 11/30/2016 15:26:4.8
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function country() {
   this.ServerClass =  "Country" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("trn");
   this.hasEnterEvent = true;
   this.SetStandaloneVars=function()
   {
      this.Gx_mode=gx.fn.getControlValue("vMODE") ;
   };
   this.Valid_Countryid=function()
   {
      /*
         call server method valid_CountryId
      */
      gx.ajax.validSrvEvt("dyncall","Valid_Countryid",["gx.O.A1CountryId", "gx.O.A2CountryName"],["A2CountryName", "Gx_mode", "Z1CountryId", "Z2CountryName", ["BTN_ENTER2","Enabled"]]);
      return true;
   }
   this.Valid_Countryname=function()
   {
      try {
         var gxballoon = gx.util.balloon.getNew("COUNTRYNAME");
         this.AnyError  = 0;
         if ( (""==this.A2CountryName) )
         {
            try {
               gxballoon.setError("No se permiten PAISES sin NOMBRE");
               this.AnyError = 1 ;
            }
            catch(e){}
         }

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e11011_client=function()
   {
      this.executeServerEvent("ENTER", true);
   };
   this.e12011_client=function()
   {
      this.executeServerEvent("CANCEL", true);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,5,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,26,27,33,36,38,41,43];
   this.GXLastCtrlId =43;
   this.GXValidFnc[2]={fld:"TABLEMAIN",grid:0};
   this.GXValidFnc[5]={fld:"TABLETOOLBAR",grid:0};
   this.GXValidFnc[8]={fld:"BTN_FIRST",grid:0};
   this.GXValidFnc[9]={fld:"BTN_FIRST_SEPARATOR",grid:0};
   this.GXValidFnc[10]={fld:"BTN_PREVIOUS",grid:0};
   this.GXValidFnc[11]={fld:"BTN_PREVIOUS_SEPARATOR",grid:0};
   this.GXValidFnc[12]={fld:"BTN_NEXT",grid:0};
   this.GXValidFnc[13]={fld:"BTN_NEXT_SEPARATOR",grid:0};
   this.GXValidFnc[14]={fld:"BTN_LAST",grid:0};
   this.GXValidFnc[15]={fld:"BTN_LAST_SEPARATOR",grid:0};
   this.GXValidFnc[16]={fld:"BTN_SELECT",grid:0};
   this.GXValidFnc[17]={fld:"BTN_SELECT_SEPARATOR",grid:0};
   this.GXValidFnc[18]={fld:"BTN_ENTER2",grid:0};
   this.GXValidFnc[19]={fld:"BTN_ENTER2_SEPARATOR",grid:0};
   this.GXValidFnc[20]={fld:"BTN_CANCEL2",grid:0};
   this.GXValidFnc[21]={fld:"BTN_CANCEL2_SEPARATOR",grid:0};
   this.GXValidFnc[22]={fld:"BTN_DELETE2",grid:0};
   this.GXValidFnc[23]={fld:"BTN_DELETE2_SEPARATOR",grid:0};
   this.GXValidFnc[26]={fld:"GROUPDATA",grid:0};
   this.GXValidFnc[27]={fld:"TABLE1",grid:0};
   this.GXValidFnc[33]={fld:"TABLE2",grid:0};
   this.GXValidFnc[36]={fld:"TEXTBLOCKCOUNTRYID", format:0,grid:0};
   this.GXValidFnc[38]={lvl:0,type:"int",len:6,dec:0,sign:false,pic:"ZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Countryid,isvalid:null,rgrid:[],fld:"COUNTRYID",gxz:"Z1CountryId",gxold:"O1CountryId",gxvar:"A1CountryId",ucs:[],op:[43],ip:[43,38],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A1CountryId=gx.num.intval(Value)},v2z:function(Value){gx.O.Z1CountryId=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("COUNTRYID",gx.O.A1CountryId,0)},c2v:function(){gx.O.A1CountryId=this.val()},val:function(){return gx.fn.getIntegerValue("COUNTRYID",',')},nac:function(){return  false }};
   this.GXValidFnc[41]={fld:"TEXTBLOCKCOUNTRYNAME", format:0,grid:0};
   this.GXValidFnc[43]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Countryname,isvalid:null,fld:"COUNTRYNAME",gxz:"Z2CountryName",gxold:"O2CountryName",gxvar:"A2CountryName",ucs:[],op:[43],ip:[43],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A2CountryName=Value},v2z:function(Value){gx.O.Z2CountryName=Value},v2c:function(){gx.fn.setControlValue("COUNTRYNAME",gx.O.A2CountryName,0)},c2v:function(){gx.O.A2CountryName=this.val()},val:function(){return gx.fn.getControlValue("COUNTRYNAME")},nac:function(){return  false }};
   this.A1CountryId = 0 ;
   this.Z1CountryId = 0 ;
   this.O1CountryId = 0 ;
   this.A2CountryName = "" ;
   this.Z2CountryName = "" ;
   this.O2CountryName = "" ;
   this.ServerEvents = ["e11011_client" ,"e12011_client"];
   this.EnterCtrl = ["BTN_ENTER"];
   this.VarControlMap["Gx_mode"] = {id:"vMODE",grid:0,type:"char"};
   this.SetStandaloneVars( );
}
country.prototype = new gx.GxObject;
gx.setParentObj(new country());
