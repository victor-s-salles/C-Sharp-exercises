class Program
{
   

    static void Main(string[] args)
    {
        int[] expensesCost;
        Console.WriteLine("Entre com o número de despesas: ");
        int numberOfExpenses = getNumberOfExpenses();

        for (int i=0; i < numberOfExpenses; i++)
            {
              expensesCost[i] = getExpenseCostFromUser();
            }

        int totalExpenses = 0;

        for (int i = 0; i < numberOfExpenses; i++)
            {
            totalExpenses += expensesCost[i];
            }

        Console.WriteLine("O total das despesas é: " + totalExpenses);
    }



}