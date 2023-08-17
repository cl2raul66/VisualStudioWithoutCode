namespace FlowToCSharpConverter.Models;

public class Document
{
    public Guid Id { get; private set; }
    public string Title { get; private set; }
    public string Code { get; private set; }

    public Document(Guid id, string title, string? code = null)
    {
        Id = id;
        Title = title;
        Code = string.IsNullOrEmpty(code) ? string.Empty : code;
    }
}
