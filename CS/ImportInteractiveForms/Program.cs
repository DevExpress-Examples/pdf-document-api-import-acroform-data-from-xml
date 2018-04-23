using DevExpress.Pdf;

namespace ImportInteractiveForms {
    class Program {
        static void Main(string[] args) {

            using (PdfDocumentProcessor processor = new PdfDocumentProcessor()) {

                // Load a PDF document with AcroForm data.
                processor.LoadDocument("..\\..\\EmptyForm.pdf");

                // Import AcroForm data from an XML file.
                processor.Import("..\\..\\InteractiveForm.xml");

                // Save the imported document.
                processor.SaveDocument("..\\..\\InteractiveForm.pdf");
            }
        }
    }
}
