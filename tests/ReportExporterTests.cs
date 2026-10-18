using Demo;
using Xunit;

public class ReportExporterTests
{
    [Fact]
    public void Export_WritesPlainRow()
    {
        var csv = new ReportExporter().Export(new[] { new[] { "a", "b" } });
        Assert.Equal("a,b", csv.TrimEnd());
    }

    [Fact]
    public void Export_QuotesCommas()
    {
        var csv = new ReportExporter().Export(new[] { new[] { "a,b", "c" } });
        Assert.Equal("\"a,b\",c", csv.TrimEnd());
    }
}
