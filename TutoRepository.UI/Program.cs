
using StructureMap;
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

            IContainer container = Container.For<Resolver>();
            var _bl = container.GetInstance<IRecipeLogic>();
            
            List<Recipe> recipes = _bl.GetAll().ToList();

            foreach (Recipe recipe in recipes)
            {
                Console.WriteLine(recipe.Id.ToString()+" --> "+recipe.Name);
            }
            Console.ReadKey();


        }
    }
}
