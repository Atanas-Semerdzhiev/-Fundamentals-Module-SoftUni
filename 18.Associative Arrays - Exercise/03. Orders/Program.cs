namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, double[]> addThisProducts = new Dictionary<string, double[]>();
            string[] inputOrders = Console.ReadLine().Split(" ");
           string product = inputOrders[0];
            while (product != "buy")
            {
             
              
                 double[] priceInfo =   { double.Parse(inputOrders[1]), double.Parse(inputOrders[2]) };
            
                  
                if(!addThisProducts.ContainsKey(product))
                {
                    addThisProducts.Add(product,priceInfo );
                }
                else if(addThisProducts.ContainsKey(product))
                {
                    addThisProducts[product][0] = priceInfo[0];
                    addThisProducts[product][1] += priceInfo[1];
                }
                 inputOrders = Console.ReadLine().Split(" ");
                product = inputOrders[0];
            }
            foreach (var item in addThisProducts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]:f2}");
            }
         


        }
    }
}