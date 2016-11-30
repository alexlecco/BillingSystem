/*
               File: Gx0020
        Description: Selection List Customer
             Author: GeneXus C# Generator version 10_1_6-46473
       Generated on: 11/30/2016 15:26:1.86
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function gx0020() {
   this.ServerClass =  "Gx0020" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = true;
   this.autoRefresh = true;
   this.SetStandaloneVars=function()
   {
      this.AV13pCustomerId=gx.fn.getIntegerValue("vPCUSTOMERID",',') ;
   };
   this.Valid_Customerid=function()
   {
      try {
         if(  gx.fn.currentGridRowImpl(51) ===0) return true;
         var gxballoon = gx.util.balloon.getNew("CUSTOMERID", gx.fn.currentGridRowImpl(51));
         this.AnyError  = 0;
         this.StandaloneModal( );
         this.StandaloneNotModal( );

      }
      catch(e){}
      try {
         if (gxballoon == null) return true; return gxballoon.show();
      }
      catch(e){}
      return true ;
   }
   this.e13052_client=function()
   {
      this.executeServerEvent("ENTER", true, arguments[0]);
   };
   this.e14051_client=function()
   {
      this.executeServerEvent("CANCEL", true);
   };
   this.GXValidFnc = [];
   this.GXCtrlIds=[2,8,9,12,14,17,19,22,24,27,29,32,34,37,39,42,44,47,48,52,53,54,55,56,57,58,61];
   this.GXLastCtrlId =61;
   this.Grid1Container = new gx.grid.grid(this, 2,"WbpLvl2",51,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0020",[],false,1,false,true,10,true,false,false,"",0,"px","New row",true,false,false,null,null,false,"");
   this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",52,0,"px",17,"px",null,"","");
   this.Grid1Container.addSingleLineEdit(3,53,"CUSTOMERID","Id","","CustomerId","int",0,"px",6,6,"right",null,[],3,"CustomerId",true,0,false,false);
   this.Grid1Container.addSingleLineEdit(4,54,"CUSTOMERNAME","Name","Select","CustomerName","char",0,"px",30,30,"left",null,[],4,"CustomerName",true,0,false,false);
   this.Grid1Container.addSingleLineEdit(5,55,"CUSTOMERADDRESS","Address","","CustomerAddress","char",0,"px",30,30,"left",null,[],5,"CustomerAddress",true,0,false,false);
   this.Grid1Container.addRadioButton(6,56,"CUSTOMERGENDER","Gender","CustomerGender","char",null,false,true,false);
   this.Grid1Container.addSingleLineEdit(7,57,"CUSTOMERTOTALPURCHASES","Total Purchases","","CustomerTotalPurchases","decimal",0,"px",9,9,"right",null,[],7,"CustomerTotalPurchases",true,2,false,false);
   this.Grid1Container.addSingleLineEdit(1,58,"COUNTRYID","Country Id","","CountryId","int",0,"px",6,6,"right",null,[],1,"CountryId",true,0,false,false);
   this.setGrid(this.Grid1Container);
   this.GXValidFnc[2]={fld:"TABLE1",grid:0};
   this.GXValidFnc[8]={fld:"GROUP1",grid:0};
   this.GXValidFnc[9]={fld:"TABLE2",grid:0};
   this.GXValidFnc[12]={fld:"TEXTBLOCKCUSTOMERID", format:0,grid:0};
   this.GXValidFnc[14]={lvl:0,type:"int",len:6,dec:0,sign:false,pic:"ZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCCUSTOMERID",gxz:"ZV6cCustomerId",gxold:"OV6cCustomerId",gxvar:"AV6cCustomerId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV6cCustomerId=gx.num.intval(Value)},v2z:function(Value){gx.O.ZV6cCustomerId=gx.num.intval(Value)},v2c:function(){gx.fn.setControlValue("vCCUSTOMERID",gx.O.AV6cCustomerId,0)},c2v:function(){gx.O.AV6cCustomerId=this.val()},val:function(){return gx.fn.getIntegerValue("vCCUSTOMERID",',')},nac:function(){return  false }};
   this.GXValidFnc[17]={fld:"TEXTBLOCKCUSTOMERNAME", format:0,grid:0};
   this.GXValidFnc[19]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCCUSTOMERNAME",gxz:"ZV7cCustomerName",gxold:"OV7cCustomerName",gxvar:"AV7cCustomerName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV7cCustomerName=Value},v2z:function(Value){gx.O.ZV7cCustomerName=Value},v2c:function(){gx.fn.setControlValue("vCCUSTOMERNAME",gx.O.AV7cCustomerName,0)},c2v:function(){gx.O.AV7cCustomerName=this.val()},val:function(){return gx.fn.getControlValue("vCCUSTOMERNAME")},nac:function(){return  false }};
   this.GXValidFnc[22]={fld:"TEXTBLOCKCUSTOMERADDRESS", format:0,grid:0};
   this.GXValidFnc[24]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCCUSTOMERADDRESS",gxz:"ZV8cCustomerAddress",gxold:"OV8cCustomerAddress",gxvar:"AV8cCustomerAddress",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV8cCustomerAddress=Value},v2z:function(Value){gx.O.ZV8cCustomerAddress=Value},v2c:function(){gx.fn.setControlValue("vCCUSTOMERADDRESS",gx.O.AV8cCustomerAddress,0)},c2v:function(){gx.O.AV8cCustomerAddress=this.val()},val:function(){return gx.fn.getControlValue("vCCUSTOMERADDRESS")},nac:function(){return  false }};
   this.GXValidFnc[27]={fld:"TEXTBLOCKCUSTOMERGENDER", format:0,grid:0};
   this.GXValidFnc[29]={lvl:0,type:"char",len:1,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCCUSTOMERGENDER",gxz:"ZV9cCustomerGender",gxold:"OV9cCustomerGender",gxvar:"AV9cCustomerGender",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"radio",v2v:function(Value){gx.O.AV9cCustomerGender=Value},v2z:function(Value){gx.O.ZV9cCustomerGender=Value},v2c:function(){gx.fn.setRadioValue("vCCUSTOMERGENDER",gx.O.AV9cCustomerGender)},c2v:function(){gx.O.AV9cCustomerGender=this.val()},val:function(){return gx.fn.getControlValue("vCCUSTOMERGENDER")},nac:function(){return  false }};
   this.GXValidFnc[32]={fld:"TEXTBLOCKCUSTOMERTOTALPURCHASES", format:0,grid:0};
   this.GXValidFnc[34]={lvl:0,type:"decimal",len:9,dec:2,sign:false,pic:"ZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCCUSTOMERTOTALPURCHASES",gxz:"ZV10cCustomerTotalPurchases",gxold:"OV10cCustomerTotalPurchases",gxvar:"AV10cCustomerTotalPurchases",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV10cCustomerTotalPurchases=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.ZV10cCustomerTotalPurchases=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vCCUSTOMERTOTALPURCHASES",gx.O.AV10cCustomerTotalPurchases,2,'.')},c2v:function(){gx.O.AV10cCustomerTotalPurchases=this.val()},val:function(){return gx.fn.getDecimalValue("vCCUSTOMERTOTALPURCHASES",',','.')},nac:function(){return  false }};
   this.GXValidFnc[37]={fld:"TEXTBLOCKCUSTOMERTOTALPAYMENTS", format:0,grid:0};
   this.GXValidFnc[39]={lvl:0,type:"decimal",len:9,dec:2,sign:false,pic:"ZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCCUSTOMERTOTALPAYMENTS",gxz:"ZV11cCustomerTotalPayments",gxold:"OV11cCustomerTotalPayments",gxvar:"AV11cCustomerTotalPayments",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV11cCustomerTotalPayments=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.ZV11cCustomerTotalPayments=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vCCUSTOMERTOTALPAYMENTS",gx.O.AV11cCustomerTotalPayments,2,'.')},c2v:function(){gx.O.AV11cCustomerTotalPayments=this.val()},val:function(){return gx.fn.getDecimalValue("vCCUSTOMERTOTALPAYMENTS",',','.')},nac:function(){return  false }};
   this.GXValidFnc[42]={fld:"TEXTBLOCKCUSTOMERBALANCE", format:0,grid:0};
   this.GXValidFnc[44]={lvl:0,type:"decimal",len:9,dec:2,sign:false,pic:"ZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCCUSTOMERBALANCE",gxz:"ZV12cCustomerBalance",gxold:"OV12cCustomerBalance",gxvar:"AV12cCustomerBalance",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV12cCustomerBalance=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.ZV12cCustomerBalance=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setDecimalValue("vCCUSTOMERBALANCE",gx.O.AV12cCustomerBalance,2,'.')},c2v:function(){gx.O.AV12cCustomerBalance=this.val()},val:function(){return gx.fn.getDecimalValue("vCCUSTOMERBALANCE",',','.')},nac:function(){return  false }};
   this.GXValidFnc[47]={fld:"GROUP2",grid:0};
   this.GXValidFnc[48]={fld:"TABLE3",grid:0};
   this.GXValidFnc[52]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.AV5LinkSelection=Value},v2z:function(Value){gx.O.ZV5LinkSelection=Value},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(51))},nac:function(){return  false }};
   this.GXValidFnc[53]={lvl:2,type:"int",len:6,dec:0,sign:false,pic:"ZZZZZ9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:this.Valid_Customerid,isvalid:null,rgrid:[],fld:"CUSTOMERID",gxz:"Z3CustomerId",gxold:"O3CustomerId",gxvar:"A3CustomerId",ucs:[],op:[],ip:[53],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A3CustomerId=gx.num.intval(Value)},v2z:function(Value){gx.O.Z3CustomerId=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("CUSTOMERID",gx.fn.currentGridRowImpl(51),gx.O.A3CustomerId,0)},c2v:function(){gx.O.A3CustomerId=this.val()},val:function(){return gx.fn.getGridIntegerValue("CUSTOMERID",gx.fn.currentGridRowImpl(51),',')},nac:function(){return  false }};
   this.GXValidFnc[54]={lvl:2,type:"char",len:30,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CUSTOMERNAME",gxz:"Z4CustomerName",gxold:"O4CustomerName",gxvar:"A4CustomerName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A4CustomerName=Value},v2z:function(Value){gx.O.Z4CustomerName=Value},v2c:function(){gx.fn.setGridControlValue("CUSTOMERNAME",gx.fn.currentGridRowImpl(51),gx.O.A4CustomerName,0)},c2v:function(){gx.O.A4CustomerName=this.val()},val:function(){return gx.fn.getGridControlValue("CUSTOMERNAME",gx.fn.currentGridRowImpl(51))},nac:function(){return  false }};
   this.GXValidFnc[55]={lvl:2,type:"char",len:30,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CUSTOMERADDRESS",gxz:"Z5CustomerAddress",gxold:"O5CustomerAddress",gxvar:"A5CustomerAddress",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A5CustomerAddress=Value},v2z:function(Value){gx.O.Z5CustomerAddress=Value},v2c:function(){gx.fn.setGridControlValue("CUSTOMERADDRESS",gx.fn.currentGridRowImpl(51),gx.O.A5CustomerAddress,0)},c2v:function(){gx.O.A5CustomerAddress=this.val()},val:function(){return gx.fn.getGridControlValue("CUSTOMERADDRESS",gx.fn.currentGridRowImpl(51))},nac:function(){return  false }};
   this.GXValidFnc[56]={lvl:2,type:"char",len:1,dec:0,sign:false,ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CUSTOMERGENDER",gxz:"Z6CustomerGender",gxold:"O6CustomerGender",gxvar:"A6CustomerGender",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"radio",v2v:function(Value){gx.O.A6CustomerGender=Value},v2z:function(Value){gx.O.Z6CustomerGender=Value},v2c:function(){},c2v:function(){gx.O.A6CustomerGender=this.val()},val:function(){return gx.fn.getGridControlValue("CUSTOMERGENDER",gx.fn.currentGridRowImpl(51))},nac:function(){return  false }};
   this.GXValidFnc[57]={lvl:2,type:"decimal",len:9,dec:2,sign:false,pic:"ZZZZZ9.99",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"CUSTOMERTOTALPURCHASES",gxz:"Z7CustomerTotalPurchases",gxold:"O7CustomerTotalPurchases",gxvar:"A7CustomerTotalPurchases",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A7CustomerTotalPurchases=gx.fn.toDecimalValue(Value,',','.')},v2z:function(Value){gx.O.Z7CustomerTotalPurchases=gx.fn.toDecimalValue(Value,',','.')},v2c:function(){gx.fn.setGridDecimalValue("CUSTOMERTOTALPURCHASES",gx.fn.currentGridRowImpl(51),gx.O.A7CustomerTotalPurchases,2,'.')},c2v:function(){gx.O.A7CustomerTotalPurchases=this.val()},val:function(){return gx.fn.getGridDecimalValue("CUSTOMERTOTALPURCHASES",gx.fn.currentGridRowImpl(51),',','.')},nac:function(){return  false }};
   this.GXValidFnc[58]={lvl:2,type:"int",len:6,dec:0,sign:false,pic:"ZZZZZ9",ro:1,grid:51,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"COUNTRYID",gxz:"Z1CountryId",gxold:"O1CountryId",gxvar:"A1CountryId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(Value){gx.O.A1CountryId=gx.num.intval(Value)},v2z:function(Value){gx.O.Z1CountryId=gx.num.intval(Value)},v2c:function(){gx.fn.setGridControlValue("COUNTRYID",gx.fn.currentGridRowImpl(51),gx.O.A1CountryId,0)},c2v:function(){gx.O.A1CountryId=this.val()},val:function(){return gx.fn.getGridIntegerValue("COUNTRYID",gx.fn.currentGridRowImpl(51),',')},nac:function(){return  false }};
   this.GXValidFnc[61]={fld:"TABLE4",grid:0};
   this.AV6cCustomerId = 0 ;
   this.ZV6cCustomerId = 0 ;
   this.OV6cCustomerId = 0 ;
   this.AV7cCustomerName = "" ;
   this.ZV7cCustomerName = "" ;
   this.OV7cCustomerName = "" ;
   this.AV8cCustomerAddress = "" ;
   this.ZV8cCustomerAddress = "" ;
   this.OV8cCustomerAddress = "" ;
   this.AV9cCustomerGender = "" ;
   this.ZV9cCustomerGender = "" ;
   this.OV9cCustomerGender = "" ;
   this.AV10cCustomerTotalPurchases = 0 ;
   this.ZV10cCustomerTotalPurchases = 0 ;
   this.OV10cCustomerTotalPurchases = 0 ;
   this.AV11cCustomerTotalPayments = 0 ;
   this.ZV11cCustomerTotalPayments = 0 ;
   this.OV11cCustomerTotalPayments = 0 ;
   this.AV12cCustomerBalance = 0 ;
   this.ZV12cCustomerBalance = 0 ;
   this.OV12cCustomerBalance = 0 ;
   this.ZV5LinkSelection = "" ;
   this.OV5LinkSelection = "" ;
   this.Z3CustomerId = 0 ;
   this.O3CustomerId = 0 ;
   this.Z4CustomerName = "" ;
   this.O4CustomerName = "" ;
   this.Z5CustomerAddress = "" ;
   this.O5CustomerAddress = "" ;
   this.Z6CustomerGender = "" ;
   this.O6CustomerGender = "" ;
   this.Z7CustomerTotalPurchases = 0 ;
   this.O7CustomerTotalPurchases = 0 ;
   this.Z1CountryId = 0 ;
   this.O1CountryId = 0 ;
   this.AV13pCustomerId = 0 ;
   this.A8CustomerTotalPayments = 0 ;
   this.A9CustomerBalance = 0 ;
   this.AV5LinkSelection = "" ;
   this.A3CustomerId = 0 ;
   this.A4CustomerName = "" ;
   this.A5CustomerAddress = "" ;
   this.A6CustomerGender = "" ;
   this.A7CustomerTotalPurchases = 0 ;
   this.A1CountryId = 0 ;
   this.ServerEvents = ["e13052_client" ,"e14051_client"];
   this.VarControlMap["AV13pCustomerId"] = {id:"vPCUSTOMERID",grid:0,type:"int"};
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[24]);
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[29]);
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[34]);
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[39]);
   this.Grid1Container.addRefreshingVar(this.GXValidFnc[44]);
   this.SetStandaloneVars( );
}
gx0020.prototype = new gx.GxObject;
gx.setParentObj(new gx0020());
