using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace SimpleECommerceApp
{
    // 1. Product Structure
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(int id, string name, double price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        // 9. Strings: Use string interpolation
        public override string ToString() => $"ID: {Id} | Name: {Name} | Price: {Price:C} | Stock: {Quantity}";
    }

    class Program
    {
        // 2. Data Storage using List
        static List<Product> products = new List<Product>();
        static List<Product> cart = new List<Product>();
        static string filePath = "products_data.txt";

        static void Main(string[] args)
        {
            LoadProductsFromFile(); // 10. File Handling (Bonus)

            // 3. Menu System using while loop and switch statement[cite: 1]
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n--- Simple E-Commerce System ---");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View All Products");
                Console.WriteLine("3. Search Product");
                Console.WriteLine("4. Add to Cart");
                Console.WriteLine("5. View Cart");
                Console.WriteLine("6. Checkout");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": AddProduct(); break;
                    case "2": ViewProducts(); break;
                    case "3": SearchMenu(); break;
                    case "4": AddToCartProcess(); break;
                    case "5":
                        Console.WriteLine("\n--- Your Cart ---");
                        ViewCartRecursive(0, 0); break; // 7. Recursion[cite: 1]
                    case "6": Checkout(); break;
                    case "7": running = false; break;
                    default: Console.WriteLine("Invalid input. Try again."); break;
                }
            }
            SaveProductsToFile();
        }

        // 4. Methods: AddProduct()[cite: 1]
        static void AddProduct()
        {
            try // 8. Exception Handling[cite: 1]
            {
                Console.Write("Enter Product ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                // Bonus 4: Validate inputs using Regex[cite: 1]
                if (!Regex.IsMatch(name, @"^[a-zA-Z\s]+$")) throw new Exception("Invalid Name format.");

                Console.Write("Enter Price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Enter Quantity: ");
                int qty = int.Parse(Console.ReadLine());

                products.Add(new Product(id, name, price, qty));
                Console.WriteLine("Product added successfully.");
            }
            catch (Exception ex) { Console.WriteLine($"Error: {ex.Message}"); }
        }

        static void ViewProducts()
        {
            if (products.Count == 0) Console.WriteLine("No products available.");
            products.ForEach(p => Console.WriteLine(p));
        }

        static void SearchMenu()
        {
            Console.WriteLine("Search by: 1. ID  2. Name");
            string mode = Console.ReadLine();
            if (mode == "1")
            {
                Console.Write("Enter ID: ");
                int id = int.Parse(Console.ReadLine());
                // 5. Method Overloading: Searching by Id[cite: 1]
                if (SearchProduct(id, out Product p)) Console.WriteLine(p);
                else Console.WriteLine("Product not found.");
            }
            else
            {
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();
                // 5. Method Overloading: Searching by Name[cite: 1]
                SearchProduct(name);
            }
        }

        // 6. ref / out: Use out in a method that returns a found product[cite: 1]
        static bool SearchProduct(int id, out Product foundProduct)
        {
            foundProduct = products.FirstOrDefault(p => p.Id == id);
            return foundProduct != null;
        }

        // 5. Method Overloading: Search Product(string name)[cite: 1]
        static void SearchProduct(string name)
        {
            var results = products.Where(p => p.Name.ToLower().Contains(name.ToLower())).ToList();
            if (results.Any()) results.ForEach(p => Console.WriteLine(p));
            else Console.WriteLine("No matches found.");
        }

        static void AddToCartProcess()
        {
            try
            {
                Console.Write("Enter Product ID to add: ");
                int id = int.Parse(Console.ReadLine());
                if (SearchProduct(id, out Product p))
                {
                    Console.Write("Enter Quantity: ");
                    int qty = int.Parse(Console.ReadLine());

                    if (p.Quantity >= qty)
                    {
                        // 6. ref / out: Use ref to update product quantity[cite: 1]
                        int currentQty = p.Quantity;
                        UpdateStock(ref currentQty, qty);
                        p.Quantity = currentQty;

                        cart.Add(new Product(p.Id, p.Name, p.Price, qty));
                        Console.WriteLine("Added to cart.");
                    }
                    else throw new Exception("Insufficient quantity!"); // 8. Exception Handling[cite: 1]
                }
                else Console.WriteLine("Product not found.");
            }
            catch (Exception ex) { Console.WriteLine($"Error: {ex.Message}"); }
        }

        static void UpdateStock(ref int stock, int amount) => stock -= amount;

        // 7. Recursion: Display cart items instead of loops[cite: 1]
        static void ViewCartRecursive(int index, double total)
        {
            if (index >= cart.Count)
            {
                Console.WriteLine($"Total Price: {total:C}");
                return;
            }
            var item = cart[index];
            double subtotal = item.Price * item.Quantity;
            Console.WriteLine($"- {item.Name} (x{item.Quantity}): {subtotal:C}");
            ViewCartRecursive(index + 1, total + subtotal);
        }

        static void Checkout()
        {
            if (cart.Count == 0) { Console.WriteLine("Cart is empty."); return; }
            Console.WriteLine("Checking out...");
            ViewCartRecursive(0, 0);
            cart.Clear();
            Console.WriteLine("Thank you for your purchase!");
        }

        // 10. File Handling: Save and load using StreamWriter/Reader[cite: 1]
        static void SaveProductsToFile()
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var p in products)
                    writer.WriteLine($"{p.Id},{p.Name},{p.Price},{p.Quantity}");
            }
        }

        static void LoadProductsFromFile()
        {
            if (!File.Exists(filePath)) return;
            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                products.Add(new Product(int.Parse(parts[0]), parts[1], double.Parse(parts[2]), int.Parse(parts[3])));
            }
        }
    }
}