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
        public enum IncludeAddress { Yes, No };
        public enum SendCopy { Yes, No };

        public int VendorId { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="product">Product to order</param>
        /// <param name="quantity">Quantity of the product to order</param>
        /// <param name="deliverBy"> RequestbDelivery Date</param>
        /// <param name="Instructions">Delivery Instructions</param>
        /// <returns></returns>
        public OperationResult PlaceOrder(Product product, int quantity, DateTimeOffset? deliverBy = null, string instructions = "Standart delivery")
        {

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
        /// <summary>
        /// send a product oredr to the vendor
        /// </summary>
        /// <param name="product">Product to order</param>
        /// <param name="quantity">Quantity of the product to order</param>
        /// <param name="includeAddress">True to include the shipping address</param>
        /// <param name="sendCopy">True to send a copy of the enmail of the current</param>
        /// <returns success flag and order text></returns>

        public OperationResult placeOrder(Product product, int quantity, IncludeAddress includeAddress, SendCopy sendCopy)
        {
            var orderText = "Test";
            if (includeAddress == IncludeAddress.Yes) orderText += " With Address";
            if (sendCopy == SendCopy.No) orderText += " With Copy";
            var operationalResult = new OperationResult(true, orderText);
            return operationalResult;
        }


    }
}
