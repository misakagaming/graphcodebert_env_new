<?xml version="1.0" encoding="ISO-8859-9"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">

  <xsl:variable name="varModelName">Model Name: </xsl:variable>
  <xsl:variable name="varSubset">Subset: </xsl:variable>
  <xsl:variable name="varEndOfReport">*** End of report ***</xsl:variable>
  <xsl:variable name="varAttr">Attribute: </xsl:variable>
  <xsl:variable name="varEntType">Entity Type: </xsl:variable>
  <xsl:variable name="varProp">Properties: </xsl:variable>
  <xsl:variable name="varAliases">Aliases: </xsl:variable>
  <xsl:variable name="varAlias">Alias</xsl:variable>
  <xsl:variable name="varAbbrev">Abbrev</xsl:variable>
  <xsl:variable name="varAcronym">Acronym</xsl:variable>
  <xsl:variable name="varLongName">LongName: </xsl:variable>
  <xsl:variable name="varDesc">Description: </xsl:variable>
  <xsl:variable name="varSubArea">Subject Area:</xsl:variable>
  <xsl:variable name="varValues">Values:</xsl:variable>
  <xsl:variable name="varPermVal">Permitted Values:</xsl:variable>
  <xsl:variable name="varDefault">Default:</xsl:variable>
  <xsl:variable name="varDefAlg">Default Algorithm:</xsl:variable>
  <xsl:variable name="varTDName">TD Name:</xsl:variable>
  <xsl:variable name="varto">to</xsl:variable>
  <xsl:variable name="varNone">&lt;None&gt;</xsl:variable>
  <xsl:variable name="varMandatory">Mandatory</xsl:variable>
  <xsl:variable name="varOptional">Optional</xsl:variable>
  <xsl:variable name="varAutoNumber">Auto Number</xsl:variable>
  <xsl:variable name="varBasic">Basic</xsl:variable>
  <xsl:variable name="varDerived">Derived</xsl:variable>
  <xsl:variable name="varDesigned">Designed</xsl:variable>
  <xsl:variable name="varText">Text</xsl:variable>
  <xsl:variable name="varDate">Date</xsl:variable>
  <xsl:variable name="varNumber">Number</xsl:variable>
  <xsl:variable name="varTime">Time</xsl:variable>
  <xsl:variable name="varTimestamp">Timestamp</xsl:variable>
  <xsl:variable name="varDBCS">DBCS</xsl:variable>
  <xsl:variable name="varMixed">Mixed</xsl:variable>
  <xsl:variable name="varBLOB">BLOB</xsl:variable>
  <xsl:variable name="varGUIObject">GUI Object</xsl:variable>
  <xsl:variable name="varLengthColon">Length:</xsl:variable>
  <xsl:variable name="varDecimalplacesColon">Decimal places: </xsl:variable>
  <xsl:variable name="varNotVariable">Fixed Length</xsl:variable>
  <xsl:variable name="varVariable">Variable Length</xsl:variable>
  <xsl:variable name="varNotCasesensitive">Not Case sensitive</xsl:variable>
  <xsl:variable name="varCasesensitive">Case sensitive</xsl:variable>
  <xsl:variable name="varImplCandJava">Implement in C, C# and Java with decimal precision</xsl:variable>
  <xsl:variable name="varDoNotImplCandJava">Do not implement in C, C# and Java with decimal precision</xsl:variable>
  <xsl:variable name="varCobolDataTypeColon">COBOL Data Type:</xsl:variable>
  <xsl:variable name="varDefaultDisplay">Default (Display format)</xsl:variable>
  <xsl:variable name="varCompBinary">Comp (Binary)</xsl:variable>
  <xsl:variable name="varComp-1">Comp-1 (Single precision)</xsl:variable>
  <xsl:variable name="varComp-2">Comp-2 (Double precision)</xsl:variable>
  <xsl:variable name="varComp-3">Comp-3 (Packed decimal))</xsl:variable>
  <xsl:variable name="varBAAActionBlockColon">BAA Action Block:</xsl:variable>
  <xsl:variable name="varBSDActionBlockColon">BSD Action Block:</xsl:variable>
  <xsl:variable name="varProcedureStepColon">Procedure Step:</xsl:variable>
  <xsl:variable name="varProcessColon">Process:</xsl:variable>
  <xsl:variable name="varOperationsColon">Operations:</xsl:variable>
  <xsl:variable name="varAttributesColon">Attributes:</xsl:variable>
  <xsl:variable name="varEntitySubtypeColon">Entity Subtype: </xsl:variable>
  <xsl:variable name="varPartitioningColon">Partitioning:</xsl:variable>
  <xsl:variable name="varYes">Yes</xsl:variable>
  <xsl:variable name="varNo">No</xsl:variable>
  <xsl:variable name="varWorkSetColon">Work Set:</xsl:variable>
  <xsl:variable name="varSubtypeColon">Subtype:</xsl:variable>
  <xsl:variable name="varUnitsKB">KB</xsl:variable>
  <xsl:variable name="varUnitsMB">MB</xsl:variable>
  <xsl:variable name="varUnitsGB">GB</xsl:variable>

    <xsl:template match="/">
      
   <DIV STYLE="background-color:white; font-size: 10pt">
	<h1 style="left:100; position:relative">
		<xsl:value-of select="Report/title"/></h1>
	<h3><xsl:copy-of select="$varModelName" /><span style="left:20; position:relative"><xsl:value-of select="Report/modelname"/></span></h3>
	<h3><xsl:copy-of select="$varSubset" /><span style="left:20; position:relative"><xsl:value-of select="Report/subset"/></span></h3>
	<h3><xsl:value-of select="Report/datetime"/></h3>
	<h3></h3>
	<h3></h3>
     <xsl:apply-templates select="Report"/>
   	<b style="left:100; position:relative"><xsl:copy-of select="$varEndOfReport" /></b>
   </DIV>

  </xsl:template>
  
  <xsl:template match="Report">
	<xsl:for-each select="TATTRUSR">
		<ul style="left:5; position:relative"><b><xsl:copy-of select="$varAttr" /></b>
			<span style="left:5; position:relative"><xsl:value-of select="@NAME" /></span>
			<xsl:apply-templates select="DALIAS" />
			<xsl:apply-templates select="TSUBJ" />
			<xsl:apply-templates select="THLENT" />
			<xsl:apply-templates select="THLENTDS" />
			<xsl:apply-templates select="TENTSU" />
			<xsl:apply-templates select="DESC" />
			<ul style="left:5; position:relative"><b><xsl:copy-of select="$varProp" /></b>
				<xsl:choose>
					<xsl:when test="@OPT[.='M']">
						<span style="left:20; position:relative"><xsl:copy-of select="$varMandatory" /></span>
					</xsl:when>
					<xsl:otherwise><span style="left:20; position:relative"><xsl:copy-of select="$varOptional" /></span>
					</xsl:otherwise>
				</xsl:choose>
				<xsl:choose>
					<xsl:when test="@BASDER[.='A']">
						<span style="left:30; position:relative"><xsl:copy-of select="$varAutoNumber" /></span>
					</xsl:when>
					<xsl:when test="@BASDER[.='B']">
						<span style="left:30; position:relative"><xsl:copy-of select="$varBasic" /></span>
					</xsl:when>
					<xsl:when test="@BASDER[.='D']">
						<span style="left:30; position:relative"><xsl:copy-of select="$varDerived" /></span>
					</xsl:when>
					<xsl:otherwise><span style="left:30; position:relative"><xsl:copy-of select="$varDesigned" /></span>
					</xsl:otherwise>
				</xsl:choose>
				<xsl:choose>
					<xsl:when test="@DOMAN[.='T']">
						<span style="left:40; position:relative"><xsl:copy-of select="$varText" /></span>
					</xsl:when>
					<xsl:when test="@DOMAN[.='D']">
						<span style="left:40; position:relative"><xsl:copy-of select="$varDate" /></span>
					</xsl:when>
					<xsl:when test="@DOMAN[.='N']">
						<span style="left:40; position:relative"><xsl:copy-of select="$varNumber" /></span>
					</xsl:when>
					<xsl:when test="@DOMAN[.='M']">
						<span style="left:40; position:relative"><xsl:copy-of select="$varTime" /></span>
					</xsl:when>
					<xsl:when test="@DOMAN[.='Q']">
						<span style="left:40; position:relative"><xsl:copy-of select="$varTimestamp" /></span>
					</xsl:when>
					<xsl:when test="@DOMAN[.='G']">
						<span style="left:40; position:relative"><xsl:copy-of select="$varDBCS" /></span>
					</xsl:when>
					<xsl:when test="@DOMAN[.='Z']">
						<span style="left:40; position:relative"><xsl:copy-of select="$varMixed" /></span>
					</xsl:when>
					<xsl:when test="@DOMAN[.='B']">
						<span style="left:40; position:relative"><xsl:copy-of select="$varBLOB" /></span>
					</xsl:when>
					<xsl:otherwise>
						<span style="left:40; position:relative"><xsl:copy-of select="$varGUIObject" /></span>
					</xsl:otherwise>
				</xsl:choose>
				<ul style="left:45; position:relative"><xsl:copy-of select="$varLengthColon" />
					<span style="left:5; position:relative"><xsl:value-of select="@LEN" /></span>
					<xsl:if test="@DOMAN[.='N']">
						<span style="left:20; position:relative"><xsl:copy-of select="$varDecimalplacesColon" /></span>
						<span style="left:30; position:relative"><xsl:value-of select="@DECPLC" /></span>
					</xsl:if>
					<xsl:if test="@DOMAN[.='B']">
						<xsl:choose>
							<xsl:when test="@UNITS[.='K']">
								<span style="left:10; position:relative">
									<xsl:copy-of select="$varUnitsKB" />
								</span>
							</xsl:when>
							<xsl:when test="@UNITS[.='M']">
								<span style="left:10; position:relative">
									<xsl:copy-of select="$varUnitsMB" />
								</span>
							</xsl:when>
							<xsl:when test="@UNITS[.='G']">
								<span style="left:10; position:relative">
									<xsl:copy-of select="$varUnitsGB" />
								</span>
							</xsl:when>
						</xsl:choose>
					</xsl:if>
				</ul>
				<xsl:choose>
					<xsl:when test="@VARLEN[.='N']">
						<ul style="left:45; position:relative"><xsl:copy-of select="$varNotVariable" /></ul>
					</xsl:when>
					<xsl:otherwise><ul style="left:45; position:relative"><xsl:copy-of select="$varVariable" /></ul>
					</xsl:otherwise>
				</xsl:choose>
				<xsl:choose>
					<xsl:when test="@CASESENS[.='N']">
						<ul style="left:45; position:relative"><xsl:copy-of select="$varNotCasesensitive" /></ul>
					</xsl:when>
					<xsl:otherwise><ul style="left:45; position:relative"><xsl:copy-of select="$varCasesensitive" /></ul>
					</xsl:otherwise>
				</xsl:choose>
				<ul style="left:45; position:relative"><b><xsl:copy-of select="$varTDName" /></b>
					<span style="left:5; position:relative"><xsl:value-of select="@DSDNAME" /></span>
				</ul>
				<xsl:if test="@DOMAN[.='N']">
					<p></p>
					<ul style="left:45; position:relative">
						<xsl:choose>
							<xsl:when test="@SRCETYP[.='Y']">
								<xsl:copy-of select="$varImplCandJava" />
							</xsl:when>
							<xsl:otherwise>
								<xsl:copy-of select="$varDoNotImplCandJava" />
							</xsl:otherwise>
						</xsl:choose>
					</ul>
					<ul style="left:45; position:relative"><xsl:copy-of select="$varCobolDataTypeColon" />
						<span style="left:5; position:relative">
						<xsl:choose>
							<xsl:when test="@DATTYP[.=' ']"><xsl:copy-of select="$varDefaultDisplay" /></xsl:when>
							<xsl:when test="@DATTYP[.='B']"><xsl:copy-of select="$varCompBinary" /></xsl:when>
							<xsl:when test="@DATTYP[.='S']"><xsl:copy-of select="$varComp-1" /></xsl:when>
							<xsl:when test="@DATTYP[.='O']"><xsl:copy-of select="$varComp-2" /></xsl:when>
							<xsl:otherwise><xsl:copy-of select="$varComp-3" /></xsl:otherwise>
						</xsl:choose>
						</span>
					</ul>
					<p></p>
				</xsl:if>
			</ul>
			<xsl:apply-templates select="TPERMVAL" />
		</ul>
	</xsl:for-each>
  </xsl:template>

  <xsl:template match="TACBLKBA">
		<ul style="left:20; position:relative"><b><xsl:copy-of select="$varBAAActionBlockColon" /></b>
	          <span style="left:20; position:relative"><xsl:value-of select="@NAME" /></span>
		</ul>
  </xsl:template>
  
  <xsl:template match="TACBLKBS">
		<ul style="left:20; position:relative"><b><xsl:copy-of select="$varBSDActionBlockColon" /></b>
	          <span style="left:20; position:relative"><xsl:value-of select="@NAME" /></span>
		</ul>
  </xsl:template>
  
  <xsl:template match="TBUSPRST">
		<ul style="left:20; position:relative"><b><xsl:copy-of select="$varProcedureStepColon" /></b>
	          <span style="left:20; position:relative"><xsl:value-of select="@NAME" /></span>
		</ul>
  </xsl:template>
  
  <xsl:template match="TPRCDF">
		<ul style="left:20; position:relative"><b><xsl:copy-of select="$varProcessColon" /></b>
	          <span style="left:20; position:relative"><xsl:value-of select="@NAME" /></span>
		</ul>
  </xsl:template>
  
  <xsl:template match="DACBLKDE">
		<ul style="left:20; position:relative"><b><xsl:copy-of select="$varOperationsColon" /></b>
          	<xsl:for-each select="TACBLKBA">
	          <ul style="left:20; position:relative"><xsl:value-of select="@NAME" /></ul>
          	</xsl:for-each>
          	<xsl:for-each select="TACBLKBS">
	          <ul style="left:20; position:relative"><xsl:value-of select="@NAME" /></ul>
          	</xsl:for-each>
		</ul>
  </xsl:template>
  
  <xsl:template match="DATTR">
		<ul style="left:20; position:relative"><b><xsl:copy-of select="$varAttributesColon" /></b>
          	<xsl:for-each select="TATTRUSR">
	          <ul style="left:20; position:relative"><xsl:value-of select="@NAME" /></ul>
          	</xsl:for-each>
		</ul>
  </xsl:template>
  
  <xsl:template match="TENTSU">
      <ul style="left:20; position:relative"><b><xsl:copy-of select="$varEntitySubtypeColon" /></b></ul>
        <ul style="left:40; position:relative"><xsl:value-of select="@NAME" /></ul>
			<xsl:apply-templates select="DACBLKDE"/>
			<xsl:apply-templates select="DATTR"/>
		<xsl:apply-templates select="TPART"/>
  </xsl:template>
  
  <xsl:template match="TPART">
	<ul style="left:20; position:relative"><b><xsl:copy-of select="$varPartitioningColon" /></b>
       	<xsl:for-each select="TATTRUSR">
          <ul style="left:20; position:relative"><xsl:value-of select="@NAME" /></ul>
       	</xsl:for-each>
		<xsl:apply-templates select="TENTSU"/>
	</ul>
  </xsl:template>
  
  <xsl:template match="DALIAS">
	<ul style="left:5; position:relative"><b><xsl:copy-of select="$varAliases" /></b>
		<xsl:choose>
			<xsl:when test="TALIAS/@NAME"><xsl:apply-templates select="TALIAS" /></xsl:when>
			<xsl:otherwise><span style="left:5; position:relative"><xsl:value-of select="$varNone" /></span></xsl:otherwise>
		</xsl:choose>
	</ul>
  </xsl:template>
  
  <xsl:template match="TALIAS">
	<xsl:if test="position()='1'">
	<ul style="left:0; position:relative"><b><xsl:copy-of select="$varAlias" /></b>
		<span style="left:360; position:absolute"><b><xsl:copy-of select="$varAbbrev" /></b></span>
		<span style="left:460; position:absolute"><b><xsl:copy-of select="$varAcronym" /></b></span>
	</ul>
	</xsl:if>
	<ul style="left:5; position:relative"><xsl:value-of select="@NAME" />
		<span style="left:360; position:absolute">
			<xsl:choose>
				<xsl:when test="@ABBREV[.='Y']"><xsl:copy-of select="$varYes" /></xsl:when>
				<xsl:otherwise><xsl:copy-of select="$varNo" /></xsl:otherwise>
			</xsl:choose>
		</span>
		<span style="left:460; position:absolute">
			<xsl:choose>
				<xsl:when test="@ACRONYM[.='Y']"><xsl:copy-of select="$varYes" /></xsl:when>
				<xsl:otherwise><xsl:copy-of select="$varNo" /></xsl:otherwise>
			</xsl:choose>
		</span>
		<xsl:apply-templates select="LONGNAME" />
		<xsl:apply-templates select="DESC" />
	</ul>
  </xsl:template>

  <xsl:template match="LONGNAME">
	<ul style="left:5; position:relative"><b><xsl:copy-of select="$varLongName" /></b>
		<span style="left:20; position:relative"><xsl:value-of select="." /></span>
	</ul>
  </xsl:template>

  <xsl:template match="DESC">
	<ul style="left:5; position:relative"><b><xsl:copy-of select="$varDesc" /></b>
		<span style="left:20; position:relative">
		<xsl:choose>
			<xsl:when test=". != ''"><xsl:value-of select="." /></xsl:when>
			<xsl:otherwise><xsl:copy-of select="$varNone" /></xsl:otherwise>
		</xsl:choose>
		</span>
	</ul>
  </xsl:template>

  <xsl:template match="TSUBJ">
	<ul style="left:5; position:relative"><b><xsl:copy-of select="$varSubArea" /></b>
		<span style="left:20; position:relative"><xsl:value-of select="@NAME" /></span></ul>
  </xsl:template>

  <xsl:template match="THLENT">
	<ul style="left:5; position:relative"><b><xsl:copy-of select="$varEntType" /></b>
		<span style="left:20; position:relative"><xsl:value-of select="@NAME" /></span></ul>
  </xsl:template>

  <xsl:template match="THLENTDS">
	<ul style="left:5; position:relative"><b><xsl:copy-of select="$varWorkSetColon" /></b>
		<span style="left:20; position:relative"><xsl:value-of select="@NAME" /></span></ul>
  </xsl:template>

  <xsl:template match="TENTSU">
	<ul style="left:5; position:relative"><b><xsl:copy-of select="$varSubtypeColon" /></b>
		<span style="left:20; position:relative"><xsl:value-of select="@NAME" /></span></ul>
  </xsl:template>

  <xsl:template match="TPERMVAL">
	<ul style="left:5; position:relative"><b><xsl:copy-of select="$varValues" /></b>
		<ul style="left:5; position:relative">
			<xsl:choose>
				<xsl:when test="@DFLTTO">
					<b><xsl:copy-of select="$varDefault" /></b>
					<span style="left:20; position:relative">
					<xsl:choose>
						<xsl:when test="@DFLTTO != ''"><xsl:value-of select="@DFLTTO" /></xsl:when>
						<xsl:otherwise><xsl:copy-of select="$varNone" /></xsl:otherwise>
					</xsl:choose>
					</span>
				</xsl:when>
				<xsl:otherwise>
					<b><xsl:copy-of select="$varDefAlg" /></b>
					<span style="left:20; position:relative"><xsl:value-of select="@ESTBY" /></span>
				</xsl:otherwise>
			</xsl:choose>
		</ul>
		<xsl:apply-templates select="MAYBE" />
	</ul>
  </xsl:template>

  <xsl:template match="MAYBE">
	<xsl:if test="position()='1'">
		<ul style="left:5; position:relative"><b><xsl:copy-of select="$varPermVal" /></b></ul>
	</xsl:if>
	<ul style="left:60; position:relative">
		<xsl:value-of select="substring-after(substring-before(@PERMVAL,';'),'LOWVAL:')" />
		<xsl:if test="substring-after(substring-before(@PERMVAL,';'),'LOWVAL:')!=substring-after(@PERMVAL,'HIVAL:')">
			<span style="left:20; position:relative"><b><xsl:copy-of select="$varto" /></b></span>
			<span style="left:40; position:relative"><xsl:value-of select="substring-after(@PERMVAL,'HIVAL:')" /></span>
		</xsl:if>
		<xsl:apply-templates select="DESC" />
	</ul>
  </xsl:template>

</xsl:stylesheet>
