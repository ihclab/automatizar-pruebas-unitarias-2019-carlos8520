class TestClass
{
    static void Main(string[] args)
    {
        readFile();
    }
    private string readFile(string txt) {
            var fileStream = new FileStream(@"/Users/dcl22n15/Desktop/automatizar-pruebas-unitarias-2019-carlos8520/CasosPrueba.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
            txt = streamReader.ReadToEnd();
            }
        }
}