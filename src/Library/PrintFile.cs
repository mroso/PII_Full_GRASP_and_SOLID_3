using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{

// En esta clase implemento el metodo para que imprima en archivo, sin tener que preguntar por el destino, usando la interfase IPrinter
    public class PrintFile:IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            
                File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}