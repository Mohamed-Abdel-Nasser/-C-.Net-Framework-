namespace ConsoleApp3
{
    using System;
    using System.Collections.Generic;

    namespace CustomAttributesExample
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Create a list of products with prices
                List<Product> products = new List<Product>
            {
                new Product { Name = "Laptop", Price = 1500 },
                new Product { Name = "Smartphone", Price = 800 },
                new Product { Name = "Headphones", Price = 120 },
                new Product { Name = "Tablet", Price = 2500 }
            };

                // Validate each product's price using custom attribute
                var validationErrors = new List<string>();
                foreach (var product in products)
                {
                    var validationResults = ValidateProduct(product);
                    if (validationResults.Count > 0)
                    {
                        validationErrors.AddRange(validationResults);
                    }
                }

                // Display validation results
                if (validationErrors.Count > 0)
                {
                    Console.WriteLine("Validation Errors:");
                    foreach (var error in validationErrors)
                    {
                        Console.WriteLine($"- {error}");
                    }
                }
                else
                {
                    Console.WriteLine("All products are valid.");
                }
            }

            static List<string> ValidateProduct(Product product)
            {
                var errors = new List<string>();
                var properties = typeof(Product).GetProperties();

                foreach (var property in properties)
                {
                    var rangeAttribute = (RangeAttribute)Attribute.GetCustomAttribute(property, typeof(RangeAttribute));
                    if (rangeAttribute != null)
                    {
                        var value = (decimal)property.GetValue(product);
                        if (!rangeAttribute.IsValid(value))
                        {
                            errors.Add($"{product.Name}: {property.Name} value is out of range.");
                        }
                    }
                }

                return errors;
            }
        }

        public class Product
        {
            public string Name { get; set; }

            [Range(100, 2000)]
            public decimal Price { get; set; }
        }

        [AttributeUsage(AttributeTargets.Property)]
        public class RangeAttribute : Attribute
        {
            public decimal Minimum { get;  set; }
            public decimal Maximum { get;  set; }

            public RangeAttribute(decimal minimum, decimal maximum)
            {
                Minimum = minimum;
                Maximum = maximum;
            }

            public bool IsValid(decimal value)
            {
                return value >= Minimum && value <= Maximum;
            }
        }
    }

}
