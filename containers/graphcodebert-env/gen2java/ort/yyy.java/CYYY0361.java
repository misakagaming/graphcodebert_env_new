
package gen.ort.yyy;

// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
//
//                    Source Code Generated by
//                           CA Gen 8.6
//
//    Copyright (c) 2023 CA Technologies. All rights reserved.
//
//    Name: CYYY0361_TYPE_INSTANCE_ID_GEN    Date: 2023/07/05
//    Target OS:   JVM                       Time: 15:09:20
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

public class CYYY0361 extends ABBase
{
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  // EXPORT VIEW CLASS VARIABLE
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  CYYY0361_OA w_oa;
  
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  // MISC DECLARATIONS AND PROTOTYPES 
  //    FOLLOW AS NEEDED:             
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  boolean func_0022020210_esc_flag;
  PadView padview[] = new PadView [5];
  int trace_ret_code;
  PadText padtext[] = initPadText();
  public PadText [] initPadText()
  {
    PadText [] result = new PadText [PADTEXT_SIZE];
    result[0] = PadText.getInstance(   0,"+->   CYYY0361_TYPE_INSTANCE_ID_GEN     07/05/2023  15:09");
    result[1] = PadText.getInstance(   0,"!       EXPORTS:");
    result[2] = PadText.getInstance(   0,"!         Entity View exp type (Transient, Export only)");
    result[3] = PadText.getInstance(   0,"!           tinstance_id");
    result[4] = PadText.getInstance(   0,"!");
    result[5] = PadText.getInstance(   0,"!     PROCEDURE STATEMENTS");
    result[6] = PadText.getInstance(   0,"!");
    result[7] = PadText.getInstance(   1,"!  NOTE: ");
    result[8] = PadText.getInstance(   1,"!  Please review explanation for purpose.");
    result[9] = PadText.getInstance(   1,"!  ");
    result[10] = PadText.getInstance(   2,"!  NOTE: ");
    result[11] = PadText.getInstance(   2,"!  RELEASE HISTORY");
    result[12] = PadText.getInstance(   2,"!  01_00 23-02-1998 New release");
    result[13] = PadText.getInstance(   2,"!  ");
    result[14] = PadText.getInstance(   3,"!  SET exp type tinstance_id TO CURRENT_TIMESTAMP ");
    result[15] = PadText.getInstance(   0,"+---");
    result[16] = PadText.getInstance(PadText.LASTLINE,"************************* BOTTOM OF DATA *************************");
    return result;
  }
  final static int PADTEXT_SIZE = 17;
  //       +->   CYYY0361_TYPE_INSTANCE_ID_GEN     07/05/2023  15:09
  //       !       EXPORTS:
  //       !         Entity View exp type (Transient, Export only)
  //       !           tinstance_id
  //       !
  //       !     PROCEDURE STATEMENTS
  //       !
  //     1 !  NOTE: 
  //     1 !  Please review explanation for purpose.
  //     1 !  
  //     2 !  NOTE: 
  //     2 !  RELEASE HISTORY
  //     2 !  01_00 23-02-1998 New release
  //     2 !  
  //     3 !  SET exp type tinstance_id TO CURRENT_TIMESTAMP 
  //       +---
  
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  //  CONSTRUCTOR FOR THE CLASS       
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  public CYYY0361()
  {
    iefCGenRlse = "CA Gen 8.6";
    ssCopyright = "Copyright (c) 2023 CA Technologies. All rights reserved.";
    iefCGenDate = "2023/07/05";
    iefCGenTime = "15:09:20";
    iefCGenEncy = "9.2.A6";
    iefCGenUserId = "HakanBal";
    iefCGenModel = "N8I_ORT_YYY_0112_TEMPLATE";
    iefCGenSubset = "ALL";
    iefCGenName = "CYYY0361_TYPE_INSTANCE_ID_GEN";
    nestingLevel = 0;
    valChkDeadlockTimeout = false;
    valChkDBError = false;
  }
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  // ACTION BLOCK FUNCTION DECLARATIONS 
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  
  public void CYYY0361( Object in_runtime_parm1, 
  	IRuntimePStepContext in_runtime_parm2, 
  	GlobData in_globdata, 
  	CYYY0361_OA export_view )
  {
    iefRuntimeParm1 = in_runtime_parm1;
    iefRuntimeParm2 = in_runtime_parm2;
    globdata = in_globdata;
    w_oa = export_view;
    _CYYY0361();
  }
  
  private void _CYYY0361()
  {
    
    ++(nestingLevel);
    try {
      f_22020210_init();
      f_22020210();
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
  public void f_22020210()
  	throws ABException
  {
    func_0022020210_esc_flag = false;
    globdata.getStateData().setCurrentABId( "0022020210" );
    globdata.getStateData().setCurrentABName( "CYYY0361_TYPE_INSTANCE_ID_GEN" );
    padview_init();
    globdata.getStateData().setLastStatementNumber( "0000000000" );
    f_0_trace();
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    //    Please review explanation for purpose.                          
    //                                                                    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    //    RELEASE HISTORY                                                 
    //    01_00 23-02-1998 New release                                    
    //                                                                    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    globdata.getStateData().setLastStatementNumber( "0000000003" );
    f_0_trace();
    if ( trace_ret_code != 8 )
    {
      if ( todaysTimestamp == null )
      {
        todaysTimestamp = StringAttr.getInstance();
      }
      if ( todaysTime == null )
      {
        todaysTime = IntAttr.getInstance();
      }
      if ( todaysDate == null )
      {
        todaysDate = IntAttr.getInstance();
      }
      TIRDAT2.getSystemTimestamp(todaysTimestamp);
      TIRDAT2.getSystemDate(todaysDate, TIRDAT2.DF_YYYYMMDD);
      TIRDAT2.getSystemTime(todaysTime, TIRDAT2.TF_HHMMSS);
      w_oa.ExpTypeTinstanceId = TimestampAttr.valueOf(todaysTimestamp.get());
    }
  }
  
  
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  // SUBORDINATE FUNCTIONS
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  // INITIALIZATION UTILITY FUNCTIONS 
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  
  public void f_22020210_init()
  	throws ABException
  {
    if ( nestingLevel < 2 )
    {
    }
    w_oa.ExpTypeTinstanceId = "00000000000000000000";
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
    padview[1] = PadView.getInstance("EXP                             ", 0, 0, 0, (short)2, PadView.VT_VIEW, PadView.DT_NONE, w_oa, 
      null);
    padview[2] = PadView.getInstance("TYPE                            ", 0, 0, 0, (short)3, PadView.VT_ENTITY, PadView.DT_NONE, w_oa,
       null);
    padview[3] = PadView.getInstance("TINSTANCE_ID                    ", 20, 0, 0, (short)3, PadView.VT_PREDICATE, 
      PadView.DT_TIMESTAMP, w_oa, "ExpTypeTinstanceId");
    padview[4] = PadView.getInstance("******** BOTTOM OF DATA ********", 0, 0, 0, (short)0, PadView.VT_END, PadView.DT_NONE, w_oa, 
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
//    Name: CYYY0361_OA                      Date: 2023/07/05
//    User: HakanBal                         Time: 15:09:20
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
 * Internal data view storage for: CYYY0361_OA
 **/
public class CYYY0361_OA extends ViewBase implements IExportView, Serializable
{
  // Entity View: EXP
  //        Type: TYPE
  /**
   * Attribute missing flag for: ExpTypeTinstanceId
   **/
  public char ExpTypeTinstanceId_AS;
  /**
   * Attribute for: ExpTypeTinstanceId
   * Domain: Timestamp
   * Length: 20
   **/
  public String ExpTypeTinstanceId;
  /**
   * Default Constructor
   **/
  
  public CYYY0361_OA()
  {
    reset();
  }
  /**
   * Copy Constructor
   **/
  
  public CYYY0361_OA(CYYY0361_OA orig)
  {
    copyFrom(orig);
  }
  /**
   * Static instance creator function
   **/
  
  public static CYYY0361_OA getInstance()
  {
    return new CYYY0361_OA();
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
    return(new CYYY0361_OA(this));
  }
  /**
   * Resets all properties to the defaults.
   **/
  
  public void reset()
  {
    ExpTypeTinstanceId_AS = ' ';
    ExpTypeTinstanceId = "00000000000000000000";
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
    this.copyFrom((CYYY0361_OA) orig);
  }
  
  /**
   * Sets the current instance based on the passed view.
   **/
  public void copyFrom(CYYY0361_OA orig)
  {
    ExpTypeTinstanceId_AS = orig.ExpTypeTinstanceId_AS;
    ExpTypeTinstanceId = orig.ExpTypeTinstanceId;
  }
}
