
using System.Security.Claims;
using System.Text;

internal class Program
{
    const bool AUTODETECTAR_CODIFICACION_BOM = true;
    public void LeerFichero()
    {
        const bool AÑADIR_AL_FINAL = true;
        StreamReader sr = new StreamReader("vocabulario.txt", Encoding.UTF8, AÑADIR_AL_FINAL);
    }
    public void EscribirFichero()
    {
        FileStream stream = new("vocabulario.txt", FileMode.Open, FileAccess.Read);
        StreamWriter sw = new StreamWriter(stream, Encoding.UTF8);
    }

    public static void GenerarDiccionarioTxt(Dictionary<string, string> diccionario, string rutaArchivo)
    {
        using (StreamWriter writer = new StreamWriter(rutaArchivo, false, Encoding.UTF8))
        {
            foreach (var entrada in diccionario)
            {
                writer.WriteLine($"{entrada.Key}: {entrada.Value}");
            }
        }
        Console.WriteLine($"Diccionario guardado en '{rutaArchivo}'");
    }
    private static void Main(string[] args)
    {
        StreamReader sr = new StreamReader("vocabulario.txt", Encoding.UTF8, AUTODETECTAR_CODIFICACION_BOM);
        // Leo línea a línea hasta final de fichero y la muestro por consola.
        while(!sr.EndOfStream)
            Console.WriteLine(sr.ReadLine());
        sr.Close();

        var diccionario = new Dictionary<string, string>
        {
            { "Program", "Clase principal donde se define la lógica del programa." },
            { "AUTODETECTAR_CODIFICACION_BOM", "Constante booleana que indica si se debe detectar automáticamente la codificación BOM (Byte Order Mark) al leer el archivo." },
            { "LeerFichero", "Método que se encarga de leer el archivo 'vocabulario.txt'." },
            { "AÑADIR_AL_FINAL", "Constante booleana que se pasa al StreamReader, aunque en este contexto parece mal utilizada (no corresponde al tercer parámetro de ese constructor en versiones actuales de .NET)." },
            { "StreamReader", "Clase usada para leer caracteres desde un archivo de texto." },
            { "StreamWriter", "Clase usada para escribir caracteres en un archivo de texto." },
            { "FileStream", "Clase que proporciona una secuencia para archivos, usada para acceso de bajo nivel." },
            { "Encoding.UTF8", "Especifica que la codificación utilizada es UTF-8, útil para caracteres especiales." },
            { "FileMode.Open", "Modo de apertura del archivo; en este caso, indica que se debe abrir un archivo existente." },
            { "FileAccess.Read", "Indica que el archivo se abre solo para lectura." },
            { "EscribirFichero", "Método que prepara la escritura en el archivo 'vocabulario.txt'." },
            { "Main", "Método principal de ejecución del programa." },
            { "args", "Parámetro que contiene los argumentos de línea de comandos pasados al programa." },
            { "Console.WriteLine", "Método que imprime una línea de texto en la consola." },
            { "sr.Close()", "Método que cierra el lector de archivos y libera recursos." },
            { "sr.EndOfStream", "Propiedad que indica si se ha alcanzado el final del archivo." }
        };
    }
}
