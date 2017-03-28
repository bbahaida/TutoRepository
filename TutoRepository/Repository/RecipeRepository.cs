using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoRepository.Repository
{
    public class RecipeRepository : Repository<Recipe>, IRecipeRepository
    {

        public RecipesEntities RecipeContext
        {
            get { return Context as RecipesEntities; }
        }
        public RecipeRepository(RecipesEntities Context) : base(Context)
        {
            
        }

        public IEnumerable<Recipe> GetRecipesTop(int pageIndex, int pageSize)
        {
            return RecipeContext.Recipes.OrderBy(e=>e.Id).Skip((pageIndex - 1) * pageSize).Take(pageSize).AsEnumerable();
        }
    }
}
