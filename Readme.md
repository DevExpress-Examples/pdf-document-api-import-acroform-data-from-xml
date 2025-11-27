<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595584/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T491383)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# PDF Document API - Import Interactive Form Data from an XML File

This example demonstrates how to import AcroForm data (interactive form data) from XML format to a PDF document. You can also import the AcroForm data from FDF, XFDF, and TXT formats, as described below.

>[!IMPORTANT]
> You need a license for the **DevExpress Office File API Subscription** or **DevExpress Universal Subscription** to use the libraries listed below in production code.

## Implementation Details

To import interactive forms from XML, FDF, XFDF, or TXT format to a PDF document:
-  Call the [PdfDocumentProcessor.LoadDocument](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor.LoadDocument.overloads) method to load a PDF document (e.g., from a file path), in which the data will be imported.
- Call one of the [PdfDocumentProcessor.Import](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor.Import.overloads) overloaded methods, for example, with a specified XML file that contains imported data.
- Use the [PdfDocumentProcessor.SaveDocument](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor.SaveDocument.overloads) method to save the imported document.

## Files to Review

* [Program.cs](./CS/ImportInteractiveForms/Program.cs) (VB: [Program.vb](./VB/ImportInteractiveForms/Program.vb))

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pdf-document-api-import-acroform-data-from-xml&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pdf-document-api-import-acroform-data-from-xml&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
