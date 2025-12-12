using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inventory.Models;
using Microsoft.EntityFrameworkCore;

namespace inventory.Data.config
{
    public class PurchaseConfiguration:IEntityTypeConfiguration<Purchase>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Purchase> builder)
        {
           builder.HasKey(p=>p.PurchaseId);
           
           builder.HasData(loadPurchase());
        }
       private List<Purchase> loadPurchase()
{
    List<Purchase> purchases = new List<Purchase>()
    {
        new Purchase
        {
            PurchaseId = "5035f91e-4a29-411a-8779-17f6105675f1",
            ProductId = "d35623ee-bef6-42b2-8776-2f99f8bb4782",
            Timestamp = DateTime.Parse("2007-09-28T13:56:51Z"),
            Quantity = 875,
            UnitCost = 4163.31m,
            TotalCost = 7871.43m
        },
        new Purchase
        {
            PurchaseId = "85841cb5-2132-40f2-b923-9769ee3c199b",
            ProductId = "8ac1ac77-7358-425e-be16-0bdde9f02e59",
            Timestamp = DateTime.Parse("2015-02-01T13:04:43Z"),
            Quantity = 471,
            UnitCost = 5673.17m,
            TotalCost = 485.48m
        },
        new Purchase
        {
            PurchaseId = "de384851-f898-4495-99b8-73448bb470bf",
            ProductId = "1afc136b-4d9f-4e8e-aace-8e1df908a404",
            Timestamp = DateTime.Parse("2010-10-22T19:38:20Z"),
            Quantity = 37,
            UnitCost = 3835.06m,
            TotalCost = 4202.25m
        },
        new Purchase
        {
            PurchaseId = "e0b0486c-6396-42b7-9a84-e21bd3a88600",
            ProductId = "af84cc12-4fea-4f58-aece-f2ce92ca9580",
            Timestamp = DateTime.Parse("2020-01-25T13:30:58Z"),
            Quantity = 201,
            UnitCost = 1822.27m,
            TotalCost = 8028.29m
        },
        new Purchase
        {
            PurchaseId = "822e6025-e582-4e8c-b143-dc5ebad4c18c",
            ProductId = "86e3bb1c-2f5d-4774-98f3-4df7cddd0a0f",
            Timestamp = DateTime.Parse("2011-12-30T12:54:41Z"),
            Quantity = 789,
            UnitCost = 9238.02m,
            TotalCost = 5086.57m
        },
        new Purchase
        {
            PurchaseId = "dd6d3a14-92d5-40f4-9bf4-92fb4043882c",
            ProductId = "26b017c6-06d8-443f-9b4a-d6b1cee6f4c0",
            Timestamp = DateTime.Parse("2014-02-26T01:13:31Z"),
            Quantity = 251,
            UnitCost = 2443.32m,
            TotalCost = 9520.42m
        },
        new Purchase
        {
            PurchaseId = "434e5415-cb23-4170-b1e7-bc85737dc8c7",
            ProductId = "440c9e80-6bf8-4eb3-b2d2-f81936d67de3",
            Timestamp = DateTime.Parse("2001-11-18T23:49:33Z"),
            Quantity = 418,
            UnitCost = 5085.79m,
            TotalCost = 5394.89m
        },
        new Purchase
        {
            PurchaseId = "963a92ab-e092-4f3d-8b6a-5ab803550d78",
            ProductId = "98255f4e-40a6-470f-89a5-0792729f8947",
            Timestamp = DateTime.Parse("2020-04-27T08:53:44Z"),
            Quantity = 926,
            UnitCost = 8626.52m,
            TotalCost = 3526.35m
        },
        new Purchase
        {
            PurchaseId = "b4aebfdc-bce9-4e90-89fc-5098447d687a",
            ProductId = "2a339fb2-f9f3-43bc-a85a-b217a0a38f12",
            Timestamp = DateTime.Parse("2020-02-05T13:02:55Z"),
            Quantity = 754,
            UnitCost = 9052.79m,
            TotalCost = 8035.97m
        },
        new Purchase
        {
            PurchaseId = "de2ba6a2-c291-4a60-aad1-23d5749c5847",
            ProductId = "8a8391b2-b4ac-4847-b652-66ffd8d65875",
            Timestamp = DateTime.Parse("2020-05-07T16:41:13Z"),
            Quantity = 365,
            UnitCost = 1105.02m,
            TotalCost = 361.77m
        },
        new Purchase
        {
            PurchaseId = "78ea5f20-8fcc-4b6c-836f-e4b7a58d7479",
            ProductId = "be2157fb-7454-405e-9511-bf7ba81b7726",
            Timestamp = DateTime.Parse("2014-08-12T16:37:41Z"),
            Quantity = 975,
            UnitCost = 4783.47m,
            TotalCost = 9517.85m
        },
        new Purchase
        {
            PurchaseId = "61ba57e9-81fe-4d04-85b5-6aab219ced9d",
            ProductId = "fdf1ba3d-fa06-4ce5-90ff-d081c5d37176",
            Timestamp = DateTime.Parse("2008-12-07T16:18:59Z"),
            Quantity = 286,
            UnitCost = 6910.82m,
            TotalCost = 9006.07m
        },
        new Purchase
        {
            PurchaseId = "012d028b-4d6b-43bf-8d69-edf296133c9e",
            ProductId = "afded6df-058f-477d-9878-e0e0b1d3dff3",
            Timestamp = DateTime.Parse("2005-12-29T10:50:55Z"),
            Quantity = 71,
            UnitCost = 4058.81m,
            TotalCost = 5983.42m
        },
        new Purchase
        {
            PurchaseId = "8155b76c-3da2-4fb4-ba18-68bf8a2cec1b",
            ProductId = "daa29167-82a7-474b-9687-b8b903e7ec69",
            Timestamp = DateTime.Parse("2007-08-15T18:41:49Z"),
            Quantity = 963,
            UnitCost = 2198.44m,
            TotalCost = 4935.68m
        },
        new Purchase
        {
            PurchaseId = "4d449c76-ee8a-473e-8135-f74875a31964",
            ProductId = "ccb83982-71f3-4497-bad8-7e64c6920dc6",
            Timestamp = DateTime.Parse("2014-12-05T06:28:48Z"),
            Quantity = 614,
            UnitCost = 6565.99m,
            TotalCost = 6406.98m
        },
        new Purchase
        {
            PurchaseId = "115c6e6c-e6d0-418f-990e-1730f9e4b02e",
            ProductId = "1936d406-e89e-40e4-bff7-1827532269d4",
            Timestamp = DateTime.Parse("2003-12-17T12:52:02Z"),
            Quantity = 193,
            UnitCost = 2562.72m,
            TotalCost = 788.08m
        }
    };

    return purchases;
}

    }
}