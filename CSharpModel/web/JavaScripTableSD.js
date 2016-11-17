gx.grid.impl=function(b){this.basePath=gx.basePath;this.imgsDir=gx.staticDirectory;this.columns=[];this.rows=[];this.fixedValues=[];this.width="";this.align="";this.border="0";this.padding="1";this.spacing="0";this.sortColumn=-1;this.ascSort=true;this.usePaging=true;this.eof=1;this.firstRecordOnPage=0;this.pageSize=9999;this.currentPage=1;this.gxLvl=0;this.gxGridName="";this.gxGridObject=null;this.gxBuffer=new gx.text.stringBuffer();this.gxParentRowId="";this.tableClass="";this.headerClass="";this.footerClass="";this.editControlClass="";this.navigationClass="";this.navigationLinkClass="";this.highlightedNavigationLinkClass="";this.columnHeaderClass="";this.columnHeaderTextClass="";this.oddRowClass="";this.oddRowCellClass="";this.evenRowClass="";this.evenRowCellClass="";if(typeof(Image)!="undefined"){this.ascLabel=new Image();this.descLabel=new Image()}else{this.ascLabel=null;this.descLabel=null}this.id=b;this.container=null;this.setContainerDelayed=function(c){this.container=c};this.addColumn=function(d){if(d.isGxRemove()){d.visible=false}var c=this.columns.length;d.index=c;d.table=this;this.columns[c]=d;return d};this.getColumnByIndex=function(c){return this.columns[c]};this.addRow=function(d,c){d.table=this;if(d==null){return}this.rows[this.rows.length]=d;if(gx.lang.booleanValue(c)){this.render()}return d};this.getColumnByHtmlName=function(d){for(var c=0;c<this.columns.length;c++){if((this.columns[c].htmlName==d)||(this.gxCmpContext+this.columns[c].htmlName==d)){return this.columns[c]}}return null};this.getColumnByGxId=function(d){for(var c=0;c<this.columns.length;c++){if(this.columns[c].gxId==d){return this.columns[c]}}return null};this.getColumnForVar=function(e){for(var c=0;c<this.columns.length;c++){var d=this.parentGxObject.getValidStructFld(this.columns[c].htmlName);if(d){if(d.gxvar==e){return this.columns[c]}}}return null},this.getRowById=function(f){var d=null;var c=this.rows.length;for(var e=0;(d==null)&&(e<c);e++){row=this.rows[e];if(row.id==f){d=row}}return d};this.getRowByGxId=function(f){var d=null;var c=this.rows.length;for(var e=0;(d==null)&&(e<c);e++){row=this.rows[e];if(row.gxId==f){d=row}}return d};this.setSort=function(c,d){if(c==this.sortColumn){if(d==null){this.ascSort=!this.ascSort}else{this.ascSort=gx.lang.booleanValue(d)}}else{this.sortColumn=c;this.ascSort=(d==null?true:gx.lang.booleanValue(d))}this.rows.sort(this.sort);this.ownerGrid.refreshGrid()};this.getControlName=function(d,c){return this.gxCmpContext+c.htmlName+"_"+d.gxId};this.getControlId=function(d,c){return this.getControlName(d,c)};this.getRowCount=function(){return this.rows.length};this.getMaxPage=function(){return Math.ceil(this.getRowCount()/this.pageSize)};this.isGxTrn=function(){return this.parentGxObject.isTransaction()};this.gridObject=function(){return"gx.fn.gridObj('"+this.gxCmpContext+"','"+this.gxGridName+"',"+this.gxIsMasterPageGrid.toString()+")"};this.deleteImgId=function(c){return this.gxCmpContext+"delete"+this.gxGridName+"_"+c};this.showDeleteImage=function(e){if(this.ownerGrid.deleteMethod==gx.grid.deleteMethods.images){var d=this.isGxTrn();
if(d){var c=gx.dom.el(this.deleteImgId(e));if(c){if(!gx.fn.isVisible(c)){c.style.display="inline";if(c.parentNode.nodeName=="A"){c.parentNode.style.display="inline"}}}}}};this.appendDeleteHeader=function(e,d){if(!this.gxIsFreestyle&&(this.ownerGrid.deleteMethod!=gx.grid.deleteMethods.none)){var f=this.isGxTrn();var c=false;if(this.ownerGrid.deleteMethod==gx.grid.deleteMethods.menu){if(d==gx.grid.deletePositions.left){c=true}else{return}}else{if(gx.grid.deletePosition==d){c=true}}if(f&&c){var g="&nbsp;";if(this.ownerGrid.deleteMethod==gx.grid.deleteMethods.images){g=gx.grid.deleteTitle}e.append('<th class="'+this.columnHeaderClass+'">'+g+"</th>")}}};this.appendDeleteImage=function(g,r,i){if(this.ownerGrid.deleteMethod!=gx.grid.deleteMethods.none){var h=this.isGxTrn();if(h){var m=false;var c=false;if((this.parentGxObject.Gx_mode!="DSP")&&(this.parentGxObject.Gx_mode!="DLT")){m=r.gxDeleted();c=(r.gxIsMod()||r.gxExists())}var d=this.deleteImgId(r.gxId);var f=false;if(this.ownerGrid.deleteMethod==gx.grid.deleteMethods.menu){if(i==gx.grid.deletePositions.left){f=true}else{return}}else{if(!this.gxIsFreestyle&&(gx.grid.deletePosition==i)){f=true}else{if(this.gxIsFreestyle){var n=gx.grid.deletePositionFree;if(i==gx.grid.deletePositions.left){f=((n==gx.grid.deletePositions.topL)||(n==gx.grid.deletePositions.bottomL))}else{if(i==gx.grid.deletePositions.right){f=((n==gx.grid.deletePositions.topR)||(n==gx.grid.deletePositions.bottomR))}}i=n}}}if(f){var e='<td style="text-align:'+this.deleteImageAlign(i)+";vertical-align:"+this.deleteVerticalAlign(i)+'">';var l="</td>";var p="";var j=false;if(m&&(this.ownerGrid.deleteMethod==gx.grid.deleteMethods.images)){p=gx.grid.undeleteImage}else{if(c&&(this.ownerGrid.deleteMethod==gx.grid.deleteMethods.images)){p=gx.grid.deleteImage}else{if(m&&(this.ownerGrid.deleteMethod==gx.grid.deleteMethods.menu)){p=gx.grid.deleteImage}else{p=gx.grid.deleteImage;j=true}}}var q="";g.append(e);if(this.ownerGrid.deleteMethod==gx.grid.deleteMethods.images){var o=gx.fn.firstGridControl(this.ownerGrid.gridId);q=gx.grid.deleteTooltip;g.append('<a gxfocusable="1" href="javascript:'+this.gridObject()+".setRowDeleted('"+r.gxId+"');\"");g.append(' onfocus="gx.evt.onfocus(this,'+o+",'"+this.ownerGrid.gxComponentContext+"',"+this.ownerGrid.isMasterPageGrid+",'"+r.gxId+"',"+this.ownerGrid.gridId+')"');var k="";if(j){k+="display:none;"}if(k!=""){g.append(' style="'+k+'"')}g.append(">")}g.append('<img id="'+d+'" src="'+p+'"');if(q!=""){g.append(' title="'+q+'"')}g.append(' style="border-style: none;');if(j){g.append("display:none;")}g.append('"');g.append("/>");if(this.ownerGrid.deleteMethod==gx.grid.deleteMethods.images){g.append("</a>")}g.append(l)}}}};this.deleteVerticalAlign=function(c){if(this.gxIsFreestyle){if(this.ownerGrid.deleteMethod==gx.grid.deleteMethods.menu){return"middle"}var d="top";if((c==gx.grid.deletePositions.bottomL)||(c==gx.grid.deletePositions.bottomR)){d="bottom"}return d}return"middle"};this.deleteImageAlign=function(c){if(this.gxIsFreestyle){if(this.ownerGrid.deleteMethod==gx.grid.deleteMethods.menu){return"left"
}var d="right";if((c==gx.grid.deletePositions.bottomL)||(c==gx.grid.deletePositions.topL)){d="left"}return d}return"center"};this.render=function(y,S,Q,t){if(y!=false){y=true}var B=this.isGxTrn();var q=this.gxIsFreestyle&&(this.gxGridCols>1);var K="cursor:"+(document.createTextRange?"hand":"pointer")+";";var E=new gx.text.stringBuffer();var f=this.columns;var G=G=f.length;if(!this.gxIsFreestyle&&B){G++}var m=[];var A=[];var w,F,D;if(this.pageSize!=0){var D=this.getMaxPage();if(this.currentPage<=0){this.currentPage=1}else{if(this.currentPage>D){this.currentPage=D}}w=Math.max(this.pageSize*(this.currentPage-1),0);F=Math.min(w+this.pageSize,this.rows.length)}else{w=0;F=this.rows.length}this.tableClass=this.gxCssClass;this.evenRowClass=this.gxEvenLinesClass;this.oddRowClass=this.gxOddLlinesClass;this.headerClass=this.gxTitleClass;this.columnHeaderClass=this.headerClass;this.columnHeaderTextClass=this.headerClass;this.evenRowCellClass=this.evenRowClass;this.oddRowCellClass=this.oddRowClass;var R="";if(this.gxHtmlTags.indexOf("class=")==-1){R=' class="'+this.gxCssClass+'"'}var H="";if(!gx.lang.emptyObject(this.gxBackground)){H+=";background-image:url('"+gx.util.resourceUrl(this.gxBackground,true)+"');"}if(!gx.lang.emptyObject(this.gxBorderWidth)){H+=";border: solid "+this.gxBorderWidth+"px "}if(!gx.lang.emptyObject(this.gxBordercolor)){H+=this.gxBordercolor+";"}else{H+=";"}if(this.ownerGrid.width>0){H+="width:"+this.ownerGrid.width+this.ownerGrid.widthUnit+";"}if(this.gxAllowCollapsing){E.append('<table><tr valign="top"><td>'),E.append('<img style="cursor:pointer;" src="');if(this.gxCollapsed){H="display:none;";E.append(gx.util.resourceUrl(gx.basePath+this.imgsDir+"expand.gif",true))}else{E.append(gx.util.resourceUrl(gx.basePath+this.imgsDir+"collapse.gif",true))}E.append('" onclick="'+this.gridObject()+'.expandCollapse(this, event);"></td><td width="100%">')}E.append("<table "+R+' id="'+this.gxCmpContext+this.gxGridObject+'Tbl" ');if(!gx.lang.emptyObject(this.gxToolTipText)){E.append('title="'+this.gxToolTipText+'" ')}var h=/style="([^"]*)"/ig;var J=h.exec(this.gxHtmlTags);var P="";if(J&&J.length>1){P=J[1]}P+=H;E.append('style="');E.append(P);E.append('" '+this.gxHtmlTags.replace(h,"")+">");if(!gx.lang.emptyObject(this.headerText)){E.append('<tr><td colspan="'+G+'" class="'+this.headerClass+'">'+this.headerText+"</td></tr>")}var x=f.length;if(!this.gxIsFreestyle){E.append("<tr>");this.appendDeleteHeader(E,gx.grid.deletePositions.left);var e=gx.util.resourceUrl(gx.basePath+gx.staticDirectory+"asc.gif",true);var L=gx.util.resourceUrl(gx.basePath+gx.staticDirectory+"desc.gif",true);var T=0;for(var Y=0;Y<x;Y++){var U=f[Y];E.append('<th nowrap="nowrap" class="'+this.columnHeaderClass+'"');var v="";if(!gx.lang.gxBoolean(U.visible)){v+="display:none;"}if(U.width!=""){if(U.gxWidthUnit==""){U.gxWidthUnit="px"}v+="width:"+U.width+U.gxWidthUnit+";"}if(U.align!=""){v+="text-align:"+U.align+";"}if(!gx.lang.emptyObject(this.gxTitleBackColor)&&(this.gxTitleBackstyle==gx.grid.styles.header||this.gxTitleBackstyle==gx.grid.styles.report)){v+="background-color:"+this.gxTitleBackColor+";";
this.gxRealTitleBackColor=this.gxTitleBackColor}if(!gx.lang.emptyObject(this.gxBackColor)&&(this.gxTitleBackstyle==gx.grid.styles.uniform)){v+="background-color:"+this.gxBackColor+";";this.gxRealTitleBackColor=this.gxBackColor}if(!gx.lang.emptyObject(this.gxTitleForeColor)){v+="color:"+this.gxTitleForeColor+";"}if(!gx.lang.emptyObject(this.gxTitleFont)){v+=this.gxTitleFont}E.append(' style="'+v);E.append(' colindex="'+T+'"');E.append(">");T++;if(gx.lang.emptyObject(gx.text.trim(U.title))){E.append("&nbsp;")}else{E.append("<span");if(U.gxTooltip!=undefined&&U.gxTooltip!=""){E.append(' title="'+U.gxTooltip+'"')}var v="";if(U.sortable){v=K;E.append(' onclick="'+this.gridObject()+".grid.setSort("+U.index+');" onMouseOver="window.status=\''+this.sortMessage+"';return true;\" onMouseOut=\"window.status='';return true;\"")}E.append('">');E.append(U.title);if(this.ascLabel!=null&&this.descLabel!=null){this.ascLabel.src=e;this.descLabel.src=L;if(U.sortable&&this.sortColumn==U.index){E.append("&nbsp;"+this.handleLabel(((this.ascSort)?this.ascLabel:this.descLabel),m))}}E.append("</span>")}E.append("</th>")}this.appendDeleteHeader(E,gx.grid.deletePositions.right);E.append("</tr>")}var N=true;for(var Y=w;Y<F;Y++){var z=this.rows[Y];var d=z.gxDeleted();N=!N;var M=(N?this.evenRowClass:this.oddRowClass)+(d?" RowDeleted":"");if(this.gxIsFreestyle&&!(this.gxTitleBackstyle==gx.grid.styles.report||this.gxTitleBackstyle==gx.grid.styles.uniform)){M=this.tableClass}var n=new gx.text.stringBuffer();var O="tr";var s=q&&this.gxIsFreestyle&&(((Y>0)&&(Y%this.gxGridCols==0))||((Y==0)&&(this.gxGridCols>0)));if(s){if(Y>0){E.append("</tr>")}E.append("<tr>")}if(this.gxIsFreestyle){O="td"}var p="";if(this.gxTitleBackstyle==gx.grid.styles.report){p=(N)?this.gxLinesBackcolorEven:this.gxLinesBackcolorOdd}if(this.gxTitleBackstyle==gx.grid.styles.header){p=this.gxLinesBackcolorOdd}if(this.gxTitleBackstyle==gx.grid.styles.uniform){p=this.gxBackColor}if(!this.gxIsFreestyle||(this.gxIsFreestyle&&q)){n.append("<"+O+" id='"+this.gxCmpContext+this.gxGridObject+"Row_"+z.gxId+"'");if(this.gxIsFreestyle&&q){n.append(' gxrow="'+z.gxId.toString()+'"vAlign="'+this.columns[1].gxControl.verticalAlign+'"')}else{n.append(' gxrow="'+z.gxId.toString()+'"')}if(B&&(this.ownerGrid.deleteMethod==gx.grid.deleteMethods.menu)){n.append(' oncontextmenu="'+this.gridObject()+'.showContextMenu(this, event);"')}if(this.gxAllowSelection&&!this.gxIsFreestyle){n.append(' onmousedown="'+this.gridObject()+".grid.setRowSelected(this, '"+z.gxId.toString()+"', true);\"")}if(B){n.append(' onkeydown="'+this.gridObject()+'.rowKeyPressed(event);"')}if(!this.gxIsFreestyle){n.append(' class="'+M+'"')}if(this.gxAllowHovering&&!z.selected&&!this.gxIsFreestyle){n.append(' onmouseover="'+this.gridObject()+".grid.startRowHover(this, "+z.id+');" onmouseout="'+this.gridObject()+".grid.endRowHover(this, "+z.id+');"')}var C="";if(p){C="background-color:"+p+";"}if(!gx.lang.emptyObject(this.gxLinesFont)){C+=this.gxLinesFont}if(C!=""){n.append(' style="'+C+'" ')
}n.append(">");E.append(n.toString())}if(this.gxIsFreestyle){if(q){E.append("<table width='100%' cellspacing='0' cellpadding='0'");E.append("><tbody>")}var o=(N?this.evenRowCellClass:this.oddRowCellClass);var W=this.gxBuffer.toString();E.append(W)}if(!this.gxIsFreestyle){this.appendDeleteImage(E,z,gx.grid.deletePositions.left)}for(var X=0;X<x;X++){var U=f[X];var l=gx.lang.gxBoolean(U.visible);var V=z.gxProps[U.index];var c=z.values[U.index];var g=U.gxControl;if(this.gxIsFreestyle&&g.type==gx.html.controls.types.row){if(U.index==0){g.isFreestyleRow=true}}g.grid=this.ownerGrid;g.row=z;g.gridId=this.gxId;g.gridRow=z.gxId;if(!Q){g.setProperties.apply(g,V)}else{g.value=c;g.id=U.htmlName+"_"+g.gridRow}if(d){g.rtEnabled=true;g.enabled=false}if(y){delete gx.usrPtys[g.id]}else{if(gx.usrPtys[g.id]!==undefined){var I;for(I in gx.usrPtys[g.id]){if(I=="enabled"){g.rtEnabled=true}g[I]=gx.usrPtys[g.id][I]}}}if(V.Value){g.value=V.Value}if(V.FormattedValue){g.formattedValue=V.FormattedValue}if(V.Values){g.possibleValues=V.Values.v}if(this.gxIsFreestyle&&g.type==gx.html.controls.types.row){if(U.index==0){g.id=this.gxCmpContext+this.gxGridObject+"Row_"+z.gxId;if(B&&(this.ownerGrid.deleteMethod==gx.grid.deleteMethods.menu)){g.oncontextmenu=this.gridObject()+".showContextMenu(this, event);"}if(p){g.style+="background-color:"+p+";"}}}if(!this.gxIsFreestyle){E.append('<td valign="'+U.valign+'"');var u="";if(!l){u+="display:none;"}if(U.width!=""){if(U.gxWidthUnit==""){U.gxWidthUnit="px"}u+="width:"+U.width+U.gxWidthUnit+";"}if(U.align!=""){u+="text-align:"+U.align+";"}if(g.style){u+=g.style}if(u!=""){E.append(' style="'+u+'" ')}E.append(">")}E.append(g.getHtml());if(this.gxIsFreestyle&&g.type==gx.html.controls.types.row&&U.index==0){this.appendDeleteImage(E,z,gx.grid.deletePositions.left)}g.persistValue();if(!this.gxIsFreestyle){E.append("</td>")}if(this.gxIsFreestyle){if(U.index==this.columns.length-1){this.appendDeleteImage(E,z,gx.grid.deletePositions.right)}var W=U.buffer.toString();E.append(W)}}if(this.gxIsFreestyle&&q){if(q){E.append("</tbody></table></td>")}}else{this.appendDeleteImage(E,z,gx.grid.deletePositions.right)}}if(this.gxIsFreestyle&&(this.gxGridCols>0)&&q){E.append("</tr>")}var r="";var k=(B||this.hasPagingButtons());if(k){r=this.buildNavigation(G);E.append(r)}if(!gx.lang.emptyObject(this.footerText)){E.append('<tr><td colspan="'+G+'" class="'+this.footerClass+'">'+this.footerText+"</td></tr>")}E.append("</table>");if(this.gxAllowCollapsing){E.append("</td></tr></table>")}this.container.innerHTML=E.toString();E.clear();E=null;t()};this.changePage=function(d){var c=this.getMaxPage();d=parseInt(d);if(d<=0){d=1}else{if(d>c){d=c}}this.currentPage=d;this.render()};this.setRowSelected=function(e,d,f){var c=function(){if(e.gxOriginalBackcolor==undefined){e.gxOriginalBackcolor=e.style.backgroundColor}gx.dom.forEachChild(e,this,function(i){if(i.gxOriginalBackcolor==undefined){i.gxOriginalBackcolor=i.style.backgroundColor}});this.instanciateSelectionVars(d);var l=false;
var g=this.rows.length;for(var j=0;j<g;j++){var k=this.rows[j];k.selected=(k.gxId==d);if(!k.selected){var h=gx.dom.el(this.gxCmpContext+this.gxGridObject+"Row_"+k.gxId);if((h!=null)&&(h.gxSBackcolor!=undefined)){h.style.backgroundColor=h.gxSBackcolor;if(gx.util.browser.isIE()){gx.dom.forEachChild(h,this,function(i){if((i!=null)&&(i.gxSBackcolor!=undefined)){i.style.backgroundColor=i.gxSBackcolor}})}}}else{e.gxSBackcolor=(e.gxOriginalBackcolor!=undefined)?e.gxOriginalBackcolor:e.style.backgroundColor;e.style.backgroundColor=this.gxSelectionColor.Html;this.instanciateSelectedRow(k);if(gx.util.browser.isIE()){gx.dom.forEachChild(e,this,function(i){i.gxSBackcolor=(i.gxOriginalBackcolor!=undefined)?i.gxOriginalBackcolor:i.style.backgroundColor;i.style.backgroundColor=this.gxSelectionColor.Html})}}l=!l}};if(f){setTimeout(c.closure(this),100)}else{c.call(this)}};this.instanciateSelectionVars=function(c){gx.setGxO(this.parentGxObject.CmpContext,this.parentGxObject.IsMasterPage);gx.fn.setCurrentGridRow(this.gxId,c);gx.fn.setHidden(this.gxCmpContext+this.gxGridName.toUpperCase()+"_ROW",c.substring(0,4))};this.instanciateSelectedRow=function(c){this.setSelectedRowVars(c);if(this.gxOnLineActivate&&!this.ownerGrid.isLoading){this.parentGxObject[this.gxOnLineActivate].call(this.parentGxObject,c.gxId)}};this.setSelectedRowVars=function(g){var f=this.parentGxObject;var c=this.columns.length;for(var d=0;d<c;d++){var e=this.columns[d];var j=f.GXValidFnc[e.gxId];if(j!=null){var h=g.values[d];if(this.ownerGrid.isUsercontrol){h=this.properties[g.id][e.index].value}if(j.v2v){j.v2v(h)}}}};this.startRowHover=function(c,d){if(c.gxOriginalBackcolor==undefined){c.gxOriginalBackcolor=c.style.backgroundColor}gx.dom.forEachChild(c,this,function(f){if(f.gxOriginalBackcolor==undefined){f.gxOriginalBackcolor=f.style.backgroundColor}});var e=this.getRowById(d);if(this.gxAllowHovering&&this.gxHoverColor&&!e.selected){c.gxHBackcolor=c.style.backgroundColor;c.style.backgroundColor=this.gxHoverColor.Html;if(gx.util.browser.isIE()){gx.dom.forEachChild(c,this,function(f){f.gxHBackcolor=f.style.backgroundColor;f.style.backgroundColor=this.gxHoverColor.Html})}}};this.endRowHover=function(c,d){var e=this.getRowById(d);if(this.gxAllowHovering&&!e.selected){if(c.gxHBackcolor!=undefined){c.style.backgroundColor=c.gxHBackcolor;if(gx.util.browser.isIE()){gx.dom.forEachChild(c,this,function(f){if(f.gxHBackcolor!=undefined){f.style.backgroundColor=f.gxHBackcolor}})}}}};this.hasPagingButtons=function(){return(this.usePaging&&(!this.isFirstPage()||!this.isLastPage()))};this.buildNavigation=function(f){var c="cursor:"+(document.createTextRange?"hand":"pointer")+";";var g=new gx.text.stringBuffer();var l=this.getRowCount();var e=f;this.navigationClass=this.gxTitleClass;if(this.gxIsFreestyle&&this.gxGridCols>1){e=this.gxGridCols}if(gx.lang.emptyObject(this.gxRealTitleBackColor)){g.append('<tr><td colspan="'+e+'" class="'+this.navigationClass+'" style="text-align: center;">')}else{g.append('<tr><td colspan="'+e+'" class="'+this.navigationClass+'" style="text-align: center;background-color:'+this.gxRealTitleBackColor+';">')
}var k=this.navigationLinkClass;var h=this.highlightedNavigationLinkClass;function n(u,o,p,t,q){var s=(t!=undefined)?'id="'+t+'"':"";var r=gx.util.browser.isFirefox()?"onkeypress":"onkeydown";return"<a class='gx_newrow' type='gxlink' style='text-decoration:none;' tabindex='0' onfocus=\""+q+'" onblur="this.style.textDecoration = \'none\';"><span '+s+' style="'+c+'" class="'+k+'" onclick="'+o+'" onMouseOver="this.className=\''+h+"';window.status='"+p+"';return true;\" onMouseOut=\"this.className='"+k+"';window.status='';return true;\">"+u+"</span></a>"}var d=gx.util.browser.isIE();var m='style="padding-left:20px;padding-bottom:5px;"';function j(p,o){return'<span class="'+p+'" onclick="'+o+'" '+m+">&nbsp;&nbsp;</span>"}if(l>0){if(this.usePaging){if(!d){g.append("<div>")}if(this.currentPage<=0){this.currentPage=1}var i=this.getMaxPage();if(!this.isFirstPage()){g.append(j("PagingButtonsFirst",this.getPaginEvent("FIRST")));g.append(j("PagingButtonsPrevious",this.getPaginEvent("PREV")))}if(!this.isLastPage()){g.append(j("PagingButtonsNext",this.getPaginEvent("NEXT")));g.append(j("PagingButtonsLast",this.getPaginEvent("LAST")))}if(!d){g.append("</div>&nbsp;")}}}if(this.isGxTrn()&&!this.gxHasAddlines&&(this.parentGxObject.Gx_mode!="DSP")){g.append(n("["+this.gxNewRowText+"]",this.gridObject()+".getNewRows(1,event);",this.gxNewRowText,this.gxGridObject+"_NewRow",this.gridObject()+".gxNewRowFocused(this);"))}g.append("</td></tr>");return g.toString()};this.isLastPage=function(){var c=this.eof;return(c!="0")};this.isFirstPage=function(){var c=gx.lang.emptyObject(this.firstRecordOnPage)?"0":this.firstRecordOnPage;return(c=="0")};this.getPaginEvent=function(c){var d=this.gxGridName.toUpperCase()+"PAGING";return"javascript:gx.fn.setHidden('"+this.gxCmpContext+d+"','"+c+"');gx.evt.execEvt('"+this.gxCmpContext+"E"+d+".', gx.evt.dummyCtrl);"};this.getWebImageTag=function(c){return'<img border="0" src="/'+this.basePath+this.imgsDir+c.toString()+'"/>'};var a=0;this.handleLabel=function(d,c){if(d.src){var e="img"+a;a++;return"<img name='"+e+"' border='0' src='"+d.src+"'>"}else{return d}};this.sort=function(p,o){if(p.table.isGxTrn()){if((!p.gxExists()&&!o.gxExists())&&(!p.gxIsMod()&&!o.gxIsMod())){return 0}else{if((!p.gxExists()&&o.gxExists())||(!p.gxIsMod()&&o.gxIsMod())){return 1}else{if((p.gxExists()&&!o.gxExists())||(p.gxIsMod()&&!o.gxIsMod())){return -1}}}}var g=p.table;var d=g.getColumnByIndex(g.sortColumn);var k=d.type;var n,m;values1=p.values[g.sortColumn];m=o.values[g.sortColumn];if(!gx.lang.instanceOf(values1,Array)){values1=[values1]}if(!gx.lang.instanceOf(m,Array)){m=[m]}var l;switch(d.type){case gx.types.numeric:l=function(i){i=gx.num.parseFloat(i,gx.thousandSeparator,gx.decimalPoint);if(isNaN(i)){i=0}return i};break;case gx.types.date:case gx.types.dateTime:l=function(i){try{i=new gx.date.gxdate(i).Value}catch(q){gx.dbg.logEx(q,"JSTable.js","sort")}return i.valueOf()};break;case gx.types.bool:l=function(i){return gx.lang.booleanValue(i)?1:0};break;case gx.types.character:default:l=function(i){return String(i).replace(/\<[^\>]*\>/g,"").toUpperCase()
};break}var c=Math.max(values1.length,m.length);var j=0;for(var e=0;(j==0)&&(e<c);e++){var h=values1[e];if(h==null){j=-1}var f=m[e];if(f==null){j=1}if(j==0){h=l(h);f=l(f);j=(h==f)?0:(h>f)?1:-1}if(j!=0){j*=(g.ascSort?1:-1)}}return j}};gx.grid.column=function(d,c,b,e,a){this.table=null;this.index=-1;this.title=d||"";this.type=(typeof(c)!="undefined")?c:gx.types.character;this.width=b||"";this.align=e||"left";this.valign=a||"middle";this.htmlName=null;this.visible=true;this.enabled=true;this.sortable=true;this.colspan=1;this.rowspan=1;this.gxId=-1;this.gxAttId=-1;this.gxAttName="";this.gxWidthUnit="";this.gxChecked=undefined;this.gxUnChecked=undefined;this.buffer=new gx.text.stringBuffer();this.isGxRemove=function(){if(this.gxAttName){return(this.gxAttName.indexOf("GxRemove")!=-1)||(this.gxAttName.indexOf("nRcdDeleted")!=-1)}else{return false}}};gx.grid.row=function(d,a,c,b){this.table=null;this.id=d;this.gxParentRowId=b||"";this.gxId=c+this.gxParentRowId;this.gxCmpContext="";this.values=[];this.selected=false;this.gxLvl=0;this.gxProps=a.Props||[];this.gxRenderProps=a.RenderProps||[];this.gxGrids=[];this.gxKeyValues=[];this.gxExists=function(){var e=gx.fn.getHidden(this.gxCmpContext+"nRcdExists_"+this.gxLvl+"_"+this.gxId);if(e!=null){return(e!=0)}return false};this.gxIsMod=function(){var e=gx.fn.getHidden(this.gxCmpContext+"nIsMod_"+this.gxLvl+"_"+this.gxId);if(e!=null){return(e!=0)}return false};this.gxDeleted=function(){var e=gx.fn.getHidden(this.gxCmpContext+"nRcdDeleted_"+this.gxLvl+"_"+this.gxId);if(e!=null){return(e!=0)}return false};this.setDeleted=function(e){var f=(e?1:0);gx.fn.setHidden(this.gxCmpContext+"nRcdDeleted_"+this.gxLvl+"_"+this.gxId,f)}};