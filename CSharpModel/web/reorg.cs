/*
               File: reorg
        Description: Table Manager
             Author: GeneXus C# Generator version 10_1_6-46473
       Generated on: 11/23/2016 16:35:25.51
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
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class reorg : GXReorganization
   {
      public reorg( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public reorg( IGxContext context )
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
         initialize();
         executePrivate();
      }

      void executePrivate( )
      {
         if ( PreviousCheck() )
         {
            ExecuteReorganization( ) ;
         }
      }

      private void FirstActions( )
      {
         /* Load data into tables. */
      }

      public void ReorganizeCustomer( )
      {
         String cmdBuffer ;
         /* Indices for table Customer */
         cmdBuffer=" DROP INDEX [ICUSTOMER1] ON [Customer] "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         cmdBuffer=" ALTER TABLE [Customer] ALTER COLUMN [CountryId] int NULL  "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         try
         {
            cmdBuffer=" CREATE NONCLUSTERED INDEX [ICUSTOMER1] ON [Customer] ([CountryId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            cmdBuffer=" DROP INDEX [ICUSTOMER1] ON [Customer] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE NONCLUSTERED INDEX [ICUSTOMER1] ON [Customer] ([CountryId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreateInvoiceDetail( )
      {
         String cmdBuffer ;
         /* Indices for table InvoiceDetail */
         try
         {
            cmdBuffer=" CREATE TABLE [InvoiceDetail] ([InvoiceId] int NOT NULL , [InvoiceDetailId] smallint NOT NULL , [ProductId] int NOT NULL , [InvoiceDetailQuantiity] smallint NOT NULL , [InvoiceDetailAmount] money NOT NULL , PRIMARY KEY([InvoiceId], [InvoiceDetailId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            DropTableConstraints( "[InvoiceDetail]") ;
            cmdBuffer=" DROP TABLE [InvoiceDetail] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE TABLE [InvoiceDetail] ([InvoiceId] int NOT NULL , [InvoiceDetailId] smallint NOT NULL , [ProductId] int NOT NULL , [InvoiceDetailQuantiity] smallint NOT NULL , [InvoiceDetailAmount] money NOT NULL , PRIMARY KEY([InvoiceId], [InvoiceDetailId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         try
         {
            cmdBuffer=" CREATE NONCLUSTERED INDEX [IINVOICEDETAIL1] ON [InvoiceDetail] ([ProductId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            cmdBuffer=" DROP INDEX [IINVOICEDETAIL1] ON [InvoiceDetail] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE NONCLUSTERED INDEX [IINVOICEDETAIL1] ON [InvoiceDetail] ([ProductId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreateInvoice( )
      {
         String cmdBuffer ;
         /* Indices for table Invoice */
         try
         {
            cmdBuffer=" CREATE TABLE [Invoice] ([InvoiceId] int NOT NULL  IDENTITY(1,1), [InvoiceDate] datetime NOT NULL , [CustomerId] int NOT NULL , [InvoiceAmount] money NOT NULL , PRIMARY KEY([InvoiceId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            DropTableConstraints( "[Invoice]") ;
            cmdBuffer=" DROP TABLE [Invoice] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE TABLE [Invoice] ([InvoiceId] int NOT NULL  IDENTITY(1,1), [InvoiceDate] datetime NOT NULL , [CustomerId] int NOT NULL , [InvoiceAmount] money NOT NULL , PRIMARY KEY([InvoiceId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         try
         {
            cmdBuffer=" CREATE NONCLUSTERED INDEX [IINVOICE1] ON [Invoice] ([CustomerId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            cmdBuffer=" DROP INDEX [IINVOICE1] ON [Invoice] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE NONCLUSTERED INDEX [IINVOICE1] ON [Invoice] ([CustomerId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreateProduct( )
      {
         String cmdBuffer ;
         /* Indices for table Product */
         try
         {
            cmdBuffer=" CREATE TABLE [Product] ([ProductId] int NOT NULL  IDENTITY(1,1), [ProductDescription] char(30) NOT NULL , [ProductStock] smallint NOT NULL , [ProductPrice] money NOT NULL , PRIMARY KEY([ProductId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            DropTableConstraints( "[Product]") ;
            cmdBuffer=" DROP TABLE [Product] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE TABLE [Product] ([ProductId] int NOT NULL  IDENTITY(1,1), [ProductDescription] char(30) NOT NULL , [ProductStock] smallint NOT NULL , [ProductPrice] money NOT NULL , PRIMARY KEY([ProductId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void RIInvoiceCustomer( )
      {
         String cmdBuffer ;
         try
         {
            cmdBuffer=" ALTER TABLE [Invoice] ADD CONSTRAINT [IINVOICE1] FOREIGN KEY ([CustomerId]) REFERENCES [Customer] ([CustomerId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            cmdBuffer=" ALTER TABLE [Invoice] DROP CONSTRAINT [IINVOICE1] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" ALTER TABLE [Invoice] ADD CONSTRAINT [IINVOICE1] FOREIGN KEY ([CustomerId]) REFERENCES [Customer] ([CustomerId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void RIInvoiceDetailInvoice( )
      {
         String cmdBuffer ;
         try
         {
            cmdBuffer=" ALTER TABLE [InvoiceDetail] ADD CONSTRAINT [IINVOICEDETAIL2] FOREIGN KEY ([InvoiceId]) REFERENCES [Invoice] ([InvoiceId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            cmdBuffer=" ALTER TABLE [InvoiceDetail] DROP CONSTRAINT [IINVOICEDETAIL2] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" ALTER TABLE [InvoiceDetail] ADD CONSTRAINT [IINVOICEDETAIL2] FOREIGN KEY ([InvoiceId]) REFERENCES [Invoice] ([InvoiceId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void RIInvoiceDetailProduct( )
      {
         String cmdBuffer ;
         try
         {
            cmdBuffer=" ALTER TABLE [InvoiceDetail] ADD CONSTRAINT [IINVOICEDETAIL1] FOREIGN KEY ([ProductId]) REFERENCES [Product] ([ProductId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            cmdBuffer=" ALTER TABLE [InvoiceDetail] DROP CONSTRAINT [IINVOICEDETAIL1] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" ALTER TABLE [InvoiceDetail] ADD CONSTRAINT [IINVOICEDETAIL1] FOREIGN KEY ([ProductId]) REFERENCES [Product] ([ProductId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      private void TablesCount( )
      {
         if ( ! IsResumeMode( ) )
         {
            /* Using cursor P00012 */
            pr_default.execute(0);
            CustomerCount = P00012_ACustomerCount[0] ;
            pr_default.close(0);
            PrintRecordCount ( "Customer" ,  CustomerCount );
         }
      }

      private bool PreviousCheck( )
      {
         if ( ! IsResumeMode( ) )
         {
            if ( GXUtil.DbmsVersion( context, "DEFAULT") < 9 )
            {
               SetCheckError ( GXResourceManager.GetMessage("GXM_bad_DBMS_version", new   object[]  {"2005"}) );
               return false;
            }
         }
         if ( ! MustRunCheck( ) )
         {
            return true ;
         }
         if ( GXUtil.IsSQLSERVER2005( context, "DEFAULT") )
         {
            /* Using cursor P00023 */
            pr_default.execute(1);
            while ( (pr_default.getStatus(1) != 101) )
            {
               sSchemaVar = P00023_AsSchemaVar[0] ;
               nsSchemaVar = P00023_nsSchemaVar[0] ;
               pr_default.readNext(1);
            }
            pr_default.close(1);
         }
         else
         {
            /* Using cursor P00034 */
            pr_default.execute(2);
            while ( (pr_default.getStatus(2) != 101) )
            {
               sSchemaVar = P00034_AsSchemaVar[0] ;
               nsSchemaVar = P00034_nsSchemaVar[0] ;
               pr_default.readNext(2);
            }
            pr_default.close(2);
         }
         if ( TableExist("InvoiceDetail",sSchemaVar) )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_table_exist", new   object[]  {"InvoiceDetail"}) );
            return false;
         }
         if ( TableExist("Invoice",sSchemaVar) )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_table_exist", new   object[]  {"Invoice"}) );
            return false;
         }
         if ( TableExist("Product",sSchemaVar) )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_table_exist", new   object[]  {"Product"}) );
            return false;
         }
         return true ;
      }

      private bool TableExist( String sTableName ,
                               String sMySchemaName )
      {
         bool result ;
         result = false ;
         /* Using cursor P00045 */
         pr_default.execute(3, new Object[] {sTableName, sMySchemaName});
         while ( (pr_default.getStatus(3) != 101) )
         {
            tablename = P00045_Atablename[0] ;
            ntablename = P00045_ntablename[0] ;
            schemaname = P00045_Aschemaname[0] ;
            nschemaname = P00045_nschemaname[0] ;
            result = true ;
            pr_default.readNext(3);
         }
         pr_default.close(3);
         return result ;
      }

      private void ExecuteOnlyTablesReorganization( )
      {
         ReorgExecute.RegisterBlockForSubmit( 1 ,  "ReorganizeCustomer" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 2 ,  "CreateInvoiceDetail" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 3 ,  "CreateInvoice" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 4 ,  "CreateProduct" , new Object[]{ });
      }

      private void ExecuteOnlyRisReorganization( )
      {
         ReorgExecute.RegisterBlockForSubmit( 5 ,  "RIInvoiceCustomer" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 6 ,  "RIInvoiceDetailInvoice" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 7 ,  "RIInvoiceDetailProduct" , new Object[]{ });
      }

      private void ExecuteTablesReorganization( )
      {
         ExecuteOnlyTablesReorganization( ) ;
         ExecuteOnlyRisReorganization( ) ;
         ReorgExecute.SubmitAll() ;
      }

      private void SetPrecedence( )
      {
         SetPrecedencetables( ) ;
         SetPrecedenceris( ) ;
      }

      private void SetPrecedencetables( )
      {
         GXReorganization.SetMsg( 1 ,  GXResourceManager.GetMessage("GXM_fileupdate", new   object[]  {"Customer", ""}) );
         GXReorganization.SetMsg( 2 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"InvoiceDetail", ""}) );
         ReorgExecute.RegisterPrecedence( "CreateInvoiceDetail" ,  "CreateInvoice" );
         ReorgExecute.RegisterPrecedence( "CreateInvoiceDetail" ,  "CreateProduct" );
         GXReorganization.SetMsg( 3 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"Invoice", ""}) );
         GXReorganization.SetMsg( 4 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"Product", ""}) );
      }

      private void SetPrecedenceris( )
      {
         GXReorganization.SetMsg( 5 ,  GXResourceManager.GetMessage("GXM_refintcrea", new   object[]  {"[IINVOICE1]"}) );
         ReorgExecute.RegisterPrecedence( "RIInvoiceCustomer" ,  "CreateInvoice" );
         ReorgExecute.RegisterPrecedence( "RIInvoiceCustomer" ,  "ReorganizeCustomer" );
         GXReorganization.SetMsg( 6 ,  GXResourceManager.GetMessage("GXM_refintcrea", new   object[]  {"[IINVOICEDETAIL2]"}) );
         ReorgExecute.RegisterPrecedence( "RIInvoiceDetailInvoice" ,  "CreateInvoiceDetail" );
         ReorgExecute.RegisterPrecedence( "RIInvoiceDetailInvoice" ,  "CreateInvoice" );
         GXReorganization.SetMsg( 7 ,  GXResourceManager.GetMessage("GXM_refintcrea", new   object[]  {"[IINVOICEDETAIL1]"}) );
         ReorgExecute.RegisterPrecedence( "RIInvoiceDetailProduct" ,  "CreateInvoiceDetail" );
         ReorgExecute.RegisterPrecedence( "RIInvoiceDetailProduct" ,  "CreateProduct" );
      }

      private void ExecuteReorganization( )
      {
         if ( ErrCode == 0 )
         {
            TablesCount( ) ;
            if ( ! PrintOnlyRecordCount( ) )
            {
               FirstActions( ) ;
               SetPrecedence( ) ;
               ExecuteTablesReorganization( ) ;
            }
         }
      }

      [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
      public void DropTableConstraints( String sTableName )
      {
         String cmdBuffer ;
         /* Using cursor P00056 */
         pr_default.execute(4, new Object[] {sTableName});
         while ( (pr_default.getStatus(4) != 101) )
         {
            constid = P00056_Aconstid[0] ;
            nconstid = P00056_nconstid[0] ;
            fkeyid = P00056_Afkeyid[0] ;
            nfkeyid = P00056_nfkeyid[0] ;
            rkeyid = P00056_Arkeyid[0] ;
            nrkeyid = P00056_nrkeyid[0] ;
            cmdBuffer = "ALTER TABLE " + "[" + fkeyid + "] DROP CONSTRAINT " + constid ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            pr_default.readNext(4);
         }
         pr_default.close(4);
      }

      public void UtilsCleanup( )
      {
         this.cleanup();
      }

      protected void cleanup( )
      {
         CloseOpenCursors();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         scmdbuf = "" ;
         P00012_ACustomerCount = new int[1] ;
         sSchemaVar = "" ;
         nsSchemaVar = false ;
         P00023_AsSchemaVar = new String[] {""} ;
         P00023_nsSchemaVar = new bool[] {false} ;
         P00034_AsSchemaVar = new String[] {""} ;
         P00034_nsSchemaVar = new bool[] {false} ;
         sTableName = "" ;
         sMySchemaName = "" ;
         tablename = "" ;
         ntablename = false ;
         schemaname = "" ;
         nschemaname = false ;
         P00045_Atablename = new String[] {""} ;
         P00045_ntablename = new bool[] {false} ;
         P00045_Aschemaname = new String[] {""} ;
         P00045_nschemaname = new bool[] {false} ;
         constid = "" ;
         nconstid = false ;
         fkeyid = "" ;
         nfkeyid = false ;
         P00056_Aconstid = new String[] {""} ;
         P00056_nconstid = new bool[] {false} ;
         P00056_Afkeyid = new String[] {""} ;
         P00056_nfkeyid = new bool[] {false} ;
         P00056_Arkeyid = new int[1] ;
         P00056_nrkeyid = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.reorg__default(),
            new Object[][] {
                new Object[] {
               P00012_ACustomerCount
               }
               , new Object[] {
               P00023_AsSchemaVar
               }
               , new Object[] {
               P00034_AsSchemaVar
               }
               , new Object[] {
               P00045_Atablename, P00045_Aschemaname
               }
               , new Object[] {
               P00056_Aconstid, P00056_Afkeyid, P00056_Arkeyid
               }
            }
         );
         /* GeneXus formulas. */
      }

      protected short ErrCode ;
      protected int CustomerCount ;
      protected int rkeyid ;
      protected String scmdbuf ;
      protected String sSchemaVar ;
      protected String sTableName ;
      protected String sMySchemaName ;
      protected bool nsSchemaVar ;
      protected bool ntablename ;
      protected bool nschemaname ;
      protected bool nconstid ;
      protected bool nfkeyid ;
      protected bool nrkeyid ;
      protected String tablename ;
      protected String schemaname ;
      protected String constid ;
      protected String fkeyid ;
      protected IGxDataStore dsDefault ;
      protected GxCommand RGZ ;
      protected IDataStoreProvider pr_default ;
      protected int[] P00012_ACustomerCount ;
      protected String[] P00023_AsSchemaVar ;
      protected bool[] P00023_nsSchemaVar ;
      protected String[] P00034_AsSchemaVar ;
      protected bool[] P00034_nsSchemaVar ;
      protected String[] P00045_Atablename ;
      protected bool[] P00045_ntablename ;
      protected String[] P00045_Aschemaname ;
      protected bool[] P00045_nschemaname ;
      protected String[] P00056_Aconstid ;
      protected bool[] P00056_nconstid ;
      protected String[] P00056_Afkeyid ;
      protected bool[] P00056_nfkeyid ;
      protected int[] P00056_Arkeyid ;
      protected bool[] P00056_nrkeyid ;
   }

   public class reorg__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00012 ;
          prmP00012 = new Object[] {
          } ;
          Object[] prmP00023 ;
          prmP00023 = new Object[] {
          } ;
          Object[] prmP00034 ;
          prmP00034 = new Object[] {
          } ;
          Object[] prmP00045 ;
          prmP00045 = new Object[] {
          new Object[] {"@sTableName",SqlDbType.Char,255,0} ,
          new Object[] {"@sMySchemaName",SqlDbType.Char,255,0}
          } ;
          Object[] prmP00056 ;
          prmP00056 = new Object[] {
          new Object[] {"@sTableName",SqlDbType.Char,255,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00012", "SELECT COUNT(*) FROM [Customer] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00012,100,0,true,false )
             ,new CursorDef("P00023", "SELECT SCHEMA_NAME() ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00023,100,0,true,false )
             ,new CursorDef("P00034", "SELECT USER_NAME() ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00034,100,0,true,false )
             ,new CursorDef("P00045", "SELECT [TABLE_NAME], [TABLE_SCHEMA] FROM INFORMATION_SCHEMA.TABLES WHERE ([TABLE_NAME] = @sTableName) AND ([TABLE_SCHEMA] = @sMySchemaName) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00045,100,0,true,false )
             ,new CursorDef("P00056", "SELECT OBJECT_NAME(object_id), OBJECT_NAME(parent_object_id), [referenced_object_id] FROM sys.foreign_keys WHERE [referenced_object_id] = OBJECT_ID(RTRIM(LTRIM(@sTableName))) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00056,100,0,true,false )
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
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 255) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 255) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
