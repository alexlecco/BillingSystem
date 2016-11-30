using System;
using GeneXus.Builder;
using System.IO;
public class bldDevelopermenu : GxBaseBuilder
{
   string cs_path = "." ;
   public bldDevelopermenu( ) : base()
   {
   }

   public override int BeforeCompile( )
   {
      return 0 ;
   }

   public override int AfterCompile( )
   {
      int ErrCode ;
      ErrCode = 0 ;
      if ( ! File.Exists(@"bin\client.exe.config") || checkTime(@"bin\client.exe.config",cs_path + @"\client.exe.config") )
      {
         File.Copy( cs_path + @"\client.exe.config", @"bin\client.exe.config", true);
      }
      return ErrCode ;
   }

   static public int Main( string[] args )
   {
      bldDevelopermenu x = new bldDevelopermenu() ;
      x.SetMainSourceFile( "bldDevelopermenu.cs");
      x.LoadVariables( args);
      return x.CompileAll( );
   }

   public override ItemCollection GetSortedBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\GeneXus.Programs.Common.dll", cs_path + @"\GeneXus.Programs.Common.rsp");
      return sc ;
   }

   public override ItemCollection GetRuntimeBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\clientesenrango.dll", cs_path + @"\clientesenrango.rsp");
      sc.Add( @"bin\gx0051.dll", cs_path + @"\gx0051.rsp");
      sc.Add( @"bin\gx0040.dll", cs_path + @"\gx0040.rsp");
      sc.Add( @"bin\gx0030.dll", cs_path + @"\gx0030.rsp");
      sc.Add( @"bin\gx0020.dll", cs_path + @"\gx0020.rsp");
      sc.Add( @"bin\gx0010.dll", cs_path + @"\gx0010.rsp");
      sc.Add( @"bin\promptmasterpage.dll", cs_path + @"\promptmasterpage.rsp");
      sc.Add( @"bin\recentlinks.dll", cs_path + @"\recentlinks.rsp");
      sc.Add( @"bin\appmasterpage.dll", cs_path + @"\appmasterpage.rsp");
      sc.Add( @"bin\invoice.dll", cs_path + @"\invoice.rsp");
      sc.Add( @"bin\product.dll", cs_path + @"\product.rsp");
      sc.Add( @"bin\customer.dll", cs_path + @"\customer.rsp");
      sc.Add( @"bin\country.dll", cs_path + @"\country.rsp");
      return sc ;
   }

   public override ItemCollection GetResBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\messages.eng.dll", cs_path + @"\messages.eng.txt");
      return sc ;
   }

   public override bool ToBuild( String obj )
   {
      if (checkTime(obj, cs_path + @"\bin\GxClasses.dll" ))
         return true;
      if ( obj == @"bin\GeneXus.Programs.Common.dll" )
      {
         if (checkTime(obj, cs_path + @"\type_SdtLinkList_LinkItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxObjectCollection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxSilentTrnGridCollection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\SoapParm.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxWebStd.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxFullTextSearchReindexer.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxModelInfoProvider.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINStatus.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINRecentLinksOptions.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINMessageTypes.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINIMEMode.cs" ))
            return true;
      }
      if ( obj == @"bin\messages.eng.dll" )
      {
         if (checkTime(obj, cs_path + @"\messages.eng.txt" ))
            return true;
      }
      return false ;
   }

}

