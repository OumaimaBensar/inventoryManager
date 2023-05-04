using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Inventory_M.Models.users_management;

namespace Inventory_M.Models
{
    public class Record
    {
        [Key]
        public int Id { get; set; }
        public string PCODE { get; set; }
        public string Description { get; set; }
        public int Qty { get; set; }
        public int TotalSales { get; set; }
        public DateTime Date { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
        public float Total { get; set; }
        public int Barcode { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public int ReOrder { get; set; }
        public int StockOnHand { get; set; }
        public int TransNo { get; set; }
        public string VoidBy { get; set; }
        public string CancelledBy { get; set; }
        public string Reason { get; set; }
        public string Action { get; set; }
        public int Ref { get; set; }
        public DateTime StockInDate { get; set; }
        public string StockInBy { get; set; }




    }
}