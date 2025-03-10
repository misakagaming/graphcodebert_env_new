namespace GEN.ORT.YYY
{
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  //
  //                    Source Code Generated by
  //                           CA Gen 8.6
  //
  //    Copyright (c) 2024 CA Technologies. All rights reserved.
  //
  //    Name: IRO10051_CMPNT_IDENTIFIERS_GET_S Date: 2024/01/09
  //    Target OS:   CLR                       Time: 13:40:16
  //    Target DBMS: ODBC/ADO.NET              User: AliAl
  //    Access Method: <NONE>         
  //
  //    Generation options:
  //    Debug trace option not selected
  //    Data modeling constraint enforcement not selected
  //    Optimized import view initialization not selected
  //    Enforce default values with DBMS not selected
  //    Init unspecified optional fields to NULL not selected
  //
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  // using Statements
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  using System;
  using com.ca.gen.vwrt;
  using com.ca.gen.vwrt.types;
  using com.ca.gen.vwrt.vdf;
  using com.ca.gen.csu.exception;
  
  using com.ca.gen.abrt;
  using com.ca.gen.abrt.functions;
  using com.ca.gen.abrt.cascade;
  using com.ca.gen.abrt.manager;
  using com.ca.gen.abrt.trace;
  using com.ca.gen.exits.common;
  using com.ca.gen.odc;
  using System.Data;
  using System.Collections;
  
  public class IRO10051 : ABBase
  {
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // EXPORT VIEW CLASS VARIABLE
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    IRO10051_OA WOa;
    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // MISC DECLARATIONS AND PROTOTYPES 
    //    FOLLOW AS NEEDED:             
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    //       +->   IRO10051_CMPNT_IDENTIFIERS_GET_S  01/09/2024  13:40
    //       !       EXPORTS:
    //       !         Work View out_data iro1_component (Transient, Export
    //       !                     only)
    //       !           specification_id
    //       !           implementation_id
    //       !           origin_servid
    //       !         Work View out_error iro1_component (Transient, Export
    //       !                     only)
    //       !           severity_cd
    //       !           rollback_indicator_tx
    //       !           origin_servid
    //       !           return_code
    //       !           reason_code
    //       !
    //       !     EXTERNAL ACTION BLOCK
    //       !
    //     1 !   
    //     2 !  NOTE: 
    //     2 !  **************************************************************
    //     2 !  ***
    //     3 !  NOTE: 
    //     3 !  * Copyright (C) 1996 Texas Instruments and Castek 
    //     4 !  NOTE: 
    //     4 !  * Software Factory Inc.
    //     5 !  NOTE: 
    //     5 !  * 
    //     6 !  NOTE: 
    //     6 !  * All rights reserved.  No part of this work may be used or 
    //     7 !  NOTE: 
    //     7 !  * reproduced in any form without the permission in writing
    //     8 !  NOTE: 
    //     8 !  * of Texas Instruments and Castek Software Factory.
    //     9 !  NOTE: 
    //     9 !  **************************************************************
    //     9 !  ***
    //    10 !   
    //    11 !  NOTE: 
    //    11 !  PRE-CONDITION:
    //    11 !  None
    //    11 !  POST-CONDITION:
    //    11 !  Component Identifiers returned
    //    12 !   
    //    13 !  NOTE: 
    //    13 !  RETURN / REASON  CODES
    //    13 !  
    //    13 !  + 0001/0001            All OK
    //       +---
    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    //  CONSTRUCTOR FOR THE CLASS       
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    public IRO10051(  )
    {
      IefCGenRlse = "CA Gen 8.6";
      IsCopyright = "Copyright (c) 2024 CA Technologies. All rights reserved.";
      IefCGenDate = "2024/01/09";
      IefCGenTime = "13:40:16";
      IefCGenEncy = "9.2.A6";
      IefCGenUserId = "AliAl";
      IefCGenModel = "N8I_ORT_YYY_0112_TEMPLATE";
      IefCGenSubset = "ALL";
      IefCGenName = "IRO10051_CMPNT_IDENTIFIERS_GET_S";
      NestingLevel = 0;
      ValChkDeadlockTimeout = false;
      ValChkDBError = false;
    }
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // ACTION BLOCK FUNCTION DECLARATIONS 
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    
    public void Execute( Object in_runtime_parm1, 
    	IRuntimePStepContext in_runtime_parm2, 
    	GlobData in_globdata, 
    	IRO10051_OA export_view )
    {
      IefRuntimeParm1 = in_runtime_parm1;
      IefRuntimeParm2 = in_runtime_parm2;
      Globdata = in_globdata;
      WOa = export_view;
      _Execute();
    }
    
    private void _Execute()
    {
      
      try {
        f_22020214(  );
      } catch( Exception e ) {
        if ( ((Globdata.GetErrorData().GetStatus() == ErrorData.StatusNone) && (Globdata.GetErrorData().GetErrorEncountered() == 
          ErrorData.ErrorEncounteredNoErrorFound)) && (Globdata.GetErrorData().GetViewOverflow() == 
          ErrorData.ErrorEncounteredNoErrorFound) )
        {
          Globdata.GetErrorData().SetStatus( ErrorData.LastStatusFatalError );
          Globdata.GetErrorData().SetLastStatus( ErrorData.LastStatusUnexpectedExceptionError );
          Globdata.GetErrorData().SetErrorEncountered( ErrorData.ErrorEncounteredErrorFound );
          Globdata.GetErrorData(  ).SetErrorMessage( e );
        }
      }
    }
    public void f_22020214(  )
    {
      
      
      //    User-written code should be inserted here  
      
      
    }
  }// end class
  
}

