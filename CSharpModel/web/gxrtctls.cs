/*
               File: GXRTCtls
        Description: Run time reorganization controls
             Author: GeneXus C# Generator version 10_1_6-46473
       Generated on: 11/30/2016 18:6:48.23
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
   public class gxrtctls : GXProcedure
   {
      public gxrtctls( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public gxrtctls( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out short aP0_Status )
      {
         this.AV2Status = 0 ;
         initialize();
         executePrivate();
         aP0_Status=this.AV2Status;
      }

      public short executeUdp( )
      {
         this.AV2Status = 0 ;
         initialize();
         executePrivate();
         aP0_Status=this.AV2Status;
         return AV2Status ;
      }

      public void executeSubmit( out short aP0_Status )
      {
         gxrtctls objgxrtctls;
         objgxrtctls = new gxrtctls();
         objgxrtctls.AV2Status = 0 ;
         objgxrtctls.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objgxrtctls.executePrivateCatch ));
         aP0_Status=this.AV2Status;
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
         AV2Status = 0 ;
         Console.WriteLine( "=== Starting run time controls" );
         Console.WriteLine( "Checking that table Customer does NOT contain records." );
         AV3NotFound = 0 ;
         AV6GXLvl4 = 0 ;
         /* Using cursor LTCTLS2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A1CountryId = LTCTLS2_A1CountryId[0] ;
            A3CustomerId = LTCTLS2_A3CustomerId[0] ;
            AV6GXLvl4 = 1 ;
            AV7GXLvl7 = 0 ;
            /* Using cursor LTCTLS3 */
            pr_default.execute(1, new Object[] {A1CountryId});
            while ( (pr_default.getStatus(1) != 101) )
            {
               AV7GXLvl7 = 1 ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
            if ( AV7GXLvl7 == 0 )
            {
               AV2Status = 1 ;
               Console.WriteLine( "Fail: Table Customer has records but referenced key value in table Country does _not_ exist." );
               Console.WriteLine( "Recovery: See recovery information for reorganization message rgz0029." );
               AV3NotFound = 1 ;
            }
            if ( AV3NotFound == 1 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV6GXLvl4 == 0 )
         {
            Console.WriteLine( "Success: Table Customer does NOT have records." );
            AV3NotFound = 1 ;
         }
         if ( AV3NotFound == 0 )
         {
            Console.WriteLine( "Success: Table Customerhas records but all referenced key values in table Country exist." );
         }
         Console.WriteLine( "====================" );
         Console.WriteLine( "=== End of run time controls" );
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
         scmdbuf = "" ;
         LTCTLS2_A1CountryId = new int[1] ;
         LTCTLS2_A3CustomerId = new int[1] ;
         LTCTLS3_A1CountryId = new int[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gxrtctls__default(),
            new Object[][] {
                new Object[] {
               LTCTLS2_A1CountryId, LTCTLS2_A3CustomerId
               }
               , new Object[] {
               LTCTLS3_A1CountryId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV2Status ;
      private short AV3NotFound ;
      private short AV6GXLvl4 ;
      private short AV7GXLvl7 ;
      private int A1CountryId ;
      private int A3CustomerId ;
      private String scmdbuf ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] LTCTLS2_A1CountryId ;
      private int[] LTCTLS2_A3CustomerId ;
      private int[] LTCTLS3_A1CountryId ;
      private short aP0_Status ;
   }

   public class gxrtctls__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmLTCTLS2 ;
          prmLTCTLS2 = new Object[] {
          } ;
          Object[] prmLTCTLS3 ;
          prmLTCTLS3 = new Object[] {
          new Object[] {"@CountryId",SqlDbType.Int,6,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("LTCTLS2", "SELECT DISTINCT [CountryId], [CustomerId] FROM [Customer] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmLTCTLS2,100,0,true,false )
             ,new CursorDef("LTCTLS3", "SELECT [CountryId] FROM [Country] WHERE [CountryId] = @CountryId ORDER BY [CountryId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmLTCTLS3,1,0,false,true )
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
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
