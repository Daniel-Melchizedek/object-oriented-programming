using System.Text;
namespace Acme.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Insert spaces before each Capitol Letter in a string.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
        {
            StringBuilder result = new (string.Empty);
            if (!string.IsNullOrWhiteSpace(source))
            {
                char previousCh=' ';
                foreach (char letter in source.ToCharArray())
                {
                    if ( char.IsUpper(letter) )
                    {
                        if(!previousCh.Equals(' '))
                        {
                            result.Append(" ");
                        }
                        
                    }
                        result.Append(letter);
                        previousCh = letter;
                }
            }
            return result.ToString();
        }

       
    }
}
