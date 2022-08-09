using System;
using System.IO;

namespace CleanPathFiles
{
    class Program
    {
        private static string _path = AppDomain.CurrentDomain.BaseDirectory;
        private static DateTime _dateTime = DateTime.Now.AddMonths(-1);
        
        static void ReadPath()
        {
            DirectoryInfo diretorio = new DirectoryInfo(_path);
            FileInfo[] Arquivos = diretorio.GetFiles("*.zip");

            //Começamos a listar os arquivos
            foreach (FileInfo fileinfo in Arquivos)
            {
                string mes = Convert.ToString(_dateTime.Month);
                string param = $"M{mes.PadLeft(2, '0')}";
                int file = fileinfo.Name.IndexOf($"M{mes.PadLeft(2, '0')}");
                //Console.WriteLine($"{fileinfo.Name.Substring(0, 13)}");

                //Console.WriteLine($"{fileinfo.Name.IndexOf($"M{mes.PadLeft(2, '0')}")}");
                //Console.WriteLine(file);

                if(file > 0)
                {
                    Console.WriteLine($"{fileinfo.Name} - size: {fileinfo.Name.Length} - M{mes.PadLeft(2, '0')} - Apagado");
                    File.Delete(Path.Combine($"{_path}", fileinfo.Name));
                }
            }
        } 

        static void Main(string[] args)
        {
            ReadPath();
            Console.WriteLine("Hello World!");
        }
    }
}
