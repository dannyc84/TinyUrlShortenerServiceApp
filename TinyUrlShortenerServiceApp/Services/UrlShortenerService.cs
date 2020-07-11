using System.Linq;
using System.Text;
using TinyUrlShortenerService.Interfaces;

namespace TinyUrlShortenerService.Services
{
    public class UrlShortenerService : IUrlShortenerService
    {
        private static readonly string Alphabet = "abcdefghijklmnopqrstuvwxyz0123456789";
        private static readonly int Base = Alphabet.Length;

        /// <summary>
        /// Converts an identifier into a string
        /// </summary>
        /// <param name="id">the input identifier to be converted</param>
        /// <returns>the short string corresponding to the input identifier</returns>
        public string Encode(int id)
        {
            if (id == 0) 
                return Alphabet.FirstOrDefault().ToString();

            var sb = new StringBuilder();
            while (id > 0)
            {
                sb.Insert(0, Alphabet[id % Base]);
                id /= Base;
            }
            return sb.ToString();
        }

        /// <summary>
        /// Converts back a string into the original identifier
        /// </summary>
        /// <param name="str"> the input string to be converted</param>
        /// <returns> the ID corresponding to the input string</returns>
        public int Decode(string str)
        {
            var i = 0;

            foreach (var chr in str)
            {
                i = (i * Base) + Alphabet.IndexOf(chr);
            }

            return i;
        }
    }
}
