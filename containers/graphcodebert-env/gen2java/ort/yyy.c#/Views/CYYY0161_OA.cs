// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
//
//                    Source Code Generated by
//                           CA Gen 8.6
//
//    Copyright (c) 2024 CA Technologies. All rights reserved.
//
//    Name: CYYY0161_OA                      Date: 2024/01/09
//    User: AliAl                            Time: 13:40:51
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
  /// Internal data view storage for: CYYY0161_OA
  /// </summary>
  [Serializable]
  public class CYYY0161_OA : ViewBase, IExportView
  {
    private static CYYY0161_OA[] freeArray = new CYYY0161_OA[30];
    private static int countFree = 0;
    
    // Entity View: EXP
    //        Type: PARENT
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpParentPinstanceId
    /// </summary>
    private char _ExpParentPinstanceId_AS;
    /// <summary>
    /// Attribute missing flag for: ExpParentPinstanceId
    /// </summary>
    public char ExpParentPinstanceId_AS {
      get {
        return(_ExpParentPinstanceId_AS);
      }
      set {
        _ExpParentPinstanceId_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpParentPinstanceId
    /// Domain: Timestamp
    /// Length: 20
    /// </summary>
    private string _ExpParentPinstanceId;
    /// <summary>
    /// Attribute for: ExpParentPinstanceId
    /// </summary>
    public string ExpParentPinstanceId {
      get {
        return(_ExpParentPinstanceId);
      }
      set {
        _ExpParentPinstanceId = value;
      }
    }
    /// <summary>
    /// Default Constructor
    /// </summary>
    
    public CYYY0161_OA(  )
    {
      Reset(  );
    }
    /// <summary>
    /// Copy Constructor
    /// </summary>
    
    public CYYY0161_OA( CYYY0161_OA orig )
    {
      ExpParentPinstanceId_AS = orig.ExpParentPinstanceId_AS;
      ExpParentPinstanceId = orig.ExpParentPinstanceId;
    }
    /// <summary>
    /// Static instance creator function
    /// </summary>
    
    public static CYYY0161_OA GetInstance(  )
    {
      if ( countFree == 0 )
      {
        return(new CYYY0161_OA());
      }
      else 
      {
        lock (freeArray)
        {
          if ( countFree == 0 )
          {
            return(new CYYY0161_OA());
          }
          else 
          {
            CYYY0161_OA result = freeArray[--countFree];
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
      return(new CYYY0161_OA(this));
    }
    /// <summary>
    /// Resets all properties to the defaults.
    /// </summary>
    
    public void Reset(  )
    {
      ExpParentPinstanceId_AS = ' ';
      ExpParentPinstanceId = "00000000000000000000";
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
      this.CopyFrom((CYYY0161_OA) orig);
    }
    
    /// <summary>
    /// Sets the current instance based on the passed view.
    /// </summary>
    public void CopyFrom( CYYY0161_OA orig )
    {
      ExpParentPinstanceId_AS = orig.ExpParentPinstanceId_AS;
      ExpParentPinstanceId = orig.ExpParentPinstanceId;
    }
  }
}
