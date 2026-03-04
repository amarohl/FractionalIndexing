namespace FractionalIndexing;

public static class Challenge
{
    /// <summary>
    /// `GenerateDefaultFractionalIndices` returns an ordered list of `length` fractional index strings.
    /// 
    /// Each string is exactly 8 characters: a letter prefix, a base-62 number, `'f'` padding, and a final `'V'`.
    /// The prefix letter, starting at `'a'`, determines how many base-62 digits follow —
    /// one digit for `'a'`, two for `'b'`, three for `'c'`, and so on — with `'f'` characters filling the remainder to keep the total length fixed.
    /// Items fill each prefix group exhaustively before advancing to the next.
    /// It throws `ArgumentOutOfRangeException` for negative input.
    /// </summary>
    public static List<string> GenerateDefaultFractionalIndices(int length)
    {
        throw new NotImplementedException();
    }
}
