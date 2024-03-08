class Program
{
    public static void Main(string[] args)
    {
        var array = new int[3];
        
        try
        {
            for (int i = 0; i < 10; i++)
            {
                // System.IndexOutOfRangeException
                Console.WriteLine(array[i]);
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine("Não encontrei o índice");
        }
        
        catch(Exception ex)
        {
            Console.Write("Ops, deu errado!");   
        }


    }

    public class MinhaException : Exception
    {
        public DateTime WhatTime { get; set; }
    }

}
