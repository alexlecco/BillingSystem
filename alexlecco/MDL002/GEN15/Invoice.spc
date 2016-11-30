spec_i([ trn,4,'Invoice','Invoice',[],eng,'10_1_6-46473' ]).
 
struct_i(4,0,[],[]).
struct_i(5,4,[ 14,20,9,16,'GxBScreen',7 ],[ 20,9,16,7 ]).
 
level_i(5,[ 5,[ [ 5,many ],[ 3,one ] ],[ 14,17 ],[],[],[],[ 14,17 ],'IINVOICEDETAIL',[ 5,[ [ [],14,14 ] ] ],[] ]).
level_i(4,[ 4,[ [ 4,many ],[ 2,one ],[ 1,one ],[ 2000,one ],[ 2001,one ] ],[ 14 ],[],[],[],[ 14 ],'IINVOICE',[ 4,[] ],[] ]).
 
tw_i(5,[ [ 3,[ [ 5,10,10 ] ] ] ]).
tw_i(4,[ [ 2,[ [ 4,3,3 ] ] ],[ 1,[ [ 2,1,1 ] ] ],[ 2000,[ [ 4,oe([ t(14,2) ]),14 ] ] ],[ 2001,[ [ 4,oe([ t(14,2) ]),14 ] ] ] ]).
 
lwi_i(5,[ [] ]).
lwi_i(4,[ [] ]).
 
 
 
 
ta_i(5,[ [ [ 5,14 ],[ 5,17 ],[ 3,12 ],[ 3,11 ],[ 3,13 ],[ 5,18 ],[ 5,10 ] ] ]).
ta_i(4,[ [ [ 4,14 ],[ 2,7 ],[ 4,15 ],[ 2,4 ],[ 1,2 ],[ 4,3 ],[ 2,1 ],[ 2000,se(20,[ [ 2000,20 ] ],[ t('coalesce(',1),t(20,2),t(',',7),t('0',3),t(')',4) ]) ],[ 2001,se(16,[ [ 2001,16 ] ],[ t('coalesce(',1),t(16,2),t(',',7),t('0',3),t(')',4) ]) ] ] ]).
 
las_i(5,[ [ 14,17,20,19,12,9,16,'GxBScreen',10,11,13,18,7 ] ]).
las_i(4,[ [ 14,7,'GxBScreen','Today',9,15,3,4,20,1,2,16 ] ]).
 
lac_i(5,[ [ 17,10,18 ] ]).
lac_i(4,[ [ 14,15,3 ] ]).
 
 
lits_i('Id',5,10).
lits_i('Date',5,10).
lits_i('Customer Id',5,10).
lits_i('Customer Name',5,10).
lits_i('Customer Total Purchases',5,10).
lits_i('Customer Balance',5,10).
lits_i('Country Id',5,10).
lits_i('Detail',5,10).
lits_i('Amount',5,10).
 
cls_i([ 0,0 ],[ 5,63 ]).
 
pos_i(14,[ 0,0,0 ]).
pos_i(15,[ 0,0,0 ]).
pos_i(3,[ 0,0,0 ]).
pos_i(4,[ 0,0,0 ]).
pos_i(7,[ 0,0,0 ]).
pos_i(9,[ 0,0,0 ]).
pos_i(1,[ 0,0,0 ]).
pos_i(17,[ 1,2,0 ]).
pos_i(10,[ 1,2,3 ]).
pos_i(11,[ 1,2,10 ]).
pos_i(13,[ 1,2,41 ]).
pos_i(18,[ 1,2,51 ]).
pos_i(19,[ 1,2,55 ]).
pos_i(16,[ 0,0,0 ]).
 
repeat_i(5,[ 1,2,[],[] ]).
 
default_i(e(15,4,3,[ t('Today',23) ])).
default_i(e('Today',2,2,'''today''')).
 
rule_i(0,datastore(1,'DS_LAST_CHANGE','')).
rule_i(0,datastore(1,'LOCK_RETRY','10')).
rule_i(0,datastore(1,'WAIT_RECORD','0')).
rule_i(0,datastore(1,'SQLSERVER_VERSION','9')).
rule_i(0,datastore(1,'COMMENT_ON','No')).
rule_i(0,datastore(1,'DFT_TMP_TBLSPACE','')).
rule_i(0,datastore(1,'DFT_IDX_TBLSPACE','')).
rule_i(0,datastore(1,'DFT_TBL_TBLSPACE','')).
rule_i(0,datastore(1,'DCL_REF_INT_DB','Yes')).
rule_i(0,datastore(1,'PRIMARY_KEY_TYPE','PK')).
rule_i(0,datastore(1,'CS_SCHEMA','')).
rule_i(0,datastore(1,'SORT_ATTRIBUTES','Yes')).
rule_i(0,datastore(1,'JRN400','QSQJRN')).
rule_i(0,datastore(1,'CREATE_SAVF','Yes')).
rule_i(0,datastore(1,'PGMLIB','')).
rule_i(0,datastore(1,'DTALIB','')).
rule_i(0,datastore(1,'CC_USER_PASS','')).
rule_i(0,datastore(1,'CC_USER_ID','')).
rule_i(0,datastore(1,'CC_SERVER','')).
rule_i(0,datastore(1,'CC_DBNAME','')).
rule_i(0,datastore(1,'RecycleRWMin','30')).
rule_i(0,datastore(1,'RecycleRWType','1')).
rule_i(0,datastore(1,'RecycleRW','-1')).
rule_i(0,datastore(1,'POOL_STARTUP','No')).
rule_i(0,datastore(1,'POOLSIZE_RW','10')).
rule_i(0,datastore(1,'UnlimitedRWPool','-1')).
rule_i(0,datastore(1,'PoolRWEnabled','-1')).
rule_i(0,datastore(1,'CS_RPCPGML','')).
rule_i(0,datastore(1,'JDBC_DATASOURCE','')).
rule_i(0,datastore(1,'USE_JDBC_DATASOURCE','0')).
rule_i(0,datastore(1,'DS_DBMS_ADDINFO','')).
rule_i(0,datastore(1,'USER_PASSWORD','')).
rule_i(0,datastore(1,'USER_ID','')).
rule_i(0,datastore(1,'TRUSTED_CONNECTION','Yes')).
rule_i(0,datastore(1,'CS_CONNECT','First')).
rule_i(0,datastore(1,'DBMS_PORT','')).
rule_i(0,datastore(1,'CS_SERVER','LECCO\SQLEXPRESS')).
rule_i(0,datastore(1,'CS_DBNAME','BillingSystem')).
rule_i(0,datastore(1,'CS_FLEDSNAME','')).
rule_i(0,datastore(1,'CS_DRVNAME','sql server')).
rule_i(0,datastore(1,'CS_DSNAME','')).
rule_i(0,datastore(1,'DB_URL','')).
rule_i(0,datastore(1,'JDBC_CUSTOM_URL','0')).
rule_i(0,datastore(1,'JDBC_CUSTOM_DRIVER','')).
rule_i(0,datastore(1,'JDBC_DRIVER','net.sourceforge.jtds.jdbc.Driver')).
rule_i(0,datastore(1,'CONNECT_METHOD','OPSYS')).
rule_i(0,datastore(1,'ACCESS_TECHNO','ADONET')).
rule_i(0,datastore(1,'MAIN_DS','-1')).
rule_i(0,datastore(1,'REORG_GEN','8')).
rule_i(0,datastore(1,'HelpKeyword','20')).
rule_i(0,datastore(1,'DBMS',12)).
rule_i(0,datastore(1,'NAME','Default')).
rule_i(0,prop(idNULLS_BEHAVIOR,idNB_Current)).
rule_i(0,prop('GenerateObject','-1')).
rule_i(0,prop('MTIER_OPT','Yes')).
rule_i(0,prop('CS_ORA_FORUPD','UMPV')).
rule_i(0,prop('Hint_firstrows','UMPV')).
rule_i(0,prop('AUTOENTER','UMPV')).
rule_i(0,prop('BEEPONMSG','UMPV')).
rule_i(0,prop('BEEPONERROR','UMPV')).
rule_i(0,prop('GENERATE_ILE','UMPV')).
rule_i(0,prop('TRNCMT','YES')).
rule_i(0,prop('NULLVALUE_AS_NULL','UMPV')).
rule_i(0,prop('INITIALIZE_NEW','UMPV')).
rule_i(0,prop('STD_FUNC_OBJECT','Yes')).
rule_i(0,prop('SPC_WARNINGS_DISABLED','spc0096 spc0107 spc0142')).
rule_i(0,prop('WBCHAR','')).
rule_i(0,prop('WBATTR',none)).
rule_i(0,prop('WBCOLOR',none)).
rule_i(0,prop('WNDPOP','NO')).
rule_i(0,prop('OKBUT','YES')).
rule_i(0,prop('AUTOCENTER','UMPV')).
rule_i(0,prop('DLT_BUTTON','')).
rule_i(0,prop('CNF_BUTTON','')).
rule_i(0,prop('UPD_BUTTON','')).
rule_i(0,prop('ADD_BUTTON','')).
rule_i(0,prop('AUTOSCROLL_FORM','UMPV')).
rule_i(0,prop('SHOW_FRM','UMPV')).
rule_i(0,prop('MODAL','PARM')).
rule_i(0,prop('CTRBOX','YES')).
rule_i(0,prop('ICON','')).
rule_i(0,prop('S_TASK','YES')).
rule_i(0,prop('MINBUT','YES')).
rule_i(0,prop('MAXBUT','YES')).
rule_i(0,prop('BORSTY','2')).
rule_i(0,prop('KEY_MOREKEYS','UMPV')).
rule_i(0,prop('KEY_ENTER','UMPV')).
rule_i(0,prop('KEY_LAST','UMPV')).
rule_i(0,prop('KEY_FIRST','UMPV')).
rule_i(0,prop('KEY_SELECT','UMPV')).
rule_i(0,prop('KEY_DISPLAY','UMPV')).
rule_i(0,prop('KEY_DELETE','UMPV')).
rule_i(0,prop('KEY_CANCEL','UMPV')).
rule_i(0,prop('KEY_UPDATE','UMPV')).
rule_i(0,prop('KEY_MENU','UMPV')).
rule_i(0,prop('KEY_RETRIEVE','UMPV')).
rule_i(0,prop('KEY_NEXT','UMPV')).
rule_i(0,prop('KEY_PREVIOUS','UMPV')).
rule_i(0,prop('KEY_INSERT','UMPV')).
rule_i(0,prop('KEY_REFRESH','UMPV')).
rule_i(0,prop('KEY_PROMPT','UMPV')).
rule_i(0,prop('KEY_EXIT','UMPV')).
rule_i(0,prop('KEY_CHECK','UMPV')).
rule_i(0,prop('KEY_HELP','UMPV')).
rule_i(0,prop('ASSIGNED_FNC_KEYS','UMPV')).
rule_i(0,prop('FIRST_WD_DATEPICKER','UMPV')).
rule_i(0,prop('WNUM_DATEPICKER','UMPV')).
rule_i(0,prop(idUSE_WEB_DATEPICKER,'UMPV')).
rule_i(0,prop('FIELD_TO_FIELD','UMPV')).
rule_i(0,prop('TRNCFM','UMPV')).
rule_i(0,prop('CFMTRN','No')).
rule_i(0,prop('TRNEND','Yes')).
rule_i(0,prop('IsDwhTrn','0')).
rule_i(0,prop('AjaxRequestsSecurity','High')).
rule_i(0,prop('USE_ENCRYPTION','UMPV')).
rule_i(0,prop('SHOWMASTERPAGE_POPUP','0')).
rule_i(0,prop('MasterPage',o(13,'AppMasterPage'))).
rule_i(0,prop('WEB_COMP','No')).
rule_i(0,prop('Theme',o(25,'GeneXusX'))).
rule_i(0,prop('ExternalNamespace','BillingSystem')).
rule_i(0,prop('ExternalName','Invoice')).
rule_i(0,prop('OBJECT_METADATA','')).
rule_i(0,prop('IsMain','0')).
rule_i(0,prop(idBC,'0')).
rule_i(0,prop('Folder',o(8,'Objects'))).
rule_i(0,prop('ObjDesc','Invoice')).
rule_i(0,prop('ObjName','Invoice')).
rule_i(5,prompt([ 3,[ [ 5,10,10 ] ],[ 10 ],[ 10 ],[ t(o(13,'Gx0030'),28),t(10,2) ],[],n,[] ])).
rule_i(5,rule([ a(23,[ [ 10 ],[ t(o(13,'Gx0030'),28),t(10,2) ] ]) ],[],[],[ 10 ])).
rule_i(5,prompt([ 5,[ [ [],14,14 ],[ [],17,17 ] ],[],[],[ t(o(13,'Gx0051'),28),t(14,2),t(',',7),t(17,2) ],[ 14 ],n,[] ])).
rule_i(5,rule([ a(23,[ [ 14,17 ],[ t(o(13,'Gx0051'),28),t(14,2),t(',',7),t(17,2) ] ]) ],[],[],[ 14,17 ])).
rule_i(4,prompt([ 2,[ [ 4,3,3 ] ],[ 3 ],[ 3 ],[ t(o(13,'Gx0020'),28),t(3,2) ],[],n,[] ])).
rule_i(4,rule([ a(23,[ [ 3 ],[ t(o(13,'Gx0020'),28),t(3,2) ] ]) ],[],[],[ 3 ])).
rule_i(4,prompt([ 4,[ [ [],14,14 ] ],[],[],[ t(o(13,'Gx0040'),28),t(14,2) ],[],n,[] ])).
rule_i(4,rule([ a(23,[ [ 14 ],[ t(o(13,'Gx0040'),28),t(14,2) ] ]) ],[],[],[ 14 ])).
rule_i(5,rule([ a(3,[ t(10,2) ]) ],[ t(update,1) ],[ update ],[ 10 ])).
rule_i(4,rule([ a(3,[ t(3,2) ]) ],[ t(update,1) ],[ update ],[ 3 ])).
rule_i(0,rule([ a(22,[ 'Dlt','"Delete"','' ]) ],[],[],[])).
rule_i(0,maingen(15)).
rule_i(0,macro(17,serial(20,[ t('1',3) ]))).
rule_i(4,rule([ a(1,msg([ t('"Field Invoice Date is out of range"',3) ],[ t('OutOfRange',3) ])) ],[ t('NOT',8),t('(',0),t('null(',1),t(15,2),t(')',4),t('.OR.',9),t(15,2),t(>=,10),t('ymdtod(',1),t('1753',3),t(',',7),t('01',3),t(',',7),t('01',3),t(')',4),t(')',4) ],[ insert,update ],[ 15 ])).
rule_i(4,rule([ a(18,[ [ 1 ] ]) ],[],[ insert,update,delete ],[ 1 ])).
rule_i(4,rule([ a(99,[ [ oe([ t(14,2) ]) ] ]) ],[],[ insert,update,delete ],[ oe([ t(14,2) ]) ])).
rule_i(4,rule([ a(99,[ [ oe([ t(14,2) ]) ] ]) ],[],[ insert,update,delete ],[ oe([ t(14,2) ]) ])).
rule_i(0,suggest(t(1,2),[ 2 ],1,5,[ [ [ 1,2 ] ],y,[ [ 1,many ] ],[],[ c([ t('upper(',1),t(2,2),t(')',4),t('.LIKE.',10),t('upper(',1),t(2,23),t(')',4) ],[ 2 ]) ],[ 2 ],[],[],[] ])).
rule_i(4,rule([ a(1,[ t('''No se permiten FACTURAS sin FECHA''',3) ]) ],[ t('null(',1),t(15,2),t(')',4) ],[ insert,update,delete ],[ 15 ])).
rule_i(4,rule([ a(1,[ t('''La fecha es mayor a la del dia de hoy''',3) ]) ],[ t(15,2),t(>,10),t('Today',23) ],[ insert,update,delete ],[ 15,'Today' ])).
rule_i(4,rule([ a(3,[ t(20,2) ]) ],[],[ insert,update,delete ],[ 20 ])).
rule_i(4,rule([ a(3,[ t(7,2) ]) ],[],[ insert,update,delete ],[ 7 ])).
rule_i(4,rule([ a(19,[ [ 3 ],msg([ t('"No matching ''Customer''."',3) ],[ t('ForeignKeyNotFound',3) ]) ]) ],[],[ insert,update,delete ],[ 3 ])).
rule_i(4,rule([ a(19,[ [ 1 ],msg([ t('"No matching ''Country''."',3) ],[ t('ForeignKeyNotFound',3) ]) ]) ],[],[ insert,update,delete ],[ 1 ])).
rule_i(5,rule([ a(3,[ t(20,2) ]) ],[],[ insert,update,delete ],[ 20 ])).
rule_i(5,rule([ a(3,[ t(7,2) ]) ],[],[ insert,update,delete ],[ 7 ])).
rule_i(5,rule([ a(19,[ [ 10 ],msg([ t('"No matching ''Product''."',3) ],[ t('ForeignKeyNotFound',3) ]) ]) ],[],[ insert,update,delete ],[ 10 ])).
 
a_i(1,4,b,0,[],[ [],[ a(1,msg([ t('"Field Invoice Date is out of range"',3) ],[ t('OutOfRange',3) ])) ],[ t('NOT',8),t('(',0),t('null(',1),t(15,2),t(')',4),t('.OR.',9),t(15,2),t(>=,10),t('ymdtod(',1),t('1753',3),t(',',7),t('01',3),t(',',7),t('01',3),t(')',4),t(')',4) ] ]).
a_i(2,4,f,9,[],[ [],[ t(7,2),t(-,5),t(16,2) ] ]).
a_i(3,4,f,7,[],[ [ delete,insert,update,delete ],[ t('old(',1),t(7,2),t(')',4),t(-,5),t(16,2),t('IF',17),t(delete,1),t(';',18),t('old(',1),t(7,2),t(')',4),t(+,5),t(16,2),t(-,5),t('old(',1),t(16,2),t(')',4),t('IF',17),t('(',0),t(insert,1),t('.OR.',9),t(update,1),t('.OR.',9),t(delete,1),t(')',4),t(';',18) ] ]).
a_i(4,4,f,[ t(7,2),t('Enabled',3) ],[],[ [],[ t(0,3),t(';',18) ] ]).
a_i(5,4,f,15,[],[ [ insert ],[ t('Today',23),t('IF',17),t(insert,1),t('AND',9),t('null1(',1),t(15,2),t(')',4),t('AND',9),t('GxBScreen',23),t(=,10),t(0,3),t(';',18) ] ]).
a_i(6,4,h,1,[],[ [ 1 ],[ 2 ],[ [ [ 1,2 ],[ 1,1 ] ],n,[ [ 1,many ] ],[],[ c([ t(2,2),t(=,10),t(2,23) ],[ 2 ]) ],[],[],[],[] ] ]).
a_i(7,4,b,0,[],[ [ update ],[ a(3,[ t(3,2) ]) ],[ t(update,1) ] ]).
a_i(8,4,b,2,[],[ [],[ a(1,[ t('''No se permiten FACTURAS sin FECHA''',3) ]) ],[ t('null(',1),t(15,2),t(')',4) ] ]).
a_i(9,4,b,3,[],[ [],[ a(1,[ t('''La fecha es mayor a la del dia de hoy''',3) ]) ],[ t(15,2),t(>,10),t('Today',23) ] ]).
a_i(10,5,f,16,[],[ [ insert,update,delete ],[ t('old(',1),t(16,2),t(')',4),t(+,5),t(19,2),t('IF',17),t(insert,1),t(';',18),t('old(',1),t(16,2),t(')',4),t(+,5),t(19,2),t(-,5),t('old(',1),t(19,2),t(')',4),t('IF',17),t(update,1),t(';',18),t('old(',1),t(16,2),t(')',4),t(-,5),t('old(',1),t(19,2),t(')',4),t('IF',17),t(delete,1),t(';',18) ] ]).
a_i(11,5,f,9,[],[ [],[ t(7,2),t(-,5),t(16,2) ] ]).
a_i(12,5,f,19,[],[ [],[ t(13,2),t(*,6),t(18,2) ] ]).
a_i(13,5,f,20,[],[ [ insert,update,delete ],[ t('old(',1),t(20,2),t(')',4),t(+,5),t('1',3),t('IF',17),t(insert,1),t(';',18),t('old(',1),t(20,2),t(')',4),t('IF',17),t(update,1),t(';',18),t('old(',1),t(20,2),t(')',4),t(-,5),t('1',3),t('IF',17),t(delete,1),t(';',18) ] ]).
a_i(14,5,f,20,[],[ [ insert ],[ t('old(',1),t(20,2),t(')',4),t(+,5),t('1',3),t('IF',17),t(insert,1),t(';',18) ] ]).
a_i(15,5,f,17,[],[ [ insert ],[ t(20,2),t('IF',17),t(insert,1),t('AND',9),t('GxBScreen',23),t(=,10),t(1,3),t(';',18) ] ]).
a_i(16,5,f,19,[],[ [],[ t(13,2),t(*,6),t(18,2),t(';',18) ] ]).
a_i(17,5,f,12,[],[ [],[ t('old(',1),t(12,2),t(')',4),t(-,5),t(18,2),t('IF',17),t(12,2),t(-,5),t(18,2),t(>=,10),t('0',3),t(';',18) ] ]).
a_i(18,5,f,7,[],[ [ insert,update,delete ],[ t('old(',1),t(7,2),t(')',4),t(+,5),t(16,2),t(-,5),t('old(',1),t(16,2),t(')',4),t('IF',17),t('(',0),t(insert,1),t('.OR.',9),t(update,1),t('.OR.',9),t(delete,1),t(')',4),t(';',18) ] ]).
a_i(19,5,f,[ t(7,2),t('Enabled',3) ],[],[ [],[ t(0,3),t(';',18) ] ]).
a_i(20,5,b,0,[],[ [ update ],[ a(3,[ t(10,2) ]) ],[ t(update,1) ] ]).
a_i(21,4,t,4,[],[ [ [ [],14,14 ] ],'IINVOICE',[] ]).
a_i(22,4,r,2,[],[ [ [ 4,3,3 ] ],'ICUSTOMER',[] ]).
a_i(23,4,r,1,[],[ [ [ 2,1,1 ] ],'ICOUNTRY',[] ]).
a_i(24,4,r,2000,[],[ [ [ 4,oe([ t(14,2) ]),14 ] ],'IINVOICE',[] ]).
a_i(25,4,r,2001,[],[ [ [ 4,oe([ t(14,2) ]),14 ] ],'IINVOICE',[] ]).
a_i(26,5,t,5,[],[ [ [ [],14,14 ],[ [],17,17 ] ],'IINVOICEDETAIL',[] ]).
a_i(27,5,r,3,[],[ [ [ 5,10,10 ] ],'IPRODUCT',[] ]).
a_i(28,4,f,'GxBScreen',[],[ [],[ t('0',3) ] ]).
a_i(29,4,f,'Today',[],[ [],[ t('today(',1),t(')',4) ] ]).
 
v_i(b,i,1,15).
v_i(b,o,1,[]).
v_i(f,i,2,7).
v_i(f,i,2,16).
v_i(f,o,2,9).
v_i(f,i,3,7).
v_i(f,i,3,16).
v_i(f,o,3,7).
v_i(f,i,4,[]).
v_i(f,o,4,[ t(7,2),t('Enabled',3) ]).
v_i(f,i,5,'Today').
v_i(f,i,5,'GxBScreen').
v_i(f,o,5,15).
v_i(h,i,6,1).
v_i(h,o,6,1).
v_i(b,i,7,[]).
v_i(b,o,7,[]).
v_i(b,i,8,15).
v_i(b,o,8,[]).
v_i(b,i,9,15).
v_i(b,i,9,'Today').
v_i(b,o,9,[]).
v_i(f,i,10,19).
v_i(f,o,10,16).
v_i(f,i,11,7).
v_i(f,i,11,16).
v_i(f,o,11,9).
v_i(f,i,12,13).
v_i(f,i,12,18).
v_i(f,o,12,19).
v_i(f,i,13,18).
v_i(f,o,13,20).
v_i(f,o,14,20).
v_i(f,i,15,20).
v_i(f,i,15,'GxBScreen').
v_i(f,o,15,17).
v_i(f,i,16,13).
v_i(f,i,16,18).
v_i(f,o,16,19).
v_i(f,i,17,12).
v_i(f,i,17,18).
v_i(f,o,17,12).
v_i(f,i,18,16).
v_i(f,o,18,7).
v_i(f,i,19,[]).
v_i(f,o,19,[ t(7,2),t('Enabled',3) ]).
v_i(b,i,20,[]).
v_i(b,o,20,[]).
v_i(t,i,21,14).
v_i(t,o,21,15).
v_i(t,o,21,3).
v_i(r,i,22,3).
v_i(r,o,22,7).
v_i(r,o,22,4).
v_i(r,o,22,1).
v_i(r,i,23,1).
v_i(r,o,23,2).
v_i(r,i,24,14).
v_i(r,o,24,20).
v_i(r,i,25,14).
v_i(r,o,25,16).
v_i(t,i,26,14).
v_i(t,i,26,17).
v_i(t,o,26,18).
v_i(t,o,26,10).
v_i(r,i,27,10).
v_i(r,o,27,12).
v_i(r,o,27,11).
v_i(r,o,27,13).
v_i(f,i,14,[]).
v_i(f,i,28,[]).
v_i(f,o,28,'GxBScreen').
v_i(f,i,29,[]).
v_i(f,o,29,'Today').
 
ca_i(18,7).
ca_i(17,12).
ca_i(14,20).
ca_i(13,20).
ca_i(10,16).
ca_i(5,15).
ca_i(3,7).
 
tbl_to_delete_i(4,[ 5,[ [ 4,14,14 ] ],d,'IINVOICEDETAIL',[ [ 5,14 ],[ 5,17 ] ],[ 14,17 ] ]).
 
 
 
attri_i(19,[ 'InvoiceDetailAmount',int,9,2,'ZZZZZ9.99',0,'Invoice Detail Amount','',0 ]).
attri_i(13,[ 'ProductPrice',int,9,2,'ZZZZZ9.99',0,'Product Price','',0 ]).
attri_i(12,[ 'ProductStock',int,4,0,'ZZZ9',0,'Product Stock','',0 ]).
attri_i(11,[ 'ProductDescription',char,30,0,'',0,'Product Description','',0 ]).
attri_i(18,[ 'InvoiceDetailQuantiity',int,3,0,'ZZ9',0,'Invoice Detail Quantiity','',0 ]).
attri_i(10,[ 'ProductId',int,6,0,'ZZZZZ9',0,'Product Identifier','',0 ]).
attri_i(17,[ 'InvoiceDetailId',int,2,0,'Z9',0,'Detail Identifier','',0 ]).
attri_i(16,[ 'InvoiceAmount',int,9,2,'ZZZZZ9.99',0,'Invoice Amount','',0 ]).
attri_i(2,[ 'CountryName',char,30,0,'',0,'Country Name','',0 ]).
attri_i(1,[ 'CountryId',int,6,0,'ZZZZZ9',0,'Country Id','',0 ]).
attri_i(20,[ 'InvoiceLastLineId',int,4,0,'ZZZ9',0,'Invoice Last Line Id','',0 ]).
attri_i(4,[ 'CustomerName',char,30,0,'',0,'Customer Name','',0 ]).
attri_i(3,[ 'CustomerId',int,6,0,'ZZZZZ9',0,'Customer Id','',0 ]).
attri_i(15,[ 'InvoiceDate',date,8,0,'99/99/99',0,'Invoice Date','',0 ]).
attri_i(7,[ 'CustomerTotalPurchases',int,9,2,'ZZZZZ9.99',0,'Customer Total Purchases','',0 ]).
attri_i(14,[ 'InvoiceId',int,6,0,'ZZZZZ9',0,'Invoice Id','',0 ]).
attri_i(9,[ 'CustomerBalance',int,9,2,'ZZZZZ9.99',0,'Customer Balance','',0 ]).
attri_i('GxBScreen',[ 'Gx_BScreen',int,1,0,'',0,'','',7 ]).
attri_i('Today',[ 'Gx_date',date,8,0,'99/99/99',1,'','',6 ]).
attri_i('Gxremove',[ 'GxRemove',int,1,0,'9',0,'Gx Remove','',5 ]).
attri_i('Mode',[ 'Gx_mode',char,3,0,'@!',1,'','',2 ]).
 
table_i(2001,[ 'Invoice',[ 16,14 ],'Invoice','Invoice' ]).
table_i(2000,[ 'Invoice',[ 20,14 ],'Invoice','Invoice' ]).
table_i(1,[ 'Country',[ 1,2 ],'Country','Country' ]).
table_i(2,[ 'Customer',[ 3,4,7,1 ],'Customer','Customer' ]).
table_i(4,[ 'Invoice',[ 14,15,3 ],'Invoice','Invoice' ]).
table_i(3,[ 'Product',[ 10,11,12,13 ],'Product','Product' ]).
table_i(5,[ 'InvoiceDetail',[ 14,17,10,18 ],'Detail','InvoiceDetail' ]).
 
index_i(5,[ 'IINVOICEDETAIL',u,[ 14,17 ],'IInvoiceDetail' ]).
index_i(3,[ 'IPRODUCT',u,[ 10 ],'IProduct' ]).
index_i(4,[ 'IINVOICE',u,[ 14 ],'IInvoice' ]).
index_i(2,[ 'ICUSTOMER',u,[ 3 ],'ICustomer' ]).
index_i(1,[ 'ICOUNTRY',u,[ 1 ],'ICountry' ]).
index_i(2000,[ 'IINVOICE',u,[ 14 ],'IInvoice' ]).
index_i(2001,[ 'IINVOICE',u,[ 14 ],'IInvoice' ]).
 
lv_i(2,2000,4).
lv_i(2,2001,4).
 
 
function_i(5,7,no,old,'old(',[ 16 ],1,16,[ 2 ]).
function_i(5,7,no,old,'old(',[ 7 ],0,7,[ 2 ]).
function_i(5,12,no,old,'old(',[ 12 ],0,12,[ 2 ]).
function_i(5,20,no,old,'old(',[ 20 ],2,20,[ 2 ]).
function_i(5,20,no,old,'old(',[ 20 ],1,20,[ 2 ]).
function_i(5,20,no,old,'old(',[ 20 ],0,20,[ 2 ]).
function_i(5,16,no,old,'old(',[ 19 ],4,19,[ 2 ]).
function_i(5,16,no,old,'old(',[ 16 ],3,16,[ 2 ]).
function_i(5,16,no,old,'old(',[ 19 ],2,19,[ 2 ]).
function_i(5,16,no,old,'old(',[ 16 ],1,16,[ 2 ]).
function_i(5,16,no,old,'old(',[ 16 ],0,16,[ 2 ]).
function_i(4,7,no,old,'old(',[ 16 ],2,16,[ 2 ]).
function_i(4,7,no,old,'old(',[ 7 ],1,7,[ 2 ]).
function_i(4,7,no,old,'old(',[ 7 ],0,7,[ 2 ]).
 
 
nav_view_i(2000,[ 20 ],[ 14 ],[ 14 ],[ [ 2000,[ [ 4,oe([ t(14,2) ]),14 ] ] ] ],[ [ [ 5,[ 'count(',18 ] ],[ 5,14 ] ],n,[ [ 5,many ] ],[],[],[ none ],[],[ 14 ],[] ]).
nav_view_i(2001,[ 16 ],[ 14 ],[ 14 ],[ [ 2001,[ [ 4,oe([ t(14,2) ]),14 ] ] ] ],[ [ [ 5,[ 'sum(',se(19,[ [ 3,13 ],[ 5,18 ] ],[ t(13,2),t(*,6),t(18,2) ]) ] ],[ 5,14 ] ],n,[ [ 5,many ],[ 3,one ] ],[ [ 3,[ [ 5,10,10 ] ] ] ],[],[ none ],[],[ 14 ],[] ]).
 
agg_def_i(20,[ t('0',3) ]).
agg_def_i(16,[ t('0',3) ]).
 
for_ver_i(4,5,20,'count(',[ t(18,2) ],[],[ t('0',3) ]).
for_ver_i(4,5,16,'sum(',[ t(19,2) ],[],[ t('0',3) ]).
 
 
 
upd_i(4,4,i,[ [ 15,3 ],[],'IINVOICE',[ [ [],14,14 ] ] ]).
upd_i(4,4,u,[ [ 15,3 ],[],'IINVOICE',[] ]).
upd_i(4,4,d,[ [],[],'IINVOICE',[] ]).
upd_i(4,2,u,[ [ 7 ],[ 7 ],'ICUSTOMER',[ [ 4,3,3 ] ] ]).
upd_i(5,5,i,[ [ 14,17,18,10 ],[],'IINVOICEDETAIL',[ [ [],14,14 ],[ [],17,17 ] ] ]).
upd_i(5,5,u,[ [ 18,10 ],[],'IINVOICEDETAIL',[] ]).
upd_i(5,5,d,[ [],[],'IINVOICEDETAIL',[] ]).
upd_i(5,3,u,[ [ 12 ],[],'IPRODUCT',[ [ 5,10,10 ] ] ]).
 
 
 
start_i(5,0,0,[ [ [ 14,2,14,= ] ],many ]).
 
end_i(5,0,0,[ [ [ t(14,2),t(=,10),t(14,23) ] ] ]).
 
 
 
 
enumerated_i(2,22,15).
 
enum_value_i(2,15,'"value 0"','Active','"Active"').
enum_value_i(2,15,'"value 1"','OnHold','"On Hold"').
enum_value_i(2,15,'"value 2"','Closed','"Closed"').
 
enum_value_info_i(2,15,'Status').
 
enum_type_i(2,15,svchar,40,0).
 
 
break_i(2,nvg,1,[],[ [],[],[] ]).
 
b_group_i(2,1,lit,0,1,0).
 
 
sf_break_i(75,5).
 
 
 
 
 
 
 
 
 
 
 
 
html_i(2,table(2)).
 
html_sub_i(2,0,html_i(0,html('<TBODY>'))).
html_sub_i(2,3,html_i(1,row(3))).
html_sub_i(3,4,html_i(0,cell(4))).
html_sub_i(4,5,html_i(0,table(5))).
html_sub_i(5,0,html_i(0,html('<TBODY>'))).
html_sub_i(5,6,html_i(1,row(6))).
html_sub_i(6,7,html_i(0,cell(7))).
html_sub_i(7,0,html_i(0,html('<DIV style="WHITE-SPACE: nowrap" class="ToolbarMain">'))).
html_sub_i(7,8,html_i(1,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-42'))).
html_sub_i(7,9,html_i(2,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-60'))).
html_sub_i(7,10,html_i(3,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-48'))).
html_sub_i(7,11,html_i(4,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-60'))).
html_sub_i(7,12,html_i(5,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-47'))).
html_sub_i(7,13,html_i(6,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-60'))).
html_sub_i(7,14,html_i(7,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-44'))).
html_sub_i(7,15,html_i(8,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-60'))).
html_sub_i(7,16,html_i(9,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-55'))).
html_sub_i(7,17,html_i(10,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-60'))).
html_sub_i(7,18,html_i(11,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-54'))).
html_sub_i(7,19,html_i(12,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-60'))).
html_sub_i(7,20,html_i(13,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-40'))).
html_sub_i(7,21,html_i(14,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-60'))).
html_sub_i(7,22,html_i(15,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-28'))).
html_sub_i(7,23,html_i(16,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-60'))).
html_sub_i(7,0,html_i(17,html('</DIV>'))).
html_sub_i(5,24,html_i(2,row(24))).
html_sub_i(24,25,html_i(0,cell(25))).
html_sub_i(5,0,html_i(3,html('</TBODY>'))).
html_sub_i(4,26,html_i(1,group(26))).
html_sub_i(26,27,html_i(0,table(27))).
html_sub_i(27,0,html_i(0,html('<TBODY>'))).
html_sub_i(27,28,html_i(1,row(28))).
html_sub_i(28,29,html_i(0,cell(29))).
html_sub_i(29,30,html_i(0,comp(errview))).
html_sub_i(27,31,html_i(2,row(31))).
html_sub_i(31,32,html_i(0,cell(32))).
html_sub_i(32,33,html_i(0,table(33))).
html_sub_i(33,0,html_i(0,html('<TBODY>'))).
html_sub_i(33,34,html_i(1,row(34))).
html_sub_i(34,35,html_i(0,cell(35))).
html_sub_i(35,36,html_i(0,t('Id',3))).
html_sub_i(34,37,html_i(1,cell(37))).
html_sub_i(37,38,html_i(0,t(14,2))).
html_sub_i(33,39,html_i(2,row(39))).
html_sub_i(39,40,html_i(0,cell(40))).
html_sub_i(40,41,html_i(0,t('Date',3))).
html_sub_i(39,42,html_i(1,cell(42))).
html_sub_i(42,43,html_i(0,t(15,2))).
html_sub_i(33,44,html_i(3,row(44))).
html_sub_i(44,45,html_i(0,cell(45))).
html_sub_i(45,46,html_i(0,t('Customer Id',3))).
html_sub_i(44,47,html_i(1,cell(47))).
html_sub_i(47,48,html_i(0,t(3,2))).
html_sub_i(33,49,html_i(4,row(49))).
html_sub_i(49,50,html_i(0,cell(50))).
html_sub_i(50,51,html_i(0,t('Customer Name',3))).
html_sub_i(49,52,html_i(1,cell(52))).
html_sub_i(52,53,html_i(0,t(4,2))).
html_sub_i(33,54,html_i(5,row(54))).
html_sub_i(54,55,html_i(0,cell(55))).
html_sub_i(55,56,html_i(0,t('Customer Total Purchases',3))).
html_sub_i(54,57,html_i(1,cell(57))).
html_sub_i(57,58,html_i(0,t(7,2))).
html_sub_i(33,59,html_i(6,row(59))).
html_sub_i(59,60,html_i(0,cell(60))).
html_sub_i(60,61,html_i(0,t('Customer Balance',3))).
html_sub_i(59,62,html_i(1,cell(62))).
html_sub_i(62,63,html_i(0,t(9,2))).
html_sub_i(33,64,html_i(7,row(64))).
html_sub_i(64,65,html_i(0,cell(65))).
html_sub_i(65,66,html_i(0,t('Country Id',3))).
html_sub_i(64,67,html_i(1,cell(67))).
html_sub_i(67,68,html_i(0,t(1,2))).
html_sub_i(33,69,html_i(8,row(69))).
html_sub_i(69,70,html_i(0,cell(70))).
html_sub_i(70,0,html_i(0,html('<BR/>'))).
html_sub_i(70,71,html_i(1,table(71))).
html_sub_i(71,0,html_i(0,html('<TBODY>'))).
html_sub_i(71,72,html_i(1,row(72))).
html_sub_i(72,73,html_i(0,cell(73))).
html_sub_i(73,74,html_i(0,t('Detail',3))).
html_sub_i(71,0,html_i(2,html('</TBODY>'))).
html_sub_i(70,0,html_i(2,html('<HR class="HRDefault"/>'))).
html_sub_i(70,75,html_i(3,s(75))).
html_sub_i(33,82,html_i(9,row(82))).
html_sub_i(82,83,html_i(0,cell(83))).
html_sub_i(83,84,html_i(0,t('Amount',3))).
html_sub_i(82,85,html_i(1,cell(85))).
html_sub_i(85,86,html_i(0,t(16,2))).
html_sub_i(33,0,html_i(10,html('</TBODY>'))).
html_sub_i(27,87,html_i(3,row(87))).
html_sub_i(87,88,html_i(0,cell(88))).
html_sub_i(88,89,html_i(0,button('Enter'))).
html_sub_i(88,90,html_i(1,button('Cancel'))).
html_sub_i(88,91,html_i(2,button('Delete'))).
html_sub_i(27,0,html_i(4,html('</TBODY>'))).
html_sub_i(2,0,html_i(2,html('</TBODY>'))).
 
html_tags_i(1,'Class','Form').
 
html_comp_i(30,'Backcolor',rgb(0,0,0),d,[ color ]).
html_comp_i(2,'Id','Tablemain',v,[ str ]).
html_comp_i(2,'Class','TableBorder100x100',v,[ str ]).
html_comp_i(2,'Title','',d,[ str ]).
html_comp_i(2,'Align',left,d,[ str ]).
html_comp_i(2,'Backgroundgx','',d,[ str ]).
html_comp_i(2,'Bgcolor',rgb(0,0,0),d,[ color ]).
html_comp_i(2,'Border','0',d,[ str ]).
html_comp_i(2,'Bordercolor',rgb(0,0,0),d,[ color ]).
html_comp_i(2,'Cellpadding','1',d,[ str ]).
html_comp_i(2,'Cellspacing','2',d,[ str ]).
html_comp_i(2,'Height',measure(0,px),d,[ measure ]).
html_comp_i(2,'Width',measure(0,px),d,[ measure ]).
html_comp_i(2,'Rules',none,d,[ str ]).
html_comp_i(5,'Id','Tabletoolbar',v,[ str ]).
html_comp_i(5,'Class','ViewTable',v,[ str ]).
html_comp_i(5,'Title','',d,[ str ]).
html_comp_i(5,'Align',left,d,[ str ]).
html_comp_i(5,'Backgroundgx','',d,[ str ]).
html_comp_i(5,'Bgcolor',rgb(255,255,255),d,[ color ]).
html_comp_i(5,'Border','1',d,[ str ]).
html_comp_i(5,'Bordercolor',rgb(192,192,192),d,[ color ]).
html_comp_i(5,'Cellpadding','1',d,[ str ]).
html_comp_i(5,'Cellspacing','2',d,[ str ]).
html_comp_i(5,'Height',measure(0,px),d,[ measure ]).
html_comp_i(5,'Width',measure(0,px),d,[ measure ]).
html_comp_i(5,'Rules',none,d,[ str ]).
html_comp_i(8,'Id','Btn_first',v,[ str ]).
html_comp_i(8,'Class','ImageHandCenter',v,[ str ]).
html_comp_i(8,src,i(98,'b9e06284-17ac-4c88-8937-5dbd84ad5d80'),v,[ image ]).
html_comp_i(8,lowsrc,'',d,[ str ]).
html_comp_i(8,'Returnonclick',0,d,[ bool ]).
html_comp_i(8,'Eventgx','First',v,[ str ]).
html_comp_i(8,'Height',measure(0,px),d,[ measure ]).
html_comp_i(8,'Width',measure(0,px),d,[ measure ]).
html_comp_i(8,'Border','0',d,[ str ]).
html_comp_i(8,'Alt','',d,[ str ]).
html_comp_i(8,'Title','First',v,[ str ]).
html_comp_i(8,'Hspace',0,v,[ num ]).
html_comp_i(8,'Vspace',0,d,[ num ]).
html_comp_i(8,'Align',left,d,[ str ]).
html_comp_i(8,'Usemap','',d,[ str ]).
html_comp_i(9,'Id','Btn_first_separator',v,[ str ]).
html_comp_i(9,'Class','ImageTop',v,[ str ]).
html_comp_i(9,src,i(98,'ea7811ba-4fa2-42da-8591-e6cb10669f1f'),v,[ image ]).
html_comp_i(9,lowsrc,'',d,[ str ]).
html_comp_i(9,'Returnonclick',0,d,[ bool ]).
html_comp_i(9,'Eventgx','First',v,[ str ]).
html_comp_i(9,'Height',measure(0,px),d,[ measure ]).
html_comp_i(9,'Width',measure(0,px),d,[ measure ]).
html_comp_i(9,'Border','0',d,[ str ]).
html_comp_i(9,'Alt','',d,[ str ]).
html_comp_i(9,'Title','',d,[ str ]).
html_comp_i(9,'Hspace',0,v,[ num ]).
html_comp_i(9,'Vspace',0,d,[ num ]).
html_comp_i(9,'Align',left,d,[ str ]).
html_comp_i(9,'Usemap','',d,[ str ]).
html_comp_i(10,'Id','Btn_previous',v,[ str ]).
html_comp_i(10,'Class','ImageHandCenter',v,[ str ]).
html_comp_i(10,src,i(98,'7d212604-db7b-4785-9c0d-5faffe71aa33'),v,[ image ]).
html_comp_i(10,lowsrc,'',d,[ str ]).
html_comp_i(10,'Returnonclick',0,d,[ bool ]).
html_comp_i(10,'Eventgx','Previous',v,[ str ]).
html_comp_i(10,'Height',measure(0,px),d,[ measure ]).
html_comp_i(10,'Width',measure(0,px),d,[ measure ]).
html_comp_i(10,'Border','0',d,[ str ]).
html_comp_i(10,'Alt','',d,[ str ]).
html_comp_i(10,'Title','Previous',v,[ str ]).
html_comp_i(10,'Hspace',0,v,[ num ]).
html_comp_i(10,'Vspace',0,d,[ num ]).
html_comp_i(10,'Align',left,d,[ str ]).
html_comp_i(10,'Usemap','',d,[ str ]).
html_comp_i(11,'Id','Btn_previous_separator',v,[ str ]).
html_comp_i(11,'Class','ImageTop',v,[ str ]).
html_comp_i(11,src,i(98,'ea7811ba-4fa2-42da-8591-e6cb10669f1f'),v,[ image ]).
html_comp_i(11,lowsrc,'',d,[ str ]).
html_comp_i(11,'Returnonclick',0,d,[ bool ]).
html_comp_i(11,'Eventgx','Previous',v,[ str ]).
html_comp_i(11,'Height',measure(0,px),d,[ measure ]).
html_comp_i(11,'Width',measure(0,px),d,[ measure ]).
html_comp_i(11,'Border','0',d,[ str ]).
html_comp_i(11,'Alt','',d,[ str ]).
html_comp_i(11,'Title','',d,[ str ]).
html_comp_i(11,'Hspace',0,v,[ num ]).
html_comp_i(11,'Vspace',0,d,[ num ]).
html_comp_i(11,'Align',left,d,[ str ]).
html_comp_i(11,'Usemap','',d,[ str ]).
html_comp_i(12,'Id','Btn_next',v,[ str ]).
html_comp_i(12,'Class','ImageHandCenter',v,[ str ]).
html_comp_i(12,src,i(98,'1ae947cf-1354-41a9-8d59-d91daebf554f'),v,[ image ]).
html_comp_i(12,lowsrc,'',d,[ str ]).
html_comp_i(12,'Returnonclick',0,d,[ bool ]).
html_comp_i(12,'Eventgx','Next',v,[ str ]).
html_comp_i(12,'Height',measure(0,px),d,[ measure ]).
html_comp_i(12,'Width',measure(0,px),d,[ measure ]).
html_comp_i(12,'Border','0',d,[ str ]).
html_comp_i(12,'Alt','',d,[ str ]).
html_comp_i(12,'Title','Next',v,[ str ]).
html_comp_i(12,'Hspace',0,v,[ num ]).
html_comp_i(12,'Vspace',0,d,[ num ]).
html_comp_i(12,'Align',left,d,[ str ]).
html_comp_i(12,'Usemap','',d,[ str ]).
html_comp_i(13,'Id','Btn_next_separator',v,[ str ]).
html_comp_i(13,'Class','ImageTop',v,[ str ]).
html_comp_i(13,src,i(98,'ea7811ba-4fa2-42da-8591-e6cb10669f1f'),v,[ image ]).
html_comp_i(13,lowsrc,'',d,[ str ]).
html_comp_i(13,'Returnonclick',0,d,[ bool ]).
html_comp_i(13,'Eventgx','Next',v,[ str ]).
html_comp_i(13,'Height',measure(0,px),d,[ measure ]).
html_comp_i(13,'Width',measure(0,px),d,[ measure ]).
html_comp_i(13,'Border','0',d,[ str ]).
html_comp_i(13,'Alt','',d,[ str ]).
html_comp_i(13,'Title','',d,[ str ]).
html_comp_i(13,'Hspace',0,v,[ num ]).
html_comp_i(13,'Vspace',0,d,[ num ]).
html_comp_i(13,'Align',left,d,[ str ]).
html_comp_i(13,'Usemap','',d,[ str ]).
html_comp_i(14,'Id','Btn_last',v,[ str ]).
html_comp_i(14,'Class','ImageHandCenter',v,[ str ]).
html_comp_i(14,src,i(98,'29211874-e613-48e5-9011-8017d984217e'),v,[ image ]).
html_comp_i(14,lowsrc,'',d,[ str ]).
html_comp_i(14,'Returnonclick',0,d,[ bool ]).
html_comp_i(14,'Eventgx','Last',v,[ str ]).
html_comp_i(14,'Height',measure(0,px),d,[ measure ]).
html_comp_i(14,'Width',measure(0,px),d,[ measure ]).
html_comp_i(14,'Border','0',d,[ str ]).
html_comp_i(14,'Alt','',d,[ str ]).
html_comp_i(14,'Title','Last',v,[ str ]).
html_comp_i(14,'Hspace',0,v,[ num ]).
html_comp_i(14,'Vspace',0,d,[ num ]).
html_comp_i(14,'Align',left,d,[ str ]).
html_comp_i(14,'Usemap','',d,[ str ]).
html_comp_i(15,'Id','Btn_last_separator',v,[ str ]).
html_comp_i(15,'Class','ImageTop',v,[ str ]).
html_comp_i(15,src,i(98,'ea7811ba-4fa2-42da-8591-e6cb10669f1f'),v,[ image ]).
html_comp_i(15,lowsrc,'',d,[ str ]).
html_comp_i(15,'Returnonclick',0,d,[ bool ]).
html_comp_i(15,'Eventgx','Last',v,[ str ]).
html_comp_i(15,'Height',measure(0,px),d,[ measure ]).
html_comp_i(15,'Width',measure(0,px),d,[ measure ]).
html_comp_i(15,'Border','0',d,[ str ]).
html_comp_i(15,'Alt','',d,[ str ]).
html_comp_i(15,'Title','',d,[ str ]).
html_comp_i(15,'Hspace',0,v,[ num ]).
html_comp_i(15,'Vspace',0,d,[ num ]).
html_comp_i(15,'Align',left,d,[ str ]).
html_comp_i(15,'Usemap','',d,[ str ]).
html_comp_i(16,'Id','Btn_select',v,[ str ]).
html_comp_i(16,'Class','ImageHandCenter',v,[ str ]).
html_comp_i(16,src,i(98,'1ca03f75-9947-4d2c-90a4-e8ab9c5cedea'),v,[ image ]).
html_comp_i(16,lowsrc,'',d,[ str ]).
html_comp_i(16,'Returnonclick',0,d,[ bool ]).
html_comp_i(16,'Eventgx','Select',v,[ str ]).
html_comp_i(16,'Height',measure(0,px),d,[ measure ]).
html_comp_i(16,'Width',measure(0,px),d,[ measure ]).
html_comp_i(16,'Border','0',d,[ str ]).
html_comp_i(16,'Alt','',d,[ str ]).
html_comp_i(16,'Title','Select',v,[ str ]).
html_comp_i(16,'Hspace',0,v,[ num ]).
html_comp_i(16,'Vspace',0,d,[ num ]).
html_comp_i(16,'Align',left,d,[ str ]).
html_comp_i(16,'Usemap','',d,[ str ]).
html_comp_i(17,'Id','Btn_select_separator',v,[ str ]).
html_comp_i(17,'Class','ImageTop',v,[ str ]).
html_comp_i(17,src,i(98,'ea7811ba-4fa2-42da-8591-e6cb10669f1f'),v,[ image ]).
html_comp_i(17,lowsrc,'',d,[ str ]).
html_comp_i(17,'Returnonclick',0,d,[ bool ]).
html_comp_i(17,'Eventgx','Select',v,[ str ]).
html_comp_i(17,'Height',measure(0,px),d,[ measure ]).
html_comp_i(17,'Width',measure(0,px),d,[ measure ]).
html_comp_i(17,'Border','0',d,[ str ]).
html_comp_i(17,'Alt','',d,[ str ]).
html_comp_i(17,'Title','',d,[ str ]).
html_comp_i(17,'Hspace',0,v,[ num ]).
html_comp_i(17,'Vspace',0,d,[ num ]).
html_comp_i(17,'Align',left,d,[ str ]).
html_comp_i(17,'Usemap','',d,[ str ]).
html_comp_i(18,'Id','Btn_enter2',v,[ str ]).
html_comp_i(18,'Class','ImageHandCenter',v,[ str ]).
html_comp_i(18,src,i(98,'2061cf2c-bd33-4433-a13e-34af954142e9'),v,[ image ]).
html_comp_i(18,lowsrc,'',d,[ str ]).
html_comp_i(18,'Returnonclick',0,d,[ bool ]).
html_comp_i(18,'Eventgx','Enter',v,[ str ]).
html_comp_i(18,'Height',measure(0,px),d,[ measure ]).
html_comp_i(18,'Width',measure(0,px),d,[ measure ]).
html_comp_i(18,'Border','0',d,[ str ]).
html_comp_i(18,'Alt','',d,[ str ]).
html_comp_i(18,'Title','Confirm',v,[ str ]).
html_comp_i(18,'Hspace',0,v,[ num ]).
html_comp_i(18,'Vspace',0,d,[ num ]).
html_comp_i(18,'Align',left,d,[ str ]).
html_comp_i(18,'Usemap','',d,[ str ]).
html_comp_i(19,'Id','Btn_enter2_separator',v,[ str ]).
html_comp_i(19,'Class','ImageTop',v,[ str ]).
html_comp_i(19,src,i(98,'ea7811ba-4fa2-42da-8591-e6cb10669f1f'),v,[ image ]).
html_comp_i(19,lowsrc,'',d,[ str ]).
html_comp_i(19,'Returnonclick',0,d,[ bool ]).
html_comp_i(19,'Eventgx','Enter',v,[ str ]).
html_comp_i(19,'Height',measure(0,px),d,[ measure ]).
html_comp_i(19,'Width',measure(0,px),d,[ measure ]).
html_comp_i(19,'Border','0',d,[ str ]).
html_comp_i(19,'Alt','',d,[ str ]).
html_comp_i(19,'Title','',d,[ str ]).
html_comp_i(19,'Hspace',0,v,[ num ]).
html_comp_i(19,'Vspace',0,d,[ num ]).
html_comp_i(19,'Align',left,d,[ str ]).
html_comp_i(19,'Usemap','',d,[ str ]).
html_comp_i(20,'Id','Btn_cancel2',v,[ str ]).
html_comp_i(20,'Class','ImageHandCenter',v,[ str ]).
html_comp_i(20,src,i(98,'0e94ced8-bc34-47ff-9a53-bc683736a686'),v,[ image ]).
html_comp_i(20,lowsrc,'',d,[ str ]).
html_comp_i(20,'Returnonclick',0,d,[ bool ]).
html_comp_i(20,'Eventgx','Cancel',v,[ str ]).
html_comp_i(20,'Height',measure(0,px),d,[ measure ]).
html_comp_i(20,'Width',measure(0,px),d,[ measure ]).
html_comp_i(20,'Border','0',d,[ str ]).
html_comp_i(20,'Alt','',d,[ str ]).
html_comp_i(20,'Title','Cancel',v,[ str ]).
html_comp_i(20,'Hspace',0,v,[ num ]).
html_comp_i(20,'Vspace',0,d,[ num ]).
html_comp_i(20,'Align',left,d,[ str ]).
html_comp_i(20,'Usemap','',d,[ str ]).
html_comp_i(21,'Id','Btn_cancel2_separator',v,[ str ]).
html_comp_i(21,'Class','ImageTop',v,[ str ]).
html_comp_i(21,src,i(98,'ea7811ba-4fa2-42da-8591-e6cb10669f1f'),v,[ image ]).
html_comp_i(21,lowsrc,'',d,[ str ]).
html_comp_i(21,'Returnonclick',0,d,[ bool ]).
html_comp_i(21,'Eventgx','Cancel',v,[ str ]).
html_comp_i(21,'Height',measure(0,px),d,[ measure ]).
html_comp_i(21,'Width',measure(0,px),d,[ measure ]).
html_comp_i(21,'Border','0',d,[ str ]).
html_comp_i(21,'Alt','',d,[ str ]).
html_comp_i(21,'Title','',d,[ str ]).
html_comp_i(21,'Hspace',0,v,[ num ]).
html_comp_i(21,'Vspace',0,d,[ num ]).
html_comp_i(21,'Align',left,d,[ str ]).
html_comp_i(21,'Usemap','',d,[ str ]).
html_comp_i(22,'Id','Btn_delete2',v,[ str ]).
html_comp_i(22,'Class','ImageHandCenter',v,[ str ]).
html_comp_i(22,src,i(98,'7695fe89-52c9-4b7e-871e-0e11548f823e'),v,[ image ]).
html_comp_i(22,lowsrc,'',d,[ str ]).
html_comp_i(22,'Returnonclick',0,d,[ bool ]).
html_comp_i(22,'Eventgx','Delete',v,[ str ]).
html_comp_i(22,'Height',measure(0,px),d,[ measure ]).
html_comp_i(22,'Width',measure(0,px),d,[ measure ]).
html_comp_i(22,'Border','0',d,[ str ]).
html_comp_i(22,'Alt','',d,[ str ]).
html_comp_i(22,'Title','Delete',v,[ str ]).
html_comp_i(22,'Hspace',0,v,[ num ]).
html_comp_i(22,'Vspace',0,d,[ num ]).
html_comp_i(22,'Align',left,d,[ str ]).
html_comp_i(22,'Usemap','',d,[ str ]).
html_comp_i(23,'Id','Btn_delete2_separator',v,[ str ]).
html_comp_i(23,'Class','ImageTop',v,[ str ]).
html_comp_i(23,src,i(98,'ea7811ba-4fa2-42da-8591-e6cb10669f1f'),v,[ image ]).
html_comp_i(23,lowsrc,'',d,[ str ]).
html_comp_i(23,'Returnonclick',0,d,[ bool ]).
html_comp_i(23,'Eventgx','Delete',v,[ str ]).
html_comp_i(23,'Height',measure(0,px),d,[ measure ]).
html_comp_i(23,'Width',measure(0,px),d,[ measure ]).
html_comp_i(23,'Border','0',d,[ str ]).
html_comp_i(23,'Alt','',d,[ str ]).
html_comp_i(23,'Title','',d,[ str ]).
html_comp_i(23,'Hspace',0,v,[ num ]).
html_comp_i(23,'Vspace',0,d,[ num ]).
html_comp_i(23,'Align',left,d,[ str ]).
html_comp_i(23,'Usemap','',d,[ str ]).
html_comp_i(26,'Class','Group',v,[ str ]).
html_comp_i(26,'Caption','Invoice',d,[ str ]).
html_comp_i(26,'Id','Groupdata',v,[ str ]).
html_comp_i(26,'Height',measure(0,px),d,[ measure ]).
html_comp_i(26,'Width',measure(0,px),d,[ measure ]).
html_comp_i(27,'Id','Table1',v,[ str ]).
html_comp_i(27,'Class','Table',v,[ str ]).
html_comp_i(27,'Title','',d,[ str ]).
html_comp_i(27,'Align',left,d,[ str ]).
html_comp_i(27,'Backgroundgx','',d,[ str ]).
html_comp_i(27,'Bgcolor',rgb(0,0,0),d,[ color ]).
html_comp_i(27,'Border','0',d,[ str ]).
html_comp_i(27,'Bordercolor',rgb(0,0,0),d,[ color ]).
html_comp_i(27,'Cellpadding','1',d,[ str ]).
html_comp_i(27,'Cellspacing','2',d,[ str ]).
html_comp_i(27,'Height',measure(0,px),d,[ measure ]).
html_comp_i(27,'Width',measure(0,px),d,[ measure ]).
html_comp_i(27,'Rules',none,d,[ str ]).
html_comp_i(30,'Controlname','Ctlerror',v,[ str ]).
html_comp_i(30,'Class','ErrorViewer',d,[ str ]).
html_comp_i(30,'Displaymode',1,d,[ num ]).
html_comp_i(30,'Forecolor',rgb(0,0,0),d,[ color ]).
html_comp_i(30,'Font',font('Microsoft Sans Serif',8,[]),d,[ font ]).
html_comp_i(30,'Fill',-1,d,[ bool ]).
html_comp_i(33,'Id','Table2',v,[ str ]).
html_comp_i(33,'Class','Table',v,[ str ]).
html_comp_i(33,'Title','',d,[ str ]).
html_comp_i(33,'Align',left,d,[ str ]).
html_comp_i(33,'Backgroundgx','',d,[ str ]).
html_comp_i(33,'Bgcolor',rgb(0,0,0),d,[ color ]).
html_comp_i(33,'Border','0',d,[ str ]).
html_comp_i(33,'Bordercolor',rgb(0,0,0),d,[ color ]).
html_comp_i(33,'Cellpadding','1',d,[ str ]).
html_comp_i(33,'Cellspacing','2',d,[ str ]).
html_comp_i(33,'Height',measure(0,px),d,[ measure ]).
html_comp_i(33,'Width',measure(0,px),d,[ measure ]).
html_comp_i(33,'Rules',none,d,[ str ]).
html_comp_i(35,'Valign',top,v,[ str ]).
html_comp_i(35,'Class',td5,v,[ str ]).
html_comp_i(36,'Caption','Id',d,[ str ]).
html_comp_i(36,'Id','Textblockinvoiceid',v,[ str ]).
html_comp_i(36,'Class','TextBlock',d,[ str ]).
html_comp_i(36,'Event','',d,[ str ]).
html_comp_i(36,'Returnonclick',0,d,[ bool ]).
html_comp_i(36,'Gxformat',0,d,[ num ]).
html_comp_i(36,'Title','',d,[ str ]).
html_comp_i(36,'Fill',-1,d,[ bool ]).
html_comp_i(36,'Backcolor',rgb(255,255,255),d,[ color ]).
html_comp_i(36,'Forecolor',rgb(116,116,116),d,[ color ]).
html_comp_i(36,'Font',font('Arial',9,[]),d,[ font ]).
html_comp_i(38,'Attid',14,v,[ num ]).
html_comp_i(38,'Class','Attribute',d,[ str ]).
html_comp_i(38,'Controlname','Invoiceid',d,[ str ]).
html_comp_i(38,'Returnonclick',0,d,[ bool ]).
html_comp_i(38,'Controltype',2,d,[ num ]).
html_comp_i(38,'Inputtype',0,d,[ num ]).
html_comp_i(38,'Notifycontextchange',0,d,[ bool ]).
html_comp_i(38,'Emptyasnull','Yes',d,[ str ]).
html_comp_i(38,'Readonly',0,d,[ bool ]).
html_comp_i(38,'Autocomplete',-1,d,[ bool ]).
html_comp_i(38,'Ispassword',0,d,[ bool ]).
html_comp_i(38,'Autoresize',-1,d,[ bool ]).
html_comp_i(38,'Gxwidth',measure(6,chr),d,[ measure ]).
html_comp_i(38,'Gxheight',measure(1,row),d,[ measure ]).
html_comp_i(38,'Ismultiline',0,d,[ bool ]).
html_comp_i(38,'Fill',-1,d,[ bool ]).
html_comp_i(38,'Backcolor',rgb(255,255,255),d,[ color ]).
html_comp_i(38,'Forecolor',rgb(51,51,51),d,[ color ]).
html_comp_i(38,'Font',font('Arial',9,[]),d,[ font ]).
html_comp_i(38,'Horizontalalignment',right,d,[ str ]).
html_comp_i(38,'Gxformat',0,d,[ num ]).
html_comp_i(38,'Title','',d,[ str ]).
html_comp_i(40,'Valign',top,v,[ str ]).
html_comp_i(40,'Class',td5,v,[ str ]).
html_comp_i(41,'Caption','Date',d,[ str ]).
html_comp_i(41,'Id','Textblockinvoicedate',v,[ str ]).
html_comp_i(41,'Class','TextBlock',d,[ str ]).
html_comp_i(41,'Event','',d,[ str ]).
html_comp_i(41,'Returnonclick',0,d,[ bool ]).
html_comp_i(41,'Gxformat',0,d,[ num ]).
html_comp_i(41,'Title','',d,[ str ]).
html_comp_i(41,'Fill',-1,d,[ bool ]).
html_comp_i(41,'Backcolor',rgb(255,255,255),d,[ color ]).
html_comp_i(41,'Forecolor',rgb(116,116,116),d,[ color ]).
html_comp_i(41,'Font',font('Arial',9,[]),d,[ font ]).
html_comp_i(43,'Attid',15,v,[ num ]).
html_comp_i(43,'Class','Attribute',d,[ str ]).
html_comp_i(43,'Controlname','Invoicedate',d,[ str ]).
html_comp_i(43,'Returnonclick',0,d,[ bool ]).
html_comp_i(43,'Controltype',2,d,[ num ]).
html_comp_i(43,'Inputtype',0,d,[ num ]).
html_comp_i(43,'Notifycontextchange',0,d,[ bool ]).
html_comp_i(43,'Emptyasnull','Yes',d,[ str ]).
html_comp_i(43,'Readonly',0,d,[ bool ]).
html_comp_i(43,'Autocomplete',-1,d,[ bool ]).
html_comp_i(43,'Ispassword',0,d,[ bool ]).
html_comp_i(43,'Autoresize',-1,d,[ bool ]).
html_comp_i(43,'Gxwidth',measure(8,chr),d,[ measure ]).
html_comp_i(43,'Gxheight',measure(1,row),d,[ measure ]).
html_comp_i(43,'Ismultiline',0,d,[ bool ]).
html_comp_i(43,'Fill',-1,d,[ bool ]).
html_comp_i(43,'Backcolor',rgb(255,255,255),d,[ color ]).
html_comp_i(43,'Forecolor',rgb(51,51,51),d,[ color ]).
html_comp_i(43,'Font',font('Arial',9,[]),d,[ font ]).
html_comp_i(43,'Horizontalalignment',right,d,[ str ]).
html_comp_i(43,'Gxformat',0,d,[ num ]).
html_comp_i(43,'Title','',d,[ str ]).
html_comp_i(43,'Use_datepicker',-1,d,[ bool ]).
html_comp_i(43,'Flat_datepicker',0,d,[ bool ]).
html_comp_i(45,'Valign',top,v,[ str ]).
html_comp_i(45,'Class',td5,v,[ str ]).
html_comp_i(46,'Caption','Customer Id',d,[ str ]).
html_comp_i(46,'Id','Textblockcustomerid',v,[ str ]).
html_comp_i(46,'Class','TextBlock',d,[ str ]).
html_comp_i(46,'Event','',d,[ str ]).
html_comp_i(46,'Returnonclick',0,d,[ bool ]).
html_comp_i(46,'Gxformat',0,d,[ num ]).
html_comp_i(46,'Title','',d,[ str ]).
html_comp_i(46,'Fill',-1,d,[ bool ]).
html_comp_i(46,'Backcolor',rgb(255,255,255),d,[ color ]).
html_comp_i(46,'Forecolor',rgb(116,116,116),d,[ color ]).
html_comp_i(46,'Font',font('Arial',9,[]),d,[ font ]).
html_comp_i(48,'Attid',3,v,[ num ]).
html_comp_i(48,'Class','Attribute',d,[ str ]).
html_comp_i(48,'Controlname','Customerid',d,[ str ]).
html_comp_i(48,'Returnonclick',0,d,[ bool ]).
html_comp_i(48,'Controltype',2,d,[ num ]).
html_comp_i(48,'Inputtype',0,d,[ num ]).
html_comp_i(48,'Notifycontextchange',0,d,[ bool ]).
html_comp_i(48,'Emptyasnull','Yes',d,[ str ]).
html_comp_i(48,'Readonly',0,d,[ bool ]).
html_comp_i(48,'Autocomplete',-1,d,[ bool ]).
html_comp_i(48,'Ispassword',0,d,[ bool ]).
html_comp_i(48,'Autoresize',-1,d,[ bool ]).
html_comp_i(48,'Gxwidth',measure(6,chr),d,[ measure ]).
html_comp_i(48,'Gxheight',measure(1,row),d,[ measure ]).
html_comp_i(48,'Ismultiline',0,d,[ bool ]).
html_comp_i(48,'Fill',-1,d,[ bool ]).
html_comp_i(48,'Backcolor',rgb(255,255,255),d,[ color ]).
html_comp_i(48,'Forecolor',rgb(51,51,51),d,[ color ]).
html_comp_i(48,'Font',font('Arial',9,[]),d,[ font ]).
html_comp_i(48,'Horizontalalignment',right,d,[ str ]).
html_comp_i(48,'Gxformat',0,d,[ num ]).
html_comp_i(48,'Title','',d,[ str ]).
html_comp_i(50,'Valign',top,v,[ str ]).
html_comp_i(50,'Class',td5,v,[ str ]).
html_comp_i(51,'Caption','Customer Name',d,[ str ]).
html_comp_i(51,'Id','Textblockcustomername',v,[ str ]).
html_comp_i(51,'Class','TextBlock',d,[ str ]).
html_comp_i(51,'Event','',d,[ str ]).
html_comp_i(51,'Returnonclick',0,d,[ bool ]).
html_comp_i(51,'Gxformat',0,d,[ num ]).
html_comp_i(51,'Title','',d,[ str ]).
html_comp_i(51,'Fill',-1,d,[ bool ]).
html_comp_i(51,'Backcolor',rgb(255,255,255),d,[ color ]).
html_comp_i(51,'Forecolor',rgb(116,116,116),d,[ color ]).
html_comp_i(51,'Font',font('Arial',9,[]),d,[ font ]).
html_comp_i(53,'Attid',4,v,[ num ]).
html_comp_i(53,'Class','Attribute',d,[ str ]).
html_comp_i(53,'Controlname','Customername',d,[ str ]).
html_comp_i(53,'Returnonclick',0,d,[ bool ]).
html_comp_i(53,'Controltype',2,d,[ num ]).
html_comp_i(53,'Inputtype',0,d,[ num ]).
html_comp_i(53,'Editautocomplete',0,d,[ num ]).
html_comp_i(53,'Notifycontextchange',0,d,[ bool ]).
html_comp_i(53,'Emptyasnull','Yes',d,[ str ]).
html_comp_i(53,'Readonly',0,d,[ bool ]).
html_comp_i(53,'Autocomplete',-1,d,[ bool ]).
html_comp_i(53,'Ispassword',0,d,[ bool ]).
html_comp_i(53,'Autoresize',-1,d,[ bool ]).
html_comp_i(53,'Gxwidth',measure(30,chr),d,[ measure ]).
html_comp_i(53,'Gxheight',measure(1,row),d,[ measure ]).
html_comp_i(53,'Ismultiline',0,d,[ bool ]).
html_comp_i(53,'Fill',-1,d,[ bool ]).
html_comp_i(53,'Backcolor',rgb(255,255,255),d,[ color ]).
html_comp_i(53,'Forecolor',rgb(51,51,51),d,[ color ]).
html_comp_i(53,'Font',font('Arial',9,[]),d,[ font ]).
html_comp_i(53,'Horizontalalignment',left,d,[ str ]).
html_comp_i(53,'Gxformat',0,d,[ num ]).
html_comp_i(53,'Title','',d,[ str ]).
html_comp_i(55,'Valign',top,v,[ str ]).
html_comp_i(55,'Class',td5,v,[ str ]).
html_comp_i(55,'Height',measure(23,px),v,[ measure ]).
html_comp_i(56,'Caption','Customer Total Purchases',d,[ str ]).
html_comp_i(56,'Id','Textblockcustomertotalpurchases',v,[ str ]).
html_comp_i(56,'Class','TextBlock',d,[ str ]).
html_comp_i(56,'Event','',d,[ str ]).
html_comp_i(56,'Returnonclick',0,d,[ bool ]).
html_comp_i(56,'Gxformat',0,d,[ num ]).
html_comp_i(56,'Title','',d,[ str ]).
html_comp_i(56,'Fill',-1,d,[ bool ]).
html_comp_i(56,'Backcolor',rgb(255,255,255),d,[ color ]).
html_comp_i(56,'Forecolor',rgb(116,116,116),d,[ color ]).
html_comp_i(56,'Font',font('Arial',9,[]),d,[ font ]).
html_comp_i(58,'Attid',7,v,[ num ]).
html_comp_i(58,'Class','Attribute',d,[ str ]).
html_comp_i(58,'Controlname','Customertotalpurchases',d,[ str ]).
html_comp_i(58,'Returnonclick',0,d,[ bool ]).
html_comp_i(58,'Controltype',2,d,[ num ]).
html_comp_i(58,'Inputtype',0,d,[ num ]).
html_comp_i(58,'Notifycontextchange',0,d,[ bool ]).
html_comp_i(58,'Emptyasnull','Yes',d,[ str ]).
html_comp_i(58,'Readonly',0,d,[ bool ]).
html_comp_i(58,'Autocomplete',-1,d,[ bool ]).
html_comp_i(58,'Ispassword',0,d,[ bool ]).
html_comp_i(58,'Autoresize',-1,d,[ bool ]).
html_comp_i(58,'Gxwidth',measure(9,chr),d,[ measure ]).
html_comp_i(58,'Gxheight',measure(1,row),d,[ measure ]).
html_comp_i(58,'Ismultiline',0,d,[ bool ]).
html_comp_i(58,'Fill',-1,d,[ bool ]).
html_comp_i(58,'Backcolor',rgb(255,255,255),d,[ color ]).
html_comp_i(58,'Forecolor',rgb(51,51,51),d,[ color ]).
html_comp_i(58,'Font',font('Arial',9,[]),d,[ font ]).
html_comp_i(58,'Horizontalalignment',right,d,[ str ]).
html_comp_i(58,'Gxformat',0,d,[ num ]).
html_comp_i(58,'Title','',d,[ str ]).
html_comp_i(60,'Height',measure(23,px),v,[ measure ]).
html_comp_i(61,'Caption','Customer Balance',d,[ str ]).
html_comp_i(61,'Id','Textblockcustomertotalpurchases2',v,[ str ]).
html_comp_i(61,'Class','TextBlock',d,[ str ]).
html_comp_i(61,'Event','',d,[ str ]).
html_comp_i(61,'Returnonclick',0,d,[ bool ]).
html_comp_i(61,'Gxformat',0,d,[ num ]).
html_comp_i(61,'Title','',d,[ str ]).
html_comp_i(61,'Fill',-1,d,[ bool ]).
html_comp_i(61,'Backcolor',rgb(255,255,255),d,[ color ]).
html_comp_i(61,'Forecolor',rgb(116,116,116),d,[ color ]).
html_comp_i(61,'Font',font('Arial',9,[]),d,[ font ]).
html_comp_i(63,'Attid',9,v,[ num ]).
html_comp_i(63,'Class','Attribute',d,[ str ]).
html_comp_i(63,'Controlname','Customerbalance',d,[ str ]).
html_comp_i(63,'Returnonclick',0,d,[ bool ]).
html_comp_i(63,'Controltype',2,d,[ num ]).
html_comp_i(63,'Inputtype',0,d,[ num ]).
html_comp_i(63,'Notifycontextchange',0,d,[ bool ]).
html_comp_i(63,'Emptyasnull','Yes',d,[ str ]).
html_comp_i(63,'Readonly',0,d,[ bool ]).
html_comp_i(63,'Autocomplete',-1,d,[ bool ]).
html_comp_i(63,'Ispassword',0,d,[ bool ]).
html_comp_i(63,'Autoresize',-1,d,[ bool ]).
html_comp_i(63,'Gxwidth',measure(9,chr),d,[ measure ]).
html_comp_i(63,'Gxheight',measure(1,row),d,[ measure ]).
html_comp_i(63,'Ismultiline',0,d,[ bool ]).
html_comp_i(63,'Fill',-1,d,[ bool ]).
html_comp_i(63,'Backcolor',rgb(255,255,255),d,[ color ]).
html_comp_i(63,'Forecolor',rgb(51,51,51),d,[ color ]).
html_comp_i(63,'Font',font('Arial',9,[]),d,[ font ]).
html_comp_i(63,'Horizontalalignment',right,d,[ str ]).
html_comp_i(63,'Gxformat',0,d,[ num ]).
html_comp_i(63,'Title','',d,[ str ]).
html_comp_i(65,'Height',measure(16,px),v,[ measure ]).
html_comp_i(66,'Caption','Country Id',d,[ str ]).
html_comp_i(66,'Id','Textblockcustomertotalpurchases3',v,[ str ]).
html_comp_i(66,'Class','TextBlock',d,[ str ]).
html_comp_i(66,'Event','',d,[ str ]).
html_comp_i(66,'Returnonclick',0,d,[ bool ]).
html_comp_i(66,'Gxformat',0,d,[ num ]).
html_comp_i(66,'Title','',d,[ str ]).
html_comp_i(66,'Fill',-1,d,[ bool ]).
html_comp_i(66,'Backcolor',rgb(255,255,255),d,[ color ]).
html_comp_i(66,'Forecolor',rgb(116,116,116),d,[ color ]).
html_comp_i(66,'Font',font('Arial',9,[]),d,[ font ]).
html_comp_i(68,'Attid',1,v,[ num ]).
html_comp_i(68,'Class','Attribute',d,[ str ]).
html_comp_i(68,'Controlname','Countryid',d,[ str ]).
html_comp_i(68,'Returnonclick',0,d,[ bool ]).
html_comp_i(68,'Controltype',2,d,[ num ]).
html_comp_i(68,'Inputtype',1,v,[ num ]).
html_comp_i(68,'Controlitemvalues',1,d,[ num ]).
html_comp_i(68,'Controlitemdescription',2,v,[ num ]).
html_comp_i(68,'Editautocomplete',2,v,[ num ]).
html_comp_i(68,'Filteroperator',0,d,[ num ]).
html_comp_i(68,'Maxitems',5,d,[ num ]).
html_comp_i(68,'Controlsortdescription',-1,d,[ bool ]).
html_comp_i(68,'Casesensitive',0,d,[ bool ]).
html_comp_i(68,'Controlwhere','$[]$',v,[ str ]).
html_comp_i(68,'Controlrestrictedby','',d,[ str ]).
html_comp_i(68,'Notifycontextchange',0,d,[ bool ]).
html_comp_i(68,'Emptyasnull','Yes',d,[ str ]).
html_comp_i(68,'Readonly',0,d,[ bool ]).
html_comp_i(68,'Ispassword',0,d,[ bool ]).
html_comp_i(68,'Autoresize',-1,d,[ bool ]).
html_comp_i(68,'Gxwidth',measure(30,chr),d,[ measure ]).
html_comp_i(68,'Gxheight',measure(1,row),d,[ measure ]).
html_comp_i(68,'Ismultiline',0,d,[ bool ]).
html_comp_i(68,'Fill',-1,d,[ bool ]).
html_comp_i(68,'Backcolor',rgb(255,255,255),d,[ color ]).
html_comp_i(68,'Forecolor',rgb(51,51,51),d,[ color ]).
html_comp_i(68,'Font',font('Arial',9,[]),d,[ font ]).
html_comp_i(68,'Horizontalalignment',left,d,[ str ]).
html_comp_i(68,'Gxformat',0,d,[ num ]).
html_comp_i(68,'Title','',d,[ str ]).
html_comp_i(70,'Height',measure(197,px),v,[ measure ]).
html_comp_i(70,'Colspan',2,v,[ num ]).
html_comp_i(71,'Id','Table3',v,[ str ]).
html_comp_i(71,'Class','Table95',v,[ str ]).
html_comp_i(71,'Title','',d,[ str ]).
html_comp_i(71,'Align',left,d,[ str ]).
html_comp_i(71,'Backgroundgx','',d,[ str ]).
html_comp_i(71,'Bgcolor',rgb(0,0,0),d,[ color ]).
html_comp_i(71,'Border','0',d,[ str ]).
html_comp_i(71,'Bordercolor',rgb(0,0,0),d,[ color ]).
html_comp_i(71,'Cellpadding','1',d,[ str ]).
html_comp_i(71,'Cellspacing','2',d,[ str ]).
html_comp_i(71,'Height',measure(0,px),d,[ measure ]).
html_comp_i(71,'Width',measure(0,px),d,[ measure ]).
html_comp_i(71,'Rules',none,d,[ str ]).
html_comp_i(73,'Class','SubTitle',v,[ str ]).
html_comp_i(74,'Caption','Detail',d,[ str ]).
html_comp_i(74,'Id','Titledetail',v,[ str ]).
html_comp_i(74,'Event','',d,[ str ]).
html_comp_i(74,'Returnonclick',0,d,[ bool ]).
html_comp_i(74,'Gxformat',0,d,[ num ]).
html_comp_i(74,'Title','',d,[ str ]).
html_comp_i(74,'Fill',-1,d,[ bool ]).
html_comp_i(74,'Backcolor',rgb(255,255,255),d,[ color ]).
html_comp_i(74,'Forecolor',rgb(0,0,0),d,[ color ]).
html_comp_i(74,'Font','',d,[ str ]).
html_comp_i(75,'Controlname','Gridinvoice_detail',v,[ str ]).
html_comp_i(75,'Iddataselector','',d,[ str ]).
html_comp_i(75,'Rules',none,d,[ str ]).
html_comp_i(75,'Sflrender','',d,[ str ]).
html_comp_i(75,'Class','Grid',d,[ str ]).
html_comp_i(75,'Autoresize',-1,d,[ bool ]).
html_comp_i(75,'Gxwidth',measure(0,px),d,[ measure ]).
html_comp_i(75,'Gxheight',measure(0,px),d,[ measure ]).
html_comp_i(75,'Backgroundgx','',d,[ str ]).
html_comp_i(75,'Border','0',d,[ str ]).
html_comp_i(75,'Backcolorstyle',2,v,[ num ]).
html_comp_i(75,'Bordercolor',rgb(255,255,255),d,[ color ]).
html_comp_i(75,'Maxrows',5,d,[ num ]).
html_comp_i(75,'Title','',d,[ str ]).
html_comp_i(75,'Linescolor',rgb(0,0,0),d,[ color ]).
html_comp_i(75,'Linesbackcolor',rgb(240,240,240),d,[ color ]).
html_comp_i(75,'Linesfont',font('Microsoft Sans Serif',8,[]),d,[ font ]).
html_comp_i(75,'Titlecolor',rgb(255,255,255),d,[ color ]).
html_comp_i(75,'Titlebackcolor',rgb(157,31,31),d,[ color ]).
html_comp_i(75,'Titlefont',font('Arial',10,[ bold ]),d,[ font ]).
html_comp_i(75,'Align',left,d,[ str ]).
html_comp_i(75,'Cellpadding','1',d,[ str ]).
html_comp_i(75,'Cellspacing','2',d,[ str ]).
html_comp_i(75,'Sortable',-1,d,[ bool ]).
html_comp_i(75,'Allowdrop',0,d,[ bool ]).
html_comp_i(75,'Allowdrag',0,d,[ bool ]).
html_comp_i(75,'Notifycontextchange',0,d,[ bool ]).
html_comp_i(75,'Allowcollapsing',0,d,[ bool ]).
html_comp_i(75,'Allowselection',0,d,[ bool ]).
html_comp_i(76,'Colattid',17,v,[ num ]).
html_comp_i(76,'Controlname','Invoicedetailid',d,[ str ]).
html_comp_i(76,'Class','Attribute',d,[ str ]).
html_comp_i(76,'Returnonclick',0,d,[ bool ]).
html_comp_i(76,'Controltype',2,d,[ num ]).
html_comp_i(76,'Inputtype',0,d,[ num ]).
html_comp_i(76,'Notifycontextchange',0,d,[ bool ]).
html_comp_i(76,'Colreadonly',0,d,[ bool ]).
html_comp_i(76,'Autocomplete',-1,d,[ bool ]).
html_comp_i(76,'Emptyasnull','Yes',d,[ str ]).
html_comp_i(76,'Ispassword',0,d,[ bool ]).
html_comp_i(76,'Colautoresize',-1,d,[ bool ]).
html_comp_i(76,'Colwidth',measure(0,px),d,[ measure ]).
html_comp_i(76,'Height',measure(17,px),d,[ measure ]).
html_comp_i(76,'Collinesfont',font('Microsoft Sans Serif',8,[]),d,[ font ]).
html_comp_i(76,'Collinescolor',rgb(0,0,0),d,[ color ]).
html_comp_i(76,'Coltitle','Identifier',d,[ str ]).
html_comp_i(76,'Coltitlefont',font('Arial',10,[ bold ]),d,[ font ]).
html_comp_i(76,'Coltitlecolor',rgb(255,255,255),d,[ color ]).
html_comp_i(76,'Horizontalalignment',right,d,[ str ]).
html_comp_i(76,'Gxformat',0,d,[ num ]).
html_comp_i(76,'Colvisible',-1,v,[ bool ]).
html_comp_i(76,'Title','',d,[ str ]).
html_comp_i(77,'Colattid',10,v,[ num ]).
html_comp_i(77,'Controlname','Productid',d,[ str ]).
html_comp_i(77,'Class','Attribute',d,[ str ]).
html_comp_i(77,'Returnonclick',0,d,[ bool ]).
html_comp_i(77,'Controltype',2,d,[ num ]).
html_comp_i(77,'Inputtype',0,d,[ num ]).
html_comp_i(77,'Notifycontextchange',0,d,[ bool ]).
html_comp_i(77,'Colreadonly',0,d,[ bool ]).
html_comp_i(77,'Autocomplete',-1,d,[ bool ]).
html_comp_i(77,'Emptyasnull','Yes',d,[ str ]).
html_comp_i(77,'Ispassword',0,d,[ bool ]).
html_comp_i(77,'Colautoresize',-1,d,[ bool ]).
html_comp_i(77,'Colwidth',measure(0,px),d,[ measure ]).
html_comp_i(77,'Height',measure(17,px),d,[ measure ]).
html_comp_i(77,'Collinesfont',font('Microsoft Sans Serif',8,[]),d,[ font ]).
html_comp_i(77,'Collinescolor',rgb(0,0,0),d,[ color ]).
html_comp_i(77,'Coltitle','Product Identifier',d,[ str ]).
html_comp_i(77,'Coltitlefont',font('Arial',10,[ bold ]),d,[ font ]).
html_comp_i(77,'Coltitlecolor',rgb(255,255,255),d,[ color ]).
html_comp_i(77,'Horizontalalignment',right,d,[ str ]).
html_comp_i(77,'Gxformat',0,d,[ num ]).
html_comp_i(77,'Colvisible',-1,d,[ bool ]).
html_comp_i(77,'Title','',d,[ str ]).
html_comp_i(78,'Colattid',11,v,[ num ]).
html_comp_i(78,'Controlname','Productdescription',d,[ str ]).
html_comp_i(78,'Class','Attribute',d,[ str ]).
html_comp_i(78,'Returnonclick',0,d,[ bool ]).
html_comp_i(78,'Controltype',2,d,[ num ]).
html_comp_i(78,'Inputtype',0,d,[ num ]).
html_comp_i(78,'Editautocomplete',0,d,[ num ]).
html_comp_i(78,'Notifycontextchange',0,d,[ bool ]).
html_comp_i(78,'Colreadonly',0,d,[ bool ]).
html_comp_i(78,'Autocomplete',-1,d,[ bool ]).
html_comp_i(78,'Emptyasnull','Yes',d,[ str ]).
html_comp_i(78,'Ispassword',0,d,[ bool ]).
html_comp_i(78,'Colautoresize',-1,d,[ bool ]).
html_comp_i(78,'Colwidth',measure(0,px),d,[ measure ]).
html_comp_i(78,'Height',measure(17,px),d,[ measure ]).
html_comp_i(78,'Collinesfont',font('Microsoft Sans Serif',8,[]),d,[ font ]).
html_comp_i(78,'Collinescolor',rgb(0,0,0),d,[ color ]).
html_comp_i(78,'Coltitle','Product Description',d,[ str ]).
html_comp_i(78,'Coltitlefont',font('Arial',10,[ bold ]),d,[ font ]).
html_comp_i(78,'Coltitlecolor',rgb(255,255,255),d,[ color ]).
html_comp_i(78,'Horizontalalignment',left,d,[ str ]).
html_comp_i(78,'Gxformat',0,d,[ num ]).
html_comp_i(78,'Colvisible',-1,d,[ bool ]).
html_comp_i(78,'Title','',d,[ str ]).
html_comp_i(79,'Colattid',13,v,[ num ]).
html_comp_i(79,'Controlname','Productprice',d,[ str ]).
html_comp_i(79,'Class','Attribute',d,[ str ]).
html_comp_i(79,'Returnonclick',0,d,[ bool ]).
html_comp_i(79,'Controltype',2,d,[ num ]).
html_comp_i(79,'Inputtype',0,d,[ num ]).
html_comp_i(79,'Notifycontextchange',0,d,[ bool ]).
html_comp_i(79,'Colreadonly',0,d,[ bool ]).
html_comp_i(79,'Autocomplete',-1,d,[ bool ]).
html_comp_i(79,'Emptyasnull','Yes',d,[ str ]).
html_comp_i(79,'Ispassword',0,d,[ bool ]).
html_comp_i(79,'Colautoresize',-1,d,[ bool ]).
html_comp_i(79,'Colwidth',measure(0,px),d,[ measure ]).
html_comp_i(79,'Height',measure(17,px),d,[ measure ]).
html_comp_i(79,'Collinesfont',font('Microsoft Sans Serif',8,[]),d,[ font ]).
html_comp_i(79,'Collinescolor',rgb(0,0,0),d,[ color ]).
html_comp_i(79,'Coltitle','Product Price',d,[ str ]).
html_comp_i(79,'Coltitlefont',font('Arial',10,[ bold ]),d,[ font ]).
html_comp_i(79,'Coltitlecolor',rgb(255,255,255),d,[ color ]).
html_comp_i(79,'Horizontalalignment',right,d,[ str ]).
html_comp_i(79,'Gxformat',0,d,[ num ]).
html_comp_i(79,'Colvisible',-1,d,[ bool ]).
html_comp_i(79,'Title','',d,[ str ]).
html_comp_i(80,'Colattid',18,v,[ num ]).
html_comp_i(80,'Controlname','Invoicedetailquantiity',d,[ str ]).
html_comp_i(80,'Class','Attribute',d,[ str ]).
html_comp_i(80,'Returnonclick',0,d,[ bool ]).
html_comp_i(80,'Controltype',2,d,[ num ]).
html_comp_i(80,'Inputtype',0,d,[ num ]).
html_comp_i(80,'Notifycontextchange',0,d,[ bool ]).
html_comp_i(80,'Colreadonly',0,d,[ bool ]).
html_comp_i(80,'Autocomplete',-1,d,[ bool ]).
html_comp_i(80,'Emptyasnull','Yes',d,[ str ]).
html_comp_i(80,'Ispassword',0,d,[ bool ]).
html_comp_i(80,'Colautoresize',-1,d,[ bool ]).
html_comp_i(80,'Colwidth',measure(0,px),d,[ measure ]).
html_comp_i(80,'Height',measure(17,px),d,[ measure ]).
html_comp_i(80,'Collinesfont',font('Microsoft Sans Serif',8,[]),d,[ font ]).
html_comp_i(80,'Collinescolor',rgb(0,0,0),d,[ color ]).
html_comp_i(80,'Coltitle','Detail Quantiity',d,[ str ]).
html_comp_i(80,'Coltitlefont',font('Arial',10,[ bold ]),d,[ font ]).
html_comp_i(80,'Coltitlecolor',rgb(255,255,255),d,[ color ]).
html_comp_i(80,'Horizontalalignment',right,d,[ str ]).
html_comp_i(80,'Gxformat',0,d,[ num ]).
html_comp_i(80,'Colvisible',-1,d,[ bool ]).
html_comp_i(80,'Title','',d,[ str ]).
html_comp_i(81,'Colattid',19,v,[ num ]).
html_comp_i(81,'Controlname','Invoicedetailamount',d,[ str ]).
html_comp_i(81,'Class','Attribute',d,[ str ]).
html_comp_i(81,'Returnonclick',0,d,[ bool ]).
html_comp_i(81,'Controltype',2,d,[ num ]).
html_comp_i(81,'Inputtype',0,d,[ num ]).
html_comp_i(81,'Notifycontextchange',0,d,[ bool ]).
html_comp_i(81,'Colreadonly',0,d,[ bool ]).
html_comp_i(81,'Autocomplete',-1,d,[ bool ]).
html_comp_i(81,'Emptyasnull','Yes',d,[ str ]).
html_comp_i(81,'Ispassword',0,d,[ bool ]).
html_comp_i(81,'Colautoresize',-1,d,[ bool ]).
html_comp_i(81,'Colwidth',measure(0,px),d,[ measure ]).
html_comp_i(81,'Height',measure(17,px),d,[ measure ]).
html_comp_i(81,'Collinesfont',font('Microsoft Sans Serif',8,[]),d,[ font ]).
html_comp_i(81,'Collinescolor',rgb(0,0,0),d,[ color ]).
html_comp_i(81,'Coltitle','Detail Amount',d,[ str ]).
html_comp_i(81,'Coltitlefont',font('Arial',10,[ bold ]),d,[ font ]).
html_comp_i(81,'Coltitlecolor',rgb(255,255,255),d,[ color ]).
html_comp_i(81,'Horizontalalignment',right,d,[ str ]).
html_comp_i(81,'Gxformat',0,d,[ num ]).
html_comp_i(81,'Colvisible',-1,d,[ bool ]).
html_comp_i(81,'Title','',d,[ str ]).
html_comp_i(83,'Valign',top,v,[ str ]).
html_comp_i(83,'Class',td5,v,[ str ]).
html_comp_i(83,'Height',measure(23,px),v,[ measure ]).
html_comp_i(84,'Caption','Amount',d,[ str ]).
html_comp_i(84,'Id','Textblockinvoiceamount',v,[ str ]).
html_comp_i(84,'Class','TextBlock',d,[ str ]).
html_comp_i(84,'Event','',d,[ str ]).
html_comp_i(84,'Returnonclick',0,d,[ bool ]).
html_comp_i(84,'Gxformat',0,d,[ num ]).
html_comp_i(84,'Title','',d,[ str ]).
html_comp_i(84,'Fill',-1,d,[ bool ]).
html_comp_i(84,'Backcolor',rgb(255,255,255),d,[ color ]).
html_comp_i(84,'Forecolor',rgb(116,116,116),d,[ color ]).
html_comp_i(84,'Font',font('Arial',9,[]),d,[ font ]).
html_comp_i(86,'Attid',16,v,[ num ]).
html_comp_i(86,'Class','Attribute',d,[ str ]).
html_comp_i(86,'Controlname','Invoiceamount',d,[ str ]).
html_comp_i(86,'Returnonclick',0,d,[ bool ]).
html_comp_i(86,'Controltype',2,d,[ num ]).
html_comp_i(86,'Inputtype',0,d,[ num ]).
html_comp_i(86,'Notifycontextchange',0,d,[ bool ]).
html_comp_i(86,'Emptyasnull','Yes',d,[ str ]).
html_comp_i(86,'Readonly',0,d,[ bool ]).
html_comp_i(86,'Autocomplete',-1,d,[ bool ]).
html_comp_i(86,'Ispassword',0,d,[ bool ]).
html_comp_i(86,'Autoresize',-1,d,[ bool ]).
html_comp_i(86,'Gxwidth',measure(9,chr),d,[ measure ]).
html_comp_i(86,'Gxheight',measure(1,row),d,[ measure ]).
html_comp_i(86,'Ismultiline',0,d,[ bool ]).
html_comp_i(86,'Fill',-1,d,[ bool ]).
html_comp_i(86,'Backcolor',rgb(255,255,255),d,[ color ]).
html_comp_i(86,'Forecolor',rgb(51,51,51),d,[ color ]).
html_comp_i(86,'Font',font('Arial',9,[]),d,[ font ]).
html_comp_i(86,'Horizontalalignment',right,d,[ str ]).
html_comp_i(86,'Gxformat',0,d,[ num ]).
html_comp_i(86,'Title','',d,[ str ]).
html_comp_i(89,'Controlname','Btn_enter',v,[ str ]).
html_comp_i(89,'Class','BtnEnter',v,[ str ]).
html_comp_i(89,'Event','Enter',v,[ str ]).
html_comp_i(89,'Caption','Confirm',d,[ str ]).
html_comp_i(89,'Title','Confirm',d,[ str ]).
html_comp_i(89,'Type',0,d,[ num ]).
html_comp_i(89,'Font',font('Verdana',8,[]),d,[ font ]).
html_comp_i(89,'Forecolor',rgb(157,31,31),d,[ color ]).
html_comp_i(89,'Backcolor',rgb(159,159,159),d,[ color ]).
html_comp_i(89,'Border','0',d,[ str ]).
html_comp_i(89,'Bordercolor',rgb(121,121,121),d,[ color ]).
html_comp_i(89,'Buttonborderstyle',rounded,d,[ str ]).
html_comp_i(90,'Controlname','Btn_cancel',v,[ str ]).
html_comp_i(90,'Class','BtnCancel',v,[ str ]).
html_comp_i(90,'Event','Cancel',v,[ str ]).
html_comp_i(90,'Caption','Cancel',d,[ str ]).
html_comp_i(90,'Title','Cancel',d,[ str ]).
html_comp_i(90,'Type',0,d,[ num ]).
html_comp_i(90,'Font',font('Verdana',8,[]),d,[ font ]).
html_comp_i(90,'Forecolor',rgb(157,31,31),d,[ color ]).
html_comp_i(90,'Backcolor',rgb(159,159,159),d,[ color ]).
html_comp_i(90,'Border','0',d,[ str ]).
html_comp_i(90,'Bordercolor',rgb(121,121,121),d,[ color ]).
html_comp_i(90,'Buttonborderstyle',rounded,d,[ str ]).
html_comp_i(91,'Controlname','Btn_delete',v,[ str ]).
html_comp_i(91,'Class','BtnDelete',v,[ str ]).
html_comp_i(91,'Event','Delete',v,[ str ]).
html_comp_i(91,'Caption','Delete',d,[ str ]).
html_comp_i(91,'Title','Delete',d,[ str ]).
html_comp_i(91,'Type',0,d,[ num ]).
html_comp_i(91,'Font',font('Verdana',8,[]),d,[ font ]).
html_comp_i(91,'Forecolor',rgb(157,31,31),d,[ color ]).
html_comp_i(91,'Backcolor',rgb(159,159,159),d,[ color ]).
html_comp_i(91,'Border','0',d,[ str ]).
html_comp_i(91,'Bordercolor',rgb(121,121,121),d,[ color ]).
html_comp_i(91,'Buttonborderstyle',rounded,d,[ str ]).
 
 
 
 
 
 
warn_gen_i(msg([],spc0033,[ '',att(2,3),' will be read-only in update mode.' ])).
warn_gen_i(msg([],spc0033,[ '',att(2,10),' will be read-only in update mode.' ])).
warn_gen_i(msg([],spc0170,[ 'Attribute ',att(2,1),' will be empty when the value of description attribute ',att(2,2),' does not exist in table ',tbl(2,1),'.' ])).
 
lit_i(8,1,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-42'),[ ctlname('Btn_first') ]).
lit_i(9,1,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-60'),[ ctlname('Btn_first_separator') ]).
lit_i(10,1,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-48'),[ ctlname('Btn_previous') ]).
lit_i(11,1,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-60'),[ ctlname('Btn_previous_separator') ]).
lit_i(12,1,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-47'),[ ctlname('Btn_next') ]).
lit_i(13,1,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-60'),[ ctlname('Btn_next_separator') ]).
lit_i(14,1,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-44'),[ ctlname('Btn_last') ]).
lit_i(15,1,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-60'),[ ctlname('Btn_last_separator') ]).
lit_i(16,1,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-55'),[ ctlname('Btn_select') ]).
lit_i(17,1,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-60'),[ ctlname('Btn_select_separator') ]).
lit_i(18,1,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-54'),[ ctlname('Btn_enter2') ]).
lit_i(19,1,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-60'),[ ctlname('Btn_enter2_separator') ]).
lit_i(20,1,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-40'),[ ctlname('Btn_cancel2') ]).
lit_i(21,1,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-60'),[ ctlname('Btn_cancel2_separator') ]).
lit_i(22,1,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-28'),[ ctlname('Btn_delete2') ]).
lit_i(23,1,bitmap('9fb193d9-64a4-4d30-b129-ff7c76830f7e-60'),[ ctlname('Btn_delete2_separator') ]).
lit_i(5,1,table(5),[ ctlname('Tabletoolbar') ]).
lit_i(30,1,comp(errview),[ ctlname('Ctlerror'),width(0),rect(0,0,10,10),title('Nothing') ]).
lit_i(36,1,t('Id',3),[ ctlname('Textblockinvoiceid') ]).
lit_i(38,1,t(14,2),[ ctlname(14),ctrltype(edit,38),pos(38),ispwd(0),e2n(1),width(0),rect(0,0,10,10),title('Nothing') ]).
lit_i(41,1,t('Date',3),[ ctlname('Textblockinvoicedate') ]).
lit_i(43,1,t(15,2),[ ctlname(15),ctrltype(edit,43),pos(43),ispwd(0),e2n(1),width(0),rect(0,0,10,10),title('Nothing') ]).
lit_i(46,1,t('Customer Id',3),[ ctlname('Textblockcustomerid') ]).
lit_i(48,1,t(3,2),[ ctlname(3),ctrltype(edit,48),pos(48),ispwd(0),e2n(1),width(0),rect(0,0,10,10),title('Nothing') ]).
lit_i(51,1,t('Customer Name',3),[ ctlname('Textblockcustomername') ]).
lit_i(53,1,t(4,2),[ ctlname(4),ctrltype(edit,53),pos(53),ispwd(0),e2n(1),width(0),rect(0,0,10,10),title('Nothing') ]).
lit_i(56,1,t('Customer Total Purchases',3),[ ctlname('Textblockcustomertotalpurchases') ]).
lit_i(58,1,t(7,2),[ ctlname(7),ctrltype(edit,58),pos(58),ispwd(0),e2n(1),width(0),rect(0,0,10,10),title('Nothing') ]).
lit_i(61,1,t('Customer Balance',3),[ ctlname('Textblockcustomertotalpurchases2') ]).
lit_i(63,1,t(9,2),[ ctlname(9),ctrltype(edit,63),pos(63),ispwd(0),e2n(1),width(0),rect(0,0,10,10),title('Nothing') ]).
lit_i(66,1,t('Country Id',3),[ ctlname('Textblockcustomertotalpurchases3') ]).
lit_i(68,1,t(1,2),[ ctlname(1),ctrltype(edit,68),pos(68),ispwd(0),e2n(1),width(0),rect(0,0,10,10),title('Nothing') ]).
lit_i(74,1,t('Detail',3),[ ctlname('Titledetail') ]).
lit_i(71,1,table(71),[ ctlname('Table3') ]).
lit_i(76,1,s(t(17,2),75),[ ctlname(17),ctrltype(edit,76),pos(76),ispwd(0),e2n(1),width(0),rect(0,0,10,10),title('Nothing') ]).
lit_i(77,1,s(t(10,2),75),[ ctlname(10),ctrltype(edit,77),pos(77),ispwd(0),e2n(1),width(0),rect(0,0,10,10),title('Nothing') ]).
lit_i(78,1,s(t(11,2),75),[ ctlname(11),ctrltype(edit,78),pos(78),ispwd(0),e2n(1),width(0),rect(0,0,10,10),title('Nothing') ]).
lit_i(79,1,s(t(13,2),75),[ ctlname(13),ctrltype(edit,79),pos(79),ispwd(0),e2n(1),width(0),rect(0,0,10,10),title('Nothing') ]).
lit_i(80,1,s(t(18,2),75),[ ctlname(18),ctrltype(edit,80),pos(80),ispwd(0),e2n(1),width(0),rect(0,0,10,10),title('Nothing') ]).
lit_i(81,1,s(t(19,2),75),[ ctlname(19),ctrltype(edit,81),pos(81),ispwd(0),e2n(1),width(0),rect(0,0,10,10),title('Nothing') ]).
lit_i(75,1,s(75),[ ctlname('Gridinvoice_detail'),el([ t(17,2),t(10,2),t(11,2),t(13,2),t(18,2),t(19,2) ]),width(0),rect(0,0,10,10),title('Nothing') ]).
lit_i(84,1,t('Amount',3),[ ctlname('Textblockinvoiceamount') ]).
lit_i(86,1,t(16,2),[ ctlname(16),ctrltype(edit,86),pos(86),ispwd(0),e2n(1),width(0),rect(0,0,10,10),title('Nothing') ]).
lit_i(33,1,table(33),[ ctlname('Table2') ]).
lit_i(89,1,button('Enter'),[ ctlname('Btn_enter'),width(0),rect(0,0,10,10),title('Nothing') ]).
lit_i(90,1,button('Cancel'),[ ctlname('Btn_cancel'),width(0),rect(0,0,10,10),title('Nothing') ]).
lit_i(91,1,button('Delete'),[ ctlname('Btn_delete'),width(0),rect(0,0,10,10),title('Nothing') ]).
lit_i(27,1,table(27),[ ctlname('Table1') ]).
lit_i(26,1,group(26),[ ctlname('Groupdata') ]).
lit_i(2,1,table(2),[ ctlname('Tablemain') ]).
lit_i(1,1,window,[ rect(0,0,1000,1000),ctlname('Form') ]).
 
 
 
 
 
 
 
 
 
att_prop_i(2,14,'ExternalName','InvoiceId',d).
att_prop_i(2,14,'ExternalNamespace','BillingSystem',d).
att_prop_i(2,14,'EmptyAsNull','Yes',d).
att_prop_i(2,14,'AUTONUMBER','-1',d).
att_prop_i(2,14,'AUTONUMBER_START','1',d).
att_prop_i(2,14,'AUTONUMBER_STEP','1',d).
att_prop_i(2,14,'AUTONUMBER_FORREPLICATION','-1',d).
att_prop_i(2,14,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,14,'AttRegEx','',d).
att_prop_i(2,14,'AttValidationFailedMsg','',d).
att_prop_i(2,14,'FullName','InvoiceId',v).
att_prop_i(2,15,'ExternalName','InvoiceDate',d).
att_prop_i(2,15,'ExternalNamespace','BillingSystem',d).
att_prop_i(2,15,'EmptyAsNull','Yes',d).
att_prop_i(2,15,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,15,'AttRegEx','',d).
att_prop_i(2,15,'AttValidationFailedMsg','',d).
att_prop_i(2,15,idDATEFORMAT,idDATEFORMAT_SHORT,d).
att_prop_i(2,15,'FullName','InvoiceDate',v).
att_prop_i(2,3,'ExternalName','CustomerId',d).
att_prop_i(2,3,'ExternalNamespace','BillingSystem',d).
att_prop_i(2,3,'EmptyAsNull','Yes',d).
att_prop_i(2,3,'AUTONUMBER','-1',d).
att_prop_i(2,3,'AUTONUMBER_START','1',d).
att_prop_i(2,3,'AUTONUMBER_STEP','1',d).
att_prop_i(2,3,'AUTONUMBER_FORREPLICATION','-1',d).
att_prop_i(2,3,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,3,'AttRegEx','',d).
att_prop_i(2,3,'AttValidationFailedMsg','',d).
att_prop_i(2,3,'FullName','CustomerId',v).
att_prop_i(2,4,'ExternalName','CustomerName',d).
att_prop_i(2,4,'ExternalNamespace','BillingSystem',d).
att_prop_i(2,4,'EmptyAsNull','Yes',d).
att_prop_i(2,4,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,4,'DB_NLS_SUPPORT','No',d).
att_prop_i(2,4,'AttRegEx','',d).
att_prop_i(2,4,'AttValidationFailedMsg','',d).
att_prop_i(2,4,'FullName','CustomerName',v).
att_prop_i(2,7,'ExternalName','CustomerTotalPurchases',d).
att_prop_i(2,7,'ExternalNamespace','BillingSystem',d).
att_prop_i(2,7,'EmptyAsNull','Yes',d).
att_prop_i(2,7,'AUTONUMBER','0',d).
att_prop_i(2,7,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,7,'AttRegEx','',d).
att_prop_i(2,7,'AttValidationFailedMsg','',d).
att_prop_i(2,7,'FullName','CustomerTotalPurchases',v).
att_prop_i(2,9,'ExternalName','CustomerBalance',d).
att_prop_i(2,9,'ExternalNamespace','BillingSystem',d).
att_prop_i(2,9,'EmptyAsNull','Yes',d).
att_prop_i(2,9,'AUTONUMBER','0',d).
att_prop_i(2,9,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,9,'AttRegEx','',d).
att_prop_i(2,9,'AttValidationFailedMsg','',d).
att_prop_i(2,9,'FullName','CustomerBalance',v).
att_prop_i(2,20,'ExternalName','InvoiceLastLineId',d).
att_prop_i(2,20,'ExternalNamespace','BillingSystem',d).
att_prop_i(2,20,'EmptyAsNull','Yes',v).
att_prop_i(2,20,'AUTONUMBER','0',d).
att_prop_i(2,20,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,20,'AttRegEx','',d).
att_prop_i(2,20,'AttValidationFailedMsg','',d).
att_prop_i(2,20,'FullName','InvoiceLastLineId',v).
att_prop_i(2,1,'ExternalName','CountryId',d).
att_prop_i(2,1,'ExternalNamespace','BillingSystem',d).
att_prop_i(2,1,'EmptyAsNull','Yes',d).
att_prop_i(2,1,'AUTONUMBER','-1',v).
att_prop_i(2,1,'AUTONUMBER_START','1',d).
att_prop_i(2,1,'AUTONUMBER_STEP','1',d).
att_prop_i(2,1,'AUTONUMBER_FORREPLICATION','-1',d).
att_prop_i(2,1,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,1,'AttRegEx','',d).
att_prop_i(2,1,'AttValidationFailedMsg','',d).
att_prop_i(2,1,'FullName','CountryId',v).
att_prop_i(2,2,'ExternalName','CountryName',d).
att_prop_i(2,2,'ExternalNamespace','BillingSystem',d).
att_prop_i(2,2,'EmptyAsNull','Yes',d).
att_prop_i(2,2,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,2,'DB_NLS_SUPPORT','No',d).
att_prop_i(2,2,'AttRegEx','',d).
att_prop_i(2,2,'AttValidationFailedMsg','',d).
att_prop_i(2,2,'FullName','CountryName',v).
att_prop_i(2,16,'ExternalName','InvoiceAmount',d).
att_prop_i(2,16,'ExternalNamespace','BillingSystem',d).
att_prop_i(2,16,'EmptyAsNull','Yes',d).
att_prop_i(2,16,'AUTONUMBER','0',d).
att_prop_i(2,16,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,16,'AttRegEx','',d).
att_prop_i(2,16,'AttValidationFailedMsg','',d).
att_prop_i(2,16,'FullName','InvoiceAmount',v).
att_prop_i(2,17,'ExternalName','InvoiceDetailId',d).
att_prop_i(2,17,'ExternalNamespace','BillingSystem',d).
att_prop_i(2,17,'EmptyAsNull','Yes',d).
att_prop_i(2,17,'AUTONUMBER','0',d).
att_prop_i(2,17,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,17,'AttRegEx','',d).
att_prop_i(2,17,'AttValidationFailedMsg','',d).
att_prop_i(2,17,'FullName','InvoiceDetailId',v).
att_prop_i(2,10,'ExternalName','ProductId',d).
att_prop_i(2,10,'ExternalNamespace','BillingSystem',d).
att_prop_i(2,10,'EmptyAsNull','Yes',d).
att_prop_i(2,10,'AUTONUMBER','-1',d).
att_prop_i(2,10,'AUTONUMBER_START','1',d).
att_prop_i(2,10,'AUTONUMBER_STEP','1',d).
att_prop_i(2,10,'AUTONUMBER_FORREPLICATION','-1',d).
att_prop_i(2,10,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,10,'AttRegEx','',d).
att_prop_i(2,10,'AttValidationFailedMsg','',d).
att_prop_i(2,10,'FullName','ProductId',v).
att_prop_i(2,11,'ExternalName','ProductDescription',d).
att_prop_i(2,11,'ExternalNamespace','BillingSystem',d).
att_prop_i(2,11,'EmptyAsNull','Yes',d).
att_prop_i(2,11,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,11,'DB_NLS_SUPPORT','No',d).
att_prop_i(2,11,'AttRegEx','',d).
att_prop_i(2,11,'AttValidationFailedMsg','',d).
att_prop_i(2,11,'FullName','ProductDescription',v).
att_prop_i(2,12,'ExternalName','ProductStock',d).
att_prop_i(2,12,'ExternalNamespace','BillingSystem',d).
att_prop_i(2,12,'EmptyAsNull','Yes',d).
att_prop_i(2,12,'AUTONUMBER','0',d).
att_prop_i(2,12,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,12,'AttRegEx','',d).
att_prop_i(2,12,'AttValidationFailedMsg','',d).
att_prop_i(2,12,'FullName','ProductStock',v).
att_prop_i(2,13,'ExternalName','ProductPrice',d).
att_prop_i(2,13,'ExternalNamespace','BillingSystem',d).
att_prop_i(2,13,'EmptyAsNull','Yes',d).
att_prop_i(2,13,'AUTONUMBER','0',d).
att_prop_i(2,13,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,13,'AttRegEx','',d).
att_prop_i(2,13,'AttValidationFailedMsg','',d).
att_prop_i(2,13,'FullName','ProductPrice',v).
att_prop_i(2,18,'ExternalName','InvoiceDetailQuantiity',d).
att_prop_i(2,18,'ExternalNamespace','BillingSystem',d).
att_prop_i(2,18,'EmptyAsNull','Yes',d).
att_prop_i(2,18,'AUTONUMBER','0',d).
att_prop_i(2,18,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,18,'AttRegEx','',d).
att_prop_i(2,18,'AttValidationFailedMsg','',d).
att_prop_i(2,18,'FullName','InvoiceDetailQuantiity',v).
att_prop_i(2,19,'ExternalName','InvoiceDetailAmount',d).
att_prop_i(2,19,'ExternalNamespace','BillingSystem',d).
att_prop_i(2,19,'EmptyAsNull','Yes',d).
att_prop_i(2,19,'AUTONUMBER','0',d).
att_prop_i(2,19,'ATT_INITIAL_VALUE','',d).
att_prop_i(2,19,'AttRegEx','',d).
att_prop_i(2,19,'AttValidationFailedMsg','',d).
att_prop_i(2,19,'FullName','InvoiceDetailAmount',v).
 
tbl_prop_i(2,2,'AllDirSuper',[ [ 1,[ 1 ] ] ],v).
tbl_prop_i(2,4,'AllDirSuper',[ [ 2,[ 3 ] ] ],v).
tbl_prop_i(2,5,'AllDirSuper',[ [ 3,[ 10 ] ],[ 4,[ 14 ] ] ],v).
tbl_prop_i(2,2,'DirSuperNull',[ [ 1,[ 1 ] ] ],v).
tbl_prop_i(2,2001,'DirSubor',[ [ 5,[ 14 ] ] ],v).
tbl_prop_i(2,2000,'DirSubor',[ [ 5,[ 14 ] ] ],v).
tbl_prop_i(2,1,'DirSubor',[ [ 2,[ 1 ] ] ],v).
tbl_prop_i(2,2,'DirSubor',[ [ 4,[ 3 ] ] ],v).
tbl_prop_i(2,4,'DirSubor',[ [ 5,[ 14 ] ] ],v).
tbl_prop_i(2,3,'DirSubor',[ [ 5,[ 10 ] ] ],v).
tbl_prop_i(2,2001,'DirSuper',[ [ 2,[ 3 ] ] ],v).
tbl_prop_i(2,2000,'DirSuper',[ [ 2,[ 3 ] ] ],v).
tbl_prop_i(2,2,'DirSuper',[ [ 1,[ 1 ] ] ],v).
tbl_prop_i(2,4,'DirSuper',[ [ 2,[ 3 ] ] ],v).
tbl_prop_i(2,5,'DirSuper',[ [ 3,[ 10 ] ],[ 4,[ 14 ] ] ],v).
 
tbl_att_prop_i(2,4,14,'AllowNulls',n).
tbl_att_prop_i(2,4,14,'AUTONUMBER',y).
tbl_att_prop_i(2,4,15,'AllowNulls',n).
tbl_att_prop_i(2,4,3,'AllowNulls',n).
tbl_att_prop_i(2,5,17,'AllowNulls',n).
tbl_att_prop_i(2,5,10,'AllowNulls',n).
tbl_att_prop_i(2,5,18,'AllowNulls',n).
tbl_att_prop_i(2,5,14,'AllowNulls',n).
tbl_att_prop_i(2,3,13,'AllowNulls',n).
tbl_att_prop_i(2,3,10,'AllowNulls',n).
tbl_att_prop_i(2,3,10,'AUTONUMBER',y).
tbl_att_prop_i(2,3,11,'AllowNulls',n).
tbl_att_prop_i(2,3,12,'AllowNulls',n).
tbl_att_prop_i(2,2,3,'AllowNulls',n).
tbl_att_prop_i(2,2,3,'AUTONUMBER',y).
tbl_att_prop_i(2,2,4,'AllowNulls',n).
tbl_att_prop_i(2,2,7,'AllowNulls',n).
tbl_att_prop_i(2,1,1,'AllowNulls',n).
tbl_att_prop_i(2,1,1,'AUTONUMBER',y).
tbl_att_prop_i(2,1,2,'AllowNulls',n).
tbl_att_prop_i(2,2000,14,'AllowNulls',n).
tbl_att_prop_i(2,2000,14,'AUTONUMBER',y).
tbl_att_prop_i(2,2001,14,'AllowNulls',n).
tbl_att_prop_i(2,2001,14,'AUTONUMBER',y).
 
 
 
 
a_alias_i([ 'count(',18 ],'InvoiceLastLineId').
a_alias_i(se(20,[ [ 2000,20 ] ],[ t('coalesce(',1),t(20,2),t(',',7),t('0',3),t(')',4) ]),'InvoiceLastLineId').
a_alias_i([ 'sum(',se(19,[ [ 3,13 ],[ 5,18 ] ],[ t(13,2),t(*,6),t(18,2) ]) ],'InvoiceAmount').
a_alias_i(se(16,[ [ 2001,16 ] ],[ t('coalesce(',1),t(16,2),t(',',7),t('0',3),t(')',4) ]),'InvoiceAmount').
 
trn_level_i(4,[ [ 14,15,3,4,7,9,20,1,2,16 ],'Invoice','Invoice','Invoice','',15 ]).
trn_level_i(5,[ [ 17,10,11,12,13,18,19 ],'Detail','Detail','Detail','',11 ]).
 
 
 
 
 
 
pgm_parm_i(web,7,'GX0040',[ [ int,6,0,0 ] ],[ [ pInvoiceId,out,[] ] ]).
pgm_parm_i(web,5,'GX0020',[ [ int,6,0,0 ] ],[ [ pCustomerId,out,[] ] ]).
pgm_parm_i(web,8,'GX0051',[ [ int,6,0,0 ],[ int,2,0,0 ] ],[ [ pInvoiceId,in,[] ],[ pInvoiceDetailId,out,[] ] ]).
pgm_parm_i(web,6,'GX0030',[ [ int,6,0,0 ] ],[ [ pProductId,out,[] ] ]).
 
 
 
 
 
hc_i(1,2,t(1,2),[ 1 ]).
 
 
 
