using Core.Data;
using Core.Data.Repositories;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PreguntasDBContext _context;

        public UnitOfWork(PreguntasDBContext context)
        {
            _context = context;
        }

        private ScoreRepository _scoreRepository;
        private UserRepository _userRepository;
        private QuestionRepository _questionRepository;
        private CategoryRepository _categoryRepository;
        private GameRepository _gameRepository;

        public IScoreRepository ScoreRepository => _scoreRepository ??= new ScoreRepository(_context);
        public IUserRepository UserRepository => _userRepository ??= new UserRepository(_context);
        public IQuestionRepository QuestionRepository => _questionRepository ??= new QuestionRepository(_context);
        public ICategoryRepository CategoryRepository => _categoryRepository ??= new CategoryRepository(_context);
        public IGameRepository GameRepository => _gameRepository ??= new GameRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
