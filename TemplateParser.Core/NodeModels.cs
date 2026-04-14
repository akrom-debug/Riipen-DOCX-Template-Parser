using DocumentFormat.OpenXml.Office2010.Excel;

namespace TemplateParser.Core;

public sealed class Node
{
    public Guid Id { get; set; }


    public Guid TemplateId { get; set; }


    public Guid? ParentId { get; set; }

    public string Type { get; set; } = string.Empty;

    

    public string Title { get; set; } = string.Empty;

    public int OrderIndex { get; set; }

    public string MetadataJson { get; set; } = "{}";


}
