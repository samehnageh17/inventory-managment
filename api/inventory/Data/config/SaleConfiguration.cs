using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inventory.Models;
using Microsoft.EntityFrameworkCore;

namespace inventory.Data.config
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(s=> s.SaleId);
            builder.Property(s => s.UnitPrice).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(s => s.TotalAmount).IsRequired().HasColumnType("decimal(18,2)");
            builder.HasData(LoadSales());
        }
        private static List<Sale> LoadSales()
{
    return new List<Sale>
    {
        new Sale
        {
            SaleId = "df8a03fa-c69c-4ffe-9e28-5febfb7a5ca9",
            ProductId = "d35623ee-bef6-42b2-8776-2f99f8bb4782",
            Timestamp = DateTime.Parse("2023-11-02T04:03:00Z"),
            Quantity = 229,
            UnitPrice = 221.1m,
            TotalAmount = 8012.55m
        },
        new Sale
        {
            SaleId = "8d008094-bbb7-4b6f-a38c-0e2a9905322d",
            ProductId = "8ac1ac77-7358-425e-be16-0bdde9f02e59",
            Timestamp = DateTime.Parse("2023-08-17T19:53:36Z"),
            Quantity = 241,
            UnitPrice = 414.68m,
            TotalAmount = 5661.25m
        },
        new Sale
        {
            SaleId = "4fca2797-3e88-40c5-88d3-fd4df8744958",
            ProductId = "1afc136b-4d9f-4e8e-aace-8e1df908a404",
            Timestamp = DateTime.Parse("2023-11-21T15:03:18Z"),
            Quantity = 699,
            UnitPrice = 550.22m,
            TotalAmount = 4708.54m
        },
        new Sale
        {
            SaleId = "ae6a3d09-fdf8-407b-9e55-07a347c87efa",
            ProductId = "af84cc12-4fea-4f58-aece-f2ce92ca9580",
            Timestamp = DateTime.Parse("2023-05-17T20:20:03Z"),
            Quantity = 182,
            UnitPrice = 113.69m,
            TotalAmount = 9419.4m
        },
        new Sale
        {
            SaleId = "f4dced2f-4446-450b-9778-fd32fe4dc583",
            ProductId = "86e3bb1c-2f5d-4774-98f3-4df7cddd0a0f",
            Timestamp = DateTime.Parse("2023-06-14T15:17:34Z"),
            Quantity = 863,
            UnitPrice = 214.01m,
            TotalAmount = 8942.2m
        },
        new Sale
        {
            SaleId = "b9c0856c-d10f-47a1-bf05-2f2c400aff69",
            ProductId = "26b017c6-06d8-443f-9b4a-d6b1cee6f4c0",
            Timestamp = DateTime.Parse("2023-10-27T18:59:51Z"),
            Quantity = 985,
            UnitPrice = 506.74m,
            TotalAmount = 1790.08m
        },
        new Sale
        {
            SaleId = "4411942c-1d3e-42b1-89bd-a692c43185b4",
            ProductId = "440c9e80-6bf8-4eb3-b2d2-f81936d67de3",
            Timestamp = DateTime.Parse("2023-06-17T19:16:31Z"),
            Quantity = 607,
            UnitPrice = 100.77m,
            TotalAmount = 3293.73m
        },
        new Sale
        {
            SaleId = "85460f0a-83d5-45b5-8db0-42506e0c5739",
            ProductId = "98255f4e-40a6-470f-89a5-0792729f8947",
            Timestamp = DateTime.Parse("2024-01-12T16:37:28Z"),
            Quantity = 93,
            UnitPrice = 310.09m,
            TotalAmount = 5531.81m
        },
        new Sale
        {
            SaleId = "1d9c4316-ed1a-49c5-a9ed-71a9fc8aff1c",
            ProductId = "2a339fb2-f9f3-43bc-a85a-b217a0a38f12",
            Timestamp = DateTime.Parse("2023-11-08T18:16:52Z"),
            Quantity = 482,
            UnitPrice = 83.62m,
            TotalAmount = 894.41m
        },
        new Sale
        {
            SaleId = "94a6ad98-8efe-4aef-bf19-742a542cf790",
            ProductId = "8a8391b2-b4ac-4847-b652-66ffd8d65875",
            Timestamp = DateTime.Parse("2023-12-21T22:49:11Z"),
            Quantity = 285,
            UnitPrice = 76.09m,
            TotalAmount = 3738.87m
        },
        new Sale
        {
            SaleId = "cff83ef4-6b2c-4ad4-b550-929e0eb3fa93",
            ProductId = "be2157fb-7454-405e-9511-bf7ba81b7726",
            Timestamp = DateTime.Parse("2023-11-21T15:03:43Z"),
            Quantity = 219,
            UnitPrice = 606.43m,
            TotalAmount = 8773.57m
        },
        new Sale
        {
            SaleId = "bc6fbde5-325d-4918-b8d9-36d8a7be769f",
            ProductId = "fdf1ba3d-fa06-4ce5-90ff-d081c5d37176",
            Timestamp = DateTime.Parse("2024-03-01T17:35:27Z"),
            Quantity = 286,
            UnitPrice = 246.58m,
            TotalAmount = 3328.18m
        },
        new Sale
        {
            SaleId = "022fe7a7-3938-4f41-9f56-f9e0a797f00f",
            ProductId = "afded6df-058f-477d-9878-e0e0b1d3dff3",
            Timestamp = DateTime.Parse("2023-06-27T12:09:45Z"),
            Quantity = 107,
            UnitPrice = 891.26m,
            TotalAmount = 3915.37m
        },
        new Sale
        {
            SaleId = "e6fc26ef-50e8-4983-a7e0-f2cbf32d32ef",
            ProductId = "daa29167-82a7-474b-9687-b8b903e7ec69",
            Timestamp = DateTime.Parse("2023-07-06T02:50:19Z"),
            Quantity = 195,
            UnitPrice = 809.59m,
            TotalAmount = 725.11m
        },
        new Sale
        {
            SaleId = "5ab2a0f1-2248-4804-9bf0-219d8a30b076",
            ProductId = "ccb83982-71f3-4497-bad8-7e64c6920dc6",
            Timestamp = DateTime.Parse("2023-03-18T01:14:42Z"),
            Quantity = 339,
            UnitPrice = 662.74m,
            TotalAmount = 3694.96m
        },
        new Sale
        {
            SaleId = "a3659c0d-ccc6-4903-b035-6f13e7778253",
            ProductId = "1936d406-e89e-40e4-bff7-1827532269d4",
            Timestamp = DateTime.Parse("2023-11-05T00:17:48Z"),
            Quantity = 71,
            UnitPrice = 529.95m,
            TotalAmount = 2535.36m
        }
    };
}

    }
}