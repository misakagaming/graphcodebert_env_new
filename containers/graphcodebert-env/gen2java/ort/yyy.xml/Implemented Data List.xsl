<?xml version="1.0" encoding="ISO-8859-9"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">

  <xsl:variable name="varModelName">Model Name: </xsl:variable>
  <xsl:variable name="varSubset">Subset: </xsl:variable>
  <xsl:variable name="varEndOfReport">*** End of report ***</xsl:variable>
  <xsl:variable name="varEntity">Entity</xsl:variable>
  <xsl:variable name="varImplement">Implement</xsl:variable>
  <xsl:variable name="vartable">table</xsl:variable>
  <xsl:variable name="varrelmem">relmem</xsl:variable>
  <xsl:variable name="varMNLinkTblwithForgnKeyRICons">M:N Link Table with Foreign Key RI constraints</xsl:variable>
  <xsl:variable name="varindexbasedForgnKey">an index based on a Foreign Key</xsl:variable>
  <xsl:variable name="varaForeignKey">a Foreign Key</xsl:variable>
  <xsl:variable name="varununknownimpl">an unknown implementation</xsl:variable>
  <xsl:variable name="varAttribute">Attribute</xsl:variable>
  <xsl:variable name="varDatacol">Data column</xsl:variable>
  <xsl:variable name="varForeignKeycol">Foreign Key column</xsl:variable>
  <xsl:variable name="varDenormalizedcol">Denormalized column</xsl:variable>
  <xsl:variable name="varCountCol">Count Column</xsl:variable>
  <xsl:variable name="varpartition">partition</xsl:variable>
  <xsl:variable name="varsubtype">subtype</xsl:variable>
  <xsl:variable name="varattribute">attribute</xsl:variable>

  <xsl:template match="/">
      
   <DIV STYLE="background-color:white; left:10; position:relative; font-size: 10pt">
	<h1 style="left:100; position:relative">
		<xsl:value-of select="Report/title"/></h1>
	<h3><xsl:copy-of select="$varModelName"/> <span style="left:20; position:relative"><xsl:value-of select="Report/modelname"/></span></h3>
	<h3><xsl:copy-of select="$varSubset"/>  <span style="left:20; position:relative"><xsl:value-of select="Report/subset"/></span></h3>
	<h3><xsl:value-of select="Report/datetime"/></h3>
	<h3></h3>
	<h3></h3>
     <xsl:apply-templates select="Report"/>
   	<b style="left:100; position:relative"><xsl:copy-of select="$varEndOfReport"/></b>
   </DIV>

  </xsl:template>
  
  <xsl:template match="Report">
	<xsl:apply-templates select="THLENT" />
  </xsl:template>

  <xsl:template match="THLENT">
	<ul style="left:10; position:relative"><b><xsl:copy-of select="$varEntity" /></b>
		<span style="left:20; position:relative"><xsl:value-of select="@NAME" /></span>
		<ul style="left:10; position:relative"><b><xsl:copy-of select="$varImplement" /></b>
			<span style="left:20; position:relative"><xsl:value-of select="substring-after(@IMPLMNTB,':')" /></span>
			<span style="left:40; position:relative"><b><xsl:copy-of select="$vartable" /></b></span>
		</ul>
		<xsl:apply-templates select="TRELMM" />
		<xsl:apply-templates select="TATTRUSR" />
		<xsl:apply-templates select="TPART" />
	</ul>
  </xsl:template>

  <xsl:template match="TRELMM">
	<ul style="left:10; position:relative"><b><xsl:copy-of select="$varrelmem" /></b>
		<span style="left:20; position:relative"><xsl:value-of select="@NAME" /></span>
		<span style="left:30; position:relative"><xsl:value-of select="@DENTY" /></span>
		<ul style="left:10; position:relative"><b><xsl:copy-of select="$varImplement" /></b>
		<span style="left:15; position:relative">
		<xsl:choose>
			<xsl:when test="@RELPRTIM[.='TRELIMMN']"><b><xsl:copy-of select="$varMNLinkTblwithForgnKeyRICons" /></b></xsl:when>
			<xsl:when test="@RELPRTIM[.='TRELIMEP']"><b><xsl:copy-of select="$varindexbasedForgnKey" /></b></xsl:when>
			<xsl:when test="@RELPRTIM[.='TRELIMFK']"><b><xsl:copy-of select="$varaForeignKey" /></b></xsl:when>
			<xsl:otherwise><span style="left:40; position:relative"><b><xsl:copy-of select="$varununknownimpl" /></b></span></xsl:otherwise>
		</xsl:choose>
		</span>
		</ul>
	</ul>
  </xsl:template>

  <xsl:template match="TATTRUSR">
	<ul style="left:10; position:relative"><b><xsl:copy-of select="$varAttribute" /></b>
		<span style="left:20; position:relative"><xsl:value-of select="@NAME" /></span>
		<xsl:apply-templates select="IMPLNTBY" />
	</ul>
  </xsl:template>

  <xsl:template match="IMPLNTBY">
	<ul style="left:5; position:relative"><b><xsl:copy-of select="$varImplement" /></b>
		<span style="left:10; position:relative"><xsl:value-of select="@DFIELD" /></span>
		<span style="left:15; position:relative"><b>
		<xsl:choose>
			<xsl:when test="@ROLEFLD[.='P']"><xsl:copy-of select="$varDatacol" /></xsl:when>
			<xsl:when test="@ROLEFLD[.='F']"><xsl:copy-of select="$varForeignKeycol" /></xsl:when>
			<xsl:when test="@ROLEFLD[.='D']"><xsl:copy-of select="$varDenormalizedcol" /></xsl:when>
			<xsl:otherwise><xsl:copy-of select="$varCountCol" /></xsl:otherwise>
		</xsl:choose>
		</b></span>
		<span style="left:20; position:relative"><xsl:value-of select="@TRECDATA" /></span>
		<span style="left:30; position:relative"><b><xsl:copy-of select="$vartable" /></b></span>
	</ul>
  </xsl:template>
  
  <xsl:template match="TPART">
	<ul style="left:10; position:relative"><b><xsl:copy-of select="$varpartition" /></b>
		<span style="left:20; position:relative"><xsl:value-of select="TATTRUSR/@NAME" /></span>
		<xsl:apply-templates select="TENTSU" />
	</ul>
  </xsl:template>

  <xsl:template match="TENTSU">
	<ul style="left:10; position:relative"><b><xsl:copy-of select="$varsubtype" /></b>
		<span style="left:20; position:relative"><xsl:value-of select="@NAME" /></span>
		<xsl:for-each select="TATTRUSR">
			<ul style="left:10; position:relative"><b><xsl:copy-of select="$varattribute" /></b>
				<span style="left:20; position:relative"><xsl:value-of select="@NAME" /></span>
			</ul>
		</xsl:for-each>
		<xsl:apply-templates select="TPART" />
	</ul>
  </xsl:template>

</xsl:stylesheet>
