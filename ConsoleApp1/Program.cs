// specify the data source 
int [] scores = [10,20,30,40];
// Define the query expression
IEnumerable<int> scoreQuery = 
 from score in scores
 where score > 80
 select score;
 // Excecute the query
 foreach(var i in scoreQuery)
{
    Console.Write(i + " ");
}



