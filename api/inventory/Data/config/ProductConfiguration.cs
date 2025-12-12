using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using inventory.Models;

namespace inventory.Data.config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(p => p.Rating).HasColumnType("decimal(5,2)");
            builder.HasData(loadProducts());
        }

        private static List<Product> loadProducts()
        {
            return new List<Product>
            {
                new Product { ProductId = "d35623ee-bef6-42b2-8776-2f99f8bb4782", Name = "Pinkscale Blazing Star", Price = 456.04m, Rating = 2.25m, StockQuantity = 124834 },
                new Product { ProductId = "8ac1ac77-7358-425e-be16-0bdde9f02e59", Name = "Gila Milkvetch", Price = 899.05m, Rating = 3.56m, StockQuantity = 799402 },
                new Product { ProductId = "1afc136b-4d9f-4e8e-aace-8e1df908a404", Name = "Rocky Mountain Zinnia", Price = 264.37m, Rating = 3.23m, StockQuantity = 842192 },
                new Product { ProductId = "af84cc12-4fea-4f58-aece-f2ce92ca9580", Name = "Guadalupe Suncup", Price = 555.93m, Rating = 4.09m, StockQuantity = 236333 },
                new Product { ProductId = "86e3bb1c-2f5d-4774-98f3-4df7cddd0a0f", Name = "Saline Phlox", Price = 82.62m, Rating = 4.8m, StockQuantity = 601208 },
                new Product { ProductId = "26b017c6-06d8-443f-9b4a-d6b1cee6f4c0", Name = "Common Brighteyes", Price = 435.44m, Rating = 0.27m, StockQuantity = 124068 },
                new Product { ProductId = "440c9e80-6bf8-4eb3-b2d2-f81936d67de3", Name = "Vermejo Phlox", Price = 759.15m, Rating = 2.46m, StockQuantity = 234525 },
                new Product { ProductId = "98255f4e-40a6-470f-89a5-0792729f8947", Name = "Purple Marshlocks", Price = 974.99m, Rating = 4.82m, StockQuantity = 739009 },
                new Product { ProductId = "2a339fb2-f9f3-43bc-a85a-b217a0a38f12", Name = "Hamatocaulis Moss", Price = 639.9m, Rating = 1.17m, StockQuantity = 754285 },
                new Product { ProductId = "8a8391b2-b4ac-4847-b652-66ffd8d65875", Name = "Wax Myrtle", Price = 62.95m, Rating = 4.6m, StockQuantity = 205240 },
                new Product { ProductId = "be2157fb-7454-405e-9511-bf7ba81b7726", Name = "Thladiantha", Price = 699.0m, Rating = 1.65m, StockQuantity = 399124 },
                new Product { ProductId = "fdf1ba3d-fa06-4ce5-90ff-d081c5d37176", Name = "Common Tarweed", Price = 899.61m, Rating = 2.39m, StockQuantity = 196884 },
                new Product { ProductId = "afded6df-058f-477d-9878-e0e0b1d3dff3", Name = "Smooth Phlox", Price = 575.6m, Rating = 4.38m, StockQuantity = 673658 },
                new Product { ProductId = "daa29167-82a7-474b-9687-b8b903e7ec69", Name = "Lemmon's Beggarticks", Price = 492.35m, Rating = 1.07m, StockQuantity = 205143 },
                new Product { ProductId = "ccb83982-71f3-4497-bad8-7e64c6920dc6", Name = "Globe Fimbry", Price = 304.69m, Rating = 2.62m, StockQuantity = 388596 },
                new Product { ProductId = "1936d406-e89e-40e4-bff7-1827532269d4", Name = "Columbia Milkvetch", Price = 845.15m, Rating = 2.21m, StockQuantity = 631658 },
                new Product { ProductId = "c849a535-5f8b-47e3-889c-015693a644ac", Name = "Girdlepod", Price = 880.09m, Rating = 1.49m, StockQuantity = 65457 },
                new Product { ProductId = "0c3e80ee-59b3-4fc4-b760-8b07acc2d3ae", Name = "Lindley's Clerodendrum", Price = 51.66m, Rating = 1.53m, StockQuantity = 263383 },
                new Product { ProductId = "d8f5bee3-f3eb-4071-a124-6b857e0fd798", Name = "Arizonia Dry Rock Moss", Price = 746.88m, Rating = 4.71m, StockQuantity = 616812 },
                new Product { ProductId = "8d15de86-0e4a-4414-9166-7a33610202d3", Name = "Clamshell Orchid", Price = 17.1m, Rating = 0.79m, StockQuantity = 604774 },
                new Product { ProductId = "ea8fd0b9-c2d9-4d43-9c23-44cb99d079bb", Name = "Fourleaf Mare's-tail", Price = 905.04m, Rating = 3.71m, StockQuantity = 909107 },
                new Product { ProductId = "25d01c80-bca1-4a00-b1d0-0fbd39ff9e89", Name = "Simpson's Rosinweed", Price = 184.41m, Rating = 1.98m, StockQuantity = 953695 },
                new Product { ProductId = "1d6df6e3-b7ea-4507-9d66-87c6ee8ed5b9", Name = "Lobelia", Price = 163.6m, Rating = 0.81m, StockQuantity = 341530 },
                new Product { ProductId = "000a8c23-5bca-436c-a216-4e747a94c511", Name = "Yew Plum Pine", Price = 196.27m, Rating = 1.6m, StockQuantity = 967173 },
                new Product { ProductId = "c5b600dc-6bfb-492a-b335-c3cc8c707959", Name = "Thimbleberry", Price = 602.37m, Rating = 0.13m, StockQuantity = 162208 },
                new Product { ProductId = "9d5fafbc-312b-47e8-ada1-283918f0c3b5", Name = "Yellowturbans", Price = 564.82m, Rating = 4.74m, StockQuantity = 33021 },
                new Product { ProductId = "0114d5d4-ae48-46fa-b0ca-afe60eb88add", Name = "Field Brome", Price = 664.2m, Rating = 0.13m, StockQuantity = 363992 },
                new Product { ProductId = "e5b0da8c-148d-4680-b262-8609fb8a10da", Name = "Pentas", Price = 685.1m, Rating = 1.5m, StockQuantity = 635092 },
                new Product { ProductId = "2be5b024-2c96-4f29-912c-c6f36353f799", Name = "Strigose Beard Lichen", Price = 373.81m, Rating = 1.06m, StockQuantity = 35383 },
                new Product { ProductId = "fcf2e432-62a3-4b6f-a34d-36e42a12272e", Name = "Mad River Fleabane", Price = 669.97m, Rating = 1.34m, StockQuantity = 880242 },
                new Product { ProductId = "fc4c81e5-f1ac-40f5-8c6f-da3fbad5599d", Name = "Chickenthief", Price = 100.11m, Rating = 0.49m, StockQuantity = 896782 },
                new Product { ProductId = "07238d8e-0037-4972-87ca-0df206ee3e42", Name = "Palmleaf Poppymallow", Price = 22.99m, Rating = 3.42m, StockQuantity = 635344 },
                new Product { ProductId = "154b7860-23a2-4564-ad99-1745ab7122ef", Name = "Guayanan Waterclover", Price = 45.45m, Rating = 0.34m, StockQuantity = 456487 },
                new Product { ProductId = "8d4bf814-65d4-4df4-84cc-68911d925fdf", Name = "Emory's Acacia", Price = 847.6m, Rating = 1.79m, StockQuantity = 638956 },
                new Product { ProductId = "a52bf1bd-3d35-4cd2-849a-354e3952e2d2", Name = "American Century Plant", Price = 969.47m, Rating = 3.66m, StockQuantity = 248630 }
            };
        }
    }
}
