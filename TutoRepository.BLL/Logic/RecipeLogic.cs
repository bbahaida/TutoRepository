using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TutoRepository.Repository;

namespace TutoRepository.BLL.Logic
{
    public class RecipeLogic : IRecipeLogic
    {
        private IRecipeRepository _repository;
        public RecipeLogic(IRecipeRepository repository)
        {
            _repository = repository;
        }
        public void Add(Recipe recipe)
        {
            _repository.Add(recipe);
        }

        public void AddRange(IEnumerable<Recipe> recipes)
        {
            _repository.AddRange(recipes);
        }

        public IEnumerable<Recipe> Find(Expression<Func<Recipe, bool>> predicate)
        {
            return _repository.Find(predicate);
        }

        public Recipe Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Recipe> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Recipe> GetRecipesTop(int pageIndex, int pageSize)
        {
            return _repository.GetRecipesTop(pageIndex,pageSize);
        }

        public void Remove(Recipe recipe)
        {
            _repository.Remove(recipe);
        }

        public void RemoveRange(IEnumerable<Recipe> recipes)
        {
            _repository.RemoveRange(recipes);
        }
    }
}
