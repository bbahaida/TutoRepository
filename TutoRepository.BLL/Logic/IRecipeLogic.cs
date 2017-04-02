using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TutoRepository.BLL.Logic
{
    public interface IRecipeLogic
    {
        Recipe Get(int id);
        IEnumerable<Recipe> GetAll();
        IEnumerable<Recipe> Find(Expression<Func<Recipe, bool>> predicate);
        void Add(Recipe recipe);
        void AddRange(IEnumerable<Recipe> recipes);
        void Remove(Recipe recipe);
        void RemoveRange(IEnumerable<Recipe> recipes);
        IEnumerable<Recipe> GetRecipesTop(int pageIndex, int pageSize);
    }
}
