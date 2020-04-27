namespace Full_GRASP_And_SOLID.Library
{

/* Utilizo Patrón Polymorfism para que el codigo no varie segun el destino, la interfase es el molde para imprimir y el codigo que varia esta en 
las diferentes clases que imprimen (ej PrintFile O PrintConsole) con una operación polimórfica. Para eso definimos un tipo IPrinter
*/
    public interface IPrinter
        {
            void PrintRecipe(Recipe recipe);

        }
}