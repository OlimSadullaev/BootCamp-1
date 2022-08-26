using Microsoft.EntityFrameworkCore;
using PhotoStock.Data;
using PhotoStock.Entity;

namespace PhotoStock.Services
{
    public class PhotoService : IPhotoService
    {
        private readonly PhotoApiDbContext _ctx;

        public PhotoService(PhotoApiDbContext context) => _ctx = context;

        public Task<(bool IsSuccess, Exception Exception)> DeleteCommentAsync(Photo photo)
        {
            throw new NotImplementedException();
        }

        public async Task<(bool IsSuccess, Exception Exception)> DeletePhotoAsync(Photo photo)
        {
            try
            {
                _ctx.Photos.Remove(photo);
                _ctx?.SaveChangesAsync();
                return (true, null);
            }
            catch (Exception ex)
            {
                return (false, ex);
            }
        }

        public Task<Photo?> GetPhotoById(Guid id)
        => _ctx.Photos.FirstOrDefaultAsync(c => c.Id == id);

        public Task<List<Photo>> GetPhotosByPostId(Guid Id)
        => _ctx.Photos
            .AsNoTracking()
            .Where(c => c.Id == Id)
            .ToListAsync();

        public async Task<(bool IsSuccess, Exception Exception)> InsertPhotoAsync(Photo phoot)
        {
            try
            {
                await _ctx.Photos.AddAsync(phoot);
                await _ctx.SaveChangesAsync();
                return (true, null);
            }
            catch (Exception e)
            {
                return (false, e);
            }
        }

        public async Task<(bool IsSuccess, Exception Exception)> UpdatePhotoAsync(Photo photo)
        {
            try
            {
                _ctx.Photos.Update(photo);
                await _ctx.SaveChangesAsync();
                return (true, null);
            }
            catch (Exception e)
            {
                return (false, e);
            }
        }

        Task<(bool IsSuccess, Exception Exception)> IPhotoService.UpdateCommentAsync(Photo photo)
        {
            throw new NotImplementedException();
        }
    }
}
