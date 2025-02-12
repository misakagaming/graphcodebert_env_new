namespace GEN.ORT.YYY
{
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  //
  //                    Source Code Generated by
  //                           CA Gen 8.6
  //
  //    Copyright (c) 2024 CA Technologies. All rights reserved.
  //
  //    Name: IYY1SUB0_SUB_TRANSACTIONS        Date: 2024/01/09
  //    Target OS:   CLR                       Time: 13:41:45
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
  
  public class IYY1SUB0 : ABBase
  {
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // IMPORT VIEW CLASS VARIABLE
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    IYY1SUB0_IA WIa;
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // EXPORT VIEW CLASS VARIABLE
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    IYY1SUB0_OA WOa;
    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // ACTION BLOCK IMPORT/EXPORT VIEWS CLASS VARIABLES
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    GEN.ORT.YYY.IYY19041_IA Iyy19041Ia;
    GEN.ORT.YYY.IYY19041_OA Iyy19041Oa;
    GEN.ORT.YYY.IYY19051_OA Iyy19051Oa;
    GEN.ORT.YYY.IYY19061_IA Iyy19061Ia;
    GEN.ORT.YYY.IYY19061_OA Iyy19061Oa;
    GEN.ORT.YYY.IYY19151_OA Iyy19151Oa;
    GEN.ORT.YYY.IYY19161_IA Iyy19161Ia;
    GEN.ORT.YYY.IYY19161_OA Iyy19161Oa;
    GEN.ORT.YYY.IYY19481_IA Iyy19481Ia;
    GEN.ORT.YYY.IYY19481_OA Iyy19481Oa;
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // REPEATING GROUP VIEW STATUS FIELDS 
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    bool ExpGroupHilite_FL_001;
    int ExpGroupHilite_PS_001;
    bool ExpGroupHilite_RF_001;
    public const int ExpGroupHilite_MM_001 = 10;
    bool ExpGroupHilite_FL_002;
    int ExpGroupHilite_PS_002;
    bool ExpGroupHilite_RF_002;
    public const int ExpGroupHilite_MM_002 = 10;
    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // MISC DECLARATIONS AND PROTOTYPES 
    //    FOLLOW AS NEEDED:             
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    bool func_0022020109_esc_flag;
    //       +->   IYY1SUB0_SUB_TRANSACTIONS         01/09/2024  13:41
    //       !       IMPORTS:
    //       !         Work View imp iyy1_component (Transient, Optional,
    //       !                     Import only)
    //       !           severity_code
    //       !           rollback_indicator
    //       !           origin_servid
    //       !           context_string
    //       !           return_code
    //       !           reason_code
    //       !           send_command
    //       !           client_command
    //       !           component_cd
    //       !           implementation_id
    //       !           specification_id
    //       !           dialect_cd
    //       !           activity_cd
    //       !           message_tx
    //       !           message_name_tx
    //       !           attribute_name_tx
    //       !           origin_serv_tx
    //       !           specification_string_tx
    //       !           implementation_string_tx
    //       !           checksum
    //       !       EXPORTS:
    //       !         Work View exp iyy1_component (Transient, Export only)
    //       !           severity_code
    //       !           rollback_indicator
    //       !           origin_servid
    //       !           context_string
    //       !           return_code
    //       !           reason_code
    //       !           send_command
    //       !           client_command
    //       !           component_cd
    //       !           implementation_id
    //       !           specification_id
    //       !           dialect_cd
    //       !           activity_cd
    //       !           message_tx
    //       !           message_name_tx
    //       !           attribute_name_tx
    //       !           origin_serv_tx
    //       !           specification_string_tx
    //       !           implementation_string_tx
    //       !           checksum
    //       !         Group View (10) exp_group_hilite
    //       !           Work View exp_g_hilite iyy1_component (Transient,
    //       !                       Export only)
    //       !             attribute_name_tx
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
    //     2 !  PRE-CONDITION:
    //     2 !  Inapplicable
    //     2 !  POST-CONDITION:
    //     2 !  Inapplicable
    //     2 !  RETURN CODE = Inapplicable, REASON CODE = Inapplicable
    //     2 !  
    //     3 !  NOTE: 
    //     3 !  RETURN / REASON CODES
    //     3 !  Inapplicable
    //     3 !  
    //     4 !  NOTE: 
    //     4 !  RELEASE HISTORY
    //     4 !  01_00 23-02-1998 New Release
    //     4 !  
    //     5 !  NOTE: 
    //     5 !  **********************************************************
    //     5 !  The public operations about error handling
    //     5 !  
    //     6 !  NOTE: 
    //     6 !  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //     6 !  !!!!!!!!!!!!!!!!
    //     6 !  Encode the operations (I..9*) that are only about error
    //     6 !  handling.
    //     6 !  For each AB starting with 'I', encode a seperate CASE and
    //     6 !  USE.
    //     6 !  Change the CASE values (The first 8 letters of the USEd AB).
    //     6 !  Complete the view matchings.
    //     6 !  
    //     6 !  
    //     6 !  
    //     7 !  +->CASE OF COMMAND
    //     7 !  +> CASE "IYY19041"
    //     8 !  !  USE iyy19041_excptn_msg_fmt_as_str_s
    //     8 !  !     WHICH IMPORTS: Work View imp iyy1_component TO Work View
    //     8 !  !              imp_error iyy1_component
    //     8 !  !     WHICH EXPORTS: Work View exp iyy1_component FROM Work
    //     8 !  !              View exp_error_msg iyy1_component
    //     8 !  !                    Work View exp_error iyy1_component FROM
    //     8 !  !              Work View exp_error iyy1_component
    //     7 !  +> CASE "IYY19051"
    //     9 !  !  USE iyy19051_cmpnt_identifiers_get_s
    //     9 !  !     WHICH EXPORTS: Work View exp iyy1_component FROM Work
    //     9 !  !              View exp_identifiers iyy1_component
    //     9 !  !                    Work View exp_error iyy1_component FROM
    //     9 !  !              Work View exp_error iyy1_component
    //     7 !  +> CASE "IYY19061"
    //    10 !  !  USE iyy19061_cmpnt_nm_and_prms_get_s
    //    10 !  !     WHICH IMPORTS: Work View imp iyy1_component TO Work View
    //    10 !  !              imp_identifiers iyy1_component
    //    10 !  !     WHICH EXPORTS: Work View exp iyy1_component FROM Work
    //    10 !  !              View exp_nmparms iyy1_component
    //    10 !  !                    Work View exp_error iyy1_component FROM
    //    10 !  !              Work View exp_error iyy1_component
    //     7 !  +> CASE "IYY19151"
    //    11 !  !  USE iyy19151_checksum_generate_s
    //    11 !  !     WHICH EXPORTS: Work View exp iyy1_component FROM Work
    //    11 !  !              View exp_checksum iyy1_component
    //    11 !  !                    Work View exp_error iyy1_component FROM
    //    11 !  !              Work View exp_error iyy1_component
    //     7 !  +> CASE "IYY19161"
    //    12 !  !  USE iyy19161_checksum_validate_s
    //    12 !  !     WHICH IMPORTS: Work View imp iyy1_component TO Work View
    //    12 !  !              imp_checksum iyy1_component
    //    12 !  !     WHICH EXPORTS: Work View exp_error iyy1_component FROM
    //    12 !  !              Work View exp_error iyy1_component
    //     7 !  +> CASE "IYY19481"
    //    13 !  !  USE iyy19481_exptn_msg_n_hilte_get_s
    //    13 !  !     WHICH IMPORTS: Work View imp iyy1_component TO Work View
    //    13 !  !              imp_error iyy1_component
    //    13 !  !     WHICH EXPORTS: Group View  exp_group_hilite FROM Group
    //    13 !  !              View exp_group_hilite
    //    13 !  !                    Work View exp iyy1_component FROM Work
    //    13 !  !              View exp_error_msg iyy1_component
    //    13 !  !                    Work View exp_error iyy1_component FROM
    //    13 !  !              Work View exp_error iyy1_component
    //     7 !  +> OTHERWISE
    //     7 !  +--
    //       +---
    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    //  CONSTRUCTOR FOR THE CLASS       
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    public IYY1SUB0(  )
    {
      IefCGenRlse = "CA Gen 8.6";
      IsCopyright = "Copyright (c) 2024 CA Technologies. All rights reserved.";
      IefCGenDate = "2024/01/09";
      IefCGenTime = "13:41:45";
      IefCGenEncy = "9.2.A6";
      IefCGenUserId = "AliAl";
      IefCGenModel = "N8I_ORT_YYY_0112_TEMPLATE";
      IefCGenSubset = "ALL";
      IefCGenName = "IYY1SUB0_SUB_TRANSACTIONS";
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
    	IYY1SUB0_IA import_view, 
    	IYY1SUB0_OA export_view )
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
        f_22020109_init(  );
        f_22020109(  );
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
    public void f_22020109(  )
    {
      func_0022020109_esc_flag = false;
      Globdata.GetStateData().SetCurrentABId( "0022020109" );
      Globdata.GetStateData().SetCurrentABName( "IYY1SUB0_SUB_TRANSACTIONS" );
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      //    PURPOSE(CONTINUED)                                              
      //                                                                    
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      //    PRE-CONDITION:                                                  
      //    Inapplicable                                                    
      //    POST-CONDITION:                                                 
      //    Inapplicable                                                    
      //    RETURN CODE = Inapplicable, REASON CODE = Inapplicable          
      //                                                                    
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      //    RETURN / REASON CODES                                           
      //    Inapplicable                                                    
      //                                                                    
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      //    RELEASE HISTORY                                                 
      //    01_00 23-02-1998 New Release                                    
      //                                                                    
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      //    **********************************************************      
      //    The public operations about error handling                      
      //                                                                    
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      //    !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!  
      //    !!!!!!!!!!!!!!!!                                                
      //    Encode the operations (I..9*) that are only about error         
      //    handling.                                                       
      //    For each AB starting with 'I', encode a seperate CASE and       
      //    USE.                                                            
      //    Change the CASE values (The first 8 letters of the USEd AB).    
      //    Complete the view matchings.                                    
      //                                                                    
      //                                                                    
      //                                                                    
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      Globdata.GetStateData().SetLastStatementNumber( "0000000007" );
      if ( CompareExit.CompareTo(Globdata.GetStateData().GetCommand(), "IYY19041") == 0 )
      {
        Globdata.GetStateData().SetLastSubStatementNumber( "1" );
        {
          Globdata.GetStateData().SetLastStatementNumber( "0000000008" );
          
          Iyy19041Ia = (GEN.ORT.YYY.IYY19041_IA)(IefRuntimeParm2.GetInstance( typeof(GEN.ORT.YYY.IYY19041).Assembly,
          	"GEN.ORT.YYY.IYY19041_IA" ));
          Iyy19041Oa = (GEN.ORT.YYY.IYY19041_OA)(IefRuntimeParm2.GetInstance( typeof(GEN.ORT.YYY.IYY19041).Assembly,
          	"GEN.ORT.YYY.IYY19041_OA" ));
          Iyy19041Ia.ImpErrorIyy1ComponentOriginServid = DoubleAttr.ValueOf(WIa.ImpIyy1ComponentOriginServid);
          Iyy19041Ia.ImpErrorIyy1ComponentContextString = StringAttr.ValueOf(WIa.ImpIyy1ComponentContextString, 512);
          Iyy19041Ia.ImpErrorIyy1ComponentReturnCode = IntAttr.ValueOf(WIa.ImpIyy1ComponentReturnCode);
          Iyy19041Ia.ImpErrorIyy1ComponentReasonCode = IntAttr.ValueOf(WIa.ImpIyy1ComponentReasonCode);
          Iyy19041Ia.ImpErrorIyy1ComponentImplementationId = DoubleAttr.ValueOf(WIa.ImpIyy1ComponentImplementationId);
          Iyy19041Ia.ImpErrorIyy1ComponentSpecificationId = DoubleAttr.ValueOf(WIa.ImpIyy1ComponentSpecificationId);
          Iyy19041Ia.ImpErrorIyy1ComponentDialectCd = FixedStringAttr.ValueOf(WIa.ImpIyy1ComponentDialectCd, 2);
          Iyy19041Ia.ImpErrorIyy1ComponentActivityCd = FixedStringAttr.ValueOf(WIa.ImpIyy1ComponentActivityCd, 15);
          Globdata.GetErrorData().SetErrorEncountered( ErrorData.ErrorEncounteredNoErrorFound );
          IefRuntimeParm2.UseActionBlock( typeof(GEN.ORT.YYY.IYY19041).Assembly,
          	"GEN.ORT.YYY.IYY19041",
          	"Execute",
          	Iyy19041Ia,
          	Iyy19041Oa );
          if ( ((Globdata.GetErrorData().GetStatus() != ErrorData.StatusNone) || (Globdata.GetErrorData().GetErrorEncountered() != 
            ErrorData.ErrorEncounteredNoErrorFound)) || (Globdata.GetErrorData().GetViewOverflow() != 
            ErrorData.ErrorEncounteredNoErrorFound) )
          {
            throw new ABException();
          }
          Globdata.GetStateData().SetCurrentABId( "0022020109" );
          Globdata.GetStateData().SetCurrentABName( "IYY1SUB0_SUB_TRANSACTIONS" );
          Globdata.GetStateData().SetLastStatementNumber( "0000000008" );
          WOa.ExpErrorIyy1ComponentSeverityCode = FixedStringAttr.ValueOf(Iyy19041Oa.ExpErrorIyy1ComponentSeverityCode, 1);
          WOa.ExpErrorIyy1ComponentRollbackIndicator = FixedStringAttr.ValueOf(Iyy19041Oa.ExpErrorIyy1ComponentRollbackIndicator, 1)
            ;
          WOa.ExpErrorIyy1ComponentOriginServid = DoubleAttr.ValueOf(Iyy19041Oa.ExpErrorIyy1ComponentOriginServid);
          WOa.ExpErrorIyy1ComponentContextString = StringAttr.ValueOf(Iyy19041Oa.ExpErrorIyy1ComponentContextString, 512);
          WOa.ExpErrorIyy1ComponentReturnCode = IntAttr.ValueOf(Iyy19041Oa.ExpErrorIyy1ComponentReturnCode);
          WOa.ExpErrorIyy1ComponentReasonCode = IntAttr.ValueOf(Iyy19041Oa.ExpErrorIyy1ComponentReasonCode);
          WOa.ExpErrorIyy1ComponentChecksum = FixedStringAttr.ValueOf(Iyy19041Oa.ExpErrorIyy1ComponentChecksum, 15);
          WOa.ExpIyy1ComponentSeverityCode = FixedStringAttr.ValueOf(Iyy19041Oa.ExpErrorMsgIyy1ComponentSeverityCode, 1);
          WOa.ExpIyy1ComponentMessageTx = StringAttr.ValueOf(Iyy19041Oa.ExpErrorMsgIyy1ComponentMessageTx, 512);
          Iyy19041Ia.FreeInstance(  );
          Iyy19041Ia = null;
          Iyy19041Oa.FreeInstance(  );
          Iyy19041Oa = null;
        }
      }
      else if ( CompareExit.CompareTo(Globdata.GetStateData().GetCommand(), "IYY19051") == 0 )
      {
        Globdata.GetStateData().SetLastSubStatementNumber( "2" );
        {
          Globdata.GetStateData().SetLastStatementNumber( "0000000009" );
          
          Iyy19051Oa = (GEN.ORT.YYY.IYY19051_OA)(IefRuntimeParm2.GetInstance( typeof(GEN.ORT.YYY.IYY19051).Assembly,
          	"GEN.ORT.YYY.IYY19051_OA" ));
          Globdata.GetErrorData().SetErrorEncountered( ErrorData.ErrorEncounteredNoErrorFound );
          IefRuntimeParm2.UseActionBlock( typeof(GEN.ORT.YYY.IYY19051).Assembly,
          	"GEN.ORT.YYY.IYY19051",
          	"Execute",
          	null,
          	Iyy19051Oa );
          if ( ((Globdata.GetErrorData().GetStatus() != ErrorData.StatusNone) || (Globdata.GetErrorData().GetErrorEncountered() != 
            ErrorData.ErrorEncounteredNoErrorFound)) || (Globdata.GetErrorData().GetViewOverflow() != 
            ErrorData.ErrorEncounteredNoErrorFound) )
          {
            throw new ABException();
          }
          Globdata.GetStateData().SetCurrentABId( "0022020109" );
          Globdata.GetStateData().SetCurrentABName( "IYY1SUB0_SUB_TRANSACTIONS" );
          Globdata.GetStateData().SetLastStatementNumber( "0000000009" );
          WOa.ExpErrorIyy1ComponentSeverityCode = FixedStringAttr.ValueOf(Iyy19051Oa.ExpErrorIyy1ComponentSeverityCode, 1);
          WOa.ExpErrorIyy1ComponentRollbackIndicator = FixedStringAttr.ValueOf(Iyy19051Oa.ExpErrorIyy1ComponentRollbackIndicator, 1)
            ;
          WOa.ExpErrorIyy1ComponentOriginServid = DoubleAttr.ValueOf(Iyy19051Oa.ExpErrorIyy1ComponentOriginServid);
          WOa.ExpErrorIyy1ComponentContextString = StringAttr.ValueOf(Iyy19051Oa.ExpErrorIyy1ComponentContextString, 512);
          WOa.ExpErrorIyy1ComponentReturnCode = IntAttr.ValueOf(Iyy19051Oa.ExpErrorIyy1ComponentReturnCode);
          WOa.ExpErrorIyy1ComponentReasonCode = IntAttr.ValueOf(Iyy19051Oa.ExpErrorIyy1ComponentReasonCode);
          WOa.ExpErrorIyy1ComponentChecksum = FixedStringAttr.ValueOf(Iyy19051Oa.ExpErrorIyy1ComponentChecksum, 15);
          WOa.ExpIyy1ComponentOriginServid = DoubleAttr.ValueOf(Iyy19051Oa.ExpIdentifiersIyy1ComponentOriginServid);
          WOa.ExpIyy1ComponentImplementationId = DoubleAttr.ValueOf(Iyy19051Oa.ExpIdentifiersIyy1ComponentImplementationId);
          WOa.ExpIyy1ComponentSpecificationId = DoubleAttr.ValueOf(Iyy19051Oa.ExpIdentifiersIyy1ComponentSpecificationId);
          Iyy19051Oa.FreeInstance(  );
          Iyy19051Oa = null;
        }
      }
      else if ( CompareExit.CompareTo(Globdata.GetStateData().GetCommand(), "IYY19061") == 0 )
      {
        Globdata.GetStateData().SetLastSubStatementNumber( "3" );
        {
          Globdata.GetStateData().SetLastStatementNumber( "0000000010" );
          
          Iyy19061Ia = (GEN.ORT.YYY.IYY19061_IA)(IefRuntimeParm2.GetInstance( typeof(GEN.ORT.YYY.IYY19061).Assembly,
          	"GEN.ORT.YYY.IYY19061_IA" ));
          Iyy19061Oa = (GEN.ORT.YYY.IYY19061_OA)(IefRuntimeParm2.GetInstance( typeof(GEN.ORT.YYY.IYY19061).Assembly,
          	"GEN.ORT.YYY.IYY19061_OA" ));
          Iyy19061Ia.ImpIdentifiersIyy1ComponentOriginServid = DoubleAttr.ValueOf(WIa.ImpIyy1ComponentOriginServid);
          Iyy19061Ia.ImpIdentifiersIyy1ComponentImplementationId = DoubleAttr.ValueOf(WIa.ImpIyy1ComponentImplementationId);
          Iyy19061Ia.ImpIdentifiersIyy1ComponentSpecificationId = DoubleAttr.ValueOf(WIa.ImpIyy1ComponentSpecificationId);
          Globdata.GetErrorData().SetErrorEncountered( ErrorData.ErrorEncounteredNoErrorFound );
          IefRuntimeParm2.UseActionBlock( typeof(GEN.ORT.YYY.IYY19061).Assembly,
          	"GEN.ORT.YYY.IYY19061",
          	"Execute",
          	Iyy19061Ia,
          	Iyy19061Oa );
          if ( ((Globdata.GetErrorData().GetStatus() != ErrorData.StatusNone) || (Globdata.GetErrorData().GetErrorEncountered() != 
            ErrorData.ErrorEncounteredNoErrorFound)) || (Globdata.GetErrorData().GetViewOverflow() != 
            ErrorData.ErrorEncounteredNoErrorFound) )
          {
            throw new ABException();
          }
          Globdata.GetStateData().SetCurrentABId( "0022020109" );
          Globdata.GetStateData().SetCurrentABName( "IYY1SUB0_SUB_TRANSACTIONS" );
          Globdata.GetStateData().SetLastStatementNumber( "0000000010" );
          WOa.ExpErrorIyy1ComponentSeverityCode = FixedStringAttr.ValueOf(Iyy19061Oa.ExpErrorIyy1ComponentSeverityCode, 1);
          WOa.ExpErrorIyy1ComponentRollbackIndicator = FixedStringAttr.ValueOf(Iyy19061Oa.ExpErrorIyy1ComponentRollbackIndicator, 1)
            ;
          WOa.ExpErrorIyy1ComponentOriginServid = DoubleAttr.ValueOf(Iyy19061Oa.ExpErrorIyy1ComponentOriginServid);
          WOa.ExpErrorIyy1ComponentContextString = StringAttr.ValueOf(Iyy19061Oa.ExpErrorIyy1ComponentContextString, 512);
          WOa.ExpErrorIyy1ComponentReturnCode = IntAttr.ValueOf(Iyy19061Oa.ExpErrorIyy1ComponentReturnCode);
          WOa.ExpErrorIyy1ComponentReasonCode = IntAttr.ValueOf(Iyy19061Oa.ExpErrorIyy1ComponentReasonCode);
          WOa.ExpErrorIyy1ComponentChecksum = FixedStringAttr.ValueOf(Iyy19061Oa.ExpErrorIyy1ComponentChecksum, 15);
          WOa.ExpIyy1ComponentOriginServid = DoubleAttr.ValueOf(Iyy19061Oa.ExpNmparmsIyy1ComponentOriginServid);
          WOa.ExpIyy1ComponentImplementationId = DoubleAttr.ValueOf(Iyy19061Oa.ExpNmparmsIyy1ComponentImplementationId);
          WOa.ExpIyy1ComponentSpecificationId = DoubleAttr.ValueOf(Iyy19061Oa.ExpNmparmsIyy1ComponentSpecificationId);
          WOa.ExpIyy1ComponentOriginServTx = StringAttr.ValueOf(Iyy19061Oa.ExpNmparmsIyy1ComponentOriginServTx, 255);
          WOa.ExpIyy1ComponentSpecificationStringTx = StringAttr.ValueOf(Iyy19061Oa.ExpNmparmsIyy1ComponentSpecificationStringTx, 
            255);
          WOa.ExpIyy1ComponentImplementationStringTx = StringAttr.ValueOf(Iyy19061Oa.ExpNmparmsIyy1ComponentImplementationStringTx, 
            255);
          Iyy19061Ia.FreeInstance(  );
          Iyy19061Ia = null;
          Iyy19061Oa.FreeInstance(  );
          Iyy19061Oa = null;
        }
      }
      else if ( CompareExit.CompareTo(Globdata.GetStateData().GetCommand(), "IYY19151") == 0 )
      {
        Globdata.GetStateData().SetLastSubStatementNumber( "4" );
        {
          Globdata.GetStateData().SetLastStatementNumber( "0000000011" );
          
          Iyy19151Oa = (GEN.ORT.YYY.IYY19151_OA)(IefRuntimeParm2.GetInstance( typeof(GEN.ORT.YYY.IYY19151).Assembly,
          	"GEN.ORT.YYY.IYY19151_OA" ));
          Globdata.GetErrorData().SetErrorEncountered( ErrorData.ErrorEncounteredNoErrorFound );
          IefRuntimeParm2.UseActionBlock( typeof(GEN.ORT.YYY.IYY19151).Assembly,
          	"GEN.ORT.YYY.IYY19151",
          	"Execute",
          	null,
          	Iyy19151Oa );
          if ( ((Globdata.GetErrorData().GetStatus() != ErrorData.StatusNone) || (Globdata.GetErrorData().GetErrorEncountered() != 
            ErrorData.ErrorEncounteredNoErrorFound)) || (Globdata.GetErrorData().GetViewOverflow() != 
            ErrorData.ErrorEncounteredNoErrorFound) )
          {
            throw new ABException();
          }
          Globdata.GetStateData().SetCurrentABId( "0022020109" );
          Globdata.GetStateData().SetCurrentABName( "IYY1SUB0_SUB_TRANSACTIONS" );
          Globdata.GetStateData().SetLastStatementNumber( "0000000011" );
          WOa.ExpErrorIyy1ComponentSeverityCode = FixedStringAttr.ValueOf(Iyy19151Oa.ExpErrorIyy1ComponentSeverityCode, 1);
          WOa.ExpErrorIyy1ComponentRollbackIndicator = FixedStringAttr.ValueOf(Iyy19151Oa.ExpErrorIyy1ComponentRollbackIndicator, 1)
            ;
          WOa.ExpErrorIyy1ComponentOriginServid = DoubleAttr.ValueOf(Iyy19151Oa.ExpErrorIyy1ComponentOriginServid);
          WOa.ExpErrorIyy1ComponentContextString = StringAttr.ValueOf(Iyy19151Oa.ExpErrorIyy1ComponentContextString, 512);
          WOa.ExpErrorIyy1ComponentReturnCode = IntAttr.ValueOf(Iyy19151Oa.ExpErrorIyy1ComponentReturnCode);
          WOa.ExpErrorIyy1ComponentReasonCode = IntAttr.ValueOf(Iyy19151Oa.ExpErrorIyy1ComponentReasonCode);
          WOa.ExpErrorIyy1ComponentChecksum = FixedStringAttr.ValueOf(Iyy19151Oa.ExpErrorIyy1ComponentChecksum, 15);
          WOa.ExpIyy1ComponentChecksum = FixedStringAttr.ValueOf(Iyy19151Oa.ExpChecksumIyy1ComponentChecksum, 15);
          Iyy19151Oa.FreeInstance(  );
          Iyy19151Oa = null;
        }
      }
      else if ( CompareExit.CompareTo(Globdata.GetStateData().GetCommand(), "IYY19161") == 0 )
      {
        Globdata.GetStateData().SetLastSubStatementNumber( "5" );
        {
          Globdata.GetStateData().SetLastStatementNumber( "0000000012" );
          
          Iyy19161Ia = (GEN.ORT.YYY.IYY19161_IA)(IefRuntimeParm2.GetInstance( typeof(GEN.ORT.YYY.IYY19161).Assembly,
          	"GEN.ORT.YYY.IYY19161_IA" ));
          Iyy19161Oa = (GEN.ORT.YYY.IYY19161_OA)(IefRuntimeParm2.GetInstance( typeof(GEN.ORT.YYY.IYY19161).Assembly,
          	"GEN.ORT.YYY.IYY19161_OA" ));
          Iyy19161Ia.ImpChecksumIyy1ComponentChecksum = FixedStringAttr.ValueOf(WIa.ImpIyy1ComponentChecksum, 15);
          Globdata.GetErrorData().SetErrorEncountered( ErrorData.ErrorEncounteredNoErrorFound );
          IefRuntimeParm2.UseActionBlock( typeof(GEN.ORT.YYY.IYY19161).Assembly,
          	"GEN.ORT.YYY.IYY19161",
          	"Execute",
          	Iyy19161Ia,
          	Iyy19161Oa );
          if ( ((Globdata.GetErrorData().GetStatus() != ErrorData.StatusNone) || (Globdata.GetErrorData().GetErrorEncountered() != 
            ErrorData.ErrorEncounteredNoErrorFound)) || (Globdata.GetErrorData().GetViewOverflow() != 
            ErrorData.ErrorEncounteredNoErrorFound) )
          {
            throw new ABException();
          }
          Globdata.GetStateData().SetCurrentABId( "0022020109" );
          Globdata.GetStateData().SetCurrentABName( "IYY1SUB0_SUB_TRANSACTIONS" );
          Globdata.GetStateData().SetLastStatementNumber( "0000000012" );
          WOa.ExpErrorIyy1ComponentSeverityCode = FixedStringAttr.ValueOf(Iyy19161Oa.ExpErrorIyy1ComponentSeverityCode, 1);
          WOa.ExpErrorIyy1ComponentRollbackIndicator = FixedStringAttr.ValueOf(Iyy19161Oa.ExpErrorIyy1ComponentRollbackIndicator, 1)
            ;
          WOa.ExpErrorIyy1ComponentOriginServid = DoubleAttr.ValueOf(Iyy19161Oa.ExpErrorIyy1ComponentOriginServid);
          WOa.ExpErrorIyy1ComponentContextString = StringAttr.ValueOf(Iyy19161Oa.ExpErrorIyy1ComponentContextString, 512);
          WOa.ExpErrorIyy1ComponentReturnCode = IntAttr.ValueOf(Iyy19161Oa.ExpErrorIyy1ComponentReturnCode);
          WOa.ExpErrorIyy1ComponentReasonCode = IntAttr.ValueOf(Iyy19161Oa.ExpErrorIyy1ComponentReasonCode);
          WOa.ExpErrorIyy1ComponentChecksum = FixedStringAttr.ValueOf(Iyy19161Oa.ExpErrorIyy1ComponentChecksum, 15);
          Iyy19161Ia.FreeInstance(  );
          Iyy19161Ia = null;
          Iyy19161Oa.FreeInstance(  );
          Iyy19161Oa = null;
        }
      }
      else if ( CompareExit.CompareTo(Globdata.GetStateData().GetCommand(), "IYY19481") == 0 )
      {
        Globdata.GetStateData().SetLastSubStatementNumber( "6" );
        {
          Globdata.GetStateData().SetLastStatementNumber( "0000000013" );
          
          Iyy19481Ia = (GEN.ORT.YYY.IYY19481_IA)(IefRuntimeParm2.GetInstance( typeof(GEN.ORT.YYY.IYY19481).Assembly,
          	"GEN.ORT.YYY.IYY19481_IA" ));
          Iyy19481Oa = (GEN.ORT.YYY.IYY19481_OA)(IefRuntimeParm2.GetInstance( typeof(GEN.ORT.YYY.IYY19481).Assembly,
          	"GEN.ORT.YYY.IYY19481_OA" ));
          Iyy19481Ia.ImpErrorIyy1ComponentOriginServid = DoubleAttr.ValueOf(WIa.ImpIyy1ComponentOriginServid);
          Iyy19481Ia.ImpErrorIyy1ComponentContextString = StringAttr.ValueOf(WIa.ImpIyy1ComponentContextString, 512);
          Iyy19481Ia.ImpErrorIyy1ComponentReturnCode = IntAttr.ValueOf(WIa.ImpIyy1ComponentReturnCode);
          Iyy19481Ia.ImpErrorIyy1ComponentReasonCode = IntAttr.ValueOf(WIa.ImpIyy1ComponentReasonCode);
          Iyy19481Ia.ImpErrorIyy1ComponentImplementationId = DoubleAttr.ValueOf(WIa.ImpIyy1ComponentImplementationId);
          Iyy19481Ia.ImpErrorIyy1ComponentSpecificationId = DoubleAttr.ValueOf(WIa.ImpIyy1ComponentSpecificationId);
          Iyy19481Ia.ImpErrorIyy1ComponentDialectCd = FixedStringAttr.ValueOf(WIa.ImpIyy1ComponentDialectCd, 2);
          Iyy19481Ia.ImpErrorIyy1ComponentActivityCd = FixedStringAttr.ValueOf(WIa.ImpIyy1ComponentActivityCd, 15);
          Globdata.GetErrorData().SetErrorEncountered( ErrorData.ErrorEncounteredNoErrorFound );
          IefRuntimeParm2.UseActionBlock( typeof(GEN.ORT.YYY.IYY19481).Assembly,
          	"GEN.ORT.YYY.IYY19481",
          	"Execute",
          	Iyy19481Ia,
          	Iyy19481Oa );
          if ( ((Globdata.GetErrorData().GetStatus() != ErrorData.StatusNone) || (Globdata.GetErrorData().GetErrorEncountered() != 
            ErrorData.ErrorEncounteredNoErrorFound)) || (Globdata.GetErrorData().GetViewOverflow() != 
            ErrorData.ErrorEncounteredNoErrorFound) )
          {
            throw new ABException();
          }
          Globdata.GetStateData().SetCurrentABId( "0022020109" );
          Globdata.GetStateData().SetCurrentABName( "IYY1SUB0_SUB_TRANSACTIONS" );
          Globdata.GetStateData().SetLastStatementNumber( "0000000013" );
          WOa.ExpErrorIyy1ComponentSeverityCode = FixedStringAttr.ValueOf(Iyy19481Oa.ExpErrorIyy1ComponentSeverityCode, 1);
          WOa.ExpErrorIyy1ComponentRollbackIndicator = FixedStringAttr.ValueOf(Iyy19481Oa.ExpErrorIyy1ComponentRollbackIndicator, 1)
            ;
          WOa.ExpErrorIyy1ComponentOriginServid = DoubleAttr.ValueOf(Iyy19481Oa.ExpErrorIyy1ComponentOriginServid);
          WOa.ExpErrorIyy1ComponentContextString = StringAttr.ValueOf(Iyy19481Oa.ExpErrorIyy1ComponentContextString, 512);
          WOa.ExpErrorIyy1ComponentReturnCode = IntAttr.ValueOf(Iyy19481Oa.ExpErrorIyy1ComponentReturnCode);
          WOa.ExpErrorIyy1ComponentReasonCode = IntAttr.ValueOf(Iyy19481Oa.ExpErrorIyy1ComponentReasonCode);
          WOa.ExpErrorIyy1ComponentChecksum = FixedStringAttr.ValueOf(Iyy19481Oa.ExpErrorIyy1ComponentChecksum, 15);
          WOa.ExpIyy1ComponentSeverityCode = FixedStringAttr.ValueOf(Iyy19481Oa.ExpErrorMsgIyy1ComponentSeverityCode, 1);
          WOa.ExpIyy1ComponentMessageTx = StringAttr.ValueOf(Iyy19481Oa.ExpErrorMsgIyy1ComponentMessageTx, 512);
          WOa.ExpGroupHilite_MA = IntAttr.ValueOf(Iyy19481Oa.ExpGroupHilite_MA);
          for(Adim1 = 1; Adim1 <= WOa.ExpGroupHilite_MA; ++(Adim1))
          {
            WOa.ExpGHiliteIyy1ComponentAttributeNameTx[Adim1-1] = FixedStringAttr.ValueOf(
              Iyy19481Oa.ExpGHiliteIyy1ComponentAttributeNameTx[Adim1-1], 50);
          }
          Iyy19481Ia.FreeInstance(  );
          Iyy19481Ia = null;
          Iyy19481Oa.FreeInstance(  );
          Iyy19481Oa = null;
        }
      }
      else {
        Globdata.GetStateData().SetLastSubStatementNumber( "7" );
        {
          // Empty statement here.
          ;
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
    
    public void f_22020109_init(  )
    {
      if ( NestingLevel < 2 )
      {
      }
      WOa.ExpIyy1ComponentSeverityCode = " ";
      WOa.ExpIyy1ComponentRollbackIndicator = " ";
      WOa.ExpIyy1ComponentOriginServid = 0.0;
      WOa.ExpIyy1ComponentContextString = "";
      WOa.ExpIyy1ComponentReturnCode = 0;
      WOa.ExpIyy1ComponentReasonCode = 0;
      WOa.ExpIyy1ComponentSendCommand = "        ";
      WOa.ExpIyy1ComponentClientCommand = "        ";
      WOa.ExpIyy1ComponentComponentCd = "   ";
      WOa.ExpIyy1ComponentImplementationId = 0.0;
      WOa.ExpIyy1ComponentSpecificationId = 0.0;
      WOa.ExpIyy1ComponentDialectCd = "  ";
      WOa.ExpIyy1ComponentActivityCd = "               ";
      WOa.ExpIyy1ComponentMessageTx = "";
      WOa.ExpIyy1ComponentMessageNameTx = "                              ";
      WOa.ExpIyy1ComponentAttributeNameTx = "                                                  ";
      WOa.ExpIyy1ComponentOriginServTx = "";
      WOa.ExpIyy1ComponentSpecificationStringTx = "";
      WOa.ExpIyy1ComponentImplementationStringTx = "";
      WOa.ExpIyy1ComponentChecksum = "               ";
      WOa.ExpGroupHilite_MA = 0;
      for(ExpGroupHilite_PS_001 = 1; ExpGroupHilite_PS_001 <= 10; ++(ExpGroupHilite_PS_001))
      {
        WOa.ExpGHiliteIyy1ComponentAttributeNameTx[ExpGroupHilite_PS_001-1] = "                                                  ";
      }
      WOa.ExpErrorIyy1ComponentSeverityCode = " ";
      WOa.ExpErrorIyy1ComponentRollbackIndicator = " ";
      WOa.ExpErrorIyy1ComponentOriginServid = 0.0;
      WOa.ExpErrorIyy1ComponentContextString = "";
      WOa.ExpErrorIyy1ComponentReturnCode = 0;
      WOa.ExpErrorIyy1ComponentReasonCode = 0;
      WOa.ExpErrorIyy1ComponentChecksum = "               ";
      ExpGroupHilite_PS_001 = 1;
      ExpGroupHilite_PS_002 = 1;
    }
  }// end class
  
}

