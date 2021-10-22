using System;
using System.Collections.Generic;
using System.IO;
using Solid_Principles.DEPENDENCY_INVERSION;
using Solid_Principles.INTERFACE_SEGREGATION_PRINCIPLE;
using Solid_Principles.LISKOVE_SUBSITUTION_PRINCIPLE;
using Solid_Principles.OPEN_CLONE_PRINCIPLE;
using Solid_Principles.SINGLE_RESPONSIBILITY_PRINCIPLE;

namespace Solid_Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Single Responsibility Principle ----------------------------------------------------------
            #region 

            var j = new Journal();
            j.AddEntry("I cried today.");
            j.AddEntry("I ate a bug.");


            // Wrong
            // j.Save("");

            // True way 
            new PersistenceManager().SaveToFile<Journal>(j , "fileURL" , true );
            #endregion
            // Open-Close Principle ---------------------------------------------------------------------
            #region 
            
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = {apple, tree, house};
            var pf = new ProductFilter();
            Console.WriteLine("Green products:");
            
            foreach (var p in pf.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($" - {p.Name} is Green");
            }

            foreach (var p in pf.FilterBySize(products, Size.Large))
            {
                Console.WriteLine($" - {p.Name} is Green");
            }

            foreach (var p in pf.FilterBySizeAndColor(products, Size.Large , Color.Green))
            {
                Console.WriteLine($" - {p.Name} is Larg & Green");
            }


            var bf = new BetterFilter();
            Console.WriteLine("Green products (new):");
            foreach( var p in bf.Filter(products , new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($" - {p.Name} is  Green");
            }    

            Console.WriteLine("Large blue items");
            foreach( var p in bf.Filter(
                products,
                new AndSpecification<Product>(new ColorSpecification(Color.Blue) , new SizeSpecification(Size.Large))))
            {
                Console.WriteLine($" - {p.Name} is Large & Blue");
            }

            #endregion
            // Liskove Subsitution Principle ------------------------------------------------------------
            #region 
            Rectangle rc = new Rectangle(2,3);
            Console.WriteLine($"{rc} has area {Operation.Area(rc)}" );

            Rectangle sq = new Square();
            sq.Width = 4 ;
            Console.WriteLine($"{sq} has area {Operation.Area(sq)}");
            #endregion   
            // Interface Segregation -------------------------------------------------------------------
            #region 
            
            Document document = new Document("Historical Stories");
            MultiFunctionMachine mF = new MultiFunctionMachine(new printer() , new scanner());

            mF.Print(document);
            mF.scan(document);

            #endregion
            // Dependency Inversion --------------------------------------------------------------------
            #region 
            INotification smsNotif = new SmsNotification();
            INotification emailNotif = new EmailNotification();

            
            DatabaseManager db = new DatabaseManager(smsNotif);
            //DatabaseManager db = new DatabaseManager(emailNotif);

            db.Add();
            db.Remove();
            db.Update();

            #endregion
        
        }


       
    }
}
