using System;

public sealed class Email: IEquatable <Email> // If we
{
	public string Value { get; } //readonly property //due rule constraints

    public Email( string value)
	{
		Value = value;
        // to access the value outside the class you use Email.Value
    }
    public static Email CreateEmail(string value) // static direct invocation
    {
        // Add validation logic here if needed
        return new Email(value);
    }

    //public override bool Equals(object? obj) 
    //{
    //    return Equals(obj as Email);
    //}
    //public bool Equals(Email? other)
    //{
    //    return other != null &&
    //           Value == other.Value;
    //}
    //public override int GetHashCode()
    //{
    //    return HashCode.Combine(Value);
    //}

}
