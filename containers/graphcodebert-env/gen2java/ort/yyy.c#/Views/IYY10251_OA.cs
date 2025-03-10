// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
//
//                    Source Code Generated by
//                           CA Gen 8.6
//
//    Copyright (c) 2024 CA Technologies. All rights reserved.
//
//    Name: IYY10251_OA                      Date: 2024/01/09
//    User: AliAl                            Time: 13:41:59
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
  /// Internal data view storage for: IYY10251_OA
  /// </summary>
  [Serializable]
  public class IYY10251_OA : ViewBase, IExportView
  {
    private static IYY10251_OA[] freeArray = new IYY10251_OA[30];
    private static int countFree = 0;
    
    // Repeating GV:  EXP_GROUP_LIST
    //     Repeats: 48 times
    /// <summary>
    /// Internal storage, repeating group view count
    /// </summary>
    private int _ExpGroupList_MA;
    /// <summary>
    /// Repeating group view count
    /// </summary>
    public int ExpGroupList_MA {
      get {
        return(_ExpGroupList_MA);
      }
      set {
        _ExpGroupList_MA = value;
      }
    }
    /// <summary>
    /// Internal storage, repeating group view occurrance array
    /// </summary>
    private char[] _ExpGroupList_AC = new char[48];
    /// <summary>
    /// Repeating group view occurrance array
    /// </summary>
    public char[] ExpGroupList_AC {
      get {
        return(_ExpGroupList_AC);
      }
      set {
        _ExpGroupList_AC = value;
      }
    }
    // Entity View: EXP_G_LIST
    //        Type: IYY1_CHILD
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpGListIyy1ChildCinstanceId
    /// </summary>
    private char[] _ExpGListIyy1ChildCinstanceId_AS = new char[48];
    /// <summary>
    /// Attribute missing flag for: ExpGListIyy1ChildCinstanceId
    /// </summary>
    public char[] ExpGListIyy1ChildCinstanceId_AS {
      get {
        return(_ExpGListIyy1ChildCinstanceId_AS);
      }
      set {
        _ExpGListIyy1ChildCinstanceId_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpGListIyy1ChildCinstanceId
    /// Domain: Timestamp
    /// Length: 20
    /// </summary>
    private string[] _ExpGListIyy1ChildCinstanceId = new string[48];
    /// <summary>
    /// Attribute for: ExpGListIyy1ChildCinstanceId
    /// </summary>
    public string[] ExpGListIyy1ChildCinstanceId {
      get {
        return(_ExpGListIyy1ChildCinstanceId);
      }
      set {
        _ExpGListIyy1ChildCinstanceId = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpGListIyy1ChildCreferenceId
    /// </summary>
    private char[] _ExpGListIyy1ChildCreferenceId_AS = new char[48];
    /// <summary>
    /// Attribute missing flag for: ExpGListIyy1ChildCreferenceId
    /// </summary>
    public char[] ExpGListIyy1ChildCreferenceId_AS {
      get {
        return(_ExpGListIyy1ChildCreferenceId_AS);
      }
      set {
        _ExpGListIyy1ChildCreferenceId_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpGListIyy1ChildCreferenceId
    /// Domain: Timestamp
    /// Length: 20
    /// </summary>
    private string[] _ExpGListIyy1ChildCreferenceId = new string[48];
    /// <summary>
    /// Attribute for: ExpGListIyy1ChildCreferenceId
    /// </summary>
    public string[] ExpGListIyy1ChildCreferenceId {
      get {
        return(_ExpGListIyy1ChildCreferenceId);
      }
      set {
        _ExpGListIyy1ChildCreferenceId = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpGListIyy1ChildCparentPkeyAttrText
    /// </summary>
    private char[] _ExpGListIyy1ChildCparentPkeyAttrText_AS = new char[48];
    /// <summary>
    /// Attribute missing flag for: ExpGListIyy1ChildCparentPkeyAttrText
    /// </summary>
    public char[] ExpGListIyy1ChildCparentPkeyAttrText_AS {
      get {
        return(_ExpGListIyy1ChildCparentPkeyAttrText_AS);
      }
      set {
        _ExpGListIyy1ChildCparentPkeyAttrText_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpGListIyy1ChildCparentPkeyAttrText
    /// Domain: Text
    /// Length: 5
    /// Varying Length: N
    /// </summary>
    private string[] _ExpGListIyy1ChildCparentPkeyAttrText = new string[48];
    /// <summary>
    /// Attribute for: ExpGListIyy1ChildCparentPkeyAttrText
    /// </summary>
    public string[] ExpGListIyy1ChildCparentPkeyAttrText {
      get {
        return(_ExpGListIyy1ChildCparentPkeyAttrText);
      }
      set {
        _ExpGListIyy1ChildCparentPkeyAttrText = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpGListIyy1ChildCkeyAttrNum
    /// </summary>
    private char[] _ExpGListIyy1ChildCkeyAttrNum_AS = new char[48];
    /// <summary>
    /// Attribute missing flag for: ExpGListIyy1ChildCkeyAttrNum
    /// </summary>
    public char[] ExpGListIyy1ChildCkeyAttrNum_AS {
      get {
        return(_ExpGListIyy1ChildCkeyAttrNum_AS);
      }
      set {
        _ExpGListIyy1ChildCkeyAttrNum_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpGListIyy1ChildCkeyAttrNum
    /// Domain: Number
    /// Length: 6
    /// Decimal Places: 0
    /// Decimal Precision: N
    /// </summary>
    private int[] _ExpGListIyy1ChildCkeyAttrNum = new int[48];
    /// <summary>
    /// Attribute for: ExpGListIyy1ChildCkeyAttrNum
    /// </summary>
    public int[] ExpGListIyy1ChildCkeyAttrNum {
      get {
        return(_ExpGListIyy1ChildCkeyAttrNum);
      }
      set {
        _ExpGListIyy1ChildCkeyAttrNum = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpGListIyy1ChildCsearchAttrText
    /// </summary>
    private char[] _ExpGListIyy1ChildCsearchAttrText_AS = new char[48];
    /// <summary>
    /// Attribute missing flag for: ExpGListIyy1ChildCsearchAttrText
    /// </summary>
    public char[] ExpGListIyy1ChildCsearchAttrText_AS {
      get {
        return(_ExpGListIyy1ChildCsearchAttrText_AS);
      }
      set {
        _ExpGListIyy1ChildCsearchAttrText_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpGListIyy1ChildCsearchAttrText
    /// Domain: Text
    /// Length: 25
    /// Varying Length: N
    /// </summary>
    private string[] _ExpGListIyy1ChildCsearchAttrText = new string[48];
    /// <summary>
    /// Attribute for: ExpGListIyy1ChildCsearchAttrText
    /// </summary>
    public string[] ExpGListIyy1ChildCsearchAttrText {
      get {
        return(_ExpGListIyy1ChildCsearchAttrText);
      }
      set {
        _ExpGListIyy1ChildCsearchAttrText = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpGListIyy1ChildCotherAttrText
    /// </summary>
    private char[] _ExpGListIyy1ChildCotherAttrText_AS = new char[48];
    /// <summary>
    /// Attribute missing flag for: ExpGListIyy1ChildCotherAttrText
    /// </summary>
    public char[] ExpGListIyy1ChildCotherAttrText_AS {
      get {
        return(_ExpGListIyy1ChildCotherAttrText_AS);
      }
      set {
        _ExpGListIyy1ChildCotherAttrText_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpGListIyy1ChildCotherAttrText
    /// Domain: Text
    /// Length: 25
    /// Varying Length: N
    /// </summary>
    private string[] _ExpGListIyy1ChildCotherAttrText = new string[48];
    /// <summary>
    /// Attribute for: ExpGListIyy1ChildCotherAttrText
    /// </summary>
    public string[] ExpGListIyy1ChildCotherAttrText {
      get {
        return(_ExpGListIyy1ChildCotherAttrText);
      }
      set {
        _ExpGListIyy1ChildCotherAttrText = value;
      }
    }
    // Entity View: EXP_ERROR
    //        Type: IYY1_COMPONENT
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpErrorIyy1ComponentSeverityCode
    /// </summary>
    private char _ExpErrorIyy1ComponentSeverityCode_AS;
    /// <summary>
    /// Attribute missing flag for: ExpErrorIyy1ComponentSeverityCode
    /// </summary>
    public char ExpErrorIyy1ComponentSeverityCode_AS {
      get {
        return(_ExpErrorIyy1ComponentSeverityCode_AS);
      }
      set {
        _ExpErrorIyy1ComponentSeverityCode_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpErrorIyy1ComponentSeverityCode
    /// Domain: Text
    /// Length: 1
    /// Varying Length: N
    /// </summary>
    private string _ExpErrorIyy1ComponentSeverityCode;
    /// <summary>
    /// Attribute for: ExpErrorIyy1ComponentSeverityCode
    /// </summary>
    public string ExpErrorIyy1ComponentSeverityCode {
      get {
        return(_ExpErrorIyy1ComponentSeverityCode);
      }
      set {
        _ExpErrorIyy1ComponentSeverityCode = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpErrorIyy1ComponentRollbackIndicator
    /// </summary>
    private char _ExpErrorIyy1ComponentRollbackIndicator_AS;
    /// <summary>
    /// Attribute missing flag for: ExpErrorIyy1ComponentRollbackIndicator
    /// </summary>
    public char ExpErrorIyy1ComponentRollbackIndicator_AS {
      get {
        return(_ExpErrorIyy1ComponentRollbackIndicator_AS);
      }
      set {
        _ExpErrorIyy1ComponentRollbackIndicator_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpErrorIyy1ComponentRollbackIndicator
    /// Domain: Text
    /// Length: 1
    /// Varying Length: N
    /// </summary>
    private string _ExpErrorIyy1ComponentRollbackIndicator;
    /// <summary>
    /// Attribute for: ExpErrorIyy1ComponentRollbackIndicator
    /// </summary>
    public string ExpErrorIyy1ComponentRollbackIndicator {
      get {
        return(_ExpErrorIyy1ComponentRollbackIndicator);
      }
      set {
        _ExpErrorIyy1ComponentRollbackIndicator = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpErrorIyy1ComponentOriginServid
    /// </summary>
    private char _ExpErrorIyy1ComponentOriginServid_AS;
    /// <summary>
    /// Attribute missing flag for: ExpErrorIyy1ComponentOriginServid
    /// </summary>
    public char ExpErrorIyy1ComponentOriginServid_AS {
      get {
        return(_ExpErrorIyy1ComponentOriginServid_AS);
      }
      set {
        _ExpErrorIyy1ComponentOriginServid_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpErrorIyy1ComponentOriginServid
    /// Domain: Number
    /// Length: 15
    /// Decimal Places: 0
    /// Decimal Precision: N
    /// </summary>
    private double _ExpErrorIyy1ComponentOriginServid;
    /// <summary>
    /// Attribute for: ExpErrorIyy1ComponentOriginServid
    /// </summary>
    public double ExpErrorIyy1ComponentOriginServid {
      get {
        return(_ExpErrorIyy1ComponentOriginServid);
      }
      set {
        _ExpErrorIyy1ComponentOriginServid = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpErrorIyy1ComponentContextString
    /// </summary>
    private char _ExpErrorIyy1ComponentContextString_AS;
    /// <summary>
    /// Attribute missing flag for: ExpErrorIyy1ComponentContextString
    /// </summary>
    public char ExpErrorIyy1ComponentContextString_AS {
      get {
        return(_ExpErrorIyy1ComponentContextString_AS);
      }
      set {
        _ExpErrorIyy1ComponentContextString_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpErrorIyy1ComponentContextString
    /// Domain: Text
    /// Length: 512
    /// Varying Length: Y
    /// </summary>
    private string _ExpErrorIyy1ComponentContextString;
    /// <summary>
    /// Attribute for: ExpErrorIyy1ComponentContextString
    /// </summary>
    public string ExpErrorIyy1ComponentContextString {
      get {
        return(_ExpErrorIyy1ComponentContextString);
      }
      set {
        _ExpErrorIyy1ComponentContextString = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpErrorIyy1ComponentReturnCode
    /// </summary>
    private char _ExpErrorIyy1ComponentReturnCode_AS;
    /// <summary>
    /// Attribute missing flag for: ExpErrorIyy1ComponentReturnCode
    /// </summary>
    public char ExpErrorIyy1ComponentReturnCode_AS {
      get {
        return(_ExpErrorIyy1ComponentReturnCode_AS);
      }
      set {
        _ExpErrorIyy1ComponentReturnCode_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpErrorIyy1ComponentReturnCode
    /// Domain: Number
    /// Length: 5
    /// Decimal Places: 0
    /// Decimal Precision: N
    /// </summary>
    private int _ExpErrorIyy1ComponentReturnCode;
    /// <summary>
    /// Attribute for: ExpErrorIyy1ComponentReturnCode
    /// </summary>
    public int ExpErrorIyy1ComponentReturnCode {
      get {
        return(_ExpErrorIyy1ComponentReturnCode);
      }
      set {
        _ExpErrorIyy1ComponentReturnCode = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpErrorIyy1ComponentReasonCode
    /// </summary>
    private char _ExpErrorIyy1ComponentReasonCode_AS;
    /// <summary>
    /// Attribute missing flag for: ExpErrorIyy1ComponentReasonCode
    /// </summary>
    public char ExpErrorIyy1ComponentReasonCode_AS {
      get {
        return(_ExpErrorIyy1ComponentReasonCode_AS);
      }
      set {
        _ExpErrorIyy1ComponentReasonCode_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpErrorIyy1ComponentReasonCode
    /// Domain: Number
    /// Length: 5
    /// Decimal Places: 0
    /// Decimal Precision: N
    /// </summary>
    private int _ExpErrorIyy1ComponentReasonCode;
    /// <summary>
    /// Attribute for: ExpErrorIyy1ComponentReasonCode
    /// </summary>
    public int ExpErrorIyy1ComponentReasonCode {
      get {
        return(_ExpErrorIyy1ComponentReasonCode);
      }
      set {
        _ExpErrorIyy1ComponentReasonCode = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpErrorIyy1ComponentChecksum
    /// </summary>
    private char _ExpErrorIyy1ComponentChecksum_AS;
    /// <summary>
    /// Attribute missing flag for: ExpErrorIyy1ComponentChecksum
    /// </summary>
    public char ExpErrorIyy1ComponentChecksum_AS {
      get {
        return(_ExpErrorIyy1ComponentChecksum_AS);
      }
      set {
        _ExpErrorIyy1ComponentChecksum_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpErrorIyy1ComponentChecksum
    /// Domain: Text
    /// Length: 15
    /// Varying Length: N
    /// </summary>
    private string _ExpErrorIyy1ComponentChecksum;
    /// <summary>
    /// Attribute for: ExpErrorIyy1ComponentChecksum
    /// </summary>
    public string ExpErrorIyy1ComponentChecksum {
      get {
        return(_ExpErrorIyy1ComponentChecksum);
      }
      set {
        _ExpErrorIyy1ComponentChecksum = value;
      }
    }
    /// <summary>
    /// Default Constructor
    /// </summary>
    
    public IYY10251_OA(  )
    {
      Reset(  );
    }
    /// <summary>
    /// Copy Constructor
    /// </summary>
    
    public IYY10251_OA( IYY10251_OA orig )
    {
      ExpGroupList_MA = orig.ExpGroupList_MA;
      Array.Copy( orig._ExpGroupList_AC,
      	ExpGroupList_AC,
      	ExpGroupList_AC.Length );
      Array.Copy( orig._ExpGListIyy1ChildCinstanceId_AS,
      	ExpGListIyy1ChildCinstanceId_AS,
      	ExpGListIyy1ChildCinstanceId_AS.Length );
      Array.Copy( orig._ExpGListIyy1ChildCinstanceId,
      	ExpGListIyy1ChildCinstanceId,
      	ExpGListIyy1ChildCinstanceId.Length );
      Array.Copy( orig._ExpGListIyy1ChildCreferenceId_AS,
      	ExpGListIyy1ChildCreferenceId_AS,
      	ExpGListIyy1ChildCreferenceId_AS.Length );
      Array.Copy( orig._ExpGListIyy1ChildCreferenceId,
      	ExpGListIyy1ChildCreferenceId,
      	ExpGListIyy1ChildCreferenceId.Length );
      Array.Copy( orig._ExpGListIyy1ChildCparentPkeyAttrText_AS,
      	ExpGListIyy1ChildCparentPkeyAttrText_AS,
      	ExpGListIyy1ChildCparentPkeyAttrText_AS.Length );
      Array.Copy( orig._ExpGListIyy1ChildCparentPkeyAttrText,
      	ExpGListIyy1ChildCparentPkeyAttrText,
      	ExpGListIyy1ChildCparentPkeyAttrText.Length );
      Array.Copy( orig._ExpGListIyy1ChildCkeyAttrNum_AS,
      	ExpGListIyy1ChildCkeyAttrNum_AS,
      	ExpGListIyy1ChildCkeyAttrNum_AS.Length );
      Array.Copy( orig._ExpGListIyy1ChildCkeyAttrNum,
      	ExpGListIyy1ChildCkeyAttrNum,
      	ExpGListIyy1ChildCkeyAttrNum.Length );
      Array.Copy( orig._ExpGListIyy1ChildCsearchAttrText_AS,
      	ExpGListIyy1ChildCsearchAttrText_AS,
      	ExpGListIyy1ChildCsearchAttrText_AS.Length );
      Array.Copy( orig._ExpGListIyy1ChildCsearchAttrText,
      	ExpGListIyy1ChildCsearchAttrText,
      	ExpGListIyy1ChildCsearchAttrText.Length );
      Array.Copy( orig._ExpGListIyy1ChildCotherAttrText_AS,
      	ExpGListIyy1ChildCotherAttrText_AS,
      	ExpGListIyy1ChildCotherAttrText_AS.Length );
      Array.Copy( orig._ExpGListIyy1ChildCotherAttrText,
      	ExpGListIyy1ChildCotherAttrText,
      	ExpGListIyy1ChildCotherAttrText.Length );
      ExpErrorIyy1ComponentSeverityCode_AS = orig.ExpErrorIyy1ComponentSeverityCode_AS;
      ExpErrorIyy1ComponentSeverityCode = orig.ExpErrorIyy1ComponentSeverityCode;
      ExpErrorIyy1ComponentRollbackIndicator_AS = orig.ExpErrorIyy1ComponentRollbackIndicator_AS;
      ExpErrorIyy1ComponentRollbackIndicator = orig.ExpErrorIyy1ComponentRollbackIndicator;
      ExpErrorIyy1ComponentOriginServid_AS = orig.ExpErrorIyy1ComponentOriginServid_AS;
      ExpErrorIyy1ComponentOriginServid = orig.ExpErrorIyy1ComponentOriginServid;
      ExpErrorIyy1ComponentContextString_AS = orig.ExpErrorIyy1ComponentContextString_AS;
      ExpErrorIyy1ComponentContextString = orig.ExpErrorIyy1ComponentContextString;
      ExpErrorIyy1ComponentReturnCode_AS = orig.ExpErrorIyy1ComponentReturnCode_AS;
      ExpErrorIyy1ComponentReturnCode = orig.ExpErrorIyy1ComponentReturnCode;
      ExpErrorIyy1ComponentReasonCode_AS = orig.ExpErrorIyy1ComponentReasonCode_AS;
      ExpErrorIyy1ComponentReasonCode = orig.ExpErrorIyy1ComponentReasonCode;
      ExpErrorIyy1ComponentChecksum_AS = orig.ExpErrorIyy1ComponentChecksum_AS;
      ExpErrorIyy1ComponentChecksum = orig.ExpErrorIyy1ComponentChecksum;
    }
    /// <summary>
    /// Static instance creator function
    /// </summary>
    
    public static IYY10251_OA GetInstance(  )
    {
      if ( countFree == 0 )
      {
        return(new IYY10251_OA());
      }
      else 
      {
        lock (freeArray)
        {
          if ( countFree == 0 )
          {
            return(new IYY10251_OA());
          }
          else 
          {
            IYY10251_OA result = freeArray[--countFree];
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
      return(new IYY10251_OA(this));
    }
    /// <summary>
    /// Resets all properties to the defaults.
    /// </summary>
    
    public void Reset(  )
    {
      ExpGroupList_MA = 0;
      for(int a = 0; a < 48; a++)
      {
        ExpGroupList_AC[ a] = ' ';
        ExpGListIyy1ChildCinstanceId_AS[ a] = ' ';
        ExpGListIyy1ChildCinstanceId[ a] = "00000000000000000000";
        ExpGListIyy1ChildCreferenceId_AS[ a] = ' ';
        ExpGListIyy1ChildCreferenceId[ a] = "00000000000000000000";
        ExpGListIyy1ChildCparentPkeyAttrText_AS[ a] = ' ';
        ExpGListIyy1ChildCparentPkeyAttrText[ a] = "     ";
        ExpGListIyy1ChildCkeyAttrNum_AS[ a] = ' ';
        ExpGListIyy1ChildCkeyAttrNum[ a] = 0;
        ExpGListIyy1ChildCsearchAttrText_AS[ a] = ' ';
        ExpGListIyy1ChildCsearchAttrText[ a] = "                         ";
        ExpGListIyy1ChildCotherAttrText_AS[ a] = ' ';
        ExpGListIyy1ChildCotherAttrText[ a] = "                         ";
      }
      ExpErrorIyy1ComponentSeverityCode_AS = ' ';
      ExpErrorIyy1ComponentSeverityCode = " ";
      ExpErrorIyy1ComponentRollbackIndicator_AS = ' ';
      ExpErrorIyy1ComponentRollbackIndicator = " ";
      ExpErrorIyy1ComponentOriginServid_AS = ' ';
      ExpErrorIyy1ComponentOriginServid = 0.0;
      ExpErrorIyy1ComponentContextString_AS = ' ';
      ExpErrorIyy1ComponentContextString = "";
      ExpErrorIyy1ComponentReturnCode_AS = ' ';
      ExpErrorIyy1ComponentReturnCode = 0;
      ExpErrorIyy1ComponentReasonCode_AS = ' ';
      ExpErrorIyy1ComponentReasonCode = 0;
      ExpErrorIyy1ComponentChecksum_AS = ' ';
      ExpErrorIyy1ComponentChecksum = "               ";
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
      this.CopyFrom((IYY10251_OA) orig);
    }
    
    /// <summary>
    /// Sets the current instance based on the passed view.
    /// </summary>
    public void CopyFrom( IYY10251_OA orig )
    {
      ExpGroupList_MA = orig.ExpGroupList_MA;
      for(int a = 0; a < 48; a++)
      {
        ExpGroupList_AC[ a] = orig.ExpGroupList_AC[ a];
        ExpGListIyy1ChildCinstanceId_AS[ a] = orig.ExpGListIyy1ChildCinstanceId_AS[ a];
        ExpGListIyy1ChildCinstanceId[ a] = orig.ExpGListIyy1ChildCinstanceId[ a];
        ExpGListIyy1ChildCreferenceId_AS[ a] = orig.ExpGListIyy1ChildCreferenceId_AS[ a];
        ExpGListIyy1ChildCreferenceId[ a] = orig.ExpGListIyy1ChildCreferenceId[ a];
        ExpGListIyy1ChildCparentPkeyAttrText_AS[ a] = orig.ExpGListIyy1ChildCparentPkeyAttrText_AS[ a];
        ExpGListIyy1ChildCparentPkeyAttrText[ a] = orig.ExpGListIyy1ChildCparentPkeyAttrText[ a];
        ExpGListIyy1ChildCkeyAttrNum_AS[ a] = orig.ExpGListIyy1ChildCkeyAttrNum_AS[ a];
        ExpGListIyy1ChildCkeyAttrNum[ a] = orig.ExpGListIyy1ChildCkeyAttrNum[ a];
        ExpGListIyy1ChildCsearchAttrText_AS[ a] = orig.ExpGListIyy1ChildCsearchAttrText_AS[ a];
        ExpGListIyy1ChildCsearchAttrText[ a] = orig.ExpGListIyy1ChildCsearchAttrText[ a];
        ExpGListIyy1ChildCotherAttrText_AS[ a] = orig.ExpGListIyy1ChildCotherAttrText_AS[ a];
        ExpGListIyy1ChildCotherAttrText[ a] = orig.ExpGListIyy1ChildCotherAttrText[ a];
      }
      ExpErrorIyy1ComponentSeverityCode_AS = orig.ExpErrorIyy1ComponentSeverityCode_AS;
      ExpErrorIyy1ComponentSeverityCode = orig.ExpErrorIyy1ComponentSeverityCode;
      ExpErrorIyy1ComponentRollbackIndicator_AS = orig.ExpErrorIyy1ComponentRollbackIndicator_AS;
      ExpErrorIyy1ComponentRollbackIndicator = orig.ExpErrorIyy1ComponentRollbackIndicator;
      ExpErrorIyy1ComponentOriginServid_AS = orig.ExpErrorIyy1ComponentOriginServid_AS;
      ExpErrorIyy1ComponentOriginServid = orig.ExpErrorIyy1ComponentOriginServid;
      ExpErrorIyy1ComponentContextString_AS = orig.ExpErrorIyy1ComponentContextString_AS;
      ExpErrorIyy1ComponentContextString = orig.ExpErrorIyy1ComponentContextString;
      ExpErrorIyy1ComponentReturnCode_AS = orig.ExpErrorIyy1ComponentReturnCode_AS;
      ExpErrorIyy1ComponentReturnCode = orig.ExpErrorIyy1ComponentReturnCode;
      ExpErrorIyy1ComponentReasonCode_AS = orig.ExpErrorIyy1ComponentReasonCode_AS;
      ExpErrorIyy1ComponentReasonCode = orig.ExpErrorIyy1ComponentReasonCode;
      ExpErrorIyy1ComponentChecksum_AS = orig.ExpErrorIyy1ComponentChecksum_AS;
      ExpErrorIyy1ComponentChecksum = orig.ExpErrorIyy1ComponentChecksum;
    }
  }
}
