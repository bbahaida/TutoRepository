using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoRepository.Repository;

namespace TutoRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            IRecipeRepository _repository = new RecipeRepository(new RecipesEntities());

            List<Recipe> recipes = _repository.GetAll().ToList();
            Console.WriteLine("______________GetAll_______________");
            foreach (Recipe r in recipes)
            {
                Console.WriteLine(r.Id.ToString()+" --> "+r.Name);
            }
            Console.ReadKey();
            _repository.Add(new Recipe { Name = "Felafel"});
            Console.WriteLine("______________Add then GetAll_______________");
            recipes = _repository.GetAll().ToList();
            foreach (Recipe r in recipes)
            {
                Console.WriteLine(r.Id.ToString() + " --> " + r.Name);
            }
            Console.ReadKey();
            _repository.Remove(_repository.Get(3));
            Console.WriteLine("______________Remove then GetAll_______________");
            recipes = _repository.GetAll().ToList();
            foreach (Recipe r in recipes)
            {
                Console.WriteLine(r.Id.ToString() + " --> " + r.Name);
            }
            Console.ReadKey();
            recipes = _repository.GetRecipesTop(1,2).ToList();
            Console.WriteLine("______________Paging_______________");

            foreach (Recipe r in recipes)
            {
                Console.WriteLine(r.Id.ToString() + " --> " + r.Name);
            }
            Console.ReadKey();
        }
    }
}
