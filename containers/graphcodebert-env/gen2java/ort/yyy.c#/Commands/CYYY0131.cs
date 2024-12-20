namespace GEN.ORT.YYY
{
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  //
  //                    Source Code Generated by
  //                           CA Gen 8.6
  //
  //    Copyright (c) 2024 CA Technologies. All rights reserved.
  //
  //    Name: CYYY0131_PARENT_UPDATE           Date: 2024/01/09
  //    Target OS:   CLR                       Time: 13:40:49
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
  
  public class CYYY0131 : ABBase
  {
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // IMPORT VIEW CLASS VARIABLE
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    CYYY0131_IA WIa;
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // EXPORT VIEW CLASS VARIABLE
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    CYYY0131_OA WOa;
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // LOCAL VIEW CLASS VARIABLE
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    CYYY0131_LA WLa;
    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // ACTION BLOCK IMPORT/EXPORT VIEWS CLASS VARIABLES
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    GEN.ORT.YYY.CYYY9001_OA Cyyy9001Oa;
    GEN.ORT.YYY.CYYY9141_IA Cyyy9141Ia;
    GEN.ORT.YYY.CYYY9141_OA Cyyy9141Oa;
    GEN.ORT.YYY.DYYY0131_IA Dyyy0131Ia;
    GEN.ORT.YYY.DYYY0131_OA Dyyy0131Oa;
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // REPEATING GROUP VIEW STATUS FIELDS 
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    bool LocGroupContext_FL_001;
    int LocGroupContext_PS_001;
    bool LocGroupContext_RF_001;
    public const int LocGroupContext_MM_001 = 9;
    bool ImpGroupContext_FL_002;
    int ImpGroupContext_PS_002;
    bool ImpGroupContext_RF_002;
    public const int ImpGroupContext_MM_002 = 9;
    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // MISC DECLARATIONS AND PROTOTYPES 
    //    FOLLOW AS NEEDED:             
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    bool func_0022020341_esc_flag;
    bool func_0020972544_esc_flag;
    bool func_0020972237_esc_flag;
    bool func_0020972334_esc_flag;
    bool func_0020972317_esc_flag;
    //       +->   CYYY0131_PARENT_UPDATE            01/09/2024  13:40
    //       !       IMPORTS:
    //       !         Work View imp_reference iyy1_server_data (Transient,
    //       !                     Mandatory, Import only)
    //       !           userid
    //       !           reference_id
    //       !         Entity View imp parent (Transient, Mandatory, Import
    //       !                     only)
    //       !           pinstance_id
    //       !           preference_id
    //       !           pkey_attr_text
    //       !           psearch_attr_text
    //       !           pother_attr_text
    //       !           ptype_tkey_attr_text
    //       !       EXPORTS:
    //       !         Entity View exp parent (Transient, Export only)
    //       !           preference_id
    //       !         Work View exp_error iyy1_component (Transient, Export
    //       !                     only)
    //       !           severity_code
    //       !           rollback_indicator
    //       !           origin_servid
    //       !           context_string
    //       !           return_code
    //       !           reason_code
    //       !           checksum
    //       !       LOCALS:
    //       !         Entity View loc_imp parent
    //       !           pinstance_id
    //       !           preference_id
    //       !           pkey_attr_text
    //       !           psearch_attr_text
    //       !           pother_attr_text
    //       !           ptype_tkey_attr_text
    //       !         Entity View loc_empty parent
    //       !           pinstance_id
    //       !           pkey_attr_text
    //       !           psearch_attr_text
    //       !           pother_attr_text
    //       !           ptype_tkey_attr_text
    //       !         Work View loc_error iyy1_component
    //       !           severity_code
    //       !           rollback_indicator
    //       !           origin_servid
    //       !           context_string
    //       !           return_code
    //       !           reason_code
    //       !           checksum
    //       !         Group View (9) loc_group_context
    //       !           Work View loc_g_context dont_change_text
    //       !             text_150
    //       !         Work View loc dont_change_return_codes
    //       !           1_ok
    //       !           n20_mandatory_import_missing
    //       !         Work View loc dont_change_reason_codes
    //       !           1_default
    //       !           104_parent_type_key_attr_mand
    //       !           105_parent_key_attr_mand
    //       !           106_parent_search_attr_mand
    //       !
    //       !     PROCEDURE STATEMENTS
    //       !
    //     1 !  NOTE: 
    //     1 !  See the description for the purpose.
    //     1 !  
    //     2 !  NOTE: 
    //     2 !  RELEASE HISTORY
    //     2 !  01_00 23-02-1998 New release
    //     2 !  
    //     3 !  USE cyyy9001_exception_hndlng_dflt
    //     3 !     WHICH EXPORTS: Work View exp_error iyy1_component FROM Work
    //     3 !              View exp_error iyy1_component
    //     4 !   
    //     5 !  NOTE: 
    //     5 !  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //     5 !  Name the method below
    //     5 !  
    //     6 !  SET SUBSCRIPT OF loc_group_context TO 1 
    //     7 !  SET loc_g_context dont_change_text text_150 TO "CYYY0131" 
    //     8 !  SET SUBSCRIPT OF loc_group_context TO 2 
    //     9 !  SET loc_g_context dont_change_text text_150 TO "UPDATE" 
    //    10 !   
    //    11 !  NOTE: 
    //    11 !  ****************************************************************
    //    11 !  The used ReturnCode/ReasonCode values
    //    11 !  
    //    12 !  NOTE: 
    //    12 !  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //    12 !  Set the return and reason codes below
    //    12 !  
    //    13 !  SET loc dont_change_return_codes 1_ok TO 1 
    //    14 !  SET loc dont_change_return_codes n20_mandatory_import_missing
    //    14 !              TO -20 
    //    15 !   
    //    16 !  SET loc dont_change_reason_codes 1_default TO 1 
    //    17 !  SET loc dont_change_reason_codes 104_parent_type_key_attr_mand
    //    17 !              TO 104 
    //    18 !  SET loc dont_change_reason_codes 105_parent_key_attr_mand TO
    //    18 !              105 
    //    19 !  SET loc dont_change_reason_codes 106_parent_search_attr_mand
    //    19 !              TO 106 
    //    20 !   
    //    21 !  NOTE: 
    //    21 !  ****************************************************************
    //    21 !  
    //    22 !  MOVE imp parent TO loc_imp parent
    //    23 !   
    //    24 !  NOTE: 
    //    24 !  **************************************************************
    //    24 !  **
    //    24 !  Mandatory or optional only the needed fields for the
    //    24 !  operation are checked.
    //    24 !  
    //    25 !  +->IF exp_error iyy1_component return_code >= loc
    //    25 !  !        dont_change_return_codes 1_ok
    //    26 !  !  +->IF loc_imp parent pkey_attr_text <= loc_empty parent
    //    26 !  !  !        pkey_attr_text
    //    27 !  !  !  SET exp_error iyy1_component return_code TO loc
    //    27 !  !  !              dont_change_return_codes
    //    27 !  !  !              n20_mandatory_import_missing 
    //    28 !  !  !  SET exp_error iyy1_component reason_code TO loc
    //    28 !  !  !              dont_change_reason_codes
    //    28 !  !  !              104_parent_type_key_attr_mand 
    //    26 !  !  +--
    //    29 !  !  +->IF loc_imp parent psearch_attr_text <= loc_empty parent
    //    29 !  !  !        psearch_attr_text
    //    30 !  !  !  SET exp_error iyy1_component return_code TO loc
    //    30 !  !  !              dont_change_return_codes
    //    30 !  !  !              n20_mandatory_import_missing 
    //    31 !  !  !  SET exp_error iyy1_component reason_code TO loc
    //    31 !  !  !              dont_change_reason_codes
    //    31 !  !  !              105_parent_key_attr_mand 
    //    29 !  !  +--
    //    32 !  !  +->IF imp parent ptype_tkey_attr_text <= loc_empty parent
    //    32 !  !  !        ptype_tkey_attr_text
    //    33 !  !  !  SET exp_error iyy1_component return_code TO loc
    //    33 !  !  !              dont_change_return_codes
    //    33 !  !  !              n20_mandatory_import_missing 
    //    34 !  !  !  SET exp_error iyy1_component reason_code TO loc
    //    34 !  !  !              dont_change_reason_codes
    //    34 !  !  !              106_parent_search_attr_mand 
    //    32 !  !  +--
    //    25 !  +--
    //    35 !   
    //    36 !  +->IF exp_error iyy1_component return_code >= loc
    //    36 !  !        dont_change_return_codes 1_ok
    //    37 !  !  USE dyyy0131_parent_update
    //    37 !  !     WHICH IMPORTS: Work View exp_error iyy1_component TO
    //    37 !  !              Work View imp_error iyy1_component
    //    37 !  !                    Work View imp_reference iyy1_server_data
    //    37 !  !              TO Work View imp_reference iyy1_server_data
    //    37 !  !                    Entity View loc_imp parent TO Entity View
    //    37 !  !              imp parent
    //    37 !  !     WHICH EXPORTS: Entity View exp parent FROM Entity View
    //    37 !  !              exp parent
    //    37 !  !                    Work View loc_error iyy1_component FROM
    //    37 !  !              Work View exp_error iyy1_component
    //    38 !  !  +->IF loc_error iyy1_component return_code < loc
    //    38 !  !  !        dont_change_return_codes 1_ok
    //    39 !  !  !  MOVE loc_error iyy1_component TO exp_error
    //    39 !  !  !              iyy1_component
    //    40 !  !  !  NOTE: 
    //    40 ...!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //    40 ...!!!!!!!!!!!
    //    40 ...!! WARNING: In D AB, if there' s a need for generating
    //    40 ...context string, must exit from ESCAPE AB.
    //    40 ...
    //    41 ! <------ESCAPE
    //    38 !  !  +--
    //    36 !  +--
    //    42 !   
    //    43 !  +->IF exp_error iyy1_component return_code < loc
    //    43 !  !        dont_change_return_codes 1_ok
    //    44 !  !  USE cyyy9141_context_string_set
    //    44 !  !     WHICH IMPORTS: Group View  loc_group_context TO Group
    //    44 !  !              View imp_group_context
    //    44 !  !     WHICH EXPORTS: Work View loc_error iyy1_component FROM
    //    44 !  !              Work View exp_error iyy1_component
    //    44 !  !                    Work View exp_error iyy1_component FROM
    //    44 !  !              Work View exp_context iyy1_component
    //    45 !  !   
    //    46 !  !  +->IF loc_error iyy1_component return_code < loc
    //    46 !  !  !        dont_change_return_codes 1_ok
    //    47 !  !  !  MOVE loc_error iyy1_component TO exp_error
    //    47 !  !  !              iyy1_component
    //    46 !  !  +--
    //    48 !  !  SET exp_error iyy1_component severity_code TO "E" 
    //    43 !  +--
    //       +---
    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    //  CONSTRUCTOR FOR THE CLASS       
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    public CYYY0131(  )
    {
      IefCGenRlse = "CA Gen 8.6";
      IsCopyright = "Copyright (c) 2024 CA Technologies. All rights reserved.";
      IefCGenDate = "2024/01/09";
      IefCGenTime = "13:40:49";
      IefCGenEncy = "9.2.A6";
      IefCGenUserId = "AliAl";
      IefCGenModel = "N8I_ORT_YYY_0112_TEMPLATE";
      IefCGenSubset = "ALL";
      IefCGenName = "CYYY0131_PARENT_UPDATE";
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
    	CYYY0131_IA import_view, 
    	CYYY0131_OA export_view )
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
      
      f_22020341_localAlloc( "CYYY0131_PARENT_UPDATE" );
      if ( Globdata.GetErrorData().GetLastStatus() == ErrorData.LastStatusIefAllocationError )
      	return;
      
      ++(NestingLevel);
      try {
        f_22020341_init(  );
        f_22020341(  );
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
    public void f_22020341(  )
    {
      func_0022020341_esc_flag = false;
      Globdata.GetStateData().SetCurrentABId( "0022020341" );
      Globdata.GetStateData().SetCurrentABName( "CYYY0131_PARENT_UPDATE" );
      {
        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        //    See the description for the purpose.                            
        //                                                                    
        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        //    RELEASE HISTORY                                                 
        //    01_00 23-02-1998 New release                                    
        //                                                                    
        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        Globdata.GetStateData().SetLastStatementNumber( "0000000003" );
        
        Cyyy9001Oa = (GEN.ORT.YYY.CYYY9001_OA)(IefRuntimeParm2.GetInstance( typeof(GEN.ORT.YYY.CYYY9001).Assembly,
        	"GEN.ORT.YYY.CYYY9001_OA" ));
        Globdata.GetErrorData().SetErrorEncountered( ErrorData.ErrorEncounteredNoErrorFound );
        IefRuntimeParm2.UseActionBlock( typeof(GEN.ORT.YYY.CYYY9001).Assembly,
        	"GEN.ORT.YYY.CYYY9001",
        	"Execute",
        	null,
        	Cyyy9001Oa );
        if ( ((Globdata.GetErrorData().GetStatus() != ErrorData.StatusNone) || (Globdata.GetErrorData().GetErrorEncountered() != 
          ErrorData.ErrorEncounteredNoErrorFound)) || (Globdata.GetErrorData().GetViewOverflow() != 
          ErrorData.ErrorEncounteredNoErrorFound) )
        {
          throw new ABException();
        }
        Globdata.GetStateData().SetCurrentABId( "0022020341" );
        Globdata.GetStateData().SetCurrentABName( "CYYY0131_PARENT_UPDATE" );
        Globdata.GetStateData().SetLastStatementNumber( "0000000003" );
        WOa.ExpErrorIyy1ComponentSeverityCode = FixedStringAttr.ValueOf(Cyyy9001Oa.ExpErrorIyy1ComponentSeverityCode, 1);
        WOa.ExpErrorIyy1ComponentRollbackIndicator = FixedStringAttr.ValueOf(Cyyy9001Oa.ExpErrorIyy1ComponentRollbackIndicator, 1);
        WOa.ExpErrorIyy1ComponentOriginServid = DoubleAttr.ValueOf(Cyyy9001Oa.ExpErrorIyy1ComponentOriginServid);
        WOa.ExpErrorIyy1ComponentContextString = StringAttr.ValueOf(Cyyy9001Oa.ExpErrorIyy1ComponentContextString, 512);
        WOa.ExpErrorIyy1ComponentReturnCode = IntAttr.ValueOf(Cyyy9001Oa.ExpErrorIyy1ComponentReturnCode);
        WOa.ExpErrorIyy1ComponentReasonCode = IntAttr.ValueOf(Cyyy9001Oa.ExpErrorIyy1ComponentReasonCode);
        WOa.ExpErrorIyy1ComponentChecksum = FixedStringAttr.ValueOf(Cyyy9001Oa.ExpErrorIyy1ComponentChecksum, 15);
        Cyyy9001Oa.FreeInstance(  );
        Cyyy9001Oa = null;
        
        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        //    !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!                      
        //    Name the method below                                           
        //                                                                    
        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        Globdata.GetStateData().SetLastStatementNumber( "0000000006" );
        LocGroupContext_PS_001 = (int)TIRD2DEC.Execute1(1, 0, TIRD2DEC.ROUND_NONE, 0);
        if ( (LocGroupContext_PS_001 > WLa.LocGroupContext_MA) && (LocGroupContext_PS_001 <= 9) )
        WLa.LocGroupContext_MA = IntAttr.ValueOf(LocGroupContext_PS_001);
        Globdata.GetStateData().SetLastStatementNumber( "0000000007" );
        WLa.LocGContextDontChangeTextText150[LocGroupContext_PS_001-1] = FixedStringAttr.ValueOf("CYYY0131", 150);
        f_173015048_rgvc(  );
        Globdata.GetStateData().SetLastStatementNumber( "0000000008" );
        LocGroupContext_PS_001 = (int)TIRD2DEC.Execute1(2, 0, TIRD2DEC.ROUND_NONE, 0);
        if ( (LocGroupContext_PS_001 > WLa.LocGroupContext_MA) && (LocGroupContext_PS_001 <= 9) )
        WLa.LocGroupContext_MA = IntAttr.ValueOf(LocGroupContext_PS_001);
        Globdata.GetStateData().SetLastStatementNumber( "0000000009" );
        WLa.LocGContextDontChangeTextText150[LocGroupContext_PS_001-1] = FixedStringAttr.ValueOf("UPDATE", 150);
        f_173015048_rgvc(  );
        
        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        //    **************************************************************  
        //    **                                                              
        //    The used ReturnCode/ReasonCode values                           
        //                                                                    
        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        //    !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!  
        //    !!                                                              
        //    Set the return and reason codes below                           
        //                                                                    
        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        Globdata.GetStateData().SetLastStatementNumber( "0000000013" );
        WLa.LocDontChangeReturnCodesQ1Ok = IntAttr.ValueOf((int)TIRD2DEC.Execute1(1, 0, TIRD2DEC.ROUND_NONE, 5));
        Globdata.GetStateData().SetLastStatementNumber( "0000000014" );
        WLa.LocDontChangeReturnCodesN20MandatoryImportMissing = IntAttr.ValueOf((int)TIRD2DEC.Execute1(-20, 0, TIRD2DEC.ROUND_NONE, 
          5));
        
        Globdata.GetStateData().SetLastStatementNumber( "0000000016" );
        WLa.LocDontChangeReasonCodesQ1Default = IntAttr.ValueOf((int)TIRD2DEC.Execute1(1, 0, TIRD2DEC.ROUND_NONE, 5));
        Globdata.GetStateData().SetLastStatementNumber( "0000000017" );
        WLa.LocDontChangeReasonCodesQ104ParentTypeKeyAttrMand = IntAttr.ValueOf((int)TIRD2DEC.Execute1(104, 0, TIRD2DEC.ROUND_NONE, 
          5));
        Globdata.GetStateData().SetLastStatementNumber( "0000000018" );
        WLa.LocDontChangeReasonCodesQ105ParentKeyAttrMand = IntAttr.ValueOf((int)TIRD2DEC.Execute1(105, 0, TIRD2DEC.ROUND_NONE, 5));
        Globdata.GetStateData().SetLastStatementNumber( "0000000019" );
        WLa.LocDontChangeReasonCodesQ106ParentSearchAttrMand = IntAttr.ValueOf((int)TIRD2DEC.Execute1(106, 0, TIRD2DEC.ROUND_NONE, 5)
          );
        
        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        //    **************************************************************  
        //    **                                                              
        //                                                                    
        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        Globdata.GetStateData().SetLastStatementNumber( "0000000022" );
        WLa.LocImpParentPinstanceId = TimestampAttr.ValueOf(WIa.ImpParentPinstanceId);
        WLa.LocImpParentPreferenceId = TimestampAttr.ValueOf(WIa.ImpParentPreferenceId);
        WLa.LocImpParentPkeyAttrText = FixedStringAttr.ValueOf(WIa.ImpParentPkeyAttrText, 5);
        WLa.LocImpParentPsearchAttrText = FixedStringAttr.ValueOf(WIa.ImpParentPsearchAttrText, 25);
        WLa.LocImpParentPotherAttrText = FixedStringAttr.ValueOf(WIa.ImpParentPotherAttrText, 25);
        WLa.LocImpParentPtypeTkeyAttrText = FixedStringAttr.ValueOf(WIa.ImpParentPtypeTkeyAttrText, 4);
        
        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        //    **************************************************************  
        //    **                                                              
        //    Mandatory or optional only the needed fields for the            
        //    operation are checked.                                          
        //                                                                    
        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        Globdata.GetStateData().SetLastStatementNumber( "0000000025" );
        if ( ((double) WOa.ExpErrorIyy1ComponentReturnCode >= (double) WLa.LocDontChangeReturnCodesQ1Ok) )
        {
          f_20972544(  );
        }
        
        
        Globdata.GetStateData().SetLastStatementNumber( "0000000036" );
        if ( ((double) WOa.ExpErrorIyy1ComponentReturnCode >= (double) WLa.LocDontChangeReturnCodesQ1Ok) )
        {
          f_20972237(  );
        }
        
        if ( func_0022020341_esc_flag )
        {
          goto f_0022020341_esctag;
        }
        
        Globdata.GetStateData().SetLastStatementNumber( "0000000043" );
        if ( ((double) WOa.ExpErrorIyy1ComponentReturnCode < (double) WLa.LocDontChangeReturnCodesQ1Ok) )
        {
          f_20972334(  );
        }
        
      }
      f_0022020341_esctag: 
      ;
      return;
    }
    
    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // SUBORDINATE FUNCTIONS
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    
    
    public void f_20972544(  )
    {
      func_0020972544_esc_flag = false;
      Globdata.GetStateData().SetLastStatementNumber( "0000000026" );
      if ( CompareExit.CompareTo(WLa.LocImpParentPkeyAttrText, WLa.LocEmptyParentPkeyAttrText) <= 0 )
      {
        Globdata.GetStateData().SetLastStatementNumber( "0000000027" );
        WOa.ExpErrorIyy1ComponentReturnCode = IntAttr.ValueOf((int)TIRD2DEC.Execute1((double) 
          WLa.LocDontChangeReturnCodesN20MandatoryImportMissing, 0, TIRD2DEC.ROUND_NONE, 5));
        Globdata.GetStateData().SetLastStatementNumber( "0000000028" );
        WOa.ExpErrorIyy1ComponentReasonCode = IntAttr.ValueOf((int)TIRD2DEC.Execute1((double) 
          WLa.LocDontChangeReasonCodesQ104ParentTypeKeyAttrMand, 0, TIRD2DEC.ROUND_NONE, 5));
      }
      
      Globdata.GetStateData().SetLastStatementNumber( "0000000029" );
      if ( CompareExit.CompareTo(WLa.LocImpParentPsearchAttrText, WLa.LocEmptyParentPsearchAttrText) <= 0 )
      {
        Globdata.GetStateData().SetLastStatementNumber( "0000000030" );
        WOa.ExpErrorIyy1ComponentReturnCode = IntAttr.ValueOf((int)TIRD2DEC.Execute1((double) 
          WLa.LocDontChangeReturnCodesN20MandatoryImportMissing, 0, TIRD2DEC.ROUND_NONE, 5));
        Globdata.GetStateData().SetLastStatementNumber( "0000000031" );
        WOa.ExpErrorIyy1ComponentReasonCode = IntAttr.ValueOf((int)TIRD2DEC.Execute1((double) 
          WLa.LocDontChangeReasonCodesQ105ParentKeyAttrMand, 0, TIRD2DEC.ROUND_NONE, 5));
      }
      
      Globdata.GetStateData().SetLastStatementNumber( "0000000032" );
      if ( CompareExit.CompareTo(WIa.ImpParentPtypeTkeyAttrText, WLa.LocEmptyParentPtypeTkeyAttrText) <= 0 )
      {
        Globdata.GetStateData().SetLastStatementNumber( "0000000033" );
        WOa.ExpErrorIyy1ComponentReturnCode = IntAttr.ValueOf((int)TIRD2DEC.Execute1((double) 
          WLa.LocDontChangeReturnCodesN20MandatoryImportMissing, 0, TIRD2DEC.ROUND_NONE, 5));
        Globdata.GetStateData().SetLastStatementNumber( "0000000034" );
        WOa.ExpErrorIyy1ComponentReasonCode = IntAttr.ValueOf((int)TIRD2DEC.Execute1((double) 
          WLa.LocDontChangeReasonCodesQ106ParentSearchAttrMand, 0, TIRD2DEC.ROUND_NONE, 5));
      }
      
      return;
    }
    
    public void f_20972237(  )
    {
      func_0020972237_esc_flag = false;
      {
        Globdata.GetStateData().SetLastStatementNumber( "0000000037" );
        
        Dyyy0131Ia = (GEN.ORT.YYY.DYYY0131_IA)(IefRuntimeParm2.GetInstance( typeof(GEN.ORT.YYY.DYYY0131).Assembly,
        	"GEN.ORT.YYY.DYYY0131_IA" ));
        Dyyy0131Oa = (GEN.ORT.YYY.DYYY0131_OA)(IefRuntimeParm2.GetInstance( typeof(GEN.ORT.YYY.DYYY0131).Assembly,
        	"GEN.ORT.YYY.DYYY0131_OA" ));
        Dyyy0131Ia.ImpParentPinstanceId = TimestampAttr.ValueOf(WLa.LocImpParentPinstanceId);
        Dyyy0131Ia.ImpParentPreferenceId = TimestampAttr.ValueOf(WLa.LocImpParentPreferenceId);
        Dyyy0131Ia.ImpParentPkeyAttrText = FixedStringAttr.ValueOf(WLa.LocImpParentPkeyAttrText, 5);
        Dyyy0131Ia.ImpParentPsearchAttrText = FixedStringAttr.ValueOf(WLa.LocImpParentPsearchAttrText, 25);
        Dyyy0131Ia.ImpParentPotherAttrText = FixedStringAttr.ValueOf(WLa.LocImpParentPotherAttrText, 25);
        Dyyy0131Ia.ImpParentPtypeTkeyAttrText = FixedStringAttr.ValueOf(WLa.LocImpParentPtypeTkeyAttrText, 4);
        Dyyy0131Ia.ImpReferenceIyy1ServerDataUserid = FixedStringAttr.ValueOf(WIa.ImpReferenceIyy1ServerDataUserid, 8);
        Dyyy0131Ia.ImpReferenceIyy1ServerDataReferenceId = TimestampAttr.ValueOf(WIa.ImpReferenceIyy1ServerDataReferenceId);
        Dyyy0131Ia.ImpErrorIyy1ComponentSeverityCode = FixedStringAttr.ValueOf(WOa.ExpErrorIyy1ComponentSeverityCode, 1);
        Dyyy0131Ia.ImpErrorIyy1ComponentRollbackIndicator = FixedStringAttr.ValueOf(WOa.ExpErrorIyy1ComponentRollbackIndicator, 1);
        Dyyy0131Ia.ImpErrorIyy1ComponentOriginServid = DoubleAttr.ValueOf(WOa.ExpErrorIyy1ComponentOriginServid);
        Dyyy0131Ia.ImpErrorIyy1ComponentContextString = StringAttr.ValueOf(WOa.ExpErrorIyy1ComponentContextString, 512);
        Dyyy0131Ia.ImpErrorIyy1ComponentReturnCode = IntAttr.ValueOf(WOa.ExpErrorIyy1ComponentReturnCode);
        Dyyy0131Ia.ImpErrorIyy1ComponentReasonCode = IntAttr.ValueOf(WOa.ExpErrorIyy1ComponentReasonCode);
        Dyyy0131Ia.ImpErrorIyy1ComponentChecksum = FixedStringAttr.ValueOf(WOa.ExpErrorIyy1ComponentChecksum, 15);
        Globdata.GetErrorData().SetErrorEncountered( ErrorData.ErrorEncounteredNoErrorFound );
        IefRuntimeParm2.UseActionBlock( typeof(GEN.ORT.YYY.DYYY0131).Assembly,
        	"GEN.ORT.YYY.DYYY0131",
        	"Execute",
        	Dyyy0131Ia,
        	Dyyy0131Oa );
        if ( ((Globdata.GetErrorData().GetStatus() != ErrorData.StatusNone) || (Globdata.GetErrorData().GetErrorEncountered() != 
          ErrorData.ErrorEncounteredNoErrorFound)) || (Globdata.GetErrorData().GetViewOverflow() != 
          ErrorData.ErrorEncounteredNoErrorFound) )
        {
          throw new ABException();
        }
        Globdata.GetStateData().SetCurrentABId( "0022020341" );
        Globdata.GetStateData().SetCurrentABName( "CYYY0131_PARENT_UPDATE" );
        Globdata.GetStateData().SetLastStatementNumber( "0000000037" );
        WLa.LocErrorIyy1ComponentSeverityCode = FixedStringAttr.ValueOf(Dyyy0131Oa.ExpErrorIyy1ComponentSeverityCode, 1);
        WLa.LocErrorIyy1ComponentRollbackIndicator = FixedStringAttr.ValueOf(Dyyy0131Oa.ExpErrorIyy1ComponentRollbackIndicator, 1);
        WLa.LocErrorIyy1ComponentOriginServid = DoubleAttr.ValueOf(Dyyy0131Oa.ExpErrorIyy1ComponentOriginServid);
        WLa.LocErrorIyy1ComponentContextString = StringAttr.ValueOf(Dyyy0131Oa.ExpErrorIyy1ComponentContextString, 512);
        WLa.LocErrorIyy1ComponentReturnCode = IntAttr.ValueOf(Dyyy0131Oa.ExpErrorIyy1ComponentReturnCode);
        WLa.LocErrorIyy1ComponentReasonCode = IntAttr.ValueOf(Dyyy0131Oa.ExpErrorIyy1ComponentReasonCode);
        WLa.LocErrorIyy1ComponentChecksum = FixedStringAttr.ValueOf(Dyyy0131Oa.ExpErrorIyy1ComponentChecksum, 15);
        WOa.ExpParentPreferenceId = TimestampAttr.ValueOf(Dyyy0131Oa.ExpParentPreferenceId);
        Dyyy0131Ia.FreeInstance(  );
        Dyyy0131Ia = null;
        Dyyy0131Oa.FreeInstance(  );
        Dyyy0131Oa = null;
        Globdata.GetStateData().SetLastStatementNumber( "0000000038" );
        if ( ((double) WLa.LocErrorIyy1ComponentReturnCode < (double) WLa.LocDontChangeReturnCodesQ1Ok) )
        {
          f_20972317(  );
        }
        
      }
      f_0020972237_esctag: 
      ;
      return;
    }
    
    public void f_20972334(  )
    {
      func_0020972334_esc_flag = false;
      Globdata.GetStateData().SetLastStatementNumber( "0000000044" );
      
      Cyyy9141Ia = (GEN.ORT.YYY.CYYY9141_IA)(IefRuntimeParm2.GetInstance( typeof(GEN.ORT.YYY.CYYY9141).Assembly,
      	"GEN.ORT.YYY.CYYY9141_IA" ));
      Cyyy9141Oa = (GEN.ORT.YYY.CYYY9141_OA)(IefRuntimeParm2.GetInstance( typeof(GEN.ORT.YYY.CYYY9141).Assembly,
      	"GEN.ORT.YYY.CYYY9141_OA" ));
      Cyyy9141Ia.ImpGroupContext_MA = IntAttr.ValueOf(WLa.LocGroupContext_MA);
      for(Adim1 = 1; Adim1 <= WLa.LocGroupContext_MA; ++(Adim1))
      {
        Cyyy9141Ia.ImpGContextDontChangeTextText150[Adim1-1] = FixedStringAttr.ValueOf(WLa.LocGContextDontChangeTextText150[Adim1-1],
           150);
      }
      for(Adim1 = WLa.LocGroupContext_MA + 1; Adim1 <= 9; ++(Adim1))
      {
        Cyyy9141Ia.ImpGContextDontChangeTextText150[Adim1-1] = 
"                                                                                                                                                      "
          ;
      }
      Globdata.GetErrorData().SetErrorEncountered( ErrorData.ErrorEncounteredNoErrorFound );
      IefRuntimeParm2.UseActionBlock( typeof(GEN.ORT.YYY.CYYY9141).Assembly,
      	"GEN.ORT.YYY.CYYY9141",
      	"Execute",
      	Cyyy9141Ia,
      	Cyyy9141Oa );
      if ( ((Globdata.GetErrorData().GetStatus() != ErrorData.StatusNone) || (Globdata.GetErrorData().GetErrorEncountered() != 
        ErrorData.ErrorEncounteredNoErrorFound)) || (Globdata.GetErrorData().GetViewOverflow() != 
        ErrorData.ErrorEncounteredNoErrorFound) )
      {
        throw new ABException();
      }
      Globdata.GetStateData().SetCurrentABId( "0022020341" );
      Globdata.GetStateData().SetCurrentABName( "CYYY0131_PARENT_UPDATE" );
      Globdata.GetStateData().SetLastStatementNumber( "0000000044" );
      WOa.ExpErrorIyy1ComponentContextString = StringAttr.ValueOf(Cyyy9141Oa.ExpContextIyy1ComponentContextString, 512);
      WLa.LocErrorIyy1ComponentSeverityCode = FixedStringAttr.ValueOf(Cyyy9141Oa.ExpErrorIyy1ComponentSeverityCode, 1);
      WLa.LocErrorIyy1ComponentRollbackIndicator = FixedStringAttr.ValueOf(Cyyy9141Oa.ExpErrorIyy1ComponentRollbackIndicator, 1);
      WLa.LocErrorIyy1ComponentOriginServid = DoubleAttr.ValueOf(Cyyy9141Oa.ExpErrorIyy1ComponentOriginServid);
      WLa.LocErrorIyy1ComponentContextString = StringAttr.ValueOf(Cyyy9141Oa.ExpErrorIyy1ComponentContextString, 512);
      WLa.LocErrorIyy1ComponentReturnCode = IntAttr.ValueOf(Cyyy9141Oa.ExpErrorIyy1ComponentReturnCode);
      WLa.LocErrorIyy1ComponentReasonCode = IntAttr.ValueOf(Cyyy9141Oa.ExpErrorIyy1ComponentReasonCode);
      WLa.LocErrorIyy1ComponentChecksum = FixedStringAttr.ValueOf(Cyyy9141Oa.ExpErrorIyy1ComponentChecksum, 15);
      Cyyy9141Ia.FreeInstance(  );
      Cyyy9141Ia = null;
      Cyyy9141Oa.FreeInstance(  );
      Cyyy9141Oa = null;
      
      Globdata.GetStateData().SetLastStatementNumber( "0000000046" );
      if ( ((double) WLa.LocErrorIyy1ComponentReturnCode < (double) WLa.LocDontChangeReturnCodesQ1Ok) )
      {
        Globdata.GetStateData().SetLastStatementNumber( "0000000047" );
        WOa.ExpErrorIyy1ComponentSeverityCode = FixedStringAttr.ValueOf(WLa.LocErrorIyy1ComponentSeverityCode, 1);
        WOa.ExpErrorIyy1ComponentRollbackIndicator = FixedStringAttr.ValueOf(WLa.LocErrorIyy1ComponentRollbackIndicator, 1);
        WOa.ExpErrorIyy1ComponentOriginServid = DoubleAttr.ValueOf(WLa.LocErrorIyy1ComponentOriginServid);
        WOa.ExpErrorIyy1ComponentContextString = StringAttr.ValueOf(WLa.LocErrorIyy1ComponentContextString, 512);
        WOa.ExpErrorIyy1ComponentReturnCode = IntAttr.ValueOf(WLa.LocErrorIyy1ComponentReturnCode);
        WOa.ExpErrorIyy1ComponentReasonCode = IntAttr.ValueOf(WLa.LocErrorIyy1ComponentReasonCode);
        WOa.ExpErrorIyy1ComponentChecksum = FixedStringAttr.ValueOf(WLa.LocErrorIyy1ComponentChecksum, 15);
      }
      
      Globdata.GetStateData().SetLastStatementNumber( "0000000048" );
      WOa.ExpErrorIyy1ComponentSeverityCode = FixedStringAttr.ValueOf("E", 1);
      return;
    }
    
    public void f_20972317(  )
    {
      func_0020972317_esc_flag = false;
      {
        Globdata.GetStateData().SetLastStatementNumber( "0000000039" );
        WOa.ExpErrorIyy1ComponentSeverityCode = FixedStringAttr.ValueOf(WLa.LocErrorIyy1ComponentSeverityCode, 1);
        WOa.ExpErrorIyy1ComponentRollbackIndicator = FixedStringAttr.ValueOf(WLa.LocErrorIyy1ComponentRollbackIndicator, 1);
        WOa.ExpErrorIyy1ComponentOriginServid = DoubleAttr.ValueOf(WLa.LocErrorIyy1ComponentOriginServid);
        WOa.ExpErrorIyy1ComponentContextString = StringAttr.ValueOf(WLa.LocErrorIyy1ComponentContextString, 512);
        WOa.ExpErrorIyy1ComponentReturnCode = IntAttr.ValueOf(WLa.LocErrorIyy1ComponentReturnCode);
        WOa.ExpErrorIyy1ComponentReasonCode = IntAttr.ValueOf(WLa.LocErrorIyy1ComponentReasonCode);
        WOa.ExpErrorIyy1ComponentChecksum = FixedStringAttr.ValueOf(WLa.LocErrorIyy1ComponentChecksum, 15);
        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        //    !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!  
        //    !!!!!!!!!!!                                                     
        //    !! WARNING: In D AB, if there' s a need for generating          
        //    context string, must exit from ESCAPE AB.                       
        //                                                                    
        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        Globdata.GetStateData().SetLastStatementNumber( "0000000041" );
        func_0020972317_esc_flag = true;
        func_0020972237_esc_flag = true;
      }
      f_0020972317_esctag: 
      ;
      return;
    }
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // INITIALIZATION UTILITY FUNCTIONS 
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    
    public void f_22020341_localAlloc( String abname )
    {
      // Request localview allocation 
      WLa = (GEN.ORT.YYY.CYYY0131_LA)(IefRuntimeParm2.GetInstance( GetType().Assembly,
      	"GEN.ORT.YYY.CYYY0131_LA" ));
      if ( WLa == null )
      {
        Globdata.GetStateData().SetCurrentABId( "0022020341" );
        Globdata.GetStateData().SetCurrentABName( abname );
        Globdata.GetErrorData().SetErrorEncountered( ErrorData.ErrorEncounteredErrorFound );
        Globdata.GetErrorData().SetLastStatus( ErrorData.LastStatusIefAllocationError );
      }
    }
    
    public void f_22020341_init(  )
    {
      if ( NestingLevel < 2 )
      {
        WLa.Reset();
      }
      WLa.LocGroupContext_MA = 0;
      for(LocGroupContext_PS_001 = 1; LocGroupContext_PS_001 <= 9; ++(LocGroupContext_PS_001))
      {
      }
      WOa.ExpParentPreferenceId = "00000000000000000000";
      WOa.ExpErrorIyy1ComponentSeverityCode = " ";
      WOa.ExpErrorIyy1ComponentRollbackIndicator = " ";
      WOa.ExpErrorIyy1ComponentOriginServid = 0.0;
      WOa.ExpErrorIyy1ComponentContextString = "";
      WOa.ExpErrorIyy1ComponentReturnCode = 0;
      WOa.ExpErrorIyy1ComponentReasonCode = 0;
      WOa.ExpErrorIyy1ComponentChecksum = "               ";
      LocGroupContext_PS_001 = 1;
    }
    public void f_173015048_rgvc(  )
    {
      if ( (LocGroupContext_PS_001 > 9) || (LocGroupContext_PS_001 < 1) )
      {
        Globdata.GetErrorData().SetViewOverflow( ErrorData.ErrorEncounteredErrorFound );
        {
          throw new ABException();
        }
      }
    }
  }// end class
  
}

