// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
//
//                    Source Code Generated by
//                           CA Gen 8.6
//
//    Copyright (c) 2024 CA Technologies. All rights reserved.
//
//    Name: IRO10481_OA                      Date: 2024/01/09
//    User: AliAl                            Time: 13:41:48
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
  /// Internal data view storage for: IRO10481_OA
  /// </summary>
  [Serializable]
  public class IRO10481_OA : ViewBase, IExportView
  {
    private static IRO10481_OA[] freeArray = new IRO10481_OA[30];
    private static int countFree = 0;
    
    // Entity View: OUT_DATA
    //        Type: IRO1_COMPONENT
    /// <summary>
    /// Internal storage for attribute missing flag for: OutDataIro1ComponentSeverityCd
    /// </summary>
    private char _OutDataIro1ComponentSeverityCd_AS;
    /// <summary>
    /// Attribute missing flag for: OutDataIro1ComponentSeverityCd
    /// </summary>
    public char OutDataIro1ComponentSeverityCd_AS {
      get {
        return(_OutDataIro1ComponentSeverityCd_AS);
      }
      set {
        _OutDataIro1ComponentSeverityCd_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: OutDataIro1ComponentSeverityCd
    /// Domain: Text
    /// Length: 1
    /// Varying Length: N
    /// </summary>
    private string _OutDataIro1ComponentSeverityCd;
    /// <summary>
    /// Attribute for: OutDataIro1ComponentSeverityCd
    /// </summary>
    public string OutDataIro1ComponentSeverityCd {
      get {
        return(_OutDataIro1ComponentSeverityCd);
      }
      set {
        _OutDataIro1ComponentSeverityCd = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: OutDataIro1ComponentMessageTx
    /// </summary>
    private char _OutDataIro1ComponentMessageTx_AS;
    /// <summary>
    /// Attribute missing flag for: OutDataIro1ComponentMessageTx
    /// </summary>
    public char OutDataIro1ComponentMessageTx_AS {
      get {
        return(_OutDataIro1ComponentMessageTx_AS);
      }
      set {
        _OutDataIro1ComponentMessageTx_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: OutDataIro1ComponentMessageTx
    /// Domain: Text
    /// Length: 512
    /// Varying Length: Y
    /// </summary>
    private string _OutDataIro1ComponentMessageTx;
    /// <summary>
    /// Attribute for: OutDataIro1ComponentMessageTx
    /// </summary>
    public string OutDataIro1ComponentMessageTx {
      get {
        return(_OutDataIro1ComponentMessageTx);
      }
      set {
        _OutDataIro1ComponentMessageTx = value;
      }
    }
    // Repeating GV:  OUT_HILITE_GROUP
    //     Repeats: 10 times
    /// <summary>
    /// Internal storage, repeating group view count
    /// </summary>
    private int _OutHiliteGroup_MA;
    /// <summary>
    /// Repeating group view count
    /// </summary>
    public int OutHiliteGroup_MA {
      get {
        return(_OutHiliteGroup_MA);
      }
      set {
        _OutHiliteGroup_MA = value;
      }
    }
    /// <summary>
    /// Internal storage, repeating group view occurrance array
    /// </summary>
    private char[] _OutHiliteGroup_AC = new char[10];
    /// <summary>
    /// Repeating group view occurrance array
    /// </summary>
    public char[] OutHiliteGroup_AC {
      get {
        return(_OutHiliteGroup_AC);
      }
      set {
        _OutHiliteGroup_AC = value;
      }
    }
    // Entity View: OUT_HILITE_G
    //        Type: IRO1_COMPONENT
    /// <summary>
    /// Internal storage for attribute missing flag for: OutHiliteGIro1ComponentAttributeNameTx
    /// </summary>
    private char[] _OutHiliteGIro1ComponentAttributeNameTx_AS = new char[10];
    /// <summary>
    /// Attribute missing flag for: OutHiliteGIro1ComponentAttributeNameTx
    /// </summary>
    public char[] OutHiliteGIro1ComponentAttributeNameTx_AS {
      get {
        return(_OutHiliteGIro1ComponentAttributeNameTx_AS);
      }
      set {
        _OutHiliteGIro1ComponentAttributeNameTx_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: OutHiliteGIro1ComponentAttributeNameTx
    /// Domain: Text
    /// Length: 50
    /// Varying Length: N
    /// </summary>
    private string[] _OutHiliteGIro1ComponentAttributeNameTx = new string[10];
    /// <summary>
    /// Attribute for: OutHiliteGIro1ComponentAttributeNameTx
    /// </summary>
    public string[] OutHiliteGIro1ComponentAttributeNameTx {
      get {
        return(_OutHiliteGIro1ComponentAttributeNameTx);
      }
      set {
        _OutHiliteGIro1ComponentAttributeNameTx = value;
      }
    }
    // Entity View: OUT_ERROR
    //        Type: IRO1_COMPONENT
    /// <summary>
    /// Internal storage for attribute missing flag for: OutErrorIro1ComponentSeverityCd
    /// </summary>
    private char _OutErrorIro1ComponentSeverityCd_AS;
    /// <summary>
    /// Attribute missing flag for: OutErrorIro1ComponentSeverityCd
    /// </summary>
    public char OutErrorIro1ComponentSeverityCd_AS {
      get {
        return(_OutErrorIro1ComponentSeverityCd_AS);
      }
      set {
        _OutErrorIro1ComponentSeverityCd_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: OutErrorIro1ComponentSeverityCd
    /// Domain: Text
    /// Length: 1
    /// Varying Length: N
    /// </summary>
    private string _OutErrorIro1ComponentSeverityCd;
    /// <summary>
    /// Attribute for: OutErrorIro1ComponentSeverityCd
    /// </summary>
    public string OutErrorIro1ComponentSeverityCd {
      get {
        return(_OutErrorIro1ComponentSeverityCd);
      }
      set {
        _OutErrorIro1ComponentSeverityCd = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: OutErrorIro1ComponentRollbackIndicatorTx
    /// </summary>
    private char _OutErrorIro1ComponentRollbackIndicatorTx_AS;
    /// <summary>
    /// Attribute missing flag for: OutErrorIro1ComponentRollbackIndicatorTx
    /// </summary>
    public char OutErrorIro1ComponentRollbackIndicatorTx_AS {
      get {
        return(_OutErrorIro1ComponentRollbackIndicatorTx_AS);
      }
      set {
        _OutErrorIro1ComponentRollbackIndicatorTx_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: OutErrorIro1ComponentRollbackIndicatorTx
    /// Domain: Text
    /// Length: 1
    /// Varying Length: N
    /// </summary>
    private string _OutErrorIro1ComponentRollbackIndicatorTx;
    /// <summary>
    /// Attribute for: OutErrorIro1ComponentRollbackIndicatorTx
    /// </summary>
    public string OutErrorIro1ComponentRollbackIndicatorTx {
      get {
        return(_OutErrorIro1ComponentRollbackIndicatorTx);
      }
      set {
        _OutErrorIro1ComponentRollbackIndicatorTx = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: OutErrorIro1ComponentOriginServid
    /// </summary>
    private char _OutErrorIro1ComponentOriginServid_AS;
    /// <summary>
    /// Attribute missing flag for: OutErrorIro1ComponentOriginServid
    /// </summary>
    public char OutErrorIro1ComponentOriginServid_AS {
      get {
        return(_OutErrorIro1ComponentOriginServid_AS);
      }
      set {
        _OutErrorIro1ComponentOriginServid_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: OutErrorIro1ComponentOriginServid
    /// Domain: Number
    /// Length: 15
    /// Decimal Places: 0
    /// Decimal Precision: N
    /// </summary>
    private double _OutErrorIro1ComponentOriginServid;
    /// <summary>
    /// Attribute for: OutErrorIro1ComponentOriginServid
    /// </summary>
    public double OutErrorIro1ComponentOriginServid {
      get {
        return(_OutErrorIro1ComponentOriginServid);
      }
      set {
        _OutErrorIro1ComponentOriginServid = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: OutErrorIro1ComponentContextStringTx
    /// </summary>
    private char _OutErrorIro1ComponentContextStringTx_AS;
    /// <summary>
    /// Attribute missing flag for: OutErrorIro1ComponentContextStringTx
    /// </summary>
    public char OutErrorIro1ComponentContextStringTx_AS {
      get {
        return(_OutErrorIro1ComponentContextStringTx_AS);
      }
      set {
        _OutErrorIro1ComponentContextStringTx_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: OutErrorIro1ComponentContextStringTx
    /// Domain: Text
    /// Length: 255
    /// Varying Length: Y
    /// </summary>
    private string _OutErrorIro1ComponentContextStringTx;
    /// <summary>
    /// Attribute for: OutErrorIro1ComponentContextStringTx
    /// </summary>
    public string OutErrorIro1ComponentContextStringTx {
      get {
        return(_OutErrorIro1ComponentContextStringTx);
      }
      set {
        _OutErrorIro1ComponentContextStringTx = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: OutErrorIro1ComponentReturnCode
    /// </summary>
    private char _OutErrorIro1ComponentReturnCode_AS;
    /// <summary>
    /// Attribute missing flag for: OutErrorIro1ComponentReturnCode
    /// </summary>
    public char OutErrorIro1ComponentReturnCode_AS {
      get {
        return(_OutErrorIro1ComponentReturnCode_AS);
      }
      set {
        _OutErrorIro1ComponentReturnCode_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: OutErrorIro1ComponentReturnCode
    /// Domain: Number
    /// Length: 5
    /// Decimal Places: 0
    /// Decimal Precision: N
    /// </summary>
    private int _OutErrorIro1ComponentReturnCode;
    /// <summary>
    /// Attribute for: OutErrorIro1ComponentReturnCode
    /// </summary>
    public int OutErrorIro1ComponentReturnCode {
      get {
        return(_OutErrorIro1ComponentReturnCode);
      }
      set {
        _OutErrorIro1ComponentReturnCode = value;
      }
    }
    /// <summary>
    /// Internal storage for attribute missing flag for: OutErrorIro1ComponentReasonCode
    /// </summary>
    private char _OutErrorIro1ComponentReasonCode_AS;
    /// <summary>
    /// Attribute missing flag for: OutErrorIro1ComponentReasonCode
    /// </summary>
    public char OutErrorIro1ComponentReasonCode_AS {
      get {
        return(_OutErrorIro1ComponentReasonCode_AS);
      }
      set {
        _OutErrorIro1ComponentReasonCode_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: OutErrorIro1ComponentReasonCode
    /// Domain: Number
    /// Length: 5
    /// Decimal Places: 0
    /// Decimal Precision: N
    /// </summary>
    private int _OutErrorIro1ComponentReasonCode;
    /// <summary>
    /// Attribute for: OutErrorIro1ComponentReasonCode
    /// </summary>
    public int OutErrorIro1ComponentReasonCode {
      get {
        return(_OutErrorIro1ComponentReasonCode);
      }
      set {
        _OutErrorIro1ComponentReasonCode = value;
      }
    }
    /// <summary>
    /// Default Constructor
    /// </summary>
    
    public IRO10481_OA(  )
    {
      Reset(  );
    }
    /// <summary>
    /// Copy Constructor
    /// </summary>
    
    public IRO10481_OA( IRO10481_OA orig )
    {
      OutDataIro1ComponentSeverityCd_AS = orig.OutDataIro1ComponentSeverityCd_AS;
      OutDataIro1ComponentSeverityCd = orig.OutDataIro1ComponentSeverityCd;
      OutDataIro1ComponentMessageTx_AS = orig.OutDataIro1ComponentMessageTx_AS;
      OutDataIro1ComponentMessageTx = orig.OutDataIro1ComponentMessageTx;
      OutHiliteGroup_MA = orig.OutHiliteGroup_MA;
      Array.Copy( orig._OutHiliteGroup_AC,
      	OutHiliteGroup_AC,
      	OutHiliteGroup_AC.Length );
      Array.Copy( orig._OutHiliteGIro1ComponentAttributeNameTx_AS,
      	OutHiliteGIro1ComponentAttributeNameTx_AS,
      	OutHiliteGIro1ComponentAttributeNameTx_AS.Length );
      Array.Copy( orig._OutHiliteGIro1ComponentAttributeNameTx,
      	OutHiliteGIro1ComponentAttributeNameTx,
      	OutHiliteGIro1ComponentAttributeNameTx.Length );
      OutErrorIro1ComponentSeverityCd_AS = orig.OutErrorIro1ComponentSeverityCd_AS;
      OutErrorIro1ComponentSeverityCd = orig.OutErrorIro1ComponentSeverityCd;
      OutErrorIro1ComponentRollbackIndicatorTx_AS = orig.OutErrorIro1ComponentRollbackIndicatorTx_AS;
      OutErrorIro1ComponentRollbackIndicatorTx = orig.OutErrorIro1ComponentRollbackIndicatorTx;
      OutErrorIro1ComponentOriginServid_AS = orig.OutErrorIro1ComponentOriginServid_AS;
      OutErrorIro1ComponentOriginServid = orig.OutErrorIro1ComponentOriginServid;
      OutErrorIro1ComponentContextStringTx_AS = orig.OutErrorIro1ComponentContextStringTx_AS;
      OutErrorIro1ComponentContextStringTx = orig.OutErrorIro1ComponentContextStringTx;
      OutErrorIro1ComponentReturnCode_AS = orig.OutErrorIro1ComponentReturnCode_AS;
      OutErrorIro1ComponentReturnCode = orig.OutErrorIro1ComponentReturnCode;
      OutErrorIro1ComponentReasonCode_AS = orig.OutErrorIro1ComponentReasonCode_AS;
      OutErrorIro1ComponentReasonCode = orig.OutErrorIro1ComponentReasonCode;
    }
    /// <summary>
    /// Static instance creator function
    /// </summary>
    
    public static IRO10481_OA GetInstance(  )
    {
      if ( countFree == 0 )
      {
        return(new IRO10481_OA());
      }
      else 
      {
        lock (freeArray)
        {
          if ( countFree == 0 )
          {
            return(new IRO10481_OA());
          }
          else 
          {
            IRO10481_OA result = freeArray[--countFree];
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
      return(new IRO10481_OA(this));
    }
    /// <summary>
    /// Resets all properties to the defaults.
    /// </summary>
    
    public void Reset(  )
    {
      OutDataIro1ComponentSeverityCd_AS = ' ';
      OutDataIro1ComponentSeverityCd = " ";
      OutDataIro1ComponentMessageTx_AS = ' ';
      OutDataIro1ComponentMessageTx = "";
      OutHiliteGroup_MA = 0;
      for(int a = 0; a < 10; a++)
      {
        OutHiliteGroup_AC[ a] = ' ';
        OutHiliteGIro1ComponentAttributeNameTx_AS[ a] = ' ';
        OutHiliteGIro1ComponentAttributeNameTx[ a] = "                                                  ";
      }
      OutErrorIro1ComponentSeverityCd_AS = ' ';
      OutErrorIro1ComponentSeverityCd = " ";
      OutErrorIro1ComponentRollbackIndicatorTx_AS = ' ';
      OutErrorIro1ComponentRollbackIndicatorTx = " ";
      OutErrorIro1ComponentOriginServid_AS = ' ';
      OutErrorIro1ComponentOriginServid = 0.0;
      OutErrorIro1ComponentContextStringTx_AS = ' ';
      OutErrorIro1ComponentContextStringTx = "";
      OutErrorIro1ComponentReturnCode_AS = ' ';
      OutErrorIro1ComponentReturnCode = 0;
      OutErrorIro1ComponentReasonCode_AS = ' ';
      OutErrorIro1ComponentReasonCode = 0;
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
      this.CopyFrom((IRO10481_OA) orig);
    }
    
    /// <summary>
    /// Sets the current instance based on the passed view.
    /// </summary>
    public void CopyFrom( IRO10481_OA orig )
    {
      OutDataIro1ComponentSeverityCd_AS = orig.OutDataIro1ComponentSeverityCd_AS;
      OutDataIro1ComponentSeverityCd = orig.OutDataIro1ComponentSeverityCd;
      OutDataIro1ComponentMessageTx_AS = orig.OutDataIro1ComponentMessageTx_AS;
      OutDataIro1ComponentMessageTx = orig.OutDataIro1ComponentMessageTx;
      OutHiliteGroup_MA = orig.OutHiliteGroup_MA;
      for(int a = 0; a < 10; a++)
      {
        OutHiliteGroup_AC[ a] = orig.OutHiliteGroup_AC[ a];
        OutHiliteGIro1ComponentAttributeNameTx_AS[ a] = orig.OutHiliteGIro1ComponentAttributeNameTx_AS[ a];
        OutHiliteGIro1ComponentAttributeNameTx[ a] = orig.OutHiliteGIro1ComponentAttributeNameTx[ a];
      }
      OutErrorIro1ComponentSeverityCd_AS = orig.OutErrorIro1ComponentSeverityCd_AS;
      OutErrorIro1ComponentSeverityCd = orig.OutErrorIro1ComponentSeverityCd;
      OutErrorIro1ComponentRollbackIndicatorTx_AS = orig.OutErrorIro1ComponentRollbackIndicatorTx_AS;
      OutErrorIro1ComponentRollbackIndicatorTx = orig.OutErrorIro1ComponentRollbackIndicatorTx;
      OutErrorIro1ComponentOriginServid_AS = orig.OutErrorIro1ComponentOriginServid_AS;
      OutErrorIro1ComponentOriginServid = orig.OutErrorIro1ComponentOriginServid;
      OutErrorIro1ComponentContextStringTx_AS = orig.OutErrorIro1ComponentContextStringTx_AS;
      OutErrorIro1ComponentContextStringTx = orig.OutErrorIro1ComponentContextStringTx;
      OutErrorIro1ComponentReturnCode_AS = orig.OutErrorIro1ComponentReturnCode_AS;
      OutErrorIro1ComponentReturnCode = orig.OutErrorIro1ComponentReturnCode;
      OutErrorIro1ComponentReasonCode_AS = orig.OutErrorIro1ComponentReasonCode_AS;
      OutErrorIro1ComponentReasonCode = orig.OutErrorIro1ComponentReasonCode;
    }
  }
}
