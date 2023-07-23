using System.Text.RegularExpressions;
namespace Concepts.MysterySolving;
public partial record MysteryId
{
    private readonly string _value;
    public MysteryId(string value)
    {
        if (string.IsNullOrEmpty(value) || !MysteryIdRegex().IsMatch(value)) throw new ArgumentException("MysteryIDが不正です");
        this._value = value;
    }
    [GeneratedRegex("^mst-mystery-[0-9]+$")]
    private static partial Regex MysteryIdRegex();

}