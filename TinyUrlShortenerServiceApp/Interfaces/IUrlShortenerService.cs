namespace TinyUrlShortenerService.Interfaces
{
    public interface IUrlShortenerService
    {
        int Decode(string str);

        string Encode(int num);
    }
}