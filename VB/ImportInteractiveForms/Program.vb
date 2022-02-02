Imports DevExpress.Pdf

Namespace ImportInteractiveForms

    Friend Class Program

        Shared Sub Main(ByVal args As String())
            Using processor As PdfDocumentProcessor = New PdfDocumentProcessor()
                ' Load a PDF document with AcroForm data.
                processor.LoadDocument("..\..\EmptyForm.pdf")
                ' Import AcroForm data from an XML file.
                processor.Import("..\..\InteractiveForm.xml")
                ' Save the imported document.
                processor.SaveDocument("..\..\InteractiveForm.pdf")
            End Using
        End Sub
    End Class
End Namespace
