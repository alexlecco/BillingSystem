/*
               File: Invoice
        Description: Invoice
             Author: GeneXus C# Generator version 10_1_6-46473
       Generated on: 11/30/2016 15:26:8.35
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxSuggest"+"_"+"COUNTRYID") == 0 )
         {
            A2CountryName = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2CountryName", A2CountryName);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            GXSGACOUNTRYID040( A2CountryName) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxSuggest"+"_"+"COUNTRYID") == 0 )
         {
            A2CountryName = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2CountryName", A2CountryName);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            GXSGACOUNTRYID040( A2CountryName) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxHideCode"+"_"+"COUNTRYID") == 0 )
         {
            A1CountryId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            n1CountryId = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
            h1CountryId = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            GXHCACOUNTRYID044( A1CountryId, h1CountryId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_24") == 0 )
         {
            A14InvoiceId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14InvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14InvoiceId), 6, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_24( A14InvoiceId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_25") == 0 )
         {
            A14InvoiceId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14InvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14InvoiceId), 6, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_25( A14InvoiceId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_22") == 0 )
         {
            A3CustomerId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3CustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3CustomerId), 6, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_22( A3CustomerId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_23") == 0 )
         {
            A1CountryId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            n1CountryId = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_23( A1CountryId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_27") == 0 )
         {
            A10ProductId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10ProductId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10ProductId), 6, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_27( A10ProductId) ;
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
            nGXsfl_75_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            sGXsfl_75_idx = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxnrGridinvoice_detail_newrow( nRC_Gridinvoice_detail, nGXsfl_75_idx, sGXsfl_75_idx) ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirm", "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_Invoice.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 90,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancel", "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_Invoice.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"" ;
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
            GxWebStd.gx_single_line_edit( context, edtCustomerId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A3CustomerId), 6, 0, ".", "")), "", 6, "chr", 1, "row", 6, 1, edtCustomerId_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A3CustomerId), "ZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(48);\"", 0, edtCustomerId_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Invoice.htm");
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
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\"  style=\"height:23px\">") ;
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
            context.WriteHtmlText( "<td style=\"height:23px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcustomertotalpurchases2_Internalname, 1, 1, 0, "Customer Balance", "", "", "", 0, lblTextblockcustomertotalpurchases2_Jsonclick, "", StyleString, ClassString, "HLP_Invoice.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCustomerBalance_Internalname, StringUtil.LTrim( StringUtil.NToC( A9CustomerBalance, 9, 2, ".", "")), "", 9, "chr", 1, "row", 9, 1, edtCustomerBalance_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A9CustomerBalance, "ZZZZZ9.99"), "", 0, edtCustomerBalance_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Invoice.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:16px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcustomertotalpurchases3_Internalname, 1, 1, 0, "Country Id", "", "", "", 0, lblTextblockcustomertotalpurchases3_Jsonclick, "", StyleString, ClassString, "HLP_Invoice.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCountryId_Internalname, StringUtil.RTrim( h1CountryId), "", 30, "chr", 1, "row", 30, 1, edtCountryId_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( h1CountryId, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtCountryId_Jsonclick, "", 0, 1, 0, true, "left", "HLP_Invoice.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\"  style=\"height:197px\">") ;
            context.WriteHtmlText( "<br>") ;
            wb_table5_71_044( true) ;
         }
         return  ;
      }

      protected void wb_table5_71_044e( bool wbgen )
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
            nGXsfl_75_idx = 0 ;
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
               B16InvoiceAmount = A16InvoiceAmount ;
               n16InvoiceAmount = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
               B7CustomerTotalPurchases = A7CustomerTotalPurchases ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
               B20InvoiceLastLineId = A20InvoiceLastLineId ;
               n20InvoiceLastLineId = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
               standaloneNotModal045( ) ;
               standaloneModal045( ) ;
               sMode5 = Gx_mode ;
               while ( nGXsfl_75_idx < nRC_Gridinvoice_detail )
               {
                  ReadRow045( ) ;
                  edtInvoiceDetailId_Enabled = (int)(context.localUtil.CToN( cgiGet( "INVOICEDETAILID_"+sGXsfl_75_idx+"Enabled"), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvoiceDetailId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvoiceDetailId_Enabled), 5, 0)));
                  edtProductId_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRODUCTID_"+sGXsfl_75_idx+"Enabled"), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProductId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProductId_Enabled), 5, 0)));
                  edtProductDescription_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRODUCTDESCRIPTION_"+sGXsfl_75_idx+"Enabled"), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProductDescription_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProductDescription_Enabled), 5, 0)));
                  edtProductPrice_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRODUCTPRICE_"+sGXsfl_75_idx+"Enabled"), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtProductPrice_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtProductPrice_Enabled), 5, 0)));
                  edtInvoiceDetailQuantiity_Enabled = (int)(context.localUtil.CToN( cgiGet( "INVOICEDETAILQUANTIITY_"+sGXsfl_75_idx+"Enabled"), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvoiceDetailQuantiity_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvoiceDetailQuantiity_Enabled), 5, 0)));
                  edtInvoiceDetailAmount_Enabled = (int)(context.localUtil.CToN( cgiGet( "INVOICEDETAILAMOUNT_"+sGXsfl_75_idx+"Enabled"), ".", ",")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvoiceDetailAmount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvoiceDetailAmount_Enabled), 5, 0)));
                  imgprompt_3_Link = cgiGet( "PROMPT_10_"+sGXsfl_75_idx+"Link") ;
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
               A16InvoiceAmount = B16InvoiceAmount ;
               n16InvoiceAmount = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
               A7CustomerTotalPurchases = B7CustomerTotalPurchases ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
               A20InvoiceLastLineId = B20InvoiceLastLineId ;
               n20InvoiceLastLineId = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
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
            B16InvoiceAmount = A16InvoiceAmount ;
            n16InvoiceAmount = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
            B7CustomerTotalPurchases = A7CustomerTotalPurchases ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
            B20InvoiceLastLineId = A20InvoiceLastLineId ;
            n20InvoiceLastLineId = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
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
            A16InvoiceAmount = B16InvoiceAmount ;
            n16InvoiceAmount = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
            A7CustomerTotalPurchases = B7CustomerTotalPurchases ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
            A20InvoiceLastLineId = B20InvoiceLastLineId ;
            n20InvoiceLastLineId = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
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

      protected void wb_table5_71_044( bool wbgen )
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
            wb_table5_71_044e( true) ;
         }
         else
         {
            wb_table5_71_044e( false) ;
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
               A9CustomerBalance = context.localUtil.CToN( cgiGet( edtCustomerBalance_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
               h1CountryId = cgiGet( edtCountryId_Internalname) ;
               A16InvoiceAmount = context.localUtil.CToN( cgiGet( edtInvoiceAmount_Internalname), ".", ",") ;
               n16InvoiceAmount = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
               /* Read saved values. */
               Z14InvoiceId = (int)(context.localUtil.CToN( cgiGet( "Z14InvoiceId"), ".", ",")) ;
               Z15InvoiceDate = context.localUtil.CToD( cgiGet( "Z15InvoiceDate"), 0) ;
               Z3CustomerId = (int)(context.localUtil.CToN( cgiGet( "Z3CustomerId"), ".", ",")) ;
               Z4CustomerName = cgiGet( "Z4CustomerName") ;
               Z1CountryId = (int)(context.localUtil.CToN( cgiGet( "Z1CountryId"), ".", ",")) ;
               O16InvoiceAmount = context.localUtil.CToN( cgiGet( "O16InvoiceAmount"), ".", ",") ;
               O7CustomerTotalPurchases = context.localUtil.CToN( cgiGet( "O7CustomerTotalPurchases"), ".", ",") ;
               O20InvoiceLastLineId = (short)(context.localUtil.CToN( cgiGet( "O20InvoiceLastLineId"), ".", ",")) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               nRC_Gridinvoice_detail = (short)(context.localUtil.CToN( cgiGet( "nRC_Gridinvoice_detail"), ".", ",")) ;
               Gx_date = context.localUtil.CToD( cgiGet( "vTODAY"), 0) ;
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ".", ",")) ;
               A1CountryId = (int)(context.localUtil.CToN( cgiGet( "GXHCCOUNTRYID"), ".", ",")) ;
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
         s16InvoiceAmount = O16InvoiceAmount ;
         n16InvoiceAmount = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
         s7CustomerTotalPurchases = O7CustomerTotalPurchases ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
         s20InvoiceLastLineId = O20InvoiceLastLineId ;
         n20InvoiceLastLineId = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
         s9CustomerBalance = O9CustomerBalance ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
         nGXsfl_75_idx = 0 ;
         while ( nGXsfl_75_idx < nRC_Gridinvoice_detail )
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
                        O16InvoiceAmount = A16InvoiceAmount ;
                        n16InvoiceAmount = false ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
                        O7CustomerTotalPurchases = A7CustomerTotalPurchases ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
                        O20InvoiceLastLineId = A20InvoiceLastLineId ;
                        n20InvoiceLastLineId = false ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
                        O9CustomerBalance = A9CustomerBalance ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
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
                           O16InvoiceAmount = A16InvoiceAmount ;
                           n16InvoiceAmount = false ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
                           O7CustomerTotalPurchases = A7CustomerTotalPurchases ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
                           O20InvoiceLastLineId = A20InvoiceLastLineId ;
                           n20InvoiceLastLineId = false ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
                           O9CustomerBalance = A9CustomerBalance ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
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
                              O16InvoiceAmount = A16InvoiceAmount ;
                              n16InvoiceAmount = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
                              O7CustomerTotalPurchases = A7CustomerTotalPurchases ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
                              O20InvoiceLastLineId = A20InvoiceLastLineId ;
                              n20InvoiceLastLineId = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
                              O9CustomerBalance = A9CustomerBalance ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
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
            ChangePostValue( "ZT_"+"Z17InvoiceDetailId_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17InvoiceDetailId), 2, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z18InvoiceDetailQuantiity_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z18InvoiceDetailQuantiity), 3, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z10ProductId_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10ProductId), 6, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z11ProductDescription_"+sGXsfl_75_idx, StringUtil.RTrim( Z11ProductDescription)) ;
            ChangePostValue( "ZT_"+"Z13ProductPrice_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( Z13ProductPrice, 9, 2, ".", ""))) ;
            ChangePostValue( "T12ProductStock_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(O12ProductStock), 4, 0, ".", ""))) ;
            ChangePostValue( "T19InvoiceDetailAmount_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( O19InvoiceDetailAmount, 9, 2, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_5_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_5), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_5_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_5), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_5_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_5), 4, 0, ".", ""))) ;
            if ( nIsMod_5 != 0 )
            {
               ChangePostValue( "INVOICEDETAILID_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtInvoiceDetailId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRODUCTID_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProductId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRODUCTDESCRIPTION_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProductDescription_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRODUCTPRICE_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProductPrice_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INVOICEDETAILQUANTIITY_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtInvoiceDetailQuantiity_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INVOICEDETAILAMOUNT_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtInvoiceDetailAmount_Enabled), 5, 0, ".", ""))) ;
            }
         }
         O16InvoiceAmount = s16InvoiceAmount ;
         n16InvoiceAmount = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
         O7CustomerTotalPurchases = s7CustomerTotalPurchases ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
         O20InvoiceLastLineId = s20InvoiceLastLineId ;
         n20InvoiceLastLineId = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
         O9CustomerBalance = s9CustomerBalance ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption040( )
      {
      }

      protected void ZM044( short GX_JID )
      {
         if ( ( GX_JID == 21 ) || ( GX_JID == 0 ) )
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
         if ( ( GX_JID == 22 ) || ( GX_JID == 0 ) )
         {
            Z4CustomerName = T00049_A4CustomerName[0] ;
            Z1CountryId = T00049_A1CountryId[0] ;
         }
         if ( GX_JID == -21 )
         {
            Z14InvoiceId = A14InvoiceId ;
            Z15InvoiceDate = A15InvoiceDate ;
            Z3CustomerId = A3CustomerId ;
            Z20InvoiceLastLineId = A20InvoiceLastLineId ;
            Z16InvoiceAmount = A16InvoiceAmount ;
            Z7CustomerTotalPurchases = A7CustomerTotalPurchases ;
            Z4CustomerName = A4CustomerName ;
            Z1CountryId = A1CountryId ;
            Z2CountryName = A2CountryName ;
         }
      }

      protected void standaloneNotModal( )
      {
         edtCustomerTotalPurchases_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCustomerTotalPurchases_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCustomerTotalPurchases_Enabled), 5, 0)));
         Gx_BScreen = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         Gx_date = DateTimeUtil.Today( ) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_date", context.localUtil.Format(Gx_date, "99/99/99"));
         imgprompt_3_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0020.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CUSTOMERID"+"'), id:'"+"CUSTOMERID"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"false"+");") ;
         edtCustomerTotalPurchases_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCustomerTotalPurchases_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCustomerTotalPurchases_Enabled), 5, 0)));
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
         {
            edtCustomerId_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCustomerId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCustomerId_Enabled), 5, 0)));
         }
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
         /* Using cursor T000417 */
         pr_default.execute(11, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound4 = 1 ;
            A7CustomerTotalPurchases = T000417_A7CustomerTotalPurchases[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
            A15InvoiceDate = T000417_A15InvoiceDate[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15InvoiceDate", context.localUtil.Format(A15InvoiceDate, "99/99/99"));
            A4CustomerName = T000417_A4CustomerName[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CustomerName", A4CustomerName);
            A2CountryName = T000417_A2CountryName[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2CountryName", A2CountryName);
            A3CustomerId = T000417_A3CustomerId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3CustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3CustomerId), 6, 0)));
            A1CountryId = T000417_A1CountryId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
            n1CountryId = T000417_n1CountryId[0] ;
            A20InvoiceLastLineId = T000417_A20InvoiceLastLineId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
            n20InvoiceLastLineId = T000417_n20InvoiceLastLineId[0] ;
            A16InvoiceAmount = T000417_A16InvoiceAmount[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
            n16InvoiceAmount = T000417_n16InvoiceAmount[0] ;
            ZM044( -21) ;
         }
         pr_default.close(11);
         OnLoadActions044( ) ;
      }

      protected void OnLoadActions044( )
      {
         /* Using cursor T000412 */
         pr_default.execute(9, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            A20InvoiceLastLineId = T000412_A20InvoiceLastLineId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
            n20InvoiceLastLineId = T000412_n20InvoiceLastLineId[0] ;
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
         pr_default.close(9);
         /* Using cursor T000414 */
         pr_default.execute(10, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(10) != 101) )
         {
            A16InvoiceAmount = T000414_A16InvoiceAmount[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
            n16InvoiceAmount = T000414_n16InvoiceAmount[0] ;
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
         pr_default.close(10);
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
         {
            A7CustomerTotalPurchases = (decimal)(O7CustomerTotalPurchases-A16InvoiceAmount) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
            {
               A7CustomerTotalPurchases = (decimal)(O7CustomerTotalPurchases+A16InvoiceAmount-O16InvoiceAmount) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
            }
         }
         A9CustomerBalance = (decimal)(A7CustomerTotalPurchases-A16InvoiceAmount) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
         h1CountryId = A2CountryName ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "h1CountryId", h1CountryId);
      }

      protected void CheckExtendedTable044( )
      {
         Gx_BScreen = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( h1CountryId)) )
         {
            A1CountryId = 0 ;
            n1CountryId = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
         }
         else
         {
            A2CountryName = h1CountryId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2CountryName", A2CountryName);
            /* Using cursor T000418 */
            pr_default.execute(12, new Object[] {A2CountryName});
            A1CountryId = T000418_A1CountryId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
            n1CountryId = T000418_n1CountryId[0] ;
            A1CountryId = T000418_A1CountryId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
            n1CountryId = T000418_n1CountryId[0] ;
            if ( ! ( (pr_default.getStatus(12) == 101) ) )
            {
               pr_default.readNext(12);
               if ( ! ( (pr_default.getStatus(12) == 101) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_ambiguousck", new   object[]  {"Country Name"}), 1, "");
                  AnyError = 1 ;
               }
            }
            else
            {
            }
            pr_default.close(12);
         }
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "h1CountryId", h1CountryId);
         /* Using cursor T000412 */
         pr_default.execute(9, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            A20InvoiceLastLineId = T000412_A20InvoiceLastLineId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
            n20InvoiceLastLineId = T000412_n20InvoiceLastLineId[0] ;
         }
         else
         {
            A20InvoiceLastLineId = 0 ;
            n20InvoiceLastLineId = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
         }
         pr_default.close(9);
         /* Using cursor T000414 */
         pr_default.execute(10, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(10) != 101) )
         {
            A16InvoiceAmount = T000414_A16InvoiceAmount[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
            n16InvoiceAmount = T000414_n16InvoiceAmount[0] ;
         }
         else
         {
            A16InvoiceAmount = 0 ;
            n16InvoiceAmount = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
         }
         pr_default.close(10);
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
         /* Using cursor T00049 */
         pr_default.execute(7, new Object[] {A3CustomerId});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No matching 'Customer'.", "ForeignKeyNotFound", 1, "CUSTOMERID");
            AnyError = 1 ;
            GX_FocusControl = edtCustomerId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A7CustomerTotalPurchases = T00049_A7CustomerTotalPurchases[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
            A4CustomerName = T00049_A4CustomerName[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CustomerName", A4CustomerName);
            A1CountryId = T00049_A1CountryId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
            n1CountryId = T00049_n1CountryId[0] ;
            O7CustomerTotalPurchases = A7CustomerTotalPurchases ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
         }
         pr_default.close(7);
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
         {
            A7CustomerTotalPurchases = (decimal)(O7CustomerTotalPurchases-A16InvoiceAmount) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
            {
               A7CustomerTotalPurchases = (decimal)(O7CustomerTotalPurchases+A16InvoiceAmount-O16InvoiceAmount) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
            }
         }
         A9CustomerBalance = (decimal)(A7CustomerTotalPurchases-A16InvoiceAmount) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
         if ( String.IsNullOrEmpty(StringUtil.RTrim( h1CountryId)) )
         {
            A1CountryId = 0 ;
            n1CountryId = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
         }
         else
         {
            A2CountryName = h1CountryId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2CountryName", A2CountryName);
            /* Using cursor T000419 */
            pr_default.execute(13, new Object[] {A2CountryName});
            A1CountryId = T000419_A1CountryId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
            n1CountryId = T000419_n1CountryId[0] ;
            A1CountryId = T000419_A1CountryId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
            n1CountryId = T000419_n1CountryId[0] ;
            if ( ! ( (pr_default.getStatus(13) == 101) ) )
            {
               pr_default.readNext(13);
               if ( ! ( (pr_default.getStatus(13) == 101) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_ambiguousck", new   object[]  {"Country Name"}), 1, "");
                  AnyError = 1 ;
               }
            }
            else
            {
            }
            pr_default.close(13);
         }
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "h1CountryId", h1CountryId);
         /* Using cursor T000410 */
         pr_default.execute(8, new Object[] {n1CountryId, A1CountryId});
         if ( (pr_default.getStatus(8) == 101) )
         {
            if ( ! ( (0==A1CountryId) && n1CountryId && String.IsNullOrEmpty(StringUtil.RTrim( A2CountryName)) ) )
            {
               GX_msglist.addItem("No matching 'Country'.", "ForeignKeyNotFound", 1, "");
               AnyError = 1 ;
            }
         }
         if ( AnyError == 0 )
         {
            A2CountryName = T000410_A2CountryName[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2CountryName", A2CountryName);
         }
         pr_default.close(8);
         if ( A15InvoiceDate > Gx_date )
         {
            GX_msglist.addItem("La fecha es mayor a la del dia de hoy", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors044( )
      {
         pr_default.close(9);
         pr_default.close(10);
         pr_default.close(7);
         pr_default.close(8);
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

      protected void gxLoad_24( int A14InvoiceId )
      {
         /* Using cursor T000421 */
         pr_default.execute(14, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(14) != 101) )
         {
            A20InvoiceLastLineId = T000421_A20InvoiceLastLineId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
            n20InvoiceLastLineId = T000421_n20InvoiceLastLineId[0] ;
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
         if ( (pr_default.getStatus(14) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(14);
      }

      protected void gxLoad_25( int A14InvoiceId )
      {
         /* Using cursor T000423 */
         pr_default.execute(15, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(15) != 101) )
         {
            A16InvoiceAmount = T000423_A16InvoiceAmount[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
            n16InvoiceAmount = T000423_n16InvoiceAmount[0] ;
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
         if ( (pr_default.getStatus(15) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(15);
      }

      protected void gxLoad_22( int A3CustomerId )
      {
         /* Using cursor T000424 */
         pr_default.execute(16, new Object[] {A3CustomerId});
         if ( (pr_default.getStatus(16) == 101) )
         {
            GX_msglist.addItem("No matching 'Customer'.", "ForeignKeyNotFound", 1, "CUSTOMERID");
            AnyError = 1 ;
            GX_FocusControl = edtCustomerId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A7CustomerTotalPurchases = T000424_A7CustomerTotalPurchases[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
            A4CustomerName = T000424_A4CustomerName[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CustomerName", A4CustomerName);
            A1CountryId = T000424_A1CountryId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
            n1CountryId = T000424_n1CountryId[0] ;
            O7CustomerTotalPurchases = A7CustomerTotalPurchases ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A7CustomerTotalPurchases, 9, 2, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A4CustomerName))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A1CountryId), 6, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(16) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(16);
      }

      protected void gxLoad_23( int A1CountryId )
      {
         /* Using cursor T000425 */
         pr_default.execute(17, new Object[] {n1CountryId, A1CountryId});
         if ( (pr_default.getStatus(17) == 101) )
         {
            if ( ! ( (0==A1CountryId) && n1CountryId && String.IsNullOrEmpty(StringUtil.RTrim( A2CountryName)) ) )
            {
               GX_msglist.addItem("No matching 'Country'.", "ForeignKeyNotFound", 1, "");
               AnyError = 1 ;
            }
         }
         if ( AnyError == 0 )
         {
            A2CountryName = T000425_A2CountryName[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2CountryName", A2CountryName);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A2CountryName))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(17) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(17);
      }

      protected void GetKey044( )
      {
         /* Using cursor T000426 */
         pr_default.execute(18, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound4 = 1 ;
         }
         else
         {
            RcdFound4 = 0 ;
         }
         pr_default.close(18);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00047 */
         pr_default.execute(5, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            ZM044( 21) ;
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
         /* Using cursor T000427 */
         pr_default.execute(19, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(19) != 101) )
         {
            while ( (pr_default.getStatus(19) != 101) && ( ( T000427_A14InvoiceId[0] < A14InvoiceId ) ) )
            {
               pr_default.readNext(19);
            }
            if ( (pr_default.getStatus(19) != 101) && ( ( T000427_A14InvoiceId[0] > A14InvoiceId ) ) )
            {
               A14InvoiceId = T000427_A14InvoiceId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14InvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14InvoiceId), 6, 0)));
               RcdFound4 = 1 ;
            }
         }
         pr_default.close(5);
      }

      protected void move_previous( )
      {
         RcdFound4 = 0 ;
         /* Using cursor T000428 */
         pr_default.execute(20, new Object[] {A14InvoiceId});
         if ( (pr_default.getStatus(20) != 101) )
         {
            while ( (pr_default.getStatus(20) != 101) && ( ( T000428_A14InvoiceId[0] > A14InvoiceId ) ) )
            {
               pr_default.readNext(20);
            }
            if ( (pr_default.getStatus(20) != 101) && ( ( T000428_A14InvoiceId[0] < A14InvoiceId ) ) )
            {
               A14InvoiceId = T000428_A14InvoiceId[0] ;
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
               A16InvoiceAmount = O16InvoiceAmount ;
               n16InvoiceAmount = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
               A7CustomerTotalPurchases = O7CustomerTotalPurchases ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
               A20InvoiceLastLineId = O20InvoiceLastLineId ;
               n20InvoiceLastLineId = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
               A9CustomerBalance = O9CustomerBalance ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
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
               A16InvoiceAmount = O16InvoiceAmount ;
               n16InvoiceAmount = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
               A7CustomerTotalPurchases = O7CustomerTotalPurchases ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
               A20InvoiceLastLineId = O20InvoiceLastLineId ;
               n20InvoiceLastLineId = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
               A9CustomerBalance = O9CustomerBalance ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
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
               A16InvoiceAmount = O16InvoiceAmount ;
               n16InvoiceAmount = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
               A7CustomerTotalPurchases = O7CustomerTotalPurchases ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
               A20InvoiceLastLineId = O20InvoiceLastLineId ;
               n20InvoiceLastLineId = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
               A9CustomerBalance = O9CustomerBalance ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
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
                  A16InvoiceAmount = O16InvoiceAmount ;
                  n16InvoiceAmount = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
                  A7CustomerTotalPurchases = O7CustomerTotalPurchases ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
                  A20InvoiceLastLineId = O20InvoiceLastLineId ;
                  n20InvoiceLastLineId = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
                  A9CustomerBalance = O9CustomerBalance ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
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
            A16InvoiceAmount = O16InvoiceAmount ;
            n16InvoiceAmount = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
            A7CustomerTotalPurchases = O7CustomerTotalPurchases ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
            A20InvoiceLastLineId = O20InvoiceLastLineId ;
            n20InvoiceLastLineId = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
            A9CustomerBalance = O9CustomerBalance ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
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
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( h1CountryId)) )
            {
               A1CountryId = 0 ;
               n1CountryId = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
            }
            else
            {
               A2CountryName = h1CountryId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2CountryName", A2CountryName);
               /* Using cursor T000429 */
               pr_default.execute(21, new Object[] {A2CountryName});
               A1CountryId = T000429_A1CountryId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
               n1CountryId = T000429_n1CountryId[0] ;
               A1CountryId = T000429_A1CountryId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
               n1CountryId = T000429_n1CountryId[0] ;
               if ( ! ( (pr_default.getStatus(21) == 101) ) )
               {
                  pr_default.readNext(21);
                  if ( ! ( (pr_default.getStatus(21) == 101) ) )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_ambiguousck", new   object[]  {"Country Name"}), 1, "");
                     AnyError = 1 ;
                  }
               }
               else
               {
               }
               pr_default.close(21);
            }
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "h1CountryId", h1CountryId);
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000430 */
            pr_default.execute(22, new Object[] {A14InvoiceId});
            if ( (pr_default.getStatus(22) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Invoice"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(22) == 101) || ( Z15InvoiceDate != T000430_A15InvoiceDate[0] ) || ( Z3CustomerId != T000430_A3CustomerId[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Invoice"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
         /* Using cursor T00048 */
         pr_default.execute(6, new Object[] {A3CustomerId});
         if ( (pr_default.getStatus(6) == 103) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Customer"}), "RecordIsLocked", 1, "");
            AnyError = 1 ;
            return  ;
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            if ( false || ( StringUtil.StrCmp(Z4CustomerName, T00048_A4CustomerName[0]) != 0 ) || ( Z1CountryId != T00048_A1CountryId[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Customer"}), "RecordWasChanged", 1, "");
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
                     /* Using cursor T000431 */
                     pr_default.execute(23, new Object[] {A15InvoiceDate, A3CustomerId});
                     pr_default.close(23);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000432 */
                     pr_default.execute(24);
                     A14InvoiceId = T000432_A14InvoiceId[0] ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14InvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14InvoiceId), 6, 0)));
                     pr_default.close(24);
                     if ( AnyError == 0 )
                     {
                        UpdateTablesN1044( ) ;
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
                     /* Using cursor T000433 */
                     pr_default.execute(25, new Object[] {A15InvoiceDate, A3CustomerId, A14InvoiceId});
                     pr_default.close(25);
                     if ( (pr_default.getStatus(25) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Invoice"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate044( ) ;
                     if ( AnyError == 0 )
                     {
                        UpdateTablesN1044( ) ;
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
                  A16InvoiceAmount = O16InvoiceAmount ;
                  n16InvoiceAmount = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
                  A7CustomerTotalPurchases = O7CustomerTotalPurchases ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
                  A20InvoiceLastLineId = O20InvoiceLastLineId ;
                  n20InvoiceLastLineId = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
                  A9CustomerBalance = O9CustomerBalance ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
                  ScanStart045( ) ;
                  while ( RcdFound5 != 0 )
                  {
                     getByPrimaryKey045( ) ;
                     Delete045( ) ;
                     ScanNext045( ) ;
                     O16InvoiceAmount = A16InvoiceAmount ;
                     n16InvoiceAmount = false ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
                     O7CustomerTotalPurchases = A7CustomerTotalPurchases ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
                     O20InvoiceLastLineId = A20InvoiceLastLineId ;
                     n20InvoiceLastLineId = false ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
                     O9CustomerBalance = A9CustomerBalance ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
                  }
                  ScanEnd045( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000434 */
                     pr_default.execute(26, new Object[] {A14InvoiceId});
                     pr_default.close(26);
                     if ( AnyError == 0 )
                     {
                        UpdateTablesN1044( ) ;
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
            /* Using cursor T000436 */
            pr_default.execute(27, new Object[] {A14InvoiceId});
            if ( (pr_default.getStatus(27) != 101) )
            {
               A20InvoiceLastLineId = T000436_A20InvoiceLastLineId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
               n20InvoiceLastLineId = T000436_n20InvoiceLastLineId[0] ;
            }
            else
            {
               A20InvoiceLastLineId = 0 ;
               n20InvoiceLastLineId = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
            }
            pr_default.close(27);
            /* Using cursor T000438 */
            pr_default.execute(28, new Object[] {A14InvoiceId});
            if ( (pr_default.getStatus(28) != 101) )
            {
               A16InvoiceAmount = T000438_A16InvoiceAmount[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
               n16InvoiceAmount = T000438_n16InvoiceAmount[0] ;
            }
            else
            {
               A16InvoiceAmount = 0 ;
               n16InvoiceAmount = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
            }
            pr_default.close(28);
            /* Using cursor T000439 */
            pr_default.execute(29, new Object[] {A3CustomerId});
            Z4CustomerName = T000439_A4CustomerName[0] ;
            Z1CountryId = T000439_A1CountryId[0] ;
            A7CustomerTotalPurchases = T000439_A7CustomerTotalPurchases[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
            A4CustomerName = T000439_A4CustomerName[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CustomerName", A4CustomerName);
            A1CountryId = T000439_A1CountryId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
            n1CountryId = T000439_n1CountryId[0] ;
            O7CustomerTotalPurchases = A7CustomerTotalPurchases ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
            pr_default.close(29);
            if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
            {
               A7CustomerTotalPurchases = (decimal)(O7CustomerTotalPurchases-A16InvoiceAmount) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
               {
                  A7CustomerTotalPurchases = (decimal)(O7CustomerTotalPurchases+A16InvoiceAmount-O16InvoiceAmount) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
               }
            }
            A9CustomerBalance = (decimal)(A7CustomerTotalPurchases-A16InvoiceAmount) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
            /* Using cursor T000440 */
            pr_default.execute(30, new Object[] {n1CountryId, A1CountryId});
            A2CountryName = T000440_A2CountryName[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2CountryName", A2CountryName);
            pr_default.close(30);
         }
      }

      protected void ProcessNestedLevel045( )
      {
         s16InvoiceAmount = O16InvoiceAmount ;
         n16InvoiceAmount = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
         s7CustomerTotalPurchases = O7CustomerTotalPurchases ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
         s20InvoiceLastLineId = O20InvoiceLastLineId ;
         n20InvoiceLastLineId = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
         s9CustomerBalance = O9CustomerBalance ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
         nGXsfl_75_idx = 0 ;
         while ( nGXsfl_75_idx < nRC_Gridinvoice_detail )
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
               O16InvoiceAmount = A16InvoiceAmount ;
               n16InvoiceAmount = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
               O7CustomerTotalPurchases = A7CustomerTotalPurchases ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
               O20InvoiceLastLineId = A20InvoiceLastLineId ;
               n20InvoiceLastLineId = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
               O9CustomerBalance = A9CustomerBalance ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
            }
            ChangePostValue( edtInvoiceDetailId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A17InvoiceDetailId), 2, 0, ".", ""))) ;
            ChangePostValue( edtProductId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A10ProductId), 6, 0, ".", ""))) ;
            ChangePostValue( edtProductDescription_Internalname, StringUtil.RTrim( A11ProductDescription)) ;
            ChangePostValue( edtProductPrice_Internalname, StringUtil.LTrim( StringUtil.NToC( A13ProductPrice, 9, 2, ".", ""))) ;
            ChangePostValue( edtInvoiceDetailQuantiity_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A18InvoiceDetailQuantiity), 3, 0, ".", ""))) ;
            ChangePostValue( edtInvoiceDetailAmount_Internalname, StringUtil.LTrim( StringUtil.NToC( A19InvoiceDetailAmount, 9, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z17InvoiceDetailId_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17InvoiceDetailId), 2, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z18InvoiceDetailQuantiity_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z18InvoiceDetailQuantiity), 3, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z10ProductId_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z10ProductId), 6, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z11ProductDescription_"+sGXsfl_75_idx, StringUtil.RTrim( Z11ProductDescription)) ;
            ChangePostValue( "ZT_"+"Z13ProductPrice_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( Z13ProductPrice, 9, 2, ".", ""))) ;
            ChangePostValue( "T12ProductStock_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(O12ProductStock), 4, 0, ".", ""))) ;
            ChangePostValue( "T19InvoiceDetailAmount_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( O19InvoiceDetailAmount, 9, 2, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_5_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_5), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_5_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_5), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_5_"+sGXsfl_75_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_5), 4, 0, ".", ""))) ;
            if ( nIsMod_5 != 0 )
            {
               ChangePostValue( "INVOICEDETAILID_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtInvoiceDetailId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRODUCTID_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProductId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRODUCTDESCRIPTION_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProductDescription_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRODUCTPRICE_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtProductPrice_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INVOICEDETAILQUANTIITY_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtInvoiceDetailQuantiity_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "INVOICEDETAILAMOUNT_"+sGXsfl_75_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtInvoiceDetailAmount_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll045( ) ;
         if ( AnyError != 0 )
         {
            O16InvoiceAmount = s16InvoiceAmount ;
            n16InvoiceAmount = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
            O7CustomerTotalPurchases = s7CustomerTotalPurchases ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
            O20InvoiceLastLineId = s20InvoiceLastLineId ;
            n20InvoiceLastLineId = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
            O9CustomerBalance = s9CustomerBalance ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
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
            O16InvoiceAmount = s16InvoiceAmount ;
            n16InvoiceAmount = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16InvoiceAmount", StringUtil.LTrim( StringUtil.Str( A16InvoiceAmount, 9, 2)));
            O7CustomerTotalPurchases = s7CustomerTotalPurchases ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
            O20InvoiceLastLineId = s20InvoiceLastLineId ;
            n20InvoiceLastLineId = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20InvoiceLastLineId", StringUtil.LTrim( StringUtil.Str( (decimal)(A20InvoiceLastLineId), 4, 0)));
            O9CustomerBalance = s9CustomerBalance ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
         }
         /* Restore parent mode. */
         Gx_mode = sMode4 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
         /* Using cursor T000441 */
         pr_default.execute(31, new Object[] {A7CustomerTotalPurchases, A3CustomerId});
         pr_default.close(31);
      }

      protected void UpdateTablesN1044( )
      {
         /* Using cursor T000442 */
         pr_default.execute(32, new Object[] {A7CustomerTotalPurchases, A3CustomerId});
         pr_default.close(32);
      }

      protected void EndLevel044( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(22);
         }
         pr_default.close(6);
         if ( AnyError == 0 )
         {
            BeforeComplete044( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(20);
            pr_default.close(19);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(29);
            pr_default.close(30);
            pr_default.close(27);
            pr_default.close(28);
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
            pr_default.close(20);
            pr_default.close(19);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(29);
            pr_default.close(30);
            pr_default.close(27);
            pr_default.close(28);
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
         /* Using cursor T000443 */
         pr_default.execute(33);
         RcdFound4 = 0 ;
         if ( (pr_default.getStatus(33) != 101) )
         {
            RcdFound4 = 1 ;
            A14InvoiceId = T000443_A14InvoiceId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14InvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14InvoiceId), 6, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext044( )
      {
         pr_default.readNext(33);
         RcdFound4 = 0 ;
         if ( (pr_default.getStatus(33) != 101) )
         {
            RcdFound4 = 1 ;
            A14InvoiceId = T000443_A14InvoiceId[0] ;
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
         edtCustomerBalance_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCustomerBalance_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCustomerBalance_Enabled), 5, 0)));
         edtCountryId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCountryId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCountryId_Enabled), 5, 0)));
         edtInvoiceAmount_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvoiceAmount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInvoiceAmount_Enabled), 5, 0)));
      }

      protected void ZM045( short GX_JID )
      {
         if ( ( GX_JID == 26 ) || ( GX_JID == 0 ) )
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
         if ( ( GX_JID == 27 ) || ( GX_JID == 0 ) )
         {
            Z11ProductDescription = T00045_A11ProductDescription[0] ;
            Z13ProductPrice = T00045_A13ProductPrice[0] ;
         }
         if ( GX_JID == -26 )
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
         edtCustomerTotalPurchases_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCustomerTotalPurchases_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCustomerTotalPurchases_Enabled), 5, 0)));
         edtCustomerTotalPurchases_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCustomerTotalPurchases_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCustomerTotalPurchases_Enabled), 5, 0)));
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
         /* Using cursor T000444 */
         pr_default.execute(34, new Object[] {A14InvoiceId, A17InvoiceDetailId});
         if ( (pr_default.getStatus(34) != 101) )
         {
            RcdFound5 = 1 ;
            A12ProductStock = T000444_A12ProductStock[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12ProductStock", StringUtil.LTrim( StringUtil.Str( (decimal)(A12ProductStock), 4, 0)));
            A11ProductDescription = T000444_A11ProductDescription[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11ProductDescription", A11ProductDescription);
            A13ProductPrice = T000444_A13ProductPrice[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ProductPrice", StringUtil.LTrim( StringUtil.Str( A13ProductPrice, 9, 2)));
            A18InvoiceDetailQuantiity = T000444_A18InvoiceDetailQuantiity[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18InvoiceDetailQuantiity", StringUtil.LTrim( StringUtil.Str( (decimal)(A18InvoiceDetailQuantiity), 3, 0)));
            A10ProductId = T000444_A10ProductId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10ProductId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10ProductId), 6, 0)));
            ZM045( -26) ;
         }
         pr_default.close(34);
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
         {
            A7CustomerTotalPurchases = (decimal)(O7CustomerTotalPurchases+A16InvoiceAmount-O16InvoiceAmount) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
         }
         A9CustomerBalance = (decimal)(A7CustomerTotalPurchases-A16InvoiceAmount) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
         {
            A7CustomerTotalPurchases = (decimal)(O7CustomerTotalPurchases+A16InvoiceAmount-O16InvoiceAmount) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
         }
         A9CustomerBalance = (decimal)(A7CustomerTotalPurchases-A16InvoiceAmount) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
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

      protected void gxLoad_27( int A10ProductId )
      {
         /* Using cursor T000445 */
         pr_default.execute(35, new Object[] {A10ProductId});
         if ( (pr_default.getStatus(35) == 101) )
         {
            GX_msglist.addItem("No matching 'Product'.", "ForeignKeyNotFound", 1, "PRODUCTID");
            AnyError = 1 ;
            GX_FocusControl = edtProductId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A12ProductStock = T000445_A12ProductStock[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12ProductStock", StringUtil.LTrim( StringUtil.Str( (decimal)(A12ProductStock), 4, 0)));
            A11ProductDescription = T000445_A11ProductDescription[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11ProductDescription", A11ProductDescription);
            A13ProductPrice = T000445_A13ProductPrice[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ProductPrice", StringUtil.LTrim( StringUtil.Str( A13ProductPrice, 9, 2)));
            O12ProductStock = A12ProductStock ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12ProductStock", StringUtil.LTrim( StringUtil.Str( (decimal)(A12ProductStock), 4, 0)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A12ProductStock), 4, 0, ".", "")))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A11ProductDescription))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( A13ProductPrice, 9, 2, ".", "")))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(35) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(35);
      }

      protected void GetKey045( )
      {
         /* Using cursor T000446 */
         pr_default.execute(36, new Object[] {A14InvoiceId, A17InvoiceDetailId});
         if ( (pr_default.getStatus(36) != 101) )
         {
            RcdFound5 = 1 ;
         }
         else
         {
            RcdFound5 = 0 ;
         }
         pr_default.close(36);
      }

      protected void getByPrimaryKey045( )
      {
         /* Using cursor T00043 */
         pr_default.execute(1, new Object[] {A14InvoiceId, A17InvoiceDetailId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM045( 26) ;
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
                     /* Using cursor T000447 */
                     pr_default.execute(37, new Object[] {A14InvoiceId, A17InvoiceDetailId, A18InvoiceDetailQuantiity, A10ProductId});
                     pr_default.close(37);
                     if ( (pr_default.getStatus(37) == 1) )
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
                     /* Using cursor T000448 */
                     pr_default.execute(38, new Object[] {A18InvoiceDetailQuantiity, A10ProductId, A14InvoiceId, A17InvoiceDetailId});
                     pr_default.close(38);
                     if ( (pr_default.getStatus(38) == 103) )
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
                  /* Using cursor T000449 */
                  pr_default.execute(39, new Object[] {A14InvoiceId, A17InvoiceDetailId});
                  pr_default.close(39);
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
            /* Using cursor T000450 */
            pr_default.execute(40, new Object[] {A10ProductId});
            Z11ProductDescription = T000450_A11ProductDescription[0] ;
            Z13ProductPrice = T000450_A13ProductPrice[0] ;
            A12ProductStock = T000450_A12ProductStock[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12ProductStock", StringUtil.LTrim( StringUtil.Str( (decimal)(A12ProductStock), 4, 0)));
            A11ProductDescription = T000450_A11ProductDescription[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11ProductDescription", A11ProductDescription);
            A13ProductPrice = T000450_A13ProductPrice[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ProductPrice", StringUtil.LTrim( StringUtil.Str( A13ProductPrice, 9, 2)));
            O12ProductStock = A12ProductStock ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12ProductStock", StringUtil.LTrim( StringUtil.Str( (decimal)(A12ProductStock), 4, 0)));
            pr_default.close(40);
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
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
            {
               A7CustomerTotalPurchases = (decimal)(O7CustomerTotalPurchases+A16InvoiceAmount-O16InvoiceAmount) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
            }
            A9CustomerBalance = (decimal)(A7CustomerTotalPurchases-A16InvoiceAmount) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
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
         /* Using cursor T000451 */
         pr_default.execute(41, new Object[] {A12ProductStock, A10ProductId});
         pr_default.close(41);
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
         /* Using cursor T000452 */
         pr_default.execute(42, new Object[] {A14InvoiceId});
         RcdFound5 = 0 ;
         if ( (pr_default.getStatus(42) != 101) )
         {
            RcdFound5 = 1 ;
            A17InvoiceDetailId = T000452_A17InvoiceDetailId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17InvoiceDetailId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17InvoiceDetailId), 2, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext045( )
      {
         pr_default.readNext(42);
         RcdFound5 = 0 ;
         if ( (pr_default.getStatus(42) != 101) )
         {
            RcdFound5 = 1 ;
            A17InvoiceDetailId = T000452_A17InvoiceDetailId[0] ;
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
         nGXsfl_75_idx = (short)(nGXsfl_75_idx+1) ;
         sGXsfl_75_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_75_idx), 4, 0)), 4, "0") ;
         edtInvoiceDetailId_Internalname = "INVOICEDETAILID_"+sGXsfl_75_idx ;
         edtProductId_Internalname = "PRODUCTID_"+sGXsfl_75_idx ;
         imgprompt_10_Internalname = "PROMPT_10_"+sGXsfl_75_idx ;
         edtProductDescription_Internalname = "PRODUCTDESCRIPTION_"+sGXsfl_75_idx ;
         edtProductPrice_Internalname = "PRODUCTPRICE_"+sGXsfl_75_idx ;
         edtInvoiceDetailQuantiity_Internalname = "INVOICEDETAILQUANTIITY_"+sGXsfl_75_idx ;
         edtInvoiceDetailAmount_Internalname = "INVOICEDETAILAMOUNT_"+sGXsfl_75_idx ;
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
            if ( ((int)(nGXsfl_75_idx) % (2)) == 0 )
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
         imgprompt_10_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0030.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PRODUCTID_"+sGXsfl_75_idx+"'), id:'"+"PRODUCTID_"+sGXsfl_75_idx+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"gx.dom.form()."+"nIsMod_5_"+sGXsfl_75_idx+","+"'', false"+","+"false"+");") ;
         /* * Property Link not supported in */
         /* * Property Link not supported in */
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_5_" + sGXsfl_75_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_75_idx + "',75)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridinvoice_detailRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtInvoiceDetailId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A17InvoiceDetailId), 2, 0, ".", "")),(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)2,(short)-1,(int)edtInvoiceDetailId_Enabled,(short)1,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A17InvoiceDetailId), "Z9"),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(76);\"",(short)0,(String)edtInvoiceDetailId_Jsonclick,(String)"",(short)75,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_5_" + sGXsfl_75_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 77,'',false,'" + sGXsfl_75_idx + "',75)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridinvoice_detailRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProductId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A10ProductId), 6, 0, ".", "")),(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)6,(short)-1,(int)edtProductId_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A10ProductId), "ZZZZZ9"),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(77);\"",(short)0,(String)edtProductId_Jsonclick,(String)"",(short)75,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Static imag