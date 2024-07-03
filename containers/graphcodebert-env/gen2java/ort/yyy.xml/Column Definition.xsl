<?xml version="1.0" encoding="ISO-8859-9"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">

    <xsl:variable name="varModelName">Model Name: </xsl:variable>
    <xsl:variable name="varSubset">Subset: </xsl:variable>
    <xsl:variable name="varEndOfReport">*** End of report ***</xsl:variable>
    <xsl:variable name="varEntityColon">Entity:</xsl:variable>
    <xsl:variable name="varAttributeColon">Attribute:</xsl:variable>
    <xsl:variable name="varnotimplemented">not implemented</xsl:variable>
    <xsl:variable name="varGenericColumnColon">Generic Column:</xsl:variable>
    <xsl:variable name="varSlashGenericTableColon">/Generic Table:</xsl:variable>
    <xsl:variable name="varImplementation">Implementation</xsl:variable>
    <xsl:variable name="varColumnColon">Column:</xsl:variable>
    <xsl:variable name="varSlashTableColon">/Table:</xsl:variable>
    <xsl:variable name="varFormatColon">Format:</xsl:variable>
    <xsl:variable name="varLengthColon">Length:</xsl:variable>
    <xsl:variable name="varDecimalColon">Decimal:</xsl:variable>
    <xsl:variable name="varOptionalityColon">Optionality:</xsl:variable>
    <xsl:variable name="varNotNull">Not Null</xsl:variable>
    <xsl:variable name="varNull">Null</xsl:variable>
    <xsl:variable name="varRoleColon">Role:</xsl:variable>
    <xsl:variable name="varData">Data</xsl:variable>
    <xsl:variable name="varForeignKey">Foreign Key</xsl:variable>
    <xsl:variable name="varDenormalized">Denormalized</xsl:variable>
    <xsl:variable name="varCount">Count</xsl:variable>
    <xsl:variable name="varUnknown">Unknown</xsl:variable>
    <xsl:variable name="varIdentifierColon">Identifier:</xsl:variable>
    <xsl:variable name="varIndexeswhichusedthiscolColon">Indexes which used this column:</xsl:variable>
    <xsl:variable name="varColumnnotusedinanyindexes">Column not used in any indexes</xsl:variable>
    <xsl:variable name="varColumnimplementsautonumber">Column implements an auto number attribute</xsl:variable>
    <xsl:variable name="varFieldProc">Field Procedure Exit Routine:</xsl:variable>
    <xsl:variable name="varParams">Parameters:</xsl:variable>
    <xsl:variable name="varStarting">Starting value:</xsl:variable>
    <xsl:variable name="varSeed">Seed value:</xsl:variable>
    <xsl:variable name="varIncrement">Increment by:</xsl:variable>
    <xsl:variable name="varMaximum">Maximum value:</xsl:variable>
    <xsl:variable name="varMinimum">Minimum value:</xsl:variable>
    <xsl:variable name="varCache">Values to cache:</xsl:variable>
    <xsl:variable name="varNoCache">Do not cache values</xsl:variable>
    <xsl:variable name="varCycle">Cycle values</xsl:variable>
    <xsl:variable name="varOrder">Order values</xsl:variable>
    <xsl:variable name="varNotForRep">Not for Replication</xsl:variable>
    <xsl:variable name="varUnitsKB">KB</xsl:variable>
    <xsl:variable name="varUnitsMB">MB</xsl:variable>
    <xsl:variable name="varUnitsGB">GB</xsl:variable>


    <xsl:template match="/">

    <DIV STYLE="background-color:white; left:10; position:relative; font-size: 10pt">
        <h1 style="left:100; position:relative">
            <xsl:value-of select="Report/title"/>
        </h1>
        <h3>
            <xsl:copy-of select="$varModelName"/>
            <span style="left:20; position:relative">
                <xsl:value-of select="Report/modelname"/>
            </span>
        </h3>
        <h3>
            <xsl:copy-of select="$varSubset"/>
            <span style="left:20; position:relative">
                <xsl:value-of select="Report/subset"/>
            </span>
        </h3>
        <h3>
            <xsl:value-of select="Report/datetime"/>
        </h3>
        <h3></h3>
        <h3></h3>
        <xsl:apply-templates select="Report"/>
        <b style="left:100; position:relative">
            <xsl:copy-of select="$varEndOfReport"/>
        </b>
    </DIV>

    </xsl:template>

    <xsl:template match="Report">
        <xsl:apply-templates select="THLENT" />
    </xsl:template>

    <xsl:template match="THLENT">
        <ul style="left:10; position:relative">
            <b>
                <xsl:copy-of select="$varEntityColon" />
            </b>
            <span style="left:20; position:relative">
                <xsl:value-of select="@NAME" />
            </span>
            <xsl:apply-templates select="TATTRUSR" />
            <xsl:apply-templates select="TENTSU" />
        </ul>
    </xsl:template>

    <xsl:template match="TATTRUSR">
        <ul style="left:10; position:relative">
            <b>
                <xsl:copy-of select="$varAttributeColon" />
            </b>
            <span style="left:20; position:relative">
                <xsl:value-of select="@NAME" />
            </span>
            <xsl:choose>
                <xsl:when test="IMPLNTBY">
                    <xsl:apply-templates select="IMPLNTBY" />
                </xsl:when>
                <xsl:otherwise>
                    <span style="left:40; position:relative">
                        <b>
                            <xsl:copy-of select="$varnotimplemented" />
                        </b>
                    </span>
                </xsl:otherwise>
            </xsl:choose>
        </ul>
    </xsl:template>

    <xsl:template match="IMPLNTBY">
        <ul style="left:5; position:relative">
            <b>
                <xsl:copy-of select="$varGenericColumnColon" />
            </b>
            <span style="left:10; position:relative">
                <xsl:value-of select="@DFIELD" />
            </span>
            <span style="left:15; position:relative">
                <b>
                    <xsl:copy-of select="$varSlashGenericTableColon" />
                </b>
            </span>
            <span style="left:20; position:relative">
                <xsl:value-of select="@DRECDATA" />
            </span>
        </ul>
        <ul style="left:5; position:relative">
            <b>
                <xsl:value-of select="@DBMS" />
            </b>
            <span style="left:10; position:relative">
                <b>
                    <xsl:copy-of select="$varImplementation" />
                </b>
            </span>
            <ul style="left:5; position:relative">
                <b>
                    <xsl:copy-of select="$varColumnColon" />
                </b>
                <span style="left:10; position:relative">
                    <xsl:value-of select="@DFIELDDB" />
                </span>
                <span style="left:15; position:relative">
                    <b>
                        <xsl:copy-of select="$varSlashTableColon" />
                    </b>
                </span>
                <span style="left:20; position:relative">
                    <xsl:value-of select="@DRECDATADB" />
                </span>
            </ul>
            <ul style="left:5; position:relative">
                <b>
                    <xsl:copy-of select="$varFormatColon" />
                </b>
                <span style="left:10; position:relative">
                    <xsl:value-of select="@FORMAT" />
                </span>
            </ul>
            <ul style="left:5; position:relative">
                <b>
                    <xsl:copy-of select="$varLengthColon" />
                </b>
                <span style="left:10; position:relative">
                    <xsl:value-of select="@LENGTH" />
                </span>
                <xsl:choose>
                    <xsl:when test="@UNITS[.='K']"><span style="left:15; position:relative"><xsl:copy-of select="$varUnitsKB" /></span></xsl:when>
                    <xsl:when test="@UNITS[.='M']"><span style="left:15; position:relative"><xsl:copy-of select="$varUnitsMB" /></span></xsl:when>
                    <xsl:when test="@UNITS[.='G']"><span style="left:15; position:relative"><xsl:copy-of select="$varUnitsGB" /></span></xsl:when>
                </xsl:choose>
            </ul>
            <ul style="left:5; position:relative">
                <b>
                    <xsl:copy-of select="$varDecimalColon" />
                </b>
                <span style="left:10; position:relative">
                    <xsl:value-of select="@DECPLCFL" />
                </span>
            </ul>
            <ul style="left:5; position:relative">
                <b>
                    <xsl:copy-of select="$varOptionalityColon" />
                </b>
                <span style="left:10; position:relative">
                    <xsl:choose>
                        <xsl:when test="@OPTDB2">
                            <xsl:choose>
                                <xsl:when test="@OPTDB2[.!=''] and @OPTDB2[.!='O']">
                                    <xsl:copy-of select="$varNotNull" />
                                </xsl:when>
                                <xsl:otherwise>
                                    <xsl:copy-of select="$varNull" />
                                </xsl:otherwise>
                            </xsl:choose>
                        </xsl:when>
                        <xsl:when test="@OPTDBMS and @OPTDBMS[.!=''] or @OPTDBMS[.!='']">
                            <xsl:choose>
                                <xsl:when test="@OPTDBMS[.!=''] and @OPTDBMS[.!='O']">
                                    <xsl:copy-of select="$varNotNull" />
                                </xsl:when>
                                <xsl:otherwise>
                                    <xsl:copy-of select="$varNull" />
                                </xsl:otherwise>
                            </xsl:choose>
                        </xsl:when>
                        <xsl:otherwise>
                            <xsl:copy-of select="$varNull" />
                        </xsl:otherwise>
                    </xsl:choose>
                </span>
            </ul>
            <ul style="left:5; position:relative">
                <b>
                    <xsl:copy-of select="$varRoleColon" />
                </b>
                <span style="left:10; position:relative">
                    <xsl:choose>
                        <xsl:when test="@ROLEFLD[.='P']">
                            <xsl:copy-of select="$varData" />
                        </xsl:when>
                        <xsl:when test="@ROLEFLD[.='F']">
                            <xsl:copy-of select="$varForeignKey" />
                        </xsl:when>
                        <xsl:when test="@ROLEFLD[.='D']">
                            <xsl:copy-of select="$varDenormalized" />
                        </xsl:when>
                        <xsl:when test="@ROLEFLD[.='C']">
                            <xsl:copy-of select="$varCount" />
                        </xsl:when>
                        <xsl:otherwise>
                            <xsl:copy-of select="$varUnknown" />
                        </xsl:otherwise>
                    </xsl:choose>
                </span>
            </ul>
            <ul style="left:5; position:relative">
                <b>
                    <xsl:copy-of select="$varIdentifierColon" />
                </b>
                <span style="left:10; position:relative">
                    <xsl:value-of select="@TIDENT" />
                </span>
            </ul>

            <xsl:choose>
                <xsl:when test="@FIELDPRC">
                    <ul style="left:5; position:relative">
                        <b>
                            <xsl:copy-of select="$varFieldProc" />
                        </b>
                        <span style="left:20; position:relative">
                            <xsl:value-of select="@FIELDPRC"/>
                        </span>
                    </ul>
                </xsl:when>
            </xsl:choose>
            <xsl:choose>
                <xsl:when test="@PARMS">
                    <ul style="left:5; position:relative">
                        <b>
                            <xsl:copy-of select="$varParams" />
                        </b>
                        <span style="left:20; position:relative">
                            <xsl:value-of select="@PARMS"/>
                        </span>
                    </ul>
                </xsl:when>
            </xsl:choose>


            <ul style="left:5; position:relative">
                <span>
                    <xsl:choose>
                        <xsl:when test="TFLDEPUS">
                            <b>
                                <xsl:copy-of select="$varIndexeswhichusedthiscolColon" />
                            </b>
                            <xsl:apply-templates select="TFLDEPUS" />
                        </xsl:when>
                        <xsl:otherwise>
                            <b>
                                <xsl:copy-of select="$varColumnnotusedinanyindexes" />
                            </b>
                        </xsl:otherwise>
                    </xsl:choose>
                </span>
            </ul>
            <xsl:choose>
                <xsl:when test="@AUTONUMBER[.='Y']">
                    <ul style="left:5; position:relative">
                        <b>
                            <xsl:copy-of select="$varColumnimplementsautonumber" />
                        </b>
                    </ul>
                    <xsl:choose>
                        <xsl:when test="@STARTING">
                            <ul style="left:20; position:relative">
                                <b>
                                    <xsl:copy-of select="$varStarting" />
                                </b>
                                <span style="left:10; position:relative">
                                    <xsl:value-of select="@STARTING"/>
                                </span>
                            </ul>
                        </xsl:when>
                    </xsl:choose>
                    <xsl:choose>
                        <xsl:when test="@SEED">
                            <ul style="left:20; position:relative">
                                <b>
                                    <xsl:copy-of select="$varSeed" />
                                </b>
                                <span style="left:10; position:relative">
                                    <xsl:value-of select="@SEED"/>
                                </span>
                            </ul>
                        </xsl:when>
                    </xsl:choose>
                    <xsl:choose>
                        <xsl:when test="@INCREMENT">
                            <ul style="left:20; position:relative">
                                <b>
                                    <xsl:copy-of select="$varIncrement" />
                                </b>
                                <span style="left:10; position:relative">
                                    <xsl:value-of select="@INCREMENT"/>
                                </span>
                            </ul>
                        </xsl:when>
                    </xsl:choose>
                    <xsl:choose>
                        <xsl:when test="@MINIMUM">
                            <ul style="left:20; position:relative">
                                <b>
                                    <xsl:copy-of select="$varMinimum" />
                                </b>
                                <span style="left:10; position:relative">
                                    <xsl:value-of select="@MINIMUM"/>
                                </span>
                            </ul>
                        </xsl:when>
                    </xsl:choose>
                    <xsl:choose>
                        <xsl:when test="@MAXIMUM">
                            <ul style="left:20; position:relative">
                                <b>
                                    <xsl:copy-of select="$varMaximum" />
                                </b>
                                <span style="left:10; position:relative">
                                    <xsl:value-of select="@MAXIMUM"/>
                                </span>
                            </ul>
                        </xsl:when>
                    </xsl:choose>
                    <xsl:choose>
                        <xsl:when test="@CACHE">
                            <xsl:choose>
                                <xsl:when test="@CACHE[.='0']">
                                    <!-- Do Nothing -->
                                </xsl:when>
                                <xsl:when test="@CACHE[.='1']">
                                    <ul style="left:20; position:relative">
                                        <b>
                                            <xsl:copy-of select="$varNoCache" />
                                        </b>
                                    </ul>
                                </xsl:when>
                                <xsl:otherwise>
                                    <ul style="left:20; position:relative">
                                        <b>
                                            <xsl:copy-of select="$varCache" />
                                        </b>
                                        <span style="left:10; position:relative">
                                            <xsl:value-of select="@CACHE"/>
                                        </span>
                                    </ul>
                                </xsl:otherwise>
                            </xsl:choose>
                        </xsl:when>
                    </xsl:choose>
                    <xsl:choose>
                        <xsl:when test="@CYCLE">
                            <ul style="left:20; position:relative">
                                <b>
                                    <xsl:copy-of select="$varCycle" />
                                </b>
                            </ul>
                        </xsl:when>
                    </xsl:choose>
                    <xsl:choose>
                        <xsl:when test="@ORDER">
                            <ul style="left:20; position:relative">
                                <b>
                                    <xsl:copy-of select="$varOrder" />
                                </b>
                            </ul>
                        </xsl:when>
                    </xsl:choose>
                    <xsl:choose>
                        <xsl:when test="@NOTFORREP">
                            <ul style="left:20; position:relative">
                                <b>
                                    <xsl:copy-of select="$varNotForRep" />
                                </b>
                            </ul>
                        </xsl:when>
                    </xsl:choose>
                </xsl:when>
            </xsl:choose>
        </ul>
    </xsl:template>

    <xsl:template match="TFLDEPUS">
        <ul style="left:1; position:relative">
            <xsl:value-of select="@NAME" />
        </ul>
    </xsl:template>

</xsl:stylesheet>
