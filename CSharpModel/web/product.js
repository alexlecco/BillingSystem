gx.evt.autoSkip=false;function product(){this.ServerClass="Product";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=true;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Productid=function(){gx.ajax.validSrvEvt("dyncall","Valid_Productid",["gx.O.A10ProductId","gx.O.A11ProductDescription","gx.O.A12ProductStock","gx.num.urlDecimal(gx.O.A13ProductPrice,',','.')"],["A11ProductDescription","A12ProductStock","A13ProductPrice","Gx_mode","Z10ProductId","Z11ProductDescription","Z12ProductStock","Z13ProductPrice",["A12ProductStock","Enabled"],["BTN_ENTER2","Enabled"]]);
return true};this.Valid_Productstock=function(){try{var a=gx.util.balloon.getNew("PRODUCTSTOCK");this.AnyError=0;if((0==this.A12ProductStock)){try{a.setError("No se permiten PRODUCTOS sin STOCK");this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.e11033_client=function(){this.executeServerEvent("ENTER",true)};this.e12033_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,5,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,26,27,33,36,38,41,43,46,48,51,53];
this.GXLastCtrlId=53;this.GXValidFnc[2]={fld:"TABLEMAIN",grid:0};this.GXValidFnc[5]={fld:"TABLETOOLBAR",grid:0};this.GXValidFnc[8]={fld:"BTN_FIRST",grid:0};this.GXValidFnc[9]={fld:"BTN_FIRST_SEPARATOR",grid:0};this.GXValidFnc[10]={fld:"BTN_PREVIOUS",grid:0};this.GXValidFnc[11]={fld:"BTN_PREVIOUS_SEPARATOR",grid:0};this.GXValidFnc[12]={fld:"BTN_NEXT",grid:0};this.GXValidFnc[13]={fld:"BTN_NEXT_SEPARATOR",grid:0};this.GXValidFnc[14]={fld:"BTN_LAST",grid:0};this.GXValidFnc[15]={fld:"BTN_LAST_SEPARATOR",grid:0};
this.GXValidFnc[16]={fld:"BTN_SELECT",grid:0};this.GXValidFnc[17]={fld:"BTN_SELECT_SEPARATOR",grid:0};this.GXValidFnc[18]={fld:"BTN_ENTER2",grid:0};this.GXValidFnc[19]={fld:"BTN_ENTER2_SEPARATOR",grid:0};this.GXValidFnc[20]={fld:"BTN_CANCEL2",grid:0};this.GXValidFnc[21]={fld:"BTN_CANCEL2_SEPARATOR",grid:0};this.GXValidFnc[22]={fld:"BTN_DELETE2",grid:0};this.GXValidFnc[23]={fld:"BTN_DELETE2_SEPARATOR",grid:0};this.GXValidFnc[26]={fld:"GROUPDATA",grid:0};this.GXValidFnc[27]={fld:"TABLE1",grid:0};this.GXValidFnc[33]={fld:"TABLE2",grid:0};
this.GXValidFnc[36]={fld:"TEXTBLOCKPRODUCTID",format:0,grid:0};this.GXValidFnc[38]={lvl:0,type:"int",len:6,dec:0,sign:false,pic:"ZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Productid,isvalid:null,rgrid:[],fld:"PRODUCTID",gxz:"Z10ProductId",gxold:"O10ProductId",gxvar:"A10ProductId",ucs:[],op:[53,48,43],ip:[53,48,43,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A10ProductId=gx.num.intval(a)},v2z:function(a){gx.O.Z10ProductId=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("PRODUCTID",gx.O.A10ProductId,0)
},c2v:function(){gx.O.A10ProductId=this.val()},val:function(){return gx.fn.getIntegerValue("PRODUCTID",",")},nac:function(){return false}};this.GXValidFnc[41]={fld:"TEXTBLOCKPRODUCTDESCRIPTION",format:0,grid:0};this.GXValidFnc[43]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"PRODUCTDESCRIPTION",gxz:"Z11ProductDescription",gxold:"O11ProductDescription",gxvar:"A11ProductDescription",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A11ProductDescription=a
},v2z:function(a){gx.O.Z11ProductDescription=a},v2c:function(){gx.fn.setControlValue("PRODUCTDESCRIPTION",gx.O.A11ProductDescription,0)},c2v:function(){gx.O.A11ProductDescription=this.val()},val:function(){return gx.fn.getControlValue("PRODUCTDESCRIPTION")},nac:function(){return false}};this.GXValidFnc[46]={fld:"TEXTBLOCKPRODUCTSTOCK",format:0,grid:0};this.GXValidFnc[48]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Productstock,isvalid:null,rgrid:[],fld:"PRODUCTSTOCK",gxz:"Z12ProductStock",gxold:"O12ProductStock",gxvar:"A12ProductStock",ucs:[],op:[48],ip:[48],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A12ProductStock=gx.num.intval(a)
},v2z:function(a){gx.O.Z12ProductStock=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("PRODUCTSTOCK",gx.O.A12ProductStock,0)},c2v:function(){gx.O.A12ProductStock=this.val()},val:function(){return gx.fn.getIntegerValue("PRODUCTSTOCK",",")},nac:function(){return(this.Gx_mode=="UPD")}};this.GXValidFnc[51]={fld:"TEXTBLOCKPRODUCTPRICE",format:0,grid:0};this.GXValidFnc[53]={lvl:0,type:"decimal",len:9,dec:2,sign:false,pic:"ZZZZZ9.99",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PRODUCTPRICE",gxz:"Z13ProductPrice",gxold:"O13ProductPrice",gxvar:"A13ProductPrice",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A13ProductPrice=gx.fn.toDecimalValue(a,",",".")
},v2z:function(a){gx.O.Z13ProductPrice=gx.fn.toDecimalValue(a,",",".")},v2c:function(){gx.fn.setDecimalValue("PRODUCTPRICE",gx.O.A13ProductPrice,2,".")},c2v:function(){gx.O.A13ProductPrice=this.val()},val:function(){return gx.fn.getDecimalValue("PRODUCTPRICE",",",".")},nac:function(){return false}};this.A10ProductId=0;this.Z10ProductId=0;this.O10ProductId=0;this.A11ProductDescription="";this.Z11ProductDescription="";this.O11ProductDescription="";this.A12ProductStock=0;this.Z12ProductStock=0;this.O12ProductStock=0;
this.A13ProductPrice=0;this.Z13ProductPrice=0;this.O13ProductPrice=0;this.ServerEvents=["e11033_client","e12033_client"];this.EnterCtrl=["BTN_ENTER"];this.VarControlMap.Gx_mode={id:"vMODE",grid:0,type:"char"};this.SetStandaloneVars()}product.prototype=new gx.GxObject;gx.setParentObj(new product());