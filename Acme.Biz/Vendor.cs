using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    /// <summary>
    /// Manages the vendors from whom we purchase our inventory.
    /// </summary>
    public class Vendor
    {

        public int VendorId { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }


        public OperationResult PlaceOrder(Product product, int quantity)
        {
            /**this is a method overloading */
            /* if (product == null) throw new ArgumentNullException(nameof(product));
             if (quantity <= 0) throw new ArgumentOutOfRangeException(nameof(quantity));
             var success = false;
             var orderText = "Order from Acme, Inc" + System.Environment.NewLine + "Product: " + product.ProductName + System.Environment.NewLine + "Quantity: " + quantity;
             var emailService = new EmailService();
             var confirmation = emailService.SendMessage("New Order", orderText, this.Email);
             if (confirmation.StartsWith("Message sent:"))
             {
                 success = true;
             }
             var operationalResult = new OperationResult(success, orderText);
             return operationalResult;
            */

            /*This is method chaining*/

            return PlaceOrder(product, quantity, null, null);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="product">Product to order</param>
        /// <param name="quantity">Quantity of the product to order</param>
        /// <param name="deliverBy"> RequestbDelivery Date</param>
        /// <returns></returns>
        public OperationResult PlaceOrder(Product product, int quantity, DateTimeOffset? deliverBy)
        {
            /* This is method overloading */
            /*
            if (product == null) throw new ArgumentNullException(nameof(product));
            if (quantity <= 0) throw new ArgumentOutOfRangeException(nameof(quantity));
            if (deliverBy <= DateTimeOffset.Now) throw new ArgumentOutOfRangeException(nameof(deliverBy));
            var success = false;
            var orderText = "Order from Acme, Inc" + System.Environment.NewLine + "Product: " + product.ProductName + System.Environment.NewLine + "Quantity: " + quantity;
            if (deliverBy.HasValue)
            {
                orderText += System.Environment.NewLine + "DeliverBy: " + deliverBy.Value.ToString("d");
            }
            var emailService = new EmailService();
            var confirmation = emailService.SendMessage("New Order", orderText, this.Email);
            if (confirmation.StartsWith("Message sent:"))
            {
                success = true;
            }
            var operationalResult = new OperationResult(success, orderText);
            return operationalResult;
            */
            /*This is Method chaining*/
            return PlaceOrder(product, quantity, deliverBy, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="product">Product to order</param>
        /// <param name="quantity">Quantity of the product to order</param>
        /// <param name="deliverBy"> RequestbDelivery Date</param>
        /// <param name="Instructions">Delivery Instructions</param>
        /// <returns></returns>
        public OperationResult PlaceOrder(Product product, int quantity, DateTimeOffset? deliverBy, string instructions)
        {
            /*This is method Overloading*/
            /*
            if (product == null) throw new ArgumentNullException(nameof(product));
            if (quantity <= 0) throw new ArgumentOutOfRangeException(nameof(quantity));
            if (deliverBy <= DateTimeOffset.Now) throw new ArgumentOutOfRangeException(nameof(deliverBy));

            var success = false;
            var orderText = "Order from Acme, Inc" + System.Environment.NewLine + "Product: " + product.ProductName + System.Environment.NewLine + "Quantity: " + quantity;
            if (deliverBy.HasValue)
            {
                orderText += System.Environment.NewLine + "DeliverBy: " + deliverBy.Value.ToString("d");
            }
            if (!String.IsNullOrWhiteSpace(instructions))
            {
                orderText += System.Environment.NewLine + "Instructions: " + instructions;
            }
            var emailService = new EmailService();
            var confirmation = emailService.SendMessage("New Order", orderText, this.Email);
            if (confirmation.StartsWith("Message sent:"))
            {
                success = true;
            }
            var operationalResult = new OperationResult(success, orderText);
            return operationalResult;
            */
            /*This is method chaining*/
            return PlaceOrder(product, quantity, deliverBy, instructions);
        }



        /// <summary>
        /// Sends an email to welcome a new vendor.
        /// </summary>
        /// <returns></returns>
        public string SendWelcomeEmail(string message)
        {
            var emailService = new EmailService();
            var subject = ("Hello " + this.CompanyName).Trim();
            var confirmation = emailService.SendMessage(subject,
                                                        message,
                                                        this.Email);
            return confirmation;
        }
    }
}
