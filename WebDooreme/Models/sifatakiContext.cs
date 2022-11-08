using Microsoft.EntityFrameworkCore;

namespace WebDooreme.Models
{
    public partial class sifatakiContext : DbContext
    {
        public sifatakiContext(DbContextOptions<sifatakiContext> options)
    : base(options)
        {
        }
        public virtual DbSet<Basket> Baskets { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<DisCount> DisCounts { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<ExchangeRate> ExchangeRates { get; set; }
        public virtual DbSet<Faq> Faqs { get; set; }
        public virtual DbSet<Institutional> Institutionals { get; set; }
        public virtual DbSet<MailList> MailLists { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MemberDetail> MemberDetails { get; set; }
        public virtual DbSet<Metum> Meta { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Outlet> Outlets { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Reference> Reference { get; set; }
        public virtual DbSet<ReferansTable> ReferansTables { get; set; }
        public virtual DbSet<Revenue> Revenues { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<SubCategoryClass> SubCategoryClasses { get; set; }
        public virtual DbSet<Survey> Surveys { get; set; }
        public virtual DbSet<Technical> Technicals { get; set; }
        public virtual DbSet<Temp> Temps { get; set; }
        public virtual DbSet<Visitor> Visitors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Basket>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Basket");

                entity.Property(e => e.BasketDate).HasColumnType("smalldatetime");

                entity.Property(e => e.BasketId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("BasketID");

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.Property(e => e.StockCode).HasMaxLength(100);

                entity.Property(e => e.TotalPrice).HasColumnType("money");

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.ToTable("Blog");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.MetaDesc).HasMaxLength(160);

                entity.Property(e => e.MetaKeywords).HasMaxLength(260);

                entity.Property(e => e.MetaTitle).HasMaxLength(70);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CommentDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CommentDetail).HasColumnType("text");

                entity.Property(e => e.CommentId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CommentID");

                entity.Property(e => e.CommentMail).HasMaxLength(50);

                entity.Property(e => e.CommentName).HasMaxLength(100);

                entity.Property(e => e.ProductName).HasMaxLength(50);
            });

            modelBuilder.Entity<DisCount>(entity =>
            {
                entity.ToTable("DisCount");

                entity.Property(e => e.Explanation).HasMaxLength(500);

                entity.Property(e => e.Features).HasMaxLength(50);

                entity.Property(e => e.Features2).HasMaxLength(50);

                entity.Property(e => e.Features3).HasMaxLength(50);

                entity.Property(e => e.Features4).HasMaxLength(50);

                entity.Property(e => e.Features5).HasMaxLength(50);

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.StockCode).HasMaxLength(50);
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.Property(e => e.Aimages).HasColumnName("AImages");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ExchangeRate>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DollarPrice).HasColumnType("money");

                entity.Property(e => e.EuroPrice).HasColumnType("money");

                entity.Property(e => e.ExchangeDay).HasColumnType("smalldatetime");

                entity.Property(e => e.ExchangeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ExchangeID");
            });

            modelBuilder.Entity<Faq>(entity =>
            {
                entity.ToTable("Faq");
            });

            modelBuilder.Entity<Institutional>(entity =>
            {
                entity.ToTable("Institutional");

                entity.Property(e => e.Tİtle).HasMaxLength(50);
            });

            modelBuilder.Entity<MailList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MailList", "sifataki");

                entity.Property(e => e.MailAddress).HasMaxLength(50);

                entity.Property(e => e.MailId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("MailID");

                entity.Property(e => e.MailName).HasMaxLength(50);
            });

            modelBuilder.Entity<Mark>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Marks", "sifataki");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.MarkId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("MarkID");

                entity.Property(e => e.MarkName).HasMaxLength(50);
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.MemberName).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<MemberDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FirstVisit).HasColumnType("smalldatetime");

                entity.Property(e => e.LastVisit).HasColumnType("smalldatetime");

                entity.Property(e => e.MemberAddress).HasColumnType("text");

                entity.Property(e => e.MemberBirthday).HasColumnType("smalldatetime");

                entity.Property(e => e.MemberCity).HasMaxLength(50);

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.MemberName).HasMaxLength(100);

                entity.Property(e => e.MemberSemt).HasMaxLength(50);

                entity.Property(e => e.MemberTaxOffice).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.Member)
                    .WithMany()
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MemberDetails_Members");
            });

            modelBuilder.Entity<Metum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Meta", "sifataki");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Keywords).HasColumnType("text");

                entity.Property(e => e.MetaId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("MetaID");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.NewsDate).HasColumnType("smalldatetime");

                entity.Property(e => e.NewsDetails).HasColumnType("text");

                entity.Property(e => e.NewsId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NewsID");

                entity.Property(e => e.NewsImage).HasMaxLength(100);

                entity.Property(e => e.NewsName).HasMaxLength(50);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DeliveryTime).HasMaxLength(50);

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.MemberName).HasMaxLength(100);

                entity.Property(e => e.OrderAddress).HasColumnType("text");

                entity.Property(e => e.OrderCargoFirm).HasMaxLength(50);

                entity.Property(e => e.OrderCity).HasMaxLength(50);

                entity.Property(e => e.OrderGsm).HasMaxLength(50);

                entity.Property(e => e.OrderGsmCode).HasMaxLength(50);

                entity.Property(e => e.OrderId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("OrderID");

                entity.Property(e => e.OrderNote).HasColumnType("text");

                entity.Property(e => e.OrderNumber).HasMaxLength(50);

                entity.Property(e => e.OrderPaymentType).HasMaxLength(50);

                entity.Property(e => e.OrderSemt).HasMaxLength(50);

                entity.Property(e => e.OrderTel).HasMaxLength(50);

                entity.Property(e => e.OrderTelCode).HasMaxLength(50);

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.Property(e => e.TaxNumber).HasMaxLength(50);

                entity.Property(e => e.TaxOffice).HasMaxLength(50);

                entity.Property(e => e.TotalPrice).HasColumnType("money");

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<Outlet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Outlets", "sifataki");

                entity.Property(e => e.OutletAddress).HasColumnType("text");

                entity.Property(e => e.OutletAuth).HasMaxLength(100);

                entity.Property(e => e.OutletCity).HasMaxLength(50);

                entity.Property(e => e.OutletFax).HasMaxLength(50);

                entity.Property(e => e.OutletFaxCode).HasMaxLength(10);

                entity.Property(e => e.OutletId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("OutletID");

                entity.Property(e => e.OutletMail).HasMaxLength(50);

                entity.Property(e => e.OutletMapCode).HasColumnType("text");

                entity.Property(e => e.OutletName).HasMaxLength(50);

                entity.Property(e => e.OutletSemt).HasMaxLength(50);

                entity.Property(e => e.OutletTel).HasMaxLength(50);

                entity.Property(e => e.OutletTelCode).HasMaxLength(10);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.CargoDiamension).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CargoPrice).HasColumnType("money");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.DiscountPrice).HasColumnType("money");

                entity.Property(e => e.DiscountPrice2).HasColumnType("money");

                entity.Property(e => e.DiscountPrice3).HasColumnType("money");

                entity.Property(e => e.Image).HasMaxLength(100);

                entity.Property(e => e.ImageDetails).HasMaxLength(100);

                entity.Property(e => e.InstallmentTable).HasColumnType("text");

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.Keywords).HasMaxLength(100);

                entity.Property(e => e.LastPrice).HasColumnType("money");

                entity.Property(e => e.Mark).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProductDetail).HasColumnType("text");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.ProductWords).HasColumnType("text");

                entity.Property(e => e.RelegatePrice).HasColumnType("money");

                entity.Property(e => e.StockCode).HasMaxLength(50);

                entity.Property(e => e.SubCategoryClassId).HasColumnName("SubCategoryClassID");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.Thumbnail1).HasMaxLength(100);

                entity.Property(e => e.Thumbnail2).HasMaxLength(100);

                entity.Property(e => e.Thumbnail3).HasMaxLength(100);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Products_Categories");

                entity.HasOne(d => d.SubCategoryClass)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.SubCategoryClassId)
                    .HasConstraintName("FK_Products_Subcategoryclass");
            });

            modelBuilder.Entity<Reference>(entity =>
            {
                entity.Property(e => e.ReferenceId).HasColumnName("ReferenceID");

                entity.Property(e => e.ReferenceImage).HasMaxLength(100);

                entity.Property(e => e.ReferenceName).HasMaxLength(100);

                entity.Property(e => e.ReferenceThumb1).HasMaxLength(100);

                entity.Property(e => e.ReferenceThumb2).HasMaxLength(100);

                entity.Property(e => e.ReferenceThumb3).HasMaxLength(100);

                entity.Property(e => e.ReferenceThumb4).HasMaxLength(100);

            });
            modelBuilder.Entity<ReferansTable>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.Company).HasMaxLength(100);

                entity.Property(e => e.Province).HasMaxLength(100);

                entity.Property(e => e.District).HasMaxLength(100);

            });


            modelBuilder.Entity<Revenue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Revenues", "sifataki");

                entity.Property(e => e.MemberName).HasMaxLength(100);

                entity.Property(e => e.RevenueId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RevenueID");

                entity.Property(e => e.RevenuePoint).HasMaxLength(50);

                entity.Property(e => e.RevenueType).HasMaxLength(50);

                entity.Property(e => e.RevenueValue).HasColumnType("money");
            });

            modelBuilder.Entity<Slider>(entity =>
            {
                entity.Property(e => e.SiderId).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.MetaDesc).HasMaxLength(160);

                entity.Property(e => e.MetaKeywords).HasMaxLength(260);

                entity.Property(e => e.MetaTitle).HasMaxLength(70);

                entity.Property(e => e.SubCategoryId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SubCategoryID");

                entity.Property(e => e.SubCategoryName).HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany()
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Subcategories_Categories");
            });

            modelBuilder.Entity<SubCategoryClass>(entity =>
            {
                entity.ToTable("SubCategoryClass");

                entity.Property(e => e.SubCategoryClassId).HasColumnName("SubCategoryClassID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.SubClassName).HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SubCategoryClasses)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Subcategoryclass_Categories");
            });

            modelBuilder.Entity<Survey>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SurveyId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SurveyID");

                entity.Property(e => e.SurveyName).HasMaxLength(50);

                entity.Property(e => e.SurveyQuestion1).HasMaxLength(50);

                entity.Property(e => e.SurveyQuestion2).HasMaxLength(50);

                entity.Property(e => e.SurveyQuestion3).HasMaxLength(50);

                entity.Property(e => e.SurveyQuestion4).HasMaxLength(50);

                entity.Property(e => e.SurveyQuestion5).HasMaxLength(50);
            });

            modelBuilder.Entity<Technical>(entity =>
            {
                entity.ToTable("Technical");

                entity.Property(e => e.Aimages2).HasColumnName("AImages2");

                entity.Property(e => e.Aimages3).HasColumnName("AImages3");

                entity.Property(e => e.Aimages4).HasColumnName("AImages4");

                entity.Property(e => e.Title2).HasMaxLength(100);

                entity.Property(e => e.Tİtle).HasMaxLength(100);
            });

            modelBuilder.Entity<Temp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp", "sifataki");

                entity.Property(e => e.CargoDiamension).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CargoPrice).HasColumnType("money");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.DiscountPrice).HasColumnType("money");

                entity.Property(e => e.DiscountPrice2).HasColumnType("money");

                entity.Property(e => e.DiscountPrice3).HasColumnType("money");

                entity.Property(e => e.Image).HasMaxLength(100);

                entity.Property(e => e.ImageDetails).HasMaxLength(100);

                entity.Property(e => e.InstallmentTabel).HasColumnType("text");

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.Keywords).HasColumnType("text");

                entity.Property(e => e.LastPrice).HasColumnType("money");

                entity.Property(e => e.Mark).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProductDetail).HasColumnType("text");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.Property(e => e.ProductWords).HasColumnType("text");

                entity.Property(e => e.RelegatePrice).HasColumnType("money");

                entity.Property(e => e.StockCode).HasMaxLength(50);

                entity.Property(e => e.SubCategoryClassId).HasColumnName("SubCategoryClassID");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

                entity.Property(e => e.Thumbnail1).HasMaxLength(100);

                entity.Property(e => e.Thumbnail2).HasMaxLength(100);

                entity.Property(e => e.Thumbnail3).HasMaxLength(100);
            });

            modelBuilder.Entity<Visitor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Visitors", "sifataki");

                entity.Property(e => e.VisitDate).HasColumnType("datetime");

                entity.Property(e => e.VisitorId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("VisitorID");

                entity.Property(e => e.VisitorIp).HasMaxLength(20);

                entity.Property(e => e.VisitorLocation).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");
        //    modelBuilder.Entity<Basket>(entity =>
        //    {
        //        entity.Property(e => e.BasketId).ValueGeneratedOnAdd();
        //    });
        //    modelBuilder.Entity<Comment>(entity =>
        //    {
        //        entity.Property(e => e.CommentId).ValueGeneratedOnAdd();
        //    });
        //    modelBuilder.Entity<ExchangeRate>(entity =>
        //    {
        //        entity.Property(e => e.ExchangeId).ValueGeneratedOnAdd();
        //    });
        //    modelBuilder.Entity<MailList>(entity =>
        //    {
        //        entity.Property(e => e.MailId).ValueGeneratedOnAdd();
        //    });
        //    modelBuilder.Entity<Mark>(entity =>
        //    {
        //        entity.Property(e => e.MarkId).ValueGeneratedOnAdd();
        //    });
        //    modelBuilder.Entity<MemberDetail>(entity =>
        //    {
        //        entity.HasOne(d => d.Member)
        //            .WithMany()
        //            .HasForeignKey(d => d.MemberId)
        //            .OnDelete(DeleteBehavior.Cascade)
        //            .HasConstraintName("FK_MemberDetails_Members");
        //    });
        //    modelBuilder.Entity<Metum>(entity =>
        //    {
        //        entity.Property(e => e.MetaId).ValueGeneratedOnAdd();
        //    });
        //    modelBuilder.Entity<News>(entity =>
        //    {
        //        entity.Property(e => e.NewsId).ValueGeneratedOnAdd();
        //    });
        //    modelBuilder.Entity<Order>(entity =>
        //    {
        //        entity.Property(e => e.OrderId).ValueGeneratedOnAdd();
        //    });
        //    modelBuilder.Entity<Outlet>(entity =>
        //    {
        //        entity.Property(e => e.OutletId).ValueGeneratedOnAdd();
        //    });
        //    modelBuilder.Entity<Product>(entity =>
        //    {
        //        entity.HasOne(d => d.Category)
        //            .WithMany(p => p.Products)
        //            .HasForeignKey(d => d.CategoryId)
        //            .OnDelete(DeleteBehavior.Cascade)
        //            .HasConstraintName("FK_Products_Categories");
        //        entity.HasOne(d => d.SubCategoryClass)
        //            .WithMany(p => p.Products)
        //            .HasForeignKey(d => d.SubCategoryClassId)
        //            .HasConstraintName("FK_Products_Subcategoryclass");
        //    });
        //    modelBuilder.Entity<Revenue>(entity =>
        //    {
        //        entity.Property(e => e.RevenueId).ValueGeneratedOnAdd();
        //    });
        //    modelBuilder.Entity<Slider>(entity =>
        //    {
        //        entity.Property(e => e.SiderId).ValueGeneratedOnAdd();
        //    });
        //    modelBuilder.Entity<SubCategory>(entity =>
        //    {
        //        entity.Property(e => e.SubCategoryId).ValueGeneratedOnAdd();
        //        entity.HasOne(d => d.Category)
        //            .WithMany()
        //            .HasForeignKey(d => d.CategoryId)
        //            .OnDelete(DeleteBehavior.Cascade)
        //            .HasConstraintName("FK_Subcategories_Categories");
        //    });
        //    modelBuilder.Entity<SubCategoryClass>(entity =>
        //    {
        //        entity.HasOne(d => d.Category)
        //            .WithMany(p => p.SubCategoryClasses)
        //            .HasForeignKey(d => d.CategoryId)
        //            .HasConstraintName("FK_Subcategoryclass_Categories");
        //    });
        //    modelBuilder.Entity<Survey>(entity =>
        //    {
        //        entity.Property(e => e.SurveyId).ValueGeneratedOnAdd();
        //    });
        //    modelBuilder.Entity<Visitor>(entity =>
        //    {
        //        entity.Property(e => e.VisitorId).ValueGeneratedOnAdd();
        //    });
        //    OnModelCreatingPartial(modelBuilder);
        //}
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
