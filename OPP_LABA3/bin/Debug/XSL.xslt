<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" 
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
    <xsl:output method="html"/>
    <xsl:template match = "GuitarDataBase">
      <TABLE BORDER="5">
        <TR>
          <xsl:for-each select="//Guitar">
            <TR>
              <TD>
                <TABLE BORDER="5" WIDTH="1200">
                  
                </TABLE>
              </TD>
            </TR>
          </xsl:for-each>
        </TR>
      </TABLE>
    </xsl:template>
</xsl:stylesheet>
