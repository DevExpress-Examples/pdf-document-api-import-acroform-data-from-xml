# How to import AcroForm data from XML


This example demonstrates how to import AcroForm data (interactive form data) from XML format to a PDF document.<br><br>You can also import the AcroForm data from FDF, XFDF, and TXT formats, as described below.<br><br>


<h3>Description</h3>

To import interactive forms from&nbsp;XML, FDF, XFDF,&nbsp;or TXT format to a PDF document: <br><br>- load a&nbsp;PDF document (e.g., from a file path), in which the data will be imported, using the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_LoadDocumenttopic">PdfDocumentProcessor.LoadDocument</a>&nbsp;method; <br>- call one of the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_Importtopic">PdfDocumentProcessor.Import</a>&nbsp;overloaded methods, for example, with a specified XML file that contains imported data;<br>- save the imported document using the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_SaveDocumenttopic">PdfDocumentProcessor.SaveDocument </a>&nbsp;method.

<br/>


