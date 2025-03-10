namespace GEN.ORT.YYY
{
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  //
  //                    Source Code Generated by
  //                           CA Gen 8.6
  //
  //    Copyright (c) 2024 CA Technologies. All rights reserved.
  //
  //    Name: IYY10311_TYPE_CREATE_S           Date: 2024/01/09
  //    Target OS:   CLR                       Time: 13:41:40
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
  
  public class IYY10311 : ABBase
  {
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // IMPORT VIEW CLASS VARIABLE
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    IYY10311_IA WIa;
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // EXPORT VIEW CLASS VARIABLE
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    IYY10311_OA WOa;
    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // ACTION BLOCK IMPORT/EXPORT VIEWS CLASS VARIABLES
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    GEN.ORT.YYY.MYY10311_IA Myy10311Ia;
    GEN.ORT.YYY.MYY10311_OA Myy10311Oa;
    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // MISC DECLARATIONS AND PROTOTYPES 
    //    FOLLOW AS NEEDED:             
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    bool func_0022020134_esc_flag;
    //       +->   IYY10311_TYPE_CREATE_S            01/09/2024  13:41
    //       !       IMPORTS:
    //       !         Work View imp_reference iyy1_server_data (Transient,
    //       !                     Mandatory, Import only)
    //       !           userid
    //       !           reference_id
    //       !         Entity View imp iyy1_type (Transient, Mandatory, Import
    //       !                     only)
    //       !           tkey_attr_text
    //       !           tsearch_attr_text
    //       !           tother_attr_text
    //       !           tother_attr_date
    //       !           tother_attr_time
    //       !           tother_attr_amount
    //       !       EXPORTS:
    //       !         Entity View exp iyy1_type (Transient, Export only)
    //       !           tinstance_id
    //       !           treference_id
    //       !         Work View exp_error iyy1_component (Transient, Export
    //       !                     only)
    //       !           severity_code
    //       !           rollback_indicator
    //       !           origin_servid
    //       !           context_string
    //       !           return_code
    //       !           reason_code
    //       !           checksum
    //       !
    //       !     PROCEDURE STATEMENTS
    //       !
    //     1 !  NOTE: 
    //     1 !  PURPOSE(CONTINUED)
    //     1 !  
    //     2 !  NOTE: 
    //     2 !  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //     2 !  !!!!!!!!!!!!
    //     2 !  Review the Pre-Post Conditions and Return/Reason Codes.
    //     2 !  
    //     3 !  NOTE: 
    //     3 !  PRE-CONDITION
    //     3 !  All mandatory fields are given.
    //     3 !  POST-CONDITION
    //     3 !  Record is created.
    //     3 !  Return Code = 1, Reason Code = 1
    //     3 !  
    //     4 !  NOTE: 
    //     4 !  PRE-CONDITION
    //     4 !  Record already exists.
    //     4 !  POST-CONDITION
    //     4 !  Record cannot be created.
    //     4 !  Return Code = -40, Reason Code = 2
    //     4 !  
    //     5 !  NOTE: 
    //     5 !  PRE-CONDITION
    //     5 !  At least one of the record fields is out of the permitted
    //     5 !  value boundaries.
    //     5 !  POST-CONDITION
    //     5 !  Record cannot be created.
    //     5 !  Return Code = -40, Reason Code = 3
    //     5 !  
    //     6 !  NOTE: 
    //     6 !  RETURN / REASON CODES
    //     6 !  +1/1 Record has been created.
    //     6 !  +1999/1 Other warnings.
    //     6 !  -40/2 Record already exists.
    //     6 !  -40/3 At least one of the record fields is out of the
    //     6 !  permitted value boundaries.
    //     6 !  -1999/1 Other errors.
    //     6 !  
    //     7 !  NOTE: 
    //     7 !  RELEASE HISTORY
    //     7 !  01_00 23-02-1998 New release
    //     7 !  
    //     8 !  NOTE: 
    //     8 !  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //     8 !  !!!!!!!!!!!!
    //     8 !  USE <mapper ab>
    //     8 !  
    //     9 !  USE myy10311_type_create
    //     9 !     WHICH IMPORTS: Work View imp_reference iyy1_server_data TO
    //     9 !              Work View imp_reference iyy1_server_data
    //     9 !                    Entity View imp iyy1_type TO Entity View imp
    //     9 !              iyy1_type
    //     9 !     WHICH EXPORTS: Entity View exp iyy1_type FROM Entity View
    //     9 !              exp iyy1_type
    //     9 !                    Work View exp_error iyy1_component FROM Work
    //     9 !              View exp_error iyy1_component
    //       +---
    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    //  CONSTRUCTOR FOR THE CLASS       
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    public IYY10311(  )
    {
      IefCGenRlse = "CA Gen 8.6";
      IsCopyright = "Copyright (c) 2024 CA Technologies. All rights reserved.";
      IefCGenDate = "2024/01/09";
      IefCGenTime = "13:41:40";
      IefCGenEncy = "9.2.A6";
      IefCGenUserId = "AliAl";
      IefCGenModel = "N8I_ORT_YYY_0112_TEMPLATE";
      IefCGenSubset = "ALL";
      IefCGenName = "IYY10311_TYPE_CREATE_S";
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
    	IYY10311_IA import_view, 
    	IYY10311_OA export_view )
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
        f_22020134_init(  );
        f_22020134(  );
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
    public void f_22020134(  )
    {
      func_0022020134_esc_flag = false;
      Globdata.GetStateData().SetCurrentABId( "0022020134" );
      Globdata.GetStateData().SetCurrentABName( "IYY10311_TYPE_CREATE_S" );
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      //    PURPOSE(CONTINUED)                                              
      //                                                                    
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      //    !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!  
      //    !!!!!!!!!!!!                                                    
      //    Review the Pre-Post Conditions and Return/Reason Codes.         
      //                                                                    
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      //    PRE-CONDITION                                                   
      //    All mandatory fields are given.                                 
      //    POST-CONDITION                                                  
      //    Record is created.                                              
      //    Return Code = 1, Reason Code = 1                                
      //                                                                    
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      //    PRE-CONDITION                                                   
      //    Record already exists.                                          
      //    POST-CONDITION                                                  
      //    Record cannot be created.                                       
      //    Return Code = -40, Reason Code = 2                              
      //                                                                    
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      //    PRE-CONDITION                                                   
      //    At least one of the record fields is out of the permitted       
      //    value boundaries.                                               
      //    POST-CONDITION                                                  
      //    Record cannot be created.                                       
      //    Return Code = -40, Reason Code = 3                              
      //                                                                    
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      //    RETURN / REASON CODES                                           
      //    +1/1 Record has been created.                                   
      //    +1999/1 Other warnings.                                         
      //    -40/2 Record already exists.                                    
      //    -40/3 At least one of the record fields is out of the           
      //    permitted value boundaries.                                     
      //    -1999/1 Other errors.                                           
      //                                                                    
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      //    RELEASE HISTORY                                                 
      //    01_00 23-02-1998 New release                                    
      //                                                                    
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      //    !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!  
      //    !!!!!!!!!!!!                                                    
      //    USE <mapper ab>                                                 
      //                                                                    
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      Globdata.GetStateData().SetLastStatementNumber( "0000000009" );
      
      Myy10311Ia = (GEN.ORT.YYY.MYY10311_IA)(IefRuntimeParm2.GetInstance( typeof(GEN.ORT.YYY.MYY10311).Assembly,
      	"GEN.ORT.YYY.MYY10311_IA" ));
      Myy10311Oa = (GEN.ORT.YYY.MYY10311_OA)(IefRuntimeParm2.GetInstance( typeof(GEN.ORT.YYY.MYY10311).Assembly,
      	"GEN.ORT.YYY.MYY10311_OA" ));
      Myy10311Ia.ImpIyy1TypeTkeyAttrText = FixedStringAttr.ValueOf(WIa.ImpIyy1TypeTkeyAttrText, 4);
      Myy10311Ia.ImpIyy1TypeTsearchAttrText = FixedStringAttr.ValueOf(WIa.ImpIyy1TypeTsearchAttrText, 20);
      Myy10311Ia.ImpIyy1TypeTotherAttrText = FixedStringAttr.ValueOf(WIa.ImpIyy1TypeTotherAttrText, 2);
      Myy10311Ia.ImpIyy1TypeTotherAttrDate = DateAttr.ValueOf(WIa.ImpIyy1TypeTotherAttrDate);
      Myy10311Ia.ImpIyy1TypeTotherAttrTime = TimeAttr.ValueOf(WIa.ImpIyy1TypeTotherAttrTime);
      Myy10311Ia.ImpIyy1TypeTotherAttrAmount = DecimalAttr.ValueOf(WIa.ImpIyy1TypeTotherAttrAmount);
      Myy10311Ia.ImpReferenceIyy1ServerDataUserid = FixedStringAttr.ValueOf(WIa.ImpReferenceIyy1ServerDataUserid, 8);
      Myy10311Ia.ImpReferenceIyy1ServerDataReferenceId = TimestampAttr.ValueOf(WIa.ImpReferenceIyy1ServerDataReferenceId);
      Globdata.GetErrorData().SetErrorEncountered( ErrorData.ErrorEncounteredNoErrorFound );
      IefRuntimeParm2.UseActionBlock( typeof(GEN.ORT.YYY.MYY10311).Assembly,
      	"GEN.ORT.YYY.MYY10311",
      	"Execute",
      	Myy10311Ia,
      	Myy10311Oa );
      if ( ((Globdata.GetErrorData().GetStatus() != ErrorData.StatusNone) || (Globdata.GetErrorData().GetErrorEncountered() != 
        ErrorData.ErrorEncounteredNoErrorFound)) || (Globdata.GetErrorData().GetViewOverflow() != 
        ErrorData.ErrorEncounteredNoErrorFound) )
      {
        throw new ABException();
      }
      Globdata.GetStateData().SetCurrentABId( "0022020134" );
      Globdata.GetStateData().SetCurrentABName( "IYY10311_TYPE_CREATE_S" );
      Globdata.GetStateData().SetLastStatementNumber( "0000000009" );
      WOa.ExpErrorIyy1ComponentSeverityCode = FixedStringAttr.ValueOf(Myy10311Oa.ExpErrorIyy1ComponentSeverityCode, 1);
      WOa.ExpErrorIyy1ComponentRollbackIndicator = FixedStringAttr.ValueOf(Myy10311Oa.ExpErrorIyy1ComponentRollbackIndicator, 1);
      WOa.ExpErrorIyy1ComponentOriginServid = DoubleAttr.ValueOf(Myy10311Oa.ExpErrorIyy1ComponentOriginServid);
      WOa.ExpErrorIyy1ComponentContextString = StringAttr.ValueOf(Myy10311Oa.ExpErrorIyy1ComponentContextString, 512);
      WOa.ExpErrorIyy1ComponentReturnCode = IntAttr.ValueOf(Myy10311Oa.ExpErrorIyy1ComponentReturnCode);
      WOa.ExpErrorIyy1ComponentReasonCode = IntAttr.ValueOf(Myy10311Oa.ExpErrorIyy1ComponentReasonCode);
      WOa.ExpErrorIyy1ComponentChecksum = FixedStringAttr.ValueOf(Myy10311Oa.ExpErrorIyy1ComponentChecksum, 15);
      WOa.ExpIyy1TypeTinstanceId = TimestampAttr.ValueOf(Myy10311Oa.ExpIyy1TypeTinstanceId);
      WOa.ExpIyy1TypeTreferenceId = TimestampAttr.ValueOf(Myy10311Oa.ExpIyy1TypeTreferenceId);
      Myy10311Ia.FreeInstance(  );
      Myy10311Ia = null;
      Myy10311Oa.FreeInstance(  );
      Myy10311Oa = null;
      return;
    }
    
    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // SUBORDINATE FUNCTIONS
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // INITIALIZATION UTILITY FUNCTIONS 
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    
    public void f_22020134_init(  )
    {
      if ( NestingLevel < 2 )
      {
      }
      WOa.ExpIyy1TypeTinstanceId = "00000000000000000000";
      WOa.ExpIyy1TypeTreferenceId = "00000000000000000000";
      WOa.ExpErrorIyy1ComponentSeverityCode = " ";
      WOa.ExpErrorIyy1ComponentRollbackIndicator = " ";
      WOa.ExpErrorIyy1ComponentOriginServid = 0.0;
      WOa.ExpErrorIyy1ComponentContextString = "";
      WOa.ExpErrorIyy1ComponentReturnCode = 0;
      WOa.ExpErrorIyy1ComponentReasonCode = 0;
      WOa.ExpErrorIyy1ComponentChecksum = "               ";
    }
  }// end class
  
}

