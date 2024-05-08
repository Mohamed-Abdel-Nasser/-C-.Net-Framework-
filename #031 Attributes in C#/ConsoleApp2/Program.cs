namespace ConsoleApp2
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    namespace CustomAttributesExample
    {
        class Program
        {
            static void Main(string[] args)
            {
                List<Product> products = new List<Product>
            {
                new Product { Name = "Laptop", Price = 1200 },
                new Product { Name = "Smartphone", Price = 800 },
                new Product { Name = "Tablet", Price = 300 },
                new Product { Name = "Camera", Price = 1500 }
            };

                var errors = new List<Error>();
                foreach (var product in products)
                {
                    var properties = product.GetType().GetProperties();
                    foreach (var prop in properties)
                    {
                        var rangeAttribute = prop.GetCustomAttribute<RangeAttribute>();
                        if (rangeAttribute != null)
                        {
                            var value = Convert.ToDecimal(prop.GetValue(product));
                            if (!rangeAttribute.IsValid(value))
                            {
                                errors.Add(new Error(prop.Name,
                                    $"Invalid value. Accepted range is {rangeAttribute.Minimum}-{rangeAttribute.Maximum}."));
                            }
                        }
                    }
                }

                if (errors.Count > 0)
                {
                    Console.WriteLine("Validation errors:");
                    foreach (var error in errors)
                    {
                        Console.WriteLine($"{error}");
                    }
                }
                else
                {
                    Console.WriteLine("All product information is valid.");
                }

                Console.ReadKey();
            }
        }

        public class Product
        {
           


            [Range(nameof(Price), 1, 5000)]
            public string Name { get; set; }  // Name should not have a Range attribute

            [Range(nameof(Price), 1, 5000)]
            public decimal Price { get; set; }
        }

        public class Error
        {
            public string field { get; private set; }
            public string details { get; private set; }

            public Error(string field, string details)
            {
                this.field = field;
                this.details = details;
            }

            public override string ToString()
            {
                return $"{{\"{field}\": \"{details}\"}}";
            }
        }
        public class RangeAttribute : Attribute
        {
            public string Name { get; private set; }
            public decimal Minimum { get; private set; }
            public decimal Maximum { get; private set; }
            public RangeAttribute(string name, int minimum, int maximum)
            {
                this.Name = name;
                this.Minimum = minimum;
                this.Maximum = maximum;
            }
            public bool IsValid(object obj)
            {
                var value = (int)obj;
                return value >= Minimum && value <= Maximum;
            }
        }
    }
}
