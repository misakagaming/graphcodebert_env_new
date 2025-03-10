// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
//
//                    Source Code Generated by
//                           CA Gen 8.6
//
//    Copyright (c) 2024 CA Technologies. All rights reserved.
//
//    Name: CYYY0341_LA                      Date: 2024/01/09
//    User: AliAl                            Time: 13:40:27
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
  /// Internal data view storage for: CYYY0341_LA
  /// </summary>
  [Serializable]
  public class CYYY0341_LA : ViewBase, ILocalView
  {
    private static CYYY0341_LA[] freeArray = new CYYY0341_LA[30];
    private static int countFree = 0;
    
    // Entity View: LOC_ERROR
    //        Type: IYY1_COMPONENT
    /// <summary>
    /// Internal storage for attribute missing flag for: LocErrorIyy1ComponentSeverityCode
    /// </summary>
    private char _LocErrorIyy1ComponentSeverityCode_AS;
    /// <summary>
    /// Attribute missing flag for: LocErrorIyy1ComponentSeverityCode
    /// </summary>
    public char LocErrorIyy1ComponentSeverityCode_AS {
      get {
        return(_LocErrorIyy1ComponentSeverityCode_AS);
      }
      set {
        _LocErrorIyy1ComponentSeverityCode_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocErrorIyy1ComponentSeverityCode
    /// Domain: Text
    /// Length: 1
    /// Varying Length: N
    /// </summary>
    private string _LocErrorIyy1ComponentSeverityCode;
    /// <summary>
    /// Attribute for: LocErrorIyy1ComponentSeverityCode
    /// </summary>
    public string LocErrorIyy1ComponentSeverityCode {
      get {
        return(_LocErrorIyy1ComponentSeverityCode);
      }
      set {
        _LocErrorIyy1ComponentSeverityCode = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocErrorIyy1ComponentRollbackIndicator
    /// </summary>
    private char _LocErrorIyy1ComponentRollbackIndicator_AS;
    /// <summary>
    /// Attribute missing flag for: LocErrorIyy1ComponentRollbackIndicator
    /// </summary>
    public char LocErrorIyy1ComponentRollbackIndicator_AS {
      get {
        return(_LocErrorIyy1ComponentRollbackIndicator_AS);
      }
      set {
        _LocErrorIyy1ComponentRollbackIndicator_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocErrorIyy1ComponentRollbackIndicator
    /// Domain: Text
    /// Length: 1
    /// Varying Length: N
    /// </summary>
    private string _LocErrorIyy1ComponentRollbackIndicator;
    /// <summary>
    /// Attribute for: LocErrorIyy1ComponentRollbackIndicator
    /// </summary>
    public string LocErrorIyy1ComponentRollbackIndicator {
      get {
        return(_LocErrorIyy1ComponentRollbackIndicator);
      }
      set {
        _LocErrorIyy1ComponentRollbackIndicator = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocErrorIyy1ComponentOriginServid
    /// </summary>
    private char _LocErrorIyy1ComponentOriginServid_AS;
    /// <summary>
    /// Attribute missing flag for: LocErrorIyy1ComponentOriginServid
    /// </summary>
    public char LocErrorIyy1ComponentOriginServid_AS {
      get {
        return(_LocErrorIyy1ComponentOriginServid_AS);
      }
      set {
        _LocErrorIyy1ComponentOriginServid_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocErrorIyy1ComponentOriginServid
    /// Domain: Number
    /// Length: 15
    /// Decimal Places: 0
    /// Decimal Precision: N
    /// </summary>
    private double _LocErrorIyy1ComponentOriginServid;
    /// <summary>
    /// Attribute for: LocErrorIyy1ComponentOriginServid
    /// </summary>
    public double LocErrorIyy1ComponentOriginServid {
      get {
        return(_LocErrorIyy1ComponentOriginServid);
      }
      set {
        _LocErrorIyy1ComponentOriginServid = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocErrorIyy1ComponentContextString
    /// </summary>
    private char _LocErrorIyy1ComponentContextString_AS;
    /// <summary>
    /// Attribute missing flag for: LocErrorIyy1ComponentContextString
    /// </summary>
    public char LocErrorIyy1ComponentContextString_AS {
      get {
        return(_LocErrorIyy1ComponentContextString_AS);
      }
      set {
        _LocErrorIyy1ComponentContextString_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocErrorIyy1ComponentContextString
    /// Domain: Text
    /// Length: 512
    /// Varying Length: Y
    /// </summary>
    private string _LocErrorIyy1ComponentContextString;
    /// <summary>
    /// Attribute for: LocErrorIyy1ComponentContextString
    /// </summary>
    public string LocErrorIyy1ComponentContextString {
      get {
        return(_LocErrorIyy1ComponentContextString);
      }
      set {
        _LocErrorIyy1ComponentContextString = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocErrorIyy1ComponentReturnCode
    /// </summary>
    private char _LocErrorIyy1ComponentReturnCode_AS;
    /// <summary>
    /// Attribute missing flag for: LocErrorIyy1ComponentReturnCode
    /// </summary>
    public char LocErrorIyy1ComponentReturnCode_AS {
      get {
        return(_LocErrorIyy1ComponentReturnCode_AS);
      }
      set {
        _LocErrorIyy1ComponentReturnCode_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocErrorIyy1ComponentReturnCode
    /// Domain: Number
    /// Length: 5
    /// Decimal Places: 0
    /// Decimal Precision: N
    /// </summary>
    private int _LocErrorIyy1ComponentReturnCode;
    /// <summary>
    /// Attribute for: LocErrorIyy1ComponentReturnCode
    /// </summary>
    public int LocErrorIyy1ComponentReturnCode {
      get {
        return(_LocErrorIyy1ComponentReturnCode);
      }
      set {
        _LocErrorIyy1ComponentReturnCode = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocErrorIyy1ComponentReasonCode
    /// </summary>
    private char _LocErrorIyy1ComponentReasonCode_AS;
    /// <summary>
    /// Attribute missing flag for: LocErrorIyy1ComponentReasonCode
    /// </summary>
    public char LocErrorIyy1ComponentReasonCode_AS {
      get {
        return(_LocErrorIyy1ComponentReasonCode_AS);
      }
      set {
        _LocErrorIyy1ComponentReasonCode_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocErrorIyy1ComponentReasonCode
    /// Domain: Number
    /// Length: 5
    /// Decimal Places: 0
    /// Decimal Precision: N
    /// </summary>
    private int _LocErrorIyy1ComponentReasonCode;
    /// <summary>
    /// Attribute for: LocErrorIyy1ComponentReasonCode
    /// </summary>
    public int LocErrorIyy1ComponentReasonCode {
      get {
        return(_LocErrorIyy1ComponentReasonCode);
      }
      set {
        _LocErrorIyy1ComponentReasonCode = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocErrorIyy1ComponentChecksum
    /// </summary>
    private char _LocErrorIyy1ComponentChecksum_AS;
    /// <summary>
    /// Attribute missing flag for: LocErrorIyy1ComponentChecksum
    /// </summary>
    public char LocErrorIyy1ComponentChecksum_AS {
      get {
        return(_LocErrorIyy1ComponentChecksum_AS);
      }
      set {
        _LocErrorIyy1ComponentChecksum_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocErrorIyy1ComponentChecksum
    /// Domain: Text
    /// Length: 15
    /// Varying Length: N
    /// </summary>
    private string _LocErrorIyy1ComponentChecksum;
    /// <summary>
    /// Attribute for: LocErrorIyy1ComponentChecksum
    /// </summary>
    public string LocErrorIyy1ComponentChecksum {
      get {
        return(_LocErrorIyy1ComponentChecksum);
      }
      set {
        _LocErrorIyy1ComponentChecksum = value;
      }
    }
    // Repeating GV:  LOC_GROUP_CONTEXT
    //     Repeats: 9 times
    /// <summary>
    /// Internal storage, repeating group view count
    /// </summary>
    private int _LocGroupContext_MA;
    /// <summary>
    /// Repeating group view count
    /// </summary>
    public int LocGroupContext_MA {
      get {
        return(_LocGroupContext_MA);
      }
      set {
        _LocGroupContext_MA = value;
      }
    }
    /// <summary>
    /// Internal storage, repeating group view occurrance array
    /// </summary>
    private char[] _LocGroupContext_AC = new char[9];
    /// <summary>
    /// Repeating group view occurrance array
    /// </summary>
    public char[] LocGroupContext_AC {
      get {
        return(_LocGroupContext_AC);
      }
      set {
        _LocGroupContext_AC = value;
      }
    }
    // Entity View: LOC_G_CONTEXT
    //        Type: DONT_CHANGE_TEXT
    /// <summary>
    /// Internal storage for attribute missing flag for: LocGContextDontChangeTextText150
    /// </summary>
    private char[] _LocGContextDontChangeTextText150_AS = new char[9];
    /// <summary>
    /// Attribute missing flag for: LocGContextDontChangeTextText150
    /// </summary>
    public char[] LocGContextDontChangeTextText150_AS {
      get {
        return(_LocGContextDontChangeTextText150_AS);
      }
      set {
        _LocGContextDontChangeTextText150_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocGContextDontChangeTextText150
    /// Domain: Text
    /// Length: 150
    /// Varying Length: N
    /// </summary>
    private string[] _LocGContextDontChangeTextText150 = new string[9];
    /// <summary>
    /// Attribute for: LocGContextDontChangeTextText150
    /// </summary>
    public string[] LocGContextDontChangeTextText150 {
      get {
        return(_LocGContextDontChangeTextText150);
      }
      set {
        _LocGContextDontChangeTextText150 = value;
      }
    }
    // Entity View: LOC
    //        Type: DONT_CHANGE_RETURN_CODES
    /// <summary>
    /// Internal storage for attribute missing flag for: LocDontChangeReturnCodesQ1Ok
    /// </summary>
    private char _LocDontChangeReturnCodesQ1Ok_AS;
    /// <summary>
    /// Attribute missing flag for: LocDontChangeReturnCodesQ1Ok
    /// </summary>
    public char LocDontChangeReturnCodesQ1Ok_AS {
      get {
        return(_LocDontChangeReturnCodesQ1Ok_AS);
      }
      set {
        _LocDontChangeReturnCodesQ1Ok_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocDontChangeReturnCodesQ1Ok
    /// Domain: Number
    /// Length: 5
    /// Decimal Places: 0
    /// Decimal Precision: N
    /// </summary>
    private int _LocDontChangeReturnCodesQ1Ok;
    /// <summary>
    /// Attribute for: LocDontChangeReturnCodesQ1Ok
    /// </summary>
    public int LocDontChangeReturnCodesQ1Ok {
      get {
        return(_LocDontChangeReturnCodesQ1Ok);
      }
      set {
        _LocDontChangeReturnCodesQ1Ok = value;
      }
    }
    // Entity View: LOC
    //        Type: DONT_CHANGE_REASON_CODES
    /// <summary>
    /// Internal storage for attribute missing flag for: LocDontChangeReasonCodesQ1Default
    /// </summary>
    private char _LocDontChangeReasonCodesQ1Default_AS;
    /// <summary>
    /// Attribute missing flag for: LocDontChangeReasonCodesQ1Default
    /// </summary>
    public char LocDontChangeReasonCodesQ1Default_AS {
      get {
        return(_LocDontChangeReasonCodesQ1Default_AS);
      }
      set {
        _LocDontChangeReasonCodesQ1Default_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocDontChangeReasonCodesQ1Default
    /// Domain: Number
    /// Length: 5
    /// Decimal Places: 0
    /// Decimal Precision: N
    /// </summary>
    private int _LocDontChangeReasonCodesQ1Default;
    /// <summary>
    /// Attribute for: LocDontChangeReasonCodesQ1Default
    /// </summary>
    public int LocDontChangeReasonCodesQ1Default {
      get {
        return(_LocDontChangeReasonCodesQ1Default);
      }
      set {
        _LocDontChangeReasonCodesQ1Default = value;
      }
    }
    /// <summary>
    /// Default Constructor
    /// </summary>
    
    public CYYY0341_LA(  )
    {
      Reset(  );
    }
    /// <summary>
    /// Copy Constructor
    /// </summary>
    
    public CYYY0341_LA( CYYY0341_LA orig )
    {
      LocErrorIyy1ComponentSeverityCode_AS = orig.LocErrorIyy1ComponentSeverityCode_AS;
      LocErrorIyy1ComponentSeverityCode = orig.LocErrorIyy1ComponentSeverityCode;
      LocErrorIyy1ComponentRollbackIndicator_AS = orig.LocErrorIyy1ComponentRollbackIndicator_AS;
      LocErrorIyy1ComponentRollbackIndicator = orig.LocErrorIyy1ComponentRollbackIndicator;
      LocErrorIyy1ComponentOriginServid_AS = orig.LocErrorIyy1ComponentOriginServid_AS;
      LocErrorIyy1ComponentOriginServid = orig.LocErrorIyy1ComponentOriginServid;
      LocErrorIyy1ComponentContextString_AS = orig.LocErrorIyy1ComponentContextString_AS;
      LocErrorIyy1ComponentContextString = orig.LocErrorIyy1ComponentContextString;
      LocErrorIyy1ComponentReturnCode_AS = orig.LocErrorIyy1ComponentReturnCode_AS;
      LocErrorIyy1ComponentReturnCode = orig.LocErrorIyy1ComponentReturnCode;
      LocErrorIyy1ComponentReasonCode_AS = orig.LocErrorIyy1ComponentReasonCode_AS;
      LocErrorIyy1ComponentReasonCode = orig.LocErrorIyy1ComponentReasonCode;
      LocErrorIyy1ComponentChecksum_AS = orig.LocErrorIyy1ComponentChecksum_AS;
      LocErrorIyy1ComponentChecksum = orig.LocErrorIyy1ComponentChecksum;
      LocGroupContext_MA = orig.LocGroupContext_MA;
      Array.Copy( orig._LocGroupContext_AC,
      	LocGroupContext_AC,
      	LocGroupContext_AC.Length );
      Array.Copy( orig._LocGContextDontChangeTextText150_AS,
      	LocGContextDontChangeTextText150_AS,
      	LocGContextDontChangeTextText150_AS.Length );
      Array.Copy( orig._LocGContextDontChangeTextText150,
      	LocGContextDontChangeTextText150,
      	LocGContextDontChangeTextText150.Length );
      LocDontChangeReturnCodesQ1Ok_AS = orig.LocDontChangeReturnCodesQ1Ok_AS;
      LocDontChangeReturnCodesQ1Ok = orig.LocDontChangeReturnCodesQ1Ok;
      LocDontChangeReasonCodesQ1Default_AS = orig.LocDontChangeReasonCodesQ1Default_AS;
      LocDontChangeReasonCodesQ1Default = orig.LocDontChangeReasonCodesQ1Default;
    }
    /// <summary>
    /// Static instance creator function
    /// </summary>
    
    public static CYYY0341_LA GetInstance(  )
    {
      if ( countFree == 0 )
      {
        return(new CYYY0341_LA());
      }
      else 
      {
        lock (freeArray)
        {
          if ( countFree == 0 )
          {
            return(new CYYY0341_LA());
          }
          else 
          {
            CYYY0341_LA result = freeArray[--countFree];
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
      return(new CYYY0341_LA(this));
    }
    /// <summary>
    /// Resets all properties to the defaults.
    /// </summary>
    
    public void Reset(  )
    {
      LocErrorIyy1ComponentSeverityCode_AS = ' ';
      LocErrorIyy1ComponentSeverityCode = " ";
      LocErrorIyy1ComponentRollbackIndicator_AS = ' ';
      LocErrorIyy1ComponentRollbackIndicator = " ";
      LocErrorIyy1ComponentOriginServid_AS = ' ';
      LocErrorIyy1ComponentOriginServid = 0.0;
      LocErrorIyy1ComponentContextString_AS = ' ';
      LocErrorIyy1ComponentContextString = "";
      LocErrorIyy1ComponentReturnCode_AS = ' ';
      LocErrorIyy1ComponentReturnCode = 0;
      LocErrorIyy1ComponentReasonCode_AS = ' ';
      LocErrorIyy1ComponentReasonCode = 0;
      LocErrorIyy1ComponentChecksum_AS = ' ';
      LocErrorIyy1ComponentChecksum = "               ";
      LocGroupContext_MA = 0;
      for(int a = 0; a < 9; a++)
      {
        LocGroupContext_AC[ a] = ' ';
        LocGContextDontChangeTextText150_AS[ a] = ' ';
        LocGContextDontChangeTextText150[ a] = 
"                                                                                                                                                      "
          ;
      }
      LocDontChangeReturnCodesQ1Ok_AS = ' ';
      LocDontChangeReturnCodesQ1Ok = 0;
      LocDontChangeReasonCodesQ1Default_AS = ' ';
      LocDontChangeReasonCodesQ1Default = 0;
    }
  }
}
