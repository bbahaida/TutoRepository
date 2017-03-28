using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoRepository.Repository
{
    public interface IRecipeRepository : IRepository<Recipe>
    {
        IEnumerable<Recipe> GetRecipesTop(int pageIndex, int pageSize);
    }
}
