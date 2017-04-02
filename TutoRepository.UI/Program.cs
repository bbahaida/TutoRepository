using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoRepository.BLL.Logic;
using TutoRepository.Repository;

namespace TutoRepository.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            // init unity object
            UnityContainer IU = new UnityContainer();

            // register types will be used in injection
            IU.RegisterType<RecipeLogic>();
            IU.RegisterType<RecipeRepository>();

            //
            IU.RegisterType<IRecipeRepository,RecipeRepository>();
            IU.RegisterType<IRecipeLogic, RecipeLogic>();

            IRecipeLogic _bl = IU.Resolve<IRecipeLogic>();


            List<Recipe> recipes = _bl.GetAll().ToList();

            foreach (Recipe recipe in recipes)
            {
                Console.WriteLine(recipe.Id.ToString()+" --> "+recipe.Name);
            }
            Console.ReadKey();


        }
    }
}
