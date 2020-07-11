using System;
using TinyUrlShortenerService.Interfaces;

namespace TinyUrlShortenerService
{
    public class TinyUrlShortenerApp
    {
        private readonly IUrlShortenerService _urlShortenerService;

        public TinyUrlShortenerApp(IUrlShortenerService urlShortenerService)
        {
            _urlShortenerService = urlShortenerService;
        }

        public void Run(string[] args)
        {
            if (args is null)
                throw new ArgumentNullException();

            else if (args.Length != 1)
                throw new ArgumentException("The number of arguments must be only one");

            if (int.TryParse(args[0], out int urlId))
            {
                var encodedUrl = _urlShortenerService.Encode(urlId);
                Console.WriteLine($"Encoded URL: {encodedUrl}");
                var decodedUrl = _urlShortenerService.Decode(encodedUrl);
                Console.WriteLine($"Decoded URL : {decodedUrl}");
            }
            Console.WriteLine("Attempted conversion of '{0}' failed.",
                               args[0] ?? "<null>");
        }
    }
}
