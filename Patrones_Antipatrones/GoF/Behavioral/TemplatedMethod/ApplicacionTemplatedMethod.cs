namespace GoF.Behavioral.TemplatedMethod
{
    public class ApplicacionTemplatedMethod
    {
        public void Test()
        {
            DocumentProcessor pdfProcessor = new PDFDocumentProcessor();
            DocumentProcessor wordProcessor = new WordDocumentProcessor();

            Console.WriteLine("Procesandp documento PDF:");
            pdfProcessor.ProcessDocument();

            Console.WriteLine("\nProcesando documento Word:");
            wordProcessor.ProcessDocument();
        }
    }
}
