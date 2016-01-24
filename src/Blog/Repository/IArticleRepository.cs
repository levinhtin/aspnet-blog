using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;

namespace Blog.Repository
{
    public interface IArticleRepository
    {
        IEnumerable<Article> AllArticle { get; }
        void Add(Article item);
        Article GetById(int id);
        bool Delete(int id);
    }
}
