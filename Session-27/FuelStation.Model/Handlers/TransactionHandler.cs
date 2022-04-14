using FuelStation.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model.Handlers
{
    public class TransactionHandler
    {
        public TransactionHandler()
        {

        }

        public double CalculateNetValue(double quantity, double price)
        {
            if (quantity <= 0) throw new ArgumentException("Quantity must be a non zero positive number");
            if (price <= 0) throw new ArgumentException("Price must be a non zero positive number");
            return quantity * price;
        }

        public double CalculateDiscountValue(double netValue, double discountPercent)
        {
            if (netValue <= 0) throw new ArgumentException("Net Value must be a non zero positive value");
            if (discountPercent < 0) throw new ArgumentException("Discount Percent must not be a negative value");
            return netValue * discountPercent;
        }

        public double CalculateLineTotalValue(double discountValue, double netValue)
        {
            if (discountValue < 0) throw new ArgumentException("Discount value must not be a negative value");
            if (netValue <= 0) throw new ArgumentException("Net Value must be a non zero positive value");
            return netValue - discountValue;
        }
        
        public double CalculateTransactionTotalValue(List<double> linesTotalValues)
        {
            return linesTotalValues.Sum();
        }

        public double ApplyTenPercentDiscount(double netValue, double discount, ItemTypeEnum type)
        {
            if (netValue <= 0) throw new ArgumentException("Net Value must be a non zero positive value");
            if (type == ItemTypeEnum.Fuel && netValue > 20)
            {
                return netValue * discount;
            }
            return 0;
        }

        public bool CheckFuelExist(List<TransactionLine> transactionLines)
        {
            foreach (var line in transactionLines)
            {
                if (line.Item?.ItemType == ItemTypeEnum.Fuel)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckCardPaymentAvail(double totalValue)
        {
            if (totalValue < 0) throw new ArgumentException("Total Value must be a positive number");
            if (totalValue > 50)
                return false;
            return true;
        }
    }
}
