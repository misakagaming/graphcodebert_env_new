<!-- Entity Type Definition Report -->
<?xml version="1.0" encoding="ISO-8859-9"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">

  <xsl:variable name="varModelName">Model Name: </xsl:variable>
  <xsl:variable name="varSubset">Subset: </xsl:variable>
  <xsl:variable name="varEndOfReport">*** End of report ***</xsl:variable>
  <xsl:variable name="varEntType">Entity Type: </xsl:variable>
  <xsl:variable name="varWorkset">Work Set: </xsl:variable>
  <xsl:variable name="varAliases">Aliases: </xsl:variable>
  <xsl:variable name="varProp">Properties: </xsl:variable>
  <xsl:variable name="varRelProp">Relationship Properties: </xsl:variable>
  <xsl:variable name="varDesc">Description: </xsl:variable>
  <xsl:variable name="varSubArea">Subject Area:</xsl:variable>
  <xsl:variable name="varMinOcc">Min Occ: </xsl:variable>
  <xsl:variable name="varAvgOcc">Avg Occ: </xsl:variable>
  <xsl:variable name="varMaxOcc">Max Occ: </xsl:variable>
  <xsl:variable name="varGrowth">Growth Rate: </xsl:variable>
  <xsl:variable name="varTDName">TD Name: </xsl:variable>
  <xsl:variable name="varName">Name: </xsl:variable>
  <xsl:variable name="varLongName">Long Name: </xsl:variable>
  <xsl:variable name="varDestination">Destination </xsl:variable>
  <xsl:variable name="varSource">Source </xsl:variable>
  <xsl:variable name="varClasVal">Classifying Value </xsl:variable>
  <xsl:variable name="varSubtype">Subtype </xsl:variable>
  <xsl:variable name="varSubtypeColon">Subtype: </xsl:variable>
  <xsl:variable name="varSubtypeOf">Subtype Of: </xsl:variable>
  <xsl:variable name="varOper">Operations: </xsl:variable>
  <xsl:variable name="varInheritOper">Inherited Operations: </xsl:variable>
  <xsl:variable name="varIdent">Identifiers: </xsl:variable>
  <xsl:variable name="varInheritIdent">Inherited Identifiers: </xsl:variable>
  <xsl:variable name="varPart">Partitioned by: </xsl:variable>
  <xsl:variable name="varMutExclusive">Mutually Exclusive Relationships: </xsl:variable>
  <xsl:variable name="varInheritRelation">Inherited Relationships: </xsl:variable>
  <xsl:variable name="varAttr">Attributes: </xsl:variable>
  <xsl:variable name="varRel">Relationships: </xsl:variable>
  <xsl:variable name="varInheritAttr">Inherited Attributes: </xsl:variable>
  <xsl:variable name="varNoName">&lt;unnamed&gt;</xsl:variable>
  <xsl:variable name="varPersist">Persistent, </xsl:variable>
  <xsl:variable name="varOpen">Open</xsl:variable>
  <xsl:variable name="varOpenNoEncap">Open (no encapsulation)</xsl:variable>
  <xsl:variable name="varEncap">Encapsulated</xsl:variable>
  <xsl:variable name="varRestPart">Restricted (partial encapsulation)</xsl:variable>
  <xsl:variable name="varPerYear">per year</xsl:variable>
  <xsl:variable name="varPerMnth">per month</xsl:variable>
  <xsl:variable name="varPerWeek">per week</xsl:variable>
  <xsl:variable name="varDaily">daily</xsl:variable>
  <xsl:variable name="varNone">&lt;None&gt;</xsl:variable>
  <xsl:variable name="varTransient">Transient,</xsl:variable>
  <xsl:variable name="varAbbrAcro">Abbreviation, Acronym</xsl:variable>
  <xsl:variable name="varAbbr">Abbreviation</xsl:variable>
  <xsl:variable name="varAcronym">Acronym</xsl:variable>
  <xsl:variable name="varAlways100">Always (100%)</xsl:variable>
  <xsl:variable name="varSometimesOpenParen">Sometimes (</xsl:variable>
  <xsl:variable name="varPercentCloseParen">%)</xsl:variable>
  <xsl:variable name="varOne">one</xsl:variable>
  <xsl:variable name="varMany">many</xsl:variable>
  <xsl:variable name="varCard">Cardinality</xsl:variable>
  <xsl:variable name="varMinColon">Min:</xsl:variable>
  <xsl:variable name="varMaxColon">Max:</xsl:variable>
  <xsl:variable name="varAvgColon">Avg:</xsl:variable>
  <xsl:variable name="varParenEstParen">(est)</xsl:variable>
  <xsl:variable name="varDispRelNam">Display relationship name</xsl:variable>
  <xsl:variable name="varDoNotDispRelNam">Do not display relationship name</xsl:variable>
  <xsl:variable name="varTrans">Transferable</xsl:variable>
  <xsl:variable name="varNotTrans">Not transferable</xsl:variable>
  <xsl:variable name="varRmdesc">Relationship description: </xsl:variable>
  <xsl:variable name="varNotRmdesc">Relationship has no description</xsl:variable>
  <xsl:variable name="varAssActRef">Associate action is Referencing</xsl:variable>
  <xsl:variable name="varAssActMod">Associate actions is Modifying</xsl:variable>
  <xsl:variable name="varDelRuleWhen">Deletion Rule: When an occurrence of</xsl:variable>
  <xsl:variable name="varIsDel"> is deleted</xsl:variable>
  <xsl:variable name="varDisallowDel">Disallow deletion of </xsl:variable>
  <xsl:variable name="varIfOneOrMoreOcc"> if there is one (or more) occurrence of</xsl:variable>
  <xsl:variable name="varIfThere">if there is a</xsl:variable>
  <xsl:variable name="varWhich">which</xsl:variable>
  <xsl:variable name="varThis">this</xsl:variable>
  <xsl:variable name="varDisassocOcc">Disassociate each occurrence of </xsl:variable>
  <xsl:variable name="varForWhichlast">for which this is the last</xsl:variable>
  <xsl:variable name="varDelEachOcc">Delete each occurrence of</xsl:variable>
  <xsl:variable name="varParenUnknowDelRuleParen">(Unknown delete rule)</xsl:variable>
  <xsl:variable name="varParenPrimaryParen">(Primary)</xsl:variable>
  <xsl:variable name="varYes">Yes</xsl:variable>
  <xsl:variable name="varNo">No</xsl:variable>

  <xsl:template match="/">

    <DIV STYLE="font-size: 10pt">
	<h1 style="left:100; position:relative">
		<xsl:value-of select="Report/title"/></h1>
	<h3><xsl:copy-of select="$varModelName" />  <xsl:value-of select="Report/modelname"/></h3>
	<h3><xsl:copy-of select="$varSubset" />  <xsl:value-of select="Report/subset"/></h3>
	<h3><xsl:value-of select="Report/datetime"/></h3>
	<h3></h3>
	<h3></h3>
     <xsl:apply-templates select="Report"/>
   	<b style="left:100; position:relative"><xsl:copy-of select="$varEndOfReport" /></b>
   </DIV>
   
  </xsl:template>
  
  <xsl:template match="Report">
	<xsl:apply-templates select="THLENT"/>
	<xsl:for-each select="THLENTDS">
		<b style="left:0; position:relative"><xsl:copy-of select="$varWorkset" /></b>
			<b style="left:40; position:relative"><xsl:value-of select="@NAME" /></b>
			<xsl:apply-templates select="TALIAS"/>
			<xsl:apply-templates select="DESC" />

			<xsl:apply-templates select="TSUBJ"/>
			
			<ul style="left:20; position:relative">
				<b><xsl:copy-of select="$varProp" /></b>
				<span style="left:18; position:relative">
				<xsl:choose>
					<xsl:when test="@BASDER[.='B']"><xsl:copy-of select="$varPersist" /></xsl:when>
					<xsl:otherwise><xsl:copy-of select="$varTransient" /></xsl:otherwise>
				</xsl:choose>

				<xsl:choose>
					<xsl:when test="@OOTYPE[.='O']"><xsl:copy-of select="$varOpenNoEncap" /></xsl:when>
					<xsl:when test="@OOTYPE[.='E']"><xsl:copy-of select="$varEncap" /></xsl:when>
					<xsl:when test="@OOTYPE[.='R']"><xsl:copy-of select="$varRestPart" /></xsl:when>
					<xsl:otherwise><xsl:copy-of select="$varOpen" /></xsl:otherwise>
				</xsl:choose>
				</span>
				<ul style="left:40; position:relative"><b><xsl:copy-of select="$varMinOcc" /></b>
					<span style="left:25; position:relative"><xsl:value-of select="@MINOCC"/></span>
				</ul>
				<ul style="left:40; position:relative"><b><xsl:copy-of select="$varAvgOcc" /></b>
					<span style="left:25; position:relative"><xsl:value-of select="@AVGOCC"/></span>
				</ul>
				<ul style="left:40; position:relative"><b><xsl:copy-of select="$varMaxOcc" /></b>
					<span style="left:25; position:relative"><xsl:value-of select="@MAXOCC"/></span>
				</ul>
				<ul style="left:40; position:relative"><b><xsl:copy-of select="$varGrowth" /></b>
					<span style="left:5; position:relative"><xsl:value-of select="@PCTGRW"/>%</span>
					<span style="left:15; position:relative">
						<xsl:choose>
							<xsl:when test="@GRWUNT[.='Y']"><xsl:copy-of select="$varPerYear" /></xsl:when>
							<xsl:when test="@GRWUNT[.='M']"><xsl:copy-of select="$varPerMnth" /></xsl:when>
							<xsl:when test="@GRWUNT[.='W']"><xsl:copy-of select="$varPerWeek" /></xsl:when>
							<xsl:otherwise><xsl:copy-of select="$varDaily" /></xsl:otherwise>
						</xsl:choose>
					</span>
				</ul>
			<ul style="left:40; position:relative"><b><xsl:copy-of select="$varTDName" /></b>
				<span style="left:24; position:relative"><xsl:value-of select="@DSDNAME"/></span>
			</ul>
			</ul>
			
			<xsl:apply-templates select="DACBLKDE"/>
			<xsl:apply-templates select="DATTR"/>
			<xsl:apply-templates select="TRELMM" />
			<xsl:apply-templates select="DMUEXC"/>
			<xsl:apply-templates select="TIDENT"/>
			<xsl:apply-templates select="TPART"/>
	</xsl:for-each>
  </xsl:template>

  <xsl:template match="DACBLKDE">
	<xsl:choose>
		<xsl:when test="THLENT or TACBLKBA or TACBLKBS">
			<xsl:choose>
			<xsl:when test="THLENT">
				<xsl:for-each select="THLENT">
				<ul style="left:20; position:relative"><b><xsl:copy-of select="$varInheritOper" /></b>
					<ul style="left:40; position:relative"><xsl:value-of select="@NAME" />
          			<xsl:for-each select="TACBLKBA">
					<ul style="left:20; position:relative"><xsl:value-of select="@NAME" /></ul>
          			</xsl:for-each>
          			<xsl:for-each select="TACBLKBS">
					<ul style="left:20; position:relative"><xsl:value-of select="@NAME" /></ul>
          			</xsl:for-each>
          			</ul>
				</ul>
				</xsl:for-each>
			</xsl:when>
			<xsl:otherwise>
				<ul style="left:20; position:relative"><b><xsl:copy-of select="$varOper" /></b>
          			<xsl:for-each select="TACBLKBA">
					<ul style="left:40; position:relative"><xsl:value-of select="@NAME" /></ul>
          			</xsl:for-each>
          			<xsl:for-each select="TACBLKBS">
					<ul style="left:40; position:relative"><xsl:value-of select="@NAME" /></ul>
          			</xsl:for-each>
				</ul>
			</xsl:otherwise>
			</xsl:choose>
		</xsl:when>
		<xsl:otherwise>
			<ul style="left:20; position:relative"><b><xsl:copy-of select="$varOper" /></b>
				<xsl:choose>
					<xsl:when test=". != ''">
						<span style="left:10; position:relative"><xsl:value-of select="." /></span>
					</xsl:when>
					<xsl:otherwise>
						<span style="left:10; position:relative"><xsl:copy-of select="$varNone" /></span>
					</xsl:otherwise>
				</xsl:choose>
			</ul>
		</xsl:otherwise>
	</xsl:choose>
  </xsl:template>
  
  <xsl:template match="DATTR">
	<xsl:choose>
	<xsl:when test="THLENT">
		<xsl:for-each select="THLENT">
		<ul style="left:20; position:relative"><b><xsl:copy-of select="$varInheritAttr" /></b>
			<ul style="left:40; position:relative"><xsl:value-of select="@NAME" />
          	<xsl:for-each select="TATTRUSR">
	          <ul style="left:20; position:relative"><xsl:value-of select="@NAME" /></ul>
          	</xsl:for-each>
          	</ul>
		</ul>
		</xsl:for-each>
	</xsl:when>
	<xsl:otherwise>
		<ul style="left:20; position:relative"><b><xsl:copy-of select="$varAttr" /></b>
          	<xsl:for-each select="TATTRUSR">
	          <ul style="left:40; position:relative"><xsl:value-of select="@NAME" /></ul>
          	</xsl:for-each>
		</ul>
	</xsl:otherwise>
	</xsl:choose>
  </xsl:template>
  
  <xsl:template match="TENTSU">
		<ul style="left:20; position:relative"><b><xsl:copy-of select="$varSubtypeColon" /></b>
			<b style="left:30; position:relative"><xsl:value-of select="@NAME" /></b>
                </ul>
		<xsl:apply-templates select="TALIAS"/>

		<xsl:apply-templates select="DESC" />

		<ul style="left:20; position:relative">
			<b><xsl:copy-of select="$varProp" /></b>
			<span style="left:18; position:relative">
			<xsl:choose>
				<xsl:when test="@BASDER[.='B']"><xsl:copy-of select="$varPersist" /></xsl:when>
				<xsl:otherwise><xsl:copy-of select="$varTransient" /></xsl:otherwise>
			</xsl:choose>
			<xsl:choose>
				<xsl:when test="@OOTYPE[.='O']"><xsl:copy-of select="$varOpenNoEncap" /></xsl:when>
				<xsl:when test="@OOTYPE[.='E']"><xsl:copy-of select="$varEncap" /></xsl:when>
				<xsl:when test="@OOTYPE[.='R']"><xsl:copy-of select="$varRestPart" /></xsl:when>
				<xsl:otherwise><xsl:copy-of select="$varOpen" /></xsl:otherwise>
			</xsl:choose>
			</span>

			<ul style="left:40; position:relative"><b><xsl:copy-of select="$varMinOcc" /></b>
				<span style="left:25; position:relative"><xsl:value-of select="@MINOCC"/></span>
			</ul>
			<ul style="left:40; position:relative"><b><xsl:copy-of select="$varAvgOcc" /></b>
				<span style="left:25; position:relative"><xsl:value-of select="@AVGOCC"/></span>
			</ul>
			<ul style="left:40; position:relative"><b><xsl:copy-of select="$varMaxOcc" /></b>
				<span style="left:25; position:relative"><xsl:value-of select="@MAXOCC"/></span>
			</ul>
			<ul style="left:40; position:relative"><b><xsl:copy-of select="$varGrowth" /></b>
				<span style="left:5; position:relative"><xsl:value-of select="@PCTGRW"/>%</span>
				<span style="left:15; position:relative">
					<xsl:choose>
						<xsl:when test="@GRWUNT[.='Y']"><xsl:copy-of select="$varPerYear" /></xsl:when>
						<xsl:when test="@GRWUNT[.='M']"><xsl:copy-of select="$varPerMnth" /></xsl:when>
						<xsl:when test="@GRWUNT[.='W']"><xsl:copy-of select="$varPerWeek" /></xsl:when>
						<xsl:otherwise><xsl:copy-of select="$varDaily" /></xsl:otherwise>
					</xsl:choose>
				</span>
			</ul>
			<ul style="left:40; position:relative"><b><xsl:copy-of select="$varTDName" /></b>
			<span style="left:24; position:relative"><xsl:value-of select="@DSDNAME"/></span>
			</ul>
		</ul>
			
		<xsl:apply-templates select="DACBLKDE"/>
		<xsl:apply-templates select="DATTR"/>
		<xsl:apply-templates select="TRELMM" />
		<xsl:apply-templates select="DRELMM"/>
		<xsl:apply-templates select="DMUEXC"/>
		<xsl:apply-templates select="TIDENT"/>
		<xsl:apply-templates select="DIDENT" />
		<xsl:for-each select="THLENT">
			<ul style="left:20; position:relative"><b><xsl:copy-of select="$varSubtypeOf" /></b>
				<span style="left:10; position:relative"><xsl:value-of select="@NAME" /></span>
			</ul>
		</xsl:for-each>
		<xsl:apply-templates select="TPART"/>
  </xsl:template>
  
  <xsl:template match="TPART">
	<ul style="left:20; position:relative"><b><xsl:copy-of select="$varPart" /></b>
		<xsl:choose>
			<xsl:when test="TATTRUSR or TENTSU">
       			<xsl:for-each select="TATTRUSR">
				<span style="left:68; position:relative"><xsl:value-of select="@NAME" /></span>
       			</xsl:for-each>
       			<xsl:if test="TENTSU">
       			<ul style="left:38; position:relative"><b><xsl:copy-of select="$varSubtype" /></b>
       				<span style="left:300; position:absolute"><b><xsl:copy-of select="$varClasVal" /></b></span>
       			</ul>
				<xsl:for-each select="TENTSU">
					<ul style="left:38; position:relative"><xsl:value-of select="@NAME" />
					<xsl:for-each select="TPERMVAL">
						<span style="left:300; position:absolute">
						<xsl:choose>
							<xsl:when test="@HIVAL"><xsl:value-of select="@HIVAL" /></xsl:when>
							<xsl:otherwise><xsl:value-of select="." /></xsl:otherwise>
       					</xsl:choose>
       					</span>
       				</xsl:for-each>
					</ul>
				</xsl:for-each>
				</xsl:if>
			</xsl:when>
			<xsl:otherwise><span style="left:10; position:relative"><xsl:copy-of select="$varNone" /></span></xsl:otherwise>
		</xsl:choose>
	</ul>
  </xsl:template>
  
  <xsl:template match="TSUBJ">
	<ul style="left:20; position:relative"><b><xsl:copy-of select="$varSubArea" /></b>
		<span style="left:4; position:relative"><xsl:value-of select="@NAME" /></span></ul>
  </xsl:template>

  <xsl:template match="TALIAS">
	<ul style="left:10; position:relative">
		<xsl:choose>
			<xsl:when test="@NAME">
				<xsl:if test="position() = '1'">
					<b><xsl:copy-of select="$varAliases" /></b>
					<span style="left:480; position:absolute"><xsl:copy-of select="$varAbbr" /></span>
					<span style="left:560; position:absolute"><xsl:copy-of select="$varAcronym" /></span>
				</xsl:if>
				<ul style="left:-10; position:relative">
					<xsl:value-of select="@NAME" />
						<span style="left:480; position:absolute">
						<xsl:choose>
							<xsl:when test="@ABBREV[.='Y']"><xsl:copy-of select="$varYes" /></xsl:when>
							<xsl:otherwise><xsl:copy-of select="$varNo" /></xsl:otherwise>
						</xsl:choose>
		   				</span>
						<span style="left:540; position:absolute">
						<xsl:choose>
							<xsl:when test="@ACRONYM[.='Y']"><xsl:copy-of select="$varYes" /></xsl:when>
							<xsl:otherwise><xsl:copy-of select="$varNo" /></xsl:otherwise>
						</xsl:choose>
		   				</span>
						<xsl:apply-templates select="LONGNAME" />
						<xsl:apply-templates select="DESC" />
				</ul>
			</xsl:when>
			<xsl:otherwise><b><xsl:copy-of select="$varAliases" /></b><span style="left:10; position:relative"><xsl:copy-of select="$varNone" /></span></xsl:otherwise>
		</xsl:choose>
	</ul>
  </xsl:template>

  <xsl:template match="LONGNAME">
   	<ul style="left:20; position:relative"><b><xsl:copy-of select="$varLongName" /></b>
	   <span style="left:80; position:absolute"><xsl:value-of select="." /></span>
  	</ul>
  </xsl:template>

  <xsl:template match="DESC">
	<ul style="left:20; position:relative"><b><xsl:copy-of select="$varDesc" /></b>
		<xsl:choose>
			<xsl:when test=". != ''">
				<span style="left:10; position:relative"><xsl:value-of select="." /></span>
			</xsl:when>
			<xsl:otherwise>
				<span style="left:10; position:relative"><xsl:copy-of select="$varNone" /></span>
			</xsl:otherwise>
		</xsl:choose>
	</ul>
  </xsl:template>

  <xsl:template match="TRELMM">
	<ul style="left:20; position:relative"><b><xsl:copy-of select="$varRelProp" /></b>
	   <xsl:choose>
		<xsl:when test="@NAME">
			<ul style="left:40; position:relative"><b><xsl:copy-of select="$varSource" /></b>
				<span style="left:30; position:relative">
				<xsl:choose>
					<xsl:when test="@OPT[.='M']"><xsl:copy-of select="$varAlways100" /></xsl:when>
					<xsl:otherwise><xsl:copy-of select="$varSometimesOpenParen" /><xsl:value-of select="@PCTOPT" /><xsl:copy-of select="$varPercentCloseParen" /></xsl:otherwise>
				</xsl:choose>
				</span>
				<span style="left:40; position:relative"><xsl:value-of select="@NAME" /></span>
				<span style="left:50; position:relative">
				<xsl:choose>
					<xsl:when test="@CARD[.='1']"><xsl:copy-of select="$varOne" /></xsl:when>
					<xsl:otherwise><xsl:copy-of select="$varMany" /></xsl:otherwise>
				</xsl:choose>
				</span>
				<span style="left:60; position:relative"><xsl:value-of select="@DSCPR" /></span>
				<xsl:if test="@CARD[.='M']">
					<ul style="left:30; position:relative"><xsl:copy-of select="$varCard" />
						<span style="left:10; position:relative"><xsl:copy-of select="$varMinColon" /><xsl:value-of select="@EXPMIN" /><xsl:copy-of select="$varParenEstParen" /></span>
						<span style="left:20; position:relative"><xsl:copy-of select="$varMaxColon" /><xsl:value-of select="@EXPMAX" /><xsl:copy-of select="$varParenEstParen" /></span>
						<span style="left:30; position:relative"><xsl:copy-of select="$varAvgColon" /><xsl:value-of select="@EXPAVG" /></span>
					</ul>
				</xsl:if>
				<ul style="left:30; position:relative">
				<xsl:choose>
					<xsl:when test="@DISPLAD[.='Y']"><xsl:copy-of select="$varDispRelNam" /></xsl:when>
					<xsl:otherwise><xsl:copy-of select="$varDoNotDispRelNam" /></xsl:otherwise>
				</xsl:choose>
				</ul>
				<ul style="left:30; position:relative">
				<xsl:choose>
					<xsl:when test="@TRANSF[.='Y']"><xsl:copy-of select="$varTrans" /></xsl:when>
					<xsl:otherwise><xsl:copy-of select="$varNotTrans" /></xsl:otherwise>
				</xsl:choose>
				</ul>
				<ul style="left:30; position:relative">
				<xsl:choose>
					<xsl:when test="@RMDESC[.='']"><xsl:copy-of select="$varNotRmdesc" /></xsl:when>
					<xsl:otherwise><xsl:copy-of select="$varRmdesc" /><xsl:value-of select="@RMDESC" /></xsl:otherwise>
				</xsl:choose>
				</ul>
				<ul style="left:30; position:relative">
				<xsl:choose>
					<xsl:when test="@MODORREF[.='R']"><xsl:copy-of select="$varAssActRef" /></xsl:when>
					<xsl:otherwise><xsl:copy-of select="$varAssActMod" /></xsl:otherwise>
				</xsl:choose>
				</ul>
				<ul style="left:30; position:relative"><xsl:copy-of select="$varDelRuleWhen" />
					<span style="left:10; position:relative"><xsl:value-of select="@DENTY" /><xsl:copy-of select="$varIsDel" /></span>
					<ul style="left:40; position:relative">
						<xsl:choose>
						<xsl:when test="INVERS/TRELMM/@CASCADE[.='R']"><xsl:copy-of select="$varDisallowDel" /><xsl:value-of select="INVERS/TRELMM/@DSCPR" />
							<xsl:if test="INVERS/TRELMM/@CARD[.='1']"><xsl:copy-of select="$varIfOneOrMoreOcc" /> 
							<span style="left:10; position:relative">
							<xsl:value-of select="INVERS/TRELMM/@DENTY" />
							</span>
							</xsl:if>
							<xsl:if test="INVERS/TRELMM/@CARD[.='M']"><xsl:copy-of select="$varIfThere" /> 
							<span style="left:10; position:relative">
							<xsl:value-of select="INVERS/TRELMM/@DENTY" />
							</span>
							<span style="left:10; position:relative"><xsl:copy-of select="$varWhich" /> 
							<xsl:value-of select="INVERS/TRELMM/@NAME" />
							</span>
							<span style="left:10; position:relative"><xsl:copy-of select="$varThis" /> 
							<xsl:value-of select="INVERS/TRELMM/@DSCPR" />
							</span>
							</xsl:if>
						</xsl:when>
						<xsl:when test="INVERS/TRELMM/@CASCADE[.='N']"><xsl:copy-of select="$varDisassocOcc" /><xsl:value-of select="INVERS/TRELMM/@DENTY" /></xsl:when>
						<xsl:when test="INVERS/TRELMM/@CASCADE[.='D']">
							<xsl:choose>
								<xsl:when test="INVERS/TRELMM/@CARD[.='1']">
									<xsl:copy-of select="$varDelEachOcc" /><xsl:value-of select="INVERS/TRELMM/@DENTY" />
								</xsl:when>
								<xsl:otherwise>
									<xsl:copy-of select="$varDelEachOcc" /><xsl:value-of select="INVERS/TRELMM/@DENTY" />
									<span style="left:10; position:relative"><xsl:copy-of select="$varForWhichlast" /> 
									<xsl:value-of select="INVERS/TRELMM/@DSCPR" />
									</span>
								</xsl:otherwise>
							</xsl:choose>
						</xsl:when>
						<xsl:when test="INVERS/TRELMM/@CASCADE[.='C']">
							<xsl:choose>
								<xsl:when test="INVERS/TRELMM/@CARD[.='1']">
									<xsl:copy-of select="$varDelEachOcc" /><xsl:value-of select="INVERS/TRELMM/@DENTY" />
								</xsl:when>
								<xsl:otherwise>
									<xsl:copy-of select="$varDelEachOcc" /><xsl:value-of select="INVERS/TRELMM/@DENTY" />
									<span style="left:10; position:relative"><xsl:copy-of select="$varForWhichlast" /> 
									<xsl:value-of select="INVERS/TRELMM/@DSCPR" />
									</span>
								</xsl:otherwise>
							</xsl:choose>
						</xsl:when>
						<xsl:otherwise><xsl:copy-of select="$varParenUnknowDelRuleParen" /></xsl:otherwise>
						</xsl:choose>
					</ul>
				</ul>
				<xsl:apply-templates select="DESC" />
			</ul>
			
			<ul style="left:40; position:relative"><b><xsl:copy-of select="$varDestination" /></b>
				<span style="left:8; position:relative">
				<xsl:choose>
					<xsl:when test="INVERS/TRELMM/@OPT[.='M']"><xsl:copy-of select="$varAlways100" /></xsl:when>
					<xsl:otherwise><xsl:copy-of select="$varSometimesOpenParen" /><xsl:value-of select="INVERS/TRELMM/@PCTOPT" /><xsl:copy-of select="$varPercentCloseParen" /></xsl:otherwise>
				</xsl:choose>
				</span>
				<span style="left:20; position:relative"><xsl:value-of select="INVERS/TRELMM/@NAME" /></span>
				<span style="left:30; position:relative">
				<xsl:choose>
					<xsl:when test="INVERS/TRELMM/@CARD[.='1']"><xsl:copy-of select="$varOne" /></xsl:when>
					<xsl:otherwise><xsl:copy-of select="$varMany" /></xsl:otherwise>
				</xsl:choose>
				</span>
				<span style="left:40; position:relative"><xsl:value-of select="INVERS/TRELMM/@DSCPR" /></span>
				<xsl:if test="INVERS/TRELMM/@CARD[.='M']">
					<ul style="left:30; position:relative"><xsl:copy-of select="$varCard" />
						<span style="left:10; position:relative"><xsl:copy-of select="$varMinColon" /><xsl:value-of select="INVERS/TRELMM/@EXPMIN" /><xsl:copy-of select="$varParenEstParen" /></span>
						<span style="left:20; position:relative"> <xsl:copy-of select="$varMaxColon" /><xsl:value-of select="INVERS/TRELMM/@EXPMAX" /><xsl:copy-of select="$varParenEstParen" /></span>
						<span style="left:30; position:relative"><xsl:copy-of select="$varAvgColon" /><xsl:value-of select="INVERS/TRELMM/@EXPAVG" /></span>
					</ul>
				</xsl:if>
				
				<xsl:apply-templates select="INVERS" />
					<ul style="left:110; position:relative">
						<xsl:choose>
						<xsl:when test="@CASCADE[.='R']"><xsl:copy-of select="$varDisallowDel" /><xsl:value-of select="@DSCPR" />
							<xsl:if test="@CARD[.='1']"><xsl:copy-of select="$varIfOneOrMoreOcc" /> 
							<span style="left:10; position:relative">
							<xsl:value-of select="@DENTY" />
							</span>
							</xsl:if>
							<xsl:if test="@CARD[.='M']"><xsl:copy-of select="$varIfThere" /> 
							<span style="left:10; position:relative">
							<xsl:value-of select="@DENTY" />
							</span>
							<span style="left:10; position:relative"><xsl:copy-of select="$varWhich" /> 
							<xsl:value-of select="@NAME" />
							</span>
							<span style="left:10; position:relative"><xsl:copy-of select="$varThis" /> 
							<xsl:value-of select="@DSCPR" />
							</span>
							</xsl:if>
						</xsl:when>
						<xsl:when test="@CASCADE[.='N']"><xsl:copy-of select="$varDisassocOcc" /><xsl:value-of select="@DENTY" /></xsl:when>
						<xsl:when test="@CASCADE[.='D']">
							<xsl:choose>
								<xsl:when test="@CARD[.='1']">
									<xsl:copy-of select="$varDelEachOcc" /><xsl:value-of select="@DENTY" />
								</xsl:when>
								<xsl:otherwise><xsl:copy-of select="$varDelEachOcc" /><xsl:value-of select="@DENTY" />
									<span style="left:10; position:relative"><xsl:copy-of select="$varForWhichlast" /> 
									<xsl:value-of select="@DSCPR" />
									</span>
								</xsl:otherwise>
							</xsl:choose>
						</xsl:when>
						<xsl:when test="@CASCADE[.='C']">
							<xsl:choose>
								<xsl:when test="@CARD[.='1']">
									<xsl:copy-of select="$varDelEachOcc" /><xsl:value-of select="@DENTY" />
								</xsl:when>
								<xsl:otherwise>
									<xsl:copy-of select="$varDelEachOcc" /><xsl:value-of select="@DENTY" />
									<span style="left:10; position:relative"><xsl:copy-of select="$varForWhichlast" /> 
									<xsl:value-of select="@DSCPR" />
									</span>
								</xsl:otherwise>
							</xsl:choose>
						</xsl:when>
						<xsl:otherwise><xsl:copy-of select="$varParenUnknowDelRuleParen" /></xsl:otherwise>
						</xsl:choose>
					</ul>
					<xsl:apply-templates select="DESC" />
			</ul>
		</xsl:when>
		<xsl:otherwise><span style="left:10; position:relative"><xsl:value-of select="." /></span></xsl:otherwise>
	   </xsl:choose>
	</ul>
  </xsl:template>

  <xsl:template match="INVERS">
	
	<xsl:for-each select="TRELMM">
	   <ul style="left:30; position:relative">
	      <xsl:choose>
		<xsl:when test="@DISPLAD[.='Y']"><xsl:copy-of select="$varDispRelNam" /></xsl:when>
		<xsl:otherwise><xsl:copy-of select="$varDoNotDispRelNam" /></xsl:otherwise>
	      </xsl:choose>
	   </ul>
	   <ul style="left:30; position:relative">
	      <xsl:choose>
		<xsl:when test="@TRANSF[.='Y']"><xsl:copy-of select="$varTrans" /></xsl:when>
		<xsl:otherwise><xsl:copy-of select="$varNotTrans" /></xsl:otherwise>
	      </xsl:choose>
	   </ul>
	   <ul style="left:30; position:relative">
		<xsl:choose>
		<xsl:when test="@RMDESC[.='']"><xsl:copy-of select="$varNotRmdesc" /></xsl:when>
		<xsl:otherwise><xsl:copy-of select="$varRmdesc" /><xsl:value-of select="@RMDESC" /></xsl:otherwise>
	      </xsl:choose>
	   </ul>
	   <ul style="left:30; position:relative">
		<xsl:choose>
			<xsl:when test="@MODORREF[.='R']"><xsl:copy-of select="$varAssActRef" /></xsl:when>
			<xsl:otherwise><xsl:copy-of select="$varAssActMod" /></xsl:otherwise>
		</xsl:choose>
	   </ul>
	   <ul style="left:30; position:relative"><xsl:copy-of select="$varDelRuleWhen" />
		<span style="left:10; position:relative"><xsl:value-of select="@DENTY" /><xsl:copy-of select="$varIsDel" /></span>
	   </ul>
	</xsl:for-each>
	
  </xsl:template>

  <xsl:template match="DMUEXC">
	<ul style="left:20; position:relative"><b><xsl:copy-of select="$varMutExclusive" /> </b>
		<xsl:choose>
			<xsl:when test="TMUEXC/@NAME"><xsl:apply-templates select="TMUEXC" /></xsl:when>
			<xsl:otherwise><span style="left:20; position:relative"><xsl:copy-of select="$varNone"/></span></xsl:otherwise>
		</xsl:choose>
	</ul>
  </xsl:template>

  <xsl:template match="TMUEXC">
	<xsl:if test="position()!='1'"><br /></xsl:if>
	<ul style="left:20; position:relative"><b><xsl:copy-of select="$varName" /></b><xsl:value-of select="@NAME" /></ul>
			<xsl:for-each select="TRELMM">
				<ul style="left:60; position:relative"><xsl:value-of select="@NAME"/></ul>
			</xsl:for-each>
		<xsl:apply-templates select="DESC" />
  </xsl:template>
  
  <xsl:template match="TIDENT">
     <ul style="left:20; position:relative"><b><xsl:copy-of select="$varIdent" /> </b>
		<xsl:choose>
			<xsl:when test="@NAME">
				<ul style="left:6; position:relative"><b><xsl:copy-of select="$varName" /></b>
								<span style="left:65; position:relative">
					<xsl:choose>
										<xsl:when test="@NAME[.='']">Unnamed</xsl:when>
						<xsl:otherwise><xsl:value-of select="@NAME"/></xsl:otherwise>
					</xsl:choose>
		                        
					<xsl:if test="@PRIMARY[.='Y']"><span style="left:10; position:relative"><xsl:copy-of select="$varParenPrimaryParen" /></span></xsl:if>
					</span>
				</ul>

				<ul style="left:38; position:relative"><b><xsl:copy-of select="$varAttr" /></b>
					<xsl:for-each select="TATTRUSR">
						<ul style="left:40; position:relative"><xsl:value-of select="@NAME"/></ul>
					</xsl:for-each>
				</ul>

				<ul style="left:38; position:relative"><b><xsl:copy-of select="$varRel"/></b>
					<xsl:for-each select="TRELMM">
						<ul style="left:10; position:relative"><xsl:value-of select="@Level"/>
						<span style="left:10; position:relative"><xsl:value-of select="@DSCPR"/></span>
							</ul>
					</xsl:for-each>
				</ul>

			</xsl:when>
			<xsl:otherwise><span style="left:10; position:relative"><xsl:copy-of select="$varNone"/></span></xsl:otherwise>
		</xsl:choose>
	</ul>
  </xsl:template>
  
  <xsl:template match="DRELMM">
	<ul style="left:20; position:relative"><b><xsl:copy-of select="$varInheritRelation" /></b>>
		<xsl:apply-templates select="TRELMM" />
	</ul>
  </xsl:template>

  <xsl:template match="CNTANS">
	<xsl:for-each select="TRELMM">
		<ul style="left:60; position:relative"><xsl:value-of select="@NAME"/></ul>
	</xsl:for-each>
  </xsl:template>
  
  <xsl:template match="DIDENT">
	<ul style="left:20; position:relative"><b><xsl:copy-of select="$varInheritIdent" /></b>>
		<xsl:apply-templates select="TIDENT" />
	</ul>
  </xsl:template>
  
  <xsl:template match="THLENT">
	<ul style="left:10; position:relative"><b style="left:0; position:relative"><xsl:copy-of select="$varEntType" /></b>
		<b style="left:40; position:relative"><xsl:value-of select="@NAME" /></b>
		<xsl:apply-templates select="TALIAS"/>
		<xsl:apply-templates select="DESC" />
		<xsl:apply-templates select="TSUBJ"/>
		<ul style="left:20; position:relative">
			<b><xsl:copy-of select="$varProp" /></b>
			<span style="left:18; position:relative">
			<xsl:choose>
				<xsl:when test="@BASDER[.='B']"><xsl:copy-of select="$varPersist" /></xsl:when>
				<xsl:otherwise><xsl:copy-of select="$varTransient" /></xsl:otherwise>
			</xsl:choose>

			<xsl:choose>
				<xsl:when test="@OOTYPE[.='O']"><xsl:copy-of select="$varOpenNoEncap" /></xsl:when>
				<xsl:when test="@OOTYPE[.='E']"><xsl:copy-of select="$varEncap" /></xsl:when>
				<xsl:when test="@OOTYPE[.='R']"><xsl:copy-of select="$varRestPart" /></xsl:when>
				<xsl:otherwise><xsl:copy-of select="$varOpen" /></xsl:otherwise>
			</xsl:choose>
			</span>
			<ul style="left:40; position:relative"><b><xsl:copy-of select="$varMinOcc" /></b>
				<span style="left:25; position:relative"><xsl:value-of select="@MINOCC"/></span>
			</ul>
			<ul style="left:40; position:relative"><b><xsl:copy-of select="$varAvgOcc" /></b>
				<span style="left:25; position:relative"><xsl:value-of select="@AVGOCC"/></span>
			</ul>
			<ul style="left:40; position:relative"><b><xsl:copy-of select="$varMaxOcc" /></b>
				<span style="left:25; position:relative"><xsl:value-of select="@MAXOCC"/></span>
			</ul>
			<ul style="left:40; position:relative"><b><xsl:copy-of select="$varGrowth" /></b>
				<span style="left:5; position:relative"><xsl:value-of select="@PCTGRW"/>%</span>
				<span style="left:15; position:relative">
					<xsl:choose>
						<xsl:when test="@GRWUNT[.='Y']"><xsl:copy-of select="$varPerYear" /></xsl:when>
						<xsl:when test="@GRWUNT[.='M']"><xsl:copy-of select="$varPerMnth" /></xsl:when>
						<xsl:when test="@GRWUNT[.='W']"><xsl:copy-of select="$varPerWeek" /></xsl:when>
						<xsl:otherwise><xsl:copy-of select="$varDaily" /></xsl:otherwise>
					</xsl:choose>
				</span>
			</ul>
		<ul style="left:40; position:relative"><b><xsl:copy-of select="$varTDName" /></b>
			<span style="left:24; position:relative"><xsl:value-of select="@DSDNAME"/></span>
		</ul>
		</ul>
		
		<xsl:apply-templates select="DACBLKDE"/>
		<xsl:apply-templates select="DATTR"/>
		<xsl:apply-templates select="TRELMM" />
		<xsl:apply-templates select="DMUEXC"/>
		<xsl:apply-templates select="TIDENT"/>
		<xsl:apply-templates select="TPART"/>
		<xsl:apply-templates select="TENTSU"/>
	</ul>
  </xsl:template>

</xsl:stylesheet>

