using System;
using System.Collections;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
        Task<AppUser> GetUserWithLikes(int userId);
        Task<IEnumerable> GetUserLikes(string predicate, int userId);
    }
}
