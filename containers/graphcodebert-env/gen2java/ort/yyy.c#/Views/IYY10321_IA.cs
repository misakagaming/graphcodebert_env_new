// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
//
//                    Source Code Generated by
//                           CA Gen 8.6
//
//    Copyright (c) 2024 CA Technologies. All rights reserved.
//
//    Name: IYY10321_IA                      Date: 2024/01/09
//    User: AliAl                            Time: 13:40:17
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
// START OF IMPORT VIEW
// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
namespace GEN.ORT.YYY
{
  /// <summary>
  /// Internal data view storage for: IYY10321_IA
  /// </summary>
  [Serializable]
  public class IYY10321_IA : ViewBase, IImportView
  {
    private static IYY10321_IA[] freeArray = new IYY10321_IA[30];
    private static int countFree = 0;
    
    // Entity View: IMP
    //        Type: IYY1_TYPE
    /// <summary>
    /// Internal storage for attribute missing flag for: ImpIyy1TypeTinstanceId
    /// </summary>
    private char _ImpIyy1TypeTinstanceId_AS;
    /// <summary>
    /// Attribute missing flag for: ImpIyy1TypeTinstanceId
    /// </summary>
    public char ImpIyy1TypeTinstanceId_AS {
      get {
        return(_ImpIyy1TypeTinstanceId_AS);
      }
      set {
        _ImpIyy1TypeTinstanceId_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ImpIyy1TypeTinstanceId
    /// Domain: Timestamp
    /// Length: 20
    /// </summary>
    private string _ImpIyy1TypeTinstanceId;
    /// <summary>
    /// Attribute for: ImpIyy1TypeTinstanceId
    /// </summary>
    public string ImpIyy1TypeTinstanceId {
      get {
        return(_ImpIyy1TypeTinstanceId);
      }
      set {
        _ImpIyy1TypeTinstanceId = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ImpIyy1TypeTkeyAttrText
    /// </summary>
    private char _ImpIyy1TypeTkeyAttrText_AS;
    /// <summary>
    /// Attribute missing flag for: ImpIyy1TypeTkeyAttrText
    /// </summary>
    public char ImpIyy1TypeTkeyAttrText_AS {
      get {
        return(_ImpIyy1TypeTkeyAttrText_AS);
      }
      set {
        _ImpIyy1TypeTkeyAttrText_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ImpIyy1TypeTkeyAttrText
    /// Domain: Text
    /// Length: 4
    /// Varying Length: N
    /// </summary>
    private string _ImpIyy1TypeTkeyAttrText;
    /// <summary>
    /// Attribute for: ImpIyy1TypeTkeyAttrText
    /// </summary>
    public string ImpIyy1TypeTkeyAttrText {
      get {
        return(_ImpIyy1TypeTkeyAttrText);
      }
      set {
        _ImpIyy1TypeTkeyAttrText = value;
      }
    }
    /// <summary>
    /// Default Constructor
    /// </summary>
    
    public IYY10321_IA(  )
    {
      Reset(  );
    }
    /// <summary>
    /// Copy Constructor
    /// </summary>
    
    public IYY10321_IA( IYY10321_IA orig )
    {
      ImpIyy1TypeTinstanceId_AS = orig.ImpIyy1TypeTinstanceId_AS;
      ImpIyy1TypeTinstanceId = orig.ImpIyy1TypeTinstanceId;
      ImpIyy1TypeTkeyAttrText_AS = orig.ImpIyy1TypeTkeyAttrText_AS;
      ImpIyy1TypeTkeyAttrText = orig.ImpIyy1TypeTkeyAttrText;
    }
    /// <summary>
    /// Static instance creator function
    /// </summary>
    
    public static IYY10321_IA GetInstance(  )
    {
      if ( countFree == 0 )
      {
        return(new IYY10321_IA());
      }
      else 
      {
        lock (freeArray)
        {
          if ( countFree == 0 )
          {
            return(new IYY10321_IA());
          }
          else 
          {
            IYY10321_IA result = freeArray[--countFree];
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
      return(new IYY10321_IA(this));
    }
    /// <summary>
    /// Resets all properties to the defaults.
    /// </summary>
    
    public void Reset(  )
    {
      ImpIyy1TypeTinstanceId_AS = ' ';
      ImpIyy1TypeTinstanceId = "00000000000000000000";
      ImpIyy1TypeTkeyAttrText_AS = ' ';
      ImpIyy1TypeTkeyAttrText = "    ";
    }
    /// <summary>
    /// Gets the VDF version of the current state of the instance.
    /// </summary>
    public VDF GetVDF(  )
    {
      throw new Exception("can only execute GetVDF for a Procedure Step.");
    }
    
    /// <summary>
    /// Sets the current state of the instance to the VDF version.
    /// </summary>
    public void SetFromVDF( VDF vdf )
    {
      throw new Exception("can only execute SetFromVDF for a Procedure Step.");
    }
    
    /// <summary>
    /// Sets the current instance based on the passed view.
    /// </summary>
    public void CopyFrom( IImportView orig )
    {
      this.CopyFrom((IYY10321_IA) orig);
    }
    
    /// <summary>
    /// Sets the current instance based on the passed view.
    /// </summary>
    public void CopyFrom( IYY10321_IA orig )
    {
      ImpIyy1TypeTinstanceId_AS = orig.ImpIyy1TypeTinstanceId_AS;
      ImpIyy1TypeTinstanceId = orig.ImpIyy1TypeTinstanceId;
      ImpIyy1TypeTkeyAttrText_AS = orig.ImpIyy1TypeTkeyAttrText_AS;
      ImpIyy1TypeTkeyAttrText = orig.ImpIyy1TypeTkeyAttrText;
    }
  }
}
