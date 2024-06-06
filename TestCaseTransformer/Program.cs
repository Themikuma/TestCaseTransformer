using System;
using System.IO;

namespace TestCaseTransformer
{
    class Program
    {
        static void Main(string[] args)
        {
            string basePath = "";//Set to base folder path.
            string inputPath = $"{basePath}input/input";
            string outputPath = $"{basePath}output/output";
            string format = "txt";
            int i = 0;
            int o = 0;
            var files = Directory.EnumerateFiles($"{basePath}/tests");
            Directory.CreateDirectory($"{basePath}input");
            Directory.CreateDirectory($"{basePath}output");
            foreach (var item in files)
            {
                if (item.EndsWith("in"))
                {
                    string path = $"{inputPath}{i}.{format}";
                    File.Copy(item, path, true);
                    i++;
                }
                else
                {
                    File.Copy(item, $"{outputPath}{o}.{format}", true);
                    o++;
                }
            }
        }
    }
}
