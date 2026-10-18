using Contoso.Csv;

namespace Demo;

public class ReportExporter
{
    public string Export(IEnumerable<IEnumerable<string>> rows)
    {
        using var writer = new StringWriter();
        foreach (var row in rows)
        {
            CsvWriter.WriteRow(writer, row);
        }
        return writer.ToString();
    }
}
