gx.evt.autoSkip=false;function customer(){this.ServerClass="Customer";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=true;this.SetStandaloneVars=function(){this.Gx_BScreen=gx.fn.getIntegerValue("vGXBSCREEN",",");this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Customerid=function(){gx.ajax.validSrvEvt("dyncall","Valid_Customerid",["gx.O.A3CustomerId","gx.num.urlDecimal(gx.O.A9CustomerBalance,',','.')","gx.O.A4CustomerName","gx.O.A5CustomerAddress","gx.O.A6CustomerGender","gx.num.urlDecimal(gx.O.A7CustomerTotalPurchases,',','.')","gx.num.urlDecimal(gx.O.A8CustomerTotalPayments,',','.')","gx.O.A1CountryId"],["A4CustomerName","A5CustomerAddress","A6CustomerGender","A7CustomerTotalPurchases","A8CustomerTotalPayments","A1CountryId","A9CustomerBalance","A2CountryName","Gx_mode","Z3CustomerId","Z4CustomerName","Z5CustomerAddress","Z6CustomerGender","Z7CustomerTotalPurchases","Z8CustomerTotalPayments","Z1CountryId","Z9CustomerBalance","Z2CountryName",["BTN_ENTER2","Enabled"]]);
return true};this.Valid_Customername=function(){try{var a=gx.util.balloon.getNew("CUSTOMERNAME");this.AnyError=0;if((""==this.A4CustomerName)){try{a.setError("No se permiten clientes sin nombre");this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Customeraddress=function(){try{var a=gx.util.balloon.getNew("CUSTOMERADDRESS");this.AnyError=0;if((""==this.A5CustomerAddress)){try{a.setError("No se ingresó dirección para el cliente");this.AnyError=1
}catch(b){}}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Customertotalpurchases=function(){try{var a=gx.util.balloon.getNew("CUSTOMERTOTALPURCHASES");this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Customertotalpayments=function(){try{var a=gx.util.balloon.getNew("CUSTOMERTOTALPAYMENTS");this.AnyError=0;try{this.A9CustomerBalance=this.A7CustomerTotalPurchases-this.A8CustomerTotalPayments}catch(b){}}catch(b){}try{if(a==null){return true
}return a.show()}catch(b){}return true};this.Valid_Countryid=function(){gx.ajax.validSrvEvt("dyncall","Valid_Countryid",["gx.O.A1CountryId","gx.O.A2CountryName"],["A2CountryName"]);return true};this.e11022_client=function(){this.executeServerEvent("ENTER",true)};this.e12022_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,5,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,26,27,33,36,38,41,43,46,48,51,53,56,58,61,63,66,68,71,73,76,78,84];this.GXLastCtrlId=84;
this.GXValidFnc[2]={fld:"TABLEMAIN",grid:0};this.GXValidFnc[5]={fld:"TABLETOOLBAR",grid:0};this.GXValidFnc[8]={fld:"BTN_FIRST",grid:0};this.GXValidFnc[9]={fld:"BTN_FIRST_SEPARATOR",grid:0};this.GXValidFnc[10]={fld:"BTN_PREVIOUS",grid:0};this.GXValidFnc[11]={fld:"BTN_PREVIOUS_SEPARATOR",grid:0};this.GXValidFnc[12]={fld:"BTN_NEXT",grid:0};this.GXValidFnc[13]={fld:"BTN_NEXT_SEPARATOR",grid:0};this.GXValidFnc[14]={fld:"BTN_LAST",grid:0};this.GXValidFnc[15]={fld:"BTN_LAST_SEPARATOR",grid:0};this.GXValidFnc[16]={fld:"BTN_SELECT",grid:0};
this.GXValidFnc[17]={fld:"BTN_SELECT_SEPARATOR",grid:0};this.GXValidFnc[18]={fld:"BTN_ENTER2",grid:0};this.GXValidFnc[19]={fld:"BTN_ENTER2_SEPARATOR",grid:0};this.GXValidFnc[20]={fld:"BTN_CANCEL2",grid:0};this.GXValidFnc[21]={fld:"BTN_CANCEL2_SEPARATOR",grid:0};this.GXValidFnc[22]={fld:"BTN_DELETE2",grid:0};this.GXValidFnc[23]={fld:"BTN_DELETE2_SEPARATOR",grid:0};this.GXValidFnc[26]={fld:"GROUPDATA",grid:0};this.GXValidFnc[27]={fld:"TABLE1",grid:0};this.GXValidFnc[33]={fld:"TABLE2",grid:0};this.GXValidFnc[36]={fld:"TEXTBLOCKCUSTOMERID",format:0,grid:0};
this.GXValidFnc[38]={lvl:0,type:"int",len:6,dec:0,sign:false,pic:"ZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Customerid,isvalid:null,rgrid:[],fld:"CUSTOMERID",gxz:"Z3CustomerId",gxold:"O3CustomerId",gxvar:"A3CustomerId",ucs:[],op:[73,63,58,53,48,43,68],ip:[73,63,58,53,48,43,68,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A3CustomerId=gx.num.intval(a)},v2z:function(a){gx.O.Z3CustomerId=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("CUSTOMERID",gx.O.A3CustomerId,0)},c2v:function(){gx.O.A3CustomerId=this.val()
},val:function(){return gx.fn.getIntegerValue("CUSTOMERID",",")},nac:function(){return false}};this.GXValidFnc[41]={fld:"TEXTBLOCKCUSTOMERNAME",format:0,grid:0};this.GXValidFnc[43]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Customername,isvalid:null,fld:"CUSTOMERNAME",gxz:"Z4CustomerName",gxold:"O4CustomerName",gxvar:"A4CustomerName",ucs:[],op:[43],ip:[43],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A4CustomerName=a},v2z:function(a){gx.O.Z4CustomerName=a},v2c:function(){gx.fn.setControlValue("CUSTOMERNAME",gx.O.A4CustomerName,0)
},c2v:function(){gx.O.A4CustomerName=this.val()},val:function(){return gx.fn.getControlValue("CUSTOMERNAME")},nac:function(){return false}};this.GXValidFnc[46]={fld:"TEXTBLOCKCUSTOMERADDRESS",format:0,grid:0};this.GXValidFnc[48]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Customeraddress,isvalid:null,fld:"CUSTOMERADDRESS",gxz:"Z5CustomerAddress",gxold:"O5CustomerAddress",gxvar:"A5CustomerAddress",ucs:[],op:[48],ip:[48],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A5CustomerAddress=a
},v2z:function(a){gx.O.Z5CustomerAddress=a},v2c:function(){gx.fn.setControlValue("CUSTOMERADDRESS",gx.O.A5CustomerAddress,0)},c2v:function(){gx.O.A5CustomerAddress=this.val()},val:function(){return gx.fn.getControlValue("CUSTOMERADDRESS")},nac:function(){return false}};this.GXValidFnc[51]={fld:"TEXTBLOCKCUSTOMERGENDER",format:0,grid:0};this.GXValidFnc[53]={lvl:0,type:"char",len:1,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"CUSTOMERGENDER",gxz:"Z6CustomerGender",gxold:"O6CustomerGender",gxvar:"A6CustomerGender",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"radio",v2v:function(a){gx.O.A6CustomerGender=a
},v2z:function(a){gx.O.Z6CustomerGender=a},v2c:function(){gx.fn.setRadioValue("CUSTOMERGENDER",gx.O.A6CustomerGender)},c2v:function(){gx.O.A6CustomerGender=this.val()},val:function(){return gx.fn.getControlValue("CUSTOMERGENDER")},nac:function(){return false}};this.GXValidFnc[56]={fld:"TEXTBLOCKCUSTOMERTOTALPURCHASES",format:0,grid:0};this.GXValidFnc[58]={lvl:0,type:"decimal",len:9,dec:2,sign:false,pic:"ZZZZZ9.99",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Customertotalpurchases,isvalid:null,rgrid:[],fld:"CUSTOMERTOTALPURCHASES",gxz:"Z7CustomerTotalPurchases",gxold:"O7CustomerTotalPurchases",gxvar:"A7CustomerTotalPurchases",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A7CustomerTotalPurchases=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z7CustomerTotalPurchases=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("CUSTOMERTOTALPURCHASES",gx.O.A7CustomerTotalPurchases,2,".")},c2v:function(){gx.O.A7CustomerTotalPurchases=this.val()},val:function(){return gx.fn.getDecimalValue("CUSTOMERTOTALPURCHASES",",",".")},nac:function(){return false}};this.GXValidFnc[61]={fld:"TEXTBLOCKCUSTOMERTOTALPAYMENTS",format:0,grid:0};this.GXValidFnc[63]={lvl:0,type:"decimal",len:9,dec:2,sign:false,pic:"ZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Customertotalpayments,isvalid:null,rgrid:[],fld:"CUSTOMERTOTALPAYMENTS",gxz:"Z8CustomerTotalPayments",gxold:"O8CustomerTotalPayments",gxvar:"A8CustomerTotalPayments",ucs:[],op:[68],ip:[68,63,58],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A8CustomerTotalPayments=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z8CustomerTotalPayments=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("CUSTOMERTOTALPAYMENTS",gx.O.A8CustomerTotalPayments,2,".")},c2v:function(){gx.O.A8CustomerTotalPayments=this.val()},val:function(){return gx.fn.getDecimalValue("CUSTOMERTOTALPAYMENTS",",",".")},nac:function(){return false}};this.GXValidFnc[66]={fld:"TEXTBLOCKCUSTOMERBALANCE",format:0,grid:0};this.GXValidFnc[68]={lvl:0,type:"decimal",len:9,dec:2,sign:false,pic:"ZZZZZ9.99",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"CUSTOMERBALANCE",gxz:"Z9CustomerBalance",gxold:"O9CustomerBalance",gxvar:"A9CustomerBalance",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A9CustomerBalance=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z9CustomerBalance=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("CUSTOMERBALANCE",gx.O.A9CustomerBalance,2,".")},c2v:function(){gx.O.A9CustomerBalance=this.val()},val:function(){return gx.fn.getDecimalValue("CUSTOMERBALANCE",",",".")},nac:function(){return false}};this.GXValidFnc[71]={fld:"TEXTBLOCKCOUNTRYID",format:0,grid:0};this.GXValidFnc[73]={lvl:0,type:"int",len:6,dec:0,sign:false,pic:"ZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Countryid,isvalid:null,rgrid:[],fld:"COUNTRYID",gxz:"Z1CountryId",gxold:"O1CountryId",gxvar:"A1CountryId",ucs:[],op:[78],ip:[78,73],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A1CountryId=gx.num.intval(a)
},v2z:function(a){gx.O.Z1CountryId=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("COUNTRYID",gx.O.A1CountryId,0)},c2v:function(){gx.O.A1CountryId=this.val()},val:function(){return gx.fn.getIntegerValue("COUNTRYID",",")},nac:function(){return false}};this.GXValidFnc[76]={fld:"TEXTBLOCKCOUNTRYNAME",format:0,grid:0};this.GXValidFnc[78]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"COUNTRYNAME",gxz:"Z2CountryName",gxold:"O2CountryName",gxvar:"A2CountryName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A2CountryName=a
},v2z:function(a){gx.O.Z2CountryName=a},v2c:function(){gx.fn.setControlValue("COUNTRYNAME",gx.O.A2CountryName,0)},c2v:function(){gx.O.A2CountryName=this.val()},val:function(){return gx.fn.getControlValue("COUNTRYNAME")},nac:function(){return false}};this.GXValidFnc[84]={fld:"PROMPT_1",grid:2};this.A3CustomerId=0;this.Z3CustomerId=0;this.O3CustomerId=0;this.A4CustomerName="";this.Z4CustomerName="";this.O4CustomerName="";this.A5CustomerAddress="";this.Z5CustomerAddress="";this.O5CustomerAddress="";
this.A6CustomerGender="";this.Z6CustomerGender="";this.O6CustomerGender="";this.A7CustomerTotalPurchases=0;this.Z7CustomerTotalPurchases=0;this.O7CustomerTotalPurchases=0;this.A8CustomerTotalPayments=0;this.Z8CustomerTotalPayments=0;this.O8CustomerTotalPayments=0;this.A9CustomerBalance=0;this.Z9CustomerBalance=0;this.O9CustomerBalance=0;this.A1CountryId=0;this.Z1CountryId=0;this.O1CountryId=0;this.A2CountryName="";this.Z2CountryName="";this.O2CountryName="";this.Gx_BScreen=0;this.ServerEvents=["e11022_client","e12022_client"];
this.setPrompt("PROMPT_1",[73]);this.EnterCtrl=["BTN_ENTER"];this.VarControlMap.Gx_BScreen={id:"vGXBSCREEN",grid:0,type:"int"};this.VarControlMap.Gx_mode={id:"vMODE",grid:0,type:"char"};this.SetStandaloneVars()}customer.prototype=new gx.GxObject;gx.setParentObj(new customer());