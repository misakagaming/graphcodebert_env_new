// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
//
//                    Source Code Generated by
//                           CA Gen 8.6
//
//    Copyright (c) 2024 CA Technologies. All rights reserved.
//
//    Name: MYY10341_IA                      Date: 2024/01/09
//    User: AliAl                            Time: 13:41:43
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
  /// Internal data view storage for: MYY10341_IA
  /// </summary>
  [Serializable]
  public class MYY10341_IA : ViewBase, IImportView
  {
    private static MYY10341_IA[] freeArray = new MYY10341_IA[30];
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
    /// Internal storage for attribute missing flag for: ImpIyy1TypeTreferenceId
    /// </summary>
    private char _ImpIyy1TypeTreferenceId_AS;
    /// <summary>
    /// Attribute missing flag for: ImpIyy1TypeTreferenceId
    /// </summary>
    public char ImpIyy1TypeTreferenceId_AS {
      get {
        return(_ImpIyy1TypeTreferenceId_AS);
      }
      set {
        _ImpIyy1TypeTreferenceId_AS = value;
      }
    }
    /// <summary>
    /// Internal storage, attribute for: ImpIyy1TypeTreferenceId
    /// Domain: Timestamp
    /// Length: 20
    /// </summary>
    private string _ImpIyy1TypeTreferenceId;
    /// <summary>
    /// Attribute for: ImpIyy1TypeTreferenceId
    /// </summary>
    public string ImpIyy1TypeTreferenceId {
      get {
        return(_ImpIyy1TypeTreferenceId);
      }
      set {
        _ImpIyy1TypeTreferenceId = value;
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
    
    public MYY10341_IA(  )
    {
      Reset(  );
    }
    /// <summary>
    /// Copy Constructor
    /// </summary>
    
    public MYY10341_IA( MYY10341_IA orig )
    {
      ImpReferenceIyy1ServerDataUserid_AS = orig.ImpReferenceIyy1ServerDataUserid_AS;
      ImpReferenceIyy1ServerDataUserid = orig.ImpReferenceIyy1ServerDataUserid;
      ImpReferenceIyy1ServerDataReferenceId_AS = orig.ImpReferenceIyy1ServerDataReferenceId_AS;
      ImpReferenceIyy1ServerDataReferenceId = orig.ImpReferenceIyy1ServerDataReferenceId;
      ImpIyy1TypeTinstanceId_AS = orig.ImpIyy1TypeTinstanceId_AS;
      ImpIyy1TypeTinstanceId = orig.ImpIyy1TypeTinstanceId;
      ImpIyy1TypeTreferenceId_AS = orig.ImpIyy1TypeTreferenceId_AS;
      ImpIyy1TypeTreferenceId = orig.ImpIyy1TypeTreferenceId;
      ImpIyy1TypeTkeyAttrText_AS = orig.ImpIyy1TypeTkeyAttrText_AS;
      ImpIyy1TypeTkeyAttrText = orig.ImpIyy1TypeTkeyAttrText;
    }
    /// <summary>
    /// Static instance creator function
    /// </summary>
    
    public static MYY10341_IA GetInstance(  )
    {
      if ( countFree == 0 )
      {
        return(new MYY10341_IA());
      }
      else 
      {
        lock (freeArray)
        {
          if ( countFree == 0 )
          {
            return(new MYY10341_IA());
          }
          else 
          {
            MYY10341_IA result = freeArray[--countFree];
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
      return(new MYY10341_IA(this));
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
      ImpIyy1TypeTinstanceId_AS = ' ';
      ImpIyy1TypeTinstanceId = "00000000000000000000";
      ImpIyy1TypeTreferenceId_AS = ' ';
      ImpIyy1TypeTreferenceId = "00000000000000000000";
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
      this.CopyFrom((MYY10341_IA) orig);
    }
    
    /// <summary>
    /// Sets the current instance based on the passed view.
    /// </summary>
    public void CopyFrom( MYY10341_IA orig )
    {
      ImpReferenceIyy1ServerDataUserid_AS = orig.ImpReferenceIyy1ServerDataUserid_AS;
      ImpReferenceIyy1ServerDataUserid = orig.ImpReferenceIyy1ServerDataUserid;
      ImpReferenceIyy1ServerDataReferenceId_AS = orig.ImpReferenceIyy1ServerDataReferenceId_AS;
      ImpReferenceIyy1ServerDataReferenceId = orig.ImpReferenceIyy1ServerDataReferenceId;
      ImpIyy1TypeTinstanceId_AS = orig.ImpIyy1TypeTinstanceId_AS;
      ImpIyy1TypeTinstanceId = orig.ImpIyy1TypeTinstanceId;
      ImpIyy1TypeTreferenceId_AS = orig.ImpIyy1TypeTreferenceId_AS;
      ImpIyy1TypeTreferenceId = orig.ImpIyy1TypeTreferenceId;
      ImpIyy1TypeTkeyAttrText_AS = orig.ImpIyy1TypeTkeyAttrText_AS;
      ImpIyy1TypeTkeyAttrText = orig.ImpIyy1TypeTkeyAttrText;
    }
  }
}
