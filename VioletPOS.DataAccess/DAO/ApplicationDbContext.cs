using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VioletPOS.Share.DataModels;

namespace VioletPOS.DataAccess.DAO
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> db) : base(db)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=Franco;Database=VioletPOSDB;User Id=sa;Password=sasa");
        //}

        public DbSet<CustomerEntity> Customers { get; set; }

        public DbSet<EmployeeEntity> Employees { get; set; }

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<OrderItemEntity> OrderItems { get; set; }
        public DbSet<PaymentEntity> Payments { get; set; }
        public DbSet<TableEntity> Tables { get; set; }
        public DbSet<ReservationEntity> Reservations { get; set; }
        public DbSet<InventoryEntity> Inventories { get; set; }
        public DbSet<SupplierEntity> Suppliers { get; set; }
        public DbSet<OrderItemOptionEntity> OrderItemsOption { get; set; }
        public DbSet<KitchenOrderEntity> KitchenOrders { get; set; }
        public DbSet<KitchenOrderItemEntity> KitchenOrderItems { get; set; }
        public DbSet<PromotionEntity> Promotions { get; set; }
        public DbSet<PromotionProductEntity> PromotionProducts { get; set; }
        public DbSet<MenuEntity> Menus { get; set; }
        public DbSet<MenuItemEntity> MenuItems { get; set; }
        public DbSet<MenuItemOptionEntity> MenuItemOptions { get; set; }
        public DbSet<IngredientEntity> Ingredients { get; set; }
        public DbSet<IngredientInventoryEntity> IngredientInventories { get; set; }
        public DbSet<OrderPromotionEntity> OrderPromotions { get; set; }
        public DbSet<DiscountEntity> Discounts { get; set; }
        public DbSet<DiscountProductEntity> DiscountProducts { get; set; }
        public DbSet<ReservationLogEntity> ReservationLogs { get; set; }
        public DbSet<TableStatusLogEntity> TableStatusLogs { get; set; }
        public DbSet<EmployeeScheduleEntity> EmployeeSchedules { get; set; }
        public DbSet<ShiftLogEntity> ShiftLogs { get; set; }
        public DbSet<StockAdjustmentEntity> StockAdjustments { get; set; }
        public DbSet<StockAdjustmentReasonEntity> StockAdjustmentReasons { get; set; }
        public DbSet<EmployeeSalaryEntity> EmployeeSalaries { get; set; }
        public DbSet<ExpenseEntity> Expenses { get; set; }
        public DbSet<ExpenseCategoryEntity> ExpenseCategories { get; set; }
        public DbSet<TaxEntity> Taxes { get; set; }
        public DbSet<OrderTaxEntity> OrderTaxes { get; set; }
        public DbSet<ReservationStatusEntity> ReservationStatuses { get; set; }
        public DbSet<TableStatusEntity> TableStatuses { get; set; }
        public DbSet<EmployeePositionEntity> EmployeePositions { get; set; }
        public DbSet<ExpenseTypeEntity> ExpenseTypes { get; set; }
        public DbSet<ShiftTypeEntity> ShiftTypes { get; set; }
        public DbSet<InventoryStatusEntity> InventoryStatuses { get; set; }
        public DbSet<SupplierStatusEntity> SupplierStatuses { get; set; }

    }
}
