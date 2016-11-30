/*
               File: clientesEnRango
        Description: clientes En Rango
             Author: GeneXus C# Generator version 10_1_6-46473
       Generated on: 11/30/2016 15:26:2.30
       Program type: Callable routine
          Main DBMS: sqlserver
*/
gx.evt.autoSkip = false;
function clientesenrango() {
   this.ServerClass =  "clientesEnRango" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = false;
   this.autoRefresh = true;
   this.SetStandaloneVars=function()
   {
   };
   this.e12092_client=function()
   {
      this.executeServerEvent("ENTER", true);
   };
   this.e13092_client=function()
   {
      this.executeServerEvent("CANCEL", true);
   };
   this.GXValidFnc = [];
   this.GXLastCtrlId =0;
   this.ServerEvents = ["e12092_client" ,"e13092_client"];
   this.SetStandaloneVars( );
}
clientesenrango.prototype = new gx.GxObject;
gx.setParentObj(new clientesenrango());
