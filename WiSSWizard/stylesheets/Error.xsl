<?xml version="1.0" encoding="utf-8"?>
<!-- Edited by XMLSpy® -->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<xsl:template match="/">
  <html>
    <head>
      <style type="text/css">
        body {
        font-family: Arial, Helvetica, Geneva, SunSans-Regular, sans-serif;
        }
        h2 {font-family: Arial, Helvetica, Geneva, SunSans-Regular, sans-serif }
        h4 {
        font-family: Arial, Helvetica, Geneva, SunSans-Regular, sans-serif;
        margin:10px 0px 0px 0px;

        }

      </style>
    
    </head>
  <body>
    
  <h2>Fault Summary</h2>
      
    <table>
      <br />
      <tr>
        <td></td>
        
        <td WIDTH="300">
          <b>Configuration step:</b>
        </td>

        <td>
          <b>Fault report:</b>
        </td>
      </tr>
      <xsl:for-each select="ConfigClass/ErrorList/ConfigErrors">

        <tr>
          <td>
           <!--  <img scr= "error.png"/>-->
          </td>
          <td>
            <xsl:value-of select="ConfigError"/>
          </td>
          <td>
            <xsl:value-of select="ErrorMessage"/>
          </td>
        </tr>

      </xsl:for-each>

    </table>
    

  </body>
  </html>
</xsl:template>
</xsl:stylesheet>