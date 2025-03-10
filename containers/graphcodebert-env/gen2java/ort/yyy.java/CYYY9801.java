
package gen.ort.yyy;

// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
//
//                    Source Code Generated by
//                           CA Gen 8.6
//
//    Copyright (c) 2023 CA Technologies. All rights reserved.
//
//    Name: CYYY9801_SET_EXCPTN_OTHER_INFO   Date: 2023/07/05
//    Target OS:   JVM                       Time: 15:07:42
//    Target DBMS: JDBC                      User: HakanBal
//    Access Method: JDBC           
//
//    Generation options:
//    Debug trace option selected
//    Data modeling constraint enforcement not selected
//    Optimized import view initialization not selected
//    Enforce default values with DBMS not selected
//    Init unspecified optional fields to NULL not selected
//
// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
// Import Statements
// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
import java.lang.*;
import java.io.*;
import java.util.*;
import java.math.*;
import java.sql.*;
import com.ca.gen.vwrt.*;
import com.ca.gen.vwrt.types.*;
import com.ca.gen.vwrt.vdf.*;

import com.ca.gen.abrt.*;
import com.ca.gen.abrt.functions.*;
import com.ca.gen.abrt.cascade.*;
import com.ca.gen.abrt.trace.*;
import com.ca.gen.exits.common.*;
import com.ca.gen.odc.*;

public class CYYY9801 extends ABBase
{
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  // EXPORT VIEW CLASS VARIABLE
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  CYYY9801_OA w_oa;
  
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  // MISC DECLARATIONS AND PROTOTYPES 
  //    FOLLOW AS NEEDED:             
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  boolean func_0022020319_esc_flag;
  PadView padview[] = new PadView [6];
  int trace_ret_code;
  PadText padtext[] = initPadText();
  public PadText [] initPadText()
  {
    PadText [] result = new PadText [PADTEXT_SIZE];
    result[0] = PadText.getInstance(   0,"+->   CYYY9801_SET_EXCPTN_OTHER_INFO    07/05/2023  15:07");
    result[1] = PadText.getInstance(   0,"!       EXPORTS:");
    result[2] = PadText.getInstance(   0,"!         Work View exp_other_error iyy1_component (Transient, Export only)");
    result[3] = PadText.getInstance(   0,"!           return_code");
    result[4] = PadText.getInstance(   0,"!           reason_code");
    result[5] = PadText.getInstance(   0,"!");
    result[6] = PadText.getInstance(   0,"!     PROCEDURE STATEMENTS");
    result[7] = PadText.getInstance(   0,"!");
    result[8] = PadText.getInstance(   1,"!  NOTE: ");
    result[9] = PadText.getInstance(   1,"!  Please review explanation for purpose.");
    result[10] = PadText.getInstance(   1,"!  ");
    result[11] = PadText.getInstance(   2,"!  NOTE: ");
    result[12] = PadText.getInstance(   2,"!  RELEASE HISTORY");
    result[13] = PadText.getInstance(   2,"!  01_00 25-10-1998 New release");
    result[14] = PadText.getInstance(   2,"!  ");
    result[15] = PadText.getInstance(   3,"!  NOTE: ");
    result[16] = PadText.getInstance(   3,"!  ****************************************************************");
    result[17] = PadText.getInstance(   3,
      "!  This will be used instead of the error codes, returned and not mapped from the components used in this component.");
    result[18] = PadText.getInstance(   3,"!  This component will return an error code that will not be used for other purpose.");
    result[19] = PadText.getInstance(   3,"!  Recommended return_code = -1999");
    result[20] = PadText.getInstance(   3,"!                 reason_code = 1");
    result[21] = PadText.getInstance(   3,"!  ");
    result[22] = PadText.getInstance(   3,"!  ");
    result[23] = PadText.getInstance(   4,"!  SET exp_other_error iyy1_component return_code TO 1999 ");
    result[24] = PadText.getInstance(   5,"!  SET exp_other_error iyy1_component reason_code TO 1 ");
    result[25] = PadText.getInstance(   0,"+---");
    result[26] = PadText.getInstance(PadText.LASTLINE,"************************* BOTTOM OF DATA *************************");
    return result;
  }
  final static int PADTEXT_SIZE = 27;
  //       +->   CYYY9801_SET_EXCPTN_OTHER_INFO    07/05/2023  15:07
  //       !       EXPORTS:
  //       !         Work View exp_other_error iyy1_component (Transient, Export only)
  //       !           return_code
  //       !           reason_code
  //       !
  //       !     PROCEDURE STATEMENTS
  //       !
  //     1 !  NOTE: 
  //     1 !  Please review explanation for purpose.
  //     1 !  
  //     2 !  NOTE: 
  //     2 !  RELEASE HISTORY
  //     2 !  01_00 25-10-1998 New release
  //     2 !  
  //     3 !  NOTE: 
  //     3 !  ****************************************************************
  //     3 !  This will be used instead of the error codes, returned and not mapped from the components used in this component.
  //     3 !  This component will return an error code that will not be used for other purpose.
  //     3 !  Recommended return_code = -1999
  //     3 !                 reason_code = 1
  //     3 !  
  //     3 !  
  //     4 !  SET exp_other_error iyy1_component return_code TO 1999 
  //     5 !  SET exp_other_error iyy1_component reason_code TO 1 
  //       +---
  
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  //  CONSTRUCTOR FOR THE CLASS       
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  public CYYY9801()
  {
    iefCGenRlse = "CA Gen 8.6";
    ssCopyright = "Copyright (c) 2023 CA Technologies. All rights reserved.";
    iefCGenDate = "2023/07/05";
    iefCGenTime = "15:07:42";
    iefCGenEncy = "9.2.A6";
    iefCGenUserId = "HakanBal";
    iefCGenModel = "N8I_ORT_YYY_0112_TEMPLATE";
    iefCGenSubset = "ALL";
    iefCGenName = "CYYY9801_SET_EXCPTN_OTHER_INFO";
    nestingLevel = 0;
    valChkDeadlockTimeout = false;
    valChkDBError = false;
  }
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  // ACTION BLOCK FUNCTION DECLARATIONS 
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  
  public void CYYY9801( Object in_runtime_parm1, 
  	IRuntimePStepContext in_runtime_parm2, 
  	GlobData in_globdata, 
  	CYYY9801_OA export_view )
  {
    iefRuntimeParm1 = in_runtime_parm1;
    iefRuntimeParm2 = in_runtime_parm2;
    globdata = in_globdata;
    w_oa = export_view;
    _CYYY9801();
  }
  
  private void _CYYY9801()
  {
    
    ++(nestingLevel);
    try {
      f_22020319_init();
      f_22020319();
    } catch( ABException e ) {
    } finally {
      --(nestingLevel);
    }
    String last_stmt_num_saved = globdata.getStateData().getLastStatementNumber();
    globdata.getStateData().setLastStatementNumber( "9999999999" );
    try {
      f_0_trace();
    } catch( ABException e ) {
    }
    globdata.getStateData().setLastStatementNumber( last_stmt_num_saved );
  }
  public void f_22020319()
  	throws ABException
  {
    func_0022020319_esc_flag = false;
    globdata.getStateData().setCurrentABId( "0022020319" );
    globdata.getStateData().setCurrentABName( "CYYY9801_SET_EXCPTN_OTHER_INFO" );
    padview_init();
    globdata.getStateData().setLastStatementNumber( "0000000000" );
    f_0_trace();
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    //    Please review explanation for purpose.                          
    //                                                                    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    //    RELEASE HISTORY                                                 
    //    01_00 25-10-1998 New release                                    
    //                                                                    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    //    **************************************************************  
    //    **                                                              
    //    This will be used instead of the error codes,                   
    //    returned and not mapped from the components used in this compo  
    //    nent. This component will return an error code that will not b  
    //    e used for other purpose.                                       
    //    Recommended return_code = -1999                                 
    //                   reason_code = 1                                  
    //                                                                    
    //                                                                    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    globdata.getStateData().setLastStatementNumber( "0000000004" );
    f_0_trace();
    if ( trace_ret_code != 8 )
    {
      w_oa.ExpOtherErrorIyy1ComponentReturnCode = IntAttr.valueOf((int)TIRD2DEC.TIRD2DC1(1999, 0, TIRD2DEC.ROUND_NONE, 5));
    }
    globdata.getStateData().setLastStatementNumber( "0000000005" );
    f_0_trace();
    if ( trace_ret_code != 8 )
    {
      w_oa.ExpOtherErrorIyy1ComponentReasonCode = IntAttr.valueOf((int)TIRD2DEC.TIRD2DC1(1, 0, TIRD2DEC.ROUND_NONE, 5));
    }
  }
  
  
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  // SUBORDINATE FUNCTIONS
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  // INITIALIZATION UTILITY FUNCTIONS 
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  
  public void f_22020319_init()
  	throws ABException
  {
    if ( nestingLevel < 2 )
    {
    }
    w_oa.ExpOtherErrorIyy1ComponentReturnCode = 0;
    w_oa.ExpOtherErrorIyy1ComponentReasonCode = 0;
  }
  
  public void f_0_trace()
  	throws ABException
  {
    trace_ret_code = TIRTRCE.TIRTRCE(iefRuntimeParm1, iefRuntimeParm2, globdata, padtext, padview);
    if ( trace_ret_code == 20 )
    {
      throw new ABException();
    }
  }
  
  public void padview_init()
  {
padview[0] = PadView.getInstance("EXPORT                          ", 0, 0, 0, (short)1, PadView.VT_BASE, PadView.DT_NONE, w_oa, 
      "w_oa");
    padview[1] = PadView.getInstance("EXP_OTHER_ERROR                 ", 0, 0, 0, (short)2, PadView.VT_VIEW, PadView.DT_NONE, w_oa, 
      null);
    padview[2] = PadView.getInstance("IYY1_COMPONENT                  ", 0, 0, 0, (short)3, PadView.VT_ENTITY, PadView.DT_NONE, w_oa,
       null);
    padview[3] = PadView.getInstance("RETURN_CODE                     ", 5, 0, 0, (short)3, PadView.VT_PREDICATE, PadView.DT_NUMERIC,
       w_oa, "ExpOtherErrorIyy1ComponentReturnCode");
    padview[4] = PadView.getInstance("REASON_CODE                     ", 5, 0, 0, (short)3, PadView.VT_PREDICATE, PadView.DT_NUMERIC,
       w_oa, "ExpOtherErrorIyy1ComponentReasonCode");
    padview[5] = PadView.getInstance("******** BOTTOM OF DATA ********", 0, 0, 0, (short)0, PadView.VT_END, PadView.DT_NONE, w_oa, 
      null);
  }
}// end class


package gen.ort.yyy;
// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
//
//                    Source Code Generated by
//                           CA Gen 8.6
//
//    Copyright (c) 2023 CA Technologies. All rights reserved.
//
//    Name: CYYY9801_OA                      Date: 2023/07/05
//    User: HakanBal                         Time: 15:07:45
//
// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *

// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
// Import Statements
// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
import java.lang.*;
import java.io.*;
import java.util.*;
import java.math.*;
import java.sql.*;
import com.ca.gen.vwrt.*;
import com.ca.gen.vwrt.types.*;
import com.ca.gen.vwrt.vdf.*;
import com.ca.gen.csu.exception.*;

// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
// START OF EXPORT VIEW
// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
/**
 * Internal data view storage for: CYYY9801_OA
 **/
public class CYYY9801_OA extends ViewBase implements IExportView, Serializable
{
  // Entity View: EXP_OTHER_ERROR
  //        Type: IYY1_COMPONENT
  /**
   * Attribute missing flag for: ExpOtherErrorIyy1ComponentReturnCode
   **/
  public char ExpOtherErrorIyy1ComponentReturnCode_AS;
  /**
   * Attribute for: ExpOtherErrorIyy1ComponentReturnCode
   * Domain: Number
   * Length: 5
   * Decimal Places: 0
   * Decimal Precision: N
   **/
  public int ExpOtherErrorIyy1ComponentReturnCode;
  /**
   * Attribute missing flag for: ExpOtherErrorIyy1ComponentReasonCode
   **/
  public char ExpOtherErrorIyy1ComponentReasonCode_AS;
  /**
   * Attribute for: ExpOtherErrorIyy1ComponentReasonCode
   * Domain: Number
   * Length: 5
   * Decimal Places: 0
   * Decimal Precision: N
   **/
  public int ExpOtherErrorIyy1ComponentReasonCode;
  /**
   * Default Constructor
   **/
  
  public CYYY9801_OA()
  {
    reset();
  }
  /**
   * Copy Constructor
   **/
  
  public CYYY9801_OA(CYYY9801_OA orig)
  {
    copyFrom(orig);
  }
  /**
   * Static instance creator function
   **/
  
  public static CYYY9801_OA getInstance()
  {
    return new CYYY9801_OA();
  }
  /**
   * Static free instance method
   **/
  
  public void freeInstance()
  {
  }
  /**
   * clone constructor
   **/
  
  @Override public Object clone()
  	throws CloneNotSupportedException
  {
    return(new CYYY9801_OA(this));
  }
  /**
   * Resets all properties to the defaults.
   **/
  
  public void reset()
  {
    ExpOtherErrorIyy1ComponentReturnCode_AS = ' ';
    ExpOtherErrorIyy1ComponentReturnCode = 0;
    ExpOtherErrorIyy1ComponentReasonCode_AS = ' ';
    ExpOtherErrorIyy1ComponentReasonCode = 0;
  }
  /**
   * Sets the current state of the instance to the VDF version.
   **/
  public void setFromVDF(VDF vdf)
  {
    throw new RuntimeException("can only execute setFromVDF for a Procedure Step.");
  }
  
  /**
   * Gets the VDF version of the current state of the instance.
   **/
  public VDF getVDF()
  {
    throw new RuntimeException("can only execute getVDF for a Procedure Step.");
  }
  
  /**
   * Sets the current instance based on the passed view.
   **/
  public void copyFrom(IExportView orig)
  {
    this.copyFrom((CYYY9801_OA) orig);
  }
  
  /**
   * Sets the current instance based on the passed view.
   **/
  public void copyFrom(CYYY9801_OA orig)
  {
    ExpOtherErrorIyy1ComponentReturnCode_AS = orig.ExpOtherErrorIyy1ComponentReturnCode_AS;
    ExpOtherErrorIyy1ComponentReturnCode = orig.ExpOtherErrorIyy1ComponentReturnCode;
    ExpOtherErrorIyy1ComponentReasonCode_AS = orig.ExpOtherErrorIyy1ComponentReasonCode_AS;
    ExpOtherErrorIyy1ComponentReasonCode = orig.ExpOtherErrorIyy1ComponentReasonCode;
  }
}
