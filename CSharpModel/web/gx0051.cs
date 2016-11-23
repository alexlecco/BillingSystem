/*
               File: Gx0051
        Description: Selection List Detail
             Author: GeneXus C# Generator version 10_1_6-46473
       Generated on: 11/23/2016 17:25:23.32
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
   public class gx0051 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0051( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("GeneXusX");
      }

      public gx0051( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( int aP0_pInvoiceId ,
                           out short aP1_pInvoiceDetailId )
      {
         this.AV10pInvoiceId = aP0_pInvoiceId;
         this.AV11pInvoiceDetailId = 0 ;
         executePrivate();
         aP1_pInvoiceDetailId=this.AV11pInvoiceDetailId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
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
               nGXsfl_36_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_36_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_36_idx, sGXsfl_36_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               Grid1_PageSize36 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cInvoiceDetailId = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cInvoiceDetailId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cInvoiceDetailId), 2, 0)));
               AV7cProductId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cProductId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cProductId), 6, 0)));
               AV8cInvoiceDetailQuantiity = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cInvoiceDetailQuantiity", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cInvoiceDetailQuantiity), 3, 0)));
               AV9cInvoiceDetailAmount = NumberUtil.Val( GetNextPar( ), ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cInvoiceDetailAmount", StringUtil.LTrim( StringUtil.Str( AV9cInvoiceDetailAmount, 9, 2)));
               AV10pInvoiceId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pInvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10pInvoiceId), 6, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize36, AV6cInvoiceDetailId, AV7cProductId, AV8cInvoiceDetailQuantiity, AV9cInvoiceDetailAmount, AV10pInvoiceId) ;
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
               AV10pInvoiceId = (int)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pInvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10pInvoiceId), 6, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV11pInvoiceDetailId = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pInvoiceDetailId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pInvoiceDetailId), 2, 0)));
               }
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
         PA082( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START082( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx0051.aspx") + "?" + UrlEncode("" +AV10pInvoiceId) + "," + UrlEncode("" +AV11pInvoiceDetailId)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCINVOICEDETAILID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cInvoiceDetailId), 2, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPRODUCTID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cProductId), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCINVOICEDETAILQUANTIITY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cInvoiceDetailQuantiity), 3, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCINVOICEDETAILAMOUNT", StringUtil.LTrim( StringUtil.NToC( AV9cInvoiceDetailAmount, 9, 2, ".", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPINVOICEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10pInvoiceId), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPINVOICEDETAILID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11pInvoiceDetailId), 2, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PRODUCTPRICE", StringUtil.LTrim( StringUtil.NToC( A13ProductPrice, 9, 2, ".", "")));
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
            WE082( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT082( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx0051" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Detail" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx0051.aspx") + "?" + UrlEncode("" +AV10pInvoiceId) + "," + UrlEncode("" +AV11pInvoiceDetailId) ;
      }

      protected void WB080( )
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
            wb_table1_2_082( true) ;
         }
         else
         {
            wb_table1_2_082( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_082e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START082( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_6-46473", 0) ;
         Form.Meta.addItem("Description", "Selection List Detail", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP080( ) ;
      }

      protected void WS082( )
      {
         START082( ) ;
         EVT082( ) ;
      }

      protected void EVT082( )
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
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCINVOICEDETAILID"), ".", ",") != Convert.ToDecimal( AV6cInvoiceDetailId )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPRODUCTID"), ".", ",") != Convert.ToDecimal( AV7cProductId )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCINVOICEDETAILQUANTIITY"), ".", ",") != Convert.ToDecimal( AV8cInvoiceDetailQuantiity )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToN( cgiGet( "GXH_vCINVOICEDETAILAMOUNT"), ".", ",") != AV9cInvoiceDetailAmount )
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
                              nGXsfl_36_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
                              edtInvoiceDetailId_Internalname = "INVOICEDETAILID_"+sGXsfl_36_idx ;
                              edtProductId_Internalname = "PRODUCTID_"+sGXsfl_36_idx ;
                              edtInvoiceDetailQuantiity_Internalname = "INVOICEDETAILQUANTIITY_"+sGXsfl_36_idx ;
                              edtInvoiceDetailAmount_Internalname = "INVOICEDETAILAMOUNT_"+sGXsfl_36_idx ;
                              edtInvoiceId_Internalname = "INVOICEID_"+sGXsfl_36_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
                              A17InvoiceDetailId = (short)(context.localUtil.CToN( cgiGet( edtInvoiceDetailId_Internalname), ".", ",")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17InvoiceDetailId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17InvoiceDetailId), 2, 0)));
                              A10ProductId = (int)(context.localUtil.CToN( cgiGet( edtProductId_Internalname), ".", ",")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10ProductId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10ProductId), 6, 0)));
                              A18InvoiceDetailQuantiity = (short)(context.localUtil.CToN( cgiGet( edtInvoiceDetailQuantiity_Internalname), ".", ",")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18InvoiceDetailQuantiity", StringUtil.LTrim( StringUtil.Str( (decimal)(A18InvoiceDetailQuantiity), 3, 0)));
                              A19InvoiceDetailAmount = context.localUtil.CToN( cgiGet( edtInvoiceDetailAmount_Internalname), ".", ",") ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19InvoiceDetailAmount", StringUtil.LTrim( StringUtil.Str( A19InvoiceDetailAmount, 9, 2)));
                              A14InvoiceId = (int)(context.localUtil.CToN( cgiGet( edtInvoiceId_Internalname), ".", ",")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14InvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14InvoiceId), 6, 0)));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E11082 */
                                    E11082 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E12082 */
                                    E12082 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Cinvoicedetailid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCINVOICEDETAILID"), ".", ",") != Convert.ToDecimal( AV6cInvoiceDetailId )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cproductid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPRODUCTID"), ".", ",") != Convert.ToDecimal( AV7cProductId )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cinvoicedetailquantiity Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCINVOICEDETAILQUANTIITY"), ".", ",") != Convert.ToDecimal( AV8cInvoiceDetailQuantiity )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cinvoicedetailamount Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCINVOICEDETAILAMOUNT"), ".", ",") != AV9cInvoiceDetailAmount )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E13082 */
                                          E13082 ();
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

      protected void WE082( )
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

      protected void PA082( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavCinvoicedetailid_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_36_idx ,
                                       String sGXsfl_36_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
         edtInvoiceDetailId_Internalname = "INVOICEDETAILID_"+sGXsfl_36_idx ;
         edtProductId_Internalname = "PRODUCTID_"+sGXsfl_36_idx ;
         edtInvoiceDetailQuantiity_Internalname = "INVOICEDETAILQUANTIITY_"+sGXsfl_36_idx ;
         edtInvoiceDetailAmount_Internalname = "INVOICEDETAILAMOUNT_"+sGXsfl_36_idx ;
         edtInvoiceId_Internalname = "INVOICEID_"+sGXsfl_36_idx ;
         while ( nGXsfl_36_idx <= nRC_Grid1 )
         {
            sendrow_362( ) ;
            nGXsfl_36_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_36_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_36_idx+1)) ;
            sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
            edtInvoiceDetailId_Internalname = "INVOICEDETAILID_"+sGXsfl_36_idx ;
            edtProductId_Internalname = "PRODUCTID_"+sGXsfl_36_idx ;
            edtInvoiceDetailQuantiity_Internalname = "INVOICEDETAILQUANTIITY_"+sGXsfl_36_idx ;
            edtInvoiceDetailAmount_Internalname = "INVOICEDETAILAMOUNT_"+sGXsfl_36_idx ;
            edtInvoiceId_Internalname = "INVOICEID_"+sGXsfl_36_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize36 ,
                                        short AV6cInvoiceDetailId ,
                                        int AV7cProductId ,
                                        short AV8cInvoiceDetailQuantiity ,
                                        decimal AV9cInvoiceDetailAmount ,
                                        int AV10pInvoiceId )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize36) ;
         RF082( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF082( ) ;
         /* End function Refresh */
      }

      protected void RF082( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 36 ;
         nGXsfl_36_idx = 1 ;
         sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
         edtInvoiceDetailId_Internalname = "INVOICEDETAILID_"+sGXsfl_36_idx ;
         edtProductId_Internalname = "PRODUCTID_"+sGXsfl_36_idx ;
         edtInvoiceDetailQuantiity_Internalname = "INVOICEDETAILQUANTIITY_"+sGXsfl_36_idx ;
         edtInvoiceDetailAmount_Internalname = "INVOICEDETAILAMOUNT_"+sGXsfl_36_idx ;
         edtInvoiceId_Internalname = "INVOICEID_"+sGXsfl_36_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
            edtInvoiceDetailId_Internalname = "INVOICEDETAILID_"+sGXsfl_36_idx ;
            edtProductId_Internalname = "PRODUCTID_"+sGXsfl_36_idx ;
            edtInvoiceDetailQuantiity_Internalname = "INVOICEDETAILQUANTIITY_"+sGXsfl_36_idx ;
            edtInvoiceDetailAmount_Internalname = "INVOICEDETAILAMOUNT_"+sGXsfl_36_idx ;
            edtInvoiceId_Internalname = "INVOICEID_"+sGXsfl_36_idx ;
            /* Using cursor H00082 */
            pr_default.execute(0, new Object[] {AV10pInvoiceId, AV6cInvoiceDetailId, AV7cProductId, AV8cInvoiceDetailQuantiity, AV9cInvoiceDetailAmount});
            nGXsfl_36_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A14InvoiceId = H00082_A14InvoiceId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14InvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(A14InvoiceId), 6, 0)));
               A10ProductId = H00082_A10ProductId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10ProductId", StringUtil.LTrim( StringUtil.Str( (decimal)(A10ProductId), 6, 0)));
               A17InvoiceDetailId = H00082_A17InvoiceDetailId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17InvoiceDetailId", StringUtil.LTrim( StringUtil.Str( (decimal)(A17InvoiceDetailId), 2, 0)));
               A13ProductPrice = H00082_A13ProductPrice[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ProductPrice", StringUtil.LTrim( StringUtil.Str( A13ProductPrice, 9, 2)));
               A18InvoiceDetailQuantiity = H00082_A18InvoiceDetailQuantiity[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18InvoiceDetailQuantiity", StringUtil.LTrim( StringUtil.Str( (decimal)(A18InvoiceDetailQuantiity), 3, 0)));
               A13ProductPrice = H00082_A13ProductPrice[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13ProductPrice", StringUtil.LTrim( StringUtil.Str( A13ProductPrice, 9, 2)));
               A19InvoiceDetailAmount = (decimal)(A13ProductPrice*A18InvoiceDetailQuantiity) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19InvoiceDetailAmount", StringUtil.LTrim( StringUtil.Str( A19InvoiceDetailAmount, 9, 2)));
               /* Execute user event: E12082 */
               E12082 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 36 ;
            WB080( ) ;
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
         /* Using cursor H00083 */
         pr_default.execute(1, new Object[] {AV10pInvoiceId, AV6cInvoiceDetailId, AV7cProductId, AV8cInvoiceDetailQuantiity, AV9cInvoiceDetailAmount});
         GRID1_nRecordCount = H00083_AGRID1_nRecordCount[0] ;
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

      protected void STRUP080( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11082 */
         E11082 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCinvoicedetailid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCinvoicedetailid_Internalname), ".", ",") > Convert.ToDecimal( 99 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCINVOICEDETAILID");
               GX_FocusControl = edtavCinvoicedetailid_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV6cInvoiceDetailId = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cInvoiceDetailId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cInvoiceDetailId), 2, 0)));
            }
            else
            {
               AV6cInvoiceDetailId = (short)(context.localUtil.CToN( cgiGet( edtavCinvoicedetailid_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cInvoiceDetailId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cInvoiceDetailId), 2, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCproductid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCproductid_Internalname), ".", ",") > Convert.ToDecimal( 999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCPRODUCTID");
               GX_FocusControl = edtavCproductid_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV7cProductId = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cProductId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cProductId), 6, 0)));
            }
            else
            {
               AV7cProductId = (int)(context.localUtil.CToN( cgiGet( edtavCproductid_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cProductId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cProductId), 6, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCinvoicedetailquantiity_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCinvoicedetailquantiity_Internalname), ".", ",") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCINVOICEDETAILQUANTIITY");
               GX_FocusControl = edtavCinvoicedetailquantiity_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8cInvoiceDetailQuantiity = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cInvoiceDetailQuantiity", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cInvoiceDetailQuantiity), 3, 0)));
            }
            else
            {
               AV8cInvoiceDetailQuantiity = (short)(context.localUtil.CToN( cgiGet( edtavCinvoicedetailquantiity_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cInvoiceDetailQuantiity", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cInvoiceDetailQuantiity), 3, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCinvoicedetailamount_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCinvoicedetailamount_Internalname), ".", ",") > 999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCINVOICEDETAILAMOUNT");
               GX_FocusControl = edtavCinvoicedetailamount_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV9cInvoiceDetailAmount = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cInvoiceDetailAmount", StringUtil.LTrim( StringUtil.Str( AV9cInvoiceDetailAmount, 9, 2)));
            }
            else
            {
               AV9cInvoiceDetailAmount = context.localUtil.CToN( cgiGet( edtavCinvoicedetailamount_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cInvoiceDetailAmount", StringUtil.LTrim( StringUtil.Str( AV9cInvoiceDetailAmount, 9, 2)));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            AV10pInvoiceId = (int)(context.localUtil.CToN( cgiGet( "vPINVOICEID"), ".", ",")) ;
            AV11pInvoiceDetailId = (short)(context.localUtil.CToN( cgiGet( "vPINVOICEDETAILID"), ".", ",")) ;
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
         /* Execute user event: E11082 */
         E11082 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E11082( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Selection List %1", "Detail", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E12082( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "GeneXusX") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_362( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E13082 */
         E13082 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E13082( )
      {
         /* Enter Routine */
         AV11pInvoiceDetailId = A17InvoiceDetailId ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pInvoiceDetailId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pInvoiceDetailId), 2, 0)));
         context.setWebReturnParms(new Object[] {(short)AV11pInvoiceDetailId});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_082( bool wbgen )
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
            wb_table2_9_082( true) ;
         }
         else
         {
            wb_table2_9_082( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_082e( bool wbgen )
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
            wb_table3_33_082( true) ;
         }
         else
         {
            wb_table3_33_082( false) ;
         }
         return  ;
      }

      protected void wb_table3_33_082e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_082e( true) ;
         }
         else
         {
            wb_table1_2_082e( false) ;
         }
      }

      protected void wb_table3_33_082( bool wbgen )
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
               context.SendWebValue( "Identifier") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Product Identifier") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Detail Quantiity") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Detail Amount") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Invoice Id") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A17InvoiceDetailId), 2, 0, ".", "")));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtInvoiceDetailId_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A10ProductId), 6, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A18InvoiceDetailQuantiity), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A19InvoiceDetailAmount, 9, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A14InvoiceId), 6, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 36 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_36_idx-1) ;
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
            wb_table4_45_082( true) ;
         }
         else
         {
            wb_table4_45_082( false) ;
         }
         return  ;
      }

      protected void wb_table4_45_082e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_33_082e( true) ;
         }
         else
         {
            wb_table3_33_082e( false) ;
         }
      }

      protected void wb_table4_45_082( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancel", "Cancel", "", StyleString, ClassString, 1, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(36), 3, 0)+","+"null"+");", "", "HLP_Gx0051.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_45_082e( true) ;
         }
         else
         {
            wb_table4_45_082e( false) ;
         }
      }

      protected void wb_table2_9_082( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockinvoicedetailid_Internalname, 1, 1, 0, "Detail Identifier", "", "", "", 0, lblTextblockinvoicedetailid_Jsonclick, "", StyleString, ClassString, "HLP_Gx0051.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCinvoicedetailid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cInvoiceDetailId), 2, 0, ".", "")), "", 2, "chr", 1, "row", 2, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV6cInvoiceDetailId), "Z9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(14);\"", 0, edtavCinvoicedetailid_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0051.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockproductid_Internalname, 1, 1, 0, "Product Identifier", "", "", "", 0, lblTextblockproductid_Jsonclick, "", StyleString, ClassString, "HLP_Gx0051.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCproductid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cProductId), 6, 0, ".", "")), "", 6, "chr", 1, "row", 6, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV7cProductId), "ZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(19);\"", 0, edtavCproductid_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0051.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockinvoicedetailquantiity_Internalname, 1, 1, 0, "Invoice Detail Quantiity", "", "", "", 0, lblTextblockinvoicedetailquantiity_Jsonclick, "", StyleString, ClassString, "HLP_Gx0051.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCinvoicedetailquantiity_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cInvoiceDetailQuantiity), 3, 0, ".", "")), "", 3, "chr", 1, "row", 3, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV8cInvoiceDetailQuantiity), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(24);\"", 0, edtavCinvoicedetailquantiity_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0051.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockinvoicedetailamount_Internalname, 1, 1, 0, "Invoice Detail Amount", "", "", "", 0, lblTextblockinvoicedetailamount_Jsonclick, "", StyleString, ClassString, "HLP_Gx0051.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCinvoicedetailamount_Internalname, StringUtil.LTrim( StringUtil.NToC( AV9cInvoiceDetailAmount, 9, 2, ".", "")), "", 9, "chr", 1, "row", 9, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( AV9cInvoiceDetailAmount, "ZZZZZ9.99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(29);\"", 0, edtavCinvoicedetailamount_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0051.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_082e( true) ;
         }
         else
         {
            wb_table2_9_082e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV10pInvoiceId = Convert.ToInt32(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pInvoiceId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10pInvoiceId), 6, 0)));
         AV11pInvoiceDetailId = Convert.ToInt16(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pInvoiceDetailId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pInvoiceDetailId), 2, 0)));
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
         PA082( ) ;
         WS082( ) ;
         WE082( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?17252376");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.eng.js", "?46473");
         context.AddJavascriptSource("gx0051.js", "?17252376");
         /* End function include_jscripts */
      }

      protected void sendrow_362( )
      {
         WB080( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_36_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_36_idx) % (2)) == 0 )
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A17InvoiceDetailId), 2, 0, ".", "")))+"'"+"]);" ;
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
            edtInvoiceDetailId_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A17InvoiceDetailId), 2, 0, ".", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInvoiceDetailId_Internalname, "Link", edtInvoiceDetailId_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtInvoiceDetailId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A17InvoiceDetailId), 2, 0, ".", "")),(String)"Select",(short)0,(String)"px",(short)17,(String)"px",(short)2,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtInvoiceDetailId_Link,(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A17InvoiceDetailId), "Z9"),(String)"",(short)0,(String)edtInvoiceDetailId_Jsonclick,(String)"",(short)36,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtProductId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A10ProductId), 6, 0, ".", "")),(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)6,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A10ProductId), "ZZZZZ9"),(String)"",(short)0,(String)edtProductId_Jsonclick,(String)"",(short)36,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtInvoiceDetailQuantiity_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A18InvoiceDetailQuantiity), 3, 0, ".", "")),(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A18InvoiceDetailQuantiity), "ZZ9"),(String)"",(short)0,(String)edtInvoiceDetailQuantiity_Jsonclick,(String)"",(short)36,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtInvoiceDetailAmount_Internalname,StringUtil.LTrim( StringUtil.NToC( A19InvoiceDetailAmount, 9, 2, ".", "")),(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A19InvoiceDetailAmount, "ZZZZZ9.99"),(String)"",(short)0,(String)edtInvoiceDetailAmount_Jsonclick,(String)"",(short)36,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtInvoiceId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A14InvoiceId), 6, 0, ".", "")),(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)6,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A14InvoiceId), "ZZZZZ9"),(String)"",(short)0,(String)edtInvoiceId_Jsonclick,(String)"",(short)36,(short)1,(short)1,(bool)true,(String)"right"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_36_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_36_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_36_idx+1)) ;
            sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
            edtInvoiceDetailId_Internalname = "INVOICEDETAILID_"+sGXsfl_36_idx ;
            edtProductId_Internalname = "PRODUCTID_"+sGXsfl_36_idx ;
            edtInvoiceDetailQuantiity_Internalname = "INVOICEDETAILQUANTIITY_"+sGXsfl_36_idx ;
            edtInvoiceDetailAmount_Internalname = "INVOICEDETAILAMOUNT_"+sGXsfl_36_idx ;
            edtInvoiceId_Internalname = "INVOICEID_"+sGXsfl_36_idx ;
         }
         /* End function sendrow_362 */
      }

      protected void init_default_properties( )
      {
         lblTextblockinvoicedetailid_Internalname = "TEXTBLOCKINVOICEDETAILID" ;
         edtavCinvoicedetailid_Internalname = "vCINVOICEDETAILID" ;
         lblTextblockproductid_Internalname = "TEXTBLOCKPRODUCTID" ;
         edtavCproductid_Internalname = "vCPRODUCTID" ;
         lblTextblockinvoicedetailquantiity_Internalname = "TEXTBLOCKINVOICEDETAILQUANTIITY" ;
         edtavCinvoicedetailquantiity_Internalname = "vCINVOICEDETAILQUANTIITY" ;
         lblTextblockinvoicedetailamount_Internalname = "TEXTBLOCKINVOICEDETAILAMOUNT" ;
         edtavCinvoicedetailamount_Internalname = "vCINVOICEDETAILAMOUNT" ;
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
         edtInvoiceId_Jsonclick = "" ;
         edtInvoiceDetailAmount_Jsonclick = "" ;
         edtInvoiceDetailQuantiity_Jsonclick = "" ;
         edtProductId_Jsonclick = "" ;
         edtInvoiceDetailId_Jsonclick = "" ;
         edtavCinvoicedetailamount_Jsonclick = "" ;
         edtavCinvoicedetailquantiity_Jsonclick = "" ;
         edtavCproductid_Jsonclick = "" ;
         edtavCinvoicedetailid_Jsonclick = "" ;
         edtInvoiceDetailId_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Detail" ;
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
         edtInvoiceDetailId_Internalname = "" ;
         edtProductId_Internalname = "" ;
         edtInvoiceDetailQuantiity_Internalname = "" ;
         edtInvoiceDetailAmount_Internalname = "" ;
         edtInvoiceId_Internalname = "" ;
         AV5LinkSelection = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         H00082_A14InvoiceId = new int[1] ;
         H00082_A10ProductId = new int[1] ;
         H00082_A17InvoiceDetailId = new short[1] ;
         H00082_A13ProductPrice = new decimal[1] ;
         H00082_A18InvoiceDetailQuantiity = new short[1] ;
         H00083_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockinvoicedetailid_Jsonclick = "" ;
         lblTextblockproductid_Jsonclick = "" ;
         lblTextblockinvoicedetailquantiity_Jsonclick = "" ;
         lblTextblockinvoicedetailamount_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char7 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0051__default(),
            new Object[][] {
                new Object[] {
               H00082_A14InvoiceId, H00082_A10ProductId, H00082_A17InvoiceDetailId, H00082_A13ProductPrice, H00082_A18InvoiceDetailQuantiity
               }
               , new Object[] {
               H00083_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_36_idx=1 ;
      private short AV6cInvoiceDetailId ;
      private short AV8cInvoiceDetailQuantiity ;
      private short AV11pInvoiceDetailId ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A17InvoiceDetailId ;
      private short A18InvoiceDetailQuantiity ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int AV10pInvoiceId ;
      private int wcpOAV10pInvoiceId ;
      private int Grid1_PageSize36 ;
      private int AV7cProductId ;
      private int GRID1_nFirstRecordOnPage ;
      private int A10ProductId ;
      private int A14InvoiceId ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private decimal AV9cInvoiceDetailAmount ;
      private decimal A13ProductPrice ;
      private decimal A19InvoiceDetailAmount ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_36_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtInvoiceDetailId_Internalname ;
      private String edtProductId_Internalname ;
      private String edtInvoiceDetailQuantiity_Internalname ;
      private String edtInvoiceDetailAmount_Internalname ;
      private String edtInvoiceId_Internalname ;
      private String edtavCinvoicedetailid_Internalname ;
      private String scmdbuf ;
      private String edtavCproductid_Internalname ;
      private String edtavCinvoicedetailquantiity_Internalname ;
      private String edtavCinvoicedetailamount_Internalname ;
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
      private String edtavLinkselection_Link ;
      private String edtInvoiceDetailId_Link ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockinvoicedetailid_Internalname ;
      private String lblTextblockinvoicedetailid_Jsonclick ;
      private String edtavCinvoicedetailid_Jsonclick ;
      private String lblTextblockproductid_Internalname ;
      private String lblTextblockproductid_Jsonclick ;
      private String edtavCproductid_Jsonclick ;
      private String lblTextblockinvoicedetailquantiity_Internalname ;
      private String lblTextblockinvoicedetailquantiity_Jsonclick ;
      private String edtavCinvoicedetailquantiity_Jsonclick ;
      private String lblTextblockinvoicedetailamount_Internalname ;
      private String lblTextblockinvoicedetailamount_Jsonclick ;
      private String edtavCinvoicedetailamount_Jsonclick ;
      private String ROClassString ;
      private String edtInvoiceDetailId_Jsonclick ;
      private String edtProductId_Jsonclick ;
      private String edtInvoiceDetailQuantiity_Jsonclick ;
      private String edtInvoiceDetailAmount_Jsonclick ;
      private String edtInvoiceId_Jsonclick ;
      private String GXt_char7 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] H00082_A14InvoiceId ;
      private int[] H00082_A10ProductId ;
      private short[] H00082_A17InvoiceDetailId ;
      private decimal[] H00082_A13ProductPrice ;
      private short[] H00082_A18InvoiceDetailQuantiity ;
      private int[] H00083_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP1_pInvoiceDetailId ;
      private GXWebForm Form ;
   }

   public class gx0051__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00082 ;
          prmH00082 = new Object[] {
          new Object[] {"@AV10pInvoiceId",SqlDbType.Int,6,0} ,
          new Object[] {"@AV6cInvoiceDetailId",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV7cProductId",SqlDbType.Int,6,0} ,
          new Object[] {"@AV8cInvoiceDetailQuantiity",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV9cInvoiceDetailAmount",SqlDbType.Decimal,9,2}
          } ;
          Object[] prmH00083 ;
          prmH00083 = new Object[] {
          new Object[] {"@AV10pInvoiceId",SqlDbType.Int,6,0} ,
          new Object[] {"@AV6cInvoiceDetailId",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV7cProductId",SqlDbType.Int,6,0} ,
          new Object[] {"@AV8cInvoiceDetailQuantiity",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV9cInvoiceDetailAmount",SqlDbType.Decimal,9,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00082", "SELECT T1.[InvoiceId], T1.[ProductId], T1.[InvoiceDetailId], T2.[ProductPrice], T1.[InvoiceDetailQuantiity] FROM ([InvoiceDetail] T1 WITH (NOLOCK) INNER JOIN [Product] T2 WITH (NOLOCK) ON T2.[ProductId] = T1.[ProductId]) WHERE (T1.[InvoiceId] = @AV10pInvoiceId and T1.[InvoiceDetailId] >= @AV6cInvoiceDetailId) AND (T1.[ProductId] >= @AV7cProductId) AND (T1.[InvoiceDetailQuantiity] >= @AV8cInvoiceDetailQuantiity) AND (( T2.[ProductPrice] * CAST(T1.[InvoiceDetailQuantiity] AS decimal( 14, 5))) >= @AV9cInvoiceDetailAmount) ORDER BY T1.[InvoiceId], T1.[InvoiceDetailId]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00082,11,0,false,false )
             ,new CursorDef("H00083", "SELECT COUNT(*) FROM ([InvoiceDetail] T1 WITH (NOLOCK) INNER JOIN [Product] T2 WITH (NOLOCK) ON T2.[ProductId] = T1.[ProductId]) WHERE (T1.[InvoiceId] = @AV10pInvoiceId and T1.[InvoiceDetailId] >= @AV6cInvoiceDetailId) AND (T1.[ProductId] >= @AV7cProductId) AND (T1.[InvoiceDetailQuantiity] >= @AV8cInvoiceDetailQuantiity) AND (( T2.[ProductPrice] * CAST(T1.[InvoiceDetailQuantiity] AS decimal( 14, 5))) >= @AV9cInvoiceDetailAmount) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00083,1,0,false,false )
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                break;
       }
    }

 }

}
