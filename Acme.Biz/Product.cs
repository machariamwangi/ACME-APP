using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    /// <summary>
    /// Manages products carried in inventory.
    /// </summary>
    public class Product
    {
        public Product()
        {
            Console.WriteLine("Product instance created");
        }
        public Product(int productId,
                        string productName,
                        string description) : this()
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Description = description;

            Console.WriteLine("Product instance has a name: " +
                                ProductName);
        }
        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        private string description;

        public decimal Cost { get; set; }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private int productId;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        //  private Vendor productVendor;
        public Vendor productVendor
        {
            get
            {
                if (productVendor == null)
                {
                    productVendor = new Vendor();
                }
                return productVendor;
            }
            set { productVendor = value; }
        }
        internal string Category { get; set; }
        public int SequenceNumber { get; set; } = 1;
        public string ProductCode => this.Category + "-" + this.SequenceNumber;
        public string ValidationMessage { get; private set; }
        /// <summary>
        /// Calculate the suggested Retail price
        /// </summary>
        /// <param name="markupPercent">Percentage Used to mark up the cost</param>
        /// <returns></returns>
        public decimal CalculateSuggestedPrice(decimal markupPercent) => this.Cost + (this.Cost * markupPercent / 100);

        public string SayHello() => "Hello " + ProductName +
                    " (" + ProductId + "): " +
                    Description;
        /**/
        public override string ToString() => this.ProductName + "(" + this.productId + ")";


    }
}
