using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CsvHelperDemo
{
public class ReadFile
{
    private string FilePath { get; set; }

    public ReadFile(string filePath)
    {
        FilePath = filePath;
    }

    public List<CsvContentModel> Get()
    {
        if (FilePath == null)
            return new List<CsvContentModel>();

        if (FilePath == "")
            return new List<CsvContentModel>();

        List<CsvContentModel> records = new List<CsvContentModel>();

        using (TextReader reader = File.OpenText(FilePath))
        {
            try
            {
                var csv = new CsvReader(reader);
                csv.Configuration.RegisterClassMap<CsvContentModelDefinitionMap>();
                records = csv.GetRecords<CsvContentModel>().ToList();
            }
            catch (CsvMissingFieldException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        return records;
    }
}
}
