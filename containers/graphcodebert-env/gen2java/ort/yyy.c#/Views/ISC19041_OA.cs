// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
//
//                    Source Code Generated by
//                           CA Gen 8.6
//
//    Copyright (c) 2024 CA Technologies. All rights reserved.
//
//    Name: ISC19041_OA                      Date: 2024/01/09
//    User: AliAl                            Time: 13:40:37
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
  /// Internal data view storage for: ISC19041_OA
  /// </summary>
  [Serializable]
  public class ISC19041_OA : ViewBase, IExportView
  {
    private static ISC19041_OA[] freeArray = new ISC19041_OA[30];
    private static int countFree = 0;
    
    // Entity View: EXP_ERROR_MSG
    //        Type: ISC1_COMPONENT
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpErrorMsgIsc1ComponentSeverityCode
    /// </summary>
    private char _ExpErrorMsgIsc1ComponentSeverityCode_AS;
    /// <summary>
    /// Attribute missing flag for: ExpErrorMsgIsc1ComponentSeverityCode
    /// </summary>
    public char ExpErrorMsgIsc1ComponentSeverityCode_AS {
      get {
        return(_ExpErrorMsgIsc1ComponentSeverityCode_AS);
      }
      set {
        _ExpErrorMsgIsc1ComponentSeverityCode_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpErrorMsgIsc1ComponentSeverityCode
    /// Domain: Text
    /// Length: 1
    /// Varying Length: N
    /// </summary>
    private string _ExpErrorMsgIsc1ComponentSeverityCode;
    /// <summary>
    /// Attribute for: ExpErrorMsgIsc1ComponentSeverityCode
    /// </summary>
    public string ExpErrorMsgIsc1ComponentSeverityCode {
      get {
        return(_ExpErrorMsgIsc1ComponentSeverityCode);
      }
      set {
        _ExpErrorMsgIsc1ComponentSeverityCode = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpErrorMsgIsc1ComponentMessageTx
    /// </summary>
    private char _ExpErrorMsgIsc1ComponentMessageTx_AS;
    /// <summary>
    /// Attribute missing flag for: ExpErrorMsgIsc1ComponentMessageTx
    /// </summary>
    public char ExpErrorMsgIsc1ComponentMessageTx_AS {
      get {
        return(_ExpErrorMsgIsc1ComponentMessageTx_AS);
      }
      set {
        _ExpErrorMsgIsc1ComponentMessageTx_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpErrorMsgIsc1ComponentMessageTx
    /// Domain: Text
    /// Length: 512
    /// Varying Length: Y
    /// </summary>
    private string _ExpErrorMsgIsc1ComponentMessageTx;
    /// <summary>
    /// Attribute for: ExpErrorMsgIsc1ComponentMessageTx
    /// </summary>
    public string ExpErrorMsgIsc1ComponentMessageTx {
      get {
        return(_ExpErrorMsgIsc1ComponentMessageTx);
      }
      set {
        _ExpErrorMsgIsc1ComponentMessageTx = value;
      }
    }
    // Entity View: EXP_ERROR
    //        Type: ISC1_COMPONENT
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpErrorIsc1ComponentSeverityCode
    /// </summary>
    private char _ExpErrorIsc1ComponentSeverityCode_AS;
    /// <summary>
    /// Attribute missing flag for: ExpErrorIsc1ComponentSeverityCode
    /// </summary>
    public char ExpErrorIsc1ComponentSeverityCode_AS {
      get {
        return(_ExpErrorIsc1ComponentSeverityCode_AS);
      }
      set {
        _ExpErrorIsc1ComponentSeverityCode_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpErrorIsc1ComponentSeverityCode
    /// Domain: Text
    /// Length: 1
    /// Varying Length: N
    /// </summary>
    private string _ExpErrorIsc1ComponentSeverityCode;
    /// <summary>
    /// Attribute for: ExpErrorIsc1ComponentSeverityCode
    /// </summary>
    public string ExpErrorIsc1ComponentSeverityCode {
      get {
        return(_ExpErrorIsc1ComponentSeverityCode);
      }
      set {
        _ExpErrorIsc1ComponentSeverityCode = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpErrorIsc1ComponentRollbackIndicator
    /// </summary>
    private char _ExpErrorIsc1ComponentRollbackIndicator_AS;
    /// <summary>
    /// Attribute missing flag for: ExpErrorIsc1ComponentRollbackIndicator
    /// </summary>
    public char ExpErrorIsc1ComponentRollbackIndicator_AS {
      get {
        return(_ExpErrorIsc1ComponentRollbackIndicator_AS);
      }
      set {
        _ExpErrorIsc1ComponentRollbackIndicator_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpErrorIsc1ComponentRollbackIndicator
    /// Domain: Text
    /// Length: 1
    /// Varying Length: N
    /// </summary>
    private string _ExpErrorIsc1ComponentRollbackIndicator;
    /// <summary>
    /// Attribute for: ExpErrorIsc1ComponentRollbackIndicator
    /// </summary>
    public string ExpErrorIsc1ComponentRollbackIndicator {
      get {
        return(_ExpErrorIsc1ComponentRollbackIndicator);
      }
      set {
        _ExpErrorIsc1ComponentRollbackIndicator = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpErrorIsc1ComponentOriginServid
    /// </summary>
    private char _ExpErrorIsc1ComponentOriginServid_AS;
    /// <summary>
    /// Attribute missing flag for: ExpErrorIsc1ComponentOriginServid
    /// </summary>
    public char ExpErrorIsc1ComponentOriginServid_AS {
      get {
        return(_ExpErrorIsc1ComponentOriginServid_AS);
      }
      set {
        _ExpErrorIsc1ComponentOriginServid_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpErrorIsc1ComponentOriginServid
    /// Domain: Number
    /// Length: 15
    /// Decimal Places: 0
    /// Decimal Precision: N
    /// </summary>
    private double _ExpErrorIsc1ComponentOriginServid;
    /// <summary>
    /// Attribute for: ExpErrorIsc1ComponentOriginServid
    /// </summary>
    public double ExpErrorIsc1ComponentOriginServid {
      get {
        return(_ExpErrorIsc1ComponentOriginServid);
      }
      set {
        _ExpErrorIsc1ComponentOriginServid = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpErrorIsc1ComponentContextString
    /// </summary>
    private char _ExpErrorIsc1ComponentContextString_AS;
    /// <summary>
    /// Attribute missing flag for: ExpErrorIsc1ComponentContextString
    /// </summary>
    public char ExpErrorIsc1ComponentContextString_AS {
      get {
        return(_ExpErrorIsc1ComponentContextString_AS);
      }
      set {
        _ExpErrorIsc1ComponentContextString_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpErrorIsc1ComponentContextString
    /// Domain: Text
    /// Length: 512
    /// Varying Length: Y
    /// </summary>
    private string _ExpErrorIsc1ComponentContextString;
    /// <summary>
    /// Attribute for: ExpErrorIsc1ComponentContextString
    /// </summary>
    public string ExpErrorIsc1ComponentContextString {
      get {
        return(_ExpErrorIsc1ComponentContextString);
      }
      set {
        _ExpErrorIsc1ComponentContextString = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpErrorIsc1ComponentReturnCode
    /// </summary>
    private char _ExpErrorIsc1ComponentReturnCode_AS;
    /// <summary>
    /// Attribute missing flag for: ExpErrorIsc1ComponentReturnCode
    /// </summary>
    public char ExpErrorIsc1ComponentReturnCode_AS {
      get {
        return(_ExpErrorIsc1ComponentReturnCode_AS);
      }
      set {
        _ExpErrorIsc1ComponentReturnCode_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpErrorIsc1ComponentReturnCode
    /// Domain: Number
    /// Length: 5
    /// Decimal Places: 0
    /// Decimal Precision: N
    /// </summary>
    private int _ExpErrorIsc1ComponentReturnCode;
    /// <summary>
    /// Attribute for: ExpErrorIsc1ComponentReturnCode
    /// </summary>
    public int ExpErrorIsc1ComponentReturnCode {
      get {
        return(_ExpErrorIsc1ComponentReturnCode);
      }
      set {
        _ExpErrorIsc1ComponentReturnCode = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpErrorIsc1ComponentReasonCode
    /// </summary>
    private char _ExpErrorIsc1ComponentReasonCode_AS;
    /// <summary>
    /// Attribute missing flag for: ExpErrorIsc1ComponentReasonCode
    /// </summary>
    public char ExpErrorIsc1ComponentReasonCode_AS {
      get {
        return(_ExpErrorIsc1ComponentReasonCode_AS);
      }
      set {
        _ExpErrorIsc1ComponentReasonCode_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpErrorIsc1ComponentReasonCode
    /// Domain: Number
    /// Length: 5
    /// Decimal Places: 0
    /// Decimal Precision: N
    /// </summary>
    private int _ExpErrorIsc1ComponentReasonCode;
    /// <summary>
    /// Attribute for: ExpErrorIsc1ComponentReasonCode
    /// </summary>
    public int ExpErrorIsc1ComponentReasonCode {
      get {
        return(_ExpErrorIsc1ComponentReasonCode);
      }
      set {
        _ExpErrorIsc1ComponentReasonCode = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: ExpErrorIsc1ComponentChecksum
    /// </summary>
    private char _ExpErrorIsc1ComponentChecksum_AS;
    /// <summary>
    /// Attribute missing flag for: ExpErrorIsc1ComponentChecksum
    /// </summary>
    public char ExpErrorIsc1ComponentChecksum_AS {
      get {
        return(_ExpErrorIsc1ComponentChecksum_AS);
      }
      set {
        _ExpErrorIsc1ComponentChecksum_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ExpErrorIsc1ComponentChecksum
    /// Domain: Text
    /// Length: 15
    /// Varying Length: N
    /// </summary>
    private string _ExpErrorIsc1ComponentChecksum;
    /// <summary>
    /// Attribute for: ExpErrorIsc1ComponentChecksum
    /// </summary>
    public string ExpErrorIsc1ComponentChecksum {
      get {
        return(_ExpErrorIsc1ComponentChecksum);
      }
      set {
        _ExpErrorIsc1ComponentChecksum = value;
      }
    }
    /// <summary>
    /// Default Constructor
    /// </summary>
    
    public ISC19041_OA(  )
    {
      Reset(  );
    }
    /// <summary>
    /// Copy Constructor
    /// </summary>
    
    public ISC19041_OA( ISC19041_OA orig )
    {
      ExpErrorMsgIsc1ComponentSeverityCode_AS = orig.ExpErrorMsgIsc1ComponentSeverityCode_AS;
      ExpErrorMsgIsc1ComponentSeverityCode = orig.ExpErrorMsgIsc1ComponentSeverityCode;
      ExpErrorMsgIsc1ComponentMessageTx_AS = orig.ExpErrorMsgIsc1ComponentMessageTx_AS;
      ExpErrorMsgIsc1ComponentMessageTx = orig.ExpErrorMsgIsc1ComponentMessageTx;
      ExpErrorIsc1ComponentSeverityCode_AS = orig.ExpErrorIsc1ComponentSeverityCode_AS;
      ExpErrorIsc1ComponentSeverityCode = orig.ExpErrorIsc1ComponentSeverityCode;
      ExpErrorIsc1ComponentRollbackIndicator_AS = orig.ExpErrorIsc1ComponentRollbackIndicator_AS;
      ExpErrorIsc1ComponentRollbackIndicator = orig.ExpErrorIsc1ComponentRollbackIndicator;
      ExpErrorIsc1ComponentOriginServid_AS = orig.ExpErrorIsc1ComponentOriginServid_AS;
      ExpErrorIsc1ComponentOriginServid = orig.ExpErrorIsc1ComponentOriginServid;
      ExpErrorIsc1ComponentContextString_AS = orig.ExpErrorIsc1ComponentContextString_AS;
      ExpErrorIsc1ComponentContextString = orig.ExpErrorIsc1ComponentContextString;
      ExpErrorIsc1ComponentReturnCode_AS = orig.ExpErrorIsc1ComponentReturnCode_AS;
      ExpErrorIsc1ComponentReturnCode = orig.ExpErrorIsc1ComponentReturnCode;
      ExpErrorIsc1ComponentReasonCode_AS = orig.ExpErrorIsc1ComponentReasonCode_AS;
      ExpErrorIsc1ComponentReasonCode = orig.ExpErrorIsc1ComponentReasonCode;
      ExpErrorIsc1ComponentChecksum_AS = orig.ExpErrorIsc1ComponentChecksum_AS;
      ExpErrorIsc1ComponentChecksum = orig.ExpErrorIsc1ComponentChecksum;
    }
    /// <summary>
    /// Static instance creator function
    /// </summary>
    
    public static ISC19041_OA GetInstance(  )
    {
      if ( countFree == 0 )
      {
        return(new ISC19041_OA());
      }
      else 
      {
        lock (freeArray)
        {
          if ( countFree == 0 )
          {
            return(new ISC19041_OA());
          }
          else 
          {
            ISC19041_OA result = freeArray[--countFree];
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
      return(new ISC19041_OA(this));
    }
    /// <summary>
    /// Resets all properties to the defaults.
    /// </summary>
    
    public void Reset(  )
    {
      ExpErrorMsgIsc1ComponentSeverityCode_AS = ' ';
      ExpErrorMsgIsc1ComponentSeverityCode = " ";
      ExpErrorMsgIsc1ComponentMessageTx_AS = ' ';
      ExpErrorMsgIsc1ComponentMessageTx = "";
      ExpErrorIsc1ComponentSeverityCode_AS = ' ';
      ExpErrorIsc1ComponentSeverityCode = " ";
      ExpErrorIsc1ComponentRollbackIndicator_AS = ' ';
      ExpErrorIsc1ComponentRollbackIndicator = " ";
      ExpErrorIsc1ComponentOriginServid_AS = ' ';
      ExpErrorIsc1ComponentOriginServid = 0.0;
      ExpErrorIsc1ComponentContextString_AS = ' ';
      ExpErrorIsc1ComponentContextString = "";
      ExpErrorIsc1ComponentReturnCode_AS = ' ';
      ExpErrorIsc1ComponentReturnCode = 0;
      ExpErrorIsc1ComponentReasonCode_AS = ' ';
      ExpErrorIsc1ComponentReasonCode = 0;
      ExpErrorIsc1ComponentChecksum_AS = ' ';
      ExpErrorIsc1ComponentChecksum = "               ";
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
      this.CopyFrom((ISC19041_OA) orig);
    }
    
    /// <summary>
    /// Sets the current instance based on the passed view.
    /// </summary>
    public void CopyFrom( ISC19041_OA orig )
    {
      ExpErrorMsgIsc1ComponentSeverityCode_AS = orig.ExpErrorMsgIsc1ComponentSeverityCode_AS;
      ExpErrorMsgIsc1ComponentSeverityCode = orig.ExpErrorMsgIsc1ComponentSeverityCode;
      ExpErrorMsgIsc1ComponentMessageTx_AS = orig.ExpErrorMsgIsc1ComponentMessageTx_AS;
      ExpErrorMsgIsc1ComponentMessageTx = orig.ExpErrorMsgIsc1ComponentMessageTx;
      ExpErrorIsc1ComponentSeverityCode_AS = orig.ExpErrorIsc1ComponentSeverityCode_AS;
      ExpErrorIsc1ComponentSeverityCode = orig.ExpErrorIsc1ComponentSeverityCode;
      ExpErrorIsc1ComponentRollbackIndicator_AS = orig.ExpErrorIsc1ComponentRollbackIndicator_AS;
      ExpErrorIsc1ComponentRollbackIndicator = orig.ExpErrorIsc1ComponentRollbackIndicator;
      ExpErrorIsc1ComponentOriginServid_AS = orig.ExpErrorIsc1ComponentOriginServid_AS;
      ExpErrorIsc1ComponentOriginServid = orig.ExpErrorIsc1ComponentOriginServid;
      ExpErrorIsc1ComponentContextString_AS = orig.ExpErrorIsc1ComponentContextString_AS;
      ExpErrorIsc1ComponentContextString = orig.ExpErrorIsc1ComponentContextString;
      ExpErrorIsc1ComponentReturnCode_AS = orig.ExpErrorIsc1ComponentReturnCode_AS;
      ExpErrorIsc1ComponentReturnCode = orig.ExpErrorIsc1ComponentReturnCode;
      ExpErrorIsc1ComponentReasonCode_AS = orig.ExpErrorIsc1ComponentReasonCode_AS;
      ExpErrorIsc1ComponentReasonCode = orig.ExpErrorIsc1ComponentReasonCode;
      ExpErrorIsc1ComponentChecksum_AS = orig.ExpErrorIsc1ComponentChecksum_AS;
      ExpErrorIsc1ComponentChecksum = orig.ExpErrorIsc1ComponentChecksum;
    }
  }
}
