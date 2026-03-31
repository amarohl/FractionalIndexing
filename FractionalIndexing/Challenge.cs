using System.Collections;
using System.Globalization;
using System.Xml;

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

       // bits is 62 bits to account for needing to return an empty array
    private static readonly char[] Bits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
    private const int FixedLength = 8;
    private const int SuffixLength = 1;      // final 'V'
    private const int PrefixLength = 1;      // 'a'..'f'
    private const int MaxDigitCount = 6;     // 'a' => 1, ..., 'f' => 6
    private const int MaxContentLength = FixedLength - PrefixLength - SuffixLength; // 6
    public static List<string>GenerateDefaultFractionalIndices(int length)
    {
        List<string> output = new List<string>(length);
        if (length < 0)
            throw new ArgumentOutOfRangeException(nameof(length));

        // var result = new List<string>(length);
        if (length == 0)
            output.Add(string.Empty);

        long[] pow62 = new long[MaxDigitCount + 1];
        pow62[0] = 1;
        for (int i = 1; i <= MaxDigitCount; i++)
            pow62[i] = pow62[i - 1] * Bits.Length;

        for (int prefixIdx = 0; prefixIdx < MaxDigitCount && output.Count < length; prefixIdx++)
        {
            int digitCount = prefixIdx + 1;      // a=1, b=2, ...
            long available = pow62[digitCount];
            long needed = length - output.Count;
            long toGenerate = Math.Min(available, needed);

            string prefix = ((char)('a' + prefixIdx)).ToString();
            int fillerCount = MaxContentLength - digitCount;

            for (long n = 0; n < toGenerate; n++)
            {
                Span<char> content = stackalloc char[digitCount];
                long value = n;
                for (int d = digitCount - 1; d >= 0; d--)
                {
                    int digit = (int)(value % Bits.Length);
                    content[d] = Bits[digit];
                    value /= Bits.Length;
                }

                var sb = new System.Text.StringBuilder(FixedLength);
                sb.Append(prefix);
                sb.Append(content);
                if (fillerCount > 0)
                    sb.Append('f', fillerCount);
                sb.Append('V');

                output.Add(sb.ToString());
            }
        }

        return output;
        throw new NotImplementedException();
    }       
}
