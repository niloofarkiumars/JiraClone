namespace JiraClone.Domain.ValueObjects;

public sealed class ProjectKey
{
    public string Value { get; }

    private ProjectKey(string value)
    {
        Value = value;
    }

    public static ProjectKey Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException(
                "Project key cannot be empty.",
                nameof(value));

        value = value.Trim().ToUpperInvariant();

        if (value.Length > 5)
            throw new ArgumentException(
                "Project key cannot be longer than 5 characters.",
                nameof(value));

        foreach (char c in value)
        {
            if (!char.IsLetterOrDigit(c))
                throw new ArgumentException(
                    "Project key can contain only letters and numbers.",
                    nameof(value));
        }

        return new ProjectKey(value);
    }

    public override string ToString()
    {
        return Value;
    }
}