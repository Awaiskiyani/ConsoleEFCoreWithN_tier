using ConsoleEfCoreWithN_tier_DataAccess.Data;
using EFCoreWithN_tier_Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Security.Cryptography;
using ConsoleEFCoreWithN_tier.Services;
internal class Program
{
    public  static void Main(string[] args)
    {
      
        Service service = new Service();
        service.GetAllBooks();
        Console.WriteLine();
        service.GetBookFirstOrDefault();
        Console.WriteLine();
        service.GetBookByPublisher();
        Console.WriteLine();
        service.GetBookBySeededID();
        Console.WriteLine();
        Console.WriteLine();
        service.GetBookByPubliserIdseededUsingSingle();
        Console.WriteLine();
        service.AddBooks();
        Console.WriteLine();
        service.SortBookUsingOrderBy();
        Console.WriteLine();
        service.sortBookUsingOrderByDescending();








    }
}