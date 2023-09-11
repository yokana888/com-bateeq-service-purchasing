﻿using Com.DanLiris.Service.Purchasing.Lib.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Com.DanLiris.Service.Purchasing.Lib.Models.GarmentExternalPurchaseOrderModel
{
    public class GarmentExternalPurchaseOrder : BaseModel
    {
        [MaxLength(255)]
        public string EPONo { get; set; }
        [MaxLength(255)]
        public string SupplierName { get; set; }
        [MaxLength(255)]
        public int SupplierId { get; set; }
        [MaxLength(255)]
        public string SupplierCode { get; set; }
        [MaxLength(255)]
        public bool SupplierImport { get; set; }

        public DateTimeOffset OrderDate { get; set; }
        public DateTimeOffset DeliveryDate { get; set; }
        public string FreightCostBy { get; set; }
        public string PaymentType { get; set; }
        public string PaymentMethod { get; set; }
        public int PaymentDueDays { get; set; }
        public int CurrencyId { get; set; }
        public double CurrencyRate { get; set; }
        public string CurrencyCode { get; set; }
        public bool IsIncomeTax { get; set; }

        [MaxLength(255)]
        public string IncomeTaxId { get; set; }
        [MaxLength(255)]
        public string IncomeTaxName { get; set; }
        [MaxLength(1000)]
        public string IncomeTaxRate { get; set; }

        public bool IsUseVat { get; set; }

        public string Category { get; set; }
        public string Remark { get; set; }
        public bool IsPosted { get; set; }
        public bool IsOverBudget { get; set; }
        public bool IsApproved { get; set; }
        public bool IsCanceled { get; set; }
        public bool IsClosed { get; set; }

        //StandardQuality
        [MaxLength(1000)]
        public string QualityStandardType { get; set; }
        [MaxLength(1000)]
        public string Shrinkage { get; set; }
        [MaxLength(1000)]
        public string WetRubbing { get; set; }
        [MaxLength(1000)]
        public string DryRubbing { get; set; }
        [MaxLength(1000)]
        public string Washing { get; set; }
        [MaxLength(1000)]
        public string DarkPerspiration { get; set; }
        [MaxLength(1000)]
        public string LightMedPerspiration { get; set; }
        [MaxLength(1000)]
        public string PieceLength { get; set; }

        public virtual ICollection<GarmentExternalPurchaseOrderItem> Items { get; set; }
    }
}
