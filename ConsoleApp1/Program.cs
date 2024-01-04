// for loop
// using System.Threading.Tasks.Dataflow;

// for (int i = 0; i<=5 ; i++)
// {
//     if (i == 3)
//     {
//     Console.WriteLine(i);
//     }
// }
for (int row = 1; row < 11; row++)
{
  for (char column = 'a'; column < 'k'; column++)
  {
    Console.WriteLine($"The cell is ({row}, {column})");
  }
}