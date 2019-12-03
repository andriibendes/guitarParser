<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="html"/>
  <xsl:template match="/">
    <html>
      <body>
        <!-- tut border -->
        <table border="10">
          <TR>
            <th>NAME</th>
            <th>TYPE</th>
            <th>BRAND</th>
            <th>BODY</th>
            <th>MATERIAL</th>
            <th>COUNTRY</th>
          </TR>
          <xsl:for-each select="GuitarDataBase/Guitar">
            <tr>
              <td>
                <xsl:value-of select="@NAME"/>
              </td>
              <td>
                <xsl:value-of select="@TYPE"/>
              </td>
              <td>
                <xsl:value-of select="@BRAND"/>
              </td>
              <td>
                <xsl:value-of select="@BODY"/>
              </td>
              <td>
                <xsl:value-of select="@MATERIAL"/>
              </td>
              <td>
                <xsl:value-of select="@COUNTRY"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
