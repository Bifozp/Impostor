using System.Globalization;

namespace Impostor.Api.Innersloth
{
    public static class TextBox
    {
        public static bool IsCharAllowed(char i)
        {
            switch (char.GetUnicodeCategory(i))
            {
                // 英字
                case UnicodeCategory.LowercaseLetter:
                case UnicodeCategory.UppercaseLetter:
                // 数字
                case UnicodeCategory.DecimalDigitNumber:
                case UnicodeCategory.LetterNumber:
                // 文字・修飾子
                case UnicodeCategory.TitlecaseLetter:
                case UnicodeCategory.OtherLetter:
                case UnicodeCategory.ModifierLetter:
                case UnicodeCategory.OtherSymbol:
                case UnicodeCategory.ModifierSymbol:
                case UnicodeCategory.SpaceSeparator:
                case UnicodeCategory.OtherPunctuation:
                    return true;
            }

            System.Console.WriteLine(char.GetUnicodeCategory(i));
            return false;
        }
    }
}
