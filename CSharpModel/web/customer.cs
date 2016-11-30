/*
               File: Customer
        Description: Customer
             Author: GeneXus C# Generator version 10_1_6-46473
       Generated on: 11/25/2016 15:15:9.48
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
   public class customer : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            GXHCACOUNTRYID022( A1CountryId, h1CountryId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_10") == 0 )
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
            gxLoad_10( A1CountryId) ;
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
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp ;
         }
         radCustomerGender.Name = "CUSTOMERGENDER" ;
         radCustomerGender.WebTags = "" ;
         radCustomerGender.addItem("M", "Male", 0);
         radCustomerGender.addItem("F", "Female", 0);
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_6-46473", 0) ;
         Form.Meta.addItem("Description", "Customer", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtCustomerId_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("GeneXusX");
      }

      public customer( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("GeneXusX");
      }

      public customer( IGxContext context )
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
         radCustomerGender = new GXRadio();
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
            wb_table1_2_022( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_022e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_022( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_022( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_022e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Customer"+"</legend>") ;
            wb_table3_27_022( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_022e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_022e( true) ;
         }
         else
         {
            wb_table1_2_022e( false) ;
         }
      }

      protected void wb_table3_27_022( bool wbgen )
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
            wb_table4_33_022( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_022e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirm", "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_Customer.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancel", "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_Customer.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Delete", "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_Customer.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_022e( true) ;
         }
         else
         {
            wb_table3_27_022e( false) ;
         }
      }

      protected void wb_table4_33_022( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockcustomerid_Internalname, 1, 1, 0, "Id", "", "", "", 0, lblTextblockcustomerid_Jsonclick, "", StyleString, ClassString, "HLP_Customer.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCustomerId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A3CustomerId), 6, 0, ".", "")), "", 6, "chr", 1, "row", 6, 1, edtCustomerId_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A3CustomerId), "ZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(38);\"", 0, edtCustomerId_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Customer.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcustomername_Internalname, 1, 1, 0, "Name", "", "", "", 0, lblTextblockcustomername_Jsonclick, "", StyleString, ClassString, "HLP_Customer.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCustomerName_Internalname, StringUtil.RTrim( A4CustomerName), "", 30, "chr", 1, "row", 30, 1, edtCustomerName_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A4CustomerName, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", 0, edtCustomerName_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Customer.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcustomeraddress_Internalname, 1, 1, 0, "Address", "", "", "", 0, lblTextblockcustomeraddress_Jsonclick, "", StyleString, ClassString, "HLP_Customer.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCustomerAddress_Internalname, StringUtil.RTrim( A5CustomerAddress), "", 30, "chr", 1, "row", 30, 1, edtCustomerAddress_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A5CustomerAddress, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", 0, edtCustomerAddress_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Customer.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcustomergender_Internalname, 1, 1, 0, "Gender", "", "", "", 0, lblTextblockcustomergender_Jsonclick, "", StyleString, ClassString, "HLP_Customer.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Radio button */
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            GxWebStd.gx_radio_ctrl( context, radCustomerGender, radCustomerGender_Internalname, A6CustomerGender, "", 1, radCustomerGender.Enabled, 1, 1, StyleString, ClassString, 0, radCustomerGender_Jsonclick, "", TempTags+" onclick=\"gx.evt.onchange(this);\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", "HLP_Customer.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcustomertotalpurchases_Internalname, 1, 1, 0, "Total Purchases", "", "", "", 0, lblTextblockcustomertotalpurchases_Jsonclick, "", StyleString, ClassString, "HLP_Customer.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCustomerTotalPurchases_Internalname, StringUtil.LTrim( StringUtil.NToC( A7CustomerTotalPurchases, 9, 2, ".", "")), "", 9, "chr", 1, "row", 9, 1, edtCustomerTotalPurchases_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A7CustomerTotalPurchases, "ZZZZZ9.99"), "", 0, edtCustomerTotalPurchases_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Customer.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcustomertotalpayments_Internalname, 1, 1, 0, "Total Payments", "", "", "", 0, lblTextblockcustomertotalpayments_Jsonclick, "", StyleString, ClassString, "HLP_Customer.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCustomerTotalPayments_Internalname, StringUtil.LTrim( StringUtil.NToC( A8CustomerTotalPayments, 9, 2, ".", "")), "", 9, "chr", 1, "row", 9, 1, edtCustomerTotalPayments_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A8CustomerTotalPayments, "ZZZZZ9.99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(63);\"", 0, edtCustomerTotalPayments_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Customer.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcustomerbalance_Internalname, 1, 1, 0, "Balance", "", "", "", 0, lblTextblockcustomerbalance_Jsonclick, "", StyleString, ClassString, "HLP_Customer.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCustomerBalance_Internalname, StringUtil.LTrim( StringUtil.NToC( A9CustomerBalance, 9, 2, ".", "")), "", 9, "chr", 1, "row", 9, 1, edtCustomerBalance_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A9CustomerBalance, "ZZZZZ9.99"), "", 0, edtCustomerBalance_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Customer.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcountryid_Internalname, 1, 1, 0, "Country Id", "", "", "", 0, lblTextblockcountryid_Jsonclick, "", StyleString, ClassString, "HLP_Customer.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCountryId_Internalname, StringUtil.RTrim( h1CountryId), "", 30, "chr", 1, "row", 30, 1, edtCountryId_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( h1CountryId, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(73);\"", 0, edtCountryId_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Customer.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcountryname_Internalname, 1, 1, 0, "Country Name", "", "", "", 0, lblTextblockcountryname_Jsonclick, "", StyleString, ClassString, "HLP_Customer.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCountryName_Internalname, StringUtil.RTrim( A2CountryName), "", 30, "chr", 1, "row", 30, 1, edtCountryName_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A2CountryName, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtCountryName_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Customer.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_022e( true) ;
         }
         else
         {
            wb_table4_33_022e( false) ;
         }
      }

      protected void wb_table2_5_022( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, "", context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "GeneXusX"), "GeneXusX", imgBtn_first_Visible, 1, "", "First", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Customer.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Customer.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, "", context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "GeneXusX"), "GeneXusX", imgBtn_previous_Visible, 1, "", "Previous", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Customer.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Customer.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, "", context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "GeneXusX"), "GeneXusX", imgBtn_next_Visible, 1, "", "Next", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Customer.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Customer.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, "", context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "GeneXusX"), "GeneXusX", imgBtn_last_Visible, 1, "", "Last", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Customer.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Customer.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, "", context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "GeneXusX"), "GeneXusX", imgBtn_select_Visible, 1, "", "Select", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0020.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CUSTOMERID"+"'), id:'"+"CUSTOMERID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Customer.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0020.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CUSTOMERID"+"'), id:'"+"CUSTOMERID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Customer.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, "", context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "GeneXusX"), "GeneXusX", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirm", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Customer.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Customer.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, "", context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "GeneXusX"), "GeneXusX", imgBtn_cancel2_Visible, 1, "", "Cancel", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Customer.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Customer.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, "", context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "GeneXusX"), "GeneXusX", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Delete", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Customer.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Customer.htm");
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
            wb_table2_5_022e( true) ;
         }
         else
         {
            wb_table2_5_022e( false) ;
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
               A5CustomerAddress = cgiGet( edtCustomerAddress_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5CustomerAddress", A5CustomerAddress);
               A6CustomerGender = cgiGet( radCustomerGender_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6CustomerGender", A6CustomerGender);
               A7CustomerTotalPurchases = context.localUtil.CToN( cgiGet( edtCustomerTotalPurchases_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
               if ( ( ( context.localUtil.CToN( cgiGet( edtCustomerTotalPayments_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCustomerTotalPayments_Internalname), ".", ",") > 999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "CUSTOMERTOTALPAYMENTS");
                  AnyError = 1 ;
                  GX_FocusControl = edtCustomerTotalPayments_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A8CustomerTotalPayments = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CustomerTotalPayments", StringUtil.LTrim( StringUtil.Str( A8CustomerTotalPayments, 9, 2)));
               }
               else
               {
                  A8CustomerTotalPayments = context.localUtil.CToN( cgiGet( edtCustomerTotalPayments_Internalname), ".", ",") ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CustomerTotalPayments", StringUtil.LTrim( StringUtil.Str( A8CustomerTotalPayments, 9, 2)));
               }
               A9CustomerBalance = context.localUtil.CToN( cgiGet( edtCustomerBalance_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
               h1CountryId = cgiGet( edtCountryId_Internalname) ;
               A2CountryName = cgiGet( edtCountryName_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2CountryName", A2CountryName);
               /* Read saved values. */
               Z3CustomerId = (int)(context.localUtil.CToN( cgiGet( "Z3CustomerId"), ".", ",")) ;
               Z4CustomerName = cgiGet( "Z4CustomerName") ;
               Z5CustomerAddress = cgiGet( "Z5CustomerAddress") ;
               Z6CustomerGender = cgiGet( "Z6CustomerGender") ;
               Z7CustomerTotalPurchases = context.localUtil.CToN( cgiGet( "Z7CustomerTotalPurchases"), ".", ",") ;
               Z8CustomerTotalPayments = context.localUtil.CToN( cgiGet( "Z8CustomerTotalPayments"), ".", ",") ;
               Z1CountryId = (int)(context.localUtil.CToN( cgiGet( "Z1CountryId"), ".", ",")) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ",")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ",")) ;
               Gx_mode = cgiGet( "Mode") ;
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ".", ",")) ;
               A1CountryId = (int)(context.localUtil.CToN( cgiGet( "GXHCCOUNTRYID"), ".", ",")) ;
               Gx_mode = cgiGet( "vMODE") ;
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
                  A3CustomerId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3CustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3CustomerId), 6, 0)));
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
               InitAll022( ) ;
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
         DisableAttributes022( ) ;
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

      protected void ResetCaption020( )
      {
      }

      protected void ZM022( short GX_JID )
      {
         if ( ( GX_JID == 9 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z4CustomerName = T00023_A4CustomerName[0] ;
               Z5CustomerAddress = T00023_A5CustomerAddress[0] ;
               Z6CustomerGender = T00023_A6CustomerGender[0] ;
               Z7CustomerTotalPurchases = T00023_A7CustomerTotalPurchases[0] ;
               Z8CustomerTotalPayments = T00023_A8CustomerTotalPayments[0] ;
               Z1CountryId = T00023_A1CountryId[0] ;
            }
            else
            {
               Z4CustomerName = A4CustomerName ;
               Z5CustomerAddress = A5CustomerAddress ;
               Z6CustomerGender = A6CustomerGender ;
               Z7CustomerTotalPurchases = A7CustomerTotalPurchases ;
               Z8CustomerTotalPayments = A8CustomerTotalPayments ;
               Z1CountryId = A1CountryId ;
            }
         }
         if ( GX_JID == -9 )
         {
            Z3CustomerId = A3CustomerId ;
            Z4CustomerName = A4CustomerName ;
            Z5CustomerAddress = A5CustomerAddress ;
            Z6CustomerGender = A6CustomerGender ;
            Z7CustomerTotalPurchases = A7CustomerTotalPurchases ;
            Z8CustomerTotalPayments = A8CustomerTotalPayments ;
            Z1CountryId = A1CountryId ;
            Z2CountryName = A2CountryName ;
         }
      }

      protected void standaloneNotModal( )
      {
         edtCustomerTotalPurchases_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCustomerTotalPurchases_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCustomerTotalPurchases_Enabled), 5, 0)));
         edtCustomerBalance_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCustomerBalance_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCustomerBalance_Enabled), 5, 0)));
         Gx_BScreen = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         edtCustomerTotalPurchases_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCustomerTotalPurchases_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCustomerTotalPurchases_Enabled), 5, 0)));
         edtCustomerBalance_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCustomerBalance_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCustomerBalance_Enabled), 5, 0)));
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && String.IsNullOrEmpty(StringUtil.RTrim( A6CustomerGender)) && ( Gx_BScreen == 0 ) )
         {
            A6CustomerGender = "F" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6CustomerGender", A6CustomerGender);
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
      }

      protected void Load022( )
      {
         /* Using cursor T00025 */
         pr_default.execute(3, new Object[] {A3CustomerId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound2 = 1 ;
            A4CustomerName = T00025_A4CustomerName[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CustomerName", A4CustomerName);
            A5CustomerAddress = T00025_A5CustomerAddress[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5CustomerAddress", A5CustomerAddress);
            A6CustomerGender = T00025_A6CustomerGender[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6CustomerGender", A6CustomerGender);
            A7CustomerTotalPurchases = T00025_A7CustomerTotalPurchases[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
            A8CustomerTotalPayments = T00025_A8CustomerTotalPayments[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CustomerTotalPayments", StringUtil.LTrim( StringUtil.Str( A8CustomerTotalPayments, 9, 2)));
            A2CountryName = T00025_A2CountryName[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2CountryName", A2CountryName);
            A1CountryId = T00025_A1CountryId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
            n1CountryId = T00025_n1CountryId[0] ;
            ZM022( -9) ;
         }
         pr_default.close(3);
         OnLoadActions022( ) ;
      }

      protected void OnLoadActions022( )
      {
         A9CustomerBalance = (decimal)(A7CustomerTotalPurchases-A8CustomerTotalPayments) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
         h1CountryId = A2CountryName ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "h1CountryId", h1CountryId);
      }

      protected void CheckExtendedTable022( )
      {
         Gx_BScreen = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( h1CountryId)) )
         {
            A1CountryId = 0 ;
            n1CountryId = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
            n1CountryId = ((0==A1CountryId) ? true : false) ;
         }
         else
         {
            A2CountryName = h1CountryId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2CountryName", A2CountryName);
            /* Using cursor T00026 */
            pr_default.execute(4, new Object[] {A2CountryName});
            A1CountryId = T00026_A1CountryId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
            n1CountryId = T00026_n1CountryId[0] ;
            A1CountryId = T00026_A1CountryId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
            n1CountryId = T00026_n1CountryId[0] ;
            if ( ! ( (pr_default.getStatus(4) == 101) ) )
            {
               pr_default.readNext(4);
               if ( ! ( (pr_default.getStatus(4) == 101) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_ambiguousck", new   object[]  {"Country Name"}), 1, "COUNTRYID");
                  AnyError = 1 ;
                  GX_FocusControl = edtCountryId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               n1CountryId = ((0==A1CountryId) ? true : false) ;
            }
            pr_default.close(4);
         }
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "h1CountryId", h1CountryId);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A4CustomerName)) )
         {
            GX_msglist.addItem("No se permiten CLIENTES sin NOMBRE", 1, "");
            AnyError = 1 ;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A5CustomerAddress)) )
         {
            GX_msglist.addItem("No se ingres� DIRECCI�N para el CLIENTE", 1, "");
            AnyError = 1 ;
         }
         A9CustomerBalance = (decimal)(A7CustomerTotalPurchases-A8CustomerTotalPayments) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
         if ( String.IsNullOrEmpty(StringUtil.RTrim( h1CountryId)) )
         {
            A1CountryId = 0 ;
            n1CountryId = false ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
            n1CountryId = ((0==A1CountryId) ? true : false) ;
         }
         else
         {
            A2CountryName = h1CountryId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2CountryName", A2CountryName);
            /* Using cursor T00027 */
            pr_default.execute(5, new Object[] {A2CountryName});
            A1CountryId = T00027_A1CountryId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
            n1CountryId = T00027_n1CountryId[0] ;
            A1CountryId = T00027_A1CountryId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
            n1CountryId = T00027_n1CountryId[0] ;
            if ( ! ( (pr_default.getStatus(5) == 101) ) )
            {
               pr_default.readNext(5);
               if ( ! ( (pr_default.getStatus(5) == 101) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_ambiguousck", new   object[]  {"Country Name"}), 1, "COUNTRYID");
                  AnyError = 1 ;
                  GX_FocusControl = edtCountryId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               n1CountryId = ((0==A1CountryId) ? true : false) ;
            }
            pr_default.close(5);
         }
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "h1CountryId", h1CountryId);
         /* Using cursor T00024 */
         pr_default.execute(2, new Object[] {n1CountryId, A1CountryId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( (0==A1CountryId) && n1CountryId && String.IsNullOrEmpty(StringUtil.RTrim( A2CountryName)) ) )
            {
               GX_msglist.addItem("No matching 'Country'.", "ForeignKeyNotFound", 1, "COUNTRYID");
               AnyError = 1 ;
               GX_FocusControl = edtCountryId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         if ( AnyError == 0 )
         {
            A2CountryName = T00024_A2CountryName[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2CountryName", A2CountryName);
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors022( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
         if ( IsConfirmed == 0 )
         {
            imgBtn_delete2_Enabled = RcdFound2 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
         else
         {
            imgBtn_delete2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
      }

      protected void gxLoad_10( int A1CountryId )
      {
         /* Using cursor T00028 */
         pr_default.execute(6, new Object[] {n1CountryId, A1CountryId});
         if ( (pr_default.getStatus(6) == 101) )
         {
            if ( ! ( (0==A1CountryId) && n1CountryId && String.IsNullOrEmpty(StringUtil.RTrim( A2CountryName)) ) )
            {
               GX_msglist.addItem("No matching 'Country'.", "ForeignKeyNotFound", 1, "COUNTRYID");
               AnyError = 1 ;
               GX_FocusControl = edtCountryId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         if ( AnyError == 0 )
         {
            A2CountryName = T00028_A2CountryName[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2CountryName", A2CountryName);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A2CountryName))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(6);
      }

      protected void GetKey022( )
      {
         /* Using cursor T00029 */
         pr_default.execute(7, new Object[] {A3CustomerId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound2 = 1 ;
         }
         else
         {
            RcdFound2 = 0 ;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00023 */
         pr_default.execute(1, new Object[] {A3CustomerId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM022( 9) ;
            RcdFound2 = 1 ;
            A3CustomerId = T00023_A3CustomerId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3CustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3CustomerId), 6, 0)));
            A4CustomerName = T00023_A4CustomerName[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CustomerName", A4CustomerName);
            A5CustomerAddress = T00023_A5CustomerAddress[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5CustomerAddress", A5CustomerAddress);
            A6CustomerGender = T00023_A6CustomerGender[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6CustomerGender", A6CustomerGender);
            A7CustomerTotalPurchases = T00023_A7CustomerTotalPurchases[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
            A8CustomerTotalPayments = T00023_A8CustomerTotalPayments[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CustomerTotalPayments", StringUtil.LTrim( StringUtil.Str( A8CustomerTotalPayments, 9, 2)));
            A1CountryId = T00023_A1CountryId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
            n1CountryId = T00023_n1CountryId[0] ;
            Z3CustomerId = A3CustomerId ;
            sMode2 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load022( ) ;
            Gx_mode = sMode2 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound2 = 0 ;
            InitializeNonKey022( ) ;
            sMode2 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode2 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey022( ) ;
         if ( RcdFound2 == 0 )
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
         RcdFound2 = 0 ;
         /* Using cursor T000210 */
         pr_default.execute(8, new Object[] {A3CustomerId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000210_A3CustomerId[0] < A3CustomerId ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000210_A3CustomerId[0] > A3CustomerId ) ) )
            {
               A3CustomerId = T000210_A3CustomerId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3CustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3CustomerId), 6, 0)));
               RcdFound2 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound2 = 0 ;
         /* Using cursor T000211 */
         pr_default.execute(9, new Object[] {A3CustomerId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000211_A3CustomerId[0] > A3CustomerId ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000211_A3CustomerId[0] < A3CustomerId ) ) )
            {
               A3CustomerId = T000211_A3CustomerId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3CustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3CustomerId), 6, 0)));
               RcdFound2 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey022( ) ;
         if ( RcdFound2 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "CUSTOMERID");
               AnyError = 1 ;
               GX_FocusControl = edtCustomerId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( A3CustomerId != Z3CustomerId )
            {
               A3CustomerId = Z3CustomerId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3CustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3CustomerId), 6, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "CUSTOMERID");
               AnyError = 1 ;
               GX_FocusControl = edtCustomerId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtCustomerId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               Gx_mode = "UPD" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Update record */
               Update022( ) ;
               GX_FocusControl = edtCustomerId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( A3CustomerId != Z3CustomerId )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtCustomerId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert022( ) ;
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
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "CUSTOMERID");
                  AnyError = 1 ;
                  GX_FocusControl = edtCustomerId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtCustomerId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert022( ) ;
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
         if ( A3CustomerId != Z3CustomerId )
         {
            A3CustomerId = Z3CustomerId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3CustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3CustomerId), 6, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "CUSTOMERID");
            AnyError = 1 ;
            GX_FocusControl = edtCustomerId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtCustomerId_Internalname ;
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
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound"), "PrimaryKeyNotFound", 1, "CUSTOMERID");
            AnyError = 1 ;
         }
         GX_FocusControl = edtCustomerName_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart022( ) ;
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCustomerName_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd022( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCustomerName_Internalname ;
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
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCustomerName_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart022( ) ;
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            while ( RcdFound2 != 0 )
            {
               ScanNext022( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCustomerName_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd022( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency022( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( h1CountryId)) )
            {
               A1CountryId = 0 ;
               n1CountryId = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
               n1CountryId = ((0==A1CountryId) ? true : false) ;
            }
            else
            {
               A2CountryName = h1CountryId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2CountryName", A2CountryName);
               /* Using cursor T000212 */
               pr_default.execute(10, new Object[] {A2CountryName});
               A1CountryId = T000212_A1CountryId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
               n1CountryId = T000212_n1CountryId[0] ;
               A1CountryId = T000212_A1CountryId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
               n1CountryId = T000212_n1CountryId[0] ;
               if ( ! ( (pr_default.getStatus(10) == 101) ) )
               {
                  pr_default.readNext(10);
                  if ( ! ( (pr_default.getStatus(10) == 101) ) )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_ambiguousck", new   object[]  {"Country Name"}), 1, "COUNTRYID");
                     AnyError = 1 ;
                     GX_FocusControl = edtCountryId_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  n1CountryId = ((0==A1CountryId) ? true : false) ;
               }
               pr_default.close(10);
            }
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "h1CountryId", h1CountryId);
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000213 */
            pr_default.execute(11, new Object[] {A3CustomerId});
            if ( (pr_default.getStatus(11) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Customer"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(11) == 101) || ( StringUtil.StrCmp(Z4CustomerName, T000213_A4CustomerName[0]) != 0 ) || ( StringUtil.StrCmp(Z5CustomerAddress, T000213_A5CustomerAddress[0]) != 0 ) || ( StringUtil.StrCmp(Z6CustomerGender, T000213_A6CustomerGender[0]) != 0 ) || ( Z7CustomerTotalPurchases != T000213_A7CustomerTotalPurchases[0] ) || ( Z8CustomerTotalPayments != T000213_A8CustomerTotalPayments[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z1CountryId != T000213_A1CountryId[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Customer"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert022( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable022( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM022( 0) ;
            CheckOptimisticConcurrency022( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm022( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert022( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000214 */
                     pr_default.execute(12, new Object[] {A4CustomerName, A5CustomerAddress, A6CustomerGender, A7CustomerTotalPurchases, A8CustomerTotalPayments, n1CountryId, A1CountryId});
                     pr_default.close(12);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000215 */
                     pr_default.execute(13);
                     A3CustomerId = T000215_A3CustomerId[0] ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3CustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3CustomerId), 6, 0)));
                     pr_default.close(13);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded"), 0, "");
                           ResetCaption020( ) ;
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
               Load022( ) ;
            }
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void Update022( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable022( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency022( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm022( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate022( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000216 */
                     pr_default.execute(14, new Object[] {A4CustomerName, A5CustomerAddress, A6CustomerGender, A7CustomerTotalPurchases, A8CustomerTotalPayments, n1CountryId, A1CountryId, A3CustomerId});
                     pr_default.close(14);
                     if ( (pr_default.getStatus(14) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Customer"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate022( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated"), 0, "");
                           ResetCaption020( ) ;
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
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void DeferredUpdate022( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency022( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls022( ) ;
            AfterConfirm022( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete022( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000217 */
                  pr_default.execute(15, new Object[] {A3CustomerId});
                  pr_default.close(15);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound2 == 0 )
                        {
                           InitAll022( ) ;
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
                        ResetCaption020( ) ;
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
         sMode2 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel022( ) ;
         Gx_mode = sMode2 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls022( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000218 */
            pr_default.execute(16, new Object[] {n1CountryId, A1CountryId});
            A2CountryName = T000218_A2CountryName[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2CountryName", A2CountryName);
            pr_default.close(16);
            A9CustomerBalance = (decimal)(A7CustomerTotalPurchases-A8CustomerTotalPayments) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000219 */
            pr_default.execute(17, new Object[] {A3CustomerId});
            if ( (pr_default.getStatus(17) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Invoice"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(17);
         }
      }

      protected void EndLevel022( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(11);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete022( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(9);
            pr_default.close(8);
            pr_default.close(16);
            context.CommitDataStores("Customer");
            if ( AnyError == 0 )
            {
               ConfirmValues020( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(9);
            pr_default.close(8);
            pr_default.close(16);
            context.RollbackDataStores("Customer");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart022( )
      {
         /* Using cursor T000220 */
         pr_default.execute(18);
         RcdFound2 = 0 ;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound2 = 1 ;
            A3CustomerId = T000220_A3CustomerId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3CustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3CustomerId), 6, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext022( )
      {
         pr_default.readNext(18);
         RcdFound2 = 0 ;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound2 = 1 ;
            A3CustomerId = T000220_A3CustomerId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3CustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3CustomerId), 6, 0)));
         }
      }

      protected void ScanEnd022( )
      {
      }

      protected void AfterConfirm022( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert022( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate022( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete022( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete022( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate022( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes022( )
      {
         edtCustomerId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCustomerId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCustomerId_Enabled), 5, 0)));
         edtCustomerName_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCustomerName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCustomerName_Enabled), 5, 0)));
         edtCustomerAddress_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCustomerAddress_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCustomerAddress_Enabled), 5, 0)));
         radCustomerGender.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, radCustomerGender_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(radCustomerGender.Enabled), 5, 0)));
         edtCustomerTotalPurchases_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCustomerTotalPurchases_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCustomerTotalPurchases_Enabled), 5, 0)));
         edtCustomerTotalPayments_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCustomerTotalPayments_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCustomerTotalPayments_Enabled), 5, 0)));
         edtCustomerBalance_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCustomerBalance_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCustomerBalance_Enabled), 5, 0)));
         edtCountryId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCountryId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCountryId_Enabled), 5, 0)));
         edtCountryName_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCountryName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCountryName_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues020( )
      {
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("customer.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z3CustomerId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z3CustomerId), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z4CustomerName", StringUtil.RTrim( Z4CustomerName));
         GxWebStd.gx_hidden_field( context, "Z5CustomerAddress", StringUtil.RTrim( Z5CustomerAddress));
         GxWebStd.gx_hidden_field( context, "Z6CustomerGender", StringUtil.RTrim( Z6CustomerGender));
         GxWebStd.gx_hidden_field( context, "Z7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.NToC( Z7CustomerTotalPurchases, 9, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z8CustomerTotalPayments", StringUtil.LTrim( StringUtil.NToC( Z8CustomerTotalPayments, 9, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z1CountryId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1CountryId), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXHCCOUNTRYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1CountryId), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
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
         return "Customer" ;
      }

      public override String GetPgmdesc( )
      {
         return "Customer" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("customer.aspx")  ;
      }

      protected void InitializeNonKey022( )
      {
         A9CustomerBalance = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
         A4CustomerName = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CustomerName", A4CustomerName);
         A5CustomerAddress = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5CustomerAddress", A5CustomerAddress);
         A7CustomerTotalPurchases = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
         A8CustomerTotalPayments = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CustomerTotalPayments", StringUtil.LTrim( StringUtil.Str( A8CustomerTotalPayments, 9, 2)));
         A1CountryId = 0 ;
         n1CountryId = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
         n1CountryId = ((0==A1CountryId) ? true : false) ;
         A2CountryName = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2CountryName", A2CountryName);
         h1CountryId = A2CountryName ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "h1CountryId", h1CountryId);
         A6CustomerGender = "F" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6CustomerGender", A6CustomerGender);
      }

      protected void InitAll022( )
      {
         A3CustomerId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3CustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3CustomerId), 6, 0)));
         InitializeNonKey022( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A6CustomerGender = i6CustomerGender ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6CustomerGender", A6CustomerGender);
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "GeneXusX.css", "?1401355");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?15151044");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.eng.js", "?46473");
         context.AddJavascriptSource("customer.js", "?15151044");
         /* End function include_jscripts */
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
         lblTextblockcustomerid_Internalname = "TEXTBLOCKCUSTOMERID" ;
         edtCustomerId_Internalname = "CUSTOMERID" ;
         lblTextblockcustomername_Internalname = "TEXTBLOCKCUSTOMERNAME" ;
         edtCustomerName_Internalname = "CUSTOMERNAME" ;
         lblTextblockcustomeraddress_Internalname = "TEXTBLOCKCUSTOMERADDRESS" ;
         edtCustomerAddress_Internalname = "CUSTOMERADDRESS" ;
         lblTextblockcustomergender_Internalname = "TEXTBLOCKCUSTOMERGENDER" ;
         radCustomerGender_Internalname = "CUSTOMERGENDER" ;
         lblTextblockcustomertotalpurchases_Internalname = "TEXTBLOCKCUSTOMERTOTALPURCHASES" ;
         edtCustomerTotalPurchases_Internalname = "CUSTOMERTOTALPURCHASES" ;
         lblTextblockcustomertotalpayments_Internalname = "TEXTBLOCKCUSTOMERTOTALPAYMENTS" ;
         edtCustomerTotalPayments_Internalname = "CUSTOMERTOTALPAYMENTS" ;
         lblTextblockcustomerbalance_Internalname = "TEXTBLOCKCUSTOMERBALANCE" ;
         edtCustomerBalance_Internalname = "CUSTOMERBALANCE" ;
         lblTextblockcountryid_Internalname = "TEXTBLOCKCOUNTRYID" ;
         edtCountryId_Internalname = "COUNTRYID" ;
         lblTextblockcountryname_Internalname = "TEXTBLOCKCOUNTRYNAME" ;
         edtCountryName_Internalname = "COUNTRYNAME" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Customer" ;
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
         edtCountryName_Jsonclick = "" ;
         edtCountryName_Enabled = 0 ;
         edtCountryId_Jsonclick = "" ;
         edtCountryId_Enabled = 1 ;
         edtCustomerBalance_Jsonclick = "" ;
         edtCustomerBalance_Enabled = 0 ;
         edtCustomerTotalPayments_Jsonclick = "" ;
         edtCustomerTotalPayments_Enabled = 1 ;
         edtCustomerTotalPurchases_Jsonclick = "" ;
         edtCustomerTotalPurchases_Enabled = 0 ;
         radCustomerGender_Jsonclick = "" ;
         radCustomerGender.Enabled = 1 ;
         edtCustomerAddress_Jsonclick = "" ;
         edtCustomerAddress_Enabled = 1 ;
         edtCustomerName_Jsonclick = "" ;
         edtCustomerName_Enabled = 1 ;
         edtCustomerId_Jsonclick = "" ;
         edtCustomerId_Enabled = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXHCACOUNTRYID022( int A1CountryId ,
                                        String A2CountryName )
      {
         /* Using cursor T000221 */
         pr_default.execute(19, new Object[] {A2CountryName});
         gxhchits = 0 ;
         while ( (pr_default.getStatus(19) != 101) )
         {
            gxhchits = (short)(gxhchits+1) ;
            if ( gxhchits > 1 )
            {
               if (true) break;
            }
            A2CountryName = T000221_A2CountryName[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2CountryName", A2CountryName);
            A1CountryId = T000221_A1CountryId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
            n1CountryId = T000221_n1CountryId[0] ;
            pr_default.readNext(19);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A1CountryId), 6, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString(")");
         if ( gxhchits > 1 )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("\"ambiguousck\"");
         }
         if ( gxhchits == 0 )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(19);
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         GX_FocusControl = edtCustomerName_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Customerid( String GX_Parm1 ,
                                    int GX_Parm2 ,
                                    String GX_Parm3 ,
                                    String GX_Parm4 ,
                                    String GX_Parm5 ,
                                    decimal GX_Parm6 ,
                                    decimal GX_Parm7 ,
                                    int GX_Parm8 )
      {
         h1CountryId = GX_Parm1 ;
         A3CustomerId = GX_Parm2 ;
         A4CustomerName = GX_Parm3 ;
         A5CustomerAddress = GX_Parm4 ;
         A6CustomerGender = GX_Parm5 ;
         A7CustomerTotalPurchases = GX_Parm6 ;
         A8CustomerTotalPayments = GX_Parm7 ;
         A1CountryId = GX_Parm8 ;
         n1CountryId = false ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A2CountryName = "" ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A4CustomerName)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A5CustomerAddress)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A6CustomerGender)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A7CustomerTotalPurchases, 9, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A8CustomerTotalPayments, 9, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A1CountryId), 6, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( A9CustomerBalance, 9, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A2CountryName)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z3CustomerId), 6, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z4CustomerName)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z5CustomerAddress)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z6CustomerGender)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z7CustomerTotalPurchases, 9, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z8CustomerTotalPayments, 9, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1CountryId), 6, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( Z9CustomerBalance, 9, 2, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z2CountryName)));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(StringUtil.RTrim( h1CountryId)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Countryid( String GX_Parm1 ,
                                   int GX_Parm2 ,
                                   String GX_Parm3 )
      {
         h1CountryId = GX_Parm1 ;
         A1CountryId = GX_Parm2 ;
         n1CountryId = false ;
         A2CountryName = GX_Parm3 ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( h1CountryId)) )
         {
            A1CountryId = 0 ;
            n1CountryId = false ;
            n1CountryId = ((0==A1CountryId) ? true : false) ;
         }
         else
         {
            A2CountryName = h1CountryId ;
            /* Using cursor T000222 */
            pr_default.execute(20, new Object[] {A2CountryName});
            A1CountryId = T000222_A1CountryId[0] ;
            n1CountryId = T000222_n1CountryId[0] ;
            A1CountryId = T000222_A1CountryId[0] ;
            n1CountryId = T000222_n1CountryId[0] ;
            if ( ! ( (pr_default.getStatus(20) == 101) ) )
            {
               pr_default.readNext(20);
               if ( ! ( (pr_default.getStatus(20) == 101) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_ambiguousck", new   object[]  {"Country Name"}), 1, "COUNTRYID");
                  AnyError = 1 ;
                  GX_FocusControl = edtCountryId_Internalname ;
               }
            }
            else
            {
               n1CountryId = ((0==A1CountryId) ? true : false) ;
            }
            pr_default.close(20);
         }
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "h1CountryId", h1CountryId);
         /* Using cursor T000223 */
         pr_default.execute(21, new Object[] {n1CountryId, A1CountryId});
         if ( (pr_default.getStatus(21) == 101) )
         {
            if ( ! ( (0==A1CountryId) && n1CountryId && String.IsNullOrEmpty(StringUtil.RTrim( A2CountryName)) ) )
            {
               GX_msglist.addItem("No matching 'Country'.", "ForeignKeyNotFound", 1, "COUNTRYID");
               AnyError = 1 ;
               GX_FocusControl = edtCountryId_Internalname ;
            }
         }
         if ( AnyError == 0 )
         {
            A2CountryName = T000223_A2CountryName[0] ;
         }
         pr_default.close(21);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A2CountryName = "" ;
         }
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A1CountryId), 6, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A2CountryName)));
         isValidOutput.Add((Object)(StringUtil.RTrim( h1CountryId)));
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
         pr_default.close(18);
         pr_default.close(9);
         pr_default.close(8);
         pr_default.close(21);
         pr_default.close(16);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         h1CountryId = "" ;
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
         lblTextblockcustomerid_Jsonclick = "" ;
         lblTextblockcustomername_Jsonclick = "" ;
         A4CustomerName = "" ;
         lblTextblockcustomeraddress_Jsonclick = "" ;
         A5CustomerAddress = "" ;
         lblTextblockcustomergender_Jsonclick = "" ;
         A6CustomerGender = "" ;
         lblTextblockcustomertotalpurchases_Jsonclick = "" ;
         lblTextblockcustomertotalpayments_Jsonclick = "" ;
         lblTextblockcustomerbalance_Jsonclick = "" ;
         lblTextblockcountryid_Jsonclick = "" ;
         lblTextblockcountryname_Jsonclick = "" ;
         A2CountryName = "" ;
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
         Z4CustomerName = "" ;
         Z5CustomerAddress = "" ;
         Z6CustomerGender = "" ;
         Gx_mode = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         Z2CountryName = "" ;
         T00025_A3CustomerId = new int[1] ;
         T00025_A4CustomerName = new String[] {""} ;
         T00025_A5CustomerAddress = new String[] {""} ;
         T00025_A6CustomerGender = new String[] {""} ;
         T00025_A7CustomerTotalPurchases = new decimal[1] ;
         T00025_A8CustomerTotalPayments = new decimal[1] ;
         T00025_A2CountryName = new String[] {""} ;
         T00025_A1CountryId = new int[1] ;
         T00025_n1CountryId = new bool[] {false} ;
         T00026_A2CountryName = new String[] {""} ;
         T00026_A1CountryId = new int[1] ;
         T00026_n1CountryId = new bool[] {false} ;
         T00027_A2CountryName = new String[] {""} ;
         T00027_A1CountryId = new int[1] ;
         T00027_n1CountryId = new bool[] {false} ;
         T00024_A2CountryName = new String[] {""} ;
         T00028_A2CountryName = new String[] {""} ;
         T00029_A3CustomerId = new int[1] ;
         T00023_A3CustomerId = new int[1] ;
         T00023_A4CustomerName = new String[] {""} ;
         T00023_A5CustomerAddress = new String[] {""} ;
         T00023_A6CustomerGender = new String[] {""} ;
         T00023_A7CustomerTotalPurchases = new decimal[1] ;
         T00023_A8CustomerTotalPayments = new decimal[1] ;
         T00023_A1CountryId = new int[1] ;
         T00023_n1CountryId = new bool[] {false} ;
         sMode2 = "" ;
         T000210_A3CustomerId = new int[1] ;
         T000211_A3CustomerId = new int[1] ;
         T000212_A2CountryName = new String[] {""} ;
         T000212_A1CountryId = new int[1] ;
         T000212_n1CountryId = new bool[] {false} ;
         T000213_A3CustomerId = new int[1] ;
         T000213_A4CustomerName = new String[] {""} ;
         T000213_A5CustomerAddress = new String[] {""} ;
         T000213_A6CustomerGender = new String[] {""} ;
         T000213_A7CustomerTotalPurchases = new decimal[1] ;
         T000213_A8CustomerTotalPayments = new decimal[1] ;
         T000213_A1CountryId = new int[1] ;
         T000213_n1CountryId = new bool[] {false} ;
         T000215_A3CustomerId = new int[1] ;
         T000218_A2CountryName = new String[] {""} ;
         T000219_A14InvoiceId = new int[1] ;
         T000220_A3CustomerId = new int[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         i6CustomerGender = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         T000221_A2CountryName = new String[] {""} ;
         T000221_A1CountryId = new int[1] ;
         T000221_n1CountryId = new bool[] {false} ;
         GXt_char3 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         T000222_A2CountryName = new String[] {""} ;
         T000222_A1CountryId = new int[1] ;
         T000222_n1CountryId = new bool[] {false} ;
         T000223_A2CountryName = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.customer__default(),
            new Object[][] {
                new Object[] {
               T00022_A3CustomerId, T00022_A4CustomerName, T00022_A5CustomerAddress, T00022_A6CustomerGender, T00022_A7CustomerTotalPurchases, T00022_A8CustomerTotalPayments, T00022_A1CountryId, T00022_n1CountryId
               }
               , new Object[] {
               T00023_A3CustomerId, T00023_A4CustomerName, T00023_A5CustomerAddress, T00023_A6CustomerGender, T00023_A7CustomerTotalPurchases, T00023_A8CustomerTotalPayments, T00023_A1CountryId, T00023_n1CountryId
               }
               , new Object[] {
               T00024_A2CountryName
               }
               , new Object[] {
               T00025_A3CustomerId, T00025_A4CustomerName, T00025_A5CustomerAddress, T00025_A6CustomerGender, T00025_A7CustomerTotalPurchases, T00025_A8CustomerTotalPayments, T00025_A2CountryName, T00025_A1CountryId, T00025_n1CountryId
               }
               , new Object[] {
               T00026_A2CountryName, T00026_A1CountryId
               }
               , new Object[] {
               T00027_A2CountryName, T00027_A1CountryId
               }
               , new Object[] {
               T00028_A2CountryName
               }
               , new Object[] {
               T00029_A3CustomerId
               }
               , new Object[] {
               T000210_A3CustomerId
               }
               , new Object[] {
               T000211_A3CustomerId
               }
               , new Object[] {
               T000212_A2CountryName, T000212_A1CountryId
               }
               , new Object[] {
               T000213_A3CustomerId, T000213_A4CustomerName, T000213_A5CustomerAddress, T000213_A6CustomerGender, T000213_A7CustomerTotalPurchases, T000213_A8CustomerTotalPayments, T000213_A1CountryId, T000213_n1CountryId
               }
               , new Object[] {
               }
               , new Object[] {
               T000215_A3CustomerId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000218_A2CountryName
               }
               , new Object[] {
               T000219_A14InvoiceId
               }
               , new Object[] {
               T000220_A3CustomerId
               }
               , new Object[] {
               T000221_A2CountryName, T000221_A1CountryId
               }
               , new Object[] {
               T000222_A2CountryName, T000222_A1CountryId
               }
               , new Object[] {
               T000223_A2CountryName
               }
            }
         );
         A6CustomerGender = "F" ;
      }

      private short RcdFound2 ;
      private short GxWebError ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short Gx_BScreen ;
      private short GX_JID ;
      private short gxajaxcallmode ;
      private short gxhchits ;
      private int A1CountryId ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int A3CustomerId ;
      private int edtCustomerId_Enabled ;
      private int edtCustomerName_Enabled ;
      private int edtCustomerAddress_Enabled ;
      private int edtCustomerTotalPurchases_Enabled ;
      private int edtCustomerTotalPayments_Enabled ;
      private int edtCustomerBalance_Enabled ;
      private int edtCountryId_Enabled ;
      private int edtCountryName_Enabled ;
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
      private int Z3CustomerId ;
      private int Z1CountryId ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private decimal A7CustomerTotalPurchases ;
      private decimal A8CustomerTotalPayments ;
      private decimal A9CustomerBalance ;
      private decimal Z7CustomerTotalPurchases ;
      private decimal Z8CustomerTotalPayments ;
      private decimal Z9CustomerBalance ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String h1CountryId ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtCustomerId_Internalname ;
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
      private String lblTextblockcustomerid_Internalname ;
      private String lblTextblockcustomerid_Jsonclick ;
      private String edtCustomerId_Jsonclick ;
      private String lblTextblockcustomername_Internalname ;
      private String lblTextblockcustomername_Jsonclick ;
      private String edtCustomerName_Internalname ;
      private String A4CustomerName ;
      private String edtCustomerName_Jsonclick ;
      private String lblTextblockcustomeraddress_Internalname ;
      private String lblTextblockcustomeraddress_Jsonclick ;
      private String edtCustomerAddress_Internalname ;
      private String A5CustomerAddress ;
      private String edtCustomerAddress_Jsonclick ;
      private String lblTextblockcustomergender_Internalname ;
      private String lblTextblockcustomergender_Jsonclick ;
      private String radCustomerGender_Internalname ;
      private String A6CustomerGender ;
      private String radCustomerGender_Jsonclick ;
      private String lblTextblockcustomertotalpurchases_Internalname ;
      private String lblTextblockcustomertotalpurchases_Jsonclick ;
      private String edtCustomerTotalPurchases_Internalname ;
      private String edtCustomerTotalPurchases_Jsonclick ;
      private String lblTextblockcustomertotalpayments_Internalname ;
      private String lblTextblockcustomertotalpayments_Jsonclick ;
      private String edtCustomerTotalPayments_Internalname ;
      private String edtCustomerTotalPayments_Jsonclick ;
      private String lblTextblockcustomerbalance_Internalname ;
      private String lblTextblockcustomerbalance_Jsonclick ;
      private String edtCustomerBalance_Internalname ;
      private String edtCustomerBalance_Jsonclick ;
      private String lblTextblockcountryid_Internalname ;
      private String lblTextblockcountryid_Jsonclick ;
      private String edtCountryId_Internalname ;
      private String edtCountryId_Jsonclick ;
      private String lblTextblockcountryname_Internalname ;
      private String lblTextblockcountryname_Jsonclick ;
      private String edtCountryName_Internalname ;
      private String A2CountryName ;
      private String edtCountryName_Jsonclick ;
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
      private String Z4CustomerName ;
      private String Z5CustomerAddress ;
      private String Z6CustomerGender ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z2CountryName ;
      private String sMode2 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String i6CustomerGender ;
      private String gxwrpcisep ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool n1CountryId ;
      private bool wbErr ;
      private bool Gx_longc ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private GXRadio radCustomerGender ;
      private IDataStoreProvider pr_default ;
      private int[] T00025_A3CustomerId ;
      private String[] T00025_A4CustomerName ;
      private String[] T00025_A5CustomerAddress ;
      private String[] T00025_A6CustomerGender ;
      private decimal[] T00025_A7CustomerTotalPurchases ;
      private decimal[] T00025_A8CustomerTotalPayments ;
      private String[] T00025_A2CountryName ;
      private int[] T00025_A1CountryId ;
      private bool[] T00025_n1CountryId ;
      private String[] T00026_A2CountryName ;
      private int[] T00026_A1CountryId ;
      private bool[] T00026_n1CountryId ;
      private String[] T00027_A2CountryName ;
      private int[] T00027_A1CountryId ;
      private bool[] T00027_n1CountryId ;
      private String[] T00024_A2CountryName ;
      private String[] T00028_A2CountryName ;
      private int[] T00029_A3CustomerId ;
      private int[] T00023_A3CustomerId ;
      private String[] T00023_A4CustomerName ;
      private String[] T00023_A5CustomerAddress ;
      private String[] T00023_A6CustomerGender ;
      private decimal[] T00023_A7CustomerTotalPurchases ;
      private decimal[] T00023_A8CustomerTotalPayments ;
      private int[] T00023_A1CountryId ;
      private bool[] T00023_n1CountryId ;
      private int[] T000210_A3CustomerId ;
      private int[] T000211_A3CustomerId ;
      private String[] T000212_A2CountryName ;
      private int[] T000212_A1CountryId ;
      private bool[] T000212_n1CountryId ;
      private int[] T000213_A3CustomerId ;
      private String[] T000213_A4CustomerName ;
      private String[] T000213_A5CustomerAddress ;
      private String[] T000213_A6CustomerGender ;
      private decimal[] T000213_A7CustomerTotalPurchases ;
      private decimal[] T000213_A8CustomerTotalPayments ;
      private int[] T000213_A1CountryId ;
      private bool[] T000213_n1CountryId ;
      private int[] T000215_A3CustomerId ;
      private String[] T000218_A2CountryName ;
      private int[] T000219_A14InvoiceId ;
      private int[] T000220_A3CustomerId ;
      private String[] T000221_A2CountryName ;
      private int[] T000221_A1CountryId ;
      private bool[] T000221_n1CountryId ;
      private String[] T000222_A2CountryName ;
      private int[] T000222_A1CountryId ;
      private bool[] T000222_n1CountryId ;
      private String[] T000223_A2CountryName ;
      private int[] T00022_A3CustomerId ;
      private String[] T00022_A4CustomerName ;
      private String[] T00022_A5CustomerAddress ;
      private String[] T00022_A6CustomerGender ;
      private decimal[] T00022_A7CustomerTotalPurchases ;
      private decimal[] T00022_A8CustomerTotalPayments ;
      private int[] T00022_A1CountryId ;
      private bool[] T00022_n1CountryId ;
      private GXWebForm Form ;
   }

   public class customer__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new UpdateCursor(def[14])
         ,new UpdateCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00022 ;
          prmT00022 = new Object[] {
          new Object[] {"@CustomerId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT00025 ;
          prmT00025 = new Object[] {
          new Object[] {"@CustomerId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT00026 ;
          prmT00026 = new Object[] {
          new Object[] {"@CountryName",SqlDbType.Char,30,0}
          } ;
          Object[] prmT00027 ;
          prmT00027 = new Object[] {
          new Object[] {"@CountryName",SqlDbType.Char,30,0}
          } ;
          Object[] prmT00024 ;
          prmT00024 = new Object[] {
          new Object[] {"@CountryId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT00028 ;
          prmT00028 = new Object[] {
          new Object[] {"@CountryId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT00029 ;
          prmT00029 = new Object[] {
          new Object[] {"@CustomerId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT00023 ;
          prmT00023 = new Object[] {
          new Object[] {"@CustomerId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000210 ;
          prmT000210 = new Object[] {
          new Object[] {"@CustomerId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000211 ;
          prmT000211 = new Object[] {
          new Object[] {"@CustomerId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000212 ;
          prmT000212 = new Object[] {
          new Object[] {"@CountryName",SqlDbType.Char,30,0}
          } ;
          Object[] prmT000213 ;
          prmT000213 = new Object[] {
          new Object[] {"@CustomerId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000214 ;
          prmT000214 = new Object[] {
          new Object[] {"@CustomerName",SqlDbType.Char,30,0} ,
          new Object[] {"@CustomerAddress",SqlDbType.Char,30,0} ,
          new Object[] {"@CustomerGender",SqlDbType.Char,1,0} ,
          new Object[] {"@CustomerTotalPurchases",SqlDbType.Decimal,9,2} ,
          new Object[] {"@CustomerTotalPayments",SqlDbType.Decimal,9,2} ,
          new Object[] {"@CountryId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000215 ;
          prmT000215 = new Object[] {
          } ;
          Object[] prmT000216 ;
          prmT000216 = new Object[] {
          new Object[] {"@CustomerName",SqlDbType.Char,30,0} ,
          new Object[] {"@CustomerAddress",SqlDbType.Char,30,0} ,
          new Object[] {"@CustomerGender",SqlDbType.Char,1,0} ,
          new Object[] {"@CustomerTotalPurchases",SqlDbType.Decimal,9,2} ,
          new Object[] {"@CustomerTotalPayments",SqlDbType.Decimal,9,2} ,
          new Object[] {"@CountryId",SqlDbType.Int,6,0} ,
          new Object[] {"@CustomerId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000217 ;
          prmT000217 = new Object[] {
          new Object[] {"@CustomerId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000218 ;
          prmT000218 = new Object[] {
          new Object[] {"@CountryId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000219 ;
          prmT000219 = new Object[] {
          new Object[] {"@CustomerId",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000220 ;
          prmT000220 = new Object[] {
          } ;
          Object[] prmT000221 ;
          prmT000221 = new Object[] {
          new Object[] {"@CountryName",SqlDbType.Char,30,0}
          } ;
          Object[] prmT000222 ;
          prmT000222 = new Object[] {
          new Object[] {"@CountryName",SqlDbType.Char,30,0}
          } ;
          Object[] prmT000223 ;
          prmT000223 = new Object[] {
          new Object[] {"@CountryId",SqlDbType.Int,6,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00022", "SELECT [CustomerId], [CustomerName], [CustomerAddress], [CustomerGender], [CustomerTotalPurchases], [CustomerTotalPayments], [CountryId] FROM [Customer] WITH (UPDLOCK) WHERE [CustomerId] = @CustomerId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00022,1,0,true,false )
             ,new CursorDef("T00023", "SELECT [CustomerId], [CustomerName], [CustomerAddress], [CustomerGender], [CustomerTotalPurchases], [CustomerTotalPayments], [CountryId] FROM [Customer] WITH (NOLOCK) WHERE [CustomerId] = @CustomerId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00023,1,0,true,false )
             ,new CursorDef("T00024", "SELECT [CountryName] FROM [Country] WITH (NOLOCK) WHERE [CountryId] = @CountryId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00024,1,0,true,false )
             ,new CursorDef("T00025", "SELECT TM1.[CustomerId], TM1.[CustomerName], TM1.[CustomerAddress], TM1.[CustomerGender], TM1.[CustomerTotalPurchases], TM1.[CustomerTotalPayments], T2.[CountryName], TM1.[CountryId] FROM ([Customer] TM1 WITH (NOLOCK) LEFT JOIN [Country] T2 WITH (NOLOCK) ON T2.[CountryId] = TM1.[CountryId]) WHERE TM1.[CustomerId] = @CustomerId ORDER BY TM1.[CustomerId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00025,100,0,true,false )
             ,new CursorDef("T00026", "SELECT [CountryName], [CountryId] FROM [Country] WITH (NOLOCK) WHERE [CountryName] = @CountryName  OPTION (FAST 0)",true, GxErrorMask.GX_NOMASK, false, this,prmT00026,0,0,true,false )
             ,new CursorDef("T00027", "SELECT [CountryName], [CountryId] FROM [Country] WITH (NOLOCK) WHERE [CountryName] = @CountryName  OPTION (FAST 0)",true, GxErrorMask.GX_NOMASK, false, this,prmT00027,0,0,true,false )
             ,new CursorDef("T00028", "SELECT [CountryName] FROM [Country] WITH (NOLOCK) WHERE [CountryId] = @CountryId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00028,1,0,true,false )
             ,new CursorDef("T00029", "SELECT [CustomerId] FROM [Customer] WITH (NOLOCK) WHERE [CustomerId] = @CustomerId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00029,1,0,true,false )
             ,new CursorDef("T000210", "SELECT TOP 1 [CustomerId] FROM [Customer] WITH (NOLOCK) WHERE ( [CustomerId] > @CustomerId) ORDER BY [CustomerId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000210,1,0,true,true )
             ,new CursorDef("T000211", "SELECT TOP 1 [CustomerId] FROM [Customer] WITH (NOLOCK) WHERE ( [CustomerId] < @CustomerId) ORDER BY [CustomerId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000211,1,0,true,true )
             ,new CursorDef("T000212", "SELECT [CountryName], [CountryId] FROM [Country] WITH (NOLOCK) WHERE [CountryName] = @CountryName  OPTION (FAST 0)",true, GxErrorMask.GX_NOMASK, false, this,prmT000212,0,0,true,false )
             ,new CursorDef("T000213", "SELECT [CustomerId], [CustomerName], [CustomerAddress], [CustomerGender], [CustomerTotalPurchases], [CustomerTotalPayments], [CountryId] FROM [Customer] WITH (UPDLOCK) WHERE [CustomerId] = @CustomerId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000213,1,0,true,false )
             ,new CursorDef("T000214", "INSERT INTO [Customer] ([CustomerName], [CustomerAddress], [CustomerGender], [CustomerTotalPurchases], [CustomerTotalPayments], [CountryId]) VALUES (@CustomerName, @CustomerAddress, @CustomerGender, @CustomerTotalPurchases, @CustomerTotalPayments, @CountryId)", GxErrorMask.GX_NOMASK,prmT000214)
             ,new CursorDef("T000215", "SELECT Ident_Current('[Customer]') ",true, GxErrorMask.GX_NOMASK, false, this,prmT000215,1,0,true,false )
             ,new CursorDef("T000216", "UPDATE [Customer] SET [CustomerName]=@CustomerName, [CustomerAddress]=@CustomerAddress, [CustomerGender]=@CustomerGender, [CustomerTotalPurchases]=@CustomerTotalPurchases, [CustomerTotalPayments]=@CustomerTotalPayments, [CountryId]=@CountryId  WHERE [CustomerId] = @CustomerId", GxErrorMask.GX_NOMASK,prmT000216)
             ,new CursorDef("T000217", "DELETE FROM [Customer]  WHERE [CustomerId] = @CustomerId", GxErrorMask.GX_NOMASK,prmT000217)
             ,new CursorDef("T000218", "SELECT [CountryName] FROM [Country] WITH (NOLOCK) WHERE [CountryId] = @CountryId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000218,1,0,true,false )
             ,new CursorDef("T000219", "SELECT TOP 1 [InvoiceId] FROM [Invoice] WITH (NOLOCK) WHERE [CustomerId] = @CustomerId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000219,1,0,true,true )
             ,new CursorDef("T000220", "SELECT [CustomerId] FROM [Customer] WITH (NOLOCK) ORDER BY [CustomerId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000220,100,0,true,false )
             ,new CursorDef("T000221", "SELECT [CountryName], [CountryId] FROM [Country] WITH (NOLOCK) WHERE [CountryName] = @CountryName ",true, GxErrorMask.GX_NOMASK, false, this,prmT000221,0,0,true,false )
             ,new CursorDef("T000222", "SELECT [CountryName], [CountryId] FROM [Country] WITH (NOLOCK) WHERE [CountryName] = @CountryName  OPTION (FAST 0)",true, GxErrorMask.GX_NOMASK, false, this,prmT000222,0,0,true,false )
             ,new CursorDef("T000223", "SELECT [CountryName] FROM [Country] WITH (NOLOCK) WHERE [CountryId] = @CountryId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000223,1,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 30) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 30) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 30) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 30) ;
                ((int[]) buf[7])[0] = rslt.getInt(8) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(8);
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                break;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 8 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 9 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 11 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 30) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                break;
             case 13 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                break;
             case 17 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 18 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
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
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 2 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 6 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
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
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 11 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 6 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(6, (int)parms[6]);
                }
                break;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 6 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(6, (int)parms[6]);
                }
                stmt.SetParameter(7, (int)parms[7]);
                break;
             case 15 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 16 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
             case 17 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 19 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 20 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 21 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Int );
                }
                else
                {
                   stmt.SetParameter(1, (int)parms[1]);
                }
                break;
       }
    }

 }

}
