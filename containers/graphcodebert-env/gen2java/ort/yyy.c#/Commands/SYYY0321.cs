namespace GEN.ORT.YYY
{
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  //
  //                    Source Code Generated by
  //                           CA Gen 8.6
  //
  //    Copyright (c) 2024 CA Technologies. All rights reserved.
  //
  //    Name: SYYY0321_TYPE_READ               Date: 2024/01/09
  //    Target OS:   CLR                       Time: 13:40:21
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
  
  public class SYYY0321 : ABBase
  {
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // IMPORT VIEW CLASS VARIABLE
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    SYYY0321_IA WIa;
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // EXPORT VIEW CLASS VARIABLE
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    SYYY0321_OA WOa;
    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // MISC DECLARATIONS AND PROTOTYPES 
    //    FOLLOW AS NEEDED:             
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    bool func_0022020231_esc_flag;
    //       +->   SYYY0321_TYPE_READ                01/09/2024  13:40
    //       !       IMPORTS:
    //       !         Entity View imp type (Transient, Mandatory, Import
    //       !                     only)
    //       !           tinstance_id
    //       !           tkey_attr_text
    //       !       EXPORTS:
    //       !         Entity View exp type (Transient, Export only)
    //       !           tinstance_id
    //       !           treference_id
    //       !           tcreate_user_id
    //       !           tupdate_user_id
    //       !           tkey_attr_text
    //       !           tsearch_attr_text
    //       !           tother_attr_text
    //       !           tother_attr_date
    //       !           tother_attr_time
    //       !           tother_attr_amount
    //       !         Work View exp_error dont_change_text (Transient, Export
    //       !                     only)
    //       !           text_2
    //       !
    //       !     PROCEDURE STATEMENTS
    //       !
    //     1 !  NOTE: 
    //     1 !  See the description for the purpose
    //     1 !  
    //     2 !  NOTE: 
    //     2 !  RELEASE HISTORY
    //     2 !  01_00 23-02-1998 New release
    //     2 !  
    //     3 !  NOTE: 
    //     3 !  **************************************************************
    //     3 !  *
    //     3 !  WARNING ! Before GENERATION EXECUTE STATEMENT NUMBER flag
    //     3 !  must be unchecked.
    //     3 !  
    //     4 !  NOTE: 
    //     4 !  **************************************************************
    //     4 !  *
    //     4 !  SIMULATION and EXTERNAL APPLICATION
    //     4 !  The preparation purposes of external AB s, Server test for
    //     4 !  Local tests and Simulation for real time 
    //     4 !  conditions, to-do list and the things to be taken into
    //     4 !  consideration during the preparation, what 
    //     4 !  should be done during the usage are explained in the related
    //     4 !  documents.
    //     4 !  
    //     5 !  SET exp_error dont_change_text text_2 TO "OK" 
    //     6 !   
    //     7 !  SET exp type tkey_attr_text TO "KEYA" 
    //     8 !  SET exp type tsearch_attr_text TO "SEARCH ATTRIBUTE" 
    //     9 !  SET exp type tother_attr_text TO "OA" 
    //    10 !  SET exp type tother_attr_date TO CURRENT_DATE 
    //    11 !  SET exp type tother_attr_time TO CURRENT_TIME 
    //    12 !  SET exp type tother_attr_amount TO 123456789012345.67 
    //    13 !  SET exp type tcreate_user_id TO "CREAUSER" 
    //    14 !  SET exp type tupdate_user_id TO "UPDTUSER" 
    //    15 !  SET exp type tinstance_id TO imp type tinstance_id 
    //    16 !  SET exp type treference_id TO imp type tinstance_id 
    //    17 !   
    //    18 !  +->IF imp type tkey_attr_text >= "9000"
    //    19 !  !  SET exp_error dont_change_text text_2 TO "XX" 
    //    18 !  +> ELSE IF imp type tkey_attr_text >= "8000"
    //    20 !  !  SET exp_error dont_change_text text_2 TO "NF" 
    //    18 !  +--
    //       +---
    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    //  CONSTRUCTOR FOR THE CLASS       
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    public SYYY0321(  )
    {
      IefCGenRlse = "CA Gen 8.6";
      IsCopyright = "Copyright (c) 2024 CA Technologies. All rights reserved.";
      IefCGenDate = "2024/01/09";
      IefCGenTime = "13:40:21";
      IefCGenEncy = "9.2.A6";
      IefCGenUserId = "AliAl";
      IefCGenModel = "N8I_ORT_YYY_0112_TEMPLATE";
      IefCGenSubset = "ALL";
      IefCGenName = "SYYY0321_TYPE_READ";
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
    	SYYY0321_IA import_view, 
    	SYYY0321_OA export_view )
    {
      IefRuntimeParm1 = in_runtime_parm1;
      IefRuntimeParm2 = in_runtime_parm2;
      Globdata = in_globdata;
      WIa = import_view;
      WOa = export_view;
      _Execute();
    }
    
    private void _Execute()
    {
      
      ++(NestingLevel);
      try {
        f_22020231_init(  );
        f_22020231(  );
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
      --(NestingLevel);
    }
    public void f_22020231(  )
    {
      func_0022020231_esc_flag = false;
      Globdata.GetStateData().SetCurrentABId( "0022020231" );
      Globdata.GetStateData().SetCurrentABName( "SYYY0321_TYPE_READ" );
      Globdata.GetStateData().SetLastStatementNumber( "0000000000" );
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      //    See the description for the purpose                             
      //                                                                    
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      //    RELEASE HISTORY                                                 
      //    01_00 23-02-1998 New release                                    
      //                                                                    
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      //    **************************************************************  
      //    *                                                               
      //    WARNING ! Before GENERATION EXECUTE STATEMENT NUMBER flag       
      //    must be unchecked.                                              
      //                                                                    
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      //    **************************************************************  
      //    *                                                               
      //    SIMULATION and EXTERNAL APPLICATION                             
      //    The preparation purposes of external AB s, Server test for      
      //    Local tests and Simulation for real time                        
      //    conditions, to-do list and the things to be taken into          
      //    consideration during the preparation, what                      
      //    should be done during the usage are explained in the related    
      //    documents.                                                      
      //                                                                    
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      // Globdata.GetStateData().SetLastStatementNumber( "0000000005" );
      WOa.ExpErrorDontChangeTextText2 = FixedStringAttr.ValueOf("OK", 2);
      
      // Globdata.GetStateData().SetLastStatementNumber( "0000000007" );
      WOa.ExpTypeTkeyAttrText = FixedStringAttr.ValueOf("KEYA", 4);
      // Globdata.GetStateData().SetLastStatementNumber( "0000000008" );
      WOa.ExpTypeTsearchAttrText = FixedStringAttr.ValueOf("SEARCH ATTRIBUTE", 20);
      // Globdata.GetStateData().SetLastStatementNumber( "0000000009" );
      WOa.ExpTypeTotherAttrText = FixedStringAttr.ValueOf("OA", 2);
      // Globdata.GetStateData().SetLastStatementNumber( "0000000010" );
      if ( TodaysTimestamp == null )
      {
        TodaysTimestamp = StringAttr.GetInstance();
      }
      if ( TodaysTime == null )
      {
        TodaysTime = IntAttr.GetInstance();
      }
      if ( TodaysDate == null )
      {
        TodaysDate = IntAttr.GetInstance();
      }
      TIRDAT2.GetSystemTimestamp( TodaysTimestamp );
      TIRDAT2.GetSystemDate( TodaysDate,
      	TIRDAT2.DF_YYYYMMDD );
      TIRDAT2.GetSystemTime( TodaysTime,
      	TIRDAT2.TF_HHMMSS );
      WOa.ExpTypeTotherAttrDate = DateAttr.ValueOf(TodaysDate.Get());
      // Globdata.GetStateData().SetLastStatementNumber( "0000000011" );
      if ( TodaysTimestamp == null )
      {
        TodaysTimestamp = StringAttr.GetInstance();
      }
      if ( TodaysTime == null )
      {
        TodaysTime = IntAttr.GetInstance();
      }
      if ( TodaysDate == null )
      {
        TodaysDate = IntAttr.GetInstance();
      }
      TIRDAT2.GetSystemTimestamp( TodaysTimestamp );
      TIRDAT2.GetSystemDate( TodaysDate,
      	TIRDAT2.DF_YYYYMMDD );
      TIRDAT2.GetSystemTime( TodaysTime,
      	TIRDAT2.TF_HHMMSS );
      WOa.ExpTypeTotherAttrTime = TimeAttr.ValueOf(TodaysTime.Get());
      // Globdata.GetStateData().SetLastStatementNumber( "0000000012" );
      WOa.ExpTypeTotherAttrAmount = DecimalAttr.ValueOf(TIRBDTRU.TruncateToDecimal( "123456789012345.67", 2));
      // Globdata.GetStateData().SetLastStatementNumber( "0000000013" );
      WOa.ExpTypeTcreateUserId = FixedStringAttr.ValueOf("CREAUSER", 8);
      // Globdata.GetStateData().SetLastStatementNumber( "0000000014" );
      WOa.ExpTypeTupdateUserId = FixedStringAttr.ValueOf("UPDTUSER", 8);
      // Globdata.GetStateData().SetLastStatementNumber( "0000000015" );
      WOa.ExpTypeTinstanceId = TimestampAttr.ValueOf(WIa.ImpTypeTinstanceId);
      // Globdata.GetStateData().SetLastStatementNumber( "0000000016" );
      WOa.ExpTypeTreferenceId = TimestampAttr.ValueOf(WIa.ImpTypeTinstanceId);
      
      // Globdata.GetStateData().SetLastStatementNumber( "0000000018" );
      if ( CompareExit.CompareTo(WIa.ImpTypeTkeyAttrText, "9000") >= 0 )
      {
        // Globdata.GetStateData().SetLastStatementNumber( "0000000019" );
        WOa.ExpErrorDontChangeTextText2 = FixedStringAttr.ValueOf("XX", 2);
      }
      else 
      {
        // Globdata.GetStateData().SetLastSubStatementNumber( "1" );
        if ( CompareExit.CompareTo(WIa.ImpTypeTkeyAttrText, "8000") >= 0 )
        {
          // Globdata.GetStateData().SetLastStatementNumber( "0000000020" );
          WOa.ExpErrorDontChangeTextText2 = FixedStringAttr.ValueOf("NF", 2);
        }
      }
      
      return;
    }
    
    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // SUBORDINATE FUNCTIONS
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // INITIALIZATION UTILITY FUNCTIONS 
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    
    public void f_22020231_init(  )
    {
      if ( NestingLevel < 2 )
      {
      }
      WOa.ExpTypeTinstanceId = "00000000000000000000";
      WOa.ExpTypeTreferenceId = "00000000000000000000";
      WOa.ExpTypeTcreateUserId = "        ";
      WOa.ExpTypeTupdateUserId = "        ";
      WOa.ExpTypeTkeyAttrText = "    ";
      WOa.ExpTypeTsearchAttrText = "                    ";
      WOa.ExpTypeTotherAttrText = "  ";
      WOa.ExpTypeTotherAttrDate = 00000000;
      WOa.ExpTypeTotherAttrTime = 00000000;
      WOa.ExpTypeTotherAttrAmount = DecimalAttr.GetDefaultValue();
      WOa.ExpErrorDontChangeTextText2 = "  ";
    }
  }// end class
  
}

