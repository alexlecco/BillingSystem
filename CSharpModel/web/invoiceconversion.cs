/*
               File: InvoiceConversion
        Description: Conversion for table Invoice
             Author: GeneXus C# Generator version 10_1_6-46473
       Generated on: 11/30/2016 17:45:32.5
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
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
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class invoiceconversion : GXProcedure
   {
      public invoiceconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public invoiceconversion( IGxContext context )
      {
         this.DisconnectAtCleanup = true;
         context = context.UtlClone();
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         invoiceconversion objinvoiceconversion;
         objinvoiceconversion = new invoiceconversion();
         objinvoiceconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objinvoiceconversion.executePrivateCatch ));
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         cmdBuffer=" SET IDENTITY_INSERT [GXA0004] ON "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         /* Using cursor INVOICECON2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A1CountryId = INVOICECON2_A1CountryId[0] ;
            n1CountryId = INVOICECON2_n1CountryId[0] ;
            A3CustomerId = INVOICECON2_A3CustomerId[0] ;
            A15InvoiceDate = INVOICECON2_A15InvoiceDate[0] ;
            A14InvoiceId = INVOICECON2_A14InvoiceId[0] ;
            A1CountryId = INVOICECON2_A1CountryId[0] ;
            n1CountryId = INVOICECON2_n1CountryId[0] ;
            /*
               INSERT RECORD ON TABLE GXA0004

            */
            AV2InvoiceId = A14InvoiceId ;
            AV3InvoiceDate = A15InvoiceDate ;
            AV4CustomerId = A3CustomerId ;
            if ( INVOICECON2_n1CountryId[0] )
            {
               AV5InvoiceCountryId = 0 ;
            }
            else
            {
               AV5InvoiceCountryId = A1CountryId ;
            }
            /* Using cursor INVOICECON3 */
            pr_default.execute(1, new Object[] {AV2InvoiceId, AV3InvoiceDate, AV4CustomerId, AV5InvoiceCountryId});
            pr_default.close(1);
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1 ;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate")) ;
            }
            else
            {
               context.Gx_err = 0 ;
               Gx_emsg = "" ;
            }
            /* End Insert */
            pr_default.readNext(0);
         }
         pr_default.close(0);
         cmdBuffer=" SET IDENTITY_INSERT [GXA0004] OFF "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         this.cleanup();
      }

      protected void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         cmdBuffer = "" ;
         scmdbuf = "" ;
         INVOICECON2_A1CountryId = new int[1] ;
         INVOICECON2_n1CountryId = new bool[] {false} ;
         INVOICECON2_A3CustomerId = new int[1] ;
         INVOICECON2_A15InvoiceDate = new DateTime[] {DateTime.MinValue} ;
         INVOICECON2_A14InvoiceId = new int[1] ;
         A15InvoiceDate = DateTime.MinValue ;
         AV3InvoiceDate = DateTime.MinValue ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.invoiceconversion__default(),
            new Object[][] {
                new Object[] {
               INVOICECON2_A1CountryId, INVOICECON2_n1CountryId, INVOICECON2_A3CustomerId, INVOICECON2_A15InvoiceDate, INVOICECON2_A14InvoiceId
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int A1CountryId ;
      private int A3CustomerId ;
      private int A14InvoiceId ;
      private int GIGXA0004 ;
      private int AV2InvoiceId ;
      private int AV4CustomerId ;
      private int AV5InvoiceCountryId ;
      private String cmdBuffer ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime A15InvoiceDate ;
      private DateTime AV3InvoiceDate ;
      private bool n1CountryId ;
      private IGxDataStore dsDefault ;
      private GxCommand RGZ ;
      private IDataStoreProvider pr_default ;
      private int[] INVOICECON2_A1CountryId ;
      private bool[] INVOICECON2_n1CountryId ;
      private int[] INVOICECON2_A3CustomerId ;
      private DateTime[] INVOICECON2_A15InvoiceDate ;
      private int[] INVOICECON2_A14InvoiceId ;
   }

   public class invoiceconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmINVOICECON2 ;
          prmINVOICECON2 = new Object[] {
          } ;
          Object[] prmINVOICECON3 ;
          prmINVOICECON3 = new Object[] {
          new Object[] {"@AV2InvoiceId",SqlDbType.Int,6,0} ,
          new Object[] {"@AV3InvoiceDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV4CustomerId",SqlDbType.Int,6,0} ,
          new Object[] {"@AV5InvoiceCountryId",SqlDbType.Int,6,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("INVOICECON2", "SELECT T2.[CountryId], T1.[CustomerId], T1.[InvoiceDate], T1.[InvoiceId] FROM ([Invoice] T1 INNER JOIN [Customer] T2 ON T2.[CustomerId] = T1.[CustomerId]) ORDER BY T1.[InvoiceId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmINVOICECON2,100,0,true,false )
             ,new CursorDef("INVOICECON3", "INSERT INTO [GXA0004] ([InvoiceId], [InvoiceDate], [CustomerId], [InvoiceCountryId]) VALUES (@AV2InvoiceId, @AV3InvoiceDate, @AV4CustomerId, @AV5InvoiceCountryId)", GxErrorMask.GX_NOMASK,prmINVOICECON3)
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
                ((int[]) buf[4])[0] = rslt.getInt(4) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
       }
    }

 }

}
