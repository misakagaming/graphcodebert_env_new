// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
//
//                    Source Code Generated by
//                           CA Gen 8.6
//
//    Copyright (c) 2024 CA Technologies. All rights reserved.
//
//    Name: MYY10321_LA                      Date: 2024/01/09
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
// START OF LOCAL VIEW
// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
namespace GEN.ORT.YYY
{
  /// <summary>
  /// Internal data view storage for: MYY10321_LA
  /// </summary>
  [Serializable]
  public class MYY10321_LA : ViewBase, ILocalView
  {
    private static MYY10321_LA[] freeArray = new MYY10321_LA[30];
    private static int countFree = 0;
    
    // Entity View: LOC_IMP
    //        Type: TYPE
    /// <summary>
    /// Internal storage for attribute missing flag for: LocImpTypeTinstanceId
    /// </summary>
    private char _LocImpTypeTinstanceId_AS;
    /// <summary>
    /// Attribute missing flag for: LocImpTypeTinstanceId
    /// </summary>
    public char LocImpTypeTinstanceId_AS {
      get {
        return(_LocImpTypeTinstanceId_AS);
      }
      set {
        _LocImpTypeTinstanceId_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocImpTypeTinstanceId
    /// Domain: Timestamp
    /// Length: 20
    /// </summary>
    private string _LocImpTypeTinstanceId;
    /// <summary>
    /// Attribute for: LocImpTypeTinstanceId
    /// </summary>
    public string LocImpTypeTinstanceId {
      get {
        return(_LocImpTypeTinstanceId);
      }
      set {
        _LocImpTypeTinstanceId = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocImpTypeTkeyAttrText
    /// </summary>
    private char _LocImpTypeTkeyAttrText_AS;
    /// <summary>
    /// Attribute missing flag for: LocImpTypeTkeyAttrText
    /// </summary>
    public char LocImpTypeTkeyAttrText_AS {
      get {
        return(_LocImpTypeTkeyAttrText_AS);
      }
      set {
        _LocImpTypeTkeyAttrText_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocImpTypeTkeyAttrText
    /// Domain: Text
    /// Length: 4
    /// Varying Length: N
    /// </summary>
    private string _LocImpTypeTkeyAttrText;
    /// <summary>
    /// Attribute for: LocImpTypeTkeyAttrText
    /// </summary>
    public string LocImpTypeTkeyAttrText {
      get {
        return(_LocImpTypeTkeyAttrText);
      }
      set {
        _LocImpTypeTkeyAttrText = value;
      }
    }
    // Entity View: LOC_EXP
    //        Type: TYPE
    /// <summary>
    /// Internal storage for attribute missing flag for: LocExpTypeTinstanceId
    /// </summary>
    private char _LocExpTypeTinstanceId_AS;
    /// <summary>
    /// Attribute missing flag for: LocExpTypeTinstanceId
    /// </summary>
    public char LocExpTypeTinstanceId_AS {
      get {
        return(_LocExpTypeTinstanceId_AS);
      }
      set {
        _LocExpTypeTinstanceId_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocExpTypeTinstanceId
    /// Domain: Timestamp
    /// Length: 20
    /// </summary>
    private string _LocExpTypeTinstanceId;
    /// <summary>
    /// Attribute for: LocExpTypeTinstanceId
    /// </summary>
    public string LocExpTypeTinstanceId {
      get {
        return(_LocExpTypeTinstanceId);
      }
      set {
        _LocExpTypeTinstanceId = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocExpTypeTreferenceId
    /// </summary>
    private char _LocExpTypeTreferenceId_AS;
    /// <summary>
    /// Attribute missing flag for: LocExpTypeTreferenceId
    /// </summary>
    public char LocExpTypeTreferenceId_AS {
      get {
        return(_LocExpTypeTreferenceId_AS);
      }
      set {
        _LocExpTypeTreferenceId_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocExpTypeTreferenceId
    /// Domain: Timestamp
    /// Length: 20
    /// </summary>
    private string _LocExpTypeTreferenceId;
    /// <summary>
    /// Attribute for: LocExpTypeTreferenceId
    /// </summary>
    public string LocExpTypeTreferenceId {
      get {
        return(_LocExpTypeTreferenceId);
      }
      set {
        _LocExpTypeTreferenceId = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocExpTypeTcreateUserId
    /// </summary>
    private char _LocExpTypeTcreateUserId_AS;
    /// <summary>
    /// Attribute missing flag for: LocExpTypeTcreateUserId
    /// </summary>
    public char LocExpTypeTcreateUserId_AS {
      get {
        return(_LocExpTypeTcreateUserId_AS);
      }
      set {
        _LocExpTypeTcreateUserId_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocExpTypeTcreateUserId
    /// Domain: Text
    /// Length: 8
    /// Varying Length: N
    /// </summary>
    private string _LocExpTypeTcreateUserId;
    /// <summary>
    /// Attribute for: LocExpTypeTcreateUserId
    /// </summary>
    public string LocExpTypeTcreateUserId {
      get {
        return(_LocExpTypeTcreateUserId);
      }
      set {
        _LocExpTypeTcreateUserId = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocExpTypeTupdateUserId
    /// </summary>
    private char _LocExpTypeTupdateUserId_AS;
    /// <summary>
    /// Attribute missing flag for: LocExpTypeTupdateUserId
    /// </summary>
    public char LocExpTypeTupdateUserId_AS {
      get {
        return(_LocExpTypeTupdateUserId_AS);
      }
      set {
        _LocExpTypeTupdateUserId_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocExpTypeTupdateUserId
    /// Domain: Text
    /// Length: 8
    /// Varying Length: N
    /// </summary>
    private string _LocExpTypeTupdateUserId;
    /// <summary>
    /// Attribute for: LocExpTypeTupdateUserId
    /// </summary>
    public string LocExpTypeTupdateUserId {
      get {
        return(_LocExpTypeTupdateUserId);
      }
      set {
        _LocExpTypeTupdateUserId = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocExpTypeTkeyAttrText
    /// </summary>
    private char _LocExpTypeTkeyAttrText_AS;
    /// <summary>
    /// Attribute missing flag for: LocExpTypeTkeyAttrText
    /// </summary>
    public char LocExpTypeTkeyAttrText_AS {
      get {
        return(_LocExpTypeTkeyAttrText_AS);
      }
      set {
        _LocExpTypeTkeyAttrText_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocExpTypeTkeyAttrText
    /// Domain: Text
    /// Length: 4
    /// Varying Length: N
    /// </summary>
    private string _LocExpTypeTkeyAttrText;
    /// <summary>
    /// Attribute for: LocExpTypeTkeyAttrText
    /// </summary>
    public string LocExpTypeTkeyAttrText {
      get {
        return(_LocExpTypeTkeyAttrText);
      }
      set {
        _LocExpTypeTkeyAttrText = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocExpTypeTsearchAttrText
    /// </summary>
    private char _LocExpTypeTsearchAttrText_AS;
    /// <summary>
    /// Attribute missing flag for: LocExpTypeTsearchAttrText
    /// </summary>
    public char LocExpTypeTsearchAttrText_AS {
      get {
        return(_LocExpTypeTsearchAttrText_AS);
      }
      set {
        _LocExpTypeTsearchAttrText_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocExpTypeTsearchAttrText
    /// Domain: Text
    /// Length: 20
    /// Varying Length: N
    /// </summary>
    private string _LocExpTypeTsearchAttrText;
    /// <summary>
    /// Attribute for: LocExpTypeTsearchAttrText
    /// </summary>
    public string LocExpTypeTsearchAttrText {
      get {
        return(_LocExpTypeTsearchAttrText);
      }
      set {
        _LocExpTypeTsearchAttrText = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocExpTypeTotherAttrText
    /// </summary>
    private char _LocExpTypeTotherAttrText_AS;
    /// <summary>
    /// Attribute missing flag for: LocExpTypeTotherAttrText
    /// </summary>
    public char LocExpTypeTotherAttrText_AS {
      get {
        return(_LocExpTypeTotherAttrText_AS);
      }
      set {
        _LocExpTypeTotherAttrText_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocExpTypeTotherAttrText
    /// Domain: Text
    /// Length: 2
    /// Varying Length: N
    /// </summary>
    private string _LocExpTypeTotherAttrText;
    /// <summary>
    /// Attribute for: LocExpTypeTotherAttrText
    /// </summary>
    public string LocExpTypeTotherAttrText {
      get {
        return(_LocExpTypeTotherAttrText);
      }
      set {
        _LocExpTypeTotherAttrText = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocExpTypeTotherAttrDate
    /// </summary>
    private char _LocExpTypeTotherAttrDate_AS;
    /// <summary>
    /// Attribute missing flag for: LocExpTypeTotherAttrDate
    /// </summary>
    public char LocExpTypeTotherAttrDate_AS {
      get {
        return(_LocExpTypeTotherAttrDate_AS);
      }
      set {
        _LocExpTypeTotherAttrDate_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocExpTypeTotherAttrDate
    /// Domain: Date
    /// Length: 8
    /// </summary>
    private int _LocExpTypeTotherAttrDate;
    /// <summary>
    /// Attribute for: LocExpTypeTotherAttrDate
    /// </summary>
    public int LocExpTypeTotherAttrDate {
      get {
        return(_LocExpTypeTotherAttrDate);
      }
      set {
        _LocExpTypeTotherAttrDate = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocExpTypeTotherAttrTime
    /// </summary>
    private char _LocExpTypeTotherAttrTime_AS;
    /// <summary>
    /// Attribute missing flag for: LocExpTypeTotherAttrTime
    /// </summary>
    public char LocExpTypeTotherAttrTime_AS {
      get {
        return(_LocExpTypeTotherAttrTime_AS);
      }
      set {
        _LocExpTypeTotherAttrTime_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocExpTypeTotherAttrTime
    /// Domain: Time
    /// Length: 6
    /// </summary>
    private int _LocExpTypeTotherAttrTime;
    /// <summary>
    /// Attribute for: LocExpTypeTotherAttrTime
    /// </summary>
    public int LocExpTypeTotherAttrTime {
      get {
        return(_LocExpTypeTotherAttrTime);
      }
      set {
        _LocExpTypeTotherAttrTime = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocExpTypeTotherAttrAmount
    /// </summary>
    private char _LocExpTypeTotherAttrAmount_AS;
    /// <summary>
    /// Attribute missing flag for: LocExpTypeTotherAttrAmount
    /// </summary>
    public char LocExpTypeTotherAttrAmount_AS {
      get {
        return(_LocExpTypeTotherAttrAmount_AS);
      }
      set {
        _LocExpTypeTotherAttrAmount_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocExpTypeTotherAttrAmount
    /// Domain: Number
    /// Length: 17
    /// Decimal Places: 2
    /// Decimal Precision: Y
    /// </summary>
    private decimal _LocExpTypeTotherAttrAmount;
    /// <summary>
    /// Attribute for: LocExpTypeTotherAttrAmount
    /// </summary>
    public decimal LocExpTypeTotherAttrAmount {
      get {
        return(_LocExpTypeTotherAttrAmount);
      }
      set {
        _LocExpTypeTotherAttrAmount = value;
      }
    }
    /// <summary>
    /// Default Constructor
    /// </summary>
    
    public MYY10321_LA(  )
    {
      Reset(  );
    }
    /// <summary>
    /// Copy Constructor
    /// </summary>
    
    public MYY10321_LA( MYY10321_LA orig )
    {
      LocImpTypeTinstanceId_AS = orig.LocImpTypeTinstanceId_AS;
      LocImpTypeTinstanceId = orig.LocImpTypeTinstanceId;
      LocImpTypeTkeyAttrText_AS = orig.LocImpTypeTkeyAttrText_AS;
      LocImpTypeTkeyAttrText = orig.LocImpTypeTkeyAttrText;
      LocExpTypeTinstanceId_AS = orig.LocExpTypeTinstanceId_AS;
      LocExpTypeTinstanceId = orig.LocExpTypeTinstanceId;
      LocExpTypeTreferenceId_AS = orig.LocExpTypeTreferenceId_AS;
      LocExpTypeTreferenceId = orig.LocExpTypeTreferenceId;
      LocExpTypeTcreateUserId_AS = orig.LocExpTypeTcreateUserId_AS;
      LocExpTypeTcreateUserId = orig.LocExpTypeTcreateUserId;
      LocExpTypeTupdateUserId_AS = orig.LocExpTypeTupdateUserId_AS;
      LocExpTypeTupdateUserId = orig.LocExpTypeTupdateUserId;
      LocExpTypeTkeyAttrText_AS = orig.LocExpTypeTkeyAttrText_AS;
      LocExpTypeTkeyAttrText = orig.LocExpTypeTkeyAttrText;
      LocExpTypeTsearchAttrText_AS = orig.LocExpTypeTsearchAttrText_AS;
      LocExpTypeTsearchAttrText = orig.LocExpTypeTsearchAttrText;
      LocExpTypeTotherAttrText_AS = orig.LocExpTypeTotherAttrText_AS;
      LocExpTypeTotherAttrText = orig.LocExpTypeTotherAttrText;
      LocExpTypeTotherAttrDate_AS = orig.LocExpTypeTotherAttrDate_AS;
      LocExpTypeTotherAttrDate = orig.LocExpTypeTotherAttrDate;
      LocExpTypeTotherAttrTime_AS = orig.LocExpTypeTotherAttrTime_AS;
      LocExpTypeTotherAttrTime = orig.LocExpTypeTotherAttrTime;
      LocExpTypeTotherAttrAmount_AS = orig.LocExpTypeTotherAttrAmount_AS;
      LocExpTypeTotherAttrAmount = orig.LocExpTypeTotherAttrAmount;
    }
    /// <summary>
    /// Static instance creator function
    /// </summary>
    
    public static MYY10321_LA GetInstance(  )
    {
      if ( countFree == 0 )
      {
        return(new MYY10321_LA());
      }
      else 
      {
        lock (freeArray)
        {
          if ( countFree == 0 )
          {
            return(new MYY10321_LA());
          }
          else 
          {
            MYY10321_LA result = freeArray[--countFree];
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
      return(new MYY10321_LA(this));
    }
    /// <summary>
    /// Resets all properties to the defaults.
    /// </summary>
    
    public void Reset(  )
    {
      LocImpTypeTinstanceId_AS = ' ';
      LocImpTypeTinstanceId = "00000000000000000000";
      LocImpTypeTkeyAttrText_AS = ' ';
      LocImpTypeTkeyAttrText = "    ";
      LocExpTypeTinstanceId_AS = ' ';
      LocExpTypeTinstanceId = "00000000000000000000";
      LocExpTypeTreferenceId_AS = ' ';
      LocExpTypeTreferenceId = "00000000000000000000";
      LocExpTypeTcreateUserId_AS = ' ';
      LocExpTypeTcreateUserId = "        ";
      LocExpTypeTupdateUserId_AS = ' ';
      LocExpTypeTupdateUserId = "        ";
      LocExpTypeTkeyAttrText_AS = ' ';
      LocExpTypeTkeyAttrText = "    ";
      LocExpTypeTsearchAttrText_AS = ' ';
      LocExpTypeTsearchAttrText = "                    ";
      LocExpTypeTotherAttrText_AS = ' ';
      LocExpTypeTotherAttrText = "  ";
      LocExpTypeTotherAttrDate_AS = ' ';
      LocExpTypeTotherAttrDate = 00000000;
      LocExpTypeTotherAttrTime_AS = ' ';
      LocExpTypeTotherAttrTime = 00000000;
      LocExpTypeTotherAttrAmount_AS = ' ';
      LocExpTypeTotherAttrAmount = DecimalAttr.GetDefaultValue();
    }
  }
}
