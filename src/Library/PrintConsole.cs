using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{

// En esta clase implemento el metodo para que imprima en consola, sin tener que preguntar por el destino, usando la interfase IPrinter
    public class PrintConsole:IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            
                Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}