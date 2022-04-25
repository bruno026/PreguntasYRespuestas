using Core.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    public interface IUnitOfWork : IDisposable
    {
        public IScoreRepository ScoreRepository { get; }
        public IUserRepository UserRepository { get; }
        public IQuestionRepository QuestionRepository { get; }
        public ICategoryRepository CategoryRepository { get; }
        public IGameRepository GameRepository  { get; }

        Task<int> CommitAsync();

    }
}
