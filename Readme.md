<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595584/16.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T491383)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# PDF Document API - Import Interactive Form Data from an XML File


This example demonstrates how to import AcroForm data (interactive form data) from XML format to a PDF document. You can also import the AcroForm data from FDF, XFDF, and TXT formats, as described below.


## Implementation Details

To import interactive forms from XML, FDF, XFDF, or TXT format to a PDF document: 
-  Call the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_LoadDocumenttopic">PdfDocumentProcessor.LoadDocument</a> method to load a PDF document (e.g., from a file path), in which the data will be imported.
- Call one of the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_Importtopic">PdfDocumentProcessor.Import</a> overloaded methods, for example, with a specified XML file that contains imported data.
- Use the <a href="https://documentation.devexpress.com/#DocumentServer/DevExpressPdfPdfDocumentProcessor_SaveDocumenttopic">PdfDocumentProcessor.SaveDocument </a> method to save the imported document.

## Files to Review 

* [Program.cs](./CS/ImportInteractiveForms/Program.cs) (VB: [Program.vb](./VB/ImportInteractiveForms/Program.vb))

