gx.evt.autoSkip=false;function appmasterpage(){this.ServerClass="AppMasterPage";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.IsMasterPage=true;this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){};this.e14012_client=function(){this.executeServerEvent("ENTER_MPAGE",true)};this.e15012_client=function(){this.executeServerEvent("CANCEL_MPAGE",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,5,8,11,15,17,18,19,22,24,26,28,30,32,39,46,49,52,55,58,59,62];this.GXLastCtrlId=62;
this.GXValidFnc[2]={fld:"TABLE4",grid:0};this.GXValidFnc[5]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={fld:"BTN_TOPL",grid:0};this.GXValidFnc[11]={fld:"BTN_TOPR",grid:0};this.GXValidFnc[15]={fld:"TEXTBLOCKHEADER1",format:0,grid:0};this.GXValidFnc[17]={fld:"IMAGE1",grid:0};this.GXValidFnc[18]={fld:"IMAGE2",grid:0};this.GXValidFnc[19]={fld:"TABLE2",grid:0};this.GXValidFnc[22]={fld:"HOME",format:0,grid:0};this.GXValidFnc[24]={fld:"FIRSTTEXT",format:0,grid:0};this.GXValidFnc[26]={fld:"SECONDTEXT",format:0,grid:0};
this.GXValidFnc[28]={fld:"THIRDTEXT",format:0,grid:0};this.GXValidFnc[30]={fld:"FOURTHTEXT",format:0,grid:0};this.GXValidFnc[32]={fld:"FIFTHTEXT",format:0,grid:0};this.GXValidFnc[39]={fld:"TABLE5",grid:0};this.GXValidFnc[46]={fld:"TABLE6",grid:0};this.GXValidFnc[49]={fld:"TABLE7",grid:0};this.GXValidFnc[52]={fld:"TABLE8",grid:0};this.GXValidFnc[55]={fld:"TABLE3",grid:0};this.GXValidFnc[58]={fld:"TEXTBLOCK1",format:0,grid:0};this.GXValidFnc[59]={fld:"TABLE9",grid:0};this.GXValidFnc[62]={fld:"TABLE10",grid:0};
this.ServerEvents=["e14012_client","e15012_client"];this.SetStandaloneVars();this.setComponent({id:"WCRECENTLINKS",GXClass:null,Prefix:"MPW0035",lvl:1})}appmasterpage.prototype=new gx.GxObject;gx.setMasterPage(new appmasterpage());