

namespace BrosEngine.Registry;

class IdentifiableString {
    private readonly string Owner;
    private readonly string Value;

    public IdentifiableString(string owner, string value) {
        Owner = owner;
        Value = value;
    }

    public string GetOwner() => Owner;
    public string GetValue() => Value;

    public override string ToString() => Owner + ":"+ Value;
}