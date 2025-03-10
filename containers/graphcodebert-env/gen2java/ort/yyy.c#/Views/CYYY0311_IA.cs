// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
//
//                    Source Code Generated by
//                           CA Gen 8.6
//
//    Copyright (c) 2024 CA Technologies. All rights reserved.
//
//    Name: CYYY0311_IA                      Date: 2024/01/09
//    User: AliAl                            Time: 13:40:26
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
  /// Internal data view storage for: CYYY0311_IA
  /// </summary>
  [Serializable]
  public class CYYY0311_IA : ViewBase, IImportView
  {
    private static CYYY0311_IA[] freeArray = new CYYY0311_IA[30];
    private static int countFree = 0;
    
    // Entity View: IMP_REFERENCE
    //        Type: IYY1_SERVER_DATA
    /// <summary>
    /// Internal storage for attribute missing flag for: ImpReferenceIyy1ServerDataUserid
    /// </summary>
    private char _ImpReferenceIyy1ServerDataUserid_AS;
    /// <summary>
    /// Attribute missing flag for: ImpReferenceIyy1ServerDataUserid
    /// </summary>
    public char ImpReferenceIyy1ServerDataUserid_AS {
      get {
        return(_ImpReferenceIyy1ServerDataUserid_AS);
      }
      set {
        _ImpReferenceIyy1ServerDataUserid_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ImpReferenceIyy1ServerDataUserid
    /// Domain: Text
    /// Length: 8
    /// Varying Length: N
    /// </summary>
    private string _ImpReferenceIyy1ServerDataUserid;
    /// <summary>
    /// Attribute for: ImpReferenceIyy1ServerDataUserid
    /// </summary>
    public string ImpReferenceIyy1ServerDataUserid {
      get {
        return(_ImpReferenceIyy1ServerDataUserid);
      }
      set {
        _ImpReferenceIyy1ServerDataUserid = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ImpReferenceIyy1ServerDataReferenceId
    /// </summary>
    private char _ImpReferenceIyy1ServerDataReferenceId_AS;
    /// <summary>
    /// Attribute missing flag for: ImpReferenceIyy1ServerDataReferenceId
    /// </summary>
    public char ImpReferenceIyy1ServerDataReferenceId_AS {
      get {
        return(_ImpReferenceIyy1ServerDataReferenceId_AS);
      }
      set {
        _ImpReferenceIyy1ServerDataReferenceId_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ImpReferenceIyy1ServerDataReferenceId
    /// Domain: Timestamp
    /// Length: 20
    /// </summary>
    private string _ImpReferenceIyy1ServerDataReferenceId;
    /// <summary>
    /// Attribute for: ImpReferenceIyy1ServerDataReferenceId
    /// </summary>
    public string ImpReferenceIyy1ServerDataReferenceId {
      get {
        return(_ImpReferenceIyy1ServerDataReferenceId);
      }
      set {
        _ImpReferenceIyy1ServerDataReferenceId = value;
      }
    }
    // Entity View: IMP
    //        Type: TYPE
    /// <summary>
    /// Internal storage for attribute missing flag for: ImpTypeTkeyAttrText
    /// </summary>
    private char _ImpTypeTkeyAttrText_AS;
    /// <summary>
    /// Attribute missing flag for: ImpTypeTkeyAttrText
    /// </summary>
    public char ImpTypeTkeyAttrText_AS {
      get {
        return(_ImpTypeTkeyAttrText_AS);
      }
      set {
        _ImpTypeTkeyAttrText_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ImpTypeTkeyAttrText
    /// Domain: Text
    /// Length: 4
    /// Varying Length: N
    /// </summary>
    private string _ImpTypeTkeyAttrText;
    /// <summary>
    /// Attribute for: ImpTypeTkeyAttrText
    /// </summary>
    public string ImpTypeTkeyAttrText {
      get {
        return(_ImpTypeTkeyAttrText);
      }
      set {
        _ImpTypeTkeyAttrText = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ImpTypeTsearchAttrText
    /// </summary>
    private char _ImpTypeTsearchAttrText_AS;
    /// <summary>
    /// Attribute missing flag for: ImpTypeTsearchAttrText
    /// </summary>
    public char ImpTypeTsearchAttrText_AS {
      get {
        return(_ImpTypeTsearchAttrText_AS);
      }
      set {
        _ImpTypeTsearchAttrText_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ImpTypeTsearchAttrText
    /// Domain: Text
    /// Length: 20
    /// Varying Length: N
    /// </summary>
    private string _ImpTypeTsearchAttrText;
    /// <summary>
    /// Attribute for: ImpTypeTsearchAttrText
    /// </summary>
    public string ImpTypeTsearchAttrText {
      get {
        return(_ImpTypeTsearchAttrText);
      }
      set {
        _ImpTypeTsearchAttrText = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ImpTypeTotherAttrText
    /// </summary>
    private char _ImpTypeTotherAttrText_AS;
    /// <summary>
    /// Attribute missing flag for: ImpTypeTotherAttrText
    /// </summary>
    public char ImpTypeTotherAttrText_AS {
      get {
        return(_ImpTypeTotherAttrText_AS);
      }
      set {
        _ImpTypeTotherAttrText_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ImpTypeTotherAttrText
    /// Domain: Text
    /// Length: 2
    /// Varying Length: N
    /// </summary>
    private string _ImpTypeTotherAttrText;
    /// <summary>
    /// Attribute for: ImpTypeTotherAttrText
    /// </summary>
    public string ImpTypeTotherAttrText {
      get {
        return(_ImpTypeTotherAttrText);
      }
      set {
        _ImpTypeTotherAttrText = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ImpTypeTotherAttrDate
    /// </summary>
    private char _ImpTypeTotherAttrDate_AS;
    /// <summary>
    /// Attribute missing flag for: ImpTypeTotherAttrDate
    /// </summary>
    public char ImpTypeTotherAttrDate_AS {
      get {
        return(_ImpTypeTotherAttrDate_AS);
      }
      set {
        _ImpTypeTotherAttrDate_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ImpTypeTotherAttrDate
    /// Domain: Date
    /// Length: 8
    /// </summary>
    private int _ImpTypeTotherAttrDate;
    /// <summary>
    /// Attribute for: ImpTypeTotherAttrDate
    /// </summary>
    public int ImpTypeTotherAttrDate {
      get {
        return(_ImpTypeTotherAttrDate);
      }
      set {
        _ImpTypeTotherAttrDate = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ImpTypeTotherAttrTime
    /// </summary>
    private char _ImpTypeTotherAttrTime_AS;
    /// <summary>
    /// Attribute missing flag for: ImpTypeTotherAttrTime
    /// </summary>
    public char ImpTypeTotherAttrTime_AS {
      get {
        return(_ImpTypeTotherAttrTime_AS);
      }
      set {
        _ImpTypeTotherAttrTime_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ImpTypeTotherAttrTime
    /// Domain: Time
    /// Length: 6
    /// </summary>
    private int _ImpTypeTotherAttrTime;
    /// <summary>
    /// Attribute for: ImpTypeTotherAttrTime
    /// </summary>
    public int ImpTypeTotherAttrTime {
      get {
        return(_ImpTypeTotherAttrTime);
      }
      set {
        _ImpTypeTotherAttrTime = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ImpTypeTotherAttrAmount
    /// </summary>
    private char _ImpTypeTotherAttrAmount_AS;
    /// <summary>
    /// Attribute missing flag for: ImpTypeTotherAttrAmount
    /// </summary>
    public char ImpTypeTotherAttrAmount_AS {
      get {
        return(_ImpTypeTotherAttrAmount_AS);
      }
      set {
        _ImpTypeTotherAttrAmount_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ImpTypeTotherAttrAmount
    /// Domain: Number
    /// Length: 17
    /// Decimal Places: 2
    /// Decimal Precision: Y
    /// </summary>
    private decimal _ImpTypeTotherAttrAmount;
    /// <summary>
    /// Attribute for: ImpTypeTotherAttrAmount
    /// </summary>
    public decimal ImpTypeTotherAttrAmount {
      get {
        return(_ImpTypeTotherAttrAmount);
      }
      set {
        _ImpTypeTotherAttrAmount = value;
      }
    }
    /// <summary>
    /// Default Constructor
    /// </summary>
    
    public CYYY0311_IA(  )
    {
      Reset(  );
    }
    /// <summary>
    /// Copy Constructor
    /// </summary>
    
    public CYYY0311_IA( CYYY0311_IA orig )
    {
      ImpReferenceIyy1ServerDataUserid_AS = orig.ImpReferenceIyy1ServerDataUserid_AS;
      ImpReferenceIyy1ServerDataUserid = orig.ImpReferenceIyy1ServerDataUserid;
      ImpReferenceIyy1ServerDataReferenceId_AS = orig.ImpReferenceIyy1ServerDataReferenceId_AS;
      ImpReferenceIyy1ServerDataReferenceId = orig.ImpReferenceIyy1ServerDataReferenceId;
      ImpTypeTkeyAttrText_AS = orig.ImpTypeTkeyAttrText_AS;
      ImpTypeTkeyAttrText = orig.ImpTypeTkeyAttrText;
      ImpTypeTsearchAttrText_AS = orig.ImpTypeTsearchAttrText_AS;
      ImpTypeTsearchAttrText = orig.ImpTypeTsearchAttrText;
      ImpTypeTotherAttrText_AS = orig.ImpTypeTotherAttrText_AS;
      ImpTypeTotherAttrText = orig.ImpTypeTotherAttrText;
      ImpTypeTotherAttrDate_AS = orig.ImpTypeTotherAttrDate_AS;
      ImpTypeTotherAttrDate = orig.ImpTypeTotherAttrDate;
      ImpTypeTotherAttrTime_AS = orig.ImpTypeTotherAttrTime_AS;
      ImpTypeTotherAttrTime = orig.ImpTypeTotherAttrTime;
      ImpTypeTotherAttrAmount_AS = orig.ImpTypeTotherAttrAmount_AS;
      ImpTypeTotherAttrAmount = orig.ImpTypeTotherAttrAmount;
    }
    /// <summary>
    /// Static instance creator function
    /// </summary>
    
    public static CYYY0311_IA GetInstance(  )
    {
      if ( countFree == 0 )
      {
        return(new CYYY0311_IA());
      }
      else 
      {
        lock (freeArray)
        {
          if ( countFree == 0 )
          {
            return(new CYYY0311_IA());
          }
          else 
          {
            CYYY0311_IA result = freeArray[--countFree];
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
      return(new CYYY0311_IA(this));
    }
    /// <summary>
    /// Resets all properties to the defaults.
    /// </summary>
    
    public void Reset(  )
    {
      ImpReferenceIyy1ServerDataUserid_AS = ' ';
      ImpReferenceIyy1ServerDataUserid = "        ";
      ImpReferenceIyy1ServerDataReferenceId_AS = ' ';
      ImpReferenceIyy1ServerDataReferenceId = "00000000000000000000";
      ImpTypeTkeyAttrText_AS = ' ';
      ImpTypeTkeyAttrText = "    ";
      ImpTypeTsearchAttrText_AS = ' ';
      ImpTypeTsearchAttrText = "                    ";
      ImpTypeTotherAttrText_AS = ' ';
      ImpTypeTotherAttrText = "  ";
      ImpTypeTotherAttrDate_AS = ' ';
      ImpTypeTotherAttrDate = 00000000;
      ImpTypeTotherAttrTime_AS = ' ';
      ImpTypeTotherAttrTime = 00000000;
      ImpTypeTotherAttrAmount_AS = ' ';
      ImpTypeTotherAttrAmount = DecimalAttr.GetDefaultValue();
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
      this.CopyFrom((CYYY0311_IA) orig);
    }
    
    /// <summary>
    /// Sets the current instance based on the passed view.
    /// </summary>
    public void CopyFrom( CYYY0311_IA orig )
    {
      ImpReferenceIyy1ServerDataUserid_AS = orig.ImpReferenceIyy1ServerDataUserid_AS;
      ImpReferenceIyy1ServerDataUserid = orig.ImpReferenceIyy1ServerDataUserid;
      ImpReferenceIyy1ServerDataReferenceId_AS = orig.ImpReferenceIyy1ServerDataReferenceId_AS;
      ImpReferenceIyy1ServerDataReferenceId = orig.ImpReferenceIyy1ServerDataReferenceId;
      ImpTypeTkeyAttrText_AS = orig.ImpTypeTkeyAttrText_AS;
      ImpTypeTkeyAttrText = orig.ImpTypeTkeyAttrText;
      ImpTypeTsearchAttrText_AS = orig.ImpTypeTsearchAttrText_AS;
      ImpTypeTsearchAttrText = orig.ImpTypeTsearchAttrText;
      ImpTypeTotherAttrText_AS = orig.ImpTypeTotherAttrText_AS;
      ImpTypeTotherAttrText = orig.ImpTypeTotherAttrText;
      ImpTypeTotherAttrDate_AS = orig.ImpTypeTotherAttrDate_AS;
      ImpTypeTotherAttrDate = orig.ImpTypeTotherAttrDate;
      ImpTypeTotherAttrTime_AS = orig.ImpTypeTotherAttrTime_AS;
      ImpTypeTotherAttrTime = orig.ImpTypeTotherAttrTime;
      ImpTypeTotherAttrAmount_AS = orig.ImpTypeTotherAttrAmount_AS;
      ImpTypeTotherAttrAmount = orig.ImpTypeTotherAttrAmount;
    }
  }
}
