global using PhotoStock.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PhotoStock.Services
{
    public class TextService : ITextService
    {
        private readonly PhotoApiDbContext _text;

        public TextService(PhotoApiDbContext text)
        {
            _text = text;
        }

        public async Task<(bool IsSuccess, Exception Exception)> InsertTextAsync(Text text)
        {
            try
            {
                await _text.Texts.AddAsync(text);
                await _text.SavechangesAsync();
                return (true, null);
            }
            catch (Exception ex)
            {
                return (false, ex);
            }   
        }

        public async Task<(bool IsSuccess, Exception Exception)> UpdateTextAsync(Text text)
        {
            try
            {
                _text.Texts.AddAsync(text);
                await _text.SavechangesAsync();
                return (true, null);
            }
            catch(Exception ex)
            {
                return (false, ex);
            }
        }
    }
}
