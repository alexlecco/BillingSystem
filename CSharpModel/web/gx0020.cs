/*
               File: Gx0020
        Description: Selection List Customer
             Author: GeneXus C# Generator version 10_1_6-46473
       Generated on: 11/30/2016 15:25:59.98
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
   public class gx0020 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0020( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("GeneXusX");
      }

      public gx0020( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out int aP0_pCustomerId )
      {
         this.AV13pCustomerId = 0 ;
         executePrivate();
         aP0_pCustomerId=this.AV13pCustomerId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         radavCcustomergender = new GXRadio();
         radCustomerGender = new GXRadio();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_Grid1 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               nGXsfl_51_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_51_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_51_idx, sGXsfl_51_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               radavCcustomergender.Name = "vCCUSTOMERGENDER" ;
               radavCcustomergender.WebTags = "" ;
               radavCcustomergender.addItem("M", "Male", 0);
               radavCcustomergender.addItem("F", "Female", 0);
               GXCCtl = "CUSTOMERGENDER_" + sGXsfl_51_idx ;
               radCustomerGender.Name = GXCCtl ;
               radCustomerGender.WebTags = "" ;
               radCustomerGender.addItem("M", "Male", 0);
               radCustomerGender.addItem("F", "Female", 0);
               Grid1_PageSize51 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cCustomerId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cCustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cCustomerId), 6, 0)));
               AV7cCustomerName = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cCustomerName", AV7cCustomerName);
               AV8cCustomerAddress = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cCustomerAddress", AV8cCustomerAddress);
               AV9cCustomerGender = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCustomerGender", AV9cCustomerGender);
               AV10cCustomerTotalPurchases = NumberUtil.Val( GetNextPar( ), ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cCustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( AV10cCustomerTotalPurchases, 9, 2)));
               AV11cCustomerTotalPayments = NumberUtil.Val( GetNextPar( ), ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cCustomerTotalPayments", StringUtil.LTrim( StringUtil.Str( AV11cCustomerTotalPayments, 9, 2)));
               AV12cCustomerBalance = NumberUtil.Val( GetNextPar( ), ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cCustomerBalance", StringUtil.LTrim( StringUtil.Str( AV12cCustomerBalance, 9, 2)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize51, AV6cCustomerId, AV7cCustomerName, AV8cCustomerAddress, AV9cCustomerGender, AV10cCustomerTotalPurchases, AV11cCustomerTotalPayments, AV12cCustomerBalance) ;
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
            if ( ! entryPointCalled )
            {
               AV13pCustomerId = (int)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pCustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pCustomerId), 6, 0)));
            }
         }
         context.SetTheme("GeneXusX");
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("promptmasterpage", "GeneXus.Programs.promptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,true);
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

      public override short ExecuteStartEvent( )
      {
         PA052( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START052( ) ;
         }
         return gxajaxcallmode ;
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
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx0020.aspx") + "?" + UrlEncode("" +AV13pCustomerId)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCCUSTOMERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cCustomerId), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCUSTOMERNAME", StringUtil.RTrim( AV7cCustomerName));
         GxWebStd.gx_hidden_field( context, "GXH_vCCUSTOMERADDRESS", StringUtil.RTrim( AV8cCustomerAddress));
         GxWebStd.gx_hidden_field( context, "GXH_vCCUSTOMERGENDER", StringUtil.RTrim( AV9cCustomerGender));
         GxWebStd.gx_hidden_field( context, "GXH_vCCUSTOMERTOTALPURCHASES", StringUtil.LTrim( StringUtil.NToC( AV10cCustomerTotalPurchases, 9, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCUSTOMERTOTALPAYMENTS", StringUtil.LTrim( StringUtil.NToC( AV11cCustomerTotalPayments, 9, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCUSTOMERBALANCE", StringUtil.LTrim( StringUtil.NToC( AV12cCustomerBalance, 9, 2, ".", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPCUSTOMERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pCustomerId), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE052( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT052( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx0020" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Customer" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx0020.aspx") + "?" + UrlEncode("" +AV13pCustomerId) ;
      }

      protected void WB050( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            wb_table1_2_052( true) ;
         }
         else
         {
            wb_table1_2_052( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_052e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START052( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_6-46473", 0) ;
         Form.Meta.addItem("Description", "Selection List Customer", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP050( ) ;
      }

      protected void WS052( )
      {
         START052( ) ;
         EVT052( ) ;
      }

      protected void EVT052( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName") ;
               EvtGridId = cgiGet( "_EventGridId") ;
               EvtRowId = cgiGet( "_EventRowId") ;
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1) ;
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                  /* Check if conditions changed and reset current page numbers */
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCUSTOMERID"), ".", ",") != Convert.ToDecimal( AV6cCustomerId )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCCUSTOMERNAME"), AV7cCustomerName) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCCUSTOMERADDRESS"), AV8cCustomerAddress) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCCUSTOMERGENDER"), AV9cCustomerGender) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToN( cgiGet( "GXH_vCCUSTOMERTOTALPURCHASES"), ".", ",") != AV10cCustomerTotalPurchases )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToN( cgiGet( "GXH_vCCUSTOMERTOTALPAYMENTS"), ".", ",") != AV11cCustomerTotalPayments )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToN( cgiGet( "GXH_vCCUSTOMERBALANCE"), ".", ",") != AV12cCustomerBalance )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1) ;
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                           {
                              context.wbHandled = 1 ;
                              sEvt = cgiGet( "GRID1PAGING") ;
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid1_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid1_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid1_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid1_lastpage( ) ;
                              }
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                           {
                              nGXsfl_51_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
                              edtCustomerId_Internalname = "CUSTOMERID_"+sGXsfl_51_idx ;
                              edtCustomerName_Internalname = "CUSTOMERNAME_"+sGXsfl_51_idx ;
                              edtCustomerAddress_Internalname = "CUSTOMERADDRESS_"+sGXsfl_51_idx ;
                              radCustomerGender_Internalname = "CUSTOMERGENDER_"+sGXsfl_51_idx ;
                              edtCustomerTotalPurchases_Internalname = "CUSTOMERTOTALPURCHASES_"+sGXsfl_51_idx ;
                              edtCountryId_Internalname = "COUNTRYID_"+sGXsfl_51_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
                              A3CustomerId = (int)(context.localUtil.CToN( cgiGet( edtCustomerId_Internalname), ".", ",")) ;
                              n3CustomerId = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3CustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3CustomerId), 6, 0)));
                              A4CustomerName = cgiGet( edtCustomerName_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CustomerName", A4CustomerName);
                              A5CustomerAddress = cgiGet( edtCustomerAddress_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5CustomerAddress", A5CustomerAddress);
                              A6CustomerGender = cgiGet( radCustomerGender_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6CustomerGender", A6CustomerGender);
                              A7CustomerTotalPurchases = context.localUtil.CToN( cgiGet( edtCustomerTotalPurchases_Internalname), ".", ",") ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
                              A1CountryId = (int)(context.localUtil.CToN( cgiGet( edtCountryId_Internalname), ".", ",")) ;
                              n1CountryId = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E11052 */
                                    E11052 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E12052 */
                                    E12052 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Ccustomerid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCUSTOMERID"), ".", ",") != Convert.ToDecimal( AV6cCustomerId )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ccustomername Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCCUSTOMERNAME"), AV7cCustomerName) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ccustomeraddress Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCCUSTOMERADDRESS"), AV8cCustomerAddress) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ccustomergender Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCCUSTOMERGENDER"), AV9cCustomerGender) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ccustomertotalpurchases Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCCUSTOMERTOTALPURCHASES"), ".", ",") != AV10cCustomerTotalPurchases )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ccustomertotalpayments Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCCUSTOMERTOTALPAYMENTS"), ".", ",") != AV11cCustomerTotalPayments )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ccustomerbalance Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCCUSTOMERBALANCE"), ".", ",") != AV12cCustomerBalance )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E13052 */
                                          E13052 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE052( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA052( )
      {
         if ( nDonePA == 0 )
         {
            radavCcustomergender.Name = "vCCUSTOMERGENDER" ;
            radavCcustomergender.WebTags = "" ;
            radavCcustomergender.addItem("M", "Male", 0);
            radavCcustomergender.addItem("F", "Female", 0);
            GXCCtl = "CUSTOMERGENDER_" + sGXsfl_51_idx ;
            radCustomerGender.Name = GXCCtl ;
            radCustomerGender.WebTags = "" ;
            radCustomerGender.addItem("M", "Male", 0);
            radCustomerGender.addItem("F", "Female", 0);
            GX_FocusControl = edtavCcustomerid_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_51_idx ,
                                       String sGXsfl_51_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtCustomerId_Internalname = "CUSTOMERID_"+sGXsfl_51_idx ;
         edtCustomerName_Internalname = "CUSTOMERNAME_"+sGXsfl_51_idx ;
         edtCustomerAddress_Internalname = "CUSTOMERADDRESS_"+sGXsfl_51_idx ;
         radCustomerGender_Internalname = "CUSTOMERGENDER_"+sGXsfl_51_idx ;
         edtCustomerTotalPurchases_Internalname = "CUSTOMERTOTALPURCHASES_"+sGXsfl_51_idx ;
         edtCountryId_Internalname = "COUNTRYID_"+sGXsfl_51_idx ;
         while ( nGXsfl_51_idx <= nRC_Grid1 )
         {
            sendrow_512( ) ;
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtCustomerId_Internalname = "CUSTOMERID_"+sGXsfl_51_idx ;
            edtCustomerName_Internalname = "CUSTOMERNAME_"+sGXsfl_51_idx ;
            edtCustomerAddress_Internalname = "CUSTOMERADDRESS_"+sGXsfl_51_idx ;
            radCustomerGender_Internalname = "CUSTOMERGENDER_"+sGXsfl_51_idx ;
            edtCustomerTotalPurchases_Internalname = "CUSTOMERTOTALPURCHASES_"+sGXsfl_51_idx ;
            edtCountryId_Internalname = "COUNTRYID_"+sGXsfl_51_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize51 ,
                                        int AV6cCustomerId ,
                                        String AV7cCustomerName ,
                                        String AV8cCustomerAddress ,
                                        String AV9cCustomerGender ,
                                        decimal AV10cCustomerTotalPurchases ,
                                        decimal AV11cCustomerTotalPayments ,
                                        decimal AV12cCustomerBalance )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize51) ;
         RF052( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF052( ) ;
         /* End function Refresh */
      }

      protected void RF052( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 51 ;
         nGXsfl_51_idx = 1 ;
         sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtCustomerId_Internalname = "CUSTOMERID_"+sGXsfl_51_idx ;
         edtCustomerName_Internalname = "CUSTOMERNAME_"+sGXsfl_51_idx ;
         edtCustomerAddress_Internalname = "CUSTOMERADDRESS_"+sGXsfl_51_idx ;
         radCustomerGender_Internalname = "CUSTOMERGENDER_"+sGXsfl_51_idx ;
         edtCustomerTotalPurchases_Internalname = "CUSTOMERTOTALPURCHASES_"+sGXsfl_51_idx ;
         edtCountryId_Internalname = "COUNTRYID_"+sGXsfl_51_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtCustomerId_Internalname = "CUSTOMERID_"+sGXsfl_51_idx ;
            edtCustomerName_Internalname = "CUSTOMERNAME_"+sGXsfl_51_idx ;
            edtCustomerAddress_Internalname = "CUSTOMERADDRESS_"+sGXsfl_51_idx ;
            radCustomerGender_Internalname = "CUSTOMERGENDER_"+sGXsfl_51_idx ;
            edtCustomerTotalPurchases_Internalname = "CUSTOMERTOTALPURCHASES_"+sGXsfl_51_idx ;
            edtCountryId_Internalname = "COUNTRYID_"+sGXsfl_51_idx ;
            lV7cCustomerName = StringUtil.PadR( StringUtil.RTrim( AV7cCustomerName), 30, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cCustomerName", AV7cCustomerName);
            lV8cCustomerAddress = StringUtil.PadR( StringUtil.RTrim( AV8cCustomerAddress), 30, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cCustomerAddress", AV8cCustomerAddress);
            lV9cCustomerGender = StringUtil.PadR( StringUtil.RTrim( AV9cCustomerGender), 1, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCustomerGender", AV9cCustomerGender);
            /* Using cursor H00054 */
            pr_default.execute(0, new Object[] {AV6cCustomerId, lV7cCustomerName, lV8cCustomerAddress, lV9cCustomerGender, AV10cCustomerTotalPurchases, AV11cCustomerTotalPayments, AV12cCustomerBalance});
            nGXsfl_51_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A8CustomerTotalPayments = H00054_A8CustomerTotalPayments[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8CustomerTotalPayments", StringUtil.LTrim( StringUtil.Str( A8CustomerTotalPayments, 9, 2)));
               A1CountryId = H00054_A1CountryId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1CountryId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1CountryId), 6, 0)));
               n1CountryId = H00054_n1CountryId[0] ;
               A7CustomerTotalPurchases = H00054_A7CustomerTotalPurchases[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7CustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( A7CustomerTotalPurchases, 9, 2)));
               A6CustomerGender = H00054_A6CustomerGender[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6CustomerGender", A6CustomerGender);
               A5CustomerAddress = H00054_A5CustomerAddress[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5CustomerAddress", A5CustomerAddress);
               A4CustomerName = H00054_A4CustomerName[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4CustomerName", A4CustomerName);
               A3CustomerId = H00054_A3CustomerId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3CustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(A3CustomerId), 6, 0)));
               n3CustomerId = H00054_n3CustomerId[0] ;
               A9CustomerBalance = H00054_A9CustomerBalance[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
               n9CustomerBalance = H00054_n9CustomerBalance[0] ;
               A9CustomerBalance = H00054_A9CustomerBalance[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9CustomerBalance", StringUtil.LTrim( StringUtil.Str( A9CustomerBalance, 9, 2)));
               n9CustomerBalance = H00054_n9CustomerBalance[0] ;
               /* Execute user event: E12052 */
               E12052 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 51 ;
            WB050( ) ;
         }
      }

      protected int subGrid1_Pagecount( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         lV7cCustomerName = StringUtil.PadR( StringUtil.RTrim( AV7cCustomerName), 30, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cCustomerName", AV7cCustomerName);
         lV8cCustomerAddress = StringUtil.PadR( StringUtil.RTrim( AV8cCustomerAddress), 30, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cCustomerAddress", AV8cCustomerAddress);
         lV9cCustomerGender = StringUtil.PadR( StringUtil.RTrim( AV9cCustomerGender), 1, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCustomerGender", AV9cCustomerGender);
         /* Using cursor H00057 */
         pr_default.execute(1, new Object[] {AV6cCustomerId, lV7cCustomerName, lV8cCustomerAddress, lV9cCustomerGender, AV10cCustomerTotalPurchases, AV11cCustomerTotalPayments, AV12cCustomerBalance});
         GRID1_nRecordCount = H00057_AGRID1_nRecordCount[0] ;
         pr_default.close(1);
         return GRID1_nRecordCount ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         if ( 10 > 0 )
         {
            if ( 1 > 0 )
            {
               return (int)(10*1) ;
            }
            else
            {
               return (int)(10) ;
            }
         }
         return (int)(-1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID1_nFirstRecordOnPage/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0 ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ( GRID1_nRecordCount >= subGrid1_Recordsperpage( ) ) && ( GRID1_nEOF == 0 ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( GRID1_nFirstRecordOnPage >= subGrid1_Recordsperpage( ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage-subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( GRID1_nRecordCount > subGrid1_Recordsperpage( ) )
         {
            if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-subGrid1_Recordsperpage( )) ;
            }
            else
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) ;
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return 0 ;
      }

      protected int subgrid1_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID1_nFirstRecordOnPage = (int)(subGrid1_Recordsperpage( )*(nPageNo-1)) ;
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return (int)(0) ;
      }

      protected void STRUP050( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11052 */
         E11052 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCcustomerid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCcustomerid_Internalname), ".", ",") > Convert.ToDecimal( 999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCCUSTOMERID");
               GX_FocusControl = edtavCcustomerid_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV6cCustomerId = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cCustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cCustomerId), 6, 0)));
            }
            else
            {
               AV6cCustomerId = (int)(context.localUtil.CToN( cgiGet( edtavCcustomerid_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cCustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cCustomerId), 6, 0)));
            }
            AV7cCustomerName = cgiGet( edtavCcustomername_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cCustomerName", AV7cCustomerName);
            AV8cCustomerAddress = cgiGet( edtavCcustomeraddress_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cCustomerAddress", AV8cCustomerAddress);
            AV9cCustomerGender = cgiGet( radavCcustomergender_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCustomerGender", AV9cCustomerGender);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCcustomertotalpurchases_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCcustomertotalpurchases_Internalname), ".", ",") > 999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCCUSTOMERTOTALPURCHASES");
               GX_FocusControl = edtavCcustomertotalpurchases_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV10cCustomerTotalPurchases = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cCustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( AV10cCustomerTotalPurchases, 9, 2)));
            }
            else
            {
               AV10cCustomerTotalPurchases = context.localUtil.CToN( cgiGet( edtavCcustomertotalpurchases_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cCustomerTotalPurchases", StringUtil.LTrim( StringUtil.Str( AV10cCustomerTotalPurchases, 9, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCcustomertotalpayments_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCcustomertotalpayments_Internalname), ".", ",") > 999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCCUSTOMERTOTALPAYMENTS");
               GX_FocusControl = edtavCcustomertotalpayments_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV11cCustomerTotalPayments = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cCustomerTotalPayments", StringUtil.LTrim( StringUtil.Str( AV11cCustomerTotalPayments, 9, 2)));
            }
            else
            {
               AV11cCustomerTotalPayments = context.localUtil.CToN( cgiGet( edtavCcustomertotalpayments_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cCustomerTotalPayments", StringUtil.LTrim( StringUtil.Str( AV11cCustomerTotalPayments, 9, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCcustomerbalance_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCcustomerbalance_Internalname), ".", ",") > 999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCCUSTOMERBALANCE");
               GX_FocusControl = edtavCcustomerbalance_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV12cCustomerBalance = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cCustomerBalance", StringUtil.LTrim( StringUtil.Str( AV12cCustomerBalance, 9, 2)));
            }
            else
            {
               AV12cCustomerBalance = context.localUtil.CToN( cgiGet( edtavCcustomerbalance_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cCustomerBalance", StringUtil.LTrim( StringUtil.Str( AV12cCustomerBalance, 9, 2)));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            AV13pCustomerId = (int)(context.localUtil.CToN( cgiGet( "vPCUSTOMERID"), ".", ",")) ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ".", ",")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ".", ",")) ;
            /* Read subfile selected row values. */
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E11052 */
         E11052 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E11052( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Selection List %1", "Customer", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E12052( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "GeneXusX") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_512( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E13052 */
         E13052 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E13052( )
      {
         /* Enter Routine */
         AV13pCustomerId = A3CustomerId ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pCustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pCustomerId), 6, 0)));
         context.setWebReturnParms(new Object[] {(int)AV13pCustomerId});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_052( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroup1_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Filters"+"</legend>") ;
            wb_table2_9_052( true) ;
         }
         else
         {
            wb_table2_9_052( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_052e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroup2_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Selection List"+"</legend>") ;
            wb_table3_48_052( true) ;
         }
         else
         {
            wb_table3_48_052( false) ;
         }
         return  ;
      }

      protected void wb_table3_48_052e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_052e( true) ;
         }
         else
         {
            wb_table1_2_052e( false) ;
         }
      }

      protected void wb_table3_48_052( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\" >") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "Grid", 0, "", "", 1, 0, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0 ;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title" ;
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1 ;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor ;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle" ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title" ;
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Name") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Address") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Gender") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Total Purchases") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Country Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               Grid1Container.AddObjectProperty("GridName", "Grid1");
            }
            else
            {
               Grid1Container.Clear();
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Class", "Grid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5LinkSelection));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A3CustomerId), 6, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A4CustomerName));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtCustomerName_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A5CustomerAddress));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A6CustomerGender));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A7CustomerTotalPurchases, 9, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A1CountryId), 6, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 51 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_51_idx-1) ;
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
               sStyleString = " style=\"display:none;\"" ;
               sStyleString = "" ;
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", (Object)(Grid1Container));
               GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            wb_table4_61_052( true) ;
         }
         else
         {
            wb_table4_61_052( false) ;
         }
         return  ;
      }

      protected void wb_table4_61_052e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_48_052e( true) ;
         }
         else
         {
            wb_table3_48_052e( false) ;
         }
      }

      protected void wb_table4_61_052( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancel", "Cancel", "", StyleString, ClassString, 1, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(51), 3, 0)+","+"null"+");", "", "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_61_052e( true) ;
         }
         else
         {
            wb_table4_61_052e( false) ;
         }
      }

      protected void wb_table2_9_052( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcustomerid_Internalname, 1, 1, 0, "Customer Id", "", "", "", 0, lblTextblockcustomerid_Jsonclick, "", StyleString, ClassString, "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCcustomerid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cCustomerId), 6, 0, ".", "")), "", 6, "chr", 1, "row", 6, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV6cCustomerId), "ZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(14);\"", 0, edtavCcustomerid_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcustomername_Internalname, 1, 1, 0, "Customer Name", "", "", "", 0, lblTextblockcustomername_Jsonclick, "", StyleString, ClassString, "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCcustomername_Internalname, StringUtil.RTrim( AV7cCustomerName), "", 30, "chr", 1, "row", 30, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV7cCustomerName, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(19);\"", 0, edtavCcustomername_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcustomeraddress_Internalname, 1, 1, 0, "Customer Address", "", "", "", 0, lblTextblockcustomeraddress_Jsonclick, "", StyleString, ClassString, "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCcustomeraddress_Internalname, StringUtil.RTrim( AV8cCustomerAddress), "", 30, "chr", 1, "row", 30, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV8cCustomerAddress, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(24);\"", 0, edtavCcustomeraddress_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcustomergender_Internalname, 1, 1, 0, "Customer Gender", "", "", "", 0, lblTextblockcustomergender_Jsonclick, "", StyleString, ClassString, "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Radio button */
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            GxWebStd.gx_radio_ctrl( context, radavCcustomergender, radavCcustomergender_Internalname, AV9cCustomerGender, "", 1, 1, 1, 1, StyleString, ClassString, 0, radavCcustomergender_Jsonclick, "", TempTags+" onclick=\"gx.evt.onchange(this);\" "+" onblur=\""+""+";gx.evt.onblur(29);\"", "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcustomertotalpurchases_Internalname, 1, 1, 0, "Customer Total Purchases", "", "", "", 0, lblTextblockcustomertotalpurchases_Jsonclick, "", StyleString, ClassString, "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCcustomertotalpurchases_Internalname, StringUtil.LTrim( StringUtil.NToC( AV10cCustomerTotalPurchases, 9, 2, ".", "")), "", 9, "chr", 1, "row", 9, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( AV10cCustomerTotalPurchases, "ZZZZZ9.99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(34);\"", 0, edtavCcustomertotalpurchases_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcustomertotalpayments_Internalname, 1, 1, 0, "Customer Total Payments", "", "", "", 0, lblTextblockcustomertotalpayments_Jsonclick, "", StyleString, ClassString, "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCcustomertotalpayments_Internalname, StringUtil.LTrim( StringUtil.NToC( AV11cCustomerTotalPayments, 9, 2, ".", "")), "", 9, "chr", 1, "row", 9, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( AV11cCustomerTotalPayments, "ZZZZZ9.99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(39);\"", 0, edtavCcustomertotalpayments_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcustomerbalance_Internalname, 1, 1, 0, "Customer Balance", "", "", "", 0, lblTextblockcustomerbalance_Jsonclick, "", StyleString, ClassString, "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCcustomerbalance_Internalname, StringUtil.LTrim( StringUtil.NToC( AV12cCustomerBalance, 9, 2, ".", "")), "", 9, "chr", 1, "row", 9, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( AV12cCustomerBalance, "ZZZZZ9.99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(44);\"", 0, edtavCcustomerbalance_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_052e( true) ;
         }
         else
         {
            wb_table2_9_052e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pCustomerId = Convert.ToInt32(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pCustomerId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pCustomerId), 6, 0)));
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         sDynURL = sGXDynURL ;
         nGotPars = (short)(1) ;
         nGXWrapped = (short)(1) ;
         context.SetWrapped(true);
         PA052( ) ;
         WS052( ) ;
         WE052( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "GeneXusX.css", "?1401355");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1526141");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.eng.js", "?46473");
         context.AddJavascriptSource("gx0020.js", "?1526141");
         /* End function include_jscripts */
      }

      protected void sendrow_512( )
      {
         WB050( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_51_idx <= subGrid1_Recordsperpage( ) * 1 ) )
         {
            Grid1Row = GXWebRow.GetNew(context,Grid1Container) ;
            if ( subGrid1_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid1_Backstyle = 0 ;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd" ;
               }
            }
            else if ( subGrid1_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid1_Backstyle = 0 ;
               subGrid1_Backcolor = subGrid1_Allbackcolor ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Uniform" ;
               }
            }
            else if ( subGrid1_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd" ;
               }
               subGrid1_Backcolor = (int)(0xF0F0F0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
            }
            else if ( subGrid1_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               if ( ((int)(nGXsfl_51_idx) % (2)) == 0 )
               {
                  subGrid1_Backcolor = (int)(0x0) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Even" ;
                  }
               }
               else
               {
                  subGrid1_Backcolor = (int)(0xF0F0F0) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Odd" ;
                  }
               }
            }
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+subGrid1_Linesclass+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( ">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A3CustomerId), 6, 0, ".", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)"",(String)AV5LinkSelection,(String)"GeneXusX",(short)-1,(short)1,(String)"",(String)"Select",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(String)edtavLinkselection_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCustomerId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A3CustomerId), 6, 0, ".", "")),(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)6,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A3CustomerId), "ZZZZZ9"),(String)"",(short)0,(String)edtCustomerId_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtCustomerName_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A3CustomerId), 6, 0, ".", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCustomerName_Internalname, "Link", edtCustomerName_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCustomerName_Internalname,StringUtil.RTrim( A4CustomerName),(String)"Select",(short)0,(String)"px",(short)17,(String)"px",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtCustomerName_Link,(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A4CustomerName, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtCustomerName_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCustomerAddress_Internalname,StringUtil.RTrim( A5CustomerAddress),(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)30,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A5CustomerAddress, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtCustomerAddress_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Radio button */
            ClassString = "Attribute" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("radio", 2, isAjaxCallMode( ), new Object[] {(GXRadio)radCustomerGender,(String)radCustomerGender_Internalname,(String)A6CustomerGender,(String)"",(short)-1,(short)0,(short)1,(short)1,(String)StyleString,(String)ClassString,(short)0,(String)radCustomerGender_Jsonclick,(String)"",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCustomerTotalPurchases_Internalname,StringUtil.LTrim( StringUtil.NToC( A7CustomerTotalPurchases, 9, 2, ".", "")),(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A7CustomerTotalPurchases, "ZZZZZ9.99"),(String)"",(short)0,(String)edtCustomerTotalPurchases_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCountryId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A1CountryId), 6, 0, ".", "")),(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)6,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A1CountryId), "ZZZZZ9"),(String)"",(short)0,(String)edtCountryId_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtCustomerId_Internalname = "CUSTOMERID_"+sGXsfl_51_idx ;
            edtCustomerName_Internalname = "CUSTOMERNAME_"+sGXsfl_51_idx ;
            edtCustomerAddress_Internalname = "CUSTOMERADDRESS_"+sGXsfl_51_idx ;
            radCustomerGender_Internalname = "CUSTOMERGENDER_"+sGXsfl_51_idx ;
            edtCustomerTotalPurchases_Internalname = "CUSTOMERTOTALPURCHASES_"+sGXsfl_51_idx ;
            edtCountryId_Internalname = "COUNTRYID_"+sGXsfl_51_idx ;
         }
         /* End function sendrow_512 */
      }

      protected void init_default_properties( )
      {
         lblTextblockcustomerid_Internalname = "TEXTBLOCKCUSTOMERID" ;
         edtavCcustomerid_Internalname = "vCCUSTOMERID" ;
         lblTextblockcustomername_Internalname = "TEXTBLOCKCUSTOMERNAME" ;
         edtavCcustomername_Internalname = "vCCUSTOMERNAME" ;
         lblTextblockcustomeraddress_Internalname = "TEXTBLOCKCUSTOMERADDRESS" ;
         edtavCcustomeraddress_Internalname = "vCCUSTOMERADDRESS" ;
         lblTextblockcustomergender_Internalname = "TEXTBLOCKCUSTOMERGENDER" ;
         radavCcustomergender_Internalname = "vCCUSTOMERGENDER" ;
         lblTextblockcustomertotalpurchases_Internalname = "TEXTBLOCKCUSTOMERTOTALPURCHASES" ;
         edtavCcustomertotalpurchases_Internalname = "vCCUSTOMERTOTALPURCHASES" ;
         lblTextblockcustomertotalpayments_Internalname = "TEXTBLOCKCUSTOMERTOTALPAYMENTS" ;
         edtavCcustomertotalpayments_Internalname = "vCCUSTOMERTOTALPAYMENTS" ;
         lblTextblockcustomerbalance_Internalname = "TEXTBLOCKCUSTOMERBALANCE" ;
         edtavCcustomerbalance_Internalname = "vCCUSTOMERBALANCE" ;
         tblTable2_Internalname = "TABLE2" ;
         grpGroup1_Internalname = "GROUP1" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         tblTable4_Internalname = "TABLE4" ;
         tblTable3_Internalname = "TABLE3" ;
         grpGroup2_Internalname = "GROUP2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtCountryId_Jsonclick = "" ;
         edtCustomerTotalPurchases_Jsonclick = "" ;
         radCustomerGender_Jsonclick = "" ;
         edtCustomerAddress_Jsonclick = "" ;
         edtCustomerName_Jsonclick = "" ;
         edtCustomerId_Jsonclick = "" ;
         edtavCcustomerbalance_Jsonclick = "" ;
         edtavCcustomertotalpayments_Jsonclick = "" ;
         edtavCcustomertotalpurchases_Jsonclick = "" ;
         radavCcustomergender_Jsonclick = "" ;
         edtavCcustomeraddress_Jsonclick = "" ;
         edtavCcustomername_Jsonclick = "" ;
         edtavCcustomerid_Jsonclick = "" ;
         edtCustomerName_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Customer" ;
         context.GX_msglist.DisplayMode = 1 ;
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
      }

      public override void initialize( )
      {
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         GXCCtl = "" ;
         AV7cCustomerName = "" ;
         AV8cCustomerAddress = "" ;
         AV9cCustomerGender = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtavLinkselection_Internalname = "" ;
         edtCustomerId_Internalname = "" ;
         edtCustomerName_Internalname = "" ;
         edtCustomerAddress_Internalname = "" ;
         radCustomerGender_Internalname = "" ;
         edtCustomerTotalPurchases_Internalname = "" ;
         edtCountryId_Internalname = "" ;
         AV5LinkSelection = "" ;
         A4CustomerName = "" ;
         A5CustomerAddress = "" ;
         A6CustomerGender = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV7cCustomerName = "" ;
         lV8cCustomerAddress = "" ;
         lV9cCustomerGender = "" ;
         H00054_A8CustomerTotalPayments = new decimal[1] ;
         H00054_A1CountryId = new int[1] ;
         H00054_n1CountryId = new bool[] {false} ;
         H00054_A7CustomerTotalPurchases = new decimal[1] ;
         H00054_A6CustomerGender = new String[] {""} ;
         H00054_A5CustomerAddress = new String[] {""} ;
         H00054_A4CustomerName = new String[] {""} ;
         H00054_A3CustomerId = new int[1] ;
         H00054_n3CustomerId = new bool[] {false} ;
         H00054_A9CustomerBalance = new decimal[1] ;
         H00054_n9CustomerBalance = new bool[] {false} ;
         H00057_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         GXt_char5 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char7 = "" ;
         GXt_char6 = "" ;
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockcustomerid_Jsonclick = "" ;
         lblTextblockcustomername_Jsonclick = "" ;
         lblTextblockcustomeraddress_Jsonclick = "" ;
         lblTextblockcustomergender_Jsonclick = "" ;
         lblTextblockcustomertotalpurchases_Jsonclick = "" ;
         lblTextblockcustomertotalpayments_Jsonclick = "" ;
         lblTextblockcustomerbalance_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char8 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0020__default(),
            new Object[][] {
                new Object[] {
               H00054_A8CustomerTotalPayments, H00054_A1CountryId, H00054_n1CountryId, H00054_A7CustomerTotalPurchases, H00054_A6CustomerGender, H00054_A5CustomerAddress, H00054_A4CustomerName, H00054_A3CustomerId, H00054_n3CustomerId, H00054_A9CustomerBalance,
               H00054_n9CustomerBalance
               }
               , new Object[] {
               H00057_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_51_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize51 ;
      private int AV6cCustomerId ;
      private int AV13pCustomerId ;
      private int GRID1_nFirstRecordOnPage ;
      private int A3CustomerId ;
      private int A1CountryId ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private decimal AV10cCustomerTotalPurchases ;
      private decimal AV11cCustomerTotalPayments ;
      private decimal AV12cCustomerBalance ;
      private decimal A7CustomerTotalPurchases ;
      private decimal A8CustomerTotalPayments ;
      private decimal A9CustomerBalance ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_51_idx="0001" ;
      private String GXCCtl ;
      private String AV7cCustomerName ;
      private String AV8cCustomerAddress ;
      private String AV9cCustomerGender ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtCustomerId_Internalname ;
      private String edtCustomerName_Internalname ;
      private String edtCustomerAddress_Internalname ;
      private String radCustomerGender_Internalname ;
      private String edtCustomerTotalPurchases_Internalname ;
      private String edtCountryId_Internalname ;
      private String A4CustomerName ;
      private String A5CustomerAddress ;
      private String A6CustomerGender ;
      private String edtavCcustomerid_Internalname ;
      private String scmdbuf ;
      private String lV7cCustomerName ;
      private String lV8cCustomerAddress ;
      private String lV9cCustomerGender ;
      private String edtavCcustomername_Internalname ;
      private String edtavCcustomeraddress_Internalname ;
      private String radavCcustomergender_Internalname ;
      private String edtavCcustomertotalpurchases_Internalname ;
      private String edtavCcustomertotalpayments_Internalname ;
      private String edtavCcustomerbalance_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroup1_Internalname ;
      private String grpGroup2_Internalname ;
      private String tblTable3_Internalname ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char4 ;
      private String GXt_char5 ;
      private String edtavLinkselection_Link ;
      private String edtCustomerName_Link ;
      private String GXt_char7 ;
      private String GXt_char6 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockcustomerid_Internalname ;
      private String lblTextblockcustomerid_Jsonclick ;
      private String edtavCcustomerid_Jsonclick ;
      private String lblTextblockcustomername_Internalname ;
      private String lblTextblockcustomername_Jsonclick ;
      private String edtavCcustomername_Jsonclick ;
      private String lblTextblockcustomeraddress_Internalname ;
      private String lblTextblockcustomeraddress_Jsonclick ;
      private String edtavCcustomeraddress_Jsonclick ;
      private String lblTextblockcustomergender_Internalname ;
      private String lblTextblockcustomergender_Jsonclick ;
      private String radavCcustomergender_Jsonclick ;
      private String lblTextblockcustomertotalpurchases_Internalname ;
      private String lblTextblockcustomertotalpurchases_Jsonclick ;
      private String edtavCcustomertotalpurchases_Jsonclick ;
      private String lblTextblockcustomertotalpayments_Internalname ;
      private String lblTextblockcustomertotalpayments_Jsonclick ;
      private String edtavCcustomertotalpayments_Jsonclick ;
      private String lblTextblockcustomerbalance_Internalname ;
      private String lblTextblockcustomerbalance_Jsonclick ;
      private String edtavCcustomerbalance_Jsonclick ;
      private String ROClassString ;
      private String edtCustomerId_Jsonclick ;
      private String edtCustomerName_Jsonclick ;
      private String edtCustomerAddress_Jsonclick ;
      private String radCustomerGender_Jsonclick ;
      private String edtCustomerTotalPurchases_Jsonclick ;
      private String edtCountryId_Jsonclick ;
      private String GXt_char8 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n3CustomerId ;
      private bool n1CountryId ;
      private bool n9CustomerBalance ;
      private bool returnInSub ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXRadio radavCcustomergender ;
      private GXRadio radCustomerGender ;
      private IDataStoreProvider pr_default ;
      private decimal[] H00054_A8CustomerTotalPayments ;
      private int[] H00054_A1CountryId ;
      private bool[] H00054_n1CountryId ;
      private decimal[] H00054_A7CustomerTotalPurchases ;
      private String[] H00054_A6CustomerGender ;
      private String[] H00054_A5CustomerAddress ;
      private String[] H00054_A4CustomerName ;
      private int[] H00054_A3CustomerId ;
      private bool[] H00054_n3CustomerId ;
      private decimal[] H00054_A9CustomerBalance ;
      private bool[] H00054_n9CustomerBalance ;
      private int[] H00057_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private int aP0_pCustomerId ;
      private GXWebForm Form ;
   }

   public class gx0020__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00054 ;
          prmH00054 = new Object[] {
          new Object[] {"@AV6cCustomerId",SqlDbType.Int,6,0} ,
          new Object[] {"@lV7cCustomerName",SqlDbType.Char,30,0} ,
          new Object[] {"@lV8cCustomerAddress",SqlDbType.Char,30,0} ,
          new Object[] {"@lV9cCustomerGender",SqlDbType.Char,1,0} ,
          new Object[] {"@AV10cCustomerTotalPurchases",SqlDbType.Decimal,9,2} ,
          new Object[] {"@AV11cCustomerTotalPayments",SqlDbType.Decimal,9,2} ,
          new Object[] {"@AV12cCustomerBalance",SqlDbType.Decimal,9,2}
          } ;
          Object[] prmH00057 ;
          prmH00057 = new Object[] {
          new Object[] {"@AV6cCustomerId",SqlDbType.Int,6,0} ,
          new Object[] {"@lV7cCustomerName",SqlDbType.Char,30,0} ,
          new Object[] {"@lV8cCustomerAddress",SqlDbType.Char,30,0} ,
          new Object[] {"@lV9cCustomerGender",SqlDbType.Char,1,0} ,
          new Object[] {"@AV10cCustomerTotalPurchases",SqlDbType.Decimal,9,2} ,
          new Object[] {"@AV11cCustomerTotalPayments",SqlDbType.Decimal,9,2} ,
          new Object[] {"@AV12cCustomerBalance",SqlDbType.Decimal,9,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00054", "SELECT T1.[CustomerTotalPayments], T1.[CountryId], T1.[CustomerTotalPurchases], T1.[CustomerGender], T1.[CustomerAddress], T1.[CustomerName], T1.[CustomerId], COALESCE( T2.[CustomerBalance], 0) AS CustomerBalance FROM ([Customer] T1 WITH (NOLOCK) INNER JOIN (SELECT T4.[CustomerTotalPurchases] - COALESCE( T5.[InvoiceAmount], 0) AS CustomerBalance, T3.[CustomerId] FROM (([Invoice] T3 WITH (NOLOCK) INNER JOIN [Customer] T4 WITH (NOLOCK) ON T4.[CustomerId] = T3.[CustomerId]) LEFT JOIN (SELECT SUM(T7.[ProductPrice] * CAST(T6.[InvoiceDetailQuantiity] AS decimal( 14, 5))) AS InvoiceAmount, T6.[InvoiceId] FROM ([InvoiceDetail] T6 WITH (NOLOCK) INNER JOIN [Product] T7 WITH (NOLOCK) ON T7.[ProductId] = T6.[ProductId]) GROUP BY T6.[InvoiceId] ) T5 ON T5.[InvoiceId] = T3.[InvoiceId]) ) T2 ON T2.[CustomerId] = T1.[CustomerId]) WHERE (T1.[CustomerId] >= @AV6cCustomerId) AND (T1.[CustomerName] like @lV7cCustomerName) AND (T1.[CustomerAddress] like @lV8cCustomerAddress) AND (T1.[CustomerGender] like @lV9cCustomerGender) AND (T1.[CustomerTotalPurchases] >= @AV10cCustomerTotalPurchases) AND (T1.[CustomerTotalPayments] >= @AV11cCustomerTotalPayments) AND (COALESCE( T2.[CustomerBalance], 0) >= @AV12cCustomerBalance) ORDER BY T1.[CustomerId]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00054,11,0,false,false )
             ,new CursorDef("H00057", "SELECT COUNT(*) FROM ([Customer] T1 WITH (NOLOCK) INNER JOIN (SELECT T4.[CustomerTotalPurchases] - COALESCE( T5.[InvoiceAmount], 0) AS CustomerBalance, T3.[CustomerId] FROM (([Invoice] T3 WITH (NOLOCK) INNER JOIN [Customer] T4 WITH (NOLOCK) ON T4.[CustomerId] = T3.[CustomerId]) LEFT JOIN (SELECT SUM(T7.[ProductPrice] * CAST(T6.[InvoiceDetailQuantiity] AS decimal( 14, 5))) AS InvoiceAmount, T6.[InvoiceId] FROM ([InvoiceDetail] T6 WITH (NOLOCK) INNER JOIN [Product] T7 WITH (NOLOCK) ON T7.[ProductId] = T6.[ProductId]) GROUP BY T6.[InvoiceId] ) T5 ON T5.[InvoiceId] = T3.[InvoiceId]) ) T2 ON T2.[CustomerId] = T1.[CustomerId]) WHERE (T1.[CustomerId] >= @AV6cCustomerId) AND (T1.[CustomerName] like @lV7cCustomerName) AND (T1.[CustomerAddress] like @lV8cCustomerAddress) AND (T1.[CustomerGender] like @lV9cCustomerGender) AND (T1.[CustomerTotalPurchases] >= @AV10cCustomerTotalPurchases) AND (T1.[CustomerTotalPayments] >= @AV11cCustomerTotalPayments) AND (COALESCE( T2.[CustomerBalance], 0) >= @AV12cCustomerBalance) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00057,1,0,false,false )
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
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((decimal[]) buf[3])[0] = rslt.getDecimal(3) ;
                ((String[]) buf[4])[0] = rslt.getString(4, 1) ;
                ((String[]) buf[5])[0] = rslt.getString(5, 30) ;
                ((String[]) buf[6])[0] = rslt.getString(6, 30) ;
                ((int[]) buf[7])[0] = rslt.getInt(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((decimal[]) buf[9])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (decimal)parms[5]);
                stmt.SetParameter(7, (decimal)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (decimal)parms[5]);
                stmt.SetParameter(7, (decimal)parms[6]);
                break;
       }
    }

 }

}
