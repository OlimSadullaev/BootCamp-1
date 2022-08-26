using static System.Net.Mime.MediaTypeNames;

namespace PhotoStock.Services
{
    public interface ITextService
    {
        Task<(bool IsSuccess, Exception Exception)> InsertTextAsync(Text text);
        Task<(bool IsSuccess, Exception Exception)> UpdateTextAsync(Text text);
    }
}