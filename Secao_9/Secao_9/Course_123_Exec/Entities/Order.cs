using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Course_123_Exec.Entities.Enums;

namespace Course_123_Exec.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(OrderStatus status, Client client)
        {
            Moment = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach(OrderItem orderItem in Items)
            {
                sum += orderItem.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine("Order status: " + Status.ToString());
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToShortDateString()}) - {Client.Email}");
            sb.AppendLine("Order items:");
            foreach(OrderItem orderItem in Items)
            {
                sb.AppendLine(orderItem.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }

    }
}
