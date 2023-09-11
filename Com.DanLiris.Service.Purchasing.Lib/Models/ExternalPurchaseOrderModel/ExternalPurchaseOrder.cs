﻿using Com.DanLiris.Service.Purchasing.Lib.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Com.DanLiris.Service.Purchasing.Lib.Models.ExternalPurchaseOrderModel
{
    public class ExternalPurchaseOrder : BaseModel
    {
        [MaxLength(255)]
        public string EPONo { get; set; }

        //Division
        [MaxLength(255)]
        public string DivisionId { get; set; }
        [MaxLength(255)]
        public string DivisionCode { get; set; }
        [MaxLength(1000)]
        public string DivisionName { get; set; }

        //Unit
        [MaxLength(255)]
        public string UnitId { get; set; }
        [MaxLength(255)]
        public string UnitCode { get; set; }
        [MaxLength(1000)]
        public string UnitName { get; set; }

        //Supplier
        [MaxLength(255)]
        public string SupplierId { get; set; }
        [MaxLength(255)]
        public string SupplierCode { get; set; }
        [MaxLength(1000)]
        public string SupplierName { get; set; }

        public DateTimeOffset OrderDate { get; set; }
        public DateTimeOffset DeliveryDate { get; set; }
        public string FreightCostBy { get; set; }

        //Currency
        [MaxLength(255)]
        public string CurrencyId { get; set; }
        [MaxLength(255)]
        public string CurrencyCode { get; set; }
        [MaxLength(1000)]
        public double CurrencyRate { get; set; }

        public string PaymentMethod { get; set; }
        public string PaymentDueDays { get; set; }
        public bool UseIncomeTax { get; set; }

        //IncomeTax
        [MaxLength(255)]
        public string IncomeTaxId { get; set; }
        [MaxLength(255)]
        public string IncomeTaxName { get; set; }
        [MaxLength(1000)]
        public string IncomeTaxRate { get; set; }
        [MaxLength(255)]
        public string IncomeTaxBy { get; set; }

        public bool UseVat { get; set; }
        public bool IsPosted { get; set; }
        public bool IsClosed { get; set; }
        public bool IsCanceled { get; set; }
        public string Remark { get; set; }

        public int VatId { get; set; }
        public double VatRate { get; set; }

        public virtual ICollection<ExternalPurchaseOrderItem> Items { get; set; }
    }
}
