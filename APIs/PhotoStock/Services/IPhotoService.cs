using PhotoStock.Entity;

namespace PhotoStock.Services
{
    public interface IPhotoService
    {
        Task<(bool IsSuccess, Exception Exception)> InsertPhotoAsync(Photo photo);
        Task<(bool IsSuccess, Exception Exception)> UpdateCommentAsync(Photo photo);
        Task<(bool IsSuccess, Exception Exception)> DeleteCommentAsync(Photo photo);
        Task<List<Photo>> GetPhotosByPostId(Guid Id);
    }
}