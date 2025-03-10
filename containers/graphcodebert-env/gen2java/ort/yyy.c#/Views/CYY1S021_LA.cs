// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
//
//                    Source Code Generated by
//                           CA Gen 8.6
//
//    Copyright (c) 2024 CA Technologies. All rights reserved.
//
//    Name: CYY1S021_LA                      Date: 2024/01/09
//    User: AliAl                            Time: 13:40:43
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
  /// Internal data view storage for: CYY1S021_LA
  /// </summary>
  [Serializable]
  public class CYY1S021_LA : ViewBase, ILocalView
  {
    private static CYY1S021_LA[] freeArray = new CYY1S021_LA[30];
    private static int countFree = 0;
    
    // Entity View: LOC_REFERENCE
    //        Type: IYY1_SERVER_DATA
    /// <summary>
    /// Internal storage for attribute missing flag for: LocReferenceIyy1ServerDataUserid
    /// </summary>
    private char _LocReferenceIyy1ServerDataUserid_AS;
    /// <summary>
    /// Attribute missing flag for: LocReferenceIyy1ServerDataUserid
    /// </summary>
    public char LocReferenceIyy1ServerDataUserid_AS {
      get {
        return(_LocReferenceIyy1ServerDataUserid_AS);
      }
      set {
        _LocReferenceIyy1ServerDataUserid_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocReferenceIyy1ServerDataUserid
    /// Domain: Text
    /// Length: 8
    /// Varying Length: N
    /// </summary>
    private string _LocReferenceIyy1ServerDataUserid;
    /// <summary>
    /// Attribute for: LocReferenceIyy1ServerDataUserid
    /// </summary>
    public string LocReferenceIyy1ServerDataUserid {
      get {
        return(_LocReferenceIyy1ServerDataUserid);
      }
      set {
        _LocReferenceIyy1ServerDataUserid = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocReferenceIyy1ServerDataServerDate
    /// </summary>
    private char _LocReferenceIyy1ServerDataServerDate_AS;
    /// <summary>
    /// Attribute missing flag for: LocReferenceIyy1ServerDataServerDate
    /// </summary>
    public char LocReferenceIyy1ServerDataServerDate_AS {
      get {
        return(_LocReferenceIyy1ServerDataServerDate_AS);
      }
      set {
        _LocReferenceIyy1ServerDataServerDate_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocReferenceIyy1ServerDataServerDate
    /// Domain: Date
    /// Length: 8
    /// </summary>
    private int _LocReferenceIyy1ServerDataServerDate;
    /// <summary>
    /// Attribute for: LocReferenceIyy1ServerDataServerDate
    /// </summary>
    public int LocReferenceIyy1ServerDataServerDate {
      get {
        return(_LocReferenceIyy1ServerDataServerDate);
      }
      set {
        _LocReferenceIyy1ServerDataServerDate = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocReferenceIyy1ServerDataServerTime
    /// </summary>
    private char _LocReferenceIyy1ServerDataServerTime_AS;
    /// <summary>
    /// Attribute missing flag for: LocReferenceIyy1ServerDataServerTime
    /// </summary>
    public char LocReferenceIyy1ServerDataServerTime_AS {
      get {
        return(_LocReferenceIyy1ServerDataServerTime_AS);
      }
      set {
        _LocReferenceIyy1ServerDataServerTime_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocReferenceIyy1ServerDataServerTime
    /// Domain: Time
    /// Length: 6
    /// </summary>
    private int _LocReferenceIyy1ServerDataServerTime;
    /// <summary>
    /// Attribute for: LocReferenceIyy1ServerDataServerTime
    /// </summary>
    public int LocReferenceIyy1ServerDataServerTime {
      get {
        return(_LocReferenceIyy1ServerDataServerTime);
      }
      set {
        _LocReferenceIyy1ServerDataServerTime = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocReferenceIyy1ServerDataReferenceId
    /// </summary>
    private char _LocReferenceIyy1ServerDataReferenceId_AS;
    /// <summary>
    /// Attribute missing flag for: LocReferenceIyy1ServerDataReferenceId
    /// </summary>
    public char LocReferenceIyy1ServerDataReferenceId_AS {
      get {
        return(_LocReferenceIyy1ServerDataReferenceId_AS);
      }
      set {
        _LocReferenceIyy1ServerDataReferenceId_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocReferenceIyy1ServerDataReferenceId
    /// Domain: Timestamp
    /// Length: 20
    /// </summary>
    private string _LocReferenceIyy1ServerDataReferenceId;
    /// <summary>
    /// Attribute for: LocReferenceIyy1ServerDataReferenceId
    /// </summary>
    public string LocReferenceIyy1ServerDataReferenceId {
      get {
        return(_LocReferenceIyy1ServerDataReferenceId);
      }
      set {
        _LocReferenceIyy1ServerDataReferenceId = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocReferenceIyy1ServerDataServerTimestamp
    /// </summary>
    private char _LocReferenceIyy1ServerDataServerTimestamp_AS;
    /// <summary>
    /// Attribute missing flag for: LocReferenceIyy1ServerDataServerTimestamp
    /// </summary>
    public char LocReferenceIyy1ServerDataServerTimestamp_AS {
      get {
        return(_LocReferenceIyy1ServerDataServerTimestamp_AS);
      }
      set {
        _LocReferenceIyy1ServerDataServerTimestamp_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocReferenceIyy1ServerDataServerTimestamp
    /// Domain: Timestamp
    /// Length: 20
    /// </summary>
    private string _LocReferenceIyy1ServerDataServerTimestamp;
    /// <summary>
    /// Attribute for: LocReferenceIyy1ServerDataServerTimestamp
    /// </summary>
    public string LocReferenceIyy1ServerDataServerTimestamp {
      get {
        return(_LocReferenceIyy1ServerDataServerTimestamp);
      }
      set {
        _LocReferenceIyy1ServerDataServerTimestamp = value;
      }
    }
    // Entity View: LOC_ERROR
    //        Type: ISC1_COMPONENT
    /// <summary>
    /// Internal storage for attribute missing flag for: LocErrorIsc1ComponentSeverityCode
    /// </summary>
    private char _LocErrorIsc1ComponentSeverityCode_AS;
    /// <summary>
    /// Attribute missing flag for: LocErrorIsc1ComponentSeverityCode
    /// </summary>
    public char LocErrorIsc1ComponentSeverityCode_AS {
      get {
        return(_LocErrorIsc1ComponentSeverityCode_AS);
      }
      set {
        _LocErrorIsc1ComponentSeverityCode_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocErrorIsc1ComponentSeverityCode
    /// Domain: Text
    /// Length: 1
    /// Varying Length: N
    /// </summary>
    private string _LocErrorIsc1ComponentSeverityCode;
    /// <summary>
    /// Attribute for: LocErrorIsc1ComponentSeverityCode
    /// </summary>
    public string LocErrorIsc1ComponentSeverityCode {
      get {
        return(_LocErrorIsc1ComponentSeverityCode);
      }
      set {
        _LocErrorIsc1ComponentSeverityCode = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocErrorIsc1ComponentRollbackIndicator
    /// </summary>
    private char _LocErrorIsc1ComponentRollbackIndicator_AS;
    /// <summary>
    /// Attribute missing flag for: LocErrorIsc1ComponentRollbackIndicator
    /// </summary>
    public char LocErrorIsc1ComponentRollbackIndicator_AS {
      get {
        return(_LocErrorIsc1ComponentRollbackIndicator_AS);
      }
      set {
        _LocErrorIsc1ComponentRollbackIndicator_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocErrorIsc1ComponentRollbackIndicator
    /// Domain: Text
    /// Length: 1
    /// Varying Length: N
    /// </summary>
    private string _LocErrorIsc1ComponentRollbackIndicator;
    /// <summary>
    /// Attribute for: LocErrorIsc1ComponentRollbackIndicator
    /// </summary>
    public string LocErrorIsc1ComponentRollbackIndicator {
      get {
        return(_LocErrorIsc1ComponentRollbackIndicator);
      }
      set {
        _LocErrorIsc1ComponentRollbackIndicator = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocErrorIsc1ComponentOriginServid
    /// </summary>
    private char _LocErrorIsc1ComponentOriginServid_AS;
    /// <summary>
    /// Attribute missing flag for: LocErrorIsc1ComponentOriginServid
    /// </summary>
    public char LocErrorIsc1ComponentOriginServid_AS {
      get {
        return(_LocErrorIsc1ComponentOriginServid_AS);
      }
      set {
        _LocErrorIsc1ComponentOriginServid_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocErrorIsc1ComponentOriginServid
    /// Domain: Number
    /// Length: 15
    /// Decimal Places: 0
    /// Decimal Precision: N
    /// </summary>
    private double _LocErrorIsc1ComponentOriginServid;
    /// <summary>
    /// Attribute for: LocErrorIsc1ComponentOriginServid
    /// </summary>
    public double LocErrorIsc1ComponentOriginServid {
      get {
        return(_LocErrorIsc1ComponentOriginServid);
      }
      set {
        _LocErrorIsc1ComponentOriginServid = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocErrorIsc1ComponentContextString
    /// </summary>
    private char _LocErrorIsc1ComponentContextString_AS;
    /// <summary>
    /// Attribute missing flag for: LocErrorIsc1ComponentContextString
    /// </summary>
    public char LocErrorIsc1ComponentContextString_AS {
      get {
        return(_LocErrorIsc1ComponentContextString_AS);
      }
      set {
        _LocErrorIsc1ComponentContextString_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocErrorIsc1ComponentContextString
    /// Domain: Text
    /// Length: 512
    /// Varying Length: Y
    /// </summary>
    private string _LocErrorIsc1ComponentContextString;
    /// <summary>
    /// Attribute for: LocErrorIsc1ComponentContextString
    /// </summary>
    public string LocErrorIsc1ComponentContextString {
      get {
        return(_LocErrorIsc1ComponentContextString);
      }
      set {
        _LocErrorIsc1ComponentContextString = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocErrorIsc1ComponentReturnCode
    /// </summary>
    private char _LocErrorIsc1ComponentReturnCode_AS;
    /// <summary>
    /// Attribute missing flag for: LocErrorIsc1ComponentReturnCode
    /// </summary>
    public char LocErrorIsc1ComponentReturnCode_AS {
      get {
        return(_LocErrorIsc1ComponentReturnCode_AS);
      }
      set {
        _LocErrorIsc1ComponentReturnCode_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocErrorIsc1ComponentReturnCode
    /// Domain: Number
    /// Length: 5
    /// Decimal Places: 0
    /// Decimal Precision: N
    /// </summary>
    private int _LocErrorIsc1ComponentReturnCode;
    /// <summary>
    /// Attribute for: LocErrorIsc1ComponentReturnCode
    /// </summary>
    public int LocErrorIsc1ComponentReturnCode {
      get {
        return(_LocErrorIsc1ComponentReturnCode);
      }
      set {
        _LocErrorIsc1ComponentReturnCode = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocErrorIsc1ComponentReasonCode
    /// </summary>
    private char _LocErrorIsc1ComponentReasonCode_AS;
    /// <summary>
    /// Attribute missing flag for: LocErrorIsc1ComponentReasonCode
    /// </summary>
    public char LocErrorIsc1ComponentReasonCode_AS {
      get {
        return(_LocErrorIsc1ComponentReasonCode_AS);
      }
      set {
        _LocErrorIsc1ComponentReasonCode_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocErrorIsc1ComponentReasonCode
    /// Domain: Number
    /// Length: 5
    /// Decimal Places: 0
    /// Decimal Precision: N
    /// </summary>
    private int _LocErrorIsc1ComponentReasonCode;
    /// <summary>
    /// Attribute for: LocErrorIsc1ComponentReasonCode
    /// </summary>
    public int LocErrorIsc1ComponentReasonCode {
      get {
        return(_LocErrorIsc1ComponentReasonCode);
      }
      set {
        _LocErrorIsc1ComponentReasonCode = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: LocErrorIsc1ComponentChecksum
    /// </summary>
    private char _LocErrorIsc1ComponentChecksum_AS;
    /// <summary>
    /// Attribute missing flag for: LocErrorIsc1ComponentChecksum
    /// </summary>
    public char LocErrorIsc1ComponentChecksum_AS {
      get {
        return(_LocErrorIsc1ComponentChecksum_AS);
      }
      set {
        _LocErrorIsc1ComponentChecksum_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocErrorIsc1ComponentChecksum
    /// Domain: Text
    /// Length: 15
    /// Varying Length: N
    /// </summary>
    private string _LocErrorIsc1ComponentChecksum;
    /// <summary>
    /// Attribute for: LocErrorIsc1ComponentChecksum
    /// </summary>
    public string LocErrorIsc1ComponentChecksum {
      get {
        return(_LocErrorIsc1ComponentChecksum);
      }
      set {
        _LocErrorIsc1ComponentChecksum = value;
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
    // Entity View: LOC_CONTEXT
    //        Type: IYY1_COMPONENT
    /// <summary>
    /// Internal storage for attribute missing flag for: LocContextIyy1ComponentContextString
    /// </summary>
    private char _LocContextIyy1ComponentContextString_AS;
    /// <summary>
    /// Attribute missing flag for: LocContextIyy1ComponentContextString
    /// </summary>
    public char LocContextIyy1ComponentContextString_AS {
      get {
        return(_LocContextIyy1ComponentContextString_AS);
      }
      set {
        _LocContextIyy1ComponentContextString_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocContextIyy1ComponentContextString
    /// Domain: Text
    /// Length: 512
    /// Varying Length: Y
    /// </summary>
    private string _LocContextIyy1ComponentContextString;
    /// <summary>
    /// Attribute for: LocContextIyy1ComponentContextString
    /// </summary>
    public string LocContextIyy1ComponentContextString {
      get {
        return(_LocContextIyy1ComponentContextString);
      }
      set {
        _LocContextIyy1ComponentContextString = value;
      }
    }
    // Entity View: LOC
    //        Type: DONT_CHANGE_RETURN_CODES
    /// <summary>
    /// Internal storage for attribute missing flag for: LocDontChangeReturnCodesN1120InvalidCommand
    /// </summary>
    private char _LocDontChangeReturnCodesN1120InvalidCommand_AS;
    /// <summary>
    /// Attribute missing flag for: LocDontChangeReturnCodesN1120InvalidCommand
    /// </summary>
    public char LocDontChangeReturnCodesN1120InvalidCommand_AS {
      get {
        return(_LocDontChangeReturnCodesN1120InvalidCommand_AS);
      }
      set {
        _LocDontChangeReturnCodesN1120InvalidCommand_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: LocDontChangeReturnCodesN1120InvalidCommand
    /// Domain: Number
    /// Length: 5
    /// Decimal Places: 0
    /// Decimal Precision: N
    /// </summary>
    private int _LocDontChangeReturnCodesN1120InvalidCommand;
    /// <summary>
    /// Attribute for: LocDontChangeReturnCodesN1120InvalidCommand
    /// </summary>
    public int LocDontChangeReturnCodesN1120InvalidCommand {
      get {
        return(_LocDontChangeReturnCodesN1120InvalidCommand);
      }
      set {
        _LocDontChangeReturnCodesN1120InvalidCommand = value;
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
    
    public CYY1S021_LA(  )
    {
      Reset(  );
    }
    /// <summary>
    /// Copy Constructor
    /// </summary>
    
    public CYY1S021_LA( CYY1S021_LA orig )
    {
      LocReferenceIyy1ServerDataUserid_AS = orig.LocReferenceIyy1ServerDataUserid_AS;
      LocReferenceIyy1ServerDataUserid = orig.LocReferenceIyy1ServerDataUserid;
      LocReferenceIyy1ServerDataServerDate_AS = orig.LocReferenceIyy1ServerDataServerDate_AS;
      LocReferenceIyy1ServerDataServerDate = orig.LocReferenceIyy1ServerDataServerDate;
      LocReferenceIyy1ServerDataServerTime_AS = orig.LocReferenceIyy1ServerDataServerTime_AS;
      LocReferenceIyy1ServerDataServerTime = orig.LocReferenceIyy1ServerDataServerTime;
      LocReferenceIyy1ServerDataReferenceId_AS = orig.LocReferenceIyy1ServerDataReferenceId_AS;
      LocReferenceIyy1ServerDataReferenceId = orig.LocReferenceIyy1ServerDataReferenceId;
      LocReferenceIyy1ServerDataServerTimestamp_AS = orig.LocReferenceIyy1ServerDataServerTimestamp_AS;
      LocReferenceIyy1ServerDataServerTimestamp = orig.LocReferenceIyy1ServerDataServerTimestamp;
      LocErrorIsc1ComponentSeverityCode_AS = orig.LocErrorIsc1ComponentSeverityCode_AS;
      LocErrorIsc1ComponentSeverityCode = orig.LocErrorIsc1ComponentSeverityCode;
      LocErrorIsc1ComponentRollbackIndicator_AS = orig.LocErrorIsc1ComponentRollbackIndicator_AS;
      LocErrorIsc1ComponentRollbackIndicator = orig.LocErrorIsc1ComponentRollbackIndicator;
      LocErrorIsc1ComponentOriginServid_AS = orig.LocErrorIsc1ComponentOriginServid_AS;
      LocErrorIsc1ComponentOriginServid = orig.LocErrorIsc1ComponentOriginServid;
      LocErrorIsc1ComponentContextString_AS = orig.LocErrorIsc1ComponentContextString_AS;
      LocErrorIsc1ComponentContextString = orig.LocErrorIsc1ComponentContextString;
      LocErrorIsc1ComponentReturnCode_AS = orig.LocErrorIsc1ComponentReturnCode_AS;
      LocErrorIsc1ComponentReturnCode = orig.LocErrorIsc1ComponentReturnCode;
      LocErrorIsc1ComponentReasonCode_AS = orig.LocErrorIsc1ComponentReasonCode_AS;
      LocErrorIsc1ComponentReasonCode = orig.LocErrorIsc1ComponentReasonCode;
      LocErrorIsc1ComponentChecksum_AS = orig.LocErrorIsc1ComponentChecksum_AS;
      LocErrorIsc1ComponentChecksum = orig.LocErrorIsc1ComponentChecksum;
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
      LocContextIyy1ComponentContextString_AS = orig.LocContextIyy1ComponentContextString_AS;
      LocContextIyy1ComponentContextString = orig.LocContextIyy1ComponentContextString;
      LocDontChangeReturnCodesN1120InvalidCommand_AS = orig.LocDontChangeReturnCodesN1120InvalidCommand_AS;
      LocDontChangeReturnCodesN1120InvalidCommand = orig.LocDontChangeReturnCodesN1120InvalidCommand;
      LocDontChangeReasonCodesQ1Default_AS = orig.LocDontChangeReasonCodesQ1Default_AS;
      LocDontChangeReasonCodesQ1Default = orig.LocDontChangeReasonCodesQ1Default;
    }
    /// <summary>
    /// Static instance creator function
    /// </summary>
    
    public static CYY1S021_LA GetInstance(  )
    {
      if ( countFree == 0 )
      {
        return(new CYY1S021_LA());
      }
      else 
      {
        lock (freeArray)
        {
          if ( countFree == 0 )
          {
            return(new CYY1S021_LA());
          }
          else 
          {
            CYY1S021_LA result = freeArray[--countFree];
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
      return(new CYY1S021_LA(this));
    }
    /// <summary>
    /// Resets all properties to the defaults.
    /// </summary>
    
    public void Reset(  )
    {
      LocReferenceIyy1ServerDataUserid_AS = ' ';
      LocReferenceIyy1ServerDataUserid = "        ";
      LocReferenceIyy1ServerDataServerDate_AS = ' ';
      LocReferenceIyy1ServerDataServerDate = 00000000;
      LocReferenceIyy1ServerDataServerTime_AS = ' ';
      LocReferenceIyy1ServerDataServerTime = 00000000;
      LocReferenceIyy1ServerDataReferenceId_AS = ' ';
      LocReferenceIyy1ServerDataReferenceId = "00000000000000000000";
      LocReferenceIyy1ServerDataServerTimestamp_AS = ' ';
      LocReferenceIyy1ServerDataServerTimestamp = "00000000000000000000";
      LocErrorIsc1ComponentSeverityCode_AS = ' ';
      LocErrorIsc1ComponentSeverityCode = " ";
      LocErrorIsc1ComponentRollbackIndicator_AS = ' ';
      LocErrorIsc1ComponentRollbackIndicator = " ";
      LocErrorIsc1ComponentOriginServid_AS = ' ';
      LocErrorIsc1ComponentOriginServid = 0.0;
      LocErrorIsc1ComponentContextString_AS = ' ';
      LocErrorIsc1ComponentContextString = "";
      LocErrorIsc1ComponentReturnCode_AS = ' ';
      LocErrorIsc1ComponentReturnCode = 0;
      LocErrorIsc1ComponentReasonCode_AS = ' ';
      LocErrorIsc1ComponentReasonCode = 0;
      LocErrorIsc1ComponentChecksum_AS = ' ';
      LocErrorIsc1ComponentChecksum = "               ";
      LocGroupContext_MA = 0;
      for(int a = 0; a < 9; a++)
      {
        LocGroupContext_AC[ a] = ' ';
        LocGContextDontChangeTextText150_AS[ a] = ' ';
        LocGContextDontChangeTextText150[ a] = 
"                                                                                                                                                      "
          ;
      }
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
      LocContextIyy1ComponentContextString_AS = ' ';
      LocContextIyy1ComponentContextString = "";
      LocDontChangeReturnCodesN1120InvalidCommand_AS = ' ';
      LocDontChangeReturnCodesN1120InvalidCommand = 0;
      LocDontChangeReasonCodesQ1Default_AS = ' ';
      LocDontChangeReasonCodesQ1Default = 0;
    }
  }
}
