// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
//
//                    Source Code Generated by
//                           CA Gen 8.6
//
//    Copyright (c) 2024 CA Technologies. All rights reserved.
//
//    Name: IXX10002_OA                      Date: 2024/01/09
//    User: AliAl                            Time: 13:41:19
//
// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *

// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
// using Statements
// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
using System;
using com.ca.gen.vwrt;
using com.ca.gen.vwrt.types;
using com.ca.gen.vwrt.vdf;
using com.ca.gen.csu.exception;

// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
// START OF EXPORT VIEW
// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
namespace GEN.ORT.YYY
{
  /// <summary>
  /// Internal data view storage for: IXX10002_OA
  /// </summary>
  [Serializable]
  public class IXX10002_OA : ViewBase, IExportView
  {
    private static IXX10002_OA[] freeArray = new IXX10002_OA[30];
    private static int countFree = 0;
    
    // Entity View: EXP
    //        Type: IXX1_CLIENT_RUNTIME_INFO
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpIxx1ClientRuntimeInfoTokenText
    /// </summary>
    private char _ExpIxx1ClientRuntimeInfoTokenText_AS;
    /// <summary>
    /// Attribute missing flag for: ExpIxx1ClientRuntimeInfoTokenText
    /// </summary>
    public char ExpIxx1ClientRuntimeInfoTokenText_AS {
      get {
        return(_ExpIxx1ClientRuntimeInfoTokenText_AS);
      }
      set {
        _ExpIxx1ClientRuntimeInfoTokenText_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpIxx1ClientRuntimeInfoTokenText
    /// Domain: Text
    /// Length: 32
    /// Varying Length: N
    /// </summary>
    private string _ExpIxx1ClientRuntimeInfoTokenText;
    /// <summary>
    /// Attribute for: ExpIxx1ClientRuntimeInfoTokenText
    /// </summary>
    public string ExpIxx1ClientRuntimeInfoTokenText {
      get {
        return(_ExpIxx1ClientRuntimeInfoTokenText);
      }
      set {
        _ExpIxx1ClientRuntimeInfoTokenText = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpIxx1ClientRuntimeInfoWsNameText
    /// </summary>
    private char _ExpIxx1ClientRuntimeInfoWsNameText_AS;
    /// <summary>
    /// Attribute missing flag for: ExpIxx1ClientRuntimeInfoWsNameText
    /// </summary>
    public char ExpIxx1ClientRuntimeInfoWsNameText_AS {
      get {
        return(_ExpIxx1ClientRuntimeInfoWsNameText_AS);
      }
      set {
        _ExpIxx1ClientRuntimeInfoWsNameText_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpIxx1ClientRuntimeInfoWsNameText
    /// Domain: Text
    /// Length: 10
    /// Varying Length: N
    /// </summary>
    private string _ExpIxx1ClientRuntimeInfoWsNameText;
    /// <summary>
    /// Attribute for: ExpIxx1ClientRuntimeInfoWsNameText
    /// </summary>
    public string ExpIxx1ClientRuntimeInfoWsNameText {
      get {
        return(_ExpIxx1ClientRuntimeInfoWsNameText);
      }
      set {
        _ExpIxx1ClientRuntimeInfoWsNameText = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpIxx1ClientRuntimeInfoWsIpAddrText
    /// </summary>
    private char _ExpIxx1ClientRuntimeInfoWsIpAddrText_AS;
    /// <summary>
    /// Attribute missing flag for: ExpIxx1ClientRuntimeInfoWsIpAddrText
    /// </summary>
    public char ExpIxx1ClientRuntimeInfoWsIpAddrText_AS {
      get {
        return(_ExpIxx1ClientRuntimeInfoWsIpAddrText_AS);
      }
      set {
        _ExpIxx1ClientRuntimeInfoWsIpAddrText_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpIxx1ClientRuntimeInfoWsIpAddrText
    /// Domain: Text
    /// Length: 15
    /// Varying Length: N
    /// </summary>
    private string _ExpIxx1ClientRuntimeInfoWsIpAddrText;
    /// <summary>
    /// Attribute for: ExpIxx1ClientRuntimeInfoWsIpAddrText
    /// </summary>
    public string ExpIxx1ClientRuntimeInfoWsIpAddrText {
      get {
        return(_ExpIxx1ClientRuntimeInfoWsIpAddrText);
      }
      set {
        _ExpIxx1ClientRuntimeInfoWsIpAddrText = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpIxx1ClientRuntimeInfoWsLocalTs
    /// </summary>
    private char _ExpIxx1ClientRuntimeInfoWsLocalTs_AS;
    /// <summary>
    /// Attribute missing flag for: ExpIxx1ClientRuntimeInfoWsLocalTs
    /// </summary>
    public char ExpIxx1ClientRuntimeInfoWsLocalTs_AS {
      get {
        return(_ExpIxx1ClientRuntimeInfoWsLocalTs_AS);
      }
      set {
        _ExpIxx1ClientRuntimeInfoWsLocalTs_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpIxx1ClientRuntimeInfoWsLocalTs
    /// Domain: Timestamp
    /// Length: 20
    /// </summary>
    private string _ExpIxx1ClientRuntimeInfoWsLocalTs;
    /// <summary>
    /// Attribute for: ExpIxx1ClientRuntimeInfoWsLocalTs
    /// </summary>
    public string ExpIxx1ClientRuntimeInfoWsLocalTs {
      get {
        return(_ExpIxx1ClientRuntimeInfoWsLocalTs);
      }
      set {
        _ExpIxx1ClientRuntimeInfoWsLocalTs = value;
      }
    }
    /// <summary>
    /// Default Constructor
    /// </summary>
    
    public IXX10002_OA(  )
    {
      Reset(  );
    }
    /// <summary>
    /// Copy Constructor
    /// </summary>
    
    public IXX10002_OA( IXX10002_OA orig )
    {
      ExpIxx1ClientRuntimeInfoTokenText_AS = orig.ExpIxx1ClientRuntimeInfoTokenText_AS;
      ExpIxx1ClientRuntimeInfoTokenText = orig.ExpIxx1ClientRuntimeInfoTokenText;
      ExpIxx1ClientRuntimeInfoWsNameText_AS = orig.ExpIxx1ClientRuntimeInfoWsNameText_AS;
      ExpIxx1ClientRuntimeInfoWsNameText = orig.ExpIxx1ClientRuntimeInfoWsNameText;
      ExpIxx1ClientRuntimeInfoWsIpAddrText_AS = orig.ExpIxx1ClientRuntimeInfoWsIpAddrText_AS;
      ExpIxx1ClientRuntimeInfoWsIpAddrText = orig.ExpIxx1ClientRuntimeInfoWsIpAddrText;
      ExpIxx1ClientRuntimeInfoWsLocalTs_AS = orig.ExpIxx1ClientRuntimeInfoWsLocalTs_AS;
      ExpIxx1ClientRuntimeInfoWsLocalTs = orig.ExpIxx1ClientRuntimeInfoWsLocalTs;
    }
    /// <summary>
    /// Static instance creator function
    /// </summary>
    
    public static IXX10002_OA GetInstance(  )
    {
      if ( countFree == 0 )
      {
        return(new IXX10002_OA());
      }
      else 
      {
        lock (freeArray)
        {
          if ( countFree == 0 )
          {
            return(new IXX10002_OA());
          }
          else 
          {
            IXX10002_OA result = freeArray[--countFree];
            freeArray[countFree] = null;
            result.Reset(  );
            return(result);
          }
        }
      }
    }
    /// <summary>
    /// Static free instance method
    /// </summary>
    
    public void FreeInstance(  )
    {
      lock (freeArray)
      {
        if ( countFree < freeArray.Length )
        {
          freeArray[countFree++] = this;
        }
      }
    }
    /// <summary>
    /// clone constructor
    /// </summary>
    
    public override Object Clone(  )
    {
      return(new IXX10002_OA(this));
    }
    /// <summary>
    /// Resets all properties to the defaults.
    /// </summary>
    
    public void Reset(  )
    {
      ExpIxx1ClientRuntimeInfoTokenText_AS = ' ';
      ExpIxx1ClientRuntimeInfoTokenText = "                                ";
      ExpIxx1ClientRuntimeInfoWsNameText_AS = ' ';
      ExpIxx1ClientRuntimeInfoWsNameText = "          ";
      ExpIxx1ClientRuntimeInfoWsIpAddrText_AS = ' ';
      ExpIxx1ClientRuntimeInfoWsIpAddrText = "               ";
      ExpIxx1ClientRuntimeInfoWsLocalTs_AS = ' ';
      ExpIxx1ClientRuntimeInfoWsLocalTs = "00000000000000000000";
    }
    /// <summary>
    /// Sets the current state of the instance to the VDF version.
    /// </summary>
    public void SetFromVDF( VDF vdf )
    {
      throw new Exception("can only execute SetFromVDF for a Procedure Step.");
    }
    
    /// <summary>
    /// Gets the VDF version of the current state of the instance.
    /// </summary>
    public VDF GetVDF(  )
    {
      throw new Exception("can only execute GetVDF for a Procedure Step.");
    }
    
    /// <summary>
    /// Sets the current instance based on the passed view.
    /// </summary>
    public void CopyFrom( IExportView orig )
    {
      this.CopyFrom((IXX10002_OA) orig);
    }
    
    /// <summary>
    /// Sets the current instance based on the passed view.
    /// </summary>
    public void CopyFrom( IXX10002_OA orig )
    {
      ExpIxx1ClientRuntimeInfoTokenText_AS = orig.ExpIxx1ClientRuntimeInfoTokenText_AS;
      ExpIxx1ClientRuntimeInfoTokenText = orig.ExpIxx1ClientRuntimeInfoTokenText;
      ExpIxx1ClientRuntimeInfoWsNameText_AS = orig.ExpIxx1ClientRuntimeInfoWsNameText_AS;
      ExpIxx1ClientRuntimeInfoWsNameText = orig.ExpIxx1ClientRuntimeInfoWsNameText;
      ExpIxx1ClientRuntimeInfoWsIpAddrText_AS = orig.ExpIxx1ClientRuntimeInfoWsIpAddrText_AS;
      ExpIxx1ClientRuntimeInfoWsIpAddrText = orig.ExpIxx1ClientRuntimeInfoWsIpAddrText;
      ExpIxx1ClientRuntimeInfoWsLocalTs_AS = orig.ExpIxx1ClientRuntimeInfoWsLocalTs_AS;
      ExpIxx1ClientRuntimeInfoWsLocalTs = orig.ExpIxx1ClientRuntimeInfoWsLocalTs;
    }
  }
}
