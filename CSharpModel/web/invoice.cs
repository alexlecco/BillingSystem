/*
               File: Invoice
        Description: Invoice
             Author: GeneXus C# Generator version 10_1_6-46473
       Generated on: 11/23/2016 17:25:24.69
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class invoice : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false ;
         gxfirstwebparm = GetNextPar( ) ;
         gxfirstwebparm_bkp = gxfirstwebparm ;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm, "High") ;
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_15") == 0 )
         {
            A14InvoiceId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14InvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14InvoiceId), 6, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_15( A14InvoiceId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_16") == 0 )
         {
            A14InvoiceId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14InvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14InvoiceId), 6, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_16( A14InvoiceId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_14") == 0 )
         {
            A3CustomerId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3CustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3CustomerId), 6, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_14( A3CustomerId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_18") == 0 )
         {
            A10ProductId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10ProductId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10ProductId), 6, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_18( A10ProductId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = GetNextPar( ) ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridinvoice_detail") == 0 )
         {
            nRC_Gridinvoice_detail = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            nGXsfl_65_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            sGXsfl_65_idx = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxnrGridinvoice_detail_newrow( nRC_Gridinvoice_detail, nGXsfl_65_idx, sGXsfl_65_idx) ;
            return  ;
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp ;
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_6-46473", 0) ;
         Form.Meta.addItem("Description", "Invoice", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtInvoiceId_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("GeneXusX");
      }

      public invoice( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("GeneXusX");
      }

      public invoice( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("appmasterpage", "GeneXus.Programs.appmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            MasterPageObj.webExecute();
            if ( context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            wb_table1_2_044( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_044e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_044( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_044( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_044e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Invoice"+"</legend>") ;
            wb_table3_27_044( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_044e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_044e( true) ;
         }
         else
         {
            wb_table1_2_044e( false) ;
         }
      }

      protected void wb_table3_27_044( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table4_33_044( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_044e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirm", "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_Invoice.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancel", "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_Invoice.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Delete", "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_Invoice.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_044e( true) ;
         }
         else
         {
            wb_table3_27_044e( false) ;
         }
      }

      protected void wb_table4_33_044( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockinvoiceid_Internalname, 1, 1, 0, "Id", "", "", "", 0, lblTextblockinvoiceid_Jsonclick, "", StyleString, ClassString, "HLP_Invoice.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtInvoiceId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A14InvoiceId), 6, 0, ".", "")), "", 6, "chr", 1, "row", 6, 1, edtInvoiceId_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A14InvoiceId), "ZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(38);\"", 0, edtInvoiceId_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Invoice.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockinvoicedate_Internalname, 1, 1, 0, "Date", "", "", "", 0, lblTextblockinvoicedate_Jsonclick, "", StyleString, ClassString, "HLP_Invoice.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtInvoiceDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtInvoiceDate_Internalname, context.localUtil.Format(A15InvoiceDate, "99/99/99"), "", 8, "chr", 1, "row", 8, 1, edtInvoiceDate_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A15InvoiceDate, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onblur(43);\"", 0, edtInvoiceDate_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Invoice.htm");
            GxWebStd.gx_bitmap( context, edtInvoiceDate_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtInvoiceDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Invoice.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcustomerid_Internalname, 1, 1, 0, "Customer Id", "", "", "", 0, lblTextblockcustomerid_Jsonclick, "", StyleString, ClassString, "HLP_Invoice.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCustomerId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A3CustomerId), 6, 0, ".", "")), "", 6, "chr", 1, "row", 6, 1, edtCustomerId_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A3CustomerId), "ZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(48);\"", 0, edtCustomerId_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Invoice.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_3_Internalname, "", "prompt.gif", "GeneXusX", imgprompt_3_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_3_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_Invoice.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcustomername_Internalname, 1, 1, 0, "Customer Name", "", "", "", 0, lblTextblockcustomername_Jsonclick, "", StyleString, ClassString, "HLP_Invoice.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCustomerName_Internalname, StringUtil.RTrim( A4CustomerName), "", 30, "chr", 1, "row", 30, 1, edtCustomerName_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A4CustomerName, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtCustomerName_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Invoice.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcustomertotalpurchases_Internalname, 1, 1, 0, "Customer Total Purchases", "", "", "", 0, lblTextblockcustomertotalpurchases_Jsonclick, "", StyleString, ClassString, "HLP_Invoice.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCustomerTotalPurchases_Internalname, StringUtil.LTrim( StringUtil.NToC( A7CustomerTotalPurchases, 9, 2, ".", "")), "", 9, "chr", 1, "row", 9, 1, edtCustomerTotalPurchases_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A7CustomerTotalPurchases, "ZZZZZ9.99"), "", 0, edtCustomerTotalPurchases_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Invoice.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\"  style=\"height:197px\">") ;
            context.WriteHtmlText( "<br>") ;
            wb_table5_61_044( true) ;
         }
         return  ;
      }

      protected void wb_table5_61_044e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<hr class=\"HRDefault\">") ;
            /*  Grid Control  */
            Gridinvoice_detailContainer.AddObjectProperty("GridName", "Gridinvoice_detail");
            Gridinvoice_detailContainer.AddObjectProperty("Class", "Grid");
            Gridinvoice_detailContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Gridinvoice_detailContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            Gridinvoice_detailContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinvoice_detail_Backcolorstyle), 1, 0, ".", "")));
            Gridinvoice_detailContainer.AddObjectProperty("CmpContext", "");
            Gridinvoice_detailContainer.AddObjectProperty("InMasterPage", "false");
            Gridinvoice_detailColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridinvoice_detailColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A17InvoiceDetailId), 2, 0, ".", "")));
            Gridinvoice_detailColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtInvoiceDetailId_Enabled), 5, 0, ".", "")));
            Gridinvoice_detailContainer.AddColumnProperties(Gridinvoice_detailColumn);
            Gridinvoice_detailColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridinvoice_detailColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A10ProductId), 6, 0, ".", "")));
            Gridinvoice_detailColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProductId_Enabled), 5, 0, ".", "")));
            Gridinvoice_detailContainer.AddColumnProperties(Gridinvoice_detailColumn);
            Gridinvoice_detailColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridinvoice_detailContainer.AddColumnProperties(Gridinvoice_detailColumn);
            Gridinvoice_detailColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridinvoice_detailColumn.AddObjectProperty("Value", StringUtil.RTrim( A11ProductDescription));
            Gridinvoice_detailColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProductDescription_Enabled), 5, 0, ".", "")));
            Gridinvoice_detailContainer.AddColumnProperties(Gridinvoice_detailColumn);
            Gridinvoice_detailColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridinvoice_detailColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A13ProductPrice, 9, 2, ".", "")));
            Gridinvoice_detailColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProductPrice_Enabled), 5, 0, ".", "")));
            Gridinvoice_detailContainer.AddColumnProperties(Gridinvoice_detailColumn);
            Gridinvoice_detailColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridinvoice_detailColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A18InvoiceDetailQuantiity), 3, 0, ".", "")));
            Gridinvoice_detailColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtInvoiceDetailQuantiity_Enabled), 5, 0, ".", "")));
            Gridinvoice_detailContainer.AddColumnProperties(Gridinvoice_detailColumn);
            Gridinvoice_detailColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridinvoice_detailColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A19InvoiceDetailAmount, 9, 2, ".", "")));
            Gridinvoice_detailColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtInvoiceDetailAmount_Enabled), 5, 0, ".", "")));
            Gridinvoice_detailContainer.AddColumnProperties(Gridinvoice_detailColumn);
            Gridinvoice_detailContainer.AddObjectProperty("Allowselection", "false");
            Gridinvoice_detailContainer.AddObjectProperty("Allowcollapsing", "false");
            Gridinvoice_detailContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridinvoice_detail_Collapsed), 9, 0, ".", "")));
            nGXsfl_65_idx = 0 ;
            if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
            {
               /* Enter key processing. */
               nBlankRcdCount5 = 5 ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  /* Display confirmed (stored) records */
                  nRcdExists_5 = 1 ;
                  ScanStart045( ) ;
                  while ( RcdFound5 != 0 )
                  {
                     init_level_properties5( ) ;
                     getByPrimaryKey045( ) ;
                     AddRow045( ) ;
                     ScanNext045( ) ;
                  }
                  ScanEnd045( ) ;
                  nBlankRcdCount5 = 5 ;
               }
            }
            else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
            {
               /* Button check  or addlines. */
               B20InvoiceLastLineId = A20InvoiceLastLineId ;
               n20InvoiceLastLineId = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
               B16InvoiceAmount = A16InvoiceAmount ;
               n16InvoiceAmount = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
               standaloneNotModal045( ) ;
               standaloneModal045( ) ;
               sMode5 = Gx_mode ;
               while ( nGXsfl_65_idx < nRC_Gridinvoice_detail )
               {
                  ReadRow045( ) ;
                  edtInvoiceDetailId_Enabled = (int)(context.localUtil.CToN( cgiGet( "INVOICEDETAILID_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvoiceDetailId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvoiceDetailId_Enabled), 5, 0)));
                  edtProductId_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRODUCTID_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProductId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProductId_Enabled), 5, 0)));
                  edtProductDescription_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRODUCTDESCRIPTION_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProductDescription_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProductDescription_Enabled), 5, 0)));
                  edtProductPrice_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRODUCTPRICE_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProductPrice_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProductPrice_Enabled), 5, 0)));
                  edtInvoiceDetailQuantiity_Enabled = (int)(context.localUtil.CToN( cgiGet( "INVOICEDETAILQUANTIITY_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvoiceDetailQuantiity_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvoiceDetailQuantiity_Enabled), 5, 0)));
                  edtInvoiceDetailAmount_Enabled = (int)(context.localUtil.CToN( cgiGet( "INVOICEDETAILAMOUNT_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvoiceDetailAmount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvoiceDetailAmount_Enabled), 5, 0)));
                  imgprompt_3_Link = cgiGet( "PROMPT_10_"+sGXsfl_65_idx+"Link") ;
                  if ( ( nRcdExists_5 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     standaloneModal045( ) ;
                  }
                  SendRow045( ) ;
               }
               Gx_mode = sMode5 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               A20InvoiceLastLineId = B20InvoiceLastLineId ;
               n20InvoiceLastLineId = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
               A16InvoiceAmount = B16InvoiceAmount ;
               n16InvoiceAmount = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
            }
            else
            {
               /* Get or get-alike key processing. */
               nBlankRcdCount5 = 5 ;
               nRcdExists_5 = 1 ;
               ScanStart045( ) ;
               while ( RcdFound5 != 0 )
               {
                  init_level_properties5( ) ;
                  getByPrimaryKey045( ) ;
                  standaloneNotModal045( ) ;
                  standaloneModal045( ) ;
                  AddRow045( ) ;
                  ScanNext045( ) ;
               }
               ScanEnd045( ) ;
            }
            /* Initialize fields for 'new' records and send them. */
            sMode5 = Gx_mode ;
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            InitAll045( ) ;
            init_level_properties5( ) ;
            B20InvoiceLastLineId = A20InvoiceLastLineId ;
            n20InvoiceLastLineId = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
            B16InvoiceAmount = A16InvoiceAmount ;
            n16InvoiceAmount = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
            standaloneNotModal045( ) ;
            standaloneModal045( ) ;
            nRcdExists_5 = 0 ;
            nIsMod_5 = 0 ;
            nBlankRcdCount5 = (short)(nBlankRcdUsr5+nBlankRcdCount5) ;
            fRowAdded = 0 ;
            while ( nBlankRcdCount5 > 0 )
            {
               AddRow045( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1 ;
                  GX_FocusControl = edtInvoiceDetailId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount5 = (short)(nBlankRcdCount5-1) ;
            }
            Gx_mode = sMode5 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            A20InvoiceLastLineId = B20InvoiceLastLineId ;
            n20InvoiceLastLineId = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
            A16InvoiceAmount = B16InvoiceAmount ;
            n16InvoiceAmount = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
            sStyleString = " style=\"display:none;\"" ;
            sStyleString = "" ;
            context.WriteHtmlText( "<div id=\""+"Gridinvoice_detailContainer"+"Div\" "+sStyleString+">"+"</div>") ;
            context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridinvoice_detail", (Object)(Gridinvoice_detailContainer));
            GxWebStd.gx_hidden_field( context, "Gridinvoice_detailContainerData", Gridinvoice_detailContainer.ToJavascriptSource());
            if ( context.isAjaxRequest( ) )
            {
               GxWebStd.gx_hidden_field( context, "Gridinvoice_detailContainerData"+"V", Gridinvoice_detailContainer.GridValuesHidden());
            }
            else
            {
               context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridinvoice_detailContainerData"+"V"+"\" value='"+Gridinvoice_detailContainer.GridValuesHidden()+"'>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\"  style=\"height:23px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockinvoiceamount_Internalname, 1, 1, 0, "Amount", "", "", "", 0, lblTextblockinvoiceamount_Jsonclick, "", StyleString, ClassString, "HLP_Invoice.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtInvoiceAmount_Internalname, StringUtil.LTrim( StringUtil.NToC( A16InvoiceAmount, 9, 2, ".", "")), "", 9, "chr", 1, "row", 9, 1, edtInvoiceAmount_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A16InvoiceAmount, "ZZZZZ9.99"), "", 0, edtInvoiceAmount_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Invoice.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_044e( true) ;
         }
         else
         {
            wb_table4_33_044e( false) ;
         }
      }

      protected void wb_table5_61_044( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table95", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class=\"SubTitle\" >") ;
            /* Text block */
            ClassString = "" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTitledetail_Internalname, 1, 1, 0, "Detail", "", "", "", 0, lblTitledetail_Jsonclick, "", StyleString, ClassString, "HLP_Invoice.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_61_044e( true) ;
         }
         else
         {
            wb_table5_61_044e( false) ;
         }
      }

      protected void wb_table2_5_044( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTabletoolbar_Internalname, tblTabletoolbar_Internalname, "", "ViewTable", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "<div style=\"WHITE-SPACE: nowrap\" class=\"ToolbarMain\">") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, "", context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "GeneXusX"), "GeneXusX", imgBtn_first_Visible, 1, "", "First", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Invoice.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Invoice.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, "", context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "GeneXusX"), "GeneXusX", imgBtn_previous_Visible, 1, "", "Previous", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Invoice.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Invoice.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, "", context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "GeneXusX"), "GeneXusX", imgBtn_next_Visible, 1, "", "Next", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Invoice.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Invoice.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, "", context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "GeneXusX"), "GeneXusX", imgBtn_last_Visible, 1, "", "Last", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Invoice.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Invoice.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, "", context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "GeneXusX"), "GeneXusX", imgBtn_select_Visible, 1, "", "Select", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0040.aspx"+"',["+"{Ctrl:gx.dom.el('"+"INVOICEID"+"'), id:'"+"INVOICEID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Invoice.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0040.aspx"+"',["+"{Ctrl:gx.dom.el('"+"INVOICEID"+"'), id:'"+"INVOICEID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Invoice.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, "", context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "GeneXusX"), "GeneXusX", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirm", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Invoice.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Invoice.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, "", context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "GeneXusX"), "GeneXusX", imgBtn_cancel2_Visible, 1, "", "Cancel", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Invoice.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Invoice.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, "", context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "GeneXusX"), "GeneXusX", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Delete", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Invoice.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Invoice.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_044e( true) ;
         }
         else
         {
            wb_table2_5_044e( false) ;
         }
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtInvoiceId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtInvoiceId_Internalname), ".", ",") > Convert.ToDecimal( 999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "INVOICEID");
                  AnyError = 1 ;
                  GX_FocusControl = edtInvoiceId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A14InvoiceId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14InvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14InvoiceId), 6, 0)));
               }
               else
               {
                  A14InvoiceId = (int)(context.localUtil.CToN( cgiGet( edtInvoiceId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14InvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14InvoiceId), 6, 0)));
               }
               if ( context.localUtil.VCDate( cgiGet( edtInvoiceDate_Internalname), 1) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Invoice Date"}), 1, "INVOICEDATE");
                  AnyError = 1 ;
                  GX_FocusControl = edtInvoiceDate_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A15InvoiceDate = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15InvoiceDate", context.localUtil.Format(A15InvoiceDate, "99/99/99"));
               }
               else
               {
                  A15InvoiceDate = context.localUtil.CToD( cgiGet( edtInvoiceDate_Internalname), 1) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15InvoiceDate", context.localUtil.Format(A15InvoiceDate, "99/99/99"));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtCustomerId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCustomerId_Internalname), ".", ",") > Convert.ToDecimal( 999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "CUSTOMERID");
                  AnyError = 1 ;
                  GX_FocusControl = edtCustomerId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A3CustomerId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3CustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3CustomerId), 6, 0)));
               }
               else
               {
                  A3CustomerId = (int)(context.localUtil.CToN( cgiGet( edtCustomerId_Internalname), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3CustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3CustomerId), 6, 0)));
               }
               A4CustomerName = cgiGet( edtCustomerName_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CustomerName", A4CustomerName);
               A7CustomerTotalPurchases = context.localUtil.CToN( cgiGet( edtCustomerTotalPurchases_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
               A16InvoiceAmount = context.localUtil.CToN( cgiGet( edtInvoiceAmount_Internalname), ".", ",") ;
               n16InvoiceAmount = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
               /* Read saved values. */
               Z14InvoiceId = (int)(context.localUtil.CToN( cgiGet( "Z14InvoiceId"), ".", ",")) ;
               Z15InvoiceDate = context.localUtil.CToD( cgiGet( "Z15InvoiceDate"), 0) ;
               Z3CustomerId = (int)(context.localUtil.CToN( cgiGet( "Z3CustomerId"), ".", ",")) ;
               O20InvoiceLastLineId = (short)(context.localUtil.CToN( cgiGet( "O20InvoiceLastLineId"), ".", ",")) ;
               O16InvoiceAmount = context.localUtil.CToN( cgiGet( "O16InvoiceAmount"), ".", ",") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               nRC_Gridinvoice_detail = (short)(context.localUtil.CToN( cgiGet( "nRC_Gridinvoice_detail"), ".", ",")) ;
               Gx_date = context.localUtil.CToD( cgiGet( "vTODAY"), 0) ;
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ".", ",")) ;
               A20InvoiceLastLineId = (short)(context.localUtil.CToN( cgiGet( "INVOICELASTLINEID"), ".", ",")) ;
               Gx_mode = cgiGet( "vMODE") ;
               A12ProductStock = (short)(context.localUtil.CToN( cgiGet( "PRODUCTSTOCK"), ".", ",")) ;
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  A14InvoiceId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14InvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14InvoiceId), 6, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons_dsp( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal( ) ;
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName") ;
            EvtGridId = cgiGet( "_EventGridId") ;
            EvtRowId = cgiGet( "_EventRowId") ;
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1) ;
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
               /* Check if conditions changed and reset current page numbers */
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1) ;
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_first( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_previous( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_next( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_last( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_select( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_delete( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1 ;
                           AfterKeyLoadScreen( ) ;
                        }
                     }
                     else
                     {
                        sEvtType = StringUtil.Right( sEvt, 4) ;
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                     }
                  }
                  context.wbHandled = 1 ;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll044( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            imgBtn_delete2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
      }

      protected void disable_std_buttons_dsp( )
      {
         imgBtn_delete2_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Visible), 5, 0)));
         imgBtn_delete2_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_separator_Visible), 5, 0)));
         bttBtn_delete_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         imgBtn_first_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_first_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_first_Visible), 5, 0)));
         imgBtn_first_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_first_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_first_separator_Visible), 5, 0)));
         imgBtn_previous_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_previous_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_previous_Visible), 5, 0)));
         imgBtn_previous_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_previous_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_previous_separator_Visible), 5, 0)));
         imgBtn_next_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_next_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_next_Visible), 5, 0)));
         imgBtn_next_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_next_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_next_separator_Visible), 5, 0)));
         imgBtn_last_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_last_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_last_Visible), 5, 0)));
         imgBtn_last_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_last_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_last_separator_Visible), 5, 0)));
         imgBtn_select_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_select_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_select_Visible), 5, 0)));
         imgBtn_select_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_select_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_select_separator_Visible), 5, 0)));
         imgBtn_delete2_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Visible), 5, 0)));
         imgBtn_delete2_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_separator_Visible), 5, 0)));
         bttBtn_delete_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            imgBtn_enter2_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Visible), 5, 0)));
            imgBtn_enter2_separator_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_separator_Visible), 5, 0)));
            bttBtn_enter_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
         }
         DisableAttributes044( ) ;
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete"), 0, "");
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm"), 0, "");
            }
         }
      }

      protected void CONFIRM_045( )
      {
         s20InvoiceLastLineId = O20InvoiceLastLineId ;
         n20InvoiceLastLineId = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
         s16InvoiceAmount = O16InvoiceAmount ;
         n16InvoiceAmount = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
         nGXsfl_65_idx = 0 ;
         while ( nGXsfl_65_idx < nRC_Gridinvoice_detail )
         {
            ReadRow045( ) ;
            if ( ( nRcdExists_5 != 0 ) || ( nIsMod_5 != 0 ) )
            {
               GetKey045( ) ;
               if ( ( nRcdExists_5 == 0 ) && ( nRcdDeleted_5 == 0 ) )
               {
                  if ( RcdFound5 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate045( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable045( ) ;
                        CloseExtendedTableCursors045( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1 ;
                        }
                        O20InvoiceLastLineId = A20InvoiceLastLineId ;
                        n20InvoiceLastLineId = false ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
                        O16InvoiceAmount = A16InvoiceAmount ;
                        n16InvoiceAmount = false ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtInvoiceDetailId_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound5 != 0 )
                  {
                     if ( nRcdDeleted_5 != 0 )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey045( ) ;
                        Load045( ) ;
                        BeforeValidate045( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls045( ) ;
                           O20InvoiceLastLineId = A20InvoiceLastLineId ;
                           n20InvoiceLastLineId = false ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
                           O16InvoiceAmount = A16InvoiceAmount ;
                           n16InvoiceAmount = false ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
                        }
                     }
                     else
                     {
                        if ( nIsMod_5 != 0 )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate045( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable045( ) ;
                              CloseExtendedTableCursors045( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1 ;
                              }
                              O20InvoiceLastLineId = A20InvoiceLastLineId ;
                              n20InvoiceLastLineId = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
                              O16InvoiceAmount = A16InvoiceAmount ;
                              n16InvoiceAmount = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_5 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtInvoiceDetailId_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtInvoiceDetailId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A17InvoiceDetailId), 2, 0, ".", ""))) ;
            ChangePostValue( edtProductId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A10ProductId), 6, 0, ".", ""))) ;
            ChangePostValue( edtProductDescription_Internalname, StringUtil.RTrim( A11ProductDescription)) ;
            ChangePostValue( edtProductPrice_Internalname, StringUtil.LTrim( StringUtil.NToC( A13ProductPrice, 9, 2, ".", ""))) ;
            ChangePostValue( edtInvoiceDetailQuantiity_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A18InvoiceDetailQuantiity), 3, 0, ".", ""))) ;
            ChangePostValue( edtInvoiceDetailAmount_Internalname, StringUtil.LTrim( StringUtil.NToC( A19InvoiceDetailAmount, 9, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z17InvoiceDetailId_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17InvoiceDetailId), 2, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z18InvoiceDetailQuantiity_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z18InvoiceDetailQuantiity), 3, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z10ProductId_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10ProductId), 6, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z11ProductDescription_"+sGXsfl_65_idx, StringUtil.RTrim( Z11ProductDescription)) ;
            ChangePostValue( "ZT_"+"Z13ProductPrice_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( Z13ProductPrice, 9, 2, ".", ""))) ;
            ChangePostValue( "T12ProductStock_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(O12ProductStock), 4, 0, ".", ""))) ;
            ChangePostValue( "T19InvoiceDetailAmount_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( O19InvoiceDetailAmount, 9, 2, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_5_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_5), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_5_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_5), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_5_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_5), 4, 0, ".", ""))) ;
            if ( nIsMod_5 != 0 )
            {
               ChangePostValue( "INVOICEDETAILID_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtInvoiceDetailId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRODUCTID_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProductId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRODUCTDESCRIPTION_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProductDescription_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRODUCTPRICE_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProductPrice_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INVOICEDETAILQUANTIITY_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtInvoiceDetailQuantiity_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INVOICEDETAILAMOUNT_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtInvoiceDetailAmount_Enabled), 5, 0, ".", ""))) ;
            }
         }
         O20InvoiceLastLineId = s20InvoiceLastLineId ;
         n20InvoiceLastLineId = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
         O16InvoiceAmount = s16InvoiceAmount ;
         n16InvoiceAmount = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption040( )
      {
      }

      protected void ZM044( short GX_JID )
      {
         if ( ( GX_JID == 13 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z15InvoiceDate = T00047_A15InvoiceDate[0] ;
               Z3CustomerId = T00047_A3CustomerId[0] ;
            }
            else
            {
               Z15InvoiceDate = A15InvoiceDate ;
               Z3CustomerId = A3CustomerId ;
            }
         }
         if ( GX_JID == -13 )
         {
            Z14InvoiceId = A14InvoiceId ;
            Z15InvoiceDate = A15InvoiceDate ;
            Z3CustomerId = A3CustomerId ;
            Z20InvoiceLastLineId = A20InvoiceLastLineId ;
            Z16InvoiceAmount = A16InvoiceAmount ;
            Z4CustomerName = A4CustomerName ;
            Z7CustomerTotalPurchases = A7CustomerTotalPurchases ;
         }
      }

      protected void standaloneNotModal( )
      {
         Gx_BScreen = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         Gx_date = DateTimeUtil.Today( ) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_date", context.localUtil.Format(Gx_date, "99/99/99"));
         imgprompt_3_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0020.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CUSTOMERID"+"'), id:'"+"CUSTOMERID"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (DateTime.MinValue==A15InvoiceDate) && ( Gx_BScreen == 0 ) )
         {
            A15InvoiceDate = Gx_date ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15InvoiceDate", context.localUtil.Format(A15InvoiceDate, "99/99/99"));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            imgBtn_enter2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Enabled), 5, 0)));
         }
         else
         {
            imgBtn_enter2_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Enabled), 5, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
         }
      }

      protected void Load044( )
      {
         /* Using cursor T000415 */
         pr_default.execute(9, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound4 = 1 ;
            A15InvoiceDate = T000415_A15InvoiceDate[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15InvoiceDate", context.localUtil.Format(A15InvoiceDate, "99/99/99"));
            A4CustomerName = T000415_A4CustomerName[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CustomerName", A4CustomerName);
            A7CustomerTotalPurchases = T000415_A7CustomerTotalPurchases[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
            A3CustomerId = T000415_A3CustomerId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3CustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3CustomerId), 6, 0)));
            A20InvoiceLastLineId = T000415_A20InvoiceLastLineId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
            n20InvoiceLastLineId = T000415_n20InvoiceLastLineId[0] ;
            A16InvoiceAmount = T000415_A16InvoiceAmount[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
            n16InvoiceAmount = T000415_n16InvoiceAmount[0] ;
            ZM044( -13) ;
         }
         pr_default.close(9);
         OnLoadActions044( ) ;
      }

      protected void OnLoadActions044( )
      {
         /* Using cursor T000410 */
         pr_default.execute(7, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            A20InvoiceLastLineId = T000410_A20InvoiceLastLineId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
            n20InvoiceLastLineId = T000410_n20InvoiceLastLineId[0] ;
         }
         else
         {
            A20InvoiceLastLineId = 0 ;
            n20InvoiceLastLineId = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
         }
         O20InvoiceLastLineId = A20InvoiceLastLineId ;
         n20InvoiceLastLineId = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
         pr_default.close(7);
         /* Using cursor T000412 */
         pr_default.execute(8, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            A16InvoiceAmount = T000412_A16InvoiceAmount[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
            n16InvoiceAmount = T000412_n16InvoiceAmount[0] ;
         }
         else
         {
            A16InvoiceAmount = 0 ;
            n16InvoiceAmount = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
         }
         O16InvoiceAmount = A16InvoiceAmount ;
         n16InvoiceAmount = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
         pr_default.close(8);
      }

      protected void CheckExtendedTable044( )
      {
         Gx_BScreen = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         /* Using cursor T000410 */
         pr_default.execute(7, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            A20InvoiceLastLineId = T000410_A20InvoiceLastLineId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
            n20InvoiceLastLineId = T000410_n20InvoiceLastLineId[0] ;
         }
         else
         {
            A20InvoiceLastLineId = 0 ;
            n20InvoiceLastLineId = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
         }
         pr_default.close(7);
         /* Using cursor T000412 */
         pr_default.execute(8, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            A16InvoiceAmount = T000412_A16InvoiceAmount[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
            n16InvoiceAmount = T000412_n16InvoiceAmount[0] ;
         }
         else
         {
            A16InvoiceAmount = 0 ;
            n16InvoiceAmount = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
         }
         pr_default.close(8);
         if ( ! ( (DateTime.MinValue==A15InvoiceDate) || ( A15InvoiceDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Field Invoice Date is out of range", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         if ( (DateTime.MinValue==A15InvoiceDate) )
         {
            GX_msglist.addItem("No se permiten FACTURAS sin FECHA", 1, "");
            AnyError = 1 ;
         }
         /* Using cursor T00048 */
         pr_default.execute(6, new Object[] {A3CustomerId});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No matching 'Customer'.", "ForeignKeyNotFound", 1, "CUSTOMERID");
            AnyError = 1 ;
            GX_FocusControl = edtCustomerId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A4CustomerName = T00048_A4CustomerName[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CustomerName", A4CustomerName);
            A7CustomerTotalPurchases = T00048_A7CustomerTotalPurchases[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
         }
         pr_default.close(6);
         if ( A15InvoiceDate > Gx_date )
         {
            GX_msglist.addItem("La fecha es mayor a la del dia de hoy", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors044( )
      {
         pr_default.close(7);
         pr_default.close(8);
         pr_default.close(6);
      }

      protected void enableDisable( )
      {
         if ( IsConfirmed == 0 )
         {
            imgBtn_delete2_Enabled = RcdFound4 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
         else
         {
            imgBtn_delete2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
      }

      protected void gxLoad_15( int A14InvoiceId )
      {
         /* Using cursor T000417 */
         pr_default.execute(10, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(10) != 101) )
         {
            A20InvoiceLastLineId = T000417_A20InvoiceLastLineId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
            n20InvoiceLastLineId = T000417_n20InvoiceLastLineId[0] ;
         }
         else
         {
            A20InvoiceLastLineId = 0 ;
            n20InvoiceLastLineId = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A20InvoiceLastLineId), 4, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(10) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(10);
      }

      protected void gxLoad_16( int A14InvoiceId )
      {
         /* Using cursor T000419 */
         pr_default.execute(11, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(11) != 101) )
         {
            A16InvoiceAmount = T000419_A16InvoiceAmount[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
            n16InvoiceAmount = T000419_n16InvoiceAmount[0] ;
         }
         else
         {
            A16InvoiceAmount = 0 ;
            n16InvoiceAmount = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A16InvoiceAmount, 9, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(11) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(11);
      }

      protected void gxLoad_14( int A3CustomerId )
      {
         /* Using cursor T000420 */
         pr_default.execute(12, new Object[] {A3CustomerId});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("No matching 'Customer'.", "ForeignKeyNotFound", 1, "CUSTOMERID");
            AnyError = 1 ;
            GX_FocusControl = edtCustomerId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A4CustomerName = T000420_A4CustomerName[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CustomerName", A4CustomerName);
            A7CustomerTotalPurchases = T000420_A7CustomerTotalPurchases[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A4CustomerName))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A7CustomerTotalPurchases, 9, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(12) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(12);
      }

      protected void GetKey044( )
      {
         /* Using cursor T000421 */
         pr_default.execute(13, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound4 = 1 ;
         }
         else
         {
            RcdFound4 = 0 ;
         }
         pr_default.close(13);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00047 */
         pr_default.execute(5, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            ZM044( 13) ;
            RcdFound4 = 1 ;
            A14InvoiceId = T00047_A14InvoiceId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14InvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14InvoiceId), 6, 0)));
            A15InvoiceDate = T00047_A15InvoiceDate[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15InvoiceDate", context.localUtil.Format(A15InvoiceDate, "99/99/99"));
            A3CustomerId = T00047_A3CustomerId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3CustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3CustomerId), 6, 0)));
            Z14InvoiceId = A14InvoiceId ;
            sMode4 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load044( ) ;
            Gx_mode = sMode4 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound4 = 0 ;
            InitializeNonKey044( ) ;
            sMode4 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode4 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(5);
      }

      protected void getEqualNoModal( )
      {
         GetKey044( ) ;
         if ( RcdFound4 == 0 )
         {
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound4 = 0 ;
         /* Using cursor T000422 */
         pr_default.execute(14, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(14) != 101) )
         {
            while ( (pr_default.getStatus(14) != 101) && ( ( T000422_A14InvoiceId[0] < A14InvoiceId ) ) )
            {
               pr_default.readNext(14);
            }
            if ( (pr_default.getStatus(14) != 101) && ( ( T000422_A14InvoiceId[0] > A14InvoiceId ) ) )
            {
               A14InvoiceId = T000422_A14InvoiceId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14InvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14InvoiceId), 6, 0)));
               RcdFound4 = 1 ;
            }
         }
         pr_default.close(5);
      }

      protected void move_previous( )
      {
         RcdFound4 = 0 ;
         /* Using cursor T000423 */
         pr_default.execute(15, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(15) != 101) )
         {
            while ( (pr_default.getStatus(15) != 101) && ( ( T000423_A14InvoiceId[0] > A14InvoiceId ) ) )
            {
               pr_default.readNext(15);
            }
            if ( (pr_default.getStatus(15) != 101) && ( ( T000423_A14InvoiceId[0] < A14InvoiceId ) ) )
            {
               A14InvoiceId = T000423_A14InvoiceId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14InvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14InvoiceId), 6, 0)));
               RcdFound4 = 1 ;
            }
         }
         pr_default.close(4);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey044( ) ;
         if ( RcdFound4 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "INVOICEID");
               AnyError = 1 ;
               GX_FocusControl = edtInvoiceId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( A14InvoiceId != Z14InvoiceId )
            {
               A14InvoiceId = Z14InvoiceId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14InvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14InvoiceId), 6, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "INVOICEID");
               AnyError = 1 ;
               GX_FocusControl = edtInvoiceId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               A20InvoiceLastLineId = O20InvoiceLastLineId ;
               n20InvoiceLastLineId = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
               A16InvoiceAmount = O16InvoiceAmount ;
               n16InvoiceAmount = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtInvoiceId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               Gx_mode = "UPD" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Update record */
               A20InvoiceLastLineId = O20InvoiceLastLineId ;
               n20InvoiceLastLineId = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
               A16InvoiceAmount = O16InvoiceAmount ;
               n16InvoiceAmount = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
               Update044( ) ;
               GX_FocusControl = edtInvoiceId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( A14InvoiceId != Z14InvoiceId )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               A20InvoiceLastLineId = O20InvoiceLastLineId ;
               n20InvoiceLastLineId = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
               A16InvoiceAmount = O16InvoiceAmount ;
               n16InvoiceAmount = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
               GX_FocusControl = edtInvoiceId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert044( ) ;
               if ( AnyError == 1 )
               {
                  GX_FocusControl = "" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "INVOICEID");
                  AnyError = 1 ;
                  GX_FocusControl = edtInvoiceId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  A20InvoiceLastLineId = O20InvoiceLastLineId ;
                  n20InvoiceLastLineId = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
                  A16InvoiceAmount = O16InvoiceAmount ;
                  n16InvoiceAmount = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
                  GX_FocusControl = edtInvoiceId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert044( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
            }
         }
         AfterTrn( ) ;
      }

      protected void btn_delete( )
      {
         if ( A14InvoiceId != Z14InvoiceId )
         {
            A14InvoiceId = Z14InvoiceId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14InvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14InvoiceId), 6, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "INVOICEID");
            AnyError = 1 ;
            GX_FocusControl = edtInvoiceId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            A20InvoiceLastLineId = O20InvoiceLastLineId ;
            n20InvoiceLastLineId = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
            A16InvoiceAmount = O16InvoiceAmount ;
            n16InvoiceAmount = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtInvoiceId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
         CloseOpenCursors();
      }

      protected void btn_get( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         if ( RcdFound4 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound"), "PrimaryKeyNotFound", 1, "INVOICEID");
            AnyError = 1 ;
         }
         GX_FocusControl = edtInvoiceDate_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart044( ) ;
         if ( RcdFound4 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtInvoiceDate_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd044( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound4 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtInvoiceDate_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_next( ) ;
         if ( RcdFound4 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtInvoiceDate_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart044( ) ;
         if ( RcdFound4 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            while ( RcdFound4 != 0 )
            {
               ScanNext044( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtInvoiceDate_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd044( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency044( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000424 */
            pr_default.execute(16, new Object[] {A14InvoiceId});
            if ( (pr_default.getStatus(16) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Invoice"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(16) == 101) || ( Z15InvoiceDate != T000424_A15InvoiceDate[0] ) || ( Z3CustomerId != T000424_A3CustomerId[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Invoice"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert044( )
      {
         BeforeValidate044( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable044( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM044( 0) ;
            CheckOptimisticConcurrency044( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm044( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert044( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000425 */
                     pr_default.execute(17, new Object[] {A15InvoiceDate, A3CustomerId});
                     pr_default.close(17);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000426 */
                     pr_default.execute(18);
                     A14InvoiceId = T000426_A14InvoiceId[0] ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14InvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14InvoiceId), 6, 0)));
                     pr_default.close(18);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel044( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded"), 0, "");
                              ResetCaption040( ) ;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
            else
            {
               Load044( ) ;
            }
            EndLevel044( ) ;
         }
         CloseExtendedTableCursors044( ) ;
      }

      protected void Update044( )
      {
         BeforeValidate044( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable044( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency044( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm044( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate044( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000427 */
                     pr_default.execute(19, new Object[] {A15InvoiceDate, A3CustomerId, A14InvoiceId});
                     pr_default.close(19);
                     if ( (pr_default.getStatus(19) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Invoice"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate044( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel044( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated"), 0, "");
                              ResetCaption040( ) ;
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
            }
            EndLevel044( ) ;
         }
         CloseExtendedTableCursors044( ) ;
      }

      protected void DeferredUpdate044( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate044( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency044( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls044( ) ;
            AfterConfirm044( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete044( ) ;
               if ( AnyError == 0 )
               {
                  A20InvoiceLastLineId = O20InvoiceLastLineId ;
                  n20InvoiceLastLineId = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
                  A16InvoiceAmount = O16InvoiceAmount ;
                  n16InvoiceAmount = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
                  ScanStart045( ) ;
                  while ( RcdFound5 != 0 )
                  {
                     getByPrimaryKey045( ) ;
                     Delete045( ) ;
                     ScanNext045( ) ;
                     O20InvoiceLastLineId = A20InvoiceLastLineId ;
                     n20InvoiceLastLineId = false ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
                     O16InvoiceAmount = A16InvoiceAmount ;
                     n16InvoiceAmount = false ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
                  }
                  ScanEnd045( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000428 */
                     pr_default.execute(20, new Object[] {A14InvoiceId});
                     pr_default.close(20);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound4 == 0 )
                           {
                              InitAll044( ) ;
                              Gx_mode = "INS" ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           }
                           else
                           {
                              getByPrimaryKey( ) ;
                              Gx_mode = "UPD" ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           }
                           GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted"), 0, "");
                           ResetCaption040( ) ;
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
            }
         }
         sMode4 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel044( ) ;
         Gx_mode = sMode4 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls044( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000430 */
            pr_default.execute(21, new Object[] {A14InvoiceId});
            if ( (pr_default.getStatus(21) != 101) )
            {
               A20InvoiceLastLineId = T000430_A20InvoiceLastLineId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
               n20InvoiceLastLineId = T000430_n20InvoiceLastLineId[0] ;
            }
            else
            {
               A20InvoiceLastLineId = 0 ;
               n20InvoiceLastLineId = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
            }
            pr_default.close(21);
            /* Using cursor T000432 */
            pr_default.execute(22, new Object[] {A14InvoiceId});
            if ( (pr_default.getStatus(22) != 101) )
            {
               A16InvoiceAmount = T000432_A16InvoiceAmount[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
               n16InvoiceAmount = T000432_n16InvoiceAmount[0] ;
            }
            else
            {
               A16InvoiceAmount = 0 ;
               n16InvoiceAmount = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
            }
            pr_default.close(22);
            /* Using cursor T000433 */
            pr_default.execute(23, new Object[] {A3CustomerId});
            A4CustomerName = T000433_A4CustomerName[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CustomerName", A4CustomerName);
            A7CustomerTotalPurchases = T000433_A7CustomerTotalPurchases[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
            pr_default.close(23);
         }
      }

      protected void ProcessNestedLevel045( )
      {
         s20InvoiceLastLineId = O20InvoiceLastLineId ;
         n20InvoiceLastLineId = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
         s16InvoiceAmount = O16InvoiceAmount ;
         n16InvoiceAmount = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
         nGXsfl_65_idx = 0 ;
         while ( nGXsfl_65_idx < nRC_Gridinvoice_detail )
         {
            ReadRow045( ) ;
            if ( ( nRcdExists_5 != 0 ) || ( nIsMod_5 != 0 ) )
            {
               standaloneNotModal045( ) ;
               GetKey045( ) ;
               if ( ( nRcdExists_5 == 0 ) && ( nRcdDeleted_5 == 0 ) )
               {
                  if ( RcdFound5 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Insert045( ) ;
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtInvoiceDetailId_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound5 != 0 )
                  {
                     if ( ( nRcdDeleted_5 != 0 ) && ( nRcdExists_5 != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete045( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_5 != 0 ) && ( nRcdExists_5 != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update045( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_5 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtInvoiceDetailId_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
               O20InvoiceLastLineId = A20InvoiceLastLineId ;
               n20InvoiceLastLineId = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
               O16InvoiceAmount = A16InvoiceAmount ;
               n16InvoiceAmount = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
            }
            ChangePostValue( edtInvoiceDetailId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A17InvoiceDetailId), 2, 0, ".", ""))) ;
            ChangePostValue( edtProductId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A10ProductId), 6, 0, ".", ""))) ;
            ChangePostValue( edtProductDescription_Internalname, StringUtil.RTrim( A11ProductDescription)) ;
            ChangePostValue( edtProductPrice_Internalname, StringUtil.LTrim( StringUtil.NToC( A13ProductPrice, 9, 2, ".", ""))) ;
            ChangePostValue( edtInvoiceDetailQuantiity_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A18InvoiceDetailQuantiity), 3, 0, ".", ""))) ;
            ChangePostValue( edtInvoiceDetailAmount_Internalname, StringUtil.LTrim( StringUtil.NToC( A19InvoiceDetailAmount, 9, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z17InvoiceDetailId_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17InvoiceDetailId), 2, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z18InvoiceDetailQuantiity_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z18InvoiceDetailQuantiity), 3, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z10ProductId_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10ProductId), 6, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z11ProductDescription_"+sGXsfl_65_idx, StringUtil.RTrim( Z11ProductDescription)) ;
            ChangePostValue( "ZT_"+"Z13ProductPrice_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( Z13ProductPrice, 9, 2, ".", ""))) ;
            ChangePostValue( "T12ProductStock_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(O12ProductStock), 4, 0, ".", ""))) ;
            ChangePostValue( "T19InvoiceDetailAmount_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( O19InvoiceDetailAmount, 9, 2, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_5_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_5), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_5_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_5), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_5_"+sGXsfl_65_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_5), 4, 0, ".", ""))) ;
            if ( nIsMod_5 != 0 )
            {
               ChangePostValue( "INVOICEDETAILID_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtInvoiceDetailId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRODUCTID_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProductId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRODUCTDESCRIPTION_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProductDescription_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRODUCTPRICE_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProductPrice_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INVOICEDETAILQUANTIITY_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtInvoiceDetailQuantiity_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INVOICEDETAILAMOUNT_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtInvoiceDetailAmount_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll045( ) ;
         if ( AnyError != 0 )
         {
            O20InvoiceLastLineId = s20InvoiceLastLineId ;
            n20InvoiceLastLineId = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
            O16InvoiceAmount = s16InvoiceAmount ;
            n16InvoiceAmount = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
         }
         nRcdExists_5 = 0 ;
         nIsMod_5 = 0 ;
         nRcdDeleted_5 = 0 ;
      }

      protected void ProcessLevel044( )
      {
         /* Save parent mode. */
         sMode4 = Gx_mode ;
         ProcessNestedLevel045( ) ;
         if ( AnyError != 0 )
         {
            O20InvoiceLastLineId = s20InvoiceLastLineId ;
            n20InvoiceLastLineId = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
            O16InvoiceAmount = s16InvoiceAmount ;
            n16InvoiceAmount = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
         }
         /* Restore parent mode. */
         Gx_mode = sMode4 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel044( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(16);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete044( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(15);
            pr_default.close(14);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(23);
            pr_default.close(21);
            pr_default.close(22);
            pr_default.close(3);
            pr_default.close(2);
            context.CommitDataStores("Invoice");
            if ( AnyError == 0 )
            {
               ConfirmValues040( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(15);
            pr_default.close(14);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(23);
            pr_default.close(21);
            pr_default.close(22);
            pr_default.close(3);
            pr_default.close(2);
            context.RollbackDataStores("Invoice");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart044( )
      {
         /* Using cursor T000434 */
         pr_default.execute(24);
         RcdFound4 = 0 ;
         if ( (pr_default.getStatus(24) != 101) )
         {
            RcdFound4 = 1 ;
            A14InvoiceId = T000434_A14InvoiceId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14InvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14InvoiceId), 6, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext044( )
      {
         pr_default.readNext(24);
         RcdFound4 = 0 ;
         if ( (pr_default.getStatus(24) != 101) )
         {
            RcdFound4 = 1 ;
            A14InvoiceId = T000434_A14InvoiceId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14InvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14InvoiceId), 6, 0)));
         }
      }

      protected void ScanEnd044( )
      {
      }

      protected void AfterConfirm044( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert044( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate044( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete044( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete044( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate044( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes044( )
      {
         edtInvoiceId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvoiceId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvoiceId_Enabled), 5, 0)));
         edtInvoiceDate_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvoiceDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvoiceDate_Enabled), 5, 0)));
         edtCustomerId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCustomerId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCustomerId_Enabled), 5, 0)));
         edtCustomerName_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCustomerName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCustomerName_Enabled), 5, 0)));
         edtCustomerTotalPurchases_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCustomerTotalPurchases_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCustomerTotalPurchases_Enabled), 5, 0)));
         edtInvoiceAmount_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvoiceAmount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvoiceAmount_Enabled), 5, 0)));
      }

      protected void ZM045( short GX_JID )
      {
         if ( ( GX_JID == 17 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z18InvoiceDetailQuantiity = T00043_A18InvoiceDetailQuantiity[0] ;
               Z10ProductId = T00043_A10ProductId[0] ;
            }
            else
            {
               Z18InvoiceDetailQuantiity = A18InvoiceDetailQuantiity ;
               Z10ProductId = A10ProductId ;
            }
         }
         if ( ( GX_JID == 18 ) || ( GX_JID == 0 ) )
         {
            Z11ProductDescription = T00045_A11ProductDescription[0] ;
            Z13ProductPrice = T00045_A13ProductPrice[0] ;
         }
         if ( GX_JID == -17 )
         {
            Z14InvoiceId = A14InvoiceId ;
            Z17InvoiceDetailId = A17InvoiceDetailId ;
            Z18InvoiceDetailQuantiity = A18InvoiceDetailQuantiity ;
            Z10ProductId = A10ProductId ;
            Z12ProductStock = A12ProductStock ;
            Z11ProductDescription = A11ProductDescription ;
            Z13ProductPrice = A13ProductPrice ;
         }
      }

      protected void standaloneNotModal045( )
      {
      }

      protected void standaloneModal045( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A20InvoiceLastLineId = (short)(O20InvoiceLastLineId+1) ;
            n20InvoiceLastLineId = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && ( Gx_BScreen == 1 ) )
         {
            A17InvoiceDetailId = A20InvoiceLastLineId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17InvoiceDetailId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17InvoiceDetailId), 2, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtInvoiceDetailId_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvoiceDetailId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvoiceDetailId_Enabled), 5, 0)));
         }
         else
         {
            edtInvoiceDetailId_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvoiceDetailId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvoiceDetailId_Enabled), 5, 0)));
         }
         if ( ( StringUtil.StrCmp(sMode5, "DSP") == 0 ) || ( StringUtil.StrCmp(sMode5, "DLT") == 0 ) )
         {
            DisableAttributes045( ) ;
         }
      }

      protected void Load045( )
      {
         /* Using cursor T000435 */
         pr_default.execute(25, new Object[] {A14InvoiceId, A17InvoiceDetailId});
         if ( (pr_default.getStatus(25) != 101) )
         {
            RcdFound5 = 1 ;
            A12ProductStock = T000435_A12ProductStock[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12ProductStock", StringUtil.LTrim( StringUtil.Str( (decimal)(A12ProductStock), 4, 0)));
            A11ProductDescription = T000435_A11ProductDescription[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11ProductDescription", A11ProductDescription);
            A13ProductPrice = T000435_A13ProductPrice[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ProductPrice", StringUtil.LTrim( StringUtil.Str( A13ProductPrice, 9, 2)));
            A18InvoiceDetailQuantiity = T000435_A18InvoiceDetailQuantiity[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18InvoiceDetailQuantiity", StringUtil.LTrim( StringUtil.Str( (decimal)(A18InvoiceDetailQuantiity), 3, 0)));
            A10ProductId = T000435_A10ProductId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10ProductId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10ProductId), 6, 0)));
            ZM045( -17) ;
         }
         pr_default.close(25);
         OnLoadActions045( ) ;
      }

      protected void OnLoadActions045( )
      {
         if ( A12ProductStock - A18InvoiceDetailQuantiity >= 0 )
         {
            A12ProductStock = (short)(O12ProductStock-A18InvoiceDetailQuantiity) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12ProductStock", StringUtil.LTrim( StringUtil.Str( (decimal)(A12ProductStock), 4, 0)));
         }
         A19InvoiceDetailAmount = (decimal)(A13ProductPrice*A18InvoiceDetailQuantiity) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19InvoiceDetailAmount", StringUtil.LTrim( StringUtil.Str( A19InvoiceDetailAmount, 9, 2)));
         O19InvoiceDetailAmount = A19InvoiceDetailAmount ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19InvoiceDetailAmount", StringUtil.LTrim( StringUtil.Str( A19InvoiceDetailAmount, 9, 2)));
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A16InvoiceAmount = (decimal)(O16InvoiceAmount+A19InvoiceDetailAmount) ;
            n16InvoiceAmount = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A16InvoiceAmount = (decimal)(O16InvoiceAmount+A19InvoiceDetailAmount-O19InvoiceDetailAmount) ;
               n16InvoiceAmount = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A16InvoiceAmount = (decimal)(O16InvoiceAmount-O19InvoiceDetailAmount) ;
                  n16InvoiceAmount = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
               }
            }
         }
         A19InvoiceDetailAmount = (decimal)(A13ProductPrice*A18InvoiceDetailQuantiity) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19InvoiceDetailAmount", StringUtil.LTrim( StringUtil.Str( A19InvoiceDetailAmount, 9, 2)));
         O19InvoiceDetailAmount = A19InvoiceDetailAmount ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19InvoiceDetailAmount", StringUtil.LTrim( StringUtil.Str( A19InvoiceDetailAmount, 9, 2)));
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A20InvoiceLastLineId = (short)(O20InvoiceLastLineId+1) ;
            n20InvoiceLastLineId = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A20InvoiceLastLineId = O20InvoiceLastLineId ;
               n20InvoiceLastLineId = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A20InvoiceLastLineId = (short)(O20InvoiceLastLineId-1) ;
                  n20InvoiceLastLineId = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
               }
            }
         }
      }

      protected void CheckExtendedTable045( )
      {
         Gx_BScreen = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal045( ) ;
         /* Using cursor T00045 */
         pr_default.execute(3, new Object[] {A10ProductId});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No matching 'Product'.", "ForeignKeyNotFound", 1, "PRODUCTID");
            AnyError = 1 ;
            GX_FocusControl = edtProductId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A12ProductStock = T00045_A12ProductStock[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12ProductStock", StringUtil.LTrim( StringUtil.Str( (decimal)(A12ProductStock), 4, 0)));
            A11ProductDescription = T00045_A11ProductDescription[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11ProductDescription", A11ProductDescription);
            A13ProductPrice = T00045_A13ProductPrice[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ProductPrice", StringUtil.LTrim( StringUtil.Str( A13ProductPrice, 9, 2)));
            O12ProductStock = A12ProductStock ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12ProductStock", StringUtil.LTrim( StringUtil.Str( (decimal)(A12ProductStock), 4, 0)));
         }
         pr_default.close(3);
         if ( A12ProductStock - A18InvoiceDetailQuantiity >= 0 )
         {
            A12ProductStock = (short)(O12ProductStock-A18InvoiceDetailQuantiity) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12ProductStock", StringUtil.LTrim( StringUtil.Str( (decimal)(A12ProductStock), 4, 0)));
         }
         A19InvoiceDetailAmount = (decimal)(A13ProductPrice*A18InvoiceDetailQuantiity) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19InvoiceDetailAmount", StringUtil.LTrim( StringUtil.Str( A19InvoiceDetailAmount, 9, 2)));
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A16InvoiceAmount = (decimal)(O16InvoiceAmount+A19InvoiceDetailAmount) ;
            n16InvoiceAmount = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A16InvoiceAmount = (decimal)(O16InvoiceAmount+A19InvoiceDetailAmount-O19InvoiceDetailAmount) ;
               n16InvoiceAmount = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A16InvoiceAmount = (decimal)(O16InvoiceAmount-O19InvoiceDetailAmount) ;
                  n16InvoiceAmount = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
               }
            }
         }
         A19InvoiceDetailAmount = (decimal)(A13ProductPrice*A18InvoiceDetailQuantiity) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19InvoiceDetailAmount", StringUtil.LTrim( StringUtil.Str( A19InvoiceDetailAmount, 9, 2)));
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A20InvoiceLastLineId = (short)(O20InvoiceLastLineId+1) ;
            n20InvoiceLastLineId = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
            {
               A20InvoiceLastLineId = O20InvoiceLastLineId ;
               n20InvoiceLastLineId = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A20InvoiceLastLineId = (short)(O20InvoiceLastLineId-1) ;
                  n20InvoiceLastLineId = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
               }
            }
         }
      }

      protected void CloseExtendedTableCursors045( )
      {
         pr_default.close(3);
      }

      protected void enableDisable045( )
      {
      }

      protected void gxLoad_18( int A10ProductId )
      {
         /* Using cursor T000436 */
         pr_default.execute(26, new Object[] {A10ProductId});
         if ( (pr_default.getStatus(26) == 101) )
         {
            GX_msglist.addItem("No matching 'Product'.", "ForeignKeyNotFound", 1, "PRODUCTID");
            AnyError = 1 ;
            GX_FocusControl = edtProductId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A12ProductStock = T000436_A12ProductStock[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12ProductStock", StringUtil.LTrim( StringUtil.Str( (decimal)(A12ProductStock), 4, 0)));
            A11ProductDescription = T000436_A11ProductDescription[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11ProductDescription", A11ProductDescription);
            A13ProductPrice = T000436_A13ProductPrice[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ProductPrice", StringUtil.LTrim( StringUtil.Str( A13ProductPrice, 9, 2)));
            O12ProductStock = A12ProductStock ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12ProductStock", StringUtil.LTrim( StringUtil.Str( (decimal)(A12ProductStock), 4, 0)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A12ProductStock), 4, 0, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A11ProductDescription))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A13ProductPrice, 9, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(26) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(26);
      }

      protected void GetKey045( )
      {
         /* Using cursor T000437 */
         pr_default.execute(27, new Object[] {A14InvoiceId, A17InvoiceDetailId});
         if ( (pr_default.getStatus(27) != 101) )
         {
            RcdFound5 = 1 ;
         }
         else
         {
            RcdFound5 = 0 ;
         }
         pr_default.close(27);
      }

      protected void getByPrimaryKey045( )
      {
         /* Using cursor T00043 */
         pr_default.execute(1, new Object[] {A14InvoiceId, A17InvoiceDetailId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM045( 17) ;
            RcdFound5 = 1 ;
            InitializeNonKey045( ) ;
            A17InvoiceDetailId = T00043_A17InvoiceDetailId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17InvoiceDetailId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17InvoiceDetailId), 2, 0)));
            A18InvoiceDetailQuantiity = T00043_A18InvoiceDetailQuantiity[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18InvoiceDetailQuantiity", StringUtil.LTrim( StringUtil.Str( (decimal)(A18InvoiceDetailQuantiity), 3, 0)));
            A10ProductId = T00043_A10ProductId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10ProductId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10ProductId), 6, 0)));
            Z14InvoiceId = A14InvoiceId ;
            Z17InvoiceDetailId = A17InvoiceDetailId ;
            sMode5 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal045( ) ;
            Load045( ) ;
            Gx_mode = sMode5 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound5 = 0 ;
            InitializeNonKey045( ) ;
            sMode5 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal045( ) ;
            Gx_mode = sMode5 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency045( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00042 */
            pr_default.execute(0, new Object[] {A14InvoiceId, A17InvoiceDetailId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"InvoiceDetail"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z18InvoiceDetailQuantiity != T00042_A18InvoiceDetailQuantiity[0] ) || ( Z10ProductId != T00042_A10ProductId[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"InvoiceDetail"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
         /* Using cursor T00044 */
         pr_default.execute(2, new Object[] {A10ProductId});
         if ( (pr_default.getStatus(2) == 103) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Product"}), "RecordIsLocked", 1, "");
            AnyError = 1 ;
            return  ;
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            if ( false || ( StringUtil.StrCmp(Z11ProductDescription, T00044_A11ProductDescription[0]) != 0 ) || ( Z13ProductPrice != T00044_A13ProductPrice[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Product"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert045( )
      {
         BeforeValidate045( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable045( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM045( 0) ;
            CheckOptimisticConcurrency045( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm045( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert045( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000438 */
                     pr_default.execute(28, new Object[] {A14InvoiceId, A17InvoiceDetailId, A18InvoiceDetailQuantiity, A10ProductId});
                     pr_default.close(28);
                     if ( (pr_default.getStatus(28) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1 ;
                     }
                     if ( AnyError == 0 )
                     {
                        UpdateTablesN1045( ) ;
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
            else
            {
               Load045( ) ;
            }
            EndLevel045( ) ;
         }
         CloseExtendedTableCursors045( ) ;
      }

      protected void Update045( )
      {
         BeforeValidate045( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable045( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency045( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm045( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate045( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000439 */
                     pr_default.execute(29, new Object[] {A18InvoiceDetailQuantiity, A10ProductId, A14InvoiceId, A17InvoiceDetailId});
                     pr_default.close(29);
                     if ( (pr_default.getStatus(29) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"InvoiceDetail"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate045( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           UpdateTablesN1045( ) ;
                           getByPrimaryKey045( ) ;
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
            }
            EndLevel045( ) ;
         }
         CloseExtendedTableCursors045( ) ;
      }

      protected void DeferredUpdate045( )
      {
      }

      protected void Delete045( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate045( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency045( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls045( ) ;
            AfterConfirm045( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete045( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000440 */
                  pr_default.execute(30, new Object[] {A14InvoiceId, A17InvoiceDetailId});
                  pr_default.close(30);
                  if ( AnyError == 0 )
                  {
                     UpdateTablesN1045( ) ;
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
         }
         sMode5 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel045( ) ;
         Gx_mode = sMode5 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls045( )
      {
         standaloneModal045( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000441 */
            pr_default.execute(31, new Object[] {A10ProductId});
            Z11ProductDescription = T000441_A11ProductDescription[0] ;
            Z13ProductPrice = T000441_A13ProductPrice[0] ;
            A12ProductStock = T000441_A12ProductStock[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12ProductStock", StringUtil.LTrim( StringUtil.Str( (decimal)(A12ProductStock), 4, 0)));
            A11ProductDescription = T000441_A11ProductDescription[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11ProductDescription", A11ProductDescription);
            A13ProductPrice = T000441_A13ProductPrice[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ProductPrice", StringUtil.LTrim( StringUtil.Str( A13ProductPrice, 9, 2)));
            O12ProductStock = A12ProductStock ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12ProductStock", StringUtil.LTrim( StringUtil.Str( (decimal)(A12ProductStock), 4, 0)));
            pr_default.close(31);
            A19InvoiceDetailAmount = (decimal)(A13ProductPrice*A18InvoiceDetailQuantiity) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19InvoiceDetailAmount", StringUtil.LTrim( StringUtil.Str( A19InvoiceDetailAmount, 9, 2)));
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               A16InvoiceAmount = (decimal)(O16InvoiceAmount+A19InvoiceDetailAmount) ;
               n16InvoiceAmount = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
               {
                  A16InvoiceAmount = (decimal)(O16InvoiceAmount+A19InvoiceDetailAmount-O19InvoiceDetailAmount) ;
                  n16InvoiceAmount = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
               }
               else
               {
                  if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
                  {
                     A16InvoiceAmount = (decimal)(O16InvoiceAmount-O19InvoiceDetailAmount) ;
                     n16InvoiceAmount = false ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
                  }
               }
            }
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               A20InvoiceLastLineId = (short)(O20InvoiceLastLineId+1) ;
               n20InvoiceLastLineId = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
               {
                  A20InvoiceLastLineId = O20InvoiceLastLineId ;
                  n20InvoiceLastLineId = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
               }
               else
               {
                  if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
                  {
                     A20InvoiceLastLineId = (short)(O20InvoiceLastLineId-1) ;
                     n20InvoiceLastLineId = false ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
                  }
               }
            }
            A19InvoiceDetailAmount = (decimal)(A13ProductPrice*A18InvoiceDetailQuantiity) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19InvoiceDetailAmount", StringUtil.LTrim( StringUtil.Str( A19InvoiceDetailAmount, 9, 2)));
            if ( A12ProductStock - A18InvoiceDetailQuantiity >= 0 )
            {
               A12ProductStock = (short)(O12ProductStock-A18InvoiceDetailQuantiity) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12ProductStock", StringUtil.LTrim( StringUtil.Str( (decimal)(A12ProductStock), 4, 0)));
            }
         }
      }

      protected void UpdateTablesN1045( )
      {
         /* Using cursor T000442 */
         pr_default.execute(32, new Object[] {A12ProductStock, A10ProductId});
         pr_default.close(32);
      }

      protected void EndLevel045( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         pr_default.close(2);
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart045( )
      {
         /* Using cursor T000443 */
         pr_default.execute(33, new Object[] {A14InvoiceId});
         RcdFound5 = 0 ;
         if ( (pr_default.getStatus(33) != 101) )
         {
            RcdFound5 = 1 ;
            A17InvoiceDetailId = T000443_A17InvoiceDetailId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17InvoiceDetailId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17InvoiceDetailId), 2, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext045( )
      {
         pr_default.readNext(33);
         RcdFound5 = 0 ;
         if ( (pr_default.getStatus(33) != 101) )
         {
            RcdFound5 = 1 ;
            A17InvoiceDetailId = T000443_A17InvoiceDetailId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17InvoiceDetailId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17InvoiceDetailId), 2, 0)));
         }
      }

      protected void ScanEnd045( )
      {
         pr_default.close(1);
      }

      protected void AfterConfirm045( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert045( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate045( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete045( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete045( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate045( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes045( )
      {
         edtInvoiceDetailId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvoiceDetailId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvoiceDetailId_Enabled), 5, 0)));
         edtProductId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProductId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProductId_Enabled), 5, 0)));
         edtProductDescription_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProductDescription_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProductDescription_Enabled), 5, 0)));
         edtProductPrice_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProductPrice_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProductPrice_Enabled), 5, 0)));
         edtInvoiceDetailQuantiity_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvoiceDetailQuantiity_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvoiceDetailQuantiity_Enabled), 5, 0)));
         edtInvoiceDetailAmount_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvoiceDetailAmount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvoiceDetailAmount_Enabled), 5, 0)));
      }

      protected void AddRow045( )
      {
         nGXsfl_65_idx = (short)(nGXsfl_65_idx+1) ;
         sGXsfl_65_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_65_idx), 4, 0)), 4, "0") ;
         edtInvoiceDetailId_Internalname = "INVOICEDETAILID_"+sGXsfl_65_idx ;
         edtProductId_Internalname = "PRODUCTID_"+sGXsfl_65_idx ;
         imgprompt_10_Internalname = "PROMPT_10_"+sGXsfl_65_idx ;
         edtProductDescription_Internalname = "PRODUCTDESCRIPTION_"+sGXsfl_65_idx ;
         edtProductPrice_Internalname = "PRODUCTPRICE_"+sGXsfl_65_idx ;
         edtInvoiceDetailQuantiity_Internalname = "INVOICEDETAILQUANTIITY_"+sGXsfl_65_idx ;
         edtInvoiceDetailAmount_Internalname = "INVOICEDETAILAMOUNT_"+sGXsfl_65_idx ;
         SendRow045( ) ;
      }

      protected void SendRow045( )
      {
         Gridinvoice_detailRow = GXWebRow.GetNew(context) ;
         if ( subGridinvoice_detail_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridinvoice_detail_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGridinvoice_detail_Class, "") != 0 )
            {
               subGridinvoice_detail_Linesclass = subGridinvoice_detail_Class+"Odd" ;
            }
         }
         else if ( subGridinvoice_detail_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridinvoice_detail_Backstyle = 0 ;
            subGridinvoice_detail_Backcolor = subGridinvoice_detail_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridinvoice_detailContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridinvoice_detail_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGridinvoice_detail_Class, "") != 0 )
            {
               subGridinvoice_detail_Linesclass = subGridinvoice_detail_Class+"Uniform" ;
            }
         }
         else if ( subGridinvoice_detail_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridinvoice_detail_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGridinvoice_detail_Class, "") != 0 )
            {
               subGridinvoice_detail_Linesclass = subGridinvoice_detail_Class+"Odd" ;
            }
            subGridinvoice_detail_Backcolor = (int)(0xF0F0F0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridinvoice_detailContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridinvoice_detail_Backcolor), 9, 0)));
         }
         else if ( subGridinvoice_detail_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridinvoice_detail_Backstyle = 1 ;
            if ( ((int)(nGXsfl_65_idx) % (2)) == 0 )
            {
               subGridinvoice_detail_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridinvoice_detailContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridinvoice_detail_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridinvoice_detail_Class, "") != 0 )
               {
                  subGridinvoice_detail_Linesclass = subGridinvoice_detail_Class+"Even" ;
               }
            }
            else
            {
               subGridinvoice_detail_Backcolor = (int)(0xF0F0F0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridinvoice_detailContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridinvoice_detail_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridinvoice_detail_Class, "") != 0 )
               {
                  subGridinvoice_detail_Linesclass = subGridinvoice_detail_Class+"Odd" ;
               }
            }
         }
         imgprompt_10_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PRODUCTID_"+sGXsfl_65_idx+"'), id:'"+"PRODUCTID_"+sGXsfl_65_idx+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"gx.dom.form()."+"nIsMod_5_"+sGXsfl_65_idx+","+"'', false"+","+"false"+");") ;
         /* * Property Link not supported in */
         /* * Property Link not supported in */
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_5_" + sGXsfl_65_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_65_idx + "',65)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridinvoice_detailRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtInvoiceDetailId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A17InvoiceDetailId), 2, 0, ".", "")),(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)2,(short)-1,(int)edtInvoiceDetailId_Enabled,(short)1,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A17InvoiceDetailId), "Z9"),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(66);\"",(short)0,(String)edtInvoiceDetailId_Jsonclick,(String)"",(short)65,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_5_" + sGXsfl_65_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 67,'',false,'" + sGXsfl_65_idx + "',65)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridinvoice_detailRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProductId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A10ProductId), 6, 0, ".", "")),(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)6,(short)-1,(int)edtProductId_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A10ProductId), "ZZZZZ9"),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(67);\"",(short)0,(String)edtProductId_Jsonclick,(String)"",(short)65,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "Image" ;
         StyleString = "" ;
         Gridinvoice_detailRow.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)imgprompt_10_Internalname,(String)"","prompt.gif",(String)"GeneXusX",(int)imgprompt_10_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(String)imgprompt_10_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
         /* Subfile cell */
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridinvoice_detailRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProductDescription_Internalname,StringUtil.RTrim( A11ProductDescription),(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)30,(short)-1,(int)edtProductDescription_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A11ProductDescription, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtProductDescription_Jsonclick,(String)"",(short)65,(short)1,(short)-1,(bool)true,(String)"left"});
         /* Subfile cell */
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridinvoice_detailRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProductPrice_Internalname,StringUtil.LTrim( StringUtil.NToC( A13ProductPrice, 9, 2, ".", "")),(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)-1,(int)edtProductPrice_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A13ProductPrice, "ZZZZZ9.99"),(String)"",(short)0,(String)edtProductPrice_Jsonclick,(String)"",(short)65,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_5_" + sGXsfl_65_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 70,'',false,'" + sGXsfl_65_idx + "',65)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridinvoice_detailRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtInvoiceDetailQuantiity_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A18InvoiceDetailQuantiity), 3, 0, ".", "")),(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)-1,(int)edtInvoiceDetailQuantiity_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A18InvoiceDetailQuantiity), "ZZ9"),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(70);\"",(short)0,(String)edtInvoiceDetailQuantiity_Jsonclick,(String)"",(short)65,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridinvoice_detailRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtInvoiceDetailAmount_Internalname,StringUtil.LTrim( StringUtil.NToC( A19InvoiceDetailAmount, 9, 2, ".", "")),(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)-1,(int)edtInvoiceDetailAmount_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A19InvoiceDetailAmount, "ZZZZZ9.99"),(String)"",(short)0,(String)edtInvoiceDetailAmount_Jsonclick,(String)"",(short)65,(short)1,(short)-1,(bool)true,(String)"right"});
         context.httpAjaxContext.ajax_sending_grid_row(Gridinvoice_detailRow);
         GXCCtl = "Z17InvoiceDetailId_" + sGXsfl_65_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17InvoiceDetailId), 2, 0, ".", "")));
         GXCCtl = "Z18InvoiceDetailQuantiity_" + sGXsfl_65_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z18InvoiceDetailQuantiity), 3, 0, ".", "")));
         GXCCtl = "Z10ProductId_" + sGXsfl_65_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10ProductId), 6, 0, ".", "")));
         GXCCtl = "Z11ProductDescription_" + sGXsfl_65_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z11ProductDescription));
         GXCCtl = "Z13ProductPrice_" + sGXsfl_65_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z13ProductPrice, 9, 2, ".", "")));
         GXCCtl = "O12ProductStock_" + sGXsfl_65_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(O12ProductStock), 4, 0, ".", "")));
         GXCCtl = "O19InvoiceDetailAmount_" + sGXsfl_65_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( O19InvoiceDetailAmount, 9, 2, ".", "")));
         GXCCtl = "PRODUCTSTOCK_" + sGXsfl_65_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(A12ProductStock), 4, 0, ".", "")));
         GXCCtl = "nRcdDeleted_5_" + sGXsfl_65_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_5), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_5_" + sGXsfl_65_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_5), 4, 0, ".", "")));
         GXCCtl = "nIsMod_5_" + sGXsfl_65_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_5), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "INVOICEDETAILID_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtInvoiceDetailId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PRODUCTID_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProductId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PRODUCTDESCRIPTION_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProductDescription_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PRODUCTPRICE_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProductPrice_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "INVOICEDETAILQUANTIITY_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtInvoiceDetailQuantiity_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "INVOICEDETAILAMOUNT_"+sGXsfl_65_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtInvoiceDetailAmount_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_10_"+sGXsfl_65_idx+"Link", StringUtil.RTrim( imgprompt_10_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridinvoice_detailContainer.AddRow(Gridinvoice_detailRow);
      }

      protected void ReadRow045( )
      {
         nGXsfl_65_idx = (short)(nGXsfl_65_idx+1) ;
         sGXsfl_65_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_65_idx), 4, 0)), 4, "0") ;
         edtInvoiceDetailId_Internalname = "INVOICEDETAILID_"+sGXsfl_65_idx ;
         edtProductId_Internalname = "PRODUCTID_"+sGXsfl_65_idx ;
         imgprompt_10_Internalname = "PROMPT_10_"+sGXsfl_65_idx ;
         edtProductDescription_Internalname = "PRODUCTDESCRIPTION_"+sGXsfl_65_idx ;
         edtProductPrice_Internalname = "PRODUCTPRICE_"+sGXsfl_65_idx ;
         edtInvoiceDetailQuantiity_Internalname = "INVOICEDETAILQUANTIITY_"+sGXsfl_65_idx ;
         edtInvoiceDetailAmount_Internalname = "INVOICEDETAILAMOUNT_"+sGXsfl_65_idx ;
         edtInvoiceDetailId_Enabled = (int)(context.localUtil.CToN( cgiGet( "INVOICEDETAILID_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvoiceDetailId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvoiceDetailId_Enabled), 5, 0)));
         edtProductId_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRODUCTID_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProductId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProductId_Enabled), 5, 0)));
         edtProductDescription_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRODUCTDESCRIPTION_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProductDescription_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProductDescription_Enabled), 5, 0)));
         edtProductPrice_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRODUCTPRICE_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProductPrice_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProductPrice_Enabled), 5, 0)));
         edtInvoiceDetailQuantiity_Enabled = (int)(context.localUtil.CToN( cgiGet( "INVOICEDETAILQUANTIITY_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvoiceDetailQuantiity_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvoiceDetailQuantiity_Enabled), 5, 0)));
         edtInvoiceDetailAmount_Enabled = (int)(context.localUtil.CToN( cgiGet( "INVOICEDETAILAMOUNT_"+sGXsfl_65_idx+"Enabled"), ".", ",")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvoiceDetailAmount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvoiceDetailAmount_Enabled), 5, 0)));
         imgprompt_3_Link = cgiGet( "PROMPT_10_"+sGXsfl_65_idx+"Link") ;
         if ( ( ( context.localUtil.CToN( cgiGet( edtInvoiceDetailId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtInvoiceDetailId_Internalname), ".", ",") > Convert.ToDecimal( 99 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "INVOICEDETAILID");
            AnyError = 1 ;
            GX_FocusControl = edtInvoiceDetailId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A17InvoiceDetailId = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17InvoiceDetailId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17InvoiceDetailId), 2, 0)));
         }
         else
         {
            A17InvoiceDetailId = (short)(context.localUtil.CToN( cgiGet( edtInvoiceDetailId_Internalname), ".", ",")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17InvoiceDetailId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17InvoiceDetailId), 2, 0)));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtProductId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtProductId_Internalname), ".", ",") > Convert.ToDecimal( 999999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "PRODUCTID");
            AnyError = 1 ;
            GX_FocusControl = edtProductId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A10ProductId = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10ProductId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10ProductId), 6, 0)));
         }
         else
         {
            A10ProductId = (int)(context.localUtil.CToN( cgiGet( edtProductId_Internalname), ".", ",")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10ProductId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10ProductId), 6, 0)));
         }
         A11ProductDescription = cgiGet( edtProductDescription_Internalname) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11ProductDescription", A11ProductDescription);
         A13ProductPrice = context.localUtil.CToN( cgiGet( edtProductPrice_Internalname), ".", ",") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ProductPrice", StringUtil.LTrim( StringUtil.Str( A13ProductPrice, 9, 2)));
         if ( ( ( context.localUtil.CToN( cgiGet( edtInvoiceDetailQuantiity_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtInvoiceDetailQuantiity_Internalname), ".", ",") > Convert.ToDecimal( 999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "INVOICEDETAILQUANTIITY");
            AnyError = 1 ;
            GX_FocusControl = edtInvoiceDetailQuantiity_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A18InvoiceDetailQuantiity = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18InvoiceDetailQuantiity", StringUtil.LTrim( StringUtil.Str( (decimal)(A18InvoiceDetailQuantiity), 3, 0)));
         }
         else
         {
            A18InvoiceDetailQuantiity = (short)(context.localUtil.CToN( cgiGet( edtInvoiceDetailQuantiity_Internalname), ".", ",")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18InvoiceDetailQuantiity", StringUtil.LTrim( StringUtil.Str( (decimal)(A18InvoiceDetailQuantiity), 3, 0)));
         }
         A19InvoiceDetailAmount = context.localUtil.CToN( cgiGet( edtInvoiceDetailAmount_Internalname), ".", ",") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19InvoiceDetailAmount", StringUtil.LTrim( StringUtil.Str( A19InvoiceDetailAmount, 9, 2)));
         GXCCtl = "Z17InvoiceDetailId_" + sGXsfl_65_idx ;
         Z17InvoiceDetailId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "Z18InvoiceDetailQuantiity_" + sGXsfl_65_idx ;
         Z18InvoiceDetailQuantiity = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "Z10ProductId_" + sGXsfl_65_idx ;
         Z10ProductId = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "Z11ProductDescription_" + sGXsfl_65_idx ;
         Z11ProductDescription = cgiGet( GXCCtl) ;
         GXCCtl = "Z13ProductPrice_" + sGXsfl_65_idx ;
         Z13ProductPrice = context.localUtil.CToN( cgiGet( GXCCtl), ".", ",") ;
         GXCCtl = "O12ProductStock_" + sGXsfl_65_idx ;
         O12ProductStock = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "O19InvoiceDetailAmount_" + sGXsfl_65_idx ;
         O19InvoiceDetailAmount = context.localUtil.CToN( cgiGet( GXCCtl), ".", ",") ;
         GXCCtl = "PRODUCTSTOCK_" + sGXsfl_65_idx ;
         A12ProductStock = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdDeleted_5_" + sGXsfl_65_idx ;
         nRcdDeleted_5 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nRcdExists_5_" + sGXsfl_65_idx ;
         nRcdExists_5 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
         GXCCtl = "nIsMod_5_" + sGXsfl_65_idx ;
         nIsMod_5 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ",")) ;
      }

      protected void assign_properties_default( )
      {
         defedtInvoiceDetailId_Enabled = edtInvoiceDetailId_Enabled ;
      }

      protected void ConfirmValues040( )
      {
         nGXsfl_65_idx = 0 ;
         sGXsfl_65_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_65_idx), 4, 0)), 4, "0") ;
         edtInvoiceDetailId_Internalname = "INVOICEDETAILID_"+sGXsfl_65_idx ;
         edtProductId_Internalname = "PRODUCTID_"+sGXsfl_65_idx ;
         imgprompt_10_Internalname = "PROMPT_10_"+sGXsfl_65_idx ;
         edtProductDescription_Internalname = "PRODUCTDESCRIPTION_"+sGXsfl_65_idx ;
         edtProductPrice_Internalname = "PRODUCTPRICE_"+sGXsfl_65_idx ;
         edtInvoiceDetailQuantiity_Internalname = "INVOICEDETAILQUANTIITY_"+sGXsfl_65_idx ;
         edtInvoiceDetailAmount_Internalname = "INVOICEDETAILAMOUNT_"+sGXsfl_65_idx ;
         while ( nGXsfl_65_idx < nRC_Gridinvoice_detail )
         {
            nGXsfl_65_idx = (short)(nGXsfl_65_idx+1) ;
            sGXsfl_65_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_65_idx), 4, 0)), 4, "0") ;
            edtInvoiceDetailId_Internalname = "INVOICEDETAILID_"+sGXsfl_65_idx ;
            edtProductId_Internalname = "PRODUCTID_"+sGXsfl_65_idx ;
            imgprompt_10_Internalname = "PROMPT_10_"+sGXsfl_65_idx ;
            edtProductDescription_Internalname = "PRODUCTDESCRIPTION_"+sGXsfl_65_idx ;
            edtProductPrice_Internalname = "PRODUCTPRICE_"+sGXsfl_65_idx ;
            edtInvoiceDetailQuantiity_Internalname = "INVOICEDETAILQUANTIITY_"+sGXsfl_65_idx ;
            edtInvoiceDetailAmount_Internalname = "INVOICEDETAILAMOUNT_"+sGXsfl_65_idx ;
            ChangePostValue( "Z17InvoiceDetailId_"+sGXsfl_65_idx, cgiGet( "ZT_"+"Z17InvoiceDetailId_"+sGXsfl_65_idx)) ;
            DeletePostValue( "ZT_"+"Z17InvoiceDetailId_"+sGXsfl_65_idx) ;
            ChangePostValue( "Z18InvoiceDetailQuantiity_"+sGXsfl_65_idx, cgiGet( "ZT_"+"Z18InvoiceDetailQuantiity_"+sGXsfl_65_idx)) ;
            DeletePostValue( "ZT_"+"Z18InvoiceDetailQuantiity_"+sGXsfl_65_idx) ;
            ChangePostValue( "Z10ProductId_"+sGXsfl_65_idx, cgiGet( "ZT_"+"Z10ProductId_"+sGXsfl_65_idx)) ;
            DeletePostValue( "ZT_"+"Z10ProductId_"+sGXsfl_65_idx) ;
            ChangePostValue( "Z11ProductDescription_"+sGXsfl_65_idx, cgiGet( "ZT_"+"Z11ProductDescription_"+sGXsfl_65_idx)) ;
            DeletePostValue( "ZT_"+"Z11ProductDescription_"+sGXsfl_65_idx) ;
            ChangePostValue( "Z13ProductPrice_"+sGXsfl_65_idx, cgiGet( "ZT_"+"Z13ProductPrice_"+sGXsfl_65_idx)) ;
            DeletePostValue( "ZT_"+"Z13ProductPrice_"+sGXsfl_65_idx) ;
         }
         ChangePostValue( "O12ProductStock", cgiGet( "T12ProductStock")) ;
         DeletePostValue( "T12ProductStock") ;
         ChangePostValue( "O19InvoiceDetailAmount", cgiGet( "T19InvoiceDetailAmount")) ;
         DeletePostValue( "T19InvoiceDetailAmount") ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      public override void RenderHtmlOpenForm( )
      {
         context.WriteHtmlText( "<title>") ;
         context.WriteHtmlText( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         if ( ! context.isSmartDevice( ) )
         {
            context.AddJavascriptSource("gxgral.js", "?46473");
            context.AddJavascriptSource("gxcfg.js", "?46473");
         }
         else
         {
            context.AddJavascriptSource("gxapiSD.js", "?46473");
            context.AddJavascriptSource("gxfxSD.js", "?46473");
            context.AddJavascriptSource("gxtypesSD.js", "?46473");
            context.AddJavascriptSource("gxpopupSD.js", "?46473");
            context.AddJavascriptSource("gxfrmutlSD.js", "?46473");
            context.AddJavascriptSource("gxgridSD.js", "?46473");
            context.AddJavascriptSource("JavaScripTableSD.js", "?46473");
            context.AddJavascriptSource("rijndaelSD.js", "?46473");
            context.AddJavascriptSource("gxgralSD.js", "?46473");
            context.AddJavascriptSource("gxcfg.js", "?46473");
         }
         context.AddJavascriptSource("calendar.js", "?46473");
         context.AddJavascriptSource("calendar-setup.js", "?46473");
         context.AddJavascriptSource("calendar-en.js", "?46473");
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("invoice.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z14InvoiceId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z14InvoiceId), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z15InvoiceDate", context.localUtil.DToC( Z15InvoiceDate, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z3CustomerId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z3CustomerId), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "O20InvoiceLastLineId", StringUtil.LTrim( StringUtil.NToC( (decimal)(O20InvoiceLastLineId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "O16InvoiceAmount", StringUtil.LTrim( StringUtil.NToC( O16InvoiceAmount, 9, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_Gridinvoice_detail", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_65_idx), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vTODAY", context.localUtil.DToC( Gx_date, 0, "/"));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "INVOICELASTLINEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A20InvoiceLastLineId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "PRODUCTSTOCK", StringUtil.LTrim( StringUtil.NToC( (decimal)(A12ProductStock), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         Draw( ) ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Invoice" ;
      }

      public override String GetPgmdesc( )
      {
         return "Invoice" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("invoice.aspx")  ;
      }

      protected void InitializeNonKey044( )
      {
         A3CustomerId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3CustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3CustomerId), 6, 0)));
         A4CustomerName = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CustomerName", A4CustomerName);
         A7CustomerTotalPurchases = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
         A20InvoiceLastLineId = 0 ;
         n20InvoiceLastLineId = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
         A16InvoiceAmount = 0 ;
         n16InvoiceAmount = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
         A15InvoiceDate = Gx_date ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15InvoiceDate", context.localUtil.Format(A15InvoiceDate, "99/99/99"));
         O20InvoiceLastLineId = A20InvoiceLastLineId ;
         n20InvoiceLastLineId = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
         O16InvoiceAmount = A16InvoiceAmount ;
         n16InvoiceAmount = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
      }

      protected void InitAll044( )
      {
         A14InvoiceId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14InvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14InvoiceId), 6, 0)));
         InitializeNonKey044( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A15InvoiceDate = i15InvoiceDate ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15InvoiceDate", context.localUtil.Format(A15InvoiceDate, "99/99/99"));
      }

      protected void InitializeNonKey045( )
      {
         A19InvoiceDetailAmount = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19InvoiceDetailAmount", StringUtil.LTrim( StringUtil.Str( A19InvoiceDetailAmount, 9, 2)));
         A12ProductStock = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12ProductStock", StringUtil.LTrim( StringUtil.Str( (decimal)(A12ProductStock), 4, 0)));
         A10ProductId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10ProductId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10ProductId), 6, 0)));
         A11ProductDescription = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11ProductDescription", A11ProductDescription);
         A13ProductPrice = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ProductPrice", StringUtil.LTrim( StringUtil.Str( A13ProductPrice, 9, 2)));
         A18InvoiceDetailQuantiity = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18InvoiceDetailQuantiity", StringUtil.LTrim( StringUtil.Str( (decimal)(A18InvoiceDetailQuantiity), 3, 0)));
         O12ProductStock = A12ProductStock ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12ProductStock", StringUtil.LTrim( StringUtil.Str( (decimal)(A12ProductStock), 4, 0)));
         O19InvoiceDetailAmount = A19InvoiceDetailAmount ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19InvoiceDetailAmount", StringUtil.LTrim( StringUtil.Str( A19InvoiceDetailAmount, 9, 2)));
      }

      protected void InitAll045( )
      {
         A17InvoiceDetailId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17InvoiceDetailId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17InvoiceDetailId), 2, 0)));
         InitializeNonKey045( ) ;
      }

      protected void StandaloneModalInsert045( )
      {
         A20InvoiceLastLineId = i20InvoiceLastLineId ;
         n20InvoiceLastLineId = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?1042300");
         AddThemeStyleSheetFile("", "GeneXusX.css", "?1401355");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?17252697");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.eng.js", "?46473");
         context.AddJavascriptSource("invoice.js", "?17252698");
         /* End function include_jscripts */
      }

      protected void init_level_properties5( )
      {
         edtInvoiceDetailId_Enabled = defedtInvoiceDetailId_Enabled ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvoiceDetailId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvoiceDetailId_Enabled), 5, 0)));
      }

      protected void init_default_properties( )
      {
         imgBtn_first_Internalname = "BTN_FIRST" ;
         imgBtn_first_separator_Internalname = "BTN_FIRST_SEPARATOR" ;
         imgBtn_previous_Internalname = "BTN_PREVIOUS" ;
         imgBtn_previous_separator_Internalname = "BTN_PREVIOUS_SEPARATOR" ;
         imgBtn_next_Internalname = "BTN_NEXT" ;
         imgBtn_next_separator_Internalname = "BTN_NEXT_SEPARATOR" ;
         imgBtn_last_Internalname = "BTN_LAST" ;
         imgBtn_last_separator_Internalname = "BTN_LAST_SEPARATOR" ;
         imgBtn_select_Internalname = "BTN_SELECT" ;
         imgBtn_select_separator_Internalname = "BTN_SELECT_SEPARATOR" ;
         imgBtn_enter2_Internalname = "BTN_ENTER2" ;
         imgBtn_enter2_separator_Internalname = "BTN_ENTER2_SEPARATOR" ;
         imgBtn_cancel2_Internalname = "BTN_CANCEL2" ;
         imgBtn_cancel2_separator_Internalname = "BTN_CANCEL2_SEPARATOR" ;
         imgBtn_delete2_Internalname = "BTN_DELETE2" ;
         imgBtn_delete2_separator_Internalname = "BTN_DELETE2_SEPARATOR" ;
         tblTabletoolbar_Internalname = "TABLETOOLBAR" ;
         lblTextblockinvoiceid_Internalname = "TEXTBLOCKINVOICEID" ;
         edtInvoiceId_Internalname = "INVOICEID" ;
         lblTextblockinvoicedate_Internalname = "TEXTBLOCKINVOICEDATE" ;
         edtInvoiceDate_Internalname = "INVOICEDATE" ;
         lblTextblockcustomerid_Internalname = "TEXTBLOCKCUSTOMERID" ;
         edtCustomerId_Internalname = "CUSTOMERID" ;
         lblTextblockcustomername_Internalname = "TEXTBLOCKCUSTOMERNAME" ;
         edtCustomerName_Internalname = "CUSTOMERNAME" ;
         lblTextblockcustomertotalpurchases_Internalname = "TEXTBLOCKCUSTOMERTOTALPURCHASES" ;
         edtCustomerTotalPurchases_Internalname = "CUSTOMERTOTALPURCHASES" ;
         lblTitledetail_Internalname = "TITLEDETAIL" ;
         tblTable3_Internalname = "TABLE3" ;
         lblTextblockinvoiceamount_Internalname = "TEXTBLOCKINVOICEAMOUNT" ;
         edtInvoiceAmount_Internalname = "INVOICEAMOUNT" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_3_Internalname = "PROMPT_3" ;
         subGridinvoice_detail_Internalname = "GRIDINVOICE_DETAIL" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Invoice" ;
         edtInvoiceDetailAmount_Jsonclick = "" ;
         edtInvoiceDetailQuantiity_Jsonclick = "" ;
         edtProductPrice_Jsonclick = "" ;
         edtProductDescription_Jsonclick = "" ;
         imgprompt_10_Visible = 1 ;
         imgprompt_10_Link = "" ;
         imgprompt_3_Visible = 1 ;
         edtProductId_Jsonclick = "" ;
         edtInvoiceDetailId_Jsonclick = "" ;
         subGridinvoice_detail_Class = "Grid" ;
         imgBtn_delete2_separator_Visible = 1 ;
         imgBtn_delete2_Enabled = 1 ;
         imgBtn_delete2_Visible = 1 ;
         imgBtn_cancel2_separator_Visible = 1 ;
         imgBtn_cancel2_Visible = 1 ;
         imgBtn_enter2_separator_Visible = 1 ;
         imgBtn_enter2_Enabled = 1 ;
         imgBtn_enter2_Visible = 1 ;
         imgBtn_select_separator_Visible = 1 ;
         imgBtn_select_Visible = 1 ;
         imgBtn_last_separator_Visible = 1 ;
         imgBtn_last_Visible = 1 ;
         imgBtn_next_separator_Visible = 1 ;
         imgBtn_next_Visible = 1 ;
         imgBtn_previous_separator_Visible = 1 ;
         imgBtn_previous_Visible = 1 ;
         imgBtn_first_separator_Visible = 1 ;
         imgBtn_first_Visible = 1 ;
         edtInvoiceAmount_Jsonclick = "" ;
         edtInvoiceAmount_Enabled = 0 ;
         edtInvoiceDetailAmount_Enabled = 0 ;
         edtInvoiceDetailQuantiity_Enabled = 1 ;
         edtProductPrice_Enabled = 0 ;
         edtProductDescription_Enabled = 0 ;
         edtProductId_Enabled = 1 ;
         edtInvoiceDetailId_Enabled = 1 ;
         subGridinvoice_detail_Backcolorstyle = 2 ;
         edtCustomerTotalPurchases_Jsonclick = "" ;
         edtCustomerTotalPurchases_Enabled = 0 ;
         edtCustomerName_Jsonclick = "" ;
         edtCustomerName_Enabled = 0 ;
         imgprompt_3_Visible = 1 ;
         imgprompt_3_Link = "" ;
         edtCustomerId_Jsonclick = "" ;
         edtCustomerId_Enabled = 1 ;
         edtInvoiceDate_Jsonclick = "" ;
         edtInvoiceDate_Enabled = 1 ;
         edtInvoiceId_Jsonclick = "" ;
         edtInvoiceId_Enabled = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGridinvoice_detail_newrow( short nRC_Gridinvoice_detail ,
                                                    short nGXsfl_65_idx ,
                                                    String sGXsfl_65_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         edtInvoiceDetailId_Internalname = "INVOICEDETAILID_"+sGXsfl_65_idx ;
         edtProductId_Internalname = "PRODUCTID_"+sGXsfl_65_idx ;
         imgprompt_10_Internalname = "PROMPT_10_"+sGXsfl_65_idx ;
         edtProductDescription_Internalname = "PRODUCTDESCRIPTION_"+sGXsfl_65_idx ;
         edtProductPrice_Internalname = "PRODUCTPRICE_"+sGXsfl_65_idx ;
         edtInvoiceDetailQuantiity_Internalname = "INVOICEDETAILQUANTIITY_"+sGXsfl_65_idx ;
         edtInvoiceDetailAmount_Internalname = "INVOICEDETAILAMOUNT_"+sGXsfl_65_idx ;
         while ( nGXsfl_65_idx <= nRC_Gridinvoice_detail )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal045( ) ;
            standaloneModal045( ) ;
            dynload_actions( ) ;
            SendRow045( ) ;
            nGXsfl_65_idx = (short)(nGXsfl_65_idx+1) ;
            sGXsfl_65_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_65_idx), 4, 0)), 4, "0") ;
            edtInvoiceDetailId_Internalname = "INVOICEDETAILID_"+sGXsfl_65_idx ;
            edtProductId_Internalname = "PRODUCTID_"+sGXsfl_65_idx ;
            imgprompt_10_Internalname = "PROMPT_10_"+sGXsfl_65_idx ;
            edtProductDescription_Internalname = "PRODUCTDESCRIPTION_"+sGXsfl_65_idx ;
            edtProductPrice_Internalname = "PRODUCTPRICE_"+sGXsfl_65_idx ;
            edtInvoiceDetailQuantiity_Internalname = "INVOICEDETAILQUANTIITY_"+sGXsfl_65_idx ;
            edtInvoiceDetailAmount_Internalname = "INVOICEDETAILAMOUNT_"+sGXsfl_65_idx ;
         }
         context.GX_webresponse.AddString(Gridinvoice_detailContainer.ToJavascriptSource());
         /* End function gxnrGridinvoice_detail_newrow */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         GX_FocusControl = edtInvoiceDate_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Invoiceid( int GX_Parm1 ,
                                   DateTime GX_Parm2 ,
                                   int GX_Parm3 ,
                                   short GX_Parm4 ,
                                   decimal GX_Parm5 )
      {
         A14InvoiceId = GX_Parm1 ;
         A15InvoiceDate = GX_Parm2 ;
         A3CustomerId = GX_Parm3 ;
         A20InvoiceLastLineId = GX_Parm4 ;
         n20InvoiceLastLineId = false ;
         A16InvoiceAmount = GX_Parm5 ;
         n16InvoiceAmount = false ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         /* Using cursor T000430 */
         pr_default.execute(21, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(21) != 101) )
         {
            A20InvoiceLastLineId = T000430_A20InvoiceLastLineId[0] ;
            n20InvoiceLastLineId = T000430_n20InvoiceLastLineId[0] ;
         }
         else
         {
            A20InvoiceLastLineId = 0 ;
            n20InvoiceLastLineId = false ;
         }
         pr_default.close(21);
         /* Using cursor T000432 */
         pr_default.execute(22, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(22) != 101) )
         {
            A16InvoiceAmount = T000432_A16InvoiceAmount[0] ;
            n16InvoiceAmount = T000432_n16InvoiceAmount[0] ;
         }
         else
         {
            A16InvoiceAmount = 0 ;
            n16InvoiceAmount = false ;
         }
         pr_default.close(22);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A20InvoiceLastLineId = 0 ;
            n20InvoiceLastLineId = false ;
            A16InvoiceAmount = 0 ;
            n16InvoiceAmount = false ;
            A4CustomerName = "" ;
            A7CustomerTotalPurchases = 0 ;
         }
         isValidOutput.Add((Object)(context.localUtil.Format(A15InvoiceDate, "99/99/99")));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A3CustomerId), 6, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A20InvoiceLastLineId), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A16InvoiceAmount, 9, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A4CustomerName)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A7CustomerTotalPurchases, 9, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z14InvoiceId), 6, 0, ".", ""))));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z15InvoiceDate, 0, "/")));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z3CustomerId), 6, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z20InvoiceLastLineId), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z16InvoiceAmount, 9, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z4CustomerName)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z7CustomerTotalPurchases, 9, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(O20InvoiceLastLineId), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( O16InvoiceAmount, 9, 2, ".", ""))));
         isValidOutput.Add((Object)(Gridinvoice_detailContainer));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Customerid( int GX_Parm1 ,
                                    String GX_Parm2 ,
                                    decimal GX_Parm3 )
      {
         A3CustomerId = GX_Parm1 ;
         A4CustomerName = GX_Parm2 ;
         A7CustomerTotalPurchases = GX_Parm3 ;
         /* Using cursor T000433 */
         pr_default.execute(23, new Object[] {A3CustomerId});
         if ( (pr_default.getStatus(23) == 101) )
         {
            GX_msglist.addItem("No matching 'Customer'.", "ForeignKeyNotFound", 1, "CUSTOMERID");
            AnyError = 1 ;
            GX_FocusControl = edtCustomerId_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A4CustomerName = T000433_A4CustomerName[0] ;
            A7CustomerTotalPurchases = T000433_A7CustomerTotalPurchases[0] ;
         }
         pr_default.close(23);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A4CustomerName = "" ;
            A7CustomerTotalPurchases = 0 ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A4CustomerName)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A7CustomerTotalPurchases, 9, 2, ".", ""))));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Productid( int GX_Parm1 ,
                                   short GX_Parm2 ,
                                   String GX_Parm3 ,
                                   decimal GX_Parm4 )
      {
         A10ProductId = GX_Parm1 ;
         A12ProductStock = GX_Parm2 ;
         A11ProductDescription = GX_Parm3 ;
         A13ProductPrice = GX_Parm4 ;
         /* Using cursor T000441 */
         pr_default.execute(31, new Object[] {A10ProductId});
         Z11ProductDescription = T000441_A11ProductDescription[0] ;
         Z13ProductPrice = T000441_A13ProductPrice[0] ;
         if ( (pr_default.getStatus(31) == 101) )
         {
            GX_msglist.addItem("No matching 'Product'.", "ForeignKeyNotFound", 1, "PRODUCTID");
            AnyError = 1 ;
            GX_FocusControl = edtProductId_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A12ProductStock = T000441_A12ProductStock[0] ;
            A11ProductDescription = T000441_A11ProductDescription[0] ;
            A13ProductPrice = T000441_A13ProductPrice[0] ;
            O12ProductStock = A12ProductStock ;
         }
         pr_default.close(31);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A12ProductStock = 0 ;
            A11ProductDescription = "" ;
            A13ProductPrice = 0 ;
         }
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(O12ProductStock), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A12ProductStock), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A11ProductDescription)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A13ProductPrice, 9, 2, ".", ""))));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(33);
         pr_default.close(31);
         pr_default.close(24);
         pr_default.close(15);
         pr_default.close(14);
         pr_default.close(23);
         pr_default.close(21);
         pr_default.close(22);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Form = new GXWebForm();
         GX_FocusControl = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         TempTags = "" ;
         bttBtn_enter_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         bttBtn_delete_Jsonclick = "" ;
         lblTextblockinvoiceid_Jsonclick = "" ;
         lblTextblockinvoicedate_Jsonclick = "" ;
         A15InvoiceDate = DateTime.MinValue ;
         lblTextblockcustomerid_Jsonclick = "" ;
         lblTextblockcustomername_Jsonclick = "" ;
         A4CustomerName = "" ;
         lblTextblockcustomertotalpurchases_Jsonclick = "" ;
         Gridinvoice_detailContainer = new GXWebGrid( context);
         Gridinvoice_detailColumn = new GXWebColumn();
         A11ProductDescription = "" ;
         Gx_mode = "" ;
         sMode5 = "" ;
         edtInvoiceDetailId_Internalname = "" ;
         edtProductId_Internalname = "" ;
         edtProductDescription_Internalname = "" ;
         edtProductPrice_Internalname = "" ;
         edtInvoiceDetailQuantiity_Internalname = "" ;
         edtInvoiceDetailAmount_Internalname = "" ;
         lblTextblockinvoiceamount_Jsonclick = "" ;
         lblTitledetail_Jsonclick = "" ;
         imgBtn_first_Jsonclick = "" ;
         imgBtn_first_separator_Jsonclick = "" ;
         imgBtn_previous_Jsonclick = "" ;
         imgBtn_previous_separator_Jsonclick = "" ;
         imgBtn_next_Jsonclick = "" ;
         imgBtn_next_separator_Jsonclick = "" ;
         imgBtn_last_Jsonclick = "" ;
         imgBtn_last_separator_Jsonclick = "" ;
         imgBtn_select_Jsonclick = "" ;
         imgBtn_select_separator_Jsonclick = "" ;
         imgBtn_enter2_Jsonclick = "" ;
         imgBtn_enter2_separator_Jsonclick = "" ;
         imgBtn_cancel2_Jsonclick = "" ;
         imgBtn_cancel2_separator_Jsonclick = "" ;
         imgBtn_delete2_Jsonclick = "" ;
         imgBtn_delete2_separator_Jsonclick = "" ;
         Z15InvoiceDate = DateTime.MinValue ;
         Gx_date = DateTime.MinValue ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         Z11ProductDescription = "" ;
         Z4CustomerName = "" ;
         T000415_A14InvoiceId = new int[1] ;
         T000415_A15InvoiceDate = new DateTime[] {DateTime.MinValue} ;
         T000415_A4CustomerName = new String[] {""} ;
         T000415_A7CustomerTotalPurchases = new decimal[1] ;
         T000415_A3CustomerId = new int[1] ;
         T000415_A20InvoiceLastLineId = new short[1] ;
         T000415_n20InvoiceLastLineId = new bool[] {false} ;
         T000415_A16InvoiceAmount = new decimal[1] ;
         T000415_n16InvoiceAmount = new bool[] {false} ;
         T000410_A20InvoiceLastLineId = new short[1] ;
         T000410_n20InvoiceLastLineId = new bool[] {false} ;
         T000412_A16InvoiceAmount = new decimal[1] ;
         T000412_n16InvoiceAmount = new bool[] {false} ;
         T00048_A4CustomerName = new String[] {""} ;
         T00048_A7CustomerTotalPurchases = new decimal[1] ;
         T000417_A20InvoiceLastLineId = new short[1] ;
         T000417_n20InvoiceLastLineId = new bool[] {false} ;
         T000419_A16InvoiceAmount = new decimal[1] ;
         T000419_n16InvoiceAmount = new bool[] {false} ;
         T000420_A4CustomerName = new String[] {""} ;
         T000420_A7CustomerTotalPurchases = new decimal[1] ;
         T000421_A14InvoiceId = new int[1] ;
         T00047_A14InvoiceId = new int[1] ;
         T00047_A15InvoiceDate = new DateTime[] {DateTime.MinValue} ;
         T00047_A3CustomerId = new int[1] ;
         sMode4 = "" ;
         T000422_A14InvoiceId = new int[1] ;
         T000423_A14InvoiceId = new int[1] ;
         T000424_A14InvoiceId = new int[1] ;
         T000424_A15InvoiceDate = new DateTime[] {DateTime.MinValue} ;
         T000424_A3CustomerId = new int[1] ;
         T000426_A14InvoiceId = new int[1] ;
         T000430_A20InvoiceLastLineId = new short[1] ;
         T000430_n20InvoiceLastLineId = new bool[] {false} ;
         T000432_A16InvoiceAmount = new decimal[1] ;
         T000432_n16InvoiceAmount = new bool[] {false} ;
         T000433_A4CustomerName = new String[] {""} ;
         T000433_A7CustomerTotalPurchases = new decimal[1] ;
         T000434_A14InvoiceId = new int[1] ;
         T000435_A14InvoiceId = new int[1] ;
         T000435_A17InvoiceDetailId = new short[1] ;
         T000435_A12ProductStock = new short[1] ;
         T000435_A11ProductDescription = new String[] {""} ;
         T000435_A13ProductPrice = new decimal[1] ;
         T000435_A18InvoiceDetailQuantiity = new short[1] ;
         T000435_A10ProductId = new int[1] ;
         T00045_A12ProductStock = new short[1] ;
         T00045_A11ProductDescription = new String[] {""} ;
         T00045_A13ProductPrice = new decimal[1] ;
         T000436_A12ProductStock = new short[1] ;
         T000436_A11ProductDescription = new String[] {""} ;
         T000436_A13ProductPrice = new decimal[1] ;
         T000437_A14InvoiceId = new int[1] ;
         T000437_A17InvoiceDetailId = new short[1] ;
         T00043_A14InvoiceId = new int[1] ;
         T00043_A17InvoiceDetailId = new short[1] ;
         T00043_A18InvoiceDetailQuantiity = new short[1] ;
         T00043_A10ProductId = new int[1] ;
         T00042_A14InvoiceId = new int[1] ;
         T00042_A17InvoiceDetailId = new short[1] ;
         T00042_A18InvoiceDetailQuantiity = new short[1] ;
         T00042_A10ProductId = new int[1] ;
         T00044_A12ProductStock = new short[1] ;
         T00044_A11ProductDescription = new String[] {""} ;
         T00044_A13ProductPrice = new decimal[1] ;
         T000441_A12ProductStock = new short[1] ;
         T000441_A11ProductDescription = new String[] {""} ;
         T000441_A13ProductPrice = new decimal[1] ;
         T000443_A14InvoiceId = new int[1] ;
         T000443_A17InvoiceDetailId = new short[1] ;
         imgprompt_10_Internalname = "" ;
         Gridinvoice_detailRow = new GXWebRow();
         subGridinvoice_detail_Linesclass = "" ;
         ROClassString = "" ;
         GXCCtl = "" ;
         GXt_char10 = "" ;
         GXt_char9 = "" ;
         GXt_char8 = "" ;
         GXt_char7 = "" ;
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         GXt_char4 = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char11 = "" ;
         GXt_char12 = "" ;
         GXt_char13 = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char15 = "" ;
         GXt_char14 = "" ;
         i15InvoiceDate = DateTime.MinValue ;
         GXt_char16 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.invoice__default(),
            new Object[][] {
                new Object[] {
               T00042_A14InvoiceId, T00042_A17InvoiceDetailId, T00042_A18InvoiceDetailQuantiity, T00042_A10ProductId
               }
               , new Object[] {
               T00043_A14InvoiceId, T00043_A17InvoiceDetailId, T00043_A18InvoiceDetailQuantiity, T00043_A10ProductId
               }
               , new Object[] {
               T00044_A12ProductStock, T00044_A11ProductDescription, T00044_A13ProductPrice
               }
               , new Object[] {
               T00045_A12ProductStock, T00045_A11ProductDescription, T00045_A13ProductPrice
               }
               , new Object[] {
               T00046_A14InvoiceId, T00046_A15InvoiceDate, T00046_A3CustomerId
               }
               , new Object[] {
               T00047_A14InvoiceId, T00047_A15InvoiceDate, T00047_A3CustomerId
               }
               , new Object[] {
               T00048_A4CustomerName, T00048_A7CustomerTotalPurchases
               }
               , new Object[] {
               T000410_A20InvoiceLastLineId, T000410_n20InvoiceLastLineId
               }
               , new Object[] {
               T000412_A16InvoiceAmount, T000412_n16InvoiceAmount
               }
               , new Object[] {
               T000415_A14InvoiceId, T000415_A15InvoiceDate, T000415_A4CustomerName, T000415_A7CustomerTotalPurchases, T000415_A3CustomerId, T000415_A20InvoiceLastLineId, T000415_n20InvoiceLastLineId, T000415_A16InvoiceAmount, T000415_n16InvoiceAmount
               }
               , new Object[] {
               T000417_A20InvoiceLastLineId, T000417_n20InvoiceLastLineId
               }
               , new Object[] {
               T000419_A16InvoiceAmount, T000419_n16InvoiceAmount
               }
               , new Object[] {
               T000420_A4CustomerName, T000420_A7CustomerTotalPurchases
               }
               , new Object[] {
               T000421_A14InvoiceId
               }
               , new Object[] {
               T000422_A14InvoiceId
               }
               , new Object[] {
               T000423_A14InvoiceId
               }
               , new Object[] {
               T000424_A14InvoiceId, T000424_A15InvoiceDate, T000424_A3CustomerId
               }
               , new Object[] {
               }
               , new Object[] {
               T000426_A14InvoiceId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000430_A20InvoiceLastLineId, T000430_n20InvoiceLastLineId
               }
               , new Object[] {
               T000432_A16InvoiceAmount, T000432_n16InvoiceAmount
               }
               , new Object[] {
               T000433_A4CustomerName, T000433_A7CustomerTotalPurchases
               }
               , new Object[] {
               T000434_A14InvoiceId
               }
               , new Object[] {
               T000435_A14InvoiceId, T000435_A17InvoiceDetailId, T000435_A12ProductStock, T000435_A11ProductDescription, T000435_A13ProductPrice, T000435_A18InvoiceDetailQuantiity, T000435_A10ProductId
               }
               , new Object[] {
               T000436_A12ProductStock, T000436_A11ProductDescription, T000436_A13ProductPrice
               }
               , new Object[] {
               T000437_A14InvoiceId, T000437_A17InvoiceDetailId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000441_A12ProductStock, T000441_A11ProductDescription, T000441_A13ProductPrice
               }
               , new Object[] {
               }
               , new Object[] {
               T000443_A14InvoiceId, T000443_A17InvoiceDetailId
               }
            }
         );
         A15InvoiceDate = Gx_date ;
         Gx_date = DateTimeUtil.Today( ) ;
      }

      private short nIsMod_5 ;
      private short RcdFound4 ;
      private short GxWebError ;
      private short nRC_Gridinvoice_detail ;
      private short nGXsfl_65_idx=1 ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short subGridinvoice_detail_Backcolorstyle ;
      private short A17InvoiceDetailId ;
      private short A18InvoiceDetailQuantiity ;
      private short subGridinvoice_detail_Collapsed ;
      private short nBlankRcdCount5 ;
      private short nRcdExists_5 ;
      private short RcdFound5 ;
      private short B20InvoiceLastLineId ;
      private short A20InvoiceLastLineId ;
      private short nBlankRcdUsr5 ;
      private short O20InvoiceLastLineId ;
      private short Gx_BScreen ;
      private short A12ProductStock ;
      private short s20InvoiceLastLineId ;
      private short nRcdDeleted_5 ;
      private short Z17InvoiceDetailId ;
      private short Z18InvoiceDetailQuantiity ;
      private short T12ProductStock ;
      private short O12ProductStock ;
      private short GX_JID ;
      private short Z20InvoiceLastLineId ;
      private short Z12ProductStock ;
      private short subGridinvoice_detail_Backstyle ;
      private short gxajaxcallmode ;
      private short i20InvoiceLastLineId ;
      private int A14InvoiceId ;
      private int A3CustomerId ;
      private int A10ProductId ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtInvoiceId_Enabled ;
      private int edtInvoiceDate_Enabled ;
      private int edtCustomerId_Enabled ;
      private int imgprompt_3_Visible ;
      private int edtCustomerName_Enabled ;
      private int edtCustomerTotalPurchases_Enabled ;
      private int edtInvoiceDetailId_Enabled ;
      private int edtProductId_Enabled ;
      private int edtProductDescription_Enabled ;
      private int edtProductPrice_Enabled ;
      private int edtInvoiceDetailQuantiity_Enabled ;
      private int edtInvoiceDetailAmount_Enabled ;
      private int fRowAdded ;
      private int edtInvoiceAmount_Enabled ;
      private int imgBtn_first_Visible ;
      private int imgBtn_first_separator_Visible ;
      private int imgBtn_previous_Visible ;
      private int imgBtn_previous_separator_Visible ;
      private int imgBtn_next_Visible ;
      private int imgBtn_next_separator_Visible ;
      private int imgBtn_last_Visible ;
      private int imgBtn_last_separator_Visible ;
      private int imgBtn_select_Visible ;
      private int imgBtn_select_separator_Visible ;
      private int imgBtn_enter2_Visible ;
      private int imgBtn_enter2_Enabled ;
      private int imgBtn_enter2_separator_Visible ;
      private int imgBtn_cancel2_Visible ;
      private int imgBtn_cancel2_separator_Visible ;
      private int imgBtn_delete2_Visible ;
      private int imgBtn_delete2_Enabled ;
      private int imgBtn_delete2_separator_Visible ;
      private int Z14InvoiceId ;
      private int Z3CustomerId ;
      private int GRIDINVOICE_DETAIL_nFirstRecordOnPage ;
      private int Z10ProductId ;
      private int subGridinvoice_detail_Backcolor ;
      private int subGridinvoice_detail_Allbackcolor ;
      private int imgprompt_10_Visible ;
      private int defedtInvoiceDetailId_Enabled ;
      private int idxLst ;
      private decimal A7CustomerTotalPurchases ;
      private decimal A13ProductPrice ;
      private decimal A19InvoiceDetailAmount ;
      private decimal B16InvoiceAmount ;
      private decimal A16InvoiceAmount ;
      private decimal O16InvoiceAmount ;
      private decimal s16InvoiceAmount ;
      private decimal Z13ProductPrice ;
      private decimal T19InvoiceDetailAmount ;
      private decimal O19InvoiceDetailAmount ;
      private decimal Z16InvoiceAmount ;
      private decimal Z7CustomerTotalPurchases ;
      private String sPrefix ;
      private String sGXsfl_65_idx="0001" ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtInvoiceId_Internalname ;
      private String sStyleString ;
      private String tblTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroupdata_Internalname ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockinvoiceid_Internalname ;
      private String lblTextblockinvoiceid_Jsonclick ;
      private String edtInvoiceId_Jsonclick ;
      private String lblTextblockinvoicedate_Internalname ;
      private String lblTextblockinvoicedate_Jsonclick ;
      private String edtInvoiceDate_Internalname ;
      private String edtInvoiceDate_Jsonclick ;
      private String lblTextblockcustomerid_Internalname ;
      private String lblTextblockcustomerid_Jsonclick ;
      private String edtCustomerId_Internalname ;
      private String edtCustomerId_Jsonclick ;
      private String imgprompt_3_Internalname ;
      private String imgprompt_3_Link ;
      private String lblTextblockcustomername_Internalname ;
      private String lblTextblockcustomername_Jsonclick ;
      private String edtCustomerName_Internalname ;
      private String A4CustomerName ;
      private String edtCustomerName_Jsonclick ;
      private String lblTextblockcustomertotalpurchases_Internalname ;
      private String lblTextblockcustomertotalpurchases_Jsonclick ;
      private String edtCustomerTotalPurchases_Internalname ;
      private String edtCustomerTotalPurchases_Jsonclick ;
      private String A11ProductDescription ;
      private String Gx_mode ;
      private String sMode5 ;
      private String edtInvoiceDetailId_Internalname ;
      private String edtProductId_Internalname ;
      private String edtProductDescription_Internalname ;
      private String edtProductPrice_Internalname ;
      private String edtInvoiceDetailQuantiity_Internalname ;
      private String edtInvoiceDetailAmount_Internalname ;
      private String lblTextblockinvoiceamount_Internalname ;
      private String lblTextblockinvoiceamount_Jsonclick ;
      private String edtInvoiceAmount_Internalname ;
      private String edtInvoiceAmount_Jsonclick ;
      private String tblTable3_Internalname ;
      private String lblTitledetail_Internalname ;
      private String lblTitledetail_Jsonclick ;
      private String tblTabletoolbar_Internalname ;
      private String imgBtn_first_Internalname ;
      private String imgBtn_first_Jsonclick ;
      private String imgBtn_first_separator_Internalname ;
      private String imgBtn_first_separator_Jsonclick ;
      private String imgBtn_previous_Internalname ;
      private String imgBtn_previous_Jsonclick ;
      private String imgBtn_previous_separator_Internalname ;
      private String imgBtn_previous_separator_Jsonclick ;
      private String imgBtn_next_Internalname ;
      private String imgBtn_next_Jsonclick ;
      private String imgBtn_next_separator_Internalname ;
      private String imgBtn_next_separator_Jsonclick ;
      private String imgBtn_last_Internalname ;
      private String imgBtn_last_Jsonclick ;
      private String imgBtn_last_separator_Internalname ;
      private String imgBtn_last_separator_Jsonclick ;
      private String imgBtn_select_Internalname ;
      private String imgBtn_select_Jsonclick ;
      private String imgBtn_select_separator_Internalname ;
      private String imgBtn_select_separator_Jsonclick ;
      private String imgBtn_enter2_Internalname ;
      private String imgBtn_enter2_Jsonclick ;
      private String imgBtn_enter2_separator_Internalname ;
      private String imgBtn_enter2_separator_Jsonclick ;
      private String imgBtn_cancel2_Internalname ;
      private String imgBtn_cancel2_Jsonclick ;
      private String imgBtn_cancel2_separator_Internalname ;
      private String imgBtn_cancel2_separator_Jsonclick ;
      private String imgBtn_delete2_Internalname ;
      private String imgBtn_delete2_Jsonclick ;
      private String imgBtn_delete2_separator_Internalname ;
      private String imgBtn_delete2_separator_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z11ProductDescription ;
      private String Z4CustomerName ;
      private String sMode4 ;
      private String imgprompt_10_Internalname ;
      private String subGridinvoice_detail_Class ;
      private String subGridinvoice_detail_Linesclass ;
      private String imgprompt_10_Link ;
      private String ROClassString ;
      private String edtInvoiceDetailId_Jsonclick ;
      private String edtProductId_Jsonclick ;
      private String edtProductDescription_Jsonclick ;
      private String edtProductPrice_Jsonclick ;
      private String edtInvoiceDetailQuantiity_Jsonclick ;
      private String edtInvoiceDetailAmount_Jsonclick ;
      private String GXCCtl ;
      private String GXt_char10 ;
      private String GXt_char9 ;
      private String GXt_char8 ;
      private String GXt_char7 ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char11 ;
      private String GXt_char12 ;
      private String GXt_char13 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char15 ;
      private String GXt_char14 ;
      private String subGridinvoice_detail_Internalname ;
      private String GXt_char16 ;
      private DateTime A15InvoiceDate ;
      private DateTime Z15InvoiceDate ;
      private DateTime Gx_date ;
      private DateTime i15InvoiceDate ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool n20InvoiceLastLineId ;
      private bool n16InvoiceAmount ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Gridinvoice_detailContainer ;
      private GXWebRow Gridinvoice_detailRow ;
      private GXWebColumn Gridinvoice_detailColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] T000415_A14InvoiceId ;
      private DateTime[] T000415_A15InvoiceDate ;
      private String[] T000415_A4CustomerName ;
      private decimal[] T000415_A7CustomerTotalPurchases ;
      private int[] T000415_A3CustomerId ;
      private short[] T000415_A20InvoiceLastLineId ;
      private bool[] T000415_n20InvoiceLastLineId ;
      private decimal[] T000415_A16InvoiceAmount ;
      private bool[] T000415_n16InvoiceAmount ;
      private short[] T000410_A20InvoiceLastLineId ;
      private bool[] T000410_n20InvoiceLastLineId ;
      private decimal[] T000412_A16InvoiceAmount ;
      private bool[] T000412_n16InvoiceAmount ;
      private String[] T00048_A4CustomerName ;
      private decimal[] T00048_A7CustomerTotalPurchases ;
      private short[] T000417_A20InvoiceLastLineId ;
      private bool[] T000417_n20InvoiceLastLineId ;
      private decimal[] T000419_A16InvoiceAmount ;
      private bool[] T000419_n16InvoiceAmount ;
      private String[] T000420_A4CustomerName ;
      private decimal[] T000420_A7CustomerTotalPurchases ;
      private int[] T000421_A14InvoiceId ;
      private int[] T00047_A14InvoiceId ;
      private DateTime[] T00047_A15InvoiceDate ;
      private int[] T00047_A3CustomerId ;
      private int[] T000422_A14InvoiceId ;
      private int[] T000423_A14InvoiceId ;
      private int[] T000424_A14InvoiceId ;
      private DateTime[] T000424_A15InvoiceDate ;
      private int[] T000424_A3CustomerId ;
      private int[] T000426_A14InvoiceId ;
      private short[] T000430_A20InvoiceLastLineId ;
      private bool[] T000430_n20InvoiceLastLineId ;
      private decimal[] T000432_A16InvoiceAmount ;
      private bool[] T000432_n16InvoiceAmount ;
      private String[] T000433_A4CustomerName ;
      private decimal[] T000433_A7CustomerTotalPurchases ;
      private int[] T000434_A14InvoiceId ;
      private int[] T000435_A14InvoiceId ;
      private short[] T000435_A17InvoiceDetailId ;
      private short[] T000435_A12ProductStock ;
      private String[] T000435_A11ProductDescription ;
      private decimal[] T000435_A13ProductPrice ;
      private short[] T000435_A18InvoiceDetailQuantiity ;
      private int[] T000435_A10ProductId ;
      private short[] T00045_A12ProductStock ;
      private String[] T00045_A11ProductDescription ;
      private decimal[] T00045_A13ProductPrice ;
      private short[] T000436_A12ProductStock ;
      private String[] T000436_A11ProductDescription ;
      private decimal[] T000436_A13ProductPrice ;
      private int[] T000437_A14InvoiceId ;
      private short[] T000437_A17InvoiceDetailId ;
      private int[] T00043_A14InvoiceId ;
      private short[] T00043_A17InvoiceDetailId ;
      private short[] T00043_A18InvoiceDetailQuantiity ;
      private int[] T00043_A10ProductId ;
      private int[] T00042_A14InvoiceId ;
      private short[] T00042_A17InvoiceDetailId ;
      private short[] T00042_A18InvoiceDetailQuantiity ;
      private int[] T00042_A10ProductId ;
      private short[] T00044_A12ProductStock ;
      private String[] T00044_A11ProductDescription ;
      private decimal[] T00044_A13ProductPrice ;
      private short[] T000441_A12ProductStock ;
      private String[] T000441_A11ProductDescription ;
      private decimal[] T000441_A13ProductPrice ;
      private int[] T000443_A14InvoiceId ;
      private short[] T000443_A17InvoiceDetailId ;
      private int[] T00046_A14InvoiceId ;
      private DateTime[] T00046_A15InvoiceDate ;
      private int[] T00046_A3CustomerId ;
      private GXWebForm Form ;
   }

   public class invoice__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new UpdateCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new UpdateCursor(def[19])
         ,new UpdateCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
         ,new ForEachCursor(def[24])
         ,new ForEachCursor(def[25])
         ,new ForEachCursor(def[26])
         ,new ForEachCursor(def[27])
         ,new UpdateCursor(def[28])
         ,new UpdateCursor(def[29])
         ,new UpdateCursor(def[30])
         ,new ForEachCursor(def[31])
         ,new UpdateCursor(def[32])
         ,new ForEachCursor(def[33])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00046 ;
          prmT00046 = new Object[] {
          new Object[] {"@InvoiceId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000415 ;
          prmT000415 = new Object[] {
          new Object[] {"@InvoiceId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000410 ;
          prmT000410 = new Object[] {
          new Object[] {"@InvoiceId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000412 ;
          prmT000412 = new Object[] {
          new Object[] {"@InvoiceId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT00048 ;
          prmT00048 = new Object[] {
          new Object[] {"@CustomerId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000417 ;
          prmT000417 = new Object[] {
          new Object[] {"@InvoiceId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000419 ;
          prmT000419 = new Object[] {
          new Object[] {"@InvoiceId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000420 ;
          prmT000420 = new Object[] {
          new Object[] {"@CustomerId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000421 ;
          prmT000421 = new Object[] {
          new Object[] {"@InvoiceId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT00047 ;
          prmT00047 = new Object[] {
          new Object[] {"@InvoiceId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000422 ;
          prmT000422 = new Object[] {
          new Object[] {"@InvoiceId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000423 ;
          prmT000423 = new Object[] {
          new Object[] {"@InvoiceId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000424 ;
          prmT000424 = new Object[] {
          new Object[] {"@InvoiceId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000425 ;
          prmT000425 = new Object[] {
          new Object[] {"@InvoiceDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@CustomerId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000426 ;
          prmT000426 = new Object[] {
          } ;
          Object[] prmT000427 ;
          prmT000427 = new Object[] {
          new Object[] {"@InvoiceDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@CustomerId",SqlDbType.Int,6,0} ,
          new Object[] {"@InvoiceId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000428 ;
          prmT000428 = new Object[] {
          new Object[] {"@InvoiceId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000434 ;
          prmT000434 = new Object[] {
          } ;
          Object[] prmT000435 ;
          prmT000435 = new Object[] {
          new Object[] {"@InvoiceId",SqlDbType.Int,6,0} ,
          new Object[] {"@InvoiceDetailId",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmT00045 ;
          prmT00045 = new Object[] {
          new Object[] {"@ProductId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000436 ;
          prmT000436 = new Object[] {
          new Object[] {"@ProductId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000437 ;
          prmT000437 = new Object[] {
          new Object[] {"@InvoiceId",SqlDbType.Int,6,0} ,
          new Object[] {"@InvoiceDetailId",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmT00043 ;
          prmT00043 = new Object[] {
          new Object[] {"@InvoiceId",SqlDbType.Int,6,0} ,
          new Object[] {"@InvoiceDetailId",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmT00042 ;
          prmT00042 = new Object[] {
          new Object[] {"@InvoiceId",SqlDbType.Int,6,0} ,
          new Object[] {"@InvoiceDetailId",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmT00044 ;
          prmT00044 = new Object[] {
          new Object[] {"@ProductId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000438 ;
          prmT000438 = new Object[] {
          new Object[] {"@InvoiceId",SqlDbType.Int,6,0} ,
          new Object[] {"@InvoiceDetailId",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@InvoiceDetailQuantiity",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@ProductId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000439 ;
          prmT000439 = new Object[] {
          new Object[] {"@InvoiceDetailQuantiity",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@ProductId",SqlDbType.Int,6,0} ,
          new Object[] {"@InvoiceId",SqlDbType.Int,6,0} ,
          new Object[] {"@InvoiceDetailId",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmT000440 ;
          prmT000440 = new Object[] {
          new Object[] {"@InvoiceId",SqlDbType.Int,6,0} ,
          new Object[] {"@InvoiceDetailId",SqlDbType.SmallInt,2,0}
          } ;
          Object[] prmT000442 ;
          prmT000442 = new Object[] {
          new Object[] {"@ProductStock",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ProductId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000443 ;
          prmT000443 = new Object[] {
          new Object[] {"@InvoiceId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000430 ;
          prmT000430 = new Object[] {
          new Object[] {"@InvoiceId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000432 ;
          prmT000432 = new Object[] {
          new Object[] {"@InvoiceId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000433 ;
          prmT000433 = new Object[] {
          new Object[] {"@CustomerId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000441 ;
          prmT000441 = new Object[] {
          new Object[] {"@ProductId",SqlDbType.Int,6,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00042", "SELECT [InvoiceId], [InvoiceDetailId], [InvoiceDetailQuantiity], [ProductId] FROM [InvoiceDetail] WITH (UPDLOCK) WHERE [InvoiceId] = @InvoiceId AND [InvoiceDetailId] = @InvoiceDetailId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00042,1,0,true,false )
             ,new CursorDef("T00043", "SELECT [InvoiceId], [InvoiceDetailId], [InvoiceDetailQuantiity], [ProductId] FROM [InvoiceDetail] WITH (NOLOCK) WHERE [InvoiceId] = @InvoiceId AND [InvoiceDetailId] = @InvoiceDetailId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00043,1,0,true,false )
             ,new CursorDef("T00044", "SELECT [ProductStock], [ProductDescription], [ProductPrice] FROM [Product] WITH (UPDLOCK) WHERE [ProductId] = @ProductId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00044,1,0,true,false )
             ,new CursorDef("T00045", "SELECT [ProductStock], [ProductDescription], [ProductPrice] FROM [Product] WITH (NOLOCK) WHERE [ProductId] = @ProductId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00045,1,0,true,false )
             ,new CursorDef("T00046", "SELECT [InvoiceId], [InvoiceDate], [CustomerId] FROM [Invoice] WITH (UPDLOCK) WHERE [InvoiceId] = @InvoiceId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00046,1,0,true,false )
             ,new CursorDef("T00047", "SELECT [InvoiceId], [InvoiceDate], [CustomerId] FROM [Invoice] WITH (NOLOCK) WHERE [InvoiceId] = @InvoiceId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00047,1,0,true,false )
             ,new CursorDef("T00048", "SELECT [CustomerName], [CustomerTotalPurchases] FROM [Customer] WITH (NOLOCK) WHERE [CustomerId] = @CustomerId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00048,1,0,true,false )
             ,new CursorDef("T000410", "SELECT COALESCE( T1.[InvoiceLastLineId], 0) AS InvoiceLastLineId FROM (SELECT COUNT(*) AS InvoiceLastLineId, [InvoiceId] FROM [InvoiceDetail] WITH (UPDLOCK) GROUP BY [InvoiceId] ) T1 WHERE T1.[InvoiceId] = @InvoiceId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000410,1,0,true,false )
             ,new CursorDef("T000412", "SELECT COALESCE( T1.[InvoiceAmount], 0) AS InvoiceAmount FROM (SELECT SUM(T3.[ProductPrice] * CAST(T2.[InvoiceDetailQuantiity] AS decimal( 14, 5))) AS InvoiceAmount, T2.[InvoiceId] FROM ([InvoiceDetail] T2 WITH (UPDLOCK) INNER JOIN [Product] T3 WITH (UPDLOCK) ON T3.[ProductId] = T2.[ProductId]) GROUP BY T2.[InvoiceId] ) T1 WHERE T1.[InvoiceId] = @InvoiceId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000412,1,0,true,false )
             ,new CursorDef("T000415", "SELECT TM1.[InvoiceId], TM1.[InvoiceDate], T4.[CustomerName], T4.[CustomerTotalPurchases], TM1.[CustomerId], COALESCE( T2.[InvoiceLastLineId], 0) AS InvoiceLastLineId, COALESCE( T3.[InvoiceAmount], 0) AS InvoiceAmount FROM ((([Invoice] TM1 WITH (NOLOCK) LEFT JOIN (SELECT COUNT(*) AS InvoiceLastLineId, [InvoiceId] FROM [InvoiceDetail] WITH (NOLOCK) GROUP BY [InvoiceId] ) T2 ON T2.[InvoiceId] = TM1.[InvoiceId]) LEFT JOIN (SELECT SUM(T6.[ProductPrice] * CAST(T5.[InvoiceDetailQuantiity] AS decimal( 14, 5))) AS InvoiceAmount, T5.[InvoiceId] FROM ([InvoiceDetail] T5 WITH (NOLOCK) INNER JOIN [Product] T6 WITH (NOLOCK) ON T6.[ProductId] = T5.[ProductId]) GROUP BY T5.[InvoiceId] ) T3 ON T3.[InvoiceId] = TM1.[InvoiceId]) INNER JOIN [Customer] T4 WITH (NOLOCK) ON T4.[CustomerId] = TM1.[CustomerId]) WHERE TM1.[InvoiceId] = @InvoiceId ORDER BY TM1.[InvoiceId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000415,100,0,true,false )
             ,new CursorDef("T000417", "SELECT COALESCE( T1.[InvoiceLastLineId], 0) AS InvoiceLastLineId FROM (SELECT COUNT(*) AS InvoiceLastLineId, [InvoiceId] FROM [InvoiceDetail] WITH (UPDLOCK) GROUP BY [InvoiceId] ) T1 WHERE T1.[InvoiceId] = @InvoiceId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000417,1,0,true,false )
             ,new CursorDef("T000419", "SELECT COALESCE( T1.[InvoiceAmount], 0) AS InvoiceAmount FROM (SELECT SUM(T3.[ProductPrice] * CAST(T2.[InvoiceDetailQuantiity] AS decimal( 14, 5))) AS InvoiceAmount, T2.[InvoiceId] FROM ([InvoiceDetail] T2 WITH (UPDLOCK) INNER JOIN [Product] T3 WITH (UPDLOCK) ON T3.[ProductId] = T2.[ProductId]) GROUP BY T2.[InvoiceId] ) T1 WHERE T1.[InvoiceId] = @InvoiceId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000419,1,0,true,false )
             ,new CursorDef("T000420", "SELECT [CustomerName], [CustomerTotalPurchases] FROM [Customer] WITH (NOLOCK) WHERE [CustomerId] = @CustomerId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000420,1,0,true,false )
             ,new CursorDef("T000421", "SELECT [InvoiceId] FROM [Invoice] WITH (NOLOCK) WHERE [InvoiceId] = @InvoiceId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000421,1,0,true,false )
             ,new CursorDef("T000422", "SELECT TOP 1 [InvoiceId] FROM [Invoice] WITH (NOLOCK) WHERE ( [InvoiceId] > @InvoiceId) ORDER BY [InvoiceId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000422,1,0,true,true )
             ,new CursorDef("T000423", "SELECT TOP 1 [InvoiceId] FROM [Invoice] WITH (NOLOCK) WHERE ( [InvoiceId] < @InvoiceId) ORDER BY [InvoiceId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000423,1,0,true,true )
             ,new CursorDef("T000424", "SELECT [InvoiceId], [InvoiceDate], [CustomerId] FROM [Invoice] WITH (UPDLOCK) WHERE [InvoiceId] = @InvoiceId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000424,1,0,true,false )
             ,new CursorDef("T000425", "INSERT INTO [Invoice] ([InvoiceDate], [CustomerId]) VALUES (@InvoiceDate, @CustomerId)", GxErrorMask.GX_NOMASK,prmT000425)
             ,new CursorDef("T000426", "SELECT Ident_Current('[Invoice]') ",true, GxErrorMask.GX_NOMASK, false, this,prmT000426,1,0,true,false )
             ,new CursorDef("T000427", "UPDATE [Invoice] SET [InvoiceDate]=@InvoiceDate, [CustomerId]=@CustomerId  WHERE [InvoiceId] = @InvoiceId", GxErrorMask.GX_NOMASK,prmT000427)
             ,new CursorDef("T000428", "DELETE FROM [Invoice]  WHERE [InvoiceId] = @InvoiceId", GxErrorMask.GX_NOMASK,prmT000428)
             ,new CursorDef("T000430", "SELECT COALESCE( T1.[InvoiceLastLineId], 0) AS InvoiceLastLineId FROM (SELECT COUNT(*) AS InvoiceLastLineId, [InvoiceId] FROM [InvoiceDetail] WITH (UPDLOCK) GROUP BY [InvoiceId] ) T1 WHERE T1.[InvoiceId] = @InvoiceId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000430,1,0,true,false )
             ,new CursorDef("T000432", "SELECT COALESCE( T1.[InvoiceAmount], 0) AS InvoiceAmount FROM (SELECT SUM(T3.[ProductPrice] * CAST(T2.[InvoiceDetailQuantiity] AS decimal( 14, 5))) AS InvoiceAmount, T2.[InvoiceId] FROM ([InvoiceDetail] T2 WITH (UPDLOCK) INNER JOIN [Product] T3 WITH (UPDLOCK) ON T3.[ProductId] = T2.[ProductId]) GROUP BY T2.[InvoiceId] ) T1 WHERE T1.[InvoiceId] = @InvoiceId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000432,1,0,true,false )
             ,new CursorDef("T000433", "SELECT [CustomerName], [CustomerTotalPurchases] FROM [Customer] WITH (NOLOCK) WHERE [CustomerId] = @CustomerId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000433,1,0,true,false )
             ,new CursorDef("T000434", "SELECT [InvoiceId] FROM [Invoice] WITH (NOLOCK) ORDER BY [InvoiceId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000434,100,0,true,false )
             ,new CursorDef("T000435", "SELECT T1.[InvoiceId], T1.[InvoiceDetailId], T2.[ProductStock], T2.[ProductDescription], T2.[ProductPrice], T1.[InvoiceDetailQuantiity], T1.[ProductId] FROM ([InvoiceDetail] T1 WITH (NOLOCK) INNER JOIN [Product] T2 WITH (NOLOCK) ON T2.[ProductId] = T1.[ProductId]) WHERE T1.[InvoiceId] = @InvoiceId and T1.[InvoiceDetailId] = @InvoiceDetailId ORDER BY T1.[InvoiceId], T1.[InvoiceDetailId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000435,11,0,true,false )
             ,new CursorDef("T000436", "SELECT [ProductStock], [ProductDescription], [ProductPrice] FROM [Product] WITH (NOLOCK) WHERE [ProductId] = @ProductId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000436,1,0,true,false )
             ,new CursorDef("T000437", "SELECT [InvoiceId], [InvoiceDetailId] FROM [InvoiceDetail] WITH (NOLOCK) WHERE [InvoiceId] = @InvoiceId AND [InvoiceDetailId] = @InvoiceDetailId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000437,1,0,true,false )
             ,new CursorDef("T000438", "INSERT INTO [InvoiceDetail] ([InvoiceId], [InvoiceDetailId], [InvoiceDetailQuantiity], [ProductId]) VALUES (@InvoiceId, @InvoiceDetailId, @InvoiceDetailQuantiity, @ProductId)", GxErrorMask.GX_NOMASK,prmT000438)
             ,new CursorDef("T000439", "UPDATE [InvoiceDetail] SET [InvoiceDetailQuantiity]=@InvoiceDetailQuantiity, [ProductId]=@ProductId  WHERE [InvoiceId] = @InvoiceId AND [InvoiceDetailId] = @InvoiceDetailId", GxErrorMask.GX_NOMASK,prmT000439)
             ,new CursorDef("T000440", "DELETE FROM [InvoiceDetail]  WHERE [InvoiceId] = @InvoiceId AND [InvoiceDetailId] = @InvoiceDetailId", GxErrorMask.GX_NOMASK,prmT000440)
             ,new CursorDef("T000441", "SELECT [ProductStock], [ProductDescription], [ProductPrice] FROM [Product] WITH (NOLOCK) WHERE [ProductId] = @ProductId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000441,1,0,true,false )
             ,new CursorDef("T000442", "UPDATE [Product] SET [ProductStock]=@ProductStock  WHERE [ProductId] = @ProductId", GxErrorMask.GX_NOMASK,prmT000442)
             ,new CursorDef("T000443", "SELECT [InvoiceId], [InvoiceDetailId] FROM [InvoiceDetail] WITH (NOLOCK) WHERE [InvoiceId] = @InvoiceId ORDER BY [InvoiceId], [InvoiceDetailId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000443,11,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                break;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                break;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 8 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 9 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 30) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                break;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 11 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                break;
             case 13 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 14 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 15 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 16 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 18 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 21 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 22 :
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 23 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                break;
             case 24 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 25 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 30) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                break;
             case 26 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                break;
             case 27 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 31 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                break;
             case 33 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 10 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 11 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 12 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 13 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 14 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 15 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 16 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 17 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 19 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 20 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 21 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 22 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 23 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 25 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 26 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 27 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 28 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 29 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 30 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 31 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 32 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 33 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
