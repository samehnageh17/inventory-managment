using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace inventory.Migrations
{
    /// <inheritdoc />
    public partial class secondMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Products",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price", "Rating", "StockQuantity" },
                values: new object[,]
                {
                    { "000a8c23-5bca-436c-a216-4e747a94c511", "Yew Plum Pine", 196.27m, 1.6m, 967173 },
                    { "0114d5d4-ae48-46fa-b0ca-afe60eb88add", "Field Brome", 664.2m, 0.13m, 363992 },
                    { "07238d8e-0037-4972-87ca-0df206ee3e42", "Palmleaf Poppymallow", 22.99m, 3.42m, 635344 },
                    { "0c3e80ee-59b3-4fc4-b760-8b07acc2d3ae", "Lindley's Clerodendrum", 51.66m, 1.53m, 263383 },
                    { "154b7860-23a2-4564-ad99-1745ab7122ef", "Guayanan Waterclover", 45.45m, 0.34m, 456487 },
                    { "1936d406-e89e-40e4-bff7-1827532269d4", "Columbia Milkvetch", 845.15m, 2.21m, 631658 },
                    { "1afc136b-4d9f-4e8e-aace-8e1df908a404", "Rocky Mountain Zinnia", 264.37m, 3.23m, 842192 },
                    { "1d6df6e3-b7ea-4507-9d66-87c6ee8ed5b9", "Lobelia", 163.6m, 0.81m, 341530 },
                    { "25d01c80-bca1-4a00-b1d0-0fbd39ff9e89", "Simpson's Rosinweed", 184.41m, 1.98m, 953695 },
                    { "26b017c6-06d8-443f-9b4a-d6b1cee6f4c0", "Common Brighteyes", 435.44m, 0.27m, 124068 },
                    { "2a339fb2-f9f3-43bc-a85a-b217a0a38f12", "Hamatocaulis Moss", 639.9m, 1.17m, 754285 },
                    { "2be5b024-2c96-4f29-912c-c6f36353f799", "Strigose Beard Lichen", 373.81m, 1.06m, 35383 },
                    { "440c9e80-6bf8-4eb3-b2d2-f81936d67de3", "Vermejo Phlox", 759.15m, 2.46m, 234525 },
                    { "86e3bb1c-2f5d-4774-98f3-4df7cddd0a0f", "Saline Phlox", 82.62m, 4.8m, 601208 },
                    { "8a8391b2-b4ac-4847-b652-66ffd8d65875", "Wax Myrtle", 62.95m, 4.6m, 205240 },
                    { "8ac1ac77-7358-425e-be16-0bdde9f02e59", "Gila Milkvetch", 899.05m, 3.56m, 799402 },
                    { "8d15de86-0e4a-4414-9166-7a33610202d3", "Clamshell Orchid", 17.1m, 0.79m, 604774 },
                    { "8d4bf814-65d4-4df4-84cc-68911d925fdf", "Emory's Acacia", 847.6m, 1.79m, 638956 },
                    { "98255f4e-40a6-470f-89a5-0792729f8947", "Purple Marshlocks", 974.99m, 4.82m, 739009 },
                    { "9d5fafbc-312b-47e8-ada1-283918f0c3b5", "Yellowturbans", 564.82m, 4.74m, 33021 },
                    { "a52bf1bd-3d35-4cd2-849a-354e3952e2d2", "American Century Plant", 969.47m, 3.66m, 248630 },
                    { "af84cc12-4fea-4f58-aece-f2ce92ca9580", "Guadalupe Suncup", 555.93m, 4.09m, 236333 },
                    { "afded6df-058f-477d-9878-e0e0b1d3dff3", "Smooth Phlox", 575.6m, 4.38m, 673658 },
                    { "be2157fb-7454-405e-9511-bf7ba81b7726", "Thladiantha", 699.0m, 1.65m, 399124 },
                    { "c5b600dc-6bfb-492a-b335-c3cc8c707959", "Thimbleberry", 602.37m, 0.13m, 162208 },
                    { "c849a535-5f8b-47e3-889c-015693a644ac", "Girdlepod", 880.09m, 1.49m, 65457 },
                    { "ccb83982-71f3-4497-bad8-7e64c6920dc6", "Globe Fimbry", 304.69m, 2.62m, 388596 },
                    { "d35623ee-bef6-42b2-8776-2f99f8bb4782", "Pinkscale Blazing Star", 456.04m, 2.25m, 124834 },
                    { "d8f5bee3-f3eb-4071-a124-6b857e0fd798", "Arizonia Dry Rock Moss", 746.88m, 4.71m, 616812 },
                    { "daa29167-82a7-474b-9687-b8b903e7ec69", "Lemmon's Beggarticks", 492.35m, 1.07m, 205143 },
                    { "e5b0da8c-148d-4680-b262-8609fb8a10da", "Pentas", 685.1m, 1.5m, 635092 },
                    { "ea8fd0b9-c2d9-4d43-9c23-44cb99d079bb", "Fourleaf Mare's-tail", 905.04m, 3.71m, 909107 },
                    { "fc4c81e5-f1ac-40f5-8c6f-da3fbad5599d", "Chickenthief", 100.11m, 0.49m, 896782 },
                    { "fcf2e432-62a3-4b6f-a34d-36e42a12272e", "Mad River Fleabane", 669.97m, 1.34m, 880242 },
                    { "fdf1ba3d-fa06-4ce5-90ff-d081c5d37176", "Common Tarweed", 899.61m, 2.39m, 196884 }
                });

            migrationBuilder.InsertData(
                table: "Purchases",
                columns: new[] { "PurchaseId", "ProductId", "Quantity", "Timestamp", "TotalCost", "UnitCost" },
                values: new object[,]
                {
                    { "012d028b-4d6b-43bf-8d69-edf296133c9e", "afded6df-058f-477d-9878-e0e0b1d3dff3", 71, new DateTime(2005, 12, 29, 12, 50, 55, 0, DateTimeKind.Local), 5983.42m, 4058.81m },
                    { "115c6e6c-e6d0-418f-990e-1730f9e4b02e", "1936d406-e89e-40e4-bff7-1827532269d4", 193, new DateTime(2003, 12, 17, 14, 52, 2, 0, DateTimeKind.Local), 788.08m, 2562.72m },
                    { "434e5415-cb23-4170-b1e7-bc85737dc8c7", "440c9e80-6bf8-4eb3-b2d2-f81936d67de3", 418, new DateTime(2001, 11, 19, 1, 49, 33, 0, DateTimeKind.Local), 5394.89m, 5085.79m },
                    { "4d449c76-ee8a-473e-8135-f74875a31964", "ccb83982-71f3-4497-bad8-7e64c6920dc6", 614, new DateTime(2014, 12, 5, 8, 28, 48, 0, DateTimeKind.Local), 6406.98m, 6565.99m },
                    { "5035f91e-4a29-411a-8779-17f6105675f1", "d35623ee-bef6-42b2-8776-2f99f8bb4782", 875, new DateTime(2007, 9, 28, 15, 56, 51, 0, DateTimeKind.Local), 7871.43m, 4163.31m },
                    { "61ba57e9-81fe-4d04-85b5-6aab219ced9d", "fdf1ba3d-fa06-4ce5-90ff-d081c5d37176", 286, new DateTime(2008, 12, 7, 18, 18, 59, 0, DateTimeKind.Local), 9006.07m, 6910.82m },
                    { "78ea5f20-8fcc-4b6c-836f-e4b7a58d7479", "be2157fb-7454-405e-9511-bf7ba81b7726", 975, new DateTime(2014, 8, 12, 19, 37, 41, 0, DateTimeKind.Local), 9517.85m, 4783.47m },
                    { "8155b76c-3da2-4fb4-ba18-68bf8a2cec1b", "daa29167-82a7-474b-9687-b8b903e7ec69", 963, new DateTime(2007, 8, 15, 21, 41, 49, 0, DateTimeKind.Local), 4935.68m, 2198.44m },
                    { "822e6025-e582-4e8c-b143-dc5ebad4c18c", "86e3bb1c-2f5d-4774-98f3-4df7cddd0a0f", 789, new DateTime(2011, 12, 30, 14, 54, 41, 0, DateTimeKind.Local), 5086.57m, 9238.02m },
                    { "85841cb5-2132-40f2-b923-9769ee3c199b", "8ac1ac77-7358-425e-be16-0bdde9f02e59", 471, new DateTime(2015, 2, 1, 15, 4, 43, 0, DateTimeKind.Local), 485.48m, 5673.17m },
                    { "963a92ab-e092-4f3d-8b6a-5ab803550d78", "98255f4e-40a6-470f-89a5-0792729f8947", 926, new DateTime(2020, 4, 27, 10, 53, 44, 0, DateTimeKind.Local), 3526.35m, 8626.52m },
                    { "b4aebfdc-bce9-4e90-89fc-5098447d687a", "2a339fb2-f9f3-43bc-a85a-b217a0a38f12", 754, new DateTime(2020, 2, 5, 15, 2, 55, 0, DateTimeKind.Local), 8035.97m, 9052.79m },
                    { "dd6d3a14-92d5-40f4-9bf4-92fb4043882c", "26b017c6-06d8-443f-9b4a-d6b1cee6f4c0", 251, new DateTime(2014, 2, 26, 3, 13, 31, 0, DateTimeKind.Local), 9520.42m, 2443.32m },
                    { "de2ba6a2-c291-4a60-aad1-23d5749c5847", "8a8391b2-b4ac-4847-b652-66ffd8d65875", 365, new DateTime(2020, 5, 7, 18, 41, 13, 0, DateTimeKind.Local), 361.77m, 1105.02m },
                    { "de384851-f898-4495-99b8-73448bb470bf", "1afc136b-4d9f-4e8e-aace-8e1df908a404", 37, new DateTime(2010, 10, 22, 21, 38, 20, 0, DateTimeKind.Local), 4202.25m, 3835.06m },
                    { "e0b0486c-6396-42b7-9a84-e21bd3a88600", "af84cc12-4fea-4f58-aece-f2ce92ca9580", 201, new DateTime(2020, 1, 25, 15, 30, 58, 0, DateTimeKind.Local), 8028.29m, 1822.27m }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "ProductId", "Quantity", "Timestamp", "TotalAmount", "UnitPrice" },
                values: new object[,]
                {
                    { "022fe7a7-3938-4f41-9f56-f9e0a797f00f", "afded6df-058f-477d-9878-e0e0b1d3dff3", 107, new DateTime(2023, 6, 27, 15, 9, 45, 0, DateTimeKind.Local), 3915.37m, 891.26m },
                    { "1d9c4316-ed1a-49c5-a9ed-71a9fc8aff1c", "2a339fb2-f9f3-43bc-a85a-b217a0a38f12", 482, new DateTime(2023, 11, 8, 20, 16, 52, 0, DateTimeKind.Local), 894.41m, 83.62m },
                    { "4411942c-1d3e-42b1-89bd-a692c43185b4", "440c9e80-6bf8-4eb3-b2d2-f81936d67de3", 607, new DateTime(2023, 6, 17, 22, 16, 31, 0, DateTimeKind.Local), 3293.73m, 100.77m },
                    { "4fca2797-3e88-40c5-88d3-fd4df8744958", "1afc136b-4d9f-4e8e-aace-8e1df908a404", 699, new DateTime(2023, 11, 21, 17, 3, 18, 0, DateTimeKind.Local), 4708.54m, 550.22m },
                    { "5ab2a0f1-2248-4804-9bf0-219d8a30b076", "ccb83982-71f3-4497-bad8-7e64c6920dc6", 339, new DateTime(2023, 3, 18, 3, 14, 42, 0, DateTimeKind.Local), 3694.96m, 662.74m },
                    { "85460f0a-83d5-45b5-8db0-42506e0c5739", "98255f4e-40a6-470f-89a5-0792729f8947", 93, new DateTime(2024, 1, 12, 18, 37, 28, 0, DateTimeKind.Local), 5531.81m, 310.09m },
                    { "8d008094-bbb7-4b6f-a38c-0e2a9905322d", "8ac1ac77-7358-425e-be16-0bdde9f02e59", 241, new DateTime(2023, 8, 17, 22, 53, 36, 0, DateTimeKind.Local), 5661.25m, 414.68m },
                    { "94a6ad98-8efe-4aef-bf19-742a542cf790", "8a8391b2-b4ac-4847-b652-66ffd8d65875", 285, new DateTime(2023, 12, 22, 0, 49, 11, 0, DateTimeKind.Local), 3738.87m, 76.09m },
                    { "a3659c0d-ccc6-4903-b035-6f13e7778253", "1936d406-e89e-40e4-bff7-1827532269d4", 71, new DateTime(2023, 11, 5, 2, 17, 48, 0, DateTimeKind.Local), 2535.36m, 529.95m },
                    { "ae6a3d09-fdf8-407b-9e55-07a347c87efa", "af84cc12-4fea-4f58-aece-f2ce92ca9580", 182, new DateTime(2023, 5, 17, 23, 20, 3, 0, DateTimeKind.Local), 9419.4m, 113.69m },
                    { "b9c0856c-d10f-47a1-bf05-2f2c400aff69", "26b017c6-06d8-443f-9b4a-d6b1cee6f4c0", 985, new DateTime(2023, 10, 27, 20, 59, 51, 0, DateTimeKind.Local), 1790.08m, 506.74m },
                    { "bc6fbde5-325d-4918-b8d9-36d8a7be769f", "fdf1ba3d-fa06-4ce5-90ff-d081c5d37176", 286, new DateTime(2024, 3, 1, 19, 35, 27, 0, DateTimeKind.Local), 3328.18m, 246.58m },
                    { "cff83ef4-6b2c-4ad4-b550-929e0eb3fa93", "be2157fb-7454-405e-9511-bf7ba81b7726", 219, new DateTime(2023, 11, 21, 17, 3, 43, 0, DateTimeKind.Local), 8773.57m, 606.43m },
                    { "df8a03fa-c69c-4ffe-9e28-5febfb7a5ca9", "d35623ee-bef6-42b2-8776-2f99f8bb4782", 229, new DateTime(2023, 11, 2, 6, 3, 0, 0, DateTimeKind.Local), 8012.55m, 221.1m },
                    { "e6fc26ef-50e8-4983-a7e0-f2cbf32d32ef", "daa29167-82a7-474b-9687-b8b903e7ec69", 195, new DateTime(2023, 7, 6, 5, 50, 19, 0, DateTimeKind.Local), 725.11m, 809.59m },
                    { "f4dced2f-4446-450b-9778-fd32fe4dc583", "86e3bb1c-2f5d-4774-98f3-4df7cddd0a0f", 863, new DateTime(2023, 6, 14, 18, 17, 34, 0, DateTimeKind.Local), 8942.2m, 214.01m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "000a8c23-5bca-436c-a216-4e747a94c511");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "0114d5d4-ae48-46fa-b0ca-afe60eb88add");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "07238d8e-0037-4972-87ca-0df206ee3e42");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "0c3e80ee-59b3-4fc4-b760-8b07acc2d3ae");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "154b7860-23a2-4564-ad99-1745ab7122ef");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "1d6df6e3-b7ea-4507-9d66-87c6ee8ed5b9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "25d01c80-bca1-4a00-b1d0-0fbd39ff9e89");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "2be5b024-2c96-4f29-912c-c6f36353f799");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "8d15de86-0e4a-4414-9166-7a33610202d3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "8d4bf814-65d4-4df4-84cc-68911d925fdf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "9d5fafbc-312b-47e8-ada1-283918f0c3b5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "a52bf1bd-3d35-4cd2-849a-354e3952e2d2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "c5b600dc-6bfb-492a-b335-c3cc8c707959");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "c849a535-5f8b-47e3-889c-015693a644ac");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "d8f5bee3-f3eb-4071-a124-6b857e0fd798");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "e5b0da8c-148d-4680-b262-8609fb8a10da");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "ea8fd0b9-c2d9-4d43-9c23-44cb99d079bb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "fc4c81e5-f1ac-40f5-8c6f-da3fbad5599d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "fcf2e432-62a3-4b6f-a34d-36e42a12272e");

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "012d028b-4d6b-43bf-8d69-edf296133c9e");

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "115c6e6c-e6d0-418f-990e-1730f9e4b02e");

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "434e5415-cb23-4170-b1e7-bc85737dc8c7");

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "4d449c76-ee8a-473e-8135-f74875a31964");

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "5035f91e-4a29-411a-8779-17f6105675f1");

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "61ba57e9-81fe-4d04-85b5-6aab219ced9d");

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "78ea5f20-8fcc-4b6c-836f-e4b7a58d7479");

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "8155b76c-3da2-4fb4-ba18-68bf8a2cec1b");

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "822e6025-e582-4e8c-b143-dc5ebad4c18c");

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "85841cb5-2132-40f2-b923-9769ee3c199b");

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "963a92ab-e092-4f3d-8b6a-5ab803550d78");

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "b4aebfdc-bce9-4e90-89fc-5098447d687a");

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "dd6d3a14-92d5-40f4-9bf4-92fb4043882c");

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "de2ba6a2-c291-4a60-aad1-23d5749c5847");

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "de384851-f898-4495-99b8-73448bb470bf");

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "e0b0486c-6396-42b7-9a84-e21bd3a88600");

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: "022fe7a7-3938-4f41-9f56-f9e0a797f00f");

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: "1d9c4316-ed1a-49c5-a9ed-71a9fc8aff1c");

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: "4411942c-1d3e-42b1-89bd-a692c43185b4");

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: "4fca2797-3e88-40c5-88d3-fd4df8744958");

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: "5ab2a0f1-2248-4804-9bf0-219d8a30b076");

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: "85460f0a-83d5-45b5-8db0-42506e0c5739");

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: "8d008094-bbb7-4b6f-a38c-0e2a9905322d");

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: "94a6ad98-8efe-4aef-bf19-742a542cf790");

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: "a3659c0d-ccc6-4903-b035-6f13e7778253");

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: "ae6a3d09-fdf8-407b-9e55-07a347c87efa");

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: "b9c0856c-d10f-47a1-bf05-2f2c400aff69");

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: "bc6fbde5-325d-4918-b8d9-36d8a7be769f");

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: "cff83ef4-6b2c-4ad4-b550-929e0eb3fa93");

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: "df8a03fa-c69c-4ffe-9e28-5febfb7a5ca9");

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: "e6fc26ef-50e8-4983-a7e0-f2cbf32d32ef");

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: "f4dced2f-4446-450b-9778-fd32fe4dc583");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "1936d406-e89e-40e4-bff7-1827532269d4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "1afc136b-4d9f-4e8e-aace-8e1df908a404");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "26b017c6-06d8-443f-9b4a-d6b1cee6f4c0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "2a339fb2-f9f3-43bc-a85a-b217a0a38f12");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "440c9e80-6bf8-4eb3-b2d2-f81936d67de3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "86e3bb1c-2f5d-4774-98f3-4df7cddd0a0f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "8a8391b2-b4ac-4847-b652-66ffd8d65875");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "8ac1ac77-7358-425e-be16-0bdde9f02e59");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "98255f4e-40a6-470f-89a5-0792729f8947");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "af84cc12-4fea-4f58-aece-f2ce92ca9580");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "afded6df-058f-477d-9878-e0e0b1d3dff3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "be2157fb-7454-405e-9511-bf7ba81b7726");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "ccb83982-71f3-4497-bad8-7e64c6920dc6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "d35623ee-bef6-42b2-8776-2f99f8bb4782");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "daa29167-82a7-474b-9687-b8b903e7ec69");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "fdf1ba3d-fa06-4ce5-90ff-d081c5d37176");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
