namespace GEN.ORT.YYY
{
  // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
  //
  //                    Source Code Generated by
  //                           CA Gen 8.6
  //
  //    Copyright (c) 2024 CA Technologies. All rights reserved.
  //
  //    Name: CYYY0421_XML_PARSE               Date: 2024/01/09
  //    Target OS:   CLR                       Time: 13:41:25
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
  
  public class CYYY0421 : ABBase
  {
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // IMPORT VIEW CLASS VARIABLE
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    CYYY0421_IA WIa;
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // EXPORT VIEW CLASS VARIABLE
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    CYYY0421_OA WOa;
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // LOCAL VIEW CLASS VARIABLE
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    CYYY0421_LA WLa;
    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // ACTION BLOCK IMPORT/EXPORT VIEWS CLASS VARIABLES
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    GEN.ORT.YYY.EYYY0421_IA Eyyy0421Ia;
    GEN.ORT.YYY.EYYY0421_OA Eyyy0421Oa;
    GEN.ORT.YYY.CYYY9141_IA Cyyy9141Ia;
    GEN.ORT.YYY.CYYY9141_OA Cyyy9141Oa;
    GEN.ORT.YYY.CYYY9001_OA Cyyy9001Oa;
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
    bool func_0022020271_esc_flag;
    bool func_0020972101_esc_flag;
    bool func_0020972016_esc_flag;
    //       +->   CYYY0421_XML_PARSE                01/09/2024  13:41
    //       !       IMPORTS:
    //       !         Work View imp canam_xml (Transient, Optional, Import
    //       !                     only)
    //       !           xml_buffer
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
    //       !         Work View exp_error canam_xml (Transient, Export only)
    //       !           xml_return_code
    //       !           xml_message
    //       !           xml_position
    //       !           xml_source
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
    //       !         Work View loc dont_change_return_codes
    //       !           1_ok
    //       !           n70_xml_error
    //       !         Work View loc dont_change_reason_codes
    //       !           1_default
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
    //       !
    //       !     PROCEDURE STATEMENTS
    //       !
    //     1 !  NOTE: 
    //     1 !  Check description for porpose
    //     1 !  
    //     2 !  NOTE: 
    //     2 !  RELEASE HISTORY
    //     2 !  01_00 01-10-2009 New Release
    //     2 !  
    //     3 !  USE cyyy9001_exception_hndlng_dflt
    //     3 !     WHICH EXPORTS: Work View exp_error iyy1_component FROM Work
    //     3 !              View exp_error iyy1_component
    //     4 !   
    //     5 !  NOTE: 
    //     5 !  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //     5 !  Change Action Block Name
    //     5 !  
    //     6 !  SET SUBSCRIPT OF loc_group_context TO 1 
    //     7 !  SET loc_g_context dont_change_text text_150 TO "CYYY0421" 
    //     8 !  SET SUBSCRIPT OF loc_group_context TO 2 
    //     9 !  SET loc_g_context dont_change_text text_150 TO "XML CREATE" 
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
    //    14 !  SET loc dont_change_return_codes n70_xml_error TO -70 
    //    15 !   
    //    16 !  SET loc dont_change_reason_codes 1_default TO 1 
    //    17 !  +->IF exp_error iyy1_component return_code >= loc
    //    17 !  !        dont_change_return_codes 1_ok
    //    18 !  !  USE eyyy0421_xml_parse
    //    18 !  !     WHICH IMPORTS: Work View imp canam_xml TO Work View imp
    //    18 !  !              canam_xml
    //    18 !  !     WHICH EXPORTS: Entity View exp type FROM Entity View exp
    //    18 !  !              type
    //    18 !  !                    Work View exp_error canam_xml FROM Work
    //    18 !  !              View exp_error canam_xml
    //    19 !  !   
    //    20 !  !  +->CASE OF exp_error canam_xml xml_return_code
    //    20 !  !  +> CASE "OK"
    //    21 !  !  !  NOTE: 
    //    21 ...**************************************************************
    //    21 ...**
    //    21 ...OK
    //    21 ... Successful.
    //    22 !  !  !  SET exp_error iyy1_component return_code TO loc
    //    22 !  !  !              dont_change_return_codes 1_ok 
    //    23 !  !  !  SET exp_error iyy1_component reason_code TO loc
    //    23 !  !  !              dont_change_reason_codes 1_default 
    //    20 !  !  +> OTHERWISE
    //    24 !  !  !  SET exp_error iyy1_component return_code TO loc
    //    24 !  !  !              dont_change_return_codes n70_xml_error 
    //    25 !  !  !  SET exp_error iyy1_component reason_code TO loc
    //    25 !  !  !              dont_change_reason_codes 1_default 
    //    26 !  !  !  NOTE: 
    //    26 ...Check exp_error canam_xml for error details..
    //    26 ...       Work View   exp_error canam_xml (transient,export
    //    26 ...only)
    //    26 ...         xml_return_code 
    //    26 ...         xml_message 
    //    26 ...         xml_position 
    //    26 ...         xml_source 
    //    26 ...
    //    26 ...CASE OF  xml_return_code:
    //    26 ...EB
    //    26 ... End of buffer. Occurs during parsing when end of buffer is
    //    26 ...encountered while more data was expected. For the writer, it
    //    26 ...means that buffer is exhausted while more data was needed to
    //    26 ...be written out.
    //    26 ... 
    //    26 ...IC
    //    26 ... Invalid character. Occurs when a character is encountered in
    //    26 ...the stream that was not expected. Such as, a missing “=”
    //    26 ...after attribute name.
    //    26 ... 
    //    26 ...MN
    //    26 ... Missing node. Occurs when a mandatory element or attribute
    //    26 ...is missing.
    //    26 ... 
    //    26 ...UN
    //    26 ... Unknown node. Occurs when a foreign (unknown) node has been
    //    26 ...encountered within a ‘non-extensible’ element context
    //    26 ... 
    //    26 ...DA
    //    26 ... Duplicate attribute. Occurs during parsing when an XML
    //    26 ...element has two attributes with the same name.
    //    26 ... 
    //    26 ...PE
    //    26 ... Pattern error. The node text does not have the pattern
    //    26 ...specified during design, such as date/time patterns.
    //    26 ... 
    //    26 ...OV
    //    26 ... Numeric overflow error. This can happen when the integer
    //    26 ...part of the number is truncated after parsing.
    //    26 ... 
    //    26 ...MD
    //    26 ... More data warning. This is a warning message that means
    //    26 ...there is more data in XML document than the IDS (Interface
    //    26 ...Data Structure) can hold.
    //    26 ... 
    //    26 ...BP
    //    26 ... XML PARSE statement error.
    //    26 ... 
    //    26 ...ER
    //    26 ... Unknown error. Occurs when operation could not be completed
    //    26 ...for any other reason.
    //    26 ... 
    //    20 !  !  +--
    //    17 !  +--
    //    27 !  +->IF exp_error iyy1_component return_code < loc
    //    27 !  !        dont_change_return_codes 1_ok
    //    28 !  !  USE cyyy9141_context_string_set
    //    28 !  !     WHICH IMPORTS: Group View  loc_group_context TO Group
    //    28 !  !              View imp_group_context
    //    28 !  !     WHICH EXPORTS: Work View loc_error iyy1_component FROM
    //    28 !  !              Work View exp_error iyy1_component
    //    28 !  !                    Work View exp_error iyy1_component FROM
    //    28 !  !              Work View exp_context iyy1_component
    //    29 !  !   
    //    30 !  !  +->IF loc_error iyy1_component return_code < loc
    //    30 !  !  !        dont_change_return_codes 1_ok
    //    31 !  !  !  MOVE loc_error iyy1_component TO exp_error
    //    31 !  !  !              iyy1_component
    //    30 !  !  +--
    //    32 !  !  SET exp_error iyy1_component severity_code TO "E" 
    //    27 !  +--
    //       +---
    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    //  CONSTRUCTOR FOR THE CLASS       
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    public CYYY0421(  )
    {
      IefCGenRlse = "CA Gen 8.6";
      IsCopyright = "Copyright (c) 2024 CA Technologies. All rights reserved.";
      IefCGenDate = "2024/01/09";
      IefCGenTime = "13:41:25";
      IefCGenEncy = "9.2.A6";
      IefCGenUserId = "AliAl";
      IefCGenModel = "N8I_ORT_YYY_0112_TEMPLATE";
      IefCGenSubset = "ALL";
      IefCGenName = "CYYY0421_XML_PARSE";
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
    	CYYY0421_IA import_view, 
    	CYYY0421_OA export_view )
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
      
      f_22020271_localAlloc( "CYYY0421_XML_PARSE" );
      if ( Globdata.GetErrorData().GetLastStatus() == ErrorData.LastStatusIefAllocationError )
      	return;
      
      ++(NestingLevel);
      try {
        f_22020271_init(  );
        f_22020271(  );
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
    public void f_22020271(  )
    {
      func_0022020271_esc_flag = false;
      Globdata.GetStateData().SetCurrentABId( "0022020271" );
      Globdata.GetStateData().SetCurrentABName( "CYYY0421_XML_PARSE" );
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      //    Check description for porpose                                   
      //                                                                    
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      //    RELEASE HISTORY                                                 
      //    01_00 01-10-2009 New Release                                    
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
      Globdata.GetStateData().SetCurrentABId( "0022020271" );
      Globdata.GetStateData().SetCurrentABName( "CYYY0421_XML_PARSE" );
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
      //    Change Action Block Name                                        
      //                                                                    
      // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
      Globdata.GetStateData().SetLastStatementNumber( "0000000006" );
      LocGroupContext_PS_001 = (int)TIRD2DEC.Execute1(1, 0, TIRD2DEC.ROUND_NONE, 0);
      if ( (LocGroupContext_PS_001 > WLa.LocGroupContext_MA) && (LocGroupContext_PS_001 <= 9) )
      WLa.LocGroupContext_MA = IntAttr.ValueOf(LocGroupContext_PS_001);
      Globdata.GetStateData().SetLastStatementNumber( "0000000007" );
      WLa.LocGContextDontChangeTextText150[LocGroupContext_PS_001-1] = FixedStringAttr.ValueOf("CYYY0421", 150);
      f_173015093_rgvc(  );
      Globdata.GetStateData().SetLastStatementNumber( "0000000008" );
      LocGroupContext_PS_001 = (int)TIRD2DEC.Execute1(2, 0, TIRD2DEC.ROUND_NONE, 0);
      if ( (LocGroupContext_PS_001 > WLa.LocGroupContext_MA) && (LocGroupContext_PS_001 <= 9) )
      WLa.LocGroupContext_MA = IntAttr.ValueOf(LocGroupContext_PS_001);
      Globdata.GetStateData().SetLastStatementNumber( "0000000009" );
      WLa.LocGContextDontChangeTextText150[LocGroupContext_PS_001-1] = FixedStringAttr.ValueOf("XML CREATE", 150);
      f_173015093_rgvc(  );
      
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
      WLa.LocDontChangeReturnCodesN70XmlError = IntAttr.ValueOf((int)TIRD2DEC.Execute1(-70, 0, TIRD2DEC.ROUND_NONE, 5));
      
      Globdata.GetStateData().SetLastStatementNumber( "0000000016" );
      WLa.LocDontChangeReasonCodesQ1Default = IntAttr.ValueOf((int)TIRD2DEC.Execute1(1, 0, TIRD2DEC.ROUND_NONE, 5));
      Globdata.GetStateData().SetLastStatementNumber( "0000000017" );
      if ( ((double) WOa.ExpErrorIyy1ComponentReturnCode >= (double) WLa.LocDontChangeReturnCodesQ1Ok) )
      {
        f_20972101(  );
      }
      
      Globdata.GetStateData().SetLastStatementNumber( "0000000027" );
      if ( ((double) WOa.ExpErrorIyy1ComponentReturnCode < (double) WLa.LocDontChangeReturnCodesQ1Ok) )
      {
        f_20972016(  );
      }
      
      return;
    }
    
    
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // SUBORDINATE FUNCTIONS
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    
    
    public void f_20972101(  )
    {
      func_0020972101_esc_flag = false;
      Globdata.GetStateData().SetLastStatementNumber( "0000000018" );
      
      Eyyy0421Ia = (GEN.ORT.YYY.EYYY0421_IA)(IefRuntimeParm2.GetInstance( typeof(GEN.ORT.YYY.EYYY0421).Assembly,
      	"GEN.ORT.YYY.EYYY0421_IA" ));
      Eyyy0421Oa = (GEN.ORT.YYY.EYYY0421_OA)(IefRuntimeParm2.GetInstance( typeof(GEN.ORT.YYY.EYYY0421).Assembly,
      	"GEN.ORT.YYY.EYYY0421_OA" ));
      Eyyy0421Ia.ImpCanamXmlXmlBuffer = StringAttr.ValueOf(WIa.ImpCanamXmlXmlBuffer, 4094);
      Globdata.GetErrorData().SetErrorEncountered( ErrorData.ErrorEncounteredNoErrorFound );
      IefRuntimeParm2.UseActionBlock( typeof(GEN.ORT.YYY.EYYY0421).Assembly,
      	"GEN.ORT.YYY.EYYY0421",
      	"Execute",
      	Eyyy0421Ia,
      	Eyyy0421Oa );
      if ( ((Globdata.GetErrorData().GetStatus() != ErrorData.StatusNone) || (Globdata.GetErrorData().GetErrorEncountered() != 
        ErrorData.ErrorEncounteredNoErrorFound)) || (Globdata.GetErrorData().GetViewOverflow() != 
        ErrorData.ErrorEncounteredNoErrorFound) )
      {
        throw new ABException();
      }
      Globdata.GetStateData().SetCurrentABId( "0022020271" );
      Globdata.GetStateData().SetCurrentABName( "CYYY0421_XML_PARSE" );
      Globdata.GetStateData().SetLastStatementNumber( "0000000018" );
      WOa.ExpErrorCanamXmlXmlReturnCode = FixedStringAttr.ValueOf(Eyyy0421Oa.ExpErrorCanamXmlXmlReturnCode, 2);
      WOa.ExpErrorCanamXmlXmlMessage = FixedStringAttr.ValueOf(Eyyy0421Oa.ExpErrorCanamXmlXmlMessage, 80);
      WOa.ExpErrorCanamXmlXmlPosition = DoubleAttr.ValueOf(Eyyy0421Oa.ExpErrorCanamXmlXmlPosition);
      WOa.ExpErrorCanamXmlXmlSource = FixedStringAttr.ValueOf(Eyyy0421Oa.ExpErrorCanamXmlXmlSource, 120);
      WOa.ExpTypeTinstanceId = TimestampAttr.ValueOf(Eyyy0421Oa.ExpTypeTinstanceId);
      WOa.ExpTypeTreferenceId = TimestampAttr.ValueOf(Eyyy0421Oa.ExpTypeTreferenceId);
      WOa.ExpTypeTcreateUserId = FixedStringAttr.ValueOf(Eyyy0421Oa.ExpTypeTcreateUserId, 8);
      WOa.ExpTypeTupdateUserId = FixedStringAttr.ValueOf(Eyyy0421Oa.ExpTypeTupdateUserId, 8);
      WOa.ExpTypeTkeyAttrText = FixedStringAttr.ValueOf(Eyyy0421Oa.ExpTypeTkeyAttrText, 4);
      WOa.ExpTypeTsearchAttrText = FixedStringAttr.ValueOf(Eyyy0421Oa.ExpTypeTsearchAttrText, 20);
      WOa.ExpTypeTotherAttrText = FixedStringAttr.ValueOf(Eyyy0421Oa.ExpTypeTotherAttrText, 2);
      WOa.ExpTypeTotherAttrDate = DateAttr.ValueOf(Eyyy0421Oa.ExpTypeTotherAttrDate);
      WOa.ExpTypeTotherAttrTime = TimeAttr.ValueOf(Eyyy0421Oa.ExpTypeTotherAttrTime);
      WOa.ExpTypeTotherAttrAmount = DecimalAttr.ValueOf(Eyyy0421Oa.ExpTypeTotherAttrAmount);
      Eyyy0421Ia.FreeInstance(  );
      Eyyy0421Ia = null;
      Eyyy0421Oa.FreeInstance(  );
      Eyyy0421Oa = null;
      
      Globdata.GetStateData().SetLastStatementNumber( "0000000020" );
      if ( CompareExit.CompareTo(WOa.ExpErrorCanamXmlXmlReturnCode, "OK") == 0 )
      {
        Globdata.GetStateData().SetLastSubStatementNumber( "1" );
        {
          // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
          //    **************************************************************  
          //    **                                                              
          //    OK                                                              
          //     Successful.                                                    
          // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
          Globdata.GetStateData().SetLastStatementNumber( "0000000022" );
          WOa.ExpErrorIyy1ComponentReturnCode = IntAttr.ValueOf((int)TIRD2DEC.Execute1((double) WLa.LocDontChangeReturnCodesQ1Ok, 0, 
            TIRD2DEC.ROUND_NONE, 5));
          Globdata.GetStateData().SetLastStatementNumber( "0000000023" );
          WOa.ExpErrorIyy1ComponentReasonCode = IntAttr.ValueOf((int)TIRD2DEC.Execute1((double) 
            WLa.LocDontChangeReasonCodesQ1Default, 0, TIRD2DEC.ROUND_NONE, 5));
        }
      }
      else {
        Globdata.GetStateData().SetLastSubStatementNumber( "2" );
        {
          Globdata.GetStateData().SetLastStatementNumber( "0000000024" );
          WOa.ExpErrorIyy1ComponentReturnCode = IntAttr.ValueOf((int)TIRD2DEC.Execute1((double) 
            WLa.LocDontChangeReturnCodesN70XmlError, 0, TIRD2DEC.ROUND_NONE, 5));
          Globdata.GetStateData().SetLastStatementNumber( "0000000025" );
          WOa.ExpErrorIyy1ComponentReasonCode = IntAttr.ValueOf((int)TIRD2DEC.Execute1((double) 
            WLa.LocDontChangeReasonCodesQ1Default, 0, TIRD2DEC.ROUND_NONE, 5));
          // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
          //    Check exp_error canam_xml for error details..                   
          //           Work View   exp_error canam_xml (transient,export        
          //    only)                                                           
          //             xml_return_code                                        
          //             xml_message                                            
          //             xml_position                                           
          //             xml_source                                             
          //                                                                    
          //    CASE OF  xml_return_code:                                       
          //    EB                                                              
          //     End of buffer. Occurs during parsing when end of buffer is     
          //    encountered while more data was expected. For the writer, it    
          //    means that buffer is exhausted while more data was needed to    
          //    be written out.                                                 
          //                                                                    
          //    IC                                                              
          //     Invalid character. Occurs when a character is encountered in   
          //    the stream that was not expected. Such as, a missing “=”        
          //    after attribute name.                                           
          //                                                                    
          //    MN                                                              
          //     Missing node. Occurs when a mandatory element or attribute     
          //    is missing.                                                     
          //                                                                    
          //    UN                                                              
          //     Unknown node. Occurs when a foreign (unknown) node has been    
          //    encountered within a ‘non-extensible’ element context           
          //                                                                    
          //    DA                                                              
          //     Duplicate attribute. Occurs during parsing when an XML         
          //    element has two attributes with the same name.                  
          //                                                                    
          //    PE                                                              
          //     Pattern error. The node text does not have the pattern         
          //    specified during design, such as date/time patterns.            
          //                                                                    
          //    OV                                                              
          //     Numeric overflow error. This can happen when the integer       
          //    part of the number is truncated after parsing.                  
          //                                                                    
          //    MD                                                              
          //     More data warning. This is a warning message that means        
          //    there is more data in XML document than the IDS (Interface      
          //    Data Structure) can hold.                                       
          //                                                                    
          //    BP                                                              
          //     XML PARSE statement error.                                     
          //                                                                    
          //    ER                                                              
          //     Unknown error. Occurs when operation could not be completed    
          //    for any other reason.                                           
          //                                                                    
          // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        }
      }
      return;
    }
    
    public void f_20972016(  )
    {
      func_0020972016_esc_flag = false;
      Globdata.GetStateData().SetLastStatementNumber( "0000000028" );
      
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
      Globdata.GetStateData().SetCurrentABId( "0022020271" );
      Globdata.GetStateData().SetCurrentABName( "CYYY0421_XML_PARSE" );
      Globdata.GetStateData().SetLastStatementNumber( "0000000028" );
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
      
      Globdata.GetStateData().SetLastStatementNumber( "0000000030" );
      if ( ((double) WLa.LocErrorIyy1ComponentReturnCode < (double) WLa.LocDontChangeReturnCodesQ1Ok) )
      {
        Globdata.GetStateData().SetLastStatementNumber( "0000000031" );
        WOa.ExpErrorIyy1ComponentSeverityCode = FixedStringAttr.ValueOf(WLa.LocErrorIyy1ComponentSeverityCode, 1);
        WOa.ExpErrorIyy1ComponentRollbackIndicator = FixedStringAttr.ValueOf(WLa.LocErrorIyy1ComponentRollbackIndicator, 1);
        WOa.ExpErrorIyy1ComponentOriginServid = DoubleAttr.ValueOf(WLa.LocErrorIyy1ComponentOriginServid);
        WOa.ExpErrorIyy1ComponentContextString = StringAttr.ValueOf(WLa.LocErrorIyy1ComponentContextString, 512);
        WOa.ExpErrorIyy1ComponentReturnCode = IntAttr.ValueOf(WLa.LocErrorIyy1ComponentReturnCode);
        WOa.ExpErrorIyy1ComponentReasonCode = IntAttr.ValueOf(WLa.LocErrorIyy1ComponentReasonCode);
        WOa.ExpErrorIyy1ComponentChecksum = FixedStringAttr.ValueOf(WLa.LocErrorIyy1ComponentChecksum, 15);
      }
      
      Globdata.GetStateData().SetLastStatementNumber( "0000000032" );
      WOa.ExpErrorIyy1ComponentSeverityCode = FixedStringAttr.ValueOf("E", 1);
      return;
    }
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    // INITIALIZATION UTILITY FUNCTIONS 
    // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    
    public void f_22020271_localAlloc( String abname )
    {
      // Request localview allocation 
      WLa = (GEN.ORT.YYY.CYYY0421_LA)(IefRuntimeParm2.GetInstance( GetType().Assembly,
      	"GEN.ORT.YYY.CYYY0421_LA" ));
      if ( WLa == null )
      {
        Globdata.GetStateData().SetCurrentABId( "0022020271" );
        Globdata.GetStateData().SetCurrentABName( abname );
        Globdata.GetErrorData().SetErrorEncountered( ErrorData.ErrorEncounteredErrorFound );
        Globdata.GetErrorData().SetLastStatus( ErrorData.LastStatusIefAllocationError );
      }
    }
    
    public void f_22020271_init(  )
    {
      if ( NestingLevel < 2 )
      {
        WLa.Reset();
      }
      WLa.LocGroupContext_MA = 0;
      for(LocGroupContext_PS_001 = 1; LocGroupContext_PS_001 <= 9; ++(LocGroupContext_PS_001))
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
      WOa.ExpErrorCanamXmlXmlReturnCode = "  ";
      WOa.ExpErrorCanamXmlXmlMessage = "                                                                                ";
      WOa.ExpErrorCanamXmlXmlPosition = 0.0;
      WOa.ExpErrorCanamXmlXmlSource = 
        "                                                                                                                        ";
      WOa.ExpErrorIyy1ComponentSeverityCode = " ";
      WOa.ExpErrorIyy1ComponentRollbackIndicator = " ";
      WOa.ExpErrorIyy1ComponentOriginServid = 0.0;
      WOa.ExpErrorIyy1ComponentContextString = "";
      WOa.ExpErrorIyy1ComponentReturnCode = 0;
      WOa.ExpErrorIyy1ComponentReasonCode = 0;
      WOa.ExpErrorIyy1ComponentChecksum = "               ";
      LocGroupContext_PS_001 = 1;
    }
    public void f_173015093_rgvc(  )
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

